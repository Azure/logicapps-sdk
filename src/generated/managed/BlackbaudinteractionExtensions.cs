//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudinteraction
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudinteractionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionRead> ListActions(Expression<Func<string>> listId = null, Expression<Func<string>> computedStatus = null, Expression<Func<string>> statusCode = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var apiCallPath = "/constituent/v1/actions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (listId != null)
                callPayload.Queries["list_id"] = CSharpExpressionConverter.ConvertO(listId);
            if (computedStatus != null)
                callPayload.Queries["computed_status"] = CSharpExpressionConverter.ConvertO(computedStatus);
            if (statusCode != null)
                callPayload.Queries["status_code"] = CSharpExpressionConverter.ConvertO(statusCode);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (dateAdded != null)
                callPayload.Queries["date_added"] = CSharpExpressionConverter.ConvertO(dateAdded);
            if (lastModified != null)
                callPayload.Queries["last_modified"] = CSharpExpressionConverter.ConvertO(lastModified);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfActionRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IBodyWorkflowAction<ConstituentApiCreatedAction> CreateAction(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodydate, Expression<Func<bodycategoryInput>> bodycategory, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodysummary = null, Expression<Func<string>> bodynote = null, Expression<Func<bool>> bodycompleted = null, Expression<Func<string>> bodycompletedOn = null, Expression<Func<string>> bodystatus = null, Expression<Func<bodydirectionInput>> bodydirection = null, Expression<Func<string>> bodylocation = null, Expression<Func<string>> bodyopportunityID = null, Expression<Func<bodyoutcomeInput>> bodyoutcome = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendTime = null, Expression<Func<string>> bodyauthor = null, Expression<Func<string[]>> bodyfundraiserS = null)
        {
            var apiCallPath = "/constituent/v1/actions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = CSharpExpressionConverter.ConvertToken(bodyconstituentID);
            bodypropCount++;
            body["date"] = CSharpExpressionConverter.ConvertToken(bodydate);
            bodypropCount++;
            body["category"] = CSharpExpressionConverter.Convert(bodycategory);
            if (bodytype != null)
            {
                body["type"] = CSharpExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
            }

            if (bodysummary != null)
            {
                body["summary"] = CSharpExpressionConverter.ConvertToken(bodysummary);
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodynote);
                bodypropCount++;
            }

            if (bodycompleted != null)
            {
                body["completed"] = CSharpExpressionConverter.ConvertToken(bodycompleted);
                bodypropCount++;
            }

            if (bodycompletedOn != null)
            {
                body["completed_date"] = CSharpExpressionConverter.ConvertToken(bodycompletedOn);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = CSharpExpressionConverter.ConvertToken(bodystatus);
                bodypropCount++;
            }

            if (bodydirection != null)
            {
                body["direction"] = CSharpExpressionConverter.Convert(bodydirection);
                bodypropCount++;
            }

            if (bodylocation != null)
            {
                body["location"] = CSharpExpressionConverter.ConvertToken(bodylocation);
                bodypropCount++;
            }

            if (bodyopportunityID != null)
            {
                body["opportunity_id"] = CSharpExpressionConverter.ConvertToken(bodyopportunityID);
                bodypropCount++;
            }

            if (bodyoutcome != null)
            {
                body["outcome"] = CSharpExpressionConverter.Convert(bodyoutcome);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["priority"] = CSharpExpressionConverter.Convert(bodypriority);
                bodypropCount++;
            }

            if (bodystartTime != null)
            {
                body["start_time"] = CSharpExpressionConverter.ConvertToken(bodystartTime);
                bodypropCount++;
            }

            if (bodyendTime != null)
            {
                body["end_time"] = CSharpExpressionConverter.ConvertToken(bodyendTime);
                bodypropCount++;
            }

            if (bodyauthor != null)
            {
                body["author"] = CSharpExpressionConverter.ConvertToken(bodyauthor);
                bodypropCount++;
            }

            if (bodyfundraiserS != null)
            {
                body["fundraisers"] = CSharpExpressionConverter.ConvertToken(bodyfundraiserS);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedAction>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IBodyWorkflowAction<ConstituentApiActionRead> GetAction(Expression<Func<string>> actionId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(actionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiActionRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IWorkflowAction EditAction(Expression<Func<string>> actionId, Expression<Func<string>> bodydate = null, Expression<Func<bodycategoryInput>> bodycategory = null, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodysummary = null, Expression<Func<string>> bodynote = null, Expression<Func<bool>> bodycompleted = null, Expression<Func<string>> bodycompletedOn = null, Expression<Func<string>> bodystatus = null, Expression<Func<bodydirectionInput>> bodydirection = null, Expression<Func<string>> bodylocation = null, Expression<Func<string>> bodyopportunityID = null, Expression<Func<bodyoutcomeInput>> bodyoutcome = null, Expression<Func<bodypriorityInput>> bodypriority = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendTime = null, Expression<Func<string[]>> bodyfundraiserS = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(actionId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydate != null)
            {
                body["date"] = CSharpExpressionConverter.ConvertToken(bodydate);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["category"] = CSharpExpressionConverter.Convert(bodycategory);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = CSharpExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
            }

            if (bodysummary != null)
            {
                body["summary"] = CSharpExpressionConverter.ConvertToken(bodysummary);
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodynote);
                bodypropCount++;
            }

            if (bodycompleted != null)
            {
                body["completed"] = CSharpExpressionConverter.ConvertToken(bodycompleted);
                bodypropCount++;
            }

            if (bodycompletedOn != null)
            {
                body["completed_date"] = CSharpExpressionConverter.ConvertToken(bodycompletedOn);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = CSharpExpressionConverter.ConvertToken(bodystatus);
                bodypropCount++;
            }

            if (bodydirection != null)
            {
                body["direction"] = CSharpExpressionConverter.Convert(bodydirection);
                bodypropCount++;
            }

            if (bodylocation != null)
            {
                body["location"] = CSharpExpressionConverter.ConvertToken(bodylocation);
                bodypropCount++;
            }

            if (bodyopportunityID != null)
            {
                body["opportunity_id"] = CSharpExpressionConverter.ConvertToken(bodyopportunityID);
                bodypropCount++;
            }

            if (bodyoutcome != null)
            {
                body["outcome"] = CSharpExpressionConverter.Convert(bodyoutcome);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["priority"] = CSharpExpressionConverter.Convert(bodypriority);
                bodypropCount++;
            }

            if (bodystartTime != null)
            {
                body["start_time"] = CSharpExpressionConverter.ConvertToken(bodystartTime);
                bodypropCount++;
            }

            if (bodyendTime != null)
            {
                body["end_time"] = CSharpExpressionConverter.ConvertToken(bodyendTime);
                bodypropCount++;
            }

            if (bodyfundraiserS != null)
            {
                body["fundraisers"] = CSharpExpressionConverter.ConvertToken(bodyfundraiserS);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionAttachmentRead> ListActionAttachments(Expression<Func<string>> actionId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/{0}/attachments", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(actionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfActionAttachmentRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionCustomFieldRead> ListActionCustomFields(Expression<Func<string>> actionId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/{0}/customfields", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(actionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfActionCustomFieldRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IBodyWorkflowAction<ConstituentApiCreatedActionAttachment> CreateActionAttachment(Expression<Func<string>> bodyactionID, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileID = null, Expression<Func<string>> bodythumbnailID = null, Expression<Func<string[]>> bodytags = null)
        {
            var apiCallPath = "/constituent/v1/actions/attachments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["parent_id"] = CSharpExpressionConverter.ConvertToken(bodyactionID);
            bodypropCount++;
            body["type"] = CSharpExpressionConverter.Convert(bodytype);
            if (bodyname != null)
            {
                body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = CSharpExpressionConverter.ConvertToken(bodydate);
                bodypropCount++;
            }

            if (bodyuRL != null)
            {
                body["url"] = CSharpExpressionConverter.ConvertToken(bodyuRL);
                bodypropCount++;
            }

            if (bodyfileName != null)
            {
                body["file_name"] = CSharpExpressionConverter.ConvertToken(bodyfileName);
                bodypropCount++;
            }

            if (bodyfileID != null)
            {
                body["file_id"] = CSharpExpressionConverter.ConvertToken(bodyfileID);
                bodypropCount++;
            }

            if (bodythumbnailID != null)
            {
                body["thumbnail_id"] = CSharpExpressionConverter.ConvertToken(bodythumbnailID);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = CSharpExpressionConverter.ConvertToken(bodytags);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedActionAttachment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IWorkflowAction EditActionAttachment(Expression<Func<string>> attachmentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string[]>> bodytags = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/attachments/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachmentId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = CSharpExpressionConverter.ConvertToken(bodydate);
                bodypropCount++;
            }

            if (bodyuRL != null)
            {
                body["url"] = CSharpExpressionConverter.ConvertToken(bodyuRL);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = CSharpExpressionConverter.ConvertToken(bodytags);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IBodyWorkflowAction<ConstituentApiCreatedActionCustomField> CreateActionCustomField(Expression<Func<string>> bodyactionID, Expression<Func<string>> bodycategory, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = "/constituent/v1/actions/customfields";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["parent_id"] = CSharpExpressionConverter.ConvertToken(bodyactionID);
            bodypropCount++;
            body["category"] = CSharpExpressionConverter.ConvertToken(bodycategory);
            if (bodyvalue != null)
            {
                body["value"] = CSharpExpressionConverter.ConvertToken(bodyvalue);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = CSharpExpressionConverter.ConvertToken(bodydate);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["comment"] = CSharpExpressionConverter.ConvertToken(bodycomment);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedActionCustomField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IWorkflowAction EditActionCustomField(Expression<Func<string>> customFieldId, Expression<Func<string>> bodycategory = null, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/customfields/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(customFieldId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycategory != null)
            {
                body["category"] = CSharpExpressionConverter.ConvertToken(bodycategory);
                bodypropCount++;
            }

            if (bodyvalue != null)
            {
                body["value"] = CSharpExpressionConverter.ConvertToken(bodyvalue);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = CSharpExpressionConverter.ConvertToken(bodydate);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["comment"] = CSharpExpressionConverter.ConvertToken(bodycomment);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionRead> ListConstituentActions(Expression<Func<string>> constituentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/actions", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfActionRead>(callPayload);
        }
    }

    public class BlackbaudinteractionTriggers([ConnectionName] string connectionId)
    {
    }

    public class ConstituentApiApiCollectionOfActionRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiActionRead[] Value { get; set; }
    }

    public class ConstituentApiActionRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("completed_date")]
        public string CompletedOn { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("description")]
        public string Note { get; set; }

        [JsonProperty("direction")]
        public ConstituentApiActionReadDirectionType Direction { get; set; }

        [JsonProperty("fundraisers")]
        public string[] FundraiserS { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("opportunity_id")]
        public string OpportunityID { get; set; }

        [JsonProperty("outcome")]
        public ConstituentApiActionReadOutcomeType Outcome { get; set; }

        [JsonProperty("priority")]
        public ConstituentApiActionReadPriorityType Priority { get; set; }

        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_code")]
        public string StatusCode { get; set; }

        [JsonProperty("computed_status")]
        public ConstituentApiActionReadComputedStatusType ComputedStatus { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum ConstituentApiActionReadDirectionType
    {
        Inbound,
        Outbound
    }

    public enum ConstituentApiActionReadOutcomeType
    {
        Successful,
        Unsuccessful
    }

    public enum ConstituentApiActionReadPriorityType
    {
        Normal,
        High,
        Low
    }

    public enum ConstituentApiActionReadComputedStatusType
    {
        Open,
        Completed,
        PastDue
    }

    public class ConstituentApiCreatedAction
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodycategoryInput
    {
        [EnumMember(Value = "Phone Call")]
        PhoneCall,
        Meeting,
        Mailing,
        Email,
        [EnumMember(Value = "Task/Other")]
        TaskOther
    }

    public enum bodydirectionInput
    {
        Inbound,
        Outbound
    }

    public enum bodyoutcomeInput
    {
        Successful,
        Unsuccessful
    }

    public enum bodypriorityInput
    {
        Normal,
        High,
        Low
    }

    public class ConstituentApiApiCollectionOfActionAttachmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiActionAttachmentRead[] Value { get; set; }
    }

    public class ConstituentApiActionAttachmentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string ActionID { get; set; }

        [JsonProperty("type")]
        public ConstituentApiActionAttachmentReadTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_id")]
        public string FileID { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailID { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public enum ConstituentApiActionAttachmentReadTypeType
    {
        Link,
        Physical
    }

    public class ConstituentApiApiCollectionOfActionCustomFieldRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiActionCustomFieldRead[] Value { get; set; }
    }

    public class ConstituentApiActionCustomFieldRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string ActionID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public ConstituentApiActionCustomFieldReadTypeType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("text_value")]
        public string TextValue { get; set; }

        [JsonProperty("number_value")]
        public int NumberValue { get; set; }

        [JsonProperty("date_value")]
        public string DateValue { get; set; }

        [JsonProperty("currency_value")]
        public double CurrencyValue { get; set; }

        [JsonProperty("boolean_value")]
        public bool BooleanValue { get; set; }

        [JsonProperty("codetableentry_value")]
        public string TableEntryValue { get; set; }

        [JsonProperty("constituentid_value")]
        public string ConstituentIDValue { get; set; }

        [JsonProperty("fuzzydate_value")]
        public ConstituentApiActionCustomFieldReadFuzzyDateValueType FuzzyDateValue { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum ConstituentApiActionCustomFieldReadTypeType
    {
        Text,
        Number,
        Date,
        Currency,
        Boolean,
        CodeTableEntry,
        ConstituentId,
        FuzzyDate
    }

    public class ConstituentApiActionCustomFieldReadFuzzyDateValueType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiCreatedActionAttachment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodytypeInput
    {
        Link,
        Physical
    }

    public class ConstituentApiCreatedActionCustomField
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudinteraction;

    public partial class WorkflowManagedActions
    {
        public BlackbaudinteractionActions Blackbaudinteraction(string connectionId) => new BlackbaudinteractionActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudinteractionTriggers Blackbaudinteraction(string connectionId) => new BlackbaudinteractionTriggers(connectionId);
    }
}