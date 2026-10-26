//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Vitacloudquotes
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VitacloudquotesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwAuthor[], ApiConnectionActionConfiguration> GetAuthors()
        {
            return new DeferredBodyAction<VwAuthor[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Authors";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VwAuthor[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwAuthor, ApiConnectionActionConfiguration> GetAuthor(Expression<Func<string>> authortag)
        {
            var __workflow_authortag = WorkflowExpression.Compile(authortag, nameof(authortag), required: true);
            return new DeferredBodyAction<VwAuthor, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Authors/{0}", __workflow_authortag.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VwAuthor>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwQuote, ApiConnectionActionConfiguration> GetTodaysQuote()
        {
            return new DeferredBodyAction<VwQuote, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Quotes/Today";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VwQuote>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwQuote, ApiConnectionActionConfiguration> GetRandomQuote()
        {
            return new DeferredBodyAction<VwQuote, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Quotes/Random";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VwQuote>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwQuote[], ApiConnectionActionConfiguration> GetRandomQuotes()
        {
            return new DeferredBodyAction<VwQuote[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Quotes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VwQuote[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwQuote[], ApiConnectionActionConfiguration> GetRandomQuotesByNum(Expression<Func<int>> number)
        {
            var __workflow_number = WorkflowExpression.Compile(number, nameof(number), required: true);
            return new DeferredBodyAction<VwQuote[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Quotes/{0}", __workflow_number.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VwQuote[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwQuote[], ApiConnectionActionConfiguration> GetRandomQuotesByAuthor(Expression<Func<string>> authortag)
        {
            var __workflow_authortag = WorkflowExpression.Compile(authortag, nameof(authortag), required: true);
            return new DeferredBodyAction<VwQuote[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Quotes/Author/{0}", __workflow_authortag.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VwQuote[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwQuote[], ApiConnectionActionConfiguration> GetRandomQuotesByAuthorAndNum(Expression<Func<string>> authortag, Expression<Func<int>> number)
        {
            var __workflow_authortag = WorkflowExpression.Compile(authortag, nameof(authortag), required: true);
            var __workflow_number = WorkflowExpression.Compile(number, nameof(number), required: true);
            return new DeferredBodyAction<VwQuote[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Quotes/Author/{0}/{1}", __workflow_authortag.WithUrlEncoding(1), __workflow_number.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VwQuote[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwQuote[], ApiConnectionActionConfiguration> GetRandomQuotesByTheme(Expression<Func<string>> themetag)
        {
            var __workflow_themetag = WorkflowExpression.Compile(themetag, nameof(themetag), required: true);
            return new DeferredBodyAction<VwQuote[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Quotes/Theme/{0}", __workflow_themetag.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VwQuote[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwQuote[], ApiConnectionActionConfiguration> GetRandomQuotesByThemeAndNum(Expression<Func<string>> themetag, Expression<Func<int>> number)
        {
            var __workflow_themetag = WorkflowExpression.Compile(themetag, nameof(themetag), required: true);
            var __workflow_number = WorkflowExpression.Compile(number, nameof(number), required: true);
            return new DeferredBodyAction<VwQuote[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Quotes/Theme/{0}/{1}", __workflow_themetag.WithUrlEncoding(1), __workflow_number.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VwQuote[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwTheme[], ApiConnectionActionConfiguration> GetThemes()
        {
            return new DeferredBodyAction<VwTheme[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Themes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VwTheme[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwTheme, ApiConnectionActionConfiguration> GetTheme(Expression<Func<string>> themetag)
        {
            var __workflow_themetag = WorkflowExpression.Compile(themetag, nameof(themetag), required: true);
            return new DeferredBodyAction<VwTheme, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Themes/{0}", __workflow_themetag.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VwTheme>(callPayload);
            });
        }
    }

    public class VitacloudquotesTriggers([ConnectionName] string connectionId)
    {
    }

    public class VwAuthor
    {
        public string AuthorTag { get; set; }
        public string AuthorName { get; set; }
        public string AuthorImage { get; set; }
        public string AuthorLink { get; set; }
    }

    public class VwQuote
    {
        public string AuthorTag { get; set; }
        public string AuthorName { get; set; }
        public string AuthorImage { get; set; }
        public string AuthorLink { get; set; }
        public string Quote { get; set; }
        public int Length { get; set; }
        public string ThemeTag { get; set; }
        public string ThemeName { get; set; }
    }

    public class VwTheme
    {
        public string ThemeTag { get; set; }
        public string ThemeName { get; set; }
        public string ThemeDesc { get; set; }
        public int ThemeQuotes { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Vitacloudquotes;

    public partial class WorkflowManagedActions
    {
        public VitacloudquotesActions Vitacloudquotes(string connectionId) => new VitacloudquotesActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public VitacloudquotesTriggers Vitacloudquotes(string connectionId) => new VitacloudquotesTriggers(connectionId);
    }
}