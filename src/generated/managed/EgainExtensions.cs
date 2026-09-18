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
        public IWorkflowAction KbSearch([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> portalId, [WorkflowExpression] Func<string> q, [WorkflowExpression] Func<string> lang, [WorkflowExpression] Func<string> authToken, [WorkflowExpression] Func<string> baseUrl, [WorkflowExpression] Func<string> shortName, [WorkflowExpression] Func<string> acceptLanguage, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> attribute = null, [WorkflowExpression] Func<int> pagenum = null, [WorkflowExpression] Func<int> pagesize = null)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egain")]
        public IWorkflowAction Generative([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<int> portalId, [WorkflowExpression] Func<string> languageCode, [WorkflowExpression] Func<string> authToken, [WorkflowExpression] Func<string> baseUrl, [WorkflowExpression] Func<string> shortName, [WorkflowExpression] Func<int> departmentId = null, [WorkflowExpression] Func<int> userId = null, [WorkflowExpression] Func<int> personalizationProfileId = null, [WorkflowExpression] Func<string> accept = null)
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
        public IWorkflowAction Search([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> portalId, [WorkflowExpression] Func<string> languageCode, [WorkflowExpression] Func<string> q, [WorkflowExpression] Func<string> authToken, [WorkflowExpression] Func<string> baseUrl, [WorkflowExpression] Func<string> shortName, [WorkflowExpression] Func<int> personalizationProfileId = null, [WorkflowExpression] Func<string> accept = null)
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