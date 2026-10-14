//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Egain
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class EgainActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egain")]
        public IWorkflowAction KbSearch(Expression<Func<string>> portalId, Expression<Func<string>> q, Expression<Func<string>> lang, Expression<Func<string>> authToken, Expression<Func<string>> baseUrl, Expression<Func<string>> shortName, Expression<Func<string>> acceptLanguage, Expression<Func<string>> accept, Expression<Func<string>> attribute = null, Expression<Func<int>> pagenum = null, Expression<Func<int>> pagesize = null)
        {
            var __workflow_portalId = portalId == null ? null : WorkflowExpression.Compile(portalId);
            WorkflowExpression.Validate(__workflow_portalId, nameof(portalId), required: true);
            var __workflow_q = q == null ? null : WorkflowExpression.Compile(q);
            WorkflowExpression.Validate(__workflow_q, nameof(q), required: true);
            var __workflow_lang = lang == null ? null : WorkflowExpression.Compile(lang);
            WorkflowExpression.Validate(__workflow_lang, nameof(lang), required: true);
            var __workflow_authToken = authToken == null ? null : WorkflowExpression.Compile(authToken);
            WorkflowExpression.Validate(__workflow_authToken, nameof(authToken), required: true);
            var __workflow_baseUrl = baseUrl == null ? null : WorkflowExpression.Compile(baseUrl);
            WorkflowExpression.Validate(__workflow_baseUrl, nameof(baseUrl), required: true);
            var __workflow_shortName = shortName == null ? null : WorkflowExpression.Compile(shortName);
            WorkflowExpression.Validate(__workflow_shortName, nameof(shortName), required: true);
            var __workflow_acceptLanguage = acceptLanguage == null ? null : WorkflowExpression.Compile(acceptLanguage);
            WorkflowExpression.Validate(__workflow_acceptLanguage, nameof(acceptLanguage), required: true);
            var __workflow_accept = accept == null ? null : WorkflowExpression.Compile(accept);
            WorkflowExpression.Validate(__workflow_accept, nameof(accept), required: true);
            var __workflow_attribute = attribute == null ? null : WorkflowExpression.Compile(attribute);
            WorkflowExpression.Validate(__workflow_attribute, nameof(attribute), required: false);
            var __workflow_pagenum = pagenum == null ? null : WorkflowExpression.Compile(pagenum);
            WorkflowExpression.Validate(__workflow_pagenum, nameof(pagenum), required: false);
            var __workflow_pagesize = pagesize == null ? null : WorkflowExpression.Compile(pagesize);
            WorkflowExpression.Validate(__workflow_pagesize, nameof(pagesize), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/knowledge/portalmgr/v3/internal/portals/{0}/search/kb", ExpressionConverter.ConvertWithUrlEncoding(__workflow_portalId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                callPayload.Queries["$lang"] = ExpressionConverter.Convert(__workflow_lang);
                if (__workflow_attribute != null)
                    callPayload.Queries["$attribute"] = ExpressionConverter.Convert(__workflow_attribute);
                if (__workflow_pagenum != null)
                    callPayload.Queries["$pagenum"] = ExpressionConverter.Convert(__workflow_pagenum);
                if (__workflow_pagesize != null)
                    callPayload.Queries["$pagesize"] = ExpressionConverter.Convert(__workflow_pagesize);
                callPayload.Queries["authToken"] = ExpressionConverter.Convert(__workflow_authToken);
                callPayload.Queries["baseUrl"] = ExpressionConverter.Convert(__workflow_baseUrl);
                callPayload.Queries["shortName"] = ExpressionConverter.Convert(__workflow_shortName);
                callPayload.Headers["Accept-language"] = ExpressionConverter.Convert(__workflow_acceptLanguage);
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egain")]
        public IWorkflowAction Generative(Expression<Func<string>> q, Expression<Func<int>> portalId, Expression<Func<string>> languageCode, Expression<Func<string>> authToken, Expression<Func<string>> baseUrl, Expression<Func<string>> shortName, Expression<Func<int>> departmentId = null, Expression<Func<int>> userId = null, Expression<Func<int>> personalizationProfileId = null, Expression<Func<string>> accept = null)
        {
            var __workflow_q = q == null ? null : WorkflowExpression.Compile(q);
            WorkflowExpression.Validate(__workflow_q, nameof(q), required: true);
            var __workflow_portalId = portalId == null ? null : WorkflowExpression.Compile(portalId);
            WorkflowExpression.Validate(__workflow_portalId, nameof(portalId), required: true);
            var __workflow_languageCode = languageCode == null ? null : WorkflowExpression.Compile(languageCode);
            WorkflowExpression.Validate(__workflow_languageCode, nameof(languageCode), required: true);
            var __workflow_authToken = authToken == null ? null : WorkflowExpression.Compile(authToken);
            WorkflowExpression.Validate(__workflow_authToken, nameof(authToken), required: true);
            var __workflow_baseUrl = baseUrl == null ? null : WorkflowExpression.Compile(baseUrl);
            WorkflowExpression.Validate(__workflow_baseUrl, nameof(baseUrl), required: true);
            var __workflow_shortName = shortName == null ? null : WorkflowExpression.Compile(shortName);
            WorkflowExpression.Validate(__workflow_shortName, nameof(shortName), required: true);
            var __workflow_departmentId = departmentId == null ? null : WorkflowExpression.Compile(departmentId);
            WorkflowExpression.Validate(__workflow_departmentId, nameof(departmentId), required: false);
            var __workflow_userId = userId == null ? null : WorkflowExpression.Compile(userId);
            WorkflowExpression.Validate(__workflow_userId, nameof(userId), required: false);
            var __workflow_personalizationProfileId = personalizationProfileId == null ? null : WorkflowExpression.Compile(personalizationProfileId);
            WorkflowExpression.Validate(__workflow_personalizationProfileId, nameof(personalizationProfileId), required: false);
            var __workflow_accept = accept == null ? null : WorkflowExpression.Compile(accept);
            WorkflowExpression.Validate(__workflow_accept, nameof(accept), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/core/aiservices/v3/internal/instantanswers/generative";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_departmentId != null)
                    callPayload.Queries["departmentId"] = ExpressionConverter.Convert(__workflow_departmentId);
                if (__workflow_userId != null)
                    callPayload.Queries["userId"] = ExpressionConverter.Convert(__workflow_userId);
                callPayload.Queries["portalId"] = ExpressionConverter.Convert(__workflow_portalId);
                callPayload.Queries["languageCode"] = ExpressionConverter.Convert(__workflow_languageCode);
                if (__workflow_personalizationProfileId != null)
                    callPayload.Queries["personalizationProfileId"] = ExpressionConverter.Convert(__workflow_personalizationProfileId);
                callPayload.Queries["authToken"] = ExpressionConverter.Convert(__workflow_authToken);
                callPayload.Queries["baseUrl"] = ExpressionConverter.Convert(__workflow_baseUrl);
                callPayload.Queries["shortName"] = ExpressionConverter.Convert(__workflow_shortName);
                if (__workflow_accept != null)
                    callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egain")]
        public IWorkflowAction Search(Expression<Func<string>> portalId, Expression<Func<string>> languageCode, Expression<Func<string>> q, Expression<Func<string>> authToken, Expression<Func<string>> baseUrl, Expression<Func<string>> shortName, Expression<Func<int>> personalizationProfileId = null, Expression<Func<string>> accept = null)
        {
            var __workflow_portalId = portalId == null ? null : WorkflowExpression.Compile(portalId);
            WorkflowExpression.Validate(__workflow_portalId, nameof(portalId), required: true);
            var __workflow_languageCode = languageCode == null ? null : WorkflowExpression.Compile(languageCode);
            WorkflowExpression.Validate(__workflow_languageCode, nameof(languageCode), required: true);
            var __workflow_q = q == null ? null : WorkflowExpression.Compile(q);
            WorkflowExpression.Validate(__workflow_q, nameof(q), required: true);
            var __workflow_authToken = authToken == null ? null : WorkflowExpression.Compile(authToken);
            WorkflowExpression.Validate(__workflow_authToken, nameof(authToken), required: true);
            var __workflow_baseUrl = baseUrl == null ? null : WorkflowExpression.Compile(baseUrl);
            WorkflowExpression.Validate(__workflow_baseUrl, nameof(baseUrl), required: true);
            var __workflow_shortName = shortName == null ? null : WorkflowExpression.Compile(shortName);
            WorkflowExpression.Validate(__workflow_shortName, nameof(shortName), required: true);
            var __workflow_personalizationProfileId = personalizationProfileId == null ? null : WorkflowExpression.Compile(personalizationProfileId);
            WorkflowExpression.Validate(__workflow_personalizationProfileId, nameof(personalizationProfileId), required: false);
            var __workflow_accept = accept == null ? null : WorkflowExpression.Compile(accept);
            WorkflowExpression.Validate(__workflow_accept, nameof(accept), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/core/aiservices/v3/internal/instantanswers/{0}/search", ExpressionConverter.ConvertWithUrlEncoding(__workflow_portalId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["languageCode"] = ExpressionConverter.Convert(__workflow_languageCode);
                callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_personalizationProfileId != null)
                    callPayload.Queries["personalizationProfileId"] = ExpressionConverter.Convert(__workflow_personalizationProfileId);
                callPayload.Queries["authToken"] = ExpressionConverter.Convert(__workflow_authToken);
                callPayload.Queries["baseUrl"] = ExpressionConverter.Convert(__workflow_baseUrl);
                callPayload.Queries["shortName"] = ExpressionConverter.Convert(__workflow_shortName);
                if (__workflow_accept != null)
                    callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                return new ApiConnectionAction(callPayload);
            });
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
