//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Certopus
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CertopusActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certopus")]
        public IBodyWorkflowAction<CreateCredentialResponse, ApiConnectionActionConfiguration> CreateCredential(Expression<Func<CreateCredentialInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateCredentialResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/certificates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class CreateCredentialInput
    {
        [JsonProperty("organisationId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OrganisationId { get; set; }

        [JsonProperty("eventId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EventId { get; set; }

        [JsonProperty("categoryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CategoryId { get; set; }

        [JsonProperty("generate")]
        public bool? Generate { get; set; }

        [JsonProperty("publish")]
        public bool? Publish { get; set; }

        [JsonProperty("recipients")]
        public CreateCredentialInputRecipientsTypeItem[] Recipients { get; set; }
    }

    public class CreateCredentialInputRecipientsTypeItem
    {
        [JsonProperty("data")]
        public CreateCredentialInputRecipientsTypeItemDataType Data { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class CreateCredentialInputRecipientsTypeItemDataType
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