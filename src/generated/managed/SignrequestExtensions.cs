//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Signrequest
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SignrequestActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signrequest")]
        public IBodyWorkflowAction<SignRequestQuickCreate> SignrequestQuickCreateCreate(Expression<Func<Signer[]>> datasigners, Expression<Func<int>> dataautoDeleteDays = null, Expression<Func<int>> dataautoExpireDays = null, Expression<Func<bool>> datadisableAttachments = null, Expression<Func<bool>> datadisableBlockchainProof = null, Expression<Func<bool>> datadisableDate = null, Expression<Func<bool>> datadisableEmails = null, Expression<Func<bool>> datadisableText = null, Expression<Func<bool>> datadisableTextSignatures = null, Expression<Func<bool>> datadisableUploadSignatures = null, Expression<Func<string>> datadocument = null, Expression<Func<string>> dataeventsCallbackUrl = null, Expression<Func<string>> dataexternalId = null, Expression<Func<string>> datafile = null, Expression<Func<string>> datafileFromContent = null, Expression<Func<string>> datafileFromContentName = null, Expression<Func<string>> datafileFromUrl = null, Expression<Func<string>> datafromEmail = null, Expression<Func<string>> datafromEmailName = null, Expression<Func<string>> datafrontendId = null, Expression<Func<bool>> dataisBeingPrepared = null, Expression<Func<string>> datamessage = null, Expression<Func<string>> dataname = null, Expression<Func<InlinePrefillTags[]>> dataprefillTags = null, Expression<Func<string>> dataprepareUrl = null, Expression<Func<string>> dataredirectUrl = null, Expression<Func<string>> dataredirectUrlDeclined = null, Expression<Func<RequiredAttachment[]>> datarequiredAttachments = null, Expression<Func<bool>> datasendReminders = null, Expression<Func<string>> datasubdomain = null, Expression<Func<string>> datasubject = null, Expression<Func<string>> datatemplate = null, Expression<Func<bool>> datatextMessageVerificationLocked = null, Expression<Func<string>> dataurl = null, Expression<Func<string>> datauuid = null, Expression<Func<datawhoInput>> datawho = null)
        {
            var __workflow_datasigners = WorkflowExpression.Compile(datasigners, nameof(datasigners), required: true);
            var __workflow_dataautoDeleteDays = WorkflowExpression.Compile(dataautoDeleteDays, nameof(dataautoDeleteDays), required: false);
            var __workflow_dataautoExpireDays = WorkflowExpression.Compile(dataautoExpireDays, nameof(dataautoExpireDays), required: false);
            var __workflow_datadisableAttachments = WorkflowExpression.Compile(datadisableAttachments, nameof(datadisableAttachments), required: false);
            var __workflow_datadisableBlockchainProof = WorkflowExpression.Compile(datadisableBlockchainProof, nameof(datadisableBlockchainProof), required: false);
            var __workflow_datadisableDate = WorkflowExpression.Compile(datadisableDate, nameof(datadisableDate), required: false);
            var __workflow_datadisableEmails = WorkflowExpression.Compile(datadisableEmails, nameof(datadisableEmails), required: false);
            var __workflow_datadisableText = WorkflowExpression.Compile(datadisableText, nameof(datadisableText), required: false);
            var __workflow_datadisableTextSignatures = WorkflowExpression.Compile(datadisableTextSignatures, nameof(datadisableTextSignatures), required: false);
            var __workflow_datadisableUploadSignatures = WorkflowExpression.Compile(datadisableUploadSignatures, nameof(datadisableUploadSignatures), required: false);
            var __workflow_datadocument = WorkflowExpression.Compile(datadocument, nameof(datadocument), required: false);
            var __workflow_dataeventsCallbackUrl = WorkflowExpression.Compile(dataeventsCallbackUrl, nameof(dataeventsCallbackUrl), required: false);
            var __workflow_dataexternalId = WorkflowExpression.Compile(dataexternalId, nameof(dataexternalId), required: false);
            var __workflow_datafile = WorkflowExpression.Compile(datafile, nameof(datafile), required: false);
            var __workflow_datafileFromContent = WorkflowExpression.Compile(datafileFromContent, nameof(datafileFromContent), required: false);
            var __workflow_datafileFromContentName = WorkflowExpression.Compile(datafileFromContentName, nameof(datafileFromContentName), required: false);
            var __workflow_datafileFromUrl = WorkflowExpression.Compile(datafileFromUrl, nameof(datafileFromUrl), required: false);
            var __workflow_datafromEmail = WorkflowExpression.Compile(datafromEmail, nameof(datafromEmail), required: false);
            var __workflow_datafromEmailName = WorkflowExpression.Compile(datafromEmailName, nameof(datafromEmailName), required: false);
            var __workflow_datafrontendId = WorkflowExpression.Compile(datafrontendId, nameof(datafrontendId), required: false);
            var __workflow_dataisBeingPrepared = WorkflowExpression.Compile(dataisBeingPrepared, nameof(dataisBeingPrepared), required: false);
            var __workflow_datamessage = WorkflowExpression.Compile(datamessage, nameof(datamessage), required: false);
            var __workflow_dataname = WorkflowExpression.Compile(dataname, nameof(dataname), required: false);
            var __workflow_dataprefillTags = WorkflowExpression.Compile(dataprefillTags, nameof(dataprefillTags), required: false);
            var __workflow_dataprepareUrl = WorkflowExpression.Compile(dataprepareUrl, nameof(dataprepareUrl), required: false);
            var __workflow_dataredirectUrl = WorkflowExpression.Compile(dataredirectUrl, nameof(dataredirectUrl), required: false);
            var __workflow_dataredirectUrlDeclined = WorkflowExpression.Compile(dataredirectUrlDeclined, nameof(dataredirectUrlDeclined), required: false);
            var __workflow_datarequiredAttachments = WorkflowExpression.Compile(datarequiredAttachments, nameof(datarequiredAttachments), required: false);
            var __workflow_datasendReminders = WorkflowExpression.Compile(datasendReminders, nameof(datasendReminders), required: false);
            var __workflow_datasubdomain = WorkflowExpression.Compile(datasubdomain, nameof(datasubdomain), required: false);
            var __workflow_datasubject = WorkflowExpression.Compile(datasubject, nameof(datasubject), required: false);
            var __workflow_datatemplate = WorkflowExpression.Compile(datatemplate, nameof(datatemplate), required: false);
            var __workflow_datatextMessageVerificationLocked = WorkflowExpression.Compile(datatextMessageVerificationLocked, nameof(datatextMessageVerificationLocked), required: false);
            var __workflow_dataurl = WorkflowExpression.Compile(dataurl, nameof(dataurl), required: false);
            var __workflow_datauuid = WorkflowExpression.Compile(datauuid, nameof(datauuid), required: false);
            var __workflow_datawho = WorkflowExpression.Compile(datawho, nameof(datawho), required: false);
            return new DeferredBodyAction<SignRequestQuickCreate>(() =>
            {
                var apiCallPath = "/signrequest-quick-create/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var data = new JObject();
                var datapropCount = 0;
                if (__workflow_dataautoDeleteDays != null)
                {
                    data["auto_delete_days"] = ExpressionConverter.ConvertO(__workflow_dataautoDeleteDays);
                    datapropCount++;
                }

                if (__workflow_dataautoExpireDays != null)
                {
                    data["auto_expire_days"] = ExpressionConverter.ConvertO(__workflow_dataautoExpireDays);
                    datapropCount++;
                }

                if (__workflow_datadisableAttachments != null)
                {
                    data["disable_attachments"] = ExpressionConverter.ConvertO(__workflow_datadisableAttachments);
                    datapropCount++;
                }

                if (__workflow_datadisableBlockchainProof != null)
                {
                    data["disable_blockchain_proof"] = ExpressionConverter.ConvertO(__workflow_datadisableBlockchainProof);
                    datapropCount++;
                }

                if (__workflow_datadisableDate != null)
                {
                    data["disable_date"] = ExpressionConverter.ConvertO(__workflow_datadisableDate);
                    datapropCount++;
                }

                if (__workflow_datadisableEmails != null)
                {
                    data["disable_emails"] = ExpressionConverter.ConvertO(__workflow_datadisableEmails);
                    datapropCount++;
                }

                if (__workflow_datadisableText != null)
                {
                    data["disable_text"] = ExpressionConverter.ConvertO(__workflow_datadisableText);
                    datapropCount++;
                }

                if (__workflow_datadisableTextSignatures != null)
                {
                    data["disable_text_signatures"] = ExpressionConverter.ConvertO(__workflow_datadisableTextSignatures);
                    datapropCount++;
                }

                if (__workflow_datadisableUploadSignatures != null)
                {
                    data["disable_upload_signatures"] = ExpressionConverter.ConvertO(__workflow_datadisableUploadSignatures);
                    datapropCount++;
                }

                if (__workflow_datadocument != null)
                {
                    data["document"] = ExpressionConverter.ConvertO(__workflow_datadocument);
                    datapropCount++;
                }

                if (__workflow_dataeventsCallbackUrl != null)
                {
                    data["events_callback_url"] = ExpressionConverter.ConvertO(__workflow_dataeventsCallbackUrl);
                    datapropCount++;
                }

                if (__workflow_dataexternalId != null)
                {
                    data["external_id"] = ExpressionConverter.ConvertO(__workflow_dataexternalId);
                    datapropCount++;
                }

                if (__workflow_datafile != null)
                {
                    data["file"] = ExpressionConverter.ConvertO(__workflow_datafile);
                    datapropCount++;
                }

                if (__workflow_datafileFromContent != null)
                {
                    data["file_from_content"] = ExpressionConverter.ConvertO(__workflow_datafileFromContent);
                    datapropCount++;
                }

                if (__workflow_datafileFromContentName != null)
                {
                    data["file_from_content_name"] = ExpressionConverter.ConvertO(__workflow_datafileFromContentName);
                    datapropCount++;
                }

                if (__workflow_datafileFromUrl != null)
                {
                    data["file_from_url"] = ExpressionConverter.ConvertO(__workflow_datafileFromUrl);
                    datapropCount++;
                }

                if (__workflow_datafromEmail != null)
                {
                    data["from_email"] = ExpressionConverter.ConvertO(__workflow_datafromEmail);
                    datapropCount++;
                }

                if (__workflow_datafromEmailName != null)
                {
                    data["from_email_name"] = ExpressionConverter.ConvertO(__workflow_datafromEmailName);
                    datapropCount++;
                }

                if (__workflow_datafrontendId != null)
                {
                    data["frontend_id"] = ExpressionConverter.ConvertO(__workflow_datafrontendId);
                    datapropCount++;
                }

                if (__workflow_dataisBeingPrepared != null)
                {
                    data["is_being_prepared"] = ExpressionConverter.ConvertO(__workflow_dataisBeingPrepared);
                    datapropCount++;
                }

                if (__workflow_datamessage != null)
                {
                    data["message"] = ExpressionConverter.ConvertO(__workflow_datamessage);
                    datapropCount++;
                }

                if (__workflow_dataname != null)
                {
                    data["name"] = ExpressionConverter.ConvertO(__workflow_dataname);
                    datapropCount++;
                }

                if (__workflow_dataprefillTags != null)
                {
                    data["prefill_tags"] = ExpressionConverter.ConvertO(__workflow_dataprefillTags);
                    datapropCount++;
                }

                if (__workflow_dataprepareUrl != null)
                {
                    data["prepare_url"] = ExpressionConverter.ConvertO(__workflow_dataprepareUrl);
                    datapropCount++;
                }

                if (__workflow_dataredirectUrl != null)
                {
                    data["redirect_url"] = ExpressionConverter.ConvertO(__workflow_dataredirectUrl);
                    datapropCount++;
                }

                if (__workflow_dataredirectUrlDeclined != null)
                {
                    data["redirect_url_declined"] = ExpressionConverter.ConvertO(__workflow_dataredirectUrlDeclined);
                    datapropCount++;
                }

                if (__workflow_datarequiredAttachments != null)
                {
                    data["required_attachments"] = ExpressionConverter.ConvertO(__workflow_datarequiredAttachments);
                    datapropCount++;
                }

                if (__workflow_datasendReminders != null)
                {
                    data["send_reminders"] = ExpressionConverter.ConvertO(__workflow_datasendReminders);
                    datapropCount++;
                }

                datapropCount++;
                data["signers"] = ExpressionConverter.ConvertO(__workflow_datasigners);
                if (__workflow_datasubdomain != null)
                {
                    data["subdomain"] = ExpressionConverter.ConvertO(__workflow_datasubdomain);
                    datapropCount++;
                }

                if (__workflow_datasubject != null)
                {
                    data["subject"] = ExpressionConverter.ConvertO(__workflow_datasubject);
                    datapropCount++;
                }

                if (__workflow_datatemplate != null)
                {
                    data["template"] = ExpressionConverter.ConvertO(__workflow_datatemplate);
                    datapropCount++;
                }

                if (__workflow_datatextMessageVerificationLocked != null)
                {
                    data["text_message_verification_locked"] = ExpressionConverter.ConvertO(__workflow_datatextMessageVerificationLocked);
                    datapropCount++;
                }

                if (__workflow_dataurl != null)
                {
                    data["url"] = ExpressionConverter.ConvertO(__workflow_dataurl);
                    datapropCount++;
                }

                if (__workflow_datauuid != null)
                {
                    data["uuid"] = ExpressionConverter.ConvertO(__workflow_datauuid);
                    datapropCount++;
                }

                if (__workflow_datawho != null)
                {
                    if (__workflow_datawho != null)
                    {
                        data["who"] = ExpressionConverter.ConvertO(__workflow_datawho);
                        datapropCount++;
                    }

                    datapropCount++;
                }
                else
                {
                    data["who"] = "o";
                    datapropCount++;
                }

                if (datapropCount > 0)
                {
                    callPayload.Body = data;
                }

                return new ApiConnectionAction<SignRequestQuickCreate>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class SignrequestTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookSubscription> WebhooksCreate(Expression<Func<dataeventTypeInput>> dataeventType, Expression<Func<string>> datacreated = null, Expression<Func<string>> dataname = null, Expression<Func<string>> datasubdomain = null, Expression<Func<string>> datateamname = null, Expression<Func<string>> datateamsubdomain = null, Expression<Func<string>> datateamurl = null, Expression<Func<string>> dataurl = null, Expression<Func<string>> datauuid = null, FlowRecurrence recurrence = null)
        {
            var __workflow_dataeventType = WorkflowExpression.Compile(dataeventType, nameof(dataeventType), required: true);
            var __workflow_datacreated = WorkflowExpression.Compile(datacreated, nameof(datacreated), required: false);
            var __workflow_dataname = WorkflowExpression.Compile(dataname, nameof(dataname), required: false);
            var __workflow_datasubdomain = WorkflowExpression.Compile(datasubdomain, nameof(datasubdomain), required: false);
            var __workflow_datateamname = WorkflowExpression.Compile(datateamname, nameof(datateamname), required: false);
            var __workflow_datateamsubdomain = WorkflowExpression.Compile(datateamsubdomain, nameof(datateamsubdomain), required: false);
            var __workflow_datateamurl = WorkflowExpression.Compile(datateamurl, nameof(datateamurl), required: false);
            var __workflow_dataurl = WorkflowExpression.Compile(dataurl, nameof(dataurl), required: false);
            var __workflow_datauuid = WorkflowExpression.Compile(datauuid, nameof(datauuid), required: false);
            return new DeferredBodyTrigger<WebhookSubscription>(() =>
            {
                var apiCallPath = "/webhooks/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var data = new JObject();
                var datapropCount = 0;
                data["callback_url"] = "#{listCallbackUrl()}";
                datapropCount++;
                if (__workflow_datacreated != null)
                {
                    data["created"] = ExpressionConverter.ConvertO(__workflow_datacreated);
                    datapropCount++;
                }

                datapropCount++;
                data["event_type"] = ExpressionConverter.ConvertO(__workflow_dataeventType);
                if (__workflow_dataname != null)
                {
                    data["name"] = ExpressionConverter.ConvertO(__workflow_dataname);
                    datapropCount++;
                }

                if (__workflow_datasubdomain != null)
                {
                    data["subdomain"] = ExpressionConverter.ConvertO(__workflow_datasubdomain);
                    datapropCount++;
                }

                var teamObject = new JObject();
                var teamObjectpropCount = 0;
                if (__workflow_datateamname != null)
                {
                    teamObject["name"] = ExpressionConverter.ConvertO(__workflow_datateamname);
                    teamObjectpropCount++;
                }

                if (__workflow_datateamsubdomain != null)
                {
                    teamObject["subdomain"] = ExpressionConverter.ConvertO(__workflow_datateamsubdomain);
                    teamObjectpropCount++;
                }

                if (__workflow_datateamurl != null)
                {
                    teamObject["url"] = ExpressionConverter.ConvertO(__workflow_datateamurl);
                    teamObjectpropCount++;
                }

                if (teamObjectpropCount > 0)
                {
                    data["team"] = teamObject;
                    datapropCount++;
                }

                if (__workflow_dataurl != null)
                {
                    data["url"] = ExpressionConverter.ConvertO(__workflow_dataurl);
                    datapropCount++;
                }

                if (__workflow_datauuid != null)
                {
                    data["uuid"] = ExpressionConverter.ConvertO(__workflow_datauuid);
                    datapropCount++;
                }

                if (datapropCount > 0)
                {
                    callPayload.Body = data;
                }

                return new ApiConnectionTrigger<WebhookSubscription>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }
    }

    public class SignRequestQuickCreate
    {
        [JsonProperty("auto_delete_days")]
        public int AutoDeleteDays { get; set; }

        [JsonProperty("auto_expire_days")]
        public int AutoExpireDays { get; set; }

        [JsonProperty("disable_attachments")]
        public bool DisableAttachments { get; set; }

        [JsonProperty("disable_blockchain_proof")]
        public bool DisableBlockchainProof { get; set; }

        [JsonProperty("disable_date")]
        public bool DisableDate { get; set; }

        [JsonProperty("disable_emails")]
        public bool DisableEmails { get; set; }

        [JsonProperty("disable_text")]
        public bool DisableText { get; set; }

        [JsonProperty("disable_text_signatures")]
        public bool DisableTextSignatures { get; set; }

        [JsonProperty("disable_upload_signatures")]
        public bool DisableUploadSignatures { get; set; }

        [JsonProperty("document")]
        public string Document { get; set; }

        [JsonProperty("events_callback_url")]
        public string EventsCallbackUrl { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("file_from_content")]
        public string FileFromContent { get; set; }

        [JsonProperty("file_from_content_name")]
        public string FileFromContentName { get; set; }

        [JsonProperty("file_from_url")]
        public string FileFromUrl { get; set; }

        [JsonProperty("from_email")]
        public string FromEmail { get; set; }

        [JsonProperty("from_email_name")]
        public string FromEmailName { get; set; }

        [JsonProperty("frontend_id")]
        public string FrontendId { get; set; }

        [JsonProperty("is_being_prepared")]
        public bool IsBeingPrepared { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("prefill_tags")]
        public InlinePrefillTags[] PrefillTags { get; set; }

        [JsonProperty("prepare_url")]
        public string PrepareUrl { get; set; }

        [JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }

        [JsonProperty("redirect_url_declined")]
        public string RedirectUrlDeclined { get; set; }

        [JsonProperty("required_attachments")]
        public RequiredAttachment[] RequiredAttachments { get; set; }

        [JsonProperty("send_reminders")]
        public bool SendReminders { get; set; }

        [JsonProperty("signers")]
        public Signer[] Signers { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("text_message_verification_locked")]
        public bool TextMessageVerificationLocked { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("who")]
        public SignRequestQuickCreateWhoType Who { get; set; }
    }

    public class InlinePrefillTags
    {
        [JsonProperty("checkbox_value")]
        public bool CheckboxValue { get; set; }

        [JsonProperty("date_value")]
        public string DateValue { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class RequiredAttachment
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public class Signer
    {
        [JsonProperty("after_document")]
        public string AfterDocument { get; set; }

        [JsonProperty("approve_only")]
        public bool ApproveOnly { get; set; }

        [JsonProperty("attachments")]
        public SignerAttachment[] Attachments { get; set; }

        [JsonProperty("declined")]
        public bool Declined { get; set; }

        [JsonProperty("declined_on")]
        public string DeclinedOn { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("downloaded")]
        public bool Downloaded { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("email_viewed")]
        public bool EmailViewed { get; set; }

        [JsonProperty("emailed")]
        public bool Emailed { get; set; }

        [JsonProperty("embed_url")]
        public string EmbedUrl { get; set; }

        [JsonProperty("embed_url_user_id")]
        public string EmbedUrlUserId { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("force_language")]
        public bool ForceLanguage { get; set; }

        [JsonProperty("forwarded")]
        public bool Forwarded { get; set; }

        [JsonProperty("forwarded_on")]
        public string ForwardedOn { get; set; }

        [JsonProperty("forwarded_reason")]
        public string ForwardedReason { get; set; }

        [JsonProperty("forwarded_to_email")]
        public string ForwardedToEmail { get; set; }

        [JsonProperty("in_person")]
        public bool InPerson { get; set; }

        [JsonProperty("inputs")]
        public SignerInputs[] Inputs { get; set; }

        [JsonProperty("language")]
        public SignerLanguageType Language { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("needs_to_sign")]
        public bool NeedsToSign { get; set; }

        [JsonProperty("notify_only")]
        public bool NotifyOnly { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }

        [JsonProperty("redirect_url_declined")]
        public string RedirectUrlDeclined { get; set; }

        [JsonProperty("signed")]
        public bool Signed { get; set; }

        [JsonProperty("signed_on")]
        public string SignedOn { get; set; }

        [JsonProperty("use_stamp_for_approve_only")]
        public bool UseStampForApproveOnly { get; set; }

        [JsonProperty("verify_bank_account")]
        public string VerifyBankAccount { get; set; }

        [JsonProperty("verify_phone_number")]
        public string VerifyPhoneNumber { get; set; }

        [JsonProperty("viewed")]
        public bool Viewed { get; set; }
    }

    public class SignerAttachment
    {
        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("for_attachment")]
        public RequiredAttachment ForAttachment { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public class SignerInputs
    {
        [JsonProperty("checkbox_value")]
        public bool CheckboxValue { get; set; }

        [JsonProperty("date_value")]
        public string DateValue { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("page_index")]
        public int PageIndex { get; set; }

        [JsonProperty("placeholder_uuid")]
        public string PlaceholderUuid { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("type")]
        public SignerInputsTypeType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SignerInputsTypeType
    {
        [EnumMember(Value = "s")]
        S,
        [EnumMember(Value = "i")]
        I,
        [EnumMember(Value = "n")]
        N,
        [EnumMember(Value = "d")]
        D,
        [EnumMember(Value = "t")]
        T,
        [EnumMember(Value = "c")]
        C
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SignerLanguageType
    {
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "en-gb")]
        EnGb,
        [EnumMember(Value = "nl")]
        Nl,
        [EnumMember(Value = "fr")]
        Fr,
        [EnumMember(Value = "de")]
        De,
        [EnumMember(Value = "he")]
        He,
        [EnumMember(Value = "da")]
        Da,
        [EnumMember(Value = "fi")]
        Fi,
        [EnumMember(Value = "hu")]
        Hu,
        [EnumMember(Value = "it")]
        It,
        [EnumMember(Value = "no")]
        No,
        [EnumMember(Value = "pl")]
        Pl,
        [EnumMember(Value = "pt")]
        Pt,
        [EnumMember(Value = "es")]
        Es,
        [EnumMember(Value = "sv")]
        Sv,
        [EnumMember(Value = "ru")]
        Ru
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SignRequestQuickCreateWhoType
    {
        [EnumMember(Value = "m")]
        M,
        [EnumMember(Value = "mo")]
        Mo,
        [EnumMember(Value = "o")]
        O
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum datawhoInput
    {
        [EnumMember(Value = "m")]
        M,
        [EnumMember(Value = "mo")]
        Mo,
        [EnumMember(Value = "o")]
        O
    }

    public class WebhookSubscription
    {
        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("event_type")]
        public WebhookSubscriptionEventTypeType EventType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("team")]
        public WebhookSubscriptionTeamType Team { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebhookSubscriptionEventTypeType
    {
        [EnumMember(Value = "convert_error")]
        ConvertError,
        [EnumMember(Value = "converted")]
        Converted,
        [EnumMember(Value = "sending_error")]
        SendingError,
        [EnumMember(Value = "sent")]
        Sent,
        [EnumMember(Value = "declined")]
        Declined,
        [EnumMember(Value = "cancelled")]
        Cancelled,
        [EnumMember(Value = "expired")]
        Expired,
        [EnumMember(Value = "signed")]
        Signed,
        [EnumMember(Value = "viewed")]
        Viewed,
        [EnumMember(Value = "downloaded")]
        Downloaded,
        [EnumMember(Value = "signer_signed")]
        SignerSigned,
        [EnumMember(Value = "signer_email_bounced")]
        SignerEmailBounced,
        [EnumMember(Value = "signer_viewed_email")]
        SignerViewedEmail,
        [EnumMember(Value = "signer_viewed")]
        SignerViewed,
        [EnumMember(Value = "signer_forwarded")]
        SignerForwarded,
        [EnumMember(Value = "signer_downloaded")]
        SignerDownloaded,
        [EnumMember(Value = "signrequest_received")]
        SignrequestReceived
    }

    public class WebhookSubscriptionTeamType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum dataeventTypeInput
    {
        [EnumMember(Value = "convert_error")]
        ConvertError,
        [EnumMember(Value = "converted")]
        Converted,
        [EnumMember(Value = "sending_error")]
        SendingError,
        [EnumMember(Value = "sent")]
        Sent,
        [EnumMember(Value = "declined")]
        Declined,
        [EnumMember(Value = "cancelled")]
        Cancelled,
        [EnumMember(Value = "expired")]
        Expired,
        [EnumMember(Value = "signed")]
        Signed,
        [EnumMember(Value = "viewed")]
        Viewed,
        [EnumMember(Value = "downloaded")]
        Downloaded,
        [EnumMember(Value = "signer_signed")]
        SignerSigned,
        [EnumMember(Value = "signer_email_bounced")]
        SignerEmailBounced,
        [EnumMember(Value = "signer_viewed_email")]
        SignerViewedEmail,
        [EnumMember(Value = "signer_viewed")]
        SignerViewed,
        [EnumMember(Value = "signer_forwarded")]
        SignerForwarded,
        [EnumMember(Value = "signer_downloaded")]
        SignerDownloaded,
        [EnumMember(Value = "signrequest_received")]
        SignrequestReceived
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Signrequest;

    public partial class WorkflowManagedActions
    {
        public SignrequestActions Signrequest(string connectionId) => new SignrequestActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SignrequestTriggers Signrequest(string connectionId) => new SignrequestTriggers(connectionId);
    }
}
