//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gototraining
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GototrainingActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gototraining")]
        public IBodyWorkflowAction<Training> GetTraining([WorkflowExpression] Func<string> trainingid)
        {
            SourceExpression.Validate(trainingid, nameof(trainingid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/G2T/rest/organizers/organizerKey/trainings/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(trainingid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Training>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gototraining")]
        public IBodyWorkflowAction<Registrant[]> ListRegistrations([WorkflowExpression] Func<string> trainingid)
        {
            SourceExpression.Validate(trainingid, nameof(trainingid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/G2T/rest/organizers/organizerKey/trainings/{0}/registrants", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(trainingid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Registrant[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gototraining")]
        public IBodyWorkflowAction<AddRegistrantResponse> AddRegistrant([WorkflowExpression] Func<string> trainingid, [WorkflowExpression] Func<string> bodyregistrantEmail, [WorkflowExpression] Func<string> bodyfirstName, [WorkflowExpression] Func<string> bodylastName)
        {
            SourceExpression.Validate(trainingid, nameof(trainingid), required: true);
            SourceExpression.Validate(bodyregistrantEmail, nameof(bodyregistrantEmail), required: true);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: true);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/G2T/rest/organizers/organizerKey/trainings/{0}/registrants", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(trainingid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyregistrantEmail);
                bodypropCount++;
                body["givenName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                bodypropCount++;
                body["surname"] = SourceExpressionConverter.ConvertToken(bodylastName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddRegistrantResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gototraining")]
        public IBodyWorkflowAction<Registrant> GetRegistrant([WorkflowExpression] Func<string> trainingid, [WorkflowExpression] Func<string> registrantKey)
        {
            SourceExpression.Validate(trainingid, nameof(trainingid), required: true);
            SourceExpression.Validate(registrantKey, nameof(registrantKey), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/G2T/rest/organizers/organizerKey/trainings/{0}/registrants/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(trainingid, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(registrantKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Registrant>(BuildSourceInput);
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