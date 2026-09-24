//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Softonewebcrm
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SoftonewebcrmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesCallsCallDTO[]> CallGetAll([WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<string> priorityId = null, [WorkflowExpression] Func<string> createdBy = null, [WorkflowExpression] Func<string> lastModifiedBy = null, [WorkflowExpression] Func<string> dueDate = null, [WorkflowExpression] Func<string> sortDate = null, [WorkflowExpression] Func<string> assignedToId = null, [WorkflowExpression] Func<string> relatedToId = null, [WorkflowExpression] Func<string> callResultId = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(priorityId, nameof(priorityId), required: false);
            SourceExpression.Validate(createdBy, nameof(createdBy), required: false);
            SourceExpression.Validate(lastModifiedBy, nameof(lastModifiedBy), required: false);
            SourceExpression.Validate(dueDate, nameof(dueDate), required: false);
            SourceExpression.Validate(sortDate, nameof(sortDate), required: false);
            SourceExpression.Validate(assignedToId, nameof(assignedToId), required: false);
            SourceExpression.Validate(relatedToId, nameof(relatedToId), required: false);
            SourceExpression.Validate(callResultId, nameof(callResultId), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/task/Call";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["Id"] = SourceExpressionConverter.ConvertO(id);
                if (status != null)
                    callPayload.Queries["Status"] = SourceExpressionConverter.Convert(status);
                if (priorityId != null)
                    callPayload.Queries["PriorityId"] = SourceExpressionConverter.ConvertO(priorityId);
                if (createdBy != null)
                    callPayload.Queries["CreatedBy"] = SourceExpressionConverter.ConvertO(createdBy);
                if (lastModifiedBy != null)
                    callPayload.Queries["LastModifiedBy"] = SourceExpressionConverter.ConvertO(lastModifiedBy);
                if (dueDate != null)
                    callPayload.Queries["DueDate"] = SourceExpressionConverter.ConvertO(dueDate);
                if (sortDate != null)
                    callPayload.Queries["SortDate"] = SourceExpressionConverter.ConvertO(sortDate);
                if (assignedToId != null)
                    callPayload.Queries["AssignedToId"] = SourceExpressionConverter.ConvertO(assignedToId);
                if (relatedToId != null)
                    callPayload.Queries["RelatedToId"] = SourceExpressionConverter.ConvertO(relatedToId);
                if (callResultId != null)
                    callPayload.Queries["CallResultId"] = SourceExpressionConverter.ConvertO(callResultId);
                if (search != null)
                    callPayload.Queries["Search"] = SourceExpressionConverter.ConvertO(search);
                if (page != null)
                    callPayload.Queries["Page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<TaskApiFeaturesCallsCallDTO[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesCallsCallDTO> CallCreate([WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<bodyassignedToTypeInput> bodyassignedToType = null, [WorkflowExpression] Func<string> bodyassignedToId = null, [WorkflowExpression] Func<bodyrelatedToTypeInput> bodyrelatedToType = null, [WorkflowExpression] Func<string> bodyrelatedToId = null, [WorkflowExpression] Func<bodycontactTypeInput> bodycontactType = null, [WorkflowExpression] Func<string[]> bodycontactIds = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodycallDuration = null, [WorkflowExpression] Func<string> bodycallResultId = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodyeditorBody = null, [WorkflowExpression] Func<string> bodypriorityId = null, [WorkflowExpression] Func<int> bodyposition = null, [WorkflowExpression] Func<string> bodyparentId = null, [WorkflowExpression] Func<bool> bodyreminderSet = null, [WorkflowExpression] Func<string> bodysortDate = null, [WorkflowExpression] Func<string> bodysourceId = null, [WorkflowExpression] Func<string> bodysourceAssignedToId = null, [WorkflowExpression] Func<string> bodysourceRelatedToId = null, [WorkflowExpression] Func<string[]> bodysourceContactIds = null, [WorkflowExpression] Func<bodycallDirectionInput> bodycallDirection = null)
        {
            SourceExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            SourceExpression.Validate(bodyassignedToType, nameof(bodyassignedToType), required: false);
            SourceExpression.Validate(bodyassignedToId, nameof(bodyassignedToId), required: false);
            SourceExpression.Validate(bodyrelatedToType, nameof(bodyrelatedToType), required: false);
            SourceExpression.Validate(bodyrelatedToId, nameof(bodyrelatedToId), required: false);
            SourceExpression.Validate(bodycontactType, nameof(bodycontactType), required: false);
            SourceExpression.Validate(bodycontactIds, nameof(bodycontactIds), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodycallDuration, nameof(bodycallDuration), required: false);
            SourceExpression.Validate(bodycallResultId, nameof(bodycallResultId), required: false);
            SourceExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            SourceExpression.Validate(bodyeditorBody, nameof(bodyeditorBody), required: false);
            SourceExpression.Validate(bodypriorityId, nameof(bodypriorityId), required: false);
            SourceExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            SourceExpression.Validate(bodyparentId, nameof(bodyparentId), required: false);
            SourceExpression.Validate(bodyreminderSet, nameof(bodyreminderSet), required: false);
            SourceExpression.Validate(bodysortDate, nameof(bodysortDate), required: false);
            SourceExpression.Validate(bodysourceId, nameof(bodysourceId), required: false);
            SourceExpression.Validate(bodysourceAssignedToId, nameof(bodysourceAssignedToId), required: false);
            SourceExpression.Validate(bodysourceRelatedToId, nameof(bodysourceRelatedToId), required: false);
            SourceExpression.Validate(bodysourceContactIds, nameof(bodysourceContactIds), required: false);
            SourceExpression.Validate(bodycallDirection, nameof(bodycallDirection), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/task/Call";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydueDate != null)
                {
                    body["dueDate"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                if (bodyassignedToType != null)
                {
                    body["assignedToType"] = SourceExpressionConverter.Convert(bodyassignedToType);
                    bodypropCount++;
                }

                if (bodyassignedToId != null)
                {
                    body["assignedToId"] = SourceExpressionConverter.ConvertToken(bodyassignedToId);
                    bodypropCount++;
                }

                if (bodyrelatedToType != null)
                {
                    body["relatedToType"] = SourceExpressionConverter.Convert(bodyrelatedToType);
                    bodypropCount++;
                }

                if (bodyrelatedToId != null)
                {
                    body["relatedToId"] = SourceExpressionConverter.ConvertToken(bodyrelatedToId);
                    bodypropCount++;
                }

                if (bodycontactType != null)
                {
                    body["contactType"] = SourceExpressionConverter.Convert(bodycontactType);
                    bodypropCount++;
                }

                if (bodycontactIds != null)
                {
                    body["contactIds"] = SourceExpressionConverter.ConvertToken(bodycontactIds);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                if (bodycallDuration != null)
                {
                    body["callDuration"] = SourceExpressionConverter.ConvertToken(bodycallDuration);
                    bodypropCount++;
                }

                if (bodycallResultId != null)
                {
                    body["callResultId"] = SourceExpressionConverter.ConvertToken(bodycallResultId);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodyeditorBody != null)
                {
                    body["editorBody"] = SourceExpressionConverter.ConvertToken(bodyeditorBody);
                    bodypropCount++;
                }

                if (bodypriorityId != null)
                {
                    body["priorityId"] = SourceExpressionConverter.ConvertToken(bodypriorityId);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodyparentId != null)
                {
                    body["parentId"] = SourceExpressionConverter.ConvertToken(bodyparentId);
                    bodypropCount++;
                }

                if (bodyreminderSet != null)
                {
                    body["reminderSet"] = SourceExpressionConverter.ConvertToken(bodyreminderSet);
                    bodypropCount++;
                }

                if (bodysortDate != null)
                {
                    body["sortDate"] = SourceExpressionConverter.ConvertToken(bodysortDate);
                    bodypropCount++;
                }

                if (bodysourceId != null)
                {
                    body["sourceId"] = SourceExpressionConverter.ConvertToken(bodysourceId);
                    bodypropCount++;
                }

                if (bodysourceAssignedToId != null)
                {
                    body["sourceAssignedToId"] = SourceExpressionConverter.ConvertToken(bodysourceAssignedToId);
                    bodypropCount++;
                }

                if (bodysourceRelatedToId != null)
                {
                    body["sourceRelatedToId"] = SourceExpressionConverter.ConvertToken(bodysourceRelatedToId);
                    bodypropCount++;
                }

                if (bodysourceContactIds != null)
                {
                    body["sourceContactIds"] = SourceExpressionConverter.ConvertToken(bodysourceContactIds);
                    bodypropCount++;
                }

                if (bodycallDirection != null)
                {
                    body["callDirection"] = SourceExpressionConverter.Convert(bodycallDirection);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TaskApiFeaturesCallsCallDTO>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesCallsCallDTO> CallGetById([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/task/Call/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TaskApiFeaturesCallsCallDTO>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction CallDelete([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/task/Call/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesCallsCallDTO> CallUpdate([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bodytaskTypeInput> bodytaskType = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<bodyassignedToTypeInput> bodyassignedToType = null, [WorkflowExpression] Func<string> bodyassignedToId = null, [WorkflowExpression] Func<bodyrelatedToTypeInput> bodyrelatedToType = null, [WorkflowExpression] Func<string> bodyrelatedToId = null, [WorkflowExpression] Func<bodycontactTypeInput> bodycontactType = null, [WorkflowExpression] Func<string[]> bodycontactIds = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodycallDuration = null, [WorkflowExpression] Func<string> bodycallResultId = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodyeditorBody = null, [WorkflowExpression] Func<string> bodypriorityId = null, [WorkflowExpression] Func<int> bodyposition = null, [WorkflowExpression] Func<string> bodyparentId = null, [WorkflowExpression] Func<bool> bodyreminderSet = null, [WorkflowExpression] Func<string> bodylastModifiedBy = null, [WorkflowExpression] Func<string> bodysortDate = null, [WorkflowExpression] Func<string> bodysourceId = null, [WorkflowExpression] Func<string> bodysourceAssignedToId = null, [WorkflowExpression] Func<string> bodysourceRelatedToId = null, [WorkflowExpression] Func<string[]> bodysourceContactIds = null, [WorkflowExpression] Func<bodycallDirectionInput> bodycallDirection = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytaskType, nameof(bodytaskType), required: false);
            SourceExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            SourceExpression.Validate(bodyassignedToType, nameof(bodyassignedToType), required: false);
            SourceExpression.Validate(bodyassignedToId, nameof(bodyassignedToId), required: false);
            SourceExpression.Validate(bodyrelatedToType, nameof(bodyrelatedToType), required: false);
            SourceExpression.Validate(bodyrelatedToId, nameof(bodyrelatedToId), required: false);
            SourceExpression.Validate(bodycontactType, nameof(bodycontactType), required: false);
            SourceExpression.Validate(bodycontactIds, nameof(bodycontactIds), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodycallDuration, nameof(bodycallDuration), required: false);
            SourceExpression.Validate(bodycallResultId, nameof(bodycallResultId), required: false);
            SourceExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            SourceExpression.Validate(bodyeditorBody, nameof(bodyeditorBody), required: false);
            SourceExpression.Validate(bodypriorityId, nameof(bodypriorityId), required: false);
            SourceExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            SourceExpression.Validate(bodyparentId, nameof(bodyparentId), required: false);
            SourceExpression.Validate(bodyreminderSet, nameof(bodyreminderSet), required: false);
            SourceExpression.Validate(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            SourceExpression.Validate(bodysortDate, nameof(bodysortDate), required: false);
            SourceExpression.Validate(bodysourceId, nameof(bodysourceId), required: false);
            SourceExpression.Validate(bodysourceAssignedToId, nameof(bodysourceAssignedToId), required: false);
            SourceExpression.Validate(bodysourceRelatedToId, nameof(bodysourceRelatedToId), required: false);
            SourceExpression.Validate(bodysourceContactIds, nameof(bodysourceContactIds), required: false);
            SourceExpression.Validate(bodycallDirection, nameof(bodycallDirection), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/task/Call/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytaskType != null)
                {
                    body["taskType"] = SourceExpressionConverter.Convert(bodytaskType);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["dueDate"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                if (bodyassignedToType != null)
                {
                    body["assignedToType"] = SourceExpressionConverter.Convert(bodyassignedToType);
                    bodypropCount++;
                }

                if (bodyassignedToId != null)
                {
                    body["assignedToId"] = SourceExpressionConverter.ConvertToken(bodyassignedToId);
                    bodypropCount++;
                }

                if (bodyrelatedToType != null)
                {
                    body["relatedToType"] = SourceExpressionConverter.Convert(bodyrelatedToType);
                    bodypropCount++;
                }

                if (bodyrelatedToId != null)
                {
                    body["relatedToId"] = SourceExpressionConverter.ConvertToken(bodyrelatedToId);
                    bodypropCount++;
                }

                if (bodycontactType != null)
                {
                    body["contactType"] = SourceExpressionConverter.Convert(bodycontactType);
                    bodypropCount++;
                }

                if (bodycontactIds != null)
                {
                    body["contactIds"] = SourceExpressionConverter.ConvertToken(bodycontactIds);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                if (bodycallDuration != null)
                {
                    body["callDuration"] = SourceExpressionConverter.ConvertToken(bodycallDuration);
                    bodypropCount++;
                }

                if (bodycallResultId != null)
                {
                    body["callResultId"] = SourceExpressionConverter.ConvertToken(bodycallResultId);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodyeditorBody != null)
                {
                    body["editorBody"] = SourceExpressionConverter.ConvertToken(bodyeditorBody);
                    bodypropCount++;
                }

                if (bodypriorityId != null)
                {
                    body["priorityId"] = SourceExpressionConverter.ConvertToken(bodypriorityId);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodyparentId != null)
                {
                    body["parentId"] = SourceExpressionConverter.ConvertToken(bodyparentId);
                    bodypropCount++;
                }

                if (bodyreminderSet != null)
                {
                    body["reminderSet"] = SourceExpressionConverter.ConvertToken(bodyreminderSet);
                    bodypropCount++;
                }

                if (bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = SourceExpressionConverter.ConvertToken(bodylastModifiedBy);
                    bodypropCount++;
                }

                if (bodysortDate != null)
                {
                    body["sortDate"] = SourceExpressionConverter.ConvertToken(bodysortDate);
                    bodypropCount++;
                }

                if (bodysourceId != null)
                {
                    body["sourceId"] = SourceExpressionConverter.ConvertToken(bodysourceId);
                    bodypropCount++;
                }

                if (bodysourceAssignedToId != null)
                {
                    body["sourceAssignedToId"] = SourceExpressionConverter.ConvertToken(bodysourceAssignedToId);
                    bodypropCount++;
                }

                if (bodysourceRelatedToId != null)
                {
                    body["sourceRelatedToId"] = SourceExpressionConverter.ConvertToken(bodysourceRelatedToId);
                    bodypropCount++;
                }

                if (bodysourceContactIds != null)
                {
                    body["sourceContactIds"] = SourceExpressionConverter.ConvertToken(bodysourceContactIds);
                    bodypropCount++;
                }

                if (bodycallDirection != null)
                {
                    body["callDirection"] = SourceExpressionConverter.Convert(bodycallDirection);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TaskApiFeaturesCallsCallDTO>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesEventsEventDTO[]> EventGetAll([WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<eventStatusInput> eventStatus = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> assignedToId = null, [WorkflowExpression] Func<string> relatedToId = null, [WorkflowExpression] Func<string> sortDate = null, [WorkflowExpression] Func<string> parentId = null, [WorkflowExpression] Func<string> eventResultId = null, [WorkflowExpression] Func<string> priorityId = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> lastModifiedBy = null, [WorkflowExpression] Func<string> createdBy = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(eventStatus, nameof(eventStatus), required: false);
            SourceExpression.Validate(startDate, nameof(startDate), required: false);
            SourceExpression.Validate(assignedToId, nameof(assignedToId), required: false);
            SourceExpression.Validate(relatedToId, nameof(relatedToId), required: false);
            SourceExpression.Validate(sortDate, nameof(sortDate), required: false);
            SourceExpression.Validate(parentId, nameof(parentId), required: false);
            SourceExpression.Validate(eventResultId, nameof(eventResultId), required: false);
            SourceExpression.Validate(priorityId, nameof(priorityId), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(lastModifiedBy, nameof(lastModifiedBy), required: false);
            SourceExpression.Validate(createdBy, nameof(createdBy), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/task/Event";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["Id"] = SourceExpressionConverter.ConvertO(id);
                if (status != null)
                    callPayload.Queries["Status"] = SourceExpressionConverter.Convert(status);
                if (eventStatus != null)
                    callPayload.Queries["EventStatus"] = SourceExpressionConverter.Convert(eventStatus);
                if (startDate != null)
                    callPayload.Queries["StartDate"] = SourceExpressionConverter.ConvertO(startDate);
                if (assignedToId != null)
                    callPayload.Queries["AssignedToId"] = SourceExpressionConverter.ConvertO(assignedToId);
                if (relatedToId != null)
                    callPayload.Queries["RelatedToId"] = SourceExpressionConverter.ConvertO(relatedToId);
                if (sortDate != null)
                    callPayload.Queries["SortDate"] = SourceExpressionConverter.ConvertO(sortDate);
                if (parentId != null)
                    callPayload.Queries["ParentId"] = SourceExpressionConverter.ConvertO(parentId);
                if (eventResultId != null)
                    callPayload.Queries["EventResultId"] = SourceExpressionConverter.ConvertO(eventResultId);
                if (priorityId != null)
                    callPayload.Queries["PriorityId"] = SourceExpressionConverter.ConvertO(priorityId);
                if (search != null)
                    callPayload.Queries["Search"] = SourceExpressionConverter.ConvertO(search);
                if (lastModifiedBy != null)
                    callPayload.Queries["LastModifiedBy"] = SourceExpressionConverter.ConvertO(lastModifiedBy);
                if (createdBy != null)
                    callPayload.Queries["CreatedBy"] = SourceExpressionConverter.ConvertO(createdBy);
                if (page != null)
                    callPayload.Queries["Page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<TaskApiFeaturesEventsEventDTO[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesEventsEventDTO> EventCreate([WorkflowExpression] Func<string> bodyupdateDate = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<bodytaskTypeInput> bodytaskType = null, [WorkflowExpression] Func<bodyassignedToTypeInput> bodyassignedToType = null, [WorkflowExpression] Func<string> bodyassignedToId = null, [WorkflowExpression] Func<bodyrelatedToTypeInput> bodyrelatedToType = null, [WorkflowExpression] Func<string> bodyrelatedToId = null, [WorkflowExpression] Func<bodycontactTypeInput> bodycontactType = null, [WorkflowExpression] Func<string[]> bodycontactIds = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyeditorBody = null, [WorkflowExpression] Func<string> bodypriorityId = null, [WorkflowExpression] Func<string> bodylocationlongitude = null, [WorkflowExpression] Func<string> bodylocationlatitude = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<bool> bodyreminderSet = null, [WorkflowExpression] Func<string> bodycreatedBy = null, [WorkflowExpression] Func<string> bodylastModifiedBy = null, [WorkflowExpression] Func<int> bodyposition = null, [WorkflowExpression] Func<string> bodyparentId = null, [WorkflowExpression] Func<string> bodyrepeat = null, [WorkflowExpression] Func<bodyeventStatusInput> bodyeventStatus = null, [WorkflowExpression] Func<string> bodyeventResultId = null, [WorkflowExpression] Func<string> bodyrecurrenceInterval = null, [WorkflowExpression] Func<string> bodysourceId = null, [WorkflowExpression] Func<string> bodysourceAssignedToId = null, [WorkflowExpression] Func<string> bodysourceRelatedToId = null, [WorkflowExpression] Func<string[]> bodysourceContactIds = null, [WorkflowExpression] Func<string[]> bodyteamMembers = null)
        {
            SourceExpression.Validate(bodyupdateDate, nameof(bodyupdateDate), required: false);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            SourceExpression.Validate(bodytaskType, nameof(bodytaskType), required: false);
            SourceExpression.Validate(bodyassignedToType, nameof(bodyassignedToType), required: false);
            SourceExpression.Validate(bodyassignedToId, nameof(bodyassignedToId), required: false);
            SourceExpression.Validate(bodyrelatedToType, nameof(bodyrelatedToType), required: false);
            SourceExpression.Validate(bodyrelatedToId, nameof(bodyrelatedToId), required: false);
            SourceExpression.Validate(bodycontactType, nameof(bodycontactType), required: false);
            SourceExpression.Validate(bodycontactIds, nameof(bodycontactIds), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyeditorBody, nameof(bodyeditorBody), required: false);
            SourceExpression.Validate(bodypriorityId, nameof(bodypriorityId), required: false);
            SourceExpression.Validate(bodylocationlongitude, nameof(bodylocationlongitude), required: false);
            SourceExpression.Validate(bodylocationlatitude, nameof(bodylocationlatitude), required: false);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            SourceExpression.Validate(bodyreminderSet, nameof(bodyreminderSet), required: false);
            SourceExpression.Validate(bodycreatedBy, nameof(bodycreatedBy), required: false);
            SourceExpression.Validate(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            SourceExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            SourceExpression.Validate(bodyparentId, nameof(bodyparentId), required: false);
            SourceExpression.Validate(bodyrepeat, nameof(bodyrepeat), required: false);
            SourceExpression.Validate(bodyeventStatus, nameof(bodyeventStatus), required: false);
            SourceExpression.Validate(bodyeventResultId, nameof(bodyeventResultId), required: false);
            SourceExpression.Validate(bodyrecurrenceInterval, nameof(bodyrecurrenceInterval), required: false);
            SourceExpression.Validate(bodysourceId, nameof(bodysourceId), required: false);
            SourceExpression.Validate(bodysourceAssignedToId, nameof(bodysourceAssignedToId), required: false);
            SourceExpression.Validate(bodysourceRelatedToId, nameof(bodysourceRelatedToId), required: false);
            SourceExpression.Validate(bodysourceContactIds, nameof(bodysourceContactIds), required: false);
            SourceExpression.Validate(bodyteamMembers, nameof(bodyteamMembers), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/task/Event";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyupdateDate != null)
                {
                    body["updateDate"] = SourceExpressionConverter.ConvertToken(bodyupdateDate);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                if (bodytaskType != null)
                {
                    body["taskType"] = SourceExpressionConverter.Convert(bodytaskType);
                    bodypropCount++;
                }

                if (bodyassignedToType != null)
                {
                    body["assignedToType"] = SourceExpressionConverter.Convert(bodyassignedToType);
                    bodypropCount++;
                }

                if (bodyassignedToId != null)
                {
                    body["assignedToId"] = SourceExpressionConverter.ConvertToken(bodyassignedToId);
                    bodypropCount++;
                }

                if (bodyrelatedToType != null)
                {
                    body["relatedToType"] = SourceExpressionConverter.Convert(bodyrelatedToType);
                    bodypropCount++;
                }

                if (bodyrelatedToId != null)
                {
                    body["relatedToId"] = SourceExpressionConverter.ConvertToken(bodyrelatedToId);
                    bodypropCount++;
                }

                if (bodycontactType != null)
                {
                    body["contactType"] = SourceExpressionConverter.Convert(bodycontactType);
                    bodypropCount++;
                }

                if (bodycontactIds != null)
                {
                    body["contactIds"] = SourceExpressionConverter.ConvertToken(bodycontactIds);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyeditorBody != null)
                {
                    body["editorBody"] = SourceExpressionConverter.ConvertToken(bodyeditorBody);
                    bodypropCount++;
                }

                if (bodypriorityId != null)
                {
                    body["priorityId"] = SourceExpressionConverter.ConvertToken(bodypriorityId);
                    bodypropCount++;
                }

                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (bodylocationlongitude != null)
                {
                    locationObject["longitude"] = SourceExpressionConverter.ConvertToken(bodylocationlongitude);
                    locationObjectpropCount++;
                }

                if (bodylocationlatitude != null)
                {
                    locationObject["latitude"] = SourceExpressionConverter.ConvertToken(bodylocationlatitude);
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    body["location"] = locationObject;
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["endDate"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodyreminderSet != null)
                {
                    body["reminderSet"] = SourceExpressionConverter.ConvertToken(bodyreminderSet);
                    bodypropCount++;
                }

                if (bodycreatedBy != null)
                {
                    body["createdBy"] = SourceExpressionConverter.ConvertToken(bodycreatedBy);
                    bodypropCount++;
                }

                if (bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = SourceExpressionConverter.ConvertToken(bodylastModifiedBy);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodyparentId != null)
                {
                    body["parentId"] = SourceExpressionConverter.ConvertToken(bodyparentId);
                    bodypropCount++;
                }

                if (bodyrepeat != null)
                {
                    body["repeat"] = SourceExpressionConverter.ConvertToken(bodyrepeat);
                    bodypropCount++;
                }

                if (bodyeventStatus != null)
                {
                    body["eventStatus"] = SourceExpressionConverter.Convert(bodyeventStatus);
                    bodypropCount++;
                }

                if (bodyeventResultId != null)
                {
                    body["eventResultId"] = SourceExpressionConverter.ConvertToken(bodyeventResultId);
                    bodypropCount++;
                }

                if (bodyrecurrenceInterval != null)
                {
                    body["recurrenceInterval"] = SourceExpressionConverter.ConvertToken(bodyrecurrenceInterval);
                    bodypropCount++;
                }

                if (bodysourceId != null)
                {
                    body["sourceId"] = SourceExpressionConverter.ConvertToken(bodysourceId);
                    bodypropCount++;
                }

                if (bodysourceAssignedToId != null)
                {
                    body["sourceAssignedToId"] = SourceExpressionConverter.ConvertToken(bodysourceAssignedToId);
                    bodypropCount++;
                }

                if (bodysourceRelatedToId != null)
                {
                    body["sourceRelatedToId"] = SourceExpressionConverter.ConvertToken(bodysourceRelatedToId);
                    bodypropCount++;
                }

                if (bodysourceContactIds != null)
                {
                    body["sourceContactIds"] = SourceExpressionConverter.ConvertToken(bodysourceContactIds);
                    bodypropCount++;
                }

                if (bodyteamMembers != null)
                {
                    body["teamMembers"] = SourceExpressionConverter.ConvertToken(bodyteamMembers);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TaskApiFeaturesEventsEventDTO>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesEventsEventDTO> EventGetById([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/task/Event/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TaskApiFeaturesEventsEventDTO>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction EventDelete([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/task/Event/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesEventsEventDTO> EventUpdate([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyupdateDate = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<bodytaskTypeInput> bodytaskType = null, [WorkflowExpression] Func<bodyassignedToTypeInput> bodyassignedToType = null, [WorkflowExpression] Func<string> bodyassignedToId = null, [WorkflowExpression] Func<bodyrelatedToTypeInput> bodyrelatedToType = null, [WorkflowExpression] Func<string> bodyrelatedToId = null, [WorkflowExpression] Func<bodycontactTypeInput> bodycontactType = null, [WorkflowExpression] Func<string[]> bodycontactIds = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyeditorBody = null, [WorkflowExpression] Func<string> bodypriorityId = null, [WorkflowExpression] Func<string> bodylocationlongitude = null, [WorkflowExpression] Func<string> bodylocationlatitude = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<bool> bodyreminderSet = null, [WorkflowExpression] Func<string> bodycreatedBy = null, [WorkflowExpression] Func<string> bodylastModifiedBy = null, [WorkflowExpression] Func<int> bodyposition = null, [WorkflowExpression] Func<string> bodyparentId = null, [WorkflowExpression] Func<string> bodyrepeat = null, [WorkflowExpression] Func<bodyeventStatusInput> bodyeventStatus = null, [WorkflowExpression] Func<string> bodyeventResultId = null, [WorkflowExpression] Func<string> bodyrecurrenceInterval = null, [WorkflowExpression] Func<string> bodysourceId = null, [WorkflowExpression] Func<string> bodysourceAssignedToId = null, [WorkflowExpression] Func<string> bodysourceRelatedToId = null, [WorkflowExpression] Func<string[]> bodysourceContactIds = null, [WorkflowExpression] Func<string[]> bodyteamMembers = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyupdateDate, nameof(bodyupdateDate), required: false);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            SourceExpression.Validate(bodytaskType, nameof(bodytaskType), required: false);
            SourceExpression.Validate(bodyassignedToType, nameof(bodyassignedToType), required: false);
            SourceExpression.Validate(bodyassignedToId, nameof(bodyassignedToId), required: false);
            SourceExpression.Validate(bodyrelatedToType, nameof(bodyrelatedToType), required: false);
            SourceExpression.Validate(bodyrelatedToId, nameof(bodyrelatedToId), required: false);
            SourceExpression.Validate(bodycontactType, nameof(bodycontactType), required: false);
            SourceExpression.Validate(bodycontactIds, nameof(bodycontactIds), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyeditorBody, nameof(bodyeditorBody), required: false);
            SourceExpression.Validate(bodypriorityId, nameof(bodypriorityId), required: false);
            SourceExpression.Validate(bodylocationlongitude, nameof(bodylocationlongitude), required: false);
            SourceExpression.Validate(bodylocationlatitude, nameof(bodylocationlatitude), required: false);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            SourceExpression.Validate(bodyreminderSet, nameof(bodyreminderSet), required: false);
            SourceExpression.Validate(bodycreatedBy, nameof(bodycreatedBy), required: false);
            SourceExpression.Validate(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            SourceExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            SourceExpression.Validate(bodyparentId, nameof(bodyparentId), required: false);
            SourceExpression.Validate(bodyrepeat, nameof(bodyrepeat), required: false);
            SourceExpression.Validate(bodyeventStatus, nameof(bodyeventStatus), required: false);
            SourceExpression.Validate(bodyeventResultId, nameof(bodyeventResultId), required: false);
            SourceExpression.Validate(bodyrecurrenceInterval, nameof(bodyrecurrenceInterval), required: false);
            SourceExpression.Validate(bodysourceId, nameof(bodysourceId), required: false);
            SourceExpression.Validate(bodysourceAssignedToId, nameof(bodysourceAssignedToId), required: false);
            SourceExpression.Validate(bodysourceRelatedToId, nameof(bodysourceRelatedToId), required: false);
            SourceExpression.Validate(bodysourceContactIds, nameof(bodysourceContactIds), required: false);
            SourceExpression.Validate(bodyteamMembers, nameof(bodyteamMembers), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/task/Event/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyupdateDate != null)
                {
                    body["updateDate"] = SourceExpressionConverter.ConvertToken(bodyupdateDate);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                if (bodytaskType != null)
                {
                    body["taskType"] = SourceExpressionConverter.Convert(bodytaskType);
                    bodypropCount++;
                }

                if (bodyassignedToType != null)
                {
                    body["assignedToType"] = SourceExpressionConverter.Convert(bodyassignedToType);
                    bodypropCount++;
                }

                if (bodyassignedToId != null)
                {
                    body["assignedToId"] = SourceExpressionConverter.ConvertToken(bodyassignedToId);
                    bodypropCount++;
                }

                if (bodyrelatedToType != null)
                {
                    body["relatedToType"] = SourceExpressionConverter.Convert(bodyrelatedToType);
                    bodypropCount++;
                }

                if (bodyrelatedToId != null)
                {
                    body["relatedToId"] = SourceExpressionConverter.ConvertToken(bodyrelatedToId);
                    bodypropCount++;
                }

                if (bodycontactType != null)
                {
                    body["contactType"] = SourceExpressionConverter.Convert(bodycontactType);
                    bodypropCount++;
                }

                if (bodycontactIds != null)
                {
                    body["contactIds"] = SourceExpressionConverter.ConvertToken(bodycontactIds);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyeditorBody != null)
                {
                    body["editorBody"] = SourceExpressionConverter.ConvertToken(bodyeditorBody);
                    bodypropCount++;
                }

                if (bodypriorityId != null)
                {
                    body["priorityId"] = SourceExpressionConverter.ConvertToken(bodypriorityId);
                    bodypropCount++;
                }

                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (bodylocationlongitude != null)
                {
                    locationObject["longitude"] = SourceExpressionConverter.ConvertToken(bodylocationlongitude);
                    locationObjectpropCount++;
                }

                if (bodylocationlatitude != null)
                {
                    locationObject["latitude"] = SourceExpressionConverter.ConvertToken(bodylocationlatitude);
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    body["location"] = locationObject;
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["endDate"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodyreminderSet != null)
                {
                    body["reminderSet"] = SourceExpressionConverter.ConvertToken(bodyreminderSet);
                    bodypropCount++;
                }

                if (bodycreatedBy != null)
                {
                    body["createdBy"] = SourceExpressionConverter.ConvertToken(bodycreatedBy);
                    bodypropCount++;
                }

                if (bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = SourceExpressionConverter.ConvertToken(bodylastModifiedBy);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodyparentId != null)
                {
                    body["parentId"] = SourceExpressionConverter.ConvertToken(bodyparentId);
                    bodypropCount++;
                }

                if (bodyrepeat != null)
                {
                    body["repeat"] = SourceExpressionConverter.ConvertToken(bodyrepeat);
                    bodypropCount++;
                }

                if (bodyeventStatus != null)
                {
                    body["eventStatus"] = SourceExpressionConverter.Convert(bodyeventStatus);
                    bodypropCount++;
                }

                if (bodyeventResultId != null)
                {
                    body["eventResultId"] = SourceExpressionConverter.ConvertToken(bodyeventResultId);
                    bodypropCount++;
                }

                if (bodyrecurrenceInterval != null)
                {
                    body["recurrenceInterval"] = SourceExpressionConverter.ConvertToken(bodyrecurrenceInterval);
                    bodypropCount++;
                }

                if (bodysourceId != null)
                {
                    body["sourceId"] = SourceExpressionConverter.ConvertToken(bodysourceId);
                    bodypropCount++;
                }

                if (bodysourceAssignedToId != null)
                {
                    body["sourceAssignedToId"] = SourceExpressionConverter.ConvertToken(bodysourceAssignedToId);
                    bodypropCount++;
                }

                if (bodysourceRelatedToId != null)
                {
                    body["sourceRelatedToId"] = SourceExpressionConverter.ConvertToken(bodysourceRelatedToId);
                    bodypropCount++;
                }

                if (bodysourceContactIds != null)
                {
                    body["sourceContactIds"] = SourceExpressionConverter.ConvertToken(bodysourceContactIds);
                    bodypropCount++;
                }

                if (bodyteamMembers != null)
                {
                    body["teamMembers"] = SourceExpressionConverter.ConvertToken(bodyteamMembers);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TaskApiFeaturesEventsEventDTO>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesNotesNoteDTO[]> NoteGetAll([WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> relatedToId = null, [WorkflowExpression] Func<relatedToTypeInput> relatedToType = null, [WorkflowExpression] Func<string> createdBy = null, [WorkflowExpression] Func<string> lastModifiedBy = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(relatedToId, nameof(relatedToId), required: false);
            SourceExpression.Validate(relatedToType, nameof(relatedToType), required: false);
            SourceExpression.Validate(createdBy, nameof(createdBy), required: false);
            SourceExpression.Validate(lastModifiedBy, nameof(lastModifiedBy), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/task/Note";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["Id"] = SourceExpressionConverter.ConvertO(id);
                if (search != null)
                    callPayload.Queries["Search"] = SourceExpressionConverter.ConvertO(search);
                if (relatedToId != null)
                    callPayload.Queries["RelatedToId"] = SourceExpressionConverter.ConvertO(relatedToId);
                if (relatedToType != null)
                    callPayload.Queries["RelatedToType"] = SourceExpressionConverter.Convert(relatedToType);
                if (createdBy != null)
                    callPayload.Queries["CreatedBy"] = SourceExpressionConverter.ConvertO(createdBy);
                if (lastModifiedBy != null)
                    callPayload.Queries["LastModifiedBy"] = SourceExpressionConverter.ConvertO(lastModifiedBy);
                if (page != null)
                    callPayload.Queries["Page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<TaskApiFeaturesNotesNoteDTO[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesNotesNoteDTO> NoteCreate([WorkflowExpression] Func<string> bodysubject, [WorkflowExpression] Func<bodytaskTypeInput> bodytaskType = null, [WorkflowExpression] Func<bodyrelatedToTypeInput> bodyrelatedToType = null, [WorkflowExpression] Func<bodycontactTypeInput> bodycontactType = null, [WorkflowExpression] Func<string> bodyrelatedToId = null, [WorkflowExpression] Func<string> bodybody = null, [WorkflowExpression] Func<string> bodyeditorBody = null, [WorkflowExpression] Func<string[]> bodycontactIds = null)
        {
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: true);
            SourceExpression.Validate(bodytaskType, nameof(bodytaskType), required: false);
            SourceExpression.Validate(bodyrelatedToType, nameof(bodyrelatedToType), required: false);
            SourceExpression.Validate(bodycontactType, nameof(bodycontactType), required: false);
            SourceExpression.Validate(bodyrelatedToId, nameof(bodyrelatedToId), required: false);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: false);
            SourceExpression.Validate(bodyeditorBody, nameof(bodyeditorBody), required: false);
            SourceExpression.Validate(bodycontactIds, nameof(bodycontactIds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/task/Note";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytaskType != null)
                {
                    body["taskType"] = SourceExpressionConverter.Convert(bodytaskType);
                    bodypropCount++;
                }

                if (bodyrelatedToType != null)
                {
                    body["relatedToType"] = SourceExpressionConverter.Convert(bodyrelatedToType);
                    bodypropCount++;
                }

                if (bodycontactType != null)
                {
                    body["contactType"] = SourceExpressionConverter.Convert(bodycontactType);
                    bodypropCount++;
                }

                if (bodyrelatedToId != null)
                {
                    body["relatedToId"] = SourceExpressionConverter.ConvertToken(bodyrelatedToId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                if (bodybody != null)
                {
                    body["body"] = SourceExpressionConverter.ConvertToken(bodybody);
                    bodypropCount++;
                }

                if (bodyeditorBody != null)
                {
                    body["editorBody"] = SourceExpressionConverter.ConvertToken(bodyeditorBody);
                    bodypropCount++;
                }

                if (bodycontactIds != null)
                {
                    body["contactIds"] = SourceExpressionConverter.ConvertToken(bodycontactIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TaskApiFeaturesNotesNoteDTO>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesNotesNoteDTO> NoteGetById([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/task/Note/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TaskApiFeaturesNotesNoteDTO>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction NoteDelete([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/task/Note/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesNotesNoteDTO> NoteUpdate([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bodyrelatedToTypeInput> bodyrelatedToType = null, [WorkflowExpression] Func<string> bodyrelatedToId = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodybody = null, [WorkflowExpression] Func<string> bodyeditorBody = null, [WorkflowExpression] Func<string> bodylastModifiedBy = null, [WorkflowExpression] Func<string[]> bodycontactIds = null, [WorkflowExpression] Func<bodycontactTypeInput> bodycontactType = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyrelatedToType, nameof(bodyrelatedToType), required: false);
            SourceExpression.Validate(bodyrelatedToId, nameof(bodyrelatedToId), required: false);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: false);
            SourceExpression.Validate(bodyeditorBody, nameof(bodyeditorBody), required: false);
            SourceExpression.Validate(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            SourceExpression.Validate(bodycontactIds, nameof(bodycontactIds), required: false);
            SourceExpression.Validate(bodycontactType, nameof(bodycontactType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/task/Note/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyrelatedToType != null)
                {
                    body["relatedToType"] = SourceExpressionConverter.Convert(bodyrelatedToType);
                    bodypropCount++;
                }

                if (bodyrelatedToId != null)
                {
                    body["relatedToId"] = SourceExpressionConverter.ConvertToken(bodyrelatedToId);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                if (bodybody != null)
                {
                    body["body"] = SourceExpressionConverter.ConvertToken(bodybody);
                    bodypropCount++;
                }

                if (bodyeditorBody != null)
                {
                    body["editorBody"] = SourceExpressionConverter.ConvertToken(bodyeditorBody);
                    bodypropCount++;
                }

                if (bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = SourceExpressionConverter.ConvertToken(bodylastModifiedBy);
                    bodypropCount++;
                }

                if (bodycontactIds != null)
                {
                    body["contactIds"] = SourceExpressionConverter.ConvertToken(bodycontactIds);
                    bodypropCount++;
                }

                if (bodycontactType != null)
                {
                    body["contactType"] = SourceExpressionConverter.Convert(bodycontactType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TaskApiFeaturesNotesNoteDTO>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesTasksTaskDTO[]> TaskGetAll([WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<string> relatedTo = null, [WorkflowExpression] Func<string> relatedToId = null, [WorkflowExpression] Func<string> priorityId = null, [WorkflowExpression] Func<typeInput> type = null, [WorkflowExpression] Func<string> dueDate = null, [WorkflowExpression] Func<string> sortDate = null, [WorkflowExpression] Func<string> parentId = null, [WorkflowExpression] Func<string> lastModifiedBy = null, [WorkflowExpression] Func<string> createdBy = null, [WorkflowExpression] Func<string> assignedToId = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(relatedTo, nameof(relatedTo), required: false);
            SourceExpression.Validate(relatedToId, nameof(relatedToId), required: false);
            SourceExpression.Validate(priorityId, nameof(priorityId), required: false);
            SourceExpression.Validate(type, nameof(type), required: false);
            SourceExpression.Validate(dueDate, nameof(dueDate), required: false);
            SourceExpression.Validate(sortDate, nameof(sortDate), required: false);
            SourceExpression.Validate(parentId, nameof(parentId), required: false);
            SourceExpression.Validate(lastModifiedBy, nameof(lastModifiedBy), required: false);
            SourceExpression.Validate(createdBy, nameof(createdBy), required: false);
            SourceExpression.Validate(assignedToId, nameof(assignedToId), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Task";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["Id"] = SourceExpressionConverter.ConvertO(id);
                if (status != null)
                    callPayload.Queries["Status"] = SourceExpressionConverter.Convert(status);
                if (relatedTo != null)
                    callPayload.Queries["RelatedTo"] = SourceExpressionConverter.ConvertO(relatedTo);
                if (relatedToId != null)
                    callPayload.Queries["RelatedToId"] = SourceExpressionConverter.ConvertO(relatedToId);
                if (priorityId != null)
                    callPayload.Queries["PriorityId"] = SourceExpressionConverter.ConvertO(priorityId);
                if (type != null)
                    callPayload.Queries["Type"] = SourceExpressionConverter.Convert(type);
                if (dueDate != null)
                    callPayload.Queries["DueDate"] = SourceExpressionConverter.ConvertO(dueDate);
                if (sortDate != null)
                    callPayload.Queries["SortDate"] = SourceExpressionConverter.ConvertO(sortDate);
                if (parentId != null)
                    callPayload.Queries["ParentId"] = SourceExpressionConverter.ConvertO(parentId);
                if (lastModifiedBy != null)
                    callPayload.Queries["LastModifiedBy"] = SourceExpressionConverter.ConvertO(lastModifiedBy);
                if (createdBy != null)
                    callPayload.Queries["CreatedBy"] = SourceExpressionConverter.ConvertO(createdBy);
                if (assignedToId != null)
                    callPayload.Queries["AssignedToId"] = SourceExpressionConverter.ConvertO(assignedToId);
                if (search != null)
                    callPayload.Queries["Search"] = SourceExpressionConverter.ConvertO(search);
                if (page != null)
                    callPayload.Queries["Page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<TaskApiFeaturesTasksTaskDTO[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesTasksTaskDTO> TaskCreate([WorkflowExpression] Func<bodytaskTypeInput> bodytaskType = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodypriorityId = null, [WorkflowExpression] Func<string> bodyassignedToId = null, [WorkflowExpression] Func<bodyassignedToTypeInput> bodyassignedToType = null, [WorkflowExpression] Func<string[]> bodycontactIds = null, [WorkflowExpression] Func<bodycontactTypeInput> bodycontactType = null, [WorkflowExpression] Func<string> bodyrelatedToId = null, [WorkflowExpression] Func<bodyrelatedToTypeInput> bodyrelatedToType = null, [WorkflowExpression] Func<string> bodytaskSubTypeId = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodyeditorBody = null, [WorkflowExpression] Func<bool> bodyreminderSet = null, [WorkflowExpression] Func<int> bodyposition = null, [WorkflowExpression] Func<string> bodyparentId = null)
        {
            SourceExpression.Validate(bodytaskType, nameof(bodytaskType), required: false);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            SourceExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodypriorityId, nameof(bodypriorityId), required: false);
            SourceExpression.Validate(bodyassignedToId, nameof(bodyassignedToId), required: false);
            SourceExpression.Validate(bodyassignedToType, nameof(bodyassignedToType), required: false);
            SourceExpression.Validate(bodycontactIds, nameof(bodycontactIds), required: false);
            SourceExpression.Validate(bodycontactType, nameof(bodycontactType), required: false);
            SourceExpression.Validate(bodyrelatedToId, nameof(bodyrelatedToId), required: false);
            SourceExpression.Validate(bodyrelatedToType, nameof(bodyrelatedToType), required: false);
            SourceExpression.Validate(bodytaskSubTypeId, nameof(bodytaskSubTypeId), required: false);
            SourceExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            SourceExpression.Validate(bodyeditorBody, nameof(bodyeditorBody), required: false);
            SourceExpression.Validate(bodyreminderSet, nameof(bodyreminderSet), required: false);
            SourceExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            SourceExpression.Validate(bodyparentId, nameof(bodyparentId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Task";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytaskType != null)
                {
                    body["taskType"] = SourceExpressionConverter.Convert(bodytaskType);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["dueDate"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                if (bodypriorityId != null)
                {
                    body["priorityId"] = SourceExpressionConverter.ConvertToken(bodypriorityId);
                    bodypropCount++;
                }

                if (bodyassignedToId != null)
                {
                    body["assignedToId"] = SourceExpressionConverter.ConvertToken(bodyassignedToId);
                    bodypropCount++;
                }

                if (bodyassignedToType != null)
                {
                    body["assignedToType"] = SourceExpressionConverter.Convert(bodyassignedToType);
                    bodypropCount++;
                }

                if (bodycontactIds != null)
                {
                    body["contactIds"] = SourceExpressionConverter.ConvertToken(bodycontactIds);
                    bodypropCount++;
                }

                if (bodycontactType != null)
                {
                    body["contactType"] = SourceExpressionConverter.Convert(bodycontactType);
                    bodypropCount++;
                }

                if (bodyrelatedToId != null)
                {
                    body["relatedToId"] = SourceExpressionConverter.ConvertToken(bodyrelatedToId);
                    bodypropCount++;
                }

                if (bodyrelatedToType != null)
                {
                    body["relatedToType"] = SourceExpressionConverter.Convert(bodyrelatedToType);
                    bodypropCount++;
                }

                if (bodytaskSubTypeId != null)
                {
                    body["taskSubTypeId"] = SourceExpressionConverter.ConvertToken(bodytaskSubTypeId);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodyeditorBody != null)
                {
                    body["editorBody"] = SourceExpressionConverter.ConvertToken(bodyeditorBody);
                    bodypropCount++;
                }

                if (bodyreminderSet != null)
                {
                    body["reminderSet"] = SourceExpressionConverter.ConvertToken(bodyreminderSet);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodyparentId != null)
                {
                    body["parentId"] = SourceExpressionConverter.ConvertToken(bodyparentId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TaskApiFeaturesTasksTaskDTO>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesTasksTaskDTO> TaskGetById([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/Task/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TaskApiFeaturesTasksTaskDTO>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction TaskDelete([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/Task/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesTasksTaskDTO> TaskUpdate([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bodytaskTypeInput> bodytaskType = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<string> bodycompletedDate = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodypriorityId = null, [WorkflowExpression] Func<string> bodyassignedToId = null, [WorkflowExpression] Func<bodyassignedToTypeInput> bodyassignedToType = null, [WorkflowExpression] Func<string[]> bodycontactIds = null, [WorkflowExpression] Func<bodycontactTypeInput> bodycontactType = null, [WorkflowExpression] Func<string> bodyrelatedToId = null, [WorkflowExpression] Func<bodyrelatedToTypeInput> bodyrelatedToType = null, [WorkflowExpression] Func<string> bodytaskSubTypeId = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<string> bodyeditorBody = null, [WorkflowExpression] Func<bool> bodyreminderSet = null, [WorkflowExpression] Func<int> bodyposition = null, [WorkflowExpression] Func<string> bodyparentId = null, [WorkflowExpression] Func<string> bodylastModifiedBy = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytaskType, nameof(bodytaskType), required: false);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            SourceExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            SourceExpression.Validate(bodycompletedDate, nameof(bodycompletedDate), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodypriorityId, nameof(bodypriorityId), required: false);
            SourceExpression.Validate(bodyassignedToId, nameof(bodyassignedToId), required: false);
            SourceExpression.Validate(bodyassignedToType, nameof(bodyassignedToType), required: false);
            SourceExpression.Validate(bodycontactIds, nameof(bodycontactIds), required: false);
            SourceExpression.Validate(bodycontactType, nameof(bodycontactType), required: false);
            SourceExpression.Validate(bodyrelatedToId, nameof(bodyrelatedToId), required: false);
            SourceExpression.Validate(bodyrelatedToType, nameof(bodyrelatedToType), required: false);
            SourceExpression.Validate(bodytaskSubTypeId, nameof(bodytaskSubTypeId), required: false);
            SourceExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            SourceExpression.Validate(bodyeditorBody, nameof(bodyeditorBody), required: false);
            SourceExpression.Validate(bodyreminderSet, nameof(bodyreminderSet), required: false);
            SourceExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            SourceExpression.Validate(bodyparentId, nameof(bodyparentId), required: false);
            SourceExpression.Validate(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/Task/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytaskType != null)
                {
                    body["taskType"] = SourceExpressionConverter.Convert(bodytaskType);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["dueDate"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                    bodypropCount++;
                }

                if (bodycompletedDate != null)
                {
                    body["completedDate"] = SourceExpressionConverter.ConvertToken(bodycompletedDate);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                if (bodypriorityId != null)
                {
                    body["priorityId"] = SourceExpressionConverter.ConvertToken(bodypriorityId);
                    bodypropCount++;
                }

                if (bodyassignedToId != null)
                {
                    body["assignedToId"] = SourceExpressionConverter.ConvertToken(bodyassignedToId);
                    bodypropCount++;
                }

                if (bodyassignedToType != null)
                {
                    body["assignedToType"] = SourceExpressionConverter.Convert(bodyassignedToType);
                    bodypropCount++;
                }

                if (bodycontactIds != null)
                {
                    body["contactIds"] = SourceExpressionConverter.ConvertToken(bodycontactIds);
                    bodypropCount++;
                }

                if (bodycontactType != null)
                {
                    body["contactType"] = SourceExpressionConverter.Convert(bodycontactType);
                    bodypropCount++;
                }

                if (bodyrelatedToId != null)
                {
                    body["relatedToId"] = SourceExpressionConverter.ConvertToken(bodyrelatedToId);
                    bodypropCount++;
                }

                if (bodyrelatedToType != null)
                {
                    body["relatedToType"] = SourceExpressionConverter.Convert(bodyrelatedToType);
                    bodypropCount++;
                }

                if (bodytaskSubTypeId != null)
                {
                    body["taskSubTypeId"] = SourceExpressionConverter.ConvertToken(bodytaskSubTypeId);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodyeditorBody != null)
                {
                    body["editorBody"] = SourceExpressionConverter.ConvertToken(bodyeditorBody);
                    bodypropCount++;
                }

                if (bodyreminderSet != null)
                {
                    body["reminderSet"] = SourceExpressionConverter.ConvertToken(bodyreminderSet);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodyparentId != null)
                {
                    body["parentId"] = SourceExpressionConverter.ConvertToken(bodyparentId);
                    bodypropCount++;
                }

                if (bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = SourceExpressionConverter.ConvertToken(bodylastModifiedBy);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TaskApiFeaturesTasksTaskDTO>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesLeadLeadDto[]> LeadGetAll([WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> lastName = null, [WorkflowExpression] Func<string> insertDate = null, [WorkflowExpression] Func<string> phone = null, [WorkflowExpression] Func<string> mobilePhone = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> ownerId = null, [WorkflowExpression] Func<ownerTypeInput> ownerType = null, [WorkflowExpression] Func<string> accountSourceTypeId = null, [WorkflowExpression] Func<string> leadStatusId = null, [WorkflowExpression] Func<string> industryId = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(firstName, nameof(firstName), required: false);
            SourceExpression.Validate(lastName, nameof(lastName), required: false);
            SourceExpression.Validate(insertDate, nameof(insertDate), required: false);
            SourceExpression.Validate(phone, nameof(phone), required: false);
            SourceExpression.Validate(mobilePhone, nameof(mobilePhone), required: false);
            SourceExpression.Validate(email, nameof(email), required: false);
            SourceExpression.Validate(ownerId, nameof(ownerId), required: false);
            SourceExpression.Validate(ownerType, nameof(ownerType), required: false);
            SourceExpression.Validate(accountSourceTypeId, nameof(accountSourceTypeId), required: false);
            SourceExpression.Validate(leadStatusId, nameof(leadStatusId), required: false);
            SourceExpression.Validate(industryId, nameof(industryId), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Lead";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["Id"] = SourceExpressionConverter.ConvertO(id);
                if (name != null)
                    callPayload.Queries["Name"] = SourceExpressionConverter.ConvertO(name);
                if (firstName != null)
                    callPayload.Queries["FirstName"] = SourceExpressionConverter.ConvertO(firstName);
                if (lastName != null)
                    callPayload.Queries["LastName"] = SourceExpressionConverter.ConvertO(lastName);
                if (insertDate != null)
                    callPayload.Queries["InsertDate"] = SourceExpressionConverter.ConvertO(insertDate);
                if (phone != null)
                    callPayload.Queries["Phone"] = SourceExpressionConverter.ConvertO(phone);
                if (mobilePhone != null)
                    callPayload.Queries["MobilePhone"] = SourceExpressionConverter.ConvertO(mobilePhone);
                if (email != null)
                    callPayload.Queries["Email"] = SourceExpressionConverter.ConvertO(email);
                if (ownerId != null)
                    callPayload.Queries["OwnerId"] = SourceExpressionConverter.ConvertO(ownerId);
                if (ownerType != null)
                    callPayload.Queries["OwnerType"] = SourceExpressionConverter.Convert(ownerType);
                if (accountSourceTypeId != null)
                    callPayload.Queries["AccountSourceTypeId"] = SourceExpressionConverter.ConvertO(accountSourceTypeId);
                if (leadStatusId != null)
                    callPayload.Queries["LeadStatusId"] = SourceExpressionConverter.ConvertO(leadStatusId);
                if (industryId != null)
                    callPayload.Queries["IndustryId"] = SourceExpressionConverter.ConvertO(industryId);
                if (status != null)
                    callPayload.Queries["Status"] = SourceExpressionConverter.ConvertO(status);
                if (search != null)
                    callPayload.Queries["Search"] = SourceExpressionConverter.ConvertO(search);
                if (page != null)
                    callPayload.Queries["Page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<SalesPipelineApiFeaturesLeadLeadDto[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesLeadLeadDto> LeadCreate([WorkflowExpression] Func<string> bodynamefirstName, [WorkflowExpression] Func<string> bodyjobTitle = null, [WorkflowExpression] Func<string> bodyleadStatusId = null, [WorkflowExpression] Func<string> bodynamelastName = null, [WorkflowExpression] Func<string> bodynamemiddleName = null, [WorkflowExpression] Func<string> bodynamesalutationId = null, [WorkflowExpression] Func<string> bodynamesuffix = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodymobilePhone = null, [WorkflowExpression] Func<SalesPipelineApiDTOsEmailDTO[]> bodyotherEmail = null, [WorkflowExpression] Func<SalesPipelineApiDTOsPhoneDTO[]> bodyotherPhone = null, [WorkflowExpression] Func<bool> bodycallOptOut = null, [WorkflowExpression] Func<bool> bodyemailOptOut = null, [WorkflowExpression] Func<string> bodyratingId = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<bodyownerTypeInput> bodyownerType = null, [WorkflowExpression] Func<string> bodywebsite = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodyindustryId = null, [WorkflowExpression] Func<int> bodynoOfEmployees = null, [WorkflowExpression] Func<string> bodyaccountSourceTypeId = null, [WorkflowExpression] Func<string> bodyaddressaddress1 = null, [WorkflowExpression] Func<string> bodyaddressaddress2 = null, [WorkflowExpression] Func<string> bodyaddresscity = null, [WorkflowExpression] Func<string> bodyaddressstate = null, [WorkflowExpression] Func<string> bodyaddresscountry = null, [WorkflowExpression] Func<string> bodyaddresspostalCode = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<double> bodyannualRevenue = null, [WorkflowExpression] Func<string> bodylastTransferDate = null, [WorkflowExpression] Func<string> bodygenderId = null, [WorkflowExpression] Func<string> bodypronounceId = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null)
        {
            SourceExpression.Validate(bodynamefirstName, nameof(bodynamefirstName), required: true);
            SourceExpression.Validate(bodyjobTitle, nameof(bodyjobTitle), required: false);
            SourceExpression.Validate(bodyleadStatusId, nameof(bodyleadStatusId), required: false);
            SourceExpression.Validate(bodynamelastName, nameof(bodynamelastName), required: false);
            SourceExpression.Validate(bodynamemiddleName, nameof(bodynamemiddleName), required: false);
            SourceExpression.Validate(bodynamesalutationId, nameof(bodynamesalutationId), required: false);
            SourceExpression.Validate(bodynamesuffix, nameof(bodynamesuffix), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            SourceExpression.Validate(bodymobilePhone, nameof(bodymobilePhone), required: false);
            SourceExpression.Validate(bodyotherEmail, nameof(bodyotherEmail), required: false);
            SourceExpression.Validate(bodyotherPhone, nameof(bodyotherPhone), required: false);
            SourceExpression.Validate(bodycallOptOut, nameof(bodycallOptOut), required: false);
            SourceExpression.Validate(bodyemailOptOut, nameof(bodyemailOptOut), required: false);
            SourceExpression.Validate(bodyratingId, nameof(bodyratingId), required: false);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            SourceExpression.Validate(bodyownerType, nameof(bodyownerType), required: false);
            SourceExpression.Validate(bodywebsite, nameof(bodywebsite), required: false);
            SourceExpression.Validate(bodycompany, nameof(bodycompany), required: false);
            SourceExpression.Validate(bodyindustryId, nameof(bodyindustryId), required: false);
            SourceExpression.Validate(bodynoOfEmployees, nameof(bodynoOfEmployees), required: false);
            SourceExpression.Validate(bodyaccountSourceTypeId, nameof(bodyaccountSourceTypeId), required: false);
            SourceExpression.Validate(bodyaddressaddress1, nameof(bodyaddressaddress1), required: false);
            SourceExpression.Validate(bodyaddressaddress2, nameof(bodyaddressaddress2), required: false);
            SourceExpression.Validate(bodyaddresscity, nameof(bodyaddresscity), required: false);
            SourceExpression.Validate(bodyaddressstate, nameof(bodyaddressstate), required: false);
            SourceExpression.Validate(bodyaddresscountry, nameof(bodyaddresscountry), required: false);
            SourceExpression.Validate(bodyaddresspostalCode, nameof(bodyaddresspostalCode), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyannualRevenue, nameof(bodyannualRevenue), required: false);
            SourceExpression.Validate(bodylastTransferDate, nameof(bodylastTransferDate), required: false);
            SourceExpression.Validate(bodygenderId, nameof(bodygenderId), required: false);
            SourceExpression.Validate(bodypronounceId, nameof(bodypronounceId), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Lead";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyjobTitle != null)
                {
                    body["jobTitle"] = SourceExpressionConverter.ConvertToken(bodyjobTitle);
                    bodypropCount++;
                }

                if (bodyleadStatusId != null)
                {
                    body["leadStatusId"] = SourceExpressionConverter.ConvertToken(bodyleadStatusId);
                    bodypropCount++;
                }

                var nameObject = new JObject();
                var nameObjectpropCount = 0;
                nameObjectpropCount++;
                nameObject["firstName"] = SourceExpressionConverter.ConvertToken(bodynamefirstName);
                if (bodynamelastName != null)
                {
                    nameObject["lastName"] = SourceExpressionConverter.ConvertToken(bodynamelastName);
                    nameObjectpropCount++;
                }

                if (bodynamemiddleName != null)
                {
                    nameObject["middleName"] = SourceExpressionConverter.ConvertToken(bodynamemiddleName);
                    nameObjectpropCount++;
                }

                if (bodynamesalutationId != null)
                {
                    nameObject["salutationId"] = SourceExpressionConverter.ConvertToken(bodynamesalutationId);
                    nameObjectpropCount++;
                }

                if (bodynamesuffix != null)
                {
                    nameObject["suffix"] = SourceExpressionConverter.ConvertToken(bodynamesuffix);
                    nameObjectpropCount++;
                }

                if (nameObjectpropCount > 0)
                {
                    body["name"] = nameObject;
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                    bodypropCount++;
                }

                if (bodymobilePhone != null)
                {
                    body["mobilePhone"] = SourceExpressionConverter.ConvertToken(bodymobilePhone);
                    bodypropCount++;
                }

                if (bodyotherEmail != null)
                {
                    body["otherEmail"] = SourceExpressionConverter.ConvertToken(bodyotherEmail);
                    bodypropCount++;
                }

                if (bodyotherPhone != null)
                {
                    body["otherPhone"] = SourceExpressionConverter.ConvertToken(bodyotherPhone);
                    bodypropCount++;
                }

                if (bodycallOptOut != null)
                {
                    body["callOptOut"] = SourceExpressionConverter.ConvertToken(bodycallOptOut);
                    bodypropCount++;
                }

                if (bodyemailOptOut != null)
                {
                    body["emailOptOut"] = SourceExpressionConverter.ConvertToken(bodyemailOptOut);
                    bodypropCount++;
                }

                if (bodyratingId != null)
                {
                    body["ratingId"] = SourceExpressionConverter.ConvertToken(bodyratingId);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["ownerId"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                    bodypropCount++;
                }

                if (bodyownerType != null)
                {
                    body["ownerType"] = SourceExpressionConverter.Convert(bodyownerType);
                    bodypropCount++;
                }

                if (bodywebsite != null)
                {
                    body["website"] = SourceExpressionConverter.ConvertToken(bodywebsite);
                    bodypropCount++;
                }

                if (bodycompany != null)
                {
                    body["company"] = SourceExpressionConverter.ConvertToken(bodycompany);
                    bodypropCount++;
                }

                if (bodyindustryId != null)
                {
                    body["industryId"] = SourceExpressionConverter.ConvertToken(bodyindustryId);
                    bodypropCount++;
                }

                if (bodynoOfEmployees != null)
                {
                    body["noOfEmployees"] = SourceExpressionConverter.ConvertToken(bodynoOfEmployees);
                    bodypropCount++;
                }

                if (bodyaccountSourceTypeId != null)
                {
                    body["accountSourceTypeId"] = SourceExpressionConverter.ConvertToken(bodyaccountSourceTypeId);
                    bodypropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (bodyaddressaddress1 != null)
                {
                    addressObject["address1"] = SourceExpressionConverter.ConvertToken(bodyaddressaddress1);
                    addressObjectpropCount++;
                }

                if (bodyaddressaddress2 != null)
                {
                    addressObject["address2"] = SourceExpressionConverter.ConvertToken(bodyaddressaddress2);
                    addressObjectpropCount++;
                }

                if (bodyaddresscity != null)
                {
                    addressObject["city"] = SourceExpressionConverter.ConvertToken(bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (bodyaddressstate != null)
                {
                    addressObject["state"] = SourceExpressionConverter.ConvertToken(bodyaddressstate);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountry != null)
                {
                    addressObject["country"] = SourceExpressionConverter.ConvertToken(bodyaddresscountry);
                    addressObjectpropCount++;
                }

                if (bodyaddresspostalCode != null)
                {
                    addressObject["postalCode"] = SourceExpressionConverter.ConvertToken(bodyaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyannualRevenue != null)
                {
                    body["annualRevenue"] = SourceExpressionConverter.ConvertToken(bodyannualRevenue);
                    bodypropCount++;
                }

                if (bodylastTransferDate != null)
                {
                    body["lastTransferDate"] = SourceExpressionConverter.ConvertToken(bodylastTransferDate);
                    bodypropCount++;
                }

                if (bodygenderId != null)
                {
                    body["genderId"] = SourceExpressionConverter.ConvertToken(bodygenderId);
                    bodypropCount++;
                }

                if (bodypronounceId != null)
                {
                    body["pronounceId"] = SourceExpressionConverter.ConvertToken(bodypronounceId);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
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
                return callPayload;
            }

            return new ApiConnectionAction<SalesPipelineApiFeaturesLeadLeadDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesLeadLeadDto> LeadGetById([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/Lead/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SalesPipelineApiFeaturesLeadLeadDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction LeadDelete([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/Lead/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesLeadLeadDto> LeadUpdate([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodynamefirstName, [WorkflowExpression] Func<string> bodyjobTitle = null, [WorkflowExpression] Func<string> bodyleadStatusId = null, [WorkflowExpression] Func<string> bodynamelastName = null, [WorkflowExpression] Func<string> bodynamemiddleName = null, [WorkflowExpression] Func<string> bodynamesalutationId = null, [WorkflowExpression] Func<string> bodynamesuffix = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodymobilePhone = null, [WorkflowExpression] Func<SalesPipelineApiDTOsEmailDTO[]> bodyotherEmail = null, [WorkflowExpression] Func<SalesPipelineApiDTOsPhoneDTO[]> bodyotherPhone = null, [WorkflowExpression] Func<bool> bodycallOptOut = null, [WorkflowExpression] Func<bool> bodyemailOptOut = null, [WorkflowExpression] Func<string> bodyratingId = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<bodyownerTypeInput> bodyownerType = null, [WorkflowExpression] Func<string> bodywebsite = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodyindustryId = null, [WorkflowExpression] Func<int> bodynoOfEmployees = null, [WorkflowExpression] Func<string> bodyaccountSourceTypeId = null, [WorkflowExpression] Func<string> bodyaddressaddress1 = null, [WorkflowExpression] Func<string> bodyaddressaddress2 = null, [WorkflowExpression] Func<string> bodyaddresscity = null, [WorkflowExpression] Func<string> bodyaddressstate = null, [WorkflowExpression] Func<string> bodyaddresscountry = null, [WorkflowExpression] Func<string> bodyaddresspostalCode = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<double> bodyannualRevenue = null, [WorkflowExpression] Func<string> bodylastTransferDate = null, [WorkflowExpression] Func<string> bodygenderId = null, [WorkflowExpression] Func<string> bodypronounceId = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodylastModifiedBy = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodynamefirstName, nameof(bodynamefirstName), required: true);
            SourceExpression.Validate(bodyjobTitle, nameof(bodyjobTitle), required: false);
            SourceExpression.Validate(bodyleadStatusId, nameof(bodyleadStatusId), required: false);
            SourceExpression.Validate(bodynamelastName, nameof(bodynamelastName), required: false);
            SourceExpression.Validate(bodynamemiddleName, nameof(bodynamemiddleName), required: false);
            SourceExpression.Validate(bodynamesalutationId, nameof(bodynamesalutationId), required: false);
            SourceExpression.Validate(bodynamesuffix, nameof(bodynamesuffix), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            SourceExpression.Validate(bodymobilePhone, nameof(bodymobilePhone), required: false);
            SourceExpression.Validate(bodyotherEmail, nameof(bodyotherEmail), required: false);
            SourceExpression.Validate(bodyotherPhone, nameof(bodyotherPhone), required: false);
            SourceExpression.Validate(bodycallOptOut, nameof(bodycallOptOut), required: false);
            SourceExpression.Validate(bodyemailOptOut, nameof(bodyemailOptOut), required: false);
            SourceExpression.Validate(bodyratingId, nameof(bodyratingId), required: false);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            SourceExpression.Validate(bodyownerType, nameof(bodyownerType), required: false);
            SourceExpression.Validate(bodywebsite, nameof(bodywebsite), required: false);
            SourceExpression.Validate(bodycompany, nameof(bodycompany), required: false);
            SourceExpression.Validate(bodyindustryId, nameof(bodyindustryId), required: false);
            SourceExpression.Validate(bodynoOfEmployees, nameof(bodynoOfEmployees), required: false);
            SourceExpression.Validate(bodyaccountSourceTypeId, nameof(bodyaccountSourceTypeId), required: false);
            SourceExpression.Validate(bodyaddressaddress1, nameof(bodyaddressaddress1), required: false);
            SourceExpression.Validate(bodyaddressaddress2, nameof(bodyaddressaddress2), required: false);
            SourceExpression.Validate(bodyaddresscity, nameof(bodyaddresscity), required: false);
            SourceExpression.Validate(bodyaddressstate, nameof(bodyaddressstate), required: false);
            SourceExpression.Validate(bodyaddresscountry, nameof(bodyaddresscountry), required: false);
            SourceExpression.Validate(bodyaddresspostalCode, nameof(bodyaddresspostalCode), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyannualRevenue, nameof(bodyannualRevenue), required: false);
            SourceExpression.Validate(bodylastTransferDate, nameof(bodylastTransferDate), required: false);
            SourceExpression.Validate(bodygenderId, nameof(bodygenderId), required: false);
            SourceExpression.Validate(bodypronounceId, nameof(bodypronounceId), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/Lead/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyjobTitle != null)
                {
                    body["jobTitle"] = SourceExpressionConverter.ConvertToken(bodyjobTitle);
                    bodypropCount++;
                }

                if (bodyleadStatusId != null)
                {
                    body["leadStatusId"] = SourceExpressionConverter.ConvertToken(bodyleadStatusId);
                    bodypropCount++;
                }

                var nameObject = new JObject();
                var nameObjectpropCount = 0;
                nameObjectpropCount++;
                nameObject["firstName"] = SourceExpressionConverter.ConvertToken(bodynamefirstName);
                if (bodynamelastName != null)
                {
                    nameObject["lastName"] = SourceExpressionConverter.ConvertToken(bodynamelastName);
                    nameObjectpropCount++;
                }

                if (bodynamemiddleName != null)
                {
                    nameObject["middleName"] = SourceExpressionConverter.ConvertToken(bodynamemiddleName);
                    nameObjectpropCount++;
                }

                if (bodynamesalutationId != null)
                {
                    nameObject["salutationId"] = SourceExpressionConverter.ConvertToken(bodynamesalutationId);
                    nameObjectpropCount++;
                }

                if (bodynamesuffix != null)
                {
                    nameObject["suffix"] = SourceExpressionConverter.ConvertToken(bodynamesuffix);
                    nameObjectpropCount++;
                }

                if (nameObjectpropCount > 0)
                {
                    body["name"] = nameObject;
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                    bodypropCount++;
                }

                if (bodymobilePhone != null)
                {
                    body["mobilePhone"] = SourceExpressionConverter.ConvertToken(bodymobilePhone);
                    bodypropCount++;
                }

                if (bodyotherEmail != null)
                {
                    body["otherEmail"] = SourceExpressionConverter.ConvertToken(bodyotherEmail);
                    bodypropCount++;
                }

                if (bodyotherPhone != null)
                {
                    body["otherPhone"] = SourceExpressionConverter.ConvertToken(bodyotherPhone);
                    bodypropCount++;
                }

                if (bodycallOptOut != null)
                {
                    body["callOptOut"] = SourceExpressionConverter.ConvertToken(bodycallOptOut);
                    bodypropCount++;
                }

                if (bodyemailOptOut != null)
                {
                    body["emailOptOut"] = SourceExpressionConverter.ConvertToken(bodyemailOptOut);
                    bodypropCount++;
                }

                if (bodyratingId != null)
                {
                    body["ratingId"] = SourceExpressionConverter.ConvertToken(bodyratingId);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["ownerId"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                    bodypropCount++;
                }

                if (bodyownerType != null)
                {
                    body["ownerType"] = SourceExpressionConverter.Convert(bodyownerType);
                    bodypropCount++;
                }

                if (bodywebsite != null)
                {
                    body["website"] = SourceExpressionConverter.ConvertToken(bodywebsite);
                    bodypropCount++;
                }

                if (bodycompany != null)
                {
                    body["company"] = SourceExpressionConverter.ConvertToken(bodycompany);
                    bodypropCount++;
                }

                if (bodyindustryId != null)
                {
                    body["industryId"] = SourceExpressionConverter.ConvertToken(bodyindustryId);
                    bodypropCount++;
                }

                if (bodynoOfEmployees != null)
                {
                    body["noOfEmployees"] = SourceExpressionConverter.ConvertToken(bodynoOfEmployees);
                    bodypropCount++;
                }

                if (bodyaccountSourceTypeId != null)
                {
                    body["accountSourceTypeId"] = SourceExpressionConverter.ConvertToken(bodyaccountSourceTypeId);
                    bodypropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (bodyaddressaddress1 != null)
                {
                    addressObject["address1"] = SourceExpressionConverter.ConvertToken(bodyaddressaddress1);
                    addressObjectpropCount++;
                }

                if (bodyaddressaddress2 != null)
                {
                    addressObject["address2"] = SourceExpressionConverter.ConvertToken(bodyaddressaddress2);
                    addressObjectpropCount++;
                }

                if (bodyaddresscity != null)
                {
                    addressObject["city"] = SourceExpressionConverter.ConvertToken(bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (bodyaddressstate != null)
                {
                    addressObject["state"] = SourceExpressionConverter.ConvertToken(bodyaddressstate);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountry != null)
                {
                    addressObject["country"] = SourceExpressionConverter.ConvertToken(bodyaddresscountry);
                    addressObjectpropCount++;
                }

                if (bodyaddresspostalCode != null)
                {
                    addressObject["postalCode"] = SourceExpressionConverter.ConvertToken(bodyaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyannualRevenue != null)
                {
                    body["annualRevenue"] = SourceExpressionConverter.ConvertToken(bodyannualRevenue);
                    bodypropCount++;
                }

                if (bodylastTransferDate != null)
                {
                    body["lastTransferDate"] = SourceExpressionConverter.ConvertToken(bodylastTransferDate);
                    bodypropCount++;
                }

                if (bodygenderId != null)
                {
                    body["genderId"] = SourceExpressionConverter.ConvertToken(bodygenderId);
                    bodypropCount++;
                }

                if (bodypronounceId != null)
                {
                    body["pronounceId"] = SourceExpressionConverter.ConvertToken(bodypronounceId);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                if (bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = SourceExpressionConverter.ConvertToken(bodylastModifiedBy);
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
                return callPayload;
            }

            return new ApiConnectionAction<SalesPipelineApiFeaturesLeadLeadDto>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO[]> OpportunityGetAll([WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> ownerId = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<double> amount = null, [WorkflowExpression] Func<string> closeDate = null, [WorkflowExpression] Func<string> updateDate = null, [WorkflowExpression] Func<string> insertDate = null, [WorkflowExpression] Func<string> accountId = null, [WorkflowExpression] Func<string> forecastCategoryId = null, [WorkflowExpression] Func<string> accountSourceTypeId = null, [WorkflowExpression] Func<string> opportunityStatusId = null, [WorkflowExpression] Func<string> quoteId = null, [WorkflowExpression] Func<string> lossReasonId = null, [WorkflowExpression] Func<string> typeId = null, [WorkflowExpression] Func<string> lastModifiedBy = null, [WorkflowExpression] Func<string> createdBy = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> salesPipelineId = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(ownerId, nameof(ownerId), required: false);
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(amount, nameof(amount), required: false);
            SourceExpression.Validate(closeDate, nameof(closeDate), required: false);
            SourceExpression.Validate(updateDate, nameof(updateDate), required: false);
            SourceExpression.Validate(insertDate, nameof(insertDate), required: false);
            SourceExpression.Validate(accountId, nameof(accountId), required: false);
            SourceExpression.Validate(forecastCategoryId, nameof(forecastCategoryId), required: false);
            SourceExpression.Validate(accountSourceTypeId, nameof(accountSourceTypeId), required: false);
            SourceExpression.Validate(opportunityStatusId, nameof(opportunityStatusId), required: false);
            SourceExpression.Validate(quoteId, nameof(quoteId), required: false);
            SourceExpression.Validate(lossReasonId, nameof(lossReasonId), required: false);
            SourceExpression.Validate(typeId, nameof(typeId), required: false);
            SourceExpression.Validate(lastModifiedBy, nameof(lastModifiedBy), required: false);
            SourceExpression.Validate(createdBy, nameof(createdBy), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(salesPipelineId, nameof(salesPipelineId), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Opportunity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["Id"] = SourceExpressionConverter.ConvertO(id);
                if (ownerId != null)
                    callPayload.Queries["OwnerId"] = SourceExpressionConverter.ConvertO(ownerId);
                if (name != null)
                    callPayload.Queries["Name"] = SourceExpressionConverter.ConvertO(name);
                if (amount != null)
                    callPayload.Queries["Amount"] = SourceExpressionConverter.ConvertO(amount);
                if (closeDate != null)
                    callPayload.Queries["CloseDate"] = SourceExpressionConverter.ConvertO(closeDate);
                if (updateDate != null)
                    callPayload.Queries["UpdateDate"] = SourceExpressionConverter.ConvertO(updateDate);
                if (insertDate != null)
                    callPayload.Queries["InsertDate"] = SourceExpressionConverter.ConvertO(insertDate);
                if (accountId != null)
                    callPayload.Queries["AccountId"] = SourceExpressionConverter.ConvertO(accountId);
                if (forecastCategoryId != null)
                    callPayload.Queries["ForecastCategoryId"] = SourceExpressionConverter.ConvertO(forecastCategoryId);
                if (accountSourceTypeId != null)
                    callPayload.Queries["AccountSourceTypeId"] = SourceExpressionConverter.ConvertO(accountSourceTypeId);
                if (opportunityStatusId != null)
                    callPayload.Queries["OpportunityStatusId"] = SourceExpressionConverter.ConvertO(opportunityStatusId);
                if (quoteId != null)
                    callPayload.Queries["QuoteId"] = SourceExpressionConverter.ConvertO(quoteId);
                if (lossReasonId != null)
                    callPayload.Queries["LossReasonId"] = SourceExpressionConverter.ConvertO(lossReasonId);
                if (typeId != null)
                    callPayload.Queries["TypeId"] = SourceExpressionConverter.ConvertO(typeId);
                if (lastModifiedBy != null)
                    callPayload.Queries["LastModifiedBy"] = SourceExpressionConverter.ConvertO(lastModifiedBy);
                if (createdBy != null)
                    callPayload.Queries["CreatedBy"] = SourceExpressionConverter.ConvertO(createdBy);
                if (search != null)
                    callPayload.Queries["Search"] = SourceExpressionConverter.ConvertO(search);
                if (salesPipelineId != null)
                    callPayload.Queries["SalesPipelineId"] = SourceExpressionConverter.ConvertO(salesPipelineId);
                if (status != null)
                    callPayload.Queries["Status"] = SourceExpressionConverter.ConvertO(status);
                if (page != null)
                    callPayload.Queries["Page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO> OpportunityCreate([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodycloseDate, [WorkflowExpression] Func<string> bodytypeId = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodyaccountId = null, [WorkflowExpression] Func<double> bodyamount = null, [WorkflowExpression] Func<string> bodyforecastCategoryId = null, [WorkflowExpression] Func<string> bodysalesPipelineId = null, [WorkflowExpression] Func<int> bodyprobability = null, [WorkflowExpression] Func<int> bodyscore = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyquoteId = null, [WorkflowExpression] Func<string> bodyopportunityStatusId = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodyaccountSourceTypeId = null, [WorkflowExpression] Func<string> bodynextStep = null, [WorkflowExpression] Func<bool> bodybudgetConfirmed = null, [WorkflowExpression] Func<bool> bodydiscoveryCompleted = null, [WorkflowExpression] Func<double> bodyexpectedRevenue = null, [WorkflowExpression] Func<string> bodylossReasonId = null, [WorkflowExpression] Func<bool> bodyprivate = null)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodycloseDate, nameof(bodycloseDate), required: true);
            SourceExpression.Validate(bodytypeId, nameof(bodytypeId), required: false);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            SourceExpression.Validate(bodyaccountId, nameof(bodyaccountId), required: false);
            SourceExpression.Validate(bodyamount, nameof(bodyamount), required: false);
            SourceExpression.Validate(bodyforecastCategoryId, nameof(bodyforecastCategoryId), required: false);
            SourceExpression.Validate(bodysalesPipelineId, nameof(bodysalesPipelineId), required: false);
            SourceExpression.Validate(bodyprobability, nameof(bodyprobability), required: false);
            SourceExpression.Validate(bodyscore, nameof(bodyscore), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyquoteId, nameof(bodyquoteId), required: false);
            SourceExpression.Validate(bodyopportunityStatusId, nameof(bodyopportunityStatusId), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodyaccountSourceTypeId, nameof(bodyaccountSourceTypeId), required: false);
            SourceExpression.Validate(bodynextStep, nameof(bodynextStep), required: false);
            SourceExpression.Validate(bodybudgetConfirmed, nameof(bodybudgetConfirmed), required: false);
            SourceExpression.Validate(bodydiscoveryCompleted, nameof(bodydiscoveryCompleted), required: false);
            SourceExpression.Validate(bodyexpectedRevenue, nameof(bodyexpectedRevenue), required: false);
            SourceExpression.Validate(bodylossReasonId, nameof(bodylossReasonId), required: false);
            SourceExpression.Validate(bodyprivate, nameof(bodyprivate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Opportunity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytypeId != null)
                {
                    body["typeId"] = SourceExpressionConverter.ConvertToken(bodytypeId);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["ownerId"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                    bodypropCount++;
                }

                if (bodyaccountId != null)
                {
                    body["accountId"] = SourceExpressionConverter.ConvertToken(bodyaccountId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodyamount != null)
                {
                    body["amount"] = SourceExpressionConverter.ConvertToken(bodyamount);
                    bodypropCount++;
                }

                if (bodyforecastCategoryId != null)
                {
                    body["forecastCategoryId"] = SourceExpressionConverter.ConvertToken(bodyforecastCategoryId);
                    bodypropCount++;
                }

                if (bodysalesPipelineId != null)
                {
                    body["salesPipelineId"] = SourceExpressionConverter.ConvertToken(bodysalesPipelineId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["closeDate"] = SourceExpressionConverter.ConvertToken(bodycloseDate);
                if (bodyprobability != null)
                {
                    body["probability"] = SourceExpressionConverter.ConvertToken(bodyprobability);
                    bodypropCount++;
                }

                if (bodyscore != null)
                {
                    body["score"] = SourceExpressionConverter.ConvertToken(bodyscore);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyquoteId != null)
                {
                    body["quoteId"] = SourceExpressionConverter.ConvertToken(bodyquoteId);
                    bodypropCount++;
                }

                if (bodyopportunityStatusId != null)
                {
                    body["opportunityStatusId"] = SourceExpressionConverter.ConvertToken(bodyopportunityStatusId);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                if (bodyaccountSourceTypeId != null)
                {
                    body["accountSourceTypeId"] = SourceExpressionConverter.ConvertToken(bodyaccountSourceTypeId);
                    bodypropCount++;
                }

                if (bodynextStep != null)
                {
                    body["nextStep"] = SourceExpressionConverter.ConvertToken(bodynextStep);
                    bodypropCount++;
                }

                if (bodybudgetConfirmed != null)
                {
                    body["budgetConfirmed"] = SourceExpressionConverter.ConvertToken(bodybudgetConfirmed);
                    bodypropCount++;
                }

                if (bodydiscoveryCompleted != null)
                {
                    body["discoveryCompleted"] = SourceExpressionConverter.ConvertToken(bodydiscoveryCompleted);
                    bodypropCount++;
                }

                if (bodyexpectedRevenue != null)
                {
                    body["expectedRevenue"] = SourceExpressionConverter.ConvertToken(bodyexpectedRevenue);
                    bodypropCount++;
                }

                if (bodylossReasonId != null)
                {
                    body["lossReasonId"] = SourceExpressionConverter.ConvertToken(bodylossReasonId);
                    bodypropCount++;
                }

                if (bodyprivate != null)
                {
                    body["private"] = SourceExpressionConverter.ConvertToken(bodyprivate);
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
                return callPayload;
            }

            return new ApiConnectionAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO> OpportunityGetById([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/Opportunity/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction OpportunityDelete([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/Opportunity/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO> OpportunityUpdate([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytypeId = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodyaccountId = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<double> bodyamount = null, [WorkflowExpression] Func<string> bodyforecastCategoryId = null, [WorkflowExpression] Func<string> bodycloseDate = null, [WorkflowExpression] Func<int> bodyprobability = null, [WorkflowExpression] Func<int> bodyscore = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodysalesPipelineId = null, [WorkflowExpression] Func<string> bodyquoteId = null, [WorkflowExpression] Func<string> bodyopportunityStatusId = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodyaccountSourceTypeId = null, [WorkflowExpression] Func<string> bodynextStep = null, [WorkflowExpression] Func<bool> bodybudgetConfirmed = null, [WorkflowExpression] Func<bool> bodydiscoveryCompleted = null, [WorkflowExpression] Func<double> bodyexpectedRevenue = null, [WorkflowExpression] Func<string> bodylossReasonId = null, [WorkflowExpression] Func<bool> bodyprivate = null, [WorkflowExpression] Func<string> bodylastModifiedBy = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytypeId, nameof(bodytypeId), required: false);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            SourceExpression.Validate(bodyaccountId, nameof(bodyaccountId), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyamount, nameof(bodyamount), required: false);
            SourceExpression.Validate(bodyforecastCategoryId, nameof(bodyforecastCategoryId), required: false);
            SourceExpression.Validate(bodycloseDate, nameof(bodycloseDate), required: false);
            SourceExpression.Validate(bodyprobability, nameof(bodyprobability), required: false);
            SourceExpression.Validate(bodyscore, nameof(bodyscore), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodysalesPipelineId, nameof(bodysalesPipelineId), required: false);
            SourceExpression.Validate(bodyquoteId, nameof(bodyquoteId), required: false);
            SourceExpression.Validate(bodyopportunityStatusId, nameof(bodyopportunityStatusId), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodyaccountSourceTypeId, nameof(bodyaccountSourceTypeId), required: false);
            SourceExpression.Validate(bodynextStep, nameof(bodynextStep), required: false);
            SourceExpression.Validate(bodybudgetConfirmed, nameof(bodybudgetConfirmed), required: false);
            SourceExpression.Validate(bodydiscoveryCompleted, nameof(bodydiscoveryCompleted), required: false);
            SourceExpression.Validate(bodyexpectedRevenue, nameof(bodyexpectedRevenue), required: false);
            SourceExpression.Validate(bodylossReasonId, nameof(bodylossReasonId), required: false);
            SourceExpression.Validate(bodyprivate, nameof(bodyprivate), required: false);
            SourceExpression.Validate(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/Opportunity/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytypeId != null)
                {
                    body["typeId"] = SourceExpressionConverter.ConvertToken(bodytypeId);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["ownerId"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                    bodypropCount++;
                }

                if (bodyaccountId != null)
                {
                    body["accountId"] = SourceExpressionConverter.ConvertToken(bodyaccountId);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyamount != null)
                {
                    body["amount"] = SourceExpressionConverter.ConvertToken(bodyamount);
                    bodypropCount++;
                }

                if (bodyforecastCategoryId != null)
                {
                    body["forecastCategoryId"] = SourceExpressionConverter.ConvertToken(bodyforecastCategoryId);
                    bodypropCount++;
                }

                if (bodycloseDate != null)
                {
                    body["closeDate"] = SourceExpressionConverter.ConvertToken(bodycloseDate);
                    bodypropCount++;
                }

                if (bodyprobability != null)
                {
                    body["probability"] = SourceExpressionConverter.ConvertToken(bodyprobability);
                    bodypropCount++;
                }

                if (bodyscore != null)
                {
                    body["score"] = SourceExpressionConverter.ConvertToken(bodyscore);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodysalesPipelineId != null)
                {
                    body["salesPipelineId"] = SourceExpressionConverter.ConvertToken(bodysalesPipelineId);
                    bodypropCount++;
                }

                if (bodyquoteId != null)
                {
                    body["quoteId"] = SourceExpressionConverter.ConvertToken(bodyquoteId);
                    bodypropCount++;
                }

                if (bodyopportunityStatusId != null)
                {
                    body["opportunityStatusId"] = SourceExpressionConverter.ConvertToken(bodyopportunityStatusId);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                if (bodyaccountSourceTypeId != null)
                {
                    body["accountSourceTypeId"] = SourceExpressionConverter.ConvertToken(bodyaccountSourceTypeId);
                    bodypropCount++;
                }

                if (bodynextStep != null)
                {
                    body["nextStep"] = SourceExpressionConverter.ConvertToken(bodynextStep);
                    bodypropCount++;
                }

                if (bodybudgetConfirmed != null)
                {
                    body["budgetConfirmed"] = SourceExpressionConverter.ConvertToken(bodybudgetConfirmed);
                    bodypropCount++;
                }

                if (bodydiscoveryCompleted != null)
                {
                    body["discoveryCompleted"] = SourceExpressionConverter.ConvertToken(bodydiscoveryCompleted);
                    bodypropCount++;
                }

                if (bodyexpectedRevenue != null)
                {
                    body["expectedRevenue"] = SourceExpressionConverter.ConvertToken(bodyexpectedRevenue);
                    bodypropCount++;
                }

                if (bodylossReasonId != null)
                {
                    body["lossReasonId"] = SourceExpressionConverter.ConvertToken(bodylossReasonId);
                    bodypropCount++;
                }

                if (bodyprivate != null)
                {
                    body["private"] = SourceExpressionConverter.ConvertToken(bodyprivate);
                    bodypropCount++;
                }

                if (bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = SourceExpressionConverter.ConvertToken(bodylastModifiedBy);
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
                return callPayload;
            }

            return new ApiConnectionAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<IdentityApiBackOfficeUsersGetUserGetUserResponse> UserGetById([WorkflowExpression] Func<string> userId)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IdentityApiBackOfficeUsersGetUserGetUserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<IdentityApiTeamsDtosGetTeamResponse> TeamGetById([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/teams/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IdentityApiTeamsDtosGetTeamResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<CustomerApiFeaturesAccountsAccountDTO> AccountGetById([WorkflowExpression] Func<string> accountId)
        {
            SourceExpression.Validate(accountId, nameof(accountId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/Account/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CustomerApiFeaturesAccountsAccountDTO>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction AccountDelete([WorkflowExpression] Func<string> accountId)
        {
            SourceExpression.Validate(accountId, nameof(accountId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/Account/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<CustomerApiFeaturesAccountsAccountDTO> AccountUpdate([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodytin = null, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodysourceId = null, [WorkflowExpression] Func<string> bodysourceParentId = null, [WorkflowExpression] Func<string> bodysourceOwnerId = null, [WorkflowExpression] Func<string[]> bodyprimaryContactIds = null, [WorkflowExpression] Func<string> bodyparentAccountId = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodyaddressaddress1 = null, [WorkflowExpression] Func<string> bodyaddressaddress2 = null, [WorkflowExpression] Func<string> bodyaddresscity = null, [WorkflowExpression] Func<string> bodyaddressstate = null, [WorkflowExpression] Func<string> bodyaddresslatitude = null, [WorkflowExpression] Func<string> bodyaddresslongtitude = null, [WorkflowExpression] Func<string> bodyaddresscountry = null, [WorkflowExpression] Func<string> bodyaddresscountryCode = null, [WorkflowExpression] Func<string> bodyaddresspostalCode = null, [WorkflowExpression] Func<string> bodyaddressfirstName = null, [WorkflowExpression] Func<string> bodyaddresslastName = null, [WorkflowExpression] Func<string> bodyaddressphoneNumber = null, [WorkflowExpression] Func<string> bodyaddressemail = null, [WorkflowExpression] Func<string> bodyaccountSourceTypeId = null, [WorkflowExpression] Func<string> bodyindustryId = null, [WorkflowExpression] Func<string> bodytierId = null, [WorkflowExpression] Func<string> bodywebsite = null, [WorkflowExpression] Func<string> bodyaccountDescription = null, [WorkflowExpression] Func<int> bodynoOfEmployees = null, [WorkflowExpression] Func<double> bodyannualRevenue = null, [WorkflowExpression] Func<string> bodycreatedBy = null, [WorkflowExpression] Func<string> bodylastModifiedBy = null, [WorkflowExpression] Func<string> bodyfax = null, [WorkflowExpression] Func<string> bodyownershipId = null, [WorkflowExpression] Func<string> bodyratingId = null, [WorkflowExpression] Func<string> bodyclassificationId = null, [WorkflowExpression] Func<string[]> bodyassignedTeams = null)
        {
            SourceExpression.Validate(accountId, nameof(accountId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            SourceExpression.Validate(bodytin, nameof(bodytin), required: false);
            SourceExpression.Validate(bodycode, nameof(bodycode), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodysourceId, nameof(bodysourceId), required: false);
            SourceExpression.Validate(bodysourceParentId, nameof(bodysourceParentId), required: false);
            SourceExpression.Validate(bodysourceOwnerId, nameof(bodysourceOwnerId), required: false);
            SourceExpression.Validate(bodyprimaryContactIds, nameof(bodyprimaryContactIds), required: false);
            SourceExpression.Validate(bodyparentAccountId, nameof(bodyparentAccountId), required: false);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            SourceExpression.Validate(bodyaddressaddress1, nameof(bodyaddressaddress1), required: false);
            SourceExpression.Validate(bodyaddressaddress2, nameof(bodyaddressaddress2), required: false);
            SourceExpression.Validate(bodyaddresscity, nameof(bodyaddresscity), required: false);
            SourceExpression.Validate(bodyaddressstate, nameof(bodyaddressstate), required: false);
            SourceExpression.Validate(bodyaddresslatitude, nameof(bodyaddresslatitude), required: false);
            SourceExpression.Validate(bodyaddresslongtitude, nameof(bodyaddresslongtitude), required: false);
            SourceExpression.Validate(bodyaddresscountry, nameof(bodyaddresscountry), required: false);
            SourceExpression.Validate(bodyaddresscountryCode, nameof(bodyaddresscountryCode), required: false);
            SourceExpression.Validate(bodyaddresspostalCode, nameof(bodyaddresspostalCode), required: false);
            SourceExpression.Validate(bodyaddressfirstName, nameof(bodyaddressfirstName), required: false);
            SourceExpression.Validate(bodyaddresslastName, nameof(bodyaddresslastName), required: false);
            SourceExpression.Validate(bodyaddressphoneNumber, nameof(bodyaddressphoneNumber), required: false);
            SourceExpression.Validate(bodyaddressemail, nameof(bodyaddressemail), required: false);
            SourceExpression.Validate(bodyaccountSourceTypeId, nameof(bodyaccountSourceTypeId), required: false);
            SourceExpression.Validate(bodyindustryId, nameof(bodyindustryId), required: false);
            SourceExpression.Validate(bodytierId, nameof(bodytierId), required: false);
            SourceExpression.Validate(bodywebsite, nameof(bodywebsite), required: false);
            SourceExpression.Validate(bodyaccountDescription, nameof(bodyaccountDescription), required: false);
            SourceExpression.Validate(bodynoOfEmployees, nameof(bodynoOfEmployees), required: false);
            SourceExpression.Validate(bodyannualRevenue, nameof(bodyannualRevenue), required: false);
            SourceExpression.Validate(bodycreatedBy, nameof(bodycreatedBy), required: false);
            SourceExpression.Validate(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            SourceExpression.Validate(bodyfax, nameof(bodyfax), required: false);
            SourceExpression.Validate(bodyownershipId, nameof(bodyownershipId), required: false);
            SourceExpression.Validate(bodyratingId, nameof(bodyratingId), required: false);
            SourceExpression.Validate(bodyclassificationId, nameof(bodyclassificationId), required: false);
            SourceExpression.Validate(bodyassignedTeams, nameof(bodyassignedTeams), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/Account/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                    bodypropCount++;
                }

                if (bodytin != null)
                {
                    body["tin"] = SourceExpressionConverter.ConvertToken(bodytin);
                    bodypropCount++;
                }

                if (bodycode != null)
                {
                    body["code"] = SourceExpressionConverter.ConvertToken(bodycode);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodysourceId != null)
                {
                    body["sourceId"] = SourceExpressionConverter.ConvertToken(bodysourceId);
                    bodypropCount++;
                }

                if (bodysourceParentId != null)
                {
                    body["sourceParentId"] = SourceExpressionConverter.ConvertToken(bodysourceParentId);
                    bodypropCount++;
                }

                if (bodysourceOwnerId != null)
                {
                    body["sourceOwnerId"] = SourceExpressionConverter.ConvertToken(bodysourceOwnerId);
                    bodypropCount++;
                }

                if (bodyprimaryContactIds != null)
                {
                    body["primaryContactIds"] = SourceExpressionConverter.ConvertToken(bodyprimaryContactIds);
                    bodypropCount++;
                }

                if (bodyparentAccountId != null)
                {
                    body["parentAccountId"] = SourceExpressionConverter.ConvertToken(bodyparentAccountId);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["ownerId"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                    bodypropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (bodyaddressaddress1 != null)
                {
                    addressObject["address1"] = SourceExpressionConverter.ConvertToken(bodyaddressaddress1);
                    addressObjectpropCount++;
                }

                if (bodyaddressaddress2 != null)
                {
                    addressObject["address2"] = SourceExpressionConverter.ConvertToken(bodyaddressaddress2);
                    addressObjectpropCount++;
                }

                if (bodyaddresscity != null)
                {
                    addressObject["city"] = SourceExpressionConverter.ConvertToken(bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (bodyaddressstate != null)
                {
                    addressObject["state"] = SourceExpressionConverter.ConvertToken(bodyaddressstate);
                    addressObjectpropCount++;
                }

                if (bodyaddresslatitude != null)
                {
                    addressObject["latitude"] = SourceExpressionConverter.ConvertToken(bodyaddresslatitude);
                    addressObjectpropCount++;
                }

                if (bodyaddresslongtitude != null)
                {
                    addressObject["longtitude"] = SourceExpressionConverter.ConvertToken(bodyaddresslongtitude);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountry != null)
                {
                    addressObject["country"] = SourceExpressionConverter.ConvertToken(bodyaddresscountry);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountryCode != null)
                {
                    addressObject["countryCode"] = SourceExpressionConverter.ConvertToken(bodyaddresscountryCode);
                    addressObjectpropCount++;
                }

                if (bodyaddresspostalCode != null)
                {
                    addressObject["postalCode"] = SourceExpressionConverter.ConvertToken(bodyaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (bodyaddressfirstName != null)
                {
                    addressObject["firstName"] = SourceExpressionConverter.ConvertToken(bodyaddressfirstName);
                    addressObjectpropCount++;
                }

                if (bodyaddresslastName != null)
                {
                    addressObject["lastName"] = SourceExpressionConverter.ConvertToken(bodyaddresslastName);
                    addressObjectpropCount++;
                }

                if (bodyaddressphoneNumber != null)
                {
                    addressObject["phoneNumber"] = SourceExpressionConverter.ConvertToken(bodyaddressphoneNumber);
                    addressObjectpropCount++;
                }

                if (bodyaddressemail != null)
                {
                    addressObject["email"] = SourceExpressionConverter.ConvertToken(bodyaddressemail);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                if (bodyaccountSourceTypeId != null)
                {
                    body["accountSourceTypeId"] = SourceExpressionConverter.ConvertToken(bodyaccountSourceTypeId);
                    bodypropCount++;
                }

                if (bodyindustryId != null)
                {
                    body["industryId"] = SourceExpressionConverter.ConvertToken(bodyindustryId);
                    bodypropCount++;
                }

                if (bodytierId != null)
                {
                    body["tierId"] = SourceExpressionConverter.ConvertToken(bodytierId);
                    bodypropCount++;
                }

                if (bodywebsite != null)
                {
                    body["website"] = SourceExpressionConverter.ConvertToken(bodywebsite);
                    bodypropCount++;
                }

                if (bodyaccountDescription != null)
                {
                    body["accountDescription"] = SourceExpressionConverter.ConvertToken(bodyaccountDescription);
                    bodypropCount++;
                }

                if (bodynoOfEmployees != null)
                {
                    body["noOfEmployees"] = SourceExpressionConverter.ConvertToken(bodynoOfEmployees);
                    bodypropCount++;
                }

                if (bodyannualRevenue != null)
                {
                    body["annualRevenue"] = SourceExpressionConverter.ConvertToken(bodyannualRevenue);
                    bodypropCount++;
                }

                if (bodycreatedBy != null)
                {
                    body["createdBy"] = SourceExpressionConverter.ConvertToken(bodycreatedBy);
                    bodypropCount++;
                }

                if (bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = SourceExpressionConverter.ConvertToken(bodylastModifiedBy);
                    bodypropCount++;
                }

                if (bodyfax != null)
                {
                    body["fax"] = SourceExpressionConverter.ConvertToken(bodyfax);
                    bodypropCount++;
                }

                if (bodyownershipId != null)
                {
                    body["ownershipId"] = SourceExpressionConverter.ConvertToken(bodyownershipId);
                    bodypropCount++;
                }

                if (bodyratingId != null)
                {
                    body["ratingId"] = SourceExpressionConverter.ConvertToken(bodyratingId);
                    bodypropCount++;
                }

                if (bodyclassificationId != null)
                {
                    body["classificationId"] = SourceExpressionConverter.ConvertToken(bodyclassificationId);
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
                    body["assignedTeams"] = SourceExpressionConverter.ConvertToken(bodyassignedTeams);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CustomerApiFeaturesAccountsAccountDTO>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<CustomerApiFeaturesAccountsAccountDTO[]> AccountGetAll([WorkflowExpression] Func<string> parentAccount = null, [WorkflowExpression] Func<string> phone = null, [WorkflowExpression] Func<string> suggestions = null, [WorkflowExpression] Func<string> ownerId = null, [WorkflowExpression] Func<string> ownershipId = null, [WorkflowExpression] Func<string> ratingId = null, [WorkflowExpression] Func<string> classificationId = null, [WorkflowExpression] Func<string> industryId = null, [WorkflowExpression] Func<string> accountSourceTypeId = null, [WorkflowExpression] Func<string> primaryContactId = null, [WorkflowExpression] Func<string> assignedTeams = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(parentAccount, nameof(parentAccount), required: false);
            SourceExpression.Validate(phone, nameof(phone), required: false);
            SourceExpression.Validate(suggestions, nameof(suggestions), required: false);
            SourceExpression.Validate(ownerId, nameof(ownerId), required: false);
            SourceExpression.Validate(ownershipId, nameof(ownershipId), required: false);
            SourceExpression.Validate(ratingId, nameof(ratingId), required: false);
            SourceExpression.Validate(classificationId, nameof(classificationId), required: false);
            SourceExpression.Validate(industryId, nameof(industryId), required: false);
            SourceExpression.Validate(accountSourceTypeId, nameof(accountSourceTypeId), required: false);
            SourceExpression.Validate(primaryContactId, nameof(primaryContactId), required: false);
            SourceExpression.Validate(assignedTeams, nameof(assignedTeams), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Account";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (parentAccount != null)
                    callPayload.Queries["ParentAccount"] = SourceExpressionConverter.ConvertO(parentAccount);
                if (phone != null)
                    callPayload.Queries["Phone"] = SourceExpressionConverter.ConvertO(phone);
                if (suggestions != null)
                    callPayload.Queries["Suggestions"] = SourceExpressionConverter.ConvertO(suggestions);
                if (ownerId != null)
                    callPayload.Queries["OwnerId"] = SourceExpressionConverter.ConvertO(ownerId);
                if (ownershipId != null)
                    callPayload.Queries["OwnershipId"] = SourceExpressionConverter.ConvertO(ownershipId);
                if (ratingId != null)
                    callPayload.Queries["RatingId"] = SourceExpressionConverter.ConvertO(ratingId);
                if (classificationId != null)
                    callPayload.Queries["ClassificationId"] = SourceExpressionConverter.ConvertO(classificationId);
                if (industryId != null)
                    callPayload.Queries["IndustryId"] = SourceExpressionConverter.ConvertO(industryId);
                if (accountSourceTypeId != null)
                    callPayload.Queries["AccountSourceTypeId"] = SourceExpressionConverter.ConvertO(accountSourceTypeId);
                if (primaryContactId != null)
                    callPayload.Queries["PrimaryContactId"] = SourceExpressionConverter.ConvertO(primaryContactId);
                if (assignedTeams != null)
                    callPayload.Queries["AssignedTeams"] = SourceExpressionConverter.ConvertO(assignedTeams);
                if (search != null)
                    callPayload.Queries["Search"] = SourceExpressionConverter.ConvertO(search);
                if (name != null)
                    callPayload.Queries["Name"] = SourceExpressionConverter.ConvertO(name);
                if (id != null)
                    callPayload.Queries["Id"] = SourceExpressionConverter.ConvertO(id);
                if (page != null)
                    callPayload.Queries["Page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<CustomerApiFeaturesAccountsAccountDTO[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<CustomerApiFeaturesAccountsAccountDTO> AccountCreate([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodycompanyId = null, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<string> bodytin = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodysourceId = null, [WorkflowExpression] Func<string> bodysourceParentId = null, [WorkflowExpression] Func<string> bodysourceOwnerId = null, [WorkflowExpression] Func<string[]> bodyprimaryContactIds = null, [WorkflowExpression] Func<string> bodyparentAccountId = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodyaddressaddress1 = null, [WorkflowExpression] Func<string> bodyaddressaddress2 = null, [WorkflowExpression] Func<string> bodyaddresscity = null, [WorkflowExpression] Func<string> bodyaddressstate = null, [WorkflowExpression] Func<string> bodyaddresslatitude = null, [WorkflowExpression] Func<string> bodyaddresslongtitude = null, [WorkflowExpression] Func<string> bodyaddresscountry = null, [WorkflowExpression] Func<string> bodyaddresscountryCode = null, [WorkflowExpression] Func<string> bodyaddresspostalCode = null, [WorkflowExpression] Func<string> bodyaddressfirstName = null, [WorkflowExpression] Func<string> bodyaddresslastName = null, [WorkflowExpression] Func<string> bodyaddressphoneNumber = null, [WorkflowExpression] Func<string> bodyaddressemail = null, [WorkflowExpression] Func<string> bodyupdateDate = null, [WorkflowExpression] Func<string> bodyinsertDate = null, [WorkflowExpression] Func<string> bodytaxOffice = null, [WorkflowExpression] Func<string> bodyaccountSourceTypeId = null, [WorkflowExpression] Func<string> bodyindustryId = null, [WorkflowExpression] Func<string> bodytierId = null, [WorkflowExpression] Func<string> bodywebsite = null, [WorkflowExpression] Func<string> bodyaccountDescription = null, [WorkflowExpression] Func<int> bodynoOfEmployees = null, [WorkflowExpression] Func<double> bodyannualRevenue = null, [WorkflowExpression] Func<string> bodycreatedBy = null, [WorkflowExpression] Func<string> bodylastModifiedBy = null, [WorkflowExpression] Func<string> bodyfax = null, [WorkflowExpression] Func<string> bodyownershipId = null, [WorkflowExpression] Func<string> bodyratingId = null, [WorkflowExpression] Func<string> bodyclassificationId = null, [WorkflowExpression] Func<string[]> bodyassignedTeams = null, [WorkflowExpression] Func<double> bodyaiScore = null, [WorkflowExpression] Func<string> bodyaiScoreReasoning = null, [WorkflowExpression] Func<bodyaiSentimentInput> bodyaiSentiment = null, [WorkflowExpression] Func<string> bodyaiGenerationDate = null)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodycompanyId, nameof(bodycompanyId), required: false);
            SourceExpression.Validate(bodycode, nameof(bodycode), required: false);
            SourceExpression.Validate(bodytin, nameof(bodytin), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            SourceExpression.Validate(bodysourceId, nameof(bodysourceId), required: false);
            SourceExpression.Validate(bodysourceParentId, nameof(bodysourceParentId), required: false);
            SourceExpression.Validate(bodysourceOwnerId, nameof(bodysourceOwnerId), required: false);
            SourceExpression.Validate(bodyprimaryContactIds, nameof(bodyprimaryContactIds), required: false);
            SourceExpression.Validate(bodyparentAccountId, nameof(bodyparentAccountId), required: false);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            SourceExpression.Validate(bodyaddressaddress1, nameof(bodyaddressaddress1), required: false);
            SourceExpression.Validate(bodyaddressaddress2, nameof(bodyaddressaddress2), required: false);
            SourceExpression.Validate(bodyaddresscity, nameof(bodyaddresscity), required: false);
            SourceExpression.Validate(bodyaddressstate, nameof(bodyaddressstate), required: false);
            SourceExpression.Validate(bodyaddresslatitude, nameof(bodyaddresslatitude), required: false);
            SourceExpression.Validate(bodyaddresslongtitude, nameof(bodyaddresslongtitude), required: false);
            SourceExpression.Validate(bodyaddresscountry, nameof(bodyaddresscountry), required: false);
            SourceExpression.Validate(bodyaddresscountryCode, nameof(bodyaddresscountryCode), required: false);
            SourceExpression.Validate(bodyaddresspostalCode, nameof(bodyaddresspostalCode), required: false);
            SourceExpression.Validate(bodyaddressfirstName, nameof(bodyaddressfirstName), required: false);
            SourceExpression.Validate(bodyaddresslastName, nameof(bodyaddresslastName), required: false);
            SourceExpression.Validate(bodyaddressphoneNumber, nameof(bodyaddressphoneNumber), required: false);
            SourceExpression.Validate(bodyaddressemail, nameof(bodyaddressemail), required: false);
            SourceExpression.Validate(bodyupdateDate, nameof(bodyupdateDate), required: false);
            SourceExpression.Validate(bodyinsertDate, nameof(bodyinsertDate), required: false);
            SourceExpression.Validate(bodytaxOffice, nameof(bodytaxOffice), required: false);
            SourceExpression.Validate(bodyaccountSourceTypeId, nameof(bodyaccountSourceTypeId), required: false);
            SourceExpression.Validate(bodyindustryId, nameof(bodyindustryId), required: false);
            SourceExpression.Validate(bodytierId, nameof(bodytierId), required: false);
            SourceExpression.Validate(bodywebsite, nameof(bodywebsite), required: false);
            SourceExpression.Validate(bodyaccountDescription, nameof(bodyaccountDescription), required: false);
            SourceExpression.Validate(bodynoOfEmployees, nameof(bodynoOfEmployees), required: false);
            SourceExpression.Validate(bodyannualRevenue, nameof(bodyannualRevenue), required: false);
            SourceExpression.Validate(bodycreatedBy, nameof(bodycreatedBy), required: false);
            SourceExpression.Validate(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            SourceExpression.Validate(bodyfax, nameof(bodyfax), required: false);
            SourceExpression.Validate(bodyownershipId, nameof(bodyownershipId), required: false);
            SourceExpression.Validate(bodyratingId, nameof(bodyratingId), required: false);
            SourceExpression.Validate(bodyclassificationId, nameof(bodyclassificationId), required: false);
            SourceExpression.Validate(bodyassignedTeams, nameof(bodyassignedTeams), required: false);
            SourceExpression.Validate(bodyaiScore, nameof(bodyaiScore), required: false);
            SourceExpression.Validate(bodyaiScoreReasoning, nameof(bodyaiScoreReasoning), required: false);
            SourceExpression.Validate(bodyaiSentiment, nameof(bodyaiSentiment), required: false);
            SourceExpression.Validate(bodyaiGenerationDate, nameof(bodyaiGenerationDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Account";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodycompanyId != null)
                {
                    body["companyId"] = SourceExpressionConverter.ConvertToken(bodycompanyId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodycode != null)
                {
                    body["code"] = SourceExpressionConverter.ConvertToken(bodycode);
                    bodypropCount++;
                }

                if (bodytin != null)
                {
                    body["tin"] = SourceExpressionConverter.ConvertToken(bodytin);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                    bodypropCount++;
                }

                if (bodysourceId != null)
                {
                    body["sourceId"] = SourceExpressionConverter.ConvertToken(bodysourceId);
                    bodypropCount++;
                }

                if (bodysourceParentId != null)
                {
                    body["sourceParentId"] = SourceExpressionConverter.ConvertToken(bodysourceParentId);
                    bodypropCount++;
                }

                if (bodysourceOwnerId != null)
                {
                    body["sourceOwnerId"] = SourceExpressionConverter.ConvertToken(bodysourceOwnerId);
                    bodypropCount++;
                }

                if (bodyprimaryContactIds != null)
                {
                    body["primaryContactIds"] = SourceExpressionConverter.ConvertToken(bodyprimaryContactIds);
                    bodypropCount++;
                }

                if (bodyparentAccountId != null)
                {
                    body["parentAccountId"] = SourceExpressionConverter.ConvertToken(bodyparentAccountId);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["ownerId"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                    bodypropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (bodyaddressaddress1 != null)
                {
                    addressObject["address1"] = SourceExpressionConverter.ConvertToken(bodyaddressaddress1);
                    addressObjectpropCount++;
                }

                if (bodyaddressaddress2 != null)
                {
                    addressObject["address2"] = SourceExpressionConverter.ConvertToken(bodyaddressaddress2);
                    addressObjectpropCount++;
                }

                if (bodyaddresscity != null)
                {
                    addressObject["city"] = SourceExpressionConverter.ConvertToken(bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (bodyaddressstate != null)
                {
                    addressObject["state"] = SourceExpressionConverter.ConvertToken(bodyaddressstate);
                    addressObjectpropCount++;
                }

                if (bodyaddresslatitude != null)
                {
                    addressObject["latitude"] = SourceExpressionConverter.ConvertToken(bodyaddresslatitude);
                    addressObjectpropCount++;
                }

                if (bodyaddresslongtitude != null)
                {
                    addressObject["longtitude"] = SourceExpressionConverter.ConvertToken(bodyaddresslongtitude);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountry != null)
                {
                    addressObject["country"] = SourceExpressionConverter.ConvertToken(bodyaddresscountry);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountryCode != null)
                {
                    addressObject["countryCode"] = SourceExpressionConverter.ConvertToken(bodyaddresscountryCode);
                    addressObjectpropCount++;
                }

                if (bodyaddresspostalCode != null)
                {
                    addressObject["postalCode"] = SourceExpressionConverter.ConvertToken(bodyaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (bodyaddressfirstName != null)
                {
                    addressObject["firstName"] = SourceExpressionConverter.ConvertToken(bodyaddressfirstName);
                    addressObjectpropCount++;
                }

                if (bodyaddresslastName != null)
                {
                    addressObject["lastName"] = SourceExpressionConverter.ConvertToken(bodyaddresslastName);
                    addressObjectpropCount++;
                }

                if (bodyaddressphoneNumber != null)
                {
                    addressObject["phoneNumber"] = SourceExpressionConverter.ConvertToken(bodyaddressphoneNumber);
                    addressObjectpropCount++;
                }

                if (bodyaddressemail != null)
                {
                    addressObject["email"] = SourceExpressionConverter.ConvertToken(bodyaddressemail);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                if (bodyupdateDate != null)
                {
                    body["updateDate"] = SourceExpressionConverter.ConvertToken(bodyupdateDate);
                    bodypropCount++;
                }

                if (bodyinsertDate != null)
                {
                    body["insertDate"] = SourceExpressionConverter.ConvertToken(bodyinsertDate);
                    bodypropCount++;
                }

                if (bodytaxOffice != null)
                {
                    body["taxOffice"] = SourceExpressionConverter.ConvertToken(bodytaxOffice);
                    bodypropCount++;
                }

                if (bodyaccountSourceTypeId != null)
                {
                    body["accountSourceTypeId"] = SourceExpressionConverter.ConvertToken(bodyaccountSourceTypeId);
                    bodypropCount++;
                }

                if (bodyindustryId != null)
                {
                    body["industryId"] = SourceExpressionConverter.ConvertToken(bodyindustryId);
                    bodypropCount++;
                }

                if (bodytierId != null)
                {
                    body["tierId"] = SourceExpressionConverter.ConvertToken(bodytierId);
                    bodypropCount++;
                }

                if (bodywebsite != null)
                {
                    body["website"] = SourceExpressionConverter.ConvertToken(bodywebsite);
                    bodypropCount++;
                }

                if (bodyaccountDescription != null)
                {
                    body["accountDescription"] = SourceExpressionConverter.ConvertToken(bodyaccountDescription);
                    bodypropCount++;
                }

                if (bodynoOfEmployees != null)
                {
                    body["noOfEmployees"] = SourceExpressionConverter.ConvertToken(bodynoOfEmployees);
                    bodypropCount++;
                }

                if (bodyannualRevenue != null)
                {
                    body["annualRevenue"] = SourceExpressionConverter.ConvertToken(bodyannualRevenue);
                    bodypropCount++;
                }

                if (bodycreatedBy != null)
                {
                    body["createdBy"] = SourceExpressionConverter.ConvertToken(bodycreatedBy);
                    bodypropCount++;
                }

                if (bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = SourceExpressionConverter.ConvertToken(bodylastModifiedBy);
                    bodypropCount++;
                }

                if (bodyfax != null)
                {
                    body["fax"] = SourceExpressionConverter.ConvertToken(bodyfax);
                    bodypropCount++;
                }

                if (bodyownershipId != null)
                {
                    body["ownershipId"] = SourceExpressionConverter.ConvertToken(bodyownershipId);
                    bodypropCount++;
                }

                if (bodyratingId != null)
                {
                    body["ratingId"] = SourceExpressionConverter.ConvertToken(bodyratingId);
                    bodypropCount++;
                }

                if (bodyclassificationId != null)
                {
                    body["classificationId"] = SourceExpressionConverter.ConvertToken(bodyclassificationId);
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
                    body["assignedTeams"] = SourceExpressionConverter.ConvertToken(bodyassignedTeams);
                    bodypropCount++;
                }

                if (bodyaiScore != null)
                {
                    body["aiScore"] = SourceExpressionConverter.ConvertToken(bodyaiScore);
                    bodypropCount++;
                }

                if (bodyaiScoreReasoning != null)
                {
                    body["aiScoreReasoning"] = SourceExpressionConverter.ConvertToken(bodyaiScoreReasoning);
                    bodypropCount++;
                }

                if (bodyaiSentiment != null)
                {
                    body["aiSentiment"] = SourceExpressionConverter.Convert(bodyaiSentiment);
                    bodypropCount++;
                }

                if (bodyaiGenerationDate != null)
                {
                    body["aiGenerationDate"] = SourceExpressionConverter.ConvertToken(bodyaiGenerationDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CustomerApiFeaturesAccountsAccountDTO>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<CustomerApiFeaturesContactsContact> ContactGetById([WorkflowExpression] Func<string> contactId)
        {
            SourceExpression.Validate(contactId, nameof(contactId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/Contact/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CustomerApiFeaturesContactsContact>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction ContactDelete([WorkflowExpression] Func<string> contactId)
        {
            SourceExpression.Validate(contactId, nameof(contactId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/Contact/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<CustomerApiFeaturesContactsContactDTO> ContactUpdate([WorkflowExpression] Func<string> contactId, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string[]> bodyaccountIds = null, [WorkflowExpression] Func<string> bodysourceId = null, [WorkflowExpression] Func<string> bodysourceOwnerId = null, [WorkflowExpression] Func<string[]> bodysourceAccountIds = null, [WorkflowExpression] Func<string> bodynamefirstName = null, [WorkflowExpression] Func<string> bodynamelastName = null, [WorkflowExpression] Func<string> bodynamemiddleName = null, [WorkflowExpression] Func<string> bodynamesalutationId = null, [WorkflowExpression] Func<string> bodynamesuffix = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodymobilePhone = null, [WorkflowExpression] Func<string> bodyfax = null, [WorkflowExpression] Func<bool> bodycallOptOut = null, [WorkflowExpression] Func<bool> bodyemailOptOut = null, [WorkflowExpression] Func<CustomerApiFeaturesContactsEmailDTO[]> bodyotherEmail = null, [WorkflowExpression] Func<CustomerApiFeaturesContactsPhoneDTO[]> bodyotherPhone = null, [WorkflowExpression] Func<string> bodyjobTitle = null, [WorkflowExpression] Func<string> bodygenderId = null, [WorkflowExpression] Func<string> bodypronounceId = null, [WorkflowExpression] Func<string> bodyaddressaddress1 = null, [WorkflowExpression] Func<string> bodyaddressaddress2 = null, [WorkflowExpression] Func<string> bodyaddresscity = null, [WorkflowExpression] Func<string> bodyaddressstate = null, [WorkflowExpression] Func<string> bodyaddresslatitude = null, [WorkflowExpression] Func<string> bodyaddresslongtitude = null, [WorkflowExpression] Func<string> bodyaddresscountry = null, [WorkflowExpression] Func<string> bodyaddresscountryCode = null, [WorkflowExpression] Func<string> bodyaddresspostalCode = null, [WorkflowExpression] Func<string> bodyaddressfirstName = null, [WorkflowExpression] Func<string> bodyaddresslastName = null, [WorkflowExpression] Func<string> bodyaddressphoneNumber = null, [WorkflowExpression] Func<string> bodyaddressemail = null, [WorkflowExpression] Func<string> bodycreatedBy = null, [WorkflowExpression] Func<string> bodylastModifiedBy = null, [WorkflowExpression] Func<string> bodydepartment = null, [WorkflowExpression] Func<string> bodyreportsTo = null, [WorkflowExpression] Func<string> bodyassistant = null, [WorkflowExpression] Func<string> bodyassistantPhone = null, [WorkflowExpression] Func<string> bodybirthday = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodylastStayInTouchReportedDate = null, [WorkflowExpression] Func<string> bodylastStayInTouchSaveDate = null, [WorkflowExpression] Func<string> bodyaccountSourceTypeId = null, [WorkflowExpression] Func<string[]> bodyassignedTeams = null)
        {
            SourceExpression.Validate(contactId, nameof(contactId), required: true);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            SourceExpression.Validate(bodyaccountIds, nameof(bodyaccountIds), required: false);
            SourceExpression.Validate(bodysourceId, nameof(bodysourceId), required: false);
            SourceExpression.Validate(bodysourceOwnerId, nameof(bodysourceOwnerId), required: false);
            SourceExpression.Validate(bodysourceAccountIds, nameof(bodysourceAccountIds), required: false);
            SourceExpression.Validate(bodynamefirstName, nameof(bodynamefirstName), required: false);
            SourceExpression.Validate(bodynamelastName, nameof(bodynamelastName), required: false);
            SourceExpression.Validate(bodynamemiddleName, nameof(bodynamemiddleName), required: false);
            SourceExpression.Validate(bodynamesalutationId, nameof(bodynamesalutationId), required: false);
            SourceExpression.Validate(bodynamesuffix, nameof(bodynamesuffix), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            SourceExpression.Validate(bodymobilePhone, nameof(bodymobilePhone), required: false);
            SourceExpression.Validate(bodyfax, nameof(bodyfax), required: false);
            SourceExpression.Validate(bodycallOptOut, nameof(bodycallOptOut), required: false);
            SourceExpression.Validate(bodyemailOptOut, nameof(bodyemailOptOut), required: false);
            SourceExpression.Validate(bodyotherEmail, nameof(bodyotherEmail), required: false);
            SourceExpression.Validate(bodyotherPhone, nameof(bodyotherPhone), required: false);
            SourceExpression.Validate(bodyjobTitle, nameof(bodyjobTitle), required: false);
            SourceExpression.Validate(bodygenderId, nameof(bodygenderId), required: false);
            SourceExpression.Validate(bodypronounceId, nameof(bodypronounceId), required: false);
            SourceExpression.Validate(bodyaddressaddress1, nameof(bodyaddressaddress1), required: false);
            SourceExpression.Validate(bodyaddressaddress2, nameof(bodyaddressaddress2), required: false);
            SourceExpression.Validate(bodyaddresscity, nameof(bodyaddresscity), required: false);
            SourceExpression.Validate(bodyaddressstate, nameof(bodyaddressstate), required: false);
            SourceExpression.Validate(bodyaddresslatitude, nameof(bodyaddresslatitude), required: false);
            SourceExpression.Validate(bodyaddresslongtitude, nameof(bodyaddresslongtitude), required: false);
            SourceExpression.Validate(bodyaddresscountry, nameof(bodyaddresscountry), required: false);
            SourceExpression.Validate(bodyaddresscountryCode, nameof(bodyaddresscountryCode), required: false);
            SourceExpression.Validate(bodyaddresspostalCode, nameof(bodyaddresspostalCode), required: false);
            SourceExpression.Validate(bodyaddressfirstName, nameof(bodyaddressfirstName), required: false);
            SourceExpression.Validate(bodyaddresslastName, nameof(bodyaddresslastName), required: false);
            SourceExpression.Validate(bodyaddressphoneNumber, nameof(bodyaddressphoneNumber), required: false);
            SourceExpression.Validate(bodyaddressemail, nameof(bodyaddressemail), required: false);
            SourceExpression.Validate(bodycreatedBy, nameof(bodycreatedBy), required: false);
            SourceExpression.Validate(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            SourceExpression.Validate(bodydepartment, nameof(bodydepartment), required: false);
            SourceExpression.Validate(bodyreportsTo, nameof(bodyreportsTo), required: false);
            SourceExpression.Validate(bodyassistant, nameof(bodyassistant), required: false);
            SourceExpression.Validate(bodyassistantPhone, nameof(bodyassistantPhone), required: false);
            SourceExpression.Validate(bodybirthday, nameof(bodybirthday), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodylastStayInTouchReportedDate, nameof(bodylastStayInTouchReportedDate), required: false);
            SourceExpression.Validate(bodylastStayInTouchSaveDate, nameof(bodylastStayInTouchSaveDate), required: false);
            SourceExpression.Validate(bodyaccountSourceTypeId, nameof(bodyaccountSourceTypeId), required: false);
            SourceExpression.Validate(bodyassignedTeams, nameof(bodyassignedTeams), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/Contact/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyownerId != null)
                {
                    body["ownerId"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                    bodypropCount++;
                }

                if (bodyaccountIds != null)
                {
                    body["accountIds"] = SourceExpressionConverter.ConvertToken(bodyaccountIds);
                    bodypropCount++;
                }

                if (bodysourceId != null)
                {
                    body["sourceId"] = SourceExpressionConverter.ConvertToken(bodysourceId);
                    bodypropCount++;
                }

                if (bodysourceOwnerId != null)
                {
                    body["sourceOwnerId"] = SourceExpressionConverter.ConvertToken(bodysourceOwnerId);
                    bodypropCount++;
                }

                if (bodysourceAccountIds != null)
                {
                    body["sourceAccountIds"] = SourceExpressionConverter.ConvertToken(bodysourceAccountIds);
                    bodypropCount++;
                }

                var nameObject = new JObject();
                var nameObjectpropCount = 0;
                if (bodynamefirstName != null)
                {
                    nameObject["firstName"] = SourceExpressionConverter.ConvertToken(bodynamefirstName);
                    nameObjectpropCount++;
                }

                if (bodynamelastName != null)
                {
                    nameObject["lastName"] = SourceExpressionConverter.ConvertToken(bodynamelastName);
                    nameObjectpropCount++;
                }

                if (bodynamemiddleName != null)
                {
                    nameObject["middleName"] = SourceExpressionConverter.ConvertToken(bodynamemiddleName);
                    nameObjectpropCount++;
                }

                if (bodynamesalutationId != null)
                {
                    nameObject["salutationId"] = SourceExpressionConverter.ConvertToken(bodynamesalutationId);
                    nameObjectpropCount++;
                }

                if (bodynamesuffix != null)
                {
                    nameObject["suffix"] = SourceExpressionConverter.ConvertToken(bodynamesuffix);
                    nameObjectpropCount++;
                }

                if (nameObjectpropCount > 0)
                {
                    body["name"] = nameObject;
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                    bodypropCount++;
                }

                if (bodymobilePhone != null)
                {
                    body["mobilePhone"] = SourceExpressionConverter.ConvertToken(bodymobilePhone);
                    bodypropCount++;
                }

                if (bodyfax != null)
                {
                    body["fax"] = SourceExpressionConverter.ConvertToken(bodyfax);
                    bodypropCount++;
                }

                if (bodycallOptOut != null)
                {
                    body["callOptOut"] = SourceExpressionConverter.ConvertToken(bodycallOptOut);
                    bodypropCount++;
                }

                if (bodyemailOptOut != null)
                {
                    body["emailOptOut"] = SourceExpressionConverter.ConvertToken(bodyemailOptOut);
                    bodypropCount++;
                }

                if (bodyotherEmail != null)
                {
                    body["otherEmail"] = SourceExpressionConverter.ConvertToken(bodyotherEmail);
                    bodypropCount++;
                }

                if (bodyotherPhone != null)
                {
                    body["otherPhone"] = SourceExpressionConverter.ConvertToken(bodyotherPhone);
                    bodypropCount++;
                }

                if (bodyjobTitle != null)
                {
                    body["jobTitle"] = SourceExpressionConverter.ConvertToken(bodyjobTitle);
                    bodypropCount++;
                }

                if (bodygenderId != null)
                {
                    body["genderId"] = SourceExpressionConverter.ConvertToken(bodygenderId);
                    bodypropCount++;
                }

                if (bodypronounceId != null)
                {
                    body["pronounceId"] = SourceExpressionConverter.ConvertToken(bodypronounceId);
                    bodypropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (bodyaddressaddress1 != null)
                {
                    addressObject["address1"] = SourceExpressionConverter.ConvertToken(bodyaddressaddress1);
                    addressObjectpropCount++;
                }

                if (bodyaddressaddress2 != null)
                {
                    addressObject["address2"] = SourceExpressionConverter.ConvertToken(bodyaddressaddress2);
                    addressObjectpropCount++;
                }

                if (bodyaddresscity != null)
                {
                    addressObject["city"] = SourceExpressionConverter.ConvertToken(bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (bodyaddressstate != null)
                {
                    addressObject["state"] = SourceExpressionConverter.ConvertToken(bodyaddressstate);
                    addressObjectpropCount++;
                }

                if (bodyaddresslatitude != null)
                {
                    addressObject["latitude"] = SourceExpressionConverter.ConvertToken(bodyaddresslatitude);
                    addressObjectpropCount++;
                }

                if (bodyaddresslongtitude != null)
                {
                    addressObject["longtitude"] = SourceExpressionConverter.ConvertToken(bodyaddresslongtitude);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountry != null)
                {
                    addressObject["country"] = SourceExpressionConverter.ConvertToken(bodyaddresscountry);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountryCode != null)
                {
                    addressObject["countryCode"] = SourceExpressionConverter.ConvertToken(bodyaddresscountryCode);
                    addressObjectpropCount++;
                }

                if (bodyaddresspostalCode != null)
                {
                    addressObject["postalCode"] = SourceExpressionConverter.ConvertToken(bodyaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (bodyaddressfirstName != null)
                {
                    addressObject["firstName"] = SourceExpressionConverter.ConvertToken(bodyaddressfirstName);
                    addressObjectpropCount++;
                }

                if (bodyaddresslastName != null)
                {
                    addressObject["lastName"] = SourceExpressionConverter.ConvertToken(bodyaddresslastName);
                    addressObjectpropCount++;
                }

                if (bodyaddressphoneNumber != null)
                {
                    addressObject["phoneNumber"] = SourceExpressionConverter.ConvertToken(bodyaddressphoneNumber);
                    addressObjectpropCount++;
                }

                if (bodyaddressemail != null)
                {
                    addressObject["email"] = SourceExpressionConverter.ConvertToken(bodyaddressemail);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                if (bodycreatedBy != null)
                {
                    body["createdBy"] = SourceExpressionConverter.ConvertToken(bodycreatedBy);
                    bodypropCount++;
                }

                if (bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = SourceExpressionConverter.ConvertToken(bodylastModifiedBy);
                    bodypropCount++;
                }

                if (bodydepartment != null)
                {
                    body["department"] = SourceExpressionConverter.ConvertToken(bodydepartment);
                    bodypropCount++;
                }

                if (bodyreportsTo != null)
                {
                    body["reportsTo"] = SourceExpressionConverter.ConvertToken(bodyreportsTo);
                    bodypropCount++;
                }

                if (bodyassistant != null)
                {
                    body["assistant"] = SourceExpressionConverter.ConvertToken(bodyassistant);
                    bodypropCount++;
                }

                if (bodyassistantPhone != null)
                {
                    body["assistantPhone"] = SourceExpressionConverter.ConvertToken(bodyassistantPhone);
                    bodypropCount++;
                }

                if (bodybirthday != null)
                {
                    body["birthday"] = SourceExpressionConverter.ConvertToken(bodybirthday);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodylastStayInTouchReportedDate != null)
                {
                    body["lastStayInTouchReportedDate"] = SourceExpressionConverter.ConvertToken(bodylastStayInTouchReportedDate);
                    bodypropCount++;
                }

                if (bodylastStayInTouchSaveDate != null)
                {
                    body["lastStayInTouchSaveDate"] = SourceExpressionConverter.ConvertToken(bodylastStayInTouchSaveDate);
                    bodypropCount++;
                }

                if (bodyaccountSourceTypeId != null)
                {
                    body["accountSourceTypeId"] = SourceExpressionConverter.ConvertToken(bodyaccountSourceTypeId);
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
                    body["assignedTeams"] = SourceExpressionConverter.ConvertToken(bodyassignedTeams);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CustomerApiFeaturesContactsContactDTO>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<CustomerApiFeaturesContactsContactDTO[]> ContactGetAll([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> ownerId = null, [WorkflowExpression] Func<string> suggestions = null, [WorkflowExpression] Func<string> accountSourceTypeId = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> lastName = null, [WorkflowExpression] Func<string> phone = null, [WorkflowExpression] Func<string> mobilePhone = null, [WorkflowExpression] Func<string> accountIds = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> assignedTeams = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(ownerId, nameof(ownerId), required: false);
            SourceExpression.Validate(suggestions, nameof(suggestions), required: false);
            SourceExpression.Validate(accountSourceTypeId, nameof(accountSourceTypeId), required: false);
            SourceExpression.Validate(firstName, nameof(firstName), required: false);
            SourceExpression.Validate(lastName, nameof(lastName), required: false);
            SourceExpression.Validate(phone, nameof(phone), required: false);
            SourceExpression.Validate(mobilePhone, nameof(mobilePhone), required: false);
            SourceExpression.Validate(accountIds, nameof(accountIds), required: false);
            SourceExpression.Validate(email, nameof(email), required: false);
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(assignedTeams, nameof(assignedTeams), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Contact";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["Name"] = SourceExpressionConverter.ConvertO(name);
                if (ownerId != null)
                    callPayload.Queries["OwnerId"] = SourceExpressionConverter.ConvertO(ownerId);
                if (suggestions != null)
                    callPayload.Queries["Suggestions"] = SourceExpressionConverter.ConvertO(suggestions);
                if (accountSourceTypeId != null)
                    callPayload.Queries["AccountSourceTypeId"] = SourceExpressionConverter.ConvertO(accountSourceTypeId);
                if (firstName != null)
                    callPayload.Queries["FirstName"] = SourceExpressionConverter.ConvertO(firstName);
                if (lastName != null)
                    callPayload.Queries["LastName"] = SourceExpressionConverter.ConvertO(lastName);
                if (phone != null)
                    callPayload.Queries["Phone"] = SourceExpressionConverter.ConvertO(phone);
                if (mobilePhone != null)
                    callPayload.Queries["MobilePhone"] = SourceExpressionConverter.ConvertO(mobilePhone);
                if (accountIds != null)
                    callPayload.Queries["AccountIds"] = SourceExpressionConverter.ConvertO(accountIds);
                if (email != null)
                    callPayload.Queries["Email"] = SourceExpressionConverter.ConvertO(email);
                if (id != null)
                    callPayload.Queries["Id"] = SourceExpressionConverter.ConvertO(id);
                if (assignedTeams != null)
                    callPayload.Queries["AssignedTeams"] = SourceExpressionConverter.ConvertO(assignedTeams);
                if (search != null)
                    callPayload.Queries["Search"] = SourceExpressionConverter.ConvertO(search);
                if (page != null)
                    callPayload.Queries["Page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<CustomerApiFeaturesContactsContactDTO[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<CustomerApiFeaturesContactsContactDTO> ContactCreate([WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodycompanyId = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string[]> bodyaccountIds = null, [WorkflowExpression] Func<string> bodysourceId = null, [WorkflowExpression] Func<string> bodysourceOwnerId = null, [WorkflowExpression] Func<string[]> bodysourceAccountIds = null, [WorkflowExpression] Func<string> bodynamefirstName = null, [WorkflowExpression] Func<string> bodynamelastName = null, [WorkflowExpression] Func<string> bodynamemiddleName = null, [WorkflowExpression] Func<string> bodynamesalutationId = null, [WorkflowExpression] Func<string> bodynamesuffix = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodymobilePhone = null, [WorkflowExpression] Func<string> bodyfax = null, [WorkflowExpression] Func<bool> bodycallOptOut = null, [WorkflowExpression] Func<bool> bodyemailOptOut = null, [WorkflowExpression] Func<CustomerApiFeaturesContactsEmailDTO[]> bodyotherEmail = null, [WorkflowExpression] Func<CustomerApiFeaturesContactsPhoneDTO[]> bodyotherPhone = null, [WorkflowExpression] Func<string> bodyjobTitle = null, [WorkflowExpression] Func<string> bodygenderId = null, [WorkflowExpression] Func<string> bodypronounceId = null, [WorkflowExpression] Func<string> bodyaddressaddress1 = null, [WorkflowExpression] Func<string> bodyaddressaddress2 = null, [WorkflowExpression] Func<string> bodyaddresscity = null, [WorkflowExpression] Func<string> bodyaddressstate = null, [WorkflowExpression] Func<string> bodyaddresslatitude = null, [WorkflowExpression] Func<string> bodyaddresslongtitude = null, [WorkflowExpression] Func<string> bodyaddresscountry = null, [WorkflowExpression] Func<string> bodyaddresscountryCode = null, [WorkflowExpression] Func<string> bodyaddresspostalCode = null, [WorkflowExpression] Func<string> bodyaddressfirstName = null, [WorkflowExpression] Func<string> bodyaddresslastName = null, [WorkflowExpression] Func<string> bodyaddressphoneNumber = null, [WorkflowExpression] Func<string> bodyaddressemail = null, [WorkflowExpression] Func<string> bodyinsertDate = null, [WorkflowExpression] Func<string> bodyupdateDate = null, [WorkflowExpression] Func<string> bodycreatedBy = null, [WorkflowExpression] Func<string> bodylastModifiedBy = null, [WorkflowExpression] Func<string> bodydepartment = null, [WorkflowExpression] Func<string> bodyreportsTo = null, [WorkflowExpression] Func<string> bodyassistant = null, [WorkflowExpression] Func<string> bodyassistantPhone = null, [WorkflowExpression] Func<string> bodybirthday = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodylastStayInTouchReportedDate = null, [WorkflowExpression] Func<string> bodylastStayInTouchSaveDate = null, [WorkflowExpression] Func<string> bodyaccountSourceTypeId = null, [WorkflowExpression] Func<string> bodyfullName = null, [WorkflowExpression] Func<string[]> bodyassignedTeams = null)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodycompanyId, nameof(bodycompanyId), required: false);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            SourceExpression.Validate(bodyaccountIds, nameof(bodyaccountIds), required: false);
            SourceExpression.Validate(bodysourceId, nameof(bodysourceId), required: false);
            SourceExpression.Validate(bodysourceOwnerId, nameof(bodysourceOwnerId), required: false);
            SourceExpression.Validate(bodysourceAccountIds, nameof(bodysourceAccountIds), required: false);
            SourceExpression.Validate(bodynamefirstName, nameof(bodynamefirstName), required: false);
            SourceExpression.Validate(bodynamelastName, nameof(bodynamelastName), required: false);
            SourceExpression.Validate(bodynamemiddleName, nameof(bodynamemiddleName), required: false);
            SourceExpression.Validate(bodynamesalutationId, nameof(bodynamesalutationId), required: false);
            SourceExpression.Validate(bodynamesuffix, nameof(bodynamesuffix), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            SourceExpression.Validate(bodymobilePhone, nameof(bodymobilePhone), required: false);
            SourceExpression.Validate(bodyfax, nameof(bodyfax), required: false);
            SourceExpression.Validate(bodycallOptOut, nameof(bodycallOptOut), required: false);
            SourceExpression.Validate(bodyemailOptOut, nameof(bodyemailOptOut), required: false);
            SourceExpression.Validate(bodyotherEmail, nameof(bodyotherEmail), required: false);
            SourceExpression.Validate(bodyotherPhone, nameof(bodyotherPhone), required: false);
            SourceExpression.Validate(bodyjobTitle, nameof(bodyjobTitle), required: false);
            SourceExpression.Validate(bodygenderId, nameof(bodygenderId), required: false);
            SourceExpression.Validate(bodypronounceId, nameof(bodypronounceId), required: false);
            SourceExpression.Validate(bodyaddressaddress1, nameof(bodyaddressaddress1), required: false);
            SourceExpression.Validate(bodyaddressaddress2, nameof(bodyaddressaddress2), required: false);
            SourceExpression.Validate(bodyaddresscity, nameof(bodyaddresscity), required: false);
            SourceExpression.Validate(bodyaddressstate, nameof(bodyaddressstate), required: false);
            SourceExpression.Validate(bodyaddresslatitude, nameof(bodyaddresslatitude), required: false);
            SourceExpression.Validate(bodyaddresslongtitude, nameof(bodyaddresslongtitude), required: false);
            SourceExpression.Validate(bodyaddresscountry, nameof(bodyaddresscountry), required: false);
            SourceExpression.Validate(bodyaddresscountryCode, nameof(bodyaddresscountryCode), required: false);
            SourceExpression.Validate(bodyaddresspostalCode, nameof(bodyaddresspostalCode), required: false);
            SourceExpression.Validate(bodyaddressfirstName, nameof(bodyaddressfirstName), required: false);
            SourceExpression.Validate(bodyaddresslastName, nameof(bodyaddresslastName), required: false);
            SourceExpression.Validate(bodyaddressphoneNumber, nameof(bodyaddressphoneNumber), required: false);
            SourceExpression.Validate(bodyaddressemail, nameof(bodyaddressemail), required: false);
            SourceExpression.Validate(bodyinsertDate, nameof(bodyinsertDate), required: false);
            SourceExpression.Validate(bodyupdateDate, nameof(bodyupdateDate), required: false);
            SourceExpression.Validate(bodycreatedBy, nameof(bodycreatedBy), required: false);
            SourceExpression.Validate(bodylastModifiedBy, nameof(bodylastModifiedBy), required: false);
            SourceExpression.Validate(bodydepartment, nameof(bodydepartment), required: false);
            SourceExpression.Validate(bodyreportsTo, nameof(bodyreportsTo), required: false);
            SourceExpression.Validate(bodyassistant, nameof(bodyassistant), required: false);
            SourceExpression.Validate(bodyassistantPhone, nameof(bodyassistantPhone), required: false);
            SourceExpression.Validate(bodybirthday, nameof(bodybirthday), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodylastStayInTouchReportedDate, nameof(bodylastStayInTouchReportedDate), required: false);
            SourceExpression.Validate(bodylastStayInTouchSaveDate, nameof(bodylastStayInTouchSaveDate), required: false);
            SourceExpression.Validate(bodyaccountSourceTypeId, nameof(bodyaccountSourceTypeId), required: false);
            SourceExpression.Validate(bodyfullName, nameof(bodyfullName), required: false);
            SourceExpression.Validate(bodyassignedTeams, nameof(bodyassignedTeams), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodycompanyId != null)
                {
                    body["companyId"] = SourceExpressionConverter.ConvertToken(bodycompanyId);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["ownerId"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                    bodypropCount++;
                }

                if (bodyaccountIds != null)
                {
                    body["accountIds"] = SourceExpressionConverter.ConvertToken(bodyaccountIds);
                    bodypropCount++;
                }

                if (bodysourceId != null)
                {
                    body["sourceId"] = SourceExpressionConverter.ConvertToken(bodysourceId);
                    bodypropCount++;
                }

                if (bodysourceOwnerId != null)
                {
                    body["sourceOwnerId"] = SourceExpressionConverter.ConvertToken(bodysourceOwnerId);
                    bodypropCount++;
                }

                if (bodysourceAccountIds != null)
                {
                    body["sourceAccountIds"] = SourceExpressionConverter.ConvertToken(bodysourceAccountIds);
                    bodypropCount++;
                }

                var nameObject = new JObject();
                var nameObjectpropCount = 0;
                if (bodynamefirstName != null)
                {
                    nameObject["firstName"] = SourceExpressionConverter.ConvertToken(bodynamefirstName);
                    nameObjectpropCount++;
                }

                if (bodynamelastName != null)
                {
                    nameObject["lastName"] = SourceExpressionConverter.ConvertToken(bodynamelastName);
                    nameObjectpropCount++;
                }

                if (bodynamemiddleName != null)
                {
                    nameObject["middleName"] = SourceExpressionConverter.ConvertToken(bodynamemiddleName);
                    nameObjectpropCount++;
                }

                if (bodynamesalutationId != null)
                {
                    nameObject["salutationId"] = SourceExpressionConverter.ConvertToken(bodynamesalutationId);
                    nameObjectpropCount++;
                }

                if (bodynamesuffix != null)
                {
                    nameObject["suffix"] = SourceExpressionConverter.ConvertToken(bodynamesuffix);
                    nameObjectpropCount++;
                }

                if (nameObjectpropCount > 0)
                {
                    body["name"] = nameObject;
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                    bodypropCount++;
                }

                if (bodymobilePhone != null)
                {
                    body["mobilePhone"] = SourceExpressionConverter.ConvertToken(bodymobilePhone);
                    bodypropCount++;
                }

                if (bodyfax != null)
                {
                    body["fax"] = SourceExpressionConverter.ConvertToken(bodyfax);
                    bodypropCount++;
                }

                if (bodycallOptOut != null)
                {
                    body["callOptOut"] = SourceExpressionConverter.ConvertToken(bodycallOptOut);
                    bodypropCount++;
                }

                if (bodyemailOptOut != null)
                {
                    body["emailOptOut"] = SourceExpressionConverter.ConvertToken(bodyemailOptOut);
                    bodypropCount++;
                }

                if (bodyotherEmail != null)
                {
                    body["otherEmail"] = SourceExpressionConverter.ConvertToken(bodyotherEmail);
                    bodypropCount++;
                }

                if (bodyotherPhone != null)
                {
                    body["otherPhone"] = SourceExpressionConverter.ConvertToken(bodyotherPhone);
                    bodypropCount++;
                }

                if (bodyjobTitle != null)
                {
                    body["jobTitle"] = SourceExpressionConverter.ConvertToken(bodyjobTitle);
                    bodypropCount++;
                }

                if (bodygenderId != null)
                {
                    body["genderId"] = SourceExpressionConverter.ConvertToken(bodygenderId);
                    bodypropCount++;
                }

                if (bodypronounceId != null)
                {
                    body["pronounceId"] = SourceExpressionConverter.ConvertToken(bodypronounceId);
                    bodypropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (bodyaddressaddress1 != null)
                {
                    addressObject["address1"] = SourceExpressionConverter.ConvertToken(bodyaddressaddress1);
                    addressObjectpropCount++;
                }

                if (bodyaddressaddress2 != null)
                {
                    addressObject["address2"] = SourceExpressionConverter.ConvertToken(bodyaddressaddress2);
                    addressObjectpropCount++;
                }

                if (bodyaddresscity != null)
                {
                    addressObject["city"] = SourceExpressionConverter.ConvertToken(bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (bodyaddressstate != null)
                {
                    addressObject["state"] = SourceExpressionConverter.ConvertToken(bodyaddressstate);
                    addressObjectpropCount++;
                }

                if (bodyaddresslatitude != null)
                {
                    addressObject["latitude"] = SourceExpressionConverter.ConvertToken(bodyaddresslatitude);
                    addressObjectpropCount++;
                }

                if (bodyaddresslongtitude != null)
                {
                    addressObject["longtitude"] = SourceExpressionConverter.ConvertToken(bodyaddresslongtitude);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountry != null)
                {
                    addressObject["country"] = SourceExpressionConverter.ConvertToken(bodyaddresscountry);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountryCode != null)
                {
                    addressObject["countryCode"] = SourceExpressionConverter.ConvertToken(bodyaddresscountryCode);
                    addressObjectpropCount++;
                }

                if (bodyaddresspostalCode != null)
                {
                    addressObject["postalCode"] = SourceExpressionConverter.ConvertToken(bodyaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (bodyaddressfirstName != null)
                {
                    addressObject["firstName"] = SourceExpressionConverter.ConvertToken(bodyaddressfirstName);
                    addressObjectpropCount++;
                }

                if (bodyaddresslastName != null)
                {
                    addressObject["lastName"] = SourceExpressionConverter.ConvertToken(bodyaddresslastName);
                    addressObjectpropCount++;
                }

                if (bodyaddressphoneNumber != null)
                {
                    addressObject["phoneNumber"] = SourceExpressionConverter.ConvertToken(bodyaddressphoneNumber);
                    addressObjectpropCount++;
                }

                if (bodyaddressemail != null)
                {
                    addressObject["email"] = SourceExpressionConverter.ConvertToken(bodyaddressemail);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                if (bodyinsertDate != null)
                {
                    body["insertDate"] = SourceExpressionConverter.ConvertToken(bodyinsertDate);
                    bodypropCount++;
                }

                if (bodyupdateDate != null)
                {
                    body["updateDate"] = SourceExpressionConverter.ConvertToken(bodyupdateDate);
                    bodypropCount++;
                }

                if (bodycreatedBy != null)
                {
                    body["createdBy"] = SourceExpressionConverter.ConvertToken(bodycreatedBy);
                    bodypropCount++;
                }

                if (bodylastModifiedBy != null)
                {
                    body["lastModifiedBy"] = SourceExpressionConverter.ConvertToken(bodylastModifiedBy);
                    bodypropCount++;
                }

                if (bodydepartment != null)
                {
                    body["department"] = SourceExpressionConverter.ConvertToken(bodydepartment);
                    bodypropCount++;
                }

                if (bodyreportsTo != null)
                {
                    body["reportsTo"] = SourceExpressionConverter.ConvertToken(bodyreportsTo);
                    bodypropCount++;
                }

                if (bodyassistant != null)
                {
                    body["assistant"] = SourceExpressionConverter.ConvertToken(bodyassistant);
                    bodypropCount++;
                }

                if (bodyassistantPhone != null)
                {
                    body["assistantPhone"] = SourceExpressionConverter.ConvertToken(bodyassistantPhone);
                    bodypropCount++;
                }

                if (bodybirthday != null)
                {
                    body["birthday"] = SourceExpressionConverter.ConvertToken(bodybirthday);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodylastStayInTouchReportedDate != null)
                {
                    body["lastStayInTouchReportedDate"] = SourceExpressionConverter.ConvertToken(bodylastStayInTouchReportedDate);
                    bodypropCount++;
                }

                if (bodylastStayInTouchSaveDate != null)
                {
                    body["lastStayInTouchSaveDate"] = SourceExpressionConverter.ConvertToken(bodylastStayInTouchSaveDate);
                    bodypropCount++;
                }

                if (bodyaccountSourceTypeId != null)
                {
                    body["accountSourceTypeId"] = SourceExpressionConverter.ConvertToken(bodyaccountSourceTypeId);
                    bodypropCount++;
                }

                if (bodyfullName != null)
                {
                    body["fullName"] = SourceExpressionConverter.ConvertToken(bodyfullName);
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
                    body["assignedTeams"] = SourceExpressionConverter.ConvertToken(bodyassignedTeams);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CustomerApiFeaturesContactsContactDTO>(BuildSourceInput);
        }
    }

    public class SoftonewebcrmTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CallCreated([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/WebHook/register/call/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger OpportunityUpdated([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/WebHook/register/opportunity/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger OpportunityDeleted([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/WebHook/register/opportunity/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger OpportunityCreated([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/WebHook/register/opportunity/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger LeadUpdated([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/WebHook/register/lead/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger LeadDeleted([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/WebHook/register/lead/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger LeadCreated([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/WebHook/register/lead/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TaskUpdated([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/WebHook/register/task/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TaskDeleted([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/WebHook/register/task/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TaskCreated([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/WebHook/register/task/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger EventUpdated([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/WebHook/register/event/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger EventDeleted([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/WebHook/register/event/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger EventCreated([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/WebHook/register/event/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger CallDeleted([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/WebHook/register/call/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger CallUpdated([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/WebHook/register/call/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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

    public enum TaskApiModelsEnumsAssignedToType
    {
        People,
        Queues
    }

    public enum TaskApiModelsEnumsRelatedToType
    {
        Account,
        Opportunity,
        Quote
    }

    public enum TaskApiModelsEnumsContactType
    {
        Lead,
        Contact
    }

    public enum TaskApiModelsEnumsStatus
    {
        Open,
        Completed
    }

    public enum TaskApiModelsEnumsCallDirection
    {
        Unknown,
        Inbound,
        Outbound
    }

    public enum statusInput
    {
        Open,
        Completed
    }

    public enum bodyassignedToTypeInput
    {
        People,
        Queues
    }

    public enum bodyrelatedToTypeInput
    {
        Account,
        Opportunity,
        Quote
    }

    public enum bodycontactTypeInput
    {
        Lead,
        Contact
    }

    public enum bodystatusInput
    {
        Open,
        Won,
        Lost,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    public enum bodycallDirectionInput
    {
        Unknown,
        Inbound,
        Outbound
    }

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

    public enum TaskApiModelsEnumsEventStatus
    {
        Scheduled,
        Completed,
        Rescheduled,
        Canceled
    }

    public enum eventStatusInput
    {
        Scheduled,
        Completed,
        Rescheduled,
        Canceled
    }

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

    public enum SalesPipelineApiModelsEnumsPhoneType
    {
        Work,
        Home,
        Other,
        [EnumMember(Value = "ignore")]
        Ignore
    }

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

    public enum SalesPipelineApiModelsEnumsStatus
    {
        Default,
        Qualified,
        Unqualified
    }

    public enum SalesPipelineApiFeaturesLeadUpdateLeadScoreLeadSentiment
    {
        Unqualified,
        Stalled,
        Cold,
        Warm,
        Hot
    }

    public enum ownerTypeInput
    {
        People,
        Queues
    }

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

    public enum SalesPipelineApiModelsEnumsOpportunityStatus
    {
        Open,
        Won,
        Lost,
        [EnumMember(Value = "ignore")]
        Ignore
    }

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