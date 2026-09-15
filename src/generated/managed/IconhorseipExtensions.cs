//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iconhorseip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IconhorseipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iconhorseip")]
        public IBodyWorkflowAction<JToken> FaviconGet(Expression<Func<string>> domain)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/icon/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(domain, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
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