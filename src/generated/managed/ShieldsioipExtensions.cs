//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shieldsioip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ShieldsioipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shieldsioip")]
        public IBodyWorkflowAction<JToken> BadgeCreate(Expression<Func<string>> label = null, Expression<Func<string>> labelColor = null, Expression<Func<string>> message = null, Expression<Func<string>> color = null, Expression<Func<string>> style = null, Expression<Func<string>> logo = null, Expression<Func<string>> logoColor = null, Expression<Func<int>> logoWidth = null, Expression<Func<string>> link = null, Expression<Func<int>> cacheSeconds = null)
        {
            var apiCallPath = "/static/v1";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (label != null)
                callPayload.Queries["label"] = CSharpExpressionConverter.ConvertO(label);
            if (labelColor != null)
                callPayload.Queries["labelColor"] = CSharpExpressionConverter.ConvertO(labelColor);
            if (message != null)
                callPayload.Queries["message"] = CSharpExpressionConverter.ConvertO(message);
            if (color != null)
                callPayload.Queries["color"] = CSharpExpressionConverter.ConvertO(color);
            if (style != null)
                callPayload.Queries["style"] = CSharpExpressionConverter.ConvertO(style);
            if (logo != null)
                callPayload.Queries["logo"] = CSharpExpressionConverter.ConvertO(logo);
            if (logoColor != null)
                callPayload.Queries["logoColor"] = CSharpExpressionConverter.ConvertO(logoColor);
            if (logoWidth != null)
                callPayload.Queries["logoWidth"] = CSharpExpressionConverter.ConvertO(logoWidth);
            if (link != null)
                callPayload.Queries["link"] = CSharpExpressionConverter.ConvertO(link);
            callPayload.Queries["cacheSeconds"] = Convert.ToString(3600);
            if (cacheSeconds != null)
                callPayload.Queries["cacheSeconds"] = CSharpExpressionConverter.ConvertO(cacheSeconds);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shieldsioip")]
        public IBodyWorkflowAction<JToken> BadgeGet(Expression<Func<string>> parameters)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(parameters, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class ShieldsioipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Shieldsioip;

    public partial class WorkflowManagedActions
    {
        public ShieldsioipActions Shieldsioip(string connectionId) => new ShieldsioipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ShieldsioipTriggers Shieldsioip(string connectionId) => new ShieldsioipTriggers(connectionId);
    }
}