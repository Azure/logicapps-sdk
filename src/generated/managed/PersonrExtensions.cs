//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Personr
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PersonrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "personr")]
        public IBodyWorkflowAction<ApiApplicantCreateResponse> ApiApplicantCreate([WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodynameFirst = null, [WorkflowExpression] Func<string> bodynameLast = null, [WorkflowExpression] Func<string> bodyflowName = null)
        {
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            SourceExpression.Validate(bodynameFirst, nameof(bodynameFirst), required: false);
            SourceExpression.Validate(bodynameLast, nameof(bodynameLast), required: false);
            SourceExpression.Validate(bodyflowName, nameof(bodyflowName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-applicant-create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                    bodypropCount++;
                }

                if (bodynameFirst != null)
                {
                    body["nameFirst"] = SourceExpressionConverter.ConvertToken(bodynameFirst);
                    bodypropCount++;
                }

                if (bodynameLast != null)
                {
                    body["nameLast"] = SourceExpressionConverter.ConvertToken(bodynameLast);
                    bodypropCount++;
                }

                if (bodyflowName != null)
                {
                    body["flowName"] = SourceExpressionConverter.ConvertToken(bodyflowName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ApiApplicantCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "personr")]
        public IBodyWorkflowAction<ApiVerificationlinkCreateResponse> ApiVerificationlinkCreate([WorkflowExpression] Func<string> bodyapplicant = null)
        {
            SourceExpression.Validate(bodyapplicant, nameof(bodyapplicant), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-verificationlink-create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyapplicant != null)
                {
                    body["applicant"] = SourceExpressionConverter.ConvertToken(bodyapplicant);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ApiVerificationlinkCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "personr")]
        public IWorkflowAction ApiDocumentUpload([WorkflowExpression] Func<string> bodyapplicantId = null, [WorkflowExpression] Func<string> bodydocType = null, [WorkflowExpression] Func<string> bodydocSubType = null, [WorkflowExpression] Func<string> bodydocCountryISO = null, [WorkflowExpression] Func<string> bodydocFilefilename = null, [WorkflowExpression] Func<string> bodydocFilecontents = null)
        {
            SourceExpression.Validate(bodyapplicantId, nameof(bodyapplicantId), required: false);
            SourceExpression.Validate(bodydocType, nameof(bodydocType), required: false);
            SourceExpression.Validate(bodydocSubType, nameof(bodydocSubType), required: false);
            SourceExpression.Validate(bodydocCountryISO, nameof(bodydocCountryISO), required: false);
            SourceExpression.Validate(bodydocFilefilename, nameof(bodydocFilefilename), required: false);
            SourceExpression.Validate(bodydocFilecontents, nameof(bodydocFilecontents), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-document-upload";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyapplicantId != null)
                {
                    body["applicantId"] = SourceExpressionConverter.ConvertToken(bodyapplicantId);
                    bodypropCount++;
                }

                if (bodydocType != null)
                {
                    body["docType"] = SourceExpressionConverter.ConvertToken(bodydocType);
                    bodypropCount++;
                }

                if (bodydocSubType != null)
                {
                    body["docSubType"] = SourceExpressionConverter.ConvertToken(bodydocSubType);
                    bodypropCount++;
                }

                if (bodydocCountryISO != null)
                {
                    body["docCountryISO"] = SourceExpressionConverter.ConvertToken(bodydocCountryISO);
                    bodypropCount++;
                }

                var docFileObject = new JObject();
                var docFileObjectpropCount = 0;
                if (bodydocFilefilename != null)
                {
                    docFileObject["filename"] = SourceExpressionConverter.ConvertToken(bodydocFilefilename);
                    docFileObjectpropCount++;
                }

                if (bodydocFilecontents != null)
                {
                    docFileObject["contents"] = SourceExpressionConverter.ConvertToken(bodydocFilecontents);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "personr")]
        public IBodyWorkflowAction<ApiApplicantStatusResponse> ApiApplicantStatus([WorkflowExpression] Func<string> bodyapplicantId = null)
        {
            SourceExpression.Validate(bodyapplicantId, nameof(bodyapplicantId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-applicant-status";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyapplicantId != null)
                {
                    body["applicantId"] = SourceExpressionConverter.ConvertToken(bodyapplicantId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ApiApplicantStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "personr")]
        public IBodyWorkflowAction<ApiApplicantDetailsResponse> ApiApplicantDetails([WorkflowExpression] Func<string> bodyapplicantId = null)
        {
            SourceExpression.Validate(bodyapplicantId, nameof(bodyapplicantId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-applicant-details";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyapplicantId != null)
                {
                    body["applicantId"] = SourceExpressionConverter.ConvertToken(bodyapplicantId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ApiApplicantDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "personr")]
        public IWorkflowAction ApiRequestApplicantCheck([WorkflowExpression] Func<string> bodyapplicantId = null)
        {
            SourceExpression.Validate(bodyapplicantId, nameof(bodyapplicantId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-request-applicant-check";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyapplicantId != null)
                {
                    body["applicantId"] = SourceExpressionConverter.ConvertToken(bodyapplicantId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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