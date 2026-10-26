//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Leankit
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LeankitActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leankit")]
        public IBodyWorkflowAction<CreateBoardResponse, ApiConnectionActionConfiguration> CreateBoard(Expression<Func<CreateBoardInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateBoardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/io/board";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateBoardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leankit")]
        public IBodyWorkflowAction<CreateCardResponse, ApiConnectionActionConfiguration> CreateCard(Expression<Func<CreateCardInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateCardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/io/card";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateCardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leankit")]
        public IBodyWorkflowAction<CardResponse, ApiConnectionActionConfiguration> GetCard(Expression<Func<string>> cardId)
        {
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            return new DeferredBodyAction<CardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/io/card/{0}", __workflow_cardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leankit")]
        public IBodyWorkflowAction<CardResponse, ApiConnectionActionConfiguration> UpdateCard(Expression<Func<string>> cardId, Expression<Func<UpdateCardInput>> body)
        {
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/io/card/{0}", __workflow_cardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leankit")]
        public IBodyWorkflowAction<CardResponse, ApiConnectionActionConfiguration> DeleteCard(Expression<Func<string>> cardId)
        {
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            return new DeferredBodyAction<CardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/io/card/{0}", __workflow_cardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leankit")]
        public IBodyWorkflowAction<AddCommentResponse, ApiConnectionActionConfiguration> AddComment(Expression<Func<string>> cardId, Expression<Func<AddCommentInput>> body)
        {
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddCommentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/io/card/{0}/comment", __workflow_cardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddCommentResponse>(callPayload);
            });
        }
    }

    public class LeankitTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CardResponse[], ApiConnectionTriggerConfiguration> TrigNewCard(Expression<Func<string>> board, Expression<Func<string>> lane, FlowRecurrence recurrence = null)
        {
            var __workflow_board = WorkflowExpression.Compile(board, nameof(board), required: true);
            var __workflow_lane = WorkflowExpression.Compile(lane, nameof(lane), required: true);
            return new DeferredBodyTrigger<CardResponse[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/add_card_trigger/io/card";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board"] = ExpressionConverter.Convert(__workflow_board);
                callPayload.Queries["lane"] = ExpressionConverter.Convert(__workflow_lane);
                return new ApiConnectionTrigger<CardResponse[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CardResponse[], ApiConnectionTriggerConfiguration> TrigUpdateCard(Expression<Func<string>> board, Expression<Func<string>> lane, FlowRecurrence recurrence = null)
        {
            var __workflow_board = WorkflowExpression.Compile(board, nameof(board), required: true);
            var __workflow_lane = WorkflowExpression.Compile(lane, nameof(lane), required: true);
            return new DeferredBodyTrigger<CardResponse[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/update_card_trigger/io/card";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board"] = ExpressionConverter.Convert(__workflow_board);
                callPayload.Queries["lane"] = ExpressionConverter.Convert(__workflow_lane);
                return new ApiConnectionTrigger<CardResponse[]>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CreateBoardResponse
    {
        [JsonProperty("id")]
        public string BoardId { get; set; }
    }

    public class CreateBoardInput
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class CreateCardResponse
    {
        [JsonProperty("id")]
        public string CardId { get; set; }
    }

    public class CreateCardInput
    {
        [JsonProperty("boardId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BoardId { get; set; }

        [JsonProperty("typeId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("laneId")]
        public string LaneId { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("size")]
        public int? Size { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("plannedStart")]
        public string PlannedStartDate { get; set; }

        [JsonProperty("plannedFinish")]
        public string PlannedFinishDate { get; set; }

        [JsonProperty("customId")]
        public string CardId { get; set; }

        [JsonProperty("isBlocked")]
        public bool? IsBlocked { get; set; }

        [JsonProperty("blockReason")]
        public string BlockReason { get; set; }

        [JsonProperty("externalLink")]
        public CreateCardInputExternalLinkType ExternalLink { get; set; }

        [JsonProperty("assignedUserIds")]
        public string[] Assignees { get; set; }
    }

    public class CreateCardInputExternalLinkType
    {
        [JsonProperty("label")]
        public string ExternalLinkLabel { get; set; }

        [JsonProperty("url")]
        public string ExternalLinkURL { get; set; }
    }

    public class CardResponse
    {
        [JsonProperty("actualFinish")]
        public string FinishDateTime { get; set; }

        [JsonProperty("actualStart")]
        public string StartDateTime { get; set; }

        [JsonProperty("blockedStatus")]
        public CardResponseBlockedType Blocked { get; set; }

        [JsonProperty("board")]
        public CardResponseBoardType Board { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("archivedOn")]
        public string ArchivedDateTime { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("plannedFinish")]
        public string PlannedFinishDate { get; set; }

        [JsonProperty("customId")]
        public CardResponseCustomIdType CustomId { get; set; }

        [JsonProperty("id")]
        public string CardId { get; set; }

        [JsonProperty("lane")]
        public CardResponseLaneType Lane { get; set; }

        [JsonProperty("updatedOn")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("movedOn")]
        public string MovedDateTime { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("plannedStart")]
        public string PlannedStartDate { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("type")]
        public CardResponseTypeType Type { get; set; }
    }

    public class CardResponseBlockedType
    {
        [JsonProperty("isBlocked")]
        public bool IsBlocked { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("date")]
        public string BlockedDateTime { get; set; }
    }

    public class CardResponseBoardType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class CardResponseCustomIdType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CardResponseLaneType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("laneClassType")]
        public string ClassType { get; set; }

        [JsonProperty("laneType")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class CardResponseTypeType
    {
        [JsonProperty("title")]
        public string Type { get; set; }
    }

    public class UpdateCardInput
    {
        [JsonProperty("typeId")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("laneId")]
        public string LaneId { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("size")]
        public int? Size { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("plannedStart")]
        public string PlannedStartDateTime { get; set; }

        [JsonProperty("plannedFinish")]
        public string PlannedFinishDateTime { get; set; }

        [JsonProperty("customId")]
        public string CardId { get; set; }

        [JsonProperty("isBlocked")]
        public bool? IsBlocked { get; set; }

        [JsonProperty("blockReason")]
        public string BlockReason { get; set; }

        [JsonProperty("externalLink")]
        public UpdateCardInputExternalLinkType ExternalLink { get; set; }

        [JsonProperty("assignedUserIds")]
        public string[] Assignees { get; set; }
    }

    public class UpdateCardInputExternalLinkType
    {
        [JsonProperty("label")]
        public string ExternalLinkLabel { get; set; }

        [JsonProperty("url")]
        public string ExternalLinkURL { get; set; }
    }

    public class AddCommentResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("createdBy")]
        public AddCommentResponseAuthorType Author { get; set; }

        [JsonProperty("text")]
        public string Comment { get; set; }
    }

    public class AddCommentResponseAuthorType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("emailAddress")]
        public string Email { get; set; }

        [JsonProperty("fullName")]
        public string Name { get; set; }
    }

    public class AddCommentInput
    {
        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Comment { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Leankit;

    public partial class WorkflowManagedActions
    {
        public LeankitActions Leankit(string connectionId) => new LeankitActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LeankitTriggers Leankit(string connectionId) => new LeankitTriggers(connectionId);
    }
}