// Copyright (c) Microsoft Corporation. All rights reserved.
namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.ServiceBus;
    using Newtonsoft.Json.Linq;
    using Xunit;
    using static WorkflowExpressionTestSource;

    public class WorkflowExpressionVisitorTests
    {
        [Fact]
        public void ArithmeticLinqAndNestedLambdasRemainCSharp()
        {
            var offset = 3;
            var source = WorkflowActions.BuiltIn.Compose<int>(() => 1).WithName("Source");
            var action = WorkflowActions.BuiltIn.Compose(() =>
                new[] { source.Output, 2 }.Select((int value) => value + offset).Single());
            offset = 100;

            AssertReturnExpression(
                """
                global::System.Linq.Enumerable.Single<int>(
                    global::System.Linq.Enumerable.Select<int, int>(
                        (global::System.Collections.Generic.IEnumerable<int>)new int[] { outputs("Source").ToObject<int>(), 2 },
                        (int value) => value + 3))
                """,
                Input(action));
        }

        [Fact]
        public void LinqOverAnonymousTypesUsesImplicitLambdaParameters()
        {
            var action = WorkflowActions.BuiltIn.Compose(
                () => new[]
                {
                    new { Value = 1 },
                    new { Value = 2 },
                }
                .Select(item => item.Value)
                .Single());

            var source = Input(action);
            Assert.DoesNotContain("AnonymousType", source);
            AssertReturnExpression(
                """
                global::System.Linq.Enumerable.Single<int>(
                    global::System.Linq.Enumerable.Select(
                        new[] { new { Value = 1 }, new { Value = 2 } },
                        (item) => item.Value))
                """,
                source);
        }

        [Fact]
        public void ComposedExpressionsAreUniversallyParenthesized()
        {
            var source = WorkflowActions.BuiltIn.Compose<int>(() => 1).WithName("Source");

            var precedence = Input(WorkflowActions.BuiltIn.Compose(() => (source.Output + 2) * 3));
            Assert.Equal(
                """#{(((outputs("Source")).ToObject<int>()) + (2)) * (3)}""",
                precedence);

            var associativity = Input(WorkflowActions.BuiltIn.Compose(
                () => source.Output - (source.Output - 1)));
            Assert.Equal(
                """#{((outputs("Source")).ToObject<int>()) - (((outputs("Source")).ToObject<int>()) - (1))}""",
                associativity);
        }

        [Fact]
        public void SpecialClrValuesRemainRuntimeExpressions()
        {
            AssertReturnExpression(
                "new byte[] { (byte)1, (byte)2, (byte)3 }",
                Input(WorkflowActions.BuiltIn.Compose(() => new byte[] { 1, 2, 3 })));
            AssertReturnExpression(
                "global::System.Net.Http.HttpMethod.Post",
                Input(WorkflowActions.BuiltIn.Compose(() => System.Net.Http.HttpMethod.Post)));

            var method = System.Net.Http.HttpMethod.Patch;
            AssertReturnExpression(
                """new global::System.Net.Http.HttpMethod("PATCH")""",
                Input(WorkflowActions.BuiltIn.Compose(() => method)));
            AssertReturnExpression(
                "global::Microsoft.Azure.Workflows.Sdk.MessageRole.User",
                Input(WorkflowActions.BuiltIn.Compose(() => MessageRole.User)));
        }

        [Fact]
        public void ObjectCollectionAndAnonymousInitializersRemainCSharp()
        {
            var previous = WorkflowActions.BuiltIn.Compose<string>(() => "id").WithName("Source");
            var dto = WorkflowActions.BuiltIn.Compose(() => new SendMessageInputMessageType
            {
                MessageId = previous.Output,
            });
            AssertReturnExpression(
                """new global::Microsoft.Azure.Workflows.Sdk.ServiceProviders.ServiceBus.SendMessageInputMessageType { MessageId = outputs("Source").ToObject<string>() }""",
                Input(dto));
            AssertReturnExpression(
                """new global::System.Collections.Generic.Dictionary<string, string>() { { "kind", "test" } }""",
                Input(WorkflowActions.BuiltIn.Compose(
                    () => new Dictionary<string, string> { { "kind", "test" } })));

            var anonymous = WorkflowActions.BuiltIn.Compose(() => new
            {
                Value = DateTime.UtcNow.Year,
                Role = MessageRole.User,
            });
            AssertReturnExpression(
                "new { Value = global::System.DateTime.UtcNow.Year, Role = global::Microsoft.Azure.Workflows.Sdk.MessageRole.User }",
                Input(anonymous));
        }

        [Fact]
        public void NestedMemberAndCollectionInitializersRemainCSharp()
        {
            var member = WorkflowActions.BuiltIn.Compose(() => new AgentModelSettings
            {
                AgentChatCompletionSettings =
                {
                    MaxTokens = 1,
                },
            });
            AssertReturnExpression(
                """
                new global::Microsoft.Azure.Workflows.Sdk.AgentModelSettings
                {
                    AgentChatCompletionSettings = { MaxTokens = (int?)1 }
                }
                """,
                Input(member));

            var collection = WorkflowActions.BuiltIn.Compose(() => new HttpRequestMessage
            {
                Headers =
                {
                    { "X-Test", "value" },
                },
            });
            AssertReturnExpression(
                """
                new global::System.Net.Http.HttpRequestMessage
                {
                    Headers = { { "X-Test", "value" } }
                }
                """,
                Input(collection));
        }

        [Fact]
        public void SdkDtoWorkflowRootsUseClrMemberAccess()
        {
            var message = WorkflowActions.BuiltIn.Compose<SendMessageInputMessageType>(
                () => new SendMessageInputMessageType { MessageId = "id" })
                .WithName("Message");
            var action = WorkflowActions.BuiltIn.Compose(
                () => message.Output.MessageId.ToUpperInvariant());

            AssertReturnExpression(
                """outputs("Message").ToObject<global::Microsoft.Azure.Workflows.Sdk.ServiceProviders.ServiceBus.SendMessageInputMessageType>().MessageId.ToUpperInvariant()""",
                Input(action));
        }

        [Fact]
        public void CheckedCastsAndConditionalsRemainCSharp()
        {
            var value = WorkflowActions.BuiltIn.Compose<object>(
                () => new SendMessageInputMessageType { MessageId = "id" }).WithName("Object");
            var action = WorkflowActions.BuiltIn.Compose(() =>
                checked(((SendMessageInputMessageType)value.Output).MessageId.Length + 1));

            AssertReturnExpression(
                """checked(((global::Microsoft.Azure.Workflows.Sdk.ServiceProviders.ServiceBus.SendMessageInputMessageType)outputs("Object").ToObject<object>()).MessageId.Length + 1)""",
                Input(action));
        }

        [Fact]
        public void WorkflowFunctionsBecomeExistingHostCalls()
        {
            var action = WorkflowActions.BuiltIn.Compose(() =>
                WorkflowFunctions.ParseJson<SendMessageInputMessageType>("{\"messageId\":\"id\"}").MessageId);

            AssertReturnExpression(
                """json("{\"messageId\":\"id\"}").ToObject<global::Microsoft.Azure.Workflows.Sdk.ServiceProviders.ServiceBus.SendMessageInputMessageType>().MessageId""",
                Input(action));
            AssertReturnExpression(
                """json("\"value\"").ToObject<string>()""",
                Input(WorkflowActions.BuiltIn.Compose(
                    () => WorkflowFunctions.ParseJson<string>("\"value\""))));
            AssertReturnExpression(
                """json("true").ToObject<bool>()""",
                Input(WorkflowActions.BuiltIn.Compose(
                    () => WorkflowFunctions.ParseJson<bool>("true"))));
            AssertReturnExpression(
                """json("{}")""",
                Input(WorkflowActions.BuiltIn.Compose<JToken>(
                    () => WorkflowFunctions.ParseJson("{}"))));
            AssertReturnExpression(
                "listCallbackUrl()",
                Input(WorkflowActions.BuiltIn.Compose(
                    () => WorkflowFunctions.ListCallbackUrl())));
        }

        [Fact]
        public void WorkflowContextFunctionsUseRuntimeMappings()
        {
            AssertReturnExpression(
                """parameters("Parameter")""",
                Input(WorkflowActions.BuiltIn.Compose<JToken>(
                    () => WorkflowFunctions.Parameters("Parameter"))));
            AssertReturnExpression(
                "workflow()",
                Input(WorkflowActions.BuiltIn.Compose<JToken>(
                    () => WorkflowFunctions.Workflow())));
            AssertReturnExpression(
                """result("Scope")""",
                Input(WorkflowActions.BuiltIn.Compose<JToken>(
                    () => WorkflowFunctions.Result("Scope"))));
            AssertReturnExpression(
                """items("OuterLoop")""",
                Input(WorkflowActions.BuiltIn.Compose<JToken>(
                    () => WorkflowFunctions.Items("OuterLoop"))));
            AssertReturnExpression(
                """iterationIndexes("UntilLoop")""",
                Input(WorkflowActions.BuiltIn.Compose<JToken>(
                    () => WorkflowFunctions.IterationIndexes("UntilLoop"))));
            AssertReturnExpression(
                """parameters("Count").ToObject<int>() + 1""",
                Input(WorkflowActions.BuiltIn.Compose(
                    () => WorkflowFunctions.Parameters("Count").ToObject<int>() + 1)));
        }

        [Fact]
        public void StringFormatAndSelectedOverloadsRemainExplicit()
        {
            var value = 1;
            var formatted = WorkflowActions.BuiltIn.Compose<string>(() => $"{value}");
            var formattedSource = Input(formatted);
            Assert.Contains("string.Format", formattedSource);
            Assert.DoesNotContain("JsonConvert.SerializeObject", formattedSource);
            AssertReturnExpression(
                """string.Format("{0}", (object)1)""",
                formattedSource);

            var concatMethod = typeof(string).GetMethod(
                nameof(string.Concat),
                new[] { typeof(object), typeof(object) });
            var concatExpression = Expression.Lambda<Func<string>>(
                Expression.Call(
                    concatMethod,
                    Expression.Constant("a"),
                    Expression.Constant("b")));
            AssertReturnExpression(
                """string.Concat((object)"a", (object)"b")""",
                Input(WorkflowActions.BuiltIn.Compose(concatExpression)));
        }

        [Fact]
        public void CustomDtoWorkflowPathsUseJsonPropertyNames()
        {
            var customer = new TestOutputAction<Customer>().WithName("Customer");
            var action = WorkflowActions.BuiltIn.Compose(() => customer.Output.Address.City);

            AssertReturnExpression(
                """outputs("Customer")["address"]["city_name"]?.ToObject<string>() ?? default(string)""",
                Input(action));

            var function = WorkflowActions.BuiltIn.Compose(
                () => WorkflowFunctions.ParseJson<Customer>(
                    "{\"address\":{\"city_name\":\"Seattle\"}}").Address.City);
            AssertReturnExpression(
                """json("{\"address\":{\"city_name\":\"Seattle\"}}")["address"]["city_name"]?.ToObject<string>() ?? default(string)""",
                Input(function));

            Assert.Throws<NotSupportedException>(
                () => WorkflowActions.BuiltIn.Compose<Customer>(() => customer.Output));
            Assert.Throws<NotSupportedException>(
                () => WorkflowActions.BuiltIn.Compose(
                    () => WorkflowFunctions.ParseJson<Customer>("{}")));
        }

        [Fact]
        public void ReusedExpressionAndLiteralNullResultsWork()
        {
            var suffix = "!";
            Expression<Func<string>> source = () => suffix;
            var first = WorkflowActions.BuiltIn.Compose(source);
            suffix = "?";

            Assert.Equal("!", ((JToken)first.GetActionDefinition("flow").Inputs).Value<string>());
            Assert.Throws<ArgumentException>(() => WorkflowActions.BuiltIn.Compose<object>(() => null));
        }

        [Fact]
        public void UnsupportedProgrammaticExpressionNodesFailExplicitly()
        {
            var variable = Expression.Variable(typeof(int), "value");
            var assignment = Expression.Lambda<Func<int>>(
                Expression.Block(new[] { variable }, Expression.Assign(variable, Expression.Constant(1)), variable));

            Assert.Throws<NotSupportedException>(() => WorkflowActions.BuiltIn.Compose(assignment));
            Assert.Throws<NotSupportedException>(
                () => WorkflowActions.BuiltIn.Compose(() => Task.FromResult(1)));
            Assert.Throws<NotSupportedException>(
                () => WorkflowActions.BuiltIn.Compose(
                    () => new HttpClient().GetStringAsync("https://example.com").Result));
        }

        private sealed class Customer
        {
            [Newtonsoft.Json.JsonProperty("address")]
            public Address Address { get; set; }
        }

        private sealed class Address
        {
            [Newtonsoft.Json.JsonProperty("city_name")]
            public string City { get; set; }
        }

        private sealed class TestOutputAction<T> : IOutputWorkflowAction<T>
        {
            public string Name { get; set; }

            public List<IWorkflowAction> Children { get; } = new();

            public Dictionary<string, FlowStatus[]> RunAfterConfig { get; } = new();

            public T Output => default;

            public FlowTemplateAction GetActionDefinition(string flowName, FlowKind? flowKind = null) =>
                throw new NotSupportedException();

            public OperationChain Then(IWorkflowAction action) => throw new NotSupportedException();

            public OperationChain Then(IWorkflowAction action, FlowStatus[] runAfter) => throw new NotSupportedException();

            public OperationChain Then(IWorkflowAction action, RunAfter[] runAfter) => throw new NotSupportedException();

            public OperationChain Then(Func<IChainableNode, OperationChain[]> branches) => throw new NotSupportedException();

            public IWorkflowOperation GetRootOperation() => this;
        }

    }
}
