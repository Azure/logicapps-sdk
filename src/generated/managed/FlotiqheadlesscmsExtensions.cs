//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Flotiqheadlesscms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FlotiqheadlesscmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "flotiqheadlesscms")]
        public IWorkflowAction CreateContentObject(Expression<Func<string>> contentTypeId, Expression<Func<object>> body = null)
        {
            var apiCallPath = String.Format("/api/v1/content/{0}", ExpressionConverter.ConvertWithUrlEncoding(contentTypeId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class FlotiqheadlesscmsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Flotiqheadlesscms;

    public partial class WorkflowManagedActions
    {
        public FlotiqheadlesscmsActions Flotiqheadlesscms(string connectionId) => new FlotiqheadlesscmsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FlotiqheadlesscmsTriggers Flotiqheadlesscms(string connectionId) => new FlotiqheadlesscmsTriggers(connectionId);
    }
}