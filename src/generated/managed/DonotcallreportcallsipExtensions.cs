//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Donotcallreportcallsip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DonotcallreportcallsipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "donotcallreportcallsip")]
        [WorkflowExpressionFactory(nameof(__BuildComplaintsAll))]
        public IBodyWorkflowAction<ComplaintsAllResponse> ComplaintsAll([WorkflowExpression] Func<string> createdDate = null, [WorkflowExpression] Func<string> createdDateFrom = null, [WorkflowExpression] Func<string> createdDateTo = null, [WorkflowExpression] Func<string> violationDate = null, [WorkflowExpression] Func<string> violationDateFrom = null, [WorkflowExpression] Func<string> violationDateTo = null, [WorkflowExpression] Func<string> state = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<int> areaCode = null, [WorkflowExpression] Func<bool> isRobocall = null, [WorkflowExpression] Func<sortOrderInput> sortOrder = null, [WorkflowExpression] Func<int> itemsPerPage = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "donotcallreportcallsip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ComplaintsAllResponse> __BuildComplaintsAll(WorkflowExpression<string> createdDate = null, WorkflowExpression<string> createdDateFrom = null, WorkflowExpression<string> createdDateTo = null, WorkflowExpression<string> violationDate = null, WorkflowExpression<string> violationDateFrom = null, WorkflowExpression<string> violationDateTo = null, WorkflowExpression<string> state = null, WorkflowExpression<string> city = null, WorkflowExpression<int> areaCode = null, WorkflowExpression<bool> isRobocall = null, WorkflowExpression<sortOrderInput> sortOrder = null, WorkflowExpression<int> itemsPerPage = null, WorkflowExpression<int> offset = null)
        {
            WorkflowExpression.Validate(createdDate, nameof(createdDate), required: false);
            WorkflowExpression.Validate(createdDateFrom, nameof(createdDateFrom), required: false);
            WorkflowExpression.Validate(createdDateTo, nameof(createdDateTo), required: false);
            WorkflowExpression.Validate(violationDate, nameof(violationDate), required: false);
            WorkflowExpression.Validate(violationDateFrom, nameof(violationDateFrom), required: false);
            WorkflowExpression.Validate(violationDateTo, nameof(violationDateTo), required: false);
            WorkflowExpression.Validate(state, nameof(state), required: false);
            WorkflowExpression.Validate(city, nameof(city), required: false);
            WorkflowExpression.Validate(areaCode, nameof(areaCode), required: false);
            WorkflowExpression.Validate(isRobocall, nameof(isRobocall), required: false);
            WorkflowExpression.Validate(sortOrder, nameof(sortOrder), required: false);
            WorkflowExpression.Validate(itemsPerPage, nameof(itemsPerPage), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ComplaintsAllResponse>(() =>
            {
                var apiCallPath = "/dnc-complaints";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (createdDate != null)
                    callPayload.Queries["created_date"] = ExpressionConverter.Convert(createdDate);
                if (createdDateFrom != null)
                    callPayload.Queries["created_date_from"] = ExpressionConverter.Convert(createdDateFrom);
                if (createdDateTo != null)
                    callPayload.Queries["created_date_to"] = ExpressionConverter.Convert(createdDateTo);
                if (violationDate != null)
                    callPayload.Queries["violation_date"] = ExpressionConverter.Convert(violationDate);
                if (violationDateFrom != null)
                    callPayload.Queries["violation_date_from"] = ExpressionConverter.Convert(violationDateFrom);
                if (violationDateTo != null)
                    callPayload.Queries["violation_date_to"] = ExpressionConverter.Convert(violationDateTo);
                if (state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(state);
                if (city != null)
                    callPayload.Queries["city"] = ExpressionConverter.Convert(city);
                if (areaCode != null)
                    callPayload.Queries["area_code"] = ExpressionConverter.Convert(areaCode);
                if (isRobocall != null)
                    callPayload.Queries["is_robocall"] = ExpressionConverter.Convert(isRobocall);
                callPayload.Queries["sort_order"] = Convert.ToString("DESC");
                if (sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(sortOrder);
                if (itemsPerPage != null)
                    callPayload.Queries["items_per_page"] = ExpressionConverter.Convert(itemsPerPage);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<ComplaintsAllResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "donotcallreportcallsip")]
        [WorkflowExpressionFactory(nameof(__BuildComplaintID))]
        public IBodyWorkflowAction<ComplaintIDResponse> ComplaintID([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "donotcallreportcallsip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ComplaintIDResponse> __BuildComplaintID(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ComplaintIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/dnc-complaints/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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