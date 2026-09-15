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
        public IWorkflowAction PostLearning(Expression<Func<string>> learningType, Expression<Func<string>> bodydateTime, Expression<Func<string>> bodyuserId, Expression<Func<string>> bodycourseName, Expression<Func<double>> bodyscore, Expression<Func<string>> bodycontentCategory = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/import/push/lms_{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(learningType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["event_time"] = CSharpExpressionConverter.ConvertToken(bodydateTime);
            bodypropCount++;
            body["user_id"] = CSharpExpressionConverter.ConvertToken(bodyuserId);
            bodypropCount++;
            body["course_name"] = CSharpExpressionConverter.ConvertToken(bodycourseName);
            bodypropCount++;
            body["score"] = CSharpExpressionConverter.ConvertToken(bodyscore);
            if (bodycontentCategory != null)
            {
                body["course_category"] = CSharpExpressionConverter.ConvertToken(bodycontentCategory);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "centrical")]
        public IWorkflowAction PostPerformance(Expression<Func<string>> performanceType, Expression<Func<string>> bodydateTime, Expression<Func<string>> bodyuserId, Expression<Func<string>> bodykpiName, Expression<Func<double>> bodykpiValue, Expression<Func<string>> bodyadditionalData = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/import/push/kpi_{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(performanceType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["event_time"] = CSharpExpressionConverter.ConvertToken(bodydateTime);
            bodypropCount++;
            body["user_id"] = CSharpExpressionConverter.ConvertToken(bodyuserId);
            bodypropCount++;
            body["kpi_name"] = CSharpExpressionConverter.ConvertToken(bodykpiName);
            bodypropCount++;
            body["kpi_value"] = CSharpExpressionConverter.ConvertToken(bodykpiValue);
            if (bodyadditionalData != null)
            {
                body["additional_data"] = CSharpExpressionConverter.ConvertToken(bodyadditionalData);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
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