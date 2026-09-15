//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudprospects
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudprospectsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<ConstituentApiProspectStatusRead> GetConstituentProspectStatus(Expression<Func<string>> constituentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/prospectstatus", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiProspectStatusRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfRatingRead> ListConstituentRatings(Expression<Func<string>> constituentId, Expression<Func<bool>> includeInactive = null, Expression<Func<bool>> mostRecentOnly = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/ratings", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = CSharpExpressionConverter.ConvertO(includeInactive);
            if (mostRecentOnly != null)
                callPayload.Queries["most_recent_only"] = CSharpExpressionConverter.ConvertO(mostRecentOnly);
            return new ApiConnectionAction<ConstituentApiApiCollectionOfRatingRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentRating> CreateConstituentRating(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodysource, Expression<Func<string>> bodycategory, Expression<Func<string>> bodydate, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodycomments = null)
        {
            var apiCallPath = "/constituent/v1/ratings";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = CSharpExpressionConverter.ConvertToken(bodyconstituentID);
            bodypropCount++;
            body["source"] = CSharpExpressionConverter.ConvertToken(bodysource);
            bodypropCount++;
            body["category"] = CSharpExpressionConverter.ConvertToken(bodycategory);
            bodypropCount++;
            body["date"] = CSharpExpressionConverter.ConvertToken(bodydate);
            if (bodyvalue != null)
            {
                body["value"] = CSharpExpressionConverter.ConvertToken(bodyvalue);
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comment"] = CSharpExpressionConverter.ConvertToken(bodycomments);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentRating>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<OpportunityApiApiCollectionOfOpportunityRead> ListOpportunities(Expression<Func<string>> listId = null, Expression<Func<string>> constituentId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<bool>> includeInactive = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var apiCallPath = "/opportunity/v1/opportunities";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (listId != null)
                callPayload.Queries["list_id"] = CSharpExpressionConverter.ConvertO(listId);
            if (constituentId != null)
                callPayload.Queries["constituent_id"] = CSharpExpressionConverter.ConvertO(constituentId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            if (includeInactive != null)
                callPayload.Queries["include_inactive"] = CSharpExpressionConverter.ConvertO(includeInactive);
            if (dateAdded != null)
                callPayload.Queries["date_added"] = CSharpExpressionConverter.ConvertO(dateAdded);
            if (lastModified != null)
                callPayload.Queries["last_modified"] = CSharpExpressionConverter.ConvertO(lastModified);
            return new ApiConnectionAction<OpportunityApiApiCollectionOfOpportunityRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<OpportunityApiCreatedOpportunity> CreateOpportunity(Expression<Func<string>> bodyconstituentID, Expression<Func<string>> bodypurpose, Expression<Func<string>> bodyname, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodydeadline = null, Expression<Func<string>> bodyaskDate = null, Expression<Func<double>> bodyaskAmountvalue = null, Expression<Func<string>> bodyexpectedDate = null, Expression<Func<double>> bodyexpectedAmountvalue = null, Expression<Func<string>> bodyfundedDate = null, Expression<Func<double>> bodyfundedAmountvalue = null, Expression<Func<string>> bodycampaignID = null, Expression<Func<string>> bodyfundID = null, Expression<Func<OpportunityApiFundraiser[]>> bodyfundraiserS = null, Expression<Func<bool>> bodyinactive = null)
        {
            var apiCallPath = "/opportunity/v1/opportunities";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = CSharpExpressionConverter.ConvertToken(bodyconstituentID);
            bodypropCount++;
            body["purpose"] = CSharpExpressionConverter.ConvertToken(bodypurpose);
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            if (bodystatus != null)
            {
                body["status"] = CSharpExpressionConverter.ConvertToken(bodystatus);
                bodypropCount++;
            }

            if (bodydeadline != null)
            {
                body["deadline"] = CSharpExpressionConverter.ConvertToken(bodydeadline);
                bodypropCount++;
            }

            if (bodyaskDate != null)
            {
                body["ask_date"] = CSharpExpressionConverter.ConvertToken(bodyaskDate);
                bodypropCount++;
            }

            var askAmountObject = new JObject();
            var askAmountObjectpropCount = 0;
            if (bodyaskAmountvalue != null)
            {
                askAmountObject["value"] = CSharpExpressionConverter.ConvertToken(bodyaskAmountvalue);
                askAmountObjectpropCount++;
            }

            if (askAmountObjectpropCount > 0)
            {
                body["ask_amount"] = askAmountObject;
                bodypropCount++;
            }

            if (bodyexpectedDate != null)
            {
                body["expected_date"] = CSharpExpressionConverter.ConvertToken(bodyexpectedDate);
                bodypropCount++;
            }

            var expectedAmountObject = new JObject();
            var expectedAmountObjectpropCount = 0;
            if (bodyexpectedAmountvalue != null)
            {
                expectedAmountObject["value"] = CSharpExpressionConverter.ConvertToken(bodyexpectedAmountvalue);
                expectedAmountObjectpropCount++;
            }

            if (expectedAmountObjectpropCount > 0)
            {
                body["expected_amount"] = expectedAmountObject;
                bodypropCount++;
            }

            if (bodyfundedDate != null)
            {
                body["funded_date"] = CSharpExpressionConverter.ConvertToken(bodyfundedDate);
                bodypropCount++;
            }

            var fundedAmountObject = new JObject();
            var fundedAmountObjectpropCount = 0;
            if (bodyfundedAmountvalue != null)
            {
                fundedAmountObject["value"] = CSharpExpressionConverter.ConvertToken(bodyfundedAmountvalue);
                fundedAmountObjectpropCount++;
            }

            if (fundedAmountObjectpropCount > 0)
            {
                body["funded_amount"] = fundedAmountObject;
                bodypropCount++;
            }

            if (bodycampaignID != null)
            {
                body["campaign_id"] = CSharpExpressionConverter.ConvertToken(bodycampaignID);
                bodypropCount++;
            }

            if (bodyfundID != null)
            {
                body["fund_id"] = CSharpExpressionConverter.ConvertToken(bodyfundID);
                bodypropCount++;
            }

            if (bodyfundraiserS != null)
            {
                body["fundraisers"] = CSharpExpressionConverter.ConvertToken(bodyfundraiserS);
                bodypropCount++;
            }

            if (bodyinactive != null)
            {
                body["inactive"] = CSharpExpressionConverter.ConvertToken(bodyinactive);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<OpportunityApiCreatedOpportunity>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<OpportunityApiOpportunityRead> GetOpportunity(Expression<Func<string>> opportunityId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/opportunity/v1/opportunities/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(opportunityId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<OpportunityApiOpportunityRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IWorkflowAction EditOpportunity(Expression<Func<string>> opportunityId, Expression<Func<string>> bodypurpose = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodydeadline = null, Expression<Func<string>> bodyaskDate = null, Expression<Func<double>> bodyaskAmountvalue = null, Expression<Func<string>> bodyexpectedDate = null, Expression<Func<double>> bodyexpectedAmountvalue = null, Expression<Func<string>> bodyfundedDate = null, Expression<Func<double>> bodyfundedAmountvalue = null, Expression<Func<string>> bodycampaignID = null, Expression<Func<string>> bodyfundID = null, Expression<Func<OpportunityApiFundraiser[]>> bodyfundraiserS = null, Expression<Func<bool>> bodyinactive = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/opportunity/v1/opportunities/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(opportunityId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypurpose != null)
            {
                body["purpose"] = CSharpExpressionConverter.ConvertToken(bodypurpose);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = CSharpExpressionConverter.ConvertToken(bodystatus);
                bodypropCount++;
            }

            if (bodydeadline != null)
            {
                body["deadline"] = CSharpExpressionConverter.ConvertToken(bodydeadline);
                bodypropCount++;
            }

            if (bodyaskDate != null)
            {
                body["ask_date"] = CSharpExpressionConverter.ConvertToken(bodyaskDate);
                bodypropCount++;
            }

            var askAmountObject = new JObject();
            var askAmountObjectpropCount = 0;
            if (bodyaskAmountvalue != null)
            {
                askAmountObject["value"] = CSharpExpressionConverter.ConvertToken(bodyaskAmountvalue);
                askAmountObjectpropCount++;
            }

            if (askAmountObjectpropCount > 0)
            {
                body["ask_amount"] = askAmountObject;
                bodypropCount++;
            }

            if (bodyexpectedDate != null)
            {
                body["expected_date"] = CSharpExpressionConverter.ConvertToken(bodyexpectedDate);
                bodypropCount++;
            }

            var expectedAmountObject = new JObject();
            var expectedAmountObjectpropCount = 0;
            if (bodyexpectedAmountvalue != null)
            {
                expectedAmountObject["value"] = CSharpExpressionConverter.ConvertToken(bodyexpectedAmountvalue);
                expectedAmountObjectpropCount++;
            }

            if (expectedAmountObjectpropCount > 0)
            {
                body["expected_amount"] = expectedAmountObject;
                bodypropCount++;
            }

            if (bodyfundedDate != null)
            {
                body["funded_date"] = CSharpExpressionConverter.ConvertToken(bodyfundedDate);
                bodypropCount++;
            }

            var fundedAmountObject = new JObject();
            var fundedAmountObjectpropCount = 0;
            if (bodyfundedAmountvalue != null)
            {
                fundedAmountObject["value"] = CSharpExpressionConverter.ConvertToken(bodyfundedAmountvalue);
                fundedAmountObjectpropCount++;
            }

            if (fundedAmountObjectpropCount > 0)
            {
                body["funded_amount"] = fundedAmountObject;
                bodypropCount++;
            }

            if (bodycampaignID != null)
            {
                body["campaign_id"] = CSharpExpressionConverter.ConvertToken(bodycampaignID);
                bodypropCount++;
            }

            if (bodyfundID != null)
            {
                body["fund_id"] = CSharpExpressionConverter.ConvertToken(bodyfundID);
                bodypropCount++;
            }

            if (bodyfundraiserS != null)
            {
                body["fundraisers"] = CSharpExpressionConverter.ConvertToken(bodyfundraiserS);
                bodypropCount++;
            }

            if (bodyinactive != null)
            {
                body["inactive"] = CSharpExpressionConverter.ConvertToken(bodyinactive);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<OpportunityApiApiCollectionOfOpportunityAttachmentRead> ListOpportunityAttachments(Expression<Func<string>> opportunityId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/opportunity/v1/opportunities/{0}/attachments", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(opportunityId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<OpportunityApiApiCollectionOfOpportunityAttachmentRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<OpportunityApiApiCollectionOfOpportunityCustomFieldRead> ListOpportunityCustomFields(Expression<Func<string>> opportunityId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/opportunity/v1/opportunities/{0}/customfields", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(opportunityId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<OpportunityApiApiCollectionOfOpportunityCustomFieldRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<OpportunityApiCreatedOpportunityAttachment> CreateOpportunityAttachment(Expression<Func<string>> bodyopportunityID, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileID = null, Expression<Func<string>> bodythumbnailID = null, Expression<Func<string[]>> bodytags = null)
        {
            var apiCallPath = "/opportunity/v1/opportunities/attachments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["parent_id"] = CSharpExpressionConverter.ConvertToken(bodyopportunityID);
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

            return new ApiConnectionAction<OpportunityApiCreatedOpportunityAttachment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IWorkflowAction EditOpportunityAttachment(Expression<Func<string>> attachmentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string[]>> bodytags = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/opportunity/v1/opportunities/attachments/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachmentId, 1));
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IBodyWorkflowAction<OpportunityApiCreatedOpportunityCustomField> CreateOpportunityCustomField(Expression<Func<string>> bodyopportunityID, Expression<Func<string>> bodycategory, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = "/opportunity/v1/opportunities/customfields";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["parent_id"] = CSharpExpressionConverter.ConvertToken(bodyopportunityID);
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

            return new ApiConnectionAction<OpportunityApiCreatedOpportunityCustomField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudprospects")]
        public IWorkflowAction EditOpportunityCustomField(Expression<Func<string>> customFieldId, Expression<Func<string>> bodycategory = null, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/opportunity/v1/opportunities/customfields/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(customFieldId, 1));
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
    }

    public class BlackbaudprospectsTriggers([ConnectionName] string connectionId)
    {
    }

    public class ConstituentApiProspectStatusRead
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("days_elapsed")]
        public int DaysElapsed { get; set; }

        [JsonProperty("start")]
        public string StartDate { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }

    public class ConstituentApiApiCollectionOfRatingRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiRatingRead[] Value { get; set; }
    }

    public class ConstituentApiRatingRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("value")]
        public JToken Description { get; set; }

        [JsonProperty("comment")]
        public string Comments { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("type")]
        public ConstituentApiRatingReadTypeType Type { get; set; }
    }

    public enum ConstituentApiRatingReadTypeType
    {
        Text,
        Number,
        DateTime,
        Currency,
        Boolean,
        CodeTable,
        Unknown
    }

    public class ConstituentApiCreatedConstituentRating
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class OpportunityApiApiCollectionOfOpportunityRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public OpportunityApiOpportunityRead[] Value { get; set; }
    }

    public class OpportunityApiOpportunityRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("purpose")]
        public string Purpose { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("deadline")]
        public string Deadline { get; set; }

        [JsonProperty("ask_date")]
        public string AskDate { get; set; }

        [JsonProperty("ask_amount")]
        public OpportunityApiOpportunityReadAskAmountType AskAmount { get; set; }

        [JsonProperty("expected_date")]
        public string ExpectedDate { get; set; }

        [JsonProperty("expected_amount")]
        public OpportunityApiOpportunityReadExpectedAmountType ExpectedAmount { get; set; }

        [JsonProperty("funded_date")]
        public string FundedDate { get; set; }

        [JsonProperty("funded_amount")]
        public OpportunityApiOpportunityReadFundedAmountType FundedAmount { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignID { get; set; }

        [JsonProperty("fund_id")]
        public string FundID { get; set; }

        [JsonProperty("fundraisers")]
        public OpportunityApiFundraiser[] FundraiserS { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("linked_gifts")]
        public string[] LinkedGifts { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class OpportunityApiOpportunityReadAskAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class OpportunityApiOpportunityReadExpectedAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class OpportunityApiOpportunityReadFundedAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class OpportunityApiFundraiser
    {
        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("credit_amount")]
        public OpportunityApiFundraiserCreditAmountType CreditAmount { get; set; }
    }

    public class OpportunityApiFundraiserCreditAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class OpportunityApiCreatedOpportunity
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class OpportunityApiApiCollectionOfOpportunityAttachmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public OpportunityApiOpportunityAttachmentRead[] Value { get; set; }
    }

    public class OpportunityApiOpportunityAttachmentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string OpportunityID { get; set; }

        [JsonProperty("type")]
        public OpportunityApiOpportunityAttachmentReadTypeType Type { get; set; }

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

    public enum OpportunityApiOpportunityAttachmentReadTypeType
    {
        Link,
        Physical
    }

    public class OpportunityApiApiCollectionOfOpportunityCustomFieldRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public OpportunityApiOpportunityCustomFieldRead[] Value { get; set; }
    }

    public class OpportunityApiOpportunityCustomFieldRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string OpportunityID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public OpportunityApiOpportunityCustomFieldReadTypeType Type { get; set; }

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
        public OpportunityApiOpportunityCustomFieldReadFuzzyDateValueType FuzzyDateValue { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum OpportunityApiOpportunityCustomFieldReadTypeType
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

    public class OpportunityApiOpportunityCustomFieldReadFuzzyDateValueType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class OpportunityApiCreatedOpportunityAttachment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodytypeInput
    {
        Link,
        Physical
    }

    public class OpportunityApiCreatedOpportunityCustomField
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudprospects;

    public partial class WorkflowManagedActions
    {
        public BlackbaudprospectsActions Blackbaudprospects(string connectionId) => new BlackbaudprospectsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudprospectsTriggers Blackbaudprospects(string connectionId) => new BlackbaudprospectsTriggers(connectionId);
    }
}