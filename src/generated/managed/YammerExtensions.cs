//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Yammer
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class YammerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yammer")]
        public IBodyWorkflowAction<Network[]> GetNetworks()
        {
            var apiCallPath = "/networks.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Network[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yammer")]
        public IBodyWorkflowAction<YammmerEntity[]> GetGroups(Expression<Func<string>> networkId = null, Expression<Func<int>> mine = null, Expression<Func<int>> showAllCompanyGroup = null)
        {
            var apiCallPath = "/groups.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["network_id"] = Convert.ToString("Default");
            if (networkId != null)
                callPayload.Queries["network_id"] = ExpressionConverter.Convert(networkId);
            callPayload.Queries["mine"] = Convert.ToString(1);
            if (mine != null)
                callPayload.Queries["mine"] = ExpressionConverter.Convert(mine);
            callPayload.Queries["showAllCompanyGroup"] = Convert.ToString(0);
            if (showAllCompanyGroup != null)
                callPayload.Queries["showAllCompanyGroup"] = ExpressionConverter.Convert(showAllCompanyGroup);
            return new ApiConnectionAction<YammmerEntity[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yammer")]
        public IBodyWorkflowAction<MessageListV2> PostMessageV2(Expression<Func<int>> inputgroupID, Expression<Func<string>> inputmessageText, Expression<Func<string>> networkId = null, Expression<Func<int>> inputrepliedToId = null, Expression<Func<int>> inputdirectToId = null, Expression<Func<bool>> inputbroadcast = null, Expression<Func<string>> inputtitle = null)
        {
            var apiCallPath = "/v2/messages.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["network_id"] = Convert.ToString("Default");
            if (networkId != null)
                callPayload.Queries["network_id"] = ExpressionConverter.Convert(networkId);
            var input = new JObject();
            var inputpropCount = 0;
            inputpropCount++;
            input["group_id"] = ExpressionConverter.ConvertO(inputgroupID);
            inputpropCount++;
            input["body"] = ExpressionConverter.ConvertO(inputmessageText);
            if (inputrepliedToId != null)
            {
                input["replied_to_id"] = ExpressionConverter.ConvertO(inputrepliedToId);
                inputpropCount++;
            }

            if (inputdirectToId != null)
            {
                input["direct_to_id"] = ExpressionConverter.ConvertO(inputdirectToId);
                inputpropCount++;
            }

            if (inputbroadcast != null)
            {
                input["broadcast"] = ExpressionConverter.ConvertO(inputbroadcast);
                inputpropCount++;
            }

            if (inputtitle != null)
            {
                input["title"] = ExpressionConverter.ConvertO(inputtitle);
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<MessageListV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yammer")]
        public IBodyWorkflowAction<PageableMessageListV2> GetAllMessagesV3(Expression<Func<string>> networkId = null, Expression<Func<int>> olderThan = null, Expression<Func<int>> newerThan = null, Expression<Func<threadedInput>> threaded = null, Expression<Func<int>> limit = null)
        {
            var apiCallPath = "/v3/messages.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["network_id"] = Convert.ToString("Default");
            if (networkId != null)
                callPayload.Queries["network_id"] = ExpressionConverter.Convert(networkId);
            if (olderThan != null)
                callPayload.Queries["older_than"] = ExpressionConverter.Convert(olderThan);
            if (newerThan != null)
                callPayload.Queries["newer_than"] = ExpressionConverter.Convert(newerThan);
            if (threaded != null)
                callPayload.Queries["threaded"] = ExpressionConverter.Convert(threaded);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            return new ApiConnectionAction<PageableMessageListV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yammer")]
        public IBodyWorkflowAction<PageableMessageListV2> GetMessagesFollowingV3(Expression<Func<string>> networkId = null, Expression<Func<int>> olderThan = null, Expression<Func<int>> newerThan = null, Expression<Func<threadedInput>> threaded = null, Expression<Func<int>> limit = null)
        {
            var apiCallPath = "/v3/messages/following.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["network_id"] = Convert.ToString("Default");
            if (networkId != null)
                callPayload.Queries["network_id"] = ExpressionConverter.Convert(networkId);
            if (olderThan != null)
                callPayload.Queries["older_than"] = ExpressionConverter.Convert(olderThan);
            if (newerThan != null)
                callPayload.Queries["newer_than"] = ExpressionConverter.Convert(newerThan);
            if (threaded != null)
                callPayload.Queries["threaded"] = ExpressionConverter.Convert(threaded);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            return new ApiConnectionAction<PageableMessageListV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yammer")]
        public IBodyWorkflowAction<PageableMessageListV2> GetMessagesInGroupV3(Expression<Func<int>> groupId, Expression<Func<string>> networkId = null, Expression<Func<int>> olderThan = null, Expression<Func<int>> newerThan = null, Expression<Func<threadedInput>> threaded = null, Expression<Func<int>> limit = null)
        {
            var apiCallPath = String.Format("/v3/messages/in_group/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["network_id"] = Convert.ToString("Default");
            if (networkId != null)
                callPayload.Queries["network_id"] = ExpressionConverter.Convert(networkId);
            if (olderThan != null)
                callPayload.Queries["older_than"] = ExpressionConverter.Convert(olderThan);
            if (newerThan != null)
                callPayload.Queries["newer_than"] = ExpressionConverter.Convert(newerThan);
            if (threaded != null)
                callPayload.Queries["threaded"] = ExpressionConverter.Convert(threaded);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            return new ApiConnectionAction<PageableMessageListV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yammer")]
        public IBodyWorkflowAction<PageableMessageListV2> GetMessagesInThreadV3(Expression<Func<int>> threadId)
        {
            var apiCallPath = String.Format("/v3/messages/in_thread/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(threadId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PageableMessageListV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yammer")]
        public IBodyWorkflowAction<User> GetUserDetailsById(Expression<Func<int>> userId)
        {
            var apiCallPath = String.Format("/users/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<User>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yammer")]
        public IWorkflowAction LikeMessage(Expression<Func<string>> messageId)
        {
            var apiCallPath = "/messages/liked_by/current.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["message_id"] = ExpressionConverter.Convert(messageId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class YammerTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<MessageListV2> OnNewMessagesFollowingV2(Expression<Func<string>> networkId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v2/trigger/messages/following.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["network_id"] = Convert.ToString("Default");
            if (networkId != null)
                callPayload.Queries["network_id"] = ExpressionConverter.Convert(networkId);
            return new ApiConnectionTrigger<MessageListV2>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<MessageListV2> OnNewMessagesInGroupV2(Expression<Func<int>> groupId, Expression<Func<string>> networkId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/v2/trigger/in_group/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["network_id"] = Convert.ToString("Default");
            if (networkId != null)
                callPayload.Queries["network_id"] = ExpressionConverter.Convert(networkId);
            return new ApiConnectionTrigger<MessageListV2>(callPayload, triggerName, recurrence);
        }
    }

    public class Network
    {
        [JsonProperty("id")]
        public string ID { get; set; }

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
        public int GroupID { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }
    }

    public class MessageListV2
    {
        [JsonProperty("messages")]
        public MessageV2[] Messages { get; set; }
    }

    public class MessageV2
    {
        [JsonProperty("id")]
        public int ID { get; set; }

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
        public int GroupID { get; set; }

        [JsonProperty("body")]
        public MessageBody Body { get; set; }

        [JsonProperty("thread_id")]
        public int ThreadID { get; set; }

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

    public class PageableMessageListV2
    {
        [JsonProperty("value")]
        public MessageV2[] Messages { get; set; }
    }

    public enum threadedInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "extended")]
        Extended,
        [EnumMember(Value = "false")]
        False
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