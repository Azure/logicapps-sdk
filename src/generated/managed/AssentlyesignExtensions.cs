//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Assentlyesign
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AssentlyesignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IBodyWorkflowAction<JToken> GetCase(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/v2/getCase";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Queries["includeAllStatuses"] = Convert.ToString(true);
                callPayload.Queries["IncludePendingApprovalStatus"] = Convert.ToString(true);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IBodyWorkflowAction<JToken[]> FindCases(Expression<Func<object>> findCasesModel = null)
        {
            var __workflow_findCasesModel = WorkflowExpression.Compile(findCasesModel, nameof(findCasesModel), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/v2/findCases";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeAllStatuses"] = Convert.ToString(true);
                callPayload.Queries["IncludePendingApprovalStatus"] = Convert.ToString(true);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_findCasesModel);
                return new ApiConnectionAction<JToken[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IBodyWorkflowAction<JToken[]> FindTemplates(Expression<Func<object>> findTemplatesModel = null)
        {
            var __workflow_findTemplatesModel = WorkflowExpression.Compile(findTemplatesModel, nameof(findTemplatesModel), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/v2/findTemplates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_findTemplatesModel);
                return new ApiConnectionAction<JToken[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IWorkflowAction CreateCase(Expression<Func<object>> caseModel = null)
        {
            var __workflow_caseModel = WorkflowExpression.Compile(caseModel, nameof(caseModel), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/createCase";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_caseModel);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IWorkflowAction CreateCaseFromTemplate(Expression<Func<object>> createCaseFromTemplateModel = null)
        {
            var __workflow_createCaseFromTemplateModel = WorkflowExpression.Compile(createCaseFromTemplateModel, nameof(createCaseFromTemplateModel), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/createCaseFromTemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_createCaseFromTemplateModel);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IWorkflowAction UpdateCase()
        {
            var apiCallPath = "/v2/updateCase";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var caseModel = new JObject();
            var caseModelpropCount = 0;
            if (caseModelpropCount > 0)
            {
                callPayload.Body = caseModel;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IWorkflowAction UpdateCaseMetadata(Expression<Func<object>> updateCaseMetadataModel = null)
        {
            var __workflow_updateCaseMetadataModel = WorkflowExpression.Compile(updateCaseMetadataModel, nameof(updateCaseMetadataModel), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/updateCaseMetadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_updateCaseMetadataModel);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IWorkflowAction SendCase(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/sendCase";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IWorkflowAction RequestApproval(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/requestApproval";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IWorkflowAction RemindCase(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/remindCase";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IWorkflowAction DeleteCase(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/deleteCase";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IWorkflowAction RecallCase(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/recallCase";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IWorkflowAction GetCaseByTemporaryId(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/getCaseByTemporaryId";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IBodyWorkflowAction<string> GetFileOfCase(Expression<Func<string>> caseid, Expression<Func<string>> documentid)
        {
            var __workflow_caseid = WorkflowExpression.Compile(caseid, nameof(caseid), required: true);
            var __workflow_documentid = WorkflowExpression.Compile(documentid, nameof(documentid), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/getdocumentdata";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["caseid"] = ExpressionConverter.Convert(__workflow_caseid);
                callPayload.Queries["documentid"] = ExpressionConverter.Convert(__workflow_documentid);
                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class AssentlyesignTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CaseEventTrigger(Expression<Func<string>> eventPath, FlowRecurrence recurrence = null)
        {
            var __workflow_eventPath = WorkflowExpression.Compile(eventPath, nameof(eventPath), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/hook/v1/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["EventPath"] = ExpressionConverter.Convert(__workflow_eventPath);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Assentlyesign;

    public partial class WorkflowManagedActions
    {
        public AssentlyesignActions Assentlyesign(string connectionId) => new AssentlyesignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AssentlyesignTriggers Assentlyesign(string connectionId) => new AssentlyesignTriggers(connectionId);
    }
}
