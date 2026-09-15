//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cascadestrategynew
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CascadestrategynewActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascadestrategynew")]
        public IBodyWorkflowAction<UpdateMeasure2Response> UpdateMeasure2(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyplanId, Expression<Func<double>> bodymeasureValue, Expression<Func<string>> measureId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/measures/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(measureId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["workspace_id"] = CSharpExpressionConverter.ConvertToken(bodyworkspaceId);
            bodypropCount++;
            body["plan_id"] = CSharpExpressionConverter.ConvertToken(bodyplanId);
            bodypropCount++;
            body["measure_value"] = CSharpExpressionConverter.ConvertToken(bodymeasureValue);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateMeasure2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascadestrategynew")]
        public IBodyWorkflowAction<UpdateMeasureHistoricalValue2Response> UpdateMeasureHistoricalValue2(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyplanId, Expression<Func<string>> measureId, Expression<Func<bodyhistoricalDataInputItem[]>> bodyhistoricalData = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/measures/historical/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(measureId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["workspace_id"] = CSharpExpressionConverter.ConvertToken(bodyworkspaceId);
            bodypropCount++;
            body["plan_id"] = CSharpExpressionConverter.ConvertToken(bodyplanId);
            if (bodyhistoricalData != null)
            {
                body["historical_data"] = CSharpExpressionConverter.ConvertToken(bodyhistoricalData);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateMeasureHistoricalValue2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascadestrategynew")]
        public IBodyWorkflowAction<UpdateAction2Response> UpdateAction2(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyplanId, Expression<Func<double>> bodyactionValue, Expression<Func<string>> actionId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/actions/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(actionId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["workspace_id"] = CSharpExpressionConverter.ConvertToken(bodyworkspaceId);
            bodypropCount++;
            body["plan_id"] = CSharpExpressionConverter.ConvertToken(bodyplanId);
            bodypropCount++;
            body["action_value"] = CSharpExpressionConverter.ConvertToken(bodyactionValue);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateAction2Response>(callPayload);
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

    public class UpdateMeasureHistoricalValue2Response
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class bodyhistoricalDataInputItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class UpdateAction2Response
    {
        [JsonProperty("message")]
        public string Message { get; set; }
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