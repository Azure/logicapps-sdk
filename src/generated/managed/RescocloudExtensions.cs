//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rescocloud
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RescocloudActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rescocloud")]
        public IBodyWorkflowAction<OdataError> RecordDelete([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<string> ifMatch = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(entity, nameof(entity), required: true);
            SourceExpression.Validate(ifMatch, nameof(ifMatch), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}('{1}')", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entity, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ifMatch != null)
                    callPayload.Headers["If-Match"] = SourceExpressionConverter.ConvertO(ifMatch);
                return callPayload;
            }

            return new ApiConnectionAction<OdataError>(BuildSourceInput);
        }
    }

    public class RescocloudTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger TriggerCreate([WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<actionInput> action, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(entity, nameof(entity), required: true);
            SourceExpression.Validate(action, nameof(action), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/$hook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$entity"] = SourceExpressionConverter.ConvertO(entity);
                callPayload.Queries["$action"] = SourceExpressionConverter.Convert(action);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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