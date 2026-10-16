//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Acceptmission
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AcceptmissionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetcategoriesResponseItem[]> Getcategories()
        {
            var apiCallPath = "/general/v1/categories";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetcategoriesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PostcategoriesResponse> Postcategories(Expression<Func<string>> bodytitle = null, Expression<Func<int>> bodyposition = null, Expression<Func<string>> bodychipColor = null, Expression<Func<string>> bodymissionsId = null, Expression<Func<int>> bodycompanyId = null, Expression<Func<string>> bodyimage = null, Expression<Func<int>> bodyuserId = null, Expression<Func<string>> bodytempImage = null, Expression<Func<string>> bodymainImage = null, Expression<Func<string>> bodyimageConfigs = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string>> bodyupdatedBy = null, Expression<Func<string>> bodyrecordUrl = null, Expression<Func<string>> bodysyncId = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            var __workflow_bodychipColor = WorkflowExpression.Compile(bodychipColor, nameof(bodychipColor), required: false);
            var __workflow_bodymissionsId = WorkflowExpression.Compile(bodymissionsId, nameof(bodymissionsId), required: false);
            var __workflow_bodycompanyId = WorkflowExpression.Compile(bodycompanyId, nameof(bodycompanyId), required: false);
            var __workflow_bodyimage = WorkflowExpression.Compile(bodyimage, nameof(bodyimage), required: false);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
            var __workflow_bodytempImage = WorkflowExpression.Compile(bodytempImage, nameof(bodytempImage), required: false);
            var __workflow_bodymainImage = WorkflowExpression.Compile(bodymainImage, nameof(bodymainImage), required: false);
            var __workflow_bodyimageConfigs = WorkflowExpression.Compile(bodyimageConfigs, nameof(bodyimageConfigs), required: false);
            var __workflow_bodyownerId = WorkflowExpression.Compile(bodyownerId, nameof(bodyownerId), required: false);
            var __workflow_bodyupdatedBy = WorkflowExpression.Compile(bodyupdatedBy, nameof(bodyupdatedBy), required: false);
            var __workflow_bodyrecordUrl = WorkflowExpression.Compile(bodyrecordUrl, nameof(bodyrecordUrl), required: false);
            var __workflow_bodysyncId = WorkflowExpression.Compile(bodysyncId, nameof(bodysyncId), required: false);
            return new DeferredBodyAction<PostcategoriesResponse>(() =>
            {
                var apiCallPath = "/general/v1/categories";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (__workflow_bodychipColor != null)
                {
                    body["chip_color"] = ExpressionConverter.ConvertO(__workflow_bodychipColor);
                    bodypropCount++;
                }

                if (__workflow_bodymissionsId != null)
                {
                    body["missions_id"] = ExpressionConverter.ConvertO(__workflow_bodymissionsId);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyId != null)
                {
                    body["company_id"] = ExpressionConverter.ConvertO(__workflow_bodycompanyId);
                    bodypropCount++;
                }

                if (__workflow_bodyimage != null)
                {
                    body["image"] = ExpressionConverter.ConvertO(__workflow_bodyimage);
                    bodypropCount++;
                }

                if (__workflow_bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (__workflow_bodytempImage != null)
                {
                    body["temp_image"] = ExpressionConverter.ConvertO(__workflow_bodytempImage);
                    bodypropCount++;
                }

                if (__workflow_bodymainImage != null)
                {
                    body["main_image"] = ExpressionConverter.ConvertO(__workflow_bodymainImage);
                    bodypropCount++;
                }

                if (__workflow_bodyimageConfigs != null)
                {
                    body["image_configs"] = ExpressionConverter.ConvertO(__workflow_bodyimageConfigs);
                    bodypropCount++;
                }

                if (__workflow_bodyownerId != null)
                {
                    body["owner_id"] = ExpressionConverter.ConvertO(__workflow_bodyownerId);
                    bodypropCount++;
                }

                if (__workflow_bodyupdatedBy != null)
                {
                    body["updated_by"] = ExpressionConverter.ConvertO(__workflow_bodyupdatedBy);
                    bodypropCount++;
                }

                if (__workflow_bodyrecordUrl != null)
                {
                    body["record_url"] = ExpressionConverter.ConvertO(__workflow_bodyrecordUrl);
                    bodypropCount++;
                }

                if (__workflow_bodysyncId != null)
                {
                    body["sync_id"] = ExpressionConverter.ConvertO(__workflow_bodysyncId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostcategoriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetcategoriesIdResponse> GetcategoriesId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetcategoriesIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/categories/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetcategoriesIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeletecategoriesId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/categories/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PutcategoriesIdResponse> PutcategoriesId(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<int>> bodyposition = null, Expression<Func<string>> bodychipColor = null, Expression<Func<string>> bodymissionsId = null, Expression<Func<int>> bodycompanyId = null, Expression<Func<string>> bodyimage = null, Expression<Func<int>> bodyuserId = null, Expression<Func<string>> bodytempImage = null, Expression<Func<string>> bodymainImage = null, Expression<Func<string>> bodyimageConfigs = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string>> bodyupdatedBy = null, Expression<Func<string>> bodyrecordUrl = null, Expression<Func<string>> bodysyncId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            var __workflow_bodychipColor = WorkflowExpression.Compile(bodychipColor, nameof(bodychipColor), required: false);
            var __workflow_bodymissionsId = WorkflowExpression.Compile(bodymissionsId, nameof(bodymissionsId), required: false);
            var __workflow_bodycompanyId = WorkflowExpression.Compile(bodycompanyId, nameof(bodycompanyId), required: false);
            var __workflow_bodyimage = WorkflowExpression.Compile(bodyimage, nameof(bodyimage), required: false);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
            var __workflow_bodytempImage = WorkflowExpression.Compile(bodytempImage, nameof(bodytempImage), required: false);
            var __workflow_bodymainImage = WorkflowExpression.Compile(bodymainImage, nameof(bodymainImage), required: false);
            var __workflow_bodyimageConfigs = WorkflowExpression.Compile(bodyimageConfigs, nameof(bodyimageConfigs), required: false);
            var __workflow_bodyownerId = WorkflowExpression.Compile(bodyownerId, nameof(bodyownerId), required: false);
            var __workflow_bodyupdatedBy = WorkflowExpression.Compile(bodyupdatedBy, nameof(bodyupdatedBy), required: false);
            var __workflow_bodyrecordUrl = WorkflowExpression.Compile(bodyrecordUrl, nameof(bodyrecordUrl), required: false);
            var __workflow_bodysyncId = WorkflowExpression.Compile(bodysyncId, nameof(bodysyncId), required: false);
            return new DeferredBodyAction<PutcategoriesIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/categories/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (__workflow_bodychipColor != null)
                {
                    body["chip_color"] = ExpressionConverter.ConvertO(__workflow_bodychipColor);
                    bodypropCount++;
                }

                if (__workflow_bodymissionsId != null)
                {
                    body["missions_id"] = ExpressionConverter.ConvertO(__workflow_bodymissionsId);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyId != null)
                {
                    body["company_id"] = ExpressionConverter.ConvertO(__workflow_bodycompanyId);
                    bodypropCount++;
                }

                if (__workflow_bodyimage != null)
                {
                    body["image"] = ExpressionConverter.ConvertO(__workflow_bodyimage);
                    bodypropCount++;
                }

                if (__workflow_bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (__workflow_bodytempImage != null)
                {
                    body["temp_image"] = ExpressionConverter.ConvertO(__workflow_bodytempImage);
                    bodypropCount++;
                }

                if (__workflow_bodymainImage != null)
                {
                    body["main_image"] = ExpressionConverter.ConvertO(__workflow_bodymainImage);
                    bodypropCount++;
                }

                if (__workflow_bodyimageConfigs != null)
                {
                    body["image_configs"] = ExpressionConverter.ConvertO(__workflow_bodyimageConfigs);
                    bodypropCount++;
                }

                if (__workflow_bodyownerId != null)
                {
                    body["owner_id"] = ExpressionConverter.ConvertO(__workflow_bodyownerId);
                    bodypropCount++;
                }

                if (__workflow_bodyupdatedBy != null)
                {
                    body["updated_by"] = ExpressionConverter.ConvertO(__workflow_bodyupdatedBy);
                    bodypropCount++;
                }

                if (__workflow_bodyrecordUrl != null)
                {
                    body["record_url"] = ExpressionConverter.ConvertO(__workflow_bodyrecordUrl);
                    bodypropCount++;
                }

                if (__workflow_bodysyncId != null)
                {
                    body["sync_id"] = ExpressionConverter.ConvertO(__workflow_bodysyncId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PutcategoriesIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchcategoriesIdResponse> PatchcategoriesId(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            return new DeferredBodyAction<PatchcategoriesIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/categories/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PatchcategoriesIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetdepartmentsResponse> Getdepartments()
        {
            var apiCallPath = "/general/v1/departments";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetdepartmentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PostdepartmentsResponse> Postdepartments(Expression<Func<string>> bodytitle = null, Expression<Func<int>> bodyposition = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            return new DeferredBodyAction<PostdepartmentsResponse>(() =>
            {
                var apiCallPath = "/general/v1/departments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostdepartmentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetdepartmentsIdResponse> GetdepartmentsId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetdepartmentsIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/departments/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetdepartmentsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeletedepartmentsId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/departments/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PutdepartmentsIdResponse> PutdepartmentsId(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<int>> bodyposition = null, Expression<Func<int>> bodycompanyId = null, Expression<Func<int>> bodyideasCount = null, Expression<Func<int>> bodyprojectsCount = null, Expression<Func<string>> bodyimage = null, Expression<Func<int>> bodyuserId = null, Expression<Func<string>> bodytempImage = null, Expression<Func<string>> bodymainImage = null, Expression<Func<string>> bodyimageConfigs = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string>> bodyupdatedBy = null, Expression<Func<string>> bodyrecordUrl = null, Expression<Func<string>> bodysyncId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            var __workflow_bodycompanyId = WorkflowExpression.Compile(bodycompanyId, nameof(bodycompanyId), required: false);
            var __workflow_bodyideasCount = WorkflowExpression.Compile(bodyideasCount, nameof(bodyideasCount), required: false);
            var __workflow_bodyprojectsCount = WorkflowExpression.Compile(bodyprojectsCount, nameof(bodyprojectsCount), required: false);
            var __workflow_bodyimage = WorkflowExpression.Compile(bodyimage, nameof(bodyimage), required: false);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
            var __workflow_bodytempImage = WorkflowExpression.Compile(bodytempImage, nameof(bodytempImage), required: false);
            var __workflow_bodymainImage = WorkflowExpression.Compile(bodymainImage, nameof(bodymainImage), required: false);
            var __workflow_bodyimageConfigs = WorkflowExpression.Compile(bodyimageConfigs, nameof(bodyimageConfigs), required: false);
            var __workflow_bodyownerId = WorkflowExpression.Compile(bodyownerId, nameof(bodyownerId), required: false);
            var __workflow_bodyupdatedBy = WorkflowExpression.Compile(bodyupdatedBy, nameof(bodyupdatedBy), required: false);
            var __workflow_bodyrecordUrl = WorkflowExpression.Compile(bodyrecordUrl, nameof(bodyrecordUrl), required: false);
            var __workflow_bodysyncId = WorkflowExpression.Compile(bodysyncId, nameof(bodysyncId), required: false);
            return new DeferredBodyAction<PutdepartmentsIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/departments/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyId != null)
                {
                    body["company_id"] = ExpressionConverter.ConvertO(__workflow_bodycompanyId);
                    bodypropCount++;
                }

                if (__workflow_bodyideasCount != null)
                {
                    body["ideas_count"] = ExpressionConverter.ConvertO(__workflow_bodyideasCount);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectsCount != null)
                {
                    body["projects_count"] = ExpressionConverter.ConvertO(__workflow_bodyprojectsCount);
                    bodypropCount++;
                }

                if (__workflow_bodyimage != null)
                {
                    body["image"] = ExpressionConverter.ConvertO(__workflow_bodyimage);
                    bodypropCount++;
                }

                if (__workflow_bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (__workflow_bodytempImage != null)
                {
                    body["temp_image"] = ExpressionConverter.ConvertO(__workflow_bodytempImage);
                    bodypropCount++;
                }

                if (__workflow_bodymainImage != null)
                {
                    body["main_image"] = ExpressionConverter.ConvertO(__workflow_bodymainImage);
                    bodypropCount++;
                }

                if (__workflow_bodyimageConfigs != null)
                {
                    body["image_configs"] = ExpressionConverter.ConvertO(__workflow_bodyimageConfigs);
                    bodypropCount++;
                }

                if (__workflow_bodyownerId != null)
                {
                    body["owner_id"] = ExpressionConverter.ConvertO(__workflow_bodyownerId);
                    bodypropCount++;
                }

                if (__workflow_bodyupdatedBy != null)
                {
                    body["updated_by"] = ExpressionConverter.ConvertO(__workflow_bodyupdatedBy);
                    bodypropCount++;
                }

                if (__workflow_bodyrecordUrl != null)
                {
                    body["record_url"] = ExpressionConverter.ConvertO(__workflow_bodyrecordUrl);
                    bodypropCount++;
                }

                if (__workflow_bodysyncId != null)
                {
                    body["sync_id"] = ExpressionConverter.ConvertO(__workflow_bodysyncId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PutdepartmentsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchdepartmentsIdResponse> PatchdepartmentsId(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<int>> bodyposition = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            return new DeferredBodyAction<PatchdepartmentsIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/departments/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PatchdepartmentsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetfunnelLanesResponse> GetfunnelLanes()
        {
            var apiCallPath = "/general/v1/funnel_lanes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetfunnelLanesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PostfunnelLanesResponse> PostfunnelLanes(Expression<Func<string>> bodytitle = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            return new DeferredBodyAction<PostfunnelLanesResponse>(() =>
            {
                var apiCallPath = "/general/v1/funnel_lanes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostfunnelLanesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetfunnelLanesIdResponse> GetfunnelLanesId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetfunnelLanesIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/funnel_lanes/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetfunnelLanesIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeletefunnelLanesId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/funnel_lanes/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PutfunnelLanesIdResponse> PutfunnelLanesId(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<int>> bodyfunnelStageType = null, Expression<Func<int>> bodystageType = null, Expression<Func<string>> bodycolor = null, Expression<Func<int>> bodydeadline = null, Expression<Func<int>> bodyposition = null, Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodymodifiedBy = null, Expression<Func<int>> bodyfunnelId = null, Expression<Func<int>> bodyfunnelStatusId = null, Expression<Func<int>> bodyownerId = null, Expression<Func<bool>> bodyenableNotification = null, Expression<Func<int>> bodyideasCount = null, Expression<Func<int>> bodyprojectsCount = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodylink = null, Expression<Func<string>> bodyfile = null, Expression<Func<bool>> bodyshowInGraph = null, Expression<Func<bool>> bodyshowInBubble = null, Expression<Func<int>> bodyconfettiType = null, Expression<Func<string>> bodyautomationOwnerId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyfunnelStageType = WorkflowExpression.Compile(bodyfunnelStageType, nameof(bodyfunnelStageType), required: false);
            var __workflow_bodystageType = WorkflowExpression.Compile(bodystageType, nameof(bodystageType), required: false);
            var __workflow_bodycolor = WorkflowExpression.Compile(bodycolor, nameof(bodycolor), required: false);
            var __workflow_bodydeadline = WorkflowExpression.Compile(bodydeadline, nameof(bodydeadline), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
            var __workflow_bodymodifiedBy = WorkflowExpression.Compile(bodymodifiedBy, nameof(bodymodifiedBy), required: false);
            var __workflow_bodyfunnelId = WorkflowExpression.Compile(bodyfunnelId, nameof(bodyfunnelId), required: false);
            var __workflow_bodyfunnelStatusId = WorkflowExpression.Compile(bodyfunnelStatusId, nameof(bodyfunnelStatusId), required: false);
            var __workflow_bodyownerId = WorkflowExpression.Compile(bodyownerId, nameof(bodyownerId), required: false);
            var __workflow_bodyenableNotification = WorkflowExpression.Compile(bodyenableNotification, nameof(bodyenableNotification), required: false);
            var __workflow_bodyideasCount = WorkflowExpression.Compile(bodyideasCount, nameof(bodyideasCount), required: false);
            var __workflow_bodyprojectsCount = WorkflowExpression.Compile(bodyprojectsCount, nameof(bodyprojectsCount), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodylink = WorkflowExpression.Compile(bodylink, nameof(bodylink), required: false);
            var __workflow_bodyfile = WorkflowExpression.Compile(bodyfile, nameof(bodyfile), required: false);
            var __workflow_bodyshowInGraph = WorkflowExpression.Compile(bodyshowInGraph, nameof(bodyshowInGraph), required: false);
            var __workflow_bodyshowInBubble = WorkflowExpression.Compile(bodyshowInBubble, nameof(bodyshowInBubble), required: false);
            var __workflow_bodyconfettiType = WorkflowExpression.Compile(bodyconfettiType, nameof(bodyconfettiType), required: false);
            var __workflow_bodyautomationOwnerId = WorkflowExpression.Compile(bodyautomationOwnerId, nameof(bodyautomationOwnerId), required: false);
            return new DeferredBodyAction<PutfunnelLanesIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/funnel_lanes/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyfunnelStageType != null)
                {
                    body["funnel_stage_type"] = ExpressionConverter.ConvertO(__workflow_bodyfunnelStageType);
                    bodypropCount++;
                }

                if (__workflow_bodystageType != null)
                {
                    body["stage_type"] = ExpressionConverter.ConvertO(__workflow_bodystageType);
                    bodypropCount++;
                }

                if (__workflow_bodycolor != null)
                {
                    body["color"] = ExpressionConverter.ConvertO(__workflow_bodycolor);
                    bodypropCount++;
                }

                if (__workflow_bodydeadline != null)
                {
                    body["deadline"] = ExpressionConverter.ConvertO(__workflow_bodydeadline);
                    bodypropCount++;
                }

                if (__workflow_bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (__workflow_bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (__workflow_bodymodifiedBy != null)
                {
                    body["modified_by"] = ExpressionConverter.ConvertO(__workflow_bodymodifiedBy);
                    bodypropCount++;
                }

                if (__workflow_bodyfunnelId != null)
                {
                    body["funnel_id"] = ExpressionConverter.ConvertO(__workflow_bodyfunnelId);
                    bodypropCount++;
                }

                if (__workflow_bodyfunnelStatusId != null)
                {
                    body["funnel_status_id"] = ExpressionConverter.ConvertO(__workflow_bodyfunnelStatusId);
                    bodypropCount++;
                }

                if (__workflow_bodyownerId != null)
                {
                    body["owner_id"] = ExpressionConverter.ConvertO(__workflow_bodyownerId);
                    bodypropCount++;
                }

                if (__workflow_bodyenableNotification != null)
                {
                    body["enable_notification"] = ExpressionConverter.ConvertO(__workflow_bodyenableNotification);
                    bodypropCount++;
                }

                if (__workflow_bodyideasCount != null)
                {
                    body["ideas_count"] = ExpressionConverter.ConvertO(__workflow_bodyideasCount);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectsCount != null)
                {
                    body["projects_count"] = ExpressionConverter.ConvertO(__workflow_bodyprojectsCount);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodylink != null)
                {
                    body["link"] = ExpressionConverter.ConvertO(__workflow_bodylink);
                    bodypropCount++;
                }

                if (__workflow_bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyfile);
                    bodypropCount++;
                }

                if (__workflow_bodyshowInGraph != null)
                {
                    body["show_in_graph"] = ExpressionConverter.ConvertO(__workflow_bodyshowInGraph);
                    bodypropCount++;
                }

                if (__workflow_bodyshowInBubble != null)
                {
                    body["show_in_bubble"] = ExpressionConverter.ConvertO(__workflow_bodyshowInBubble);
                    bodypropCount++;
                }

                if (__workflow_bodyconfettiType != null)
                {
                    body["confetti_type"] = ExpressionConverter.ConvertO(__workflow_bodyconfettiType);
                    bodypropCount++;
                }

                if (__workflow_bodyautomationOwnerId != null)
                {
                    body["automation_owner_id"] = ExpressionConverter.ConvertO(__workflow_bodyautomationOwnerId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PutfunnelLanesIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchfunnelLanesIdResponse> PatchfunnelLanesId(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            return new DeferredBodyAction<PatchfunnelLanesIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/funnel_lanes/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PatchfunnelLanesIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetfunnelsResponse> Getfunnels()
        {
            var apiCallPath = "/general/v1/funnels";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetfunnelsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction Postfunnels(Expression<Func<string>> bodytitle = null, Expression<Func<int>> bodyfunnelType = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyfunnelType = WorkflowExpression.Compile(bodyfunnelType, nameof(bodyfunnelType), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/general/v1/funnels";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyfunnelType != null)
                {
                    body["funnel_type"] = ExpressionConverter.ConvertO(__workflow_bodyfunnelType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetfunnelsIdResponse> GetfunnelsId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetfunnelsIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/funnels/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetfunnelsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeletefunnelsId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/funnels/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction PutfunnelsId(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<int>> bodycompanyId = null, Expression<Func<int>> bodyuserId = null, Expression<Func<int>> bodyfunnelType = null, Expression<Func<int>> bodymodifiedBy = null, Expression<Func<int>> bodyprivacySetting = null, Expression<Func<int>> bodyownerId = null, Expression<Func<bool>> bodyblockFunnelNotification = null, Expression<Func<int>> bodyideasCount = null, Expression<Func<int>> bodyprojectsCount = null, Expression<Func<bool>> bodyhidden = null, Expression<Func<string>> bodysetXAxis = null, Expression<Func<string>> bodysetYAxis = null, Expression<Func<string>> bodysetZAxis = null, Expression<Func<string>> bodysetAxisColor = null, Expression<Func<string>> bodydepartmentId = null, Expression<Func<int>> bodyprojectFunnelId = null, Expression<Func<string>> bodyfromScript = null, Expression<Func<int>> bodyuserPrivacySetting = null, Expression<Func<bool>> bodyincludeInDashboard = null, Expression<Func<string>> bodyrecordUrl = null, Expression<Func<string>> bodysyncId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodycompanyId = WorkflowExpression.Compile(bodycompanyId, nameof(bodycompanyId), required: false);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
            var __workflow_bodyfunnelType = WorkflowExpression.Compile(bodyfunnelType, nameof(bodyfunnelType), required: false);
            var __workflow_bodymodifiedBy = WorkflowExpression.Compile(bodymodifiedBy, nameof(bodymodifiedBy), required: false);
            var __workflow_bodyprivacySetting = WorkflowExpression.Compile(bodyprivacySetting, nameof(bodyprivacySetting), required: false);
            var __workflow_bodyownerId = WorkflowExpression.Compile(bodyownerId, nameof(bodyownerId), required: false);
            var __workflow_bodyblockFunnelNotification = WorkflowExpression.Compile(bodyblockFunnelNotification, nameof(bodyblockFunnelNotification), required: false);
            var __workflow_bodyideasCount = WorkflowExpression.Compile(bodyideasCount, nameof(bodyideasCount), required: false);
            var __workflow_bodyprojectsCount = WorkflowExpression.Compile(bodyprojectsCount, nameof(bodyprojectsCount), required: false);
            var __workflow_bodyhidden = WorkflowExpression.Compile(bodyhidden, nameof(bodyhidden), required: false);
            var __workflow_bodysetXAxis = WorkflowExpression.Compile(bodysetXAxis, nameof(bodysetXAxis), required: false);
            var __workflow_bodysetYAxis = WorkflowExpression.Compile(bodysetYAxis, nameof(bodysetYAxis), required: false);
            var __workflow_bodysetZAxis = WorkflowExpression.Compile(bodysetZAxis, nameof(bodysetZAxis), required: false);
            var __workflow_bodysetAxisColor = WorkflowExpression.Compile(bodysetAxisColor, nameof(bodysetAxisColor), required: false);
            var __workflow_bodydepartmentId = WorkflowExpression.Compile(bodydepartmentId, nameof(bodydepartmentId), required: false);
            var __workflow_bodyprojectFunnelId = WorkflowExpression.Compile(bodyprojectFunnelId, nameof(bodyprojectFunnelId), required: false);
            var __workflow_bodyfromScript = WorkflowExpression.Compile(bodyfromScript, nameof(bodyfromScript), required: false);
            var __workflow_bodyuserPrivacySetting = WorkflowExpression.Compile(bodyuserPrivacySetting, nameof(bodyuserPrivacySetting), required: false);
            var __workflow_bodyincludeInDashboard = WorkflowExpression.Compile(bodyincludeInDashboard, nameof(bodyincludeInDashboard), required: false);
            var __workflow_bodyrecordUrl = WorkflowExpression.Compile(bodyrecordUrl, nameof(bodyrecordUrl), required: false);
            var __workflow_bodysyncId = WorkflowExpression.Compile(bodysyncId, nameof(bodysyncId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/funnels/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyId != null)
                {
                    body["company_id"] = ExpressionConverter.ConvertO(__workflow_bodycompanyId);
                    bodypropCount++;
                }

                if (__workflow_bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (__workflow_bodyfunnelType != null)
                {
                    body["funnel_type"] = ExpressionConverter.ConvertO(__workflow_bodyfunnelType);
                    bodypropCount++;
                }

                if (__workflow_bodymodifiedBy != null)
                {
                    body["modified_by"] = ExpressionConverter.ConvertO(__workflow_bodymodifiedBy);
                    bodypropCount++;
                }

                if (__workflow_bodyprivacySetting != null)
                {
                    body["privacy_setting"] = ExpressionConverter.ConvertO(__workflow_bodyprivacySetting);
                    bodypropCount++;
                }

                if (__workflow_bodyownerId != null)
                {
                    body["owner_id"] = ExpressionConverter.ConvertO(__workflow_bodyownerId);
                    bodypropCount++;
                }

                if (__workflow_bodyblockFunnelNotification != null)
                {
                    body["block_funnel_notification"] = ExpressionConverter.ConvertO(__workflow_bodyblockFunnelNotification);
                    bodypropCount++;
                }

                if (__workflow_bodyideasCount != null)
                {
                    body["ideas_count"] = ExpressionConverter.ConvertO(__workflow_bodyideasCount);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectsCount != null)
                {
                    body["projects_count"] = ExpressionConverter.ConvertO(__workflow_bodyprojectsCount);
                    bodypropCount++;
                }

                if (__workflow_bodyhidden != null)
                {
                    body["hidden"] = ExpressionConverter.ConvertO(__workflow_bodyhidden);
                    bodypropCount++;
                }

                if (__workflow_bodysetXAxis != null)
                {
                    body["set_x_axis"] = ExpressionConverter.ConvertO(__workflow_bodysetXAxis);
                    bodypropCount++;
                }

                if (__workflow_bodysetYAxis != null)
                {
                    body["set_y_axis"] = ExpressionConverter.ConvertO(__workflow_bodysetYAxis);
                    bodypropCount++;
                }

                if (__workflow_bodysetZAxis != null)
                {
                    body["set_z_axis"] = ExpressionConverter.ConvertO(__workflow_bodysetZAxis);
                    bodypropCount++;
                }

                if (__workflow_bodysetAxisColor != null)
                {
                    body["set_axis_color"] = ExpressionConverter.ConvertO(__workflow_bodysetAxisColor);
                    bodypropCount++;
                }

                if (__workflow_bodydepartmentId != null)
                {
                    body["department_id"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentId);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectFunnelId != null)
                {
                    body["project_funnel_id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectFunnelId);
                    bodypropCount++;
                }

                if (__workflow_bodyfromScript != null)
                {
                    body["from_script"] = ExpressionConverter.ConvertO(__workflow_bodyfromScript);
                    bodypropCount++;
                }

                if (__workflow_bodyuserPrivacySetting != null)
                {
                    body["user_privacy_setting"] = ExpressionConverter.ConvertO(__workflow_bodyuserPrivacySetting);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeInDashboard != null)
                {
                    body["include_in_dashboard"] = ExpressionConverter.ConvertO(__workflow_bodyincludeInDashboard);
                    bodypropCount++;
                }

                if (__workflow_bodyrecordUrl != null)
                {
                    body["record_url"] = ExpressionConverter.ConvertO(__workflow_bodyrecordUrl);
                    bodypropCount++;
                }

                if (__workflow_bodysyncId != null)
                {
                    body["sync_id"] = ExpressionConverter.ConvertO(__workflow_bodysyncId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchfunnelsIdResponse> PatchfunnelsId(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<int>> bodyfunnelType = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyfunnelType = WorkflowExpression.Compile(bodyfunnelType, nameof(bodyfunnelType), required: false);
            return new DeferredBodyAction<PatchfunnelsIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/funnels/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyfunnelType != null)
                {
                    body["funnel_type"] = ExpressionConverter.ConvertO(__workflow_bodyfunnelType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PatchfunnelsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetideasResponse> Getideas()
        {
            var apiCallPath = "/general/v1/ideas";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetideasResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction Postideas(Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodycontent = null, Expression<Func<int>> bodyfunnelId = null, Expression<Func<int>> bodymissionId = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodycontent = WorkflowExpression.Compile(bodycontent, nameof(bodycontent), required: false);
            var __workflow_bodyfunnelId = WorkflowExpression.Compile(bodyfunnelId, nameof(bodyfunnelId), required: false);
            var __workflow_bodymissionId = WorkflowExpression.Compile(bodymissionId, nameof(bodymissionId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/general/v1/ideas";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(__workflow_bodycontent);
                    bodypropCount++;
                }

                if (__workflow_bodyfunnelId != null)
                {
                    body["funnel_id"] = ExpressionConverter.ConvertO(__workflow_bodyfunnelId);
                    bodypropCount++;
                }

                if (__workflow_bodymissionId != null)
                {
                    body["mission_id"] = ExpressionConverter.ConvertO(__workflow_bodymissionId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetideasIdeaIdTasksResponse> GetideasIdeaIdTasks(Expression<Func<string>> ideaId)
        {
            var __workflow_ideaId = WorkflowExpression.Compile(ideaId, nameof(ideaId), required: true);
            return new DeferredBodyAction<GetideasIdeaIdTasksResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/ideas/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(__workflow_ideaId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetideasIdeaIdTasksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PostideasIdeaIdTasksResponse> PostideasIdeaIdTasks(Expression<Func<string>> ideaId, Expression<Func<string>> bodytitle = null, Expression<Func<int>> bodystatus = null)
        {
            var __workflow_ideaId = WorkflowExpression.Compile(ideaId, nameof(ideaId), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<PostideasIdeaIdTasksResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/ideas/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(__workflow_ideaId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostideasIdeaIdTasksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction GetideasId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/ideas/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeleteideasId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/ideas/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction PutideasId(Expression<Func<string>> id, Expression<Func<int>> bodyuserId = null, Expression<Func<int>> bodyroundId = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodycontent = null, Expression<Func<string>> bodyimage = null, Expression<Func<string>> bodydevice = null, Expression<Func<string>> bodybrowser = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodyscreenRes = null, Expression<Func<string>> bodyuserIp = null, Expression<Func<int>> bodycommentsCount = null, Expression<Func<int>> bodyreviewScoresCount = null, Expression<Func<string>> bodyslug = null, Expression<Func<int>> bodystage = null, Expression<Func<string>> bodydepartmentId = null, Expression<Func<string>> bodystatusId = null, Expression<Func<string>> bodyposition = null, Expression<Func<string>> bodyprojectId = null, Expression<Func<string>> bodyideaCreator = null, Expression<Func<string>> bodyideationIdeaCategoryId = null, Expression<Func<string>> bodyboardIdeaCategoryId = null, Expression<Func<int>> bodycompanyId = null, Expression<Func<int>> bodyideaLikesCount = null, Expression<Func<bool>> bodybookmark = null, Expression<Func<int>> bodyideaScoresCount = null, Expression<Func<int>> bodylikesCount = null, Expression<Func<string>> bodyboardId = null, Expression<Func<string>> bodymissionId = null, Expression<Func<string>> bodycreatorName = null, Expression<Func<int>> bodytagsCount = null, Expression<Func<string>> bodyfunnelId = null, Expression<Func<string>> bodyfunnelStageId = null, Expression<Func<string>> bodyfunnelStatusId = null, Expression<Func<string>> bodyideaDeadline = null, Expression<Func<bool>> bodydeadlineNotification = null, Expression<Func<int>> bodyideaViews = null, Expression<Func<string>> bodyrevenue = null, Expression<Func<string>> bodycost = null, Expression<Func<string>> bodyprofit = null, Expression<Func<string>> bodystatusName = null, Expression<Func<string>> bodyideaScores = null, Expression<Func<string>> bodyapprovedAt = null, Expression<Func<string>> bodydeniedAt = null, Expression<Func<string>> bodyadminComments = null, Expression<Func<bool>> bodyisChild = null, Expression<Func<string>> bodyparentId = null, Expression<Func<string>> bodytempImage = null, Expression<Func<string>> bodymainImage = null, Expression<Func<string>> bodyimageConfigs = null, Expression<Func<int>> bodyscoreCompleteScore = null, Expression<Func<int>> bodyenrichmentScore = null, Expression<Func<int>> bodyengagementScore = null, Expression<Func<int>> bodyopportunityScore = null, Expression<Func<int>> bodytrendScore = null, Expression<Func<string>> bodycleanedText = null, Expression<Func<int>> bodyduplicateIdeasCount = null, Expression<Func<string>> bodysidekiqDuplicateIdeasCount = null, Expression<Func<string>> bodyaiCreated = null, Expression<Func<string>> bodyideaType = null, Expression<Func<string>> bodyfromScript = null, Expression<Func<string>> bodyembedding = null, Expression<Func<string>> bodyreasonText = null, Expression<Func<string>> bodycategoryText = null, Expression<Func<string>> bodycanvassId = null, Expression<Func<string>> bodybudgetTotal = null, Expression<Func<string>> bodybudgetSpend = null, Expression<Func<string>> bodybudgetResult = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodytagText = null, Expression<Func<string>> bodyinnovationTypeId = null, Expression<Func<string>> bodyinnovationTypeText = null, Expression<Func<string>> bodysyncId = null, Expression<Func<string>> bodyrecordUrl = null, Expression<Func<string>> bodydescriptionEnriched = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
            var __workflow_bodyroundId = WorkflowExpression.Compile(bodyroundId, nameof(bodyroundId), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodycontent = WorkflowExpression.Compile(bodycontent, nameof(bodycontent), required: false);
            var __workflow_bodyimage = WorkflowExpression.Compile(bodyimage, nameof(bodyimage), required: false);
            var __workflow_bodydevice = WorkflowExpression.Compile(bodydevice, nameof(bodydevice), required: false);
            var __workflow_bodybrowser = WorkflowExpression.Compile(bodybrowser, nameof(bodybrowser), required: false);
            var __workflow_bodyaddress = WorkflowExpression.Compile(bodyaddress, nameof(bodyaddress), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodystate = WorkflowExpression.Compile(bodystate, nameof(bodystate), required: false);
            var __workflow_bodypostalCode = WorkflowExpression.Compile(bodypostalCode, nameof(bodypostalCode), required: false);
            var __workflow_bodycountry = WorkflowExpression.Compile(bodycountry, nameof(bodycountry), required: false);
            var __workflow_bodyscreenRes = WorkflowExpression.Compile(bodyscreenRes, nameof(bodyscreenRes), required: false);
            var __workflow_bodyuserIp = WorkflowExpression.Compile(bodyuserIp, nameof(bodyuserIp), required: false);
            var __workflow_bodycommentsCount = WorkflowExpression.Compile(bodycommentsCount, nameof(bodycommentsCount), required: false);
            var __workflow_bodyreviewScoresCount = WorkflowExpression.Compile(bodyreviewScoresCount, nameof(bodyreviewScoresCount), required: false);
            var __workflow_bodyslug = WorkflowExpression.Compile(bodyslug, nameof(bodyslug), required: false);
            var __workflow_bodystage = WorkflowExpression.Compile(bodystage, nameof(bodystage), required: false);
            var __workflow_bodydepartmentId = WorkflowExpression.Compile(bodydepartmentId, nameof(bodydepartmentId), required: false);
            var __workflow_bodystatusId = WorkflowExpression.Compile(bodystatusId, nameof(bodystatusId), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: false);
            var __workflow_bodyideaCreator = WorkflowExpression.Compile(bodyideaCreator, nameof(bodyideaCreator), required: false);
            var __workflow_bodyideationIdeaCategoryId = WorkflowExpression.Compile(bodyideationIdeaCategoryId, nameof(bodyideationIdeaCategoryId), required: false);
            var __workflow_bodyboardIdeaCategoryId = WorkflowExpression.Compile(bodyboardIdeaCategoryId, nameof(bodyboardIdeaCategoryId), required: false);
            var __workflow_bodycompanyId = WorkflowExpression.Compile(bodycompanyId, nameof(bodycompanyId), required: false);
            var __workflow_bodyideaLikesCount = WorkflowExpression.Compile(bodyideaLikesCount, nameof(bodyideaLikesCount), required: false);
            var __workflow_bodybookmark = WorkflowExpression.Compile(bodybookmark, nameof(bodybookmark), required: false);
            var __workflow_bodyideaScoresCount = WorkflowExpression.Compile(bodyideaScoresCount, nameof(bodyideaScoresCount), required: false);
            var __workflow_bodylikesCount = WorkflowExpression.Compile(bodylikesCount, nameof(bodylikesCount), required: false);
            var __workflow_bodyboardId = WorkflowExpression.Compile(bodyboardId, nameof(bodyboardId), required: false);
            var __workflow_bodymissionId = WorkflowExpression.Compile(bodymissionId, nameof(bodymissionId), required: false);
            var __workflow_bodycreatorName = WorkflowExpression.Compile(bodycreatorName, nameof(bodycreatorName), required: false);
            var __workflow_bodytagsCount = WorkflowExpression.Compile(bodytagsCount, nameof(bodytagsCount), required: false);
            var __workflow_bodyfunnelId = WorkflowExpression.Compile(bodyfunnelId, nameof(bodyfunnelId), required: false);
            var __workflow_bodyfunnelStageId = WorkflowExpression.Compile(bodyfunnelStageId, nameof(bodyfunnelStageId), required: false);
            var __workflow_bodyfunnelStatusId = WorkflowExpression.Compile(bodyfunnelStatusId, nameof(bodyfunnelStatusId), required: false);
            var __workflow_bodyideaDeadline = WorkflowExpression.Compile(bodyideaDeadline, nameof(bodyideaDeadline), required: false);
            var __workflow_bodydeadlineNotification = WorkflowExpression.Compile(bodydeadlineNotification, nameof(bodydeadlineNotification), required: false);
            var __workflow_bodyideaViews = WorkflowExpression.Compile(bodyideaViews, nameof(bodyideaViews), required: false);
            var __workflow_bodyrevenue = WorkflowExpression.Compile(bodyrevenue, nameof(bodyrevenue), required: false);
            var __workflow_bodycost = WorkflowExpression.Compile(bodycost, nameof(bodycost), required: false);
            var __workflow_bodyprofit = WorkflowExpression.Compile(bodyprofit, nameof(bodyprofit), required: false);
            var __workflow_bodystatusName = WorkflowExpression.Compile(bodystatusName, nameof(bodystatusName), required: false);
            var __workflow_bodyideaScores = WorkflowExpression.Compile(bodyideaScores, nameof(bodyideaScores), required: false);
            var __workflow_bodyapprovedAt = WorkflowExpression.Compile(bodyapprovedAt, nameof(bodyapprovedAt), required: false);
            var __workflow_bodydeniedAt = WorkflowExpression.Compile(bodydeniedAt, nameof(bodydeniedAt), required: false);
            var __workflow_bodyadminComments = WorkflowExpression.Compile(bodyadminComments, nameof(bodyadminComments), required: false);
            var __workflow_bodyisChild = WorkflowExpression.Compile(bodyisChild, nameof(bodyisChild), required: false);
            var __workflow_bodyparentId = WorkflowExpression.Compile(bodyparentId, nameof(bodyparentId), required: false);
            var __workflow_bodytempImage = WorkflowExpression.Compile(bodytempImage, nameof(bodytempImage), required: false);
            var __workflow_bodymainImage = WorkflowExpression.Compile(bodymainImage, nameof(bodymainImage), required: false);
            var __workflow_bodyimageConfigs = WorkflowExpression.Compile(bodyimageConfigs, nameof(bodyimageConfigs), required: false);
            var __workflow_bodyscoreCompleteScore = WorkflowExpression.Compile(bodyscoreCompleteScore, nameof(bodyscoreCompleteScore), required: false);
            var __workflow_bodyenrichmentScore = WorkflowExpression.Compile(bodyenrichmentScore, nameof(bodyenrichmentScore), required: false);
            var __workflow_bodyengagementScore = WorkflowExpression.Compile(bodyengagementScore, nameof(bodyengagementScore), required: false);
            var __workflow_bodyopportunityScore = WorkflowExpression.Compile(bodyopportunityScore, nameof(bodyopportunityScore), required: false);
            var __workflow_bodytrendScore = WorkflowExpression.Compile(bodytrendScore, nameof(bodytrendScore), required: false);
            var __workflow_bodycleanedText = WorkflowExpression.Compile(bodycleanedText, nameof(bodycleanedText), required: false);
            var __workflow_bodyduplicateIdeasCount = WorkflowExpression.Compile(bodyduplicateIdeasCount, nameof(bodyduplicateIdeasCount), required: false);
            var __workflow_bodysidekiqDuplicateIdeasCount = WorkflowExpression.Compile(bodysidekiqDuplicateIdeasCount, nameof(bodysidekiqDuplicateIdeasCount), required: false);
            var __workflow_bodyaiCreated = WorkflowExpression.Compile(bodyaiCreated, nameof(bodyaiCreated), required: false);
            var __workflow_bodyideaType = WorkflowExpression.Compile(bodyideaType, nameof(bodyideaType), required: false);
            var __workflow_bodyfromScript = WorkflowExpression.Compile(bodyfromScript, nameof(bodyfromScript), required: false);
            var __workflow_bodyembedding = WorkflowExpression.Compile(bodyembedding, nameof(bodyembedding), required: false);
            var __workflow_bodyreasonText = WorkflowExpression.Compile(bodyreasonText, nameof(bodyreasonText), required: false);
            var __workflow_bodycategoryText = WorkflowExpression.Compile(bodycategoryText, nameof(bodycategoryText), required: false);
            var __workflow_bodycanvassId = WorkflowExpression.Compile(bodycanvassId, nameof(bodycanvassId), required: false);
            var __workflow_bodybudgetTotal = WorkflowExpression.Compile(bodybudgetTotal, nameof(bodybudgetTotal), required: false);
            var __workflow_bodybudgetSpend = WorkflowExpression.Compile(bodybudgetSpend, nameof(bodybudgetSpend), required: false);
            var __workflow_bodybudgetResult = WorkflowExpression.Compile(bodybudgetResult, nameof(bodybudgetResult), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodytagText = WorkflowExpression.Compile(bodytagText, nameof(bodytagText), required: false);
            var __workflow_bodyinnovationTypeId = WorkflowExpression.Compile(bodyinnovationTypeId, nameof(bodyinnovationTypeId), required: false);
            var __workflow_bodyinnovationTypeText = WorkflowExpression.Compile(bodyinnovationTypeText, nameof(bodyinnovationTypeText), required: false);
            var __workflow_bodysyncId = WorkflowExpression.Compile(bodysyncId, nameof(bodysyncId), required: false);
            var __workflow_bodyrecordUrl = WorkflowExpression.Compile(bodyrecordUrl, nameof(bodyrecordUrl), required: false);
            var __workflow_bodydescriptionEnriched = WorkflowExpression.Compile(bodydescriptionEnriched, nameof(bodydescriptionEnriched), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/ideas/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (__workflow_bodyroundId != null)
                {
                    body["round_id"] = ExpressionConverter.ConvertO(__workflow_bodyroundId);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(__workflow_bodycontent);
                    bodypropCount++;
                }

                if (__workflow_bodyimage != null)
                {
                    body["image"] = ExpressionConverter.ConvertO(__workflow_bodyimage);
                    bodypropCount++;
                }

                if (__workflow_bodydevice != null)
                {
                    body["device"] = ExpressionConverter.ConvertO(__workflow_bodydevice);
                    bodypropCount++;
                }

                if (__workflow_bodybrowser != null)
                {
                    body["browser"] = ExpressionConverter.ConvertO(__workflow_bodybrowser);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress != null)
                {
                    body["address"] = ExpressionConverter.ConvertO(__workflow_bodyaddress);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodypostalCode != null)
                {
                    body["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodypostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                    bodypropCount++;
                }

                if (__workflow_bodyscreenRes != null)
                {
                    body["screen_res"] = ExpressionConverter.ConvertO(__workflow_bodyscreenRes);
                    bodypropCount++;
                }

                if (__workflow_bodyuserIp != null)
                {
                    body["user_ip"] = ExpressionConverter.ConvertO(__workflow_bodyuserIp);
                    bodypropCount++;
                }

                if (__workflow_bodycommentsCount != null)
                {
                    body["comments_count"] = ExpressionConverter.ConvertO(__workflow_bodycommentsCount);
                    bodypropCount++;
                }

                if (__workflow_bodyreviewScoresCount != null)
                {
                    body["review_scores_count"] = ExpressionConverter.ConvertO(__workflow_bodyreviewScoresCount);
                    bodypropCount++;
                }

                if (__workflow_bodyslug != null)
                {
                    body["slug"] = ExpressionConverter.ConvertO(__workflow_bodyslug);
                    bodypropCount++;
                }

                if (__workflow_bodystage != null)
                {
                    body["stage"] = ExpressionConverter.ConvertO(__workflow_bodystage);
                    bodypropCount++;
                }

                if (__workflow_bodydepartmentId != null)
                {
                    body["department_id"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentId);
                    bodypropCount++;
                }

                if (__workflow_bodystatusId != null)
                {
                    body["status_id"] = ExpressionConverter.ConvertO(__workflow_bodystatusId);
                    bodypropCount++;
                }

                if (__workflow_bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectId != null)
                {
                    body["project_id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                    bodypropCount++;
                }

                if (__workflow_bodyideaCreator != null)
                {
                    body["idea_creator"] = ExpressionConverter.ConvertO(__workflow_bodyideaCreator);
                    bodypropCount++;
                }

                if (__workflow_bodyideationIdeaCategoryId != null)
                {
                    body["ideation_idea_category_id"] = ExpressionConverter.ConvertO(__workflow_bodyideationIdeaCategoryId);
                    bodypropCount++;
                }

                if (__workflow_bodyboardIdeaCategoryId != null)
                {
                    body["board_idea_category_id"] = ExpressionConverter.ConvertO(__workflow_bodyboardIdeaCategoryId);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyId != null)
                {
                    body["company_id"] = ExpressionConverter.ConvertO(__workflow_bodycompanyId);
                    bodypropCount++;
                }

                if (__workflow_bodyideaLikesCount != null)
                {
                    body["idea_likes_count"] = ExpressionConverter.ConvertO(__workflow_bodyideaLikesCount);
                    bodypropCount++;
                }

                if (__workflow_bodybookmark != null)
                {
                    body["bookmark"] = ExpressionConverter.ConvertO(__workflow_bodybookmark);
                    bodypropCount++;
                }

                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                if (__workflow_bodyideaScoresCount != null)
                {
                    body["idea_scores_count"] = ExpressionConverter.ConvertO(__workflow_bodyideaScoresCount);
                    bodypropCount++;
                }

                if (__workflow_bodylikesCount != null)
                {
                    body["likes_count"] = ExpressionConverter.ConvertO(__workflow_bodylikesCount);
                    bodypropCount++;
                }

                if (__workflow_bodyboardId != null)
                {
                    body["board_id"] = ExpressionConverter.ConvertO(__workflow_bodyboardId);
                    bodypropCount++;
                }

                if (__workflow_bodymissionId != null)
                {
                    body["mission_id"] = ExpressionConverter.ConvertO(__workflow_bodymissionId);
                    bodypropCount++;
                }

                if (__workflow_bodycreatorName != null)
                {
                    body["creator_name"] = ExpressionConverter.ConvertO(__workflow_bodycreatorName);
                    bodypropCount++;
                }

                if (__workflow_bodytagsCount != null)
                {
                    body["tags_count"] = ExpressionConverter.ConvertO(__workflow_bodytagsCount);
                    bodypropCount++;
                }

                if (__workflow_bodyfunnelId != null)
                {
                    body["funnel_id"] = ExpressionConverter.ConvertO(__workflow_bodyfunnelId);
                    bodypropCount++;
                }

                if (__workflow_bodyfunnelStageId != null)
                {
                    body["funnel_stage_id"] = ExpressionConverter.ConvertO(__workflow_bodyfunnelStageId);
                    bodypropCount++;
                }

                if (__workflow_bodyfunnelStatusId != null)
                {
                    body["funnel_status_id"] = ExpressionConverter.ConvertO(__workflow_bodyfunnelStatusId);
                    bodypropCount++;
                }

                if (__workflow_bodyideaDeadline != null)
                {
                    body["idea_deadline"] = ExpressionConverter.ConvertO(__workflow_bodyideaDeadline);
                    bodypropCount++;
                }

                if (__workflow_bodydeadlineNotification != null)
                {
                    body["deadline_notification"] = ExpressionConverter.ConvertO(__workflow_bodydeadlineNotification);
                    bodypropCount++;
                }

                if (__workflow_bodyideaViews != null)
                {
                    body["idea_views"] = ExpressionConverter.ConvertO(__workflow_bodyideaViews);
                    bodypropCount++;
                }

                if (__workflow_bodyrevenue != null)
                {
                    body["revenue"] = ExpressionConverter.ConvertO(__workflow_bodyrevenue);
                    bodypropCount++;
                }

                if (__workflow_bodycost != null)
                {
                    body["cost"] = ExpressionConverter.ConvertO(__workflow_bodycost);
                    bodypropCount++;
                }

                if (__workflow_bodyprofit != null)
                {
                    body["profit"] = ExpressionConverter.ConvertO(__workflow_bodyprofit);
                    bodypropCount++;
                }

                if (__workflow_bodystatusName != null)
                {
                    body["status_name"] = ExpressionConverter.ConvertO(__workflow_bodystatusName);
                    bodypropCount++;
                }

                if (__workflow_bodyideaScores != null)
                {
                    body["idea_scores"] = ExpressionConverter.ConvertO(__workflow_bodyideaScores);
                    bodypropCount++;
                }

                if (__workflow_bodyapprovedAt != null)
                {
                    body["approved_at"] = ExpressionConverter.ConvertO(__workflow_bodyapprovedAt);
                    bodypropCount++;
                }

                if (__workflow_bodydeniedAt != null)
                {
                    body["denied_at"] = ExpressionConverter.ConvertO(__workflow_bodydeniedAt);
                    bodypropCount++;
                }

                if (__workflow_bodyadminComments != null)
                {
                    body["admin_comments"] = ExpressionConverter.ConvertO(__workflow_bodyadminComments);
                    bodypropCount++;
                }

                if (__workflow_bodyisChild != null)
                {
                    body["is_child"] = ExpressionConverter.ConvertO(__workflow_bodyisChild);
                    bodypropCount++;
                }

                if (__workflow_bodyparentId != null)
                {
                    body["parent_id"] = ExpressionConverter.ConvertO(__workflow_bodyparentId);
                    bodypropCount++;
                }

                if (__workflow_bodytempImage != null)
                {
                    body["temp_image"] = ExpressionConverter.ConvertO(__workflow_bodytempImage);
                    bodypropCount++;
                }

                if (__workflow_bodymainImage != null)
                {
                    body["main_image"] = ExpressionConverter.ConvertO(__workflow_bodymainImage);
                    bodypropCount++;
                }

                if (__workflow_bodyimageConfigs != null)
                {
                    body["image_configs"] = ExpressionConverter.ConvertO(__workflow_bodyimageConfigs);
                    bodypropCount++;
                }

                if (__workflow_bodyscoreCompleteScore != null)
                {
                    body["score_complete_score"] = ExpressionConverter.ConvertO(__workflow_bodyscoreCompleteScore);
                    bodypropCount++;
                }

                if (__workflow_bodyenrichmentScore != null)
                {
                    body["enrichment_score"] = ExpressionConverter.ConvertO(__workflow_bodyenrichmentScore);
                    bodypropCount++;
                }

                if (__workflow_bodyengagementScore != null)
                {
                    body["engagement_score"] = ExpressionConverter.ConvertO(__workflow_bodyengagementScore);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityScore != null)
                {
                    body["opportunity_score"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityScore);
                    bodypropCount++;
                }

                if (__workflow_bodytrendScore != null)
                {
                    body["trend_score"] = ExpressionConverter.ConvertO(__workflow_bodytrendScore);
                    bodypropCount++;
                }

                if (__workflow_bodycleanedText != null)
                {
                    body["cleaned_text"] = ExpressionConverter.ConvertO(__workflow_bodycleanedText);
                    bodypropCount++;
                }

                if (__workflow_bodyduplicateIdeasCount != null)
                {
                    body["duplicate_ideas_count"] = ExpressionConverter.ConvertO(__workflow_bodyduplicateIdeasCount);
                    bodypropCount++;
                }

                if (__workflow_bodysidekiqDuplicateIdeasCount != null)
                {
                    body["sidekiq_duplicate_ideas_count"] = ExpressionConverter.ConvertO(__workflow_bodysidekiqDuplicateIdeasCount);
                    bodypropCount++;
                }

                if (__workflow_bodyaiCreated != null)
                {
                    body["ai_created"] = ExpressionConverter.ConvertO(__workflow_bodyaiCreated);
                    bodypropCount++;
                }

                if (__workflow_bodyideaType != null)
                {
                    body["idea_type"] = ExpressionConverter.ConvertO(__workflow_bodyideaType);
                    bodypropCount++;
                }

                if (__workflow_bodyfromScript != null)
                {
                    body["from_script"] = ExpressionConverter.ConvertO(__workflow_bodyfromScript);
                    bodypropCount++;
                }

                if (__workflow_bodyembedding != null)
                {
                    body["embedding"] = ExpressionConverter.ConvertO(__workflow_bodyembedding);
                    bodypropCount++;
                }

                if (__workflow_bodyreasonText != null)
                {
                    body["reason_text"] = ExpressionConverter.ConvertO(__workflow_bodyreasonText);
                    bodypropCount++;
                }

                if (__workflow_bodycategoryText != null)
                {
                    body["category_text"] = ExpressionConverter.ConvertO(__workflow_bodycategoryText);
                    bodypropCount++;
                }

                if (__workflow_bodycanvassId != null)
                {
                    body["canvass_id"] = ExpressionConverter.ConvertO(__workflow_bodycanvassId);
                    bodypropCount++;
                }

                if (__workflow_bodybudgetTotal != null)
                {
                    body["budget_total"] = ExpressionConverter.ConvertO(__workflow_bodybudgetTotal);
                    bodypropCount++;
                }

                if (__workflow_bodybudgetSpend != null)
                {
                    body["budget_spend"] = ExpressionConverter.ConvertO(__workflow_bodybudgetSpend);
                    bodypropCount++;
                }

                if (__workflow_bodybudgetResult != null)
                {
                    body["budget_result"] = ExpressionConverter.ConvertO(__workflow_bodybudgetResult);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodytagText != null)
                {
                    body["tag_text"] = ExpressionConverter.ConvertO(__workflow_bodytagText);
                    bodypropCount++;
                }

                if (__workflow_bodyinnovationTypeId != null)
                {
                    body["innovation_type_id"] = ExpressionConverter.ConvertO(__workflow_bodyinnovationTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodyinnovationTypeText != null)
                {
                    body["innovation_type_text"] = ExpressionConverter.ConvertO(__workflow_bodyinnovationTypeText);
                    bodypropCount++;
                }

                if (__workflow_bodysyncId != null)
                {
                    body["sync_id"] = ExpressionConverter.ConvertO(__workflow_bodysyncId);
                    bodypropCount++;
                }

                if (__workflow_bodyrecordUrl != null)
                {
                    body["record_url"] = ExpressionConverter.ConvertO(__workflow_bodyrecordUrl);
                    bodypropCount++;
                }

                if (__workflow_bodydescriptionEnriched != null)
                {
                    body["description_enriched"] = ExpressionConverter.ConvertO(__workflow_bodydescriptionEnriched);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction PatchideasId(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodycontent = null, Expression<Func<int>> bodyfunnelId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodycontent = WorkflowExpression.Compile(bodycontent, nameof(bodycontent), required: false);
            var __workflow_bodyfunnelId = WorkflowExpression.Compile(bodyfunnelId, nameof(bodyfunnelId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/ideas/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(__workflow_bodycontent);
                    bodypropCount++;
                }

                if (__workflow_bodyfunnelId != null)
                {
                    body["funnel_id"] = ExpressionConverter.ConvertO(__workflow_bodyfunnelId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetmissionsResponse> Getmissions()
        {
            var apiCallPath = "/general/v1/missions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetmissionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction Postmissions(Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<bool>> bodyhidden = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodyhidden = WorkflowExpression.Compile(bodyhidden, nameof(bodyhidden), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/general/v1/missions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["start_date"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["end_date"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (__workflow_bodyhidden != null)
                {
                    body["hidden"] = ExpressionConverter.ConvertO(__workflow_bodyhidden);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetmissionsIdResponse> GetmissionsId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetmissionsIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/missions/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetmissionsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeletemissionsId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/missions/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PutmissionsIdResponse> PutmissionsId(Expression<Func<string>> id, Expression<Func<int>> bodyuserId = null, Expression<Func<int>> bodycompanyId = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<bool>> bodyisAnonymous = null, Expression<Func<string>> bodyendingNote = null, Expression<Func<string>> bodymissionPic = null, Expression<Func<int>> bodyteamSize = null, Expression<Func<int>> bodystatus = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyslug = null, Expression<Func<string>> bodyfromName = null, Expression<Func<bool>> bodyisTemplate = null, Expression<Func<int>> bodyendDuration = null, Expression<Func<string>> bodytoken = null, Expression<Func<bool>> bodyisTryout = null, Expression<Func<int>> bodytemplateType = null, Expression<Func<bool>> bodyisOpen = null, Expression<Func<int>> bodymissionType = null, Expression<Func<string>> bodypublishedOnce = null, Expression<Func<string>> bodyinboxQuestion = null, Expression<Func<string>> bodyprivacySetting = null, Expression<Func<string>> bodyagentProfile = null, Expression<Func<string>> bodydepartmentId = null, Expression<Func<bool>> bodyenableReport = null, Expression<Func<int>> bodyideasCount = null, Expression<Func<int>> bodylikesCount = null, Expression<Func<int>> bodycommentsCount = null, Expression<Func<string>> bodyfunnelId = null, Expression<Func<string>> bodyemail = null, Expression<Func<bool>> bodyenableInboundEmail = null, Expression<Func<string>> bodydepartmentName = null, Expression<Func<string>> bodynotificationType = null, Expression<Func<string>> bodynotificationFrequency = null, Expression<Func<string>> bodynotificationText = null, Expression<Func<int>> bodyposition = null, Expression<Func<string>> bodymissionViews = null, Expression<Func<string>> bodytempImage = null, Expression<Func<string>> bodymainImage = null, Expression<Func<string>> bodyimageConfigs = null, Expression<Func<string>> bodyallowAiIdeas = null, Expression<Func<string>> bodyaiMissionType = null, Expression<Func<string>> bodyfromScript = null, Expression<Func<string>> bodyideaAttachmentsAllowed = null, Expression<Func<string>> bodyvideoLink = null, Expression<Func<string>> bodyhidden = null, Expression<Func<string>> bodyconfettiType = null, Expression<Func<string>> bodyenable = null, Expression<Func<string>> bodyaddAttachment = null, Expression<Func<string>> bodyaddComment = null, Expression<Func<string>> bodyrecordUrl = null, Expression<Func<string>> bodysyncId = null, Expression<Func<string>> bodyideaCustomFields = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
            var __workflow_bodycompanyId = WorkflowExpression.Compile(bodycompanyId, nameof(bodycompanyId), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyisAnonymous = WorkflowExpression.Compile(bodyisAnonymous, nameof(bodyisAnonymous), required: false);
            var __workflow_bodyendingNote = WorkflowExpression.Compile(bodyendingNote, nameof(bodyendingNote), required: false);
            var __workflow_bodymissionPic = WorkflowExpression.Compile(bodymissionPic, nameof(bodymissionPic), required: false);
            var __workflow_bodyteamSize = WorkflowExpression.Compile(bodyteamSize, nameof(bodyteamSize), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodyslug = WorkflowExpression.Compile(bodyslug, nameof(bodyslug), required: false);
            var __workflow_bodyfromName = WorkflowExpression.Compile(bodyfromName, nameof(bodyfromName), required: false);
            var __workflow_bodyisTemplate = WorkflowExpression.Compile(bodyisTemplate, nameof(bodyisTemplate), required: false);
            var __workflow_bodyendDuration = WorkflowExpression.Compile(bodyendDuration, nameof(bodyendDuration), required: false);
            var __workflow_bodytoken = WorkflowExpression.Compile(bodytoken, nameof(bodytoken), required: false);
            var __workflow_bodyisTryout = WorkflowExpression.Compile(bodyisTryout, nameof(bodyisTryout), required: false);
            var __workflow_bodytemplateType = WorkflowExpression.Compile(bodytemplateType, nameof(bodytemplateType), required: false);
            var __workflow_bodyisOpen = WorkflowExpression.Compile(bodyisOpen, nameof(bodyisOpen), required: false);
            var __workflow_bodymissionType = WorkflowExpression.Compile(bodymissionType, nameof(bodymissionType), required: false);
            var __workflow_bodypublishedOnce = WorkflowExpression.Compile(bodypublishedOnce, nameof(bodypublishedOnce), required: false);
            var __workflow_bodyinboxQuestion = WorkflowExpression.Compile(bodyinboxQuestion, nameof(bodyinboxQuestion), required: false);
            var __workflow_bodyprivacySetting = WorkflowExpression.Compile(bodyprivacySetting, nameof(bodyprivacySetting), required: false);
            var __workflow_bodyagentProfile = WorkflowExpression.Compile(bodyagentProfile, nameof(bodyagentProfile), required: false);
            var __workflow_bodydepartmentId = WorkflowExpression.Compile(bodydepartmentId, nameof(bodydepartmentId), required: false);
            var __workflow_bodyenableReport = WorkflowExpression.Compile(bodyenableReport, nameof(bodyenableReport), required: false);
            var __workflow_bodyideasCount = WorkflowExpression.Compile(bodyideasCount, nameof(bodyideasCount), required: false);
            var __workflow_bodylikesCount = WorkflowExpression.Compile(bodylikesCount, nameof(bodylikesCount), required: false);
            var __workflow_bodycommentsCount = WorkflowExpression.Compile(bodycommentsCount, nameof(bodycommentsCount), required: false);
            var __workflow_bodyfunnelId = WorkflowExpression.Compile(bodyfunnelId, nameof(bodyfunnelId), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyenableInboundEmail = WorkflowExpression.Compile(bodyenableInboundEmail, nameof(bodyenableInboundEmail), required: false);
            var __workflow_bodydepartmentName = WorkflowExpression.Compile(bodydepartmentName, nameof(bodydepartmentName), required: false);
            var __workflow_bodynotificationType = WorkflowExpression.Compile(bodynotificationType, nameof(bodynotificationType), required: false);
            var __workflow_bodynotificationFrequency = WorkflowExpression.Compile(bodynotificationFrequency, nameof(bodynotificationFrequency), required: false);
            var __workflow_bodynotificationText = WorkflowExpression.Compile(bodynotificationText, nameof(bodynotificationText), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            var __workflow_bodymissionViews = WorkflowExpression.Compile(bodymissionViews, nameof(bodymissionViews), required: false);
            var __workflow_bodytempImage = WorkflowExpression.Compile(bodytempImage, nameof(bodytempImage), required: false);
            var __workflow_bodymainImage = WorkflowExpression.Compile(bodymainImage, nameof(bodymainImage), required: false);
            var __workflow_bodyimageConfigs = WorkflowExpression.Compile(bodyimageConfigs, nameof(bodyimageConfigs), required: false);
            var __workflow_bodyallowAiIdeas = WorkflowExpression.Compile(bodyallowAiIdeas, nameof(bodyallowAiIdeas), required: false);
            var __workflow_bodyaiMissionType = WorkflowExpression.Compile(bodyaiMissionType, nameof(bodyaiMissionType), required: false);
            var __workflow_bodyfromScript = WorkflowExpression.Compile(bodyfromScript, nameof(bodyfromScript), required: false);
            var __workflow_bodyideaAttachmentsAllowed = WorkflowExpression.Compile(bodyideaAttachmentsAllowed, nameof(bodyideaAttachmentsAllowed), required: false);
            var __workflow_bodyvideoLink = WorkflowExpression.Compile(bodyvideoLink, nameof(bodyvideoLink), required: false);
            var __workflow_bodyhidden = WorkflowExpression.Compile(bodyhidden, nameof(bodyhidden), required: false);
            var __workflow_bodyconfettiType = WorkflowExpression.Compile(bodyconfettiType, nameof(bodyconfettiType), required: false);
            var __workflow_bodyenable = WorkflowExpression.Compile(bodyenable, nameof(bodyenable), required: false);
            var __workflow_bodyaddAttachment = WorkflowExpression.Compile(bodyaddAttachment, nameof(bodyaddAttachment), required: false);
            var __workflow_bodyaddComment = WorkflowExpression.Compile(bodyaddComment, nameof(bodyaddComment), required: false);
            var __workflow_bodyrecordUrl = WorkflowExpression.Compile(bodyrecordUrl, nameof(bodyrecordUrl), required: false);
            var __workflow_bodysyncId = WorkflowExpression.Compile(bodysyncId, nameof(bodysyncId), required: false);
            var __workflow_bodyideaCustomFields = WorkflowExpression.Compile(bodyideaCustomFields, nameof(bodyideaCustomFields), required: false);
            return new DeferredBodyAction<PutmissionsIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/missions/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyId != null)
                {
                    body["company_id"] = ExpressionConverter.ConvertO(__workflow_bodycompanyId);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyisAnonymous != null)
                {
                    body["is_anonymous"] = ExpressionConverter.ConvertO(__workflow_bodyisAnonymous);
                    bodypropCount++;
                }

                if (__workflow_bodyendingNote != null)
                {
                    body["ending_note"] = ExpressionConverter.ConvertO(__workflow_bodyendingNote);
                    bodypropCount++;
                }

                if (__workflow_bodymissionPic != null)
                {
                    body["mission_pic"] = ExpressionConverter.ConvertO(__workflow_bodymissionPic);
                    bodypropCount++;
                }

                if (__workflow_bodyteamSize != null)
                {
                    body["team_size"] = ExpressionConverter.ConvertO(__workflow_bodyteamSize);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["start_date"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["end_date"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (__workflow_bodyslug != null)
                {
                    body["slug"] = ExpressionConverter.ConvertO(__workflow_bodyslug);
                    bodypropCount++;
                }

                if (__workflow_bodyfromName != null)
                {
                    body["from_name"] = ExpressionConverter.ConvertO(__workflow_bodyfromName);
                    bodypropCount++;
                }

                if (__workflow_bodyisTemplate != null)
                {
                    body["is_template"] = ExpressionConverter.ConvertO(__workflow_bodyisTemplate);
                    bodypropCount++;
                }

                if (__workflow_bodyendDuration != null)
                {
                    body["end_duration"] = ExpressionConverter.ConvertO(__workflow_bodyendDuration);
                    bodypropCount++;
                }

                if (__workflow_bodytoken != null)
                {
                    body["token"] = ExpressionConverter.ConvertO(__workflow_bodytoken);
                    bodypropCount++;
                }

                if (__workflow_bodyisTryout != null)
                {
                    body["is_tryout"] = ExpressionConverter.ConvertO(__workflow_bodyisTryout);
                    bodypropCount++;
                }

                if (__workflow_bodytemplateType != null)
                {
                    body["template_type"] = ExpressionConverter.ConvertO(__workflow_bodytemplateType);
                    bodypropCount++;
                }

                if (__workflow_bodyisOpen != null)
                {
                    body["is_open"] = ExpressionConverter.ConvertO(__workflow_bodyisOpen);
                    bodypropCount++;
                }

                if (__workflow_bodymissionType != null)
                {
                    body["mission_type"] = ExpressionConverter.ConvertO(__workflow_bodymissionType);
                    bodypropCount++;
                }

                if (__workflow_bodypublishedOnce != null)
                {
                    body["published_once"] = ExpressionConverter.ConvertO(__workflow_bodypublishedOnce);
                    bodypropCount++;
                }

                if (__workflow_bodyinboxQuestion != null)
                {
                    body["inbox_question"] = ExpressionConverter.ConvertO(__workflow_bodyinboxQuestion);
                    bodypropCount++;
                }

                if (__workflow_bodyprivacySetting != null)
                {
                    body["privacy_setting"] = ExpressionConverter.ConvertO(__workflow_bodyprivacySetting);
                    bodypropCount++;
                }

                if (__workflow_bodyagentProfile != null)
                {
                    body["agent_profile"] = ExpressionConverter.ConvertO(__workflow_bodyagentProfile);
                    bodypropCount++;
                }

                if (__workflow_bodydepartmentId != null)
                {
                    body["department_id"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentId);
                    bodypropCount++;
                }

                if (__workflow_bodyenableReport != null)
                {
                    body["enable_report"] = ExpressionConverter.ConvertO(__workflow_bodyenableReport);
                    bodypropCount++;
                }

                if (__workflow_bodyideasCount != null)
                {
                    body["ideas_count"] = ExpressionConverter.ConvertO(__workflow_bodyideasCount);
                    bodypropCount++;
                }

                if (__workflow_bodylikesCount != null)
                {
                    body["likes_count"] = ExpressionConverter.ConvertO(__workflow_bodylikesCount);
                    bodypropCount++;
                }

                if (__workflow_bodycommentsCount != null)
                {
                    body["comments_count"] = ExpressionConverter.ConvertO(__workflow_bodycommentsCount);
                    bodypropCount++;
                }

                if (__workflow_bodyfunnelId != null)
                {
                    body["funnel_id"] = ExpressionConverter.ConvertO(__workflow_bodyfunnelId);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyenableInboundEmail != null)
                {
                    body["enable_inbound_email"] = ExpressionConverter.ConvertO(__workflow_bodyenableInboundEmail);
                    bodypropCount++;
                }

                var customFieldsObject = new JObject();
                var customFieldsObjectpropCount = 0;
                if (customFieldsObjectpropCount > 0)
                {
                    body["custom_fields"] = customFieldsObject;
                    bodypropCount++;
                }

                if (__workflow_bodydepartmentName != null)
                {
                    body["department_name"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentName);
                    bodypropCount++;
                }

                if (__workflow_bodynotificationType != null)
                {
                    body["notification_type"] = ExpressionConverter.ConvertO(__workflow_bodynotificationType);
                    bodypropCount++;
                }

                if (__workflow_bodynotificationFrequency != null)
                {
                    body["notification_frequency"] = ExpressionConverter.ConvertO(__workflow_bodynotificationFrequency);
                    bodypropCount++;
                }

                if (__workflow_bodynotificationText != null)
                {
                    body["notification_text"] = ExpressionConverter.ConvertO(__workflow_bodynotificationText);
                    bodypropCount++;
                }

                if (__workflow_bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (__workflow_bodymissionViews != null)
                {
                    body["mission_views"] = ExpressionConverter.ConvertO(__workflow_bodymissionViews);
                    bodypropCount++;
                }

                if (__workflow_bodytempImage != null)
                {
                    body["temp_image"] = ExpressionConverter.ConvertO(__workflow_bodytempImage);
                    bodypropCount++;
                }

                if (__workflow_bodymainImage != null)
                {
                    body["main_image"] = ExpressionConverter.ConvertO(__workflow_bodymainImage);
                    bodypropCount++;
                }

                if (__workflow_bodyimageConfigs != null)
                {
                    body["image_configs"] = ExpressionConverter.ConvertO(__workflow_bodyimageConfigs);
                    bodypropCount++;
                }

                if (__workflow_bodyallowAiIdeas != null)
                {
                    body["allow_ai_ideas"] = ExpressionConverter.ConvertO(__workflow_bodyallowAiIdeas);
                    bodypropCount++;
                }

                if (__workflow_bodyaiMissionType != null)
                {
                    body["ai_mission_type"] = ExpressionConverter.ConvertO(__workflow_bodyaiMissionType);
                    bodypropCount++;
                }

                if (__workflow_bodyfromScript != null)
                {
                    body["from_script"] = ExpressionConverter.ConvertO(__workflow_bodyfromScript);
                    bodypropCount++;
                }

                if (__workflow_bodyideaAttachmentsAllowed != null)
                {
                    body["idea_attachments_allowed"] = ExpressionConverter.ConvertO(__workflow_bodyideaAttachmentsAllowed);
                    bodypropCount++;
                }

                if (__workflow_bodyvideoLink != null)
                {
                    body["video_link"] = ExpressionConverter.ConvertO(__workflow_bodyvideoLink);
                    bodypropCount++;
                }

                if (__workflow_bodyhidden != null)
                {
                    body["hidden"] = ExpressionConverter.ConvertO(__workflow_bodyhidden);
                    bodypropCount++;
                }

                if (__workflow_bodyconfettiType != null)
                {
                    body["confetti_type"] = ExpressionConverter.ConvertO(__workflow_bodyconfettiType);
                    bodypropCount++;
                }

                if (__workflow_bodyenable != null)
                {
                    body["enable"] = ExpressionConverter.ConvertO(__workflow_bodyenable);
                    bodypropCount++;
                }

                if (__workflow_bodyaddAttachment != null)
                {
                    body["add_attachment"] = ExpressionConverter.ConvertO(__workflow_bodyaddAttachment);
                    bodypropCount++;
                }

                if (__workflow_bodyaddComment != null)
                {
                    body["add_comment"] = ExpressionConverter.ConvertO(__workflow_bodyaddComment);
                    bodypropCount++;
                }

                if (__workflow_bodyrecordUrl != null)
                {
                    body["record_url"] = ExpressionConverter.ConvertO(__workflow_bodyrecordUrl);
                    bodypropCount++;
                }

                if (__workflow_bodysyncId != null)
                {
                    body["sync_id"] = ExpressionConverter.ConvertO(__workflow_bodysyncId);
                    bodypropCount++;
                }

                if (__workflow_bodyideaCustomFields != null)
                {
                    body["idea_custom_fields"] = ExpressionConverter.ConvertO(__workflow_bodyideaCustomFields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PutmissionsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchmissionsIdResponse> PatchmissionsId(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<bool>> bodyhidden = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyhidden = WorkflowExpression.Compile(bodyhidden, nameof(bodyhidden), required: false);
            return new DeferredBodyAction<PatchmissionsIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/missions/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyhidden != null)
                {
                    body["hidden"] = ExpressionConverter.ConvertO(__workflow_bodyhidden);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PatchmissionsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetprojectsResponse> Getprojects()
        {
            var apiCallPath = "/general/v1/projects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetprojectsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PostprojectsResponse> Postprojects(Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodyfunnelId = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyfunnelId = WorkflowExpression.Compile(bodyfunnelId, nameof(bodyfunnelId), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            return new DeferredBodyAction<PostprojectsResponse>(() =>
            {
                var apiCallPath = "/general/v1/projects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyfunnelId != null)
                {
                    body["funnel_id"] = ExpressionConverter.ConvertO(__workflow_bodyfunnelId);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["start_date"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["end_date"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostprojectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetprojectsIdResponse> GetprojectsId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetprojectsIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetprojectsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeleteprojectsId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PutprojectsIdResponse> PutprojectsId(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyimage = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodystatusId = null, Expression<Func<string>> bodydepartmentId = null, Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodystageId = null, Expression<Func<string>> bodyprojectManagerId = null, Expression<Func<string>> bodybusinessOwnerId = null, Expression<Func<string>> bodyprogress = null, Expression<Func<string>> bodycompanyId = null, Expression<Func<string>> bodycommentsCount = null, Expression<Func<string>> bodyprojectScore = null, Expression<Func<string>> bodyslug = null, Expression<Func<string>> bodyposition = null, Expression<Func<int>> bodymodifiedBy = null, Expression<Func<int>> bodytagsCount = null, Expression<Func<string>> bodyfunnelId = null, Expression<Func<string>> bodyfunnelStageId = null, Expression<Func<string>> bodyfunnelStatusId = null, Expression<Func<string>> bodystageDeadline = null, Expression<Func<string>> bodydeadlineNotification = null, Expression<Func<string>> bodystatusName = null, Expression<Func<string>> bodyapprovedAt = null, Expression<Func<string>> bodydeniedAt = null, Expression<Func<string>> bodyamScores = null, Expression<Func<string>> bodyprojectRevenue = null, Expression<Func<string>> bodyprojectCost = null, Expression<Func<string>> bodyprojectProfit = null, Expression<Func<string>> bodyadminComments = null, Expression<Func<string>> bodytempImage = null, Expression<Func<string>> bodymainImage = null, Expression<Func<string>> bodyimageConfigs = null, Expression<Func<string>> bodyfromScript = null, Expression<Func<string>> bodyreasonText = null, Expression<Func<string>> bodycategoryText = null, Expression<Func<string>> bodycanvassId = null, Expression<Func<string>> bodybudgetTotal = null, Expression<Func<string>> bodybudgetSpend = null, Expression<Func<string>> bodybudgetResult = null, Expression<Func<string>> bodytagText = null, Expression<Func<string>> bodyestimatedTime = null, Expression<Func<string>> bodytotalTimeSpend = null, Expression<Func<string>> bodytotalTime = null, Expression<Func<string>> bodyinnovationTypeId = null, Expression<Func<string>> bodyinnovationTypeText = null, Expression<Func<string>> bodysyncId = null, Expression<Func<string>> bodyrecordUrl = null, Expression<Func<string>> bodydescriptionEnriched = null, Expression<Func<string>> bodycustomFieldValues = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyimage = WorkflowExpression.Compile(bodyimage, nameof(bodyimage), required: false);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: false);
            var __workflow_bodyendDate = WorkflowExpression.Compile(bodyendDate, nameof(bodyendDate), required: false);
            var __workflow_bodystatusId = WorkflowExpression.Compile(bodystatusId, nameof(bodystatusId), required: false);
            var __workflow_bodydepartmentId = WorkflowExpression.Compile(bodydepartmentId, nameof(bodydepartmentId), required: false);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
            var __workflow_bodystageId = WorkflowExpression.Compile(bodystageId, nameof(bodystageId), required: false);
            var __workflow_bodyprojectManagerId = WorkflowExpression.Compile(bodyprojectManagerId, nameof(bodyprojectManagerId), required: false);
            var __workflow_bodybusinessOwnerId = WorkflowExpression.Compile(bodybusinessOwnerId, nameof(bodybusinessOwnerId), required: false);
            var __workflow_bodyprogress = WorkflowExpression.Compile(bodyprogress, nameof(bodyprogress), required: false);
            var __workflow_bodycompanyId = WorkflowExpression.Compile(bodycompanyId, nameof(bodycompanyId), required: false);
            var __workflow_bodycommentsCount = WorkflowExpression.Compile(bodycommentsCount, nameof(bodycommentsCount), required: false);
            var __workflow_bodyprojectScore = WorkflowExpression.Compile(bodyprojectScore, nameof(bodyprojectScore), required: false);
            var __workflow_bodyslug = WorkflowExpression.Compile(bodyslug, nameof(bodyslug), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            var __workflow_bodymodifiedBy = WorkflowExpression.Compile(bodymodifiedBy, nameof(bodymodifiedBy), required: false);
            var __workflow_bodytagsCount = WorkflowExpression.Compile(bodytagsCount, nameof(bodytagsCount), required: false);
            var __workflow_bodyfunnelId = WorkflowExpression.Compile(bodyfunnelId, nameof(bodyfunnelId), required: false);
            var __workflow_bodyfunnelStageId = WorkflowExpression.Compile(bodyfunnelStageId, nameof(bodyfunnelStageId), required: false);
            var __workflow_bodyfunnelStatusId = WorkflowExpression.Compile(bodyfunnelStatusId, nameof(bodyfunnelStatusId), required: false);
            var __workflow_bodystageDeadline = WorkflowExpression.Compile(bodystageDeadline, nameof(bodystageDeadline), required: false);
            var __workflow_bodydeadlineNotification = WorkflowExpression.Compile(bodydeadlineNotification, nameof(bodydeadlineNotification), required: false);
            var __workflow_bodystatusName = WorkflowExpression.Compile(bodystatusName, nameof(bodystatusName), required: false);
            var __workflow_bodyapprovedAt = WorkflowExpression.Compile(bodyapprovedAt, nameof(bodyapprovedAt), required: false);
            var __workflow_bodydeniedAt = WorkflowExpression.Compile(bodydeniedAt, nameof(bodydeniedAt), required: false);
            var __workflow_bodyamScores = WorkflowExpression.Compile(bodyamScores, nameof(bodyamScores), required: false);
            var __workflow_bodyprojectRevenue = WorkflowExpression.Compile(bodyprojectRevenue, nameof(bodyprojectRevenue), required: false);
            var __workflow_bodyprojectCost = WorkflowExpression.Compile(bodyprojectCost, nameof(bodyprojectCost), required: false);
            var __workflow_bodyprojectProfit = WorkflowExpression.Compile(bodyprojectProfit, nameof(bodyprojectProfit), required: false);
            var __workflow_bodyadminComments = WorkflowExpression.Compile(bodyadminComments, nameof(bodyadminComments), required: false);
            var __workflow_bodytempImage = WorkflowExpression.Compile(bodytempImage, nameof(bodytempImage), required: false);
            var __workflow_bodymainImage = WorkflowExpression.Compile(bodymainImage, nameof(bodymainImage), required: false);
            var __workflow_bodyimageConfigs = WorkflowExpression.Compile(bodyimageConfigs, nameof(bodyimageConfigs), required: false);
            var __workflow_bodyfromScript = WorkflowExpression.Compile(bodyfromScript, nameof(bodyfromScript), required: false);
            var __workflow_bodyreasonText = WorkflowExpression.Compile(bodyreasonText, nameof(bodyreasonText), required: false);
            var __workflow_bodycategoryText = WorkflowExpression.Compile(bodycategoryText, nameof(bodycategoryText), required: false);
            var __workflow_bodycanvassId = WorkflowExpression.Compile(bodycanvassId, nameof(bodycanvassId), required: false);
            var __workflow_bodybudgetTotal = WorkflowExpression.Compile(bodybudgetTotal, nameof(bodybudgetTotal), required: false);
            var __workflow_bodybudgetSpend = WorkflowExpression.Compile(bodybudgetSpend, nameof(bodybudgetSpend), required: false);
            var __workflow_bodybudgetResult = WorkflowExpression.Compile(bodybudgetResult, nameof(bodybudgetResult), required: false);
            var __workflow_bodytagText = WorkflowExpression.Compile(bodytagText, nameof(bodytagText), required: false);
            var __workflow_bodyestimatedTime = WorkflowExpression.Compile(bodyestimatedTime, nameof(bodyestimatedTime), required: false);
            var __workflow_bodytotalTimeSpend = WorkflowExpression.Compile(bodytotalTimeSpend, nameof(bodytotalTimeSpend), required: false);
            var __workflow_bodytotalTime = WorkflowExpression.Compile(bodytotalTime, nameof(bodytotalTime), required: false);
            var __workflow_bodyinnovationTypeId = WorkflowExpression.Compile(bodyinnovationTypeId, nameof(bodyinnovationTypeId), required: false);
            var __workflow_bodyinnovationTypeText = WorkflowExpression.Compile(bodyinnovationTypeText, nameof(bodyinnovationTypeText), required: false);
            var __workflow_bodysyncId = WorkflowExpression.Compile(bodysyncId, nameof(bodysyncId), required: false);
            var __workflow_bodyrecordUrl = WorkflowExpression.Compile(bodyrecordUrl, nameof(bodyrecordUrl), required: false);
            var __workflow_bodydescriptionEnriched = WorkflowExpression.Compile(bodydescriptionEnriched, nameof(bodydescriptionEnriched), required: false);
            var __workflow_bodycustomFieldValues = WorkflowExpression.Compile(bodycustomFieldValues, nameof(bodycustomFieldValues), required: false);
            return new DeferredBodyAction<PutprojectsIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyimage != null)
                {
                    body["image"] = ExpressionConverter.ConvertO(__workflow_bodyimage);
                    bodypropCount++;
                }

                if (__workflow_bodystartDate != null)
                {
                    body["start_date"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyendDate != null)
                {
                    body["end_date"] = ExpressionConverter.ConvertO(__workflow_bodyendDate);
                    bodypropCount++;
                }

                if (__workflow_bodystatusId != null)
                {
                    body["status_id"] = ExpressionConverter.ConvertO(__workflow_bodystatusId);
                    bodypropCount++;
                }

                if (__workflow_bodydepartmentId != null)
                {
                    body["department_id"] = ExpressionConverter.ConvertO(__workflow_bodydepartmentId);
                    bodypropCount++;
                }

                if (__workflow_bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (__workflow_bodystageId != null)
                {
                    body["stage_id"] = ExpressionConverter.ConvertO(__workflow_bodystageId);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectManagerId != null)
                {
                    body["project_manager_id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectManagerId);
                    bodypropCount++;
                }

                if (__workflow_bodybusinessOwnerId != null)
                {
                    body["business_owner_id"] = ExpressionConverter.ConvertO(__workflow_bodybusinessOwnerId);
                    bodypropCount++;
                }

                if (__workflow_bodyprogress != null)
                {
                    body["progress"] = ExpressionConverter.ConvertO(__workflow_bodyprogress);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyId != null)
                {
                    body["company_id"] = ExpressionConverter.ConvertO(__workflow_bodycompanyId);
                    bodypropCount++;
                }

                if (__workflow_bodycommentsCount != null)
                {
                    body["comments_count"] = ExpressionConverter.ConvertO(__workflow_bodycommentsCount);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectScore != null)
                {
                    body["project_score"] = ExpressionConverter.ConvertO(__workflow_bodyprojectScore);
                    bodypropCount++;
                }

                if (__workflow_bodyslug != null)
                {
                    body["slug"] = ExpressionConverter.ConvertO(__workflow_bodyslug);
                    bodypropCount++;
                }

                if (__workflow_bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (__workflow_bodymodifiedBy != null)
                {
                    body["modified_by"] = ExpressionConverter.ConvertO(__workflow_bodymodifiedBy);
                    bodypropCount++;
                }

                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                if (__workflow_bodytagsCount != null)
                {
                    body["tags_count"] = ExpressionConverter.ConvertO(__workflow_bodytagsCount);
                    bodypropCount++;
                }

                if (__workflow_bodyfunnelId != null)
                {
                    body["funnel_id"] = ExpressionConverter.ConvertO(__workflow_bodyfunnelId);
                    bodypropCount++;
                }

                if (__workflow_bodyfunnelStageId != null)
                {
                    body["funnel_stage_id"] = ExpressionConverter.ConvertO(__workflow_bodyfunnelStageId);
                    bodypropCount++;
                }

                if (__workflow_bodyfunnelStatusId != null)
                {
                    body["funnel_status_id"] = ExpressionConverter.ConvertO(__workflow_bodyfunnelStatusId);
                    bodypropCount++;
                }

                if (__workflow_bodystageDeadline != null)
                {
                    body["stage_deadline"] = ExpressionConverter.ConvertO(__workflow_bodystageDeadline);
                    bodypropCount++;
                }

                if (__workflow_bodydeadlineNotification != null)
                {
                    body["deadline_notification"] = ExpressionConverter.ConvertO(__workflow_bodydeadlineNotification);
                    bodypropCount++;
                }

                if (__workflow_bodystatusName != null)
                {
                    body["status_name"] = ExpressionConverter.ConvertO(__workflow_bodystatusName);
                    bodypropCount++;
                }

                if (__workflow_bodyapprovedAt != null)
                {
                    body["approved_at"] = ExpressionConverter.ConvertO(__workflow_bodyapprovedAt);
                    bodypropCount++;
                }

                if (__workflow_bodydeniedAt != null)
                {
                    body["denied_at"] = ExpressionConverter.ConvertO(__workflow_bodydeniedAt);
                    bodypropCount++;
                }

                if (__workflow_bodyamScores != null)
                {
                    body["am_scores"] = ExpressionConverter.ConvertO(__workflow_bodyamScores);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectRevenue != null)
                {
                    body["project_revenue"] = ExpressionConverter.ConvertO(__workflow_bodyprojectRevenue);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectCost != null)
                {
                    body["project_cost"] = ExpressionConverter.ConvertO(__workflow_bodyprojectCost);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectProfit != null)
                {
                    body["project_profit"] = ExpressionConverter.ConvertO(__workflow_bodyprojectProfit);
                    bodypropCount++;
                }

                if (__workflow_bodyadminComments != null)
                {
                    body["admin_comments"] = ExpressionConverter.ConvertO(__workflow_bodyadminComments);
                    bodypropCount++;
                }

                if (__workflow_bodytempImage != null)
                {
                    body["temp_image"] = ExpressionConverter.ConvertO(__workflow_bodytempImage);
                    bodypropCount++;
                }

                if (__workflow_bodymainImage != null)
                {
                    body["main_image"] = ExpressionConverter.ConvertO(__workflow_bodymainImage);
                    bodypropCount++;
                }

                if (__workflow_bodyimageConfigs != null)
                {
                    body["image_configs"] = ExpressionConverter.ConvertO(__workflow_bodyimageConfigs);
                    bodypropCount++;
                }

                if (__workflow_bodyfromScript != null)
                {
                    body["from_script"] = ExpressionConverter.ConvertO(__workflow_bodyfromScript);
                    bodypropCount++;
                }

                if (__workflow_bodyreasonText != null)
                {
                    body["reason_text"] = ExpressionConverter.ConvertO(__workflow_bodyreasonText);
                    bodypropCount++;
                }

                if (__workflow_bodycategoryText != null)
                {
                    body["category_text"] = ExpressionConverter.ConvertO(__workflow_bodycategoryText);
                    bodypropCount++;
                }

                if (__workflow_bodycanvassId != null)
                {
                    body["canvass_id"] = ExpressionConverter.ConvertO(__workflow_bodycanvassId);
                    bodypropCount++;
                }

                if (__workflow_bodybudgetTotal != null)
                {
                    body["budget_total"] = ExpressionConverter.ConvertO(__workflow_bodybudgetTotal);
                    bodypropCount++;
                }

                if (__workflow_bodybudgetSpend != null)
                {
                    body["budget_spend"] = ExpressionConverter.ConvertO(__workflow_bodybudgetSpend);
                    bodypropCount++;
                }

                if (__workflow_bodybudgetResult != null)
                {
                    body["budget_result"] = ExpressionConverter.ConvertO(__workflow_bodybudgetResult);
                    bodypropCount++;
                }

                if (__workflow_bodytagText != null)
                {
                    body["tag_text"] = ExpressionConverter.ConvertO(__workflow_bodytagText);
                    bodypropCount++;
                }

                if (__workflow_bodyestimatedTime != null)
                {
                    body["estimated_time"] = ExpressionConverter.ConvertO(__workflow_bodyestimatedTime);
                    bodypropCount++;
                }

                if (__workflow_bodytotalTimeSpend != null)
                {
                    body["total_time_spend"] = ExpressionConverter.ConvertO(__workflow_bodytotalTimeSpend);
                    bodypropCount++;
                }

                if (__workflow_bodytotalTime != null)
                {
                    body["total_time"] = ExpressionConverter.ConvertO(__workflow_bodytotalTime);
                    bodypropCount++;
                }

                if (__workflow_bodyinnovationTypeId != null)
                {
                    body["innovation_type_id"] = ExpressionConverter.ConvertO(__workflow_bodyinnovationTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodyinnovationTypeText != null)
                {
                    body["innovation_type_text"] = ExpressionConverter.ConvertO(__workflow_bodyinnovationTypeText);
                    bodypropCount++;
                }

                if (__workflow_bodysyncId != null)
                {
                    body["sync_id"] = ExpressionConverter.ConvertO(__workflow_bodysyncId);
                    bodypropCount++;
                }

                if (__workflow_bodyrecordUrl != null)
                {
                    body["record_url"] = ExpressionConverter.ConvertO(__workflow_bodyrecordUrl);
                    bodypropCount++;
                }

                if (__workflow_bodydescriptionEnriched != null)
                {
                    body["description_enriched"] = ExpressionConverter.ConvertO(__workflow_bodydescriptionEnriched);
                    bodypropCount++;
                }

                if (__workflow_bodycustomFieldValues != null)
                {
                    body["custom_field_values"] = ExpressionConverter.ConvertO(__workflow_bodycustomFieldValues);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PutprojectsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchprojectsIdResponse> PatchprojectsId(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<PatchprojectsIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PatchprojectsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetprojectsProjectIdTasksResponse> GetprojectsProjectIdTasks(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<GetprojectsProjectIdTasksResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/projects/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(__workflow_projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetprojectsProjectIdTasksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PostprojectsProjectIdTasksResponse> PostprojectsProjectIdTasks(Expression<Func<string>> projectId, Expression<Func<string>> bodytitle = null, Expression<Func<int>> bodystatus = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<PostprojectsProjectIdTasksResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/projects/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(__workflow_projectId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostprojectsProjectIdTasksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetTaskBySyncIdResponse> GetTaskBySyncId(Expression<Func<string>> syncId = null)
        {
            var __workflow_syncId = WorkflowExpression.Compile(syncId, nameof(syncId), required: false);
            return new DeferredBodyAction<GetTaskBySyncIdResponse>(() =>
            {
                var apiCallPath = "/general/v1/tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_syncId != null)
                    callPayload.Queries["sync_id"] = ExpressionConverter.Convert(__workflow_syncId);
                return new ApiConnectionAction<GetTaskBySyncIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PosttasksResponse> Posttasks(Expression<Func<string>> bodytitle = null, Expression<Func<int>> bodystatus = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<PosttasksResponse>(() =>
            {
                var apiCallPath = "/general/v1/tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PosttasksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GettasksIdResponse> GettasksId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GettasksIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GettasksIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeletetasksId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchtasksIdResponse> PatchtasksId(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<int>> bodystatus = null, Expression<Func<string>> bodysyncId = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodysyncId = WorkflowExpression.Compile(bodysyncId, nameof(bodysyncId), required: false);
            return new DeferredBodyAction<PatchtasksIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodysyncId != null)
                {
                    body["sync_id"] = ExpressionConverter.ConvertO(__workflow_bodysyncId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PatchtasksIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GettopicsResponse> Gettopics()
        {
            var apiCallPath = "/general/v1/topics";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GettopicsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeletetopicsId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/topics/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetusersResponse> Getusers()
        {
            var apiCallPath = "/general/v1/users";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetusersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PostusersResponse> Postusers(Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodyphoneNumber = null, Expression<Func<int>> bodyposition = null)
        {
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodyphoneNumber = WorkflowExpression.Compile(bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            return new DeferredBodyAction<PostusersResponse>(() =>
            {
                var apiCallPath = "/general/v1/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfirstName != null)
                {
                    body["first_name"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["last_name"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodyphoneNumber != null)
                {
                    body["phone_number"] = ExpressionConverter.ConvertO(__workflow_bodyphoneNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostusersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetusersGetCompanyResponse> GetusersGetCompany()
        {
            var apiCallPath = "/general/v1/users/get_company";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetusersGetCompanyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetusersIdResponse> GetusersId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetusersIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetusersIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeleteusersId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PutusersIdResponse> PutusersId(Expression<Func<string>> id, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodyprofilePic = null, Expression<Func<int>> bodypoints = null, Expression<Func<int>> bodycompanyId = null, Expression<Func<int>> bodyuserRoleId = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyslug = null, Expression<Func<string>> bodyphoneNumber = null, Expression<Func<string>> bodylastSignOutAt = null, Expression<Func<string>> bodyposition = null, Expression<Func<bool>> bodyprofileFlag = null, Expression<Func<string>> bodyuserChecklist = null, Expression<Func<int>> bodyideaLikesCount = null, Expression<Func<int>> bodycommentsCount = null, Expression<Func<int>> bodyxpPoints = null, Expression<Func<int>> bodyideasCount = null, Expression<Func<string>> bodyfunnelId = null, Expression<Func<int>> bodylevel = null, Expression<Func<int>> bodyxpLevel = null, Expression<Func<string>> bodyprojectFunnelId = null, Expression<Func<string>> bodychecklistScore = null, Expression<Func<string>> bodyprovider = null, Expression<Func<string>> bodyuid = null, Expression<Func<string>> bodyemailSentAt = null, Expression<Func<bool>> bodyblockAllNotification = null, Expression<Func<string>> bodydbName = null, Expression<Func<string>> bodydeptId = null, Expression<Func<string>> bodydeptName = null, Expression<Func<string>> bodymainImage = null, Expression<Func<string>> bodytempImage = null, Expression<Func<string>> bodyimageConfigs = null, Expression<Func<bool>> bodyimageAutoGenerated = null, Expression<Func<string>> bodyamAccount = null, Expression<Func<string>> bodyuuid = null, Expression<Func<string>> bodypasswordResetAttempts = null, Expression<Func<string>> bodylastPasswordResetAt = null, Expression<Func<string>> bodycustomDomain = null, Expression<Func<string>> bodyuserRoleName = null, Expression<Func<int>> bodytheme = null, Expression<Func<string>> bodyuserType = null, Expression<Func<string>> bodyviewSettings = null, Expression<Func<string>> bodyreadManual = null, Expression<Func<string>> bodyaddIdeaBox = null, Expression<Func<string>> bodyvisitAgent = null, Expression<Func<string>> bodyaddIdea = null, Expression<Func<string>> bodyinvitePeople = null, Expression<Func<string>> bodyaddBoardMission = null, Expression<Func<string>> bodyaddProject = null, Expression<Func<string>> bodycompletedChecklist = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodyprofilePic = WorkflowExpression.Compile(bodyprofilePic, nameof(bodyprofilePic), required: false);
            var __workflow_bodypoints = WorkflowExpression.Compile(bodypoints, nameof(bodypoints), required: false);
            var __workflow_bodycompanyId = WorkflowExpression.Compile(bodycompanyId, nameof(bodycompanyId), required: false);
            var __workflow_bodyuserRoleId = WorkflowExpression.Compile(bodyuserRoleId, nameof(bodyuserRoleId), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyslug = WorkflowExpression.Compile(bodyslug, nameof(bodyslug), required: false);
            var __workflow_bodyphoneNumber = WorkflowExpression.Compile(bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            var __workflow_bodylastSignOutAt = WorkflowExpression.Compile(bodylastSignOutAt, nameof(bodylastSignOutAt), required: false);
            var __workflow_bodyposition = WorkflowExpression.Compile(bodyposition, nameof(bodyposition), required: false);
            var __workflow_bodyprofileFlag = WorkflowExpression.Compile(bodyprofileFlag, nameof(bodyprofileFlag), required: false);
            var __workflow_bodyuserChecklist = WorkflowExpression.Compile(bodyuserChecklist, nameof(bodyuserChecklist), required: false);
            var __workflow_bodyideaLikesCount = WorkflowExpression.Compile(bodyideaLikesCount, nameof(bodyideaLikesCount), required: false);
            var __workflow_bodycommentsCount = WorkflowExpression.Compile(bodycommentsCount, nameof(bodycommentsCount), required: false);
            var __workflow_bodyxpPoints = WorkflowExpression.Compile(bodyxpPoints, nameof(bodyxpPoints), required: false);
            var __workflow_bodyideasCount = WorkflowExpression.Compile(bodyideasCount, nameof(bodyideasCount), required: false);
            var __workflow_bodyfunnelId = WorkflowExpression.Compile(bodyfunnelId, nameof(bodyfunnelId), required: false);
            var __workflow_bodylevel = WorkflowExpression.Compile(bodylevel, nameof(bodylevel), required: false);
            var __workflow_bodyxpLevel = WorkflowExpression.Compile(bodyxpLevel, nameof(bodyxpLevel), required: false);
            var __workflow_bodyprojectFunnelId = WorkflowExpression.Compile(bodyprojectFunnelId, nameof(bodyprojectFunnelId), required: false);
            var __workflow_bodychecklistScore = WorkflowExpression.Compile(bodychecklistScore, nameof(bodychecklistScore), required: false);
            var __workflow_bodyprovider = WorkflowExpression.Compile(bodyprovider, nameof(bodyprovider), required: false);
            var __workflow_bodyuid = WorkflowExpression.Compile(bodyuid, nameof(bodyuid), required: false);
            var __workflow_bodyemailSentAt = WorkflowExpression.Compile(bodyemailSentAt, nameof(bodyemailSentAt), required: false);
            var __workflow_bodyblockAllNotification = WorkflowExpression.Compile(bodyblockAllNotification, nameof(bodyblockAllNotification), required: false);
            var __workflow_bodydbName = WorkflowExpression.Compile(bodydbName, nameof(bodydbName), required: false);
            var __workflow_bodydeptId = WorkflowExpression.Compile(bodydeptId, nameof(bodydeptId), required: false);
            var __workflow_bodydeptName = WorkflowExpression.Compile(bodydeptName, nameof(bodydeptName), required: false);
            var __workflow_bodymainImage = WorkflowExpression.Compile(bodymainImage, nameof(bodymainImage), required: false);
            var __workflow_bodytempImage = WorkflowExpression.Compile(bodytempImage, nameof(bodytempImage), required: false);
            var __workflow_bodyimageConfigs = WorkflowExpression.Compile(bodyimageConfigs, nameof(bodyimageConfigs), required: false);
            var __workflow_bodyimageAutoGenerated = WorkflowExpression.Compile(bodyimageAutoGenerated, nameof(bodyimageAutoGenerated), required: false);
            var __workflow_bodyamAccount = WorkflowExpression.Compile(bodyamAccount, nameof(bodyamAccount), required: false);
            var __workflow_bodyuuid = WorkflowExpression.Compile(bodyuuid, nameof(bodyuuid), required: false);
            var __workflow_bodypasswordResetAttempts = WorkflowExpression.Compile(bodypasswordResetAttempts, nameof(bodypasswordResetAttempts), required: false);
            var __workflow_bodylastPasswordResetAt = WorkflowExpression.Compile(bodylastPasswordResetAt, nameof(bodylastPasswordResetAt), required: false);
            var __workflow_bodycustomDomain = WorkflowExpression.Compile(bodycustomDomain, nameof(bodycustomDomain), required: false);
            var __workflow_bodyuserRoleName = WorkflowExpression.Compile(bodyuserRoleName, nameof(bodyuserRoleName), required: false);
            var __workflow_bodytheme = WorkflowExpression.Compile(bodytheme, nameof(bodytheme), required: false);
            var __workflow_bodyuserType = WorkflowExpression.Compile(bodyuserType, nameof(bodyuserType), required: false);
            var __workflow_bodyviewSettings = WorkflowExpression.Compile(bodyviewSettings, nameof(bodyviewSettings), required: false);
            var __workflow_bodyreadManual = WorkflowExpression.Compile(bodyreadManual, nameof(bodyreadManual), required: false);
            var __workflow_bodyaddIdeaBox = WorkflowExpression.Compile(bodyaddIdeaBox, nameof(bodyaddIdeaBox), required: false);
            var __workflow_bodyvisitAgent = WorkflowExpression.Compile(bodyvisitAgent, nameof(bodyvisitAgent), required: false);
            var __workflow_bodyaddIdea = WorkflowExpression.Compile(bodyaddIdea, nameof(bodyaddIdea), required: false);
            var __workflow_bodyinvitePeople = WorkflowExpression.Compile(bodyinvitePeople, nameof(bodyinvitePeople), required: false);
            var __workflow_bodyaddBoardMission = WorkflowExpression.Compile(bodyaddBoardMission, nameof(bodyaddBoardMission), required: false);
            var __workflow_bodyaddProject = WorkflowExpression.Compile(bodyaddProject, nameof(bodyaddProject), required: false);
            var __workflow_bodycompletedChecklist = WorkflowExpression.Compile(bodycompletedChecklist, nameof(bodycompletedChecklist), required: false);
            return new DeferredBodyAction<PutusersIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfirstName != null)
                {
                    body["first_name"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["last_name"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodyprofilePic != null)
                {
                    body["profile_pic"] = ExpressionConverter.ConvertO(__workflow_bodyprofilePic);
                    bodypropCount++;
                }

                if (__workflow_bodypoints != null)
                {
                    body["points"] = ExpressionConverter.ConvertO(__workflow_bodypoints);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyId != null)
                {
                    body["company_id"] = ExpressionConverter.ConvertO(__workflow_bodycompanyId);
                    bodypropCount++;
                }

                if (__workflow_bodyuserRoleId != null)
                {
                    body["user_role_id"] = ExpressionConverter.ConvertO(__workflow_bodyuserRoleId);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyslug != null)
                {
                    body["slug"] = ExpressionConverter.ConvertO(__workflow_bodyslug);
                    bodypropCount++;
                }

                if (__workflow_bodyphoneNumber != null)
                {
                    body["phone_number"] = ExpressionConverter.ConvertO(__workflow_bodyphoneNumber);
                    bodypropCount++;
                }

                if (__workflow_bodylastSignOutAt != null)
                {
                    body["last_sign_out_at"] = ExpressionConverter.ConvertO(__workflow_bodylastSignOutAt);
                    bodypropCount++;
                }

                if (__workflow_bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(__workflow_bodyposition);
                    bodypropCount++;
                }

                if (__workflow_bodyprofileFlag != null)
                {
                    body["profile_flag"] = ExpressionConverter.ConvertO(__workflow_bodyprofileFlag);
                    bodypropCount++;
                }

                if (__workflow_bodyuserChecklist != null)
                {
                    body["user_checklist"] = ExpressionConverter.ConvertO(__workflow_bodyuserChecklist);
                    bodypropCount++;
                }

                if (__workflow_bodyideaLikesCount != null)
                {
                    body["idea_likes_count"] = ExpressionConverter.ConvertO(__workflow_bodyideaLikesCount);
                    bodypropCount++;
                }

                if (__workflow_bodycommentsCount != null)
                {
                    body["comments_count"] = ExpressionConverter.ConvertO(__workflow_bodycommentsCount);
                    bodypropCount++;
                }

                if (__workflow_bodyxpPoints != null)
                {
                    body["xp_points"] = ExpressionConverter.ConvertO(__workflow_bodyxpPoints);
                    bodypropCount++;
                }

                if (__workflow_bodyideasCount != null)
                {
                    body["ideas_count"] = ExpressionConverter.ConvertO(__workflow_bodyideasCount);
                    bodypropCount++;
                }

                if (__workflow_bodyfunnelId != null)
                {
                    body["funnel_id"] = ExpressionConverter.ConvertO(__workflow_bodyfunnelId);
                    bodypropCount++;
                }

                if (__workflow_bodylevel != null)
                {
                    body["level"] = ExpressionConverter.ConvertO(__workflow_bodylevel);
                    bodypropCount++;
                }

                if (__workflow_bodyxpLevel != null)
                {
                    body["xp_level"] = ExpressionConverter.ConvertO(__workflow_bodyxpLevel);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectFunnelId != null)
                {
                    body["project_funnel_id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectFunnelId);
                    bodypropCount++;
                }

                if (__workflow_bodychecklistScore != null)
                {
                    body["checklist_score"] = ExpressionConverter.ConvertO(__workflow_bodychecklistScore);
                    bodypropCount++;
                }

                if (__workflow_bodyprovider != null)
                {
                    body["provider"] = ExpressionConverter.ConvertO(__workflow_bodyprovider);
                    bodypropCount++;
                }

                if (__workflow_bodyuid != null)
                {
                    body["uid"] = ExpressionConverter.ConvertO(__workflow_bodyuid);
                    bodypropCount++;
                }

                if (__workflow_bodyemailSentAt != null)
                {
                    body["email_sent_at"] = ExpressionConverter.ConvertO(__workflow_bodyemailSentAt);
                    bodypropCount++;
                }

                if (__workflow_bodyblockAllNotification != null)
                {
                    body["block_all_notification"] = ExpressionConverter.ConvertO(__workflow_bodyblockAllNotification);
                    bodypropCount++;
                }

                if (__workflow_bodydbName != null)
                {
                    body["db_name"] = ExpressionConverter.ConvertO(__workflow_bodydbName);
                    bodypropCount++;
                }

                if (__workflow_bodydeptId != null)
                {
                    body["dept_id"] = ExpressionConverter.ConvertO(__workflow_bodydeptId);
                    bodypropCount++;
                }

                if (__workflow_bodydeptName != null)
                {
                    body["dept_name"] = ExpressionConverter.ConvertO(__workflow_bodydeptName);
                    bodypropCount++;
                }

                if (__workflow_bodymainImage != null)
                {
                    body["main_image"] = ExpressionConverter.ConvertO(__workflow_bodymainImage);
                    bodypropCount++;
                }

                if (__workflow_bodytempImage != null)
                {
                    body["temp_image"] = ExpressionConverter.ConvertO(__workflow_bodytempImage);
                    bodypropCount++;
                }

                if (__workflow_bodyimageConfigs != null)
                {
                    body["image_configs"] = ExpressionConverter.ConvertO(__workflow_bodyimageConfigs);
                    bodypropCount++;
                }

                if (__workflow_bodyimageAutoGenerated != null)
                {
                    body["image_auto_generated"] = ExpressionConverter.ConvertO(__workflow_bodyimageAutoGenerated);
                    bodypropCount++;
                }

                if (__workflow_bodyamAccount != null)
                {
                    body["am_account"] = ExpressionConverter.ConvertO(__workflow_bodyamAccount);
                    bodypropCount++;
                }

                if (__workflow_bodyuuid != null)
                {
                    body["uuid"] = ExpressionConverter.ConvertO(__workflow_bodyuuid);
                    bodypropCount++;
                }

                if (__workflow_bodypasswordResetAttempts != null)
                {
                    body["password_reset_attempts"] = ExpressionConverter.ConvertO(__workflow_bodypasswordResetAttempts);
                    bodypropCount++;
                }

                if (__workflow_bodylastPasswordResetAt != null)
                {
                    body["last_password_reset_at"] = ExpressionConverter.ConvertO(__workflow_bodylastPasswordResetAt);
                    bodypropCount++;
                }

                if (__workflow_bodycustomDomain != null)
                {
                    body["custom_domain"] = ExpressionConverter.ConvertO(__workflow_bodycustomDomain);
                    bodypropCount++;
                }

                if (__workflow_bodyuserRoleName != null)
                {
                    body["user_role_name"] = ExpressionConverter.ConvertO(__workflow_bodyuserRoleName);
                    bodypropCount++;
                }

                if (__workflow_bodytheme != null)
                {
                    body["theme"] = ExpressionConverter.ConvertO(__workflow_bodytheme);
                    bodypropCount++;
                }

                if (__workflow_bodyuserType != null)
                {
                    body["user_type"] = ExpressionConverter.ConvertO(__workflow_bodyuserType);
                    bodypropCount++;
                }

                if (__workflow_bodyviewSettings != null)
                {
                    body["view_settings"] = ExpressionConverter.ConvertO(__workflow_bodyviewSettings);
                    bodypropCount++;
                }

                if (__workflow_bodyreadManual != null)
                {
                    body["read_manual"] = ExpressionConverter.ConvertO(__workflow_bodyreadManual);
                    bodypropCount++;
                }

                if (__workflow_bodyaddIdeaBox != null)
                {
                    body["add_idea_box"] = ExpressionConverter.ConvertO(__workflow_bodyaddIdeaBox);
                    bodypropCount++;
                }

                if (__workflow_bodyvisitAgent != null)
                {
                    body["visit_agent"] = ExpressionConverter.ConvertO(__workflow_bodyvisitAgent);
                    bodypropCount++;
                }

                if (__workflow_bodyaddIdea != null)
                {
                    body["add_idea"] = ExpressionConverter.ConvertO(__workflow_bodyaddIdea);
                    bodypropCount++;
                }

                if (__workflow_bodyinvitePeople != null)
                {
                    body["invite_people"] = ExpressionConverter.ConvertO(__workflow_bodyinvitePeople);
                    bodypropCount++;
                }

                if (__workflow_bodyaddBoardMission != null)
                {
                    body["add_board_mission"] = ExpressionConverter.ConvertO(__workflow_bodyaddBoardMission);
                    bodypropCount++;
                }

                if (__workflow_bodyaddProject != null)
                {
                    body["add_project"] = ExpressionConverter.ConvertO(__workflow_bodyaddProject);
                    bodypropCount++;
                }

                if (__workflow_bodycompletedChecklist != null)
                {
                    body["completed_checklist"] = ExpressionConverter.ConvertO(__workflow_bodycompletedChecklist);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PutusersIdResponse>(callPayload);
            });
        }
    }

    public class AcceptmissionTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger TriggerIdeaCreated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/ideas/add_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggerIdeaUpdated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/ideas/edit_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggerIdeaDeleted(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/ideas/delete_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggerProjectCreated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/projects/add_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggerProjectUpdated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/projects/edit_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggerProjectDelete(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/projects/delete_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggertaskCreated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/tasks/add_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggercategoryCreated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/categories/add_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggerCategoryUpdated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/categories/edit_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggerCategoryDeleted(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/categories/delete_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggerdepartmentCreated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/departments/add_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggerdepartmentUpdated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/departments/edit_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggerdepartmentDeleted(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/departments/delete_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggerfunnellaneCreated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/funnel_lanes/add_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggerfunnellaneUpdated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/funnel_lanes/edit_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggerfunnellaneDeleted(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/funnel_lanes/delete_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggerfunnelCreated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/funnels/add_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggerfunnelUpdated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/funnels/edit_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggerfunnelDeleted(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/funnels/delete_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggermissionCreated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/missions/add_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggermissionUpdated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/missions/edit_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggermissionDeleted(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/missions/delete_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggertopicCreated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/topics/add_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggertopicUpdated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/topics/edit_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggertopicDeleted(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/topics/delete_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggertaskUpdated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/tasks/edit_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggertaskDeleted(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/tasks/delete_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggeruserCreated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/users/add_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggeruserUpdated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/users/edit_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger TriggeruserDeleted(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/general/v1/users/delete_redirect_url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }
    }

    public class GetcategoriesResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("round_id")]
        public int RoundId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("tags_count")]
        public int TagsCount { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("stage")]
        public int Stage { get; set; }

        [JsonProperty("department_id")]
        public int DepartmentId { get; set; }

        [JsonProperty("status_id")]
        public int StatusId { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("creator_name")]
        public string CreatorName { get; set; }

        [JsonProperty("idea_likes_count")]
        public int IdeaLikesCount { get; set; }

        [JsonProperty("comments_count")]
        public int CommentsCount { get; set; }

        [JsonProperty("mission_id")]
        public int MissionId { get; set; }

        [JsonProperty("board_id")]
        public string BoardId { get; set; }

        [JsonProperty("funnel_id")]
        public int FunnelId { get; set; }

        [JsonProperty("funnel_stage_id")]
        public int FunnelStageId { get; set; }

        [JsonProperty("idea_views")]
        public int IdeaViews { get; set; }

        [JsonProperty("funnel_status_id")]
        public int FunnelStatusId { get; set; }

        [JsonProperty("profit")]
        public string Profit { get; set; }

        [JsonProperty("cost")]
        public string Cost { get; set; }

        [JsonProperty("revenue")]
        public int Revenue { get; set; }

        [JsonProperty("status_name")]
        public string StatusName { get; set; }

        [JsonProperty("approved_at")]
        public string ApprovedAt { get; set; }

        [JsonProperty("denied_at")]
        public string DeniedAt { get; set; }

        [JsonProperty("reason_text")]
        public string ReasonText { get; set; }

        [JsonProperty("category_text")]
        public string CategoryText { get; set; }

        [JsonProperty("tag_text")]
        public string TagText { get; set; }
    }

    public class PostcategoriesResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("chip_color")]
        public string ChipColor { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }

    public class GetcategoriesIdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("chip_color")]
        public string ChipColor { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }

    public class PutcategoriesIdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("chip_color")]
        public string ChipColor { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }

    public class PatchcategoriesIdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("chip_color")]
        public string ChipColor { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }

    public class GetdepartmentsResponse
    {
        [JsonProperty("value")]
        public GetdepartmentsResponseValueTypeItem[] Value { get; set; }
    }

    public class GetdepartmentsResponseValueTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("ideas_count")]
        public int IdeasCount { get; set; }

        [JsonProperty("projects_count")]
        public int ProjectsCount { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }

    public class PostdepartmentsResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("ideas_count")]
        public int IdeasCount { get; set; }

        [JsonProperty("projects_count")]
        public int ProjectsCount { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }

    public class GetdepartmentsIdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("ideas_count")]
        public int IdeasCount { get; set; }

        [JsonProperty("projects_count")]
        public int ProjectsCount { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }

    public class PutdepartmentsIdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("ideas_count")]
        public int IdeasCount { get; set; }

        [JsonProperty("projects_count")]
        public int ProjectsCount { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }

    public class PatchdepartmentsIdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("ideas_count")]
        public int IdeasCount { get; set; }

        [JsonProperty("projects_count")]
        public int ProjectsCount { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }

    public class GetfunnelLanesResponse
    {
        [JsonProperty("value")]
        public GetfunnelLanesResponseValueTypeItem[] Value { get; set; }
    }

    public class GetfunnelLanesResponseValueTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("funnel_stage_type")]
        public int FunnelStageType { get; set; }

        [JsonProperty("stage_type")]
        public int StageType { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("deadline")]
        public string Deadline { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("modified_by")]
        public string ModifiedBy { get; set; }

        [JsonProperty("funnel_id")]
        public int FunnelId { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("funnel_status_id")]
        public int FunnelStatusId { get; set; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("enable_notification")]
        public bool EnableNotification { get; set; }

        [JsonProperty("ideas_count")]
        public int IdeasCount { get; set; }

        [JsonProperty("projects_count")]
        public int ProjectsCount { get; set; }
    }

    public class PostfunnelLanesResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("funnel_stage_type")]
        public int FunnelStageType { get; set; }

        [JsonProperty("stage_type")]
        public int StageType { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("deadline")]
        public string Deadline { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("modified_by")]
        public string ModifiedBy { get; set; }

        [JsonProperty("funnel_id")]
        public int FunnelId { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("funnel_status_id")]
        public int FunnelStatusId { get; set; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("enable_notification")]
        public bool EnableNotification { get; set; }

        [JsonProperty("ideas_count")]
        public int IdeasCount { get; set; }

        [JsonProperty("projects_count")]
        public int ProjectsCount { get; set; }
    }

    public class GetfunnelLanesIdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("funnel_stage_type")]
        public int FunnelStageType { get; set; }

        [JsonProperty("stage_type")]
        public int StageType { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("deadline")]
        public string Deadline { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("modified_by")]
        public string ModifiedBy { get; set; }

        [JsonProperty("funnel_id")]
        public int FunnelId { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("funnel_status_id")]
        public int FunnelStatusId { get; set; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("enable_notification")]
        public bool EnableNotification { get; set; }

        [JsonProperty("ideas_count")]
        public int IdeasCount { get; set; }

        [JsonProperty("projects_count")]
        public int ProjectsCount { get; set; }
    }

    public class PutfunnelLanesIdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("funnel_stage_type")]
        public int FunnelStageType { get; set; }

        [JsonProperty("stage_type")]
        public int StageType { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("deadline")]
        public string Deadline { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("modified_by")]
        public string ModifiedBy { get; set; }

        [JsonProperty("funnel_id")]
        public int FunnelId { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("funnel_status_id")]
        public int FunnelStatusId { get; set; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("enable_notification")]
        public bool EnableNotification { get; set; }

        [JsonProperty("ideas_count")]
        public int IdeasCount { get; set; }

        [JsonProperty("projects_count")]
        public int ProjectsCount { get; set; }
    }

    public class PatchfunnelLanesIdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("funnel_stage_type")]
        public int FunnelStageType { get; set; }

        [JsonProperty("stage_type")]
        public int StageType { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("deadline")]
        public string Deadline { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("modified_by")]
        public string ModifiedBy { get; set; }

        [JsonProperty("funnel_id")]
        public int FunnelId { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("funnel_status_id")]
        public int FunnelStatusId { get; set; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("enable_notification")]
        public bool EnableNotification { get; set; }

        [JsonProperty("ideas_count")]
        public int IdeasCount { get; set; }

        [JsonProperty("projects_count")]
        public int ProjectsCount { get; set; }
    }

    public class GetfunnelsResponse
    {
        [JsonProperty("value")]
        public GetfunnelsResponseValueTypeItem[] Value { get; set; }
    }

    public class GetfunnelsResponseValueTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("funnel_type")]
        public int FunnelType { get; set; }

        [JsonProperty("modified_by")]
        public int ModifiedBy { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("privacy_setting")]
        public int PrivacySetting { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("block_funnel_notification")]
        public bool BlockFunnelNotification { get; set; }

        [JsonProperty("ideas_count")]
        public int IdeasCount { get; set; }

        [JsonProperty("projects_count")]
        public int ProjectsCount { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }

    public class GetfunnelsIdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("funnel_type")]
        public int FunnelType { get; set; }

        [JsonProperty("modified_by")]
        public int ModifiedBy { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("privacy_setting")]
        public int PrivacySetting { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("block_funnel_notification")]
        public bool BlockFunnelNotification { get; set; }

        [JsonProperty("ideas_count")]
        public int IdeasCount { get; set; }

        [JsonProperty("projects_count")]
        public int ProjectsCount { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }

    public class PatchfunnelsIdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("funnel_type")]
        public int FunnelType { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }

    public class GetideasResponse
    {
        [JsonProperty("value")]
        public GetideasResponseValueTypeItem[] Value { get; set; }
    }

    public class GetideasResponseValueTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("round_id")]
        public string RoundId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("tags_count")]
        public int TagsCount { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("stage")]
        public int Stage { get; set; }

        [JsonProperty("department_id")]
        public string DepartmentId { get; set; }

        [JsonProperty("status_id")]
        public string StatusId { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("creator_name")]
        public string CreatorName { get; set; }

        [JsonProperty("idea_likes_count")]
        public int IdeaLikesCount { get; set; }

        [JsonProperty("comments_count")]
        public int CommentsCount { get; set; }

        [JsonProperty("mission_id")]
        public string MissionId { get; set; }

        [JsonProperty("board_id")]
        public string BoardId { get; set; }

        [JsonProperty("funnel_id")]
        public int FunnelId { get; set; }

        [JsonProperty("funnel_stage_id")]
        public int FunnelStageId { get; set; }

        [JsonProperty("idea_views")]
        public string IdeaViews { get; set; }

        [JsonProperty("funnel_status_id")]
        public int FunnelStatusId { get; set; }

        [JsonProperty("profit")]
        public string Profit { get; set; }

        [JsonProperty("cost")]
        public string Cost { get; set; }

        [JsonProperty("revenue")]
        public string Revenue { get; set; }

        [JsonProperty("status_name")]
        public string StatusName { get; set; }

        [JsonProperty("approved_at")]
        public string ApprovedAt { get; set; }

        [JsonProperty("denied_at")]
        public string DeniedAt { get; set; }

        [JsonProperty("reason_text")]
        public string ReasonText { get; set; }

        [JsonProperty("category_text")]
        public string CategoryText { get; set; }

        [JsonProperty("tag_text")]
        public string TagText { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }

        [JsonProperty("description_enriched")]
        public string DescriptionEnriched { get; set; }
    }

    public class GetideasIdeaIdTasksResponse
    {
        [JsonProperty("value")]
        public GetideasIdeaIdTasksResponseValueTypeItem[] Value { get; set; }
    }

    public class GetideasIdeaIdTasksResponseValueTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("idea_id")]
        public string IdeaId { get; set; }

        [JsonProperty("project_id")]
        public int ProjectId { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("phase")]
        public string Phase { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("scheduled_job_id")]
        public string ScheduledJobId { get; set; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("time_spent")]
        public string TimeSpent { get; set; }

        [JsonProperty("estimated_duration")]
        public string EstimatedDuration { get; set; }

        [JsonProperty("funnel_stage_id")]
        public string FunnelStageId { get; set; }

        [JsonProperty("deadline_timer")]
        public string DeadlineTimer { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }

    public class PostideasIdeaIdTasksResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("idea_id")]
        public string IdeaId { get; set; }

        [JsonProperty("project_id")]
        public int ProjectId { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("phase")]
        public string Phase { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("scheduled_job_id")]
        public string ScheduledJobId { get; set; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("time_spent")]
        public string TimeSpent { get; set; }

        [JsonProperty("estimated_duration")]
        public string EstimatedDuration { get; set; }

        [JsonProperty("funnel_stage_id")]
        public string FunnelStageId { get; set; }

        [JsonProperty("deadline_timer")]
        public string DeadlineTimer { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }

    public class GetmissionsResponse
    {
        [JsonProperty("value")]
        public GetmissionsResponseValueTypeItem[] Value { get; set; }
    }

    public class GetmissionsResponseValueTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("team_size")]
        public string TeamSize { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("end_duration")]
        public int EndDuration { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("mission_type")]
        public int MissionType { get; set; }

        [JsonProperty("inbox_question")]
        public string InboxQuestion { get; set; }

        [JsonProperty("department_id")]
        public string DepartmentId { get; set; }

        [JsonProperty("ideas_count")]
        public int IdeasCount { get; set; }

        [JsonProperty("likes_count")]
        public int LikesCount { get; set; }

        [JsonProperty("comments_count")]
        public int CommentsCount { get; set; }

        [JsonProperty("department_name")]
        public string DepartmentName { get; set; }

        [JsonProperty("mission_views")]
        public int MissionViews { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }

    public class GetmissionsIdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("team_size")]
        public string TeamSize { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("end_duration")]
        public int EndDuration { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("mission_type")]
        public int MissionType { get; set; }

        [JsonProperty("inbox_question")]
        public string InboxQuestion { get; set; }

        [JsonProperty("department_id")]
        public string DepartmentId { get; set; }

        [JsonProperty("ideas_count")]
        public int IdeasCount { get; set; }

        [JsonProperty("likes_count")]
        public int LikesCount { get; set; }

        [JsonProperty("comments_count")]
        public int CommentsCount { get; set; }

        [JsonProperty("department_name")]
        public string DepartmentName { get; set; }

        [JsonProperty("mission_views")]
        public int MissionViews { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }

    public class PutmissionsIdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }

    public class PatchmissionsIdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class GetprojectsResponse
    {
        [JsonProperty("value")]
        public GetprojectsResponseValueTypeItem[] Value { get; set; }
    }

    public class GetprojectsResponseValueTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("status_id")]
        public string StatusId { get; set; }

        [JsonProperty("department_id")]
        public string DepartmentId { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("stage_id")]
        public string StageId { get; set; }

        [JsonProperty("tags_count")]
        public int TagsCount { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("project_manager_id")]
        public int ProjectManagerId { get; set; }

        [JsonProperty("business_owner_id")]
        public string BusinessOwnerId { get; set; }

        [JsonProperty("progress")]
        public string Progress { get; set; }

        [JsonProperty("project_score")]
        public JToken ProjectScore { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("modified_by")]
        public string ModifiedBy { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("funnel_id")]
        public int FunnelId { get; set; }

        [JsonProperty("funnel_stage_id")]
        public int FunnelStageId { get; set; }

        [JsonProperty("funnel_status_id")]
        public int FunnelStatusId { get; set; }

        [JsonProperty("status_name")]
        public string StatusName { get; set; }

        [JsonProperty("approved_at")]
        public string ApprovedAt { get; set; }

        [JsonProperty("denied_at")]
        public string DeniedAt { get; set; }

        [JsonProperty("project_revenue")]
        public string ProjectRevenue { get; set; }

        [JsonProperty("project_cost")]
        public string ProjectCost { get; set; }

        [JsonProperty("project_profit")]
        public string ProjectProfit { get; set; }

        [JsonProperty("reason_text")]
        public string ReasonText { get; set; }

        [JsonProperty("category_text")]
        public string CategoryText { get; set; }

        [JsonProperty("tag_text")]
        public string TagText { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }

        [JsonProperty("description_enriched")]
        public string DescriptionEnriched { get; set; }
    }

    public class PostprojectsResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("status_id")]
        public string StatusId { get; set; }

        [JsonProperty("department_id")]
        public string DepartmentId { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("stage_id")]
        public string StageId { get; set; }

        [JsonProperty("tags_count")]
        public int TagsCount { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("project_manager_id")]
        public int ProjectManagerId { get; set; }

        [JsonProperty("business_owner_id")]
        public string BusinessOwnerId { get; set; }

        [JsonProperty("progress")]
        public string Progress { get; set; }

        [JsonProperty("project_score")]
        public JToken ProjectScore { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("modified_by")]
        public string ModifiedBy { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("funnel_id")]
        public int FunnelId { get; set; }

        [JsonProperty("funnel_stage_id")]
        public int FunnelStageId { get; set; }

        [JsonProperty("funnel_status_id")]
        public int FunnelStatusId { get; set; }

        [JsonProperty("status_name")]
        public string StatusName { get; set; }

        [JsonProperty("approved_at")]
        public string ApprovedAt { get; set; }

        [JsonProperty("denied_at")]
        public string DeniedAt { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }

        [JsonProperty("description_enriched")]
        public string DescriptionEnriched { get; set; }
    }

    public class GetprojectsIdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("status_id")]
        public string StatusId { get; set; }

        [JsonProperty("department_id")]
        public string DepartmentId { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("stage_id")]
        public string StageId { get; set; }

        [JsonProperty("tags_count")]
        public int TagsCount { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("project_manager_id")]
        public int ProjectManagerId { get; set; }

        [JsonProperty("business_owner_id")]
        public string BusinessOwnerId { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("modified_by")]
        public string ModifiedBy { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("funnel_id")]
        public int FunnelId { get; set; }

        [JsonProperty("funnel_stage_id")]
        public int FunnelStageId { get; set; }

        [JsonProperty("funnel_status_id")]
        public int FunnelStatusId { get; set; }

        [JsonProperty("status_name")]
        public string StatusName { get; set; }

        [JsonProperty("approved_at")]
        public string ApprovedAt { get; set; }

        [JsonProperty("denied_at")]
        public string DeniedAt { get; set; }

        [JsonProperty("project_revenue")]
        public int ProjectRevenue { get; set; }

        [JsonProperty("project_cost")]
        public int ProjectCost { get; set; }

        [JsonProperty("project_profit")]
        public int ProjectProfit { get; set; }

        [JsonProperty("reason_text")]
        public string ReasonText { get; set; }

        [JsonProperty("category_text")]
        public string CategoryText { get; set; }

        [JsonProperty("tag_text")]
        public string TagText { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }

        [JsonProperty("description_enriched")]
        public string DescriptionEnriched { get; set; }
    }

    public class PutprojectsIdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("status_id")]
        public string StatusId { get; set; }

        [JsonProperty("department_id")]
        public string DepartmentId { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("stage_id")]
        public string StageId { get; set; }

        [JsonProperty("tags_count")]
        public int TagsCount { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("project_manager_id")]
        public int ProjectManagerId { get; set; }

        [JsonProperty("business_owner_id")]
        public string BusinessOwnerId { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("project_score")]
        public JToken ProjectScore { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("modified_by")]
        public int ModifiedBy { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("funnel_id")]
        public int FunnelId { get; set; }

        [JsonProperty("funnel_stage_id")]
        public int FunnelStageId { get; set; }

        [JsonProperty("funnel_status_id")]
        public int FunnelStatusId { get; set; }

        [JsonProperty("status_name")]
        public string StatusName { get; set; }

        [JsonProperty("approved_at")]
        public string ApprovedAt { get; set; }

        [JsonProperty("denied_at")]
        public string DeniedAt { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }

        [JsonProperty("description_enriched")]
        public string DescriptionEnriched { get; set; }
    }

    public class PatchprojectsIdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("status_id")]
        public string StatusId { get; set; }

        [JsonProperty("department_id")]
        public string DepartmentId { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("stage_id")]
        public string StageId { get; set; }

        [JsonProperty("tags_count")]
        public int TagsCount { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("project_manager_id")]
        public int ProjectManagerId { get; set; }

        [JsonProperty("business_owner_id")]
        public string BusinessOwnerId { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("project_score")]
        public JToken ProjectScore { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("modified_by")]
        public int ModifiedBy { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("funnel_id")]
        public int FunnelId { get; set; }

        [JsonProperty("funnel_stage_id")]
        public int FunnelStageId { get; set; }

        [JsonProperty("funnel_status_id")]
        public int FunnelStatusId { get; set; }

        [JsonProperty("status_name")]
        public string StatusName { get; set; }

        [JsonProperty("approved_at")]
        public string ApprovedAt { get; set; }

        [JsonProperty("denied_at")]
        public string DeniedAt { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }

        [JsonProperty("description_enriched")]
        public string DescriptionEnriched { get; set; }
    }

    public class GetprojectsProjectIdTasksResponse
    {
        [JsonProperty("value")]
        public GetprojectsProjectIdTasksResponseValueTypeItem[] Value { get; set; }
    }

    public class GetprojectsProjectIdTasksResponseValueTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("idea_id")]
        public string IdeaId { get; set; }

        [JsonProperty("project_id")]
        public int ProjectId { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("phase")]
        public string Phase { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("scheduled_job_id")]
        public string ScheduledJobId { get; set; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("time_spent")]
        public string TimeSpent { get; set; }

        [JsonProperty("estimated_duration")]
        public string EstimatedDuration { get; set; }

        [JsonProperty("funnel_stage_id")]
        public string FunnelStageId { get; set; }

        [JsonProperty("deadline_timer")]
        public string DeadlineTimer { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }

    public class PostprojectsProjectIdTasksResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("idea_id")]
        public string IdeaId { get; set; }

        [JsonProperty("project_id")]
        public int ProjectId { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("phase")]
        public string Phase { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("scheduled_job_id")]
        public string ScheduledJobId { get; set; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("time_spent")]
        public string TimeSpent { get; set; }

        [JsonProperty("estimated_duration")]
        public string EstimatedDuration { get; set; }

        [JsonProperty("funnel_stage_id")]
        public string FunnelStageId { get; set; }

        [JsonProperty("deadline_timer")]
        public string DeadlineTimer { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }

    public class GetTaskBySyncIdResponse
    {
        [JsonProperty("value")]
        public GetTaskBySyncIdResponseValueTypeItem[] Value { get; set; }
    }

    public class GetTaskBySyncIdResponseValueTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("idea_id")]
        public string IdeaId { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("phase")]
        public string Phase { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("scheduled_job_id")]
        public string ScheduledJobId { get; set; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("time_spent")]
        public string TimeSpent { get; set; }

        [JsonProperty("estimated_duration")]
        public string EstimatedDuration { get; set; }

        [JsonProperty("funnel_stage_id")]
        public string FunnelStageId { get; set; }

        [JsonProperty("deadline_timer")]
        public string DeadlineTimer { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }
    }

    public class PosttasksResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("idea_id")]
        public string IdeaId { get; set; }

        [JsonProperty("project_id")]
        public int ProjectId { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("phase")]
        public string Phase { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("scheduled_job_id")]
        public string ScheduledJobId { get; set; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("time_spent")]
        public string TimeSpent { get; set; }

        [JsonProperty("estimated_duration")]
        public string EstimatedDuration { get; set; }

        [JsonProperty("funnel_stage_id")]
        public string FunnelStageId { get; set; }

        [JsonProperty("deadline_timer")]
        public string DeadlineTimer { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }

    public class GettasksIdResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("idea_id")]
        public string IdeaId { get; set; }

        [JsonProperty("project_id")]
        public int ProjectId { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("phase")]
        public string Phase { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("scheduled_job_id")]
        public string ScheduledJobId { get; set; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("time_spent")]
        public string TimeSpent { get; set; }

        [JsonProperty("estimated_duration")]
        public string EstimatedDuration { get; set; }

        [JsonProperty("funnel_stage_id")]
        public string FunnelStageId { get; set; }

        [JsonProperty("deadline_timer")]
        public string DeadlineTimer { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }

    public class PatchtasksIdResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("idea_id")]
        public string IdeaId { get; set; }

        [JsonProperty("project_id")]
        public int ProjectId { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("phase")]
        public string Phase { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("scheduled_job_id")]
        public string ScheduledJobId { get; set; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("time_spent")]
        public string TimeSpent { get; set; }

        [JsonProperty("estimated_duration")]
        public string EstimatedDuration { get; set; }

        [JsonProperty("funnel_stage_id")]
        public string FunnelStageId { get; set; }

        [JsonProperty("deadline_timer")]
        public string DeadlineTimer { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }
    }

    public class GettopicsResponse
    {
        [JsonProperty("value")]
        public GettopicsResponseValueTypeItem[] Value { get; set; }
    }

    public class GettopicsResponseValueTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("last_active")]
        public string LastActive { get; set; }

        [JsonProperty("modified_by")]
        public int ModifiedBy { get; set; }

        [JsonProperty("ideas_count")]
        public int IdeasCount { get; set; }

        [JsonProperty("projects_count")]
        public int ProjectsCount { get; set; }
    }

    public class GetusersResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class PostusersResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("profile_pic")]
        public string ProfilePic { get; set; }

        [JsonProperty("current_sign_in_at")]
        public string CurrentSignInAt { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user_role_id")]
        public string UserRoleId { get; set; }

        [JsonProperty("user_role_name")]
        public string UserRoleName { get; set; }

        [JsonProperty("ideas_count")]
        public int IdeasCount { get; set; }

        [JsonProperty("idea_likes_count")]
        public int IdeaLikesCount { get; set; }

        [JsonProperty("comments_count")]
        public int CommentsCount { get; set; }

        [JsonProperty("xp_points")]
        public string XpPoints { get; set; }

        [JsonProperty("dept_id")]
        public string DeptId { get; set; }

        [JsonProperty("dept_name")]
        public string DeptName { get; set; }

        [JsonProperty("department_name")]
        public string DepartmentName { get; set; }
    }

    public class GetusersGetCompanyResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class GetusersIdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("profile_pic")]
        public string ProfilePic { get; set; }

        [JsonProperty("current_sign_in_at")]
        public string CurrentSignInAt { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user_role_id")]
        public int UserRoleId { get; set; }

        [JsonProperty("user_role_name")]
        public string UserRoleName { get; set; }

        [JsonProperty("ideas_count")]
        public int IdeasCount { get; set; }

        [JsonProperty("idea_likes_count")]
        public int IdeaLikesCount { get; set; }

        [JsonProperty("comments_count")]
        public int CommentsCount { get; set; }

        [JsonProperty("xp_points")]
        public int XpPoints { get; set; }

        [JsonProperty("dept_id")]
        public int DeptId { get; set; }

        [JsonProperty("dept_name")]
        public string DeptName { get; set; }

        [JsonProperty("department_name")]
        public string DepartmentName { get; set; }
    }

    public class PutusersIdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("profile_pic")]
        public string ProfilePic { get; set; }

        [JsonProperty("current_sign_in_at")]
        public string CurrentSignInAt { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user_role_id")]
        public int UserRoleId { get; set; }

        [JsonProperty("user_role_name")]
        public string UserRoleName { get; set; }

        [JsonProperty("ideas_count")]
        public int IdeasCount { get; set; }

        [JsonProperty("idea_likes_count")]
        public int IdeaLikesCount { get; set; }

        [JsonProperty("comments_count")]
        public int CommentsCount { get; set; }

        [JsonProperty("xp_points")]
        public int XpPoints { get; set; }

        [JsonProperty("dept_id")]
        public int DeptId { get; set; }

        [JsonProperty("dept_name")]
        public string DeptName { get; set; }

        [JsonProperty("department_name")]
        public string DepartmentName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Acceptmission;

    public partial class WorkflowManagedActions
    {
        public AcceptmissionActions Acceptmission(string connectionId) => new AcceptmissionActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AcceptmissionTriggers Acceptmission(string connectionId) => new AcceptmissionTriggers(connectionId);
    }
}
