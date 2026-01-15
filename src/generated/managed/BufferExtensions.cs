//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Buffer
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BufferActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buffer")]
        public IBodyWorkflowAction<CreateUpdateResponse> CreateUpdate(Expression<Func<string>> createUpdateProfileId, Expression<Func<string>> createUpdateText)
        {
            var apiCallPath = "/1/updates/create.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["CreateUpdateProfileId"] = ExpressionConverter.Convert(createUpdateProfileId);
            callPayload.Queries["CreateUpdateText"] = ExpressionConverter.Convert(createUpdateText);
            return new ApiConnectionAction<CreateUpdateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buffer")]
        public IBodyWorkflowAction<ShareUpdateResponse> ShareUpdate(Expression<Func<string>> profileId, Expression<Func<string>> udpateId)
        {
            var apiCallPath = String.Format("/1/updates/{0}/share.json", ExpressionConverter.ConvertWithUrlEncoding(udpateId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["profile_id"] = ExpressionConverter.Convert(profileId);
            return new ApiConnectionAction<ShareUpdateResponse>(callPayload);
        }
    }

    public class BufferTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<ListPendingUpdatesResponse> TrigPendingUpdates(Expression<Func<string>> profileId)
        {
            var apiCallPath = String.Format("/trigger/1/profiles/{0}/updates/pending.json", ExpressionConverter.ConvertWithUrlEncoding(profileId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListPendingUpdatesResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<ListSentUpdatesResponse> TrigSentUpdates(Expression<Func<string>> profileId)
        {
            var apiCallPath = String.Format("/trigger/1/profiles/{0}/updates/sent.json", ExpressionConverter.ConvertWithUrlEncoding(profileId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ListSentUpdatesResponse>(callPayload);
        }
    }

    public class CreateUpdateResponse
    {
        [JsonProperty("updates")]
        public CreateUpdateResponseUpdatesTypeItem[] Updates { get; set; }
    }

    public class CreateUpdateResponseUpdatesTypeItem
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("day")]
        public string Day { get; set; }

        [JsonProperty("due_at")]
        public string DueAt { get; set; }

        [JsonProperty("due_time")]
        public string DueTime { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("profile_id")]
        public string ProfileId { get; set; }

        [JsonProperty("profile_service")]
        public string ProfileUpdate { get; set; }

        [JsonProperty("shared_now")]
        public bool IsSharedNow { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("text_formatted")]
        public string TextFormatted { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("via")]
        public string Via { get; set; }
    }

    public class ShareUpdateResponse
    {
        [JsonProperty("success")]
        public bool IsSuccess { get; set; }
    }

    public class ListPendingUpdatesResponse
    {
        [JsonProperty("updates")]
        public ListPendingUpdatesResponseUpdatesTypeItem[] Updates { get; set; }
    }

    public class ListPendingUpdatesResponseUpdatesTypeItem
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("day")]
        public string Day { get; set; }

        [JsonProperty("due_at")]
        public string DueAt { get; set; }

        [JsonProperty("due_time")]
        public string DueTime { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("profile_id")]
        public string ProfileId { get; set; }

        [JsonProperty("profile_service")]
        public string ProfileUpdate { get; set; }

        [JsonProperty("shared_now")]
        public bool IsSharedNow { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("text_formatted")]
        public string TextFormatted { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("via")]
        public string Via { get; set; }
    }

    public class ListSentUpdatesResponse
    {
        [JsonProperty("updates")]
        public ListSentUpdatesResponseUpdatesTypeItem[] Updates { get; set; }
    }

    public class ListSentUpdatesResponseUpdatesTypeItem
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("day")]
        public string Day { get; set; }

        [JsonProperty("due_at")]
        public string DueAt { get; set; }

        [JsonProperty("due_time")]
        public string DueTime { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("profile_id")]
        public string ProfileId { get; set; }

        [JsonProperty("profile_service")]
        public string ProfileUpdate { get; set; }

        [JsonProperty("shared_now")]
        public bool IsSharedNow { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("text_formatted")]
        public string TextFormatted { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("via")]
        public string Via { get; set; }

        [JsonProperty("statistics")]
        public ListSentUpdatesResponseUpdatesTypeItemStatisticsType Statistics { get; set; }
    }

    public class ListSentUpdatesResponseUpdatesTypeItemStatisticsType
    {
        [JsonProperty("comments")]
        public int Comments { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("clicks")]
        public int Clicks { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Buffer;

    public partial class WorkflowManagedActions
    {
        public BufferActions Buffer(string connectionId) => new BufferActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BufferTriggers Buffer(string connectionId) => new BufferTriggers(connectionId);
    }
}