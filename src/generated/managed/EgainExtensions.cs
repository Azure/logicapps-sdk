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
        public IWorkflowAction SearchV3(Expression<Func<string>> portalId, Expression<Func<string>> languageCode, Expression<Func<string>> q, Expression<Func<string>> authToken, Expression<Func<string>> baseUrl, Expression<Func<string>> shortName, Expression<Func<int>> personalizationProfileId = null, Expression<Func<string>> accept = null)
        {
            var apiCallPath = String.Format("/core/aiservices/v3/internal/instantanswers/{0}/search", ExpressionConverter.ConvertWithUrlEncoding(portalId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["languageCode"] = ExpressionConverter.Convert(languageCode);
            callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (personalizationProfileId != null)
                callPayload.Queries["personalizationProfileId"] = ExpressionConverter.Convert(personalizationProfileId);
            callPayload.Queries["authToken"] = ExpressionConverter.Convert(authToken);
            callPayload.Queries["baseUrl"] = ExpressionConverter.Convert(baseUrl);
            callPayload.Queries["shortName"] = ExpressionConverter.Convert(shortName);
            if (accept != null)
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egain")]
        public IWorkflowAction GenerativeV3(Expression<Func<string>> q, Expression<Func<int>> portalId, Expression<Func<string>> languageCode, Expression<Func<string>> authToken, Expression<Func<string>> baseUrl, Expression<Func<string>> shortName, Expression<Func<int>> departmentId = null, Expression<Func<int>> userId = null, Expression<Func<int>> personalizationProfileId = null, Expression<Func<string>> accept = null)
        {
            var apiCallPath = "/core/aiservices/v3/internal/instantanswers/generative";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (departmentId != null)
                callPayload.Queries["departmentId"] = ExpressionConverter.Convert(departmentId);
            if (userId != null)
                callPayload.Queries["userId"] = ExpressionConverter.Convert(userId);
            callPayload.Queries["portalId"] = ExpressionConverter.Convert(portalId);
            callPayload.Queries["languageCode"] = ExpressionConverter.Convert(languageCode);
            if (personalizationProfileId != null)
                callPayload.Queries["personalizationProfileId"] = ExpressionConverter.Convert(personalizationProfileId);
            callPayload.Queries["authToken"] = ExpressionConverter.Convert(authToken);
            callPayload.Queries["baseUrl"] = ExpressionConverter.Convert(baseUrl);
            callPayload.Queries["shortName"] = ExpressionConverter.Convert(shortName);
            if (accept != null)
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egain")]
        public IWorkflowAction KbSearch(Expression<Func<string>> portalId, Expression<Func<string>> q, Expression<Func<string>> lang, Expression<Func<string>> authToken, Expression<Func<string>> baseUrl, Expression<Func<string>> shortName, Expression<Func<string>> acceptLanguage, Expression<Func<string>> accept, Expression<Func<string>> attribute = null, Expression<Func<int>> pagenum = null, Expression<Func<int>> pagesize = null)
        {
            var apiCallPath = String.Format("/knowledge/portalmgr/v3/internal/portals/{0}/search/kb", ExpressionConverter.ConvertWithUrlEncoding(portalId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            callPayload.Queries["$lang"] = ExpressionConverter.Convert(lang);
            if (attribute != null)
                callPayload.Queries["$attribute"] = ExpressionConverter.Convert(attribute);
            if (pagenum != null)
                callPayload.Queries["$pagenum"] = ExpressionConverter.Convert(pagenum);
            if (pagesize != null)
                callPayload.Queries["$pagesize"] = ExpressionConverter.Convert(pagesize);
            callPayload.Queries["authToken"] = ExpressionConverter.Convert(authToken);
            callPayload.Queries["baseUrl"] = ExpressionConverter.Convert(baseUrl);
            callPayload.Queries["shortName"] = ExpressionConverter.Convert(shortName);
            callPayload.Headers["Accept-language"] = ExpressionConverter.Convert(acceptLanguage);
            callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
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