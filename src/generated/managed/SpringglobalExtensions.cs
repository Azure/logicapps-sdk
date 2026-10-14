//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Springglobal
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class SpringglobalActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "springglobal")]
        public IBodyWorkflowAction<JToken> GetExecutionById(Expression<Func<string>> executionId, Expression<Func<string>> surveyId, Expression<Func<string>> publicationId, Expression<Func<bool>> advancedInfo = null)
        {
            var __workflow_executionId = executionId == null ? null : WorkflowExpression.Compile(executionId);
            WorkflowExpression.Validate(__workflow_executionId, nameof(executionId), required: true);
            var __workflow_surveyId = surveyId == null ? null : WorkflowExpression.Compile(surveyId);
            WorkflowExpression.Validate(__workflow_surveyId, nameof(surveyId), required: true);
            var __workflow_publicationId = publicationId == null ? null : WorkflowExpression.Compile(publicationId);
            WorkflowExpression.Validate(__workflow_publicationId, nameof(publicationId), required: true);
            var __workflow_advancedInfo = advancedInfo == null ? null : WorkflowExpression.Compile(advancedInfo);
            WorkflowExpression.Validate(__workflow_advancedInfo, nameof(advancedInfo), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/survey-service/execution/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_executionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["advancedInfo"] = Convert.ToString(false);
                if (__workflow_advancedInfo != null)
                    callPayload.Headers["advancedInfo"] = ExpressionConverter.Convert(__workflow_advancedInfo);
                callPayload.Headers["surveyId"] = ExpressionConverter.Convert(__workflow_surveyId);
                callPayload.Headers["publicationId"] = ExpressionConverter.Convert(__workflow_publicationId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "springglobal")]
        public IBodyWorkflowAction<GetUserByIdResponse> GetUserById(Expression<Func<string>> userId)
        {
            var __workflow_userId = userId == null ? null : WorkflowExpression.Compile(userId);
            WorkflowExpression.Validate(__workflow_userId, nameof(userId), required: true);
            return new DeferredBodyAction<GetUserByIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/identity-service/user/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUserByIdResponse>(callPayload);
            });
        }
    }

    public class SpringglobalTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger OnSurveyExecution(Expression<Func<string>> bodyparameterssurveyId = null, Expression<Func<string>> bodyparameterspublicationId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyparameterssurveyId = bodyparameterssurveyId == null ? null : WorkflowExpression.Compile(bodyparameterssurveyId);
            WorkflowExpression.Validate(__workflow_bodyparameterssurveyId, nameof(bodyparameterssurveyId), required: false);
            var __workflow_bodyparameterspublicationId = bodyparameterspublicationId == null ? null : WorkflowExpression.Compile(bodyparameterspublicationId);
            WorkflowExpression.Validate(__workflow_bodyparameterspublicationId, nameof(bodyparameterspublicationId), required: false);
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
                if (__workflow_bodyparameterssurveyId != null)
                {
                    parametersObject["surveyId"] = ExpressionConverter.ConvertO(__workflow_bodyparameterssurveyId);
                    parametersObjectpropCount++;
                }

                if (__workflow_bodyparameterspublicationId != null)
                {
                    parametersObject["publicationId"] = ExpressionConverter.ConvertO(__workflow_bodyparameterspublicationId);
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

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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
