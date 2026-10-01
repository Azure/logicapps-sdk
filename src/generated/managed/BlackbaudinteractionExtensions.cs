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
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionRead> ListActions([WorkflowExpression] Func<string> listId = null, [WorkflowExpression] Func<string> computedStatus = null, [WorkflowExpression] Func<string> statusCode = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> dateAdded = null, [WorkflowExpression] Func<string> lastModified = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/actions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (listId != null)
                    callPayload.Queries["list_id"] = SourceExpressionConverter.ConvertO(listId);
                if (computedStatus != null)
                    callPayload.Queries["computed_status"] = SourceExpressionConverter.ConvertO(computedStatus);
                if (statusCode != null)
                    callPayload.Queries["status_code"] = SourceExpressionConverter.ConvertO(statusCode);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (dateAdded != null)
                    callPayload.Queries["date_added"] = SourceExpressionConverter.ConvertO(dateAdded);
                if (lastModified != null)
                    callPayload.Queries["last_modified"] = SourceExpressionConverter.ConvertO(lastModified);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfActionRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IBodyWorkflowAction<ConstituentApiCreatedAction> CreateAction([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<bodycategoryInput> bodycategory, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodysummary = null, [WorkflowExpression] Func<string> bodynote = null, [WorkflowExpression] Func<bool> bodycompleted = null, [WorkflowExpression] Func<string> bodycompletedOn = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bodydirectionInput> bodydirection = null, [WorkflowExpression] Func<string> bodylocation = null, [WorkflowExpression] Func<string> bodyopportunityId = null, [WorkflowExpression] Func<bodyoutcomeInput> bodyoutcome = null, [WorkflowExpression] Func<bodypriorityInput> bodypriority = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<string> bodyauthor = null, [WorkflowExpression] Func<string[]> bodyfundraiserS = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/actions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                bodypropCount++;
                body["category"] = SourceExpressionConverter.Convert(bodycategory);
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodysummary != null)
                {
                    body["summary"] = SourceExpressionConverter.ConvertToken(bodysummary);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodynote);
                    bodypropCount++;
                }

                if (bodycompleted != null)
                {
                    body["completed"] = SourceExpressionConverter.ConvertToken(bodycompleted);
                    bodypropCount++;
                }

                if (bodycompletedOn != null)
                {
                    body["completed_date"] = SourceExpressionConverter.ConvertToken(bodycompletedOn);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodydirection != null)
                {
                    body["direction"] = SourceExpressionConverter.Convert(bodydirection);
                    bodypropCount++;
                }

                if (bodylocation != null)
                {
                    body["location"] = SourceExpressionConverter.ConvertToken(bodylocation);
                    bodypropCount++;
                }

                if (bodyopportunityId != null)
                {
                    body["opportunity_id"] = SourceExpressionConverter.ConvertToken(bodyopportunityId);
                    bodypropCount++;
                }

                if (bodyoutcome != null)
                {
                    body["outcome"] = SourceExpressionConverter.Convert(bodyoutcome);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.Convert(bodypriority);
                    bodypropCount++;
                }

                if (bodystartTime != null)
                {
                    body["start_time"] = SourceExpressionConverter.ConvertToken(bodystartTime);
                    bodypropCount++;
                }

                if (bodyendTime != null)
                {
                    body["end_time"] = SourceExpressionConverter.ConvertToken(bodyendTime);
                    bodypropCount++;
                }

                if (bodyauthor != null)
                {
                    body["author"] = SourceExpressionConverter.ConvertToken(bodyauthor);
                    bodypropCount++;
                }

                if (bodyfundraiserS != null)
                {
                    body["fundraisers"] = SourceExpressionConverter.ConvertToken(bodyfundraiserS);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedAction>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IBodyWorkflowAction<ConstituentApiActionRead> GetAction([WorkflowExpression] Func<string> actionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(actionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiActionRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IWorkflowAction EditAction([WorkflowExpression] Func<string> actionId, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<bodycategoryInput> bodycategory = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodysummary = null, [WorkflowExpression] Func<string> bodynote = null, [WorkflowExpression] Func<bool> bodycompleted = null, [WorkflowExpression] Func<string> bodycompletedOn = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bodydirectionInput> bodydirection = null, [WorkflowExpression] Func<string> bodylocation = null, [WorkflowExpression] Func<string> bodyopportunityId = null, [WorkflowExpression] Func<bodyoutcomeInput> bodyoutcome = null, [WorkflowExpression] Func<bodypriorityInput> bodypriority = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<string[]> bodyfundraiserS = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(actionId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.Convert(bodycategory);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodysummary != null)
                {
                    body["summary"] = SourceExpressionConverter.ConvertToken(bodysummary);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodynote);
                    bodypropCount++;
                }

                if (bodycompleted != null)
                {
                    body["completed"] = SourceExpressionConverter.ConvertToken(bodycompleted);
                    bodypropCount++;
                }

                if (bodycompletedOn != null)
                {
                    body["completed_date"] = SourceExpressionConverter.ConvertToken(bodycompletedOn);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodydirection != null)
                {
                    body["direction"] = SourceExpressionConverter.Convert(bodydirection);
                    bodypropCount++;
                }

                if (bodylocation != null)
                {
                    body["location"] = SourceExpressionConverter.ConvertToken(bodylocation);
                    bodypropCount++;
                }

                if (bodyopportunityId != null)
                {
                    body["opportunity_id"] = SourceExpressionConverter.ConvertToken(bodyopportunityId);
                    bodypropCount++;
                }

                if (bodyoutcome != null)
                {
                    body["outcome"] = SourceExpressionConverter.Convert(bodyoutcome);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.Convert(bodypriority);
                    bodypropCount++;
                }

                if (bodystartTime != null)
                {
                    body["start_time"] = SourceExpressionConverter.ConvertToken(bodystartTime);
                    bodypropCount++;
                }

                if (bodyendTime != null)
                {
                    body["end_time"] = SourceExpressionConverter.ConvertToken(bodyendTime);
                    bodypropCount++;
                }

                if (bodyfundraiserS != null)
                {
                    body["fundraisers"] = SourceExpressionConverter.ConvertToken(bodyfundraiserS);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionAttachmentRead> ListActionAttachments([WorkflowExpression] Func<string> actionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/{0}/attachments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(actionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfActionAttachmentRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionCustomFieldRead> ListActionCustomFields([WorkflowExpression] Func<string> actionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/{0}/customfields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(actionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfActionCustomFieldRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IBodyWorkflowAction<ConstituentApiCreatedActionAttachment> CreateActionAttachment([WorkflowExpression] Func<string> bodyactionId, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string> bodyfileName = null, [WorkflowExpression] Func<string> bodyfileId = null, [WorkflowExpression] Func<string> bodythumbnailId = null, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/actions/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = SourceExpressionConverter.ConvertToken(bodyactionId);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyuRL);
                    bodypropCount++;
                }

                if (bodyfileName != null)
                {
                    body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                    bodypropCount++;
                }

                if (bodyfileId != null)
                {
                    body["file_id"] = SourceExpressionConverter.ConvertToken(bodyfileId);
                    bodypropCount++;
                }

                if (bodythumbnailId != null)
                {
                    body["thumbnail_id"] = SourceExpressionConverter.ConvertToken(bodythumbnailId);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedActionAttachment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IWorkflowAction EditActionAttachment([WorkflowExpression] Func<string> attachmentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/attachments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachmentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyuRL);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IBodyWorkflowAction<ConstituentApiCreatedActionCustomField> CreateActionCustomField([WorkflowExpression] Func<string> bodyactionId, [WorkflowExpression] Func<string> bodycategory, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/actions/customfields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = SourceExpressionConverter.ConvertToken(bodyactionId);
                bodypropCount++;
                body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedActionCustomField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IWorkflowAction EditActionCustomField([WorkflowExpression] Func<string> customFieldId, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/actions/customfields/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customFieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudinteraction")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfActionRead> ListConstituentActions([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/actions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfActionRead>(BuildSourceInput);
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