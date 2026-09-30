//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seismicforcopilotfor
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SeismicforcopilotforActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicforcopilotfor")]
        public IBodyWorkflowAction<ExternalRelatedRecordListResponseEnvelope> ScpGetRelatedRecords([WorkflowExpression] Func<recordTypeInput> recordType, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<crmTypeInput> crmType = null, [WorkflowExpression] Func<string> crmOrgUrl = null)
        {
            var apiCallPath = "/connector/relatedRecords";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["recordType"] = ExpressionConverter.Convert(recordType);
            callPayload.Queries["recordId"] = ExpressionConverter.Convert(recordId);
            if (top != null)
                callPayload.Queries["top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["crmType"] = Convert.ToString("Salesforce");
            if (crmType != null)
                callPayload.Queries["crmType"] = ExpressionConverter.Convert(crmType);
            if (crmOrgUrl != null)
                callPayload.Queries["crmOrgUrl"] = ExpressionConverter.Convert(crmOrgUrl);
            return new ApiConnectionAction<ExternalRelatedRecordListResponseEnvelope>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicforcopilotfor")]
        public IBodyWorkflowAction<ActivityListResponseEnvelope> ScpGetRelatedActivities([WorkflowExpression] Func<recordTypeInput> recordType, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<string> startDateTime = null, [WorkflowExpression] Func<string> endDateTime = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<crmTypeInput> crmType = null, [WorkflowExpression] Func<string> crmOrgUrl = null)
        {
            var apiCallPath = "/connector/relatedActivities";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["recordType"] = ExpressionConverter.Convert(recordType);
            callPayload.Queries["recordId"] = ExpressionConverter.Convert(recordId);
            if (startDateTime != null)
                callPayload.Queries["startDateTime"] = ExpressionConverter.Convert(startDateTime);
            if (endDateTime != null)
                callPayload.Queries["endDateTime"] = ExpressionConverter.Convert(endDateTime);
            if (top != null)
                callPayload.Queries["top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["skip"] = ExpressionConverter.Convert(skip);
            if (crmType != null)
                callPayload.Queries["crmType"] = ExpressionConverter.Convert(crmType);
            if (crmOrgUrl != null)
                callPayload.Queries["crmOrgUrl"] = ExpressionConverter.Convert(crmOrgUrl);
            return new ApiConnectionAction<ActivityListResponseEnvelope>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicforcopilotfor")]
        public IBodyWorkflowAction<SalesHighlightListResponseEnvelope> ScpGetSalesHighlights([WorkflowExpression] Func<recordTypeInput> recordType, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<string> crmType = null, [WorkflowExpression] Func<string> crmOrgUrl = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null)
        {
            var apiCallPath = "/connector/salesHighlights";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["recordType"] = ExpressionConverter.Convert(recordType);
            callPayload.Queries["recordId"] = ExpressionConverter.Convert(recordId);
            if (crmType != null)
                callPayload.Queries["crmType"] = ExpressionConverter.Convert(crmType);
            if (crmOrgUrl != null)
                callPayload.Queries["crmOrgUrl"] = ExpressionConverter.Convert(crmOrgUrl);
            if (top != null)
                callPayload.Queries["top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["skip"] = ExpressionConverter.Convert(skip);
            return new ApiConnectionAction<SalesHighlightListResponseEnvelope>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicforcopilotfor")]
        public IBodyWorkflowAction<EmailSummeryResponseEnvelope> ScpGetEmailInsights([WorkflowExpression] Func<string> emailContacts, [WorkflowExpression] Func<string> recordType = null, [WorkflowExpression] Func<string> recordId = null, [WorkflowExpression] Func<string> crmType = null, [WorkflowExpression] Func<string> crmOrgUrl = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null)
        {
            var apiCallPath = "/connector/emailInsights";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (recordType != null)
                callPayload.Queries["recordType"] = ExpressionConverter.Convert(recordType);
            if (recordId != null)
                callPayload.Queries["recordId"] = ExpressionConverter.Convert(recordId);
            if (crmType != null)
                callPayload.Queries["crmType"] = ExpressionConverter.Convert(crmType);
            if (crmOrgUrl != null)
                callPayload.Queries["crmOrgUrl"] = ExpressionConverter.Convert(crmOrgUrl);
            callPayload.Queries["emailContacts"] = ExpressionConverter.Convert(emailContacts);
            if (top != null)
                callPayload.Queries["Top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["Skip"] = ExpressionConverter.Convert(skip);
            return new ApiConnectionAction<EmailSummeryResponseEnvelope>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicforcopilotfor")]
        public IBodyWorkflowAction<EmailDraftResponseEnvelope> ScpGetContentSuggestions([WorkflowExpression] Func<string> requestBodyresourceType, [WorkflowExpression] Func<string> xMsMessageId = null, [WorkflowExpression] Func<string> xMsConversationId = null, [WorkflowExpression] Func<string> requestBodyresourceDataplainTextBody = null, [WorkflowExpression] Func<string> requestBodyresourceDatafullHTMLBody = null, [WorkflowExpression] Func<string> requestBodyresourceDatasubject = null, [WorkflowExpression] Func<string> requestBodyresourceDatafrom = null, [WorkflowExpression] Func<string[]> requestBodyresourceDatato = null, [WorkflowExpression] Func<string[]> requestBodyresourceDatacC = null, [WorkflowExpression] Func<string[]> requestBodyresourceDatabCC = null, [WorkflowExpression] Func<string> requestBodyresourceDatasentDateTime = null, [WorkflowExpression] Func<string> requestBodyresourceDatatheGraphMessageId = null, [WorkflowExpression] Func<string> requestBodyresourceDatatheGraphConversationID = null, [WorkflowExpression] Func<string> requestBodyrecordType = null, [WorkflowExpression] Func<string> requestBodyrecordID = null, [WorkflowExpression] Func<string> requestBodycRMType = null, [WorkflowExpression] Func<string> requestBodycRMOrgURL = null, [WorkflowExpression] Func<string> requestBodyinputPrompt = null, [WorkflowExpression] Func<int> requestBodytop = null, [WorkflowExpression] Func<int> requestBodyskip = null)
        {
            var apiCallPath = "/connector/contentSuggestions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xMsMessageId != null)
                callPayload.Headers["x-ms-message-id"] = ExpressionConverter.Convert(xMsMessageId);
            if (xMsConversationId != null)
                callPayload.Headers["x-ms-conversation-id"] = ExpressionConverter.Convert(xMsConversationId);
            var requestBody = new JObject();
            var requestBodypropCount = 0;
            var resourceDataObject = new JObject();
            var resourceDataObjectpropCount = 0;
            if (requestBodyresourceDataplainTextBody != null)
            {
                resourceDataObject["plaintextBody"] = ExpressionConverter.ConvertO(requestBodyresourceDataplainTextBody);
                resourceDataObjectpropCount++;
            }

            if (requestBodyresourceDatafullHTMLBody != null)
            {
                resourceDataObject["fullHtmlBody"] = ExpressionConverter.ConvertO(requestBodyresourceDatafullHTMLBody);
                resourceDataObjectpropCount++;
            }

            if (requestBodyresourceDatasubject != null)
            {
                resourceDataObject["subject"] = ExpressionConverter.ConvertO(requestBodyresourceDatasubject);
                resourceDataObjectpropCount++;
            }

            if (requestBodyresourceDatafrom != null)
            {
                resourceDataObject["from"] = ExpressionConverter.ConvertO(requestBodyresourceDatafrom);
                resourceDataObjectpropCount++;
            }

            if (requestBodyresourceDatato != null)
            {
                resourceDataObject["to"] = ExpressionConverter.ConvertO(requestBodyresourceDatato);
                resourceDataObjectpropCount++;
            }

            if (requestBodyresourceDatacC != null)
            {
                resourceDataObject["cc"] = ExpressionConverter.ConvertO(requestBodyresourceDatacC);
                resourceDataObjectpropCount++;
            }

            if (requestBodyresourceDatabCC != null)
            {
                resourceDataObject["bcc"] = ExpressionConverter.ConvertO(requestBodyresourceDatabCC);
                resourceDataObjectpropCount++;
            }

            if (requestBodyresourceDatasentDateTime != null)
            {
                resourceDataObject["sentDateTime"] = ExpressionConverter.ConvertO(requestBodyresourceDatasentDateTime);
                resourceDataObjectpropCount++;
            }

            if (requestBodyresourceDatatheGraphMessageId != null)
            {
                resourceDataObject["messageId"] = ExpressionConverter.ConvertO(requestBodyresourceDatatheGraphMessageId);
                resourceDataObjectpropCount++;
            }

            if (requestBodyresourceDatatheGraphConversationID != null)
            {
                resourceDataObject["conversationId"] = ExpressionConverter.ConvertO(requestBodyresourceDatatheGraphConversationID);
                resourceDataObjectpropCount++;
            }

            if (resourceDataObjectpropCount > 0)
            {
                requestBody["resourceData"] = resourceDataObject;
                requestBodypropCount++;
            }

            requestBodypropCount++;
            requestBody["resourceType"] = ExpressionConverter.ConvertO(requestBodyresourceType);
            if (requestBodyrecordType != null)
            {
                requestBody["recordType"] = ExpressionConverter.ConvertO(requestBodyrecordType);
                requestBodypropCount++;
            }

            if (requestBodyrecordID != null)
            {
                requestBody["recordId"] = ExpressionConverter.ConvertO(requestBodyrecordID);
                requestBodypropCount++;
            }

            if (requestBodycRMType != null)
            {
                requestBody["crmType"] = ExpressionConverter.ConvertO(requestBodycRMType);
                requestBodypropCount++;
            }

            if (requestBodycRMOrgURL != null)
            {
                requestBody["crmOrgUrl"] = ExpressionConverter.ConvertO(requestBodycRMOrgURL);
                requestBodypropCount++;
            }

            if (requestBodyinputPrompt != null)
            {
                requestBody["inputPrompt"] = ExpressionConverter.ConvertO(requestBodyinputPrompt);
                requestBodypropCount++;
            }

            if (requestBodytop != null)
            {
                requestBody["top"] = ExpressionConverter.ConvertO(requestBodytop);
                requestBodypropCount++;
            }

            if (requestBodyskip != null)
            {
                requestBody["skip"] = ExpressionConverter.ConvertO(requestBodyskip);
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