//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Theittipster
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TheittipsterActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theittipster")]
        public IBodyWorkflowAction<GenerateBarcodeResponse> GenerateBarcode(Expression<Func<string>> bodybarcodeNumber = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theittipster")]
        public IBodyWorkflowAction<GenerateQRCodeResponse> GenerateQRCode(Expression<Func<string>> bodyqrcodeText = null)
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
    using Microsoft.Azure.Workflows.Sdk.Theittipster;

    public partial class WorkflowManagedActions
    {
        public TheittipsterActions Theittipster(string connectionId) => new TheittipsterActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TheittipsterTriggers Theittipster(string connectionId) => new TheittipsterTriggers(connectionId);
    }
}