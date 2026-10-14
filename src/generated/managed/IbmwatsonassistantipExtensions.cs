//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ibmwatsonassistantip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class IbmwatsonassistantipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ibmwatsonassistantip")]
        public IBodyWorkflowAction<CreateSessionResponse> CreateSession(Expression<Func<string>> version)
        {
            var __workflow_version = version == null ? null : WorkflowExpression.Compile(version);
            WorkflowExpression.Validate(__workflow_version, nameof(version), required: true);
            return new DeferredBodyAction<CreateSessionResponse>(() =>
            {
                var apiCallPath = "/sessions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["version"] = ExpressionConverter.Convert(__workflow_version);
                return new ApiConnectionAction<CreateSessionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ibmwatsonassistantip")]
        public IWorkflowAction DeleteSession(Expression<Func<string>> session, Expression<Func<string>> version = null)
        {
            var __workflow_session = session == null ? null : WorkflowExpression.Compile(session);
            WorkflowExpression.Validate(__workflow_session, nameof(session), required: true);
            var __workflow_version = version == null ? null : WorkflowExpression.Compile(version);
            WorkflowExpression.Validate(__workflow_version, nameof(version), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/sessions/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_session, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["version"] = Convert.ToString("2021-11-27");
                if (__workflow_version != null)
                    callPayload.Queries["version"] = ExpressionConverter.Convert(__workflow_version);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ibmwatsonassistantip")]
        public IBodyWorkflowAction<StatefulMessageResponse> StatefulMessage(Expression<Func<string>> session, Expression<Func<string>> version = null, Expression<Func<string>> bodyinputtext = null)
        {
            var __workflow_session = session == null ? null : WorkflowExpression.Compile(session);
            WorkflowExpression.Validate(__workflow_session, nameof(session), required: true);
            var __workflow_version = version == null ? null : WorkflowExpression.Compile(version);
            WorkflowExpression.Validate(__workflow_version, nameof(version), required: false);
            var __workflow_bodyinputtext = bodyinputtext == null ? null : WorkflowExpression.Compile(bodyinputtext);
            WorkflowExpression.Validate(__workflow_bodyinputtext, nameof(bodyinputtext), required: false);
            return new DeferredBodyAction<StatefulMessageResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/sessions/{0}/message", ExpressionConverter.ConvertWithUrlEncoding(__workflow_session, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["version"] = Convert.ToString("2021-11-27");
                if (__workflow_version != null)
                    callPayload.Queries["version"] = ExpressionConverter.Convert(__workflow_version);
                var body = new JObject();
                var bodypropCount = 0;
                var inputObject = new JObject();
                var inputObjectpropCount = 0;
                if (__workflow_bodyinputtext != null)
                {
                    inputObject["text"] = ExpressionConverter.ConvertO(__workflow_bodyinputtext);
                    inputObjectpropCount++;
                }

                if (inputObjectpropCount > 0)
                {
                    body["input"] = inputObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StatefulMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ibmwatsonassistantip")]
        public IBodyWorkflowAction<StatelessMessageResponse> StatelessMessage(Expression<Func<string>> version = null, Expression<Func<string>> bodyinputtext = null)
        {
            var __workflow_version = version == null ? null : WorkflowExpression.Compile(version);
            WorkflowExpression.Validate(__workflow_version, nameof(version), required: false);
            var __workflow_bodyinputtext = bodyinputtext == null ? null : WorkflowExpression.Compile(bodyinputtext);
            WorkflowExpression.Validate(__workflow_bodyinputtext, nameof(bodyinputtext), required: false);
            return new DeferredBodyAction<StatelessMessageResponse>(() =>
            {
                var apiCallPath = "/message";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["version"] = Convert.ToString("2021-11-27");
                if (__workflow_version != null)
                    callPayload.Queries["version"] = ExpressionConverter.Convert(__workflow_version);
                var body = new JObject();
                var bodypropCount = 0;
                var inputObject = new JObject();
                var inputObjectpropCount = 0;
                if (__workflow_bodyinputtext != null)
                {
                    inputObject["text"] = ExpressionConverter.ConvertO(__workflow_bodyinputtext);
                    inputObjectpropCount++;
                }

                if (inputObjectpropCount > 0)
                {
                    body["input"] = inputObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StatelessMessageResponse>(callPayload);
            });
        }
    }

    public class IbmwatsonassistantipTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateSessionResponse
    {
        [JsonProperty("session_id")]
        public string SessionId { get; set; }
    }

    public class StatefulMessageResponse
    {
        [JsonProperty("output")]
        public StatefulMessageResponseOutputType Output { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }

    public class StatefulMessageResponseOutputType
    {
        [JsonProperty("intents")]
        public StatefulMessageResponseOutputTypeIntentsTypeItem[] Intents { get; set; }

        [JsonProperty("generic")]
        public StatefulMessageResponseOutputTypeGenericTypeItem[] Generic { get; set; }
    }

    public class StatefulMessageResponseOutputTypeIntentsTypeItem
    {
        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class StatefulMessageResponseOutputTypeGenericTypeItem
    {
        [JsonProperty("response_type")]
        public string ResponseType { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class StatelessMessageResponse
    {
        [JsonProperty("output")]
        public StatelessMessageResponseOutputType Output { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }

    public class StatelessMessageResponseOutputType
    {
        [JsonProperty("intents")]
        public StatelessMessageResponseOutputTypeIntentsTypeItem[] Intents { get; set; }

        [JsonProperty("generic")]
        public StatelessMessageResponseOutputTypeGenericTypeItem[] Generic { get; set; }
    }

    public class StatelessMessageResponseOutputTypeIntentsTypeItem
    {
        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }
    }

    public class StatelessMessageResponseOutputTypeGenericTypeItem
    {
        [JsonProperty("response_type")]
        public string ResponseType { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ibmwatsonassistantip;

    public partial class WorkflowManagedActions
    {
        public IbmwatsonassistantipActions Ibmwatsonassistantip(string connectionId) => new IbmwatsonassistantipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IbmwatsonassistantipTriggers Ibmwatsonassistantip(string connectionId) => new IbmwatsonassistantipTriggers(connectionId);
    }
}
