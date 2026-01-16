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
            var apiCallPath = String.Format("/v2/measures/{0}", ExpressionConverter.ConvertWithUrlEncoding(measureId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["workspace_id"] = ExpressionConverter.ConvertO(bodyworkspaceId);
            bodypropCount++;
            body["plan_id"] = ExpressionConverter.ConvertO(bodyplanId);
            bodypropCount++;
            body["measure_value"] = ExpressionConverter.ConvertO(bodymeasureValue);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateMeasure2Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cascadestrategynew")]
        public IBodyWorkflowAction<UpdateMeasureHistoricalValue2Response> UpdateMeasureHistoricalValue2(Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodyplanId, Expression<Func<string>> measureId, Expression<Func<bodyhistoricalDataInputItem[]>> bodyhistoricalData = null)
        {
            var apiCallPath = String.Format("/v2/measures/historical/{0}", ExpressionConverter.ConvertWithUrlEncoding(measureId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["workspace_id"] = ExpressionConverter.ConvertO(bodyworkspaceId);
            bodypropCount++;
            body["plan_id"] = ExpressionConverter.ConvertO(bodyplanId);
            if (bodyhistoricalData != null)
            {
                body["historical_data"] = ExpressionConverter.ConvertO(bodyhistoricalData);
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
            var apiCallPath = String.Format("/v2/actions/{0}", ExpressionConverter.ConvertWithUrlEncoding(actionId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["workspace_id"] = ExpressionConverter.ConvertO(bodyworkspaceId);
            bodypropCount++;
            body["plan_id"] = ExpressionConverter.ConvertO(bodyplanId);
            bodypropCount++;
            body["action_value"] = ExpressionConverter.ConvertO(bodyactionValue);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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