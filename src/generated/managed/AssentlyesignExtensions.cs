//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Assentlyesign
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AssentlyesignActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        [WorkflowExpressionFactory(nameof(__BuildGetCase))]
        public IBodyWorkflowAction<JToken> GetCase([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetCase(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/v2/getCase";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
                callPayload.Queries["includeAllStatuses"] = Convert.ToString(true);
                callPayload.Queries["IncludePendingApprovalStatus"] = Convert.ToString(true);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        [WorkflowExpressionFactory(nameof(__BuildFindCases))]
        public IBodyWorkflowAction<JToken[]> FindCases([WorkflowExpression] Func<object> findCasesModel = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildFindCases(WorkflowExpression<object> findCasesModel = null)
        {
            WorkflowExpression.Validate(findCasesModel, nameof(findCasesModel), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/v2/findCases";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeAllStatuses"] = Convert.ToString(true);
                callPayload.Queries["IncludePendingApprovalStatus"] = Convert.ToString(true);
                callPayload.Body = ExpressionConverter.ConvertO(findCasesModel);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        [WorkflowExpressionFactory(nameof(__BuildFindTemplates))]
        public IBodyWorkflowAction<JToken[]> FindTemplates([WorkflowExpression] Func<object> findTemplatesModel = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildFindTemplates(WorkflowExpression<object> findTemplatesModel = null)
        {
            WorkflowExpression.Validate(findTemplatesModel, nameof(findTemplatesModel), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = "/v2/findTemplates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(findTemplatesModel);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        [WorkflowExpressionFactory(nameof(__BuildCreateCase))]
        public IWorkflowAction CreateCase([WorkflowExpression] Func<object> caseModel = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateCase(WorkflowExpression<object> caseModel = null)
        {
            WorkflowExpression.Validate(caseModel, nameof(caseModel), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/createCase";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(caseModel);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        [WorkflowExpressionFactory(nameof(__BuildCreateCaseFromTemplate))]
        public IWorkflowAction CreateCaseFromTemplate([WorkflowExpression] Func<object> createCaseFromTemplateModel = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateCaseFromTemplate(WorkflowExpression<object> createCaseFromTemplateModel = null)
        {
            WorkflowExpression.Validate(createCaseFromTemplateModel, nameof(createCaseFromTemplateModel), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/createCaseFromTemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(createCaseFromTemplateModel);
                return new ApiConnectionAction(callPayload);
            });
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
        [WorkflowExpressionFactory(nameof(__BuildUpdateCaseMetadata))]
        public IWorkflowAction UpdateCaseMetadata([WorkflowExpression] Func<object> updateCaseMetadataModel = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateCaseMetadata(WorkflowExpression<object> updateCaseMetadataModel = null)
        {
            WorkflowExpression.Validate(updateCaseMetadataModel, nameof(updateCaseMetadataModel), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/updateCaseMetadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(updateCaseMetadataModel);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        [WorkflowExpressionFactory(nameof(__BuildSendCase))]
        public IWorkflowAction SendCase([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendCase(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/sendCase";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        [WorkflowExpressionFactory(nameof(__BuildRequestApproval))]
        public IWorkflowAction RequestApproval([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRequestApproval(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/requestApproval";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        [WorkflowExpressionFactory(nameof(__BuildRemindCase))]
        public IWorkflowAction RemindCase([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRemindCase(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/remindCase";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteCase))]
        public IWorkflowAction DeleteCase([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteCase(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/deleteCase";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        [WorkflowExpressionFactory(nameof(__BuildRecallCase))]
        public IWorkflowAction RecallCase([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRecallCase(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/recallCase";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        [WorkflowExpressionFactory(nameof(__BuildGetCaseByTemporaryId))]
        public IWorkflowAction GetCaseByTemporaryId([WorkflowExpression] Func<int> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetCaseByTemporaryId(WorkflowExpression<int> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/getCaseByTemporaryId";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        [WorkflowExpressionFactory(nameof(__BuildGetFileOfCase))]
        public IBodyWorkflowAction<string> GetFileOfCase([WorkflowExpression] Func<string> caseid, [WorkflowExpression] Func<string> documentid)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetFileOfCase(WorkflowExpression<string> caseid, WorkflowExpression<string> documentid)
        {
            WorkflowExpression.Validate(caseid, nameof(caseid), required: true);
            WorkflowExpression.Validate(documentid, nameof(documentid), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/getdocumentdata";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["caseid"] = ExpressionConverter.Convert(caseid);
                callPayload.Queries["documentid"] = ExpressionConverter.Convert(documentid);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class AssentlyesignTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildCaseEventTrigger))]
        public IWorkflowTrigger CaseEventTrigger([WorkflowExpression] Func<string> eventPath,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCaseEventTrigger(WorkflowExpression<string> eventPath,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(eventPath, nameof(eventPath), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/hook/v1/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["EventPath"] = ExpressionConverter.Convert(eventPath);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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