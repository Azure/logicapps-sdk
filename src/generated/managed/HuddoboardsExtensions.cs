//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Huddoboards
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HuddoboardsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<Node[], ApiConnectionActionConfiguration> BoardSearch(Expression<Func<string>> q = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            return new DeferredBodyAction<Node[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/board";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                return new ApiConnectionAction<Node[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BoardCreate(Expression<Func<BoardCreateInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/board";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<Board, ApiConnectionActionConfiguration> Board(Expression<Func<string>> boardId)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            return new DeferredBodyAction<Board, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/board/{0}", __workflow_boardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Board>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<NodeSummary[], ApiConnectionActionConfiguration> Cards(Expression<Func<string>> boardId, Expression<Func<typeInput>> type = null, Expression<Func<string>> q = null)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            return new DeferredBodyAction<NodeSummary[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/board/{0}/cards", __workflow_boardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                return new ApiConnectionAction<NodeSummary[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<Member[], ApiConnectionActionConfiguration> BoardMembers(Expression<Func<string>> boardId, Expression<Func<bool>> expand = null, Expression<Func<string>> q = null)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            return new DeferredBodyAction<Member[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/board/{0}/members", __workflow_boardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_expand != null)
                    callPayload.Queries["expand"] = ExpressionConverter.Convert(__workflow_expand);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                return new ApiConnectionAction<Member[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<Board[], ApiConnectionActionConfiguration> BoardMy(Expression<Func<bool>> template = null)
        {
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: false);
            return new DeferredBodyAction<Board[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/board/my";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_template != null)
                    callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                return new ApiConnectionAction<Board[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IWorkflowAction<ApiConnectionActionConfiguration> NodeCreate(Expression<Func<NodeCreateInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/node";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<Node, ApiConnectionActionConfiguration> Node(Expression<Func<string>> nodeId)
        {
            var __workflow_nodeId = WorkflowExpression.Compile(nodeId, nameof(nodeId), required: true);
            return new DeferredBodyAction<Node, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/node/{0}", __workflow_nodeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Node>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Assign(Expression<Func<string>> nodeId, Expression<Func<AssignInput>> body = null)
        {
            var __workflow_nodeId = WorkflowExpression.Compile(nodeId, nameof(nodeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/node/{0}/assign", __workflow_nodeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<Node[], ApiConnectionActionConfiguration> Children(Expression<Func<string>> nodeId)
        {
            var __workflow_nodeId = WorkflowExpression.Compile(nodeId, nameof(nodeId), required: true);
            return new DeferredBodyAction<Node[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/node/{0}/children", __workflow_nodeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Node[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<Node[], ApiConnectionActionConfiguration> Comments(Expression<Func<string>> nodeId)
        {
            var __workflow_nodeId = WorkflowExpression.Compile(nodeId, nameof(nodeId), required: true);
            return new DeferredBodyAction<Node[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/node/{0}/comments", __workflow_nodeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Node[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateAComment(Expression<Func<string>> nodeId, Expression<Func<CreateACommentInput>> body)
        {
            var __workflow_nodeId = WorkflowExpression.Compile(nodeId, nameof(nodeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/node/{0}/comments", __workflow_nodeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IWorkflowAction<ApiConnectionActionConfiguration> IncompleteTask(Expression<Func<string>> nodeId)
        {
            var __workflow_nodeId = WorkflowExpression.Compile(nodeId, nameof(nodeId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/node/{0}/complete", __workflow_nodeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CompleteTask(Expression<Func<string>> nodeId)
        {
            var __workflow_nodeId = WorkflowExpression.Compile(nodeId, nameof(nodeId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/node/{0}/complete", __workflow_nodeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IWorkflowAction<ApiConnectionActionConfiguration> NodeDate(Expression<Func<string>> nodeId, Expression<Func<NodeDateInput>> body)
        {
            var __workflow_nodeId = WorkflowExpression.Compile(nodeId, nameof(nodeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/node/{0}/dates", __workflow_nodeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<Node[], ApiConnectionActionConfiguration> FindTask(Expression<Func<string>> q = null, Expression<Func<bool>> completed = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_completed = WorkflowExpression.Compile(completed, nameof(completed), required: false);
            return new DeferredBodyAction<Node[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/todo/assigned";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_completed != null)
                    callPayload.Queries["completed"] = ExpressionConverter.Convert(__workflow_completed);
                return new ApiConnectionAction<Node[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<User[], ApiConnectionActionConfiguration> User(Expression<Func<string>> q)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: true);
            return new DeferredBodyAction<User[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/user";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                return new ApiConnectionAction<User[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<User, ApiConnectionActionConfiguration> UserMe()
        {
            return new DeferredBodyAction<User, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/user/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<User>(callPayload);
            });
        }
    }

    public class HuddoboardsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<NodeSummary, ApiConnectionTriggerConfiguration> AddedToBoard(Expression<Func<AddedToBoardInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<NodeSummary, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/added-to-board";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<NodeSummary>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<NodeSummary, ApiConnectionTriggerConfiguration> AssignedTask(Expression<Func<AssignedTaskInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<NodeSummary, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/assigned-task";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<NodeSummary>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<NodeSummary, ApiConnectionTriggerConfiguration> BoardTaskCompleted(Expression<Func<string>> boardId, Expression<Func<BoardTaskCompletedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<NodeSummary, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/webhook/board-task-completed/{0}", __workflow_boardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<NodeSummary>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<NodeSummary, ApiConnectionTriggerConfiguration> CreatedNode(Expression<Func<string>> boardId, Expression<Func<CreatedNodeInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<NodeSummary, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/webhook/created-node/{0}", __workflow_boardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<NodeSummary>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<NodeSummary, ApiConnectionTriggerConfiguration> MyTaskCompleted(Expression<Func<MyTaskCompletedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<NodeSummary, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/my-task-completed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<NodeSummary>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class Node
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("boardId")]
        public string BoardId { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }
    }

    public class BoardCreateInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sourceId")]
        public string TemplateId { get; set; }
    }

    public class Board
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("childNodes")]
        public NodeWithChildren[] ChildNodes { get; set; }
    }

    public class NodeWithChildren
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("boardId")]
        public string BoardId { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("childNodes")]
        public Node[] ChildNodes { get; set; }
    }

    public class NodeSummary
    {
        [JsonProperty("payload")]
        public NodeSummaryPayloadType Payload { get; set; }
    }

    public class NodeSummaryPayloadType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("listId")]
        public string ListId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("boardId")]
        public string BoardId { get; set; }

        [JsonProperty("board")]
        public string Board { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum typeInput
    {
        [EnumMember(Value = "task")]
        TaskObject,
        [EnumMember(Value = "entry")]
        Entry,
        [EnumMember(Value = "list")]
        List
    }

    public class Member
    {
        [JsonProperty("board")]
        public string Board { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("entity")]
        public MemberEntityType Entity { get; set; }
    }

    public class MemberEntityType
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("source")]
        public MemberEntityTypeSourceType Source { get; set; }
    }

    public class MemberEntityTypeSourceType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }
    }

    public class NodeCreateInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("boardId")]
        public string Board { get; set; }

        [JsonProperty("parentId")]
        public string Parent { get; set; }

        [JsonProperty("type")]
        public NodeCreateInputTypeType? Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NodeCreateInputTypeType
    {
        [EnumMember(Value = "task")]
        TaskObject,
        [EnumMember(Value = "entry")]
        Entry,
        [EnumMember(Value = "list")]
        List
    }

    public class AssignInput
    {
        [JsonProperty("id")]
        public string UserId { get; set; }
    }

    public class CreateACommentInput
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class NodeDateInput
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("due")]
        public string Due { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class User
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("organisation")]
        public string Organisation { get; set; }

        [JsonProperty("aliases")]
        public UserAliasesTypeItem[] Aliases { get; set; }
    }

    public class UserAliasesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("organisation")]
        public string Organisation { get; set; }

        [JsonProperty("providerURL")]
        public string ProviderURL { get; set; }
    }

    public class AddedToBoardInput
    {
        [JsonProperty("callback", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callback { get; set; } = "#{listCallbackUrl()}";
    }

    public class AssignedTaskInput
    {
        [JsonProperty("callback", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callback { get; set; } = "#{listCallbackUrl()}";
    }

    public class BoardTaskCompletedInput
    {
        [JsonProperty("callback", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callback { get; set; } = "#{listCallbackUrl()}";
    }

    public class CreatedNodeInput
    {
        [JsonProperty("callback", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callback { get; set; } = "#{listCallbackUrl()}";
    }

    public class MyTaskCompletedInput
    {
        [JsonProperty("callback", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callback { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Huddoboards;

    public partial class WorkflowManagedActions
    {
        public HuddoboardsActions Huddoboards(string connectionId) => new HuddoboardsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HuddoboardsTriggers Huddoboards(string connectionId) => new HuddoboardsTriggers(connectionId);
    }
}