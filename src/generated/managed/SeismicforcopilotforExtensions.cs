//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seismicforcopilotfor
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class SeismicforcopilotforActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicforcopilotfor")]
        public IBodyWorkflowAction<ExternalRelatedRecordListResponseEnvelope> ScpGetRelatedRecords(Expression<Func<recordTypeInput>> recordType, Expression<Func<string>> recordId, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<crmTypeInput>> crmType = null, Expression<Func<string>> crmOrgUrl = null)
        {
            var __workflow_recordType = recordType == null ? null : WorkflowExpression.Compile(recordType);
            WorkflowExpression.Validate(__workflow_recordType, nameof(recordType), required: true);
            var __workflow_recordId = recordId == null ? null : WorkflowExpression.Compile(recordId);
            WorkflowExpression.Validate(__workflow_recordId, nameof(recordId), required: true);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            var __workflow_skip = skip == null ? null : WorkflowExpression.Compile(skip);
            WorkflowExpression.Validate(__workflow_skip, nameof(skip), required: false);
            var __workflow_crmType = crmType == null ? null : WorkflowExpression.Compile(crmType);
            WorkflowExpression.Validate(__workflow_crmType, nameof(crmType), required: false);
            var __workflow_crmOrgUrl = crmOrgUrl == null ? null : WorkflowExpression.Compile(crmOrgUrl);
            WorkflowExpression.Validate(__workflow_crmOrgUrl, nameof(crmOrgUrl), required: false);
            return new DeferredBodyAction<ExternalRelatedRecordListResponseEnvelope>(() =>
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
        public IBodyWorkflowAction<ActivityListResponseEnvelope> ScpGetRelatedActivities(Expression<Func<recordTypeInput>> recordType, Expression<Func<string>> recordId, Expression<Func<string>> startDateTime = null, Expression<Func<string>> endDateTime = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<crmTypeInput>> crmType = null, Expression<Func<string>> crmOrgUrl = null)
        {
            var __workflow_recordType = recordType == null ? null : WorkflowExpression.Compile(recordType);
            WorkflowExpression.Validate(__workflow_recordType, nameof(recordType), required: true);
            var __workflow_recordId = recordId == null ? null : WorkflowExpression.Compile(recordId);
            WorkflowExpression.Validate(__workflow_recordId, nameof(recordId), required: true);
            var __workflow_startDateTime = startDateTime == null ? null : WorkflowExpression.Compile(startDateTime);
            WorkflowExpression.Validate(__workflow_startDateTime, nameof(startDateTime), required: false);
            var __workflow_endDateTime = endDateTime == null ? null : WorkflowExpression.Compile(endDateTime);
            WorkflowExpression.Validate(__workflow_endDateTime, nameof(endDateTime), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            var __workflow_skip = skip == null ? null : WorkflowExpression.Compile(skip);
            WorkflowExpression.Validate(__workflow_skip, nameof(skip), required: false);
            var __workflow_crmType = crmType == null ? null : WorkflowExpression.Compile(crmType);
            WorkflowExpression.Validate(__workflow_crmType, nameof(crmType), required: false);
            var __workflow_crmOrgUrl = crmOrgUrl == null ? null : WorkflowExpression.Compile(crmOrgUrl);
            WorkflowExpression.Validate(__workflow_crmOrgUrl, nameof(crmOrgUrl), required: false);
            return new DeferredBodyAction<ActivityListResponseEnvelope>(() =>
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
        public IBodyWorkflowAction<SalesHighlightListResponseEnvelope> ScpGetSalesHighlights(Expression<Func<recordTypeInput>> recordType, Expression<Func<string>> recordId, Expression<Func<string>> crmType = null, Expression<Func<string>> crmOrgUrl = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_recordType = recordType == null ? null : WorkflowExpression.Compile(recordType);
            WorkflowExpression.Validate(__workflow_recordType, nameof(recordType), required: true);
            var __workflow_recordId = recordId == null ? null : WorkflowExpression.Compile(recordId);
            WorkflowExpression.Validate(__workflow_recordId, nameof(recordId), required: true);
            var __workflow_crmType = crmType == null ? null : WorkflowExpression.Compile(crmType);
            WorkflowExpression.Validate(__workflow_crmType, nameof(crmType), required: false);
            var __workflow_crmOrgUrl = crmOrgUrl == null ? null : WorkflowExpression.Compile(crmOrgUrl);
            WorkflowExpression.Validate(__workflow_crmOrgUrl, nameof(crmOrgUrl), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            var __workflow_skip = skip == null ? null : WorkflowExpression.Compile(skip);
            WorkflowExpression.Validate(__workflow_skip, nameof(skip), required: false);
            return new DeferredBodyAction<SalesHighlightListResponseEnvelope>(() =>
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
        public IBodyWorkflowAction<EmailSummeryResponseEnvelope> ScpGetEmailInsights(Expression<Func<string>> emailContacts, Expression<Func<string>> recordType = null, Expression<Func<string>> recordId = null, Expression<Func<string>> crmType = null, Expression<Func<string>> crmOrgUrl = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var __workflow_emailContacts = emailContacts == null ? null : WorkflowExpression.Compile(emailContacts);
            WorkflowExpression.Validate(__workflow_emailContacts, nameof(emailContacts), required: true);
            var __workflow_recordType = recordType == null ? null : WorkflowExpression.Compile(recordType);
            WorkflowExpression.Validate(__workflow_recordType, nameof(recordType), required: false);
            var __workflow_recordId = recordId == null ? null : WorkflowExpression.Compile(recordId);
            WorkflowExpression.Validate(__workflow_recordId, nameof(recordId), required: false);
            var __workflow_crmType = crmType == null ? null : WorkflowExpression.Compile(crmType);
            WorkflowExpression.Validate(__workflow_crmType, nameof(crmType), required: false);
            var __workflow_crmOrgUrl = crmOrgUrl == null ? null : WorkflowExpression.Compile(crmOrgUrl);
            WorkflowExpression.Validate(__workflow_crmOrgUrl, nameof(crmOrgUrl), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            var __workflow_skip = skip == null ? null : WorkflowExpression.Compile(skip);
            WorkflowExpression.Validate(__workflow_skip, nameof(skip), required: false);
            return new DeferredBodyAction<EmailSummeryResponseEnvelope>(() =>
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
        public IBodyWorkflowAction<EmailDraftResponseEnvelope> ScpGetContentSuggestions(Expression<Func<string>> requestBodyresourceType, Expression<Func<string>> xMsMessageId = null, Expression<Func<string>> xMsConversationId = null, Expression<Func<string>> requestBodyresourceDataplainTextBody = null, Expression<Func<string>> requestBodyresourceDatafullHTMLBody = null, Expression<Func<string>> requestBodyresourceDatasubject = null, Expression<Func<string>> requestBodyresourceDatafrom = null, Expression<Func<string[]>> requestBodyresourceDatato = null, Expression<Func<string[]>> requestBodyresourceDatacC = null, Expression<Func<string[]>> requestBodyresourceDatabCC = null, Expression<Func<string>> requestBodyresourceDatasentDateTime = null, Expression<Func<string>> requestBodyresourceDatatheGraphMessageId = null, Expression<Func<string>> requestBodyresourceDatatheGraphConversationID = null, Expression<Func<string>> requestBodyrecordType = null, Expression<Func<string>> requestBodyrecordID = null, Expression<Func<string>> requestBodycRMType = null, Expression<Func<string>> requestBodycRMOrgURL = null, Expression<Func<string>> requestBodyinputPrompt = null, Expression<Func<int>> requestBodytop = null, Expression<Func<int>> requestBodyskip = null)
        {
            var __workflow_requestBodyresourceType = requestBodyresourceType == null ? null : WorkflowExpression.Compile(requestBodyresourceType);
            WorkflowExpression.Validate(__workflow_requestBodyresourceType, nameof(requestBodyresourceType), required: true);
            var __workflow_xMsMessageId = xMsMessageId == null ? null : WorkflowExpression.Compile(xMsMessageId);
            WorkflowExpression.Validate(__workflow_xMsMessageId, nameof(xMsMessageId), required: false);
            var __workflow_xMsConversationId = xMsConversationId == null ? null : WorkflowExpression.Compile(xMsConversationId);
            WorkflowExpression.Validate(__workflow_xMsConversationId, nameof(xMsConversationId), required: false);
            var __workflow_requestBodyresourceDataplainTextBody = requestBodyresourceDataplainTextBody == null ? null : WorkflowExpression.Compile(requestBodyresourceDataplainTextBody);
            WorkflowExpression.Validate(__workflow_requestBodyresourceDataplainTextBody, nameof(requestBodyresourceDataplainTextBody), required: false);
            var __workflow_requestBodyresourceDatafullHTMLBody = requestBodyresourceDatafullHTMLBody == null ? null : WorkflowExpression.Compile(requestBodyresourceDatafullHTMLBody);
            WorkflowExpression.Validate(__workflow_requestBodyresourceDatafullHTMLBody, nameof(requestBodyresourceDatafullHTMLBody), required: false);
            var __workflow_requestBodyresourceDatasubject = requestBodyresourceDatasubject == null ? null : WorkflowExpression.Compile(requestBodyresourceDatasubject);
            WorkflowExpression.Validate(__workflow_requestBodyresourceDatasubject, nameof(requestBodyresourceDatasubject), required: false);
            var __workflow_requestBodyresourceDatafrom = requestBodyresourceDatafrom == null ? null : WorkflowExpression.Compile(requestBodyresourceDatafrom);
            WorkflowExpression.Validate(__workflow_requestBodyresourceDatafrom, nameof(requestBodyresourceDatafrom), required: false);
            var __workflow_requestBodyresourceDatato = requestBodyresourceDatato == null ? null : WorkflowExpression.Compile(requestBodyresourceDatato);
            WorkflowExpression.Validate(__workflow_requestBodyresourceDatato, nameof(requestBodyresourceDatato), required: false);
            var __workflow_requestBodyresourceDatacC = requestBodyresourceDatacC == null ? null : WorkflowExpression.Compile(requestBodyresourceDatacC);
            WorkflowExpression.Validate(__workflow_requestBodyresourceDatacC, nameof(requestBodyresourceDatacC), required: false);
            var __workflow_requestBodyresourceDatabCC = requestBodyresourceDatabCC == null ? null : WorkflowExpression.Compile(requestBodyresourceDatabCC);
            WorkflowExpression.Validate(__workflow_requestBodyresourceDatabCC, nameof(requestBodyresourceDatabCC), required: false);
            var __workflow_requestBodyresourceDatasentDateTime = requestBodyresourceDatasentDateTime == null ? null : WorkflowExpression.Compile(requestBodyresourceDatasentDateTime);
            WorkflowExpression.Validate(__workflow_requestBodyresourceDatasentDateTime, nameof(requestBodyresourceDatasentDateTime), required: false);
            var __workflow_requestBodyresourceDatatheGraphMessageId = requestBodyresourceDatatheGraphMessageId == null ? null : WorkflowExpression.Compile(requestBodyresourceDatatheGraphMessageId);
            WorkflowExpression.Validate(__workflow_requestBodyresourceDatatheGraphMessageId, nameof(requestBodyresourceDatatheGraphMessageId), required: false);
            var __workflow_requestBodyresourceDatatheGraphConversationID = requestBodyresourceDatatheGraphConversationID == null ? null : WorkflowExpression.Compile(requestBodyresourceDatatheGraphConversationID);
            WorkflowExpression.Validate(__workflow_requestBodyresourceDatatheGraphConversationID, nameof(requestBodyresourceDatatheGraphConversationID), required: false);
            var __workflow_requestBodyrecordType = requestBodyrecordType == null ? null : WorkflowExpression.Compile(requestBodyrecordType);
            WorkflowExpression.Validate(__workflow_requestBodyrecordType, nameof(requestBodyrecordType), required: false);
            var __workflow_requestBodyrecordID = requestBodyrecordID == null ? null : WorkflowExpression.Compile(requestBodyrecordID);
            WorkflowExpression.Validate(__workflow_requestBodyrecordID, nameof(requestBodyrecordID), required: false);
            var __workflow_requestBodycRMType = requestBodycRMType == null ? null : WorkflowExpression.Compile(requestBodycRMType);
            WorkflowExpression.Validate(__workflow_requestBodycRMType, nameof(requestBodycRMType), required: false);
            var __workflow_requestBodycRMOrgURL = requestBodycRMOrgURL == null ? null : WorkflowExpression.Compile(requestBodycRMOrgURL);
            WorkflowExpression.Validate(__workflow_requestBodycRMOrgURL, nameof(requestBodycRMOrgURL), required: false);
            var __workflow_requestBodyinputPrompt = requestBodyinputPrompt == null ? null : WorkflowExpression.Compile(requestBodyinputPrompt);
            WorkflowExpression.Validate(__workflow_requestBodyinputPrompt, nameof(requestBodyinputPrompt), required: false);
            var __workflow_requestBodytop = requestBodytop == null ? null : WorkflowExpression.Compile(requestBodytop);
            WorkflowExpression.Validate(__workflow_requestBodytop, nameof(requestBodytop), required: false);
            var __workflow_requestBodyskip = requestBodyskip == null ? null : WorkflowExpression.Compile(requestBodyskip);
            WorkflowExpression.Validate(__workflow_requestBodyskip, nameof(requestBodyskip), required: false);
            return new DeferredBodyAction<EmailDraftResponseEnvelope>(() =>
            {
                var apiCallPath = "/connector/contentSuggestions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsMessageId != null)
                    callPayload.Headers["x-ms-message-id"] = ExpressionConverter.Convert(__workflow_xMsMessageId);
                if (__workflow_xMsConversationId != null)
                    callPayload.Headers["x-ms-conversation-id"] = ExpressionConverter.Convert(__workflow_xMsConversationId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                var resourceDataObject = new JObject();
                var resourceDataObjectpropCount = 0;
                if (__workflow_requestBodyresourceDataplainTextBody != null)
                {
                    resourceDataObject["plaintextBody"] = ExpressionConverter.ConvertO(__workflow_requestBodyresourceDataplainTextBody);
                    resourceDataObjectpropCount++;
                }

                if (__workflow_requestBodyresourceDatafullHTMLBody != null)
                {
                    resourceDataObject["fullHtmlBody"] = ExpressionConverter.ConvertO(__workflow_requestBodyresourceDatafullHTMLBody);
                    resourceDataObjectpropCount++;
                }

                if (__workflow_requestBodyresourceDatasubject != null)
                {
                    resourceDataObject["subject"] = ExpressionConverter.ConvertO(__workflow_requestBodyresourceDatasubject);
                    resourceDataObjectpropCount++;
                }

                if (__workflow_requestBodyresourceDatafrom != null)
                {
                    resourceDataObject["from"] = ExpressionConverter.ConvertO(__workflow_requestBodyresourceDatafrom);
                    resourceDataObjectpropCount++;
                }

                if (__workflow_requestBodyresourceDatato != null)
                {
                    resourceDataObject["to"] = ExpressionConverter.ConvertO(__workflow_requestBodyresourceDatato);
                    resourceDataObjectpropCount++;
                }

                if (__workflow_requestBodyresourceDatacC != null)
                {
                    resourceDataObject["cc"] = ExpressionConverter.ConvertO(__workflow_requestBodyresourceDatacC);
                    resourceDataObjectpropCount++;
                }

                if (__workflow_requestBodyresourceDatabCC != null)
                {
                    resourceDataObject["bcc"] = ExpressionConverter.ConvertO(__workflow_requestBodyresourceDatabCC);
                    resourceDataObjectpropCount++;
                }

                if (__workflow_requestBodyresourceDatasentDateTime != null)
                {
                    resourceDataObject["sentDateTime"] = ExpressionConverter.ConvertO(__workflow_requestBodyresourceDatasentDateTime);
                    resourceDataObjectpropCount++;
                }

                if (__workflow_requestBodyresourceDatatheGraphMessageId != null)
                {
                    resourceDataObject["messageId"] = ExpressionConverter.ConvertO(__workflow_requestBodyresourceDatatheGraphMessageId);
                    resourceDataObjectpropCount++;
                }

                if (__workflow_requestBodyresourceDatatheGraphConversationID != null)
                {
                    resourceDataObject["conversationId"] = ExpressionConverter.ConvertO(__workflow_requestBodyresourceDatatheGraphConversationID);
                    resourceDataObjectpropCount++;
                }

                if (resourceDataObjectpropCount > 0)
                {
                    requestBody["resourceData"] = resourceDataObject;
                    requestBodypropCount++;
                }

                requestBodypropCount++;
                requestBody["resourceType"] = ExpressionConverter.ConvertO(__workflow_requestBodyresourceType);
                if (__workflow_requestBodyrecordType != null)
                {
                    requestBody["recordType"] = ExpressionConverter.ConvertO(__workflow_requestBodyrecordType);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyrecordID != null)
                {
                    requestBody["recordId"] = ExpressionConverter.ConvertO(__workflow_requestBodyrecordID);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodycRMType != null)
                {
                    requestBody["crmType"] = ExpressionConverter.ConvertO(__workflow_requestBodycRMType);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodycRMOrgURL != null)
                {
                    requestBody["crmOrgUrl"] = ExpressionConverter.ConvertO(__workflow_requestBodycRMOrgURL);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyinputPrompt != null)
                {
                    requestBody["inputPrompt"] = ExpressionConverter.ConvertO(__workflow_requestBodyinputPrompt);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodytop != null)
                {
                    requestBody["top"] = ExpressionConverter.ConvertO(__workflow_requestBodytop);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyskip != null)
                {
                    requestBody["skip"] = ExpressionConverter.ConvertO(__workflow_requestBodyskip);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

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
        public string RecordID { get; set; }

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
