//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Toggltrack
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ToggltrackActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<UserResponse> GetMe(Expression<Func<bool>> withRelatedData = null)
        {
            var apiCallPath = "/me";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["with_related_data"] = Convert.ToString(false);
            if (withRelatedData != null)
                callPayload.Queries["with_related_data"] = ExpressionConverter.Convert(withRelatedData);
            return new ApiConnectionAction<UserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<UserBasicResponse> UpdateMe(Expression<Func<int>> bodybeginningOfWeek = null, Expression<Func<int>> bodycountryID = null, Expression<Func<string>> bodycurrentPassword = null, Expression<Func<int>> bodydefaultWorkspaceID = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyfullName = null, Expression<Func<string>> bodynewPassword = null, Expression<Func<string>> bodytimezone = null)
        {
            var apiCallPath = "/me";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodybeginningOfWeek != null)
            {
                body["beginning_of_week"] = ExpressionConverter.ConvertO(bodybeginningOfWeek);
                bodypropCount++;
            }

            if (bodycountryID != null)
            {
                body["country_id"] = ExpressionConverter.ConvertO(bodycountryID);
                bodypropCount++;
            }

            if (bodycurrentPassword != null)
            {
                body["current_password"] = ExpressionConverter.ConvertO(bodycurrentPassword);
                bodypropCount++;
            }

            if (bodydefaultWorkspaceID != null)
            {
                body["default_workspace_id"] = ExpressionConverter.ConvertO(bodydefaultWorkspaceID);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodyfullName != null)
            {
                body["fullname"] = ExpressionConverter.ConvertO(bodyfullName);
                bodypropCount++;
            }

            if (bodynewPassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodynewPassword);
                bodypropCount++;
            }

            if (bodytimezone != null)
            {
                body["timezone"] = ExpressionConverter.ConvertO(bodytimezone);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UserBasicResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Client[]> GetMeClients(Expression<Func<int>> since = null)
        {
            var apiCallPath = "/me/clients";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (since != null)
                callPayload.Queries["since"] = ExpressionConverter.Convert(since);
            return new ApiConnectionAction<Client[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<WorkspaceFeatures[]> GetMeFeatures()
        {
            var apiCallPath = "/me/features";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<WorkspaceFeatures[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<LocationResponse> GetMeLocation()
        {
            var apiCallPath = "/me/location";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LocationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IWorkflowAction GetMeLogged()
        {
            var apiCallPath = "/me/logged";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Organization[]> GetMeOrganizations()
        {
            var apiCallPath = "/me/organizations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Organization[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Project[]> GetMeProjects(Expression<Func<string>> includeArchived = null, Expression<Func<int>> since = null)
        {
            var apiCallPath = "/me/projects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeArchived != null)
                callPayload.Queries["include_archived"] = ExpressionConverter.Convert(includeArchived);
            if (since != null)
                callPayload.Queries["since"] = ExpressionConverter.Convert(since);
            return new ApiConnectionAction<Project[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Project[]> GetMeProjectsPaginated(Expression<Func<int>> startProjectId = null, Expression<Func<int>> since = null, Expression<Func<int>> perPage = null)
        {
            var apiCallPath = "/me/projects/paginated";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (startProjectId != null)
                callPayload.Queries["start_project_id"] = ExpressionConverter.Convert(startProjectId);
            if (since != null)
                callPayload.Queries["since"] = ExpressionConverter.Convert(since);
            callPayload.Queries["per_page"] = Convert.ToString(201);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            return new ApiConnectionAction<Project[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Tag[]> GetMeTags(Expression<Func<int>> since = null)
        {
            var apiCallPath = "/me/tags";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (since != null)
                callPayload.Queries["since"] = ExpressionConverter.Convert(since);
            return new ApiConnectionAction<Tag[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TaskObject[]> GetMeTasks(Expression<Func<bool>> meta = null, Expression<Func<int>> since = null, Expression<Func<string>> includeNotActive = null, Expression<Func<int>> offset = null, Expression<Func<int>> perPage = null)
        {
            var apiCallPath = "/me/tasks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["meta"] = Convert.ToString(false);
            if (meta != null)
                callPayload.Queries["meta"] = ExpressionConverter.Convert(meta);
            if (since != null)
                callPayload.Queries["since"] = ExpressionConverter.Convert(since);
            if (includeNotActive != null)
                callPayload.Queries["include_not_active"] = ExpressionConverter.Convert(includeNotActive);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            callPayload.Queries["per_page"] = Convert.ToString(201);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            return new ApiConnectionAction<TaskObject[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TrackReminder[]> GetMeTrackReminders()
        {
            var apiCallPath = "/me/track_reminders";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TrackReminder[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IWorkflowAction GetMeWebTimer()
        {
            var apiCallPath = "/me/web-timer";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Workspace[]> GetMeWorkspaces(Expression<Func<int>> since = null)
        {
            var apiCallPath = "/me/workspaces";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (since != null)
                callPayload.Queries["since"] = ExpressionConverter.Convert(since);
            return new ApiConnectionAction<Workspace[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TimeEntry[]> GetMeTimeEntries(Expression<Func<bool>> meta = null, Expression<Func<bool>> includeSharing = null, Expression<Func<int>> since = null, Expression<Func<string>> before = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null)
        {
            var apiCallPath = "/me/time_entries";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["meta"] = Convert.ToString(false);
            if (meta != null)
                callPayload.Queries["meta"] = ExpressionConverter.Convert(meta);
            callPayload.Queries["include_sharing"] = Convert.ToString(false);
            if (includeSharing != null)
                callPayload.Queries["include_sharing"] = ExpressionConverter.Convert(includeSharing);
            if (since != null)
                callPayload.Queries["since"] = ExpressionConverter.Convert(since);
            if (before != null)
                callPayload.Queries["before"] = ExpressionConverter.Convert(before);
            if (startDate != null)
                callPayload.Queries["start_date"] = ExpressionConverter.Convert(startDate);
            if (endDate != null)
                callPayload.Queries["end_date"] = ExpressionConverter.Convert(endDate);
            return new ApiConnectionAction<TimeEntry[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TimeEntry> GetCurrentTimeEntry()
        {
            var apiCallPath = "/me/time_entries/current";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TimeEntry>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TimeEntry> GetTimeEntryById(Expression<Func<int>> timeEntryId, Expression<Func<bool>> meta = null, Expression<Func<bool>> includeSharing = null)
        {
            var apiCallPath = String.Format("/me/time_entries/{0}", ExpressionConverter.ConvertWithUrlEncoding(timeEntryId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["meta"] = Convert.ToString(false);
            if (meta != null)
                callPayload.Queries["meta"] = ExpressionConverter.Convert(meta);
            callPayload.Queries["include_sharing"] = Convert.ToString(false);
            if (includeSharing != null)
                callPayload.Queries["include_sharing"] = ExpressionConverter.Convert(includeSharing);
            return new ApiConnectionAction<TimeEntry>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TimeEntry> CreateTimeEntry(Expression<Func<int>> workspaceId, Expression<Func<bool>> meta = null, Expression<Func<bool>> bodybillable = null, Expression<Func<string>> bodycreatedWith = null, Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodyduration = null, Expression<Func<bool>> bodydurationOnly = null, Expression<Func<string>> bodyeventMetadataoriginFeature = null, Expression<Func<int>> bodyeventMetadatavisibleGoalsCount = null, Expression<Func<int[]>> bodyexpenseIDs = null, Expression<Func<int>> bodyprojectIDLegacy = null, Expression<Func<int>> bodyprojectID = null, Expression<Func<int[]>> bodysharedWithUserIDs = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodystopTime = null, Expression<Func<bodytagActionInput>> bodytagAction = null, Expression<Func<int[]>> bodytagIDs = null, Expression<Func<string[]>> bodytags = null, Expression<Func<int>> bodytaskID = null, Expression<Func<int>> bodytaskIDLegacy = null, Expression<Func<int>> bodyuserIDLegacy = null, Expression<Func<int>> bodyuserID = null, Expression<Func<int>> bodyworkspaceIDLegacy = null, Expression<Func<int>> bodyworkspaceID = null)
        {
            var apiCallPath = String.Format("/workspaces/{0}/time_entries", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["meta"] = Convert.ToString(false);
            if (meta != null)
                callPayload.Queries["meta"] = ExpressionConverter.Convert(meta);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodybillable != null)
            {
                body["billable"] = ExpressionConverter.ConvertO(bodybillable);
                bodypropCount++;
            }

            if (bodycreatedWith != null)
            {
                body["created_with"] = ExpressionConverter.ConvertO(bodycreatedWith);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyduration != null)
            {
                body["duration"] = ExpressionConverter.ConvertO(bodyduration);
                bodypropCount++;
            }

            if (bodydurationOnly != null)
            {
                body["duronly"] = ExpressionConverter.ConvertO(bodydurationOnly);
                bodypropCount++;
            }

            var event_metadataObject = new JObject();
            var event_metadataObjectpropCount = 0;
            if (bodyeventMetadataoriginFeature != null)
            {
                event_metadataObject["origin_feature"] = ExpressionConverter.ConvertO(bodyeventMetadataoriginFeature);
                event_metadataObjectpropCount++;
            }

            if (bodyeventMetadatavisibleGoalsCount != null)
            {
                event_metadataObject["visible_goals_count"] = ExpressionConverter.ConvertO(bodyeventMetadatavisibleGoalsCount);
                event_metadataObjectpropCount++;
            }

            if (event_metadataObjectpropCount > 0)
            {
                body["event_metadata"] = event_metadataObject;
                bodypropCount++;
            }

            if (bodyexpenseIDs != null)
            {
                body["expense_ids"] = ExpressionConverter.ConvertO(bodyexpenseIDs);
                bodypropCount++;
            }

            if (bodyprojectIDLegacy != null)
            {
                body["pid"] = ExpressionConverter.ConvertO(bodyprojectIDLegacy);
                bodypropCount++;
            }

            if (bodyprojectID != null)
            {
                body["project_id"] = ExpressionConverter.ConvertO(bodyprojectID);
                bodypropCount++;
            }

            if (bodysharedWithUserIDs != null)
            {
                body["shared_with_user_ids"] = ExpressionConverter.ConvertO(bodysharedWithUserIDs);
                bodypropCount++;
            }

            if (bodystartTime != null)
            {
                body["start"] = ExpressionConverter.ConvertO(bodystartTime);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["start_date"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodystopTime != null)
            {
                body["stop"] = ExpressionConverter.ConvertO(bodystopTime);
                bodypropCount++;
            }

            if (bodytagAction != null)
            {
                body["tag_action"] = ExpressionConverter.ConvertO(bodytagAction);
                bodypropCount++;
            }

            if (bodytagIDs != null)
            {
                body["tag_ids"] = ExpressionConverter.ConvertO(bodytagIDs);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = ExpressionConverter.ConvertO(bodytags);
                bodypropCount++;
            }

            if (bodytaskID != null)
            {
                body["task_id"] = ExpressionConverter.ConvertO(bodytaskID);
                bodypropCount++;
            }

            if (bodytaskIDLegacy != null)
            {
                body["tid"] = ExpressionConverter.ConvertO(bodytaskIDLegacy);
                bodypropCount++;
            }

            if (bodyuserIDLegacy != null)
            {
                body["uid"] = ExpressionConverter.ConvertO(bodyuserIDLegacy);
                bodypropCount++;
            }

            if (bodyuserID != null)
            {
                body["user_id"] = ExpressionConverter.ConvertO(bodyuserID);
                bodypropCount++;
            }

            if (bodyworkspaceIDLegacy != null)
            {
                body["wid"] = ExpressionConverter.ConvertO(bodyworkspaceIDLegacy);
                bodypropCount++;
            }

            if (bodyworkspaceID != null)
            {
                body["workspace_id"] = ExpressionConverter.ConvertO(bodyworkspaceID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TimeEntry>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IWorkflowAction DeleteTimeEntry(Expression<Func<int>> workspaceId, Expression<Func<int>> timeEntryId)
        {
            var apiCallPath = String.Format("/workspaces/{0}/time_entries/{1}", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(timeEntryId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TimeEntry> UpdateTimeEntry(Expression<Func<int>> workspaceId, Expression<Func<int>> timeEntryId, Expression<Func<bool>> meta = null, Expression<Func<bool>> includeSharing = null, Expression<Func<bool>> bodybillable = null, Expression<Func<string>> bodycreatedWith = null, Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodyduration = null, Expression<Func<bool>> bodydurationOnly = null, Expression<Func<string>> bodyeventMetadataoriginFeature = null, Expression<Func<int>> bodyeventMetadatavisibleGoalsCount = null, Expression<Func<int[]>> bodyexpenseIDs = null, Expression<Func<int>> bodyprojectIDLegacy = null, Expression<Func<int>> bodyprojectID = null, Expression<Func<int[]>> bodysharedWithUserIDs = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodystopTime = null, Expression<Func<bodytagActionInput>> bodytagAction = null, Expression<Func<int[]>> bodytagIDs = null, Expression<Func<string[]>> bodytags = null, Expression<Func<int>> bodytaskID = null, Expression<Func<int>> bodytaskIDLegacy = null, Expression<Func<int>> bodyuserIDLegacy = null, Expression<Func<int>> bodyuserID = null, Expression<Func<int>> bodyworkspaceIDLegacy = null, Expression<Func<int>> bodyworkspaceID = null)
        {
            var apiCallPath = String.Format("/workspaces/{0}/time_entries/{1}", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(timeEntryId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["meta"] = Convert.ToString(false);
            if (meta != null)
                callPayload.Queries["meta"] = ExpressionConverter.Convert(meta);
            callPayload.Queries["include_sharing"] = Convert.ToString(false);
            if (includeSharing != null)
                callPayload.Queries["include_sharing"] = ExpressionConverter.Convert(includeSharing);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodybillable != null)
            {
                body["billable"] = ExpressionConverter.ConvertO(bodybillable);
                bodypropCount++;
            }

            if (bodycreatedWith != null)
            {
                body["created_with"] = ExpressionConverter.ConvertO(bodycreatedWith);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyduration != null)
            {
                body["duration"] = ExpressionConverter.ConvertO(bodyduration);
                bodypropCount++;
            }

            if (bodydurationOnly != null)
            {
                body["duronly"] = ExpressionConverter.ConvertO(bodydurationOnly);
                bodypropCount++;
            }

            var event_metadataObject = new JObject();
            var event_metadataObjectpropCount = 0;
            if (bodyeventMetadataoriginFeature != null)
            {
                event_metadataObject["origin_feature"] = ExpressionConverter.ConvertO(bodyeventMetadataoriginFeature);
                event_metadataObjectpropCount++;
            }

            if (bodyeventMetadatavisibleGoalsCount != null)
            {
                event_metadataObject["visible_goals_count"] = ExpressionConverter.ConvertO(bodyeventMetadatavisibleGoalsCount);
                event_metadataObjectpropCount++;
            }

            if (event_metadataObjectpropCount > 0)
            {
                body["event_metadata"] = event_metadataObject;
                bodypropCount++;
            }

            if (bodyexpenseIDs != null)
            {
                body["expense_ids"] = ExpressionConverter.ConvertO(bodyexpenseIDs);
                bodypropCount++;
            }

            if (bodyprojectIDLegacy != null)
            {
                body["pid"] = ExpressionConverter.ConvertO(bodyprojectIDLegacy);
                bodypropCount++;
            }

            if (bodyprojectID != null)
            {
                body["project_id"] = ExpressionConverter.ConvertO(bodyprojectID);
                bodypropCount++;
            }

            if (bodysharedWithUserIDs != null)
            {
                body["shared_with_user_ids"] = ExpressionConverter.ConvertO(bodysharedWithUserIDs);
                bodypropCount++;
            }

            if (bodystartTime != null)
            {
                body["start"] = ExpressionConverter.ConvertO(bodystartTime);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["start_date"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodystopTime != null)
            {
                body["stop"] = ExpressionConverter.ConvertO(bodystopTime);
                bodypropCount++;
            }

            if (bodytagAction != null)
            {
                body["tag_action"] = ExpressionConverter.ConvertO(bodytagAction);
                bodypropCount++;
            }

            if (bodytagIDs != null)
            {
                body["tag_ids"] = ExpressionConverter.ConvertO(bodytagIDs);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = ExpressionConverter.ConvertO(bodytags);
                bodypropCount++;
            }

            if (bodytaskID != null)
            {
                body["task_id"] = ExpressionConverter.ConvertO(bodytaskID);
                bodypropCount++;
            }

            if (bodytaskIDLegacy != null)
            {
                body["tid"] = ExpressionConverter.ConvertO(bodytaskIDLegacy);
                bodypropCount++;
            }

            if (bodyuserIDLegacy != null)
            {
                body["uid"] = ExpressionConverter.ConvertO(bodyuserIDLegacy);
                bodypropCount++;
            }

            if (bodyuserID != null)
            {
                body["user_id"] = ExpressionConverter.ConvertO(bodyuserID);
                bodypropCount++;
            }

            if (bodyworkspaceIDLegacy != null)
            {
                body["wid"] = ExpressionConverter.ConvertO(bodyworkspaceIDLegacy);
                bodypropCount++;
            }

            if (bodyworkspaceID != null)
            {
                body["workspace_id"] = ExpressionConverter.ConvertO(bodyworkspaceID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TimeEntry>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<BulkEditResponse> BulkEditTimeEntries(Expression<Func<int>> workspaceId, Expression<Func<string>> timeEntryIds, Expression<Func<bool>> meta = null, Expression<Func<PatchOperation[]>> body = null)
        {
            var apiCallPath = String.Format("/workspaces/{0}/time_entries/bulk/{1}", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(timeEntryIds, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["meta"] = Convert.ToString(false);
            if (meta != null)
                callPayload.Queries["meta"] = ExpressionConverter.Convert(meta);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<BulkEditResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TimeEntry> StopTimeEntry(Expression<Func<int>> workspaceId, Expression<Func<int>> timeEntryId)
        {
            var apiCallPath = String.Format("/workspaces/{0}/time_entries/{1}/stop", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(timeEntryId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TimeEntry>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<WorkspaceUser[]> GetOrganizationWorkspaceUsers(Expression<Func<int>> organizationId, Expression<Func<int>> workspaceId, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<bool>> customRates = null, Expression<Func<bool>> active = null, Expression<Func<string>> name = null, Expression<Func<string>> search = null)
        {
            var apiCallPath = String.Format("/organizations/{0}/workspaces/{1}/workspace_users", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1), ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["per_page"] = Convert.ToString(201);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            if (customRates != null)
                callPayload.Queries["custom_rates"] = ExpressionConverter.Convert(customRates);
            if (active != null)
                callPayload.Queries["active"] = ExpressionConverter.Convert(active);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            return new ApiConnectionAction<WorkspaceUser[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Workspace> GetWorkspace(Expression<Func<int>> workspaceId)
        {
            var apiCallPath = String.Format("/workspaces/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Workspace>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Rate[]> GetWorkspaceRates(Expression<Func<int>> workspaceId, Expression<Func<levelInput>> level, Expression<Func<int>> levelId, Expression<Func<typeInput>> type = null)
        {
            var apiCallPath = String.Format("/workspaces/{0}/rates/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(level, 1), ExpressionConverter.ConvertWithUrlEncoding(levelId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["type"] = Convert.ToString("billable_rates");
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            return new ApiConnectionAction<Rate[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<WorkspaceStatistics> GetWorkspaceStatistics(Expression<Func<int>> workspaceId)
        {
            var apiCallPath = String.Format("/workspaces/{0}/statistics", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<WorkspaceStatistics>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TimeEntryConstraints> GetWorkspaceTimeEntryConstraints(Expression<Func<int>> workspaceId)
        {
            var apiCallPath = String.Format("/workspaces/{0}/time_entry_constraints", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TimeEntryConstraints>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TrackRemindersResponse> GetWorkspaceTrackReminders(Expression<Func<int>> workspaceId)
        {
            var apiCallPath = String.Format("/workspaces/{0}/track_reminders", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TrackRemindersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<WorkspaceUserSimple[]> GetWorkspaceUsers(Expression<Func<int>> workspaceId, Expression<Func<bool>> excludeDeleted = null)
        {
            var apiCallPath = String.Format("/workspaces/{0}/users", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["exclude_deleted"] = Convert.ToString(false);
            if (excludeDeleted != null)
                callPayload.Queries["exclude_deleted"] = ExpressionConverter.Convert(excludeDeleted);
            return new ApiConnectionAction<WorkspaceUserSimple[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<ProjectUser[]> GetWorkspaceProjectUsers(Expression<Func<int>> workspaceId, Expression<Func<string>> projectIds = null, Expression<Func<string>> userId = null, Expression<Func<bool>> withGroupMembers = null)
        {
            var apiCallPath = String.Format("/workspaces/{0}/project_users", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (projectIds != null)
                callPayload.Queries["project_ids"] = ExpressionConverter.Convert(projectIds);
            if (userId != null)
                callPayload.Queries["user_id"] = ExpressionConverter.Convert(userId);
            callPayload.Queries["with_group_members"] = Convert.ToString(false);
            if (withGroupMembers != null)
                callPayload.Queries["with_group_members"] = ExpressionConverter.Convert(withGroupMembers);
            return new ApiConnectionAction<ProjectUser[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Project[]> GetWorkspaceProjects(Expression<Func<int>> workspaceId, Expression<Func<bool>> sortPinned, Expression<Func<string>> sortField, Expression<Func<sortOrderInput>> sortOrder, Expression<Func<bool>> onlyTemplates, Expression<Func<bool>> active = null, Expression<Func<int>> since = null, Expression<Func<bool>> billable = null, Expression<Func<int[]>> userIds = null, Expression<Func<int[]>> clientIds = null, Expression<Func<int[]>> groupIds = null, Expression<Func<string>> projectIds = null, Expression<Func<string[]>> statuses = null, Expression<Func<string>> name = null, Expression<Func<int>> page = null, Expression<Func<bool>> onlyMe = null, Expression<Func<int>> perPage = null)
        {
            var apiCallPath = String.Format("/workspaces/{0}/projects", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["sort_pinned"] = ExpressionConverter.Convert(sortPinned);
            if (active != null)
                callPayload.Queries["active"] = ExpressionConverter.Convert(active);
            if (since != null)
                callPayload.Queries["since"] = ExpressionConverter.Convert(since);
            if (billable != null)
                callPayload.Queries["billable"] = ExpressionConverter.Convert(billable);
            if (userIds != null)
                callPayload.Queries["user_ids"] = ExpressionConverter.Convert(userIds);
            if (clientIds != null)
                callPayload.Queries["client_ids"] = ExpressionConverter.Convert(clientIds);
            if (groupIds != null)
                callPayload.Queries["group_ids"] = ExpressionConverter.Convert(groupIds);
            if (projectIds != null)
                callPayload.Queries["project_ids"] = ExpressionConverter.Convert(projectIds);
            if (statuses != null)
                callPayload.Queries["statuses"] = ExpressionConverter.Convert(statuses);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["sort_field"] = ExpressionConverter.Convert(sortField);
            callPayload.Queries["sort_order"] = ExpressionConverter.Convert(sortOrder);
            callPayload.Queries["only_templates"] = ExpressionConverter.Convert(onlyTemplates);
            callPayload.Queries["only_me"] = Convert.ToString(false);
            if (onlyMe != null)
                callPayload.Queries["only_me"] = ExpressionConverter.Convert(onlyMe);
            callPayload.Queries["per_page"] = Convert.ToString(201);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            return new ApiConnectionAction<Project[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Project> GetWorkspaceProject(Expression<Func<int>> workspaceId, Expression<Func<int>> projectId)
        {
            var apiCallPath = String.Format("/workspaces/{0}/projects/{1}", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Project>(callPayload);
        }
    }

    public class ToggltrackTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookSubscription> OnTimeEntryCreated(Expression<Func<int>> workspaceId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/webhooks/api/v1/subscriptions/{0}/time_entry_created", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url_callback"] = "@listCallbackUrl()";
            bodypropCount++;
            body["description"] = "Power Automate Time Tracking Trigger";
            bodypropCount++;
            body["enabled"] = true;
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookSubscription>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookSubscription> OnTimeEntryUpdated(Expression<Func<int>> workspaceId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/webhooks/api/v1/subscriptions/{0}/time_entry_updated", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url_callback"] = "@listCallbackUrl()";
            bodypropCount++;
            body["description"] = "Power Automate Time Tracking Trigger";
            bodypropCount++;
            body["enabled"] = true;
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookSubscription>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookSubscription> OnTimeEntryDeleted(Expression<Func<int>> workspaceId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/webhooks/api/v1/subscriptions/{0}/time_entry_deleted", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url_callback"] = "@listCallbackUrl()";
            bodypropCount++;
            body["description"] = "Power Automate Time Tracking Trigger";
            bodypropCount++;
            body["enabled"] = true;
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookSubscription>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookSubscription> OnTimeEntryStarted(Expression<Func<int>> workspaceId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/webhooks/api/v1/subscriptions/{0}/time_entry_started", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url_callback"] = "@listCallbackUrl()";
            bodypropCount++;
            body["description"] = "Power Automate Time Tracking Trigger";
            bodypropCount++;
            body["enabled"] = true;
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookSubscription>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookSubscription> OnTimeEntryStopped(Expression<Func<int>> workspaceId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/webhooks/api/v1/subscriptions/{0}/time_entry_stopped", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url_callback"] = "@listCallbackUrl()";
            bodypropCount++;
            body["description"] = "Power Automate Time Tracking Trigger";
            bodypropCount++;
            body["enabled"] = true;
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookSubscription>(callPayload, triggerName, recurrence);
        }
    }

    public class UserResponse
    {
        [JsonProperty("2fa_enabled")]
        public bool _2FAEnabled { get; set; }

        [JsonProperty("api_token")]
        public string APIToken { get; set; }

        [JsonProperty("at")]
        public string LastUpdated { get; set; }

        [JsonProperty("authorization_updated_at")]
        public string AuthorizationUpdated { get; set; }

        [JsonProperty("beginning_of_week")]
        public int BeginningOfWeek { get; set; }

        [JsonProperty("clients")]
        public Client[] Clients { get; set; }

        [JsonProperty("country_id")]
        public int CountryID { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("default_workspace_id")]
        public int DefaultWorkspaceID { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("fullname")]
        public string FullName { get; set; }

        [JsonProperty("has_password")]
        public bool HasPassword { get; set; }

        [JsonProperty("id")]
        public int UserID { get; set; }

        [JsonProperty("image_url")]
        public string ImageURL { get; set; }

        [JsonProperty("intercom_hash")]
        public string IntercomHash { get; set; }

        [JsonProperty("oauth_providers")]
        public string[] OAuthProviders { get; set; }

        [JsonProperty("openid_email")]
        public string OpenIDEmail { get; set; }

        [JsonProperty("openid_enabled")]
        public bool OpenIDEnabled { get; set; }

        [JsonProperty("options")]
        public JToken Options { get; set; }

        [JsonProperty("projects")]
        public Project[] Projects { get; set; }

        [JsonProperty("tags")]
        public Tag[] Tags { get; set; }

        [JsonProperty("tasks")]
        public TaskObject[] Tasks { get; set; }

        [JsonProperty("time_entries")]
        public TimeEntry[] TimeEntries { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("workspaces")]
        public Workspace[] Workspaces { get; set; }
    }

    public class Client
    {
        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("at")]
        public string LastUpdated { get; set; }

        [JsonProperty("creator_id")]
        public int CreatorID { get; set; }

        [JsonProperty("external_reference")]
        public string ExternalReference { get; set; }

        [JsonProperty("id")]
        public int ClientID { get; set; }

        [JsonProperty("integration_ext_id")]
        public string IntegrationExternalID { get; set; }

        [JsonProperty("integration_ext_type")]
        public string IntegrationExternalType { get; set; }

        [JsonProperty("integration_provider")]
        public JToken IntegrationProvider { get; set; }

        [JsonProperty("name")]
        public string ClientName { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("permissions")]
        public string[] Permissions { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("wid")]
        public int WorkspaceID { get; set; }
    }

    public class Project
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("actual_hours")]
        public int ActualHours { get; set; }

        [JsonProperty("actual_seconds")]
        public int ActualSeconds { get; set; }

        [JsonProperty("at")]
        public string LastUpdated { get; set; }

        [JsonProperty("auto_estimates")]
        public bool AutoEstimates { get; set; }

        [JsonProperty("billable")]
        public bool Billable { get; set; }

        [JsonProperty("can_track_time")]
        public bool CanTrackTime { get; set; }

        [JsonProperty("cid")]
        public int ClientIDLegacy { get; set; }

        [JsonProperty("client_id")]
        public int ClientID { get; set; }

        [JsonProperty("client_name")]
        public string ClientName { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("current_period")]
        public JToken CurrentPeriod { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("estimated_hours")]
        public int EstimatedHours { get; set; }

        [JsonProperty("estimated_seconds")]
        public int EstimatedSeconds { get; set; }

        [JsonProperty("external_reference")]
        public string ExternalReference { get; set; }

        [JsonProperty("fixed_fee")]
        public double FixedFee { get; set; }

        [JsonProperty("id")]
        public int ProjectID { get; set; }

        [JsonProperty("integration_ext_id")]
        public string IntegrationExternalID { get; set; }

        [JsonProperty("integration_ext_type")]
        public string IntegrationExternalType { get; set; }

        [JsonProperty("integration_provider")]
        public JToken IntegrationProvider { get; set; }

        [JsonProperty("is_private")]
        public bool IsPrivate { get; set; }

        [JsonProperty("name")]
        public string ProjectName { get; set; }

        [JsonProperty("permissions")]
        public string[] Permissions { get; set; }

        [JsonProperty("pinned")]
        public bool Pinned { get; set; }

        [JsonProperty("rate")]
        public double HourlyRate { get; set; }

        [JsonProperty("rate_last_updated")]
        public string RateLastUpdated { get; set; }

        [JsonProperty("recurring")]
        public bool Recurring { get; set; }

        [JsonProperty("recurring_parameters")]
        public RecurringParameter[] RecurringParameters { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("template")]
        public bool Template { get; set; }

        [JsonProperty("template_id")]
        public int TemplateID { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("wid")]
        public int WorkspaceIDLegacy { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceID { get; set; }
    }

    public class RecurringParameter
    {
        [JsonProperty("custom_period")]
        public int CustomPeriod { get; set; }

        [JsonProperty("estimated_seconds")]
        public int EstimatedSeconds { get; set; }

        [JsonProperty("parameter_end_date")]
        public string ParameterEndDate { get; set; }

        [JsonProperty("parameter_start_date")]
        public string ParameterStartDate { get; set; }

        [JsonProperty("period")]
        public string Period { get; set; }

        [JsonProperty("project_start_date")]
        public string ProjectStartDate { get; set; }
    }

    public class Tag
    {
        [JsonProperty("at")]
        public string LastModified { get; set; }

        [JsonProperty("creator_id")]
        public int CreatorID { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("id")]
        public int TagID { get; set; }

        [JsonProperty("integration_ext_id")]
        public string IntegrationExternalID { get; set; }

        [JsonProperty("integration_ext_type")]
        public string IntegrationExternalType { get; set; }

        [JsonProperty("integration_provider")]
        public JToken IntegrationProvider { get; set; }

        [JsonProperty("name")]
        public string TagName { get; set; }

        [JsonProperty("permissions")]
        public string[] Permissions { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceID { get; set; }
    }

    public class TaskObject
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("at")]
        public string LastModified { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarURL { get; set; }

        [JsonProperty("client_name")]
        public string ClientName { get; set; }

        [JsonProperty("estimated_seconds")]
        public int EstimatedSeconds { get; set; }

        [JsonProperty("id")]
        public int TaskID { get; set; }

        [JsonProperty("integration_ext_id")]
        public string IntegrationExternalID { get; set; }

        [JsonProperty("integration_ext_type")]
        public string IntegrationExternalType { get; set; }

        [JsonProperty("integration_provider")]
        public JToken IntegrationProvider { get; set; }

        [JsonProperty("name")]
        public string TaskName { get; set; }

        [JsonProperty("permissions")]
        public string[] Permissions { get; set; }

        [JsonProperty("project_billable")]
        public bool ProjectBillable { get; set; }

        [JsonProperty("project_color")]
        public string ProjectColor { get; set; }

        [JsonProperty("project_id")]
        public int ProjectID { get; set; }

        [JsonProperty("project_is_private")]
        public bool ProjectIsPrivate { get; set; }

        [JsonProperty("project_name")]
        public string ProjectName { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("rate_last_updated")]
        public string RateLastUpdated { get; set; }

        [JsonProperty("recurring")]
        public bool Recurring { get; set; }

        [JsonProperty("toggl_accounts_id")]
        public string TogglAccountsID { get; set; }

        [JsonProperty("tracked_seconds")]
        public int TrackedSeconds { get; set; }

        [JsonProperty("user_id")]
        public int UserID { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceID { get; set; }
    }

    public class TimeEntry
    {
        [JsonProperty("at")]
        public string LastUpdated { get; set; }

        [JsonProperty("billable")]
        public bool Billable { get; set; }

        [JsonProperty("client_name")]
        public string ClientName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("duronly")]
        public bool DurationOnly { get; set; }

        [JsonProperty("expense_ids")]
        public int[] ExpenseIDs { get; set; }

        [JsonProperty("id")]
        public int TimeEntryID { get; set; }

        [JsonProperty("permissions")]
        public string[] Permissions { get; set; }

        [JsonProperty("pid")]
        public int ProjectIDLegacy { get; set; }

        [JsonProperty("project_active")]
        public bool ProjectActive { get; set; }

        [JsonProperty("project_billable")]
        public bool ProjectBillable { get; set; }

        [JsonProperty("project_color")]
        public string ProjectColor { get; set; }

        [JsonProperty("project_id")]
        public int ProjectID { get; set; }

        [JsonProperty("project_name")]
        public string ProjectName { get; set; }

        [JsonProperty("shared_with")]
        public SharedWith[] SharedWith { get; set; }

        [JsonProperty("start")]
        public string StartTime { get; set; }

        [JsonProperty("stop")]
        public string StopTime { get; set; }

        [JsonProperty("tag_ids")]
        public int[] TagIDs { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("task_id")]
        public int TaskID { get; set; }

        [JsonProperty("task_name")]
        public string TaskName { get; set; }

        [JsonProperty("tid")]
        public int TaskIDLegacy { get; set; }

        [JsonProperty("uid")]
        public int UserIDLegacy { get; set; }

        [JsonProperty("user_avatar_url")]
        public string UserAvatarURL { get; set; }

        [JsonProperty("user_id")]
        public int UserID { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("wid")]
        public int WorkspaceIDLegacy { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceID { get; set; }
    }

    public class SharedWith
    {
        [JsonProperty("accepted")]
        public bool Accepted { get; set; }

        [JsonProperty("user_id")]
        public int UserID { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }
    }

    public class Workspace
    {
        [JsonProperty("active_project_count")]
        public int ActiveProjectCount { get; set; }

        [JsonProperty("admin")]
        public bool Admin { get; set; }

        [JsonProperty("api_token")]
        public string APIToken { get; set; }

        [JsonProperty("at")]
        public string LastChanged { get; set; }

        [JsonProperty("business_ws")]
        public bool BusinessWorkspace { get; set; }

        [JsonProperty("csv_upload")]
        public JToken CSVUpload { get; set; }

        [JsonProperty("default_currency")]
        public string DefaultCurrency { get; set; }

        [JsonProperty("default_hourly_rate")]
        public double DefaultHourlyRate { get; set; }

        [JsonProperty("disable_approvals")]
        public bool DisableApprovals { get; set; }

        [JsonProperty("disable_timesheet_view")]
        public bool DisableTimesheetView { get; set; }

        [JsonProperty("hide_start_end_times")]
        public bool HideStartEndTimes { get; set; }

        [JsonProperty("ical_enabled")]
        public bool ICalEnabled { get; set; }

        [JsonProperty("ical_url")]
        public string ICalURL { get; set; }

        [JsonProperty("id")]
        public int WorkspaceID { get; set; }

        [JsonProperty("last_modified")]
        public string LastModified { get; set; }

        [JsonProperty("limit_public_project_data")]
        public bool LimitPublicProjectData { get; set; }

        [JsonProperty("logo_url")]
        public string LogoURL { get; set; }

        [JsonProperty("max_data_retention_days")]
        public JToken MaxDataRetentionDays { get; set; }

        [JsonProperty("name")]
        public string WorkspaceName { get; set; }

        [JsonProperty("only_admins_may_create_projects")]
        public bool OnlyAdminsMayCreateProjects { get; set; }

        [JsonProperty("only_admins_may_create_tags")]
        public bool OnlyAdminsMayCreateTags { get; set; }

        [JsonProperty("only_admins_see_team_dashboard")]
        public bool OnlyAdminsSeeTeamDashboard { get; set; }

        [JsonProperty("organization_id")]
        public int OrganizationID { get; set; }

        [JsonProperty("permissions")]
        public string[] Permissions { get; set; }

        [JsonProperty("premium")]
        public bool Premium { get; set; }

        [JsonProperty("projects_billable_by_default")]
        public bool ProjectsBillableByDefault { get; set; }

        [JsonProperty("projects_enforce_billable")]
        public bool ProjectsEnforceBillable { get; set; }

        [JsonProperty("projects_private_by_default")]
        public bool ProjectsPrivateByDefault { get; set; }

        [JsonProperty("rate_last_updated")]
        public string RateLastUpdated { get; set; }

        [JsonProperty("reports_collapse")]
        public bool ReportsCollapse { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("rounding")]
        public int Rounding { get; set; }

        [JsonProperty("rounding_minutes")]
        public int RoundingMinutes { get; set; }

        [JsonProperty("subscription")]
        public JToken Subscription { get; set; }

        [JsonProperty("suspended_at")]
        public string SuspendedAt { get; set; }

        [JsonProperty("te_constraints")]
        public JToken TimeEntryConstraints { get; set; }

        [JsonProperty("working_hours_in_minutes")]
        public int WorkingHoursInMinutes { get; set; }
    }

    public class UserBasicResponse
    {
        [JsonProperty("2fa_enabled")]
        public bool _2FAEnabled { get; set; }

        [JsonProperty("api_token")]
        public string APIToken { get; set; }

        [JsonProperty("at")]
        public string LastUpdated { get; set; }

        [JsonProperty("beginning_of_week")]
        public int BeginningOfWeek { get; set; }

        [JsonProperty("country_id")]
        public int CountryID { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("default_workspace_id")]
        public int DefaultWorkspaceID { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("fullname")]
        public string FullName { get; set; }

        [JsonProperty("has_password")]
        public bool HasPassword { get; set; }

        [JsonProperty("id")]
        public int UserID { get; set; }

        [JsonProperty("image_url")]
        public string ImageURL { get; set; }

        [JsonProperty("openid_email")]
        public string OpenIDEmail { get; set; }

        [JsonProperty("openid_enabled")]
        public bool OpenIDEnabled { get; set; }

        [JsonProperty("options")]
        public JToken Options { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class WorkspaceFeatures
    {
        [JsonProperty("features")]
        public Feature[] Features { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceID { get; set; }
    }

    public class Feature
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("feature_id")]
        public int FeatureID { get; set; }

        [JsonProperty("name")]
        public string FeatureName { get; set; }
    }

    public class LocationResponse
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("city_lat_long")]
        public string CityCoordinates { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class Organization
    {
        [JsonProperty("admin")]
        public bool Admin { get; set; }

        [JsonProperty("at")]
        public string LastModified { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public int OrganizationID { get; set; }

        [JsonProperty("is_multi_workspace_enabled")]
        public bool MultiWorkspaceEnabled { get; set; }

        [JsonProperty("is_unified")]
        public bool IsUnified { get; set; }

        [JsonProperty("max_data_retention_days")]
        public JToken MaxDataRetentionDays { get; set; }

        [JsonProperty("max_workspaces")]
        public int MaxWorkspaces { get; set; }

        [JsonProperty("name")]
        public string OrganizationName { get; set; }

        [JsonProperty("owner")]
        public bool Owner { get; set; }

        [JsonProperty("permissions")]
        public string[] Permissions { get; set; }

        [JsonProperty("pricing_plan_enterprise")]
        public bool PricingPlanEnterprise { get; set; }

        [JsonProperty("pricing_plan_id")]
        public int PricingPlanID { get; set; }

        [JsonProperty("pricing_plan_name")]
        public string PricingPlanName { get; set; }

        [JsonProperty("suspended_at")]
        public string SuspendedAt { get; set; }

        [JsonProperty("trial_info")]
        public TrialInfo TrialInfo { get; set; }

        [JsonProperty("user_count")]
        public int UserCount { get; set; }
    }

    public class TrialInfo
    {
        [JsonProperty("can_have_trial")]
        public bool CanHaveTrial { get; set; }

        [JsonProperty("last_pricing_plan_id")]
        public int LastPricingPlanID { get; set; }

        [JsonProperty("next_payment_date")]
        public string NextPaymentDate { get; set; }

        [JsonProperty("trial")]
        public bool Trial { get; set; }

        [JsonProperty("trial_available")]
        public bool TrialAvailable { get; set; }

        [JsonProperty("trial_end_date")]
        public string TrialEndDate { get; set; }

        [JsonProperty("trial_plan_id")]
        public int TrialPlanID { get; set; }
    }

    public class TrackReminder
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("group_ids")]
        public int[] GroupIDs { get; set; }

        [JsonProperty("reminder_id")]
        public int ReminderID { get; set; }

        [JsonProperty("threshold")]
        public int Threshold { get; set; }

        [JsonProperty("user_ids")]
        public int[] UserIDs { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceID { get; set; }
    }

    public enum bodytagActionInput
    {
        [EnumMember(Value = "add")]
        Add,
        [EnumMember(Value = "delete")]
        Delete
    }

    public class BulkEditResponse
    {
        [JsonProperty("failure")]
        public BulkEditFailure[] Failures { get; set; }

        [JsonProperty("success")]
        public int[] SuccessIDs { get; set; }
    }

    public class BulkEditFailure
    {
        [JsonProperty("id")]
        public int FailedID { get; set; }

        [JsonProperty("message")]
        public string ErrorMessage { get; set; }
    }

    public class PatchOperation
    {
        [JsonProperty("op")]
        public PatchOperationOperationType Operation { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }

    public enum PatchOperationOperationType
    {
        [EnumMember(Value = "add")]
        Add,
        [EnumMember(Value = "remove")]
        Remove,
        [EnumMember(Value = "replace")]
        Replace
    }

    public class WorkspaceUser
    {
        [JsonProperty("2fa_enabled")]
        public bool _2FAEnabled { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("admin")]
        public bool Admin { get; set; }

        [JsonProperty("at")]
        public string LastUpdated { get; set; }

        [JsonProperty("avatar_file_name")]
        public string AvatarURL { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("group_ids")]
        public int[] GroupIDs { get; set; }

        [JsonProperty("id")]
        public int UserWorkspaceID { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("invitation_code")]
        public string InvitationCode { get; set; }

        [JsonProperty("invite_url")]
        public string InviteURL { get; set; }

        [JsonProperty("is_direct")]
        public bool IsDirectMember { get; set; }

        [JsonProperty("labor_cost")]
        public double LaborCost { get; set; }

        [JsonProperty("labor_cost_last_updated")]
        public string LaborCostLastUpdated { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organization_admin")]
        public bool OrganizationAdmin { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("rate_last_updated")]
        public string RateLastUpdated { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("role_id")]
        public int RoleID { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("uid")]
        public int GlobalUserID { get; set; }

        [JsonProperty("user_id")]
        public int UserID { get; set; }

        [JsonProperty("view_edit_billable_rates")]
        public bool ViewEditBillableRates { get; set; }

        [JsonProperty("view_edit_labor_costs")]
        public bool ViewEditLaborCosts { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceID { get; set; }

        [JsonProperty("working_hours_in_minutes")]
        public int WorkingHoursInMinutes { get; set; }

        [JsonProperty("workspace_admin")]
        public bool WorkspaceAdmin { get; set; }
    }

    public class Rate
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("creator_id")]
        public int CreatorID { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("end")]
        public string EndDate { get; set; }

        [JsonProperty("id")]
        public int RateID { get; set; }

        [JsonProperty("planned_task_id")]
        public int PlannedTaskID { get; set; }

        [JsonProperty("project_id")]
        public int ProjectID { get; set; }

        [JsonProperty("project_user_id")]
        public int ProjectUserID { get; set; }

        [JsonProperty("rate_change_mode")]
        public string RateChangeMode { get; set; }

        [JsonProperty("start")]
        public string StartDate { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceID { get; set; }

        [JsonProperty("workspace_user_id")]
        public int WorkspaceUserID { get; set; }
    }

    public enum levelInput
    {
        [EnumMember(Value = "workspace")]
        Workspace,
        [EnumMember(Value = "project")]
        Project,
        [EnumMember(Value = "task")]
        TaskObject,
        [EnumMember(Value = "user")]
        User
    }

    public enum typeInput
    {
        [EnumMember(Value = "billable_rates")]
        BillableRates,
        [EnumMember(Value = "labor_costs")]
        LaborCosts
    }

    public class WorkspaceStatistics
    {
        [JsonProperty("admins")]
        public WorkspaceAdmin[] Admins { get; set; }

        [JsonProperty("groups_count")]
        public int GroupsCount { get; set; }

        [JsonProperty("members_count")]
        public int MembersCount { get; set; }
    }

    public class WorkspaceAdmin
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("user_id")]
        public int UserID { get; set; }
    }

    public class TimeEntryConstraints
    {
        [JsonProperty("description_present")]
        public bool DescriptionRequired { get; set; }

        [JsonProperty("project_present")]
        public bool ProjectRequired { get; set; }

        [JsonProperty("tag_present")]
        public bool TagRequired { get; set; }

        [JsonProperty("task_present")]
        public bool TaskRequired { get; set; }

        [JsonProperty("time_entry_constraints_enabled")]
        public bool ConstraintsEnabled { get; set; }
    }

    public class TrackRemindersResponse
    {
        [JsonProperty("items")]
        public TrackReminder[] TrackReminders { get; set; }
    }

    public class WorkspaceUserSimple
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("fullname")]
        public string FullName { get; set; }

        [JsonProperty("id")]
        public int UserID { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("is_active")]
        public bool IsActive { get; set; }

        [JsonProperty("is_admin")]
        public bool IsAdminDeprecated { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }

    public class ProjectUser
    {
        [JsonProperty("at")]
        public string LastModified { get; set; }

        [JsonProperty("gid")]
        public int GroupIDLegacy { get; set; }

        [JsonProperty("group_id")]
        public int GroupID { get; set; }

        [JsonProperty("id")]
        public int ProjectUserID { get; set; }

        [JsonProperty("labor_cost")]
        public double LaborCost { get; set; }

        [JsonProperty("labor_cost_last_updated")]
        public string LaborCostLastUpdated { get; set; }

        [JsonProperty("manager")]
        public bool Manager { get; set; }

        [JsonProperty("project_id")]
        public int ProjectID { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("rate_last_updated")]
        public string RateLastUpdated { get; set; }

        [JsonProperty("user_id")]
        public int UserID { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceID { get; set; }
    }

    public enum sortOrderInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class WebhookSubscription
    {
        [JsonProperty("subscription_id")]
        public int SubscriptionID { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceID { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url_callback")]
        public string CallbackURL { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("validated_at")]
        public string ValidatedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("event_filters")]
        public EventFilter[] EventFilters { get; set; }
    }

    public class EventFilter
    {
        [JsonProperty("entity")]
        public string Entity { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Toggltrack;

    public partial class WorkflowManagedActions
    {
        public ToggltrackActions Toggltrack(string connectionId) => new ToggltrackActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ToggltrackTriggers Toggltrack(string connectionId) => new ToggltrackTriggers(connectionId);
    }
}