//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Uscongresscrs
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UscongresscrsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uscongresscrs")]
        public IWorkflowAction AmendmentCosponsors([WorkflowExpression] Func<int> congress, [WorkflowExpression] Func<string> amendmentType, [WorkflowExpression] Func<int> amendmentNumber, [WorkflowExpression] Func<string> format = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null)
        {
            SourceExpression.Validate(congress, nameof(congress), required: true);
            SourceExpression.Validate(amendmentType, nameof(amendmentType), required: true);
            SourceExpression.Validate(amendmentNumber, nameof(amendmentNumber), required: true);
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/amendment/{0}/{1}/{2}/cosponsors", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(congress, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(amendmentType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(amendmentNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.ConvertO(format);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uscongresscrs")]
        public IWorkflowAction AmendmentAmendments([WorkflowExpression] Func<int> congress, [WorkflowExpression] Func<string> amendmentType, [WorkflowExpression] Func<int> amendmentNumber, [WorkflowExpression] Func<string> format = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null)
        {
            SourceExpression.Validate(congress, nameof(congress), required: true);
            SourceExpression.Validate(amendmentType, nameof(amendmentType), required: true);
            SourceExpression.Validate(amendmentNumber, nameof(amendmentNumber), required: true);
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/amendment/{0}/{1}/{2}/amendments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(congress, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(amendmentType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(amendmentNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.ConvertO(format);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uscongresscrs")]
        public IWorkflowAction CongressCurrentList([WorkflowExpression] Func<string> format = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null)
        {
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/congress/current";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.ConvertO(format);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uscongresscrs")]
        public IWorkflowAction MemberListByCongressStateDistrict([WorkflowExpression] Func<int> congress, [WorkflowExpression] Func<string> stateCode, [WorkflowExpression] Func<int> district, [WorkflowExpression] Func<string> format = null, [WorkflowExpression] Func<string> currentMember = null)
        {
            SourceExpression.Validate(congress, nameof(congress), required: true);
            SourceExpression.Validate(stateCode, nameof(stateCode), required: true);
            SourceExpression.Validate(district, nameof(district), required: true);
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(currentMember, nameof(currentMember), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/member/congress/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(congress, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(stateCode, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(district, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.ConvertO(format);
                if (currentMember != null)
                    callPayload.Queries["currentMember"] = SourceExpressionConverter.ConvertO(currentMember);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uscongresscrs")]
        public IWorkflowAction CommitteeMeetingCongress([WorkflowExpression] Func<int> congress, [WorkflowExpression] Func<string> format = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null)
        {
            SourceExpression.Validate(congress, nameof(congress), required: true);
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/committee-meeting/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(congress, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.ConvertO(format);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uscongresscrs")]
        public IBodyWorkflowAction<NominationListResponse> NominationList([WorkflowExpression] Func<string> format = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> fromDateTime = null, [WorkflowExpression] Func<string> toDateTime = null)
        {
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(fromDateTime, nameof(fromDateTime), required: false);
            SourceExpression.Validate(toDateTime, nameof(toDateTime), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nomination";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.ConvertO(format);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (fromDateTime != null)
                    callPayload.Queries["fromDateTime"] = SourceExpressionConverter.ConvertO(fromDateTime);
                if (toDateTime != null)
                    callPayload.Queries["toDateTime"] = SourceExpressionConverter.ConvertO(toDateTime);
                return callPayload;
            }

            return new ApiConnectionAction<NominationListResponse>(BuildSourceInput);
        }
    }

    public class UscongresscrsTriggers([ConnectionName] string connectionId)
    {
    }

    public class NominationListResponse
    {
        [JsonProperty("nominations")]
        public NominationListResponseNominationsTypeItem[] Nominations { get; set; }
    }

    public class NominationListResponseNominationsTypeItem
    {
        [JsonProperty("citation")]
        public string Citation { get; set; }

        [JsonProperty("congress")]
        public int Congress { get; set; }

        [JsonProperty("latestAction")]
        public NominationListResponseNominationsTypeItemLatestActionType LatestAction { get; set; }

        [JsonProperty("nominationType")]
        public NominationListResponseNominationsTypeItemNominationTypeType NominationType { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("partNumber")]
        public string PartNumber { get; set; }

        [JsonProperty("receivedDate")]
        public string ReceivedDate { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class NominationListResponseNominationsTypeItemLatestActionType
    {
        [JsonProperty("actionDate")]
        public string ActionDate { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class NominationListResponseNominationsTypeItemNominationTypeType
    {
        [JsonProperty("isMilitary")]
        public bool IsMilitary { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Uscongresscrs;

    public partial class WorkflowManagedActions
    {
        public UscongresscrsActions Uscongresscrs(string connectionId) => new UscongresscrsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UscongresscrsTriggers Uscongresscrs(string connectionId) => new UscongresscrsTriggers(connectionId);
    }
}