//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Springglobal
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SpringglobalActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "springglobal")]
        public IBodyWorkflowAction<JToken> GetExecutionById([WorkflowExpression] Func<string> executionId, [WorkflowExpression] Func<string> surveyId, [WorkflowExpression] Func<string> publicationId, [WorkflowExpression] Func<bool> advancedInfo = null)
        {
            SourceExpression.Validate(executionId, nameof(executionId), required: true);
            SourceExpression.Validate(surveyId, nameof(surveyId), required: true);
            SourceExpression.Validate(publicationId, nameof(publicationId), required: true);
            SourceExpression.Validate(advancedInfo, nameof(advancedInfo), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/survey-service/execution/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(executionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["advancedInfo"] = Convert.ToString(false);
                if (advancedInfo != null)
                    callPayload.Headers["advancedInfo"] = SourceExpressionConverter.ConvertO(advancedInfo);
                callPayload.Headers["surveyId"] = SourceExpressionConverter.ConvertO(surveyId);
                callPayload.Headers["publicationId"] = SourceExpressionConverter.ConvertO(publicationId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "springglobal")]
        public IBodyWorkflowAction<GetUserByIdResponse> GetUserById([WorkflowExpression] Func<string> userId)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/identity-service/user/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetUserByIdResponse>(BuildSourceInput);
        }
    }

    public class SpringglobalTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger OnSurveyExecution([WorkflowExpression] Func<string> bodyparameterssurveyId = null, [WorkflowExpression] Func<string> bodyparameterspublicationId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyparameterssurveyId, nameof(bodyparameterssurveyId), required: false);
            SourceExpression.Validate(bodyparameterspublicationId, nameof(bodyparameterspublicationId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook-service/subscribe/surveyexecution";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callback"] = "@listCallbackUrl()";
                bodypropCount++;
                var parametersObject = new JObject();
                var parametersObjectpropCount = 0;
                if (bodyparameterssurveyId != null)
                {
                    parametersObject["surveyId"] = SourceExpressionConverter.ConvertToken(bodyparameterssurveyId);
                    parametersObjectpropCount++;
                }

                if (bodyparameterspublicationId != null)
                {
                    parametersObject["publicationId"] = SourceExpressionConverter.ConvertToken(bodyparameterspublicationId);
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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