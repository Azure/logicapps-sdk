//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cascadestrategynew
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CascadestrategynewActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascadestrategynew")]
        public IBodyWorkflowAction<UpdateMeasure2Response> UpdateMeasure2([WorkflowExpression] Func<string> bodyworkspaceId, [WorkflowExpression] Func<string> bodyplanId, [WorkflowExpression] Func<double> bodymeasureValue, [WorkflowExpression] Func<string> measureId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/measures/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(measureId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspace_id"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                bodypropCount++;
                body["plan_id"] = SourceExpressionConverter.ConvertToken(bodyplanId);
                bodypropCount++;
                body["measure_value"] = SourceExpressionConverter.ConvertToken(bodymeasureValue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateMeasure2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascadestrategynew")]
        public IBodyWorkflowAction<UpdateMeasureHistoricalValue2Response> UpdateMeasureHistoricalValue2([WorkflowExpression] Func<string> bodyworkspaceId, [WorkflowExpression] Func<string> bodyplanId, [WorkflowExpression] Func<string> measureId, [WorkflowExpression] Func<bodyhistoricalDataInputItem[]> bodyhistoricalData = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/measures/historical/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(measureId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspace_id"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                bodypropCount++;
                body["plan_id"] = SourceExpressionConverter.ConvertToken(bodyplanId);
                if (bodyhistoricalData != null)
                {
                    body["historical_data"] = SourceExpressionConverter.ConvertToken(bodyhistoricalData);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateMeasureHistoricalValue2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascadestrategynew")]
        public IBodyWorkflowAction<UpdateAction2Response> UpdateAction2([WorkflowExpression] Func<string> bodyworkspaceId, [WorkflowExpression] Func<string> bodyplanId, [WorkflowExpression] Func<double> bodyactionValue, [WorkflowExpression] Func<string> actionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/actions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(actionId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspace_id"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                bodypropCount++;
                body["plan_id"] = SourceExpressionConverter.ConvertToken(bodyplanId);
                bodypropCount++;
                body["action_value"] = SourceExpressionConverter.ConvertToken(bodyactionValue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateAction2Response>(BuildSourceInput);
        }
    }

    public class CascadestrategynewTriggers([ConnectionName] string connectionId)
    {
    }

    public class UpdateMeasure2Response
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class UpdateMeasureHistoricalValue2Response
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class bodyhistoricalDataInputItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class UpdateAction2Response
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cascadestrategynew;

    public partial class WorkflowManagedActions
    {
        public CascadestrategynewActions Cascadestrategynew(string connectionId) => new CascadestrategynewActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CascadestrategynewTriggers Cascadestrategynew(string connectionId) => new CascadestrategynewTriggers(connectionId);
    }
}