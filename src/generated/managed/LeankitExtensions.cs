//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Leankit
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class LeankitActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leankit")]
        public IBodyWorkflowAction<CreateBoardResponse> CreateBoard(Expression<Func<string>> bodytitle, Expression<Func<string>> bodydescription = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<CreateBoardResponse>(() =>
            {
                var apiCallPath = "/io/board";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateBoardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leankit")]
        public IBodyWorkflowAction<CreateCardResponse> CreateCard(Expression<Func<string>> bodyboardId, Expression<Func<string>> bodytype, Expression<Func<string>> bodytitle, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodylaneId = null, Expression<Func<string>> bodypriority = null, Expression<Func<int>> bodysize = null, Expression<Func<string>> bodytags = null, Expression<Func<string>> bodyplannedStartDate = null, Expression<Func<string>> bodyplannedFinishDate = null, Expression<Func<string>> bodycardId = null, Expression<Func<bool>> bodyisBlocked = null, Expression<Func<string>> bodyblockReason = null, Expression<Func<string>> bodyexternalLinkexternalLinkLabel = null, Expression<Func<string>> bodyexternalLinkexternalLinkURL = null, Expression<Func<string[]>> bodyassignees = null)
        {
            var __workflow_bodyboardId = WorkflowExpression.Compile(bodyboardId, nameof(bodyboardId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodylaneId = WorkflowExpression.Compile(bodylaneId, nameof(bodylaneId), required: false);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodysize = WorkflowExpression.Compile(bodysize, nameof(bodysize), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            var __workflow_bodyplannedStartDate = WorkflowExpression.Compile(bodyplannedStartDate, nameof(bodyplannedStartDate), required: false);
            var __workflow_bodyplannedFinishDate = WorkflowExpression.Compile(bodyplannedFinishDate, nameof(bodyplannedFinishDate), required: false);
            var __workflow_bodycardId = WorkflowExpression.Compile(bodycardId, nameof(bodycardId), required: false);
            var __workflow_bodyisBlocked = WorkflowExpression.Compile(bodyisBlocked, nameof(bodyisBlocked), required: false);
            var __workflow_bodyblockReason = WorkflowExpression.Compile(bodyblockReason, nameof(bodyblockReason), required: false);
            var __workflow_bodyexternalLinkexternalLinkLabel = WorkflowExpression.Compile(bodyexternalLinkexternalLinkLabel, nameof(bodyexternalLinkexternalLinkLabel), required: false);
            var __workflow_bodyexternalLinkexternalLinkURL = WorkflowExpression.Compile(bodyexternalLinkexternalLinkURL, nameof(bodyexternalLinkexternalLinkURL), required: false);
            var __workflow_bodyassignees = WorkflowExpression.Compile(bodyassignees, nameof(bodyassignees), required: false);
            return new DeferredBodyAction<CreateCardResponse>(() =>
            {
                var apiCallPath = "/io/card";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["boardId"] = ExpressionConverter.ConvertO(__workflow_bodyboardId);
                bodypropCount++;
                body["typeId"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodylaneId != null)
                {
                    body["laneId"] = ExpressionConverter.ConvertO(__workflow_bodylaneId);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodysize != null)
                {
                    body["size"] = ExpressionConverter.ConvertO(__workflow_bodysize);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (__workflow_bodyplannedStartDate != null)
                {
                    body["plannedStart"] = ExpressionConverter.ConvertO(__workflow_bodyplannedStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyplannedFinishDate != null)
                {
                    body["plannedFinish"] = ExpressionConverter.ConvertO(__workflow_bodyplannedFinishDate);
                    bodypropCount++;
                }

                if (__workflow_bodycardId != null)
                {
                    body["customId"] = ExpressionConverter.ConvertO(__workflow_bodycardId);
                    bodypropCount++;
                }

                if (__workflow_bodyisBlocked != null)
                {
                    body["isBlocked"] = ExpressionConverter.ConvertO(__workflow_bodyisBlocked);
                    bodypropCount++;
                }

                if (__workflow_bodyblockReason != null)
                {
                    body["blockReason"] = ExpressionConverter.ConvertO(__workflow_bodyblockReason);
                    bodypropCount++;
                }

                var externalLinkObject = new JObject();
                var externalLinkObjectpropCount = 0;
                if (__workflow_bodyexternalLinkexternalLinkLabel != null)
                {
                    externalLinkObject["label"] = ExpressionConverter.ConvertO(__workflow_bodyexternalLinkexternalLinkLabel);
                    externalLinkObjectpropCount++;
                }

                if (__workflow_bodyexternalLinkexternalLinkURL != null)
                {
                    externalLinkObject["url"] = ExpressionConverter.ConvertO(__workflow_bodyexternalLinkexternalLinkURL);
                    externalLinkObjectpropCount++;
                }

                if (externalLinkObjectpropCount > 0)
                {
                    body["externalLink"] = externalLinkObject;
                    bodypropCount++;
                }

                if (__workflow_bodyassignees != null)
                {
                    body["assignedUserIds"] = ExpressionConverter.ConvertO(__workflow_bodyassignees);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateCardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leankit")]
        public IBodyWorkflowAction<CardResponse> GetCard(Expression<Func<string>> cardId)
        {
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            return new DeferredBodyAction<CardResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/io/card/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_cardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leankit")]
        public IBodyWorkflowAction<CardResponse> UpdateCard(Expression<Func<string>> cardId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodylaneId = null, Expression<Func<string>> bodypriority = null, Expression<Func<int>> bodysize = null, Expression<Func<string>> bodytags = null, Expression<Func<string>> bodyplannedStartDateTime = null, Expression<Func<string>> bodyplannedFinishDateTime = null, Expression<Func<string>> bodycardId = null, Expression<Func<bool>> bodyisBlocked = null, Expression<Func<string>> bodyblockReason = null, Expression<Func<string>> bodyexternalLinkexternalLinkLabel = null, Expression<Func<string>> bodyexternalLinkexternalLinkURL = null, Expression<Func<string[]>> bodyassignees = null)
        {
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodylaneId = WorkflowExpression.Compile(bodylaneId, nameof(bodylaneId), required: false);
            var __workflow_bodypriority = WorkflowExpression.Compile(bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodysize = WorkflowExpression.Compile(bodysize, nameof(bodysize), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            var __workflow_bodyplannedStartDateTime = WorkflowExpression.Compile(bodyplannedStartDateTime, nameof(bodyplannedStartDateTime), required: false);
            var __workflow_bodyplannedFinishDateTime = WorkflowExpression.Compile(bodyplannedFinishDateTime, nameof(bodyplannedFinishDateTime), required: false);
            var __workflow_bodycardId = WorkflowExpression.Compile(bodycardId, nameof(bodycardId), required: false);
            var __workflow_bodyisBlocked = WorkflowExpression.Compile(bodyisBlocked, nameof(bodyisBlocked), required: false);
            var __workflow_bodyblockReason = WorkflowExpression.Compile(bodyblockReason, nameof(bodyblockReason), required: false);
            var __workflow_bodyexternalLinkexternalLinkLabel = WorkflowExpression.Compile(bodyexternalLinkexternalLinkLabel, nameof(bodyexternalLinkexternalLinkLabel), required: false);
            var __workflow_bodyexternalLinkexternalLinkURL = WorkflowExpression.Compile(bodyexternalLinkexternalLinkURL, nameof(bodyexternalLinkexternalLinkURL), required: false);
            var __workflow_bodyassignees = WorkflowExpression.Compile(bodyassignees, nameof(bodyassignees), required: false);
            return new DeferredBodyAction<CardResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/io/card/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_cardId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytype != null)
                {
                    body["typeId"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodylaneId != null)
                {
                    body["laneId"] = ExpressionConverter.ConvertO(__workflow_bodylaneId);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodysize != null)
                {
                    body["size"] = ExpressionConverter.ConvertO(__workflow_bodysize);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (__workflow_bodyplannedStartDateTime != null)
                {
                    body["plannedStart"] = ExpressionConverter.ConvertO(__workflow_bodyplannedStartDateTime);
                    bodypropCount++;
                }

                if (__workflow_bodyplannedFinishDateTime != null)
                {
                    body["plannedFinish"] = ExpressionConverter.ConvertO(__workflow_bodyplannedFinishDateTime);
                    bodypropCount++;
                }

                if (__workflow_bodycardId != null)
                {
                    body["customId"] = ExpressionConverter.ConvertO(__workflow_bodycardId);
                    bodypropCount++;
                }

                if (__workflow_bodyisBlocked != null)
                {
                    body["isBlocked"] = ExpressionConverter.ConvertO(__workflow_bodyisBlocked);
                    bodypropCount++;
                }

                if (__workflow_bodyblockReason != null)
                {
                    body["blockReason"] = ExpressionConverter.ConvertO(__workflow_bodyblockReason);
                    bodypropCount++;
                }

                var externalLinkObject = new JObject();
                var externalLinkObjectpropCount = 0;
                if (__workflow_bodyexternalLinkexternalLinkLabel != null)
                {
                    externalLinkObject["label"] = ExpressionConverter.ConvertO(__workflow_bodyexternalLinkexternalLinkLabel);
                    externalLinkObjectpropCount++;
                }

                if (__workflow_bodyexternalLinkexternalLinkURL != null)
                {
                    externalLinkObject["url"] = ExpressionConverter.ConvertO(__workflow_bodyexternalLinkexternalLinkURL);
                    externalLinkObjectpropCount++;
                }

                if (externalLinkObjectpropCount > 0)
                {
                    body["externalLink"] = externalLinkObject;
                    bodypropCount++;
                }

                if (__workflow_bodyassignees != null)
                {
                    body["assignedUserIds"] = ExpressionConverter.ConvertO(__workflow_bodyassignees);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leankit")]
        public IBodyWorkflowAction<CardResponse> DeleteCard(Expression<Func<string>> cardId)
        {
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            return new DeferredBodyAction<CardResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/io/card/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_cardId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leankit")]
        public IBodyWorkflowAction<AddCommentResponse> AddComment(Expression<Func<string>> cardId, Expression<Func<string>> bodycomment)
        {
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: true);
            return new DeferredBodyAction<AddCommentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/io/card/{0}/comment", ExpressionConverter.ConvertWithUrlEncoding(__workflow_cardId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddCommentResponse>(callPayload);
            });
        }
    }

    public class LeankitTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CardResponse[]> TrigNewCard(Expression<Func<string>> board, Expression<Func<string>> lane, FlowRecurrence recurrence = null)
        {
            var __workflow_board = WorkflowExpression.Compile(board, nameof(board), required: true);
            var __workflow_lane = WorkflowExpression.Compile(lane, nameof(lane), required: true);
            return new DeferredBodyTrigger<CardResponse[]>(() =>
            {
                var apiCallPath = "/add_card_trigger/io/card";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board"] = ExpressionConverter.Convert(__workflow_board);
                callPayload.Queries["lane"] = ExpressionConverter.Convert(__workflow_lane);
                return new ApiConnectionTrigger<CardResponse[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CardResponse[]> TrigUpdateCard(Expression<Func<string>> board, Expression<Func<string>> lane, FlowRecurrence recurrence = null)
        {
            var __workflow_board = WorkflowExpression.Compile(board, nameof(board), required: true);
            var __workflow_lane = WorkflowExpression.Compile(lane, nameof(lane), required: true);
            return new DeferredBodyTrigger<CardResponse[]>(() =>
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

    public class CreateCardResponse
    {
        [JsonProperty("id")]
        public string CardId { get; set; }
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
