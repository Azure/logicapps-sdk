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
        public IBodyWorkflowAction<GenerateBarcodeResponse, ApiConnectionActionConfiguration> GenerateBarcode(Expression<Func<GenerateBarcodeInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GenerateBarcodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/generateBarcode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GenerateBarcodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theittipster")]
        public IBodyWorkflowAction<GenerateQRCodeResponse, ApiConnectionActionConfiguration> GenerateQRCode(Expression<Func<GenerateQRCodeInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GenerateQRCodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/generateQRCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class GenerateBarcodeInput
    {
        [JsonProperty("barcodeNumber")]
        public string BarcodeNumber { get; set; }
    }

    public class GenerateQRCodeResponse
    {
        [JsonProperty("body")]
        public string Body { get; set; }
    }

    public class GenerateQRCodeInput
    {
        [JsonProperty("qrcodeText")]
        public string QrcodeText { get; set; }
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