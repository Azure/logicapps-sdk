// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.Azure.Workflows.Sdk;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Office365;
    using Newtonsoft.Json.Linq;

    public class CSharpTypedWorkflowBoundaryTests
    {
        [Fact]
        public void Convert_TypedStringActionOutput_PreservesClrType()
        {
            var compose = WorkflowActions.BuiltIn.Compose<string>(() => "value").WithName("Compose");

            Assert.Equal(
                "outputs(\"Compose\").ToObject<string>().ToUpper()",
                CSharpExpressionConverter.ConvertO(() => compose.Output.ToUpper()));
        }

        [Fact]
        public void Convert_TypedPocoBody_UsesStructuralJsonAccess()
        {
            var action = new TestBodyWorkflowAction<Poco>("GetUser");

            Assert.Equal(
                "body(\"GetUser\")?[\"Name\"].ToObject<string>().ToUpper()",
                CSharpExpressionConverter.ConvertO(() => action.Body.Name.ToUpper()));
            Assert.Equal(
                "body(\"GetUser\")?[\"renamed\"].ToObject<string>()",
                CSharpExpressionConverter.ConvertO(() => action.Body.Tag));
        }

        [Fact]
        public void Convert_TypedNumericProperty_UsesNativeArithmetic()
        {
            var action = new TestBodyWorkflowAction<Poco>("GetUser");

            Assert.Equal(
                "body(\"GetUser\")?[\"Count\"].ToObject<int>() + 1",
                CSharpExpressionConverter.ConvertO(() => action.Body.Count + 1));
        }

        [Fact]
        public void Convert_TypedNestedProperty_UsesStructuralJsonPath()
        {
            var action = new TestBodyWorkflowAction<Poco>("GetUser");

            Assert.Equal(
                "body(\"GetUser\")?[\"Nested\"]?[\"Value\"].ToObject<string>().ToUpper()",
                CSharpExpressionConverter.ConvertO(() => action.Body.Nested.Value.ToUpper()));
        }

        [Fact]
        public void Convert_TypedListAndArray_SupportLinq()
        {
            var listAction = new TestBodyWorkflowAction<Poco>("GetUsers");
            var arrayAction = new TestBodyWorkflowAction<NestedPoco[]>("GetArray");

            Assert.Equal(
                "body(\"GetUsers\")?[\"Items\"].Children().Select(item => item?[\"Value\"].ToObject<string>()).ToList<string>()",
                CSharpExpressionConverter.ConvertO(() => listAction.Body.Items.Select(item => item.Value).ToList()));
            Assert.Equal(
                "body(\"GetArray\").Children().Select(item => item?[\"Value\"].ToObject<string>()).ToArray<string>()",
                CSharpExpressionConverter.ConvertO(() => arrayAction.Body.Select(item => item.Value).ToArray()));
        }

        [Fact]
        public void Convert_TypedDtoArray_SupportsIndexLengthAndConditionalAccess()
        {
            var first = new TestBodyWorkflowAction<NestedPoco[]>("First");
            var second = new TestBodyWorkflowAction<NestedPoco[]>("Second");
            var useFirst = true;

            Assert.Equal(
                "body(\"First\").Children().ElementAt(0)?[\"Value\"].ToObject<string>()",
                CSharpExpressionConverter.ConvertO(() => first.Body[0].Value));
            Assert.Equal(
                "body(\"First\").Count()",
                CSharpExpressionConverter.ConvertO(() => first.Body.Length));
            Assert.Equal(
                "(true ? body(\"First\") : body(\"Second\")).Children().ElementAt(0)?[\"Value\"].ToObject<string>()",
                CSharpExpressionConverter.ConvertO(
                    () => (useFirst ? first.Body : second.Body)[0].Value));
        }

        [Fact]
        public void Convert_TypedDtoDictionary_UsesJsonKeyAccess()
        {
            var action = new TestBodyWorkflowAction<Dictionary<string, NestedPoco>>("Lookup");

            Assert.Equal(
                "body(\"Lookup\")[\"primary\"]?[\"Value\"].ToObject<string>()",
                CSharpExpressionConverter.ConvertO(() => action.Body["primary"].Value));
        }

        [Fact]
        public void Convert_GenericNullableAndNestedTypes_UseValidQualifiedNames()
        {
            var listAction = new TestBodyWorkflowAction<List<NestedPoco>>("GetList");
            var nullableAction = new TestBodyWorkflowAction<int?>("GetNullable");
            var genericAction = new TestBodyWorkflowAction<Envelope<NestedPoco>>("GetEnvelope");
            var nestedAction = new TestBodyWorkflowAction<OuterPoco.NestedPoco>("GetNested");

            Assert.Equal(
                "body(\"GetList\").Count()",
                CSharpExpressionConverter.ConvertO(() => listAction.Body.Count));
            Assert.Equal(
                "body(\"GetNullable\").ToObject<int?>().Value",
                CSharpExpressionConverter.ConvertO(() => nullableAction.Body.Value));
            Assert.Equal(
                "body(\"GetEnvelope\")?[\"Value\"]?[\"Value\"].ToObject<string>()",
                CSharpExpressionConverter.ConvertO(() => genericAction.Body.Value.Value));
            Assert.Equal(
                "body(\"GetNested\")?[\"Value\"].ToObject<string>()",
                CSharpExpressionConverter.ConvertO(() => nestedAction.Body.Value));
        }

        [Fact]
        public void Convert_TypedTriggerBody_PreservesClrType()
        {
            var trigger = new TestBodyWorkflowTrigger<Poco>("Request");

            Assert.Equal(
                "triggerBody()?[\"Name\"].ToObject<string>().ToUpper()",
                CSharpExpressionConverter.ConvertO(() => trigger.TriggerBody.Name.ToUpper()));
        }

        [Fact]
        public void Convert_GeneratedConnectorTypes_UseStructuralJsonAccess()
        {
            var categories = new TestBodyWorkflowAction<GraphOutlookCategory[]>("GetCategories");
            var message = new TestBodyWorkflowAction<OutlookReceiveMessage>("GetMessage");

            Assert.Equal(
                "body(\"GetCategories\").Children().Select(category => category?[\"displayName\"].ToObject<string>()).ToArray<string>()",
                CSharpExpressionConverter.ConvertO(
                    () => categories.Body.Select(category => category.DisplayName).ToArray()));
            Assert.Equal(
                "body(\"GetMessage\")?[\"Importance\"].ToObject<string>() == \"High\"",
                CSharpExpressionConverter.ConvertO(
                    () => message.Body.Importance == OutlookReceiveMessageImportanceType.High));
        }

        [Fact]
        public void Convert_CustomClrIdentityOperations_AreRejected()
        {
            var action = new TestBodyWorkflowAction<Poco>("GetUser");

            Assert.Throws<NotSupportedException>(
                () => CSharpExpressionConverter.ConvertO(() => new Poco { Name = "alice" }));
            Assert.Throws<NotSupportedException>(
                () => CSharpExpressionConverter.ConvertO(() => action.Body is Poco));
            Assert.Throws<NotSupportedException>(
                () => CSharpExpressionConverter.ConvertO(() => action.Body.ToString()));
        }

        [Fact]
        public void Convert_JTokenActionBody_RemainsRawWorkflowData()
        {
            var action = new TestBodyWorkflowAction<JToken>("GetUser");

            Assert.Equal(
                "body(\"GetUser\")[\"Name\"]",
                CSharpExpressionConverter.ConvertO(() => action.Body["Name"]));
        }

        [Fact]
        public void Convert_AgentPrimitiveParameter_AddsTypedConversion()
        {
            var context = new AgentToolContext<Poco>(new Poco());

            Assert.Equal(
                "agentparameters(\"Count\").ToObject<int>() + 1",
                CSharpExpressionConverter.ConvertO(() => context.Parameters.Count + 1));
        }
    }
}
