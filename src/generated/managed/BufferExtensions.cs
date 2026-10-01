//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Buffer
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BufferActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buffer")]
        public IBodyWorkflowAction<CreateUpdateResponse> CreateUpdate([WorkflowExpression] Func<string> createUpdateProfileId, [WorkflowExpression] Func<string> createUpdateText)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1/updates/create.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["CreateUpdateProfileId"] = SourceExpressionConverter.ConvertO(createUpdateProfileId);
                callPayload.Queries["CreateUpdateText"] = SourceExpressionConverter.ConvertO(createUpdateText);
                return callPayload;
            }

            return new ApiConnectionAction<CreateUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buffer")]
        public IBodyWorkflowAction<ShareUpdateResponse> ShareUpdate([WorkflowExpression] Func<string> profileId, [WorkflowExpression] Func<string> udpateId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/1/updates/{0}/share.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(udpateId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["profile_id"] = SourceExpressionConverter.ConvertO(profileId);
                return callPayload;
            }

            return new ApiConnectionAction<ShareUpdateResponse>(BuildSourceInput);
        }
    }

    public class BufferTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListPendingUpdatesResponse> TrigPendingUpdates([WorkflowExpression] Func<string> profileId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger/1/profiles/{0}/updates/pending.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(profileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListPendingUpdatesResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ListSentUpdatesResponse> TrigSentUpdates([WorkflowExpression] Func<string> profileId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger/1/profiles/{0}/updates/sent.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(profileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ListSentUpdatesResponse>(BuildSourceInput, triggerName, recurrence);
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Buffer;

    public partial class WorkflowManagedActions
    {
        public BufferActions Buffer(string connectionId) => new BufferActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BufferTriggers Buffer(string connectionId) => new BufferTriggers(connectionId);
    }
}