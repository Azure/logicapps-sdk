//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Getmyinvoices
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GetmyinvoicesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "getmyinvoices")]
        [WorkflowExpressionFactory(nameof(__BuildGetInvoiceFromGetMyInvoices))]
        public IBodyWorkflowAction<GetInvoiceFromGetMyInvoicesResponse> GetInvoiceFromGetMyInvoices([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> bodyapiKey)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetInvoiceFromGetMyInvoicesResponse> __BuildGetInvoiceFromGetMyInvoices(WorkflowValue<string> contentType, WorkflowValue<string> accept, WorkflowValue<string> bodyapiKey)
        {
            WorkflowValue.Validate(contentType, nameof(contentType), required: true);
            WorkflowValue.Validate(accept, nameof(accept), required: true);
            WorkflowValue.Validate(bodyapiKey, nameof(bodyapiKey), required: true);
            return new DeferredBodyAction<GetInvoiceFromGetMyInvoicesResponse>(() =>
            {
                var apiCallPath = "/accounts/v2/sendDocumentsToPowerAutomate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["api_key"] = ExpressionConverter.ConvertO(bodyapiKey);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetInvoiceFromGetMyInvoicesResponse>(callPayload);
            });
        }
    }

    public class GetmyinvoicesTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetInvoiceFromGetMyInvoicesResponse
    {
        [JsonProperty("records")]
        public GetInvoiceFromGetMyInvoicesResponseRecordsTypeItem[] Records { get; set; }
    }

    public class GetInvoiceFromGetMyInvoicesResponseRecordsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("company_uid")]
        public int CompanyUid { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("document_type")]
        public string DocumentType { get; set; }

        [JsonProperty("document_number")]
        public string DocumentNumber { get; set; }

        [JsonProperty("creation_date")]
        public string CreationDate { get; set; }

        [JsonProperty("document_date")]
        public string DocumentDate { get; set; }

        [JsonProperty("document_due_date")]
        public string DocumentDueDate { get; set; }

        [JsonProperty("document_payment_method")]
        public string DocumentPaymentMethod { get; set; }

        [JsonProperty("payment_status")]
        public string PaymentStatus { get; set; }

        [JsonProperty("net_amount")]
        public double NetAmount { get; set; }

        [JsonProperty("vat")]
        public int Vat { get; set; }

        [JsonProperty("gross_amount")]
        public double GrossAmount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("is_archived")]
        public bool IsArchived { get; set; }

        [JsonProperty("is_ocr_completed")]
        public bool IsOcrCompleted { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("source_user")]
        public string SourceUser { get; set; }

        [JsonProperty("document_name")]
        public string DocumentName { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        [JsonProperty("file_content")]
        public string FileContent { get; set; }

        [JsonProperty("line_items")]
        public JToken[] LineItems { get; set; }

        [JsonProperty("readable_text")]
        public string ReadableText { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Getmyinvoices;

    public partial class WorkflowManagedActions
    {
        public GetmyinvoicesActions Getmyinvoices(string connectionId) => new GetmyinvoicesActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GetmyinvoicesTriggers Getmyinvoices(string connectionId) => new GetmyinvoicesTriggers(connectionId);
    }
}
