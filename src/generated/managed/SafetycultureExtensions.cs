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
        public IBodyWorkflowAction<AuditSearchResponse> SearchAudits(Expression<Func<orderInput>> order = null, Expression<Func<string>> modifiedAfter = null, Expression<Func<string>> modifiedBefore = null, Expression<Func<string>> template = null, Expression<Func<archivedInput>> archived = null, Expression<Func<completedInput>> completed = null, Expression<Func<ownerInput>> owner = null, Expression<Func<int>> limit = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<GetAuditByIdResponse> GetAuditById(Expression<Func<string>> auditId)
        {
            var apiCallPath = String.Format("/audits/{0}", ExpressionConverter.ConvertWithUrlEncoding(auditId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAuditByIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<GetAuditByIdResponse> ArchiveRestoreAudit(Expression<Func<string>> auditId, Expression<Func<bool>> bodyarchived = null)
        {
            var apiCallPath = String.Format("/audits/{0}", ExpressionConverter.ConvertWithUrlEncoding(auditId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<InitExportResponse> InitiateAuditExport(Expression<Func<string>> auditId, Expression<Func<formatInput>> format, Expression<Func<timezoneInput>> timezone = null, Expression<Func<string>> exportProfile = null)
        {
            var apiCallPath = String.Format("/audits/{0}/export", ExpressionConverter.ConvertWithUrlEncoding(auditId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            callPayload.Queries["timezone"] = Convert.ToString("Etc/UTC");
            if (timezone != null)
                callPayload.Queries["timezone"] = ExpressionConverter.Convert(timezone);
            if (exportProfile != null)
                callPayload.Queries["export_profile"] = ExpressionConverter.Convert(exportProfile);
            return new ApiConnectionAction<InitExportResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<ExportStatusResponse> PollExportStatus(Expression<Func<string>> auditId, Expression<Func<string>> exportId)
        {
            var apiCallPath = String.Format("/audits/{0}/exports/{1}", ExpressionConverter.ConvertWithUrlEncoding(auditId, 1), ExpressionConverter.ConvertWithUrlEncoding(exportId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ExportStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<string> GetAuditExport(Expression<Func<string>> auditId, Expression<Func<string>> exportId, Expression<Func<string>> filename)
        {
            var apiCallPath = String.Format("/audits/{0}/exports/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(auditId, 1), ExpressionConverter.ConvertWithUrlEncoding(exportId, 1), ExpressionConverter.ConvertWithUrlEncoding(filename, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<GetAuditLinkResponse> GetWebReportLink(Expression<Func<string>> auditId)
        {
            var apiCallPath = String.Format("/audits/{0}/web_report_link", ExpressionConverter.ConvertWithUrlEncoding(auditId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAuditLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IWorkflowAction DeleteWebReportLink(Expression<Func<string>> auditId)
        {
            var apiCallPath = String.Format("/audits/{0}/web_report_link", ExpressionConverter.ConvertWithUrlEncoding(auditId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<ActionsSearchResponse> SearchActions(Expression<Func<string[]>> searchActionsBodyauditIDS = null, Expression<Func<searchActionsBodyassigneesInputItem[]>> searchActionsBodyassignees = null, Expression<Func<string>> searchActionsBodycreatedafterDate = null, Expression<Func<string>> searchActionsBodycreatedbeforeDate = null, Expression<Func<string>> searchActionsBodymodifiedafterDate = null, Expression<Func<string>> searchActionsBodymodifiedbeforeDate = null, Expression<Func<string>> searchActionsBodydueafterDate = null, Expression<Func<string>> searchActionsBodyduebeforeDate = null)
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

            var created_atObject = new JObject();
            var created_atObjectpropCount = 0;
            if (searchActionsBodycreatedafterDate != null)
            {
                created_atObject["from"] = ExpressionConverter.ConvertO(searchActionsBodycreatedafterDate);
                created_atObjectpropCount++;
            }

            if (searchActionsBodycreatedbeforeDate != null)
            {
                created_atObject["to"] = ExpressionConverter.ConvertO(searchActionsBodycreatedbeforeDate);
                created_atObjectpropCount++;
            }

            if (created_atObjectpropCount > 0)
            {
                searchActionsBody["created_at"] = created_atObject;
                searchActionsBodypropCount++;
            }

            var modified_atObject = new JObject();
            var modified_atObjectpropCount = 0;
            if (searchActionsBodymodifiedafterDate != null)
            {
                modified_atObject["from"] = ExpressionConverter.ConvertO(searchActionsBodymodifiedafterDate);
                modified_atObjectpropCount++;
            }

            if (searchActionsBodymodifiedbeforeDate != null)
            {
                modified_atObject["to"] = ExpressionConverter.ConvertO(searchActionsBodymodifiedbeforeDate);
                modified_atObjectpropCount++;
            }

            if (modified_atObjectpropCount > 0)
            {
                searchActionsBody["modified_at"] = modified_atObject;
                searchActionsBodypropCount++;
            }

            var due_atObject = new JObject();
            var due_atObjectpropCount = 0;
            if (searchActionsBodydueafterDate != null)
            {
                due_atObject["from"] = ExpressionConverter.ConvertO(searchActionsBodydueafterDate);
                due_atObjectpropCount++;
            }

            if (searchActionsBodyduebeforeDate != null)
            {
                due_atObject["to"] = ExpressionConverter.ConvertO(searchActionsBodyduebeforeDate);
                due_atObjectpropCount++;
            }

            if (due_atObjectpropCount > 0)
            {
                searchActionsBody["due_at"] = due_atObject;
                searchActionsBodypropCount++;
            }

            if (searchActionsBodypropCount > 0)
            {
                callPayload.Body = searchActionsBody;
            }

            return new ApiConnectionAction<ActionsSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<Action> CreateAction(Expression<Func<string>> createActionBodyauditID = null, Expression<Func<string>> createActionBodyitemID = null, Expression<Func<string>> createActionBodytitle = null, Expression<Func<string>> createActionBodydescription = null, Expression<Func<createActionBodypriorityInput>> createActionBodypriority = null, Expression<Func<createActionBodystatusInput>> createActionBodystatus = null, Expression<Func<string>> createActionBodydueAt = null, Expression<Func<createActionBodyassigneesInputItem[]>> createActionBodyassignees = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<DeleteActionResponse> DeleteAction(Expression<Func<string>> actionId)
        {
            var apiCallPath = String.Format("/actions/{0}", ExpressionConverter.ConvertWithUrlEncoding(actionId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DeleteActionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<Action> UpdateAction(Expression<Func<string>> actionId, Expression<Func<string>> updateActionBodytitle = null, Expression<Func<string>> updateActionBodydescription = null, Expression<Func<updateActionBodypriorityInput>> updateActionBodypriority = null, Expression<Func<updateActionBodystatusInput>> updateActionBodystatus = null, Expression<Func<string>> updateActionBodydueAt = null, Expression<Func<updateActionBodyassigneesInputItem[]>> updateActionBodyassignees = null)
        {
            var apiCallPath = String.Format("/actions/{0}", ExpressionConverter.ConvertWithUrlEncoding(actionId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<string> GetMedia(Expression<Func<string>> auditId, Expression<Func<string>> mediaId)
        {
            var apiCallPath = String.Format("/audits/{0}/media/{1}", ExpressionConverter.ConvertWithUrlEncoding(auditId, 1), ExpressionConverter.ConvertWithUrlEncoding(mediaId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<InitInspectionExportResponse> InitiateInspectionExport(Expression<Func<string>> auditId, Expression<Func<formatexportFormatInput>> formatexportFormat = null, Expression<Func<string>> formatpreferenceID = null)
        {
            var apiCallPath = String.Format("/audits/{0}/report", ExpressionConverter.ConvertWithUrlEncoding(auditId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var format = new JObject();
            var formatpropCount = 0;
            if (formatexportFormat != null)
            {
                format["format"] = ExpressionConverter.ConvertO(formatexportFormat);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "safetyculture")]
        public IBodyWorkflowAction<InspectionExportStatusResponse> PollInspectionExportStatus(Expression<Func<string>> auditId, Expression<Func<string>> exportId)
        {
            var apiCallPath = String.Format("/audits/{0}/report/{1}", ExpressionConverter.ConvertWithUrlEncoding(auditId, 1), ExpressionConverter.ConvertWithUrlEncoding(exportId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<InspectionExportStatusResponse>(callPayload);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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