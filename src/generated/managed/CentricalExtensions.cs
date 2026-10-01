//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Centrical
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CentricalActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "centrical")]
        public IWorkflowAction PostLearning([WorkflowExpression] Func<string> learningType, [WorkflowExpression] Func<string> bodydateTime, [WorkflowExpression] Func<string> bodyuserId, [WorkflowExpression] Func<string> bodycourseName, [WorkflowExpression] Func<double> bodyscore, [WorkflowExpression] Func<string> bodycontentCategory = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/import/push/lms_{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(learningType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event_time"] = SourceExpressionConverter.ConvertToken(bodydateTime);
                bodypropCount++;
                body["user_id"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                bodypropCount++;
                body["course_name"] = SourceExpressionConverter.ConvertToken(bodycourseName);
                bodypropCount++;
                body["score"] = SourceExpressionConverter.ConvertToken(bodyscore);
                if (bodycontentCategory != null)
                {
                    body["course_category"] = SourceExpressionConverter.ConvertToken(bodycontentCategory);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "centrical")]
        public IWorkflowAction PostPerformance([WorkflowExpression] Func<string> performanceType, [WorkflowExpression] Func<string> bodydateTime, [WorkflowExpression] Func<string> bodyuserId, [WorkflowExpression] Func<string> bodykpiName, [WorkflowExpression] Func<double> bodykpiValue, [WorkflowExpression] Func<string> bodyadditionalData = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/import/push/kpi_{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(performanceType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event_time"] = SourceExpressionConverter.ConvertToken(bodydateTime);
                bodypropCount++;
                body["user_id"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                bodypropCount++;
                body["kpi_name"] = SourceExpressionConverter.ConvertToken(bodykpiName);
                bodypropCount++;
                body["kpi_value"] = SourceExpressionConverter.ConvertToken(bodykpiValue);
                if (bodyadditionalData != null)
                {
                    body["additional_data"] = SourceExpressionConverter.ConvertToken(bodyadditionalData);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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