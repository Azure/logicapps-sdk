//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Personr
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PersonrActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "personr")]
        [WorkflowExpressionFactory(nameof(__BuildApiApplicantCreate))]
        public IBodyWorkflowAction<ApiApplicantCreateResponse> ApiApplicantCreate([WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodynameFirst = null, [WorkflowExpression] Func<string> bodynameLast = null, [WorkflowExpression] Func<string> bodyflowName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ApiApplicantCreateResponse> __BuildApiApplicantCreate(WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodyphone = null, WorkflowExpression<string> bodynameFirst = null, WorkflowExpression<string> bodynameLast = null, WorkflowExpression<string> bodyflowName = null)
        {
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            WorkflowExpression.Validate(bodynameFirst, nameof(bodynameFirst), required: false);
            WorkflowExpression.Validate(bodynameLast, nameof(bodynameLast), required: false);
            WorkflowExpression.Validate(bodyflowName, nameof(bodyflowName), required: false);
            return new DeferredBodyAction<ApiApplicantCreateResponse>(() =>
            {
                var apiCallPath = "/api-applicant-create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(bodyphone);
                    bodypropCount++;
                }

                if (bodynameFirst != null)
                {
                    body["nameFirst"] = ExpressionConverter.ConvertO(bodynameFirst);
                    bodypropCount++;
                }

                if (bodynameLast != null)
                {
                    body["nameLast"] = ExpressionConverter.ConvertO(bodynameLast);
                    bodypropCount++;
                }

                if (bodyflowName != null)
                {
                    body["flowName"] = ExpressionConverter.ConvertO(bodyflowName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ApiApplicantCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "personr")]
        [WorkflowExpressionFactory(nameof(__BuildApiVerificationlinkCreate))]
        public IBodyWorkflowAction<ApiVerificationlinkCreateResponse> ApiVerificationlinkCreate([WorkflowExpression] Func<string> bodyapplicant = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ApiVerificationlinkCreateResponse> __BuildApiVerificationlinkCreate(WorkflowExpression<string> bodyapplicant = null)
        {
            WorkflowExpression.Validate(bodyapplicant, nameof(bodyapplicant), required: false);
            return new DeferredBodyAction<ApiVerificationlinkCreateResponse>(() =>
            {
                var apiCallPath = "/api-verificationlink-create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyapplicant != null)
                {
                    body["applicant"] = ExpressionConverter.ConvertO(bodyapplicant);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ApiVerificationlinkCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "personr")]
        [WorkflowExpressionFactory(nameof(__BuildApiDocumentUpload))]
        public IWorkflowAction ApiDocumentUpload([WorkflowExpression] Func<string> bodyapplicantId = null, [WorkflowExpression] Func<string> bodydocType = null, [WorkflowExpression] Func<string> bodydocSubType = null, [WorkflowExpression] Func<string> bodydocCountryISO = null, [WorkflowExpression] Func<string> bodydocFilefilename = null, [WorkflowExpression] Func<string> bodydocFilecontents = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildApiDocumentUpload(WorkflowExpression<string> bodyapplicantId = null, WorkflowExpression<string> bodydocType = null, WorkflowExpression<string> bodydocSubType = null, WorkflowExpression<string> bodydocCountryISO = null, WorkflowExpression<string> bodydocFilefilename = null, WorkflowExpression<string> bodydocFilecontents = null)
        {
            WorkflowExpression.Validate(bodyapplicantId, nameof(bodyapplicantId), required: false);
            WorkflowExpression.Validate(bodydocType, nameof(bodydocType), required: false);
            WorkflowExpression.Validate(bodydocSubType, nameof(bodydocSubType), required: false);
            WorkflowExpression.Validate(bodydocCountryISO, nameof(bodydocCountryISO), required: false);
            WorkflowExpression.Validate(bodydocFilefilename, nameof(bodydocFilefilename), required: false);
            WorkflowExpression.Validate(bodydocFilecontents, nameof(bodydocFilecontents), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api-document-upload";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyapplicantId != null)
                {
                    body["applicantId"] = ExpressionConverter.ConvertO(bodyapplicantId);
                    bodypropCount++;
                }

                if (bodydocType != null)
                {
                    body["docType"] = ExpressionConverter.ConvertO(bodydocType);
                    bodypropCount++;
                }

                if (bodydocSubType != null)
                {
                    body["docSubType"] = ExpressionConverter.ConvertO(bodydocSubType);
                    bodypropCount++;
                }

                if (bodydocCountryISO != null)
                {
                    body["docCountryISO"] = ExpressionConverter.ConvertO(bodydocCountryISO);
                    bodypropCount++;
                }

                var docFileObject = new JObject();
                var docFileObjectpropCount = 0;
                if (bodydocFilefilename != null)
                {
                    docFileObject["filename"] = ExpressionConverter.ConvertO(bodydocFilefilename);
                    docFileObjectpropCount++;
                }

                if (bodydocFilecontents != null)
                {
                    docFileObject["contents"] = ExpressionConverter.ConvertO(bodydocFilecontents);
                    docFileObjectpropCount++;
                }

                if (docFileObjectpropCount > 0)
                {
                    body["docFile"] = docFileObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "personr")]
        [WorkflowExpressionFactory(nameof(__BuildApiApplicantStatus))]
        public IBodyWorkflowAction<ApiApplicantStatusResponse> ApiApplicantStatus([WorkflowExpression] Func<string> bodyapplicantId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ApiApplicantStatusResponse> __BuildApiApplicantStatus(WorkflowExpression<string> bodyapplicantId = null)
        {
            WorkflowExpression.Validate(bodyapplicantId, nameof(bodyapplicantId), required: false);
            return new DeferredBodyAction<ApiApplicantStatusResponse>(() =>
            {
                var apiCallPath = "/api-applicant-status";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyapplicantId != null)
                {
                    body["applicantId"] = ExpressionConverter.ConvertO(bodyapplicantId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ApiApplicantStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "personr")]
        [WorkflowExpressionFactory(nameof(__BuildApiApplicantDetails))]
        public IBodyWorkflowAction<ApiApplicantDetailsResponse> ApiApplicantDetails([WorkflowExpression] Func<string> bodyapplicantId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ApiApplicantDetailsResponse> __BuildApiApplicantDetails(WorkflowExpression<string> bodyapplicantId = null)
        {
            WorkflowExpression.Validate(bodyapplicantId, nameof(bodyapplicantId), required: false);
            return new DeferredBodyAction<ApiApplicantDetailsResponse>(() =>
            {
                var apiCallPath = "/api-applicant-details";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyapplicantId != null)
                {
                    body["applicantId"] = ExpressionConverter.ConvertO(bodyapplicantId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ApiApplicantDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "personr")]
        [WorkflowExpressionFactory(nameof(__BuildApiRequestApplicantCheck))]
        public IWorkflowAction ApiRequestApplicantCheck([WorkflowExpression] Func<string> bodyapplicantId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildApiRequestApplicantCheck(WorkflowExpression<string> bodyapplicantId = null)
        {
            WorkflowExpression.Validate(bodyapplicantId, nameof(bodyapplicantId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api-request-applicant-check";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyapplicantId != null)
                {
                    body["applicantId"] = ExpressionConverter.ConvertO(bodyapplicantId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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