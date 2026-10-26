//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gototraining
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GototrainingActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gototraining")]
        public IBodyWorkflowAction<Training, ApiConnectionActionConfiguration> GetTraining(Expression<Func<string>> trainingid)
        {
            var __workflow_trainingid = WorkflowExpression.Compile(trainingid, nameof(trainingid), required: true);
            return new DeferredBodyAction<Training, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/G2T/rest/organizers/organizerKey/trainings/{0}", __workflow_trainingid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Training>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gototraining")]
        public IBodyWorkflowAction<Registrant[], ApiConnectionActionConfiguration> ListRegistrations(Expression<Func<string>> trainingid)
        {
            var __workflow_trainingid = WorkflowExpression.Compile(trainingid, nameof(trainingid), required: true);
            return new DeferredBodyAction<Registrant[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/G2T/rest/organizers/organizerKey/trainings/{0}/registrants", __workflow_trainingid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Registrant[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gototraining")]
        public IBodyWorkflowAction<AddRegistrantResponse, ApiConnectionActionConfiguration> AddRegistrant(Expression<Func<string>> trainingid, Expression<Func<AddRegistrantInput>> body)
        {
            var __workflow_trainingid = WorkflowExpression.Compile(trainingid, nameof(trainingid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddRegistrantResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/G2T/rest/organizers/organizerKey/trainings/{0}/registrants", __workflow_trainingid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddRegistrantResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gototraining")]
        public IBodyWorkflowAction<Registrant, ApiConnectionActionConfiguration> GetRegistrant(Expression<Func<string>> trainingid, Expression<Func<string>> registrantKey)
        {
            var __workflow_trainingid = WorkflowExpression.Compile(trainingid, nameof(trainingid), required: true);
            var __workflow_registrantKey = WorkflowExpression.Compile(registrantKey, nameof(registrantKey), required: true);
            return new DeferredBodyAction<Registrant, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/G2T/rest/organizers/organizerKey/trainings/{0}/registrants/{1}", __workflow_trainingid.WithUrlEncoding(1), __workflow_registrantKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Registrant>(callPayload);
            });
        }
    }

    public class GototrainingTriggers([ConnectionName] string connectionId)
    {
    }

    public class Training
    {
        [JsonProperty("trainingId")]
        public string TrainingId { get; set; }

        [JsonProperty("name")]
        public string Title { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("times")]
        public TrainingTimesTypeItem[] Times { get; set; }

        [JsonProperty("organizers")]
        public TrainingOrganizersTypeItem[] Organizers { get; set; }

        [JsonProperty("registrationSettings")]
        public TrainingRegistrationSettingsType RegistrationSettings { get; set; }

        [JsonProperty("trainingKey")]
        public string TrainingKey { get; set; }
    }

    public class TrainingTimesTypeItem
    {
        [JsonProperty("startDate")]
        public string StartDateTime { get; set; }

        [JsonProperty("endDate")]
        public string EndDateTime { get; set; }
    }

    public class TrainingOrganizersTypeItem
    {
        [JsonProperty("givenName")]
        public string FirstName { get; set; }

        [JsonProperty("surname")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("organizerKey")]
        public string OrganizerKey { get; set; }
    }

    public class TrainingRegistrationSettingsType
    {
        [JsonProperty("disableConfirmationEmail")]
        public bool DisableConfirmationEmail { get; set; }

        [JsonProperty("disableWebRegistration")]
        public bool DisableWebRegistration { get; set; }
    }

    public class Registrant
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("givenName")]
        public string FirstName { get; set; }

        [JsonProperty("surname")]
        public string LastName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDateTime { get; set; }

        [JsonProperty("joinUrl")]
        public string JoinUrl { get; set; }

        [JsonProperty("confirmationUrl")]
        public string ConfirmationUrl { get; set; }

        [JsonProperty("registrantKey")]
        public string RegistrantKey { get; set; }
    }

    public class AddRegistrantResponse
    {
        [JsonProperty("joinUrl")]
        public string JoinUrl { get; set; }

        [JsonProperty("confirmationUrl")]
        public string ConfirmationUrl { get; set; }

        [JsonProperty("registrantKey")]
        public string RegistrantKey { get; set; }
    }

    public class AddRegistrantInput
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RegistrantEmail { get; set; }

        [JsonProperty("givenName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FirstName { get; set; }

        [JsonProperty("surname", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Gototraining;

    public partial class WorkflowManagedActions
    {
        public GototrainingActions Gototraining(string connectionId) => new GototrainingActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GototrainingTriggers Gototraining(string connectionId) => new GototrainingTriggers(connectionId);
    }
}