// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk
{
    using System.Globalization;
    using System.Linq.Expressions;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Source representation of operation inputs lambda expressions. Holds literal values or source programs (source segments + bindings to workflow context).
    /// </summary>
    internal abstract class WorkflowExpression
    {
        internal abstract JToken LiteralToken { get; }
        internal abstract string Render();

        internal static WorkflowExpression<T> Literal<T>(T value) =>
            new WorkflowExpression<T>(Serialize(value), null);

        internal static WorkflowExpression<T> Create<T>(SourceProgram program) =>
            new WorkflowExpression<T>(null, program ?? throw new ArgumentNullException(nameof(program)));

        internal static WorkflowExpression<T> Compile<T>(
            Expression<Func<T>> expression,
            string parameterName,
            bool required)
        {
            if (expression == null)
            {
                if (required) throw new ArgumentNullException(parameterName);
                return null;
            }

            if (!WorkflowExpressionTypePolicy.IsAnonymous(typeof(T)))
                WorkflowExpressionTypePolicy.Validate(typeof(T));

            var isLiteral = CapturedValueReader.TryRead(expression.Body, out var literal) &&
                (literal == null || CanUseLiteral(typeof(T)));

            var descriptor = isLiteral
                ? Literal((T)literal)
                : Create<T>(new WorkflowExpressionVisitor().Visit(expression.Body));

            if (required && descriptor.LiteralToken?.Type == JTokenType.Null)
                throw new ArgumentException("A required workflow value cannot be null.", parameterName);

            return descriptor;
        }

        private static bool CanUseLiteral(Type type) =>
            type.IsPrimitive && !type.IsEnum ||
            type == typeof(string) ||
            type == typeof(decimal);

        internal static JToken Serialize(object value)
        {
            if (value == null) return JValue.CreateNull();
            if (value is double number && (double.IsNaN(number) || double.IsInfinity(number)) ||
                value is float single && (float.IsNaN(single) || float.IsInfinity(single)))
                throw new NotSupportedException("Non-finite values cannot be workflow literals.");
            if (value is Uri uri) return new JValue(uri.OriginalString);
            if (value is HttpMethod method) return new JValue(method.Method);
            if (value is byte[] bytes)
                return new JObject { ["$content-type"] = "application/octet-stream", ["$content"] = Convert.ToBase64String(bytes) };
            var serializer = new JsonSerializer { Culture = CultureInfo.InvariantCulture, TypeNameHandling = TypeNameHandling.None };
            serializer.Converters.Add(new StringEnumConverter());
            return JToken.FromObject(value, serializer);
        }
    }

    internal sealed class WorkflowExpression<T> : WorkflowExpression
    {
        private readonly JToken literal;
        private readonly SourceProgram program;

        internal WorkflowExpression(JToken literal, SourceProgram program)
        {
            this.literal = literal;
            this.program = program;
        }

        internal override JToken LiteralToken => this.literal?.DeepClone();

        internal override string Render()
        {
            if (this.literal != null) throw new InvalidOperationException("A literal has no source program.");
            return this.program.Render();
        }
    }

    /// <summary>
    /// Immutable C# source segments interleaved with late-bound workflow references.
    /// </summary>
    internal sealed class SourceProgram
    {
        private readonly string[] segments;
        private readonly WorkflowExpressionBinding[] bindings;

        private SourceProgram(string[] segments, WorkflowExpressionBinding[] bindings)
        {
            if (segments == null || bindings == null || segments.Length != bindings.Length + 1 ||
                segments.Any(segment => segment == null) || bindings.Any(binding => binding == null))
                throw new ArgumentException("A source program needs one more non-null segment than bindings.");

            this.segments = segments;
            this.bindings = bindings;
        }

        internal static SourceProgram Text(string text) =>
            new SourceProgram(new[] { text ?? throw new ArgumentNullException(nameof(text)) }, Array.Empty<WorkflowExpressionBinding>());

        internal static SourceProgram Binding(WorkflowExpressionBinding binding) =>
            new SourceProgram(
                new[] { string.Empty, string.Empty },
                new[] { binding ?? throw new ArgumentNullException(nameof(binding)) });

        internal static SourceProgram Concat(params SourceProgram[] programs) =>
            Concat((IEnumerable<SourceProgram>)programs);

        internal static SourceProgram Concat(IEnumerable<SourceProgram> programs)
        {
            if (programs == null) throw new ArgumentNullException(nameof(programs));
            var segments = new List<string> { string.Empty };
            var bindings = new List<WorkflowExpressionBinding>();
            foreach (var program in programs)
            {
                if (program == null) throw new ArgumentException("Source programs cannot contain null.", nameof(programs));
                segments[segments.Count - 1] += program.segments[0];
                for (var index = 0; index < program.bindings.Length; index++)
                {
                    bindings.Add(program.bindings[index]);
                    segments.Add(program.segments[index + 1]);
                }
            }

            return new SourceProgram(segments.ToArray(), bindings.ToArray());
        }

        internal static SourceProgram Join(string separator, IEnumerable<SourceProgram> programs)
        {
            if (separator == null) throw new ArgumentNullException(nameof(separator));
            if (programs == null) throw new ArgumentNullException(nameof(programs));
            var parts = new List<SourceProgram>();
            foreach (var program in programs)
            {
                if (parts.Count != 0) parts.Add(Text(separator));
                parts.Add(program);
            }

            return Concat(parts);
        }

        internal static SourceProgram CommaSeparated(IEnumerable<SourceProgram> programs) =>
            Join(", ", programs);

        internal SourceProgram Wrapped(string prefix, string suffix) =>
            Concat(Text(prefix), this, Text(suffix));

        internal SourceProgram Parenthesized() =>
            this.Wrapped("(", ")");

        internal SourceProgram Bracketed() =>
            this.Wrapped("[", "]");

        internal SourceProgram Braced() =>
            this.Wrapped("{ ", " }");

        internal bool IsText(string text) =>
            this.bindings.Length == 0 && this.segments[0] == text;

        internal string Render()
        {
            var source = new StringBuilder(this.segments[0]);
            for (var index = 0; index < this.bindings.Length; index++)
                source.Append(this.bindings[index].Render()).Append(this.segments[index + 1]);
            return source.ToString();
        }
    }

    /// <summary>Late-bound workflow context references.</summary>
    internal sealed class WorkflowExpressionBinding
    {
        private readonly IWorkflowOperation operation;
        private readonly string function;
        private readonly string argument;

        private WorkflowExpressionBinding(IWorkflowOperation operation, string function, string argument = null)
        {
            this.operation = operation;
            this.function = function;
            this.argument = argument;
        }

        internal static WorkflowExpressionBinding Output(IWorkflowAction action) =>
            new WorkflowExpressionBinding(action ?? throw new ArgumentNullException(nameof(action)), "outputs");
        
        internal static WorkflowExpressionBinding Body(IWorkflowAction action) =>
            new WorkflowExpressionBinding(action ?? throw new ArgumentNullException(nameof(action)), "body");
        
        internal static WorkflowExpressionBinding Trigger(IWorkflowTrigger trigger, bool body) =>
            new WorkflowExpressionBinding(trigger ?? throw new ArgumentNullException(nameof(trigger)), body ? "triggerBody" : "triggerOutputs");
        
        internal static WorkflowExpressionBinding Variable(IVariableWorkflowAction action) =>
            new WorkflowExpressionBinding(action ?? throw new ArgumentNullException(nameof(action)), "variables");
        
        internal static WorkflowExpressionBinding Item(JToken item) =>
            item is ForEachItemToken ? new WorkflowExpressionBinding(null, "item") :
                throw new ArgumentException("Expected a workflow foreach item.", nameof(item));
        
        internal static WorkflowExpressionBinding AgentParameter(object context, string name) =>
            context != null ? new WorkflowExpressionBinding(null, "agentparameters", name) :
                throw new ArgumentNullException(nameof(context));

        internal string Render()
        {
            var name = this.argument;
            if (this.operation is IVariableWorkflowAction variable) name = variable.VariableName;
            else if (this.function == "outputs" || this.function == "body") name = this.operation.Name;
            if ((this.function == "outputs" || this.function == "body" || this.function == "variables") && string.IsNullOrEmpty(name))
                throw new InvalidOperationException("The referenced operation must have a name before definition rendering.");
            return this.function + "(" + (name == null ? "" : JsonConvert.ToString(name)) + ")";
        }
    }
}
