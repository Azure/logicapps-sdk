//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Yammer
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class YammerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yammer")]
        public IBodyWorkflowAction<Network[], ApiConnectionActionConfiguration> GetNetworks()
        {
            return new DeferredBodyAction<Network[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/networks.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Network[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yammer")]
        public IBodyWorkflowAction<YammmerEntity[], ApiConnectionActionConfiguration> GetGroups(Expression<Func<string>> networkId = null, Expression<Func<int>> mine = null, Expression<Func<int>> showAllCompanyGroup = null)
        {
            var __workflow_networkId = WorkflowExpression.Compile(networkId, nameof(networkId), required: false);
            var __workflow_mine = WorkflowExpression.Compile(mine, nameof(mine), required: false);
            var __workflow_showAllCompanyGroup = WorkflowExpression.Compile(showAllCompanyGroup, nameof(showAllCompanyGroup), required: false);
            return new DeferredBodyAction<YammmerEntity[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/groups.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["network_id"] = Convert.ToString("Default");
                if (__workflow_networkId != null)
                    callPayload.Queries["network_id"] = ExpressionConverter.Convert(__workflow_networkId);
                callPayload.Queries["mine"] = Convert.ToString(1);
                if (__workflow_mine != null)
                    callPayload.Queries["mine"] = ExpressionConverter.Convert(__workflow_mine);
                callPayload.Queries["showAllCompanyGroup"] = Convert.ToString(0);
                if (__workflow_showAllCompanyGroup != null)
                    callPayload.Queries["showAllCompanyGroup"] = ExpressionConverter.Convert(__workflow_showAllCompanyGroup);
                return new ApiConnectionAction<YammmerEntity[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yammer")]
        public IBodyWorkflowAction<User, ApiConnectionActionConfiguration> GetUserDetailsById(Expression<Func<int>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<User, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}.json", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<User>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yammer")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LikeMessage(Expression<Func<string>> messageId)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/messages/liked_by/current.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["message_id"] = ExpressionConverter.Convert(__workflow_messageId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yammer")]
        public IBodyWorkflowAction<PageableMessageListV2, ApiConnectionActionConfiguration> GetAllMessages(Expression<Func<string>> networkId = null, Expression<Func<int>> olderThan = null, Expression<Func<int>> newerThan = null, Expression<Func<threadedInput>> threaded = null, Expression<Func<int>> limit = null)
        {
            var __workflow_networkId = WorkflowExpression.Compile(networkId, nameof(networkId), required: false);
            var __workflow_olderThan = WorkflowExpression.Compile(olderThan, nameof(olderThan), required: false);
            var __workflow_newerThan = WorkflowExpression.Compile(newerThan, nameof(newerThan), required: false);
            var __workflow_threaded = WorkflowExpression.Compile(threaded, nameof(threaded), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<PageableMessageListV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/messages.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["network_id"] = Convert.ToString("Default");
                if (__workflow_networkId != null)
                    callPayload.Queries["network_id"] = ExpressionConverter.Convert(__workflow_networkId);
                if (__workflow_olderThan != null)
                    callPayload.Queries["older_than"] = ExpressionConverter.Convert(__workflow_olderThan);
                if (__workflow_newerThan != null)
                    callPayload.Queries["newer_than"] = ExpressionConverter.Convert(__workflow_newerThan);
                if (__workflow_threaded != null)
                    callPayload.Queries["threaded"] = ExpressionConverter.Convert(__workflow_threaded);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<PageableMessageListV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yammer")]
        public IBodyWorkflowAction<PageableMessageListV2, ApiConnectionActionConfiguration> GetMessagesFollowing(Expression<Func<string>> networkId = null, Expression<Func<int>> olderThan = null, Expression<Func<int>> newerThan = null, Expression<Func<threadedInput>> threaded = null, Expression<Func<int>> limit = null)
        {
            var __workflow_networkId = WorkflowExpression.Compile(networkId, nameof(networkId), required: false);
            var __workflow_olderThan = WorkflowExpression.Compile(olderThan, nameof(olderThan), required: false);
            var __workflow_newerThan = WorkflowExpression.Compile(newerThan, nameof(newerThan), required: false);
            var __workflow_threaded = WorkflowExpression.Compile(threaded, nameof(threaded), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<PageableMessageListV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/messages/following.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["network_id"] = Convert.ToString("Default");
                if (__workflow_networkId != null)
                    callPayload.Queries["network_id"] = ExpressionConverter.Convert(__workflow_networkId);
                if (__workflow_olderThan != null)
                    callPayload.Queries["older_than"] = ExpressionConverter.Convert(__workflow_olderThan);
                if (__workflow_newerThan != null)
                    callPayload.Queries["newer_than"] = ExpressionConverter.Convert(__workflow_newerThan);
                if (__workflow_threaded != null)
                    callPayload.Queries["threaded"] = ExpressionConverter.Convert(__workflow_threaded);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<PageableMessageListV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yammer")]
        public IBodyWorkflowAction<PageableMessageListV2, ApiConnectionActionConfiguration> GetMessagesInGroup(Expression<Func<int>> groupId, Expression<Func<string>> networkId = null, Expression<Func<int>> olderThan = null, Expression<Func<int>> newerThan = null, Expression<Func<threadedInput>> threaded = null, Expression<Func<int>> limit = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_networkId = WorkflowExpression.Compile(networkId, nameof(networkId), required: false);
            var __workflow_olderThan = WorkflowExpression.Compile(olderThan, nameof(olderThan), required: false);
            var __workflow_newerThan = WorkflowExpression.Compile(newerThan, nameof(newerThan), required: false);
            var __workflow_threaded = WorkflowExpression.Compile(threaded, nameof(threaded), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<PageableMessageListV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/messages/in_group/{0}.json", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["network_id"] = Convert.ToString("Default");
                if (__workflow_networkId != null)
                    callPayload.Queries["network_id"] = ExpressionConverter.Convert(__workflow_networkId);
                if (__workflow_olderThan != null)
                    callPayload.Queries["older_than"] = ExpressionConverter.Convert(__workflow_olderThan);
                if (__workflow_newerThan != null)
                    callPayload.Queries["newer_than"] = ExpressionConverter.Convert(__workflow_newerThan);
                if (__workflow_threaded != null)
                    callPayload.Queries["threaded"] = ExpressionConverter.Convert(__workflow_threaded);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<PageableMessageListV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yammer")]
        public IBodyWorkflowAction<PageableMessageListV2, ApiConnectionActionConfiguration> GetMessagesInThread(Expression<Func<int>> threadId)
        {
            var __workflow_threadId = WorkflowExpression.Compile(threadId, nameof(threadId), required: true);
            return new DeferredBodyAction<PageableMessageListV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/messages/in_thread/{0}.json", __workflow_threadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PageableMessageListV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yammer")]
        public IBodyWorkflowAction<MessageListV2, ApiConnectionActionConfiguration> PostMessage(Expression<Func<int>> inputgroupId, Expression<Func<string>> inputmessageText, Expression<Func<string>> networkId = null, Expression<Func<int>> inputrepliedToId = null, Expression<Func<int>> inputdirectToId = null, Expression<Func<bool>> inputbroadcast = null, Expression<Func<string>> inputtitle = null)
        {
            var __workflow_inputgroupId = WorkflowExpression.Compile(inputgroupId, nameof(inputgroupId), required: true);
            var __workflow_inputmessageText = WorkflowExpression.Compile(inputmessageText, nameof(inputmessageText), required: true);
            var __workflow_networkId = WorkflowExpression.Compile(networkId, nameof(networkId), required: false);
            var __workflow_inputrepliedToId = WorkflowExpression.Compile(inputrepliedToId, nameof(inputrepliedToId), required: false);
            var __workflow_inputdirectToId = WorkflowExpression.Compile(inputdirectToId, nameof(inputdirectToId), required: false);
            var __workflow_inputbroadcast = WorkflowExpression.Compile(inputbroadcast, nameof(inputbroadcast), required: false);
            var __workflow_inputtitle = WorkflowExpression.Compile(inputtitle, nameof(inputtitle), required: false);
            return new DeferredBodyAction<MessageListV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/messages.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["network_id"] = Convert.ToString("Default");
                if (__workflow_networkId != null)
                    callPayload.Queries["network_id"] = ExpressionConverter.Convert(__workflow_networkId);
                var input = new JObject();
                var inputpropCount = 0;
                inputpropCount++;
                input["group_id"] = ExpressionConverter.ConvertO(__workflow_inputgroupId);
                inputpropCount++;
                input["body"] = ExpressionConverter.ConvertO(__workflow_inputmessageText);
                if (__workflow_inputrepliedToId != null)
                {
                    input["replied_to_id"] = ExpressionConverter.ConvertO(__workflow_inputrepliedToId);
                    inputpropCount++;
                }

                if (__workflow_inputdirectToId != null)
                {
                    input["direct_to_id"] = ExpressionConverter.ConvertO(__workflow_inputdirectToId);
                    inputpropCount++;
                }

                if (__workflow_inputbroadcast != null)
                {
                    input["broadcast"] = ExpressionConverter.ConvertO(__workflow_inputbroadcast);
                    inputpropCount++;
                }

                if (__workflow_inputtitle != null)
                {
                    input["title"] = ExpressionConverter.ConvertO(__workflow_inputtitle);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<MessageListV2>(callPayload);
            });
        }
    }

    public class YammerTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<MessageListV2, ApiConnectionTriggerConfiguration> OnNewMessagesFollowing(Expression<Func<string>> networkId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_networkId = WorkflowExpression.Compile(networkId, nameof(networkId), required: false);
            return new DeferredBodyTrigger<MessageListV2, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/trigger/messages/following.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["network_id"] = Convert.ToString("Default");
                if (__workflow_networkId != null)
                    callPayload.Queries["network_id"] = ExpressionConverter.Convert(__workflow_networkId);
                return new ApiConnectionTrigger<MessageListV2>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<MessageListV2, ApiConnectionTriggerConfiguration> OnNewMessagesInGroup(Expression<Func<int>> groupId, Expression<Func<string>> networkId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_networkId = WorkflowExpression.Compile(networkId, nameof(networkId), required: false);
            return new DeferredBodyTrigger<MessageListV2, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/trigger/in_group/{0}.json", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["network_id"] = Convert.ToString("Default");
                if (__workflow_networkId != null)
                    callPayload.Queries["network_id"] = ExpressionConverter.Convert(__workflow_networkId);
                return new ApiConnectionTrigger<MessageListV2>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class Network
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("permalink")]
        public string Link { get; set; }
    }

    public class YammmerEntity
    {
        [JsonProperty("type")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public int GroupId { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }
    }

    public class User
    {
        [JsonProperty("name")]
        public string Username { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("web_url")]
        public string ProfileUrl { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("birth_date")]
        public string BirthDate { get; set; }

        [JsonProperty("mugshot_url")]
        public string PhotoUrl { get; set; }
    }

    public class PageableMessageListV2
    {
        [JsonProperty("value")]
        public MessageV2[] Messages { get; set; }
    }

    public class MessageV2
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("content_excerpt")]
        public string Text { get; set; }

        [JsonProperty("sender_id")]
        public int Sender { get; set; }

        [JsonProperty("replied_to_id")]
        public int RepliedTo { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("network_id")]
        public int Network { get; set; }

        [JsonProperty("message_type")]
        public string Type { get; set; }

        [JsonProperty("sender_type")]
        public string SenderType { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("web_url")]
        public string WebUrl { get; set; }

        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        [JsonProperty("body")]
        public MessageBody Body { get; set; }

        [JsonProperty("thread_id")]
        public int ThreadId { get; set; }

        [JsonProperty("direct_message")]
        public bool DirectMessage { get; set; }

        [JsonProperty("client_type")]
        public string ClientId { get; set; }

        [JsonProperty("client_url")]
        public string ClientURL { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("notified_user_ids")]
        public int[] TaggedUser { get; set; }

        [JsonProperty("privacy")]
        public string Privacy { get; set; }

        [JsonProperty("liked_by")]
        public LikedBy LikedBy { get; set; }

        [JsonProperty("system_message")]
        public bool IsSystemMessage { get; set; }
    }

    public class MessageBody
    {
        [JsonProperty("parsed")]
        public string Text { get; set; }

        [JsonProperty("plain")]
        public string Plain { get; set; }

        [JsonProperty("rich")]
        public string Rich { get; set; }
    }

    public class LikedBy
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("names")]
        public LikedByNamesTypeItem[] Names { get; set; }
    }

    public class LikedByNamesTypeItem
    {
        [JsonProperty("full_name")]
        public string FullName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum threadedInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "extended")]
        Extended,
        [EnumMember(Value = "false")]
        False
    }

    public class MessageListV2
    {
        [JsonProperty("messages")]
        public MessageV2[] Messages { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Yammer;

    public partial class WorkflowManagedActions
    {
        public YammerActions Yammer(string connectionId) => new YammerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public YammerTriggers Yammer(string connectionId) => new YammerTriggers(connectionId);
    }
}