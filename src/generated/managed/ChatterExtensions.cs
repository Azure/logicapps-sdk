//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Chatter
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ChatterActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "chatter")]
        [WorkflowExpressionFactory(nameof(__BuildCreatePostInGroup))]
        public IBodyWorkflowAction<CreatePostInGroupResponse> CreatePostInGroup([WorkflowExpression] Func<string> bodygroupID, [WorkflowExpression] Func<string> createPostInGroupText)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreatePostInGroupResponse> __BuildCreatePostInGroup(WorkflowValue<string> bodygroupID, WorkflowValue<string> createPostInGroupText)
        {
            WorkflowValue.Validate(bodygroupID, nameof(bodygroupID), required: true);
            WorkflowValue.Validate(createPostInGroupText, nameof(createPostInGroupText), required: true);
            return new DeferredBodyAction<CreatePostInGroupResponse>(() =>
            {
                var apiCallPath = "/services/data/v38.0/chatter/feed-elements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["CreatePostInGroupText"] = ExpressionConverter.Convert(createPostInGroupText);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["subjectId"] = ExpressionConverter.ConvertO(bodygroupID);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreatePostInGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "chatter")]
        [WorkflowExpressionFactory(nameof(__BuildListGroupMembers))]
        public IBodyWorkflowAction<ListGroupMembersResponse> ListGroupMembers([WorkflowExpression] Func<string> groupId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListGroupMembersResponse> __BuildListGroupMembers(WorkflowValue<string> groupId)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            return new DeferredBodyAction<ListGroupMembersResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/services/data/v38.0/chatter/groups/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListGroupMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "chatter")]
        [WorkflowExpressionFactory(nameof(__BuildAddUserToGroup))]
        public IBodyWorkflowAction<GroupMemberResponse> AddUserToGroup([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> bodysalesforceUserID)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GroupMemberResponse> __BuildAddUserToGroup(WorkflowValue<string> groupId, WorkflowValue<string> bodysalesforceUserID)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            WorkflowValue.Validate(bodysalesforceUserID, nameof(bodysalesforceUserID), required: true);
            return new DeferredBodyAction<GroupMemberResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/services/data/v38.0/chatter/groups/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userId"] = ExpressionConverter.ConvertO(bodysalesforceUserID);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GroupMemberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "chatter")]
        [WorkflowExpressionFactory(nameof(__BuildGetUser))]
        public IBodyWorkflowAction<UserUserResponse> GetUser([WorkflowExpression] Func<string> userId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserUserResponse> __BuildGetUser(WorkflowValue<string> userId)
        {
            WorkflowValue.Validate(userId, nameof(userId), required: true);
            return new DeferredBodyAction<UserUserResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/services/data/v38.0/chatter/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "chatter")]
        [WorkflowExpressionFactory(nameof(__BuildGet))]
        public IBodyWorkflowAction<GetPostResponse> Get([WorkflowExpression] Func<string> postId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetPostResponse> __BuildGet(WorkflowValue<string> postId)
        {
            WorkflowValue.Validate(postId, nameof(postId), required: true);
            return new DeferredBodyAction<GetPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/services/data/v38.0/chatter/feed-elements/{0}", ExpressionConverter.ConvertWithUrlEncoding(postId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPostResponse>(callPayload);
            });
        }
    }

    public class ChatterTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildTrigNewPostInGroup))]
        public IBodyWorkflowTrigger<ListPostsByGroupResponse> TrigNewPostInGroup([WorkflowExpression] Func<string> groupId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ListPostsByGroupResponse> __BuildTrigNewPostInGroup(WorkflowValue<string> groupId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            return new DeferredBodyTrigger<ListPostsByGroupResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/new_post_trigger/services/data/v38.0/chatter/feeds/record/{0}/feed-elements", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ListPostsByGroupResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
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
        public string ID { get; set; }

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
        public string UserID { get; set; }

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
        public string ID { get; set; }

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
        public string UserID { get; set; }

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
        public string MemberID { get; set; }

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
        public string ID { get; set; }

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
        public string ID { get; set; }

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
        public string ID { get; set; }

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
        public string ID { get; set; }

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
        public string ID { get; set; }

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
