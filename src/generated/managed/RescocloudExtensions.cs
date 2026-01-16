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
        public IBodyWorkflowAction<OdataError> RecordDelete(Expression<Func<string>> id, Expression<Func<string>> entity, Expression<Func<string>> ifMatch = null)
        {
            var apiCallPath = String.Format("/{0}('{1}')", ExpressionConverter.ConvertWithUrlEncoding(entity, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (ifMatch != null)
                callPayload.Headers["If-Match"] = ExpressionConverter.Convert(ifMatch);
            return new ApiConnectionAction<OdataError>(callPayload);
        }
    }

    public class RescocloudTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger TriggerCreate(Expression<Func<string>> entity, Expression<Func<actionInput>> action)
        {
            var apiCallPath = "/$hook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["$entity"] = ExpressionConverter.Convert(entity);
            callPayload.Queries["$action"] = ExpressionConverter.Convert(action);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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