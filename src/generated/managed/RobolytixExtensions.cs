//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Robolytix
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RobolytixActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "robolytix")]
        public IBodyWorkflowAction<SonarResponse> Sonar(Expression<Func<string>> bodyname, Expression<Func<string>> bodyprocessid, Expression<Func<string>> bodytype, Expression<Func<string>> bodyrunid = null)
        {
            var apiCallPath = "/messages";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["processid"] = ExpressionConverter.ConvertO(bodyprocessid);
            if (bodyrunid != null)
            {
                body["runid"] = ExpressionConverter.ConvertO(bodyrunid);
                bodypropCount++;
            }

            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SonarResponse>(callPayload);
        }
    }

    public class RobolytixTriggers([ConnectionName] string connectionId)
    {
    }

    public class SonarResponse
    {
        [JsonProperty("data")]
        public SonarResponseDataType Data { get; set; }
    }

    public class SonarResponseDataType
    {
        [JsonProperty("runid")]
        public string Runid { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Robolytix;

    public partial class WorkflowManagedActions
    {
        public RobolytixActions Robolytix(string connectionId) => new RobolytixActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RobolytixTriggers Robolytix(string connectionId) => new RobolytixTriggers(connectionId);
    }
}