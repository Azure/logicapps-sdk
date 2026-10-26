//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Uscongresscrs
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UscongresscrsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uscongresscrs")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AmendmentCosponsors(Expression<Func<int>> congress, Expression<Func<string>> amendmentType, Expression<Func<int>> amendmentNumber, Expression<Func<string>> format = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null)
        {
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            var __workflow_amendmentType = WorkflowExpression.Compile(amendmentType, nameof(amendmentType), required: true);
            var __workflow_amendmentNumber = WorkflowExpression.Compile(amendmentNumber, nameof(amendmentNumber), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/amendment/{0}/{1}/{2}/cosponsors", __workflow_congress.WithUrlEncoding(1), __workflow_amendmentType.WithUrlEncoding(1), __workflow_amendmentNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uscongresscrs")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AmendmentAmendments(Expression<Func<int>> congress, Expression<Func<string>> amendmentType, Expression<Func<int>> amendmentNumber, Expression<Func<string>> format = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null)
        {
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            var __workflow_amendmentType = WorkflowExpression.Compile(amendmentType, nameof(amendmentType), required: true);
            var __workflow_amendmentNumber = WorkflowExpression.Compile(amendmentNumber, nameof(amendmentNumber), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/amendment/{0}/{1}/{2}/amendments", __workflow_congress.WithUrlEncoding(1), __workflow_amendmentType.WithUrlEncoding(1), __workflow_amendmentNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uscongresscrs")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CongressCurrentList(Expression<Func<string>> format = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/congress/current";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uscongresscrs")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MemberListByCongressStateDistrict(Expression<Func<int>> congress, Expression<Func<string>> stateCode, Expression<Func<int>> district, Expression<Func<string>> format = null, Expression<Func<string>> currentMember = null)
        {
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            var __workflow_stateCode = WorkflowExpression.Compile(stateCode, nameof(stateCode), required: true);
            var __workflow_district = WorkflowExpression.Compile(district, nameof(district), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_currentMember = WorkflowExpression.Compile(currentMember, nameof(currentMember), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/member/congress/{0}/{1}/{2}", __workflow_congress.WithUrlEncoding(1), __workflow_stateCode.WithUrlEncoding(1), __workflow_district.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_currentMember != null)
                    callPayload.Queries["currentMember"] = ExpressionConverter.Convert(__workflow_currentMember);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uscongresscrs")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CommitteeMeetingCongress(Expression<Func<int>> congress, Expression<Func<string>> format = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null)
        {
            var __workflow_congress = WorkflowExpression.Compile(congress, nameof(congress), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/committee-meeting/{0}", __workflow_congress.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uscongresscrs")]
        public IBodyWorkflowAction<NominationListResponse, ApiConnectionActionConfiguration> NominationList(Expression<Func<string>> format = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> fromDateTime = null, Expression<Func<string>> toDateTime = null)
        {
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_fromDateTime = WorkflowExpression.Compile(fromDateTime, nameof(fromDateTime), required: false);
            var __workflow_toDateTime = WorkflowExpression.Compile(toDateTime, nameof(toDateTime), required: false);
            return new DeferredBodyAction<NominationListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nomination";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_fromDateTime != null)
                    callPayload.Queries["fromDateTime"] = ExpressionConverter.Convert(__workflow_fromDateTime);
                if (__workflow_toDateTime != null)
                    callPayload.Queries["toDateTime"] = ExpressionConverter.Convert(__workflow_toDateTime);
                return new ApiConnectionAction<NominationListResponse>(callPayload);
            });
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