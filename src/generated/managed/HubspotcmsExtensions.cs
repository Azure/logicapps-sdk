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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPagesList(WorkflowValue<int> limit = null, WorkflowValue<bool> archived = null, WorkflowValue<string> id = null, WorkflowValue<string> name = null)
        {
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(archived, nameof(archived), required: false);
            WorkflowValue.Validate(id, nameof(id), required: false);
            WorkflowValue.Validate(name, nameof(name), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPagesCreate(WorkflowValue<string> bodycampaign = null, WorkflowValue<string> bodycampaignName = null, WorkflowValue<string> bodyfooterHtml = null, WorkflowValue<string> bodyheadHtml = null, WorkflowValue<string> bodyisDraft = null, WorkflowValue<string> bodymetaDescription = null, WorkflowValue<string> bodymetaKeywords = null, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodypassword = null, WorkflowValue<string> bodypublishDate = null, WorkflowValue<string> bodypublishImmediately = null, WorkflowValue<string> bodyslug = null, WorkflowValue<string> bodysubcategory = null, WorkflowValue<string> bodywidgetContainers = null, WorkflowValue<string> bodywidgets = null)
        {
            WorkflowValue.Validate(bodycampaign, nameof(bodycampaign), required: false);
            WorkflowValue.Validate(bodycampaignName, nameof(bodycampaignName), required: false);
            WorkflowValue.Validate(bodyfooterHtml, nameof(bodyfooterHtml), required: false);
            WorkflowValue.Validate(bodyheadHtml, nameof(bodyheadHtml), required: false);
            WorkflowValue.Validate(bodyisDraft, nameof(bodyisDraft), required: false);
            WorkflowValue.Validate(bodymetaDescription, nameof(bodymetaDescription), required: false);
            WorkflowValue.Validate(bodymetaKeywords, nameof(bodymetaKeywords), required: false);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodypassword, nameof(bodypassword), required: false);
            WorkflowValue.Validate(bodypublishDate, nameof(bodypublishDate), required: false);
            WorkflowValue.Validate(bodypublishImmediately, nameof(bodypublishImmediately), required: false);
            WorkflowValue.Validate(bodyslug, nameof(bodyslug), required: false);
            WorkflowValue.Validate(bodysubcategory, nameof(bodysubcategory), required: false);
            WorkflowValue.Validate(bodywidgetContainers, nameof(bodywidgetContainers), required: false);
            WorkflowValue.Validate(bodywidgets, nameof(bodywidgets), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPagesArchive(WorkflowValue<string> pageId)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPagesUpdate(WorkflowValue<string> pageId, WorkflowValue<string> bodycampaign = null, WorkflowValue<string> bodycampaignName = null, WorkflowValue<string> bodyfooterHtml = null, WorkflowValue<string> bodyheadHtml = null, WorkflowValue<string> bodyisDraft = null, WorkflowValue<string> bodymetaDescription = null, WorkflowValue<string> bodymetaKeywords = null, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodypassword = null, WorkflowValue<string> bodypublishDate = null, WorkflowValue<string> bodypublishImmediately = null, WorkflowValue<string> bodyslug = null, WorkflowValue<string> bodysubcategory = null, WorkflowValue<string> bodywidgetContainers = null, WorkflowValue<string> bodywidgets = null)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(bodycampaign, nameof(bodycampaign), required: false);
            WorkflowValue.Validate(bodycampaignName, nameof(bodycampaignName), required: false);
            WorkflowValue.Validate(bodyfooterHtml, nameof(bodyfooterHtml), required: false);
            WorkflowValue.Validate(bodyheadHtml, nameof(bodyheadHtml), required: false);
            WorkflowValue.Validate(bodyisDraft, nameof(bodyisDraft), required: false);
            WorkflowValue.Validate(bodymetaDescription, nameof(bodymetaDescription), required: false);
            WorkflowValue.Validate(bodymetaKeywords, nameof(bodymetaKeywords), required: false);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodypassword, nameof(bodypassword), required: false);
            WorkflowValue.Validate(bodypublishDate, nameof(bodypublishDate), required: false);
            WorkflowValue.Validate(bodypublishImmediately, nameof(bodypublishImmediately), required: false);
            WorkflowValue.Validate(bodyslug, nameof(bodyslug), required: false);
            WorkflowValue.Validate(bodysubcategory, nameof(bodysubcategory), required: false);
            WorkflowValue.Validate(bodywidgetContainers, nameof(bodywidgetContainers), required: false);
            WorkflowValue.Validate(bodywidgets, nameof(bodywidgets), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPagesPublish(WorkflowValue<string> pageId, WorkflowValue<bodyactionInput> bodyaction)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(bodyaction, nameof(bodyaction), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTemplatesList(WorkflowValue<int> limit = null, WorkflowValue<string> id = null)
        {
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(id, nameof(id), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTemplatesCreate(WorkflowValue<bodycategoryIdInput> bodycategoryId = null, WorkflowValue<string> bodyfolder = null, WorkflowValue<bool> bodyisAvailableForNewContent = null, WorkflowValue<bodytemplateTypeInput> bodytemplateType = null, WorkflowValue<string> bodypath = null, WorkflowValue<string> bodysource = null)
        {
            WorkflowValue.Validate(bodycategoryId, nameof(bodycategoryId), required: false);
            WorkflowValue.Validate(bodyfolder, nameof(bodyfolder), required: false);
            WorkflowValue.Validate(bodyisAvailableForNewContent, nameof(bodyisAvailableForNewContent), required: false);
            WorkflowValue.Validate(bodytemplateType, nameof(bodytemplateType), required: false);
            WorkflowValue.Validate(bodypath, nameof(bodypath), required: false);
            WorkflowValue.Validate(bodysource, nameof(bodysource), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTemplatesArchive(WorkflowValue<string> templateId)
        {
            WorkflowValue.Validate(templateId, nameof(templateId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTemplatesUpdate(WorkflowValue<string> templateId, WorkflowValue<string> bodysource)
        {
            WorkflowValue.Validate(templateId, nameof(templateId), required: true);
            WorkflowValue.Validate(bodysource, nameof(bodysource), required: true);
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
