//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Simpleedi
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SimpleediActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "simpleedi")]
        public IBodyWorkflowAction<JToken> EdiToJson([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            SourceExpression.Validate(bodyinputString, nameof(bodyinputString), required: true);
            SourceExpression.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: true);
            SourceExpression.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/EdiToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = SourceExpressionConverter.ConvertToken(bodyinputString);
                bodypropCount++;
                body["liquidTemplate"] = SourceExpressionConverter.ConvertToken(bodyliquidTemplate);
                if (bodylogFileName != null)
                {
                    body["logFileName"] = SourceExpressionConverter.ConvertToken(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "simpleedi")]
        public IBodyWorkflowAction<JToken> XmlToXml([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            SourceExpression.Validate(bodyinputString, nameof(bodyinputString), required: true);
            SourceExpression.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: true);
            SourceExpression.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/EdiToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = SourceExpressionConverter.ConvertToken(bodyinputString);
                bodypropCount++;
                body["liquidTemplate"] = SourceExpressionConverter.ConvertToken(bodyliquidTemplate);
                if (bodylogFileName != null)
                {
                    body["logFileName"] = SourceExpressionConverter.ConvertToken(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }
    }

    public class SimpleediTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Simpleedi;

    public partial class WorkflowManagedActions
    {
        public SimpleediActions Simpleedi(string connectionId) => new SimpleediActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SimpleediTriggers Simpleedi(string connectionId) => new SimpleediTriggers(connectionId);
    }
}