//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iconhorseip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IconhorseipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iconhorseip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> FaviconGet(Expression<Func<string>> domain)
        {
            var __workflow_domain = WorkflowExpression.Compile(domain, nameof(domain), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/icon/{0}", __workflow_domain.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class IconhorseipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Iconhorseip;

    public partial class WorkflowManagedActions
    {
        public IconhorseipActions Iconhorseip(string connectionId) => new IconhorseipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IconhorseipTriggers Iconhorseip(string connectionId) => new IconhorseipTriggers(connectionId);
    }
}
