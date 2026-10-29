//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Acceptmission
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AcceptmissionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetcategoriesResponseItem[], ApiConnectionActionConfiguration> Getcategories()
        {
            return new DeferredBodyAction<GetcategoriesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetcategoriesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PostcategoriesResponse, ApiConnectionActionConfiguration> Postcategories(Expression<Func<PostcategoriesInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostcategoriesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/categories";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostcategoriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetcategoriesIdResponse, ApiConnectionActionConfiguration> GetcategoriesId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetcategoriesIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/categories/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetcategoriesIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeletecategoriesId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/categories/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PutcategoriesIdResponse, ApiConnectionActionConfiguration> PutcategoriesId(Expression<Func<string>> id, Expression<Func<PutcategoriesIdInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PutcategoriesIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/categories/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PutcategoriesIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchcategoriesIdResponse, ApiConnectionActionConfiguration> PatchcategoriesId(Expression<Func<string>> id, Expression<Func<PatchcategoriesIdInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PatchcategoriesIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/categories/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PatchcategoriesIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetdepartmentsResponse, ApiConnectionActionConfiguration> Getdepartments()
        {
            return new DeferredBodyAction<GetdepartmentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/departments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetdepartmentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PostdepartmentsResponse, ApiConnectionActionConfiguration> Postdepartments(Expression<Func<PostdepartmentsInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostdepartmentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/departments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostdepartmentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetdepartmentsIdResponse, ApiConnectionActionConfiguration> GetdepartmentsId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetdepartmentsIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/departments/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetdepartmentsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeletedepartmentsId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/departments/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PutdepartmentsIdResponse, ApiConnectionActionConfiguration> PutdepartmentsId(Expression<Func<string>> id, Expression<Func<PutdepartmentsIdInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PutdepartmentsIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/departments/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PutdepartmentsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchdepartmentsIdResponse, ApiConnectionActionConfiguration> PatchdepartmentsId(Expression<Func<string>> id, Expression<Func<PatchdepartmentsIdInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PatchdepartmentsIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/departments/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PatchdepartmentsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetfunnelLanesResponse, ApiConnectionActionConfiguration> GetfunnelLanes()
        {
            return new DeferredBodyAction<GetfunnelLanesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/funnel_lanes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetfunnelLanesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PostfunnelLanesResponse, ApiConnectionActionConfiguration> PostfunnelLanes(Expression<Func<PostfunnelLanesInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostfunnelLanesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/funnel_lanes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostfunnelLanesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetfunnelLanesIdResponse, ApiConnectionActionConfiguration> GetfunnelLanesId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetfunnelLanesIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/funnel_lanes/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetfunnelLanesIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeletefunnelLanesId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/funnel_lanes/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PutfunnelLanesIdResponse, ApiConnectionActionConfiguration> PutfunnelLanesId(Expression<Func<string>> id, Expression<Func<PutfunnelLanesIdInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PutfunnelLanesIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/funnel_lanes/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PutfunnelLanesIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchfunnelLanesIdResponse, ApiConnectionActionConfiguration> PatchfunnelLanesId(Expression<Func<string>> id, Expression<Func<PatchfunnelLanesIdInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PatchfunnelLanesIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/funnel_lanes/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PatchfunnelLanesIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetfunnelsResponse, ApiConnectionActionConfiguration> Getfunnels()
        {
            return new DeferredBodyAction<GetfunnelsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/funnels";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetfunnelsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Postfunnels(Expression<Func<PostfunnelsInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/funnels";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetfunnelsIdResponse, ApiConnectionActionConfiguration> GetfunnelsId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetfunnelsIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/funnels/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetfunnelsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeletefunnelsId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/funnels/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PutfunnelsId(Expression<Func<string>> id, Expression<Func<PutfunnelsIdInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/funnels/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchfunnelsIdResponse, ApiConnectionActionConfiguration> PatchfunnelsId(Expression<Func<string>> id, Expression<Func<PatchfunnelsIdInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PatchfunnelsIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/funnels/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PatchfunnelsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetideasResponse, ApiConnectionActionConfiguration> Getideas()
        {
            return new DeferredBodyAction<GetideasResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/ideas";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetideasResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Postideas(Expression<Func<PostideasInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/ideas";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetideasIdeaIdTasksResponse, ApiConnectionActionConfiguration> GetideasIdeaIdTasks(Expression<Func<string>> ideaId)
        {
            var __workflow_ideaId = WorkflowExpression.Compile(ideaId, nameof(ideaId), required: true);
            return new DeferredBodyAction<GetideasIdeaIdTasksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/ideas/{0}/tasks", __workflow_ideaId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetideasIdeaIdTasksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PostideasIdeaIdTasksResponse, ApiConnectionActionConfiguration> PostideasIdeaIdTasks(Expression<Func<string>> ideaId, Expression<Func<PostideasIdeaIdTasksInput>> body = null)
        {
            var __workflow_ideaId = WorkflowExpression.Compile(ideaId, nameof(ideaId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostideasIdeaIdTasksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/ideas/{0}/tasks", __workflow_ideaId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostideasIdeaIdTasksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetideasId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/ideas/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteideasId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/ideas/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PutideasId(Expression<Func<string>> id, Expression<Func<PutideasIdInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/ideas/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PatchideasId(Expression<Func<string>> id, Expression<Func<PatchideasIdInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/ideas/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetmissionsResponse, ApiConnectionActionConfiguration> Getmissions()
        {
            return new DeferredBodyAction<GetmissionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/missions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetmissionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Postmissions(Expression<Func<PostmissionsInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/missions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetmissionsIdResponse, ApiConnectionActionConfiguration> GetmissionsId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetmissionsIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/missions/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetmissionsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeletemissionsId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/missions/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PutmissionsIdResponse, ApiConnectionActionConfiguration> PutmissionsId(Expression<Func<string>> id, Expression<Func<PutmissionsIdInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PutmissionsIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/missions/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PutmissionsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchmissionsIdResponse, ApiConnectionActionConfiguration> PatchmissionsId(Expression<Func<string>> id, Expression<Func<PatchmissionsIdInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PatchmissionsIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/missions/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PatchmissionsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetprojectsResponse, ApiConnectionActionConfiguration> Getprojects()
        {
            return new DeferredBodyAction<GetprojectsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/projects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetprojectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PostprojectsResponse, ApiConnectionActionConfiguration> Postprojects(Expression<Func<PostprojectsInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostprojectsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/projects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostprojectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetprojectsIdResponse, ApiConnectionActionConfiguration> GetprojectsId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetprojectsIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/projects/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetprojectsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteprojectsId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/projects/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PutprojectsIdResponse, ApiConnectionActionConfiguration> PutprojectsId(Expression<Func<string>> id, Expression<Func<PutprojectsIdInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PutprojectsIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/projects/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PutprojectsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchprojectsIdResponse, ApiConnectionActionConfiguration> PatchprojectsId(Expression<Func<string>> id, Expression<Func<PatchprojectsIdInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PatchprojectsIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/projects/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PatchprojectsIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetprojectsProjectIdTasksResponse, ApiConnectionActionConfiguration> GetprojectsProjectIdTasks(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<GetprojectsProjectIdTasksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/projects/{0}/tasks", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetprojectsProjectIdTasksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PostprojectsProjectIdTasksResponse, ApiConnectionActionConfiguration> PostprojectsProjectIdTasks(Expression<Func<string>> projectId, Expression<Func<PostprojectsProjectIdTasksInput>> body = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostprojectsProjectIdTasksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/projects/{0}/tasks", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostprojectsProjectIdTasksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetTaskBySyncIdResponse, ApiConnectionActionConfiguration> GetTaskBySyncId(Expression<Func<string>> syncId = null)
        {
            var __workflow_syncId = WorkflowExpression.Compile(syncId, nameof(syncId), required: false);
            return new DeferredBodyAction<GetTaskBySyncIdResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<PosttasksResponse, ApiConnectionActionConfiguration> Posttasks(Expression<Func<PosttasksInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PosttasksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PosttasksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GettasksIdResponse, ApiConnectionActionConfiguration> GettasksId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GettasksIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/tasks/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GettasksIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeletetasksId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/tasks/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PatchtasksIdResponse, ApiConnectionActionConfiguration> PatchtasksId(Expression<Func<string>> id, Expression<Func<PatchtasksIdInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PatchtasksIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/tasks/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PatchtasksIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GettopicsResponse, ApiConnectionActionConfiguration> Gettopics()
        {
            return new DeferredBodyAction<GettopicsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/topics";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GettopicsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeletetopicsId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/topics/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetusersResponse, ApiConnectionActionConfiguration> Getusers()
        {
            return new DeferredBodyAction<GetusersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetusersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PostusersResponse, ApiConnectionActionConfiguration> Postusers(Expression<Func<PostusersInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostusersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostusersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetusersGetCompanyResponse, ApiConnectionActionConfiguration> GetusersGetCompany()
        {
            return new DeferredBodyAction<GetusersGetCompanyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/users/get_company";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetusersGetCompanyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<GetusersIdResponse, ApiConnectionActionConfiguration> GetusersId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetusersIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/users/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetusersIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteusersId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/users/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acceptmission")]
        public IBodyWorkflowAction<PutusersIdResponse, ApiConnectionActionConfiguration> PutusersId(Expression<Func<string>> id, Expression<Func<PutusersIdInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PutusersIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/general/v1/users/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PutusersIdResponse>(callPayload);
            });
        }
    }

    public class AcceptmissionTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggerIdeaCreated(Expression<Func<TriggerIdeaCreatedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/ideas/add_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggerIdeaUpdated(Expression<Func<TriggerIdeaUpdatedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/ideas/edit_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggerIdeaDeleted(Expression<Func<TriggerIdeaDeletedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/ideas/delete_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggerProjectCreated(Expression<Func<TriggerProjectCreatedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/projects/add_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggerProjectUpdated(Expression<Func<TriggerProjectUpdatedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/projects/edit_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggerProjectDelete(Expression<Func<TriggerProjectDeleteInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/projects/delete_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggertaskCreated(Expression<Func<TriggertaskCreatedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/tasks/add_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggercategoryCreated(Expression<Func<TriggercategoryCreatedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/categories/add_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggerCategoryUpdated(Expression<Func<TriggerCategoryUpdatedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/categories/edit_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggerCategoryDeleted(Expression<Func<TriggerCategoryDeletedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/categories/delete_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggerdepartmentCreated(Expression<Func<TriggerdepartmentCreatedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/departments/add_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggerdepartmentUpdated(Expression<Func<TriggerdepartmentUpdatedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/departments/edit_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggerdepartmentDeleted(Expression<Func<TriggerdepartmentDeletedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/departments/delete_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggerfunnellaneCreated(Expression<Func<TriggerfunnellaneCreatedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/funnel_lanes/add_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggerfunnellaneUpdated(Expression<Func<TriggerfunnellaneUpdatedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/funnel_lanes/edit_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggerfunnellaneDeleted(Expression<Func<TriggerfunnellaneDeletedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/funnel_lanes/delete_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggerfunnelCreated(Expression<Func<TriggerfunnelCreatedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/funnels/add_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggerfunnelUpdated(Expression<Func<TriggerfunnelUpdatedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/funnels/edit_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggerfunnelDeleted(Expression<Func<TriggerfunnelDeletedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/funnels/delete_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggermissionCreated(Expression<Func<TriggermissionCreatedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/missions/add_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggermissionUpdated(Expression<Func<TriggermissionUpdatedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/missions/edit_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggermissionDeleted(Expression<Func<TriggermissionDeletedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/missions/delete_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggertopicCreated(Expression<Func<TriggertopicCreatedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/topics/add_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggertopicUpdated(Expression<Func<TriggertopicUpdatedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/topics/edit_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggertopicDeleted(Expression<Func<TriggertopicDeletedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/topics/delete_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggertaskUpdated(Expression<Func<TriggertaskUpdatedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/tasks/edit_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggertaskDeleted(Expression<Func<TriggertaskDeletedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/tasks/delete_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggeruserCreated(Expression<Func<TriggeruserCreatedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/users/add_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggeruserUpdated(Expression<Func<TriggeruserUpdatedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/users/edit_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggeruserDeleted(Expression<Func<TriggeruserDeletedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/general/v1/users/delete_redirect_url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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

    public class PostcategoriesInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("position")]
        public int? Position { get; set; }

        [JsonProperty("chip_color")]
        public string ChipColor { get; set; }

        [JsonProperty("missions_id")]
        public string MissionsId { get; set; }

        [JsonProperty("company_id")]
        public int? CompanyId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        [JsonProperty("temp_image")]
        public string TempImage { get; set; }

        [JsonProperty("main_image")]
        public string MainImage { get; set; }

        [JsonProperty("image_configs")]
        public string ImageConfigs { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("updated_by")]
        public string UpdatedBy { get; set; }

        [JsonProperty("record_url")]
        public string RecordUrl { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }
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

    public class PutcategoriesIdInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("position")]
        public int? Position { get; set; }

        [JsonProperty("chip_color")]
        public string ChipColor { get; set; }

        [JsonProperty("missions_id")]
        public string MissionsId { get; set; }

        [JsonProperty("company_id")]
        public int? CompanyId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        [JsonProperty("temp_image")]
        public string TempImage { get; set; }

        [JsonProperty("main_image")]
        public string MainImage { get; set; }

        [JsonProperty("image_configs")]
        public string ImageConfigs { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("updated_by")]
        public string UpdatedBy { get; set; }

        [JsonProperty("record_url")]
        public string RecordUrl { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }
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

    public class PatchcategoriesIdInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }
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

    public class PostdepartmentsInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("position")]
        public int? Position { get; set; }
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

    public class PutdepartmentsIdInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("position")]
        public int? Position { get; set; }

        [JsonProperty("company_id")]
        public int? CompanyId { get; set; }

        [JsonProperty("ideas_count")]
        public int? IdeasCount { get; set; }

        [JsonProperty("projects_count")]
        public int? ProjectsCount { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        [JsonProperty("temp_image")]
        public string TempImage { get; set; }

        [JsonProperty("main_image")]
        public string MainImage { get; set; }

        [JsonProperty("image_configs")]
        public string ImageConfigs { get; set; }

        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        [JsonProperty("updated_by")]
        public string UpdatedBy { get; set; }

        [JsonProperty("record_url")]
        public string RecordUrl { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }
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

    public class PatchdepartmentsIdInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("position")]
        public int? Position { get; set; }
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

    public class PostfunnelLanesInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }
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

    public class PutfunnelLanesIdInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("funnel_stage_type")]
        public int? FunnelStageType { get; set; }

        [JsonProperty("stage_type")]
        public int? StageType { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("deadline")]
        public int? Deadline { get; set; }

        [JsonProperty("position")]
        public int? Position { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("modified_by")]
        public string ModifiedBy { get; set; }

        [JsonProperty("funnel_id")]
        public int? FunnelId { get; set; }

        [JsonProperty("funnel_status_id")]
        public int? FunnelStatusId { get; set; }

        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

        [JsonProperty("enable_notification")]
        public bool? EnableNotification { get; set; }

        [JsonProperty("ideas_count")]
        public int? IdeasCount { get; set; }

        [JsonProperty("projects_count")]
        public int? ProjectsCount { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("show_in_graph")]
        public bool? ShowInGraph { get; set; }

        [JsonProperty("show_in_bubble")]
        public bool? ShowInBubble { get; set; }

        [JsonProperty("confetti_type")]
        public int? ConfettiType { get; set; }

        [JsonProperty("automation_owner_id")]
        public string AutomationOwnerId { get; set; }
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

    public class PatchfunnelLanesIdInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }
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

    public class PostfunnelsInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("funnel_type")]
        public int? FunnelType { get; set; }
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

    public class PutfunnelsIdInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("company_id")]
        public int? CompanyId { get; set; }

        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        [JsonProperty("funnel_type")]
        public int? FunnelType { get; set; }

        [JsonProperty("modified_by")]
        public int? ModifiedBy { get; set; }

        [JsonProperty("privacy_setting")]
        public int? PrivacySetting { get; set; }

        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

        [JsonProperty("block_funnel_notification")]
        public bool? BlockFunnelNotification { get; set; }

        [JsonProperty("ideas_count")]
        public int? IdeasCount { get; set; }

        [JsonProperty("projects_count")]
        public int? ProjectsCount { get; set; }

        [JsonProperty("hidden")]
        public bool? Hidden { get; set; }

        [JsonProperty("set_x_axis")]
        public string SetXAxis { get; set; }

        [JsonProperty("set_y_axis")]
        public string SetYAxis { get; set; }

        [JsonProperty("set_z_axis")]
        public string SetZAxis { get; set; }

        [JsonProperty("set_axis_color")]
        public string SetAxisColor { get; set; }

        [JsonProperty("department_id")]
        public string DepartmentId { get; set; }

        [JsonProperty("project_funnel_id")]
        public int? ProjectFunnelId { get; set; }

        [JsonProperty("from_script")]
        public string FromScript { get; set; }

        [JsonProperty("user_privacy_setting")]
        public int? UserPrivacySetting { get; set; }

        [JsonProperty("include_in_dashboard")]
        public bool? IncludeInDashboard { get; set; }

        [JsonProperty("record_url")]
        public string RecordUrl { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }
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

    public class PatchfunnelsIdInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("funnel_type")]
        public int? FunnelType { get; set; }
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

    public class PostideasInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("funnel_id")]
        public int? FunnelId { get; set; }

        [JsonProperty("mission_id")]
        public int? MissionId { get; set; }
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

    public class PostideasIdeaIdTasksInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("status")]
        public int? Status { get; set; }
    }

    public class PutideasIdInput
    {
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        [JsonProperty("round_id")]
        public int? RoundId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("browser")]
        public string Browser { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("screen_res")]
        public string ScreenRes { get; set; }

        [JsonProperty("user_ip")]
        public string UserIp { get; set; }

        [JsonProperty("comments_count")]
        public int? CommentsCount { get; set; }

        [JsonProperty("review_scores_count")]
        public int? ReviewScoresCount { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("stage")]
        public int? Stage { get; set; }

        [JsonProperty("department_id")]
        public string DepartmentId { get; set; }

        [JsonProperty("status_id")]
        public string StatusId { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("idea_creator")]
        public string IdeaCreator { get; set; }

        [JsonProperty("ideation_idea_category_id")]
        public string IdeationIdeaCategoryId { get; set; }

        [JsonProperty("board_idea_category_id")]
        public string BoardIdeaCategoryId { get; set; }

        [JsonProperty("company_id")]
        public int? CompanyId { get; set; }

        [JsonProperty("idea_likes_count")]
        public int? IdeaLikesCount { get; set; }

        [JsonProperty("bookmark")]
        public bool? Bookmark { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }

        [JsonProperty("idea_scores_count")]
        public int? IdeaScoresCount { get; set; }

        [JsonProperty("likes_count")]
        public int? LikesCount { get; set; }

        [JsonProperty("board_id")]
        public string BoardId { get; set; }

        [JsonProperty("mission_id")]
        public string MissionId { get; set; }

        [JsonProperty("creator_name")]
        public string CreatorName { get; set; }

        [JsonProperty("tags_count")]
        public int? TagsCount { get; set; }

        [JsonProperty("funnel_id")]
        public string FunnelId { get; set; }

        [JsonProperty("funnel_stage_id")]
        public string FunnelStageId { get; set; }

        [JsonProperty("funnel_status_id")]
        public string FunnelStatusId { get; set; }

        [JsonProperty("idea_deadline")]
        public string IdeaDeadline { get; set; }

        [JsonProperty("deadline_notification")]
        public bool? DeadlineNotification { get; set; }

        [JsonProperty("idea_views")]
        public int? IdeaViews { get; set; }

        [JsonProperty("revenue")]
        public string Revenue { get; set; }

        [JsonProperty("cost")]
        public string Cost { get; set; }

        [JsonProperty("profit")]
        public string Profit { get; set; }

        [JsonProperty("status_name")]
        public string StatusName { get; set; }

        [JsonProperty("idea_scores")]
        public string IdeaScores { get; set; }

        [JsonProperty("approved_at")]
        public string ApprovedAt { get; set; }

        [JsonProperty("denied_at")]
        public string DeniedAt { get; set; }

        [JsonProperty("admin_comments")]
        public string AdminComments { get; set; }

        [JsonProperty("is_child")]
        public bool? IsChild { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("temp_image")]
        public string TempImage { get; set; }

        [JsonProperty("main_image")]
        public string MainImage { get; set; }

        [JsonProperty("image_configs")]
        public string ImageConfigs { get; set; }

        [JsonProperty("score_complete_score")]
        public int? ScoreCompleteScore { get; set; }

        [JsonProperty("enrichment_score")]
        public int? EnrichmentScore { get; set; }

        [JsonProperty("engagement_score")]
        public int? EngagementScore { get; set; }

        [JsonProperty("opportunity_score")]
        public int? OpportunityScore { get; set; }

        [JsonProperty("trend_score")]
        public int? TrendScore { get; set; }

        [JsonProperty("cleaned_text")]
        public string CleanedText { get; set; }

        [JsonProperty("duplicate_ideas_count")]
        public int? DuplicateIdeasCount { get; set; }

        [JsonProperty("sidekiq_duplicate_ideas_count")]
        public string SidekiqDuplicateIdeasCount { get; set; }

        [JsonProperty("ai_created")]
        public string AiCreated { get; set; }

        [JsonProperty("idea_type")]
        public string IdeaType { get; set; }

        [JsonProperty("from_script")]
        public string FromScript { get; set; }

        [JsonProperty("embedding")]
        public string Embedding { get; set; }

        [JsonProperty("reason_text")]
        public string ReasonText { get; set; }

        [JsonProperty("category_text")]
        public string CategoryText { get; set; }

        [JsonProperty("canvass_id")]
        public string CanvassId { get; set; }

        [JsonProperty("budget_total")]
        public string BudgetTotal { get; set; }

        [JsonProperty("budget_spend")]
        public string BudgetSpend { get; set; }

        [JsonProperty("budget_result")]
        public string BudgetResult { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tag_text")]
        public string TagText { get; set; }

        [JsonProperty("innovation_type_id")]
        public string InnovationTypeId { get; set; }

        [JsonProperty("innovation_type_text")]
        public string InnovationTypeText { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("record_url")]
        public string RecordUrl { get; set; }

        [JsonProperty("description_enriched")]
        public string DescriptionEnriched { get; set; }
    }

    public class PatchideasIdInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("funnel_id")]
        public int? FunnelId { get; set; }
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

    public class PostmissionsInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("hidden")]
        public bool? Hidden { get; set; }
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

    public class PutmissionsIdInput
    {
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        [JsonProperty("company_id")]
        public int? CompanyId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("is_anonymous")]
        public bool? IsAnonymous { get; set; }

        [JsonProperty("ending_note")]
        public string EndingNote { get; set; }

        [JsonProperty("mission_pic")]
        public string MissionPic { get; set; }

        [JsonProperty("team_size")]
        public int? TeamSize { get; set; }

        [JsonProperty("status")]
        public int? Status { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("from_name")]
        public string FromName { get; set; }

        [JsonProperty("is_template")]
        public bool? IsTemplate { get; set; }

        [JsonProperty("end_duration")]
        public int? EndDuration { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("is_tryout")]
        public bool? IsTryout { get; set; }

        [JsonProperty("template_type")]
        public int? TemplateType { get; set; }

        [JsonProperty("is_open")]
        public bool? IsOpen { get; set; }

        [JsonProperty("mission_type")]
        public int? MissionType { get; set; }

        [JsonProperty("published_once")]
        public string PublishedOnce { get; set; }

        [JsonProperty("inbox_question")]
        public string InboxQuestion { get; set; }

        [JsonProperty("privacy_setting")]
        public string PrivacySetting { get; set; }

        [JsonProperty("agent_profile")]
        public string AgentProfile { get; set; }

        [JsonProperty("department_id")]
        public string DepartmentId { get; set; }

        [JsonProperty("enable_report")]
        public bool? EnableReport { get; set; }

        [JsonProperty("ideas_count")]
        public int? IdeasCount { get; set; }

        [JsonProperty("likes_count")]
        public int? LikesCount { get; set; }

        [JsonProperty("comments_count")]
        public int? CommentsCount { get; set; }

        [JsonProperty("funnel_id")]
        public string FunnelId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("enable_inbound_email")]
        public bool? EnableInboundEmail { get; set; }

        [JsonProperty("custom_fields")]
        public JToken CustomFields { get; set; }

        [JsonProperty("department_name")]
        public string DepartmentName { get; set; }

        [JsonProperty("notification_type")]
        public string NotificationType { get; set; }

        [JsonProperty("notification_frequency")]
        public string NotificationFrequency { get; set; }

        [JsonProperty("notification_text")]
        public string NotificationText { get; set; }

        [JsonProperty("position")]
        public int? Position { get; set; }

        [JsonProperty("mission_views")]
        public string MissionViews { get; set; }

        [JsonProperty("temp_image")]
        public string TempImage { get; set; }

        [JsonProperty("main_image")]
        public string MainImage { get; set; }

        [JsonProperty("image_configs")]
        public string ImageConfigs { get; set; }

        [JsonProperty("allow_ai_ideas")]
        public string AllowAiIdeas { get; set; }

        [JsonProperty("ai_mission_type")]
        public string AiMissionType { get; set; }

        [JsonProperty("from_script")]
        public string FromScript { get; set; }

        [JsonProperty("idea_attachments_allowed")]
        public string IdeaAttachmentsAllowed { get; set; }

        [JsonProperty("video_link")]
        public string VideoLink { get; set; }

        [JsonProperty("hidden")]
        public string Hidden { get; set; }

        [JsonProperty("confetti_type")]
        public string ConfettiType { get; set; }

        [JsonProperty("enable")]
        public string Enable { get; set; }

        [JsonProperty("add_attachment")]
        public string AddAttachment { get; set; }

        [JsonProperty("add_comment")]
        public string AddComment { get; set; }

        [JsonProperty("record_url")]
        public string RecordUrl { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("idea_custom_fields")]
        public string IdeaCustomFields { get; set; }
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

    public class PatchmissionsIdInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("hidden")]
        public bool? Hidden { get; set; }
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

    public class PostprojectsInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("funnel_id")]
        public int? FunnelId { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }
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

    public class PutprojectsIdInput
    {
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
        public string UserId { get; set; }

        [JsonProperty("stage_id")]
        public string StageId { get; set; }

        [JsonProperty("project_manager_id")]
        public string ProjectManagerId { get; set; }

        [JsonProperty("business_owner_id")]
        public string BusinessOwnerId { get; set; }

        [JsonProperty("progress")]
        public string Progress { get; set; }

        [JsonProperty("company_id")]
        public string CompanyId { get; set; }

        [JsonProperty("comments_count")]
        public string CommentsCount { get; set; }

        [JsonProperty("project_score")]
        public string ProjectScore { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("modified_by")]
        public int? ModifiedBy { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }

        [JsonProperty("tags_count")]
        public int? TagsCount { get; set; }

        [JsonProperty("funnel_id")]
        public string FunnelId { get; set; }

        [JsonProperty("funnel_stage_id")]
        public string FunnelStageId { get; set; }

        [JsonProperty("funnel_status_id")]
        public string FunnelStatusId { get; set; }

        [JsonProperty("stage_deadline")]
        public string StageDeadline { get; set; }

        [JsonProperty("deadline_notification")]
        public string DeadlineNotification { get; set; }

        [JsonProperty("status_name")]
        public string StatusName { get; set; }

        [JsonProperty("approved_at")]
        public string ApprovedAt { get; set; }

        [JsonProperty("denied_at")]
        public string DeniedAt { get; set; }

        [JsonProperty("am_scores")]
        public string AmScores { get; set; }

        [JsonProperty("project_revenue")]
        public string ProjectRevenue { get; set; }

        [JsonProperty("project_cost")]
        public string ProjectCost { get; set; }

        [JsonProperty("project_profit")]
        public string ProjectProfit { get; set; }

        [JsonProperty("admin_comments")]
        public string AdminComments { get; set; }

        [JsonProperty("temp_image")]
        public string TempImage { get; set; }

        [JsonProperty("main_image")]
        public string MainImage { get; set; }

        [JsonProperty("image_configs")]
        public string ImageConfigs { get; set; }

        [JsonProperty("from_script")]
        public string FromScript { get; set; }

        [JsonProperty("reason_text")]
        public string ReasonText { get; set; }

        [JsonProperty("category_text")]
        public string CategoryText { get; set; }

        [JsonProperty("canvass_id")]
        public string CanvassId { get; set; }

        [JsonProperty("budget_total")]
        public string BudgetTotal { get; set; }

        [JsonProperty("budget_spend")]
        public string BudgetSpend { get; set; }

        [JsonProperty("budget_result")]
        public string BudgetResult { get; set; }

        [JsonProperty("tag_text")]
        public string TagText { get; set; }

        [JsonProperty("estimated_time")]
        public string EstimatedTime { get; set; }

        [JsonProperty("total_time_spend")]
        public string TotalTimeSpend { get; set; }

        [JsonProperty("total_time")]
        public string TotalTime { get; set; }

        [JsonProperty("innovation_type_id")]
        public string InnovationTypeId { get; set; }

        [JsonProperty("innovation_type_text")]
        public string InnovationTypeText { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }

        [JsonProperty("record_url")]
        public string RecordUrl { get; set; }

        [JsonProperty("description_enriched")]
        public string DescriptionEnriched { get; set; }

        [JsonProperty("custom_field_values")]
        public string CustomFieldValues { get; set; }
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

    public class PatchprojectsIdInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
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

    public class PostprojectsProjectIdTasksInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("status")]
        public int? Status { get; set; }
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

    public class PosttasksInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("status")]
        public int? Status { get; set; }
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

    public class PatchtasksIdInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("status")]
        public int? Status { get; set; }

        [JsonProperty("sync_id")]
        public string SyncId { get; set; }
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

    public class PostusersInput
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("position")]
        public int? Position { get; set; }
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

    public class PutusersIdInput
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("profile_pic")]
        public string ProfilePic { get; set; }

        [JsonProperty("points")]
        public int? Points { get; set; }

        [JsonProperty("company_id")]
        public int? CompanyId { get; set; }

        [JsonProperty("user_role_id")]
        public int? UserRoleId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("last_sign_out_at")]
        public string LastSignOutAt { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("profile_flag")]
        public bool? ProfileFlag { get; set; }

        [JsonProperty("user_checklist")]
        public string UserChecklist { get; set; }

        [JsonProperty("idea_likes_count")]
        public int? IdeaLikesCount { get; set; }

        [JsonProperty("comments_count")]
        public int? CommentsCount { get; set; }

        [JsonProperty("xp_points")]
        public int? XpPoints { get; set; }

        [JsonProperty("ideas_count")]
        public int? IdeasCount { get; set; }

        [JsonProperty("funnel_id")]
        public string FunnelId { get; set; }

        [JsonProperty("level")]
        public int? Level { get; set; }

        [JsonProperty("xp_level")]
        public int? XpLevel { get; set; }

        [JsonProperty("project_funnel_id")]
        public string ProjectFunnelId { get; set; }

        [JsonProperty("checklist_score")]
        public string ChecklistScore { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("email_sent_at")]
        public string EmailSentAt { get; set; }

        [JsonProperty("block_all_notification")]
        public bool? BlockAllNotification { get; set; }

        [JsonProperty("db_name")]
        public string DbName { get; set; }

        [JsonProperty("dept_id")]
        public string DeptId { get; set; }

        [JsonProperty("dept_name")]
        public string DeptName { get; set; }

        [JsonProperty("main_image")]
        public string MainImage { get; set; }

        [JsonProperty("temp_image")]
        public string TempImage { get; set; }

        [JsonProperty("image_configs")]
        public string ImageConfigs { get; set; }

        [JsonProperty("image_auto_generated")]
        public bool? ImageAutoGenerated { get; set; }

        [JsonProperty("am_account")]
        public string AmAccount { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("password_reset_attempts")]
        public string PasswordResetAttempts { get; set; }

        [JsonProperty("last_password_reset_at")]
        public string LastPasswordResetAt { get; set; }

        [JsonProperty("custom_domain")]
        public string CustomDomain { get; set; }

        [JsonProperty("user_role_name")]
        public string UserRoleName { get; set; }

        [JsonProperty("theme")]
        public int? Theme { get; set; }

        [JsonProperty("user_type")]
        public string UserType { get; set; }

        [JsonProperty("view_settings")]
        public string ViewSettings { get; set; }

        [JsonProperty("read_manual")]
        public string ReadManual { get; set; }

        [JsonProperty("add_idea_box")]
        public string AddIdeaBox { get; set; }

        [JsonProperty("visit_agent")]
        public string VisitAgent { get; set; }

        [JsonProperty("add_idea")]
        public string AddIdea { get; set; }

        [JsonProperty("invite_people")]
        public string InvitePeople { get; set; }

        [JsonProperty("add_board_mission")]
        public string AddBoardMission { get; set; }

        [JsonProperty("add_project")]
        public string AddProject { get; set; }

        [JsonProperty("completed_checklist")]
        public string CompletedChecklist { get; set; }
    }

    public class TriggerIdeaCreatedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggerIdeaUpdatedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggerIdeaDeletedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggerProjectCreatedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggerProjectUpdatedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggerProjectDeleteInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggertaskCreatedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggercategoryCreatedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggerCategoryUpdatedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggerCategoryDeletedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggerdepartmentCreatedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggerdepartmentUpdatedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggerdepartmentDeletedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggerfunnellaneCreatedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggerfunnellaneUpdatedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggerfunnellaneDeletedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggerfunnelCreatedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggerfunnelUpdatedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggerfunnelDeletedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggermissionCreatedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggermissionUpdatedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggermissionDeletedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggertopicCreatedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggertopicUpdatedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggertopicDeletedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggertaskUpdatedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggertaskDeletedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggeruserCreatedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggeruserUpdatedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class TriggeruserDeletedInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";
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