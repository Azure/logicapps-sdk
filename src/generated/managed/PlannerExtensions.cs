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
        public IWorkflowAction DeleteTask([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/planner/tasks/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskResponseV2> UnassignUsers([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyremoveAssignedUsers)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyremoveAssignedUsers, nameof(bodyremoveAssignedUsers), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/planner/tasks/{0}/unassignusers", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString(" return=representation");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["assignments"] = SourceExpressionConverter.ConvertToken(bodyremoveAssignedUsers);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetTaskResponseV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskResponseV2> AssignUsers([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyassignedUserIds)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyassignedUserIds, nameof(bodyassignedUserIds), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/planner/tasks/{0}/assignusers", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString(" return=representation");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["assignments"] = SourceExpressionConverter.ConvertToken(bodyassignedUserIds);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetTaskResponseV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<ListMyPlansResponse> ListGroupPlans([WorkflowExpression] Func<string> groupId)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/planner/plans", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListMyPlansResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<CreateBucketResponse> CreateBucket([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodygroupId, [WorkflowExpression] Func<string> bodyplanId)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodygroupId, nameof(bodygroupId), required: true);
            SourceExpression.Validate(bodyplanId, nameof(bodyplanId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/v1.0/planner/buckets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["groupId"] = SourceExpressionConverter.ConvertToken(bodygroupId);
                bodypropCount++;
                body["planId"] = SourceExpressionConverter.ConvertToken(bodyplanId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateBucketResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskResponseV3> CreateTask([WorkflowExpression] Func<string> bodygroupId, [WorkflowExpression] Func<string> bodyplanId, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodybucketId = null, [WorkflowExpression] Func<string> bodystartDateTime = null, [WorkflowExpression] Func<string> bodydueDateTime = null, [WorkflowExpression] Func<string> bodyassignedUserIds = null, [WorkflowExpression] Func<bool> bodyappliedCategoriespink = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesred = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesyellow = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesgreen = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesblue = null, [WorkflowExpression] Func<bool> bodyappliedCategoriespurple = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesbronze = null, [WorkflowExpression] Func<bool> bodyappliedCategorieslime = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesaqua = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesgray = null, [WorkflowExpression] Func<bool> bodyappliedCategoriessilver = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesbrown = null, [WorkflowExpression] Func<bool> bodyappliedCategoriescranberry = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesorange = null, [WorkflowExpression] Func<bool> bodyappliedCategoriespeach = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesmarigold = null, [WorkflowExpression] Func<bool> bodyappliedCategorieslightGreen = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesdarkGreen = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesteal = null, [WorkflowExpression] Func<bool> bodyappliedCategorieslightBlue = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesdarkBlue = null, [WorkflowExpression] Func<bool> bodyappliedCategorieslavender = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesplum = null, [WorkflowExpression] Func<bool> bodyappliedCategorieslightGray = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesdarkGray = null, [WorkflowExpression] Func<int> bodypriority = null)
        {
            SourceExpression.Validate(bodygroupId, nameof(bodygroupId), required: true);
            SourceExpression.Validate(bodyplanId, nameof(bodyplanId), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            SourceExpression.Validate(bodybucketId, nameof(bodybucketId), required: false);
            SourceExpression.Validate(bodystartDateTime, nameof(bodystartDateTime), required: false);
            SourceExpression.Validate(bodydueDateTime, nameof(bodydueDateTime), required: false);
            SourceExpression.Validate(bodyassignedUserIds, nameof(bodyassignedUserIds), required: false);
            SourceExpression.Validate(bodyappliedCategoriespink, nameof(bodyappliedCategoriespink), required: false);
            SourceExpression.Validate(bodyappliedCategoriesred, nameof(bodyappliedCategoriesred), required: false);
            SourceExpression.Validate(bodyappliedCategoriesyellow, nameof(bodyappliedCategoriesyellow), required: false);
            SourceExpression.Validate(bodyappliedCategoriesgreen, nameof(bodyappliedCategoriesgreen), required: false);
            SourceExpression.Validate(bodyappliedCategoriesblue, nameof(bodyappliedCategoriesblue), required: false);
            SourceExpression.Validate(bodyappliedCategoriespurple, nameof(bodyappliedCategoriespurple), required: false);
            SourceExpression.Validate(bodyappliedCategoriesbronze, nameof(bodyappliedCategoriesbronze), required: false);
            SourceExpression.Validate(bodyappliedCategorieslime, nameof(bodyappliedCategorieslime), required: false);
            SourceExpression.Validate(bodyappliedCategoriesaqua, nameof(bodyappliedCategoriesaqua), required: false);
            SourceExpression.Validate(bodyappliedCategoriesgray, nameof(bodyappliedCategoriesgray), required: false);
            SourceExpression.Validate(bodyappliedCategoriessilver, nameof(bodyappliedCategoriessilver), required: false);
            SourceExpression.Validate(bodyappliedCategoriesbrown, nameof(bodyappliedCategoriesbrown), required: false);
            SourceExpression.Validate(bodyappliedCategoriescranberry, nameof(bodyappliedCategoriescranberry), required: false);
            SourceExpression.Validate(bodyappliedCategoriesorange, nameof(bodyappliedCategoriesorange), required: false);
            SourceExpression.Validate(bodyappliedCategoriespeach, nameof(bodyappliedCategoriespeach), required: false);
            SourceExpression.Validate(bodyappliedCategoriesmarigold, nameof(bodyappliedCategoriesmarigold), required: false);
            SourceExpression.Validate(bodyappliedCategorieslightGreen, nameof(bodyappliedCategorieslightGreen), required: false);
            SourceExpression.Validate(bodyappliedCategoriesdarkGreen, nameof(bodyappliedCategoriesdarkGreen), required: false);
            SourceExpression.Validate(bodyappliedCategoriesteal, nameof(bodyappliedCategoriesteal), required: false);
            SourceExpression.Validate(bodyappliedCategorieslightBlue, nameof(bodyappliedCategorieslightBlue), required: false);
            SourceExpression.Validate(bodyappliedCategoriesdarkBlue, nameof(bodyappliedCategoriesdarkBlue), required: false);
            SourceExpression.Validate(bodyappliedCategorieslavender, nameof(bodyappliedCategorieslavender), required: false);
            SourceExpression.Validate(bodyappliedCategoriesplum, nameof(bodyappliedCategoriesplum), required: false);
            SourceExpression.Validate(bodyappliedCategorieslightGray, nameof(bodyappliedCategorieslightGray), required: false);
            SourceExpression.Validate(bodyappliedCategoriesdarkGray, nameof(bodyappliedCategoriesdarkGray), required: false);
            SourceExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/beta/planner/tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString(" return=representation");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["groupId"] = SourceExpressionConverter.ConvertToken(bodygroupId);
                bodypropCount++;
                body["planId"] = SourceExpressionConverter.ConvertToken(bodyplanId);
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodybucketId != null)
                {
                    body["bucketId"] = SourceExpressionConverter.ConvertToken(bodybucketId);
                    bodypropCount++;
                }

                if (bodystartDateTime != null)
                {
                    body["startDateTime"] = SourceExpressionConverter.ConvertToken(bodystartDateTime);
                    bodypropCount++;
                }

                if (bodydueDateTime != null)
                {
                    body["dueDateTime"] = SourceExpressionConverter.ConvertToken(bodydueDateTime);
                    bodypropCount++;
                }

                if (bodyassignedUserIds != null)
                {
                    body["assignments"] = SourceExpressionConverter.ConvertToken(bodyassignedUserIds);
                    bodypropCount++;
                }

                var appliedCategoriesObject = new JObject();
                var appliedCategoriesObjectpropCount = 0;
                if (bodyappliedCategoriespink != null)
                {
                    appliedCategoriesObject["category1"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriespink);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesred != null)
                {
                    appliedCategoriesObject["category2"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesred);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesyellow != null)
                {
                    appliedCategoriesObject["category3"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesyellow);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesgreen != null)
                {
                    appliedCategoriesObject["category4"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesgreen);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesblue != null)
                {
                    appliedCategoriesObject["category5"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesblue);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriespurple != null)
                {
                    appliedCategoriesObject["category6"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriespurple);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesbronze != null)
                {
                    appliedCategoriesObject["category7"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesbronze);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategorieslime != null)
                {
                    appliedCategoriesObject["category8"] = SourceExpressionConverter.ConvertToken(bodyappliedCategorieslime);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesaqua != null)
                {
                    appliedCategoriesObject["category9"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesaqua);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesgray != null)
                {
                    appliedCategoriesObject["category10"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesgray);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriessilver != null)
                {
                    appliedCategoriesObject["category11"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriessilver);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesbrown != null)
                {
                    appliedCategoriesObject["category12"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesbrown);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriescranberry != null)
                {
                    appliedCategoriesObject["category13"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriescranberry);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesorange != null)
                {
                    appliedCategoriesObject["category14"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesorange);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriespeach != null)
                {
                    appliedCategoriesObject["category15"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriespeach);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesmarigold != null)
                {
                    appliedCategoriesObject["category16"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesmarigold);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategorieslightGreen != null)
                {
                    appliedCategoriesObject["category17"] = SourceExpressionConverter.ConvertToken(bodyappliedCategorieslightGreen);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesdarkGreen != null)
                {
                    appliedCategoriesObject["category18"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesdarkGreen);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesteal != null)
                {
                    appliedCategoriesObject["category19"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesteal);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategorieslightBlue != null)
                {
                    appliedCategoriesObject["category20"] = SourceExpressionConverter.ConvertToken(bodyappliedCategorieslightBlue);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesdarkBlue != null)
                {
                    appliedCategoriesObject["category21"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesdarkBlue);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategorieslavender != null)
                {
                    appliedCategoriesObject["category22"] = SourceExpressionConverter.ConvertToken(bodyappliedCategorieslavender);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesplum != null)
                {
                    appliedCategoriesObject["category23"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesplum);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategorieslightGray != null)
                {
                    appliedCategoriesObject["category24"] = SourceExpressionConverter.ConvertToken(bodyappliedCategorieslightGray);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesdarkGray != null)
                {
                    appliedCategoriesObject["category25"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesdarkGray);
                    appliedCategoriesObjectpropCount++;
                }

                if (appliedCategoriesObjectpropCount > 0)
                {
                    body["appliedCategories"] = appliedCategoriesObject;
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetTaskResponseV3>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskResponseV2> GetTask([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/planner/tasks/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetTaskResponseV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskDetailsResponse> GetTaskDetails([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/planner/tasks/{0}/details", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetTaskDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<ListBucketsResponse> ListBuckets([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/v1.0/planner/plans/{0}/buckets", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = SourceExpressionConverter.ConvertO(groupId);
                return callPayload;
            }

            return new ApiConnectionAction<ListBucketsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<ListTasksResponseV2> ListMyTasks()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/me/planner/tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListTasksResponseV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<ListTasksResponseV2> ListTasks([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/v1.0/planner/plans/{0}/tasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = SourceExpressionConverter.ConvertO(groupId);
                return callPayload;
            }

            return new ApiConnectionAction<ListTasksResponseV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskResponseV2> UpdateTask([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydueDateTime = null, [WorkflowExpression] Func<string> bodystartDateTime = null, [WorkflowExpression] Func<int> bodypercentComplete = null, [WorkflowExpression] Func<string> bodybucketId = null, [WorkflowExpression] Func<bool> bodyappliedCategoriespink = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesred = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesyellow = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesgreen = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesblue = null, [WorkflowExpression] Func<bool> bodyappliedCategoriespurple = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesbronze = null, [WorkflowExpression] Func<bool> bodyappliedCategorieslime = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesaqua = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesgray = null, [WorkflowExpression] Func<bool> bodyappliedCategoriessilver = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesbrown = null, [WorkflowExpression] Func<bool> bodyappliedCategoriescranberry = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesorange = null, [WorkflowExpression] Func<bool> bodyappliedCategoriespeach = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesmarigold = null, [WorkflowExpression] Func<bool> bodyappliedCategorieslightGreen = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesdarkGreen = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesteal = null, [WorkflowExpression] Func<bool> bodyappliedCategorieslightBlue = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesdarkBlue = null, [WorkflowExpression] Func<bool> bodyappliedCategorieslavender = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesplum = null, [WorkflowExpression] Func<bool> bodyappliedCategorieslightGray = null, [WorkflowExpression] Func<bool> bodyappliedCategoriesdarkGray = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodydueDateTime, nameof(bodydueDateTime), required: false);
            SourceExpression.Validate(bodystartDateTime, nameof(bodystartDateTime), required: false);
            SourceExpression.Validate(bodypercentComplete, nameof(bodypercentComplete), required: false);
            SourceExpression.Validate(bodybucketId, nameof(bodybucketId), required: false);
            SourceExpression.Validate(bodyappliedCategoriespink, nameof(bodyappliedCategoriespink), required: false);
            SourceExpression.Validate(bodyappliedCategoriesred, nameof(bodyappliedCategoriesred), required: false);
            SourceExpression.Validate(bodyappliedCategoriesyellow, nameof(bodyappliedCategoriesyellow), required: false);
            SourceExpression.Validate(bodyappliedCategoriesgreen, nameof(bodyappliedCategoriesgreen), required: false);
            SourceExpression.Validate(bodyappliedCategoriesblue, nameof(bodyappliedCategoriesblue), required: false);
            SourceExpression.Validate(bodyappliedCategoriespurple, nameof(bodyappliedCategoriespurple), required: false);
            SourceExpression.Validate(bodyappliedCategoriesbronze, nameof(bodyappliedCategoriesbronze), required: false);
            SourceExpression.Validate(bodyappliedCategorieslime, nameof(bodyappliedCategorieslime), required: false);
            SourceExpression.Validate(bodyappliedCategoriesaqua, nameof(bodyappliedCategoriesaqua), required: false);
            SourceExpression.Validate(bodyappliedCategoriesgray, nameof(bodyappliedCategoriesgray), required: false);
            SourceExpression.Validate(bodyappliedCategoriessilver, nameof(bodyappliedCategoriessilver), required: false);
            SourceExpression.Validate(bodyappliedCategoriesbrown, nameof(bodyappliedCategoriesbrown), required: false);
            SourceExpression.Validate(bodyappliedCategoriescranberry, nameof(bodyappliedCategoriescranberry), required: false);
            SourceExpression.Validate(bodyappliedCategoriesorange, nameof(bodyappliedCategoriesorange), required: false);
            SourceExpression.Validate(bodyappliedCategoriespeach, nameof(bodyappliedCategoriespeach), required: false);
            SourceExpression.Validate(bodyappliedCategoriesmarigold, nameof(bodyappliedCategoriesmarigold), required: false);
            SourceExpression.Validate(bodyappliedCategorieslightGreen, nameof(bodyappliedCategorieslightGreen), required: false);
            SourceExpression.Validate(bodyappliedCategoriesdarkGreen, nameof(bodyappliedCategoriesdarkGreen), required: false);
            SourceExpression.Validate(bodyappliedCategoriesteal, nameof(bodyappliedCategoriesteal), required: false);
            SourceExpression.Validate(bodyappliedCategorieslightBlue, nameof(bodyappliedCategorieslightBlue), required: false);
            SourceExpression.Validate(bodyappliedCategoriesdarkBlue, nameof(bodyappliedCategoriesdarkBlue), required: false);
            SourceExpression.Validate(bodyappliedCategorieslavender, nameof(bodyappliedCategorieslavender), required: false);
            SourceExpression.Validate(bodyappliedCategoriesplum, nameof(bodyappliedCategoriesplum), required: false);
            SourceExpression.Validate(bodyappliedCategorieslightGray, nameof(bodyappliedCategorieslightGray), required: false);
            SourceExpression.Validate(bodyappliedCategoriesdarkGray, nameof(bodyappliedCategoriesdarkGray), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/v1.0/planner/tasks/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString(" return=representation");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodydueDateTime != null)
                {
                    body["dueDateTime"] = SourceExpressionConverter.ConvertToken(bodydueDateTime);
                    bodypropCount++;
                }

                if (bodystartDateTime != null)
                {
                    body["startDateTime"] = SourceExpressionConverter.ConvertToken(bodystartDateTime);
                    bodypropCount++;
                }

                if (bodypercentComplete != null)
                {
                    body["percentComplete"] = SourceExpressionConverter.ConvertToken(bodypercentComplete);
                    bodypropCount++;
                }

                if (bodybucketId != null)
                {
                    body["bucketId"] = SourceExpressionConverter.ConvertToken(bodybucketId);
                    bodypropCount++;
                }

                var appliedCategoriesObject = new JObject();
                var appliedCategoriesObjectpropCount = 0;
                if (bodyappliedCategoriespink != null)
                {
                    appliedCategoriesObject["category1"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriespink);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesred != null)
                {
                    appliedCategoriesObject["category2"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesred);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesyellow != null)
                {
                    appliedCategoriesObject["category3"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesyellow);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesgreen != null)
                {
                    appliedCategoriesObject["category4"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesgreen);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesblue != null)
                {
                    appliedCategoriesObject["category5"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesblue);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriespurple != null)
                {
                    appliedCategoriesObject["category6"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriespurple);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesbronze != null)
                {
                    appliedCategoriesObject["category7"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesbronze);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategorieslime != null)
                {
                    appliedCategoriesObject["category8"] = SourceExpressionConverter.ConvertToken(bodyappliedCategorieslime);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesaqua != null)
                {
                    appliedCategoriesObject["category9"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesaqua);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesgray != null)
                {
                    appliedCategoriesObject["category10"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesgray);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriessilver != null)
                {
                    appliedCategoriesObject["category11"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriessilver);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesbrown != null)
                {
                    appliedCategoriesObject["category12"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesbrown);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriescranberry != null)
                {
                    appliedCategoriesObject["category13"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriescranberry);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesorange != null)
                {
                    appliedCategoriesObject["category14"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesorange);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriespeach != null)
                {
                    appliedCategoriesObject["category15"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriespeach);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesmarigold != null)
                {
                    appliedCategoriesObject["category16"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesmarigold);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategorieslightGreen != null)
                {
                    appliedCategoriesObject["category17"] = SourceExpressionConverter.ConvertToken(bodyappliedCategorieslightGreen);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesdarkGreen != null)
                {
                    appliedCategoriesObject["category18"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesdarkGreen);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesteal != null)
                {
                    appliedCategoriesObject["category19"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesteal);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategorieslightBlue != null)
                {
                    appliedCategoriesObject["category20"] = SourceExpressionConverter.ConvertToken(bodyappliedCategorieslightBlue);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesdarkBlue != null)
                {
                    appliedCategoriesObject["category21"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesdarkBlue);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategorieslavender != null)
                {
                    appliedCategoriesObject["category22"] = SourceExpressionConverter.ConvertToken(bodyappliedCategorieslavender);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesplum != null)
                {
                    appliedCategoriesObject["category23"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesplum);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategorieslightGray != null)
                {
                    appliedCategoriesObject["category24"] = SourceExpressionConverter.ConvertToken(bodyappliedCategorieslightGray);
                    appliedCategoriesObjectpropCount++;
                }

                if (bodyappliedCategoriesdarkGray != null)
                {
                    appliedCategoriesObject["category25"] = SourceExpressionConverter.ConvertToken(bodyappliedCategoriesdarkGray);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetTaskResponseV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "planner")]
        public IBodyWorkflowAction<GetTaskDetailsResponse> UpdateTaskDetails([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bodyreferencesInputItem[]> bodyreferences = null, [WorkflowExpression] Func<bodychecklistInputItem[]> bodychecklist = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyreferences, nameof(bodyreferences), required: false);
            SourceExpression.Validate(bodychecklist, nameof(bodychecklist), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/planner/tasks/{0}/details", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["prefer"] = Convert.ToString(" return=representation");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyreferences != null)
                {
                    body["references"] = SourceExpressionConverter.ConvertToken(bodyreferences);
                    bodypropCount++;
                }

                if (bodychecklist != null)
                {
                    body["checklist"] = SourceExpressionConverter.ConvertToken(bodychecklist);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetTaskDetailsResponse>(BuildSourceInput);
        }
    }

    public class PlannerTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListTasksResponseV2> OnCompleteTask([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> id, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/v1.0/planner/oncompletetask_trigger/plans/{0}/tasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = SourceExpressionConverter.ConvertO(groupId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListTasksResponseV2>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListTasksResponseV2> OnNewTask([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> id, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/v1.0/planner/onnewtask_trigger/plans/{0}/tasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["groupId"] = SourceExpressionConverter.ConvertO(groupId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListTasksResponseV2>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListTasksResponseV2> OnTaskAssignedToMe(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/me/planner/ontaskassignedtome_trigger/tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListTasksResponseV2>(BuildSourceInput, triggerName, recurrence);
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