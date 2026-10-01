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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/networks.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Network[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yammer")]
        public IBodyWorkflowAction<YammmerEntity[]> GetGroups([WorkflowExpression] Func<string> networkId = null, [WorkflowExpression] Func<int> mine = null, [WorkflowExpression] Func<int> showAllCompanyGroup = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/groups.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["network_id"] = Convert.ToString("Default");
                if (networkId != null)
                    callPayload.Queries["network_id"] = SourceExpressionConverter.ConvertO(networkId);
                callPayload.Queries["mine"] = Convert.ToString(1);
                if (mine != null)
                    callPayload.Queries["mine"] = SourceExpressionConverter.ConvertO(mine);
                callPayload.Queries["showAllCompanyGroup"] = Convert.ToString(0);
                if (showAllCompanyGroup != null)
                    callPayload.Queries["showAllCompanyGroup"] = SourceExpressionConverter.ConvertO(showAllCompanyGroup);
                return callPayload;
            }

            return new ApiConnectionAction<YammmerEntity[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yammer")]
        public IBodyWorkflowAction<User> GetUserDetailsById([WorkflowExpression] Func<int> userId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<User>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yammer")]
        public IWorkflowAction LikeMessage([WorkflowExpression] Func<string> messageId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/messages/liked_by/current.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["message_id"] = SourceExpressionConverter.ConvertO(messageId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yammer")]
        public IBodyWorkflowAction<PageableMessageListV2> GetAllMessages([WorkflowExpression] Func<string> networkId = null, [WorkflowExpression] Func<int> olderThan = null, [WorkflowExpression] Func<int> newerThan = null, [WorkflowExpression] Func<threadedInput> threaded = null, [WorkflowExpression] Func<int> limit = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/messages.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["network_id"] = Convert.ToString("Default");
                if (networkId != null)
                    callPayload.Queries["network_id"] = SourceExpressionConverter.ConvertO(networkId);
                if (olderThan != null)
                    callPayload.Queries["older_than"] = SourceExpressionConverter.ConvertO(olderThan);
                if (newerThan != null)
                    callPayload.Queries["newer_than"] = SourceExpressionConverter.ConvertO(newerThan);
                if (threaded != null)
                    callPayload.Queries["threaded"] = SourceExpressionConverter.Convert(threaded);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<PageableMessageListV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yammer")]
        public IBodyWorkflowAction<PageableMessageListV2> GetMessagesFollowing([WorkflowExpression] Func<string> networkId = null, [WorkflowExpression] Func<int> olderThan = null, [WorkflowExpression] Func<int> newerThan = null, [WorkflowExpression] Func<threadedInput> threaded = null, [WorkflowExpression] Func<int> limit = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/messages/following.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["network_id"] = Convert.ToString("Default");
                if (networkId != null)
                    callPayload.Queries["network_id"] = SourceExpressionConverter.ConvertO(networkId);
                if (olderThan != null)
                    callPayload.Queries["older_than"] = SourceExpressionConverter.ConvertO(olderThan);
                if (newerThan != null)
                    callPayload.Queries["newer_than"] = SourceExpressionConverter.ConvertO(newerThan);
                if (threaded != null)
                    callPayload.Queries["threaded"] = SourceExpressionConverter.Convert(threaded);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<PageableMessageListV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yammer")]
        public IBodyWorkflowAction<PageableMessageListV2> GetMessagesInGroup([WorkflowExpression] Func<int> groupId, [WorkflowExpression] Func<string> networkId = null, [WorkflowExpression] Func<int> olderThan = null, [WorkflowExpression] Func<int> newerThan = null, [WorkflowExpression] Func<threadedInput> threaded = null, [WorkflowExpression] Func<int> limit = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/messages/in_group/{0}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["network_id"] = Convert.ToString("Default");
                if (networkId != null)
                    callPayload.Queries["network_id"] = SourceExpressionConverter.ConvertO(networkId);
                if (olderThan != null)
                    callPayload.Queries["older_than"] = SourceExpressionConverter.ConvertO(olderThan);
                if (newerThan != null)
                    callPayload.Queries["newer_than"] = SourceExpressionConverter.ConvertO(newerThan);
                if (threaded != null)
                    callPayload.Queries["threaded"] = SourceExpressionConverter.Convert(threaded);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<PageableMessageListV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yammer")]
        public IBodyWorkflowAction<PageableMessageListV2> GetMessagesInThread([WorkflowExpression] Func<int> threadId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/messages/in_thread/{0}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(threadId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PageableMessageListV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "yammer")]
        public IBodyWorkflowAction<MessageListV2> PostMessage([WorkflowExpression] Func<int> inputgroupId, [WorkflowExpression] Func<string> inputmessageText, [WorkflowExpression] Func<string> networkId = null, [WorkflowExpression] Func<int> inputrepliedToId = null, [WorkflowExpression] Func<int> inputdirectToId = null, [WorkflowExpression] Func<bool> inputbroadcast = null, [WorkflowExpression] Func<string> inputtitle = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/messages.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["network_id"] = Convert.ToString("Default");
                if (networkId != null)
                    callPayload.Queries["network_id"] = SourceExpressionConverter.ConvertO(networkId);
                var input = new JObject();
                var inputpropCount = 0;
                inputpropCount++;
                input["group_id"] = SourceExpressionConverter.ConvertToken(inputgroupId);
                inputpropCount++;
                input["body"] = SourceExpressionConverter.ConvertToken(inputmessageText);
                if (inputrepliedToId != null)
                {
                    input["replied_to_id"] = SourceExpressionConverter.ConvertToken(inputrepliedToId);
                    inputpropCount++;
                }

                if (inputdirectToId != null)
                {
                    input["direct_to_id"] = SourceExpressionConverter.ConvertToken(inputdirectToId);
                    inputpropCount++;
                }

                if (inputbroadcast != null)
                {
                    input["broadcast"] = SourceExpressionConverter.ConvertToken(inputbroadcast);
                    inputpropCount++;
                }

                if (inputtitle != null)
                {
                    input["title"] = SourceExpressionConverter.ConvertToken(inputtitle);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MessageListV2>(BuildSourceInput);
        }
    }

    public class YammerTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<MessageListV2> OnNewMessagesFollowing([WorkflowExpression] Func<string> networkId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/trigger/messages/following.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["network_id"] = Convert.ToString("Default");
                if (networkId != null)
                    callPayload.Queries["network_id"] = SourceExpressionConverter.ConvertO(networkId);
                return callPayload;
            }

            return new ApiConnectionTrigger<MessageListV2>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<MessageListV2> OnNewMessagesInGroup([WorkflowExpression] Func<int> groupId, [WorkflowExpression] Func<string> networkId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/trigger/in_group/{0}.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["network_id"] = Convert.ToString("Default");
                if (networkId != null)
                    callPayload.Queries["network_id"] = SourceExpressionConverter.ConvertO(networkId);
                return callPayload;
            }

            return new ApiConnectionTrigger<MessageListV2>(BuildSourceInput, triggerName, recurrence);
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