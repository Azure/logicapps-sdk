//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Togglplanip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TogglplanipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IBodyWorkflowAction<UserProfileResponse> GetProfileInformation()
        {
            var apiCallPath = "/api/v5/me";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserProfileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IBodyWorkflowAction<UserProfileResponse> UpdateProfile(Expression<Func<int>> bodycolorId = null, Expression<Func<string>> bodyemail = null, Expression<Func<bool>> bodyhasPicture = null, Expression<Func<string>> bodyinitials = null, Expression<Func<JToken[]>> bodyinvitations = null, Expression<Func<bool>> bodylegalConsentPending = null, Expression<Func<string>> bodymanager = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodypictureUrl = null, Expression<Func<bool>> bodypreferenceshideWeekends = null, Expression<Func<bool>> bodypreferenceshighlightDoneTasks = null, Expression<Func<bool>> bodypreferencesonboardingEmails = null, Expression<Func<bool>> bodypreferencespinMeOnTop = null, Expression<Func<string>> bodypreferencesselectedAccountId = null, Expression<Func<string>> bodypreferencesselectedGroupId = null, Expression<Func<string>> bodypreferencesselectedProjectId = null, Expression<Func<int>> bodypreferencesstartOfWeek = null, Expression<Func<bool>> bodypreferencestaskNotifications = null, Expression<Func<string>> bodypreferencestimezone = null, Expression<Func<bool>> bodypreferencesvisionImpaired = null, Expression<Func<bool>> bodypreferencesvisionImpairedBigFont = null, Expression<Func<bool>> bodypreferencesvisionImpairedBorders = null, Expression<Func<bool>> bodypreferencesvisionImpairedContrastText = null, Expression<Func<bool>> bodypreferencesvisionImpairedLightColors = null, Expression<Func<bool>> bodypreferencesvisionImpairedPatterns = null, Expression<Func<bool>> bodypreferencesvisionImpairedToday = null, Expression<Func<bool>> bodypreferencesvisionImpairedWeekends = null)
        {
            var apiCallPath = "/api/v5/me";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycolorId != null)
            {
                body["color_id"] = ExpressionConverter.ConvertO(bodycolorId);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodyhasPicture != null)
            {
                body["has_picture"] = ExpressionConverter.ConvertO(bodyhasPicture);
                bodypropCount++;
            }

            if (bodyinitials != null)
            {
                body["initials"] = ExpressionConverter.ConvertO(bodyinitials);
                bodypropCount++;
            }

            if (bodyinvitations != null)
            {
                body["invitations"] = ExpressionConverter.ConvertO(bodyinvitations);
                bodypropCount++;
            }

            if (bodylegalConsentPending != null)
            {
                body["legal_consent_pending"] = ExpressionConverter.ConvertO(bodylegalConsentPending);
                bodypropCount++;
            }

            if (bodymanager != null)
            {
                body["manager"] = ExpressionConverter.ConvertO(bodymanager);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodypictureUrl != null)
            {
                body["picture_url"] = ExpressionConverter.ConvertO(bodypictureUrl);
                bodypropCount++;
            }

            var preferencesObject = new JObject();
            var preferencesObjectpropCount = 0;
            if (bodypreferenceshideWeekends != null)
            {
                preferencesObject["hide_weekends"] = ExpressionConverter.ConvertO(bodypreferenceshideWeekends);
                preferencesObjectpropCount++;
            }

            if (bodypreferenceshighlightDoneTasks != null)
            {
                preferencesObject["highlight_done_tasks"] = ExpressionConverter.ConvertO(bodypreferenceshighlightDoneTasks);
                preferencesObjectpropCount++;
            }

            if (bodypreferencesonboardingEmails != null)
            {
                preferencesObject["onboarding_emails"] = ExpressionConverter.ConvertO(bodypreferencesonboardingEmails);
                preferencesObjectpropCount++;
            }

            if (bodypreferencespinMeOnTop != null)
            {
                preferencesObject["pin_me_on_top"] = ExpressionConverter.ConvertO(bodypreferencespinMeOnTop);
                preferencesObjectpropCount++;
            }

            if (bodypreferencesselectedAccountId != null)
            {
                preferencesObject["selected_account_id"] = ExpressionConverter.ConvertO(bodypreferencesselectedAccountId);
                preferencesObjectpropCount++;
            }

            if (bodypreferencesselectedGroupId != null)
            {
                preferencesObject["selected_group_id"] = ExpressionConverter.ConvertO(bodypreferencesselectedGroupId);
                preferencesObjectpropCount++;
            }

            if (bodypreferencesselectedProjectId != null)
            {
                preferencesObject["selected_project_id"] = ExpressionConverter.ConvertO(bodypreferencesselectedProjectId);
                preferencesObjectpropCount++;
            }

            if (bodypreferencesstartOfWeek != null)
            {
                preferencesObject["start_of_week"] = ExpressionConverter.ConvertO(bodypreferencesstartOfWeek);
                preferencesObjectpropCount++;
            }

            if (bodypreferencestaskNotifications != null)
            {
                preferencesObject["task_notifications"] = ExpressionConverter.ConvertO(bodypreferencestaskNotifications);
                preferencesObjectpropCount++;
            }

            if (bodypreferencestimezone != null)
            {
                preferencesObject["timezone"] = ExpressionConverter.ConvertO(bodypreferencestimezone);
                preferencesObjectpropCount++;
            }

            if (bodypreferencesvisionImpaired != null)
            {
                preferencesObject["vision_impaired"] = ExpressionConverter.ConvertO(bodypreferencesvisionImpaired);
                preferencesObjectpropCount++;
            }

            if (bodypreferencesvisionImpairedBigFont != null)
            {
                preferencesObject["vision_impaired_big_font"] = ExpressionConverter.ConvertO(bodypreferencesvisionImpairedBigFont);
                preferencesObjectpropCount++;
            }

            if (bodypreferencesvisionImpairedBorders != null)
            {
                preferencesObject["vision_impaired_borders"] = ExpressionConverter.ConvertO(bodypreferencesvisionImpairedBorders);
                preferencesObjectpropCount++;
            }

            if (bodypreferencesvisionImpairedContrastText != null)
            {
                preferencesObject["vision_impaired_contrast_text"] = ExpressionConverter.ConvertO(bodypreferencesvisionImpairedContrastText);
                preferencesObjectpropCount++;
            }

            if (bodypreferencesvisionImpairedLightColors != null)
            {
                preferencesObject["vision_impaired_light_colors"] = ExpressionConverter.ConvertO(bodypreferencesvisionImpairedLightColors);
                preferencesObjectpropCount++;
            }

            if (bodypreferencesvisionImpairedPatterns != null)
            {
                preferencesObject["vision_impaired_patterns"] = ExpressionConverter.ConvertO(bodypreferencesvisionImpairedPatterns);
                preferencesObjectpropCount++;
            }

            if (bodypreferencesvisionImpairedToday != null)
            {
                preferencesObject["vision_impaired_today"] = ExpressionConverter.ConvertO(bodypreferencesvisionImpairedToday);
                preferencesObjectpropCount++;
            }

            if (bodypreferencesvisionImpairedWeekends != null)
            {
                preferencesObject["vision_impaired_weekends"] = ExpressionConverter.ConvertO(bodypreferencesvisionImpairedWeekends);
                preferencesObjectpropCount++;
            }

            if (preferencesObjectpropCount > 0)
            {
                body["preferences"] = preferencesObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UserProfileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IBodyWorkflowAction<DummyUserResponse> AddMember(Expression<Func<string>> workspaceId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyrole = null)
        {
            var apiCallPath = String.Format("/api/v5/{0}/dummy_users", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyrole != null)
            {
                body["role"] = ExpressionConverter.ConvertO(bodyrole);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DummyUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IBodyWorkflowAction<NonExistingUserResponse> UpdateMemberNotLinkedWithExistingUser(Expression<Func<string>> workspaceId, Expression<Func<string>> memberId, Expression<Func<int>> bodycolorId = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyinitials = null, Expression<Func<string>> bodyinvitation = null, Expression<Func<bool>> bodyisGuest = null, Expression<Func<int>> bodymembershipId = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodypretendedEmail = null)
        {
            var apiCallPath = String.Format("/api/v5/{0}/dummy_users/{1}", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(memberId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycolorId != null)
            {
                body["color_id"] = ExpressionConverter.ConvertO(bodycolorId);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodyinitials != null)
            {
                body["initials"] = ExpressionConverter.ConvertO(bodyinitials);
                bodypropCount++;
            }

            if (bodyinvitation != null)
            {
                body["invitation"] = ExpressionConverter.ConvertO(bodyinvitation);
                bodypropCount++;
            }

            if (bodyisGuest != null)
            {
                body["is_guest"] = ExpressionConverter.ConvertO(bodyisGuest);
                bodypropCount++;
            }

            if (bodymembershipId != null)
            {
                body["membership_id"] = ExpressionConverter.ConvertO(bodymembershipId);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodypretendedEmail != null)
            {
                body["pretended_email"] = ExpressionConverter.ConvertO(bodypretendedEmail);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<NonExistingUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IBodyWorkflowAction<UserInfo[]> FetchMembers(Expression<Func<string>> workspaceId)
        {
            var apiCallPath = String.Format("/api/v5/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserInfo[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IBodyWorkflowAction<MemberResponse> GetMember(Expression<Func<string>> workspaceId, Expression<Func<string>> membershipId)
        {
            var apiCallPath = String.Format("/api/v5/{0}/members/{1}", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(membershipId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MemberResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IBodyWorkflowAction<MemberResponse> UpdateMember(Expression<Func<string>> workspaceId, Expression<Func<string>> membershipId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyinitials = null, Expression<Func<string>> bodycolor = null, Expression<Func<int>> bodyweight = null)
        {
            var apiCallPath = String.Format("/api/v5/{0}/members/{1}", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(membershipId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyinitials != null)
            {
                body["initials"] = ExpressionConverter.ConvertO(bodyinitials);
                bodypropCount++;
            }

            if (bodycolor != null)
            {
                body["color"] = ExpressionConverter.ConvertO(bodycolor);
                bodypropCount++;
            }

            if (bodyweight != null)
            {
                body["weight"] = ExpressionConverter.ConvertO(bodyweight);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MemberResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IWorkflowAction RemoveMember(Expression<Func<string>> workspaceId, Expression<Func<string>> memberId)
        {
            var apiCallPath = String.Format("/api/v5/{0}/members/{1}", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(memberId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IBodyWorkflowAction<TaskResponse[]> FetchTasks(Expression<Func<string>> workspaceId, Expression<Func<string>> since = null, Expression<Func<string>> until = null, Expression<Func<int[]>> users = null, Expression<Func<int[]>> tasks = null, Expression<Func<int>> group = null, Expression<Func<int[]>> tags = null, Expression<Func<int>> project = null)
        {
            var apiCallPath = String.Format("/api/v5/{0}/tasks/timeline", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (since != null)
                callPayload.Queries["since"] = ExpressionConverter.Convert(since);
            if (until != null)
                callPayload.Queries["until"] = ExpressionConverter.Convert(until);
            if (users != null)
                callPayload.Queries["users"] = ExpressionConverter.Convert(users);
            if (tasks != null)
                callPayload.Queries["tasks"] = ExpressionConverter.Convert(tasks);
            if (group != null)
                callPayload.Queries["group"] = ExpressionConverter.Convert(group);
            if (tags != null)
                callPayload.Queries["tags"] = ExpressionConverter.Convert(tags);
            if (project != null)
                callPayload.Queries["project"] = ExpressionConverter.Convert(project);
            return new ApiConnectionAction<TaskResponse[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IBodyWorkflowAction<TaskResponse> AddTask(Expression<Func<string>> workspaceId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendTime = null, Expression<Func<string>> bodycolor = null, Expression<Func<int>> bodyestimatedHours = null, Expression<Func<bool>> bodypinned = null, Expression<Func<string>> bodystatus = null, Expression<Func<int>> bodyprojectId = null, Expression<Func<int[]>> bodyworkspaceMembers = null)
        {
            var apiCallPath = String.Format("/api/v5/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["start_date"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["end_date"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodystartTime != null)
            {
                body["start_time"] = ExpressionConverter.ConvertO(bodystartTime);
                bodypropCount++;
            }

            if (bodyendTime != null)
            {
                body["end_time"] = ExpressionConverter.ConvertO(bodyendTime);
                bodypropCount++;
            }

            if (bodycolor != null)
            {
                body["color"] = ExpressionConverter.ConvertO(bodycolor);
                bodypropCount++;
            }

            if (bodyestimatedHours != null)
            {
                body["estimated_hours"] = ExpressionConverter.ConvertO(bodyestimatedHours);
                bodypropCount++;
            }

            if (bodypinned != null)
            {
                body["pinned"] = ExpressionConverter.ConvertO(bodypinned);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyprojectId != null)
            {
                body["project_id"] = ExpressionConverter.ConvertO(bodyprojectId);
                bodypropCount++;
            }

            if (bodyworkspaceMembers != null)
            {
                body["workspace_members"] = ExpressionConverter.ConvertO(bodyworkspaceMembers);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IWorkflowAction RemoveTask(Expression<Func<string>> workspaceId, Expression<Func<string>> taskId)
        {
            var apiCallPath = String.Format("/api/v5/{0}/tasks/{1}", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IBodyWorkflowAction<TaskResponse> UpdateTask(Expression<Func<string>> workspaceId, Expression<Func<string>> taskId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendTime = null, Expression<Func<string>> bodycolor = null, Expression<Func<int>> bodyestimatedHours = null, Expression<Func<bool>> bodypinned = null, Expression<Func<string>> bodystatus = null, Expression<Func<int>> bodyprojectId = null, Expression<Func<int[]>> bodyworkspaceMembers = null)
        {
            var apiCallPath = String.Format("/api/v5/{0}/tasks/{1}", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodystartDate != null)
            {
                body["start_date"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodyendDate != null)
            {
                body["end_date"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodystartTime != null)
            {
                body["start_time"] = ExpressionConverter.ConvertO(bodystartTime);
                bodypropCount++;
            }

            if (bodyendTime != null)
            {
                body["end_time"] = ExpressionConverter.ConvertO(bodyendTime);
                bodypropCount++;
            }

            if (bodycolor != null)
            {
                body["color"] = ExpressionConverter.ConvertO(bodycolor);
                bodypropCount++;
            }

            if (bodyestimatedHours != null)
            {
                body["estimated_hours"] = ExpressionConverter.ConvertO(bodyestimatedHours);
                bodypropCount++;
            }

            if (bodypinned != null)
            {
                body["pinned"] = ExpressionConverter.ConvertO(bodypinned);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyprojectId != null)
            {
                body["project_id"] = ExpressionConverter.ConvertO(bodyprojectId);
                bodypropCount++;
            }

            if (bodyworkspaceMembers != null)
            {
                body["workspace_members"] = ExpressionConverter.ConvertO(bodyworkspaceMembers);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IBodyWorkflowAction<MilestoneResponse[]> FetchMilestones(Expression<Func<string>> workspaceId, Expression<Func<string>> since = null, Expression<Func<string>> until = null, Expression<Func<int>> groups = null, Expression<Func<int>> projects = null)
        {
            var apiCallPath = String.Format("/api/v5/{0}/milestones", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (since != null)
                callPayload.Queries["since"] = ExpressionConverter.Convert(since);
            if (until != null)
                callPayload.Queries["until"] = ExpressionConverter.Convert(until);
            if (groups != null)
                callPayload.Queries["groups"] = ExpressionConverter.Convert(groups);
            if (projects != null)
                callPayload.Queries["projects"] = ExpressionConverter.Convert(projects);
            return new ApiConnectionAction<MilestoneResponse[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IBodyWorkflowAction<MilestoneResponse> AddMilestone(Expression<Func<string>> workspaceId, Expression<Func<int>> bodycolor = null, Expression<Func<int>> bodycolorID = null, Expression<Func<string>> bodydate = null, Expression<Func<bool>> bodydone = null, Expression<Func<int>> bodygroup = null, Expression<Func<bool>> bodyholiday = null, Expression<Func<string>> bodyname = null, Expression<Func<int>> bodyproject = null)
        {
            var apiCallPath = String.Format("/api/v5/{0}/milestones", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycolor != null)
            {
                body["color"] = ExpressionConverter.ConvertO(bodycolor);
                bodypropCount++;
            }

            if (bodycolorID != null)
            {
                body["color_id"] = ExpressionConverter.ConvertO(bodycolorID);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodydone != null)
            {
                body["done"] = ExpressionConverter.ConvertO(bodydone);
                bodypropCount++;
            }

            if (bodygroup != null)
            {
                body["group_id"] = ExpressionConverter.ConvertO(bodygroup);
                bodypropCount++;
            }

            if (bodyholiday != null)
            {
                body["holiday"] = ExpressionConverter.ConvertO(bodyholiday);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyproject != null)
            {
                body["project_id"] = ExpressionConverter.ConvertO(bodyproject);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MilestoneResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IBodyWorkflowAction<MilestoneResponse> GetMilestone(Expression<Func<string>> workspaceId, Expression<Func<string>> milestoneId)
        {
            var apiCallPath = String.Format("/api/v5/{0}/milestones/{1}", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(milestoneId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MilestoneResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IWorkflowAction RemoveMilestone(Expression<Func<string>> workspaceId, Expression<Func<string>> milestoneId)
        {
            var apiCallPath = String.Format("/api/v5/{0}/milestones/{1}", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(milestoneId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IBodyWorkflowAction<MilestoneResponse> UpdateMilestone(Expression<Func<string>> workspaceId, Expression<Func<string>> milestoneId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<bool>> bodydone = null, Expression<Func<bool>> bodyholiday = null, Expression<Func<int>> bodygroupId = null, Expression<Func<int>> bodyprojectId = null)
        {
            var apiCallPath = String.Format("/api/v5/{0}/milestones/{1}", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(milestoneId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodydone != null)
            {
                body["done"] = ExpressionConverter.ConvertO(bodydone);
                bodypropCount++;
            }

            if (bodyholiday != null)
            {
                body["holiday"] = ExpressionConverter.ConvertO(bodyholiday);
                bodypropCount++;
            }

            if (bodygroupId != null)
            {
                body["group_id"] = ExpressionConverter.ConvertO(bodygroupId);
                bodypropCount++;
            }

            if (bodyprojectId != null)
            {
                body["project_id"] = ExpressionConverter.ConvertO(bodyprojectId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MilestoneResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IBodyWorkflowAction<ProjectsResponseItem[]> FetchProjects(Expression<Func<string>> workspaceId)
        {
            var apiCallPath = String.Format("/api/v5/{0}/projects", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProjectsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IBodyWorkflowAction<ProjectResponse> AddProject(Expression<Func<string>> workspaceId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodycolor = null, Expression<Func<bool>> bodyboardEnabled = null)
        {
            var apiCallPath = String.Format("/api/v5/{0}/projects", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodycolor != null)
            {
                body["color"] = ExpressionConverter.ConvertO(bodycolor);
                bodypropCount++;
            }

            if (bodyboardEnabled != null)
            {
                body["board_enabled"] = ExpressionConverter.ConvertO(bodyboardEnabled);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ProjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IBodyWorkflowAction<ProjectResponse> GetProject(Expression<Func<string>> workspaceId, Expression<Func<string>> projectId)
        {
            var apiCallPath = String.Format("/api/v5/{0}/projects/{1}", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IWorkflowAction RemoveProject(Expression<Func<string>> workspaceId, Expression<Func<string>> projectId)
        {
            var apiCallPath = String.Format("/api/v5/{0}/projects/{1}", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IBodyWorkflowAction<ProjectResponse> UpdateProject(Expression<Func<string>> workspaceId, Expression<Func<string>> projectId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodycolor = null, Expression<Func<bool>> bodyboardEnabled = null)
        {
            var apiCallPath = String.Format("/api/v5/{0}/projects/{1}", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodycolor != null)
            {
                body["color"] = ExpressionConverter.ConvertO(bodycolor);
                bodypropCount++;
            }

            if (bodyboardEnabled != null)
            {
                body["board_enabled"] = ExpressionConverter.ConvertO(bodyboardEnabled);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ProjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IBodyWorkflowAction<GroupInheritedResponse[]> FetchGroups(Expression<Func<string>> workspaceId)
        {
            var apiCallPath = String.Format("/api/v5/{0}/groups", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GroupInheritedResponse[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IBodyWorkflowAction<GroupResponse> AddGroup(Expression<Func<string>> workspaceId, Expression<Func<string>> bodyname = null, Expression<Func<int[]>> bodyuserIDS = null)
        {
            var apiCallPath = String.Format("/api/v5/{0}/groups", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyuserIDS != null)
            {
                body["user_ids"] = ExpressionConverter.ConvertO(bodyuserIDS);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IBodyWorkflowAction<GroupResponse> GetGroup(Expression<Func<string>> workspaceId, Expression<Func<string>> groupId)
        {
            var apiCallPath = String.Format("/api/v5/{0}/groups/{1}", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IBodyWorkflowAction<GroupResponse> UpdateGroup(Expression<Func<string>> workspaceId, Expression<Func<string>> groupId, Expression<Func<string>> bodyname = null, Expression<Func<int[]>> bodyuserIDS = null)
        {
            var apiCallPath = String.Format("/api/v5/{0}/groups/{1}", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyuserIDS != null)
            {
                body["user_ids"] = ExpressionConverter.ConvertO(bodyuserIDS);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IWorkflowAction RemoveGroup(Expression<Func<string>> workspaceId, Expression<Func<string>> groupId)
        {
            var apiCallPath = String.Format("/api/v5/{0}/groups/{1}", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IBodyWorkflowAction<GroupMembershipResponse> AddUserToGroup(Expression<Func<string>> workspaceId, Expression<Func<string>> groupId, Expression<Func<int>> bodyuserId = null)
        {
            var apiCallPath = String.Format("/api/v5/{0}/groups/{1}/memberships", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyuserId != null)
            {
                body["user_id"] = ExpressionConverter.ConvertO(bodyuserId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GroupMembershipResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "togglplanip")]
        public IWorkflowAction RemoveGroupMember(Expression<Func<string>> workspaceId, Expression<Func<string>> groupId, Expression<Func<string>> membershipId)
        {
            var apiCallPath = String.Format("/api/v5/{0}/groups/{1}/memberships/{2}", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(groupId, 1), ExpressionConverter.ConvertWithUrlEncoding(membershipId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class TogglplanipTriggers([ConnectionName] string connectionId)
    {
    }

    public class UserProfileResponse
    {
        [JsonProperty("color_id")]
        public int ColorID { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("email_verified_at")]
        public string EmailVerifiedAt { get; set; }

        [JsonProperty("has_picture")]
        public bool HasPicture { get; set; }

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("initials")]
        public string Initials { get; set; }

        [JsonProperty("invitations")]
        public JToken[] Invitations { get; set; }

        [JsonProperty("legal_consent_pending")]
        public bool LegalConsentPending { get; set; }

        [JsonProperty("manager")]
        public string Manager { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("picture_url")]
        public string PictureURL { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("preferences")]
        public UserProfilePreferences Preferences { get; set; }

        [JsonProperty("workspaces")]
        public UserProfileWorkspaces[] Workspaces { get; set; }
    }

    public class UserProfilePreferences
    {
        [JsonProperty("hide_weekends")]
        public bool HideWeekends { get; set; }

        [JsonProperty("highlight_done_tasks")]
        public bool HighlightDoneTasks { get; set; }

        [JsonProperty("onboarding_emails")]
        public bool OnboardingEmails { get; set; }

        [JsonProperty("pin_me_on_top")]
        public bool PinMeOnTop { get; set; }

        [JsonProperty("selected_account_id")]
        public string SelectedAccountID { get; set; }

        [JsonProperty("selected_group_id")]
        public string SelectedGroupID { get; set; }

        [JsonProperty("selected_project_id")]
        public string SelectedProjectID { get; set; }

        [JsonProperty("start_of_week")]
        public int StartOfWeek { get; set; }

        [JsonProperty("task_notifications")]
        public bool TaskNotifications { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("vision_impaired")]
        public bool VisionImpaired { get; set; }

        [JsonProperty("vision_impaired_big_font")]
        public bool VisionImpairedBigFont { get; set; }

        [JsonProperty("vision_impaired_borders")]
        public bool VisionImpairedBorders { get; set; }

        [JsonProperty("vision_impaired_contrast_text")]
        public bool VisionImpairedContrastText { get; set; }

        [JsonProperty("vision_impaired_light_colors")]
        public bool VisionImpairedLightColors { get; set; }

        [JsonProperty("vision_impaired_patterns")]
        public bool VisionImpairedPatterns { get; set; }

        [JsonProperty("vision_impaired_today")]
        public bool VisionImpairedToday { get; set; }

        [JsonProperty("vision_impaired_weekends")]
        public bool VisionImpairedWeekends { get; set; }
    }

    public class UserProfileWorkspaces
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("custom_colors")]
        public JToken[] CustomColors { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pricing_system")]
        public string PricingSystem { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("suspended_at")]
        public string SuspendedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class DummyUserResponse
    {
        [JsonProperty("color_id")]
        public int ColorId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public int UserID { get; set; }

        [JsonProperty("initials")]
        public string Initials { get; set; }

        [JsonProperty("invitation")]
        public string Invitation { get; set; }

        [JsonProperty("is_guest")]
        public bool IsGuest { get; set; }

        [JsonProperty("membership_id")]
        public int MembershipId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pretended_email")]
        public string PretendedEmail { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class NonExistingUserResponse
    {
        [JsonProperty("color_id")]
        public int ColorId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("initials")]
        public string Initials { get; set; }

        [JsonProperty("invitation")]
        public string Invitation { get; set; }

        [JsonProperty("is_guest")]
        public string IsGuest { get; set; }

        [JsonProperty("membership_id")]
        public string MembershipId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pretended_email")]
        public string PretendedEmail { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class UserInfo
    {
        [JsonProperty("activated_at")]
        public string ActivatedAt { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("color_id")]
        public int ColorId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("deactivated_at")]
        public string DeactivatedAt { get; set; }

        [JsonProperty("dummy")]
        public bool Dummy { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("hours_per_work_day")]
        public string HoursPerWorkDay { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("initials")]
        public string Initials { get; set; }

        [JsonProperty("invitation")]
        public string Invitation { get; set; }

        [JsonProperty("is_guest")]
        public bool IsGuest { get; set; }

        [JsonProperty("membership_id")]
        public int MembershipId { get; set; }

        [JsonProperty("minutes_per_work_day")]
        public string MinutesPerWorkDay { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("picture_url")]
        public string PictureUrl { get; set; }

        [JsonProperty("preferences")]
        public UserPreferences Preferences { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user")]
        public UserObject User { get; set; }
    }

    public class UserPreferences
    {
        [JsonProperty("holidays_locale")]
        public string HolidaysLocale { get; set; }

        [JsonProperty("tracking_access_token")]
        public string TrackingAccessToken { get; set; }

        [JsonProperty("weekly_digest")]
        public bool WeeklyDigest { get; set; }
    }

    public class UserObject
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("initials")]
        public string Initials { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pretended_email")]
        public string PretendedEmail { get; set; }

        [JsonProperty("suspended_at")]
        public string SuspendedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class MemberResponse
    {
        [JsonProperty("activated_at")]
        public string ActivatedAt { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("color_id")]
        public int ColorId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("deactivated_at")]
        public string DeactivatedAt { get; set; }

        [JsonProperty("dummy")]
        public bool Dummy { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("hours_per_work_day")]
        public string HoursPerWorkDay { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("initials")]
        public string Initials { get; set; }

        [JsonProperty("invitation")]
        public string Invitation { get; set; }

        [JsonProperty("is_guest")]
        public bool IsGuest { get; set; }

        [JsonProperty("membership_id")]
        public int MembershipId { get; set; }

        [JsonProperty("minutes_per_work_day")]
        public string MinutesPerWorkDay { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("picture_url")]
        public string PictureUrl { get; set; }

        [JsonProperty("preferences")]
        public MemberResponsePreferencesType Preferences { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user")]
        public MemberResponseUserType User { get; set; }
    }

    public class MemberResponsePreferencesType
    {
        [JsonProperty("holidays_locale")]
        public string HolidaysLocale { get; set; }

        [JsonProperty("tracking_access_token")]
        public string TrackingAccessToken { get; set; }

        [JsonProperty("weekly_digest")]
        public bool WeeklyDigest { get; set; }
    }

    public class MemberResponseUserType
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("initials")]
        public string Initials { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pretended_email")]
        public string PretendedEmail { get; set; }

        [JsonProperty("suspended_at")]
        public string SuspendedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class TaskResponse
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("color_id")]
        public string ColorId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("created_by")]
        public int CreatedBy { get; set; }

        [JsonProperty("done")]
        public bool Done { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        [JsonProperty("estimate_type")]
        public string EstimateType { get; set; }

        [JsonProperty("estimated_minutes")]
        public string EstimatedMinutes { get; set; }

        [JsonProperty("folder_id")]
        public string FolderId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("original_repeated_task_id")]
        public string OriginalRepeatedTaskId { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("plan_status_position")]
        public string PlanStatusPosition { get; set; }

        [JsonProperty("project")]
        public TaskResponseProjectType Project { get; set; }

        [JsonProperty("project_id")]
        public int ProjectId { get; set; }

        [JsonProperty("project_segment")]
        public TaskResponseProjectSegmentType ProjectSegment { get; set; }

        [JsonProperty("project_segment_id")]
        public int ProjectSegmentId { get; set; }

        [JsonProperty("repetition_rule")]
        public string RepetitionRule { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tag_ids")]
        public int[] TagIds { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("updated_by")]
        public int UpdatedBy { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("visible_properties")]
        public string[] VisibleProperties { get; set; }

        [JsonProperty("weight")]
        public string Weight { get; set; }

        [JsonProperty("workspace_members")]
        public int[] WorkspaceMembers { get; set; }
    }

    public class TaskResponseProjectType
    {
        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("board_enabled")]
        public bool BoardEnabled { get; set; }

        [JsonProperty("color")]
        public int Color { get; set; }

        [JsonProperty("color_id")]
        public int ColorId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("timeline_enabled")]
        public bool TimelineEnabled { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class TaskResponseProjectSegmentType
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("project_id")]
        public int ProjectId { get; set; }
    }

    public class MilestoneResponse
    {
        [JsonProperty("color")]
        public int Color { get; set; }

        [JsonProperty("color_id")]
        public int ColorId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("done")]
        public bool Done { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("holiday")]
        public bool Holiday { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("project_id")]
        public int ProjectId { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class ProjectsResponseItem
    {
        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("board_enabled")]
        public bool BoardEnabled { get; set; }

        [JsonProperty("color")]
        public int Color { get; set; }

        [JsonProperty("color_id")]
        public int ColorId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("segments")]
        public ProjectsResponseItemSegmentsTypeItem[] Segments { get; set; }

        [JsonProperty("tags")]
        public ProjectsResponseItemTagsTypeItem[] Tags { get; set; }

        [JsonProperty("timeline_enabled")]
        public bool TimelineEnabled { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("statuses")]
        public ProjectsResponseItemStatusesTypeItem[] Statuses { get; set; }
    }

    public class ProjectsResponseItemSegmentsTypeItem
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("project_id")]
        public int ProjectId { get; set; }
    }

    public class ProjectsResponseItemTagsTypeItem
    {
        [JsonProperty("color_id")]
        public int ColorId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("custom_color_id")]
        public string CustomColorId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("plan_id")]
        public int PlanId { get; set; }
    }

    public class ProjectsResponseItemStatusesTypeItem
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_done")]
        public bool IsDone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("plan_id")]
        public int PlanId { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }
    }

    public class ProjectResponse
    {
        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("board_enabled")]
        public bool BoardEnabled { get; set; }

        [JsonProperty("color")]
        public int Color { get; set; }

        [JsonProperty("color_id")]
        public int ColorId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("segments")]
        public ProjectResponseSegmentsTypeItem[] Segments { get; set; }

        [JsonProperty("tags")]
        public ProjectResponseTagsTypeItem[] Tags { get; set; }

        [JsonProperty("timeline_enabled")]
        public bool TimelineEnabled { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("statuses")]
        public ProjectResponseStatusesTypeItem[] Statuses { get; set; }
    }

    public class ProjectResponseSegmentsTypeItem
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("project_id")]
        public int ProjectId { get; set; }
    }

    public class ProjectResponseTagsTypeItem
    {
        [JsonProperty("color_id")]
        public int ColorId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("custom_color_id")]
        public string CustomColorId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("plan_id")]
        public int PlanId { get; set; }
    }

    public class ProjectResponseStatusesTypeItem
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_done")]
        public bool IsDone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("plan_id")]
        public int PlanId { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }
    }

    public class GroupInheritedResponse
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("memberships")]
        public GroupInheritedResponseMembershipsTypeItem[] Memberships { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class GroupInheritedResponseMembershipsTypeItem
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }

    public class GroupResponse
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }

    public class GroupMembershipResponse
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Togglplanip;

    public partial class WorkflowManagedActions
    {
        public TogglplanipActions Togglplanip(string connectionId) => new TogglplanipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TogglplanipTriggers Togglplanip(string connectionId) => new TogglplanipTriggers(connectionId);
    }
}