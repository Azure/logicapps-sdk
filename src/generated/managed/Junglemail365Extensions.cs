//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Junglemail365
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Junglemail365Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JsEmailsResponse> EmailsGet([WorkflowExpression] Func<string> requestJobId, [WorkflowExpression] Func<requestEmailTypeInput> requestEmailType)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1.0/emails";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["request.jobId"] = SourceExpressionConverter.ConvertO(requestJobId);
                callPayload.Queries["request.emailType"] = SourceExpressionConverter.Convert(requestEmailType);
                return callPayload;
            }

            return new ApiConnectionAction<JsEmailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JToken> JobApprove([WorkflowExpression] Func<string> requestsecret, [WorkflowExpression] Func<string> requestcomments = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1.0/job/approve";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestcomments != null)
                {
                    request["comments"] = SourceExpressionConverter.ConvertToken(requestcomments);
                    requestpropCount++;
                }

                requestpropCount++;
                request["secret"] = SourceExpressionConverter.ConvertToken(requestsecret);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JsCreateJobResponse> JobCreate([WorkflowExpression] Func<requestrecipientSourceInput> requestrecipientSource, [WorkflowExpression] Func<string> requestsendingAccount, [WorkflowExpression] Func<string> requestnewsletterTitle, [WorkflowExpression] Func<string> requestoffice365Groups = null, [WorkflowExpression] Func<string> requestattachmentContent = null, [WorkflowExpression] Func<string> requestattachmentName = null, [WorkflowExpression] Func<string> requestemailAddresses = null, [WorkflowExpression] Func<string> requestemailContent = null, [WorkflowExpression] Func<requestemailContentTypeInput> requestemailContentType = null, [WorkflowExpression] Func<string> requestemailSubject = null, [WorkflowExpression] Func<string> requestexchangeGroups = null, [WorkflowExpression] Func<requestwhenToSendTypeInput> requestwhenToSendType = null, [WorkflowExpression] Func<string> requestwhenToSend = null, [WorkflowExpression] Func<string> requestrecipientEmailField = null, [WorkflowExpression] Func<string> requestrecipientListURL = null, [WorkflowExpression] Func<string> requestrecipientFilterView = null, [WorkflowExpression] Func<bool> requestremoveDuplicates = null, [WorkflowExpression] Func<bool> requestsendReport = null, [WorkflowExpression] Func<string> requesttimeZone = null, [WorkflowExpression] Func<string> requesttemplate = null, [WorkflowExpression] Func<bool> requesttrackClicks = null, [WorkflowExpression] Func<bool> requesttrackOpens = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1.0/job/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestoffice365Groups != null)
                {
                    request["adGroups"] = SourceExpressionConverter.ConvertToken(requestoffice365Groups);
                    requestpropCount++;
                }

                if (requestattachmentContent != null)
                {
                    request["attachmentContent"] = SourceExpressionConverter.ConvertToken(requestattachmentContent);
                    requestpropCount++;
                }

                if (requestattachmentName != null)
                {
                    request["attachmentName"] = SourceExpressionConverter.ConvertToken(requestattachmentName);
                    requestpropCount++;
                }

                if (requestemailAddresses != null)
                {
                    request["emailAddresses"] = SourceExpressionConverter.ConvertToken(requestemailAddresses);
                    requestpropCount++;
                }

                if (requestemailContent != null)
                {
                    request["emailBody"] = SourceExpressionConverter.ConvertToken(requestemailContent);
                    requestpropCount++;
                }

                if (requestemailContentType != null)
                {
                    if (requestemailContentType != null)
                    {
                        request["emailContentType"] = SourceExpressionConverter.Convert(requestemailContentType);
                        requestpropCount++;
                    }

                    requestpropCount++;
                }
                else
                {
                    request["emailContentType"] = "Template";
                    requestpropCount++;
                }

                if (requestemailSubject != null)
                {
                    request["emailSubject"] = SourceExpressionConverter.ConvertToken(requestemailSubject);
                    requestpropCount++;
                }

                if (requestexchangeGroups != null)
                {
                    request["exchangeGroups"] = SourceExpressionConverter.ConvertToken(requestexchangeGroups);
                    requestpropCount++;
                }

                if (requestwhenToSendType != null)
                {
                    if (requestwhenToSendType != null)
                    {
                        request["jobExecutionType"] = SourceExpressionConverter.Convert(requestwhenToSendType);
                        requestpropCount++;
                    }

                    requestpropCount++;
                }
                else
                {
                    request["jobExecutionType"] = "Now";
                    requestpropCount++;
                }

                if (requestwhenToSend != null)
                {
                    request["jobScheduleTime"] = SourceExpressionConverter.ConvertToken(requestwhenToSend);
                    requestpropCount++;
                }

                if (requestrecipientEmailField != null)
                {
                    request["recipientListField"] = SourceExpressionConverter.ConvertToken(requestrecipientEmailField);
                    requestpropCount++;
                }

                if (requestrecipientListURL != null)
                {
                    request["recipientListUrl"] = SourceExpressionConverter.ConvertToken(requestrecipientListURL);
                    requestpropCount++;
                }

                if (requestrecipientFilterView != null)
                {
                    request["recipientListView"] = SourceExpressionConverter.ConvertToken(requestrecipientFilterView);
                    requestpropCount++;
                }

                requestpropCount++;
                request["recipientType"] = SourceExpressionConverter.Convert(requestrecipientSource);
                if (requestremoveDuplicates != null)
                {
                    if (requestremoveDuplicates != null)
                    {
                        request["removeDuplicates"] = SourceExpressionConverter.ConvertToken(requestremoveDuplicates);
                        requestpropCount++;
                    }

                    requestpropCount++;
                }
                else
                {
                    request["removeDuplicates"] = true;
                    requestpropCount++;
                }

                if (requestsendReport != null)
                {
                    if (requestsendReport != null)
                    {
                        request["reportAuthor"] = SourceExpressionConverter.ConvertToken(requestsendReport);
                        requestpropCount++;
                    }

                    requestpropCount++;
                }
                else
                {
                    request["reportAuthor"] = true;
                    requestpropCount++;
                }

                if (requesttimeZone != null)
                {
                    request["scheduledTimeZoneId"] = SourceExpressionConverter.ConvertToken(requesttimeZone);
                    requestpropCount++;
                }

                requestpropCount++;
                request["sendingAddressId"] = SourceExpressionConverter.ConvertToken(requestsendingAccount);
                if (requesttemplate != null)
                {
                    request["template"] = SourceExpressionConverter.ConvertToken(requesttemplate);
                    requestpropCount++;
                }

                requestpropCount++;
                request["title"] = SourceExpressionConverter.ConvertToken(requestnewsletterTitle);
                if (requesttrackClicks != null)
                {
                    if (requesttrackClicks != null)
                    {
                        request["trackClicks"] = SourceExpressionConverter.ConvertToken(requesttrackClicks);
                        requestpropCount++;
                    }

                    requestpropCount++;
                }
                else
                {
                    request["trackClicks"] = true;
                    requestpropCount++;
                }

                if (requesttrackOpens != null)
                {
                    if (requesttrackOpens != null)
                    {
                        request["trackOpens"] = SourceExpressionConverter.ConvertToken(requesttrackOpens);
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
                return callPayload;
            }

            return new ApiConnectionAction<JsCreateJobResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JsJob> JobGet([WorkflowExpression] Func<string> requestJobId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1.0/job/get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["request.jobId"] = SourceExpressionConverter.ConvertO(requestJobId);
                return callPayload;
            }

            return new ApiConnectionAction<JsJob>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JsJobsResponse> JobGetAll([WorkflowExpression] Func<string> requestDateFrom = null, [WorkflowExpression] Func<string> requestDateTo = null, [WorkflowExpression] Func<int> requestLimit = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1.0/job/getlist";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (requestDateFrom != null)
                    callPayload.Queries["request.dateFrom"] = SourceExpressionConverter.ConvertO(requestDateFrom);
                if (requestDateTo != null)
                    callPayload.Queries["request.dateTo"] = SourceExpressionConverter.ConvertO(requestDateTo);
                if (requestLimit != null)
                    callPayload.Queries["request.limit"] = SourceExpressionConverter.ConvertO(requestLimit);
                return callPayload;
            }

            return new ApiConnectionAction<JsJobsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JsJobReport> JobGetReport([WorkflowExpression] Func<string> requestJobId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1.0/job/getreport";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["request.jobId"] = SourceExpressionConverter.ConvertO(requestJobId);
                return callPayload;
            }

            return new ApiConnectionAction<JsJobReport>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JToken> JobReject([WorkflowExpression] Func<string> requestsecret, [WorkflowExpression] Func<string> requestcomments = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1.0/job/reject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestcomments != null)
                {
                    request["comments"] = SourceExpressionConverter.ConvertToken(requestcomments);
                    requestpropCount++;
                }

                requestpropCount++;
                request["secret"] = SourceExpressionConverter.ConvertToken(requestsecret);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JsTrackerLogResponse> TrackerLogGet([WorkflowExpression] Func<string> requestJobId, [WorkflowExpression] Func<requestDataTypeInput> requestDataType)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1.0/trackerlog";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["request.jobId"] = SourceExpressionConverter.ConvertO(requestJobId);
                callPayload.Queries["request.dataType"] = SourceExpressionConverter.Convert(requestDataType);
                return callPayload;
            }

            return new ApiConnectionAction<JsTrackerLogResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "junglemail365")]
        public IBodyWorkflowAction<JsUnsubscribesResponse> UnsubscribesGet([WorkflowExpression] Func<string> requestJobId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1.0/unsubscribes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (requestJobId != null)
                    callPayload.Queries["request.jobId"] = SourceExpressionConverter.ConvertO(requestJobId);
                return callPayload;
            }

            return new ApiConnectionAction<JsUnsubscribesResponse>(BuildSourceInput);
        }
    }

    public class Junglemail365Triggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JsWebhookCreatedResponse> WebhookJobCompleted([WorkflowExpression] Func<string> requesttitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1.0/registerwebhookjobcompleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["title"] = SourceExpressionConverter.ConvertToken(requesttitle);
                request["triggerUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JsWebhookCreatedResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JsWebhookCreatedResponse> WebhookJobStarted([WorkflowExpression] Func<string> requesttitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1.0/registerwebhookjobstarted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["title"] = SourceExpressionConverter.ConvertToken(requesttitle);
                request["triggerUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JsWebhookCreatedResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JsWebhookCreatedResponse> WebhookJobSumitted([WorkflowExpression] Func<string> requesttitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1.0/registerwebhookjobsubmitted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["title"] = SourceExpressionConverter.ConvertToken(requesttitle);
                request["triggerUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JsWebhookCreatedResponse>(BuildSourceInput, triggerName, recurrence);
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