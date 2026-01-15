//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Junglemail365
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Junglemail365Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JsEmailsResponse> EmailsGet(Expression<Func<string>> requestJobId, Expression<Func<requestEmailTypeInput>> requestEmailType)
        {
            var apiCallPath = "/1.0/emails";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["request.jobId"] = ExpressionConverter.Convert(requestJobId);
            callPayload.Queries["request.emailType"] = ExpressionConverter.Convert(requestEmailType);
            return new ApiConnectionAction<JsEmailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JToken> JobApprove(Expression<Func<string>> requestsecret, Expression<Func<string>> requestcomments = null)
        {
            var apiCallPath = "/1.0/job/approve";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestcomments != null)
            {
                request["comments"] = ExpressionConverter.ConvertO(requestcomments);
                requestpropCount++;
            }

            requestpropCount++;
            request["secret"] = ExpressionConverter.ConvertO(requestsecret);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JsCreateJobResponse> JobCreate(Expression<Func<requestrecipientSourceInput>> requestrecipientSource, Expression<Func<string>> requestsendingAccount, Expression<Func<string>> requestnewsletterTitle, Expression<Func<string>> requestoffice365Groups = null, Expression<Func<string>> requestattachmentContent = null, Expression<Func<string>> requestattachmentName = null, Expression<Func<string>> requestemailAddresses = null, Expression<Func<string>> requestemailContent = null, Expression<Func<requestemailContentTypeInput>> requestemailContentType = null, Expression<Func<string>> requestemailSubject = null, Expression<Func<string>> requestexchangeGroups = null, Expression<Func<requestwhenToSendTypeInput>> requestwhenToSendType = null, Expression<Func<string>> requestwhenToSend = null, Expression<Func<string>> requestrecipientEmailField = null, Expression<Func<string>> requestrecipientListURL = null, Expression<Func<string>> requestrecipientFilterView = null, Expression<Func<bool>> requestremoveDuplicates = null, Expression<Func<bool>> requestsendReport = null, Expression<Func<string>> requesttimeZone = null, Expression<Func<string>> requesttemplate = null, Expression<Func<bool>> requesttrackClicks = null, Expression<Func<bool>> requesttrackOpens = null)
        {
            var apiCallPath = "/1.0/job/create";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestoffice365Groups != null)
            {
                request["adGroups"] = ExpressionConverter.ConvertO(requestoffice365Groups);
                requestpropCount++;
            }

            if (requestattachmentContent != null)
            {
                request["attachmentContent"] = ExpressionConverter.ConvertO(requestattachmentContent);
                requestpropCount++;
            }

            if (requestattachmentName != null)
            {
                request["attachmentName"] = ExpressionConverter.ConvertO(requestattachmentName);
                requestpropCount++;
            }

            if (requestemailAddresses != null)
            {
                request["emailAddresses"] = ExpressionConverter.ConvertO(requestemailAddresses);
                requestpropCount++;
            }

            if (requestemailContent != null)
            {
                request["emailBody"] = ExpressionConverter.ConvertO(requestemailContent);
                requestpropCount++;
            }

            if (requestemailContentType != null)
            {
                request["emailContentType"] = ExpressionConverter.ConvertO(requestemailContentType);
                requestpropCount++;
            }

            if (requestemailSubject != null)
            {
                request["emailSubject"] = ExpressionConverter.ConvertO(requestemailSubject);
                requestpropCount++;
            }

            if (requestexchangeGroups != null)
            {
                request["exchangeGroups"] = ExpressionConverter.ConvertO(requestexchangeGroups);
                requestpropCount++;
            }

            if (requestwhenToSendType != null)
            {
                request["jobExecutionType"] = ExpressionConverter.ConvertO(requestwhenToSendType);
                requestpropCount++;
            }

            if (requestwhenToSend != null)
            {
                request["jobScheduleTime"] = ExpressionConverter.ConvertO(requestwhenToSend);
                requestpropCount++;
            }

            if (requestrecipientEmailField != null)
            {
                request["recipientListField"] = ExpressionConverter.ConvertO(requestrecipientEmailField);
                requestpropCount++;
            }

            if (requestrecipientListURL != null)
            {
                request["recipientListUrl"] = ExpressionConverter.ConvertO(requestrecipientListURL);
                requestpropCount++;
            }

            if (requestrecipientFilterView != null)
            {
                request["recipientListView"] = ExpressionConverter.ConvertO(requestrecipientFilterView);
                requestpropCount++;
            }

            requestpropCount++;
            request["recipientType"] = ExpressionConverter.ConvertO(requestrecipientSource);
            if (requestremoveDuplicates != null)
            {
                request["removeDuplicates"] = ExpressionConverter.ConvertO(requestremoveDuplicates);
                requestpropCount++;
            }

            if (requestsendReport != null)
            {
                request["reportAuthor"] = ExpressionConverter.ConvertO(requestsendReport);
                requestpropCount++;
            }

            if (requesttimeZone != null)
            {
                request["scheduledTimeZoneId"] = ExpressionConverter.ConvertO(requesttimeZone);
                requestpropCount++;
            }

            requestpropCount++;
            request["sendingAddressId"] = ExpressionConverter.ConvertO(requestsendingAccount);
            if (requesttemplate != null)
            {
                request["template"] = ExpressionConverter.ConvertO(requesttemplate);
                requestpropCount++;
            }

            requestpropCount++;
            request["title"] = ExpressionConverter.ConvertO(requestnewsletterTitle);
            if (requesttrackClicks != null)
            {
                request["trackClicks"] = ExpressionConverter.ConvertO(requesttrackClicks);
                requestpropCount++;
            }

            if (requesttrackOpens != null)
            {
                request["trackOpens"] = ExpressionConverter.ConvertO(requesttrackOpens);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<JsCreateJobResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JsJob> JobGet(Expression<Func<string>> requestJobId)
        {
            var apiCallPath = "/1.0/job/get";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["request.jobId"] = ExpressionConverter.Convert(requestJobId);
            return new ApiConnectionAction<JsJob>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JsJobsResponse> JobGetAll(Expression<Func<string>> requestDateFrom = null, Expression<Func<string>> requestDateTo = null, Expression<Func<int>> requestLimit = null)
        {
            var apiCallPath = "/1.0/job/getlist";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (requestDateFrom != null)
                callPayload.Queries["request.dateFrom"] = ExpressionConverter.Convert(requestDateFrom);
            if (requestDateTo != null)
                callPayload.Queries["request.dateTo"] = ExpressionConverter.Convert(requestDateTo);
            if (requestLimit != null)
                callPayload.Queries["request.limit"] = ExpressionConverter.Convert(requestLimit);
            return new ApiConnectionAction<JsJobsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JsJobReport> JobGetReport(Expression<Func<string>> requestJobId)
        {
            var apiCallPath = "/1.0/job/getreport";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["request.jobId"] = ExpressionConverter.Convert(requestJobId);
            return new ApiConnectionAction<JsJobReport>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JToken> JobReject(Expression<Func<string>> requestsecret, Expression<Func<string>> requestcomments = null)
        {
            var apiCallPath = "/1.0/job/reject";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestcomments != null)
            {
                request["comments"] = ExpressionConverter.ConvertO(requestcomments);
                requestpropCount++;
            }

            requestpropCount++;
            request["secret"] = ExpressionConverter.ConvertO(requestsecret);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JsTrackerLogResponse> TrackerLogGet(Expression<Func<string>> requestJobId, Expression<Func<requestDataTypeInput>> requestDataType)
        {
            var apiCallPath = "/1.0/trackerlog";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["request.jobId"] = ExpressionConverter.Convert(requestJobId);
            callPayload.Queries["request.dataType"] = ExpressionConverter.Convert(requestDataType);
            return new ApiConnectionAction<JsTrackerLogResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JsUnsubscribesResponse> UnsubscribesGet(Expression<Func<string>> requestJobId = null)
        {
            var apiCallPath = "/1.0/unsubscribes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (requestJobId != null)
                callPayload.Queries["request.jobId"] = ExpressionConverter.Convert(requestJobId);
            return new ApiConnectionAction<JsUnsubscribesResponse>(callPayload);
        }
    }

    public class Junglemail365Triggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<JsWebhookCreatedResponse> WebhookJobCompleted(Expression<Func<string>> requesttitle)
        {
            var apiCallPath = "/1.0/registerwebhookjobcompleted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["title"] = ExpressionConverter.ConvertO(requesttitle);
            request["triggerUrl"] = "@listcallbackurl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger<JsWebhookCreatedResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<JsWebhookCreatedResponse> WebhookJobStarted(Expression<Func<string>> requesttitle)
        {
            var apiCallPath = "/1.0/registerwebhookjobstarted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["title"] = ExpressionConverter.ConvertO(requesttitle);
            request["triggerUrl"] = "@listcallbackurl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger<JsWebhookCreatedResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<JsWebhookCreatedResponse> WebhookJobSumitted(Expression<Func<string>> requesttitle)
        {
            var apiCallPath = "/1.0/registerwebhookjobsubmitted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["title"] = ExpressionConverter.ConvertO(requesttitle);
            request["triggerUrl"] = "@listcallbackurl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger<JsWebhookCreatedResponse>(callPayload);
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

    public enum requestEmailTypeInput
    {
        Sent,
        Skipped,
        Failed,
        Completed
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

    public enum requestrecipientSourceInput
    {
        Emails,
        List,
        Office365Groups,
        ExchangeGroups
    }

    public enum requestemailContentTypeInput
    {
        Template,
        Html
    }

    public enum requestwhenToSendTypeInput
    {
        Now,
        AtSpecifiedTime
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
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Junglemail365;

    public partial class WorkflowManagedActions
    {
        public Junglemail365Actions Junglemail365(string connectionId) => new Junglemail365Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Junglemail365Triggers Junglemail365(string connectionId) => new Junglemail365Triggers(connectionId);
    }
}