//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Adobepdftools
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AdobepdftoolsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adobepdftools")]
        public IBodyWorkflowAction<CombinePDFResponse> CombinePDF([WorkflowExpression] Func<string> filesArraymergedPDFFileName, [WorkflowExpression] Func<string[]> filesArrayfiles, [WorkflowExpression] Func<xRegionValueInput> xRegionValue = null)
        {
            SourceExpression.Validate(filesArraymergedPDFFileName, nameof(filesArraymergedPDFFileName), required: true);
            SourceExpression.Validate(filesArrayfiles, nameof(filesArrayfiles), required: true);
            SourceExpression.Validate(xRegionValue, nameof(xRegionValue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/operation/v1/combinePDF";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("PowerAutomate");
                callPayload.Headers["x-region-value"] = Convert.ToString("-ue1");
                if (xRegionValue != null)
                    callPayload.Headers["x-region-value"] = SourceExpressionConverter.Convert(xRegionValue);
                var filesArray = new JObject();
                var filesArraypropCount = 0;
                filesArraypropCount++;
                filesArray["outputFileName"] = SourceExpressionConverter.ConvertToken(filesArraymergedPDFFileName);
                filesArraypropCount++;
                filesArray["files"] = SourceExpressionConverter.ConvertToken(filesArrayfiles);
                if (filesArraypropCount > 0)
                {
                    callPayload.Body = filesArray;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CombinePDFResponse>(BuildSourceInput);
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