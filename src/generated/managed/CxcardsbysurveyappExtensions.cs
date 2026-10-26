//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cxcardsbysurveyapp
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CxcardsbysurveyappActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cxcardsbysurveyapp")]
        public IBodyWorkflowAction<SendSurveyResponse, ApiConnectionActionConfiguration> SendSurvey(Expression<Func<SendSurveyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendSurveyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/email-surveys/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendSurveyResponse>(callPayload);
            });
        }
    }

    public class CxcardsbysurveyappTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendSurveyResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class SendSurveyInput
    {
        [JsonProperty("api_key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ApiKey { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("ref")]
        public string Ref { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("record_type")]
        public string RecordType { get; set; }

        [JsonProperty("record_id")]
        public string RecordId { get; set; }

        [JsonProperty("version_number")]
        public string VersionNumber { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cxcardsbysurveyapp;

    public partial class WorkflowManagedActions
    {
        public CxcardsbysurveyappActions Cxcardsbysurveyapp(string connectionId) => new CxcardsbysurveyappActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CxcardsbysurveyappTriggers Cxcardsbysurveyapp(string connectionId) => new CxcardsbysurveyappTriggers(connectionId);
    }
}