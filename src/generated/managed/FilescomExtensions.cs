//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Filescom
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FilescomActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<GetUsersIdResponse, ApiConnectionActionConfiguration> GetUsersId(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetUsersIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUsersIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteUsersId(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<PatchUsersIdResponse, ApiConnectionActionConfiguration> PatchUsersId(Expression<Func<int>> id, Expression<Func<bodyauthenticationMethodInput>> bodyauthenticationMethod = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodygroupIds = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodypassword = null, Expression<Func<bool>> bodyrequirePasswordChange = null, Expression<Func<string>> bodyuserHome = null, Expression<Func<string>> bodyuserRoot = null, Expression<Func<string>> bodyusername = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyauthenticationMethod = WorkflowExpression.Compile(bodyauthenticationMethod, nameof(bodyauthenticationMethod), required: false);
            var __workflow_bodycompany = WorkflowExpression.Compile(bodycompany, nameof(bodycompany), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodygroupIds = WorkflowExpression.Compile(bodygroupIds, nameof(bodygroupIds), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodyrequirePasswordChange = WorkflowExpression.Compile(bodyrequirePasswordChange, nameof(bodyrequirePasswordChange), required: false);
            var __workflow_bodyuserHome = WorkflowExpression.Compile(bodyuserHome, nameof(bodyuserHome), required: false);
            var __workflow_bodyuserRoot = WorkflowExpression.Compile(bodyuserRoot, nameof(bodyuserRoot), required: false);
            var __workflow_bodyusername = WorkflowExpression.Compile(bodyusername, nameof(bodyusername), required: false);
            return new DeferredBodyAction<PatchUsersIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyauthenticationMethod != null)
                {
                    body["authentication_method"] = ExpressionConverter.ConvertO(__workflow_bodyauthenticationMethod);
                    bodypropCount++;
                }

                if (__workflow_bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(__workflow_bodycompany);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodygroupIds != null)
                {
                    body["group_ids"] = ExpressionConverter.ConvertO(__workflow_bodygroupIds);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodyrequirePasswordChange != null)
                {
                    body["require_password_change"] = ExpressionConverter.ConvertO(__workflow_bodyrequirePasswordChange);
                    bodypropCount++;
                }

                if (__workflow_bodyuserHome != null)
                {
                    body["user_home"] = ExpressionConverter.ConvertO(__workflow_bodyuserHome);
                    bodypropCount++;
                }

                if (__workflow_bodyuserRoot != null)
                {
                    body["user_root"] = ExpressionConverter.ConvertO(__workflow_bodyuserRoot);
                    bodypropCount++;
                }

                if (__workflow_bodyusername != null)
                {
                    body["username"] = ExpressionConverter.ConvertO(__workflow_bodyusername);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PatchUsersIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<GetUsersResponseItem[], ApiConnectionActionConfiguration> GetUsers()
        {
            return new DeferredBodyAction<GetUsersResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUsersResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<PostUsersResponse, ApiConnectionActionConfiguration> PostUsers(Expression<Func<string>> bodyusername, Expression<Func<bodyauthenticationMethodInput>> bodyauthenticationMethod = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodygroupIds = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodypassword = null, Expression<Func<bool>> bodyrequirePasswordChange = null, Expression<Func<string>> bodyuserHome = null, Expression<Func<string>> bodyuserRoot = null)
        {
            var __workflow_bodyusername = WorkflowExpression.Compile(bodyusername, nameof(bodyusername), required: true);
            var __workflow_bodyauthenticationMethod = WorkflowExpression.Compile(bodyauthenticationMethod, nameof(bodyauthenticationMethod), required: false);
            var __workflow_bodycompany = WorkflowExpression.Compile(bodycompany, nameof(bodycompany), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodygroupIds = WorkflowExpression.Compile(bodygroupIds, nameof(bodygroupIds), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodyrequirePasswordChange = WorkflowExpression.Compile(bodyrequirePasswordChange, nameof(bodyrequirePasswordChange), required: false);
            var __workflow_bodyuserHome = WorkflowExpression.Compile(bodyuserHome, nameof(bodyuserHome), required: false);
            var __workflow_bodyuserRoot = WorkflowExpression.Compile(bodyuserRoot, nameof(bodyuserRoot), required: false);
            return new DeferredBodyAction<PostUsersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyauthenticationMethod != null)
                {
                    body["authentication_method"] = ExpressionConverter.ConvertO(__workflow_bodyauthenticationMethod);
                    bodypropCount++;
                }

                if (__workflow_bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(__workflow_bodycompany);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodygroupIds != null)
                {
                    body["group_ids"] = ExpressionConverter.ConvertO(__workflow_bodygroupIds);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodyrequirePasswordChange != null)
                {
                    body["require_password_change"] = ExpressionConverter.ConvertO(__workflow_bodyrequirePasswordChange);
                    bodypropCount++;
                }

                if (__workflow_bodyuserHome != null)
                {
                    body["user_home"] = ExpressionConverter.ConvertO(__workflow_bodyuserHome);
                    bodypropCount++;
                }

                if (__workflow_bodyuserRoot != null)
                {
                    body["user_root"] = ExpressionConverter.ConvertO(__workflow_bodyuserRoot);
                    bodypropCount++;
                }

                bodypropCount++;
                body["username"] = ExpressionConverter.ConvertO(__workflow_bodyusername);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostUsersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<GetBundleDownloadsResponseItem[], ApiConnectionActionConfiguration> GetBundleDownloads(Expression<Func<int>> bundleId = null)
        {
            var __workflow_bundleId = WorkflowExpression.Compile(bundleId, nameof(bundleId), required: false);
            return new DeferredBodyAction<GetBundleDownloadsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/bundle_downloads";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_bundleId != null)
                    callPayload.Queries["bundle_id"] = ExpressionConverter.Convert(__workflow_bundleId);
                return new ApiConnectionAction<GetBundleDownloadsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<GetBundleNotificationsIdResponse, ApiConnectionActionConfiguration> GetBundleNotificationsId(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetBundleNotificationsIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/bundle_notifications/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetBundleNotificationsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteBundleNotificationsId(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/bundle_notifications/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<PatchBundleNotificationsIdResponse, ApiConnectionActionConfiguration> PatchBundleNotificationsId(Expression<Func<int>> id, Expression<Func<bool>> bodynotifyOnRegistration = null, Expression<Func<bool>> bodynotifyOnUpload = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodynotifyOnRegistration = WorkflowExpression.Compile(bodynotifyOnRegistration, nameof(bodynotifyOnRegistration), required: false);
            var __workflow_bodynotifyOnUpload = WorkflowExpression.Compile(bodynotifyOnUpload, nameof(bodynotifyOnUpload), required: false);
            return new DeferredBodyAction<PatchBundleNotificationsIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/bundle_notifications/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodynotifyOnRegistration != null)
                {
                    body["notify_on_registration"] = ExpressionConverter.ConvertO(__workflow_bodynotifyOnRegistration);
                    bodypropCount++;
                }

                if (__workflow_bodynotifyOnUpload != null)
                {
                    body["notify_on_upload"] = ExpressionConverter.ConvertO(__workflow_bodynotifyOnUpload);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PatchBundleNotificationsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<GetBundleNotificationsResponseItem[], ApiConnectionActionConfiguration> GetBundleNotifications()
        {
            return new DeferredBodyAction<GetBundleNotificationsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/bundle_notifications";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetBundleNotificationsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<PostBundleNotificationsResponse, ApiConnectionActionConfiguration> PostBundleNotifications(Expression<Func<int>> bodybundleId, Expression<Func<int>> bodynotifyUserId = null)
        {
            var __workflow_bodybundleId = WorkflowExpression.Compile(bodybundleId, nameof(bodybundleId), required: true);
            var __workflow_bodynotifyUserId = WorkflowExpression.Compile(bodynotifyUserId, nameof(bodynotifyUserId), required: false);
            return new DeferredBodyAction<PostBundleNotificationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/bundle_notifications";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["bundle_id"] = ExpressionConverter.ConvertO(__workflow_bodybundleId);
                if (__workflow_bodynotifyUserId != null)
                {
                    body["notify_user_id"] = ExpressionConverter.ConvertO(__workflow_bodynotifyUserId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostBundleNotificationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<GetBundleRecipientsResponseItem[], ApiConnectionActionConfiguration> GetBundleRecipients(Expression<Func<int>> bundleId)
        {
            var __workflow_bundleId = WorkflowExpression.Compile(bundleId, nameof(bundleId), required: true);
            return new DeferredBodyAction<GetBundleRecipientsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/bundle_recipients";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["bundle_id"] = ExpressionConverter.Convert(__workflow_bundleId);
                return new ApiConnectionAction<GetBundleRecipientsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<PostBundleRecipientsResponse, ApiConnectionActionConfiguration> PostBundleRecipients(Expression<Func<int>> bodybundleId, Expression<Func<string>> bodyrecipient, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodynote = null)
        {
            var __workflow_bodybundleId = WorkflowExpression.Compile(bodybundleId, nameof(bodybundleId), required: true);
            var __workflow_bodyrecipient = WorkflowExpression.Compile(bodyrecipient, nameof(bodyrecipient), required: true);
            var __workflow_bodycompany = WorkflowExpression.Compile(bodycompany, nameof(bodycompany), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            return new DeferredBodyAction<PostBundleRecipientsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/bundle_recipients";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["bundle_id"] = ExpressionConverter.ConvertO(__workflow_bodybundleId);
                if (__workflow_bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(__workflow_bodycompany);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                bodypropCount++;
                body["recipient"] = ExpressionConverter.ConvertO(__workflow_bodyrecipient);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostBundleRecipientsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<GetBundleRegistrationsResponseItem[], ApiConnectionActionConfiguration> GetBundleRegistrations(Expression<Func<int>> bundleId = null)
        {
            var __workflow_bundleId = WorkflowExpression.Compile(bundleId, nameof(bundleId), required: false);
            return new DeferredBodyAction<GetBundleRegistrationsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/bundle_registrations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_bundleId != null)
                    callPayload.Queries["bundle_id"] = ExpressionConverter.Convert(__workflow_bundleId);
                return new ApiConnectionAction<GetBundleRegistrationsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<GetBundlesIdResponse, ApiConnectionActionConfiguration> GetBundlesId(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetBundlesIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/bundles/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetBundlesIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteBundlesId(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/bundles/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<PatchBundlesIdResponse, ApiConnectionActionConfiguration> PatchBundlesId(Expression<Func<int>> id, Expression<Func<string>> bodyexpiresAt = null, Expression<Func<bodypermissionsInput>> bodypermissions = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyexpiresAt = WorkflowExpression.Compile(bodyexpiresAt, nameof(bodyexpiresAt), required: false);
            var __workflow_bodypermissions = WorkflowExpression.Compile(bodypermissions, nameof(bodypermissions), required: false);
            return new DeferredBodyAction<PatchBundlesIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/bundles/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyexpiresAt != null)
                {
                    body["expires_at"] = ExpressionConverter.ConvertO(__workflow_bodyexpiresAt);
                    bodypropCount++;
                }

                if (__workflow_bodypermissions != null)
                {
                    body["permissions"] = ExpressionConverter.ConvertO(__workflow_bodypermissions);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PatchBundlesIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<GetBundlesResponseItem[], ApiConnectionActionConfiguration> GetBundles()
        {
            return new DeferredBodyAction<GetBundlesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/bundles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetBundlesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<PostBundlesResponse, ApiConnectionActionConfiguration> PostBundles(Expression<Func<string[]>> bodypaths, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyexpiresAt = null, Expression<Func<int>> bodymaxUses = null, Expression<Func<string>> bodynote = null, Expression<Func<string>> bodypassword = null, Expression<Func<bodypermissionsInput>> bodypermissions = null, Expression<Func<bool>> bodyrequireRegistration = null)
        {
            var __workflow_bodypaths = WorkflowExpression.Compile(bodypaths, nameof(bodypaths), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyexpiresAt = WorkflowExpression.Compile(bodyexpiresAt, nameof(bodyexpiresAt), required: false);
            var __workflow_bodymaxUses = WorkflowExpression.Compile(bodymaxUses, nameof(bodymaxUses), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodypermissions = WorkflowExpression.Compile(bodypermissions, nameof(bodypermissions), required: false);
            var __workflow_bodyrequireRegistration = WorkflowExpression.Compile(bodyrequireRegistration, nameof(bodyrequireRegistration), required: false);
            return new DeferredBodyAction<PostBundlesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/bundles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiresAt != null)
                {
                    body["expires_at"] = ExpressionConverter.ConvertO(__workflow_bodyexpiresAt);
                    bodypropCount++;
                }

                if (__workflow_bodymaxUses != null)
                {
                    body["max_uses"] = ExpressionConverter.ConvertO(__workflow_bodymaxUses);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                bodypropCount++;
                body["paths"] = ExpressionConverter.ConvertO(__workflow_bodypaths);
                if (__workflow_bodypermissions != null)
                {
                    body["permissions"] = ExpressionConverter.ConvertO(__workflow_bodypermissions);
                    bodypropCount++;
                }

                if (__workflow_bodyrequireRegistration != null)
                {
                    body["require_registration"] = ExpressionConverter.ConvertO(__workflow_bodyrequireRegistration);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostBundlesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteFilesPath(Expression<Func<string>> path)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/files/{0}", __workflow_path.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<FileActionFindResponse, ApiConnectionActionConfiguration> FileActionFind(Expression<Func<string>> path)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            return new DeferredBodyAction<FileActionFindResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/file_actions/metadata/{0}", __workflow_path.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FileActionFindResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<FileActionCopyResponse, ApiConnectionActionConfiguration> FileActionCopy(Expression<Func<string>> path, Expression<Func<string>> bodydestinationFolderPath = null, Expression<Func<string>> bodydestinationName = null)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            var __workflow_bodydestinationFolderPath = WorkflowExpression.Compile(bodydestinationFolderPath, nameof(bodydestinationFolderPath), required: false);
            var __workflow_bodydestinationName = WorkflowExpression.Compile(bodydestinationName, nameof(bodydestinationName), required: false);
            return new DeferredBodyAction<FileActionCopyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/file_actions/copy/{0}", __workflow_path.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydestinationFolderPath != null)
                {
                    body["destination_folder_path"] = ExpressionConverter.ConvertO(__workflow_bodydestinationFolderPath);
                    bodypropCount++;
                }

                if (__workflow_bodydestinationName != null)
                {
                    body["destination_name"] = ExpressionConverter.ConvertO(__workflow_bodydestinationName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FileActionCopyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<FileActionMoveResponse, ApiConnectionActionConfiguration> FileActionMove(Expression<Func<string>> path, Expression<Func<string>> bodydestinationFolderPath = null, Expression<Func<string>> bodydestinationName = null)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            var __workflow_bodydestinationFolderPath = WorkflowExpression.Compile(bodydestinationFolderPath, nameof(bodydestinationFolderPath), required: false);
            var __workflow_bodydestinationName = WorkflowExpression.Compile(bodydestinationName, nameof(bodydestinationName), required: false);
            return new DeferredBodyAction<FileActionMoveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/file_actions/move/{0}", __workflow_path.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydestinationFolderPath != null)
                {
                    body["destination_folder_path"] = ExpressionConverter.ConvertO(__workflow_bodydestinationFolderPath);
                    bodypropCount++;
                }

                if (__workflow_bodydestinationName != null)
                {
                    body["destination_name"] = ExpressionConverter.ConvertO(__workflow_bodydestinationName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FileActionMoveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<FolderListForPathResponseItem[], ApiConnectionActionConfiguration> FolderListForPath(Expression<Func<string>> path)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            return new DeferredBodyAction<FolderListForPathResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/folders/{0}", __workflow_path.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FolderListForPathResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<PostFoldersPathResponse, ApiConnectionActionConfiguration> PostFoldersPath(Expression<Func<string>> path)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            return new DeferredBodyAction<PostFoldersPathResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/folders/{0}", __workflow_path.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PostFoldersPathResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<PostGroupsGroupIdUsersResponse, ApiConnectionActionConfiguration> PostGroupsGroupIdUsers(Expression<Func<int>> groupId, Expression<Func<string>> bodyusername, Expression<Func<bodyauthenticationMethodInput>> bodyauthenticationMethod = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodygroupIds = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodypassword = null, Expression<Func<bool>> bodyrequirePasswordChange = null, Expression<Func<string>> bodyuserHome = null, Expression<Func<string>> bodyuserRoot = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_bodyusername = WorkflowExpression.Compile(bodyusername, nameof(bodyusername), required: true);
            var __workflow_bodyauthenticationMethod = WorkflowExpression.Compile(bodyauthenticationMethod, nameof(bodyauthenticationMethod), required: false);
            var __workflow_bodycompany = WorkflowExpression.Compile(bodycompany, nameof(bodycompany), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodygroupIds = WorkflowExpression.Compile(bodygroupIds, nameof(bodygroupIds), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodyrequirePasswordChange = WorkflowExpression.Compile(bodyrequirePasswordChange, nameof(bodyrequirePasswordChange), required: false);
            var __workflow_bodyuserHome = WorkflowExpression.Compile(bodyuserHome, nameof(bodyuserHome), required: false);
            var __workflow_bodyuserRoot = WorkflowExpression.Compile(bodyuserRoot, nameof(bodyuserRoot), required: false);
            return new DeferredBodyAction<PostGroupsGroupIdUsersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/groups/{0}/users", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyauthenticationMethod != null)
                {
                    body["authentication_method"] = ExpressionConverter.ConvertO(__workflow_bodyauthenticationMethod);
                    bodypropCount++;
                }

                if (__workflow_bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(__workflow_bodycompany);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodygroupIds != null)
                {
                    body["group_ids"] = ExpressionConverter.ConvertO(__workflow_bodygroupIds);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodyrequirePasswordChange != null)
                {
                    body["require_password_change"] = ExpressionConverter.ConvertO(__workflow_bodyrequirePasswordChange);
                    bodypropCount++;
                }

                if (__workflow_bodyuserHome != null)
                {
                    body["user_home"] = ExpressionConverter.ConvertO(__workflow_bodyuserHome);
                    bodypropCount++;
                }

                if (__workflow_bodyuserRoot != null)
                {
                    body["user_root"] = ExpressionConverter.ConvertO(__workflow_bodyuserRoot);
                    bodypropCount++;
                }

                bodypropCount++;
                body["username"] = ExpressionConverter.ConvertO(__workflow_bodyusername);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostGroupsGroupIdUsersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<GetGroupsIdResponse, ApiConnectionActionConfiguration> GetGroupsId(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetGroupsIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/groups/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetGroupsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteGroupsId(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/groups/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<PatchGroupsIdResponse, ApiConnectionActionConfiguration> PatchGroupsId(Expression<Func<int>> id, Expression<Func<string>> bodyadminIds = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodyuserIds = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyadminIds = WorkflowExpression.Compile(bodyadminIds, nameof(bodyadminIds), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodyuserIds = WorkflowExpression.Compile(bodyuserIds, nameof(bodyuserIds), required: false);
            return new DeferredBodyAction<PatchGroupsIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/groups/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyadminIds != null)
                {
                    body["admin_ids"] = ExpressionConverter.ConvertO(__workflow_bodyadminIds);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (__workflow_bodyuserIds != null)
                {
                    body["user_ids"] = ExpressionConverter.ConvertO(__workflow_bodyuserIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PatchGroupsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<GetGroupsResponseItem[], ApiConnectionActionConfiguration> GetGroups()
        {
            return new DeferredBodyAction<GetGroupsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/groups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetGroupsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<PostGroupsResponse, ApiConnectionActionConfiguration> PostGroups(Expression<Func<string>> bodyname, Expression<Func<string>> bodyadminIds = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodyuserIds = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyadminIds = WorkflowExpression.Compile(bodyadminIds, nameof(bodyadminIds), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodyuserIds = WorkflowExpression.Compile(bodyuserIds, nameof(bodyuserIds), required: false);
            return new DeferredBodyAction<PostGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/groups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyadminIds != null)
                {
                    body["admin_ids"] = ExpressionConverter.ConvertO(__workflow_bodyadminIds);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (__workflow_bodyuserIds != null)
                {
                    body["user_ids"] = ExpressionConverter.ConvertO(__workflow_bodyuserIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DownloadFileContentUsingPath(Expression<Func<string>> path, Expression<Func<bool>> forceOctetStream = null)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            var __workflow_forceOctetStream = WorkflowExpression.Compile(forceOctetStream, nameof(forceOctetStream), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/file_contents/{0}", __workflow_path.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["force_octet_stream"] = Convert.ToString(false);
                if (__workflow_forceOctetStream != null)
                    callPayload.Queries["force_octet_stream"] = ExpressionConverter.Convert(__workflow_forceOctetStream);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UploadFile(Expression<Func<string>> path, Expression<Func<string>> body = null)
        {
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/file_contents/{0}", __workflow_path.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UploadFileToRemoteServer(Expression<Func<int>> remoteServerId, Expression<Func<string>> destinationName, Expression<Func<string>> destinationFolderPath = null, Expression<Func<string>> body = null)
        {
            var __workflow_remoteServerId = WorkflowExpression.Compile(remoteServerId, nameof(remoteServerId), required: true);
            var __workflow_destinationName = WorkflowExpression.Compile(destinationName, nameof(destinationName), required: true);
            var __workflow_destinationFolderPath = WorkflowExpression.Compile(destinationFolderPath, nameof(destinationFolderPath), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/_power_automate_underscore/upload_to_remote_server";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["remote_server_id"] = ExpressionConverter.Convert(__workflow_remoteServerId);
                if (__workflow_destinationFolderPath != null)
                    callPayload.Queries["destination_folder_path"] = ExpressionConverter.Convert(__workflow_destinationFolderPath);
                callPayload.Queries["destination_name"] = ExpressionConverter.Convert(__workflow_destinationName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<CopyFileToRemoteServerResponse, ApiConnectionActionConfiguration> CopyFileToRemoteServer(Expression<Func<string>> sourcePath, Expression<Func<int>> remoteServerId, Expression<Func<string>> destinationFolderPath = null, Expression<Func<string>> destinationName = null, Expression<Func<bool>> overwrite = null, Expression<Func<bool>> copyBehaviors = null, Expression<Func<bool>> structure = null)
        {
            var __workflow_sourcePath = WorkflowExpression.Compile(sourcePath, nameof(sourcePath), required: true);
            var __workflow_remoteServerId = WorkflowExpression.Compile(remoteServerId, nameof(remoteServerId), required: true);
            var __workflow_destinationFolderPath = WorkflowExpression.Compile(destinationFolderPath, nameof(destinationFolderPath), required: false);
            var __workflow_destinationName = WorkflowExpression.Compile(destinationName, nameof(destinationName), required: false);
            var __workflow_overwrite = WorkflowExpression.Compile(overwrite, nameof(overwrite), required: false);
            var __workflow_copyBehaviors = WorkflowExpression.Compile(copyBehaviors, nameof(copyBehaviors), required: false);
            var __workflow_structure = WorkflowExpression.Compile(structure, nameof(structure), required: false);
            return new DeferredBodyAction<CopyFileToRemoteServerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/_power_automate_underscore/copy_to_remote_server";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source_path"] = ExpressionConverter.Convert(__workflow_sourcePath);
                callPayload.Queries["remote_server_id"] = ExpressionConverter.Convert(__workflow_remoteServerId);
                if (__workflow_destinationFolderPath != null)
                    callPayload.Queries["destination_folder_path"] = ExpressionConverter.Convert(__workflow_destinationFolderPath);
                if (__workflow_destinationName != null)
                    callPayload.Queries["destination_name"] = ExpressionConverter.Convert(__workflow_destinationName);
                if (__workflow_overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(__workflow_overwrite);
                if (__workflow_copyBehaviors != null)
                    callPayload.Queries["copy_behaviors"] = ExpressionConverter.Convert(__workflow_copyBehaviors);
                if (__workflow_structure != null)
                    callPayload.Queries["structure"] = ExpressionConverter.Convert(__workflow_structure);
                return new ApiConnectionAction<CopyFileToRemoteServerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<MoveFileToRemoteServerResponse, ApiConnectionActionConfiguration> MoveFileToRemoteServer(Expression<Func<string>> sourcePath, Expression<Func<int>> remoteServerId, Expression<Func<string>> destinationFolderPath = null, Expression<Func<string>> destinationName = null, Expression<Func<bool>> overwrite = null)
        {
            var __workflow_sourcePath = WorkflowExpression.Compile(sourcePath, nameof(sourcePath), required: true);
            var __workflow_remoteServerId = WorkflowExpression.Compile(remoteServerId, nameof(remoteServerId), required: true);
            var __workflow_destinationFolderPath = WorkflowExpression.Compile(destinationFolderPath, nameof(destinationFolderPath), required: false);
            var __workflow_destinationName = WorkflowExpression.Compile(destinationName, nameof(destinationName), required: false);
            var __workflow_overwrite = WorkflowExpression.Compile(overwrite, nameof(overwrite), required: false);
            return new DeferredBodyAction<MoveFileToRemoteServerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/_power_automate_underscore/move_to_remote_server";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source_path"] = ExpressionConverter.Convert(__workflow_sourcePath);
                callPayload.Queries["remote_server_id"] = ExpressionConverter.Convert(__workflow_remoteServerId);
                if (__workflow_destinationFolderPath != null)
                    callPayload.Queries["destination_folder_path"] = ExpressionConverter.Convert(__workflow_destinationFolderPath);
                if (__workflow_destinationName != null)
                    callPayload.Queries["destination_name"] = ExpressionConverter.Convert(__workflow_destinationName);
                if (__workflow_overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(__workflow_overwrite);
                return new ApiConnectionAction<MoveFileToRemoteServerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UploadFileToSnapshot(Expression<Func<int>> snapshotId, Expression<Func<string>> destinationName, Expression<Func<string>> destinationFolderPath = null, Expression<Func<string>> body = null)
        {
            var __workflow_snapshotId = WorkflowExpression.Compile(snapshotId, nameof(snapshotId), required: true);
            var __workflow_destinationName = WorkflowExpression.Compile(destinationName, nameof(destinationName), required: true);
            var __workflow_destinationFolderPath = WorkflowExpression.Compile(destinationFolderPath, nameof(destinationFolderPath), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/_power_automate_underscore/upload_to_snapshot";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["snapshot_id"] = ExpressionConverter.Convert(__workflow_snapshotId);
                if (__workflow_destinationFolderPath != null)
                    callPayload.Queries["destination_folder_path"] = ExpressionConverter.Convert(__workflow_destinationFolderPath);
                callPayload.Queries["destination_name"] = ExpressionConverter.Convert(__workflow_destinationName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<CopyFileToSnapshotResponse, ApiConnectionActionConfiguration> CopyFileToSnapshot(Expression<Func<string>> sourcePath, Expression<Func<int>> snapshotId, Expression<Func<string>> destinationFolderPath = null, Expression<Func<string>> destinationName = null, Expression<Func<bool>> overwrite = null, Expression<Func<bool>> copyBehaviors = null, Expression<Func<bool>> structure = null)
        {
            var __workflow_sourcePath = WorkflowExpression.Compile(sourcePath, nameof(sourcePath), required: true);
            var __workflow_snapshotId = WorkflowExpression.Compile(snapshotId, nameof(snapshotId), required: true);
            var __workflow_destinationFolderPath = WorkflowExpression.Compile(destinationFolderPath, nameof(destinationFolderPath), required: false);
            var __workflow_destinationName = WorkflowExpression.Compile(destinationName, nameof(destinationName), required: false);
            var __workflow_overwrite = WorkflowExpression.Compile(overwrite, nameof(overwrite), required: false);
            var __workflow_copyBehaviors = WorkflowExpression.Compile(copyBehaviors, nameof(copyBehaviors), required: false);
            var __workflow_structure = WorkflowExpression.Compile(structure, nameof(structure), required: false);
            return new DeferredBodyAction<CopyFileToSnapshotResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/_power_automate_underscore/copy_to_snapshot";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source_path"] = ExpressionConverter.Convert(__workflow_sourcePath);
                callPayload.Queries["snapshot_id"] = ExpressionConverter.Convert(__workflow_snapshotId);
                if (__workflow_destinationFolderPath != null)
                    callPayload.Queries["destination_folder_path"] = ExpressionConverter.Convert(__workflow_destinationFolderPath);
                if (__workflow_destinationName != null)
                    callPayload.Queries["destination_name"] = ExpressionConverter.Convert(__workflow_destinationName);
                if (__workflow_overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(__workflow_overwrite);
                if (__workflow_copyBehaviors != null)
                    callPayload.Queries["copy_behaviors"] = ExpressionConverter.Convert(__workflow_copyBehaviors);
                if (__workflow_structure != null)
                    callPayload.Queries["structure"] = ExpressionConverter.Convert(__workflow_structure);
                return new ApiConnectionAction<CopyFileToSnapshotResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<MoveFileToSnapshotResponse, ApiConnectionActionConfiguration> MoveFileToSnapshot(Expression<Func<string>> sourcePath, Expression<Func<int>> snapshotId, Expression<Func<string>> destinationFolderPath = null, Expression<Func<string>> destinationName = null, Expression<Func<bool>> overwrite = null)
        {
            var __workflow_sourcePath = WorkflowExpression.Compile(sourcePath, nameof(sourcePath), required: true);
            var __workflow_snapshotId = WorkflowExpression.Compile(snapshotId, nameof(snapshotId), required: true);
            var __workflow_destinationFolderPath = WorkflowExpression.Compile(destinationFolderPath, nameof(destinationFolderPath), required: false);
            var __workflow_destinationName = WorkflowExpression.Compile(destinationName, nameof(destinationName), required: false);
            var __workflow_overwrite = WorkflowExpression.Compile(overwrite, nameof(overwrite), required: false);
            return new DeferredBodyAction<MoveFileToSnapshotResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/_power_automate_underscore/move_to_snapshot";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source_path"] = ExpressionConverter.Convert(__workflow_sourcePath);
                callPayload.Queries["snapshot_id"] = ExpressionConverter.Convert(__workflow_snapshotId);
                if (__workflow_destinationFolderPath != null)
                    callPayload.Queries["destination_folder_path"] = ExpressionConverter.Convert(__workflow_destinationFolderPath);
                if (__workflow_destinationName != null)
                    callPayload.Queries["destination_name"] = ExpressionConverter.Convert(__workflow_destinationName);
                if (__workflow_overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(__workflow_overwrite);
                return new ApiConnectionAction<MoveFileToSnapshotResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UploadFileToChildSite(Expression<Func<int>> siteId, Expression<Func<string>> destinationName, Expression<Func<string>> destinationFolderPath = null, Expression<Func<string>> body = null)
        {
            var __workflow_siteId = WorkflowExpression.Compile(siteId, nameof(siteId), required: true);
            var __workflow_destinationName = WorkflowExpression.Compile(destinationName, nameof(destinationName), required: true);
            var __workflow_destinationFolderPath = WorkflowExpression.Compile(destinationFolderPath, nameof(destinationFolderPath), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/_power_automate_underscore/upload_to_child_site";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["site_id"] = ExpressionConverter.Convert(__workflow_siteId);
                if (__workflow_destinationFolderPath != null)
                    callPayload.Queries["destination_folder_path"] = ExpressionConverter.Convert(__workflow_destinationFolderPath);
                callPayload.Queries["destination_name"] = ExpressionConverter.Convert(__workflow_destinationName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<CopyFileToChildSiteResponse, ApiConnectionActionConfiguration> CopyFileToChildSite(Expression<Func<string>> sourcePath, Expression<Func<int>> siteId, Expression<Func<string>> destinationFolderPath = null, Expression<Func<string>> destinationName = null, Expression<Func<bool>> overwrite = null, Expression<Func<bool>> copyBehaviors = null, Expression<Func<bool>> structure = null)
        {
            var __workflow_sourcePath = WorkflowExpression.Compile(sourcePath, nameof(sourcePath), required: true);
            var __workflow_siteId = WorkflowExpression.Compile(siteId, nameof(siteId), required: true);
            var __workflow_destinationFolderPath = WorkflowExpression.Compile(destinationFolderPath, nameof(destinationFolderPath), required: false);
            var __workflow_destinationName = WorkflowExpression.Compile(destinationName, nameof(destinationName), required: false);
            var __workflow_overwrite = WorkflowExpression.Compile(overwrite, nameof(overwrite), required: false);
            var __workflow_copyBehaviors = WorkflowExpression.Compile(copyBehaviors, nameof(copyBehaviors), required: false);
            var __workflow_structure = WorkflowExpression.Compile(structure, nameof(structure), required: false);
            return new DeferredBodyAction<CopyFileToChildSiteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/_power_automate_underscore/copy_to_child_site";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source_path"] = ExpressionConverter.Convert(__workflow_sourcePath);
                callPayload.Queries["site_id"] = ExpressionConverter.Convert(__workflow_siteId);
                if (__workflow_destinationFolderPath != null)
                    callPayload.Queries["destination_folder_path"] = ExpressionConverter.Convert(__workflow_destinationFolderPath);
                if (__workflow_destinationName != null)
                    callPayload.Queries["destination_name"] = ExpressionConverter.Convert(__workflow_destinationName);
                if (__workflow_overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(__workflow_overwrite);
                if (__workflow_copyBehaviors != null)
                    callPayload.Queries["copy_behaviors"] = ExpressionConverter.Convert(__workflow_copyBehaviors);
                if (__workflow_structure != null)
                    callPayload.Queries["structure"] = ExpressionConverter.Convert(__workflow_structure);
                return new ApiConnectionAction<CopyFileToChildSiteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "filescom")]
        public IBodyWorkflowAction<MoveFileToChildSiteResponse, ApiConnectionActionConfiguration> MoveFileToChildSite(Expression<Func<string>> sourcePath, Expression<Func<int>> siteId, Expression<Func<string>> destinationFolderPath = null, Expression<Func<string>> destinationName = null, Expression<Func<bool>> overwrite = null)
        {
            var __workflow_sourcePath = WorkflowExpression.Compile(sourcePath, nameof(sourcePath), required: true);
            var __workflow_siteId = WorkflowExpression.Compile(siteId, nameof(siteId), required: true);
            var __workflow_destinationFolderPath = WorkflowExpression.Compile(destinationFolderPath, nameof(destinationFolderPath), required: false);
            var __workflow_destinationName = WorkflowExpression.Compile(destinationName, nameof(destinationName), required: false);
            var __workflow_overwrite = WorkflowExpression.Compile(overwrite, nameof(overwrite), required: false);
            return new DeferredBodyAction<MoveFileToChildSiteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/_power_automate_underscore/move_to_child_site";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source_path"] = ExpressionConverter.Convert(__workflow_sourcePath);
                callPayload.Queries["site_id"] = ExpressionConverter.Convert(__workflow_siteId);
                if (__workflow_destinationFolderPath != null)
                    callPayload.Queries["destination_folder_path"] = ExpressionConverter.Convert(__workflow_destinationFolderPath);
                if (__workflow_destinationName != null)
                    callPayload.Queries["destination_name"] = ExpressionConverter.Convert(__workflow_destinationName);
                if (__workflow_overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(__workflow_overwrite);
                return new ApiConnectionAction<MoveFileToChildSiteResponse>(callPayload);
            });
        }
    }

    public class FilescomTriggers([ConnectionName] string connectionId)
    {
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

        [JsonProperty("ai_assistant_personality_id")]
        public int AiAssistantPersonalityId { get; set; }

        [JsonProperty("desktop_configuration_profile_id")]
        public int DesktopConfigurationProfileId { get; set; }

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

        [JsonProperty("primary_group_id")]
        public int PrimaryGroupId { get; set; }

        [JsonProperty("public_keys_count")]
        public int PublicKeysCount { get; set; }

        [JsonProperty("receive_admin_alerts")]
        public bool ReceiveAdminAlerts { get; set; }

        [JsonProperty("notify_on_all_site_warnings")]
        public bool NotifyOnAllSiteWarnings { get; set; }

        [JsonProperty("notify_on_all_sso_failures")]
        public bool NotifyOnAllSsoFailures { get; set; }

        [JsonProperty("notify_on_all_user_security_events")]
        public bool NotifyOnAllUserSecurityEvents { get; set; }

        [JsonProperty("notify_on_all_pending_work_failures")]
        public bool NotifyOnAllPendingWorkFailures { get; set; }

        [JsonProperty("notify_on_all_siem_http_destination_failures")]
        public bool NotifyOnAllSiemHttpDestinationFailures { get; set; }

        [JsonProperty("notify_on_all_sync_failures")]
        public bool NotifyOnAllSyncFailures { get; set; }

        [JsonProperty("notify_on_all_automation_failures")]
        public bool NotifyOnAllAutomationFailures { get; set; }

        [JsonProperty("notify_on_all_expectation_failures")]
        public bool NotifyOnAllExpectationFailures { get; set; }

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

        [JsonProperty("workspace_admin")]
        public bool WorkspaceAdmin { get; set; }

        [JsonProperty("site_id")]
        public int SiteId { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }

        [JsonProperty("default_workspace_id")]
        public int DefaultWorkspaceId { get; set; }

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

        [JsonProperty("ai_assistant_personality_id")]
        public int AiAssistantPersonalityId { get; set; }

        [JsonProperty("desktop_configuration_profile_id")]
        public int DesktopConfigurationProfileId { get; set; }

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

        [JsonProperty("primary_group_id")]
        public int PrimaryGroupId { get; set; }

        [JsonProperty("public_keys_count")]
        public int PublicKeysCount { get; set; }

        [JsonProperty("receive_admin_alerts")]
        public bool ReceiveAdminAlerts { get; set; }

        [JsonProperty("notify_on_all_site_warnings")]
        public bool NotifyOnAllSiteWarnings { get; set; }

        [JsonProperty("notify_on_all_sso_failures")]
        public bool NotifyOnAllSsoFailures { get; set; }

        [JsonProperty("notify_on_all_user_security_events")]
        public bool NotifyOnAllUserSecurityEvents { get; set; }

        [JsonProperty("notify_on_all_pending_work_failures")]
        public bool NotifyOnAllPendingWorkFailures { get; set; }

        [JsonProperty("notify_on_all_siem_http_destination_failures")]
        public bool NotifyOnAllSiemHttpDestinationFailures { get; set; }

        [JsonProperty("notify_on_all_sync_failures")]
        public bool NotifyOnAllSyncFailures { get; set; }

        [JsonProperty("notify_on_all_automation_failures")]
        public bool NotifyOnAllAutomationFailures { get; set; }

        [JsonProperty("notify_on_all_expectation_failures")]
        public bool NotifyOnAllExpectationFailures { get; set; }

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

        [JsonProperty("workspace_admin")]
        public bool WorkspaceAdmin { get; set; }

        [JsonProperty("site_id")]
        public int SiteId { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }

        [JsonProperty("default_workspace_id")]
        public int DefaultWorkspaceId { get; set; }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyauthenticationMethodInput
    {
        [EnumMember(Value = "password")]
        Password,
        [EnumMember(Value = "email_signup")]
        EmailSignup
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

        [JsonProperty("ai_assistant_personality_id")]
        public int AiAssistantPersonalityId { get; set; }

        [JsonProperty("desktop_configuration_profile_id")]
        public int DesktopConfigurationProfileId { get; set; }

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

        [JsonProperty("primary_group_id")]
        public int PrimaryGroupId { get; set; }

        [JsonProperty("public_keys_count")]
        public int PublicKeysCount { get; set; }

        [JsonProperty("receive_admin_alerts")]
        public bool ReceiveAdminAlerts { get; set; }

        [JsonProperty("notify_on_all_site_warnings")]
        public bool NotifyOnAllSiteWarnings { get; set; }

        [JsonProperty("notify_on_all_sso_failures")]
        public bool NotifyOnAllSsoFailures { get; set; }

        [JsonProperty("notify_on_all_user_security_events")]
        public bool NotifyOnAllUserSecurityEvents { get; set; }

        [JsonProperty("notify_on_all_pending_work_failures")]
        public bool NotifyOnAllPendingWorkFailures { get; set; }

        [JsonProperty("notify_on_all_siem_http_destination_failures")]
        public bool NotifyOnAllSiemHttpDestinationFailures { get; set; }

        [JsonProperty("notify_on_all_sync_failures")]
        public bool NotifyOnAllSyncFailures { get; set; }

        [JsonProperty("notify_on_all_automation_failures")]
        public bool NotifyOnAllAutomationFailures { get; set; }

        [JsonProperty("notify_on_all_expectation_failures")]
        public bool NotifyOnAllExpectationFailures { get; set; }

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

        [JsonProperty("workspace_admin")]
        public bool WorkspaceAdmin { get; set; }

        [JsonProperty("site_id")]
        public int SiteId { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }

        [JsonProperty("default_workspace_id")]
        public int DefaultWorkspaceId { get; set; }

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

        [JsonProperty("ai_assistant_personality_id")]
        public int AiAssistantPersonalityId { get; set; }

        [JsonProperty("desktop_configuration_profile_id")]
        public int DesktopConfigurationProfileId { get; set; }

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

        [JsonProperty("primary_group_id")]
        public int PrimaryGroupId { get; set; }

        [JsonProperty("public_keys_count")]
        public int PublicKeysCount { get; set; }

        [JsonProperty("receive_admin_alerts")]
        public bool ReceiveAdminAlerts { get; set; }

        [JsonProperty("notify_on_all_site_warnings")]
        public bool NotifyOnAllSiteWarnings { get; set; }

        [JsonProperty("notify_on_all_sso_failures")]
        public bool NotifyOnAllSsoFailures { get; set; }

        [JsonProperty("notify_on_all_user_security_events")]
        public bool NotifyOnAllUserSecurityEvents { get; set; }

        [JsonProperty("notify_on_all_pending_work_failures")]
        public bool NotifyOnAllPendingWorkFailures { get; set; }

        [JsonProperty("notify_on_all_siem_http_destination_failures")]
        public bool NotifyOnAllSiemHttpDestinationFailures { get; set; }

        [JsonProperty("notify_on_all_sync_failures")]
        public bool NotifyOnAllSyncFailures { get; set; }

        [JsonProperty("notify_on_all_automation_failures")]
        public bool NotifyOnAllAutomationFailures { get; set; }

        [JsonProperty("notify_on_all_expectation_failures")]
        public bool NotifyOnAllExpectationFailures { get; set; }

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

        [JsonProperty("workspace_admin")]
        public bool WorkspaceAdmin { get; set; }

        [JsonProperty("site_id")]
        public int SiteId { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }

        [JsonProperty("default_workspace_id")]
        public int DefaultWorkspaceId { get; set; }

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

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }

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

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }

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

        [JsonProperty("notify_current_user")]
        public bool NotifyCurrentUser { get; set; }

        [JsonProperty("notify_user_id")]
        public int NotifyUserId { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }
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

        [JsonProperty("notify_current_user")]
        public bool NotifyCurrentUser { get; set; }

        [JsonProperty("notify_user_id")]
        public int NotifyUserId { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }
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

        [JsonProperty("notify_current_user")]
        public bool NotifyCurrentUser { get; set; }

        [JsonProperty("notify_user_id")]
        public int NotifyUserId { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }
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

        [JsonProperty("notify_current_user")]
        public bool NotifyCurrentUser { get; set; }

        [JsonProperty("notify_user_id")]
        public int NotifyUserId { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }
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

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }
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

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }
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

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }

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

        [JsonProperty("bypasses_site_expiration_rules")]
        public bool BypassesSiteExpirationRules { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("dont_separate_submissions_by_folder")]
        public bool DontSeparateSubmissionsByFolder { get; set; }

        [JsonProperty("max_uses")]
        public int MaxUses { get; set; }

        [JsonProperty("internal_name")]
        public string InternalName { get; set; }

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

        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        [JsonProperty("clickwrap_id")]
        public int ClickwrapId { get; set; }

        [JsonProperty("inbox_id")]
        public int InboxId { get; set; }

        [JsonProperty("watermark_attachment")]
        public GetBundlesIdResponseWatermarkAttachmentType WatermarkAttachment { get; set; }

        [JsonProperty("watermark_value")]
        public JToken WatermarkValue { get; set; }

        [JsonProperty("send_one_time_password_to_recipient_at_registration")]
        public bool SendOneTimePasswordToRecipientAtRegistration { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }

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

        [JsonProperty("bypasses_site_expiration_rules")]
        public bool BypassesSiteExpirationRules { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("dont_separate_submissions_by_folder")]
        public bool DontSeparateSubmissionsByFolder { get; set; }

        [JsonProperty("max_uses")]
        public int MaxUses { get; set; }

        [JsonProperty("internal_name")]
        public string InternalName { get; set; }

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

        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        [JsonProperty("clickwrap_id")]
        public int ClickwrapId { get; set; }

        [JsonProperty("inbox_id")]
        public int InboxId { get; set; }

        [JsonProperty("watermark_attachment")]
        public PatchBundlesIdResponseWatermarkAttachmentType WatermarkAttachment { get; set; }

        [JsonProperty("watermark_value")]
        public JToken WatermarkValue { get; set; }

        [JsonProperty("send_one_time_password_to_recipient_at_registration")]
        public bool SendOneTimePasswordToRecipientAtRegistration { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypermissionsInput
    {
        [EnumMember(Value = "read")]
        Read,
        [EnumMember(Value = "write")]
        Write,
        [EnumMember(Value = "read_write")]
        ReadWrite,
        [EnumMember(Value = "full")]
        Full,
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "preview_only")]
        PreviewOnly
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

        [JsonProperty("bypasses_site_expiration_rules")]
        public bool BypassesSiteExpirationRules { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("dont_separate_submissions_by_folder")]
        public bool DontSeparateSubmissionsByFolder { get; set; }

        [JsonProperty("max_uses")]
        public int MaxUses { get; set; }

        [JsonProperty("internal_name")]
        public string InternalName { get; set; }

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

        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        [JsonProperty("clickwrap_id")]
        public int ClickwrapId { get; set; }

        [JsonProperty("inbox_id")]
        public int InboxId { get; set; }

        [JsonProperty("watermark_attachment")]
        public GetBundlesResponseItemWatermarkAttachmentType WatermarkAttachment { get; set; }

        [JsonProperty("watermark_value")]
        public JToken WatermarkValue { get; set; }

        [JsonProperty("send_one_time_password_to_recipient_at_registration")]
        public bool SendOneTimePasswordToRecipientAtRegistration { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }

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

        [JsonProperty("bypasses_site_expiration_rules")]
        public bool BypassesSiteExpirationRules { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("dont_separate_submissions_by_folder")]
        public bool DontSeparateSubmissionsByFolder { get; set; }

        [JsonProperty("max_uses")]
        public int MaxUses { get; set; }

        [JsonProperty("internal_name")]
        public string InternalName { get; set; }

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

        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        [JsonProperty("clickwrap_id")]
        public int ClickwrapId { get; set; }

        [JsonProperty("inbox_id")]
        public int InboxId { get; set; }

        [JsonProperty("watermark_attachment")]
        public PostBundlesResponseWatermarkAttachmentType WatermarkAttachment { get; set; }

        [JsonProperty("watermark_value")]
        public JToken WatermarkValue { get; set; }

        [JsonProperty("send_one_time_password_to_recipient_at_registration")]
        public bool SendOneTimePasswordToRecipientAtRegistration { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }

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

        [JsonProperty("created_by_sync_id")]
        public int CreatedBySyncId { get; set; }

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

        [JsonProperty("last_modified_by_sync_id")]
        public int LastModifiedBySyncId { get; set; }

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

        [JsonProperty("created_by_sync_id")]
        public int CreatedBySyncId { get; set; }

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

        [JsonProperty("last_modified_by_sync_id")]
        public int LastModifiedBySyncId { get; set; }

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

        [JsonProperty("created_by_sync_id")]
        public int CreatedBySyncId { get; set; }

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

        [JsonProperty("last_modified_by_sync_id")]
        public int LastModifiedBySyncId { get; set; }

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

        [JsonProperty("ai_assistant_personality_id")]
        public int AiAssistantPersonalityId { get; set; }

        [JsonProperty("desktop_configuration_profile_id")]
        public int DesktopConfigurationProfileId { get; set; }

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

        [JsonProperty("primary_group_id")]
        public int PrimaryGroupId { get; set; }

        [JsonProperty("public_keys_count")]
        public int PublicKeysCount { get; set; }

        [JsonProperty("receive_admin_alerts")]
        public bool ReceiveAdminAlerts { get; set; }

        [JsonProperty("notify_on_all_site_warnings")]
        public bool NotifyOnAllSiteWarnings { get; set; }

        [JsonProperty("notify_on_all_sso_failures")]
        public bool NotifyOnAllSsoFailures { get; set; }

        [JsonProperty("notify_on_all_user_security_events")]
        public bool NotifyOnAllUserSecurityEvents { get; set; }

        [JsonProperty("notify_on_all_pending_work_failures")]
        public bool NotifyOnAllPendingWorkFailures { get; set; }

        [JsonProperty("notify_on_all_siem_http_destination_failures")]
        public bool NotifyOnAllSiemHttpDestinationFailures { get; set; }

        [JsonProperty("notify_on_all_sync_failures")]
        public bool NotifyOnAllSyncFailures { get; set; }

        [JsonProperty("notify_on_all_automation_failures")]
        public bool NotifyOnAllAutomationFailures { get; set; }

        [JsonProperty("notify_on_all_expectation_failures")]
        public bool NotifyOnAllExpectationFailures { get; set; }

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

        [JsonProperty("workspace_admin")]
        public bool WorkspaceAdmin { get; set; }

        [JsonProperty("site_id")]
        public int SiteId { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }

        [JsonProperty("default_workspace_id")]
        public int DefaultWorkspaceId { get; set; }

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

        [JsonProperty("ai_assistant_personality_id")]
        public int AiAssistantPersonalityId { get; set; }

        [JsonProperty("ftp_permission")]
        public bool FtpPermission { get; set; }

        [JsonProperty("sftp_permission")]
        public bool SftpPermission { get; set; }

        [JsonProperty("dav_permission")]
        public bool DavPermission { get; set; }

        [JsonProperty("restapi_permission")]
        public bool RestapiPermission { get; set; }

        [JsonProperty("desktop_configuration_profile_id")]
        public int DesktopConfigurationProfileId { get; set; }

        [JsonProperty("site_id")]
        public int SiteId { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }
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

        [JsonProperty("ai_assistant_personality_id")]
        public int AiAssistantPersonalityId { get; set; }

        [JsonProperty("ftp_permission")]
        public bool FtpPermission { get; set; }

        [JsonProperty("sftp_permission")]
        public bool SftpPermission { get; set; }

        [JsonProperty("dav_permission")]
        public bool DavPermission { get; set; }

        [JsonProperty("restapi_permission")]
        public bool RestapiPermission { get; set; }

        [JsonProperty("desktop_configuration_profile_id")]
        public int DesktopConfigurationProfileId { get; set; }

        [JsonProperty("site_id")]
        public int SiteId { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }
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

        [JsonProperty("ai_assistant_personality_id")]
        public int AiAssistantPersonalityId { get; set; }

        [JsonProperty("ftp_permission")]
        public bool FtpPermission { get; set; }

        [JsonProperty("sftp_permission")]
        public bool SftpPermission { get; set; }

        [JsonProperty("dav_permission")]
        public bool DavPermission { get; set; }

        [JsonProperty("restapi_permission")]
        public bool RestapiPermission { get; set; }

        [JsonProperty("desktop_configuration_profile_id")]
        public int DesktopConfigurationProfileId { get; set; }

        [JsonProperty("site_id")]
        public int SiteId { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }
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

        [JsonProperty("ai_assistant_personality_id")]
        public int AiAssistantPersonalityId { get; set; }

        [JsonProperty("ftp_permission")]
        public bool FtpPermission { get; set; }

        [JsonProperty("sftp_permission")]
        public bool SftpPermission { get; set; }

        [JsonProperty("dav_permission")]
        public bool DavPermission { get; set; }

        [JsonProperty("restapi_permission")]
        public bool RestapiPermission { get; set; }

        [JsonProperty("desktop_configuration_profile_id")]
        public int DesktopConfigurationProfileId { get; set; }

        [JsonProperty("site_id")]
        public int SiteId { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }
    }

    public class CopyFileToRemoteServerResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("file_migration_id")]
        public int FileMigrationId { get; set; }
    }

    public class MoveFileToRemoteServerResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("file_migration_id")]
        public int FileMigrationId { get; set; }
    }

    public class CopyFileToSnapshotResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("file_migration_id")]
        public int FileMigrationId { get; set; }
    }

    public class MoveFileToSnapshotResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("file_migration_id")]
        public int FileMigrationId { get; set; }
    }

    public class CopyFileToChildSiteResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("file_migration_id")]
        public int FileMigrationId { get; set; }
    }

    public class MoveFileToChildSiteResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("file_migration_id")]
        public int FileMigrationId { get; set; }
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