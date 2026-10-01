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
        public IBodyWorkflowAction<SonarResponse> Sonar([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyprocessid, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodyrunid = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["processid"] = SourceExpressionConverter.ConvertToken(bodyprocessid);
                if (bodyrunid != null)
                {
                    body["runid"] = SourceExpressionConverter.ConvertToken(bodyrunid);
                    bodypropCount++;
                }

                bodypropCount++;
                body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SonarResponse>(BuildSourceInput);
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