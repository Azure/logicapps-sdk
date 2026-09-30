//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gotowebinar
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GotowebinarActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gotowebinar")]
        public IBodyWorkflowAction<Webinar> GetWebinar([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> webinarKey)
        {
            var apiCallPath = String.Format("/organizers/organizerKey/webinars/{0}", ExpressionConverter.ConvertWithUrlEncoding(webinarKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Webinar>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gotowebinar")]
        public IBodyWorkflowAction<RegistrantSummary[]> ListRegistrations([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> webinarKey)
        {
            var apiCallPath = String.Format("/organizers/organizerKey/webinars/{0}/registrants", ExpressionConverter.ConvertWithUrlEncoding(webinarKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<RegistrantSummary[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gotowebinar")]
        public IBodyWorkflowAction<RegistrationResult> AddRegistrant([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> webinarKey, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null)
        {
            var apiCallPath = String.Format("/organizers/organizerKey/webinars/{0}/registrants", ExpressionConverter.ConvertWithUrlEncoding(webinarKey, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyemail != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodyfirstName != null)
            {
                body["firstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                bodypropCount++;
            }

            if (bodylastName != null)
            {
                body["lastName"] = ExpressionConverter.ConvertO(bodylastName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<RegistrationResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gotowebinar")]
        public IBodyWorkflowAction<Registrant> GetRegistrant([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> webinarKey, [WorkflowExpression] Func<string> registrantKey)
        {
            var apiCallPath = String.Format("/organizers/organizerKey/webinars/{0}/registrants/{1}", ExpressionConverter.ConvertWithUrlEncoding(webinarKey, 1), ExpressionConverter.ConvertWithUrlEncoding(registrantKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Registrant>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gotowebinar")]
        public IBodyWorkflowAction<WebinarSummary[]> ListWebinars()
        {
            var apiCallPath = "/organizers/organizerKey/webinars";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<WebinarSummary[]>(callPayload);
        }
    }

    public class GotowebinarTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebinarSummary[]> OnNewWebinar(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/organizers/organizerKey/webinars";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<WebinarSummary[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<RegistrantSummary[]> OnNewRegistration([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> webinarKey, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/trigger/organizers/organizerKey/webinars/{0}/registrants", ExpressionConverter.ConvertWithUrlEncoding(webinarKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<RegistrantSummary[]>(callPayload, triggerName, recurrence);
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