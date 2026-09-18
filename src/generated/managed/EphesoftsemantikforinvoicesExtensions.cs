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
        public IBodyWorkflowAction<string> DeleteSemantikWebhook([WorkflowExpression] Func<string> configurationId)
        {
            SourceExpression.Validate(configurationId, nameof(configurationId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/settings/integrations/configurations/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(configurationId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ephesoftsemantikforinvoices")]
        public IBodyWorkflowAction<CreateDocumentUploadResponse> CreateDocumentUpload([WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<bodytypeInput> bodytype)
        {
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/documents/uploads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["fileName"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateDocumentUploadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ephesoftsemantikforinvoices")]
        public IBodyWorkflowAction<UpdateDocumentUploadResponse> UpdateDocumentUpload([WorkflowExpression] Func<string> uploadId, [WorkflowExpression] Func<bodystatusInput> bodystatus)
        {
            SourceExpression.Validate(uploadId, nameof(uploadId), required: true);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/documents/uploads/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(uploadId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["status"] = SourceExpressionConverter.Convert(bodystatus);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateDocumentUploadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ephesoftsemantikforinvoices")]
        public IBodyWorkflowAction<UploadCreatedResponse> CreateVendorUpload([WorkflowExpression] Func<string> bodyfileName)
        {
            SourceExpression.Validate(bodyfileName, nameof(bodyfileName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/vendors/uploads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["fileName"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UploadCreatedResponse>(BuildSourceInput);
        }
    }

    public class EphesoftsemantikforinvoicesTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<UploadCreatedResponse> TrigSemantikInvoiceCompleted([WorkflowExpression] Func<string> bodyintegrationName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyintegrationName, nameof(bodyintegrationName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/settings/integrations/configurations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["integrationName"] = SourceExpressionConverter.ConvertToken(bodyintegrationName);
                body["integrationType"] = "webhook";
                bodypropCount++;
                body["enabled"] = true;
                bodypropCount++;
                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                settingsObject["payload"] = "{\n     \"AmountDue\": \"$AmountDue\",\n     \"DocumentId\": \"$DocumentId\",\n     \"DueDate\": \"$DueDate\",\n     \"Entity\": \"$Entity\",\n     \"FileName\": \"$FileName\",\n     \"IngestionId\": \"$IngestionId\",\n     \"InvoiceDate\": \"$InvoiceDate\",\n     \"InvoiceNumber\": \"$InvoiceNumber\",\n     \"Memo\": \"$Memo\",\n     \"OrderDate\": \"$OrderDate\",\n     \"PdfUrl\": \"$PdfUrl\",\n     \"PONumber\": \"$PONumber\",\n     \"PostingDate\": \"$PostingDate\",\n     \"ReviewedBy\": \"$ReviewedBy\",\n     \"ServiceEndDate\": \"$ServiceEndDate\",\n     \"ServiceStartDate\": \"$ServiceStartDate\",\n     \"ShipDate\": \"$ShipDate\",\n     \"ShipFreight\": \"$ShipFreight\",\n     \"SubTotal\": \"$SubTotal\",\n     \"TableUrl\": \"$TableUrl\",\n     \"TaxAmount\": \"$TaxAmount\",\n     \"TaxRate\": \"$TaxRate\",\n     \"TenantId\": \"$TenantId\",\n     \"Terms\": \"$Terms\",\n     \"TotalAmount\": \"$TotalAmount\",\n     \"Vendor\": {\n          \"VendorAddress\": {\n               \"VendorCountry\": \"$Vendor:Country\",\n               \"VendorLocality\": \"$Vendor:Locality\",\n               \"VendorPOBox\": \"$Vendor:POBox\",\n               \"VendorPostalCode\": \"$Vendor:PostalCode\",\n               \"VendorRegion\": \"$Vendor:Region\",\n               \"VendorStreetAddress\": \"$Vendor:StreetAddress\"\n          },\n          \"VendorApprover\": \"$Vendor:Approver\",\n          \"VendorCustom1\": \"$Vendor:Custom1\",\n          \"VendorCustom2\": \"$Vendor:Custom2\",\n          \"VendorCustom3\": \"$Vendor:Custom3\",\n          \"VendorCustom4\": \"$Vendor:Custom4\",\n          \"VendorCustom5\": \"$Vendor:Custom5\",\n          \"VendorCustomerId\": \"$Vendor:CustomerId\",\n          \"VendorDepartment\": \"$Vendor:Department\",\n          \"VendorGLCode\": \"$Vendor:GLCode\",\n          \"VendorIBAN\": \"$Vendor:IBAN\",\n          \"VendorId\": \"$Vendor:VendorId\",\n          \"VendorMatched\": \"$Vendor:Matched\",\n          \"VendorMemo\": \"$Vendor:Memo\",\n          \"VendorName\": \"$Vendor:Name\",\n          \"VendorStatus\": \"$Vendor:Status\",\n          \"VendorSWIFT\": \"$Vendor:SWIFT\",\n          \"VendorTaxId\": \"$Vendor:TaxId\",\n          \"VendorTelephone\": \"$Vendor:Telephone\"\n     }\n}";
                settingsObjectpropCount++;
                settingsObject["targetUrl"] = "@listCallbackUrl()";
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
                return callPayload;
            }

            return new ApiConnectionTrigger<UploadCreatedResponse>(BuildSourceInput, triggerName, recurrence);
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