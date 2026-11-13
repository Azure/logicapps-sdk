//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotcms
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HubspotcmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PagesList(Expression<Func<int>> limit = null, Expression<Func<bool>> archived = null, Expression<Func<string>> id = null, Expression<Func<string>> name = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/content/api/v2/pages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(20);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PagesCreate(Expression<Func<PagesCreateBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/content/api/v2/pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PagesArchive(Expression<Func<string>> pageId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/content/api/v2/pages/{0}", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PagesUpdate(Expression<Func<string>> pageId, Expression<Func<PagesCreateBodyInput>> body = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/content/api/v2/pages/{0}", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PagesPublish(Expression<Func<string>> pageId, Expression<Func<PagesPublishBodyInput>> body)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/content/api/v2/pages/{0}/publish-action", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction<ApiConnectionActionConfiguration> TemplatesList(Expression<Func<int>> limit = null, Expression<Func<string>> id = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/content/api/v2/templates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(20);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction<ApiConnectionActionConfiguration> TemplatesCreate(Expression<Func<TemplatesCreateBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/content/api/v2/templates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = new TemplatesCreateBodyInput().ToJToken();
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction<ApiConnectionActionConfiguration> TemplatesArchive(Expression<Func<string>> templateId)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/content/api/v2/templates/{0}", __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction<ApiConnectionActionConfiguration> TemplatesUpdate(Expression<Func<string>> templateId, Expression<Func<TemplatesUpdateBodyInput>> body)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/content/api/v2/templates/{0}", __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class HubspotcmsTriggers([ConnectionName] string connectionId)
    {
    }

    public class PagesCreateBodyInput
    {
        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        [JsonProperty("campaign_name")]
        public string CampaignName { get; set; }

        [JsonProperty("footer_html")]
        public string FooterHtml { get; set; }

        [JsonProperty("head_html")]
        public string HeadHtml { get; set; }

        [JsonProperty("is_draft")]
        public string IsDraft { get; set; }

        [JsonProperty("meta_description")]
        public string MetaDescription { get; set; }

        [JsonProperty("meta_keywords")]
        public string MetaKeywords { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("publish_date")]
        public string PublishDate { get; set; }

        [JsonProperty("publish_immediately")]
        public string PublishImmediately { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("widget_containers")]
        public string WidgetContainers { get; set; }

        [JsonProperty("widgets")]
        public string Widgets { get; set; }
    }

    public class PagesPublishBodyInput
    {
        public PagesPublishBodyInput(BodyInputActionType action)
        {
            this.Action = action;
        }

        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputActionType Action { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputActionType
    {
        [EnumMember(Value = "push-buffer-live")]
        PushBufferLive,
        [EnumMember(Value = "schedule-publish")]
        SchedulePublish,
        [EnumMember(Value = "cancel-publish")]
        CancelPublish
    }

    public class TemplatesCreateBodyInput
    {
        [JsonProperty("category_id")]
        public BodyInputCategoryIdType? CategoryId { get; set; }

        [JsonProperty("folder")]
        public string Folder { get; set; }

        [JsonProperty("is_available_for_new_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsAvailableForNewContent { get; set; } = false;

        [JsonProperty("template_type")]
        public BodyInputTemplateTypeType? TemplateType { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public enum BodyInputCategoryIdType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4
    }

    public enum BodyInputTemplateTypeType
    {
        _2 = 2,
        _4 = 4,
        _6 = 6,
        _11 = 11,
        _12 = 12,
        _13 = 13,
        _14 = 14,
        _19 = 19
    }

    public class TemplatesUpdateBodyInput
    {
        public TemplatesUpdateBodyInput(string source)
        {
            this.Source = source;
        }

        [JsonProperty("source", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Source { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotcms;

    public partial class WorkflowManagedActions
    {
        public HubspotcmsActions Hubspotcms(string connectionId) => new HubspotcmsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HubspotcmsTriggers Hubspotcms(string connectionId) => new HubspotcmsTriggers(connectionId);
    }
}