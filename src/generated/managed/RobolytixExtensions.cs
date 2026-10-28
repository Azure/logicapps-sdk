//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Robolytix
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RobolytixActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "robolytix")]
        public IBodyWorkflowAction<SonarResponse> Sonar(Expression<Func<string>> bodyname, Expression<Func<string>> bodyprocessid, Expression<Func<string>> bodytype, Expression<Func<string>> bodyrunid = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyprocessid = WorkflowExpression.Compile(bodyprocessid, nameof(bodyprocessid), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodyrunid = WorkflowExpression.Compile(bodyrunid, nameof(bodyrunid), required: false);
            return new DeferredBodyAction<SonarResponse>(() =>
            {
                var apiCallPath = "/messages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["processid"] = ExpressionConverter.ConvertO(__workflow_bodyprocessid);
                if (__workflow_bodyrunid != null)
                {
                    body["runid"] = ExpressionConverter.ConvertO(__workflow_bodyrunid);
                    bodypropCount++;
                }

                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SonarResponse>(callPayload);
            });
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
