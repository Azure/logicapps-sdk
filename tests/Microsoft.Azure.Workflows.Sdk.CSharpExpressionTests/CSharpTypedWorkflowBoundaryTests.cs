// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.Azure.Workflows.Sdk;
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
        public void Convert_TypedPocoBody_UsesClrMemberAccess()
        {
            var action = new TestBodyWorkflowAction<Poco>("GetUser");

            Assert.Equal(
                "body(\"GetUser\").ToObject<global::Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.Poco>().Name.ToUpper()",
                CSharpExpressionConverter.ConvertO(() => action.Body.Name.ToUpper()));
            Assert.Equal(
                "body(\"GetUser\").ToObject<global::Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.Poco>().Tag",
                CSharpExpressionConverter.ConvertO(() => action.Body.Tag));
        }

        [Fact]
        public void Convert_TypedNumericProperty_UsesNativeArithmetic()
        {
            var action = new TestBodyWorkflowAction<Poco>("GetUser");

            Assert.Equal(
                "body(\"GetUser\").ToObject<global::Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.Poco>().Count + 1",
                CSharpExpressionConverter.ConvertO(() => action.Body.Count + 1));
        }

        [Fact]
        public void Convert_TypedNestedProperty_UsesDotNotation()
        {
            var action = new TestBodyWorkflowAction<Poco>("GetUser");

            Assert.Equal(
                "body(\"GetUser\").ToObject<global::Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.Poco>().Nested.Value.ToUpper()",
                CSharpExpressionConverter.ConvertO(() => action.Body.Nested.Value.ToUpper()));
        }

        [Fact]
        public void Convert_TypedListAndArray_SupportLinq()
        {
            var listAction = new TestBodyWorkflowAction<Poco>("GetUsers");
            var arrayAction = new TestBodyWorkflowAction<NestedPoco[]>("GetArray");

            Assert.Equal(
                "body(\"GetUsers\").ToObject<global::Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.Poco>().Items.Select<global::Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.NestedPoco, string>(item => item.Value).ToList<string>()",
                CSharpExpressionConverter.ConvertO(() => listAction.Body.Items.Select(item => item.Value).ToList()));
            Assert.Equal(
                "body(\"GetArray\").ToObject<global::Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.NestedPoco[]>().Select<global::Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.NestedPoco, string>(item => item.Value).ToArray<string>()",
                CSharpExpressionConverter.ConvertO(() => arrayAction.Body.Select(item => item.Value).ToArray()));
        }

        [Fact]
        public void Convert_GenericNullableAndNestedTypes_UseValidQualifiedNames()
        {
            var listAction = new TestBodyWorkflowAction<List<NestedPoco>>("GetList");
            var nullableAction = new TestBodyWorkflowAction<int?>("GetNullable");
            var genericAction = new TestBodyWorkflowAction<Envelope<NestedPoco>>("GetEnvelope");
            var nestedAction = new TestBodyWorkflowAction<OuterPoco.NestedPoco>("GetNested");

            Assert.Equal(
                "body(\"GetList\").ToObject<List<global::Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.NestedPoco>>().Count",
                CSharpExpressionConverter.ConvertO(() => listAction.Body.Count));
            Assert.Equal(
                "body(\"GetNullable\").ToObject<int?>().Value",
                CSharpExpressionConverter.ConvertO(() => nullableAction.Body.Value));
            Assert.Equal(
                "body(\"GetEnvelope\").ToObject<global::Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.Envelope<global::Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.NestedPoco>>().Value.Value",
                CSharpExpressionConverter.ConvertO(() => genericAction.Body.Value.Value));
            Assert.Equal(
                "body(\"GetNested\").ToObject<global::Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.OuterPoco.NestedPoco>().Value",
                CSharpExpressionConverter.ConvertO(() => nestedAction.Body.Value));
        }

        [Fact]
        public void Convert_TypedTriggerBody_PreservesClrType()
        {
            var trigger = new TestBodyWorkflowTrigger<Poco>("Request");

            Assert.Equal(
                "triggerBody().ToObject<global::Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests.Poco>().Name.ToUpper()",
                CSharpExpressionConverter.ConvertO(() => trigger.TriggerBody.Name.ToUpper()));
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
