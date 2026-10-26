//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Centrical
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CentricalActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "centrical")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PostLearning(Expression<Func<string>> learningType, Expression<Func<PostLearningInput>> body)
        {
            var __workflow_learningType = WorkflowExpression.Compile(learningType, nameof(learningType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/import/push/lms_{0}", __workflow_learningType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "centrical")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PostPerformance(Expression<Func<string>> performanceType, Expression<Func<PostPerformanceInput>> body)
        {
            var __workflow_performanceType = WorkflowExpression.Compile(performanceType, nameof(performanceType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/import/push/kpi_{0}", __workflow_performanceType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class CentricalTriggers([ConnectionName] string connectionId)
    {
    }

    public class PostLearningInput
    {
        [JsonProperty("event_time", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DateTime { get; set; }

        [JsonProperty("user_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserId { get; set; }

        [JsonProperty("course_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CourseName { get; set; }

        [JsonProperty("score", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Score { get; set; }

        [JsonProperty("course_category")]
        public string ContentCategory { get; set; }
    }

    public class PostPerformanceInput
    {
        [JsonProperty("event_time", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DateTime { get; set; }

        [JsonProperty("user_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserId { get; set; }

        [JsonProperty("kpi_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string KpiName { get; set; }

        [JsonProperty("kpi_value", DefaultValueHandling = DefaultValueHandling.Include)]
        public double KpiValue { get; set; }

        [JsonProperty("additional_data")]
        public string AdditionalData { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Centrical;

    public partial class WorkflowManagedActions
    {
        public CentricalActions Centrical(string connectionId) => new CentricalActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CentricalTriggers Centrical(string connectionId) => new CentricalTriggers(connectionId);
    }
}