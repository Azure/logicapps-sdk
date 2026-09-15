//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Egain
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EgainActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egain")]
        public IWorkflowAction KbSearch(Expression<Func<string>> portalId, Expression<Func<string>> q, Expression<Func<string>> lang, Expression<Func<string>> authToken, Expression<Func<string>> baseUrl, Expression<Func<string>> shortName, Expression<Func<string>> acceptLanguage, Expression<Func<string>> accept, Expression<Func<string>> attribute = null, Expression<Func<int>> pagenum = null, Expression<Func<int>> pagesize = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/knowledge/portalmgr/v3/internal/portals/{0}/search/kb", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(portalId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["q"] = CSharpExpressionConverter.ConvertO(q);
            callPayload.Queries["$lang"] = CSharpExpressionConverter.ConvertO(lang);
            if (attribute != null)
                callPayload.Queries["$attribute"] = CSharpExpressionConverter.ConvertO(attribute);
            if (pagenum != null)
                callPayload.Queries["$pagenum"] = CSharpExpressionConverter.ConvertO(pagenum);
            if (pagesize != null)
                callPayload.Queries["$pagesize"] = CSharpExpressionConverter.ConvertO(pagesize);
            callPayload.Queries["authToken"] = CSharpExpressionConverter.ConvertO(authToken);
            callPayload.Queries["baseUrl"] = CSharpExpressionConverter.ConvertO(baseUrl);
            callPayload.Queries["shortName"] = CSharpExpressionConverter.ConvertO(shortName);
            callPayload.Headers["Accept-language"] = CSharpExpressionConverter.ConvertO(acceptLanguage);
            callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egain")]
        public IWorkflowAction Generative(Expression<Func<string>> q, Expression<Func<int>> portalId, Expression<Func<string>> languageCode, Expression<Func<string>> authToken, Expression<Func<string>> baseUrl, Expression<Func<string>> shortName, Expression<Func<int>> departmentId = null, Expression<Func<int>> userId = null, Expression<Func<int>> personalizationProfileId = null, Expression<Func<string>> accept = null)
        {
            var apiCallPath = "/core/aiservices/v3/internal/instantanswers/generative";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["q"] = CSharpExpressionConverter.ConvertO(q);
            if (departmentId != null)
                callPayload.Queries["departmentId"] = CSharpExpressionConverter.ConvertO(departmentId);
            if (userId != null)
                callPayload.Queries["userId"] = CSharpExpressionConverter.ConvertO(userId);
            callPayload.Queries["portalId"] = CSharpExpressionConverter.ConvertO(portalId);
            callPayload.Queries["languageCode"] = CSharpExpressionConverter.ConvertO(languageCode);
            if (personalizationProfileId != null)
                callPayload.Queries["personalizationProfileId"] = CSharpExpressionConverter.ConvertO(personalizationProfileId);
            callPayload.Queries["authToken"] = CSharpExpressionConverter.ConvertO(authToken);
            callPayload.Queries["baseUrl"] = CSharpExpressionConverter.ConvertO(baseUrl);
            callPayload.Queries["shortName"] = CSharpExpressionConverter.ConvertO(shortName);
            if (accept != null)
                callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egain")]
        public IWorkflowAction Search(Expression<Func<string>> portalId, Expression<Func<string>> languageCode, Expression<Func<string>> q, Expression<Func<string>> authToken, Expression<Func<string>> baseUrl, Expression<Func<string>> shortName, Expression<Func<int>> personalizationProfileId = null, Expression<Func<string>> accept = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/core/aiservices/v3/internal/instantanswers/{0}/search", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(portalId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["languageCode"] = CSharpExpressionConverter.ConvertO(languageCode);
            callPayload.Queries["q"] = CSharpExpressionConverter.ConvertO(q);
            if (personalizationProfileId != null)
                callPayload.Queries["personalizationProfileId"] = CSharpExpressionConverter.ConvertO(personalizationProfileId);
            callPayload.Queries["authToken"] = CSharpExpressionConverter.ConvertO(authToken);
            callPayload.Queries["baseUrl"] = CSharpExpressionConverter.ConvertO(baseUrl);
            callPayload.Queries["shortName"] = CSharpExpressionConverter.ConvertO(shortName);
            if (accept != null)
                callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class EgainTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Egain;

    public partial class WorkflowManagedActions
    {
        public EgainActions Egain(string connectionId) => new EgainActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EgainTriggers Egain(string connectionId) => new EgainTriggers(connectionId);
    }
}