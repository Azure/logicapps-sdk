// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.Expressions
{
    using System.Globalization;
    using System.Linq.Expressions;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Source representation of operation inputs lambda expressions. Holds literal values or C# source (source segments + bindings to workflow context).
    /// </summary>
    internal abstract class WorkflowExpression
    {
        internal abstract JToken LiteralToken { get; }

        internal string Render() =>
            this.ToFragment().Render();

        private protected abstract WorkflowExpressionFragment ToFragment();

        internal static WorkflowExpression<T> Literal<T>(T value) =>
            new WorkflowExpression<T>(Serialize(value), null);

        internal static WorkflowExpression<T> Create<T>(WorkflowExpressionFragment root) =>
            new WorkflowExpression<T>(null, root ?? throw new ArgumentNullException(nameof(root)));

        internal static WorkflowExpression<string> GeneratedPath(
            string format,
            params WorkflowExpression<string>[] arguments)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (arguments == null) throw new ArgumentNullException(nameof(arguments));

            var pieces = new List<WorkflowExpressionFragment>();
            var text = new StringBuilder();
            for (var index = 0; index < format.Length; index++)
            {
                if (format[index] != '{')
                {
                    text.Append(format[index]);
                    continue;
                }

                var end = format.IndexOf('}', index);
                if (end < 0 ||
                    !int.TryParse(format.Substring(index + 1, end - index - 1), out var position) ||
                    position < 0 ||
                    position >= arguments.Length)
                {
                    throw new FormatException("Invalid generated connector path.");
                }

                if (text.Length != 0)
                {
                    pieces.Add(CSharpSyntaxGenerator.Literal(text.ToString(), typeof(string)));
                    text.Clear();
                }

                pieces.Add((arguments[position] ?? throw new ArgumentException(
                    "Generated connector path arguments cannot contain null.",
                    nameof(arguments))).ToFragment());
                index = end;
            }

            if (text.Length != 0 || pieces.Count == 0)
                pieces.Add(CSharpSyntaxGenerator.Literal(text.ToString(), typeof(string)));

            var result = pieces[0];
            for (var index = 1; index < pieces.Count; index++)
                result = CSharpSyntaxGenerator.Binary(result, "+", pieces[index]);

            return Create<string>(result);
        }

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
        private const string EncodeUriComponentFunction = "encodeURIComponent";
        private const string Base64Function = "base64";

        private readonly JToken literal;
        private readonly WorkflowExpressionFragment root;

        internal WorkflowExpression(JToken literal, WorkflowExpressionFragment root)
        {
            if ((literal == null) == (root == null))
                throw new ArgumentException("A workflow expression must contain either a literal or source.");

            this.literal = literal;
            this.root = root;
        }

        internal override JToken LiteralToken => this.literal?.DeepClone();

        private protected override WorkflowExpressionFragment ToFragment()
        {
            if (this.root != null) return this.root;
            var value = this.literal.Type == JTokenType.Null ? default(T) : this.literal.ToObject<T>();
            return CSharpSyntaxGenerator.Literal(value, typeof(T));
        }

        internal WorkflowExpression<TResult> Cast<TResult>() =>
            WorkflowExpression.Create<TResult>(
                CSharpSyntaxGenerator.Cast(typeof(TResult), this.ToFragment()));

        internal WorkflowExpression<string> WithUrlEncoding(int times)
        {
            if (times < 0) throw new ArgumentOutOfRangeException(nameof(times));
            var fragment = this.ToFragment();
            for (var index = 0; index < times; index++)
                fragment = CSharpSyntaxGenerator.Invocation(
                    EncodeUriComponentFunction,
                    new[] { fragment });
            return WorkflowExpression.Create<string>(fragment);
        }

        internal WorkflowExpression<string> WithBase64Encoding()
        {
            if (this.literal != null)
            {
                if (typeof(T) == typeof(byte[]))
                    return WorkflowExpression.Literal(this.literal.Value<string>("$content"));

                var text = this.literal.Type == JTokenType.String
                    ? this.literal.Value<string>()
                    : this.literal.ToString(Formatting.None);
                return WorkflowExpression.Create<string>(
                    CSharpSyntaxGenerator.Invocation(
                        Base64Function,
                        new[] { CSharpSyntaxGenerator.Literal(text, typeof(string)) }));
            }

            var fragment = typeof(T) == typeof(byte[])
                ? CSharpSyntaxGenerator.Invocation(
                    CSharpSyntaxGenerator.StaticMemberAccess(
                        typeof(Convert),
                        nameof(Convert.ToBase64String)),
                    Array.Empty<Type>(),
                    new[] { this.root })
                : CSharpSyntaxGenerator.Invocation(
                    Base64Function,
                    new[] { this.root });
            return WorkflowExpression.Create<string>(fragment);
        }
    }

    /// <summary>
    /// Immutable C# source segments interleaved with late-bound workflow references.
    /// </summary>
    internal sealed class WorkflowExpressionFragment
    {
        private readonly string[] segments;
        private readonly WorkflowExpressionBinding[] bindings;

        private WorkflowExpressionFragment(string[] segments, WorkflowExpressionBinding[] bindings)
        {
            if (segments == null || bindings == null || segments.Length != bindings.Length + 1 ||
                segments.Any(segment => segment == null) || bindings.Any(binding => binding == null))
                throw new ArgumentException("A source expression needs one more non-null segment than bindings.");

            this.segments = segments;
            this.bindings = bindings;
        }

        internal static WorkflowExpressionFragment Text(string text) =>
            new WorkflowExpressionFragment(new[] { text ?? throw new ArgumentNullException(nameof(text)) }, Array.Empty<WorkflowExpressionBinding>());

        internal static WorkflowExpressionFragment Binding(WorkflowExpressionBinding binding) =>
            new WorkflowExpressionFragment(
                new[] { string.Empty, string.Empty },
                new[] { binding ?? throw new ArgumentNullException(nameof(binding)) });

        internal static WorkflowExpressionFragment Concat(params WorkflowExpressionFragment[] fragments) =>
            Concat((IEnumerable<WorkflowExpressionFragment>)fragments);

        internal static WorkflowExpressionFragment Concat(IEnumerable<WorkflowExpressionFragment> fragments)
        {
            if (fragments == null) throw new ArgumentNullException(nameof(fragments));
            var segments = new List<string> { string.Empty };
            var bindings = new List<WorkflowExpressionBinding>();
            foreach (var fragment in fragments)
            {
                if (fragment == null) throw new ArgumentException("Source expressions cannot contain null.", nameof(fragments));
                segments[segments.Count - 1] += fragment.segments[0];
                for (var index = 0; index < fragment.bindings.Length; index++)
                {
                    bindings.Add(fragment.bindings[index]);
                    segments.Add(fragment.segments[index + 1]);
                }
            }

            return new WorkflowExpressionFragment(segments.ToArray(), bindings.ToArray());
        }

        internal static WorkflowExpressionFragment Join(string separator, IEnumerable<WorkflowExpressionFragment> fragments)
        {
            if (separator == null) throw new ArgumentNullException(nameof(separator));
            if (fragments == null) throw new ArgumentNullException(nameof(fragments));
            var parts = new List<WorkflowExpressionFragment>();
            foreach (var fragment in fragments)
            {
                if (parts.Count != 0) parts.Add(Text(separator));
                parts.Add(fragment);
            }

            return Concat(parts);
        }

        internal static WorkflowExpressionFragment CommaSeparated(IEnumerable<WorkflowExpressionFragment> fragments) =>
            Join(", ", fragments);

        internal WorkflowExpressionFragment Wrapped(string prefix, string suffix) =>
            Concat(Text(prefix), this, Text(suffix));

        internal WorkflowExpressionFragment Parenthesized() =>
            this.Wrapped("(", ")");

        internal WorkflowExpressionFragment Bracketed() =>
            this.Wrapped("[", "]");

        internal WorkflowExpressionFragment Braced() =>
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
