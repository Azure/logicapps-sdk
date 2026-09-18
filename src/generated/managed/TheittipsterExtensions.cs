//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Theittipster
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TheittipsterActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theittipster")]
        public IBodyWorkflowAction<GenerateBarcodeResponse> GenerateBarcode([WorkflowExpression] Func<string> bodybarcodeNumber = null)
        {
            SourceExpression.Validate(bodybarcodeNumber, nameof(bodybarcodeNumber), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/generateBarcode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodybarcodeNumber != null)
                {
                    body["barcodeNumber"] = SourceExpressionConverter.ConvertToken(bodybarcodeNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GenerateBarcodeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theittipster")]
        public IBodyWorkflowAction<GenerateQRCodeResponse> GenerateQRCode([WorkflowExpression] Func<string> bodyqrcodeText = null)
        {
            SourceExpression.Validate(bodyqrcodeText, nameof(bodyqrcodeText), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/generateQRCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyqrcodeText != null)
                {
                    body["qrcodeText"] = SourceExpressionConverter.ConvertToken(bodyqrcodeText);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GenerateQRCodeResponse>(BuildSourceInput);
        }
    }

    public class TheittipsterTriggers([ConnectionName] string connectionId)
    {
    }

    public class GenerateBarcodeResponse
    {
        [JsonProperty("body")]
        public string Body { get; set; }
    }

    public class GenerateQRCodeResponse
    {
        [JsonProperty("body")]
        public string Body { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Theittipster;

    public partial class WorkflowManagedActions
    {
        public TheittipsterActions Theittipster(string connectionId) => new TheittipsterActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TheittipsterTriggers Theittipster(string connectionId) => new TheittipsterTriggers(connectionId);
    }
}