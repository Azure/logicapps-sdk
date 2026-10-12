//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gototraining
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GototrainingActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gototraining")]
        [WorkflowExpressionFactory(nameof(__BuildGetTraining))]
        public IBodyWorkflowAction<Training> GetTraining([WorkflowExpression] Func<string> trainingid)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Training> __BuildGetTraining(WorkflowExpression<string> trainingid)
        {
            WorkflowExpression.Validate(trainingid, nameof(trainingid), required: true);
            return new DeferredBodyAction<Training>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/G2T/rest/organizers/organizerKey/trainings/{0}", ExpressionConverter.ConvertWithUrlEncoding(trainingid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Training>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gototraining")]
        [WorkflowExpressionFactory(nameof(__BuildListRegistrations))]
        public IBodyWorkflowAction<Registrant[]> ListRegistrations([WorkflowExpression] Func<string> trainingid)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Registrant[]> __BuildListRegistrations(WorkflowExpression<string> trainingid)
        {
            WorkflowExpression.Validate(trainingid, nameof(trainingid), required: true);
            return new DeferredBodyAction<Registrant[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/G2T/rest/organizers/organizerKey/trainings/{0}/registrants", ExpressionConverter.ConvertWithUrlEncoding(trainingid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Registrant[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gototraining")]
        [WorkflowExpressionFactory(nameof(__BuildAddRegistrant))]
        public IBodyWorkflowAction<AddRegistrantResponse> AddRegistrant([WorkflowExpression] Func<string> trainingid, [WorkflowExpression] Func<string> bodyregistrantEmail, [WorkflowExpression] Func<string> bodyfirstName, [WorkflowExpression] Func<string> bodylastName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddRegistrantResponse> __BuildAddRegistrant(WorkflowExpression<string> trainingid, WorkflowExpression<string> bodyregistrantEmail, WorkflowExpression<string> bodyfirstName, WorkflowExpression<string> bodylastName)
        {
            WorkflowExpression.Validate(trainingid, nameof(trainingid), required: true);
            WorkflowExpression.Validate(bodyregistrantEmail, nameof(bodyregistrantEmail), required: true);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: true);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: true);
            return new DeferredBodyAction<AddRegistrantResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/G2T/rest/organizers/organizerKey/trainings/{0}/registrants", ExpressionConverter.ConvertWithUrlEncoding(trainingid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyregistrantEmail);
                bodypropCount++;
                body["givenName"] = ExpressionConverter.ConvertO(bodyfirstName);
                bodypropCount++;
                body["surname"] = ExpressionConverter.ConvertO(bodylastName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddRegistrantResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gototraining")]
        [WorkflowExpressionFactory(nameof(__BuildGetRegistrant))]
        public IBodyWorkflowAction<Registrant> GetRegistrant([WorkflowExpression] Func<string> trainingid, [WorkflowExpression] Func<string> registrantKey)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Registrant> __BuildGetRegistrant(WorkflowExpression<string> trainingid, WorkflowExpression<string> registrantKey)
        {
            WorkflowExpression.Validate(trainingid, nameof(trainingid), required: true);
            WorkflowExpression.Validate(registrantKey, nameof(registrantKey), required: true);
            return new DeferredBodyAction<Registrant>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/G2T/rest/organizers/organizerKey/trainings/{0}/registrants/{1}", ExpressionConverter.ConvertWithUrlEncoding(trainingid, 1), ExpressionConverter.ConvertWithUrlEncoding(registrantKey, 1));
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