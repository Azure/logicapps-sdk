//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Personr
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PersonrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "personr")]
        public IBodyWorkflowAction<ApiApplicantCreateResponse, ApiConnectionActionConfiguration> ApiApplicantCreate(Expression<Func<ApiApplicantCreateInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ApiApplicantCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-applicant-create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ApiApplicantCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "personr")]
        public IBodyWorkflowAction<ApiVerificationlinkCreateResponse, ApiConnectionActionConfiguration> ApiVerificationlinkCreate(Expression<Func<ApiVerificationlinkCreateInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ApiVerificationlinkCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-verificationlink-create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ApiVerificationlinkCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "personr")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ApiDocumentUpload(Expression<Func<ApiDocumentUploadInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-document-upload";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "personr")]
        public IBodyWorkflowAction<ApiApplicantStatusResponse, ApiConnectionActionConfiguration> ApiApplicantStatus(Expression<Func<ApiApplicantStatusInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ApiApplicantStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-applicant-status";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ApiApplicantStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "personr")]
        public IBodyWorkflowAction<ApiApplicantDetailsResponse, ApiConnectionActionConfiguration> ApiApplicantDetails(Expression<Func<ApiApplicantDetailsInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ApiApplicantDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-applicant-details";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ApiApplicantDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "personr")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ApiRequestApplicantCheck(Expression<Func<ApiRequestApplicantCheckInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api-request-applicant-check";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class PersonrTriggers([ConnectionName] string connectionId)
    {
    }

    public class ApiApplicantCreateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("response")]
        public ApiApplicantCreateResponseResponseType Response { get; set; }
    }

    public class ApiApplicantCreateResponseResponseType
    {
        [JsonProperty("applicantId")]
        public string ApplicantId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("nameFirst")]
        public string NameFirst { get; set; }

        [JsonProperty("nameLast")]
        public string NameLast { get; set; }

        [JsonProperty("flowName")]
        public string FlowName { get; set; }

        [JsonProperty("applicantStatus")]
        public string ApplicantStatus { get; set; }
    }

    public class ApiApplicantCreateInput
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("nameFirst")]
        public string NameFirst { get; set; }

        [JsonProperty("nameLast")]
        public string NameLast { get; set; }

        [JsonProperty("flowName")]
        public string FlowName { get; set; }
    }

    public class ApiVerificationlinkCreateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("response")]
        public ApiVerificationlinkCreateResponseResponseType Response { get; set; }
    }

    public class ApiVerificationlinkCreateResponseResponseType
    {
        [JsonProperty("verificationLink")]
        public string VerificationLink { get; set; }
    }

    public class ApiVerificationlinkCreateInput
    {
        [JsonProperty("applicant")]
        public string Applicant { get; set; }
    }

    public class ApiDocumentUploadInput
    {
        [JsonProperty("applicantId")]
        public string ApplicantId { get; set; }

        [JsonProperty("docType")]
        public string DocType { get; set; }

        [JsonProperty("docSubType")]
        public string DocSubType { get; set; }

        [JsonProperty("docCountryISO")]
        public string DocCountryISO { get; set; }

        [JsonProperty("docFile")]
        public ApiDocumentUploadInputDocFileType DocFile { get; set; }
    }

    public class ApiDocumentUploadInputDocFileType
    {
        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("contents")]
        public string Contents { get; set; }
    }

    public class ApiApplicantStatusResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("response")]
        public ApiApplicantStatusResponseResponseType Response { get; set; }
    }

    public class ApiApplicantStatusResponseResponseType
    {
        [JsonProperty("applicantStatus")]
        public string ApplicantStatus { get; set; }

        [JsonProperty("applicantActionStatus")]
        public string ApplicantActionStatus { get; set; }

        [JsonProperty("result")]
        public ApiApplicantStatusResponseResponseTypeResultType Result { get; set; }

        [JsonProperty("extractedFirstName")]
        public string ExtractedFirstName { get; set; }

        [JsonProperty("extractedLastName")]
        public string ExtractedLastName { get; set; }

        [JsonProperty("extractedBirthDate")]
        public string ExtractedBirthDate { get; set; }

        [JsonProperty("documentCountry")]
        public string DocumentCountry { get; set; }

        [JsonProperty("extractedStreetNum")]
        public string ExtractedStreetNum { get; set; }

        [JsonProperty("extractedStreet")]
        public string ExtractedStreet { get; set; }

        [JsonProperty("extractedCity")]
        public string ExtractedCity { get; set; }

        [JsonProperty("extractedState")]
        public string ExtractedState { get; set; }

        [JsonProperty("extractedPostCode")]
        public string ExtractedPostCode { get; set; }
    }

    public class ApiApplicantStatusResponseResponseTypeResultType
    {
        [JsonProperty("Modified Date")]
        public int ModifiedDate { get; set; }

        [JsonProperty("Created Date")]
        public int CreatedDate { get; set; }

        [JsonProperty("Created By")]
        public string CreatedBy { get; set; }

        [JsonProperty("reviewAnswer")]
        public string ReviewAnswer { get; set; }

        [JsonProperty("applicant")]
        public string Applicant { get; set; }

        [JsonProperty("commentClient")]
        public string CommentClient { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("commentModeration")]
        public string CommentModeration { get; set; }

        [JsonProperty("rejectLabels")]
        public string[] RejectLabels { get; set; }

        [JsonProperty("reviewRejectType")]
        public string ReviewRejectType { get; set; }

        [JsonProperty("verification")]
        public string Verification { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }
    }

    public class ApiApplicantStatusInput
    {
        [JsonProperty("applicantId")]
        public string ApplicantId { get; set; }
    }

    public class ApiApplicantDetailsResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("response")]
        public ApiApplicantDetailsResponseResponseType Response { get; set; }
    }

    public class ApiApplicantDetailsResponseResponseType
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("nameFirst")]
        public string NameFirst { get; set; }

        [JsonProperty("nameLast")]
        public string NameLast { get; set; }

        [JsonProperty("tags")]
        public JToken[] Tags { get; set; }

        [JsonProperty("flowName")]
        public string FlowName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ApiApplicantDetailsInput
    {
        [JsonProperty("applicantId")]
        public string ApplicantId { get; set; }
    }

    public class ApiRequestApplicantCheckInput
    {
        [JsonProperty("applicantId")]
        public string ApplicantId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Personr;

    public partial class WorkflowManagedActions
    {
        public PersonrActions Personr(string connectionId) => new PersonrActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PersonrTriggers Personr(string connectionId) => new PersonrTriggers(connectionId);
    }
}