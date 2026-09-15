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
                callPayload.Queries["Id"] = CSharpExpressionConverter.ConvertO(id);
            if (status != null)
                callPayload.Queries["Status"] = CSharpExpressionConverter.Convert(status);
            if (priorityId != null)
                callPayload.Queries["PriorityId"] = CSharpExpressionConverter.ConvertO(priorityId);
            if (createdBy != null)
                callPayload.Queries["CreatedBy"] = CSharpExpressionConverter.ConvertO(createdBy);
            if (lastModifiedBy != null)
                callPayload.Queries["LastModifiedBy"] = CSharpExpressionConverter.ConvertO(lastModifiedBy);
            if (dueDate != null)
                callPayload.Queries["DueDate"] = CSharpExpressionConverter.ConvertO(dueDate);
            if (sortDate != null)
                callPayload.Queries["SortDate"] = CSharpExpressionConverter.ConvertO(sortDate);
            if (assignedToId != null)
                callPayload.Queries["AssignedToId"] = CSharpExpressionConverter.ConvertO(assignedToId);
            if (relatedToId != null)
                callPayload.Queries["RelatedToId"] = CSharpExpressionConverter.ConvertO(relatedToId);
            if (callResultId != null)
                callPayload.Queries["CallResultId"] = CSharpExpressionConverter.ConvertO(callResultId);
            if (search != null)
                callPayload.Queries["Search"] = CSharpExpressionConverter.ConvertO(search);
            if (page != null)
                callPayload.Queries["Page"] = CSharpExpressionConverter.ConvertO(page);
            if (pageSize != null)
                callPayload.Queries["PageSize"] = CSharpExpressionConverter.ConvertO(pageSize);
            if (sort != null)
                callPayload.Queries["Sort"] = CSharpExpressionConverter.ConvertO(sort);
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
                body["dueDate"] = CSharpExpressionConverter.ConvertToken(bodydueDate);
                bodypropCount++;
            }

            if (bodysubject != null)
            {
                body["subject"] = CSharpExpressionConverter.ConvertToken(bodysubject);
                bodypropCount++;
            }

            if (bodyassignedToType != null)
            {
                body["assignedToType"] = CSharpExpressionConverter.Convert(bodyassignedToType);
                bodypropCount++;
            }

            if (bodyassignedToId != null)
            {
                body["assignedToId"] = CSharpExpressionConverter.ConvertToken(bodyassignedToId);
                bodypropCount++;
            }

            if (bodyrelatedToType != null)
            {
                body["relatedToType"] = CSharpExpressionConverter.Convert(bodyrelatedToType);
                bodypropCount++;
            }

            if (bodyrelatedToId != null)
            {
                body["relatedToId"] = CSharpExpressionConverter.ConvertToken(bodyrelatedToId);
                bodypropCount++;
            }

            if (bodycontactType != null)
            {
                body["contactType"] = CSharpExpressionConverter.Convert(bodycontactType);
                bodypropCount++;
            }

            if (bodycontactIds != null)
            {
                body["contactIds"] = CSharpExpressionConverter.ConvertToken(bodycontactIds);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = CSharpExpressionConverter.Convert(bodystatus);
                bodypropCount++;
            }

            if (bodycallDuration != null)
            {
                body["callDuration"] = CSharpExpressionConverter.ConvertToken(bodycallDuration);
                bodypropCount++;
            }

            if (bodycallResultId != null)
            {
                body["callResultId"] = CSharpExpressionConverter.ConvertToken(bodycallResultId);
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comments"] = CSharpExpressionConverter.ConvertToken(bodycomments);
                bodypropCount++;
            }

            if (bodyeditorBody != null)
            {
                body["editorBody"] = CSharpExpressionConverter.ConvertToken(bodyeditorBody);
                bodypropCount++;
            }

            if (bodypriorityId != null)
            {
                body["priorityId"] = CSharpExpressionConverter.ConvertToken(bodypriorityId);
                bodypropCount++;
            }

            if (bodyposition != null)
            {
                body["position"] = CSharpExpressionConverter.ConvertToken(bodyposition);
                bodypropCount++;
            }

            if (bodyparentId != null)
            {
                body["parentId"] = CSharpExpressionConverter.ConvertToken(bodyparentId);
                bodypropCount++;
            }

            if (bodyreminderSet != null)
            {
                body["reminderSet"] = CSharpExpressionConverter.ConvertToken(bodyreminderSet);
                bodypropCount++;
            }

            if (bodysortDate != null)
            {
                body["sortDate"] = CSharpExpressionConverter.ConvertToken(bodysortDate);
                bodypropCount++;
            }

            if (bodysourceId != null)
            {
                body["sourceId"] = CSharpExpressionConverter.ConvertToken(bodysourceId);
                bodypropCount++;
            }

            if (bodysourceAssignedToId != null)
            {
                body["sourceAssignedToId"] = CSharpExpressionConverter.ConvertToken(bodysourceAssignedToId);
                bodypropCount++;
            }

            if (bodysourceRelatedToId != null)
            {
                body["sourceRelatedToId"] = CSharpExpressionConverter.ConvertToken(bodysourceRelatedToId);
                bodypropCount++;
            }

            if (bodysourceContactIds != null)
            {
                body["sourceContactIds"] = CSharpExpressionConverter.ConvertToken(bodysourceContactIds);
                bodypropCount++;
            }

            if (bodycallDirection != null)
            {
                body["callDirection"] = CSharpExpressionConverter.Convert(bodycallDirection);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/task/Call/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TaskApiFeaturesCallsCallDTO>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction CallDelete(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/task/Call/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesCallsCallDTO> CallUpdate(Expression<Func<string>> id, Expression<Func<bodytaskTypeInput>> bodytaskType = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodysubject = null, Expression<Func<bodyassignedToTypeInput>> bodyassignedToType = null, Expression<Func<string>> bodyassignedToId = null, Expression<Func<bodyrelatedToTypeInput>> bodyrelatedToType = null, Expression<Func<string>> bodyrelatedToId = null, Expression<Func<bodycontactTypeInput>> bodycontactType = null, Expression<Func<string[]>> bodycontactIds = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodycallDuration = null, Expression<Func<string>> bodycallResultId = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodyeditorBody = null, Expression<Func<string>> bodypriorityId = null, Expression<Func<int>> bodyposition = null, Expression<Func<string>> bodyparentId = null, Expression<Func<bool>> bodyreminderSet = null, Expression<Func<string>> bodylastModifiedBy = null, Expression<Func<string>> bodysortDate = null, Expression<Func<string>> bodysourceId = null, Expression<Func<string>> bodysourceAssignedToId = null, Expression<Func<string>> bodysourceRelatedToId = null, Expression<Func<string[]>> bodysourceContactIds = null, Expression<Func<bodycallDirectionInput>> bodycallDirection = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/task/Call/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytaskType != null)
            {
                body["taskType"] = CSharpExpressionConverter.Convert(bodytaskType);
                bodypropCount++;
            }

            if (bodydueDate != null)
            {
                body["dueDate"] = CSharpExpressionConverter.ConvertToken(bodydueDate);
                bodypropCount++;
            }

            if (bodysubject != null)
            {
                body["subject"] = CSharpExpressionConverter.ConvertToken(bodysubject);
                bodypropCount++;
            }

            if (bodyassignedToType != null)
            {
                body["assignedToType"] = CSharpExpressionConverter.Convert(bodyassignedToType);
                bodypropCount++;
            }

            if (bodyassignedToId != null)
            {
                body["assignedToId"] = CSharpExpressionConverter.ConvertToken(bodyassignedToId);
                bodypropCount++;
            }

            if (bodyrelatedToType != null)
            {
                body["relatedToType"] = CSharpExpressionConverter.Convert(bodyrelatedToType);
                bodypropCount++;
            }

            if (bodyrelatedToId != null)
            {
                body["relatedToId"] = CSharpExpressionConverter.ConvertToken(bodyrelatedToId);
                bodypropCount++;
            }

            if (bodycontactType != null)
            {
                body["contactType"] = CSharpExpressionConverter.Convert(bodycontactType);
                bodypropCount++;
            }

            if (bodycontactIds != null)
            {
                body["contactIds"] = CSharpExpressionConverter.ConvertToken(bodycontactIds);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = CSharpExpressionConverter.Convert(bodystatus);
                bodypropCount++;
            }

            if (bodycallDuration != null)
            {
                body["callDuration"] = CSharpExpressionConverter.ConvertToken(bodycallDuration);
                bodypropCount++;
            }

            if (bodycallResultId != null)
            {
                body["callResultId"] = CSharpExpressionConverter.ConvertToken(bodycallResultId);
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comments"] = CSharpExpressionConverter.ConvertToken(bodycomments);
                bodypropCount++;
            }

            if (bodyeditorBody != null)
            {
                body["editorBody"] = CSharpExpressionConverter.ConvertToken(bodyeditorBody);
                bodypropCount++;
            }

            if (bodypriorityId != null)
            {
                body["priorityId"] = CSharpExpressionConverter.ConvertToken(bodypriorityId);
                bodypropCount++;
            }

            if (bodyposition != null)
            {
                body["position"] = CSharpExpressionConverter.ConvertToken(bodyposition);
                bodypropCount++;
            }

            if (bodyparentId != null)
            {
                body["parentId"] = CSharpExpressionConverter.ConvertToken(bodyparentId);
                bodypropCount++;
            }

            if (bodyreminderSet != null)
            {
                body["reminderSet"] = CSharpExpressionConverter.ConvertToken(bodyreminderSet);
                bodypropCount++;
            }

            if (bodylastModifiedBy != null)
            {
                body["lastModifiedBy"] = CSharpExpressionConverter.ConvertToken(bodylastModifiedBy);
                bodypropCount++;
            }

            if (bodysortDate != null)
            {
                body["sortDate"] = CSharpExpressionConverter.ConvertToken(bodysortDate);
                bodypropCount++;
            }

            if (bodysourceId != null)
            {
                body["sourceId"] = CSharpExpressionConverter.ConvertToken(bodysourceId);
                bodypropCount++;
            }

            if (bodysourceAssignedToId != null)
            {
                body["sourceAssignedToId"] = CSharpExpressionConverter.ConvertToken(bodysourceAssignedToId);
                bodypropCount++;
            }

            if (bodysourceRelatedToId != null)
            {
                body["sourceRelatedToId"] = CSharpExpressionConverter.ConvertToken(bodysourceRelatedToId);
                bodypropCount++;
            }

            if (bodysourceContactIds != null)
            {
                body["sourceContactIds"] = CSharpExpressionConverter.ConvertToken(bodysourceContactIds);
                bodypropCount++;
            }

            if (bodycallDirection != null)
            {
                body["callDirection"] = CSharpExpressionConverter.Convert(bodycallDirection);
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
                callPayload.Queries["Id"] = CSharpExpressionConverter.ConvertO(id);
            if (status != null)
                callPayload.Queries["Status"] = CSharpExpressionConverter.Convert(status);
            if (eventStatus != null)
                callPayload.Queries["EventStatus"] = CSharpExpressionConverter.Convert(eventStatus);
            if (startDate != null)
                callPayload.Queries["StartDate"] = CSharpExpressionConverter.ConvertO(startDate);
            if (assignedToId != null)
                callPayload.Queries["AssignedToId"] = CSharpExpressionConverter.ConvertO(assignedToId);
            if (relatedToId != null)
                callPayload.Queries["RelatedToId"] = CSharpExpressionConverter.ConvertO(relatedToId);
            if (sortDate != null)
                callPayload.Queries["SortDate"] = CSharpExpressionConverter.ConvertO(sortDate);
            if (parentId != null)
                callPayload.Queries["ParentId"] = CSharpExpressionConverter.ConvertO(parentId);
            if (eventResultId != null)
                callPayload.Queries["EventResultId"] = CSharpExpressionConverter.ConvertO(eventResultId);
            if (priorityId != null)
                callPayload.Queries["PriorityId"] = CSharpExpressionConverter.ConvertO(priorityId);
            if (search != null)
                callPayload.Queries["Search"] = CSharpExpressionConverter.ConvertO(search);
            if (lastModifiedBy != null)
                callPayload.Queries["LastModifiedBy"] = CSharpExpressionConverter.ConvertO(lastModifiedBy);
            if (createdBy != null)
                callPayload.Queries["CreatedBy"] = CSharpExpressionConverter.ConvertO(createdBy);
            if (page != null)
                callPayload.Queries["Page"] = CSharpExpressionConverter.ConvertO(page);
            if (pageSize != null)
                callPayload.Queries["PageSize"] = CSharpExpressionConverter.ConvertO(pageSize);
            if (sort != null)
                callPayload.Queries["Sort"] = CSharpExpressionConverter.ConvertO(sort);
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
                body["updateDate"] = CSharpExpressionConverter.ConvertToken(bodyupdateDate);
                bodypropCount++;
            }

            if (bodysubject != null)
            {
                body["subject"] = CSharpExpressionConverter.ConvertToken(bodysubject);
                bodypropCount++;
            }

            if (bodytaskType != null)
            {
                body["taskType"] = CSharpExpressionConverter.Convert(bodytaskType);
                bodypropCount++;
            }

            if (bodyassignedToType != null)
            {
                body["assignedToType"] = CSharpExpressionConverter.Convert(bodyassignedToType);
                bodypropCount++;
            }

            if (bodyassignedToId != null)
            {
                body["assignedToId"] = CSharpExpressionConverter.ConvertToken(bodyassignedToId);
                bodypropCount++;
            }

            if (bodyrelatedToType != null)
            {
                body["relatedToType"] = CSharpExpressionConverter.Convert(bodyrelatedToType);
                bodypropCount++;
            }

            if (bodyrelatedToId != null)
            {
                body["relatedToId"] = CSharpExpressionConverter.ConvertToken(bodyrelatedToId);
                bodypropCount++;
            }

            if (bodycontactType != null)
            {
                body["contactType"] = CSharpExpressionConverter.Convert(bodycontactType);
                bodypropCount++;
            }

            if (bodycontactIds != null)
            {
                body["contactIds"] = CSharpExpressionConverter.ConvertToken(bodycontactIds);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodyeditorBody != null)
            {
                body["editorBody"] = CSharpExpressionConverter.ConvertToken(bodyeditorBody);
                bodypropCount++;
            }

            if (bodypriorityId != null)
            {
                body["priorityId"] = CSharpExpressionConverter.ConvertToken(bodypriorityId);
                bodypropCount++;
            }

            var locationObject = new JObject();
            var locationObjectpropCount = 0;
            if (bodylocationlongitude != null)
            {
                locationObject["longitude"] = CSharpExpressionConverter.ConvertToken(bodylocationlongitude);
                locationObjectpropCount++;
            }

            if (bodylocationlatitude != null)
            {
                locationObject["latitude"] = CSharpExpressionConverter.ConvertToken(bodylocationlatitude);
                locationObjectpropCount++;
            }

            if (locationObjectpropCount > 0)
            {
                body["location"] = locationObject;
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["startDate"] = CSharpExpressionConverter.ConvertToken(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["endDate"] = CSharpExpressionConverter.ConvertToken(bodyendDate);
                bodypropCount++;
            }

            if (bodyreminderSet != null)
            {
                body["reminderSet"] = CSharpExpressionConverter.ConvertToken(bodyreminderSet);
                bodypropCount++;
            }

            if (bodycreatedBy != null)
            {
                body["createdBy"] = CSharpExpressionConverter.ConvertToken(bodycreatedBy);
                bodypropCount++;
            }

            if (bodylastModifiedBy != null)
            {
                body["lastModifiedBy"] = CSharpExpressionConverter.ConvertToken(bodylastModifiedBy);
                bodypropCount++;
            }

            if (bodyposition != null)
            {
                body["position"] = CSharpExpressionConverter.ConvertToken(bodyposition);
                bodypropCount++;
            }

            if (bodyparentId != null)
            {
                body["parentId"] = CSharpExpressionConverter.ConvertToken(bodyparentId);
                bodypropCount++;
            }

            if (bodyrepeat != null)
            {
                body["repeat"] = CSharpExpressionConverter.ConvertToken(bodyrepeat);
                bodypropCount++;
            }

            if (bodyeventStatus != null)
            {
                body["eventStatus"] = CSharpExpressionConverter.Convert(bodyeventStatus);
                bodypropCount++;
            }

            if (bodyeventResultId != null)
            {
                body["eventResultId"] = CSharpExpressionConverter.ConvertToken(bodyeventResultId);
                bodypropCount++;
            }

            if (bodyrecurrenceInterval != null)
            {
                body["recurrenceInterval"] = CSharpExpressionConverter.ConvertToken(bodyrecurrenceInterval);
                bodypropCount++;
            }

            if (bodysourceId != null)
            {
                body["sourceId"] = CSharpExpressionConverter.ConvertToken(bodysourceId);
                bodypropCount++;
            }

            if (bodysourceAssignedToId != null)
            {
                body["sourceAssignedToId"] = CSharpExpressionConverter.ConvertToken(bodysourceAssignedToId);
                bodypropCount++;
            }

            if (bodysourceRelatedToId != null)
            {
                body["sourceRelatedToId"] = CSharpExpressionConverter.ConvertToken(bodysourceRelatedToId);
                bodypropCount++;
            }

            if (bodysourceContactIds != null)
            {
                body["sourceContactIds"] = CSharpExpressionConverter.ConvertToken(bodysourceContactIds);
                bodypropCount++;
            }

            if (bodyteamMembers != null)
            {
                body["teamMembers"] = CSharpExpressionConverter.ConvertToken(bodyteamMembers);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/task/Event/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TaskApiFeaturesEventsEventDTO>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction EventDelete(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/task/Event/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesEventsEventDTO> EventUpdate(Expression<Func<string>> id, Expression<Func<string>> bodyupdateDate = null, Expression<Func<string>> bodysubject = null, Expression<Func<bodytaskTypeInput>> bodytaskType = null, Expression<Func<bodyassignedToTypeInput>> bodyassignedToType = null, Expression<Func<string>> bodyassignedToId = null, Expression<Func<bodyrelatedToTypeInput>> bodyrelatedToType = null, Expression<Func<string>> bodyrelatedToId = null, Expression<Func<bodycontactTypeInput>> bodycontactType = null, Expression<Func<string[]>> bodycontactIds = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyeditorBody = null, Expression<Func<string>> bodypriorityId = null, Expression<Func<string>> bodylocationlongitude = null, Expression<Func<string>> bodylocationlatitude = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<bool>> bodyreminderSet = null, Expression<Func<string>> bodycreatedBy = null, Expression<Func<string>> bodylastModifiedBy = null, Expression<Func<int>> bodyposition = null, Expression<Func<string>> bodyparentId = null, Expression<Func<string>> bodyrepeat = null, Expression<Func<bodyeventStatusInput>> bodyeventStatus = null, Expression<Func<string>> bodyeventResultId = null, Expression<Func<string>> bodyrecurrenceInterval = null, Expression<Func<string>> bodysourceId = null, Expression<Func<string>> bodysourceAssignedToId = null, Expression<Func<string>> bodysourceRelatedToId = null, Expression<Func<string[]>> bodysourceContactIds = null, Expression<Func<string[]>> bodyteamMembers = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/task/Event/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyupdateDate != null)
            {
                body["updateDate"] = CSharpExpressionConverter.ConvertToken(bodyupdateDate);
                bodypropCount++;
            }

            if (bodysubject != null)
            {
                body["subject"] = CSharpExpressionConverter.ConvertToken(bodysubject);
                bodypropCount++;
            }

            if (bodytaskType != null)
            {
                body["taskType"] = CSharpExpressionConverter.Convert(bodytaskType);
                bodypropCount++;
            }

            if (bodyassignedToType != null)
            {
                body["assignedToType"] = CSharpExpressionConverter.Convert(bodyassignedToType);
                bodypropCount++;
            }

            if (bodyassignedToId != null)
            {
                body["assignedToId"] = CSharpExpressionConverter.ConvertToken(bodyassignedToId);
                bodypropCount++;
            }

            if (bodyrelatedToType != null)
            {
                body["relatedToType"] = CSharpExpressionConverter.Convert(bodyrelatedToType);
                bodypropCount++;
            }

            if (bodyrelatedToId != null)
            {
                body["relatedToId"] = CSharpExpressionConverter.ConvertToken(bodyrelatedToId);
                bodypropCount++;
            }

            if (bodycontactType != null)
            {
                body["contactType"] = CSharpExpressionConverter.Convert(bodycontactType);
                bodypropCount++;
            }

            if (bodycontactIds != null)
            {
                body["contactIds"] = CSharpExpressionConverter.ConvertToken(bodycontactIds);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodyeditorBody != null)
            {
                body["editorBody"] = CSharpExpressionConverter.ConvertToken(bodyeditorBody);
                bodypropCount++;
            }

            if (bodypriorityId != null)
            {
                body["priorityId"] = CSharpExpressionConverter.ConvertToken(bodypriorityId);
                bodypropCount++;
            }

            var locationObject = new JObject();
            var locationObjectpropCount = 0;
            if (bodylocationlongitude != null)
            {
                locationObject["longitude"] = CSharpExpressionConverter.ConvertToken(bodylocationlongitude);
                locationObjectpropCount++;
            }

            if (bodylocationlatitude != null)
            {
                locationObject["latitude"] = CSharpExpressionConverter.ConvertToken(bodylocationlatitude);
                locationObjectpropCount++;
            }

            if (locationObjectpropCount > 0)
            {
                body["location"] = locationObject;
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["startDate"] = CSharpExpressionConverter.ConvertToken(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["endDate"] = CSharpExpressionConverter.ConvertToken(bodyendDate);
                bodypropCount++;
            }

            if (bodyreminderSet != null)
            {
                body["reminderSet"] = CSharpExpressionConverter.ConvertToken(bodyreminderSet);
                bodypropCount++;
            }

            if (bodycreatedBy != null)
            {
                body["createdBy"] = CSharpExpressionConverter.ConvertToken(bodycreatedBy);
                bodypropCount++;
            }

            if (bodylastModifiedBy != null)
            {
                body["lastModifiedBy"] = CSharpExpressionConverter.ConvertToken(bodylastModifiedBy);
                bodypropCount++;
            }

            if (bodyposition != null)
            {
                body["position"] = CSharpExpressionConverter.ConvertToken(bodyposition);
                bodypropCount++;
            }

            if (bodyparentId != null)
            {
                body["parentId"] = CSharpExpressionConverter.ConvertToken(bodyparentId);
                bodypropCount++;
            }

            if (bodyrepeat != null)
            {
                body["repeat"] = CSharpExpressionConverter.ConvertToken(bodyrepeat);
                bodypropCount++;
            }

            if (bodyeventStatus != null)
            {
                body["eventStatus"] = CSharpExpressionConverter.Convert(bodyeventStatus);
                bodypropCount++;
            }

            if (bodyeventResultId != null)
            {
                body["eventResultId"] = CSharpExpressionConverter.ConvertToken(bodyeventResultId);
                bodypropCount++;
            }

            if (bodyrecurrenceInterval != null)
            {
                body["recurrenceInterval"] = CSharpExpressionConverter.ConvertToken(bodyrecurrenceInterval);
                bodypropCount++;
            }

            if (bodysourceId != null)
            {
                body["sourceId"] = CSharpExpressionConverter.ConvertToken(bodysourceId);
                bodypropCount++;
            }

            if (bodysourceAssignedToId != null)
            {
                body["sourceAssignedToId"] = CSharpExpressionConverter.ConvertToken(bodysourceAssignedToId);
                bodypropCount++;
            }

            if (bodysourceRelatedToId != null)
            {
                body["sourceRelatedToId"] = CSharpExpressionConverter.ConvertToken(bodysourceRelatedToId);
                bodypropCount++;
            }

            if (bodysourceContactIds != null)
            {
                body["sourceContactIds"] = CSharpExpressionConverter.ConvertToken(bodysourceContactIds);
                bodypropCount++;
            }

            if (bodyteamMembers != null)
            {
                body["teamMembers"] = CSharpExpressionConverter.ConvertToken(bodyteamMembers);
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
                callPayload.Queries["Id"] = CSharpExpressionConverter.ConvertO(id);
            if (search != null)
                callPayload.Queries["Search"] = CSharpExpressionConverter.ConvertO(search);
            if (relatedToId != null)
                callPayload.Queries["RelatedToId"] = CSharpExpressionConverter.ConvertO(relatedToId);
            if (relatedToType != null)
                callPayload.Queries["RelatedToType"] = CSharpExpressionConverter.Convert(relatedToType);
            if (createdBy != null)
                callPayload.Queries["CreatedBy"] = CSharpExpressionConverter.ConvertO(createdBy);
            if (lastModifiedBy != null)
                callPayload.Queries["LastModifiedBy"] = CSharpExpressionConverter.ConvertO(lastModifiedBy);
            if (page != null)
                callPayload.Queries["Page"] = CSharpExpressionConverter.ConvertO(page);
            if (pageSize != null)
                callPayload.Queries["PageSize"] = CSharpExpressionConverter.ConvertO(pageSize);
            if (sort != null)
                callPayload.Queries["Sort"] = CSharpExpressionConverter.ConvertO(sort);
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
                body["taskType"] = CSharpExpressionConverter.Convert(bodytaskType);
                bodypropCount++;
            }

            if (bodyrelatedToType != null)
            {
                body["relatedToType"] = CSharpExpressionConverter.Convert(bodyrelatedToType);
                bodypropCount++;
            }

            if (bodycontactType != null)
            {
                body["contactType"] = CSharpExpressionConverter.Convert(bodycontactType);
                bodypropCount++;
            }

            if (bodyrelatedToId != null)
            {
                body["relatedToId"] = CSharpExpressionConverter.ConvertToken(bodyrelatedToId);
                bodypropCount++;
            }

            bodypropCount++;
            body["subject"] = CSharpExpressionConverter.ConvertToken(bodysubject);
            if (bodybody != null)
            {
                body["body"] = CSharpExpressionConverter.ConvertToken(bodybody);
                bodypropCount++;
            }

            if (bodyeditorBody != null)
            {
                body["editorBody"] = CSharpExpressionConverter.ConvertToken(bodyeditorBody);
                bodypropCount++;
            }

            if (bodycontactIds != null)
            {
                body["contactIds"] = CSharpExpressionConverter.ConvertToken(bodycontactIds);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/task/Note/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TaskApiFeaturesNotesNoteDTO>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction NoteDelete(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/task/Note/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesNotesNoteDTO> NoteUpdate(Expression<Func<string>> id, Expression<Func<bodyrelatedToTypeInput>> bodyrelatedToType = null, Expression<Func<string>> bodyrelatedToId = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodybody = null, Expression<Func<string>> bodyeditorBody = null, Expression<Func<string>> bodylastModifiedBy = null, Expression<Func<string[]>> bodycontactIds = null, Expression<Func<bodycontactTypeInput>> bodycontactType = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/task/Note/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyrelatedToType != null)
            {
                body["relatedToType"] = CSharpExpressionConverter.Convert(bodyrelatedToType);
                bodypropCount++;
            }

            if (bodyrelatedToId != null)
            {
                body["relatedToId"] = CSharpExpressionConverter.ConvertToken(bodyrelatedToId);
                bodypropCount++;
            }

            if (bodysubject != null)
            {
                body["subject"] = CSharpExpressionConverter.ConvertToken(bodysubject);
                bodypropCount++;
            }

            if (bodybody != null)
            {
                body["body"] = CSharpExpressionConverter.ConvertToken(bodybody);
                bodypropCount++;
            }

            if (bodyeditorBody != null)
            {
                body["editorBody"] = CSharpExpressionConverter.ConvertToken(bodyeditorBody);
                bodypropCount++;
            }

            if (bodylastModifiedBy != null)
            {
                body["lastModifiedBy"] = CSharpExpressionConverter.ConvertToken(bodylastModifiedBy);
                bodypropCount++;
            }

            if (bodycontactIds != null)
            {
                body["contactIds"] = CSharpExpressionConverter.ConvertToken(bodycontactIds);
                bodypropCount++;
            }

            if (bodycontactType != null)
            {
                body["contactType"] = CSharpExpressionConverter.Convert(bodycontactType);
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
                callPayload.Queries["Id"] = CSharpExpressionConverter.ConvertO(id);
            if (status != null)
                callPayload.Queries["Status"] = CSharpExpressionConverter.Convert(status);
            if (relatedTo != null)
                callPayload.Queries["RelatedTo"] = CSharpExpressionConverter.ConvertO(relatedTo);
            if (relatedToId != null)
                callPayload.Queries["RelatedToId"] = CSharpExpressionConverter.ConvertO(relatedToId);
            if (priorityId != null)
                callPayload.Queries["PriorityId"] = CSharpExpressionConverter.ConvertO(priorityId);
            if (type != null)
                callPayload.Queries["Type"] = CSharpExpressionConverter.Convert(type);
            if (dueDate != null)
                callPayload.Queries["DueDate"] = CSharpExpressionConverter.ConvertO(dueDate);
            if (sortDate != null)
                callPayload.Queries["SortDate"] = CSharpExpressionConverter.ConvertO(sortDate);
            if (parentId != null)
                callPayload.Queries["ParentId"] = CSharpExpressionConverter.ConvertO(parentId);
            if (lastModifiedBy != null)
                callPayload.Queries["LastModifiedBy"] = CSharpExpressionConverter.ConvertO(lastModifiedBy);
            if (createdBy != null)
                callPayload.Queries["CreatedBy"] = CSharpExpressionConverter.ConvertO(createdBy);
            if (assignedToId != null)
                callPayload.Queries["AssignedToId"] = CSharpExpressionConverter.ConvertO(assignedToId);
            if (search != null)
                callPayload.Queries["Search"] = CSharpExpressionConverter.ConvertO(search);
            if (page != null)
                callPayload.Queries["Page"] = CSharpExpressionConverter.ConvertO(page);
            if (pageSize != null)
                callPayload.Queries["PageSize"] = CSharpExpressionConverter.ConvertO(pageSize);
            if (sort != null)
                callPayload.Queries["Sort"] = CSharpExpressionConverter.ConvertO(sort);
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
                body["taskType"] = CSharpExpressionConverter.Convert(bodytaskType);
                bodypropCount++;
            }

            if (bodysubject != null)
            {
                body["subject"] = CSharpExpressionConverter.ConvertToken(bodysubject);
                bodypropCount++;
            }

            if (bodydueDate != null)
            {
                body["dueDate"] = CSharpExpressionConverter.ConvertToken(bodydueDate);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = CSharpExpressionConverter.Convert(bodystatus);
                bodypropCount++;
            }

            if (bodypriorityId != null)
            {
                body["priorityId"] = CSharpExpressionConverter.ConvertToken(bodypriorityId);
                bodypropCount++;
            }

            if (bodyassignedToId != null)
            {
                body["assignedToId"] = CSharpExpressionConverter.ConvertToken(bodyassignedToId);
                bodypropCount++;
            }

            if (bodyassignedToType != null)
            {
                body["assignedToType"] = CSharpExpressionConverter.Convert(bodyassignedToType);
                bodypropCount++;
            }

            if (bodycontactIds != null)
            {
                body["contactIds"] = CSharpExpressionConverter.ConvertToken(bodycontactIds);
                bodypropCount++;
            }

            if (bodycontactType != null)
            {
                body["contactType"] = CSharpExpressionConverter.Convert(bodycontactType);
                bodypropCount++;
            }

            if (bodyrelatedToId != null)
            {
                body["relatedToId"] = CSharpExpressionConverter.ConvertToken(bodyrelatedToId);
                bodypropCount++;
            }

            if (bodyrelatedToType != null)
            {
                body["relatedToType"] = CSharpExpressionConverter.Convert(bodyrelatedToType);
                bodypropCount++;
            }

            if (bodytaskSubTypeId != null)
            {
                body["taskSubTypeId"] = CSharpExpressionConverter.ConvertToken(bodytaskSubTypeId);
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comments"] = CSharpExpressionConverter.ConvertToken(bodycomments);
                bodypropCount++;
            }

            if (bodyeditorBody != null)
            {
                body["editorBody"] = CSharpExpressionConverter.ConvertToken(bodyeditorBody);
                bodypropCount++;
            }

            if (bodyreminderSet != null)
            {
                body["reminderSet"] = CSharpExpressionConverter.ConvertToken(bodyreminderSet);
                bodypropCount++;
            }

            if (bodyposition != null)
            {
                body["position"] = CSharpExpressionConverter.ConvertToken(bodyposition);
                bodypropCount++;
            }

            if (bodyparentId != null)
            {
                body["parentId"] = CSharpExpressionConverter.ConvertToken(bodyparentId);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/Task/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TaskApiFeaturesTasksTaskDTO>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction TaskDelete(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/Task/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<TaskApiFeaturesTasksTaskDTO> TaskUpdate(Expression<Func<string>> id, Expression<Func<bodytaskTypeInput>> bodytaskType = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodycompletedDate = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodypriorityId = null, Expression<Func<string>> bodyassignedToId = null, Expression<Func<bodyassignedToTypeInput>> bodyassignedToType = null, Expression<Func<string[]>> bodycontactIds = null, Expression<Func<bodycontactTypeInput>> bodycontactType = null, Expression<Func<string>> bodyrelatedToId = null, Expression<Func<bodyrelatedToTypeInput>> bodyrelatedToType = null, Expression<Func<string>> bodytaskSubTypeId = null, Expression<Func<string>> bodycomments = null, Expression<Func<string>> bodyeditorBody = null, Expression<Func<bool>> bodyreminderSet = null, Expression<Func<int>> bodyposition = null, Expression<Func<string>> bodyparentId = null, Expression<Func<string>> bodylastModifiedBy = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/Task/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytaskType != null)
            {
                body["taskType"] = CSharpExpressionConverter.Convert(bodytaskType);
                bodypropCount++;
            }

            if (bodysubject != null)
            {
                body["subject"] = CSharpExpressionConverter.ConvertToken(bodysubject);
                bodypropCount++;
            }

            if (bodydueDate != null)
            {
                body["dueDate"] = CSharpExpressionConverter.ConvertToken(bodydueDate);
                bodypropCount++;
            }

            if (bodycompletedDate != null)
            {
                body["completedDate"] = CSharpExpressionConverter.ConvertToken(bodycompletedDate);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = CSharpExpressionConverter.Convert(bodystatus);
                bodypropCount++;
            }

            if (bodypriorityId != null)
            {
                body["priorityId"] = CSharpExpressionConverter.ConvertToken(bodypriorityId);
                bodypropCount++;
            }

            if (bodyassignedToId != null)
            {
                body["assignedToId"] = CSharpExpressionConverter.ConvertToken(bodyassignedToId);
                bodypropCount++;
            }

            if (bodyassignedToType != null)
            {
                body["assignedToType"] = CSharpExpressionConverter.Convert(bodyassignedToType);
                bodypropCount++;
            }

            if (bodycontactIds != null)
            {
                body["contactIds"] = CSharpExpressionConverter.ConvertToken(bodycontactIds);
                bodypropCount++;
            }

            if (bodycontactType != null)
            {
                body["contactType"] = CSharpExpressionConverter.Convert(bodycontactType);
                bodypropCount++;
            }

            if (bodyrelatedToId != null)
            {
                body["relatedToId"] = CSharpExpressionConverter.ConvertToken(bodyrelatedToId);
                bodypropCount++;
            }

            if (bodyrelatedToType != null)
            {
                body["relatedToType"] = CSharpExpressionConverter.Convert(bodyrelatedToType);
                bodypropCount++;
            }

            if (bodytaskSubTypeId != null)
            {
                body["taskSubTypeId"] = CSharpExpressionConverter.ConvertToken(bodytaskSubTypeId);
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comments"] = CSharpExpressionConverter.ConvertToken(bodycomments);
                bodypropCount++;
            }

            if (bodyeditorBody != null)
            {
                body["editorBody"] = CSharpExpressionConverter.ConvertToken(bodyeditorBody);
                bodypropCount++;
            }

            if (bodyreminderSet != null)
            {
                body["reminderSet"] = CSharpExpressionConverter.ConvertToken(bodyreminderSet);
                bodypropCount++;
            }

            if (bodyposition != null)
            {
                body["position"] = CSharpExpressionConverter.ConvertToken(bodyposition);
                bodypropCount++;
            }

            if (bodyparentId != null)
            {
                body["parentId"] = CSharpExpressionConverter.ConvertToken(bodyparentId);
                bodypropCount++;
            }

            if (bodylastModifiedBy != null)
            {
                body["lastModifiedBy"] = CSharpExpressionConverter.ConvertToken(bodylastModifiedBy);
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
                callPayload.Queries["Id"] = CSharpExpressionConverter.ConvertO(id);
            if (name != null)
                callPayload.Queries["Name"] = CSharpExpressionConverter.ConvertO(name);
            if (firstName != null)
                callPayload.Queries["FirstName"] = CSharpExpressionConverter.ConvertO(firstName);
            if (lastName != null)
                callPayload.Queries["LastName"] = CSharpExpressionConverter.ConvertO(lastName);
            if (insertDate != null)
                callPayload.Queries["InsertDate"] = CSharpExpressionConverter.ConvertO(insertDate);
            if (phone != null)
                callPayload.Queries["Phone"] = CSharpExpressionConverter.ConvertO(phone);
            if (mobilePhone != null)
                callPayload.Queries["MobilePhone"] = CSharpExpressionConverter.ConvertO(mobilePhone);
            if (email != null)
                callPayload.Queries["Email"] = CSharpExpressionConverter.ConvertO(email);
            if (ownerId != null)
                callPayload.Queries["OwnerId"] = CSharpExpressionConverter.ConvertO(ownerId);
            if (ownerType != null)
                callPayload.Queries["OwnerType"] = CSharpExpressionConverter.Convert(ownerType);
            if (accountSourceTypeId != null)
                callPayload.Queries["AccountSourceTypeId"] = CSharpExpressionConverter.ConvertO(accountSourceTypeId);
            if (leadStatusId != null)
                callPayload.Queries["LeadStatusId"] = CSharpExpressionConverter.ConvertO(leadStatusId);
            if (industryId != null)
                callPayload.Queries["IndustryId"] = CSharpExpressionConverter.ConvertO(industryId);
            if (status != null)
                callPayload.Queries["Status"] = CSharpExpressionConverter.ConvertO(status);
            if (search != null)
                callPayload.Queries["Search"] = CSharpExpressionConverter.ConvertO(search);
            if (page != null)
                callPayload.Queries["Page"] = CSharpExpressionConverter.ConvertO(page);
            if (pageSize != null)
                callPayload.Queries["PageSize"] = CSharpExpressionConverter.ConvertO(pageSize);
            if (sort != null)
                callPayload.Queries["Sort"] = CSharpExpressionConverter.ConvertO(sort);
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
                body["jobTitle"] = CSharpExpressionConverter.ConvertToken(bodyjobTitle);
                bodypropCount++;
            }

            if (bodyleadStatusId != null)
            {
                body["leadStatusId"] = CSharpExpressionConverter.ConvertToken(bodyleadStatusId);
                bodypropCount++;
            }

            var nameObject = new JObject();
            var nameObjectpropCount = 0;
            nameObjectpropCount++;
            nameObject["firstName"] = CSharpExpressionConverter.ConvertToken(bodynamefirstName);
            if (bodynamelastName != null)
            {
                nameObject["lastName"] = CSharpExpressionConverter.ConvertToken(bodynamelastName);
                nameObjectpropCount++;
            }

            if (bodynamemiddleName != null)
            {
                nameObject["middleName"] = CSharpExpressionConverter.ConvertToken(bodynamemiddleName);
                nameObjectpropCount++;
            }

            if (bodynamesalutationId != null)
            {
                nameObject["salutationId"] = CSharpExpressionConverter.ConvertToken(bodynamesalutationId);
                nameObjectpropCount++;
            }

            if (bodynamesuffix != null)
            {
                nameObject["suffix"] = CSharpExpressionConverter.ConvertToken(bodynamesuffix);
                nameObjectpropCount++;
            }

            if (nameObjectpropCount > 0)
            {
                body["name"] = nameObject;
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
            }

            if (bodyphone != null)
            {
                body["phone"] = CSharpExpressionConverter.ConvertToken(bodyphone);
                bodypropCount++;
            }

            if (bodymobilePhone != null)
            {
                body["mobilePhone"] = CSharpExpressionConverter.ConvertToken(bodymobilePhone);
                bodypropCount++;
            }

            if (bodyotherEmail != null)
            {
                body["otherEmail"] = CSharpExpressionConverter.ConvertToken(bodyotherEmail);
                bodypropCount++;
            }

            if (bodyotherPhone != null)
            {
                body["otherPhone"] = CSharpExpressionConverter.ConvertToken(bodyotherPhone);
                bodypropCount++;
            }

            if (bodycallOptOut != null)
            {
                body["callOptOut"] = CSharpExpressionConverter.ConvertToken(bodycallOptOut);
                bodypropCount++;
            }

            if (bodyemailOptOut != null)
            {
                body["emailOptOut"] = CSharpExpressionConverter.ConvertToken(bodyemailOptOut);
                bodypropCount++;
            }

            if (bodyratingId != null)
            {
                body["ratingId"] = CSharpExpressionConverter.ConvertToken(bodyratingId);
                bodypropCount++;
            }

            if (bodyownerId != null)
            {
                body["ownerId"] = CSharpExpressionConverter.ConvertToken(bodyownerId);
                bodypropCount++;
            }

            if (bodyownerType != null)
            {
                body["ownerType"] = CSharpExpressionConverter.Convert(bodyownerType);
                bodypropCount++;
            }

            if (bodywebsite != null)
            {
                body["website"] = CSharpExpressionConverter.ConvertToken(bodywebsite);
                bodypropCount++;
            }

            if (bodycompany != null)
            {
                body["company"] = CSharpExpressionConverter.ConvertToken(bodycompany);
                bodypropCount++;
            }

            if (bodyindustryId != null)
            {
                body["industryId"] = CSharpExpressionConverter.ConvertToken(bodyindustryId);
                bodypropCount++;
            }

            if (bodynoOfEmployees != null)
            {
                body["noOfEmployees"] = CSharpExpressionConverter.ConvertToken(bodynoOfEmployees);
                bodypropCount++;
            }

            if (bodyaccountSourceTypeId != null)
            {
                body["accountSourceTypeId"] = CSharpExpressionConverter.ConvertToken(bodyaccountSourceTypeId);
                bodypropCount++;
            }

            var addressObject = new JObject();
            var addressObjectpropCount = 0;
            if (bodyaddressaddress1 != null)
            {
                addressObject["address1"] = CSharpExpressionConverter.ConvertToken(bodyaddressaddress1);
                addressObjectpropCount++;
            }

            if (bodyaddressaddress2 != null)
            {
                addressObject["address2"] = CSharpExpressionConverter.ConvertToken(bodyaddressaddress2);
                addressObjectpropCount++;
            }

            if (bodyaddresscity != null)
            {
                addressObject["city"] = CSharpExpressionConverter.ConvertToken(bodyaddresscity);
                addressObjectpropCount++;
            }

            if (bodyaddressstate != null)
            {
                addressObject["state"] = CSharpExpressionConverter.ConvertToken(bodyaddressstate);
                addressObjectpropCount++;
            }

            if (bodyaddresscountry != null)
            {
                addressObject["country"] = CSharpExpressionConverter.ConvertToken(bodyaddresscountry);
                addressObjectpropCount++;
            }

            if (bodyaddresspostalCode != null)
            {
                addressObject["postalCode"] = CSharpExpressionConverter.ConvertToken(bodyaddresspostalCode);
                addressObjectpropCount++;
            }

            if (addressObjectpropCount > 0)
            {
                body["address"] = addressObject;
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodyannualRevenue != null)
            {
                body["annualRevenue"] = CSharpExpressionConverter.ConvertToken(bodyannualRevenue);
                bodypropCount++;
            }

            if (bodylastTransferDate != null)
            {
                body["lastTransferDate"] = CSharpExpressionConverter.ConvertToken(bodylastTransferDate);
                bodypropCount++;
            }

            if (bodygenderId != null)
            {
                body["genderId"] = CSharpExpressionConverter.ConvertToken(bodygenderId);
                bodypropCount++;
            }

            if (bodypronounceId != null)
            {
                body["pronounceId"] = CSharpExpressionConverter.ConvertToken(bodypronounceId);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = CSharpExpressionConverter.Convert(bodystatus);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/Lead/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SalesPipelineApiFeaturesLeadLeadDto>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction LeadDelete(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/Lead/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesLeadLeadDto> LeadUpdate(Expression<Func<string>> id, Expression<Func<string>> bodynamefirstName, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodyleadStatusId = null, Expression<Func<string>> bodynamelastName = null, Expression<Func<string>> bodynamemiddleName = null, Expression<Func<string>> bodynamesalutationId = null, Expression<Func<string>> bodynamesuffix = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodymobilePhone = null, Expression<Func<SalesPipelineApiDTOsEmailDTO[]>> bodyotherEmail = null, Expression<Func<SalesPipelineApiDTOsPhoneDTO[]>> bodyotherPhone = null, Expression<Func<bool>> bodycallOptOut = null, Expression<Func<bool>> bodyemailOptOut = null, Expression<Func<string>> bodyratingId = null, Expression<Func<string>> bodyownerId = null, Expression<Func<bodyownerTypeInput>> bodyownerType = null, Expression<Func<string>> bodywebsite = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodyindustryId = null, Expression<Func<int>> bodynoOfEmployees = null, Expression<Func<string>> bodyaccountSourceTypeId = null, Expression<Func<string>> bodyaddressaddress1 = null, Expression<Func<string>> bodyaddressaddress2 = null, Expression<Func<string>> bodyaddresscity = null, Expression<Func<string>> bodyaddressstate = null, Expression<Func<string>> bodyaddresscountry = null, Expression<Func<string>> bodyaddresspostalCode = null, Expression<Func<string>> bodydescription = null, Expression<Func<double>> bodyannualRevenue = null, Expression<Func<string>> bodylastTransferDate = null, Expression<Func<string>> bodygenderId = null, Expression<Func<string>> bodypronounceId = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodylastModifiedBy = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/Lead/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyjobTitle != null)
            {
                body["jobTitle"] = CSharpExpressionConverter.ConvertToken(bodyjobTitle);
                bodypropCount++;
            }

            if (bodyleadStatusId != null)
            {
                body["leadStatusId"] = CSharpExpressionConverter.ConvertToken(bodyleadStatusId);
                bodypropCount++;
            }

            var nameObject = new JObject();
            var nameObjectpropCount = 0;
            nameObjectpropCount++;
            nameObject["firstName"] = CSharpExpressionConverter.ConvertToken(bodynamefirstName);
            if (bodynamelastName != null)
            {
                nameObject["lastName"] = CSharpExpressionConverter.ConvertToken(bodynamelastName);
                nameObjectpropCount++;
            }

            if (bodynamemiddleName != null)
            {
                nameObject["middleName"] = CSharpExpressionConverter.ConvertToken(bodynamemiddleName);
                nameObjectpropCount++;
            }

            if (bodynamesalutationId != null)
            {
                nameObject["salutationId"] = CSharpExpressionConverter.ConvertToken(bodynamesalutationId);
                nameObjectpropCount++;
            }

            if (bodynamesuffix != null)
            {
                nameObject["suffix"] = CSharpExpressionConverter.ConvertToken(bodynamesuffix);
                nameObjectpropCount++;
            }

            if (nameObjectpropCount > 0)
            {
                body["name"] = nameObject;
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
            }

            if (bodyphone != null)
            {
                body["phone"] = CSharpExpressionConverter.ConvertToken(bodyphone);
                bodypropCount++;
            }

            if (bodymobilePhone != null)
            {
                body["mobilePhone"] = CSharpExpressionConverter.ConvertToken(bodymobilePhone);
                bodypropCount++;
            }

            if (bodyotherEmail != null)
            {
                body["otherEmail"] = CSharpExpressionConverter.ConvertToken(bodyotherEmail);
                bodypropCount++;
            }

            if (bodyotherPhone != null)
            {
                body["otherPhone"] = CSharpExpressionConverter.ConvertToken(bodyotherPhone);
                bodypropCount++;
            }

            if (bodycallOptOut != null)
            {
                body["callOptOut"] = CSharpExpressionConverter.ConvertToken(bodycallOptOut);
                bodypropCount++;
            }

            if (bodyemailOptOut != null)
            {
                body["emailOptOut"] = CSharpExpressionConverter.ConvertToken(bodyemailOptOut);
                bodypropCount++;
            }

            if (bodyratingId != null)
            {
                body["ratingId"] = CSharpExpressionConverter.ConvertToken(bodyratingId);
                bodypropCount++;
            }

            if (bodyownerId != null)
            {
                body["ownerId"] = CSharpExpressionConverter.ConvertToken(bodyownerId);
                bodypropCount++;
            }

            if (bodyownerType != null)
            {
                body["ownerType"] = CSharpExpressionConverter.Convert(bodyownerType);
                bodypropCount++;
            }

            if (bodywebsite != null)
            {
                body["website"] = CSharpExpressionConverter.ConvertToken(bodywebsite);
                bodypropCount++;
            }

            if (bodycompany != null)
            {
                body["company"] = CSharpExpressionConverter.ConvertToken(bodycompany);
                bodypropCount++;
            }

            if (bodyindustryId != null)
            {
                body["industryId"] = CSharpExpressionConverter.ConvertToken(bodyindustryId);
                bodypropCount++;
            }

            if (bodynoOfEmployees != null)
            {
                body["noOfEmployees"] = CSharpExpressionConverter.ConvertToken(bodynoOfEmployees);
                bodypropCount++;
            }

            if (bodyaccountSourceTypeId != null)
            {
                body["accountSourceTypeId"] = CSharpExpressionConverter.ConvertToken(bodyaccountSourceTypeId);
                bodypropCount++;
            }

            var addressObject = new JObject();
            var addressObjectpropCount = 0;
            if (bodyaddressaddress1 != null)
            {
                addressObject["address1"] = CSharpExpressionConverter.ConvertToken(bodyaddressaddress1);
                addressObjectpropCount++;
            }

            if (bodyaddressaddress2 != null)
            {
                addressObject["address2"] = CSharpExpressionConverter.ConvertToken(bodyaddressaddress2);
                addressObjectpropCount++;
            }

            if (bodyaddresscity != null)
            {
                addressObject["city"] = CSharpExpressionConverter.ConvertToken(bodyaddresscity);
                addressObjectpropCount++;
            }

            if (bodyaddressstate != null)
            {
                addressObject["state"] = CSharpExpressionConverter.ConvertToken(bodyaddressstate);
                addressObjectpropCount++;
            }

            if (bodyaddresscountry != null)
            {
                addressObject["country"] = CSharpExpressionConverter.ConvertToken(bodyaddresscountry);
                addressObjectpropCount++;
            }

            if (bodyaddresspostalCode != null)
            {
                addressObject["postalCode"] = CSharpExpressionConverter.ConvertToken(bodyaddresspostalCode);
                addressObjectpropCount++;
            }

            if (addressObjectpropCount > 0)
            {
                body["address"] = addressObject;
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodyannualRevenue != null)
            {
                body["annualRevenue"] = CSharpExpressionConverter.ConvertToken(bodyannualRevenue);
                bodypropCount++;
            }

            if (bodylastTransferDate != null)
            {
                body["lastTransferDate"] = CSharpExpressionConverter.ConvertToken(bodylastTransferDate);
                bodypropCount++;
            }

            if (bodygenderId != null)
            {
                body["genderId"] = CSharpExpressionConverter.ConvertToken(bodygenderId);
                bodypropCount++;
            }

            if (bodypronounceId != null)
            {
                body["pronounceId"] = CSharpExpressionConverter.ConvertToken(bodypronounceId);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = CSharpExpressionConverter.Convert(bodystatus);
                bodypropCount++;
            }

            if (bodylastModifiedBy != null)
            {
                body["lastModifiedBy"] = CSharpExpressionConverter.ConvertToken(bodylastModifiedBy);
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
                callPayload.Queries["Id"] = CSharpExpressionConverter.ConvertO(id);
            if (ownerId != null)
                callPayload.Queries["OwnerId"] = CSharpExpressionConverter.ConvertO(ownerId);
            if (name != null)
                callPayload.Queries["Name"] = CSharpExpressionConverter.ConvertO(name);
            if (amount != null)
                callPayload.Queries["Amount"] = CSharpExpressionConverter.ConvertO(amount);
            if (closeDate != null)
                callPayload.Queries["CloseDate"] = CSharpExpressionConverter.ConvertO(closeDate);
            if (updateDate != null)
                callPayload.Queries["UpdateDate"] = CSharpExpressionConverter.ConvertO(updateDate);
            if (insertDate != null)
                callPayload.Queries["InsertDate"] = CSharpExpressionConverter.ConvertO(insertDate);
            if (accountId != null)
                callPayload.Queries["AccountId"] = CSharpExpressionConverter.ConvertO(accountId);
            if (forecastCategoryId != null)
                callPayload.Queries["ForecastCategoryId"] = CSharpExpressionConverter.ConvertO(forecastCategoryId);
            if (accountSourceTypeId != null)
                callPayload.Queries["AccountSourceTypeId"] = CSharpExpressionConverter.ConvertO(accountSourceTypeId);
            if (opportunityStatusId != null)
                callPayload.Queries["OpportunityStatusId"] = CSharpExpressionConverter.ConvertO(opportunityStatusId);
            if (quoteId != null)
                callPayload.Queries["QuoteId"] = CSharpExpressionConverter.ConvertO(quoteId);
            if (lossReasonId != null)
                callPayload.Queries["LossReasonId"] = CSharpExpressionConverter.ConvertO(lossReasonId);
            if (typeId != null)
                callPayload.Queries["TypeId"] = CSharpExpressionConverter.ConvertO(typeId);
            if (lastModifiedBy != null)
                callPayload.Queries["LastModifiedBy"] = CSharpExpressionConverter.ConvertO(lastModifiedBy);
            if (createdBy != null)
                callPayload.Queries["CreatedBy"] = CSharpExpressionConverter.ConvertO(createdBy);
            if (search != null)
                callPayload.Queries["Search"] = CSharpExpressionConverter.ConvertO(search);
            if (salesPipelineId != null)
                callPayload.Queries["SalesPipelineId"] = CSharpExpressionConverter.ConvertO(salesPipelineId);
            if (status != null)
                callPayload.Queries["Status"] = CSharpExpressionConverter.ConvertO(status);
            if (page != null)
                callPayload.Queries["Page"] = CSharpExpressionConverter.ConvertO(page);
            if (pageSize != null)
                callPayload.Queries["PageSize"] = CSharpExpressionConverter.ConvertO(pageSize);
            if (sort != null)
                callPayload.Queries["Sort"] = CSharpExpressionConverter.ConvertO(sort);
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
                body["typeId"] = CSharpExpressionConverter.ConvertToken(bodytypeId);
                bodypropCount++;
            }

            if (bodyownerId != null)
            {
                body["ownerId"] = CSharpExpressionConverter.ConvertToken(bodyownerId);
                bodypropCount++;
            }

            if (bodyaccountId != null)
            {
                body["accountId"] = CSharpExpressionConverter.ConvertToken(bodyaccountId);
                bodypropCount++;
            }

            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            if (bodyamount != null)
            {
                body["amount"] = CSharpExpressionConverter.ConvertToken(bodyamount);
                bodypropCount++;
            }

            if (bodyforecastCategoryId != null)
            {
                body["forecastCategoryId"] = CSharpExpressionConverter.ConvertToken(bodyforecastCategoryId);
                bodypropCount++;
            }

            if (bodysalesPipelineId != null)
            {
                body["salesPipelineId"] = CSharpExpressionConverter.ConvertToken(bodysalesPipelineId);
                bodypropCount++;
            }

            bodypropCount++;
            body["closeDate"] = CSharpExpressionConverter.ConvertToken(bodycloseDate);
            if (bodyprobability != null)
            {
                body["probability"] = CSharpExpressionConverter.ConvertToken(bodyprobability);
                bodypropCount++;
            }

            if (bodyscore != null)
            {
                body["score"] = CSharpExpressionConverter.ConvertToken(bodyscore);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodyquoteId != null)
            {
                body["quoteId"] = CSharpExpressionConverter.ConvertToken(bodyquoteId);
                bodypropCount++;
            }

            if (bodyopportunityStatusId != null)
            {
                body["opportunityStatusId"] = CSharpExpressionConverter.ConvertToken(bodyopportunityStatusId);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = CSharpExpressionConverter.Convert(bodystatus);
                bodypropCount++;
            }

            if (bodyaccountSourceTypeId != null)
            {
                body["accountSourceTypeId"] = CSharpExpressionConverter.ConvertToken(bodyaccountSourceTypeId);
                bodypropCount++;
            }

            if (bodynextStep != null)
            {
                body["nextStep"] = CSharpExpressionConverter.ConvertToken(bodynextStep);
                bodypropCount++;
            }

            if (bodybudgetConfirmed != null)
            {
                body["budgetConfirmed"] = CSharpExpressionConverter.ConvertToken(bodybudgetConfirmed);
                bodypropCount++;
            }

            if (bodydiscoveryCompleted != null)
            {
                body["discoveryCompleted"] = CSharpExpressionConverter.ConvertToken(bodydiscoveryCompleted);
                bodypropCount++;
            }

            if (bodyexpectedRevenue != null)
            {
                body["expectedRevenue"] = CSharpExpressionConverter.ConvertToken(bodyexpectedRevenue);
                bodypropCount++;
            }

            if (bodylossReasonId != null)
            {
                body["lossReasonId"] = CSharpExpressionConverter.ConvertToken(bodylossReasonId);
                bodypropCount++;
            }

            if (bodyprivate != null)
            {
                body["private"] = CSharpExpressionConverter.ConvertToken(bodyprivate);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/Opportunity/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction OpportunityDelete(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/Opportunity/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<SalesPipelineApiFeaturesOpportunityOpportunityDTO> OpportunityUpdate(Expression<Func<string>> id, Expression<Func<string>> bodytypeId = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string>> bodyaccountId = null, Expression<Func<string>> bodyname = null, Expression<Func<double>> bodyamount = null, Expression<Func<string>> bodyforecastCategoryId = null, Expression<Func<string>> bodycloseDate = null, Expression<Func<int>> bodyprobability = null, Expression<Func<int>> bodyscore = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodysalesPipelineId = null, Expression<Func<string>> bodyquoteId = null, Expression<Func<string>> bodyopportunityStatusId = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodyaccountSourceTypeId = null, Expression<Func<string>> bodynextStep = null, Expression<Func<bool>> bodybudgetConfirmed = null, Expression<Func<bool>> bodydiscoveryCompleted = null, Expression<Func<double>> bodyexpectedRevenue = null, Expression<Func<string>> bodylossReasonId = null, Expression<Func<bool>> bodyprivate = null, Expression<Func<string>> bodylastModifiedBy = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/Opportunity/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytypeId != null)
            {
                body["typeId"] = CSharpExpressionConverter.ConvertToken(bodytypeId);
                bodypropCount++;
            }

            if (bodyownerId != null)
            {
                body["ownerId"] = CSharpExpressionConverter.ConvertToken(bodyownerId);
                bodypropCount++;
            }

            if (bodyaccountId != null)
            {
                body["accountId"] = CSharpExpressionConverter.ConvertToken(bodyaccountId);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
            }

            if (bodyamount != null)
            {
                body["amount"] = CSharpExpressionConverter.ConvertToken(bodyamount);
                bodypropCount++;
            }

            if (bodyforecastCategoryId != null)
            {
                body["forecastCategoryId"] = CSharpExpressionConverter.ConvertToken(bodyforecastCategoryId);
                bodypropCount++;
            }

            if (bodycloseDate != null)
            {
                body["closeDate"] = CSharpExpressionConverter.ConvertToken(bodycloseDate);
                bodypropCount++;
            }

            if (bodyprobability != null)
            {
                body["probability"] = CSharpExpressionConverter.ConvertToken(bodyprobability);
                bodypropCount++;
            }

            if (bodyscore != null)
            {
                body["score"] = CSharpExpressionConverter.ConvertToken(bodyscore);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodysalesPipelineId != null)
            {
                body["salesPipelineId"] = CSharpExpressionConverter.ConvertToken(bodysalesPipelineId);
                bodypropCount++;
            }

            if (bodyquoteId != null)
            {
                body["quoteId"] = CSharpExpressionConverter.ConvertToken(bodyquoteId);
                bodypropCount++;
            }

            if (bodyopportunityStatusId != null)
            {
                body["opportunityStatusId"] = CSharpExpressionConverter.ConvertToken(bodyopportunityStatusId);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = CSharpExpressionConverter.Convert(bodystatus);
                bodypropCount++;
            }

            if (bodyaccountSourceTypeId != null)
            {
                body["accountSourceTypeId"] = CSharpExpressionConverter.ConvertToken(bodyaccountSourceTypeId);
                bodypropCount++;
            }

            if (bodynextStep != null)
            {
                body["nextStep"] = CSharpExpressionConverter.ConvertToken(bodynextStep);
                bodypropCount++;
            }

            if (bodybudgetConfirmed != null)
            {
                body["budgetConfirmed"] = CSharpExpressionConverter.ConvertToken(bodybudgetConfirmed);
                bodypropCount++;
            }

            if (bodydiscoveryCompleted != null)
            {
                body["discoveryCompleted"] = CSharpExpressionConverter.ConvertToken(bodydiscoveryCompleted);
                bodypropCount++;
            }

            if (bodyexpectedRevenue != null)
            {
                body["expectedRevenue"] = CSharpExpressionConverter.ConvertToken(bodyexpectedRevenue);
                bodypropCount++;
            }

            if (bodylossReasonId != null)
            {
                body["lossReasonId"] = CSharpExpressionConverter.ConvertToken(bodylossReasonId);
                bodypropCount++;
            }

            if (bodyprivate != null)
            {
                body["private"] = CSharpExpressionConverter.ConvertToken(bodyprivate);
                bodypropCount++;
            }

            if (bodylastModifiedBy != null)
            {
                body["lastModifiedBy"] = CSharpExpressionConverter.ConvertToken(bodylastModifiedBy);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/users/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IdentityApiBackOfficeUsersGetUserGetUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<IdentityApiTeamsDtosGetTeamResponse> TeamGetById(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/teams/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IdentityApiTeamsDtosGetTeamResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<CustomerApiFeaturesAccountsAccountDTO> AccountGetById(Expression<Func<string>> accountId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/Account/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CustomerApiFeaturesAccountsAccountDTO>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction AccountDelete(Expression<Func<string>> accountId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/Account/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<CustomerApiFeaturesAccountsAccountDTO> AccountUpdate(Expression<Func<string>> accountId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodytin = null, Expression<Func<string>> bodycode = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodysourceId = null, Expression<Func<string>> bodysourceParentId = null, Expression<Func<string>> bodysourceOwnerId = null, Expression<Func<string[]>> bodyprimaryContactIds = null, Expression<Func<string>> bodyparentAccountId = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string>> bodyaddressaddress1 = null, Expression<Func<string>> bodyaddressaddress2 = null, Expression<Func<string>> bodyaddresscity = null, Expression<Func<string>> bodyaddressstate = null, Expression<Func<string>> bodyaddresslatitude = null, Expression<Func<string>> bodyaddresslongtitude = null, Expression<Func<string>> bodyaddresscountry = null, Expression<Func<string>> bodyaddresscountryCode = null, Expression<Func<string>> bodyaddresspostalCode = null, Expression<Func<string>> bodyaddressfirstName = null, Expression<Func<string>> bodyaddresslastName = null, Expression<Func<string>> bodyaddressphoneNumber = null, Expression<Func<string>> bodyaddressemail = null, Expression<Func<string>> bodyaccountSourceTypeId = null, Expression<Func<string>> bodyindustryId = null, Expression<Func<string>> bodytierId = null, Expression<Func<string>> bodywebsite = null, Expression<Func<string>> bodyaccountDescription = null, Expression<Func<int>> bodynoOfEmployees = null, Expression<Func<double>> bodyannualRevenue = null, Expression<Func<string>> bodycreatedBy = null, Expression<Func<string>> bodylastModifiedBy = null, Expression<Func<string>> bodyfax = null, Expression<Func<string>> bodyownershipId = null, Expression<Func<string>> bodyratingId = null, Expression<Func<string>> bodyclassificationId = null, Expression<Func<string[]>> bodyassignedTeams = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/Account/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
            }

            if (bodyphone != null)
            {
                body["phone"] = CSharpExpressionConverter.ConvertToken(bodyphone);
                bodypropCount++;
            }

            if (bodytin != null)
            {
                body["tin"] = CSharpExpressionConverter.ConvertToken(bodytin);
                bodypropCount++;
            }

            if (bodycode != null)
            {
                body["code"] = CSharpExpressionConverter.ConvertToken(bodycode);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
            }

            if (bodysourceId != null)
            {
                body["sourceId"] = CSharpExpressionConverter.ConvertToken(bodysourceId);
                bodypropCount++;
            }

            if (bodysourceParentId != null)
            {
                body["sourceParentId"] = CSharpExpressionConverter.ConvertToken(bodysourceParentId);
                bodypropCount++;
            }

            if (bodysourceOwnerId != null)
            {
                body["sourceOwnerId"] = CSharpExpressionConverter.ConvertToken(bodysourceOwnerId);
                bodypropCount++;
            }

            if (bodyprimaryContactIds != null)
            {
                body["primaryContactIds"] = CSharpExpressionConverter.ConvertToken(bodyprimaryContactIds);
                bodypropCount++;
            }

            if (bodyparentAccountId != null)
            {
                body["parentAccountId"] = CSharpExpressionConverter.ConvertToken(bodyparentAccountId);
                bodypropCount++;
            }

            if (bodyownerId != null)
            {
                body["ownerId"] = CSharpExpressionConverter.ConvertToken(bodyownerId);
                bodypropCount++;
            }

            var addressObject = new JObject();
            var addressObjectpropCount = 0;
            if (bodyaddressaddress1 != null)
            {
                addressObject["address1"] = CSharpExpressionConverter.ConvertToken(bodyaddressaddress1);
                addressObjectpropCount++;
            }

            if (bodyaddressaddress2 != null)
            {
                addressObject["address2"] = CSharpExpressionConverter.ConvertToken(bodyaddressaddress2);
                addressObjectpropCount++;
            }

            if (bodyaddresscity != null)
            {
                addressObject["city"] = CSharpExpressionConverter.ConvertToken(bodyaddresscity);
                addressObjectpropCount++;
            }

            if (bodyaddressstate != null)
            {
                addressObject["state"] = CSharpExpressionConverter.ConvertToken(bodyaddressstate);
                addressObjectpropCount++;
            }

            if (bodyaddresslatitude != null)
            {
                addressObject["latitude"] = CSharpExpressionConverter.ConvertToken(bodyaddresslatitude);
                addressObjectpropCount++;
            }

            if (bodyaddresslongtitude != null)
            {
                addressObject["longtitude"] = CSharpExpressionConverter.ConvertToken(bodyaddresslongtitude);
                addressObjectpropCount++;
            }

            if (bodyaddresscountry != null)
            {
                addressObject["country"] = CSharpExpressionConverter.ConvertToken(bodyaddresscountry);
                addressObjectpropCount++;
            }

            if (bodyaddresscountryCode != null)
            {
                addressObject["countryCode"] = CSharpExpressionConverter.ConvertToken(bodyaddresscountryCode);
                addressObjectpropCount++;
            }

            if (bodyaddresspostalCode != null)
            {
                addressObject["postalCode"] = CSharpExpressionConverter.ConvertToken(bodyaddresspostalCode);
                addressObjectpropCount++;
            }

            if (bodyaddressfirstName != null)
            {
                addressObject["firstName"] = CSharpExpressionConverter.ConvertToken(bodyaddressfirstName);
                addressObjectpropCount++;
            }

            if (bodyaddresslastName != null)
            {
                addressObject["lastName"] = CSharpExpressionConverter.ConvertToken(bodyaddresslastName);
                addressObjectpropCount++;
            }

            if (bodyaddressphoneNumber != null)
            {
                addressObject["phoneNumber"] = CSharpExpressionConverter.ConvertToken(bodyaddressphoneNumber);
                addressObjectpropCount++;
            }

            if (bodyaddressemail != null)
            {
                addressObject["email"] = CSharpExpressionConverter.ConvertToken(bodyaddressemail);
                addressObjectpropCount++;
            }

            if (addressObjectpropCount > 0)
            {
                body["address"] = addressObject;
                bodypropCount++;
            }

            if (bodyaccountSourceTypeId != null)
            {
                body["accountSourceTypeId"] = CSharpExpressionConverter.ConvertToken(bodyaccountSourceTypeId);
                bodypropCount++;
            }

            if (bodyindustryId != null)
            {
                body["industryId"] = CSharpExpressionConverter.ConvertToken(bodyindustryId);
                bodypropCount++;
            }

            if (bodytierId != null)
            {
                body["tierId"] = CSharpExpressionConverter.ConvertToken(bodytierId);
                bodypropCount++;
            }

            if (bodywebsite != null)
            {
                body["website"] = CSharpExpressionConverter.ConvertToken(bodywebsite);
                bodypropCount++;
            }

            if (bodyaccountDescription != null)
            {
                body["accountDescription"] = CSharpExpressionConverter.ConvertToken(bodyaccountDescription);
                bodypropCount++;
            }

            if (bodynoOfEmployees != null)
            {
                body["noOfEmployees"] = CSharpExpressionConverter.ConvertToken(bodynoOfEmployees);
                bodypropCount++;
            }

            if (bodyannualRevenue != null)
            {
                body["annualRevenue"] = CSharpExpressionConverter.ConvertToken(bodyannualRevenue);
                bodypropCount++;
            }

            if (bodycreatedBy != null)
            {
                body["createdBy"] = CSharpExpressionConverter.ConvertToken(bodycreatedBy);
                bodypropCount++;
            }

            if (bodylastModifiedBy != null)
            {
                body["lastModifiedBy"] = CSharpExpressionConverter.ConvertToken(bodylastModifiedBy);
                bodypropCount++;
            }

            if (bodyfax != null)
            {
                body["fax"] = CSharpExpressionConverter.ConvertToken(bodyfax);
                bodypropCount++;
            }

            if (bodyownershipId != null)
            {
                body["ownershipId"] = CSharpExpressionConverter.ConvertToken(bodyownershipId);
                bodypropCount++;
            }

            if (bodyratingId != null)
            {
                body["ratingId"] = CSharpExpressionConverter.ConvertToken(bodyratingId);
                bodypropCount++;
            }

            if (bodyclassificationId != null)
            {
                body["classificationId"] = CSharpExpressionConverter.ConvertToken(bodyclassificationId);
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
                body["assignedTeams"] = CSharpExpressionConverter.ConvertToken(bodyassignedTeams);
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
                callPayload.Queries["ParentAccount"] = CSharpExpressionConverter.ConvertO(parentAccount);
            if (phone != null)
                callPayload.Queries["Phone"] = CSharpExpressionConverter.ConvertO(phone);
            if (suggestions != null)
                callPayload.Queries["Suggestions"] = CSharpExpressionConverter.ConvertO(suggestions);
            if (ownerId != null)
                callPayload.Queries["OwnerId"] = CSharpExpressionConverter.ConvertO(ownerId);
            if (ownershipId != null)
                callPayload.Queries["OwnershipId"] = CSharpExpressionConverter.ConvertO(ownershipId);
            if (ratingId != null)
                callPayload.Queries["RatingId"] = CSharpExpressionConverter.ConvertO(ratingId);
            if (classificationId != null)
                callPayload.Queries["ClassificationId"] = CSharpExpressionConverter.ConvertO(classificationId);
            if (industryId != null)
                callPayload.Queries["IndustryId"] = CSharpExpressionConverter.ConvertO(industryId);
            if (accountSourceTypeId != null)
                callPayload.Queries["AccountSourceTypeId"] = CSharpExpressionConverter.ConvertO(accountSourceTypeId);
            if (primaryContactId != null)
                callPayload.Queries["PrimaryContactId"] = CSharpExpressionConverter.ConvertO(primaryContactId);
            if (assignedTeams != null)
                callPayload.Queries["AssignedTeams"] = CSharpExpressionConverter.ConvertO(assignedTeams);
            if (search != null)
                callPayload.Queries["Search"] = CSharpExpressionConverter.ConvertO(search);
            if (name != null)
                callPayload.Queries["Name"] = CSharpExpressionConverter.ConvertO(name);
            if (id != null)
                callPayload.Queries["Id"] = CSharpExpressionConverter.ConvertO(id);
            if (page != null)
                callPayload.Queries["Page"] = CSharpExpressionConverter.ConvertO(page);
            if (pageSize != null)
                callPayload.Queries["PageSize"] = CSharpExpressionConverter.ConvertO(pageSize);
            if (sort != null)
                callPayload.Queries["Sort"] = CSharpExpressionConverter.ConvertO(sort);
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
                body["id"] = CSharpExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
            }

            if (bodycompanyId != null)
            {
                body["companyId"] = CSharpExpressionConverter.ConvertToken(bodycompanyId);
                bodypropCount++;
            }

            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            if (bodycode != null)
            {
                body["code"] = CSharpExpressionConverter.ConvertToken(bodycode);
                bodypropCount++;
            }

            if (bodytin != null)
            {
                body["tin"] = CSharpExpressionConverter.ConvertToken(bodytin);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
            }

            if (bodyphone != null)
            {
                body["phone"] = CSharpExpressionConverter.ConvertToken(bodyphone);
                bodypropCount++;
            }

            if (bodysourceId != null)
            {
                body["sourceId"] = CSharpExpressionConverter.ConvertToken(bodysourceId);
                bodypropCount++;
            }

            if (bodysourceParentId != null)
            {
                body["sourceParentId"] = CSharpExpressionConverter.ConvertToken(bodysourceParentId);
                bodypropCount++;
            }

            if (bodysourceOwnerId != null)
            {
                body["sourceOwnerId"] = CSharpExpressionConverter.ConvertToken(bodysourceOwnerId);
                bodypropCount++;
            }

            if (bodyprimaryContactIds != null)
            {
                body["primaryContactIds"] = CSharpExpressionConverter.ConvertToken(bodyprimaryContactIds);
                bodypropCount++;
            }

            if (bodyparentAccountId != null)
            {
                body["parentAccountId"] = CSharpExpressionConverter.ConvertToken(bodyparentAccountId);
                bodypropCount++;
            }

            if (bodyownerId != null)
            {
                body["ownerId"] = CSharpExpressionConverter.ConvertToken(bodyownerId);
                bodypropCount++;
            }

            var addressObject = new JObject();
            var addressObjectpropCount = 0;
            if (bodyaddressaddress1 != null)
            {
                addressObject["address1"] = CSharpExpressionConverter.ConvertToken(bodyaddressaddress1);
                addressObjectpropCount++;
            }

            if (bodyaddressaddress2 != null)
            {
                addressObject["address2"] = CSharpExpressionConverter.ConvertToken(bodyaddressaddress2);
                addressObjectpropCount++;
            }

            if (bodyaddresscity != null)
            {
                addressObject["city"] = CSharpExpressionConverter.ConvertToken(bodyaddresscity);
                addressObjectpropCount++;
            }

            if (bodyaddressstate != null)
            {
                addressObject["state"] = CSharpExpressionConverter.ConvertToken(bodyaddressstate);
                addressObjectpropCount++;
            }

            if (bodyaddresslatitude != null)
            {
                addressObject["latitude"] = CSharpExpressionConverter.ConvertToken(bodyaddresslatitude);
                addressObjectpropCount++;
            }

            if (bodyaddresslongtitude != null)
            {
                addressObject["longtitude"] = CSharpExpressionConverter.ConvertToken(bodyaddresslongtitude);
                addressObjectpropCount++;
            }

            if (bodyaddresscountry != null)
            {
                addressObject["country"] = CSharpExpressionConverter.ConvertToken(bodyaddresscountry);
                addressObjectpropCount++;
            }

            if (bodyaddresscountryCode != null)
            {
                addressObject["countryCode"] = CSharpExpressionConverter.ConvertToken(bodyaddresscountryCode);
                addressObjectpropCount++;
            }

            if (bodyaddresspostalCode != null)
            {
                addressObject["postalCode"] = CSharpExpressionConverter.ConvertToken(bodyaddresspostalCode);
                addressObjectpropCount++;
            }

            if (bodyaddressfirstName != null)
            {
                addressObject["firstName"] = CSharpExpressionConverter.ConvertToken(bodyaddressfirstName);
                addressObjectpropCount++;
            }

            if (bodyaddresslastName != null)
            {
                addressObject["lastName"] = CSharpExpressionConverter.ConvertToken(bodyaddresslastName);
                addressObjectpropCount++;
            }

            if (bodyaddressphoneNumber != null)
            {
                addressObject["phoneNumber"] = CSharpExpressionConverter.ConvertToken(bodyaddressphoneNumber);
                addressObjectpropCount++;
            }

            if (bodyaddressemail != null)
            {
                addressObject["email"] = CSharpExpressionConverter.ConvertToken(bodyaddressemail);
                addressObjectpropCount++;
            }

            if (addressObjectpropCount > 0)
            {
                body["address"] = addressObject;
                bodypropCount++;
            }

            if (bodyupdateDate != null)
            {
                body["updateDate"] = CSharpExpressionConverter.ConvertToken(bodyupdateDate);
                bodypropCount++;
            }

            if (bodyinsertDate != null)
            {
                body["insertDate"] = CSharpExpressionConverter.ConvertToken(bodyinsertDate);
                bodypropCount++;
            }

            if (bodytaxOffice != null)
            {
                body["taxOffice"] = CSharpExpressionConverter.ConvertToken(bodytaxOffice);
                bodypropCount++;
            }

            if (bodyaccountSourceTypeId != null)
            {
                body["accountSourceTypeId"] = CSharpExpressionConverter.ConvertToken(bodyaccountSourceTypeId);
                bodypropCount++;
            }

            if (bodyindustryId != null)
            {
                body["industryId"] = CSharpExpressionConverter.ConvertToken(bodyindustryId);
                bodypropCount++;
            }

            if (bodytierId != null)
            {
                body["tierId"] = CSharpExpressionConverter.ConvertToken(bodytierId);
                bodypropCount++;
            }

            if (bodywebsite != null)
            {
                body["website"] = CSharpExpressionConverter.ConvertToken(bodywebsite);
                bodypropCount++;
            }

            if (bodyaccountDescription != null)
            {
                body["accountDescription"] = CSharpExpressionConverter.ConvertToken(bodyaccountDescription);
                bodypropCount++;
            }

            if (bodynoOfEmployees != null)
            {
                body["noOfEmployees"] = CSharpExpressionConverter.ConvertToken(bodynoOfEmployees);
                bodypropCount++;
            }

            if (bodyannualRevenue != null)
            {
                body["annualRevenue"] = CSharpExpressionConverter.ConvertToken(bodyannualRevenue);
                bodypropCount++;
            }

            if (bodycreatedBy != null)
            {
                body["createdBy"] = CSharpExpressionConverter.ConvertToken(bodycreatedBy);
                bodypropCount++;
            }

            if (bodylastModifiedBy != null)
            {
                body["lastModifiedBy"] = CSharpExpressionConverter.ConvertToken(bodylastModifiedBy);
                bodypropCount++;
            }

            if (bodyfax != null)
            {
                body["fax"] = CSharpExpressionConverter.ConvertToken(bodyfax);
                bodypropCount++;
            }

            if (bodyownershipId != null)
            {
                body["ownershipId"] = CSharpExpressionConverter.ConvertToken(bodyownershipId);
                bodypropCount++;
            }

            if (bodyratingId != null)
            {
                body["ratingId"] = CSharpExpressionConverter.ConvertToken(bodyratingId);
                bodypropCount++;
            }

            if (bodyclassificationId != null)
            {
                body["classificationId"] = CSharpExpressionConverter.ConvertToken(bodyclassificationId);
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
                body["assignedTeams"] = CSharpExpressionConverter.ConvertToken(bodyassignedTeams);
                bodypropCount++;
            }

            if (bodyaiScore != null)
            {
                body["aiScore"] = CSharpExpressionConverter.ConvertToken(bodyaiScore);
                bodypropCount++;
            }

            if (bodyaiScoreReasoning != null)
            {
                body["aiScoreReasoning"] = CSharpExpressionConverter.ConvertToken(bodyaiScoreReasoning);
                bodypropCount++;
            }

            if (bodyaiSentiment != null)
            {
                body["aiSentiment"] = CSharpExpressionConverter.Convert(bodyaiSentiment);
                bodypropCount++;
            }

            if (bodyaiGenerationDate != null)
            {
                body["aiGenerationDate"] = CSharpExpressionConverter.ConvertToken(bodyaiGenerationDate);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/Contact/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CustomerApiFeaturesContactsContact>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IWorkflowAction ContactDelete(Expression<Func<string>> contactId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/Contact/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softonewebcrm")]
        public IBodyWorkflowAction<CustomerApiFeaturesContactsContactDTO> ContactUpdate(Expression<Func<string>> contactId, Expression<Func<string>> bodyownerId = null, Expression<Func<string[]>> bodyaccountIds = null, Expression<Func<string>> bodysourceId = null, Expression<Func<string>> bodysourceOwnerId = null, Expression<Func<string[]>> bodysourceAccountIds = null, Expression<Func<string>> bodynamefirstName = null, Expression<Func<string>> bodynamelastName = null, Expression<Func<string>> bodynamemiddleName = null, Expression<Func<string>> bodynamesalutationId = null, Expression<Func<string>> bodynamesuffix = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodymobilePhone = null, Expression<Func<string>> bodyfax = null, Expression<Func<bool>> bodycallOptOut = null, Expression<Func<bool>> bodyemailOptOut = null, Expression<Func<CustomerApiFeaturesContactsEmailDTO[]>> bodyotherEmail = null, Expression<Func<CustomerApiFeaturesContactsPhoneDTO[]>> bodyotherPhone = null, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodygenderId = null, Expression<Func<string>> bodypronounceId = null, Expression<Func<string>> bodyaddressaddress1 = null, Expression<Func<string>> bodyaddressaddress2 = null, Expression<Func<string>> bodyaddresscity = null, Expression<Func<string>> bodyaddressstate = null, Expression<Func<string>> bodyaddresslatitude = null, Expression<Func<string>> bodyaddresslongtitude = null, Expression<Func<string>> bodyaddresscountry = null, Expression<Func<string>> bodyaddresscountryCode = null, Expression<Func<string>> bodyaddresspostalCode = null, Expression<Func<string>> bodyaddressfirstName = null, Expression<Func<string>> bodyaddresslastName = null, Expression<Func<string>> bodyaddressphoneNumber = null, Expression<Func<string>> bodyaddressemail = null, Expression<Func<string>> bodycreatedBy = null, Expression<Func<string>> bodylastModifiedBy = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodyreportsTo = null, Expression<Func<string>> bodyassistant = null, Expression<Func<string>> bodyassistantPhone = null, Expression<Func<string>> bodybirthday = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodylastStayInTouchReportedDate = null, Expression<Func<string>> bodylastStayInTouchSaveDate = null, Expression<Func<string>> bodyaccountSourceTypeId = null, Expression<Func<string[]>> bodyassignedTeams = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/Contact/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyownerId != null)
            {
                body["ownerId"] = CSharpExpressionConverter.ConvertToken(bodyownerId);
                bodypropCount++;
            }

            if (bodyaccountIds != null)
            {
                body["accountIds"] = CSharpExpressionConverter.ConvertToken(bodyaccountIds);
                bodypropCount++;
            }

            if (bodysourceId != null)
            {
                body["sourceId"] = CSharpExpressionConverter.ConvertToken(bodysourceId);
                bodypropCount++;
            }

            if (bodysourceOwnerId != null)
            {
                body["sourceOwnerId"] = CSharpExpressionConverter.ConvertToken(bodysourceOwnerId);
                bodypropCount++;
            }

            if (bodysourceAccountIds != null)
            {
                body["sourceAccountIds"] = CSharpExpressionConverter.ConvertToken(bodysourceAccountIds);
                bodypropCount++;
            }

            var nameObject = new JObject();
            var nameObjectpropCount = 0;
            if (bodynamefirstName != null)
            {
                nameObject["firstName"] = CSharpExpressionConverter.ConvertToken(bodynamefirstName);
                nameObjectpropCount++;
            }

            if (bodynamelastName != null)
            {
                nameObject["lastName"] = CSharpExpressionConverter.ConvertToken(bodynamelastName);
                nameObjectpropCount++;
            }

            if (bodynamemiddleName != null)
            {
                nameObject["middleName"] = CSharpExpressionConverter.ConvertToken(bodynamemiddleName);
                nameObjectpropCount++;
            }

            if (bodynamesalutationId != null)
            {
                nameObject["salutationId"] = CSharpExpressionConverter.ConvertToken(bodynamesalutationId);
                nameObjectpropCount++;
            }

            if (bodynamesuffix != null)
            {
                nameObject["suffix"] = CSharpExpressionConverter.ConvertToken(bodynamesuffix);
                nameObjectpropCount++;
            }

            if (nameObjectpropCount > 0)
            {
                body["name"] = nameObject;
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
            }

            if (bodyphone != null)
            {
                body["phone"] = CSharpExpressionConverter.ConvertToken(bodyphone);
                bodypropCount++;
            }

            if (bodymobilePhone != null)
            {
                body["mobilePhone"] = CSharpExpressionConverter.ConvertToken(bodymobilePhone);
                bodypropCount++;
            }

            if (bodyfax != null)
            {
                body["fax"] = CSharpExpressionConverter.ConvertToken(bodyfax);
                bodypropCount++;
            }

            if (bodycallOptOut != null)
            {
                body["callOptOut"] = CSharpExpressionConverter.ConvertToken(bodycallOptOut);
                bodypropCount++;
            }

            if (bodyemailOptOut != null)
            {
                body["emailOptOut"] = CSharpExpressionConverter.ConvertToken(bodyemailOptOut);
                bodypropCount++;
            }

            if (bodyotherEmail != null)
            {
                body["otherEmail"] = CSharpExpressionConverter.ConvertToken(bodyotherEmail);
                bodypropCount++;
            }

            if (bodyotherPhone != null)
            {
                body["otherPhone"] = CSharpExpressionConverter.ConvertToken(bodyotherPhone);
                bodypropCount++;
            }

            if (bodyjobTitle != null)
            {
                body["jobTitle"] = CSharpExpressionConverter.ConvertToken(bodyjobTitle);
                bodypropCount++;
            }

            if (bodygenderId != null)
            {
                body["genderId"] = CSharpExpressionConverter.ConvertToken(bodygenderId);
                bodypropCount++;
            }

            if (bodypronounceId != null)
            {
                body["pronounceId"] = CSharpExpressionConverter.ConvertToken(bodypronounceId);
                bodypropCount++;
            }

            var addressObject = new JObject();
            var addressObjectpropCount = 0;
            if (bodyaddressaddress1 != null)
            {
                addressObject["address1"] = CSharpExpressionConverter.ConvertToken(bodyaddressaddress1);
                addressObjectpropCount++;
            }

            if (bodyaddressaddress2 != null)
            {
                addressObject["address2"] = CSharpExpressionConverter.ConvertToken(bodyaddressaddress2);
                addressObjectpropCount++;
            }

            if (bodyaddresscity != null)
            {
                addressObject["city"] = CSharpExpressionConverter.ConvertToken(bodyaddresscity);
                addressObjectpropCount++;
            }

            if (bodyaddressstate != null)
            {
                addressObject["state"] = CSharpExpressionConverter.ConvertToken(bodyaddressstate);
                addressObjectpropCount++;
            }

            if (bodyaddresslatitude != null)
            {
                addressObject["latitude"] = CSharpExpressionConverter.ConvertToken(bodyaddresslatitude);
                addressObjectpropCount++;
            }

            if (bodyaddresslongtitude != null)
            {
                addressObject["longtitude"] = CSharpExpressionConverter.ConvertToken(bodyaddresslongtitude);
                addressObjectpropCount++;
            }

            if (bodyaddresscountry != null)
            {
                addressObject["country"] = CSharpExpressionConverter.ConvertToken(bodyaddresscountry);
                addressObjectpropCount++;
            }

            if (bodyaddresscountryCode != null)
            {
                addressObject["countryCode"] = CSharpExpressionConverter.ConvertToken(bodyaddresscountryCode);
                addressObjectpropCount++;
            }

            if (bodyaddresspostalCode != null)
            {
                addressObject["postalCode"] = CSharpExpressionConverter.ConvertToken(bodyaddresspostalCode);
                addressObjectpropCount++;
            }

            if (bodyaddressfirstName != null)
            {
                addressObject["firstName"] = CSharpExpressionConverter.ConvertToken(bodyaddressfirstName);
                addressObjectpropCount++;
            }

            if (bodyaddresslastName != null)
            {
                addressObject["lastName"] = CSharpExpressionConverter.ConvertToken(bodyaddresslastName);
                addressObjectpropCount++;
            }

            if (bodyaddressphoneNumber != null)
            {
                addressObject["phoneNumber"] = CSharpExpressionConverter.ConvertToken(bodyaddressphoneNumber);
                addressObjectpropCount++;
            }

            if (bodyaddressemail != null)
            {
                addressObject["email"] = CSharpExpressionConverter.ConvertToken(bodyaddressemail);
                addressObjectpropCount++;
            }

            if (addressObjectpropCount > 0)
            {
                body["address"] = addressObject;
                bodypropCount++;
            }

            if (bodycreatedBy != null)
            {
                body["createdBy"] = CSharpExpressionConverter.ConvertToken(bodycreatedBy);
                bodypropCount++;
            }

            if (bodylastModifiedBy != null)
            {
                body["lastModifiedBy"] = CSharpExpressionConverter.ConvertToken(bodylastModifiedBy);
                bodypropCount++;
            }

            if (bodydepartment != null)
            {
                body["department"] = CSharpExpressionConverter.ConvertToken(bodydepartment);
                bodypropCount++;
            }

            if (bodyreportsTo != null)
            {
                body["reportsTo"] = CSharpExpressionConverter.ConvertToken(bodyreportsTo);
                bodypropCount++;
            }

            if (bodyassistant != null)
            {
                body["assistant"] = CSharpExpressionConverter.ConvertToken(bodyassistant);
                bodypropCount++;
            }

            if (bodyassistantPhone != null)
            {
                body["assistantPhone"] = CSharpExpressionConverter.ConvertToken(bodyassistantPhone);
                bodypropCount++;
            }

            if (bodybirthday != null)
            {
                body["birthday"] = CSharpExpressionConverter.ConvertToken(bodybirthday);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodylastStayInTouchReportedDate != null)
            {
                body["lastStayInTouchReportedDate"] = CSharpExpressionConverter.ConvertToken(bodylastStayInTouchReportedDate);
                bodypropCount++;
            }

            if (bodylastStayInTouchSaveDate != null)
            {
                body["lastStayInTouchSaveDate"] = CSharpExpressionConverter.ConvertToken(bodylastStayInTouchSaveDate);
                bodypropCount++;
            }

            if (bodyaccountSourceTypeId != null)
            {
                body["accountSourceTypeId"] = CSharpExpressionConverter.ConvertToken(bodyaccountSourceTypeId);
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
                body["assignedTeams"] = CSharpExpressionConverter.ConvertToken(bodyassignedTeams);
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
                callPayload.Queries["Name"] = CSharpExpressionConverter.ConvertO(name);
            if (ownerId != null)
                callPayload.Queries["OwnerId"] = CSharpExpressionConverter.ConvertO(ownerId);
            if (suggestions != null)
                callPayload.Queries["Suggestions"] = CSharpExpressionConverter.ConvertO(suggestions);
            if (accountSourceTypeId != null)
                callPayload.Queries["AccountSourceTypeId"] = CSharpExpressionConverter.ConvertO(accountSourceTypeId);
            if (firstName != null)
                callPayload.Queries["FirstName"] = CSharpExpressionConverter.ConvertO(firstName);
            if (lastName != null)
                callPayload.Queries["LastName"] = CSharpExpressionConverter.ConvertO(lastName);
            if (phone != null)
                callPayload.Queries["Phone"] = CSharpExpressionConverter.ConvertO(phone);
            if (mobilePhone != null)
                callPayload.Queries["MobilePhone"] = CSharpExpressionConverter.ConvertO(mobilePhone);
            if (accountIds != null)
                callPayload.Queries["AccountIds"] = CSharpExpressionConverter.ConvertO(accountIds);
            if (email != null)
                callPayload.Queries["Email"] = CSharpExpressionConverter.ConvertO(email);
            if (id != null)
                callPayload.Queries["Id"] = CSharpExpressionConverter.ConvertO(id);
            if (assignedTeams != null)
                callPayload.Queries["AssignedTeams"] = CSharpExpressionConverter.ConvertO(assignedTeams);
            if (search != null)
                callPayload.Queries["Search"] = CSharpExpressionConverter.ConvertO(search);
            if (page != null)
                callPayload.Queries["Page"] = CSharpExpressionConverter.ConvertO(page);
            if (pageSize != null)
                callPayload.Queries["PageSize"] = CSharpExpressionConverter.ConvertO(pageSize);
            if (sort != null)
                callPayload.Queries["Sort"] = CSharpExpressionConverter.ConvertO(sort);
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
                body["id"] = CSharpExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
            }

            if (bodycompanyId != null)
            {
                body["companyId"] = CSharpExpressionConverter.ConvertToken(bodycompanyId);
                bodypropCount++;
            }

            if (bodyownerId != null)
            {
                body["ownerId"] = CSharpExpressionConverter.ConvertToken(bodyownerId);
                bodypropCount++;
            }

            if (bodyaccountIds != null)
            {
                body["accountIds"] = CSharpExpressionConverter.ConvertToken(bodyaccountIds);
                bodypropCount++;
            }

            if (bodysourceId != null)
            {
                body["sourceId"] = CSharpExpressionConverter.ConvertToken(bodysourceId);
                bodypropCount++;
            }

            if (bodysourceOwnerId != null)
            {
                body["sourceOwnerId"] = CSharpExpressionConverter.ConvertToken(bodysourceOwnerId);
                bodypropCount++;
            }

            if (bodysourceAccountIds != null)
            {
                body["sourceAccountIds"] = CSharpExpressionConverter.ConvertToken(bodysourceAccountIds);
                bodypropCount++;
            }

            var nameObject = new JObject();
            var nameObjectpropCount = 0;
            if (bodynamefirstName != null)
            {
                nameObject["firstName"] = CSharpExpressionConverter.ConvertToken(bodynamefirstName);
                nameObjectpropCount++;
            }

            if (bodynamelastName != null)
            {
                nameObject["lastName"] = CSharpExpressionConverter.ConvertToken(bodynamelastName);
                nameObjectpropCount++;
            }

            if (bodynamemiddleName != null)
            {
                nameObject["middleName"] = CSharpExpressionConverter.ConvertToken(bodynamemiddleName);
                nameObjectpropCount++;
            }

            if (bodynamesalutationId != null)
            {
                nameObject["salutationId"] = CSharpExpressionConverter.ConvertToken(bodynamesalutationId);
                nameObjectpropCount++;
            }

            if (bodynamesuffix != null)
            {
                nameObject["suffix"] = CSharpExpressionConverter.ConvertToken(bodynamesuffix);
                nameObjectpropCount++;
            }

            if (nameObjectpropCount > 0)
            {
                body["name"] = nameObject;
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
            }

            if (bodyphone != null)
            {
                body["phone"] = CSharpExpressionConverter.ConvertToken(bodyphone);
                bodypropCount++;
            }

            if (bodymobilePhone != null)
            {
                body["mobilePhone"] = CSharpExpressionConverter.ConvertToken(bodymobilePhone);
                bodypropCount++;
            }

            if (bodyfax != null)
            {
                body["fax"] = CSharpExpressionConverter.ConvertToken(bodyfax);
                bodypropCount++;
            }

            if (bodycallOptOut != null)
            {
                body["callOptOut"] = CSharpExpressionConverter.ConvertToken(bodycallOptOut);
                bodypropCount++;
            }

            if (bodyemailOptOut != null)
            {
                body["emailOptOut"] = CSharpExpressionConverter.ConvertToken(bodyemailOptOut);
                bodypropCount++;
            }

            if (bodyotherEmail != null)
            {
                body["otherEmail"] = CSharpExpressionConverter.ConvertToken(bodyotherEmail);
                bodypropCount++;
            }

            if (bodyotherPhone != null)
            {
                body["otherPhone"] = CSharpExpressionConverter.ConvertToken(bodyotherPhone);
                bodypropCount++;
            }

            if (bodyjobTitle != null)
            {
                body["jobTitle"] = CSharpExpressionConverter.ConvertToken(bodyjobTitle);
                bodypropCount++;
            }

            if (bodygenderId != null)
            {
                body["genderId"] = CSharpExpressionConverter.ConvertToken(bodygenderId);
                bodypropCount++;
            }

            if (bodypronounceId != null)
            {
                body["pronounceId"] = CSharpExpressionConverter.ConvertToken(bodypronounceId);
                bodypropCount++;
            }

            var addressObject = new JObject();
            var addressObjectpropCount = 0;
            if (bodyaddressaddress1 != null)
            {
                addressObject["address1"] = CSharpExpressionConverter.ConvertToken(bodyaddressaddress1);
                addressObjectpropCount++;
            }

            if (bodyaddressaddress2 != null)
            {
                addressObject["address2"] = CSharpExpressionConverter.ConvertToken(bodyaddressaddress2);
                addressObjectpropCount++;
            }

            if (bodyaddresscity != null)
            {
                addressObject["city"] = CSharpExpressionConverter.ConvertToken(bodyaddresscity);
                addressObjectpropCount++;
            }

            if (bodyaddressstate != null)
            {
                addressObject["state"] = CSharpExpressionConverter.ConvertToken(bodyaddressstate);
                addressObjectpropCount++;
            }

            if (bodyaddresslatitude != null)
            {
                addressObject["latitude"] = CSharpExpressionConverter.ConvertToken(bodyaddresslatitude);
                addressObjectpropCount++;
            }

            if (bodyaddresslongtitude != null)
            {
                addressObject["longtitude"] = CSharpExpressionConverter.ConvertToken(bodyaddresslongtitude);
                addressObjectpropCount++;
            }

            if (bodyaddresscountry != null)
            {
                addressObject["country"] = CSharpExpressionConverter.ConvertToken(bodyaddresscountry);
                addressObjectpropCount++;
            }

            if (bodyaddresscountryCode != null)
            {
                addressObject["countryCode"] = CSharpExpressionConverter.ConvertToken(bodyaddresscountryCode);
                addressObjectpropCount++;
            }

            if (bodyaddresspostalCode != null)
            {
                addressObject["postalCode"] = CSharpExpressionConverter.ConvertToken(bodyaddresspostalCode);
                addressObjectpropCount++;
            }

            if (bodyaddressfirstName != null)
            {
                addressObject["firstName"] = CSharpExpressionConverter.ConvertToken(bodyaddressfirstName);
                addressObjectpropCount++;
            }

            if (bodyaddresslastName != null)
            {
                addressObject["lastName"] = CSharpExpressionConverter.ConvertToken(bodyaddresslastName);
                addressObjectpropCount++;
            }

            if (bodyaddressphoneNumber != null)
            {
                addressObject["phoneNumber"] = CSharpExpressionConverter.ConvertToken(bodyaddressphoneNumber);
                addressObjectpropCount++;
            }

            if (bodyaddressemail != null)
            {
                addressObject["email"] = CSharpExpressionConverter.ConvertToken(bodyaddressemail);
                addressObjectpropCount++;
            }

            if (addressObjectpropCount > 0)
            {
                body["address"] = addressObject;
                bodypropCount++;
            }

            if (bodyinsertDate != null)
            {
                body["insertDate"] = CSharpExpressionConverter.ConvertToken(bodyinsertDate);
                bodypropCount++;
            }

            if (bodyupdateDate != null)
            {
                body["updateDate"] = CSharpExpressionConverter.ConvertToken(bodyupdateDate);
                bodypropCount++;
            }

            if (bodycreatedBy != null)
            {
                body["createdBy"] = CSharpExpressionConverter.ConvertToken(bodycreatedBy);
                bodypropCount++;
            }

            if (bodylastModifiedBy != null)
            {
                body["lastModifiedBy"] = CSharpExpressionConverter.ConvertToken(bodylastModifiedBy);
                bodypropCount++;
            }

            if (bodydepartment != null)
            {
                body["department"] = CSharpExpressionConverter.ConvertToken(bodydepartment);
                bodypropCount++;
            }

            if (bodyreportsTo != null)
            {
                body["reportsTo"] = CSharpExpressionConverter.ConvertToken(bodyreportsTo);
                bodypropCount++;
            }

            if (bodyassistant != null)
            {
                body["assistant"] = CSharpExpressionConverter.ConvertToken(bodyassistant);
                bodypropCount++;
            }

            if (bodyassistantPhone != null)
            {
                body["assistantPhone"] = CSharpExpressionConverter.ConvertToken(bodyassistantPhone);
                bodypropCount++;
            }

            if (bodybirthday != null)
            {
                body["birthday"] = CSharpExpressionConverter.ConvertToken(bodybirthday);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodylastStayInTouchReportedDate != null)
            {
                body["lastStayInTouchReportedDate"] = CSharpExpressionConverter.ConvertToken(bodylastStayInTouchReportedDate);
                bodypropCount++;
            }

            if (bodylastStayInTouchSaveDate != null)
            {
                body["lastStayInTouchSaveDate"] = CSharpExpressionConverter.ConvertToken(bodylastStayInTouchSaveDate);
                bodypropCount++;
            }

            if (bodyaccountSourceTypeId != null)
            {
                body["accountSourceTypeId"] = CSharpExpressionConverter.ConvertToken(bodyaccountSourceTypeId);
                bodypropCount++;
            }

            if (bodyfullName != null)
            {
                body["fullName"] = CSharpExpressionConverter.ConvertToken(bodyfullName);
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
                body["assignedTeams"] = CSharpExpressionConverter.ConvertToken(bodyassignedTeams);
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
            body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
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
            body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
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
            body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
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
            body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
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
            body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
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
            body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
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
            body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
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
            body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
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
            body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
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
            body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
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
            body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
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
            body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
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
            body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
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
            body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
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
            body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
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