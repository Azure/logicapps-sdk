//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Shieldsioip
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
                callPayload.Queries["label"] = ExpressionConverter.Convert(label);
            if (labelColor != null)
                callPayload.Queries["labelColor"] = ExpressionConverter.Convert(labelColor);
            if (message != null)
                callPayload.Queries["message"] = ExpressionConverter.Convert(message);
            if (color != null)
                callPayload.Queries["color"] = ExpressionConverter.Convert(color);
            if (style != null)
                callPayload.Queries["style"] = ExpressionConverter.Convert(style);
            if (logo != null)
                callPayload.Queries["logo"] = ExpressionConverter.Convert(logo);
            if (logoColor != null)
                callPayload.Queries["logoColor"] = ExpressionConverter.Convert(logoColor);
            if (logoWidth != null)
                callPayload.Queries["logoWidth"] = ExpressionConverter.Convert(logoWidth);
            if (link != null)
                callPayload.Queries["link"] = ExpressionConverter.Convert(link);
            callPayload.Queries["cacheSeconds"] = Convert.ToString(3600);
            if (cacheSeconds != null)
                callPayload.Queries["cacheSeconds"] = ExpressionConverter.Convert(cacheSeconds);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shieldsioip")]
        public IBodyWorkflowAction<JToken> BadgeGet(Expression<Func<string>> parameters)
        {
            var apiCallPath = String.Format("/{0}", ExpressionConverter.ConvertWithUrlEncoding(parameters, 1));
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
    using Microsoft.Azure.Workflows.Sdk.Shieldsioip;

    public partial class WorkflowManagedActions
    {
        public ShieldsioipActions Shieldsioip(string connectionId) => new ShieldsioipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ShieldsioipTriggers Shieldsioip(string connectionId) => new ShieldsioipTriggers(connectionId);
    }
}