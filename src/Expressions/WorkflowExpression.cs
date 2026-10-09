// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk
{
    using System.ComponentModel;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class WorkflowExpressionAttribute : Attribute { }

    [AttributeUsage(AttributeTargets.Method)]
    public sealed class WorkflowExpressionFactoryAttribute : Attribute
    {
        public WorkflowExpressionFactoryAttribute(string entryPoint) => this.EntryPoint = entryPoint;
        public string EntryPoint { get; }
    }

    /// <summary>Authoring-time source and bindings; never an executable placeholder delegate.</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public abstract class WorkflowExpression
    {
        internal abstract JToken LiteralToken { get; }
        internal abstract string Render();

        public static WorkflowExpression<T> Literal<T>(T value) =>
            new WorkflowExpression<T>(Serialize(value), null, null);

        public static WorkflowExpression<T> Program<T>(string[] segments, WorkflowExpressionBinding[] bindings)
        {
            if (segments == null || bindings == null || segments.Length != bindings.Length + 1 ||
                segments.Any(segment => segment == null) || bindings.Any(binding => binding == null))
                throw new ArgumentException("A source program needs one more non-null segment than bindings.");
            return new WorkflowExpression<T>(null, (string[])segments.Clone(), (WorkflowExpressionBinding[])bindings.Clone());
        }

        public static WorkflowExpression<T> Program<T>(string[] segments, WorkflowExpressionBinding[] bindings, Func<T> typeWitness) =>
            Program<T>(segments, bindings);

        public static void Validate(WorkflowExpression value, string name, bool required)
        {
            if (required && value == null) throw new ArgumentNullException(name);
            if (required && value.LiteralToken?.Type == JTokenType.Null)
                throw new ArgumentException("A required workflow value cannot be null.", name);
        }

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

    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class WorkflowExpression<T> : WorkflowExpression
    {
        private readonly JToken literal;
        private readonly string[] segments;
        private readonly WorkflowExpressionBinding[] bindings;
        internal WorkflowExpression(JToken literal, string[] segments, WorkflowExpressionBinding[] bindings)
        {
            this.literal = literal;
            this.segments = segments;
            this.bindings = bindings;
        }
        internal override JToken LiteralToken => this.literal?.DeepClone();
        internal override string Render()
        {
            if (this.literal != null) throw new InvalidOperationException("A literal has no source program.");
            var source = new System.Text.StringBuilder(this.segments[0]);
            for (var index = 0; index < this.bindings.Length; index++)
                source.Append(this.bindings[index].Render()).Append(this.segments[index + 1]);
            return source.ToString();
        }
    }

    /// <summary>Late-bound operation names or immutable scalar source snapshots.</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class WorkflowExpressionBinding
    {
        private readonly IWorkflowOperation operation;
        private readonly string function;
        private readonly string argument;
        private readonly string capture;
        private WorkflowExpressionBinding(IWorkflowOperation operation, string function, string argument = null, string capture = null)
        {
            this.operation = operation;
            this.function = function;
            this.argument = argument;
            this.capture = capture;
        }
        public static WorkflowExpressionBinding Output(IWorkflowAction action) =>
            new WorkflowExpressionBinding(action ?? throw new ArgumentNullException(nameof(action)), "outputs");
        public static WorkflowExpressionBinding Body(IWorkflowAction action) =>
            new WorkflowExpressionBinding(action ?? throw new ArgumentNullException(nameof(action)), "body");
        public static WorkflowExpressionBinding Trigger(IWorkflowTrigger trigger, bool body) =>
            new WorkflowExpressionBinding(trigger ?? throw new ArgumentNullException(nameof(trigger)), body ? "triggerBody" : "triggerOutputs");
        public static WorkflowExpressionBinding Variable(IVariableWorkflowAction action) =>
            new WorkflowExpressionBinding(action ?? throw new ArgumentNullException(nameof(action)), "variables");
        public static WorkflowExpressionBinding Item(JToken item) =>
            item is ForEachItemToken ? new WorkflowExpressionBinding(null, "item") :
                throw new ArgumentException("Expected a workflow foreach item.", nameof(item));
        public static WorkflowExpressionBinding AgentParameter(object context, string name) =>
            context != null ? new WorkflowExpressionBinding(null, "agentparameters", name) :
                throw new ArgumentNullException(nameof(context));
        public static WorkflowExpressionBinding Capture<T>(T value) =>
            new WorkflowExpressionBinding(null, null, capture: CaptureSource(value, typeof(T)));

        internal string Render()
        {
            if (this.capture != null) return this.capture;
            var name = this.argument;
            if (this.operation is IVariableWorkflowAction variable) name = variable.VariableName;
            else if (this.function == "outputs" || this.function == "body") name = this.operation.Name;
            if ((this.function == "outputs" || this.function == "body" || this.function == "variables") && string.IsNullOrEmpty(name))
                throw new InvalidOperationException("The referenced operation must have a name before definition rendering.");
            return this.function + "(" + (name == null ? "" : JsonConvert.ToString(name)) + ")";
        }

        private static string CaptureSource(object value, Type type)
        {
            var nullable = Nullable.GetUnderlyingType(type);
            if (value == null) return "null";
            if (nullable != null) return CaptureSource(value, nullable);
            if (value is string text) return JsonConvert.ToString(text);
            if (value is char character) return "(char)" + ((int)character).ToString(CultureInfo.InvariantCulture);
            if (value is bool flag) return flag ? "true" : "false";
            if (value is double number && (double.IsNaN(number) || double.IsInfinity(number)) ||
                value is float single && (float.IsNaN(single) || float.IsInfinity(single)))
                throw new NotSupportedException("Non-finite captures are unsupported.");
            if (type.IsEnum)
                return "(" + TypeName(type) + ")(" + CaptureSource(Convert.ChangeType(value, Enum.GetUnderlyingType(type), CultureInfo.InvariantCulture), Enum.GetUnderlyingType(type)) + ")";
            if (value is Guid guid) return "new global::System.Guid(" + JsonConvert.ToString(guid.ToString("D")) + ")";
            if (value is DateTime date) return $"new global::System.DateTime({date.Ticks}L, global::System.DateTimeKind.{date.Kind})";
            if (value is DateTimeOffset offset) return $"new global::System.DateTimeOffset({offset.Ticks}L, new global::System.TimeSpan({offset.Offset.Ticks}L))";
            if (value is TimeSpan span) return $"new global::System.TimeSpan({span.Ticks}L)";
            if (value is Uri uri) return "new global::System.Uri(" + JsonConvert.ToString(uri.OriginalString) + ", global::System.UriKind.RelativeOrAbsolute)";
            if (value is HttpMethod method) return "new global::System.Net.Http.HttpMethod(" + JsonConvert.ToString(method.Method) + ")";
            var suffix = value is decimal ? "m" : value is float ? "f" : value is double ? "d" :
                value is ulong ? "UL" : value is long ? "L" : value is uint ? "U" : "";
            if (type.IsPrimitive || value is decimal)
                return "(" + TypeName(type) + ")(" + ((IFormattable)value).ToString(value is float || value is double ? "R" : null, CultureInfo.InvariantCulture) + suffix + ")";
            throw new NotSupportedException($"Capture '{type}' is unsupported. Capture immutable scalars rather than reference objects.");
        }

        private static string TypeName(Type type) => "global::" + type.FullName.Replace('+', '.');
    }
}
