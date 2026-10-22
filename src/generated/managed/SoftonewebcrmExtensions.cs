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
        public IBodyWorkflowAction<TaskApiFeaturesCallsCallDTO[], ApiConnectionActionConfiguration> CallGetAll(Expression<Func<string>> id = null, Expression<Func<statusInput>> status = null, Expression<Func<string>> priorityId = null, Expression<Func<string>> createdBy = null, Expression<Func<string>> lastModifiedBy = null, Expression<Func<string>> dueDate = null, Expression<Func<string>> sortDate = null, Expression<Func<string>> assignedToId = null, Expression<Func<string>> relatedToId = null, Expression<Func<string>> callResultId = null, Expression<Func<string>> search = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
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
        public IBodyWorkflowAction<TaskApiFeaturesCallsCallDTO, ApiConnectionActionConfiguration> CallCreate(Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodysubject = null, Expression<Func<bodyassignedToTypeInput>> bodyassignedToType = null, Expression<Func<string>> bodyassignedToId = null, Expression<Func<bodyrelatedToTypeInput>> bodyrelatedToType = null, Expression<Func<string>> bodyrelatedToId = null, Expression<Func<bodycontactTypeInput>> bodycontactType = null, Expression<Func<string[]>> bodycontactIds = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodycallDuration = null, Expression<Func<string>> bodycallResultId = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodyeditorBody = null, Expression<Func<string>> bodypriorityId = null, Expression<Func<int>> bodyposition = null, Expression<Func<string>> bodyparentId = null, Expression<Func<bool>> bodyreminderSet = null, Expression<Func<string>> bodysortDate = null, Expression<Func<string>> bodysourceId = null, Expression<Func<string>> bodysourceAssignedToId = null, Expression<Func<string>> bodysourceRelatedToId = null, Expression<Func<string[]>> bodysourceContactIds = null, Expression<Func<bodycallDirectionInput>> bodycallDirection = null)
        {
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodyassignedToType = WorkflowExpression.Compile(bodyassignedToType, nameof(bodyassignedToType), required: false);
            var __workflow_bodyassignedToId = WorkflowExpression.Compile(bodyassignedToId, nameof(bodyassignedToId), required: false);
            var __workflow_bodyrelatedToType = WorkflowExpression.Compile(bodyrelatedToType, nameof(bodyrelatedToType), required: false);
            var __workflow_bodyrelatedToId = WorkflowExpression.Compile(bodyrelatedToId, nameof(bodyrelatedToId), required: false);
            var __workflow_bodycontactType = WorkflowExpression.Compile(bodycontactType, nameof(bodycontactType), required: false);
            var __workflow_bodycontactIds = WorkflowExpression.Compile(bodycontactIds, nameof(bodycontactIds), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodycallDuration = WorkflowExpression.Compile(bodycallDuration, nameof(bodycallDuration), required: false);
            var __workflow_bodycallResultId = WorkflowExpression.Compile(bodycallResultId, nameof(bodycallResultId), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodyeditorBody = WorkflowExpression.Compile(bodyeditorBody, nameof(bodyeditorBody), required: false);
            var __workflow_bodypriorityId = WorkflowExpression.Compile(bodypriorityId, nameof(bodypriorityId), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            var __workflow_bodyparentId = WorkflowExpression.Compile(bodyparentId, nameof(bodyparentId), required: false);
            var __workflow_bodyreminderSet = WorkflowExpression.Compile(bodyreminderSet, nameof(bodyreminderSet), required: false);
            var __workflow_bodysortDate = WorkflowExpression.Compile(bodysortDate, nameof(bodysortDate), required: false);
            var __workflow_bodysourceId = WorkflowExpression.Compile(bodysourceId, nameof(bodysourceId), required: false);
            var __workflow_bodysourceAssignedToId = WorkflowExpression.Compile(bodysourceAssignedToId, nameof(bodysourceAssignedToId), required: false);
            var __workflow_bodysourceRelatedToId = WorkflowExpression.Compile(bodysourceRelatedToId, nameof(bodysourceRelatedToId), required: false);
            var __workflow_bodysourceContactIds = WorkflowExpression.Compile(bodysourceContactIds, nameof(bodysourceContactIds), required: false);
            var __workflow_bodycallDirection = WorkflowExpression.Compile(bodycallDirection, nameof(bodycallDirection), required: false);
            return new DeferredBodyAction<TaskApiFeaturesCallsCallDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/task/Call";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(__workflow_bodydueDate);
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedToType != null)
                {
                    body["assignedToType"] = ExpressionConverter.ConvertO(__workflow_bodyassignedToType);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedToId != null)
                {
                    body["assignedToId"] = ExpressionConverter.ConvertO(__workflow_bodyassignedToId);
                    bodypropCount++;
                }

                if (__workflow_bodyrelatedToType != null)
                {
                    body["relatedToType"] = ExpressionConverter.ConvertO(__workflow_bodyrelatedToType);
                    bodypropCount++;
                }

                if (__workflow_bodyrelatedToId != null)
                {
                    body["relatedToId"] = ExpressionConverter.ConvertO(__workflow_bodyrelatedToId);
                    bodypropCount++;
                }

                if (__workflow_bodycontactType != null)
                {
                    body["contactType"] = ExpressionConverter.ConvertO(__workflow_bodycontactType);
                    bodypropCount++;
                }

                if (__workflow_bodycontactIds != null)
                {
                    body["contactIds"] = ExpressionConverter.ConvertO(__workflow_bodycontactIds);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodycallDuration != null)
                {
                    body["callDuration"] = ExpressionConverter.ConvertO(__workflow_bodycallDuration);
                    bodypropCount++;
                }

                if (__workflow_bodycallResultId != null)
                {
                    body["callResultId"] = ExpressionConverter.ConvertO(__workflow_bodycallResultId);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodyeditorBody != null)
                {
                    body["editorBody"] = ExpressionConverter.ConvertO(__workflow_bodyeditorBody);
                    bodypropCount++;
                }

                if (__workflow_bodypriorityId != null)
                {
                    body["priorityId"] = ExpressionConverter.ConvertO(__workflow_bodypriorityId);
                    bodypropCount++;
                }

                if (__workflow_bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (__workflow_bodyparentId != null)
                {
                    body["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyparentId);
                    bodypropCount++;
                }

                if (__workflow_bodyreminderSet != null)
                {
                    body["reminderSet"] = ExpressionConverter.ConvertO(__workflow_bodyreminderSet);
                    bodypropCount++;
                }

                if (__workflow_bodysortDate != null)
                {
                    body["sortDate"] = ExpressionConverter.ConvertO(__workflow_bodysortDate);
                    bodypropCount++;
                }

                if (__workflow_bodysourceId != null)
                {
                    body["sourceId"] = ExpressionConverter.ConvertO(__workflow_bodysourceId);
                    bodypropCount++;
                }

                if (__workflow_bodysourceAssignedToId != null)
                {
                    body["sourceAssignedToId"] = ExpressionConverter.ConvertO(__workflow_bodysourceAssignedToId);
                    bodypropCount++;
                }

                if (__workflow_bodysourceRelatedToId != null)
                {
                    body["sourceRelatedToId"] = ExpressionConverter.ConvertO(__workflow_bodysourceRelatedToId);
                    bodypropCount++;
                }

                if (__workflow_bodysourceContactIds != null)
                {
                    body["sourceContactIds"] = ExpressionConverter.ConvertO(__workflow_bodysourceContactIds);
                    bodypropCount++;
                }

                if (__workflow_bodycallDirection != null)
                {
                    body["callDirection"] = ExpressionConverter.ConvertO(__workflow_bodycallDirection);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<TaskApiFeaturesCallsCallDTO, ApiConnectionActionConfiguration> CallUpdate(Expression<Func<string>> id, Expression<Func<bodytaskTypeInput>> bodytaskType = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodysubject = null, Expression<Func<bodyassignedToTypeInput>> bodyassignedToType = null, Expression<Func<string>> bodyassignedToId = null, Expression<Func<bodyrelatedToTypeInput>> bodyrelatedToType = null, Expression<Func<string>> bodyrelatedToId = null, Expression<Func<bodycontactTypeInput>> bodycontactType = null, Expression<Func<string[]>> bodycontactIds = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodycallDuration = null, Expression<Func<string>> bodycallResultId = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodyeditorBody = null, Expression<Func<string>> bodypriorityId = null, Expression<Func<int>> bodyposition = null, Expression<Func<string>> bodyparentId = null, Expression<Func<bool>> bodyreminderSet = null, Expression<Func<string>> bodylastModifiedBy = null, Expression<Func<string>> bodysortDate = null, Expression<Func<string>> bodysourceId = null, Expression<Func<string>> bodysourceAssignedToId = null, Expression<Func<string>> bodysourceRelatedToId = null, Expression<Func<string[]>> bodysourceContactIds = null, Expression<Func<bodycallDirectionInput>> bodycallDirection = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytaskType = WorkflowExpression.Compile(bodytaskType, nameof(bodytaskType), required: false);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodyassignedToType = WorkflowExpression.Compile(bodyassignedToType, nameof(bodyassignedToType), required: false);
            var __workflow_bodyassignedToId = WorkflowExpression.Compile(bodyassignedToId, nameof(bodyassignedToId), required: false);
            var __workflow_bodyrelatedToType = WorkflowExpression.Compile(bodyrelatedToType, nameof(bodyrelatedToType), required: false);
            var __workflow_bodyrelatedToId = WorkflowExpression.Compile(bodyrelatedToId, nameof(bodyrelatedToId), required: false);
            var __workflow_bodycontactType = WorkflowExpression.Compile(bodycontactType, nameof(bodycontactType), required: false);
            var __workflow_bodycontactIds = WorkflowExpression.Compile(bodycontactIds, nameof(bodycontactIds), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodycallDuration = WorkflowExpression.Compile(bodycallDuration, nameof(bodycallDuration), required: false);
            var __workflow_bodycallResultId = WorkflowExpression.Compile(bodycallResultId, nameof(bodycallResultId), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodyeditorBody = WorkflowExpression.Compile(bodyeditorBody, nameof(bodyeditorBody), required: false);
            var __workflow_bodypriorityId = WorkflowExpression.Compile(bodypriorityId, nameof(bodypriorityId), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            var __workflow_bodyparentId = WorkflowExpression.Compile(bodyparentId, nameof(bodyparentId), required: false);
            var __workflow_bodyreminderSet = WorkflowExpression.Compile(bodyreminderSet, nameof(bodyreminderSet), required: false);
            var __workflow_bodylastModifiedBy = WorkflowExpression.Compile(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            var __workflow_bodysortDate = WorkflowExpression.Compile(bodysortDate, nameof(bodysortDate), required: false);
            var __workflow_bodysourceId = WorkflowExpression.Compile(bodysourceId, nameof(bodysourceId), required: false);
            var __workflow_bodysourceAssignedToId = WorkflowExpression.Compile(bodysourceAssignedToId, nameof(bodysourceAssignedToId), required: false);
            var __workflow_bodysourceRelatedToId = WorkflowExpression.Compile(bodysourceRelatedToId, nameof(bodysourceRelatedToId), required: false);
            var __workflow_bodysourceContactIds = WorkflowExpression.Compile(bodysourceContactIds, nameof(bodysourceContactIds), required: false);
            var __workflow_bodycallDirection = WorkflowExpression.Compile(bodycallDirection, nameof(bodycallDirection), required: false);
            return new DeferredBodyAction<TaskApiFeaturesCallsCallDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/task/Call/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytaskType != null)
                {
                    body["taskType"] = ExpressionConverter.ConvertO(__workflow_bodytaskType);
                    bodypropCount++;
                }

                if (__workflow_bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(__workflow_bodydueDate);
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedToType != null)
                {
                    body["assignedToType"] = ExpressionConverter.ConvertO(__workflow_bodyassignedToType);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedToId != null)
                {
                    body["assignedToId"] = ExpressionConverter.ConvertO(__workflow_bodyassignedToId);
                    bodypropCount++;
                }

                if (__workflow_bodyrelatedToType != null)
                {
                    body["relatedToType"] = ExpressionConverter.ConvertO(__workflow_bodyrelatedToType);
                    bodypropCount++;
                }

                if (__workflow_bodyrelatedToId != null)
                {
                    body["relatedToId"] = ExpressionConverter.ConvertO(__workflow_bodyrelatedToId);
                    bodypropCount++;
                }

                if (__workflow_bodycontactType != null)
                {
                    body["contactType"] = ExpressionConverter.ConvertO(__workflow_bodycontactType);
                    bodypropCount++;
                }

                if (__workflow_bodycontactIds != null)
                {
                    body["contactIds"] = ExpressionConverter.ConvertO(__workflow_bodycontactIds);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodycallDuration != null)
                {
                    body["callDuration"] = ExpressionConverter.ConvertO(__workflow_bodycallDuration);
                    bodypropCount++;
                }

                if (__workflow_bodycallResultId != null)
                {
                    body["callResultId"] = ExpressionConverter.ConvertO(__workflow_bodycallResultId);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodyeditorBody != null)
                {
                    body["editorBody"] = ExpressionConverter.ConvertO(__workflow_bodyeditorBody);
                    bodypropCount++;
                }

                if (__workflow_bodypriorityId != null)
                {
                    body["priorityId"] = ExpressionConverter.ConvertO(__workflow_bodypriorityId);
                    bodypropCount++;
                }

                if (__workflow_bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (__workflow_bodyparentId != null)
                {
                    body["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyparentId);
                    bodypropCount++;
                }

                if (__workflow_bodyreminderSet != null)
                {
                    body["reminderSet"] = ExpressionConverter.ConvertO(__workflow_bodyreminderSet);
                    bodypropCount++;
                }

                if (__workflow_bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = ExpressionConverter.ConvertO(__workflow_bodylastModifiedBy);
                    bodypropCount++;
                }

                if (__workflow_bodysortDate != null)
                {
                    body["sortDate"] = ExpressionConverter.ConvertO(__workflow_bodysortDate);
                    bodypropCount++;
                }

                if (__workflow_bodysourceId != null)
                {
                    body["sourceId"] = ExpressionConverter.ConvertO(__workflow_bodysourceId);
                    bodypropCount++;
                }

                if (__workflow_bodysourceAssignedToId != null)
                {
                    body["sourceAssignedToId"] = ExpressionConverter.ConvertO(__workflow_bodysourceAssignedToId);
                    bodypropCount++;
                }

                if (__workflow_bodysourceRelatedToId != null)
                {
                    body["sourceRelatedToId"] = ExpressionConverter.ConvertO(__workflow_bodysourceRelatedToId);
                    bodypropCount++;
                }

                if (__workflow_bodysourceContactIds != null)
                {
                    body["sourceContactIds"] = ExpressionConverter.ConvertO(__workflow_bodysourceContactIds);
                    bodypropCount++;
                }

                if (__workflow_bodycallDirection != null)
                {
                    body["callDirection"] = ExpressionConverter.ConvertO(__workflow_bodycallDirection);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TaskApiFeaturesCallsCallDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesEventsEventDTO[], ApiConnectionActionConfiguration> EventGetAll(Expression<Func<string>> id = null, Expression<Func<statusInput>> status = null, Expression<Func<eventStatusInput>> eventStatus = null, Expression<Func<string>> startDate = null, Expression<Func<string>> assignedToId = null, Expression<Func<string>> relatedToId = null, Expression<Func<string>> sortDate = null, Expression<Func<string>> parentId = null, Expression<Func<string>> eventResultId = null, Expression<Func<string>> priorityId = null, Expression<Func<string>> search = null, Expression<Func<string>> lastModifiedBy = null, Expression<Func<string>> createdBy = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
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
        public IBodyWorkflowAction<TaskApiFeaturesEventsEventDTO, ApiConnectionActionConfiguration> EventCreate(Expression<Func<string>> bodyupdateDate = null, Expression<Func<string>> bodysubject = null, Expression<Func<bodytaskTypeInput>> bodytaskType = null, Expression<Func<bodyassignedToTypeInput>> bodyassignedToType = null, Expression<Func<string>> bodyassignedToId = null, Expression<Func<bodyrelatedToTypeInput>> bodyrelatedToType = null, Expression<Func<string>> bodyrelatedToId = null, Expression<Func<bodycontactTypeInput>> bodycontactType = null, Expression<Func<string[]>> bodycontactIds = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyeditorBody = null, Expression<Func<string>> bodypriorityId = null, Expression<Func<string>> bodylocationlongitude = null, Expression<Func<string>> bodylocationlatitude = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<bool>> bodyreminderSet = null, Expression<Func<string>> bodycreatedBy = null, Expression<Func<string>> bodylastModifiedBy = null, Expression<Func<int>> bodyposition = null, Expression<Func<string>> bodyparentId = null, Expression<Func<string>> bodyrepeat = null, Expression<Func<bodyeventStatusInput>> bodyeventStatus = null, Expression<Func<string>> bodyeventResultId = null, Expression<Func<string>> bodyrecurrenceInterval = null, Expression<Func<string>> bodysourceId = null, Expression<Func<string>> bodysourceAssignedToId = null, Expression<Func<string>> bodysourceRelatedToId = null, Expression<Func<string[]>> bodysourceContactIds = null, Expression<Func<string[]>> bodyteamMembers = null)
        {
            var __workflow_bodyupdateDate = WorkflowExpression.Compile(bodyupdateDate, nameof(bodyupdateDate), required: false);
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodytaskType = WorkflowExpression.Compile(bodytaskType, nameof(bodytaskType), required: false);
            var __workflow_bodyassignedToType = WorkflowExpression.Compile(bodyassignedToType, nameof(bodyassignedToType), required: false);
            var __workflow_bodyassignedToId = WorkflowExpression.Compile(bodyassignedToId, nameof(bodyassignedToId), required: false);
            var __workflow_bodyrelatedToType = WorkflowExpression.Compile(bodyrelatedToType, nameof(bodyrelatedToType), required: false);
            var __workflow_bodyrelatedToId = WorkflowExpression.Compile(bodyrelatedToId, nameof(bodyrelatedToId), required: false);
            var __workflow_bodycontactType = WorkflowExpression.Compile(bodycontactType, nameof(bodycontactType), required: false);
            var __workflow_bodycontactIds = WorkflowExpression.Compile(bodycontactIds, nameof(bodycontactIds), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyeditorBody = WorkflowExpression.Compile(bodyeditorBody, nameof(bodyeditorBody), required: false);
            var __workflow_bodypriorityId = WorkflowExpression.Compile(bodypriorityId, nameof(bodypriorityId), required: false);
            var __workflow_bodylocationlongitude = WorkflowExpression.Compile(bodylocationlongitude, nameof(bodylocationlongitude), required: false);
            var __workflow_bodylocationlatitude = WorkflowExpression.Compile(bodylocationlatitude, nameof(bodylocationlatitude), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodyreminderSet = WorkflowExpression.Compile(bodyreminderSet, nameof(bodyreminderSet), required: false);
            var __workflow_bodycreatedBy = WorkflowExpression.Compile(bodycreatedBy, nameof(bodycreatedBy), required: false);
            var __workflow_bodylastModifiedBy = WorkflowExpression.Compile(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            var __workflow_bodyparentId = WorkflowExpression.Compile(bodyparentId, nameof(bodyparentId), required: false);
            var __workflow_bodyrepeat = WorkflowExpression.Compile(bodyrepeat, nameof(bodyrepeat), required: false);
            var __workflow_bodyeventStatus = WorkflowExpression.Compile(bodyeventStatus, nameof(bodyeventStatus), required: false);
            var __workflow_bodyeventResultId = WorkflowExpression.Compile(bodyeventResultId, nameof(bodyeventResultId), required: false);
            var __workflow_bodyrecurrenceInterval = WorkflowExpression.Compile(bodyrecurrenceInterval, nameof(bodyrecurrenceInterval), required: false);
            var __workflow_bodysourceId = WorkflowExpression.Compile(bodysourceId, nameof(bodysourceId), required: false);
            var __workflow_bodysourceAssignedToId = WorkflowExpression.Compile(bodysourceAssignedToId, nameof(bodysourceAssignedToId), required: false);
            var __workflow_bodysourceRelatedToId = WorkflowExpression.Compile(bodysourceRelatedToId, nameof(bodysourceRelatedToId), required: false);
            var __workflow_bodysourceContactIds = WorkflowExpression.Compile(bodysourceContactIds, nameof(bodysourceContactIds), required: false);
            var __workflow_bodyteamMembers = WorkflowExpression.Compile(bodyteamMembers, nameof(bodyteamMembers), required: false);
            return new DeferredBodyAction<TaskApiFeaturesEventsEventDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/task/Event";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyupdateDate != null)
                {
                    body["updateDate"] = ExpressionConverter.ConvertO(__workflow_bodyupdateDate);
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (__workflow_bodytaskType != null)
                {
                    body["taskType"] = ExpressionConverter.ConvertO(__workflow_bodytaskType);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedToType != null)
                {
                    body["assignedToType"] = ExpressionConverter.ConvertO(__workflow_bodyassignedToType);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedToId != null)
                {
                    body["assignedToId"] = ExpressionConverter.ConvertO(__workflow_bodyassignedToId);
                    bodypropCount++;
                }

                if (__workflow_bodyrelatedToType != null)
                {
                    body["relatedToType"] = ExpressionConverter.ConvertO(__workflow_bodyrelatedToType);
                    bodypropCount++;
                }

                if (__workflow_bodyrelatedToId != null)
                {
                    body["relatedToId"] = ExpressionConverter.ConvertO(__workflow_bodyrelatedToId);
                    bodypropCount++;
                }

                if (__workflow_bodycontactType != null)
                {
                    body["contactType"] = ExpressionConverter.ConvertO(__workflow_bodycontactType);
                    bodypropCount++;
                }

                if (__workflow_bodycontactIds != null)
                {
                    body["contactIds"] = ExpressionConverter.ConvertO(__workflow_bodycontactIds);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyeditorBody != null)
                {
                    body["editorBody"] = ExpressionConverter.ConvertO(__workflow_bodyeditorBody);
                    bodypropCount++;
                }

                if (__workflow_bodypriorityId != null)
                {
                    body["priorityId"] = ExpressionConverter.ConvertO(__workflow_bodypriorityId);
                    bodypropCount++;
                }

                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (__workflow_bodylocationlongitude != null)
                {
                    locationObject["longitude"] = ExpressionConverter.ConvertO(__workflow_bodylocationlongitude);
                    locationObjectpropCount++;
                }

                if (__workflow_bodylocationlatitude != null)
                {
                    locationObject["latitude"] = ExpressionConverter.ConvertO(__workflow_bodylocationlatitude);
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    body["location"] = locationObject;
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["endDate"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (__workflow_bodyreminderSet != null)
                {
                    body["reminderSet"] = ExpressionConverter.ConvertO(__workflow_bodyreminderSet);
                    bodypropCount++;
                }

                if (__workflow_bodycreatedBy != null)
                {
                    body["createdBy"] = ExpressionConverter.ConvertO(__workflow_bodycreatedBy);
                    bodypropCount++;
                }

                if (__workflow_bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = ExpressionConverter.ConvertO(__workflow_bodylastModifiedBy);
                    bodypropCount++;
                }

                if (__workflow_bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (__workflow_bodyparentId != null)
                {
                    body["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyparentId);
                    bodypropCount++;
                }

                if (__workflow_bodyrepeat != null)
                {
                    body["repeat"] = ExpressionConverter.ConvertO(__workflow_bodyrepeat);
                    bodypropCount++;
                }

                if (__workflow_bodyeventStatus != null)
                {
                    body["eventStatus"] = ExpressionConverter.ConvertO(__workflow_bodyeventStatus);
                    bodypropCount++;
                }

                if (__workflow_bodyeventResultId != null)
                {
                    body["eventResultId"] = ExpressionConverter.ConvertO(__workflow_bodyeventResultId);
                    bodypropCount++;
                }

                if (__workflow_bodyrecurrenceInterval != null)
                {
                    body["recurrenceInterval"] = ExpressionConverter.ConvertO(__workflow_bodyrecurrenceInterval);
                    bodypropCount++;
                }

                if (__workflow_bodysourceId != null)
                {
                    body["sourceId"] = ExpressionConverter.ConvertO(__workflow_bodysourceId);
                    bodypropCount++;
                }

                if (__workflow_bodysourceAssignedToId != null)
                {
                    body["sourceAssignedToId"] = ExpressionConverter.ConvertO(__workflow_bodysourceAssignedToId);
                    bodypropCount++;
                }

                if (__workflow_bodysourceRelatedToId != null)
                {
                    body["sourceRelatedToId"] = ExpressionConverter.ConvertO(__workflow_bodysourceRelatedToId);
                    bodypropCount++;
                }

                if (__workflow_bodysourceContactIds != null)
                {
                    body["sourceContactIds"] = ExpressionConverter.ConvertO(__workflow_bodysourceContactIds);
                    bodypropCount++;
                }

                if (__workflow_bodyteamMembers != null)
                {
                    body["teamMembers"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembers);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<TaskApiFeaturesEventsEventDTO, ApiConnectionActionConfiguration> EventUpdate(Expression<Func<string>> id, Expression<Func<string>> bodyupdateDate = null, Expression<Func<string>> bodysubject = null, Expression<Func<bodytaskTypeInput>> bodytaskType = null, Expression<Func<bodyassignedToTypeInput>> bodyassignedToType = null, Expression<Func<string>> bodyassignedToId = null, Expression<Func<bodyrelatedToTypeInput>> bodyrelatedToType = null, Expression<Func<string>> bodyrelatedToId = null, Expression<Func<bodycontactTypeInput>> bodycontactType = null, Expression<Func<string[]>> bodycontactIds = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyeditorBody = null, Expression<Func<string>> bodypriorityId = null, Expression<Func<string>> bodylocationlongitude = null, Expression<Func<string>> bodylocationlatitude = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<bool>> bodyreminderSet = null, Expression<Func<string>> bodycreatedBy = null, Expression<Func<string>> bodylastModifiedBy = null, Expression<Func<int>> bodyposition = null, Expression<Func<string>> bodyparentId = null, Expression<Func<string>> bodyrepeat = null, Expression<Func<bodyeventStatusInput>> bodyeventStatus = null, Expression<Func<string>> bodyeventResultId = null, Expression<Func<string>> bodyrecurrenceInterval = null, Expression<Func<string>> bodysourceId = null, Expression<Func<string>> bodysourceAssignedToId = null, Expression<Func<string>> bodysourceRelatedToId = null, Expression<Func<string[]>> bodysourceContactIds = null, Expression<Func<string[]>> bodyteamMembers = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyupdateDate = WorkflowExpression.Compile(bodyupdateDate, nameof(bodyupdateDate), required: false);
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodytaskType = WorkflowExpression.Compile(bodytaskType, nameof(bodytaskType), required: false);
            var __workflow_bodyassignedToType = WorkflowExpression.Compile(bodyassignedToType, nameof(bodyassignedToType), required: false);
            var __workflow_bodyassignedToId = WorkflowExpression.Compile(bodyassignedToId, nameof(bodyassignedToId), required: false);
            var __workflow_bodyrelatedToType = WorkflowExpression.Compile(bodyrelatedToType, nameof(bodyrelatedToType), required: false);
            var __workflow_bodyrelatedToId = WorkflowExpression.Compile(bodyrelatedToId, nameof(bodyrelatedToId), required: false);
            var __workflow_bodycontactType = WorkflowExpression.Compile(bodycontactType, nameof(bodycontactType), required: false);
            var __workflow_bodycontactIds = WorkflowExpression.Compile(bodycontactIds, nameof(bodycontactIds), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyeditorBody = WorkflowExpression.Compile(bodyeditorBody, nameof(bodyeditorBody), required: false);
            var __workflow_bodypriorityId = WorkflowExpression.Compile(bodypriorityId, nameof(bodypriorityId), required: false);
            var __workflow_bodylocationlongitude = WorkflowExpression.Compile(bodylocationlongitude, nameof(bodylocationlongitude), required: false);
            var __workflow_bodylocationlatitude = WorkflowExpression.Compile(bodylocationlatitude, nameof(bodylocationlatitude), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodyreminderSet = WorkflowExpression.Compile(bodyreminderSet, nameof(bodyreminderSet), required: false);
            var __workflow_bodycreatedBy = WorkflowExpression.Compile(bodycreatedBy, nameof(bodycreatedBy), required: false);
            var __workflow_bodylastModifiedBy = WorkflowExpression.Compile(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            var __workflow_bodyparentId = WorkflowExpression.Compile(bodyparentId, nameof(bodyparentId), required: false);
            var __workflow_bodyrepeat = WorkflowExpression.Compile(bodyrepeat, nameof(bodyrepeat), required: false);
            var __workflow_bodyeventStatus = WorkflowExpression.Compile(bodyeventStatus, nameof(bodyeventStatus), required: false);
            var __workflow_bodyeventResultId = WorkflowExpression.Compile(bodyeventResultId, nameof(bodyeventResultId), required: false);
            var __workflow_bodyrecurrenceInterval = WorkflowExpression.Compile(bodyrecurrenceInterval, nameof(bodyrecurrenceInterval), required: false);
            var __workflow_bodysourceId = WorkflowExpression.Compile(bodysourceId, nameof(bodysourceId), required: false);
            var __workflow_bodysourceAssignedToId = WorkflowExpression.Compile(bodysourceAssignedToId, nameof(bodysourceAssignedToId), required: false);
            var __workflow_bodysourceRelatedToId = WorkflowExpression.Compile(bodysourceRelatedToId, nameof(bodysourceRelatedToId), required: false);
            var __workflow_bodysourceContactIds = WorkflowExpression.Compile(bodysourceContactIds, nameof(bodysourceContactIds), required: false);
            var __workflow_bodyteamMembers = WorkflowExpression.Compile(bodyteamMembers, nameof(bodyteamMembers), required: false);
            return new DeferredBodyAction<TaskApiFeaturesEventsEventDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/task/Event/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyupdateDate != null)
                {
                    body["updateDate"] = ExpressionConverter.ConvertO(__workflow_bodyupdateDate);
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (__workflow_bodytaskType != null)
                {
                    body["taskType"] = ExpressionConverter.ConvertO(__workflow_bodytaskType);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedToType != null)
                {
                    body["assignedToType"] = ExpressionConverter.ConvertO(__workflow_bodyassignedToType);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedToId != null)
                {
                    body["assignedToId"] = ExpressionConverter.ConvertO(__workflow_bodyassignedToId);
                    bodypropCount++;
                }

                if (__workflow_bodyrelatedToType != null)
                {
                    body["relatedToType"] = ExpressionConverter.ConvertO(__workflow_bodyrelatedToType);
                    bodypropCount++;
                }

                if (__workflow_bodyrelatedToId != null)
                {
                    body["relatedToId"] = ExpressionConverter.ConvertO(__workflow_bodyrelatedToId);
                    bodypropCount++;
                }

                if (__workflow_bodycontactType != null)
                {
                    body["contactType"] = ExpressionConverter.ConvertO(__workflow_bodycontactType);
                    bodypropCount++;
                }

                if (__workflow_bodycontactIds != null)
                {
                    body["contactIds"] = ExpressionConverter.ConvertO(__workflow_bodycontactIds);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyeditorBody != null)
                {
                    body["editorBody"] = ExpressionConverter.ConvertO(__workflow_bodyeditorBody);
                    bodypropCount++;
                }

                if (__workflow_bodypriorityId != null)
                {
                    body["priorityId"] = ExpressionConverter.ConvertO(__workflow_bodypriorityId);
                    bodypropCount++;
                }

                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (__workflow_bodylocationlongitude != null)
                {
                    locationObject["longitude"] = ExpressionConverter.ConvertO(__workflow_bodylocationlongitude);
                    locationObjectpropCount++;
                }

                if (__workflow_bodylocationlatitude != null)
                {
                    locationObject["latitude"] = ExpressionConverter.ConvertO(__workflow_bodylocationlatitude);
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    body["location"] = locationObject;
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["endDate"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (__workflow_bodyreminderSet != null)
                {
                    body["reminderSet"] = ExpressionConverter.ConvertO(__workflow_bodyreminderSet);
                    bodypropCount++;
                }

                if (__workflow_bodycreatedBy != null)
                {
                    body["createdBy"] = ExpressionConverter.ConvertO(__workflow_bodycreatedBy);
                    bodypropCount++;
                }

                if (__workflow_bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = ExpressionConverter.ConvertO(__workflow_bodylastModifiedBy);
                    bodypropCount++;
                }

                if (__workflow_bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (__workflow_bodyparentId != null)
                {
                    body["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyparentId);
                    bodypropCount++;
                }

                if (__workflow_bodyrepeat != null)
                {
                    body["repeat"] = ExpressionConverter.ConvertO(__workflow_bodyrepeat);
                    bodypropCount++;
                }

                if (__workflow_bodyeventStatus != null)
                {
                    body["eventStatus"] = ExpressionConverter.ConvertO(__workflow_bodyeventStatus);
                    bodypropCount++;
                }

                if (__workflow_bodyeventResultId != null)
                {
                    body["eventResultId"] = ExpressionConverter.ConvertO(__workflow_bodyeventResultId);
                    bodypropCount++;
                }

                if (__workflow_bodyrecurrenceInterval != null)
                {
                    body["recurrenceInterval"] = ExpressionConverter.ConvertO(__workflow_bodyrecurrenceInterval);
                    bodypropCount++;
                }

                if (__workflow_bodysourceId != null)
                {
                    body["sourceId"] = ExpressionConverter.ConvertO(__workflow_bodysourceId);
                    bodypropCount++;
                }

                if (__workflow_bodysourceAssignedToId != null)
                {
                    body["sourceAssignedToId"] = ExpressionConverter.ConvertO(__workflow_bodysourceAssignedToId);
                    bodypropCount++;
                }

                if (__workflow_bodysourceRelatedToId != null)
                {
                    body["sourceRelatedToId"] = ExpressionConverter.ConvertO(__workflow_bodysourceRelatedToId);
                    bodypropCount++;
                }

                if (__workflow_bodysourceContactIds != null)
                {
                    body["sourceContactIds"] = ExpressionConverter.ConvertO(__workflow_bodysourceContactIds);
                    bodypropCount++;
                }

                if (__workflow_bodyteamMembers != null)
                {
                    body["teamMembers"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembers);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TaskApiFeaturesEventsEventDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesNotesNoteDTO[], ApiConnectionActionConfiguration> NoteGetAll(Expression<Func<string>> id = null, Expression<Func<string>> search = null, Expression<Func<string>> relatedToId = null, Expression<Func<relatedToTypeInput>> relatedToType = null, Expression<Func<string>> createdBy = null, Expression<Func<string>> lastModifiedBy = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
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
        public IBodyWorkflowAction<TaskApiFeaturesNotesNoteDTO, ApiConnectionActionConfiguration> NoteCreate(Expression<Func<string>> bodysubject, Expression<Func<bodytaskTypeInput>> bodytaskType = null, Expression<Func<bodyrelatedToTypeInput>> bodyrelatedToType = null, Expression<Func<bodycontactTypeInput>> bodycontactType = null, Expression<Func<string>> bodyrelatedToId = null, Expression<Func<string>> bodybody = null, Expression<Func<string>> bodyeditorBody = null, Expression<Func<string[]>> bodycontactIds = null)
        {
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: true);
            var __workflow_bodytaskType = WorkflowExpression.Compile(bodytaskType, nameof(bodytaskType), required: false);
            var __workflow_bodyrelatedToType = WorkflowExpression.Compile(bodyrelatedToType, nameof(bodyrelatedToType), required: false);
            var __workflow_bodycontactType = WorkflowExpression.Compile(bodycontactType, nameof(bodycontactType), required: false);
            var __workflow_bodyrelatedToId = WorkflowExpression.Compile(bodyrelatedToId, nameof(bodyrelatedToId), required: false);
            var __workflow_bodybody = WorkflowExpression.Compile(bodybody, nameof(bodybody), required: false);
            var __workflow_bodyeditorBody = WorkflowExpression.Compile(bodyeditorBody, nameof(bodyeditorBody), required: false);
            var __workflow_bodycontactIds = WorkflowExpression.Compile(bodycontactIds, nameof(bodycontactIds), required: false);
            return new DeferredBodyAction<TaskApiFeaturesNotesNoteDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/task/Note";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytaskType != null)
                {
                    body["taskType"] = ExpressionConverter.ConvertO(__workflow_bodytaskType);
                    bodypropCount++;
                }

                if (__workflow_bodyrelatedToType != null)
                {
                    body["relatedToType"] = ExpressionConverter.ConvertO(__workflow_bodyrelatedToType);
                    bodypropCount++;
                }

                if (__workflow_bodycontactType != null)
                {
                    body["contactType"] = ExpressionConverter.ConvertO(__workflow_bodycontactType);
                    bodypropCount++;
                }

                if (__workflow_bodyrelatedToId != null)
                {
                    body["relatedToId"] = ExpressionConverter.ConvertO(__workflow_bodyrelatedToId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                if (__workflow_bodybody != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(__workflow_bodybody);
                    bodypropCount++;
                }

                if (__workflow_bodyeditorBody != null)
                {
                    body["editorBody"] = ExpressionConverter.ConvertO(__workflow_bodyeditorBody);
                    bodypropCount++;
                }

                if (__workflow_bodycontactIds != null)
                {
                    body["contactIds"] = ExpressionConverter.ConvertO(__workflow_bodycontactIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<TaskApiFeaturesNotesNoteDTO, ApiConnectionActionConfiguration> NoteUpdate(Expression<Func<string>> id, Expression<Func<bodyrelatedToTypeInput>> bodyrelatedToType = null, Expression<Func<string>> bodyrelatedToId = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodybody = null, Expression<Func<string>> bodyeditorBody = null, Expression<Func<string>> bodylastModifiedBy = null, Expression<Func<string[]>> bodycontactIds = null, Expression<Func<bodycontactTypeInput>> bodycontactType = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyrelatedToType = WorkflowExpression.Compile(bodyrelatedToType, nameof(bodyrelatedToType), required: false);
            var __workflow_bodyrelatedToId = WorkflowExpression.Compile(bodyrelatedToId, nameof(bodyrelatedToId), required: false);
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodybody = WorkflowExpression.Compile(bodybody, nameof(bodybody), required: false);
            var __workflow_bodyeditorBody = WorkflowExpression.Compile(bodyeditorBody, nameof(bodyeditorBody), required: false);
            var __workflow_bodylastModifiedBy = WorkflowExpression.Compile(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            var __workflow_bodycontactIds = WorkflowExpression.Compile(bodycontactIds, nameof(bodycontactIds), required: false);
            var __workflow_bodycontactType = WorkflowExpression.Compile(bodycontactType, nameof(bodycontactType), required: false);
            return new DeferredBodyAction<TaskApiFeaturesNotesNoteDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/task/Note/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyrelatedToType != null)
                {
                    body["relatedToType"] = ExpressionConverter.ConvertO(__workflow_bodyrelatedToType);
                    bodypropCount++;
                }

                if (__workflow_bodyrelatedToId != null)
                {
                    body["relatedToId"] = ExpressionConverter.ConvertO(__workflow_bodyrelatedToId);
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (__workflow_bodybody != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(__workflow_bodybody);
                    bodypropCount++;
                }

                if (__workflow_bodyeditorBody != null)
                {
                    body["editorBody"] = ExpressionConverter.ConvertO(__workflow_bodyeditorBody);
                    bodypropCount++;
                }

                if (__workflow_bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = ExpressionConverter.ConvertO(__workflow_bodylastModifiedBy);
                    bodypropCount++;
                }

                if (__workflow_bodycontactIds != null)
                {
                    body["contactIds"] = ExpressionConverter.ConvertO(__workflow_bodycontactIds);
                    bodypropCount++;
                }

                if (__workflow_bodycontactType != null)
                {
                    body["contactType"] = ExpressionConverter.ConvertO(__workflow_bodycontactType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TaskApiFeaturesNotesNoteDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesTasksTaskDTO[], ApiConnectionActionConfiguration> TaskGetAll(Expression<Func<string>> id = null, Expression<Func<statusInput>> status = null, Expression<Func<string>> relatedTo = null, Expression<Func<string>> relatedToId = null, Expression<Func<string>> priorityId = null, Expression<Func<typeInput>> type = null, Expression<Func<string>> dueDate = null, Expression<Func<string>> sortDate = null, Expression<Func<string>> parentId = null, Expression<Func<string>> lastModifiedBy = null, Expression<Func<string>> createdBy = null, Expression<Func<string>> assignedToId = null, Expression<Func<string>> search = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
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
        public IBodyWorkflowAction<TaskApiFeaturesTasksTaskDTO, ApiConnectionActionConfiguration> TaskCreate(Expression<Func<bodytaskTypeInput>> bodytaskType = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodydueDate = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodypriorityId = null, Expression<Func<string>> bodyassignedToId = null, Expression<Func<bodyassignedToTypeInput>> bodyassignedToType = null, Expression<Func<string[]>> bodycontactIds = null, Expression<Func<bodycontactTypeInput>> bodycontactType = null, Expression<Func<string>> bodyrelatedToId = null, Expression<Func<bodyrelatedToTypeInput>> bodyrelatedToType = null, Expression<Func<string>> bodytaskSubTypeId = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodyeditorBody = null, Expression<Func<bool>> bodyreminderSet = null, Expression<Func<int>> bodyposition = null, Expression<Func<string>> bodyparentId = null)
        {
            var __workflow_bodytaskType = WorkflowExpression.Compile(bodytaskType, nameof(bodytaskType), required: false);
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodypriorityId = WorkflowExpression.Compile(bodypriorityId, nameof(bodypriorityId), required: false);
            var __workflow_bodyassignedToId = WorkflowExpression.Compile(bodyassignedToId, nameof(bodyassignedToId), required: false);
            var __workflow_bodyassignedToType = WorkflowExpression.Compile(bodyassignedToType, nameof(bodyassignedToType), required: false);
            var __workflow_bodycontactIds = WorkflowExpression.Compile(bodycontactIds, nameof(bodycontactIds), required: false);
            var __workflow_bodycontactType = WorkflowExpression.Compile(bodycontactType, nameof(bodycontactType), required: false);
            var __workflow_bodyrelatedToId = WorkflowExpression.Compile(bodyrelatedToId, nameof(bodyrelatedToId), required: false);
            var __workflow_bodyrelatedToType = WorkflowExpression.Compile(bodyrelatedToType, nameof(bodyrelatedToType), required: false);
            var __workflow_bodytaskSubTypeId = WorkflowExpression.Compile(bodytaskSubTypeId, nameof(bodytaskSubTypeId), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodyeditorBody = WorkflowExpression.Compile(bodyeditorBody, nameof(bodyeditorBody), required: false);
            var __workflow_bodyreminderSet = WorkflowExpression.Compile(bodyreminderSet, nameof(bodyreminderSet), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            var __workflow_bodyparentId = WorkflowExpression.Compile(bodyparentId, nameof(bodyparentId), required: false);
            return new DeferredBodyAction<TaskApiFeaturesTasksTaskDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Task";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytaskType != null)
                {
                    body["taskType"] = ExpressionConverter.ConvertO(__workflow_bodytaskType);
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (__workflow_bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(__workflow_bodydueDate);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodypriorityId != null)
                {
                    body["priorityId"] = ExpressionConverter.ConvertO(__workflow_bodypriorityId);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedToId != null)
                {
                    body["assignedToId"] = ExpressionConverter.ConvertO(__workflow_bodyassignedToId);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedToType != null)
                {
                    body["assignedToType"] = ExpressionConverter.ConvertO(__workflow_bodyassignedToType);
                    bodypropCount++;
                }

                if (__workflow_bodycontactIds != null)
                {
                    body["contactIds"] = ExpressionConverter.ConvertO(__workflow_bodycontactIds);
                    bodypropCount++;
                }

                if (__workflow_bodycontactType != null)
                {
                    body["contactType"] = ExpressionConverter.ConvertO(__workflow_bodycontactType);
                    bodypropCount++;
                }

                if (__workflow_bodyrelatedToId != null)
                {
                    body["relatedToId"] = ExpressionConverter.ConvertO(__workflow_bodyrelatedToId);
                    bodypropCount++;
                }

                if (__workflow_bodyrelatedToType != null)
                {
                    body["relatedToType"] = ExpressionConverter.ConvertO(__workflow_bodyrelatedToType);
                    bodypropCount++;
                }

                if (__workflow_bodytaskSubTypeId != null)
                {
                    body["taskSubTypeId"] = ExpressionConverter.ConvertO(__workflow_bodytaskSubTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodyeditorBody != null)
                {
                    body["editorBody"] = ExpressionConverter.ConvertO(__workflow_bodyeditorBody);
                    bodypropCount++;
                }

                if (__workflow_bodyreminderSet != null)
                {
                    body["reminderSet"] = ExpressionConverter.ConvertO(__workflow_bodyreminderSet);
                    bodypropCount++;
                }

                if (__workflow_bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (__workflow_bodyparentId != null)
                {
                    body["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyparentId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<TaskApiFeaturesTasksTaskDTO, ApiConnectionActionConfiguration> TaskUpdate(Expression<Func<string>> id, Expression<Func<bodytaskTypeInput>> bodytaskType = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodycompletedDate = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodypriorityId = null, Expression<Func<string>> bodyassignedToId = null, Expression<Func<bodyassignedToTypeInput>> bodyassignedToType = null, Expression<Func<string[]>> bodycontactIds = null, Expression<Func<bodycontactTypeInput>> bodycontactType = null, Expression<Func<string>> bodyrelatedToId = null, Expression<Func<bodyrelatedToTypeInput>> bodyrelatedToType = null, Expression<Func<string>> bodytaskSubTypeId = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodyeditorBody = null, Expression<Func<bool>> bodyreminderSet = null, Expression<Func<int>> bodyposition = null, Expression<Func<string>> bodyparentId = null, Expression<Func<string>> bodylastModifiedBy = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytaskType = WorkflowExpression.Compile(bodytaskType, nameof(bodytaskType), required: false);
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodycompletedDate = WorkflowExpression.Compile(bodycompletedDate, nameof(bodycompletedDate), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodypriorityId = WorkflowExpression.Compile(bodypriorityId, nameof(bodypriorityId), required: false);
            var __workflow_bodyassignedToId = WorkflowExpression.Compile(bodyassignedToId, nameof(bodyassignedToId), required: false);
            var __workflow_bodyassignedToType = WorkflowExpression.Compile(bodyassignedToType, nameof(bodyassignedToType), required: false);
            var __workflow_bodycontactIds = WorkflowExpression.Compile(bodycontactIds, nameof(bodycontactIds), required: false);
            var __workflow_bodycontactType = WorkflowExpression.Compile(bodycontactType, nameof(bodycontactType), required: false);
            var __workflow_bodyrelatedToId = WorkflowExpression.Compile(bodyrelatedToId, nameof(bodyrelatedToId), required: false);
            var __workflow_bodyrelatedToType = WorkflowExpression.Compile(bodyrelatedToType, nameof(bodyrelatedToType), required: false);
            var __workflow_bodytaskSubTypeId = WorkflowExpression.Compile(bodytaskSubTypeId, nameof(bodytaskSubTypeId), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodyeditorBody = WorkflowExpression.Compile(bodyeditorBody, nameof(bodyeditorBody), required: false);
            var __workflow_bodyreminderSet = WorkflowExpression.Compile(bodyreminderSet, nameof(bodyreminderSet), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            var __workflow_bodyparentId = WorkflowExpression.Compile(bodyparentId, nameof(bodyparentId), required: false);
            var __workflow_bodylastModifiedBy = WorkflowExpression.Compile(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            return new DeferredBodyAction<TaskApiFeaturesTasksTaskDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Task/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytaskType != null)
                {
                    body["taskType"] = ExpressionConverter.ConvertO(__workflow_bodytaskType);
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (__workflow_bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(__workflow_bodydueDate);
                    bodypropCount++;
                }

                if (__workflow_bodycompletedDate != null)
                {
                    body["completedDate"] = ExpressionConverter.ConvertO(__workflow_bodycompletedDate);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodypriorityId != null)
                {
                    body["priorityId"] = ExpressionConverter.ConvertO(__workflow_bodypriorityId);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedToId != null)
                {
                    body["assignedToId"] = ExpressionConverter.ConvertO(__workflow_bodyassignedToId);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedToType != null)
                {
                    body["assignedToType"] = ExpressionConverter.ConvertO(__workflow_bodyassignedToType);
                    bodypropCount++;
                }

                if (__workflow_bodycontactIds != null)
                {
                    body["contactIds"] = ExpressionConverter.ConvertO(__workflow_bodycontactIds);
                    bodypropCount++;
                }

                if (__workflow_bodycontactType != null)
                {
                    body["contactType"] = ExpressionConverter.ConvertO(__workflow_bodycontactType);
                    bodypropCount++;
                }

                if (__workflow_bodyrelatedToId != null)
                {
                    body["relatedToId"] = ExpressionConverter.ConvertO(__workflow_bodyrelatedToId);
                    bodypropCount++;
                }

                if (__workflow_bodyrelatedToType != null)
                {
                    body["relatedToType"] = ExpressionConverter.ConvertO(__workflow_bodyrelatedToType);
                    bodypropCount++;
                }

                if (__workflow_bodytaskSubTypeId != null)
                {
                    body["taskSubTypeId"] = ExpressionConverter.ConvertO(__workflow_bodytaskSubTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodyeditorBody != null)
                {
                    body["editorBody"] = ExpressionConverter.ConvertO(__workflow_bodyeditorBody);
                    bodypropCount++;
                }

                if (__workflow_bodyreminderSet != null)
                {
                    body["reminderSet"] = ExpressionConverter.ConvertO(__workflow_bodyreminderSet);
                    bodypropCount++;
                }

                if (__workflow_bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (__workflow_bodyparentId != null)
                {
                    body["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyparentId);
                    bodypropCount++;
                }

                if (__workflow_bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = ExpressionConverter.ConvertO(__workflow_bodylastModifiedBy);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TaskApiFeaturesTasksTaskDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesLeadLeadDto[], ApiConnectionActionConfiguration> LeadGetAll(Expression<Func<string>> id = null, Expression<Func<string>> name = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lastName = null, Expression<Func<string>> insertDate = null, Expression<Func<string>> phone = null, Expression<Func<string>> mobilePhone = null, Expression<Func<string>> email = null, Expression<Func<string>> ownerId = null, Expression<Func<ownerTypeInput>> ownerType = null, Expression<Func<string>> accountSourceTypeId = null, Expression<Func<string>> leadStatusId = null, Expression<Func<string>> industryId = null, Expression<Func<string>> status = null, Expression<Func<string>> search = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
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
        public IBodyWorkflowAction<SalesPipelineApiFeaturesLeadLeadDto, ApiConnectionActionConfiguration> LeadCreate(Expression<Func<string>> bodynamefirstName, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodyleadStatusId = null, Expression<Func<string>> bodynamelastName = null, Expression<Func<string>> bodynamemiddleName = null, Expression<Func<string>> bodynamesalutationId = null, Expression<Func<string>> bodynamesuffix = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodymobilePhone = null, Expression<Func<SalesPipelineApiDTOsEmailDTO[]>> bodyotherEmail = null, Expression<Func<SalesPipelineApiDTOsPhoneDTO[]>> bodyotherPhone = null, Expression<Func<bool>> bodycallOptOut = null, Expression<Func<bool>> bodyemailOptOut = null, Expression<Func<string>> bodyratingId = null, Expression<Func<string>> bodyownerId = null, Expression<Func<bodyownerTypeInput>> bodyownerType = null, Expression<Func<string>> bodywebsite = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodyindustryId = null, Expression<Func<int>> bodynoOfEmployees = null, Expression<Func<string>> bodyaccountSourceTypeId = null, Expression<Func<string>> bodyaddressaddress1 = null, Expression<Func<string>> bodyaddressaddress2 = null, Expression<Func<string>> bodyaddresscity = null, Expression<Func<string>> bodyaddressstate = null, Expression<Func<string>> bodyaddresscountry = null, Expression<Func<string>> bodyaddresspostalCode = null, Expression<Func<string>> bodydescription = null, Expression<Func<double>> bodyannualRevenue = null, Expression<Func<string>> bodylastTransferDate = null, Expression<Func<string>> bodygenderId = null, Expression<Func<string>> bodypronounceId = null, Expression<Func<bodystatusInput>> bodystatus = null)
        {
            var __workflow_bodynamefirstName = WorkflowExpression.Compile(bodynamefirstName, nameof(bodynamefirstName), required: true);
            var __workflow_bodyjobTitle = WorkflowExpression.Compile(bodyjobTitle, nameof(bodyjobTitle), required: false);
            var __workflow_bodyleadStatusId = WorkflowExpression.Compile(bodyleadStatusId, nameof(bodyleadStatusId), required: false);
            var __workflow_bodynamelastName = WorkflowExpression.Compile(bodynamelastName, nameof(bodynamelastName), required: false);
            var __workflow_bodynamemiddleName = WorkflowExpression.Compile(bodynamemiddleName, nameof(bodynamemiddleName), required: false);
            var __workflow_bodynamesalutationId = WorkflowExpression.Compile(bodynamesalutationId, nameof(bodynamesalutationId), required: false);
            var __workflow_bodynamesuffix = WorkflowExpression.Compile(bodynamesuffix, nameof(bodynamesuffix), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyphone = WorkflowExpression.Compile(bodyphone, nameof(bodyphone), required: false);
            var __workflow_bodymobilePhone = WorkflowExpression.Compile(bodymobilePhone, nameof(bodymobilePhone), required: false);
            var __workflow_bodyotherEmail = WorkflowExpression.Compile(bodyotherEmail, nameof(bodyotherEmail), required: false);
            var __workflow_bodyotherPhone = WorkflowExpression.Compile(bodyotherPhone, nameof(bodyotherPhone), required: false);
            var __workflow_bodycallOptOut = WorkflowExpression.Compile(bodycallOptOut, nameof(bodycallOptOut), required: false);
            var __workflow_bodyemailOptOut = WorkflowExpression.Compile(bodyemailOptOut, nameof(bodyemailOptOut), required: false);
            var __workflow_bodyratingId = WorkflowExpression.Compile(bodyratingId, nameof(bodyratingId), required: false);
            var __workflow_bodyownerId = WorkflowExpression.Compile(bodyownerId, nameof(bodyownerId), required: false);
            var __workflow_bodyownerType = WorkflowExpression.Compile(bodyownerType, nameof(bodyownerType), required: false);
            var __workflow_bodywebsite = WorkflowExpression.Compile(bodywebsite, nameof(bodywebsite), required: false);
            var __workflow_bodycompany = WorkflowExpression.Compile(bodycompany, nameof(bodycompany), required: false);
            var __workflow_bodyindustryId = WorkflowExpression.Compile(bodyindustryId, nameof(bodyindustryId), required: false);
            var __workflow_bodynoOfEmployees = WorkflowExpression.Compile(bodynoOfEmployees, nameof(bodynoOfEmployees), required: false);
            var __workflow_bodyaccountSourceTypeId = WorkflowExpression.Compile(bodyaccountSourceTypeId, nameof(bodyaccountSourceTypeId), required: false);
            var __workflow_bodyaddressaddress1 = WorkflowExpression.Compile(bodyaddressaddress1, nameof(bodyaddressaddress1), required: false);
            var __workflow_bodyaddressaddress2 = WorkflowExpression.Compile(bodyaddressaddress2, nameof(bodyaddressaddress2), required: false);
            var __workflow_bodyaddresscity = WorkflowExpression.Compile(bodyaddresscity, nameof(bodyaddresscity), required: false);
            var __workflow_bodyaddressstate = WorkflowExpression.Compile(bodyaddressstate, nameof(bodyaddressstate), required: false);
            var __workflow_bodyaddresscountry = WorkflowExpression.Compile(bodyaddresscountry, nameof(bodyaddresscountry), required: false);
            var __workflow_bodyaddresspostalCode = WorkflowExpression.Compile(bodyaddresspostalCode, nameof(bodyaddresspostalCode), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyannualRevenue = WorkflowExpression.Compile(bodyannualRevenue, nameof(bodyannualRevenue), required: false);
            var __workflow_bodylastTransferDate = WorkflowExpression.Compile(bodylastTransferDate, nameof(bodylastTransferDate), required: false);
            var __workflow_bodygenderId = WorkflowExpression.Compile(bodygenderId, nameof(bodygenderId), required: false);
            var __workflow_bodypronounceId = WorkflowExpression.Compile(bodypronounceId, nameof(bodypronounceId), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<SalesPipelineApiFeaturesLeadLeadDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Lead";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyjobTitle != null)
                {
                    body["jobTitle"] = ExpressionConverter.ConvertO(__workflow_bodyjobTitle);
                    bodypropCount++;
                }

                if (__workflow_bodyleadStatusId != null)
                {
                    body["leadStatusId"] = ExpressionConverter.ConvertO(__workflow_bodyleadStatusId);
                    bodypropCount++;
                }

                var nameObject = new JObject();
                var nameObjectpropCount = 0;
                nameObjectpropCount++;
                nameObject["firstName"] = ExpressionConverter.ConvertO(__workflow_bodynamefirstName);
                if (__workflow_bodynamelastName != null)
                {
                    nameObject["lastName"] = ExpressionConverter.ConvertO(__workflow_bodynamelastName);
                    nameObjectpropCount++;
                }

                if (__workflow_bodynamemiddleName != null)
                {
                    nameObject["middleName"] = ExpressionConverter.ConvertO(__workflow_bodynamemiddleName);
                    nameObjectpropCount++;
                }

                if (__workflow_bodynamesalutationId != null)
                {
                    nameObject["salutationId"] = ExpressionConverter.ConvertO(__workflow_bodynamesalutationId);
                    nameObjectpropCount++;
                }

                if (__workflow_bodynamesuffix != null)
                {
                    nameObject["suffix"] = ExpressionConverter.ConvertO(__workflow_bodynamesuffix);
                    nameObjectpropCount++;
                }

                if (nameObjectpropCount > 0)
                {
                    body["name"] = nameObject;
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(__workflow_bodyphone);
                    bodypropCount++;
                }

                if (__workflow_bodymobilePhone != null)
                {
                    body["mobilePhone"] = ExpressionConverter.ConvertO(__workflow_bodymobilePhone);
                    bodypropCount++;
                }

                if (__workflow_bodyotherEmail != null)
                {
                    body["otherEmail"] = ExpressionConverter.ConvertO(__workflow_bodyotherEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyotherPhone != null)
                {
                    body["otherPhone"] = ExpressionConverter.ConvertO(__workflow_bodyotherPhone);
                    bodypropCount++;
                }

                if (__workflow_bodycallOptOut != null)
                {
                    body["callOptOut"] = ExpressionConverter.ConvertO(__workflow_bodycallOptOut);
                    bodypropCount++;
                }

                if (__workflow_bodyemailOptOut != null)
                {
                    body["emailOptOut"] = ExpressionConverter.ConvertO(__workflow_bodyemailOptOut);
                    bodypropCount++;
                }

                if (__workflow_bodyratingId != null)
                {
                    body["ratingId"] = ExpressionConverter.ConvertO(__workflow_bodyratingId);
                    bodypropCount++;
                }

                if (__workflow_bodyownerId != null)
                {
                    body["ownerId"] = ExpressionConverter.ConvertO(__workflow_bodyownerId);
                    bodypropCount++;
                }

                if (__workflow_bodyownerType != null)
                {
                    body["ownerType"] = ExpressionConverter.ConvertO(__workflow_bodyownerType);
                    bodypropCount++;
                }

                if (__workflow_bodywebsite != null)
                {
                    body["website"] = ExpressionConverter.ConvertO(__workflow_bodywebsite);
                    bodypropCount++;
                }

                if (__workflow_bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(__workflow_bodycompany);
                    bodypropCount++;
                }

                if (__workflow_bodyindustryId != null)
                {
                    body["industryId"] = ExpressionConverter.ConvertO(__workflow_bodyindustryId);
                    bodypropCount++;
                }

                if (__workflow_bodynoOfEmployees != null)
                {
                    body["noOfEmployees"] = ExpressionConverter.ConvertO(__workflow_bodynoOfEmployees);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountSourceTypeId != null)
                {
                    body["accountSourceTypeId"] = ExpressionConverter.ConvertO(__workflow_bodyaccountSourceTypeId);
                    bodypropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (__workflow_bodyaddressaddress1 != null)
                {
                    addressObject["address1"] = ExpressionConverter.ConvertO(__workflow_bodyaddressaddress1);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressaddress2 != null)
                {
                    addressObject["address2"] = ExpressionConverter.ConvertO(__workflow_bodyaddressaddress2);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscity != null)
                {
                    addressObject["city"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressstate != null)
                {
                    addressObject["state"] = ExpressionConverter.ConvertO(__workflow_bodyaddressstate);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscountry != null)
                {
                    addressObject["country"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscountry);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresspostalCode != null)
                {
                    addressObject["postalCode"] = ExpressionConverter.ConvertO(__workflow_bodyaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyannualRevenue != null)
                {
                    body["annualRevenue"] = ExpressionConverter.ConvertO(__workflow_bodyannualRevenue);
                    bodypropCount++;
                }

                if (__workflow_bodylastTransferDate != null)
                {
                    body["lastTransferDate"] = ExpressionConverter.ConvertO(__workflow_bodylastTransferDate);
                    bodypropCount++;
                }

                if (__workflow_bodygenderId != null)
                {
                    body["genderId"] = ExpressionConverter.ConvertO(__workflow_bodygenderId);
                    bodypropCount++;
                }

                if (__workflow_bodypronounceId != null)
                {
                    body["pronounceId"] = ExpressionConverter.ConvertO(__workflow_bodypronounceId);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                var extraFieldsObject = new JObject();
                var extraFieldsObjectpropCount = 0;
                if (extraFieldsObjectpropCount > 0)
                {
                    body["extraFields"] = extraFieldsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<SalesPipelineApiFeaturesLeadLeadDto, ApiConnectionActionConfiguration> LeadUpdate(Expression<Func<string>> id, Expression<Func<string>> bodynamefirstName, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodyleadStatusId = null, Expression<Func<string>> bodynamelastName = null, Expression<Func<string>> bodynamemiddleName = null, Expression<Func<string>> bodynamesalutationId = null, Expression<Func<string>> bodynamesuffix = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodymobilePhone = null, Expression<Func<SalesPipelineApiDTOsEmailDTO[]>> bodyotherEmail = null, Expression<Func<SalesPipelineApiDTOsPhoneDTO[]>> bodyotherPhone = null, Expression<Func<bool>> bodycallOptOut = null, Expression<Func<bool>> bodyemailOptOut = null, Expression<Func<string>> bodyratingId = null, Expression<Func<string>> bodyownerId = null, Expression<Func<bodyownerTypeInput>> bodyownerType = null, Expression<Func<string>> bodywebsite = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodyindustryId = null, Expression<Func<int>> bodynoOfEmployees = null, Expression<Func<string>> bodyaccountSourceTypeId = null, Expression<Func<string>> bodyaddressaddress1 = null, Expression<Func<string>> bodyaddressaddress2 = null, Expression<Func<string>> bodyaddresscity = null, Expression<Func<string>> bodyaddressstate = null, Expression<Func<string>> bodyaddresscountry = null, Expression<Func<string>> bodyaddresspostalCode = null, Expression<Func<string>> bodydescription = null, Expression<Func<double>> bodyannualRevenue = null, Expression<Func<string>> bodylastTransferDate = null, Expression<Func<string>> bodygenderId = null, Expression<Func<string>> bodypronounceId = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodylastModifiedBy = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodynamefirstName = WorkflowExpression.Compile(bodynamefirstName, nameof(bodynamefirstName), required: true);
            var __workflow_bodyjobTitle = WorkflowExpression.Compile(bodyjobTitle, nameof(bodyjobTitle), required: false);
            var __workflow_bodyleadStatusId = WorkflowExpression.Compile(bodyleadStatusId, nameof(bodyleadStatusId), required: false);
            var __workflow_bodynamelastName = WorkflowExpression.Compile(bodynamelastName, nameof(bodynamelastName), required: false);
            var __workflow_bodynamemiddleName = WorkflowExpression.Compile(bodynamemiddleName, nameof(bodynamemiddleName), required: false);
            var __workflow_bodynamesalutationId = WorkflowExpression.Compile(bodynamesalutationId, nameof(bodynamesalutationId), required: false);
            var __workflow_bodynamesuffix = WorkflowExpression.Compile(bodynamesuffix, nameof(bodynamesuffix), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyphone = WorkflowExpression.Compile(bodyphone, nameof(bodyphone), required: false);
            var __workflow_bodymobilePhone = WorkflowExpression.Compile(bodymobilePhone, nameof(bodymobilePhone), required: false);
            var __workflow_bodyotherEmail = WorkflowExpression.Compile(bodyotherEmail, nameof(bodyotherEmail), required: false);
            var __workflow_bodyotherPhone = WorkflowExpression.Compile(bodyotherPhone, nameof(bodyotherPhone), required: false);
            var __workflow_bodycallOptOut = WorkflowExpression.Compile(bodycallOptOut, nameof(bodycallOptOut), required: false);
            var __workflow_bodyemailOptOut = WorkflowExpression.Compile(bodyemailOptOut, nameof(bodyemailOptOut), required: false);
            var __workflow_bodyratingId = WorkflowExpression.Compile(bodyratingId, nameof(bodyratingId), required: false);
            var __workflow_bodyownerId = WorkflowExpression.Compile(bodyownerId, nameof(bodyownerId), required: false);
            var __workflow_bodyownerType = WorkflowExpression.Compile(bodyownerType, nameof(bodyownerType), required: false);
            var __workflow_bodywebsite = WorkflowExpression.Compile(bodywebsite, nameof(bodywebsite), required: false);
            var __workflow_bodycompany = WorkflowExpression.Compile(bodycompany, nameof(bodycompany), required: false);
            var __workflow_bodyindustryId = WorkflowExpression.Compile(bodyindustryId, nameof(bodyindustryId), required: false);
            var __workflow_bodynoOfEmployees = WorkflowExpression.Compile(bodynoOfEmployees, nameof(bodynoOfEmployees), required: false);
            var __workflow_bodyaccountSourceTypeId = WorkflowExpression.Compile(bodyaccountSourceTypeId, nameof(bodyaccountSourceTypeId), required: false);
            var __workflow_bodyaddressaddress1 = WorkflowExpression.Compile(bodyaddressaddress1, nameof(bodyaddressaddress1), required: false);
            var __workflow_bodyaddressaddress2 = WorkflowExpression.Compile(bodyaddressaddress2, nameof(bodyaddressaddress2), required: false);
            var __workflow_bodyaddresscity = WorkflowExpression.Compile(bodyaddresscity, nameof(bodyaddresscity), required: false);
            var __workflow_bodyaddressstate = WorkflowExpression.Compile(bodyaddressstate, nameof(bodyaddressstate), required: false);
            var __workflow_bodyaddresscountry = WorkflowExpression.Compile(bodyaddresscountry, nameof(bodyaddresscountry), required: false);
            var __workflow_bodyaddresspostalCode = WorkflowExpression.Compile(bodyaddresspostalCode, nameof(bodyaddresspostalCode), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyannualRevenue = WorkflowExpression.Compile(bodyannualRevenue, nameof(bodyannualRevenue), required: false);
            var __workflow_bodylastTransferDate = WorkflowExpression.Compile(bodylastTransferDate, nameof(bodylastTransferDate), required: false);
            var __workflow_bodygenderId = WorkflowExpression.Compile(bodygenderId, nameof(bodygenderId), required: false);
            var __workflow_bodypronounceId = WorkflowExpression.Compile(bodypronounceId, nameof(bodypronounceId), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodylastModifiedBy = WorkflowExpression.Compile(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            return new DeferredBodyAction<SalesPipelineApiFeaturesLeadLeadDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Lead/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyjobTitle != null)
                {
                    body["jobTitle"] = ExpressionConverter.ConvertO(__workflow_bodyjobTitle);
                    bodypropCount++;
                }

                if (__workflow_bodyleadStatusId != null)
                {
                    body["leadStatusId"] = ExpressionConverter.ConvertO(__workflow_bodyleadStatusId);
                    bodypropCount++;
                }

                var nameObject = new JObject();
                var nameObjectpropCount = 0;
                nameObjectpropCount++;
                nameObject["firstName"] = ExpressionConverter.ConvertO(__workflow_bodynamefirstName);
                if (__workflow_bodynamelastName != null)
                {
                    nameObject["lastName"] = ExpressionConverter.ConvertO(__workflow_bodynamelastName);
                    nameObjectpropCount++;
                }

                if (__workflow_bodynamemiddleName != null)
                {
                    nameObject["middleName"] = ExpressionConverter.ConvertO(__workflow_bodynamemiddleName);
                    nameObjectpropCount++;
                }

                if (__workflow_bodynamesalutationId != null)
                {
                    nameObject["salutationId"] = ExpressionConverter.ConvertO(__workflow_bodynamesalutationId);
                    nameObjectpropCount++;
                }

                if (__workflow_bodynamesuffix != null)
                {
                    nameObject["suffix"] = ExpressionConverter.ConvertO(__workflow_bodynamesuffix);
                    nameObjectpropCount++;
                }

                if (nameObjectpropCount > 0)
                {
                    body["name"] = nameObject;
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(__workflow_bodyphone);
                    bodypropCount++;
                }

                if (__workflow_bodymobilePhone != null)
                {
                    body["mobilePhone"] = ExpressionConverter.ConvertO(__workflow_bodymobilePhone);
                    bodypropCount++;
                }

                if (__workflow_bodyotherEmail != null)
                {
                    body["otherEmail"] = ExpressionConverter.ConvertO(__workflow_bodyotherEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyotherPhone != null)
                {
                    body["otherPhone"] = ExpressionConverter.ConvertO(__workflow_bodyotherPhone);
                    bodypropCount++;
                }

                if (__workflow_bodycallOptOut != null)
                {
                    body["callOptOut"] = ExpressionConverter.ConvertO(__workflow_bodycallOptOut);
                    bodypropCount++;
                }

                if (__workflow_bodyemailOptOut != null)
                {
                    body["emailOptOut"] = ExpressionConverter.ConvertO(__workflow_bodyemailOptOut);
                    bodypropCount++;
                }

                if (__workflow_bodyratingId != null)
                {
                    body["ratingId"] = ExpressionConverter.ConvertO(__workflow_bodyratingId);
                    bodypropCount++;
                }

                if (__workflow_bodyownerId != null)
                {
                    body["ownerId"] = ExpressionConverter.ConvertO(__workflow_bodyownerId);
                    bodypropCount++;
                }

                if (__workflow_bodyownerType != null)
                {
                    body["ownerType"] = ExpressionConverter.ConvertO(__workflow_bodyownerType);
                    bodypropCount++;
                }

                if (__workflow_bodywebsite != null)
                {
                    body["website"] = ExpressionConverter.ConvertO(__workflow_bodywebsite);
                    bodypropCount++;
                }

                if (__workflow_bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(__workflow_bodycompany);
                    bodypropCount++;
                }

                if (__workflow_bodyindustryId != null)
                {
                    body["industryId"] = ExpressionConverter.ConvertO(__workflow_bodyindustryId);
                    bodypropCount++;
                }

                if (__workflow_bodynoOfEmployees != null)
                {
                    body["noOfEmployees"] = ExpressionConverter.ConvertO(__workflow_bodynoOfEmployees);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountSourceTypeId != null)
                {
                    body["accountSourceTypeId"] = ExpressionConverter.ConvertO(__workflow_bodyaccountSourceTypeId);
                    bodypropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (__workflow_bodyaddressaddress1 != null)
                {
                    addressObject["address1"] = ExpressionConverter.ConvertO(__workflow_bodyaddressaddress1);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressaddress2 != null)
                {
                    addressObject["address2"] = ExpressionConverter.ConvertO(__workflow_bodyaddressaddress2);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscity != null)
                {
                    addressObject["city"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressstate != null)
                {
                    addressObject["state"] = ExpressionConverter.ConvertO(__workflow_bodyaddressstate);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscountry != null)
                {
                    addressObject["country"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscountry);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresspostalCode != null)
                {
                    addressObject["postalCode"] = ExpressionConverter.ConvertO(__workflow_bodyaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyannualRevenue != null)
                {
                    body["annualRevenue"] = ExpressionConverter.ConvertO(__workflow_bodyannualRevenue);
                    bodypropCount++;
                }

                if (__workflow_bodylastTransferDate != null)
                {
                    body["lastTransferDate"] = ExpressionConverter.ConvertO(__workflow_bodylastTransferDate);
                    bodypropCount++;
                }

                if (__workflow_bodygenderId != null)
                {
                    body["genderId"] = ExpressionConverter.ConvertO(__workflow_bodygenderId);
                    bodypropCount++;
                }

                if (__workflow_bodypronounceId != null)
                {
                    body["pronounceId"] = ExpressionConverter.ConvertO(__workflow_bodypronounceId);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = ExpressionConverter.ConvertO(__workflow_bodylastModifiedBy);
                    bodypropCount++;
                }

                var extraFieldsObject = new JObject();
                var extraFieldsObjectpropCount = 0;
                if (extraFieldsObjectpropCount > 0)
                {
                    body["extraFields"] = extraFieldsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO, ApiConnectionActionConfiguration> OpportunityCreate(Expression<Func<string>> bodyname, Expression<Func<string>> bodycloseDate, Expression<Func<string>> bodytypeId = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string>> bodyaccountId = null, Expression<Func<double>> bodyamount = null, Expression<Func<string>> bodyforecastCategoryId = null, Expression<Func<string>> bodysalesPipelineId = null, Expression<Func<int>> bodyprobability = null, Expression<Func<int>> bodyscore = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyquoteId = null, Expression<Func<string>> bodyopportunityStatusId = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodyaccountSourceTypeId = null, Expression<Func<string>> bodynextStep = null, Expression<Func<bool>> bodybudgetConfirmed = null, Expression<Func<bool>> bodydiscoveryCompleted = null, Expression<Func<double>> bodyexpectedRevenue = null, Expression<Func<string>> bodylossReasonId = null, Expression<Func<bool>> bodyprivate = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodycloseDate = WorkflowExpression.Compile(bodycloseDate, nameof(bodycloseDate), required: true);
            var __workflow_bodytypeId = WorkflowExpression.Compile(bodytypeId, nameof(bodytypeId), required: false);
            var __workflow_bodyownerId = WorkflowExpression.Compile(bodyownerId, nameof(bodyownerId), required: false);
            var __workflow_bodyaccountId = WorkflowExpression.Compile(bodyaccountId, nameof(bodyaccountId), required: false);
            var __workflow_bodyamount = WorkflowExpression.Compile(bodyamount, nameof(bodyamount), required: false);
            var __workflow_bodyforecastCategoryId = WorkflowExpression.Compile(bodyforecastCategoryId, nameof(bodyforecastCategoryId), required: false);
            var __workflow_bodysalesPipelineId = WorkflowExpression.Compile(bodysalesPipelineId, nameof(bodysalesPipelineId), required: false);
            var __workflow_bodyprobability = WorkflowExpression.Compile(bodyprobability, nameof(bodyprobability), required: false);
            var __workflow_bodyscore = WorkflowExpression.Compile(bodyscore, nameof(bodyscore), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyquoteId = WorkflowExpression.Compile(bodyquoteId, nameof(bodyquoteId), required: false);
            var __workflow_bodyopportunityStatusId = WorkflowExpression.Compile(bodyopportunityStatusId, nameof(bodyopportunityStatusId), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyaccountSourceTypeId = WorkflowExpression.Compile(bodyaccountSourceTypeId, nameof(bodyaccountSourceTypeId), required: false);
            var __workflow_bodynextStep = WorkflowExpression.Compile(bodynextStep, nameof(bodynextStep), required: false);
            var __workflow_bodybudgetConfirmed = WorkflowExpression.Compile(bodybudgetConfirmed, nameof(bodybudgetConfirmed), required: false);
            var __workflow_bodydiscoveryCompleted = WorkflowExpression.Compile(bodydiscoveryCompleted, nameof(bodydiscoveryCompleted), required: false);
            var __workflow_bodyexpectedRevenue = WorkflowExpression.Compile(bodyexpectedRevenue, nameof(bodyexpectedRevenue), required: false);
            var __workflow_bodylossReasonId = WorkflowExpression.Compile(bodylossReasonId, nameof(bodylossReasonId), required: false);
            var __workflow_bodyprivate = WorkflowExpression.Compile(bodyprivate, nameof(bodyprivate), required: false);
            return new DeferredBodyAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Opportunity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytypeId != null)
                {
                    body["typeId"] = ExpressionConverter.ConvertO(__workflow_bodytypeId);
                    bodypropCount++;
                }

                if (__workflow_bodyownerId != null)
                {
                    body["ownerId"] = ExpressionConverter.ConvertO(__workflow_bodyownerId);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountId != null)
                {
                    body["accountId"] = ExpressionConverter.ConvertO(__workflow_bodyaccountId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodyamount != null)
                {
                    body["amount"] = ExpressionConverter.ConvertO(__workflow_bodyamount);
                    bodypropCount++;
                }

                if (__workflow_bodyforecastCategoryId != null)
                {
                    body["forecastCategoryId"] = ExpressionConverter.ConvertO(__workflow_bodyforecastCategoryId);
                    bodypropCount++;
                }

                if (__workflow_bodysalesPipelineId != null)
                {
                    body["salesPipelineId"] = ExpressionConverter.ConvertO(__workflow_bodysalesPipelineId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["closeDate"] = ExpressionConverter.ConvertO(__workflow_bodycloseDate);
                if (__workflow_bodyprobability != null)
                {
                    body["probability"] = ExpressionConverter.ConvertO(__workflow_bodyprobability);
                    bodypropCount++;
                }

                if (__workflow_bodyscore != null)
                {
                    body["score"] = ExpressionConverter.ConvertO(__workflow_bodyscore);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyquoteId != null)
                {
                    body["quoteId"] = ExpressionConverter.ConvertO(__workflow_bodyquoteId);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityStatusId != null)
                {
                    body["opportunityStatusId"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityStatusId);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountSourceTypeId != null)
                {
                    body["accountSourceTypeId"] = ExpressionConverter.ConvertO(__workflow_bodyaccountSourceTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodynextStep != null)
                {
                    body["nextStep"] = ExpressionConverter.ConvertO(__workflow_bodynextStep);
                    bodypropCount++;
                }

                if (__workflow_bodybudgetConfirmed != null)
                {
                    body["budgetConfirmed"] = ExpressionConverter.ConvertO(__workflow_bodybudgetConfirmed);
                    bodypropCount++;
                }

                if (__workflow_bodydiscoveryCompleted != null)
                {
                    body["discoveryCompleted"] = ExpressionConverter.ConvertO(__workflow_bodydiscoveryCompleted);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedRevenue != null)
                {
                    body["expectedRevenue"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedRevenue);
                    bodypropCount++;
                }

                if (__workflow_bodylossReasonId != null)
                {
                    body["lossReasonId"] = ExpressionConverter.ConvertO(__workflow_bodylossReasonId);
                    bodypropCount++;
                }

                if (__workflow_bodyprivate != null)
                {
                    body["private"] = ExpressionConverter.ConvertO(__workflow_bodyprivate);
                    bodypropCount++;
                }

                var extraFieldsObject = new JObject();
                var extraFieldsObjectpropCount = 0;
                if (extraFieldsObjectpropCount > 0)
                {
                    body["extraFields"] = extraFieldsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO, ApiConnectionActionConfiguration> OpportunityUpdate(Expression<Func<string>> id, Expression<Func<string>> bodytypeId = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string>> bodyaccountId = null, Expression<Func<string>> bodyname = null, Expression<Func<double>> bodyamount = null, Expression<Func<string>> bodyforecastCategoryId = null, Expression<Func<string>> bodycloseDate = null, Expression<Func<int>> bodyprobability = null, Expression<Func<int>> bodyscore = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodysalesPipelineId = null, Expression<Func<string>> bodyquoteId = null, Expression<Func<string>> bodyopportunityStatusId = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodyaccountSourceTypeId = null, Expression<Func<string>> bodynextStep = null, Expression<Func<bool>> bodybudgetConfirmed = null, Expression<Func<bool>> bodydiscoveryCompleted = null, Expression<Func<double>> bodyexpectedRevenue = null, Expression<Func<string>> bodylossReasonId = null, Expression<Func<bool>> bodyprivate = null, Expression<Func<string>> bodylastModifiedBy = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytypeId = WorkflowExpression.Compile(bodytypeId, nameof(bodytypeId), required: false);
            var __workflow_bodyownerId = WorkflowExpression.Compile(bodyownerId, nameof(bodyownerId), required: false);
            var __workflow_bodyaccountId = WorkflowExpression.Compile(bodyaccountId, nameof(bodyaccountId), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyamount = WorkflowExpression.Compile(bodyamount, nameof(bodyamount), required: false);
            var __workflow_bodyforecastCategoryId = WorkflowExpression.Compile(bodyforecastCategoryId, nameof(bodyforecastCategoryId), required: false);
            var __workflow_bodycloseDate = WorkflowExpression.Compile(bodycloseDate, nameof(bodycloseDate), required: false);
            var __workflow_bodyprobability = WorkflowExpression.Compile(bodyprobability, nameof(bodyprobability), required: false);
            var __workflow_bodyscore = WorkflowExpression.Compile(bodyscore, nameof(bodyscore), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodysalesPipelineId = WorkflowExpression.Compile(bodysalesPipelineId, nameof(bodysalesPipelineId), required: false);
            var __workflow_bodyquoteId = WorkflowExpression.Compile(bodyquoteId, nameof(bodyquoteId), required: false);
            var __workflow_bodyopportunityStatusId = WorkflowExpression.Compile(bodyopportunityStatusId, nameof(bodyopportunityStatusId), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyaccountSourceTypeId = WorkflowExpression.Compile(bodyaccountSourceTypeId, nameof(bodyaccountSourceTypeId), required: false);
            var __workflow_bodynextStep = WorkflowExpression.Compile(bodynextStep, nameof(bodynextStep), required: false);
            var __workflow_bodybudgetConfirmed = WorkflowExpression.Compile(bodybudgetConfirmed, nameof(bodybudgetConfirmed), required: false);
            var __workflow_bodydiscoveryCompleted = WorkflowExpression.Compile(bodydiscoveryCompleted, nameof(bodydiscoveryCompleted), required: false);
            var __workflow_bodyexpectedRevenue = WorkflowExpression.Compile(bodyexpectedRevenue, nameof(bodyexpectedRevenue), required: false);
            var __workflow_bodylossReasonId = WorkflowExpression.Compile(bodylossReasonId, nameof(bodylossReasonId), required: false);
            var __workflow_bodyprivate = WorkflowExpression.Compile(bodyprivate, nameof(bodyprivate), required: false);
            var __workflow_bodylastModifiedBy = WorkflowExpression.Compile(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            return new DeferredBodyAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Opportunity/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytypeId != null)
                {
                    body["typeId"] = ExpressionConverter.ConvertO(__workflow_bodytypeId);
                    bodypropCount++;
                }

                if (__workflow_bodyownerId != null)
                {
                    body["ownerId"] = ExpressionConverter.ConvertO(__workflow_bodyownerId);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountId != null)
                {
                    body["accountId"] = ExpressionConverter.ConvertO(__workflow_bodyaccountId);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyamount != null)
                {
                    body["amount"] = ExpressionConverter.ConvertO(__workflow_bodyamount);
                    bodypropCount++;
                }

                if (__workflow_bodyforecastCategoryId != null)
                {
                    body["forecastCategoryId"] = ExpressionConverter.ConvertO(__workflow_bodyforecastCategoryId);
                    bodypropCount++;
                }

                if (__workflow_bodycloseDate != null)
                {
                    body["closeDate"] = ExpressionConverter.ConvertO(__workflow_bodycloseDate);
                    bodypropCount++;
                }

                if (__workflow_bodyprobability != null)
                {
                    body["probability"] = ExpressionConverter.ConvertO(__workflow_bodyprobability);
                    bodypropCount++;
                }

                if (__workflow_bodyscore != null)
                {
                    body["score"] = ExpressionConverter.ConvertO(__workflow_bodyscore);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodysalesPipelineId != null)
                {
                    body["salesPipelineId"] = ExpressionConverter.ConvertO(__workflow_bodysalesPipelineId);
                    bodypropCount++;
                }

                if (__workflow_bodyquoteId != null)
                {
                    body["quoteId"] = ExpressionConverter.ConvertO(__workflow_bodyquoteId);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityStatusId != null)
                {
                    body["opportunityStatusId"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityStatusId);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountSourceTypeId != null)
                {
                    body["accountSourceTypeId"] = ExpressionConverter.ConvertO(__workflow_bodyaccountSourceTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodynextStep != null)
                {
                    body["nextStep"] = ExpressionConverter.ConvertO(__workflow_bodynextStep);
                    bodypropCount++;
                }

                if (__workflow_bodybudgetConfirmed != null)
                {
                    body["budgetConfirmed"] = ExpressionConverter.ConvertO(__workflow_bodybudgetConfirmed);
                    bodypropCount++;
                }

                if (__workflow_bodydiscoveryCompleted != null)
                {
                    body["discoveryCompleted"] = ExpressionConverter.ConvertO(__workflow_bodydiscoveryCompleted);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedRevenue != null)
                {
                    body["expectedRevenue"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedRevenue);
                    bodypropCount++;
                }

                if (__workflow_bodylossReasonId != null)
                {
                    body["lossReasonId"] = ExpressionConverter.ConvertO(__workflow_bodylossReasonId);
                    bodypropCount++;
                }

                if (__workflow_bodyprivate != null)
                {
                    body["private"] = ExpressionConverter.ConvertO(__workflow_bodyprivate);
                    bodypropCount++;
                }

                if (__workflow_bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = ExpressionConverter.ConvertO(__workflow_bodylastModifiedBy);
                    bodypropCount++;
                }

                var extraFieldsObject = new JObject();
                var extraFieldsObjectpropCount = 0;
                if (extraFieldsObjectpropCount > 0)
                {
                    body["extraFields"] = extraFieldsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<CustomerApiFeaturesAccountsAccountDTO, ApiConnectionActionConfiguration> AccountUpdate(Expression<Func<string>> accountId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodytin = null, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodysourceId = null, Expression<Func<string>> bodysourceParentId = null, Expression<Func<string>> bodysourceOwnerId = null, Expression<Func<string[]>> bodyprimaryContactIds = null, Expression<Func<string>> bodyparentAccountId = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string>> bodyaddressaddress1 = null, Expression<Func<string>> bodyaddressaddress2 = null, Expression<Func<string>> bodyaddresscity = null, Expression<Func<string>> bodyaddressstate = null, Expression<Func<string>> bodyaddresslatitude = null, Expression<Func<string>> bodyaddresslongtitude = null, Expression<Func<string>> bodyaddresscountry = null, Expression<Func<string>> bodyaddresscountryCode = null, Expression<Func<string>> bodyaddresspostalCode = null, Expression<Func<string>> bodyaddressfirstName = null, Expression<Func<string>> bodyaddresslastName = null, Expression<Func<string>> bodyaddressphoneNumber = null, Expression<Func<string>> bodyaddressemail = null, Expression<Func<string>> bodyaccountSourceTypeId = null, Expression<Func<string>> bodyindustryId = null, Expression<Func<string>> bodytierId = null, Expression<Func<string>> bodywebsite = null, Expression<Func<string>> bodyaccountDescription = null, Expression<Func<int>> bodynoOfEmployees = null, Expression<Func<double>> bodyannualRevenue = null, Expression<Func<string>> bodycreatedBy = null, Expression<Func<string>> bodylastModifiedBy = null, Expression<Func<string>> bodyfax = null, Expression<Func<string>> bodyownershipId = null, Expression<Func<string>> bodyratingId = null, Expression<Func<string>> bodyclassificationId = null, Expression<Func<string[]>> bodyassignedTeams = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyphone = WorkflowExpression.Compile(bodyphone, nameof(bodyphone), required: false);
            var __workflow_bodytin = WorkflowExpression.Compile(bodytin, nameof(bodytin), required: false);
            var __workflow_bodycode = WorkflowExpression.Compile(bodycode, nameof(bodycode), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodysourceId = WorkflowExpression.Compile(bodysourceId, nameof(bodysourceId), required: false);
            var __workflow_bodysourceParentId = WorkflowExpression.Compile(bodysourceParentId, nameof(bodysourceParentId), required: false);
            var __workflow_bodysourceOwnerId = WorkflowExpression.Compile(bodysourceOwnerId, nameof(bodysourceOwnerId), required: false);
            var __workflow_bodyprimaryContactIds = WorkflowExpression.Compile(bodyprimaryContactIds, nameof(bodyprimaryContactIds), required: false);
            var __workflow_bodyparentAccountId = WorkflowExpression.Compile(bodyparentAccountId, nameof(bodyparentAccountId), required: false);
            var __workflow_bodyownerId = WorkflowExpression.Compile(bodyownerId, nameof(bodyownerId), required: false);
            var __workflow_bodyaddressaddress1 = WorkflowExpression.Compile(bodyaddressaddress1, nameof(bodyaddressaddress1), required: false);
            var __workflow_bodyaddressaddress2 = WorkflowExpression.Compile(bodyaddressaddress2, nameof(bodyaddressaddress2), required: false);
            var __workflow_bodyaddresscity = WorkflowExpression.Compile(bodyaddresscity, nameof(bodyaddresscity), required: false);
            var __workflow_bodyaddressstate = WorkflowExpression.Compile(bodyaddressstate, nameof(bodyaddressstate), required: false);
            var __workflow_bodyaddresslatitude = WorkflowExpression.Compile(bodyaddresslatitude, nameof(bodyaddresslatitude), required: false);
            var __workflow_bodyaddresslongtitude = WorkflowExpression.Compile(bodyaddresslongtitude, nameof(bodyaddresslongtitude), required: false);
            var __workflow_bodyaddresscountry = WorkflowExpression.Compile(bodyaddresscountry, nameof(bodyaddresscountry), required: false);
            var __workflow_bodyaddresscountryCode = WorkflowExpression.Compile(bodyaddresscountryCode, nameof(bodyaddresscountryCode), required: false);
            var __workflow_bodyaddresspostalCode = WorkflowExpression.Compile(bodyaddresspostalCode, nameof(bodyaddresspostalCode), required: false);
            var __workflow_bodyaddressfirstName = WorkflowExpression.Compile(bodyaddressfirstName, nameof(bodyaddressfirstName), required: false);
            var __workflow_bodyaddresslastName = WorkflowExpression.Compile(bodyaddresslastName, nameof(bodyaddresslastName), required: false);
            var __workflow_bodyaddressphoneNumber = WorkflowExpression.Compile(bodyaddressphoneNumber, nameof(bodyaddressphoneNumber), required: false);
            var __workflow_bodyaddressemail = WorkflowExpression.Compile(bodyaddressemail, nameof(bodyaddressemail), required: false);
            var __workflow_bodyaccountSourceTypeId = WorkflowExpression.Compile(bodyaccountSourceTypeId, nameof(bodyaccountSourceTypeId), required: false);
            var __workflow_bodyindustryId = WorkflowExpression.Compile(bodyindustryId, nameof(bodyindustryId), required: false);
            var __workflow_bodytierId = WorkflowExpression.Compile(bodytierId, nameof(bodytierId), required: false);
            var __workflow_bodywebsite = WorkflowExpression.Compile(bodywebsite, nameof(bodywebsite), required: false);
            var __workflow_bodyaccountDescription = WorkflowExpression.Compile(bodyaccountDescription, nameof(bodyaccountDescription), required: false);
            var __workflow_bodynoOfEmployees = WorkflowExpression.Compile(bodynoOfEmployees, nameof(bodynoOfEmployees), required: false);
            var __workflow_bodyannualRevenue = WorkflowExpression.Compile(bodyannualRevenue, nameof(bodyannualRevenue), required: false);
            var __workflow_bodycreatedBy = WorkflowExpression.Compile(bodycreatedBy, nameof(bodycreatedBy), required: false);
            var __workflow_bodylastModifiedBy = WorkflowExpression.Compile(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            var __workflow_bodyfax = WorkflowExpression.Compile(bodyfax, nameof(bodyfax), required: false);
            var __workflow_bodyownershipId = WorkflowExpression.Compile(bodyownershipId, nameof(bodyownershipId), required: false);
            var __workflow_bodyratingId = WorkflowExpression.Compile(bodyratingId, nameof(bodyratingId), required: false);
            var __workflow_bodyclassificationId = WorkflowExpression.Compile(bodyclassificationId, nameof(bodyclassificationId), required: false);
            var __workflow_bodyassignedTeams = WorkflowExpression.Compile(bodyassignedTeams, nameof(bodyassignedTeams), required: false);
            return new DeferredBodyAction<CustomerApiFeaturesAccountsAccountDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Account/{0}", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(__workflow_bodyphone);
                    bodypropCount++;
                }

                if (__workflow_bodytin != null)
                {
                    body["tin"] = ExpressionConverter.ConvertO(__workflow_bodytin);
                    bodypropCount++;
                }

                if (__workflow_bodycode != null)
                {
                    body["code"] = ExpressionConverter.ConvertO(__workflow_bodycode);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodysourceId != null)
                {
                    body["sourceId"] = ExpressionConverter.ConvertO(__workflow_bodysourceId);
                    bodypropCount++;
                }

                if (__workflow_bodysourceParentId != null)
                {
                    body["sourceParentId"] = ExpressionConverter.ConvertO(__workflow_bodysourceParentId);
                    bodypropCount++;
                }

                if (__workflow_bodysourceOwnerId != null)
                {
                    body["sourceOwnerId"] = ExpressionConverter.ConvertO(__workflow_bodysourceOwnerId);
                    bodypropCount++;
                }

                if (__workflow_bodyprimaryContactIds != null)
                {
                    body["primaryContactIds"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryContactIds);
                    bodypropCount++;
                }

                if (__workflow_bodyparentAccountId != null)
                {
                    body["parentAccountId"] = ExpressionConverter.ConvertO(__workflow_bodyparentAccountId);
                    bodypropCount++;
                }

                if (__workflow_bodyownerId != null)
                {
                    body["ownerId"] = ExpressionConverter.ConvertO(__workflow_bodyownerId);
                    bodypropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (__workflow_bodyaddressaddress1 != null)
                {
                    addressObject["address1"] = ExpressionConverter.ConvertO(__workflow_bodyaddressaddress1);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressaddress2 != null)
                {
                    addressObject["address2"] = ExpressionConverter.ConvertO(__workflow_bodyaddressaddress2);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscity != null)
                {
                    addressObject["city"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressstate != null)
                {
                    addressObject["state"] = ExpressionConverter.ConvertO(__workflow_bodyaddressstate);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresslatitude != null)
                {
                    addressObject["latitude"] = ExpressionConverter.ConvertO(__workflow_bodyaddresslatitude);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresslongtitude != null)
                {
                    addressObject["longtitude"] = ExpressionConverter.ConvertO(__workflow_bodyaddresslongtitude);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscountry != null)
                {
                    addressObject["country"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscountry);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscountryCode != null)
                {
                    addressObject["countryCode"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscountryCode);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresspostalCode != null)
                {
                    addressObject["postalCode"] = ExpressionConverter.ConvertO(__workflow_bodyaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressfirstName != null)
                {
                    addressObject["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyaddressfirstName);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresslastName != null)
                {
                    addressObject["lastName"] = ExpressionConverter.ConvertO(__workflow_bodyaddresslastName);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressphoneNumber != null)
                {
                    addressObject["phoneNumber"] = ExpressionConverter.ConvertO(__workflow_bodyaddressphoneNumber);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressemail != null)
                {
                    addressObject["email"] = ExpressionConverter.ConvertO(__workflow_bodyaddressemail);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                if (__workflow_bodyaccountSourceTypeId != null)
                {
                    body["accountSourceTypeId"] = ExpressionConverter.ConvertO(__workflow_bodyaccountSourceTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodyindustryId != null)
                {
                    body["industryId"] = ExpressionConverter.ConvertO(__workflow_bodyindustryId);
                    bodypropCount++;
                }

                if (__workflow_bodytierId != null)
                {
                    body["tierId"] = ExpressionConverter.ConvertO(__workflow_bodytierId);
                    bodypropCount++;
                }

                if (__workflow_bodywebsite != null)
                {
                    body["website"] = ExpressionConverter.ConvertO(__workflow_bodywebsite);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountDescription != null)
                {
                    body["accountDescription"] = ExpressionConverter.ConvertO(__workflow_bodyaccountDescription);
                    bodypropCount++;
                }

                if (__workflow_bodynoOfEmployees != null)
                {
                    body["noOfEmployees"] = ExpressionConverter.ConvertO(__workflow_bodynoOfEmployees);
                    bodypropCount++;
                }

                if (__workflow_bodyannualRevenue != null)
                {
                    body["annualRevenue"] = ExpressionConverter.ConvertO(__workflow_bodyannualRevenue);
                    bodypropCount++;
                }

                if (__workflow_bodycreatedBy != null)
                {
                    body["createdBy"] = ExpressionConverter.ConvertO(__workflow_bodycreatedBy);
                    bodypropCount++;
                }

                if (__workflow_bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = ExpressionConverter.ConvertO(__workflow_bodylastModifiedBy);
                    bodypropCount++;
                }

                if (__workflow_bodyfax != null)
                {
                    body["fax"] = ExpressionConverter.ConvertO(__workflow_bodyfax);
                    bodypropCount++;
                }

                if (__workflow_bodyownershipId != null)
                {
                    body["ownershipId"] = ExpressionConverter.ConvertO(__workflow_bodyownershipId);
                    bodypropCount++;
                }

                if (__workflow_bodyratingId != null)
                {
                    body["ratingId"] = ExpressionConverter.ConvertO(__workflow_bodyratingId);
                    bodypropCount++;
                }

                if (__workflow_bodyclassificationId != null)
                {
                    body["classificationId"] = ExpressionConverter.ConvertO(__workflow_bodyclassificationId);
                    bodypropCount++;
                }

                var extraFieldsObject = new JObject();
                var extraFieldsObjectpropCount = 0;
                if (extraFieldsObjectpropCount > 0)
                {
                    body["extraFields"] = extraFieldsObject;
                    bodypropCount++;
                }

                if (__workflow_bodyassignedTeams != null)
                {
                    body["assignedTeams"] = ExpressionConverter.ConvertO(__workflow_bodyassignedTeams);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<CustomerApiFeaturesAccountsAccountDTO, ApiConnectionActionConfiguration> AccountCreate(Expression<Func<string>> bodyname, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodycompanyId = null, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodytin = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodysourceId = null, Expression<Func<string>> bodysourceParentId = null, Expression<Func<string>> bodysourceOwnerId = null, Expression<Func<string[]>> bodyprimaryContactIds = null, Expression<Func<string>> bodyparentAccountId = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string>> bodyaddressaddress1 = null, Expression<Func<string>> bodyaddressaddress2 = null, Expression<Func<string>> bodyaddresscity = null, Expression<Func<string>> bodyaddressstate = null, Expression<Func<string>> bodyaddresslatitude = null, Expression<Func<string>> bodyaddresslongtitude = null, Expression<Func<string>> bodyaddresscountry = null, Expression<Func<string>> bodyaddresscountryCode = null, Expression<Func<string>> bodyaddresspostalCode = null, Expression<Func<string>> bodyaddressfirstName = null, Expression<Func<string>> bodyaddresslastName = null, Expression<Func<string>> bodyaddressphoneNumber = null, Expression<Func<string>> bodyaddressemail = null, Expression<Func<string>> bodyupdateDate = null, Expression<Func<string>> bodyinsertDate = null, Expression<Func<string>> bodytaxOffice = null, Expression<Func<string>> bodyaccountSourceTypeId = null, Expression<Func<string>> bodyindustryId = null, Expression<Func<string>> bodytierId = null, Expression<Func<string>> bodywebsite = null, Expression<Func<string>> bodyaccountDescription = null, Expression<Func<int>> bodynoOfEmployees = null, Expression<Func<double>> bodyannualRevenue = null, Expression<Func<string>> bodycreatedBy = null, Expression<Func<string>> bodylastModifiedBy = null, Expression<Func<string>> bodyfax = null, Expression<Func<string>> bodyownershipId = null, Expression<Func<string>> bodyratingId = null, Expression<Func<string>> bodyclassificationId = null, Expression<Func<string[]>> bodyassignedTeams = null, Expression<Func<double>> bodyaiScore = null, Expression<Func<string>> bodyaiScoreReasoning = null, Expression<Func<bodyaiSentimentInput>> bodyaiSentiment = null, Expression<Func<string>> bodyaiGenerationDate = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodycompanyId = WorkflowExpression.Compile(bodycompanyId, nameof(bodycompanyId), required: false);
            var __workflow_bodycode = WorkflowExpression.Compile(bodycode, nameof(bodycode), required: false);
            var __workflow_bodytin = WorkflowExpression.Compile(bodytin, nameof(bodytin), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyphone = WorkflowExpression.Compile(bodyphone, nameof(bodyphone), required: false);
            var __workflow_bodysourceId = WorkflowExpression.Compile(bodysourceId, nameof(bodysourceId), required: false);
            var __workflow_bodysourceParentId = WorkflowExpression.Compile(bodysourceParentId, nameof(bodysourceParentId), required: false);
            var __workflow_bodysourceOwnerId = WorkflowExpression.Compile(bodysourceOwnerId, nameof(bodysourceOwnerId), required: false);
            var __workflow_bodyprimaryContactIds = WorkflowExpression.Compile(bodyprimaryContactIds, nameof(bodyprimaryContactIds), required: false);
            var __workflow_bodyparentAccountId = WorkflowExpression.Compile(bodyparentAccountId, nameof(bodyparentAccountId), required: false);
            var __workflow_bodyownerId = WorkflowExpression.Compile(bodyownerId, nameof(bodyownerId), required: false);
            var __workflow_bodyaddressaddress1 = WorkflowExpression.Compile(bodyaddressaddress1, nameof(bodyaddressaddress1), required: false);
            var __workflow_bodyaddressaddress2 = WorkflowExpression.Compile(bodyaddressaddress2, nameof(bodyaddressaddress2), required: false);
            var __workflow_bodyaddresscity = WorkflowExpression.Compile(bodyaddresscity, nameof(bodyaddresscity), required: false);
            var __workflow_bodyaddressstate = WorkflowExpression.Compile(bodyaddressstate, nameof(bodyaddressstate), required: false);
            var __workflow_bodyaddresslatitude = WorkflowExpression.Compile(bodyaddresslatitude, nameof(bodyaddresslatitude), required: false);
            var __workflow_bodyaddresslongtitude = WorkflowExpression.Compile(bodyaddresslongtitude, nameof(bodyaddresslongtitude), required: false);
            var __workflow_bodyaddresscountry = WorkflowExpression.Compile(bodyaddresscountry, nameof(bodyaddresscountry), required: false);
            var __workflow_bodyaddresscountryCode = WorkflowExpression.Compile(bodyaddresscountryCode, nameof(bodyaddresscountryCode), required: false);
            var __workflow_bodyaddresspostalCode = WorkflowExpression.Compile(bodyaddresspostalCode, nameof(bodyaddresspostalCode), required: false);
            var __workflow_bodyaddressfirstName = WorkflowExpression.Compile(bodyaddressfirstName, nameof(bodyaddressfirstName), required: false);
            var __workflow_bodyaddresslastName = WorkflowExpression.Compile(bodyaddresslastName, nameof(bodyaddresslastName), required: false);
            var __workflow_bodyaddressphoneNumber = WorkflowExpression.Compile(bodyaddressphoneNumber, nameof(bodyaddressphoneNumber), required: false);
            var __workflow_bodyaddressemail = WorkflowExpression.Compile(bodyaddressemail, nameof(bodyaddressemail), required: false);
            var __workflow_bodyupdateDate = WorkflowExpression.Compile(bodyupdateDate, nameof(bodyupdateDate), required: false);
            var __workflow_bodyinsertDate = WorkflowExpression.Compile(bodyinsertDate, nameof(bodyinsertDate), required: false);
            var __workflow_bodytaxOffice = WorkflowExpression.Compile(bodytaxOffice, nameof(bodytaxOffice), required: false);
            var __workflow_bodyaccountSourceTypeId = WorkflowExpression.Compile(bodyaccountSourceTypeId, nameof(bodyaccountSourceTypeId), required: false);
            var __workflow_bodyindustryId = WorkflowExpression.Compile(bodyindustryId, nameof(bodyindustryId), required: false);
            var __workflow_bodytierId = WorkflowExpression.Compile(bodytierId, nameof(bodytierId), required: false);
            var __workflow_bodywebsite = WorkflowExpression.Compile(bodywebsite, nameof(bodywebsite), required: false);
            var __workflow_bodyaccountDescription = WorkflowExpression.Compile(bodyaccountDescription, nameof(bodyaccountDescription), required: false);
            var __workflow_bodynoOfEmployees = WorkflowExpression.Compile(bodynoOfEmployees, nameof(bodynoOfEmployees), required: false);
            var __workflow_bodyannualRevenue = WorkflowExpression.Compile(bodyannualRevenue, nameof(bodyannualRevenue), required: false);
            var __workflow_bodycreatedBy = WorkflowExpression.Compile(bodycreatedBy, nameof(bodycreatedBy), required: false);
            var __workflow_bodylastModifiedBy = WorkflowExpression.Compile(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            var __workflow_bodyfax = WorkflowExpression.Compile(bodyfax, nameof(bodyfax), required: false);
            var __workflow_bodyownershipId = WorkflowExpression.Compile(bodyownershipId, nameof(bodyownershipId), required: false);
            var __workflow_bodyratingId = WorkflowExpression.Compile(bodyratingId, nameof(bodyratingId), required: false);
            var __workflow_bodyclassificationId = WorkflowExpression.Compile(bodyclassificationId, nameof(bodyclassificationId), required: false);
            var __workflow_bodyassignedTeams = WorkflowExpression.Compile(bodyassignedTeams, nameof(bodyassignedTeams), required: false);
            var __workflow_bodyaiScore = WorkflowExpression.Compile(bodyaiScore, nameof(bodyaiScore), required: false);
            var __workflow_bodyaiScoreReasoning = WorkflowExpression.Compile(bodyaiScoreReasoning, nameof(bodyaiScoreReasoning), required: false);
            var __workflow_bodyaiSentiment = WorkflowExpression.Compile(bodyaiSentiment, nameof(bodyaiSentiment), required: false);
            var __workflow_bodyaiGenerationDate = WorkflowExpression.Compile(bodyaiGenerationDate, nameof(bodyaiGenerationDate), required: false);
            return new DeferredBodyAction<CustomerApiFeaturesAccountsAccountDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Account";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyId != null)
                {
                    body["companyId"] = ExpressionConverter.ConvertO(__workflow_bodycompanyId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodycode != null)
                {
                    body["code"] = ExpressionConverter.ConvertO(__workflow_bodycode);
                    bodypropCount++;
                }

                if (__workflow_bodytin != null)
                {
                    body["tin"] = ExpressionConverter.ConvertO(__workflow_bodytin);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(__workflow_bodyphone);
                    bodypropCount++;
                }

                if (__workflow_bodysourceId != null)
                {
                    body["sourceId"] = ExpressionConverter.ConvertO(__workflow_bodysourceId);
                    bodypropCount++;
                }

                if (__workflow_bodysourceParentId != null)
                {
                    body["sourceParentId"] = ExpressionConverter.ConvertO(__workflow_bodysourceParentId);
                    bodypropCount++;
                }

                if (__workflow_bodysourceOwnerId != null)
                {
                    body["sourceOwnerId"] = ExpressionConverter.ConvertO(__workflow_bodysourceOwnerId);
                    bodypropCount++;
                }

                if (__workflow_bodyprimaryContactIds != null)
                {
                    body["primaryContactIds"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryContactIds);
                    bodypropCount++;
                }

                if (__workflow_bodyparentAccountId != null)
                {
                    body["parentAccountId"] = ExpressionConverter.ConvertO(__workflow_bodyparentAccountId);
                    bodypropCount++;
                }

                if (__workflow_bodyownerId != null)
                {
                    body["ownerId"] = ExpressionConverter.ConvertO(__workflow_bodyownerId);
                    bodypropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (__workflow_bodyaddressaddress1 != null)
                {
                    addressObject["address1"] = ExpressionConverter.ConvertO(__workflow_bodyaddressaddress1);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressaddress2 != null)
                {
                    addressObject["address2"] = ExpressionConverter.ConvertO(__workflow_bodyaddressaddress2);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscity != null)
                {
                    addressObject["city"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressstate != null)
                {
                    addressObject["state"] = ExpressionConverter.ConvertO(__workflow_bodyaddressstate);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresslatitude != null)
                {
                    addressObject["latitude"] = ExpressionConverter.ConvertO(__workflow_bodyaddresslatitude);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresslongtitude != null)
                {
                    addressObject["longtitude"] = ExpressionConverter.ConvertO(__workflow_bodyaddresslongtitude);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscountry != null)
                {
                    addressObject["country"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscountry);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscountryCode != null)
                {
                    addressObject["countryCode"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscountryCode);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresspostalCode != null)
                {
                    addressObject["postalCode"] = ExpressionConverter.ConvertO(__workflow_bodyaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressfirstName != null)
                {
                    addressObject["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyaddressfirstName);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresslastName != null)
                {
                    addressObject["lastName"] = ExpressionConverter.ConvertO(__workflow_bodyaddresslastName);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressphoneNumber != null)
                {
                    addressObject["phoneNumber"] = ExpressionConverter.ConvertO(__workflow_bodyaddressphoneNumber);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressemail != null)
                {
                    addressObject["email"] = ExpressionConverter.ConvertO(__workflow_bodyaddressemail);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                if (__workflow_bodyupdateDate != null)
                {
                    body["updateDate"] = ExpressionConverter.ConvertO(__workflow_bodyupdateDate);
                    bodypropCount++;
                }

                if (__workflow_bodyinsertDate != null)
                {
                    body["insertDate"] = ExpressionConverter.ConvertO(__workflow_bodyinsertDate);
                    bodypropCount++;
                }

                if (__workflow_bodytaxOffice != null)
                {
                    body["taxOffice"] = ExpressionConverter.ConvertO(__workflow_bodytaxOffice);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountSourceTypeId != null)
                {
                    body["accountSourceTypeId"] = ExpressionConverter.ConvertO(__workflow_bodyaccountSourceTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodyindustryId != null)
                {
                    body["industryId"] = ExpressionConverter.ConvertO(__workflow_bodyindustryId);
                    bodypropCount++;
                }

                if (__workflow_bodytierId != null)
                {
                    body["tierId"] = ExpressionConverter.ConvertO(__workflow_bodytierId);
                    bodypropCount++;
                }

                if (__workflow_bodywebsite != null)
                {
                    body["website"] = ExpressionConverter.ConvertO(__workflow_bodywebsite);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountDescription != null)
                {
                    body["accountDescription"] = ExpressionConverter.ConvertO(__workflow_bodyaccountDescription);
                    bodypropCount++;
                }

                if (__workflow_bodynoOfEmployees != null)
                {
                    body["noOfEmployees"] = ExpressionConverter.ConvertO(__workflow_bodynoOfEmployees);
                    bodypropCount++;
                }

                if (__workflow_bodyannualRevenue != null)
                {
                    body["annualRevenue"] = ExpressionConverter.ConvertO(__workflow_bodyannualRevenue);
                    bodypropCount++;
                }

                if (__workflow_bodycreatedBy != null)
                {
                    body["createdBy"] = ExpressionConverter.ConvertO(__workflow_bodycreatedBy);
                    bodypropCount++;
                }

                if (__workflow_bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = ExpressionConverter.ConvertO(__workflow_bodylastModifiedBy);
                    bodypropCount++;
                }

                if (__workflow_bodyfax != null)
                {
                    body["fax"] = ExpressionConverter.ConvertO(__workflow_bodyfax);
                    bodypropCount++;
                }

                if (__workflow_bodyownershipId != null)
                {
                    body["ownershipId"] = ExpressionConverter.ConvertO(__workflow_bodyownershipId);
                    bodypropCount++;
                }

                if (__workflow_bodyratingId != null)
                {
                    body["ratingId"] = ExpressionConverter.ConvertO(__workflow_bodyratingId);
                    bodypropCount++;
                }

                if (__workflow_bodyclassificationId != null)
                {
                    body["classificationId"] = ExpressionConverter.ConvertO(__workflow_bodyclassificationId);
                    bodypropCount++;
                }

                var extraFieldsObject = new JObject();
                var extraFieldsObjectpropCount = 0;
                if (extraFieldsObjectpropCount > 0)
                {
                    body["extraFields"] = extraFieldsObject;
                    bodypropCount++;
                }

                if (__workflow_bodyassignedTeams != null)
                {
                    body["assignedTeams"] = ExpressionConverter.ConvertO(__workflow_bodyassignedTeams);
                    bodypropCount++;
                }

                if (__workflow_bodyaiScore != null)
                {
                    body["aiScore"] = ExpressionConverter.ConvertO(__workflow_bodyaiScore);
                    bodypropCount++;
                }

                if (__workflow_bodyaiScoreReasoning != null)
                {
                    body["aiScoreReasoning"] = ExpressionConverter.ConvertO(__workflow_bodyaiScoreReasoning);
                    bodypropCount++;
                }

                if (__workflow_bodyaiSentiment != null)
                {
                    body["aiSentiment"] = ExpressionConverter.ConvertO(__workflow_bodyaiSentiment);
                    bodypropCount++;
                }

                if (__workflow_bodyaiGenerationDate != null)
                {
                    body["aiGenerationDate"] = ExpressionConverter.ConvertO(__workflow_bodyaiGenerationDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<CustomerApiFeaturesContactsContactDTO, ApiConnectionActionConfiguration> ContactUpdate(Expression<Func<string>> contactId, Expression<Func<string>> bodyownerId = null, Expression<Func<string[]>> bodyaccountIds = null, Expression<Func<string>> bodysourceId = null, Expression<Func<string>> bodysourceOwnerId = null, Expression<Func<string[]>> bodysourceAccountIds = null, Expression<Func<string>> bodynamefirstName = null, Expression<Func<string>> bodynamelastName = null, Expression<Func<string>> bodynamemiddleName = null, Expression<Func<string>> bodynamesalutationId = null, Expression<Func<string>> bodynamesuffix = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodymobilePhone = null, Expression<Func<string>> bodyfax = null, Expression<Func<bool>> bodycallOptOut = null, Expression<Func<bool>> bodyemailOptOut = null, Expression<Func<CustomerApiFeaturesContactsEmailDTO[]>> bodyotherEmail = null, Expression<Func<CustomerApiFeaturesContactsPhoneDTO[]>> bodyotherPhone = null, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodygenderId = null, Expression<Func<string>> bodypronounceId = null, Expression<Func<string>> bodyaddressaddress1 = null, Expression<Func<string>> bodyaddressaddress2 = null, Expression<Func<string>> bodyaddresscity = null, Expression<Func<string>> bodyaddressstate = null, Expression<Func<string>> bodyaddresslatitude = null, Expression<Func<string>> bodyaddresslongtitude = null, Expression<Func<string>> bodyaddresscountry = null, Expression<Func<string>> bodyaddresscountryCode = null, Expression<Func<string>> bodyaddresspostalCode = null, Expression<Func<string>> bodyaddressfirstName = null, Expression<Func<string>> bodyaddresslastName = null, Expression<Func<string>> bodyaddressphoneNumber = null, Expression<Func<string>> bodyaddressemail = null, Expression<Func<string>> bodycreatedBy = null, Expression<Func<string>> bodylastModifiedBy = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodyreportsTo = null, Expression<Func<string>> bodyassistant = null, Expression<Func<string>> bodyassistantPhone = null, Expression<Func<string>> bodybirthday = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodylastStayInTouchReportedDate = null, Expression<Func<string>> bodylastStayInTouchSaveDate = null, Expression<Func<string>> bodyaccountSourceTypeId = null, Expression<Func<string[]>> bodyassignedTeams = null)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            var __workflow_bodyownerId = WorkflowExpression.Compile(bodyownerId, nameof(bodyownerId), required: false);
            var __workflow_bodyaccountIds = WorkflowExpression.Compile(bodyaccountIds, nameof(bodyaccountIds), required: false);
            var __workflow_bodysourceId = WorkflowExpression.Compile(bodysourceId, nameof(bodysourceId), required: false);
            var __workflow_bodysourceOwnerId = WorkflowExpression.Compile(bodysourceOwnerId, nameof(bodysourceOwnerId), required: false);
            var __workflow_bodysourceAccountIds = WorkflowExpression.Compile(bodysourceAccountIds, nameof(bodysourceAccountIds), required: false);
            var __workflow_bodynamefirstName = WorkflowExpression.Compile(bodynamefirstName, nameof(bodynamefirstName), required: false);
            var __workflow_bodynamelastName = WorkflowExpression.Compile(bodynamelastName, nameof(bodynamelastName), required: false);
            var __workflow_bodynamemiddleName = WorkflowExpression.Compile(bodynamemiddleName, nameof(bodynamemiddleName), required: false);
            var __workflow_bodynamesalutationId = WorkflowExpression.Compile(bodynamesalutationId, nameof(bodynamesalutationId), required: false);
            var __workflow_bodynamesuffix = WorkflowExpression.Compile(bodynamesuffix, nameof(bodynamesuffix), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyphone = WorkflowExpression.Compile(bodyphone, nameof(bodyphone), required: false);
            var __workflow_bodymobilePhone = WorkflowExpression.Compile(bodymobilePhone, nameof(bodymobilePhone), required: false);
            var __workflow_bodyfax = WorkflowExpression.Compile(bodyfax, nameof(bodyfax), required: false);
            var __workflow_bodycallOptOut = WorkflowExpression.Compile(bodycallOptOut, nameof(bodycallOptOut), required: false);
            var __workflow_bodyemailOptOut = WorkflowExpression.Compile(bodyemailOptOut, nameof(bodyemailOptOut), required: false);
            var __workflow_bodyotherEmail = WorkflowExpression.Compile(bodyotherEmail, nameof(bodyotherEmail), required: false);
            var __workflow_bodyotherPhone = WorkflowExpression.Compile(bodyotherPhone, nameof(bodyotherPhone), required: false);
            var __workflow_bodyjobTitle = WorkflowExpression.Compile(bodyjobTitle, nameof(bodyjobTitle), required: false);
            var __workflow_bodygenderId = WorkflowExpression.Compile(bodygenderId, nameof(bodygenderId), required: false);
            var __workflow_bodypronounceId = WorkflowExpression.Compile(bodypronounceId, nameof(bodypronounceId), required: false);
            var __workflow_bodyaddressaddress1 = WorkflowExpression.Compile(bodyaddressaddress1, nameof(bodyaddressaddress1), required: false);
            var __workflow_bodyaddressaddress2 = WorkflowExpression.Compile(bodyaddressaddress2, nameof(bodyaddressaddress2), required: false);
            var __workflow_bodyaddresscity = WorkflowExpression.Compile(bodyaddresscity, nameof(bodyaddresscity), required: false);
            var __workflow_bodyaddressstate = WorkflowExpression.Compile(bodyaddressstate, nameof(bodyaddressstate), required: false);
            var __workflow_bodyaddresslatitude = WorkflowExpression.Compile(bodyaddresslatitude, nameof(bodyaddresslatitude), required: false);
            var __workflow_bodyaddresslongtitude = WorkflowExpression.Compile(bodyaddresslongtitude, nameof(bodyaddresslongtitude), required: false);
            var __workflow_bodyaddresscountry = WorkflowExpression.Compile(bodyaddresscountry, nameof(bodyaddresscountry), required: false);
            var __workflow_bodyaddresscountryCode = WorkflowExpression.Compile(bodyaddresscountryCode, nameof(bodyaddresscountryCode), required: false);
            var __workflow_bodyaddresspostalCode = WorkflowExpression.Compile(bodyaddresspostalCode, nameof(bodyaddresspostalCode), required: false);
            var __workflow_bodyaddressfirstName = WorkflowExpression.Compile(bodyaddressfirstName, nameof(bodyaddressfirstName), required: false);
            var __workflow_bodyaddresslastName = WorkflowExpression.Compile(bodyaddresslastName, nameof(bodyaddresslastName), required: false);
            var __workflow_bodyaddressphoneNumber = WorkflowExpression.Compile(bodyaddressphoneNumber, nameof(bodyaddressphoneNumber), required: false);
            var __workflow_bodyaddressemail = WorkflowExpression.Compile(bodyaddressemail, nameof(bodyaddressemail), required: false);
            var __workflow_bodycreatedBy = WorkflowExpression.Compile(bodycreatedBy, nameof(bodycreatedBy), required: false);
            var __workflow_bodylastModifiedBy = WorkflowExpression.Compile(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            var __workflow_bodydepartment = WorkflowExpression.Compile(bodydepartment, nameof(bodydepartment), required: false);
            var __workflow_bodyreportsTo = WorkflowExpression.Compile(bodyreportsTo, nameof(bodyreportsTo), required: false);
            var __workflow_bodyassistant = WorkflowExpression.Compile(bodyassistant, nameof(bodyassistant), required: false);
            var __workflow_bodyassistantPhone = WorkflowExpression.Compile(bodyassistantPhone, nameof(bodyassistantPhone), required: false);
            var __workflow_bodybirthday = WorkflowExpression.Compile(bodybirthday, nameof(bodybirthday), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodylastStayInTouchReportedDate = WorkflowExpression.Compile(bodylastStayInTouchReportedDate, nameof(bodylastStayInTouchReportedDate), required: false);
            var __workflow_bodylastStayInTouchSaveDate = WorkflowExpression.Compile(bodylastStayInTouchSaveDate, nameof(bodylastStayInTouchSaveDate), required: false);
            var __workflow_bodyaccountSourceTypeId = WorkflowExpression.Compile(bodyaccountSourceTypeId, nameof(bodyaccountSourceTypeId), required: false);
            var __workflow_bodyassignedTeams = WorkflowExpression.Compile(bodyassignedTeams, nameof(bodyassignedTeams), required: false);
            return new DeferredBodyAction<CustomerApiFeaturesContactsContactDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/Contact/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyownerId != null)
                {
                    body["ownerId"] = ExpressionConverter.ConvertO(__workflow_bodyownerId);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountIds != null)
                {
                    body["accountIds"] = ExpressionConverter.ConvertO(__workflow_bodyaccountIds);
                    bodypropCount++;
                }

                if (__workflow_bodysourceId != null)
                {
                    body["sourceId"] = ExpressionConverter.ConvertO(__workflow_bodysourceId);
                    bodypropCount++;
                }

                if (__workflow_bodysourceOwnerId != null)
                {
                    body["sourceOwnerId"] = ExpressionConverter.ConvertO(__workflow_bodysourceOwnerId);
                    bodypropCount++;
                }

                if (__workflow_bodysourceAccountIds != null)
                {
                    body["sourceAccountIds"] = ExpressionConverter.ConvertO(__workflow_bodysourceAccountIds);
                    bodypropCount++;
                }

                var nameObject = new JObject();
                var nameObjectpropCount = 0;
                if (__workflow_bodynamefirstName != null)
                {
                    nameObject["firstName"] = ExpressionConverter.ConvertO(__workflow_bodynamefirstName);
                    nameObjectpropCount++;
                }

                if (__workflow_bodynamelastName != null)
                {
                    nameObject["lastName"] = ExpressionConverter.ConvertO(__workflow_bodynamelastName);
                    nameObjectpropCount++;
                }

                if (__workflow_bodynamemiddleName != null)
                {
                    nameObject["middleName"] = ExpressionConverter.ConvertO(__workflow_bodynamemiddleName);
                    nameObjectpropCount++;
                }

                if (__workflow_bodynamesalutationId != null)
                {
                    nameObject["salutationId"] = ExpressionConverter.ConvertO(__workflow_bodynamesalutationId);
                    nameObjectpropCount++;
                }

                if (__workflow_bodynamesuffix != null)
                {
                    nameObject["suffix"] = ExpressionConverter.ConvertO(__workflow_bodynamesuffix);
                    nameObjectpropCount++;
                }

                if (nameObjectpropCount > 0)
                {
                    body["name"] = nameObject;
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(__workflow_bodyphone);
                    bodypropCount++;
                }

                if (__workflow_bodymobilePhone != null)
                {
                    body["mobilePhone"] = ExpressionConverter.ConvertO(__workflow_bodymobilePhone);
                    bodypropCount++;
                }

                if (__workflow_bodyfax != null)
                {
                    body["fax"] = ExpressionConverter.ConvertO(__workflow_bodyfax);
                    bodypropCount++;
                }

                if (__workflow_bodycallOptOut != null)
                {
                    body["callOptOut"] = ExpressionConverter.ConvertO(__workflow_bodycallOptOut);
                    bodypropCount++;
                }

                if (__workflow_bodyemailOptOut != null)
                {
                    body["emailOptOut"] = ExpressionConverter.ConvertO(__workflow_bodyemailOptOut);
                    bodypropCount++;
                }

                if (__workflow_bodyotherEmail != null)
                {
                    body["otherEmail"] = ExpressionConverter.ConvertO(__workflow_bodyotherEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyotherPhone != null)
                {
                    body["otherPhone"] = ExpressionConverter.ConvertO(__workflow_bodyotherPhone);
                    bodypropCount++;
                }

                if (__workflow_bodyjobTitle != null)
                {
                    body["jobTitle"] = ExpressionConverter.ConvertO(__workflow_bodyjobTitle);
                    bodypropCount++;
                }

                if (__workflow_bodygenderId != null)
                {
                    body["genderId"] = ExpressionConverter.ConvertO(__workflow_bodygenderId);
                    bodypropCount++;
                }

                if (__workflow_bodypronounceId != null)
                {
                    body["pronounceId"] = ExpressionConverter.ConvertO(__workflow_bodypronounceId);
                    bodypropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (__workflow_bodyaddressaddress1 != null)
                {
                    addressObject["address1"] = ExpressionConverter.ConvertO(__workflow_bodyaddressaddress1);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressaddress2 != null)
                {
                    addressObject["address2"] = ExpressionConverter.ConvertO(__workflow_bodyaddressaddress2);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscity != null)
                {
                    addressObject["city"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressstate != null)
                {
                    addressObject["state"] = ExpressionConverter.ConvertO(__workflow_bodyaddressstate);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresslatitude != null)
                {
                    addressObject["latitude"] = ExpressionConverter.ConvertO(__workflow_bodyaddresslatitude);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresslongtitude != null)
                {
                    addressObject["longtitude"] = ExpressionConverter.ConvertO(__workflow_bodyaddresslongtitude);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscountry != null)
                {
                    addressObject["country"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscountry);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscountryCode != null)
                {
                    addressObject["countryCode"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscountryCode);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresspostalCode != null)
                {
                    addressObject["postalCode"] = ExpressionConverter.ConvertO(__workflow_bodyaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressfirstName != null)
                {
                    addressObject["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyaddressfirstName);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresslastName != null)
                {
                    addressObject["lastName"] = ExpressionConverter.ConvertO(__workflow_bodyaddresslastName);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressphoneNumber != null)
                {
                    addressObject["phoneNumber"] = ExpressionConverter.ConvertO(__workflow_bodyaddressphoneNumber);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressemail != null)
                {
                    addressObject["email"] = ExpressionConverter.ConvertO(__workflow_bodyaddressemail);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                if (__workflow_bodycreatedBy != null)
                {
                    body["createdBy"] = ExpressionConverter.ConvertO(__workflow_bodycreatedBy);
                    bodypropCount++;
                }

                if (__workflow_bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = ExpressionConverter.ConvertO(__workflow_bodylastModifiedBy);
                    bodypropCount++;
                }

                if (__workflow_bodydepartment != null)
                {
                    body["department"] = ExpressionConverter.ConvertO(__workflow_bodydepartment);
                    bodypropCount++;
                }

                if (__workflow_bodyreportsTo != null)
                {
                    body["reportsTo"] = ExpressionConverter.ConvertO(__workflow_bodyreportsTo);
                    bodypropCount++;
                }

                if (__workflow_bodyassistant != null)
                {
                    body["assistant"] = ExpressionConverter.ConvertO(__workflow_bodyassistant);
                    bodypropCount++;
                }

                if (__workflow_bodyassistantPhone != null)
                {
                    body["assistantPhone"] = ExpressionConverter.ConvertO(__workflow_bodyassistantPhone);
                    bodypropCount++;
                }

                if (__workflow_bodybirthday != null)
                {
                    body["birthday"] = ExpressionConverter.ConvertO(__workflow_bodybirthday);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodylastStayInTouchReportedDate != null)
                {
                    body["lastStayInTouchReportedDate"] = ExpressionConverter.ConvertO(__workflow_bodylastStayInTouchReportedDate);
                    bodypropCount++;
                }

                if (__workflow_bodylastStayInTouchSaveDate != null)
                {
                    body["lastStayInTouchSaveDate"] = ExpressionConverter.ConvertO(__workflow_bodylastStayInTouchSaveDate);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountSourceTypeId != null)
                {
                    body["accountSourceTypeId"] = ExpressionConverter.ConvertO(__workflow_bodyaccountSourceTypeId);
                    bodypropCount++;
                }

                var extraFieldsObject = new JObject();
                var extraFieldsObjectpropCount = 0;
                if (extraFieldsObjectpropCount > 0)
                {
                    body["extraFields"] = extraFieldsObject;
                    bodypropCount++;
                }

                if (__workflow_bodyassignedTeams != null)
                {
                    body["assignedTeams"] = ExpressionConverter.ConvertO(__workflow_bodyassignedTeams);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<CustomerApiFeaturesContactsContactDTO, ApiConnectionActionConfiguration> ContactCreate(Expression<Func<string>> bodyid = null, Expression<Func<string>> bodycompanyId = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string[]>> bodyaccountIds = null, Expression<Func<string>> bodysourceId = null, Expression<Func<string>> bodysourceOwnerId = null, Expression<Func<string[]>> bodysourceAccountIds = null, Expression<Func<string>> bodynamefirstName = null, Expression<Func<string>> bodynamelastName = null, Expression<Func<string>> bodynamemiddleName = null, Expression<Func<string>> bodynamesalutationId = null, Expression<Func<string>> bodynamesuffix = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodymobilePhone = null, Expression<Func<string>> bodyfax = null, Expression<Func<bool>> bodycallOptOut = null, Expression<Func<bool>> bodyemailOptOut = null, Expression<Func<CustomerApiFeaturesContactsEmailDTO[]>> bodyotherEmail = null, Expression<Func<CustomerApiFeaturesContactsPhoneDTO[]>> bodyotherPhone = null, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodygenderId = null, Expression<Func<string>> bodypronounceId = null, Expression<Func<string>> bodyaddressaddress1 = null, Expression<Func<string>> bodyaddressaddress2 = null, Expression<Func<string>> bodyaddresscity = null, Expression<Func<string>> bodyaddressstate = null, Expression<Func<string>> bodyaddresslatitude = null, Expression<Func<string>> bodyaddresslongtitude = null, Expression<Func<string>> bodyaddresscountry = null, Expression<Func<string>> bodyaddresscountryCode = null, Expression<Func<string>> bodyaddresspostalCode = null, Expression<Func<string>> bodyaddressfirstName = null, Expression<Func<string>> bodyaddresslastName = null, Expression<Func<string>> bodyaddressphoneNumber = null, Expression<Func<string>> bodyaddressemail = null, Expression<Func<string>> bodyinsertDate = null, Expression<Func<string>> bodyupdateDate = null, Expression<Func<string>> bodycreatedBy = null, Expression<Func<string>> bodylastModifiedBy = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodyreportsTo = null, Expression<Func<string>> bodyassistant = null, Expression<Func<string>> bodyassistantPhone = null, Expression<Func<string>> bodybirthday = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodylastStayInTouchReportedDate = null, Expression<Func<string>> bodylastStayInTouchSaveDate = null, Expression<Func<string>> bodyaccountSourceTypeId = null, Expression<Func<string>> bodyfullName = null, Expression<Func<string[]>> bodyassignedTeams = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodycompanyId = WorkflowExpression.Compile(bodycompanyId, nameof(bodycompanyId), required: false);
            var __workflow_bodyownerId = WorkflowExpression.Compile(bodyownerId, nameof(bodyownerId), required: false);
            var __workflow_bodyaccountIds = WorkflowExpression.Compile(bodyaccountIds, nameof(bodyaccountIds), required: false);
            var __workflow_bodysourceId = WorkflowExpression.Compile(bodysourceId, nameof(bodysourceId), required: false);
            var __workflow_bodysourceOwnerId = WorkflowExpression.Compile(bodysourceOwnerId, nameof(bodysourceOwnerId), required: false);
            var __workflow_bodysourceAccountIds = WorkflowExpression.Compile(bodysourceAccountIds, nameof(bodysourceAccountIds), required: false);
            var __workflow_bodynamefirstName = WorkflowExpression.Compile(bodynamefirstName, nameof(bodynamefirstName), required: false);
            var __workflow_bodynamelastName = WorkflowExpression.Compile(bodynamelastName, nameof(bodynamelastName), required: false);
            var __workflow_bodynamemiddleName = WorkflowExpression.Compile(bodynamemiddleName, nameof(bodynamemiddleName), required: false);
            var __workflow_bodynamesalutationId = WorkflowExpression.Compile(bodynamesalutationId, nameof(bodynamesalutationId), required: false);
            var __workflow_bodynamesuffix = WorkflowExpression.Compile(bodynamesuffix, nameof(bodynamesuffix), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyphone = WorkflowExpression.Compile(bodyphone, nameof(bodyphone), required: false);
            var __workflow_bodymobilePhone = WorkflowExpression.Compile(bodymobilePhone, nameof(bodymobilePhone), required: false);
            var __workflow_bodyfax = WorkflowExpression.Compile(bodyfax, nameof(bodyfax), required: false);
            var __workflow_bodycallOptOut = WorkflowExpression.Compile(bodycallOptOut, nameof(bodycallOptOut), required: false);
            var __workflow_bodyemailOptOut = WorkflowExpression.Compile(bodyemailOptOut, nameof(bodyemailOptOut), required: false);
            var __workflow_bodyotherEmail = WorkflowExpression.Compile(bodyotherEmail, nameof(bodyotherEmail), required: false);
            var __workflow_bodyotherPhone = WorkflowExpression.Compile(bodyotherPhone, nameof(bodyotherPhone), required: false);
            var __workflow_bodyjobTitle = WorkflowExpression.Compile(bodyjobTitle, nameof(bodyjobTitle), required: false);
            var __workflow_bodygenderId = WorkflowExpression.Compile(bodygenderId, nameof(bodygenderId), required: false);
            var __workflow_bodypronounceId = WorkflowExpression.Compile(bodypronounceId, nameof(bodypronounceId), required: false);
            var __workflow_bodyaddressaddress1 = WorkflowExpression.Compile(bodyaddressaddress1, nameof(bodyaddressaddress1), required: false);
            var __workflow_bodyaddressaddress2 = WorkflowExpression.Compile(bodyaddressaddress2, nameof(bodyaddressaddress2), required: false);
            var __workflow_bodyaddresscity = WorkflowExpression.Compile(bodyaddresscity, nameof(bodyaddresscity), required: false);
            var __workflow_bodyaddressstate = WorkflowExpression.Compile(bodyaddressstate, nameof(bodyaddressstate), required: false);
            var __workflow_bodyaddresslatitude = WorkflowExpression.Compile(bodyaddresslatitude, nameof(bodyaddresslatitude), required: false);
            var __workflow_bodyaddresslongtitude = WorkflowExpression.Compile(bodyaddresslongtitude, nameof(bodyaddresslongtitude), required: false);
            var __workflow_bodyaddresscountry = WorkflowExpression.Compile(bodyaddresscountry, nameof(bodyaddresscountry), required: false);
            var __workflow_bodyaddresscountryCode = WorkflowExpression.Compile(bodyaddresscountryCode, nameof(bodyaddresscountryCode), required: false);
            var __workflow_bodyaddresspostalCode = WorkflowExpression.Compile(bodyaddresspostalCode, nameof(bodyaddresspostalCode), required: false);
            var __workflow_bodyaddressfirstName = WorkflowExpression.Compile(bodyaddressfirstName, nameof(bodyaddressfirstName), required: false);
            var __workflow_bodyaddresslastName = WorkflowExpression.Compile(bodyaddresslastName, nameof(bodyaddresslastName), required: false);
            var __workflow_bodyaddressphoneNumber = WorkflowExpression.Compile(bodyaddressphoneNumber, nameof(bodyaddressphoneNumber), required: false);
            var __workflow_bodyaddressemail = WorkflowExpression.Compile(bodyaddressemail, nameof(bodyaddressemail), required: false);
            var __workflow_bodyinsertDate = WorkflowExpression.Compile(bodyinsertDate, nameof(bodyinsertDate), required: false);
            var __workflow_bodyupdateDate = WorkflowExpression.Compile(bodyupdateDate, nameof(bodyupdateDate), required: false);
            var __workflow_bodycreatedBy = WorkflowExpression.Compile(bodycreatedBy, nameof(bodycreatedBy), required: false);
            var __workflow_bodylastModifiedBy = WorkflowExpression.Compile(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            var __workflow_bodydepartment = WorkflowExpression.Compile(bodydepartment, nameof(bodydepartment), required: false);
            var __workflow_bodyreportsTo = WorkflowExpression.Compile(bodyreportsTo, nameof(bodyreportsTo), required: false);
            var __workflow_bodyassistant = WorkflowExpression.Compile(bodyassistant, nameof(bodyassistant), required: false);
            var __workflow_bodyassistantPhone = WorkflowExpression.Compile(bodyassistantPhone, nameof(bodyassistantPhone), required: false);
            var __workflow_bodybirthday = WorkflowExpression.Compile(bodybirthday, nameof(bodybirthday), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodylastStayInTouchReportedDate = WorkflowExpression.Compile(bodylastStayInTouchReportedDate, nameof(bodylastStayInTouchReportedDate), required: false);
            var __workflow_bodylastStayInTouchSaveDate = WorkflowExpression.Compile(bodylastStayInTouchSaveDate, nameof(bodylastStayInTouchSaveDate), required: false);
            var __workflow_bodyaccountSourceTypeId = WorkflowExpression.Compile(bodyaccountSourceTypeId, nameof(bodyaccountSourceTypeId), required: false);
            var __workflow_bodyfullName = WorkflowExpression.Compile(bodyfullName, nameof(bodyfullName), required: false);
            var __workflow_bodyassignedTeams = WorkflowExpression.Compile(bodyassignedTeams, nameof(bodyassignedTeams), required: false);
            return new DeferredBodyAction<CustomerApiFeaturesContactsContactDTO, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyId != null)
                {
                    body["companyId"] = ExpressionConverter.ConvertO(__workflow_bodycompanyId);
                    bodypropCount++;
                }

                if (__workflow_bodyownerId != null)
                {
                    body["ownerId"] = ExpressionConverter.ConvertO(__workflow_bodyownerId);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountIds != null)
                {
                    body["accountIds"] = ExpressionConverter.ConvertO(__workflow_bodyaccountIds);
                    bodypropCount++;
                }

                if (__workflow_bodysourceId != null)
                {
                    body["sourceId"] = ExpressionConverter.ConvertO(__workflow_bodysourceId);
                    bodypropCount++;
                }

                if (__workflow_bodysourceOwnerId != null)
                {
                    body["sourceOwnerId"] = ExpressionConverter.ConvertO(__workflow_bodysourceOwnerId);
                    bodypropCount++;
                }

                if (__workflow_bodysourceAccountIds != null)
                {
                    body["sourceAccountIds"] = ExpressionConverter.ConvertO(__workflow_bodysourceAccountIds);
                    bodypropCount++;
                }

                var nameObject = new JObject();
                var nameObjectpropCount = 0;
                if (__workflow_bodynamefirstName != null)
                {
                    nameObject["firstName"] = ExpressionConverter.ConvertO(__workflow_bodynamefirstName);
                    nameObjectpropCount++;
                }

                if (__workflow_bodynamelastName != null)
                {
                    nameObject["lastName"] = ExpressionConverter.ConvertO(__workflow_bodynamelastName);
                    nameObjectpropCount++;
                }

                if (__workflow_bodynamemiddleName != null)
                {
                    nameObject["middleName"] = ExpressionConverter.ConvertO(__workflow_bodynamemiddleName);
                    nameObjectpropCount++;
                }

                if (__workflow_bodynamesalutationId != null)
                {
                    nameObject["salutationId"] = ExpressionConverter.ConvertO(__workflow_bodynamesalutationId);
                    nameObjectpropCount++;
                }

                if (__workflow_bodynamesuffix != null)
                {
                    nameObject["suffix"] = ExpressionConverter.ConvertO(__workflow_bodynamesuffix);
                    nameObjectpropCount++;
                }

                if (nameObjectpropCount > 0)
                {
                    body["name"] = nameObject;
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(__workflow_bodyphone);
                    bodypropCount++;
                }

                if (__workflow_bodymobilePhone != null)
                {
                    body["mobilePhone"] = ExpressionConverter.ConvertO(__workflow_bodymobilePhone);
                    bodypropCount++;
                }

                if (__workflow_bodyfax != null)
                {
                    body["fax"] = ExpressionConverter.ConvertO(__workflow_bodyfax);
                    bodypropCount++;
                }

                if (__workflow_bodycallOptOut != null)
                {
                    body["callOptOut"] = ExpressionConverter.ConvertO(__workflow_bodycallOptOut);
                    bodypropCount++;
                }

                if (__workflow_bodyemailOptOut != null)
                {
                    body["emailOptOut"] = ExpressionConverter.ConvertO(__workflow_bodyemailOptOut);
                    bodypropCount++;
                }

                if (__workflow_bodyotherEmail != null)
                {
                    body["otherEmail"] = ExpressionConverter.ConvertO(__workflow_bodyotherEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyotherPhone != null)
                {
                    body["otherPhone"] = ExpressionConverter.ConvertO(__workflow_bodyotherPhone);
                    bodypropCount++;
                }

                if (__workflow_bodyjobTitle != null)
                {
                    body["jobTitle"] = ExpressionConverter.ConvertO(__workflow_bodyjobTitle);
                    bodypropCount++;
                }

                if (__workflow_bodygenderId != null)
                {
                    body["genderId"] = ExpressionConverter.ConvertO(__workflow_bodygenderId);
                    bodypropCount++;
                }

                if (__workflow_bodypronounceId != null)
                {
                    body["pronounceId"] = ExpressionConverter.ConvertO(__workflow_bodypronounceId);
                    bodypropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (__workflow_bodyaddressaddress1 != null)
                {
                    addressObject["address1"] = ExpressionConverter.ConvertO(__workflow_bodyaddressaddress1);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressaddress2 != null)
                {
                    addressObject["address2"] = ExpressionConverter.ConvertO(__workflow_bodyaddressaddress2);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscity != null)
                {
                    addressObject["city"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressstate != null)
                {
                    addressObject["state"] = ExpressionConverter.ConvertO(__workflow_bodyaddressstate);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresslatitude != null)
                {
                    addressObject["latitude"] = ExpressionConverter.ConvertO(__workflow_bodyaddresslatitude);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresslongtitude != null)
                {
                    addressObject["longtitude"] = ExpressionConverter.ConvertO(__workflow_bodyaddresslongtitude);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscountry != null)
                {
                    addressObject["country"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscountry);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresscountryCode != null)
                {
                    addressObject["countryCode"] = ExpressionConverter.ConvertO(__workflow_bodyaddresscountryCode);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresspostalCode != null)
                {
                    addressObject["postalCode"] = ExpressionConverter.ConvertO(__workflow_bodyaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressfirstName != null)
                {
                    addressObject["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyaddressfirstName);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddresslastName != null)
                {
                    addressObject["lastName"] = ExpressionConverter.ConvertO(__workflow_bodyaddresslastName);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressphoneNumber != null)
                {
                    addressObject["phoneNumber"] = ExpressionConverter.ConvertO(__workflow_bodyaddressphoneNumber);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyaddressemail != null)
                {
                    addressObject["email"] = ExpressionConverter.ConvertO(__workflow_bodyaddressemail);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                if (__workflow_bodyinsertDate != null)
                {
                    body["insertDate"] = ExpressionConverter.ConvertO(__workflow_bodyinsertDate);
                    bodypropCount++;
                }

                if (__workflow_bodyupdateDate != null)
                {
                    body["updateDate"] = ExpressionConverter.ConvertO(__workflow_bodyupdateDate);
                    bodypropCount++;
                }

                if (__workflow_bodycreatedBy != null)
                {
                    body["createdBy"] = ExpressionConverter.ConvertO(__workflow_bodycreatedBy);
                    bodypropCount++;
                }

                if (__workflow_bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = ExpressionConverter.ConvertO(__workflow_bodylastModifiedBy);
                    bodypropCount++;
                }

                if (__workflow_bodydepartment != null)
                {
                    body["department"] = ExpressionConverter.ConvertO(__workflow_bodydepartment);
                    bodypropCount++;
                }

                if (__workflow_bodyreportsTo != null)
                {
                    body["reportsTo"] = ExpressionConverter.ConvertO(__workflow_bodyreportsTo);
                    bodypropCount++;
                }

                if (__workflow_bodyassistant != null)
                {
                    body["assistant"] = ExpressionConverter.ConvertO(__workflow_bodyassistant);
                    bodypropCount++;
                }

                if (__workflow_bodyassistantPhone != null)
                {
                    body["assistantPhone"] = ExpressionConverter.ConvertO(__workflow_bodyassistantPhone);
                    bodypropCount++;
                }

                if (__workflow_bodybirthday != null)
                {
                    body["birthday"] = ExpressionConverter.ConvertO(__workflow_bodybirthday);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodylastStayInTouchReportedDate != null)
                {
                    body["lastStayInTouchReportedDate"] = ExpressionConverter.ConvertO(__workflow_bodylastStayInTouchReportedDate);
                    bodypropCount++;
                }

                if (__workflow_bodylastStayInTouchSaveDate != null)
                {
                    body["lastStayInTouchSaveDate"] = ExpressionConverter.ConvertO(__workflow_bodylastStayInTouchSaveDate);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountSourceTypeId != null)
                {
                    body["accountSourceTypeId"] = ExpressionConverter.ConvertO(__workflow_bodyaccountSourceTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodyfullName != null)
                {
                    body["fullName"] = ExpressionConverter.ConvertO(__workflow_bodyfullName);
                    bodypropCount++;
                }

                var extraFieldsObject = new JObject();
                var extraFieldsObjectpropCount = 0;
                if (extraFieldsObjectpropCount > 0)
                {
                    body["extraFields"] = extraFieldsObject;
                    bodypropCount++;
                }

                if (__workflow_bodyassignedTeams != null)
                {
                    body["assignedTeams"] = ExpressionConverter.ConvertO(__workflow_bodyassignedTeams);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CustomerApiFeaturesContactsContactDTO>(callPayload);
            });
        }
    }

    public class SoftonewebcrmTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CallCreated(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/call/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> OpportunityUpdated(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/opportunity/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> OpportunityDeleted(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/opportunity/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> OpportunityCreated(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/opportunity/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> LeadUpdated(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/lead/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> LeadDeleted(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/lead/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> LeadCreated(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/lead/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TaskUpdated(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/task/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TaskDeleted(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/task/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TaskCreated(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/task/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> EventUpdated(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/event/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> EventDeleted(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/event/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> EventCreated(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/event/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CallDeleted(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/call/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CallUpdated(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/WebHook/register/call/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
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
        public TaskApiModelsEnumsTaskType TaskType { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("assignedToType")]
        public TaskApiModelsEnumsAssignedToType AssignedToType { get; set; }

        [JsonProperty("assignedToId")]
        public string AssignedToId { get; set; }

        [JsonProperty("relatedToType")]
        public TaskApiModelsEnumsRelatedToType RelatedToType { get; set; }

        [JsonProperty("relatedToId")]
        public string RelatedToId { get; set; }

        [JsonProperty("contactType")]
        public TaskApiModelsEnumsContactType ContactType { get; set; }

        [JsonProperty("contactIds")]
        public string[] ContactIds { get; set; }

        [JsonProperty("status")]
        public TaskApiModelsEnumsStatus Status { get; set; }

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
        public TaskApiModelsEnumsCallDirection CallDirection { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TaskApiModelsEnumsTaskType
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
    public enum TaskApiModelsEnumsAssignedToType
    {
        People,
        Queues
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TaskApiModelsEnumsRelatedToType
    {
        Account,
        Opportunity,
        Quote
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TaskApiModelsEnumsContactType
    {
        Lead,
        Contact
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TaskApiModelsEnumsStatus
    {
        Open,
        Completed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TaskApiModelsEnumsCallDirection
    {
        Unknown,
        Inbound,
        Outbound
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum statusInput
    {
        Open,
        Completed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyassignedToTypeInput
    {
        People,
        Queues
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyrelatedToTypeInput
    {
        Account,
        Opportunity,
        Quote
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycontactTypeInput
    {
        Lead,
        Contact
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodystatusInput
    {
        Open,
        Won,
        Lost,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycallDirectionInput
    {
        Unknown,
        Inbound,
        Outbound
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytaskTypeInput
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
        public TaskApiModelsEnumsTaskType TaskType { get; set; }

        [JsonProperty("assignedToType")]
        public TaskApiModelsEnumsAssignedToType AssignedToType { get; set; }

        [JsonProperty("assignedToId")]
        public string AssignedToId { get; set; }

        [JsonProperty("relatedToType")]
        public TaskApiModelsEnumsRelatedToType RelatedToType { get; set; }

        [JsonProperty("relatedToId")]
        public string RelatedToId { get; set; }

        [JsonProperty("contactType")]
        public TaskApiModelsEnumsContactType ContactType { get; set; }

        [JsonProperty("contactIds")]
        public string[] ContactIds { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("editorBody")]
        public string EditorBody { get; set; }

        [JsonProperty("priorityId")]
        public string PriorityId { get; set; }

        [JsonProperty("location")]
        public TaskApiFeaturesEventsLocationDTO Location { get; set; }

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
        public TaskApiModelsEnumsEventStatus EventStatus { get; set; }

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

    public class TaskApiFeaturesEventsLocationDTO
    {
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TaskApiModelsEnumsEventStatus
    {
        Scheduled,
        Completed,
        Rescheduled,
        Canceled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum eventStatusInput
    {
        Scheduled,
        Completed,
        Rescheduled,
        Canceled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyeventStatusInput
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
        public TaskApiModelsEnumsRelatedToType RelatedToType { get; set; }

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
        public TaskApiModelsEnumsContactType ContactType { get; set; }

        [JsonProperty("taskType")]
        public TaskApiModelsEnumsTaskType TaskType { get; set; }

        [JsonProperty("sortDate")]
        public string SortDate { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum relatedToTypeInput
    {
        Account,
        Opportunity,
        Quote
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
        public TaskApiModelsEnumsTaskType TaskType { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("completedDate")]
        public string CompletedDate { get; set; }

        [JsonProperty("status")]
        public TaskApiModelsEnumsStatus Status { get; set; }

        [JsonProperty("priorityId")]
        public string PriorityId { get; set; }

        [JsonProperty("assignedToId")]
        public string AssignedToId { get; set; }

        [JsonProperty("assignedToType")]
        public TaskApiModelsEnumsAssignedToType AssignedToType { get; set; }

        [JsonProperty("contactIds")]
        public string[] ContactIds { get; set; }

        [JsonProperty("contactType")]
        public TaskApiModelsEnumsContactType ContactType { get; set; }

        [JsonProperty("relatedToId")]
        public string RelatedToId { get; set; }

        [JsonProperty("relatedToType")]
        public TaskApiModelsEnumsRelatedToType RelatedToType { get; set; }

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
    public enum typeInput
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
        public SalesPipelineApiDTOsNameDTO Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("otherEmail")]
        public SalesPipelineApiDTOsEmailDTO[] OtherEmail { get; set; }

        [JsonProperty("otherPhone")]
        public SalesPipelineApiDTOsPhoneDTO[] OtherPhone { get; set; }

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
        public SalesPipelineApiModelsEnumsOwnerType OwnerType { get; set; }

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
        public SalesPipelineApiDTOsAddressDto Address { get; set; }

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
        public SalesPipelineApiModelsEnumsStatus Status { get; set; }

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

    public class SalesPipelineApiDTOsNameDTO
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

    public class SalesPipelineApiDTOsEmailDTO
    {
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("type")]
        public SalesPipelineApiModelsEnumsEmailType Type { get; set; }

        [JsonProperty("optOut")]
        public bool OptOut { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SalesPipelineApiModelsEnumsEmailType
    {
        Work,
        Home,
        Other,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    public class SalesPipelineApiDTOsPhoneDTO
    {
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("type")]
        public SalesPipelineApiModelsEnumsPhoneType Type { get; set; }

        [JsonProperty("optOut")]
        public bool OptOut { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SalesPipelineApiModelsEnumsPhoneType
    {
        Work,
        Home,
        Other,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SalesPipelineApiModelsEnumsOwnerType
    {
        People,
        Queues
    }

    public class SalesPipelineApiDTOsAddressDto
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
    public enum SalesPipelineApiModelsEnumsStatus
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
    public enum ownerTypeInput
    {
        People,
        Queues
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyownerTypeInput
    {
        People,
        Queues
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
        public SalesPipelineApiModelsEnumsOpportunityStatus Status { get; set; }

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
    public enum SalesPipelineApiModelsEnumsOpportunityStatus
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
        public CustomerApiDTOsAddressDTO Address { get; set; }

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

    public class CustomerApiDTOsAddressDTO
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CustomerApiFeaturesAccountsAccountDTOAiSentimentType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyaiSentimentInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4
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
        public CustomerApiFeaturesContactsNameDTO Name { get; set; }

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
        public CustomerApiFeaturesContactsEmailDTO[] OtherEmail { get; set; }

        [JsonProperty("otherPhone")]
        public CustomerApiFeaturesContactsPhoneDTO[] OtherPhone { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("genderId")]
        public string GenderId { get; set; }

        [JsonProperty("pronounceId")]
        public string PronounceId { get; set; }

        [JsonProperty("address")]
        public CustomerApiDTOsAddressDTO Address { get; set; }

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

    public class CustomerApiFeaturesContactsNameDTO
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

    public class CustomerApiFeaturesContactsEmailDTO
    {
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("type")]
        public CustomerApiFeaturesContactsEmailDTOTypeType Type { get; set; }

        [JsonProperty("optOut")]
        public bool OptOut { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CustomerApiFeaturesContactsEmailDTOTypeType
    {
        Work,
        Home,
        Other,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    public class CustomerApiFeaturesContactsPhoneDTO
    {
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("type")]
        public CustomerApiFeaturesContactsPhoneDTOTypeType Type { get; set; }

        [JsonProperty("optOut")]
        public bool OptOut { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CustomerApiFeaturesContactsPhoneDTOTypeType
    {
        Work,
        Home,
        Other,
        [EnumMember(Value = "ignore")]
        Ignore
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
