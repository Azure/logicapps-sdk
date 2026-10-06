namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionTests;

using System.Reflection;
using System.Runtime.ExceptionServices;
using Microsoft.Azure.Workflows.Sdk.Connectors.Abbreviationsip;
using Microsoft.Azure.Workflows.Sdk.Connectors.Acceptmission;
using Microsoft.Azure.Workflows.Sdk.Connectors.A365copilotchatmcp;
using Microsoft.Azure.Workflows.Sdk.Connectors.Azureeventgrid;
using Microsoft.Azure.Workflows.Sdk.Connectors.Dropbox;
using Microsoft.Azure.Workflows.Sdk.Connectors.Slack;
using Microsoft.Azure.Workflows.Sdk.ServiceProviders.AzureBlob;
using Newtonsoft.Json.Linq;
using QueueActions = Microsoft.Azure.Workflows.Sdk.ServiceProviders.Azurequeues.AzurequeuesActions;
using QueueTriggers = Microsoft.Azure.Workflows.Sdk.ServiceProviders.Azurequeues.AzurequeuesTriggers;

public sealed class ConnectorValidationContractTests
{
    public static IEnumerable<object[]> Parameters()
    {
        yield return [typeof(AcceptmissionActions), "GetcategoriesId", "id", true];
        yield return [typeof(AbbreviationsipActions), "AbbrGet", "term", true];
        yield return [typeof(AbbreviationsipActions), "AbbrGet", "categoryid", false];
        yield return [typeof(AbbreviationsipActions), "AbbrGet", "sortby", false];
        yield return [typeof(DropboxActions), "CreateFile", "body", false];
        yield return [typeof(SlackActions), "PostMessage", "messagemessageText", true];
        yield return [typeof(A365copilotchatmcpActions), "McpM365copilot", "mcpSessionId", false];
        yield return [typeof(AzureeventgridTriggers), "CreateSubscription", "subscriptionId", true];
        yield return [typeof(AzureeventgridTriggers), "CreateSubscription", "resourceType", true];
        yield return [typeof(AzureeventgridTriggers), "CreateSubscription", "bodypropertiesfiltereventType", false];
        yield return [typeof(AzureBlobActions), "UploadBlob", "content", true];
        yield return [typeof(QueueActions), "PutMessage", "message", true];
        yield return [typeof(QueueActions), "PutMessage", "timeToLive", false];
        yield return [typeof(QueueTriggers), "ReceiveQueueMessages", "queueName", true];
        yield return [typeof(QueueTriggers), "SpecifiedNumberOfMessagesAvailable", "threshold", true];
    }

    public static IEnumerable<object[]> ParameterIdentities() =>
        Parameters().Select(row => row.Take(3).ToArray());

    [Theory]
    [MemberData(nameof(Parameters))]
    public void Null_delegate_is_rejected_at_invocation_only_when_required(
        Type connector, string method, string parameter, bool required)
    {
        var call = PrepareCall(connector, method, parameter, null);
        if (required)
        {
            var error = Assert.Throws<ArgumentNullException>(call.Invoke);
            Assert.Equal(parameter, error.ParamName);
        }
        else
        {
            Assert.NotNull(Render(call.Invoke()));
        }
    }

    [Theory]
    [MemberData(nameof(Parameters))]
    public void Literal_default_is_rejected_only_when_it_is_null_and_required(
        Type connector, string method, string parameter, bool required)
    {
        var valueType = Parameter(connector, method, parameter).ParameterType.GenericTypeArguments.Single();
        var value = valueType.IsValueType ? Activator.CreateInstance(valueType) : null;
        var call = PrepareCall(connector, method, parameter, Literal(valueType, value));
        if (required && value == null)
        {
            var error = Assert.Throws<ArgumentException>(call.Invoke);
            Assert.Equal(parameter, error.ParamName);
            Assert.StartsWith("A required workflow argument cannot be null.", error.Message);
        }
        else
        {
            Assert.NotNull(Render(call.Invoke()));
        }
    }

    [Theory]
    [MemberData(nameof(ParameterIdentities))]
    public void Raw_delegate_is_rejected_at_invocation_without_executing(
        Type connector, string method, string parameter)
    {
        var calls = 0;
        var valueType = Parameter(connector, method, parameter).ParameterType.GenericTypeArguments.Single();
        var raw = CreateRaw(valueType, () => calls++);
        var call = PrepareCall(connector, method, parameter, raw);
        var error = Record.Exception(call.Invoke);
        Assert.Equal(0, calls);
        Assert.IsType<NotSupportedException>(error);
        Assert.Contains("Missing workflow source expression metadata", error.Message);
    }

