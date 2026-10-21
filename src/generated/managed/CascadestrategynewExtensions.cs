//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cascadestrategynew
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CascadestrategynewActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascadestrategynew")]
        public IBodyWorkflowAction<UpdateMeasure2Response> UpdateMeasure2(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyplanId, Expression<Func<double>> bodymeasureValue, Expression<Func<string>> measureId)
        {
            var __workflow_bodyworkspaceId = WorkflowExpression.Compile(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            var __workflow_bodyplanId = WorkflowExpression.Compile(bodyplanId, nameof(bodyplanId), required: true);
            var __workflow_bodymeasureValue = WorkflowExpression.Compile(bodymeasureValue, nameof(bodymeasureValue), required: true);
            var __workflow_measureId = WorkflowExpression.Compile(measureId, nameof(measureId), required: true);
            return new DeferredBodyAction<UpdateMeasure2Response>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/measures/{0}", __workflow_measureId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspace_id"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                bodypropCount++;
                body["plan_id"] = ExpressionConverter.ConvertO(__workflow_bodyplanId);
                bodypropCount++;
                body["measure_value"] = ExpressionConverter.ConvertO(__workflow_bodymeasureValue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateMeasure2Response>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascadestrategynew")]
        public IBodyWorkflowAction<UpdateMeasureHistoricalValue2Response> UpdateMeasureHistoricalValue2(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyplanId, Expression<Func<string>> measureId, Expression<Func<bodyhistoricalDataInputItem[]>> bodyhistoricalData = null)
        {
            var __workflow_bodyworkspaceId = WorkflowExpression.Compile(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            var __workflow_bodyplanId = WorkflowExpression.Compile(bodyplanId, nameof(bodyplanId), required: true);
            var __workflow_measureId = WorkflowExpression.Compile(measureId, nameof(measureId), required: true);
            var __workflow_bodyhistoricalData = WorkflowExpression.Compile(bodyhistoricalData, nameof(bodyhistoricalData), required: false);
            return new DeferredBodyAction<UpdateMeasureHistoricalValue2Response>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/measures/historical/{0}", __workflow_measureId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspace_id"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                bodypropCount++;
                body["plan_id"] = ExpressionConverter.ConvertO(__workflow_bodyplanId);
                if (__workflow_bodyhistoricalData != null)
                {
                    body["historical_data"] = ExpressionConverter.ConvertO(__workflow_bodyhistoricalData);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateMeasureHistoricalValue2Response>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascadestrategynew")]
        public IBodyWorkflowAction<UpdateAction2Response> UpdateAction2(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyplanId, Expression<Func<double>> bodyactionValue, Expression<Func<string>> actionId)
        {
            var __workflow_bodyworkspaceId = WorkflowExpression.Compile(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            var __workflow_bodyplanId = WorkflowExpression.Compile(bodyplanId, nameof(bodyplanId), required: true);
            var __workflow_bodyactionValue = WorkflowExpression.Compile(bodyactionValue, nameof(bodyactionValue), required: true);
            var __workflow_actionId = WorkflowExpression.Compile(actionId, nameof(actionId), required: true);
            return new DeferredBodyAction<UpdateAction2Response>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/actions/{0}", __workflow_actionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspace_id"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                bodypropCount++;
                body["plan_id"] = ExpressionConverter.ConvertO(__workflow_bodyplanId);
                bodypropCount++;
                body["action_value"] = ExpressionConverter.ConvertO(__workflow_bodyactionValue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateAction2Response>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
