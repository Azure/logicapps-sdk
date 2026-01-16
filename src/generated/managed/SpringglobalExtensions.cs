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
        public IBodyWorkflowAction<JToken> GetExecutionById(Expression<Func<string>> executionId, Expression<Func<string>> surveyId, Expression<Func<string>> publicationId, Expression<Func<bool>> advancedInfo = null)
        {
            var apiCallPath = String.Format("/survey-service/execution/{0}", ExpressionConverter.ConvertWithUrlEncoding(executionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["advancedInfo"] = Convert.ToString(false);
            if (advancedInfo != null)
                callPayload.Headers["advancedInfo"] = ExpressionConverter.Convert(advancedInfo);
            callPayload.Headers["surveyId"] = ExpressionConverter.Convert(surveyId);
            callPayload.Headers["publicationId"] = ExpressionConverter.Convert(publicationId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "springglobal")]
        public IBodyWorkflowAction<GetUserByIdResponse> GetUserById(Expression<Func<string>> userId)
        {
            var apiCallPath = String.Format("/identity-service/user/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetUserByIdResponse>(callPayload);
        }
    }

    public class SpringglobalTriggers([ConnectionName] string connectionId)
    {
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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