//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Experlogixcpq
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExperlogixcpqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationXmlResponse> GetConfigurationXml(Expression<Func<string>> type, Expression<Func<string>> id)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetConfigurationXmlResponse>(() =>
            {
                var apiCallPath = "/api/ConfigurationXml";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<GetConfigurationXmlResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationXmlResponse> CreateConfigurationFromCopy(Expression<Func<string>> reqtargetId, Expression<Func<string>> reqsourceId, Expression<Func<string>> reqtype, Expression<Func<int[]>> reqlineItemIds = null)
        {
            var __workflow_reqtargetId = WorkflowExpression.Compile(reqtargetId, nameof(reqtargetId), required: true);
            var __workflow_reqsourceId = WorkflowExpression.Compile(reqsourceId, nameof(reqsourceId), required: true);
            var __workflow_reqtype = WorkflowExpression.Compile(reqtype, nameof(reqtype), required: true);
            var __workflow_reqlineItemIds = WorkflowExpression.Compile(reqlineItemIds, nameof(reqlineItemIds), required: false);
            return new DeferredBodyAction<GetConfigurationXmlResponse>(() =>
            {
                var apiCallPath = "/api/CreateConfigurationFromCopy";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["targetId"] = ExpressionConverter.ConvertO(__workflow_reqtargetId);
                reqpropCount++;
                req["sourceId"] = ExpressionConverter.ConvertO(__workflow_reqsourceId);
                reqpropCount++;
                req["type"] = ExpressionConverter.ConvertO(__workflow_reqtype);
                if (__workflow_reqlineItemIds != null)
                {
                    req["lineItemIds"] = ExpressionConverter.ConvertO(__workflow_reqlineItemIds);
                    reqpropCount++;
                }

                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }

                return new ApiConnectionAction<GetConfigurationXmlResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationXmlResponse> UpdateConfiguration(Expression<Func<string>> reqid, Expression<Func<string>> reqtype, Expression<Func<string>> reqconfigurationXml)
        {
            var __workflow_reqid = WorkflowExpression.Compile(reqid, nameof(reqid), required: true);
            var __workflow_reqtype = WorkflowExpression.Compile(reqtype, nameof(reqtype), required: true);
            var __workflow_reqconfigurationXml = WorkflowExpression.Compile(reqconfigurationXml, nameof(reqconfigurationXml), required: true);
            return new DeferredBodyAction<GetConfigurationXmlResponse>(() =>
            {
                var apiCallPath = "/api/UpdateConfiguration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["id"] = ExpressionConverter.ConvertO(__workflow_reqid);
                reqpropCount++;
                req["type"] = ExpressionConverter.ConvertO(__workflow_reqtype);
                reqpropCount++;
                req["configurationXml"] = ExpressionConverter.ConvertO(__workflow_reqconfigurationXml);
                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }

                return new ApiConnectionAction<GetConfigurationXmlResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationXmlResponse> CreateConfiguration(Expression<Func<string>> reqid, Expression<Func<string>> reqtype, Expression<Func<string>> reqconfigurationXml)
        {
            var __workflow_reqid = WorkflowExpression.Compile(reqid, nameof(reqid), required: true);
            var __workflow_reqtype = WorkflowExpression.Compile(reqtype, nameof(reqtype), required: true);
            var __workflow_reqconfigurationXml = WorkflowExpression.Compile(reqconfigurationXml, nameof(reqconfigurationXml), required: true);
            return new DeferredBodyAction<GetConfigurationXmlResponse>(() =>
            {
                var apiCallPath = "/api/CreateConfiguration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["id"] = ExpressionConverter.ConvertO(__workflow_reqid);
                reqpropCount++;
                req["type"] = ExpressionConverter.ConvertO(__workflow_reqtype);
                reqpropCount++;
                req["configurationXml"] = ExpressionConverter.ConvertO(__workflow_reqconfigurationXml);
                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }

                return new ApiConnectionAction<GetConfigurationXmlResponse>(callPayload);
            });
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

namespace Microsoft.Azure.Workflows.Sdk
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
