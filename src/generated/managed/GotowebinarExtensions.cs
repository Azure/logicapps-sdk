//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gotowebinar
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GotowebinarActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gotowebinar")]
        public IBodyWorkflowAction<Webinar> GetWebinar([WorkflowExpression] Func<string> webinarKey)
        {
            SourceExpression.Validate(webinarKey, nameof(webinarKey), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/organizers/organizerKey/webinars/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(webinarKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Webinar>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gotowebinar")]
        public IBodyWorkflowAction<RegistrantSummary[]> ListRegistrations([WorkflowExpression] Func<string> webinarKey)
        {
            SourceExpression.Validate(webinarKey, nameof(webinarKey), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/organizers/organizerKey/webinars/{0}/registrants", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(webinarKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<RegistrantSummary[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gotowebinar")]
        public IBodyWorkflowAction<RegistrationResult> AddRegistrant([WorkflowExpression] Func<string> webinarKey, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null)
        {
            SourceExpression.Validate(webinarKey, nameof(webinarKey), required: true);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/organizers/organizerKey/webinars/{0}/registrants", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(webinarKey, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["firstName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["lastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RegistrationResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gotowebinar")]
        public IBodyWorkflowAction<Registrant> GetRegistrant([WorkflowExpression] Func<string> webinarKey, [WorkflowExpression] Func<string> registrantKey)
        {
            SourceExpression.Validate(webinarKey, nameof(webinarKey), required: true);
            SourceExpression.Validate(registrantKey, nameof(registrantKey), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/organizers/organizerKey/webinars/{0}/registrants/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(webinarKey, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(registrantKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Registrant>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gotowebinar")]
        public IBodyWorkflowAction<WebinarSummary[]> ListWebinars()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/organizers/organizerKey/webinars";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<WebinarSummary[]>(BuildSourceInput);
        }
    }

    public class GotowebinarTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebinarSummary[]> OnNewWebinar(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/organizers/organizerKey/webinars";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<WebinarSummary[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<RegistrantSummary[]> OnNewRegistration([WorkflowExpression] Func<string> webinarKey, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(webinarKey, nameof(webinarKey), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger/organizers/organizerKey/webinars/{0}/registrants", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(webinarKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<RegistrantSummary[]>(BuildSourceInput, triggerName, recurrence);
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