//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Planner
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PlannerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IWorkflowAction DeleteTask(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/planner/tasks/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskResponseV2> UnassignUsers(Expression<Func<string>> id, Expression<Func<string>> bodyremoveAssignedUsers)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyremoveAssignedUsers = WorkflowExpression.Compile(bodyremoveAssignedUsers, nameof(bodyremoveAssignedUsers), required: true);
            return new DeferredBodyAction<GetTaskResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/planner/tasks/{0}/unassignusers", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString(" return=representation");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["assignments"] = ExpressionConverter.ConvertO(__workflow_bodyremoveAssignedUsers);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetTaskResponseV2>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskResponseV2> AssignUsers(Expression<Func<string>> id, Expression<Func<string>> bodyassignedUserIds)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyassignedUserIds = WorkflowExpression.Compile(bodyassignedUserIds, nameof(bodyassignedUserIds), required: true);
            return new DeferredBodyAction<GetTaskResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/planner/tasks/{0}/assignusers", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString(" return=representation");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["assignments"] = ExpressionConverter.ConvertO(__workflow_bodyassignedUserIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetTaskResponseV2>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<ListMyPlansResponse> ListGroupPlans(Expression<Func<string>> groupId)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            return new DeferredBodyAction<ListMyPlansResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/groups/{0}/planner/plans", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListMyPlansResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<CreateBucketResponse> CreateBucket(Expression<Func<string>> bodyname, Expression<Func<string>> bodygroupId, Expression<Func<string>> bodyplanId)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodygroupId = WorkflowExpression.Compile(bodygroupId, nameof(bodygroupId), required: true);
            var __workflow_bodyplanId = WorkflowExpression.Compile(bodyplanId, nameof(bodyplanId), required: true);
            return new DeferredBodyAction<CreateBucketResponse>(() =>
            {
                var apiCallPath = "/v2/v1.0/planner/buckets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["groupId"] = ExpressionConverter.ConvertO(__workflow_bodygroupId);
                bodypropCount++;
                body["planId"] = ExpressionConverter.ConvertO(__workflow_bodyplanId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateBucketResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskResponseV3> CreateTask(Expression<Func<string>> bodygroupId, Expression<Func<string>> bodyplanId, Expression<Func<string>> bodytitle, Expression<Func<string>> bodybucketId = null, Expression<Func<string>> bodystartDateTime = null, Expression<Func<string>> bodydueDateTime = null, Expression<Func<string>> bodyassignedUserIds = null, Expression<Func<bool>> bodyappliedCategoriespink = null, Expression<Func<bool>> bodyappliedCategoriesred = null, Expression<Func<bool>> bodyappliedCategoriesyellow = null, Expression<Func<bool>> bodyappliedCategoriesgreen = null, Expression<Func<bool>> bodyappliedCategoriesblue = null, Expression<Func<bool>> bodyappliedCategoriespurple = null, Expression<Func<bool>> bodyappliedCategoriesbronze = null, Expression<Func<bool>> bodyappliedCategorieslime = null, Expression<Func<bool>> bodyappliedCategoriesaqua = null, Expression<Func<bool>> bodyappliedCategoriesgray = null, Expression<Func<bool>> bodyappliedCategoriessilver = null, Expression<Func<bool>> bodyappliedCategoriesbrown = null, Expression<Func<bool>> bodyappliedCategoriescranberry = null, Expression<Func<bool>> bodyappliedCategoriesorange = null, Expression<Func<bool>> bodyappliedCategoriespeach = null, Expression<Func<bool>> bodyappliedCategoriesmarigold = null, Expression<Func<bool>> bodyappliedCategorieslightGreen = null, Expression<Func<bool>> bodyappliedCategoriesdarkGreen = null, Expression<Func<bool>> bodyappliedCategoriesteal = null, Expression<Func<bool>> bodyappliedCategorieslightBlue = null, Expression<Func<bool>> bodyappliedCategoriesdarkBlue = null, Expression<Func<bool>> bodyappliedCategorieslavender = null, Expression<Func<bool>> bodyappliedCategoriesplum = null, Expression<Func<bool>> bodyappliedCategorieslightGray = null, Expression<Func<bool>> bodyappliedCategoriesdarkGray = null, Expression<Func<int>> bodypriority = null)
        {
            var __workflow_bodygroupId = WorkflowExpression.Compile(bodygroupId, nameof(bodygroupId), required: true);
            var __workflow_bodyplanId = WorkflowExpression.Compile(bodyplanId, nameof(bodyplanId), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodybucketId = WorkflowExpression.Compile(bodybucketId, nameof(bodybucketId), required: false);
            var __workflow_bodystartDateTime = WorkflowExpression.Compile(bodystartDateTime, nameof(bodystartDateTime), required: false);
            var __workflow_bodydueDateTime = WorkflowExpression.Compile(bodydueDateTime, nameof(bodydueDateTime), required: false);
            var __workflow_bodyassignedUserIds = WorkflowExpression.Compile(bodyassignedUserIds, nameof(bodyassignedUserIds), required: false);
            var __workflow_bodyappliedCategoriespink = WorkflowExpression.Compile(bodyappliedCategoriespink, nameof(bodyappliedCategoriespink), required: false);
            var __workflow_bodyappliedCategoriesred = WorkflowExpression.Compile(bodyappliedCategoriesred, nameof(bodyappliedCategoriesred), required: false);
            var __workflow_bodyappliedCategoriesyellow = WorkflowExpression.Compile(bodyappliedCategoriesyellow, nameof(bodyappliedCategoriesyellow), required: false);
            var __workflow_bodyappliedCategoriesgreen = WorkflowExpression.Compile(bodyappliedCategoriesgreen, nameof(bodyappliedCategoriesgreen), required: false);
            var __workflow_bodyappliedCategoriesblue = WorkflowExpression.Compile(bodyappliedCategoriesblue, nameof(bodyappliedCategoriesblue), required: false);
            var __workflow_bodyappliedCategoriespurple = WorkflowExpression.Compile(bodyappliedCategoriespurple, nameof(bodyappliedCategoriespurple), required: false);
            var __workflow_bodyappliedCategoriesbronze = WorkflowExpression.Compile(bodyappliedCategoriesbronze, nameof(bodyappliedCategoriesbronze), required: false);
            var __workflow_bodyappliedCategorieslime = WorkflowExpression.Compile(bodyappliedCategorieslime, nameof(bodyappliedCategorieslime), required: false);
            var __workflow_bodyappliedCategoriesaqua = WorkflowExpression.Compile(bodyappliedCategoriesaqua, nameof(bodyappliedCategoriesaqua), required: false);
            var __workflow_bodyappliedCategoriesgray = WorkflowExpression.Compile(bodyappliedCategoriesgray, nameof(bodyappliedCategoriesgray), required: false);
            var __workflow_bodyappliedCategoriessilver = WorkflowExpression.Compile(bodyappliedCategoriessilver, nameof(bodyappliedCategoriessilver), required: false);
            var __workflow_bodyappliedCategoriesbrown = WorkflowExpression.Compile(bodyappliedCategoriesbrown, nameof(bodyappliedCategoriesbrown), required: false);
            var __workflow_bodyappliedCategoriescranberry = WorkflowExpression.Compile(bodyappliedCategoriescranberry, nameof(bodyappliedCategoriescranberry), required: false);
            var __workflow_bodyappliedCategoriesorange = WorkflowExpression.Compile(bodyappliedCategoriesorange, nameof(bodyappliedCategoriesorange), required: false);
            var __workflow_bodyappliedCategoriespeach = WorkflowExpression.Compile(bodyappliedCategoriespeach, nameof(bodyappliedCategoriespeach), required: false);
            var __workflow_bodyappliedCategoriesmarigold = WorkflowExpression.Compile(bodyappliedCategoriesmarigold, nameof(bodyappliedCategoriesmarigold), required: false);
            var __workflow_bodyappliedCategorieslightGreen = WorkflowExpression.Compile(bodyappliedCategorieslightGreen, nameof(bodyappliedCategorieslightGreen), required: false);
            var __workflow_bodyappliedCategoriesdarkGreen = WorkflowExpression.Compile(bodyappliedCategoriesdarkGreen, nameof(bodyappliedCategoriesdarkGreen), required: false);
            var __workflow_bodyappliedCategoriesteal = WorkflowExpression.Compile(bodyappliedCategoriesteal, nameof(bodyappliedCategoriesteal), required: false);
            var __workflow_bodyappliedCategorieslightBlue = WorkflowExpression.Compile(bodyappliedCategorieslightBlue, nameof(bodyappliedCategorieslightBlue), required: false);
            var __workflow_bodyappliedCategoriesdarkBlue = WorkflowExpression.Compile(bodyappliedCategoriesdarkBlue, nameof(bodyappliedCategoriesdarkBlue), required: false);
            var __workflow_bodyappliedCategorieslavender = WorkflowExpression.Compile(bodyappliedCategorieslavender, nameof(bodyappliedCategorieslavender), required: false);
            var __workflow_bodyappliedCategoriesplum = WorkflowExpression.Compile(bodyappliedCategoriesplum, nameof(bodyappliedCategoriesplum), required: false);
            var __workflow_bodyappliedCategorieslightGray = WorkflowExpression.Compile(bodyappliedCategorieslightGray, nameof(bodyappliedCategorieslightGray), required: false);
            var __workflow_bodyappliedCategoriesdarkGray = WorkflowExpression.Compile(bodyappliedCategoriesdarkGray, nameof(bodyappliedCategoriesdarkGray), required: false);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: false);
            return new DeferredBodyAction<GetTaskResponseV3>(() =>
            {
                var apiCallPath = "/v2/beta/planner/tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString(" return=representation");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["groupId"] = ExpressionConverter.ConvertO(__workflow_bodygroupId);
                bodypropCount++;
                body["planId"] = ExpressionConverter.ConvertO(__workflow_bodyplanId);
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (__workflow_bodybucketId != null)
                {
                    body["bucketId"] = ExpressionConverter.ConvertO(__workflow_bodybucketId);
                    bodypropCount++;
                }

                if (__workflow_bodystartDateTime != null)
                {
                    body["startDateTime"] = ExpressionConverter.ConvertO(__workflow_bodystartDateTime);
                    bodypropCount++;
                }

                if (__workflow_bodydueDateTime != null)
                {
                    body["dueDateTime"] = ExpressionConverter.ConvertO(__workflow_bodydueDateTime);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedUserIds != null)
                {
                    body["assignments"] = ExpressionConverter.ConvertO(__workflow_bodyassignedUserIds);
                    bodypropCount++;
                }

                var appliedCategoriesObject = new JObject();
                var appliedCategoriesObjectpropCount = 0;
                if (__workflow_bodyappliedCategoriespink != null)
                {
                    appliedCategoriesObject["category1"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriespink);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesred != null)
                {
                    appliedCategoriesObject["category2"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesred);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesyellow != null)
                {
                    appliedCategoriesObject["category3"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesyellow);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesgreen != null)
                {
                    appliedCategoriesObject["category4"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesgreen);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesblue != null)
                {
                    appliedCategoriesObject["category5"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesblue);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriespurple != null)
                {
                    appliedCategoriesObject["category6"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriespurple);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesbronze != null)
                {
                    appliedCategoriesObject["category7"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesbronze);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategorieslime != null)
                {
                    appliedCategoriesObject["category8"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategorieslime);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesaqua != null)
                {
                    appliedCategoriesObject["category9"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesaqua);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesgray != null)
                {
                    appliedCategoriesObject["category10"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesgray);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriessilver != null)
                {
                    appliedCategoriesObject["category11"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriessilver);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesbrown != null)
                {
                    appliedCategoriesObject["category12"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesbrown);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriescranberry != null)
                {
                    appliedCategoriesObject["category13"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriescranberry);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesorange != null)
                {
                    appliedCategoriesObject["category14"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesorange);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriespeach != null)
                {
                    appliedCategoriesObject["category15"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriespeach);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesmarigold != null)
                {
                    appliedCategoriesObject["category16"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesmarigold);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategorieslightGreen != null)
                {
                    appliedCategoriesObject["category17"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategorieslightGreen);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesdarkGreen != null)
                {
                    appliedCategoriesObject["category18"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesdarkGreen);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesteal != null)
                {
                    appliedCategoriesObject["category19"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesteal);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategorieslightBlue != null)
                {
                    appliedCategoriesObject["category20"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategorieslightBlue);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesdarkBlue != null)
                {
                    appliedCategoriesObject["category21"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesdarkBlue);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategorieslavender != null)
                {
                    appliedCategoriesObject["category22"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategorieslavender);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesplum != null)
                {
                    appliedCategoriesObject["category23"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesplum);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategorieslightGray != null)
                {
                    appliedCategoriesObject["category24"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategorieslightGray);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesdarkGray != null)
                {
                    appliedCategoriesObject["category25"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesdarkGray);
                    appliedCategoriesObjectpropCount++;
                }

                if (appliedCategoriesObjectpropCount > 0)
                {
                    body["appliedCategories"] = appliedCategoriesObject;
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetTaskResponseV3>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskResponseV2> GetTask(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetTaskResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/planner/tasks/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTaskResponseV2>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskDetailsResponse> GetTaskDetails(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetTaskDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/planner/tasks/{0}/details", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTaskDetailsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<ListBucketsResponse> ListBuckets(Expression<Func<string>> groupId, Expression<Func<string>> id)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ListBucketsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/v1.0/planner/plans/{0}/buckets", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                return new ApiConnectionAction<ListBucketsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<ListTasksResponseV2> ListMyTasks()
        {
            var apiCallPath = "/v1.0/me/planner/tasks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListTasksResponseV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<ListTasksResponseV2> ListTasks(Expression<Func<string>> groupId, Expression<Func<string>> id)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ListTasksResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/v1.0/planner/plans/{0}/tasks", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                return new ApiConnectionAction<ListTasksResponseV2>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskResponseV2> UpdateTask(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydueDateTime = null, Expression<Func<string>> bodystartDateTime = null, Expression<Func<int>> bodypercentComplete = null, Expression<Func<string>> bodybucketId = null, Expression<Func<bool>> bodyappliedCategoriespink = null, Expression<Func<bool>> bodyappliedCategoriesred = null, Expression<Func<bool>> bodyappliedCategoriesyellow = null, Expression<Func<bool>> bodyappliedCategoriesgreen = null, Expression<Func<bool>> bodyappliedCategoriesblue = null, Expression<Func<bool>> bodyappliedCategoriespurple = null, Expression<Func<bool>> bodyappliedCategoriesbronze = null, Expression<Func<bool>> bodyappliedCategorieslime = null, Expression<Func<bool>> bodyappliedCategoriesaqua = null, Expression<Func<bool>> bodyappliedCategoriesgray = null, Expression<Func<bool>> bodyappliedCategoriessilver = null, Expression<Func<bool>> bodyappliedCategoriesbrown = null, Expression<Func<bool>> bodyappliedCategoriescranberry = null, Expression<Func<bool>> bodyappliedCategoriesorange = null, Expression<Func<bool>> bodyappliedCategoriespeach = null, Expression<Func<bool>> bodyappliedCategoriesmarigold = null, Expression<Func<bool>> bodyappliedCategorieslightGreen = null, Expression<Func<bool>> bodyappliedCategoriesdarkGreen = null, Expression<Func<bool>> bodyappliedCategoriesteal = null, Expression<Func<bool>> bodyappliedCategorieslightBlue = null, Expression<Func<bool>> bodyappliedCategoriesdarkBlue = null, Expression<Func<bool>> bodyappliedCategorieslavender = null, Expression<Func<bool>> bodyappliedCategoriesplum = null, Expression<Func<bool>> bodyappliedCategorieslightGray = null, Expression<Func<bool>> bodyappliedCategoriesdarkGray = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodydueDateTime = WorkflowExpression.Compile(bodydueDateTime, nameof(bodydueDateTime), required: false);
            var __workflow_bodystartDateTime = WorkflowExpression.Compile(bodystartDateTime, nameof(bodystartDateTime), required: false);
            var __workflow_bodypercentComplete = WorkflowExpression.Compile(bodypercentComplete, nameof(bodypercentComplete), required: false);
            var __workflow_bodybucketId = WorkflowExpression.Compile(bodybucketId, nameof(bodybucketId), required: false);
            var __workflow_bodyappliedCategoriespink = WorkflowExpression.Compile(bodyappliedCategoriespink, nameof(bodyappliedCategoriespink), required: false);
            var __workflow_bodyappliedCategoriesred = WorkflowExpression.Compile(bodyappliedCategoriesred, nameof(bodyappliedCategoriesred), required: false);
            var __workflow_bodyappliedCategoriesyellow = WorkflowExpression.Compile(bodyappliedCategoriesyellow, nameof(bodyappliedCategoriesyellow), required: false);
            var __workflow_bodyappliedCategoriesgreen = WorkflowExpression.Compile(bodyappliedCategoriesgreen, nameof(bodyappliedCategoriesgreen), required: false);
            var __workflow_bodyappliedCategoriesblue = WorkflowExpression.Compile(bodyappliedCategoriesblue, nameof(bodyappliedCategoriesblue), required: false);
            var __workflow_bodyappliedCategoriespurple = WorkflowExpression.Compile(bodyappliedCategoriespurple, nameof(bodyappliedCategoriespurple), required: false);
            var __workflow_bodyappliedCategoriesbronze = WorkflowExpression.Compile(bodyappliedCategoriesbronze, nameof(bodyappliedCategoriesbronze), required: false);
            var __workflow_bodyappliedCategorieslime = WorkflowExpression.Compile(bodyappliedCategorieslime, nameof(bodyappliedCategorieslime), required: false);
            var __workflow_bodyappliedCategoriesaqua = WorkflowExpression.Compile(bodyappliedCategoriesaqua, nameof(bodyappliedCategoriesaqua), required: false);
            var __workflow_bodyappliedCategoriesgray = WorkflowExpression.Compile(bodyappliedCategoriesgray, nameof(bodyappliedCategoriesgray), required: false);
            var __workflow_bodyappliedCategoriessilver = WorkflowExpression.Compile(bodyappliedCategoriessilver, nameof(bodyappliedCategoriessilver), required: false);
            var __workflow_bodyappliedCategoriesbrown = WorkflowExpression.Compile(bodyappliedCategoriesbrown, nameof(bodyappliedCategoriesbrown), required: false);
            var __workflow_bodyappliedCategoriescranberry = WorkflowExpression.Compile(bodyappliedCategoriescranberry, nameof(bodyappliedCategoriescranberry), required: false);
            var __workflow_bodyappliedCategoriesorange = WorkflowExpression.Compile(bodyappliedCategoriesorange, nameof(bodyappliedCategoriesorange), required: false);
            var __workflow_bodyappliedCategoriespeach = WorkflowExpression.Compile(bodyappliedCategoriespeach, nameof(bodyappliedCategoriespeach), required: false);
            var __workflow_bodyappliedCategoriesmarigold = WorkflowExpression.Compile(bodyappliedCategoriesmarigold, nameof(bodyappliedCategoriesmarigold), required: false);
            var __workflow_bodyappliedCategorieslightGreen = WorkflowExpression.Compile(bodyappliedCategorieslightGreen, nameof(bodyappliedCategorieslightGreen), required: false);
            var __workflow_bodyappliedCategoriesdarkGreen = WorkflowExpression.Compile(bodyappliedCategoriesdarkGreen, nameof(bodyappliedCategoriesdarkGreen), required: false);
            var __workflow_bodyappliedCategoriesteal = WorkflowExpression.Compile(bodyappliedCategoriesteal, nameof(bodyappliedCategoriesteal), required: false);
            var __workflow_bodyappliedCategorieslightBlue = WorkflowExpression.Compile(bodyappliedCategorieslightBlue, nameof(bodyappliedCategorieslightBlue), required: false);
            var __workflow_bodyappliedCategoriesdarkBlue = WorkflowExpression.Compile(bodyappliedCategoriesdarkBlue, nameof(bodyappliedCategoriesdarkBlue), required: false);
            var __workflow_bodyappliedCategorieslavender = WorkflowExpression.Compile(bodyappliedCategorieslavender, nameof(bodyappliedCategorieslavender), required: false);
            var __workflow_bodyappliedCategoriesplum = WorkflowExpression.Compile(bodyappliedCategoriesplum, nameof(bodyappliedCategoriesplum), required: false);
            var __workflow_bodyappliedCategorieslightGray = WorkflowExpression.Compile(bodyappliedCategorieslightGray, nameof(bodyappliedCategorieslightGray), required: false);
            var __workflow_bodyappliedCategoriesdarkGray = WorkflowExpression.Compile(bodyappliedCategoriesdarkGray, nameof(bodyappliedCategoriesdarkGray), required: false);
            return new DeferredBodyAction<GetTaskResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/v1.0/planner/tasks/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString(" return=representation");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodydueDateTime != null)
                {
                    body["dueDateTime"] = ExpressionConverter.ConvertO(__workflow_bodydueDateTime);
                    bodypropCount++;
                }

                if (__workflow_bodystartDateTime != null)
                {
                    body["startDateTime"] = ExpressionConverter.ConvertO(__workflow_bodystartDateTime);
                    bodypropCount++;
                }

                if (__workflow_bodypercentComplete != null)
                {
                    body["percentComplete"] = ExpressionConverter.ConvertO(__workflow_bodypercentComplete);
                    bodypropCount++;
                }

                if (__workflow_bodybucketId != null)
                {
                    body["bucketId"] = ExpressionConverter.ConvertO(__workflow_bodybucketId);
                    bodypropCount++;
                }

                var appliedCategoriesObject = new JObject();
                var appliedCategoriesObjectpropCount = 0;
                if (__workflow_bodyappliedCategoriespink != null)
                {
                    appliedCategoriesObject["category1"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriespink);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesred != null)
                {
                    appliedCategoriesObject["category2"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesred);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesyellow != null)
                {
                    appliedCategoriesObject["category3"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesyellow);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesgreen != null)
                {
                    appliedCategoriesObject["category4"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesgreen);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesblue != null)
                {
                    appliedCategoriesObject["category5"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesblue);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriespurple != null)
                {
                    appliedCategoriesObject["category6"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriespurple);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesbronze != null)
                {
                    appliedCategoriesObject["category7"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesbronze);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategorieslime != null)
                {
                    appliedCategoriesObject["category8"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategorieslime);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesaqua != null)
                {
                    appliedCategoriesObject["category9"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesaqua);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesgray != null)
                {
                    appliedCategoriesObject["category10"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesgray);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriessilver != null)
                {
                    appliedCategoriesObject["category11"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriessilver);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesbrown != null)
                {
                    appliedCategoriesObject["category12"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesbrown);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriescranberry != null)
                {
                    appliedCategoriesObject["category13"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriescranberry);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesorange != null)
                {
                    appliedCategoriesObject["category14"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesorange);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriespeach != null)
                {
                    appliedCategoriesObject["category15"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriespeach);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesmarigold != null)
                {
                    appliedCategoriesObject["category16"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesmarigold);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategorieslightGreen != null)
                {
                    appliedCategoriesObject["category17"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategorieslightGreen);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesdarkGreen != null)
                {
                    appliedCategoriesObject["category18"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesdarkGreen);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesteal != null)
                {
                    appliedCategoriesObject["category19"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesteal);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategorieslightBlue != null)
                {
                    appliedCategoriesObject["category20"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategorieslightBlue);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesdarkBlue != null)
                {
                    appliedCategoriesObject["category21"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesdarkBlue);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategorieslavender != null)
                {
                    appliedCategoriesObject["category22"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategorieslavender);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesplum != null)
                {
                    appliedCategoriesObject["category23"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesplum);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategorieslightGray != null)
                {
                    appliedCategoriesObject["category24"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategorieslightGray);
                    appliedCategoriesObjectpropCount++;
                }

                if (__workflow_bodyappliedCategoriesdarkGray != null)
                {
                    appliedCategoriesObject["category25"] = ExpressionConverter.ConvertO(__workflow_bodyappliedCategoriesdarkGray);
                    appliedCategoriesObjectpropCount++;
                }

                if (appliedCategoriesObjectpropCount > 0)
                {
                    body["appliedCategories"] = appliedCategoriesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetTaskResponseV2>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskDetailsResponse> UpdateTaskDetails(Expression<Func<string>> id, Expression<Func<string>> bodydescription = null, Expression<Func<bodyreferencesInputItem[]>> bodyreferences = null, Expression<Func<bodychecklistInputItem[]>> bodychecklist = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyreferences = WorkflowExpression.Compile(bodyreferences, nameof(bodyreferences), required: false);
            var __workflow_bodychecklist = WorkflowExpression.Compile(bodychecklist, nameof(bodychecklist), required: false);
            return new DeferredBodyAction<GetTaskDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/planner/tasks/{0}/details", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString(" return=representation");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyreferences != null)
                {
                    body["references"] = ExpressionConverter.ConvertO(__workflow_bodyreferences);
                    bodypropCount++;
                }

                if (__workflow_bodychecklist != null)
                {
                    body["checklist"] = ExpressionConverter.ConvertO(__workflow_bodychecklist);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetTaskDetailsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class PlannerTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListTasksResponseV2> OnCompleteTask(Expression<Func<string>> groupId, Expression<Func<string>> id, FlowRecurrence recurrence = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyTrigger<ListTasksResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/v1.0/planner/oncompletetask_trigger/plans/{0}/tasks", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                return new ApiConnectionTrigger<ListTasksResponseV2>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<ListTasksResponseV2> OnNewTask(Expression<Func<string>> groupId, Expression<Func<string>> id, FlowRecurrence recurrence = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyTrigger<ListTasksResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/v1.0/planner/onnewtask_trigger/plans/{0}/tasks", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(__workflow_groupId);
                return new ApiConnectionTrigger<ListTasksResponseV2>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<ListTasksResponseV2> OnTaskAssignedToMe(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1.0/me/planner/ontaskassignedtome_trigger/tasks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListTasksResponseV2>(callPayload, recurrence: recurrence);
        }
    }

    public class GetTaskResponseV2
    {
        [JsonProperty("createdBy")]
        public GetTaskResponseV2CreatedByType CreatedBy { get; set; }

        [JsonProperty("planId")]
        public string PlanId { get; set; }

        [JsonProperty("bucketId")]
        public string BucketId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("percentComplete")]
        public int PercentComplete { get; set; }

        [JsonProperty("startDateTime")]
        public string StartDateTime { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("dueDateTime")]
        public string DueDateTime { get; set; }

        [JsonProperty("hasDescription")]
        public bool HasDescription { get; set; }

        [JsonProperty("completedDateTime")]
        public string CompletedDateTime { get; set; }

        [JsonProperty("referenceCount")]
        public int ReferenceCount { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("appliedCategories")]
        public AppliedCategories AppliedCategories { get; set; }

        [JsonProperty("_assignments")]
        public GetTaskResponseV2AssignmentsTypeItem[] Assignments { get; set; }
    }

    public class GetTaskResponseV2CreatedByType
    {
        [JsonProperty("user")]
        public GetTaskResponseV2CreatedByTypeUserType User { get; set; }
    }

    public class GetTaskResponseV2CreatedByTypeUserType
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AppliedCategories
    {
        [JsonProperty("category1")]
        public bool Pink { get; set; }

        [JsonProperty("category2")]
        public bool Red { get; set; }

        [JsonProperty("category3")]
        public bool Yellow { get; set; }

        [JsonProperty("category4")]
        public bool Green { get; set; }

        [JsonProperty("category5")]
        public bool Blue { get; set; }

        [JsonProperty("category6")]
        public bool Purple { get; set; }

        [JsonProperty("category7")]
        public bool Bronze { get; set; }

        [JsonProperty("category8")]
        public bool Lime { get; set; }

        [JsonProperty("category9")]
        public bool Aqua { get; set; }

        [JsonProperty("category10")]
        public bool Gray { get; set; }

        [JsonProperty("category11")]
        public bool Silver { get; set; }

        [JsonProperty("category12")]
        public bool Brown { get; set; }

        [JsonProperty("category13")]
        public bool Cranberry { get; set; }

        [JsonProperty("category14")]
        public bool Orange { get; set; }

        [JsonProperty("category15")]
        public bool Peach { get; set; }

        [JsonProperty("category16")]
        public bool Marigold { get; set; }

        [JsonProperty("category17")]
        public bool LightGreen { get; set; }

        [JsonProperty("category18")]
        public bool DarkGreen { get; set; }

        [JsonProperty("category19")]
        public bool Teal { get; set; }

        [JsonProperty("category20")]
        public bool LightBlue { get; set; }

        [JsonProperty("category21")]
        public bool DarkBlue { get; set; }

        [JsonProperty("category22")]
        public bool Lavender { get; set; }

        [JsonProperty("category23")]
        public bool Plum { get; set; }

        [JsonProperty("category24")]
        public bool LightGray { get; set; }

        [JsonProperty("category25")]
        public bool DarkGray { get; set; }
    }

    public class GetTaskResponseV2AssignmentsTypeItem
    {
        [JsonProperty("userId")]
        public string AssignedToUserId { get; set; }

        [JsonProperty("value")]
        public GetTaskResponseV2AssignmentsTypeItemValueType Value { get; set; }
    }

    public class GetTaskResponseV2AssignmentsTypeItemValueType
    {
        [JsonProperty("assignedBy")]
        public GetTaskResponseV2AssignmentsTypeItemValueTypeAssignedByType AssignedBy { get; set; }

        [JsonProperty("assignedDateTime")]
        public string AssignedDateTime { get; set; }

        [JsonProperty("orderHint")]
        public string OrderHint { get; set; }
    }

    public class GetTaskResponseV2AssignmentsTypeItemValueTypeAssignedByType
    {
        [JsonProperty("user")]
        public GetTaskResponseV2AssignmentsTypeItemValueTypeAssignedByTypeUserType User { get; set; }
    }

    public class GetTaskResponseV2AssignmentsTypeItemValueTypeAssignedByTypeUserType
    {
        [JsonProperty("id")]
        public string AssignedByUserId { get; set; }
    }

    public class ListMyPlansResponse
    {
        [JsonProperty("value")]
        public ListMyPlansResponseValueTypeItem[] Value { get; set; }
    }

    public class ListMyPlansResponseValueTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateBucketResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("planId")]
        public string PlanId { get; set; }

        [JsonProperty("orderHint")]
        public string OrderHint { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetTaskResponseV3
    {
        [JsonProperty("createdBy")]
        public GetTaskResponseV3CreatedByType CreatedBy { get; set; }

        [JsonProperty("planId")]
        public string PlanId { get; set; }

        [JsonProperty("bucketId")]
        public string BucketId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("percentComplete")]
        public int PercentComplete { get; set; }

        [JsonProperty("startDateTime")]
        public string StartDateTime { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("dueDateTime")]
        public string DueDateTime { get; set; }

        [JsonProperty("hasDescription")]
        public bool HasDescription { get; set; }

        [JsonProperty("completedDateTime")]
        public string CompletedDateTime { get; set; }

        [JsonProperty("referenceCount")]
        public int ReferenceCount { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("appliedCategories")]
        public AppliedCategories AppliedCategories { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("_assignments")]
        public GetTaskResponseV3AssignmentsTypeItem[] Assignments { get; set; }
    }

    public class GetTaskResponseV3CreatedByType
    {
        [JsonProperty("user")]
        public GetTaskResponseV3CreatedByTypeUserType User { get; set; }
    }

    public class GetTaskResponseV3CreatedByTypeUserType
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetTaskResponseV3AssignmentsTypeItem
    {
        [JsonProperty("userId")]
        public string AssignedToUserId { get; set; }

        [JsonProperty("value")]
        public GetTaskResponseV3AssignmentsTypeItemValueType Value { get; set; }
    }

    public class GetTaskResponseV3AssignmentsTypeItemValueType
    {
        [JsonProperty("assignedBy")]
        public GetTaskResponseV3AssignmentsTypeItemValueTypeAssignedByType AssignedBy { get; set; }

        [JsonProperty("assignedDateTime")]
        public string AssignedDateTime { get; set; }

        [JsonProperty("orderHint")]
        public string OrderHint { get; set; }
    }

    public class GetTaskResponseV3AssignmentsTypeItemValueTypeAssignedByType
    {
        [JsonProperty("user")]
        public GetTaskResponseV3AssignmentsTypeItemValueTypeAssignedByTypeUserType User { get; set; }
    }

    public class GetTaskResponseV3AssignmentsTypeItemValueTypeAssignedByTypeUserType
    {
        [JsonProperty("id")]
        public string AssignedByUserId { get; set; }
    }

    public class GetTaskDetailsResponse
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("references")]
        public GetTaskDetailsResponseReferencesTypeItem[] References { get; set; }

        [JsonProperty("checklist")]
        public GetTaskDetailsResponseChecklistTypeItem[] Checklist { get; set; }
    }

    public class GetTaskDetailsResponseReferencesTypeItem
    {
        [JsonProperty("resourceLink")]
        public string ResourceLink { get; set; }

        [JsonProperty("value")]
        public GetTaskDetailsResponseReferencesTypeItemValueType Value { get; set; }
    }

    public class GetTaskDetailsResponseReferencesTypeItemValueType
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("type")]
        public JToken TypeOfTheReference { get; set; }
    }

    public class GetTaskDetailsResponseChecklistTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public GetTaskDetailsResponseChecklistTypeItemValueType Value { get; set; }
    }

    public class GetTaskDetailsResponseChecklistTypeItemValueType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("isChecked")]
        public bool IsChecked { get; set; }
    }

    public class ListBucketsResponse
    {
        [JsonProperty("value")]
        public ListBucketsResponseValueTypeItem[] Value { get; set; }
    }

    public class ListBucketsResponseValueTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("planId")]
        public string PlanId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListTasksResponseV2
    {
        [JsonProperty("value")]
        public GetTaskResponseV2[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public class bodyreferencesInputItem
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("resourceLink")]
        public string ResourceLink { get; set; }

        [JsonProperty("type")]
        public JToken TypeOfTheReference { get; set; }
    }

    public class bodychecklistInputItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("isChecked")]
        public bool IsChecked { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Planner;

    public partial class WorkflowManagedActions
    {
        public PlannerActions Planner(string connectionId) => new PlannerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PlannerTriggers Planner(string connectionId) => new PlannerTriggers(connectionId);
    }
}
