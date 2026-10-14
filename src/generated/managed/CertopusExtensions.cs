//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Certopus
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class CertopusActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certopus")]
        public IBodyWorkflowAction<CreateCredentialResponse> CreateCredential(Expression<Func<string>> bodyorganisationId, Expression<Func<string>> bodyeventId, Expression<Func<string>> bodycategoryId, Expression<Func<bool>> bodygenerate = null, Expression<Func<bool>> bodypublish = null, Expression<Func<bodyrecipientsInputItem[]>> bodyrecipients = null)
        {
            var __workflow_bodyorganisationId = bodyorganisationId == null ? null : WorkflowExpression.Compile(bodyorganisationId);
            WorkflowExpression.Validate(__workflow_bodyorganisationId, nameof(bodyorganisationId), required: true);
            var __workflow_bodyeventId = bodyeventId == null ? null : WorkflowExpression.Compile(bodyeventId);
            WorkflowExpression.Validate(__workflow_bodyeventId, nameof(bodyeventId), required: true);
            var __workflow_bodycategoryId = bodycategoryId == null ? null : WorkflowExpression.Compile(bodycategoryId);
            WorkflowExpression.Validate(__workflow_bodycategoryId, nameof(bodycategoryId), required: true);
            var __workflow_bodygenerate = bodygenerate == null ? null : WorkflowExpression.Compile(bodygenerate);
            WorkflowExpression.Validate(__workflow_bodygenerate, nameof(bodygenerate), required: false);
            var __workflow_bodypublish = bodypublish == null ? null : WorkflowExpression.Compile(bodypublish);
            WorkflowExpression.Validate(__workflow_bodypublish, nameof(bodypublish), required: false);
            var __workflow_bodyrecipients = bodyrecipients == null ? null : WorkflowExpression.Compile(bodyrecipients);
            WorkflowExpression.Validate(__workflow_bodyrecipients, nameof(bodyrecipients), required: false);
            return new DeferredBodyAction<CreateCredentialResponse>(() =>
            {
                var apiCallPath = "/certificates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["organisationId"] = ExpressionConverter.ConvertO(__workflow_bodyorganisationId);
                bodypropCount++;
                body["eventId"] = ExpressionConverter.ConvertO(__workflow_bodyeventId);
                bodypropCount++;
                body["categoryId"] = ExpressionConverter.ConvertO(__workflow_bodycategoryId);
                if (__workflow_bodygenerate != null)
                {
                    body["generate"] = ExpressionConverter.ConvertO(__workflow_bodygenerate);
                    bodypropCount++;
                }

                if (__workflow_bodypublish != null)
                {
                    body["publish"] = ExpressionConverter.ConvertO(__workflow_bodypublish);
                    bodypropCount++;
                }

                if (__workflow_bodyrecipients != null)
                {
                    body["recipients"] = ExpressionConverter.ConvertO(__workflow_bodyrecipients);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateCredentialResponse>(callPayload);
            });
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
