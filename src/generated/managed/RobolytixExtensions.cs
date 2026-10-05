//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Robolytix
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RobolytixActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "robolytix")]
        [WorkflowExpressionFactory(nameof(__BuildSonar))]
        public IBodyWorkflowAction<SonarResponse> Sonar([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyprocessid, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodyrunid = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SonarResponse> __BuildSonar(WorkflowValue<string> bodyname, WorkflowValue<string> bodyprocessid, WorkflowValue<string> bodytype, WorkflowValue<string> bodyrunid = null)
        {
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowValue.Validate(bodyprocessid, nameof(bodyprocessid), required: true);
            WorkflowValue.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowValue.Validate(bodyrunid, nameof(bodyrunid), required: false);
            return new DeferredBodyAction<SonarResponse>(() =>
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
