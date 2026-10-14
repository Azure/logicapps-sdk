//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Centrical
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class CentricalActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "centrical")]
        public IWorkflowAction PostLearning(Expression<Func<string>> learningType, Expression<Func<string>> bodydateTime, Expression<Func<string>> bodyuserId, Expression<Func<string>> bodycourseName, Expression<Func<double>> bodyscore, Expression<Func<string>> bodycontentCategory = null)
        {
            var __workflow_learningType = learningType == null ? null : WorkflowExpression.Compile(learningType);
            WorkflowExpression.Validate(__workflow_learningType, nameof(learningType), required: true);
            var __workflow_bodydateTime = bodydateTime == null ? null : WorkflowExpression.Compile(bodydateTime);
            WorkflowExpression.Validate(__workflow_bodydateTime, nameof(bodydateTime), required: true);
            var __workflow_bodyuserId = bodyuserId == null ? null : WorkflowExpression.Compile(bodyuserId);
            WorkflowExpression.Validate(__workflow_bodyuserId, nameof(bodyuserId), required: true);
            var __workflow_bodycourseName = bodycourseName == null ? null : WorkflowExpression.Compile(bodycourseName);
            WorkflowExpression.Validate(__workflow_bodycourseName, nameof(bodycourseName), required: true);
            var __workflow_bodyscore = bodyscore == null ? null : WorkflowExpression.Compile(bodyscore);
            WorkflowExpression.Validate(__workflow_bodyscore, nameof(bodyscore), required: true);
            var __workflow_bodycontentCategory = bodycontentCategory == null ? null : WorkflowExpression.Compile(bodycontentCategory);
            WorkflowExpression.Validate(__workflow_bodycontentCategory, nameof(bodycontentCategory), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/import/push/lms_{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_learningType, 1));
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
            var __workflow_performanceType = performanceType == null ? null : WorkflowExpression.Compile(performanceType);
            WorkflowExpression.Validate(__workflow_performanceType, nameof(performanceType), required: true);
            var __workflow_bodydateTime = bodydateTime == null ? null : WorkflowExpression.Compile(bodydateTime);
            WorkflowExpression.Validate(__workflow_bodydateTime, nameof(bodydateTime), required: true);
            var __workflow_bodyuserId = bodyuserId == null ? null : WorkflowExpression.Compile(bodyuserId);
            WorkflowExpression.Validate(__workflow_bodyuserId, nameof(bodyuserId), required: true);
            var __workflow_bodykpiName = bodykpiName == null ? null : WorkflowExpression.Compile(bodykpiName);
            WorkflowExpression.Validate(__workflow_bodykpiName, nameof(bodykpiName), required: true);
            var __workflow_bodykpiValue = bodykpiValue == null ? null : WorkflowExpression.Compile(bodykpiValue);
            WorkflowExpression.Validate(__workflow_bodykpiValue, nameof(bodykpiValue), required: true);
            var __workflow_bodyadditionalData = bodyadditionalData == null ? null : WorkflowExpression.Compile(bodyadditionalData);
            WorkflowExpression.Validate(__workflow_bodyadditionalData, nameof(bodyadditionalData), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/import/push/kpi_{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_performanceType, 1));
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
