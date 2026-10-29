//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ephesoftsemantikforinvoices
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EphesoftsemantikforinvoicesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ephesoftsemantikforinvoices")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DeleteSemantikWebhook(Expression<Func<string>> configurationId)
        {
            var __workflow_configurationId = WorkflowExpression.Compile(configurationId, nameof(configurationId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/settings/integrations/configurations/{0}", __workflow_configurationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ephesoftsemantikforinvoices")]
        public IBodyWorkflowAction<CreateDocumentUploadResponse, ApiConnectionActionConfiguration> CreateDocumentUpload(Expression<Func<CreateDocumentUploadInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateDocumentUploadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/documents/uploads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateDocumentUploadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ephesoftsemantikforinvoices")]
        public IBodyWorkflowAction<UpdateDocumentUploadResponse, ApiConnectionActionConfiguration> UpdateDocumentUpload(Expression<Func<string>> uploadId, Expression<Func<UpdateDocumentUploadInput>> body)
        {
            var __workflow_uploadId = WorkflowExpression.Compile(uploadId, nameof(uploadId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateDocumentUploadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/documents/uploads/{0}", __workflow_uploadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateDocumentUploadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ephesoftsemantikforinvoices")]
        public IBodyWorkflowAction<UploadCreatedResponse, ApiConnectionActionConfiguration> CreateVendorUpload(Expression<Func<CreateVendorUploadInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UploadCreatedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/vendors/uploads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UploadCreatedResponse>(callPayload);
            });
        }
    }

    public class EphesoftsemantikforinvoicesTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<UploadCreatedResponse, ApiConnectionTriggerConfiguration> TrigSemantikInvoiceCompleted(Expression<Func<TrigSemantikInvoiceCompletedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<UploadCreatedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/settings/integrations/configurations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class CreateDocumentUploadInput
    {
        [JsonProperty("fileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateDocumentUploadInputTypeType Type { get; set; } = CreateDocumentUploadInputTypeType.Invoice;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateDocumentUploadInputTypeType
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

    public class UpdateDocumentUploadInput
    {
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateDocumentUploadInputStatusType Status { get; set; } = UpdateDocumentUploadInputStatusType.Completed;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateDocumentUploadInputStatusType
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

    public class CreateVendorUploadInput
    {
        [JsonProperty("fileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }
    }

    public class TrigSemantikInvoiceCompletedInput
    {
        [JsonProperty("integrationName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string IntegrationName { get; set; } = "Microsoft Power Platform";

        [JsonProperty("integrationType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string IntegrationType { get; set; } = "webhook";

        [JsonProperty("enabled", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Enabled { get; set; } = true;

        [JsonProperty("settings", DefaultValueHandling = DefaultValueHandling.Include)]
        public TrigSemantikInvoiceCompletedInputSettingsType Settings { get; set; }
    }

    public class TrigSemantikInvoiceCompletedInputSettingsType
    {
        [JsonProperty("payload", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Payload { get; set; } = "{\n     \"AmountDue\": \"$AmountDue\",\n     \"DocumentId\": \"$DocumentId\",\n     \"DueDate\": \"$DueDate\",\n     \"Entity\": \"$Entity\",\n     \"FileName\": \"$FileName\",\n     \"IngestionId\": \"$IngestionId\",\n     \"InvoiceDate\": \"$InvoiceDate\",\n     \"InvoiceNumber\": \"$InvoiceNumber\",\n     \"Memo\": \"$Memo\",\n     \"OrderDate\": \"$OrderDate\",\n     \"PdfUrl\": \"$PdfUrl\",\n     \"PONumber\": \"$PONumber\",\n     \"PostingDate\": \"$PostingDate\",\n     \"ReviewedBy\": \"$ReviewedBy\",\n     \"ServiceEndDate\": \"$ServiceEndDate\",\n     \"ServiceStartDate\": \"$ServiceStartDate\",\n     \"ShipDate\": \"$ShipDate\",\n     \"ShipFreight\": \"$ShipFreight\",\n     \"SubTotal\": \"$SubTotal\",\n     \"TableUrl\": \"$TableUrl\",\n     \"TaxAmount\": \"$TaxAmount\",\n     \"TaxRate\": \"$TaxRate\",\n     \"TenantId\": \"$TenantId\",\n     \"Terms\": \"$Terms\",\n     \"TotalAmount\": \"$TotalAmount\",\n     \"Vendor\": {\n          \"VendorAddress\": {\n               \"VendorCountry\": \"$Vendor:Country\",\n               \"VendorLocality\": \"$Vendor:Locality\",\n               \"VendorPOBox\": \"$Vendor:POBox\",\n               \"VendorPostalCode\": \"$Vendor:PostalCode\",\n               \"VendorRegion\": \"$Vendor:Region\",\n               \"VendorStreetAddress\": \"$Vendor:StreetAddress\"\n          },\n          \"VendorApprover\": \"$Vendor:Approver\",\n          \"VendorCustom1\": \"$Vendor:Custom1\",\n          \"VendorCustom2\": \"$Vendor:Custom2\",\n          \"VendorCustom3\": \"$Vendor:Custom3\",\n          \"VendorCustom4\": \"$Vendor:Custom4\",\n          \"VendorCustom5\": \"$Vendor:Custom5\",\n          \"VendorCustomerId\": \"$Vendor:CustomerId\",\n          \"VendorDepartment\": \"$Vendor:Department\",\n          \"VendorGLCode\": \"$Vendor:GLCode\",\n          \"VendorIBAN\": \"$Vendor:IBAN\",\n          \"VendorId\": \"$Vendor:VendorId\",\n          \"VendorMatched\": \"$Vendor:Matched\",\n          \"VendorMemo\": \"$Vendor:Memo\",\n          \"VendorName\": \"$Vendor:Name\",\n          \"VendorStatus\": \"$Vendor:Status\",\n          \"VendorSWIFT\": \"$Vendor:SWIFT\",\n          \"VendorTaxId\": \"$Vendor:TaxId\",\n          \"VendorTelephone\": \"$Vendor:Telephone\"\n     }\n}";

        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("encoding", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Encoding { get; set; } = "application/json";
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