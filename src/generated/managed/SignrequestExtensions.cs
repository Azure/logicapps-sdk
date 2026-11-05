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
        public IBodyWorkflowAction<SignRequestQuickCreate, ApiConnectionActionConfiguration> SignrequestQuickCreateCreate(Expression<Func<SignrequestQuickCreateCreateDataInput>> data)
        {
            var __workflow_data = WorkflowExpression.Compile(data, nameof(data), required: true);
            return new DeferredBodyAction<SignRequestQuickCreate, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/signrequest-quick-create/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_data);
                return new ApiConnectionAction<SignRequestQuickCreate>(callPayload);
            });
        }
    }

    public class SignrequestTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookSubscription, ApiConnectionTriggerConfiguration> WebhooksCreate(Expression<Func<WebhooksCreateDataInput>> data, FlowRecurrence recurrence = null)
        {
            var __workflow_data = WorkflowExpression.Compile(data, nameof(data), required: true);
            return new DeferredBodyTrigger<WebhookSubscription, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_data);
                return new ApiConnectionTrigger<WebhookSubscription>(callPayload, recurrence: recurrence);
            });
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
        public SignrequestQuickCreateCreateInlinePrefillTagsResponse[] PrefillTags { get; set; }

        [JsonProperty("prepare_url")]
        public string PrepareUrl { get; set; }

        [JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }

        [JsonProperty("redirect_url_declined")]
        public string RedirectUrlDeclined { get; set; }

        [JsonProperty("required_attachments")]
        public SignrequestQuickCreateCreateRequiredAttachmentResponse[] RequiredAttachments { get; set; }

        [JsonProperty("send_reminders")]
        public bool SendReminders { get; set; }

        [JsonProperty("signers")]
        public SignrequestQuickCreateCreateSignerResponse[] Signers { get; set; }

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

    public class SignrequestQuickCreateCreateInlinePrefillTagsResponse
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

    public class SignrequestQuickCreateCreateRequiredAttachmentResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public class SignrequestQuickCreateCreateSignerResponse
    {
        [JsonProperty("after_document")]
        public string AfterDocument { get; set; }

        [JsonProperty("approve_only")]
        public bool ApproveOnly { get; set; }

        [JsonProperty("attachments")]
        public SignrequestQuickCreateCreateSignerAttachmentResponse[] Attachments { get; set; }

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
        public SignrequestQuickCreateCreateSignerInputsResponse[] Inputs { get; set; }

        [JsonProperty("language")]
        public SignrequestQuickCreateCreateSignerLanguageTypeResponse Language { get; set; }

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

    public class SignrequestQuickCreateCreateSignerAttachmentResponse
    {
        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("for_attachment")]
        public SignrequestQuickCreateCreateRequiredAttachmentResponse ForAttachment { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public class SignrequestQuickCreateCreateSignerInputsResponse
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
        public SignrequestQuickCreateCreateSignerInputsTypeTypeResponse Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SignrequestQuickCreateCreateSignerInputsTypeTypeResponse
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
    public enum SignrequestQuickCreateCreateSignerLanguageTypeResponse
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

    public class SignrequestQuickCreateCreateDataInput
    {
        [JsonProperty("auto_delete_days")]
        public int? AutoDeleteDays { get; set; }

        [JsonProperty("auto_expire_days")]
        public int? AutoExpireDays { get; set; }

        [JsonProperty("disable_attachments")]
        public bool? DisableAttachments { get; set; }

        [JsonProperty("disable_blockchain_proof")]
        public bool? DisableBlockchainProof { get; set; }

        [JsonProperty("disable_date")]
        public bool? DisableDate { get; set; }

        [JsonProperty("disable_emails")]
        public bool? DisableEmails { get; set; }

        [JsonProperty("disable_text")]
        public bool? DisableText { get; set; }

        [JsonProperty("disable_text_signatures")]
        public bool? DisableTextSignatures { get; set; }

        [JsonProperty("disable_upload_signatures")]
        public bool? DisableUploadSignatures { get; set; }

        [JsonProperty("document")]
        public string Document { get; set; }

        [JsonProperty("events_callback_url")]
        public string EventsCallbackUrl { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("file_from_content")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileFromContent { get; set; }

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
        public bool? IsBeingPrepared { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("prefill_tags")]
        public SignrequestQuickCreateCreateInlinePrefillTags[] PrefillTags { get; set; }

        [JsonProperty("prepare_url")]
        public string PrepareUrl { get; set; }

        [JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }

        [JsonProperty("redirect_url_declined")]
        public string RedirectUrlDeclined { get; set; }

        [JsonProperty("required_attachments")]
        public SignrequestQuickCreateCreateRequiredAttachment[] RequiredAttachments { get; set; }

        [JsonProperty("send_reminders")]
        public bool? SendReminders { get; set; }

        [JsonProperty("signers", DefaultValueHandling = DefaultValueHandling.Include)]
        public SignrequestQuickCreateCreateSigner[] Signers { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("text_message_verification_locked")]
        public bool? TextMessageVerificationLocked { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("who", DefaultValueHandling = DefaultValueHandling.Include)]
        public DataInputWhoType? Who { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Signrequest.DataInputWhoType.O;
    }

    public class SignrequestQuickCreateCreateInlinePrefillTags
    {
        [JsonProperty("checkbox_value")]
        public bool? CheckboxValue { get; set; }

        [JsonProperty("date_value")]
        public string DateValue { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SignrequestQuickCreateCreateRequiredAttachment
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public class SignrequestQuickCreateCreateSigner
    {
        [JsonProperty("after_document")]
        public string AfterDocument { get; set; }

        [JsonProperty("approve_only")]
        public bool? ApproveOnly { get; set; }

        [JsonProperty("attachments")]
        public SignrequestQuickCreateCreateSignerAttachment[] Attachments { get; set; }

        [JsonProperty("declined")]
        public bool? Declined { get; set; }

        [JsonProperty("declined_on")]
        public string DeclinedOn { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("downloaded")]
        public bool? Downloaded { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("email_viewed")]
        public bool? EmailViewed { get; set; }

        [JsonProperty("emailed")]
        public bool? Emailed { get; set; }

        [JsonProperty("embed_url")]
        public string EmbedUrl { get; set; }

        [JsonProperty("embed_url_user_id")]
        public string EmbedUrlUserId { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("force_language")]
        public bool? ForceLanguage { get; set; }

        [JsonProperty("forwarded")]
        public bool? Forwarded { get; set; }

        [JsonProperty("forwarded_on")]
        public string ForwardedOn { get; set; }

        [JsonProperty("forwarded_reason")]
        public string ForwardedReason { get; set; }

        [JsonProperty("forwarded_to_email")]
        public string ForwardedToEmail { get; set; }

        [JsonProperty("in_person")]
        public bool? InPerson { get; set; }

        [JsonProperty("inputs")]
        public SignrequestQuickCreateCreateSignerInputs[] Inputs { get; set; }

        [JsonProperty("language")]
        public SignrequestQuickCreateCreateSignerLanguageType? Language { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("needs_to_sign", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NeedsToSign { get; set; } = true;

        [JsonProperty("notify_only")]
        public bool? NotifyOnly { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }

        [JsonProperty("redirect_url_declined")]
        public string RedirectUrlDeclined { get; set; }

        [JsonProperty("signed")]
        public bool? Signed { get; set; }

        [JsonProperty("signed_on")]
        public string SignedOn { get; set; }

        [JsonProperty("use_stamp_for_approve_only")]
        public bool? UseStampForApproveOnly { get; set; }

        [JsonProperty("verify_bank_account")]
        public string VerifyBankAccount { get; set; }

        [JsonProperty("verify_phone_number")]
        public string VerifyPhoneNumber { get; set; }

        [JsonProperty("viewed")]
        public bool? Viewed { get; set; }
    }

    public class SignrequestQuickCreateCreateSignerAttachment
    {
        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("for_attachment")]
        public SignrequestQuickCreateCreateRequiredAttachment ForAttachment { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public class SignrequestQuickCreateCreateSignerInputs
    {
        [JsonProperty("checkbox_value")]
        public bool? CheckboxValue { get; set; }

        [JsonProperty("date_value")]
        public string DateValue { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("page_index", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageIndex { get; set; }

        [JsonProperty("placeholder_uuid")]
        public string PlaceholderUuid { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("type")]
        public SignrequestQuickCreateCreateSignerInputsTypeType? Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SignrequestQuickCreateCreateSignerInputsTypeType
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
    public enum SignrequestQuickCreateCreateSignerLanguageType
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
    public enum DataInputWhoType
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

    public class WebhooksCreateDataInput
    {
        [JsonProperty("callback_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("event_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public DataInputEventTypeType EventType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("team")]
        public DataInputTeamType Team { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DataInputEventTypeType
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

    public class DataInputTeamType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
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