//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Softonewebcrm
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SoftonewebcrmActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [WorkflowExpressionFactory(nameof(__BuildCallGetAll))]
        public IBodyWorkflowAction<TaskApiFeaturesCallsCallDTO[]> CallGetAll([WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<string> priorityId = null, [WorkflowExpression] Func<string> createdBy = null, [WorkflowExpression] Func<string> lastModifiedBy = null, [WorkflowExpression] Func<string> dueDate = null, [WorkflowExpression] Func<string> sortDate = null, [WorkflowExpression] Func<string> assignedToId = null, [WorkflowExpression] Func<string> relatedToId = null, [WorkflowExpression] Func<string> callResultId = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskApiFeaturesCallsCallDTO[]> __BuildCallGetAll(WorkflowExpression<string> id = null, WorkflowExpression<statusInput> status = null, WorkflowExpression<string> priorityId = null, WorkflowExpression<string> createdBy = null, WorkflowExpression<string> lastModifiedBy = null, WorkflowExpression<string> dueDate = null, WorkflowExpression<string> sortDate = null, WorkflowExpression<string> assignedToId = null, WorkflowExpression<string> relatedToId = null, WorkflowExpression<string> callResultId = null, WorkflowExpression<string> search = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sort = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            WorkflowExpression.Validate(priorityId, nameof(priorityId), required: false);
            WorkflowExpression.Validate(createdBy, nameof(createdBy), required: false);
            WorkflowExpression.Validate(lastModifiedBy, nameof(lastModifiedBy), required: false);
            WorkflowExpression.Validate(dueDate, nameof(dueDate), required: false);
            WorkflowExpression.Validate(sortDate, nameof(sortDate), required: false);
            WorkflowExpression.Validate(assignedToId, nameof(assignedToId), required: false);
            WorkflowExpression.Validate(relatedToId, nameof(relatedToId), required: false);
            WorkflowExpression.Validate(callResultId, nameof(callResultId), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<TaskApiFeaturesCallsCallDTO[]>(() =>
            {
                var apiCallPath = "/api/task/Call";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
                if (status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(status);
                if (priorityId != null)
                    callPayload.Queries["PriorityId"] = ExpressionConverter.Convert(priorityId);
                if (createdBy != null)
                    callPayload.Queries["CreatedBy"] = ExpressionConverter.Convert(createdBy);
                if (lastModifiedBy != null)
                    callPayload.Queries["LastModifiedBy"] = ExpressionConverter.Convert(lastModifiedBy);
                if (dueDate != null)
                    callPayload.Queries["DueDate"] = ExpressionConverter.Convert(dueDate);
                if (sortDate != null)
                    callPayload.Queries["SortDate"] = ExpressionConverter.Convert(sortDate);
                if (assignedToId != null)
                    callPayload.Queries["AssignedToId"] = ExpressionConverter.Convert(assignedToId);
                if (relatedToId != null)
                    callPayload.Queries["RelatedToId"] = ExpressionConverter.Convert(relatedToId);
                if (callResultId != null)
                    callPayload.Queries["CallResultId"] = ExpressionConverter.Convert(callResultId);
                if (search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(search);
                if (page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(sort);
                return new ApiConnectionAction<TaskApiFeaturesCallsCallDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [WorkflowExpressionFactory(nameof(__BuildCallCreate))]
        public IBodyWorkflowAction<TaskApiFeaturesCallsCallDTO> CallCreate([WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<bodyassignedToTypeInput> bodyassignedToType = null, [WorkflowExpression] Func<string> bodyassignedToId = null, [WorkflowExpression] Func<bodyrelatedToTypeInput> bodyrelatedToType = null, [WorkflowExpression] Func<string> bodyrelatedToId = null, [WorkflowExpression] Func<bodycontactTypeInput> bodycontactType = null, [WorkflowExpression] Func<string[]> bodycontactIds = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodycallDuration = null, [WorkflowExpression] Func<string> bodycallResultId = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodyeditorBody = null, [WorkflowExpression] Func<string> bodypriorityId = null, [WorkflowExpression] Func<int> bodyposition = null, [WorkflowExpression] Func<string> bodyparentId = null, [WorkflowExpression] Func<bool> bodyreminderSet = null, [WorkflowExpression] Func<string> bodysortDate = null, [WorkflowExpression] Func<string> bodysourceId = null, [WorkflowExpression] Func<string> bodysourceAssignedToId = null, [WorkflowExpression] Func<string> bodysourceRelatedToId = null, [WorkflowExpression] Func<string[]> bodysourceContactIds = null, [WorkflowExpression] Func<bodycallDirectionInput> bodycallDirection = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskApiFeaturesCallsCallDTO> __BuildCallCreate(WorkflowExpression<string> bodydueDate = null, WorkflowExpression<string> bodysubject = null, WorkflowExpression<bodyassignedToTypeInput> bodyassignedToType = null, WorkflowExpression<string> bodyassignedToId = null, WorkflowExpression<bodyrelatedToTypeInput> bodyrelatedToType = null, WorkflowExpression<string> bodyrelatedToId = null, WorkflowExpression<bodycontactTypeInput> bodycontactType = null, WorkflowExpression<string[]> bodycontactIds = null, WorkflowExpression<bodystatusInput> bodystatus = null, WorkflowExpression<string> bodycallDuration = null, WorkflowExpression<string> bodycallResultId = null, WorkflowExpression<string> bodycomments = null, WorkflowExpression<string> bodyeditorBody = null, WorkflowExpression<string> bodypriorityId = null, WorkflowExpression<int> bodyposition = null, WorkflowExpression<string> bodyparentId = null, WorkflowExpression<bool> bodyreminderSet = null, WorkflowExpression<string> bodysortDate = null, WorkflowExpression<string> bodysourceId = null, WorkflowExpression<string> bodysourceAssignedToId = null, WorkflowExpression<string> bodysourceRelatedToId = null, WorkflowExpression<string[]> bodysourceContactIds = null, WorkflowExpression<bodycallDirectionInput> bodycallDirection = null)
        {
            WorkflowExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            WorkflowExpression.Validate(bodyassignedToType, nameof(bodyassignedToType), required: false);
            WorkflowExpression.Validate(bodyassignedToId, nameof(bodyassignedToId), required: false);
            WorkflowExpression.Validate(bodyrelatedToType, nameof(bodyrelatedToType), required: false);
            WorkflowExpression.Validate(bodyrelatedToId, nameof(bodyrelatedToId), required: false);
            WorkflowExpression.Validate(bodycontactType, nameof(bodycontactType), required: false);
            WorkflowExpression.Validate(bodycontactIds, nameof(bodycontactIds), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodycallDuration, nameof(bodycallDuration), required: false);
            WorkflowExpression.Validate(bodycallResultId, nameof(bodycallResultId), required: false);
            WorkflowExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            WorkflowExpression.Validate(bodyeditorBody, nameof(bodyeditorBody), required: false);
            WorkflowExpression.Validate(bodypriorityId, nameof(bodypriorityId), required: false);
            WorkflowExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            WorkflowExpression.Validate(bodyparentId, nameof(bodyparentId), required: false);
            WorkflowExpression.Validate(bodyreminderSet, nameof(bodyreminderSet), required: false);
            WorkflowExpression.Validate(bodysortDate, nameof(bodysortDate), required: false);
            WorkflowExpression.Validate(bodysourceId, nameof(bodysourceId), required: false);
            WorkflowExpression.Validate(bodysourceAssignedToId, nameof(bodysourceAssignedToId), required: false);
            WorkflowExpression.Validate(bodysourceRelatedToId, nameof(bodysourceRelatedToId), required: false);
            WorkflowExpression.Validate(bodysourceContactIds, nameof(bodysourceContactIds), required: false);
            WorkflowExpression.Validate(bodycallDirection, nameof(bodycallDirection), required: false);
            return new DeferredBodyAction<TaskApiFeaturesCallsCallDTO>(() =>
            {
                var apiCallPath = "/api/task/Call";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(bodydueDate);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                    bodypropCount++;
                }

                if (bodyassignedToType != null)
                {
                    body["assignedToType"] = ExpressionConverter.ConvertO(bodyassignedToType);
                    bodypropCount++;
                }

                if (bodyassignedToId != null)
                {
                    body["assignedToId"] = ExpressionConverter.ConvertO(bodyassignedToId);
                    bodypropCount++;
                }

                if (bodyrelatedToType != null)
                {
                    body["relatedToType"] = ExpressionConverter.ConvertO(bodyrelatedToType);
                    bodypropCount++;
                }

                if (bodyrelatedToId != null)
                {
                    body["relatedToId"] = ExpressionConverter.ConvertO(bodyrelatedToId);
                    bodypropCount++;
                }

                if (bodycontactType != null)
                {
                    body["contactType"] = ExpressionConverter.ConvertO(bodycontactType);
                    bodypropCount++;
                }

                if (bodycontactIds != null)
                {
                    body["contactIds"] = ExpressionConverter.ConvertO(bodycontactIds);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodycallDuration != null)
                {
                    body["callDuration"] = ExpressionConverter.ConvertO(bodycallDuration);
                    bodypropCount++;
                }

                if (bodycallResultId != null)
                {
                    body["callResultId"] = ExpressionConverter.ConvertO(bodycallResultId);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(bodycomments);
                    bodypropCount++;
                }

                if (bodyeditorBody != null)
                {
                    body["editorBody"] = ExpressionConverter.ConvertO(bodyeditorBody);
                    bodypropCount++;
                }

                if (bodypriorityId != null)
                {
                    body["priorityId"] = ExpressionConverter.ConvertO(bodypriorityId);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(bodyposition);
                    bodypropCount++;
                }

                if (bodyparentId != null)
                {
                    body["parentId"] = ExpressionConverter.ConvertO(bodyparentId);
                    bodypropCount++;
                }

                if (bodyreminderSet != null)
                {
                    body["reminderSet"] = ExpressionConverter.ConvertO(bodyreminderSet);
                    bodypropCount++;
                }

                if (bodysortDate != null)
                {
                    body["sortDate"] = ExpressionConverter.ConvertO(bodysortDate);
                    bodypropCount++;
                }

                if (bodysourceId != null)
                {
                    body["sourceId"] = ExpressionConverter.ConvertO(bodysourceId);
                    bodypropCount++;
                }

                if (bodysourceAssignedToId != null)
                {
                    body["sourceAssignedToId"] = ExpressionConverter.ConvertO(bodysourceAssignedToId);
                    bodypropCount++;
                }

                if (bodysourceRelatedToId != null)
                {
                    body["sourceRelatedToId"] = ExpressionConverter.ConvertO(bodysourceRelatedToId);
                    bodypropCount++;
                }

                if (bodysourceContactIds != null)
                {
                    body["sourceContactIds"] = ExpressionConverter.ConvertO(bodysourceContactIds);
                    bodypropCount++;
                }

                if (bodycallDirection != null)
                {
                    body["callDirection"] = ExpressionConverter.ConvertO(bodycallDirection);
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
        [WorkflowExpressionFactory(nameof(__BuildCallGetById))]
        public IBodyWorkflowAction<TaskApiFeaturesCallsCallDTO> CallGetById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskApiFeaturesCallsCallDTO> __BuildCallGetById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<TaskApiFeaturesCallsCallDTO>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/task/Call/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskApiFeaturesCallsCallDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [WorkflowExpressionFactory(nameof(__BuildCallDelete))]
        public IWorkflowAction CallDelete([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCallDelete(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/task/Call/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [WorkflowExpressionFactory(nameof(__BuildCallUpdate))]
        public IBodyWorkflowAction<TaskApiFeaturesCallsCallDTO> CallUpdate([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bodytaskTypeInput> bodytaskType = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<bodyassignedToTypeInput> bodyassignedToType = null, [WorkflowExpression] Func<string> bodyassignedToId = null, [WorkflowExpression] Func<bodyrelatedToTypeInput> bodyrelatedToType = null, [WorkflowExpression] Func<string> bodyrelatedToId = null, [WorkflowExpression] Func<bodycontactTypeInput> bodycontactType = null, [WorkflowExpression] Func<string[]> bodycontactIds = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodycallDuration = null, [WorkflowExpression] Func<string> bodycallResultId = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodyeditorBody = null, [WorkflowExpression] Func<string> bodypriorityId = null, [WorkflowExpression] Func<int> bodyposition = null, [WorkflowExpression] Func<string> bodyparentId = null, [WorkflowExpression] Func<bool> bodyreminderSet = null, [WorkflowExpression] Func<string> bodylastModifiedBy = null, [WorkflowExpression] Func<string> bodysortDate = null, [WorkflowExpression] Func<string> bodysourceId = null, [WorkflowExpression] Func<string> bodysourceAssignedToId = null, [WorkflowExpression] Func<string> bodysourceRelatedToId = null, [WorkflowExpression] Func<string[]> bodysourceContactIds = null, [WorkflowExpression] Func<bodycallDirectionInput> bodycallDirection = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskApiFeaturesCallsCallDTO> __BuildCallUpdate(WorkflowExpression<string> id, WorkflowExpression<bodytaskTypeInput> bodytaskType = null, WorkflowExpression<string> bodydueDate = null, WorkflowExpression<string> bodysubject = null, WorkflowExpression<bodyassignedToTypeInput> bodyassignedToType = null, WorkflowExpression<string> bodyassignedToId = null, WorkflowExpression<bodyrelatedToTypeInput> bodyrelatedToType = null, WorkflowExpression<string> bodyrelatedToId = null, WorkflowExpression<bodycontactTypeInput> bodycontactType = null, WorkflowExpression<string[]> bodycontactIds = null, WorkflowExpression<bodystatusInput> bodystatus = null, WorkflowExpression<string> bodycallDuration = null, WorkflowExpression<string> bodycallResultId = null, WorkflowExpression<string> bodycomments = null, WorkflowExpression<string> bodyeditorBody = null, WorkflowExpression<string> bodypriorityId = null, WorkflowExpression<int> bodyposition = null, WorkflowExpression<string> bodyparentId = null, WorkflowExpression<bool> bodyreminderSet = null, WorkflowExpression<string> bodylastModifiedBy = null, WorkflowExpression<string> bodysortDate = null, WorkflowExpression<string> bodysourceId = null, WorkflowExpression<string> bodysourceAssignedToId = null, WorkflowExpression<string> bodysourceRelatedToId = null, WorkflowExpression<string[]> bodysourceContactIds = null, WorkflowExpression<bodycallDirectionInput> bodycallDirection = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytaskType, nameof(bodytaskType), required: false);
            WorkflowExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            WorkflowExpression.Validate(bodyassignedToType, nameof(bodyassignedToType), required: false);
            WorkflowExpression.Validate(bodyassignedToId, nameof(bodyassignedToId), required: false);
            WorkflowExpression.Validate(bodyrelatedToType, nameof(bodyrelatedToType), required: false);
            WorkflowExpression.Validate(bodyrelatedToId, nameof(bodyrelatedToId), required: false);
            WorkflowExpression.Validate(bodycontactType, nameof(bodycontactType), required: false);
            WorkflowExpression.Validate(bodycontactIds, nameof(bodycontactIds), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodycallDuration, nameof(bodycallDuration), required: false);
            WorkflowExpression.Validate(bodycallResultId, nameof(bodycallResultId), required: false);
            WorkflowExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            WorkflowExpression.Validate(bodyeditorBody, nameof(bodyeditorBody), required: false);
            WorkflowExpression.Validate(bodypriorityId, nameof(bodypriorityId), required: false);
            WorkflowExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            WorkflowExpression.Validate(bodyparentId, nameof(bodyparentId), required: false);
            WorkflowExpression.Validate(bodyreminderSet, nameof(bodyreminderSet), required: false);
            WorkflowExpression.Validate(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            WorkflowExpression.Validate(bodysortDate, nameof(bodysortDate), required: false);
            WorkflowExpression.Validate(bodysourceId, nameof(bodysourceId), required: false);
            WorkflowExpression.Validate(bodysourceAssignedToId, nameof(bodysourceAssignedToId), required: false);
            WorkflowExpression.Validate(bodysourceRelatedToId, nameof(bodysourceRelatedToId), required: false);
            WorkflowExpression.Validate(bodysourceContactIds, nameof(bodysourceContactIds), required: false);
            WorkflowExpression.Validate(bodycallDirection, nameof(bodycallDirection), required: false);
            return new DeferredBodyAction<TaskApiFeaturesCallsCallDTO>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/task/Call/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytaskType != null)
                {
                    body["taskType"] = ExpressionConverter.ConvertO(bodytaskType);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(bodydueDate);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                    bodypropCount++;
                }

                if (bodyassignedToType != null)
                {
                    body["assignedToType"] = ExpressionConverter.ConvertO(bodyassignedToType);
                    bodypropCount++;
                }

                if (bodyassignedToId != null)
                {
                    body["assignedToId"] = ExpressionConverter.ConvertO(bodyassignedToId);
                    bodypropCount++;
                }

                if (bodyrelatedToType != null)
                {
                    body["relatedToType"] = ExpressionConverter.ConvertO(bodyrelatedToType);
                    bodypropCount++;
                }

                if (bodyrelatedToId != null)
                {
                    body["relatedToId"] = ExpressionConverter.ConvertO(bodyrelatedToId);
                    bodypropCount++;
                }

                if (bodycontactType != null)
                {
                    body["contactType"] = ExpressionConverter.ConvertO(bodycontactType);
                    bodypropCount++;
                }

                if (bodycontactIds != null)
                {
                    body["contactIds"] = ExpressionConverter.ConvertO(bodycontactIds);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodycallDuration != null)
                {
                    body["callDuration"] = ExpressionConverter.ConvertO(bodycallDuration);
                    bodypropCount++;
                }

                if (bodycallResultId != null)
                {
                    body["callResultId"] = ExpressionConverter.ConvertO(bodycallResultId);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(bodycomments);
                    bodypropCount++;
                }

                if (bodyeditorBody != null)
                {
                    body["editorBody"] = ExpressionConverter.ConvertO(bodyeditorBody);
                    bodypropCount++;
                }

                if (bodypriorityId != null)
                {
                    body["priorityId"] = ExpressionConverter.ConvertO(bodypriorityId);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(bodyposition);
                    bodypropCount++;
                }

                if (bodyparentId != null)
                {
                    body["parentId"] = ExpressionConverter.ConvertO(bodyparentId);
                    bodypropCount++;
                }

                if (bodyreminderSet != null)
                {
                    body["reminderSet"] = ExpressionConverter.ConvertO(bodyreminderSet);
                    bodypropCount++;
                }

                if (bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = ExpressionConverter.ConvertO(bodylastModifiedBy);
                    bodypropCount++;
                }

                if (bodysortDate != null)
                {
                    body["sortDate"] = ExpressionConverter.ConvertO(bodysortDate);
                    bodypropCount++;
                }

                if (bodysourceId != null)
                {
                    body["sourceId"] = ExpressionConverter.ConvertO(bodysourceId);
                    bodypropCount++;
                }

                if (bodysourceAssignedToId != null)
                {
                    body["sourceAssignedToId"] = ExpressionConverter.ConvertO(bodysourceAssignedToId);
                    bodypropCount++;
                }

                if (bodysourceRelatedToId != null)
                {
                    body["sourceRelatedToId"] = ExpressionConverter.ConvertO(bodysourceRelatedToId);
                    bodypropCount++;
                }

                if (bodysourceContactIds != null)
                {
                    body["sourceContactIds"] = ExpressionConverter.ConvertO(bodysourceContactIds);
                    bodypropCount++;
                }

                if (bodycallDirection != null)
                {
                    body["callDirection"] = ExpressionConverter.ConvertO(bodycallDirection);
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
        [WorkflowExpressionFactory(nameof(__BuildEventGetAll))]
        public IBodyWorkflowAction<TaskApiFeaturesEventsEventDTO[]> EventGetAll([WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<eventStatusInput> eventStatus = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> assignedToId = null, [WorkflowExpression] Func<string> relatedToId = null, [WorkflowExpression] Func<string> sortDate = null, [WorkflowExpression] Func<string> parentId = null, [WorkflowExpression] Func<string> eventResultId = null, [WorkflowExpression] Func<string> priorityId = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> lastModifiedBy = null, [WorkflowExpression] Func<string> createdBy = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskApiFeaturesEventsEventDTO[]> __BuildEventGetAll(WorkflowExpression<string> id = null, WorkflowExpression<statusInput> status = null, WorkflowExpression<eventStatusInput> eventStatus = null, WorkflowExpression<string> startDate = null, WorkflowExpression<string> assignedToId = null, WorkflowExpression<string> relatedToId = null, WorkflowExpression<string> sortDate = null, WorkflowExpression<string> parentId = null, WorkflowExpression<string> eventResultId = null, WorkflowExpression<string> priorityId = null, WorkflowExpression<string> search = null, WorkflowExpression<string> lastModifiedBy = null, WorkflowExpression<string> createdBy = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sort = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            WorkflowExpression.Validate(eventStatus, nameof(eventStatus), required: false);
            WorkflowExpression.Validate(startDate, nameof(startDate), required: false);
            WorkflowExpression.Validate(assignedToId, nameof(assignedToId), required: false);
            WorkflowExpression.Validate(relatedToId, nameof(relatedToId), required: false);
            WorkflowExpression.Validate(sortDate, nameof(sortDate), required: false);
            WorkflowExpression.Validate(parentId, nameof(parentId), required: false);
            WorkflowExpression.Validate(eventResultId, nameof(eventResultId), required: false);
            WorkflowExpression.Validate(priorityId, nameof(priorityId), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(lastModifiedBy, nameof(lastModifiedBy), required: false);
            WorkflowExpression.Validate(createdBy, nameof(createdBy), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<TaskApiFeaturesEventsEventDTO[]>(() =>
            {
                var apiCallPath = "/api/task/Event";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
                if (status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(status);
                if (eventStatus != null)
                    callPayload.Queries["EventStatus"] = ExpressionConverter.Convert(eventStatus);
                if (startDate != null)
                    callPayload.Queries["StartDate"] = ExpressionConverter.Convert(startDate);
                if (assignedToId != null)
                    callPayload.Queries["AssignedToId"] = ExpressionConverter.Convert(assignedToId);
                if (relatedToId != null)
                    callPayload.Queries["RelatedToId"] = ExpressionConverter.Convert(relatedToId);
                if (sortDate != null)
                    callPayload.Queries["SortDate"] = ExpressionConverter.Convert(sortDate);
                if (parentId != null)
                    callPayload.Queries["ParentId"] = ExpressionConverter.Convert(parentId);
                if (eventResultId != null)
                    callPayload.Queries["EventResultId"] = ExpressionConverter.Convert(eventResultId);
                if (priorityId != null)
                    callPayload.Queries["PriorityId"] = ExpressionConverter.Convert(priorityId);
                if (search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(search);
                if (lastModifiedBy != null)
                    callPayload.Queries["LastModifiedBy"] = ExpressionConverter.Convert(lastModifiedBy);
                if (createdBy != null)
                    callPayload.Queries["CreatedBy"] = ExpressionConverter.Convert(createdBy);
                if (page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(sort);
                return new ApiConnectionAction<TaskApiFeaturesEventsEventDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [WorkflowExpressionFactory(nameof(__BuildEventCreate))]
        public IBodyWorkflowAction<TaskApiFeaturesEventsEventDTO> EventCreate([WorkflowExpression] Func<string> bodyupdateDate = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<bodytaskTypeInput> bodytaskType = null, [WorkflowExpression] Func<bodyassignedToTypeInput> bodyassignedToType = null, [WorkflowExpression] Func<string> bodyassignedToId = null, [WorkflowExpression] Func<bodyrelatedToTypeInput> bodyrelatedToType = null, [WorkflowExpression] Func<string> bodyrelatedToId = null, [WorkflowExpression] Func<bodycontactTypeInput> bodycontactType = null, [WorkflowExpression] Func<string[]> bodycontactIds = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyeditorBody = null, [WorkflowExpression] Func<string> bodypriorityId = null, [WorkflowExpression] Func<string> bodylocationlongitude = null, [WorkflowExpression] Func<string> bodylocationlatitude = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<bool> bodyreminderSet = null, [WorkflowExpression] Func<string> bodycreatedBy = null, [WorkflowExpression] Func<string> bodylastModifiedBy = null, [WorkflowExpression] Func<int> bodyposition = null, [WorkflowExpression] Func<string> bodyparentId = null, [WorkflowExpression] Func<string> bodyrepeat = null, [WorkflowExpression] Func<bodyeventStatusInput> bodyeventStatus = null, [WorkflowExpression] Func<string> bodyeventResultId = null, [WorkflowExpression] Func<string> bodyrecurrenceInterval = null, [WorkflowExpression] Func<string> bodysourceId = null, [WorkflowExpression] Func<string> bodysourceAssignedToId = null, [WorkflowExpression] Func<string> bodysourceRelatedToId = null, [WorkflowExpression] Func<string[]> bodysourceContactIds = null, [WorkflowExpression] Func<string[]> bodyteamMembers = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskApiFeaturesEventsEventDTO> __BuildEventCreate(WorkflowExpression<string> bodyupdateDate = null, WorkflowExpression<string> bodysubject = null, WorkflowExpression<bodytaskTypeInput> bodytaskType = null, WorkflowExpression<bodyassignedToTypeInput> bodyassignedToType = null, WorkflowExpression<string> bodyassignedToId = null, WorkflowExpression<bodyrelatedToTypeInput> bodyrelatedToType = null, WorkflowExpression<string> bodyrelatedToId = null, WorkflowExpression<bodycontactTypeInput> bodycontactType = null, WorkflowExpression<string[]> bodycontactIds = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodyeditorBody = null, WorkflowExpression<string> bodypriorityId = null, WorkflowExpression<string> bodylocationlongitude = null, WorkflowExpression<string> bodylocationlatitude = null, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodyendDate = null, WorkflowExpression<bool> bodyreminderSet = null, WorkflowExpression<string> bodycreatedBy = null, WorkflowExpression<string> bodylastModifiedBy = null, WorkflowExpression<int> bodyposition = null, WorkflowExpression<string> bodyparentId = null, WorkflowExpression<string> bodyrepeat = null, WorkflowExpression<bodyeventStatusInput> bodyeventStatus = null, WorkflowExpression<string> bodyeventResultId = null, WorkflowExpression<string> bodyrecurrenceInterval = null, WorkflowExpression<string> bodysourceId = null, WorkflowExpression<string> bodysourceAssignedToId = null, WorkflowExpression<string> bodysourceRelatedToId = null, WorkflowExpression<string[]> bodysourceContactIds = null, WorkflowExpression<string[]> bodyteamMembers = null)
        {
            WorkflowExpression.Validate(bodyupdateDate, nameof(bodyupdateDate), required: false);
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            WorkflowExpression.Validate(bodytaskType, nameof(bodytaskType), required: false);
            WorkflowExpression.Validate(bodyassignedToType, nameof(bodyassignedToType), required: false);
            WorkflowExpression.Validate(bodyassignedToId, nameof(bodyassignedToId), required: false);
            WorkflowExpression.Validate(bodyrelatedToType, nameof(bodyrelatedToType), required: false);
            WorkflowExpression.Validate(bodyrelatedToId, nameof(bodyrelatedToId), required: false);
            WorkflowExpression.Validate(bodycontactType, nameof(bodycontactType), required: false);
            WorkflowExpression.Validate(bodycontactIds, nameof(bodycontactIds), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyeditorBody, nameof(bodyeditorBody), required: false);
            WorkflowExpression.Validate(bodypriorityId, nameof(bodypriorityId), required: false);
            WorkflowExpression.Validate(bodylocationlongitude, nameof(bodylocationlongitude), required: false);
            WorkflowExpression.Validate(bodylocationlatitude, nameof(bodylocationlatitude), required: false);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowExpression.Validate(bodyreminderSet, nameof(bodyreminderSet), required: false);
            WorkflowExpression.Validate(bodycreatedBy, nameof(bodycreatedBy), required: false);
            WorkflowExpression.Validate(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            WorkflowExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            WorkflowExpression.Validate(bodyparentId, nameof(bodyparentId), required: false);
            WorkflowExpression.Validate(bodyrepeat, nameof(bodyrepeat), required: false);
            WorkflowExpression.Validate(bodyeventStatus, nameof(bodyeventStatus), required: false);
            WorkflowExpression.Validate(bodyeventResultId, nameof(bodyeventResultId), required: false);
            WorkflowExpression.Validate(bodyrecurrenceInterval, nameof(bodyrecurrenceInterval), required: false);
            WorkflowExpression.Validate(bodysourceId, nameof(bodysourceId), required: false);
            WorkflowExpression.Validate(bodysourceAssignedToId, nameof(bodysourceAssignedToId), required: false);
            WorkflowExpression.Validate(bodysourceRelatedToId, nameof(bodysourceRelatedToId), required: false);
            WorkflowExpression.Validate(bodysourceContactIds, nameof(bodysourceContactIds), required: false);
            WorkflowExpression.Validate(bodyteamMembers, nameof(bodyteamMembers), required: false);
            return new DeferredBodyAction<TaskApiFeaturesEventsEventDTO>(() =>
            {
                var apiCallPath = "/api/task/Event";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyupdateDate != null)
                {
                    body["updateDate"] = ExpressionConverter.ConvertO(bodyupdateDate);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                    bodypropCount++;
                }

                if (bodytaskType != null)
                {
                    body["taskType"] = ExpressionConverter.ConvertO(bodytaskType);
                    bodypropCount++;
                }

                if (bodyassignedToType != null)
                {
                    body["assignedToType"] = ExpressionConverter.ConvertO(bodyassignedToType);
                    bodypropCount++;
                }

                if (bodyassignedToId != null)
                {
                    body["assignedToId"] = ExpressionConverter.ConvertO(bodyassignedToId);
                    bodypropCount++;
                }

                if (bodyrelatedToType != null)
                {
                    body["relatedToType"] = ExpressionConverter.ConvertO(bodyrelatedToType);
                    bodypropCount++;
                }

                if (bodyrelatedToId != null)
                {
                    body["relatedToId"] = ExpressionConverter.ConvertO(bodyrelatedToId);
                    bodypropCount++;
                }

                if (bodycontactType != null)
                {
                    body["contactType"] = ExpressionConverter.ConvertO(bodycontactType);
                    bodypropCount++;
                }

                if (bodycontactIds != null)
                {
                    body["contactIds"] = ExpressionConverter.ConvertO(bodycontactIds);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyeditorBody != null)
                {
                    body["editorBody"] = ExpressionConverter.ConvertO(bodyeditorBody);
                    bodypropCount++;
                }

                if (bodypriorityId != null)
                {
                    body["priorityId"] = ExpressionConverter.ConvertO(bodypriorityId);
                    bodypropCount++;
                }

                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (bodylocationlongitude != null)
                {
                    locationObject["longitude"] = ExpressionConverter.ConvertO(bodylocationlongitude);
                    locationObjectpropCount++;
                }

                if (bodylocationlatitude != null)
                {
                    locationObject["latitude"] = ExpressionConverter.ConvertO(bodylocationlatitude);
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    body["location"] = locationObject;
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["endDate"] = ExpressionConverter.ConvertO(bodyendDate);
                    bodypropCount++;
                }

                if (bodyreminderSet != null)
                {
                    body["reminderSet"] = ExpressionConverter.ConvertO(bodyreminderSet);
                    bodypropCount++;
                }

                if (bodycreatedBy != null)
                {
                    body["createdBy"] = ExpressionConverter.ConvertO(bodycreatedBy);
                    bodypropCount++;
                }

                if (bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = ExpressionConverter.ConvertO(bodylastModifiedBy);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(bodyposition);
                    bodypropCount++;
                }

                if (bodyparentId != null)
                {
                    body["parentId"] = ExpressionConverter.ConvertO(bodyparentId);
                    bodypropCount++;
                }

                if (bodyrepeat != null)
                {
                    body["repeat"] = ExpressionConverter.ConvertO(bodyrepeat);
                    bodypropCount++;
                }

                if (bodyeventStatus != null)
                {
                    body["eventStatus"] = ExpressionConverter.ConvertO(bodyeventStatus);
                    bodypropCount++;
                }

                if (bodyeventResultId != null)
                {
                    body["eventResultId"] = ExpressionConverter.ConvertO(bodyeventResultId);
                    bodypropCount++;
                }

                if (bodyrecurrenceInterval != null)
                {
                    body["recurrenceInterval"] = ExpressionConverter.ConvertO(bodyrecurrenceInterval);
                    bodypropCount++;
                }

                if (bodysourceId != null)
                {
                    body["sourceId"] = ExpressionConverter.ConvertO(bodysourceId);
                    bodypropCount++;
                }

                if (bodysourceAssignedToId != null)
                {
                    body["sourceAssignedToId"] = ExpressionConverter.ConvertO(bodysourceAssignedToId);
                    bodypropCount++;
                }

                if (bodysourceRelatedToId != null)
                {
                    body["sourceRelatedToId"] = ExpressionConverter.ConvertO(bodysourceRelatedToId);
                    bodypropCount++;
                }

                if (bodysourceContactIds != null)
                {
                    body["sourceContactIds"] = ExpressionConverter.ConvertO(bodysourceContactIds);
                    bodypropCount++;
                }

                if (bodyteamMembers != null)
                {
                    body["teamMembers"] = ExpressionConverter.ConvertO(bodyteamMembers);
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
        [WorkflowExpressionFactory(nameof(__BuildEventGetById))]
        public IBodyWorkflowAction<TaskApiFeaturesEventsEventDTO> EventGetById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskApiFeaturesEventsEventDTO> __BuildEventGetById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<TaskApiFeaturesEventsEventDTO>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/task/Event/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskApiFeaturesEventsEventDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [WorkflowExpressionFactory(nameof(__BuildEventDelete))]
        public IWorkflowAction EventDelete([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildEventDelete(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/task/Event/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [WorkflowExpressionFactory(nameof(__BuildEventUpdate))]
        public IBodyWorkflowAction<TaskApiFeaturesEventsEventDTO> EventUpdate([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyupdateDate = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<bodytaskTypeInput> bodytaskType = null, [WorkflowExpression] Func<bodyassignedToTypeInput> bodyassignedToType = null, [WorkflowExpression] Func<string> bodyassignedToId = null, [WorkflowExpression] Func<bodyrelatedToTypeInput> bodyrelatedToType = null, [WorkflowExpression] Func<string> bodyrelatedToId = null, [WorkflowExpression] Func<bodycontactTypeInput> bodycontactType = null, [WorkflowExpression] Func<string[]> bodycontactIds = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyeditorBody = null, [WorkflowExpression] Func<string> bodypriorityId = null, [WorkflowExpression] Func<string> bodylocationlongitude = null, [WorkflowExpression] Func<string> bodylocationlatitude = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<bool> bodyreminderSet = null, [WorkflowExpression] Func<string> bodycreatedBy = null, [WorkflowExpression] Func<string> bodylastModifiedBy = null, [WorkflowExpression] Func<int> bodyposition = null, [WorkflowExpression] Func<string> bodyparentId = null, [WorkflowExpression] Func<string> bodyrepeat = null, [WorkflowExpression] Func<bodyeventStatusInput> bodyeventStatus = null, [WorkflowExpression] Func<string> bodyeventResultId = null, [WorkflowExpression] Func<string> bodyrecurrenceInterval = null, [WorkflowExpression] Func<string> bodysourceId = null, [WorkflowExpression] Func<string> bodysourceAssignedToId = null, [WorkflowExpression] Func<string> bodysourceRelatedToId = null, [WorkflowExpression] Func<string[]> bodysourceContactIds = null, [WorkflowExpression] Func<string[]> bodyteamMembers = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskApiFeaturesEventsEventDTO> __BuildEventUpdate(WorkflowExpression<string> id, WorkflowExpression<string> bodyupdateDate = null, WorkflowExpression<string> bodysubject = null, WorkflowExpression<bodytaskTypeInput> bodytaskType = null, WorkflowExpression<bodyassignedToTypeInput> bodyassignedToType = null, WorkflowExpression<string> bodyassignedToId = null, WorkflowExpression<bodyrelatedToTypeInput> bodyrelatedToType = null, WorkflowExpression<string> bodyrelatedToId = null, WorkflowExpression<bodycontactTypeInput> bodycontactType = null, WorkflowExpression<string[]> bodycontactIds = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodyeditorBody = null, WorkflowExpression<string> bodypriorityId = null, WorkflowExpression<string> bodylocationlongitude = null, WorkflowExpression<string> bodylocationlatitude = null, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodyendDate = null, WorkflowExpression<bool> bodyreminderSet = null, WorkflowExpression<string> bodycreatedBy = null, WorkflowExpression<string> bodylastModifiedBy = null, WorkflowExpression<int> bodyposition = null, WorkflowExpression<string> bodyparentId = null, WorkflowExpression<string> bodyrepeat = null, WorkflowExpression<bodyeventStatusInput> bodyeventStatus = null, WorkflowExpression<string> bodyeventResultId = null, WorkflowExpression<string> bodyrecurrenceInterval = null, WorkflowExpression<string> bodysourceId = null, WorkflowExpression<string> bodysourceAssignedToId = null, WorkflowExpression<string> bodysourceRelatedToId = null, WorkflowExpression<string[]> bodysourceContactIds = null, WorkflowExpression<string[]> bodyteamMembers = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyupdateDate, nameof(bodyupdateDate), required: false);
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            WorkflowExpression.Validate(bodytaskType, nameof(bodytaskType), required: false);
            WorkflowExpression.Validate(bodyassignedToType, nameof(bodyassignedToType), required: false);
            WorkflowExpression.Validate(bodyassignedToId, nameof(bodyassignedToId), required: false);
            WorkflowExpression.Validate(bodyrelatedToType, nameof(bodyrelatedToType), required: false);
            WorkflowExpression.Validate(bodyrelatedToId, nameof(bodyrelatedToId), required: false);
            WorkflowExpression.Validate(bodycontactType, nameof(bodycontactType), required: false);
            WorkflowExpression.Validate(bodycontactIds, nameof(bodycontactIds), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyeditorBody, nameof(bodyeditorBody), required: false);
            WorkflowExpression.Validate(bodypriorityId, nameof(bodypriorityId), required: false);
            WorkflowExpression.Validate(bodylocationlongitude, nameof(bodylocationlongitude), required: false);
            WorkflowExpression.Validate(bodylocationlatitude, nameof(bodylocationlatitude), required: false);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowExpression.Validate(bodyreminderSet, nameof(bodyreminderSet), required: false);
            WorkflowExpression.Validate(bodycreatedBy, nameof(bodycreatedBy), required: false);
            WorkflowExpression.Validate(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            WorkflowExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            WorkflowExpression.Validate(bodyparentId, nameof(bodyparentId), required: false);
            WorkflowExpression.Validate(bodyrepeat, nameof(bodyrepeat), required: false);
            WorkflowExpression.Validate(bodyeventStatus, nameof(bodyeventStatus), required: false);
            WorkflowExpression.Validate(bodyeventResultId, nameof(bodyeventResultId), required: false);
            WorkflowExpression.Validate(bodyrecurrenceInterval, nameof(bodyrecurrenceInterval), required: false);
            WorkflowExpression.Validate(bodysourceId, nameof(bodysourceId), required: false);
            WorkflowExpression.Validate(bodysourceAssignedToId, nameof(bodysourceAssignedToId), required: false);
            WorkflowExpression.Validate(bodysourceRelatedToId, nameof(bodysourceRelatedToId), required: false);
            WorkflowExpression.Validate(bodysourceContactIds, nameof(bodysourceContactIds), required: false);
            WorkflowExpression.Validate(bodyteamMembers, nameof(bodyteamMembers), required: false);
            return new DeferredBodyAction<TaskApiFeaturesEventsEventDTO>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/task/Event/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyupdateDate != null)
                {
                    body["updateDate"] = ExpressionConverter.ConvertO(bodyupdateDate);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                    bodypropCount++;
                }

                if (bodytaskType != null)
                {
                    body["taskType"] = ExpressionConverter.ConvertO(bodytaskType);
                    bodypropCount++;
                }

                if (bodyassignedToType != null)
                {
                    body["assignedToType"] = ExpressionConverter.ConvertO(bodyassignedToType);
                    bodypropCount++;
                }

                if (bodyassignedToId != null)
                {
                    body["assignedToId"] = ExpressionConverter.ConvertO(bodyassignedToId);
                    bodypropCount++;
                }

                if (bodyrelatedToType != null)
                {
                    body["relatedToType"] = ExpressionConverter.ConvertO(bodyrelatedToType);
                    bodypropCount++;
                }

                if (bodyrelatedToId != null)
                {
                    body["relatedToId"] = ExpressionConverter.ConvertO(bodyrelatedToId);
                    bodypropCount++;
                }

                if (bodycontactType != null)
                {
                    body["contactType"] = ExpressionConverter.ConvertO(bodycontactType);
                    bodypropCount++;
                }

                if (bodycontactIds != null)
                {
                    body["contactIds"] = ExpressionConverter.ConvertO(bodycontactIds);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyeditorBody != null)
                {
                    body["editorBody"] = ExpressionConverter.ConvertO(bodyeditorBody);
                    bodypropCount++;
                }

                if (bodypriorityId != null)
                {
                    body["priorityId"] = ExpressionConverter.ConvertO(bodypriorityId);
                    bodypropCount++;
                }

                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (bodylocationlongitude != null)
                {
                    locationObject["longitude"] = ExpressionConverter.ConvertO(bodylocationlongitude);
                    locationObjectpropCount++;
                }

                if (bodylocationlatitude != null)
                {
                    locationObject["latitude"] = ExpressionConverter.ConvertO(bodylocationlatitude);
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    body["location"] = locationObject;
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["endDate"] = ExpressionConverter.ConvertO(bodyendDate);
                    bodypropCount++;
                }

                if (bodyreminderSet != null)
                {
                    body["reminderSet"] = ExpressionConverter.ConvertO(bodyreminderSet);
                    bodypropCount++;
                }

                if (bodycreatedBy != null)
                {
                    body["createdBy"] = ExpressionConverter.ConvertO(bodycreatedBy);
                    bodypropCount++;
                }

                if (bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = ExpressionConverter.ConvertO(bodylastModifiedBy);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(bodyposition);
                    bodypropCount++;
                }

                if (bodyparentId != null)
                {
                    body["parentId"] = ExpressionConverter.ConvertO(bodyparentId);
                    bodypropCount++;
                }

                if (bodyrepeat != null)
                {
                    body["repeat"] = ExpressionConverter.ConvertO(bodyrepeat);
                    bodypropCount++;
                }

                if (bodyeventStatus != null)
                {
                    body["eventStatus"] = ExpressionConverter.ConvertO(bodyeventStatus);
                    bodypropCount++;
                }

                if (bodyeventResultId != null)
                {
                    body["eventResultId"] = ExpressionConverter.ConvertO(bodyeventResultId);
                    bodypropCount++;
                }

                if (bodyrecurrenceInterval != null)
                {
                    body["recurrenceInterval"] = ExpressionConverter.ConvertO(bodyrecurrenceInterval);
                    bodypropCount++;
                }

                if (bodysourceId != null)
                {
                    body["sourceId"] = ExpressionConverter.ConvertO(bodysourceId);
                    bodypropCount++;
                }

                if (bodysourceAssignedToId != null)
                {
                    body["sourceAssignedToId"] = ExpressionConverter.ConvertO(bodysourceAssignedToId);
                    bodypropCount++;
                }

                if (bodysourceRelatedToId != null)
                {
                    body["sourceRelatedToId"] = ExpressionConverter.ConvertO(bodysourceRelatedToId);
                    bodypropCount++;
                }

                if (bodysourceContactIds != null)
                {
                    body["sourceContactIds"] = ExpressionConverter.ConvertO(bodysourceContactIds);
                    bodypropCount++;
                }

                if (bodyteamMembers != null)
                {
                    body["teamMembers"] = ExpressionConverter.ConvertO(bodyteamMembers);
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
        [WorkflowExpressionFactory(nameof(__BuildNoteGetAll))]
        public IBodyWorkflowAction<TaskApiFeaturesNotesNoteDTO[]> NoteGetAll([WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> relatedToId = null, [WorkflowExpression] Func<relatedToTypeInput> relatedToType = null, [WorkflowExpression] Func<string> createdBy = null, [WorkflowExpression] Func<string> lastModifiedBy = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskApiFeaturesNotesNoteDTO[]> __BuildNoteGetAll(WorkflowExpression<string> id = null, WorkflowExpression<string> search = null, WorkflowExpression<string> relatedToId = null, WorkflowExpression<relatedToTypeInput> relatedToType = null, WorkflowExpression<string> createdBy = null, WorkflowExpression<string> lastModifiedBy = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sort = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(relatedToId, nameof(relatedToId), required: false);
            WorkflowExpression.Validate(relatedToType, nameof(relatedToType), required: false);
            WorkflowExpression.Validate(createdBy, nameof(createdBy), required: false);
            WorkflowExpression.Validate(lastModifiedBy, nameof(lastModifiedBy), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<TaskApiFeaturesNotesNoteDTO[]>(() =>
            {
                var apiCallPath = "/api/task/Note";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
                if (search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(search);
                if (relatedToId != null)
                    callPayload.Queries["RelatedToId"] = ExpressionConverter.Convert(relatedToId);
                if (relatedToType != null)
                    callPayload.Queries["RelatedToType"] = ExpressionConverter.Convert(relatedToType);
                if (createdBy != null)
                    callPayload.Queries["CreatedBy"] = ExpressionConverter.Convert(createdBy);
                if (lastModifiedBy != null)
                    callPayload.Queries["LastModifiedBy"] = ExpressionConverter.Convert(lastModifiedBy);
                if (page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(sort);
                return new ApiConnectionAction<TaskApiFeaturesNotesNoteDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [WorkflowExpressionFactory(nameof(__BuildNoteCreate))]
        public IBodyWorkflowAction<TaskApiFeaturesNotesNoteDTO> NoteCreate([WorkflowExpression] Func<string> bodysubject, [WorkflowExpression] Func<bodytaskTypeInput> bodytaskType = null, [WorkflowExpression] Func<bodyrelatedToTypeInput> bodyrelatedToType = null, [WorkflowExpression] Func<bodycontactTypeInput> bodycontactType = null, [WorkflowExpression] Func<string> bodyrelatedToId = null, [WorkflowExpression] Func<string> bodybody = null, [WorkflowExpression] Func<string> bodyeditorBody = null, [WorkflowExpression] Func<string[]> bodycontactIds = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskApiFeaturesNotesNoteDTO> __BuildNoteCreate(WorkflowExpression<string> bodysubject, WorkflowExpression<bodytaskTypeInput> bodytaskType = null, WorkflowExpression<bodyrelatedToTypeInput> bodyrelatedToType = null, WorkflowExpression<bodycontactTypeInput> bodycontactType = null, WorkflowExpression<string> bodyrelatedToId = null, WorkflowExpression<string> bodybody = null, WorkflowExpression<string> bodyeditorBody = null, WorkflowExpression<string[]> bodycontactIds = null)
        {
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: true);
            WorkflowExpression.Validate(bodytaskType, nameof(bodytaskType), required: false);
            WorkflowExpression.Validate(bodyrelatedToType, nameof(bodyrelatedToType), required: false);
            WorkflowExpression.Validate(bodycontactType, nameof(bodycontactType), required: false);
            WorkflowExpression.Validate(bodyrelatedToId, nameof(bodyrelatedToId), required: false);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: false);
            WorkflowExpression.Validate(bodyeditorBody, nameof(bodyeditorBody), required: false);
            WorkflowExpression.Validate(bodycontactIds, nameof(bodycontactIds), required: false);
            return new DeferredBodyAction<TaskApiFeaturesNotesNoteDTO>(() =>
            {
                var apiCallPath = "/api/task/Note";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytaskType != null)
                {
                    body["taskType"] = ExpressionConverter.ConvertO(bodytaskType);
                    bodypropCount++;
                }

                if (bodyrelatedToType != null)
                {
                    body["relatedToType"] = ExpressionConverter.ConvertO(bodyrelatedToType);
                    bodypropCount++;
                }

                if (bodycontactType != null)
                {
                    body["contactType"] = ExpressionConverter.ConvertO(bodycontactType);
                    bodypropCount++;
                }

                if (bodyrelatedToId != null)
                {
                    body["relatedToId"] = ExpressionConverter.ConvertO(bodyrelatedToId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                if (bodybody != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(bodybody);
                    bodypropCount++;
                }

                if (bodyeditorBody != null)
                {
                    body["editorBody"] = ExpressionConverter.ConvertO(bodyeditorBody);
                    bodypropCount++;
                }

                if (bodycontactIds != null)
                {
                    body["contactIds"] = ExpressionConverter.ConvertO(bodycontactIds);
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
        [WorkflowExpressionFactory(nameof(__BuildNoteGetById))]
        public IBodyWorkflowAction<TaskApiFeaturesNotesNoteDTO> NoteGetById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskApiFeaturesNotesNoteDTO> __BuildNoteGetById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<TaskApiFeaturesNotesNoteDTO>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/task/Note/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskApiFeaturesNotesNoteDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [WorkflowExpressionFactory(nameof(__BuildNoteDelete))]
        public IWorkflowAction NoteDelete([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildNoteDelete(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/task/Note/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [WorkflowExpressionFactory(nameof(__BuildNoteUpdate))]
        public IBodyWorkflowAction<TaskApiFeaturesNotesNoteDTO> NoteUpdate([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bodyrelatedToTypeInput> bodyrelatedToType = null, [WorkflowExpression] Func<string> bodyrelatedToId = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodybody = null, [WorkflowExpression] Func<string> bodyeditorBody = null, [WorkflowExpression] Func<string> bodylastModifiedBy = null, [WorkflowExpression] Func<string[]> bodycontactIds = null, [WorkflowExpression] Func<bodycontactTypeInput> bodycontactType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskApiFeaturesNotesNoteDTO> __BuildNoteUpdate(WorkflowExpression<string> id, WorkflowExpression<bodyrelatedToTypeInput> bodyrelatedToType = null, WorkflowExpression<string> bodyrelatedToId = null, WorkflowExpression<string> bodysubject = null, WorkflowExpression<string> bodybody = null, WorkflowExpression<string> bodyeditorBody = null, WorkflowExpression<string> bodylastModifiedBy = null, WorkflowExpression<string[]> bodycontactIds = null, WorkflowExpression<bodycontactTypeInput> bodycontactType = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyrelatedToType, nameof(bodyrelatedToType), required: false);
            WorkflowExpression.Validate(bodyrelatedToId, nameof(bodyrelatedToId), required: false);
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: false);
            WorkflowExpression.Validate(bodyeditorBody, nameof(bodyeditorBody), required: false);
            WorkflowExpression.Validate(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            WorkflowExpression.Validate(bodycontactIds, nameof(bodycontactIds), required: false);
            WorkflowExpression.Validate(bodycontactType, nameof(bodycontactType), required: false);
            return new DeferredBodyAction<TaskApiFeaturesNotesNoteDTO>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/task/Note/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyrelatedToType != null)
                {
                    body["relatedToType"] = ExpressionConverter.ConvertO(bodyrelatedToType);
                    bodypropCount++;
                }

                if (bodyrelatedToId != null)
                {
                    body["relatedToId"] = ExpressionConverter.ConvertO(bodyrelatedToId);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                    bodypropCount++;
                }

                if (bodybody != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(bodybody);
                    bodypropCount++;
                }

                if (bodyeditorBody != null)
                {
                    body["editorBody"] = ExpressionConverter.ConvertO(bodyeditorBody);
                    bodypropCount++;
                }

                if (bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = ExpressionConverter.ConvertO(bodylastModifiedBy);
                    bodypropCount++;
                }

                if (bodycontactIds != null)
                {
                    body["contactIds"] = ExpressionConverter.ConvertO(bodycontactIds);
                    bodypropCount++;
                }

                if (bodycontactType != null)
                {
                    body["contactType"] = ExpressionConverter.ConvertO(bodycontactType);
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
        [WorkflowExpressionFactory(nameof(__BuildTaskGetAll))]
        public IBodyWorkflowAction<TaskApiFeaturesTasksTaskDTO[]> TaskGetAll([WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<string> relatedTo = null, [WorkflowExpression] Func<string> relatedToId = null, [WorkflowExpression] Func<string> priorityId = null, [WorkflowExpression] Func<typeInput> type = null, [WorkflowExpression] Func<string> dueDate = null, [WorkflowExpression] Func<string> sortDate = null, [WorkflowExpression] Func<string> parentId = null, [WorkflowExpression] Func<string> lastModifiedBy = null, [WorkflowExpression] Func<string> createdBy = null, [WorkflowExpression] Func<string> assignedToId = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskApiFeaturesTasksTaskDTO[]> __BuildTaskGetAll(WorkflowExpression<string> id = null, WorkflowExpression<statusInput> status = null, WorkflowExpression<string> relatedTo = null, WorkflowExpression<string> relatedToId = null, WorkflowExpression<string> priorityId = null, WorkflowExpression<typeInput> type = null, WorkflowExpression<string> dueDate = null, WorkflowExpression<string> sortDate = null, WorkflowExpression<string> parentId = null, WorkflowExpression<string> lastModifiedBy = null, WorkflowExpression<string> createdBy = null, WorkflowExpression<string> assignedToId = null, WorkflowExpression<string> search = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sort = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            WorkflowExpression.Validate(relatedTo, nameof(relatedTo), required: false);
            WorkflowExpression.Validate(relatedToId, nameof(relatedToId), required: false);
            WorkflowExpression.Validate(priorityId, nameof(priorityId), required: false);
            WorkflowExpression.Validate(type, nameof(type), required: false);
            WorkflowExpression.Validate(dueDate, nameof(dueDate), required: false);
            WorkflowExpression.Validate(sortDate, nameof(sortDate), required: false);
            WorkflowExpression.Validate(parentId, nameof(parentId), required: false);
            WorkflowExpression.Validate(lastModifiedBy, nameof(lastModifiedBy), required: false);
            WorkflowExpression.Validate(createdBy, nameof(createdBy), required: false);
            WorkflowExpression.Validate(assignedToId, nameof(assignedToId), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<TaskApiFeaturesTasksTaskDTO[]>(() =>
            {
                var apiCallPath = "/api/Task";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
                if (status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(status);
                if (relatedTo != null)
                    callPayload.Queries["RelatedTo"] = ExpressionConverter.Convert(relatedTo);
                if (relatedToId != null)
                    callPayload.Queries["RelatedToId"] = ExpressionConverter.Convert(relatedToId);
                if (priorityId != null)
                    callPayload.Queries["PriorityId"] = ExpressionConverter.Convert(priorityId);
                if (type != null)
                    callPayload.Queries["Type"] = ExpressionConverter.Convert(type);
                if (dueDate != null)
                    callPayload.Queries["DueDate"] = ExpressionConverter.Convert(dueDate);
                if (sortDate != null)
                    callPayload.Queries["SortDate"] = ExpressionConverter.Convert(sortDate);
                if (parentId != null)
                    callPayload.Queries["ParentId"] = ExpressionConverter.Convert(parentId);
                if (lastModifiedBy != null)
                    callPayload.Queries["LastModifiedBy"] = ExpressionConverter.Convert(lastModifiedBy);
                if (createdBy != null)
                    callPayload.Queries["CreatedBy"] = ExpressionConverter.Convert(createdBy);
                if (assignedToId != null)
                    callPayload.Queries["AssignedToId"] = ExpressionConverter.Convert(assignedToId);
                if (search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(search);
                if (page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(sort);
                return new ApiConnectionAction<TaskApiFeaturesTasksTaskDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [WorkflowExpressionFactory(nameof(__BuildTaskCreate))]
        public IBodyWorkflowAction<TaskApiFeaturesTasksTaskDTO> TaskCreate([WorkflowExpression] Func<bodytaskTypeInput> bodytaskType = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodypriorityId = null, [WorkflowExpression] Func<string> bodyassignedToId = null, [WorkflowExpression] Func<bodyassignedToTypeInput> bodyassignedToType = null, [WorkflowExpression] Func<string[]> bodycontactIds = null, [WorkflowExpression] Func<bodycontactTypeInput> bodycontactType = null, [WorkflowExpression] Func<string> bodyrelatedToId = null, [WorkflowExpression] Func<bodyrelatedToTypeInput> bodyrelatedToType = null, [WorkflowExpression] Func<string> bodytaskSubTypeId = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodyeditorBody = null, [WorkflowExpression] Func<bool> bodyreminderSet = null, [WorkflowExpression] Func<int> bodyposition = null, [WorkflowExpression] Func<string> bodyparentId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskApiFeaturesTasksTaskDTO> __BuildTaskCreate(WorkflowExpression<bodytaskTypeInput> bodytaskType = null, WorkflowExpression<string> bodysubject = null, WorkflowExpression<string> bodydueDate = null, WorkflowExpression<bodystatusInput> bodystatus = null, WorkflowExpression<string> bodypriorityId = null, WorkflowExpression<string> bodyassignedToId = null, WorkflowExpression<bodyassignedToTypeInput> bodyassignedToType = null, WorkflowExpression<string[]> bodycontactIds = null, WorkflowExpression<bodycontactTypeInput> bodycontactType = null, WorkflowExpression<string> bodyrelatedToId = null, WorkflowExpression<bodyrelatedToTypeInput> bodyrelatedToType = null, WorkflowExpression<string> bodytaskSubTypeId = null, WorkflowExpression<string> bodycomments = null, WorkflowExpression<string> bodyeditorBody = null, WorkflowExpression<bool> bodyreminderSet = null, WorkflowExpression<int> bodyposition = null, WorkflowExpression<string> bodyparentId = null)
        {
            WorkflowExpression.Validate(bodytaskType, nameof(bodytaskType), required: false);
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            WorkflowExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodypriorityId, nameof(bodypriorityId), required: false);
            WorkflowExpression.Validate(bodyassignedToId, nameof(bodyassignedToId), required: false);
            WorkflowExpression.Validate(bodyassignedToType, nameof(bodyassignedToType), required: false);
            WorkflowExpression.Validate(bodycontactIds, nameof(bodycontactIds), required: false);
            WorkflowExpression.Validate(bodycontactType, nameof(bodycontactType), required: false);
            WorkflowExpression.Validate(bodyrelatedToId, nameof(bodyrelatedToId), required: false);
            WorkflowExpression.Validate(bodyrelatedToType, nameof(bodyrelatedToType), required: false);
            WorkflowExpression.Validate(bodytaskSubTypeId, nameof(bodytaskSubTypeId), required: false);
            WorkflowExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            WorkflowExpression.Validate(bodyeditorBody, nameof(bodyeditorBody), required: false);
            WorkflowExpression.Validate(bodyreminderSet, nameof(bodyreminderSet), required: false);
            WorkflowExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            WorkflowExpression.Validate(bodyparentId, nameof(bodyparentId), required: false);
            return new DeferredBodyAction<TaskApiFeaturesTasksTaskDTO>(() =>
            {
                var apiCallPath = "/api/Task";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytaskType != null)
                {
                    body["taskType"] = ExpressionConverter.ConvertO(bodytaskType);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(bodydueDate);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodypriorityId != null)
                {
                    body["priorityId"] = ExpressionConverter.ConvertO(bodypriorityId);
                    bodypropCount++;
                }

                if (bodyassignedToId != null)
                {
                    body["assignedToId"] = ExpressionConverter.ConvertO(bodyassignedToId);
                    bodypropCount++;
                }

                if (bodyassignedToType != null)
                {
                    body["assignedToType"] = ExpressionConverter.ConvertO(bodyassignedToType);
                    bodypropCount++;
                }

                if (bodycontactIds != null)
                {
                    body["contactIds"] = ExpressionConverter.ConvertO(bodycontactIds);
                    bodypropCount++;
                }

                if (bodycontactType != null)
                {
                    body["contactType"] = ExpressionConverter.ConvertO(bodycontactType);
                    bodypropCount++;
                }

                if (bodyrelatedToId != null)
                {
                    body["relatedToId"] = ExpressionConverter.ConvertO(bodyrelatedToId);
                    bodypropCount++;
                }

                if (bodyrelatedToType != null)
                {
                    body["relatedToType"] = ExpressionConverter.ConvertO(bodyrelatedToType);
                    bodypropCount++;
                }

                if (bodytaskSubTypeId != null)
                {
                    body["taskSubTypeId"] = ExpressionConverter.ConvertO(bodytaskSubTypeId);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(bodycomments);
                    bodypropCount++;
                }

                if (bodyeditorBody != null)
                {
                    body["editorBody"] = ExpressionConverter.ConvertO(bodyeditorBody);
                    bodypropCount++;
                }

                if (bodyreminderSet != null)
                {
                    body["reminderSet"] = ExpressionConverter.ConvertO(bodyreminderSet);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(bodyposition);
                    bodypropCount++;
                }

                if (bodyparentId != null)
                {
                    body["parentId"] = ExpressionConverter.ConvertO(bodyparentId);
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
        [WorkflowExpressionFactory(nameof(__BuildTaskGetById))]
        public IBodyWorkflowAction<TaskApiFeaturesTasksTaskDTO> TaskGetById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskApiFeaturesTasksTaskDTO> __BuildTaskGetById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<TaskApiFeaturesTasksTaskDTO>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Task/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskApiFeaturesTasksTaskDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [WorkflowExpressionFactory(nameof(__BuildTaskDelete))]
        public IWorkflowAction TaskDelete([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTaskDelete(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Task/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [WorkflowExpressionFactory(nameof(__BuildTaskUpdate))]
        public IBodyWorkflowAction<TaskApiFeaturesTasksTaskDTO> TaskUpdate([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bodytaskTypeInput> bodytaskType = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<string> bodycompletedDate = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodypriorityId = null, [WorkflowExpression] Func<string> bodyassignedToId = null, [WorkflowExpression] Func<bodyassignedToTypeInput> bodyassignedToType = null, [WorkflowExpression] Func<string[]> bodycontactIds = null, [WorkflowExpression] Func<bodycontactTypeInput> bodycontactType = null, [WorkflowExpression] Func<string> bodyrelatedToId = null, [WorkflowExpression] Func<bodyrelatedToTypeInput> bodyrelatedToType = null, [WorkflowExpression] Func<string> bodytaskSubTypeId = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodyeditorBody = null, [WorkflowExpression] Func<bool> bodyreminderSet = null, [WorkflowExpression] Func<int> bodyposition = null, [WorkflowExpression] Func<string> bodyparentId = null, [WorkflowExpression] Func<string> bodylastModifiedBy = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskApiFeaturesTasksTaskDTO> __BuildTaskUpdate(WorkflowExpression<string> id, WorkflowExpression<bodytaskTypeInput> bodytaskType = null, WorkflowExpression<string> bodysubject = null, WorkflowExpression<string> bodydueDate = null, WorkflowExpression<string> bodycompletedDate = null, WorkflowExpression<bodystatusInput> bodystatus = null, WorkflowExpression<string> bodypriorityId = null, WorkflowExpression<string> bodyassignedToId = null, WorkflowExpression<bodyassignedToTypeInput> bodyassignedToType = null, WorkflowExpression<string[]> bodycontactIds = null, WorkflowExpression<bodycontactTypeInput> bodycontactType = null, WorkflowExpression<string> bodyrelatedToId = null, WorkflowExpression<bodyrelatedToTypeInput> bodyrelatedToType = null, WorkflowExpression<string> bodytaskSubTypeId = null, WorkflowExpression<string> bodycomments = null, WorkflowExpression<string> bodyeditorBody = null, WorkflowExpression<bool> bodyreminderSet = null, WorkflowExpression<int> bodyposition = null, WorkflowExpression<string> bodyparentId = null, WorkflowExpression<string> bodylastModifiedBy = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytaskType, nameof(bodytaskType), required: false);
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            WorkflowExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            WorkflowExpression.Validate(bodycompletedDate, nameof(bodycompletedDate), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodypriorityId, nameof(bodypriorityId), required: false);
            WorkflowExpression.Validate(bodyassignedToId, nameof(bodyassignedToId), required: false);
            WorkflowExpression.Validate(bodyassignedToType, nameof(bodyassignedToType), required: false);
            WorkflowExpression.Validate(bodycontactIds, nameof(bodycontactIds), required: false);
            WorkflowExpression.Validate(bodycontactType, nameof(bodycontactType), required: false);
            WorkflowExpression.Validate(bodyrelatedToId, nameof(bodyrelatedToId), required: false);
            WorkflowExpression.Validate(bodyrelatedToType, nameof(bodyrelatedToType), required: false);
            WorkflowExpression.Validate(bodytaskSubTypeId, nameof(bodytaskSubTypeId), required: false);
            WorkflowExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            WorkflowExpression.Validate(bodyeditorBody, nameof(bodyeditorBody), required: false);
            WorkflowExpression.Validate(bodyreminderSet, nameof(bodyreminderSet), required: false);
            WorkflowExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            WorkflowExpression.Validate(bodyparentId, nameof(bodyparentId), required: false);
            WorkflowExpression.Validate(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            return new DeferredBodyAction<TaskApiFeaturesTasksTaskDTO>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Task/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytaskType != null)
                {
                    body["taskType"] = ExpressionConverter.ConvertO(bodytaskType);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(bodydueDate);
                    bodypropCount++;
                }

                if (bodycompletedDate != null)
                {
                    body["completedDate"] = ExpressionConverter.ConvertO(bodycompletedDate);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodypriorityId != null)
                {
                    body["priorityId"] = ExpressionConverter.ConvertO(bodypriorityId);
                    bodypropCount++;
                }

                if (bodyassignedToId != null)
                {
                    body["assignedToId"] = ExpressionConverter.ConvertO(bodyassignedToId);
                    bodypropCount++;
                }

                if (bodyassignedToType != null)
                {
                    body["assignedToType"] = ExpressionConverter.ConvertO(bodyassignedToType);
                    bodypropCount++;
                }

                if (bodycontactIds != null)
                {
                    body["contactIds"] = ExpressionConverter.ConvertO(bodycontactIds);
                    bodypropCount++;
                }

                if (bodycontactType != null)
                {
                    body["contactType"] = ExpressionConverter.ConvertO(bodycontactType);
                    bodypropCount++;
                }

                if (bodyrelatedToId != null)
                {
                    body["relatedToId"] = ExpressionConverter.ConvertO(bodyrelatedToId);
                    bodypropCount++;
                }

                if (bodyrelatedToType != null)
                {
                    body["relatedToType"] = ExpressionConverter.ConvertO(bodyrelatedToType);
                    bodypropCount++;
                }

                if (bodytaskSubTypeId != null)
                {
                    body["taskSubTypeId"] = ExpressionConverter.ConvertO(bodytaskSubTypeId);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(bodycomments);
                    bodypropCount++;
                }

                if (bodyeditorBody != null)
                {
                    body["editorBody"] = ExpressionConverter.ConvertO(bodyeditorBody);
                    bodypropCount++;
                }

                if (bodyreminderSet != null)
                {
                    body["reminderSet"] = ExpressionConverter.ConvertO(bodyreminderSet);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(bodyposition);
                    bodypropCount++;
                }

                if (bodyparentId != null)
                {
                    body["parentId"] = ExpressionConverter.ConvertO(bodyparentId);
                    bodypropCount++;
                }

                if (bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = ExpressionConverter.ConvertO(bodylastModifiedBy);
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
        [WorkflowExpressionFactory(nameof(__BuildLeadGetAll))]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesLeadLeadDto[]> LeadGetAll([WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> lastName = null, [WorkflowExpression] Func<string> insertDate = null, [WorkflowExpression] Func<string> phone = null, [WorkflowExpression] Func<string> mobilePhone = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> ownerId = null, [WorkflowExpression] Func<ownerTypeInput> ownerType = null, [WorkflowExpression] Func<string> accountSourceTypeId = null, [WorkflowExpression] Func<string> leadStatusId = null, [WorkflowExpression] Func<string> industryId = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesLeadLeadDto[]> __BuildLeadGetAll(WorkflowExpression<string> id = null, WorkflowExpression<string> name = null, WorkflowExpression<string> firstName = null, WorkflowExpression<string> lastName = null, WorkflowExpression<string> insertDate = null, WorkflowExpression<string> phone = null, WorkflowExpression<string> mobilePhone = null, WorkflowExpression<string> email = null, WorkflowExpression<string> ownerId = null, WorkflowExpression<ownerTypeInput> ownerType = null, WorkflowExpression<string> accountSourceTypeId = null, WorkflowExpression<string> leadStatusId = null, WorkflowExpression<string> industryId = null, WorkflowExpression<string> status = null, WorkflowExpression<string> search = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sort = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(firstName, nameof(firstName), required: false);
            WorkflowExpression.Validate(lastName, nameof(lastName), required: false);
            WorkflowExpression.Validate(insertDate, nameof(insertDate), required: false);
            WorkflowExpression.Validate(phone, nameof(phone), required: false);
            WorkflowExpression.Validate(mobilePhone, nameof(mobilePhone), required: false);
            WorkflowExpression.Validate(email, nameof(email), required: false);
            WorkflowExpression.Validate(ownerId, nameof(ownerId), required: false);
            WorkflowExpression.Validate(ownerType, nameof(ownerType), required: false);
            WorkflowExpression.Validate(accountSourceTypeId, nameof(accountSourceTypeId), required: false);
            WorkflowExpression.Validate(leadStatusId, nameof(leadStatusId), required: false);
            WorkflowExpression.Validate(industryId, nameof(industryId), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<SalesPipelineApiFeaturesLeadLeadDto[]>(() =>
            {
                var apiCallPath = "/api/Lead";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
                if (name != null)
                    callPayload.Queries["Name"] = ExpressionConverter.Convert(name);
                if (firstName != null)
                    callPayload.Queries["FirstName"] = ExpressionConverter.Convert(firstName);
                if (lastName != null)
                    callPayload.Queries["LastName"] = ExpressionConverter.Convert(lastName);
                if (insertDate != null)
                    callPayload.Queries["InsertDate"] = ExpressionConverter.Convert(insertDate);
                if (phone != null)
                    callPayload.Queries["Phone"] = ExpressionConverter.Convert(phone);
                if (mobilePhone != null)
                    callPayload.Queries["MobilePhone"] = ExpressionConverter.Convert(mobilePhone);
                if (email != null)
                    callPayload.Queries["Email"] = ExpressionConverter.Convert(email);
                if (ownerId != null)
                    callPayload.Queries["OwnerId"] = ExpressionConverter.Convert(ownerId);
                if (ownerType != null)
                    callPayload.Queries["OwnerType"] = ExpressionConverter.Convert(ownerType);
                if (accountSourceTypeId != null)
                    callPayload.Queries["AccountSourceTypeId"] = ExpressionConverter.Convert(accountSourceTypeId);
                if (leadStatusId != null)
                    callPayload.Queries["LeadStatusId"] = ExpressionConverter.Convert(leadStatusId);
                if (industryId != null)
                    callPayload.Queries["IndustryId"] = ExpressionConverter.Convert(industryId);
                if (status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(status);
                if (search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(search);
                if (page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(sort);
                return new ApiConnectionAction<SalesPipelineApiFeaturesLeadLeadDto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [WorkflowExpressionFactory(nameof(__BuildLeadCreate))]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesLeadLeadDto> LeadCreate([WorkflowExpression] Func<string> bodynamefirstName, [WorkflowExpression] Func<string> bodyjobTitle = null, [WorkflowExpression] Func<string> bodyleadStatusId = null, [WorkflowExpression] Func<string> bodynamelastName = null, [WorkflowExpression] Func<string> bodynamemiddleName = null, [WorkflowExpression] Func<string> bodynamesalutationId = null, [WorkflowExpression] Func<string> bodynamesuffix = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodymobilePhone = null, [WorkflowExpression] Func<SalesPipelineApiDTOsEmailDTO[]> bodyotherEmail = null, [WorkflowExpression] Func<SalesPipelineApiDTOsPhoneDTO[]> bodyotherPhone = null, [WorkflowExpression] Func<bool> bodycallOptOut = null, [WorkflowExpression] Func<bool> bodyemailOptOut = null, [WorkflowExpression] Func<string> bodyratingId = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<bodyownerTypeInput> bodyownerType = null, [WorkflowExpression] Func<string> bodywebsite = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodyindustryId = null, [WorkflowExpression] Func<int> bodynoOfEmployees = null, [WorkflowExpression] Func<string> bodyaccountSourceTypeId = null, [WorkflowExpression] Func<string> bodyaddressaddress1 = null, [WorkflowExpression] Func<string> bodyaddressaddress2 = null, [WorkflowExpression] Func<string> bodyaddresscity = null, [WorkflowExpression] Func<string> bodyaddressstate = null, [WorkflowExpression] Func<string> bodyaddresscountry = null, [WorkflowExpression] Func<string> bodyaddresspostalCode = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<double> bodyannualRevenue = null, [WorkflowExpression] Func<string> bodylastTransferDate = null, [WorkflowExpression] Func<string> bodygenderId = null, [WorkflowExpression] Func<string> bodypronounceId = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesLeadLeadDto> __BuildLeadCreate(WorkflowExpression<string> bodynamefirstName, WorkflowExpression<string> bodyjobTitle = null, WorkflowExpression<string> bodyleadStatusId = null, WorkflowExpression<string> bodynamelastName = null, WorkflowExpression<string> bodynamemiddleName = null, WorkflowExpression<string> bodynamesalutationId = null, WorkflowExpression<string> bodynamesuffix = null, WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodyphone = null, WorkflowExpression<string> bodymobilePhone = null, WorkflowExpression<SalesPipelineApiDTOsEmailDTO[]> bodyotherEmail = null, WorkflowExpression<SalesPipelineApiDTOsPhoneDTO[]> bodyotherPhone = null, WorkflowExpression<bool> bodycallOptOut = null, WorkflowExpression<bool> bodyemailOptOut = null, WorkflowExpression<string> bodyratingId = null, WorkflowExpression<string> bodyownerId = null, WorkflowExpression<bodyownerTypeInput> bodyownerType = null, WorkflowExpression<string> bodywebsite = null, WorkflowExpression<string> bodycompany = null, WorkflowExpression<string> bodyindustryId = null, WorkflowExpression<int> bodynoOfEmployees = null, WorkflowExpression<string> bodyaccountSourceTypeId = null, WorkflowExpression<string> bodyaddressaddress1 = null, WorkflowExpression<string> bodyaddressaddress2 = null, WorkflowExpression<string> bodyaddresscity = null, WorkflowExpression<string> bodyaddressstate = null, WorkflowExpression<string> bodyaddresscountry = null, WorkflowExpression<string> bodyaddresspostalCode = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<double> bodyannualRevenue = null, WorkflowExpression<string> bodylastTransferDate = null, WorkflowExpression<string> bodygenderId = null, WorkflowExpression<string> bodypronounceId = null, WorkflowExpression<bodystatusInput> bodystatus = null)
        {
            WorkflowExpression.Validate(bodynamefirstName, nameof(bodynamefirstName), required: true);
            WorkflowExpression.Validate(bodyjobTitle, nameof(bodyjobTitle), required: false);
            WorkflowExpression.Validate(bodyleadStatusId, nameof(bodyleadStatusId), required: false);
            WorkflowExpression.Validate(bodynamelastName, nameof(bodynamelastName), required: false);
            WorkflowExpression.Validate(bodynamemiddleName, nameof(bodynamemiddleName), required: false);
            WorkflowExpression.Validate(bodynamesalutationId, nameof(bodynamesalutationId), required: false);
            WorkflowExpression.Validate(bodynamesuffix, nameof(bodynamesuffix), required: false);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            WorkflowExpression.Validate(bodymobilePhone, nameof(bodymobilePhone), required: false);
            WorkflowExpression.Validate(bodyotherEmail, nameof(bodyotherEmail), required: false);
            WorkflowExpression.Validate(bodyotherPhone, nameof(bodyotherPhone), required: false);
            WorkflowExpression.Validate(bodycallOptOut, nameof(bodycallOptOut), required: false);
            WorkflowExpression.Validate(bodyemailOptOut, nameof(bodyemailOptOut), required: false);
            WorkflowExpression.Validate(bodyratingId, nameof(bodyratingId), required: false);
            WorkflowExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            WorkflowExpression.Validate(bodyownerType, nameof(bodyownerType), required: false);
            WorkflowExpression.Validate(bodywebsite, nameof(bodywebsite), required: false);
            WorkflowExpression.Validate(bodycompany, nameof(bodycompany), required: false);
            WorkflowExpression.Validate(bodyindustryId, nameof(bodyindustryId), required: false);
            WorkflowExpression.Validate(bodynoOfEmployees, nameof(bodynoOfEmployees), required: false);
            WorkflowExpression.Validate(bodyaccountSourceTypeId, nameof(bodyaccountSourceTypeId), required: false);
            WorkflowExpression.Validate(bodyaddressaddress1, nameof(bodyaddressaddress1), required: false);
            WorkflowExpression.Validate(bodyaddressaddress2, nameof(bodyaddressaddress2), required: false);
            WorkflowExpression.Validate(bodyaddresscity, nameof(bodyaddresscity), required: false);
            WorkflowExpression.Validate(bodyaddressstate, nameof(bodyaddressstate), required: false);
            WorkflowExpression.Validate(bodyaddresscountry, nameof(bodyaddresscountry), required: false);
            WorkflowExpression.Validate(bodyaddresspostalCode, nameof(bodyaddresspostalCode), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyannualRevenue, nameof(bodyannualRevenue), required: false);
            WorkflowExpression.Validate(bodylastTransferDate, nameof(bodylastTransferDate), required: false);
            WorkflowExpression.Validate(bodygenderId, nameof(bodygenderId), required: false);
            WorkflowExpression.Validate(bodypronounceId, nameof(bodypronounceId), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<SalesPipelineApiFeaturesLeadLeadDto>(() =>
            {
                var apiCallPath = "/api/Lead";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyjobTitle != null)
                {
                    body["jobTitle"] = ExpressionConverter.ConvertO(bodyjobTitle);
                    bodypropCount++;
                }

                if (bodyleadStatusId != null)
                {
                    body["leadStatusId"] = ExpressionConverter.ConvertO(bodyleadStatusId);
                    bodypropCount++;
                }

                var nameObject = new JObject();
                var nameObjectpropCount = 0;
                nameObjectpropCount++;
                nameObject["firstName"] = ExpressionConverter.ConvertO(bodynamefirstName);
                if (bodynamelastName != null)
                {
                    nameObject["lastName"] = ExpressionConverter.ConvertO(bodynamelastName);
                    nameObjectpropCount++;
                }

                if (bodynamemiddleName != null)
                {
                    nameObject["middleName"] = ExpressionConverter.ConvertO(bodynamemiddleName);
                    nameObjectpropCount++;
                }

                if (bodynamesalutationId != null)
                {
                    nameObject["salutationId"] = ExpressionConverter.ConvertO(bodynamesalutationId);
                    nameObjectpropCount++;
                }

                if (bodynamesuffix != null)
                {
                    nameObject["suffix"] = ExpressionConverter.ConvertO(bodynamesuffix);
                    nameObjectpropCount++;
                }

                if (nameObjectpropCount > 0)
                {
                    body["name"] = nameObject;
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(bodyphone);
                    bodypropCount++;
                }

                if (bodymobilePhone != null)
                {
                    body["mobilePhone"] = ExpressionConverter.ConvertO(bodymobilePhone);
                    bodypropCount++;
                }

                if (bodyotherEmail != null)
                {
                    body["otherEmail"] = ExpressionConverter.ConvertO(bodyotherEmail);
                    bodypropCount++;
                }

                if (bodyotherPhone != null)
                {
                    body["otherPhone"] = ExpressionConverter.ConvertO(bodyotherPhone);
                    bodypropCount++;
                }

                if (bodycallOptOut != null)
                {
                    body["callOptOut"] = ExpressionConverter.ConvertO(bodycallOptOut);
                    bodypropCount++;
                }

                if (bodyemailOptOut != null)
                {
                    body["emailOptOut"] = ExpressionConverter.ConvertO(bodyemailOptOut);
                    bodypropCount++;
                }

                if (bodyratingId != null)
                {
                    body["ratingId"] = ExpressionConverter.ConvertO(bodyratingId);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["ownerId"] = ExpressionConverter.ConvertO(bodyownerId);
                    bodypropCount++;
                }

                if (bodyownerType != null)
                {
                    body["ownerType"] = ExpressionConverter.ConvertO(bodyownerType);
                    bodypropCount++;
                }

                if (bodywebsite != null)
                {
                    body["website"] = ExpressionConverter.ConvertO(bodywebsite);
                    bodypropCount++;
                }

                if (bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(bodycompany);
                    bodypropCount++;
                }

                if (bodyindustryId != null)
                {
                    body["industryId"] = ExpressionConverter.ConvertO(bodyindustryId);
                    bodypropCount++;
                }

                if (bodynoOfEmployees != null)
                {
                    body["noOfEmployees"] = ExpressionConverter.ConvertO(bodynoOfEmployees);
                    bodypropCount++;
                }

                if (bodyaccountSourceTypeId != null)
                {
                    body["accountSourceTypeId"] = ExpressionConverter.ConvertO(bodyaccountSourceTypeId);
                    bodypropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (bodyaddressaddress1 != null)
                {
                    addressObject["address1"] = ExpressionConverter.ConvertO(bodyaddressaddress1);
                    addressObjectpropCount++;
                }

                if (bodyaddressaddress2 != null)
                {
                    addressObject["address2"] = ExpressionConverter.ConvertO(bodyaddressaddress2);
                    addressObjectpropCount++;
                }

                if (bodyaddresscity != null)
                {
                    addressObject["city"] = ExpressionConverter.ConvertO(bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (bodyaddressstate != null)
                {
                    addressObject["state"] = ExpressionConverter.ConvertO(bodyaddressstate);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountry != null)
                {
                    addressObject["country"] = ExpressionConverter.ConvertO(bodyaddresscountry);
                    addressObjectpropCount++;
                }

                if (bodyaddresspostalCode != null)
                {
                    addressObject["postalCode"] = ExpressionConverter.ConvertO(bodyaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyannualRevenue != null)
                {
                    body["annualRevenue"] = ExpressionConverter.ConvertO(bodyannualRevenue);
                    bodypropCount++;
                }

                if (bodylastTransferDate != null)
                {
                    body["lastTransferDate"] = ExpressionConverter.ConvertO(bodylastTransferDate);
                    bodypropCount++;
                }

                if (bodygenderId != null)
                {
                    body["genderId"] = ExpressionConverter.ConvertO(bodygenderId);
                    bodypropCount++;
                }

                if (bodypronounceId != null)
                {
                    body["pronounceId"] = ExpressionConverter.ConvertO(bodypronounceId);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
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
        [WorkflowExpressionFactory(nameof(__BuildLeadGetById))]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesLeadLeadDto> LeadGetById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesLeadLeadDto> __BuildLeadGetById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<SalesPipelineApiFeaturesLeadLeadDto>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Lead/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SalesPipelineApiFeaturesLeadLeadDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [WorkflowExpressionFactory(nameof(__BuildLeadDelete))]
        public IWorkflowAction LeadDelete([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLeadDelete(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Lead/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [WorkflowExpressionFactory(nameof(__BuildLeadUpdate))]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesLeadLeadDto> LeadUpdate([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodynamefirstName, [WorkflowExpression] Func<string> bodyjobTitle = null, [WorkflowExpression] Func<string> bodyleadStatusId = null, [WorkflowExpression] Func<string> bodynamelastName = null, [WorkflowExpression] Func<string> bodynamemiddleName = null, [WorkflowExpression] Func<string> bodynamesalutationId = null, [WorkflowExpression] Func<string> bodynamesuffix = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodymobilePhone = null, [WorkflowExpression] Func<SalesPipelineApiDTOsEmailDTO[]> bodyotherEmail = null, [WorkflowExpression] Func<SalesPipelineApiDTOsPhoneDTO[]> bodyotherPhone = null, [WorkflowExpression] Func<bool> bodycallOptOut = null, [WorkflowExpression] Func<bool> bodyemailOptOut = null, [WorkflowExpression] Func<string> bodyratingId = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<bodyownerTypeInput> bodyownerType = null, [WorkflowExpression] Func<string> bodywebsite = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodyindustryId = null, [WorkflowExpression] Func<int> bodynoOfEmployees = null, [WorkflowExpression] Func<string> bodyaccountSourceTypeId = null, [WorkflowExpression] Func<string> bodyaddressaddress1 = null, [WorkflowExpression] Func<string> bodyaddressaddress2 = null, [WorkflowExpression] Func<string> bodyaddresscity = null, [WorkflowExpression] Func<string> bodyaddressstate = null, [WorkflowExpression] Func<string> bodyaddresscountry = null, [WorkflowExpression] Func<string> bodyaddresspostalCode = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<double> bodyannualRevenue = null, [WorkflowExpression] Func<string> bodylastTransferDate = null, [WorkflowExpression] Func<string> bodygenderId = null, [WorkflowExpression] Func<string> bodypronounceId = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodylastModifiedBy = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesLeadLeadDto> __BuildLeadUpdate(WorkflowExpression<string> id, WorkflowExpression<string> bodynamefirstName, WorkflowExpression<string> bodyjobTitle = null, WorkflowExpression<string> bodyleadStatusId = null, WorkflowExpression<string> bodynamelastName = null, WorkflowExpression<string> bodynamemiddleName = null, WorkflowExpression<string> bodynamesalutationId = null, WorkflowExpression<string> bodynamesuffix = null, WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodyphone = null, WorkflowExpression<string> bodymobilePhone = null, WorkflowExpression<SalesPipelineApiDTOsEmailDTO[]> bodyotherEmail = null, WorkflowExpression<SalesPipelineApiDTOsPhoneDTO[]> bodyotherPhone = null, WorkflowExpression<bool> bodycallOptOut = null, WorkflowExpression<bool> bodyemailOptOut = null, WorkflowExpression<string> bodyratingId = null, WorkflowExpression<string> bodyownerId = null, WorkflowExpression<bodyownerTypeInput> bodyownerType = null, WorkflowExpression<string> bodywebsite = null, WorkflowExpression<string> bodycompany = null, WorkflowExpression<string> bodyindustryId = null, WorkflowExpression<int> bodynoOfEmployees = null, WorkflowExpression<string> bodyaccountSourceTypeId = null, WorkflowExpression<string> bodyaddressaddress1 = null, WorkflowExpression<string> bodyaddressaddress2 = null, WorkflowExpression<string> bodyaddresscity = null, WorkflowExpression<string> bodyaddressstate = null, WorkflowExpression<string> bodyaddresscountry = null, WorkflowExpression<string> bodyaddresspostalCode = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<double> bodyannualRevenue = null, WorkflowExpression<string> bodylastTransferDate = null, WorkflowExpression<string> bodygenderId = null, WorkflowExpression<string> bodypronounceId = null, WorkflowExpression<bodystatusInput> bodystatus = null, WorkflowExpression<string> bodylastModifiedBy = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodynamefirstName, nameof(bodynamefirstName), required: true);
            WorkflowExpression.Validate(bodyjobTitle, nameof(bodyjobTitle), required: false);
            WorkflowExpression.Validate(bodyleadStatusId, nameof(bodyleadStatusId), required: false);
            WorkflowExpression.Validate(bodynamelastName, nameof(bodynamelastName), required: false);
            WorkflowExpression.Validate(bodynamemiddleName, nameof(bodynamemiddleName), required: false);
            WorkflowExpression.Validate(bodynamesalutationId, nameof(bodynamesalutationId), required: false);
            WorkflowExpression.Validate(bodynamesuffix, nameof(bodynamesuffix), required: false);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            WorkflowExpression.Validate(bodymobilePhone, nameof(bodymobilePhone), required: false);
            WorkflowExpression.Validate(bodyotherEmail, nameof(bodyotherEmail), required: false);
            WorkflowExpression.Validate(bodyotherPhone, nameof(bodyotherPhone), required: false);
            WorkflowExpression.Validate(bodycallOptOut, nameof(bodycallOptOut), required: false);
            WorkflowExpression.Validate(bodyemailOptOut, nameof(bodyemailOptOut), required: false);
            WorkflowExpression.Validate(bodyratingId, nameof(bodyratingId), required: false);
            WorkflowExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            WorkflowExpression.Validate(bodyownerType, nameof(bodyownerType), required: false);
            WorkflowExpression.Validate(bodywebsite, nameof(bodywebsite), required: false);
            WorkflowExpression.Validate(bodycompany, nameof(bodycompany), required: false);
            WorkflowExpression.Validate(bodyindustryId, nameof(bodyindustryId), required: false);
            WorkflowExpression.Validate(bodynoOfEmployees, nameof(bodynoOfEmployees), required: false);
            WorkflowExpression.Validate(bodyaccountSourceTypeId, nameof(bodyaccountSourceTypeId), required: false);
            WorkflowExpression.Validate(bodyaddressaddress1, nameof(bodyaddressaddress1), required: false);
            WorkflowExpression.Validate(bodyaddressaddress2, nameof(bodyaddressaddress2), required: false);
            WorkflowExpression.Validate(bodyaddresscity, nameof(bodyaddresscity), required: false);
            WorkflowExpression.Validate(bodyaddressstate, nameof(bodyaddressstate), required: false);
            WorkflowExpression.Validate(bodyaddresscountry, nameof(bodyaddresscountry), required: false);
            WorkflowExpression.Validate(bodyaddresspostalCode, nameof(bodyaddresspostalCode), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyannualRevenue, nameof(bodyannualRevenue), required: false);
            WorkflowExpression.Validate(bodylastTransferDate, nameof(bodylastTransferDate), required: false);
            WorkflowExpression.Validate(bodygenderId, nameof(bodygenderId), required: false);
            WorkflowExpression.Validate(bodypronounceId, nameof(bodypronounceId), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            return new DeferredBodyAction<SalesPipelineApiFeaturesLeadLeadDto>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Lead/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyjobTitle != null)
                {
                    body["jobTitle"] = ExpressionConverter.ConvertO(bodyjobTitle);
                    bodypropCount++;
                }

                if (bodyleadStatusId != null)
                {
                    body["leadStatusId"] = ExpressionConverter.ConvertO(bodyleadStatusId);
                    bodypropCount++;
                }

                var nameObject = new JObject();
                var nameObjectpropCount = 0;
                nameObjectpropCount++;
                nameObject["firstName"] = ExpressionConverter.ConvertO(bodynamefirstName);
                if (bodynamelastName != null)
                {
                    nameObject["lastName"] = ExpressionConverter.ConvertO(bodynamelastName);
                    nameObjectpropCount++;
                }

                if (bodynamemiddleName != null)
                {
                    nameObject["middleName"] = ExpressionConverter.ConvertO(bodynamemiddleName);
                    nameObjectpropCount++;
                }

                if (bodynamesalutationId != null)
                {
                    nameObject["salutationId"] = ExpressionConverter.ConvertO(bodynamesalutationId);
                    nameObjectpropCount++;
                }

                if (bodynamesuffix != null)
                {
                    nameObject["suffix"] = ExpressionConverter.ConvertO(bodynamesuffix);
                    nameObjectpropCount++;
                }

                if (nameObjectpropCount > 0)
                {
                    body["name"] = nameObject;
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(bodyphone);
                    bodypropCount++;
                }

                if (bodymobilePhone != null)
                {
                    body["mobilePhone"] = ExpressionConverter.ConvertO(bodymobilePhone);
                    bodypropCount++;
                }

                if (bodyotherEmail != null)
                {
                    body["otherEmail"] = ExpressionConverter.ConvertO(bodyotherEmail);
                    bodypropCount++;
                }

                if (bodyotherPhone != null)
                {
                    body["otherPhone"] = ExpressionConverter.ConvertO(bodyotherPhone);
                    bodypropCount++;
                }

                if (bodycallOptOut != null)
                {
                    body["callOptOut"] = ExpressionConverter.ConvertO(bodycallOptOut);
                    bodypropCount++;
                }

                if (bodyemailOptOut != null)
                {
                    body["emailOptOut"] = ExpressionConverter.ConvertO(bodyemailOptOut);
                    bodypropCount++;
                }

                if (bodyratingId != null)
                {
                    body["ratingId"] = ExpressionConverter.ConvertO(bodyratingId);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["ownerId"] = ExpressionConverter.ConvertO(bodyownerId);
                    bodypropCount++;
                }

                if (bodyownerType != null)
                {
                    body["ownerType"] = ExpressionConverter.ConvertO(bodyownerType);
                    bodypropCount++;
                }

                if (bodywebsite != null)
                {
                    body["website"] = ExpressionConverter.ConvertO(bodywebsite);
                    bodypropCount++;
                }

                if (bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(bodycompany);
                    bodypropCount++;
                }

                if (bodyindustryId != null)
                {
                    body["industryId"] = ExpressionConverter.ConvertO(bodyindustryId);
                    bodypropCount++;
                }

                if (bodynoOfEmployees != null)
                {
                    body["noOfEmployees"] = ExpressionConverter.ConvertO(bodynoOfEmployees);
                    bodypropCount++;
                }

                if (bodyaccountSourceTypeId != null)
                {
                    body["accountSourceTypeId"] = ExpressionConverter.ConvertO(bodyaccountSourceTypeId);
                    bodypropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (bodyaddressaddress1 != null)
                {
                    addressObject["address1"] = ExpressionConverter.ConvertO(bodyaddressaddress1);
                    addressObjectpropCount++;
                }

                if (bodyaddressaddress2 != null)
                {
                    addressObject["address2"] = ExpressionConverter.ConvertO(bodyaddressaddress2);
                    addressObjectpropCount++;
                }

                if (bodyaddresscity != null)
                {
                    addressObject["city"] = ExpressionConverter.ConvertO(bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (bodyaddressstate != null)
                {
                    addressObject["state"] = ExpressionConverter.ConvertO(bodyaddressstate);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountry != null)
                {
                    addressObject["country"] = ExpressionConverter.ConvertO(bodyaddresscountry);
                    addressObjectpropCount++;
                }

                if (bodyaddresspostalCode != null)
                {
                    addressObject["postalCode"] = ExpressionConverter.ConvertO(bodyaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyannualRevenue != null)
                {
                    body["annualRevenue"] = ExpressionConverter.ConvertO(bodyannualRevenue);
                    bodypropCount++;
                }

                if (bodylastTransferDate != null)
                {
                    body["lastTransferDate"] = ExpressionConverter.ConvertO(bodylastTransferDate);
                    bodypropCount++;
                }

                if (bodygenderId != null)
                {
                    body["genderId"] = ExpressionConverter.ConvertO(bodygenderId);
                    bodypropCount++;
                }

                if (bodypronounceId != null)
                {
                    body["pronounceId"] = ExpressionConverter.ConvertO(bodypronounceId);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = ExpressionConverter.ConvertO(bodylastModifiedBy);
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
        [WorkflowExpressionFactory(nameof(__BuildOpportunityGetAll))]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO[]> OpportunityGetAll([WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> ownerId = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<double> amount = null, [WorkflowExpression] Func<string> closeDate = null, [WorkflowExpression] Func<string> updateDate = null, [WorkflowExpression] Func<string> insertDate = null, [WorkflowExpression] Func<string> accountId = null, [WorkflowExpression] Func<string> forecastCategoryId = null, [WorkflowExpression] Func<string> accountSourceTypeId = null, [WorkflowExpression] Func<string> opportunityStatusId = null, [WorkflowExpression] Func<string> quoteId = null, [WorkflowExpression] Func<string> lossReasonId = null, [WorkflowExpression] Func<string> typeId = null, [WorkflowExpression] Func<string> lastModifiedBy = null, [WorkflowExpression] Func<string> createdBy = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> salesPipelineId = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO[]> __BuildOpportunityGetAll(WorkflowExpression<string> id = null, WorkflowExpression<string> ownerId = null, WorkflowExpression<string> name = null, WorkflowExpression<double> amount = null, WorkflowExpression<string> closeDate = null, WorkflowExpression<string> updateDate = null, WorkflowExpression<string> insertDate = null, WorkflowExpression<string> accountId = null, WorkflowExpression<string> forecastCategoryId = null, WorkflowExpression<string> accountSourceTypeId = null, WorkflowExpression<string> opportunityStatusId = null, WorkflowExpression<string> quoteId = null, WorkflowExpression<string> lossReasonId = null, WorkflowExpression<string> typeId = null, WorkflowExpression<string> lastModifiedBy = null, WorkflowExpression<string> createdBy = null, WorkflowExpression<string> search = null, WorkflowExpression<string> salesPipelineId = null, WorkflowExpression<string> status = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sort = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(ownerId, nameof(ownerId), required: false);
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(amount, nameof(amount), required: false);
            WorkflowExpression.Validate(closeDate, nameof(closeDate), required: false);
            WorkflowExpression.Validate(updateDate, nameof(updateDate), required: false);
            WorkflowExpression.Validate(insertDate, nameof(insertDate), required: false);
            WorkflowExpression.Validate(accountId, nameof(accountId), required: false);
            WorkflowExpression.Validate(forecastCategoryId, nameof(forecastCategoryId), required: false);
            WorkflowExpression.Validate(accountSourceTypeId, nameof(accountSourceTypeId), required: false);
            WorkflowExpression.Validate(opportunityStatusId, nameof(opportunityStatusId), required: false);
            WorkflowExpression.Validate(quoteId, nameof(quoteId), required: false);
            WorkflowExpression.Validate(lossReasonId, nameof(lossReasonId), required: false);
            WorkflowExpression.Validate(typeId, nameof(typeId), required: false);
            WorkflowExpression.Validate(lastModifiedBy, nameof(lastModifiedBy), required: false);
            WorkflowExpression.Validate(createdBy, nameof(createdBy), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(salesPipelineId, nameof(salesPipelineId), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO[]>(() =>
            {
                var apiCallPath = "/api/Opportunity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
                if (ownerId != null)
                    callPayload.Queries["OwnerId"] = ExpressionConverter.Convert(ownerId);
                if (name != null)
                    callPayload.Queries["Name"] = ExpressionConverter.Convert(name);
                if (amount != null)
                    callPayload.Queries["Amount"] = ExpressionConverter.Convert(amount);
                if (closeDate != null)
                    callPayload.Queries["CloseDate"] = ExpressionConverter.Convert(closeDate);
                if (updateDate != null)
                    callPayload.Queries["UpdateDate"] = ExpressionConverter.Convert(updateDate);
                if (insertDate != null)
                    callPayload.Queries["InsertDate"] = ExpressionConverter.Convert(insertDate);
                if (accountId != null)
                    callPayload.Queries["AccountId"] = ExpressionConverter.Convert(accountId);
                if (forecastCategoryId != null)
                    callPayload.Queries["ForecastCategoryId"] = ExpressionConverter.Convert(forecastCategoryId);
                if (accountSourceTypeId != null)
                    callPayload.Queries["AccountSourceTypeId"] = ExpressionConverter.Convert(accountSourceTypeId);
                if (opportunityStatusId != null)
                    callPayload.Queries["OpportunityStatusId"] = ExpressionConverter.Convert(opportunityStatusId);
                if (quoteId != null)
                    callPayload.Queries["QuoteId"] = ExpressionConverter.Convert(quoteId);
                if (lossReasonId != null)
                    callPayload.Queries["LossReasonId"] = ExpressionConverter.Convert(lossReasonId);
                if (typeId != null)
                    callPayload.Queries["TypeId"] = ExpressionConverter.Convert(typeId);
                if (lastModifiedBy != null)
                    callPayload.Queries["LastModifiedBy"] = ExpressionConverter.Convert(lastModifiedBy);
                if (createdBy != null)
                    callPayload.Queries["CreatedBy"] = ExpressionConverter.Convert(createdBy);
                if (search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(search);
                if (salesPipelineId != null)
                    callPayload.Queries["SalesPipelineId"] = ExpressionConverter.Convert(salesPipelineId);
                if (status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(status);
                if (page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(sort);
                return new ApiConnectionAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [WorkflowExpressionFactory(nameof(__BuildOpportunityCreate))]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO> OpportunityCreate([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodycloseDate, [WorkflowExpression] Func<string> bodytypeId = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodyaccountId = null, [WorkflowExpression] Func<double> bodyamount = null, [WorkflowExpression] Func<string> bodyforecastCategoryId = null, [WorkflowExpression] Func<string> bodysalesPipelineId = null, [WorkflowExpression] Func<int> bodyprobability = null, [WorkflowExpression] Func<int> bodyscore = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyquoteId = null, [WorkflowExpression] Func<string> bodyopportunityStatusId = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodyaccountSourceTypeId = null, [WorkflowExpression] Func<string> bodynextStep = null, [WorkflowExpression] Func<bool> bodybudgetConfirmed = null, [WorkflowExpression] Func<bool> bodydiscoveryCompleted = null, [WorkflowExpression] Func<double> bodyexpectedRevenue = null, [WorkflowExpression] Func<string> bodylossReasonId = null, [WorkflowExpression] Func<bool> bodyprivate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO> __BuildOpportunityCreate(WorkflowExpression<string> bodyname, WorkflowExpression<string> bodycloseDate, WorkflowExpression<string> bodytypeId = null, WorkflowExpression<string> bodyownerId = null, WorkflowExpression<string> bodyaccountId = null, WorkflowExpression<double> bodyamount = null, WorkflowExpression<string> bodyforecastCategoryId = null, WorkflowExpression<string> bodysalesPipelineId = null, WorkflowExpression<int> bodyprobability = null, WorkflowExpression<int> bodyscore = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodyquoteId = null, WorkflowExpression<string> bodyopportunityStatusId = null, WorkflowExpression<bodystatusInput> bodystatus = null, WorkflowExpression<string> bodyaccountSourceTypeId = null, WorkflowExpression<string> bodynextStep = null, WorkflowExpression<bool> bodybudgetConfirmed = null, WorkflowExpression<bool> bodydiscoveryCompleted = null, WorkflowExpression<double> bodyexpectedRevenue = null, WorkflowExpression<string> bodylossReasonId = null, WorkflowExpression<bool> bodyprivate = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodycloseDate, nameof(bodycloseDate), required: true);
            WorkflowExpression.Validate(bodytypeId, nameof(bodytypeId), required: false);
            WorkflowExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            WorkflowExpression.Validate(bodyaccountId, nameof(bodyaccountId), required: false);
            WorkflowExpression.Validate(bodyamount, nameof(bodyamount), required: false);
            WorkflowExpression.Validate(bodyforecastCategoryId, nameof(bodyforecastCategoryId), required: false);
            WorkflowExpression.Validate(bodysalesPipelineId, nameof(bodysalesPipelineId), required: false);
            WorkflowExpression.Validate(bodyprobability, nameof(bodyprobability), required: false);
            WorkflowExpression.Validate(bodyscore, nameof(bodyscore), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyquoteId, nameof(bodyquoteId), required: false);
            WorkflowExpression.Validate(bodyopportunityStatusId, nameof(bodyopportunityStatusId), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyaccountSourceTypeId, nameof(bodyaccountSourceTypeId), required: false);
            WorkflowExpression.Validate(bodynextStep, nameof(bodynextStep), required: false);
            WorkflowExpression.Validate(bodybudgetConfirmed, nameof(bodybudgetConfirmed), required: false);
            WorkflowExpression.Validate(bodydiscoveryCompleted, nameof(bodydiscoveryCompleted), required: false);
            WorkflowExpression.Validate(bodyexpectedRevenue, nameof(bodyexpectedRevenue), required: false);
            WorkflowExpression.Validate(bodylossReasonId, nameof(bodylossReasonId), required: false);
            WorkflowExpression.Validate(bodyprivate, nameof(bodyprivate), required: false);
            return new DeferredBodyAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO>(() =>
            {
                var apiCallPath = "/api/Opportunity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytypeId != null)
                {
                    body["typeId"] = ExpressionConverter.ConvertO(bodytypeId);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["ownerId"] = ExpressionConverter.ConvertO(bodyownerId);
                    bodypropCount++;
                }

                if (bodyaccountId != null)
                {
                    body["accountId"] = ExpressionConverter.ConvertO(bodyaccountId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodyamount != null)
                {
                    body["amount"] = ExpressionConverter.ConvertO(bodyamount);
                    bodypropCount++;
                }

                if (bodyforecastCategoryId != null)
                {
                    body["forecastCategoryId"] = ExpressionConverter.ConvertO(bodyforecastCategoryId);
                    bodypropCount++;
                }

                if (bodysalesPipelineId != null)
                {
                    body["salesPipelineId"] = ExpressionConverter.ConvertO(bodysalesPipelineId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["closeDate"] = ExpressionConverter.ConvertO(bodycloseDate);
                if (bodyprobability != null)
                {
                    body["probability"] = ExpressionConverter.ConvertO(bodyprobability);
                    bodypropCount++;
                }

                if (bodyscore != null)
                {
                    body["score"] = ExpressionConverter.ConvertO(bodyscore);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyquoteId != null)
                {
                    body["quoteId"] = ExpressionConverter.ConvertO(bodyquoteId);
                    bodypropCount++;
                }

                if (bodyopportunityStatusId != null)
                {
                    body["opportunityStatusId"] = ExpressionConverter.ConvertO(bodyopportunityStatusId);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodyaccountSourceTypeId != null)
                {
                    body["accountSourceTypeId"] = ExpressionConverter.ConvertO(bodyaccountSourceTypeId);
                    bodypropCount++;
                }

                if (bodynextStep != null)
                {
                    body["nextStep"] = ExpressionConverter.ConvertO(bodynextStep);
                    bodypropCount++;
                }

                if (bodybudgetConfirmed != null)
                {
                    body["budgetConfirmed"] = ExpressionConverter.ConvertO(bodybudgetConfirmed);
                    bodypropCount++;
                }

                if (bodydiscoveryCompleted != null)
                {
                    body["discoveryCompleted"] = ExpressionConverter.ConvertO(bodydiscoveryCompleted);
                    bodypropCount++;
                }

                if (bodyexpectedRevenue != null)
                {
                    body["expectedRevenue"] = ExpressionConverter.ConvertO(bodyexpectedRevenue);
                    bodypropCount++;
                }

                if (bodylossReasonId != null)
                {
                    body["lossReasonId"] = ExpressionConverter.ConvertO(bodylossReasonId);
                    bodypropCount++;
                }

                if (bodyprivate != null)
                {
                    body["private"] = ExpressionConverter.ConvertO(bodyprivate);
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
        [WorkflowExpressionFactory(nameof(__BuildOpportunityGetById))]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO> OpportunityGetById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO> __BuildOpportunityGetById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Opportunity/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [WorkflowExpressionFactory(nameof(__BuildOpportunityDelete))]
        public IWorkflowAction OpportunityDelete([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildOpportunityDelete(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Opportunity/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [WorkflowExpressionFactory(nameof(__BuildOpportunityUpdate))]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO> OpportunityUpdate([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytypeId = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodyaccountId = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<double> bodyamount = null, [WorkflowExpression] Func<string> bodyforecastCategoryId = null, [WorkflowExpression] Func<string> bodycloseDate = null, [WorkflowExpression] Func<int> bodyprobability = null, [WorkflowExpression] Func<int> bodyscore = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodysalesPipelineId = null, [WorkflowExpression] Func<string> bodyquoteId = null, [WorkflowExpression] Func<string> bodyopportunityStatusId = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodyaccountSourceTypeId = null, [WorkflowExpression] Func<string> bodynextStep = null, [WorkflowExpression] Func<bool> bodybudgetConfirmed = null, [WorkflowExpression] Func<bool> bodydiscoveryCompleted = null, [WorkflowExpression] Func<double> bodyexpectedRevenue = null, [WorkflowExpression] Func<string> bodylossReasonId = null, [WorkflowExpression] Func<bool> bodyprivate = null, [WorkflowExpression] Func<string> bodylastModifiedBy = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO> __BuildOpportunityUpdate(WorkflowExpression<string> id, WorkflowExpression<string> bodytypeId = null, WorkflowExpression<string> bodyownerId = null, WorkflowExpression<string> bodyaccountId = null, WorkflowExpression<string> bodyname = null, WorkflowExpression<double> bodyamount = null, WorkflowExpression<string> bodyforecastCategoryId = null, WorkflowExpression<string> bodycloseDate = null, WorkflowExpression<int> bodyprobability = null, WorkflowExpression<int> bodyscore = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodysalesPipelineId = null, WorkflowExpression<string> bodyquoteId = null, WorkflowExpression<string> bodyopportunityStatusId = null, WorkflowExpression<bodystatusInput> bodystatus = null, WorkflowExpression<string> bodyaccountSourceTypeId = null, WorkflowExpression<string> bodynextStep = null, WorkflowExpression<bool> bodybudgetConfirmed = null, WorkflowExpression<bool> bodydiscoveryCompleted = null, WorkflowExpression<double> bodyexpectedRevenue = null, WorkflowExpression<string> bodylossReasonId = null, WorkflowExpression<bool> bodyprivate = null, WorkflowExpression<string> bodylastModifiedBy = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytypeId, nameof(bodytypeId), required: false);
            WorkflowExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            WorkflowExpression.Validate(bodyaccountId, nameof(bodyaccountId), required: false);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodyamount, nameof(bodyamount), required: false);
            WorkflowExpression.Validate(bodyforecastCategoryId, nameof(bodyforecastCategoryId), required: false);
            WorkflowExpression.Validate(bodycloseDate, nameof(bodycloseDate), required: false);
            WorkflowExpression.Validate(bodyprobability, nameof(bodyprobability), required: false);
            WorkflowExpression.Validate(bodyscore, nameof(bodyscore), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodysalesPipelineId, nameof(bodysalesPipelineId), required: false);
            WorkflowExpression.Validate(bodyquoteId, nameof(bodyquoteId), required: false);
            WorkflowExpression.Validate(bodyopportunityStatusId, nameof(bodyopportunityStatusId), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyaccountSourceTypeId, nameof(bodyaccountSourceTypeId), required: false);
            WorkflowExpression.Validate(bodynextStep, nameof(bodynextStep), required: false);
            WorkflowExpression.Validate(bodybudgetConfirmed, nameof(bodybudgetConfirmed), required: false);
            WorkflowExpression.Validate(bodydiscoveryCompleted, nameof(bodydiscoveryCompleted), required: false);
            WorkflowExpression.Validate(bodyexpectedRevenue, nameof(bodyexpectedRevenue), required: false);
            WorkflowExpression.Validate(bodylossReasonId, nameof(bodylossReasonId), required: false);
            WorkflowExpression.Validate(bodyprivate, nameof(bodyprivate), required: false);
            WorkflowExpression.Validate(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            return new DeferredBodyAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Opportunity/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytypeId != null)
                {
                    body["typeId"] = ExpressionConverter.ConvertO(bodytypeId);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["ownerId"] = ExpressionConverter.ConvertO(bodyownerId);
                    bodypropCount++;
                }

                if (bodyaccountId != null)
                {
                    body["accountId"] = ExpressionConverter.ConvertO(bodyaccountId);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodyamount != null)
                {
                    body["amount"] = ExpressionConverter.ConvertO(bodyamount);
                    bodypropCount++;
                }

                if (bodyforecastCategoryId != null)
                {
                    body["forecastCategoryId"] = ExpressionConverter.ConvertO(bodyforecastCategoryId);
                    bodypropCount++;
                }

                if (bodycloseDate != null)
                {
                    body["closeDate"] = ExpressionConverter.ConvertO(bodycloseDate);
                    bodypropCount++;
                }

                if (bodyprobability != null)
                {
                    body["probability"] = ExpressionConverter.ConvertO(bodyprobability);
                    bodypropCount++;
                }

                if (bodyscore != null)
                {
                    body["score"] = ExpressionConverter.ConvertO(bodyscore);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodysalesPipelineId != null)
                {
                    body["salesPipelineId"] = ExpressionConverter.ConvertO(bodysalesPipelineId);
                    bodypropCount++;
                }

                if (bodyquoteId != null)
                {
                    body["quoteId"] = ExpressionConverter.ConvertO(bodyquoteId);
                    bodypropCount++;
                }

                if (bodyopportunityStatusId != null)
                {
                    body["opportunityStatusId"] = ExpressionConverter.ConvertO(bodyopportunityStatusId);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodyaccountSourceTypeId != null)
                {
                    body["accountSourceTypeId"] = ExpressionConverter.ConvertO(bodyaccountSourceTypeId);
                    bodypropCount++;
                }

                if (bodynextStep != null)
                {
                    body["nextStep"] = ExpressionConverter.ConvertO(bodynextStep);
                    bodypropCount++;
                }

                if (bodybudgetConfirmed != null)
                {
                    body["budgetConfirmed"] = ExpressionConverter.ConvertO(bodybudgetConfirmed);
                    bodypropCount++;
                }

                if (bodydiscoveryCompleted != null)
                {
                    body["discoveryCompleted"] = ExpressionConverter.ConvertO(bodydiscoveryCompleted);
                    bodypropCount++;
                }

                if (bodyexpectedRevenue != null)
                {
                    body["expectedRevenue"] = ExpressionConverter.ConvertO(bodyexpectedRevenue);
                    bodypropCount++;
                }

                if (bodylossReasonId != null)
                {
                    body["lossReasonId"] = ExpressionConverter.ConvertO(bodylossReasonId);
                    bodypropCount++;
                }

                if (bodyprivate != null)
                {
                    body["private"] = ExpressionConverter.ConvertO(bodyprivate);
                    bodypropCount++;
                }

                if (bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = ExpressionConverter.ConvertO(bodylastModifiedBy);
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
        [WorkflowExpressionFactory(nameof(__BuildUserGetById))]
        public IBodyWorkflowAction<IdentityApiBackOfficeUsersGetUserGetUserResponse> UserGetById([WorkflowExpression] Func<string> userId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IdentityApiBackOfficeUsersGetUserGetUserResponse> __BuildUserGetById(WorkflowExpression<string> userId)
        {
            WorkflowExpression.Validate(userId, nameof(userId), required: true);
            return new DeferredBodyAction<IdentityApiBackOfficeUsersGetUserGetUserResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IdentityApiBackOfficeUsersGetUserGetUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [WorkflowExpressionFactory(nameof(__BuildTeamGetById))]
        public IBodyWorkflowAction<IdentityApiTeamsDtosGetTeamResponse> TeamGetById([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IdentityApiTeamsDtosGetTeamResponse> __BuildTeamGetById(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<IdentityApiTeamsDtosGetTeamResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/teams/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IdentityApiTeamsDtosGetTeamResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [WorkflowExpressionFactory(nameof(__BuildAccountGetById))]
        public IBodyWorkflowAction<CustomerApiFeaturesAccountsAccountDTO> AccountGetById([WorkflowExpression] Func<string> accountId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CustomerApiFeaturesAccountsAccountDTO> __BuildAccountGetById(WorkflowExpression<string> accountId)
        {
            WorkflowExpression.Validate(accountId, nameof(accountId), required: true);
            return new DeferredBodyAction<CustomerApiFeaturesAccountsAccountDTO>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Account/{0}", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CustomerApiFeaturesAccountsAccountDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [WorkflowExpressionFactory(nameof(__BuildAccountDelete))]
        public IWorkflowAction AccountDelete([WorkflowExpression] Func<string> accountId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAccountDelete(WorkflowExpression<string> accountId)
        {
            WorkflowExpression.Validate(accountId, nameof(accountId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Account/{0}", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [WorkflowExpressionFactory(nameof(__BuildAccountUpdate))]
        public IBodyWorkflowAction<CustomerApiFeaturesAccountsAccountDTO> AccountUpdate([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodytin = null, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodysourceId = null, [WorkflowExpression] Func<string> bodysourceParentId = null, [WorkflowExpression] Func<string> bodysourceOwnerId = null, [WorkflowExpression] Func<string[]> bodyprimaryContactIds = null, [WorkflowExpression] Func<string> bodyparentAccountId = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodyaddressaddress1 = null, [WorkflowExpression] Func<string> bodyaddressaddress2 = null, [WorkflowExpression] Func<string> bodyaddresscity = null, [WorkflowExpression] Func<string> bodyaddressstate = null, [WorkflowExpression] Func<string> bodyaddresslatitude = null, [WorkflowExpression] Func<string> bodyaddresslongtitude = null, [WorkflowExpression] Func<string> bodyaddresscountry = null, [WorkflowExpression] Func<string> bodyaddresscountryCode = null, [WorkflowExpression] Func<string> bodyaddresspostalCode = null, [WorkflowExpression] Func<string> bodyaddressfirstName = null, [WorkflowExpression] Func<string> bodyaddresslastName = null, [WorkflowExpression] Func<string> bodyaddressphoneNumber = null, [WorkflowExpression] Func<string> bodyaddressemail = null, [WorkflowExpression] Func<string> bodyaccountSourceTypeId = null, [WorkflowExpression] Func<string> bodyindustryId = null, [WorkflowExpression] Func<string> bodytierId = null, [WorkflowExpression] Func<string> bodywebsite = null, [WorkflowExpression] Func<string> bodyaccountDescription = null, [WorkflowExpression] Func<int> bodynoOfEmployees = null, [WorkflowExpression] Func<double> bodyannualRevenue = null, [WorkflowExpression] Func<string> bodycreatedBy = null, [WorkflowExpression] Func<string> bodylastModifiedBy = null, [WorkflowExpression] Func<string> bodyfax = null, [WorkflowExpression] Func<string> bodyownershipId = null, [WorkflowExpression] Func<string> bodyratingId = null, [WorkflowExpression] Func<string> bodyclassificationId = null, [WorkflowExpression] Func<string[]> bodyassignedTeams = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CustomerApiFeaturesAccountsAccountDTO> __BuildAccountUpdate(WorkflowExpression<string> accountId, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodyphone = null, WorkflowExpression<string> bodytin = null, WorkflowExpression<string> bodycode = null, WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodysourceId = null, WorkflowExpression<string> bodysourceParentId = null, WorkflowExpression<string> bodysourceOwnerId = null, WorkflowExpression<string[]> bodyprimaryContactIds = null, WorkflowExpression<string> bodyparentAccountId = null, WorkflowExpression<string> bodyownerId = null, WorkflowExpression<string> bodyaddressaddress1 = null, WorkflowExpression<string> bodyaddressaddress2 = null, WorkflowExpression<string> bodyaddresscity = null, WorkflowExpression<string> bodyaddressstate = null, WorkflowExpression<string> bodyaddresslatitude = null, WorkflowExpression<string> bodyaddresslongtitude = null, WorkflowExpression<string> bodyaddresscountry = null, WorkflowExpression<string> bodyaddresscountryCode = null, WorkflowExpression<string> bodyaddresspostalCode = null, WorkflowExpression<string> bodyaddressfirstName = null, WorkflowExpression<string> bodyaddresslastName = null, WorkflowExpression<string> bodyaddressphoneNumber = null, WorkflowExpression<string> bodyaddressemail = null, WorkflowExpression<string> bodyaccountSourceTypeId = null, WorkflowExpression<string> bodyindustryId = null, WorkflowExpression<string> bodytierId = null, WorkflowExpression<string> bodywebsite = null, WorkflowExpression<string> bodyaccountDescription = null, WorkflowExpression<int> bodynoOfEmployees = null, WorkflowExpression<double> bodyannualRevenue = null, WorkflowExpression<string> bodycreatedBy = null, WorkflowExpression<string> bodylastModifiedBy = null, WorkflowExpression<string> bodyfax = null, WorkflowExpression<string> bodyownershipId = null, WorkflowExpression<string> bodyratingId = null, WorkflowExpression<string> bodyclassificationId = null, WorkflowExpression<string[]> bodyassignedTeams = null)
        {
            WorkflowExpression.Validate(accountId, nameof(accountId), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            WorkflowExpression.Validate(bodytin, nameof(bodytin), required: false);
            WorkflowExpression.Validate(bodycode, nameof(bodycode), required: false);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodysourceId, nameof(bodysourceId), required: false);
            WorkflowExpression.Validate(bodysourceParentId, nameof(bodysourceParentId), required: false);
            WorkflowExpression.Validate(bodysourceOwnerId, nameof(bodysourceOwnerId), required: false);
            WorkflowExpression.Validate(bodyprimaryContactIds, nameof(bodyprimaryContactIds), required: false);
            WorkflowExpression.Validate(bodyparentAccountId, nameof(bodyparentAccountId), required: false);
            WorkflowExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            WorkflowExpression.Validate(bodyaddressaddress1, nameof(bodyaddressaddress1), required: false);
            WorkflowExpression.Validate(bodyaddressaddress2, nameof(bodyaddressaddress2), required: false);
            WorkflowExpression.Validate(bodyaddresscity, nameof(bodyaddresscity), required: false);
            WorkflowExpression.Validate(bodyaddressstate, nameof(bodyaddressstate), required: false);
            WorkflowExpression.Validate(bodyaddresslatitude, nameof(bodyaddresslatitude), required: false);
            WorkflowExpression.Validate(bodyaddresslongtitude, nameof(bodyaddresslongtitude), required: false);
            WorkflowExpression.Validate(bodyaddresscountry, nameof(bodyaddresscountry), required: false);
            WorkflowExpression.Validate(bodyaddresscountryCode, nameof(bodyaddresscountryCode), required: false);
            WorkflowExpression.Validate(bodyaddresspostalCode, nameof(bodyaddresspostalCode), required: false);
            WorkflowExpression.Validate(bodyaddressfirstName, nameof(bodyaddressfirstName), required: false);
            WorkflowExpression.Validate(bodyaddresslastName, nameof(bodyaddresslastName), required: false);
            WorkflowExpression.Validate(bodyaddressphoneNumber, nameof(bodyaddressphoneNumber), required: false);
            WorkflowExpression.Validate(bodyaddressemail, nameof(bodyaddressemail), required: false);
            WorkflowExpression.Validate(bodyaccountSourceTypeId, nameof(bodyaccountSourceTypeId), required: false);
            WorkflowExpression.Validate(bodyindustryId, nameof(bodyindustryId), required: false);
            WorkflowExpression.Validate(bodytierId, nameof(bodytierId), required: false);
            WorkflowExpression.Validate(bodywebsite, nameof(bodywebsite), required: false);
            WorkflowExpression.Validate(bodyaccountDescription, nameof(bodyaccountDescription), required: false);
            WorkflowExpression.Validate(bodynoOfEmployees, nameof(bodynoOfEmployees), required: false);
            WorkflowExpression.Validate(bodyannualRevenue, nameof(bodyannualRevenue), required: false);
            WorkflowExpression.Validate(bodycreatedBy, nameof(bodycreatedBy), required: false);
            WorkflowExpression.Validate(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            WorkflowExpression.Validate(bodyfax, nameof(bodyfax), required: false);
            WorkflowExpression.Validate(bodyownershipId, nameof(bodyownershipId), required: false);
            WorkflowExpression.Validate(bodyratingId, nameof(bodyratingId), required: false);
            WorkflowExpression.Validate(bodyclassificationId, nameof(bodyclassificationId), required: false);
            WorkflowExpression.Validate(bodyassignedTeams, nameof(bodyassignedTeams), required: false);
            return new DeferredBodyAction<CustomerApiFeaturesAccountsAccountDTO>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Account/{0}", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(bodyphone);
                    bodypropCount++;
                }

                if (bodytin != null)
                {
                    body["tin"] = ExpressionConverter.ConvertO(bodytin);
                    bodypropCount++;
                }

                if (bodycode != null)
                {
                    body["code"] = ExpressionConverter.ConvertO(bodycode);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodysourceId != null)
                {
                    body["sourceId"] = ExpressionConverter.ConvertO(bodysourceId);
                    bodypropCount++;
                }

                if (bodysourceParentId != null)
                {
                    body["sourceParentId"] = ExpressionConverter.ConvertO(bodysourceParentId);
                    bodypropCount++;
                }

                if (bodysourceOwnerId != null)
                {
                    body["sourceOwnerId"] = ExpressionConverter.ConvertO(bodysourceOwnerId);
                    bodypropCount++;
                }

                if (bodyprimaryContactIds != null)
                {
                    body["primaryContactIds"] = ExpressionConverter.ConvertO(bodyprimaryContactIds);
                    bodypropCount++;
                }

                if (bodyparentAccountId != null)
                {
                    body["parentAccountId"] = ExpressionConverter.ConvertO(bodyparentAccountId);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["ownerId"] = ExpressionConverter.ConvertO(bodyownerId);
                    bodypropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (bodyaddressaddress1 != null)
                {
                    addressObject["address1"] = ExpressionConverter.ConvertO(bodyaddressaddress1);
                    addressObjectpropCount++;
                }

                if (bodyaddressaddress2 != null)
                {
                    addressObject["address2"] = ExpressionConverter.ConvertO(bodyaddressaddress2);
                    addressObjectpropCount++;
                }

                if (bodyaddresscity != null)
                {
                    addressObject["city"] = ExpressionConverter.ConvertO(bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (bodyaddressstate != null)
                {
                    addressObject["state"] = ExpressionConverter.ConvertO(bodyaddressstate);
                    addressObjectpropCount++;
                }

                if (bodyaddresslatitude != null)
                {
                    addressObject["latitude"] = ExpressionConverter.ConvertO(bodyaddresslatitude);
                    addressObjectpropCount++;
                }

                if (bodyaddresslongtitude != null)
                {
                    addressObject["longtitude"] = ExpressionConverter.ConvertO(bodyaddresslongtitude);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountry != null)
                {
                    addressObject["country"] = ExpressionConverter.ConvertO(bodyaddresscountry);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountryCode != null)
                {
                    addressObject["countryCode"] = ExpressionConverter.ConvertO(bodyaddresscountryCode);
                    addressObjectpropCount++;
                }

                if (bodyaddresspostalCode != null)
                {
                    addressObject["postalCode"] = ExpressionConverter.ConvertO(bodyaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (bodyaddressfirstName != null)
                {
                    addressObject["firstName"] = ExpressionConverter.ConvertO(bodyaddressfirstName);
                    addressObjectpropCount++;
                }

                if (bodyaddresslastName != null)
                {
                    addressObject["lastName"] = ExpressionConverter.ConvertO(bodyaddresslastName);
                    addressObjectpropCount++;
                }

                if (bodyaddressphoneNumber != null)
                {
                    addressObject["phoneNumber"] = ExpressionConverter.ConvertO(bodyaddressphoneNumber);
                    addressObjectpropCount++;
                }

                if (bodyaddressemail != null)
                {
                    addressObject["email"] = ExpressionConverter.ConvertO(bodyaddressemail);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                if (bodyaccountSourceTypeId != null)
                {
                    body["accountSourceTypeId"] = ExpressionConverter.ConvertO(bodyaccountSourceTypeId);
                    bodypropCount++;
                }

                if (bodyindustryId != null)
                {
                    body["industryId"] = ExpressionConverter.ConvertO(bodyindustryId);
                    bodypropCount++;
                }

                if (bodytierId != null)
                {
                    body["tierId"] = ExpressionConverter.ConvertO(bodytierId);
                    bodypropCount++;
                }

                if (bodywebsite != null)
                {
                    body["website"] = ExpressionConverter.ConvertO(bodywebsite);
                    bodypropCount++;
                }

                if (bodyaccountDescription != null)
                {
                    body["accountDescription"] = ExpressionConverter.ConvertO(bodyaccountDescription);
                    bodypropCount++;
                }

                if (bodynoOfEmployees != null)
                {
                    body["noOfEmployees"] = ExpressionConverter.ConvertO(bodynoOfEmployees);
                    bodypropCount++;
                }

                if (bodyannualRevenue != null)
                {
                    body["annualRevenue"] = ExpressionConverter.ConvertO(bodyannualRevenue);
                    bodypropCount++;
                }

                if (bodycreatedBy != null)
                {
                    body["createdBy"] = ExpressionConverter.ConvertO(bodycreatedBy);
                    bodypropCount++;
                }

                if (bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = ExpressionConverter.ConvertO(bodylastModifiedBy);
                    bodypropCount++;
                }

                if (bodyfax != null)
                {
                    body["fax"] = ExpressionConverter.ConvertO(bodyfax);
                    bodypropCount++;
                }

                if (bodyownershipId != null)
                {
                    body["ownershipId"] = ExpressionConverter.ConvertO(bodyownershipId);
                    bodypropCount++;
                }

                if (bodyratingId != null)
                {
                    body["ratingId"] = ExpressionConverter.ConvertO(bodyratingId);
                    bodypropCount++;
                }

                if (bodyclassificationId != null)
                {
                    body["classificationId"] = ExpressionConverter.ConvertO(bodyclassificationId);
                    bodypropCount++;
                }

                var extraFieldsObject = new JObject();
                var extraFieldsObjectpropCount = 0;
                if (extraFieldsObjectpropCount > 0)
                {
                    body["extraFields"] = extraFieldsObject;
                    bodypropCount++;
                }

                if (bodyassignedTeams != null)
                {
                    body["assignedTeams"] = ExpressionConverter.ConvertO(bodyassignedTeams);
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
        [WorkflowExpressionFactory(nameof(__BuildAccountGetAll))]
        public IBodyWorkflowAction<CustomerApiFeaturesAccountsAccountDTO[]> AccountGetAll([WorkflowExpression] Func<string> parentAccount = null, [WorkflowExpression] Func<string> phone = null, [WorkflowExpression] Func<string> suggestions = null, [WorkflowExpression] Func<string> ownerId = null, [WorkflowExpression] Func<string> ownershipId = null, [WorkflowExpression] Func<string> ratingId = null, [WorkflowExpression] Func<string> classificationId = null, [WorkflowExpression] Func<string> industryId = null, [WorkflowExpression] Func<string> accountSourceTypeId = null, [WorkflowExpression] Func<string> primaryContactId = null, [WorkflowExpression] Func<string> assignedTeams = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CustomerApiFeaturesAccountsAccountDTO[]> __BuildAccountGetAll(WorkflowExpression<string> parentAccount = null, WorkflowExpression<string> phone = null, WorkflowExpression<string> suggestions = null, WorkflowExpression<string> ownerId = null, WorkflowExpression<string> ownershipId = null, WorkflowExpression<string> ratingId = null, WorkflowExpression<string> classificationId = null, WorkflowExpression<string> industryId = null, WorkflowExpression<string> accountSourceTypeId = null, WorkflowExpression<string> primaryContactId = null, WorkflowExpression<string> assignedTeams = null, WorkflowExpression<string> search = null, WorkflowExpression<string> name = null, WorkflowExpression<string> id = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sort = null)
        {
            WorkflowExpression.Validate(parentAccount, nameof(parentAccount), required: false);
            WorkflowExpression.Validate(phone, nameof(phone), required: false);
            WorkflowExpression.Validate(suggestions, nameof(suggestions), required: false);
            WorkflowExpression.Validate(ownerId, nameof(ownerId), required: false);
            WorkflowExpression.Validate(ownershipId, nameof(ownershipId), required: false);
            WorkflowExpression.Validate(ratingId, nameof(ratingId), required: false);
            WorkflowExpression.Validate(classificationId, nameof(classificationId), required: false);
            WorkflowExpression.Validate(industryId, nameof(industryId), required: false);
            WorkflowExpression.Validate(accountSourceTypeId, nameof(accountSourceTypeId), required: false);
            WorkflowExpression.Validate(primaryContactId, nameof(primaryContactId), required: false);
            WorkflowExpression.Validate(assignedTeams, nameof(assignedTeams), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<CustomerApiFeaturesAccountsAccountDTO[]>(() =>
            {
                var apiCallPath = "/api/Account";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (parentAccount != null)
                    callPayload.Queries["ParentAccount"] = ExpressionConverter.Convert(parentAccount);
                if (phone != null)
                    callPayload.Queries["Phone"] = ExpressionConverter.Convert(phone);
                if (suggestions != null)
                    callPayload.Queries["Suggestions"] = ExpressionConverter.Convert(suggestions);
                if (ownerId != null)
                    callPayload.Queries["OwnerId"] = ExpressionConverter.Convert(ownerId);
                if (ownershipId != null)
                    callPayload.Queries["OwnershipId"] = ExpressionConverter.Convert(ownershipId);
                if (ratingId != null)
                    callPayload.Queries["RatingId"] = ExpressionConverter.Convert(ratingId);
                if (classificationId != null)
                    callPayload.Queries["ClassificationId"] = ExpressionConverter.Convert(classificationId);
                if (industryId != null)
                    callPayload.Queries["IndustryId"] = ExpressionConverter.Convert(industryId);
                if (accountSourceTypeId != null)
                    callPayload.Queries["AccountSourceTypeId"] = ExpressionConverter.Convert(accountSourceTypeId);
                if (primaryContactId != null)
                    callPayload.Queries["PrimaryContactId"] = ExpressionConverter.Convert(primaryContactId);
                if (assignedTeams != null)
                    callPayload.Queries["AssignedTeams"] = ExpressionConverter.Convert(assignedTeams);
                if (search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(search);
                if (name != null)
                    callPayload.Queries["Name"] = ExpressionConverter.Convert(name);
                if (id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
                if (page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(sort);
                return new ApiConnectionAction<CustomerApiFeaturesAccountsAccountDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [WorkflowExpressionFactory(nameof(__BuildAccountCreate))]
        public IBodyWorkflowAction<CustomerApiFeaturesAccountsAccountDTO> AccountCreate([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodycompanyId = null, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<string> bodytin = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodysourceId = null, [WorkflowExpression] Func<string> bodysourceParentId = null, [WorkflowExpression] Func<string> bodysourceOwnerId = null, [WorkflowExpression] Func<string[]> bodyprimaryContactIds = null, [WorkflowExpression] Func<string> bodyparentAccountId = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodyaddressaddress1 = null, [WorkflowExpression] Func<string> bodyaddressaddress2 = null, [WorkflowExpression] Func<string> bodyaddresscity = null, [WorkflowExpression] Func<string> bodyaddressstate = null, [WorkflowExpression] Func<string> bodyaddresslatitude = null, [WorkflowExpression] Func<string> bodyaddresslongtitude = null, [WorkflowExpression] Func<string> bodyaddresscountry = null, [WorkflowExpression] Func<string> bodyaddresscountryCode = null, [WorkflowExpression] Func<string> bodyaddresspostalCode = null, [WorkflowExpression] Func<string> bodyaddressfirstName = null, [WorkflowExpression] Func<string> bodyaddresslastName = null, [WorkflowExpression] Func<string> bodyaddressphoneNumber = null, [WorkflowExpression] Func<string> bodyaddressemail = null, [WorkflowExpression] Func<string> bodyupdateDate = null, [WorkflowExpression] Func<string> bodyinsertDate = null, [WorkflowExpression] Func<string> bodytaxOffice = null, [WorkflowExpression] Func<string> bodyaccountSourceTypeId = null, [WorkflowExpression] Func<string> bodyindustryId = null, [WorkflowExpression] Func<string> bodytierId = null, [WorkflowExpression] Func<string> bodywebsite = null, [WorkflowExpression] Func<string> bodyaccountDescription = null, [WorkflowExpression] Func<int> bodynoOfEmployees = null, [WorkflowExpression] Func<double> bodyannualRevenue = null, [WorkflowExpression] Func<string> bodycreatedBy = null, [WorkflowExpression] Func<string> bodylastModifiedBy = null, [WorkflowExpression] Func<string> bodyfax = null, [WorkflowExpression] Func<string> bodyownershipId = null, [WorkflowExpression] Func<string> bodyratingId = null, [WorkflowExpression] Func<string> bodyclassificationId = null, [WorkflowExpression] Func<string[]> bodyassignedTeams = null, [WorkflowExpression] Func<double> bodyaiScore = null, [WorkflowExpression] Func<string> bodyaiScoreReasoning = null, [WorkflowExpression] Func<bodyaiSentimentInput> bodyaiSentiment = null, [WorkflowExpression] Func<string> bodyaiGenerationDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CustomerApiFeaturesAccountsAccountDTO> __BuildAccountCreate(WorkflowExpression<string> bodyname, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodycompanyId = null, WorkflowExpression<string> bodycode = null, WorkflowExpression<string> bodytin = null, WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodyphone = null, WorkflowExpression<string> bodysourceId = null, WorkflowExpression<string> bodysourceParentId = null, WorkflowExpression<string> bodysourceOwnerId = null, WorkflowExpression<string[]> bodyprimaryContactIds = null, WorkflowExpression<string> bodyparentAccountId = null, WorkflowExpression<string> bodyownerId = null, WorkflowExpression<string> bodyaddressaddress1 = null, WorkflowExpression<string> bodyaddressaddress2 = null, WorkflowExpression<string> bodyaddresscity = null, WorkflowExpression<string> bodyaddressstate = null, WorkflowExpression<string> bodyaddresslatitude = null, WorkflowExpression<string> bodyaddresslongtitude = null, WorkflowExpression<string> bodyaddresscountry = null, WorkflowExpression<string> bodyaddresscountryCode = null, WorkflowExpression<string> bodyaddresspostalCode = null, WorkflowExpression<string> bodyaddressfirstName = null, WorkflowExpression<string> bodyaddresslastName = null, WorkflowExpression<string> bodyaddressphoneNumber = null, WorkflowExpression<string> bodyaddressemail = null, WorkflowExpression<string> bodyupdateDate = null, WorkflowExpression<string> bodyinsertDate = null, WorkflowExpression<string> bodytaxOffice = null, WorkflowExpression<string> bodyaccountSourceTypeId = null, WorkflowExpression<string> bodyindustryId = null, WorkflowExpression<string> bodytierId = null, WorkflowExpression<string> bodywebsite = null, WorkflowExpression<string> bodyaccountDescription = null, WorkflowExpression<int> bodynoOfEmployees = null, WorkflowExpression<double> bodyannualRevenue = null, WorkflowExpression<string> bodycreatedBy = null, WorkflowExpression<string> bodylastModifiedBy = null, WorkflowExpression<string> bodyfax = null, WorkflowExpression<string> bodyownershipId = null, WorkflowExpression<string> bodyratingId = null, WorkflowExpression<string> bodyclassificationId = null, WorkflowExpression<string[]> bodyassignedTeams = null, WorkflowExpression<double> bodyaiScore = null, WorkflowExpression<string> bodyaiScoreReasoning = null, WorkflowExpression<bodyaiSentimentInput> bodyaiSentiment = null, WorkflowExpression<string> bodyaiGenerationDate = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodycompanyId, nameof(bodycompanyId), required: false);
            WorkflowExpression.Validate(bodycode, nameof(bodycode), required: false);
            WorkflowExpression.Validate(bodytin, nameof(bodytin), required: false);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            WorkflowExpression.Validate(bodysourceId, nameof(bodysourceId), required: false);
            WorkflowExpression.Validate(bodysourceParentId, nameof(bodysourceParentId), required: false);
            WorkflowExpression.Validate(bodysourceOwnerId, nameof(bodysourceOwnerId), required: false);
            WorkflowExpression.Validate(bodyprimaryContactIds, nameof(bodyprimaryContactIds), required: false);
            WorkflowExpression.Validate(bodyparentAccountId, nameof(bodyparentAccountId), required: false);
            WorkflowExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            WorkflowExpression.Validate(bodyaddressaddress1, nameof(bodyaddressaddress1), required: false);
            WorkflowExpression.Validate(bodyaddressaddress2, nameof(bodyaddressaddress2), required: false);
            WorkflowExpression.Validate(bodyaddresscity, nameof(bodyaddresscity), required: false);
            WorkflowExpression.Validate(bodyaddressstate, nameof(bodyaddressstate), required: false);
            WorkflowExpression.Validate(bodyaddresslatitude, nameof(bodyaddresslatitude), required: false);
            WorkflowExpression.Validate(bodyaddresslongtitude, nameof(bodyaddresslongtitude), required: false);
            WorkflowExpression.Validate(bodyaddresscountry, nameof(bodyaddresscountry), required: false);
            WorkflowExpression.Validate(bodyaddresscountryCode, nameof(bodyaddresscountryCode), required: false);
            WorkflowExpression.Validate(bodyaddresspostalCode, nameof(bodyaddresspostalCode), required: false);
            WorkflowExpression.Validate(bodyaddressfirstName, nameof(bodyaddressfirstName), required: false);
            WorkflowExpression.Validate(bodyaddresslastName, nameof(bodyaddresslastName), required: false);
            WorkflowExpression.Validate(bodyaddressphoneNumber, nameof(bodyaddressphoneNumber), required: false);
            WorkflowExpression.Validate(bodyaddressemail, nameof(bodyaddressemail), required: false);
            WorkflowExpression.Validate(bodyupdateDate, nameof(bodyupdateDate), required: false);
            WorkflowExpression.Validate(bodyinsertDate, nameof(bodyinsertDate), required: false);
            WorkflowExpression.Validate(bodytaxOffice, nameof(bodytaxOffice), required: false);
            WorkflowExpression.Validate(bodyaccountSourceTypeId, nameof(bodyaccountSourceTypeId), required: false);
            WorkflowExpression.Validate(bodyindustryId, nameof(bodyindustryId), required: false);
            WorkflowExpression.Validate(bodytierId, nameof(bodytierId), required: false);
            WorkflowExpression.Validate(bodywebsite, nameof(bodywebsite), required: false);
            WorkflowExpression.Validate(bodyaccountDescription, nameof(bodyaccountDescription), required: false);
            WorkflowExpression.Validate(bodynoOfEmployees, nameof(bodynoOfEmployees), required: false);
            WorkflowExpression.Validate(bodyannualRevenue, nameof(bodyannualRevenue), required: false);
            WorkflowExpression.Validate(bodycreatedBy, nameof(bodycreatedBy), required: false);
            WorkflowExpression.Validate(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            WorkflowExpression.Validate(bodyfax, nameof(bodyfax), required: false);
            WorkflowExpression.Validate(bodyownershipId, nameof(bodyownershipId), required: false);
            WorkflowExpression.Validate(bodyratingId, nameof(bodyratingId), required: false);
            WorkflowExpression.Validate(bodyclassificationId, nameof(bodyclassificationId), required: false);
            WorkflowExpression.Validate(bodyassignedTeams, nameof(bodyassignedTeams), required: false);
            WorkflowExpression.Validate(bodyaiScore, nameof(bodyaiScore), required: false);
            WorkflowExpression.Validate(bodyaiScoreReasoning, nameof(bodyaiScoreReasoning), required: false);
            WorkflowExpression.Validate(bodyaiSentiment, nameof(bodyaiSentiment), required: false);
            WorkflowExpression.Validate(bodyaiGenerationDate, nameof(bodyaiGenerationDate), required: false);
            return new DeferredBodyAction<CustomerApiFeaturesAccountsAccountDTO>(() =>
            {
                var apiCallPath = "/api/Account";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                if (bodycompanyId != null)
                {
                    body["companyId"] = ExpressionConverter.ConvertO(bodycompanyId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodycode != null)
                {
                    body["code"] = ExpressionConverter.ConvertO(bodycode);
                    bodypropCount++;
                }

                if (bodytin != null)
                {
                    body["tin"] = ExpressionConverter.ConvertO(bodytin);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(bodyphone);
                    bodypropCount++;
                }

                if (bodysourceId != null)
                {
                    body["sourceId"] = ExpressionConverter.ConvertO(bodysourceId);
                    bodypropCount++;
                }

                if (bodysourceParentId != null)
                {
                    body["sourceParentId"] = ExpressionConverter.ConvertO(bodysourceParentId);
                    bodypropCount++;
                }

                if (bodysourceOwnerId != null)
                {
                    body["sourceOwnerId"] = ExpressionConverter.ConvertO(bodysourceOwnerId);
                    bodypropCount++;
                }

                if (bodyprimaryContactIds != null)
                {
                    body["primaryContactIds"] = ExpressionConverter.ConvertO(bodyprimaryContactIds);
                    bodypropCount++;
                }

                if (bodyparentAccountId != null)
                {
                    body["parentAccountId"] = ExpressionConverter.ConvertO(bodyparentAccountId);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["ownerId"] = ExpressionConverter.ConvertO(bodyownerId);
                    bodypropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (bodyaddressaddress1 != null)
                {
                    addressObject["address1"] = ExpressionConverter.ConvertO(bodyaddressaddress1);
                    addressObjectpropCount++;
                }

                if (bodyaddressaddress2 != null)
                {
                    addressObject["address2"] = ExpressionConverter.ConvertO(bodyaddressaddress2);
                    addressObjectpropCount++;
                }

                if (bodyaddresscity != null)
                {
                    addressObject["city"] = ExpressionConverter.ConvertO(bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (bodyaddressstate != null)
                {
                    addressObject["state"] = ExpressionConverter.ConvertO(bodyaddressstate);
                    addressObjectpropCount++;
                }

                if (bodyaddresslatitude != null)
                {
                    addressObject["latitude"] = ExpressionConverter.ConvertO(bodyaddresslatitude);
                    addressObjectpropCount++;
                }

                if (bodyaddresslongtitude != null)
                {
                    addressObject["longtitude"] = ExpressionConverter.ConvertO(bodyaddresslongtitude);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountry != null)
                {
                    addressObject["country"] = ExpressionConverter.ConvertO(bodyaddresscountry);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountryCode != null)
                {
                    addressObject["countryCode"] = ExpressionConverter.ConvertO(bodyaddresscountryCode);
                    addressObjectpropCount++;
                }

                if (bodyaddresspostalCode != null)
                {
                    addressObject["postalCode"] = ExpressionConverter.ConvertO(bodyaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (bodyaddressfirstName != null)
                {
                    addressObject["firstName"] = ExpressionConverter.ConvertO(bodyaddressfirstName);
                    addressObjectpropCount++;
                }

                if (bodyaddresslastName != null)
                {
                    addressObject["lastName"] = ExpressionConverter.ConvertO(bodyaddresslastName);
                    addressObjectpropCount++;
                }

                if (bodyaddressphoneNumber != null)
                {
                    addressObject["phoneNumber"] = ExpressionConverter.ConvertO(bodyaddressphoneNumber);
                    addressObjectpropCount++;
                }

                if (bodyaddressemail != null)
                {
                    addressObject["email"] = ExpressionConverter.ConvertO(bodyaddressemail);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                if (bodyupdateDate != null)
                {
                    body["updateDate"] = ExpressionConverter.ConvertO(bodyupdateDate);
                    bodypropCount++;
                }

                if (bodyinsertDate != null)
                {
                    body["insertDate"] = ExpressionConverter.ConvertO(bodyinsertDate);
                    bodypropCount++;
                }

                if (bodytaxOffice != null)
                {
                    body["taxOffice"] = ExpressionConverter.ConvertO(bodytaxOffice);
                    bodypropCount++;
                }

                if (bodyaccountSourceTypeId != null)
                {
                    body["accountSourceTypeId"] = ExpressionConverter.ConvertO(bodyaccountSourceTypeId);
                    bodypropCount++;
                }

                if (bodyindustryId != null)
                {
                    body["industryId"] = ExpressionConverter.ConvertO(bodyindustryId);
                    bodypropCount++;
                }

                if (bodytierId != null)
                {
                    body["tierId"] = ExpressionConverter.ConvertO(bodytierId);
                    bodypropCount++;
                }

                if (bodywebsite != null)
                {
                    body["website"] = ExpressionConverter.ConvertO(bodywebsite);
                    bodypropCount++;
                }

                if (bodyaccountDescription != null)
                {
                    body["accountDescription"] = ExpressionConverter.ConvertO(bodyaccountDescription);
                    bodypropCount++;
                }

                if (bodynoOfEmployees != null)
                {
                    body["noOfEmployees"] = ExpressionConverter.ConvertO(bodynoOfEmployees);
                    bodypropCount++;
                }

                if (bodyannualRevenue != null)
                {
                    body["annualRevenue"] = ExpressionConverter.ConvertO(bodyannualRevenue);
                    bodypropCount++;
                }

                if (bodycreatedBy != null)
                {
                    body["createdBy"] = ExpressionConverter.ConvertO(bodycreatedBy);
                    bodypropCount++;
                }

                if (bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = ExpressionConverter.ConvertO(bodylastModifiedBy);
                    bodypropCount++;
                }

                if (bodyfax != null)
                {
                    body["fax"] = ExpressionConverter.ConvertO(bodyfax);
                    bodypropCount++;
                }

                if (bodyownershipId != null)
                {
                    body["ownershipId"] = ExpressionConverter.ConvertO(bodyownershipId);
                    bodypropCount++;
                }

                if (bodyratingId != null)
                {
                    body["ratingId"] = ExpressionConverter.ConvertO(bodyratingId);
                    bodypropCount++;
                }

                if (bodyclassificationId != null)
                {
                    body["classificationId"] = ExpressionConverter.ConvertO(bodyclassificationId);
                    bodypropCount++;
                }

                var extraFieldsObject = new JObject();
                var extraFieldsObjectpropCount = 0;
                if (extraFieldsObjectpropCount > 0)
                {
                    body["extraFields"] = extraFieldsObject;
                    bodypropCount++;
                }

                if (bodyassignedTeams != null)
                {
                    body["assignedTeams"] = ExpressionConverter.ConvertO(bodyassignedTeams);
                    bodypropCount++;
                }

                if (bodyaiScore != null)
                {
                    body["aiScore"] = ExpressionConverter.ConvertO(bodyaiScore);
                    bodypropCount++;
                }

                if (bodyaiScoreReasoning != null)
                {
                    body["aiScoreReasoning"] = ExpressionConverter.ConvertO(bodyaiScoreReasoning);
                    bodypropCount++;
                }

                if (bodyaiSentiment != null)
                {
                    body["aiSentiment"] = ExpressionConverter.ConvertO(bodyaiSentiment);
                    bodypropCount++;
                }

                if (bodyaiGenerationDate != null)
                {
                    body["aiGenerationDate"] = ExpressionConverter.ConvertO(bodyaiGenerationDate);
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
        [WorkflowExpressionFactory(nameof(__BuildContactGetById))]
        public IBodyWorkflowAction<CustomerApiFeaturesContactsContact> ContactGetById([WorkflowExpression] Func<string> contactId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CustomerApiFeaturesContactsContact> __BuildContactGetById(WorkflowExpression<string> contactId)
        {
            WorkflowExpression.Validate(contactId, nameof(contactId), required: true);
            return new DeferredBodyAction<CustomerApiFeaturesContactsContact>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Contact/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CustomerApiFeaturesContactsContact>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [WorkflowExpressionFactory(nameof(__BuildContactDelete))]
        public IWorkflowAction ContactDelete([WorkflowExpression] Func<string> contactId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildContactDelete(WorkflowExpression<string> contactId)
        {
            WorkflowExpression.Validate(contactId, nameof(contactId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Contact/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [WorkflowExpressionFactory(nameof(__BuildContactUpdate))]
        public IBodyWorkflowAction<CustomerApiFeaturesContactsContactDTO> ContactUpdate([WorkflowExpression] Func<string> contactId, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string[]> bodyaccountIds = null, [WorkflowExpression] Func<string> bodysourceId = null, [WorkflowExpression] Func<string> bodysourceOwnerId = null, [WorkflowExpression] Func<string[]> bodysourceAccountIds = null, [WorkflowExpression] Func<string> bodynamefirstName = null, [WorkflowExpression] Func<string> bodynamelastName = null, [WorkflowExpression] Func<string> bodynamemiddleName = null, [WorkflowExpression] Func<string> bodynamesalutationId = null, [WorkflowExpression] Func<string> bodynamesuffix = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodymobilePhone = null, [WorkflowExpression] Func<string> bodyfax = null, [WorkflowExpression] Func<bool> bodycallOptOut = null, [WorkflowExpression] Func<bool> bodyemailOptOut = null, [WorkflowExpression] Func<CustomerApiFeaturesContactsEmailDTO[]> bodyotherEmail = null, [WorkflowExpression] Func<CustomerApiFeaturesContactsPhoneDTO[]> bodyotherPhone = null, [WorkflowExpression] Func<string> bodyjobTitle = null, [WorkflowExpression] Func<string> bodygenderId = null, [WorkflowExpression] Func<string> bodypronounceId = null, [WorkflowExpression] Func<string> bodyaddressaddress1 = null, [WorkflowExpression] Func<string> bodyaddressaddress2 = null, [WorkflowExpression] Func<string> bodyaddresscity = null, [WorkflowExpression] Func<string> bodyaddressstate = null, [WorkflowExpression] Func<string> bodyaddresslatitude = null, [WorkflowExpression] Func<string> bodyaddresslongtitude = null, [WorkflowExpression] Func<string> bodyaddresscountry = null, [WorkflowExpression] Func<string> bodyaddresscountryCode = null, [WorkflowExpression] Func<string> bodyaddresspostalCode = null, [WorkflowExpression] Func<string> bodyaddressfirstName = null, [WorkflowExpression] Func<string> bodyaddresslastName = null, [WorkflowExpression] Func<string> bodyaddressphoneNumber = null, [WorkflowExpression] Func<string> bodyaddressemail = null, [WorkflowExpression] Func<string> bodycreatedBy = null, [WorkflowExpression] Func<string> bodylastModifiedBy = null, [WorkflowExpression] Func<string> bodydepartment = null, [WorkflowExpression] Func<string> bodyreportsTo = null, [WorkflowExpression] Func<string> bodyassistant = null, [WorkflowExpression] Func<string> bodyassistantPhone = null, [WorkflowExpression] Func<string> bodybirthday = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodylastStayInTouchReportedDate = null, [WorkflowExpression] Func<string> bodylastStayInTouchSaveDate = null, [WorkflowExpression] Func<string> bodyaccountSourceTypeId = null, [WorkflowExpression] Func<string[]> bodyassignedTeams = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CustomerApiFeaturesContactsContactDTO> __BuildContactUpdate(WorkflowExpression<string> contactId, WorkflowExpression<string> bodyownerId = null, WorkflowExpression<string[]> bodyaccountIds = null, WorkflowExpression<string> bodysourceId = null, WorkflowExpression<string> bodysourceOwnerId = null, WorkflowExpression<string[]> bodysourceAccountIds = null, WorkflowExpression<string> bodynamefirstName = null, WorkflowExpression<string> bodynamelastName = null, WorkflowExpression<string> bodynamemiddleName = null, WorkflowExpression<string> bodynamesalutationId = null, WorkflowExpression<string> bodynamesuffix = null, WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodyphone = null, WorkflowExpression<string> bodymobilePhone = null, WorkflowExpression<string> bodyfax = null, WorkflowExpression<bool> bodycallOptOut = null, WorkflowExpression<bool> bodyemailOptOut = null, WorkflowExpression<CustomerApiFeaturesContactsEmailDTO[]> bodyotherEmail = null, WorkflowExpression<CustomerApiFeaturesContactsPhoneDTO[]> bodyotherPhone = null, WorkflowExpression<string> bodyjobTitle = null, WorkflowExpression<string> bodygenderId = null, WorkflowExpression<string> bodypronounceId = null, WorkflowExpression<string> bodyaddressaddress1 = null, WorkflowExpression<string> bodyaddressaddress2 = null, WorkflowExpression<string> bodyaddresscity = null, WorkflowExpression<string> bodyaddressstate = null, WorkflowExpression<string> bodyaddresslatitude = null, WorkflowExpression<string> bodyaddresslongtitude = null, WorkflowExpression<string> bodyaddresscountry = null, WorkflowExpression<string> bodyaddresscountryCode = null, WorkflowExpression<string> bodyaddresspostalCode = null, WorkflowExpression<string> bodyaddressfirstName = null, WorkflowExpression<string> bodyaddresslastName = null, WorkflowExpression<string> bodyaddressphoneNumber = null, WorkflowExpression<string> bodyaddressemail = null, WorkflowExpression<string> bodycreatedBy = null, WorkflowExpression<string> bodylastModifiedBy = null, WorkflowExpression<string> bodydepartment = null, WorkflowExpression<string> bodyreportsTo = null, WorkflowExpression<string> bodyassistant = null, WorkflowExpression<string> bodyassistantPhone = null, WorkflowExpression<string> bodybirthday = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodylastStayInTouchReportedDate = null, WorkflowExpression<string> bodylastStayInTouchSaveDate = null, WorkflowExpression<string> bodyaccountSourceTypeId = null, WorkflowExpression<string[]> bodyassignedTeams = null)
        {
            WorkflowExpression.Validate(contactId, nameof(contactId), required: true);
            WorkflowExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            WorkflowExpression.Validate(bodyaccountIds, nameof(bodyaccountIds), required: false);
            WorkflowExpression.Validate(bodysourceId, nameof(bodysourceId), required: false);
            WorkflowExpression.Validate(bodysourceOwnerId, nameof(bodysourceOwnerId), required: false);
            WorkflowExpression.Validate(bodysourceAccountIds, nameof(bodysourceAccountIds), required: false);
            WorkflowExpression.Validate(bodynamefirstName, nameof(bodynamefirstName), required: false);
            WorkflowExpression.Validate(bodynamelastName, nameof(bodynamelastName), required: false);
            WorkflowExpression.Validate(bodynamemiddleName, nameof(bodynamemiddleName), required: false);
            WorkflowExpression.Validate(bodynamesalutationId, nameof(bodynamesalutationId), required: false);
            WorkflowExpression.Validate(bodynamesuffix, nameof(bodynamesuffix), required: false);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            WorkflowExpression.Validate(bodymobilePhone, nameof(bodymobilePhone), required: false);
            WorkflowExpression.Validate(bodyfax, nameof(bodyfax), required: false);
            WorkflowExpression.Validate(bodycallOptOut, nameof(bodycallOptOut), required: false);
            WorkflowExpression.Validate(bodyemailOptOut, nameof(bodyemailOptOut), required: false);
            WorkflowExpression.Validate(bodyotherEmail, nameof(bodyotherEmail), required: false);
            WorkflowExpression.Validate(bodyotherPhone, nameof(bodyotherPhone), required: false);
            WorkflowExpression.Validate(bodyjobTitle, nameof(bodyjobTitle), required: false);
            WorkflowExpression.Validate(bodygenderId, nameof(bodygenderId), required: false);
            WorkflowExpression.Validate(bodypronounceId, nameof(bodypronounceId), required: false);
            WorkflowExpression.Validate(bodyaddressaddress1, nameof(bodyaddressaddress1), required: false);
            WorkflowExpression.Validate(bodyaddressaddress2, nameof(bodyaddressaddress2), required: false);
            WorkflowExpression.Validate(bodyaddresscity, nameof(bodyaddresscity), required: false);
            WorkflowExpression.Validate(bodyaddressstate, nameof(bodyaddressstate), required: false);
            WorkflowExpression.Validate(bodyaddresslatitude, nameof(bodyaddresslatitude), required: false);
            WorkflowExpression.Validate(bodyaddresslongtitude, nameof(bodyaddresslongtitude), required: false);
            WorkflowExpression.Validate(bodyaddresscountry, nameof(bodyaddresscountry), required: false);
            WorkflowExpression.Validate(bodyaddresscountryCode, nameof(bodyaddresscountryCode), required: false);
            WorkflowExpression.Validate(bodyaddresspostalCode, nameof(bodyaddresspostalCode), required: false);
            WorkflowExpression.Validate(bodyaddressfirstName, nameof(bodyaddressfirstName), required: false);
            WorkflowExpression.Validate(bodyaddresslastName, nameof(bodyaddresslastName), required: false);
            WorkflowExpression.Validate(bodyaddressphoneNumber, nameof(bodyaddressphoneNumber), required: false);
            WorkflowExpression.Validate(bodyaddressemail, nameof(bodyaddressemail), required: false);
            WorkflowExpression.Validate(bodycreatedBy, nameof(bodycreatedBy), required: false);
            WorkflowExpression.Validate(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            WorkflowExpression.Validate(bodydepartment, nameof(bodydepartment), required: false);
            WorkflowExpression.Validate(bodyreportsTo, nameof(bodyreportsTo), required: false);
            WorkflowExpression.Validate(bodyassistant, nameof(bodyassistant), required: false);
            WorkflowExpression.Validate(bodyassistantPhone, nameof(bodyassistantPhone), required: false);
            WorkflowExpression.Validate(bodybirthday, nameof(bodybirthday), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodylastStayInTouchReportedDate, nameof(bodylastStayInTouchReportedDate), required: false);
            WorkflowExpression.Validate(bodylastStayInTouchSaveDate, nameof(bodylastStayInTouchSaveDate), required: false);
            WorkflowExpression.Validate(bodyaccountSourceTypeId, nameof(bodyaccountSourceTypeId), required: false);
            WorkflowExpression.Validate(bodyassignedTeams, nameof(bodyassignedTeams), required: false);
            return new DeferredBodyAction<CustomerApiFeaturesContactsContactDTO>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Contact/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyownerId != null)
                {
                    body["ownerId"] = ExpressionConverter.ConvertO(bodyownerId);
                    bodypropCount++;
                }

                if (bodyaccountIds != null)
                {
                    body["accountIds"] = ExpressionConverter.ConvertO(bodyaccountIds);
                    bodypropCount++;
                }

                if (bodysourceId != null)
                {
                    body["sourceId"] = ExpressionConverter.ConvertO(bodysourceId);
                    bodypropCount++;
                }

                if (bodysourceOwnerId != null)
                {
                    body["sourceOwnerId"] = ExpressionConverter.ConvertO(bodysourceOwnerId);
                    bodypropCount++;
                }

                if (bodysourceAccountIds != null)
                {
                    body["sourceAccountIds"] = ExpressionConverter.ConvertO(bodysourceAccountIds);
                    bodypropCount++;
                }

                var nameObject = new JObject();
                var nameObjectpropCount = 0;
                if (bodynamefirstName != null)
                {
                    nameObject["firstName"] = ExpressionConverter.ConvertO(bodynamefirstName);
                    nameObjectpropCount++;
                }

                if (bodynamelastName != null)
                {
                    nameObject["lastName"] = ExpressionConverter.ConvertO(bodynamelastName);
                    nameObjectpropCount++;
                }

                if (bodynamemiddleName != null)
                {
                    nameObject["middleName"] = ExpressionConverter.ConvertO(bodynamemiddleName);
                    nameObjectpropCount++;
                }

                if (bodynamesalutationId != null)
                {
                    nameObject["salutationId"] = ExpressionConverter.ConvertO(bodynamesalutationId);
                    nameObjectpropCount++;
                }

                if (bodynamesuffix != null)
                {
                    nameObject["suffix"] = ExpressionConverter.ConvertO(bodynamesuffix);
                    nameObjectpropCount++;
                }

                if (nameObjectpropCount > 0)
                {
                    body["name"] = nameObject;
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(bodyphone);
                    bodypropCount++;
                }

                if (bodymobilePhone != null)
                {
                    body["mobilePhone"] = ExpressionConverter.ConvertO(bodymobilePhone);
                    bodypropCount++;
                }

                if (bodyfax != null)
                {
                    body["fax"] = ExpressionConverter.ConvertO(bodyfax);
                    bodypropCount++;
                }

                if (bodycallOptOut != null)
                {
                    body["callOptOut"] = ExpressionConverter.ConvertO(bodycallOptOut);
                    bodypropCount++;
                }

                if (bodyemailOptOut != null)
                {
                    body["emailOptOut"] = ExpressionConverter.ConvertO(bodyemailOptOut);
                    bodypropCount++;
                }

                if (bodyotherEmail != null)
                {
                    body["otherEmail"] = ExpressionConverter.ConvertO(bodyotherEmail);
                    bodypropCount++;
                }

                if (bodyotherPhone != null)
                {
                    body["otherPhone"] = ExpressionConverter.ConvertO(bodyotherPhone);
                    bodypropCount++;
                }

                if (bodyjobTitle != null)
                {
                    body["jobTitle"] = ExpressionConverter.ConvertO(bodyjobTitle);
                    bodypropCount++;
                }

                if (bodygenderId != null)
                {
                    body["genderId"] = ExpressionConverter.ConvertO(bodygenderId);
                    bodypropCount++;
                }

                if (bodypronounceId != null)
                {
                    body["pronounceId"] = ExpressionConverter.ConvertO(bodypronounceId);
                    bodypropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (bodyaddressaddress1 != null)
                {
                    addressObject["address1"] = ExpressionConverter.ConvertO(bodyaddressaddress1);
                    addressObjectpropCount++;
                }

                if (bodyaddressaddress2 != null)
                {
                    addressObject["address2"] = ExpressionConverter.ConvertO(bodyaddressaddress2);
                    addressObjectpropCount++;
                }

                if (bodyaddresscity != null)
                {
                    addressObject["city"] = ExpressionConverter.ConvertO(bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (bodyaddressstate != null)
                {
                    addressObject["state"] = ExpressionConverter.ConvertO(bodyaddressstate);
                    addressObjectpropCount++;
                }

                if (bodyaddresslatitude != null)
                {
                    addressObject["latitude"] = ExpressionConverter.ConvertO(bodyaddresslatitude);
                    addressObjectpropCount++;
                }

                if (bodyaddresslongtitude != null)
                {
                    addressObject["longtitude"] = ExpressionConverter.ConvertO(bodyaddresslongtitude);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountry != null)
                {
                    addressObject["country"] = ExpressionConverter.ConvertO(bodyaddresscountry);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountryCode != null)
                {
                    addressObject["countryCode"] = ExpressionConverter.ConvertO(bodyaddresscountryCode);
                    addressObjectpropCount++;
                }

                if (bodyaddresspostalCode != null)
                {
                    addressObject["postalCode"] = ExpressionConverter.ConvertO(bodyaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (bodyaddressfirstName != null)
                {
                    addressObject["firstName"] = ExpressionConverter.ConvertO(bodyaddressfirstName);
                    addressObjectpropCount++;
                }

                if (bodyaddresslastName != null)
                {
                    addressObject["lastName"] = ExpressionConverter.ConvertO(bodyaddresslastName);
                    addressObjectpropCount++;
                }

                if (bodyaddressphoneNumber != null)
                {
                    addressObject["phoneNumber"] = ExpressionConverter.ConvertO(bodyaddressphoneNumber);
                    addressObjectpropCount++;
                }

                if (bodyaddressemail != null)
                {
                    addressObject["email"] = ExpressionConverter.ConvertO(bodyaddressemail);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                if (bodycreatedBy != null)
                {
                    body["createdBy"] = ExpressionConverter.ConvertO(bodycreatedBy);
                    bodypropCount++;
                }

                if (bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = ExpressionConverter.ConvertO(bodylastModifiedBy);
                    bodypropCount++;
                }

                if (bodydepartment != null)
                {
                    body["department"] = ExpressionConverter.ConvertO(bodydepartment);
                    bodypropCount++;
                }

                if (bodyreportsTo != null)
                {
                    body["reportsTo"] = ExpressionConverter.ConvertO(bodyreportsTo);
                    bodypropCount++;
                }

                if (bodyassistant != null)
                {
                    body["assistant"] = ExpressionConverter.ConvertO(bodyassistant);
                    bodypropCount++;
                }

                if (bodyassistantPhone != null)
                {
                    body["assistantPhone"] = ExpressionConverter.ConvertO(bodyassistantPhone);
                    bodypropCount++;
                }

                if (bodybirthday != null)
                {
                    body["birthday"] = ExpressionConverter.ConvertO(bodybirthday);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodylastStayInTouchReportedDate != null)
                {
                    body["lastStayInTouchReportedDate"] = ExpressionConverter.ConvertO(bodylastStayInTouchReportedDate);
                    bodypropCount++;
                }

                if (bodylastStayInTouchSaveDate != null)
                {
                    body["lastStayInTouchSaveDate"] = ExpressionConverter.ConvertO(bodylastStayInTouchSaveDate);
                    bodypropCount++;
                }

                if (bodyaccountSourceTypeId != null)
                {
                    body["accountSourceTypeId"] = ExpressionConverter.ConvertO(bodyaccountSourceTypeId);
                    bodypropCount++;
                }

                var extraFieldsObject = new JObject();
                var extraFieldsObjectpropCount = 0;
                if (extraFieldsObjectpropCount > 0)
                {
                    body["extraFields"] = extraFieldsObject;
                    bodypropCount++;
                }

                if (bodyassignedTeams != null)
                {
                    body["assignedTeams"] = ExpressionConverter.ConvertO(bodyassignedTeams);
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
        [WorkflowExpressionFactory(nameof(__BuildContactGetAll))]
        public IBodyWorkflowAction<CustomerApiFeaturesContactsContactDTO[]> ContactGetAll([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> ownerId = null, [WorkflowExpression] Func<string> suggestions = null, [WorkflowExpression] Func<string> accountSourceTypeId = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> lastName = null, [WorkflowExpression] Func<string> phone = null, [WorkflowExpression] Func<string> mobilePhone = null, [WorkflowExpression] Func<string> accountIds = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> assignedTeams = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CustomerApiFeaturesContactsContactDTO[]> __BuildContactGetAll(WorkflowExpression<string> name = null, WorkflowExpression<string> ownerId = null, WorkflowExpression<string> suggestions = null, WorkflowExpression<string> accountSourceTypeId = null, WorkflowExpression<string> firstName = null, WorkflowExpression<string> lastName = null, WorkflowExpression<string> phone = null, WorkflowExpression<string> mobilePhone = null, WorkflowExpression<string> accountIds = null, WorkflowExpression<string> email = null, WorkflowExpression<string> id = null, WorkflowExpression<string> assignedTeams = null, WorkflowExpression<string> search = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sort = null)
        {
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(ownerId, nameof(ownerId), required: false);
            WorkflowExpression.Validate(suggestions, nameof(suggestions), required: false);
            WorkflowExpression.Validate(accountSourceTypeId, nameof(accountSourceTypeId), required: false);
            WorkflowExpression.Validate(firstName, nameof(firstName), required: false);
            WorkflowExpression.Validate(lastName, nameof(lastName), required: false);
            WorkflowExpression.Validate(phone, nameof(phone), required: false);
            WorkflowExpression.Validate(mobilePhone, nameof(mobilePhone), required: false);
            WorkflowExpression.Validate(accountIds, nameof(accountIds), required: false);
            WorkflowExpression.Validate(email, nameof(email), required: false);
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(assignedTeams, nameof(assignedTeams), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<CustomerApiFeaturesContactsContactDTO[]>(() =>
            {
                var apiCallPath = "/api/Contact";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["Name"] = ExpressionConverter.Convert(name);
                if (ownerId != null)
                    callPayload.Queries["OwnerId"] = ExpressionConverter.Convert(ownerId);
                if (suggestions != null)
                    callPayload.Queries["Suggestions"] = ExpressionConverter.Convert(suggestions);
                if (accountSourceTypeId != null)
                    callPayload.Queries["AccountSourceTypeId"] = ExpressionConverter.Convert(accountSourceTypeId);
                if (firstName != null)
                    callPayload.Queries["FirstName"] = ExpressionConverter.Convert(firstName);
                if (lastName != null)
                    callPayload.Queries["LastName"] = ExpressionConverter.Convert(lastName);
                if (phone != null)
                    callPayload.Queries["Phone"] = ExpressionConverter.Convert(phone);
                if (mobilePhone != null)
                    callPayload.Queries["MobilePhone"] = ExpressionConverter.Convert(mobilePhone);
                if (accountIds != null)
                    callPayload.Queries["AccountIds"] = ExpressionConverter.Convert(accountIds);
                if (email != null)
                    callPayload.Queries["Email"] = ExpressionConverter.Convert(email);
                if (id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
                if (assignedTeams != null)
                    callPayload.Queries["AssignedTeams"] = ExpressionConverter.Convert(assignedTeams);
                if (search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(search);
                if (page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(sort);
                return new ApiConnectionAction<CustomerApiFeaturesContactsContactDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [WorkflowExpressionFactory(nameof(__BuildContactCreate))]
        public IBodyWorkflowAction<CustomerApiFeaturesContactsContactDTO> ContactCreate([WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodycompanyId = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string[]> bodyaccountIds = null, [WorkflowExpression] Func<string> bodysourceId = null, [WorkflowExpression] Func<string> bodysourceOwnerId = null, [WorkflowExpression] Func<string[]> bodysourceAccountIds = null, [WorkflowExpression] Func<string> bodynamefirstName = null, [WorkflowExpression] Func<string> bodynamelastName = null, [WorkflowExpression] Func<string> bodynamemiddleName = null, [WorkflowExpression] Func<string> bodynamesalutationId = null, [WorkflowExpression] Func<string> bodynamesuffix = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodymobilePhone = null, [WorkflowExpression] Func<string> bodyfax = null, [WorkflowExpression] Func<bool> bodycallOptOut = null, [WorkflowExpression] Func<bool> bodyemailOptOut = null, [WorkflowExpression] Func<CustomerApiFeaturesContactsEmailDTO[]> bodyotherEmail = null, [WorkflowExpression] Func<CustomerApiFeaturesContactsPhoneDTO[]> bodyotherPhone = null, [WorkflowExpression] Func<string> bodyjobTitle = null, [WorkflowExpression] Func<string> bodygenderId = null, [WorkflowExpression] Func<string> bodypronounceId = null, [WorkflowExpression] Func<string> bodyaddressaddress1 = null, [WorkflowExpression] Func<string> bodyaddressaddress2 = null, [WorkflowExpression] Func<string> bodyaddresscity = null, [WorkflowExpression] Func<string> bodyaddressstate = null, [WorkflowExpression] Func<string> bodyaddresslatitude = null, [WorkflowExpression] Func<string> bodyaddresslongtitude = null, [WorkflowExpression] Func<string> bodyaddresscountry = null, [WorkflowExpression] Func<string> bodyaddresscountryCode = null, [WorkflowExpression] Func<string> bodyaddresspostalCode = null, [WorkflowExpression] Func<string> bodyaddressfirstName = null, [WorkflowExpression] Func<string> bodyaddresslastName = null, [WorkflowExpression] Func<string> bodyaddressphoneNumber = null, [WorkflowExpression] Func<string> bodyaddressemail = null, [WorkflowExpression] Func<string> bodyinsertDate = null, [WorkflowExpression] Func<string> bodyupdateDate = null, [WorkflowExpression] Func<string> bodycreatedBy = null, [WorkflowExpression] Func<string> bodylastModifiedBy = null, [WorkflowExpression] Func<string> bodydepartment = null, [WorkflowExpression] Func<string> bodyreportsTo = null, [WorkflowExpression] Func<string> bodyassistant = null, [WorkflowExpression] Func<string> bodyassistantPhone = null, [WorkflowExpression] Func<string> bodybirthday = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodylastStayInTouchReportedDate = null, [WorkflowExpression] Func<string> bodylastStayInTouchSaveDate = null, [WorkflowExpression] Func<string> bodyaccountSourceTypeId = null, [WorkflowExpression] Func<string> bodyfullName = null, [WorkflowExpression] Func<string[]> bodyassignedTeams = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CustomerApiFeaturesContactsContactDTO> __BuildContactCreate(WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodycompanyId = null, WorkflowExpression<string> bodyownerId = null, WorkflowExpression<string[]> bodyaccountIds = null, WorkflowExpression<string> bodysourceId = null, WorkflowExpression<string> bodysourceOwnerId = null, WorkflowExpression<string[]> bodysourceAccountIds = null, WorkflowExpression<string> bodynamefirstName = null, WorkflowExpression<string> bodynamelastName = null, WorkflowExpression<string> bodynamemiddleName = null, WorkflowExpression<string> bodynamesalutationId = null, WorkflowExpression<string> bodynamesuffix = null, WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodyphone = null, WorkflowExpression<string> bodymobilePhone = null, WorkflowExpression<string> bodyfax = null, WorkflowExpression<bool> bodycallOptOut = null, WorkflowExpression<bool> bodyemailOptOut = null, WorkflowExpression<CustomerApiFeaturesContactsEmailDTO[]> bodyotherEmail = null, WorkflowExpression<CustomerApiFeaturesContactsPhoneDTO[]> bodyotherPhone = null, WorkflowExpression<string> bodyjobTitle = null, WorkflowExpression<string> bodygenderId = null, WorkflowExpression<string> bodypronounceId = null, WorkflowExpression<string> bodyaddressaddress1 = null, WorkflowExpression<string> bodyaddressaddress2 = null, WorkflowExpression<string> bodyaddresscity = null, WorkflowExpression<string> bodyaddressstate = null, WorkflowExpression<string> bodyaddresslatitude = null, WorkflowExpression<string> bodyaddresslongtitude = null, WorkflowExpression<string> bodyaddresscountry = null, WorkflowExpression<string> bodyaddresscountryCode = null, WorkflowExpression<string> bodyaddresspostalCode = null, WorkflowExpression<string> bodyaddressfirstName = null, WorkflowExpression<string> bodyaddresslastName = null, WorkflowExpression<string> bodyaddressphoneNumber = null, WorkflowExpression<string> bodyaddressemail = null, WorkflowExpression<string> bodyinsertDate = null, WorkflowExpression<string> bodyupdateDate = null, WorkflowExpression<string> bodycreatedBy = null, WorkflowExpression<string> bodylastModifiedBy = null, WorkflowExpression<string> bodydepartment = null, WorkflowExpression<string> bodyreportsTo = null, WorkflowExpression<string> bodyassistant = null, WorkflowExpression<string> bodyassistantPhone = null, WorkflowExpression<string> bodybirthday = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodylastStayInTouchReportedDate = null, WorkflowExpression<string> bodylastStayInTouchSaveDate = null, WorkflowExpression<string> bodyaccountSourceTypeId = null, WorkflowExpression<string> bodyfullName = null, WorkflowExpression<string[]> bodyassignedTeams = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodycompanyId, nameof(bodycompanyId), required: false);
            WorkflowExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            WorkflowExpression.Validate(bodyaccountIds, nameof(bodyaccountIds), required: false);
            WorkflowExpression.Validate(bodysourceId, nameof(bodysourceId), required: false);
            WorkflowExpression.Validate(bodysourceOwnerId, nameof(bodysourceOwnerId), required: false);
            WorkflowExpression.Validate(bodysourceAccountIds, nameof(bodysourceAccountIds), required: false);
            WorkflowExpression.Validate(bodynamefirstName, nameof(bodynamefirstName), required: false);
            WorkflowExpression.Validate(bodynamelastName, nameof(bodynamelastName), required: false);
            WorkflowExpression.Validate(bodynamemiddleName, nameof(bodynamemiddleName), required: false);
            WorkflowExpression.Validate(bodynamesalutationId, nameof(bodynamesalutationId), required: false);
            WorkflowExpression.Validate(bodynamesuffix, nameof(bodynamesuffix), required: false);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            WorkflowExpression.Validate(bodymobilePhone, nameof(bodymobilePhone), required: false);
            WorkflowExpression.Validate(bodyfax, nameof(bodyfax), required: false);
            WorkflowExpression.Validate(bodycallOptOut, nameof(bodycallOptOut), required: false);
            WorkflowExpression.Validate(bodyemailOptOut, nameof(bodyemailOptOut), required: false);
            WorkflowExpression.Validate(bodyotherEmail, nameof(bodyotherEmail), required: false);
            WorkflowExpression.Validate(bodyotherPhone, nameof(bodyotherPhone), required: false);
            WorkflowExpression.Validate(bodyjobTitle, nameof(bodyjobTitle), required: false);
            WorkflowExpression.Validate(bodygenderId, nameof(bodygenderId), required: false);
            WorkflowExpression.Validate(bodypronounceId, nameof(bodypronounceId), required: false);
            WorkflowExpression.Validate(bodyaddressaddress1, nameof(bodyaddressaddress1), required: false);
            WorkflowExpression.Validate(bodyaddressaddress2, nameof(bodyaddressaddress2), required: false);
            WorkflowExpression.Validate(bodyaddresscity, nameof(bodyaddresscity), required: false);
            WorkflowExpression.Validate(bodyaddressstate, nameof(bodyaddressstate), required: false);
            WorkflowExpression.Validate(bodyaddresslatitude, nameof(bodyaddresslatitude), required: false);
            WorkflowExpression.Validate(bodyaddresslongtitude, nameof(bodyaddresslongtitude), required: false);
            WorkflowExpression.Validate(bodyaddresscountry, nameof(bodyaddresscountry), required: false);
            WorkflowExpression.Validate(bodyaddresscountryCode, nameof(bodyaddresscountryCode), required: false);
            WorkflowExpression.Validate(bodyaddresspostalCode, nameof(bodyaddresspostalCode), required: false);
            WorkflowExpression.Validate(bodyaddressfirstName, nameof(bodyaddressfirstName), required: false);
            WorkflowExpression.Validate(bodyaddresslastName, nameof(bodyaddresslastName), required: false);
            WorkflowExpression.Validate(bodyaddressphoneNumber, nameof(bodyaddressphoneNumber), required: false);
            WorkflowExpression.Validate(bodyaddressemail, nameof(bodyaddressemail), required: false);
            WorkflowExpression.Validate(bodyinsertDate, nameof(bodyinsertDate), required: false);
            WorkflowExpression.Validate(bodyupdateDate, nameof(bodyupdateDate), required: false);
            WorkflowExpression.Validate(bodycreatedBy, nameof(bodycreatedBy), required: false);
            WorkflowExpression.Validate(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            WorkflowExpression.Validate(bodydepartment, nameof(bodydepartment), required: false);
            WorkflowExpression.Validate(bodyreportsTo, nameof(bodyreportsTo), required: false);
            WorkflowExpression.Validate(bodyassistant, nameof(bodyassistant), required: false);
            WorkflowExpression.Validate(bodyassistantPhone, nameof(bodyassistantPhone), required: false);
            WorkflowExpression.Validate(bodybirthday, nameof(bodybirthday), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodylastStayInTouchReportedDate, nameof(bodylastStayInTouchReportedDate), required: false);
            WorkflowExpression.Validate(bodylastStayInTouchSaveDate, nameof(bodylastStayInTouchSaveDate), required: false);
            WorkflowExpression.Validate(bodyaccountSourceTypeId, nameof(bodyaccountSourceTypeId), required: false);
            WorkflowExpression.Validate(bodyfullName, nameof(bodyfullName), required: false);
            WorkflowExpression.Validate(bodyassignedTeams, nameof(bodyassignedTeams), required: false);
            return new DeferredBodyAction<CustomerApiFeaturesContactsContactDTO>(() =>
            {
                var apiCallPath = "/api/Contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                if (bodycompanyId != null)
                {
                    body["companyId"] = ExpressionConverter.ConvertO(bodycompanyId);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["ownerId"] = ExpressionConverter.ConvertO(bodyownerId);
                    bodypropCount++;
                }

                if (bodyaccountIds != null)
                {
                    body["accountIds"] = ExpressionConverter.ConvertO(bodyaccountIds);
                    bodypropCount++;
                }

                if (bodysourceId != null)
                {
                    body["sourceId"] = ExpressionConverter.ConvertO(bodysourceId);
                    bodypropCount++;
                }

                if (bodysourceOwnerId != null)
                {
                    body["sourceOwnerId"] = ExpressionConverter.ConvertO(bodysourceOwnerId);
                    bodypropCount++;
                }

                if (bodysourceAccountIds != null)
                {
                    body["sourceAccountIds"] = ExpressionConverter.ConvertO(bodysourceAccountIds);
                    bodypropCount++;
                }

                var nameObject = new JObject();
                var nameObjectpropCount = 0;
                if (bodynamefirstName != null)
                {
                    nameObject["firstName"] = ExpressionConverter.ConvertO(bodynamefirstName);
                    nameObjectpropCount++;
                }

                if (bodynamelastName != null)
                {
                    nameObject["lastName"] = ExpressionConverter.ConvertO(bodynamelastName);
                    nameObjectpropCount++;
                }

                if (bodynamemiddleName != null)
                {
                    nameObject["middleName"] = ExpressionConverter.ConvertO(bodynamemiddleName);
                    nameObjectpropCount++;
                }

                if (bodynamesalutationId != null)
                {
                    nameObject["salutationId"] = ExpressionConverter.ConvertO(bodynamesalutationId);
                    nameObjectpropCount++;
                }

                if (bodynamesuffix != null)
                {
                    nameObject["suffix"] = ExpressionConverter.ConvertO(bodynamesuffix);
                    nameObjectpropCount++;
                }

                if (nameObjectpropCount > 0)
                {
                    body["name"] = nameObject;
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(bodyphone);
                    bodypropCount++;
                }

                if (bodymobilePhone != null)
                {
                    body["mobilePhone"] = ExpressionConverter.ConvertO(bodymobilePhone);
                    bodypropCount++;
                }

                if (bodyfax != null)
                {
                    body["fax"] = ExpressionConverter.ConvertO(bodyfax);
                    bodypropCount++;
                }

                if (bodycallOptOut != null)
                {
                    body["callOptOut"] = ExpressionConverter.ConvertO(bodycallOptOut);
                    bodypropCount++;
                }

                if (bodyemailOptOut != null)
                {
                    body["emailOptOut"] = ExpressionConverter.ConvertO(bodyemailOptOut);
                    bodypropCount++;
                }

                if (bodyotherEmail != null)
                {
                    body["otherEmail"] = ExpressionConverter.ConvertO(bodyotherEmail);
                    bodypropCount++;
                }

                if (bodyotherPhone != null)
                {
                    body["otherPhone"] = ExpressionConverter.ConvertO(bodyotherPhone);
                    bodypropCount++;
                }

                if (bodyjobTitle != null)
                {
                    body["jobTitle"] = ExpressionConverter.ConvertO(bodyjobTitle);
                    bodypropCount++;
                }

                if (bodygenderId != null)
                {
                    body["genderId"] = ExpressionConverter.ConvertO(bodygenderId);
                    bodypropCount++;
                }

                if (bodypronounceId != null)
                {
                    body["pronounceId"] = ExpressionConverter.ConvertO(bodypronounceId);
                    bodypropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (bodyaddressaddress1 != null)
                {
                    addressObject["address1"] = ExpressionConverter.ConvertO(bodyaddressaddress1);
                    addressObjectpropCount++;
                }

                if (bodyaddressaddress2 != null)
                {
                    addressObject["address2"] = ExpressionConverter.ConvertO(bodyaddressaddress2);
                    addressObjectpropCount++;
                }

                if (bodyaddresscity != null)
                {
                    addressObject["city"] = ExpressionConverter.ConvertO(bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (bodyaddressstate != null)
                {
                    addressObject["state"] = ExpressionConverter.ConvertO(bodyaddressstate);
                    addressObjectpropCount++;
                }

                if (bodyaddresslatitude != null)
                {
                    addressObject["latitude"] = ExpressionConverter.ConvertO(bodyaddresslatitude);
                    addressObjectpropCount++;
                }

                if (bodyaddresslongtitude != null)
                {
                    addressObject["longtitude"] = ExpressionConverter.ConvertO(bodyaddresslongtitude);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountry != null)
                {
                    addressObject["country"] = ExpressionConverter.ConvertO(bodyaddresscountry);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountryCode != null)
                {
                    addressObject["countryCode"] = ExpressionConverter.ConvertO(bodyaddresscountryCode);
                    addressObjectpropCount++;
                }

                if (bodyaddresspostalCode != null)
                {
                    addressObject["postalCode"] = ExpressionConverter.ConvertO(bodyaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (bodyaddressfirstName != null)
                {
                    addressObject["firstName"] = ExpressionConverter.ConvertO(bodyaddressfirstName);
                    addressObjectpropCount++;
                }

                if (bodyaddresslastName != null)
                {
                    addressObject["lastName"] = ExpressionConverter.ConvertO(bodyaddresslastName);
                    addressObjectpropCount++;
                }

                if (bodyaddressphoneNumber != null)
                {
                    addressObject["phoneNumber"] = ExpressionConverter.ConvertO(bodyaddressphoneNumber);
                    addressObjectpropCount++;
                }

                if (bodyaddressemail != null)
                {
                    addressObject["email"] = ExpressionConverter.ConvertO(bodyaddressemail);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                if (bodyinsertDate != null)
                {
                    body["insertDate"] = ExpressionConverter.ConvertO(bodyinsertDate);
                    bodypropCount++;
                }

                if (bodyupdateDate != null)
                {
                    body["updateDate"] = ExpressionConverter.ConvertO(bodyupdateDate);
                    bodypropCount++;
                }

                if (bodycreatedBy != null)
                {
                    body["createdBy"] = ExpressionConverter.ConvertO(bodycreatedBy);
                    bodypropCount++;
                }

                if (bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = ExpressionConverter.ConvertO(bodylastModifiedBy);
                    bodypropCount++;
                }

                if (bodydepartment != null)
                {
                    body["department"] = ExpressionConverter.ConvertO(bodydepartment);
                    bodypropCount++;
                }

                if (bodyreportsTo != null)
                {
                    body["reportsTo"] = ExpressionConverter.ConvertO(bodyreportsTo);
                    bodypropCount++;
                }

                if (bodyassistant != null)
                {
                    body["assistant"] = ExpressionConverter.ConvertO(bodyassistant);
                    bodypropCount++;
                }

                if (bodyassistantPhone != null)
                {
                    body["assistantPhone"] = ExpressionConverter.ConvertO(bodyassistantPhone);
                    bodypropCount++;
                }

                if (bodybirthday != null)
                {
                    body["birthday"] = ExpressionConverter.ConvertO(bodybirthday);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodylastStayInTouchReportedDate != null)
                {
                    body["lastStayInTouchReportedDate"] = ExpressionConverter.ConvertO(bodylastStayInTouchReportedDate);
                    bodypropCount++;
                }

                if (bodylastStayInTouchSaveDate != null)
                {
                    body["lastStayInTouchSaveDate"] = ExpressionConverter.ConvertO(bodylastStayInTouchSaveDate);
                    bodypropCount++;
                }

                if (bodyaccountSourceTypeId != null)
                {
                    body["accountSourceTypeId"] = ExpressionConverter.ConvertO(bodyaccountSourceTypeId);
                    bodypropCount++;
                }

                if (bodyfullName != null)
                {
                    body["fullName"] = ExpressionConverter.ConvertO(bodyfullName);
                    bodypropCount++;
                }

                var extraFieldsObject = new JObject();
                var extraFieldsObjectpropCount = 0;
                if (extraFieldsObjectpropCount > 0)
                {
                    body["extraFields"] = extraFieldsObject;
                    bodypropCount++;
                }

                if (bodyassignedTeams != null)
                {
                    body["assignedTeams"] = ExpressionConverter.ConvertO(bodyassignedTeams);
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

        [WorkflowExpressionFactory(nameof(__BuildCallCreated))]
        public IWorkflowTrigger CallCreated([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCallCreated(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/WebHook/register/call/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOpportunityUpdated))]
        public IWorkflowTrigger OpportunityUpdated([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildOpportunityUpdated(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/WebHook/register/opportunity/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOpportunityDeleted))]
        public IWorkflowTrigger OpportunityDeleted([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildOpportunityDeleted(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/WebHook/register/opportunity/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOpportunityCreated))]
        public IWorkflowTrigger OpportunityCreated([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildOpportunityCreated(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/WebHook/register/opportunity/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildLeadUpdated))]
        public IWorkflowTrigger LeadUpdated([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildLeadUpdated(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/WebHook/register/lead/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildLeadDeleted))]
        public IWorkflowTrigger LeadDeleted([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildLeadDeleted(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/WebHook/register/lead/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildLeadCreated))]
        public IWorkflowTrigger LeadCreated([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildLeadCreated(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/WebHook/register/lead/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildTaskUpdated))]
        public IWorkflowTrigger TaskUpdated([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildTaskUpdated(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/WebHook/register/task/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildTaskDeleted))]
        public IWorkflowTrigger TaskDeleted([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildTaskDeleted(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/WebHook/register/task/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildTaskCreated))]
        public IWorkflowTrigger TaskCreated([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildTaskCreated(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/WebHook/register/task/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildEventUpdated))]
        public IWorkflowTrigger EventUpdated([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildEventUpdated(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/WebHook/register/event/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildEventDeleted))]
        public IWorkflowTrigger EventDeleted([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildEventDeleted(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/WebHook/register/event/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildEventCreated))]
        public IWorkflowTrigger EventCreated([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildEventCreated(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/WebHook/register/event/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCallDeleted))]
        public IWorkflowTrigger CallDeleted([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCallDeleted(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/WebHook/register/call/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCallUpdated))]
        public IWorkflowTrigger CallUpdated([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCallUpdated(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/WebHook/register/call/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
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