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
        public IBodyWorkflowAction<ExternalRelatedRecordListResponseEnvelope> ScpGetRelatedRecords([WorkflowExpression] Func<recordTypeInput> recordType, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<crmTypeInput> crmType = null, [WorkflowExpression] Func<string> crmOrgUrl = null)
        {
            SourceExpression.Validate(recordType, nameof(recordType), required: true);
            SourceExpression.Validate(recordId, nameof(recordId), required: true);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(crmType, nameof(crmType), required: false);
            SourceExpression.Validate(crmOrgUrl, nameof(crmOrgUrl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/connector/relatedRecords";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["recordType"] = SourceExpressionConverter.Convert(recordType);
                callPayload.Queries["recordId"] = SourceExpressionConverter.ConvertO(recordId);
                if (top != null)
                    callPayload.Queries["top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["skip"] = SourceExpressionConverter.ConvertO(skip);
                callPayload.Queries["crmType"] = Convert.ToString("Salesforce");
                if (crmType != null)
                    callPayload.Queries["crmType"] = SourceExpressionConverter.Convert(crmType);
                if (crmOrgUrl != null)
                    callPayload.Queries["crmOrgUrl"] = SourceExpressionConverter.ConvertO(crmOrgUrl);
                return callPayload;
            }

            return new ApiConnectionAction<ExternalRelatedRecordListResponseEnvelope>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicforcopilotfor")]
        public IBodyWorkflowAction<ActivityListResponseEnvelope> ScpGetRelatedActivities([WorkflowExpression] Func<recordTypeInput> recordType, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<string> startDateTime = null, [WorkflowExpression] Func<string> endDateTime = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<crmTypeInput> crmType = null, [WorkflowExpression] Func<string> crmOrgUrl = null)
        {
            SourceExpression.Validate(recordType, nameof(recordType), required: true);
            SourceExpression.Validate(recordId, nameof(recordId), required: true);
            SourceExpression.Validate(startDateTime, nameof(startDateTime), required: false);
            SourceExpression.Validate(endDateTime, nameof(endDateTime), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(crmType, nameof(crmType), required: false);
            SourceExpression.Validate(crmOrgUrl, nameof(crmOrgUrl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/connector/relatedActivities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["recordType"] = SourceExpressionConverter.Convert(recordType);
                callPayload.Queries["recordId"] = SourceExpressionConverter.ConvertO(recordId);
                if (startDateTime != null)
                    callPayload.Queries["startDateTime"] = SourceExpressionConverter.ConvertO(startDateTime);
                if (endDateTime != null)
                    callPayload.Queries["endDateTime"] = SourceExpressionConverter.ConvertO(endDateTime);
                if (top != null)
                    callPayload.Queries["top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["skip"] = SourceExpressionConverter.ConvertO(skip);
                if (crmType != null)
                    callPayload.Queries["crmType"] = SourceExpressionConverter.Convert(crmType);
                if (crmOrgUrl != null)
                    callPayload.Queries["crmOrgUrl"] = SourceExpressionConverter.ConvertO(crmOrgUrl);
                return callPayload;
            }

            return new ApiConnectionAction<ActivityListResponseEnvelope>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicforcopilotfor")]
        public IBodyWorkflowAction<SalesHighlightListResponseEnvelope> ScpGetSalesHighlights([WorkflowExpression] Func<recordTypeInput> recordType, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<string> crmType = null, [WorkflowExpression] Func<string> crmOrgUrl = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null)
        {
            SourceExpression.Validate(recordType, nameof(recordType), required: true);
            SourceExpression.Validate(recordId, nameof(recordId), required: true);
            SourceExpression.Validate(crmType, nameof(crmType), required: false);
            SourceExpression.Validate(crmOrgUrl, nameof(crmOrgUrl), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/connector/salesHighlights";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["recordType"] = SourceExpressionConverter.Convert(recordType);
                callPayload.Queries["recordId"] = SourceExpressionConverter.ConvertO(recordId);
                if (crmType != null)
                    callPayload.Queries["crmType"] = SourceExpressionConverter.ConvertO(crmType);
                if (crmOrgUrl != null)
                    callPayload.Queries["crmOrgUrl"] = SourceExpressionConverter.ConvertO(crmOrgUrl);
                if (top != null)
                    callPayload.Queries["top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["skip"] = SourceExpressionConverter.ConvertO(skip);
                return callPayload;
            }

            return new ApiConnectionAction<SalesHighlightListResponseEnvelope>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicforcopilotfor")]
        public IBodyWorkflowAction<EmailSummeryResponseEnvelope> ScpGetEmailInsights([WorkflowExpression] Func<string> emailContacts, [WorkflowExpression] Func<string> recordType = null, [WorkflowExpression] Func<string> recordId = null, [WorkflowExpression] Func<string> crmType = null, [WorkflowExpression] Func<string> crmOrgUrl = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null)
        {
            SourceExpression.Validate(emailContacts, nameof(emailContacts), required: true);
            SourceExpression.Validate(recordType, nameof(recordType), required: false);
            SourceExpression.Validate(recordId, nameof(recordId), required: false);
            SourceExpression.Validate(crmType, nameof(crmType), required: false);
            SourceExpression.Validate(crmOrgUrl, nameof(crmOrgUrl), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/connector/emailInsights";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recordType != null)
                    callPayload.Queries["recordType"] = SourceExpressionConverter.ConvertO(recordType);
                if (recordId != null)
                    callPayload.Queries["recordId"] = SourceExpressionConverter.ConvertO(recordId);
                if (crmType != null)
                    callPayload.Queries["crmType"] = SourceExpressionConverter.ConvertO(crmType);
                if (crmOrgUrl != null)
                    callPayload.Queries["crmOrgUrl"] = SourceExpressionConverter.ConvertO(crmOrgUrl);
                callPayload.Queries["emailContacts"] = SourceExpressionConverter.ConvertO(emailContacts);
                if (top != null)
                    callPayload.Queries["Top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["Skip"] = SourceExpressionConverter.ConvertO(skip);
                return callPayload;
            }

            return new ApiConnectionAction<EmailSummeryResponseEnvelope>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismicforcopilotfor")]
        public IBodyWorkflowAction<EmailDraftResponseEnvelope> ScpGetContentSuggestions([WorkflowExpression] Func<string> requestBodyresourceType, [WorkflowExpression] Func<string> xMsMessageId = null, [WorkflowExpression] Func<string> xMsConversationId = null, [WorkflowExpression] Func<string> requestBodyresourceDataplainTextBody = null, [WorkflowExpression] Func<string> requestBodyresourceDatafullHTMLBody = null, [WorkflowExpression] Func<string> requestBodyresourceDatasubject = null, [WorkflowExpression] Func<string> requestBodyresourceDatafrom = null, [WorkflowExpression] Func<string[]> requestBodyresourceDatato = null, [WorkflowExpression] Func<string[]> requestBodyresourceDatacC = null, [WorkflowExpression] Func<string[]> requestBodyresourceDatabCC = null, [WorkflowExpression] Func<string> requestBodyresourceDatasentDateTime = null, [WorkflowExpression] Func<string> requestBodyresourceDatatheGraphMessageId = null, [WorkflowExpression] Func<string> requestBodyresourceDatatheGraphConversationID = null, [WorkflowExpression] Func<string> requestBodyrecordType = null, [WorkflowExpression] Func<string> requestBodyrecordID = null, [WorkflowExpression] Func<string> requestBodycRMType = null, [WorkflowExpression] Func<string> requestBodycRMOrgURL = null, [WorkflowExpression] Func<string> requestBodyinputPrompt = null, [WorkflowExpression] Func<int> requestBodytop = null, [WorkflowExpression] Func<int> requestBodyskip = null)
        {
            SourceExpression.Validate(requestBodyresourceType, nameof(requestBodyresourceType), required: true);
            SourceExpression.Validate(xMsMessageId, nameof(xMsMessageId), required: false);
            SourceExpression.Validate(xMsConversationId, nameof(xMsConversationId), required: false);
            SourceExpression.Validate(requestBodyresourceDataplainTextBody, nameof(requestBodyresourceDataplainTextBody), required: false);
            SourceExpression.Validate(requestBodyresourceDatafullHTMLBody, nameof(requestBodyresourceDatafullHTMLBody), required: false);
            SourceExpression.Validate(requestBodyresourceDatasubject, nameof(requestBodyresourceDatasubject), required: false);
            SourceExpression.Validate(requestBodyresourceDatafrom, nameof(requestBodyresourceDatafrom), required: false);
            SourceExpression.Validate(requestBodyresourceDatato, nameof(requestBodyresourceDatato), required: false);
            SourceExpression.Validate(requestBodyresourceDatacC, nameof(requestBodyresourceDatacC), required: false);
            SourceExpression.Validate(requestBodyresourceDatabCC, nameof(requestBodyresourceDatabCC), required: false);
            SourceExpression.Validate(requestBodyresourceDatasentDateTime, nameof(requestBodyresourceDatasentDateTime), required: false);
            SourceExpression.Validate(requestBodyresourceDatatheGraphMessageId, nameof(requestBodyresourceDatatheGraphMessageId), required: false);
            SourceExpression.Validate(requestBodyresourceDatatheGraphConversationID, nameof(requestBodyresourceDatatheGraphConversationID), required: false);
            SourceExpression.Validate(requestBodyrecordType, nameof(requestBodyrecordType), required: false);
            SourceExpression.Validate(requestBodyrecordID, nameof(requestBodyrecordID), required: false);
            SourceExpression.Validate(requestBodycRMType, nameof(requestBodycRMType), required: false);
            SourceExpression.Validate(requestBodycRMOrgURL, nameof(requestBodycRMOrgURL), required: false);
            SourceExpression.Validate(requestBodyinputPrompt, nameof(requestBodyinputPrompt), required: false);
            SourceExpression.Validate(requestBodytop, nameof(requestBodytop), required: false);
            SourceExpression.Validate(requestBodyskip, nameof(requestBodyskip), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/connector/contentSuggestions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xMsMessageId != null)
                    callPayload.Headers["x-ms-message-id"] = SourceExpressionConverter.ConvertO(xMsMessageId);
                if (xMsConversationId != null)
                    callPayload.Headers["x-ms-conversation-id"] = SourceExpressionConverter.ConvertO(xMsConversationId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                var resourceDataObject = new JObject();
                var resourceDataObjectpropCount = 0;
                if (requestBodyresourceDataplainTextBody != null)
                {
                    resourceDataObject["plaintextBody"] = SourceExpressionConverter.ConvertToken(requestBodyresourceDataplainTextBody);
                    resourceDataObjectpropCount++;
                }

                if (requestBodyresourceDatafullHTMLBody != null)
                {
                    resourceDataObject["fullHtmlBody"] = SourceExpressionConverter.ConvertToken(requestBodyresourceDatafullHTMLBody);
                    resourceDataObjectpropCount++;
                }

                if (requestBodyresourceDatasubject != null)
                {
                    resourceDataObject["subject"] = SourceExpressionConverter.ConvertToken(requestBodyresourceDatasubject);
                    resourceDataObjectpropCount++;
                }

                if (requestBodyresourceDatafrom != null)
                {
                    resourceDataObject["from"] = SourceExpressionConverter.ConvertToken(requestBodyresourceDatafrom);
                    resourceDataObjectpropCount++;
                }

                if (requestBodyresourceDatato != null)
                {
                    resourceDataObject["to"] = SourceExpressionConverter.ConvertToken(requestBodyresourceDatato);
                    resourceDataObjectpropCount++;
                }

                if (requestBodyresourceDatacC != null)
                {
                    resourceDataObject["cc"] = SourceExpressionConverter.ConvertToken(requestBodyresourceDatacC);
                    resourceDataObjectpropCount++;
                }

                if (requestBodyresourceDatabCC != null)
                {
                    resourceDataObject["bcc"] = SourceExpressionConverter.ConvertToken(requestBodyresourceDatabCC);
                    resourceDataObjectpropCount++;
                }

                if (requestBodyresourceDatasentDateTime != null)
                {
                    resourceDataObject["sentDateTime"] = SourceExpressionConverter.ConvertToken(requestBodyresourceDatasentDateTime);
                    resourceDataObjectpropCount++;
                }

                if (requestBodyresourceDatatheGraphMessageId != null)
                {
                    resourceDataObject["messageId"] = SourceExpressionConverter.ConvertToken(requestBodyresourceDatatheGraphMessageId);
                    resourceDataObjectpropCount++;
                }

                if (requestBodyresourceDatatheGraphConversationID != null)
                {
                    resourceDataObject["conversationId"] = SourceExpressionConverter.ConvertToken(requestBodyresourceDatatheGraphConversationID);
                    resourceDataObjectpropCount++;
                }

                if (resourceDataObjectpropCount > 0)
                {
                    requestBody["resourceData"] = resourceDataObject;
                    requestBodypropCount++;
                }

                requestBodypropCount++;
                requestBody["resourceType"] = SourceExpressionConverter.ConvertToken(requestBodyresourceType);
                if (requestBodyrecordType != null)
                {
                    requestBody["recordType"] = SourceExpressionConverter.ConvertToken(requestBodyrecordType);
                    requestBodypropCount++;
                }

                if (requestBodyrecordID != null)
                {
                    requestBody["recordId"] = SourceExpressionConverter.ConvertToken(requestBodyrecordID);
                    requestBodypropCount++;
                }

                if (requestBodycRMType != null)
                {
                    requestBody["crmType"] = SourceExpressionConverter.ConvertToken(requestBodycRMType);
                    requestBodypropCount++;
                }

                if (requestBodycRMOrgURL != null)
                {
                    requestBody["crmOrgUrl"] = SourceExpressionConverter.ConvertToken(requestBodycRMOrgURL);
                    requestBodypropCount++;
                }

                if (requestBodyinputPrompt != null)
                {
                    requestBody["inputPrompt"] = SourceExpressionConverter.ConvertToken(requestBodyinputPrompt);
                    requestBodypropCount++;
                }

                if (requestBodytop != null)
                {
                    requestBody["top"] = SourceExpressionConverter.ConvertToken(requestBodytop);
                    requestBodypropCount++;
                }

                if (requestBodyskip != null)
                {
                    requestBody["skip"] = SourceExpressionConverter.ConvertToken(requestBodyskip);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EmailDraftResponseEnvelope>(BuildSourceInput);
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