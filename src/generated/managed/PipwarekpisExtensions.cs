//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pipwarekpis
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PipwarekpisActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipwarekpis")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SaveKpiActuals(Expression<Func<string>> contentType, Expression<Func<SaveKpiActualsBodyInputItem[]>> body)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/kpiIntegration/values";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pipwarekpis")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SaveKpiTargets(Expression<Func<string>> contentType, Expression<Func<SaveKpiTargetsBodyInputItem[]>> body)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/kpiIntegration/targets";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class PipwarekpisTriggers([ConnectionName] string connectionId)
    {
    }

    public class SaveKpiActualsBodyInputItem
    {
        public SaveKpiActualsBodyInputItem(string kpiCode, string valueDate)
        {
            this.KpiCode = kpiCode;
            this.ValueDate = valueDate;
        }

        [JsonProperty("kpiCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public string KpiCode { get; set; }

        [JsonProperty("valueDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ValueDate { get; set; }

        [JsonProperty("actualValue")]
        public double? ActualValue { get; set; }

        [JsonProperty("deleted")]
        public bool? Deleted { get; set; }
    }

    public class SaveKpiTargetsBodyInputItem
    {
        public SaveKpiTargetsBodyInputItem(string kpiCode, string targetDate)
        {
            this.KpiCode = kpiCode;
            this.TargetDate = targetDate;
        }

        [JsonProperty("kpiCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public string KpiCode { get; set; }

        [JsonProperty("targetDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetDate { get; set; }

        [JsonProperty("targetValue")]
        public double? TargetValue { get; set; }

        [JsonProperty("deleted")]
        public bool? Deleted { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pipwarekpis;

    public partial class WorkflowManagedActions
    {
        public PipwarekpisActions Pipwarekpis(string connectionId) => new PipwarekpisActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PipwarekpisTriggers Pipwarekpis(string connectionId) => new PipwarekpisTriggers(connectionId);
    }
}