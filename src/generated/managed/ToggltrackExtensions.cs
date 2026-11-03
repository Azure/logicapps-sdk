//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Toggltrack
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ToggltrackActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<UserResponse, ApiConnectionActionConfiguration> GetMe(Expression<Func<bool>> withRelatedData = null)
        {
            var __workflow_withRelatedData = WorkflowExpression.Compile(withRelatedData, nameof(withRelatedData), required: false);
            return new DeferredBodyAction<UserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["with_related_data"] = Convert.ToString(false);
                if (__workflow_withRelatedData != null)
                    callPayload.Queries["with_related_data"] = ExpressionConverter.Convert(__workflow_withRelatedData);
                return new ApiConnectionAction<UserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<UserBasicResponse, ApiConnectionActionConfiguration> UpdateMe(Expression<Func<int>> bodybeginningOfWeek = null, Expression<Func<int>> bodycountryId = null, Expression<Func<string>> bodycurrentPassword = null, Expression<Func<int>> bodydefaultWorkspaceId = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyfullName = null, Expression<Func<string>> bodynewPassword = null, Expression<Func<string>> bodytimezone = null)
        {
            var __workflow_bodybeginningOfWeek = WorkflowExpression.Compile(bodybeginningOfWeek, nameof(bodybeginningOfWeek), required: false);
            var __workflow_bodycountryId = WorkflowExpression.Compile(bodycountryId, nameof(bodycountryId), required: false);
            var __workflow_bodycurrentPassword = WorkflowExpression.Compile(bodycurrentPassword, nameof(bodycurrentPassword), required: false);
            var __workflow_bodydefaultWorkspaceId = WorkflowExpression.Compile(bodydefaultWorkspaceId, nameof(bodydefaultWorkspaceId), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyfullName = WorkflowExpression.Compile(bodyfullName, nameof(bodyfullName), required: false);
            var __workflow_bodynewPassword = WorkflowExpression.Compile(bodynewPassword, nameof(bodynewPassword), required: false);
            var __workflow_bodytimezone = WorkflowExpression.Compile(bodytimezone, nameof(bodytimezone), required: false);
            return new DeferredBodyAction<UserBasicResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/me";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodybeginningOfWeek != null)
                {
                    body["beginning_of_week"] = ExpressionConverter.ConvertO(__workflow_bodybeginningOfWeek);
                    bodypropCount++;
                }

                if (__workflow_bodycountryId != null)
                {
                    body["country_id"] = ExpressionConverter.ConvertO(__workflow_bodycountryId);
                    bodypropCount++;
                }

                if (__workflow_bodycurrentPassword != null)
                {
                    body["current_password"] = ExpressionConverter.ConvertO(__workflow_bodycurrentPassword);
                    bodypropCount++;
                }

                if (__workflow_bodydefaultWorkspaceId != null)
                {
                    body["default_workspace_id"] = ExpressionConverter.ConvertO(__workflow_bodydefaultWorkspaceId);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyfullName != null)
                {
                    body["fullname"] = ExpressionConverter.ConvertO(__workflow_bodyfullName);
                    bodypropCount++;
                }

                if (__workflow_bodynewPassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodynewPassword);
                    bodypropCount++;
                }

                if (__workflow_bodytimezone != null)
                {
                    body["timezone"] = ExpressionConverter.ConvertO(__workflow_bodytimezone);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UserBasicResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Client[], ApiConnectionActionConfiguration> GetMeClients(Expression<Func<int>> since = null)
        {
            var __workflow_since = WorkflowExpression.Compile(since, nameof(since), required: false);
            return new DeferredBodyAction<Client[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/me/clients";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_since != null)
                    callPayload.Queries["since"] = ExpressionConverter.Convert(__workflow_since);
                return new ApiConnectionAction<Client[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<WorkspaceFeatures[], ApiConnectionActionConfiguration> GetMeFeatures()
        {
            return new DeferredBodyAction<WorkspaceFeatures[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/me/features";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<WorkspaceFeatures[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<LocationResponse, ApiConnectionActionConfiguration> GetMeLocation()
        {
            return new DeferredBodyAction<LocationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/me/location";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetMeLogged()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/me/logged";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Organization[], ApiConnectionActionConfiguration> GetMeOrganizations()
        {
            return new DeferredBodyAction<Organization[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/me/organizations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Organization[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Project[], ApiConnectionActionConfiguration> GetMeProjects(Expression<Func<string>> includeArchived = null, Expression<Func<int>> since = null)
        {
            var __workflow_includeArchived = WorkflowExpression.Compile(includeArchived, nameof(includeArchived), required: false);
            var __workflow_since = WorkflowExpression.Compile(since, nameof(since), required: false);
            return new DeferredBodyAction<Project[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/me/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeArchived != null)
                    callPayload.Queries["include_archived"] = ExpressionConverter.Convert(__workflow_includeArchived);
                if (__workflow_since != null)
                    callPayload.Queries["since"] = ExpressionConverter.Convert(__workflow_since);
                return new ApiConnectionAction<Project[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Project[], ApiConnectionActionConfiguration> GetMeProjectsPaginated(Expression<Func<int>> startProjectId = null, Expression<Func<int>> since = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_startProjectId = WorkflowExpression.Compile(startProjectId, nameof(startProjectId), required: false);
            var __workflow_since = WorkflowExpression.Compile(since, nameof(since), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<Project[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/me/projects/paginated";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_startProjectId != null)
                    callPayload.Queries["start_project_id"] = ExpressionConverter.Convert(__workflow_startProjectId);
                if (__workflow_since != null)
                    callPayload.Queries["since"] = ExpressionConverter.Convert(__workflow_since);
                callPayload.Queries["per_page"] = Convert.ToString(201);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<Project[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Tag[], ApiConnectionActionConfiguration> GetMeTags(Expression<Func<int>> since = null)
        {
            var __workflow_since = WorkflowExpression.Compile(since, nameof(since), required: false);
            return new DeferredBodyAction<Tag[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/me/tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_since != null)
                    callPayload.Queries["since"] = ExpressionConverter.Convert(__workflow_since);
                return new ApiConnectionAction<Tag[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TaskObject[], ApiConnectionActionConfiguration> GetMeTasks(Expression<Func<bool>> meta = null, Expression<Func<int>> since = null, Expression<Func<string>> includeNotActive = null, Expression<Func<int>> offset = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_meta = WorkflowExpression.Compile(meta, nameof(meta), required: false);
            var __workflow_since = WorkflowExpression.Compile(since, nameof(since), required: false);
            var __workflow_includeNotActive = WorkflowExpression.Compile(includeNotActive, nameof(includeNotActive), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<TaskObject[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/me/tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["meta"] = Convert.ToString(false);
                if (__workflow_meta != null)
                    callPayload.Queries["meta"] = ExpressionConverter.Convert(__workflow_meta);
                if (__workflow_since != null)
                    callPayload.Queries["since"] = ExpressionConverter.Convert(__workflow_since);
                if (__workflow_includeNotActive != null)
                    callPayload.Queries["include_not_active"] = ExpressionConverter.Convert(__workflow_includeNotActive);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["per_page"] = Convert.ToString(201);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<TaskObject[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TrackReminder[], ApiConnectionActionConfiguration> GetMeTrackReminders()
        {
            return new DeferredBodyAction<TrackReminder[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/me/track_reminders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TrackReminder[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetMeWebTimer()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/me/web-timer";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Workspace[], ApiConnectionActionConfiguration> GetMeWorkspaces(Expression<Func<int>> since = null)
        {
            var __workflow_since = WorkflowExpression.Compile(since, nameof(since), required: false);
            return new DeferredBodyAction<Workspace[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/me/workspaces";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_since != null)
                    callPayload.Queries["since"] = ExpressionConverter.Convert(__workflow_since);
                return new ApiConnectionAction<Workspace[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TimeEntry[], ApiConnectionActionConfiguration> GetMeTimeEntries(Expression<Func<bool>> meta = null, Expression<Func<bool>> includeSharing = null, Expression<Func<int>> since = null, Expression<Func<string>> before = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null)
        {
            var __workflow_meta = WorkflowExpression.Compile(meta, nameof(meta), required: false);
            var __workflow_includeSharing = WorkflowExpression.Compile(includeSharing, nameof(includeSharing), required: false);
            var __workflow_since = WorkflowExpression.Compile(since, nameof(since), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            return new DeferredBodyAction<TimeEntry[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/me/time_entries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["meta"] = Convert.ToString(false);
                if (__workflow_meta != null)
                    callPayload.Queries["meta"] = ExpressionConverter.Convert(__workflow_meta);
                callPayload.Queries["include_sharing"] = Convert.ToString(false);
                if (__workflow_includeSharing != null)
                    callPayload.Queries["include_sharing"] = ExpressionConverter.Convert(__workflow_includeSharing);
                if (__workflow_since != null)
                    callPayload.Queries["since"] = ExpressionConverter.Convert(__workflow_since);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_startDate != null)
                    callPayload.Queries["start_date"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(__workflow_endDate);
                return new ApiConnectionAction<TimeEntry[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TimeEntry, ApiConnectionActionConfiguration> GetCurrentTimeEntry()
        {
            return new DeferredBodyAction<TimeEntry, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/me/time_entries/current";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TimeEntry>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TimeEntry, ApiConnectionActionConfiguration> GetTimeEntryById(Expression<Func<int>> timeEntryId, Expression<Func<bool>> meta = null, Expression<Func<bool>> includeSharing = null)
        {
            var __workflow_timeEntryId = WorkflowExpression.Compile(timeEntryId, nameof(timeEntryId), required: true);
            var __workflow_meta = WorkflowExpression.Compile(meta, nameof(meta), required: false);
            var __workflow_includeSharing = WorkflowExpression.Compile(includeSharing, nameof(includeSharing), required: false);
            return new DeferredBodyAction<TimeEntry, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/me/time_entries/{0}", __workflow_timeEntryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["meta"] = Convert.ToString(false);
                if (__workflow_meta != null)
                    callPayload.Queries["meta"] = ExpressionConverter.Convert(__workflow_meta);
                callPayload.Queries["include_sharing"] = Convert.ToString(false);
                if (__workflow_includeSharing != null)
                    callPayload.Queries["include_sharing"] = ExpressionConverter.Convert(__workflow_includeSharing);
                return new ApiConnectionAction<TimeEntry>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TimeEntry, ApiConnectionActionConfiguration> CreateTimeEntry(Expression<Func<int>> workspaceId, Expression<Func<bool>> meta = null, Expression<Func<bool>> bodybillable = null, Expression<Func<string>> bodycreatedWith = null, Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodyduration = null, Expression<Func<bool>> bodydurationOnly = null, Expression<Func<string>> bodyeventMetadataoriginFeature = null, Expression<Func<int>> bodyeventMetadatavisibleGoalsCount = null, Expression<Func<int[]>> bodyexpenseIDs = null, Expression<Func<int>> bodyprojectIdLegacy = null, Expression<Func<int>> bodyprojectId = null, Expression<Func<int[]>> bodysharedWithUserIDs = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodystopTime = null, Expression<Func<bodytagActionInput>> bodytagAction = null, Expression<Func<int[]>> bodytagIDs = null, Expression<Func<string[]>> bodytags = null, Expression<Func<int>> bodytaskId = null, Expression<Func<int>> bodytaskIdLegacy = null, Expression<Func<int>> bodyuserIdLegacy = null, Expression<Func<int>> bodyuserId = null, Expression<Func<int>> bodyworkspaceIdLegacy = null, Expression<Func<int>> bodyworkspaceId = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_meta = WorkflowExpression.Compile(meta, nameof(meta), required: false);
            var __workflow_bodybillable = WorkflowExpression.Compile(bodybillable, nameof(bodybillable), required: false);
            var __workflow_bodycreatedWith = WorkflowExpression.Compile(bodycreatedWith, nameof(bodycreatedWith), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyduration = WorkflowExpression.Compile(bodyduration, nameof(bodyduration), required: false);
            var __workflow_bodydurationOnly = WorkflowExpression.Compile(bodydurationOnly, nameof(bodydurationOnly), required: false);
            var __workflow_bodyeventMetadataoriginFeature = WorkflowExpression.Compile(bodyeventMetadataoriginFeature, nameof(bodyeventMetadataoriginFeature), required: false);
            var __workflow_bodyeventMetadatavisibleGoalsCount = WorkflowExpression.Compile(bodyeventMetadatavisibleGoalsCount, nameof(bodyeventMetadatavisibleGoalsCount), required: false);
            var __workflow_bodyexpenseIDs = WorkflowExpression.Compile(bodyexpenseIDs, nameof(bodyexpenseIDs), required: false);
            var __workflow_bodyprojectIdLegacy = WorkflowExpression.Compile(bodyprojectIdLegacy, nameof(bodyprojectIdLegacy), required: false);
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: false);
            var __workflow_bodysharedWithUserIDs = WorkflowExpression.Compile(bodysharedWithUserIDs, nameof(bodysharedWithUserIDs), required: false);
            var __workflow_bodystartTime = WorkflowExpression.Compile(bodystartTime, nameof(bodystartTime), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodystopTime = WorkflowExpression.Compile(bodystopTime, nameof(bodystopTime), required: false);
            var __workflow_bodytagAction = WorkflowExpression.Compile(bodytagAction, nameof(bodytagAction), required: false);
            var __workflow_bodytagIDs = WorkflowExpression.Compile(bodytagIDs, nameof(bodytagIDs), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            var __workflow_bodytaskId = WorkflowExpression.Compile(bodytaskId, nameof(bodytaskId), required: false);
            var __workflow_bodytaskIdLegacy = WorkflowExpression.Compile(bodytaskIdLegacy, nameof(bodytaskIdLegacy), required: false);
            var __workflow_bodyuserIdLegacy = WorkflowExpression.Compile(bodyuserIdLegacy, nameof(bodyuserIdLegacy), required: false);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
            var __workflow_bodyworkspaceIdLegacy = WorkflowExpression.Compile(bodyworkspaceIdLegacy, nameof(bodyworkspaceIdLegacy), required: false);
            var __workflow_bodyworkspaceId = WorkflowExpression.Compile(bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            return new DeferredBodyAction<TimeEntry, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workspaces/{0}/time_entries", __workflow_workspaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["meta"] = Convert.ToString(false);
                if (__workflow_meta != null)
                    callPayload.Queries["meta"] = ExpressionConverter.Convert(__workflow_meta);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodybillable != null)
                {
                    body["billable"] = ExpressionConverter.ConvertO(__workflow_bodybillable);
                    bodypropCount++;
                }

                if (__workflow_bodycreatedWith != null)
                {
                    body["created_with"] = ExpressionConverter.ConvertO(__workflow_bodycreatedWith);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyduration != null)
                {
                    body["duration"] = ExpressionConverter.ConvertO(__workflow_bodyduration);
                    bodypropCount++;
                }

                if (__workflow_bodydurationOnly != null)
                {
                    body["duronly"] = ExpressionConverter.ConvertO(__workflow_bodydurationOnly);
                    bodypropCount++;
                }

                var eventMetadataObject = new JObject();
                var eventMetadataObjectpropCount = 0;
                if (__workflow_bodyeventMetadataoriginFeature != null)
                {
                    eventMetadataObject["origin_feature"] = ExpressionConverter.ConvertO(__workflow_bodyeventMetadataoriginFeature);
                    eventMetadataObjectpropCount++;
                }

                if (__workflow_bodyeventMetadatavisibleGoalsCount != null)
                {
                    eventMetadataObject["visible_goals_count"] = ExpressionConverter.ConvertO(__workflow_bodyeventMetadatavisibleGoalsCount);
                    eventMetadataObjectpropCount++;
                }

                if (eventMetadataObjectpropCount > 0)
                {
                    body["event_metadata"] = eventMetadataObject;
                    bodypropCount++;
                }

                if (__workflow_bodyexpenseIDs != null)
                {
                    body["expense_ids"] = ExpressionConverter.ConvertO(__workflow_bodyexpenseIDs);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectIdLegacy != null)
                {
                    body["pid"] = ExpressionConverter.ConvertO(__workflow_bodyprojectIdLegacy);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectId != null)
                {
                    body["project_id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                    bodypropCount++;
                }

                if (__workflow_bodysharedWithUserIDs != null)
                {
                    body["shared_with_user_ids"] = ExpressionConverter.ConvertO(__workflow_bodysharedWithUserIDs);
                    bodypropCount++;
                }

                if (__workflow_bodystartTime != null)
                {
                    body["start"] = ExpressionConverter.ConvertO(__workflow_bodystartTime);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["start_date"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodystopTime != null)
                {
                    body["stop"] = ExpressionConverter.ConvertO(__workflow_bodystopTime);
                    bodypropCount++;
                }

                if (__workflow_bodytagAction != null)
                {
                    body["tag_action"] = ExpressionConverter.ConvertO(__workflow_bodytagAction);
                    bodypropCount++;
                }

                if (__workflow_bodytagIDs != null)
                {
                    body["tag_ids"] = ExpressionConverter.ConvertO(__workflow_bodytagIDs);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (__workflow_bodytaskId != null)
                {
                    body["task_id"] = ExpressionConverter.ConvertO(__workflow_bodytaskId);
                    bodypropCount++;
                }

                if (__workflow_bodytaskIdLegacy != null)
                {
                    body["tid"] = ExpressionConverter.ConvertO(__workflow_bodytaskIdLegacy);
                    bodypropCount++;
                }

                if (__workflow_bodyuserIdLegacy != null)
                {
                    body["uid"] = ExpressionConverter.ConvertO(__workflow_bodyuserIdLegacy);
                    bodypropCount++;
                }

                if (__workflow_bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (__workflow_bodyworkspaceIdLegacy != null)
                {
                    body["wid"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceIdLegacy);
                    bodypropCount++;
                }

                if (__workflow_bodyworkspaceId != null)
                {
                    body["workspace_id"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TimeEntry>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteTimeEntry(Expression<Func<int>> workspaceId, Expression<Func<int>> timeEntryId)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_timeEntryId = WorkflowExpression.Compile(timeEntryId, nameof(timeEntryId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workspaces/{0}/time_entries/{1}", __workflow_workspaceId.WithUrlEncoding(1), __workflow_timeEntryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TimeEntry, ApiConnectionActionConfiguration> UpdateTimeEntry(Expression<Func<int>> workspaceId, Expression<Func<int>> timeEntryId, Expression<Func<bool>> meta = null, Expression<Func<bool>> includeSharing = null, Expression<Func<bool>> bodybillable = null, Expression<Func<string>> bodycreatedWith = null, Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodyduration = null, Expression<Func<bool>> bodydurationOnly = null, Expression<Func<string>> bodyeventMetadataoriginFeature = null, Expression<Func<int>> bodyeventMetadatavisibleGoalsCount = null, Expression<Func<int[]>> bodyexpenseIDs = null, Expression<Func<int>> bodyprojectIdLegacy = null, Expression<Func<int>> bodyprojectId = null, Expression<Func<int[]>> bodysharedWithUserIDs = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodystopTime = null, Expression<Func<bodytagActionInput>> bodytagAction = null, Expression<Func<int[]>> bodytagIDs = null, Expression<Func<string[]>> bodytags = null, Expression<Func<int>> bodytaskId = null, Expression<Func<int>> bodytaskIdLegacy = null, Expression<Func<int>> bodyuserIdLegacy = null, Expression<Func<int>> bodyuserId = null, Expression<Func<int>> bodyworkspaceIdLegacy = null, Expression<Func<int>> bodyworkspaceId = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_timeEntryId = WorkflowExpression.Compile(timeEntryId, nameof(timeEntryId), required: true);
            var __workflow_meta = WorkflowExpression.Compile(meta, nameof(meta), required: false);
            var __workflow_includeSharing = WorkflowExpression.Compile(includeSharing, nameof(includeSharing), required: false);
            var __workflow_bodybillable = WorkflowExpression.Compile(bodybillable, nameof(bodybillable), required: false);
            var __workflow_bodycreatedWith = WorkflowExpression.Compile(bodycreatedWith, nameof(bodycreatedWith), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyduration = WorkflowExpression.Compile(bodyduration, nameof(bodyduration), required: false);
            var __workflow_bodydurationOnly = WorkflowExpression.Compile(bodydurationOnly, nameof(bodydurationOnly), required: false);
            var __workflow_bodyeventMetadataoriginFeature = WorkflowExpression.Compile(bodyeventMetadataoriginFeature, nameof(bodyeventMetadataoriginFeature), required: false);
            var __workflow_bodyeventMetadatavisibleGoalsCount = WorkflowExpression.Compile(bodyeventMetadatavisibleGoalsCount, nameof(bodyeventMetadatavisibleGoalsCount), required: false);
            var __workflow_bodyexpenseIDs = WorkflowExpression.Compile(bodyexpenseIDs, nameof(bodyexpenseIDs), required: false);
            var __workflow_bodyprojectIdLegacy = WorkflowExpression.Compile(bodyprojectIdLegacy, nameof(bodyprojectIdLegacy), required: false);
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: false);
            var __workflow_bodysharedWithUserIDs = WorkflowExpression.Compile(bodysharedWithUserIDs, nameof(bodysharedWithUserIDs), required: false);
            var __workflow_bodystartTime = WorkflowExpression.Compile(bodystartTime, nameof(bodystartTime), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodystopTime = WorkflowExpression.Compile(bodystopTime, nameof(bodystopTime), required: false);
            var __workflow_bodytagAction = WorkflowExpression.Compile(bodytagAction, nameof(bodytagAction), required: false);
            var __workflow_bodytagIDs = WorkflowExpression.Compile(bodytagIDs, nameof(bodytagIDs), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            var __workflow_bodytaskId = WorkflowExpression.Compile(bodytaskId, nameof(bodytaskId), required: false);
            var __workflow_bodytaskIdLegacy = WorkflowExpression.Compile(bodytaskIdLegacy, nameof(bodytaskIdLegacy), required: false);
            var __workflow_bodyuserIdLegacy = WorkflowExpression.Compile(bodyuserIdLegacy, nameof(bodyuserIdLegacy), required: false);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
            var __workflow_bodyworkspaceIdLegacy = WorkflowExpression.Compile(bodyworkspaceIdLegacy, nameof(bodyworkspaceIdLegacy), required: false);
            var __workflow_bodyworkspaceId = WorkflowExpression.Compile(bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            return new DeferredBodyAction<TimeEntry, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workspaces/{0}/time_entries/{1}", __workflow_workspaceId.WithUrlEncoding(1), __workflow_timeEntryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["meta"] = Convert.ToString(false);
                if (__workflow_meta != null)
                    callPayload.Queries["meta"] = ExpressionConverter.Convert(__workflow_meta);
                callPayload.Queries["include_sharing"] = Convert.ToString(false);
                if (__workflow_includeSharing != null)
                    callPayload.Queries["include_sharing"] = ExpressionConverter.Convert(__workflow_includeSharing);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodybillable != null)
                {
                    body["billable"] = ExpressionConverter.ConvertO(__workflow_bodybillable);
                    bodypropCount++;
                }

                if (__workflow_bodycreatedWith != null)
                {
                    body["created_with"] = ExpressionConverter.ConvertO(__workflow_bodycreatedWith);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyduration != null)
                {
                    body["duration"] = ExpressionConverter.ConvertO(__workflow_bodyduration);
                    bodypropCount++;
                }

                if (__workflow_bodydurationOnly != null)
                {
                    body["duronly"] = ExpressionConverter.ConvertO(__workflow_bodydurationOnly);
                    bodypropCount++;
                }

                var eventMetadataObject = new JObject();
                var eventMetadataObjectpropCount = 0;
                if (__workflow_bodyeventMetadataoriginFeature != null)
                {
                    eventMetadataObject["origin_feature"] = ExpressionConverter.ConvertO(__workflow_bodyeventMetadataoriginFeature);
                    eventMetadataObjectpropCount++;
                }

                if (__workflow_bodyeventMetadatavisibleGoalsCount != null)
                {
                    eventMetadataObject["visible_goals_count"] = ExpressionConverter.ConvertO(__workflow_bodyeventMetadatavisibleGoalsCount);
                    eventMetadataObjectpropCount++;
                }

                if (eventMetadataObjectpropCount > 0)
                {
                    body["event_metadata"] = eventMetadataObject;
                    bodypropCount++;
                }

                if (__workflow_bodyexpenseIDs != null)
                {
                    body["expense_ids"] = ExpressionConverter.ConvertO(__workflow_bodyexpenseIDs);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectIdLegacy != null)
                {
                    body["pid"] = ExpressionConverter.ConvertO(__workflow_bodyprojectIdLegacy);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectId != null)
                {
                    body["project_id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                    bodypropCount++;
                }

                if (__workflow_bodysharedWithUserIDs != null)
                {
                    body["shared_with_user_ids"] = ExpressionConverter.ConvertO(__workflow_bodysharedWithUserIDs);
                    bodypropCount++;
                }

                if (__workflow_bodystartTime != null)
                {
                    body["start"] = ExpressionConverter.ConvertO(__workflow_bodystartTime);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["start_date"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodystopTime != null)
                {
                    body["stop"] = ExpressionConverter.ConvertO(__workflow_bodystopTime);
                    bodypropCount++;
                }

                if (__workflow_bodytagAction != null)
                {
                    body["tag_action"] = ExpressionConverter.ConvertO(__workflow_bodytagAction);
                    bodypropCount++;
                }

                if (__workflow_bodytagIDs != null)
                {
                    body["tag_ids"] = ExpressionConverter.ConvertO(__workflow_bodytagIDs);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (__workflow_bodytaskId != null)
                {
                    body["task_id"] = ExpressionConverter.ConvertO(__workflow_bodytaskId);
                    bodypropCount++;
                }

                if (__workflow_bodytaskIdLegacy != null)
                {
                    body["tid"] = ExpressionConverter.ConvertO(__workflow_bodytaskIdLegacy);
                    bodypropCount++;
                }

                if (__workflow_bodyuserIdLegacy != null)
                {
                    body["uid"] = ExpressionConverter.ConvertO(__workflow_bodyuserIdLegacy);
                    bodypropCount++;
                }

                if (__workflow_bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (__workflow_bodyworkspaceIdLegacy != null)
                {
                    body["wid"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceIdLegacy);
                    bodypropCount++;
                }

                if (__workflow_bodyworkspaceId != null)
                {
                    body["workspace_id"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TimeEntry>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<BulkEditResponse, ApiConnectionActionConfiguration> BulkEditTimeEntries(Expression<Func<int>> workspaceId, Expression<Func<string>> timeEntryIds, Expression<Func<bool>> meta = null, Expression<Func<PatchOperation[]>> body = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_timeEntryIds = WorkflowExpression.Compile(timeEntryIds, nameof(timeEntryIds), required: true);
            var __workflow_meta = WorkflowExpression.Compile(meta, nameof(meta), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<BulkEditResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workspaces/{0}/time_entries/bulk/{1}", __workflow_workspaceId.WithUrlEncoding(1), __workflow_timeEntryIds.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["meta"] = Convert.ToString(false);
                if (__workflow_meta != null)
                    callPayload.Queries["meta"] = ExpressionConverter.Convert(__workflow_meta);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BulkEditResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TimeEntry, ApiConnectionActionConfiguration> StopTimeEntry(Expression<Func<int>> workspaceId, Expression<Func<int>> timeEntryId)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_timeEntryId = WorkflowExpression.Compile(timeEntryId, nameof(timeEntryId), required: true);
            return new DeferredBodyAction<TimeEntry, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workspaces/{0}/time_entries/{1}/stop", __workflow_workspaceId.WithUrlEncoding(1), __workflow_timeEntryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TimeEntry>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<WorkspaceUser[], ApiConnectionActionConfiguration> GetOrganizationWorkspaceUsers(Expression<Func<int>> organizationId, Expression<Func<int>> workspaceId, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<bool>> customRates = null, Expression<Func<bool>> active = null, Expression<Func<string>> name = null, Expression<Func<string>> search = null)
        {
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_customRates = WorkflowExpression.Compile(customRates, nameof(customRates), required: false);
            var __workflow_active = WorkflowExpression.Compile(active, nameof(active), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            return new DeferredBodyAction<WorkspaceUser[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/organizations/{0}/workspaces/{1}/workspace_users", __workflow_organizationId.WithUrlEncoding(1), __workflow_workspaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["per_page"] = Convert.ToString(201);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_customRates != null)
                    callPayload.Queries["custom_rates"] = ExpressionConverter.Convert(__workflow_customRates);
                if (__workflow_active != null)
                    callPayload.Queries["active"] = ExpressionConverter.Convert(__workflow_active);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                return new ApiConnectionAction<WorkspaceUser[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Workspace, ApiConnectionActionConfiguration> GetWorkspace(Expression<Func<int>> workspaceId)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            return new DeferredBodyAction<Workspace, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workspaces/{0}", __workflow_workspaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Workspace>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Rate[], ApiConnectionActionConfiguration> GetWorkspaceRates(Expression<Func<int>> workspaceId, Expression<Func<levelInput>> level, Expression<Func<int>> levelId, Expression<Func<typeInput>> type = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_level = WorkflowExpression.Compile(level, nameof(level), required: true);
            var __workflow_levelId = WorkflowExpression.Compile(levelId, nameof(levelId), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            return new DeferredBodyAction<Rate[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workspaces/{0}/rates/{1}/{2}", __workflow_workspaceId.WithUrlEncoding(1), __workflow_level.WithUrlEncoding(1), __workflow_levelId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = Convert.ToString("billable_rates");
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                return new ApiConnectionAction<Rate[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<WorkspaceStatistics, ApiConnectionActionConfiguration> GetWorkspaceStatistics(Expression<Func<int>> workspaceId)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            return new DeferredBodyAction<WorkspaceStatistics, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workspaces/{0}/statistics", __workflow_workspaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<WorkspaceStatistics>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TimeEntryConstraints, ApiConnectionActionConfiguration> GetWorkspaceTimeEntryConstraints(Expression<Func<int>> workspaceId)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            return new DeferredBodyAction<TimeEntryConstraints, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workspaces/{0}/time_entry_constraints", __workflow_workspaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TimeEntryConstraints>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TrackRemindersResponse, ApiConnectionActionConfiguration> GetWorkspaceTrackReminders(Expression<Func<int>> workspaceId)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            return new DeferredBodyAction<TrackRemindersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workspaces/{0}/track_reminders", __workflow_workspaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TrackRemindersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<WorkspaceUserSimple[], ApiConnectionActionConfiguration> GetWorkspaceUsers(Expression<Func<int>> workspaceId, Expression<Func<bool>> excludeDeleted = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_excludeDeleted = WorkflowExpression.Compile(excludeDeleted, nameof(excludeDeleted), required: false);
            return new DeferredBodyAction<WorkspaceUserSimple[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workspaces/{0}/users", __workflow_workspaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["exclude_deleted"] = Convert.ToString(false);
                if (__workflow_excludeDeleted != null)
                    callPayload.Queries["exclude_deleted"] = ExpressionConverter.Convert(__workflow_excludeDeleted);
                return new ApiConnectionAction<WorkspaceUserSimple[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<ProjectUser[], ApiConnectionActionConfiguration> GetWorkspaceProjectUsers(Expression<Func<int>> workspaceId, Expression<Func<string>> projectIds = null, Expression<Func<string>> userId = null, Expression<Func<bool>> withGroupMembers = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_projectIds = WorkflowExpression.Compile(projectIds, nameof(projectIds), required: false);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: false);
            var __workflow_withGroupMembers = WorkflowExpression.Compile(withGroupMembers, nameof(withGroupMembers), required: false);
            return new DeferredBodyAction<ProjectUser[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workspaces/{0}/project_users", __workflow_workspaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_projectIds != null)
                    callPayload.Queries["project_ids"] = ExpressionConverter.Convert(__workflow_projectIds);
                if (__workflow_userId != null)
                    callPayload.Queries["user_id"] = ExpressionConverter.Convert(__workflow_userId);
                callPayload.Queries["with_group_members"] = Convert.ToString(false);
                if (__workflow_withGroupMembers != null)
                    callPayload.Queries["with_group_members"] = ExpressionConverter.Convert(__workflow_withGroupMembers);
                return new ApiConnectionAction<ProjectUser[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Project[], ApiConnectionActionConfiguration> GetWorkspaceProjects(Expression<Func<int>> workspaceId, Expression<Func<bool>> sortPinned, Expression<Func<string>> sortField, Expression<Func<sortOrderInput>> sortOrder, Expression<Func<bool>> onlyTemplates, Expression<Func<bool>> active = null, Expression<Func<int>> since = null, Expression<Func<bool>> billable = null, Expression<Func<int[]>> userIds = null, Expression<Func<int[]>> clientIds = null, Expression<Func<int[]>> groupIds = null, Expression<Func<string>> projectIds = null, Expression<Func<string[]>> statuses = null, Expression<Func<string>> name = null, Expression<Func<int>> page = null, Expression<Func<bool>> onlyMe = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_sortPinned = WorkflowExpression.Compile(sortPinned, nameof(sortPinned), required: true);
            var __workflow_sortField = WorkflowExpression.Compile(sortField, nameof(sortField), required: true);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: true);
            var __workflow_onlyTemplates = WorkflowExpression.Compile(onlyTemplates, nameof(onlyTemplates), required: true);
            var __workflow_active = WorkflowExpression.Compile(active, nameof(active), required: false);
            var __workflow_since = WorkflowExpression.Compile(since, nameof(since), required: false);
            var __workflow_billable = WorkflowExpression.Compile(billable, nameof(billable), required: false);
            var __workflow_userIds = WorkflowExpression.Compile(userIds, nameof(userIds), required: false);
            var __workflow_clientIds = WorkflowExpression.Compile(clientIds, nameof(clientIds), required: false);
            var __workflow_groupIds = WorkflowExpression.Compile(groupIds, nameof(groupIds), required: false);
            var __workflow_projectIds = WorkflowExpression.Compile(projectIds, nameof(projectIds), required: false);
            var __workflow_statuses = WorkflowExpression.Compile(statuses, nameof(statuses), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_onlyMe = WorkflowExpression.Compile(onlyMe, nameof(onlyMe), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<Project[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workspaces/{0}/projects", __workflow_workspaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sort_pinned"] = ExpressionConverter.Convert(__workflow_sortPinned);
                if (__workflow_active != null)
                    callPayload.Queries["active"] = ExpressionConverter.Convert(__workflow_active);
                if (__workflow_since != null)
                    callPayload.Queries["since"] = ExpressionConverter.Convert(__workflow_since);
                if (__workflow_billable != null)
                    callPayload.Queries["billable"] = ExpressionConverter.Convert(__workflow_billable);
                if (__workflow_userIds != null)
                    callPayload.Queries["user_ids"] = ExpressionConverter.Convert(__workflow_userIds);
                if (__workflow_clientIds != null)
                    callPayload.Queries["client_ids"] = ExpressionConverter.Convert(__workflow_clientIds);
                if (__workflow_groupIds != null)
                    callPayload.Queries["group_ids"] = ExpressionConverter.Convert(__workflow_groupIds);
                if (__workflow_projectIds != null)
                    callPayload.Queries["project_ids"] = ExpressionConverter.Convert(__workflow_projectIds);
                if (__workflow_statuses != null)
                    callPayload.Queries["statuses"] = ExpressionConverter.Convert(__workflow_statuses);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["sort_field"] = ExpressionConverter.Convert(__workflow_sortField);
                callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                callPayload.Queries["only_templates"] = ExpressionConverter.Convert(__workflow_onlyTemplates);
                callPayload.Queries["only_me"] = Convert.ToString(false);
                if (__workflow_onlyMe != null)
                    callPayload.Queries["only_me"] = ExpressionConverter.Convert(__workflow_onlyMe);
                callPayload.Queries["per_page"] = Convert.ToString(201);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<Project[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Project, ApiConnectionActionConfiguration> GetWorkspaceProject(Expression<Func<int>> workspaceId, Expression<Func<int>> projectId)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<Project, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workspaces/{0}/projects/{1}", __workflow_workspaceId.WithUrlEncoding(1), __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Project>(callPayload);
            });
        }
    }

    public class ToggltrackTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookSubscription, ApiConnectionTriggerConfiguration> OnTimeEntryCreated(Expression<Func<int>> workspaceId, FlowRecurrence recurrence = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            return new DeferredBodyTrigger<WebhookSubscription, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/webhooks/api/v1/subscriptions/{0}/time_entry_created", __workflow_workspaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url_callback"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["description"] = "Power Automate Time Tracking Trigger";
                bodypropCount++;
                body["enabled"] = true;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<WebhookSubscription>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookSubscription, ApiConnectionTriggerConfiguration> OnTimeEntryUpdated(Expression<Func<int>> workspaceId, FlowRecurrence recurrence = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            return new DeferredBodyTrigger<WebhookSubscription, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/webhooks/api/v1/subscriptions/{0}/time_entry_updated", __workflow_workspaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url_callback"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["description"] = "Power Automate Time Tracking Trigger";
                bodypropCount++;
                body["enabled"] = true;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<WebhookSubscription>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookSubscription, ApiConnectionTriggerConfiguration> OnTimeEntryDeleted(Expression<Func<int>> workspaceId, FlowRecurrence recurrence = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            return new DeferredBodyTrigger<WebhookSubscription, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/webhooks/api/v1/subscriptions/{0}/time_entry_deleted", __workflow_workspaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url_callback"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["description"] = "Power Automate Time Tracking Trigger";
                bodypropCount++;
                body["enabled"] = true;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<WebhookSubscription>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookSubscription, ApiConnectionTriggerConfiguration> OnTimeEntryStarted(Expression<Func<int>> workspaceId, FlowRecurrence recurrence = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            return new DeferredBodyTrigger<WebhookSubscription, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/webhooks/api/v1/subscriptions/{0}/time_entry_started", __workflow_workspaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url_callback"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["description"] = "Power Automate Time Tracking Trigger";
                bodypropCount++;
                body["enabled"] = true;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<WebhookSubscription>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookSubscription, ApiConnectionTriggerConfiguration> OnTimeEntryStopped(Expression<Func<int>> workspaceId, FlowRecurrence recurrence = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            return new DeferredBodyTrigger<WebhookSubscription, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/webhooks/api/v1/subscriptions/{0}/time_entry_stopped", __workflow_workspaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url_callback"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["description"] = "Power Automate Time Tracking Trigger";
                bodypropCount++;
                body["enabled"] = true;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<WebhookSubscription>(callPayload, recurrence: recurrence);
            });
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
        public int CountryId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("default_workspace_id")]
        public int DefaultWorkspaceId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("fullname")]
        public string FullName { get; set; }

        [JsonProperty("has_password")]
        public bool HasPassword { get; set; }

        [JsonProperty("id")]
        public int UserId { get; set; }

        [JsonProperty("image_url")]
        public string ImageURL { get; set; }

        [JsonProperty("intercom_hash")]
        public string IntercomHash { get; set; }

        [JsonProperty("oauth_providers")]
        public string[] OAuthProviders { get; set; }

        [JsonProperty("openid_email")]
        public string OpenIdEmail { get; set; }

        [JsonProperty("openid_enabled")]
        public bool OpenIdEnabled { get; set; }

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
        public int CreatorId { get; set; }

        [JsonProperty("external_reference")]
        public string ExternalReference { get; set; }

        [JsonProperty("id")]
        public int ClientId { get; set; }

        [JsonProperty("integration_ext_id")]
        public string IntegrationExternalId { get; set; }

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
        public int WorkspaceId { get; set; }
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
        public int ClientIdLegacy { get; set; }

        [JsonProperty("client_id")]
        public int ClientId { get; set; }

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
        public int ProjectId { get; set; }

        [JsonProperty("integration_ext_id")]
        public string IntegrationExternalId { get; set; }

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
        public int TemplateId { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("wid")]
        public int WorkspaceIdLegacy { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }
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
        public int CreatorId { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("id")]
        public int TagId { get; set; }

        [JsonProperty("integration_ext_id")]
        public string IntegrationExternalId { get; set; }

        [JsonProperty("integration_ext_type")]
        public string IntegrationExternalType { get; set; }

        [JsonProperty("integration_provider")]
        public JToken IntegrationProvider { get; set; }

        [JsonProperty("name")]
        public string TagName { get; set; }

        [JsonProperty("permissions")]
        public string[] Permissions { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }
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
        public int TaskId { get; set; }

        [JsonProperty("integration_ext_id")]
        public string IntegrationExternalId { get; set; }

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
        public int ProjectId { get; set; }

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
        public string TogglAccountsId { get; set; }

        [JsonProperty("tracked_seconds")]
        public int TrackedSeconds { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }
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
        public int TimeEntryId { get; set; }

        [JsonProperty("permissions")]
        public string[] Permissions { get; set; }

        [JsonProperty("pid")]
        public int ProjectIdLegacy { get; set; }

        [JsonProperty("project_active")]
        public bool ProjectActive { get; set; }

        [JsonProperty("project_billable")]
        public bool ProjectBillable { get; set; }

        [JsonProperty("project_color")]
        public string ProjectColor { get; set; }

        [JsonProperty("project_id")]
        public int ProjectId { get; set; }

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
        public int TaskId { get; set; }

        [JsonProperty("task_name")]
        public string TaskName { get; set; }

        [JsonProperty("tid")]
        public int TaskIdLegacy { get; set; }

        [JsonProperty("uid")]
        public int UserIdLegacy { get; set; }

        [JsonProperty("user_avatar_url")]
        public string UserAvatarURL { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("wid")]
        public int WorkspaceIdLegacy { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }
    }

    public class SharedWith
    {
        [JsonProperty("accepted")]
        public bool Accepted { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

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
        public int WorkspaceId { get; set; }

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
        public int OrganizationId { get; set; }

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
        public int CountryId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("default_workspace_id")]
        public int DefaultWorkspaceId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("fullname")]
        public string FullName { get; set; }

        [JsonProperty("has_password")]
        public bool HasPassword { get; set; }

        [JsonProperty("id")]
        public int UserId { get; set; }

        [JsonProperty("image_url")]
        public string ImageURL { get; set; }

        [JsonProperty("openid_email")]
        public string OpenIdEmail { get; set; }

        [JsonProperty("openid_enabled")]
        public bool OpenIdEnabled { get; set; }

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
        public int WorkspaceId { get; set; }
    }

    public class Feature
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("feature_id")]
        public int FeatureId { get; set; }

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
        public int OrganizationId { get; set; }

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
        public int PricingPlanId { get; set; }

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
        public int LastPricingPlanId { get; set; }

        [JsonProperty("next_payment_date")]
        public string NextPaymentDate { get; set; }

        [JsonProperty("trial")]
        public bool Trial { get; set; }

        [JsonProperty("trial_available")]
        public bool TrialAvailable { get; set; }

        [JsonProperty("trial_end_date")]
        public string TrialEndDate { get; set; }

        [JsonProperty("trial_plan_id")]
        public int TrialPlanId { get; set; }
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
        public int ReminderId { get; set; }

        [JsonProperty("threshold")]
        public int Threshold { get; set; }

        [JsonProperty("user_ids")]
        public int[] UserIDs { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public int FailedId { get; set; }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public int UserWorkspaceId { get; set; }

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
        public int RoleId { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("uid")]
        public int GlobalUserId { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("view_edit_billable_rates")]
        public bool ViewEditBillableRates { get; set; }

        [JsonProperty("view_edit_labor_costs")]
        public bool ViewEditLaborCosts { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }

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
        public int CreatorId { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("end")]
        public string EndDate { get; set; }

        [JsonProperty("id")]
        public int RateId { get; set; }

        [JsonProperty("planned_task_id")]
        public int PlannedTaskId { get; set; }

        [JsonProperty("project_id")]
        public int ProjectId { get; set; }

        [JsonProperty("project_user_id")]
        public int ProjectUserId { get; set; }

        [JsonProperty("rate_change_mode")]
        public string RateChangeMode { get; set; }

        [JsonProperty("start")]
        public string StartDate { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }

        [JsonProperty("workspace_user_id")]
        public int WorkspaceUserId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public int UserId { get; set; }
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
        public int UserId { get; set; }

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
        public int GroupIdLegacy { get; set; }

        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        [JsonProperty("id")]
        public int ProjectUserId { get; set; }

        [JsonProperty("labor_cost")]
        public double LaborCost { get; set; }

        [JsonProperty("labor_cost_last_updated")]
        public string LaborCostLastUpdated { get; set; }

        [JsonProperty("manager")]
        public bool Manager { get; set; }

        [JsonProperty("project_id")]
        public int ProjectId { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("rate_last_updated")]
        public string RateLastUpdated { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public int SubscriptionId { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }

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