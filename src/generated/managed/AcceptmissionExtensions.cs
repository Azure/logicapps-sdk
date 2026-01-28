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
            var apiCallPath = "/general/v1/categories";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetcategoriesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PostcategoriesResponse> Postcategories(Expression<Func<string>> bodytitle = null, Expression<Func<int>> bodyposition = null, Expression<Func<string>> bodychipColor = null, Expression<Func<string>> bodymissionsId = null, Expression<Func<int>> bodycompanyId = null, Expression<Func<string>> bodyimage = null, Expression<Func<int>> bodyuserId = null, Expression<Func<string>> bodytempImage = null, Expression<Func<string>> bodymainImage = null, Expression<Func<string>> bodyimageConfigs = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string>> bodyupdatedBy = null, Expression<Func<string>> bodyrecordUrl = null, Expression<Func<string>> bodysyncId = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetcategoriesIdResponse> GetcategoriesId(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/general/v1/categories/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetcategoriesIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeletecategoriesId(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/general/v1/categories/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PutcategoriesIdResponse> PutcategoriesId(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<int>> bodyposition = null, Expression<Func<string>> bodychipColor = null, Expression<Func<string>> bodymissionsId = null, Expression<Func<int>> bodycompanyId = null, Expression<Func<string>> bodyimage = null, Expression<Func<int>> bodyuserId = null, Expression<Func<string>> bodytempImage = null, Expression<Func<string>> bodymainImage = null, Expression<Func<string>> bodyimageConfigs = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string>> bodyupdatedBy = null, Expression<Func<string>> bodyrecordUrl = null, Expression<Func<string>> bodysyncId = null)
        {
            var apiCallPath = String.Format("/general/v1/categories/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchcategoriesIdResponse> PatchcategoriesId(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null)
        {
            var apiCallPath = String.Format("/general/v1/categories/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetdepartmentsIdResponse> GetdepartmentsId(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/general/v1/departments/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetdepartmentsIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeletedepartmentsId(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/general/v1/departments/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PutdepartmentsIdResponse> PutdepartmentsId(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<int>> bodyposition = null, Expression<Func<int>> bodycompanyId = null, Expression<Func<int>> bodyideasCount = null, Expression<Func<int>> bodyprojectsCount = null, Expression<Func<string>> bodyimage = null, Expression<Func<int>> bodyuserId = null, Expression<Func<string>> bodytempImage = null, Expression<Func<string>> bodymainImage = null, Expression<Func<string>> bodyimageConfigs = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string>> bodyupdatedBy = null, Expression<Func<string>> bodyrecordUrl = null, Expression<Func<string>> bodysyncId = null)
        {
            var apiCallPath = String.Format("/general/v1/departments/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchdepartmentsIdResponse> PatchdepartmentsId(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<int>> bodyposition = null)
        {
            var apiCallPath = String.Format("/general/v1/departments/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetfunnelLanesIdResponse> GetfunnelLanesId(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/general/v1/funnel_lanes/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetfunnelLanesIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeletefunnelLanesId(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/general/v1/funnel_lanes/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PutfunnelLanesIdResponse> PutfunnelLanesId(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<int>> bodyfunnelStageType = null, Expression<Func<int>> bodystageType = null, Expression<Func<string>> bodycolor = null, Expression<Func<int>> bodydeadline = null, Expression<Func<int>> bodyposition = null, Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodymodifiedBy = null, Expression<Func<int>> bodyfunnelId = null, Expression<Func<int>> bodyfunnelStatusId = null, Expression<Func<int>> bodyownerId = null, Expression<Func<bool>> bodyenableNotification = null, Expression<Func<int>> bodyideasCount = null, Expression<Func<int>> bodyprojectsCount = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodylink = null, Expression<Func<string>> bodyfile = null, Expression<Func<bool>> bodyshowInGraph = null, Expression<Func<bool>> bodyshowInBubble = null, Expression<Func<int>> bodyconfettiType = null, Expression<Func<string>> bodyautomationOwnerId = null)
        {
            var apiCallPath = String.Format("/general/v1/funnel_lanes/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchfunnelLanesIdResponse> PatchfunnelLanesId(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null)
        {
            var apiCallPath = String.Format("/general/v1/funnel_lanes/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetfunnelsIdResponse> GetfunnelsId(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/general/v1/funnels/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetfunnelsIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeletefunnelsId(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/general/v1/funnels/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction PutfunnelsId(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<int>> bodycompanyId = null, Expression<Func<int>> bodyuserId = null, Expression<Func<int>> bodyfunnelType = null, Expression<Func<int>> bodymodifiedBy = null, Expression<Func<int>> bodyprivacySetting = null, Expression<Func<int>> bodyownerId = null, Expression<Func<bool>> bodyblockFunnelNotification = null, Expression<Func<int>> bodyideasCount = null, Expression<Func<int>> bodyprojectsCount = null, Expression<Func<bool>> bodyhidden = null, Expression<Func<string>> bodysetXAxis = null, Expression<Func<string>> bodysetYAxis = null, Expression<Func<string>> bodysetZAxis = null, Expression<Func<string>> bodysetAxisColor = null, Expression<Func<string>> bodydepartmentId = null, Expression<Func<int>> bodyprojectFunnelId = null, Expression<Func<string>> bodyfromScript = null, Expression<Func<int>> bodyuserPrivacySetting = null, Expression<Func<bool>> bodyincludeInDashboard = null, Expression<Func<string>> bodyrecordUrl = null, Expression<Func<string>> bodysyncId = null)
        {
            var apiCallPath = String.Format("/general/v1/funnels/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchfunnelsIdResponse> PatchfunnelsId(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<int>> bodyfunnelType = null)
        {
            var apiCallPath = String.Format("/general/v1/funnels/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetideasIdeaIdTasksResponse> GetideasIdeaIdTasks(Expression<Func<string>> ideaId)
        {
            var apiCallPath = String.Format("/general/v1/ideas/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(ideaId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetideasIdeaIdTasksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PostideasIdeaIdTasksResponse> PostideasIdeaIdTasks(Expression<Func<string>> ideaId, Expression<Func<string>> bodytitle = null, Expression<Func<int>> bodystatus = null)
        {
            var apiCallPath = String.Format("/general/v1/ideas/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(ideaId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction GetideasId(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/general/v1/ideas/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeleteideasId(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/general/v1/ideas/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction PutideasId(Expression<Func<string>> id, Expression<Func<int>> bodyuserId = null, Expression<Func<int>> bodyroundId = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodycontent = null, Expression<Func<string>> bodyimage = null, Expression<Func<string>> bodydevice = null, Expression<Func<string>> bodybrowser = null, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodyscreenRes = null, Expression<Func<string>> bodyuserIp = null, Expression<Func<int>> bodycommentsCount = null, Expression<Func<int>> bodyreviewScoresCount = null, Expression<Func<string>> bodyslug = null, Expression<Func<int>> bodystage = null, Expression<Func<string>> bodydepartmentId = null, Expression<Func<string>> bodystatusId = null, Expression<Func<string>> bodyposition = null, Expression<Func<string>> bodyprojectId = null, Expression<Func<string>> bodyideaCreator = null, Expression<Func<string>> bodyideationIdeaCategoryId = null, Expression<Func<string>> bodyboardIdeaCategoryId = null, Expression<Func<int>> bodycompanyId = null, Expression<Func<int>> bodyideaLikesCount = null, Expression<Func<bool>> bodybookmark = null, Expression<Func<int>> bodyideaScoresCount = null, Expression<Func<int>> bodylikesCount = null, Expression<Func<string>> bodyboardId = null, Expression<Func<string>> bodymissionId = null, Expression<Func<string>> bodycreatorName = null, Expression<Func<int>> bodytagsCount = null, Expression<Func<string>> bodyfunnelId = null, Expression<Func<string>> bodyfunnelStageId = null, Expression<Func<string>> bodyfunnelStatusId = null, Expression<Func<string>> bodyideaDeadline = null, Expression<Func<bool>> bodydeadlineNotification = null, Expression<Func<int>> bodyideaViews = null, Expression<Func<string>> bodyrevenue = null, Expression<Func<string>> bodycost = null, Expression<Func<string>> bodyprofit = null, Expression<Func<string>> bodystatusName = null, Expression<Func<string>> bodyideaScores = null, Expression<Func<string>> bodyapprovedAt = null, Expression<Func<string>> bodydeniedAt = null, Expression<Func<string>> bodyadminComments = null, Expression<Func<bool>> bodyisChild = null, Expression<Func<string>> bodyparentId = null, Expression<Func<string>> bodytempImage = null, Expression<Func<string>> bodymainImage = null, Expression<Func<string>> bodyimageConfigs = null, Expression<Func<int>> bodyscoreCompleteScore = null, Expression<Func<int>> bodyenrichmentScore = null, Expression<Func<int>> bodyengagementScore = null, Expression<Func<int>> bodyopportunityScore = null, Expression<Func<int>> bodytrendScore = null, Expression<Func<string>> bodycleanedText = null, Expression<Func<int>> bodyduplicateIdeasCount = null, Expression<Func<string>> bodysidekiqDuplicateIdeasCount = null, Expression<Func<string>> bodyaiCreated = null, Expression<Func<string>> bodyideaType = null, Expression<Func<string>> bodyfromScript = null, Expression<Func<string>> bodyembedding = null, Expression<Func<string>> bodyreasonText = null, Expression<Func<string>> bodycategoryText = null, Expression<Func<string>> bodycanvassId = null, Expression<Func<string>> bodybudgetTotal = null, Expression<Func<string>> bodybudgetSpend = null, Expression<Func<string>> bodybudgetResult = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodytagText = null, Expression<Func<string>> bodyinnovationTypeId = null, Expression<Func<string>> bodyinnovationTypeText = null, Expression<Func<string>> bodysyncId = null, Expression<Func<string>> bodyrecordUrl = null, Expression<Func<string>> bodydescriptionEnriched = null)
        {
            var apiCallPath = String.Format("/general/v1/ideas/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction PatchideasId(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodycontent = null, Expression<Func<int>> bodyfunnelId = null)
        {
            var apiCallPath = String.Format("/general/v1/ideas/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetmissionsIdResponse> GetmissionsId(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/general/v1/missions/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetmissionsIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeletemissionsId(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/general/v1/missions/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PutmissionsIdResponse> PutmissionsId(Expression<Func<string>> id, Expression<Func<int>> bodyuserId = null, Expression<Func<int>> bodycompanyId = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<bool>> bodyisAnonymous = null, Expression<Func<string>> bodyendingNote = null, Expression<Func<string>> bodymissionPic = null, Expression<Func<int>> bodyteamSize = null, Expression<Func<int>> bodystatus = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyslug = null, Expression<Func<string>> bodyfromName = null, Expression<Func<bool>> bodyisTemplate = null, Expression<Func<int>> bodyendDuration = null, Expression<Func<string>> bodytoken = null, Expression<Func<bool>> bodyisTryout = null, Expression<Func<int>> bodytemplateType = null, Expression<Func<bool>> bodyisOpen = null, Expression<Func<int>> bodymissionType = null, Expression<Func<string>> bodypublishedOnce = null, Expression<Func<string>> bodyinboxQuestion = null, Expression<Func<string>> bodyprivacySetting = null, Expression<Func<string>> bodyagentProfile = null, Expression<Func<string>> bodydepartmentId = null, Expression<Func<bool>> bodyenableReport = null, Expression<Func<int>> bodyideasCount = null, Expression<Func<int>> bodylikesCount = null, Expression<Func<int>> bodycommentsCount = null, Expression<Func<string>> bodyfunnelId = null, Expression<Func<string>> bodyemail = null, Expression<Func<bool>> bodyenableInboundEmail = null, Expression<Func<string>> bodydepartmentName = null, Expression<Func<string>> bodynotificationType = null, Expression<Func<string>> bodynotificationFrequency = null, Expression<Func<string>> bodynotificationText = null, Expression<Func<int>> bodyposition = null, Expression<Func<string>> bodymissionViews = null, Expression<Func<string>> bodytempImage = null, Expression<Func<string>> bodymainImage = null, Expression<Func<string>> bodyimageConfigs = null, Expression<Func<string>> bodyallowAiIdeas = null, Expression<Func<string>> bodyaiMissionType = null, Expression<Func<string>> bodyfromScript = null, Expression<Func<string>> bodyideaAttachmentsAllowed = null, Expression<Func<string>> bodyvideoLink = null, Expression<Func<string>> bodyhidden = null, Expression<Func<string>> bodyconfettiType = null, Expression<Func<string>> bodyenable = null, Expression<Func<string>> bodyaddAttachment = null, Expression<Func<string>> bodyaddComment = null, Expression<Func<string>> bodyrecordUrl = null, Expression<Func<string>> bodysyncId = null, Expression<Func<string>> bodyideaCustomFields = null)
        {
            var apiCallPath = String.Format("/general/v1/missions/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchmissionsIdResponse> PatchmissionsId(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<bool>> bodyhidden = null)
        {
            var apiCallPath = String.Format("/general/v1/missions/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetprojectsIdResponse> GetprojectsId(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/general/v1/projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetprojectsIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeleteprojectsId(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/general/v1/projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PutprojectsIdResponse> PutprojectsId(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyimage = null, Expression<Func<string>> bodystartDate = null, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodystatusId = null, Expression<Func<string>> bodydepartmentId = null, Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodystageId = null, Expression<Func<string>> bodyprojectManagerId = null, Expression<Func<string>> bodybusinessOwnerId = null, Expression<Func<string>> bodyprogress = null, Expression<Func<string>> bodycompanyId = null, Expression<Func<string>> bodycommentsCount = null, Expression<Func<string>> bodyprojectScore = null, Expression<Func<string>> bodyslug = null, Expression<Func<string>> bodyposition = null, Expression<Func<int>> bodymodifiedBy = null, Expression<Func<int>> bodytagsCount = null, Expression<Func<string>> bodyfunnelId = null, Expression<Func<string>> bodyfunnelStageId = null, Expression<Func<string>> bodyfunnelStatusId = null, Expression<Func<string>> bodystageDeadline = null, Expression<Func<string>> bodydeadlineNotification = null, Expression<Func<string>> bodystatusName = null, Expression<Func<string>> bodyapprovedAt = null, Expression<Func<string>> bodydeniedAt = null, Expression<Func<string>> bodyamScores = null, Expression<Func<string>> bodyprojectRevenue = null, Expression<Func<string>> bodyprojectCost = null, Expression<Func<string>> bodyprojectProfit = null, Expression<Func<string>> bodyadminComments = null, Expression<Func<string>> bodytempImage = null, Expression<Func<string>> bodymainImage = null, Expression<Func<string>> bodyimageConfigs = null, Expression<Func<string>> bodyfromScript = null, Expression<Func<string>> bodyreasonText = null, Expression<Func<string>> bodycategoryText = null, Expression<Func<string>> bodycanvassId = null, Expression<Func<string>> bodybudgetTotal = null, Expression<Func<string>> bodybudgetSpend = null, Expression<Func<string>> bodybudgetResult = null, Expression<Func<string>> bodytagText = null, Expression<Func<string>> bodyestimatedTime = null, Expression<Func<string>> bodytotalTimeSpend = null, Expression<Func<string>> bodytotalTime = null, Expression<Func<string>> bodyinnovationTypeId = null, Expression<Func<string>> bodyinnovationTypeText = null, Expression<Func<string>> bodysyncId = null, Expression<Func<string>> bodyrecordUrl = null, Expression<Func<string>> bodydescriptionEnriched = null, Expression<Func<string>> bodycustomFieldValues = null)
        {
            var apiCallPath = String.Format("/general/v1/projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchprojectsIdResponse> PatchprojectsId(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null)
        {
            var apiCallPath = String.Format("/general/v1/projects/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetprojectsProjectIdTasksResponse> GetprojectsProjectIdTasks(Expression<Func<string>> projectId)
        {
            var apiCallPath = String.Format("/general/v1/projects/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetprojectsProjectIdTasksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PostprojectsProjectIdTasksResponse> PostprojectsProjectIdTasks(Expression<Func<string>> projectId, Expression<Func<string>> bodytitle = null, Expression<Func<int>> bodystatus = null)
        {
            var apiCallPath = String.Format("/general/v1/projects/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetTaskBySyncIdResponse> GetTaskBySyncId(Expression<Func<string>> syncId = null)
        {
            var apiCallPath = "/general/v1/tasks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (syncId != null)
                callPayload.Queries["sync_id"] = ExpressionConverter.Convert(syncId);
            return new ApiConnectionAction<GetTaskBySyncIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PosttasksResponse> Posttasks(Expression<Func<string>> bodytitle = null, Expression<Func<int>> bodystatus = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GettasksIdResponse> GettasksId(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/general/v1/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GettasksIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeletetasksId(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/general/v1/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchtasksIdResponse> PatchtasksId(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<int>> bodystatus = null, Expression<Func<string>> bodysyncId = null)
        {
            var apiCallPath = String.Format("/general/v1/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
            var apiCallPath = String.Format("/general/v1/topics/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
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
            var apiCallPath = String.Format("/general/v1/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetusersIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction DeleteusersId(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/general/v1/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PutusersIdResponse> PutusersId(Expression<Func<string>> id, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodyprofilePic = null, Expression<Func<int>> bodypoints = null, Expression<Func<int>> bodycompanyId = null, Expression<Func<int>> bodyuserRoleId = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyslug = null, Expression<Func<string>> bodyphoneNumber = null, Expression<Func<string>> bodylastSignOutAt = null, Expression<Func<string>> bodyposition = null, Expression<Func<bool>> bodyprofileFlag = null, Expression<Func<string>> bodyuserChecklist = null, Expression<Func<int>> bodyideaLikesCount = null, Expression<Func<int>> bodycommentsCount = null, Expression<Func<int>> bodyxpPoints = null, Expression<Func<int>> bodyideasCount = null, Expression<Func<string>> bodyfunnelId = null, Expression<Func<int>> bodylevel = null, Expression<Func<int>> bodyxpLevel = null, Expression<Func<string>> bodyprojectFunnelId = null, Expression<Func<string>> bodychecklistScore = null, Expression<Func<string>> bodyprovider = null, Expression<Func<string>> bodyuid = null, Expression<Func<string>> bodyemailSentAt = null, Expression<Func<bool>> bodyblockAllNotification = null, Expression<Func<string>> bodydbName = null, Expression<Func<string>> bodydeptId = null, Expression<Func<string>> bodydeptName = null, Expression<Func<string>> bodymainImage = null, Expression<Func<string>> bodytempImage = null, Expression<Func<string>> bodyimageConfigs = null, Expression<Func<bool>> bodyimageAutoGenerated = null, Expression<Func<string>> bodyamAccount = null, Expression<Func<string>> bodyuuid = null, Expression<Func<string>> bodypasswordResetAttempts = null, Expression<Func<string>> bodylastPasswordResetAt = null, Expression<Func<string>> bodycustomDomain = null, Expression<Func<string>> bodyuserRoleName = null, Expression<Func<int>> bodytheme = null, Expression<Func<string>> bodyuserType = null, Expression<Func<string>> bodyviewSettings = null, Expression<Func<string>> bodyreadManual = null, Expression<Func<string>> bodyaddIdeaBox = null, Expression<Func<string>> bodyvisitAgent = null, Expression<Func<string>> bodyaddIdea = null, Expression<Func<string>> bodyinvitePeople = null, Expression<Func<string>> bodyaddBoardMission = null, Expression<Func<string>> bodyaddProject = null, Expression<Func<string>> bodycompletedChecklist = null)
        {
            var apiCallPath = String.Format("/general/v1/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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
            body["targetUrl"] = "@listCallbackUrl()";
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