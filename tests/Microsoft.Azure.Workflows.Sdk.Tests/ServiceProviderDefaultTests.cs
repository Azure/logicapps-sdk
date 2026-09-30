// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.Azure.Workflows.Sdk;
    using Newtonsoft.Json.Linq;
    using Xunit;

    /// <summary>
    /// Tests service provider defaults in generated workflow definitions.
    /// </summary>
    public class ServiceProviderDefaultTests
    {
        /// <summary>
        /// Verifies an omitted optional argument uses its manifest default.
        /// </summary>
        [Fact]
        public void GetActionDefinition_OmittedOptionalArgument_UsesManifestDefault()
        {
            var action = new WorkflowServiceProviderActions()
                .AzureFile("azurefile")
                .GetFileContent(() => "file");

            var definition = action.GetActionDefinition(flowName: null);
            var inputs = Assert.IsType<JObject>(definition.Inputs);

            Assert.True(inputs["parameters"].Value<bool>("inferContentType"));
        }

        /// <summary>
        /// Verifies an explicit CLR-default value overrides the manifest default.
        /// </summary>
        [Fact]
        public void GetActionDefinition_ExplicitFalseArgument_OverridesManifestDefault()
        {
            var action = new WorkflowServiceProviderActions()
                .AzureFile("azurefile")
                .GetFileContent(
                    fileId: () => "file",
                    inferContentType: () => false);

            var definition = action.GetActionDefinition(flowName: null);
            var inputs = Assert.IsType<JObject>(definition.Inputs);

            Assert.False(inputs["parameters"].Value<bool>("inferContentType"));
        }

        [Fact]
        public void GetActionDefinition_CSharpArgument_IsIntercepted()
        {
            var action = WorkflowActions.ServiceProviders.AzureFile("azurefile")
                .GetFileContent(fileId: () => DateTime.UtcNow.Year.ToString());

            var inputs = Assert.IsType<JObject>(action.GetActionDefinition(flowName: null).Inputs);
            Assert.Equal("#{DateTime.UtcNow.Year.ToString()}", inputs["parameters"].Value<string>("fileId"));
            Assert.True(inputs["parameters"].Value<bool>("inferContentType"));
        }

        [Fact]
        public void GetTriggerDefinition_CSharpArgument_IsIntercepted()
        {
            var trigger = WorkflowTriggers.ServiceProviders.Azurequeues("queues")
                .ReceiveQueueMessages(queueName: () => DateTime.UtcNow.Year.ToString());

            var inputs = Assert.IsType<JObject>(trigger.GetTriggerDefinition().Inputs);
            Assert.Equal("#{DateTime.UtcNow.Year.ToString()}", inputs["parameters"].Value<string>("queueName"));
        }
    }
}
