//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seismicforcopilotfor
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SeismicforcopilotforActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicforcopilotfor")]
        public IBodyWorkflowAction<ExternalRelatedRecordListResponseEnvelope, ApiConnectionActionConfiguration> ScpGetRelatedRecords(Expression<Func<recordTypeInput>> recordType, Expression<Func<string>> recordId, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<crmTypeInput>> crmType = null, Expression<Func<string>> crmOrgUrl = null)
        {
            var __workflow_recordType = WorkflowExpression.Compile(recordType, nameof(recordType), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_crmType = WorkflowExpression.Compile(crmType, nameof(crmType), required: false);
            var __workflow_crmOrgUrl = WorkflowExpression.Compile(crmOrgUrl, nameof(crmOrgUrl), required: false);
            return new DeferredBodyAction<ExternalRelatedRecordListResponseEnvelope, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connector/relatedRecords";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["recordType"] = ExpressionConverter.Convert(__workflow_recordType);
                callPayload.Queries["recordId"] = ExpressionConverter.Convert(__workflow_recordId);
                if (__workflow_top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["crmType"] = Convert.ToString("Salesforce");
                if (__workflow_crmType != null)
                    callPayload.Queries["crmType"] = ExpressionConverter.Convert(__workflow_crmType);
                if (__workflow_crmOrgUrl != null)
                    callPayload.Queries["crmOrgUrl"] = ExpressionConverter.Convert(__workflow_crmOrgUrl);
                return new ApiConnectionAction<ExternalRelatedRecordListResponseEnvelope>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicforcopilotfor")]
        public IBodyWorkflowAction<ActivityListResponseEnvelope, ApiConnectionActionConfiguration> ScpGetRelatedActivities(Expression<Func<recordTypeInput>> recordType, Expression<Func<string>> recordId, Expression<Func<string>> startDateTime = null, Expression<Func<string>> endDateTime = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<crmTypeInput>> crmType = null, Expression<Func<string>> crmOrgUrl = null)
        {
            var __workflow_recordType = WorkflowExpression.Compile(recordType, nameof(recordType), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_startDateTime = WorkflowExpression.Compile(startDateTime, nameof(startDateTime), required: false);
            var __workflow_endDateTime = WorkflowExpression.Compile(endDateTime, nameof(endDateTime), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_crmType = WorkflowExpression.Compile(crmType, nameof(crmType), required: false);
            var __workflow_crmOrgUrl = WorkflowExpression.Compile(crmOrgUrl, nameof(crmOrgUrl), required: false);
            return new DeferredBodyAction<ActivityListResponseEnvelope, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connector/relatedActivities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["recordType"] = ExpressionConverter.Convert(__workflow_recordType);
                callPayload.Queries["recordId"] = ExpressionConverter.Convert(__workflow_recordId);
                if (__workflow_startDateTime != null)
                    callPayload.Queries["startDateTime"] = ExpressionConverter.Convert(__workflow_startDateTime);
                if (__workflow_endDateTime != null)
                    callPayload.Queries["endDateTime"] = ExpressionConverter.Convert(__workflow_endDateTime);
                if (__workflow_top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_crmType != null)
                    callPayload.Queries["crmType"] = ExpressionConverter.Convert(__workflow_crmType);
                if (__workflow_crmOrgUrl != null)
                    callPayload.Queries["crmOrgUrl"] = ExpressionConverter.Convert(__workflow_crmOrgUrl);
                return new ApiConnectionAction<ActivityListResponseEnvelope>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicforcopilotfor")]
        public IBodyWorkflowAction<SalesHighlightListResponseEnvelope, ApiConnectionActionConfiguration> ScpGetSalesHighlights(Expression<Func<recordTypeInput>> recordType, Expression<Func<string>> recordId, Expression<Func<string>> crmType = null, Expression<Func<string>> crmOrgUrl = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_recordType = WorkflowExpression.Compile(recordType, nameof(recordType), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_crmType = WorkflowExpression.Compile(crmType, nameof(crmType), required: false);
            var __workflow_crmOrgUrl = WorkflowExpression.Compile(crmOrgUrl, nameof(crmOrgUrl), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<SalesHighlightListResponseEnvelope, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connector/salesHighlights";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["recordType"] = ExpressionConverter.Convert(__workflow_recordType);
                callPayload.Queries["recordId"] = ExpressionConverter.Convert(__workflow_recordId);
                if (__workflow_crmType != null)
                    callPayload.Queries["crmType"] = ExpressionConverter.Convert(__workflow_crmType);
                if (__workflow_crmOrgUrl != null)
                    callPayload.Queries["crmOrgUrl"] = ExpressionConverter.Convert(__workflow_crmOrgUrl);
                if (__workflow_top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                return new ApiConnectionAction<SalesHighlightListResponseEnvelope>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicforcopilotfor")]
        public IBodyWorkflowAction<EmailSummeryResponseEnvelope, ApiConnectionActionConfiguration> ScpGetEmailInsights(Expression<Func<string>> emailContacts, Expression<Func<string>> recordType = null, Expression<Func<string>> recordId = null, Expression<Func<string>> crmType = null, Expression<Func<string>> crmOrgUrl = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_emailContacts = WorkflowExpression.Compile(emailContacts, nameof(emailContacts), required: true);
            var __workflow_recordType = WorkflowExpression.Compile(recordType, nameof(recordType), required: false);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: false);
            var __workflow_crmType = WorkflowExpression.Compile(crmType, nameof(crmType), required: false);
            var __workflow_crmOrgUrl = WorkflowExpression.Compile(crmOrgUrl, nameof(crmOrgUrl), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<EmailSummeryResponseEnvelope, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connector/emailInsights";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recordType != null)
                    callPayload.Queries["recordType"] = ExpressionConverter.Convert(__workflow_recordType);
                if (__workflow_recordId != null)
                    callPayload.Queries["recordId"] = ExpressionConverter.Convert(__workflow_recordId);
                if (__workflow_crmType != null)
                    callPayload.Queries["crmType"] = ExpressionConverter.Convert(__workflow_crmType);
                if (__workflow_crmOrgUrl != null)
                    callPayload.Queries["crmOrgUrl"] = ExpressionConverter.Convert(__workflow_crmOrgUrl);
                callPayload.Queries["emailContacts"] = ExpressionConverter.Convert(__workflow_emailContacts);
                if (__workflow_top != null)
                    callPayload.Queries["Top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["Skip"] = ExpressionConverter.Convert(__workflow_skip);
                return new ApiConnectionAction<EmailSummeryResponseEnvelope>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicforcopilotfor")]
        public IBodyWorkflowAction<EmailDraftResponseEnvelope, ApiConnectionActionConfiguration> ScpGetContentSuggestions(Expression<Func<ScpGetContentSuggestionsInput>> requestBody, Expression<Func<string>> xMsMessageId = null, Expression<Func<string>> xMsConversationId = null)
        {
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: true);
            var __workflow_xMsMessageId = WorkflowExpression.Compile(xMsMessageId, nameof(xMsMessageId), required: false);
            var __workflow_xMsConversationId = WorkflowExpression.Compile(xMsConversationId, nameof(xMsConversationId), required: false);
            return new DeferredBodyAction<EmailDraftResponseEnvelope, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connector/contentSuggestions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsMessageId != null)
                    callPayload.Headers["x-ms-message-id"] = ExpressionConverter.Convert(__workflow_xMsMessageId);
                if (__workflow_xMsConversationId != null)
                    callPayload.Headers["x-ms-conversation-id"] = ExpressionConverter.Convert(__workflow_xMsConversationId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<EmailDraftResponseEnvelope>(callPayload);
            });
        }
    }

    public class SeismicforcopilotforTriggers([ConnectionName] string connectionId)
    {
    }

    public class ExternalRelatedRecordListResponseEnvelope
    {
        [JsonProperty("value")]
        public ExternalRelatedRecord[] Value { get; set; }

        [JsonProperty("hasMoreResults")]
        public bool HasMoreResults { get; set; }
    }

    public class ExternalRelatedRecord
    {
        [JsonProperty("recordId")]
        public string RecordId { get; set; }

        [JsonProperty("recordTypeDisplayName")]
        public string RecordTypeDisplayName { get; set; }

        [JsonProperty("recordTypePluralDisplayName")]
        public string RecordTypePluralDisplayName { get; set; }

        [JsonProperty("recordType")]
        public string RecordType { get; set; }

        [JsonProperty("recordTitle")]
        public string RecordTitle { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("additionalProperties")]
        public JToken AdditionalProperties { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum recordTypeInput
    {
        [EnumMember(Value = "account")]
        Account,
        [EnumMember(Value = "opportunity")]
        Opportunity
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum crmTypeInput
    {
        Salesforce,
        Dynamics365
    }

    public class ActivityListResponseEnvelope
    {
        [JsonProperty("value")]
        public Activity[] Value { get; set; }

        [JsonProperty("hasMoreResults")]
        public bool HasMoreResults { get; set; }
    }

    public class Activity
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("additionalProperties")]
        public JToken AdditionalProperties { get; set; }
    }

    public class SalesHighlightListResponseEnvelope
    {
        [JsonProperty("value")]
        public SalesHighlight[] Value { get; set; }

        [JsonProperty("hasMoreResults")]
        public bool HasMoreResults { get; set; }
    }

    public class SalesHighlight
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("additionalProperties")]
        public JToken AdditionalProperties { get; set; }
    }

    public class EmailSummeryResponseEnvelope
    {
        [JsonProperty("value")]
        public EmailSummery[] Value { get; set; }

        [JsonProperty("hasMoreResults")]
        public bool HasMoreResults { get; set; }
    }

    public class EmailSummery
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class EmailDraftResponseEnvelope
    {
        [JsonProperty("value")]
        public EmailDraft[] Value { get; set; }

        [JsonProperty("hasMoreResults")]
        public bool HasMoreResults { get; set; }
    }

    public class EmailDraft
    {
        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("contentTitle")]
        public string ContentTitle { get; set; }

        [JsonProperty("contentDescription")]
        public string ContentDescription { get; set; }

        [JsonProperty("contentIconUrl")]
        public string ContentIconURL { get; set; }

        [JsonProperty("additionalProperties")]
        public JToken AdditionalProperties { get; set; }
    }

    public class ScpGetContentSuggestionsInput
    {
        [JsonProperty("resourceData", DefaultValueHandling = DefaultValueHandling.Include)]
        public EmailDataModel ResourceData { get; set; }

        [JsonProperty("resourceType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ResourceType { get; set; }

        [JsonProperty("recordType")]
        public string RecordType { get; set; }

        [JsonProperty("recordId")]
        public string RecordId { get; set; }

        [JsonProperty("crmType")]
        public string CRMType { get; set; }

        [JsonProperty("crmOrgUrl")]
        public string CRMOrgURL { get; set; }

        [JsonProperty("inputPrompt")]
        public string InputPrompt { get; set; }

        [JsonProperty("top")]
        public int? Top { get; set; }

        [JsonProperty("skip")]
        public int? Skip { get; set; }
    }

    public class EmailDataModel
    {
        [JsonProperty("plaintextBody")]
        public string PlainTextBody { get; set; }

        [JsonProperty("fullHtmlBody")]
        public string FullHTMLBody { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string[] To { get; set; }

        [JsonProperty("cc")]
        public string[] CC { get; set; }

        [JsonProperty("bcc")]
        public string[] BCC { get; set; }

        [JsonProperty("sentDateTime")]
        public string SentDateTime { get; set; }

        [JsonProperty("messageId")]
        public string TheGraphMessageId { get; set; }

        [JsonProperty("conversationId")]
        public string TheGraphConversationId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Seismicforcopilotfor;

    public partial class WorkflowManagedActions
    {
        public SeismicforcopilotforActions Seismicforcopilotfor(string connectionId) => new SeismicforcopilotforActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SeismicforcopilotforTriggers Seismicforcopilotfor(string connectionId) => new SeismicforcopilotforTriggers(connectionId);
    }
}