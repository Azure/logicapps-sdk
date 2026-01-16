//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Autoreview
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AutoreviewActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autoreview")]
        public IBodyWorkflowAction<GETInfoResponse> GETInfo()
        {
            var apiCallPath = "/v2/autoreview/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GETInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "autoreview")]
        public IWorkflowAction POSTHttp(Expression<Func<string>> path = null)
        {
            var apiCallPath = "/v2/autoreview/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (path != null)
                callPayload.Queries["path"] = ExpressionConverter.Convert(path);
            var body = new JObject();
            var bodypropCount = 0;
            var configsObject = new JObject();
            var configsObjectpropCount = 0;
            if (configsObjectpropCount > 0)
            {
                body["configs"] = configsObject;
                bodypropCount++;
            }

            var propertiesObject = new JObject();
            var propertiesObjectpropCount = 0;
            if (propertiesObjectpropCount > 0)
            {
                body["properties"] = propertiesObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class AutoreviewTriggers([ConnectionName] string connectionId)
    {
    }

    public class GETInfoResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("apiKey")]
        public string ApiKey { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("information")]
        public string Information { get; set; }

        [JsonProperty("diagram")]
        public string Diagram { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Autoreview;

    public partial class WorkflowManagedActions
    {
        public AutoreviewActions Autoreview(string connectionId) => new AutoreviewActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AutoreviewTriggers Autoreview(string connectionId) => new AutoreviewTriggers(connectionId);
    }
}