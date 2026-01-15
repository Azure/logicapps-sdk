//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Simpleedi
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SimpleediActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "simpleedi")]
        public IBodyWorkflowAction<JToken> EdiToJson(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate, Expression<Func<string>> bodylogFileName = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "simpleedi")]
        public IBodyWorkflowAction<JToken> XmlToXml(Expression<Func<string>> bodyinputString, Expression<Func<string>> bodyliquidTemplate, Expression<Func<string>> bodylogFileName = null)
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
        }
    }

    public class SimpleediTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Simpleedi;

    public partial class WorkflowManagedActions
    {
        public SimpleediActions Simpleedi(string connectionId) => new SimpleediActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SimpleediTriggers Simpleedi(string connectionId) => new SimpleediTriggers(connectionId);
    }
}