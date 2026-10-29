//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Junglemail365
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Junglemail365Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JsEmailsResponse, ApiConnectionActionConfiguration> EmailsGet(Expression<Func<string>> requestJobId, Expression<Func<requestEmailTypeInput>> requestEmailType)
        {
            var __workflow_requestJobId = WorkflowExpression.Compile(requestJobId, nameof(requestJobId), required: true);
            var __workflow_requestEmailType = WorkflowExpression.Compile(requestEmailType, nameof(requestEmailType), required: true);
            return new DeferredBodyAction<JsEmailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1.0/emails";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["request.jobId"] = ExpressionConverter.Convert(__workflow_requestJobId);
                callPayload.Queries["request.emailType"] = ExpressionConverter.Convert(__workflow_requestEmailType);
                return new ApiConnectionAction<JsEmailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> JobApprove(Expression<Func<JobApproveInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1.0/job/approve";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JsCreateJobResponse, ApiConnectionActionConfiguration> JobCreate(Expression<Func<JobCreateInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<JsCreateJobResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1.0/job/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<JsCreateJobResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JsJob, ApiConnectionActionConfiguration> JobGet(Expression<Func<string>> requestJobId)
        {
            var __workflow_requestJobId = WorkflowExpression.Compile(requestJobId, nameof(requestJobId), required: true);
            return new DeferredBodyAction<JsJob, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1.0/job/get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["request.jobId"] = ExpressionConverter.Convert(__workflow_requestJobId);
                return new ApiConnectionAction<JsJob>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JsJobsResponse, ApiConnectionActionConfiguration> JobGetAll(Expression<Func<string>> requestDateFrom = null, Expression<Func<string>> requestDateTo = null, Expression<Func<int>> requestLimit = null)
        {
            var __workflow_requestDateFrom = WorkflowExpression.Compile(requestDateFrom, nameof(requestDateFrom), required: false);
            var __workflow_requestDateTo = WorkflowExpression.Compile(requestDateTo, nameof(requestDateTo), required: false);
            var __workflow_requestLimit = WorkflowExpression.Compile(requestLimit, nameof(requestLimit), required: false);
            return new DeferredBodyAction<JsJobsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1.0/job/getlist";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_requestDateFrom != null)
                    callPayload.Queries["request.dateFrom"] = ExpressionConverter.Convert(__workflow_requestDateFrom);
                if (__workflow_requestDateTo != null)
                    callPayload.Queries["request.dateTo"] = ExpressionConverter.Convert(__workflow_requestDateTo);
                if (__workflow_requestLimit != null)
                    callPayload.Queries["request.limit"] = ExpressionConverter.Convert(__workflow_requestLimit);
                return new ApiConnectionAction<JsJobsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JsJobReport, ApiConnectionActionConfiguration> JobGetReport(Expression<Func<string>> requestJobId)
        {
            var __workflow_requestJobId = WorkflowExpression.Compile(requestJobId, nameof(requestJobId), required: true);
            return new DeferredBodyAction<JsJobReport, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1.0/job/getreport";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["request.jobId"] = ExpressionConverter.Convert(__workflow_requestJobId);
                return new ApiConnectionAction<JsJobReport>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> JobReject(Expression<Func<JobRejectInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1.0/job/reject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JsTrackerLogResponse, ApiConnectionActionConfiguration> TrackerLogGet(Expression<Func<string>> requestJobId, Expression<Func<requestDataTypeInput>> requestDataType)
        {
            var __workflow_requestJobId = WorkflowExpression.Compile(requestJobId, nameof(requestJobId), required: true);
            var __workflow_requestDataType = WorkflowExpression.Compile(requestDataType, nameof(requestDataType), required: true);
            return new DeferredBodyAction<JsTrackerLogResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1.0/trackerlog";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["request.jobId"] = ExpressionConverter.Convert(__workflow_requestJobId);
                callPayload.Queries["request.dataType"] = ExpressionConverter.Convert(__workflow_requestDataType);
                return new ApiConnectionAction<JsTrackerLogResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JsUnsubscribesResponse, ApiConnectionActionConfiguration> UnsubscribesGet(Expression<Func<string>> requestJobId = null)
        {
            var __workflow_requestJobId = WorkflowExpression.Compile(requestJobId, nameof(requestJobId), required: false);
            return new DeferredBodyAction<JsUnsubscribesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1.0/unsubscribes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_requestJobId != null)
                    callPayload.Queries["request.jobId"] = ExpressionConverter.Convert(__workflow_requestJobId);
                return new ApiConnectionAction<JsUnsubscribesResponse>(callPayload);
            });
        }
    }

    public class Junglemail365Triggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JsWebhookCreatedResponse, ApiConnectionTriggerConfiguration> WebhookJobCompleted(Expression<Func<WebhookJobCompletedInput>> request, FlowRecurrence recurrence = null)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyTrigger<JsWebhookCreatedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/1.0/registerwebhookjobcompleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionTrigger<JsWebhookCreatedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JsWebhookCreatedResponse, ApiConnectionTriggerConfiguration> WebhookJobStarted(Expression<Func<WebhookJobStartedInput>> request, FlowRecurrence recurrence = null)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyTrigger<JsWebhookCreatedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/1.0/registerwebhookjobstarted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionTrigger<JsWebhookCreatedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JsWebhookCreatedResponse, ApiConnectionTriggerConfiguration> WebhookJobSumitted(Expression<Func<WebhookJobSumittedInput>> request, FlowRecurrence recurrence = null)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyTrigger<JsWebhookCreatedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/1.0/registerwebhookjobsubmitted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionTrigger<JsWebhookCreatedResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class JsEmailsResponse
    {
        [JsonProperty("emails")]
        public JsEmail[] Emails { get; set; }
    }

    public class JsEmail
    {
        [JsonProperty("recipientAddress")]
        public string RecipientEmail { get; set; }

        [JsonProperty("recipientId")]
        public string RecipientId { get; set; }

        [JsonProperty("recipientItemId")]
        public int RecipientItemId { get; set; }

        [JsonProperty("recipientName")]
        public string RecipientName { get; set; }

        [JsonProperty("recipientSource")]
        public string RecipientSource { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum requestEmailTypeInput
    {
        Sent,
        Skipped,
        Failed,
        Completed
    }

    public class JobApproveInput
    {
        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("secret", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Secret { get; set; }
    }

    public class JsCreateJobResponse
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class JobCreateInput
    {
        [JsonProperty("adGroups")]
        public string Office365Groups { get; set; }

        [JsonProperty("attachmentContent")]
        public string AttachmentContent { get; set; }

        [JsonProperty("attachmentName")]
        public string AttachmentName { get; set; }

        [JsonProperty("emailAddresses")]
        public string EmailAddresses { get; set; }

        [JsonProperty("emailBody")]
        public string EmailContent { get; set; }

        [JsonProperty("emailContentType", DefaultValueHandling = DefaultValueHandling.Include)]
        public JobCreateInputEmailContentTypeType? EmailContentType { get; set; } = JobCreateInputEmailContentTypeType.Template;

        [JsonProperty("emailSubject")]
        public string EmailSubject { get; set; }

        [JsonProperty("exchangeGroups")]
        public string ExchangeGroups { get; set; }

        [JsonProperty("jobExecutionType", DefaultValueHandling = DefaultValueHandling.Include)]
        public JobCreateInputWhenToSendTypeType? WhenToSendType { get; set; } = JobCreateInputWhenToSendTypeType.Now;

        [JsonProperty("jobScheduleTime")]
        public string WhenToSend { get; set; }

        [JsonProperty("recipientListField")]
        public string RecipientEmailField { get; set; }

        [JsonProperty("recipientListUrl")]
        public string RecipientListURL { get; set; }

        [JsonProperty("recipientListView")]
        public string RecipientFilterView { get; set; }

        [JsonProperty("recipientType", DefaultValueHandling = DefaultValueHandling.Include)]
        public JobCreateInputRecipientSourceType RecipientSource { get; set; } = JobCreateInputRecipientSourceType.Emails;

        [JsonProperty("removeDuplicates", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveDuplicates { get; set; } = true;

        [JsonProperty("reportAuthor", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SendReport { get; set; } = true;

        [JsonProperty("scheduledTimeZoneId")]
        public string TimeZone { get; set; }

        [JsonProperty("sendingAddressId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SendingAccount { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NewsletterTitle { get; set; }

        [JsonProperty("trackClicks", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TrackClicks { get; set; } = true;

        [JsonProperty("trackOpens", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TrackOpens { get; set; } = true;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JobCreateInputEmailContentTypeType
    {
        Template,
        Html
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JobCreateInputWhenToSendTypeType
    {
        Now,
        AtSpecifiedTime
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JobCreateInputRecipientSourceType
    {
        Emails,
        List,
        Office365Groups,
        ExchangeGroups
    }

    public class JsJob
    {
        [JsonProperty("createdByEmail")]
        public string CreatedByEmail { get; set; }

        [JsonProperty("createdById")]
        public int CreatedById { get; set; }

        [JsonProperty("createdByTitle")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdTime")]
        public string CreatedTime { get; set; }

        [JsonProperty("displayName")]
        public string NewsletterDisplayName { get; set; }

        [JsonProperty("emailSubject")]
        public string EmailSubject { get; set; }

        [JsonProperty("emailbody")]
        public string EmailHTML { get; set; }

        [JsonProperty("id")]
        public string NewsletterId { get; set; }

        [JsonProperty("isRecurrent")]
        public bool IsRecurrent { get; set; }

        [JsonProperty("isScheduled")]
        public bool IsScheduled { get; set; }

        [JsonProperty("modifiedByEmail")]
        public string ModifiedByEmail { get; set; }

        [JsonProperty("modifiedById")]
        public int ModifiedById { get; set; }

        [JsonProperty("modifiedByTitle")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedTime")]
        public string ModifiedTime { get; set; }

        [JsonProperty("previewUrl")]
        public string PreviewURL { get; set; }

        [JsonProperty("scheduledTime")]
        public string ScheduledTime { get; set; }

        [JsonProperty("sendFailedCount")]
        public int SendFailedCount { get; set; }

        [JsonProperty("sendPercentFormatted")]
        public string SendPercent { get; set; }

        [JsonProperty("sendSkippedCount")]
        public int SendSkippedCount { get; set; }

        [JsonProperty("sendSucceededCount")]
        public int SendSucceededCount { get; set; }

        [JsonProperty("sendTime")]
        public string SendTime { get; set; }

        [JsonProperty("sendTotal")]
        public int SendTotal { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("submittedByEmail")]
        public string SubmittedByEmail { get; set; }

        [JsonProperty("submittedById")]
        public int SubmittedById { get; set; }

        [JsonProperty("submittedByTitle")]
        public string SubmittedBy { get; set; }

        [JsonProperty("submittedTime")]
        public string SubmittedTime { get; set; }

        [JsonProperty("title")]
        public string NewsletterTitle { get; set; }

        [JsonProperty("totalRecipients")]
        public int TotalRecipients { get; set; }
    }

    public class JsJobsResponse
    {
        [JsonProperty("jobs")]
        public JsJobInfo[] Newsletters { get; set; }
    }

    public class JsJobInfo
    {
        [JsonProperty("jobId")]
        public string NewsletterId { get; set; }
    }

    public class JsJobReport
    {
        [JsonProperty("bounces")]
        public int Bounces { get; set; }

        [JsonProperty("bouncesRateFormatted")]
        public string BouncesRate { get; set; }

        [JsonProperty("devicesDesktopCount")]
        public int DevicesDesktop { get; set; }

        [JsonProperty("devicesDesktopRateFormatted")]
        public string DevicesDesktopRate { get; set; }

        [JsonProperty("devicesOtherCount")]
        public int DevicesOther { get; set; }

        [JsonProperty("devicesPhoneCount")]
        public int DevicesPhone { get; set; }

        [JsonProperty("devicesPhoneRateFormatted")]
        public string DevicesPhoneRate { get; set; }

        [JsonProperty("devicesTabletCount")]
        public int DevicesTablet { get; set; }

        [JsonProperty("devicesTabletRateFormatted")]
        public string DevicesTabletRate { get; set; }

        [JsonProperty("emailOpensRateFormatted")]
        public string EmailOpensRate { get; set; }

        [JsonProperty("emailOpensTotal")]
        public int TotalEmailOpens { get; set; }

        [JsonProperty("emailOpensUnique")]
        public int UniqueEmailOpens { get; set; }

        [JsonProperty("emailSubject")]
        public string EmailSubject { get; set; }

        [JsonProperty("emailsFailed")]
        public int EmailsFailed { get; set; }

        [JsonProperty("emailsSent")]
        public int TotalEmailsSent { get; set; }

        [JsonProperty("emailsSkipped")]
        public int EmailsSkipped { get; set; }

        [JsonProperty("emailsTotal")]
        public int TotalEmails { get; set; }

        [JsonProperty("emailsUnopened")]
        public int EmailsUnopened { get; set; }

        [JsonProperty("jobDisplayName")]
        public string NewsletterDisplayName { get; set; }

        [JsonProperty("jobTitle")]
        public string NewsletterTitle { get; set; }

        [JsonProperty("linkClicksRateFormatted")]
        public string LinkClicksRate { get; set; }

        [JsonProperty("linkClicksTotal")]
        public int TotalLinkClicks { get; set; }

        [JsonProperty("linkClicksUnique")]
        public int UniqueLinkClicks { get; set; }

        [JsonProperty("linksNotClicked")]
        public int LinksNotClicked { get; set; }

        [JsonProperty("reportHtml")]
        public string ReportInHTML { get; set; }

        [JsonProperty("sendTime")]
        public string SendTime { get; set; }

        [JsonProperty("submittedBy")]
        public string SubmittedBy { get; set; }

        [JsonProperty("submittedByEmail")]
        public string SubmittedByEmail { get; set; }

        [JsonProperty("submittedById")]
        public string SubmittedById { get; set; }

        [JsonProperty("topLinks")]
        public JsTopLink[] TopLinks { get; set; }

        [JsonProperty("unsubscribes")]
        public int TotalUnsubscribes { get; set; }

        [JsonProperty("unsubscribesRateFormatted")]
        public string UnsubscribesRate { get; set; }
    }

    public class JsTopLink
    {
        [JsonProperty("linkClicksTotal")]
        public string TotalLinkClicks { get; set; }

        [JsonProperty("linkClicksUnique")]
        public string UniqueLinkClicks { get; set; }

        [JsonProperty("linkIndex")]
        public int Index { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }
    }

    public class JobRejectInput
    {
        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("secret", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Secret { get; set; }
    }

    public class JsTrackerLogResponse
    {
        [JsonProperty("trackerLog")]
        public JsTrackerLogRow[] TrackerLog { get; set; }
    }

    public class JsTrackerLogRow
    {
        [JsonProperty("bounceDescription")]
        public string BounceDescription { get; set; }

        [JsonProperty("bounceReason")]
        public string BounceReason { get; set; }

        [JsonProperty("bounceType")]
        public int BounceType { get; set; }

        [JsonProperty("bouncedOn")]
        public string BouncedTime { get; set; }

        [JsonProperty("clickCount")]
        public int ClicksCount { get; set; }

        [JsonProperty("clickedOn")]
        public string ClickedTime { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstTimeClickedOn")]
        public string FirstClickTime { get; set; }

        [JsonProperty("firstTimeOpenedOn")]
        public string FirstOpenTime { get; set; }

        [JsonProperty("ipAddress")]
        public string IPAddress { get; set; }

        [JsonProperty("linkUrl")]
        public string LinkURL { get; set; }

        [JsonProperty("openCount")]
        public int OpenCount { get; set; }

        [JsonProperty("openedOn")]
        public string OpenedTime { get; set; }

        [JsonProperty("unsubscribedOn")]
        public string UnsubscribedTime { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum requestDataTypeInput
    {
        OpensUnique,
        OpensTotal,
        OpensUnopened,
        ClicksUnique,
        ClicksTotal,
        ClicksNotClicked,
        Unsubscribes,
        Bounces,
        FailedEmails,
        SkippedEmails
    }

    public class JsUnsubscribesResponse
    {
        [JsonProperty("unsubscribes")]
        public JsUnsubscribe[] Unsubscribes { get; set; }
    }

    public class JsUnsubscribe
    {
        [JsonProperty("recipientAddress")]
        public string RecipientEmail { get; set; }

        [JsonProperty("recipientId")]
        public string RecipientId { get; set; }

        [JsonProperty("recipientItemId")]
        public int RecipientItemId { get; set; }

        [JsonProperty("recipientName")]
        public string RecipientName { get; set; }

        [JsonProperty("recipientSource")]
        public string RecipientSource { get; set; }

        [JsonProperty("unsubscribeTime")]
        public string UnsubscribeTime { get; set; }
    }

    public class JsWebhookCreatedResponse
    {
        [JsonProperty("succeeded")]
        public bool Succeeded { get; set; }

        [JsonProperty("webhookId")]
        public string WebhookId { get; set; }
    }

    public class WebhookJobCompletedInput
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("triggerUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TriggerUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class WebhookJobStartedInput
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("triggerUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TriggerUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class WebhookJobSumittedInput
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("triggerUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TriggerUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Junglemail365;

    public partial class WorkflowManagedActions
    {
        public Junglemail365Actions Junglemail365(string connectionId) => new Junglemail365Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Junglemail365Triggers Junglemail365(string connectionId) => new Junglemail365Triggers(connectionId);
    }
}