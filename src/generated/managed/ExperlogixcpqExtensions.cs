//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Experlogixcpq
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ExperlogixcpqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationXmlResponse> GetConfigurationXml(Expression<Func<string>> type, Expression<Func<string>> id)
        {
            var __workflow_type = type == null ? null : WorkflowExpression.Compile(type);
            WorkflowExpression.Validate(__workflow_type, nameof(type), required: true);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
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
            var __workflow_reqtargetId = reqtargetId == null ? null : WorkflowExpression.Compile(reqtargetId);
            WorkflowExpression.Validate(__workflow_reqtargetId, nameof(reqtargetId), required: true);
            var __workflow_reqsourceId = reqsourceId == null ? null : WorkflowExpression.Compile(reqsourceId);
            WorkflowExpression.Validate(__workflow_reqsourceId, nameof(reqsourceId), required: true);
            var __workflow_reqtype = reqtype == null ? null : WorkflowExpression.Compile(reqtype);
            WorkflowExpression.Validate(__workflow_reqtype, nameof(reqtype), required: true);
            var __workflow_reqlineItemIds = reqlineItemIds == null ? null : WorkflowExpression.Compile(reqlineItemIds);
            WorkflowExpression.Validate(__workflow_reqlineItemIds, nameof(reqlineItemIds), required: false);
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
            var __workflow_reqid = reqid == null ? null : WorkflowExpression.Compile(reqid);
            WorkflowExpression.Validate(__workflow_reqid, nameof(reqid), required: true);
            var __workflow_reqtype = reqtype == null ? null : WorkflowExpression.Compile(reqtype);
            WorkflowExpression.Validate(__workflow_reqtype, nameof(reqtype), required: true);
            var __workflow_reqconfigurationXml = reqconfigurationXml == null ? null : WorkflowExpression.Compile(reqconfigurationXml);
            WorkflowExpression.Validate(__workflow_reqconfigurationXml, nameof(reqconfigurationXml), required: true);
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
            var __workflow_reqid = reqid == null ? null : WorkflowExpression.Compile(reqid);
            WorkflowExpression.Validate(__workflow_reqid, nameof(reqid), required: true);
            var __workflow_reqtype = reqtype == null ? null : WorkflowExpression.Compile(reqtype);
            WorkflowExpression.Validate(__workflow_reqtype, nameof(reqtype), required: true);
            var __workflow_reqconfigurationXml = reqconfigurationXml == null ? null : WorkflowExpression.Compile(reqconfigurationXml);
            WorkflowExpression.Validate(__workflow_reqconfigurationXml, nameof(reqconfigurationXml), required: true);
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
