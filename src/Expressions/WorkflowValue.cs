// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System.ComponentModel;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>Stores literal data or a source program without an executable authoring delegate.</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public abstract class WorkflowValue
    {
        internal abstract bool IsLiteral { get; }
        internal abstract JToken LiteralToken { get; }
        internal abstract string RenderSource();

        public static WorkflowValue<T> Literal<T>(int version, T value)
        {
            WorkflowExpressionRuntime.CheckVersion(version);
            return new WorkflowValue<T>(WorkflowExpressionRuntime.ToWire(version, value), null, null);
        }

        public static WorkflowValue<T> Captured<T>(int version, T value)
        {
            WorkflowExpressionRuntime.CheckVersion(version);
            var snapshot = WorkflowExpressionRuntime.EncodeCapture(value);
            return Literal(version, WorkflowExpressionRuntime.DecodeCapture<T>(version, snapshot));
        }

        public static WorkflowValue<T> Program<T>(int version, string[] segments, WorkflowBinding[] bindings)
        {
            WorkflowExpressionRuntime.CheckVersion(version);
            if (segments == null || bindings == null || segments.Length != bindings.Length + 1 ||
                segments.Any(segment => segment == null) || bindings.Any(binding => binding == null))
            {
                throw new ArgumentException("An expression needs one more source segment than bindings, with no null entries.");
            }
            return new WorkflowValue<T>(null, (string[])segments.Clone(), (WorkflowBinding[])bindings.Clone());
        }

        public static WorkflowValue<T> Program<T>(int version, string[] segments, WorkflowBinding[] bindings, Func<T> typeWitness) =>
            Program<T>(version, segments, bindings);

        public static void Validate(WorkflowValue value, string parameterName, bool required)
        {
            if (value == null)
            {
                if (required) throw new ArgumentNullException(parameterName);
                return;
            }
            if (required && value.IsLiteral && value.LiteralToken.Type == JTokenType.Null)
                throw new ArgumentException("A required workflow value cannot be null.", parameterName);
        }

        internal static string Quote(string value) => JsonConvert.ToString(value);
    }

    /// <summary>Retains the result type while storing an immutable expression description.</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class WorkflowValue<T> : WorkflowValue
    {
        private readonly JToken literal;
        private readonly string[] segments;
        private readonly WorkflowBinding[] bindings;

        internal WorkflowValue(JToken literal, string[] segments, WorkflowBinding[] bindings)
        {
            this.literal = literal;
            this.segments = segments;
            this.bindings = bindings;
        }

        internal override bool IsLiteral => this.literal != null;
        internal override JToken LiteralToken => this.literal?.DeepClone();

        internal override string RenderSource()
        {
            if (this.IsLiteral)
                throw new InvalidOperationException("Literal data cannot be reconstructed as a program without capture type information.");

            var source = new StringBuilder(this.segments[0]);
            for (var index = 0; index < this.bindings.Length; index++)
                source.Append(this.bindings[index].Render()).Append(this.segments[index + 1]);
            return source.ToString();
        }
    }

    /// <summary>Stores a workflow handle or an immutable capture snapshot for a source slot.</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class WorkflowBinding
    {
        private readonly IWorkflowOperation operation;
        private readonly string helper;
        private readonly string snapshot;
        private readonly string typeName;
        private readonly string argument;
        private readonly string[] path;

        private WorkflowBinding(IWorkflowOperation operation, string helper, string typeName, string snapshot = null, string argument = null, string[] path = null)
        {
            this.operation = operation;
            this.helper = helper;
            this.typeName = typeName;
            this.snapshot = snapshot;
            this.argument = argument;
            this.path = path == null ? Array.Empty<string>() : (string[])path.Clone();
        }

        public static WorkflowBinding Output(IWorkflowAction action, string typeName, params string[] path) =>
            new WorkflowBinding(action ?? throw new ArgumentNullException(nameof(action)), "outputs", typeName, path: path);

        public static WorkflowBinding Body(IWorkflowAction action, string typeName, params string[] path) =>
            new WorkflowBinding(action ?? throw new ArgumentNullException(nameof(action)), "body", typeName, path: path);

        public static WorkflowBinding Trigger(IWorkflowTrigger trigger, string helper, string typeName)
        {
            if (helper != "triggerBody" && helper != "triggerOutputs")
                throw new ArgumentException("Unknown trigger accessor.", nameof(helper));
            return new WorkflowBinding(trigger ?? throw new ArgumentNullException(nameof(trigger)), helper, typeName);
        }

        public static WorkflowBinding Variable(IVariableWorkflowAction variable) =>
            new WorkflowBinding(variable ?? throw new ArgumentNullException(nameof(variable)), "variables", "global::Newtonsoft.Json.Linq.JToken");

        public static WorkflowBinding Item(JToken item)
        {
            if (!(item is ForEachItemToken))
                throw new ArgumentException("The value is not a workflow foreach item.", nameof(item));
            return new WorkflowBinding(null, "item", "global::Newtonsoft.Json.Linq.JToken");
        }

        public static WorkflowBinding AgentParameter(object context, string name, string typeName)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));
            return new WorkflowBinding(null, "agentparameters", typeName, argument: name);
        }

        public static WorkflowBinding Capture<T>(T value, string typeName) =>
            new WorkflowBinding(null, null, typeName, WorkflowExpressionRuntime.EncodeCapture(value));

        internal string Render()
        {
            if (this.snapshot != null)
                return $"global::Microsoft.Azure.Workflows.Sdk.WorkflowExpressionRuntime.DecodeCapture<{this.typeName}>(1, {WorkflowValue.Quote(this.snapshot)})";

            var name = this.argument;
            if (this.operation is IVariableWorkflowAction variable)
            {
                name = variable.VariableName;
                if (name.StartsWith("#{", StringComparison.Ordinal))
                    throw new NotSupportedException("Referenced variable names must be known during workflow construction.");
            }
            else if (this.helper == "outputs" || this.helper == "body")
                name = this.operation.Name;

            if ((this.helper == "outputs" || this.helper == "body" || this.helper == "variables") && string.IsNullOrEmpty(name))
                throw new InvalidOperationException("The referenced workflow operation has no name.");

            var source = $"{this.helper}({(name == null ? "" : WorkflowValue.Quote(name))})";
            foreach (var property in this.path) source += $"[{WorkflowValue.Quote(property)}]";
            return this.typeName == "global::Newtonsoft.Json.Linq.JToken" ? source : $"{source}.ToObject<{this.typeName}>()";
        }
    }
}
