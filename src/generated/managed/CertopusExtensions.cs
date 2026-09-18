//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Certopus
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CertopusActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certopus")]
        public IBodyWorkflowAction<CreateCredentialResponse> CreateCredential([WorkflowExpression] Func<string> bodyorganisationId, [WorkflowExpression] Func<string> bodyeventId, [WorkflowExpression] Func<string> bodycategoryId, [WorkflowExpression] Func<bool> bodygenerate = null, [WorkflowExpression] Func<bool> bodypublish = null, [WorkflowExpression] Func<bodyrecipientsInputItem[]> bodyrecipients = null)
        {
            SourceExpression.Validate(bodyorganisationId, nameof(bodyorganisationId), required: true);
            SourceExpression.Validate(bodyeventId, nameof(bodyeventId), required: true);
            SourceExpression.Validate(bodycategoryId, nameof(bodycategoryId), required: true);
            SourceExpression.Validate(bodygenerate, nameof(bodygenerate), required: false);
            SourceExpression.Validate(bodypublish, nameof(bodypublish), required: false);
            SourceExpression.Validate(bodyrecipients, nameof(bodyrecipients), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/certificates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["organisationId"] = SourceExpressionConverter.ConvertToken(bodyorganisationId);
                bodypropCount++;
                body["eventId"] = SourceExpressionConverter.ConvertToken(bodyeventId);
                bodypropCount++;
                body["categoryId"] = SourceExpressionConverter.ConvertToken(bodycategoryId);
                if (bodygenerate != null)
                {
                    body["generate"] = SourceExpressionConverter.ConvertToken(bodygenerate);
                    bodypropCount++;
                }

                if (bodypublish != null)
                {
                    body["publish"] = SourceExpressionConverter.ConvertToken(bodypublish);
                    bodypropCount++;
                }

                if (bodyrecipients != null)
                {
                    body["recipients"] = SourceExpressionConverter.ConvertToken(bodyrecipients);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateCredentialResponse>(BuildSourceInput);
        }
    }

    public class CertopusTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateCredentialResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("responses")]
        public CreateCredentialResponseResponsesTypeItem[] Responses { get; set; }
    }

    public class CreateCredentialResponseResponsesTypeItem
    {
        [JsonProperty("certificateId")]
        public string CertificateId { get; set; }

        [JsonProperty("recipient")]
        public CreateCredentialResponseResponsesTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("category")]
        public CreateCredentialResponseResponsesTypeItemCategoryType Category { get; set; }

        [JsonProperty("eventName")]
        public string EventName { get; set; }

        [JsonProperty("pdfUrl")]
        public string PdfUrl { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("certificateUrl")]
        public string CertificateUrl { get; set; }

        [JsonProperty("issueDate")]
        public string IssueDate { get; set; }

        [JsonProperty("expiryDate")]
        public string ExpiryDate { get; set; }

        [JsonProperty("walletId")]
        public string WalletId { get; set; }
    }

    public class CreateCredentialResponseResponsesTypeItemRecipientType
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("data")]
        public CreateCredentialResponseResponsesTypeItemRecipientTypeDataType Data { get; set; }
    }

    public class CreateCredentialResponseResponsesTypeItemRecipientTypeDataType
    {
        [JsonProperty("{Name}")]
        public string Name { get; set; }
    }

    public class CreateCredentialResponseResponsesTypeItemCategoryType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class bodyrecipientsInputItem
    {
        [JsonProperty("data")]
        public bodyrecipientsInputItemDataType Data { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class bodyrecipientsInputItemDataType
    {
        [JsonProperty("{Name}")]
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Certopus;

    public partial class WorkflowManagedActions
    {
        public CertopusActions Certopus(string connectionId) => new CertopusActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CertopusTriggers Certopus(string connectionId) => new CertopusTriggers(connectionId);
    }
}