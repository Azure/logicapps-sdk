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
        public IBodyWorkflowAction<ComplaintsAllResponse> ComplaintsAll([WorkflowExpression] Func<string> createdDate = null, [WorkflowExpression] Func<string> createdDateFrom = null, [WorkflowExpression] Func<string> createdDateTo = null, [WorkflowExpression] Func<string> violationDate = null, [WorkflowExpression] Func<string> violationDateFrom = null, [WorkflowExpression] Func<string> violationDateTo = null, [WorkflowExpression] Func<string> state = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<int> areaCode = null, [WorkflowExpression] Func<bool> isRobocall = null, [WorkflowExpression] Func<sortOrderInput> sortOrder = null, [WorkflowExpression] Func<int> itemsPerPage = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(createdDate, nameof(createdDate), required: false);
            SourceExpression.Validate(createdDateFrom, nameof(createdDateFrom), required: false);
            SourceExpression.Validate(createdDateTo, nameof(createdDateTo), required: false);
            SourceExpression.Validate(violationDate, nameof(violationDate), required: false);
            SourceExpression.Validate(violationDateFrom, nameof(violationDateFrom), required: false);
            SourceExpression.Validate(violationDateTo, nameof(violationDateTo), required: false);
            SourceExpression.Validate(state, nameof(state), required: false);
            SourceExpression.Validate(city, nameof(city), required: false);
            SourceExpression.Validate(areaCode, nameof(areaCode), required: false);
            SourceExpression.Validate(isRobocall, nameof(isRobocall), required: false);
            SourceExpression.Validate(sortOrder, nameof(sortOrder), required: false);
            SourceExpression.Validate(itemsPerPage, nameof(itemsPerPage), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/dnc-complaints";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (createdDate != null)
                    callPayload.Queries["created_date"] = SourceExpressionConverter.ConvertO(createdDate);
                if (createdDateFrom != null)
                    callPayload.Queries["created_date_from"] = SourceExpressionConverter.ConvertO(createdDateFrom);
                if (createdDateTo != null)
                    callPayload.Queries["created_date_to"] = SourceExpressionConverter.ConvertO(createdDateTo);
                if (violationDate != null)
                    callPayload.Queries["violation_date"] = SourceExpressionConverter.ConvertO(violationDate);
                if (violationDateFrom != null)
                    callPayload.Queries["violation_date_from"] = SourceExpressionConverter.ConvertO(violationDateFrom);
                if (violationDateTo != null)
                    callPayload.Queries["violation_date_to"] = SourceExpressionConverter.ConvertO(violationDateTo);
                if (state != null)
                    callPayload.Queries["state"] = SourceExpressionConverter.ConvertO(state);
                if (city != null)
                    callPayload.Queries["city"] = SourceExpressionConverter.ConvertO(city);
                if (areaCode != null)
                    callPayload.Queries["area_code"] = SourceExpressionConverter.ConvertO(areaCode);
                if (isRobocall != null)
                    callPayload.Queries["is_robocall"] = SourceExpressionConverter.ConvertO(isRobocall);
                callPayload.Queries["sort_order"] = Convert.ToString("DESC");
                if (sortOrder != null)
                    callPayload.Queries["sort_order"] = SourceExpressionConverter.Convert(sortOrder);
                if (itemsPerPage != null)
                    callPayload.Queries["items_per_page"] = SourceExpressionConverter.ConvertO(itemsPerPage);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ComplaintsAllResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "donotcallreportcallsip")]
        public IBodyWorkflowAction<ComplaintIDResponse> ComplaintID([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/dnc-complaints/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ComplaintIDResponse>(BuildSourceInput);
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