    [Theory]
    [MemberData(nameof(ParameterIdentities))]
    public void Multicast_delegate_with_valid_descriptor_tail_is_rejected_without_execution(
        Type connector, string method, string parameter)
    {
        var calls = 0;
        var valueType = Parameter(connector, method, parameter).ParameterType.GenericTypeArguments.Single();
        var multicast = Delegate.Combine(CreateRaw(valueType, () => calls++), Literal(valueType, Sample(valueType)));
        var call = PrepareCall(connector, method, parameter, multicast);
        var error = Record.Exception(call.Invoke);
        Assert.Equal(0, calls);
        Assert.IsType<NotSupportedException>(error);
        Assert.Contains("Missing workflow source expression metadata", error.Message);
    }

    [Theory]
    [MemberData(nameof(ParameterIdentities))]
    public void Valid_descriptors_are_accepted_and_render_deterministically(
        Type connector, string method, string parameter)
    {
        var valueType = Parameter(connector, method, parameter).ParameterType.GenericTypeArguments.Single();
        var call = PrepareCall(connector, method, parameter, Literal(valueType, Sample(valueType)));
        var operation = call.Invoke();
        Assert.True(JToken.DeepEquals(Render(operation), Render(operation)));
    }

    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("value")]
    public void Required_query_accepts_non_null_strings_without_extra_policy(string value)
    {
        var action = new AbbreviationsipActions("connection").AbbrGet(SourceExpression.Literal(1, value));
        Assert.Equal(value, ConsumerCompilation.Token(action.GetActionDefinition("contract"))["queries"]!["term"]!.Value<string>());
    }

    [Fact]
    public void Omitted_optional_queries_remain_omitted_and_explicit_values_remain_present()
    {
        var connector = new AbbreviationsipActions("connection");
        var omitted = ConsumerCompilation.Token(connector.AbbrGet(SourceExpression.Literal(1, "term")).GetActionDefinition("contract"));
        var present = ConsumerCompilation.Token(connector.AbbrGet(SourceExpression.Literal(1, "term"),
            categoryid: SourceExpression.Literal(1, "")).GetActionDefinition("contract"));
        Assert.Null(omitted["queries"]!["categoryid"]);
        Assert.Equal("", present["queries"]!["categoryid"]!.Value<string>());
    }

    [Theory]
    [InlineData("null", true)]
    [InlineData("() => (string)null", false)]
    [InlineData("() => captured", false)]
    [InlineData("Factory()", false)]
    public void Compiled_required_query_rejects_null_before_returning_an_action(string argument, bool nullDelegate)
    {
        var prepared = ConsumerCompilation.Prepare(ConsumerCompilation.Source($$"""
            var marker = WorkflowActions.BuiltIn.Compose<string>(() => "valid");
            string captured = null;
            Func<string> Factory() => () => (string)null;
            var action = new Microsoft.Azure.Workflows.Sdk.Connectors.Abbreviationsip.AbbreviationsipActions("connection")
                .AbbrGet({{argument}});
            Returned = true;
            return action.GetActionDefinition("contract");
            """, "public static bool Returned;"));
        var error = Record.Exception(() => ConsumerCompilation.Invoke(prepared.Assembly, "Consumer", "Build"));
        if (nullDelegate)
            Assert.IsType<ArgumentNullException>(error);
        else
            Assert.IsType<ArgumentException>(error);
        Assert.Equal("term", ((ArgumentException)error!).ParamName);
        Assert.Equal(false, prepared.Assembly.GetType("Consumer")!.GetField("Returned")!.GetValue(null));
    }

    [Theory]
    [InlineData("null")]
    [InlineData("json-null")]
    [InlineData("boxed-null")]
    [InlineData("boxed-json-null")]
    public void Required_object_rejects_all_literal_null_representations(string representation)
    {
        var expression = representation switch
        {
            "null" => SourceExpression.Literal<object?>(1, null),
            "json-null" => SourceExpression.Literal<object>(1, JValue.CreateNull()),
            "boxed-null" => SourceExpression.Box(1, SourceExpression.Literal<string?>(1, null)),
            "boxed-json-null" => SourceExpression.Box(1, SourceExpression.Token(1, SourceExpression.Literal<string?>(1, null))),
            _ => throw new ArgumentOutOfRangeException(nameof(representation))
        };
        var error = Assert.Throws<ArgumentException>(() => new AzureBlobActions("connection").UploadBlob(
            SourceExpression.Literal(1, "container"), SourceExpression.Literal(1, "blob"), expression));
        Assert.Equal("content", error.ParamName);
    }

    [Theory]
    [InlineData("direct")]
    [InlineData("method-group")]
    [InlineData("reflection")]
    [InlineData("untransformed-assembly")]
    public void Required_query_null_is_rejected_for_every_call_path(string path)
    {
        var connector = new AbbreviationsipActions("connection");
        object Invoke() => path switch
        {
            "direct" => connector.AbbrGet(null),
            "method-group" => InvokeMethodGroup(connector),
            "reflection" => PrepareCall(typeof(AbbreviationsipActions), "AbbrGet", "term", null).Invoke(),
            "untransformed-assembly" => ConsumerCompilation.Invoke(
                ConsumerCompilation.Load(ConsumerCompilation.Compile("""
                    public static class Caller {
                        public static object Call() =>
                            new Microsoft.Azure.Workflows.Sdk.Connectors.Abbreviationsip.AbbreviationsipActions("connection")
                                .AbbrGet(null);
                    }
                    """)), "Caller", "Call")!,
            _ => throw new ArgumentOutOfRangeException(nameof(path))
        };
        var error = Assert.Throws<ArgumentNullException>(Invoke);
        Assert.Equal("term", error.ParamName);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void Compiled_call_evaluates_later_arguments_before_validating(bool namedArguments)
    {
        var invocation = namedArguments
            ? """connector.CreateSubscription(resourceType: () => "type", subscriptionId: () => (string)null, triggerName: Mark())"""
            : """connector.CreateSubscription(() => (string)null, () => "type", triggerName: Mark())""";
        var prepared = ConsumerCompilation.Prepare(ConsumerCompilation.Source($$"""
            var connector = new Microsoft.Azure.Workflows.Sdk.Connectors.Azureeventgrid.AzureeventgridTriggers("connection");
            {{invocation}};
            Returned = true;
            return null;
            """, """
            public static int Marks;
            public static bool Returned;
            public static string Mark() { Marks++; return "trigger"; }
            """));
        var error = Assert.Throws<ArgumentException>(() =>
            ConsumerCompilation.Invoke(prepared.Assembly, "Consumer", "Build"));
        Assert.Equal("subscriptionId", error.ParamName);
        Assert.Equal(1, prepared.Assembly.GetType("Consumer")!.GetField("Marks")!.GetValue(null));
        Assert.Equal(false, prepared.Assembly.GetType("Consumer")!.GetField("Returned")!.GetValue(null));
    }

    [Fact]
    public void Later_argument_exception_precedes_validation_failure()
    {
        var connector = new AzureeventgridTriggers("connection");
        var sentinel = new InvalidOperationException("later argument");
        string ThrowLater() => throw sentinel;
        var error = Record.Exception(() =>
            connector.CreateSubscription(null, SourceExpression.Literal(1, "type"), triggerName: ThrowLater()));
        Assert.Same(sentinel, error);
    }

    [Fact]
    public void Multiple_invalid_parameters_fail_in_declaration_order_not_named_argument_order()
    {
        var error = Assert.Throws<ArgumentNullException>(() =>
            new AzureeventgridTriggers("connection").CreateSubscription(resourceType: null, subscriptionId: null));
        Assert.Equal("subscriptionId", error.ParamName);
    }

    [Fact]
    public void Earlier_invalid_metadata_precedes_later_required_null()
    {
        var calls = 0;
        Func<string> raw = () => { calls++; return "unsafe"; };
        var error = Record.Exception(() =>
            new AzureeventgridTriggers("connection").CreateSubscription(resourceType: null, subscriptionId: raw));
        Assert.Equal(0, calls);
        Assert.IsType<NotSupportedException>(error);
    }

    [Fact]
    public void Validation_does_not_evaluate_native_expression_or_reject_a_runtime_null_reference()
    {
        var source = WorkflowActions.BuiltIn.Compose(SourceExpression.Literal<string?>(1, null)).WithName("Original");
        var expression = SourceExpression.Create<string>(1, "native", ["", ""],
            [SourceBinding.Output(source, "string")]);
        var action = new AbbreviationsipActions("connection").AbbrGet(expression);
        source.WithName("Renamed");
        var input = ConsumerCompilation.Token(action.GetActionDefinition("contract"));
        Assert.Equal("#{outputs(\"Renamed\").ToObject<string>()}", input["queries"]!["term"]!.Value<string>());
        var executable = SourceExpression.Create<string>(1, "native", ["ThrowIfExecuted()"], []);
        var second = new AbbreviationsipActions("connection").AbbrGet(executable);
        Assert.Equal("#{ThrowIfExecuted()}", ConsumerCompilation.Token(second.GetActionDefinition("contract"))["queries"]!["term"]!.Value<string>());
    }

    [Fact]
    public void Compiler_capture_snapshot_and_late_binding_survive_repeated_rendering()
    {
        var result = ConsumerCompilation.Build(ConsumerCompilation.Source("""
            var source = WorkflowActions.BuiltIn.Compose<string>(() => "seed").WithName("Original");
            var captured = "before";
            var connector = new Microsoft.Azure.Workflows.Sdk.Connectors.Abbreviationsip.AbbreviationsipActions("connection");
            var action = connector.AbbrGet(() => captured, categoryid: () => source.Output);
            captured = "after";
            source.WithName("First");
            First = JObject.Parse(action.GetActionDefinition("contract").ToJson());
            source.WithName("Second");
            return action.GetActionDefinition("contract");
            """, "public static JObject First;"));
        var first = (JObject)result.Assembly.GetType("Consumer")!.GetField("First")!.GetValue(null)!;
        var second = ConsumerCompilation.Token(result.Definition);
        Assert.Equal("before", first["inputs"]!["queries"]!["term"]!.Value<string>());
        Assert.Equal("before", second["queries"]!["term"]!.Value<string>());
        Assert.Contains("First", first["inputs"]!["queries"]!["categoryid"]!.Value<string>());
        Assert.Contains("Second", second["queries"]!["categoryid"]!.Value<string>());
        Assert.DoesNotContain("Second", first.ToString());
    }

    private static object InvokeMethodGroup(AbbreviationsipActions connector)
    {
        Func<Func<string>, Func<string>?, Func<sortbyInput>?, Func<searchtypeInput>?,
            IBodyWorkflowAction<AbbrGetResponse>> method = connector.AbbrGet;
        return method(null!, null, null, null);
    }

    private static ParameterInfo Parameter(Type connector, string method, string parameter) =>
        connector.GetMethod(method)!.GetParameters().Single(p => p.Name == parameter);

    private static Func<object> PrepareCall(
        Type connector, string methodName, string parameter, object? value)
    {
        var method = connector.GetMethod(methodName)!;
        var arguments = method.GetParameters().Select(p =>
            p.Name == parameter ? value :
            p.HasDefaultValue ? p.DefaultValue :
            Literal(p.ParameterType.GenericTypeArguments.Single(), Sample(p.ParameterType.GenericTypeArguments.Single()))).ToArray();
        var instance = Activator.CreateInstance(connector, "connection");
        object Invoke()
        {
            try { return method.Invoke(instance, arguments)!; }
            catch (TargetInvocationException error) when (error.InnerException != null)
            {
                ExceptionDispatchInfo.Capture(error.InnerException).Throw();
                throw;
            }
        }
        return Invoke;
    }

    private static object? Sample(Type type) => type == typeof(string) || type == typeof(object) ? "value" :
        type.IsArray ? Array.CreateInstance(type.GetElementType()!, 0) :
        type.IsValueType ? Activator.CreateInstance(type) :
        throw new NotSupportedException($"Add an explicit fixture for {type}.");

    private static Delegate Literal(Type type, object? value) =>
        (Delegate)typeof(SourceExpression).GetMethod(nameof(SourceExpression.Literal))!
            .MakeGenericMethod(type).Invoke(null, [1, value])!;

    private static Delegate CreateRaw(Type type, Action invoked) =>
        (Delegate)typeof(ConnectorValidationContractTests).GetMethod(nameof(Raw), BindingFlags.NonPublic | BindingFlags.Static)!
            .MakeGenericMethod(type).Invoke(null, [invoked])!;

    private static Func<T> Raw<T>(Action invoked) => () => { invoked(); return default!; };

    private static JToken Render(object operation) => operation switch
    {
        IWorkflowAction action => JObject.Parse(action.GetActionDefinition("contract").ToJson()),
        IWorkflowTrigger trigger => JObject.Parse(trigger.GetTriggerDefinition().ToJson()),
        _ => throw new NotSupportedException($"Unexpected operation type {operation.GetType()}.")
    };
}
