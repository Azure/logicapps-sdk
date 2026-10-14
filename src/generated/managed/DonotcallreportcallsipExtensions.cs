//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Donotcallreportcallsip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class DonotcallreportcallsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "donotcallreportcallsip")]
        public IBodyWorkflowAction<ComplaintsAllResponse> ComplaintsAll(Expression<Func<string>> createdDate = null, Expression<Func<string>> createdDateFrom = null, Expression<Func<string>> createdDateTo = null, Expression<Func<string>> violationDate = null, Expression<Func<string>> violationDateFrom = null, Expression<Func<string>> violationDateTo = null, Expression<Func<string>> state = null, Expression<Func<string>> city = null, Expression<Func<int>> areaCode = null, Expression<Func<bool>> isRobocall = null, Expression<Func<sortOrderInput>> sortOrder = null, Expression<Func<int>> itemsPerPage = null, Expression<Func<int>> offset = null)
        {
            var __workflow_createdDate = createdDate == null ? null : WorkflowExpression.Compile(createdDate);
            WorkflowExpression.Validate(__workflow_createdDate, nameof(createdDate), required: false);
            var __workflow_createdDateFrom = createdDateFrom == null ? null : WorkflowExpression.Compile(createdDateFrom);
            WorkflowExpression.Validate(__workflow_createdDateFrom, nameof(createdDateFrom), required: false);
            var __workflow_createdDateTo = createdDateTo == null ? null : WorkflowExpression.Compile(createdDateTo);
            WorkflowExpression.Validate(__workflow_createdDateTo, nameof(createdDateTo), required: false);
            var __workflow_violationDate = violationDate == null ? null : WorkflowExpression.Compile(violationDate);
            WorkflowExpression.Validate(__workflow_violationDate, nameof(violationDate), required: false);
            var __workflow_violationDateFrom = violationDateFrom == null ? null : WorkflowExpression.Compile(violationDateFrom);
            WorkflowExpression.Validate(__workflow_violationDateFrom, nameof(violationDateFrom), required: false);
            var __workflow_violationDateTo = violationDateTo == null ? null : WorkflowExpression.Compile(violationDateTo);
            WorkflowExpression.Validate(__workflow_violationDateTo, nameof(violationDateTo), required: false);
            var __workflow_state = state == null ? null : WorkflowExpression.Compile(state);
            WorkflowExpression.Validate(__workflow_state, nameof(state), required: false);
            var __workflow_city = city == null ? null : WorkflowExpression.Compile(city);
            WorkflowExpression.Validate(__workflow_city, nameof(city), required: false);
            var __workflow_areaCode = areaCode == null ? null : WorkflowExpression.Compile(areaCode);
            WorkflowExpression.Validate(__workflow_areaCode, nameof(areaCode), required: false);
            var __workflow_isRobocall = isRobocall == null ? null : WorkflowExpression.Compile(isRobocall);
            WorkflowExpression.Validate(__workflow_isRobocall, nameof(isRobocall), required: false);
            var __workflow_sortOrder = sortOrder == null ? null : WorkflowExpression.Compile(sortOrder);
            WorkflowExpression.Validate(__workflow_sortOrder, nameof(sortOrder), required: false);
            var __workflow_itemsPerPage = itemsPerPage == null ? null : WorkflowExpression.Compile(itemsPerPage);
            WorkflowExpression.Validate(__workflow_itemsPerPage, nameof(itemsPerPage), required: false);
            var __workflow_offset = offset == null ? null : WorkflowExpression.Compile(offset);
            WorkflowExpression.Validate(__workflow_offset, nameof(offset), required: false);
            return new DeferredBodyAction<ComplaintsAllResponse>(() =>
            {
                var apiCallPath = "/dnc-complaints";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_createdDate != null)
                    callPayload.Queries["created_date"] = ExpressionConverter.Convert(__workflow_createdDate);
                if (__workflow_createdDateFrom != null)
                    callPayload.Queries["created_date_from"] = ExpressionConverter.Convert(__workflow_createdDateFrom);
                if (__workflow_createdDateTo != null)
                    callPayload.Queries["created_date_to"] = ExpressionConverter.Convert(__workflow_createdDateTo);
                if (__workflow_violationDate != null)
                    callPayload.Queries["violation_date"] = ExpressionConverter.Convert(__workflow_violationDate);
                if (__workflow_violationDateFrom != null)
                    callPayload.Queries["violation_date_from"] = ExpressionConverter.Convert(__workflow_violationDateFrom);
                if (__workflow_violationDateTo != null)
                    callPayload.Queries["violation_date_to"] = ExpressionConverter.Convert(__workflow_violationDateTo);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                if (__workflow_city != null)
                    callPayload.Queries["city"] = ExpressionConverter.Convert(__workflow_city);
                if (__workflow_areaCode != null)
                    callPayload.Queries["area_code"] = ExpressionConverter.Convert(__workflow_areaCode);
                if (__workflow_isRobocall != null)
                    callPayload.Queries["is_robocall"] = ExpressionConverter.Convert(__workflow_isRobocall);
                callPayload.Queries["sort_order"] = Convert.ToString("DESC");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                if (__workflow_itemsPerPage != null)
                    callPayload.Queries["items_per_page"] = ExpressionConverter.Convert(__workflow_itemsPerPage);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ComplaintsAllResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "donotcallreportcallsip")]
        public IBodyWorkflowAction<ComplaintIDResponse> ComplaintID(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<ComplaintIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/dnc-complaints/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ComplaintIDResponse>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
