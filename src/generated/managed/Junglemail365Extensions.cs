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
        public IBodyWorkflowAction<JsEmailsResponse> EmailsGet(Expression<Func<string>> requestJobId, Expression<Func<requestEmailTypeInput>> requestEmailType)
        {
            var __workflow_requestJobId = WorkflowExpression.Compile(requestJobId, nameof(requestJobId), required: true);
            var __workflow_requestEmailType = WorkflowExpression.Compile(requestEmailType, nameof(requestEmailType), required: true);
            return new DeferredBodyAction<JsEmailsResponse>(() =>
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
        public IBodyWorkflowAction<JToken> JobApprove(Expression<Func<string>> requestsecret, Expression<Func<string>> requestcomments = null)
        {
            var __workflow_requestsecret = WorkflowExpression.Compile(requestsecret, nameof(requestsecret), required: true);
            var __workflow_requestcomments = WorkflowExpression.Compile(requestcomments, nameof(requestcomments), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/1.0/job/approve";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestcomments != null)
                {
                    request["comments"] = ExpressionConverter.ConvertO(__workflow_requestcomments);
                    requestpropCount++;
                }

                requestpropCount++;
                request["secret"] = ExpressionConverter.ConvertO(__workflow_requestsecret);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JsCreateJobResponse> JobCreate(Expression<Func<requestrecipientSourceInput>> requestrecipientSource, Expression<Func<string>> requestsendingAccount, Expression<Func<string>> requestnewsletterTitle, Expression<Func<string>> requestoffice365Groups = null, Expression<Func<string>> requestattachmentContent = null, Expression<Func<string>> requestattachmentName = null, Expression<Func<string>> requestemailAddresses = null, Expression<Func<string>> requestemailContent = null, Expression<Func<requestemailContentTypeInput>> requestemailContentType = null, Expression<Func<string>> requestemailSubject = null, Expression<Func<string>> requestexchangeGroups = null, Expression<Func<requestwhenToSendTypeInput>> requestwhenToSendType = null, Expression<Func<string>> requestwhenToSend = null, Expression<Func<string>> requestrecipientEmailField = null, Expression<Func<string>> requestrecipientListURL = null, Expression<Func<string>> requestrecipientFilterView = null, Expression<Func<bool>> requestremoveDuplicates = null, Expression<Func<bool>> requestsendReport = null, Expression<Func<string>> requesttimeZone = null, Expression<Func<string>> requesttemplate = null, Expression<Func<bool>> requesttrackClicks = null, Expression<Func<bool>> requesttrackOpens = null)
        {
            var __workflow_requestrecipientSource = WorkflowExpression.Compile(requestrecipientSource, nameof(requestrecipientSource), required: true);
            var __workflow_requestsendingAccount = WorkflowExpression.Compile(requestsendingAccount, nameof(requestsendingAccount), required: true);
            var __workflow_requestnewsletterTitle = WorkflowExpression.Compile(requestnewsletterTitle, nameof(requestnewsletterTitle), required: true);
            var __workflow_requestoffice365Groups = WorkflowExpression.Compile(requestoffice365Groups, nameof(requestoffice365Groups), required: false);
            var __workflow_requestattachmentContent = WorkflowExpression.Compile(requestattachmentContent, nameof(requestattachmentContent), required: false);
            var __workflow_requestattachmentName = WorkflowExpression.Compile(requestattachmentName, nameof(requestattachmentName), required: false);
            var __workflow_requestemailAddresses = WorkflowExpression.Compile(requestemailAddresses, nameof(requestemailAddresses), required: false);
            var __workflow_requestemailContent = WorkflowExpression.Compile(requestemailContent, nameof(requestemailContent), required: false);
            var __workflow_requestemailContentType = WorkflowExpression.Compile(requestemailContentType, nameof(requestemailContentType), required: false);
            var __workflow_requestemailSubject = WorkflowExpression.Compile(requestemailSubject, nameof(requestemailSubject), required: false);
            var __workflow_requestexchangeGroups = WorkflowExpression.Compile(requestexchangeGroups, nameof(requestexchangeGroups), required: false);
            var __workflow_requestwhenToSendType = WorkflowExpression.Compile(requestwhenToSendType, nameof(requestwhenToSendType), required: false);
            var __workflow_requestwhenToSend = WorkflowExpression.Compile(requestwhenToSend, nameof(requestwhenToSend), required: false);
            var __workflow_requestrecipientEmailField = WorkflowExpression.Compile(requestrecipientEmailField, nameof(requestrecipientEmailField), required: false);
            var __workflow_requestrecipientListURL = WorkflowExpression.Compile(requestrecipientListURL, nameof(requestrecipientListURL), required: false);
            var __workflow_requestrecipientFilterView = WorkflowExpression.Compile(requestrecipientFilterView, nameof(requestrecipientFilterView), required: false);
            var __workflow_requestremoveDuplicates = WorkflowExpression.Compile(requestremoveDuplicates, nameof(requestremoveDuplicates), required: false);
            var __workflow_requestsendReport = WorkflowExpression.Compile(requestsendReport, nameof(requestsendReport), required: false);
            var __workflow_requesttimeZone = WorkflowExpression.Compile(requesttimeZone, nameof(requesttimeZone), required: false);
            var __workflow_requesttemplate = WorkflowExpression.Compile(requesttemplate, nameof(requesttemplate), required: false);
            var __workflow_requesttrackClicks = WorkflowExpression.Compile(requesttrackClicks, nameof(requesttrackClicks), required: false);
            var __workflow_requesttrackOpens = WorkflowExpression.Compile(requesttrackOpens, nameof(requesttrackOpens), required: false);
            return new DeferredBodyAction<JsCreateJobResponse>(() =>
            {
                var apiCallPath = "/1.0/job/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestoffice365Groups != null)
                {
                    request["adGroups"] = ExpressionConverter.ConvertO(__workflow_requestoffice365Groups);
                    requestpropCount++;
                }

                if (__workflow_requestattachmentContent != null)
                {
                    request["attachmentContent"] = ExpressionConverter.ConvertO(__workflow_requestattachmentContent);
                    requestpropCount++;
                }

                if (__workflow_requestattachmentName != null)
                {
                    request["attachmentName"] = ExpressionConverter.ConvertO(__workflow_requestattachmentName);
                    requestpropCount++;
                }

                if (__workflow_requestemailAddresses != null)
                {
                    request["emailAddresses"] = ExpressionConverter.ConvertO(__workflow_requestemailAddresses);
                    requestpropCount++;
                }

                if (__workflow_requestemailContent != null)
                {
                    request["emailBody"] = ExpressionConverter.ConvertO(__workflow_requestemailContent);
                    requestpropCount++;
                }

                if (__workflow_requestemailContentType != null)
                {
                    if (__workflow_requestemailContentType != null)
                    {
                        request["emailContentType"] = ExpressionConverter.ConvertO(__workflow_requestemailContentType);
                        requestpropCount++;
                    }

                    requestpropCount++;
                }
                else
                {
                    request["emailContentType"] = "Template";
                    requestpropCount++;
                }

                if (__workflow_requestemailSubject != null)
                {
                    request["emailSubject"] = ExpressionConverter.ConvertO(__workflow_requestemailSubject);
                    requestpropCount++;
                }

                if (__workflow_requestexchangeGroups != null)
                {
                    request["exchangeGroups"] = ExpressionConverter.ConvertO(__workflow_requestexchangeGroups);
                    requestpropCount++;
                }

                if (__workflow_requestwhenToSendType != null)
                {
                    if (__workflow_requestwhenToSendType != null)
                    {
                        request["jobExecutionType"] = ExpressionConverter.ConvertO(__workflow_requestwhenToSendType);
                        requestpropCount++;
                    }

                    requestpropCount++;
                }
                else
                {
                    request["jobExecutionType"] = "Now";
                    requestpropCount++;
                }

                if (__workflow_requestwhenToSend != null)
                {
                    request["jobScheduleTime"] = ExpressionConverter.ConvertO(__workflow_requestwhenToSend);
                    requestpropCount++;
                }

                if (__workflow_requestrecipientEmailField != null)
                {
                    request["recipientListField"] = ExpressionConverter.ConvertO(__workflow_requestrecipientEmailField);
                    requestpropCount++;
                }

                if (__workflow_requestrecipientListURL != null)
                {
                    request["recipientListUrl"] = ExpressionConverter.ConvertO(__workflow_requestrecipientListURL);
                    requestpropCount++;
                }

                if (__workflow_requestrecipientFilterView != null)
                {
                    request["recipientListView"] = ExpressionConverter.ConvertO(__workflow_requestrecipientFilterView);
                    requestpropCount++;
                }

                requestpropCount++;
                request["recipientType"] = ExpressionConverter.ConvertO(__workflow_requestrecipientSource);
                if (__workflow_requestremoveDuplicates != null)
                {
                    if (__workflow_requestremoveDuplicates != null)
                    {
                        request["removeDuplicates"] = ExpressionConverter.ConvertO(__workflow_requestremoveDuplicates);
                        requestpropCount++;
                    }

                    requestpropCount++;
                }
                else
                {
                    request["removeDuplicates"] = true;
                    requestpropCount++;
                }

                if (__workflow_requestsendReport != null)
                {
                    if (__workflow_requestsendReport != null)
                    {
                        request["reportAuthor"] = ExpressionConverter.ConvertO(__workflow_requestsendReport);
                        requestpropCount++;
                    }

                    requestpropCount++;
                }
                else
                {
                    request["reportAuthor"] = true;
                    requestpropCount++;
                }

                if (__workflow_requesttimeZone != null)
                {
                    request["scheduledTimeZoneId"] = ExpressionConverter.ConvertO(__workflow_requesttimeZone);
                    requestpropCount++;
                }

                requestpropCount++;
                request["sendingAddressId"] = ExpressionConverter.ConvertO(__workflow_requestsendingAccount);
                if (__workflow_requesttemplate != null)
                {
                    request["template"] = ExpressionConverter.ConvertO(__workflow_requesttemplate);
                    requestpropCount++;
                }

                requestpropCount++;
                request["title"] = ExpressionConverter.ConvertO(__workflow_requestnewsletterTitle);
                if (__workflow_requesttrackClicks != null)
                {
                    if (__workflow_requesttrackClicks != null)
                    {
                        request["trackClicks"] = ExpressionConverter.ConvertO(__workflow_requesttrackClicks);
                        requestpropCount++;
                    }

                    requestpropCount++;
                }
                else
                {
                    request["trackClicks"] = true;
                    requestpropCount++;
                }

                if (__workflow_requesttrackOpens != null)
                {
                    if (__workflow_requesttrackOpens != null)
                    {
                        request["trackOpens"] = ExpressionConverter.ConvertO(__workflow_requesttrackOpens);
                        requestpropCount++;
                    }

                    requestpropCount++;
                }
                else
                {
                    request["trackOpens"] = true;
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<JsCreateJobResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JsJob> JobGet(Expression<Func<string>> requestJobId)
        {
            var __workflow_requestJobId = WorkflowExpression.Compile(requestJobId, nameof(requestJobId), required: true);
            return new DeferredBodyAction<JsJob>(() =>
            {
                var apiCallPath = "/1.0/job/get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["request.jobId"] = ExpressionConverter.Convert(__workflow_requestJobId);
                return new ApiConnectionAction<JsJob>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JsJobsResponse> JobGetAll(Expression<Func<string>> requestDateFrom = null, Expression<Func<string>> requestDateTo = null, Expression<Func<int>> requestLimit = null)
        {
            var __workflow_requestDateFrom = WorkflowExpression.Compile(requestDateFrom, nameof(requestDateFrom), required: false);
            var __workflow_requestDateTo = WorkflowExpression.Compile(requestDateTo, nameof(requestDateTo), required: false);
            var __workflow_requestLimit = WorkflowExpression.Compile(requestLimit, nameof(requestLimit), required: false);
            return new DeferredBodyAction<JsJobsResponse>(() =>
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
        public IBodyWorkflowAction<JsJobReport> JobGetReport(Expression<Func<string>> requestJobId)
        {
            var __workflow_requestJobId = WorkflowExpression.Compile(requestJobId, nameof(requestJobId), required: true);
            return new DeferredBodyAction<JsJobReport>(() =>
            {
                var apiCallPath = "/1.0/job/getreport";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["request.jobId"] = ExpressionConverter.Convert(__workflow_requestJobId);
                return new ApiConnectionAction<JsJobReport>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JToken> JobReject(Expression<Func<string>> requestsecret, Expression<Func<string>> requestcomments = null)
        {
            var __workflow_requestsecret = WorkflowExpression.Compile(requestsecret, nameof(requestsecret), required: true);
            var __workflow_requestcomments = WorkflowExpression.Compile(requestcomments, nameof(requestcomments), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/1.0/job/reject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestcomments != null)
                {
                    request["comments"] = ExpressionConverter.ConvertO(__workflow_requestcomments);
                    requestpropCount++;
                }

                requestpropCount++;
                request["secret"] = ExpressionConverter.ConvertO(__workflow_requestsecret);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JsTrackerLogResponse> TrackerLogGet(Expression<Func<string>> requestJobId, Expression<Func<requestDataTypeInput>> requestDataType)
        {
            var __workflow_requestJobId = WorkflowExpression.Compile(requestJobId, nameof(requestJobId), required: true);
            var __workflow_requestDataType = WorkflowExpression.Compile(requestDataType, nameof(requestDataType), required: true);
            return new DeferredBodyAction<JsTrackerLogResponse>(() =>
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
        public IBodyWorkflowAction<JsUnsubscribesResponse> UnsubscribesGet(Expression<Func<string>> requestJobId = null)
        {
            var __workflow_requestJobId = WorkflowExpression.Compile(requestJobId, nameof(requestJobId), required: false);
            return new DeferredBodyAction<JsUnsubscribesResponse>(() =>
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
        public IBodyWorkflowTrigger<JsWebhookCreatedResponse> WebhookJobCompleted(Expression<Func<string>> requesttitle, FlowRecurrence recurrence = null)
        {
            var __workflow_requesttitle = WorkflowExpression.Compile(requesttitle, nameof(requesttitle), required: true);
            return new DeferredBodyTrigger<JsWebhookCreatedResponse>(() =>
            {
                var apiCallPath = "/1.0/registerwebhookjobcompleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["title"] = ExpressionConverter.ConvertO(__workflow_requesttitle);
                request["triggerUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger<JsWebhookCreatedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JsWebhookCreatedResponse> WebhookJobStarted(Expression<Func<string>> requesttitle, FlowRecurrence recurrence = null)
        {
            var __workflow_requesttitle = WorkflowExpression.Compile(requesttitle, nameof(requesttitle), required: true);
            return new DeferredBodyTrigger<JsWebhookCreatedResponse>(() =>
            {
                var apiCallPath = "/1.0/registerwebhookjobstarted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["title"] = ExpressionConverter.ConvertO(__workflow_requesttitle);
                request["triggerUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger<JsWebhookCreatedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JsWebhookCreatedResponse> WebhookJobSumitted(Expression<Func<string>> requesttitle, FlowRecurrence recurrence = null)
        {
            var __workflow_requesttitle = WorkflowExpression.Compile(requesttitle, nameof(requesttitle), required: true);
            return new DeferredBodyTrigger<JsWebhookCreatedResponse>(() =>
            {
                var apiCallPath = "/1.0/registerwebhookjobsubmitted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["title"] = ExpressionConverter.ConvertO(__workflow_requesttitle);
                request["triggerUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

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

    public class JsCreateJobResponse
    {
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum requestrecipientSourceInput
    {
        Emails,
        List,
        Office365Groups,
        ExchangeGroups
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum requestemailContentTypeInput
    {
        Template,
        Html
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
