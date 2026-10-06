//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Safetyculture
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SafetycultureActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [WorkflowExpressionFactory(nameof(__BuildSearchAudits))]
        public IBodyWorkflowAction<AuditSearchResponse> SearchAudits([WorkflowExpression] Func<orderInput> order = null, [WorkflowExpression] Func<string> modifiedAfter = null, [WorkflowExpression] Func<string> modifiedBefore = null, [WorkflowExpression] Func<string> template = null, [WorkflowExpression] Func<archivedInput> archived = null, [WorkflowExpression] Func<completedInput> completed = null, [WorkflowExpression] Func<ownerInput> owner = null, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AuditSearchResponse> __BuildSearchAudits(WorkflowExpression<orderInput> order = null, WorkflowExpression<string> modifiedAfter = null, WorkflowExpression<string> modifiedBefore = null, WorkflowExpression<string> template = null, WorkflowExpression<archivedInput> archived = null, WorkflowExpression<completedInput> completed = null, WorkflowExpression<ownerInput> owner = null, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(order, nameof(order), required: false);
            WorkflowExpression.Validate(modifiedAfter, nameof(modifiedAfter), required: false);
            WorkflowExpression.Validate(modifiedBefore, nameof(modifiedBefore), required: false);
            WorkflowExpression.Validate(template, nameof(template), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            WorkflowExpression.Validate(completed, nameof(completed), required: false);
            WorkflowExpression.Validate(owner, nameof(owner), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<AuditSearchResponse>(() =>
            {
                var apiCallPath = "/audits/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["order"] = Convert.ToString("desc");
                if (order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(order);
                if (modifiedAfter != null)
                    callPayload.Queries["modified_after"] = ExpressionConverter.Convert(modifiedAfter);
                if (modifiedBefore != null)
                    callPayload.Queries["modified_before"] = ExpressionConverter.Convert(modifiedBefore);
                if (template != null)
                    callPayload.Queries["template"] = ExpressionConverter.Convert(template);
                callPayload.Queries["archived"] = Convert.ToString("false");
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                callPayload.Queries["completed"] = Convert.ToString("true");
                if (completed != null)
                    callPayload.Queries["completed"] = ExpressionConverter.Convert(completed);
                callPayload.Queries["owner"] = Convert.ToString("all");
                if (owner != null)
                    callPayload.Queries["owner"] = ExpressionConverter.Convert(owner);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction<AuditSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [WorkflowExpressionFactory(nameof(__BuildGetAuditById))]
        public IBodyWorkflowAction<GetAuditByIdResponse> GetAuditById([WorkflowExpression] Func<string> auditId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAuditByIdResponse> __BuildGetAuditById(WorkflowExpression<string> auditId)
        {
            WorkflowExpression.Validate(auditId, nameof(auditId), required: true);
            return new DeferredBodyAction<GetAuditByIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/audits/{0}", ExpressionConverter.ConvertWithUrlEncoding(auditId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAuditByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [WorkflowExpressionFactory(nameof(__BuildArchiveRestoreAudit))]
        public IBodyWorkflowAction<GetAuditByIdResponse> ArchiveRestoreAudit([WorkflowExpression] Func<string> auditId, [WorkflowExpression] Func<bool> bodyarchived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAuditByIdResponse> __BuildArchiveRestoreAudit(WorkflowExpression<string> auditId, WorkflowExpression<bool> bodyarchived = null)
        {
            WorkflowExpression.Validate(auditId, nameof(auditId), required: true);
            WorkflowExpression.Validate(bodyarchived, nameof(bodyarchived), required: false);
            return new DeferredBodyAction<GetAuditByIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/audits/{0}", ExpressionConverter.ConvertWithUrlEncoding(auditId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyarchived != null)
                {
                    body["archived"] = ExpressionConverter.ConvertO(bodyarchived);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetAuditByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [WorkflowExpressionFactory(nameof(__BuildInitiateAuditExport))]
        public IBodyWorkflowAction<InitExportResponse> InitiateAuditExport([WorkflowExpression] Func<string> auditId, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<timezoneInput> timezone = null, [WorkflowExpression] Func<string> exportProfile = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InitExportResponse> __BuildInitiateAuditExport(WorkflowExpression<string> auditId, WorkflowExpression<formatInput> format, WorkflowExpression<timezoneInput> timezone = null, WorkflowExpression<string> exportProfile = null)
        {
            WorkflowExpression.Validate(auditId, nameof(auditId), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(timezone, nameof(timezone), required: false);
            WorkflowExpression.Validate(exportProfile, nameof(exportProfile), required: false);
            return new DeferredBodyAction<InitExportResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/audits/{0}/export", ExpressionConverter.ConvertWithUrlEncoding(auditId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                callPayload.Queries["timezone"] = Convert.ToString("Etc/UTC");
                if (timezone != null)
                    callPayload.Queries["timezone"] = ExpressionConverter.Convert(timezone);
                if (exportProfile != null)
                    callPayload.Queries["export_profile"] = ExpressionConverter.Convert(exportProfile);
                return new ApiConnectionAction<InitExportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [WorkflowExpressionFactory(nameof(__BuildPollExportStatus))]
        public IBodyWorkflowAction<ExportStatusResponse> PollExportStatus([WorkflowExpression] Func<string> auditId, [WorkflowExpression] Func<string> exportId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExportStatusResponse> __BuildPollExportStatus(WorkflowExpression<string> auditId, WorkflowExpression<string> exportId)
        {
            WorkflowExpression.Validate(auditId, nameof(auditId), required: true);
            WorkflowExpression.Validate(exportId, nameof(exportId), required: true);
            return new DeferredBodyAction<ExportStatusResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/audits/{0}/exports/{1}", ExpressionConverter.ConvertWithUrlEncoding(auditId, 1), ExpressionConverter.ConvertWithUrlEncoding(exportId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ExportStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [WorkflowExpressionFactory(nameof(__BuildGetAuditExport))]
        public IBodyWorkflowAction<string> GetAuditExport([WorkflowExpression] Func<string> auditId, [WorkflowExpression] Func<string> exportId, [WorkflowExpression] Func<string> filename)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetAuditExport(WorkflowExpression<string> auditId, WorkflowExpression<string> exportId, WorkflowExpression<string> filename)
        {
            WorkflowExpression.Validate(auditId, nameof(auditId), required: true);
            WorkflowExpression.Validate(exportId, nameof(exportId), required: true);
            WorkflowExpression.Validate(filename, nameof(filename), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/audits/{0}/exports/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(auditId, 1), ExpressionConverter.ConvertWithUrlEncoding(exportId, 1), ExpressionConverter.ConvertWithUrlEncoding(filename, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [WorkflowExpressionFactory(nameof(__BuildGetWebReportLink))]
        public IBodyWorkflowAction<GetAuditLinkResponse> GetWebReportLink([WorkflowExpression] Func<string> auditId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAuditLinkResponse> __BuildGetWebReportLink(WorkflowExpression<string> auditId)
        {
            WorkflowExpression.Validate(auditId, nameof(auditId), required: true);
            return new DeferredBodyAction<GetAuditLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/audits/{0}/web_report_link", ExpressionConverter.ConvertWithUrlEncoding(auditId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAuditLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteWebReportLink))]
        public IWorkflowAction DeleteWebReportLink([WorkflowExpression] Func<string> auditId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteWebReportLink(WorkflowExpression<string> auditId)
        {
            WorkflowExpression.Validate(auditId, nameof(auditId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/audits/{0}/web_report_link", ExpressionConverter.ConvertWithUrlEncoding(auditId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [WorkflowExpressionFactory(nameof(__BuildSearchActions))]
        public IBodyWorkflowAction<ActionsSearchResponse> SearchActions([WorkflowExpression] Func<string[]> searchActionsBodyauditIDS = null, [WorkflowExpression] Func<searchActionsBodyassigneesInputItem[]> searchActionsBodyassignees = null, [WorkflowExpression] Func<string> searchActionsBodycreatedafterDate = null, [WorkflowExpression] Func<string> searchActionsBodycreatedbeforeDate = null, [WorkflowExpression] Func<string> searchActionsBodymodifiedafterDate = null, [WorkflowExpression] Func<string> searchActionsBodymodifiedbeforeDate = null, [WorkflowExpression] Func<string> searchActionsBodydueafterDate = null, [WorkflowExpression] Func<string> searchActionsBodyduebeforeDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ActionsSearchResponse> __BuildSearchActions(WorkflowExpression<string[]> searchActionsBodyauditIDS = null, WorkflowExpression<searchActionsBodyassigneesInputItem[]> searchActionsBodyassignees = null, WorkflowExpression<string> searchActionsBodycreatedafterDate = null, WorkflowExpression<string> searchActionsBodycreatedbeforeDate = null, WorkflowExpression<string> searchActionsBodymodifiedafterDate = null, WorkflowExpression<string> searchActionsBodymodifiedbeforeDate = null, WorkflowExpression<string> searchActionsBodydueafterDate = null, WorkflowExpression<string> searchActionsBodyduebeforeDate = null)
        {
            WorkflowExpression.Validate(searchActionsBodyauditIDS, nameof(searchActionsBodyauditIDS), required: false);
            WorkflowExpression.Validate(searchActionsBodyassignees, nameof(searchActionsBodyassignees), required: false);
            WorkflowExpression.Validate(searchActionsBodycreatedafterDate, nameof(searchActionsBodycreatedafterDate), required: false);
            WorkflowExpression.Validate(searchActionsBodycreatedbeforeDate, nameof(searchActionsBodycreatedbeforeDate), required: false);
            WorkflowExpression.Validate(searchActionsBodymodifiedafterDate, nameof(searchActionsBodymodifiedafterDate), required: false);
            WorkflowExpression.Validate(searchActionsBodymodifiedbeforeDate, nameof(searchActionsBodymodifiedbeforeDate), required: false);
            WorkflowExpression.Validate(searchActionsBodydueafterDate, nameof(searchActionsBodydueafterDate), required: false);
            WorkflowExpression.Validate(searchActionsBodyduebeforeDate, nameof(searchActionsBodyduebeforeDate), required: false);
            return new DeferredBodyAction<ActionsSearchResponse>(() =>
            {
                var apiCallPath = "/actions/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var searchActionsBody = new JObject();
                var searchActionsBodypropCount = 0;
                if (searchActionsBodyauditIDS != null)
                {
                    searchActionsBody["audit_id"] = ExpressionConverter.ConvertO(searchActionsBodyauditIDS);
                    searchActionsBodypropCount++;
                }

                if (searchActionsBodyassignees != null)
                {
                    searchActionsBody["assignees"] = ExpressionConverter.ConvertO(searchActionsBodyassignees);
                    searchActionsBodypropCount++;
                }

                var createdAtObject = new JObject();
                var createdAtObjectpropCount = 0;
                if (searchActionsBodycreatedafterDate != null)
                {
                    createdAtObject["from"] = ExpressionConverter.ConvertO(searchActionsBodycreatedafterDate);
                    createdAtObjectpropCount++;
                }

                if (searchActionsBodycreatedbeforeDate != null)
                {
                    createdAtObject["to"] = ExpressionConverter.ConvertO(searchActionsBodycreatedbeforeDate);
                    createdAtObjectpropCount++;
                }

                if (createdAtObjectpropCount > 0)
                {
                    searchActionsBody["created_at"] = createdAtObject;
                    searchActionsBodypropCount++;
                }

                var modifiedAtObject = new JObject();
                var modifiedAtObjectpropCount = 0;
                if (searchActionsBodymodifiedafterDate != null)
                {
                    modifiedAtObject["from"] = ExpressionConverter.ConvertO(searchActionsBodymodifiedafterDate);
                    modifiedAtObjectpropCount++;
                }

                if (searchActionsBodymodifiedbeforeDate != null)
                {
                    modifiedAtObject["to"] = ExpressionConverter.ConvertO(searchActionsBodymodifiedbeforeDate);
                    modifiedAtObjectpropCount++;
                }

                if (modifiedAtObjectpropCount > 0)
                {
                    searchActionsBody["modified_at"] = modifiedAtObject;
                    searchActionsBodypropCount++;
                }

                var dueAtObject = new JObject();
                var dueAtObjectpropCount = 0;
                if (searchActionsBodydueafterDate != null)
                {
                    dueAtObject["from"] = ExpressionConverter.ConvertO(searchActionsBodydueafterDate);
                    dueAtObjectpropCount++;
                }

                if (searchActionsBodyduebeforeDate != null)
                {
                    dueAtObject["to"] = ExpressionConverter.ConvertO(searchActionsBodyduebeforeDate);
                    dueAtObjectpropCount++;
                }

                if (dueAtObjectpropCount > 0)
                {
                    searchActionsBody["due_at"] = dueAtObject;
                    searchActionsBodypropCount++;
                }

                if (searchActionsBodypropCount > 0)
                {
                    callPayload.Body = searchActionsBody;
                }

                return new ApiConnectionAction<ActionsSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [WorkflowExpressionFactory(nameof(__BuildCreateAction))]
        public IBodyWorkflowAction<Action> CreateAction([WorkflowExpression] Func<string> createActionBodyauditID = null, [WorkflowExpression] Func<string> createActionBodyitemID = null, [WorkflowExpression] Func<string> createActionBodytitle = null, [WorkflowExpression] Func<string> createActionBodydescription = null, [WorkflowExpression] Func<createActionBodypriorityInput> createActionBodypriority = null, [WorkflowExpression] Func<createActionBodystatusInput> createActionBodystatus = null, [WorkflowExpression] Func<string> createActionBodydueAt = null, [WorkflowExpression] Func<createActionBodyassigneesInputItem[]> createActionBodyassignees = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Action> __BuildCreateAction(WorkflowExpression<string> createActionBodyauditID = null, WorkflowExpression<string> createActionBodyitemID = null, WorkflowExpression<string> createActionBodytitle = null, WorkflowExpression<string> createActionBodydescription = null, WorkflowExpression<createActionBodypriorityInput> createActionBodypriority = null, WorkflowExpression<createActionBodystatusInput> createActionBodystatus = null, WorkflowExpression<string> createActionBodydueAt = null, WorkflowExpression<createActionBodyassigneesInputItem[]> createActionBodyassignees = null)
        {
            WorkflowExpression.Validate(createActionBodyauditID, nameof(createActionBodyauditID), required: false);
            WorkflowExpression.Validate(createActionBodyitemID, nameof(createActionBodyitemID), required: false);
            WorkflowExpression.Validate(createActionBodytitle, nameof(createActionBodytitle), required: false);
            WorkflowExpression.Validate(createActionBodydescription, nameof(createActionBodydescription), required: false);
            WorkflowExpression.Validate(createActionBodypriority, nameof(createActionBodypriority), required: false);
            WorkflowExpression.Validate(createActionBodystatus, nameof(createActionBodystatus), required: false);
            WorkflowExpression.Validate(createActionBodydueAt, nameof(createActionBodydueAt), required: false);
            WorkflowExpression.Validate(createActionBodyassignees, nameof(createActionBodyassignees), required: false);
            return new DeferredBodyAction<Action>(() =>
            {
                var apiCallPath = "/actions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var createActionBody = new JObject();
                var createActionBodypropCount = 0;
                if (createActionBodyauditID != null)
                {
                    createActionBody["audit_id"] = ExpressionConverter.ConvertO(createActionBodyauditID);
                    createActionBodypropCount++;
                }

                if (createActionBodyitemID != null)
                {
                    createActionBody["item_id"] = ExpressionConverter.ConvertO(createActionBodyitemID);
                    createActionBodypropCount++;
                }

                if (createActionBodytitle != null)
                {
                    createActionBody["title"] = ExpressionConverter.ConvertO(createActionBodytitle);
                    createActionBodypropCount++;
                }

                if (createActionBodydescription != null)
                {
                    createActionBody["description"] = ExpressionConverter.ConvertO(createActionBodydescription);
                    createActionBodypropCount++;
                }

                if (createActionBodypriority != null)
                {
                    createActionBody["priority"] = ExpressionConverter.ConvertO(createActionBodypriority);
                    createActionBodypropCount++;
                }

                if (createActionBodystatus != null)
                {
                    createActionBody["status"] = ExpressionConverter.ConvertO(createActionBodystatus);
                    createActionBodypropCount++;
                }

                if (createActionBodydueAt != null)
                {
                    createActionBody["due_at"] = ExpressionConverter.ConvertO(createActionBodydueAt);
                    createActionBodypropCount++;
                }

                if (createActionBodyassignees != null)
                {
                    createActionBody["assignees"] = ExpressionConverter.ConvertO(createActionBodyassignees);
                    createActionBodypropCount++;
                }

                if (createActionBodypropCount > 0)
                {
                    callPayload.Body = createActionBody;
                }

                return new ApiConnectionAction<Action>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteAction))]
        public IBodyWorkflowAction<DeleteActionResponse> DeleteAction([WorkflowExpression] Func<string> actionId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteActionResponse> __BuildDeleteAction(WorkflowExpression<string> actionId)
        {
            WorkflowExpression.Validate(actionId, nameof(actionId), required: true);
            return new DeferredBodyAction<DeleteActionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/actions/{0}", ExpressionConverter.ConvertWithUrlEncoding(actionId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteActionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateAction))]
        public IBodyWorkflowAction<Action> UpdateAction([WorkflowExpression] Func<string> actionId, [WorkflowExpression] Func<string> updateActionBodytitle = null, [WorkflowExpression] Func<string> updateActionBodydescription = null, [WorkflowExpression] Func<updateActionBodypriorityInput> updateActionBodypriority = null, [WorkflowExpression] Func<updateActionBodystatusInput> updateActionBodystatus = null, [WorkflowExpression] Func<string> updateActionBodydueAt = null, [WorkflowExpression] Func<updateActionBodyassigneesInputItem[]> updateActionBodyassignees = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Action> __BuildUpdateAction(WorkflowExpression<string> actionId, WorkflowExpression<string> updateActionBodytitle = null, WorkflowExpression<string> updateActionBodydescription = null, WorkflowExpression<updateActionBodypriorityInput> updateActionBodypriority = null, WorkflowExpression<updateActionBodystatusInput> updateActionBodystatus = null, WorkflowExpression<string> updateActionBodydueAt = null, WorkflowExpression<updateActionBodyassigneesInputItem[]> updateActionBodyassignees = null)
        {
            WorkflowExpression.Validate(actionId, nameof(actionId), required: true);
            WorkflowExpression.Validate(updateActionBodytitle, nameof(updateActionBodytitle), required: false);
            WorkflowExpression.Validate(updateActionBodydescription, nameof(updateActionBodydescription), required: false);
            WorkflowExpression.Validate(updateActionBodypriority, nameof(updateActionBodypriority), required: false);
            WorkflowExpression.Validate(updateActionBodystatus, nameof(updateActionBodystatus), required: false);
            WorkflowExpression.Validate(updateActionBodydueAt, nameof(updateActionBodydueAt), required: false);
            WorkflowExpression.Validate(updateActionBodyassignees, nameof(updateActionBodyassignees), required: false);
            return new DeferredBodyAction<Action>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/actions/{0}", ExpressionConverter.ConvertWithUrlEncoding(actionId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var updateActionBody = new JObject();
                var updateActionBodypropCount = 0;
                if (updateActionBodytitle != null)
                {
                    updateActionBody["title"] = ExpressionConverter.ConvertO(updateActionBodytitle);
                    updateActionBodypropCount++;
                }

                if (updateActionBodydescription != null)
                {
                    updateActionBody["description"] = ExpressionConverter.ConvertO(updateActionBodydescription);
                    updateActionBodypropCount++;
                }

                if (updateActionBodypriority != null)
                {
                    updateActionBody["priority"] = ExpressionConverter.ConvertO(updateActionBodypriority);
                    updateActionBodypropCount++;
                }

                if (updateActionBodystatus != null)
                {
                    updateActionBody["status"] = ExpressionConverter.ConvertO(updateActionBodystatus);
                    updateActionBodypropCount++;
                }

                if (updateActionBodydueAt != null)
                {
                    updateActionBody["due_at"] = ExpressionConverter.ConvertO(updateActionBodydueAt);
                    updateActionBodypropCount++;
                }

                if (updateActionBodyassignees != null)
                {
                    updateActionBody["assignees"] = ExpressionConverter.ConvertO(updateActionBodyassignees);
                    updateActionBodypropCount++;
                }

                if (updateActionBodypropCount > 0)
                {
                    callPayload.Body = updateActionBody;
                }

                return new ApiConnectionAction<Action>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [WorkflowExpressionFactory(nameof(__BuildGetMedia))]
        public IBodyWorkflowAction<string> GetMedia([WorkflowExpression] Func<string> auditId, [WorkflowExpression] Func<string> mediaId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetMedia(WorkflowExpression<string> auditId, WorkflowExpression<string> mediaId)
        {
            WorkflowExpression.Validate(auditId, nameof(auditId), required: true);
            WorkflowExpression.Validate(mediaId, nameof(mediaId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/audits/{0}/media/{1}", ExpressionConverter.ConvertWithUrlEncoding(auditId, 1), ExpressionConverter.ConvertWithUrlEncoding(mediaId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [WorkflowExpressionFactory(nameof(__BuildInitiateInspectionExport))]
        public IBodyWorkflowAction<InitInspectionExportResponse> InitiateInspectionExport([WorkflowExpression] Func<string> auditId, [WorkflowExpression] Func<formatexportFormatInput> formatexportFormat = null, [WorkflowExpression] Func<string> formatpreferenceID = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InitInspectionExportResponse> __BuildInitiateInspectionExport(WorkflowExpression<string> auditId, WorkflowExpression<formatexportFormatInput> formatexportFormat = null, WorkflowExpression<string> formatpreferenceID = null)
        {
            WorkflowExpression.Validate(auditId, nameof(auditId), required: true);
            WorkflowExpression.Validate(formatexportFormat, nameof(formatexportFormat), required: false);
            WorkflowExpression.Validate(formatpreferenceID, nameof(formatpreferenceID), required: false);
            return new DeferredBodyAction<InitInspectionExportResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/audits/{0}/report", ExpressionConverter.ConvertWithUrlEncoding(auditId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var format = new JObject();
                var formatpropCount = 0;
                if (formatexportFormat != null)
                {
                    if (formatexportFormat != null)
                    {
                        format["format"] = ExpressionConverter.ConvertO(formatexportFormat);
                        formatpropCount++;
                    }

                    formatpropCount++;
                }
                else
                {
                    format["format"] = "PDF";
                    formatpropCount++;
                }

                if (formatpreferenceID != null)
                {
                    format["preference_id"] = ExpressionConverter.ConvertO(formatpreferenceID);
                    formatpropCount++;
                }

                if (formatpropCount > 0)
                {
                    callPayload.Body = format;
                }

                return new ApiConnectionAction<InitInspectionExportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [WorkflowExpressionFactory(nameof(__BuildPollInspectionExportStatus))]
        public IBodyWorkflowAction<InspectionExportStatusResponse> PollInspectionExportStatus([WorkflowExpression] Func<string> auditId, [WorkflowExpression] Func<string> exportId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InspectionExportStatusResponse> __BuildPollInspectionExportStatus(WorkflowExpression<string> auditId, WorkflowExpression<string> exportId)
        {
            WorkflowExpression.Validate(auditId, nameof(auditId), required: true);
            WorkflowExpression.Validate(exportId, nameof(exportId), required: true);
            return new DeferredBodyAction<InspectionExportStatusResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/audits/{0}/report/{1}", ExpressionConverter.ConvertWithUrlEncoding(auditId, 1), ExpressionConverter.ConvertWithUrlEncoding(exportId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<InspectionExportStatusResponse>(callPayload);
            });
        }
    }

    public class SafetycultureTriggers([ConnectionName] string connectionId)
    {
    }

    public class AuditSearchResponse
    {
        [JsonProperty("count")]
        public double Count { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("audits")]
        public AuditSearchResponseInspectionTypeItem[] Inspection { get; set; }
    }

    public class AuditSearchResponseInspectionTypeItem
    {
        [JsonProperty("audit_id")]
        public string AuditID { get; set; }

        [JsonProperty("modified_at")]
        public string DateModified { get; set; }

        [JsonProperty("template_id")]
        public string TemplateID { get; set; }
    }

    public enum orderInput
    {
        [EnumMember(Value = "desc")]
        Desc,
        [EnumMember(Value = "asc")]
        Asc
    }

    public enum archivedInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "both")]
        Both
    }

    public enum completedInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "both")]
        Both
    }

    public enum ownerInput
    {
        [EnumMember(Value = "me")]
        Me,
        [EnumMember(Value = "other")]
        Other,
        [EnumMember(Value = "all")]
        All
    }

    public class GetAuditByIdResponse
    {
        [JsonProperty("template_id")]
        public string TemplateID { get; set; }

        [JsonProperty("audit_id")]
        public string AuditID { get; set; }

        [JsonProperty("audit_data")]
        public GetAuditByIdResponseAuditDataType AuditData { get; set; }

        [JsonProperty("template_data")]
        public GetAuditByIdResponseTemplateDataType TemplateData { get; set; }
    }

    public class GetAuditByIdResponseAuditDataType
    {
        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("total_score")]
        public double TotalScore { get; set; }

        [JsonProperty("score_percentage")]
        public double ScorePercentage { get; set; }

        [JsonProperty("name")]
        public string InspectionTitle { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("authorship")]
        public GetAuditByIdResponseAuditDataTypeAuthorshipType Authorship { get; set; }

        [JsonProperty("date_completed")]
        public string DateCompleted { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("date_started")]
        public string DateStarted { get; set; }
    }

    public class GetAuditByIdResponseAuditDataTypeAuthorshipType
    {
        [JsonProperty("owner")]
        public string InspectionOwner { get; set; }

        [JsonProperty("owner_id")]
        public string InspectionOwnerID { get; set; }

        [JsonProperty("author")]
        public string InspectionAuthor { get; set; }

        [JsonProperty("author_id")]
        public string InspectionAuthorID { get; set; }
    }

    public class GetAuditByIdResponseTemplateDataType
    {
        [JsonProperty("authorship")]
        public GetAuditByIdResponseTemplateDataTypeAuthorshipType Authorship { get; set; }

        [JsonProperty("metadata")]
        public GetAuditByIdResponseTemplateDataTypeMetadataType Metadata { get; set; }
    }

    public class GetAuditByIdResponseTemplateDataTypeAuthorshipType
    {
        [JsonProperty("owner")]
        public string TemplateOwner { get; set; }

        [JsonProperty("owner_id")]
        public string TemplateOwnerID { get; set; }

        [JsonProperty("author")]
        public string TemplateAuthor { get; set; }

        [JsonProperty("author_id")]
        public string TemplateAuthorID { get; set; }
    }

    public class GetAuditByIdResponseTemplateDataTypeMetadataType
    {
        [JsonProperty("description")]
        public string TemplateDescription { get; set; }

        [JsonProperty("name")]
        public string TemplateName { get; set; }
    }

    public class InitExportResponse
    {
        [JsonProperty("id")]
        public string ExportTaskID { get; set; }
    }

    public enum formatInput
    {
        [EnumMember(Value = "pdf")]
        Pdf,
        [EnumMember(Value = "docx")]
        Docx
    }

    public enum timezoneInput
    {
        [EnumMember(Value = "Pacific/Auckland")]
        PacificAuckland,
        [EnumMember(Value = "Australia/Brisbane")]
        AustraliaBrisbane,
        [EnumMember(Value = "Asia/Tokyo")]
        AsiaTokyo,
        [EnumMember(Value = "Asia/Shanghai")]
        AsiaShanghai,
        [EnumMember(Value = "Asia/Karachi")]
        AsiaKarachi,
        [EnumMember(Value = "Europe/Moscow")]
        EuropeMoscow,
        [EnumMember(Value = "Europe/Brussels")]
        EuropeBrussels,
        [EnumMember(Value = "Europe/London")]
        EuropeLondon,
        [EnumMember(Value = "America/St_Johns")]
        AmericaStJohns,
        [EnumMember(Value = "America/Argentina/Buenos_Aires")]
        AmericaArgentinaBuenosAires,
        [EnumMember(Value = "America/New_York")]
        AmericaNewYork,
        [EnumMember(Value = "America/Mexico_City")]
        AmericaMexicoCity,
        [EnumMember(Value = "America/Guatemala")]
        AmericaGuatemala,
        [EnumMember(Value = "Etc/UTC")]
        EtcUTC
    }

    public class ExportStatusResponse
    {
        [JsonProperty("status")]
        public string ExportStatus { get; set; }

        [JsonProperty("href")]
        public string ExportURL { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }
    }

    public class GetAuditLinkResponse
    {
        [JsonProperty("url")]
        public string InspectionLink { get; set; }
    }

    public class ActionsSearchResponse
    {
        [JsonProperty("count")]
        public double Count { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("offset")]
        public double Offset { get; set; }

        [JsonProperty("actions")]
        public Action[] Actions { get; set; }
    }

    public class Action
    {
        [JsonProperty("action_id")]
        public string ActionId { get; set; }

        [JsonProperty("audit")]
        public ActionInspectionType Inspection { get; set; }

        [JsonProperty("item")]
        public ActionItemType Item { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("site")]
        public string Site { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("assignees")]
        public ActionAssigneesTypeItem[] Assignees { get; set; }

        [JsonProperty("created_by")]
        public ActionCreatedByType CreatedBy { get; set; }

        [JsonProperty("created_at")]
        public string CreationDate { get; set; }

        [JsonProperty("modified_at")]
        public string ModificationDate { get; set; }

        [JsonProperty("due_at")]
        public string DueDate { get; set; }

        [JsonProperty("completed_at")]
        public string CompletionDate { get; set; }
    }

    public class ActionInspectionType
    {
        [JsonProperty("audit_id")]
        public string AuditID { get; set; }

        [JsonProperty("name")]
        public string InspectionTitle { get; set; }
    }

    public class ActionItemType
    {
        [JsonProperty("item_id")]
        public string ItemID { get; set; }

        [JsonProperty("label")]
        public string ItemLabel { get; set; }
    }

    public class ActionAssigneesTypeItem
    {
        [JsonProperty("id")]
        public string AssigneeID { get; set; }

        [JsonProperty("name")]
        public string AssigneeName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ActionCreatedByType
    {
        [JsonProperty("user_id")]
        public string CreatorID { get; set; }

        [JsonProperty("name")]
        public string CreatorName { get; set; }
    }

    public class searchActionsBodyassigneesInputItem
    {
        [JsonProperty("id")]
        public string AssigneeID { get; set; }

        [JsonProperty("type")]
        public searchActionsBodyassigneesInputItemTypeType Type { get; set; }
    }

    public enum searchActionsBodyassigneesInputItemTypeType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "email")]
        Email
    }

    public enum createActionBodypriorityInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "20")]
        _20,
        [EnumMember(Value = "30")]
        _30
    }

    public enum createActionBodystatusInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "50")]
        _50,
        [EnumMember(Value = "60")]
        _60
    }

    public class createActionBodyassigneesInputItem
    {
        [JsonProperty("id")]
        public string AssigneeID { get; set; }

        [JsonProperty("type")]
        public createActionBodyassigneesInputItemTypeType Type { get; set; }
    }

    public enum createActionBodyassigneesInputItemTypeType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "email")]
        Email
    }

    public class DeleteActionResponse
    {
        [JsonProperty("ok")]
        public bool Ok { get; set; }
    }

    public enum updateActionBodypriorityInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "20")]
        _20,
        [EnumMember(Value = "30")]
        _30
    }

    public enum updateActionBodystatusInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "50")]
        _50,
        [EnumMember(Value = "60")]
        _60
    }

    public class updateActionBodyassigneesInputItem
    {
        [JsonProperty("id")]
        public string AssigneeID { get; set; }

        [JsonProperty("type")]
        public updateActionBodyassigneesInputItemTypeType Type { get; set; }
    }

    public enum updateActionBodyassigneesInputItemTypeType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "email")]
        Email
    }

    public class InitInspectionExportResponse
    {
        [JsonProperty("messageId")]
        public string ExportTaskID { get; set; }
    }

    public enum formatexportFormatInput
    {
        PDF,
        WORD
    }

    public class InspectionExportStatusResponse
    {
        [JsonProperty("url")]
        public string ExportURL { get; set; }

        [JsonProperty("status")]
        public string ExportStatus { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Safetyculture;

    public partial class WorkflowManagedActions
    {
        public SafetycultureActions Safetyculture(string connectionId) => new SafetycultureActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SafetycultureTriggers Safetyculture(string connectionId) => new SafetycultureTriggers(connectionId);
    }
}