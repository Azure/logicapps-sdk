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
        [WorkflowExpressionFactory(nameof(__BuildPagesList))]
        public IWorkflowAction PagesList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> name = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPagesList(WorkflowExpression<int> limit = null, WorkflowExpression<bool> archived = null, WorkflowExpression<string> id = null, WorkflowExpression<string> name = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(name, nameof(name), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        [WorkflowExpressionFactory(nameof(__BuildPagesCreate))]
        public IWorkflowAction PagesCreate([WorkflowExpression] Func<string> bodycampaign = null, [WorkflowExpression] Func<string> bodycampaignName = null, [WorkflowExpression] Func<string> bodyfooterHtml = null, [WorkflowExpression] Func<string> bodyheadHtml = null, [WorkflowExpression] Func<string> bodyisDraft = null, [WorkflowExpression] Func<string> bodymetaDescription = null, [WorkflowExpression] Func<string> bodymetaKeywords = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodypublishDate = null, [WorkflowExpression] Func<string> bodypublishImmediately = null, [WorkflowExpression] Func<string> bodyslug = null, [WorkflowExpression] Func<string> bodysubcategory = null, [WorkflowExpression] Func<string> bodywidgetContainers = null, [WorkflowExpression] Func<string> bodywidgets = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPagesCreate(WorkflowExpression<string> bodycampaign = null, WorkflowExpression<string> bodycampaignName = null, WorkflowExpression<string> bodyfooterHtml = null, WorkflowExpression<string> bodyheadHtml = null, WorkflowExpression<string> bodyisDraft = null, WorkflowExpression<string> bodymetaDescription = null, WorkflowExpression<string> bodymetaKeywords = null, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodypassword = null, WorkflowExpression<string> bodypublishDate = null, WorkflowExpression<string> bodypublishImmediately = null, WorkflowExpression<string> bodyslug = null, WorkflowExpression<string> bodysubcategory = null, WorkflowExpression<string> bodywidgetContainers = null, WorkflowExpression<string> bodywidgets = null)
        {
            WorkflowExpression.Validate(bodycampaign, nameof(bodycampaign), required: false);
            WorkflowExpression.Validate(bodycampaignName, nameof(bodycampaignName), required: false);
            WorkflowExpression.Validate(bodyfooterHtml, nameof(bodyfooterHtml), required: false);
            WorkflowExpression.Validate(bodyheadHtml, nameof(bodyheadHtml), required: false);
            WorkflowExpression.Validate(bodyisDraft, nameof(bodyisDraft), required: false);
            WorkflowExpression.Validate(bodymetaDescription, nameof(bodymetaDescription), required: false);
            WorkflowExpression.Validate(bodymetaKeywords, nameof(bodymetaKeywords), required: false);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            WorkflowExpression.Validate(bodypublishDate, nameof(bodypublishDate), required: false);
            WorkflowExpression.Validate(bodypublishImmediately, nameof(bodypublishImmediately), required: false);
            WorkflowExpression.Validate(bodyslug, nameof(bodyslug), required: false);
            WorkflowExpression.Validate(bodysubcategory, nameof(bodysubcategory), required: false);
            WorkflowExpression.Validate(bodywidgetContainers, nameof(bodywidgetContainers), required: false);
            WorkflowExpression.Validate(bodywidgets, nameof(bodywidgets), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        [WorkflowExpressionFactory(nameof(__BuildPagesArchive))]
        public IWorkflowAction PagesArchive([WorkflowExpression] Func<string> pageId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPagesArchive(WorkflowExpression<string> pageId)
        {
            WorkflowExpression.Validate(pageId, nameof(pageId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/content/api/v2/pages/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        [WorkflowExpressionFactory(nameof(__BuildPagesUpdate))]
        public IWorkflowAction PagesUpdate([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> bodycampaign = null, [WorkflowExpression] Func<string> bodycampaignName = null, [WorkflowExpression] Func<string> bodyfooterHtml = null, [WorkflowExpression] Func<string> bodyheadHtml = null, [WorkflowExpression] Func<string> bodyisDraft = null, [WorkflowExpression] Func<string> bodymetaDescription = null, [WorkflowExpression] Func<string> bodymetaKeywords = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodypublishDate = null, [WorkflowExpression] Func<string> bodypublishImmediately = null, [WorkflowExpression] Func<string> bodyslug = null, [WorkflowExpression] Func<string> bodysubcategory = null, [WorkflowExpression] Func<string> bodywidgetContainers = null, [WorkflowExpression] Func<string> bodywidgets = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPagesUpdate(WorkflowExpression<string> pageId, WorkflowExpression<string> bodycampaign = null, WorkflowExpression<string> bodycampaignName = null, WorkflowExpression<string> bodyfooterHtml = null, WorkflowExpression<string> bodyheadHtml = null, WorkflowExpression<string> bodyisDraft = null, WorkflowExpression<string> bodymetaDescription = null, WorkflowExpression<string> bodymetaKeywords = null, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodypassword = null, WorkflowExpression<string> bodypublishDate = null, WorkflowExpression<string> bodypublishImmediately = null, WorkflowExpression<string> bodyslug = null, WorkflowExpression<string> bodysubcategory = null, WorkflowExpression<string> bodywidgetContainers = null, WorkflowExpression<string> bodywidgets = null)
        {
            WorkflowExpression.Validate(pageId, nameof(pageId), required: true);
            WorkflowExpression.Validate(bodycampaign, nameof(bodycampaign), required: false);
            WorkflowExpression.Validate(bodycampaignName, nameof(bodycampaignName), required: false);
            WorkflowExpression.Validate(bodyfooterHtml, nameof(bodyfooterHtml), required: false);
            WorkflowExpression.Validate(bodyheadHtml, nameof(bodyheadHtml), required: false);
            WorkflowExpression.Validate(bodyisDraft, nameof(bodyisDraft), required: false);
            WorkflowExpression.Validate(bodymetaDescription, nameof(bodymetaDescription), required: false);
            WorkflowExpression.Validate(bodymetaKeywords, nameof(bodymetaKeywords), required: false);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            WorkflowExpression.Validate(bodypublishDate, nameof(bodypublishDate), required: false);
            WorkflowExpression.Validate(bodypublishImmediately, nameof(bodypublishImmediately), required: false);
            WorkflowExpression.Validate(bodyslug, nameof(bodyslug), required: false);
            WorkflowExpression.Validate(bodysubcategory, nameof(bodysubcategory), required: false);
            WorkflowExpression.Validate(bodywidgetContainers, nameof(bodywidgetContainers), required: false);
            WorkflowExpression.Validate(bodywidgets, nameof(bodywidgets), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/content/api/v2/pages/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        [WorkflowExpressionFactory(nameof(__BuildPagesPublish))]
        public IWorkflowAction PagesPublish([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<bodyactionInput> bodyaction)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPagesPublish(WorkflowExpression<string> pageId, WorkflowExpression<bodyactionInput> bodyaction)
        {
            WorkflowExpression.Validate(pageId, nameof(pageId), required: true);
            WorkflowExpression.Validate(bodyaction, nameof(bodyaction), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/content/api/v2/pages/{0}/publish-action", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        [WorkflowExpressionFactory(nameof(__BuildTemplatesList))]
        public IWorkflowAction TemplatesList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> id = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTemplatesList(WorkflowExpression<int> limit = null, WorkflowExpression<string> id = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(id, nameof(id), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        [WorkflowExpressionFactory(nameof(__BuildTemplatesCreate))]
        public IWorkflowAction TemplatesCreate([WorkflowExpression] Func<bodycategoryIdInput> bodycategoryId = null, [WorkflowExpression] Func<string> bodyfolder = null, [WorkflowExpression] Func<bool> bodyisAvailableForNewContent = null, [WorkflowExpression] Func<bodytemplateTypeInput> bodytemplateType = null, [WorkflowExpression] Func<string> bodypath = null, [WorkflowExpression] Func<string> bodysource = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTemplatesCreate(WorkflowExpression<bodycategoryIdInput> bodycategoryId = null, WorkflowExpression<string> bodyfolder = null, WorkflowExpression<bool> bodyisAvailableForNewContent = null, WorkflowExpression<bodytemplateTypeInput> bodytemplateType = null, WorkflowExpression<string> bodypath = null, WorkflowExpression<string> bodysource = null)
        {
            WorkflowExpression.Validate(bodycategoryId, nameof(bodycategoryId), required: false);
            WorkflowExpression.Validate(bodyfolder, nameof(bodyfolder), required: false);
            WorkflowExpression.Validate(bodyisAvailableForNewContent, nameof(bodyisAvailableForNewContent), required: false);
            WorkflowExpression.Validate(bodytemplateType, nameof(bodytemplateType), required: false);
            WorkflowExpression.Validate(bodypath, nameof(bodypath), required: false);
            WorkflowExpression.Validate(bodysource, nameof(bodysource), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        [WorkflowExpressionFactory(nameof(__BuildTemplatesArchive))]
        public IWorkflowAction TemplatesArchive([WorkflowExpression] Func<string> templateId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTemplatesArchive(WorkflowExpression<string> templateId)
        {
            WorkflowExpression.Validate(templateId, nameof(templateId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/content/api/v2/templates/{0}", ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        [WorkflowExpressionFactory(nameof(__BuildTemplatesUpdate))]
        public IWorkflowAction TemplatesUpdate([WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> bodysource)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTemplatesUpdate(WorkflowExpression<string> templateId, WorkflowExpression<string> bodysource)
        {
            WorkflowExpression.Validate(templateId, nameof(templateId), required: true);
            WorkflowExpression.Validate(bodysource, nameof(bodysource), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/content/api/v2/templates/{0}", ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
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