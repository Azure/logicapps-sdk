//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Myhours
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MyhoursActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhours")]
        public IBodyWorkflowAction<Client, ApiConnectionActionConfiguration> CreateClient(Expression<Func<string>> bodyname)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyAction<Client, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/clients/zapier";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Client>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhours")]
        public IBodyWorkflowAction<Client[], ApiConnectionActionConfiguration> FindClient(Expression<Func<string>> clientName)
        {
            var __workflow_clientName = WorkflowExpression.Compile(clientName, nameof(clientName), required: true);
            return new DeferredBodyAction<Client[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/clients/getByName";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["clientName"] = ExpressionConverter.Convert(__workflow_clientName);
                return new ApiConnectionAction<Client[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhours")]
        public IBodyWorkflowAction<Project, ApiConnectionActionConfiguration> CreateProject(Expression<Func<string>> bodyname, Expression<Func<int>> bodyclientId = null, Expression<Func<string>> bodynotes = null, Expression<Func<int>> bodyautoAssignUserId = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyclientId = WorkflowExpression.Compile(bodyclientId, nameof(bodyclientId), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodyautoAssignUserId = WorkflowExpression.Compile(bodyautoAssignUserId, nameof(bodyautoAssignUserId), required: false);
            return new DeferredBodyAction<Project, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Projects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodyclientId != null)
                {
                    body["clientId"] = ExpressionConverter.ConvertO(__workflow_bodyclientId);
                    bodypropCount++;
                }

                body["invoiceMethod"] = 3;
                bodypropCount++;
                if (__workflow_bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (__workflow_bodyautoAssignUserId != null)
                {
                    body["autoAssignUserId"] = ExpressionConverter.ConvertO(__workflow_bodyautoAssignUserId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Project>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhours")]
        public IBodyWorkflowAction<Project, ApiConnectionActionConfiguration> FindProject(Expression<Func<string>> projectName)
        {
            var __workflow_projectName = WorkflowExpression.Compile(projectName, nameof(projectName), required: true);
            return new DeferredBodyAction<Project, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Projects/getByNameForPA";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectName"] = ExpressionConverter.Convert(__workflow_projectName);
                return new ApiConnectionAction<Project>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhours")]
        public IBodyWorkflowAction<ProjectTask, ApiConnectionActionConfiguration> CreateProjectTask(Expression<Func<int>> projectId, Expression<Func<string>> bodyname, Expression<Func<string>> bodylistName = null, Expression<Func<string>> bodydescription = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodylistName = WorkflowExpression.Compile(bodylistName, nameof(bodylistName), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<ProjectTask, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Projects/taskForPA";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodylistName != null)
                {
                    if (__workflow_bodylistName != null)
                    {
                        body["listName"] = ExpressionConverter.ConvertO(__workflow_bodylistName);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["listName"] = "Task list";
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ProjectTask>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhours")]
        public IBodyWorkflowAction<ProjectTask, ApiConnectionActionConfiguration> FindTask(Expression<Func<string>> projectTaskName, Expression<Func<int>> projectId)
        {
            var __workflow_projectTaskName = WorkflowExpression.Compile(projectTaskName, nameof(projectTaskName), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<ProjectTask, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Projects/getProjectTaskByNamePowerAutomate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectTaskName"] = ExpressionConverter.Convert(__workflow_projectTaskName);
                callPayload.Queries["projectId"] = ExpressionConverter.Convert(__workflow_projectId);
                return new ApiConnectionAction<ProjectTask>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhours")]
        public IBodyWorkflowAction<Tag, ApiConnectionActionConfiguration> CreateTag(Expression<Func<string>> bodyname, Expression<Func<string>> bodyhexColor)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyhexColor = WorkflowExpression.Compile(bodyhexColor, nameof(bodyhexColor), required: true);
            return new DeferredBodyAction<Tag, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/tags";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["hexColor"] = ExpressionConverter.ConvertO(__workflow_bodyhexColor);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Tag>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhours")]
        public IBodyWorkflowAction<Tag, ApiConnectionActionConfiguration> FindTag(Expression<Func<string>> tagName)
        {
            var __workflow_tagName = WorkflowExpression.Compile(tagName, nameof(tagName), required: true);
            return new DeferredBodyAction<Tag, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/tags/getByNamePowerAutomate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tagName"] = ExpressionConverter.Convert(__workflow_tagName);
                return new ApiConnectionAction<Tag>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhours")]
        public IBodyWorkflowAction<TimeLog, ApiConnectionActionConfiguration> CreateLog(Expression<Func<string>> bodydate, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendTime = null, Expression<Func<int>> bodyduration = null, Expression<Func<string>> bodynote = null, Expression<Func<int>> bodyprojectId = null, Expression<Func<int>> bodytaskId = null, Expression<Func<int>> bodytagId = null)
        {
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: true);
            var __workflow_bodystartTime = WorkflowExpression.Compile(bodystartTime, nameof(bodystartTime), required: false);
            var __workflow_bodyendTime = WorkflowExpression.Compile(bodyendTime, nameof(bodyendTime), required: false);
            var __workflow_bodyduration = WorkflowExpression.Compile(bodyduration, nameof(bodyduration), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: false);
            var __workflow_bodytaskId = WorkflowExpression.Compile(bodytaskId, nameof(bodytaskId), required: false);
            var __workflow_bodytagId = WorkflowExpression.Compile(bodytagId, nameof(bodytagId), required: false);
            return new DeferredBodyAction<TimeLog, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/logs/powerautomate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                if (__workflow_bodystartTime != null)
                {
                    body["start"] = ExpressionConverter.ConvertO(__workflow_bodystartTime);
                    bodypropCount++;
                }

                if (__workflow_bodyendTime != null)
                {
                    body["end"] = ExpressionConverter.ConvertO(__workflow_bodyendTime);
                    bodypropCount++;
                }

                if (__workflow_bodyduration != null)
                {
                    body["duration"] = ExpressionConverter.ConvertO(__workflow_bodyduration);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["Note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectId != null)
                {
                    body["ProjectId"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                    bodypropCount++;
                }

                if (__workflow_bodytaskId != null)
                {
                    body["TaskId"] = ExpressionConverter.ConvertO(__workflow_bodytaskId);
                    bodypropCount++;
                }

                if (__workflow_bodytagId != null)
                {
                    body["TagId"] = ExpressionConverter.ConvertO(__workflow_bodytagId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TimeLog>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhours")]
        public IBodyWorkflowAction<ActivityReportResponse, ApiConnectionActionConfiguration> GetTimeLogs(Expression<Func<string>> dateFrom, Expression<Func<string>> dateTo)
        {
            var __workflow_dateFrom = WorkflowExpression.Compile(dateFrom, nameof(dateFrom), required: true);
            var __workflow_dateTo = WorkflowExpression.Compile(dateTo, nameof(dateTo), required: true);
            return new DeferredBodyAction<ActivityReportResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/reports/activityPowerAutomate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["dateFrom"] = ExpressionConverter.Convert(__workflow_dateFrom);
                callPayload.Queries["dateTo"] = ExpressionConverter.Convert(__workflow_dateTo);
                return new ApiConnectionAction<ActivityReportResponse>(callPayload);
            });
        }
    }

    public class MyhoursTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TriggerLogsEnvelope, ApiConnectionTriggerConfiguration> NewTimeLog(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/logs/powerautomate";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<TriggerLogsEnvelope>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<TriggerProjectsEnvelope, ApiConnectionTriggerConfiguration> NewProject(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/projects/powerautomate";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<TriggerProjectsEnvelope>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<TriggerProjectTasksEnvelope, ApiConnectionTriggerConfiguration> NewTask(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/projecttasks/powerautomate";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<TriggerProjectTasksEnvelope>(callPayload, recurrence: recurrence);
        }
    }

    public class Client
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("contactName")]
        public string ContactName { get; set; }

        [JsonProperty("contactEmail")]
        public string ContactEmail { get; set; }

        [JsonProperty("contactPhone")]
        public string ContactPhone { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("customId")]
        public string CustomId { get; set; }

        [JsonProperty("customFieldValues")]
        public string CustomFieldValues { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class Project
    {
        [JsonProperty("invoiceMethod")]
        public int InvoiceMethod { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("budgetType")]
        public int BudgetType { get; set; }

        [JsonProperty("budgetValue")]
        public int BudgetValue { get; set; }

        [JsonProperty("budgetAlertPercent")]
        public int BudgetAlertPercent { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("approved")]
        public bool Approved { get; set; }

        [JsonProperty("roundType")]
        public int RoundType { get; set; }

        [JsonProperty("roundInterval")]
        public int RoundInterval { get; set; }

        [JsonProperty("firstLogDate")]
        public string FirstLogDate { get; set; }

        [JsonProperty("budgetTarget")]
        public int BudgetTarget { get; set; }

        [JsonProperty("budgetPeriodType")]
        public string BudgetPeriodType { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("createdByUserId")]
        public int CreatedByUserId { get; set; }

        [JsonProperty("createdByUserName")]
        public string CreatedByUserName { get; set; }

        [JsonProperty("billable")]
        public bool Billable { get; set; }

        [JsonProperty("customFieldValues")]
        public string CustomFieldValues { get; set; }

        [JsonProperty("clientId")]
        public int ClientId { get; set; }

        [JsonProperty("clientName")]
        public string ClientName { get; set; }

        [JsonProperty("clientCustomId")]
        public string ClientCustomId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("customId")]
        public string CustomId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class ProjectTask
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("orderNo")]
        public int OrderNo { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("billableByDefault")]
        public bool BillableByDefault { get; set; }

        [JsonProperty("budgetValue")]
        public double BudgetValue { get; set; }

        [JsonProperty("budgetSpent")]
        public double BudgetSpent { get; set; }

        [JsonProperty("budgetSpentPercentage")]
        public double BudgetSpentPercentage { get; set; }

        [JsonProperty("projectBudgetType")]
        public int ProjectBudgetType { get; set; }

        [JsonProperty("projectTaskUserIds")]
        public int[] ProjectTaskUserIds { get; set; }

        [JsonProperty("customFieldValues")]
        public string CustomFieldValues { get; set; }

        [JsonProperty("customId")]
        public string CustomId { get; set; }

        [JsonProperty("projectCustomId")]
        public string ProjectCustomId { get; set; }

        [JsonProperty("clientCustomId")]
        public string ClientCustomId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class Tag
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("hexColor")]
        public string HexColor { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("dateArchived")]
        public string DateArchived { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class TimeLog
    {
        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("projectName")]
        public string ProjectName { get; set; }

        [JsonProperty("taskName")]
        public string TaskName { get; set; }

        [JsonProperty("clientName")]
        public string ClientName { get; set; }

        [JsonProperty("running")]
        public bool Running { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("times")]
        public TimeSlice[] Times { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("projectId")]
        public int ProjectId { get; set; }

        [JsonProperty("taskId")]
        public int TaskId { get; set; }

        [JsonProperty("billable")]
        public bool Billable { get; set; }

        [JsonProperty("expense")]
        public double Expense { get; set; }

        [JsonProperty("userId")]
        public int UserId { get; set; }

        [JsonProperty("billableRate")]
        public double BillableRate { get; set; }

        [JsonProperty("billableAmount")]
        public double BillableAmount { get; set; }

        [JsonProperty("laborRate")]
        public double LaborRate { get; set; }

        [JsonProperty("laborCost")]
        public double LaborCost { get; set; }

        [JsonProperty("customField1Name")]
        public string CustomField1Name { get; set; }

        [JsonProperty("customField2Name")]
        public string CustomField2Name { get; set; }

        [JsonProperty("customField3Name")]
        public string CustomField3Name { get; set; }

        [JsonProperty("customField1Value")]
        public string CustomField1Value { get; set; }

        [JsonProperty("customField2Value")]
        public string CustomField2Value { get; set; }

        [JsonProperty("customField3Value")]
        public string CustomField3Value { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("durationInHours")]
        public double DurationInHours { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("tagsData")]
        public Tag[] TagsData { get; set; }

        [JsonProperty("attachments")]
        public Attachment[] Attachments { get; set; }
    }

    public class TimeSlice
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("running")]
        public bool Running { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }
    }

    public class Attachment
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("fileUrl")]
        public string FileUrl { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class ActivityReportResponse
    {
        [JsonProperty("body")]
        public ActivityLogRow[] Body { get; set; }
    }

    public class ActivityLogRow
    {
        [JsonProperty("logId")]
        public int LogId { get; set; }

        [JsonProperty("userId")]
        public int UserId { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("teamsNames")]
        public string TeamsNames { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("userCustomId")]
        public string UserCustomId { get; set; }

        [JsonProperty("clientId")]
        public int ClientId { get; set; }

        [JsonProperty("clientName")]
        public string ClientName { get; set; }

        [JsonProperty("clientCustomId")]
        public string ClientCustomId { get; set; }

        [JsonProperty("projectId")]
        public int ProjectId { get; set; }

        [JsonProperty("projectName")]
        public string ProjectName { get; set; }

        [JsonProperty("projectCustomId")]
        public string ProjectCustomId { get; set; }

        [JsonProperty("projectStartDate")]
        public string ProjectStartDate { get; set; }

        [JsonProperty("projectDueDate")]
        public string ProjectDueDate { get; set; }

        [JsonProperty("projectBudgetType")]
        public string ProjectBudgetType { get; set; }

        [JsonProperty("projectBudgetTarget")]
        public string ProjectBudgetTarget { get; set; }

        [JsonProperty("projectBudgetPeriodType")]
        public string ProjectBudgetPeriodType { get; set; }

        [JsonProperty("projectBudgetValue")]
        public int ProjectBudgetValue { get; set; }

        [JsonProperty("taskListName")]
        public string TaskListName { get; set; }

        [JsonProperty("taskId")]
        public int TaskId { get; set; }

        [JsonProperty("taskName")]
        public string TaskName { get; set; }

        [JsonProperty("taskCustomId")]
        public string TaskCustomId { get; set; }

        [JsonProperty("taskStartDate")]
        public string TaskStartDate { get; set; }

        [JsonProperty("taskDueDate")]
        public string TaskDueDate { get; set; }

        [JsonProperty("taskCompleted")]
        public bool TaskCompleted { get; set; }

        [JsonProperty("userCustomFieldValues")]
        public string UserCustomFieldValues { get; set; }

        [JsonProperty("projectCustomFieldValues")]
        public string ProjectCustomFieldValues { get; set; }

        [JsonProperty("clientCustomFieldValues")]
        public string ClientCustomFieldValues { get; set; }

        [JsonProperty("taskCustomFieldValues")]
        public string TaskCustomFieldValues { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("billable")]
        public bool Billable { get; set; }

        [JsonProperty("inLockedPeriod")]
        public bool InLockedPeriod { get; set; }

        [JsonProperty("billableAmount")]
        public double BillableAmount { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("laborCost")]
        public double LaborCost { get; set; }

        [JsonProperty("laborRate")]
        public double LaborRate { get; set; }

        [JsonProperty("logDuration")]
        public int LogDuration { get; set; }

        [JsonProperty("logDurationBillable")]
        public int LogDurationBillable { get; set; }

        [JsonProperty("laborDuration")]
        public int LaborDuration { get; set; }

        [JsonProperty("startEndTime")]
        public string StartEndTime { get; set; }

        [JsonProperty("expense")]
        public double Expense { get; set; }

        [JsonProperty("billableExpense")]
        public double BillableExpense { get; set; }

        [JsonProperty("cost")]
        public double Cost { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("invoiceId")]
        public int InvoiceId { get; set; }

        [JsonProperty("invoiced")]
        public bool Invoiced { get; set; }

        [JsonProperty("billableHours")]
        public int BillableHours { get; set; }

        [JsonProperty("billableHoursLogBillable")]
        public int BillableHoursLogBillable { get; set; }

        [JsonProperty("laborHours")]
        public int LaborHours { get; set; }

        [JsonProperty("customField1")]
        public int CustomField1 { get; set; }

        [JsonProperty("customField2")]
        public int CustomField2 { get; set; }

        [JsonProperty("customField3")]
        public int CustomField3 { get; set; }

        [JsonProperty("balance")]
        public int Balance { get; set; }

        [JsonProperty("monthOfYear")]
        public string MonthOfYear { get; set; }

        [JsonProperty("weekNo")]
        public int WeekNo { get; set; }

        [JsonProperty("weekOfYear")]
        public string WeekOfYear { get; set; }

        [JsonProperty("teams")]
        public string[] Teams { get; set; }

        [JsonProperty("running")]
        public bool Running { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("times")]
        public TimeSlice[] Times { get; set; }

        [JsonProperty("tagsData")]
        public Tag[] TagsData { get; set; }

        [JsonProperty("attachments")]
        public Attachment[] Attachments { get; set; }

        [JsonProperty("roundType")]
        public string RoundType { get; set; }

        [JsonProperty("invoicedAmount")]
        public double InvoicedAmount { get; set; }

        [JsonProperty("uninvoicedAmount")]
        public double UninvoicedAmount { get; set; }
    }

    public class TriggerLogsEnvelope
    {
        [JsonProperty("logs")]
        public TimeLog[] Logs { get; set; }
    }

    public class TriggerProjectsEnvelope
    {
        [JsonProperty("projects")]
        public TriggerProjectsEnvelopeProjectsTypeItem[] Projects { get; set; }
    }

    public class TriggerProjectsEnvelopeProjectsTypeItem
    {
        [JsonProperty("clientId")]
        public int ClientId { get; set; }

        [JsonProperty("clientName")]
        public string ClientName { get; set; }

        [JsonProperty("clientCustomId")]
        public string ClientCustomId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("customId")]
        public string CustomId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class TriggerProjectTasksEnvelope
    {
        [JsonProperty("projectTasks")]
        public TriggerProjectTasksEnvelopeProjectTasksTypeItem[] ProjectTasks { get; set; }
    }

    public class TriggerProjectTasksEnvelopeProjectTasksTypeItem
    {
        [JsonProperty("projectId")]
        public int ProjectId { get; set; }

        [JsonProperty("listName")]
        public string ListName { get; set; }

        [JsonProperty("listOrderNo")]
        public int ListOrderNo { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("orderNo")]
        public int OrderNo { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("budgetValue")]
        public double BudgetValue { get; set; }

        [JsonProperty("projectBudgetType")]
        public int ProjectBudgetType { get; set; }

        [JsonProperty("customId")]
        public string CustomId { get; set; }

        [JsonProperty("billableByDefault")]
        public bool BillableByDefault { get; set; }

        [JsonProperty("projectCustomId")]
        public string ProjectCustomId { get; set; }

        [JsonProperty("clientCustomId")]
        public string ClientCustomId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Myhours;

    public partial class WorkflowManagedActions
    {
        public MyhoursActions Myhours(string connectionId) => new MyhoursActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MyhoursTriggers Myhours(string connectionId) => new MyhoursTriggers(connectionId);
    }
}
