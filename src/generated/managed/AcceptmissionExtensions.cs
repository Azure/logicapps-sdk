//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Acceptmission
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AcceptmissionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetcategoriesResponseItem[]> Getcategories()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetcategoriesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PostcategoriesResponse> Postcategories([WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<int> bodyposition = null, [WorkflowExpression] Func<string> bodychipColor = null, [WorkflowExpression] Func<string> bodymissionsId = null, [WorkflowExpression] Func<int> bodycompanyId = null, [WorkflowExpression] Func<string> bodyimage = null, [WorkflowExpression] Func<int> bodyuserId = null, [WorkflowExpression] Func<string> bodytempImage = null, [WorkflowExpression] Func<string> bodymainImage = null, [WorkflowExpression] Func<string> bodyimageConfigs = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodyupdatedBy = null, [WorkflowExpression] Func<string> bodyrecordUrl = null, [WorkflowExpression] Func<string> bodysyncId = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            SourceExpression.Validate(bodychipColor, nameof(bodychipColor), required: false);
            SourceExpression.Validate(bodymissionsId, nameof(bodymissionsId), required: false);
            SourceExpression.Validate(bodycompanyId, nameof(bodycompanyId), required: false);
            SourceExpression.Validate(bodyimage, nameof(bodyimage), required: false);
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            SourceExpression.Validate(bodytempImage, nameof(bodytempImage), required: false);
            SourceExpression.Validate(bodymainImage, nameof(bodymainImage), required: false);
            SourceExpression.Validate(bodyimageConfigs, nameof(bodyimageConfigs), required: false);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            SourceExpression.Validate(bodyupdatedBy, nameof(bodyupdatedBy), required: false);
            SourceExpression.Validate(bodyrecordUrl, nameof(bodyrecordUrl), required: false);
            SourceExpression.Validate(bodysyncId, nameof(bodysyncId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/categories";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodychipColor != null)
                {
                    body["chip_color"] = SourceExpressionConverter.ConvertToken(bodychipColor);
                    bodypropCount++;
                }

                if (bodymissionsId != null)
                {
                    body["missions_id"] = SourceExpressionConverter.ConvertToken(bodymissionsId);
                    bodypropCount++;
                }

                if (bodycompanyId != null)
                {
                    body["company_id"] = SourceExpressionConverter.ConvertToken(bodycompanyId);
                    bodypropCount++;
                }

                if (bodyimage != null)
                {
                    body["image"] = SourceExpressionConverter.ConvertToken(bodyimage);
                    bodypropCount++;
                }

                if (bodyuserId != null)
                {
                    body["user_id"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                if (bodytempImage != null)
                {
                    body["temp_image"] = SourceExpressionConverter.ConvertToken(bodytempImage);
                    bodypropCount++;
                }

                if (bodymainImage != null)
                {
                    body["main_image"] = SourceExpressionConverter.ConvertToken(bodymainImage);
                    bodypropCount++;
                }

                if (bodyimageConfigs != null)
                {
                    body["image_configs"] = SourceExpressionConverter.ConvertToken(bodyimageConfigs);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["owner_id"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                    bodypropCount++;
                }

                if (bodyupdatedBy != null)
                {
                    body["updated_by"] = SourceExpressionConverter.ConvertToken(bodyupdatedBy);
                    bodypropCount++;
                }

                if (bodyrecordUrl != null)
                {
                    body["record_url"] = SourceExpressionConverter.ConvertToken(bodyrecordUrl);
                    bodypropCount++;
                }

                if (bodysyncId != null)
                {
                    body["sync_id"] = SourceExpressionConverter.ConvertToken(bodysyncId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PostcategoriesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetcategoriesIdResponse> GetcategoriesId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/categories/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetcategoriesIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeletecategoriesId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/categories/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PutcategoriesIdResponse> PutcategoriesId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<int> bodyposition = null, [WorkflowExpression] Func<string> bodychipColor = null, [WorkflowExpression] Func<string> bodymissionsId = null, [WorkflowExpression] Func<int> bodycompanyId = null, [WorkflowExpression] Func<string> bodyimage = null, [WorkflowExpression] Func<int> bodyuserId = null, [WorkflowExpression] Func<string> bodytempImage = null, [WorkflowExpression] Func<string> bodymainImage = null, [WorkflowExpression] Func<string> bodyimageConfigs = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodyupdatedBy = null, [WorkflowExpression] Func<string> bodyrecordUrl = null, [WorkflowExpression] Func<string> bodysyncId = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            SourceExpression.Validate(bodychipColor, nameof(bodychipColor), required: false);
            SourceExpression.Validate(bodymissionsId, nameof(bodymissionsId), required: false);
            SourceExpression.Validate(bodycompanyId, nameof(bodycompanyId), required: false);
            SourceExpression.Validate(bodyimage, nameof(bodyimage), required: false);
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            SourceExpression.Validate(bodytempImage, nameof(bodytempImage), required: false);
            SourceExpression.Validate(bodymainImage, nameof(bodymainImage), required: false);
            SourceExpression.Validate(bodyimageConfigs, nameof(bodyimageConfigs), required: false);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            SourceExpression.Validate(bodyupdatedBy, nameof(bodyupdatedBy), required: false);
            SourceExpression.Validate(bodyrecordUrl, nameof(bodyrecordUrl), required: false);
            SourceExpression.Validate(bodysyncId, nameof(bodysyncId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/categories/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodychipColor != null)
                {
                    body["chip_color"] = SourceExpressionConverter.ConvertToken(bodychipColor);
                    bodypropCount++;
                }

                if (bodymissionsId != null)
                {
                    body["missions_id"] = SourceExpressionConverter.ConvertToken(bodymissionsId);
                    bodypropCount++;
                }

                if (bodycompanyId != null)
                {
                    body["company_id"] = SourceExpressionConverter.ConvertToken(bodycompanyId);
                    bodypropCount++;
                }

                if (bodyimage != null)
                {
                    body["image"] = SourceExpressionConverter.ConvertToken(bodyimage);
                    bodypropCount++;
                }

                if (bodyuserId != null)
                {
                    body["user_id"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                if (bodytempImage != null)
                {
                    body["temp_image"] = SourceExpressionConverter.ConvertToken(bodytempImage);
                    bodypropCount++;
                }

                if (bodymainImage != null)
                {
                    body["main_image"] = SourceExpressionConverter.ConvertToken(bodymainImage);
                    bodypropCount++;
                }

                if (bodyimageConfigs != null)
                {
                    body["image_configs"] = SourceExpressionConverter.ConvertToken(bodyimageConfigs);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["owner_id"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                    bodypropCount++;
                }

                if (bodyupdatedBy != null)
                {
                    body["updated_by"] = SourceExpressionConverter.ConvertToken(bodyupdatedBy);
                    bodypropCount++;
                }

                if (bodyrecordUrl != null)
                {
                    body["record_url"] = SourceExpressionConverter.ConvertToken(bodyrecordUrl);
                    bodypropCount++;
                }

                if (bodysyncId != null)
                {
                    body["sync_id"] = SourceExpressionConverter.ConvertToken(bodysyncId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PutcategoriesIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchcategoriesIdResponse> PatchcategoriesId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/categories/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PatchcategoriesIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetdepartmentsResponse> Getdepartments()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/departments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetdepartmentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PostdepartmentsResponse> Postdepartments([WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<int> bodyposition = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/departments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PostdepartmentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetdepartmentsIdResponse> GetdepartmentsId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/departments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetdepartmentsIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeletedepartmentsId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/departments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PutdepartmentsIdResponse> PutdepartmentsId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<int> bodyposition = null, [WorkflowExpression] Func<int> bodycompanyId = null, [WorkflowExpression] Func<int> bodyideasCount = null, [WorkflowExpression] Func<int> bodyprojectsCount = null, [WorkflowExpression] Func<string> bodyimage = null, [WorkflowExpression] Func<int> bodyuserId = null, [WorkflowExpression] Func<string> bodytempImage = null, [WorkflowExpression] Func<string> bodymainImage = null, [WorkflowExpression] Func<string> bodyimageConfigs = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodyupdatedBy = null, [WorkflowExpression] Func<string> bodyrecordUrl = null, [WorkflowExpression] Func<string> bodysyncId = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            SourceExpression.Validate(bodycompanyId, nameof(bodycompanyId), required: false);
            SourceExpression.Validate(bodyideasCount, nameof(bodyideasCount), required: false);
            SourceExpression.Validate(bodyprojectsCount, nameof(bodyprojectsCount), required: false);
            SourceExpression.Validate(bodyimage, nameof(bodyimage), required: false);
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            SourceExpression.Validate(bodytempImage, nameof(bodytempImage), required: false);
            SourceExpression.Validate(bodymainImage, nameof(bodymainImage), required: false);
            SourceExpression.Validate(bodyimageConfigs, nameof(bodyimageConfigs), required: false);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            SourceExpression.Validate(bodyupdatedBy, nameof(bodyupdatedBy), required: false);
            SourceExpression.Validate(bodyrecordUrl, nameof(bodyrecordUrl), required: false);
            SourceExpression.Validate(bodysyncId, nameof(bodysyncId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/departments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodycompanyId != null)
                {
                    body["company_id"] = SourceExpressionConverter.ConvertToken(bodycompanyId);
                    bodypropCount++;
                }

                if (bodyideasCount != null)
                {
                    body["ideas_count"] = SourceExpressionConverter.ConvertToken(bodyideasCount);
                    bodypropCount++;
                }

                if (bodyprojectsCount != null)
                {
                    body["projects_count"] = SourceExpressionConverter.ConvertToken(bodyprojectsCount);
                    bodypropCount++;
                }

                if (bodyimage != null)
                {
                    body["image"] = SourceExpressionConverter.ConvertToken(bodyimage);
                    bodypropCount++;
                }

                if (bodyuserId != null)
                {
                    body["user_id"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                if (bodytempImage != null)
                {
                    body["temp_image"] = SourceExpressionConverter.ConvertToken(bodytempImage);
                    bodypropCount++;
                }

                if (bodymainImage != null)
                {
                    body["main_image"] = SourceExpressionConverter.ConvertToken(bodymainImage);
                    bodypropCount++;
                }

                if (bodyimageConfigs != null)
                {
                    body["image_configs"] = SourceExpressionConverter.ConvertToken(bodyimageConfigs);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["owner_id"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                    bodypropCount++;
                }

                if (bodyupdatedBy != null)
                {
                    body["updated_by"] = SourceExpressionConverter.ConvertToken(bodyupdatedBy);
                    bodypropCount++;
                }

                if (bodyrecordUrl != null)
                {
                    body["record_url"] = SourceExpressionConverter.ConvertToken(bodyrecordUrl);
                    bodypropCount++;
                }

                if (bodysyncId != null)
                {
                    body["sync_id"] = SourceExpressionConverter.ConvertToken(bodysyncId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PutdepartmentsIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchdepartmentsIdResponse> PatchdepartmentsId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<int> bodyposition = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/departments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PatchdepartmentsIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetfunnelLanesResponse> GetfunnelLanes()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/funnel_lanes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetfunnelLanesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PostfunnelLanesResponse> PostfunnelLanes([WorkflowExpression] Func<string> bodytitle = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/funnel_lanes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PostfunnelLanesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetfunnelLanesIdResponse> GetfunnelLanesId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/funnel_lanes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetfunnelLanesIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeletefunnelLanesId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/funnel_lanes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PutfunnelLanesIdResponse> PutfunnelLanesId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<int> bodyfunnelStageType = null, [WorkflowExpression] Func<int> bodystageType = null, [WorkflowExpression] Func<string> bodycolor = null, [WorkflowExpression] Func<int> bodydeadline = null, [WorkflowExpression] Func<int> bodyposition = null, [WorkflowExpression] Func<string> bodyuserId = null, [WorkflowExpression] Func<string> bodymodifiedBy = null, [WorkflowExpression] Func<int> bodyfunnelId = null, [WorkflowExpression] Func<int> bodyfunnelStatusId = null, [WorkflowExpression] Func<int> bodyownerId = null, [WorkflowExpression] Func<bool> bodyenableNotification = null, [WorkflowExpression] Func<int> bodyideasCount = null, [WorkflowExpression] Func<int> bodyprojectsCount = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodylink = null, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<bool> bodyshowInGraph = null, [WorkflowExpression] Func<bool> bodyshowInBubble = null, [WorkflowExpression] Func<int> bodyconfettiType = null, [WorkflowExpression] Func<string> bodyautomationOwnerId = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodyfunnelStageType, nameof(bodyfunnelStageType), required: false);
            SourceExpression.Validate(bodystageType, nameof(bodystageType), required: false);
            SourceExpression.Validate(bodycolor, nameof(bodycolor), required: false);
            SourceExpression.Validate(bodydeadline, nameof(bodydeadline), required: false);
            SourceExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            SourceExpression.Validate(bodymodifiedBy, nameof(bodymodifiedBy), required: false);
            SourceExpression.Validate(bodyfunnelId, nameof(bodyfunnelId), required: false);
            SourceExpression.Validate(bodyfunnelStatusId, nameof(bodyfunnelStatusId), required: false);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            SourceExpression.Validate(bodyenableNotification, nameof(bodyenableNotification), required: false);
            SourceExpression.Validate(bodyideasCount, nameof(bodyideasCount), required: false);
            SourceExpression.Validate(bodyprojectsCount, nameof(bodyprojectsCount), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodylink, nameof(bodylink), required: false);
            SourceExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            SourceExpression.Validate(bodyshowInGraph, nameof(bodyshowInGraph), required: false);
            SourceExpression.Validate(bodyshowInBubble, nameof(bodyshowInBubble), required: false);
            SourceExpression.Validate(bodyconfettiType, nameof(bodyconfettiType), required: false);
            SourceExpression.Validate(bodyautomationOwnerId, nameof(bodyautomationOwnerId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/funnel_lanes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyfunnelStageType != null)
                {
                    body["funnel_stage_type"] = SourceExpressionConverter.ConvertToken(bodyfunnelStageType);
                    bodypropCount++;
                }

                if (bodystageType != null)
                {
                    body["stage_type"] = SourceExpressionConverter.ConvertToken(bodystageType);
                    bodypropCount++;
                }

                if (bodycolor != null)
                {
                    body["color"] = SourceExpressionConverter.ConvertToken(bodycolor);
                    bodypropCount++;
                }

                if (bodydeadline != null)
                {
                    body["deadline"] = SourceExpressionConverter.ConvertToken(bodydeadline);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodyuserId != null)
                {
                    body["user_id"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                if (bodymodifiedBy != null)
                {
                    body["modified_by"] = SourceExpressionConverter.ConvertToken(bodymodifiedBy);
                    bodypropCount++;
                }

                if (bodyfunnelId != null)
                {
                    body["funnel_id"] = SourceExpressionConverter.ConvertToken(bodyfunnelId);
                    bodypropCount++;
                }

                if (bodyfunnelStatusId != null)
                {
                    body["funnel_status_id"] = SourceExpressionConverter.ConvertToken(bodyfunnelStatusId);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["owner_id"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                    bodypropCount++;
                }

                if (bodyenableNotification != null)
                {
                    body["enable_notification"] = SourceExpressionConverter.ConvertToken(bodyenableNotification);
                    bodypropCount++;
                }

                if (bodyideasCount != null)
                {
                    body["ideas_count"] = SourceExpressionConverter.ConvertToken(bodyideasCount);
                    bodypropCount++;
                }

                if (bodyprojectsCount != null)
                {
                    body["projects_count"] = SourceExpressionConverter.ConvertToken(bodyprojectsCount);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodylink != null)
                {
                    body["link"] = SourceExpressionConverter.ConvertToken(bodylink);
                    bodypropCount++;
                }

                if (bodyfile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyfile);
                    bodypropCount++;
                }

                if (bodyshowInGraph != null)
                {
                    body["show_in_graph"] = SourceExpressionConverter.ConvertToken(bodyshowInGraph);
                    bodypropCount++;
                }

                if (bodyshowInBubble != null)
                {
                    body["show_in_bubble"] = SourceExpressionConverter.ConvertToken(bodyshowInBubble);
                    bodypropCount++;
                }

                if (bodyconfettiType != null)
                {
                    body["confetti_type"] = SourceExpressionConverter.ConvertToken(bodyconfettiType);
                    bodypropCount++;
                }

                if (bodyautomationOwnerId != null)
                {
                    body["automation_owner_id"] = SourceExpressionConverter.ConvertToken(bodyautomationOwnerId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PutfunnelLanesIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchfunnelLanesIdResponse> PatchfunnelLanesId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/funnel_lanes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PatchfunnelLanesIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetfunnelsResponse> Getfunnels()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/funnels";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetfunnelsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction Postfunnels([WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<int> bodyfunnelType = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodyfunnelType, nameof(bodyfunnelType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/funnels";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyfunnelType != null)
                {
                    body["funnel_type"] = SourceExpressionConverter.ConvertToken(bodyfunnelType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetfunnelsIdResponse> GetfunnelsId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/funnels/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetfunnelsIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeletefunnelsId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/funnels/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction PutfunnelsId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<int> bodycompanyId = null, [WorkflowExpression] Func<int> bodyuserId = null, [WorkflowExpression] Func<int> bodyfunnelType = null, [WorkflowExpression] Func<int> bodymodifiedBy = null, [WorkflowExpression] Func<int> bodyprivacySetting = null, [WorkflowExpression] Func<int> bodyownerId = null, [WorkflowExpression] Func<bool> bodyblockFunnelNotification = null, [WorkflowExpression] Func<int> bodyideasCount = null, [WorkflowExpression] Func<int> bodyprojectsCount = null, [WorkflowExpression] Func<bool> bodyhidden = null, [WorkflowExpression] Func<string> bodysetXAxis = null, [WorkflowExpression] Func<string> bodysetYAxis = null, [WorkflowExpression] Func<string> bodysetZAxis = null, [WorkflowExpression] Func<string> bodysetAxisColor = null, [WorkflowExpression] Func<string> bodydepartmentId = null, [WorkflowExpression] Func<int> bodyprojectFunnelId = null, [WorkflowExpression] Func<string> bodyfromScript = null, [WorkflowExpression] Func<int> bodyuserPrivacySetting = null, [WorkflowExpression] Func<bool> bodyincludeInDashboard = null, [WorkflowExpression] Func<string> bodyrecordUrl = null, [WorkflowExpression] Func<string> bodysyncId = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodycompanyId, nameof(bodycompanyId), required: false);
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            SourceExpression.Validate(bodyfunnelType, nameof(bodyfunnelType), required: false);
            SourceExpression.Validate(bodymodifiedBy, nameof(bodymodifiedBy), required: false);
            SourceExpression.Validate(bodyprivacySetting, nameof(bodyprivacySetting), required: false);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            SourceExpression.Validate(bodyblockFunnelNotification, nameof(bodyblockFunnelNotification), required: false);
            SourceExpression.Validate(bodyideasCount, nameof(bodyideasCount), required: false);
            SourceExpression.Validate(bodyprojectsCount, nameof(bodyprojectsCount), required: false);
            SourceExpression.Validate(bodyhidden, nameof(bodyhidden), required: false);
            SourceExpression.Validate(bodysetXAxis, nameof(bodysetXAxis), required: false);
            SourceExpression.Validate(bodysetYAxis, nameof(bodysetYAxis), required: false);
            SourceExpression.Validate(bodysetZAxis, nameof(bodysetZAxis), required: false);
            SourceExpression.Validate(bodysetAxisColor, nameof(bodysetAxisColor), required: false);
            SourceExpression.Validate(bodydepartmentId, nameof(bodydepartmentId), required: false);
            SourceExpression.Validate(bodyprojectFunnelId, nameof(bodyprojectFunnelId), required: false);
            SourceExpression.Validate(bodyfromScript, nameof(bodyfromScript), required: false);
            SourceExpression.Validate(bodyuserPrivacySetting, nameof(bodyuserPrivacySetting), required: false);
            SourceExpression.Validate(bodyincludeInDashboard, nameof(bodyincludeInDashboard), required: false);
            SourceExpression.Validate(bodyrecordUrl, nameof(bodyrecordUrl), required: false);
            SourceExpression.Validate(bodysyncId, nameof(bodysyncId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/funnels/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodycompanyId != null)
                {
                    body["company_id"] = SourceExpressionConverter.ConvertToken(bodycompanyId);
                    bodypropCount++;
                }

                if (bodyuserId != null)
                {
                    body["user_id"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                if (bodyfunnelType != null)
                {
                    body["funnel_type"] = SourceExpressionConverter.ConvertToken(bodyfunnelType);
                    bodypropCount++;
                }

                if (bodymodifiedBy != null)
                {
                    body["modified_by"] = SourceExpressionConverter.ConvertToken(bodymodifiedBy);
                    bodypropCount++;
                }

                if (bodyprivacySetting != null)
                {
                    body["privacy_setting"] = SourceExpressionConverter.ConvertToken(bodyprivacySetting);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["owner_id"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                    bodypropCount++;
                }

                if (bodyblockFunnelNotification != null)
                {
                    body["block_funnel_notification"] = SourceExpressionConverter.ConvertToken(bodyblockFunnelNotification);
                    bodypropCount++;
                }

                if (bodyideasCount != null)
                {
                    body["ideas_count"] = SourceExpressionConverter.ConvertToken(bodyideasCount);
                    bodypropCount++;
                }

                if (bodyprojectsCount != null)
                {
                    body["projects_count"] = SourceExpressionConverter.ConvertToken(bodyprojectsCount);
                    bodypropCount++;
                }

                if (bodyhidden != null)
                {
                    body["hidden"] = SourceExpressionConverter.ConvertToken(bodyhidden);
                    bodypropCount++;
                }

                if (bodysetXAxis != null)
                {
                    body["set_x_axis"] = SourceExpressionConverter.ConvertToken(bodysetXAxis);
                    bodypropCount++;
                }

                if (bodysetYAxis != null)
                {
                    body["set_y_axis"] = SourceExpressionConverter.ConvertToken(bodysetYAxis);
                    bodypropCount++;
                }

                if (bodysetZAxis != null)
                {
                    body["set_z_axis"] = SourceExpressionConverter.ConvertToken(bodysetZAxis);
                    bodypropCount++;
                }

                if (bodysetAxisColor != null)
                {
                    body["set_axis_color"] = SourceExpressionConverter.ConvertToken(bodysetAxisColor);
                    bodypropCount++;
                }

                if (bodydepartmentId != null)
                {
                    body["department_id"] = SourceExpressionConverter.ConvertToken(bodydepartmentId);
                    bodypropCount++;
                }

                if (bodyprojectFunnelId != null)
                {
                    body["project_funnel_id"] = SourceExpressionConverter.ConvertToken(bodyprojectFunnelId);
                    bodypropCount++;
                }

                if (bodyfromScript != null)
                {
                    body["from_script"] = SourceExpressionConverter.ConvertToken(bodyfromScript);
                    bodypropCount++;
                }

                if (bodyuserPrivacySetting != null)
                {
                    body["user_privacy_setting"] = SourceExpressionConverter.ConvertToken(bodyuserPrivacySetting);
                    bodypropCount++;
                }

                if (bodyincludeInDashboard != null)
                {
                    body["include_in_dashboard"] = SourceExpressionConverter.ConvertToken(bodyincludeInDashboard);
                    bodypropCount++;
                }

                if (bodyrecordUrl != null)
                {
                    body["record_url"] = SourceExpressionConverter.ConvertToken(bodyrecordUrl);
                    bodypropCount++;
                }

                if (bodysyncId != null)
                {
                    body["sync_id"] = SourceExpressionConverter.ConvertToken(bodysyncId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchfunnelsIdResponse> PatchfunnelsId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<int> bodyfunnelType = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodyfunnelType, nameof(bodyfunnelType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/funnels/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyfunnelType != null)
                {
                    body["funnel_type"] = SourceExpressionConverter.ConvertToken(bodyfunnelType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PatchfunnelsIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetideasResponse> Getideas()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/ideas";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetideasResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction Postideas([WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodycontent = null, [WorkflowExpression] Func<int> bodyfunnelId = null, [WorkflowExpression] Func<int> bodymissionId = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodycontent, nameof(bodycontent), required: false);
            SourceExpression.Validate(bodyfunnelId, nameof(bodyfunnelId), required: false);
            SourceExpression.Validate(bodymissionId, nameof(bodymissionId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/ideas";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodycontent != null)
                {
                    body["content"] = SourceExpressionConverter.ConvertToken(bodycontent);
                    bodypropCount++;
                }

                if (bodyfunnelId != null)
                {
                    body["funnel_id"] = SourceExpressionConverter.ConvertToken(bodyfunnelId);
                    bodypropCount++;
                }

                if (bodymissionId != null)
                {
                    body["mission_id"] = SourceExpressionConverter.ConvertToken(bodymissionId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetideasIdeaIdTasksResponse> GetideasIdeaIdTasks([WorkflowExpression] Func<string> ideaId)
        {
            SourceExpression.Validate(ideaId, nameof(ideaId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/ideas/{0}/tasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ideaId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetideasIdeaIdTasksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PostideasIdeaIdTasksResponse> PostideasIdeaIdTasks([WorkflowExpression] Func<string> ideaId, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<int> bodystatus = null)
        {
            SourceExpression.Validate(ideaId, nameof(ideaId), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/ideas/{0}/tasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ideaId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PostideasIdeaIdTasksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction GetideasId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/ideas/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeleteideasId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/ideas/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction PutideasId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> bodyuserId = null, [WorkflowExpression] Func<int> bodyroundId = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodycontent = null, [WorkflowExpression] Func<string> bodyimage = null, [WorkflowExpression] Func<string> bodydevice = null, [WorkflowExpression] Func<string> bodybrowser = null, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodypostalCode = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodyscreenRes = null, [WorkflowExpression] Func<string> bodyuserIp = null, [WorkflowExpression] Func<int> bodycommentsCount = null, [WorkflowExpression] Func<int> bodyreviewScoresCount = null, [WorkflowExpression] Func<string> bodyslug = null, [WorkflowExpression] Func<int> bodystage = null, [WorkflowExpression] Func<string> bodydepartmentId = null, [WorkflowExpression] Func<string> bodystatusId = null, [WorkflowExpression] Func<string> bodyposition = null, [WorkflowExpression] Func<string> bodyprojectId = null, [WorkflowExpression] Func<string> bodyideaCreator = null, [WorkflowExpression] Func<string> bodyideationIdeaCategoryId = null, [WorkflowExpression] Func<string> bodyboardIdeaCategoryId = null, [WorkflowExpression] Func<int> bodycompanyId = null, [WorkflowExpression] Func<int> bodyideaLikesCount = null, [WorkflowExpression] Func<bool> bodybookmark = null, [WorkflowExpression] Func<int> bodyideaScoresCount = null, [WorkflowExpression] Func<int> bodylikesCount = null, [WorkflowExpression] Func<string> bodyboardId = null, [WorkflowExpression] Func<string> bodymissionId = null, [WorkflowExpression] Func<string> bodycreatorName = null, [WorkflowExpression] Func<int> bodytagsCount = null, [WorkflowExpression] Func<string> bodyfunnelId = null, [WorkflowExpression] Func<string> bodyfunnelStageId = null, [WorkflowExpression] Func<string> bodyfunnelStatusId = null, [WorkflowExpression] Func<string> bodyideaDeadline = null, [WorkflowExpression] Func<bool> bodydeadlineNotification = null, [WorkflowExpression] Func<int> bodyideaViews = null, [WorkflowExpression] Func<string> bodyrevenue = null, [WorkflowExpression] Func<string> bodycost = null, [WorkflowExpression] Func<string> bodyprofit = null, [WorkflowExpression] Func<string> bodystatusName = null, [WorkflowExpression] Func<string> bodyideaScores = null, [WorkflowExpression] Func<string> bodyapprovedAt = null, [WorkflowExpression] Func<string> bodydeniedAt = null, [WorkflowExpression] Func<string> bodyadminComments = null, [WorkflowExpression] Func<bool> bodyisChild = null, [WorkflowExpression] Func<string> bodyparentId = null, [WorkflowExpression] Func<string> bodytempImage = null, [WorkflowExpression] Func<string> bodymainImage = null, [WorkflowExpression] Func<string> bodyimageConfigs = null, [WorkflowExpression] Func<int> bodyscoreCompleteScore = null, [WorkflowExpression] Func<int> bodyenrichmentScore = null, [WorkflowExpression] Func<int> bodyengagementScore = null, [WorkflowExpression] Func<int> bodyopportunityScore = null, [WorkflowExpression] Func<int> bodytrendScore = null, [WorkflowExpression] Func<string> bodycleanedText = null, [WorkflowExpression] Func<int> bodyduplicateIdeasCount = null, [WorkflowExpression] Func<string> bodysidekiqDuplicateIdeasCount = null, [WorkflowExpression] Func<string> bodyaiCreated = null, [WorkflowExpression] Func<string> bodyideaType = null, [WorkflowExpression] Func<string> bodyfromScript = null, [WorkflowExpression] Func<string> bodyembedding = null, [WorkflowExpression] Func<string> bodyreasonText = null, [WorkflowExpression] Func<string> bodycategoryText = null, [WorkflowExpression] Func<string> bodycanvassId = null, [WorkflowExpression] Func<string> bodybudgetTotal = null, [WorkflowExpression] Func<string> bodybudgetSpend = null, [WorkflowExpression] Func<string> bodybudgetResult = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodytagText = null, [WorkflowExpression] Func<string> bodyinnovationTypeId = null, [WorkflowExpression] Func<string> bodyinnovationTypeText = null, [WorkflowExpression] Func<string> bodysyncId = null, [WorkflowExpression] Func<string> bodyrecordUrl = null, [WorkflowExpression] Func<string> bodydescriptionEnriched = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            SourceExpression.Validate(bodyroundId, nameof(bodyroundId), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodycontent, nameof(bodycontent), required: false);
            SourceExpression.Validate(bodyimage, nameof(bodyimage), required: false);
            SourceExpression.Validate(bodydevice, nameof(bodydevice), required: false);
            SourceExpression.Validate(bodybrowser, nameof(bodybrowser), required: false);
            SourceExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: false);
            SourceExpression.Validate(bodypostalCode, nameof(bodypostalCode), required: false);
            SourceExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            SourceExpression.Validate(bodyscreenRes, nameof(bodyscreenRes), required: false);
            SourceExpression.Validate(bodyuserIp, nameof(bodyuserIp), required: false);
            SourceExpression.Validate(bodycommentsCount, nameof(bodycommentsCount), required: false);
            SourceExpression.Validate(bodyreviewScoresCount, nameof(bodyreviewScoresCount), required: false);
            SourceExpression.Validate(bodyslug, nameof(bodyslug), required: false);
            SourceExpression.Validate(bodystage, nameof(bodystage), required: false);
            SourceExpression.Validate(bodydepartmentId, nameof(bodydepartmentId), required: false);
            SourceExpression.Validate(bodystatusId, nameof(bodystatusId), required: false);
            SourceExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            SourceExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: false);
            SourceExpression.Validate(bodyideaCreator, nameof(bodyideaCreator), required: false);
            SourceExpression.Validate(bodyideationIdeaCategoryId, nameof(bodyideationIdeaCategoryId), required: false);
            SourceExpression.Validate(bodyboardIdeaCategoryId, nameof(bodyboardIdeaCategoryId), required: false);
            SourceExpression.Validate(bodycompanyId, nameof(bodycompanyId), required: false);
            SourceExpression.Validate(bodyideaLikesCount, nameof(bodyideaLikesCount), required: false);
            SourceExpression.Validate(bodybookmark, nameof(bodybookmark), required: false);
            SourceExpression.Validate(bodyideaScoresCount, nameof(bodyideaScoresCount), required: false);
            SourceExpression.Validate(bodylikesCount, nameof(bodylikesCount), required: false);
            SourceExpression.Validate(bodyboardId, nameof(bodyboardId), required: false);
            SourceExpression.Validate(bodymissionId, nameof(bodymissionId), required: false);
            SourceExpression.Validate(bodycreatorName, nameof(bodycreatorName), required: false);
            SourceExpression.Validate(bodytagsCount, nameof(bodytagsCount), required: false);
            SourceExpression.Validate(bodyfunnelId, nameof(bodyfunnelId), required: false);
            SourceExpression.Validate(bodyfunnelStageId, nameof(bodyfunnelStageId), required: false);
            SourceExpression.Validate(bodyfunnelStatusId, nameof(bodyfunnelStatusId), required: false);
            SourceExpression.Validate(bodyideaDeadline, nameof(bodyideaDeadline), required: false);
            SourceExpression.Validate(bodydeadlineNotification, nameof(bodydeadlineNotification), required: false);
            SourceExpression.Validate(bodyideaViews, nameof(bodyideaViews), required: false);
            SourceExpression.Validate(bodyrevenue, nameof(bodyrevenue), required: false);
            SourceExpression.Validate(bodycost, nameof(bodycost), required: false);
            SourceExpression.Validate(bodyprofit, nameof(bodyprofit), required: false);
            SourceExpression.Validate(bodystatusName, nameof(bodystatusName), required: false);
            SourceExpression.Validate(bodyideaScores, nameof(bodyideaScores), required: false);
            SourceExpression.Validate(bodyapprovedAt, nameof(bodyapprovedAt), required: false);
            SourceExpression.Validate(bodydeniedAt, nameof(bodydeniedAt), required: false);
            SourceExpression.Validate(bodyadminComments, nameof(bodyadminComments), required: false);
            SourceExpression.Validate(bodyisChild, nameof(bodyisChild), required: false);
            SourceExpression.Validate(bodyparentId, nameof(bodyparentId), required: false);
            SourceExpression.Validate(bodytempImage, nameof(bodytempImage), required: false);
            SourceExpression.Validate(bodymainImage, nameof(bodymainImage), required: false);
            SourceExpression.Validate(bodyimageConfigs, nameof(bodyimageConfigs), required: false);
            SourceExpression.Validate(bodyscoreCompleteScore, nameof(bodyscoreCompleteScore), required: false);
            SourceExpression.Validate(bodyenrichmentScore, nameof(bodyenrichmentScore), required: false);
            SourceExpression.Validate(bodyengagementScore, nameof(bodyengagementScore), required: false);
            SourceExpression.Validate(bodyopportunityScore, nameof(bodyopportunityScore), required: false);
            SourceExpression.Validate(bodytrendScore, nameof(bodytrendScore), required: false);
            SourceExpression.Validate(bodycleanedText, nameof(bodycleanedText), required: false);
            SourceExpression.Validate(bodyduplicateIdeasCount, nameof(bodyduplicateIdeasCount), required: false);
            SourceExpression.Validate(bodysidekiqDuplicateIdeasCount, nameof(bodysidekiqDuplicateIdeasCount), required: false);
            SourceExpression.Validate(bodyaiCreated, nameof(bodyaiCreated), required: false);
            SourceExpression.Validate(bodyideaType, nameof(bodyideaType), required: false);
            SourceExpression.Validate(bodyfromScript, nameof(bodyfromScript), required: false);
            SourceExpression.Validate(bodyembedding, nameof(bodyembedding), required: false);
            SourceExpression.Validate(bodyreasonText, nameof(bodyreasonText), required: false);
            SourceExpression.Validate(bodycategoryText, nameof(bodycategoryText), required: false);
            SourceExpression.Validate(bodycanvassId, nameof(bodycanvassId), required: false);
            SourceExpression.Validate(bodybudgetTotal, nameof(bodybudgetTotal), required: false);
            SourceExpression.Validate(bodybudgetSpend, nameof(bodybudgetSpend), required: false);
            SourceExpression.Validate(bodybudgetResult, nameof(bodybudgetResult), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodytagText, nameof(bodytagText), required: false);
            SourceExpression.Validate(bodyinnovationTypeId, nameof(bodyinnovationTypeId), required: false);
            SourceExpression.Validate(bodyinnovationTypeText, nameof(bodyinnovationTypeText), required: false);
            SourceExpression.Validate(bodysyncId, nameof(bodysyncId), required: false);
            SourceExpression.Validate(bodyrecordUrl, nameof(bodyrecordUrl), required: false);
            SourceExpression.Validate(bodydescriptionEnriched, nameof(bodydescriptionEnriched), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/ideas/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["user_id"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                if (bodyroundId != null)
                {
                    body["round_id"] = SourceExpressionConverter.ConvertToken(bodyroundId);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodycontent != null)
                {
                    body["content"] = SourceExpressionConverter.ConvertToken(bodycontent);
                    bodypropCount++;
                }

                if (bodyimage != null)
                {
                    body["image"] = SourceExpressionConverter.ConvertToken(bodyimage);
                    bodypropCount++;
                }

                if (bodydevice != null)
                {
                    body["device"] = SourceExpressionConverter.ConvertToken(bodydevice);
                    bodypropCount++;
                }

                if (bodybrowser != null)
                {
                    body["browser"] = SourceExpressionConverter.ConvertToken(bodybrowser);
                    bodypropCount++;
                }

                if (bodyaddress != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodypostalCode != null)
                {
                    body["postal_code"] = SourceExpressionConverter.ConvertToken(bodypostalCode);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                if (bodyscreenRes != null)
                {
                    body["screen_res"] = SourceExpressionConverter.ConvertToken(bodyscreenRes);
                    bodypropCount++;
                }

                if (bodyuserIp != null)
                {
                    body["user_ip"] = SourceExpressionConverter.ConvertToken(bodyuserIp);
                    bodypropCount++;
                }

                if (bodycommentsCount != null)
                {
                    body["comments_count"] = SourceExpressionConverter.ConvertToken(bodycommentsCount);
                    bodypropCount++;
                }

                if (bodyreviewScoresCount != null)
                {
                    body["review_scores_count"] = SourceExpressionConverter.ConvertToken(bodyreviewScoresCount);
                    bodypropCount++;
                }

                if (bodyslug != null)
                {
                    body["slug"] = SourceExpressionConverter.ConvertToken(bodyslug);
                    bodypropCount++;
                }

                if (bodystage != null)
                {
                    body["stage"] = SourceExpressionConverter.ConvertToken(bodystage);
                    bodypropCount++;
                }

                if (bodydepartmentId != null)
                {
                    body["department_id"] = SourceExpressionConverter.ConvertToken(bodydepartmentId);
                    bodypropCount++;
                }

                if (bodystatusId != null)
                {
                    body["status_id"] = SourceExpressionConverter.ConvertToken(bodystatusId);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodyprojectId != null)
                {
                    body["project_id"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                    bodypropCount++;
                }

                if (bodyideaCreator != null)
                {
                    body["idea_creator"] = SourceExpressionConverter.ConvertToken(bodyideaCreator);
                    bodypropCount++;
                }

                if (bodyideationIdeaCategoryId != null)
                {
                    body["ideation_idea_category_id"] = SourceExpressionConverter.ConvertToken(bodyideationIdeaCategoryId);
                    bodypropCount++;
                }

                if (bodyboardIdeaCategoryId != null)
                {
                    body["board_idea_category_id"] = SourceExpressionConverter.ConvertToken(bodyboardIdeaCategoryId);
                    bodypropCount++;
                }

                if (bodycompanyId != null)
                {
                    body["company_id"] = SourceExpressionConverter.ConvertToken(bodycompanyId);
                    bodypropCount++;
                }

                if (bodyideaLikesCount != null)
                {
                    body["idea_likes_count"] = SourceExpressionConverter.ConvertToken(bodyideaLikesCount);
                    bodypropCount++;
                }

                if (bodybookmark != null)
                {
                    body["bookmark"] = SourceExpressionConverter.ConvertToken(bodybookmark);
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
                    body["idea_scores_count"] = SourceExpressionConverter.ConvertToken(bodyideaScoresCount);
                    bodypropCount++;
                }

                if (bodylikesCount != null)
                {
                    body["likes_count"] = SourceExpressionConverter.ConvertToken(bodylikesCount);
                    bodypropCount++;
                }

                if (bodyboardId != null)
                {
                    body["board_id"] = SourceExpressionConverter.ConvertToken(bodyboardId);
                    bodypropCount++;
                }

                if (bodymissionId != null)
                {
                    body["mission_id"] = SourceExpressionConverter.ConvertToken(bodymissionId);
                    bodypropCount++;
                }

                if (bodycreatorName != null)
                {
                    body["creator_name"] = SourceExpressionConverter.ConvertToken(bodycreatorName);
                    bodypropCount++;
                }

                if (bodytagsCount != null)
                {
                    body["tags_count"] = SourceExpressionConverter.ConvertToken(bodytagsCount);
                    bodypropCount++;
                }

                if (bodyfunnelId != null)
                {
                    body["funnel_id"] = SourceExpressionConverter.ConvertToken(bodyfunnelId);
                    bodypropCount++;
                }

                if (bodyfunnelStageId != null)
                {
                    body["funnel_stage_id"] = SourceExpressionConverter.ConvertToken(bodyfunnelStageId);
                    bodypropCount++;
                }

                if (bodyfunnelStatusId != null)
                {
                    body["funnel_status_id"] = SourceExpressionConverter.ConvertToken(bodyfunnelStatusId);
                    bodypropCount++;
                }

                if (bodyideaDeadline != null)
                {
                    body["idea_deadline"] = SourceExpressionConverter.ConvertToken(bodyideaDeadline);
                    bodypropCount++;
                }

                if (bodydeadlineNotification != null)
                {
                    body["deadline_notification"] = SourceExpressionConverter.ConvertToken(bodydeadlineNotification);
                    bodypropCount++;
                }

                if (bodyideaViews != null)
                {
                    body["idea_views"] = SourceExpressionConverter.ConvertToken(bodyideaViews);
                    bodypropCount++;
                }

                if (bodyrevenue != null)
                {
                    body["revenue"] = SourceExpressionConverter.ConvertToken(bodyrevenue);
                    bodypropCount++;
                }

                if (bodycost != null)
                {
                    body["cost"] = SourceExpressionConverter.ConvertToken(bodycost);
                    bodypropCount++;
                }

                if (bodyprofit != null)
                {
                    body["profit"] = SourceExpressionConverter.ConvertToken(bodyprofit);
                    bodypropCount++;
                }

                if (bodystatusName != null)
                {
                    body["status_name"] = SourceExpressionConverter.ConvertToken(bodystatusName);
                    bodypropCount++;
                }

                if (bodyideaScores != null)
                {
                    body["idea_scores"] = SourceExpressionConverter.ConvertToken(bodyideaScores);
                    bodypropCount++;
                }

                if (bodyapprovedAt != null)
                {
                    body["approved_at"] = SourceExpressionConverter.ConvertToken(bodyapprovedAt);
                    bodypropCount++;
                }

                if (bodydeniedAt != null)
                {
                    body["denied_at"] = SourceExpressionConverter.ConvertToken(bodydeniedAt);
                    bodypropCount++;
                }

                if (bodyadminComments != null)
                {
                    body["admin_comments"] = SourceExpressionConverter.ConvertToken(bodyadminComments);
                    bodypropCount++;
                }

                if (bodyisChild != null)
                {
                    body["is_child"] = SourceExpressionConverter.ConvertToken(bodyisChild);
                    bodypropCount++;
                }

                if (bodyparentId != null)
                {
                    body["parent_id"] = SourceExpressionConverter.ConvertToken(bodyparentId);
                    bodypropCount++;
                }

                if (bodytempImage != null)
                {
                    body["temp_image"] = SourceExpressionConverter.ConvertToken(bodytempImage);
                    bodypropCount++;
                }

                if (bodymainImage != null)
                {
                    body["main_image"] = SourceExpressionConverter.ConvertToken(bodymainImage);
                    bodypropCount++;
                }

                if (bodyimageConfigs != null)
                {
                    body["image_configs"] = SourceExpressionConverter.ConvertToken(bodyimageConfigs);
                    bodypropCount++;
                }

                if (bodyscoreCompleteScore != null)
                {
                    body["score_complete_score"] = SourceExpressionConverter.ConvertToken(bodyscoreCompleteScore);
                    bodypropCount++;
                }

                if (bodyenrichmentScore != null)
                {
                    body["enrichment_score"] = SourceExpressionConverter.ConvertToken(bodyenrichmentScore);
                    bodypropCount++;
                }

                if (bodyengagementScore != null)
                {
                    body["engagement_score"] = SourceExpressionConverter.ConvertToken(bodyengagementScore);
                    bodypropCount++;
                }

                if (bodyopportunityScore != null)
                {
                    body["opportunity_score"] = SourceExpressionConverter.ConvertToken(bodyopportunityScore);
                    bodypropCount++;
                }

                if (bodytrendScore != null)
                {
                    body["trend_score"] = SourceExpressionConverter.ConvertToken(bodytrendScore);
                    bodypropCount++;
                }

                if (bodycleanedText != null)
                {
                    body["cleaned_text"] = SourceExpressionConverter.ConvertToken(bodycleanedText);
                    bodypropCount++;
                }

                if (bodyduplicateIdeasCount != null)
                {
                    body["duplicate_ideas_count"] = SourceExpressionConverter.ConvertToken(bodyduplicateIdeasCount);
                    bodypropCount++;
                }

                if (bodysidekiqDuplicateIdeasCount != null)
                {
                    body["sidekiq_duplicate_ideas_count"] = SourceExpressionConverter.ConvertToken(bodysidekiqDuplicateIdeasCount);
                    bodypropCount++;
                }

                if (bodyaiCreated != null)
                {
                    body["ai_created"] = SourceExpressionConverter.ConvertToken(bodyaiCreated);
                    bodypropCount++;
                }

                if (bodyideaType != null)
                {
                    body["idea_type"] = SourceExpressionConverter.ConvertToken(bodyideaType);
                    bodypropCount++;
                }

                if (bodyfromScript != null)
                {
                    body["from_script"] = SourceExpressionConverter.ConvertToken(bodyfromScript);
                    bodypropCount++;
                }

                if (bodyembedding != null)
                {
                    body["embedding"] = SourceExpressionConverter.ConvertToken(bodyembedding);
                    bodypropCount++;
                }

                if (bodyreasonText != null)
                {
                    body["reason_text"] = SourceExpressionConverter.ConvertToken(bodyreasonText);
                    bodypropCount++;
                }

                if (bodycategoryText != null)
                {
                    body["category_text"] = SourceExpressionConverter.ConvertToken(bodycategoryText);
                    bodypropCount++;
                }

                if (bodycanvassId != null)
                {
                    body["canvass_id"] = SourceExpressionConverter.ConvertToken(bodycanvassId);
                    bodypropCount++;
                }

                if (bodybudgetTotal != null)
                {
                    body["budget_total"] = SourceExpressionConverter.ConvertToken(bodybudgetTotal);
                    bodypropCount++;
                }

                if (bodybudgetSpend != null)
                {
                    body["budget_spend"] = SourceExpressionConverter.ConvertToken(bodybudgetSpend);
                    bodypropCount++;
                }

                if (bodybudgetResult != null)
                {
                    body["budget_result"] = SourceExpressionConverter.ConvertToken(bodybudgetResult);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodytagText != null)
                {
                    body["tag_text"] = SourceExpressionConverter.ConvertToken(bodytagText);
                    bodypropCount++;
                }

                if (bodyinnovationTypeId != null)
                {
                    body["innovation_type_id"] = SourceExpressionConverter.ConvertToken(bodyinnovationTypeId);
                    bodypropCount++;
                }

                if (bodyinnovationTypeText != null)
                {
                    body["innovation_type_text"] = SourceExpressionConverter.ConvertToken(bodyinnovationTypeText);
                    bodypropCount++;
                }

                if (bodysyncId != null)
                {
                    body["sync_id"] = SourceExpressionConverter.ConvertToken(bodysyncId);
                    bodypropCount++;
                }

                if (bodyrecordUrl != null)
                {
                    body["record_url"] = SourceExpressionConverter.ConvertToken(bodyrecordUrl);
                    bodypropCount++;
                }

                if (bodydescriptionEnriched != null)
                {
                    body["description_enriched"] = SourceExpressionConverter.ConvertToken(bodydescriptionEnriched);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction PatchideasId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodycontent = null, [WorkflowExpression] Func<int> bodyfunnelId = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodycontent, nameof(bodycontent), required: false);
            SourceExpression.Validate(bodyfunnelId, nameof(bodyfunnelId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/ideas/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodycontent != null)
                {
                    body["content"] = SourceExpressionConverter.ConvertToken(bodycontent);
                    bodypropCount++;
                }

                if (bodyfunnelId != null)
                {
                    body["funnel_id"] = SourceExpressionConverter.ConvertToken(bodyfunnelId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetmissionsResponse> Getmissions()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/missions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetmissionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction Postmissions([WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<bool> bodyhidden = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            SourceExpression.Validate(bodyhidden, nameof(bodyhidden), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/missions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["end_date"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodyhidden != null)
                {
                    body["hidden"] = SourceExpressionConverter.ConvertToken(bodyhidden);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetmissionsIdResponse> GetmissionsId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/missions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetmissionsIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeletemissionsId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/missions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PutmissionsIdResponse> PutmissionsId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> bodyuserId = null, [WorkflowExpression] Func<int> bodycompanyId = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bool> bodyisAnonymous = null, [WorkflowExpression] Func<string> bodyendingNote = null, [WorkflowExpression] Func<string> bodymissionPic = null, [WorkflowExpression] Func<int> bodyteamSize = null, [WorkflowExpression] Func<int> bodystatus = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodyslug = null, [WorkflowExpression] Func<string> bodyfromName = null, [WorkflowExpression] Func<bool> bodyisTemplate = null, [WorkflowExpression] Func<int> bodyendDuration = null, [WorkflowExpression] Func<string> bodytoken = null, [WorkflowExpression] Func<bool> bodyisTryout = null, [WorkflowExpression] Func<int> bodytemplateType = null, [WorkflowExpression] Func<bool> bodyisOpen = null, [WorkflowExpression] Func<int> bodymissionType = null, [WorkflowExpression] Func<string> bodypublishedOnce = null, [WorkflowExpression] Func<string> bodyinboxQuestion = null, [WorkflowExpression] Func<string> bodyprivacySetting = null, [WorkflowExpression] Func<string> bodyagentProfile = null, [WorkflowExpression] Func<string> bodydepartmentId = null, [WorkflowExpression] Func<bool> bodyenableReport = null, [WorkflowExpression] Func<int> bodyideasCount = null, [WorkflowExpression] Func<int> bodylikesCount = null, [WorkflowExpression] Func<int> bodycommentsCount = null, [WorkflowExpression] Func<string> bodyfunnelId = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<bool> bodyenableInboundEmail = null, [WorkflowExpression] Func<string> bodydepartmentName = null, [WorkflowExpression] Func<string> bodynotificationType = null, [WorkflowExpression] Func<string> bodynotificationFrequency = null, [WorkflowExpression] Func<string> bodynotificationText = null, [WorkflowExpression] Func<int> bodyposition = null, [WorkflowExpression] Func<string> bodymissionViews = null, [WorkflowExpression] Func<string> bodytempImage = null, [WorkflowExpression] Func<string> bodymainImage = null, [WorkflowExpression] Func<string> bodyimageConfigs = null, [WorkflowExpression] Func<string> bodyallowAiIdeas = null, [WorkflowExpression] Func<string> bodyaiMissionType = null, [WorkflowExpression] Func<string> bodyfromScript = null, [WorkflowExpression] Func<string> bodyideaAttachmentsAllowed = null, [WorkflowExpression] Func<string> bodyvideoLink = null, [WorkflowExpression] Func<string> bodyhidden = null, [WorkflowExpression] Func<string> bodyconfettiType = null, [WorkflowExpression] Func<string> bodyenable = null, [WorkflowExpression] Func<string> bodyaddAttachment = null, [WorkflowExpression] Func<string> bodyaddComment = null, [WorkflowExpression] Func<string> bodyrecordUrl = null, [WorkflowExpression] Func<string> bodysyncId = null, [WorkflowExpression] Func<string> bodyideaCustomFields = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            SourceExpression.Validate(bodycompanyId, nameof(bodycompanyId), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyisAnonymous, nameof(bodyisAnonymous), required: false);
            SourceExpression.Validate(bodyendingNote, nameof(bodyendingNote), required: false);
            SourceExpression.Validate(bodymissionPic, nameof(bodymissionPic), required: false);
            SourceExpression.Validate(bodyteamSize, nameof(bodyteamSize), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            SourceExpression.Validate(bodyslug, nameof(bodyslug), required: false);
            SourceExpression.Validate(bodyfromName, nameof(bodyfromName), required: false);
            SourceExpression.Validate(bodyisTemplate, nameof(bodyisTemplate), required: false);
            SourceExpression.Validate(bodyendDuration, nameof(bodyendDuration), required: false);
            SourceExpression.Validate(bodytoken, nameof(bodytoken), required: false);
            SourceExpression.Validate(bodyisTryout, nameof(bodyisTryout), required: false);
            SourceExpression.Validate(bodytemplateType, nameof(bodytemplateType), required: false);
            SourceExpression.Validate(bodyisOpen, nameof(bodyisOpen), required: false);
            SourceExpression.Validate(bodymissionType, nameof(bodymissionType), required: false);
            SourceExpression.Validate(bodypublishedOnce, nameof(bodypublishedOnce), required: false);
            SourceExpression.Validate(bodyinboxQuestion, nameof(bodyinboxQuestion), required: false);
            SourceExpression.Validate(bodyprivacySetting, nameof(bodyprivacySetting), required: false);
            SourceExpression.Validate(bodyagentProfile, nameof(bodyagentProfile), required: false);
            SourceExpression.Validate(bodydepartmentId, nameof(bodydepartmentId), required: false);
            SourceExpression.Validate(bodyenableReport, nameof(bodyenableReport), required: false);
            SourceExpression.Validate(bodyideasCount, nameof(bodyideasCount), required: false);
            SourceExpression.Validate(bodylikesCount, nameof(bodylikesCount), required: false);
            SourceExpression.Validate(bodycommentsCount, nameof(bodycommentsCount), required: false);
            SourceExpression.Validate(bodyfunnelId, nameof(bodyfunnelId), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyenableInboundEmail, nameof(bodyenableInboundEmail), required: false);
            SourceExpression.Validate(bodydepartmentName, nameof(bodydepartmentName), required: false);
            SourceExpression.Validate(bodynotificationType, nameof(bodynotificationType), required: false);
            SourceExpression.Validate(bodynotificationFrequency, nameof(bodynotificationFrequency), required: false);
            SourceExpression.Validate(bodynotificationText, nameof(bodynotificationText), required: false);
            SourceExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            SourceExpression.Validate(bodymissionViews, nameof(bodymissionViews), required: false);
            SourceExpression.Validate(bodytempImage, nameof(bodytempImage), required: false);
            SourceExpression.Validate(bodymainImage, nameof(bodymainImage), required: false);
            SourceExpression.Validate(bodyimageConfigs, nameof(bodyimageConfigs), required: false);
            SourceExpression.Validate(bodyallowAiIdeas, nameof(bodyallowAiIdeas), required: false);
            SourceExpression.Validate(bodyaiMissionType, nameof(bodyaiMissionType), required: false);
            SourceExpression.Validate(bodyfromScript, nameof(bodyfromScript), required: false);
            SourceExpression.Validate(bodyideaAttachmentsAllowed, nameof(bodyideaAttachmentsAllowed), required: false);
            SourceExpression.Validate(bodyvideoLink, nameof(bodyvideoLink), required: false);
            SourceExpression.Validate(bodyhidden, nameof(bodyhidden), required: false);
            SourceExpression.Validate(bodyconfettiType, nameof(bodyconfettiType), required: false);
            SourceExpression.Validate(bodyenable, nameof(bodyenable), required: false);
            SourceExpression.Validate(bodyaddAttachment, nameof(bodyaddAttachment), required: false);
            SourceExpression.Validate(bodyaddComment, nameof(bodyaddComment), required: false);
            SourceExpression.Validate(bodyrecordUrl, nameof(bodyrecordUrl), required: false);
            SourceExpression.Validate(bodysyncId, nameof(bodysyncId), required: false);
            SourceExpression.Validate(bodyideaCustomFields, nameof(bodyideaCustomFields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/missions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["user_id"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                if (bodycompanyId != null)
                {
                    body["company_id"] = SourceExpressionConverter.ConvertToken(bodycompanyId);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyisAnonymous != null)
                {
                    body["is_anonymous"] = SourceExpressionConverter.ConvertToken(bodyisAnonymous);
                    bodypropCount++;
                }

                if (bodyendingNote != null)
                {
                    body["ending_note"] = SourceExpressionConverter.ConvertToken(bodyendingNote);
                    bodypropCount++;
                }

                if (bodymissionPic != null)
                {
                    body["mission_pic"] = SourceExpressionConverter.ConvertToken(bodymissionPic);
                    bodypropCount++;
                }

                if (bodyteamSize != null)
                {
                    body["team_size"] = SourceExpressionConverter.ConvertToken(bodyteamSize);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["end_date"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodyslug != null)
                {
                    body["slug"] = SourceExpressionConverter.ConvertToken(bodyslug);
                    bodypropCount++;
                }

                if (bodyfromName != null)
                {
                    body["from_name"] = SourceExpressionConverter.ConvertToken(bodyfromName);
                    bodypropCount++;
                }

                if (bodyisTemplate != null)
                {
                    body["is_template"] = SourceExpressionConverter.ConvertToken(bodyisTemplate);
                    bodypropCount++;
                }

                if (bodyendDuration != null)
                {
                    body["end_duration"] = SourceExpressionConverter.ConvertToken(bodyendDuration);
                    bodypropCount++;
                }

                if (bodytoken != null)
                {
                    body["token"] = SourceExpressionConverter.ConvertToken(bodytoken);
                    bodypropCount++;
                }

                if (bodyisTryout != null)
                {
                    body["is_tryout"] = SourceExpressionConverter.ConvertToken(bodyisTryout);
                    bodypropCount++;
                }

                if (bodytemplateType != null)
                {
                    body["template_type"] = SourceExpressionConverter.ConvertToken(bodytemplateType);
                    bodypropCount++;
                }

                if (bodyisOpen != null)
                {
                    body["is_open"] = SourceExpressionConverter.ConvertToken(bodyisOpen);
                    bodypropCount++;
                }

                if (bodymissionType != null)
                {
                    body["mission_type"] = SourceExpressionConverter.ConvertToken(bodymissionType);
                    bodypropCount++;
                }

                if (bodypublishedOnce != null)
                {
                    body["published_once"] = SourceExpressionConverter.ConvertToken(bodypublishedOnce);
                    bodypropCount++;
                }

                if (bodyinboxQuestion != null)
                {
                    body["inbox_question"] = SourceExpressionConverter.ConvertToken(bodyinboxQuestion);
                    bodypropCount++;
                }

                if (bodyprivacySetting != null)
                {
                    body["privacy_setting"] = SourceExpressionConverter.ConvertToken(bodyprivacySetting);
                    bodypropCount++;
                }

                if (bodyagentProfile != null)
                {
                    body["agent_profile"] = SourceExpressionConverter.ConvertToken(bodyagentProfile);
                    bodypropCount++;
                }

                if (bodydepartmentId != null)
                {
                    body["department_id"] = SourceExpressionConverter.ConvertToken(bodydepartmentId);
                    bodypropCount++;
                }

                if (bodyenableReport != null)
                {
                    body["enable_report"] = SourceExpressionConverter.ConvertToken(bodyenableReport);
                    bodypropCount++;
                }

                if (bodyideasCount != null)
                {
                    body["ideas_count"] = SourceExpressionConverter.ConvertToken(bodyideasCount);
                    bodypropCount++;
                }

                if (bodylikesCount != null)
                {
                    body["likes_count"] = SourceExpressionConverter.ConvertToken(bodylikesCount);
                    bodypropCount++;
                }

                if (bodycommentsCount != null)
                {
                    body["comments_count"] = SourceExpressionConverter.ConvertToken(bodycommentsCount);
                    bodypropCount++;
                }

                if (bodyfunnelId != null)
                {
                    body["funnel_id"] = SourceExpressionConverter.ConvertToken(bodyfunnelId);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyenableInboundEmail != null)
                {
                    body["enable_inbound_email"] = SourceExpressionConverter.ConvertToken(bodyenableInboundEmail);
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
                    body["department_name"] = SourceExpressionConverter.ConvertToken(bodydepartmentName);
                    bodypropCount++;
                }

                if (bodynotificationType != null)
                {
                    body["notification_type"] = SourceExpressionConverter.ConvertToken(bodynotificationType);
                    bodypropCount++;
                }

                if (bodynotificationFrequency != null)
                {
                    body["notification_frequency"] = SourceExpressionConverter.ConvertToken(bodynotificationFrequency);
                    bodypropCount++;
                }

                if (bodynotificationText != null)
                {
                    body["notification_text"] = SourceExpressionConverter.ConvertToken(bodynotificationText);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodymissionViews != null)
                {
                    body["mission_views"] = SourceExpressionConverter.ConvertToken(bodymissionViews);
                    bodypropCount++;
                }

                if (bodytempImage != null)
                {
                    body["temp_image"] = SourceExpressionConverter.ConvertToken(bodytempImage);
                    bodypropCount++;
                }

                if (bodymainImage != null)
                {
                    body["main_image"] = SourceExpressionConverter.ConvertToken(bodymainImage);
                    bodypropCount++;
                }

                if (bodyimageConfigs != null)
                {
                    body["image_configs"] = SourceExpressionConverter.ConvertToken(bodyimageConfigs);
                    bodypropCount++;
                }

                if (bodyallowAiIdeas != null)
                {
                    body["allow_ai_ideas"] = SourceExpressionConverter.ConvertToken(bodyallowAiIdeas);
                    bodypropCount++;
                }

                if (bodyaiMissionType != null)
                {
                    body["ai_mission_type"] = SourceExpressionConverter.ConvertToken(bodyaiMissionType);
                    bodypropCount++;
                }

                if (bodyfromScript != null)
                {
                    body["from_script"] = SourceExpressionConverter.ConvertToken(bodyfromScript);
                    bodypropCount++;
                }

                if (bodyideaAttachmentsAllowed != null)
                {
                    body["idea_attachments_allowed"] = SourceExpressionConverter.ConvertToken(bodyideaAttachmentsAllowed);
                    bodypropCount++;
                }

                if (bodyvideoLink != null)
                {
                    body["video_link"] = SourceExpressionConverter.ConvertToken(bodyvideoLink);
                    bodypropCount++;
                }

                if (bodyhidden != null)
                {
                    body["hidden"] = SourceExpressionConverter.ConvertToken(bodyhidden);
                    bodypropCount++;
                }

                if (bodyconfettiType != null)
                {
                    body["confetti_type"] = SourceExpressionConverter.ConvertToken(bodyconfettiType);
                    bodypropCount++;
                }

                if (bodyenable != null)
                {
                    body["enable"] = SourceExpressionConverter.ConvertToken(bodyenable);
                    bodypropCount++;
                }

                if (bodyaddAttachment != null)
                {
                    body["add_attachment"] = SourceExpressionConverter.ConvertToken(bodyaddAttachment);
                    bodypropCount++;
                }

                if (bodyaddComment != null)
                {
                    body["add_comment"] = SourceExpressionConverter.ConvertToken(bodyaddComment);
                    bodypropCount++;
                }

                if (bodyrecordUrl != null)
                {
                    body["record_url"] = SourceExpressionConverter.ConvertToken(bodyrecordUrl);
                    bodypropCount++;
                }

                if (bodysyncId != null)
                {
                    body["sync_id"] = SourceExpressionConverter.ConvertToken(bodysyncId);
                    bodypropCount++;
                }

                if (bodyideaCustomFields != null)
                {
                    body["idea_custom_fields"] = SourceExpressionConverter.ConvertToken(bodyideaCustomFields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PutmissionsIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchmissionsIdResponse> PatchmissionsId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bool> bodyhidden = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyhidden, nameof(bodyhidden), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/missions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyhidden != null)
                {
                    body["hidden"] = SourceExpressionConverter.ConvertToken(bodyhidden);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PatchmissionsIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetprojectsResponse> Getprojects()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetprojectsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PostprojectsResponse> Postprojects([WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodyfunnelId = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyfunnelId, nameof(bodyfunnelId), required: false);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/projects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyfunnelId != null)
                {
                    body["funnel_id"] = SourceExpressionConverter.ConvertToken(bodyfunnelId);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["end_date"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PostprojectsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetprojectsIdResponse> GetprojectsId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/projects/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetprojectsIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeleteprojectsId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/projects/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PutprojectsIdResponse> PutprojectsId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyimage = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null, [WorkflowExpression] Func<string> bodystatusId = null, [WorkflowExpression] Func<string> bodydepartmentId = null, [WorkflowExpression] Func<string> bodyuserId = null, [WorkflowExpression] Func<string> bodystageId = null, [WorkflowExpression] Func<string> bodyprojectManagerId = null, [WorkflowExpression] Func<string> bodybusinessOwnerId = null, [WorkflowExpression] Func<string> bodyprogress = null, [WorkflowExpression] Func<string> bodycompanyId = null, [WorkflowExpression] Func<string> bodycommentsCount = null, [WorkflowExpression] Func<string> bodyprojectScore = null, [WorkflowExpression] Func<string> bodyslug = null, [WorkflowExpression] Func<string> bodyposition = null, [WorkflowExpression] Func<int> bodymodifiedBy = null, [WorkflowExpression] Func<int> bodytagsCount = null, [WorkflowExpression] Func<string> bodyfunnelId = null, [WorkflowExpression] Func<string> bodyfunnelStageId = null, [WorkflowExpression] Func<string> bodyfunnelStatusId = null, [WorkflowExpression] Func<string> bodystageDeadline = null, [WorkflowExpression] Func<string> bodydeadlineNotification = null, [WorkflowExpression] Func<string> bodystatusName = null, [WorkflowExpression] Func<string> bodyapprovedAt = null, [WorkflowExpression] Func<string> bodydeniedAt = null, [WorkflowExpression] Func<string> bodyamScores = null, [WorkflowExpression] Func<string> bodyprojectRevenue = null, [WorkflowExpression] Func<string> bodyprojectCost = null, [WorkflowExpression] Func<string> bodyprojectProfit = null, [WorkflowExpression] Func<string> bodyadminComments = null, [WorkflowExpression] Func<string> bodytempImage = null, [WorkflowExpression] Func<string> bodymainImage = null, [WorkflowExpression] Func<string> bodyimageConfigs = null, [WorkflowExpression] Func<string> bodyfromScript = null, [WorkflowExpression] Func<string> bodyreasonText = null, [WorkflowExpression] Func<string> bodycategoryText = null, [WorkflowExpression] Func<string> bodycanvassId = null, [WorkflowExpression] Func<string> bodybudgetTotal = null, [WorkflowExpression] Func<string> bodybudgetSpend = null, [WorkflowExpression] Func<string> bodybudgetResult = null, [WorkflowExpression] Func<string> bodytagText = null, [WorkflowExpression] Func<string> bodyestimatedTime = null, [WorkflowExpression] Func<string> bodytotalTimeSpend = null, [WorkflowExpression] Func<string> bodytotalTime = null, [WorkflowExpression] Func<string> bodyinnovationTypeId = null, [WorkflowExpression] Func<string> bodyinnovationTypeText = null, [WorkflowExpression] Func<string> bodysyncId = null, [WorkflowExpression] Func<string> bodyrecordUrl = null, [WorkflowExpression] Func<string> bodydescriptionEnriched = null, [WorkflowExpression] Func<string> bodycustomFieldValues = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyimage, nameof(bodyimage), required: false);
            SourceExpression.Validate(bodystartDate, nameof(bodystartDate), required: false);
            SourceExpression.Validate(bodyendDate, nameof(bodyendDate), required: false);
            SourceExpression.Validate(bodystatusId, nameof(bodystatusId), required: false);
            SourceExpression.Validate(bodydepartmentId, nameof(bodydepartmentId), required: false);
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            SourceExpression.Validate(bodystageId, nameof(bodystageId), required: false);
            SourceExpression.Validate(bodyprojectManagerId, nameof(bodyprojectManagerId), required: false);
            SourceExpression.Validate(bodybusinessOwnerId, nameof(bodybusinessOwnerId), required: false);
            SourceExpression.Validate(bodyprogress, nameof(bodyprogress), required: false);
            SourceExpression.Validate(bodycompanyId, nameof(bodycompanyId), required: false);
            SourceExpression.Validate(bodycommentsCount, nameof(bodycommentsCount), required: false);
            SourceExpression.Validate(bodyprojectScore, nameof(bodyprojectScore), required: false);
            SourceExpression.Validate(bodyslug, nameof(bodyslug), required: false);
            SourceExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            SourceExpression.Validate(bodymodifiedBy, nameof(bodymodifiedBy), required: false);
            SourceExpression.Validate(bodytagsCount, nameof(bodytagsCount), required: false);
            SourceExpression.Validate(bodyfunnelId, nameof(bodyfunnelId), required: false);
            SourceExpression.Validate(bodyfunnelStageId, nameof(bodyfunnelStageId), required: false);
            SourceExpression.Validate(bodyfunnelStatusId, nameof(bodyfunnelStatusId), required: false);
            SourceExpression.Validate(bodystageDeadline, nameof(bodystageDeadline), required: false);
            SourceExpression.Validate(bodydeadlineNotification, nameof(bodydeadlineNotification), required: false);
            SourceExpression.Validate(bodystatusName, nameof(bodystatusName), required: false);
            SourceExpression.Validate(bodyapprovedAt, nameof(bodyapprovedAt), required: false);
            SourceExpression.Validate(bodydeniedAt, nameof(bodydeniedAt), required: false);
            SourceExpression.Validate(bodyamScores, nameof(bodyamScores), required: false);
            SourceExpression.Validate(bodyprojectRevenue, nameof(bodyprojectRevenue), required: false);
            SourceExpression.Validate(bodyprojectCost, nameof(bodyprojectCost), required: false);
            SourceExpression.Validate(bodyprojectProfit, nameof(bodyprojectProfit), required: false);
            SourceExpression.Validate(bodyadminComments, nameof(bodyadminComments), required: false);
            SourceExpression.Validate(bodytempImage, nameof(bodytempImage), required: false);
            SourceExpression.Validate(bodymainImage, nameof(bodymainImage), required: false);
            SourceExpression.Validate(bodyimageConfigs, nameof(bodyimageConfigs), required: false);
            SourceExpression.Validate(bodyfromScript, nameof(bodyfromScript), required: false);
            SourceExpression.Validate(bodyreasonText, nameof(bodyreasonText), required: false);
            SourceExpression.Validate(bodycategoryText, nameof(bodycategoryText), required: false);
            SourceExpression.Validate(bodycanvassId, nameof(bodycanvassId), required: false);
            SourceExpression.Validate(bodybudgetTotal, nameof(bodybudgetTotal), required: false);
            SourceExpression.Validate(bodybudgetSpend, nameof(bodybudgetSpend), required: false);
            SourceExpression.Validate(bodybudgetResult, nameof(bodybudgetResult), required: false);
            SourceExpression.Validate(bodytagText, nameof(bodytagText), required: false);
            SourceExpression.Validate(bodyestimatedTime, nameof(bodyestimatedTime), required: false);
            SourceExpression.Validate(bodytotalTimeSpend, nameof(bodytotalTimeSpend), required: false);
            SourceExpression.Validate(bodytotalTime, nameof(bodytotalTime), required: false);
            SourceExpression.Validate(bodyinnovationTypeId, nameof(bodyinnovationTypeId), required: false);
            SourceExpression.Validate(bodyinnovationTypeText, nameof(bodyinnovationTypeText), required: false);
            SourceExpression.Validate(bodysyncId, nameof(bodysyncId), required: false);
            SourceExpression.Validate(bodyrecordUrl, nameof(bodyrecordUrl), required: false);
            SourceExpression.Validate(bodydescriptionEnriched, nameof(bodydescriptionEnriched), required: false);
            SourceExpression.Validate(bodycustomFieldValues, nameof(bodycustomFieldValues), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/projects/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyimage != null)
                {
                    body["image"] = SourceExpressionConverter.ConvertToken(bodyimage);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["end_date"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodystatusId != null)
                {
                    body["status_id"] = SourceExpressionConverter.ConvertToken(bodystatusId);
                    bodypropCount++;
                }

                if (bodydepartmentId != null)
                {
                    body["department_id"] = SourceExpressionConverter.ConvertToken(bodydepartmentId);
                    bodypropCount++;
                }

                if (bodyuserId != null)
                {
                    body["user_id"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                if (bodystageId != null)
                {
                    body["stage_id"] = SourceExpressionConverter.ConvertToken(bodystageId);
                    bodypropCount++;
                }

                if (bodyprojectManagerId != null)
                {
                    body["project_manager_id"] = SourceExpressionConverter.ConvertToken(bodyprojectManagerId);
                    bodypropCount++;
                }

                if (bodybusinessOwnerId != null)
                {
                    body["business_owner_id"] = SourceExpressionConverter.ConvertToken(bodybusinessOwnerId);
                    bodypropCount++;
                }

                if (bodyprogress != null)
                {
                    body["progress"] = SourceExpressionConverter.ConvertToken(bodyprogress);
                    bodypropCount++;
                }

                if (bodycompanyId != null)
                {
                    body["company_id"] = SourceExpressionConverter.ConvertToken(bodycompanyId);
                    bodypropCount++;
                }

                if (bodycommentsCount != null)
                {
                    body["comments_count"] = SourceExpressionConverter.ConvertToken(bodycommentsCount);
                    bodypropCount++;
                }

                if (bodyprojectScore != null)
                {
                    body["project_score"] = SourceExpressionConverter.ConvertToken(bodyprojectScore);
                    bodypropCount++;
                }

                if (bodyslug != null)
                {
                    body["slug"] = SourceExpressionConverter.ConvertToken(bodyslug);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodymodifiedBy != null)
                {
                    body["modified_by"] = SourceExpressionConverter.ConvertToken(bodymodifiedBy);
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
                    body["tags_count"] = SourceExpressionConverter.ConvertToken(bodytagsCount);
                    bodypropCount++;
                }

                if (bodyfunnelId != null)
                {
                    body["funnel_id"] = SourceExpressionConverter.ConvertToken(bodyfunnelId);
                    bodypropCount++;
                }

                if (bodyfunnelStageId != null)
                {
                    body["funnel_stage_id"] = SourceExpressionConverter.ConvertToken(bodyfunnelStageId);
                    bodypropCount++;
                }

                if (bodyfunnelStatusId != null)
                {
                    body["funnel_status_id"] = SourceExpressionConverter.ConvertToken(bodyfunnelStatusId);
                    bodypropCount++;
                }

                if (bodystageDeadline != null)
                {
                    body["stage_deadline"] = SourceExpressionConverter.ConvertToken(bodystageDeadline);
                    bodypropCount++;
                }

                if (bodydeadlineNotification != null)
                {
                    body["deadline_notification"] = SourceExpressionConverter.ConvertToken(bodydeadlineNotification);
                    bodypropCount++;
                }

                if (bodystatusName != null)
                {
                    body["status_name"] = SourceExpressionConverter.ConvertToken(bodystatusName);
                    bodypropCount++;
                }

                if (bodyapprovedAt != null)
                {
                    body["approved_at"] = SourceExpressionConverter.ConvertToken(bodyapprovedAt);
                    bodypropCount++;
                }

                if (bodydeniedAt != null)
                {
                    body["denied_at"] = SourceExpressionConverter.ConvertToken(bodydeniedAt);
                    bodypropCount++;
                }

                if (bodyamScores != null)
                {
                    body["am_scores"] = SourceExpressionConverter.ConvertToken(bodyamScores);
                    bodypropCount++;
                }

                if (bodyprojectRevenue != null)
                {
                    body["project_revenue"] = SourceExpressionConverter.ConvertToken(bodyprojectRevenue);
                    bodypropCount++;
                }

                if (bodyprojectCost != null)
                {
                    body["project_cost"] = SourceExpressionConverter.ConvertToken(bodyprojectCost);
                    bodypropCount++;
                }

                if (bodyprojectProfit != null)
                {
                    body["project_profit"] = SourceExpressionConverter.ConvertToken(bodyprojectProfit);
                    bodypropCount++;
                }

                if (bodyadminComments != null)
                {
                    body["admin_comments"] = SourceExpressionConverter.ConvertToken(bodyadminComments);
                    bodypropCount++;
                }

                if (bodytempImage != null)
                {
                    body["temp_image"] = SourceExpressionConverter.ConvertToken(bodytempImage);
                    bodypropCount++;
                }

                if (bodymainImage != null)
                {
                    body["main_image"] = SourceExpressionConverter.ConvertToken(bodymainImage);
                    bodypropCount++;
                }

                if (bodyimageConfigs != null)
                {
                    body["image_configs"] = SourceExpressionConverter.ConvertToken(bodyimageConfigs);
                    bodypropCount++;
                }

                if (bodyfromScript != null)
                {
                    body["from_script"] = SourceExpressionConverter.ConvertToken(bodyfromScript);
                    bodypropCount++;
                }

                if (bodyreasonText != null)
                {
                    body["reason_text"] = SourceExpressionConverter.ConvertToken(bodyreasonText);
                    bodypropCount++;
                }

                if (bodycategoryText != null)
                {
                    body["category_text"] = SourceExpressionConverter.ConvertToken(bodycategoryText);
                    bodypropCount++;
                }

                if (bodycanvassId != null)
                {
                    body["canvass_id"] = SourceExpressionConverter.ConvertToken(bodycanvassId);
                    bodypropCount++;
                }

                if (bodybudgetTotal != null)
                {
                    body["budget_total"] = SourceExpressionConverter.ConvertToken(bodybudgetTotal);
                    bodypropCount++;
                }

                if (bodybudgetSpend != null)
                {
                    body["budget_spend"] = SourceExpressionConverter.ConvertToken(bodybudgetSpend);
                    bodypropCount++;
                }

                if (bodybudgetResult != null)
                {
                    body["budget_result"] = SourceExpressionConverter.ConvertToken(bodybudgetResult);
                    bodypropCount++;
                }

                if (bodytagText != null)
                {
                    body["tag_text"] = SourceExpressionConverter.ConvertToken(bodytagText);
                    bodypropCount++;
                }

                if (bodyestimatedTime != null)
                {
                    body["estimated_time"] = SourceExpressionConverter.ConvertToken(bodyestimatedTime);
                    bodypropCount++;
                }

                if (bodytotalTimeSpend != null)
                {
                    body["total_time_spend"] = SourceExpressionConverter.ConvertToken(bodytotalTimeSpend);
                    bodypropCount++;
                }

                if (bodytotalTime != null)
                {
                    body["total_time"] = SourceExpressionConverter.ConvertToken(bodytotalTime);
                    bodypropCount++;
                }

                if (bodyinnovationTypeId != null)
                {
                    body["innovation_type_id"] = SourceExpressionConverter.ConvertToken(bodyinnovationTypeId);
                    bodypropCount++;
                }

                if (bodyinnovationTypeText != null)
                {
                    body["innovation_type_text"] = SourceExpressionConverter.ConvertToken(bodyinnovationTypeText);
                    bodypropCount++;
                }

                if (bodysyncId != null)
                {
                    body["sync_id"] = SourceExpressionConverter.ConvertToken(bodysyncId);
                    bodypropCount++;
                }

                if (bodyrecordUrl != null)
                {
                    body["record_url"] = SourceExpressionConverter.ConvertToken(bodyrecordUrl);
                    bodypropCount++;
                }

                if (bodydescriptionEnriched != null)
                {
                    body["description_enriched"] = SourceExpressionConverter.ConvertToken(bodydescriptionEnriched);
                    bodypropCount++;
                }

                if (bodycustomFieldValues != null)
                {
                    body["custom_field_values"] = SourceExpressionConverter.ConvertToken(bodycustomFieldValues);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PutprojectsIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchprojectsIdResponse> PatchprojectsId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/projects/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PatchprojectsIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetprojectsProjectIdTasksResponse> GetprojectsProjectIdTasks([WorkflowExpression] Func<string> projectId)
        {
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/projects/{0}/tasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetprojectsProjectIdTasksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PostprojectsProjectIdTasksResponse> PostprojectsProjectIdTasks([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<int> bodystatus = null)
        {
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/projects/{0}/tasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PostprojectsProjectIdTasksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetTaskBySyncIdResponse> GetTaskBySyncId([WorkflowExpression] Func<string> syncId = null)
        {
            SourceExpression.Validate(syncId, nameof(syncId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (syncId != null)
                    callPayload.Queries["sync_id"] = SourceExpressionConverter.ConvertO(syncId);
                return callPayload;
            }

            return new ApiConnectionAction<GetTaskBySyncIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PosttasksResponse> Posttasks([WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<int> bodystatus = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PosttasksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GettasksIdResponse> GettasksId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/tasks/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GettasksIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeletetasksId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/tasks/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchtasksIdResponse> PatchtasksId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<int> bodystatus = null, [WorkflowExpression] Func<string> bodysyncId = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodysyncId, nameof(bodysyncId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/tasks/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodysyncId != null)
                {
                    body["sync_id"] = SourceExpressionConverter.ConvertToken(bodysyncId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PatchtasksIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GettopicsResponse> Gettopics()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/topics";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GettopicsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeletetopicsId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/topics/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetusersResponse> Getusers()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetusersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PostusersResponse> Postusers([WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodyphoneNumber = null, [WorkflowExpression] Func<int> bodyposition = null)
        {
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            SourceExpression.Validate(bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            SourceExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfirstName != null)
                {
                    body["first_name"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["last_name"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodyphoneNumber != null)
                {
                    body["phone_number"] = SourceExpressionConverter.ConvertToken(bodyphoneNumber);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PostusersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetusersGetCompanyResponse> GetusersGetCompany()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/users/get_company";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetusersGetCompanyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetusersIdResponse> GetusersId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetusersIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeleteusersId([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PutusersIdResponse> PutusersId([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodyprofilePic = null, [WorkflowExpression] Func<int> bodypoints = null, [WorkflowExpression] Func<int> bodycompanyId = null, [WorkflowExpression] Func<int> bodyuserRoleId = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyslug = null, [WorkflowExpression] Func<string> bodyphoneNumber = null, [WorkflowExpression] Func<string> bodylastSignOutAt = null, [WorkflowExpression] Func<string> bodyposition = null, [WorkflowExpression] Func<bool> bodyprofileFlag = null, [WorkflowExpression] Func<string> bodyuserChecklist = null, [WorkflowExpression] Func<int> bodyideaLikesCount = null, [WorkflowExpression] Func<int> bodycommentsCount = null, [WorkflowExpression] Func<int> bodyxpPoints = null, [WorkflowExpression] Func<int> bodyideasCount = null, [WorkflowExpression] Func<string> bodyfunnelId = null, [WorkflowExpression] Func<int> bodylevel = null, [WorkflowExpression] Func<int> bodyxpLevel = null, [WorkflowExpression] Func<string> bodyprojectFunnelId = null, [WorkflowExpression] Func<string> bodychecklistScore = null, [WorkflowExpression] Func<string> bodyprovider = null, [WorkflowExpression] Func<string> bodyuid = null, [WorkflowExpression] Func<string> bodyemailSentAt = null, [WorkflowExpression] Func<bool> bodyblockAllNotification = null, [WorkflowExpression] Func<string> bodydbName = null, [WorkflowExpression] Func<string> bodydeptId = null, [WorkflowExpression] Func<string> bodydeptName = null, [WorkflowExpression] Func<string> bodymainImage = null, [WorkflowExpression] Func<string> bodytempImage = null, [WorkflowExpression] Func<string> bodyimageConfigs = null, [WorkflowExpression] Func<bool> bodyimageAutoGenerated = null, [WorkflowExpression] Func<string> bodyamAccount = null, [WorkflowExpression] Func<string> bodyuuid = null, [WorkflowExpression] Func<string> bodypasswordResetAttempts = null, [WorkflowExpression] Func<string> bodylastPasswordResetAt = null, [WorkflowExpression] Func<string> bodycustomDomain = null, [WorkflowExpression] Func<string> bodyuserRoleName = null, [WorkflowExpression] Func<int> bodytheme = null, [WorkflowExpression] Func<string> bodyuserType = null, [WorkflowExpression] Func<string> bodyviewSettings = null, [WorkflowExpression] Func<string> bodyreadManual = null, [WorkflowExpression] Func<string> bodyaddIdeaBox = null, [WorkflowExpression] Func<string> bodyvisitAgent = null, [WorkflowExpression] Func<string> bodyaddIdea = null, [WorkflowExpression] Func<string> bodyinvitePeople = null, [WorkflowExpression] Func<string> bodyaddBoardMission = null, [WorkflowExpression] Func<string> bodyaddProject = null, [WorkflowExpression] Func<string> bodycompletedChecklist = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            SourceExpression.Validate(bodyprofilePic, nameof(bodyprofilePic), required: false);
            SourceExpression.Validate(bodypoints, nameof(bodypoints), required: false);
            SourceExpression.Validate(bodycompanyId, nameof(bodycompanyId), required: false);
            SourceExpression.Validate(bodyuserRoleId, nameof(bodyuserRoleId), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyslug, nameof(bodyslug), required: false);
            SourceExpression.Validate(bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            SourceExpression.Validate(bodylastSignOutAt, nameof(bodylastSignOutAt), required: false);
            SourceExpression.Validate(bodyposition, nameof(bodyposition), required: false);
            SourceExpression.Validate(bodyprofileFlag, nameof(bodyprofileFlag), required: false);
            SourceExpression.Validate(bodyuserChecklist, nameof(bodyuserChecklist), required: false);
            SourceExpression.Validate(bodyideaLikesCount, nameof(bodyideaLikesCount), required: false);
            SourceExpression.Validate(bodycommentsCount, nameof(bodycommentsCount), required: false);
            SourceExpression.Validate(bodyxpPoints, nameof(bodyxpPoints), required: false);
            SourceExpression.Validate(bodyideasCount, nameof(bodyideasCount), required: false);
            SourceExpression.Validate(bodyfunnelId, nameof(bodyfunnelId), required: false);
            SourceExpression.Validate(bodylevel, nameof(bodylevel), required: false);
            SourceExpression.Validate(bodyxpLevel, nameof(bodyxpLevel), required: false);
            SourceExpression.Validate(bodyprojectFunnelId, nameof(bodyprojectFunnelId), required: false);
            SourceExpression.Validate(bodychecklistScore, nameof(bodychecklistScore), required: false);
            SourceExpression.Validate(bodyprovider, nameof(bodyprovider), required: false);
            SourceExpression.Validate(bodyuid, nameof(bodyuid), required: false);
            SourceExpression.Validate(bodyemailSentAt, nameof(bodyemailSentAt), required: false);
            SourceExpression.Validate(bodyblockAllNotification, nameof(bodyblockAllNotification), required: false);
            SourceExpression.Validate(bodydbName, nameof(bodydbName), required: false);
            SourceExpression.Validate(bodydeptId, nameof(bodydeptId), required: false);
            SourceExpression.Validate(bodydeptName, nameof(bodydeptName), required: false);
            SourceExpression.Validate(bodymainImage, nameof(bodymainImage), required: false);
            SourceExpression.Validate(bodytempImage, nameof(bodytempImage), required: false);
            SourceExpression.Validate(bodyimageConfigs, nameof(bodyimageConfigs), required: false);
            SourceExpression.Validate(bodyimageAutoGenerated, nameof(bodyimageAutoGenerated), required: false);
            SourceExpression.Validate(bodyamAccount, nameof(bodyamAccount), required: false);
            SourceExpression.Validate(bodyuuid, nameof(bodyuuid), required: false);
            SourceExpression.Validate(bodypasswordResetAttempts, nameof(bodypasswordResetAttempts), required: false);
            SourceExpression.Validate(bodylastPasswordResetAt, nameof(bodylastPasswordResetAt), required: false);
            SourceExpression.Validate(bodycustomDomain, nameof(bodycustomDomain), required: false);
            SourceExpression.Validate(bodyuserRoleName, nameof(bodyuserRoleName), required: false);
            SourceExpression.Validate(bodytheme, nameof(bodytheme), required: false);
            SourceExpression.Validate(bodyuserType, nameof(bodyuserType), required: false);
            SourceExpression.Validate(bodyviewSettings, nameof(bodyviewSettings), required: false);
            SourceExpression.Validate(bodyreadManual, nameof(bodyreadManual), required: false);
            SourceExpression.Validate(bodyaddIdeaBox, nameof(bodyaddIdeaBox), required: false);
            SourceExpression.Validate(bodyvisitAgent, nameof(bodyvisitAgent), required: false);
            SourceExpression.Validate(bodyaddIdea, nameof(bodyaddIdea), required: false);
            SourceExpression.Validate(bodyinvitePeople, nameof(bodyinvitePeople), required: false);
            SourceExpression.Validate(bodyaddBoardMission, nameof(bodyaddBoardMission), required: false);
            SourceExpression.Validate(bodyaddProject, nameof(bodyaddProject), required: false);
            SourceExpression.Validate(bodycompletedChecklist, nameof(bodycompletedChecklist), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/general/v1/users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfirstName != null)
                {
                    body["first_name"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["last_name"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodyprofilePic != null)
                {
                    body["profile_pic"] = SourceExpressionConverter.ConvertToken(bodyprofilePic);
                    bodypropCount++;
                }

                if (bodypoints != null)
                {
                    body["points"] = SourceExpressionConverter.ConvertToken(bodypoints);
                    bodypropCount++;
                }

                if (bodycompanyId != null)
                {
                    body["company_id"] = SourceExpressionConverter.ConvertToken(bodycompanyId);
                    bodypropCount++;
                }

                if (bodyuserRoleId != null)
                {
                    body["user_role_id"] = SourceExpressionConverter.ConvertToken(bodyuserRoleId);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyslug != null)
                {
                    body["slug"] = SourceExpressionConverter.ConvertToken(bodyslug);
                    bodypropCount++;
                }

                if (bodyphoneNumber != null)
                {
                    body["phone_number"] = SourceExpressionConverter.ConvertToken(bodyphoneNumber);
                    bodypropCount++;
                }

                if (bodylastSignOutAt != null)
                {
                    body["last_sign_out_at"] = SourceExpressionConverter.ConvertToken(bodylastSignOutAt);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodyprofileFlag != null)
                {
                    body["profile_flag"] = SourceExpressionConverter.ConvertToken(bodyprofileFlag);
                    bodypropCount++;
                }

                if (bodyuserChecklist != null)
                {
                    body["user_checklist"] = SourceExpressionConverter.ConvertToken(bodyuserChecklist);
                    bodypropCount++;
                }

                if (bodyideaLikesCount != null)
                {
                    body["idea_likes_count"] = SourceExpressionConverter.ConvertToken(bodyideaLikesCount);
                    bodypropCount++;
                }

                if (bodycommentsCount != null)
                {
                    body["comments_count"] = SourceExpressionConverter.ConvertToken(bodycommentsCount);
                    bodypropCount++;
                }

                if (bodyxpPoints != null)
                {
                    body["xp_points"] = SourceExpressionConverter.ConvertToken(bodyxpPoints);
                    bodypropCount++;
                }

                if (bodyideasCount != null)
                {
                    body["ideas_count"] = SourceExpressionConverter.ConvertToken(bodyideasCount);
                    bodypropCount++;
                }

                if (bodyfunnelId != null)
                {
                    body["funnel_id"] = SourceExpressionConverter.ConvertToken(bodyfunnelId);
                    bodypropCount++;
                }

                if (bodylevel != null)
                {
                    body["level"] = SourceExpressionConverter.ConvertToken(bodylevel);
                    bodypropCount++;
                }

                if (bodyxpLevel != null)
                {
                    body["xp_level"] = SourceExpressionConverter.ConvertToken(bodyxpLevel);
                    bodypropCount++;
                }

                if (bodyprojectFunnelId != null)
                {
                    body["project_funnel_id"] = SourceExpressionConverter.ConvertToken(bodyprojectFunnelId);
                    bodypropCount++;
                }

                if (bodychecklistScore != null)
                {
                    body["checklist_score"] = SourceExpressionConverter.ConvertToken(bodychecklistScore);
                    bodypropCount++;
                }

                if (bodyprovider != null)
                {
                    body["provider"] = SourceExpressionConverter.ConvertToken(bodyprovider);
                    bodypropCount++;
                }

                if (bodyuid != null)
                {
                    body["uid"] = SourceExpressionConverter.ConvertToken(bodyuid);
                    bodypropCount++;
                }

                if (bodyemailSentAt != null)
                {
                    body["email_sent_at"] = SourceExpressionConverter.ConvertToken(bodyemailSentAt);
                    bodypropCount++;
                }

                if (bodyblockAllNotification != null)
                {
                    body["block_all_notification"] = SourceExpressionConverter.ConvertToken(bodyblockAllNotification);
                    bodypropCount++;
                }

                if (bodydbName != null)
                {
                    body["db_name"] = SourceExpressionConverter.ConvertToken(bodydbName);
                    bodypropCount++;
                }

                if (bodydeptId != null)
                {
                    body["dept_id"] = SourceExpressionConverter.ConvertToken(bodydeptId);
                    bodypropCount++;
                }

                if (bodydeptName != null)
                {
                    body["dept_name"] = SourceExpressionConverter.ConvertToken(bodydeptName);
                    bodypropCount++;
                }

                if (bodymainImage != null)
                {
                    body["main_image"] = SourceExpressionConverter.ConvertToken(bodymainImage);
                    bodypropCount++;
                }

                if (bodytempImage != null)
                {
                    body["temp_image"] = SourceExpressionConverter.ConvertToken(bodytempImage);
                    bodypropCount++;
                }

                if (bodyimageConfigs != null)
                {
                    body["image_configs"] = SourceExpressionConverter.ConvertToken(bodyimageConfigs);
                    bodypropCount++;
                }

                if (bodyimageAutoGenerated != null)
                {
                    body["image_auto_generated"] = SourceExpressionConverter.ConvertToken(bodyimageAutoGenerated);
                    bodypropCount++;
                }

                if (bodyamAccount != null)
                {
                    body["am_account"] = SourceExpressionConverter.ConvertToken(bodyamAccount);
                    bodypropCount++;
                }

                if (bodyuuid != null)
                {
                    body["uuid"] = SourceExpressionConverter.ConvertToken(bodyuuid);
                    bodypropCount++;
                }

                if (bodypasswordResetAttempts != null)
                {
                    body["password_reset_attempts"] = SourceExpressionConverter.ConvertToken(bodypasswordResetAttempts);
                    bodypropCount++;
                }

                if (bodylastPasswordResetAt != null)
                {
                    body["last_password_reset_at"] = SourceExpressionConverter.ConvertToken(bodylastPasswordResetAt);
                    bodypropCount++;
                }

                if (bodycustomDomain != null)
                {
                    body["custom_domain"] = SourceExpressionConverter.ConvertToken(bodycustomDomain);
                    bodypropCount++;
                }

                if (bodyuserRoleName != null)
                {
                    body["user_role_name"] = SourceExpressionConverter.ConvertToken(bodyuserRoleName);
                    bodypropCount++;
                }

                if (bodytheme != null)
                {
                    body["theme"] = SourceExpressionConverter.ConvertToken(bodytheme);
                    bodypropCount++;
                }

                if (bodyuserType != null)
                {
                    body["user_type"] = SourceExpressionConverter.ConvertToken(bodyuserType);
                    bodypropCount++;
                }

                if (bodyviewSettings != null)
                {
                    body["view_settings"] = SourceExpressionConverter.ConvertToken(bodyviewSettings);
                    bodypropCount++;
                }

                if (bodyreadManual != null)
                {
                    body["read_manual"] = SourceExpressionConverter.ConvertToken(bodyreadManual);
                    bodypropCount++;
                }

                if (bodyaddIdeaBox != null)
                {
                    body["add_idea_box"] = SourceExpressionConverter.ConvertToken(bodyaddIdeaBox);
                    bodypropCount++;
                }

                if (bodyvisitAgent != null)
                {
                    body["visit_agent"] = SourceExpressionConverter.ConvertToken(bodyvisitAgent);
                    bodypropCount++;
                }

                if (bodyaddIdea != null)
                {
                    body["add_idea"] = SourceExpressionConverter.ConvertToken(bodyaddIdea);
                    bodypropCount++;
                }

                if (bodyinvitePeople != null)
                {
                    body["invite_people"] = SourceExpressionConverter.ConvertToken(bodyinvitePeople);
                    bodypropCount++;
                }

                if (bodyaddBoardMission != null)
                {
                    body["add_board_mission"] = SourceExpressionConverter.ConvertToken(bodyaddBoardMission);
                    bodypropCount++;
                }

                if (bodyaddProject != null)
                {
                    body["add_project"] = SourceExpressionConverter.ConvertToken(bodyaddProject);
                    bodypropCount++;
                }

                if (bodycompletedChecklist != null)
                {
                    body["completed_checklist"] = SourceExpressionConverter.ConvertToken(bodycompletedChecklist);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PutusersIdResponse>(BuildSourceInput);
        }
    }

    public class AcceptmissionTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger TriggerIdeaCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/ideas/add_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerIdeaUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/ideas/edit_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerIdeaDeleted(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/ideas/delete_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerProjectCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/projects/add_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerProjectUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/projects/edit_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerProjectDelete(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/projects/delete_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggertaskCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/tasks/add_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggercategoryCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/categories/add_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerCategoryUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/categories/edit_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerCategoryDeleted(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/categories/delete_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerdepartmentCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/departments/add_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerdepartmentUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/departments/edit_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerdepartmentDeleted(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/departments/delete_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerfunnellaneCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/funnel_lanes/add_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerfunnellaneUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/funnel_lanes/edit_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerfunnellaneDeleted(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/funnel_lanes/delete_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerfunnelCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/funnels/add_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerfunnelUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/funnels/edit_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerfunnelDeleted(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/funnels/delete_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggermissionCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/missions/add_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggermissionUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/missions/edit_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggermissionDeleted(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/missions/delete_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggertopicCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/topics/add_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggertopicUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/topics/edit_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggertopicDeleted(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/topics/delete_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggertaskUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/tasks/edit_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggertaskDeleted(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/tasks/delete_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggeruserCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/users/add_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggeruserUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/users/edit_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggeruserDeleted(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/general/v1/users/delete_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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