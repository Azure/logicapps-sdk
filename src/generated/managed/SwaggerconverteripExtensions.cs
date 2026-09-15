//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Swaggerconverterip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SwaggerconverteripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "swaggerconverterip")]
        public IBodyWorkflowAction<JToken> ConvertByUrl(Expression<Func<string>> url)
        {
            var apiCallPath = "/convert";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["url"] = CSharpExpressionConverter.ConvertO(url);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "swaggerconverterip")]
        public IBodyWorkflowAction<JToken> ConvertByInput()
        {
            var apiCallPath = "/convert";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class SwaggerconverteripTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Swaggerconverterip;

    public partial class WorkflowManagedActions
    {
        public SwaggerconverteripActions Swaggerconverterip(string connectionId) => new SwaggerconverteripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SwaggerconverteripTriggers Swaggerconverterip(string connectionId) => new SwaggerconverteripTriggers(connectionId);
    }
}