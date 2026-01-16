//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Huddoboards
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HuddoboardsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<Node[]> BoardSearch(Expression<Func<string>> q = null)
        {
            var apiCallPath = "/board";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            return new ApiConnectionAction<Node[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IWorkflowAction BoardCreate(Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodytemplateId = null)
        {
            var apiCallPath = "/board";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodytemplateId != null)
            {
                body["sourceId"] = ExpressionConverter.ConvertO(bodytemplateId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<Board> Board(Expression<Func<string>> boardId)
        {
            var apiCallPath = String.Format("/board/{0}", ExpressionConverter.ConvertWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Board>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<NodeSummary[]> Cards(Expression<Func<string>> boardId, Expression<Func<typeInput>> type = null, Expression<Func<string>> q = null)
        {
            var apiCallPath = String.Format("/board/{0}/cards", ExpressionConverter.ConvertWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            return new ApiConnectionAction<NodeSummary[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<Member[]> BoardMembers(Expression<Func<string>> boardId, Expression<Func<bool>> expand = null, Expression<Func<string>> q = null)
        {
            var apiCallPath = String.Format("/board/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (expand != null)
                callPayload.Queries["expand"] = ExpressionConverter.Convert(expand);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            return new ApiConnectionAction<Member[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<Board[]> BoardMy(Expression<Func<bool>> template = null)
        {
            var apiCallPath = "/board/my";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (template != null)
                callPayload.Queries["template"] = ExpressionConverter.Convert(template);
            return new ApiConnectionAction<Board[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IWorkflowAction NodeCreate(Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyboard = null, Expression<Func<string>> bodyparent = null, Expression<Func<bodytypeInput>> bodytype = null, Expression<Func<string>> bodydescription = null)
        {
            var apiCallPath = "/node";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyboard != null)
            {
                body["boardId"] = ExpressionConverter.ConvertO(bodyboard);
                bodypropCount++;
            }

            if (bodyparent != null)
            {
                body["parentId"] = ExpressionConverter.ConvertO(bodyparent);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<Node> Node(Expression<Func<string>> nodeId)
        {
            var apiCallPath = String.Format("/node/{0}", ExpressionConverter.ConvertWithUrlEncoding(nodeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Node>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IWorkflowAction Assign(Expression<Func<string>> nodeId, Expression<Func<string>> bodyuserId = null)
        {
            var apiCallPath = String.Format("/node/{0}/assign", ExpressionConverter.ConvertWithUrlEncoding(nodeId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyuserId != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyuserId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<Node[]> Children(Expression<Func<string>> nodeId)
        {
            var apiCallPath = String.Format("/node/{0}/children", ExpressionConverter.ConvertWithUrlEncoding(nodeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Node[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<Node[]> Comments(Expression<Func<string>> nodeId)
        {
            var apiCallPath = String.Format("/node/{0}/comments", ExpressionConverter.ConvertWithUrlEncoding(nodeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Node[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IWorkflowAction CreateAComment(Expression<Func<string>> nodeId, Expression<Func<string>> bodydescription = null)
        {
            var apiCallPath = String.Format("/node/{0}/comments", ExpressionConverter.ConvertWithUrlEncoding(nodeId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IWorkflowAction IncompleteTask(Expression<Func<string>> nodeId)
        {
            var apiCallPath = String.Format("/node/{0}/complete", ExpressionConverter.ConvertWithUrlEncoding(nodeId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IWorkflowAction CompleteTask(Expression<Func<string>> nodeId)
        {
            var apiCallPath = String.Format("/node/{0}/complete", ExpressionConverter.ConvertWithUrlEncoding(nodeId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IWorkflowAction NodeDate(Expression<Func<string>> nodeId, Expression<Func<string>> bodystart = null, Expression<Func<string>> bodydue = null, Expression<Func<string>> bodyend = null)
        {
            var apiCallPath = String.Format("/node/{0}/dates", ExpressionConverter.ConvertWithUrlEncoding(nodeId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodystart != null)
            {
                body["start"] = ExpressionConverter.ConvertO(bodystart);
                bodypropCount++;
            }

            if (bodydue != null)
            {
                body["due"] = ExpressionConverter.ConvertO(bodydue);
                bodypropCount++;
            }

            if (bodyend != null)
            {
                body["end"] = ExpressionConverter.ConvertO(bodyend);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<Node[]> FindTask(Expression<Func<string>> q = null, Expression<Func<bool>> completed = null)
        {
            var apiCallPath = "/todo/assigned";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (completed != null)
                callPayload.Queries["completed"] = ExpressionConverter.Convert(completed);
            return new ApiConnectionAction<Node[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<User[]> User(Expression<Func<string>> q)
        {
            var apiCallPath = "/user";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            return new ApiConnectionAction<User[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<User> UserMe()
        {
            var apiCallPath = "/user/me";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<User>(callPayload);
        }
    }

    public class HuddoboardsTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<NodeSummary> AddedToBoard(string triggerName = null)
        {
            var apiCallPath = "/webhook/added-to-board";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callback"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<NodeSummary>(callPayload);
        }

        public IOutputWorkflowTrigger<NodeSummary> AssignedTask(string triggerName = null)
        {
            var apiCallPath = "/webhook/assigned-task";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callback"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<NodeSummary>(callPayload);
        }

        public IOutputWorkflowTrigger<NodeSummary> BoardTaskCompleted(Expression<Func<string>> boardId, string triggerName = null)
        {
            var apiCallPath = String.Format("/webhook/board-task-completed/{0}", ExpressionConverter.ConvertWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callback"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<NodeSummary>(callPayload);
        }

        public IOutputWorkflowTrigger<NodeSummary> CreatedNode(Expression<Func<string>> boardId, string triggerName = null)
        {
            var apiCallPath = String.Format("/webhook/created-node/{0}", ExpressionConverter.ConvertWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callback"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<NodeSummary>(callPayload);
        }

        public IOutputWorkflowTrigger<NodeSummary> MyTaskCompleted(string triggerName = null)
        {
            var apiCallPath = "/webhook/my-task-completed";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callback"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<NodeSummary>(callPayload);
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

    public enum bodytypeInput
    {
        [EnumMember(Value = "task")]
        TaskObject,
        [EnumMember(Value = "entry")]
        Entry,
        [EnumMember(Value = "list")]
        List
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
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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