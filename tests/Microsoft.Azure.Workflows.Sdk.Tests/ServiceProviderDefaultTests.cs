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

        /// <summary>
        /// Verifies JSON pass-through and typed operations both use native C#.
        /// </summary>
        [Fact]
        public void GetActionDefinition_ExpressionsUseNativeConversion()
        {
            var source = WorkflowActions.BuiltIn.Compose<string>(() => "unused").WithName("Source");
            var action = new WorkflowServiceProviderActions()
                .AzureBlob("azureblob")
                .BlobExists(
                    containerName: () => source.Output,
                    blobName: () => source.Output.ToUpperInvariant());

            var definition = action.GetActionDefinition(flowName: null);
            var inputs = Assert.IsType<JObject>(definition.Inputs);

            Assert.Equal("#{outputs(\"Source\")}", inputs["parameters"].Value<string>("containerName"));
            Assert.Equal(
                "#{outputs(\"Source\").ToObject<string>().ToUpperInvariant()}",
                inputs["parameters"].Value<string>("blobName"));
        }
    }
}
