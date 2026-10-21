//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Safetyculture
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SafetycultureActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<AuditSearchResponse> SearchAudits(Expression<Func<orderInput>> order = null, Expression<Func<string>> modifiedAfter = null, Expression<Func<string>> modifiedBefore = null, Expression<Func<string>> template = null, Expression<Func<archivedInput>> archived = null, Expression<Func<completedInput>> completed = null, Expression<Func<ownerInput>> owner = null, Expression<Func<int>> limit = null)
        {
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_modifiedAfter = WorkflowExpression.Compile(modifiedAfter, nameof(modifiedAfter), required: false);
            var __workflow_modifiedBefore = WorkflowExpression.Compile(modifiedBefore, nameof(modifiedBefore), required: false);
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_completed = WorkflowExpression.Compile(completed, nameof(completed), required: false);
            var __workflow_owner = WorkflowExpression.Compile(owner, nameof(owner), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<AuditSearchResponse>(() =>
            {
                var apiCallPath = "/audits/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["order"] = Convert.ToString("desc");
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_modifiedAfter != null)
                    callPayload.Queries["modified_after"] = ExpressionConverter.Convert(__workflow_modifiedAfter);
                if (__workflow_modifiedBefore != null)
                    callPayload.Queries["modified_before"] = ExpressionConverter.Convert(__workflow_modifiedBefore);
                if (__workflow_template != null)
                    callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                callPayload.Queries["archived"] = Convert.ToString("false");
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                callPayload.Queries["completed"] = Convert.ToString("true");
                if (__workflow_completed != null)
                    callPayload.Queries["completed"] = ExpressionConverter.Convert(__workflow_completed);
                callPayload.Queries["owner"] = Convert.ToString("all");
                if (__workflow_owner != null)
                    callPayload.Queries["owner"] = ExpressionConverter.Convert(__workflow_owner);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<AuditSearchResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<GetAuditByIdResponse> GetAuditById(Expression<Func<string>> auditId)
        {
            var __workflow_auditId = WorkflowExpression.Compile(auditId, nameof(auditId), required: true);
            return new DeferredBodyAction<GetAuditByIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audits/{0}", __workflow_auditId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAuditByIdResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<GetAuditByIdResponse> ArchiveRestoreAudit(Expression<Func<string>> auditId, Expression<Func<bool>> bodyarchived = null)
        {
            var __workflow_auditId = WorkflowExpression.Compile(auditId, nameof(auditId), required: true);
            var __workflow_bodyarchived = WorkflowExpression.Compile(bodyarchived, nameof(bodyarchived), required: false);
            return new DeferredBodyAction<GetAuditByIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audits/{0}", __workflow_auditId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyarchived != null)
                {
                    body["archived"] = ExpressionConverter.ConvertO(__workflow_bodyarchived);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetAuditByIdResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<InitExportResponse> InitiateAuditExport(Expression<Func<string>> auditId, Expression<Func<formatInput>> format, Expression<Func<timezoneInput>> timezone = null, Expression<Func<string>> exportProfile = null)
        {
            var __workflow_auditId = WorkflowExpression.Compile(auditId, nameof(auditId), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_timezone = WorkflowExpression.Compile(timezone, nameof(timezone), required: false);
            var __workflow_exportProfile = WorkflowExpression.Compile(exportProfile, nameof(exportProfile), required: false);
            return new DeferredBodyAction<InitExportResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audits/{0}/export", __workflow_auditId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Queries["timezone"] = Convert.ToString("Etc/UTC");
                if (__workflow_timezone != null)
                    callPayload.Queries["timezone"] = ExpressionConverter.Convert(__workflow_timezone);
                if (__workflow_exportProfile != null)
                    callPayload.Queries["export_profile"] = ExpressionConverter.Convert(__workflow_exportProfile);
                return new ApiConnectionAction<InitExportResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<ExportStatusResponse> PollExportStatus(Expression<Func<string>> auditId, Expression<Func<string>> exportId)
        {
            var __workflow_auditId = WorkflowExpression.Compile(auditId, nameof(auditId), required: true);
            var __workflow_exportId = WorkflowExpression.Compile(exportId, nameof(exportId), required: true);
            return new DeferredBodyAction<ExportStatusResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audits/{0}/exports/{1}", __workflow_auditId.WithUrlEncoding(1), __workflow_exportId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ExportStatusResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<string> GetAuditExport(Expression<Func<string>> auditId, Expression<Func<string>> exportId, Expression<Func<string>> filename)
        {
            var __workflow_auditId = WorkflowExpression.Compile(auditId, nameof(auditId), required: true);
            var __workflow_exportId = WorkflowExpression.Compile(exportId, nameof(exportId), required: true);
            var __workflow_filename = WorkflowExpression.Compile(filename, nameof(filename), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audits/{0}/exports/{1}/{2}", __workflow_auditId.WithUrlEncoding(1), __workflow_exportId.WithUrlEncoding(1), __workflow_filename.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<GetAuditLinkResponse> GetWebReportLink(Expression<Func<string>> auditId)
        {
            var __workflow_auditId = WorkflowExpression.Compile(auditId, nameof(auditId), required: true);
            return new DeferredBodyAction<GetAuditLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audits/{0}/web_report_link", __workflow_auditId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAuditLinkResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IWorkflowAction DeleteWebReportLink(Expression<Func<string>> auditId)
        {
            var __workflow_auditId = WorkflowExpression.Compile(auditId, nameof(auditId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audits/{0}/web_report_link", __workflow_auditId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<ActionsSearchResponse> SearchActions(Expression<Func<string[]>> searchActionsBodyauditIDS = null, Expression<Func<searchActionsBodyassigneesInputItem[]>> searchActionsBodyassignees = null, Expression<Func<string>> searchActionsBodycreatedafterDate = null, Expression<Func<string>> searchActionsBodycreatedbeforeDate = null, Expression<Func<string>> searchActionsBodymodifiedafterDate = null, Expression<Func<string>> searchActionsBodymodifiedbeforeDate = null, Expression<Func<string>> searchActionsBodydueafterDate = null, Expression<Func<string>> searchActionsBodyduebeforeDate = null)
        {
            var __workflow_searchActionsBodyauditIDS = WorkflowExpression.Compile(searchActionsBodyauditIDS, nameof(searchActionsBodyauditIDS), required: false);
            var __workflow_searchActionsBodyassignees = WorkflowExpression.Compile(searchActionsBodyassignees, nameof(searchActionsBodyassignees), required: false);
            var __workflow_searchActionsBodycreatedafterDate = WorkflowExpression.Compile(searchActionsBodycreatedafterDate, nameof(searchActionsBodycreatedafterDate), required: false);
            var __workflow_searchActionsBodycreatedbeforeDate = WorkflowExpression.Compile(searchActionsBodycreatedbeforeDate, nameof(searchActionsBodycreatedbeforeDate), required: false);
            var __workflow_searchActionsBodymodifiedafterDate = WorkflowExpression.Compile(searchActionsBodymodifiedafterDate, nameof(searchActionsBodymodifiedafterDate), required: false);
            var __workflow_searchActionsBodymodifiedbeforeDate = WorkflowExpression.Compile(searchActionsBodymodifiedbeforeDate, nameof(searchActionsBodymodifiedbeforeDate), required: false);
            var __workflow_searchActionsBodydueafterDate = WorkflowExpression.Compile(searchActionsBodydueafterDate, nameof(searchActionsBodydueafterDate), required: false);
            var __workflow_searchActionsBodyduebeforeDate = WorkflowExpression.Compile(searchActionsBodyduebeforeDate, nameof(searchActionsBodyduebeforeDate), required: false);
            return new DeferredBodyAction<ActionsSearchResponse>(() =>
            {
                var apiCallPath = "/actions/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var searchActionsBody = new JObject();
                var searchActionsBodypropCount = 0;
                if (__workflow_searchActionsBodyauditIDS != null)
                {
                    searchActionsBody["audit_id"] = ExpressionConverter.ConvertO(__workflow_searchActionsBodyauditIDS);
                    searchActionsBodypropCount++;
                }

                if (__workflow_searchActionsBodyassignees != null)
                {
                    searchActionsBody["assignees"] = ExpressionConverter.ConvertO(__workflow_searchActionsBodyassignees);
                    searchActionsBodypropCount++;
                }

                var createdAtObject = new JObject();
                var createdAtObjectpropCount = 0;
                if (__workflow_searchActionsBodycreatedafterDate != null)
                {
                    createdAtObject["from"] = ExpressionConverter.ConvertO(__workflow_searchActionsBodycreatedafterDate);
                    createdAtObjectpropCount++;
                }

                if (__workflow_searchActionsBodycreatedbeforeDate != null)
                {
                    createdAtObject["to"] = ExpressionConverter.ConvertO(__workflow_searchActionsBodycreatedbeforeDate);
                    createdAtObjectpropCount++;
                }

                if (createdAtObjectpropCount > 0)
                {
                    searchActionsBody["created_at"] = createdAtObject;
                    searchActionsBodypropCount++;
                }

                var modifiedAtObject = new JObject();
                var modifiedAtObjectpropCount = 0;
                if (__workflow_searchActionsBodymodifiedafterDate != null)
                {
                    modifiedAtObject["from"] = ExpressionConverter.ConvertO(__workflow_searchActionsBodymodifiedafterDate);
                    modifiedAtObjectpropCount++;
                }

                if (__workflow_searchActionsBodymodifiedbeforeDate != null)
                {
                    modifiedAtObject["to"] = ExpressionConverter.ConvertO(__workflow_searchActionsBodymodifiedbeforeDate);
                    modifiedAtObjectpropCount++;
                }

                if (modifiedAtObjectpropCount > 0)
                {
                    searchActionsBody["modified_at"] = modifiedAtObject;
                    searchActionsBodypropCount++;
                }

                var dueAtObject = new JObject();
                var dueAtObjectpropCount = 0;
                if (__workflow_searchActionsBodydueafterDate != null)
                {
                    dueAtObject["from"] = ExpressionConverter.ConvertO(__workflow_searchActionsBodydueafterDate);
                    dueAtObjectpropCount++;
                }

                if (__workflow_searchActionsBodyduebeforeDate != null)
                {
                    dueAtObject["to"] = ExpressionConverter.ConvertO(__workflow_searchActionsBodyduebeforeDate);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<Action> CreateAction(Expression<Func<string>> createActionBodyauditID = null, Expression<Func<string>> createActionBodyitemID = null, Expression<Func<string>> createActionBodytitle = null, Expression<Func<string>> createActionBodydescription = null, Expression<Func<createActionBodypriorityInput>> createActionBodypriority = null, Expression<Func<createActionBodystatusInput>> createActionBodystatus = null, Expression<Func<string>> createActionBodydueAt = null, Expression<Func<createActionBodyassigneesInputItem[]>> createActionBodyassignees = null)
        {
            var __workflow_createActionBodyauditID = WorkflowExpression.Compile(createActionBodyauditID, nameof(createActionBodyauditID), required: false);
            var __workflow_createActionBodyitemID = WorkflowExpression.Compile(createActionBodyitemID, nameof(createActionBodyitemID), required: false);
            var __workflow_createActionBodytitle = WorkflowExpression.Compile(createActionBodytitle, nameof(createActionBodytitle), required: false);
            var __workflow_createActionBodydescription = WorkflowExpression.Compile(createActionBodydescription, nameof(createActionBodydescription), required: false);
            var __workflow_createActionBodypriority = WorkflowExpression.Compile(createActionBodypriority, nameof(createActionBodypriority), required: false);
            var __workflow_createActionBodystatus = WorkflowExpression.Compile(createActionBodystatus, nameof(createActionBodystatus), required: false);
            var __workflow_createActionBodydueAt = WorkflowExpression.Compile(createActionBodydueAt, nameof(createActionBodydueAt), required: false);
            var __workflow_createActionBodyassignees = WorkflowExpression.Compile(createActionBodyassignees, nameof(createActionBodyassignees), required: false);
            return new DeferredBodyAction<Action>(() =>
            {
                var apiCallPath = "/actions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var createActionBody = new JObject();
                var createActionBodypropCount = 0;
                if (__workflow_createActionBodyauditID != null)
                {
                    createActionBody["audit_id"] = ExpressionConverter.ConvertO(__workflow_createActionBodyauditID);
                    createActionBodypropCount++;
                }

                if (__workflow_createActionBodyitemID != null)
                {
                    createActionBody["item_id"] = ExpressionConverter.ConvertO(__workflow_createActionBodyitemID);
                    createActionBodypropCount++;
                }

                if (__workflow_createActionBodytitle != null)
                {
                    createActionBody["title"] = ExpressionConverter.ConvertO(__workflow_createActionBodytitle);
                    createActionBodypropCount++;
                }

                if (__workflow_createActionBodydescription != null)
                {
                    createActionBody["description"] = ExpressionConverter.ConvertO(__workflow_createActionBodydescription);
                    createActionBodypropCount++;
                }

                if (__workflow_createActionBodypriority != null)
                {
                    createActionBody["priority"] = ExpressionConverter.ConvertO(__workflow_createActionBodypriority);
                    createActionBodypropCount++;
                }

                if (__workflow_createActionBodystatus != null)
                {
                    createActionBody["status"] = ExpressionConverter.ConvertO(__workflow_createActionBodystatus);
                    createActionBodypropCount++;
                }

                if (__workflow_createActionBodydueAt != null)
                {
                    createActionBody["due_at"] = ExpressionConverter.ConvertO(__workflow_createActionBodydueAt);
                    createActionBodypropCount++;
                }

                if (__workflow_createActionBodyassignees != null)
                {
                    createActionBody["assignees"] = ExpressionConverter.ConvertO(__workflow_createActionBodyassignees);
                    createActionBodypropCount++;
                }

                if (createActionBodypropCount > 0)
                {
                    callPayload.Body = createActionBody;
                }

                return new ApiConnectionAction<Action>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<DeleteActionResponse> DeleteAction(Expression<Func<string>> actionId)
        {
            var __workflow_actionId = WorkflowExpression.Compile(actionId, nameof(actionId), required: true);
            return new DeferredBodyAction<DeleteActionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/actions/{0}", __workflow_actionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteActionResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<Action> UpdateAction(Expression<Func<string>> actionId, Expression<Func<string>> updateActionBodytitle = null, Expression<Func<string>> updateActionBodydescription = null, Expression<Func<updateActionBodypriorityInput>> updateActionBodypriority = null, Expression<Func<updateActionBodystatusInput>> updateActionBodystatus = null, Expression<Func<string>> updateActionBodydueAt = null, Expression<Func<updateActionBodyassigneesInputItem[]>> updateActionBodyassignees = null)
        {
            var __workflow_actionId = WorkflowExpression.Compile(actionId, nameof(actionId), required: true);
            var __workflow_updateActionBodytitle = WorkflowExpression.Compile(updateActionBodytitle, nameof(updateActionBodytitle), required: false);
            var __workflow_updateActionBodydescription = WorkflowExpression.Compile(updateActionBodydescription, nameof(updateActionBodydescription), required: false);
            var __workflow_updateActionBodypriority = WorkflowExpression.Compile(updateActionBodypriority, nameof(updateActionBodypriority), required: false);
            var __workflow_updateActionBodystatus = WorkflowExpression.Compile(updateActionBodystatus, nameof(updateActionBodystatus), required: false);
            var __workflow_updateActionBodydueAt = WorkflowExpression.Compile(updateActionBodydueAt, nameof(updateActionBodydueAt), required: false);
            var __workflow_updateActionBodyassignees = WorkflowExpression.Compile(updateActionBodyassignees, nameof(updateActionBodyassignees), required: false);
            return new DeferredBodyAction<Action>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/actions/{0}", __workflow_actionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var updateActionBody = new JObject();
                var updateActionBodypropCount = 0;
                if (__workflow_updateActionBodytitle != null)
                {
                    updateActionBody["title"] = ExpressionConverter.ConvertO(__workflow_updateActionBodytitle);
                    updateActionBodypropCount++;
                }

                if (__workflow_updateActionBodydescription != null)
                {
                    updateActionBody["description"] = ExpressionConverter.ConvertO(__workflow_updateActionBodydescription);
                    updateActionBodypropCount++;
                }

                if (__workflow_updateActionBodypriority != null)
                {
                    updateActionBody["priority"] = ExpressionConverter.ConvertO(__workflow_updateActionBodypriority);
                    updateActionBodypropCount++;
                }

                if (__workflow_updateActionBodystatus != null)
                {
                    updateActionBody["status"] = ExpressionConverter.ConvertO(__workflow_updateActionBodystatus);
                    updateActionBodypropCount++;
                }

                if (__workflow_updateActionBodydueAt != null)
                {
                    updateActionBody["due_at"] = ExpressionConverter.ConvertO(__workflow_updateActionBodydueAt);
                    updateActionBodypropCount++;
                }

                if (__workflow_updateActionBodyassignees != null)
                {
                    updateActionBody["assignees"] = ExpressionConverter.ConvertO(__workflow_updateActionBodyassignees);
                    updateActionBodypropCount++;
                }

                if (updateActionBodypropCount > 0)
                {
                    callPayload.Body = updateActionBody;
                }

                return new ApiConnectionAction<Action>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<string> GetMedia(Expression<Func<string>> auditId, Expression<Func<string>> mediaId)
        {
            var __workflow_auditId = WorkflowExpression.Compile(auditId, nameof(auditId), required: true);
            var __workflow_mediaId = WorkflowExpression.Compile(mediaId, nameof(mediaId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audits/{0}/media/{1}", __workflow_auditId.WithUrlEncoding(1), __workflow_mediaId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<InitInspectionExportResponse> InitiateInspectionExport(Expression<Func<string>> auditId, Expression<Func<formatexportFormatInput>> formatexportFormat = null, Expression<Func<string>> formatpreferenceID = null)
        {
            var __workflow_auditId = WorkflowExpression.Compile(auditId, nameof(auditId), required: true);
            var __workflow_formatexportFormat = WorkflowExpression.Compile(formatexportFormat, nameof(formatexportFormat), required: false);
            var __workflow_formatpreferenceID = WorkflowExpression.Compile(formatpreferenceID, nameof(formatpreferenceID), required: false);
            return new DeferredBodyAction<InitInspectionExportResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audits/{0}/report", __workflow_auditId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var format = new JObject();
                var formatpropCount = 0;
                if (__workflow_formatexportFormat != null)
                {
                    if (__workflow_formatexportFormat != null)
                    {
                        format["format"] = ExpressionConverter.ConvertO(__workflow_formatexportFormat);
                        formatpropCount++;
                    }

                    formatpropCount++;
                }
                else
                {
                    format["format"] = "PDF";
                    formatpropCount++;
                }

                if (__workflow_formatpreferenceID != null)
                {
                    format["preference_id"] = ExpressionConverter.ConvertO(__workflow_formatpreferenceID);
                    formatpropCount++;
                }

                if (formatpropCount > 0)
                {
                    callPayload.Body = format;
                }

                return new ApiConnectionAction<InitInspectionExportResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<InspectionExportStatusResponse> PollInspectionExportStatus(Expression<Func<string>> auditId, Expression<Func<string>> exportId)
        {
            var __workflow_auditId = WorkflowExpression.Compile(auditId, nameof(auditId), required: true);
            var __workflow_exportId = WorkflowExpression.Compile(exportId, nameof(exportId), required: true);
            return new DeferredBodyAction<InspectionExportStatusResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audits/{0}/report/{1}", __workflow_auditId.WithUrlEncoding(1), __workflow_exportId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<InspectionExportStatusResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum orderInput
    {
        [EnumMember(Value = "desc")]
        Desc,
        [EnumMember(Value = "asc")]
        Asc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum archivedInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "both")]
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum completedInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "both")]
        Both
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum formatInput
    {
        [EnumMember(Value = "pdf")]
        Pdf,
        [EnumMember(Value = "docx")]
        Docx
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum searchActionsBodyassigneesInputItemTypeType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "email")]
        Email
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
