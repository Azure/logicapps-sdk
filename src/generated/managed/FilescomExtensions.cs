//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Filescom
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FilescomActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<PatchUserResponse> PatchUser(Expression<Func<string>> bodyauthenticationMethod = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodygroupIds = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodypassword = null, Expression<Func<bool>> bodyrequirePasswordChange = null, Expression<Func<string>> bodyuserHome = null, Expression<Func<string>> bodyuserRoot = null, Expression<Func<string>> bodyusername = null)
        {
            var apiCallPath = "/user";
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyauthenticationMethod != null)
            {
                body["authentication_method"] = ExpressionConverter.ConvertO(bodyauthenticationMethod);
                bodypropCount++;
            }

            if (bodycompany != null)
            {
                body["company"] = ExpressionConverter.ConvertO(bodycompany);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodygroupIds != null)
            {
                body["group_ids"] = ExpressionConverter.ConvertO(bodygroupIds);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodyrequirePasswordChange != null)
            {
                body["require_password_change"] = ExpressionConverter.ConvertO(bodyrequirePasswordChange);
                bodypropCount++;
            }

            if (bodyuserHome != null)
            {
                body["user_home"] = ExpressionConverter.ConvertO(bodyuserHome);
                bodypropCount++;
            }

            if (bodyuserRoot != null)
            {
                body["user_root"] = ExpressionConverter.ConvertO(bodyuserRoot);
                bodypropCount++;
            }

            if (bodyusername != null)
            {
                body["username"] = ExpressionConverter.ConvertO(bodyusername);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PatchUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<GetUsersIdResponse> GetUsersId(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetUsersIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IWorkflowAction DeleteUsersId(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<PatchUsersIdResponse> PatchUsersId(Expression<Func<int>> id, Expression<Func<string>> bodyauthenticationMethod = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodygroupIds = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodypassword = null, Expression<Func<bool>> bodyrequirePasswordChange = null, Expression<Func<string>> bodyuserHome = null, Expression<Func<string>> bodyuserRoot = null, Expression<Func<string>> bodyusername = null)
        {
            var apiCallPath = String.Format("/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyauthenticationMethod != null)
            {
                body["authentication_method"] = ExpressionConverter.ConvertO(bodyauthenticationMethod);
                bodypropCount++;
            }

            if (bodycompany != null)
            {
                body["company"] = ExpressionConverter.ConvertO(bodycompany);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodygroupIds != null)
            {
                body["group_ids"] = ExpressionConverter.ConvertO(bodygroupIds);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodyrequirePasswordChange != null)
            {
                body["require_password_change"] = ExpressionConverter.ConvertO(bodyrequirePasswordChange);
                bodypropCount++;
            }

            if (bodyuserHome != null)
            {
                body["user_home"] = ExpressionConverter.ConvertO(bodyuserHome);
                bodypropCount++;
            }

            if (bodyuserRoot != null)
            {
                body["user_root"] = ExpressionConverter.ConvertO(bodyuserRoot);
                bodypropCount++;
            }

            if (bodyusername != null)
            {
                body["username"] = ExpressionConverter.ConvertO(bodyusername);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PatchUsersIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<GetUsersResponseItem[]> GetUsers()
        {
            var apiCallPath = "/users";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetUsersResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<PostUsersResponse> PostUsers(Expression<Func<string>> bodyusername, Expression<Func<string>> bodyauthenticationMethod = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodygroupIds = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodypassword = null, Expression<Func<bool>> bodyrequirePasswordChange = null, Expression<Func<string>> bodyuserHome = null, Expression<Func<string>> bodyuserRoot = null)
        {
            var apiCallPath = "/users";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyauthenticationMethod != null)
            {
                body["authentication_method"] = ExpressionConverter.ConvertO(bodyauthenticationMethod);
                bodypropCount++;
            }

            if (bodycompany != null)
            {
                body["company"] = ExpressionConverter.ConvertO(bodycompany);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodygroupIds != null)
            {
                body["group_ids"] = ExpressionConverter.ConvertO(bodygroupIds);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodyrequirePasswordChange != null)
            {
                body["require_password_change"] = ExpressionConverter.ConvertO(bodyrequirePasswordChange);
                bodypropCount++;
            }

            if (bodyuserHome != null)
            {
                body["user_home"] = ExpressionConverter.ConvertO(bodyuserHome);
                bodypropCount++;
            }

            if (bodyuserRoot != null)
            {
                body["user_root"] = ExpressionConverter.ConvertO(bodyuserRoot);
                bodypropCount++;
            }

            bodypropCount++;
            body["username"] = ExpressionConverter.ConvertO(bodyusername);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PostUsersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<GetBundleDownloadsResponseItem[]> GetBundleDownloads(Expression<Func<int>> bundleId = null)
        {
            var apiCallPath = "/bundle_downloads";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (bundleId != null)
                callPayload.Queries["bundle_id"] = ExpressionConverter.Convert(bundleId);
            return new ApiConnectionAction<GetBundleDownloadsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<GetBundleNotificationsIdResponse> GetBundleNotificationsId(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/bundle_notifications/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetBundleNotificationsIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IWorkflowAction DeleteBundleNotificationsId(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/bundle_notifications/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<PatchBundleNotificationsIdResponse> PatchBundleNotificationsId(Expression<Func<int>> id, Expression<Func<bool>> bodynotifyOnRegistration = null, Expression<Func<bool>> bodynotifyOnUpload = null)
        {
            var apiCallPath = String.Format("/bundle_notifications/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodynotifyOnRegistration != null)
            {
                body["notify_on_registration"] = ExpressionConverter.ConvertO(bodynotifyOnRegistration);
                bodypropCount++;
            }

            if (bodynotifyOnUpload != null)
            {
                body["notify_on_upload"] = ExpressionConverter.ConvertO(bodynotifyOnUpload);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PatchBundleNotificationsIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<GetBundleNotificationsResponseItem[]> GetBundleNotifications()
        {
            var apiCallPath = "/bundle_notifications";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetBundleNotificationsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<PostBundleNotificationsResponse> PostBundleNotifications(Expression<Func<int>> bodybundleId, Expression<Func<int>> bodynotifyUserId = null)
        {
            var apiCallPath = "/bundle_notifications";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["bundle_id"] = ExpressionConverter.ConvertO(bodybundleId);
            if (bodynotifyUserId != null)
            {
                body["notify_user_id"] = ExpressionConverter.ConvertO(bodynotifyUserId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PostBundleNotificationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<GetBundleRecipientsResponseItem[]> GetBundleRecipients(Expression<Func<int>> bundleId)
        {
            var apiCallPath = "/bundle_recipients";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["bundle_id"] = ExpressionConverter.Convert(bundleId);
            return new ApiConnectionAction<GetBundleRecipientsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<PostBundleRecipientsResponse> PostBundleRecipients(Expression<Func<int>> bodybundleId, Expression<Func<string>> bodyrecipient, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodynote = null)
        {
            var apiCallPath = "/bundle_recipients";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["bundle_id"] = ExpressionConverter.ConvertO(bodybundleId);
            if (bodycompany != null)
            {
                body["company"] = ExpressionConverter.ConvertO(bodycompany);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["note"] = ExpressionConverter.ConvertO(bodynote);
                bodypropCount++;
            }

            bodypropCount++;
            body["recipient"] = ExpressionConverter.ConvertO(bodyrecipient);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PostBundleRecipientsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<GetBundleRegistrationsResponseItem[]> GetBundleRegistrations(Expression<Func<int>> bundleId = null)
        {
            var apiCallPath = "/bundle_registrations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (bundleId != null)
                callPayload.Queries["bundle_id"] = ExpressionConverter.Convert(bundleId);
            return new ApiConnectionAction<GetBundleRegistrationsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<GetBundlesIdResponse> GetBundlesId(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/bundles/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetBundlesIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IWorkflowAction DeleteBundlesId(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/bundles/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<PatchBundlesIdResponse> PatchBundlesId(Expression<Func<int>> id, Expression<Func<string>> bodyexpiresAt = null)
        {
            var apiCallPath = String.Format("/bundles/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyexpiresAt != null)
            {
                body["expires_at"] = ExpressionConverter.ConvertO(bodyexpiresAt);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PatchBundlesIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<GetBundlesResponseItem[]> GetBundles()
        {
            var apiCallPath = "/bundles";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetBundlesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<PostBundlesResponse> PostBundles(Expression<Func<string[]>> bodypaths, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyexpiresAt = null, Expression<Func<int>> bodymaxUses = null, Expression<Func<string>> bodynote = null, Expression<Func<string>> bodypassword = null, Expression<Func<bool>> bodyrequireRegistration = null)
        {
            var apiCallPath = "/bundles";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyexpiresAt != null)
            {
                body["expires_at"] = ExpressionConverter.ConvertO(bodyexpiresAt);
                bodypropCount++;
            }

            if (bodymaxUses != null)
            {
                body["max_uses"] = ExpressionConverter.ConvertO(bodymaxUses);
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["note"] = ExpressionConverter.ConvertO(bodynote);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            bodypropCount++;
            body["paths"] = ExpressionConverter.ConvertO(bodypaths);
            if (bodyrequireRegistration != null)
            {
                body["require_registration"] = ExpressionConverter.ConvertO(bodyrequireRegistration);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PostBundlesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IWorkflowAction DeleteFilesPath(Expression<Func<string>> path)
        {
            var apiCallPath = String.Format("/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(path, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<FileActionFindResponse> FileActionFind(Expression<Func<string>> path)
        {
            var apiCallPath = String.Format("/file_actions/metadata/{0}", ExpressionConverter.ConvertWithUrlEncoding(path, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FileActionFindResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<FileActionCopyResponse> FileActionCopy(Expression<Func<string>> path, Expression<Func<string>> bodydestination)
        {
            var apiCallPath = String.Format("/file_actions/copy/{0}", ExpressionConverter.ConvertWithUrlEncoding(path, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["destination"] = ExpressionConverter.ConvertO(bodydestination);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FileActionCopyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<FileActionMoveResponse> FileActionMove(Expression<Func<string>> path, Expression<Func<string>> bodydestination)
        {
            var apiCallPath = String.Format("/file_actions/move/{0}", ExpressionConverter.ConvertWithUrlEncoding(path, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["destination"] = ExpressionConverter.ConvertO(bodydestination);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FileActionMoveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<FolderListForPathResponseItem[]> FolderListForPath(Expression<Func<string>> path)
        {
            var apiCallPath = String.Format("/folders/{0}", ExpressionConverter.ConvertWithUrlEncoding(path, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FolderListForPathResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<PostFoldersPathResponse> PostFoldersPath(Expression<Func<string>> path)
        {
            var apiCallPath = String.Format("/folders/{0}", ExpressionConverter.ConvertWithUrlEncoding(path, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PostFoldersPathResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<PostGroupsGroupIdUsersResponse> PostGroupsGroupIdUsers(Expression<Func<int>> groupId, Expression<Func<string>> bodyusername, Expression<Func<string>> bodyauthenticationMethod = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodygroupIds = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodypassword = null, Expression<Func<bool>> bodyrequirePasswordChange = null, Expression<Func<string>> bodyuserHome = null, Expression<Func<string>> bodyuserRoot = null)
        {
            var apiCallPath = String.Format("/groups/{0}/users", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyauthenticationMethod != null)
            {
                body["authentication_method"] = ExpressionConverter.ConvertO(bodyauthenticationMethod);
                bodypropCount++;
            }

            if (bodycompany != null)
            {
                body["company"] = ExpressionConverter.ConvertO(bodycompany);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodygroupIds != null)
            {
                body["group_ids"] = ExpressionConverter.ConvertO(bodygroupIds);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodyrequirePasswordChange != null)
            {
                body["require_password_change"] = ExpressionConverter.ConvertO(bodyrequirePasswordChange);
                bodypropCount++;
            }

            if (bodyuserHome != null)
            {
                body["user_home"] = ExpressionConverter.ConvertO(bodyuserHome);
                bodypropCount++;
            }

            if (bodyuserRoot != null)
            {
                body["user_root"] = ExpressionConverter.ConvertO(bodyuserRoot);
                bodypropCount++;
            }

            bodypropCount++;
            body["username"] = ExpressionConverter.ConvertO(bodyusername);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PostGroupsGroupIdUsersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<GetGroupsIdResponse> GetGroupsId(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/groups/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetGroupsIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IWorkflowAction DeleteGroupsId(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/groups/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<PatchGroupsIdResponse> PatchGroupsId(Expression<Func<int>> id, Expression<Func<string>> bodyadminIds = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodyuserIds = null)
        {
            var apiCallPath = String.Format("/groups/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyadminIds != null)
            {
                body["admin_ids"] = ExpressionConverter.ConvertO(bodyadminIds);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodyuserIds != null)
            {
                body["user_ids"] = ExpressionConverter.ConvertO(bodyuserIds);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PatchGroupsIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<GetGroupsResponseItem[]> GetGroups()
        {
            var apiCallPath = "/groups";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetGroupsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<PostGroupsResponse> PostGroups(Expression<Func<string>> bodyname, Expression<Func<string>> bodyadminIds = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodyuserIds = null)
        {
            var apiCallPath = "/groups";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyadminIds != null)
            {
                body["admin_ids"] = ExpressionConverter.ConvertO(bodyadminIds);
                bodypropCount++;
            }

            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodynotes != null)
            {
                body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodyuserIds != null)
            {
                body["user_ids"] = ExpressionConverter.ConvertO(bodyuserIds);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PostGroupsResponse>(callPayload);
        }
    }

    public class FilescomTriggers([ConnectionName] string connectionId)
    {
    }

    public class PatchUserResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("admin_group_ids")]
        public int[] AdminGroupIds { get; set; }

        [JsonProperty("allowed_ips")]
        public string AllowedIps { get; set; }

        [JsonProperty("attachments_permission")]
        public bool AttachmentsPermission { get; set; }

        [JsonProperty("api_keys_count")]
        public int ApiKeysCount { get; set; }

        [JsonProperty("authenticate_until")]
        public string AuthenticateUntil { get; set; }

        [JsonProperty("authentication_method")]
        public string AuthenticationMethod { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("billable")]
        public bool Billable { get; set; }

        [JsonProperty("billing_permission")]
        public bool BillingPermission { get; set; }

        [JsonProperty("bypass_site_allowed_ips")]
        public bool BypassSiteAllowedIps { get; set; }

        [JsonProperty("bypass_user_lifecycle_rules")]
        public bool BypassUserLifecycleRules { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("dav_permission")]
        public bool DavPermission { get; set; }

        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("disabled_expired_or_inactive")]
        public bool DisabledExpiredOrInactive { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("filesystem_layout")]
        public string FilesystemLayout { get; set; }

        [JsonProperty("first_login_at")]
        public string FirstLoginAt { get; set; }

        [JsonProperty("ftp_permission")]
        public bool FtpPermission { get; set; }

        [JsonProperty("group_ids")]
        public string GroupIds { get; set; }

        [JsonProperty("header_text")]
        public string HeaderText { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("last_login_at")]
        public string LastLoginAt { get; set; }

        [JsonProperty("last_web_login_at")]
        public string LastWebLoginAt { get; set; }

        [JsonProperty("last_ftp_login_at")]
        public string LastFtpLoginAt { get; set; }

        [JsonProperty("last_sftp_login_at")]
        public string LastSftpLoginAt { get; set; }

        [JsonProperty("last_dav_login_at")]
        public string LastDavLoginAt { get; set; }

        [JsonProperty("last_desktop_login_at")]
        public string LastDesktopLoginAt { get; set; }

        [JsonProperty("last_restapi_login_at")]
        public string LastRestapiLoginAt { get; set; }

        [JsonProperty("last_api_use_at")]
        public string LastApiUseAt { get; set; }

        [JsonProperty("last_active_at")]
        public string LastActiveAt { get; set; }

        [JsonProperty("last_protocol_cipher")]
        public string LastProtocolCipher { get; set; }

        [JsonProperty("lockout_expires")]
        public string LockoutExpires { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("notification_daily_send_time")]
        public int NotificationDailySendTime { get; set; }

        [JsonProperty("office_integration_enabled")]
        public bool OfficeIntegrationEnabled { get; set; }

        [JsonProperty("partner_admin")]
        public bool PartnerAdmin { get; set; }

        [JsonProperty("partner_id")]
        public int PartnerId { get; set; }

        [JsonProperty("partner_name")]
        public string PartnerName { get; set; }

        [JsonProperty("password_set_at")]
        public string PasswordSetAt { get; set; }

        [JsonProperty("password_validity_days")]
        public int PasswordValidityDays { get; set; }

        [JsonProperty("public_keys_count")]
        public int PublicKeysCount { get; set; }

        [JsonProperty("receive_admin_alerts")]
        public bool ReceiveAdminAlerts { get; set; }

        [JsonProperty("require_2fa")]
        public string Require2fa { get; set; }

        [JsonProperty("require_login_by")]
        public string RequireLoginBy { get; set; }

        [JsonProperty("active_2fa")]
        public bool Active2fa { get; set; }

        [JsonProperty("require_password_change")]
        public bool RequirePasswordChange { get; set; }

        [JsonProperty("password_expired")]
        public bool PasswordExpired { get; set; }

        [JsonProperty("readonly_site_admin")]
        public bool ReadonlySiteAdmin { get; set; }

        [JsonProperty("restapi_permission")]
        public bool RestapiPermission { get; set; }

        [JsonProperty("self_managed")]
        public bool SelfManaged { get; set; }

        [JsonProperty("sftp_permission")]
        public bool SftpPermission { get; set; }

        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }

        [JsonProperty("site_id")]
        public int SiteId { get; set; }

        [JsonProperty("skip_welcome_screen")]
        public bool SkipWelcomeScreen { get; set; }

        [JsonProperty("ssl_required")]
        public string SslRequired { get; set; }

        [JsonProperty("sso_strategy_id")]
        public int SsoStrategyId { get; set; }

        [JsonProperty("subscribe_to_newsletter")]
        public bool SubscribeToNewsletter { get; set; }

        [JsonProperty("externally_managed")]
        public bool ExternallyManaged { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }

        [JsonProperty("type_of_2fa")]
        public string TypeOf2fa { get; set; }

        [JsonProperty("type_of_2fa_for_display")]
        public string TypeOf2faForDisplay { get; set; }

        [JsonProperty("user_root")]
        public string UserRoot { get; set; }

        [JsonProperty("user_home")]
        public string UserHome { get; set; }

        [JsonProperty("days_remaining_until_password_expire")]
        public int DaysRemainingUntilPasswordExpire { get; set; }

        [JsonProperty("password_expire_at")]
        public string PasswordExpireAt { get; set; }
    }

    public class GetUsersIdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("admin_group_ids")]
        public int[] AdminGroupIds { get; set; }

        [JsonProperty("allowed_ips")]
        public string AllowedIps { get; set; }

        [JsonProperty("attachments_permission")]
        public bool AttachmentsPermission { get; set; }

        [JsonProperty("api_keys_count")]
        public int ApiKeysCount { get; set; }

        [JsonProperty("authenticate_until")]
        public string AuthenticateUntil { get; set; }

        [JsonProperty("authentication_method")]
        public string AuthenticationMethod { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("billable")]
        public bool Billable { get; set; }

        [JsonProperty("billing_permission")]
        public bool BillingPermission { get; set; }

        [JsonProperty("bypass_site_allowed_ips")]
        public bool BypassSiteAllowedIps { get; set; }

        [JsonProperty("bypass_user_lifecycle_rules")]
        public bool BypassUserLifecycleRules { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("dav_permission")]
        public bool DavPermission { get; set; }

        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("disabled_expired_or_inactive")]
        public bool DisabledExpiredOrInactive { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("filesystem_layout")]
        public string FilesystemLayout { get; set; }

        [JsonProperty("first_login_at")]
        public string FirstLoginAt { get; set; }

        [JsonProperty("ftp_permission")]
        public bool FtpPermission { get; set; }

        [JsonProperty("group_ids")]
        public string GroupIds { get; set; }

        [JsonProperty("header_text")]
        public string HeaderText { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("last_login_at")]
        public string LastLoginAt { get; set; }

        [JsonProperty("last_web_login_at")]
        public string LastWebLoginAt { get; set; }

        [JsonProperty("last_ftp_login_at")]
        public string LastFtpLoginAt { get; set; }

        [JsonProperty("last_sftp_login_at")]
        public string LastSftpLoginAt { get; set; }

        [JsonProperty("last_dav_login_at")]
        public string LastDavLoginAt { get; set; }

        [JsonProperty("last_desktop_login_at")]
        public string LastDesktopLoginAt { get; set; }

        [JsonProperty("last_restapi_login_at")]
        public string LastRestapiLoginAt { get; set; }

        [JsonProperty("last_api_use_at")]
        public string LastApiUseAt { get; set; }

        [JsonProperty("last_active_at")]
        public string LastActiveAt { get; set; }

        [JsonProperty("last_protocol_cipher")]
        public string LastProtocolCipher { get; set; }

        [JsonProperty("lockout_expires")]
        public string LockoutExpires { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("notification_daily_send_time")]
        public int NotificationDailySendTime { get; set; }

        [JsonProperty("office_integration_enabled")]
        public bool OfficeIntegrationEnabled { get; set; }

        [JsonProperty("partner_admin")]
        public bool PartnerAdmin { get; set; }

        [JsonProperty("partner_id")]
        public int PartnerId { get; set; }

        [JsonProperty("partner_name")]
        public string PartnerName { get; set; }

        [JsonProperty("password_set_at")]
        public string PasswordSetAt { get; set; }

        [JsonProperty("password_validity_days")]
        public int PasswordValidityDays { get; set; }

        [JsonProperty("public_keys_count")]
        public int PublicKeysCount { get; set; }

        [JsonProperty("receive_admin_alerts")]
        public bool ReceiveAdminAlerts { get; set; }

        [JsonProperty("require_2fa")]
        public string Require2fa { get; set; }

        [JsonProperty("require_login_by")]
        public string RequireLoginBy { get; set; }

        [JsonProperty("active_2fa")]
        public bool Active2fa { get; set; }

        [JsonProperty("require_password_change")]
        public bool RequirePasswordChange { get; set; }

        [JsonProperty("password_expired")]
        public bool PasswordExpired { get; set; }

        [JsonProperty("readonly_site_admin")]
        public bool ReadonlySiteAdmin { get; set; }

        [JsonProperty("restapi_permission")]
        public bool RestapiPermission { get; set; }

        [JsonProperty("self_managed")]
        public bool SelfManaged { get; set; }

        [JsonProperty("sftp_permission")]
        public bool SftpPermission { get; set; }

        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }

        [JsonProperty("site_id")]
        public int SiteId { get; set; }

        [JsonProperty("skip_welcome_screen")]
        public bool SkipWelcomeScreen { get; set; }

        [JsonProperty("ssl_required")]
        public string SslRequired { get; set; }

        [JsonProperty("sso_strategy_id")]
        public int SsoStrategyId { get; set; }

        [JsonProperty("subscribe_to_newsletter")]
        public bool SubscribeToNewsletter { get; set; }

        [JsonProperty("externally_managed")]
        public bool ExternallyManaged { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }

        [JsonProperty("type_of_2fa")]
        public string TypeOf2fa { get; set; }

        [JsonProperty("type_of_2fa_for_display")]
        public string TypeOf2faForDisplay { get; set; }

        [JsonProperty("user_root")]
        public string UserRoot { get; set; }

        [JsonProperty("user_home")]
        public string UserHome { get; set; }

        [JsonProperty("days_remaining_until_password_expire")]
        public int DaysRemainingUntilPasswordExpire { get; set; }

        [JsonProperty("password_expire_at")]
        public string PasswordExpireAt { get; set; }
    }

    public class PatchUsersIdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("admin_group_ids")]
        public int[] AdminGroupIds { get; set; }

        [JsonProperty("allowed_ips")]
        public string AllowedIps { get; set; }

        [JsonProperty("attachments_permission")]
        public bool AttachmentsPermission { get; set; }

        [JsonProperty("api_keys_count")]
        public int ApiKeysCount { get; set; }

        [JsonProperty("authenticate_until")]
        public string AuthenticateUntil { get; set; }

        [JsonProperty("authentication_method")]
        public string AuthenticationMethod { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("billable")]
        public bool Billable { get; set; }

        [JsonProperty("billing_permission")]
        public bool BillingPermission { get; set; }

        [JsonProperty("bypass_site_allowed_ips")]
        public bool BypassSiteAllowedIps { get; set; }

        [JsonProperty("bypass_user_lifecycle_rules")]
        public bool BypassUserLifecycleRules { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("dav_permission")]
        public bool DavPermission { get; set; }

        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("disabled_expired_or_inactive")]
        public bool DisabledExpiredOrInactive { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("filesystem_layout")]
        public string FilesystemLayout { get; set; }

        [JsonProperty("first_login_at")]
        public string FirstLoginAt { get; set; }

        [JsonProperty("ftp_permission")]
        public bool FtpPermission { get; set; }

        [JsonProperty("group_ids")]
        public string GroupIds { get; set; }

        [JsonProperty("header_text")]
        public string HeaderText { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("last_login_at")]
        public string LastLoginAt { get; set; }

        [JsonProperty("last_web_login_at")]
        public string LastWebLoginAt { get; set; }

        [JsonProperty("last_ftp_login_at")]
        public string LastFtpLoginAt { get; set; }

        [JsonProperty("last_sftp_login_at")]
        public string LastSftpLoginAt { get; set; }

        [JsonProperty("last_dav_login_at")]
        public string LastDavLoginAt { get; set; }

        [JsonProperty("last_desktop_login_at")]
        public string LastDesktopLoginAt { get; set; }

        [JsonProperty("last_restapi_login_at")]
        public string LastRestapiLoginAt { get; set; }

        [JsonProperty("last_api_use_at")]
        public string LastApiUseAt { get; set; }

        [JsonProperty("last_active_at")]
        public string LastActiveAt { get; set; }

        [JsonProperty("last_protocol_cipher")]
        public string LastProtocolCipher { get; set; }

        [JsonProperty("lockout_expires")]
        public string LockoutExpires { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("notification_daily_send_time")]
        public int NotificationDailySendTime { get; set; }

        [JsonProperty("office_integration_enabled")]
        public bool OfficeIntegrationEnabled { get; set; }

        [JsonProperty("partner_admin")]
        public bool PartnerAdmin { get; set; }

        [JsonProperty("partner_id")]
        public int PartnerId { get; set; }

        [JsonProperty("partner_name")]
        public string PartnerName { get; set; }

        [JsonProperty("password_set_at")]
        public string PasswordSetAt { get; set; }

        [JsonProperty("password_validity_days")]
        public int PasswordValidityDays { get; set; }

        [JsonProperty("public_keys_count")]
        public int PublicKeysCount { get; set; }

        [JsonProperty("receive_admin_alerts")]
        public bool ReceiveAdminAlerts { get; set; }

        [JsonProperty("require_2fa")]
        public string Require2fa { get; set; }

        [JsonProperty("require_login_by")]
        public string RequireLoginBy { get; set; }

        [JsonProperty("active_2fa")]
        public bool Active2fa { get; set; }

        [JsonProperty("require_password_change")]
        public bool RequirePasswordChange { get; set; }

        [JsonProperty("password_expired")]
        public bool PasswordExpired { get; set; }

        [JsonProperty("readonly_site_admin")]
        public bool ReadonlySiteAdmin { get; set; }

        [JsonProperty("restapi_permission")]
        public bool RestapiPermission { get; set; }

        [JsonProperty("self_managed")]
        public bool SelfManaged { get; set; }

        [JsonProperty("sftp_permission")]
        public bool SftpPermission { get; set; }

        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }

        [JsonProperty("site_id")]
        public int SiteId { get; set; }

        [JsonProperty("skip_welcome_screen")]
        public bool SkipWelcomeScreen { get; set; }

        [JsonProperty("ssl_required")]
        public string SslRequired { get; set; }

        [JsonProperty("sso_strategy_id")]
        public int SsoStrategyId { get; set; }

        [JsonProperty("subscribe_to_newsletter")]
        public bool SubscribeToNewsletter { get; set; }

        [JsonProperty("externally_managed")]
        public bool ExternallyManaged { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }

        [JsonProperty("type_of_2fa")]
        public string TypeOf2fa { get; set; }

        [JsonProperty("type_of_2fa_for_display")]
        public string TypeOf2faForDisplay { get; set; }

        [JsonProperty("user_root")]
        public string UserRoot { get; set; }

        [JsonProperty("user_home")]
        public string UserHome { get; set; }

        [JsonProperty("days_remaining_until_password_expire")]
        public int DaysRemainingUntilPasswordExpire { get; set; }

        [JsonProperty("password_expire_at")]
        public string PasswordExpireAt { get; set; }
    }

    public class GetUsersResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("admin_group_ids")]
        public int[] AdminGroupIds { get; set; }

        [JsonProperty("allowed_ips")]
        public string AllowedIps { get; set; }

        [JsonProperty("attachments_permission")]
        public bool AttachmentsPermission { get; set; }

        [JsonProperty("api_keys_count")]
        public int ApiKeysCount { get; set; }

        [JsonProperty("authenticate_until")]
        public string AuthenticateUntil { get; set; }

        [JsonProperty("authentication_method")]
        public string AuthenticationMethod { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("billable")]
        public bool Billable { get; set; }

        [JsonProperty("billing_permission")]
        public bool BillingPermission { get; set; }

        [JsonProperty("bypass_site_allowed_ips")]
        public bool BypassSiteAllowedIps { get; set; }

        [JsonProperty("bypass_user_lifecycle_rules")]
        public bool BypassUserLifecycleRules { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("dav_permission")]
        public bool DavPermission { get; set; }

        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("disabled_expired_or_inactive")]
        public bool DisabledExpiredOrInactive { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("filesystem_layout")]
        public string FilesystemLayout { get; set; }

        [JsonProperty("first_login_at")]
        public string FirstLoginAt { get; set; }

        [JsonProperty("ftp_permission")]
        public bool FtpPermission { get; set; }

        [JsonProperty("group_ids")]
        public string GroupIds { get; set; }

        [JsonProperty("header_text")]
        public string HeaderText { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("last_login_at")]
        public string LastLoginAt { get; set; }

        [JsonProperty("last_web_login_at")]
        public string LastWebLoginAt { get; set; }

        [JsonProperty("last_ftp_login_at")]
        public string LastFtpLoginAt { get; set; }

        [JsonProperty("last_sftp_login_at")]
        public string LastSftpLoginAt { get; set; }

        [JsonProperty("last_dav_login_at")]
        public string LastDavLoginAt { get; set; }

        [JsonProperty("last_desktop_login_at")]
        public string LastDesktopLoginAt { get; set; }

        [JsonProperty("last_restapi_login_at")]
        public string LastRestapiLoginAt { get; set; }

        [JsonProperty("last_api_use_at")]
        public string LastApiUseAt { get; set; }

        [JsonProperty("last_active_at")]
        public string LastActiveAt { get; set; }

        [JsonProperty("last_protocol_cipher")]
        public string LastProtocolCipher { get; set; }

        [JsonProperty("lockout_expires")]
        public string LockoutExpires { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("notification_daily_send_time")]
        public int NotificationDailySendTime { get; set; }

        [JsonProperty("office_integration_enabled")]
        public bool OfficeIntegrationEnabled { get; set; }

        [JsonProperty("partner_admin")]
        public bool PartnerAdmin { get; set; }

        [JsonProperty("partner_id")]
        public int PartnerId { get; set; }

        [JsonProperty("partner_name")]
        public string PartnerName { get; set; }

        [JsonProperty("password_set_at")]
        public string PasswordSetAt { get; set; }

        [JsonProperty("password_validity_days")]
        public int PasswordValidityDays { get; set; }

        [JsonProperty("public_keys_count")]
        public int PublicKeysCount { get; set; }

        [JsonProperty("receive_admin_alerts")]
        public bool ReceiveAdminAlerts { get; set; }

        [JsonProperty("require_2fa")]
        public string Require2fa { get; set; }

        [JsonProperty("require_login_by")]
        public string RequireLoginBy { get; set; }

        [JsonProperty("active_2fa")]
        public bool Active2fa { get; set; }

        [JsonProperty("require_password_change")]
        public bool RequirePasswordChange { get; set; }

        [JsonProperty("password_expired")]
        public bool PasswordExpired { get; set; }

        [JsonProperty("readonly_site_admin")]
        public bool ReadonlySiteAdmin { get; set; }

        [JsonProperty("restapi_permission")]
        public bool RestapiPermission { get; set; }

        [JsonProperty("self_managed")]
        public bool SelfManaged { get; set; }

        [JsonProperty("sftp_permission")]
        public bool SftpPermission { get; set; }

        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }

        [JsonProperty("site_id")]
        public int SiteId { get; set; }

        [JsonProperty("skip_welcome_screen")]
        public bool SkipWelcomeScreen { get; set; }

        [JsonProperty("ssl_required")]
        public string SslRequired { get; set; }

        [JsonProperty("sso_strategy_id")]
        public int SsoStrategyId { get; set; }

        [JsonProperty("subscribe_to_newsletter")]
        public bool SubscribeToNewsletter { get; set; }

        [JsonProperty("externally_managed")]
        public bool ExternallyManaged { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }

        [JsonProperty("type_of_2fa")]
        public string TypeOf2fa { get; set; }

        [JsonProperty("type_of_2fa_for_display")]
        public string TypeOf2faForDisplay { get; set; }

        [JsonProperty("user_root")]
        public string UserRoot { get; set; }

        [JsonProperty("user_home")]
        public string UserHome { get; set; }

        [JsonProperty("days_remaining_until_password_expire")]
        public int DaysRemainingUntilPasswordExpire { get; set; }

        [JsonProperty("password_expire_at")]
        public string PasswordExpireAt { get; set; }
    }

    public class PostUsersResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("admin_group_ids")]
        public int[] AdminGroupIds { get; set; }

        [JsonProperty("allowed_ips")]
        public string AllowedIps { get; set; }

        [JsonProperty("attachments_permission")]
        public bool AttachmentsPermission { get; set; }

        [JsonProperty("api_keys_count")]
        public int ApiKeysCount { get; set; }

        [JsonProperty("authenticate_until")]
        public string AuthenticateUntil { get; set; }

        [JsonProperty("authentication_method")]
        public string AuthenticationMethod { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("billable")]
        public bool Billable { get; set; }

        [JsonProperty("billing_permission")]
        public bool BillingPermission { get; set; }

        [JsonProperty("bypass_site_allowed_ips")]
        public bool BypassSiteAllowedIps { get; set; }

        [JsonProperty("bypass_user_lifecycle_rules")]
        public bool BypassUserLifecycleRules { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("dav_permission")]
        public bool DavPermission { get; set; }

        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("disabled_expired_or_inactive")]
        public bool DisabledExpiredOrInactive { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("filesystem_layout")]
        public string FilesystemLayout { get; set; }

        [JsonProperty("first_login_at")]
        public string FirstLoginAt { get; set; }

        [JsonProperty("ftp_permission")]
        public bool FtpPermission { get; set; }

        [JsonProperty("group_ids")]
        public string GroupIds { get; set; }

        [JsonProperty("header_text")]
        public string HeaderText { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("last_login_at")]
        public string LastLoginAt { get; set; }

        [JsonProperty("last_web_login_at")]
        public string LastWebLoginAt { get; set; }

        [JsonProperty("last_ftp_login_at")]
        public string LastFtpLoginAt { get; set; }

        [JsonProperty("last_sftp_login_at")]
        public string LastSftpLoginAt { get; set; }

        [JsonProperty("last_dav_login_at")]
        public string LastDavLoginAt { get; set; }

        [JsonProperty("last_desktop_login_at")]
        public string LastDesktopLoginAt { get; set; }

        [JsonProperty("last_restapi_login_at")]
        public string LastRestapiLoginAt { get; set; }

        [JsonProperty("last_api_use_at")]
        public string LastApiUseAt { get; set; }

        [JsonProperty("last_active_at")]
        public string LastActiveAt { get; set; }

        [JsonProperty("last_protocol_cipher")]
        public string LastProtocolCipher { get; set; }

        [JsonProperty("lockout_expires")]
        public string LockoutExpires { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("notification_daily_send_time")]
        public int NotificationDailySendTime { get; set; }

        [JsonProperty("office_integration_enabled")]
        public bool OfficeIntegrationEnabled { get; set; }

        [JsonProperty("partner_admin")]
        public bool PartnerAdmin { get; set; }

        [JsonProperty("partner_id")]
        public int PartnerId { get; set; }

        [JsonProperty("partner_name")]
        public string PartnerName { get; set; }

        [JsonProperty("password_set_at")]
        public string PasswordSetAt { get; set; }

        [JsonProperty("password_validity_days")]
        public int PasswordValidityDays { get; set; }

        [JsonProperty("public_keys_count")]
        public int PublicKeysCount { get; set; }

        [JsonProperty("receive_admin_alerts")]
        public bool ReceiveAdminAlerts { get; set; }

        [JsonProperty("require_2fa")]
        public string Require2fa { get; set; }

        [JsonProperty("require_login_by")]
        public string RequireLoginBy { get; set; }

        [JsonProperty("active_2fa")]
        public bool Active2fa { get; set; }

        [JsonProperty("require_password_change")]
        public bool RequirePasswordChange { get; set; }

        [JsonProperty("password_expired")]
        public bool PasswordExpired { get; set; }

        [JsonProperty("readonly_site_admin")]
        public bool ReadonlySiteAdmin { get; set; }

        [JsonProperty("restapi_permission")]
        public bool RestapiPermission { get; set; }

        [JsonProperty("self_managed")]
        public bool SelfManaged { get; set; }

        [JsonProperty("sftp_permission")]
        public bool SftpPermission { get; set; }

        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }

        [JsonProperty("site_id")]
        public int SiteId { get; set; }

        [JsonProperty("skip_welcome_screen")]
        public bool SkipWelcomeScreen { get; set; }

        [JsonProperty("ssl_required")]
        public string SslRequired { get; set; }

        [JsonProperty("sso_strategy_id")]
        public int SsoStrategyId { get; set; }

        [JsonProperty("subscribe_to_newsletter")]
        public bool SubscribeToNewsletter { get; set; }

        [JsonProperty("externally_managed")]
        public bool ExternallyManaged { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }

        [JsonProperty("type_of_2fa")]
        public string TypeOf2fa { get; set; }

        [JsonProperty("type_of_2fa_for_display")]
        public string TypeOf2faForDisplay { get; set; }

        [JsonProperty("user_root")]
        public string UserRoot { get; set; }

        [JsonProperty("user_home")]
        public string UserHome { get; set; }

        [JsonProperty("days_remaining_until_password_expire")]
        public int DaysRemainingUntilPasswordExpire { get; set; }

        [JsonProperty("password_expire_at")]
        public string PasswordExpireAt { get; set; }
    }

    public class GetBundleDownloadsResponseItem
    {
        [JsonProperty("bundle_registration")]
        public GetBundleDownloadsResponseItemBundleRegistrationType BundleRegistration { get; set; }

        [JsonProperty("download_method")]
        public string DownloadMethod { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class GetBundleDownloadsResponseItemBundleRegistrationType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("inbox_code")]
        public string InboxCode { get; set; }

        [JsonProperty("clickwrap_body")]
        public string ClickwrapBody { get; set; }

        [JsonProperty("form_field_set_id")]
        public int FormFieldSetId { get; set; }

        [JsonProperty("form_field_data")]
        public JToken FormFieldData { get; set; }

        [JsonProperty("bundle_code")]
        public string BundleCode { get; set; }

        [JsonProperty("bundle_id")]
        public int BundleId { get; set; }

        [JsonProperty("bundle_recipient_id")]
        public int BundleRecipientId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class GetBundleNotificationsIdResponse
    {
        [JsonProperty("bundle_id")]
        public int BundleId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("notify_on_registration")]
        public bool NotifyOnRegistration { get; set; }

        [JsonProperty("notify_on_upload")]
        public bool NotifyOnUpload { get; set; }

        [JsonProperty("notify_user_id")]
        public int NotifyUserId { get; set; }
    }

    public class PatchBundleNotificationsIdResponse
    {
        [JsonProperty("bundle_id")]
        public int BundleId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("notify_on_registration")]
        public bool NotifyOnRegistration { get; set; }

        [JsonProperty("notify_on_upload")]
        public bool NotifyOnUpload { get; set; }

        [JsonProperty("notify_user_id")]
        public int NotifyUserId { get; set; }
    }

    public class GetBundleNotificationsResponseItem
    {
        [JsonProperty("bundle_id")]
        public int BundleId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("notify_on_registration")]
        public bool NotifyOnRegistration { get; set; }

        [JsonProperty("notify_on_upload")]
        public bool NotifyOnUpload { get; set; }

        [JsonProperty("notify_user_id")]
        public int NotifyUserId { get; set; }
    }

    public class PostBundleNotificationsResponse
    {
        [JsonProperty("bundle_id")]
        public int BundleId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("notify_on_registration")]
        public bool NotifyOnRegistration { get; set; }

        [JsonProperty("notify_on_upload")]
        public bool NotifyOnUpload { get; set; }

        [JsonProperty("notify_user_id")]
        public int NotifyUserId { get; set; }
    }

    public class GetBundleRecipientsResponseItem
    {
        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("sent_at")]
        public string SentAt { get; set; }
    }

    public class PostBundleRecipientsResponse
    {
        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("sent_at")]
        public string SentAt { get; set; }
    }

    public class GetBundleRegistrationsResponseItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("inbox_code")]
        public string InboxCode { get; set; }

        [JsonProperty("clickwrap_body")]
        public string ClickwrapBody { get; set; }

        [JsonProperty("form_field_set_id")]
        public int FormFieldSetId { get; set; }

        [JsonProperty("form_field_data")]
        public JToken FormFieldData { get; set; }

        [JsonProperty("bundle_code")]
        public string BundleCode { get; set; }

        [JsonProperty("bundle_id")]
        public int BundleId { get; set; }

        [JsonProperty("bundle_recipient_id")]
        public int BundleRecipientId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class GetBundlesIdResponse
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("color_left")]
        public string ColorLeft { get; set; }

        [JsonProperty("color_link")]
        public string ColorLink { get; set; }

        [JsonProperty("color_text")]
        public string ColorText { get; set; }

        [JsonProperty("color_top")]
        public string ColorTop { get; set; }

        [JsonProperty("color_top_text")]
        public string ColorTopText { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("expires_at")]
        public string ExpiresAt { get; set; }

        [JsonProperty("password_protected")]
        public bool PasswordProtected { get; set; }

        [JsonProperty("permissions")]
        public string Permissions { get; set; }

        [JsonProperty("preview_only")]
        public bool PreviewOnly { get; set; }

        [JsonProperty("require_registration")]
        public bool RequireRegistration { get; set; }

        [JsonProperty("require_share_recipient")]
        public bool RequireShareRecipient { get; set; }

        [JsonProperty("require_logout")]
        public bool RequireLogout { get; set; }

        [JsonProperty("clickwrap_body")]
        public string ClickwrapBody { get; set; }

        [JsonProperty("form_field_set")]
        public GetBundlesIdResponseFormFieldSetType FormFieldSet { get; set; }

        [JsonProperty("skip_name")]
        public bool SkipName { get; set; }

        [JsonProperty("skip_email")]
        public bool SkipEmail { get; set; }

        [JsonProperty("start_access_on_date")]
        public string StartAccessOnDate { get; set; }

        [JsonProperty("skip_company")]
        public bool SkipCompany { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("dont_separate_submissions_by_folder")]
        public bool DontSeparateSubmissionsByFolder { get; set; }

        [JsonProperty("max_uses")]
        public int MaxUses { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("path_template")]
        public string PathTemplate { get; set; }

        [JsonProperty("path_template_time_zone")]
        public string PathTemplateTimeZone { get; set; }

        [JsonProperty("send_email_receipt_to_uploader")]
        public bool SendEmailReceiptToUploader { get; set; }

        [JsonProperty("snapshot_id")]
        public int SnapshotId { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("clickwrap_id")]
        public int ClickwrapId { get; set; }

        [JsonProperty("inbox_id")]
        public int InboxId { get; set; }

        [JsonProperty("watermark_attachment")]
        public GetBundlesIdResponseWatermarkAttachmentType WatermarkAttachment { get; set; }

        [JsonProperty("watermark_value")]
        public JToken WatermarkValue { get; set; }

        [JsonProperty("has_inbox")]
        public bool HasInbox { get; set; }

        [JsonProperty("dont_allow_folders_in_uploads")]
        public bool DontAllowFoldersInUploads { get; set; }

        [JsonProperty("paths")]
        public string[] Paths { get; set; }

        [JsonProperty("bundlepaths")]
        public JToken[] Bundlepaths { get; set; }
    }

    public class GetBundlesIdResponseFormFieldSetType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("form_layout")]
        public int[] FormLayout { get; set; }

        [JsonProperty("form_fields")]
        public JToken[] FormFields { get; set; }

        [JsonProperty("skip_name")]
        public bool SkipName { get; set; }

        [JsonProperty("skip_email")]
        public bool SkipEmail { get; set; }

        [JsonProperty("skip_company")]
        public bool SkipCompany { get; set; }

        [JsonProperty("in_use")]
        public bool InUse { get; set; }
    }

    public class GetBundlesIdResponseWatermarkAttachmentType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class PatchBundlesIdResponse
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("color_left")]
        public string ColorLeft { get; set; }

        [JsonProperty("color_link")]
        public string ColorLink { get; set; }

        [JsonProperty("color_text")]
        public string ColorText { get; set; }

        [JsonProperty("color_top")]
        public string ColorTop { get; set; }

        [JsonProperty("color_top_text")]
        public string ColorTopText { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("expires_at")]
        public string ExpiresAt { get; set; }

        [JsonProperty("password_protected")]
        public bool PasswordProtected { get; set; }

        [JsonProperty("permissions")]
        public string Permissions { get; set; }

        [JsonProperty("preview_only")]
        public bool PreviewOnly { get; set; }

        [JsonProperty("require_registration")]
        public bool RequireRegistration { get; set; }

        [JsonProperty("require_share_recipient")]
        public bool RequireShareRecipient { get; set; }

        [JsonProperty("require_logout")]
        public bool RequireLogout { get; set; }

        [JsonProperty("clickwrap_body")]
        public string ClickwrapBody { get; set; }

        [JsonProperty("form_field_set")]
        public PatchBundlesIdResponseFormFieldSetType FormFieldSet { get; set; }

        [JsonProperty("skip_name")]
        public bool SkipName { get; set; }

        [JsonProperty("skip_email")]
        public bool SkipEmail { get; set; }

        [JsonProperty("start_access_on_date")]
        public string StartAccessOnDate { get; set; }

        [JsonProperty("skip_company")]
        public bool SkipCompany { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("dont_separate_submissions_by_folder")]
        public bool DontSeparateSubmissionsByFolder { get; set; }

        [JsonProperty("max_uses")]
        public int MaxUses { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("path_template")]
        public string PathTemplate { get; set; }

        [JsonProperty("path_template_time_zone")]
        public string PathTemplateTimeZone { get; set; }

        [JsonProperty("send_email_receipt_to_uploader")]
        public bool SendEmailReceiptToUploader { get; set; }

        [JsonProperty("snapshot_id")]
        public int SnapshotId { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("clickwrap_id")]
        public int ClickwrapId { get; set; }

        [JsonProperty("inbox_id")]
        public int InboxId { get; set; }

        [JsonProperty("watermark_attachment")]
        public PatchBundlesIdResponseWatermarkAttachmentType WatermarkAttachment { get; set; }

        [JsonProperty("watermark_value")]
        public JToken WatermarkValue { get; set; }

        [JsonProperty("has_inbox")]
        public bool HasInbox { get; set; }

        [JsonProperty("dont_allow_folders_in_uploads")]
        public bool DontAllowFoldersInUploads { get; set; }

        [JsonProperty("paths")]
        public string[] Paths { get; set; }

        [JsonProperty("bundlepaths")]
        public JToken[] Bundlepaths { get; set; }
    }

    public class PatchBundlesIdResponseFormFieldSetType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("form_layout")]
        public int[] FormLayout { get; set; }

        [JsonProperty("form_fields")]
        public JToken[] FormFields { get; set; }

        [JsonProperty("skip_name")]
        public bool SkipName { get; set; }

        [JsonProperty("skip_email")]
        public bool SkipEmail { get; set; }

        [JsonProperty("skip_company")]
        public bool SkipCompany { get; set; }

        [JsonProperty("in_use")]
        public bool InUse { get; set; }
    }

    public class PatchBundlesIdResponseWatermarkAttachmentType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class GetBundlesResponseItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("color_left")]
        public string ColorLeft { get; set; }

        [JsonProperty("color_link")]
        public string ColorLink { get; set; }

        [JsonProperty("color_text")]
        public string ColorText { get; set; }

        [JsonProperty("color_top")]
        public string ColorTop { get; set; }

        [JsonProperty("color_top_text")]
        public string ColorTopText { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("expires_at")]
        public string ExpiresAt { get; set; }

        [JsonProperty("password_protected")]
        public bool PasswordProtected { get; set; }

        [JsonProperty("permissions")]
        public string Permissions { get; set; }

        [JsonProperty("preview_only")]
        public bool PreviewOnly { get; set; }

        [JsonProperty("require_registration")]
        public bool RequireRegistration { get; set; }

        [JsonProperty("require_share_recipient")]
        public bool RequireShareRecipient { get; set; }

        [JsonProperty("require_logout")]
        public bool RequireLogout { get; set; }

        [JsonProperty("clickwrap_body")]
        public string ClickwrapBody { get; set; }

        [JsonProperty("form_field_set")]
        public GetBundlesResponseItemFormFieldSetType FormFieldSet { get; set; }

        [JsonProperty("skip_name")]
        public bool SkipName { get; set; }

        [JsonProperty("skip_email")]
        public bool SkipEmail { get; set; }

        [JsonProperty("start_access_on_date")]
        public string StartAccessOnDate { get; set; }

        [JsonProperty("skip_company")]
        public bool SkipCompany { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("dont_separate_submissions_by_folder")]
        public bool DontSeparateSubmissionsByFolder { get; set; }

        [JsonProperty("max_uses")]
        public int MaxUses { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("path_template")]
        public string PathTemplate { get; set; }

        [JsonProperty("path_template_time_zone")]
        public string PathTemplateTimeZone { get; set; }

        [JsonProperty("send_email_receipt_to_uploader")]
        public bool SendEmailReceiptToUploader { get; set; }

        [JsonProperty("snapshot_id")]
        public int SnapshotId { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("clickwrap_id")]
        public int ClickwrapId { get; set; }

        [JsonProperty("inbox_id")]
        public int InboxId { get; set; }

        [JsonProperty("watermark_attachment")]
        public GetBundlesResponseItemWatermarkAttachmentType WatermarkAttachment { get; set; }

        [JsonProperty("watermark_value")]
        public JToken WatermarkValue { get; set; }

        [JsonProperty("has_inbox")]
        public bool HasInbox { get; set; }

        [JsonProperty("dont_allow_folders_in_uploads")]
        public bool DontAllowFoldersInUploads { get; set; }

        [JsonProperty("paths")]
        public string[] Paths { get; set; }

        [JsonProperty("bundlepaths")]
        public JToken[] Bundlepaths { get; set; }
    }

    public class GetBundlesResponseItemFormFieldSetType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("form_layout")]
        public int[] FormLayout { get; set; }

        [JsonProperty("form_fields")]
        public JToken[] FormFields { get; set; }

        [JsonProperty("skip_name")]
        public bool SkipName { get; set; }

        [JsonProperty("skip_email")]
        public bool SkipEmail { get; set; }

        [JsonProperty("skip_company")]
        public bool SkipCompany { get; set; }

        [JsonProperty("in_use")]
        public bool InUse { get; set; }
    }

    public class GetBundlesResponseItemWatermarkAttachmentType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class PostBundlesResponse
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("color_left")]
        public string ColorLeft { get; set; }

        [JsonProperty("color_link")]
        public string ColorLink { get; set; }

        [JsonProperty("color_text")]
        public string ColorText { get; set; }

        [JsonProperty("color_top")]
        public string ColorTop { get; set; }

        [JsonProperty("color_top_text")]
        public string ColorTopText { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("expires_at")]
        public string ExpiresAt { get; set; }

        [JsonProperty("password_protected")]
        public bool PasswordProtected { get; set; }

        [JsonProperty("permissions")]
        public string Permissions { get; set; }

        [JsonProperty("preview_only")]
        public bool PreviewOnly { get; set; }

        [JsonProperty("require_registration")]
        public bool RequireRegistration { get; set; }

        [JsonProperty("require_share_recipient")]
        public bool RequireShareRecipient { get; set; }

        [JsonProperty("require_logout")]
        public bool RequireLogout { get; set; }

        [JsonProperty("clickwrap_body")]
        public string ClickwrapBody { get; set; }

        [JsonProperty("form_field_set")]
        public PostBundlesResponseFormFieldSetType FormFieldSet { get; set; }

        [JsonProperty("skip_name")]
        public bool SkipName { get; set; }

        [JsonProperty("skip_email")]
        public bool SkipEmail { get; set; }

        [JsonProperty("start_access_on_date")]
        public string StartAccessOnDate { get; set; }

        [JsonProperty("skip_company")]
        public bool SkipCompany { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("dont_separate_submissions_by_folder")]
        public bool DontSeparateSubmissionsByFolder { get; set; }

        [JsonProperty("max_uses")]
        public int MaxUses { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("path_template")]
        public string PathTemplate { get; set; }

        [JsonProperty("path_template_time_zone")]
        public string PathTemplateTimeZone { get; set; }

        [JsonProperty("send_email_receipt_to_uploader")]
        public bool SendEmailReceiptToUploader { get; set; }

        [JsonProperty("snapshot_id")]
        public int SnapshotId { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("clickwrap_id")]
        public int ClickwrapId { get; set; }

        [JsonProperty("inbox_id")]
        public int InboxId { get; set; }

        [JsonProperty("watermark_attachment")]
        public PostBundlesResponseWatermarkAttachmentType WatermarkAttachment { get; set; }

        [JsonProperty("watermark_value")]
        public JToken WatermarkValue { get; set; }

        [JsonProperty("has_inbox")]
        public bool HasInbox { get; set; }

        [JsonProperty("dont_allow_folders_in_uploads")]
        public bool DontAllowFoldersInUploads { get; set; }

        [JsonProperty("paths")]
        public string[] Paths { get; set; }

        [JsonProperty("bundlepaths")]
        public JToken[] Bundlepaths { get; set; }
    }

    public class PostBundlesResponseFormFieldSetType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("form_layout")]
        public int[] FormLayout { get; set; }

        [JsonProperty("form_fields")]
        public JToken[] FormFields { get; set; }

        [JsonProperty("skip_name")]
        public bool SkipName { get; set; }

        [JsonProperty("skip_email")]
        public bool SkipEmail { get; set; }

        [JsonProperty("skip_company")]
        public bool SkipCompany { get; set; }

        [JsonProperty("in_use")]
        public bool InUse { get; set; }
    }

    public class PostBundlesResponseWatermarkAttachmentType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class FileActionFindResponse
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("created_by_id")]
        public int CreatedById { get; set; }

        [JsonProperty("created_by_api_key_id")]
        public int CreatedByApiKeyId { get; set; }

        [JsonProperty("created_by_as2_incoming_message_id")]
        public int CreatedByAs2IncomingMessageId { get; set; }

        [JsonProperty("created_by_automation_id")]
        public int CreatedByAutomationId { get; set; }

        [JsonProperty("created_by_bundle_registration_id")]
        public int CreatedByBundleRegistrationId { get; set; }

        [JsonProperty("created_by_inbox_id")]
        public int CreatedByInboxId { get; set; }

        [JsonProperty("created_by_remote_server_id")]
        public int CreatedByRemoteServerId { get; set; }

        [JsonProperty("created_by_remote_server_sync_id")]
        public int CreatedByRemoteServerSyncId { get; set; }

        [JsonProperty("custom_metadata")]
        public JToken CustomMetadata { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("last_modified_by_id")]
        public int LastModifiedById { get; set; }

        [JsonProperty("last_modified_by_api_key_id")]
        public int LastModifiedByApiKeyId { get; set; }

        [JsonProperty("last_modified_by_automation_id")]
        public int LastModifiedByAutomationId { get; set; }

        [JsonProperty("last_modified_by_bundle_registration_id")]
        public int LastModifiedByBundleRegistrationId { get; set; }

        [JsonProperty("last_modified_by_remote_server_id")]
        public int LastModifiedByRemoteServerId { get; set; }

        [JsonProperty("last_modified_by_remote_server_sync_id")]
        public int LastModifiedByRemoteServerSyncId { get; set; }

        [JsonProperty("mtime")]
        public string Mtime { get; set; }

        [JsonProperty("provided_mtime")]
        public string ProvidedMtime { get; set; }

        [JsonProperty("crc32")]
        public string Crc32 { get; set; }

        [JsonProperty("md5")]
        public string Md5 { get; set; }

        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        [JsonProperty("sha256")]
        public string Sha256 { get; set; }

        [JsonProperty("mime_type")]
        public string MimeType { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("permissions")]
        public string Permissions { get; set; }

        [JsonProperty("subfolders_locked?")]
        public bool SubfoldersLocked { get; set; }

        [JsonProperty("is_locked")]
        public bool IsLocked { get; set; }

        [JsonProperty("download_uri")]
        public string DownloadUri { get; set; }

        [JsonProperty("priority_color")]
        public string PriorityColor { get; set; }

        [JsonProperty("preview_id")]
        public int PreviewId { get; set; }

        [JsonProperty("preview")]
        public FileActionFindResponsePreviewType Preview { get; set; }
    }

    public class FileActionFindResponsePreviewType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("download_uri")]
        public string DownloadUri { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }
    }

    public class FileActionCopyResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("file_migration_id")]
        public int FileMigrationId { get; set; }
    }

    public class FileActionMoveResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("file_migration_id")]
        public int FileMigrationId { get; set; }
    }

    public class FolderListForPathResponseItem
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("created_by_id")]
        public int CreatedById { get; set; }

        [JsonProperty("created_by_api_key_id")]
        public int CreatedByApiKeyId { get; set; }

        [JsonProperty("created_by_as2_incoming_message_id")]
        public int CreatedByAs2IncomingMessageId { get; set; }

        [JsonProperty("created_by_automation_id")]
        public int CreatedByAutomationId { get; set; }

        [JsonProperty("created_by_bundle_registration_id")]
        public int CreatedByBundleRegistrationId { get; set; }

        [JsonProperty("created_by_inbox_id")]
        public int CreatedByInboxId { get; set; }

        [JsonProperty("created_by_remote_server_id")]
        public int CreatedByRemoteServerId { get; set; }

        [JsonProperty("created_by_remote_server_sync_id")]
        public int CreatedByRemoteServerSyncId { get; set; }

        [JsonProperty("custom_metadata")]
        public JToken CustomMetadata { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("last_modified_by_id")]
        public int LastModifiedById { get; set; }

        [JsonProperty("last_modified_by_api_key_id")]
        public int LastModifiedByApiKeyId { get; set; }

        [JsonProperty("last_modified_by_automation_id")]
        public int LastModifiedByAutomationId { get; set; }

        [JsonProperty("last_modified_by_bundle_registration_id")]
        public int LastModifiedByBundleRegistrationId { get; set; }

        [JsonProperty("last_modified_by_remote_server_id")]
        public int LastModifiedByRemoteServerId { get; set; }

        [JsonProperty("last_modified_by_remote_server_sync_id")]
        public int LastModifiedByRemoteServerSyncId { get; set; }

        [JsonProperty("mtime")]
        public string Mtime { get; set; }

        [JsonProperty("provided_mtime")]
        public string ProvidedMtime { get; set; }

        [JsonProperty("crc32")]
        public string Crc32 { get; set; }

        [JsonProperty("md5")]
        public string Md5 { get; set; }

        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        [JsonProperty("sha256")]
        public string Sha256 { get; set; }

        [JsonProperty("mime_type")]
        public string MimeType { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("permissions")]
        public string Permissions { get; set; }

        [JsonProperty("subfolders_locked?")]
        public bool SubfoldersLocked { get; set; }

        [JsonProperty("is_locked")]
        public bool IsLocked { get; set; }

        [JsonProperty("download_uri")]
        public string DownloadUri { get; set; }

        [JsonProperty("priority_color")]
        public string PriorityColor { get; set; }

        [JsonProperty("preview_id")]
        public int PreviewId { get; set; }

        [JsonProperty("preview")]
        public FolderListForPathResponseItemPreviewType Preview { get; set; }
    }

    public class FolderListForPathResponseItemPreviewType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("download_uri")]
        public string DownloadUri { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }
    }

    public class PostFoldersPathResponse
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("created_by_id")]
        public int CreatedById { get; set; }

        [JsonProperty("created_by_api_key_id")]
        public int CreatedByApiKeyId { get; set; }

        [JsonProperty("created_by_as2_incoming_message_id")]
        public int CreatedByAs2IncomingMessageId { get; set; }

        [JsonProperty("created_by_automation_id")]
        public int CreatedByAutomationId { get; set; }

        [JsonProperty("created_by_bundle_registration_id")]
        public int CreatedByBundleRegistrationId { get; set; }

        [JsonProperty("created_by_inbox_id")]
        public int CreatedByInboxId { get; set; }

        [JsonProperty("created_by_remote_server_id")]
        public int CreatedByRemoteServerId { get; set; }

        [JsonProperty("created_by_remote_server_sync_id")]
        public int CreatedByRemoteServerSyncId { get; set; }

        [JsonProperty("custom_metadata")]
        public JToken CustomMetadata { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("last_modified_by_id")]
        public int LastModifiedById { get; set; }

        [JsonProperty("last_modified_by_api_key_id")]
        public int LastModifiedByApiKeyId { get; set; }

        [JsonProperty("last_modified_by_automation_id")]
        public int LastModifiedByAutomationId { get; set; }

        [JsonProperty("last_modified_by_bundle_registration_id")]
        public int LastModifiedByBundleRegistrationId { get; set; }

        [JsonProperty("last_modified_by_remote_server_id")]
        public int LastModifiedByRemoteServerId { get; set; }

        [JsonProperty("last_modified_by_remote_server_sync_id")]
        public int LastModifiedByRemoteServerSyncId { get; set; }

        [JsonProperty("mtime")]
        public string Mtime { get; set; }

        [JsonProperty("provided_mtime")]
        public string ProvidedMtime { get; set; }

        [JsonProperty("crc32")]
        public string Crc32 { get; set; }

        [JsonProperty("md5")]
        public string Md5 { get; set; }

        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        [JsonProperty("sha256")]
        public string Sha256 { get; set; }

        [JsonProperty("mime_type")]
        public string MimeType { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("permissions")]
        public string Permissions { get; set; }

        [JsonProperty("subfolders_locked?")]
        public bool SubfoldersLocked { get; set; }

        [JsonProperty("is_locked")]
        public bool IsLocked { get; set; }

        [JsonProperty("download_uri")]
        public string DownloadUri { get; set; }

        [JsonProperty("priority_color")]
        public string PriorityColor { get; set; }

        [JsonProperty("preview_id")]
        public int PreviewId { get; set; }

        [JsonProperty("preview")]
        public PostFoldersPathResponsePreviewType Preview { get; set; }
    }

    public class PostFoldersPathResponsePreviewType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("download_uri")]
        public string DownloadUri { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }
    }

    public class PostGroupsGroupIdUsersResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("admin_group_ids")]
        public int[] AdminGroupIds { get; set; }

        [JsonProperty("allowed_ips")]
        public string AllowedIps { get; set; }

        [JsonProperty("attachments_permission")]
        public bool AttachmentsPermission { get; set; }

        [JsonProperty("api_keys_count")]
        public int ApiKeysCount { get; set; }

        [JsonProperty("authenticate_until")]
        public string AuthenticateUntil { get; set; }

        [JsonProperty("authentication_method")]
        public string AuthenticationMethod { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("billable")]
        public bool Billable { get; set; }

        [JsonProperty("billing_permission")]
        public bool BillingPermission { get; set; }

        [JsonProperty("bypass_site_allowed_ips")]
        public bool BypassSiteAllowedIps { get; set; }

        [JsonProperty("bypass_user_lifecycle_rules")]
        public bool BypassUserLifecycleRules { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("dav_permission")]
        public bool DavPermission { get; set; }

        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("disabled_expired_or_inactive")]
        public bool DisabledExpiredOrInactive { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("filesystem_layout")]
        public string FilesystemLayout { get; set; }

        [JsonProperty("first_login_at")]
        public string FirstLoginAt { get; set; }

        [JsonProperty("ftp_permission")]
        public bool FtpPermission { get; set; }

        [JsonProperty("group_ids")]
        public string GroupIds { get; set; }

        [JsonProperty("header_text")]
        public string HeaderText { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("last_login_at")]
        public string LastLoginAt { get; set; }

        [JsonProperty("last_web_login_at")]
        public string LastWebLoginAt { get; set; }

        [JsonProperty("last_ftp_login_at")]
        public string LastFtpLoginAt { get; set; }

        [JsonProperty("last_sftp_login_at")]
        public string LastSftpLoginAt { get; set; }

        [JsonProperty("last_dav_login_at")]
        public string LastDavLoginAt { get; set; }

        [JsonProperty("last_desktop_login_at")]
        public string LastDesktopLoginAt { get; set; }

        [JsonProperty("last_restapi_login_at")]
        public string LastRestapiLoginAt { get; set; }

        [JsonProperty("last_api_use_at")]
        public string LastApiUseAt { get; set; }

        [JsonProperty("last_active_at")]
        public string LastActiveAt { get; set; }

        [JsonProperty("last_protocol_cipher")]
        public string LastProtocolCipher { get; set; }

        [JsonProperty("lockout_expires")]
        public string LockoutExpires { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("notification_daily_send_time")]
        public int NotificationDailySendTime { get; set; }

        [JsonProperty("office_integration_enabled")]
        public bool OfficeIntegrationEnabled { get; set; }

        [JsonProperty("partner_admin")]
        public bool PartnerAdmin { get; set; }

        [JsonProperty("partner_id")]
        public int PartnerId { get; set; }

        [JsonProperty("partner_name")]
        public string PartnerName { get; set; }

        [JsonProperty("password_set_at")]
        public string PasswordSetAt { get; set; }

        [JsonProperty("password_validity_days")]
        public int PasswordValidityDays { get; set; }

        [JsonProperty("public_keys_count")]
        public int PublicKeysCount { get; set; }

        [JsonProperty("receive_admin_alerts")]
        public bool ReceiveAdminAlerts { get; set; }

        [JsonProperty("require_2fa")]
        public string Require2fa { get; set; }

        [JsonProperty("require_login_by")]
        public string RequireLoginBy { get; set; }

        [JsonProperty("active_2fa")]
        public bool Active2fa { get; set; }

        [JsonProperty("require_password_change")]
        public bool RequirePasswordChange { get; set; }

        [JsonProperty("password_expired")]
        public bool PasswordExpired { get; set; }

        [JsonProperty("readonly_site_admin")]
        public bool ReadonlySiteAdmin { get; set; }

        [JsonProperty("restapi_permission")]
        public bool RestapiPermission { get; set; }

        [JsonProperty("self_managed")]
        public bool SelfManaged { get; set; }

        [JsonProperty("sftp_permission")]
        public bool SftpPermission { get; set; }

        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }

        [JsonProperty("site_id")]
        public int SiteId { get; set; }

        [JsonProperty("skip_welcome_screen")]
        public bool SkipWelcomeScreen { get; set; }

        [JsonProperty("ssl_required")]
        public string SslRequired { get; set; }

        [JsonProperty("sso_strategy_id")]
        public int SsoStrategyId { get; set; }

        [JsonProperty("subscribe_to_newsletter")]
        public bool SubscribeToNewsletter { get; set; }

        [JsonProperty("externally_managed")]
        public bool ExternallyManaged { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }

        [JsonProperty("type_of_2fa")]
        public string TypeOf2fa { get; set; }

        [JsonProperty("type_of_2fa_for_display")]
        public string TypeOf2faForDisplay { get; set; }

        [JsonProperty("user_root")]
        public string UserRoot { get; set; }

        [JsonProperty("user_home")]
        public string UserHome { get; set; }

        [JsonProperty("days_remaining_until_password_expire")]
        public int DaysRemainingUntilPasswordExpire { get; set; }

        [JsonProperty("password_expire_at")]
        public string PasswordExpireAt { get; set; }
    }

    public class GetGroupsIdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("allowed_ips")]
        public string AllowedIps { get; set; }

        [JsonProperty("admin_ids")]
        public string AdminIds { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("user_ids")]
        public string UserIds { get; set; }

        [JsonProperty("usernames")]
        public string Usernames { get; set; }

        [JsonProperty("ftp_permission")]
        public bool FtpPermission { get; set; }

        [JsonProperty("sftp_permission")]
        public bool SftpPermission { get; set; }

        [JsonProperty("dav_permission")]
        public bool DavPermission { get; set; }

        [JsonProperty("restapi_permission")]
        public bool RestapiPermission { get; set; }

        [JsonProperty("site_id")]
        public int SiteId { get; set; }
    }

    public class PatchGroupsIdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("allowed_ips")]
        public string AllowedIps { get; set; }

        [JsonProperty("admin_ids")]
        public string AdminIds { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("user_ids")]
        public string UserIds { get; set; }

        [JsonProperty("usernames")]
        public string Usernames { get; set; }

        [JsonProperty("ftp_permission")]
        public bool FtpPermission { get; set; }

        [JsonProperty("sftp_permission")]
        public bool SftpPermission { get; set; }

        [JsonProperty("dav_permission")]
        public bool DavPermission { get; set; }

        [JsonProperty("restapi_permission")]
        public bool RestapiPermission { get; set; }

        [JsonProperty("site_id")]
        public int SiteId { get; set; }
    }

    public class GetGroupsResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("allowed_ips")]
        public string AllowedIps { get; set; }

        [JsonProperty("admin_ids")]
        public string AdminIds { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("user_ids")]
        public string UserIds { get; set; }

        [JsonProperty("usernames")]
        public string Usernames { get; set; }

        [JsonProperty("ftp_permission")]
        public bool FtpPermission { get; set; }

        [JsonProperty("sftp_permission")]
        public bool SftpPermission { get; set; }

        [JsonProperty("dav_permission")]
        public bool DavPermission { get; set; }

        [JsonProperty("restapi_permission")]
        public bool RestapiPermission { get; set; }

        [JsonProperty("site_id")]
        public int SiteId { get; set; }
    }

    public class PostGroupsResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("allowed_ips")]
        public string AllowedIps { get; set; }

        [JsonProperty("admin_ids")]
        public string AdminIds { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("user_ids")]
        public string UserIds { get; set; }

        [JsonProperty("usernames")]
        public string Usernames { get; set; }

        [JsonProperty("ftp_permission")]
        public bool FtpPermission { get; set; }

        [JsonProperty("sftp_permission")]
        public bool SftpPermission { get; set; }

        [JsonProperty("dav_permission")]
        public bool DavPermission { get; set; }

        [JsonProperty("restapi_permission")]
        public bool RestapiPermission { get; set; }

        [JsonProperty("site_id")]
        public int SiteId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Filescom;

    public partial class WorkflowManagedActions
    {
        public FilescomActions Filescom(string connectionId) => new FilescomActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FilescomTriggers Filescom(string connectionId) => new FilescomTriggers(connectionId);
    }
}