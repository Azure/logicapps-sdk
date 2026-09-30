//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotcms
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HubspotcmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction PagesList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> name = null)
        {
            var apiCallPath = "/content/api/v2/pages";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = Convert.ToString(20);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            callPayload.Queries["archived"] = Convert.ToString(false);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction PagesCreate([WorkflowExpression] Func<string> bodycampaign = null, [WorkflowExpression] Func<string> bodycampaignName = null, [WorkflowExpression] Func<string> bodyfooterHtml = null, [WorkflowExpression] Func<string> bodyheadHtml = null, [WorkflowExpression] Func<string> bodyisDraft = null, [WorkflowExpression] Func<string> bodymetaDescription = null, [WorkflowExpression] Func<string> bodymetaKeywords = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodypublishDate = null, [WorkflowExpression] Func<string> bodypublishImmediately = null, [WorkflowExpression] Func<string> bodyslug = null, [WorkflowExpression] Func<string> bodysubcategory = null, [WorkflowExpression] Func<string> bodywidgetContainers = null, [WorkflowExpression] Func<string> bodywidgets = null)
        {
            var apiCallPath = "/content/api/v2/pages";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycampaign != null)
            {
                body["campaign"] = ExpressionConverter.ConvertO(bodycampaign);
                bodypropCount++;
            }

            if (bodycampaignName != null)
            {
                body["campaign_name"] = ExpressionConverter.ConvertO(bodycampaignName);
                bodypropCount++;
            }

            if (bodyfooterHtml != null)
            {
                body["footer_html"] = ExpressionConverter.ConvertO(bodyfooterHtml);
                bodypropCount++;
            }

            if (bodyheadHtml != null)
            {
                body["head_html"] = ExpressionConverter.ConvertO(bodyheadHtml);
                bodypropCount++;
            }

            if (bodyisDraft != null)
            {
                body["is_draft"] = ExpressionConverter.ConvertO(bodyisDraft);
                bodypropCount++;
            }

            if (bodymetaDescription != null)
            {
                body["meta_description"] = ExpressionConverter.ConvertO(bodymetaDescription);
                bodypropCount++;
            }

            if (bodymetaKeywords != null)
            {
                body["meta_keywords"] = ExpressionConverter.ConvertO(bodymetaKeywords);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodypublishDate != null)
            {
                body["publish_date"] = ExpressionConverter.ConvertO(bodypublishDate);
                bodypropCount++;
            }

            if (bodypublishImmediately != null)
            {
                body["publish_immediately"] = ExpressionConverter.ConvertO(bodypublishImmediately);
                bodypropCount++;
            }

            if (bodyslug != null)
            {
                body["slug"] = ExpressionConverter.ConvertO(bodyslug);
                bodypropCount++;
            }

            if (bodysubcategory != null)
            {
                body["subcategory"] = ExpressionConverter.ConvertO(bodysubcategory);
                bodypropCount++;
            }

            if (bodywidgetContainers != null)
            {
                body["widget_containers"] = ExpressionConverter.ConvertO(bodywidgetContainers);
                bodypropCount++;
            }

            if (bodywidgets != null)
            {
                body["widgets"] = ExpressionConverter.ConvertO(bodywidgets);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction PagesArchive([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> pageId)
        {
            var apiCallPath = String.Format("/content/api/v2/pages/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction PagesUpdate([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> pageId, [WorkflowExpression] Func<string> bodycampaign = null, [WorkflowExpression] Func<string> bodycampaignName = null, [WorkflowExpression] Func<string> bodyfooterHtml = null, [WorkflowExpression] Func<string> bodyheadHtml = null, [WorkflowExpression] Func<string> bodyisDraft = null, [WorkflowExpression] Func<string> bodymetaDescription = null, [WorkflowExpression] Func<string> bodymetaKeywords = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodypublishDate = null, [WorkflowExpression] Func<string> bodypublishImmediately = null, [WorkflowExpression] Func<string> bodyslug = null, [WorkflowExpression] Func<string> bodysubcategory = null, [WorkflowExpression] Func<string> bodywidgetContainers = null, [WorkflowExpression] Func<string> bodywidgets = null)
        {
            var apiCallPath = String.Format("/content/api/v2/pages/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycampaign != null)
            {
                body["campaign"] = ExpressionConverter.ConvertO(bodycampaign);
                bodypropCount++;
            }

            if (bodycampaignName != null)
            {
                body["campaign_name"] = ExpressionConverter.ConvertO(bodycampaignName);
                bodypropCount++;
            }

            if (bodyfooterHtml != null)
            {
                body["footer_html"] = ExpressionConverter.ConvertO(bodyfooterHtml);
                bodypropCount++;
            }

            if (bodyheadHtml != null)
            {
                body["head_html"] = ExpressionConverter.ConvertO(bodyheadHtml);
                bodypropCount++;
            }

            if (bodyisDraft != null)
            {
                body["is_draft"] = ExpressionConverter.ConvertO(bodyisDraft);
                bodypropCount++;
            }

            if (bodymetaDescription != null)
            {
                body["meta_description"] = ExpressionConverter.ConvertO(bodymetaDescription);
                bodypropCount++;
            }

            if (bodymetaKeywords != null)
            {
                body["meta_keywords"] = ExpressionConverter.ConvertO(bodymetaKeywords);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodypublishDate != null)
            {
                body["publish_date"] = ExpressionConverter.ConvertO(bodypublishDate);
                bodypropCount++;
            }

            if (bodypublishImmediately != null)
            {
                body["publish_immediately"] = ExpressionConverter.ConvertO(bodypublishImmediately);
                bodypropCount++;
            }

            if (bodyslug != null)
            {
                body["slug"] = ExpressionConverter.ConvertO(bodyslug);
                bodypropCount++;
            }

            if (bodysubcategory != null)
            {
                body["subcategory"] = ExpressionConverter.ConvertO(bodysubcategory);
                bodypropCount++;
            }

            if (bodywidgetContainers != null)
            {
                body["widget_containers"] = ExpressionConverter.ConvertO(bodywidgetContainers);
                bodypropCount++;
            }

            if (bodywidgets != null)
            {
                body["widgets"] = ExpressionConverter.ConvertO(bodywidgets);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction PagesPublish([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> pageId, [WorkflowExpression] Func<bodyactionInput> bodyaction)
        {
            var apiCallPath = String.Format("/content/api/v2/pages/{0}/publish-action", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["action"] = ExpressionConverter.ConvertO(bodyaction);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction TemplatesList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> id = null)
        {
            var apiCallPath = "/content/api/v2/templates";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = Convert.ToString(20);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction TemplatesCreate([WorkflowExpression] Func<bodycategoryIdInput> bodycategoryId = null, [WorkflowExpression] Func<string> bodyfolder = null, [WorkflowExpression] Func<bool> bodyisAvailableForNewContent = null, [WorkflowExpression] Func<bodytemplateTypeInput> bodytemplateType = null, [WorkflowExpression] Func<string> bodypath = null, [WorkflowExpression] Func<string> bodysource = null)
        {
            var apiCallPath = "/content/api/v2/templates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycategoryId != null)
            {
                body["category_id"] = ExpressionConverter.ConvertO(bodycategoryId);
                bodypropCount++;
            }

            if (bodyfolder != null)
            {
                body["folder"] = ExpressionConverter.ConvertO(bodyfolder);
                bodypropCount++;
            }

            if (bodyisAvailableForNewContent != null)
            {
                if (bodyisAvailableForNewContent != null)
                {
                    body["is_available_for_new_content"] = ExpressionConverter.ConvertO(bodyisAvailableForNewContent);
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
                body["template_type"] = ExpressionConverter.ConvertO(bodytemplateType);
                bodypropCount++;
            }

            if (bodypath != null)
            {
                body["path"] = ExpressionConverter.ConvertO(bodypath);
                bodypropCount++;
            }

            if (bodysource != null)
            {
                body["source"] = ExpressionConverter.ConvertO(bodysource);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction TemplatesArchive([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> templateId)
        {
            var apiCallPath = String.Format("/content/api/v2/templates/{0}", ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction TemplatesUpdate([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> templateId, [WorkflowExpression] Func<string> bodysource)
        {
            var apiCallPath = String.Format("/content/api/v2/templates/{0}", ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["source"] = ExpressionConverter.ConvertO(bodysource);
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