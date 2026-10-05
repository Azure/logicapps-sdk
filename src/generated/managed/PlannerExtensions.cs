//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Planner
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PlannerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteTask))]
        public IWorkflowAction DeleteTask([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteTask(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/planner/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        [WorkflowExpressionFactory(nameof(__BuildUnassignUsers))]
        public IBodyWorkflowAction<GetTaskResponseV2> UnassignUsers([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyremoveAssignedUsers)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTaskResponseV2> __BuildUnassignUsers(WorkflowValue<string> id, WorkflowValue<string> bodyremoveAssignedUsers)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(bodyremoveAssignedUsers, nameof(bodyremoveAssignedUsers), required: true);
            return new DeferredBodyAction<GetTaskResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/planner/tasks/{0}/unassignusers", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString(" return=representation");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["assignments"] = ExpressionConverter.ConvertO(bodyremoveAssignedUsers);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetTaskResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        [WorkflowExpressionFactory(nameof(__BuildAssignUsers))]
        public IBodyWorkflowAction<GetTaskResponseV2> AssignUsers([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyassignedUserIds)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTaskResponseV2> __BuildAssignUsers(WorkflowValue<string> id, WorkflowValue<string> bodyassignedUserIds)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(bodyassignedUserIds, nameof(bodyassignedUserIds), required: true);
            return new DeferredBodyAction<GetTaskResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/planner/tasks/{0}/assignusers", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString(" return=representation");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["assignments"] = ExpressionConverter.ConvertO(bodyassignedUserIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetTaskResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        [WorkflowExpressionFactory(nameof(__BuildListGroupPlans))]
        public IBodyWorkflowAction<ListMyPlansResponse> ListGroupPlans([WorkflowExpression] Func<string> groupId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListMyPlansResponse> __BuildListGroupPlans(WorkflowValue<string> groupId)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            return new DeferredBodyAction<ListMyPlansResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/planner/plans", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListMyPlansResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        [WorkflowExpressionFactory(nameof(__BuildCreateBucket))]
        public IBodyWorkflowAction<CreateBucketResponse> CreateBucket([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodygroupId, [WorkflowExpression] Func<string> bodyplanId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateBucketResponse> __BuildCreateBucket(WorkflowValue<string> bodyname, WorkflowValue<string> bodygroupId, WorkflowValue<string> bodyplanId)
        {
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowValue.Validate(bodygroupId, nameof(bodygroupId), required: true);
            WorkflowValue.Validate(bodyplanId, nameof(bodyplanId), required: true);
            return new DeferredBodyAction<CreateBucketResponse>(() =>
            {
                var apiCallPath = "/v2/v1.0/planner/buckets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
                body["groupId"] = ExpressionConverter.ConvertO(bodygroupId);
                bodypropCount++;
                body["planId"] = ExpressionConverter.ConvertO(bodyplanId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateBucketResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTask))]
        public IBodyWorkflowAction<GetTaskResponseV3> CreateTask([WorkflowExpression] Func<string> bodygroupId, [WorkflowExpression] Func<string> bodyplanId, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodybucketId = null, [WorkflowExpression] Func<string> bodystartDateTime = null, [WorkflowExpression] Func<string> bodydueDateTime = null, [WorkflowExpression] Func<string> bodyassignedUserIds = null, [WorkflowExpression] Func<bool> bodyappliedCategoriespink = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesred = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesyellow = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesgreen = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesblue = null, [WorkflowExpression] Func<bool> bodyappliedCategoriespurple = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesbronze = null, [WorkflowExpression] Func<bool> bodyappliedCategorieslime = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesaqua = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesgray = null, [WorkflowExpression] Func<bool> bodyappliedCategoriessilver = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesbrown = null, [WorkflowExpression] Func<bool> bodyappliedCategoriescranberry = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesorange = null, [WorkflowExpression] Func<bool> bodyappliedCategoriespeach = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesmarigold = null, [WorkflowExpression] Func<bool> bodyappliedCategorieslightGreen = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesdarkGreen = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesteal = null, [WorkflowExpression] Func<bool> bodyappliedCategorieslightBlue = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesdarkBlue = null, [WorkflowExpression] Func<bool> bodyappliedCategorieslavender = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesplum = null, [WorkflowExpression] Func<bool> bodyappliedCategorieslightGray = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesdarkGray = null, [WorkflowExpression] Func<int> bodypriority = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTaskResponseV3> __BuildCreateTask(WorkflowValue<string> bodygroupId, WorkflowValue<string> bodyplanId, WorkflowValue<string> bodytitle, WorkflowValue<string> bodybucketId = null, WorkflowValue<string> bodystartDateTime = null, WorkflowValue<string> bodydueDateTime = null, WorkflowValue<string> bodyassignedUserIds = null, WorkflowValue<bool> bodyappliedCategoriespink = null, WorkflowValue<bool> bodyappliedCategoriesred = null, WorkflowValue<bool> bodyappliedCategoriesyellow = null, WorkflowValue<bool> bodyappliedCategoriesgreen = null, WorkflowValue<bool> bodyappliedCategoriesblue = null, WorkflowValue<bool> bodyappliedCategoriespurple = null, WorkflowValue<bool> bodyappliedCategoriesbronze = null, WorkflowValue<bool> bodyappliedCategorieslime = null, WorkflowValue<bool> bodyappliedCategoriesaqua = null, WorkflowValue<bool> bodyappliedCategoriesgray = null, WorkflowValue<bool> bodyappliedCategoriessilver = null, WorkflowValue<bool> bodyappliedCategoriesbrown = null, WorkflowValue<bool> bodyappliedCategoriescranberry = null, WorkflowValue<bool> bodyappliedCategoriesorange = null, WorkflowValue<bool> bodyappliedCategoriespeach = null, WorkflowValue<bool> bodyappliedCategoriesmarigold = null, WorkflowValue<bool> bodyappliedCategorieslightGreen = null, WorkflowValue<bool> bodyappliedCategoriesdarkGreen = null, WorkflowValue<bool> bodyappliedCategoriesteal = null, WorkflowValue<bool> bodyappliedCategorieslightBlue = null, WorkflowValue<bool> bodyappliedCategoriesdarkBlue = null, WorkflowValue<bool> bodyappliedCategorieslavender = null, WorkflowValue<bool> bodyappliedCategoriesplum = null, WorkflowValue<bool> bodyappliedCategorieslightGray = null, WorkflowValue<bool> bodyappliedCategoriesdarkGray = null, WorkflowValue<int> bodypriority = null)
        {
            WorkflowValue.Validate(bodygroupId, nameof(bodygroupId), required: true);
            WorkflowValue.Validate(bodyplanId, nameof(bodyplanId), required: true);
            WorkflowValue.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowValue.Validate(bodybucketId, nameof(bodybucketId), required: false);
            WorkflowValue.Validate(bodystartDateTime, nameof(bodystartDateTime), required: false);
            WorkflowValue.Validate(bodydueDateTime, nameof(bodydueDateTime), required: false);
            WorkflowValue.Validate(bodyassignedUserIds, nameof(bodyassignedUserIds), required: false);
            WorkflowValue.Validate(bodyappliedCategoriespink, nameof(bodyappliedCategoriespink), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesred, nameof(bodyappliedCategoriesred), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesyellow, nameof(bodyappliedCategoriesyellow), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesgreen, nameof(bodyappliedCategoriesgreen), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesblue, nameof(bodyappliedCategoriesblue), required: false);
            WorkflowValue.Validate(bodyappliedCategoriespurple, nameof(bodyappliedCategoriespurple), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesbronze, nameof(bodyappliedCategoriesbronze), required: false);
            WorkflowValue.Validate(bodyappliedCategorieslime, nameof(bodyappliedCategorieslime), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesaqua, nameof(bodyappliedCategoriesaqua), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesgray, nameof(bodyappliedCategoriesgray), required: false);
            WorkflowValue.Validate(bodyappliedCategoriessilver, nameof(bodyappliedCategoriessilver), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesbrown, nameof(bodyappliedCategoriesbrown), required: false);
            WorkflowValue.Validate(bodyappliedCategoriescranberry, nameof(bodyappliedCategoriescranberry), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesorange, nameof(bodyappliedCategoriesorange), required: false);
            WorkflowValue.Validate(bodyappliedCategoriespeach, nameof(bodyappliedCategoriespeach), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesmarigold, nameof(bodyappliedCategoriesmarigold), required: false);
            WorkflowValue.Validate(bodyappliedCategorieslightGreen, nameof(bodyappliedCategorieslightGreen), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesdarkGreen, nameof(bodyappliedCategoriesdarkGreen), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesteal, nameof(bodyappliedCategoriesteal), required: false);
            WorkflowValue.Validate(bodyappliedCategorieslightBlue, nameof(bodyappliedCategorieslightBlue), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesdarkBlue, nameof(bodyappliedCategoriesdarkBlue), required: false);
            WorkflowValue.Validate(bodyappliedCategorieslavender, nameof(bodyappliedCategorieslavender), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesplum, nameof(bodyappliedCategoriesplum), required: false);
            WorkflowValue.Validate(bodyappliedCategorieslightGray, nameof(bodyappliedCategorieslightGray), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesdarkGray, nameof(bodyappliedCategoriesdarkGray), required: false);
            WorkflowValue.Validate(bodypriority, nameof(bodypriority), required: false);
            return new DeferredBodyAction<GetTaskResponseV3>(() =>
            {
                var apiCallPath = "/v2/beta/planner/tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString(" return=representation");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["groupId"] = ExpressionConverter.ConvertO(bodygroupId);
                bodypropCount++;
                body["planId"] = ExpressionConverter.ConvertO(bodyplanId);
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodybucketId != null)
                {
                    body["bucketId"] = ExpressionConverter.ConvertO(bodybucketId);
                    bodypropCount++;
                }

                if (bodystartDateTime != null)
                {
                    body["startDateTime"] = ExpressionConverter.ConvertO(bodystartDateTime);
                    bodypropCount++;
                }

                if (bodydueDateTime != null)
                {
                    body["dueDateTime"] = ExpressionConverter.ConvertO(bodydueDateTime);
                    bodypropCount++;
                }

                if (bodyassignedUserIds != null)
                {
                    body["assignments"] = ExpressionConverter.ConvertO(bodyassignedUserIds);
                    bodypropCount++;
                }

                var appliedCategoriesObject = new JObject();
                var appliedCategoriesObjectpropCount = 0;
                if (bodyappliedCategoriespink != null)
                {
                    appliedCategoriesObject["category1"] = ExpressionConverter.ConvertO(bodyappliedCategoriespink);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesred != null)
                {
                    appliedCategoriesObject["category2"] = ExpressionConverter.ConvertO(bodyappliedCategoriesred);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesyellow != null)
                {
                    appliedCategoriesObject["category3"] = ExpressionConverter.ConvertO(bodyappliedCategoriesyellow);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesgreen != null)
                {
                    appliedCategoriesObject["category4"] = ExpressionConverter.ConvertO(bodyappliedCategoriesgreen);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesblue != null)
                {
                    appliedCategoriesObject["category5"] = ExpressionConverter.ConvertO(bodyappliedCategoriesblue);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriespurple != null)
                {
                    appliedCategoriesObject["category6"] = ExpressionConverter.ConvertO(bodyappliedCategoriespurple);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesbronze != null)
                {
                    appliedCategoriesObject["category7"] = ExpressionConverter.ConvertO(bodyappliedCategoriesbronze);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategorieslime != null)
                {
                    appliedCategoriesObject["category8"] = ExpressionConverter.ConvertO(bodyappliedCategorieslime);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesaqua != null)
                {
                    appliedCategoriesObject["category9"] = ExpressionConverter.ConvertO(bodyappliedCategoriesaqua);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesgray != null)
                {
                    appliedCategoriesObject["category10"] = ExpressionConverter.ConvertO(bodyappliedCategoriesgray);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriessilver != null)
                {
                    appliedCategoriesObject["category11"] = ExpressionConverter.ConvertO(bodyappliedCategoriessilver);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesbrown != null)
                {
                    appliedCategoriesObject["category12"] = ExpressionConverter.ConvertO(bodyappliedCategoriesbrown);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriescranberry != null)
                {
                    appliedCategoriesObject["category13"] = ExpressionConverter.ConvertO(bodyappliedCategoriescranberry);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesorange != null)
                {
                    appliedCategoriesObject["category14"] = ExpressionConverter.ConvertO(bodyappliedCategoriesorange);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriespeach != null)
                {
                    appliedCategoriesObject["category15"] = ExpressionConverter.ConvertO(bodyappliedCategoriespeach);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesmarigold != null)
                {
                    appliedCategoriesObject["category16"] = ExpressionConverter.ConvertO(bodyappliedCategoriesmarigold);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategorieslightGreen != null)
                {
                    appliedCategoriesObject["category17"] = ExpressionConverter.ConvertO(bodyappliedCategorieslightGreen);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesdarkGreen != null)
                {
                    appliedCategoriesObject["category18"] = ExpressionConverter.ConvertO(bodyappliedCategoriesdarkGreen);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesteal != null)
                {
                    appliedCategoriesObject["category19"] = ExpressionConverter.ConvertO(bodyappliedCategoriesteal);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategorieslightBlue != null)
                {
                    appliedCategoriesObject["category20"] = ExpressionConverter.ConvertO(bodyappliedCategorieslightBlue);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesdarkBlue != null)
                {
                    appliedCategoriesObject["category21"] = ExpressionConverter.ConvertO(bodyappliedCategoriesdarkBlue);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategorieslavender != null)
                {
                    appliedCategoriesObject["category22"] = ExpressionConverter.ConvertO(bodyappliedCategorieslavender);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesplum != null)
                {
                    appliedCategoriesObject["category23"] = ExpressionConverter.ConvertO(bodyappliedCategoriesplum);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategorieslightGray != null)
                {
                    appliedCategoriesObject["category24"] = ExpressionConverter.ConvertO(bodyappliedCategorieslightGray);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesdarkGray != null)
                {
                    appliedCategoriesObject["category25"] = ExpressionConverter.ConvertO(bodyappliedCategoriesdarkGray);
                    appliedCategoriesObjectpropCount++;
                }

                if (appliedCategoriesObjectpropCount > 0)
                {
                    body["appliedCategories"] = appliedCategoriesObject;
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetTaskResponseV3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        [WorkflowExpressionFactory(nameof(__BuildGetTask))]
        public IBodyWorkflowAction<GetTaskResponseV2> GetTask([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTaskResponseV2> __BuildGetTask(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GetTaskResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/planner/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTaskResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        [WorkflowExpressionFactory(nameof(__BuildGetTaskDetails))]
        public IBodyWorkflowAction<GetTaskDetailsResponse> GetTaskDetails([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTaskDetailsResponse> __BuildGetTaskDetails(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GetTaskDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/planner/tasks/{0}/details", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTaskDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        [WorkflowExpressionFactory(nameof(__BuildListBuckets))]
        public IBodyWorkflowAction<ListBucketsResponse> ListBuckets([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListBucketsResponse> __BuildListBuckets(WorkflowValue<string> groupId, WorkflowValue<string> id)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ListBucketsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/v1.0/planner/plans/{0}/buckets", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(groupId);
                return new ApiConnectionAction<ListBucketsResponse>(callPayload);
            });
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
        [WorkflowExpressionFactory(nameof(__BuildListTasks))]
        public IBodyWorkflowAction<ListTasksResponseV2> ListTasks([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListTasksResponseV2> __BuildListTasks(WorkflowValue<string> groupId, WorkflowValue<string> id)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ListTasksResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/v1.0/planner/plans/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(groupId);
                return new ApiConnectionAction<ListTasksResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateTask))]
        public IBodyWorkflowAction<GetTaskResponseV2> UpdateTask([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydueDateTime = null, [WorkflowExpression] Func<string> bodystartDateTime = null, [WorkflowExpression] Func<int> bodypercentComplete = null, [WorkflowExpression] Func<string> bodybucketId = null, [WorkflowExpression] Func<bool> bodyappliedCategoriespink = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesred = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesyellow = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesgreen = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesblue = null, [WorkflowExpression] Func<bool> bodyappliedCategoriespurple = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesbronze = null, [WorkflowExpression] Func<bool> bodyappliedCategorieslime = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesaqua = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesgray = null, [WorkflowExpression] Func<bool> bodyappliedCategoriessilver = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesbrown = null, [WorkflowExpression] Func<bool> bodyappliedCategoriescranberry = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesorange = null, [WorkflowExpression] Func<bool> bodyappliedCategoriespeach = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesmarigold = null, [WorkflowExpression] Func<bool> bodyappliedCategorieslightGreen = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesdarkGreen = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesteal = null, [WorkflowExpression] Func<bool> bodyappliedCategorieslightBlue = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesdarkBlue = null, [WorkflowExpression] Func<bool> bodyappliedCategorieslavender = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesplum = null, [WorkflowExpression] Func<bool> bodyappliedCategorieslightGray = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesdarkGray = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTaskResponseV2> __BuildUpdateTask(WorkflowValue<string> id, WorkflowValue<string> bodytitle = null, WorkflowValue<string> bodydueDateTime = null, WorkflowValue<string> bodystartDateTime = null, WorkflowValue<int> bodypercentComplete = null, WorkflowValue<string> bodybucketId = null, WorkflowValue<bool> bodyappliedCategoriespink = null, WorkflowValue<bool> bodyappliedCategoriesred = null, WorkflowValue<bool> bodyappliedCategoriesyellow = null, WorkflowValue<bool> bodyappliedCategoriesgreen = null, WorkflowValue<bool> bodyappliedCategoriesblue = null, WorkflowValue<bool> bodyappliedCategoriespurple = null, WorkflowValue<bool> bodyappliedCategoriesbronze = null, WorkflowValue<bool> bodyappliedCategorieslime = null, WorkflowValue<bool> bodyappliedCategoriesaqua = null, WorkflowValue<bool> bodyappliedCategoriesgray = null, WorkflowValue<bool> bodyappliedCategoriessilver = null, WorkflowValue<bool> bodyappliedCategoriesbrown = null, WorkflowValue<bool> bodyappliedCategoriescranberry = null, WorkflowValue<bool> bodyappliedCategoriesorange = null, WorkflowValue<bool> bodyappliedCategoriespeach = null, WorkflowValue<bool> bodyappliedCategoriesmarigold = null, WorkflowValue<bool> bodyappliedCategorieslightGreen = null, WorkflowValue<bool> bodyappliedCategoriesdarkGreen = null, WorkflowValue<bool> bodyappliedCategoriesteal = null, WorkflowValue<bool> bodyappliedCategorieslightBlue = null, WorkflowValue<bool> bodyappliedCategoriesdarkBlue = null, WorkflowValue<bool> bodyappliedCategorieslavender = null, WorkflowValue<bool> bodyappliedCategoriesplum = null, WorkflowValue<bool> bodyappliedCategorieslightGray = null, WorkflowValue<bool> bodyappliedCategoriesdarkGray = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowValue.Validate(bodydueDateTime, nameof(bodydueDateTime), required: false);
            WorkflowValue.Validate(bodystartDateTime, nameof(bodystartDateTime), required: false);
            WorkflowValue.Validate(bodypercentComplete, nameof(bodypercentComplete), required: false);
            WorkflowValue.Validate(bodybucketId, nameof(bodybucketId), required: false);
            WorkflowValue.Validate(bodyappliedCategoriespink, nameof(bodyappliedCategoriespink), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesred, nameof(bodyappliedCategoriesred), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesyellow, nameof(bodyappliedCategoriesyellow), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesgreen, nameof(bodyappliedCategoriesgreen), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesblue, nameof(bodyappliedCategoriesblue), required: false);
            WorkflowValue.Validate(bodyappliedCategoriespurple, nameof(bodyappliedCategoriespurple), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesbronze, nameof(bodyappliedCategoriesbronze), required: false);
            WorkflowValue.Validate(bodyappliedCategorieslime, nameof(bodyappliedCategorieslime), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesaqua, nameof(bodyappliedCategoriesaqua), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesgray, nameof(bodyappliedCategoriesgray), required: false);
            WorkflowValue.Validate(bodyappliedCategoriessilver, nameof(bodyappliedCategoriessilver), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesbrown, nameof(bodyappliedCategoriesbrown), required: false);
            WorkflowValue.Validate(bodyappliedCategoriescranberry, nameof(bodyappliedCategoriescranberry), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesorange, nameof(bodyappliedCategoriesorange), required: false);
            WorkflowValue.Validate(bodyappliedCategoriespeach, nameof(bodyappliedCategoriespeach), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesmarigold, nameof(bodyappliedCategoriesmarigold), required: false);
            WorkflowValue.Validate(bodyappliedCategorieslightGreen, nameof(bodyappliedCategorieslightGreen), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesdarkGreen, nameof(bodyappliedCategoriesdarkGreen), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesteal, nameof(bodyappliedCategoriesteal), required: false);
            WorkflowValue.Validate(bodyappliedCategorieslightBlue, nameof(bodyappliedCategorieslightBlue), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesdarkBlue, nameof(bodyappliedCategoriesdarkBlue), required: false);
            WorkflowValue.Validate(bodyappliedCategorieslavender, nameof(bodyappliedCategorieslavender), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesplum, nameof(bodyappliedCategoriesplum), required: false);
            WorkflowValue.Validate(bodyappliedCategorieslightGray, nameof(bodyappliedCategorieslightGray), required: false);
            WorkflowValue.Validate(bodyappliedCategoriesdarkGray, nameof(bodyappliedCategoriesdarkGray), required: false);
            return new DeferredBodyAction<GetTaskResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/v1.0/planner/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString(" return=representation");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodydueDateTime != null)
                {
                    body["dueDateTime"] = ExpressionConverter.ConvertO(bodydueDateTime);
                    bodypropCount++;
                }

                if (bodystartDateTime != null)
                {
                    body["startDateTime"] = ExpressionConverter.ConvertO(bodystartDateTime);
                    bodypropCount++;
                }

                if (bodypercentComplete != null)
                {
                    body["percentComplete"] = ExpressionConverter.ConvertO(bodypercentComplete);
                    bodypropCount++;
                }

                if (bodybucketId != null)
                {
                    body["bucketId"] = ExpressionConverter.ConvertO(bodybucketId);
                    bodypropCount++;
                }

                var appliedCategoriesObject = new JObject();
                var appliedCategoriesObjectpropCount = 0;
                if (bodyappliedCategoriespink != null)
                {
                    appliedCategoriesObject["category1"] = ExpressionConverter.ConvertO(bodyappliedCategoriespink);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesred != null)
                {
                    appliedCategoriesObject["category2"] = ExpressionConverter.ConvertO(bodyappliedCategoriesred);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesyellow != null)
                {
                    appliedCategoriesObject["category3"] = ExpressionConverter.ConvertO(bodyappliedCategoriesyellow);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesgreen != null)
                {
                    appliedCategoriesObject["category4"] = ExpressionConverter.ConvertO(bodyappliedCategoriesgreen);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesblue != null)
                {
                    appliedCategoriesObject["category5"] = ExpressionConverter.ConvertO(bodyappliedCategoriesblue);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriespurple != null)
                {
                    appliedCategoriesObject["category6"] = ExpressionConverter.ConvertO(bodyappliedCategoriespurple);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesbronze != null)
                {
                    appliedCategoriesObject["category7"] = ExpressionConverter.ConvertO(bodyappliedCategoriesbronze);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategorieslime != null)
                {
                    appliedCategoriesObject["category8"] = ExpressionConverter.ConvertO(bodyappliedCategorieslime);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesaqua != null)
                {
                    appliedCategoriesObject["category9"] = ExpressionConverter.ConvertO(bodyappliedCategoriesaqua);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesgray != null)
                {
                    appliedCategoriesObject["category10"] = ExpressionConverter.ConvertO(bodyappliedCategoriesgray);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriessilver != null)
                {
                    appliedCategoriesObject["category11"] = ExpressionConverter.ConvertO(bodyappliedCategoriessilver);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesbrown != null)
                {
                    appliedCategoriesObject["category12"] = ExpressionConverter.ConvertO(bodyappliedCategoriesbrown);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriescranberry != null)
                {
                    appliedCategoriesObject["category13"] = ExpressionConverter.ConvertO(bodyappliedCategoriescranberry);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesorange != null)
                {
                    appliedCategoriesObject["category14"] = ExpressionConverter.ConvertO(bodyappliedCategoriesorange);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriespeach != null)
                {
                    appliedCategoriesObject["category15"] = ExpressionConverter.ConvertO(bodyappliedCategoriespeach);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesmarigold != null)
                {
                    appliedCategoriesObject["category16"] = ExpressionConverter.ConvertO(bodyappliedCategoriesmarigold);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategorieslightGreen != null)
                {
                    appliedCategoriesObject["category17"] = ExpressionConverter.ConvertO(bodyappliedCategorieslightGreen);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesdarkGreen != null)
                {
                    appliedCategoriesObject["category18"] = ExpressionConverter.ConvertO(bodyappliedCategoriesdarkGreen);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesteal != null)
                {
                    appliedCategoriesObject["category19"] = ExpressionConverter.ConvertO(bodyappliedCategoriesteal);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategorieslightBlue != null)
                {
                    appliedCategoriesObject["category20"] = ExpressionConverter.ConvertO(bodyappliedCategorieslightBlue);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesdarkBlue != null)
                {
                    appliedCategoriesObject["category21"] = ExpressionConverter.ConvertO(bodyappliedCategoriesdarkBlue);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategorieslavender != null)
                {
                    appliedCategoriesObject["category22"] = ExpressionConverter.ConvertO(bodyappliedCategorieslavender);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesplum != null)
                {
                    appliedCategoriesObject["category23"] = ExpressionConverter.ConvertO(bodyappliedCategoriesplum);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategorieslightGray != null)
                {
                    appliedCategoriesObject["category24"] = ExpressionConverter.ConvertO(bodyappliedCategorieslightGray);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesdarkGray != null)
                {
                    appliedCategoriesObject["category25"] = ExpressionConverter.ConvertO(bodyappliedCategoriesdarkGray);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateTaskDetails))]
        public IBodyWorkflowAction<GetTaskDetailsResponse> UpdateTaskDetails([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bodyreferencesInputItem[]> bodyreferences = null, [WorkflowExpression] Func<bodychecklistInputItem[]> bodychecklist = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTaskDetailsResponse> __BuildUpdateTaskDetails(WorkflowValue<string> id, WorkflowValue<string> bodydescription = null, WorkflowValue<bodyreferencesInputItem[]> bodyreferences = null, WorkflowValue<bodychecklistInputItem[]> bodychecklist = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowValue.Validate(bodyreferences, nameof(bodyreferences), required: false);
            WorkflowValue.Validate(bodychecklist, nameof(bodychecklist), required: false);
            return new DeferredBodyAction<GetTaskDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/planner/tasks/{0}/details", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString(" return=representation");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyreferences != null)
                {
                    body["references"] = ExpressionConverter.ConvertO(bodyreferences);
                    bodypropCount++;
                }

                if (bodychecklist != null)
                {
                    body["checklist"] = ExpressionConverter.ConvertO(bodychecklist);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetTaskDetailsResponse>(callPayload);
            });
        }
    }

    public class PlannerTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildOnCompleteTask))]
        public IBodyWorkflowTrigger<ListTasksResponseV2> OnCompleteTask([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> id, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ListTasksResponseV2> __BuildOnCompleteTask(WorkflowValue<string> groupId, WorkflowValue<string> id, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyTrigger<ListTasksResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/v1.0/planner/oncompletetask_trigger/plans/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(groupId);
                return new ApiConnectionTrigger<ListTasksResponseV2>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildOnNewTask))]
        public IBodyWorkflowTrigger<ListTasksResponseV2> OnNewTask([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> id, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ListTasksResponseV2> __BuildOnNewTask(WorkflowValue<string> groupId, WorkflowValue<string> id, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyTrigger<ListTasksResponseV2>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/v1.0/planner/onnewtask_trigger/plans/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = ExpressionConverter.Convert(groupId);
                return new ApiConnectionTrigger<ListTasksResponseV2>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        public IBodyWorkflowTrigger<ListTasksResponseV2> OnTaskAssignedToMe(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1.0/me/planner/ontaskassignedtome_trigger/tasks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListTasksResponseV2>(callPayload, triggerName, recurrence);
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
