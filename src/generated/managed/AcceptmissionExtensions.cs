//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Acceptmission
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

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
        [WorkflowExpressionFactory(nameof(__BuildPostcategories))]
        public IBodyWorkflowAction<PostcategoriesResponse> Postcategories([WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<int> bodyposition = null, [WorkflowExpression] Func<string> bodychipColor = null, [WorkflowExpression] Func<string> bodymissionsId = null, [WorkflowExpression] Func<int> bodycompanyId = null, [WorkflowExpression] Func<string> bodyimage = null, [WorkflowExpression] Func<int> bodyuserId = null, [WorkflowExpression] Func<string> bodytempImage = null, [WorkflowExpression] Func<string> bodymainImage = null, [WorkflowExpression] Func<string> bodyimageConfigs = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodyupdatedBy = null, [WorkflowExpression] Func<string> bodyrecordUrl = null, [WorkflowExpression] Func<string> bodysyncId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostcategoriesResponse> __BuildPostcategories(WorkflowExpression<string> bodytitle = null, WorkflowExpression<int> bodyposition = null, WorkflowExpression<string> bodychipColor = null, WorkflowExpression<string> bodymissionsId = null, WorkflowExpression<int> bodycompanyId = null, WorkflowExpression<string> bodyimage = null, WorkflowExpression<int> bodyuserId = null, WorkflowExpression<string> bodytempImage = null, WorkflowExpression<string> bodymainImage = null, WorkflowExpression<string> bodyimageConfigs = null, WorkflowExpression<string> bodyownerId = null, WorkflowExpression<string> bodyupdatedBy = null, WorkflowExpression<string> bodyrecordUrl = null, WorkflowExpression<string> bodysyncId = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            WorkflowExpression.Validate(bodychipColor, nameof(bodychipColor), required: false);
            WorkflowExpression.Validate(bodymissionsId, nameof(bodymissionsId), required: false);
            WorkflowExpression.Validate(bodycompanyId, nameof(bodycompanyId), required: false);
            WorkflowExpression.Validate(bodyimage, nameof(bodyimage), required: false);
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            WorkflowExpression.Validate(bodytempImage, nameof(bodytempImage), required: false);
            WorkflowExpression.Validate(bodymainImage, nameof(bodymainImage), required: false);
            WorkflowExpression.Validate(bodyimageConfigs, nameof(bodyimageConfigs), required: false);
            WorkflowExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            WorkflowExpression.Validate(bodyupdatedBy, nameof(bodyupdatedBy), required: false);
            WorkflowExpression.Validate(bodyrecordUrl, nameof(bodyrecordUrl), required: false);
            WorkflowExpression.Validate(bodysyncId, nameof(bodysyncId), required: false);
            return new DeferredBodyAction<PostcategoriesResponse>(() =>
            {
                var apiCallPath = "/general/v1/categories";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(bodyposition);
                    bodypropCount++;
                }

                if (bodychipColor != null)
                {
                    body["chip_color"] = ExpressionConverter.ConvertO(bodychipColor);
                    bodypropCount++;
                }

                if (bodymissionsId != null)
                {
                    body["missions_id"] = ExpressionConverter.ConvertO(bodymissionsId);
                    bodypropCount++;
                }

                if (bodycompanyId != null)
                {
                    body["company_id"] = ExpressionConverter.ConvertO(bodycompanyId);
                    bodypropCount++;
                }

                if (bodyimage != null)
                {
                    body["image"] = ExpressionConverter.ConvertO(bodyimage);
                    bodypropCount++;
                }

                if (bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(bodyuserId);
                    bodypropCount++;
                }

                if (bodytempImage != null)
                {
                    body["temp_image"] = ExpressionConverter.ConvertO(bodytempImage);
                    bodypropCount++;
                }

                if (bodymainImage != null)
                {
                    body["main_image"] = ExpressionConverter.ConvertO(bodymainImage);
                    bodypropCount++;
                }

                if (bodyimageConfigs != null)
                {
                    body["image_configs"] = ExpressionConverter.ConvertO(bodyimageConfigs);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["owner_id"] = ExpressionConverter.ConvertO(bodyownerId);
                    bodypropCount++;
                }

                if (bodyupdatedBy != null)
                {
                    body["updated_by"] = ExpressionConverter.ConvertO(bodyupdatedBy);
                    bodypropCount++;
                }

                if (bodyrecordUrl != null)
                {
                    body["record_url"] = ExpressionConverter.ConvertO(bodyrecordUrl);
                    bodypropCount++;
                }

                if (bodysyncId != null)
                {
                    body["sync_id"] = ExpressionConverter.ConvertO(bodysyncId);
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
        [WorkflowExpressionFactory(nameof(__BuildGetcategoriesId))]
        public IBodyWorkflowAction<GetcategoriesIdResponse> GetcategoriesId([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetcategoriesIdResponse> __BuildGetcategoriesId(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GetcategoriesIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/categories/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetcategoriesIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [WorkflowExpressionFactory(nameof(__BuildDeletecategoriesId))]
        public IWorkflowAction DeletecategoriesId([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeletecategoriesId(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/categories/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [WorkflowExpressionFactory(nameof(__BuildPutcategoriesId))]
        public IBodyWorkflowAction<PutcategoriesIdResponse> PutcategoriesId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<int> bodyposition = null, [WorkflowExpression] Func<string> bodychipColor = null, [WorkflowExpression] Func<string> bodymissionsId = null, [WorkflowExpression] Func<int> bodycompanyId = null, [WorkflowExpression] Func<string> bodyimage = null, [WorkflowExpression] Func<int> bodyuserId = null, [WorkflowExpression] Func<string> bodytempImage = null, [WorkflowExpression] Func<string> bodymainImage = null, [WorkflowExpression] Func<string> bodyimageConfigs = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodyupdatedBy = null, [WorkflowExpression] Func<string> bodyrecordUrl = null, [WorkflowExpression] Func<string> bodysyncId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PutcategoriesIdResponse> __BuildPutcategoriesId(WorkflowExpression<string> id, WorkflowExpression<string> bodytitle = null, WorkflowExpression<int> bodyposition = null, WorkflowExpression<string> bodychipColor = null, WorkflowExpression<string> bodymissionsId = null, WorkflowExpression<int> bodycompanyId = null, WorkflowExpression<string> bodyimage = null, WorkflowExpression<int> bodyuserId = null, WorkflowExpression<string> bodytempImage = null, WorkflowExpression<string> bodymainImage = null, WorkflowExpression<string> bodyimageConfigs = null, WorkflowExpression<string> bodyownerId = null, WorkflowExpression<string> bodyupdatedBy = null, WorkflowExpression<string> bodyrecordUrl = null, WorkflowExpression<string> bodysyncId = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            WorkflowExpression.Validate(bodychipColor, nameof(bodychipColor), required: false);
            WorkflowExpression.Validate(bodymissionsId, nameof(bodymissionsId), required: false);
            WorkflowExpression.Validate(bodycompanyId, nameof(bodycompanyId), required: false);
            WorkflowExpression.Validate(bodyimage, nameof(bodyimage), required: false);
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            WorkflowExpression.Validate(bodytempImage, nameof(bodytempImage), required: false);
            WorkflowExpression.Validate(bodymainImage, nameof(bodymainImage), required: false);
            WorkflowExpression.Validate(bodyimageConfigs, nameof(bodyimageConfigs), required: false);
            WorkflowExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            WorkflowExpression.Validate(bodyupdatedBy, nameof(bodyupdatedBy), required: false);
            WorkflowExpression.Validate(bodyrecordUrl, nameof(bodyrecordUrl), required: false);
            WorkflowExpression.Validate(bodysyncId, nameof(bodysyncId), required: false);
            return new DeferredBodyAction<PutcategoriesIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/categories/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(bodyposition);
                    bodypropCount++;
                }

                if (bodychipColor != null)
                {
                    body["chip_color"] = ExpressionConverter.ConvertO(bodychipColor);
                    bodypropCount++;
                }

                if (bodymissionsId != null)
                {
                    body["missions_id"] = ExpressionConverter.ConvertO(bodymissionsId);
                    bodypropCount++;
                }

                if (bodycompanyId != null)
                {
                    body["company_id"] = ExpressionConverter.ConvertO(bodycompanyId);
                    bodypropCount++;
                }

                if (bodyimage != null)
                {
                    body["image"] = ExpressionConverter.ConvertO(bodyimage);
                    bodypropCount++;
                }

                if (bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(bodyuserId);
                    bodypropCount++;
                }

                if (bodytempImage != null)
                {
                    body["temp_image"] = ExpressionConverter.ConvertO(bodytempImage);
                    bodypropCount++;
                }

                if (bodymainImage != null)
                {
                    body["main_image"] = ExpressionConverter.ConvertO(bodymainImage);
                    bodypropCount++;
                }

                if (bodyimageConfigs != null)
                {
                    body["image_configs"] = ExpressionConverter.ConvertO(bodyimageConfigs);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["owner_id"] = ExpressionConverter.ConvertO(bodyownerId);
                    bodypropCount++;
                }

                if (bodyupdatedBy != null)
                {
                    body["updated_by"] = ExpressionConverter.ConvertO(bodyupdatedBy);
                    bodypropCount++;
                }

                if (bodyrecordUrl != null)
                {
                    body["record_url"] = ExpressionConverter.ConvertO(bodyrecordUrl);
                    bodypropCount++;
                }

                if (bodysyncId != null)
                {
                    body["sync_id"] = ExpressionConverter.ConvertO(bodysyncId);
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
        [WorkflowExpressionFactory(nameof(__BuildPatchcategoriesId))]
        public IBodyWorkflowAction<PatchcategoriesIdResponse> PatchcategoriesId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PatchcategoriesIdResponse> __BuildPatchcategoriesId(WorkflowExpression<string> id, WorkflowExpression<string> bodytitle = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            return new DeferredBodyAction<PatchcategoriesIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/categories/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
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
        [WorkflowExpressionFactory(nameof(__BuildPostdepartments))]
        public IBodyWorkflowAction<PostdepartmentsResponse> Postdepartments([WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<int> bodyposition = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostdepartmentsResponse> __BuildPostdepartments(WorkflowExpression<string> bodytitle = null, WorkflowExpression<int> bodyposition = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            return new DeferredBodyAction<PostdepartmentsResponse>(() =>
            {
                var apiCallPath = "/general/v1/departments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(bodyposition);
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
        [WorkflowExpressionFactory(nameof(__BuildGetdepartmentsId))]
        public IBodyWorkflowAction<GetdepartmentsIdResponse> GetdepartmentsId([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetdepartmentsIdResponse> __BuildGetdepartmentsId(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GetdepartmentsIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/departments/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetdepartmentsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [WorkflowExpressionFactory(nameof(__BuildDeletedepartmentsId))]
        public IWorkflowAction DeletedepartmentsId([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeletedepartmentsId(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/departments/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [WorkflowExpressionFactory(nameof(__BuildPutdepartmentsId))]
        public IBodyWorkflowAction<PutdepartmentsIdResponse> PutdepartmentsId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<int> bodyposition = null, [WorkflowExpression] Func<int> bodycompanyId = null, [WorkflowExpression] Func<int> bodyideasCount = null, [WorkflowExpression] Func<int> bodyprojectsCount = null, [WorkflowExpression] Func<string> bodyimage = null, [WorkflowExpression] Func<int> bodyuserId = null, [WorkflowExpression] Func<string> bodytempImage = null, [WorkflowExpression] Func<string> bodymainImage = null, [WorkflowExpression] Func<string> bodyimageConfigs = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodyupdatedBy = null, [WorkflowExpression] Func<string> bodyrecordUrl = null, [WorkflowExpression] Func<string> bodysyncId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PutdepartmentsIdResponse> __BuildPutdepartmentsId(WorkflowExpression<string> id, WorkflowExpression<string> bodytitle = null, WorkflowExpression<int> bodyposition = null, WorkflowExpression<int> bodycompanyId = null, WorkflowExpression<int> bodyideasCount = null, WorkflowExpression<int> bodyprojectsCount = null, WorkflowExpression<string> bodyimage = null, WorkflowExpression<int> bodyuserId = null, WorkflowExpression<string> bodytempImage = null, WorkflowExpression<string> bodymainImage = null, WorkflowExpression<string> bodyimageConfigs = null, WorkflowExpression<string> bodyownerId = null, WorkflowExpression<string> bodyupdatedBy = null, WorkflowExpression<string> bodyrecordUrl = null, WorkflowExpression<string> bodysyncId = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            WorkflowExpression.Validate(bodycompanyId, nameof(bodycompanyId), required: false);
            WorkflowExpression.Validate(bodyideasCount, nameof(bodyideasCount), required: false);
            WorkflowExpression.Validate(bodyprojectsCount, nameof(bodyprojectsCount), required: false);
            WorkflowExpression.Validate(bodyimage, nameof(bodyimage), required: false);
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            WorkflowExpression.Validate(bodytempImage, nameof(bodytempImage), required: false);
            WorkflowExpression.Validate(bodymainImage, nameof(bodymainImage), required: false);
            WorkflowExpression.Validate(bodyimageConfigs, nameof(bodyimageConfigs), required: false);
            WorkflowExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            WorkflowExpression.Validate(bodyupdatedBy, nameof(bodyupdatedBy), required: false);
            WorkflowExpression.Validate(bodyrecordUrl, nameof(bodyrecordUrl), required: false);
            WorkflowExpression.Validate(bodysyncId, nameof(bodysyncId), required: false);
            return new DeferredBodyAction<PutdepartmentsIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/departments/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(bodyposition);
                    bodypropCount++;
                }

                if (bodycompanyId != null)
                {
                    body["company_id"] = ExpressionConverter.ConvertO(bodycompanyId);
                    bodypropCount++;
                }

                if (bodyideasCount != null)
                {
                    body["ideas_count"] = ExpressionConverter.ConvertO(bodyideasCount);
                    bodypropCount++;
                }

                if (bodyprojectsCount != null)
                {
                    body["projects_count"] = ExpressionConverter.ConvertO(bodyprojectsCount);
                    bodypropCount++;
                }

                if (bodyimage != null)
                {
                    body["image"] = ExpressionConverter.ConvertO(bodyimage);
                    bodypropCount++;
                }

                if (bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(bodyuserId);
                    bodypropCount++;
                }

                if (bodytempImage != null)
                {
                    body["temp_image"] = ExpressionConverter.ConvertO(bodytempImage);
                    bodypropCount++;
                }

                if (bodymainImage != null)
                {
                    body["main_image"] = ExpressionConverter.ConvertO(bodymainImage);
                    bodypropCount++;
                }

                if (bodyimageConfigs != null)
                {
                    body["image_configs"] = ExpressionConverter.ConvertO(bodyimageConfigs);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["owner_id"] = ExpressionConverter.ConvertO(bodyownerId);
                    bodypropCount++;
                }

                if (bodyupdatedBy != null)
                {
                    body["updated_by"] = ExpressionConverter.ConvertO(bodyupdatedBy);
                    bodypropCount++;
                }

                if (bodyrecordUrl != null)
                {
                    body["record_url"] = ExpressionConverter.ConvertO(bodyrecordUrl);
                    bodypropCount++;
                }

                if (bodysyncId != null)
                {
                    body["sync_id"] = ExpressionConverter.ConvertO(bodysyncId);
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
        [WorkflowExpressionFactory(nameof(__BuildPatchdepartmentsId))]
        public IBodyWorkflowAction<PatchdepartmentsIdResponse> PatchdepartmentsId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<int> bodyposition = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PatchdepartmentsIdResponse> __BuildPatchdepartmentsId(WorkflowExpression<string> id, WorkflowExpression<string> bodytitle = null, WorkflowExpression<int> bodyposition = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            return new DeferredBodyAction<PatchdepartmentsIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/departments/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(bodyposition);
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
        [WorkflowExpressionFactory(nameof(__BuildPostfunnelLanes))]
        public IBodyWorkflowAction<PostfunnelLanesResponse> PostfunnelLanes([WorkflowExpression] Func<string> bodytitle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostfunnelLanesResponse> __BuildPostfunnelLanes(WorkflowExpression<string> bodytitle = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            return new DeferredBodyAction<PostfunnelLanesResponse>(() =>
            {
                var apiCallPath = "/general/v1/funnel_lanes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
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
        [WorkflowExpressionFactory(nameof(__BuildGetfunnelLanesId))]
        public IBodyWorkflowAction<GetfunnelLanesIdResponse> GetfunnelLanesId([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetfunnelLanesIdResponse> __BuildGetfunnelLanesId(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GetfunnelLanesIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/funnel_lanes/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetfunnelLanesIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [WorkflowExpressionFactory(nameof(__BuildDeletefunnelLanesId))]
        public IWorkflowAction DeletefunnelLanesId([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeletefunnelLanesId(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/funnel_lanes/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [WorkflowExpressionFactory(nameof(__BuildPutfunnelLanesId))]
        public IBodyWorkflowAction<PutfunnelLanesIdResponse> PutfunnelLanesId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<int> bodyfunnelStageType = null, [WorkflowExpression] Func<int> bodystageType = null, [WorkflowExpression] Func<string> bodycolor = null, [WorkflowExpression] Func<int> bodydeadline = null, [WorkflowExpression] Func<int> bodyposition = null, [WorkflowExpression] Func<string> bodyuserId = null, [WorkflowExpression] Func<string> bodymodifiedBy = null, [WorkflowExpression] Func<int> bodyfunnelId = null, [WorkflowExpression] Func<int> bodyfunnelStatusId = null, [WorkflowExpression] Func<int> bodyownerId = null, [WorkflowExpression] Func<bool> bodyenableNotification = null, [WorkflowExpression] Func<int> bodyideasCount = null, [WorkflowExpression] Func<int> bodyprojectsCount = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodylink = null, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<bool> bodyshowInGraph = null, [WorkflowExpression] Func<bool> bodyshowInBubble = null, [WorkflowExpression] Func<int> bodyconfettiType = null, [WorkflowExpression] Func<string> bodyautomationOwnerId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PutfunnelLanesIdResponse> __BuildPutfunnelLanesId(WorkflowExpression<string> id, WorkflowExpression<string> bodytitle = null, WorkflowExpression<int> bodyfunnelStageType = null, WorkflowExpression<int> bodystageType = null, WorkflowExpression<string> bodycolor = null, WorkflowExpression<int> bodydeadline = null, WorkflowExpression<int> bodyposition = null, WorkflowExpression<string> bodyuserId = null, WorkflowExpression<string> bodymodifiedBy = null, WorkflowExpression<int> bodyfunnelId = null, WorkflowExpression<int> bodyfunnelStatusId = null, WorkflowExpression<int> bodyownerId = null, WorkflowExpression<bool> bodyenableNotification = null, WorkflowExpression<int> bodyideasCount = null, WorkflowExpression<int> bodyprojectsCount = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodylink = null, WorkflowExpression<string> bodyfile = null, WorkflowExpression<bool> bodyshowInGraph = null, WorkflowExpression<bool> bodyshowInBubble = null, WorkflowExpression<int> bodyconfettiType = null, WorkflowExpression<string> bodyautomationOwnerId = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodyfunnelStageType, nameof(bodyfunnelStageType), required: false);
            WorkflowExpression.Validate(bodystageType, nameof(bodystageType), required: false);
            WorkflowExpression.Validate(bodycolor, nameof(bodycolor), required: false);
            WorkflowExpression.Validate(bodydeadline, nameof(bodydeadline), required: false);
            WorkflowExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            WorkflowExpression.Validate(bodymodifiedBy, nameof(bodymodifiedBy), required: false);
            WorkflowExpression.Validate(bodyfunnelId, nameof(bodyfunnelId), required: false);
            WorkflowExpression.Validate(bodyfunnelStatusId, nameof(bodyfunnelStatusId), required: false);
            WorkflowExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            WorkflowExpression.Validate(bodyenableNotification, nameof(bodyenableNotification), required: false);
            WorkflowExpression.Validate(bodyideasCount, nameof(bodyideasCount), required: false);
            WorkflowExpression.Validate(bodyprojectsCount, nameof(bodyprojectsCount), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodylink, nameof(bodylink), required: false);
            WorkflowExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            WorkflowExpression.Validate(bodyshowInGraph, nameof(bodyshowInGraph), required: false);
            WorkflowExpression.Validate(bodyshowInBubble, nameof(bodyshowInBubble), required: false);
            WorkflowExpression.Validate(bodyconfettiType, nameof(bodyconfettiType), required: false);
            WorkflowExpression.Validate(bodyautomationOwnerId, nameof(bodyautomationOwnerId), required: false);
            return new DeferredBodyAction<PutfunnelLanesIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/funnel_lanes/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodyfunnelStageType != null)
                {
                    body["funnel_stage_type"] = ExpressionConverter.ConvertO(bodyfunnelStageType);
                    bodypropCount++;
                }

                if (bodystageType != null)
                {
                    body["stage_type"] = ExpressionConverter.ConvertO(bodystageType);
                    bodypropCount++;
                }

                if (bodycolor != null)
                {
                    body["color"] = ExpressionConverter.ConvertO(bodycolor);
                    bodypropCount++;
                }

                if (bodydeadline != null)
                {
                    body["deadline"] = ExpressionConverter.ConvertO(bodydeadline);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(bodyposition);
                    bodypropCount++;
                }

                if (bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(bodyuserId);
                    bodypropCount++;
                }

                if (bodymodifiedBy != null)
                {
                    body["modified_by"] = ExpressionConverter.ConvertO(bodymodifiedBy);
                    bodypropCount++;
                }

                if (bodyfunnelId != null)
                {
                    body["funnel_id"] = ExpressionConverter.ConvertO(bodyfunnelId);
                    bodypropCount++;
                }

                if (bodyfunnelStatusId != null)
                {
                    body["funnel_status_id"] = ExpressionConverter.ConvertO(bodyfunnelStatusId);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["owner_id"] = ExpressionConverter.ConvertO(bodyownerId);
                    bodypropCount++;
                }

                if (bodyenableNotification != null)
                {
                    body["enable_notification"] = ExpressionConverter.ConvertO(bodyenableNotification);
                    bodypropCount++;
                }

                if (bodyideasCount != null)
                {
                    body["ideas_count"] = ExpressionConverter.ConvertO(bodyideasCount);
                    bodypropCount++;
                }

                if (bodyprojectsCount != null)
                {
                    body["projects_count"] = ExpressionConverter.ConvertO(bodyprojectsCount);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodylink != null)
                {
                    body["link"] = ExpressionConverter.ConvertO(bodylink);
                    bodypropCount++;
                }

                if (bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(bodyfile);
                    bodypropCount++;
                }

                if (bodyshowInGraph != null)
                {
                    body["show_in_graph"] = ExpressionConverter.ConvertO(bodyshowInGraph);
                    bodypropCount++;
                }

                if (bodyshowInBubble != null)
                {
                    body["show_in_bubble"] = ExpressionConverter.ConvertO(bodyshowInBubble);
                    bodypropCount++;
                }

                if (bodyconfettiType != null)
                {
                    body["confetti_type"] = ExpressionConverter.ConvertO(bodyconfettiType);
                    bodypropCount++;
                }

                if (bodyautomationOwnerId != null)
                {
                    body["automation_owner_id"] = ExpressionConverter.ConvertO(bodyautomationOwnerId);
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
        [WorkflowExpressionFactory(nameof(__BuildPatchfunnelLanesId))]
        public IBodyWorkflowAction<PatchfunnelLanesIdResponse> PatchfunnelLanesId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PatchfunnelLanesIdResponse> __BuildPatchfunnelLanesId(WorkflowExpression<string> id, WorkflowExpression<string> bodytitle = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            return new DeferredBodyAction<PatchfunnelLanesIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/funnel_lanes/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
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
        [WorkflowExpressionFactory(nameof(__BuildPostfunnels))]
        public IWorkflowAction Postfunnels([WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<int> bodyfunnelType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPostfunnels(WorkflowExpression<string> bodytitle = null, WorkflowExpression<int> bodyfunnelType = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodyfunnelType, nameof(bodyfunnelType), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/general/v1/funnels";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodyfunnelType != null)
                {
                    body["funnel_type"] = ExpressionConverter.ConvertO(bodyfunnelType);
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
        [WorkflowExpressionFactory(nameof(__BuildGetfunnelsId))]
        public IBodyWorkflowAction<GetfunnelsIdResponse> GetfunnelsId([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetfunnelsIdResponse> __BuildGetfunnelsId(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GetfunnelsIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/funnels/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetfunnelsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [WorkflowExpressionFactory(nameof(__BuildDeletefunnelsId))]
        public IWorkflowAction DeletefunnelsId([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeletefunnelsId(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/funnels/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [WorkflowExpressionFactory(nameof(__BuildPutfunnelsId))]
        public IWorkflowAction PutfunnelsId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<int> bodycompanyId = null, [WorkflowExpression] Func<int> bodyuserId = null, [WorkflowExpression] Func<int> bodyfunnelType = null, [WorkflowExpression] Func<int> bodymodifiedBy = null, [WorkflowExpression] Func<int> bodyprivacySetting = null, [WorkflowExpression] Func<int> bodyownerId = null, [WorkflowExpression] Func<bool> bodyblockFunnelNotification = null, [WorkflowExpression] Func<int> bodyideasCount = null, [WorkflowExpression] Func<int> bodyprojectsCount = null, [WorkflowExpression] Func<bool> bodyhidden = null, [WorkflowExpression] Func<string> bodysetXAxis = null, [WorkflowExpression] Func<string> bodysetYAxis = null, [WorkflowExpression] Func<string> bodysetZAxis = null, [WorkflowExpression] Func<string> bodysetAxisColor = null, [WorkflowExpression] Func<string> bodydepartmentId = null, [WorkflowExpression] Func<int> bodyprojectFunnelId = null, [WorkflowExpression] Func<string> bodyfromScript = null, [WorkflowExpression] Func<int> bodyuserPrivacySetting = null, [WorkflowExpression] Func<bool> bodyincludeInDashboard = null, [WorkflowExpression] Func<string> bodyrecordUrl = null, [WorkflowExpression] Func<string> bodysyncId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPutfunnelsId(WorkflowExpression<string> id, WorkflowExpression<string> bodytitle = null, WorkflowExpression<int> bodycompanyId = null, WorkflowExpression<int> bodyuserId = null, WorkflowExpression<int> bodyfunnelType = null, WorkflowExpression<int> bodymodifiedBy = null, WorkflowExpression<int> bodyprivacySetting = null, WorkflowExpression<int> bodyownerId = null, WorkflowExpression<bool> bodyblockFunnelNotification = null, WorkflowExpression<int> bodyideasCount = null, WorkflowExpression<int> bodyprojectsCount = null, WorkflowExpression<bool> bodyhidden = null, WorkflowExpression<string> bodysetXAxis = null, WorkflowExpression<string> bodysetYAxis = null, WorkflowExpression<string> bodysetZAxis = null, WorkflowExpression<string> bodysetAxisColor = null, WorkflowExpression<string> bodydepartmentId = null, WorkflowExpression<int> bodyprojectFunnelId = null, WorkflowExpression<string> bodyfromScript = null, WorkflowExpression<int> bodyuserPrivacySetting = null, WorkflowExpression<bool> bodyincludeInDashboard = null, WorkflowExpression<string> bodyrecordUrl = null, WorkflowExpression<string> bodysyncId = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodycompanyId, nameof(bodycompanyId), required: false);
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            WorkflowExpression.Validate(bodyfunnelType, nameof(bodyfunnelType), required: false);
            WorkflowExpression.Validate(bodymodifiedBy, nameof(bodymodifiedBy), required: false);
            WorkflowExpression.Validate(bodyprivacySetting, nameof(bodyprivacySetting), required: false);
            WorkflowExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            WorkflowExpression.Validate(bodyblockFunnelNotification, nameof(bodyblockFunnelNotification), required: false);
            WorkflowExpression.Validate(bodyideasCount, nameof(bodyideasCount), required: false);
            WorkflowExpression.Validate(bodyprojectsCount, nameof(bodyprojectsCount), required: false);
            WorkflowExpression.Validate(bodyhidden, nameof(bodyhidden), required: false);
            WorkflowExpression.Validate(bodysetXAxis, nameof(bodysetXAxis), required: false);
            WorkflowExpression.Validate(bodysetYAxis, nameof(bodysetYAxis), required: false);
            WorkflowExpression.Validate(bodysetZAxis, nameof(bodysetZAxis), required: false);
            WorkflowExpression.Validate(bodysetAxisColor, nameof(bodysetAxisColor), required: false);
            WorkflowExpression.Validate(bodydepartmentId, nameof(bodydepartmentId), required: false);
            WorkflowExpression.Validate(bodyprojectFunnelId, nameof(bodyprojectFunnelId), required: false);
            WorkflowExpression.Validate(bodyfromScript, nameof(bodyfromScript), required: false);
            WorkflowExpression.Validate(bodyuserPrivacySetting, nameof(bodyuserPrivacySetting), required: false);
            WorkflowExpression.Validate(bodyincludeInDashboard, nameof(bodyincludeInDashboard), required: false);
            WorkflowExpression.Validate(bodyrecordUrl, nameof(bodyrecordUrl), required: false);
            WorkflowExpression.Validate(bodysyncId, nameof(bodysyncId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/funnels/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodycompanyId != null)
                {
                    body["company_id"] = ExpressionConverter.ConvertO(bodycompanyId);
                    bodypropCount++;
                }

                if (bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(bodyuserId);
                    bodypropCount++;
                }

                if (bodyfunnelType != null)
                {
                    body["funnel_type"] = ExpressionConverter.ConvertO(bodyfunnelType);
                    bodypropCount++;
                }

                if (bodymodifiedBy != null)
                {
                    body["modified_by"] = ExpressionConverter.ConvertO(bodymodifiedBy);
                    bodypropCount++;
                }

                if (bodyprivacySetting != null)
                {
                    body["privacy_setting"] = ExpressionConverter.ConvertO(bodyprivacySetting);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["owner_id"] = ExpressionConverter.ConvertO(bodyownerId);
                    bodypropCount++;
                }

                if (bodyblockFunnelNotification != null)
                {
                    body["block_funnel_notification"] = ExpressionConverter.ConvertO(bodyblockFunnelNotification);
                    bodypropCount++;
                }

                if (bodyideasCount != null)
                {
                    body["ideas_count"] = ExpressionConverter.ConvertO(bodyideasCount);
                    bodypropCount++;
                }

                if (bodyprojectsCount != null)
                {
                    body["projects_count"] = ExpressionConverter.ConvertO(bodyprojectsCount);
                    bodypropCount++;
                }

                if (bodyhidden != null)
                {
                    body["hidden"] = ExpressionConverter.ConvertO(bodyhidden);
                    bodypropCount++;
                }

                if (bodysetXAxis != null)
                {
                    body["set_x_axis"] = ExpressionConverter.ConvertO(bodysetXAxis);
                    bodypropCount++;
                }

                if (bodysetYAxis != null)
                {
                    body["set_y_axis"] = ExpressionConverter.ConvertO(bodysetYAxis);
                    bodypropCount++;
                }

                if (bodysetZAxis != null)
                {
                    body["set_z_axis"] = ExpressionConverter.ConvertO(bodysetZAxis);
                    bodypropCount++;
                }

                if (bodysetAxisColor != null)
                {
                    body["set_axis_color"] = ExpressionConverter.ConvertO(bodysetAxisColor);
                    bodypropCount++;
                }

                if (bodydepartmentId != null)
                {
                    body["department_id"] = ExpressionConverter.ConvertO(bodydepartmentId);
                    bodypropCount++;
                }

                if (bodyprojectFunnelId != null)
                {
                    body["project_funnel_id"] = ExpressionConverter.ConvertO(bodyprojectFunnelId);
                    bodypropCount++;
                }

                if (bodyfromScript != null)
                {
                    body["from_script"] = ExpressionConverter.ConvertO(bodyfromScript);
                    bodypropCount++;
                }

                if (bodyuserPrivacySetting != null)
                {
                    body["user_privacy_setting"] = ExpressionConverter.ConvertO(bodyuserPrivacySetting);
                    bodypropCount++;
                }

                if (bodyincludeInDashboard != null)
                {
                    body["include_in_dashboard"] = ExpressionConverter.ConvertO(bodyincludeInDashboard);
                    bodypropCount++;
                }

                if (bodyrecordUrl != null)
                {
                    body["record_url"] = ExpressionConverter.ConvertO(bodyrecordUrl);
                    bodypropCount++;
                }

                if (bodysyncId != null)
                {
                    body["sync_id"] = ExpressionConverter.ConvertO(bodysyncId);
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
        [WorkflowExpressionFactory(nameof(__BuildPatchfunnelsId))]
        public IBodyWorkflowAction<PatchfunnelsIdResponse> PatchfunnelsId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<int> bodyfunnelType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PatchfunnelsIdResponse> __BuildPatchfunnelsId(WorkflowExpression<string> id, WorkflowExpression<string> bodytitle = null, WorkflowExpression<int> bodyfunnelType = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodyfunnelType, nameof(bodyfunnelType), required: false);
            return new DeferredBodyAction<PatchfunnelsIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/funnels/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodyfunnelType != null)
                {
                    body["funnel_type"] = ExpressionConverter.ConvertO(bodyfunnelType);
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
        [WorkflowExpressionFactory(nameof(__BuildPostideas))]
        public IWorkflowAction Postideas([WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodycontent = null, [WorkflowExpression] Func<int> bodyfunnelId = null, [WorkflowExpression] Func<int> bodymissionId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPostideas(WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodycontent = null, WorkflowExpression<int> bodyfunnelId = null, WorkflowExpression<int> bodymissionId = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodycontent, nameof(bodycontent), required: false);
            WorkflowExpression.Validate(bodyfunnelId, nameof(bodyfunnelId), required: false);
            WorkflowExpression.Validate(bodymissionId, nameof(bodymissionId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/general/v1/ideas";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(bodycontent);
                    bodypropCount++;
                }

                if (bodyfunnelId != null)
                {
                    body["funnel_id"] = ExpressionConverter.ConvertO(bodyfunnelId);
                    bodypropCount++;
                }

                if (bodymissionId != null)
                {
                    body["mission_id"] = ExpressionConverter.ConvertO(bodymissionId);
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
        [WorkflowExpressionFactory(nameof(__BuildGetideasIdeaIdTasks))]
        public IBodyWorkflowAction<GetideasIdeaIdTasksResponse> GetideasIdeaIdTasks([WorkflowExpression] Func<string> ideaId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetideasIdeaIdTasksResponse> __BuildGetideasIdeaIdTasks(WorkflowExpression<string> ideaId)
        {
            WorkflowExpression.Validate(ideaId, nameof(ideaId), required: true);
            return new DeferredBodyAction<GetideasIdeaIdTasksResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/ideas/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(ideaId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetideasIdeaIdTasksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [WorkflowExpressionFactory(nameof(__BuildPostideasIdeaIdTasks))]
        public IBodyWorkflowAction<PostideasIdeaIdTasksResponse> PostideasIdeaIdTasks([WorkflowExpression] Func<string> ideaId, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<int> bodystatus = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostideasIdeaIdTasksResponse> __BuildPostideasIdeaIdTasks(WorkflowExpression<string> ideaId, WorkflowExpression<string> bodytitle = null, WorkflowExpression<int> bodystatus = null)
        {
            WorkflowExpression.Validate(ideaId, nameof(ideaId), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<PostideasIdeaIdTasksResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/ideas/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(ideaId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
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
        [WorkflowExpressionFactory(nameof(__BuildGetideasId))]
        public IWorkflowAction GetideasId([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetideasId(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/ideas/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteideasId))]
        public IWorkflowAction DeleteideasId([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteideasId(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/ideas/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [WorkflowExpressionFactory(nameof(__BuildPutideasId))]
        public IWorkflowAction PutideasId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> bodyuserId = null, [WorkflowExpression] Func<int> bodyroundId = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodycontent = null, [WorkflowExpression] Func<string> bodyimage = null, [WorkflowExpression] Func<string> bodydevice = null, [WorkflowExpression] Func<string> bodybrowser = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodypostalCode = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodyscreenRes = null, [WorkflowExpression] Func<string> bodyuserIp = null, [WorkflowExpression] Func<int> bodycommentsCount = null, [WorkflowExpression] Func<int> bodyreviewScoresCount = null, [WorkflowExpression] Func<string> bodyslug = null, [WorkflowExpression] Func<int> bodystage = null, [WorkflowExpression] Func<string> bodydepartmentId = null, [WorkflowExpression] Func<string> bodystatusId = null, [WorkflowExpression] Func<string> bodyposition = null, [WorkflowExpression] Func<string> bodyprojectId = null, [WorkflowExpression] Func<string> bodyideaCreator = null, [WorkflowExpression] Func<string> bodyideationIdeaCategoryId = null, [WorkflowExpression] Func<string> bodyboardIdeaCategoryId = null, [WorkflowExpression] Func<int> bodycompanyId = null, [WorkflowExpression] Func<int> bodyideaLikesCount = null, [WorkflowExpression] Func<bool> bodybookmark = null, [WorkflowExpression] Func<int> bodyideaScoresCount = null, [WorkflowExpression] Func<int> bodylikesCount = null, [WorkflowExpression] Func<string> bodyboardId = null, [WorkflowExpression] Func<string> bodymissionId = null, [WorkflowExpression] Func<string> bodycreatorName = null, [WorkflowExpression] Func<int> bodytagsCount = null, [WorkflowExpression] Func<string> bodyfunnelId = null, [WorkflowExpression] Func<string> bodyfunnelStageId = null, [WorkflowExpression] Func<string> bodyfunnelStatusId = null, [WorkflowExpression] Func<string> bodyideaDeadline = null, [WorkflowExpression] Func<bool> bodydeadlineNotification = null, [WorkflowExpression] Func<int> bodyideaViews = null, [WorkflowExpression] Func<string> bodyrevenue = null, [WorkflowExpression] Func<string> bodycost = null, [WorkflowExpression] Func<string> bodyprofit = null, [WorkflowExpression] Func<string> bodystatusName = null, [WorkflowExpression] Func<string> bodyideaScores = null, [WorkflowExpression] Func<string> bodyapprovedAt = null, [WorkflowExpression] Func<string> bodydeniedAt = null, [WorkflowExpression] Func<string> bodyadminComments = null, [WorkflowExpression] Func<bool> bodyisChild = null, [WorkflowExpression] Func<string> bodyparentId = null, [WorkflowExpression] Func<string> bodytempImage = null, [WorkflowExpression] Func<string> bodymainImage = null, [WorkflowExpression] Func<string> bodyimageConfigs = null, [WorkflowExpression] Func<int> bodyscoreCompleteScore = null, [WorkflowExpression] Func<int> bodyenrichmentScore = null, [WorkflowExpression] Func<int> bodyengagementScore = null, [WorkflowExpression] Func<int> bodyopportunityScore = null, [WorkflowExpression] Func<int> bodytrendScore = null, [WorkflowExpression] Func<string> bodycleanedText = null, [WorkflowExpression] Func<int> bodyduplicateIdeasCount = null, [WorkflowExpression] Func<string> bodysidekiqDuplicateIdeasCount = null, [WorkflowExpression] Func<string> bodyaiCreated = null, [WorkflowExpression] Func<string> bodyideaType = null, [WorkflowExpression] Func<string> bodyfromScript = null, [WorkflowExpression] Func<string> bodyembedding = null, [WorkflowExpression] Func<string> bodyreasonText = null, [WorkflowExpression] Func<string> bodycategoryText = null, [WorkflowExpression] Func<string> bodycanvassId = null, [WorkflowExpression] Func<string> bodybudgetTotal = null, [WorkflowExpression] Func<string> bodybudgetSpend = null, [WorkflowExpression] Func<string> bodybudgetResult = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodytagText = null, [WorkflowExpression] Func<string> bodyinnovationTypeId = null, [WorkflowExpression] Func<string> bodyinnovationTypeText = null, [WorkflowExpression] Func<string> bodysyncId = null, [WorkflowExpression] Func<string> bodyrecordUrl = null, [WorkflowExpression] Func<string> bodydescriptionEnriched = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPutideasId(WorkflowExpression<string> id, WorkflowExpression<int> bodyuserId = null, WorkflowExpression<int> bodyroundId = null, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodycontent = null, WorkflowExpression<string> bodyimage = null, WorkflowExpression<string> bodydevice = null, WorkflowExpression<string> bodybrowser = null, WorkflowExpression<string> bodyaddress = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodystate = null, WorkflowExpression<string> bodypostalCode = null, WorkflowExpression<string> bodycountry = null, WorkflowExpression<string> bodyscreenRes = null, WorkflowExpression<string> bodyuserIp = null, WorkflowExpression<int> bodycommentsCount = null, WorkflowExpression<int> bodyreviewScoresCount = null, WorkflowExpression<string> bodyslug = null, WorkflowExpression<int> bodystage = null, WorkflowExpression<string> bodydepartmentId = null, WorkflowExpression<string> bodystatusId = null, WorkflowExpression<string> bodyposition = null, WorkflowExpression<string> bodyprojectId = null, WorkflowExpression<string> bodyideaCreator = null, WorkflowExpression<string> bodyideationIdeaCategoryId = null, WorkflowExpression<string> bodyboardIdeaCategoryId = null, WorkflowExpression<int> bodycompanyId = null, WorkflowExpression<int> bodyideaLikesCount = null, WorkflowExpression<bool> bodybookmark = null, WorkflowExpression<int> bodyideaScoresCount = null, WorkflowExpression<int> bodylikesCount = null, WorkflowExpression<string> bodyboardId = null, WorkflowExpression<string> bodymissionId = null, WorkflowExpression<string> bodycreatorName = null, WorkflowExpression<int> bodytagsCount = null, WorkflowExpression<string> bodyfunnelId = null, WorkflowExpression<string> bodyfunnelStageId = null, WorkflowExpression<string> bodyfunnelStatusId = null, WorkflowExpression<string> bodyideaDeadline = null, WorkflowExpression<bool> bodydeadlineNotification = null, WorkflowExpression<int> bodyideaViews = null, WorkflowExpression<string> bodyrevenue = null, WorkflowExpression<string> bodycost = null, WorkflowExpression<string> bodyprofit = null, WorkflowExpression<string> bodystatusName = null, WorkflowExpression<string> bodyideaScores = null, WorkflowExpression<string> bodyapprovedAt = null, WorkflowExpression<string> bodydeniedAt = null, WorkflowExpression<string> bodyadminComments = null, WorkflowExpression<bool> bodyisChild = null, WorkflowExpression<string> bodyparentId = null, WorkflowExpression<string> bodytempImage = null, WorkflowExpression<string> bodymainImage = null, WorkflowExpression<string> bodyimageConfigs = null, WorkflowExpression<int> bodyscoreCompleteScore = null, WorkflowExpression<int> bodyenrichmentScore = null, WorkflowExpression<int> bodyengagementScore = null, WorkflowExpression<int> bodyopportunityScore = null, WorkflowExpression<int> bodytrendScore = null, WorkflowExpression<string> bodycleanedText = null, WorkflowExpression<int> bodyduplicateIdeasCount = null, WorkflowExpression<string> bodysidekiqDuplicateIdeasCount = null, WorkflowExpression<string> bodyaiCreated = null, WorkflowExpression<string> bodyideaType = null, WorkflowExpression<string> bodyfromScript = null, WorkflowExpression<string> bodyembedding = null, WorkflowExpression<string> bodyreasonText = null, WorkflowExpression<string> bodycategoryText = null, WorkflowExpression<string> bodycanvassId = null, WorkflowExpression<string> bodybudgetTotal = null, WorkflowExpression<string> bodybudgetSpend = null, WorkflowExpression<string> bodybudgetResult = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodytagText = null, WorkflowExpression<string> bodyinnovationTypeId = null, WorkflowExpression<string> bodyinnovationTypeText = null, WorkflowExpression<string> bodysyncId = null, WorkflowExpression<string> bodyrecordUrl = null, WorkflowExpression<string> bodydescriptionEnriched = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            WorkflowExpression.Validate(bodyroundId, nameof(bodyroundId), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodycontent, nameof(bodycontent), required: false);
            WorkflowExpression.Validate(bodyimage, nameof(bodyimage), required: false);
            WorkflowExpression.Validate(bodydevice, nameof(bodydevice), required: false);
            WorkflowExpression.Validate(bodybrowser, nameof(bodybrowser), required: false);
            WorkflowExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowExpression.Validate(bodypostalCode, nameof(bodypostalCode), required: false);
            WorkflowExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            WorkflowExpression.Validate(bodyscreenRes, nameof(bodyscreenRes), required: false);
            WorkflowExpression.Validate(bodyuserIp, nameof(bodyuserIp), required: false);
            WorkflowExpression.Validate(bodycommentsCount, nameof(bodycommentsCount), required: false);
            WorkflowExpression.Validate(bodyreviewScoresCount, nameof(bodyreviewScoresCount), required: false);
            WorkflowExpression.Validate(bodyslug, nameof(bodyslug), required: false);
            WorkflowExpression.Validate(bodystage, nameof(bodystage), required: false);
            WorkflowExpression.Validate(bodydepartmentId, nameof(bodydepartmentId), required: false);
            WorkflowExpression.Validate(bodystatusId, nameof(bodystatusId), required: false);
            WorkflowExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            WorkflowExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: false);
            WorkflowExpression.Validate(bodyideaCreator, nameof(bodyideaCreator), required: false);
            WorkflowExpression.Validate(bodyideationIdeaCategoryId, nameof(bodyideationIdeaCategoryId), required: false);
            WorkflowExpression.Validate(bodyboardIdeaCategoryId, nameof(bodyboardIdeaCategoryId), required: false);
            WorkflowExpression.Validate(bodycompanyId, nameof(bodycompanyId), required: false);
            WorkflowExpression.Validate(bodyideaLikesCount, nameof(bodyideaLikesCount), required: false);
            WorkflowExpression.Validate(bodybookmark, nameof(bodybookmark), required: false);
            WorkflowExpression.Validate(bodyideaScoresCount, nameof(bodyideaScoresCount), required: false);
            WorkflowExpression.Validate(bodylikesCount, nameof(bodylikesCount), required: false);
            WorkflowExpression.Validate(bodyboardId, nameof(bodyboardId), required: false);
            WorkflowExpression.Validate(bodymissionId, nameof(bodymissionId), required: false);
            WorkflowExpression.Validate(bodycreatorName, nameof(bodycreatorName), required: false);
            WorkflowExpression.Validate(bodytagsCount, nameof(bodytagsCount), required: false);
            WorkflowExpression.Validate(bodyfunnelId, nameof(bodyfunnelId), required: false);
            WorkflowExpression.Validate(bodyfunnelStageId, nameof(bodyfunnelStageId), required: false);
            WorkflowExpression.Validate(bodyfunnelStatusId, nameof(bodyfunnelStatusId), required: false);
            WorkflowExpression.Validate(bodyideaDeadline, nameof(bodyideaDeadline), required: false);
            WorkflowExpression.Validate(bodydeadlineNotification, nameof(bodydeadlineNotification), required: false);
            WorkflowExpression.Validate(bodyideaViews, nameof(bodyideaViews), required: false);
            WorkflowExpression.Validate(bodyrevenue, nameof(bodyrevenue), required: false);
            WorkflowExpression.Validate(bodycost, nameof(bodycost), required: false);
            WorkflowExpression.Validate(bodyprofit, nameof(bodyprofit), required: false);
            WorkflowExpression.Validate(bodystatusName, nameof(bodystatusName), required: false);
            WorkflowExpression.Validate(bodyideaScores, nameof(bodyideaScores), required: false);
            WorkflowExpression.Validate(bodyapprovedAt, nameof(bodyapprovedAt), required: false);
            WorkflowExpression.Validate(bodydeniedAt, nameof(bodydeniedAt), required: false);
            WorkflowExpression.Validate(bodyadminComments, nameof(bodyadminComments), required: false);
            WorkflowExpression.Validate(bodyisChild, nameof(bodyisChild), required: false);
            WorkflowExpression.Validate(bodyparentId, nameof(bodyparentId), required: false);
            WorkflowExpression.Validate(bodytempImage, nameof(bodytempImage), required: false);
            WorkflowExpression.Validate(bodymainImage, nameof(bodymainImage), required: false);
            WorkflowExpression.Validate(bodyimageConfigs, nameof(bodyimageConfigs), required: false);
            WorkflowExpression.Validate(bodyscoreCompleteScore, nameof(bodyscoreCompleteScore), required: false);
            WorkflowExpression.Validate(bodyenrichmentScore, nameof(bodyenrichmentScore), required: false);
            WorkflowExpression.Validate(bodyengagementScore, nameof(bodyengagementScore), required: false);
            WorkflowExpression.Validate(bodyopportunityScore, nameof(bodyopportunityScore), required: false);
            WorkflowExpression.Validate(bodytrendScore, nameof(bodytrendScore), required: false);
            WorkflowExpression.Validate(bodycleanedText, nameof(bodycleanedText), required: false);
            WorkflowExpression.Validate(bodyduplicateIdeasCount, nameof(bodyduplicateIdeasCount), required: false);
            WorkflowExpression.Validate(bodysidekiqDuplicateIdeasCount, nameof(bodysidekiqDuplicateIdeasCount), required: false);
            WorkflowExpression.Validate(bodyaiCreated, nameof(bodyaiCreated), required: false);
            WorkflowExpression.Validate(bodyideaType, nameof(bodyideaType), required: false);
            WorkflowExpression.Validate(bodyfromScript, nameof(bodyfromScript), required: false);
            WorkflowExpression.Validate(bodyembedding, nameof(bodyembedding), required: false);
            WorkflowExpression.Validate(bodyreasonText, nameof(bodyreasonText), required: false);
            WorkflowExpression.Validate(bodycategoryText, nameof(bodycategoryText), required: false);
            WorkflowExpression.Validate(bodycanvassId, nameof(bodycanvassId), required: false);
            WorkflowExpression.Validate(bodybudgetTotal, nameof(bodybudgetTotal), required: false);
            WorkflowExpression.Validate(bodybudgetSpend, nameof(bodybudgetSpend), required: false);
            WorkflowExpression.Validate(bodybudgetResult, nameof(bodybudgetResult), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodytagText, nameof(bodytagText), required: false);
            WorkflowExpression.Validate(bodyinnovationTypeId, nameof(bodyinnovationTypeId), required: false);
            WorkflowExpression.Validate(bodyinnovationTypeText, nameof(bodyinnovationTypeText), required: false);
            WorkflowExpression.Validate(bodysyncId, nameof(bodysyncId), required: false);
            WorkflowExpression.Validate(bodyrecordUrl, nameof(bodyrecordUrl), required: false);
            WorkflowExpression.Validate(bodydescriptionEnriched, nameof(bodydescriptionEnriched), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/ideas/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(bodyuserId);
                    bodypropCount++;
                }

                if (bodyroundId != null)
                {
                    body["round_id"] = ExpressionConverter.ConvertO(bodyroundId);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(bodycontent);
                    bodypropCount++;
                }

                if (bodyimage != null)
                {
                    body["image"] = ExpressionConverter.ConvertO(bodyimage);
                    bodypropCount++;
                }

                if (bodydevice != null)
                {
                    body["device"] = ExpressionConverter.ConvertO(bodydevice);
                    bodypropCount++;
                }

                if (bodybrowser != null)
                {
                    body["browser"] = ExpressionConverter.ConvertO(bodybrowser);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address"] = ExpressionConverter.ConvertO(bodyaddress);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(bodystate);
                    bodypropCount++;
                }

                if (bodypostalCode != null)
                {
                    body["postal_code"] = ExpressionConverter.ConvertO(bodypostalCode);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(bodycountry);
                    bodypropCount++;
                }

                if (bodyscreenRes != null)
                {
                    body["screen_res"] = ExpressionConverter.ConvertO(bodyscreenRes);
                    bodypropCount++;
                }

                if (bodyuserIp != null)
                {
                    body["user_ip"] = ExpressionConverter.ConvertO(bodyuserIp);
                    bodypropCount++;
                }

                if (bodycommentsCount != null)
                {
                    body["comments_count"] = ExpressionConverter.ConvertO(bodycommentsCount);
                    bodypropCount++;
                }

                if (bodyreviewScoresCount != null)
                {
                    body["review_scores_count"] = ExpressionConverter.ConvertO(bodyreviewScoresCount);
                    bodypropCount++;
                }

                if (bodyslug != null)
                {
                    body["slug"] = ExpressionConverter.ConvertO(bodyslug);
                    bodypropCount++;
                }

                if (bodystage != null)
                {
                    body["stage"] = ExpressionConverter.ConvertO(bodystage);
                    bodypropCount++;
                }

                if (bodydepartmentId != null)
                {
                    body["department_id"] = ExpressionConverter.ConvertO(bodydepartmentId);
                    bodypropCount++;
                }

                if (bodystatusId != null)
                {
                    body["status_id"] = ExpressionConverter.ConvertO(bodystatusId);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(bodyposition);
                    bodypropCount++;
                }

                if (bodyprojectId != null)
                {
                    body["project_id"] = ExpressionConverter.ConvertO(bodyprojectId);
                    bodypropCount++;
                }

                if (bodyideaCreator != null)
                {
                    body["idea_creator"] = ExpressionConverter.ConvertO(bodyideaCreator);
                    bodypropCount++;
                }

                if (bodyideationIdeaCategoryId != null)
                {
                    body["ideation_idea_category_id"] = ExpressionConverter.ConvertO(bodyideationIdeaCategoryId);
                    bodypropCount++;
                }

                if (bodyboardIdeaCategoryId != null)
                {
                    body["board_idea_category_id"] = ExpressionConverter.ConvertO(bodyboardIdeaCategoryId);
                    bodypropCount++;
                }

                if (bodycompanyId != null)
                {
                    body["company_id"] = ExpressionConverter.ConvertO(bodycompanyId);
                    bodypropCount++;
                }

                if (bodyideaLikesCount != null)
                {
                    body["idea_likes_count"] = ExpressionConverter.ConvertO(bodyideaLikesCount);
                    bodypropCount++;
                }

                if (bodybookmark != null)
                {
                    body["bookmark"] = ExpressionConverter.ConvertO(bodybookmark);
                    bodypropCount++;
                }

                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                if (bodyideaScoresCount != null)
                {
                    body["idea_scores_count"] = ExpressionConverter.ConvertO(bodyideaScoresCount);
                    bodypropCount++;
                }

                if (bodylikesCount != null)
                {
                    body["likes_count"] = ExpressionConverter.ConvertO(bodylikesCount);
                    bodypropCount++;
                }

                if (bodyboardId != null)
                {
                    body["board_id"] = ExpressionConverter.ConvertO(bodyboardId);
                    bodypropCount++;
                }

                if (bodymissionId != null)
                {
                    body["mission_id"] = ExpressionConverter.ConvertO(bodymissionId);
                    bodypropCount++;
                }

                if (bodycreatorName != null)
                {
                    body["creator_name"] = ExpressionConverter.ConvertO(bodycreatorName);
                    bodypropCount++;
                }

                if (bodytagsCount != null)
                {
                    body["tags_count"] = ExpressionConverter.ConvertO(bodytagsCount);
                    bodypropCount++;
                }

                if (bodyfunnelId != null)
                {
                    body["funnel_id"] = ExpressionConverter.ConvertO(bodyfunnelId);
                    bodypropCount++;
                }

                if (bodyfunnelStageId != null)
                {
                    body["funnel_stage_id"] = ExpressionConverter.ConvertO(bodyfunnelStageId);
                    bodypropCount++;
                }

                if (bodyfunnelStatusId != null)
                {
                    body["funnel_status_id"] = ExpressionConverter.ConvertO(bodyfunnelStatusId);
                    bodypropCount++;
                }

                if (bodyideaDeadline != null)
                {
                    body["idea_deadline"] = ExpressionConverter.ConvertO(bodyideaDeadline);
                    bodypropCount++;
                }

                if (bodydeadlineNotification != null)
                {
                    body["deadline_notification"] = ExpressionConverter.ConvertO(bodydeadlineNotification);
                    bodypropCount++;
                }

                if (bodyideaViews != null)
                {
                    body["idea_views"] = ExpressionConverter.ConvertO(bodyideaViews);
                    bodypropCount++;
                }

                if (bodyrevenue != null)
                {
                    body["revenue"] = ExpressionConverter.ConvertO(bodyrevenue);
                    bodypropCount++;
                }

                if (bodycost != null)
                {
                    body["cost"] = ExpressionConverter.ConvertO(bodycost);
                    bodypropCount++;
                }

                if (bodyprofit != null)
                {
                    body["profit"] = ExpressionConverter.ConvertO(bodyprofit);
                    bodypropCount++;
                }

                if (bodystatusName != null)
                {
                    body["status_name"] = ExpressionConverter.ConvertO(bodystatusName);
                    bodypropCount++;
                }

                if (bodyideaScores != null)
                {
                    body["idea_scores"] = ExpressionConverter.ConvertO(bodyideaScores);
                    bodypropCount++;
                }

                if (bodyapprovedAt != null)
                {
                    body["approved_at"] = ExpressionConverter.ConvertO(bodyapprovedAt);
                    bodypropCount++;
                }

                if (bodydeniedAt != null)
                {
                    body["denied_at"] = ExpressionConverter.ConvertO(bodydeniedAt);
                    bodypropCount++;
                }

                if (bodyadminComments != null)
                {
                    body["admin_comments"] = ExpressionConverter.ConvertO(bodyadminComments);
                    bodypropCount++;
                }

                if (bodyisChild != null)
                {
                    body["is_child"] = ExpressionConverter.ConvertO(bodyisChild);
                    bodypropCount++;
                }

                if (bodyparentId != null)
                {
                    body["parent_id"] = ExpressionConverter.ConvertO(bodyparentId);
                    bodypropCount++;
                }

                if (bodytempImage != null)
                {
                    body["temp_image"] = ExpressionConverter.ConvertO(bodytempImage);
                    bodypropCount++;
                }

                if (bodymainImage != null)
                {
                    body["main_image"] = ExpressionConverter.ConvertO(bodymainImage);
                    bodypropCount++;
                }

                if (bodyimageConfigs != null)
                {
                    body["image_configs"] = ExpressionConverter.ConvertO(bodyimageConfigs);
                    bodypropCount++;
                }

                if (bodyscoreCompleteScore != null)
                {
                    body["score_complete_score"] = ExpressionConverter.ConvertO(bodyscoreCompleteScore);
                    bodypropCount++;
                }

                if (bodyenrichmentScore != null)
                {
                    body["enrichment_score"] = ExpressionConverter.ConvertO(bodyenrichmentScore);
                    bodypropCount++;
                }

                if (bodyengagementScore != null)
                {
                    body["engagement_score"] = ExpressionConverter.ConvertO(bodyengagementScore);
                    bodypropCount++;
                }

                if (bodyopportunityScore != null)
                {
                    body["opportunity_score"] = ExpressionConverter.ConvertO(bodyopportunityScore);
                    bodypropCount++;
                }

                if (bodytrendScore != null)
                {
                    body["trend_score"] = ExpressionConverter.ConvertO(bodytrendScore);
                    bodypropCount++;
                }

                if (bodycleanedText != null)
                {
                    body["cleaned_text"] = ExpressionConverter.ConvertO(bodycleanedText);
                    bodypropCount++;
                }

                if (bodyduplicateIdeasCount != null)
                {
                    body["duplicate_ideas_count"] = ExpressionConverter.ConvertO(bodyduplicateIdeasCount);
                    bodypropCount++;
                }

                if (bodysidekiqDuplicateIdeasCount != null)
                {
                    body["sidekiq_duplicate_ideas_count"] = ExpressionConverter.ConvertO(bodysidekiqDuplicateIdeasCount);
                    bodypropCount++;
                }

                if (bodyaiCreated != null)
                {
                    body["ai_created"] = ExpressionConverter.ConvertO(bodyaiCreated);
                    bodypropCount++;
                }

                if (bodyideaType != null)
                {
                    body["idea_type"] = ExpressionConverter.ConvertO(bodyideaType);
                    bodypropCount++;
                }

                if (bodyfromScript != null)
                {
                    body["from_script"] = ExpressionConverter.ConvertO(bodyfromScript);
                    bodypropCount++;
                }

                if (bodyembedding != null)
                {
                    body["embedding"] = ExpressionConverter.ConvertO(bodyembedding);
                    bodypropCount++;
                }

                if (bodyreasonText != null)
                {
                    body["reason_text"] = ExpressionConverter.ConvertO(bodyreasonText);
                    bodypropCount++;
                }

                if (bodycategoryText != null)
                {
                    body["category_text"] = ExpressionConverter.ConvertO(bodycategoryText);
                    bodypropCount++;
                }

                if (bodycanvassId != null)
                {
                    body["canvass_id"] = ExpressionConverter.ConvertO(bodycanvassId);
                    bodypropCount++;
                }

                if (bodybudgetTotal != null)
                {
                    body["budget_total"] = ExpressionConverter.ConvertO(bodybudgetTotal);
                    bodypropCount++;
                }

                if (bodybudgetSpend != null)
                {
                    body["budget_spend"] = ExpressionConverter.ConvertO(bodybudgetSpend);
                    bodypropCount++;
                }

                if (bodybudgetResult != null)
                {
                    body["budget_result"] = ExpressionConverter.ConvertO(bodybudgetResult);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodytagText != null)
                {
                    body["tag_text"] = ExpressionConverter.ConvertO(bodytagText);
                    bodypropCount++;
                }

                if (bodyinnovationTypeId != null)
                {
                    body["innovation_type_id"] = ExpressionConverter.ConvertO(bodyinnovationTypeId);
                    bodypropCount++;
                }

                if (bodyinnovationTypeText != null)
                {
                    body["innovation_type_text"] = ExpressionConverter.ConvertO(bodyinnovationTypeText);
                    bodypropCount++;
                }

                if (bodysyncId != null)
                {
                    body["sync_id"] = ExpressionConverter.ConvertO(bodysyncId);
                    bodypropCount++;
                }

                if (bodyrecordUrl != null)
                {
                    body["record_url"] = ExpressionConverter.ConvertO(bodyrecordUrl);
                    bodypropCount++;
                }

                if (bodydescriptionEnriched != null)
                {
                    body["description_enriched"] = ExpressionConverter.ConvertO(bodydescriptionEnriched);
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
        [WorkflowExpressionFactory(nameof(__BuildPatchideasId))]
        public IWorkflowAction PatchideasId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodycontent = null, [WorkflowExpression] Func<int> bodyfunnelId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPatchideasId(WorkflowExpression<string> id, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodycontent = null, WorkflowExpression<int> bodyfunnelId = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodycontent, nameof(bodycontent), required: false);
            WorkflowExpression.Validate(bodyfunnelId, nameof(bodyfunnelId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/ideas/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(bodycontent);
                    bodypropCount++;
                }

                if (bodyfunnelId != null)
                {
                    body["funnel_id"] = ExpressionConverter.ConvertO(bodyfunnelId);
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
        [WorkflowExpressionFactory(nameof(__BuildPostmissions))]
        public IWorkflowAction Postmissions([WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<bool> bodyhidden = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPostmissions(WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodyendDate = null, WorkflowExpression<bool> bodyhidden = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowExpression.Validate(bodyhidden, nameof(bodyhidden), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/general/v1/missions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
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

                if (bodyhidden != null)
                {
                    body["hidden"] = ExpressionConverter.ConvertO(bodyhidden);
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
        [WorkflowExpressionFactory(nameof(__BuildGetmissionsId))]
        public IBodyWorkflowAction<GetmissionsIdResponse> GetmissionsId([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetmissionsIdResponse> __BuildGetmissionsId(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GetmissionsIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/missions/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetmissionsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [WorkflowExpressionFactory(nameof(__BuildDeletemissionsId))]
        public IWorkflowAction DeletemissionsId([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeletemissionsId(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/missions/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [WorkflowExpressionFactory(nameof(__BuildPutmissionsId))]
        public IBodyWorkflowAction<PutmissionsIdResponse> PutmissionsId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> bodyuserId = null, [WorkflowExpression] Func<int> bodycompanyId = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bool> bodyisAnonymous = null, [WorkflowExpression] Func<string> bodyendingNote = null, [WorkflowExpression] Func<string> bodymissionPic = null, [WorkflowExpression] Func<int> bodyteamSize = null, [WorkflowExpression] Func<int> bodystatus = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyslug = null, [WorkflowExpression] Func<string> bodyfromName = null, [WorkflowExpression] Func<bool> bodyisTemplate = null, [WorkflowExpression] Func<int> bodyendDuration = null, [WorkflowExpression] Func<string> bodytoken = null, [WorkflowExpression] Func<bool> bodyisTryout = null, [WorkflowExpression] Func<int> bodytemplateType = null, [WorkflowExpression] Func<bool> bodyisOpen = null, [WorkflowExpression] Func<int> bodymissionType = null, [WorkflowExpression] Func<string> bodypublishedOnce = null, [WorkflowExpression] Func<string> bodyinboxQuestion = null, [WorkflowExpression] Func<string> bodyprivacySetting = null, [WorkflowExpression] Func<string> bodyagentProfile = null, [WorkflowExpression] Func<string> bodydepartmentId = null, [WorkflowExpression] Func<bool> bodyenableReport = null, [WorkflowExpression] Func<int> bodyideasCount = null, [WorkflowExpression] Func<int> bodylikesCount = null, [WorkflowExpression] Func<int> bodycommentsCount = null, [WorkflowExpression] Func<string> bodyfunnelId = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<bool> bodyenableInboundEmail = null, [WorkflowExpression] Func<string> bodydepartmentName = null, [WorkflowExpression] Func<string> bodynotificationType = null, [WorkflowExpression] Func<string> bodynotificationFrequency = null, [WorkflowExpression] Func<string> bodynotificationText = null, [WorkflowExpression] Func<int> bodyposition = null, [WorkflowExpression] Func<string> bodymissionViews = null, [WorkflowExpression] Func<string> bodytempImage = null, [WorkflowExpression] Func<string> bodymainImage = null, [WorkflowExpression] Func<string> bodyimageConfigs = null, [WorkflowExpression] Func<string> bodyallowAiIdeas = null, [WorkflowExpression] Func<string> bodyaiMissionType = null, [WorkflowExpression] Func<string> bodyfromScript = null, [WorkflowExpression] Func<string> bodyideaAttachmentsAllowed = null, [WorkflowExpression] Func<string> bodyvideoLink = null, [WorkflowExpression] Func<string> bodyhidden = null, [WorkflowExpression] Func<string> bodyconfettiType = null, [WorkflowExpression] Func<string> bodyenable = null, [WorkflowExpression] Func<string> bodyaddAttachment = null, [WorkflowExpression] Func<string> bodyaddComment = null, [WorkflowExpression] Func<string> bodyrecordUrl = null, [WorkflowExpression] Func<string> bodysyncId = null, [WorkflowExpression] Func<string> bodyideaCustomFields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PutmissionsIdResponse> __BuildPutmissionsId(WorkflowExpression<string> id, WorkflowExpression<int> bodyuserId = null, WorkflowExpression<int> bodycompanyId = null, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<bool> bodyisAnonymous = null, WorkflowExpression<string> bodyendingNote = null, WorkflowExpression<string> bodymissionPic = null, WorkflowExpression<int> bodyteamSize = null, WorkflowExpression<int> bodystatus = null, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodyendDate = null, WorkflowExpression<string> bodyslug = null, WorkflowExpression<string> bodyfromName = null, WorkflowExpression<bool> bodyisTemplate = null, WorkflowExpression<int> bodyendDuration = null, WorkflowExpression<string> bodytoken = null, WorkflowExpression<bool> bodyisTryout = null, WorkflowExpression<int> bodytemplateType = null, WorkflowExpression<bool> bodyisOpen = null, WorkflowExpression<int> bodymissionType = null, WorkflowExpression<string> bodypublishedOnce = null, WorkflowExpression<string> bodyinboxQuestion = null, WorkflowExpression<string> bodyprivacySetting = null, WorkflowExpression<string> bodyagentProfile = null, WorkflowExpression<string> bodydepartmentId = null, WorkflowExpression<bool> bodyenableReport = null, WorkflowExpression<int> bodyideasCount = null, WorkflowExpression<int> bodylikesCount = null, WorkflowExpression<int> bodycommentsCount = null, WorkflowExpression<string> bodyfunnelId = null, WorkflowExpression<string> bodyemail = null, WorkflowExpression<bool> bodyenableInboundEmail = null, WorkflowExpression<string> bodydepartmentName = null, WorkflowExpression<string> bodynotificationType = null, WorkflowExpression<string> bodynotificationFrequency = null, WorkflowExpression<string> bodynotificationText = null, WorkflowExpression<int> bodyposition = null, WorkflowExpression<string> bodymissionViews = null, WorkflowExpression<string> bodytempImage = null, WorkflowExpression<string> bodymainImage = null, WorkflowExpression<string> bodyimageConfigs = null, WorkflowExpression<string> bodyallowAiIdeas = null, WorkflowExpression<string> bodyaiMissionType = null, WorkflowExpression<string> bodyfromScript = null, WorkflowExpression<string> bodyideaAttachmentsAllowed = null, WorkflowExpression<string> bodyvideoLink = null, WorkflowExpression<string> bodyhidden = null, WorkflowExpression<string> bodyconfettiType = null, WorkflowExpression<string> bodyenable = null, WorkflowExpression<string> bodyaddAttachment = null, WorkflowExpression<string> bodyaddComment = null, WorkflowExpression<string> bodyrecordUrl = null, WorkflowExpression<string> bodysyncId = null, WorkflowExpression<string> bodyideaCustomFields = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            WorkflowExpression.Validate(bodycompanyId, nameof(bodycompanyId), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyisAnonymous, nameof(bodyisAnonymous), required: false);
            WorkflowExpression.Validate(bodyendingNote, nameof(bodyendingNote), required: false);
            WorkflowExpression.Validate(bodymissionPic, nameof(bodymissionPic), required: false);
            WorkflowExpression.Validate(bodyteamSize, nameof(bodyteamSize), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowExpression.Validate(bodyslug, nameof(bodyslug), required: false);
            WorkflowExpression.Validate(bodyfromName, nameof(bodyfromName), required: false);
            WorkflowExpression.Validate(bodyisTemplate, nameof(bodyisTemplate), required: false);
            WorkflowExpression.Validate(bodyendDuration, nameof(bodyendDuration), required: false);
            WorkflowExpression.Validate(bodytoken, nameof(bodytoken), required: false);
            WorkflowExpression.Validate(bodyisTryout, nameof(bodyisTryout), required: false);
            WorkflowExpression.Validate(bodytemplateType, nameof(bodytemplateType), required: false);
            WorkflowExpression.Validate(bodyisOpen, nameof(bodyisOpen), required: false);
            WorkflowExpression.Validate(bodymissionType, nameof(bodymissionType), required: false);
            WorkflowExpression.Validate(bodypublishedOnce, nameof(bodypublishedOnce), required: false);
            WorkflowExpression.Validate(bodyinboxQuestion, nameof(bodyinboxQuestion), required: false);
            WorkflowExpression.Validate(bodyprivacySetting, nameof(bodyprivacySetting), required: false);
            WorkflowExpression.Validate(bodyagentProfile, nameof(bodyagentProfile), required: false);
            WorkflowExpression.Validate(bodydepartmentId, nameof(bodydepartmentId), required: false);
            WorkflowExpression.Validate(bodyenableReport, nameof(bodyenableReport), required: false);
            WorkflowExpression.Validate(bodyideasCount, nameof(bodyideasCount), required: false);
            WorkflowExpression.Validate(bodylikesCount, nameof(bodylikesCount), required: false);
            WorkflowExpression.Validate(bodycommentsCount, nameof(bodycommentsCount), required: false);
            WorkflowExpression.Validate(bodyfunnelId, nameof(bodyfunnelId), required: false);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodyenableInboundEmail, nameof(bodyenableInboundEmail), required: false);
            WorkflowExpression.Validate(bodydepartmentName, nameof(bodydepartmentName), required: false);
            WorkflowExpression.Validate(bodynotificationType, nameof(bodynotificationType), required: false);
            WorkflowExpression.Validate(bodynotificationFrequency, nameof(bodynotificationFrequency), required: false);
            WorkflowExpression.Validate(bodynotificationText, nameof(bodynotificationText), required: false);
            WorkflowExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            WorkflowExpression.Validate(bodymissionViews, nameof(bodymissionViews), required: false);
            WorkflowExpression.Validate(bodytempImage, nameof(bodytempImage), required: false);
            WorkflowExpression.Validate(bodymainImage, nameof(bodymainImage), required: false);
            WorkflowExpression.Validate(bodyimageConfigs, nameof(bodyimageConfigs), required: false);
            WorkflowExpression.Validate(bodyallowAiIdeas, nameof(bodyallowAiIdeas), required: false);
            WorkflowExpression.Validate(bodyaiMissionType, nameof(bodyaiMissionType), required: false);
            WorkflowExpression.Validate(bodyfromScript, nameof(bodyfromScript), required: false);
            WorkflowExpression.Validate(bodyideaAttachmentsAllowed, nameof(bodyideaAttachmentsAllowed), required: false);
            WorkflowExpression.Validate(bodyvideoLink, nameof(bodyvideoLink), required: false);
            WorkflowExpression.Validate(bodyhidden, nameof(bodyhidden), required: false);
            WorkflowExpression.Validate(bodyconfettiType, nameof(bodyconfettiType), required: false);
            WorkflowExpression.Validate(bodyenable, nameof(bodyenable), required: false);
            WorkflowExpression.Validate(bodyaddAttachment, nameof(bodyaddAttachment), required: false);
            WorkflowExpression.Validate(bodyaddComment, nameof(bodyaddComment), required: false);
            WorkflowExpression.Validate(bodyrecordUrl, nameof(bodyrecordUrl), required: false);
            WorkflowExpression.Validate(bodysyncId, nameof(bodysyncId), required: false);
            WorkflowExpression.Validate(bodyideaCustomFields, nameof(bodyideaCustomFields), required: false);
            return new DeferredBodyAction<PutmissionsIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/missions/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(bodyuserId);
                    bodypropCount++;
                }

                if (bodycompanyId != null)
                {
                    body["company_id"] = ExpressionConverter.ConvertO(bodycompanyId);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyisAnonymous != null)
                {
                    body["is_anonymous"] = ExpressionConverter.ConvertO(bodyisAnonymous);
                    bodypropCount++;
                }

                if (bodyendingNote != null)
                {
                    body["ending_note"] = ExpressionConverter.ConvertO(bodyendingNote);
                    bodypropCount++;
                }

                if (bodymissionPic != null)
                {
                    body["mission_pic"] = ExpressionConverter.ConvertO(bodymissionPic);
                    bodypropCount++;
                }

                if (bodyteamSize != null)
                {
                    body["team_size"] = ExpressionConverter.ConvertO(bodyteamSize);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
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

                if (bodyslug != null)
                {
                    body["slug"] = ExpressionConverter.ConvertO(bodyslug);
                    bodypropCount++;
                }

                if (bodyfromName != null)
                {
                    body["from_name"] = ExpressionConverter.ConvertO(bodyfromName);
                    bodypropCount++;
                }

                if (bodyisTemplate != null)
                {
                    body["is_template"] = ExpressionConverter.ConvertO(bodyisTemplate);
                    bodypropCount++;
                }

                if (bodyendDuration != null)
                {
                    body["end_duration"] = ExpressionConverter.ConvertO(bodyendDuration);
                    bodypropCount++;
                }

                if (bodytoken != null)
                {
                    body["token"] = ExpressionConverter.ConvertO(bodytoken);
                    bodypropCount++;
                }

                if (bodyisTryout != null)
                {
                    body["is_tryout"] = ExpressionConverter.ConvertO(bodyisTryout);
                    bodypropCount++;
                }

                if (bodytemplateType != null)
                {
                    body["template_type"] = ExpressionConverter.ConvertO(bodytemplateType);
                    bodypropCount++;
                }

                if (bodyisOpen != null)
                {
                    body["is_open"] = ExpressionConverter.ConvertO(bodyisOpen);
                    bodypropCount++;
                }

                if (bodymissionType != null)
                {
                    body["mission_type"] = ExpressionConverter.ConvertO(bodymissionType);
                    bodypropCount++;
                }

                if (bodypublishedOnce != null)
                {
                    body["published_once"] = ExpressionConverter.ConvertO(bodypublishedOnce);
                    bodypropCount++;
                }

                if (bodyinboxQuestion != null)
                {
                    body["inbox_question"] = ExpressionConverter.ConvertO(bodyinboxQuestion);
                    bodypropCount++;
                }

                if (bodyprivacySetting != null)
                {
                    body["privacy_setting"] = ExpressionConverter.ConvertO(bodyprivacySetting);
                    bodypropCount++;
                }

                if (bodyagentProfile != null)
                {
                    body["agent_profile"] = ExpressionConverter.ConvertO(bodyagentProfile);
                    bodypropCount++;
                }

                if (bodydepartmentId != null)
                {
                    body["department_id"] = ExpressionConverter.ConvertO(bodydepartmentId);
                    bodypropCount++;
                }

                if (bodyenableReport != null)
                {
                    body["enable_report"] = ExpressionConverter.ConvertO(bodyenableReport);
                    bodypropCount++;
                }

                if (bodyideasCount != null)
                {
                    body["ideas_count"] = ExpressionConverter.ConvertO(bodyideasCount);
                    bodypropCount++;
                }

                if (bodylikesCount != null)
                {
                    body["likes_count"] = ExpressionConverter.ConvertO(bodylikesCount);
                    bodypropCount++;
                }

                if (bodycommentsCount != null)
                {
                    body["comments_count"] = ExpressionConverter.ConvertO(bodycommentsCount);
                    bodypropCount++;
                }

                if (bodyfunnelId != null)
                {
                    body["funnel_id"] = ExpressionConverter.ConvertO(bodyfunnelId);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodyenableInboundEmail != null)
                {
                    body["enable_inbound_email"] = ExpressionConverter.ConvertO(bodyenableInboundEmail);
                    bodypropCount++;
                }

                var customFieldsObject = new JObject();
                var customFieldsObjectpropCount = 0;
                if (customFieldsObjectpropCount > 0)
                {
                    body["custom_fields"] = customFieldsObject;
                    bodypropCount++;
                }

                if (bodydepartmentName != null)
                {
                    body["department_name"] = ExpressionConverter.ConvertO(bodydepartmentName);
                    bodypropCount++;
                }

                if (bodynotificationType != null)
                {
                    body["notification_type"] = ExpressionConverter.ConvertO(bodynotificationType);
                    bodypropCount++;
                }

                if (bodynotificationFrequency != null)
                {
                    body["notification_frequency"] = ExpressionConverter.ConvertO(bodynotificationFrequency);
                    bodypropCount++;
                }

                if (bodynotificationText != null)
                {
                    body["notification_text"] = ExpressionConverter.ConvertO(bodynotificationText);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(bodyposition);
                    bodypropCount++;
                }

                if (bodymissionViews != null)
                {
                    body["mission_views"] = ExpressionConverter.ConvertO(bodymissionViews);
                    bodypropCount++;
                }

                if (bodytempImage != null)
                {
                    body["temp_image"] = ExpressionConverter.ConvertO(bodytempImage);
                    bodypropCount++;
                }

                if (bodymainImage != null)
                {
                    body["main_image"] = ExpressionConverter.ConvertO(bodymainImage);
                    bodypropCount++;
                }

                if (bodyimageConfigs != null)
                {
                    body["image_configs"] = ExpressionConverter.ConvertO(bodyimageConfigs);
                    bodypropCount++;
                }

                if (bodyallowAiIdeas != null)
                {
                    body["allow_ai_ideas"] = ExpressionConverter.ConvertO(bodyallowAiIdeas);
                    bodypropCount++;
                }

                if (bodyaiMissionType != null)
                {
                    body["ai_mission_type"] = ExpressionConverter.ConvertO(bodyaiMissionType);
                    bodypropCount++;
                }

                if (bodyfromScript != null)
                {
                    body["from_script"] = ExpressionConverter.ConvertO(bodyfromScript);
                    bodypropCount++;
                }

                if (bodyideaAttachmentsAllowed != null)
                {
                    body["idea_attachments_allowed"] = ExpressionConverter.ConvertO(bodyideaAttachmentsAllowed);
                    bodypropCount++;
                }

                if (bodyvideoLink != null)
                {
                    body["video_link"] = ExpressionConverter.ConvertO(bodyvideoLink);
                    bodypropCount++;
                }

                if (bodyhidden != null)
                {
                    body["hidden"] = ExpressionConverter.ConvertO(bodyhidden);
                    bodypropCount++;
                }

                if (bodyconfettiType != null)
                {
                    body["confetti_type"] = ExpressionConverter.ConvertO(bodyconfettiType);
                    bodypropCount++;
                }

                if (bodyenable != null)
                {
                    body["enable"] = ExpressionConverter.ConvertO(bodyenable);
                    bodypropCount++;
                }

                if (bodyaddAttachment != null)
                {
                    body["add_attachment"] = ExpressionConverter.ConvertO(bodyaddAttachment);
                    bodypropCount++;
                }

                if (bodyaddComment != null)
                {
                    body["add_comment"] = ExpressionConverter.ConvertO(bodyaddComment);
                    bodypropCount++;
                }

                if (bodyrecordUrl != null)
                {
                    body["record_url"] = ExpressionConverter.ConvertO(bodyrecordUrl);
                    bodypropCount++;
                }

                if (bodysyncId != null)
                {
                    body["sync_id"] = ExpressionConverter.ConvertO(bodysyncId);
                    bodypropCount++;
                }

                if (bodyideaCustomFields != null)
                {
                    body["idea_custom_fields"] = ExpressionConverter.ConvertO(bodyideaCustomFields);
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
        [WorkflowExpressionFactory(nameof(__BuildPatchmissionsId))]
        public IBodyWorkflowAction<PatchmissionsIdResponse> PatchmissionsId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bool> bodyhidden = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PatchmissionsIdResponse> __BuildPatchmissionsId(WorkflowExpression<string> id, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<bool> bodyhidden = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyhidden, nameof(bodyhidden), required: false);
            return new DeferredBodyAction<PatchmissionsIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/missions/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyhidden != null)
                {
                    body["hidden"] = ExpressionConverter.ConvertO(bodyhidden);
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
        [WorkflowExpressionFactory(nameof(__BuildPostprojects))]
        public IBodyWorkflowAction<PostprojectsResponse> Postprojects([WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodyfunnelId = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostprojectsResponse> __BuildPostprojects(WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<int> bodyfunnelId = null, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodyendDate = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyfunnelId, nameof(bodyfunnelId), required: false);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            return new DeferredBodyAction<PostprojectsResponse>(() =>
            {
                var apiCallPath = "/general/v1/projects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyfunnelId != null)
                {
                    body["funnel_id"] = ExpressionConverter.ConvertO(bodyfunnelId);
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

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostprojectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [WorkflowExpressionFactory(nameof(__BuildGetprojectsId))]
        public IBodyWorkflowAction<GetprojectsIdResponse> GetprojectsId([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetprojectsIdResponse> __BuildGetprojectsId(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GetprojectsIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetprojectsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteprojectsId))]
        public IWorkflowAction DeleteprojectsId([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteprojectsId(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [WorkflowExpressionFactory(nameof(__BuildPutprojectsId))]
        public IBodyWorkflowAction<PutprojectsIdResponse> PutprojectsId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyimage = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodystatusId = null, [WorkflowExpression] Func<string> bodydepartmentId = null, [WorkflowExpression] Func<string> bodyuserId = null, [WorkflowExpression] Func<string> bodystageId = null, [WorkflowExpression] Func<string> bodyprojectManagerId = null, [WorkflowExpression] Func<string> bodybusinessOwnerId = null, [WorkflowExpression] Func<string> bodyprogress = null, [WorkflowExpression] Func<string> bodycompanyId = null, [WorkflowExpression] Func<string> bodycommentsCount = null, [WorkflowExpression] Func<string> bodyprojectScore = null, [WorkflowExpression] Func<string> bodyslug = null, [WorkflowExpression] Func<string> bodyposition = null, [WorkflowExpression] Func<int> bodymodifiedBy = null, [WorkflowExpression] Func<int> bodytagsCount = null, [WorkflowExpression] Func<string> bodyfunnelId = null, [WorkflowExpression] Func<string> bodyfunnelStageId = null, [WorkflowExpression] Func<string> bodyfunnelStatusId = null, [WorkflowExpression] Func<string> bodystageDeadline = null, [WorkflowExpression] Func<string> bodydeadlineNotification = null, [WorkflowExpression] Func<string> bodystatusName = null, [WorkflowExpression] Func<string> bodyapprovedAt = null, [WorkflowExpression] Func<string> bodydeniedAt = null, [WorkflowExpression] Func<string> bodyamScores = null, [WorkflowExpression] Func<string> bodyprojectRevenue = null, [WorkflowExpression] Func<string> bodyprojectCost = null, [WorkflowExpression] Func<string> bodyprojectProfit = null, [WorkflowExpression] Func<string> bodyadminComments = null, [WorkflowExpression] Func<string> bodytempImage = null, [WorkflowExpression] Func<string> bodymainImage = null, [WorkflowExpression] Func<string> bodyimageConfigs = null, [WorkflowExpression] Func<string> bodyfromScript = null, [WorkflowExpression] Func<string> bodyreasonText = null, [WorkflowExpression] Func<string> bodycategoryText = null, [WorkflowExpression] Func<string> bodycanvassId = null, [WorkflowExpression] Func<string> bodybudgetTotal = null, [WorkflowExpression] Func<string> bodybudgetSpend = null, [WorkflowExpression] Func<string> bodybudgetResult = null, [WorkflowExpression] Func<string> bodytagText = null, [WorkflowExpression] Func<string> bodyestimatedTime = null, [WorkflowExpression] Func<string> bodytotalTimeSpend = null, [WorkflowExpression] Func<string> bodytotalTime = null, [WorkflowExpression] Func<string> bodyinnovationTypeId = null, [WorkflowExpression] Func<string> bodyinnovationTypeText = null, [WorkflowExpression] Func<string> bodysyncId = null, [WorkflowExpression] Func<string> bodyrecordUrl = null, [WorkflowExpression] Func<string> bodydescriptionEnriched = null, [WorkflowExpression] Func<string> bodycustomFieldValues = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PutprojectsIdResponse> __BuildPutprojectsId(WorkflowExpression<string> id, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodyimage = null, WorkflowExpression<string> bodystartDate = null, WorkflowExpression<string> bodyendDate = null, WorkflowExpression<string> bodystatusId = null, WorkflowExpression<string> bodydepartmentId = null, WorkflowExpression<string> bodyuserId = null, WorkflowExpression<string> bodystageId = null, WorkflowExpression<string> bodyprojectManagerId = null, WorkflowExpression<string> bodybusinessOwnerId = null, WorkflowExpression<string> bodyprogress = null, WorkflowExpression<string> bodycompanyId = null, WorkflowExpression<string> bodycommentsCount = null, WorkflowExpression<string> bodyprojectScore = null, WorkflowExpression<string> bodyslug = null, WorkflowExpression<string> bodyposition = null, WorkflowExpression<int> bodymodifiedBy = null, WorkflowExpression<int> bodytagsCount = null, WorkflowExpression<string> bodyfunnelId = null, WorkflowExpression<string> bodyfunnelStageId = null, WorkflowExpression<string> bodyfunnelStatusId = null, WorkflowExpression<string> bodystageDeadline = null, WorkflowExpression<string> bodydeadlineNotification = null, WorkflowExpression<string> bodystatusName = null, WorkflowExpression<string> bodyapprovedAt = null, WorkflowExpression<string> bodydeniedAt = null, WorkflowExpression<string> bodyamScores = null, WorkflowExpression<string> bodyprojectRevenue = null, WorkflowExpression<string> bodyprojectCost = null, WorkflowExpression<string> bodyprojectProfit = null, WorkflowExpression<string> bodyadminComments = null, WorkflowExpression<string> bodytempImage = null, WorkflowExpression<string> bodymainImage = null, WorkflowExpression<string> bodyimageConfigs = null, WorkflowExpression<string> bodyfromScript = null, WorkflowExpression<string> bodyreasonText = null, WorkflowExpression<string> bodycategoryText = null, WorkflowExpression<string> bodycanvassId = null, WorkflowExpression<string> bodybudgetTotal = null, WorkflowExpression<string> bodybudgetSpend = null, WorkflowExpression<string> bodybudgetResult = null, WorkflowExpression<string> bodytagText = null, WorkflowExpression<string> bodyestimatedTime = null, WorkflowExpression<string> bodytotalTimeSpend = null, WorkflowExpression<string> bodytotalTime = null, WorkflowExpression<string> bodyinnovationTypeId = null, WorkflowExpression<string> bodyinnovationTypeText = null, WorkflowExpression<string> bodysyncId = null, WorkflowExpression<string> bodyrecordUrl = null, WorkflowExpression<string> bodydescriptionEnriched = null, WorkflowExpression<string> bodycustomFieldValues = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyimage, nameof(bodyimage), required: false);
            WorkflowExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            WorkflowExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            WorkflowExpression.Validate(bodystatusId, nameof(bodystatusId), required: false);
            WorkflowExpression.Validate(bodydepartmentId, nameof(bodydepartmentId), required: false);
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            WorkflowExpression.Validate(bodystageId, nameof(bodystageId), required: false);
            WorkflowExpression.Validate(bodyprojectManagerId, nameof(bodyprojectManagerId), required: false);
            WorkflowExpression.Validate(bodybusinessOwnerId, nameof(bodybusinessOwnerId), required: false);
            WorkflowExpression.Validate(bodyprogress, nameof(bodyprogress), required: false);
            WorkflowExpression.Validate(bodycompanyId, nameof(bodycompanyId), required: false);
            WorkflowExpression.Validate(bodycommentsCount, nameof(bodycommentsCount), required: false);
            WorkflowExpression.Validate(bodyprojectScore, nameof(bodyprojectScore), required: false);
            WorkflowExpression.Validate(bodyslug, nameof(bodyslug), required: false);
            WorkflowExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            WorkflowExpression.Validate(bodymodifiedBy, nameof(bodymodifiedBy), required: false);
            WorkflowExpression.Validate(bodytagsCount, nameof(bodytagsCount), required: false);
            WorkflowExpression.Validate(bodyfunnelId, nameof(bodyfunnelId), required: false);
            WorkflowExpression.Validate(bodyfunnelStageId, nameof(bodyfunnelStageId), required: false);
            WorkflowExpression.Validate(bodyfunnelStatusId, nameof(bodyfunnelStatusId), required: false);
            WorkflowExpression.Validate(bodystageDeadline, nameof(bodystageDeadline), required: false);
            WorkflowExpression.Validate(bodydeadlineNotification, nameof(bodydeadlineNotification), required: false);
            WorkflowExpression.Validate(bodystatusName, nameof(bodystatusName), required: false);
            WorkflowExpression.Validate(bodyapprovedAt, nameof(bodyapprovedAt), required: false);
            WorkflowExpression.Validate(bodydeniedAt, nameof(bodydeniedAt), required: false);
            WorkflowExpression.Validate(bodyamScores, nameof(bodyamScores), required: false);
            WorkflowExpression.Validate(bodyprojectRevenue, nameof(bodyprojectRevenue), required: false);
            WorkflowExpression.Validate(bodyprojectCost, nameof(bodyprojectCost), required: false);
            WorkflowExpression.Validate(bodyprojectProfit, nameof(bodyprojectProfit), required: false);
            WorkflowExpression.Validate(bodyadminComments, nameof(bodyadminComments), required: false);
            WorkflowExpression.Validate(bodytempImage, nameof(bodytempImage), required: false);
            WorkflowExpression.Validate(bodymainImage, nameof(bodymainImage), required: false);
            WorkflowExpression.Validate(bodyimageConfigs, nameof(bodyimageConfigs), required: false);
            WorkflowExpression.Validate(bodyfromScript, nameof(bodyfromScript), required: false);
            WorkflowExpression.Validate(bodyreasonText, nameof(bodyreasonText), required: false);
            WorkflowExpression.Validate(bodycategoryText, nameof(bodycategoryText), required: false);
            WorkflowExpression.Validate(bodycanvassId, nameof(bodycanvassId), required: false);
            WorkflowExpression.Validate(bodybudgetTotal, nameof(bodybudgetTotal), required: false);
            WorkflowExpression.Validate(bodybudgetSpend, nameof(bodybudgetSpend), required: false);
            WorkflowExpression.Validate(bodybudgetResult, nameof(bodybudgetResult), required: false);
            WorkflowExpression.Validate(bodytagText, nameof(bodytagText), required: false);
            WorkflowExpression.Validate(bodyestimatedTime, nameof(bodyestimatedTime), required: false);
            WorkflowExpression.Validate(bodytotalTimeSpend, nameof(bodytotalTimeSpend), required: false);
            WorkflowExpression.Validate(bodytotalTime, nameof(bodytotalTime), required: false);
            WorkflowExpression.Validate(bodyinnovationTypeId, nameof(bodyinnovationTypeId), required: false);
            WorkflowExpression.Validate(bodyinnovationTypeText, nameof(bodyinnovationTypeText), required: false);
            WorkflowExpression.Validate(bodysyncId, nameof(bodysyncId), required: false);
            WorkflowExpression.Validate(bodyrecordUrl, nameof(bodyrecordUrl), required: false);
            WorkflowExpression.Validate(bodydescriptionEnriched, nameof(bodydescriptionEnriched), required: false);
            WorkflowExpression.Validate(bodycustomFieldValues, nameof(bodycustomFieldValues), required: false);
            return new DeferredBodyAction<PutprojectsIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyimage != null)
                {
                    body["image"] = ExpressionConverter.ConvertO(bodyimage);
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

                if (bodystatusId != null)
                {
                    body["status_id"] = ExpressionConverter.ConvertO(bodystatusId);
                    bodypropCount++;
                }

                if (bodydepartmentId != null)
                {
                    body["department_id"] = ExpressionConverter.ConvertO(bodydepartmentId);
                    bodypropCount++;
                }

                if (bodyuserId != null)
                {
                    body["user_id"] = ExpressionConverter.ConvertO(bodyuserId);
                    bodypropCount++;
                }

                if (bodystageId != null)
                {
                    body["stage_id"] = ExpressionConverter.ConvertO(bodystageId);
                    bodypropCount++;
                }

                if (bodyprojectManagerId != null)
                {
                    body["project_manager_id"] = ExpressionConverter.ConvertO(bodyprojectManagerId);
                    bodypropCount++;
                }

                if (bodybusinessOwnerId != null)
                {
                    body["business_owner_id"] = ExpressionConverter.ConvertO(bodybusinessOwnerId);
                    bodypropCount++;
                }

                if (bodyprogress != null)
                {
                    body["progress"] = ExpressionConverter.ConvertO(bodyprogress);
                    bodypropCount++;
                }

                if (bodycompanyId != null)
                {
                    body["company_id"] = ExpressionConverter.ConvertO(bodycompanyId);
                    bodypropCount++;
                }

                if (bodycommentsCount != null)
                {
                    body["comments_count"] = ExpressionConverter.ConvertO(bodycommentsCount);
                    bodypropCount++;
                }

                if (bodyprojectScore != null)
                {
                    body["project_score"] = ExpressionConverter.ConvertO(bodyprojectScore);
                    bodypropCount++;
                }

                if (bodyslug != null)
                {
                    body["slug"] = ExpressionConverter.ConvertO(bodyslug);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(bodyposition);
                    bodypropCount++;
                }

                if (bodymodifiedBy != null)
                {
                    body["modified_by"] = ExpressionConverter.ConvertO(bodymodifiedBy);
                    bodypropCount++;
                }

                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                if (bodytagsCount != null)
                {
                    body["tags_count"] = ExpressionConverter.ConvertO(bodytagsCount);
                    bodypropCount++;
                }

                if (bodyfunnelId != null)
                {
                    body["funnel_id"] = ExpressionConverter.ConvertO(bodyfunnelId);
                    bodypropCount++;
                }

                if (bodyfunnelStageId != null)
                {
                    body["funnel_stage_id"] = ExpressionConverter.ConvertO(bodyfunnelStageId);
                    bodypropCount++;
                }

                if (bodyfunnelStatusId != null)
                {
                    body["funnel_status_id"] = ExpressionConverter.ConvertO(bodyfunnelStatusId);
                    bodypropCount++;
                }

                if (bodystageDeadline != null)
                {
                    body["stage_deadline"] = ExpressionConverter.ConvertO(bodystageDeadline);
                    bodypropCount++;
                }

                if (bodydeadlineNotification != null)
                {
                    body["deadline_notification"] = ExpressionConverter.ConvertO(bodydeadlineNotification);
                    bodypropCount++;
                }

                if (bodystatusName != null)
                {
                    body["status_name"] = ExpressionConverter.ConvertO(bodystatusName);
                    bodypropCount++;
                }

                if (bodyapprovedAt != null)
                {
                    body["approved_at"] = ExpressionConverter.ConvertO(bodyapprovedAt);
                    bodypropCount++;
                }

                if (bodydeniedAt != null)
                {
                    body["denied_at"] = ExpressionConverter.ConvertO(bodydeniedAt);
                    bodypropCount++;
                }

                if (bodyamScores != null)
                {
                    body["am_scores"] = ExpressionConverter.ConvertO(bodyamScores);
                    bodypropCount++;
                }

                if (bodyprojectRevenue != null)
                {
                    body["project_revenue"] = ExpressionConverter.ConvertO(bodyprojectRevenue);
                    bodypropCount++;
                }

                if (bodyprojectCost != null)
                {
                    body["project_cost"] = ExpressionConverter.ConvertO(bodyprojectCost);
                    bodypropCount++;
                }

                if (bodyprojectProfit != null)
                {
                    body["project_profit"] = ExpressionConverter.ConvertO(bodyprojectProfit);
                    bodypropCount++;
                }

                if (bodyadminComments != null)
                {
                    body["admin_comments"] = ExpressionConverter.ConvertO(bodyadminComments);
                    bodypropCount++;
                }

                if (bodytempImage != null)
                {
                    body["temp_image"] = ExpressionConverter.ConvertO(bodytempImage);
                    bodypropCount++;
                }

                if (bodymainImage != null)
                {
                    body["main_image"] = ExpressionConverter.ConvertO(bodymainImage);
                    bodypropCount++;
                }

                if (bodyimageConfigs != null)
                {
                    body["image_configs"] = ExpressionConverter.ConvertO(bodyimageConfigs);
                    bodypropCount++;
                }

                if (bodyfromScript != null)
                {
                    body["from_script"] = ExpressionConverter.ConvertO(bodyfromScript);
                    bodypropCount++;
                }

                if (bodyreasonText != null)
                {
                    body["reason_text"] = ExpressionConverter.ConvertO(bodyreasonText);
                    bodypropCount++;
                }

                if (bodycategoryText != null)
                {
                    body["category_text"] = ExpressionConverter.ConvertO(bodycategoryText);
                    bodypropCount++;
                }

                if (bodycanvassId != null)
                {
                    body["canvass_id"] = ExpressionConverter.ConvertO(bodycanvassId);
                    bodypropCount++;
                }

                if (bodybudgetTotal != null)
                {
                    body["budget_total"] = ExpressionConverter.ConvertO(bodybudgetTotal);
                    bodypropCount++;
                }

                if (bodybudgetSpend != null)
                {
                    body["budget_spend"] = ExpressionConverter.ConvertO(bodybudgetSpend);
                    bodypropCount++;
                }

                if (bodybudgetResult != null)
                {
                    body["budget_result"] = ExpressionConverter.ConvertO(bodybudgetResult);
                    bodypropCount++;
                }

                if (bodytagText != null)
                {
                    body["tag_text"] = ExpressionConverter.ConvertO(bodytagText);
                    bodypropCount++;
                }

                if (bodyestimatedTime != null)
                {
                    body["estimated_time"] = ExpressionConverter.ConvertO(bodyestimatedTime);
                    bodypropCount++;
                }

                if (bodytotalTimeSpend != null)
                {
                    body["total_time_spend"] = ExpressionConverter.ConvertO(bodytotalTimeSpend);
                    bodypropCount++;
                }

                if (bodytotalTime != null)
                {
                    body["total_time"] = ExpressionConverter.ConvertO(bodytotalTime);
                    bodypropCount++;
                }

                if (bodyinnovationTypeId != null)
                {
                    body["innovation_type_id"] = ExpressionConverter.ConvertO(bodyinnovationTypeId);
                    bodypropCount++;
                }

                if (bodyinnovationTypeText != null)
                {
                    body["innovation_type_text"] = ExpressionConverter.ConvertO(bodyinnovationTypeText);
                    bodypropCount++;
                }

                if (bodysyncId != null)
                {
                    body["sync_id"] = ExpressionConverter.ConvertO(bodysyncId);
                    bodypropCount++;
                }

                if (bodyrecordUrl != null)
                {
                    body["record_url"] = ExpressionConverter.ConvertO(bodyrecordUrl);
                    bodypropCount++;
                }

                if (bodydescriptionEnriched != null)
                {
                    body["description_enriched"] = ExpressionConverter.ConvertO(bodydescriptionEnriched);
                    bodypropCount++;
                }

                if (bodycustomFieldValues != null)
                {
                    body["custom_field_values"] = ExpressionConverter.ConvertO(bodycustomFieldValues);
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
        [WorkflowExpressionFactory(nameof(__BuildPatchprojectsId))]
        public IBodyWorkflowAction<PatchprojectsIdResponse> PatchprojectsId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PatchprojectsIdResponse> __BuildPatchprojectsId(WorkflowExpression<string> id, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodydescription = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<PatchprojectsIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
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
        [WorkflowExpressionFactory(nameof(__BuildGetprojectsProjectIdTasks))]
        public IBodyWorkflowAction<GetprojectsProjectIdTasksResponse> GetprojectsProjectIdTasks([WorkflowExpression] Func<string> projectId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetprojectsProjectIdTasksResponse> __BuildGetprojectsProjectIdTasks(WorkflowExpression<string> projectId)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<GetprojectsProjectIdTasksResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/projects/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetprojectsProjectIdTasksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [WorkflowExpressionFactory(nameof(__BuildPostprojectsProjectIdTasks))]
        public IBodyWorkflowAction<PostprojectsProjectIdTasksResponse> PostprojectsProjectIdTasks([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<int> bodystatus = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostprojectsProjectIdTasksResponse> __BuildPostprojectsProjectIdTasks(WorkflowExpression<string> projectId, WorkflowExpression<string> bodytitle = null, WorkflowExpression<int> bodystatus = null)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<PostprojectsProjectIdTasksResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/projects/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
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
        [WorkflowExpressionFactory(nameof(__BuildGetTaskBySyncId))]
        public IBodyWorkflowAction<GetTaskBySyncIdResponse> GetTaskBySyncId([WorkflowExpression] Func<string> syncId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTaskBySyncIdResponse> __BuildGetTaskBySyncId(WorkflowExpression<string> syncId = null)
        {
            WorkflowExpression.Validate(syncId, nameof(syncId), required: false);
            return new DeferredBodyAction<GetTaskBySyncIdResponse>(() =>
            {
                var apiCallPath = "/general/v1/tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (syncId != null)
                    callPayload.Queries["sync_id"] = ExpressionConverter.Convert(syncId);
                return new ApiConnectionAction<GetTaskBySyncIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [WorkflowExpressionFactory(nameof(__BuildPosttasks))]
        public IBodyWorkflowAction<PosttasksResponse> Posttasks([WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<int> bodystatus = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PosttasksResponse> __BuildPosttasks(WorkflowExpression<string> bodytitle = null, WorkflowExpression<int> bodystatus = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<PosttasksResponse>(() =>
            {
                var apiCallPath = "/general/v1/tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
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
        [WorkflowExpressionFactory(nameof(__BuildGettasksId))]
        public IBodyWorkflowAction<GettasksIdResponse> GettasksId([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GettasksIdResponse> __BuildGettasksId(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GettasksIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GettasksIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [WorkflowExpressionFactory(nameof(__BuildDeletetasksId))]
        public IWorkflowAction DeletetasksId([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeletetasksId(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [WorkflowExpressionFactory(nameof(__BuildPatchtasksId))]
        public IBodyWorkflowAction<PatchtasksIdResponse> PatchtasksId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<int> bodystatus = null, [WorkflowExpression] Func<string> bodysyncId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PatchtasksIdResponse> __BuildPatchtasksId(WorkflowExpression<string> id, WorkflowExpression<string> bodytitle = null, WorkflowExpression<int> bodystatus = null, WorkflowExpression<string> bodysyncId = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodysyncId, nameof(bodysyncId), required: false);
            return new DeferredBodyAction<PatchtasksIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodysyncId != null)
                {
                    body["sync_id"] = ExpressionConverter.ConvertO(bodysyncId);
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
        [WorkflowExpressionFactory(nameof(__BuildDeletetopicsId))]
        public IWorkflowAction DeletetopicsId([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeletetopicsId(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/topics/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        [WorkflowExpressionFactory(nameof(__BuildPostusers))]
        public IBodyWorkflowAction<PostusersResponse> Postusers([WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodyphoneNumber = null, [WorkflowExpression] Func<int> bodyposition = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostusersResponse> __BuildPostusers(WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<string> bodylastName = null, WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodypassword = null, WorkflowExpression<string> bodyphoneNumber = null, WorkflowExpression<int> bodyposition = null)
        {
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            WorkflowExpression.Validate(bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            WorkflowExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            return new DeferredBodyAction<PostusersResponse>(() =>
            {
                var apiCallPath = "/general/v1/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfirstName != null)
                {
                    body["first_name"] = ExpressionConverter.ConvertO(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["last_name"] = ExpressionConverter.ConvertO(bodylastName);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(bodypassword);
                    bodypropCount++;
                }

                if (bodyphoneNumber != null)
                {
                    body["phone_number"] = ExpressionConverter.ConvertO(bodyphoneNumber);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(bodyposition);
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
        [WorkflowExpressionFactory(nameof(__BuildGetusersId))]
        public IBodyWorkflowAction<GetusersIdResponse> GetusersId([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetusersIdResponse> __BuildGetusersId(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GetusersIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetusersIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteusersId))]
        public IWorkflowAction DeleteusersId([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteusersId(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [WorkflowExpressionFactory(nameof(__BuildPutusersId))]
        public IBodyWorkflowAction<PutusersIdResponse> PutusersId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodyprofilePic = null, [WorkflowExpression] Func<int> bodypoints = null, [WorkflowExpression] Func<int> bodycompanyId = null, [WorkflowExpression] Func<int> bodyuserRoleId = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyslug = null, [WorkflowExpression] Func<string> bodyphoneNumber = null, [WorkflowExpression] Func<string> bodylastSignOutAt = null, [WorkflowExpression] Func<string> bodyposition = null, [WorkflowExpression] Func<bool> bodyprofileFlag = null, [WorkflowExpression] Func<string> bodyuserChecklist = null, [WorkflowExpression] Func<int> bodyideaLikesCount = null, [WorkflowExpression] Func<int> bodycommentsCount = null, [WorkflowExpression] Func<int> bodyxpPoints = null, [WorkflowExpression] Func<int> bodyideasCount = null, [WorkflowExpression] Func<string> bodyfunnelId = null, [WorkflowExpression] Func<int> bodylevel = null, [WorkflowExpression] Func<int> bodyxpLevel = null, [WorkflowExpression] Func<string> bodyprojectFunnelId = null, [WorkflowExpression] Func<string> bodychecklistScore = null, [WorkflowExpression] Func<string> bodyprovider = null, [WorkflowExpression] Func<string> bodyuid = null, [WorkflowExpression] Func<string> bodyemailSentAt = null, [WorkflowExpression] Func<bool> bodyblockAllNotification = null, [WorkflowExpression] Func<string> bodydbName = null, [WorkflowExpression] Func<string> bodydeptId = null, [WorkflowExpression] Func<string> bodydeptName = null, [WorkflowExpression] Func<string> bodymainImage = null, [WorkflowExpression] Func<string> bodytempImage = null, [WorkflowExpression] Func<string> bodyimageConfigs = null, [WorkflowExpression] Func<bool> bodyimageAutoGenerated = null, [WorkflowExpression] Func<string> bodyamAccount = null, [WorkflowExpression] Func<string> bodyuuid = null, [WorkflowExpression] Func<string> bodypasswordResetAttempts = null, [WorkflowExpression] Func<string> bodylastPasswordResetAt = null, [WorkflowExpression] Func<string> bodycustomDomain = null, [WorkflowExpression] Func<string> bodyuserRoleName = null, [WorkflowExpression] Func<int> bodytheme = null, [WorkflowExpression] Func<string> bodyuserType = null, [WorkflowExpression] Func<string> bodyviewSettings = null, [WorkflowExpression] Func<string> bodyreadManual = null, [WorkflowExpression] Func<string> bodyaddIdeaBox = null, [WorkflowExpression] Func<string> bodyvisitAgent = null, [WorkflowExpression] Func<string> bodyaddIdea = null, [WorkflowExpression] Func<string> bodyinvitePeople = null, [WorkflowExpression] Func<string> bodyaddBoardMission = null, [WorkflowExpression] Func<string> bodyaddProject = null, [WorkflowExpression] Func<string> bodycompletedChecklist = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PutusersIdResponse> __BuildPutusersId(WorkflowExpression<string> id, WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<string> bodylastName = null, WorkflowExpression<string> bodyprofilePic = null, WorkflowExpression<int> bodypoints = null, WorkflowExpression<int> bodycompanyId = null, WorkflowExpression<int> bodyuserRoleId = null, WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodyslug = null, WorkflowExpression<string> bodyphoneNumber = null, WorkflowExpression<string> bodylastSignOutAt = null, WorkflowExpression<string> bodyposition = null, WorkflowExpression<bool> bodyprofileFlag = null, WorkflowExpression<string> bodyuserChecklist = null, WorkflowExpression<int> bodyideaLikesCount = null, WorkflowExpression<int> bodycommentsCount = null, WorkflowExpression<int> bodyxpPoints = null, WorkflowExpression<int> bodyideasCount = null, WorkflowExpression<string> bodyfunnelId = null, WorkflowExpression<int> bodylevel = null, WorkflowExpression<int> bodyxpLevel = null, WorkflowExpression<string> bodyprojectFunnelId = null, WorkflowExpression<string> bodychecklistScore = null, WorkflowExpression<string> bodyprovider = null, WorkflowExpression<string> bodyuid = null, WorkflowExpression<string> bodyemailSentAt = null, WorkflowExpression<bool> bodyblockAllNotification = null, WorkflowExpression<string> bodydbName = null, WorkflowExpression<string> bodydeptId = null, WorkflowExpression<string> bodydeptName = null, WorkflowExpression<string> bodymainImage = null, WorkflowExpression<string> bodytempImage = null, WorkflowExpression<string> bodyimageConfigs = null, WorkflowExpression<bool> bodyimageAutoGenerated = null, WorkflowExpression<string> bodyamAccount = null, WorkflowExpression<string> bodyuuid = null, WorkflowExpression<string> bodypasswordResetAttempts = null, WorkflowExpression<string> bodylastPasswordResetAt = null, WorkflowExpression<string> bodycustomDomain = null, WorkflowExpression<string> bodyuserRoleName = null, WorkflowExpression<int> bodytheme = null, WorkflowExpression<string> bodyuserType = null, WorkflowExpression<string> bodyviewSettings = null, WorkflowExpression<string> bodyreadManual = null, WorkflowExpression<string> bodyaddIdeaBox = null, WorkflowExpression<string> bodyvisitAgent = null, WorkflowExpression<string> bodyaddIdea = null, WorkflowExpression<string> bodyinvitePeople = null, WorkflowExpression<string> bodyaddBoardMission = null, WorkflowExpression<string> bodyaddProject = null, WorkflowExpression<string> bodycompletedChecklist = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowExpression.Validate(bodyprofilePic, nameof(bodyprofilePic), required: false);
            WorkflowExpression.Validate(bodypoints, nameof(bodypoints), required: false);
            WorkflowExpression.Validate(bodycompanyId, nameof(bodycompanyId), required: false);
            WorkflowExpression.Validate(bodyuserRoleId, nameof(bodyuserRoleId), required: false);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodyslug, nameof(bodyslug), required: false);
            WorkflowExpression.Validate(bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            WorkflowExpression.Validate(bodylastSignOutAt, nameof(bodylastSignOutAt), required: false);
            WorkflowExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            WorkflowExpression.Validate(bodyprofileFlag, nameof(bodyprofileFlag), required: false);
            WorkflowExpression.Validate(bodyuserChecklist, nameof(bodyuserChecklist), required: false);
            WorkflowExpression.Validate(bodyideaLikesCount, nameof(bodyideaLikesCount), required: false);
            WorkflowExpression.Validate(bodycommentsCount, nameof(bodycommentsCount), required: false);
            WorkflowExpression.Validate(bodyxpPoints, nameof(bodyxpPoints), required: false);
            WorkflowExpression.Validate(bodyideasCount, nameof(bodyideasCount), required: false);
            WorkflowExpression.Validate(bodyfunnelId, nameof(bodyfunnelId), required: false);
            WorkflowExpression.Validate(bodylevel, nameof(bodylevel), required: false);
            WorkflowExpression.Validate(bodyxpLevel, nameof(bodyxpLevel), required: false);
            WorkflowExpression.Validate(bodyprojectFunnelId, nameof(bodyprojectFunnelId), required: false);
            WorkflowExpression.Validate(bodychecklistScore, nameof(bodychecklistScore), required: false);
            WorkflowExpression.Validate(bodyprovider, nameof(bodyprovider), required: false);
            WorkflowExpression.Validate(bodyuid, nameof(bodyuid), required: false);
            WorkflowExpression.Validate(bodyemailSentAt, nameof(bodyemailSentAt), required: false);
            WorkflowExpression.Validate(bodyblockAllNotification, nameof(bodyblockAllNotification), required: false);
            WorkflowExpression.Validate(bodydbName, nameof(bodydbName), required: false);
            WorkflowExpression.Validate(bodydeptId, nameof(bodydeptId), required: false);
            WorkflowExpression.Validate(bodydeptName, nameof(bodydeptName), required: false);
            WorkflowExpression.Validate(bodymainImage, nameof(bodymainImage), required: false);
            WorkflowExpression.Validate(bodytempImage, nameof(bodytempImage), required: false);
            WorkflowExpression.Validate(bodyimageConfigs, nameof(bodyimageConfigs), required: false);
            WorkflowExpression.Validate(bodyimageAutoGenerated, nameof(bodyimageAutoGenerated), required: false);
            WorkflowExpression.Validate(bodyamAccount, nameof(bodyamAccount), required: false);
            WorkflowExpression.Validate(bodyuuid, nameof(bodyuuid), required: false);
            WorkflowExpression.Validate(bodypasswordResetAttempts, nameof(bodypasswordResetAttempts), required: false);
            WorkflowExpression.Validate(bodylastPasswordResetAt, nameof(bodylastPasswordResetAt), required: false);
            WorkflowExpression.Validate(bodycustomDomain, nameof(bodycustomDomain), required: false);
            WorkflowExpression.Validate(bodyuserRoleName, nameof(bodyuserRoleName), required: false);
            WorkflowExpression.Validate(bodytheme, nameof(bodytheme), required: false);
            WorkflowExpression.Validate(bodyuserType, nameof(bodyuserType), required: false);
            WorkflowExpression.Validate(bodyviewSettings, nameof(bodyviewSettings), required: false);
            WorkflowExpression.Validate(bodyreadManual, nameof(bodyreadManual), required: false);
            WorkflowExpression.Validate(bodyaddIdeaBox, nameof(bodyaddIdeaBox), required: false);
            WorkflowExpression.Validate(bodyvisitAgent, nameof(bodyvisitAgent), required: false);
            WorkflowExpression.Validate(bodyaddIdea, nameof(bodyaddIdea), required: false);
            WorkflowExpression.Validate(bodyinvitePeople, nameof(bodyinvitePeople), required: false);
            WorkflowExpression.Validate(bodyaddBoardMission, nameof(bodyaddBoardMission), required: false);
            WorkflowExpression.Validate(bodyaddProject, nameof(bodyaddProject), required: false);
            WorkflowExpression.Validate(bodycompletedChecklist, nameof(bodycompletedChecklist), required: false);
            return new DeferredBodyAction<PutusersIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/general/v1/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfirstName != null)
                {
                    body["first_name"] = ExpressionConverter.ConvertO(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["last_name"] = ExpressionConverter.ConvertO(bodylastName);
                    bodypropCount++;
                }

                if (bodyprofilePic != null)
                {
                    body["profile_pic"] = ExpressionConverter.ConvertO(bodyprofilePic);
                    bodypropCount++;
                }

                if (bodypoints != null)
                {
                    body["points"] = ExpressionConverter.ConvertO(bodypoints);
                    bodypropCount++;
                }

                if (bodycompanyId != null)
                {
                    body["company_id"] = ExpressionConverter.ConvertO(bodycompanyId);
                    bodypropCount++;
                }

                if (bodyuserRoleId != null)
                {
                    body["user_role_id"] = ExpressionConverter.ConvertO(bodyuserRoleId);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodyslug != null)
                {
                    body["slug"] = ExpressionConverter.ConvertO(bodyslug);
                    bodypropCount++;
                }

                if (bodyphoneNumber != null)
                {
                    body["phone_number"] = ExpressionConverter.ConvertO(bodyphoneNumber);
                    bodypropCount++;
                }

                if (bodylastSignOutAt != null)
                {
                    body["last_sign_out_at"] = ExpressionConverter.ConvertO(bodylastSignOutAt);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = ExpressionConverter.ConvertO(bodyposition);
                    bodypropCount++;
                }

                if (bodyprofileFlag != null)
                {
                    body["profile_flag"] = ExpressionConverter.ConvertO(bodyprofileFlag);
                    bodypropCount++;
                }

                if (bodyuserChecklist != null)
                {
                    body["user_checklist"] = ExpressionConverter.ConvertO(bodyuserChecklist);
                    bodypropCount++;
                }

                if (bodyideaLikesCount != null)
                {
                    body["idea_likes_count"] = ExpressionConverter.ConvertO(bodyideaLikesCount);
                    bodypropCount++;
                }

                if (bodycommentsCount != null)
                {
                    body["comments_count"] = ExpressionConverter.ConvertO(bodycommentsCount);
                    bodypropCount++;
                }

                if (bodyxpPoints != null)
                {
                    body["xp_points"] = ExpressionConverter.ConvertO(bodyxpPoints);
                    bodypropCount++;
                }

                if (bodyideasCount != null)
                {
                    body["ideas_count"] = ExpressionConverter.ConvertO(bodyideasCount);
                    bodypropCount++;
                }

                if (bodyfunnelId != null)
                {
                    body["funnel_id"] = ExpressionConverter.ConvertO(bodyfunnelId);
                    bodypropCount++;
                }

                if (bodylevel != null)
                {
                    body["level"] = ExpressionConverter.ConvertO(bodylevel);
                    bodypropCount++;
                }

                if (bodyxpLevel != null)
                {
                    body["xp_level"] = ExpressionConverter.ConvertO(bodyxpLevel);
                    bodypropCount++;
                }

                if (bodyprojectFunnelId != null)
                {
                    body["project_funnel_id"] = ExpressionConverter.ConvertO(bodyprojectFunnelId);
                    bodypropCount++;
                }

                if (bodychecklistScore != null)
                {
                    body["checklist_score"] = ExpressionConverter.ConvertO(bodychecklistScore);
                    bodypropCount++;
                }

                if (bodyprovider != null)
                {
                    body["provider"] = ExpressionConverter.ConvertO(bodyprovider);
                    bodypropCount++;
                }

                if (bodyuid != null)
                {
                    body["uid"] = ExpressionConverter.ConvertO(bodyuid);
                    bodypropCount++;
                }

                if (bodyemailSentAt != null)
                {
                    body["email_sent_at"] = ExpressionConverter.ConvertO(bodyemailSentAt);
                    bodypropCount++;
                }

                if (bodyblockAllNotification != null)
                {
                    body["block_all_notification"] = ExpressionConverter.ConvertO(bodyblockAllNotification);
                    bodypropCount++;
                }

                if (bodydbName != null)
                {
                    body["db_name"] = ExpressionConverter.ConvertO(bodydbName);
                    bodypropCount++;
                }

                if (bodydeptId != null)
                {
                    body["dept_id"] = ExpressionConverter.ConvertO(bodydeptId);
                    bodypropCount++;
                }

                if (bodydeptName != null)
                {
                    body["dept_name"] = ExpressionConverter.ConvertO(bodydeptName);
                    bodypropCount++;
                }

                if (bodymainImage != null)
                {
                    body["main_image"] = ExpressionConverter.ConvertO(bodymainImage);
                    bodypropCount++;
                }

                if (bodytempImage != null)
                {
                    body["temp_image"] = ExpressionConverter.ConvertO(bodytempImage);
                    bodypropCount++;
                }

                if (bodyimageConfigs != null)
                {
                    body["image_configs"] = ExpressionConverter.ConvertO(bodyimageConfigs);
                    bodypropCount++;
                }

                if (bodyimageAutoGenerated != null)
                {
                    body["image_auto_generated"] = ExpressionConverter.ConvertO(bodyimageAutoGenerated);
                    bodypropCount++;
                }

                if (bodyamAccount != null)
                {
                    body["am_account"] = ExpressionConverter.ConvertO(bodyamAccount);
                    bodypropCount++;
                }

                if (bodyuuid != null)
                {
                    body["uuid"] = ExpressionConverter.ConvertO(bodyuuid);
                    bodypropCount++;
                }

                if (bodypasswordResetAttempts != null)
                {
                    body["password_reset_attempts"] = ExpressionConverter.ConvertO(bodypasswordResetAttempts);
                    bodypropCount++;
                }

                if (bodylastPasswordResetAt != null)
                {
                    body["last_password_reset_at"] = ExpressionConverter.ConvertO(bodylastPasswordResetAt);
                    bodypropCount++;
                }

                if (bodycustomDomain != null)
                {
                    body["custom_domain"] = ExpressionConverter.ConvertO(bodycustomDomain);
                    bodypropCount++;
                }

                if (bodyuserRoleName != null)
                {
                    body["user_role_name"] = ExpressionConverter.ConvertO(bodyuserRoleName);
                    bodypropCount++;
                }

                if (bodytheme != null)
                {
                    body["theme"] = ExpressionConverter.ConvertO(bodytheme);
                    bodypropCount++;
                }

                if (bodyuserType != null)
                {
                    body["user_type"] = ExpressionConverter.ConvertO(bodyuserType);
                    bodypropCount++;
                }

                if (bodyviewSettings != null)
                {
                    body["view_settings"] = ExpressionConverter.ConvertO(bodyviewSettings);
                    bodypropCount++;
                }

                if (bodyreadManual != null)
                {
                    body["read_manual"] = ExpressionConverter.ConvertO(bodyreadManual);
                    bodypropCount++;
                }

                if (bodyaddIdeaBox != null)
                {
                    body["add_idea_box"] = ExpressionConverter.ConvertO(bodyaddIdeaBox);
                    bodypropCount++;
                }

                if (bodyvisitAgent != null)
                {
                    body["visit_agent"] = ExpressionConverter.ConvertO(bodyvisitAgent);
                    bodypropCount++;
                }

                if (bodyaddIdea != null)
                {
                    body["add_idea"] = ExpressionConverter.ConvertO(bodyaddIdea);
                    bodypropCount++;
                }

                if (bodyinvitePeople != null)
                {
                    body["invite_people"] = ExpressionConverter.ConvertO(bodyinvitePeople);
                    bodypropCount++;
                }

                if (bodyaddBoardMission != null)
                {
                    body["add_board_mission"] = ExpressionConverter.ConvertO(bodyaddBoardMission);
                    bodypropCount++;
                }

                if (bodyaddProject != null)
                {
                    body["add_project"] = ExpressionConverter.ConvertO(bodyaddProject);
                    bodypropCount++;
                }

                if (bodycompletedChecklist != null)
                {
                    body["completed_checklist"] = ExpressionConverter.ConvertO(bodycompletedChecklist);
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
        public IWorkflowTrigger TriggerIdeaCreated(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerIdeaUpdated(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerIdeaDeleted(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerProjectCreated(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerProjectUpdated(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerProjectDelete(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggertaskCreated(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggercategoryCreated(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerCategoryUpdated(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerCategoryDeleted(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerdepartmentCreated(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerdepartmentUpdated(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerdepartmentDeleted(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerfunnellaneCreated(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerfunnellaneUpdated(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerfunnellaneDeleted(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerfunnelCreated(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerfunnelUpdated(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerfunnelDeleted(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggermissionCreated(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggermissionUpdated(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggermissionDeleted(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggertopicCreated(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggertopicUpdated(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggertopicDeleted(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggertaskUpdated(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggertaskDeleted(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggeruserCreated(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggeruserUpdated(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggeruserDeleted(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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