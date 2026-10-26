//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Instatusip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InstatusipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<PagesGetResponseItem[], ApiConnectionActionConfiguration> PagesGet(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<PagesGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/pages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<PagesGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<PagePostResponse, ApiConnectionActionConfiguration> Page(Expression<Func<PagePostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PagePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PagePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<PageDeleteResponse, ApiConnectionActionConfiguration> PageDelete(Expression<Func<string>> pageId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            return new DeferredBodyAction<PageDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/{0}", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PageDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<PagePutResponse, ApiConnectionActionConfiguration> PagePut(Expression<Func<string>> pageId, Expression<Func<PagePutInput>> body = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PagePutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/{0}", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PagePutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<ComponentsGetResponseItem[], ApiConnectionActionConfiguration> ComponentsGet(Expression<Func<string>> pageId, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<ComponentsGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/components", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<ComponentsGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<ComponentPostResponse, ApiConnectionActionConfiguration> Component(Expression<Func<string>> pageId, Expression<Func<ComponentPostInput>> body = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ComponentPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/components", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ComponentPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<ComponentGetResponse, ApiConnectionActionConfiguration> ComponentGet(Expression<Func<string>> pageId, Expression<Func<string>> componentId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_componentId = WorkflowExpression.Compile(componentId, nameof(componentId), required: true);
            return new DeferredBodyAction<ComponentGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/components/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_componentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ComponentGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<ComponentDeleteResponse, ApiConnectionActionConfiguration> ComponentDelete(Expression<Func<string>> pageId, Expression<Func<string>> componentId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_componentId = WorkflowExpression.Compile(componentId, nameof(componentId), required: true);
            return new DeferredBodyAction<ComponentDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/components/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_componentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ComponentDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<ComponentPutResponse, ApiConnectionActionConfiguration> ComponentPut(Expression<Func<string>> pageId, Expression<Func<string>> componentId, Expression<Func<ComponentPutInput>> body = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_componentId = WorkflowExpression.Compile(componentId, nameof(componentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ComponentPutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/components/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_componentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ComponentPutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentsGetResponseItem[], ApiConnectionActionConfiguration> IncidentsGet(Expression<Func<string>> pageId, Expression<Func<string>> status = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<IncidentsGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/incidents", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<IncidentsGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentPostResponse, ApiConnectionActionConfiguration> Incident(Expression<Func<string>> pageId, Expression<Func<IncidentPostInput>> body = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IncidentPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/incidents", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IncidentPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentGetResponse, ApiConnectionActionConfiguration> IncidentGet(Expression<Func<string>> pageId, Expression<Func<string>> incidentId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_incidentId = WorkflowExpression.Compile(incidentId, nameof(incidentId), required: true);
            return new DeferredBodyAction<IncidentGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/incidents/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_incidentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IncidentGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentDeleteResponse, ApiConnectionActionConfiguration> IncidentDelete(Expression<Func<string>> pageId, Expression<Func<string>> incidentId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_incidentId = WorkflowExpression.Compile(incidentId, nameof(incidentId), required: true);
            return new DeferredBodyAction<IncidentDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/incidents/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_incidentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IncidentDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentPutResponse, ApiConnectionActionConfiguration> IncidentPut(Expression<Func<string>> pageId, Expression<Func<string>> incidentId, Expression<Func<IncidentPutInput>> body = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_incidentId = WorkflowExpression.Compile(incidentId, nameof(incidentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IncidentPutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/incidents/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_incidentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IncidentPutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentTemplatePostResponse, ApiConnectionActionConfiguration> IncidentTemplate(Expression<Func<string>> pageId, Expression<Func<string>> template)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: true);
            return new DeferredBodyAction<IncidentTemplatePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/{0}/incidents/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_template.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IncidentTemplatePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentUpdateGetResponse, ApiConnectionActionConfiguration> IncidentUpdateGet(Expression<Func<string>> pageId, Expression<Func<string>> incidentId, Expression<Func<string>> incidentUpdateId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_incidentId = WorkflowExpression.Compile(incidentId, nameof(incidentId), required: true);
            var __workflow_incidentUpdateId = WorkflowExpression.Compile(incidentUpdateId, nameof(incidentUpdateId), required: true);
            return new DeferredBodyAction<IncidentUpdateGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/incidents/{1}/incident-updates/{2}", __workflow_pageId.WithUrlEncoding(1), __workflow_incidentId.WithUrlEncoding(1), __workflow_incidentUpdateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IncidentUpdateGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentUpdateDeleteResponse, ApiConnectionActionConfiguration> IncidentUpdateDelete(Expression<Func<string>> pageId, Expression<Func<string>> incidentId, Expression<Func<string>> incidentUpdateId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_incidentId = WorkflowExpression.Compile(incidentId, nameof(incidentId), required: true);
            var __workflow_incidentUpdateId = WorkflowExpression.Compile(incidentUpdateId, nameof(incidentUpdateId), required: true);
            return new DeferredBodyAction<IncidentUpdateDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/incidents/{1}/incident-updates/{2}", __workflow_pageId.WithUrlEncoding(1), __workflow_incidentId.WithUrlEncoding(1), __workflow_incidentUpdateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IncidentUpdateDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentUpdatePutResponse, ApiConnectionActionConfiguration> IncidentUpdatePut(Expression<Func<string>> pageId, Expression<Func<string>> incidentId, Expression<Func<string>> incidentUpdateId, Expression<Func<IncidentUpdatePutInput>> body = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_incidentId = WorkflowExpression.Compile(incidentId, nameof(incidentId), required: true);
            var __workflow_incidentUpdateId = WorkflowExpression.Compile(incidentUpdateId, nameof(incidentUpdateId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IncidentUpdatePutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/incidents/{1}/incident-updates/{2}", __workflow_pageId.WithUrlEncoding(1), __workflow_incidentId.WithUrlEncoding(1), __workflow_incidentUpdateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IncidentUpdatePutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentUpdatePostResponse, ApiConnectionActionConfiguration> IncidentUpdate(Expression<Func<string>> pageId, Expression<Func<string>> incidentId, Expression<Func<IncidentUpdatePostInput>> body = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_incidentId = WorkflowExpression.Compile(incidentId, nameof(incidentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IncidentUpdatePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/incidents/{1}/incident-updates", __workflow_pageId.WithUrlEncoding(1), __workflow_incidentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IncidentUpdatePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentUpdateTemplatePostResponse, ApiConnectionActionConfiguration> IncidentUpdateTemplate(Expression<Func<string>> pageId, Expression<Func<string>> incidentId, Expression<Func<string>> template)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_incidentId = WorkflowExpression.Compile(incidentId, nameof(incidentId), required: true);
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: true);
            return new DeferredBodyAction<IncidentUpdateTemplatePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/{0}/incidents/{1}/incident-updates/{2}", __workflow_pageId.WithUrlEncoding(1), __workflow_incidentId.WithUrlEncoding(1), __workflow_template.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IncidentUpdateTemplatePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenancesGetResponseItem[], ApiConnectionActionConfiguration> MaintenancesGet(Expression<Func<string>> pageId, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<MaintenancesGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/maintenances", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<MaintenancesGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenancePostResponse, ApiConnectionActionConfiguration> Maintenance(Expression<Func<string>> pageId, Expression<Func<MaintenancePostInput>> body = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<MaintenancePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/maintenances", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MaintenancePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenanceGetResponse, ApiConnectionActionConfiguration> MaintenanceGet(Expression<Func<string>> pageId, Expression<Func<string>> maintenanceId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_maintenanceId = WorkflowExpression.Compile(maintenanceId, nameof(maintenanceId), required: true);
            return new DeferredBodyAction<MaintenanceGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/maintenances/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_maintenanceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MaintenanceGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenanceDeleteResponse, ApiConnectionActionConfiguration> MaintenanceDelete(Expression<Func<string>> pageId, Expression<Func<string>> maintenanceId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_maintenanceId = WorkflowExpression.Compile(maintenanceId, nameof(maintenanceId), required: true);
            return new DeferredBodyAction<MaintenanceDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/maintenances/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_maintenanceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MaintenanceDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenancePutResponse, ApiConnectionActionConfiguration> MaintenancePut(Expression<Func<string>> pageId, Expression<Func<string>> maintenanceId, Expression<Func<MaintenancePutInput>> body = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_maintenanceId = WorkflowExpression.Compile(maintenanceId, nameof(maintenanceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<MaintenancePutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/maintenances/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_maintenanceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MaintenancePutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenanceUpdateGetResponse, ApiConnectionActionConfiguration> MaintenanceUpdateGet(Expression<Func<string>> pageId, Expression<Func<string>> maintenanceId, Expression<Func<string>> maintenanceUpdateId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_maintenanceId = WorkflowExpression.Compile(maintenanceId, nameof(maintenanceId), required: true);
            var __workflow_maintenanceUpdateId = WorkflowExpression.Compile(maintenanceUpdateId, nameof(maintenanceUpdateId), required: true);
            return new DeferredBodyAction<MaintenanceUpdateGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/maintenances/{1}/maintenance-updates/{2}", __workflow_pageId.WithUrlEncoding(1), __workflow_maintenanceId.WithUrlEncoding(1), __workflow_maintenanceUpdateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MaintenanceUpdateGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenanceUpdateDeleteResponse, ApiConnectionActionConfiguration> MaintenanceUpdateDelete(Expression<Func<string>> pageId, Expression<Func<string>> maintenanceId, Expression<Func<string>> maintenanceUpdateId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_maintenanceId = WorkflowExpression.Compile(maintenanceId, nameof(maintenanceId), required: true);
            var __workflow_maintenanceUpdateId = WorkflowExpression.Compile(maintenanceUpdateId, nameof(maintenanceUpdateId), required: true);
            return new DeferredBodyAction<MaintenanceUpdateDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/maintenances/{1}/maintenance-updates/{2}", __workflow_pageId.WithUrlEncoding(1), __workflow_maintenanceId.WithUrlEncoding(1), __workflow_maintenanceUpdateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MaintenanceUpdateDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenanceUpdatePutResponse, ApiConnectionActionConfiguration> MaintenanceUpdatePut(Expression<Func<string>> pageId, Expression<Func<string>> maintenanceId, Expression<Func<string>> maintenanceUpdateId, Expression<Func<MaintenanceUpdatePutInput>> body = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_maintenanceId = WorkflowExpression.Compile(maintenanceId, nameof(maintenanceId), required: true);
            var __workflow_maintenanceUpdateId = WorkflowExpression.Compile(maintenanceUpdateId, nameof(maintenanceUpdateId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<MaintenanceUpdatePutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/maintenances/{1}/maintenance-updates/{2}", __workflow_pageId.WithUrlEncoding(1), __workflow_maintenanceId.WithUrlEncoding(1), __workflow_maintenanceUpdateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MaintenanceUpdatePutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenanceUpdatePostResponse, ApiConnectionActionConfiguration> MaintenanceUpdate(Expression<Func<string>> pageId, Expression<Func<string>> maintenanceId, Expression<Func<MaintenanceUpdatePostInput>> body = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_maintenanceId = WorkflowExpression.Compile(maintenanceId, nameof(maintenanceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<MaintenanceUpdatePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/maintenances/{1}/maintenance-updates", __workflow_pageId.WithUrlEncoding(1), __workflow_maintenanceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MaintenanceUpdatePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<PageTemplatesGetResponseItem[], ApiConnectionActionConfiguration> PageTemplatesGet(Expression<Func<string>> pageId, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<PageTemplatesGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/templates", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<PageTemplatesGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<TemplatePostResponse, ApiConnectionActionConfiguration> Template(Expression<Func<string>> pageId, Expression<Func<TemplatePostInput>> body = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TemplatePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/templates", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TemplatePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<TemplateGetResponse, ApiConnectionActionConfiguration> TemplateGet(Expression<Func<string>> pageId, Expression<Func<string>> templateId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            return new DeferredBodyAction<TemplateGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/templates/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TemplateGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<TemplateDeleteResponse, ApiConnectionActionConfiguration> TemplateDelete(Expression<Func<string>> pageId, Expression<Func<string>> templateId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            return new DeferredBodyAction<TemplateDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/templates/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TemplateDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<TemplatePutResponse, ApiConnectionActionConfiguration> TemplatePut(Expression<Func<string>> pageId, Expression<Func<string>> templateId, Expression<Func<TemplatePutInput>> body = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TemplatePutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/templates/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TemplatePutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<TeammatesGetResponseItem[], ApiConnectionActionConfiguration> TeammatesGet(Expression<Func<string>> pageId, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<TeammatesGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/team", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<TeammatesGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> TeamMember(Expression<Func<string>> pageId, Expression<Func<TeamMemberPostInput>> body = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/team", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> TeamMemberDelete(Expression<Func<string>> pageId, Expression<Func<string>> memberId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_memberId = WorkflowExpression.Compile(memberId, nameof(memberId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/team/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_memberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<SubscribersGetResponseItem[], ApiConnectionActionConfiguration> SubscribersGet(Expression<Func<string>> pageId, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<SubscribersGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/subscribers", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<SubscribersGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<SubscriberPostResponse, ApiConnectionActionConfiguration> Subscriber(Expression<Func<string>> pageId, Expression<Func<SubscriberPostInput>> body = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SubscriberPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/subscribers", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SubscriberPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> SubscriberDelete(Expression<Func<string>> pageId, Expression<Func<string>> subscriberId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_subscriberId = WorkflowExpression.Compile(subscriberId, nameof(subscriberId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/subscribers/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_subscriberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class InstatusipTriggers([ConnectionName] string connectionId)
    {
    }

    public class PagesGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("faviconUrl")]
        public string FaviconUrl { get; set; }

        [JsonProperty("websiteUrl")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("customDomain")]
        public string CustomDomain { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subscribeBySms")]
        public bool SubscribeBySms { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("useLargeHeader")]
        public bool UseLargeHeader { get; set; }

        [JsonProperty("brandColor")]
        public string BrandColor { get; set; }

        [JsonProperty("okColor")]
        public string OkColor { get; set; }

        [JsonProperty("disruptedColor")]
        public string DisruptedColor { get; set; }

        [JsonProperty("degradedColor")]
        public string DegradedColor { get; set; }

        [JsonProperty("downColor")]
        public string DownColor { get; set; }

        [JsonProperty("noticeColor")]
        public string NoticeColor { get; set; }

        [JsonProperty("unknownColor")]
        public string UnknownColor { get; set; }

        [JsonProperty("googleAnalytics")]
        public string GoogleAnalytics { get; set; }

        [JsonProperty("smsService")]
        public string SmsService { get; set; }

        [JsonProperty("htmlInMeta")]
        public string HtmlInMeta { get; set; }

        [JsonProperty("htmlAboveHeader")]
        public string HtmlAboveHeader { get; set; }

        [JsonProperty("htmlBelowHeader")]
        public string HtmlBelowHeader { get; set; }

        [JsonProperty("htmlAboveFooter")]
        public string HtmlAboveFooter { get; set; }

        [JsonProperty("htmlBelowFooter")]
        public string HtmlBelowFooter { get; set; }

        [JsonProperty("htmlBelowSummary")]
        public string HtmlBelowSummary { get; set; }

        [JsonProperty("launchDate")]
        public string LaunchDate { get; set; }

        [JsonProperty("cssGlobal")]
        public string CssGlobal { get; set; }

        [JsonProperty("onboarded")]
        public string Onboarded { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class PagePostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("faviconUrl")]
        public string FaviconUrl { get; set; }

        [JsonProperty("websiteUrl")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("googleAnalytics")]
        public string GoogleAnalytics { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }

        [JsonProperty("customDomain")]
        public string CustomDomain { get; set; }

        [JsonProperty("useLargeHeader")]
        public bool UseLargeHeader { get; set; }

        [JsonProperty("disableDarkMode")]
        public string DisableDarkMode { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("subscribeBySms")]
        public string SubscribeBySms { get; set; }

        [JsonProperty("brandColor")]
        public string BrandColor { get; set; }

        [JsonProperty("okColor")]
        public string OkColor { get; set; }

        [JsonProperty("disruptedColor")]
        public string DisruptedColor { get; set; }

        [JsonProperty("downColor")]
        public string DownColor { get; set; }

        [JsonProperty("degradedColor")]
        public string DegradedColor { get; set; }

        [JsonProperty("noticeColor")]
        public string NoticeColor { get; set; }

        [JsonProperty("htmlInMeta")]
        public string HtmlInMeta { get; set; }

        [JsonProperty("htmlAboveHeader")]
        public string HtmlAboveHeader { get; set; }

        [JsonProperty("htmlBelowHeader")]
        public string HtmlBelowHeader { get; set; }

        [JsonProperty("htmlAboveFooter")]
        public string HtmlAboveFooter { get; set; }

        [JsonProperty("htmlBelowFooter")]
        public string HtmlBelowFooter { get; set; }

        [JsonProperty("htmlBelowSummary")]
        public string HtmlBelowSummary { get; set; }

        [JsonProperty("cssGlobal")]
        public string CssGlobal { get; set; }

        [JsonProperty("onboarded")]
        public string Onboarded { get; set; }

        [JsonProperty("launchDate")]
        public string LaunchDate { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("dateFormatShort")]
        public string DateFormatShort { get; set; }

        [JsonProperty("timeFormat")]
        public string TimeFormat { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("useAllowList")]
        public bool UseAllowList { get; set; }

        [JsonProperty("allowList")]
        public string[] AllowList { get; set; }

        [JsonProperty("components")]
        public PagePostResponseComponentsTypeItem[] Components { get; set; }
    }

    public class PagePostResponseComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("incidents")]
        public string[] Incidents { get; set; }
    }

    public class PagePostInput
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("components")]
        public string[] Components { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("faviconUrl")]
        public string FaviconUrl { get; set; }

        [JsonProperty("websiteUrl")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("useLargeHeader")]
        public bool? UseLargeHeader { get; set; }

        [JsonProperty("brandColor")]
        public string BrandColor { get; set; }

        [JsonProperty("okColor")]
        public string OkColor { get; set; }

        [JsonProperty("disruptedColor")]
        public string DisruptedColor { get; set; }

        [JsonProperty("degradedColor")]
        public string DegradedColor { get; set; }

        [JsonProperty("downColor")]
        public string DownColor { get; set; }

        [JsonProperty("noticeColor")]
        public string NoticeColor { get; set; }

        [JsonProperty("unknownColor")]
        public string UnknownColor { get; set; }

        [JsonProperty("googleAnalytics")]
        public string GoogleAnalytics { get; set; }

        [JsonProperty("subscribeBySms")]
        public bool? SubscribeBySms { get; set; }

        [JsonProperty("smsService")]
        public string SmsService { get; set; }

        [JsonProperty("twilioSid")]
        public string TwilioSid { get; set; }

        [JsonProperty("twilioToken")]
        public string TwilioToken { get; set; }

        [JsonProperty("twilioSender")]
        public string TwilioSender { get; set; }

        [JsonProperty("htmlInMeta")]
        public string HtmlInMeta { get; set; }

        [JsonProperty("htmlAboveHeader")]
        public string HtmlAboveHeader { get; set; }

        [JsonProperty("htmlBelowHeader")]
        public string HtmlBelowHeader { get; set; }

        [JsonProperty("htmlAboveFooter")]
        public string HtmlAboveFooter { get; set; }

        [JsonProperty("htmlBelowFooter")]
        public string HtmlBelowFooter { get; set; }

        [JsonProperty("htmlBelowSummary")]
        public string HtmlBelowSummary { get; set; }

        [JsonProperty("cssGlobal")]
        public string CssGlobal { get; set; }

        [JsonProperty("launchDate")]
        public string LaunchDate { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("dateFormatShort")]
        public string DateFormatShort { get; set; }

        [JsonProperty("timeFormat")]
        public string TimeFormat { get; set; }
    }

    public class PageDeleteResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class PagePutResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("faviconUrl")]
        public string FaviconUrl { get; set; }

        [JsonProperty("websiteUrl")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("googleAnalytics")]
        public string GoogleAnalytics { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }

        [JsonProperty("customDomain")]
        public string CustomDomain { get; set; }

        [JsonProperty("useLargeHeader")]
        public bool UseLargeHeader { get; set; }

        [JsonProperty("disableDarkMode")]
        public string DisableDarkMode { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("subscribeBySms")]
        public string SubscribeBySms { get; set; }

        [JsonProperty("brandColor")]
        public string BrandColor { get; set; }

        [JsonProperty("okColor")]
        public string OkColor { get; set; }

        [JsonProperty("disruptedColor")]
        public string DisruptedColor { get; set; }

        [JsonProperty("downColor")]
        public string DownColor { get; set; }

        [JsonProperty("degradedColor")]
        public string DegradedColor { get; set; }

        [JsonProperty("noticeColor")]
        public string NoticeColor { get; set; }

        [JsonProperty("htmlInMeta")]
        public string HtmlInMeta { get; set; }

        [JsonProperty("htmlAboveHeader")]
        public string HtmlAboveHeader { get; set; }

        [JsonProperty("htmlBelowHeader")]
        public string HtmlBelowHeader { get; set; }

        [JsonProperty("htmlAboveFooter")]
        public string HtmlAboveFooter { get; set; }

        [JsonProperty("htmlBelowFooter")]
        public string HtmlBelowFooter { get; set; }

        [JsonProperty("htmlBelowSummary")]
        public string HtmlBelowSummary { get; set; }

        [JsonProperty("cssGlobal")]
        public string CssGlobal { get; set; }

        [JsonProperty("onboarded")]
        public string Onboarded { get; set; }

        [JsonProperty("launchDate")]
        public string LaunchDate { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("dateFormatShort")]
        public string DateFormatShort { get; set; }

        [JsonProperty("timeFormat")]
        public string TimeFormat { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("useAllowList")]
        public bool UseAllowList { get; set; }

        [JsonProperty("allowList")]
        public JToken[] AllowList { get; set; }

        [JsonProperty("components")]
        public PagePutResponseComponentsTypeItem[] Components { get; set; }
    }

    public class PagePutResponseComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("incidents")]
        public string[] Incidents { get; set; }
    }

    public class PagePutInput
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("faviconUrl")]
        public string FaviconUrl { get; set; }

        [JsonProperty("websiteUrl")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }

        [JsonProperty("useLargeHeader")]
        public bool? UseLargeHeader { get; set; }

        [JsonProperty("brandColor")]
        public string BrandColor { get; set; }

        [JsonProperty("okColor")]
        public string OkColor { get; set; }

        [JsonProperty("disruptedColor")]
        public string DisruptedColor { get; set; }

        [JsonProperty("degradedColor")]
        public string DegradedColor { get; set; }

        [JsonProperty("downColor")]
        public string DownColor { get; set; }

        [JsonProperty("noticeColor")]
        public string NoticeColor { get; set; }

        [JsonProperty("unknownColor")]
        public string UnknownColor { get; set; }

        [JsonProperty("googleAnalytics")]
        public string GoogleAnalytics { get; set; }

        [JsonProperty("subscribeBySms")]
        public bool? SubscribeBySms { get; set; }

        [JsonProperty("smsService")]
        public string SmsService { get; set; }

        [JsonProperty("twilioSid")]
        public string TwilioSid { get; set; }

        [JsonProperty("twilioToken")]
        public string TwilioToken { get; set; }

        [JsonProperty("twilioSender")]
        public string TwilioSender { get; set; }

        [JsonProperty("htmlInMeta")]
        public string HtmlInMeta { get; set; }

        [JsonProperty("htmlAboveHeader")]
        public string HtmlAboveHeader { get; set; }

        [JsonProperty("htmlBelowHeader")]
        public string HtmlBelowHeader { get; set; }

        [JsonProperty("htmlAboveFooter")]
        public string HtmlAboveFooter { get; set; }

        [JsonProperty("htmlBelowFooter")]
        public string HtmlBelowFooter { get; set; }

        [JsonProperty("htmlBelowSummary")]
        public string HtmlBelowSummary { get; set; }

        [JsonProperty("cssGlobal")]
        public string CssGlobal { get; set; }

        [JsonProperty("launchDate")]
        public string LaunchDate { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("dateFormatShort")]
        public string DateFormatShort { get; set; }

        [JsonProperty("timeFormat")]
        public string TimeFormat { get; set; }

        [JsonProperty("private")]
        public bool? Private { get; set; }

        [JsonProperty("useAllowList")]
        public bool? UseAllowList { get; set; }
    }

    public class ComponentsGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("uniqueEmail")]
        public string UniqueEmail { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }
    }

    public class ComponentPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("uniqueEmail")]
        public string UniqueEmail { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }
    }

    public class ComponentPostInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("showUptime")]
        public bool? ShowUptime { get; set; }

        [JsonProperty("grouped")]
        public bool? Grouped { get; set; }
    }

    public class ComponentGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("uniqueEmail")]
        public string UniqueEmail { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }
    }

    public class ComponentDeleteResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ComponentPutResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uniqueEmail")]
        public string UniqueEmail { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }
    }

    public class ComponentPutInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("showUptime")]
        public bool? ShowUptime { get; set; }

        [JsonProperty("grouped")]
        public bool? Grouped { get; set; }
    }

    public class IncidentsGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("resolved")]
        public string Resolved { get; set; }

        [JsonProperty("updates")]
        public IncidentsGetResponseItemUpdatesTypeItem[] Updates { get; set; }

        [JsonProperty("components")]
        public IncidentsGetResponseItemComponentsTypeItem[] Components { get; set; }
    }

    public class IncidentsGetResponseItemUpdatesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("ended")]
        public string Ended { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class IncidentsGetResponseItemComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("site")]
        public IncidentsGetResponseItemComponentsTypeItemSiteType Site { get; set; }
    }

    public class IncidentsGetResponseItemComponentsTypeItemSiteType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }
    }

    public class IncidentPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("resolved")]
        public string Resolved { get; set; }

        [JsonProperty("updates")]
        public string[] Updates { get; set; }

        [JsonProperty("components")]
        public IncidentPostResponseComponentsTypeItem[] Components { get; set; }
    }

    public class IncidentPostResponseComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("site")]
        public IncidentPostResponseComponentsTypeItemSiteType Site { get; set; }
    }

    public class IncidentPostResponseComponentsTypeItemSiteType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }
    }

    public class IncidentPostInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("components")]
        public string[] Components { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool? Notify { get; set; }

        [JsonProperty("statuses")]
        public IncidentPostInputStatusesTypeItem[] Statuses { get; set; }
    }

    public class IncidentPostInputStatusesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class IncidentGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("resolved")]
        public string Resolved { get; set; }

        [JsonProperty("updates")]
        public IncidentGetResponseUpdatesTypeItem[] Updates { get; set; }

        [JsonProperty("components")]
        public IncidentGetResponseComponentsTypeItem[] Components { get; set; }
    }

    public class IncidentGetResponseUpdatesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("ended")]
        public string Ended { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class IncidentGetResponseComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("site")]
        public IncidentGetResponseComponentsTypeItemSiteType Site { get; set; }
    }

    public class IncidentGetResponseComponentsTypeItemSiteType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }
    }

    public class IncidentDeleteResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class IncidentPutResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("resolved")]
        public string Resolved { get; set; }

        [JsonProperty("updates")]
        public string[] Updates { get; set; }

        [JsonProperty("components")]
        public IncidentPutResponseComponentsTypeItem[] Components { get; set; }
    }

    public class IncidentPutResponseComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("site")]
        public IncidentPutResponseComponentsTypeItemSiteType Site { get; set; }
    }

    public class IncidentPutResponseComponentsTypeItemSiteType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }
    }

    public class IncidentPutInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("components")]
        public string[] Components { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool? Notify { get; set; }

        [JsonProperty("statuses")]
        public IncidentPutInputStatusesTypeItem[] Statuses { get; set; }
    }

    public class IncidentPutInputStatusesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class IncidentTemplatePostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nameTranslationId")]
        public string NameTranslationId { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("resolved")]
        public string Resolved { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("automated")]
        public bool Automated { get; set; }

        [JsonProperty("impact")]
        public string Impact { get; set; }

        [JsonProperty("appId")]
        public string AppId { get; set; }

        [JsonProperty("siteId")]
        public string SiteId { get; set; }

        [JsonProperty("importedFromStatuspage")]
        public bool ImportedFromStatuspage { get; set; }
    }

    public class IncidentUpdateGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("incident")]
        public IncidentUpdateGetResponseIncidentType Incident { get; set; }
    }

    public class IncidentUpdateGetResponseIncidentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("components")]
        public IncidentUpdateGetResponseIncidentTypeComponentsTypeItem[] Components { get; set; }
    }

    public class IncidentUpdateGetResponseIncidentTypeComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("site")]
        public IncidentUpdateGetResponseIncidentTypeComponentsTypeItemSiteType Site { get; set; }

        [JsonProperty("subscribers")]
        public string[] Subscribers { get; set; }
    }

    public class IncidentUpdateGetResponseIncidentTypeComponentsTypeItemSiteType
    {
        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slackIntegrations")]
        public string[] SlackIntegrations { get; set; }

        [JsonProperty("subscribers")]
        public string[] Subscribers { get; set; }
    }

    public class IncidentUpdateDeleteResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class IncidentUpdatePutResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("incident")]
        public IncidentUpdatePutResponseIncidentType Incident { get; set; }
    }

    public class IncidentUpdatePutResponseIncidentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("components")]
        public IncidentUpdatePutResponseIncidentTypeComponentsTypeItem[] Components { get; set; }
    }

    public class IncidentUpdatePutResponseIncidentTypeComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("site")]
        public IncidentUpdatePutResponseIncidentTypeComponentsTypeItemSiteType Site { get; set; }

        [JsonProperty("subscribers")]
        public string[] Subscribers { get; set; }
    }

    public class IncidentUpdatePutResponseIncidentTypeComponentsTypeItemSiteType
    {
        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slackIntegrations")]
        public string[] SlackIntegrations { get; set; }

        [JsonProperty("subscribers")]
        public string[] Subscribers { get; set; }
    }

    public class IncidentUpdatePutInput
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("components")]
        public string[] Components { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool? Notify { get; set; }

        [JsonProperty("statuses")]
        public IncidentUpdatePutInputStatusesTypeItem[] Statuses { get; set; }
    }

    public class IncidentUpdatePutInputStatusesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class IncidentUpdatePostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("incident")]
        public IncidentUpdatePostResponseIncidentType Incident { get; set; }
    }

    public class IncidentUpdatePostResponseIncidentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("components")]
        public IncidentUpdatePostResponseIncidentTypeComponentsTypeItem[] Components { get; set; }
    }

    public class IncidentUpdatePostResponseIncidentTypeComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("site")]
        public IncidentUpdatePostResponseIncidentTypeComponentsTypeItemSiteType Site { get; set; }

        [JsonProperty("subscribers")]
        public string[] Subscribers { get; set; }
    }

    public class IncidentUpdatePostResponseIncidentTypeComponentsTypeItemSiteType
    {
        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slackIntegrations")]
        public string[] SlackIntegrations { get; set; }

        [JsonProperty("subscribers")]
        public string[] Subscribers { get; set; }
    }

    public class IncidentUpdatePostInput
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("components")]
        public string[] Components { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool? Notify { get; set; }

        [JsonProperty("statuses")]
        public IncidentUpdatePostInputStatusesTypeItem[] Statuses { get; set; }
    }

    public class IncidentUpdatePostInputStatusesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class IncidentUpdateTemplatePostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageTranslationId")]
        public string MessageTranslationId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("ended")]
        public string Ended { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("incidentId")]
        public string IncidentId { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("messageHtmlTranslationId")]
        public string MessageHtmlTranslationId { get; set; }

        [JsonProperty("importedFromStatuspage")]
        public bool ImportedFromStatuspage { get; set; }
    }

    public class MaintenancesGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("notifyStart")]
        public bool NotifyStart { get; set; }

        [JsonProperty("notifyEnd")]
        public bool NotifyEnd { get; set; }

        [JsonProperty("notifyEarly")]
        public bool NotifyEarly { get; set; }

        [JsonProperty("notifyMinutes")]
        public int NotifyMinutes { get; set; }

        [JsonProperty("autoStart")]
        public bool AutoStart { get; set; }

        [JsonProperty("autoEnd")]
        public bool AutoEnd { get; set; }

        [JsonProperty("updates")]
        public MaintenancesGetResponseItemUpdatesTypeItem[] Updates { get; set; }

        [JsonProperty("components")]
        public MaintenancesGetResponseItemComponentsTypeItem[] Components { get; set; }
    }

    public class MaintenancesGetResponseItemUpdatesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("ended")]
        public string Ended { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class MaintenancesGetResponseItemComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("site")]
        public MaintenancesGetResponseItemComponentsTypeItemSiteType Site { get; set; }
    }

    public class MaintenancesGetResponseItemComponentsTypeItemSiteType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }
    }

    public class MaintenancePostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("updates")]
        public string[] Updates { get; set; }

        [JsonProperty("components")]
        public MaintenancePostResponseComponentsTypeItem[] Components { get; set; }
    }

    public class MaintenancePostResponseComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("site")]
        public MaintenancePostResponseComponentsTypeItemSiteType Site { get; set; }
    }

    public class MaintenancePostResponseComponentsTypeItemSiteType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }
    }

    public class MaintenancePostInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("components")]
        public string[] Components { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool? Notify { get; set; }

        [JsonProperty("duration")]
        public int? Duration { get; set; }

        [JsonProperty("notifyStart")]
        public bool? NotifyStart { get; set; }

        [JsonProperty("notifyEnd")]
        public bool? NotifyEnd { get; set; }

        [JsonProperty("notifyEarly")]
        public bool? NotifyEarly { get; set; }

        [JsonProperty("notifyMinutes")]
        public int? NotifyMinutes { get; set; }

        [JsonProperty("autoStart")]
        public bool? AutoStart { get; set; }

        [JsonProperty("autoEnd")]
        public bool? AutoEnd { get; set; }

        [JsonProperty("statuses")]
        public MaintenancePostInputStatusesTypeItem[] Statuses { get; set; }
    }

    public class MaintenancePostInputStatusesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class MaintenanceGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("notifyStart")]
        public bool NotifyStart { get; set; }

        [JsonProperty("notifyEnd")]
        public bool NotifyEnd { get; set; }

        [JsonProperty("notifyEarly")]
        public bool NotifyEarly { get; set; }

        [JsonProperty("notifyMinutes")]
        public int NotifyMinutes { get; set; }

        [JsonProperty("autoStart")]
        public bool AutoStart { get; set; }

        [JsonProperty("autoEnd")]
        public bool AutoEnd { get; set; }

        [JsonProperty("updates")]
        public MaintenanceGetResponseUpdatesTypeItem[] Updates { get; set; }

        [JsonProperty("components")]
        public MaintenanceGetResponseComponentsTypeItem[] Components { get; set; }
    }

    public class MaintenanceGetResponseUpdatesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("ended")]
        public string Ended { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class MaintenanceGetResponseComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("site")]
        public MaintenanceGetResponseComponentsTypeItemSiteType Site { get; set; }
    }

    public class MaintenanceGetResponseComponentsTypeItemSiteType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }
    }

    public class MaintenanceDeleteResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class MaintenancePutResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("updates")]
        public MaintenancePutResponseUpdatesTypeItem[] Updates { get; set; }

        [JsonProperty("components")]
        public MaintenancePutResponseComponentsTypeItem[] Components { get; set; }
    }

    public class MaintenancePutResponseUpdatesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("ended")]
        public string Ended { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class MaintenancePutResponseComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("site")]
        public MaintenancePutResponseComponentsTypeItemSiteType Site { get; set; }
    }

    public class MaintenancePutResponseComponentsTypeItemSiteType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }
    }

    public class MaintenancePutInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("components")]
        public string[] Components { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool? Notify { get; set; }

        [JsonProperty("statuses")]
        public MaintenancePutInputStatusesTypeItem[] Statuses { get; set; }
    }

    public class MaintenancePutInputStatusesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class MaintenanceUpdateGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("maintenance")]
        public MaintenanceUpdateGetResponseMaintenanceType Maintenance { get; set; }
    }

    public class MaintenanceUpdateGetResponseMaintenanceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("components")]
        public MaintenanceUpdateGetResponseMaintenanceTypeComponentsTypeItem[] Components { get; set; }
    }

    public class MaintenanceUpdateGetResponseMaintenanceTypeComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("site")]
        public MaintenanceUpdateGetResponseMaintenanceTypeComponentsTypeItemSiteType Site { get; set; }
    }

    public class MaintenanceUpdateGetResponseMaintenanceTypeComponentsTypeItemSiteType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }
    }

    public class MaintenanceUpdateDeleteResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class MaintenanceUpdatePutResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("maintenance")]
        public MaintenanceUpdatePutResponseMaintenanceType Maintenance { get; set; }
    }

    public class MaintenanceUpdatePutResponseMaintenanceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("components")]
        public MaintenanceUpdatePutResponseMaintenanceTypeComponentsTypeItem[] Components { get; set; }
    }

    public class MaintenanceUpdatePutResponseMaintenanceTypeComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("subscribers")]
        public string[] Subscribers { get; set; }

        [JsonProperty("site")]
        public MaintenanceUpdatePutResponseMaintenanceTypeComponentsTypeItemSiteType Site { get; set; }
    }

    public class MaintenanceUpdatePutResponseMaintenanceTypeComponentsTypeItemSiteType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }

        [JsonProperty("subscribers")]
        public string[] Subscribers { get; set; }
    }

    public class MaintenanceUpdatePutInput
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("components")]
        public string[] Components { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool? Notify { get; set; }

        [JsonProperty("statuses")]
        public MaintenanceUpdatePutInputStatusesTypeItem[] Statuses { get; set; }
    }

    public class MaintenanceUpdatePutInputStatusesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class MaintenanceUpdatePostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("maintenance")]
        public MaintenanceUpdatePostResponseMaintenanceType Maintenance { get; set; }
    }

    public class MaintenanceUpdatePostResponseMaintenanceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("components")]
        public MaintenanceUpdatePostResponseMaintenanceTypeComponentsTypeItem[] Components { get; set; }
    }

    public class MaintenanceUpdatePostResponseMaintenanceTypeComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("subscribers")]
        public string[] Subscribers { get; set; }

        [JsonProperty("site")]
        public MaintenanceUpdatePostResponseMaintenanceTypeComponentsTypeItemSiteType Site { get; set; }
    }

    public class MaintenanceUpdatePostResponseMaintenanceTypeComponentsTypeItemSiteType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }

        [JsonProperty("subscribers")]
        public string[] Subscribers { get; set; }
    }

    public class MaintenanceUpdatePostInput
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("components")]
        public string[] Components { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool? Notify { get; set; }

        [JsonProperty("statuses")]
        public MaintenanceUpdatePostInputStatusesTypeItem[] Statuses { get; set; }
    }

    public class MaintenanceUpdatePostInputStatusesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PageTemplatesGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nameTranslationId")]
        public string NameTranslationId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageTranslationId")]
        public string MessageTranslationId { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("messageHtmlTranslationId")]
        public string MessageHtmlTranslationId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("siteId")]
        public string SiteId { get; set; }

        [JsonProperty("importedFromStatuspage")]
        public bool ImportedFromStatuspage { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("components")]
        public PageTemplatesGetResponseItemComponentsTypeItem[] Components { get; set; }

        [JsonProperty("translations")]
        public PageTemplatesGetResponseItemTranslationsType Translations { get; set; }
    }

    public class PageTemplatesGetResponseItemComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("componentId")]
        public string ComponentId { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("importedFromStatuspage")]
        public bool ImportedFromStatuspage { get; set; }
    }

    public class PageTemplatesGetResponseItemTranslationsType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class TemplatePostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nameTranslationId")]
        public string NameTranslationId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageTranslationId")]
        public string MessageTranslationId { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("messageHtmlTranslationId")]
        public string MessageHtmlTranslationId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("siteId")]
        public string SiteId { get; set; }

        [JsonProperty("importedFromStatuspage")]
        public bool ImportedFromStatuspage { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("components")]
        public string[] Components { get; set; }

        [JsonProperty("translations")]
        public TemplatePostResponseTranslationsType Translations { get; set; }
    }

    public class TemplatePostResponseTranslationsType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class TemplatePostInput
    {
        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool? Notify { get; set; }

        [JsonProperty("components")]
        public TemplatePostInputComponentsTypeItem[] Components { get; set; }
    }

    public class TemplatePostInputComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class TemplateGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nameTranslationId")]
        public string NameTranslationId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageTranslationId")]
        public string MessageTranslationId { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("messageHtmlTranslationId")]
        public string MessageHtmlTranslationId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("siteId")]
        public string SiteId { get; set; }

        [JsonProperty("importedFromStatuspage")]
        public bool ImportedFromStatuspage { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("components")]
        public string[] Components { get; set; }

        [JsonProperty("translations")]
        public TemplateGetResponseTranslationsType Translations { get; set; }
    }

    public class TemplateGetResponseTranslationsType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class TemplateDeleteResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("site")]
        public TemplateDeleteResponseSiteType Site { get; set; }
    }

    public class TemplateDeleteResponseSiteType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class TemplatePutResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nameTranslationId")]
        public string NameTranslationId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageTranslationId")]
        public string MessageTranslationId { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("messageHtmlTranslationId")]
        public string MessageHtmlTranslationId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("siteId")]
        public string SiteId { get; set; }

        [JsonProperty("importedFromStatuspage")]
        public bool ImportedFromStatuspage { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("components")]
        public TemplatePutResponseComponentsTypeItem[] Components { get; set; }

        [JsonProperty("translations")]
        public TemplatePutResponseTranslationsType Translations { get; set; }
    }

    public class TemplatePutResponseComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("componentId")]
        public string ComponentId { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("importedFromStatuspage")]
        public bool ImportedFromStatuspage { get; set; }
    }

    public class TemplatePutResponseTranslationsType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class TemplatePutInput
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool? Notify { get; set; }

        [JsonProperty("components")]
        public TemplatePutInputComponentsTypeItem[] Components { get; set; }
    }

    public class TemplatePutInputComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class TeammatesGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("user")]
        public TeammatesGetResponseItemUserType User { get; set; }
    }

    public class TeammatesGetResponseItemUserType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }
    }

    public class TeamMemberPostInput
    {
        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class SubscribersGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("webhook")]
        public string Webhook { get; set; }

        [JsonProperty("webhookEmail")]
        public string WebhookEmail { get; set; }

        [JsonProperty("confirmed")]
        public bool Confirmed { get; set; }

        [JsonProperty("all")]
        public bool All { get; set; }

        [JsonProperty("components")]
        public string[] Components { get; set; }
    }

    public class SubscriberPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("site")]
        public SubscriberPostResponseSiteType Site { get; set; }
    }

    public class SubscriberPostResponseSiteType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class SubscriberPostInput
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("all")]
        public bool? All { get; set; }

        [JsonProperty("autoConfirm")]
        public bool? AutoConfirm { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Instatusip;

    public partial class WorkflowManagedActions
    {
        public InstatusipActions Instatusip(string connectionId) => new InstatusipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public InstatusipTriggers Instatusip(string connectionId) => new InstatusipTriggers(connectionId);
    }
}