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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPostLearning(WorkflowValue<string> learningType, WorkflowValue<string> bodydateTime, WorkflowValue<string> bodyuserId, WorkflowValue<string> bodycourseName, WorkflowValue<double> bodyscore, WorkflowValue<string> bodycontentCategory = null)
        {
            WorkflowValue.Validate(learningType, nameof(learningType), required: true);
            WorkflowValue.Validate(bodydateTime, nameof(bodydateTime), required: true);
            WorkflowValue.Validate(bodyuserId, nameof(bodyuserId), required: true);
            WorkflowValue.Validate(bodycourseName, nameof(bodycourseName), required: true);
            WorkflowValue.Validate(bodyscore, nameof(bodyscore), required: true);
            WorkflowValue.Validate(bodycontentCategory, nameof(bodycontentCategory), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPostPerformance(WorkflowValue<string> performanceType, WorkflowValue<string> bodydateTime, WorkflowValue<string> bodyuserId, WorkflowValue<string> bodykpiName, WorkflowValue<double> bodykpiValue, WorkflowValue<string> bodyadditionalData = null)
        {
            WorkflowValue.Validate(performanceType, nameof(performanceType), required: true);
            WorkflowValue.Validate(bodydateTime, nameof(bodydateTime), required: true);
            WorkflowValue.Validate(bodyuserId, nameof(bodyuserId), required: true);
            WorkflowValue.Validate(bodykpiName, nameof(bodykpiName), required: true);
            WorkflowValue.Validate(bodykpiValue, nameof(bodykpiValue), required: true);
            WorkflowValue.Validate(bodyadditionalData, nameof(bodyadditionalData), required: false);
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
