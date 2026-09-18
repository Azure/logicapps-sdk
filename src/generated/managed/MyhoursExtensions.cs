//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Myhours
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MyhoursActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhours")]
        public IBodyWorkflowAction<Client> CreateClient([WorkflowExpression] Func<string> bodyname)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/clients/zapier";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Client>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhours")]
        public IBodyWorkflowAction<Client[]> FindClient([WorkflowExpression] Func<string> clientName)
        {
            SourceExpression.Validate(clientName, nameof(clientName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/clients/getByName";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["clientName"] = SourceExpressionConverter.ConvertO(clientName);
                return callPayload;
            }

            return new ApiConnectionAction<Client[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhours")]
        public IBodyWorkflowAction<Project> CreateProject([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<int> bodyclientId = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<int> bodyautoAssignUserId = null)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyclientId, nameof(bodyclientId), required: false);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            SourceExpression.Validate(bodyautoAssignUserId, nameof(bodyautoAssignUserId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Projects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodyclientId != null)
                {
                    body["clientId"] = SourceExpressionConverter.ConvertToken(bodyclientId);
                    bodypropCount++;
                }

                body["invoiceMethod"] = 3;
                bodypropCount++;
                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodyautoAssignUserId != null)
                {
                    body["autoAssignUserId"] = SourceExpressionConverter.ConvertToken(bodyautoAssignUserId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Project>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhours")]
        public IBodyWorkflowAction<Project> FindProject([WorkflowExpression] Func<string> projectName)
        {
            SourceExpression.Validate(projectName, nameof(projectName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Projects/getByNameForPA";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectName"] = SourceExpressionConverter.ConvertO(projectName);
                return callPayload;
            }

            return new ApiConnectionAction<Project>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhours")]
        public IBodyWorkflowAction<ProjectTask> CreateProjectTask([WorkflowExpression] Func<int> projectId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodylistName = null, [WorkflowExpression] Func<string> bodydescription = null)
        {
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodylistName, nameof(bodylistName), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Projects/taskForPA";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodylistName != null)
                {
                    if (bodylistName != null)
                    {
                        body["listName"] = SourceExpressionConverter.ConvertToken(bodylistName);
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
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ProjectTask>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhours")]
        public IBodyWorkflowAction<ProjectTask> FindTask([WorkflowExpression] Func<string> projectTaskName, [WorkflowExpression] Func<int> projectId)
        {
            SourceExpression.Validate(projectTaskName, nameof(projectTaskName), required: true);
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Projects/getProjectTaskByNamePowerAutomate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectTaskName"] = SourceExpressionConverter.ConvertO(projectTaskName);
                callPayload.Queries["projectId"] = SourceExpressionConverter.ConvertO(projectId);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectTask>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhours")]
        public IBodyWorkflowAction<Tag> CreateTag([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyhexColor)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyhexColor, nameof(bodyhexColor), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/tags";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["hexColor"] = SourceExpressionConverter.ConvertToken(bodyhexColor);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Tag>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhours")]
        public IBodyWorkflowAction<Tag> FindTag([WorkflowExpression] Func<string> tagName)
        {
            SourceExpression.Validate(tagName, nameof(tagName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/tags/getByNamePowerAutomate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tagName"] = SourceExpressionConverter.ConvertO(tagName);
                return callPayload;
            }

            return new ApiConnectionAction<Tag>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhours")]
        public IBodyWorkflowAction<TimeLog> CreateLog([WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<int> bodyduration = null, [WorkflowExpression] Func<string> bodynote = null, [WorkflowExpression] Func<int> bodyprojectId = null, [WorkflowExpression] Func<int> bodytaskId = null, [WorkflowExpression] Func<int> bodytagId = null)
        {
            SourceExpression.Validate(bodydate, nameof(bodydate), required: true);
            SourceExpression.Validate(bodystartTime, nameof(bodystartTime), required: false);
            SourceExpression.Validate(bodyendTime, nameof(bodyendTime), required: false);
            SourceExpression.Validate(bodyduration, nameof(bodyduration), required: false);
            SourceExpression.Validate(bodynote, nameof(bodynote), required: false);
            SourceExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: false);
            SourceExpression.Validate(bodytaskId, nameof(bodytaskId), required: false);
            SourceExpression.Validate(bodytagId, nameof(bodytagId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/logs/powerautomate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                if (bodystartTime != null)
                {
                    body["start"] = SourceExpressionConverter.ConvertToken(bodystartTime);
                    bodypropCount++;
                }

                if (bodyendTime != null)
                {
                    body["end"] = SourceExpressionConverter.ConvertToken(bodyendTime);
                    bodypropCount++;
                }

                if (bodyduration != null)
                {
                    body["duration"] = SourceExpressionConverter.ConvertToken(bodyduration);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["Note"] = SourceExpressionConverter.ConvertToken(bodynote);
                    bodypropCount++;
                }

                if (bodyprojectId != null)
                {
                    body["ProjectId"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                    bodypropCount++;
                }

                if (bodytaskId != null)
                {
                    body["TaskId"] = SourceExpressionConverter.ConvertToken(bodytaskId);
                    bodypropCount++;
                }

                if (bodytagId != null)
                {
                    body["TagId"] = SourceExpressionConverter.ConvertToken(bodytagId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TimeLog>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhours")]
        public IBodyWorkflowAction<ActivityReportResponse> GetTimeLogs([WorkflowExpression] Func<string> dateFrom, [WorkflowExpression] Func<string> dateTo)
        {
            SourceExpression.Validate(dateFrom, nameof(dateFrom), required: true);
            SourceExpression.Validate(dateTo, nameof(dateTo), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/reports/activityPowerAutomate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["dateFrom"] = SourceExpressionConverter.ConvertO(dateFrom);
                callPayload.Queries["dateTo"] = SourceExpressionConverter.ConvertO(dateTo);
                return callPayload;
            }

            return new ApiConnectionAction<ActivityReportResponse>(BuildSourceInput);
        }
    }

    public class MyhoursTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TriggerLogsEnvelope> NewTimeLog(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/logs/powerautomate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<TriggerLogsEnvelope>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<TriggerProjectsEnvelope> NewProject(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/projects/powerautomate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<TriggerProjectsEnvelope>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<TriggerProjectTasksEnvelope> NewTask(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/projecttasks/powerautomate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<TriggerProjectTasksEnvelope>(BuildSourceInput, triggerName, recurrence);
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