//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Donotcallreportcallsip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DonotcallreportcallsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "donotcallreportcallsip")]
        public IBodyWorkflowAction<ComplaintsAllResponse> ComplaintsAll(Expression<Func<string>> createdDate = null, Expression<Func<string>> createdDateFrom = null, Expression<Func<string>> createdDateTo = null, Expression<Func<string>> violationDate = null, Expression<Func<string>> violationDateFrom = null, Expression<Func<string>> violationDateTo = null, Expression<Func<string>> state = null, Expression<Func<string>> city = null, Expression<Func<int>> areaCode = null, Expression<Func<bool>> isRobocall = null, Expression<Func<sortOrderInput>> sortOrder = null, Expression<Func<int>> itemsPerPage = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/dnc-complaints";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (createdDate != null)
                callPayload.Queries["created_date"] = CSharpExpressionConverter.ConvertO(createdDate);
            if (createdDateFrom != null)
                callPayload.Queries["created_date_from"] = CSharpExpressionConverter.ConvertO(createdDateFrom);
            if (createdDateTo != null)
                callPayload.Queries["created_date_to"] = CSharpExpressionConverter.ConvertO(createdDateTo);
            if (violationDate != null)
                callPayload.Queries["violation_date"] = CSharpExpressionConverter.ConvertO(violationDate);
            if (violationDateFrom != null)
                callPayload.Queries["violation_date_from"] = CSharpExpressionConverter.ConvertO(violationDateFrom);
            if (violationDateTo != null)
                callPayload.Queries["violation_date_to"] = CSharpExpressionConverter.ConvertO(violationDateTo);
            if (state != null)
                callPayload.Queries["state"] = CSharpExpressionConverter.ConvertO(state);
            if (city != null)
                callPayload.Queries["city"] = CSharpExpressionConverter.ConvertO(city);
            if (areaCode != null)
                callPayload.Queries["area_code"] = CSharpExpressionConverter.ConvertO(areaCode);
            if (isRobocall != null)
                callPayload.Queries["is_robocall"] = CSharpExpressionConverter.ConvertO(isRobocall);
            callPayload.Queries["sort_order"] = Convert.ToString("DESC");
            if (sortOrder != null)
                callPayload.Queries["sort_order"] = CSharpExpressionConverter.Convert(sortOrder);
            if (itemsPerPage != null)
                callPayload.Queries["items_per_page"] = CSharpExpressionConverter.ConvertO(itemsPerPage);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            return new ApiConnectionAction<ComplaintsAllResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "donotcallreportcallsip")]
        public IBodyWorkflowAction<ComplaintIDResponse> ComplaintID(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/dnc-complaints/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ComplaintIDResponse>(callPayload);
        }
    }

    public class DonotcallreportcallsipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ComplaintsAllResponse
    {
        [JsonProperty("data")]
        public ComplaintsAllResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("meta")]
        public ComplaintsAllResponseMetaType Meta { get; set; }

        [JsonProperty("links")]
        public ComplaintsAllResponseLinksType Links { get; set; }
    }

    public class ComplaintsAllResponseDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public ComplaintsAllResponseDataTypeItemAttributesType Attributes { get; set; }

        [JsonProperty("links")]
        public ComplaintsAllResponseDataTypeItemLinksType Links { get; set; }
    }

    public class ComplaintsAllResponseDataTypeItemAttributesType
    {
        [JsonProperty("company-phone-number")]
        public string CompanyPhoneNumber { get; set; }

        [JsonProperty("created-date")]
        public string CreatedDate { get; set; }

        [JsonProperty("violation-date")]
        public string ViolationDate { get; set; }

        [JsonProperty("consumer-city")]
        public string ConsumerCity { get; set; }

        [JsonProperty("consumer-state")]
        public string ConsumerState { get; set; }

        [JsonProperty("consumer-area-code")]
        public string ConsumerAreaCode { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("recorded-message-or-robocall")]
        public string RecordedMessageOrRobocall { get; set; }
    }

    public class ComplaintsAllResponseDataTypeItemLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class ComplaintsAllResponseMetaType
    {
        [JsonProperty("records-this-page")]
        public int RecordsThisPage { get; set; }

        [JsonProperty("record-total")]
        public int RecordTotal { get; set; }
    }

    public class ComplaintsAllResponseLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public enum sortOrderInput
    {
        DESC,
        ASC
    }

    public class ComplaintIDResponse
    {
        [JsonProperty("data")]
        public ComplaintIDResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("meta")]
        public ComplaintIDResponseMetaType Meta { get; set; }

        [JsonProperty("links")]
        public ComplaintIDResponseLinksType Links { get; set; }
    }

    public class ComplaintIDResponseDataTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public ComplaintIDResponseDataTypeItemAttributesType Attributes { get; set; }

        [JsonProperty("links")]
        public ComplaintIDResponseDataTypeItemLinksType Links { get; set; }
    }

    public class ComplaintIDResponseDataTypeItemAttributesType
    {
        [JsonProperty("company-phone-number")]
        public string CompanyPhoneNumber { get; set; }

        [JsonProperty("created-date")]
        public string CreatedDate { get; set; }

        [JsonProperty("violation-date")]
        public string ViolationDate { get; set; }

        [JsonProperty("consumer-city")]
        public string ConsumerCity { get; set; }

        [JsonProperty("consumer-state")]
        public string ConsumerState { get; set; }

        [JsonProperty("consumer-area-code")]
        public string ConsumerAreaCode { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("recorded-message-or-robocall")]
        public string RecordedMessageOrRobocall { get; set; }
    }

    public class ComplaintIDResponseDataTypeItemLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class ComplaintIDResponseMetaType
    {
        [JsonProperty("records-this-page")]
        public int RecordsThisPage { get; set; }

        [JsonProperty("record-total")]
        public int RecordTotal { get; set; }
    }

    public class ComplaintIDResponseLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Donotcallreportcallsip;

    public partial class WorkflowManagedActions
    {
        public DonotcallreportcallsipActions Donotcallreportcallsip(string connectionId) => new DonotcallreportcallsipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DonotcallreportcallsipTriggers Donotcallreportcallsip(string connectionId) => new DonotcallreportcallsipTriggers(connectionId);
    }
}