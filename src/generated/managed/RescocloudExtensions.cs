//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rescocloud
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RescocloudActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rescocloud")]
        [WorkflowExpressionFactory(nameof(__BuildRecordDelete))]
        public IBodyWorkflowAction<OdataError> RecordDelete([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<string> ifMatch = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OdataError> __BuildRecordDelete(WorkflowExpression<string> id, WorkflowExpression<string> entity, WorkflowExpression<string> ifMatch = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(entity, nameof(entity), required: true);
            WorkflowExpression.Validate(ifMatch, nameof(ifMatch), required: false);
            return new DeferredBodyAction<OdataError>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}('{1}')", ExpressionConverter.ConvertWithUrlEncoding(entity, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ifMatch != null)
                    callPayload.Headers["If-Match"] = ExpressionConverter.Convert(ifMatch);
                return new ApiConnectionAction<OdataError>(callPayload);
            });
        }
    }

    public class RescocloudTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildTriggerCreate))]
        public IWorkflowTrigger TriggerCreate([WorkflowExpression] Func<string> entity,[WorkflowExpression] Func<actionInput> action,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildTriggerCreate(WorkflowExpression<string> entity,WorkflowExpression<actionInput> action,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(entity, nameof(entity), required: true);
            WorkflowExpression.Validate(action, nameof(action), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/$hook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$entity"] = ExpressionConverter.Convert(entity);
                callPayload.Queries["$action"] = ExpressionConverter.Convert(action);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class OdataError
    {
        [JsonProperty("error")]
        public OdataErrorMain Error { get; set; }
    }

    public class OdataErrorMain
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
        public OdataErrorDetail[] Details { get; set; }
    }

    public class OdataErrorDetail
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum actionInput
    {
        Create,
        Update,
        Delete
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