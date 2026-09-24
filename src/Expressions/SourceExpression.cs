// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Text.RegularExpressions;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>Marks an authoring delegate that must be replaced by the SDK source compiler.</summary>
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class WorkflowExpressionAttribute : Attribute { }

    /// <summary>Versioned compiler-facing expression descriptors. Authoring delegates are never invoked.</summary>
    public static class SourceExpression
    {
        /// <summary>Gets a C# type name for a concrete CLR binding type without inspecting its values.</summary>
        public static string TypeName(Type type) => SourceSnapshot.TypeName(type);

        public static Func<T> Create<T>(int version, string kind, string[] segments, SourceBinding[] bindings, string[] nativeSegments = null)
        {
            CheckVersion(version);
            if (kind != "native" && kind != "template" && kind != "capture")
                throw new NotSupportedException($"Source expression kind '{kind}' is unsupported. Block and async expressions require a verified execution host.");
            if (segments == null || bindings == null || segments.Length != bindings.Length + 1 ||
                segments.Any(s => s == null) || bindings.Any(b => b == null))
                throw new ArgumentException("A source expression requires one more non-null segment than bindings.");
            if (kind == "capture" && (bindings.Length != 1 || segments[0] != "" || segments[1] != "" ||
                !bindings[0].IsCapture && !bindings[0].IsItem))
                throw new ArgumentException("A capture descriptor requires empty segments and exactly one captured-value or foreach-item binding.");
            if (nativeSegments != null && (kind != "template" || nativeSegments.Length != segments.Length || nativeSegments.Any(s => s == null)))
                throw new ArgumentException("Native source segments require a template descriptor and must match its binding count.", nameof(nativeSegments));
            return new SourceDescriptor<T>(kind, (string[])segments.Clone(), (SourceBinding[])bindings.Clone(),
                nativeSegments == null ? null : (string[])nativeSegments.Clone()).Invoke;
        }

        /// <summary>Infers an unnameable result type; the witness is never invoked or retained.</summary>
        public static Func<T> Create<T>(int version, string kind, string[] segments, SourceBinding[] bindings, Func<T> typeWitness, string[] nativeSegments = null) =>
            Create<T>(version, kind, segments, bindings, nativeSegments);

        public static Func<T> Literal<T>(int version, T value)
        {
            CheckVersion(version);
            return new SourceDescriptor<T>(SourceSnapshot.Create(value)).Invoke;
        }

        /// <summary>Describes the SDK JSON intrinsic without parsing JSON or executing its input delegate.</summary>
        public static Func<T> Json<T>(int version, Func<string> input)
        {
            CheckVersion(version);
            return new SourceJsonDescriptor<T>(GetDescriptor(input)).Invoke;
        }

        /// <summary>Preserves a workflow JSON value at the wire boundary and typed source for native consumers.</summary>
        public static Func<T> Value<T>(int version, Func<T> nativeSource, Func<JToken> wireSource)
        {
            CheckVersion(version);
            return new SourceValueDescriptor<T>(GetDescriptor(nativeSource), GetDescriptor(wireSource)).Invoke;
        }

        /// <summary>Preserves source metadata across a compiler-verified Newtonsoft JSON implicit conversion.</summary>
        public static Func<JToken> Token<T>(int version, Func<T> input)
        {
            CheckVersion(version);
            return new SourceTokenDescriptor(GetDescriptor(input)).Invoke;
        }

        /// <summary>Preserves the actual source type across a generated object-valued parameter.</summary>
        public static Func<object> Box<T>(int version, Func<T> input)
        {
            CheckVersion(version);
            return new SourceBoxDescriptor(GetDescriptor(input)).Invoke;
        }

        public static Func<T> Unsupported<T>(int version, string destination, string sourceType)
        {
            CheckVersion(version);
            throw new NotSupportedException($"Destination '{destination}' does not support encoding normalization of '{sourceType}'. The captured value was not read.");
        }

        /// <summary>Retains typed native source and separately supplied enum wire source.</summary>
        public static Func<T> Enum<T>(int version, Func<T> value, Func<string> wire)
        {
            CheckVersion(version);
            if (!(Nullable.GetUnderlyingType(typeof(T)) ?? typeof(T)).IsEnum)
                throw new ArgumentException("An enum or nullable enum result type is required.");
            return new SourceEnumDescriptor<T>(GetDescriptor(value), GetDescriptor(wire)).Invoke;
        }

        /// <summary>Creates an explicitly described JSON object without running its source initializer.</summary>
        public static Func<T> Object<T>(int version, string[] names, Delegate[] members)
        {
            CheckVersion(version);
            if (names == null || members == null || names.Length != members.Length ||
                names.Any(n => n == null) || names.Distinct(StringComparer.Ordinal).Count() != names.Length)
                throw new ArgumentException("Object descriptors require unique property names and one value per property.");
            return new SourceDescriptor<T>((string[])names.Clone(), members.Select(GetDescriptor).ToArray()).Invoke;
        }

        /// <summary>Infers an unnameable object type; the witness is never invoked or retained.</summary>
        public static Func<T> Object<T>(int version, string[] names, Delegate[] members, Func<T> typeWitness) =>
            Object<T>(version, names, members);

        public static Func<T> Object<T>(int version, string[] names, Delegate[] members, bool preserveSource, Func<T> nativeSource)
        {
            if (!preserveSource) throw new ArgumentException("This descriptor overload requires preserved native source.", nameof(preserveSource));
            var result = Object<T>(version, names, members);
            ((SourceDescriptor<T>)result.Target).SetNativeSource(GetDescriptor(nativeSource));
            return result;
        }

        public static Func<T> Model<T>(int version, string schema, string[] names, Delegate[] members, Func<T> nativeSource)
        {
            var result = Object<T>(version, names, members, true, nativeSource);
            ((SourceDescriptor<T>)result.Target).SetSchema(WorkflowDestination.Parse(schema));
            return result;
        }

        /// <summary>Creates an explicitly described JSON array without running its source initializer.</summary>
        public static Func<T> Array<T>(int version, Delegate[] elements)
        {
            CheckVersion(version);
            if (elements == null) throw new ArgumentNullException(nameof(elements));
            return new SourceDescriptor<T>(null, elements.Select(GetDescriptor).ToArray()).Invoke;
        }

        /// <summary>Infers an unnameable array type; the witness is never invoked or retained.</summary>
        public static Func<T> Array<T>(int version, Delegate[] elements, Func<T> typeWitness) =>
            Array<T>(version, elements);

        public static Func<T> Array<T>(int version, Delegate[] elements, bool preserveSource, Func<T> nativeSource)
        {
            if (!preserveSource) throw new ArgumentException("This descriptor overload requires preserved native source.", nameof(preserveSource));
            var result = Array<T>(version, elements);
            ((SourceDescriptor<T>)result.Target).SetNativeSource(GetDescriptor(nativeSource));
            return result;
        }

        internal static void CheckVersion(int version)
        {
            if (version != 1)
                throw new NotSupportedException($"Source expression descriptor version {version} is unsupported; this SDK supports version 1.");
        }

        internal static ISourceDescriptor GetDescriptor(Delegate expression)
        {
            if (expression == null) throw new ArgumentNullException(nameof(expression));
            if (expression.GetInvocationList().Length != 1 || !(expression.Target is ISourceDescriptor descriptor) ||
                expression.Method.Name != nameof(SourceDescriptor<object>.Invoke))
                throw new NotSupportedException("Missing workflow source expression metadata. Enable the SDK source compiler and pass an inline expression; authoring delegates cannot be executed.");
            return descriptor is SourceTokenDescriptor token ? token.Inner :
                descriptor is SourceBoxDescriptor box ? box.Inner : descriptor;
        }

        internal static void Validate(Delegate expression, string parameterName, bool required = false)
        {
            if (expression == null)
            {
                if (required) throw new ArgumentNullException(parameterName);
                return;
            }
            var descriptor = GetDescriptor(expression);
            if (required && descriptor.IsLiteral && descriptor.RenderToken().Type == JTokenType.Null)
                throw new ArgumentException("A required workflow argument cannot be null.", parameterName);
        }
    }

    /// <summary>Explicit compiler-generated binding to a workflow handle or a construction-time snapshot.</summary>
    public sealed class SourceBinding
    {
        private readonly IWorkflowAction action;
        private readonly IVariableWorkflowAction variable;
        private readonly string helper;
        private readonly string clrType;
        private readonly SourceSnapshot capture;
        private readonly string parameterName;
        private readonly ISourceJsonDescriptor json;
        private readonly ISourceDescriptor enumWire;

        private SourceBinding(IWorkflowAction action, string helper, string clrType, SourceSnapshot capture = null, IVariableWorkflowAction variable = null, string parameterName = null, ISourceJsonDescriptor json = null, ISourceDescriptor enumWire = null)
        {
            this.action = action;
            this.helper = helper;
            this.clrType = string.IsNullOrWhiteSpace(clrType) ? throw new ArgumentException("A CLR type is required.", nameof(clrType)) : clrType;
            this.capture = capture;
            this.variable = variable;
            this.parameterName = parameterName;
            this.json = json;
            this.enumWire = enumWire;
        }

        public static SourceBinding Output(IWorkflowAction handle, string clrType) =>
            new SourceBinding(handle ?? throw new ArgumentNullException(nameof(handle)), "outputs", clrType);

        public static SourceBinding Body(IWorkflowAction handle, string clrType) =>
            new SourceBinding(handle ?? throw new ArgumentNullException(nameof(handle)), "body", clrType);

        public static SourceBinding Trigger(object handle, string helper, string clrType)
        {
            if (!(handle is IWorkflowTrigger)) throw new ArgumentException("A workflow trigger handle is required.", nameof(handle));
            if (helper != "triggerBody" && helper != "triggerOutputs")
                throw new ArgumentException("Unsupported trigger helper.", nameof(helper));
            return new SourceBinding(null, helper, clrType);
        }

        public static SourceBinding Variable(IVariableWorkflowAction handle, string clrType) =>
            new SourceBinding(null, "variables", clrType, variable: handle ?? throw new ArgumentNullException(nameof(handle)));

        public static SourceBinding Item(object handle, string clrType)
        {
            if (!(handle is ForEachItemToken)) throw new ArgumentException("An SDK foreach item is required.", nameof(handle));
            return new SourceBinding(null, "item", clrType);
        }

        public static SourceBinding Capture(object value, string clrType) =>
            value is ForEachItemToken ? Item(value, clrType) : new SourceBinding(null, null, clrType, SourceSnapshot.Create(value));

        /// <summary>Binds an SDK JSON intrinsic for typed use inside preserved native source.</summary>
        public static SourceBinding Json(Delegate jsonDescriptor, string clrType)
        {
            if (!(SourceExpression.GetDescriptor(jsonDescriptor) is ISourceJsonDescriptor descriptor))
                throw new ArgumentException("A JSON intrinsic descriptor is required.", nameof(jsonDescriptor));
            return new SourceBinding(null, null, clrType, json: descriptor);
        }

        /// <summary>Binds an enum-valued leaf to its wire representation inside native source.</summary>
        public static SourceBinding EnumWire(Delegate enumDescriptor)
        {
            var descriptor = SourceExpression.GetDescriptor(enumDescriptor);
            if (!(Nullable.GetUnderlyingType(descriptor.ResultType) ?? descriptor.ResultType).IsEnum)
                throw new ArgumentException("An enum or nullable enum descriptor is required.", nameof(enumDescriptor));
            return new SourceBinding(null, null, SourceSnapshot.TypeName(descriptor.ResultType), enumWire: descriptor);
        }

        /// <summary>Snapshots a compiler-validated instance member path without invoking property getters.</summary>
        public static SourceBinding CapturePath(object root, string[] members, string clrType)
        {
            if (members == null || members.Any(string.IsNullOrEmpty))
                throw new ArgumentException("A capture path requires non-empty member names.", nameof(members));
            object value = root;
            foreach (var name in members)
            {
                if (value == null)
                    throw new NotSupportedException($"Cannot capture member '{name}' through a null value.");
                var type = value.GetType();
                if (value is Delegate || value is IWorkflowOperation || value is ForEachItemToken ||
                    type.IsDefined(typeof(System.Runtime.CompilerServices.CompilerGeneratedAttribute), false))
                    throw new NotSupportedException($"Captured member '{name}' on '{type.FullName}' is not approved instance storage.");
                var candidates = new List<MemberInfo>();
                for (var current = type; current != null; current = current.BaseType)
                {
                    candidates.AddRange(current.GetMember(name,
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly)
                        .Where(member => member is FieldInfo || member is PropertyInfo));
                }
                if (candidates.Count != 1)
                    throw new NotSupportedException($"Captured member '{name}' on '{type.FullName}' is missing or ambiguous.");
                FieldInfo storage;
                if (candidates[0] is FieldInfo field)
                {
                    if (field.IsStatic || field.IsDefined(typeof(System.Runtime.CompilerServices.CompilerGeneratedAttribute), false))
                        throw new NotSupportedException($"Captured field '{name}' must be ordinary instance storage.");
                    storage = field;
                }
                else
                {
                    var property = (PropertyInfo)candidates[0];
                    var getter = property.GetGetMethod(nonPublic: true);
                    storage = property.DeclaringType.GetField("<" + property.Name + ">k__BackingField",
                        BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
                    if (property.GetIndexParameters().Length != 0 || getter == null || getter.IsStatic ||
                        !getter.IsDefined(typeof(System.Runtime.CompilerServices.CompilerGeneratedAttribute), false) ||
                        storage == null || storage.IsStatic || storage.FieldType != property.PropertyType ||
                        !storage.IsDefined(typeof(System.Runtime.CompilerServices.CompilerGeneratedAttribute), false))
                        throw new NotSupportedException($"Captured custom getter '{name}' is unsupported; only validated auto-property storage can be snapshotted.");
                }
                value = storage.GetValue(value);
            }
            return Capture(value, clrType);
        }

        internal bool IsCapture => this.capture != null;
        internal bool IsItem => this.helper == "item";
        internal JToken CaptureToken() => this.capture != null
            ? SourceSnapshot.CloneJson(this.capture.Token)
            : throw new InvalidOperationException("This binding is not a captured value.");

        public static SourceBinding AgentParameter(object handle, string name, string clrType)
        {
            if (handle == null || !handle.GetType().GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IAgentToolContext<>)))
                throw new ArgumentException("An SDK agent tool context is required.", nameof(handle));
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("An agent parameter name is required.", nameof(name));
            return new SourceBinding(null, "agentparameters", clrType, parameterName: name);
        }

        internal string ToNative()
        {
            if (this.enumWire != null) return SourceExpressionConverter.RenderNativeWire(this.enumWire);
            if (this.json != null) return Materialize(this.json.RenderNative(), this.clrType);
            if (this.capture != null)
            {
                if (!SourceSnapshot.MatchesDeclaredType(this.clrType, this.capture.RuntimeType))
                    return "((" + this.clrType + ")" + this.capture.Native + ")";
                if (this.capture.Native.StartsWith("(", StringComparison.Ordinal))
                    return "(" + this.capture.Native + ")";
                return this.capture.Native;
            }
            var name = this.ResolveName();
            var expression = this.helper + "(" + (name == null ? "" : SourceSnapshot.Quote(name)) + ")";
            return Materialize(expression, this.clrType);
        }

        internal static string Materialize(string expression, string clrType)
        {
            var type = clrType.Replace("global::", "");
            return type == "Newtonsoft.Json.Linq.JToken" || type == "JToken"
                ? expression
                : expression + ".ToObject<" + clrType + ">()";
        }

        private string ResolveName()
        {
            if (this.parameterName != null) return this.parameterName;
            if (this.action == null && this.variable == null) return null;
            var name = this.variable != null ? this.variable.VariableName : this.action.Name;
            if (string.IsNullOrWhiteSpace(name)) throw new InvalidOperationException("A workflow binding has no final name.");
            return name;
        }
    }

    internal interface ISourceDescriptor
    {
        bool IsLiteral { get; }
        Type ResultType { get; }
        string Kind { get; }
        string RenderNative();
        JToken RenderToken();
    }

    internal interface ISourceJsonDescriptor : ISourceDescriptor { }

    internal interface ISourceValueDescriptor : ISourceDescriptor { }

    internal sealed class SourceValueDescriptor<T> : ISourceValueDescriptor
    {
        private readonly ISourceDescriptor native;
        private readonly ISourceDescriptor wire;

        internal SourceValueDescriptor(ISourceDescriptor native, ISourceDescriptor wire)
        {
            if (native.Kind != "native" || wire.Kind != "native")
                throw new ArgumentException("Workflow value descriptors require native C# source for both representations.");
            this.native = native;
            this.wire = wire;
        }

        public bool IsLiteral => false;
        public Type ResultType => typeof(T);
        public string Kind => "native";
        public T Invoke() => throw new InvalidOperationException("A workflow source descriptor is metadata and cannot be invoked.");
        public string RenderNative() => this.native.RenderNative();
        public JToken RenderToken() => this.wire.RenderToken();
    }

    internal interface ISourceStructure : ISourceDescriptor
    {
        IReadOnlyList<string> Names { get; }
        IReadOnlyList<ISourceDescriptor> Children { get; }
        WorkflowDestination Schema { get; }
    }

    internal sealed class SourceBoxDescriptor : ISourceDescriptor
    {
        internal SourceBoxDescriptor(ISourceDescriptor inner) { this.Inner = inner; }
        internal ISourceDescriptor Inner { get; }
        public bool IsLiteral => this.Inner.IsLiteral;
        public Type ResultType => this.Inner.ResultType;
        public string Kind => this.Inner.Kind;
        public object Invoke() => throw new InvalidOperationException("A workflow source descriptor is metadata and cannot be invoked.");
        public string RenderNative() => this.Inner.RenderNative();
        public JToken RenderToken() => this.Inner.RenderToken();
    }

    internal interface ISourceEnumDescriptor : ISourceDescriptor
    {
        string RenderNativeWire();
    }

    internal sealed class SourceEnumDescriptor<T> : ISourceEnumDescriptor
    {
        private readonly ISourceDescriptor value;
        private readonly ISourceDescriptor wire;

        internal SourceEnumDescriptor(ISourceDescriptor value, ISourceDescriptor wire)
        {
            if (wire.Kind == "object" || wire.Kind == "array")
                throw new ArgumentException("Enum wire source requires a scalar string descriptor.", nameof(wire));
            this.value = value;
            this.wire = wire;
        }

        public bool IsLiteral => false;
        public Type ResultType => typeof(T);
        public string Kind => "native";
        public T Invoke() => throw new InvalidOperationException("A workflow source descriptor is metadata and cannot be invoked.");
        public string RenderNative() => this.value.RenderNative();
        public string RenderNativeWire() => this.wire.RenderNative();
        public JToken RenderToken() => new JValue("#{" + this.RenderNativeWire() + "}");
    }

    internal sealed class SourceTokenDescriptor : ISourceDescriptor
    {
        internal SourceTokenDescriptor(ISourceDescriptor inner) { this.Inner = inner; }
        internal ISourceDescriptor Inner { get; }
        public bool IsLiteral => this.Inner.IsLiteral;
        public Type ResultType => this.Inner.ResultType;
        public string Kind => this.Inner.Kind;
        public JToken Invoke() => throw new InvalidOperationException("A workflow source descriptor is metadata and cannot be invoked.");
        public string RenderNative() => this.Inner.RenderNative();
        public JToken RenderToken() => this.Inner.RenderToken();
    }

    internal sealed class SourceJsonDescriptor<T> : ISourceJsonDescriptor
    {
        private readonly ISourceDescriptor input;

        internal SourceJsonDescriptor(ISourceDescriptor input)
        {
            if (input.Kind == "object" || input.Kind == "array")
                throw new ArgumentException("The JSON intrinsic requires a scalar string descriptor.", nameof(input));
            this.input = input;
        }

        public bool IsLiteral => false;
        public Type ResultType => typeof(T);
        public string Kind => "native";
        public T Invoke() => throw new InvalidOperationException("A workflow source descriptor is metadata and cannot be invoked.");
        public string RenderNative()
        {
            var native = this.input.RenderNative();
            if (this.input is ISourceJsonDescriptor)
                native = SourceBinding.Materialize(native, SourceSnapshot.TypeName(this.input.ResultType));
            return "json(" + native + ")";
        }
        public JToken RenderToken() => new JValue("#{" + this.RenderNative() + "}");
    }

    internal sealed class SourceDescriptor<T> : ISourceStructure
    {
        private readonly string[] segments;
        private readonly SourceBinding[] bindings;
        private readonly string[] nativeSegments;
        private readonly SourceSnapshot literal;
        private readonly string[] names;
        private readonly ISourceDescriptor[] children;
        private ISourceDescriptor nativeSource;
        public WorkflowDestination Schema { get; private set; }
        public IReadOnlyList<string> Names => this.names;
        public IReadOnlyList<ISourceDescriptor> Children => this.children;

        internal void SetNativeSource(ISourceDescriptor source) { this.nativeSource = source; }
        internal void SetSchema(WorkflowDestination schema) { this.Schema = schema; }

        internal SourceDescriptor(string kind, string[] segments, SourceBinding[] bindings, string[] nativeSegments)
        {
            this.Kind = kind;
            this.segments = segments;
            this.bindings = bindings;
            this.nativeSegments = nativeSegments;
        }

        internal SourceDescriptor(SourceSnapshot literal) { this.literal = literal; this.Kind = "literal"; }
        internal SourceDescriptor(string[] names, ISourceDescriptor[] children)
        {
            this.names = names;
            this.children = children;
            this.Kind = names == null ? "array" : "object";
        }

        public bool IsLiteral => this.literal != null || this.Kind == "capture" && this.bindings[0].IsCapture ||
            this.children != null && this.children.All(child => child.IsLiteral);
        public Type ResultType => typeof(T);
        public string Kind { get; }

        public T Invoke() => throw new InvalidOperationException("A workflow source descriptor is metadata and cannot be invoked.");

        public string RenderNative()
        {
            if (this.literal != null) return this.literal.Native;
            if (this.Kind == "capture") return this.bindings[0].ToNative();
            if (this.children != null)
                return this.nativeSource?.RenderNative() ?? throw new NotSupportedException("Structured descriptor cannot be rendered as native source without compiler metadata.");
            if (this.Kind == "template" && this.nativeSegments != null)
                return this.Render(this.nativeSegments);
            if (this.Kind == "template" && this.bindings.Length == 1 && this.segments[0] == "@" && this.segments[1] == "")
                return this.bindings[0].ToNative();
            if (this.Kind != "native") throw new NotSupportedException("This template descriptor cannot be promoted to native C# without compiler source metadata.");
            return this.Render();
        }

        public JToken RenderToken()
        {
            if (this.Schema != null) return WorkflowSchemaRuntime.Render(this, this.Schema);
            if (this.literal != null) return SourceSnapshot.CloneJson(this.literal.Token);
            if (this.Kind == "capture")
                return this.bindings[0].IsCapture ? this.bindings[0].CaptureToken() : new JValue("#{" + this.bindings[0].ToNative() + "}");
            if (this.children != null)
            {
                if (this.names == null) return new JArray(this.children.Select(c => c.RenderToken()));
                var value = new JObject();
                for (int i = 0; i < this.names.Length; i++) value.Add(this.names[i], this.children[i].RenderToken());
                return value;
            }
            return new JValue("#{" + this.RenderNative() + "}");
        }

        private string Render(string[] sourceSegments = null)
        {
            sourceSegments = sourceSegments ?? this.segments;
            var text = new StringBuilder(sourceSegments[0]);
            for (int i = 0; i < this.bindings.Length; i++)
                text.Append(this.bindings[i].ToNative()).Append(sourceSegments[i + 1]);
            return text.ToString();
        }
    }

    internal sealed class SourceSnapshot
    {
        internal JToken Token { get; private set; }
        internal string Native { get; private set; }
        internal Type RuntimeType { get; private set; }

        internal static string Quote(string value) => JsonConvert.ToString(value);

        internal static SourceSnapshot Create(object value) => Create(value, new HashSet<object>(ReferenceComparer.Instance));

        private static SourceSnapshot Create(object value, HashSet<object> visiting)
        {
            if (value == null) return new SourceSnapshot { Token = JValue.CreateNull(), Native = "null" };
            var type = value.GetType();
            string native;
            JToken token;
            if (value is string text) { native = Quote(text); token = new JValue(text); }
            else if (value is char character) { native = "(char)" + ((int)character).ToString(CultureInfo.InvariantCulture); token = new JValue(character.ToString()); }
            else if (value is bool flag) { native = flag ? "true" : "false"; token = new JValue(flag); }
            else if (value is Enum choice)
            {
                native = "(" + TypeName(type) + ")" + System.Convert.ToString(System.Convert.ChangeType(choice, Enum.GetUnderlyingType(type), CultureInfo.InvariantCulture), CultureInfo.InvariantCulture);
                token = new JValue(SourceExpressionConverter.EnumWire(choice));
            }
            else if (value is Uri uri) { native = "new global::System.Uri(" + Quote(uri.OriginalString) + ", global::System.UriKind.RelativeOrAbsolute)"; token = new JValue(uri.OriginalString); }
            else if (value is System.Net.Http.HttpMethod method) { native = "new global::System.Net.Http.HttpMethod(" + Quote(method.Method) + ")"; token = new JValue(method.Method); }
            else if (value is Guid guid) { native = "new global::System.Guid(" + Quote(guid.ToString()) + ")"; token = new JValue(guid.ToString()); }
            else if (value is DateTime date) { native = "new global::System.DateTime(" + date.Ticks + "L, global::System.DateTimeKind." + date.Kind + ")"; token = new JValue(date); }
            else if (value is DateTimeOffset offset) { native = "new global::System.DateTimeOffset(" + offset.Ticks + "L, new global::System.TimeSpan(" + offset.Offset.Ticks + "L))"; token = new JValue(offset); }
            else if (value is byte[] bytes)
            {
                var copy = (byte[])bytes.Clone();
                token = new JValue(copy);
                native = "new global::System.Byte[] { " + string.Join(", ", copy.Select(b => b.ToString(CultureInfo.InvariantCulture))) + " }";
            }
            else if (type.IsPrimitive || value is decimal)
            {
                if (value is double d && (double.IsNaN(d) || double.IsInfinity(d)) ||
                    value is float f && (float.IsNaN(f) || float.IsInfinity(f)))
                    throw new NotSupportedException("Non-finite numeric captures are not JSON values.");
                native = value is double doubleValue
                    ? doubleValue == 0 && BitConverter.DoubleToInt64Bits(doubleValue) < 0 ? "-0.0" : doubleValue.ToString("R", CultureInfo.InvariantCulture) :
                    value is float floatValue
                    ? floatValue == 0 && BitConverter.ToInt32(BitConverter.GetBytes(floatValue), 0) < 0 ? "-0.0" : floatValue.ToString("R", CultureInfo.InvariantCulture) :
                    System.Convert.ToString(value, CultureInfo.InvariantCulture);
                if (value is decimal) native += "m";
                else if (value is float) native += "f";
                else if (value is double) native += "d";
                else if (value is ulong) native += "UL";
                else if (value is long) native += "L";
                else if (value is uint) native += "U";
                else if (type != typeof(int)) native = "(" + TypeName(type) + ")" + native;
                token = new JValue(value);
            }
            else if (value is JToken json && type.Assembly == typeof(JToken).Assembly)
            {
                token = CloneJson(json);
                native = "((" + TypeName(type) + ")global::Newtonsoft.Json.Linq.JToken.Parse(" + Quote(token.ToString(Formatting.None)) + "))";
            }
            else
            {
                if (!visiting.Add(value)) throw new NotSupportedException("Cyclic captured collections are unsupported.");
                try
                {
                    if (type.IsArray && ((System.Array)value).Rank == 1 || type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>))
                    {
                        var items = ((IEnumerable)value).Cast<object>().Select(v => Create(v, visiting)).ToArray();
                        token = new JArray(items.Select(v => v.Token));
                        native = "new " + TypeName(type) + " { " + string.Join(", ", items.Select(v => v.Native)) + " }";
                    }
                    else if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Dictionary<,>) && type.GetGenericArguments()[0] == typeof(string))
                    {
                        var obj = new JObject();
                        var items = new List<string>();
                        foreach (DictionaryEntry entry in (IDictionary)value)
                        {
                            var item = Create(entry.Value, visiting);
                            obj.Add((string)entry.Key, item.Token);
                            items.Add("[" + Quote((string)entry.Key) + "] = " + item.Native);
                        }
                        token = obj;
                        native = "new " + TypeName(type) + " { " + string.Join(", ", items) + " }";
                    }
                    else throw new NotSupportedException($"Captured type '{type.FullName}' is unsupported. Capture approved scalar values, JSON tokens, arrays, lists, or string-keyed dictionaries; custom getters and serializers are never executed.");
                }
                finally { visiting.Remove(value); }
            }
            return new SourceSnapshot { Token = token, Native = native, RuntimeType = type };
        }

        internal static bool MatchesDeclaredType(string declaredType, Type runtimeType)
        {
            if (runtimeType == null) return false;
            var normalized = Regex.Replace(declaredType.Replace("global::", ""), @"\s+", "");
            normalized = Regex.Replace(normalized,
                @"(?<![\w.@])(?:bool|byte|sbyte|short|ushort|int|uint|long|ulong|float|double|decimal|char|string|object)(?!\w)",
                match => PrimitiveTypeNames[match.Value]);
            return normalized == TypeName(runtimeType).Replace("global::", "").Replace(" ", "");
        }

        private static readonly Dictionary<string, string> PrimitiveTypeNames = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            ["bool"] = "System.Boolean", ["byte"] = "System.Byte", ["sbyte"] = "System.SByte",
            ["short"] = "System.Int16", ["ushort"] = "System.UInt16", ["int"] = "System.Int32",
            ["uint"] = "System.UInt32", ["long"] = "System.Int64", ["ulong"] = "System.UInt64",
            ["float"] = "System.Single", ["double"] = "System.Double", ["decimal"] = "System.Decimal",
            ["char"] = "System.Char", ["string"] = "System.String", ["object"] = "System.Object",
        };

        internal static string TypeName(Type type)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));
            if (type.ContainsGenericParameters || type.IsByRef || type.IsPointer || type == typeof(void))
                throw new NotSupportedException($"CLR binding type '{type}' must be a closed, non-pointer value type or reference type.");
            if (type.IsArray)
                return TypeName(type.GetElementType()) + "[" + new string(',', type.GetArrayRank() - 1) + "]";

            var nesting = new Stack<Type>();
            for (var current = type; current != null; current = current.DeclaringType) nesting.Push(current);
            var arguments = type.IsGenericType ? type.GetGenericArguments() : Type.EmptyTypes;
            var argumentIndex = 0;
            var text = new StringBuilder("global::");
            if (!string.IsNullOrEmpty(type.Namespace))
                text.Append(string.Join(".", type.Namespace.Split('.').Select(TypeIdentifier))).Append('.');
            while (nesting.Count > 0)
            {
                var name = nesting.Pop().Name;
                var tick = name.IndexOf('`');
                text.Append(TypeIdentifier(tick < 0 ? name : name.Substring(0, tick)));
                if (tick >= 0)
                {
                    var arity = int.Parse(name.Substring(tick + 1), CultureInfo.InvariantCulture);
                    if (argumentIndex + arity > arguments.Length)
                        throw new NotSupportedException($"CLR binding type '{type}' has unsupported generic nesting.");
                    text.Append('<').Append(string.Join(", ", arguments.Skip(argumentIndex).Take(arity).Select(TypeName))).Append('>');
                    argumentIndex += arity;
                }
                if (nesting.Count > 0) text.Append('.');
            }
            if (argumentIndex != arguments.Length)
                throw new NotSupportedException($"CLR binding type '{type}' has unsupported generic nesting.");
            return text.ToString();
        }

        private static string TypeIdentifier(string name)
        {
            if (name.Length == 0 || !(char.IsLetter(name[0]) || name[0] == '_') ||
                name.Skip(1).Any(c => !(char.IsLetterOrDigit(c) || c == '_')))
                throw new NotSupportedException($"CLR type identifier '{name}' cannot be referenced in preserved C# source.");
            return CSharpKeywords.Contains(name) ? "@" + name : name;
        }

        private static readonly HashSet<string> CSharpKeywords = new HashSet<string>(StringComparer.Ordinal)
        {
            "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked",
            "class", "const", "continue", "decimal", "default", "delegate", "do", "double", "else",
            "enum", "event", "explicit", "extern", "false", "finally", "fixed", "float", "for",
            "foreach", "goto", "if", "implicit", "in", "int", "interface", "internal", "is", "lock",
            "long", "namespace", "new", "null", "object", "operator", "out", "override", "params",
            "private", "protected", "public", "readonly", "ref", "return", "sbyte", "sealed", "short",
            "sizeof", "stackalloc", "static", "string", "struct", "switch", "this", "throw", "true",
            "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort", "using", "virtual",
            "void", "volatile", "while",
        };

        internal static string EscapeLiteral(string text)
        {
            if (text.StartsWith("@", StringComparison.Ordinal)) return "@" + text;
            if (text.StartsWith("#{", StringComparison.Ordinal) || text.Contains("@{"))
                return "#{" + Quote(text) + "}";
            return text;
        }

        internal static JToken CloneJson(JToken token, bool escapeLiterals = false)
        {
            if (token.GetType() == typeof(JObject))
            {
                var result = new JObject();
                foreach (var property in ((JObject)token).Properties())
                    result.Add(property.Name, CloneJson(property.Value, escapeLiterals));
                return result;
            }
            if (token.GetType() == typeof(JArray))
                return new JArray(((JArray)token).Select(value => CloneJson(value, escapeLiterals)));
            if (token.GetType() == typeof(JValue) && token.Type != JTokenType.Undefined && token.Type != JTokenType.Comment)
            {
                var value = ((JValue)token).Value;
                if (escapeLiterals && value is string text)
                    return new JValue(EscapeLiteral(text));
                if (value is double d && (double.IsNaN(d) || double.IsInfinity(d)) ||
                    value is float f && (float.IsNaN(f) || float.IsInfinity(f)))
                    throw new NotSupportedException("Non-finite numeric captures are not JSON values.");
                if (value is Uri uri)
                {
                    if (escapeLiterals && EscapeLiteral(uri.OriginalString) is string escaped && escaped != uri.OriginalString)
                        return new JValue(escaped);
                    return new JValue(new Uri(uri.OriginalString, UriKind.RelativeOrAbsolute));
                }
                return new JValue(value is byte[] bytes ? (byte[])bytes.Clone() : value);
            }
            throw new NotSupportedException($"Captured JSON token type '{token.GetType().FullName}' is unsupported.");
        }

        private sealed class ReferenceComparer : IEqualityComparer<object>
        {
            internal static readonly ReferenceComparer Instance = new ReferenceComparer();
            public new bool Equals(object x, object y) => ReferenceEquals(x, y);
            public int GetHashCode(object obj) => System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(obj);
        }
    }
}
