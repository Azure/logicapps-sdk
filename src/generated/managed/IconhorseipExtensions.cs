//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iconhorseip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IconhorseipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iconhorseip")]
        [WorkflowExpressionFactory(nameof(__BuildFaviconGet))]
        public IBodyWorkflowAction<JToken> FaviconGet([WorkflowExpression] Func<string> domain)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildFaviconGet(WorkflowValue<string> domain)
        {
            WorkflowValue.Validate(domain, nameof(domain), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/icon/{0}", ExpressionConverter.ConvertWithUrlEncoding(domain, 1));
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
