//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gotowebinar
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GotowebinarActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gotowebinar")]
        public IBodyWorkflowAction<Webinar, ApiConnectionActionConfiguration> GetWebinar(Expression<Func<string>> webinarKey)
        {
            var __workflow_webinarKey = WorkflowExpression.Compile(webinarKey, nameof(webinarKey), required: true);
            return new DeferredBodyAction<Webinar, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/organizers/organizerKey/webinars/{0}", __workflow_webinarKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Webinar>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gotowebinar")]
        public IBodyWorkflowAction<RegistrantSummary[], ApiConnectionActionConfiguration> ListRegistrations(Expression<Func<string>> webinarKey)
        {
            var __workflow_webinarKey = WorkflowExpression.Compile(webinarKey, nameof(webinarKey), required: true);
            return new DeferredBodyAction<RegistrantSummary[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/organizers/organizerKey/webinars/{0}/registrants", __workflow_webinarKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RegistrantSummary[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gotowebinar")]
        public IBodyWorkflowAction<RegistrationResult, ApiConnectionActionConfiguration> AddRegistrant(Expression<Func<string>> webinarKey, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null)
        {
            var __workflow_webinarKey = WorkflowExpression.Compile(webinarKey, nameof(webinarKey), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            return new DeferredBodyAction<RegistrationResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/organizers/organizerKey/webinars/{0}/registrants", __workflow_webinarKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstName != null)
                {
                    body["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RegistrationResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gotowebinar")]
        public IBodyWorkflowAction<Registrant, ApiConnectionActionConfiguration> GetRegistrant(Expression<Func<string>> webinarKey, Expression<Func<string>> registrantKey)
        {
            var __workflow_webinarKey = WorkflowExpression.Compile(webinarKey, nameof(webinarKey), required: true);
            var __workflow_registrantKey = WorkflowExpression.Compile(registrantKey, nameof(registrantKey), required: true);
            return new DeferredBodyAction<Registrant, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/organizers/organizerKey/webinars/{0}/registrants/{1}", __workflow_webinarKey.WithUrlEncoding(1), __workflow_registrantKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Registrant>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gotowebinar")]
        public IBodyWorkflowAction<WebinarSummary[], ApiConnectionActionConfiguration> ListWebinars()
        {
            var apiCallPath = "/organizers/organizerKey/webinars";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<WebinarSummary[]>(callPayload);
        }
    }

    public class GotowebinarTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebinarSummary[], ApiConnectionTriggerConfiguration> OnNewWebinar(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/organizers/organizerKey/webinars";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<WebinarSummary[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<RegistrantSummary[], ApiConnectionTriggerConfiguration> OnNewRegistration(Expression<Func<string>> webinarKey, FlowRecurrence recurrence = null)
        {
            var __workflow_webinarKey = WorkflowExpression.Compile(webinarKey, nameof(webinarKey), required: true);
            return new DeferredBodyTrigger<RegistrantSummary[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger/organizers/organizerKey/webinars/{0}/registrants", __workflow_webinarKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<RegistrantSummary[]>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class Webinar
    {
        [JsonProperty("webinarKey")]
        public string WebinarKey { get; set; }

        [JsonProperty("numberOfRegistrationLinkClicks")]
        public int RegistrationClickCount { get; set; }

        [JsonProperty("times")]
        public WebinarTimesTypeItem[] Times { get; set; }

        [JsonProperty("numberOfRegistrants")]
        public int RegistrantCount { get; set; }

        [JsonProperty("webinarID")]
        public string WebinarId { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("inSession")]
        public bool InSession { get; set; }

        [JsonProperty("organizerKey")]
        public int OrganizerKey { get; set; }

        [JsonProperty("registrationUrl")]
        public string RegistrationUrl { get; set; }

        [JsonProperty("numberOfOpenedInvitations")]
        public int NumberOfOpenedInvitations { get; set; }
    }

    public class WebinarTimesTypeItem
    {
        [JsonProperty("startTime")]
        public string StartDateTime { get; set; }

        [JsonProperty("endTime")]
        public string EndDateTime { get; set; }
    }

    public class RegistrantSummary
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDateTime { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("joinUrl")]
        public string JoinUrl { get; set; }

        [JsonProperty("registrantKey")]
        public string RegistrantKey { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class RegistrationResult
    {
        [JsonProperty("registrantKey")]
        public string RegistrantKey { get; set; }

        [JsonProperty("joinUrl")]
        public string JoinUrl { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class Registrant
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("unsubscribed")]
        public bool Unsubscribed { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDateTime { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("responses")]
        public RegistrantResponsesTypeItem[] Responses { get; set; }

        [JsonProperty("joinUrl")]
        public string JoinUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("registrantKey")]
        public string RegistrantKey { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class RegistrantResponsesTypeItem
    {
        [JsonProperty("question")]
        public string RegistrationQuestion { get; set; }

        [JsonProperty("answer")]
        public string RegistrationAnswer { get; set; }
    }

    public class WebinarSummary
    {
        [JsonProperty("webinarKey")]
        public string WebinarKey { get; set; }

        [JsonProperty("times")]
        public WebinarSummaryTimesTypeItem[] Times { get; set; }

        [JsonProperty("numberOfRegistrants")]
        public int RegistrantCount { get; set; }

        [JsonProperty("webinarID")]
        public string WebinarId { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("inSession")]
        public bool InSession { get; set; }

        [JsonProperty("organizerKey")]
        public int OrganizerKey { get; set; }

        [JsonProperty("registrationUrl")]
        public string RegistrationUrl { get; set; }
    }

    public class WebinarSummaryTimesTypeItem
    {
        [JsonProperty("startTime")]
        public string StartDateTime { get; set; }

        [JsonProperty("endTime")]
        public string EndDateTime { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Gotowebinar;

    public partial class WorkflowManagedActions
    {
        public GotowebinarActions Gotowebinar(string connectionId) => new GotowebinarActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GotowebinarTriggers Gotowebinar(string connectionId) => new GotowebinarTriggers(connectionId);
    }
}
