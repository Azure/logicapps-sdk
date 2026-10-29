//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Buffer
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BufferActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buffer")]
        public IBodyWorkflowAction<CreateUpdateResponse, ApiConnectionActionConfiguration> CreateUpdate(Expression<Func<string>> createUpdateProfileId, Expression<Func<string>> createUpdateText)
        {
            var __workflow_createUpdateProfileId = WorkflowExpression.Compile(createUpdateProfileId, nameof(createUpdateProfileId), required: true);
            var __workflow_createUpdateText = WorkflowExpression.Compile(createUpdateText, nameof(createUpdateText), required: true);
            return new DeferredBodyAction<CreateUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1/updates/create.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["CreateUpdateProfileId"] = ExpressionConverter.Convert(__workflow_createUpdateProfileId);
                callPayload.Queries["CreateUpdateText"] = ExpressionConverter.Convert(__workflow_createUpdateText);
                return new ApiConnectionAction<CreateUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buffer")]
        public IBodyWorkflowAction<ShareUpdateResponse, ApiConnectionActionConfiguration> ShareUpdate(Expression<Func<string>> profileId, Expression<Func<string>> udpateId)
        {
            var __workflow_profileId = WorkflowExpression.Compile(profileId, nameof(profileId), required: true);
            var __workflow_udpateId = WorkflowExpression.Compile(udpateId, nameof(udpateId), required: true);
            return new DeferredBodyAction<ShareUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/1/updates/{0}/share.json", __workflow_udpateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["profile_id"] = ExpressionConverter.Convert(__workflow_profileId);
                return new ApiConnectionAction<ShareUpdateResponse>(callPayload);
            });
        }
    }

    public class BufferTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListPendingUpdatesResponse, ApiConnectionTriggerConfiguration> TrigPendingUpdates(Expression<Func<string>> profileId, FlowRecurrence recurrence = null)
        {
            var __workflow_profileId = WorkflowExpression.Compile(profileId, nameof(profileId), required: true);
            return new DeferredBodyTrigger<ListPendingUpdatesResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger/1/profiles/{0}/updates/pending.json", __workflow_profileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListPendingUpdatesResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ListSentUpdatesResponse, ApiConnectionTriggerConfiguration> TrigSentUpdates(Expression<Func<string>> profileId, FlowRecurrence recurrence = null)
        {
            var __workflow_profileId = WorkflowExpression.Compile(profileId, nameof(profileId), required: true);
            return new DeferredBodyTrigger<ListSentUpdatesResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger/1/profiles/{0}/updates/sent.json", __workflow_profileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListSentUpdatesResponse>(callPayload, recurrence: recurrence);
            });
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
