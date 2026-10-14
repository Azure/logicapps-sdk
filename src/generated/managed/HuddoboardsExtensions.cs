//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Huddoboards
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class HuddoboardsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<Node[]> BoardSearch(Expression<Func<string>> q = null)
        {
            var __workflow_q = q == null ? null : WorkflowExpression.Compile(q);
            WorkflowExpression.Validate(__workflow_q, nameof(q), required: false);
            return new DeferredBodyAction<Node[]>(() =>
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
        public IWorkflowAction BoardCreate(Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodytemplateId = null)
        {
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodytemplateId = bodytemplateId == null ? null : WorkflowExpression.Compile(bodytemplateId);
            WorkflowExpression.Validate(__workflow_bodytemplateId, nameof(bodytemplateId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/board";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodytemplateId != null)
                {
                    body["sourceId"] = ExpressionConverter.ConvertO(__workflow_bodytemplateId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<Board> Board(Expression<Func<string>> boardId)
        {
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            return new DeferredBodyAction<Board>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/board/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_boardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Board>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<NodeSummary[]> Cards(Expression<Func<string>> boardId, Expression<Func<typeInput>> type = null, Expression<Func<string>> q = null)
        {
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            var __workflow_type = type == null ? null : WorkflowExpression.Compile(type);
            WorkflowExpression.Validate(__workflow_type, nameof(type), required: false);
            var __workflow_q = q == null ? null : WorkflowExpression.Compile(q);
            WorkflowExpression.Validate(__workflow_q, nameof(q), required: false);
            return new DeferredBodyAction<NodeSummary[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/board/{0}/cards", ExpressionConverter.ConvertWithUrlEncoding(__workflow_boardId, 1));
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
        public IBodyWorkflowAction<Member[]> BoardMembers(Expression<Func<string>> boardId, Expression<Func<bool>> expand = null, Expression<Func<string>> q = null)
        {
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            var __workflow_expand = expand == null ? null : WorkflowExpression.Compile(expand);
            WorkflowExpression.Validate(__workflow_expand, nameof(expand), required: false);
            var __workflow_q = q == null ? null : WorkflowExpression.Compile(q);
            WorkflowExpression.Validate(__workflow_q, nameof(q), required: false);
            return new DeferredBodyAction<Member[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/board/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(__workflow_boardId, 1));
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
        public IBodyWorkflowAction<Board[]> BoardMy(Expression<Func<bool>> template = null)
        {
            var __workflow_template = template == null ? null : WorkflowExpression.Compile(template);
            WorkflowExpression.Validate(__workflow_template, nameof(template), required: false);
            return new DeferredBodyAction<Board[]>(() =>
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
        public IWorkflowAction NodeCreate(Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyboard = null, Expression<Func<string>> bodyparent = null, Expression<Func<bodytypeInput>> bodytype = null, Expression<Func<string>> bodydescription = null)
        {
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodyboard = bodyboard == null ? null : WorkflowExpression.Compile(bodyboard);
            WorkflowExpression.Validate(__workflow_bodyboard, nameof(bodyboard), required: false);
            var __workflow_bodyparent = bodyparent == null ? null : WorkflowExpression.Compile(bodyparent);
            WorkflowExpression.Validate(__workflow_bodyparent, nameof(bodyparent), required: false);
            var __workflow_bodytype = bodytype == null ? null : WorkflowExpression.Compile(bodytype);
            WorkflowExpression.Validate(__workflow_bodytype, nameof(bodytype), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/node";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyboard != null)
                {
                    body["boardId"] = ExpressionConverter.ConvertO(__workflow_bodyboard);
                    bodypropCount++;
                }

                if (__workflow_bodyparent != null)
                {
                    body["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyparent);
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<Node> Node(Expression<Func<string>> nodeId)
        {
            var __workflow_nodeId = nodeId == null ? null : WorkflowExpression.Compile(nodeId);
            WorkflowExpression.Validate(__workflow_nodeId, nameof(nodeId), required: true);
            return new DeferredBodyAction<Node>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/node/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_nodeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Node>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IWorkflowAction Assign(Expression<Func<string>> nodeId, Expression<Func<string>> bodyuserId = null)
        {
            var __workflow_nodeId = nodeId == null ? null : WorkflowExpression.Compile(nodeId);
            WorkflowExpression.Validate(__workflow_nodeId, nameof(nodeId), required: true);
            var __workflow_bodyuserId = bodyuserId == null ? null : WorkflowExpression.Compile(bodyuserId);
            WorkflowExpression.Validate(__workflow_bodyuserId, nameof(bodyuserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/node/{0}/assign", ExpressionConverter.ConvertWithUrlEncoding(__workflow_nodeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyuserId != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<Node[]> Children(Expression<Func<string>> nodeId)
        {
            var __workflow_nodeId = nodeId == null ? null : WorkflowExpression.Compile(nodeId);
            WorkflowExpression.Validate(__workflow_nodeId, nameof(nodeId), required: true);
            return new DeferredBodyAction<Node[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/node/{0}/children", ExpressionConverter.ConvertWithUrlEncoding(__workflow_nodeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Node[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<Node[]> Comments(Expression<Func<string>> nodeId)
        {
            var __workflow_nodeId = nodeId == null ? null : WorkflowExpression.Compile(nodeId);
            WorkflowExpression.Validate(__workflow_nodeId, nameof(nodeId), required: true);
            return new DeferredBodyAction<Node[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/node/{0}/comments", ExpressionConverter.ConvertWithUrlEncoding(__workflow_nodeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Node[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IWorkflowAction CreateAComment(Expression<Func<string>> nodeId, Expression<Func<string>> bodydescription = null)
        {
            var __workflow_nodeId = nodeId == null ? null : WorkflowExpression.Compile(nodeId);
            WorkflowExpression.Validate(__workflow_nodeId, nameof(nodeId), required: true);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/node/{0}/comments", ExpressionConverter.ConvertWithUrlEncoding(__workflow_nodeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IWorkflowAction IncompleteTask(Expression<Func<string>> nodeId)
        {
            var __workflow_nodeId = nodeId == null ? null : WorkflowExpression.Compile(nodeId);
            WorkflowExpression.Validate(__workflow_nodeId, nameof(nodeId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/node/{0}/complete", ExpressionConverter.ConvertWithUrlEncoding(__workflow_nodeId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IWorkflowAction CompleteTask(Expression<Func<string>> nodeId)
        {
            var __workflow_nodeId = nodeId == null ? null : WorkflowExpression.Compile(nodeId);
            WorkflowExpression.Validate(__workflow_nodeId, nameof(nodeId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/node/{0}/complete", ExpressionConverter.ConvertWithUrlEncoding(__workflow_nodeId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IWorkflowAction NodeDate(Expression<Func<string>> nodeId, Expression<Func<string>> bodystart = null, Expression<Func<string>> bodydue = null, Expression<Func<string>> bodyend = null)
        {
            var __workflow_nodeId = nodeId == null ? null : WorkflowExpression.Compile(nodeId);
            WorkflowExpression.Validate(__workflow_nodeId, nameof(nodeId), required: true);
            var __workflow_bodystart = bodystart == null ? null : WorkflowExpression.Compile(bodystart);
            WorkflowExpression.Validate(__workflow_bodystart, nameof(bodystart), required: false);
            var __workflow_bodydue = bodydue == null ? null : WorkflowExpression.Compile(bodydue);
            WorkflowExpression.Validate(__workflow_bodydue, nameof(bodydue), required: false);
            var __workflow_bodyend = bodyend == null ? null : WorkflowExpression.Compile(bodyend);
            WorkflowExpression.Validate(__workflow_bodyend, nameof(bodyend), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/node/{0}/dates", ExpressionConverter.ConvertWithUrlEncoding(__workflow_nodeId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodystart != null)
                {
                    body["start"] = ExpressionConverter.ConvertO(__workflow_bodystart);
                    bodypropCount++;
                }

                if (__workflow_bodydue != null)
                {
                    body["due"] = ExpressionConverter.ConvertO(__workflow_bodydue);
                    bodypropCount++;
                }

                if (__workflow_bodyend != null)
                {
                    body["end"] = ExpressionConverter.ConvertO(__workflow_bodyend);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        public IBodyWorkflowAction<Node[]> FindTask(Expression<Func<string>> q = null, Expression<Func<bool>> completed = null)
        {
            var __workflow_q = q == null ? null : WorkflowExpression.Compile(q);
            WorkflowExpression.Validate(__workflow_q, nameof(q), required: false);
            var __workflow_completed = completed == null ? null : WorkflowExpression.Compile(completed);
            WorkflowExpression.Validate(__workflow_completed, nameof(completed), required: false);
            return new DeferredBodyAction<Node[]>(() =>
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
        public IBodyWorkflowAction<User[]> User(Expression<Func<string>> q)
        {
            var __workflow_q = q == null ? null : WorkflowExpression.Compile(q);
            WorkflowExpression.Validate(__workflow_q, nameof(q), required: true);
            return new DeferredBodyAction<User[]>(() =>
            {
                var apiCallPath = "/user";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                return new ApiConnectionAction<User[]>(callPayload);
            });
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
        public IBodyWorkflowTrigger<NodeSummary> AddedToBoard(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook/added-to-board";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callback"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<NodeSummary>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<NodeSummary> AssignedTask(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook/assigned-task";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callback"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<NodeSummary>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<NodeSummary> BoardTaskCompleted(Expression<Func<string>> boardId, FlowRecurrence recurrence = null)
        {
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            return new DeferredBodyTrigger<NodeSummary>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/webhook/board-task-completed/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_boardId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callback"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<NodeSummary>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<NodeSummary> CreatedNode(Expression<Func<string>> boardId, FlowRecurrence recurrence = null)
        {
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            return new DeferredBodyTrigger<NodeSummary>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/webhook/created-node/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_boardId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callback"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<NodeSummary>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<NodeSummary> MyTaskCompleted(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook/my-task-completed";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callback"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<NodeSummary>(callPayload, recurrence: recurrence);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
