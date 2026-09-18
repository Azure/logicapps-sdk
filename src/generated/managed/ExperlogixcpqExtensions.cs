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
        public IBodyWorkflowAction<GetConfigurationXmlResponse> GetConfigurationXml([WorkflowExpression] Func<string> type, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(type, nameof(type), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ConfigurationXml";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<GetConfigurationXmlResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationXmlResponse> CreateConfigurationFromCopy([WorkflowExpression] Func<string> reqtargetId, [WorkflowExpression] Func<string> reqsourceId, [WorkflowExpression] Func<string> reqtype, [WorkflowExpression] Func<int[]> reqlineItemIds = null)
        {
            SourceExpression.Validate(reqtargetId, nameof(reqtargetId), required: true);
            SourceExpression.Validate(reqsourceId, nameof(reqsourceId), required: true);
            SourceExpression.Validate(reqtype, nameof(reqtype), required: true);
            SourceExpression.Validate(reqlineItemIds, nameof(reqlineItemIds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/CreateConfigurationFromCopy";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["targetId"] = SourceExpressionConverter.ConvertToken(reqtargetId);
                reqpropCount++;
                req["sourceId"] = SourceExpressionConverter.ConvertToken(reqsourceId);
                reqpropCount++;
                req["type"] = SourceExpressionConverter.ConvertToken(reqtype);
                if (reqlineItemIds != null)
                {
                    req["lineItemIds"] = SourceExpressionConverter.ConvertToken(reqlineItemIds);
                    reqpropCount++;
                }

                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetConfigurationXmlResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationXmlResponse> UpdateConfiguration([WorkflowExpression] Func<string> reqid, [WorkflowExpression] Func<string> reqtype, [WorkflowExpression] Func<string> reqconfigurationXml)
        {
            SourceExpression.Validate(reqid, nameof(reqid), required: true);
            SourceExpression.Validate(reqtype, nameof(reqtype), required: true);
            SourceExpression.Validate(reqconfigurationXml, nameof(reqconfigurationXml), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/UpdateConfiguration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["id"] = SourceExpressionConverter.ConvertToken(reqid);
                reqpropCount++;
                req["type"] = SourceExpressionConverter.ConvertToken(reqtype);
                reqpropCount++;
                req["configurationXml"] = SourceExpressionConverter.ConvertToken(reqconfigurationXml);
                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetConfigurationXmlResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "experlogixcpq")]
        public IBodyWorkflowAction<GetConfigurationXmlResponse> CreateConfiguration([WorkflowExpression] Func<string> reqid, [WorkflowExpression] Func<string> reqtype, [WorkflowExpression] Func<string> reqconfigurationXml)
        {
            SourceExpression.Validate(reqid, nameof(reqid), required: true);
            SourceExpression.Validate(reqtype, nameof(reqtype), required: true);
            SourceExpression.Validate(reqconfigurationXml, nameof(reqconfigurationXml), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/CreateConfiguration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var req = new JObject();
                var reqpropCount = 0;
                reqpropCount++;
                req["id"] = SourceExpressionConverter.ConvertToken(reqid);
                reqpropCount++;
                req["type"] = SourceExpressionConverter.ConvertToken(reqtype);
                reqpropCount++;
                req["configurationXml"] = SourceExpressionConverter.ConvertToken(reqconfigurationXml);
                if (reqpropCount > 0)
                {
                    callPayload.Body = req;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetConfigurationXmlResponse>(BuildSourceInput);
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