//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Simpleedi
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SimpleediActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "simpleedi")]
        [WorkflowExpressionFactory(nameof(__BuildEdiToJson))]
        public IBodyWorkflowAction<JToken> EdiToJson([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "simpleedi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildEdiToJson(WorkflowExpression<string> bodyinputString, WorkflowExpression<string> bodyliquidTemplate, WorkflowExpression<string> bodylogFileName = null)
        {
            WorkflowExpression.Validate(bodyinputString, nameof(bodyinputString), required: true);
            WorkflowExpression.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: true);
            WorkflowExpression.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/EdiToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(bodyinputString);
                bodypropCount++;
                body["liquidTemplate"] = ExpressionConverter.ConvertO(bodyliquidTemplate);
                if (bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "simpleedi")]
        [WorkflowExpressionFactory(nameof(__BuildXmlToXml))]
        public IBodyWorkflowAction<JToken> XmlToXml([WorkflowExpression] Func<string> bodyinputString, [WorkflowExpression] Func<string> bodyliquidTemplate, [WorkflowExpression] Func<string> bodylogFileName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "simpleedi")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildXmlToXml(WorkflowExpression<string> bodyinputString, WorkflowExpression<string> bodyliquidTemplate, WorkflowExpression<string> bodylogFileName = null)
        {
            WorkflowExpression.Validate(bodyinputString, nameof(bodyinputString), required: true);
            WorkflowExpression.Validate(bodyliquidTemplate, nameof(bodyliquidTemplate), required: true);
            WorkflowExpression.Validate(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/EdiToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(bodyinputString);
                bodypropCount++;
                body["liquidTemplate"] = ExpressionConverter.ConvertO(bodyliquidTemplate);
                if (bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(bodylogFileName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
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