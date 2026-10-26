//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotmarketing
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HubspotmarketingActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FormsList(Expression<Func<int>> limit = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/marketing/v3/forms/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(20);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FormsCreate(Expression<Func<FormsCreateInput>> data = null)
        {
            var __workflow_data = WorkflowExpression.Compile(data, nameof(data), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/marketing/v3/forms/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_data != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_data);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FormsRead(Expression<Func<string>> formId, Expression<Func<bool>> archived = null)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/marketing/v3/forms/{0}", __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FormsArchive(Expression<Func<string>> formId)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/marketing/v3/forms/{0}", __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FormsUpdate(Expression<Func<string>> formId, Expression<Func<FormsUpdateInput>> data)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_data = WorkflowExpression.Compile(data, nameof(data), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/marketing/v3/forms/{0}", __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_data);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MarketingEventRead(Expression<Func<string>> externalEventId, Expression<Func<string>> externalAccountId)
        {
            var __workflow_externalEventId = WorkflowExpression.Compile(externalEventId, nameof(externalEventId), required: true);
            var __workflow_externalAccountId = WorkflowExpression.Compile(externalAccountId, nameof(externalAccountId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/marketing/v3/marketing-events-beta/events/{0}", __workflow_externalEventId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["externalAccountId"] = ExpressionConverter.Convert(__workflow_externalAccountId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MarketingEventsArchive(Expression<Func<string>> externalEventId, Expression<Func<string>> externalAccountId)
        {
            var __workflow_externalEventId = WorkflowExpression.Compile(externalEventId, nameof(externalEventId), required: true);
            var __workflow_externalAccountId = WorkflowExpression.Compile(externalAccountId, nameof(externalAccountId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/marketing/v3/marketing-events-beta/events/{0}", __workflow_externalEventId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["externalAccountId"] = ExpressionConverter.Convert(__workflow_externalAccountId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MarketingEventsUpdateCreateOrUpdate(Expression<Func<string>> externalEventId, Expression<Func<MarketingEventsUpdateCreateOrUpdateInput>> data)
        {
            var __workflow_externalEventId = WorkflowExpression.Compile(externalEventId, nameof(externalEventId), required: true);
            var __workflow_data = WorkflowExpression.Compile(data, nameof(data), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/marketing/v3/marketing-events-beta/events/{0}", __workflow_externalEventId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_data);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MarketingEmailsList(Expression<Func<int>> limit = null, Expression<Func<string>> orderBy = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/marketing-emails/v1/emails";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["orderBy"] = Convert.ToString("created");
                if (__workflow_orderBy != null)
                    callPayload.Queries["orderBy"] = ExpressionConverter.Convert(__workflow_orderBy);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MarketingEmailsRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/marketing-emails/v1/emails/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MarketingEmailsArchive(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/marketing-emails/v1/emails/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MarketingEmailsUpdate(Expression<Func<string>> id, Expression<Func<MarketingEmailsUpdateInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/marketing-emails/v1/emails/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MarketingEmailsCampaignRead(Expression<Func<string>> campaignId)
        {
            var __workflow_campaignId = WorkflowExpression.Compile(campaignId, nameof(campaignId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/email/public/v1/campaigns/{0}", __workflow_campaignId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MarketingEmailsCreate(Expression<Func<MarketingEmailsCreateInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/marketing-emails/v1/emails/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class HubspotmarketingTriggers([ConnectionName] string connectionId)
    {
    }

    public class FormsCreateInput
    {
        [JsonProperty("formType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FormType { get; set; } = "hubspot";

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("archived", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Archived { get; set; } = false;

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("fieldGroups")]
        public FormsCreateInputFieldGroupsTypeItem[] FieldGroups { get; set; }

        [JsonProperty("configuration")]
        public FormsCreateInputConfigurationType Configuration { get; set; }

        [JsonProperty("displayOptions")]
        public FormsCreateInputDisplayOptionsType DisplayOptions { get; set; }
    }

    public class FormsCreateInputFieldGroupsTypeItem
    {
        [JsonProperty("groupType")]
        public string GroupType { get; set; }

        [JsonProperty("richTextType")]
        public string RichTextType { get; set; }

        [JsonProperty("richText")]
        public string RichText { get; set; }

        [JsonProperty("fields")]
        public FormsCreateInputFieldGroupsTypeItemFieldsTypeItem[] Fields { get; set; }
    }

    public class FormsCreateInputFieldGroupsTypeItemFieldsTypeItem
    {
        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("objectTypeId")]
        public string ObjectTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("required")]
        public bool? Required { get; set; }

        [JsonProperty("hidden")]
        public bool? Hidden { get; set; }

        [JsonProperty("dependentFields")]
        public FormsCreateInputFieldGroupsTypeItemFieldsTypeItemDependentFieldsTypeItem[] DependentFields { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        [JsonProperty("defaultValue")]
        public string DefaultValue { get; set; }

        [JsonProperty("validation")]
        public FormsCreateInputFieldGroupsTypeItemFieldsTypeItemValidationType Validation { get; set; }

        [JsonProperty("useCountryCodeSelect")]
        public bool? UseCountryCodeSelect { get; set; }

        [JsonProperty("defaultValues")]
        public string[] DefaultValues { get; set; }

        [JsonProperty("options")]
        public FormsCreateInputFieldGroupsTypeItemFieldsTypeItemOptionsTypeItem[] Options { get; set; }

        [JsonProperty("allowMultipleFiles")]
        public bool? AllowMultipleFiles { get; set; }
    }

    public class FormsCreateInputFieldGroupsTypeItemFieldsTypeItemDependentFieldsTypeItem
    {
        [JsonProperty("dependentCondition")]
        public FormsCreateInputFieldGroupsTypeItemFieldsTypeItemDependentFieldsTypeItemDependentConditionType DependentCondition { get; set; }
    }

    public class FormsCreateInputFieldGroupsTypeItemFieldsTypeItemDependentFieldsTypeItemDependentConditionType
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }

        [JsonProperty("rangeStart")]
        public string RangeStart { get; set; }

        [JsonProperty("rangeEnd")]
        public string RangeEnd { get; set; }
    }

    public class FormsCreateInputFieldGroupsTypeItemFieldsTypeItemValidationType
    {
        [JsonProperty("blockedEmailDomains")]
        public string[] BlockedEmailDomains { get; set; }

        [JsonProperty("useDefaultBlockList")]
        public bool? UseDefaultBlockList { get; set; }

        [JsonProperty("minAllowedDigits")]
        public int? MinAllowedDigits { get; set; }

        [JsonProperty("maxAllowedDigits")]
        public int? MaxAllowedDigits { get; set; }
    }

    public class FormsCreateInputFieldGroupsTypeItemFieldsTypeItemOptionsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayOrder")]
        public int? DisplayOrder { get; set; }
    }

    public class FormsCreateInputConfigurationType
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("cloneable")]
        public bool? Cloneable { get; set; }

        [JsonProperty("postSubmitAction")]
        public FormsCreateInputConfigurationTypePostSubmitActionType PostSubmitAction { get; set; }

        [JsonProperty("editable")]
        public bool? Editable { get; set; }

        [JsonProperty("archivable")]
        public bool? Archivable { get; set; }

        [JsonProperty("recaptchaEnabled")]
        public bool? RecaptchaEnabled { get; set; }

        [JsonProperty("notifyContactOwner")]
        public bool? NotifyContactOwner { get; set; }

        [JsonProperty("notifyRecipients")]
        public string[] NotifyRecipients { get; set; }

        [JsonProperty("createNewContactForNewEmail")]
        public bool? CreateNewContactForNewEmail { get; set; }

        [JsonProperty("prePopulateKnownValues")]
        public bool? PrePopulateKnownValues { get; set; }

        [JsonProperty("allowLinkToResetKnownValues")]
        public bool? AllowLinkToResetKnownValues { get; set; }
    }

    public class FormsCreateInputConfigurationTypePostSubmitActionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class FormsCreateInputDisplayOptionsType
    {
        [JsonProperty("renderRawHtml")]
        public bool? RenderRawHtml { get; set; }

        [JsonProperty("theme")]
        public string Theme { get; set; }

        [JsonProperty("submitButtonText")]
        public string SubmitButtonText { get; set; }

        [JsonProperty("style")]
        public FormsCreateInputDisplayOptionsTypeStyleType Style { get; set; }

        [JsonProperty("cssClass")]
        public string CssClass { get; set; }
    }

    public class FormsCreateInputDisplayOptionsTypeStyleType
    {
        [JsonProperty("fontFamily")]
        public string FontFamily { get; set; }

        [JsonProperty("backgroundWidth")]
        public string BackgroundWidth { get; set; }

        [JsonProperty("labelTextColor")]
        public string LabelTextColor { get; set; }

        [JsonProperty("labelTextSize")]
        public string LabelTextSize { get; set; }

        [JsonProperty("helpTextColor")]
        public string HelpTextColor { get; set; }

        [JsonProperty("helpTextSize")]
        public string HelpTextSize { get; set; }

        [JsonProperty("legalConsentTextColor")]
        public string LegalConsentTextColor { get; set; }

        [JsonProperty("legalConsentTextSize")]
        public string LegalConsentTextSize { get; set; }

        [JsonProperty("submitColor")]
        public string SubmitColor { get; set; }

        [JsonProperty("submitAlignment")]
        public string SubmitAlignment { get; set; }

        [JsonProperty("submitFontColor")]
        public string SubmitFontColor { get; set; }

        [JsonProperty("submitSize")]
        public string SubmitSize { get; set; }
    }

    public class FormsUpdateInput
    {
        [JsonProperty("formType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FormType { get; set; } = "hubspot";

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("createdAt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UpdatedAt { get; set; }

        [JsonProperty("archived", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Archived { get; set; } = false;

        [JsonProperty("archivedAt")]
        public string ArchivedAt { get; set; }

        [JsonProperty("fieldGroups")]
        public FormsUpdateInputFieldGroupsTypeItem[] FieldGroups { get; set; }

        [JsonProperty("configuration")]
        public FormsUpdateInputConfigurationType Configuration { get; set; }

        [JsonProperty("displayOptions")]
        public FormsUpdateInputDisplayOptionsType DisplayOptions { get; set; }
    }

    public class FormsUpdateInputFieldGroupsTypeItem
    {
        [JsonProperty("groupType")]
        public string GroupType { get; set; }

        [JsonProperty("richTextType")]
        public string RichTextType { get; set; }

        [JsonProperty("richText")]
        public string RichText { get; set; }

        [JsonProperty("fields")]
        public FormsUpdateInputFieldGroupsTypeItemFieldsTypeItem[] Fields { get; set; }
    }

    public class FormsUpdateInputFieldGroupsTypeItemFieldsTypeItem
    {
        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("objectTypeId")]
        public string ObjectTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("required")]
        public bool? Required { get; set; }

        [JsonProperty("hidden")]
        public bool? Hidden { get; set; }

        [JsonProperty("dependentFields")]
        public FormsUpdateInputFieldGroupsTypeItemFieldsTypeItemDependentFieldsTypeItem[] DependentFields { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        [JsonProperty("defaultValue")]
        public string DefaultValue { get; set; }

        [JsonProperty("validation")]
        public FormsUpdateInputFieldGroupsTypeItemFieldsTypeItemValidationType Validation { get; set; }

        [JsonProperty("useCountryCodeSelect")]
        public bool? UseCountryCodeSelect { get; set; }

        [JsonProperty("defaultValues")]
        public string[] DefaultValues { get; set; }

        [JsonProperty("options")]
        public FormsUpdateInputFieldGroupsTypeItemFieldsTypeItemOptionsTypeItem[] Options { get; set; }

        [JsonProperty("allowMultipleFiles")]
        public bool? AllowMultipleFiles { get; set; }
    }

    public class FormsUpdateInputFieldGroupsTypeItemFieldsTypeItemDependentFieldsTypeItem
    {
        [JsonProperty("dependentCondition")]
        public FormsUpdateInputFieldGroupsTypeItemFieldsTypeItemDependentFieldsTypeItemDependentConditionType DependentCondition { get; set; }
    }

    public class FormsUpdateInputFieldGroupsTypeItemFieldsTypeItemDependentFieldsTypeItemDependentConditionType
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }

        [JsonProperty("rangeStart")]
        public string RangeStart { get; set; }

        [JsonProperty("rangeEnd")]
        public string RangeEnd { get; set; }
    }

    public class FormsUpdateInputFieldGroupsTypeItemFieldsTypeItemValidationType
    {
        [JsonProperty("blockedEmailDomains")]
        public string[] BlockedEmailDomains { get; set; }

        [JsonProperty("useDefaultBlockList")]
        public bool? UseDefaultBlockList { get; set; }

        [JsonProperty("minAllowedDigits")]
        public int? MinAllowedDigits { get; set; }

        [JsonProperty("maxAllowedDigits")]
        public int? MaxAllowedDigits { get; set; }
    }

    public class FormsUpdateInputFieldGroupsTypeItemFieldsTypeItemOptionsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayOrder")]
        public int? DisplayOrder { get; set; }
    }

    public class FormsUpdateInputConfigurationType
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("cloneable")]
        public bool? Cloneable { get; set; }

        [JsonProperty("postSubmitAction")]
        public FormsUpdateInputConfigurationTypePostSubmitActionType PostSubmitAction { get; set; }

        [JsonProperty("editable")]
        public bool? Editable { get; set; }

        [JsonProperty("archivable")]
        public bool? Archivable { get; set; }

        [JsonProperty("recaptchaEnabled")]
        public bool? RecaptchaEnabled { get; set; }

        [JsonProperty("notifyContactOwner")]
        public bool? NotifyContactOwner { get; set; }

        [JsonProperty("notifyRecipients")]
        public string[] NotifyRecipients { get; set; }

        [JsonProperty("createNewContactForNewEmail")]
        public bool? CreateNewContactForNewEmail { get; set; }

        [JsonProperty("prePopulateKnownValues")]
        public bool? PrePopulateKnownValues { get; set; }

        [JsonProperty("allowLinkToResetKnownValues")]
        public bool? AllowLinkToResetKnownValues { get; set; }
    }

    public class FormsUpdateInputConfigurationTypePostSubmitActionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class FormsUpdateInputDisplayOptionsType
    {
        [JsonProperty("renderRawHtml")]
        public bool? RenderRawHtml { get; set; }

        [JsonProperty("theme")]
        public string Theme { get; set; }

        [JsonProperty("submitButtonText")]
        public string SubmitButtonText { get; set; }

        [JsonProperty("style")]
        public FormsUpdateInputDisplayOptionsTypeStyleType Style { get; set; }

        [JsonProperty("cssClass")]
        public string CssClass { get; set; }
    }

    public class FormsUpdateInputDisplayOptionsTypeStyleType
    {
        [JsonProperty("fontFamily")]
        public string FontFamily { get; set; }

        [JsonProperty("backgroundWidth")]
        public string BackgroundWidth { get; set; }

        [JsonProperty("labelTextColor")]
        public string LabelTextColor { get; set; }

        [JsonProperty("labelTextSize")]
        public string LabelTextSize { get; set; }

        [JsonProperty("helpTextColor")]
        public string HelpTextColor { get; set; }

        [JsonProperty("helpTextSize")]
        public string HelpTextSize { get; set; }

        [JsonProperty("legalConsentTextColor")]
        public string LegalConsentTextColor { get; set; }

        [JsonProperty("legalConsentTextSize")]
        public string LegalConsentTextSize { get; set; }

        [JsonProperty("submitColor")]
        public string SubmitColor { get; set; }

        [JsonProperty("submitAlignment")]
        public string SubmitAlignment { get; set; }

        [JsonProperty("submitFontColor")]
        public string SubmitFontColor { get; set; }

        [JsonProperty("submitSize")]
        public string SubmitSize { get; set; }
    }

    public class MarketingEventsUpdateCreateOrUpdateInput
    {
        [JsonProperty("eventName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EventName { get; set; }

        [JsonProperty("eventType")]
        public MarketingEventsUpdateCreateOrUpdateInputEventTypeType? EventType { get; set; }

        [JsonProperty("startDateTime")]
        public string StartDateTime { get; set; }

        [JsonProperty("endDateTime")]
        public string EndDateTime { get; set; }

        [JsonProperty("eventOrganizer", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EventOrganizer { get; set; }

        [JsonProperty("eventDescription")]
        public string EventDescription { get; set; }

        [JsonProperty("eventUrl")]
        public string EventUrl { get; set; }

        [JsonProperty("eventCancelled")]
        public bool? EventCancelled { get; set; }

        [JsonProperty("customProperties")]
        public MarketingEventsUpdateCreateOrUpdateInputCustomPropertiesTypeItem[] CustomProperties { get; set; }

        [JsonProperty("externalAccountId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ExternalAccountId { get; set; }

        [JsonProperty("externalEventId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ExternalEventId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MarketingEventsUpdateCreateOrUpdateInputEventTypeType
    {
        WEBINAR,
        CONFERENCE,
        WORKSHOP
    }

    public class MarketingEventsUpdateCreateOrUpdateInputCustomPropertiesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("timestamp")]
        public int? Timestamp { get; set; }

        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        [JsonProperty("sourceLabel")]
        public string SourceLabel { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("selectedByUser")]
        public bool? SelectedByUser { get; set; }

        [JsonProperty("selectedByUserTimestamp")]
        public int? SelectedByUserTimestamp { get; set; }

        [JsonProperty("sourceVid")]
        public int[] SourceVid { get; set; }

        [JsonProperty("sourceMetadata")]
        public string SourceMetadata { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }
    }

    public class MarketingEmailsUpdateInput
    {
        [JsonProperty("fromName")]
        public string FromName { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }
    }

    public class MarketingEmailsCreateInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotmarketing;

    public partial class WorkflowManagedActions
    {
        public HubspotmarketingActions Hubspotmarketing(string connectionId) => new HubspotmarketingActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HubspotmarketingTriggers Hubspotmarketing(string connectionId) => new HubspotmarketingTriggers(connectionId);
    }
}