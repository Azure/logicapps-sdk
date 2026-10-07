//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Signrequest
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SignrequestActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signrequest")]
        [WorkflowExpressionFactory(nameof(__BuildSignrequestQuickCreateCreate))]
        public IBodyWorkflowAction<SignRequestQuickCreate> SignrequestQuickCreateCreate([WorkflowExpression] Func<Signer[]> datasigners, [WorkflowExpression] Func<int> dataautoDeleteDays = null, [WorkflowExpression] Func<int> dataautoExpireDays = null, [WorkflowExpression] Func<bool> datadisableAttachments = null, [WorkflowExpression] Func<bool> datadisableBlockchainProof = null, [WorkflowExpression] Func<bool> datadisableDate = null, [WorkflowExpression] Func<bool> datadisableEmails = null, [WorkflowExpression] Func<bool> datadisableText = null, [WorkflowExpression] Func<bool> datadisableTextSignatures = null, [WorkflowExpression] Func<bool> datadisableUploadSignatures = null, [WorkflowExpression] Func<string> datadocument = null, [WorkflowExpression] Func<string> dataeventsCallbackUrl = null, [WorkflowExpression] Func<string> dataexternalId = null, [WorkflowExpression] Func<string> datafile = null, [WorkflowExpression] Func<string> datafileFromContent = null, [WorkflowExpression] Func<string> datafileFromContentName = null, [WorkflowExpression] Func<string> datafileFromUrl = null, [WorkflowExpression] Func<string> datafromEmail = null, [WorkflowExpression] Func<string> datafromEmailName = null, [WorkflowExpression] Func<string> datafrontendId = null, [WorkflowExpression] Func<bool> dataisBeingPrepared = null, [WorkflowExpression] Func<string> datamessage = null, [WorkflowExpression] Func<string> dataname = null, [WorkflowExpression] Func<InlinePrefillTags[]> dataprefillTags = null, [WorkflowExpression] Func<string> dataprepareUrl = null, [WorkflowExpression] Func<string> dataredirectUrl = null, [WorkflowExpression] Func<string> dataredirectUrlDeclined = null, [WorkflowExpression] Func<RequiredAttachment[]> datarequiredAttachments = null, [WorkflowExpression] Func<bool> datasendReminders = null, [WorkflowExpression] Func<string> datasubdomain = null, [WorkflowExpression] Func<string> datasubject = null, [WorkflowExpression] Func<string> datatemplate = null, [WorkflowExpression] Func<bool> datatextMessageVerificationLocked = null, [WorkflowExpression] Func<string> dataurl = null, [WorkflowExpression] Func<string> datauuid = null, [WorkflowExpression] Func<datawhoInput> datawho = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signrequest")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SignRequestQuickCreate> __BuildSignrequestQuickCreateCreate(WorkflowExpression<Signer[]> datasigners, WorkflowExpression<int> dataautoDeleteDays = null, WorkflowExpression<int> dataautoExpireDays = null, WorkflowExpression<bool> datadisableAttachments = null, WorkflowExpression<bool> datadisableBlockchainProof = null, WorkflowExpression<bool> datadisableDate = null, WorkflowExpression<bool> datadisableEmails = null, WorkflowExpression<bool> datadisableText = null, WorkflowExpression<bool> datadisableTextSignatures = null, WorkflowExpression<bool> datadisableUploadSignatures = null, WorkflowExpression<string> datadocument = null, WorkflowExpression<string> dataeventsCallbackUrl = null, WorkflowExpression<string> dataexternalId = null, WorkflowExpression<string> datafile = null, WorkflowExpression<string> datafileFromContent = null, WorkflowExpression<string> datafileFromContentName = null, WorkflowExpression<string> datafileFromUrl = null, WorkflowExpression<string> datafromEmail = null, WorkflowExpression<string> datafromEmailName = null, WorkflowExpression<string> datafrontendId = null, WorkflowExpression<bool> dataisBeingPrepared = null, WorkflowExpression<string> datamessage = null, WorkflowExpression<string> dataname = null, WorkflowExpression<InlinePrefillTags[]> dataprefillTags = null, WorkflowExpression<string> dataprepareUrl = null, WorkflowExpression<string> dataredirectUrl = null, WorkflowExpression<string> dataredirectUrlDeclined = null, WorkflowExpression<RequiredAttachment[]> datarequiredAttachments = null, WorkflowExpression<bool> datasendReminders = null, WorkflowExpression<string> datasubdomain = null, WorkflowExpression<string> datasubject = null, WorkflowExpression<string> datatemplate = null, WorkflowExpression<bool> datatextMessageVerificationLocked = null, WorkflowExpression<string> dataurl = null, WorkflowExpression<string> datauuid = null, WorkflowExpression<datawhoInput> datawho = null)
        {
            WorkflowExpression.Validate(datasigners, nameof(datasigners), required: true);
            WorkflowExpression.Validate(dataautoDeleteDays, nameof(dataautoDeleteDays), required: false);
            WorkflowExpression.Validate(dataautoExpireDays, nameof(dataautoExpireDays), required: false);
            WorkflowExpression.Validate(datadisableAttachments, nameof(datadisableAttachments), required: false);
            WorkflowExpression.Validate(datadisableBlockchainProof, nameof(datadisableBlockchainProof), required: false);
            WorkflowExpression.Validate(datadisableDate, nameof(datadisableDate), required: false);
            WorkflowExpression.Validate(datadisableEmails, nameof(datadisableEmails), required: false);
            WorkflowExpression.Validate(datadisableText, nameof(datadisableText), required: false);
            WorkflowExpression.Validate(datadisableTextSignatures, nameof(datadisableTextSignatures), required: false);
            WorkflowExpression.Validate(datadisableUploadSignatures, nameof(datadisableUploadSignatures), required: false);
            WorkflowExpression.Validate(datadocument, nameof(datadocument), required: false);
            WorkflowExpression.Validate(dataeventsCallbackUrl, nameof(dataeventsCallbackUrl), required: false);
            WorkflowExpression.Validate(dataexternalId, nameof(dataexternalId), required: false);
            WorkflowExpression.Validate(datafile, nameof(datafile), required: false);
            WorkflowExpression.Validate(datafileFromContent, nameof(datafileFromContent), required: false);
            WorkflowExpression.Validate(datafileFromContentName, nameof(datafileFromContentName), required: false);
            WorkflowExpression.Validate(datafileFromUrl, nameof(datafileFromUrl), required: false);
            WorkflowExpression.Validate(datafromEmail, nameof(datafromEmail), required: false);
            WorkflowExpression.Validate(datafromEmailName, nameof(datafromEmailName), required: false);
            WorkflowExpression.Validate(datafrontendId, nameof(datafrontendId), required: false);
            WorkflowExpression.Validate(dataisBeingPrepared, nameof(dataisBeingPrepared), required: false);
            WorkflowExpression.Validate(datamessage, nameof(datamessage), required: false);
            WorkflowExpression.Validate(dataname, nameof(dataname), required: false);
            WorkflowExpression.Validate(dataprefillTags, nameof(dataprefillTags), required: false);
            WorkflowExpression.Validate(dataprepareUrl, nameof(dataprepareUrl), required: false);
            WorkflowExpression.Validate(dataredirectUrl, nameof(dataredirectUrl), required: false);
            WorkflowExpression.Validate(dataredirectUrlDeclined, nameof(dataredirectUrlDeclined), required: false);
            WorkflowExpression.Validate(datarequiredAttachments, nameof(datarequiredAttachments), required: false);
            WorkflowExpression.Validate(datasendReminders, nameof(datasendReminders), required: false);
            WorkflowExpression.Validate(datasubdomain, nameof(datasubdomain), required: false);
            WorkflowExpression.Validate(datasubject, nameof(datasubject), required: false);
            WorkflowExpression.Validate(datatemplate, nameof(datatemplate), required: false);
            WorkflowExpression.Validate(datatextMessageVerificationLocked, nameof(datatextMessageVerificationLocked), required: false);
            WorkflowExpression.Validate(dataurl, nameof(dataurl), required: false);
            WorkflowExpression.Validate(datauuid, nameof(datauuid), required: false);
            WorkflowExpression.Validate(datawho, nameof(datawho), required: false);
            return new DeferredBodyAction<SignRequestQuickCreate>(() =>
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
                    if (datawho != null)
                    {
                        data["who"] = ExpressionConverter.ConvertO(datawho);
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
            });
        }
    }

    public class SignrequestTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildWebhooksCreate))]
        public IBodyWorkflowTrigger<WebhookSubscription> WebhooksCreate([WorkflowExpression] Func<dataeventTypeInput> dataeventType,[WorkflowExpression] Func<string> datacreated = null,[WorkflowExpression] Func<string> dataname = null,[WorkflowExpression] Func<string> datasubdomain = null,[WorkflowExpression] Func<string> datateamname = null,[WorkflowExpression] Func<string> datateamsubdomain = null,[WorkflowExpression] Func<string> datateamurl = null,[WorkflowExpression] Func<string> dataurl = null,[WorkflowExpression] Func<string> datauuid = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebhookSubscription> __BuildWebhooksCreate(WorkflowExpression<dataeventTypeInput> dataeventType,WorkflowExpression<string> datacreated = null,WorkflowExpression<string> dataname = null,WorkflowExpression<string> datasubdomain = null,WorkflowExpression<string> datateamname = null,WorkflowExpression<string> datateamsubdomain = null,WorkflowExpression<string> datateamurl = null,WorkflowExpression<string> dataurl = null,WorkflowExpression<string> datauuid = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(dataeventType, nameof(dataeventType), required: true);
            WorkflowExpression.Validate(datacreated, nameof(datacreated), required: false);
            WorkflowExpression.Validate(dataname, nameof(dataname), required: false);
            WorkflowExpression.Validate(datasubdomain, nameof(datasubdomain), required: false);
            WorkflowExpression.Validate(datateamname, nameof(datateamname), required: false);
            WorkflowExpression.Validate(datateamsubdomain, nameof(datateamsubdomain), required: false);
            WorkflowExpression.Validate(datateamurl, nameof(datateamurl), required: false);
            WorkflowExpression.Validate(dataurl, nameof(dataurl), required: false);
            WorkflowExpression.Validate(datauuid, nameof(datauuid), required: false);
            return new DeferredBodyTrigger<WebhookSubscription>(() =>
            {
                var apiCallPath = "/webhooks/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var data = new JObject();
                var datapropCount = 0;
                data["callback_url"] = "#{listCallbackUrl()}";
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