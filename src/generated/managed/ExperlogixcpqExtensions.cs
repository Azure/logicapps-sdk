//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Experlogixcpq
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExperlogixcpqActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        [WorkflowExpressionFactory(nameof(__BuildGetConfigurationXml))]
        public IBodyWorkflowAction<GetConfigurationXmlResponse> GetConfigurationXml([WorkflowExpression] Func<string> type, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetConfigurationXmlResponse> __BuildGetConfigurationXml(WorkflowExpression<string> type, WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(type, nameof(type), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GetConfigurationXmlResponse>(() =>
            {
                var apiCallPath = "/api/ConfigurationXml";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<GetConfigurationXmlResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        [WorkflowExpressionFactory(nameof(__BuildCreateConfigurationFromCopy))]
        public IBodyWorkflowAction<GetConfigurationXmlResponse> CreateConfigurationFromCopy([WorkflowExpression] Func<string> reqtargetId, [WorkflowExpression] Func<string> reqsourceId, [WorkflowExpression] Func<string> reqtype, [WorkflowExpression] Func<int[]> reqlineItemIds = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetConfigurationXmlResponse> __BuildCreateConfigurationFromCopy(WorkflowExpression<string> reqtargetId, WorkflowExpression<string> reqsourceId, WorkflowExpression<string> reqtype, WorkflowExpression<int[]> reqlineItemIds = null)
        {
            WorkflowExpression.Validate(reqtargetId, nameof(reqtargetId), required: true);
            WorkflowExpression.Validate(reqsourceId, nameof(reqsourceId), required: true);
            WorkflowExpression.Validate(reqtype, nameof(reqtype), required: true);
            WorkflowExpression.Validate(reqlineItemIds, nameof(reqlineItemIds), required: false);
            return new DeferredBodyAction<GetConfigurationXmlResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateConfiguration))]
        public IBodyWorkflowAction<GetConfigurationXmlResponse> UpdateConfiguration([WorkflowExpression] Func<string> reqid, [WorkflowExpression] Func<string> reqtype, [WorkflowExpression] Func<string> reqconfigurationXml)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetConfigurationXmlResponse> __BuildUpdateConfiguration(WorkflowExpression<string> reqid, WorkflowExpression<string> reqtype, WorkflowExpression<string> reqconfigurationXml)
        {
            WorkflowExpression.Validate(reqid, nameof(reqid), required: true);
            WorkflowExpression.Validate(reqtype, nameof(reqtype), required: true);
            WorkflowExpression.Validate(reqconfigurationXml, nameof(reqconfigurationXml), required: true);
            return new DeferredBodyAction<GetConfigurationXmlResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        [WorkflowExpressionFactory(nameof(__BuildCreateConfiguration))]
        public IBodyWorkflowAction<GetConfigurationXmlResponse> CreateConfiguration([WorkflowExpression] Func<string> reqid, [WorkflowExpression] Func<string> reqtype, [WorkflowExpression] Func<string> reqconfigurationXml)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetConfigurationXmlResponse> __BuildCreateConfiguration(WorkflowExpression<string> reqid, WorkflowExpression<string> reqtype, WorkflowExpression<string> reqconfigurationXml)
        {
            WorkflowExpression.Validate(reqid, nameof(reqid), required: true);
            WorkflowExpression.Validate(reqtype, nameof(reqtype), required: true);
            WorkflowExpression.Validate(reqconfigurationXml, nameof(reqconfigurationXml), required: true);
            return new DeferredBodyAction<GetConfigurationXmlResponse>(() =>
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