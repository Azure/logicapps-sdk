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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Authors";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VwAuthor[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwAuthor> GetAuthor([WorkflowExpression] Func<string> authortag)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Authors/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(authortag, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VwAuthor>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwQuote> GetTodaysQuote()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Quotes/Today";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VwQuote>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwQuote> GetRandomQuote()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Quotes/Random";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VwQuote>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwQuote[]> GetRandomQuotes()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Quotes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VwQuote[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwQuote[]> GetRandomQuotesByNum([WorkflowExpression] Func<int> number)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Quotes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(number, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VwQuote[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwQuote[]> GetRandomQuotesByAuthor([WorkflowExpression] Func<string> authortag)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Quotes/Author/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(authortag, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VwQuote[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwQuote[]> GetRandomQuotesByAuthorAndNum([WorkflowExpression] Func<string> authortag, [WorkflowExpression] Func<int> number)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Quotes/Author/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(authortag, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(number, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VwQuote[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwQuote[]> GetRandomQuotesByTheme([WorkflowExpression] Func<string> themetag)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Quotes/Theme/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(themetag, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VwQuote[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwQuote[]> GetRandomQuotesByThemeAndNum([WorkflowExpression] Func<string> themetag, [WorkflowExpression] Func<int> number)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Quotes/Theme/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(themetag, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(number, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VwQuote[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwTheme[]> GetThemes()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Themes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VwTheme[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vitacloudquotes")]
        public IBodyWorkflowAction<VwTheme> GetTheme([WorkflowExpression] Func<string> themetag)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Themes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(themetag, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VwTheme>(BuildSourceInput);
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