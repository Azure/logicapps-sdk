//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ronswansonquotesip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RonswansonquotesipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ronswansonquotesip")]
        public IBodyWorkflowAction<string[]> QuoteGet()
        {
            var apiCallPath = "/quotes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ronswansonquotesip")]
        public IBodyWorkflowAction<string[]> Quotes(Expression<Func<int>> count)
        {
            var apiCallPath = String.Format("/quotes/{0}", ExpressionConverter.ConvertWithUrlEncoding(count, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ronswansonquotesip")]
        public IBodyWorkflowAction<string[]> Search(Expression<Func<string>> term)
        {
            var apiCallPath = String.Format("/quotes/search/{0}", ExpressionConverter.ConvertWithUrlEncoding(term, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string[]>(callPayload);
        }
    }

    public class RonswansonquotesipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ronswansonquotesip;

    public partial class WorkflowManagedActions
    {
        public RonswansonquotesipActions Ronswansonquotesip(string connectionId) => new RonswansonquotesipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RonswansonquotesipTriggers Ronswansonquotesip(string connectionId) => new RonswansonquotesipTriggers(connectionId);
    }
}