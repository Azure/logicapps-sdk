//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pilotthings
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PilotthingsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageAlertRo, ApiConnectionActionConfiguration> GetAlerts(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<DirInput>> dir = null, Expression<Func<string>> orFilter = null, Expression<Func<int>> dateStart = null, Expression<Func<int>> dateEnd = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = WorkflowExpression.Compile(sortValues, nameof(sortValues), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_orFilter = WorkflowExpression.Compile(orFilter, nameof(orFilter), required: false);
            var __workflow_dateStart = WorkflowExpression.Compile(dateStart, nameof(dateStart), required: false);
            var __workflow_dateEnd = WorkflowExpression.Compile(dateEnd, nameof(dateEnd), required: false);
            return new DeferredBodyAction<PageAlertRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/alerts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                callPayload.Queries["dateStart"] = Convert.ToString(0);
                if (__workflow_dateStart != null)
                    callPayload.Queries["dateStart"] = ExpressionConverter.Convert(__workflow_dateStart);
                callPayload.Queries["dateEnd"] = Convert.ToString(0);
                if (__workflow_dateEnd != null)
                    callPayload.Queries["dateEnd"] = ExpressionConverter.Convert(__workflow_dateEnd);
                return new ApiConnectionAction<PageAlertRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<AlertRo, ApiConnectionActionConfiguration> UpdateAlertState(Expression<Func<string>> id, Expression<Func<string>> paramJson)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_paramJson = WorkflowExpression.Compile(paramJson, nameof(paramJson), required: true);
            return new DeferredBodyAction<AlertRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/alerts/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_paramJson);
                return new ApiConnectionAction<AlertRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageMeasureRo, ApiConnectionActionConfiguration> GetMeasures(Expression<Func<bool>> detailed = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<DirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var __workflow_detailed = WorkflowExpression.Compile(detailed, nameof(detailed), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = WorkflowExpression.Compile(sortValues, nameof(sortValues), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_orFilter = WorkflowExpression.Compile(orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<PageMeasureRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/measures";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["detailed"] = Convert.ToString(false);
                if (__workflow_detailed != null)
                    callPayload.Queries["detailed"] = ExpressionConverter.Convert(__workflow_detailed);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                return new ApiConnectionAction<PageMeasureRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<CountRo, ApiConnectionActionConfiguration> GetCount(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<DirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = WorkflowExpression.Compile(sortValues, nameof(sortValues), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_orFilter = WorkflowExpression.Compile(orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<CountRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/measures/count";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                return new ApiConnectionAction<CountRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MeasureRo, ApiConnectionActionConfiguration> GetMeasure(Expression<Func<string>> id, Expression<Func<bool>> detailed = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_detailed = WorkflowExpression.Compile(detailed, nameof(detailed), required: false);
            return new DeferredBodyAction<MeasureRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/measures/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["detailed"] = Convert.ToString(false);
                if (__workflow_detailed != null)
                    callPayload.Queries["detailed"] = ExpressionConverter.Convert(__workflow_detailed);
                return new ApiConnectionAction<MeasureRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageMessageRo, ApiConnectionActionConfiguration> GetMessages(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<DirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = WorkflowExpression.Compile(sortValues, nameof(sortValues), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_orFilter = WorkflowExpression.Compile(orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<PageMessageRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/messages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                return new ApiConnectionAction<PageMessageRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageMessageRo, ApiConnectionActionConfiguration> GetMessagesAndMeasurements(Expression<Func<string>> thingId, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<DirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var __workflow_thingId = WorkflowExpression.Compile(thingId, nameof(thingId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = WorkflowExpression.Compile(sortValues, nameof(sortValues), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_orFilter = WorkflowExpression.Compile(orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<PageMessageRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/messages/things/{0}", __workflow_thingId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                return new ApiConnectionAction<PageMessageRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MessageRo, ApiConnectionActionConfiguration> AddMessage(Expression<Func<string>> thingId, Expression<Func<AddMessageMessageRoInput>> messageRo)
        {
            var __workflow_thingId = WorkflowExpression.Compile(thingId, nameof(thingId), required: true);
            var __workflow_messageRo = WorkflowExpression.Compile(messageRo, nameof(messageRo), required: true);
            return new DeferredBodyAction<MessageRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/messages/things/{0}", __workflow_thingId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_messageRo);
                return new ApiConnectionAction<MessageRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MessageRo, ApiConnectionActionConfiguration> GetMessage(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<MessageRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/messages/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MessageRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MessageRo, ApiConnectionActionConfiguration> GetPreviousMessage(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<MessageRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/messages/{0}/previous", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MessageRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageSiteRo, ApiConnectionActionConfiguration> GetSites(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<DirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = WorkflowExpression.Compile(sortValues, nameof(sortValues), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_orFilter = WorkflowExpression.Compile(orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<PageSiteRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/sites";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                return new ApiConnectionAction<PageSiteRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<AssociateThingProductSiteRoResponse[], ApiConnectionActionConfiguration> CreateSite(Expression<Func<NodeInput>> node)
        {
            var __workflow_node = WorkflowExpression.Compile(node, nameof(node), required: true);
            return new DeferredBodyAction<AssociateThingProductSiteRoResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/sites";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_node);
                return new ApiConnectionAction<AssociateThingProductSiteRoResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<AssociateThingProductSiteRoResponse, ApiConnectionActionConfiguration> GetSite(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<AssociateThingProductSiteRoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/sites/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AssociateThingProductSiteRoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteSite(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/sites/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<AssociateThingProductSiteRoResponse, ApiConnectionActionConfiguration> UpdateSite(Expression<Func<string>> id, Expression<Func<SiteRoInput>> siteRo)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_siteRo = WorkflowExpression.Compile(siteRo, nameof(siteRo), required: true);
            return new DeferredBodyAction<AssociateThingProductSiteRoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/sites/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_siteRo);
                return new ApiConnectionAction<AssociateThingProductSiteRoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageThingTagRo, ApiConnectionActionConfiguration> GetTags(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<DirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = WorkflowExpression.Compile(sortValues, nameof(sortValues), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_orFilter = WorkflowExpression.Compile(orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<PageThingTagRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                return new ApiConnectionAction<PageThingTagRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<AddThingTagTagRoResponse, ApiConnectionActionConfiguration> UpdateThingTag(Expression<Func<ThingTagRoInput>> thingTagRo)
        {
            var __workflow_thingTagRo = WorkflowExpression.Compile(thingTagRo, nameof(thingTagRo), required: true);
            return new DeferredBodyAction<AddThingTagTagRoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/tags";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_thingTagRo);
                return new ApiConnectionAction<AddThingTagTagRoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<AddThingTagTagRoResponse, ApiConnectionActionConfiguration> AddThingTag(Expression<Func<string>> thingId, Expression<Func<ThingTagRoInput>> thingTagRo)
        {
            var __workflow_thingId = WorkflowExpression.Compile(thingId, nameof(thingId), required: true);
            var __workflow_thingTagRo = WorkflowExpression.Compile(thingTagRo, nameof(thingTagRo), required: true);
            return new DeferredBodyAction<AddThingTagTagRoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/tags/thing/{0}", __workflow_thingId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_thingTagRo);
                return new ApiConnectionAction<AddThingTagTagRoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<AddThingTagTagRoResponse, ApiConnectionActionConfiguration> GetThingTag(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<AddThingTagTagRoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/tags/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AddThingTagTagRoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageSingleThingRo, ApiConnectionActionConfiguration> GetThings(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<DirInput>> dir = null, Expression<Func<string>> orFilter = null, Expression<Func<bool>> detailed = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = WorkflowExpression.Compile(sortValues, nameof(sortValues), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_orFilter = WorkflowExpression.Compile(orFilter, nameof(orFilter), required: false);
            var __workflow_detailed = WorkflowExpression.Compile(detailed, nameof(detailed), required: false);
            return new DeferredBodyAction<PageSingleThingRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/things";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                callPayload.Queries["detailed"] = Convert.ToString(false);
                if (__workflow_detailed != null)
                    callPayload.Queries["detailed"] = ExpressionConverter.Convert(__workflow_detailed);
                return new ApiConnectionAction<PageSingleThingRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SingleThingRo[], ApiConnectionActionConfiguration> AssociateThingsWithProduct(Expression<Func<JsonInput>> json)
        {
            var __workflow_json = WorkflowExpression.Compile(json, nameof(json), required: true);
            return new DeferredBodyAction<SingleThingRo[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/things";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_json);
                return new ApiConnectionAction<SingleThingRo[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SingleThingRo[], ApiConnectionActionConfiguration> GetThingList(Expression<Func<string[]>> thingIds)
        {
            var __workflow_thingIds = WorkflowExpression.Compile(thingIds, nameof(thingIds), required: true);
            return new DeferredBodyAction<SingleThingRo[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/things/list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_thingIds);
                return new ApiConnectionAction<SingleThingRo[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SingleThingRo, ApiConnectionActionConfiguration> GetThing(Expression<Func<string>> id, Expression<Func<bool>> detailed = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_detailed = WorkflowExpression.Compile(detailed, nameof(detailed), required: false);
            return new DeferredBodyAction<SingleThingRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/things/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["detailed"] = Convert.ToString(false);
                if (__workflow_detailed != null)
                    callPayload.Queries["detailed"] = ExpressionConverter.Convert(__workflow_detailed);
                return new ApiConnectionAction<SingleThingRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IWorkflowAction<ApiConnectionActionConfiguration> IgnoreThing(Expression<Func<string>> id, Expression<Func<bool>> force = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_force = WorkflowExpression.Compile(force, nameof(force), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/things/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_force != null)
                    callPayload.Queries["force"] = ExpressionConverter.Convert(__workflow_force);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ThingRo, ApiConnectionActionConfiguration> PutThing(Expression<Func<string>> id, Expression<Func<PutThingThingRoInput>> thingRo)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_thingRo = WorkflowExpression.Compile(thingRo, nameof(thingRo), required: true);
            return new DeferredBodyAction<ThingRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/things/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_thingRo);
                return new ApiConnectionAction<ThingRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ModelRo, ApiConnectionActionConfiguration> GetThingActiveModel(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ModelRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/things/{0}/active_model", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ModelRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageCustomFieldRo, ApiConnectionActionConfiguration> GetCustomField(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<PageCustomFieldRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/things/{0}/custom_fields", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PageCustomFieldRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<AssociateThingProductCustomFieldRoResponse, ApiConnectionActionConfiguration> CreateCustomField(Expression<Func<string>> id, Expression<Func<CustomFieldRoInput>> customFieldRo)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_customFieldRo = WorkflowExpression.Compile(customFieldRo, nameof(customFieldRo), required: true);
            return new DeferredBodyAction<AssociateThingProductCustomFieldRoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/things/{0}/custom_fields", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_customFieldRo);
                return new ApiConnectionAction<AssociateThingProductCustomFieldRoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<AssociateThingProductCustomFieldRoResponse, ApiConnectionActionConfiguration> UpdateCustomField(Expression<Func<string>> id, Expression<Func<CustomFieldRoInput>> customFieldRo)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_customFieldRo = WorkflowExpression.Compile(customFieldRo, nameof(customFieldRo), required: true);
            return new DeferredBodyAction<AssociateThingProductCustomFieldRoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/things/{0}/custom_fields", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_customFieldRo);
                return new ApiConnectionAction<AssociateThingProductCustomFieldRoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ResponseEntity, ApiConnectionActionConfiguration> DeleteCustomField(Expression<Func<string>> id, Expression<Func<string>> fieldId)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            return new DeferredBodyAction<ResponseEntity, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/things/{0}/custom_fields/{1}", __workflow_id.WithUrlEncoding(1), __workflow_fieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResponseEntity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ResponseEntity, ApiConnectionActionConfiguration> GetCustomFieldImage(Expression<Func<string>> id, Expression<Func<string>> fieldId)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            return new DeferredBodyAction<ResponseEntity, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/things/{0}/custom_fields/{1}/image", __workflow_id.WithUrlEncoding(1), __workflow_fieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResponseEntity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ResponseEntity, ApiConnectionActionConfiguration> GetThingImage(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResponseEntity, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/things/{0}/image", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResponseEntity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MeasureTinyRo[], ApiConnectionActionConfiguration> GetLastMeasures(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<MeasureTinyRo[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/things/{0}/last_measurements", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MeasureTinyRo[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MessageTinyRo, ApiConnectionActionConfiguration> GetLastMessage(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<MessageTinyRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/things/{0}/last_message", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MessageTinyRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageMeasureRo, ApiConnectionActionConfiguration> GetThingMeasures(Expression<Func<string>> id, Expression<Func<bool>> detailed = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<DirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_detailed = WorkflowExpression.Compile(detailed, nameof(detailed), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = WorkflowExpression.Compile(sortValues, nameof(sortValues), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_orFilter = WorkflowExpression.Compile(orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<PageMeasureRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/things/{0}/measures", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["detailed"] = Convert.ToString(false);
                if (__workflow_detailed != null)
                    callPayload.Queries["detailed"] = ExpressionConverter.Convert(__workflow_detailed);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                return new ApiConnectionAction<PageMeasureRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageMessageRo, ApiConnectionActionConfiguration> GetThingMessages(Expression<Func<string>> id, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<DirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = WorkflowExpression.Compile(sortValues, nameof(sortValues), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_orFilter = WorkflowExpression.Compile(orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<PageMessageRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/things/{0}/messages", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                return new ApiConnectionAction<PageMessageRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteThingMessages(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/things/{0}/messages", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<MessageRo, ApiConnectionActionConfiguration> CreateThingMessages(Expression<Func<string>> id, Expression<Func<CreateThingMessagesMessageRoInput>> messageRo)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_messageRo = WorkflowExpression.Compile(messageRo, nameof(messageRo), required: true);
            return new DeferredBodyAction<MessageRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/things/{0}/messages", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_messageRo);
                return new ApiConnectionAction<MessageRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ModelRo, ApiConnectionActionConfiguration> GetThingModel(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ModelRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/things/{0}/model", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ModelRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageOperationRo, ApiConnectionActionConfiguration> GetThingOperations(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<PageOperationRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/things/{0}/operations", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PageOperationRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ResponseEntity, ApiConnectionActionConfiguration> ExecuteThingOperation(Expression<Func<string>> id, Expression<Func<string>> operationId, Expression<Func<PlaceholdersValuesInput>> placeholdersValues)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_operationId = WorkflowExpression.Compile(operationId, nameof(operationId), required: true);
            var __workflow_placeholdersValues = WorkflowExpression.Compile(placeholdersValues, nameof(placeholdersValues), required: true);
            return new DeferredBodyAction<ResponseEntity, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/things/{0}/operations/{1}", __workflow_id.WithUrlEncoding(1), __workflow_operationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_placeholdersValues);
                return new ApiConnectionAction<ResponseEntity>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SingleThingRo, ApiConnectionActionConfiguration> UpdateThingFixedPosition(Expression<Func<string>> id, Expression<Func<UpdateThingFixedPositionThingRoInput>> thingRo)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_thingRo = WorkflowExpression.Compile(thingRo, nameof(thingRo), required: true);
            return new DeferredBodyAction<SingleThingRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/things/{0}/positions", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_thingRo);
                return new ApiConnectionAction<SingleThingRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<ProductRo, ApiConnectionActionConfiguration> GetThingProduct(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ProductRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/things/{0}/product", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProductRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SingleThingRo, ApiConnectionActionConfiguration> DissociateThingProduct(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<SingleThingRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/things/{0}/product", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SingleThingRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<SingleThingRo, ApiConnectionActionConfiguration> AssociateThingProduct(Expression<Func<string>> id, Expression<Func<ProductInput>> product)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_product = WorkflowExpression.Compile(product, nameof(product), required: true);
            return new DeferredBodyAction<SingleThingRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/things/{0}/product", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_product);
                return new ApiConnectionAction<SingleThingRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageFlowRo, ApiConnectionActionConfiguration> GetFlowsRelatedToThing(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<PageFlowRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/things/{0}/related_flows", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PageFlowRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageThingTagRo, ApiConnectionActionConfiguration> GetThingTags(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<PageThingTagRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/things/{0}/tags", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PageThingTagRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageStatsMeasureRo, ApiConnectionActionConfiguration> GetStatsAvg(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<DirInput>> dir = null, Expression<Func<string>> orFilter = null, Expression<Func<int>> start = null, Expression<Func<int>> end = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = WorkflowExpression.Compile(sortValues, nameof(sortValues), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_orFilter = WorkflowExpression.Compile(orFilter, nameof(orFilter), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_end = WorkflowExpression.Compile(end, nameof(end), required: false);
            return new DeferredBodyAction<PageStatsMeasureRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/stats/avg";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(__workflow_end);
                return new ApiConnectionAction<PageStatsMeasureRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<StatsCountRo, ApiConnectionActionConfiguration> GetStatsCount(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<DirInput>> dir = null, Expression<Func<string>> orFilter = null, Expression<Func<int>> start = null, Expression<Func<int>> end = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = WorkflowExpression.Compile(sortValues, nameof(sortValues), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_orFilter = WorkflowExpression.Compile(orFilter, nameof(orFilter), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_end = WorkflowExpression.Compile(end, nameof(end), required: false);
            return new DeferredBodyAction<StatsCountRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/stats/count";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(__workflow_end);
                return new ApiConnectionAction<StatsCountRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageStatsMeasureRo, ApiConnectionActionConfiguration> GetStatsLast(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<DirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = WorkflowExpression.Compile(sortValues, nameof(sortValues), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_orFilter = WorkflowExpression.Compile(orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<PageStatsMeasureRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/stats/last";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                return new ApiConnectionAction<PageStatsMeasureRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageStatsMeasureRo, ApiConnectionActionConfiguration> GetThingStatsLast(Expression<Func<string>> thingId, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<DirInput>> dir = null, Expression<Func<string>> orFilter = null)
        {
            var __workflow_thingId = WorkflowExpression.Compile(thingId, nameof(thingId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = WorkflowExpression.Compile(sortValues, nameof(sortValues), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_orFilter = WorkflowExpression.Compile(orFilter, nameof(orFilter), required: false);
            return new DeferredBodyAction<PageStatsMeasureRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/stats/last/things/{0}", __workflow_thingId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                return new ApiConnectionAction<PageStatsMeasureRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageStatsMeasureRo, ApiConnectionActionConfiguration> GetStatsMax(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<DirInput>> dir = null, Expression<Func<string>> orFilter = null, Expression<Func<int>> start = null, Expression<Func<int>> end = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = WorkflowExpression.Compile(sortValues, nameof(sortValues), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_orFilter = WorkflowExpression.Compile(orFilter, nameof(orFilter), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_end = WorkflowExpression.Compile(end, nameof(end), required: false);
            return new DeferredBodyAction<PageStatsMeasureRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/stats/max";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(__workflow_end);
                return new ApiConnectionAction<PageStatsMeasureRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<StatsGraphRo[], ApiConnectionActionConfiguration> GetStatsMeasurements(Expression<Func<int>> start, Expression<Func<int>> end, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<DirInput>> dir = null, Expression<Func<string>> orFilter = null, Expression<Func<int>> time = null, Expression<Func<string>> interval = null)
        {
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: true);
            var __workflow_end = WorkflowExpression.Compile(end, nameof(end), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = WorkflowExpression.Compile(sortValues, nameof(sortValues), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_orFilter = WorkflowExpression.Compile(orFilter, nameof(orFilter), required: false);
            var __workflow_time = WorkflowExpression.Compile(time, nameof(time), required: false);
            var __workflow_interval = WorkflowExpression.Compile(interval, nameof(interval), required: false);
            return new DeferredBodyAction<StatsGraphRo[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/stats/measurements";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                if (__workflow_time != null)
                    callPayload.Queries["time"] = ExpressionConverter.Convert(__workflow_time);
                if (__workflow_interval != null)
                    callPayload.Queries["interval"] = ExpressionConverter.Convert(__workflow_interval);
                callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                callPayload.Queries["end"] = ExpressionConverter.Convert(__workflow_end);
                return new ApiConnectionAction<StatsGraphRo[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<PageStatsMeasureRo, ApiConnectionActionConfiguration> GetStatsMin(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<DirInput>> dir = null, Expression<Func<string>> orFilter = null, Expression<Func<int>> start = null, Expression<Func<int>> end = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = WorkflowExpression.Compile(sortValues, nameof(sortValues), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_orFilter = WorkflowExpression.Compile(orFilter, nameof(orFilter), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_end = WorkflowExpression.Compile(end, nameof(end), required: false);
            return new DeferredBodyAction<PageStatsMeasureRo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/stats/min";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(__workflow_end);
                return new ApiConnectionAction<PageStatsMeasureRo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<StatsCountRo[], ApiConnectionActionConfiguration> GetStatsRepartition(Expression<Func<string>> attribute, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<DirInput>> dir = null, Expression<Func<string>> orFilter = null, Expression<Func<int>> start = null, Expression<Func<int>> end = null)
        {
            var __workflow_attribute = WorkflowExpression.Compile(attribute, nameof(attribute), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = WorkflowExpression.Compile(sortValues, nameof(sortValues), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_orFilter = WorkflowExpression.Compile(orFilter, nameof(orFilter), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_end = WorkflowExpression.Compile(end, nameof(end), required: false);
            return new DeferredBodyAction<StatsCountRo[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/stats/repartition";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["attribute"] = ExpressionConverter.Convert(__workflow_attribute);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(__workflow_end);
                return new ApiConnectionAction<StatsCountRo[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pilotthings")]
        public IBodyWorkflowAction<StatsGraphRo[], ApiConnectionActionConfiguration> GetStatsSum(Expression<Func<int>> start, Expression<Func<int>> end, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortValues = null, Expression<Func<string>> sort = null, Expression<Func<string>> filter = null, Expression<Func<DirInput>> dir = null, Expression<Func<string>> orFilter = null, Expression<Func<int>> time = null, Expression<Func<string>> interval = null)
        {
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: true);
            var __workflow_end = WorkflowExpression.Compile(end, nameof(end), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sortValues = WorkflowExpression.Compile(sortValues, nameof(sortValues), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_dir = WorkflowExpression.Compile(dir, nameof(dir), required: false);
            var __workflow_orFilter = WorkflowExpression.Compile(orFilter, nameof(orFilter), required: false);
            var __workflow_time = WorkflowExpression.Compile(time, nameof(time), required: false);
            var __workflow_interval = WorkflowExpression.Compile(interval, nameof(interval), required: false);
            return new DeferredBodyAction<StatsGraphRo[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/stats/sum";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortValues != null)
                    callPayload.Queries["sortValues"] = ExpressionConverter.Convert(__workflow_sortValues);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(__workflow_dir);
                if (__workflow_orFilter != null)
                    callPayload.Queries["orFilter"] = ExpressionConverter.Convert(__workflow_orFilter);
                if (__workflow_time != null)
                    callPayload.Queries["time"] = ExpressionConverter.Convert(__workflow_time);
                if (__workflow_interval != null)
                    callPayload.Queries["interval"] = ExpressionConverter.Convert(__workflow_interval);
                callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                callPayload.Queries["end"] = ExpressionConverter.Convert(__workflow_end);
                return new ApiConnectionAction<StatsGraphRo[]>(callPayload);
            });
        }
    }

    public class PilotthingsTriggers([ConnectionName] string connectionId)
    {
    }

    public class PageAlertRo
    {
        [JsonProperty("data")]
        public AlertRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public class AlertRo
    {
        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("creationDate")]
        public int CreationDate { get; set; }

        [JsonProperty("flowOrigin")]
        public FlowTinyRo FlowOrigin { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastUpdate")]
        public int LastUpdate { get; set; }

        [JsonProperty("level")]
        public AlertRoLevelType Level { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("state")]
        public AlertRoStateType State { get; set; }

        [JsonProperty("thing")]
        public AddMessageThingTinyRoResponse Thing { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public class FlowTinyRo
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AlertRoLevelType
    {
        INFO,
        WARNING,
        CRITICAL
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AlertRoStateType
    {
        OPENED,
        IGNORED,
        [EnumMember(Value = "IN_PROGRESS")]
        INPROGRESS,
        RESOLVED
    }

    public class AddMessageThingTinyRoResponse
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("fixedName")]
        public string FixedName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nbAlerts")]
        public int NbAlerts { get; set; }

        [JsonProperty("tags")]
        public AddMessageThingTagRoResponse[] Tags { get; set; }
    }

    public class AddMessageThingTagRoResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DirInput
    {
        ASC,
        DESC
    }

    public class PageMeasureRo
    {
        [JsonProperty("data")]
        public MeasureRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public class MeasureRo
    {
        [JsonProperty("attribute")]
        public AttributeTinyRo Attribute { get; set; }

        [JsonProperty("dtype")]
        public string Dtype { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("model")]
        public AssociateThingProductModelTinyRoResponse Model { get; set; }

        [JsonProperty("product")]
        public AssociateThingProductProductTinyRoResponse Product { get; set; }

        [JsonProperty("thing")]
        public AddMessageThingTinyRoResponse Thing { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class AttributeTinyRo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public QuantityKindRo Type { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class QuantityKindRo
    {
        [JsonProperty("defaultUnit")]
        public string DefaultUnit { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AssociateThingProductModelTinyRoResponse
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("generateLinks")]
        public bool GenerateLinks { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isCustomModel")]
        public bool IsCustomModel { get; set; }

        [JsonProperty("link")]
        public AddMessageURIResponse Link { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AddMessageURIResponse
    {
        [JsonProperty("absolute")]
        public bool Absolute { get; set; }

        [JsonProperty("authority")]
        public string Authority { get; set; }

        [JsonProperty("fragment")]
        public string Fragment { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("opaque")]
        public bool Opaque { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("port")]
        public int Port { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("rawAuthority")]
        public string RawAuthority { get; set; }

        [JsonProperty("rawFragment")]
        public string RawFragment { get; set; }

        [JsonProperty("rawPath")]
        public string RawPath { get; set; }

        [JsonProperty("rawQuery")]
        public string RawQuery { get; set; }

        [JsonProperty("rawSchemeSpecificPart")]
        public string RawSchemeSpecificPart { get; set; }

        [JsonProperty("rawUserInfo")]
        public string RawUserInfo { get; set; }

        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        [JsonProperty("schemeSpecificPart")]
        public string SchemeSpecificPart { get; set; }

        [JsonProperty("userInfo")]
        public string UserInfo { get; set; }
    }

    public class AssociateThingProductProductTinyRoResponse
    {
        [JsonProperty("connectivityTypes")]
        public AssociateThingProductProductTinyRoConnectivityTypesTypeItemResponse[] ConnectivityTypes { get; set; }

        [JsonProperty("generateLinks")]
        public bool GenerateLinks { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("manufacturer")]
        public AssociateThingProductManufacturerTinyRoResponse Manufacturer { get; set; }

        [JsonProperty("model")]
        public AssociateThingProductModelTinyRoResponse Model { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AssociateThingProductProductTinyRoConnectivityTypesTypeItemResponse
    {
        LORA,
        SIGFOX,
        MQTT,
        CELLULAR,
        ETHERNET,
        WIFI,
        BLUETOOTH,
        BACNET,
        MODBUS,
        [EnumMember(Value = "IO_ANALOG")]
        IOANALOG,
        [EnumMember(Value = "IO_DIGITAL")]
        IODIGITAL,
        ENOCEAN,
        ZIGBEE,
        ZWAVE,
        NFC,
        USB,
        [EnumMember(Value = "IEEE_LR_WPAN")]
        IEEELRWPAN,
        DALI,
        UNKNOWN
    }

    public class AssociateThingProductManufacturerTinyRoResponse
    {
        [JsonProperty("generateLinks")]
        public bool GenerateLinks { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CountRo
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class PageMessageRo
    {
        [JsonProperty("data")]
        public MessageRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public class MessageRo
    {
        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("link")]
        public AddMessageURIResponse Link { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("measurements")]
        public AddMessageJsonNodeResponse Measurements { get; set; }

        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("processed")]
        public MessageRoProcessedType Processed { get; set; }

        [JsonProperty("rawMeasurements")]
        public AddMessageJsonNodeResponse RawMeasurements { get; set; }

        [JsonProperty("thing")]
        public AddMessageThingTinyRoResponse Thing { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }
    }

    public class AddMessageJsonNodeResponse
    {
        [JsonProperty("array")]
        public bool Array { get; set; }

        [JsonProperty("bigDecimal")]
        public bool BigDecimal { get; set; }

        [JsonProperty("bigInteger")]
        public bool BigInteger { get; set; }

        [JsonProperty("binary")]
        public bool Binary { get; set; }

        [JsonProperty("boolean")]
        public bool Boolean { get; set; }

        [JsonProperty("containerNode")]
        public bool ContainerNode { get; set; }

        [JsonProperty("double")]
        public bool Double { get; set; }

        [JsonProperty("float")]
        public bool Float { get; set; }

        [JsonProperty("floatingPointNumber")]
        public bool FloatingPointNumber { get; set; }

        [JsonProperty("int")]
        public bool Int { get; set; }

        [JsonProperty("integralNumber")]
        public bool IntegralNumber { get; set; }

        [JsonProperty("long")]
        public bool Long { get; set; }

        [JsonProperty("missingNode")]
        public bool MissingNode { get; set; }

        [JsonProperty("nodeType")]
        public AddMessageJsonNodeNodeTypeTypeResponse NodeType { get; set; }

        [JsonProperty("null")]
        public bool Null { get; set; }

        [JsonProperty("number")]
        public bool Number { get; set; }

        [JsonProperty("object")]
        public bool ObjectEntity { get; set; }

        [JsonProperty("pojo")]
        public bool Pojo { get; set; }

        [JsonProperty("short")]
        public bool Short { get; set; }

        [JsonProperty("textual")]
        public bool Textual { get; set; }

        [JsonProperty("valueNode")]
        public bool ValueNode { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddMessageJsonNodeNodeTypeTypeResponse
    {
        ARRAY,
        BINARY,
        BOOLEAN,
        MISSING,
        NULL,
        NUMBER,
        [EnumMember(Value = "OBJECT")]
        ObjectEntity,
        POJO,
        STRING
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MessageRoProcessedType
    {
        TODO,
        DONE,
        [EnumMember(Value = "IN_PROGRESS")]
        INPROGRESS,
        ASSOCIATED,
        [EnumMember(Value = "TO_BE_FORWARDED")]
        TOBEFORWARDED,
        [EnumMember(Value = "ERROR_CUSTOM")]
        ERRORCUSTOM,
        [EnumMember(Value = "TODO_CUSTOM")]
        TODOCUSTOM,
        ERROR
    }

    public class AddMessageMessageRoInput
    {
        public AddMessageMessageRoInput(string body, string creationDate, string errorMessage, double latitude, double longitude, string metadata, int number, MessageRoInputProcessedType processed, AddMessageThingTinyRo thing, string timestamp, string topic)
        {
            this.Body = body;
            this.CreationDate = creationDate;
            this.ErrorMessage = errorMessage;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Metadata = metadata;
            this.Number = number;
            this.Processed = processed;
            this.Thing = thing;
            this.Timestamp = timestamp;
            this.Topic = topic;
        }

        [JsonProperty("body", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }

        [JsonProperty("creationDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CreationDate { get; set; }

        [JsonProperty("errorMessage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ErrorMessage { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("latitude", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Latitude { get; set; }

        [JsonProperty("link")]
        public AddMessageURI Link { get; set; }

        [JsonProperty("longitude", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Longitude { get; set; }

        [JsonProperty("measurements")]
        public JToken Measurements { get; set; }

        [JsonProperty("metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Metadata { get; set; }

        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Number { get; set; }

        [JsonProperty("processed", DefaultValueHandling = DefaultValueHandling.Include)]
        public MessageRoInputProcessedType Processed { get; set; }

        [JsonProperty("rawMeasurements")]
        public AddMessageJsonNode RawMeasurements { get; set; }

        [JsonProperty("thing", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddMessageThingTinyRo Thing { get; set; }

        [JsonProperty("timestamp", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Timestamp { get; set; }

        [JsonProperty("topic", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Topic { get; set; }
    }

    public class AddMessageURI
    {
        [JsonProperty("absolute")]
        public bool? Absolute { get; set; }

        [JsonProperty("authority")]
        public string Authority { get; set; }

        [JsonProperty("fragment")]
        public string Fragment { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("opaque")]
        public bool? Opaque { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("port")]
        public int? Port { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("rawAuthority")]
        public string RawAuthority { get; set; }

        [JsonProperty("rawFragment")]
        public string RawFragment { get; set; }

        [JsonProperty("rawPath")]
        public string RawPath { get; set; }

        [JsonProperty("rawQuery")]
        public string RawQuery { get; set; }

        [JsonProperty("rawSchemeSpecificPart")]
        public string RawSchemeSpecificPart { get; set; }

        [JsonProperty("rawUserInfo")]
        public string RawUserInfo { get; set; }

        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        [JsonProperty("schemeSpecificPart")]
        public string SchemeSpecificPart { get; set; }

        [JsonProperty("userInfo")]
        public string UserInfo { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MessageRoInputProcessedType
    {
        TODO,
        DONE,
        [EnumMember(Value = "IN_PROGRESS")]
        INPROGRESS,
        ASSOCIATED,
        [EnumMember(Value = "TO_BE_FORWARDED")]
        TOBEFORWARDED,
        [EnumMember(Value = "ERROR_CUSTOM")]
        ERRORCUSTOM,
        [EnumMember(Value = "TODO_CUSTOM")]
        TODOCUSTOM,
        ERROR
    }

    public class AddMessageJsonNode
    {
        [JsonProperty("array")]
        public bool? Array { get; set; }

        [JsonProperty("bigDecimal")]
        public bool? BigDecimal { get; set; }

        [JsonProperty("bigInteger")]
        public bool? BigInteger { get; set; }

        [JsonProperty("binary")]
        public bool? Binary { get; set; }

        [JsonProperty("boolean")]
        public bool? Boolean { get; set; }

        [JsonProperty("containerNode")]
        public bool? ContainerNode { get; set; }

        [JsonProperty("double")]
        public bool? Double { get; set; }

        [JsonProperty("float")]
        public bool? Float { get; set; }

        [JsonProperty("floatingPointNumber")]
        public bool? FloatingPointNumber { get; set; }

        [JsonProperty("int")]
        public bool? Int { get; set; }

        [JsonProperty("integralNumber")]
        public bool? IntegralNumber { get; set; }

        [JsonProperty("long")]
        public bool? Long { get; set; }

        [JsonProperty("missingNode")]
        public bool? MissingNode { get; set; }

        [JsonProperty("nodeType")]
        public AddMessageJsonNodeNodeTypeType? NodeType { get; set; }

        [JsonProperty("null")]
        public bool? Null { get; set; }

        [JsonProperty("number")]
        public bool? Number { get; set; }

        [JsonProperty("object")]
        public bool? ObjectEntity { get; set; }

        [JsonProperty("pojo")]
        public bool? Pojo { get; set; }

        [JsonProperty("short")]
        public bool? Short { get; set; }

        [JsonProperty("textual")]
        public bool? Textual { get; set; }

        [JsonProperty("valueNode")]
        public bool? ValueNode { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddMessageJsonNodeNodeTypeType
    {
        ARRAY,
        BINARY,
        BOOLEAN,
        MISSING,
        NULL,
        NUMBER,
        [EnumMember(Value = "OBJECT")]
        ObjectEntity,
        POJO,
        STRING
    }

    public class AddMessageThingTinyRo
    {
        public AddMessageThingTinyRo(string name)
        {
            this.Name = name;
        }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("fixedName")]
        public string FixedName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("nbAlerts")]
        public int? NbAlerts { get; set; }

        [JsonProperty("tags")]
        public AddMessageThingTagRo[] Tags { get; set; }
    }

    public class AddMessageThingTagRo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }
    }

    public class PageSiteRo
    {
        [JsonProperty("data")]
        public AssociateThingProductSiteRoResponse[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public class AssociateThingProductSiteRoResponse
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
    }

    public class NodeInput
    {
        [JsonProperty("array")]
        public bool? Array { get; set; }

        [JsonProperty("bigDecimal")]
        public bool? BigDecimal { get; set; }

        [JsonProperty("bigInteger")]
        public bool? BigInteger { get; set; }

        [JsonProperty("binary")]
        public bool? Binary { get; set; }

        [JsonProperty("boolean")]
        public bool? Boolean { get; set; }

        [JsonProperty("containerNode")]
        public bool? ContainerNode { get; set; }

        [JsonProperty("double")]
        public bool? Double { get; set; }

        [JsonProperty("float")]
        public bool? Float { get; set; }

        [JsonProperty("floatingPointNumber")]
        public bool? FloatingPointNumber { get; set; }

        [JsonProperty("int")]
        public bool? Int { get; set; }

        [JsonProperty("integralNumber")]
        public bool? IntegralNumber { get; set; }

        [JsonProperty("long")]
        public bool? Long { get; set; }

        [JsonProperty("missingNode")]
        public bool? MissingNode { get; set; }

        [JsonProperty("nodeType")]
        public NodeInputNodeTypeType? NodeType { get; set; }

        [JsonProperty("null")]
        public bool? Null { get; set; }

        [JsonProperty("number")]
        public bool? Number { get; set; }

        [JsonProperty("object")]
        public bool? ObjectEntity { get; set; }

        [JsonProperty("pojo")]
        public bool? Pojo { get; set; }

        [JsonProperty("short")]
        public bool? Short { get; set; }

        [JsonProperty("textual")]
        public bool? Textual { get; set; }

        [JsonProperty("valueNode")]
        public bool? ValueNode { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NodeInputNodeTypeType
    {
        ARRAY,
        BINARY,
        BOOLEAN,
        MISSING,
        NULL,
        NUMBER,
        [EnumMember(Value = "OBJECT")]
        ObjectEntity,
        POJO,
        STRING
    }

    public class SiteRoInput
    {
        public SiteRoInput(string address, string city, string name, string postalCode)
        {
            this.Address = address;
            this.City = city;
            this.Name = name;
            this.PostalCode = postalCode;
        }

        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Address { get; set; }

        [JsonProperty("city", DefaultValueHandling = DefaultValueHandling.Include)]
        public string City { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("postalCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PostalCode { get; set; }
    }

    public class PageThingTagRo
    {
        [JsonProperty("data")]
        public AddMessageThingTagRoResponse[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public class AddThingTagTagRoResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }
    }

    public class ThingTagRoInput
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }
    }

    public class PageSingleThingRo
    {
        [JsonProperty("data")]
        public SingleThingRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public class SingleThingRo
    {
        [JsonProperty("application")]
        public AssociateThingProductApplicationTinyRoResponse Application { get; set; }

        [JsonProperty("connectivity")]
        public AssociateThingProductConnectivityRoResponse Connectivity { get; set; }

        [JsonProperty("customFields")]
        public AssociateThingProductCustomFieldRoResponse[] CustomFields { get; set; }

        [JsonProperty("customModel")]
        public AssociateThingProductCustomModelTinyRoResponse CustomModel { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("device")]
        public AssociateThingProductDeviceRoResponse Device { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("dynamicGps")]
        public bool DynamicGps { get; set; }

        [JsonProperty("fixedLatitude")]
        public double FixedLatitude { get; set; }

        [JsonProperty("fixedLongitude")]
        public double FixedLongitude { get; set; }

        [JsonProperty("fixedName")]
        public string FixedName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastActivityDate")]
        public int LastActivityDate { get; set; }

        [JsonProperty("lastLatitude")]
        public double LastLatitude { get; set; }

        [JsonProperty("lastLongitude")]
        public double LastLongitude { get; set; }

        [JsonProperty("lastMeasurements")]
        public AddMessageJsonNodeResponse LastMeasurements { get; set; }

        [JsonProperty("lastMeasurementsTimestamps")]
        public AddMessageJsonNodeResponse LastMeasurementsTimestamps { get; set; }

        [JsonProperty("lastMessageDate")]
        public int LastMessageDate { get; set; }

        [JsonProperty("messageActivityTimeoutPeriod")]
        public int MessageActivityTimeoutPeriod { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nbAlerts")]
        public int NbAlerts { get; set; }

        [JsonProperty("product")]
        public AssociateThingProductProductTinyRoResponse Product { get; set; }

        [JsonProperty("site")]
        public AssociateThingProductSiteRoResponse Site { get; set; }

        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        [JsonProperty("status")]
        public SingleThingRoStatusType Status { get; set; }

        [JsonProperty("tags")]
        public AddMessageThingTagRoResponse[] Tags { get; set; }
    }

    public class AssociateThingProductApplicationTinyRoResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AssociateThingProductConnectivityRoResponse
    {
        [JsonProperty("additionalProperties")]
        public JToken AdditionalProperties { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("rawStatus")]
        public string RawStatus { get; set; }

        [JsonProperty("status")]
        public AssociateThingProductConnectivityRoStatusTypeResponse Status { get; set; }

        [JsonProperty("type")]
        public AssociateThingProductConnectivityRoTypeTypeResponse Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AssociateThingProductConnectivityRoStatusTypeResponse
    {
        INACTIVE,
        ONLINE,
        OFFLINE,
        ERROR,
        UNKNOWN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AssociateThingProductConnectivityRoTypeTypeResponse
    {
        LORA,
        SIGFOX,
        MQTT,
        CELLULAR,
        ETHERNET,
        WIFI,
        BLUETOOTH,
        BACNET,
        MODBUS,
        [EnumMember(Value = "IO_ANALOG")]
        IOANALOG,
        [EnumMember(Value = "IO_DIGITAL")]
        IODIGITAL,
        ENOCEAN,
        ZIGBEE,
        ZWAVE,
        NFC,
        USB,
        [EnumMember(Value = "IEEE_LR_WPAN")]
        IEEELRWPAN,
        DALI,
        UNKNOWN
    }

    public class AssociateThingProductCustomFieldRoResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public AssociateThingProductCustomFieldRoTypeTypeResponse Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AssociateThingProductCustomFieldRoTypeTypeResponse
    {
        TEXT,
        TEXTEREA,
        FILE
    }

    public class AssociateThingProductCustomModelTinyRoResponse
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AssociateThingProductDeviceRoResponse
    {
        [JsonProperty("batteryLevel")]
        public int BatteryLevel { get; set; }

        [JsonProperty("batteryStatus")]
        public AssociateThingProductDeviceRoBatteryStatusTypeResponse BatteryStatus { get; set; }

        [JsonProperty("deviceType")]
        public string DeviceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("memoryFree")]
        public int MemoryFree { get; set; }

        [JsonProperty("memoryTotal")]
        public int MemoryTotal { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("modelNumber")]
        public string ModelNumber { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("status")]
        public AssociateThingProductDeviceRoStatusTypeResponse Status { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AssociateThingProductDeviceRoBatteryStatusTypeResponse
    {
        NORMAL,
        CHARGING,
        [EnumMember(Value = "CHARGE_COMPLETE")]
        CHARGECOMPLETE,
        DAMAGED,
        [EnumMember(Value = "LOW_BATTERY")]
        LOWBATTERY,
        [EnumMember(Value = "NOT_INSTALLED")]
        NOTINSTALLED,
        UNKNOWN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AssociateThingProductDeviceRoStatusTypeResponse
    {
        RUNNING,
        HALTED,
        ERROR,
        UNKNOWN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SingleThingRoStatusType
    {
        PROVISIONED,
        PENDING,
        INACTIVE,
        ACTIVE,
        WARNING,
        SUSPENDED,
        DELETED,
        [EnumMember(Value = "IN_ASSOCIATION")]
        INASSOCIATION,
        [EnumMember(Value = "IN_DISSOCIATION")]
        INDISSOCIATION,
        [EnumMember(Value = "OUT_OF_ORDER")]
        OUTOFORDER,
        CREATED,
        VIRTUAL
    }

    public class JsonInput
    {
        [JsonProperty("array")]
        public bool? Array { get; set; }

        [JsonProperty("bigDecimal")]
        public bool? BigDecimal { get; set; }

        [JsonProperty("bigInteger")]
        public bool? BigInteger { get; set; }

        [JsonProperty("binary")]
        public bool? Binary { get; set; }

        [JsonProperty("boolean")]
        public bool? Boolean { get; set; }

        [JsonProperty("containerNode")]
        public bool? ContainerNode { get; set; }

        [JsonProperty("double")]
        public bool? Double { get; set; }

        [JsonProperty("float")]
        public bool? Float { get; set; }

        [JsonProperty("floatingPointNumber")]
        public bool? FloatingPointNumber { get; set; }

        [JsonProperty("int")]
        public bool? Int { get; set; }

        [JsonProperty("integralNumber")]
        public bool? IntegralNumber { get; set; }

        [JsonProperty("long")]
        public bool? Long { get; set; }

        [JsonProperty("missingNode")]
        public bool? MissingNode { get; set; }

        [JsonProperty("nodeType")]
        public JsonInputNodeTypeType? NodeType { get; set; }

        [JsonProperty("null")]
        public bool? Null { get; set; }

        [JsonProperty("number")]
        public bool? Number { get; set; }

        [JsonProperty("object")]
        public bool? ObjectEntity { get; set; }

        [JsonProperty("pojo")]
        public bool? Pojo { get; set; }

        [JsonProperty("short")]
        public bool? Short { get; set; }

        [JsonProperty("textual")]
        public bool? Textual { get; set; }

        [JsonProperty("valueNode")]
        public bool? ValueNode { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JsonInputNodeTypeType
    {
        ARRAY,
        BINARY,
        BOOLEAN,
        MISSING,
        NULL,
        NUMBER,
        [EnumMember(Value = "OBJECT")]
        ObjectEntity,
        POJO,
        STRING
    }

    public class ThingRo
    {
        [JsonProperty("customFields")]
        public AssociateThingProductCustomFieldRoResponse[] CustomFields { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("dynamicGps")]
        public bool DynamicGps { get; set; }

        [JsonProperty("fixedLatitude")]
        public double FixedLatitude { get; set; }

        [JsonProperty("fixedLongitude")]
        public double FixedLongitude { get; set; }

        [JsonProperty("fixedName")]
        public string FixedName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastActivityDate")]
        public int LastActivityDate { get; set; }

        [JsonProperty("lastLatitude")]
        public double LastLatitude { get; set; }

        [JsonProperty("lastLongitude")]
        public double LastLongitude { get; set; }

        [JsonProperty("lastMeasurements")]
        public AddMessageJsonNodeResponse LastMeasurements { get; set; }

        [JsonProperty("lastMeasurementsTimestamps")]
        public AddMessageJsonNodeResponse LastMeasurementsTimestamps { get; set; }

        [JsonProperty("lastMessageDate")]
        public int LastMessageDate { get; set; }

        [JsonProperty("messageActivityTimeoutPeriod")]
        public int MessageActivityTimeoutPeriod { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nbAlerts")]
        public int NbAlerts { get; set; }

        [JsonProperty("site")]
        public AssociateThingProductSiteRoResponse Site { get; set; }

        [JsonProperty("status")]
        public ThingRoStatusType Status { get; set; }

        [JsonProperty("tags")]
        public AddMessageThingTagRoResponse[] Tags { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ThingRoStatusType
    {
        PROVISIONED,
        PENDING,
        INACTIVE,
        ACTIVE,
        WARNING,
        SUSPENDED,
        DELETED,
        [EnumMember(Value = "IN_ASSOCIATION")]
        INASSOCIATION,
        [EnumMember(Value = "IN_DISSOCIATION")]
        INDISSOCIATION,
        [EnumMember(Value = "OUT_OF_ORDER")]
        OUTOFORDER,
        CREATED,
        VIRTUAL
    }

    public class PutThingThingRoInput
    {
        public PutThingThingRoInput(PutThingApplicationTinyRo application, PutThingConnectivityRo connectivity, PutThingDeviceRo device, string name)
        {
            this.Application = application;
            this.Connectivity = connectivity;
            this.Device = device;
            this.Name = name;
        }

        [JsonProperty("application", DefaultValueHandling = DefaultValueHandling.Include)]
        public PutThingApplicationTinyRo Application { get; set; }

        [JsonProperty("connectivity", DefaultValueHandling = DefaultValueHandling.Include)]
        public PutThingConnectivityRo Connectivity { get; set; }

        [JsonProperty("customFields")]
        public PutThingCustomFieldRo[] CustomFields { get; set; }

        [JsonProperty("customModel")]
        public PutThingCustomModelTinyRo CustomModel { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("device", DefaultValueHandling = DefaultValueHandling.Include)]
        public PutThingDeviceRo Device { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("dynamicGps")]
        public bool? DynamicGps { get; set; }

        [JsonProperty("fixedLatitude")]
        public double? FixedLatitude { get; set; }

        [JsonProperty("fixedLongitude")]
        public double? FixedLongitude { get; set; }

        [JsonProperty("fixedName")]
        public string FixedName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastActivityDate")]
        public int? LastActivityDate { get; set; }

        [JsonProperty("lastLatitude")]
        public double? LastLatitude { get; set; }

        [JsonProperty("lastLongitude")]
        public double? LastLongitude { get; set; }

        [JsonProperty("lastMeasurements")]
        public AddMessageJsonNode LastMeasurements { get; set; }

        [JsonProperty("lastMeasurementsTimestamps")]
        public AddMessageJsonNode LastMeasurementsTimestamps { get; set; }

        [JsonProperty("lastMessageDate")]
        public int? LastMessageDate { get; set; }

        [JsonProperty("messageActivityTimeoutPeriod")]
        public int? MessageActivityTimeoutPeriod { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("nbAlerts")]
        public int? NbAlerts { get; set; }

        [JsonProperty("product")]
        public PutThingProductTinyRo Product { get; set; }

        [JsonProperty("site")]
        public PutThingSiteRo Site { get; set; }

        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        [JsonProperty("status")]
        public ThingRoInputStatusType? Status { get; set; }

        [JsonProperty("tags")]
        public AddMessageThingTagRo[] Tags { get; set; }
    }

    public class PutThingApplicationTinyRo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PutThingConnectivityRo
    {
        [JsonProperty("additionalProperties")]
        public JToken AdditionalProperties { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("rawStatus")]
        public string RawStatus { get; set; }

        [JsonProperty("status")]
        public PutThingConnectivityRoStatusType? Status { get; set; }

        [JsonProperty("type")]
        public PutThingConnectivityRoTypeType? Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PutThingConnectivityRoStatusType
    {
        INACTIVE,
        ONLINE,
        OFFLINE,
        ERROR,
        UNKNOWN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PutThingConnectivityRoTypeType
    {
        LORA,
        SIGFOX,
        MQTT,
        CELLULAR,
        ETHERNET,
        WIFI,
        BLUETOOTH,
        BACNET,
        MODBUS,
        [EnumMember(Value = "IO_ANALOG")]
        IOANALOG,
        [EnumMember(Value = "IO_DIGITAL")]
        IODIGITAL,
        ENOCEAN,
        ZIGBEE,
        ZWAVE,
        NFC,
        USB,
        [EnumMember(Value = "IEEE_LR_WPAN")]
        IEEELRWPAN,
        DALI,
        UNKNOWN
    }

    public class PutThingCustomFieldRo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public PutThingCustomFieldRoTypeType? Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PutThingCustomFieldRoTypeType
    {
        TEXT,
        TEXTEREA,
        FILE
    }

    public class PutThingCustomModelTinyRo
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PutThingDeviceRo
    {
        [JsonProperty("batteryLevel")]
        public int? BatteryLevel { get; set; }

        [JsonProperty("batteryStatus")]
        public PutThingDeviceRoBatteryStatusType? BatteryStatus { get; set; }

        [JsonProperty("deviceType")]
        public string DeviceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("memoryFree")]
        public int? MemoryFree { get; set; }

        [JsonProperty("memoryTotal")]
        public int? MemoryTotal { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("modelNumber")]
        public string ModelNumber { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("status")]
        public PutThingDeviceRoStatusType? Status { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PutThingDeviceRoBatteryStatusType
    {
        NORMAL,
        CHARGING,
        [EnumMember(Value = "CHARGE_COMPLETE")]
        CHARGECOMPLETE,
        DAMAGED,
        [EnumMember(Value = "LOW_BATTERY")]
        LOWBATTERY,
        [EnumMember(Value = "NOT_INSTALLED")]
        NOTINSTALLED,
        UNKNOWN
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PutThingDeviceRoStatusType
    {
        RUNNING,
        HALTED,
        ERROR,
        UNKNOWN
    }

    public class PutThingProductTinyRo
    {
        [JsonProperty("connectivityTypes")]
        public PutThingProductTinyRoConnectivityTypesTypeItem[] ConnectivityTypes { get; set; }

        [JsonProperty("generateLinks")]
        public bool? GenerateLinks { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("manufacturer")]
        public AssociateThingProductManufacturerTinyRo Manufacturer { get; set; }

        [JsonProperty("model")]
        public AssociateThingProductModelTinyRo Model { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PutThingProductTinyRoConnectivityTypesTypeItem
    {
        LORA,
        SIGFOX,
        MQTT,
        CELLULAR,
        ETHERNET,
        WIFI,
        BLUETOOTH,
        BACNET,
        MODBUS,
        [EnumMember(Value = "IO_ANALOG")]
        IOANALOG,
        [EnumMember(Value = "IO_DIGITAL")]
        IODIGITAL,
        ENOCEAN,
        ZIGBEE,
        ZWAVE,
        NFC,
        USB,
        [EnumMember(Value = "IEEE_LR_WPAN")]
        IEEELRWPAN,
        DALI,
        UNKNOWN
    }

    public class AssociateThingProductManufacturerTinyRo
    {
        [JsonProperty("generateLinks")]
        public bool? GenerateLinks { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AssociateThingProductModelTinyRo
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("generateLinks")]
        public bool? GenerateLinks { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isCustomModel")]
        public bool? IsCustomModel { get; set; }

        [JsonProperty("link")]
        public AddMessageURI Link { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PutThingSiteRo
    {
        public PutThingSiteRo(string address, string city, string name, string postalCode)
        {
            this.Address = address;
            this.City = city;
            this.Name = name;
            this.PostalCode = postalCode;
        }

        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Address { get; set; }

        [JsonProperty("city", DefaultValueHandling = DefaultValueHandling.Include)]
        public string City { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("postalCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PostalCode { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ThingRoInputStatusType
    {
        PROVISIONED,
        PENDING,
        INACTIVE,
        ACTIVE,
        WARNING,
        SUSPENDED,
        DELETED,
        [EnumMember(Value = "IN_ASSOCIATION")]
        INASSOCIATION,
        [EnumMember(Value = "IN_DISSOCIATION")]
        INDISSOCIATION,
        [EnumMember(Value = "OUT_OF_ORDER")]
        OUTOFORDER,
        CREATED,
        VIRTUAL
    }

    public class ModelRo
    {
        [JsonProperty("attributes")]
        public AttributeRo[] Attributes { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isCustomModel")]
        public bool IsCustomModel { get; set; }

        [JsonProperty("link")]
        public AddMessageURIResponse Link { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("operations")]
        public OperationRo[] Operations { get; set; }
    }

    public class AttributeRo
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public QuantityKindRo Type { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class OperationRo
    {
        [JsonProperty("args")]
        public string Args { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PageCustomFieldRo
    {
        [JsonProperty("data")]
        public PageCustomFieldRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public class CustomFieldRoInput
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public CustomFieldRoInputTypeType? Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CustomFieldRoInputTypeType
    {
        TEXT,
        TEXTEREA,
        FILE
    }

    public class ResponseEntity
    {
        [JsonProperty("body")]
        public JToken Body { get; set; }

        [JsonProperty("statusCode")]
        public ResponseEntityStatusCodeType StatusCode { get; set; }

        [JsonProperty("statusCodeValue")]
        public int StatusCodeValue { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ResponseEntityStatusCodeType
    {
        [EnumMember(Value = "100")]
        _100,
        [EnumMember(Value = "101")]
        _101,
        [EnumMember(Value = "102")]
        _102,
        [EnumMember(Value = "103")]
        _103,
        [EnumMember(Value = "200")]
        _200,
        [EnumMember(Value = "201")]
        _201,
        [EnumMember(Value = "202")]
        _202,
        [EnumMember(Value = "203")]
        _203,
        [EnumMember(Value = "204")]
        _204,
        [EnumMember(Value = "205")]
        _205,
        [EnumMember(Value = "206")]
        _206,
        [EnumMember(Value = "207")]
        _207,
        [EnumMember(Value = "208")]
        _208,
        [EnumMember(Value = "226")]
        _226,
        [EnumMember(Value = "300")]
        _300,
        [EnumMember(Value = "301")]
        _301,
        [EnumMember(Value = "302")]
        _302,
        [EnumMember(Value = "303")]
        _303,
        [EnumMember(Value = "304")]
        _304,
        [EnumMember(Value = "305")]
        _305,
        [EnumMember(Value = "307")]
        _307,
        [EnumMember(Value = "308")]
        _308,
        [EnumMember(Value = "400")]
        _400,
        [EnumMember(Value = "401")]
        _401,
        [EnumMember(Value = "402")]
        _402,
        [EnumMember(Value = "403")]
        _403,
        [EnumMember(Value = "404")]
        _404,
        [EnumMember(Value = "405")]
        _405,
        [EnumMember(Value = "406")]
        _406,
        [EnumMember(Value = "407")]
        _407,
        [EnumMember(Value = "408")]
        _408,
        [EnumMember(Value = "409")]
        _409,
        [EnumMember(Value = "410")]
        _410,
        [EnumMember(Value = "411")]
        _411,
        [EnumMember(Value = "412")]
        _412,
        [EnumMember(Value = "413")]
        _413,
        [EnumMember(Value = "414")]
        _414,
        [EnumMember(Value = "415")]
        _415,
        [EnumMember(Value = "416")]
        _416,
        [EnumMember(Value = "417")]
        _417,
        [EnumMember(Value = "418")]
        _418,
        [EnumMember(Value = "419")]
        _419,
        [EnumMember(Value = "420")]
        _420,
        [EnumMember(Value = "421")]
        _421,
        [EnumMember(Value = "422")]
        _422,
        [EnumMember(Value = "423")]
        _423,
        [EnumMember(Value = "424")]
        _424,
        [EnumMember(Value = "426")]
        _426,
        [EnumMember(Value = "428")]
        _428,
        [EnumMember(Value = "429")]
        _429,
        [EnumMember(Value = "431")]
        _431,
        [EnumMember(Value = "451")]
        _451,
        [EnumMember(Value = "500")]
        _500,
        [EnumMember(Value = "501")]
        _501,
        [EnumMember(Value = "502")]
        _502,
        [EnumMember(Value = "503")]
        _503,
        [EnumMember(Value = "504")]
        _504,
        [EnumMember(Value = "505")]
        _505,
        [EnumMember(Value = "506")]
        _506,
        [EnumMember(Value = "507")]
        _507,
        [EnumMember(Value = "508")]
        _508,
        [EnumMember(Value = "509")]
        _509,
        [EnumMember(Value = "510")]
        _510,
        [EnumMember(Value = "511")]
        _511
    }

    public class MeasureTinyRo
    {
        [JsonProperty("attribute")]
        public AttributeTinyRo Attribute { get; set; }

        [JsonProperty("dtype")]
        public string Dtype { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class MessageTinyRo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public AddMessageURIResponse Link { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }
    }

    public class CreateThingMessagesMessageRoInput
    {
        public CreateThingMessagesMessageRoInput(string body, string creationDate, string errorMessage, double latitude, double longitude, string metadata, int number, MessageRoInputProcessedType processed, AddMessageThingTinyRo thing, string timestamp, string topic)
        {
            this.Body = body;
            this.CreationDate = creationDate;
            this.ErrorMessage = errorMessage;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Metadata = metadata;
            this.Number = number;
            this.Processed = processed;
            this.Thing = thing;
            this.Timestamp = timestamp;
            this.Topic = topic;
        }

        [JsonProperty("body", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Body { get; set; }

        [JsonProperty("creationDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CreationDate { get; set; }

        [JsonProperty("errorMessage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ErrorMessage { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("latitude", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Latitude { get; set; }

        [JsonProperty("link")]
        public AddMessageURI Link { get; set; }

        [JsonProperty("longitude", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Longitude { get; set; }

        [JsonProperty("measurements")]
        public AddMessageJsonNode Measurements { get; set; }

        [JsonProperty("metadata", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Metadata { get; set; }

        [JsonProperty("number", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Number { get; set; }

        [JsonProperty("processed", DefaultValueHandling = DefaultValueHandling.Include)]
        public MessageRoInputProcessedType Processed { get; set; }

        [JsonProperty("rawMeasurements")]
        public AddMessageJsonNode RawMeasurements { get; set; }

        [JsonProperty("thing", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddMessageThingTinyRo Thing { get; set; }

        [JsonProperty("timestamp", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Timestamp { get; set; }

        [JsonProperty("topic", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Topic { get; set; }
    }

    public class PageOperationRo
    {
        [JsonProperty("data")]
        public OperationRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public class PlaceholdersValuesInput
    {
        [JsonProperty("array")]
        public bool? Array { get; set; }

        [JsonProperty("bigDecimal")]
        public bool? BigDecimal { get; set; }

        [JsonProperty("bigInteger")]
        public bool? BigInteger { get; set; }

        [JsonProperty("binary")]
        public bool? Binary { get; set; }

        [JsonProperty("boolean")]
        public bool? Boolean { get; set; }

        [JsonProperty("containerNode")]
        public bool? ContainerNode { get; set; }

        [JsonProperty("double")]
        public bool? Double { get; set; }

        [JsonProperty("float")]
        public bool? Float { get; set; }

        [JsonProperty("floatingPointNumber")]
        public bool? FloatingPointNumber { get; set; }

        [JsonProperty("int")]
        public bool? Int { get; set; }

        [JsonProperty("integralNumber")]
        public bool? IntegralNumber { get; set; }

        [JsonProperty("long")]
        public bool? Long { get; set; }

        [JsonProperty("missingNode")]
        public bool? MissingNode { get; set; }

        [JsonProperty("nodeType")]
        public PlaceholdersValuesInputNodeTypeType? NodeType { get; set; }

        [JsonProperty("null")]
        public bool? Null { get; set; }

        [JsonProperty("number")]
        public bool? Number { get; set; }

        [JsonProperty("object")]
        public bool? ObjectEntity { get; set; }

        [JsonProperty("pojo")]
        public bool? Pojo { get; set; }

        [JsonProperty("short")]
        public bool? Short { get; set; }

        [JsonProperty("textual")]
        public bool? Textual { get; set; }

        [JsonProperty("valueNode")]
        public bool? ValueNode { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PlaceholdersValuesInputNodeTypeType
    {
        ARRAY,
        BINARY,
        BOOLEAN,
        MISSING,
        NULL,
        NUMBER,
        [EnumMember(Value = "OBJECT")]
        ObjectEntity,
        POJO,
        STRING
    }

    public class UpdateThingFixedPositionThingRoInput
    {
        public UpdateThingFixedPositionThingRoInput(string name)
        {
            this.Name = name;
        }

        [JsonProperty("customFields")]
        public PutThingCustomFieldRo[] CustomFields { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("dynamicGps")]
        public bool? DynamicGps { get; set; }

        [JsonProperty("fixedLatitude")]
        public double? FixedLatitude { get; set; }

        [JsonProperty("fixedLongitude")]
        public double? FixedLongitude { get; set; }

        [JsonProperty("fixedName")]
        public string FixedName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastActivityDate")]
        public int? LastActivityDate { get; set; }

        [JsonProperty("lastLatitude")]
        public double? LastLatitude { get; set; }

        [JsonProperty("lastLongitude")]
        public double? LastLongitude { get; set; }

        [JsonProperty("lastMeasurements")]
        public AddMessageJsonNode LastMeasurements { get; set; }

        [JsonProperty("lastMeasurementsTimestamps")]
        public AddMessageJsonNode LastMeasurementsTimestamps { get; set; }

        [JsonProperty("lastMessageDate")]
        public int? LastMessageDate { get; set; }

        [JsonProperty("messageActivityTimeoutPeriod")]
        public int? MessageActivityTimeoutPeriod { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("nbAlerts")]
        public int? NbAlerts { get; set; }

        [JsonProperty("site")]
        public PutThingSiteRo Site { get; set; }

        [JsonProperty("status")]
        public ThingRoInputStatusType? Status { get; set; }

        [JsonProperty("tags")]
        public AddMessageThingTagRo[] Tags { get; set; }
    }

    public class ProductRo
    {
        [JsonProperty("certification")]
        public string Certification { get; set; }

        [JsonProperty("connectivityTypes")]
        public ProductRoConnectivityTypesTypeItem[] ConnectivityTypes { get; set; }

        [JsonProperty("decoder")]
        public GetThingProductDecoderTinyRoResponse Decoder { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("encoder")]
        public GetThingProductEncoderTinyRoResponse Encoder { get; set; }

        [JsonProperty("generateLinks")]
        public bool GenerateLinks { get; set; }

        [JsonProperty("hasImage")]
        public bool HasImage { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("infoLink")]
        public string InfoLink { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("manufacturer")]
        public AssociateThingProductManufacturerTinyRoResponse Manufacturer { get; set; }

        [JsonProperty("manufacturerCategory")]
        public string ManufacturerCategory { get; set; }

        [JsonProperty("model")]
        public AssociateThingProductModelTinyRoResponse Model { get; set; }

        [JsonProperty("modelManufacturer")]
        public AssociateThingProductManufacturerTinyRoResponse ModelManufacturer { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("readOnly")]
        public bool ReadOnly { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("tags")]
        public AddThingTagTagRoResponse[] Tags { get; set; }

        [JsonProperty("things")]
        public AddMessageThingTinyRoResponse[] Things { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ProductRoConnectivityTypesTypeItem
    {
        LORA,
        SIGFOX,
        MQTT,
        CELLULAR,
        ETHERNET,
        WIFI,
        BLUETOOTH,
        BACNET,
        MODBUS,
        [EnumMember(Value = "IO_ANALOG")]
        IOANALOG,
        [EnumMember(Value = "IO_DIGITAL")]
        IODIGITAL,
        ENOCEAN,
        ZIGBEE,
        ZWAVE,
        NFC,
        USB,
        [EnumMember(Value = "IEEE_LR_WPAN")]
        IEEELRWPAN,
        DALI,
        UNKNOWN
    }

    public class GetThingProductDecoderTinyRoResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }
    }

    public class GetThingProductEncoderTinyRoResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class ProductInput
    {
        [JsonProperty("certification")]
        public string Certification { get; set; }

        [JsonProperty("connectivityTypes")]
        public ProductInputConnectivityTypesTypeItem[] ConnectivityTypes { get; set; }

        [JsonProperty("decoder")]
        public AssociateThingProductDecoderTinyRo Decoder { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("encoder")]
        public AssociateThingProductEncoderTinyRo Encoder { get; set; }

        [JsonProperty("generateLinks")]
        public bool? GenerateLinks { get; set; }

        [JsonProperty("hasImage")]
        public bool? HasImage { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("infoLink")]
        public string InfoLink { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("manufacturer")]
        public AssociateThingProductManufacturerTinyRo Manufacturer { get; set; }

        [JsonProperty("manufacturerCategory")]
        public string ManufacturerCategory { get; set; }

        [JsonProperty("model")]
        public AssociateThingProductModelTinyRo Model { get; set; }

        [JsonProperty("modelManufacturer")]
        public AssociateThingProductManufacturerTinyRo ModelManufacturer { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("readOnly")]
        public bool? ReadOnly { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("tags")]
        public AssociateThingProductTagRo[] Tags { get; set; }

        [JsonProperty("things")]
        public AddMessageThingTinyRo[] Things { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ProductInputConnectivityTypesTypeItem
    {
        LORA,
        SIGFOX,
        MQTT,
        CELLULAR,
        ETHERNET,
        WIFI,
        BLUETOOTH,
        BACNET,
        MODBUS,
        [EnumMember(Value = "IO_ANALOG")]
        IOANALOG,
        [EnumMember(Value = "IO_DIGITAL")]
        IODIGITAL,
        ENOCEAN,
        ZIGBEE,
        ZWAVE,
        NFC,
        USB,
        [EnumMember(Value = "IEEE_LR_WPAN")]
        IEEELRWPAN,
        DALI,
        UNKNOWN
    }

    public class AssociateThingProductDecoderTinyRo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("visible")]
        public bool? Visible { get; set; }
    }

    public class AssociateThingProductEncoderTinyRo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class AssociateThingProductTagRo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }
    }

    public class PageFlowRo
    {
        [JsonProperty("data")]
        public PageFlowRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public class PageStatsMeasureRo
    {
        [JsonProperty("data")]
        public StatsMeasureRo[] Data { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("totalSize")]
        public int TotalSize { get; set; }
    }

    public class StatsMeasureRo
    {
        [JsonProperty("attribute")]
        public AttributeRo Attribute { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class StatsCountRo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class StatsGraphRo
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("last")]
        public int Last { get; set; }

        [JsonProperty("max")]
        public double Max { get; set; }

        [JsonProperty("min")]
        public double Min { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pilotthings;

    public partial class WorkflowManagedActions
    {
        public PilotthingsActions Pilotthings(string connectionId) => new PilotthingsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PilotthingsTriggers Pilotthings(string connectionId) => new PilotthingsTriggers(connectionId);
    }
}