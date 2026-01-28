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
        public IBodyWorkflowAction<TaskApiFeaturesCallsCallDTO[]> CallGetAll(Expression<Func<string>> id = null, Expression<Func<statusInput>> status = null, Expression<Func<string>> priorityId = null, Expression<Func<string>> createdBy = null, Expression<Func<string>> lastModifiedBy = null, Expression<Func<string>> dueDate = null, Expression<Func<string>> sortDate = null, Expression<Func<string>> assignedToId = null, Expression<Func<string>> relatedToId = null, Expression<Func<string>> callResultId = null, Expression<Func<string>> search = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesCallsCallDTO> CallCreate(Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodysubject = null, Expression<Func<bodyassignedToTypeInput>> bodyassignedToType = null, Expression<Func<string>> bodyassignedToId = null, Expression<Func<bodyrelatedToTypeInput>> bodyrelatedToType = null, Expression<Func<string>> bodyrelatedToId = null, Expression<Func<bodycontactTypeInput>> bodycontactType = null, Expression<Func<string[]>> bodycontactIds = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodycallDuration = null, Expression<Func<string>> bodycallResultId = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodyeditorBody = null, Expression<Func<string>> bodypriorityId = null, Expression<Func<int>> bodyposition = null, Expression<Func<string>> bodyparentId = null, Expression<Func<bool>> bodyreminderSet = null, Expression<Func<string>> bodysortDate = null, Expression<Func<string>> bodysourceId = null, Expression<Func<string>> bodysourceAssignedToId = null, Expression<Func<string>> bodysourceRelatedToId = null, Expression<Func<string[]>> bodysourceContactIds = null, Expression<Func<bodycallDirectionInput>> bodycallDirection = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesCallsCallDTO> CallGetById(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/task/Call/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TaskApiFeaturesCallsCallDTO>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction CallDelete(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/task/Call/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesCallsCallDTO> CallUpdate(Expression<Func<string>> id, Expression<Func<bodytaskTypeInput>> bodytaskType = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodysubject = null, Expression<Func<bodyassignedToTypeInput>> bodyassignedToType = null, Expression<Func<string>> bodyassignedToId = null, Expression<Func<bodyrelatedToTypeInput>> bodyrelatedToType = null, Expression<Func<string>> bodyrelatedToId = null, Expression<Func<bodycontactTypeInput>> bodycontactType = null, Expression<Func<string[]>> bodycontactIds = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodycallDuration = null, Expression<Func<string>> bodycallResultId = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodyeditorBody = null, Expression<Func<string>> bodypriorityId = null, Expression<Func<int>> bodyposition = null, Expression<Func<string>> bodyparentId = null, Expression<Func<bool>> bodyreminderSet = null, Expression<Func<string>> bodylastModifiedBy = null, Expression<Func<string>> bodysortDate = null, Expression<Func<string>> bodysourceId = null, Expression<Func<string>> bodysourceAssignedToId = null, Expression<Func<string>> bodysourceRelatedToId = null, Expression<Func<string[]>> bodysourceContactIds = null, Expression<Func<bodycallDirectionInput>> bodycallDirection = null)
        {
            var apiCallPath = String.Format("/api/task/Call/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesEventsEventDTO[]> EventGetAll(Expression<Func<string>> id = null, Expression<Func<statusInput>> status = null, Expression<Func<eventStatusInput>> eventStatus = null, Expression<Func<string>> startDate = null, Expression<Func<string>> assignedToId = null, Expression<Func<string>> relatedToId = null, Expression<Func<string>> sortDate = null, Expression<Func<string>> parentId = null, Expression<Func<string>> eventResultId = null, Expression<Func<string>> priorityId = null, Expression<Func<string>> search = null, Expression<Func<string>> lastModifiedBy = null, Expression<Func<string>> createdBy = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesEventsEventDTO> EventCreate(Expression<Func<string>> bodyupdateDate = null, Expression<Func<string>> bodysubject = null, Expression<Func<bodytaskTypeInput>> bodytaskType = null, Expression<Func<bodyassignedToTypeInput>> bodyassignedToType = null, Expression<Func<string>> bodyassignedToId = null, Expression<Func<bodyrelatedToTypeInput>> bodyrelatedToType = null, Expression<Func<string>> bodyrelatedToId = null, Expression<Func<bodycontactTypeInput>> bodycontactType = null, Expression<Func<string[]>> bodycontactIds = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyeditorBody = null, Expression<Func<string>> bodypriorityId = null, Expression<Func<string>> bodylocationlongitude = null, Expression<Func<string>> bodylocationlatitude = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<bool>> bodyreminderSet = null, Expression<Func<string>> bodycreatedBy = null, Expression<Func<string>> bodylastModifiedBy = null, Expression<Func<int>> bodyposition = null, Expression<Func<string>> bodyparentId = null, Expression<Func<string>> bodyrepeat = null, Expression<Func<bodyeventStatusInput>> bodyeventStatus = null, Expression<Func<string>> bodyeventResultId = null, Expression<Func<string>> bodyrecurrenceInterval = null, Expression<Func<string>> bodysourceId = null, Expression<Func<string>> bodysourceAssignedToId = null, Expression<Func<string>> bodysourceRelatedToId = null, Expression<Func<string[]>> bodysourceContactIds = null, Expression<Func<string[]>> bodyteamMembers = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesEventsEventDTO> EventGetById(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/task/Event/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TaskApiFeaturesEventsEventDTO>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction EventDelete(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/task/Event/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesEventsEventDTO> EventUpdate(Expression<Func<string>> id, Expression<Func<string>> bodyupdateDate = null, Expression<Func<string>> bodysubject = null, Expression<Func<bodytaskTypeInput>> bodytaskType = null, Expression<Func<bodyassignedToTypeInput>> bodyassignedToType = null, Expression<Func<string>> bodyassignedToId = null, Expression<Func<bodyrelatedToTypeInput>> bodyrelatedToType = null, Expression<Func<string>> bodyrelatedToId = null, Expression<Func<bodycontactTypeInput>> bodycontactType = null, Expression<Func<string[]>> bodycontactIds = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyeditorBody = null, Expression<Func<string>> bodypriorityId = null, Expression<Func<string>> bodylocationlongitude = null, Expression<Func<string>> bodylocationlatitude = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<bool>> bodyreminderSet = null, Expression<Func<string>> bodycreatedBy = null, Expression<Func<string>> bodylastModifiedBy = null, Expression<Func<int>> bodyposition = null, Expression<Func<string>> bodyparentId = null, Expression<Func<string>> bodyrepeat = null, Expression<Func<bodyeventStatusInput>> bodyeventStatus = null, Expression<Func<string>> bodyeventResultId = null, Expression<Func<string>> bodyrecurrenceInterval = null, Expression<Func<string>> bodysourceId = null, Expression<Func<string>> bodysourceAssignedToId = null, Expression<Func<string>> bodysourceRelatedToId = null, Expression<Func<string[]>> bodysourceContactIds = null, Expression<Func<string[]>> bodyteamMembers = null)
        {
            var apiCallPath = String.Format("/api/task/Event/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesNotesNoteDTO[]> NoteGetAll(Expression<Func<string>> id = null, Expression<Func<string>> search = null, Expression<Func<string>> relatedToId = null, Expression<Func<relatedToTypeInput>> relatedToType = null, Expression<Func<string>> createdBy = null, Expression<Func<string>> lastModifiedBy = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesNotesNoteDTO> NoteCreate(Expression<Func<string>> bodysubject, Expression<Func<bodytaskTypeInput>> bodytaskType = null, Expression<Func<bodyrelatedToTypeInput>> bodyrelatedToType = null, Expression<Func<bodycontactTypeInput>> bodycontactType = null, Expression<Func<string>> bodyrelatedToId = null, Expression<Func<string>> bodybody = null, Expression<Func<string>> bodyeditorBody = null, Expression<Func<string[]>> bodycontactIds = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesNotesNoteDTO> NoteGetById(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/task/Note/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TaskApiFeaturesNotesNoteDTO>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction NoteDelete(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/task/Note/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesNotesNoteDTO> NoteUpdate(Expression<Func<string>> id, Expression<Func<bodyrelatedToTypeInput>> bodyrelatedToType = null, Expression<Func<string>> bodyrelatedToId = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodybody = null, Expression<Func<string>> bodyeditorBody = null, Expression<Func<string>> bodylastModifiedBy = null, Expression<Func<string[]>> bodycontactIds = null, Expression<Func<bodycontactTypeInput>> bodycontactType = null)
        {
            var apiCallPath = String.Format("/api/task/Note/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesTasksTaskDTO[]> TaskGetAll(Expression<Func<string>> id = null, Expression<Func<statusInput>> status = null, Expression<Func<string>> relatedTo = null, Expression<Func<string>> relatedToId = null, Expression<Func<string>> priorityId = null, Expression<Func<typeInput>> type = null, Expression<Func<string>> dueDate = null, Expression<Func<string>> sortDate = null, Expression<Func<string>> parentId = null, Expression<Func<string>> lastModifiedBy = null, Expression<Func<string>> createdBy = null, Expression<Func<string>> assignedToId = null, Expression<Func<string>> search = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesTasksTaskDTO> TaskCreate(Expression<Func<bodytaskTypeInput>> bodytaskType = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodydueDate = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodypriorityId = null, Expression<Func<string>> bodyassignedToId = null, Expression<Func<bodyassignedToTypeInput>> bodyassignedToType = null, Expression<Func<string[]>> bodycontactIds = null, Expression<Func<bodycontactTypeInput>> bodycontactType = null, Expression<Func<string>> bodyrelatedToId = null, Expression<Func<bodyrelatedToTypeInput>> bodyrelatedToType = null, Expression<Func<string>> bodytaskSubTypeId = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodyeditorBody = null, Expression<Func<bool>> bodyreminderSet = null, Expression<Func<int>> bodyposition = null, Expression<Func<string>> bodyparentId = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesTasksTaskDTO> TaskGetById(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/Task/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TaskApiFeaturesTasksTaskDTO>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction TaskDelete(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/Task/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesTasksTaskDTO> TaskUpdate(Expression<Func<string>> id, Expression<Func<bodytaskTypeInput>> bodytaskType = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodycompletedDate = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodypriorityId = null, Expression<Func<string>> bodyassignedToId = null, Expression<Func<bodyassignedToTypeInput>> bodyassignedToType = null, Expression<Func<string[]>> bodycontactIds = null, Expression<Func<bodycontactTypeInput>> bodycontactType = null, Expression<Func<string>> bodyrelatedToId = null, Expression<Func<bodyrelatedToTypeInput>> bodyrelatedToType = null, Expression<Func<string>> bodytaskSubTypeId = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodyeditorBody = null, Expression<Func<bool>> bodyreminderSet = null, Expression<Func<int>> bodyposition = null, Expression<Func<string>> bodyparentId = null, Expression<Func<string>> bodylastModifiedBy = null)
        {
            var apiCallPath = String.Format("/api/Task/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesLeadLeadDto[]> LeadGetAll(Expression<Func<string>> id = null, Expression<Func<string>> name = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lastName = null, Expression<Func<string>> insertDate = null, Expression<Func<string>> phone = null, Expression<Func<string>> mobilePhone = null, Expression<Func<string>> email = null, Expression<Func<string>> ownerId = null, Expression<Func<ownerTypeInput>> ownerType = null, Expression<Func<string>> accountSourceTypeId = null, Expression<Func<string>> leadStatusId = null, Expression<Func<string>> industryId = null, Expression<Func<string>> status = null, Expression<Func<string>> search = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesLeadLeadDto> LeadCreate(Expression<Func<string>> bodynamefirstName, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodyleadStatusId = null, Expression<Func<string>> bodynamelastName = null, Expression<Func<string>> bodynamemiddleName = null, Expression<Func<string>> bodynamesalutationId = null, Expression<Func<string>> bodynamesuffix = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodymobilePhone = null, Expression<Func<SalesPipelineApiDTOsEmailDTO[]>> bodyotherEmail = null, Expression<Func<SalesPipelineApiDTOsPhoneDTO[]>> bodyotherPhone = null, Expression<Func<bool>> bodycallOptOut = null, Expression<Func<bool>> bodyemailOptOut = null, Expression<Func<string>> bodyratingId = null, Expression<Func<string>> bodyownerId = null, Expression<Func<bodyownerTypeInput>> bodyownerType = null, Expression<Func<string>> bodywebsite = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodyindustryId = null, Expression<Func<int>> bodynoOfEmployees = null, Expression<Func<string>> bodyaccountSourceTypeId = null, Expression<Func<string>> bodyaddressaddress1 = null, Expression<Func<string>> bodyaddressaddress2 = null, Expression<Func<string>> bodyaddresscity = null, Expression<Func<string>> bodyaddressstate = null, Expression<Func<string>> bodyaddresscountry = null, Expression<Func<string>> bodyaddresspostalCode = null, Expression<Func<string>> bodydescription = null, Expression<Func<double>> bodyannualRevenue = null, Expression<Func<string>> bodylastTransferDate = null, Expression<Func<string>> bodygenderId = null, Expression<Func<string>> bodypronounceId = null, Expression<Func<bodystatusInput>> bodystatus = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesLeadLeadDto> LeadGetById(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/Lead/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SalesPipelineApiFeaturesLeadLeadDto>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction LeadDelete(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/Lead/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesLeadLeadDto> LeadUpdate(Expression<Func<string>> id, Expression<Func<string>> bodynamefirstName, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodyleadStatusId = null, Expression<Func<string>> bodynamelastName = null, Expression<Func<string>> bodynamemiddleName = null, Expression<Func<string>> bodynamesalutationId = null, Expression<Func<string>> bodynamesuffix = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodymobilePhone = null, Expression<Func<SalesPipelineApiDTOsEmailDTO[]>> bodyotherEmail = null, Expression<Func<SalesPipelineApiDTOsPhoneDTO[]>> bodyotherPhone = null, Expression<Func<bool>> bodycallOptOut = null, Expression<Func<bool>> bodyemailOptOut = null, Expression<Func<string>> bodyratingId = null, Expression<Func<string>> bodyownerId = null, Expression<Func<bodyownerTypeInput>> bodyownerType = null, Expression<Func<string>> bodywebsite = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodyindustryId = null, Expression<Func<int>> bodynoOfEmployees = null, Expression<Func<string>> bodyaccountSourceTypeId = null, Expression<Func<string>> bodyaddressaddress1 = null, Expression<Func<string>> bodyaddressaddress2 = null, Expression<Func<string>> bodyaddresscity = null, Expression<Func<string>> bodyaddressstate = null, Expression<Func<string>> bodyaddresscountry = null, Expression<Func<string>> bodyaddresspostalCode = null, Expression<Func<string>> bodydescription = null, Expression<Func<double>> bodyannualRevenue = null, Expression<Func<string>> bodylastTransferDate = null, Expression<Func<string>> bodygenderId = null, Expression<Func<string>> bodypronounceId = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodylastModifiedBy = null)
        {
            var apiCallPath = String.Format("/api/Lead/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO[]> OpportunityGetAll(Expression<Func<string>> id = null, Expression<Func<string>> ownerId = null, Expression<Func<string>> name = null, Expression<Func<double>> amount = null, Expression<Func<string>> closeDate = null, Expression<Func<string>> updateDate = null, Expression<Func<string>> insertDate = null, Expression<Func<string>> accountId = null, Expression<Func<string>> forecastCategoryId = null, Expression<Func<string>> accountSourceTypeId = null, Expression<Func<string>> opportunityStatusId = null, Expression<Func<string>> quoteId = null, Expression<Func<string>> lossReasonId = null, Expression<Func<string>> typeId = null, Expression<Func<string>> lastModifiedBy = null, Expression<Func<string>> createdBy = null, Expression<Func<string>> search = null, Expression<Func<string>> salesPipelineId = null, Expression<Func<string>> status = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO> OpportunityCreate(Expression<Func<string>> bodyname, Expression<Func<string>> bodycloseDate, Expression<Func<string>> bodytypeId = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string>> bodyaccountId = null, Expression<Func<double>> bodyamount = null, Expression<Func<string>> bodyforecastCategoryId = null, Expression<Func<string>> bodysalesPipelineId = null, Expression<Func<int>> bodyprobability = null, Expression<Func<int>> bodyscore = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyquoteId = null, Expression<Func<string>> bodyopportunityStatusId = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodyaccountSourceTypeId = null, Expression<Func<string>> bodynextStep = null, Expression<Func<bool>> bodybudgetConfirmed = null, Expression<Func<bool>> bodydiscoveryCompleted = null, Expression<Func<double>> bodyexpectedRevenue = null, Expression<Func<string>> bodylossReasonId = null, Expression<Func<bool>> bodyprivate = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO> OpportunityGetById(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/Opportunity/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction OpportunityDelete(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/Opportunity/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO> OpportunityUpdate(Expression<Func<string>> id, Expression<Func<string>> bodytypeId = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string>> bodyaccountId = null, Expression<Func<string>> bodyname = null, Expression<Func<double>> bodyamount = null, Expression<Func<string>> bodyforecastCategoryId = null, Expression<Func<string>> bodycloseDate = null, Expression<Func<int>> bodyprobability = null, Expression<Func<int>> bodyscore = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodysalesPipelineId = null, Expression<Func<string>> bodyquoteId = null, Expression<Func<string>> bodyopportunityStatusId = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodyaccountSourceTypeId = null, Expression<Func<string>> bodynextStep = null, Expression<Func<bool>> bodybudgetConfirmed = null, Expression<Func<bool>> bodydiscoveryCompleted = null, Expression<Func<double>> bodyexpectedRevenue = null, Expression<Func<string>> bodylossReasonId = null, Expression<Func<bool>> bodyprivate = null, Expression<Func<string>> bodylastModifiedBy = null)
        {
            var apiCallPath = String.Format("/api/Opportunity/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<IdentityApiBackOfficeUsersGetUserGetUserResponse> UserGetById(Expression<Func<string>> userId)
        {
            var apiCallPath = String.Format("/api/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IdentityApiBackOfficeUsersGetUserGetUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<IdentityApiTeamsDtosGetTeamResponse> TeamGetById(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/teams/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IdentityApiTeamsDtosGetTeamResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<CustomerApiFeaturesAccountsAccountDTO> AccountGetById(Expression<Func<string>> accountId)
        {
            var apiCallPath = String.Format("/api/Account/{0}", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CustomerApiFeaturesAccountsAccountDTO>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction AccountDelete(Expression<Func<string>> accountId)
        {
            var apiCallPath = String.Format("/api/Account/{0}", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<CustomerApiFeaturesAccountsAccountDTO> AccountUpdate(Expression<Func<string>> accountId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodytin = null, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodysourceId = null, Expression<Func<string>> bodysourceParentId = null, Expression<Func<string>> bodysourceOwnerId = null, Expression<Func<string[]>> bodyprimaryContactIds = null, Expression<Func<string>> bodyparentAccountId = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string>> bodyaddressaddress1 = null, Expression<Func<string>> bodyaddressaddress2 = null, Expression<Func<string>> bodyaddresscity = null, Expression<Func<string>> bodyaddressstate = null, Expression<Func<string>> bodyaddresslatitude = null, Expression<Func<string>> bodyaddresslongtitude = null, Expression<Func<string>> bodyaddresscountry = null, Expression<Func<string>> bodyaddresscountryCode = null, Expression<Func<string>> bodyaddresspostalCode = null, Expression<Func<string>> bodyaddressfirstName = null, Expression<Func<string>> bodyaddresslastName = null, Expression<Func<string>> bodyaddressphoneNumber = null, Expression<Func<string>> bodyaddressemail = null, Expression<Func<string>> bodyaccountSourceTypeId = null, Expression<Func<string>> bodyindustryId = null, Expression<Func<string>> bodytierId = null, Expression<Func<string>> bodywebsite = null, Expression<Func<string>> bodyaccountDescription = null, Expression<Func<int>> bodynoOfEmployees = null, Expression<Func<double>> bodyannualRevenue = null, Expression<Func<string>> bodycreatedBy = null, Expression<Func<string>> bodylastModifiedBy = null, Expression<Func<string>> bodyfax = null, Expression<Func<string>> bodyownershipId = null, Expression<Func<string>> bodyratingId = null, Expression<Func<string>> bodyclassificationId = null, Expression<Func<string[]>> bodyassignedTeams = null)
        {
            var apiCallPath = String.Format("/api/Account/{0}", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<CustomerApiFeaturesAccountsAccountDTO[]> AccountGetAll(Expression<Func<string>> parentAccount = null, Expression<Func<string>> phone = null, Expression<Func<string>> suggestions = null, Expression<Func<string>> ownerId = null, Expression<Func<string>> ownershipId = null, Expression<Func<string>> ratingId = null, Expression<Func<string>> classificationId = null, Expression<Func<string>> industryId = null, Expression<Func<string>> accountSourceTypeId = null, Expression<Func<string>> primaryContactId = null, Expression<Func<string>> assignedTeams = null, Expression<Func<string>> search = null, Expression<Func<string>> name = null, Expression<Func<string>> id = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<CustomerApiFeaturesAccountsAccountDTO> AccountCreate(Expression<Func<string>> bodyname, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodycompanyId = null, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodytin = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodysourceId = null, Expression<Func<string>> bodysourceParentId = null, Expression<Func<string>> bodysourceOwnerId = null, Expression<Func<string[]>> bodyprimaryContactIds = null, Expression<Func<string>> bodyparentAccountId = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string>> bodyaddressaddress1 = null, Expression<Func<string>> bodyaddressaddress2 = null, Expression<Func<string>> bodyaddresscity = null, Expression<Func<string>> bodyaddressstate = null, Expression<Func<string>> bodyaddresslatitude = null, Expression<Func<string>> bodyaddresslongtitude = null, Expression<Func<string>> bodyaddresscountry = null, Expression<Func<string>> bodyaddresscountryCode = null, Expression<Func<string>> bodyaddresspostalCode = null, Expression<Func<string>> bodyaddressfirstName = null, Expression<Func<string>> bodyaddresslastName = null, Expression<Func<string>> bodyaddressphoneNumber = null, Expression<Func<string>> bodyaddressemail = null, Expression<Func<string>> bodyupdateDate = null, Expression<Func<string>> bodyinsertDate = null, Expression<Func<string>> bodytaxOffice = null, Expression<Func<string>> bodyaccountSourceTypeId = null, Expression<Func<string>> bodyindustryId = null, Expression<Func<string>> bodytierId = null, Expression<Func<string>> bodywebsite = null, Expression<Func<string>> bodyaccountDescription = null, Expression<Func<int>> bodynoOfEmployees = null, Expression<Func<double>> bodyannualRevenue = null, Expression<Func<string>> bodycreatedBy = null, Expression<Func<string>> bodylastModifiedBy = null, Expression<Func<string>> bodyfax = null, Expression<Func<string>> bodyownershipId = null, Expression<Func<string>> bodyratingId = null, Expression<Func<string>> bodyclassificationId = null, Expression<Func<string[]>> bodyassignedTeams = null, Expression<Func<double>> bodyaiScore = null, Expression<Func<string>> bodyaiScoreReasoning = null, Expression<Func<bodyaiSentimentInput>> bodyaiSentiment = null, Expression<Func<string>> bodyaiGenerationDate = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<CustomerApiFeaturesContactsContact> ContactGetById(Expression<Func<string>> contactId)
        {
            var apiCallPath = String.Format("/api/Contact/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CustomerApiFeaturesContactsContact>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction ContactDelete(Expression<Func<string>> contactId)
        {
            var apiCallPath = String.Format("/api/Contact/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<CustomerApiFeaturesContactsContactDTO> ContactUpdate(Expression<Func<string>> contactId, Expression<Func<string>> bodyownerId = null, Expression<Func<string[]>> bodyaccountIds = null, Expression<Func<string>> bodysourceId = null, Expression<Func<string>> bodysourceOwnerId = null, Expression<Func<string[]>> bodysourceAccountIds = null, Expression<Func<string>> bodynamefirstName = null, Expression<Func<string>> bodynamelastName = null, Expression<Func<string>> bodynamemiddleName = null, Expression<Func<string>> bodynamesalutationId = null, Expression<Func<string>> bodynamesuffix = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodymobilePhone = null, Expression<Func<string>> bodyfax = null, Expression<Func<bool>> bodycallOptOut = null, Expression<Func<bool>> bodyemailOptOut = null, Expression<Func<CustomerApiFeaturesContactsEmailDTO[]>> bodyotherEmail = null, Expression<Func<CustomerApiFeaturesContactsPhoneDTO[]>> bodyotherPhone = null, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodygenderId = null, Expression<Func<string>> bodypronounceId = null, Expression<Func<string>> bodyaddressaddress1 = null, Expression<Func<string>> bodyaddressaddress2 = null, Expression<Func<string>> bodyaddresscity = null, Expression<Func<string>> bodyaddressstate = null, Expression<Func<string>> bodyaddresslatitude = null, Expression<Func<string>> bodyaddresslongtitude = null, Expression<Func<string>> bodyaddresscountry = null, Expression<Func<string>> bodyaddresscountryCode = null, Expression<Func<string>> bodyaddresspostalCode = null, Expression<Func<string>> bodyaddressfirstName = null, Expression<Func<string>> bodyaddresslastName = null, Expression<Func<string>> bodyaddressphoneNumber = null, Expression<Func<string>> bodyaddressemail = null, Expression<Func<string>> bodycreatedBy = null, Expression<Func<string>> bodylastModifiedBy = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodyreportsTo = null, Expression<Func<string>> bodyassistant = null, Expression<Func<string>> bodyassistantPhone = null, Expression<Func<string>> bodybirthday = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodylastStayInTouchReportedDate = null, Expression<Func<string>> bodylastStayInTouchSaveDate = null, Expression<Func<string>> bodyaccountSourceTypeId = null, Expression<Func<string[]>> bodyassignedTeams = null)
        {
            var apiCallPath = String.Format("/api/Contact/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<CustomerApiFeaturesContactsContactDTO[]> ContactGetAll(Expression<Func<string>> name = null, Expression<Func<string>> ownerId = null, Expression<Func<string>> suggestions = null, Expression<Func<string>> accountSourceTypeId = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lastName = null, Expression<Func<string>> phone = null, Expression<Func<string>> mobilePhone = null, Expression<Func<string>> accountIds = null, Expression<Func<string>> email = null, Expression<Func<string>> id = null, Expression<Func<string>> assignedTeams = null, Expression<Func<string>> search = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<CustomerApiFeaturesContactsContactDTO> ContactCreate(Expression<Func<string>> bodyid = null, Expression<Func<string>> bodycompanyId = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string[]>> bodyaccountIds = null, Expression<Func<string>> bodysourceId = null, Expression<Func<string>> bodysourceOwnerId = null, Expression<Func<string[]>> bodysourceAccountIds = null, Expression<Func<string>> bodynamefirstName = null, Expression<Func<string>> bodynamelastName = null, Expression<Func<string>> bodynamemiddleName = null, Expression<Func<string>> bodynamesalutationId = null, Expression<Func<string>> bodynamesuffix = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodymobilePhone = null, Expression<Func<string>> bodyfax = null, Expression<Func<bool>> bodycallOptOut = null, Expression<Func<bool>> bodyemailOptOut = null, Expression<Func<CustomerApiFeaturesContactsEmailDTO[]>> bodyotherEmail = null, Expression<Func<CustomerApiFeaturesContactsPhoneDTO[]>> bodyotherPhone = null, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodygenderId = null, Expression<Func<string>> bodypronounceId = null, Expression<Func<string>> bodyaddressaddress1 = null, Expression<Func<string>> bodyaddressaddress2 = null, Expression<Func<string>> bodyaddresscity = null, Expression<Func<string>> bodyaddressstate = null, Expression<Func<string>> bodyaddresslatitude = null, Expression<Func<string>> bodyaddresslongtitude = null, Expression<Func<string>> bodyaddresscountry = null, Expression<Func<string>> bodyaddresscountryCode = null, Expression<Func<string>> bodyaddresspostalCode = null, Expression<Func<string>> bodyaddressfirstName = null, Expression<Func<string>> bodyaddresslastName = null, Expression<Func<string>> bodyaddressphoneNumber = null, Expression<Func<string>> bodyaddressemail = null, Expression<Func<string>> bodyinsertDate = null, Expression<Func<string>> bodyupdateDate = null, Expression<Func<string>> bodycreatedBy = null, Expression<Func<string>> bodylastModifiedBy = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodyreportsTo = null, Expression<Func<string>> bodyassistant = null, Expression<Func<string>> bodyassistantPhone = null, Expression<Func<string>> bodybirthday = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodylastStayInTouchReportedDate = null, Expression<Func<string>> bodylastStayInTouchSaveDate = null, Expression<Func<string>> bodyaccountSourceTypeId = null, Expression<Func<string>> bodyfullName = null, Expression<Func<string[]>> bodyassignedTeams = null)
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
        }
    }

    public class SoftonewebcrmTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CallCreated(Expression<Func<string>> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/WebHook/register/call/created";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["Url"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["Title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger OpportunityUpdated(Expression<Func<string>> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/WebHook/register/opportunity/updated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["Url"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["Title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger OpportunityDeleted(Expression<Func<string>> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/WebHook/register/opportunity/deleted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["Url"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["Title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger OpportunityCreated(Expression<Func<string>> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/WebHook/register/opportunity/created";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["Url"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["Title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger LeadUpdated(Expression<Func<string>> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/WebHook/register/lead/updated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["Url"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["Title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger LeadDeleted(Expression<Func<string>> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/WebHook/register/lead/deleted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["Url"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["Title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger LeadCreated(Expression<Func<string>> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/WebHook/register/lead/created";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["Url"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["Title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TaskUpdated(Expression<Func<string>> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/WebHook/register/task/updated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["Url"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["Title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TaskDeleted(Expression<Func<string>> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/WebHook/register/task/deleted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["Url"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["Title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TaskCreated(Expression<Func<string>> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/WebHook/register/task/created";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["Url"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["Title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger EventUpdated(Expression<Func<string>> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/WebHook/register/event/updated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["Url"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["Title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger EventDeleted(Expression<Func<string>> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/WebHook/register/event/deleted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["Url"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["Title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger EventCreated(Expression<Func<string>> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/WebHook/register/event/created";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["Url"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["Title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger CallDeleted(Expression<Func<string>> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/WebHook/register/call/deleted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["Url"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["Title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger CallUpdated(Expression<Func<string>> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/WebHook/register/call/updated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["Url"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["Title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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