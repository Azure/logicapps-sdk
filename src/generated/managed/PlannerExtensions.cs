//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Planner
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PlannerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IWorkflowAction DeleteTask(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/planner/tasks/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskResponseV2> UnassignUsers(Expression<Func<string>> id, Expression<Func<string>> bodyremoveAssignedUsers)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/planner/tasks/{0}/unassignusers", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["prefer"] = Convert.ToString(" return=representation");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["assignments"] = CSharpExpressionConverter.ConvertToken(bodyremoveAssignedUsers);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetTaskResponseV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskResponseV2> AssignUsers(Expression<Func<string>> id, Expression<Func<string>> bodyassignedUserIds)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/planner/tasks/{0}/assignusers", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["prefer"] = Convert.ToString(" return=representation");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["assignments"] = CSharpExpressionConverter.ConvertToken(bodyassignedUserIds);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetTaskResponseV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<ListMyPlansResponse> ListGroupPlans(Expression<Func<string>> groupId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/planner/plans", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListMyPlansResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<CreateBucketResponse> CreateBucket(Expression<Func<string>> bodyname, Expression<Func<string>> bodygroupId, Expression<Func<string>> bodyplanId)
        {
            var apiCallPath = "/v2/v1.0/planner/buckets";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            bodypropCount++;
            body["groupId"] = CSharpExpressionConverter.ConvertToken(bodygroupId);
            bodypropCount++;
            body["planId"] = CSharpExpressionConverter.ConvertToken(bodyplanId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateBucketResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskResponseV3> CreateTask(Expression<Func<string>> bodygroupId, Expression<Func<string>> bodyplanId, Expression<Func<string>> bodytitle, Expression<Func<string>> bodybucketId = null, Expression<Func<string>> bodystartDateTime = null, Expression<Func<string>> bodydueDateTime = null, Expression<Func<string>> bodyassignedUserIds = null, Expression<Func<bool>> bodyappliedCategoriespink = null, Expression<Func<bool>> bodyappliedCategoriesred = null, Expression<Func<bool>> bodyappliedCategoriesyellow = null, Expression<Func<bool>> bodyappliedCategoriesgreen = null, Expression<Func<bool>> bodyappliedCategoriesblue = null, Expression<Func<bool>> bodyappliedCategoriespurple = null, Expression<Func<bool>> bodyappliedCategoriesbronze = null, Expression<Func<bool>> bodyappliedCategorieslime = null, Expression<Func<bool>> bodyappliedCategoriesaqua = null, Expression<Func<bool>> bodyappliedCategoriesgray = null, Expression<Func<bool>> bodyappliedCategoriessilver = null, Expression<Func<bool>> bodyappliedCategoriesbrown = null, Expression<Func<bool>> bodyappliedCategoriescranberry = null, Expression<Func<bool>> bodyappliedCategoriesorange = null, Expression<Func<bool>> bodyappliedCategoriespeach = null, Expression<Func<bool>> bodyappliedCategoriesmarigold = null, Expression<Func<bool>> bodyappliedCategorieslightGreen = null, Expression<Func<bool>> bodyappliedCategoriesdarkGreen = null, Expression<Func<bool>> bodyappliedCategoriesteal = null, Expression<Func<bool>> bodyappliedCategorieslightBlue = null, Expression<Func<bool>> bodyappliedCategoriesdarkBlue = null, Expression<Func<bool>> bodyappliedCategorieslavender = null, Expression<Func<bool>> bodyappliedCategoriesplum = null, Expression<Func<bool>> bodyappliedCategorieslightGray = null, Expression<Func<bool>> bodyappliedCategoriesdarkGray = null, Expression<Func<int>> bodypriority = null)
        {
            var apiCallPath = "/v2/beta/planner/tasks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["prefer"] = Convert.ToString(" return=representation");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["groupId"] = CSharpExpressionConverter.ConvertToken(bodygroupId);
            bodypropCount++;
            body["planId"] = CSharpExpressionConverter.ConvertToken(bodyplanId);
            bodypropCount++;
            body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
            if (bodybucketId != null)
            {
                body["bucketId"] = CSharpExpressionConverter.ConvertToken(bodybucketId);
                bodypropCount++;
            }

            if (bodystartDateTime != null)
            {
                body["startDateTime"] = CSharpExpressionConverter.ConvertToken(bodystartDateTime);
                bodypropCount++;
            }

            if (bodydueDateTime != null)
            {
                body["dueDateTime"] = CSharpExpressionConverter.ConvertToken(bodydueDateTime);
                bodypropCount++;
            }

            if (bodyassignedUserIds != null)
            {
                body["assignments"] = CSharpExpressionConverter.ConvertToken(bodyassignedUserIds);
                bodypropCount++;
            }

            var appliedCategoriesObject = new JObject();
            var appliedCategoriesObjectpropCount = 0;
            if (bodyappliedCategoriespink != null)
            {
                appliedCategoriesObject["category1"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriespink);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesred != null)
            {
                appliedCategoriesObject["category2"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesred);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesyellow != null)
            {
                appliedCategoriesObject["category3"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesyellow);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesgreen != null)
            {
                appliedCategoriesObject["category4"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesgreen);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesblue != null)
            {
                appliedCategoriesObject["category5"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesblue);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriespurple != null)
            {
                appliedCategoriesObject["category6"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriespurple);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesbronze != null)
            {
                appliedCategoriesObject["category7"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesbronze);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategorieslime != null)
            {
                appliedCategoriesObject["category8"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategorieslime);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesaqua != null)
            {
                appliedCategoriesObject["category9"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesaqua);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesgray != null)
            {
                appliedCategoriesObject["category10"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesgray);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriessilver != null)
            {
                appliedCategoriesObject["category11"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriessilver);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesbrown != null)
            {
                appliedCategoriesObject["category12"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesbrown);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriescranberry != null)
            {
                appliedCategoriesObject["category13"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriescranberry);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesorange != null)
            {
                appliedCategoriesObject["category14"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesorange);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriespeach != null)
            {
                appliedCategoriesObject["category15"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriespeach);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesmarigold != null)
            {
                appliedCategoriesObject["category16"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesmarigold);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategorieslightGreen != null)
            {
                appliedCategoriesObject["category17"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategorieslightGreen);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesdarkGreen != null)
            {
                appliedCategoriesObject["category18"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesdarkGreen);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesteal != null)
            {
                appliedCategoriesObject["category19"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesteal);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategorieslightBlue != null)
            {
                appliedCategoriesObject["category20"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategorieslightBlue);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesdarkBlue != null)
            {
                appliedCategoriesObject["category21"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesdarkBlue);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategorieslavender != null)
            {
                appliedCategoriesObject["category22"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategorieslavender);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesplum != null)
            {
                appliedCategoriesObject["category23"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesplum);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategorieslightGray != null)
            {
                appliedCategoriesObject["category24"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategorieslightGray);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesdarkGray != null)
            {
                appliedCategoriesObject["category25"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesdarkGray);
                appliedCategoriesObjectpropCount++;
            }

            if (appliedCategoriesObjectpropCount > 0)
            {
                body["appliedCategories"] = appliedCategoriesObject;
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["priority"] = CSharpExpressionConverter.ConvertToken(bodypriority);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetTaskResponseV3>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskResponseV2> GetTask(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/planner/tasks/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetTaskResponseV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskDetailsResponse> GetTaskDetails(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/planner/tasks/{0}/details", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetTaskDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<ListBucketsResponse> ListBuckets(Expression<Func<string>> groupId, Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/v1.0/planner/plans/{0}/buckets", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["groupId"] = CSharpExpressionConverter.ConvertO(groupId);
            return new ApiConnectionAction<ListBucketsResponse>(callPayload);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/v1.0/planner/plans/{0}/tasks", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["groupId"] = CSharpExpressionConverter.ConvertO(groupId);
            return new ApiConnectionAction<ListTasksResponseV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskResponseV2> UpdateTask(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydueDateTime = null, Expression<Func<string>> bodystartDateTime = null, Expression<Func<int>> bodypercentComplete = null, Expression<Func<string>> bodybucketId = null, Expression<Func<bool>> bodyappliedCategoriespink = null, Expression<Func<bool>> bodyappliedCategoriesred = null, Expression<Func<bool>> bodyappliedCategoriesyellow = null, Expression<Func<bool>> bodyappliedCategoriesgreen = null, Expression<Func<bool>> bodyappliedCategoriesblue = null, Expression<Func<bool>> bodyappliedCategoriespurple = null, Expression<Func<bool>> bodyappliedCategoriesbronze = null, Expression<Func<bool>> bodyappliedCategorieslime = null, Expression<Func<bool>> bodyappliedCategoriesaqua = null, Expression<Func<bool>> bodyappliedCategoriesgray = null, Expression<Func<bool>> bodyappliedCategoriessilver = null, Expression<Func<bool>> bodyappliedCategoriesbrown = null, Expression<Func<bool>> bodyappliedCategoriescranberry = null, Expression<Func<bool>> bodyappliedCategoriesorange = null, Expression<Func<bool>> bodyappliedCategoriespeach = null, Expression<Func<bool>> bodyappliedCategoriesmarigold = null, Expression<Func<bool>> bodyappliedCategorieslightGreen = null, Expression<Func<bool>> bodyappliedCategoriesdarkGreen = null, Expression<Func<bool>> bodyappliedCategoriesteal = null, Expression<Func<bool>> bodyappliedCategorieslightBlue = null, Expression<Func<bool>> bodyappliedCategoriesdarkBlue = null, Expression<Func<bool>> bodyappliedCategorieslavender = null, Expression<Func<bool>> bodyappliedCategoriesplum = null, Expression<Func<bool>> bodyappliedCategorieslightGray = null, Expression<Func<bool>> bodyappliedCategoriesdarkGray = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/v1.0/planner/tasks/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["prefer"] = Convert.ToString(" return=representation");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytitle != null)
            {
                body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodydueDateTime != null)
            {
                body["dueDateTime"] = CSharpExpressionConverter.ConvertToken(bodydueDateTime);
                bodypropCount++;
            }

            if (bodystartDateTime != null)
            {
                body["startDateTime"] = CSharpExpressionConverter.ConvertToken(bodystartDateTime);
                bodypropCount++;
            }

            if (bodypercentComplete != null)
            {
                body["percentComplete"] = CSharpExpressionConverter.ConvertToken(bodypercentComplete);
                bodypropCount++;
            }

            if (bodybucketId != null)
            {
                body["bucketId"] = CSharpExpressionConverter.ConvertToken(bodybucketId);
                bodypropCount++;
            }

            var appliedCategoriesObject = new JObject();
            var appliedCategoriesObjectpropCount = 0;
            if (bodyappliedCategoriespink != null)
            {
                appliedCategoriesObject["category1"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriespink);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesred != null)
            {
                appliedCategoriesObject["category2"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesred);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesyellow != null)
            {
                appliedCategoriesObject["category3"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesyellow);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesgreen != null)
            {
                appliedCategoriesObject["category4"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesgreen);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesblue != null)
            {
                appliedCategoriesObject["category5"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesblue);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriespurple != null)
            {
                appliedCategoriesObject["category6"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriespurple);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesbronze != null)
            {
                appliedCategoriesObject["category7"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesbronze);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategorieslime != null)
            {
                appliedCategoriesObject["category8"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategorieslime);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesaqua != null)
            {
                appliedCategoriesObject["category9"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesaqua);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesgray != null)
            {
                appliedCategoriesObject["category10"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesgray);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriessilver != null)
            {
                appliedCategoriesObject["category11"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriessilver);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesbrown != null)
            {
                appliedCategoriesObject["category12"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesbrown);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriescranberry != null)
            {
                appliedCategoriesObject["category13"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriescranberry);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesorange != null)
            {
                appliedCategoriesObject["category14"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesorange);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriespeach != null)
            {
                appliedCategoriesObject["category15"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriespeach);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesmarigold != null)
            {
                appliedCategoriesObject["category16"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesmarigold);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategorieslightGreen != null)
            {
                appliedCategoriesObject["category17"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategorieslightGreen);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesdarkGreen != null)
            {
                appliedCategoriesObject["category18"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesdarkGreen);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesteal != null)
            {
                appliedCategoriesObject["category19"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesteal);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategorieslightBlue != null)
            {
                appliedCategoriesObject["category20"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategorieslightBlue);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesdarkBlue != null)
            {
                appliedCategoriesObject["category21"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesdarkBlue);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategorieslavender != null)
            {
                appliedCategoriesObject["category22"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategorieslavender);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesplum != null)
            {
                appliedCategoriesObject["category23"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesplum);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategorieslightGray != null)
            {
                appliedCategoriesObject["category24"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategorieslightGray);
                appliedCategoriesObjectpropCount++;
            }

            if (bodyappliedCategoriesdarkGray != null)
            {
                appliedCategoriesObject["category25"] = CSharpExpressionConverter.ConvertToken(bodyappliedCategoriesdarkGray);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskDetailsResponse> UpdateTaskDetails(Expression<Func<string>> id, Expression<Func<string>> bodydescription = null, Expression<Func<bodyreferencesInputItem[]>> bodyreferences = null, Expression<Func<bodychecklistInputItem[]>> bodychecklist = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/planner/tasks/{0}/details", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["prefer"] = Convert.ToString(" return=representation");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodyreferences != null)
            {
                body["references"] = CSharpExpressionConverter.ConvertToken(bodyreferences);
                bodypropCount++;
            }

            if (bodychecklist != null)
            {
                body["checklist"] = CSharpExpressionConverter.ConvertToken(bodychecklist);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetTaskDetailsResponse>(callPayload);
        }
    }

    public class PlannerTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListTasksResponseV2> OnCompleteTask(Expression<Func<string>> groupId, Expression<Func<string>> id, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/v1.0/planner/oncompletetask_trigger/plans/{0}/tasks", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["groupId"] = CSharpExpressionConverter.ConvertO(groupId);
            return new ApiConnectionTrigger<ListTasksResponseV2>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListTasksResponseV2> OnNewTask(Expression<Func<string>> groupId, Expression<Func<string>> id, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/v1.0/planner/onnewtask_trigger/plans/{0}/tasks", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["groupId"] = CSharpExpressionConverter.ConvertO(groupId);
            return new ApiConnectionTrigger<ListTasksResponseV2>(callPayload, triggerName, recurrence);
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