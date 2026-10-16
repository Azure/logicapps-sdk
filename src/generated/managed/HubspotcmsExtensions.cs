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
        public IWorkflowAction PagesList(Expression<Func<int>> limit = null, Expression<Func<bool>> archived = null, Expression<Func<string>> id = null, Expression<Func<string>> name = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction PagesCreate(Expression<Func<string>> bodycampaign = null, Expression<Func<string>> bodycampaignName = null, Expression<Func<string>> bodyfooterHtml = null, Expression<Func<string>> bodyheadHtml = null, Expression<Func<string>> bodyisDraft = null, Expression<Func<string>> bodymetaDescription = null, Expression<Func<string>> bodymetaKeywords = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodypublishDate = null, Expression<Func<string>> bodypublishImmediately = null, Expression<Func<string>> bodyslug = null, Expression<Func<string>> bodysubcategory = null, Expression<Func<string>> bodywidgetContainers = null, Expression<Func<string>> bodywidgets = null)
        {
            var __workflow_bodycampaign = WorkflowExpression.Compile(bodycampaign, nameof(bodycampaign), required: false);
            var __workflow_bodycampaignName = WorkflowExpression.Compile(bodycampaignName, nameof(bodycampaignName), required: false);
            var __workflow_bodyfooterHtml = WorkflowExpression.Compile(bodyfooterHtml, nameof(bodyfooterHtml), required: false);
            var __workflow_bodyheadHtml = WorkflowExpression.Compile(bodyheadHtml, nameof(bodyheadHtml), required: false);
            var __workflow_bodyisDraft = WorkflowExpression.Compile(bodyisDraft, nameof(bodyisDraft), required: false);
            var __workflow_bodymetaDescription = WorkflowExpression.Compile(bodymetaDescription, nameof(bodymetaDescription), required: false);
            var __workflow_bodymetaKeywords = WorkflowExpression.Compile(bodymetaKeywords, nameof(bodymetaKeywords), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodypublishDate = WorkflowExpression.Compile(bodypublishDate, nameof(bodypublishDate), required: false);
            var __workflow_bodypublishImmediately = WorkflowExpression.Compile(bodypublishImmediately, nameof(bodypublishImmediately), required: false);
            var __workflow_bodyslug = WorkflowExpression.Compile(bodyslug, nameof(bodyslug), required: false);
            var __workflow_bodysubcategory = WorkflowExpression.Compile(bodysubcategory, nameof(bodysubcategory), required: false);
            var __workflow_bodywidgetContainers = WorkflowExpression.Compile(bodywidgetContainers, nameof(bodywidgetContainers), required: false);
            var __workflow_bodywidgets = WorkflowExpression.Compile(bodywidgets, nameof(bodywidgets), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/content/api/v2/pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycampaign != null)
                {
                    body["campaign"] = ExpressionConverter.ConvertO(__workflow_bodycampaign);
                    bodypropCount++;
                }

                if (__workflow_bodycampaignName != null)
                {
                    body["campaign_name"] = ExpressionConverter.ConvertO(__workflow_bodycampaignName);
                    bodypropCount++;
                }

                if (__workflow_bodyfooterHtml != null)
                {
                    body["footer_html"] = ExpressionConverter.ConvertO(__workflow_bodyfooterHtml);
                    bodypropCount++;
                }

                if (__workflow_bodyheadHtml != null)
                {
                    body["head_html"] = ExpressionConverter.ConvertO(__workflow_bodyheadHtml);
                    bodypropCount++;
                }

                if (__workflow_bodyisDraft != null)
                {
                    body["is_draft"] = ExpressionConverter.ConvertO(__workflow_bodyisDraft);
                    bodypropCount++;
                }

                if (__workflow_bodymetaDescription != null)
                {
                    body["meta_description"] = ExpressionConverter.ConvertO(__workflow_bodymetaDescription);
                    bodypropCount++;
                }

                if (__workflow_bodymetaKeywords != null)
                {
                    body["meta_keywords"] = ExpressionConverter.ConvertO(__workflow_bodymetaKeywords);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodypublishDate != null)
                {
                    body["publish_date"] = ExpressionConverter.ConvertO(__workflow_bodypublishDate);
                    bodypropCount++;
                }

                if (__workflow_bodypublishImmediately != null)
                {
                    body["publish_immediately"] = ExpressionConverter.ConvertO(__workflow_bodypublishImmediately);
                    bodypropCount++;
                }

                if (__workflow_bodyslug != null)
                {
                    body["slug"] = ExpressionConverter.ConvertO(__workflow_bodyslug);
                    bodypropCount++;
                }

                if (__workflow_bodysubcategory != null)
                {
                    body["subcategory"] = ExpressionConverter.ConvertO(__workflow_bodysubcategory);
                    bodypropCount++;
                }

                if (__workflow_bodywidgetContainers != null)
                {
                    body["widget_containers"] = ExpressionConverter.ConvertO(__workflow_bodywidgetContainers);
                    bodypropCount++;
                }

                if (__workflow_bodywidgets != null)
                {
                    body["widgets"] = ExpressionConverter.ConvertO(__workflow_bodywidgets);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction PagesArchive(Expression<Func<string>> pageId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/content/api/v2/pages/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_pageId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction PagesUpdate(Expression<Func<string>> pageId, Expression<Func<string>> bodycampaign = null, Expression<Func<string>> bodycampaignName = null, Expression<Func<string>> bodyfooterHtml = null, Expression<Func<string>> bodyheadHtml = null, Expression<Func<string>> bodyisDraft = null, Expression<Func<string>> bodymetaDescription = null, Expression<Func<string>> bodymetaKeywords = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodypublishDate = null, Expression<Func<string>> bodypublishImmediately = null, Expression<Func<string>> bodyslug = null, Expression<Func<string>> bodysubcategory = null, Expression<Func<string>> bodywidgetContainers = null, Expression<Func<string>> bodywidgets = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_bodycampaign = WorkflowExpression.Compile(bodycampaign, nameof(bodycampaign), required: false);
            var __workflow_bodycampaignName = WorkflowExpression.Compile(bodycampaignName, nameof(bodycampaignName), required: false);
            var __workflow_bodyfooterHtml = WorkflowExpression.Compile(bodyfooterHtml, nameof(bodyfooterHtml), required: false);
            var __workflow_bodyheadHtml = WorkflowExpression.Compile(bodyheadHtml, nameof(bodyheadHtml), required: false);
            var __workflow_bodyisDraft = WorkflowExpression.Compile(bodyisDraft, nameof(bodyisDraft), required: false);
            var __workflow_bodymetaDescription = WorkflowExpression.Compile(bodymetaDescription, nameof(bodymetaDescription), required: false);
            var __workflow_bodymetaKeywords = WorkflowExpression.Compile(bodymetaKeywords, nameof(bodymetaKeywords), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodypublishDate = WorkflowExpression.Compile(bodypublishDate, nameof(bodypublishDate), required: false);
            var __workflow_bodypublishImmediately = WorkflowExpression.Compile(bodypublishImmediately, nameof(bodypublishImmediately), required: false);
            var __workflow_bodyslug = WorkflowExpression.Compile(bodyslug, nameof(bodyslug), required: false);
            var __workflow_bodysubcategory = WorkflowExpression.Compile(bodysubcategory, nameof(bodysubcategory), required: false);
            var __workflow_bodywidgetContainers = WorkflowExpression.Compile(bodywidgetContainers, nameof(bodywidgetContainers), required: false);
            var __workflow_bodywidgets = WorkflowExpression.Compile(bodywidgets, nameof(bodywidgets), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/content/api/v2/pages/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_pageId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycampaign != null)
                {
                    body["campaign"] = ExpressionConverter.ConvertO(__workflow_bodycampaign);
                    bodypropCount++;
                }

                if (__workflow_bodycampaignName != null)
                {
                    body["campaign_name"] = ExpressionConverter.ConvertO(__workflow_bodycampaignName);
                    bodypropCount++;
                }

                if (__workflow_bodyfooterHtml != null)
                {
                    body["footer_html"] = ExpressionConverter.ConvertO(__workflow_bodyfooterHtml);
                    bodypropCount++;
                }

                if (__workflow_bodyheadHtml != null)
                {
                    body["head_html"] = ExpressionConverter.ConvertO(__workflow_bodyheadHtml);
                    bodypropCount++;
                }

                if (__workflow_bodyisDraft != null)
                {
                    body["is_draft"] = ExpressionConverter.ConvertO(__workflow_bodyisDraft);
                    bodypropCount++;
                }

                if (__workflow_bodymetaDescription != null)
                {
                    body["meta_description"] = ExpressionConverter.ConvertO(__workflow_bodymetaDescription);
                    bodypropCount++;
                }

                if (__workflow_bodymetaKeywords != null)
                {
                    body["meta_keywords"] = ExpressionConverter.ConvertO(__workflow_bodymetaKeywords);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodypublishDate != null)
                {
                    body["publish_date"] = ExpressionConverter.ConvertO(__workflow_bodypublishDate);
                    bodypropCount++;
                }

                if (__workflow_bodypublishImmediately != null)
                {
                    body["publish_immediately"] = ExpressionConverter.ConvertO(__workflow_bodypublishImmediately);
                    bodypropCount++;
                }

                if (__workflow_bodyslug != null)
                {
                    body["slug"] = ExpressionConverter.ConvertO(__workflow_bodyslug);
                    bodypropCount++;
                }

                if (__workflow_bodysubcategory != null)
                {
                    body["subcategory"] = ExpressionConverter.ConvertO(__workflow_bodysubcategory);
                    bodypropCount++;
                }

                if (__workflow_bodywidgetContainers != null)
                {
                    body["widget_containers"] = ExpressionConverter.ConvertO(__workflow_bodywidgetContainers);
                    bodypropCount++;
                }

                if (__workflow_bodywidgets != null)
                {
                    body["widgets"] = ExpressionConverter.ConvertO(__workflow_bodywidgets);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction PagesPublish(Expression<Func<string>> pageId, Expression<Func<bodyactionInput>> bodyaction)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_bodyaction = WorkflowExpression.Compile(bodyaction, nameof(bodyaction), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/content/api/v2/pages/{0}/publish-action", ExpressionConverter.ConvertWithUrlEncoding(__workflow_pageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["action"] = ExpressionConverter.ConvertO(__workflow_bodyaction);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction TemplatesList(Expression<Func<int>> limit = null, Expression<Func<string>> id = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction TemplatesCreate(Expression<Func<bodycategoryIdInput>> bodycategoryId = null, Expression<Func<string>> bodyfolder = null, Expression<Func<bool>> bodyisAvailableForNewContent = null, Expression<Func<bodytemplateTypeInput>> bodytemplateType = null, Expression<Func<string>> bodypath = null, Expression<Func<string>> bodysource = null)
        {
            var __workflow_bodycategoryId = WorkflowExpression.Compile(bodycategoryId, nameof(bodycategoryId), required: false);
            var __workflow_bodyfolder = WorkflowExpression.Compile(bodyfolder, nameof(bodyfolder), required: false);
            var __workflow_bodyisAvailableForNewContent = WorkflowExpression.Compile(bodyisAvailableForNewContent, nameof(bodyisAvailableForNewContent), required: false);
            var __workflow_bodytemplateType = WorkflowExpression.Compile(bodytemplateType, nameof(bodytemplateType), required: false);
            var __workflow_bodypath = WorkflowExpression.Compile(bodypath, nameof(bodypath), required: false);
            var __workflow_bodysource = WorkflowExpression.Compile(bodysource, nameof(bodysource), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/content/api/v2/templates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycategoryId != null)
                {
                    body["category_id"] = ExpressionConverter.ConvertO(__workflow_bodycategoryId);
                    bodypropCount++;
                }

                if (__workflow_bodyfolder != null)
                {
                    body["folder"] = ExpressionConverter.ConvertO(__workflow_bodyfolder);
                    bodypropCount++;
                }

                if (__workflow_bodyisAvailableForNewContent != null)
                {
                    if (__workflow_bodyisAvailableForNewContent != null)
                    {
                        body["is_available_for_new_content"] = ExpressionConverter.ConvertO(__workflow_bodyisAvailableForNewContent);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["is_available_for_new_content"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodytemplateType != null)
                {
                    body["template_type"] = ExpressionConverter.ConvertO(__workflow_bodytemplateType);
                    bodypropCount++;
                }

                if (__workflow_bodypath != null)
                {
                    body["path"] = ExpressionConverter.ConvertO(__workflow_bodypath);
                    bodypropCount++;
                }

                if (__workflow_bodysource != null)
                {
                    body["source"] = ExpressionConverter.ConvertO(__workflow_bodysource);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction TemplatesArchive(Expression<Func<string>> templateId)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/content/api/v2/templates/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_templateId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction TemplatesUpdate(Expression<Func<string>> templateId, Expression<Func<string>> bodysource)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_bodysource = WorkflowExpression.Compile(bodysource, nameof(bodysource), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/content/api/v2/templates/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_templateId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["source"] = ExpressionConverter.ConvertO(__workflow_bodysource);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class HubspotcmsTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyactionInput
    {
        [EnumMember(Value = "push-buffer-live")]
        PushBufferLive,
        [EnumMember(Value = "schedule-publish")]
        SchedulePublish,
        [EnumMember(Value = "cancel-publish")]
        CancelPublish
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycategoryIdInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytemplateTypeInput
    {
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "6")]
        _6,
        [EnumMember(Value = "11")]
        _11,
        [EnumMember(Value = "12")]
        _12,
        [EnumMember(Value = "13")]
        _13,
        [EnumMember(Value = "14")]
        _14,
        [EnumMember(Value = "19")]
        _19
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
