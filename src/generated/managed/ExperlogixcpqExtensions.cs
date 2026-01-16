//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Experlogixcpq
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExperlogixcpqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationXmlResponse> GetConfigurationXml(Expression<Func<string>> type, Expression<Func<string>> id)
        {
            var apiCallPath = "/api/ConfigurationXml";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<GetConfigurationXmlResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationXmlResponse> CreateConfigurationFromCopy(Expression<Func<string>> reqtargetId, Expression<Func<string>> reqsourceId, Expression<Func<string>> reqtype, Expression<Func<int[]>> reqlineItemIds = null)
        {
            var apiCallPath = "/api/CreateConfigurationFromCopy";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var req = new JObject();
            var reqpropCount = 0;
            reqpropCount++;
            req["targetId"] = ExpressionConverter.ConvertO(reqtargetId);
            reqpropCount++;
            req["sourceId"] = ExpressionConverter.ConvertO(reqsourceId);
            reqpropCount++;
            req["type"] = ExpressionConverter.ConvertO(reqtype);
            if (reqlineItemIds != null)
            {
                req["lineItemIds"] = ExpressionConverter.ConvertO(reqlineItemIds);
                reqpropCount++;
            }

            if (reqpropCount > 0)
            {
                callPayload.Body = req;
            }

            return new ApiConnectionAction<GetConfigurationXmlResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationXmlResponse> UpdateConfiguration(Expression<Func<string>> reqid, Expression<Func<string>> reqtype, Expression<Func<string>> reqconfigurationXml)
        {
            var apiCallPath = "/api/UpdateConfiguration";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var req = new JObject();
            var reqpropCount = 0;
            reqpropCount++;
            req["id"] = ExpressionConverter.ConvertO(reqid);
            reqpropCount++;
            req["type"] = ExpressionConverter.ConvertO(reqtype);
            reqpropCount++;
            req["configurationXml"] = ExpressionConverter.ConvertO(reqconfigurationXml);
            if (reqpropCount > 0)
            {
                callPayload.Body = req;
            }

            return new ApiConnectionAction<GetConfigurationXmlResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationXmlResponse> CreateConfiguration(Expression<Func<string>> reqid, Expression<Func<string>> reqtype, Expression<Func<string>> reqconfigurationXml)
        {
            var apiCallPath = "/api/CreateConfiguration";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var req = new JObject();
            var reqpropCount = 0;
            reqpropCount++;
            req["id"] = ExpressionConverter.ConvertO(reqid);
            reqpropCount++;
            req["type"] = ExpressionConverter.ConvertO(reqtype);
            reqpropCount++;
            req["configurationXml"] = ExpressionConverter.ConvertO(reqconfigurationXml);
            if (reqpropCount > 0)
            {
                callPayload.Body = req;
            }

            return new ApiConnectionAction<GetConfigurationXmlResponse>(callPayload);
        }
    }

    public class ExperlogixcpqTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetConfigurationXmlResponse
    {
        [JsonProperty("configurationXml")]
        public string ConfigurationXml { get; set; }

        [JsonProperty("configureUrl")]
        public string ConfigureUrl { get; set; }

        [JsonProperty("lineItemIds")]
        public int[] LineItemIds { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("messages")]
        public string[] Messages { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Experlogixcpq;

    public partial class WorkflowManagedActions
    {
        public ExperlogixcpqActions Experlogixcpq(string connectionId) => new ExperlogixcpqActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ExperlogixcpqTriggers Experlogixcpq(string connectionId) => new ExperlogixcpqTriggers(connectionId);
    }
}