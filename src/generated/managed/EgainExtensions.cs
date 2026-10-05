//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Egain
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EgainActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egain")]
        [WorkflowExpressionFactory(nameof(__BuildKbSearch))]
        public IWorkflowAction KbSearch([WorkflowExpression] Func<string> portalId, [WorkflowExpression] Func<string> q, [WorkflowExpression] Func<string> lang, [WorkflowExpression] Func<string> authToken, [WorkflowExpression] Func<string> baseUrl, [WorkflowExpression] Func<string> shortName, [WorkflowExpression] Func<string> acceptLanguage, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> attribute = null, [WorkflowExpression] Func<int> pagenum = null, [WorkflowExpression] Func<int> pagesize = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildKbSearch(WorkflowValue<string> portalId, WorkflowValue<string> q, WorkflowValue<string> lang, WorkflowValue<string> authToken, WorkflowValue<string> baseUrl, WorkflowValue<string> shortName, WorkflowValue<string> acceptLanguage, WorkflowValue<string> accept, WorkflowValue<string> attribute = null, WorkflowValue<int> pagenum = null, WorkflowValue<int> pagesize = null)
        {
            WorkflowValue.Validate(portalId, nameof(portalId), required: true);
            WorkflowValue.Validate(q, nameof(q), required: true);
            WorkflowValue.Validate(lang, nameof(lang), required: true);
            WorkflowValue.Validate(authToken, nameof(authToken), required: true);
            WorkflowValue.Validate(baseUrl, nameof(baseUrl), required: true);
            WorkflowValue.Validate(shortName, nameof(shortName), required: true);
            WorkflowValue.Validate(acceptLanguage, nameof(acceptLanguage), required: true);
            WorkflowValue.Validate(accept, nameof(accept), required: true);
            WorkflowValue.Validate(attribute, nameof(attribute), required: false);
            WorkflowValue.Validate(pagenum, nameof(pagenum), required: false);
            WorkflowValue.Validate(pagesize, nameof(pagesize), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/knowledge/portalmgr/v3/internal/portals/{0}/search/kb", ExpressionConverter.ConvertWithUrlEncoding(portalId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egain")]
        [WorkflowExpressionFactory(nameof(__BuildGenerative))]
        public IWorkflowAction Generative([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<int> portalId, [WorkflowExpression] Func<string> languageCode, [WorkflowExpression] Func<string> authToken, [WorkflowExpression] Func<string> baseUrl, [WorkflowExpression] Func<string> shortName, [WorkflowExpression] Func<int> departmentId = null, [WorkflowExpression] Func<int> userId = null, [WorkflowExpression] Func<int> personalizationProfileId = null, [WorkflowExpression] Func<string> accept = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGenerative(WorkflowValue<string> q, WorkflowValue<int> portalId, WorkflowValue<string> languageCode, WorkflowValue<string> authToken, WorkflowValue<string> baseUrl, WorkflowValue<string> shortName, WorkflowValue<int> departmentId = null, WorkflowValue<int> userId = null, WorkflowValue<int> personalizationProfileId = null, WorkflowValue<string> accept = null)
        {
            WorkflowValue.Validate(q, nameof(q), required: true);
            WorkflowValue.Validate(portalId, nameof(portalId), required: true);
            WorkflowValue.Validate(languageCode, nameof(languageCode), required: true);
            WorkflowValue.Validate(authToken, nameof(authToken), required: true);
            WorkflowValue.Validate(baseUrl, nameof(baseUrl), required: true);
            WorkflowValue.Validate(shortName, nameof(shortName), required: true);
            WorkflowValue.Validate(departmentId, nameof(departmentId), required: false);
            WorkflowValue.Validate(userId, nameof(userId), required: false);
            WorkflowValue.Validate(personalizationProfileId, nameof(personalizationProfileId), required: false);
            WorkflowValue.Validate(accept, nameof(accept), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egain")]
        [WorkflowExpressionFactory(nameof(__BuildSearch))]
        public IWorkflowAction Search([WorkflowExpression] Func<string> portalId, [WorkflowExpression] Func<string> languageCode, [WorkflowExpression] Func<string> q, [WorkflowExpression] Func<string> authToken, [WorkflowExpression] Func<string> baseUrl, [WorkflowExpression] Func<string> shortName, [WorkflowExpression] Func<int> personalizationProfileId = null, [WorkflowExpression] Func<string> accept = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSearch(WorkflowValue<string> portalId, WorkflowValue<string> languageCode, WorkflowValue<string> q, WorkflowValue<string> authToken, WorkflowValue<string> baseUrl, WorkflowValue<string> shortName, WorkflowValue<int> personalizationProfileId = null, WorkflowValue<string> accept = null)
        {
            WorkflowValue.Validate(portalId, nameof(portalId), required: true);
            WorkflowValue.Validate(languageCode, nameof(languageCode), required: true);
            WorkflowValue.Validate(q, nameof(q), required: true);
            WorkflowValue.Validate(authToken, nameof(authToken), required: true);
            WorkflowValue.Validate(baseUrl, nameof(baseUrl), required: true);
            WorkflowValue.Validate(shortName, nameof(shortName), required: true);
            WorkflowValue.Validate(personalizationProfileId, nameof(personalizationProfileId), required: false);
            WorkflowValue.Validate(accept, nameof(accept), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/core/aiservices/v3/internal/instantanswers/{0}/search", ExpressionConverter.ConvertWithUrlEncoding(portalId, 1));
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
