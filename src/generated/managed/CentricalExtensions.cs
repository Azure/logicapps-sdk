//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Centrical
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CentricalActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "centrical")]
        [WorkflowExpressionFactory(nameof(__BuildPostLearning))]
        public IWorkflowAction PostLearning([WorkflowExpression] Func<string> learningType, [WorkflowExpression] Func<string> bodydateTime, [WorkflowExpression] Func<string> bodyuserId, [WorkflowExpression] Func<string> bodycourseName, [WorkflowExpression] Func<double> bodyscore, [WorkflowExpression] Func<string> bodycontentCategory = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPostLearning(WorkflowExpression<string> learningType, WorkflowExpression<string> bodydateTime, WorkflowExpression<string> bodyuserId, WorkflowExpression<string> bodycourseName, WorkflowExpression<double> bodyscore, WorkflowExpression<string> bodycontentCategory = null)
        {
            WorkflowExpression.Validate(learningType, nameof(learningType), required: true);
            WorkflowExpression.Validate(bodydateTime, nameof(bodydateTime), required: true);
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: true);
            WorkflowExpression.Validate(bodycourseName, nameof(bodycourseName), required: true);
            WorkflowExpression.Validate(bodyscore, nameof(bodyscore), required: true);
            WorkflowExpression.Validate(bodycontentCategory, nameof(bodycontentCategory), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/import/push/lms_{0}", ExpressionConverter.ConvertWithUrlEncoding(learningType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event_time"] = ExpressionConverter.ConvertO(bodydateTime);
                bodypropCount++;
                body["user_id"] = ExpressionConverter.ConvertO(bodyuserId);
                bodypropCount++;
                body["course_name"] = ExpressionConverter.ConvertO(bodycourseName);
                bodypropCount++;
                body["score"] = ExpressionConverter.ConvertO(bodyscore);
                if (bodycontentCategory != null)
                {
                    body["course_category"] = ExpressionConverter.ConvertO(bodycontentCategory);
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
        [WorkflowExpressionFactory(nameof(__BuildPostPerformance))]
        public IWorkflowAction PostPerformance([WorkflowExpression] Func<string> performanceType, [WorkflowExpression] Func<string> bodydateTime, [WorkflowExpression] Func<string> bodyuserId, [WorkflowExpression] Func<string> bodykpiName, [WorkflowExpression] Func<double> bodykpiValue, [WorkflowExpression] Func<string> bodyadditionalData = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPostPerformance(WorkflowExpression<string> performanceType, WorkflowExpression<string> bodydateTime, WorkflowExpression<string> bodyuserId, WorkflowExpression<string> bodykpiName, WorkflowExpression<double> bodykpiValue, WorkflowExpression<string> bodyadditionalData = null)
        {
            WorkflowExpression.Validate(performanceType, nameof(performanceType), required: true);
            WorkflowExpression.Validate(bodydateTime, nameof(bodydateTime), required: true);
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: true);
            WorkflowExpression.Validate(bodykpiName, nameof(bodykpiName), required: true);
            WorkflowExpression.Validate(bodykpiValue, nameof(bodykpiValue), required: true);
            WorkflowExpression.Validate(bodyadditionalData, nameof(bodyadditionalData), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/import/push/kpi_{0}", ExpressionConverter.ConvertWithUrlEncoding(performanceType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event_time"] = ExpressionConverter.ConvertO(bodydateTime);
                bodypropCount++;
                body["user_id"] = ExpressionConverter.ConvertO(bodyuserId);
                bodypropCount++;
                body["kpi_name"] = ExpressionConverter.ConvertO(bodykpiName);
                bodypropCount++;
                body["kpi_value"] = ExpressionConverter.ConvertO(bodykpiValue);
                if (bodyadditionalData != null)
                {
                    body["additional_data"] = ExpressionConverter.ConvertO(bodyadditionalData);
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