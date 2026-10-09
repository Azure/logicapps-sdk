//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cascadestrategynew
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CascadestrategynewActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascadestrategynew")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateMeasure2))]
        public IBodyWorkflowAction<UpdateMeasure2Response> UpdateMeasure2([WorkflowExpression] Func<string> bodyworkspaceId, [WorkflowExpression] Func<string> bodyplanId, [WorkflowExpression] Func<double> bodymeasureValue, [WorkflowExpression] Func<string> measureId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateMeasure2Response> __BuildUpdateMeasure2(WorkflowExpression<string> bodyworkspaceId, WorkflowExpression<string> bodyplanId, WorkflowExpression<double> bodymeasureValue, WorkflowExpression<string> measureId)
        {
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            WorkflowExpression.Validate(bodyplanId, nameof(bodyplanId), required: true);
            WorkflowExpression.Validate(bodymeasureValue, nameof(bodymeasureValue), required: true);
            WorkflowExpression.Validate(measureId, nameof(measureId), required: true);
            return new DeferredBodyAction<UpdateMeasure2Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/measures/{0}", ExpressionConverter.ConvertWithUrlEncoding(measureId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspace_id"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                bodypropCount++;
                body["plan_id"] = ExpressionConverter.ConvertO(bodyplanId);
                bodypropCount++;
                body["measure_value"] = ExpressionConverter.ConvertO(bodymeasureValue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateMeasure2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascadestrategynew")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateMeasureHistoricalValue2))]
        public IBodyWorkflowAction<UpdateMeasureHistoricalValue2Response> UpdateMeasureHistoricalValue2([WorkflowExpression] Func<string> bodyworkspaceId, [WorkflowExpression] Func<string> bodyplanId, [WorkflowExpression] Func<string> measureId, [WorkflowExpression] Func<bodyhistoricalDataInputItem[]> bodyhistoricalData = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateMeasureHistoricalValue2Response> __BuildUpdateMeasureHistoricalValue2(WorkflowExpression<string> bodyworkspaceId, WorkflowExpression<string> bodyplanId, WorkflowExpression<string> measureId, WorkflowExpression<bodyhistoricalDataInputItem[]> bodyhistoricalData = null)
        {
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            WorkflowExpression.Validate(bodyplanId, nameof(bodyplanId), required: true);
            WorkflowExpression.Validate(measureId, nameof(measureId), required: true);
            WorkflowExpression.Validate(bodyhistoricalData, nameof(bodyhistoricalData), required: false);
            return new DeferredBodyAction<UpdateMeasureHistoricalValue2Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/measures/historical/{0}", ExpressionConverter.ConvertWithUrlEncoding(measureId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspace_id"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                bodypropCount++;
                body["plan_id"] = ExpressionConverter.ConvertO(bodyplanId);
                if (bodyhistoricalData != null)
                {
                    body["historical_data"] = ExpressionConverter.ConvertO(bodyhistoricalData);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateMeasureHistoricalValue2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascadestrategynew")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateAction2))]
        public IBodyWorkflowAction<UpdateAction2Response> UpdateAction2([WorkflowExpression] Func<string> bodyworkspaceId, [WorkflowExpression] Func<string> bodyplanId, [WorkflowExpression] Func<double> bodyactionValue, [WorkflowExpression] Func<string> actionId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateAction2Response> __BuildUpdateAction2(WorkflowExpression<string> bodyworkspaceId, WorkflowExpression<string> bodyplanId, WorkflowExpression<double> bodyactionValue, WorkflowExpression<string> actionId)
        {
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            WorkflowExpression.Validate(bodyplanId, nameof(bodyplanId), required: true);
            WorkflowExpression.Validate(bodyactionValue, nameof(bodyactionValue), required: true);
            WorkflowExpression.Validate(actionId, nameof(actionId), required: true);
            return new DeferredBodyAction<UpdateAction2Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/actions/{0}", ExpressionConverter.ConvertWithUrlEncoding(actionId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspace_id"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                bodypropCount++;
                body["plan_id"] = ExpressionConverter.ConvertO(bodyplanId);
                bodypropCount++;
                body["action_value"] = ExpressionConverter.ConvertO(bodyactionValue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateAction2Response>(callPayload);
            });
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