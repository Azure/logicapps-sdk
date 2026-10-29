//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Simpleedi
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SimpleediActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "simpleedi")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> EdiToJson(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate = null, Expression<Func<string>> bodylogFileName = null)
        {
            var __workflow_bodyinputString = WorkflowExpression.Compile(bodyinputString, nameof(bodyinputString), required: true);
            var __workflow_bodyliquidTemplate = WorkflowExpression.Compile(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            var __workflow_bodylogFileName = WorkflowExpression.Compile(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/EdiToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(__workflow_bodyinputString);
                if (__workflow_bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = ExpressionConverter.ConvertO(__workflow_bodyliquidTemplate);
                    bodypropCount++;
                }

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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> XmlToXml(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate = null, Expression<Func<string>> bodylogFileName = null)
        {
            var __workflow_bodyinputString = WorkflowExpression.Compile(bodyinputString, nameof(bodyinputString), required: true);
            var __workflow_bodyliquidTemplate = WorkflowExpression.Compile(bodyliquidTemplate, nameof(bodyliquidTemplate), required: false);
            var __workflow_bodylogFileName = WorkflowExpression.Compile(bodylogFileName, nameof(bodylogFileName), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/EdiToXml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inputString"] = ExpressionConverter.ConvertO(__workflow_bodyinputString);
                if (__workflow_bodyliquidTemplate != null)
                {
                    body["liquidTemplate"] = ExpressionConverter.ConvertO(__workflow_bodyliquidTemplate);
                    bodypropCount++;
                }

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