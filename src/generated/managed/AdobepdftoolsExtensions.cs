//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Adobepdftools
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AdobepdftoolsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<CombinePDFResponse, ApiConnectionActionConfiguration> CombinePDF(Expression<Func<CombinePDFInput>> filesArray, Expression<Func<xRegionValueInput>> xRegionValue = null)
        {
            var __workflow_filesArray = WorkflowExpression.Compile(filesArray, nameof(filesArray), required: true);
            var __workflow_xRegionValue = WorkflowExpression.Compile(xRegionValue, nameof(xRegionValue), required: false);
            return new DeferredBodyAction<CombinePDFResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/operation/v1/combinePDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (__workflow_xRegionValue != null)
                    callPayload.Headers["x-region-value"] = ExpressionConverter.Convert(__workflow_xRegionValue);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_filesArray);
                return new ApiConnectionAction<CombinePDFResponse>(callPayload);
            });
        }
    }

    public class AdobepdftoolsTriggers([ConnectionName] string connectionId)
    {
    }

    public class CombinePDFResponse
    {
        [JsonProperty("fileName")]
        public string PDFFileName { get; set; }

        [JsonProperty("fileContent")]
        public string PDFFileContent { get; set; }

        [JsonProperty("fileContentType")]
        public string PDFFileContentType { get; set; }
    }

    public class CombinePDFInput
    {
        [JsonProperty("outputFileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MergedPDFFileName { get; set; }

        [JsonProperty("files", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Files { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum xRegionValueInput
    {
        [EnumMember(Value = "-ue1")]
        USEastNVirginia,
        [EnumMember(Value = "-ew1")]
        EuropeIreland
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Adobepdftools;

    public partial class WorkflowManagedActions
    {
        public AdobepdftoolsActions Adobepdftools(string connectionId) => new AdobepdftoolsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AdobepdftoolsTriggers Adobepdftools(string connectionId) => new AdobepdftoolsTriggers(connectionId);
    }
}