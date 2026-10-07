//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ephesoftsemantikforinvoices
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EphesoftsemantikforinvoicesActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ephesoftsemantikforinvoices")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteSemantikWebhook))]
        public IBodyWorkflowAction<string> DeleteSemantikWebhook([WorkflowExpression] Func<string> configurationId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ephesoftsemantikforinvoices")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildDeleteSemantikWebhook(WorkflowExpression<string> configurationId)
        {
            WorkflowExpression.Validate(configurationId, nameof(configurationId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/settings/integrations/configurations/{0}", ExpressionConverter.ConvertWithUrlEncoding(configurationId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ephesoftsemantikforinvoices")]
        [WorkflowExpressionFactory(nameof(__BuildCreateDocumentUpload))]
        public IBodyWorkflowAction<CreateDocumentUploadResponse> CreateDocumentUpload([WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<bodytypeInput> bodytype)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ephesoftsemantikforinvoices")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateDocumentUploadResponse> __BuildCreateDocumentUpload(WorkflowExpression<string> bodyfileName, WorkflowExpression<bodytypeInput> bodytype)
        {
            WorkflowExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: true);
            return new DeferredBodyAction<CreateDocumentUploadResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ephesoftsemantikforinvoices")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateDocumentUpload))]
        public IBodyWorkflowAction<UpdateDocumentUploadResponse> UpdateDocumentUpload([WorkflowExpression] Func<string> uploadId, [WorkflowExpression] Func<bodystatusInput> bodystatus)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ephesoftsemantikforinvoices")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateDocumentUploadResponse> __BuildUpdateDocumentUpload(WorkflowExpression<string> uploadId, WorkflowExpression<bodystatusInput> bodystatus)
        {
            WorkflowExpression.Validate(uploadId, nameof(uploadId), required: true);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: true);
            return new DeferredBodyAction<UpdateDocumentUploadResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/documents/uploads/{0}", ExpressionConverter.ConvertWithUrlEncoding(uploadId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ephesoftsemantikforinvoices")]
        [WorkflowExpressionFactory(nameof(__BuildCreateVendorUpload))]
        public IBodyWorkflowAction<UploadCreatedResponse> CreateVendorUpload([WorkflowExpression] Func<string> bodyfileName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ephesoftsemantikforinvoices")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadCreatedResponse> __BuildCreateVendorUpload(WorkflowExpression<string> bodyfileName)
        {
            WorkflowExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            return new DeferredBodyAction<UploadCreatedResponse>(() =>
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
            });
        }
    }

    public class EphesoftsemantikforinvoicesTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildTrigSemantikInvoiceCompleted))]
        public IBodyWorkflowTrigger<UploadCreatedResponse> TrigSemantikInvoiceCompleted([WorkflowExpression] Func<string> bodyintegrationName,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<UploadCreatedResponse> __BuildTrigSemantikInvoiceCompleted(WorkflowExpression<string> bodyintegrationName,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyintegrationName, nameof(bodyintegrationName), required: true);
            return new DeferredBodyTrigger<UploadCreatedResponse>(() =>
            {
                var apiCallPath = "/v1/settings/integrations/configurations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["integrationName"] = ExpressionConverter.ConvertO(bodyintegrationName);
                body["integrationType"] = "webhook";
                bodypropCount++;
                body["enabled"] = true;
                bodypropCount++;
                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                settingsObject["payload"] = "{\n     \"AmountDue\": \"$AmountDue\",\n     \"DocumentId\": \"$DocumentId\",\n     \"DueDate\": \"$DueDate\",\n     \"Entity\": \"$Entity\",\n     \"FileName\": \"$FileName\",\n     \"IngestionId\": \"$IngestionId\",\n     \"InvoiceDate\": \"$InvoiceDate\",\n     \"InvoiceNumber\": \"$InvoiceNumber\",\n     \"Memo\": \"$Memo\",\n     \"OrderDate\": \"$OrderDate\",\n     \"PdfUrl\": \"$PdfUrl\",\n     \"PONumber\": \"$PONumber\",\n     \"PostingDate\": \"$PostingDate\",\n     \"ReviewedBy\": \"$ReviewedBy\",\n     \"ServiceEndDate\": \"$ServiceEndDate\",\n     \"ServiceStartDate\": \"$ServiceStartDate\",\n     \"ShipDate\": \"$ShipDate\",\n     \"ShipFreight\": \"$ShipFreight\",\n     \"SubTotal\": \"$SubTotal\",\n     \"TableUrl\": \"$TableUrl\",\n     \"TaxAmount\": \"$TaxAmount\",\n     \"TaxRate\": \"$TaxRate\",\n     \"TenantId\": \"$TenantId\",\n     \"Terms\": \"$Terms\",\n     \"TotalAmount\": \"$TotalAmount\",\n     \"Vendor\": {\n          \"VendorAddress\": {\n               \"VendorCountry\": \"$Vendor:Country\",\n               \"VendorLocality\": \"$Vendor:Locality\",\n               \"VendorPOBox\": \"$Vendor:POBox\",\n               \"VendorPostalCode\": \"$Vendor:PostalCode\",\n               \"VendorRegion\": \"$Vendor:Region\",\n               \"VendorStreetAddress\": \"$Vendor:StreetAddress\"\n          },\n          \"VendorApprover\": \"$Vendor:Approver\",\n          \"VendorCustom1\": \"$Vendor:Custom1\",\n          \"VendorCustom2\": \"$Vendor:Custom2\",\n          \"VendorCustom3\": \"$Vendor:Custom3\",\n          \"VendorCustom4\": \"$Vendor:Custom4\",\n          \"VendorCustom5\": \"$Vendor:Custom5\",\n          \"VendorCustomerId\": \"$Vendor:CustomerId\",\n          \"VendorDepartment\": \"$Vendor:Department\",\n          \"VendorGLCode\": \"$Vendor:GLCode\",\n          \"VendorIBAN\": \"$Vendor:IBAN\",\n          \"VendorId\": \"$Vendor:VendorId\",\n          \"VendorMatched\": \"$Vendor:Matched\",\n          \"VendorMemo\": \"$Vendor:Memo\",\n          \"VendorName\": \"$Vendor:Name\",\n          \"VendorStatus\": \"$Vendor:Status\",\n          \"VendorSWIFT\": \"$Vendor:SWIFT\",\n          \"VendorTaxId\": \"$Vendor:TaxId\",\n          \"VendorTelephone\": \"$Vendor:Telephone\"\n     }\n}";
                settingsObjectpropCount++;
                settingsObject["targetUrl"] = "#{listCallbackUrl()}";
                settingsObjectpropCount++;
                settingsObject["encoding"] = "application/json";
                settingsObjectpropCount++;
                if (settingsObjectpropCount > 0)
                {
                    body["settings"] = settingsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<UploadCreatedResponse>(callPayload, recurrence: recurrence);
            });
        }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

namespace Microsoft.Azure.Workflows.Sdk
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