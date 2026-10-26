//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Chatter
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ChatterActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "chatter")]
        public IBodyWorkflowAction<CreatePostInGroupResponse, ApiConnectionActionConfiguration> CreatePostInGroup(Expression<Func<string>> bodygroupId, Expression<Func<string>> createPostInGroupText)
        {
            var __workflow_bodygroupId = WorkflowExpression.Compile(bodygroupId, nameof(bodygroupId), required: true);
            var __workflow_createPostInGroupText = WorkflowExpression.Compile(createPostInGroupText, nameof(createPostInGroupText), required: true);
            return new DeferredBodyAction<CreatePostInGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/services/data/v38.0/chatter/feed-elements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["CreatePostInGroupText"] = ExpressionConverter.Convert(__workflow_createPostInGroupText);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["subjectId"] = ExpressionConverter.ConvertO(__workflow_bodygroupId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreatePostInGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "chatter")]
        public IBodyWorkflowAction<ListGroupMembersResponse, ApiConnectionActionConfiguration> ListGroupMembers(Expression<Func<string>> groupId)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            return new DeferredBodyAction<ListGroupMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/services/data/v38.0/chatter/groups/{0}/members", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListGroupMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "chatter")]
        public IBodyWorkflowAction<GroupMemberResponse, ApiConnectionActionConfiguration> AddUserToGroup(Expression<Func<string>> groupId, Expression<Func<string>> bodysalesforceUserId)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_bodysalesforceUserId = WorkflowExpression.Compile(bodysalesforceUserId, nameof(bodysalesforceUserId), required: true);
            return new DeferredBodyAction<GroupMemberResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/services/data/v38.0/chatter/groups/{0}/members", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userId"] = ExpressionConverter.ConvertO(__workflow_bodysalesforceUserId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GroupMemberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "chatter")]
        public IBodyWorkflowAction<UserUserResponse, ApiConnectionActionConfiguration> GetUser(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<UserUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/services/data/v38.0/chatter/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "chatter")]
        public IBodyWorkflowAction<GetPostResponse, ApiConnectionActionConfiguration> Get(Expression<Func<string>> postId)
        {
            var __workflow_postId = WorkflowExpression.Compile(postId, nameof(postId), required: true);
            return new DeferredBodyAction<GetPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/services/data/v38.0/chatter/feed-elements/{0}", __workflow_postId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPostResponse>(callPayload);
            });
        }
    }

    public class ChatterTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ListPostsByGroupResponse, ApiConnectionTriggerConfiguration> TrigNewPostInGroup(Expression<Func<string>> groupId, FlowRecurrence recurrence = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            return new DeferredBodyTrigger<ListPostsByGroupResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/new_post_trigger/services/data/v38.0/chatter/feeds/record/{0}/feed-elements", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListPostsByGroupResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CreatePostInGroupResponse
    {
        [JsonProperty("actor")]
        public ActorUserResponse Actor { get; set; }

        [JsonProperty("body")]
        public CreatePostInGroupResponsePostBodyType PostBody { get; set; }

        [JsonProperty("createdDate")]
        public string DatePosted { get; set; }

        [JsonProperty("header")]
        public CreatePostInGroupResponseHeaderType Header { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("parent")]
        public CreatePostInGroupResponseParentType Parent { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("visibility")]
        public string Visbility { get; set; }
    }

    public class ActorUserResponse
    {
        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public string UserId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("photo")]
        public ActorUserResponsePhotoType Photo { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ActorUserResponsePhotoType
    {
        [JsonProperty("largePhotoUrl")]
        public string Large { get; set; }

        [JsonProperty("mediumPhotoUrl")]
        public string Medium { get; set; }

        [JsonProperty("smallPhotoUrl")]
        public string Small { get; set; }
    }

    public class CreatePostInGroupResponsePostBodyType
    {
        [JsonProperty("isRichText")]
        public bool IsRichText { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class CreatePostInGroupResponseHeaderType
    {
        [JsonProperty("isRichText")]
        public string IsRichText { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class CreatePostInGroupResponseParentType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner")]
        public OwnerUserResponse Owner { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("visibility")]
        public string Visbility { get; set; }
    }

    public class OwnerUserResponse
    {
        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public string UserId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("photo")]
        public OwnerUserResponsePhotoType Photo { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class OwnerUserResponsePhotoType
    {
        [JsonProperty("largePhotoUrl")]
        public string Large { get; set; }

        [JsonProperty("mediumPhotoUrl")]
        public string Medium { get; set; }

        [JsonProperty("smallPhotoUrl")]
        public string Small { get; set; }
    }

    public class ListGroupMembersResponse
    {
        [JsonProperty("members")]
        public GroupMemberResponse[] Members { get; set; }

        [JsonProperty("totalMemberCount")]
        public int TotalMemberCount { get; set; }
    }

    public class GroupMemberResponse
    {
        [JsonProperty("id")]
        public string MemberId { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("user")]
        public UserUserResponse User { get; set; }
    }

    public class UserUserResponse
    {
        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("photo")]
        public UserUserResponsePhotoType Photo { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class UserUserResponsePhotoType
    {
        [JsonProperty("largePhotoUrl")]
        public string Large { get; set; }

        [JsonProperty("mediumPhotoUrl")]
        public string Medium { get; set; }

        [JsonProperty("smallPhotoUrl")]
        public string Small { get; set; }
    }

    public class GetPostResponse
    {
        [JsonProperty("actor")]
        public ActorUserResponse Actor { get; set; }

        [JsonProperty("body")]
        public GetPostResponsePostBodyType PostBody { get; set; }

        [JsonProperty("createdDate")]
        public string DatePosted { get; set; }

        [JsonProperty("header")]
        public GetPostResponseHeaderType Header { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("parent")]
        public GetPostResponseParentType Parent { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("visibility")]
        public string Visbility { get; set; }
    }

    public class GetPostResponsePostBodyType
    {
        [JsonProperty("isRichText")]
        public bool IsRichText { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetPostResponseHeaderType
    {
        [JsonProperty("isRichText")]
        public string IsRichText { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetPostResponseParentType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner")]
        public OwnerUserResponse Owner { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("visibility")]
        public string Visbility { get; set; }
    }

    public class ListPostsByGroupResponse
    {
        [JsonProperty("elements")]
        public ListPostsByGroupResponseElementsTypeItem[] Elements { get; set; }
    }

    public class ListPostsByGroupResponseElementsTypeItem
    {
        [JsonProperty("actor")]
        public ActorUserResponse Actor { get; set; }

        [JsonProperty("body")]
        public ListPostsByGroupResponseElementsTypeItemPostBodyType PostBody { get; set; }

        [JsonProperty("createdDate")]
        public string DatePosted { get; set; }

        [JsonProperty("header")]
        public ListPostsByGroupResponseElementsTypeItemHeaderType Header { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("parent")]
        public ListPostsByGroupResponseElementsTypeItemParentType Parent { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("visibility")]
        public string Visbility { get; set; }
    }

    public class ListPostsByGroupResponseElementsTypeItemPostBodyType
    {
        [JsonProperty("isRichText")]
        public bool IsRichText { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class ListPostsByGroupResponseElementsTypeItemHeaderType
    {
        [JsonProperty("isRichText")]
        public string IsRichText { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class ListPostsByGroupResponseElementsTypeItemParentType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner")]
        public OwnerUserResponse Owner { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("visibility")]
        public string Visbility { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Chatter;

    public partial class WorkflowManagedActions
    {
        public ChatterActions Chatter(string connectionId) => new ChatterActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ChatterTriggers Chatter(string connectionId) => new ChatterTriggers(connectionId);
    }
}