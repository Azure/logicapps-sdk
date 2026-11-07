//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Softonewebcrm
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SoftonewebcrmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesCallsCallDTO[], ApiConnectionActionConfiguration> CallGetAll(Expression<Func<string>> id = null, Expression<Func<CallGetAllStatusInput>> status = null, Expression<Func<string>> priorityId = null, Expression<Func<string>> createdBy = null, Expression<Func<string>> lastModifiedBy = null, Expression<Func<string>> dueDate = null, Expression<Func<string>> sortDate = null, Expression<Func<string>> assignedToId = null, Expression<Func<string>> relatedToId = null, Expression<Func<string>> callResultId = null, Expression<Func<string>> search = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_priorityId = WorkflowExpression.Compile(priorityId, nameof(priorityId), required: false);
            var __workflow_createdBy = WorkflowExpression.Compile(createdBy, nameof(createdBy), required: false);
            var __workflow_lastModifiedBy = WorkflowExpression.Compile(lastModifiedBy, nameof(lastModifiedBy), required: false);
            var __workflow_dueDate = WorkflowExpression.Compile(dueDate, nameof(dueDate), required: false);
            var __workflow_sortDate = WorkflowExpression.Compile(sortDate, nameof(sortDate), required: false);
            var __workflow_assignedToId = WorkflowExpression.Compile(assignedToId, nameof(assignedToId), required: false);
            var __workflow_relatedToId = WorkflowExpression.Compile(relatedToId, nameof(relatedToId), required: false);
            var __workflow_callResultId = WorkflowExpression.Compile(callResultId, nameof(callResultId), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<TaskApiFeaturesCallsCallDTO[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/task/Call";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_priorityId != null)
                    callPayload.Queries["PriorityId"] = ExpressionConverter.Convert(__workflow_priorityId);
                if (__workflow_createdBy != null)
                    callPayload.Queries["CreatedBy"] = ExpressionConverter.Convert(__workflow_createdBy);
                if (__workflow_lastModifiedBy != null)
                    callPayload.Queries["LastModifiedBy"] = ExpressionConverter.Convert(__workflow_lastModifiedBy);
                if (__workflow_dueDate != null)
                    callPayload.Queries["DueDate"] = ExpressionConverter.Convert(__workflow_dueDate);
                if (__workflow_sortDate != null)
                    callPayload.Queries["SortDate"] = ExpressionConverter.Convert(__workflow_sortDate);
                if (__workflow_assignedToId != null)
                    callPayload.Queries["AssignedToId"] = ExpressionConverter.Convert(__workflow_assignedToId);
                if (__workflow_relatedToId != null)
                    callPayload.Queries["RelatedToId"] = ExpressionConverter.Convert(__workflow_relatedToId);
                if (__workflow_callResultId != null)
                    callPayload.Queries["CallResultId"] = ExpressionConverter.Convert(__workflow_callResultId);
                if (__workflow_search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<TaskApiFeaturesCallsCallDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesCallsCallDTO, ApiConnectionActionConfiguration> CallCreate(Expression<Func<CallCreateBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TaskApiFeaturesCallsCallDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/task/Call";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TaskApiFeaturesCallsCallDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesCallsCallDTO, ApiConnectionActionConfiguration> CallGetById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<TaskApiFeaturesCallsCallDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/task/Call/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskApiFeaturesCallsCallDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CallDelete(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/task/Call/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesCallsCallDTO, ApiConnectionActionConfiguration> CallUpdate(Expression<Func<string>> id, Expression<Func<CallUpdateBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TaskApiFeaturesCallsCallDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/task/Call/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TaskApiFeaturesCallsCallDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesEventsEventDTO[], ApiConnectionActionConfiguration> EventGetAll(Expression<Func<string>> id = null, Expression<Func<EventGetAllStatusInput>> status = null, Expression<Func<EventStatusInput>> eventStatus = null, Expression<Func<string>> startDate = null, Expression<Func<string>> assignedToId = null, Expression<Func<string>> relatedToId = null, Expression<Func<string>> sortDate = null, Expression<Func<string>> parentId = null, Expression<Func<string>> eventResultId = null, Expression<Func<string>> priorityId = null, Expression<Func<string>> search = null, Expression<Func<string>> lastModifiedBy = null, Expression<Func<string>> createdBy = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_eventStatus = WorkflowExpression.Compile(eventStatus, nameof(eventStatus), required: false);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_assignedToId = WorkflowExpression.Compile(assignedToId, nameof(assignedToId), required: false);
            var __workflow_relatedToId = WorkflowExpression.Compile(relatedToId, nameof(relatedToId), required: false);
            var __workflow_sortDate = WorkflowExpression.Compile(sortDate, nameof(sortDate), required: false);
            var __workflow_parentId = WorkflowExpression.Compile(parentId, nameof(parentId), required: false);
            var __workflow_eventResultId = WorkflowExpression.Compile(eventResultId, nameof(eventResultId), required: false);
            var __workflow_priorityId = WorkflowExpression.Compile(priorityId, nameof(priorityId), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_lastModifiedBy = WorkflowExpression.Compile(lastModifiedBy, nameof(lastModifiedBy), required: false);
            var __workflow_createdBy = WorkflowExpression.Compile(createdBy, nameof(createdBy), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<TaskApiFeaturesEventsEventDTO[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/task/Event";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_eventStatus != null)
                    callPayload.Queries["EventStatus"] = ExpressionConverter.Convert(__workflow_eventStatus);
                if (__workflow_startDate != null)
                    callPayload.Queries["StartDate"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_assignedToId != null)
                    callPayload.Queries["AssignedToId"] = ExpressionConverter.Convert(__workflow_assignedToId);
                if (__workflow_relatedToId != null)
                    callPayload.Queries["RelatedToId"] = ExpressionConverter.Convert(__workflow_relatedToId);
                if (__workflow_sortDate != null)
                    callPayload.Queries["SortDate"] = ExpressionConverter.Convert(__workflow_sortDate);
                if (__workflow_parentId != null)
                    callPayload.Queries["ParentId"] = ExpressionConverter.Convert(__workflow_parentId);
                if (__workflow_eventResultId != null)
                    callPayload.Queries["EventResultId"] = ExpressionConverter.Convert(__workflow_eventResultId);
                if (__workflow_priorityId != null)
                    callPayload.Queries["PriorityId"] = ExpressionConverter.Convert(__workflow_priorityId);
                if (__workflow_search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_lastModifiedBy != null)
                    callPayload.Queries["LastModifiedBy"] = ExpressionConverter.Convert(__workflow_lastModifiedBy);
                if (__workflow_createdBy != null)
                    callPayload.Queries["CreatedBy"] = ExpressionConverter.Convert(__workflow_createdBy);
                if (__workflow_page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<TaskApiFeaturesEventsEventDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesEventsEventDTO, ApiConnectionActionConfiguration> EventCreate(Expression<Func<EventCreateBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TaskApiFeaturesEventsEventDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/task/Event";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TaskApiFeaturesEventsEventDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesEventsEventDTO, ApiConnectionActionConfiguration> EventGetById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<TaskApiFeaturesEventsEventDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/task/Event/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskApiFeaturesEventsEventDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EventDelete(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/task/Event/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesEventsEventDTO, ApiConnectionActionConfiguration> EventUpdate(Expression<Func<string>> id, Expression<Func<EventCreateBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TaskApiFeaturesEventsEventDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/task/Event/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TaskApiFeaturesEventsEventDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesNotesNoteDTO[], ApiConnectionActionConfiguration> NoteGetAll(Expression<Func<string>> id = null, Expression<Func<string>> search = null, Expression<Func<string>> relatedToId = null, Expression<Func<RelatedToTypeInput>> relatedToType = null, Expression<Func<string>> createdBy = null, Expression<Func<string>> lastModifiedBy = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_relatedToId = WorkflowExpression.Compile(relatedToId, nameof(relatedToId), required: false);
            var __workflow_relatedToType = WorkflowExpression.Compile(relatedToType, nameof(relatedToType), required: false);
            var __workflow_createdBy = WorkflowExpression.Compile(createdBy, nameof(createdBy), required: false);
            var __workflow_lastModifiedBy = WorkflowExpression.Compile(lastModifiedBy, nameof(lastModifiedBy), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<TaskApiFeaturesNotesNoteDTO[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/task/Note";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_relatedToId != null)
                    callPayload.Queries["RelatedToId"] = ExpressionConverter.Convert(__workflow_relatedToId);
                if (__workflow_relatedToType != null)
                    callPayload.Queries["RelatedToType"] = ExpressionConverter.Convert(__workflow_relatedToType);
                if (__workflow_createdBy != null)
                    callPayload.Queries["CreatedBy"] = ExpressionConverter.Convert(__workflow_createdBy);
                if (__workflow_lastModifiedBy != null)
                    callPayload.Queries["LastModifiedBy"] = ExpressionConverter.Convert(__workflow_lastModifiedBy);
                if (__workflow_page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<TaskApiFeaturesNotesNoteDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesNotesNoteDTO, ApiConnectionActionConfiguration> NoteCreate(Expression<Func<NoteCreateBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TaskApiFeaturesNotesNoteDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/task/Note";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TaskApiFeaturesNotesNoteDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesNotesNoteDTO, ApiConnectionActionConfiguration> NoteGetById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<TaskApiFeaturesNotesNoteDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/task/Note/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskApiFeaturesNotesNoteDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> NoteDelete(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/task/Note/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesNotesNoteDTO, ApiConnectionActionConfiguration> NoteUpdate(Expression<Func<string>> id, Expression<Func<NoteUpdateBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TaskApiFeaturesNotesNoteDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/task/Note/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TaskApiFeaturesNotesNoteDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesTasksTaskDTO[], ApiConnectionActionConfiguration> TaskGetAll(Expression<Func<string>> id = null, Expression<Func<CallGetAllStatusInput>> status = null, Expression<Func<string>> relatedTo = null, Expression<Func<string>> relatedToId = null, Expression<Func<string>> priorityId = null, Expression<Func<TypeInput>> type = null, Expression<Func<string>> dueDate = null, Expression<Func<string>> sortDate = null, Expression<Func<string>> parentId = null, Expression<Func<string>> lastModifiedBy = null, Expression<Func<string>> createdBy = null, Expression<Func<string>> assignedToId = null, Expression<Func<string>> search = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_relatedTo = WorkflowExpression.Compile(relatedTo, nameof(relatedTo), required: false);
            var __workflow_relatedToId = WorkflowExpression.Compile(relatedToId, nameof(relatedToId), required: false);
            var __workflow_priorityId = WorkflowExpression.Compile(priorityId, nameof(priorityId), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_dueDate = WorkflowExpression.Compile(dueDate, nameof(dueDate), required: false);
            var __workflow_sortDate = WorkflowExpression.Compile(sortDate, nameof(sortDate), required: false);
            var __workflow_parentId = WorkflowExpression.Compile(parentId, nameof(parentId), required: false);
            var __workflow_lastModifiedBy = WorkflowExpression.Compile(lastModifiedBy, nameof(lastModifiedBy), required: false);
            var __workflow_createdBy = WorkflowExpression.Compile(createdBy, nameof(createdBy), required: false);
            var __workflow_assignedToId = WorkflowExpression.Compile(assignedToId, nameof(assignedToId), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<TaskApiFeaturesTasksTaskDTO[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Task";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_relatedTo != null)
                    callPayload.Queries["RelatedTo"] = ExpressionConverter.Convert(__workflow_relatedTo);
                if (__workflow_relatedToId != null)
                    callPayload.Queries["RelatedToId"] = ExpressionConverter.Convert(__workflow_relatedToId);
                if (__workflow_priorityId != null)
                    callPayload.Queries["PriorityId"] = ExpressionConverter.Convert(__workflow_priorityId);
                if (__workflow_type != null)
                    callPayload.Queries["Type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_dueDate != null)
                    callPayload.Queries["DueDate"] = ExpressionConverter.Convert(__workflow_dueDate);
                if (__workflow_sortDate != null)
                    callPayload.Queries["SortDate"] = ExpressionConverter.Convert(__workflow_sortDate);
                if (__workflow_parentId != null)
                    callPayload.Queries["ParentId"] = ExpressionConverter.Convert(__workflow_parentId);
                if (__workflow_lastModifiedBy != null)
                    callPayload.Queries["LastModifiedBy"] = ExpressionConverter.Convert(__workflow_lastModifiedBy);
                if (__workflow_createdBy != null)
                    callPayload.Queries["CreatedBy"] = ExpressionConverter.Convert(__workflow_createdBy);
                if (__workflow_assignedToId != null)
                    callPayload.Queries["AssignedToId"] = ExpressionConverter.Convert(__workflow_assignedToId);
                if (__workflow_search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<TaskApiFeaturesTasksTaskDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesTasksTaskDTO, ApiConnectionActionConfiguration> TaskCreate(Expression<Func<TaskCreateBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TaskApiFeaturesTasksTaskDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Task";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TaskApiFeaturesTasksTaskDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesTasksTaskDTO, ApiConnectionActionConfiguration> TaskGetById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<TaskApiFeaturesTasksTaskDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Task/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskApiFeaturesTasksTaskDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> TaskDelete(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Task/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesTasksTaskDTO, ApiConnectionActionConfiguration> TaskUpdate(Expression<Func<string>> id, Expression<Func<TaskUpdateBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TaskApiFeaturesTasksTaskDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Task/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TaskApiFeaturesTasksTaskDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesLeadLeadDto[], ApiConnectionActionConfiguration> LeadGetAll(Expression<Func<string>> id = null, Expression<Func<string>> name = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lastName = null, Expression<Func<string>> insertDate = null, Expression<Func<string>> phone = null, Expression<Func<string>> mobilePhone = null, Expression<Func<string>> email = null, Expression<Func<string>> ownerId = null, Expression<Func<OwnerTypeInput>> ownerType = null, Expression<Func<string>> accountSourceTypeId = null, Expression<Func<string>> leadStatusId = null, Expression<Func<string>> industryId = null, Expression<Func<string>> status = null, Expression<Func<string>> search = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_firstName = WorkflowExpression.Compile(firstName, nameof(firstName), required: false);
            var __workflow_lastName = WorkflowExpression.Compile(lastName, nameof(lastName), required: false);
            var __workflow_insertDate = WorkflowExpression.Compile(insertDate, nameof(insertDate), required: false);
            var __workflow_phone = WorkflowExpression.Compile(phone, nameof(phone), required: false);
            var __workflow_mobilePhone = WorkflowExpression.Compile(mobilePhone, nameof(mobilePhone), required: false);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: false);
            var __workflow_ownerId = WorkflowExpression.Compile(ownerId, nameof(ownerId), required: false);
            var __workflow_ownerType = WorkflowExpression.Compile(ownerType, nameof(ownerType), required: false);
            var __workflow_accountSourceTypeId = WorkflowExpression.Compile(accountSourceTypeId, nameof(accountSourceTypeId), required: false);
            var __workflow_leadStatusId = WorkflowExpression.Compile(leadStatusId, nameof(leadStatusId), required: false);
            var __workflow_industryId = WorkflowExpression.Compile(industryId, nameof(industryId), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<SalesPipelineApiFeaturesLeadLeadDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Lead";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_name != null)
                    callPayload.Queries["Name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_firstName != null)
                    callPayload.Queries["FirstName"] = ExpressionConverter.Convert(__workflow_firstName);
                if (__workflow_lastName != null)
                    callPayload.Queries["LastName"] = ExpressionConverter.Convert(__workflow_lastName);
                if (__workflow_insertDate != null)
                    callPayload.Queries["InsertDate"] = ExpressionConverter.Convert(__workflow_insertDate);
                if (__workflow_phone != null)
                    callPayload.Queries["Phone"] = ExpressionConverter.Convert(__workflow_phone);
                if (__workflow_mobilePhone != null)
                    callPayload.Queries["MobilePhone"] = ExpressionConverter.Convert(__workflow_mobilePhone);
                if (__workflow_email != null)
                    callPayload.Queries["Email"] = ExpressionConverter.Convert(__workflow_email);
                if (__workflow_ownerId != null)
                    callPayload.Queries["OwnerId"] = ExpressionConverter.Convert(__workflow_ownerId);
                if (__workflow_ownerType != null)
                    callPayload.Queries["OwnerType"] = ExpressionConverter.Convert(__workflow_ownerType);
                if (__workflow_accountSourceTypeId != null)
                    callPayload.Queries["AccountSourceTypeId"] = ExpressionConverter.Convert(__workflow_accountSourceTypeId);
                if (__workflow_leadStatusId != null)
                    callPayload.Queries["LeadStatusId"] = ExpressionConverter.Convert(__workflow_leadStatusId);
                if (__workflow_industryId != null)
                    callPayload.Queries["IndustryId"] = ExpressionConverter.Convert(__workflow_industryId);
                if (__workflow_status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<SalesPipelineApiFeaturesLeadLeadDto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesLeadLeadDto, ApiConnectionActionConfiguration> LeadCreate(Expression<Func<LeadCreateBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SalesPipelineApiFeaturesLeadLeadDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Lead";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SalesPipelineApiFeaturesLeadLeadDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesLeadLeadDto, ApiConnectionActionConfiguration> LeadGetById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<SalesPipelineApiFeaturesLeadLeadDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Lead/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SalesPipelineApiFeaturesLeadLeadDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LeadDelete(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Lead/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesLeadLeadDto, ApiConnectionActionConfiguration> LeadUpdate(Expression<Func<string>> id, Expression<Func<LeadUpdateBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SalesPipelineApiFeaturesLeadLeadDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Lead/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SalesPipelineApiFeaturesLeadLeadDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO[], ApiConnectionActionConfiguration> OpportunityGetAll(Expression<Func<string>> id = null, Expression<Func<string>> ownerId = null, Expression<Func<string>> name = null, Expression<Func<double>> amount = null, Expression<Func<string>> closeDate = null, Expression<Func<string>> updateDate = null, Expression<Func<string>> insertDate = null, Expression<Func<string>> accountId = null, Expression<Func<string>> forecastCategoryId = null, Expression<Func<string>> accountSourceTypeId = null, Expression<Func<string>> opportunityStatusId = null, Expression<Func<string>> quoteId = null, Expression<Func<string>> lossReasonId = null, Expression<Func<string>> typeId = null, Expression<Func<string>> lastModifiedBy = null, Expression<Func<string>> createdBy = null, Expression<Func<string>> search = null, Expression<Func<string>> salesPipelineId = null, Expression<Func<string>> status = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_ownerId = WorkflowExpression.Compile(ownerId, nameof(ownerId), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_amount = WorkflowExpression.Compile(amount, nameof(amount), required: false);
            var __workflow_closeDate = WorkflowExpression.Compile(closeDate, nameof(closeDate), required: false);
            var __workflow_updateDate = WorkflowExpression.Compile(updateDate, nameof(updateDate), required: false);
            var __workflow_insertDate = WorkflowExpression.Compile(insertDate, nameof(insertDate), required: false);
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: false);
            var __workflow_forecastCategoryId = WorkflowExpression.Compile(forecastCategoryId, nameof(forecastCategoryId), required: false);
            var __workflow_accountSourceTypeId = WorkflowExpression.Compile(accountSourceTypeId, nameof(accountSourceTypeId), required: false);
            var __workflow_opportunityStatusId = WorkflowExpression.Compile(opportunityStatusId, nameof(opportunityStatusId), required: false);
            var __workflow_quoteId = WorkflowExpression.Compile(quoteId, nameof(quoteId), required: false);
            var __workflow_lossReasonId = WorkflowExpression.Compile(lossReasonId, nameof(lossReasonId), required: false);
            var __workflow_typeId = WorkflowExpression.Compile(typeId, nameof(typeId), required: false);
            var __workflow_lastModifiedBy = WorkflowExpression.Compile(lastModifiedBy, nameof(lastModifiedBy), required: false);
            var __workflow_createdBy = WorkflowExpression.Compile(createdBy, nameof(createdBy), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_salesPipelineId = WorkflowExpression.Compile(salesPipelineId, nameof(salesPipelineId), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Opportunity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_ownerId != null)
                    callPayload.Queries["OwnerId"] = ExpressionConverter.Convert(__workflow_ownerId);
                if (__workflow_name != null)
                    callPayload.Queries["Name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_amount != null)
                    callPayload.Queries["Amount"] = ExpressionConverter.Convert(__workflow_amount);
                if (__workflow_closeDate != null)
                    callPayload.Queries["CloseDate"] = ExpressionConverter.Convert(__workflow_closeDate);
                if (__workflow_updateDate != null)
                    callPayload.Queries["UpdateDate"] = ExpressionConverter.Convert(__workflow_updateDate);
                if (__workflow_insertDate != null)
                    callPayload.Queries["InsertDate"] = ExpressionConverter.Convert(__workflow_insertDate);
                if (__workflow_accountId != null)
                    callPayload.Queries["AccountId"] = ExpressionConverter.Convert(__workflow_accountId);
                if (__workflow_forecastCategoryId != null)
                    callPayload.Queries["ForecastCategoryId"] = ExpressionConverter.Convert(__workflow_forecastCategoryId);
                if (__workflow_accountSourceTypeId != null)
                    callPayload.Queries["AccountSourceTypeId"] = ExpressionConverter.Convert(__workflow_accountSourceTypeId);
                if (__workflow_opportunityStatusId != null)
                    callPayload.Queries["OpportunityStatusId"] = ExpressionConverter.Convert(__workflow_opportunityStatusId);
                if (__workflow_quoteId != null)
                    callPayload.Queries["QuoteId"] = ExpressionConverter.Convert(__workflow_quoteId);
                if (__workflow_lossReasonId != null)
                    callPayload.Queries["LossReasonId"] = ExpressionConverter.Convert(__workflow_lossReasonId);
                if (__workflow_typeId != null)
                    callPayload.Queries["TypeId"] = ExpressionConverter.Convert(__workflow_typeId);
                if (__workflow_lastModifiedBy != null)
                    callPayload.Queries["LastModifiedBy"] = ExpressionConverter.Convert(__workflow_lastModifiedBy);
                if (__workflow_createdBy != null)
                    callPayload.Queries["CreatedBy"] = ExpressionConverter.Convert(__workflow_createdBy);
                if (__workflow_search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_salesPipelineId != null)
                    callPayload.Queries["SalesPipelineId"] = ExpressionConverter.Convert(__workflow_salesPipelineId);
                if (__workflow_status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO, ApiConnectionActionConfiguration> OpportunityCreate(Expression<Func<OpportunityCreateBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Opportunity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO, ApiConnectionActionConfiguration> OpportunityGetById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Opportunity/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> OpportunityDelete(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Opportunity/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO, ApiConnectionActionConfiguration> OpportunityUpdate(Expression<Func<string>> id, Expression<Func<OpportunityUpdateBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Opportunity/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<IdentityApiBackOfficeUsersGetUserGetUserResponse, ApiConnectionActionConfiguration> UserGetById(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<IdentityApiBackOfficeUsersGetUserGetUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IdentityApiBackOfficeUsersGetUserGetUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<IdentityApiTeamsDtosGetTeamResponse, ApiConnectionActionConfiguration> TeamGetById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<IdentityApiTeamsDtosGetTeamResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/teams/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IdentityApiTeamsDtosGetTeamResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<CustomerApiFeaturesAccountsAccountDTO, ApiConnectionActionConfiguration> AccountGetById(Expression<Func<string>> accountId)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            return new DeferredBodyAction<CustomerApiFeaturesAccountsAccountDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Account/{0}", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CustomerApiFeaturesAccountsAccountDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AccountDelete(Expression<Func<string>> accountId)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Account/{0}", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<CustomerApiFeaturesAccountsAccountDTO, ApiConnectionActionConfiguration> AccountUpdate(Expression<Func<string>> accountId, Expression<Func<AccountUpdateBodyInput>> body = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CustomerApiFeaturesAccountsAccountDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Account/{0}", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CustomerApiFeaturesAccountsAccountDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<CustomerApiFeaturesAccountsAccountDTO[], ApiConnectionActionConfiguration> AccountGetAll(Expression<Func<string>> parentAccount = null, Expression<Func<string>> phone = null, Expression<Func<string>> suggestions = null, Expression<Func<string>> ownerId = null, Expression<Func<string>> ownershipId = null, Expression<Func<string>> ratingId = null, Expression<Func<string>> classificationId = null, Expression<Func<string>> industryId = null, Expression<Func<string>> accountSourceTypeId = null, Expression<Func<string>> primaryContactId = null, Expression<Func<string>> assignedTeams = null, Expression<Func<string>> search = null, Expression<Func<string>> name = null, Expression<Func<string>> id = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
        {
            var __workflow_parentAccount = WorkflowExpression.Compile(parentAccount, nameof(parentAccount), required: false);
            var __workflow_phone = WorkflowExpression.Compile(phone, nameof(phone), required: false);
            var __workflow_suggestions = WorkflowExpression.Compile(suggestions, nameof(suggestions), required: false);
            var __workflow_ownerId = WorkflowExpression.Compile(ownerId, nameof(ownerId), required: false);
            var __workflow_ownershipId = WorkflowExpression.Compile(ownershipId, nameof(ownershipId), required: false);
            var __workflow_ratingId = WorkflowExpression.Compile(ratingId, nameof(ratingId), required: false);
            var __workflow_classificationId = WorkflowExpression.Compile(classificationId, nameof(classificationId), required: false);
            var __workflow_industryId = WorkflowExpression.Compile(industryId, nameof(industryId), required: false);
            var __workflow_accountSourceTypeId = WorkflowExpression.Compile(accountSourceTypeId, nameof(accountSourceTypeId), required: false);
            var __workflow_primaryContactId = WorkflowExpression.Compile(primaryContactId, nameof(primaryContactId), required: false);
            var __workflow_assignedTeams = WorkflowExpression.Compile(assignedTeams, nameof(assignedTeams), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<CustomerApiFeaturesAccountsAccountDTO[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Account";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_parentAccount != null)
                    callPayload.Queries["ParentAccount"] = ExpressionConverter.Convert(__workflow_parentAccount);
                if (__workflow_phone != null)
                    callPayload.Queries["Phone"] = ExpressionConverter.Convert(__workflow_phone);
                if (__workflow_suggestions != null)
                    callPayload.Queries["Suggestions"] = ExpressionConverter.Convert(__workflow_suggestions);
                if (__workflow_ownerId != null)
                    callPayload.Queries["OwnerId"] = ExpressionConverter.Convert(__workflow_ownerId);
                if (__workflow_ownershipId != null)
                    callPayload.Queries["OwnershipId"] = ExpressionConverter.Convert(__workflow_ownershipId);
                if (__workflow_ratingId != null)
                    callPayload.Queries["RatingId"] = ExpressionConverter.Convert(__workflow_ratingId);
                if (__workflow_classificationId != null)
                    callPayload.Queries["ClassificationId"] = ExpressionConverter.Convert(__workflow_classificationId);
                if (__workflow_industryId != null)
                    callPayload.Queries["IndustryId"] = ExpressionConverter.Convert(__workflow_industryId);
                if (__workflow_accountSourceTypeId != null)
                    callPayload.Queries["AccountSourceTypeId"] = ExpressionConverter.Convert(__workflow_accountSourceTypeId);
                if (__workflow_primaryContactId != null)
                    callPayload.Queries["PrimaryContactId"] = ExpressionConverter.Convert(__workflow_primaryContactId);
                if (__workflow_assignedTeams != null)
                    callPayload.Queries["AssignedTeams"] = ExpressionConverter.Convert(__workflow_assignedTeams);
                if (__workflow_search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_name != null)
                    callPayload.Queries["Name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<CustomerApiFeaturesAccountsAccountDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<CustomerApiFeaturesAccountsAccountDTO, ApiConnectionActionConfiguration> AccountCreate(Expression<Func<AccountCreateBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CustomerApiFeaturesAccountsAccountDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Account";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CustomerApiFeaturesAccountsAccountDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<CustomerApiFeaturesContactsContact, ApiConnectionActionConfiguration> ContactGetById(Expression<Func<string>> contactId)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            return new DeferredBodyAction<CustomerApiFeaturesContactsContact, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Contact/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CustomerApiFeaturesContactsContact>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ContactDelete(Expression<Func<string>> contactId)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Contact/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<CustomerApiFeaturesContactsContactDTO, ApiConnectionActionConfiguration> ContactUpdate(Expression<Func<string>> contactId, Expression<Func<ContactUpdateBodyInput>> body = null)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CustomerApiFeaturesContactsContactDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Contact/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CustomerApiFeaturesContactsContactDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<CustomerApiFeaturesContactsContactDTO[], ApiConnectionActionConfiguration> ContactGetAll(Expression<Func<string>> name = null, Expression<Func<string>> ownerId = null, Expression<Func<string>> suggestions = null, Expression<Func<string>> accountSourceTypeId = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lastName = null, Expression<Func<string>> phone = null, Expression<Func<string>> mobilePhone = null, Expression<Func<string>> accountIds = null, Expression<Func<string>> email = null, Expression<Func<string>> id = null, Expression<Func<string>> assignedTeams = null, Expression<Func<string>> search = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_ownerId = WorkflowExpression.Compile(ownerId, nameof(ownerId), required: false);
            var __workflow_suggestions = WorkflowExpression.Compile(suggestions, nameof(suggestions), required: false);
            var __workflow_accountSourceTypeId = WorkflowExpression.Compile(accountSourceTypeId, nameof(accountSourceTypeId), required: false);
            var __workflow_firstName = WorkflowExpression.Compile(firstName, nameof(firstName), required: false);
            var __workflow_lastName = WorkflowExpression.Compile(lastName, nameof(lastName), required: false);
            var __workflow_phone = WorkflowExpression.Compile(phone, nameof(phone), required: false);
            var __workflow_mobilePhone = WorkflowExpression.Compile(mobilePhone, nameof(mobilePhone), required: false);
            var __workflow_accountIds = WorkflowExpression.Compile(accountIds, nameof(accountIds), required: false);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_assignedTeams = WorkflowExpression.Compile(assignedTeams, nameof(assignedTeams), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<CustomerApiFeaturesContactsContactDTO[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Contact";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["Name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_ownerId != null)
                    callPayload.Queries["OwnerId"] = ExpressionConverter.Convert(__workflow_ownerId);
                if (__workflow_suggestions != null)
                    callPayload.Queries["Suggestions"] = ExpressionConverter.Convert(__workflow_suggestions);
                if (__workflow_accountSourceTypeId != null)
                    callPayload.Queries["AccountSourceTypeId"] = ExpressionConverter.Convert(__workflow_accountSourceTypeId);
                if (__workflow_firstName != null)
                    callPayload.Queries["FirstName"] = ExpressionConverter.Convert(__workflow_firstName);
                if (__workflow_lastName != null)
                    callPayload.Queries["LastName"] = ExpressionConverter.Convert(__workflow_lastName);
                if (__workflow_phone != null)
                    callPayload.Queries["Phone"] = ExpressionConverter.Convert(__workflow_phone);
                if (__workflow_mobilePhone != null)
                    callPayload.Queries["MobilePhone"] = ExpressionConverter.Convert(__workflow_mobilePhone);
                if (__workflow_accountIds != null)
                    callPayload.Queries["AccountIds"] = ExpressionConverter.Convert(__workflow_accountIds);
                if (__workflow_email != null)
                    callPayload.Queries["Email"] = ExpressionConverter.Convert(__workflow_email);
                if (__workflow_id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_assignedTeams != null)
                    callPayload.Queries["AssignedTeams"] = ExpressionConverter.Convert(__workflow_assignedTeams);
                if (__workflow_search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<CustomerApiFeaturesContactsContactDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<CustomerApiFeaturesContactsContactDTO, ApiConnectionActionConfiguration> ContactCreate(Expression<Func<ContactCreateBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CustomerApiFeaturesContactsContactDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CustomerApiFeaturesContactsContactDTO>(callPayload);
            });
        }
    }

    public class SoftonewebcrmTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> CallCreated(Expression<Func<CallCreatedBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/call/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> OpportunityUpdated(Expression<Func<CallCreatedBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/opportunity/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> OpportunityDeleted(Expression<Func<CallCreatedBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/opportunity/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> OpportunityCreated(Expression<Func<CallCreatedBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/opportunity/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> LeadUpdated(Expression<Func<CallCreatedBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/lead/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> LeadDeleted(Expression<Func<CallCreatedBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/lead/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> LeadCreated(Expression<Func<CallCreatedBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/lead/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> TaskUpdated(Expression<Func<CallCreatedBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/task/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> TaskDeleted(Expression<Func<CallCreatedBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/task/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> TaskCreated(Expression<Func<CallCreatedBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/task/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> EventUpdated(Expression<Func<CallCreatedBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/event/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> EventDeleted(Expression<Func<CallCreatedBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/event/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> EventCreated(Expression<Func<CallCreatedBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/event/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> CallDeleted(Expression<Func<CallCreatedBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/call/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> CallUpdated(Expression<Func<CallCreatedBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/call/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class TaskApiFeaturesCallsCallDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("insertDate")]
        public string InsertDate { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("taskType")]
        public CallCreateTaskApiModelsEnumsTaskTypeResponse TaskType { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("assignedToType")]
        public CallCreateTaskApiModelsEnumsAssignedToTypeResponse AssignedToType { get; set; }

        [JsonProperty("assignedToId")]
        public string AssignedToId { get; set; }

        [JsonProperty("relatedToType")]
        public CallCreateTaskApiModelsEnumsRelatedToTypeResponse RelatedToType { get; set; }

        [JsonProperty("relatedToId")]
        public string RelatedToId { get; set; }

        [JsonProperty("contactType")]
        public CallCreateTaskApiModelsEnumsContactTypeResponse ContactType { get; set; }

        [JsonProperty("contactIds")]
        public string[] ContactIds { get; set; }

        [JsonProperty("status")]
        public CallCreateTaskApiModelsEnumsStatusResponse Status { get; set; }

        [JsonProperty("callDuration")]
        public string CallDuration { get; set; }

        [JsonProperty("callResultId")]
        public string CallResultId { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("editorBody")]
        public string EditorBody { get; set; }

        [JsonProperty("priorityId")]
        public string PriorityId { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("reminderSet")]
        public bool ReminderSet { get; set; }

        [JsonProperty("sortDate")]
        public string SortDate { get; set; }

        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        [JsonProperty("sourceAssignedToId")]
        public string SourceAssignedToId { get; set; }

        [JsonProperty("sourceRelatedToId")]
        public string SourceRelatedToId { get; set; }

        [JsonProperty("sourceContactIds")]
        public string[] SourceContactIds { get; set; }

        [JsonProperty("callDirection")]
        public CallCreateTaskApiModelsEnumsCallDirectionResponse CallDirection { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CallCreateTaskApiModelsEnumsTaskTypeResponse
    {
        [EnumMember(Value = "Task")]
        TaskObject,
        Event,
        Call,
        Email,
        ScheduleVisit,
        Visit,
        Note
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CallCreateTaskApiModelsEnumsAssignedToTypeResponse
    {
        People,
        Queues
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CallCreateTaskApiModelsEnumsRelatedToTypeResponse
    {
        Account,
        Opportunity,
        Quote
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CallCreateTaskApiModelsEnumsContactTypeResponse
    {
        Lead,
        Contact
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CallCreateTaskApiModelsEnumsStatusResponse
    {
        Open,
        Completed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CallCreateTaskApiModelsEnumsCallDirectionResponse
    {
        Unknown,
        Inbound,
        Outbound
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CallGetAllStatusInput
    {
        Open,
        Completed
    }

    public class CallCreateBodyInput
    {
        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("assignedToType")]
        public CallCreateTaskApiModelsEnumsAssignedToType? AssignedToType { get; set; }

        [JsonProperty("assignedToId")]
        public string AssignedToId { get; set; }

        [JsonProperty("relatedToType")]
        public CallCreateTaskApiModelsEnumsRelatedToType? RelatedToType { get; set; }

        [JsonProperty("relatedToId")]
        public string RelatedToId { get; set; }

        [JsonProperty("contactType")]
        public CallCreateTaskApiModelsEnumsContactType? ContactType { get; set; }

        [JsonProperty("contactIds")]
        public string[] ContactIds { get; set; }

        [JsonProperty("status")]
        public CallCreateTaskApiModelsEnumsStatus? Status { get; set; }

        [JsonProperty("callDuration")]
        public string CallDuration { get; set; }

        [JsonProperty("callResultId")]
        public string CallResultId { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("editorBody")]
        public string EditorBody { get; set; }

        [JsonProperty("priorityId")]
        public string PriorityId { get; set; }

        [JsonProperty("position")]
        public int? Position { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("reminderSet")]
        public bool? ReminderSet { get; set; }

        [JsonProperty("sortDate")]
        public string SortDate { get; set; }

        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        [JsonProperty("sourceAssignedToId")]
        public string SourceAssignedToId { get; set; }

        [JsonProperty("sourceRelatedToId")]
        public string SourceRelatedToId { get; set; }

        [JsonProperty("sourceContactIds")]
        public string[] SourceContactIds { get; set; }

        [JsonProperty("callDirection")]
        public CallCreateTaskApiModelsEnumsCallDirection? CallDirection { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CallCreateTaskApiModelsEnumsAssignedToType
    {
        People,
        Queues
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CallCreateTaskApiModelsEnumsRelatedToType
    {
        Account,
        Opportunity,
        Quote
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CallCreateTaskApiModelsEnumsContactType
    {
        Lead,
        Contact
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CallCreateTaskApiModelsEnumsStatus
    {
        Open,
        Completed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CallCreateTaskApiModelsEnumsCallDirection
    {
        Unknown,
        Inbound,
        Outbound
    }

    public class CallUpdateBodyInput
    {
        [JsonProperty("taskType")]
        public CallUpdateTaskApiModelsEnumsTaskType? TaskType { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("assignedToType")]
        public CallCreateTaskApiModelsEnumsAssignedToType? AssignedToType { get; set; }

        [JsonProperty("assignedToId")]
        public string AssignedToId { get; set; }

        [JsonProperty("relatedToType")]
        public CallCreateTaskApiModelsEnumsRelatedToType? RelatedToType { get; set; }

        [JsonProperty("relatedToId")]
        public string RelatedToId { get; set; }

        [JsonProperty("contactType")]
        public CallCreateTaskApiModelsEnumsContactType? ContactType { get; set; }

        [JsonProperty("contactIds")]
        public string[] ContactIds { get; set; }

        [JsonProperty("status")]
        public CallCreateTaskApiModelsEnumsStatus? Status { get; set; }

        [JsonProperty("callDuration")]
        public string CallDuration { get; set; }

        [JsonProperty("callResultId")]
        public string CallResultId { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("editorBody")]
        public string EditorBody { get; set; }

        [JsonProperty("priorityId")]
        public string PriorityId { get; set; }

        [JsonProperty("position")]
        public int? Position { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("reminderSet")]
        public bool? ReminderSet { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("sortDate")]
        public string SortDate { get; set; }

        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        [JsonProperty("sourceAssignedToId")]
        public string SourceAssignedToId { get; set; }

        [JsonProperty("sourceRelatedToId")]
        public string SourceRelatedToId { get; set; }

        [JsonProperty("sourceContactIds")]
        public string[] SourceContactIds { get; set; }

        [JsonProperty("callDirection")]
        public CallCreateTaskApiModelsEnumsCallDirection? CallDirection { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CallUpdateTaskApiModelsEnumsTaskType
    {
        [EnumMember(Value = "Task")]
        TaskObject,
        Event,
        Call,
        Email,
        ScheduleVisit,
        Visit,
        Note
    }

    public class TaskApiFeaturesEventsEventDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("insertDate")]
        public string InsertDate { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("taskType")]
        public CallCreateTaskApiModelsEnumsTaskTypeResponse TaskType { get; set; }

        [JsonProperty("assignedToType")]
        public CallCreateTaskApiModelsEnumsAssignedToTypeResponse AssignedToType { get; set; }

        [JsonProperty("assignedToId")]
        public string AssignedToId { get; set; }

        [JsonProperty("relatedToType")]
        public CallCreateTaskApiModelsEnumsRelatedToTypeResponse RelatedToType { get; set; }

        [JsonProperty("relatedToId")]
        public string RelatedToId { get; set; }

        [JsonProperty("contactType")]
        public CallCreateTaskApiModelsEnumsContactTypeResponse ContactType { get; set; }

        [JsonProperty("contactIds")]
        public string[] ContactIds { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("editorBody")]
        public string EditorBody { get; set; }

        [JsonProperty("priorityId")]
        public string PriorityId { get; set; }

        [JsonProperty("location")]
        public EventCreateTaskApiFeaturesEventsLocationDTOResponse Location { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("reminderSet")]
        public bool ReminderSet { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("repeat")]
        public string Repeat { get; set; }

        [JsonProperty("eventStatus")]
        public EventCreateTaskApiModelsEnumsEventStatusResponse EventStatus { get; set; }

        [JsonProperty("eventResultId")]
        public string EventResultId { get; set; }

        [JsonProperty("recurrenceInterval")]
        public string RecurrenceInterval { get; set; }

        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        [JsonProperty("sourceAssignedToId")]
        public string SourceAssignedToId { get; set; }

        [JsonProperty("sourceRelatedToId")]
        public string SourceRelatedToId { get; set; }

        [JsonProperty("sourceContactIds")]
        public string[] SourceContactIds { get; set; }

        [JsonProperty("teamMembers")]
        public string[] TeamMembers { get; set; }
    }

    public class EventCreateTaskApiFeaturesEventsLocationDTOResponse
    {
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EventCreateTaskApiModelsEnumsEventStatusResponse
    {
        Scheduled,
        Completed,
        Rescheduled,
        Canceled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EventGetAllStatusInput
    {
        Scheduled,
        Completed,
        Rescheduled,
        Canceled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EventStatusInput
    {
        Scheduled,
        Completed,
        Rescheduled,
        Canceled
    }

    public class EventCreateBodyInput
    {
        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("taskType")]
        public CallUpdateTaskApiModelsEnumsTaskType? TaskType { get; set; }

        [JsonProperty("assignedToType")]
        public CallCreateTaskApiModelsEnumsAssignedToType? AssignedToType { get; set; }

        [JsonProperty("assignedToId")]
        public string AssignedToId { get; set; }

        [JsonProperty("relatedToType")]
        public CallCreateTaskApiModelsEnumsRelatedToType? RelatedToType { get; set; }

        [JsonProperty("relatedToId")]
        public string RelatedToId { get; set; }

        [JsonProperty("contactType")]
        public CallCreateTaskApiModelsEnumsContactType? ContactType { get; set; }

        [JsonProperty("contactIds")]
        public string[] ContactIds { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("editorBody")]
        public string EditorBody { get; set; }

        [JsonProperty("priorityId")]
        public string PriorityId { get; set; }

        [JsonProperty("location")]
        public EventCreateTaskApiFeaturesEventsLocationDTO Location { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("reminderSet")]
        public bool? ReminderSet { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("position")]
        public int? Position { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("repeat")]
        public string Repeat { get; set; }

        [JsonProperty("eventStatus")]
        public EventCreateTaskApiModelsEnumsEventStatus? EventStatus { get; set; }

        [JsonProperty("eventResultId")]
        public string EventResultId { get; set; }

        [JsonProperty("recurrenceInterval")]
        public string RecurrenceInterval { get; set; }

        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        [JsonProperty("sourceAssignedToId")]
        public string SourceAssignedToId { get; set; }

        [JsonProperty("sourceRelatedToId")]
        public string SourceRelatedToId { get; set; }

        [JsonProperty("sourceContactIds")]
        public string[] SourceContactIds { get; set; }

        [JsonProperty("teamMembers")]
        public string[] TeamMembers { get; set; }
    }

    public class EventCreateTaskApiFeaturesEventsLocationDTO
    {
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EventCreateTaskApiModelsEnumsEventStatus
    {
        Scheduled,
        Completed,
        Rescheduled,
        Canceled
    }

    public class TaskApiFeaturesNotesNoteDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("relatedToType")]
        public CallCreateTaskApiModelsEnumsRelatedToTypeResponse RelatedToType { get; set; }

        [JsonProperty("relatedToId")]
        public string RelatedToId { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("editorBody")]
        public string EditorBody { get; set; }

        [JsonProperty("insertDate")]
        public string InsertDate { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("contactIds")]
        public string[] ContactIds { get; set; }

        [JsonProperty("contactType")]
        public CallCreateTaskApiModelsEnumsContactTypeResponse ContactType { get; set; }

        [JsonProperty("taskType")]
        public CallCreateTaskApiModelsEnumsTaskTypeResponse TaskType { get; set; }

        [JsonProperty("sortDate")]
        public string SortDate { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RelatedToTypeInput
    {
        Account,
        Opportunity,
        Quote
    }

    public class NoteCreateBodyInput
    {
        [JsonProperty("taskType")]
        public CallUpdateTaskApiModelsEnumsTaskType? TaskType { get; set; }

        [JsonProperty("relatedToType")]
        public CallCreateTaskApiModelsEnumsRelatedToType? RelatedToType { get; set; }

        [JsonProperty("contactType")]
        public CallCreateTaskApiModelsEnumsContactType? ContactType { get; set; }

        [JsonProperty("relatedToId")]
        public string RelatedToId { get; set; }

        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("editorBody")]
        public string EditorBody { get; set; }

        [JsonProperty("contactIds")]
        public string[] ContactIds { get; set; }
    }

    public class NoteUpdateBodyInput
    {
        [JsonProperty("relatedToType")]
        public CallCreateTaskApiModelsEnumsRelatedToType? RelatedToType { get; set; }

        [JsonProperty("relatedToId")]
        public string RelatedToId { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("editorBody")]
        public string EditorBody { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("contactIds")]
        public string[] ContactIds { get; set; }

        [JsonProperty("contactType")]
        public CallCreateTaskApiModelsEnumsContactType? ContactType { get; set; }
    }

    public class TaskApiFeaturesTasksTaskDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("insertDate")]
        public string InsertDate { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("taskType")]
        public CallCreateTaskApiModelsEnumsTaskTypeResponse TaskType { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("completedDate")]
        public string CompletedDate { get; set; }

        [JsonProperty("status")]
        public CallCreateTaskApiModelsEnumsStatusResponse Status { get; set; }

        [JsonProperty("priorityId")]
        public string PriorityId { get; set; }

        [JsonProperty("assignedToId")]
        public string AssignedToId { get; set; }

        [JsonProperty("assignedToType")]
        public CallCreateTaskApiModelsEnumsAssignedToTypeResponse AssignedToType { get; set; }

        [JsonProperty("contactIds")]
        public string[] ContactIds { get; set; }

        [JsonProperty("contactType")]
        public CallCreateTaskApiModelsEnumsContactTypeResponse ContactType { get; set; }

        [JsonProperty("relatedToId")]
        public string RelatedToId { get; set; }

        [JsonProperty("relatedToType")]
        public CallCreateTaskApiModelsEnumsRelatedToTypeResponse RelatedToType { get; set; }

        [JsonProperty("taskSubTypeId")]
        public string TaskSubTypeId { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("editorBody")]
        public string EditorBody { get; set; }

        [JsonProperty("reminderSet")]
        public bool ReminderSet { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TypeInput
    {
        [EnumMember(Value = "Task")]
        TaskObject,
        Event,
        Call,
        Email,
        ScheduleVisit,
        Visit,
        Note
    }

    public class TaskCreateBodyInput
    {
        [JsonProperty("taskType")]
        public CallUpdateTaskApiModelsEnumsTaskType? TaskType { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("status")]
        public CallCreateTaskApiModelsEnumsStatus? Status { get; set; }

        [JsonProperty("priorityId")]
        public string PriorityId { get; set; }

        [JsonProperty("assignedToId")]
        public string AssignedToId { get; set; }

        [JsonProperty("assignedToType")]
        public CallCreateTaskApiModelsEnumsAssignedToType? AssignedToType { get; set; }

        [JsonProperty("contactIds")]
        public string[] ContactIds { get; set; }

        [JsonProperty("contactType")]
        public CallCreateTaskApiModelsEnumsContactType? ContactType { get; set; }

        [JsonProperty("relatedToId")]
        public string RelatedToId { get; set; }

        [JsonProperty("relatedToType")]
        public CallCreateTaskApiModelsEnumsRelatedToType? RelatedToType { get; set; }

        [JsonProperty("taskSubTypeId")]
        public string TaskSubTypeId { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("editorBody")]
        public string EditorBody { get; set; }

        [JsonProperty("reminderSet")]
        public bool? ReminderSet { get; set; }

        [JsonProperty("position")]
        public int? Position { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }
    }

    public class TaskUpdateBodyInput
    {
        [JsonProperty("taskType")]
        public CallUpdateTaskApiModelsEnumsTaskType? TaskType { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("completedDate")]
        public string CompletedDate { get; set; }

        [JsonProperty("status")]
        public CallCreateTaskApiModelsEnumsStatus? Status { get; set; }

        [JsonProperty("priorityId")]
        public string PriorityId { get; set; }

        [JsonProperty("assignedToId")]
        public string AssignedToId { get; set; }

        [JsonProperty("assignedToType")]
        public CallCreateTaskApiModelsEnumsAssignedToType? AssignedToType { get; set; }

        [JsonProperty("contactIds")]
        public string[] ContactIds { get; set; }

        [JsonProperty("contactType")]
        public CallCreateTaskApiModelsEnumsContactType? ContactType { get; set; }

        [JsonProperty("relatedToId")]
        public string RelatedToId { get; set; }

        [JsonProperty("relatedToType")]
        public CallCreateTaskApiModelsEnumsRelatedToType? RelatedToType { get; set; }

        [JsonProperty("taskSubTypeId")]
        public string TaskSubTypeId { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("editorBody")]
        public string EditorBody { get; set; }

        [JsonProperty("reminderSet")]
        public bool? ReminderSet { get; set; }

        [JsonProperty("position")]
        public int? Position { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }
    }

    public class SalesPipelineApiFeaturesLeadLeadDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("leadStatusId")]
        public string LeadStatusId { get; set; }

        [JsonProperty("name")]
        public LeadCreateSalesPipelineApiDTOsNameDTOResponse Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("otherEmail")]
        public LeadCreateSalesPipelineApiDTOsEmailDTOResponse[] OtherEmail { get; set; }

        [JsonProperty("otherPhone")]
        public LeadCreateSalesPipelineApiDTOsPhoneDTOResponse[] OtherPhone { get; set; }

        [JsonProperty("callOptOut")]
        public bool CallOptOut { get; set; }

        [JsonProperty("emailOptOut")]
        public bool EmailOptOut { get; set; }

        [JsonProperty("ratingId")]
        public string RatingId { get; set; }

        [JsonProperty("insertDate")]
        public string InsertDate { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty("ownerType")]
        public LeadCreateSalesPipelineApiModelsEnumsOwnerTypeResponse OwnerType { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("industryId")]
        public string IndustryId { get; set; }

        [JsonProperty("noOfEmployees")]
        public int NoOfEmployees { get; set; }

        [JsonProperty("accountSourceTypeId")]
        public string AccountSourceTypeId { get; set; }

        [JsonProperty("address")]
        public LeadCreateSalesPipelineApiDTOsAddressDtoResponse Address { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("annualRevenue")]
        public double AnnualRevenue { get; set; }

        [JsonProperty("lastTransferDate")]
        public string LastTransferDate { get; set; }

        [JsonProperty("genderId")]
        public string GenderId { get; set; }

        [JsonProperty("pronounceId")]
        public string PronounceId { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("status")]
        public LeadCreateSalesPipelineApiModelsEnumsStatusResponse Status { get; set; }

        [JsonProperty("extraFields")]
        public JToken ExtraFields { get; set; }

        [JsonProperty("aiScore")]
        public double AiScore { get; set; }

        [JsonProperty("aiScoreReasoning")]
        public string AiScoreReasoning { get; set; }

        [JsonProperty("aiSentiment")]
        public SalesPipelineApiFeaturesLeadUpdateLeadScoreLeadSentiment AiSentiment { get; set; }

        [JsonProperty("aiGenerationDate")]
        public string AiGenerationDate { get; set; }
    }

    public class LeadCreateSalesPipelineApiDTOsNameDTOResponse
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("salutationId")]
        public string SalutationId { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }
    }

    public class LeadCreateSalesPipelineApiDTOsEmailDTOResponse
    {
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("type")]
        public LeadCreateSalesPipelineApiModelsEnumsEmailTypeResponse Type { get; set; }

        [JsonProperty("optOut")]
        public bool OptOut { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LeadCreateSalesPipelineApiModelsEnumsEmailTypeResponse
    {
        Work,
        Home,
        Other,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    public class LeadCreateSalesPipelineApiDTOsPhoneDTOResponse
    {
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("type")]
        public LeadCreateSalesPipelineApiModelsEnumsPhoneTypeResponse Type { get; set; }

        [JsonProperty("optOut")]
        public bool OptOut { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LeadCreateSalesPipelineApiModelsEnumsPhoneTypeResponse
    {
        Work,
        Home,
        Other,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LeadCreateSalesPipelineApiModelsEnumsOwnerTypeResponse
    {
        People,
        Queues
    }

    public class LeadCreateSalesPipelineApiDTOsAddressDtoResponse
    {
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LeadCreateSalesPipelineApiModelsEnumsStatusResponse
    {
        Default,
        Qualified,
        Unqualified
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SalesPipelineApiFeaturesLeadUpdateLeadScoreLeadSentiment
    {
        Unqualified,
        Stalled,
        Cold,
        Warm,
        Hot
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OwnerTypeInput
    {
        People,
        Queues
    }

    public class LeadCreateBodyInput
    {
        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("leadStatusId")]
        public string LeadStatusId { get; set; }

        [JsonProperty("name")]
        public LeadCreateSalesPipelineApiDTOsNameDTO Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("otherEmail")]
        public LeadCreateSalesPipelineApiDTOsEmailDTO[] OtherEmail { get; set; }

        [JsonProperty("otherPhone")]
        public LeadCreateSalesPipelineApiDTOsPhoneDTO[] OtherPhone { get; set; }

        [JsonProperty("callOptOut")]
        public bool? CallOptOut { get; set; }

        [JsonProperty("emailOptOut")]
        public bool? EmailOptOut { get; set; }

        [JsonProperty("ratingId")]
        public string RatingId { get; set; }

        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty("ownerType")]
        public LeadCreateSalesPipelineApiModelsEnumsOwnerType? OwnerType { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("industryId")]
        public string IndustryId { get; set; }

        [JsonProperty("noOfEmployees")]
        public int? NoOfEmployees { get; set; }

        [JsonProperty("accountSourceTypeId")]
        public string AccountSourceTypeId { get; set; }

        [JsonProperty("address")]
        public LeadCreateSalesPipelineApiDTOsAddressDto Address { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("annualRevenue")]
        public double? AnnualRevenue { get; set; }

        [JsonProperty("lastTransferDate")]
        public string LastTransferDate { get; set; }

        [JsonProperty("genderId")]
        public string GenderId { get; set; }

        [JsonProperty("pronounceId")]
        public string PronounceId { get; set; }

        [JsonProperty("status")]
        public LeadCreateSalesPipelineApiModelsEnumsStatus? Status { get; set; }

        [JsonProperty("extraFields")]
        public JToken ExtraFields { get; set; }
    }

    public class LeadCreateSalesPipelineApiDTOsNameDTO
    {
        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("salutationId")]
        public string SalutationId { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }
    }

    public class LeadCreateSalesPipelineApiDTOsEmailDTO
    {
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("type")]
        public LeadCreateSalesPipelineApiModelsEnumsEmailType? Type { get; set; }

        [JsonProperty("optOut")]
        public bool? OptOut { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LeadCreateSalesPipelineApiModelsEnumsEmailType
    {
        Work,
        Home,
        Other,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    public class LeadCreateSalesPipelineApiDTOsPhoneDTO
    {
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("type")]
        public LeadCreateSalesPipelineApiModelsEnumsPhoneType? Type { get; set; }

        [JsonProperty("optOut")]
        public bool? OptOut { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LeadCreateSalesPipelineApiModelsEnumsPhoneType
    {
        Work,
        Home,
        Other,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LeadCreateSalesPipelineApiModelsEnumsOwnerType
    {
        People,
        Queues
    }

    public class LeadCreateSalesPipelineApiDTOsAddressDto
    {
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LeadCreateSalesPipelineApiModelsEnumsStatus
    {
        Default,
        Qualified,
        Unqualified
    }

    public class LeadUpdateBodyInput
    {
        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("leadStatusId")]
        public string LeadStatusId { get; set; }

        [JsonProperty("name")]
        public LeadCreateSalesPipelineApiDTOsNameDTO Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("otherEmail")]
        public LeadCreateSalesPipelineApiDTOsEmailDTO[] OtherEmail { get; set; }

        [JsonProperty("otherPhone")]
        public LeadCreateSalesPipelineApiDTOsPhoneDTO[] OtherPhone { get; set; }

        [JsonProperty("callOptOut")]
        public bool? CallOptOut { get; set; }

        [JsonProperty("emailOptOut")]
        public bool? EmailOptOut { get; set; }

        [JsonProperty("ratingId")]
        public string RatingId { get; set; }

        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty("ownerType")]
        public LeadCreateSalesPipelineApiModelsEnumsOwnerType? OwnerType { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("industryId")]
        public string IndustryId { get; set; }

        [JsonProperty("noOfEmployees")]
        public int? NoOfEmployees { get; set; }

        [JsonProperty("accountSourceTypeId")]
        public string AccountSourceTypeId { get; set; }

        [JsonProperty("address")]
        public LeadCreateSalesPipelineApiDTOsAddressDto Address { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("annualRevenue")]
        public double? AnnualRevenue { get; set; }

        [JsonProperty("lastTransferDate")]
        public string LastTransferDate { get; set; }

        [JsonProperty("genderId")]
        public string GenderId { get; set; }

        [JsonProperty("pronounceId")]
        public string PronounceId { get; set; }

        [JsonProperty("status")]
        public LeadCreateSalesPipelineApiModelsEnumsStatus? Status { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("extraFields")]
        public JToken ExtraFields { get; set; }
    }

    public class SalesPipelineApiFeaturesOpportunityOpportunityDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("typeId")]
        public string TypeId { get; set; }

        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("forecastCategoryId")]
        public string ForecastCategoryId { get; set; }

        [JsonProperty("salesPipelineId")]
        public string SalesPipelineId { get; set; }

        [JsonProperty("insertDate")]
        public string InsertDate { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("closeDate")]
        public string CloseDate { get; set; }

        [JsonProperty("probability")]
        public int Probability { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quoteId")]
        public string QuoteId { get; set; }

        [JsonProperty("opportunityStatusId")]
        public string OpportunityStatusId { get; set; }

        [JsonProperty("status")]
        public OpportunityCreateSalesPipelineApiModelsEnumsOpportunityStatusResponse Status { get; set; }

        [JsonProperty("accountSourceTypeId")]
        public string AccountSourceTypeId { get; set; }

        [JsonProperty("nextStep")]
        public string NextStep { get; set; }

        [JsonProperty("budgetConfirmed")]
        public bool BudgetConfirmed { get; set; }

        [JsonProperty("discoveryCompleted")]
        public bool DiscoveryCompleted { get; set; }

        [JsonProperty("expectedRevenue")]
        public double ExpectedRevenue { get; set; }

        [JsonProperty("lossReasonId")]
        public string LossReasonId { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("extraFields")]
        public JToken ExtraFields { get; set; }

        [JsonProperty("aiScore")]
        public double AiScore { get; set; }

        [JsonProperty("aiScoreReasoning")]
        public string AiScoreReasoning { get; set; }

        [JsonProperty("aiSentiment")]
        public SalesPipelineApiFeaturesOpportunityUpdateOpportunityScoreOpportunitySentiment AiSentiment { get; set; }

        [JsonProperty("aiGenerationDate")]
        public string AiGenerationDate { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpportunityCreateSalesPipelineApiModelsEnumsOpportunityStatusResponse
    {
        Open,
        Won,
        Lost,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SalesPipelineApiFeaturesOpportunityUpdateOpportunityScoreOpportunitySentiment
    {
        Unqualified,
        Stalled,
        Cold,
        Warm,
        Hot
    }

    public class OpportunityCreateBodyInput
    {
        [JsonProperty("typeId")]
        public string TypeId { get; set; }

        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("amount")]
        public double? Amount { get; set; }

        [JsonProperty("forecastCategoryId")]
        public string ForecastCategoryId { get; set; }

        [JsonProperty("salesPipelineId")]
        public string SalesPipelineId { get; set; }

        [JsonProperty("closeDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CloseDate { get; set; }

        [JsonProperty("probability")]
        public int? Probability { get; set; }

        [JsonProperty("score")]
        public int? Score { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quoteId")]
        public string QuoteId { get; set; }

        [JsonProperty("opportunityStatusId")]
        public string OpportunityStatusId { get; set; }

        [JsonProperty("status")]
        public OpportunityCreateSalesPipelineApiModelsEnumsOpportunityStatus? Status { get; set; }

        [JsonProperty("accountSourceTypeId")]
        public string AccountSourceTypeId { get; set; }

        [JsonProperty("nextStep")]
        public string NextStep { get; set; }

        [JsonProperty("budgetConfirmed")]
        public bool? BudgetConfirmed { get; set; }

        [JsonProperty("discoveryCompleted")]
        public bool? DiscoveryCompleted { get; set; }

        [JsonProperty("expectedRevenue")]
        public double? ExpectedRevenue { get; set; }

        [JsonProperty("lossReasonId")]
        public string LossReasonId { get; set; }

        [JsonProperty("private")]
        public bool? Private { get; set; }

        [JsonProperty("extraFields")]
        public JToken ExtraFields { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpportunityCreateSalesPipelineApiModelsEnumsOpportunityStatus
    {
        Open,
        Won,
        Lost,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    public class OpportunityUpdateBodyInput
    {
        [JsonProperty("typeId")]
        public string TypeId { get; set; }

        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("amount")]
        public double? Amount { get; set; }

        [JsonProperty("forecastCategoryId")]
        public string ForecastCategoryId { get; set; }

        [JsonProperty("closeDate")]
        public string CloseDate { get; set; }

        [JsonProperty("probability")]
        public int? Probability { get; set; }

        [JsonProperty("score")]
        public int? Score { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("salesPipelineId")]
        public string SalesPipelineId { get; set; }

        [JsonProperty("quoteId")]
        public string QuoteId { get; set; }

        [JsonProperty("opportunityStatusId")]
        public string OpportunityStatusId { get; set; }

        [JsonProperty("status")]
        public OpportunityCreateSalesPipelineApiModelsEnumsOpportunityStatus? Status { get; set; }

        [JsonProperty("accountSourceTypeId")]
        public string AccountSourceTypeId { get; set; }

        [JsonProperty("nextStep")]
        public string NextStep { get; set; }

        [JsonProperty("budgetConfirmed")]
        public bool? BudgetConfirmed { get; set; }

        [JsonProperty("discoveryCompleted")]
        public bool? DiscoveryCompleted { get; set; }

        [JsonProperty("expectedRevenue")]
        public double? ExpectedRevenue { get; set; }

        [JsonProperty("lossReasonId")]
        public string LossReasonId { get; set; }

        [JsonProperty("private")]
        public bool? Private { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("extraFields")]
        public JToken ExtraFields { get; set; }
    }

    public class IdentityApiBackOfficeUsersGetUserGetUserResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("userRole")]
        public IdentityApiBackOfficeUsersGetUserGetUserResponseRole UserRole { get; set; }

        [JsonProperty("profileImage")]
        public IdentityApiBackOfficeUsersGetUserGetUserResponseImage ProfileImage { get; set; }

        [JsonProperty("lastLogin")]
        public string LastLogin { get; set; }

        [JsonProperty("insertDate")]
        public string InsertDate { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }
    }

    public class IdentityApiBackOfficeUsersGetUserGetUserResponseRole
    {
        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("isAdmin")]
        public bool IsAdmin { get; set; }

        [JsonProperty("roleId")]
        public string RoleId { get; set; }
    }

    public class IdentityApiBackOfficeUsersGetUserGetUserResponseImage
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("galleryId")]
        public string GalleryId { get; set; }

        [JsonProperty("alt")]
        public string Alt { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class IdentityApiTeamsDtosGetTeamResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("users")]
        public IdentityApiTeamsDtosTeamUserDto[] Users { get; set; }

        [JsonProperty("modifiedBy")]
        public string ModifiedBy { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }
    }

    public class IdentityApiTeamsDtosTeamUserDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CustomerApiFeaturesAccountsAccountDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("tin")]
        public string Tin { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        [JsonProperty("sourceParentId")]
        public string SourceParentId { get; set; }

        [JsonProperty("sourceOwnerId")]
        public string SourceOwnerId { get; set; }

        [JsonProperty("primaryContactIds")]
        public string[] PrimaryContactIds { get; set; }

        [JsonProperty("parentAccountId")]
        public string ParentAccountId { get; set; }

        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty("address")]
        public AccountCreateCustomerApiDTOsAddressDTOResponse Address { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("insertDate")]
        public string InsertDate { get; set; }

        [JsonProperty("taxOffice")]
        public string TaxOffice { get; set; }

        [JsonProperty("accountSourceTypeId")]
        public string AccountSourceTypeId { get; set; }

        [JsonProperty("industryId")]
        public string IndustryId { get; set; }

        [JsonProperty("tierId")]
        public string TierId { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("accountDescription")]
        public string AccountDescription { get; set; }

        [JsonProperty("noOfEmployees")]
        public int NoOfEmployees { get; set; }

        [JsonProperty("annualRevenue")]
        public double AnnualRevenue { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("ownershipId")]
        public string OwnershipId { get; set; }

        [JsonProperty("ratingId")]
        public string RatingId { get; set; }

        [JsonProperty("classificationId")]
        public string ClassificationId { get; set; }

        [JsonProperty("extraFields")]
        public JToken ExtraFields { get; set; }

        [JsonProperty("assignedTeams")]
        public string[] AssignedTeams { get; set; }

        [JsonProperty("aiScore")]
        public double AiScore { get; set; }

        [JsonProperty("aiScoreReasoning")]
        public string AiScoreReasoning { get; set; }

        [JsonProperty("aiSentiment")]
        public CustomerApiFeaturesAccountsAccountDTOAiSentimentType AiSentiment { get; set; }

        [JsonProperty("aiGenerationDate")]
        public string AiGenerationDate { get; set; }
    }

    public class AccountCreateCustomerApiDTOsAddressDTOResponse
    {
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longtitude")]
        public string Longtitude { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public enum CustomerApiFeaturesAccountsAccountDTOAiSentimentType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4
    }

    public class AccountUpdateBodyInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("tin")]
        public string Tin { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        [JsonProperty("sourceParentId")]
        public string SourceParentId { get; set; }

        [JsonProperty("sourceOwnerId")]
        public string SourceOwnerId { get; set; }

        [JsonProperty("primaryContactIds")]
        public string[] PrimaryContactIds { get; set; }

        [JsonProperty("parentAccountId")]
        public string ParentAccountId { get; set; }

        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty("address")]
        public AccountCreateCustomerApiDTOsAddressDTO Address { get; set; }

        [JsonProperty("accountSourceTypeId")]
        public string AccountSourceTypeId { get; set; }

        [JsonProperty("industryId")]
        public string IndustryId { get; set; }

        [JsonProperty("tierId")]
        public string TierId { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("accountDescription")]
        public string AccountDescription { get; set; }

        [JsonProperty("noOfEmployees")]
        public int? NoOfEmployees { get; set; }

        [JsonProperty("annualRevenue")]
        public double? AnnualRevenue { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("ownershipId")]
        public string OwnershipId { get; set; }

        [JsonProperty("ratingId")]
        public string RatingId { get; set; }

        [JsonProperty("classificationId")]
        public string ClassificationId { get; set; }

        [JsonProperty("extraFields")]
        public JToken ExtraFields { get; set; }

        [JsonProperty("assignedTeams")]
        public string[] AssignedTeams { get; set; }
    }

    public class AccountCreateCustomerApiDTOsAddressDTO
    {
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longtitude")]
        public string Longtitude { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class AccountCreateBodyInput
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("tin")]
        public string Tin { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        [JsonProperty("sourceParentId")]
        public string SourceParentId { get; set; }

        [JsonProperty("sourceOwnerId")]
        public string SourceOwnerId { get; set; }

        [JsonProperty("primaryContactIds")]
        public string[] PrimaryContactIds { get; set; }

        [JsonProperty("parentAccountId")]
        public string ParentAccountId { get; set; }

        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty("address")]
        public AccountCreateCustomerApiDTOsAddressDTO Address { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("insertDate")]
        public string InsertDate { get; set; }

        [JsonProperty("taxOffice")]
        public string TaxOffice { get; set; }

        [JsonProperty("accountSourceTypeId")]
        public string AccountSourceTypeId { get; set; }

        [JsonProperty("industryId")]
        public string IndustryId { get; set; }

        [JsonProperty("tierId")]
        public string TierId { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("accountDescription")]
        public string AccountDescription { get; set; }

        [JsonProperty("noOfEmployees")]
        public int? NoOfEmployees { get; set; }

        [JsonProperty("annualRevenue")]
        public double? AnnualRevenue { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("ownershipId")]
        public string OwnershipId { get; set; }

        [JsonProperty("ratingId")]
        public string RatingId { get; set; }

        [JsonProperty("classificationId")]
        public string ClassificationId { get; set; }

        [JsonProperty("extraFields")]
        public JToken ExtraFields { get; set; }

        [JsonProperty("assignedTeams")]
        public string[] AssignedTeams { get; set; }

        [JsonProperty("aiScore")]
        public double? AiScore { get; set; }

        [JsonProperty("aiScoreReasoning")]
        public string AiScoreReasoning { get; set; }

        [JsonProperty("aiSentiment")]
        public BodyInputAiSentimentType? AiSentiment { get; set; }

        [JsonProperty("aiGenerationDate")]
        public string AiGenerationDate { get; set; }
    }

    public enum BodyInputAiSentimentType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4
    }

    public class CustomerApiFeaturesContactsContact
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("partitionKey")]
        public string PartitionKey { get; set; }

        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty("accountIds")]
        public string[] AccountIds { get; set; }

        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        [JsonProperty("sourceAccountIds")]
        public string[] SourceAccountIds { get; set; }

        [JsonProperty("sourceOwnerId")]
        public string SourceOwnerId { get; set; }

        [JsonProperty("name")]
        public CustomerApiFeaturesContactsName Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("callOptOut")]
        public bool CallOptOut { get; set; }

        [JsonProperty("emailOptOut")]
        public bool EmailOptOut { get; set; }

        [JsonProperty("otherEmail")]
        public CustomerApiFeaturesContactsEmail[] OtherEmail { get; set; }

        [JsonProperty("otherPhone")]
        public CustomerApiFeaturesContactsPhone[] OtherPhone { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("genderId")]
        public string GenderId { get; set; }

        [JsonProperty("pronounceId")]
        public string PronounceId { get; set; }

        [JsonProperty("address")]
        public CustomerApiModelsAddress Address { get; set; }

        [JsonProperty("insertDate")]
        public string InsertDate { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("reportsTo")]
        public string ReportsTo { get; set; }

        [JsonProperty("assistant")]
        public string Assistant { get; set; }

        [JsonProperty("assistantPhone")]
        public string AssistantPhone { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("lastStayInTouchReportedDate")]
        public string LastStayInTouchReportedDate { get; set; }

        [JsonProperty("lastStayInTouchSaveDate")]
        public string LastStayInTouchSaveDate { get; set; }

        [JsonProperty("accountSourceTypeId")]
        public string AccountSourceTypeId { get; set; }

        [JsonProperty("extraFields")]
        public JToken ExtraFields { get; set; }

        [JsonProperty("searchTags")]
        public string[] SearchTags { get; set; }

        [JsonProperty("assignedTeams")]
        public string[] AssignedTeams { get; set; }
    }

    public class CustomerApiFeaturesContactsName
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("salutationId")]
        public string SalutationId { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }
    }

    public class CustomerApiFeaturesContactsEmail
    {
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("type")]
        public CustomerApiFeaturesContactsEmailTypeType Type { get; set; }

        [JsonProperty("optOut")]
        public bool OptOut { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CustomerApiFeaturesContactsEmailTypeType
    {
        Work,
        Home,
        Other,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    public class CustomerApiFeaturesContactsPhone
    {
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("type")]
        public CustomerApiFeaturesContactsPhoneTypeType Type { get; set; }

        [JsonProperty("optOut")]
        public bool OptOut { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CustomerApiFeaturesContactsPhoneTypeType
    {
        Work,
        Home,
        Other,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    public class CustomerApiModelsAddress
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longtitude")]
        public string Longtitude { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }

    public class CustomerApiFeaturesContactsContactDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty("accountIds")]
        public string[] AccountIds { get; set; }

        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        [JsonProperty("sourceOwnerId")]
        public string SourceOwnerId { get; set; }

        [JsonProperty("sourceAccountIds")]
        public string[] SourceAccountIds { get; set; }

        [JsonProperty("name")]
        public ContactCreateCustomerApiFeaturesContactsNameDTOResponse Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("callOptOut")]
        public bool CallOptOut { get; set; }

        [JsonProperty("emailOptOut")]
        public bool EmailOptOut { get; set; }

        [JsonProperty("otherEmail")]
        public ContactCreateCustomerApiFeaturesContactsEmailDTOResponse[] OtherEmail { get; set; }

        [JsonProperty("otherPhone")]
        public ContactCreateCustomerApiFeaturesContactsPhoneDTOResponse[] OtherPhone { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("genderId")]
        public string GenderId { get; set; }

        [JsonProperty("pronounceId")]
        public string PronounceId { get; set; }

        [JsonProperty("address")]
        public AccountCreateCustomerApiDTOsAddressDTOResponse Address { get; set; }

        [JsonProperty("insertDate")]
        public string InsertDate { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("reportsTo")]
        public string ReportsTo { get; set; }

        [JsonProperty("assistant")]
        public string Assistant { get; set; }

        [JsonProperty("assistantPhone")]
        public string AssistantPhone { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("lastStayInTouchReportedDate")]
        public string LastStayInTouchReportedDate { get; set; }

        [JsonProperty("lastStayInTouchSaveDate")]
        public string LastStayInTouchSaveDate { get; set; }

        [JsonProperty("accountSourceTypeId")]
        public string AccountSourceTypeId { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("extraFields")]
        public JToken ExtraFields { get; set; }

        [JsonProperty("assignedTeams")]
        public string[] AssignedTeams { get; set; }
    }

    public class ContactCreateCustomerApiFeaturesContactsNameDTOResponse
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("salutationId")]
        public string SalutationId { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }
    }

    public class ContactCreateCustomerApiFeaturesContactsEmailDTOResponse
    {
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("type")]
        public ContactCreateCustomerApiFeaturesContactsEmailDTOTypeTypeResponse Type { get; set; }

        [JsonProperty("optOut")]
        public bool OptOut { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ContactCreateCustomerApiFeaturesContactsEmailDTOTypeTypeResponse
    {
        Work,
        Home,
        Other,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    public class ContactCreateCustomerApiFeaturesContactsPhoneDTOResponse
    {
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("type")]
        public ContactCreateCustomerApiFeaturesContactsPhoneDTOTypeTypeResponse Type { get; set; }

        [JsonProperty("optOut")]
        public bool OptOut { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ContactCreateCustomerApiFeaturesContactsPhoneDTOTypeTypeResponse
    {
        Work,
        Home,
        Other,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    public class ContactUpdateBodyInput
    {
        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty("accountIds")]
        public string[] AccountIds { get; set; }

        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        [JsonProperty("sourceOwnerId")]
        public string SourceOwnerId { get; set; }

        [JsonProperty("sourceAccountIds")]
        public string[] SourceAccountIds { get; set; }

        [JsonProperty("name")]
        public ContactCreateCustomerApiFeaturesContactsNameDTO Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("callOptOut")]
        public bool? CallOptOut { get; set; }

        [JsonProperty("emailOptOut")]
        public bool? EmailOptOut { get; set; }

        [JsonProperty("otherEmail")]
        public ContactCreateCustomerApiFeaturesContactsEmailDTO[] OtherEmail { get; set; }

        [JsonProperty("otherPhone")]
        public ContactCreateCustomerApiFeaturesContactsPhoneDTO[] OtherPhone { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("genderId")]
        public string GenderId { get; set; }

        [JsonProperty("pronounceId")]
        public string PronounceId { get; set; }

        [JsonProperty("address")]
        public AccountCreateCustomerApiDTOsAddressDTO Address { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("reportsTo")]
        public string ReportsTo { get; set; }

        [JsonProperty("assistant")]
        public string Assistant { get; set; }

        [JsonProperty("assistantPhone")]
        public string AssistantPhone { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("lastStayInTouchReportedDate")]
        public string LastStayInTouchReportedDate { get; set; }

        [JsonProperty("lastStayInTouchSaveDate")]
        public string LastStayInTouchSaveDate { get; set; }

        [JsonProperty("accountSourceTypeId")]
        public string AccountSourceTypeId { get; set; }

        [JsonProperty("extraFields")]
        public JToken ExtraFields { get; set; }

        [JsonProperty("assignedTeams")]
        public string[] AssignedTeams { get; set; }
    }

    public class ContactCreateCustomerApiFeaturesContactsNameDTO
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("salutationId")]
        public string SalutationId { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }
    }

    public class ContactCreateCustomerApiFeaturesContactsEmailDTO
    {
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("type")]
        public ContactCreateCustomerApiFeaturesContactsEmailDTOTypeType? Type { get; set; }

        [JsonProperty("optOut")]
        public bool? OptOut { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ContactCreateCustomerApiFeaturesContactsEmailDTOTypeType
    {
        Work,
        Home,
        Other,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    public class ContactCreateCustomerApiFeaturesContactsPhoneDTO
    {
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("type")]
        public ContactCreateCustomerApiFeaturesContactsPhoneDTOTypeType? Type { get; set; }

        [JsonProperty("optOut")]
        public bool? OptOut { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ContactCreateCustomerApiFeaturesContactsPhoneDTOTypeType
    {
        Work,
        Home,
        Other,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    public class ContactCreateBodyInput
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty("accountIds")]
        public string[] AccountIds { get; set; }

        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        [JsonProperty("sourceOwnerId")]
        public string SourceOwnerId { get; set; }

        [JsonProperty("sourceAccountIds")]
        public string[] SourceAccountIds { get; set; }

        [JsonProperty("name")]
        public ContactCreateCustomerApiFeaturesContactsNameDTO Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("callOptOut")]
        public bool? CallOptOut { get; set; }

        [JsonProperty("emailOptOut")]
        public bool? EmailOptOut { get; set; }

        [JsonProperty("otherEmail")]
        public ContactCreateCustomerApiFeaturesContactsEmailDTO[] OtherEmail { get; set; }

        [JsonProperty("otherPhone")]
        public ContactCreateCustomerApiFeaturesContactsPhoneDTO[] OtherPhone { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("genderId")]
        public string GenderId { get; set; }

        [JsonProperty("pronounceId")]
        public string PronounceId { get; set; }

        [JsonProperty("address")]
        public AccountCreateCustomerApiDTOsAddressDTO Address { get; set; }

        [JsonProperty("insertDate")]
        public string InsertDate { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("lastModifiedBy")]
        public string LastModifiedBy { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("reportsTo")]
        public string ReportsTo { get; set; }

        [JsonProperty("assistant")]
        public string Assistant { get; set; }

        [JsonProperty("assistantPhone")]
        public string AssistantPhone { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("lastStayInTouchReportedDate")]
        public string LastStayInTouchReportedDate { get; set; }

        [JsonProperty("lastStayInTouchSaveDate")]
        public string LastStayInTouchSaveDate { get; set; }

        [JsonProperty("accountSourceTypeId")]
        public string AccountSourceTypeId { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("extraFields")]
        public JToken ExtraFields { get; set; }

        [JsonProperty("assignedTeams")]
        public string[] AssignedTeams { get; set; }
    }

    public class CallCreatedBodyInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Softonewebcrm;

    public partial class WorkflowManagedActions
    {
        public SoftonewebcrmActions Softonewebcrm(string connectionId) => new SoftonewebcrmActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SoftonewebcrmTriggers Softonewebcrm(string connectionId) => new SoftonewebcrmTriggers(connectionId);
    }
}