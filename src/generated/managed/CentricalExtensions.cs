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
        public IWorkflowAction PostLearning(Expression<Func<string>> learningType, Expression<Func<string>> bodydateTime, Expression<Func<string>> bodyuserId, Expression<Func<string>> bodycourseName, Expression<Func<double>> bodyscore, Expression<Func<string>> bodycontentCategory = null)
        {
            var __workflow_learningType = WorkflowExpression.Compile(learningType, nameof(learningType), required: true);
            var __workflow_bodydateTime = WorkflowExpression.Compile(bodydateTime, nameof(bodydateTime), required: true);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: true);
            var __workflow_bodycourseName = WorkflowExpression.Compile(bodycourseName, nameof(bodycourseName), required: true);
            var __workflow_bodyscore = WorkflowExpression.Compile(bodyscore, nameof(bodyscore), required: true);
            var __workflow_bodycontentCategory = WorkflowExpression.Compile(bodycontentCategory, nameof(bodycontentCategory), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/import/push/lms_{0}", __workflow_learningType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event_time"] = ExpressionConverter.ConvertO(__workflow_bodydateTime);
                bodypropCount++;
                body["user_id"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                bodypropCount++;
                body["course_name"] = ExpressionConverter.ConvertO(__workflow_bodycourseName);
                bodypropCount++;
                body["score"] = ExpressionConverter.ConvertO(__workflow_bodyscore);
                if (__workflow_bodycontentCategory != null)
                {
                    body["course_category"] = ExpressionConverter.ConvertO(__workflow_bodycontentCategory);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "centrical")]
        public IWorkflowAction PostPerformance(Expression<Func<string>> performanceType, Expression<Func<string>> bodydateTime, Expression<Func<string>> bodyuserId, Expression<Func<string>> bodykpiName, Expression<Func<double>> bodykpiValue, Expression<Func<string>> bodyadditionalData = null)
        {
            var __workflow_performanceType = WorkflowExpression.Compile(performanceType, nameof(performanceType), required: true);
            var __workflow_bodydateTime = WorkflowExpression.Compile(bodydateTime, nameof(bodydateTime), required: true);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: true);
            var __workflow_bodykpiName = WorkflowExpression.Compile(bodykpiName, nameof(bodykpiName), required: true);
            var __workflow_bodykpiValue = WorkflowExpression.Compile(bodykpiValue, nameof(bodykpiValue), required: true);
            var __workflow_bodyadditionalData = WorkflowExpression.Compile(bodyadditionalData, nameof(bodyadditionalData), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/import/push/kpi_{0}", __workflow_performanceType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event_time"] = ExpressionConverter.ConvertO(__workflow_bodydateTime);
                bodypropCount++;
                body["user_id"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                bodypropCount++;
                body["kpi_name"] = ExpressionConverter.ConvertO(__workflow_bodykpiName);
                bodypropCount++;
                body["kpi_value"] = ExpressionConverter.ConvertO(__workflow_bodykpiValue);
                if (__workflow_bodyadditionalData != null)
                {
                    body["additional_data"] = ExpressionConverter.ConvertO(__workflow_bodyadditionalData);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class CentricalTriggers([ConnectionName] string connectionId)
    {
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
