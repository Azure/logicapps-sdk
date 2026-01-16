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
            var apiCallPath = String.Format("/import/push/lms_{0}", ExpressionConverter.ConvertWithUrlEncoding(learningType, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "centrical")]
        public IWorkflowAction PostPerformance(Expression<Func<string>> performanceType, Expression<Func<string>> bodydateTime, Expression<Func<string>> bodyuserId, Expression<Func<string>> bodykpiName, Expression<Func<double>> bodykpiValue, Expression<Func<string>> bodyadditionalData = null)
        {
            var apiCallPath = String.Format("/import/push/kpi_{0}", ExpressionConverter.ConvertWithUrlEncoding(performanceType, 1));
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
        }
    }

    public class CentricalTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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