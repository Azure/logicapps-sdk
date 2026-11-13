//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rescocloud
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RescocloudActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rescocloud")]
        public IBodyWorkflowAction<ODataError, ApiConnectionActionConfiguration> RecordDelete(Expression<Func<string>> id, Expression<Func<string>> entity, Expression<Func<string>> ifMatch = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_ifMatch = WorkflowExpression.Compile(ifMatch, nameof(ifMatch), required: false);
            return new DeferredBodyAction<ODataError, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}('{1}')", __workflow_entity.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ifMatch != null)
                    callPayload.Headers["If-Match"] = ExpressionConverter.Convert(__workflow_ifMatch);
                return new ApiConnectionAction<ODataError>(callPayload);
            });
        }
    }

    public class RescocloudTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> TriggerCreate(Expression<Func<string>> entity, Expression<Func<ActionInput>> action)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_action = WorkflowExpression.Compile(action, nameof(action), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/$hook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$entity"] = ExpressionConverter.Convert(__workflow_entity);
                callPayload.Queries["$action"] = ExpressionConverter.Convert(__workflow_action);
                callPayload.Body = new BodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class ODataError
    {
        [JsonProperty("error")]
        public ODataErrorMain Error { get; set; }
    }

    public class ODataErrorMain
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("innererror")]
        public JToken Innererror { get; set; }

        [JsonProperty("details")]
        public ODataErrorDetail[] Details { get; set; }
    }

    public class ODataErrorDetail
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ActionInput
    {
        Create,
        Update,
        Delete
    }

    public class BodyInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Rescocloud;

    public partial class WorkflowManagedActions
    {
        public RescocloudActions Rescocloud(string connectionId) => new RescocloudActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RescocloudTriggers Rescocloud(string connectionId) => new RescocloudTriggers(connectionId);
    }
}