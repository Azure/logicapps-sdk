//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Vitacloudquotes
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VitacloudquotesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwAuthor[]> GetAuthors()
        {
            var apiCallPath = "/Authors";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<VwAuthor[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwAuthor> GetAuthor(Expression<Func<string>> authortag)
        {
            var apiCallPath = String.Format("/Authors/{0}", ExpressionConverter.ConvertWithUrlEncoding(authortag, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<VwAuthor>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwQuote> GetTodaysQuote()
        {
            var apiCallPath = "/Quotes/Today";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<VwQuote>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwQuote> GetRandomQuote()
        {
            var apiCallPath = "/Quotes/Random";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<VwQuote>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwQuote[]> GetRandomQuotes()
        {
            var apiCallPath = "/Quotes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<VwQuote[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwQuote[]> GetRandomQuotesByNum(Expression<Func<int>> number)
        {
            var apiCallPath = String.Format("/Quotes/{0}", ExpressionConverter.ConvertWithUrlEncoding(number, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<VwQuote[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwQuote[]> GetRandomQuotesByAuthor(Expression<Func<string>> authortag)
        {
            var apiCallPath = String.Format("/Quotes/Author/{0}", ExpressionConverter.ConvertWithUrlEncoding(authortag, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<VwQuote[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwQuote[]> GetRandomQuotesByAuthorAndNum(Expression<Func<string>> authortag, Expression<Func<int>> number)
        {
            var apiCallPath = String.Format("/Quotes/Author/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(authortag, 1), ExpressionConverter.ConvertWithUrlEncoding(number, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<VwQuote[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwQuote[]> GetRandomQuotesByTheme(Expression<Func<string>> themetag)
        {
            var apiCallPath = String.Format("/Quotes/Theme/{0}", ExpressionConverter.ConvertWithUrlEncoding(themetag, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<VwQuote[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwQuote[]> GetRandomQuotesByThemeAndNum(Expression<Func<string>> themetag, Expression<Func<int>> number)
        {
            var apiCallPath = String.Format("/Quotes/Theme/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(themetag, 1), ExpressionConverter.ConvertWithUrlEncoding(number, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<VwQuote[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwTheme[]> GetThemes()
        {
            var apiCallPath = "/Themes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<VwTheme[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwTheme> GetTheme(Expression<Func<string>> themetag)
        {
            var apiCallPath = String.Format("/Themes/{0}", ExpressionConverter.ConvertWithUrlEncoding(themetag, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<VwTheme>(callPayload);
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