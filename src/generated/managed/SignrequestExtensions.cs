//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Signrequest
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SignrequestActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signrequest")]
        public IBodyWorkflowAction<SignRequestQuickCreate> SignrequestQuickCreateCreate(Expression<Func<Signer[]>> datasigners, Expression<Func<int>> dataautoDeleteDays = null, Expression<Func<int>> dataautoExpireDays = null, Expression<Func<bool>> datadisableAttachments = null, Expression<Func<bool>> datadisableBlockchainProof = null, Expression<Func<bool>> datadisableDate = null, Expression<Func<bool>> datadisableEmails = null, Expression<Func<bool>> datadisableText = null, Expression<Func<bool>> datadisableTextSignatures = null, Expression<Func<bool>> datadisableUploadSignatures = null, Expression<Func<string>> datadocument = null, Expression<Func<string>> dataeventsCallbackUrl = null, Expression<Func<string>> dataexternalId = null, Expression<Func<string>> datafile = null, Expression<Func<string>> datafileFromContent = null, Expression<Func<string>> datafileFromContentName = null, Expression<Func<string>> datafileFromUrl = null, Expression<Func<string>> datafromEmail = null, Expression<Func<string>> datafromEmailName = null, Expression<Func<string>> datafrontendId = null, Expression<Func<bool>> dataisBeingPrepared = null, Expression<Func<string>> datamessage = null, Expression<Func<string>> dataname = null, Expression<Func<InlinePrefillTags[]>> dataprefillTags = null, Expression<Func<string>> dataprepareUrl = null, Expression<Func<string>> dataredirectUrl = null, Expression<Func<string>> dataredirectUrlDeclined = null, Expression<Func<RequiredAttachment[]>> datarequiredAttachments = null, Expression<Func<bool>> datasendReminders = null, Expression<Func<string>> datasubdomain = null, Expression<Func<string>> datasubject = null, Expression<Func<string>> datatemplate = null, Expression<Func<bool>> datatextMessageVerificationLocked = null, Expression<Func<string>> dataurl = null, Expression<Func<string>> datauuid = null, Expression<Func<datawhoInput>> datawho = null)
        {
            var apiCallPath = "/signrequest-quick-create/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var data = new JObject();
            var datapropCount = 0;
            if (dataautoDeleteDays != null)
            {
                data["auto_delete_days"] = ExpressionConverter.ConvertO(dataautoDeleteDays);
                datapropCount++;
            }

            if (dataautoExpireDays != null)
            {
                data["auto_expire_days"] = ExpressionConverter.ConvertO(dataautoExpireDays);
                datapropCount++;
            }

            if (datadisableAttachments != null)
            {
                data["disable_attachments"] = ExpressionConverter.ConvertO(datadisableAttachments);
                datapropCount++;
            }

            if (datadisableBlockchainProof != null)
            {
                data["disable_blockchain_proof"] = ExpressionConverter.ConvertO(datadisableBlockchainProof);
                datapropCount++;
            }

            if (datadisableDate != null)
            {
                data["disable_date"] = ExpressionConverter.ConvertO(datadisableDate);
                datapropCount++;
            }

            if (datadisableEmails != null)
            {
                data["disable_emails"] = ExpressionConverter.ConvertO(datadisableEmails);
                datapropCount++;
            }

            if (datadisableText != null)
            {
                data["disable_text"] = ExpressionConverter.ConvertO(datadisableText);
                datapropCount++;
            }

            if (datadisableTextSignatures != null)
            {
                data["disable_text_signatures"] = ExpressionConverter.ConvertO(datadisableTextSignatures);
                datapropCount++;
            }

            if (datadisableUploadSignatures != null)
            {
                data["disable_upload_signatures"] = ExpressionConverter.ConvertO(datadisableUploadSignatures);
                datapropCount++;
            }

            if (datadocument != null)
            {
                data["document"] = ExpressionConverter.ConvertO(datadocument);
                datapropCount++;
            }

            if (dataeventsCallbackUrl != null)
            {
                data["events_callback_url"] = ExpressionConverter.ConvertO(dataeventsCallbackUrl);
                datapropCount++;
            }

            if (dataexternalId != null)
            {
                data["external_id"] = ExpressionConverter.ConvertO(dataexternalId);
                datapropCount++;
            }

            if (datafile != null)
            {
                data["file"] = ExpressionConverter.ConvertO(datafile);
                datapropCount++;
            }

            if (datafileFromContent != null)
            {
                data["file_from_content"] = ExpressionConverter.ConvertO(datafileFromContent);
                datapropCount++;
            }

            if (datafileFromContentName != null)
            {
                data["file_from_content_name"] = ExpressionConverter.ConvertO(datafileFromContentName);
                datapropCount++;
            }

            if (datafileFromUrl != null)
            {
                data["file_from_url"] = ExpressionConverter.ConvertO(datafileFromUrl);
                datapropCount++;
            }

            if (datafromEmail != null)
            {
                data["from_email"] = ExpressionConverter.ConvertO(datafromEmail);
                datapropCount++;
            }

            if (datafromEmailName != null)
            {
                data["from_email_name"] = ExpressionConverter.ConvertO(datafromEmailName);
                datapropCount++;
            }

            if (datafrontendId != null)
            {
                data["frontend_id"] = ExpressionConverter.ConvertO(datafrontendId);
                datapropCount++;
            }

            if (dataisBeingPrepared != null)
            {
                data["is_being_prepared"] = ExpressionConverter.ConvertO(dataisBeingPrepared);
                datapropCount++;
            }

            if (datamessage != null)
            {
                data["message"] = ExpressionConverter.ConvertO(datamessage);
                datapropCount++;
            }

            if (dataname != null)
            {
                data["name"] = ExpressionConverter.ConvertO(dataname);
                datapropCount++;
            }

            if (dataprefillTags != null)
            {
                data["prefill_tags"] = ExpressionConverter.ConvertO(dataprefillTags);
                datapropCount++;
            }

            if (dataprepareUrl != null)
            {
                data["prepare_url"] = ExpressionConverter.ConvertO(dataprepareUrl);
                datapropCount++;
            }

            if (dataredirectUrl != null)
            {
                data["redirect_url"] = ExpressionConverter.ConvertO(dataredirectUrl);
                datapropCount++;
            }

            if (dataredirectUrlDeclined != null)
            {
                data["redirect_url_declined"] = ExpressionConverter.ConvertO(dataredirectUrlDeclined);
                datapropCount++;
            }

            if (datarequiredAttachments != null)
            {
                data["required_attachments"] = ExpressionConverter.ConvertO(datarequiredAttachments);
                datapropCount++;
            }

            if (datasendReminders != null)
            {
                data["send_reminders"] = ExpressionConverter.ConvertO(datasendReminders);
                datapropCount++;
            }

            datapropCount++;
            data["signers"] = ExpressionConverter.ConvertO(datasigners);
            if (datasubdomain != null)
            {
                data["subdomain"] = ExpressionConverter.ConvertO(datasubdomain);
                datapropCount++;
            }

            if (datasubject != null)
            {
                data["subject"] = ExpressionConverter.ConvertO(datasubject);
                datapropCount++;
            }

            if (datatemplate != null)
            {
                data["template"] = ExpressionConverter.ConvertO(datatemplate);
                datapropCount++;
            }

            if (datatextMessageVerificationLocked != null)
            {
                data["text_message_verification_locked"] = ExpressionConverter.ConvertO(datatextMessageVerificationLocked);
                datapropCount++;
            }

            if (dataurl != null)
            {
                data["url"] = ExpressionConverter.ConvertO(dataurl);
                datapropCount++;
            }

            if (datauuid != null)
            {
                data["uuid"] = ExpressionConverter.ConvertO(datauuid);
                datapropCount++;
            }

            if (datawho != null)
            {
                data["who"] = ExpressionConverter.ConvertO(datawho);
                datapropCount++;
            }

            if (datapropCount > 0)
            {
                callPayload.Body = data;
            }

            return new ApiConnectionAction<SignRequestQuickCreate>(callPayload);
        }
    }

    public class SignrequestTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<WebhookSubscription> WebhooksCreate(Expression<Func<dataeventTypeInput>> dataeventType, Expression<Func<string>> datacreated = null, Expression<Func<string>> dataname = null, Expression<Func<string>> datasubdomain = null, Expression<Func<string>> datateamname = null, Expression<Func<string>> datateamsubdomain = null, Expression<Func<string>> datateamurl = null, Expression<Func<string>> dataurl = null, Expression<Func<string>> datauuid = null, string triggerName = null)
        {
            var apiCallPath = "/webhooks/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var data = new JObject();
            var datapropCount = 0;
            data["callback_url"] = "@listcallbackurl()";
            datapropCount++;
            if (datacreated != null)
            {
                data["created"] = ExpressionConverter.ConvertO(datacreated);
                datapropCount++;
            }

            datapropCount++;
            data["event_type"] = ExpressionConverter.ConvertO(dataeventType);
            if (dataname != null)
            {
                data["name"] = ExpressionConverter.ConvertO(dataname);
                datapropCount++;
            }

            if (datasubdomain != null)
            {
                data["subdomain"] = ExpressionConverter.ConvertO(datasubdomain);
                datapropCount++;
            }

            var teamObject = new JObject();
            var teamObjectpropCount = 0;
            if (datateamname != null)
            {
                teamObject["name"] = ExpressionConverter.ConvertO(datateamname);
                teamObjectpropCount++;
            }

            if (datateamsubdomain != null)
            {
                teamObject["subdomain"] = ExpressionConverter.ConvertO(datateamsubdomain);
                teamObjectpropCount++;
            }

            if (datateamurl != null)
            {
                teamObject["url"] = ExpressionConverter.ConvertO(datateamurl);
                teamObjectpropCount++;
            }

            if (teamObjectpropCount > 0)
            {
                data["team"] = teamObject;
                datapropCount++;
            }

            if (dataurl != null)
            {
                data["url"] = ExpressionConverter.ConvertO(dataurl);
                datapropCount++;
            }

            if (datauuid != null)
            {
                data["uuid"] = ExpressionConverter.ConvertO(datauuid);
                datapropCount++;
            }

            if (datapropCount > 0)
            {
                callPayload.Body = data;
            }

            return new ApiConnectionTrigger<WebhookSubscription>(callPayload);
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

    public enum SignRequestQuickCreateWhoType
    {
        [EnumMember(Value = "m")]
        M,
        [EnumMember(Value = "mo")]
        Mo,
        [EnumMember(Value = "o")]
        O
    }

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