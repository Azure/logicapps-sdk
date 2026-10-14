//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Simpleedi
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class SimpleediActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "simpleedi")]
        public IBodyWorkflowAction<JToken> EdiToJson(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate, Expression<Func<string>> bodylogFileName = null)
        {
            var __workflow_bodyinputString = bodyinputString == null ? null : WorkflowExpression.Compile(bodyinputString);
            WorkflowExpression.Validate(__workflow_bodyinputString, nameof(bodyinputString), required: true);
            var __workflow_bodyliquidTemplate = bodyliquidTemplate == null ? null : WorkflowExpression.Compile(bodyliquidTemplate);
            WorkflowExpression.Validate(__workflow_bodyliquidTemplate, nameof(bodyliquidTemplate), required: true);
            var __workflow_bodylogFileName = bodylogFileName == null ? null : WorkflowExpression.Compile(bodylogFileName);
            WorkflowExpression.Validate(__workflow_bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/EdiToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(__workflow_bodyinputString);
                bodypropCount++;
                body["liquidTemplate"] = ExpressionConverter.ConvertO(__workflow_bodyliquidTemplate);
                if (__workflow_bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(__workflow_bodylogFileName);
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
        public IBodyWorkflowAction<JToken> XmlToXml(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate, Expression<Func<string>> bodylogFileName = null)
        {
            var __workflow_bodyinputString = bodyinputString == null ? null : WorkflowExpression.Compile(bodyinputString);
            WorkflowExpression.Validate(__workflow_bodyinputString, nameof(bodyinputString), required: true);
            var __workflow_bodyliquidTemplate = bodyliquidTemplate == null ? null : WorkflowExpression.Compile(bodyliquidTemplate);
            WorkflowExpression.Validate(__workflow_bodyliquidTemplate, nameof(bodyliquidTemplate), required: true);
            var __workflow_bodylogFileName = bodylogFileName == null ? null : WorkflowExpression.Compile(bodylogFileName);
            WorkflowExpression.Validate(__workflow_bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/api/EdiToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(__workflow_bodyinputString);
                bodypropCount++;
                body["liquidTemplate"] = ExpressionConverter.ConvertO(__workflow_bodyliquidTemplate);
                if (__workflow_bodylogFileName != null)
                {
                    body["logFileName"] = ExpressionConverter.ConvertO(__workflow_bodylogFileName);
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
