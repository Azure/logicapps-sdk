//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Huddoboards
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HuddoboardsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [WorkflowExpressionFactory(nameof(__BuildBoardSearch))]
        public IBodyWorkflowAction<Node[]> BoardSearch([WorkflowExpression] Func<string> q = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Node[]> __BuildBoardSearch(WorkflowExpression<string> q = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            return new DeferredBodyAction<Node[]>(() =>
            {
                var apiCallPath = "/board";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                return new ApiConnectionAction<Node[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [WorkflowExpressionFactory(nameof(__BuildBoardCreate))]
        public IWorkflowAction BoardCreate([WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodytemplateId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildBoardCreate(WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodytemplateId = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [WorkflowExpressionFactory(nameof(__BuildBoard))]
        public IBodyWorkflowAction<Board> Board([WorkflowExpression] Func<string> boardId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Board> __BuildBoard(WorkflowExpression<string> boardId)
        {
            WorkflowExpression.Validate(boardId, nameof(boardId), required: true);
            return new DeferredBodyAction<Board>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/board/{0}", ExpressionConverter.ConvertWithUrlEncoding(boardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Board>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [WorkflowExpressionFactory(nameof(__BuildCards))]
        public IBodyWorkflowAction<NodeSummary[]> Cards([WorkflowExpression] Func<string> boardId, [WorkflowExpression] Func<typeInput> type = null, [WorkflowExpression] Func<string> q = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NodeSummary[]> __BuildCards(WorkflowExpression<string> boardId, WorkflowExpression<typeInput> type = null, WorkflowExpression<string> q = null)
        {
            WorkflowExpression.Validate(boardId, nameof(boardId), required: true);
            WorkflowExpression.Validate(type, nameof(type), required: false);
            WorkflowExpression.Validate(q, nameof(q), required: false);
            return new DeferredBodyAction<NodeSummary[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/board/{0}/cards", ExpressionConverter.ConvertWithUrlEncoding(boardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                if (q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                return new ApiConnectionAction<NodeSummary[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [WorkflowExpressionFactory(nameof(__BuildBoardMembers))]
        public IBodyWorkflowAction<Member[]> BoardMembers([WorkflowExpression] Func<string> boardId, [WorkflowExpression] Func<bool> expand = null, [WorkflowExpression] Func<string> q = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Member[]> __BuildBoardMembers(WorkflowExpression<string> boardId, WorkflowExpression<bool> expand = null, WorkflowExpression<string> q = null)
        {
            WorkflowExpression.Validate(boardId, nameof(boardId), required: true);
            WorkflowExpression.Validate(expand, nameof(expand), required: false);
            WorkflowExpression.Validate(q, nameof(q), required: false);
            return new DeferredBodyAction<Member[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/board/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(boardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (expand != null)
                    callPayload.Queries["expand"] = ExpressionConverter.Convert(expand);
                if (q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                return new ApiConnectionAction<Member[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [WorkflowExpressionFactory(nameof(__BuildBoardMy))]
        public IBodyWorkflowAction<Board[]> BoardMy([WorkflowExpression] Func<bool> template = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Board[]> __BuildBoardMy(WorkflowExpression<bool> template = null)
        {
            WorkflowExpression.Validate(template, nameof(template), required: false);
            return new DeferredBodyAction<Board[]>(() =>
            {
                var apiCallPath = "/board/my";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (template != null)
                    callPayload.Queries["template"] = ExpressionConverter.Convert(template);
                return new ApiConnectionAction<Board[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [WorkflowExpressionFactory(nameof(__BuildNodeCreate))]
        public IWorkflowAction NodeCreate([WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyboard = null, [WorkflowExpression] Func<string> bodyparent = null, [WorkflowExpression] Func<bodytypeInput> bodytype = null, [WorkflowExpression] Func<string> bodydescription = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildNodeCreate(WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodyboard = null, WorkflowExpression<string> bodyparent = null, WorkflowExpression<bodytypeInput> bodytype = null, WorkflowExpression<string> bodydescription = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodyboard, nameof(bodyboard), required: false);
            WorkflowExpression.Validate(bodyparent, nameof(bodyparent), required: false);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [WorkflowExpressionFactory(nameof(__BuildNode))]
        public IBodyWorkflowAction<Node> Node([WorkflowExpression] Func<string> nodeId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Node> __BuildNode(WorkflowExpression<string> nodeId)
        {
            WorkflowExpression.Validate(nodeId, nameof(nodeId), required: true);
            return new DeferredBodyAction<Node>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/node/{0}", ExpressionConverter.ConvertWithUrlEncoding(nodeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Node>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [WorkflowExpressionFactory(nameof(__BuildAssign))]
        public IWorkflowAction Assign([WorkflowExpression] Func<string> nodeId, [WorkflowExpression] Func<string> bodyuserId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAssign(WorkflowExpression<string> nodeId, WorkflowExpression<string> bodyuserId = null)
        {
            WorkflowExpression.Validate(nodeId, nameof(nodeId), required: true);
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/node/{0}/assign", ExpressionConverter.ConvertWithUrlEncoding(nodeId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [WorkflowExpressionFactory(nameof(__BuildChildren))]
        public IBodyWorkflowAction<Node[]> Children([WorkflowExpression] Func<string> nodeId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Node[]> __BuildChildren(WorkflowExpression<string> nodeId)
        {
            WorkflowExpression.Validate(nodeId, nameof(nodeId), required: true);
            return new DeferredBodyAction<Node[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/node/{0}/children", ExpressionConverter.ConvertWithUrlEncoding(nodeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Node[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [WorkflowExpressionFactory(nameof(__BuildComments))]
        public IBodyWorkflowAction<Node[]> Comments([WorkflowExpression] Func<string> nodeId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Node[]> __BuildComments(WorkflowExpression<string> nodeId)
        {
            WorkflowExpression.Validate(nodeId, nameof(nodeId), required: true);
            return new DeferredBodyAction<Node[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/node/{0}/comments", ExpressionConverter.ConvertWithUrlEncoding(nodeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Node[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [WorkflowExpressionFactory(nameof(__BuildCreateAComment))]
        public IWorkflowAction CreateAComment([WorkflowExpression] Func<string> nodeId, [WorkflowExpression] Func<string> bodydescription = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateAComment(WorkflowExpression<string> nodeId, WorkflowExpression<string> bodydescription = null)
        {
            WorkflowExpression.Validate(nodeId, nameof(nodeId), required: true);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/node/{0}/comments", ExpressionConverter.ConvertWithUrlEncoding(nodeId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [WorkflowExpressionFactory(nameof(__BuildIncompleteTask))]
        public IWorkflowAction IncompleteTask([WorkflowExpression] Func<string> nodeId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildIncompleteTask(WorkflowExpression<string> nodeId)
        {
            WorkflowExpression.Validate(nodeId, nameof(nodeId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/node/{0}/complete", ExpressionConverter.ConvertWithUrlEncoding(nodeId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [WorkflowExpressionFactory(nameof(__BuildCompleteTask))]
        public IWorkflowAction CompleteTask([WorkflowExpression] Func<string> nodeId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCompleteTask(WorkflowExpression<string> nodeId)
        {
            WorkflowExpression.Validate(nodeId, nameof(nodeId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/node/{0}/complete", ExpressionConverter.ConvertWithUrlEncoding(nodeId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [WorkflowExpressionFactory(nameof(__BuildNodeDate))]
        public IWorkflowAction NodeDate([WorkflowExpression] Func<string> nodeId, [WorkflowExpression] Func<string> bodystart = null, [WorkflowExpression] Func<string> bodydue = null, [WorkflowExpression] Func<string> bodyend = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildNodeDate(WorkflowExpression<string> nodeId, WorkflowExpression<string> bodystart = null, WorkflowExpression<string> bodydue = null, WorkflowExpression<string> bodyend = null)
        {
            WorkflowExpression.Validate(nodeId, nameof(nodeId), required: true);
            WorkflowExpression.Validate(bodystart, nameof(bodystart), required: false);
            WorkflowExpression.Validate(bodydue, nameof(bodydue), required: false);
            WorkflowExpression.Validate(bodyend, nameof(bodyend), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/node/{0}/dates", ExpressionConverter.ConvertWithUrlEncoding(nodeId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [WorkflowExpressionFactory(nameof(__BuildFindTask))]
        public IBodyWorkflowAction<Node[]> FindTask([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<bool> completed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Node[]> __BuildFindTask(WorkflowExpression<string> q = null, WorkflowExpression<bool> completed = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(completed, nameof(completed), required: false);
            return new DeferredBodyAction<Node[]>(() =>
            {
                var apiCallPath = "/todo/assigned";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                if (completed != null)
                    callPayload.Queries["completed"] = ExpressionConverter.Convert(completed);
                return new ApiConnectionAction<Node[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [WorkflowExpressionFactory(nameof(__BuildUser))]
        public IBodyWorkflowAction<User[]> User([WorkflowExpression] Func<string> q)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "huddoboards")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<User[]> __BuildUser(WorkflowExpression<string> q)
        {
            WorkflowExpression.Validate(q, nameof(q), required: true);
            return new DeferredBodyAction<User[]>(() =>
            {
                var apiCallPath = "/user";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
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

        [WorkflowExpressionFactory(nameof(__BuildBoardTaskCompleted))]
        public IBodyWorkflowTrigger<NodeSummary> BoardTaskCompleted([WorkflowExpression] Func<string> boardId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<NodeSummary> __BuildBoardTaskCompleted(WorkflowExpression<string> boardId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(boardId, nameof(boardId), required: true);
            return new DeferredBodyTrigger<NodeSummary>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/webhook/board-task-completed/{0}", ExpressionConverter.ConvertWithUrlEncoding(boardId, 1));
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

        [WorkflowExpressionFactory(nameof(__BuildCreatedNode))]
        public IBodyWorkflowTrigger<NodeSummary> CreatedNode([WorkflowExpression] Func<string> boardId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<NodeSummary> __BuildCreatedNode(WorkflowExpression<string> boardId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(boardId, nameof(boardId), required: true);
            return new DeferredBodyTrigger<NodeSummary>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/webhook/created-node/{0}", ExpressionConverter.ConvertWithUrlEncoding(boardId, 1));
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