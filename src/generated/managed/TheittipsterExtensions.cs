//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Theittipster
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TheittipsterActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theittipster")]
        public IBodyWorkflowAction<GenerateBarcodeResponse, ApiConnectionActionConfiguration> GenerateBarcode(Expression<Func<string>> bodybarcodeNumber = null)
        {
            var __workflow_bodybarcodeNumber = WorkflowExpression.Compile(bodybarcodeNumber, nameof(bodybarcodeNumber), required: false);
            return new DeferredBodyAction<GenerateBarcodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/generateBarcode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodybarcodeNumber != null)
                {
                    body["barcodeNumber"] = ExpressionConverter.ConvertO(__workflow_bodybarcodeNumber);
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
        public IBodyWorkflowAction<GenerateQRCodeResponse, ApiConnectionActionConfiguration> GenerateQRCode(Expression<Func<string>> bodyqrcodeText = null)
        {
            var __workflow_bodyqrcodeText = WorkflowExpression.Compile(bodyqrcodeText, nameof(bodyqrcodeText), required: false);
            return new DeferredBodyAction<GenerateQRCodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/generateQRCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyqrcodeText != null)
                {
                    body["qrcodeText"] = ExpressionConverter.ConvertO(__workflow_bodyqrcodeText);
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
