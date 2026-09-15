//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seismicforcopilotfor
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SeismicforcopilotforActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicforcopilotfor")]
        public IBodyWorkflowAction<ExternalRelatedRecordListResponseEnvelope> ScpGetRelatedRecords(Expression<Func<recordTypeInput>> recordType, Expression<Func<string>> recordId, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<crmTypeInput>> crmType = null, Expression<Func<string>> crmOrgUrl = null)
        {
            var apiCallPath = "/connector/relatedRecords";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["recordType"] = CSharpExpressionConverter.Convert(recordType);
            callPayload.Queries["recordId"] = CSharpExpressionConverter.ConvertO(recordId);
            if (top != null)
                callPayload.Queries["top"] = CSharpExpressionConverter.ConvertO(top);
            if (skip != null)
                callPayload.Queries["skip"] = CSharpExpressionConverter.ConvertO(skip);
            callPayload.Queries["crmType"] = Convert.ToString("Salesforce");
            if (crmType != null)
                callPayload.Queries["crmType"] = CSharpExpressionConverter.Convert(crmType);
            if (crmOrgUrl != null)
                callPayload.Queries["crmOrgUrl"] = CSharpExpressionConverter.ConvertO(crmOrgUrl);
            return new ApiConnectionAction<ExternalRelatedRecordListResponseEnvelope>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicforcopilotfor")]
        public IBodyWorkflowAction<ActivityListResponseEnvelope> ScpGetRelatedActivities(Expression<Func<recordTypeInput>> recordType, Expression<Func<string>> recordId, Expression<Func<string>> startDateTime = null, Expression<Func<string>> endDateTime = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<crmTypeInput>> crmType = null, Expression<Func<string>> crmOrgUrl = null)
        {
            var apiCallPath = "/connector/relatedActivities";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["recordType"] = CSharpExpressionConverter.Convert(recordType);
            callPayload.Queries["recordId"] = CSharpExpressionConverter.ConvertO(recordId);
            if (startDateTime != null)
                callPayload.Queries["startDateTime"] = CSharpExpressionConverter.ConvertO(startDateTime);
            if (endDateTime != null)
                callPayload.Queries["endDateTime"] = CSharpExpressionConverter.ConvertO(endDateTime);
            if (top != null)
                callPayload.Queries["top"] = CSharpExpressionConverter.ConvertO(top);
            if (skip != null)
                callPayload.Queries["skip"] = CSharpExpressionConverter.ConvertO(skip);
            if (crmType != null)
                callPayload.Queries["crmType"] = CSharpExpressionConverter.Convert(crmType);
            if (crmOrgUrl != null)
                callPayload.Queries["crmOrgUrl"] = CSharpExpressionConverter.ConvertO(crmOrgUrl);
            return new ApiConnectionAction<ActivityListResponseEnvelope>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicforcopilotfor")]
        public IBodyWorkflowAction<SalesHighlightListResponseEnvelope> ScpGetSalesHighlights(Expression<Func<recordTypeInput>> recordType, Expression<Func<string>> recordId, Expression<Func<string>> crmType = null, Expression<Func<string>> crmOrgUrl = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var apiCallPath = "/connector/salesHighlights";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["recordType"] = CSharpExpressionConverter.Convert(recordType);
            callPayload.Queries["recordId"] = CSharpExpressionConverter.ConvertO(recordId);
            if (crmType != null)
                callPayload.Queries["crmType"] = CSharpExpressionConverter.ConvertO(crmType);
            if (crmOrgUrl != null)
                callPayload.Queries["crmOrgUrl"] = CSharpExpressionConverter.ConvertO(crmOrgUrl);
            if (top != null)
                callPayload.Queries["top"] = CSharpExpressionConverter.ConvertO(top);
            if (skip != null)
                callPayload.Queries["skip"] = CSharpExpressionConverter.ConvertO(skip);
            return new ApiConnectionAction<SalesHighlightListResponseEnvelope>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicforcopilotfor")]
        public IBodyWorkflowAction<EmailSummeryResponseEnvelope> ScpGetEmailInsights(Expression<Func<string>> emailContacts, Expression<Func<string>> recordType = null, Expression<Func<string>> recordId = null, Expression<Func<string>> crmType = null, Expression<Func<string>> crmOrgUrl = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null)
        {
            var apiCallPath = "/connector/emailInsights";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (recordType != null)
                callPayload.Queries["recordType"] = CSharpExpressionConverter.ConvertO(recordType);
            if (recordId != null)
                callPayload.Queries["recordId"] = CSharpExpressionConverter.ConvertO(recordId);
            if (crmType != null)
                callPayload.Queries["crmType"] = CSharpExpressionConverter.ConvertO(crmType);
            if (crmOrgUrl != null)
                callPayload.Queries["crmOrgUrl"] = CSharpExpressionConverter.ConvertO(crmOrgUrl);
            callPayload.Queries["emailContacts"] = CSharpExpressionConverter.ConvertO(emailContacts);
            if (top != null)
                callPayload.Queries["Top"] = CSharpExpressionConverter.ConvertO(top);
            if (skip != null)
                callPayload.Queries["Skip"] = CSharpExpressionConverter.ConvertO(skip);
            return new ApiConnectionAction<EmailSummeryResponseEnvelope>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicforcopilotfor")]
        public IBodyWorkflowAction<EmailDraftResponseEnvelope> ScpGetContentSuggestions(Expression<Func<string>> requestBodyresourceType, Expression<Func<string>> xMsMessageId = null, Expression<Func<string>> xMsConversationId = null, Expression<Func<string>> requestBodyresourceDataplainTextBody = null, Expression<Func<string>> requestBodyresourceDatafullHTMLBody = null, Expression<Func<string>> requestBodyresourceDatasubject = null, Expression<Func<string>> requestBodyresourceDatafrom = null, Expression<Func<string[]>> requestBodyresourceDatato = null, Expression<Func<string[]>> requestBodyresourceDatacC = null, Expression<Func<string[]>> requestBodyresourceDatabCC = null, Expression<Func<string>> requestBodyresourceDatasentDateTime = null, Expression<Func<string>> requestBodyresourceDatatheGraphMessageId = null, Expression<Func<string>> requestBodyresourceDatatheGraphConversationID = null, Expression<Func<string>> requestBodyrecordType = null, Expression<Func<string>> requestBodyrecordID = null, Expression<Func<string>> requestBodycRMType = null, Expression<Func<string>> requestBodycRMOrgURL = null, Expression<Func<string>> requestBodyinputPrompt = null, Expression<Func<int>> requestBodytop = null, Expression<Func<int>> requestBodyskip = null)
        {
            var apiCallPath = "/connector/contentSuggestions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xMsMessageId != null)
                callPayload.Headers["x-ms-message-id"] = CSharpExpressionConverter.ConvertO(xMsMessageId);
            if (xMsConversationId != null)
                callPayload.Headers["x-ms-conversation-id"] = CSharpExpressionConverter.ConvertO(xMsConversationId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            var resourceDataObject = new JObject();
            var resourceDataObjectpropCount = 0;
            if (requestBodyresourceDataplainTextBody != null)
            {
                resourceDataObject["plaintextBody"] = CSharpExpressionConverter.ConvertToken(requestBodyresourceDataplainTextBody);
                resourceDataObjectpropCount++;
            }

            if (requestBodyresourceDatafullHTMLBody != null)
            {
                resourceDataObject["fullHtmlBody"] = CSharpExpressionConverter.ConvertToken(requestBodyresourceDatafullHTMLBody);
                resourceDataObjectpropCount++;
            }

            if (requestBodyresourceDatasubject != null)
            {
                resourceDataObject["subject"] = CSharpExpressionConverter.ConvertToken(requestBodyresourceDatasubject);
                resourceDataObjectpropCount++;
            }

            if (requestBodyresourceDatafrom != null)
            {
                resourceDataObject["from"] = CSharpExpressionConverter.ConvertToken(requestBodyresourceDatafrom);
                resourceDataObjectpropCount++;
            }

            if (requestBodyresourceDatato != null)
            {
                resourceDataObject["to"] = CSharpExpressionConverter.ConvertToken(requestBodyresourceDatato);
                resourceDataObjectpropCount++;
            }

            if (requestBodyresourceDatacC != null)
            {
                resourceDataObject["cc"] = CSharpExpressionConverter.ConvertToken(requestBodyresourceDatacC);
                resourceDataObjectpropCount++;
            }

            if (requestBodyresourceDatabCC != null)
            {
                resourceDataObject["bcc"] = CSharpExpressionConverter.ConvertToken(requestBodyresourceDatabCC);
                resourceDataObjectpropCount++;
            }

            if (requestBodyresourceDatasentDateTime != null)
            {
                resourceDataObject["sentDateTime"] = CSharpExpressionConverter.ConvertToken(requestBodyresourceDatasentDateTime);
                resourceDataObjectpropCount++;
            }

            if (requestBodyresourceDatatheGraphMessageId != null)
            {
                resourceDataObject["messageId"] = CSharpExpressionConverter.ConvertToken(requestBodyresourceDatatheGraphMessageId);
                resourceDataObjectpropCount++;
            }

            if (requestBodyresourceDatatheGraphConversationID != null)
            {
                resourceDataObject["conversationId"] = CSharpExpressionConverter.ConvertToken(requestBodyresourceDatatheGraphConversationID);
                resourceDataObjectpropCount++;
            }

            if (resourceDataObjectpropCount > 0)
            {
                requestBody["resourceData"] = resourceDataObject;
                requestBodypropCount++;
            }

            requestBodypropCount++;
            requestBody["resourceType"] = CSharpExpressionConverter.ConvertToken(requestBodyresourceType);
            if (requestBodyrecordType != null)
            {
                requestBody["recordType"] = CSharpExpressionConverter.ConvertToken(requestBodyrecordType);
                requestBodypropCount++;
            }

            if (requestBodyrecordID != null)
            {
                requestBody["recordId"] = CSharpExpressionConverter.ConvertToken(requestBodyrecordID);
                requestBodypropCount++;
            }

            if (requestBodycRMType != null)
            {
                requestBody["crmType"] = CSharpExpressionConverter.ConvertToken(requestBodycRMType);
                requestBodypropCount++;
            }

            if (requestBodycRMOrgURL != null)
            {
                requestBody["crmOrgUrl"] = CSharpExpressionConverter.ConvertToken(requestBodycRMOrgURL);
                requestBodypropCount++;
            }

            if (requestBodyinputPrompt != null)
            {
                requestBody["inputPrompt"] = CSharpExpressionConverter.ConvertToken(requestBodyinputPrompt);
                requestBodypropCount++;
            }

            if (requestBodytop != null)
            {
                requestBody["top"] = CSharpExpressionConverter.ConvertToken(requestBodytop);
                requestBodypropCount++;
            }

            if (requestBodyskip != null)
            {
                requestBody["skip"] = CSharpExpressionConverter.ConvertToken(requestBodyskip);
                requestBodypropCount++;
            }

            if (requestBodypropCount > 0)
            {
                callPayload.Body = requestBody;
            }

            return new ApiConnectionAction<EmailDraftResponseEnvelope>(callPayload);
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

    public enum recordTypeInput
    {
        [EnumMember(Value = "account")]
        Account,
        [EnumMember(Value = "opportunity")]
        Opportunity
    }

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