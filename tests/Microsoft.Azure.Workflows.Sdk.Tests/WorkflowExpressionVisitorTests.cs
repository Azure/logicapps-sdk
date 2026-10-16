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
                """new[] { outputs("Source").ToObject<int>(), 2 }.Select((int value) => value + 3).Single()""",
                Input(action));
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
                "new[] { (byte)1, (byte)2, (byte)3 }",
                Input(WorkflowActions.BuiltIn.Compose(() => new byte[] { 1, 2, 3 })));
            AssertReturnExpression(
                """new global::System.Net.Http.HttpMethod("POST")""",
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
                WorkflowFunctions.ToJson<SendMessageInputMessageType>("{\"messageId\":\"id\"}").MessageId);

            AssertReturnExpression(
                """json("{\"messageId\":\"id\"}").ToObject<global::Microsoft.Azure.Workflows.Sdk.ServiceProviders.ServiceBus.SendMessageInputMessageType>().MessageId""",
                Input(action));
        }

        [Fact]
        public void CustomDtoWorkflowPathsUseJsonPropertyNames()
        {
            var customer = new TestOutputAction<Customer>().WithName("Customer");
            var action = WorkflowActions.BuiltIn.Compose(() => customer.Output.Address.City);

            AssertReturnExpression(
                """outputs("Customer")["address"]["city_name"].ToObject<string>()""",
                Input(action));

            var function = WorkflowActions.BuiltIn.Compose(
                () => WorkflowFunctions.ToJson<Customer>(
                    "{\"address\":{\"city_name\":\"Seattle\"}}").Address.City);
            AssertReturnExpression(
                """json("{\"address\":{\"city_name\":\"Seattle\"}}")["address"]["city_name"].ToObject<string>()""",
                Input(function));

            Assert.Throws<NotSupportedException>(
                () => WorkflowActions.BuiltIn.Compose<Customer>(() => customer.Output));
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

        private sealed class TestOutputAction<T> : WorkflowActionBase, IOutputWorkflowAction<T>
        {
            public T Output => default;

            public override FlowTemplateAction GetActionDefinition(string flowName, FlowKind? flowKind = null) =>
                throw new NotSupportedException();
        }
    }
}
