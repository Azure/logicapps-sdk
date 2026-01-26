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
        public IWorkflowAction AmendmentCosponsors(Expression<Func<int>> congress, Expression<Func<string>> amendmentType, Expression<Func<int>> amendmentNumber, Expression<Func<string>> format = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null)
        {
            var apiCallPath = String.Format("/amendment/{0}/{1}/{2}/cosponsors", ExpressionConverter.ConvertWithUrlEncoding(congress, 1), ExpressionConverter.ConvertWithUrlEncoding(amendmentType, 1), ExpressionConverter.ConvertWithUrlEncoding(amendmentNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (format != null)
                callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uscongresscrs")]
        public IWorkflowAction AmendmentAmendments(Expression<Func<int>> congress, Expression<Func<string>> amendmentType, Expression<Func<int>> amendmentNumber, Expression<Func<string>> format = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null)
        {
            var apiCallPath = String.Format("/amendment/{0}/{1}/{2}/amendments", ExpressionConverter.ConvertWithUrlEncoding(congress, 1), ExpressionConverter.ConvertWithUrlEncoding(amendmentType, 1), ExpressionConverter.ConvertWithUrlEncoding(amendmentNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (format != null)
                callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uscongresscrs")]
        public IWorkflowAction CongressCurrentList(Expression<Func<string>> format = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null)
        {
            var apiCallPath = "/congress/current";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (format != null)
                callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uscongresscrs")]
        public IWorkflowAction MemberListByCongressStateDistrict(Expression<Func<int>> congress, Expression<Func<string>> stateCode, Expression<Func<int>> district, Expression<Func<string>> format = null, Expression<Func<string>> currentMember = null)
        {
            var apiCallPath = String.Format("/member/congress/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(congress, 1), ExpressionConverter.ConvertWithUrlEncoding(stateCode, 1), ExpressionConverter.ConvertWithUrlEncoding(district, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (format != null)
                callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            if (currentMember != null)
                callPayload.Queries["currentMember"] = ExpressionConverter.Convert(currentMember);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uscongresscrs")]
        public IWorkflowAction CommitteeMeetingCongress(Expression<Func<int>> congress, Expression<Func<string>> format = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null)
        {
            var apiCallPath = String.Format("/committee-meeting/{0}", ExpressionConverter.ConvertWithUrlEncoding(congress, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (format != null)
                callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uscongresscrs")]
        public IBodyWorkflowAction<NominationListResponse> NominationList(Expression<Func<string>> format = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<string>> fromDateTime = null, Expression<Func<string>> toDateTime = null)
        {
            var apiCallPath = "/nomination";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (format != null)
                callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (fromDateTime != null)
                callPayload.Queries["fromDateTime"] = ExpressionConverter.Convert(fromDateTime);
            if (toDateTime != null)
                callPayload.Queries["toDateTime"] = ExpressionConverter.Convert(toDateTime);
            return new ApiConnectionAction<NominationListResponse>(callPayload);
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