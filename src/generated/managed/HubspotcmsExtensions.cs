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
        public IWorkflowAction PagesList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> name = null)
        {
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(name, nameof(name), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/content/api/v2/pages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(20);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction PagesCreate([WorkflowExpression] Func<string> bodycampaign = null, [WorkflowExpression] Func<string> bodycampaignName = null, [WorkflowExpression] Func<string> bodyfooterHtml = null, [WorkflowExpression] Func<string> bodyheadHtml = null, [WorkflowExpression] Func<string> bodyisDraft = null, [WorkflowExpression] Func<string> bodymetaDescription = null, [WorkflowExpression] Func<string> bodymetaKeywords = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodypublishDate = null, [WorkflowExpression] Func<string> bodypublishImmediately = null, [WorkflowExpression] Func<string> bodyslug = null, [WorkflowExpression] Func<string> bodysubcategory = null, [WorkflowExpression] Func<string> bodywidgetContainers = null, [WorkflowExpression] Func<string> bodywidgets = null)
        {
            SourceExpression.Validate(bodycampaign, nameof(bodycampaign), required: false);
            SourceExpression.Validate(bodycampaignName, nameof(bodycampaignName), required: false);
            SourceExpression.Validate(bodyfooterHtml, nameof(bodyfooterHtml), required: false);
            SourceExpression.Validate(bodyheadHtml, nameof(bodyheadHtml), required: false);
            SourceExpression.Validate(bodyisDraft, nameof(bodyisDraft), required: false);
            SourceExpression.Validate(bodymetaDescription, nameof(bodymetaDescription), required: false);
            SourceExpression.Validate(bodymetaKeywords, nameof(bodymetaKeywords), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            SourceExpression.Validate(bodypublishDate, nameof(bodypublishDate), required: false);
            SourceExpression.Validate(bodypublishImmediately, nameof(bodypublishImmediately), required: false);
            SourceExpression.Validate(bodyslug, nameof(bodyslug), required: false);
            SourceExpression.Validate(bodysubcategory, nameof(bodysubcategory), required: false);
            SourceExpression.Validate(bodywidgetContainers, nameof(bodywidgetContainers), required: false);
            SourceExpression.Validate(bodywidgets, nameof(bodywidgets), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/content/api/v2/pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycampaign != null)
                {
                    body["campaign"] = SourceExpressionConverter.ConvertToken(bodycampaign);
                    bodypropCount++;
                }

                if (bodycampaignName != null)
                {
                    body["campaign_name"] = SourceExpressionConverter.ConvertToken(bodycampaignName);
                    bodypropCount++;
                }

                if (bodyfooterHtml != null)
                {
                    body["footer_html"] = SourceExpressionConverter.ConvertToken(bodyfooterHtml);
                    bodypropCount++;
                }

                if (bodyheadHtml != null)
                {
                    body["head_html"] = SourceExpressionConverter.ConvertToken(bodyheadHtml);
                    bodypropCount++;
                }

                if (bodyisDraft != null)
                {
                    body["is_draft"] = SourceExpressionConverter.ConvertToken(bodyisDraft);
                    bodypropCount++;
                }

                if (bodymetaDescription != null)
                {
                    body["meta_description"] = SourceExpressionConverter.ConvertToken(bodymetaDescription);
                    bodypropCount++;
                }

                if (bodymetaKeywords != null)
                {
                    body["meta_keywords"] = SourceExpressionConverter.ConvertToken(bodymetaKeywords);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodypublishDate != null)
                {
                    body["publish_date"] = SourceExpressionConverter.ConvertToken(bodypublishDate);
                    bodypropCount++;
                }

                if (bodypublishImmediately != null)
                {
                    body["publish_immediately"] = SourceExpressionConverter.ConvertToken(bodypublishImmediately);
                    bodypropCount++;
                }

                if (bodyslug != null)
                {
                    body["slug"] = SourceExpressionConverter.ConvertToken(bodyslug);
                    bodypropCount++;
                }

                if (bodysubcategory != null)
                {
                    body["subcategory"] = SourceExpressionConverter.ConvertToken(bodysubcategory);
                    bodypropCount++;
                }

                if (bodywidgetContainers != null)
                {
                    body["widget_containers"] = SourceExpressionConverter.ConvertToken(bodywidgetContainers);
                    bodypropCount++;
                }

                if (bodywidgets != null)
                {
                    body["widgets"] = SourceExpressionConverter.ConvertToken(bodywidgets);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction PagesArchive([WorkflowExpression] Func<string> pageId)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/content/api/v2/pages/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction PagesUpdate([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> bodycampaign = null, [WorkflowExpression] Func<string> bodycampaignName = null, [WorkflowExpression] Func<string> bodyfooterHtml = null, [WorkflowExpression] Func<string> bodyheadHtml = null, [WorkflowExpression] Func<string> bodyisDraft = null, [WorkflowExpression] Func<string> bodymetaDescription = null, [WorkflowExpression] Func<string> bodymetaKeywords = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodypublishDate = null, [WorkflowExpression] Func<string> bodypublishImmediately = null, [WorkflowExpression] Func<string> bodyslug = null, [WorkflowExpression] Func<string> bodysubcategory = null, [WorkflowExpression] Func<string> bodywidgetContainers = null, [WorkflowExpression] Func<string> bodywidgets = null)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(bodycampaign, nameof(bodycampaign), required: false);
            SourceExpression.Validate(bodycampaignName, nameof(bodycampaignName), required: false);
            SourceExpression.Validate(bodyfooterHtml, nameof(bodyfooterHtml), required: false);
            SourceExpression.Validate(bodyheadHtml, nameof(bodyheadHtml), required: false);
            SourceExpression.Validate(bodyisDraft, nameof(bodyisDraft), required: false);
            SourceExpression.Validate(bodymetaDescription, nameof(bodymetaDescription), required: false);
            SourceExpression.Validate(bodymetaKeywords, nameof(bodymetaKeywords), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            SourceExpression.Validate(bodypublishDate, nameof(bodypublishDate), required: false);
            SourceExpression.Validate(bodypublishImmediately, nameof(bodypublishImmediately), required: false);
            SourceExpression.Validate(bodyslug, nameof(bodyslug), required: false);
            SourceExpression.Validate(bodysubcategory, nameof(bodysubcategory), required: false);
            SourceExpression.Validate(bodywidgetContainers, nameof(bodywidgetContainers), required: false);
            SourceExpression.Validate(bodywidgets, nameof(bodywidgets), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/content/api/v2/pages/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycampaign != null)
                {
                    body["campaign"] = SourceExpressionConverter.ConvertToken(bodycampaign);
                    bodypropCount++;
                }

                if (bodycampaignName != null)
                {
                    body["campaign_name"] = SourceExpressionConverter.ConvertToken(bodycampaignName);
                    bodypropCount++;
                }

                if (bodyfooterHtml != null)
                {
                    body["footer_html"] = SourceExpressionConverter.ConvertToken(bodyfooterHtml);
                    bodypropCount++;
                }

                if (bodyheadHtml != null)
                {
                    body["head_html"] = SourceExpressionConverter.ConvertToken(bodyheadHtml);
                    bodypropCount++;
                }

                if (bodyisDraft != null)
                {
                    body["is_draft"] = SourceExpressionConverter.ConvertToken(bodyisDraft);
                    bodypropCount++;
                }

                if (bodymetaDescription != null)
                {
                    body["meta_description"] = SourceExpressionConverter.ConvertToken(bodymetaDescription);
                    bodypropCount++;
                }

                if (bodymetaKeywords != null)
                {
                    body["meta_keywords"] = SourceExpressionConverter.ConvertToken(bodymetaKeywords);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodypublishDate != null)
                {
                    body["publish_date"] = SourceExpressionConverter.ConvertToken(bodypublishDate);
                    bodypropCount++;
                }

                if (bodypublishImmediately != null)
                {
                    body["publish_immediately"] = SourceExpressionConverter.ConvertToken(bodypublishImmediately);
                    bodypropCount++;
                }

                if (bodyslug != null)
                {
                    body["slug"] = SourceExpressionConverter.ConvertToken(bodyslug);
                    bodypropCount++;
                }

                if (bodysubcategory != null)
                {
                    body["subcategory"] = SourceExpressionConverter.ConvertToken(bodysubcategory);
                    bodypropCount++;
                }

                if (bodywidgetContainers != null)
                {
                    body["widget_containers"] = SourceExpressionConverter.ConvertToken(bodywidgetContainers);
                    bodypropCount++;
                }

                if (bodywidgets != null)
                {
                    body["widgets"] = SourceExpressionConverter.ConvertToken(bodywidgets);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction PagesPublish([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<bodyactionInput> bodyaction)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(bodyaction, nameof(bodyaction), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/content/api/v2/pages/{0}/publish-action", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["action"] = SourceExpressionConverter.Convert(bodyaction);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction TemplatesList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> id = null)
        {
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(id, nameof(id), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/content/api/v2/templates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(20);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction TemplatesCreate([WorkflowExpression] Func<bodycategoryIdInput> bodycategoryId = null, [WorkflowExpression] Func<string> bodyfolder = null, [WorkflowExpression] Func<bool> bodyisAvailableForNewContent = null, [WorkflowExpression] Func<bodytemplateTypeInput> bodytemplateType = null, [WorkflowExpression] Func<string> bodypath = null, [WorkflowExpression] Func<string> bodysource = null)
        {
            SourceExpression.Validate(bodycategoryId, nameof(bodycategoryId), required: false);
            SourceExpression.Validate(bodyfolder, nameof(bodyfolder), required: false);
            SourceExpression.Validate(bodyisAvailableForNewContent, nameof(bodyisAvailableForNewContent), required: false);
            SourceExpression.Validate(bodytemplateType, nameof(bodytemplateType), required: false);
            SourceExpression.Validate(bodypath, nameof(bodypath), required: false);
            SourceExpression.Validate(bodysource, nameof(bodysource), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/content/api/v2/templates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycategoryId != null)
                {
                    body["category_id"] = SourceExpressionConverter.Convert(bodycategoryId);
                    bodypropCount++;
                }

                if (bodyfolder != null)
                {
                    body["folder"] = SourceExpressionConverter.ConvertToken(bodyfolder);
                    bodypropCount++;
                }

                if (bodyisAvailableForNewContent != null)
                {
                    if (bodyisAvailableForNewContent != null)
                    {
                        body["is_available_for_new_content"] = SourceExpressionConverter.ConvertToken(bodyisAvailableForNewContent);
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
                    body["template_type"] = SourceExpressionConverter.Convert(bodytemplateType);
                    bodypropCount++;
                }

                if (bodypath != null)
                {
                    body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                    bodypropCount++;
                }

                if (bodysource != null)
                {
                    body["source"] = SourceExpressionConverter.ConvertToken(bodysource);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction TemplatesArchive([WorkflowExpression] Func<string> templateId)
        {
            SourceExpression.Validate(templateId, nameof(templateId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/content/api/v2/templates/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotcms")]
        public IWorkflowAction TemplatesUpdate([WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> bodysource)
        {
            SourceExpression.Validate(templateId, nameof(templateId), required: true);
            SourceExpression.Validate(bodysource, nameof(bodysource), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/content/api/v2/templates/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["source"] = SourceExpressionConverter.ConvertToken(bodysource);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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