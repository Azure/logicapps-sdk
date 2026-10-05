//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Springglobal
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SpringglobalActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "springglobal")]
        [WorkflowExpressionFactory(nameof(__BuildGetExecutionById))]
        public IBodyWorkflowAction<JToken> GetExecutionById([WorkflowExpression] Func<string> executionId, [WorkflowExpression] Func<string> surveyId, [WorkflowExpression] Func<string> publicationId, [WorkflowExpression] Func<bool> advancedInfo = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetExecutionById(WorkflowValue<string> executionId, WorkflowValue<string> surveyId, WorkflowValue<string> publicationId, WorkflowValue<bool> advancedInfo = null)
        {
            WorkflowValue.Validate(executionId, nameof(executionId), required: true);
            WorkflowValue.Validate(surveyId, nameof(surveyId), required: true);
            WorkflowValue.Validate(publicationId, nameof(publicationId), required: true);
            WorkflowValue.Validate(advancedInfo, nameof(advancedInfo), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/survey-service/execution/{0}", ExpressionConverter.ConvertWithUrlEncoding(executionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["advancedInfo"] = Convert.ToString(false);
                if (advancedInfo != null)
                    callPayload.Headers["advancedInfo"] = ExpressionConverter.Convert(advancedInfo);
                callPayload.Headers["surveyId"] = ExpressionConverter.Convert(surveyId);
                callPayload.Headers["publicationId"] = ExpressionConverter.Convert(publicationId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "springglobal")]
        [WorkflowExpressionFactory(nameof(__BuildGetUserById))]
        public IBodyWorkflowAction<GetUserByIdResponse> GetUserById([WorkflowExpression] Func<string> userId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetUserByIdResponse> __BuildGetUserById(WorkflowValue<string> userId)
        {
            WorkflowValue.Validate(userId, nameof(userId), required: true);
            return new DeferredBodyAction<GetUserByIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/identity-service/user/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUserByIdResponse>(callPayload);
            });
        }
    }

    public class SpringglobalTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildOnSurveyExecution))]
        public IWorkflowTrigger OnSurveyExecution([WorkflowExpression] Func<string> bodyparameterssurveyId = null, [WorkflowExpression] Func<string> bodyparameterspublicationId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildOnSurveyExecution(WorkflowValue<string> bodyparameterssurveyId = null, WorkflowValue<string> bodyparameterspublicationId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyparameterssurveyId, nameof(bodyparameterssurveyId), required: false);
            WorkflowValue.Validate(bodyparameterspublicationId, nameof(bodyparameterspublicationId), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/webhook-service/subscribe/surveyexecution";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callback"] = "#{listCallbackUrl()}";
                bodypropCount++;
                var parametersObject = new JObject();
                var parametersObjectpropCount = 0;
                if (bodyparameterssurveyId != null)
                {
                    parametersObject["surveyId"] = ExpressionConverter.ConvertO(bodyparameterssurveyId);
                    parametersObjectpropCount++;
                }

                if (bodyparameterspublicationId != null)
                {
                    parametersObject["publicationId"] = ExpressionConverter.ConvertO(bodyparameterspublicationId);
                    parametersObjectpropCount++;
                }

                if (parametersObjectpropCount > 0)
                {
                    body["parameters"] = parametersObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }

    public class GetUserByIdResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("secondName")]
        public string SecondName { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Springglobal;

    public partial class WorkflowManagedActions
    {
        public SpringglobalActions Springglobal(string connectionId) => new SpringglobalActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SpringglobalTriggers Springglobal(string connectionId) => new SpringglobalTriggers(connectionId);
    }
}
