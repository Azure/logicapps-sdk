//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotcms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HubspotcmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction PagesList(Expression<Func<int>> limit = null, Expression<Func<bool>> archived = null, Expression<Func<string>> id = null, Expression<Func<string>> name = null)
        {
            var apiCallPath = "/content/api/v2/pages";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = Convert.ToString(20);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            callPayload.Queries["archived"] = Convert.ToString(false);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            if (id != null)
                callPayload.Queries["id"] = CSharpExpressionConverter.ConvertO(id);
            if (name != null)
                callPayload.Queries["name"] = CSharpExpressionConverter.ConvertO(name);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction PagesCreate(Expression<Func<string>> bodycampaign = null, Expression<Func<string>> bodycampaignName = null, Expression<Func<string>> bodyfooterHtml = null, Expression<Func<string>> bodyheadHtml = null, Expression<Func<string>> bodyisDraft = null, Expression<Func<string>> bodymetaDescription = null, Expression<Func<string>> bodymetaKeywords = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodypublishDate = null, Expression<Func<string>> bodypublishImmediately = null, Expression<Func<string>> bodyslug = null, Expression<Func<string>> bodysubcategory = null, Expression<Func<string>> bodywidgetContainers = null, Expression<Func<string>> bodywidgets = null)
        {
            var apiCallPath = "/content/api/v2/pages";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycampaign != null)
            {
                body["campaign"] = CSharpExpressionConverter.ConvertToken(bodycampaign);
                bodypropCount++;
            }

            if (bodycampaignName != null)
            {
                body["campaign_name"] = CSharpExpressionConverter.ConvertToken(bodycampaignName);
                bodypropCount++;
            }

            if (bodyfooterHtml != null)
            {
                body["footer_html"] = CSharpExpressionConverter.ConvertToken(bodyfooterHtml);
                bodypropCount++;
            }

            if (bodyheadHtml != null)
            {
                body["head_html"] = CSharpExpressionConverter.ConvertToken(bodyheadHtml);
                bodypropCount++;
            }

            if (bodyisDraft != null)
            {
                body["is_draft"] = CSharpExpressionConverter.ConvertToken(bodyisDraft);
                bodypropCount++;
            }

            if (bodymetaDescription != null)
            {
                body["meta_description"] = CSharpExpressionConverter.ConvertToken(bodymetaDescription);
                bodypropCount++;
            }

            if (bodymetaKeywords != null)
            {
                body["meta_keywords"] = CSharpExpressionConverter.ConvertToken(bodymetaKeywords);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = CSharpExpressionConverter.ConvertToken(bodypassword);
                bodypropCount++;
            }

            if (bodypublishDate != null)
            {
                body["publish_date"] = CSharpExpressionConverter.ConvertToken(bodypublishDate);
                bodypropCount++;
            }

            if (bodypublishImmediately != null)
            {
                body["publish_immediately"] = CSharpExpressionConverter.ConvertToken(bodypublishImmediately);
                bodypropCount++;
            }

            if (bodyslug != null)
            {
                body["slug"] = CSharpExpressionConverter.ConvertToken(bodyslug);
                bodypropCount++;
            }

            if (bodysubcategory != null)
            {
                body["subcategory"] = CSharpExpressionConverter.ConvertToken(bodysubcategory);
                bodypropCount++;
            }

            if (bodywidgetContainers != null)
            {
                body["widget_containers"] = CSharpExpressionConverter.ConvertToken(bodywidgetContainers);
                bodypropCount++;
            }

            if (bodywidgets != null)
            {
                body["widgets"] = CSharpExpressionConverter.ConvertToken(bodywidgets);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction PagesArchive(Expression<Func<string>> pageId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/content/api/v2/pages/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction PagesUpdate(Expression<Func<string>> pageId, Expression<Func<string>> bodycampaign = null, Expression<Func<string>> bodycampaignName = null, Expression<Func<string>> bodyfooterHtml = null, Expression<Func<string>> bodyheadHtml = null, Expression<Func<string>> bodyisDraft = null, Expression<Func<string>> bodymetaDescription = null, Expression<Func<string>> bodymetaKeywords = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodypublishDate = null, Expression<Func<string>> bodypublishImmediately = null, Expression<Func<string>> bodyslug = null, Expression<Func<string>> bodysubcategory = null, Expression<Func<string>> bodywidgetContainers = null, Expression<Func<string>> bodywidgets = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/content/api/v2/pages/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycampaign != null)
            {
                body["campaign"] = CSharpExpressionConverter.ConvertToken(bodycampaign);
                bodypropCount++;
            }

            if (bodycampaignName != null)
            {
                body["campaign_name"] = CSharpExpressionConverter.ConvertToken(bodycampaignName);
                bodypropCount++;
            }

            if (bodyfooterHtml != null)
            {
                body["footer_html"] = CSharpExpressionConverter.ConvertToken(bodyfooterHtml);
                bodypropCount++;
            }

            if (bodyheadHtml != null)
            {
                body["head_html"] = CSharpExpressionConverter.ConvertToken(bodyheadHtml);
                bodypropCount++;
            }

            if (bodyisDraft != null)
            {
                body["is_draft"] = CSharpExpressionConverter.ConvertToken(bodyisDraft);
                bodypropCount++;
            }

            if (bodymetaDescription != null)
            {
                body["meta_description"] = CSharpExpressionConverter.ConvertToken(bodymetaDescription);
                bodypropCount++;
            }

            if (bodymetaKeywords != null)
            {
                body["meta_keywords"] = CSharpExpressionConverter.ConvertToken(bodymetaKeywords);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = CSharpExpressionConverter.ConvertToken(bodypassword);
                bodypropCount++;
            }

            if (bodypublishDate != null)
            {
                body["publish_date"] = CSharpExpressionConverter.ConvertToken(bodypublishDate);
                bodypropCount++;
            }

            if (bodypublishImmediately != null)
            {
                body["publish_immediately"] = CSharpExpressionConverter.ConvertToken(bodypublishImmediately);
                bodypropCount++;
            }

            if (bodyslug != null)
            {
                body["slug"] = CSharpExpressionConverter.ConvertToken(bodyslug);
                bodypropCount++;
            }

            if (bodysubcategory != null)
            {
                body["subcategory"] = CSharpExpressionConverter.ConvertToken(bodysubcategory);
                bodypropCount++;
            }

            if (bodywidgetContainers != null)
            {
                body["widget_containers"] = CSharpExpressionConverter.ConvertToken(bodywidgetContainers);
                bodypropCount++;
            }

            if (bodywidgets != null)
            {
                body["widgets"] = CSharpExpressionConverter.ConvertToken(bodywidgets);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction PagesPublish(Expression<Func<string>> pageId, Expression<Func<bodyactionInput>> bodyaction)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/content/api/v2/pages/{0}/publish-action", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["action"] = CSharpExpressionConverter.Convert(bodyaction);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction TemplatesList(Expression<Func<int>> limit = null, Expression<Func<string>> id = null)
        {
            var apiCallPath = "/content/api/v2/templates";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = Convert.ToString(20);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (id != null)
                callPayload.Queries["id"] = CSharpExpressionConverter.ConvertO(id);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction TemplatesCreate(Expression<Func<bodycategoryIdInput>> bodycategoryId = null, Expression<Func<string>> bodyfolder = null, Expression<Func<bool>> bodyisAvailableForNewContent = null, Expression<Func<bodytemplateTypeInput>> bodytemplateType = null, Expression<Func<string>> bodypath = null, Expression<Func<string>> bodysource = null)
        {
            var apiCallPath = "/content/api/v2/templates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycategoryId != null)
            {
                body["category_id"] = CSharpExpressionConverter.Convert(bodycategoryId);
                bodypropCount++;
            }

            if (bodyfolder != null)
            {
                body["folder"] = CSharpExpressionConverter.ConvertToken(bodyfolder);
                bodypropCount++;
            }

            if (bodyisAvailableForNewContent != null)
            {
                if (bodyisAvailableForNewContent != null)
                {
                    body["is_available_for_new_content"] = CSharpExpressionConverter.ConvertToken(bodyisAvailableForNewContent);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["is_available_for_new_content"] = false;
                bodypropCount++;
            }

            if (bodytemplateType != null)
            {
                body["template_type"] = CSharpExpressionConverter.Convert(bodytemplateType);
                bodypropCount++;
            }

            if (bodypath != null)
            {
                body["path"] = CSharpExpressionConverter.ConvertToken(bodypath);
                bodypropCount++;
            }

            if (bodysource != null)
            {
                body["source"] = CSharpExpressionConverter.ConvertToken(bodysource);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction TemplatesArchive(Expression<Func<string>> templateId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/content/api/v2/templates/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction TemplatesUpdate(Expression<Func<string>> templateId, Expression<Func<string>> bodysource)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/content/api/v2/templates/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["source"] = CSharpExpressionConverter.ConvertToken(bodysource);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class HubspotcmsTriggers([ConnectionName] string connectionId)
    {
    }

    public enum bodyactionInput
    {
        [EnumMember(Value = "push-buffer-live")]
        PushBufferLive,
        [EnumMember(Value = "schedule-publish")]
        SchedulePublish,
        [EnumMember(Value = "cancel-publish")]
        CancelPublish
    }

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