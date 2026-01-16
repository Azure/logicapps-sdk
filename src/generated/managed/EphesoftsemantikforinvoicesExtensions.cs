//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ephesoftsemantikforinvoices
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EphesoftsemantikforinvoicesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ephesoftsemantikforinvoices")]
        public IBodyWorkflowAction<string> DeleteSemantikWebhook(Expression<Func<string>> configurationId)
        {
            var apiCallPath = String.Format("/v1/settings/integrations/configurations/{0}", ExpressionConverter.ConvertWithUrlEncoding(configurationId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ephesoftsemantikforinvoices")]
        public IBodyWorkflowAction<CreateDocumentUploadResponse> CreateDocumentUpload(Expression<Func<string>> bodyfileName, Expression<Func<bodytypeInput>> bodytype)
        {
            var apiCallPath = "/v1/documents/uploads";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["fileName"] = ExpressionConverter.ConvertO(bodyfileName);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateDocumentUploadResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ephesoftsemantikforinvoices")]
        public IBodyWorkflowAction<UpdateDocumentUploadResponse> UpdateDocumentUpload(Expression<Func<string>> uploadId, Expression<Func<bodystatusInput>> bodystatus)
        {
            var apiCallPath = String.Format("/v1/documents/uploads/{0}", ExpressionConverter.ConvertWithUrlEncoding(uploadId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["status"] = ExpressionConverter.ConvertO(bodystatus);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateDocumentUploadResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ephesoftsemantikforinvoices")]
        public IBodyWorkflowAction<UploadCreatedResponse> CreateVendorUpload(Expression<Func<string>> bodyfileName)
        {
            var apiCallPath = "/v1/vendors/uploads";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["fileName"] = ExpressionConverter.ConvertO(bodyfileName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UploadCreatedResponse>(callPayload);
        }
    }

    public class EphesoftsemantikforinvoicesTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateDocumentUploadResponse
    {
        [JsonProperty("data")]
        public CreateDocumentUploadResponseDataType Data { get; set; }
    }

    public class CreateDocumentUploadResponseDataType
    {
        [JsonProperty("upload")]
        public CreateDocumentUploadResponseDataTypeUploadType Upload { get; set; }
    }

    public class CreateDocumentUploadResponseDataTypeUploadType
    {
        [JsonProperty("id")]
        public string UploadId { get; set; }

        [JsonProperty("status")]
        public string UploadStatus { get; set; }

        [JsonProperty("url")]
        public string UploadURL { get; set; }
    }

    public enum bodytypeInput
    {
        [EnumMember(Value = "invoice")]
        Invoice
    }

    public class UpdateDocumentUploadResponse
    {
        [JsonProperty("data")]
        public UpdateDocumentUploadResponseDataType Data { get; set; }
    }

    public class UpdateDocumentUploadResponseDataType
    {
        [JsonProperty("upload")]
        public UpdateDocumentUploadResponseDataTypeUploadType Upload { get; set; }
    }

    public class UpdateDocumentUploadResponseDataTypeUploadType
    {
        [JsonProperty("id")]
        public string UploadId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public enum bodystatusInput
    {
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "cancelled")]
        Cancelled
    }

    public class UploadCreatedResponse
    {
        [JsonProperty("data")]
        public UploadCreatedResponseDataType Data { get; set; }
    }

    public class UploadCreatedResponseDataType
    {
        [JsonProperty("upload")]
        public UploadCreatedResponseDataTypeUploadType Upload { get; set; }
    }

    public class UploadCreatedResponseDataTypeUploadType
    {
        [JsonProperty("id")]
        public string UploadId { get; set; }

        [JsonProperty("status")]
        public string UploadStatus { get; set; }

        [JsonProperty("url")]
        public string UploadURL { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ephesoftsemantikforinvoices;

    public partial class WorkflowManagedActions
    {
        public EphesoftsemantikforinvoicesActions Ephesoftsemantikforinvoices(string connectionId) => new EphesoftsemantikforinvoicesActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EphesoftsemantikforinvoicesTriggers Ephesoftsemantikforinvoices(string connectionId) => new EphesoftsemantikforinvoicesTriggers(connectionId);
    }
}