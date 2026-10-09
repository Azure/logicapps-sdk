//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Theittipster
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TheittipsterActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theittipster")]
        [WorkflowExpressionFactory(nameof(__BuildGenerateBarcode))]
        public IBodyWorkflowAction<GenerateBarcodeResponse> GenerateBarcode([WorkflowExpression] Func<string> bodybarcodeNumber = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GenerateBarcodeResponse> __BuildGenerateBarcode(WorkflowExpression<string> bodybarcodeNumber = null)
        {
            WorkflowExpression.Validate(bodybarcodeNumber, nameof(bodybarcodeNumber), required: false);
            return new DeferredBodyAction<GenerateBarcodeResponse>(() =>
            {
                var apiCallPath = "/api/generateBarcode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodybarcodeNumber != null)
                {
                    body["barcodeNumber"] = ExpressionConverter.ConvertO(bodybarcodeNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GenerateBarcodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theittipster")]
        [WorkflowExpressionFactory(nameof(__BuildGenerateQRCode))]
        public IBodyWorkflowAction<GenerateQRCodeResponse> GenerateQRCode([WorkflowExpression] Func<string> bodyqrcodeText = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GenerateQRCodeResponse> __BuildGenerateQRCode(WorkflowExpression<string> bodyqrcodeText = null)
        {
            WorkflowExpression.Validate(bodyqrcodeText, nameof(bodyqrcodeText), required: false);
            return new DeferredBodyAction<GenerateQRCodeResponse>(() =>
            {
                var apiCallPath = "/api/generateQRCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyqrcodeText != null)
                {
                    body["qrcodeText"] = ExpressionConverter.ConvertO(bodyqrcodeText);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GenerateQRCodeResponse>(callPayload);
            });
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