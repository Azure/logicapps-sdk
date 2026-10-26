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
        public IBodyWorkflowAction<UpdateMeasure2Response, ApiConnectionActionConfiguration> UpdateMeasure2(Expression<Func<UpdateMeasure2Input>> body, Expression<Func<string>> measureId)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_measureId = WorkflowExpression.Compile(measureId, nameof(measureId), required: true);
            return new DeferredBodyAction<UpdateMeasure2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/measures/{0}", __workflow_measureId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateMeasure2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascadestrategynew")]
        public IBodyWorkflowAction<UpdateMeasureHistoricalValue2Response, ApiConnectionActionConfiguration> UpdateMeasureHistoricalValue2(Expression<Func<UpdateMeasureHistoricalValue2Input>> body, Expression<Func<string>> measureId)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_measureId = WorkflowExpression.Compile(measureId, nameof(measureId), required: true);
            return new DeferredBodyAction<UpdateMeasureHistoricalValue2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/measures/historical/{0}", __workflow_measureId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateMeasureHistoricalValue2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascadestrategynew")]
        public IBodyWorkflowAction<UpdateAction2Response, ApiConnectionActionConfiguration> UpdateAction2(Expression<Func<UpdateAction2Input>> body, Expression<Func<string>> actionId)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_actionId = WorkflowExpression.Compile(actionId, nameof(actionId), required: true);
            return new DeferredBodyAction<UpdateAction2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/actions/{0}", __workflow_actionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class UpdateMeasure2Input
    {
        [JsonProperty("workspace_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkspaceId { get; set; }

        [JsonProperty("plan_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlanId { get; set; }

        [JsonProperty("measure_value", DefaultValueHandling = DefaultValueHandling.Include)]
        public double MeasureValue { get; set; }
    }

    public class UpdateMeasureHistoricalValue2Response
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class UpdateMeasureHistoricalValue2Input
    {
        [JsonProperty("workspace_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkspaceId { get; set; }

        [JsonProperty("plan_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlanId { get; set; }

        [JsonProperty("historical_data")]
        public UpdateMeasureHistoricalValue2InputHistoricalDataTypeItem[] HistoricalData { get; set; }
    }

    public class UpdateMeasureHistoricalValue2InputHistoricalDataTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("value")]
        public int? Value { get; set; }
    }

    public class UpdateAction2Response
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class UpdateAction2Input
    {
        [JsonProperty("workspace_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkspaceId { get; set; }

        [JsonProperty("plan_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PlanId { get; set; }

        [JsonProperty("action_value", DefaultValueHandling = DefaultValueHandling.Include)]
        public double ActionValue { get; set; }
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