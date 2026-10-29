//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ronswansonquotesip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RonswansonquotesipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ronswansonquotesip")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> QuoteGet()
        {
            return new DeferredBodyAction<string[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/quotes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ronswansonquotesip")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> Quotes(Expression<Func<int>> count)
        {
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: true);
            return new DeferredBodyAction<string[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/quotes/{0}", __workflow_count.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ronswansonquotesip")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> Search(Expression<Func<string>> term)
        {
            var __workflow_term = WorkflowExpression.Compile(term, nameof(term), required: true);
            return new DeferredBodyAction<string[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/quotes/search/{0}", __workflow_term.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string[]>(callPayload);
            });
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