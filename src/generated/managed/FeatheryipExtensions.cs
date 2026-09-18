//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Featheryip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FeatheryipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "featheryip")]
        public IBodyWorkflowAction<AccountGetResponse> AccountGet()
        {
            var apiCallPath = "/account/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AccountGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "featheryip")]
        public IBodyWorkflowAction<FormGetResponse> FormGet([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> formId)
        {
            var apiCallPath = String.Format("/form/{0}/", ExpressionConverter.ConvertWithUrlEncoding(formId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FormGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "featheryip")]
        public IWorkflowAction Form([WorkflowExpression] Func<string> bodyformId = null, [WorkflowExpression] Func<string> bodytemplateFormId = null, [WorkflowExpression] Func<bodystepsInputItem[]> bodysteps = null, [WorkflowExpression] Func<bodynavigationRulesInputItem[]> bodynavigationRules = null)
        {
            var apiCallPath = "/form/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyformId != null)
            {
                body["form_id"] = ExpressionConverter.ConvertO(bodyformId);
                bodypropCount++;
            }

            if (bodytemplateFormId != null)
            {
                body["template_form_id"] = ExpressionConverter.ConvertO(bodytemplateFormId);
                bodypropCount++;
            }

            if (bodysteps != null)
            {
                body["steps"] = ExpressionConverter.ConvertO(bodysteps);
                bodypropCount++;
            }

            if (bodynavigationRules != null)
            {
                body["navigation_rules"] = ExpressionConverter.ConvertO(bodynavigationRules);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "featheryip")]
        public IBodyWorkflowAction<UsersGetResponseItem[]> UsersGet()
        {
            var apiCallPath = "/user";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UsersGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "featheryip")]
        public IBodyWorkflowAction<UserSessionGetResponse> UserSessionGet([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> userId, [WorkflowExpression] Func<string> formKey)
        {
            var apiCallPath = String.Format("/user/{0}/session/{1}/", ExpressionConverter.ConvertWithUrlEncoding(userId, 1), ExpressionConverter.ConvertWithUrlEncoding(formKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserSessionGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "featheryip")]
        public IBodyWorkflowAction<UserPostResponse> User([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyname = null)
        {
            var apiCallPath = "/user/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UserPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "featheryip")]
        public IBodyWorkflowAction<string> UserDelete([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/user/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "featheryip")]
        public IBodyWorkflowAction<UserFieldsGetResponseItem[]> UserFieldsGet([WorkflowExpression] Func<string> id = null)
        {
            var apiCallPath = "/field/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction<UserFieldsGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "featheryip")]
        public IBodyWorkflowAction<UserFieldPostResponse> UserField([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> bodyfieldId = null, [WorkflowExpression] Func<string> bodyvalue = null)
        {
            var apiCallPath = String.Format("/field/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfieldId != null)
            {
                body["field_id"] = ExpressionConverter.ConvertO(bodyfieldId);
                bodypropCount++;
            }

            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UserFieldPostResponse>(callPayload);
        }
    }

    public class FeatheryipTriggers([ConnectionName] string connectionId)
    {
    }

    public class AccountGetResponse
    {
        [JsonProperty("team")]
        public string Team { get; set; }
    }

    public class FormGetResponse
    {
        [JsonProperty("form_id")]
        public string FormId { get; set; }

        [JsonProperty("steps")]
        public FormGetResponseStepsTypeItem[] Steps { get; set; }
    }

    public class FormGetResponseStepsTypeItem
    {
        [JsonProperty("origin")]
        public bool Origin { get; set; }

        [JsonProperty("images")]
        public FormGetResponseStepsTypeItemImagesTypeItem[] Images { get; set; }

        [JsonProperty("videos")]
        public FormGetResponseStepsTypeItemVideosTypeItem[] Videos { get; set; }

        [JsonProperty("progress_bars")]
        public FormGetResponseStepsTypeItemProgressBarsTypeItem[] ProgressBars { get; set; }

        [JsonProperty("texts")]
        public FormGetResponseStepsTypeItemTextsTypeItem[] Texts { get; set; }

        [JsonProperty("buttons")]
        public FormGetResponseStepsTypeItemButtonsTypeItem[] Buttons { get; set; }

        [JsonProperty("subgrids")]
        public FormGetResponseStepsTypeItemSubgridsTypeItem[] Subgrids { get; set; }

        [JsonProperty("previous_conditions")]
        public FormGetResponseStepsTypeItemPreviousConditionsTypeItem[] PreviousConditions { get; set; }

        [JsonProperty("next_conditions")]
        public FormGetResponseStepsTypeItemNextConditionsTypeItem[] NextConditions { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("fields")]
        public string[] Fields { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class FormGetResponseStepsTypeItemImagesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public FormGetResponseStepsTypeItemImagesTypeItemPropertiesType Properties { get; set; }
    }

    public class FormGetResponseStepsTypeItemImagesTypeItemPropertiesType
    {
        [JsonProperty("source_image")]
        public string SourceImage { get; set; }
    }

    public class FormGetResponseStepsTypeItemVideosTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public FormGetResponseStepsTypeItemVideosTypeItemPropertiesType Properties { get; set; }
    }

    public class FormGetResponseStepsTypeItemVideosTypeItemPropertiesType
    {
        [JsonProperty("loop")]
        public bool Loop { get; set; }

        [JsonProperty("muted")]
        public bool Muted { get; set; }

        [JsonProperty("autoplay")]
        public bool Autoplay { get; set; }

        [JsonProperty("controls")]
        public bool Controls { get; set; }

        [JsonProperty("source_url")]
        public string SourceUrl { get; set; }

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("video_extension")]
        public string VideoExtension { get; set; }
    }

    public class FormGetResponseStepsTypeItemProgressBarsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public FormGetResponseStepsTypeItemProgressBarsTypeItemPropertiesType Properties { get; set; }
    }

    public class FormGetResponseStepsTypeItemProgressBarsTypeItemPropertiesType
    {
        [JsonProperty("progress")]
        public string Progress { get; set; }

        [JsonProperty("num_segments")]
        public int NumSegments { get; set; }
    }

    public class FormGetResponseStepsTypeItemTextsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public FormGetResponseStepsTypeItemTextsTypeItemPropertiesType Properties { get; set; }
    }

    public class FormGetResponseStepsTypeItemTextsTypeItemPropertiesType
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("text_formatted")]
        public FormGetResponseStepsTypeItemTextsTypeItemPropertiesTypeTextFormattedTypeItem[] TextFormatted { get; set; }
    }

    public class FormGetResponseStepsTypeItemTextsTypeItemPropertiesTypeTextFormattedTypeItem
    {
        [JsonProperty("insert")]
        public string Insert { get; set; }

        [JsonProperty("attributes")]
        public FormGetResponseStepsTypeItemTextsTypeItemPropertiesTypeTextFormattedTypeItemAttributesType Attributes { get; set; }
    }

    public class FormGetResponseStepsTypeItemTextsTypeItemPropertiesTypeTextFormattedTypeItemAttributesType
    {
        [JsonProperty("font_size")]
        public int FontSize { get; set; }

        [JsonProperty("font_color")]
        public string FontColor { get; set; }

        [JsonProperty("font_link")]
        public string FontLink { get; set; }

        [JsonProperty("font_weight")]
        public int FontWeight { get; set; }

        [JsonProperty("font_strike")]
        public bool FontStrike { get; set; }

        [JsonProperty("font_underline")]
        public bool FontUnderline { get; set; }
    }

    public class FormGetResponseStepsTypeItemButtonsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public FormGetResponseStepsTypeItemButtonsTypeItemPropertiesType Properties { get; set; }
    }

    public class FormGetResponseStepsTypeItemButtonsTypeItemPropertiesType
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("submit")]
        public bool Submit { get; set; }

        [JsonProperty("actions")]
        public FormGetResponseStepsTypeItemButtonsTypeItemPropertiesTypeActionsTypeItem[] Actions { get; set; }

        [JsonProperty("text_formatted")]
        public FormGetResponseStepsTypeItemButtonsTypeItemPropertiesTypeTextFormattedTypeItem[] TextFormatted { get; set; }

        [JsonProperty("show_loading_icon")]
        public string ShowLoadingIcon { get; set; }

        [JsonProperty("disable_if_fields_incomplete")]
        public bool DisableIfFieldsIncomplete { get; set; }
    }

    public class FormGetResponseStepsTypeItemButtonsTypeItemPropertiesTypeActionsTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("submit")]
        public bool Submit { get; set; }

        [JsonProperty("open_tab")]
        public bool OpenTab { get; set; }
    }

    public class FormGetResponseStepsTypeItemButtonsTypeItemPropertiesTypeTextFormattedTypeItem
    {
        [JsonProperty("insert")]
        public string Insert { get; set; }

        [JsonProperty("attributes")]
        public FormGetResponseStepsTypeItemButtonsTypeItemPropertiesTypeTextFormattedTypeItemAttributesType Attributes { get; set; }
    }

    public class FormGetResponseStepsTypeItemButtonsTypeItemPropertiesTypeTextFormattedTypeItemAttributesType
    {
        [JsonProperty("font_color")]
        public string FontColor { get; set; }

        [JsonProperty("font_strike")]
        public bool FontStrike { get; set; }

        [JsonProperty("font_underline")]
        public bool FontUnderline { get; set; }
    }

    public class FormGetResponseStepsTypeItemSubgridsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("position")]
        public int[] Position { get; set; }

        [JsonProperty("axis")]
        public string Axis { get; set; }

        [JsonProperty("mobile_axis")]
        public string MobileAxis { get; set; }

        [JsonProperty("layout")]
        public int[] Layout { get; set; }

        [JsonProperty("mobile_layout")]
        public string MobileLayout { get; set; }

        [JsonProperty("styles")]
        public FormGetResponseStepsTypeItemSubgridsTypeItemStylesType Styles { get; set; }

        [JsonProperty("mobile_styles")]
        public FormGetResponseStepsTypeItemSubgridsTypeItemMobileStylesType MobileStyles { get; set; }

        [JsonProperty("key")]
        public int Key { get; set; }
    }

    public class FormGetResponseStepsTypeItemSubgridsTypeItemStylesType
    {
        [JsonProperty("gap")]
        public int Gap { get; set; }

        [JsonProperty("padding_top")]
        public int PaddingTop { get; set; }

        [JsonProperty("padding_left")]
        public int PaddingLeft { get; set; }

        [JsonProperty("padding_right")]
        public int PaddingRight { get; set; }

        [JsonProperty("padding_bottom")]
        public int PaddingBottom { get; set; }

        [JsonProperty("vertical_align")]
        public string VerticalAlign { get; set; }

        [JsonProperty("horizontal_align")]
        public string HorizontalAlign { get; set; }

        [JsonProperty("external_padding_top")]
        public int ExternalPaddingTop { get; set; }

        [JsonProperty("external_padding_left")]
        public int ExternalPaddingLeft { get; set; }

        [JsonProperty("external_padding_right")]
        public int ExternalPaddingRight { get; set; }

        [JsonProperty("external_padding_bottom")]
        public int ExternalPaddingBottom { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty("layout")]
        public string Layout { get; set; }
    }

    public class FormGetResponseStepsTypeItemSubgridsTypeItemMobileStylesType
    {
        [JsonProperty("gap")]
        public int Gap { get; set; }

        [JsonProperty("padding_top")]
        public int PaddingTop { get; set; }

        [JsonProperty("padding_left")]
        public int PaddingLeft { get; set; }

        [JsonProperty("padding_right")]
        public int PaddingRight { get; set; }

        [JsonProperty("padding_bottom")]
        public int PaddingBottom { get; set; }

        [JsonProperty("vertical_align")]
        public string VerticalAlign { get; set; }

        [JsonProperty("horizontal_align")]
        public string HorizontalAlign { get; set; }

        [JsonProperty("external_padding_top")]
        public int ExternalPaddingTop { get; set; }

        [JsonProperty("external_padding_left")]
        public int ExternalPaddingLeft { get; set; }

        [JsonProperty("external_padding_right")]
        public int ExternalPaddingRight { get; set; }

        [JsonProperty("external_padding_bottom")]
        public int ExternalPaddingBottom { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty("layout")]
        public string Layout { get; set; }
    }

    public class FormGetResponseStepsTypeItemPreviousConditionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("element_type")]
        public string ElementType { get; set; }

        [JsonProperty("element_id")]
        public string ElementId { get; set; }

        [JsonProperty("next_step")]
        public string NextStep { get; set; }

        [JsonProperty("previous_step")]
        public string PreviousStep { get; set; }

        [JsonProperty("next_step_key")]
        public string NextStepKey { get; set; }

        [JsonProperty("previous_step_key")]
        public string PreviousStepKey { get; set; }
    }

    public class FormGetResponseStepsTypeItemNextConditionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("element_type")]
        public string ElementType { get; set; }

        [JsonProperty("element_id")]
        public string ElementId { get; set; }

        [JsonProperty("next_step")]
        public string NextStep { get; set; }

        [JsonProperty("previous_step")]
        public string PreviousStep { get; set; }

        [JsonProperty("next_step_key")]
        public string NextStepKey { get; set; }

        [JsonProperty("previous_step_key")]
        public string PreviousStepKey { get; set; }
    }

    public class bodystepsInputItem
    {
        [JsonProperty("step_id")]
        public string StepId { get; set; }

        [JsonProperty("template_step_id")]
        public string TemplateStepId { get; set; }

        [JsonProperty("origin")]
        public bool Origin { get; set; }

        [JsonProperty("fields")]
        public bodystepsInputItemFieldsTypeItem[] Fields { get; set; }

        [JsonProperty("texts")]
        public bodystepsInputItemTextsTypeItem[] Texts { get; set; }

        [JsonProperty("buttons")]
        public bodystepsInputItemButtonsTypeItem[] Buttons { get; set; }

        [JsonProperty("images")]
        public bodystepsInputItemImagesTypeItem[] Images { get; set; }

        [JsonProperty("progress_bars")]
        public bodystepsInputItemProgressBarsTypeItem[] ProgressBars { get; set; }
    }

    public class bodystepsInputItemFieldsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("field_id")]
        public string FieldId { get; set; }
    }

    public class bodystepsInputItemTextsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class bodystepsInputItemButtonsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class bodystepsInputItemImagesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("source_url")]
        public string SourceUrl { get; set; }
    }

    public class bodystepsInputItemProgressBarsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }
    }

    public class bodynavigationRulesInputItem
    {
        [JsonProperty("previous_step_id")]
        public string PreviousStepId { get; set; }

        [JsonProperty("next_step_id")]
        public string NextStepId { get; set; }

        [JsonProperty("trigger")]
        public string Trigger { get; set; }

        [JsonProperty("element_type")]
        public string ElementType { get; set; }

        [JsonProperty("element_id")]
        public string ElementId { get; set; }

        [JsonProperty("rules")]
        public bodynavigationRulesInputItemRulesTypeItem[] Rules { get; set; }
    }

    public class bodynavigationRulesInputItemRulesTypeItem
    {
        [JsonProperty("comparison")]
        public string Comparison { get; set; }

        [JsonProperty("field_key")]
        public string FieldKey { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UsersGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class UserSessionGetResponse
    {
        [JsonProperty("current_step_key")]
        public string CurrentStepKey { get; set; }

        [JsonProperty("auth_id")]
        public string AuthId { get; set; }

        [JsonProperty("auth_email")]
        public string AuthEmail { get; set; }

        [JsonProperty("auth_phone")]
        public string AuthPhone { get; set; }
    }

    public class UserPostResponse
    {
        [JsonProperty("api_key")]
        public string ApiKey { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class UserFieldsGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("display_text")]
        public string DisplayText { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }
    }

    public class UserFieldPostResponse
    {
        [JsonProperty("field_id")]
        public string FieldId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Featheryip;

    public partial class WorkflowManagedActions
    {
        public FeatheryipActions Featheryip(string connectionId) => new FeatheryipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FeatheryipTriggers Featheryip(string connectionId) => new FeatheryipTriggers(connectionId);
    }
}