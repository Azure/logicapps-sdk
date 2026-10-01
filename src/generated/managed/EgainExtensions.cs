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
        public IWorkflowAction KbSearch([WorkflowExpression] Func<string> portalId, [WorkflowExpression] Func<string> q, [WorkflowExpression] Func<string> lang, [WorkflowExpression] Func<string> authToken, [WorkflowExpression] Func<string> baseUrl, [WorkflowExpression] Func<string> shortName, [WorkflowExpression] Func<string> acceptLanguage, [WorkflowExpression] Func<string> accept, [WorkflowExpression] Func<string> attribute = null, [WorkflowExpression] Func<int> pagenum = null, [WorkflowExpression] Func<int> pagesize = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/knowledge/portalmgr/v3/internal/portals/{0}/search/kb", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(portalId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                callPayload.Queries["$lang"] = SourceExpressionConverter.ConvertO(lang);
                if (attribute != null)
                    callPayload.Queries["$attribute"] = SourceExpressionConverter.ConvertO(attribute);
                if (pagenum != null)
                    callPayload.Queries["$pagenum"] = SourceExpressionConverter.ConvertO(pagenum);
                if (pagesize != null)
                    callPayload.Queries["$pagesize"] = SourceExpressionConverter.ConvertO(pagesize);
                callPayload.Queries["authToken"] = SourceExpressionConverter.ConvertO(authToken);
                callPayload.Queries["baseUrl"] = SourceExpressionConverter.ConvertO(baseUrl);
                callPayload.Queries["shortName"] = SourceExpressionConverter.ConvertO(shortName);
                callPayload.Headers["Accept-language"] = SourceExpressionConverter.ConvertO(acceptLanguage);
                callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egain")]
        public IWorkflowAction Generative([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<int> portalId, [WorkflowExpression] Func<string> languageCode, [WorkflowExpression] Func<string> authToken, [WorkflowExpression] Func<string> baseUrl, [WorkflowExpression] Func<string> shortName, [WorkflowExpression] Func<int> departmentId = null, [WorkflowExpression] Func<int> userId = null, [WorkflowExpression] Func<int> personalizationProfileId = null, [WorkflowExpression] Func<string> accept = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/core/aiservices/v3/internal/instantanswers/generative";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (departmentId != null)
                    callPayload.Queries["departmentId"] = SourceExpressionConverter.ConvertO(departmentId);
                if (userId != null)
                    callPayload.Queries["userId"] = SourceExpressionConverter.ConvertO(userId);
                callPayload.Queries["portalId"] = SourceExpressionConverter.ConvertO(portalId);
                callPayload.Queries["languageCode"] = SourceExpressionConverter.ConvertO(languageCode);
                if (personalizationProfileId != null)
                    callPayload.Queries["personalizationProfileId"] = SourceExpressionConverter.ConvertO(personalizationProfileId);
                callPayload.Queries["authToken"] = SourceExpressionConverter.ConvertO(authToken);
                callPayload.Queries["baseUrl"] = SourceExpressionConverter.ConvertO(baseUrl);
                callPayload.Queries["shortName"] = SourceExpressionConverter.ConvertO(shortName);
                if (accept != null)
                    callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egain")]
        public IWorkflowAction Search([WorkflowExpression] Func<string> portalId, [WorkflowExpression] Func<string> languageCode, [WorkflowExpression] Func<string> q, [WorkflowExpression] Func<string> authToken, [WorkflowExpression] Func<string> baseUrl, [WorkflowExpression] Func<string> shortName, [WorkflowExpression] Func<int> personalizationProfileId = null, [WorkflowExpression] Func<string> accept = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/core/aiservices/v3/internal/instantanswers/{0}/search", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(portalId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["languageCode"] = SourceExpressionConverter.ConvertO(languageCode);
                callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (personalizationProfileId != null)
                    callPayload.Queries["personalizationProfileId"] = SourceExpressionConverter.ConvertO(personalizationProfileId);
                callPayload.Queries["authToken"] = SourceExpressionConverter.ConvertO(authToken);
                callPayload.Queries["baseUrl"] = SourceExpressionConverter.ConvertO(baseUrl);
                callPayload.Queries["shortName"] = SourceExpressionConverter.ConvertO(shortName);
                if (accept != null)
                    callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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