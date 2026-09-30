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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/quotes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ronswansonquotesip")]
        public IBodyWorkflowAction<string[]> Quotes([WorkflowExpression] Func<int> count)
        {
            SourceExpression.Validate(count, nameof(count), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/quotes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(count, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ronswansonquotesip")]
        public IBodyWorkflowAction<string[]> Search([WorkflowExpression] Func<string> term)
        {
            SourceExpression.Validate(term, nameof(term), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/quotes/search/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(term, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
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