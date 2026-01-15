//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Wpformsbyreenhancedl
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WpformsbyreenhancedlActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpformsbyreenhancedl")]
        public IBodyWorkflowAction<GetEntriesResponseItem[]> GetEntries(Expression<Func<string>> formId, Expression<Func<object>> body = null)
        {
            var apiCallPath = "/resources/entries/query";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["form_id"] = ExpressionConverter.Convert(formId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<GetEntriesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpformsbyreenhancedl")]
        public IBodyWorkflowAction<JToken> GetEntry(Expression<Func<string>> id, Expression<Func<string>> formId)
        {
            var apiCallPath = String.Format("/resources/entries/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["form_id"] = ExpressionConverter.Convert(formId);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class WpformsbyreenhancedlTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetEntriesResponseItem
    {
        [JsonProperty("fields")]
        public JToken Fields { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Wpformsbyreenhancedl;

    public partial class WorkflowManagedActions
    {
        public WpformsbyreenhancedlActions Wpformsbyreenhancedl(string connectionId) => new WpformsbyreenhancedlActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WpformsbyreenhancedlTriggers Wpformsbyreenhancedl(string connectionId) => new WpformsbyreenhancedlTriggers(connectionId);
    }
}