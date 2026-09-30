//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Safetyculture
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SafetycultureActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<AuditSearchResponse> SearchAudits([WorkflowExpression] Func<orderInput> order = null, [WorkflowExpression] Func<string> modifiedAfter = null, [WorkflowExpression] Func<string> modifiedBefore = null, [WorkflowExpression] Func<string> template = null, [WorkflowExpression] Func<archivedInput> archived = null, [WorkflowExpression] Func<completedInput> completed = null, [WorkflowExpression] Func<ownerInput> owner = null, [WorkflowExpression] Func<int> limit = null)
        {
            SourceExpression.Validate(order, nameof(order), required: false);
            SourceExpression.Validate(modifiedAfter, nameof(modifiedAfter), required: false);
            SourceExpression.Validate(modifiedBefore, nameof(modifiedBefore), required: false);
            SourceExpression.Validate(template, nameof(template), required: false);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            SourceExpression.Validate(completed, nameof(completed), required: false);
            SourceExpression.Validate(owner, nameof(owner), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/audits/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["order"] = Convert.ToString("desc");
                if (order != null)
                    callPayload.Queries["order"] = SourceExpressionConverter.Convert(order);
                if (modifiedAfter != null)
                    callPayload.Queries["modified_after"] = SourceExpressionConverter.ConvertO(modifiedAfter);
                if (modifiedBefore != null)
                    callPayload.Queries["modified_before"] = SourceExpressionConverter.ConvertO(modifiedBefore);
                if (template != null)
                    callPayload.Queries["template"] = SourceExpressionConverter.ConvertO(template);
                callPayload.Queries["archived"] = Convert.ToString("false");
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.Convert(archived);
                callPayload.Queries["completed"] = Convert.ToString("true");
                if (completed != null)
                    callPayload.Queries["completed"] = SourceExpressionConverter.Convert(completed);
                callPayload.Queries["owner"] = Convert.ToString("all");
                if (owner != null)
                    callPayload.Queries["owner"] = SourceExpressionConverter.Convert(owner);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<AuditSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<GetAuditByIdResponse> GetAuditById([WorkflowExpression] Func<string> auditId)
        {
            SourceExpression.Validate(auditId, nameof(auditId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/audits/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(auditId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAuditByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<GetAuditByIdResponse> ArchiveRestoreAudit([WorkflowExpression] Func<string> auditId, [WorkflowExpression] Func<bool> bodyarchived = null)
        {
            SourceExpression.Validate(auditId, nameof(auditId), required: true);
            SourceExpression.Validate(bodyarchived, nameof(bodyarchived), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/audits/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(auditId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyarchived != null)
                {
                    body["archived"] = SourceExpressionConverter.ConvertToken(bodyarchived);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetAuditByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<InitExportResponse> InitiateAuditExport([WorkflowExpression] Func<string> auditId, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<timezoneInput> timezone = null, [WorkflowExpression] Func<string> exportProfile = null)
        {
            SourceExpression.Validate(auditId, nameof(auditId), required: true);
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(timezone, nameof(timezone), required: false);
            SourceExpression.Validate(exportProfile, nameof(exportProfile), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/audits/{0}/export", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(auditId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Queries["timezone"] = Convert.ToString("Etc/UTC");
                if (timezone != null)
                    callPayload.Queries["timezone"] = SourceExpressionConverter.Convert(timezone);
                if (exportProfile != null)
                    callPayload.Queries["export_profile"] = SourceExpressionConverter.ConvertO(exportProfile);
                return callPayload;
            }

            return new ApiConnectionAction<InitExportResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<ExportStatusResponse> PollExportStatus([WorkflowExpression] Func<string> auditId, [WorkflowExpression] Func<string> exportId)
        {
            SourceExpression.Validate(auditId, nameof(auditId), required: true);
            SourceExpression.Validate(exportId, nameof(exportId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/audits/{0}/exports/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(auditId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(exportId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ExportStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<string> GetAuditExport([WorkflowExpression] Func<string> auditId, [WorkflowExpression] Func<string> exportId, [WorkflowExpression] Func<string> filename)
        {
            SourceExpression.Validate(auditId, nameof(auditId), required: true);
            SourceExpression.Validate(exportId, nameof(exportId), required: true);
            SourceExpression.Validate(filename, nameof(filename), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/audits/{0}/exports/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(auditId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(exportId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(filename, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<GetAuditLinkResponse> GetWebReportLink([WorkflowExpression] Func<string> auditId)
        {
            SourceExpression.Validate(auditId, nameof(auditId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/audits/{0}/web_report_link", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(auditId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAuditLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IWorkflowAction DeleteWebReportLink([WorkflowExpression] Func<string> auditId)
        {
            SourceExpression.Validate(auditId, nameof(auditId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/audits/{0}/web_report_link", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(auditId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<ActionsSearchResponse> SearchActions([WorkflowExpression] Func<string[]> searchActionsBodyauditIdS = null, [WorkflowExpression] Func<searchActionsBodyassigneesInputItem[]> searchActionsBodyassignees = null, [WorkflowExpression] Func<string> searchActionsBodycreatedafterDate = null, [WorkflowExpression] Func<string> searchActionsBodycreatedbeforeDate = null, [WorkflowExpression] Func<string> searchActionsBodymodifiedafterDate = null, [WorkflowExpression] Func<string> searchActionsBodymodifiedbeforeDate = null, [WorkflowExpression] Func<string> searchActionsBodydueafterDate = null, [WorkflowExpression] Func<string> searchActionsBodyduebeforeDate = null)
        {
            SourceExpression.Validate(searchActionsBodyauditIdS, nameof(searchActionsBodyauditIdS), required: false);
            SourceExpression.Validate(searchActionsBodyassignees, nameof(searchActionsBodyassignees), required: false);
            SourceExpression.Validate(searchActionsBodycreatedafterDate, nameof(searchActionsBodycreatedafterDate), required: false);
            SourceExpression.Validate(searchActionsBodycreatedbeforeDate, nameof(searchActionsBodycreatedbeforeDate), required: false);
            SourceExpression.Validate(searchActionsBodymodifiedafterDate, nameof(searchActionsBodymodifiedafterDate), required: false);
            SourceExpression.Validate(searchActionsBodymodifiedbeforeDate, nameof(searchActionsBodymodifiedbeforeDate), required: false);
            SourceExpression.Validate(searchActionsBodydueafterDate, nameof(searchActionsBodydueafterDate), required: false);
            SourceExpression.Validate(searchActionsBodyduebeforeDate, nameof(searchActionsBodyduebeforeDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/actions/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var searchActionsBody = new JObject();
                var searchActionsBodypropCount = 0;
                if (searchActionsBodyauditIdS != null)
                {
                    searchActionsBody["audit_id"] = SourceExpressionConverter.ConvertToken(searchActionsBodyauditIdS);
                    searchActionsBodypropCount++;
                }

                if (searchActionsBodyassignees != null)
                {
                    searchActionsBody["assignees"] = SourceExpressionConverter.ConvertToken(searchActionsBodyassignees);
                    searchActionsBodypropCount++;
                }

                var createdAtObject = new JObject();
                var createdAtObjectpropCount = 0;
                if (searchActionsBodycreatedafterDate != null)
                {
                    createdAtObject["from"] = SourceExpressionConverter.ConvertToken(searchActionsBodycreatedafterDate);
                    createdAtObjectpropCount++;
                }

                if (searchActionsBodycreatedbeforeDate != null)
                {
                    createdAtObject["to"] = SourceExpressionConverter.ConvertToken(searchActionsBodycreatedbeforeDate);
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
                    modifiedAtObject["from"] = SourceExpressionConverter.ConvertToken(searchActionsBodymodifiedafterDate);
                    modifiedAtObjectpropCount++;
                }

                if (searchActionsBodymodifiedbeforeDate != null)
                {
                    modifiedAtObject["to"] = SourceExpressionConverter.ConvertToken(searchActionsBodymodifiedbeforeDate);
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
                    dueAtObject["from"] = SourceExpressionConverter.ConvertToken(searchActionsBodydueafterDate);
                    dueAtObjectpropCount++;
                }

                if (searchActionsBodyduebeforeDate != null)
                {
                    dueAtObject["to"] = SourceExpressionConverter.ConvertToken(searchActionsBodyduebeforeDate);
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
                return callPayload;
            }

            return new ApiConnectionAction<ActionsSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<Action> CreateAction([WorkflowExpression] Func<string> createActionBodyauditId = null, [WorkflowExpression] Func<string> createActionBodyitemId = null, [WorkflowExpression] Func<string> createActionBodytitle = null, [WorkflowExpression] Func<string> createActionBodydescription = null, [WorkflowExpression] Func<createActionBodypriorityInput> createActionBodypriority = null, [WorkflowExpression] Func<createActionBodystatusInput> createActionBodystatus = null, [WorkflowExpression] Func<string> createActionBodydueAt = null, [WorkflowExpression] Func<createActionBodyassigneesInputItem[]> createActionBodyassignees = null)
        {
            SourceExpression.Validate(createActionBodyauditId, nameof(createActionBodyauditId), required: false);
            SourceExpression.Validate(createActionBodyitemId, nameof(createActionBodyitemId), required: false);
            SourceExpression.Validate(createActionBodytitle, nameof(createActionBodytitle), required: false);
            SourceExpression.Validate(createActionBodydescription, nameof(createActionBodydescription), required: false);
            SourceExpression.Validate(createActionBodypriority, nameof(createActionBodypriority), required: false);
            SourceExpression.Validate(createActionBodystatus, nameof(createActionBodystatus), required: false);
            SourceExpression.Validate(createActionBodydueAt, nameof(createActionBodydueAt), required: false);
            SourceExpression.Validate(createActionBodyassignees, nameof(createActionBodyassignees), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/actions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var createActionBody = new JObject();
                var createActionBodypropCount = 0;
                if (createActionBodyauditId != null)
                {
                    createActionBody["audit_id"] = SourceExpressionConverter.ConvertToken(createActionBodyauditId);
                    createActionBodypropCount++;
                }

                if (createActionBodyitemId != null)
                {
                    createActionBody["item_id"] = SourceExpressionConverter.ConvertToken(createActionBodyitemId);
                    createActionBodypropCount++;
                }

                if (createActionBodytitle != null)
                {
                    createActionBody["title"] = SourceExpressionConverter.ConvertToken(createActionBodytitle);
                    createActionBodypropCount++;
                }

                if (createActionBodydescription != null)
                {
                    createActionBody["description"] = SourceExpressionConverter.ConvertToken(createActionBodydescription);
                    createActionBodypropCount++;
                }

                if (createActionBodypriority != null)
                {
                    createActionBody["priority"] = SourceExpressionConverter.Convert(createActionBodypriority);
                    createActionBodypropCount++;
                }

                if (createActionBodystatus != null)
                {
                    createActionBody["status"] = SourceExpressionConverter.Convert(createActionBodystatus);
                    createActionBodypropCount++;
                }

                if (createActionBodydueAt != null)
                {
                    createActionBody["due_at"] = SourceExpressionConverter.ConvertToken(createActionBodydueAt);
                    createActionBodypropCount++;
                }

                if (createActionBodyassignees != null)
                {
                    createActionBody["assignees"] = SourceExpressionConverter.ConvertToken(createActionBodyassignees);
                    createActionBodypropCount++;
                }

                if (createActionBodypropCount > 0)
                {
                    callPayload.Body = createActionBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Action>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<DeleteActionResponse> DeleteAction([WorkflowExpression] Func<string> actionId)
        {
            SourceExpression.Validate(actionId, nameof(actionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/actions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(actionId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DeleteActionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<Action> UpdateAction([WorkflowExpression] Func<string> actionId, [WorkflowExpression] Func<string> updateActionBodytitle = null, [WorkflowExpression] Func<string> updateActionBodydescription = null, [WorkflowExpression] Func<updateActionBodypriorityInput> updateActionBodypriority = null, [WorkflowExpression] Func<updateActionBodystatusInput> updateActionBodystatus = null, [WorkflowExpression] Func<string> updateActionBodydueAt = null, [WorkflowExpression] Func<updateActionBodyassigneesInputItem[]> updateActionBodyassignees = null)
        {
            SourceExpression.Validate(actionId, nameof(actionId), required: true);
            SourceExpression.Validate(updateActionBodytitle, nameof(updateActionBodytitle), required: false);
            SourceExpression.Validate(updateActionBodydescription, nameof(updateActionBodydescription), required: false);
            SourceExpression.Validate(updateActionBodypriority, nameof(updateActionBodypriority), required: false);
            SourceExpression.Validate(updateActionBodystatus, nameof(updateActionBodystatus), required: false);
            SourceExpression.Validate(updateActionBodydueAt, nameof(updateActionBodydueAt), required: false);
            SourceExpression.Validate(updateActionBodyassignees, nameof(updateActionBodyassignees), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/actions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(actionId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var updateActionBody = new JObject();
                var updateActionBodypropCount = 0;
                if (updateActionBodytitle != null)
                {
                    updateActionBody["title"] = SourceExpressionConverter.ConvertToken(updateActionBodytitle);
                    updateActionBodypropCount++;
                }

                if (updateActionBodydescription != null)
                {
                    updateActionBody["description"] = SourceExpressionConverter.ConvertToken(updateActionBodydescription);
                    updateActionBodypropCount++;
                }

                if (updateActionBodypriority != null)
                {
                    updateActionBody["priority"] = SourceExpressionConverter.Convert(updateActionBodypriority);
                    updateActionBodypropCount++;
                }

                if (updateActionBodystatus != null)
                {
                    updateActionBody["status"] = SourceExpressionConverter.Convert(updateActionBodystatus);
                    updateActionBodypropCount++;
                }

                if (updateActionBodydueAt != null)
                {
                    updateActionBody["due_at"] = SourceExpressionConverter.ConvertToken(updateActionBodydueAt);
                    updateActionBodypropCount++;
                }

                if (updateActionBodyassignees != null)
                {
                    updateActionBody["assignees"] = SourceExpressionConverter.ConvertToken(updateActionBodyassignees);
                    updateActionBodypropCount++;
                }

                if (updateActionBodypropCount > 0)
                {
                    callPayload.Body = updateActionBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Action>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<string> GetMedia([WorkflowExpression] Func<string> auditId, [WorkflowExpression] Func<string> mediaId)
        {
            SourceExpression.Validate(auditId, nameof(auditId), required: true);
            SourceExpression.Validate(mediaId, nameof(mediaId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/audits/{0}/media/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(auditId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mediaId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<InitInspectionExportResponse> InitiateInspectionExport([WorkflowExpression] Func<string> auditId, [WorkflowExpression] Func<formatexportFormatInput> formatexportFormat = null, [WorkflowExpression] Func<string> formatpreferenceId = null)
        {
            SourceExpression.Validate(auditId, nameof(auditId), required: true);
            SourceExpression.Validate(formatexportFormat, nameof(formatexportFormat), required: false);
            SourceExpression.Validate(formatpreferenceId, nameof(formatpreferenceId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/audits/{0}/report", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(auditId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var format = new JObject();
                var formatpropCount = 0;
                if (formatexportFormat != null)
                {
                    if (formatexportFormat != null)
                    {
                        format["format"] = SourceExpressionConverter.Convert(formatexportFormat);
                        formatpropCount++;
                    }

                    formatpropCount++;
                }
                else
                {
                    format["format"] = "PDF";
                    formatpropCount++;
                }

                if (formatpreferenceId != null)
                {
                    format["preference_id"] = SourceExpressionConverter.ConvertToken(formatpreferenceId);
                    formatpropCount++;
                }

                if (formatpropCount > 0)
                {
                    callPayload.Body = format;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InitInspectionExportResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<InspectionExportStatusResponse> PollInspectionExportStatus([WorkflowExpression] Func<string> auditId, [WorkflowExpression] Func<string> exportId)
        {
            SourceExpression.Validate(auditId, nameof(auditId), required: true);
            SourceExpression.Validate(exportId, nameof(exportId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/audits/{0}/report/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(auditId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(exportId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<InspectionExportStatusResponse>(BuildSourceInput);
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