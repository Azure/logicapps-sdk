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
        public IBodyWorkflowAction<UserResponse> GetMe([WorkflowExpression] Func<bool> withRelatedData = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["with_related_data"] = Convert.ToString(false);
                if (withRelatedData != null)
                    callPayload.Queries["with_related_data"] = SourceExpressionConverter.ConvertO(withRelatedData);
                return callPayload;
            }

            return new ApiConnectionAction<UserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<UserBasicResponse> UpdateMe([WorkflowExpression] Func<int> bodybeginningOfWeek = null, [WorkflowExpression] Func<int> bodycountryId = null, [WorkflowExpression] Func<string> bodycurrentPassword = null, [WorkflowExpression] Func<int> bodydefaultWorkspaceId = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyfullName = null, [WorkflowExpression] Func<string> bodynewPassword = null, [WorkflowExpression] Func<string> bodytimezone = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/me";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodybeginningOfWeek != null)
                {
                    body["beginning_of_week"] = SourceExpressionConverter.ConvertToken(bodybeginningOfWeek);
                    bodypropCount++;
                }

                if (bodycountryId != null)
                {
                    body["country_id"] = SourceExpressionConverter.ConvertToken(bodycountryId);
                    bodypropCount++;
                }

                if (bodycurrentPassword != null)
                {
                    body["current_password"] = SourceExpressionConverter.ConvertToken(bodycurrentPassword);
                    bodypropCount++;
                }

                if (bodydefaultWorkspaceId != null)
                {
                    body["default_workspace_id"] = SourceExpressionConverter.ConvertToken(bodydefaultWorkspaceId);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyfullName != null)
                {
                    body["fullname"] = SourceExpressionConverter.ConvertToken(bodyfullName);
                    bodypropCount++;
                }

                if (bodynewPassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodynewPassword);
                    bodypropCount++;
                }

                if (bodytimezone != null)
                {
                    body["timezone"] = SourceExpressionConverter.ConvertToken(bodytimezone);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UserBasicResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Client[]> GetMeClients([WorkflowExpression] Func<int> since = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/me/clients";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (since != null)
                    callPayload.Queries["since"] = SourceExpressionConverter.ConvertO(since);
                return callPayload;
            }

            return new ApiConnectionAction<Client[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<WorkspaceFeatures[]> GetMeFeatures()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/me/features";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<WorkspaceFeatures[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<LocationResponse> GetMeLocation()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/me/location";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LocationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IWorkflowAction GetMeLogged()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/me/logged";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Organization[]> GetMeOrganizations()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/me/organizations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Organization[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Project[]> GetMeProjects([WorkflowExpression] Func<string> includeArchived = null, [WorkflowExpression] Func<int> since = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/me/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeArchived != null)
                    callPayload.Queries["include_archived"] = SourceExpressionConverter.ConvertO(includeArchived);
                if (since != null)
                    callPayload.Queries["since"] = SourceExpressionConverter.ConvertO(since);
                return callPayload;
            }

            return new ApiConnectionAction<Project[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Project[]> GetMeProjectsPaginated([WorkflowExpression] Func<int> startProjectId = null, [WorkflowExpression] Func<int> since = null, [WorkflowExpression] Func<int> perPage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/me/projects/paginated";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startProjectId != null)
                    callPayload.Queries["start_project_id"] = SourceExpressionConverter.ConvertO(startProjectId);
                if (since != null)
                    callPayload.Queries["since"] = SourceExpressionConverter.ConvertO(since);
                callPayload.Queries["per_page"] = Convert.ToString(201);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<Project[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Tag[]> GetMeTags([WorkflowExpression] Func<int> since = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/me/tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (since != null)
                    callPayload.Queries["since"] = SourceExpressionConverter.ConvertO(since);
                return callPayload;
            }

            return new ApiConnectionAction<Tag[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TaskObject[]> GetMeTasks([WorkflowExpression] Func<bool> meta = null, [WorkflowExpression] Func<int> since = null, [WorkflowExpression] Func<string> includeNotActive = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> perPage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/me/tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["meta"] = Convert.ToString(false);
                if (meta != null)
                    callPayload.Queries["meta"] = SourceExpressionConverter.ConvertO(meta);
                if (since != null)
                    callPayload.Queries["since"] = SourceExpressionConverter.ConvertO(since);
                if (includeNotActive != null)
                    callPayload.Queries["include_not_active"] = SourceExpressionConverter.ConvertO(includeNotActive);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                callPayload.Queries["per_page"] = Convert.ToString(201);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<TaskObject[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TrackReminder[]> GetMeTrackReminders()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/me/track_reminders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TrackReminder[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IWorkflowAction GetMeWebTimer()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/me/web-timer";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Workspace[]> GetMeWorkspaces([WorkflowExpression] Func<int> since = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/me/workspaces";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (since != null)
                    callPayload.Queries["since"] = SourceExpressionConverter.ConvertO(since);
                return callPayload;
            }

            return new ApiConnectionAction<Workspace[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TimeEntry[]> GetMeTimeEntries([WorkflowExpression] Func<bool> meta = null, [WorkflowExpression] Func<bool> includeSharing = null, [WorkflowExpression] Func<int> since = null, [WorkflowExpression] Func<string> before = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/me/time_entries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["meta"] = Convert.ToString(false);
                if (meta != null)
                    callPayload.Queries["meta"] = SourceExpressionConverter.ConvertO(meta);
                callPayload.Queries["include_sharing"] = Convert.ToString(false);
                if (includeSharing != null)
                    callPayload.Queries["include_sharing"] = SourceExpressionConverter.ConvertO(includeSharing);
                if (since != null)
                    callPayload.Queries["since"] = SourceExpressionConverter.ConvertO(since);
                if (before != null)
                    callPayload.Queries["before"] = SourceExpressionConverter.ConvertO(before);
                if (startDate != null)
                    callPayload.Queries["start_date"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["end_date"] = SourceExpressionConverter.ConvertO(endDate);
                return callPayload;
            }

            return new ApiConnectionAction<TimeEntry[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TimeEntry> GetCurrentTimeEntry()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/me/time_entries/current";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TimeEntry>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TimeEntry> GetTimeEntryById([WorkflowExpression] Func<int> timeEntryId, [WorkflowExpression] Func<bool> meta = null, [WorkflowExpression] Func<bool> includeSharing = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/me/time_entries/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(timeEntryId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["meta"] = Convert.ToString(false);
                if (meta != null)
                    callPayload.Queries["meta"] = SourceExpressionConverter.ConvertO(meta);
                callPayload.Queries["include_sharing"] = Convert.ToString(false);
                if (includeSharing != null)
                    callPayload.Queries["include_sharing"] = SourceExpressionConverter.ConvertO(includeSharing);
                return callPayload;
            }

            return new ApiConnectionAction<TimeEntry>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TimeEntry> CreateTimeEntry([WorkflowExpression] Func<int> workspaceId, [WorkflowExpression] Func<bool> meta = null, [WorkflowExpression] Func<bool> bodybillable = null, [WorkflowExpression] Func<string> bodycreatedWith = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodyduration = null, [WorkflowExpression] Func<bool> bodydurationOnly = null, [WorkflowExpression] Func<string> bodyeventMetadataoriginFeature = null, [WorkflowExpression] Func<int> bodyeventMetadatavisibleGoalsCount = null, [WorkflowExpression] Func<int[]> bodyexpenseIDs = null, [WorkflowExpression] Func<int> bodyprojectIdLegacy = null, [WorkflowExpression] Func<int> bodyprojectId = null, [WorkflowExpression] Func<int[]> bodysharedWithUserIDs = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodystopTime = null, [WorkflowExpression] Func<bodytagActionInput> bodytagAction = null, [WorkflowExpression] Func<int[]> bodytagIDs = null, [WorkflowExpression] Func<string[]> bodytags = null, [WorkflowExpression] Func<int> bodytaskId = null, [WorkflowExpression] Func<int> bodytaskIdLegacy = null, [WorkflowExpression] Func<int> bodyuserIdLegacy = null, [WorkflowExpression] Func<int> bodyuserId = null, [WorkflowExpression] Func<int> bodyworkspaceIdLegacy = null, [WorkflowExpression] Func<int> bodyworkspaceId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workspaces/{0}/time_entries", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(workspaceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["meta"] = Convert.ToString(false);
                if (meta != null)
                    callPayload.Queries["meta"] = SourceExpressionConverter.ConvertO(meta);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodybillable != null)
                {
                    body["billable"] = SourceExpressionConverter.ConvertToken(bodybillable);
                    bodypropCount++;
                }

                if (bodycreatedWith != null)
                {
                    body["created_with"] = SourceExpressionConverter.ConvertToken(bodycreatedWith);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyduration != null)
                {
                    body["duration"] = SourceExpressionConverter.ConvertToken(bodyduration);
                    bodypropCount++;
                }

                if (bodydurationOnly != null)
                {
                    body["duronly"] = SourceExpressionConverter.ConvertToken(bodydurationOnly);
                    bodypropCount++;
                }

                var eventMetadataObject = new JObject();
                var eventMetadataObjectpropCount = 0;
                if (bodyeventMetadataoriginFeature != null)
                {
                    eventMetadataObject["origin_feature"] = SourceExpressionConverter.ConvertToken(bodyeventMetadataoriginFeature);
                    eventMetadataObjectpropCount++;
                }

                if (bodyeventMetadatavisibleGoalsCount != null)
                {
                    eventMetadataObject["visible_goals_count"] = SourceExpressionConverter.ConvertToken(bodyeventMetadatavisibleGoalsCount);
                    eventMetadataObjectpropCount++;
                }

                if (eventMetadataObjectpropCount > 0)
                {
                    body["event_metadata"] = eventMetadataObject;
                    bodypropCount++;
                }

                if (bodyexpenseIDs != null)
                {
                    body["expense_ids"] = SourceExpressionConverter.ConvertToken(bodyexpenseIDs);
                    bodypropCount++;
                }

                if (bodyprojectIdLegacy != null)
                {
                    body["pid"] = SourceExpressionConverter.ConvertToken(bodyprojectIdLegacy);
                    bodypropCount++;
                }

                if (bodyprojectId != null)
                {
                    body["project_id"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                    bodypropCount++;
                }

                if (bodysharedWithUserIDs != null)
                {
                    body["shared_with_user_ids"] = SourceExpressionConverter.ConvertToken(bodysharedWithUserIDs);
                    bodypropCount++;
                }

                if (bodystartTime != null)
                {
                    body["start"] = SourceExpressionConverter.ConvertToken(bodystartTime);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodystopTime != null)
                {
                    body["stop"] = SourceExpressionConverter.ConvertToken(bodystopTime);
                    bodypropCount++;
                }

                if (bodytagAction != null)
                {
                    body["tag_action"] = SourceExpressionConverter.Convert(bodytagAction);
                    bodypropCount++;
                }

                if (bodytagIDs != null)
                {
                    body["tag_ids"] = SourceExpressionConverter.ConvertToken(bodytagIDs);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                if (bodytaskId != null)
                {
                    body["task_id"] = SourceExpressionConverter.ConvertToken(bodytaskId);
                    bodypropCount++;
                }

                if (bodytaskIdLegacy != null)
                {
                    body["tid"] = SourceExpressionConverter.ConvertToken(bodytaskIdLegacy);
                    bodypropCount++;
                }

                if (bodyuserIdLegacy != null)
                {
                    body["uid"] = SourceExpressionConverter.ConvertToken(bodyuserIdLegacy);
                    bodypropCount++;
                }

                if (bodyuserId != null)
                {
                    body["user_id"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                if (bodyworkspaceIdLegacy != null)
                {
                    body["wid"] = SourceExpressionConverter.ConvertToken(bodyworkspaceIdLegacy);
                    bodypropCount++;
                }

                if (bodyworkspaceId != null)
                {
                    body["workspace_id"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TimeEntry>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IWorkflowAction DeleteTimeEntry([WorkflowExpression] Func<int> workspaceId, [WorkflowExpression] Func<int> timeEntryId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workspaces/{0}/time_entries/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(workspaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(timeEntryId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TimeEntry> UpdateTimeEntry([WorkflowExpression] Func<int> workspaceId, [WorkflowExpression] Func<int> timeEntryId, [WorkflowExpression] Func<bool> meta = null, [WorkflowExpression] Func<bool> includeSharing = null, [WorkflowExpression] Func<bool> bodybillable = null, [WorkflowExpression] Func<string> bodycreatedWith = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodyduration = null, [WorkflowExpression] Func<bool> bodydurationOnly = null, [WorkflowExpression] Func<string> bodyeventMetadataoriginFeature = null, [WorkflowExpression] Func<int> bodyeventMetadatavisibleGoalsCount = null, [WorkflowExpression] Func<int[]> bodyexpenseIDs = null, [WorkflowExpression] Func<int> bodyprojectIdLegacy = null, [WorkflowExpression] Func<int> bodyprojectId = null, [WorkflowExpression] Func<int[]> bodysharedWithUserIDs = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodystopTime = null, [WorkflowExpression] Func<bodytagActionInput> bodytagAction = null, [WorkflowExpression] Func<int[]> bodytagIDs = null, [WorkflowExpression] Func<string[]> bodytags = null, [WorkflowExpression] Func<int> bodytaskId = null, [WorkflowExpression] Func<int> bodytaskIdLegacy = null, [WorkflowExpression] Func<int> bodyuserIdLegacy = null, [WorkflowExpression] Func<int> bodyuserId = null, [WorkflowExpression] Func<int> bodyworkspaceIdLegacy = null, [WorkflowExpression] Func<int> bodyworkspaceId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workspaces/{0}/time_entries/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(workspaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(timeEntryId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["meta"] = Convert.ToString(false);
                if (meta != null)
                    callPayload.Queries["meta"] = SourceExpressionConverter.ConvertO(meta);
                callPayload.Queries["include_sharing"] = Convert.ToString(false);
                if (includeSharing != null)
                    callPayload.Queries["include_sharing"] = SourceExpressionConverter.ConvertO(includeSharing);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodybillable != null)
                {
                    body["billable"] = SourceExpressionConverter.ConvertToken(bodybillable);
                    bodypropCount++;
                }

                if (bodycreatedWith != null)
                {
                    body["created_with"] = SourceExpressionConverter.ConvertToken(bodycreatedWith);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyduration != null)
                {
                    body["duration"] = SourceExpressionConverter.ConvertToken(bodyduration);
                    bodypropCount++;
                }

                if (bodydurationOnly != null)
                {
                    body["duronly"] = SourceExpressionConverter.ConvertToken(bodydurationOnly);
                    bodypropCount++;
                }

                var eventMetadataObject = new JObject();
                var eventMetadataObjectpropCount = 0;
                if (bodyeventMetadataoriginFeature != null)
                {
                    eventMetadataObject["origin_feature"] = SourceExpressionConverter.ConvertToken(bodyeventMetadataoriginFeature);
                    eventMetadataObjectpropCount++;
                }

                if (bodyeventMetadatavisibleGoalsCount != null)
                {
                    eventMetadataObject["visible_goals_count"] = SourceExpressionConverter.ConvertToken(bodyeventMetadatavisibleGoalsCount);
                    eventMetadataObjectpropCount++;
                }

                if (eventMetadataObjectpropCount > 0)
                {
                    body["event_metadata"] = eventMetadataObject;
                    bodypropCount++;
                }

                if (bodyexpenseIDs != null)
                {
                    body["expense_ids"] = SourceExpressionConverter.ConvertToken(bodyexpenseIDs);
                    bodypropCount++;
                }

                if (bodyprojectIdLegacy != null)
                {
                    body["pid"] = SourceExpressionConverter.ConvertToken(bodyprojectIdLegacy);
                    bodypropCount++;
                }

                if (bodyprojectId != null)
                {
                    body["project_id"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                    bodypropCount++;
                }

                if (bodysharedWithUserIDs != null)
                {
                    body["shared_with_user_ids"] = SourceExpressionConverter.ConvertToken(bodysharedWithUserIDs);
                    bodypropCount++;
                }

                if (bodystartTime != null)
                {
                    body["start"] = SourceExpressionConverter.ConvertToken(bodystartTime);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodystopTime != null)
                {
                    body["stop"] = SourceExpressionConverter.ConvertToken(bodystopTime);
                    bodypropCount++;
                }

                if (bodytagAction != null)
                {
                    body["tag_action"] = SourceExpressionConverter.Convert(bodytagAction);
                    bodypropCount++;
                }

                if (bodytagIDs != null)
                {
                    body["tag_ids"] = SourceExpressionConverter.ConvertToken(bodytagIDs);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                if (bodytaskId != null)
                {
                    body["task_id"] = SourceExpressionConverter.ConvertToken(bodytaskId);
                    bodypropCount++;
                }

                if (bodytaskIdLegacy != null)
                {
                    body["tid"] = SourceExpressionConverter.ConvertToken(bodytaskIdLegacy);
                    bodypropCount++;
                }

                if (bodyuserIdLegacy != null)
                {
                    body["uid"] = SourceExpressionConverter.ConvertToken(bodyuserIdLegacy);
                    bodypropCount++;
                }

                if (bodyuserId != null)
                {
                    body["user_id"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                if (bodyworkspaceIdLegacy != null)
                {
                    body["wid"] = SourceExpressionConverter.ConvertToken(bodyworkspaceIdLegacy);
                    bodypropCount++;
                }

                if (bodyworkspaceId != null)
                {
                    body["workspace_id"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TimeEntry>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<BulkEditResponse> BulkEditTimeEntries([WorkflowExpression] Func<int> workspaceId, [WorkflowExpression] Func<string> timeEntryIds, [WorkflowExpression] Func<bool> meta = null, [WorkflowExpression] Func<PatchOperation[]> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workspaces/{0}/time_entries/bulk/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(workspaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(timeEntryIds, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["meta"] = Convert.ToString(false);
                if (meta != null)
                    callPayload.Queries["meta"] = SourceExpressionConverter.ConvertO(meta);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<BulkEditResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TimeEntry> StopTimeEntry([WorkflowExpression] Func<int> workspaceId, [WorkflowExpression] Func<int> timeEntryId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workspaces/{0}/time_entries/{1}/stop", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(workspaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(timeEntryId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TimeEntry>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<WorkspaceUser[]> GetOrganizationWorkspaceUsers([WorkflowExpression] Func<int> organizationId, [WorkflowExpression] Func<int> workspaceId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<bool> customRates = null, [WorkflowExpression] Func<bool> active = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> search = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/organizations/{0}/workspaces/{1}/workspace_users", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(organizationId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(workspaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["per_page"] = Convert.ToString(201);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                if (customRates != null)
                    callPayload.Queries["custom_rates"] = SourceExpressionConverter.ConvertO(customRates);
                if (active != null)
                    callPayload.Queries["active"] = SourceExpressionConverter.ConvertO(active);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                return callPayload;
            }

            return new ApiConnectionAction<WorkspaceUser[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Workspace> GetWorkspace([WorkflowExpression] Func<int> workspaceId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workspaces/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(workspaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Workspace>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Rate[]> GetWorkspaceRates([WorkflowExpression] Func<int> workspaceId, [WorkflowExpression] Func<levelInput> level, [WorkflowExpression] Func<int> levelId, [WorkflowExpression] Func<typeInput> type = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workspaces/{0}/rates/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(workspaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(level, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(levelId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = Convert.ToString("billable_rates");
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.Convert(type);
                return callPayload;
            }

            return new ApiConnectionAction<Rate[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<WorkspaceStatistics> GetWorkspaceStatistics([WorkflowExpression] Func<int> workspaceId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workspaces/{0}/statistics", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(workspaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<WorkspaceStatistics>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TimeEntryConstraints> GetWorkspaceTimeEntryConstraints([WorkflowExpression] Func<int> workspaceId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workspaces/{0}/time_entry_constraints", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(workspaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TimeEntryConstraints>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<TrackRemindersResponse> GetWorkspaceTrackReminders([WorkflowExpression] Func<int> workspaceId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workspaces/{0}/track_reminders", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(workspaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TrackRemindersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<WorkspaceUserSimple[]> GetWorkspaceUsers([WorkflowExpression] Func<int> workspaceId, [WorkflowExpression] Func<bool> excludeDeleted = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workspaces/{0}/users", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(workspaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["exclude_deleted"] = Convert.ToString(false);
                if (excludeDeleted != null)
                    callPayload.Queries["exclude_deleted"] = SourceExpressionConverter.ConvertO(excludeDeleted);
                return callPayload;
            }

            return new ApiConnectionAction<WorkspaceUserSimple[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<ProjectUser[]> GetWorkspaceProjectUsers([WorkflowExpression] Func<int> workspaceId, [WorkflowExpression] Func<string> projectIds = null, [WorkflowExpression] Func<string> userId = null, [WorkflowExpression] Func<bool> withGroupMembers = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workspaces/{0}/project_users", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(workspaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (projectIds != null)
                    callPayload.Queries["project_ids"] = SourceExpressionConverter.ConvertO(projectIds);
                if (userId != null)
                    callPayload.Queries["user_id"] = SourceExpressionConverter.ConvertO(userId);
                callPayload.Queries["with_group_members"] = Convert.ToString(false);
                if (withGroupMembers != null)
                    callPayload.Queries["with_group_members"] = SourceExpressionConverter.ConvertO(withGroupMembers);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectUser[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Project[]> GetWorkspaceProjects([WorkflowExpression] Func<int> workspaceId, [WorkflowExpression] Func<bool> sortPinned, [WorkflowExpression] Func<string> sortField, [WorkflowExpression] Func<sortOrderInput> sortOrder, [WorkflowExpression] Func<bool> onlyTemplates, [WorkflowExpression] Func<bool> active = null, [WorkflowExpression] Func<int> since = null, [WorkflowExpression] Func<bool> billable = null, [WorkflowExpression] Func<int[]> userIds = null, [WorkflowExpression] Func<int[]> clientIds = null, [WorkflowExpression] Func<int[]> groupIds = null, [WorkflowExpression] Func<string> projectIds = null, [WorkflowExpression] Func<string[]> statuses = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<bool> onlyMe = null, [WorkflowExpression] Func<int> perPage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workspaces/{0}/projects", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(workspaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sort_pinned"] = SourceExpressionConverter.ConvertO(sortPinned);
                if (active != null)
                    callPayload.Queries["active"] = SourceExpressionConverter.ConvertO(active);
                if (since != null)
                    callPayload.Queries["since"] = SourceExpressionConverter.ConvertO(since);
                if (billable != null)
                    callPayload.Queries["billable"] = SourceExpressionConverter.ConvertO(billable);
                if (userIds != null)
                    callPayload.Queries["user_ids"] = SourceExpressionConverter.ConvertO(userIds);
                if (clientIds != null)
                    callPayload.Queries["client_ids"] = SourceExpressionConverter.ConvertO(clientIds);
                if (groupIds != null)
                    callPayload.Queries["group_ids"] = SourceExpressionConverter.ConvertO(groupIds);
                if (projectIds != null)
                    callPayload.Queries["project_ids"] = SourceExpressionConverter.ConvertO(projectIds);
                if (statuses != null)
                    callPayload.Queries["statuses"] = SourceExpressionConverter.ConvertO(statuses);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["sort_field"] = SourceExpressionConverter.ConvertO(sortField);
                callPayload.Queries["sort_order"] = SourceExpressionConverter.Convert(sortOrder);
                callPayload.Queries["only_templates"] = SourceExpressionConverter.ConvertO(onlyTemplates);
                callPayload.Queries["only_me"] = Convert.ToString(false);
                if (onlyMe != null)
                    callPayload.Queries["only_me"] = SourceExpressionConverter.ConvertO(onlyMe);
                callPayload.Queries["per_page"] = Convert.ToString(201);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<Project[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toggltrack")]
        public IBodyWorkflowAction<Project> GetWorkspaceProject([WorkflowExpression] Func<int> workspaceId, [WorkflowExpression] Func<int> projectId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workspaces/{0}/projects/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(workspaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Project>(BuildSourceInput);
        }
    }

    public class ToggltrackTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookSubscription> OnTimeEntryCreated([WorkflowExpression] Func<int> workspaceId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/webhooks/api/v1/subscriptions/{0}/time_entry_created", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(workspaceId, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<WebhookSubscription>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookSubscription> OnTimeEntryUpdated([WorkflowExpression] Func<int> workspaceId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/webhooks/api/v1/subscriptions/{0}/time_entry_updated", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(workspaceId, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<WebhookSubscription>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookSubscription> OnTimeEntryDeleted([WorkflowExpression] Func<int> workspaceId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/webhooks/api/v1/subscriptions/{0}/time_entry_deleted", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(workspaceId, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<WebhookSubscription>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookSubscription> OnTimeEntryStarted([WorkflowExpression] Func<int> workspaceId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/webhooks/api/v1/subscriptions/{0}/time_entry_started", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(workspaceId, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<WebhookSubscription>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookSubscription> OnTimeEntryStopped([WorkflowExpression] Func<int> workspaceId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/webhooks/api/v1/subscriptions/{0}/time_entry_stopped", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(workspaceId, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<WebhookSubscription>(BuildSourceInput, triggerName, recurrence);
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