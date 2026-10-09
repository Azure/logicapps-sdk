//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Leankit
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LeankitActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leankit")]
        [WorkflowExpressionFactory(nameof(__BuildCreateBoard))]
        public IBodyWorkflowAction<CreateBoardResponse> CreateBoard([WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodydescription = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateBoardResponse> __BuildCreateBoard(WorkflowExpression<string> bodytitle, WorkflowExpression<string> bodydescription = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<CreateBoardResponse>(() =>
            {
                var apiCallPath = "/io/board";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
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
        [WorkflowExpressionFactory(nameof(__BuildCreateCard))]
        public IBodyWorkflowAction<CreateCardResponse> CreateCard([WorkflowExpression] Func<string> bodyboardId, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodylaneId = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<int> bodysize = null, [WorkflowExpression] Func<string> bodytags = null, [WorkflowExpression] Func<string> bodyplannedStartDate = null, [WorkflowExpression] Func<string> bodyplannedFinishDate = null, [WorkflowExpression] Func<string> bodycardId = null, [WorkflowExpression] Func<bool> bodyisBlocked = null, [WorkflowExpression] Func<string> bodyblockReason = null, [WorkflowExpression] Func<string> bodyexternalLinkexternalLinkLabel = null, [WorkflowExpression] Func<string> bodyexternalLinkexternalLinkURL = null, [WorkflowExpression] Func<string[]> bodyassignees = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateCardResponse> __BuildCreateCard(WorkflowExpression<string> bodyboardId, WorkflowExpression<string> bodytype, WorkflowExpression<string> bodytitle, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodylaneId = null, WorkflowExpression<string> bodypriority = null, WorkflowExpression<int> bodysize = null, WorkflowExpression<string> bodytags = null, WorkflowExpression<string> bodyplannedStartDate = null, WorkflowExpression<string> bodyplannedFinishDate = null, WorkflowExpression<string> bodycardId = null, WorkflowExpression<bool> bodyisBlocked = null, WorkflowExpression<string> bodyblockReason = null, WorkflowExpression<string> bodyexternalLinkexternalLinkLabel = null, WorkflowExpression<string> bodyexternalLinkexternalLinkURL = null, WorkflowExpression<string[]> bodyassignees = null)
        {
            WorkflowExpression.Validate(bodyboardId, nameof(bodyboardId), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodylaneId, nameof(bodylaneId), required: false);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowExpression.Validate(bodysize, nameof(bodysize), required: false);
            WorkflowExpression.Validate(bodytags, nameof(bodytags), required: false);
            WorkflowExpression.Validate(bodyplannedStartDate, nameof(bodyplannedStartDate), required: false);
            WorkflowExpression.Validate(bodyplannedFinishDate, nameof(bodyplannedFinishDate), required: false);
            WorkflowExpression.Validate(bodycardId, nameof(bodycardId), required: false);
            WorkflowExpression.Validate(bodyisBlocked, nameof(bodyisBlocked), required: false);
            WorkflowExpression.Validate(bodyblockReason, nameof(bodyblockReason), required: false);
            WorkflowExpression.Validate(bodyexternalLinkexternalLinkLabel, nameof(bodyexternalLinkexternalLinkLabel), required: false);
            WorkflowExpression.Validate(bodyexternalLinkexternalLinkURL, nameof(bodyexternalLinkexternalLinkURL), required: false);
            WorkflowExpression.Validate(bodyassignees, nameof(bodyassignees), required: false);
            return new DeferredBodyAction<CreateCardResponse>(() =>
            {
                var apiCallPath = "/io/card";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["boardId"] = ExpressionConverter.ConvertO(bodyboardId);
                bodypropCount++;
                body["typeId"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodylaneId != null)
                {
                    body["laneId"] = ExpressionConverter.ConvertO(bodylaneId);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                    bodypropCount++;
                }

                if (bodysize != null)
                {
                    body["size"] = ExpressionConverter.ConvertO(bodysize);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(bodytags);
                    bodypropCount++;
                }

                if (bodyplannedStartDate != null)
                {
                    body["plannedStart"] = ExpressionConverter.ConvertO(bodyplannedStartDate);
                    bodypropCount++;
                }

                if (bodyplannedFinishDate != null)
                {
                    body["plannedFinish"] = ExpressionConverter.ConvertO(bodyplannedFinishDate);
                    bodypropCount++;
                }

                if (bodycardId != null)
                {
                    body["customId"] = ExpressionConverter.ConvertO(bodycardId);
                    bodypropCount++;
                }

                if (bodyisBlocked != null)
                {
                    body["isBlocked"] = ExpressionConverter.ConvertO(bodyisBlocked);
                    bodypropCount++;
                }

                if (bodyblockReason != null)
                {
                    body["blockReason"] = ExpressionConverter.ConvertO(bodyblockReason);
                    bodypropCount++;
                }

                var externalLinkObject = new JObject();
                var externalLinkObjectpropCount = 0;
                if (bodyexternalLinkexternalLinkLabel != null)
                {
                    externalLinkObject["label"] = ExpressionConverter.ConvertO(bodyexternalLinkexternalLinkLabel);
                    externalLinkObjectpropCount++;
                }

                if (bodyexternalLinkexternalLinkURL != null)
                {
                    externalLinkObject["url"] = ExpressionConverter.ConvertO(bodyexternalLinkexternalLinkURL);
                    externalLinkObjectpropCount++;
                }

                if (externalLinkObjectpropCount > 0)
                {
                    body["externalLink"] = externalLinkObject;
                    bodypropCount++;
                }

                if (bodyassignees != null)
                {
                    body["assignedUserIds"] = ExpressionConverter.ConvertO(bodyassignees);
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
        [WorkflowExpressionFactory(nameof(__BuildGetCard))]
        public IBodyWorkflowAction<CardResponse> GetCard([WorkflowExpression] Func<string> cardId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CardResponse> __BuildGetCard(WorkflowExpression<string> cardId)
        {
            WorkflowExpression.Validate(cardId, nameof(cardId), required: true);
            return new DeferredBodyAction<CardResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/io/card/{0}", ExpressionConverter.ConvertWithUrlEncoding(cardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leankit")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateCard))]
        public IBodyWorkflowAction<CardResponse> UpdateCard([WorkflowExpression] Func<string> cardId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodylaneId = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<int> bodysize = null, [WorkflowExpression] Func<string> bodytags = null, [WorkflowExpression] Func<string> bodyplannedStartDateTime = null, [WorkflowExpression] Func<string> bodyplannedFinishDateTime = null, [WorkflowExpression] Func<string> bodycardId = null, [WorkflowExpression] Func<bool> bodyisBlocked = null, [WorkflowExpression] Func<string> bodyblockReason = null, [WorkflowExpression] Func<string> bodyexternalLinkexternalLinkLabel = null, [WorkflowExpression] Func<string> bodyexternalLinkexternalLinkURL = null, [WorkflowExpression] Func<string[]> bodyassignees = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CardResponse> __BuildUpdateCard(WorkflowExpression<string> cardId, WorkflowExpression<string> bodytype = null, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodylaneId = null, WorkflowExpression<string> bodypriority = null, WorkflowExpression<int> bodysize = null, WorkflowExpression<string> bodytags = null, WorkflowExpression<string> bodyplannedStartDateTime = null, WorkflowExpression<string> bodyplannedFinishDateTime = null, WorkflowExpression<string> bodycardId = null, WorkflowExpression<bool> bodyisBlocked = null, WorkflowExpression<string> bodyblockReason = null, WorkflowExpression<string> bodyexternalLinkexternalLinkLabel = null, WorkflowExpression<string> bodyexternalLinkexternalLinkURL = null, WorkflowExpression<string[]> bodyassignees = null)
        {
            WorkflowExpression.Validate(cardId, nameof(cardId), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodylaneId, nameof(bodylaneId), required: false);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowExpression.Validate(bodysize, nameof(bodysize), required: false);
            WorkflowExpression.Validate(bodytags, nameof(bodytags), required: false);
            WorkflowExpression.Validate(bodyplannedStartDateTime, nameof(bodyplannedStartDateTime), required: false);
            WorkflowExpression.Validate(bodyplannedFinishDateTime, nameof(bodyplannedFinishDateTime), required: false);
            WorkflowExpression.Validate(bodycardId, nameof(bodycardId), required: false);
            WorkflowExpression.Validate(bodyisBlocked, nameof(bodyisBlocked), required: false);
            WorkflowExpression.Validate(bodyblockReason, nameof(bodyblockReason), required: false);
            WorkflowExpression.Validate(bodyexternalLinkexternalLinkLabel, nameof(bodyexternalLinkexternalLinkLabel), required: false);
            WorkflowExpression.Validate(bodyexternalLinkexternalLinkURL, nameof(bodyexternalLinkexternalLinkURL), required: false);
            WorkflowExpression.Validate(bodyassignees, nameof(bodyassignees), required: false);
            return new DeferredBodyAction<CardResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/io/card/{0}", ExpressionConverter.ConvertWithUrlEncoding(cardId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["typeId"] = ExpressionConverter.ConvertO(bodytype);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodylaneId != null)
                {
                    body["laneId"] = ExpressionConverter.ConvertO(bodylaneId);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                    bodypropCount++;
                }

                if (bodysize != null)
                {
                    body["size"] = ExpressionConverter.ConvertO(bodysize);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(bodytags);
                    bodypropCount++;
                }

                if (bodyplannedStartDateTime != null)
                {
                    body["plannedStart"] = ExpressionConverter.ConvertO(bodyplannedStartDateTime);
                    bodypropCount++;
                }

                if (bodyplannedFinishDateTime != null)
                {
                    body["plannedFinish"] = ExpressionConverter.ConvertO(bodyplannedFinishDateTime);
                    bodypropCount++;
                }

                if (bodycardId != null)
                {
                    body["customId"] = ExpressionConverter.ConvertO(bodycardId);
                    bodypropCount++;
                }

                if (bodyisBlocked != null)
                {
                    body["isBlocked"] = ExpressionConverter.ConvertO(bodyisBlocked);
                    bodypropCount++;
                }

                if (bodyblockReason != null)
                {
                    body["blockReason"] = ExpressionConverter.ConvertO(bodyblockReason);
                    bodypropCount++;
                }

                var externalLinkObject = new JObject();
                var externalLinkObjectpropCount = 0;
                if (bodyexternalLinkexternalLinkLabel != null)
                {
                    externalLinkObject["label"] = ExpressionConverter.ConvertO(bodyexternalLinkexternalLinkLabel);
                    externalLinkObjectpropCount++;
                }

                if (bodyexternalLinkexternalLinkURL != null)
                {
                    externalLinkObject["url"] = ExpressionConverter.ConvertO(bodyexternalLinkexternalLinkURL);
                    externalLinkObjectpropCount++;
                }

                if (externalLinkObjectpropCount > 0)
                {
                    body["externalLink"] = externalLinkObject;
                    bodypropCount++;
                }

                if (bodyassignees != null)
                {
                    body["assignedUserIds"] = ExpressionConverter.ConvertO(bodyassignees);
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
        [WorkflowExpressionFactory(nameof(__BuildDeleteCard))]
        public IBodyWorkflowAction<CardResponse> DeleteCard([WorkflowExpression] Func<string> cardId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CardResponse> __BuildDeleteCard(WorkflowExpression<string> cardId)
        {
            WorkflowExpression.Validate(cardId, nameof(cardId), required: true);
            return new DeferredBodyAction<CardResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/io/card/{0}", ExpressionConverter.ConvertWithUrlEncoding(cardId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leankit")]
        [WorkflowExpressionFactory(nameof(__BuildAddComment))]
        public IBodyWorkflowAction<AddCommentResponse> AddComment([WorkflowExpression] Func<string> cardId, [WorkflowExpression] Func<string> bodycomment)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddCommentResponse> __BuildAddComment(WorkflowExpression<string> cardId, WorkflowExpression<string> bodycomment)
        {
            WorkflowExpression.Validate(cardId, nameof(cardId), required: true);
            WorkflowExpression.Validate(bodycomment, nameof(bodycomment), required: true);
            return new DeferredBodyAction<AddCommentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/io/card/{0}/comment", ExpressionConverter.ConvertWithUrlEncoding(cardId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(bodycomment);
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

        [WorkflowExpressionFactory(nameof(__BuildTrigNewCard))]
        public IBodyWorkflowTrigger<CardResponse[]> TrigNewCard([WorkflowExpression] Func<string> board,[WorkflowExpression] Func<string> lane,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CardResponse[]> __BuildTrigNewCard(WorkflowExpression<string> board,WorkflowExpression<string> lane,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(board, nameof(board), required: true);
            WorkflowExpression.Validate(lane, nameof(lane), required: true);
            return new DeferredBodyTrigger<CardResponse[]>(() =>
            {
                var apiCallPath = "/add_card_trigger/io/card";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board"] = ExpressionConverter.Convert(board);
                callPayload.Queries["lane"] = ExpressionConverter.Convert(lane);
                return new ApiConnectionTrigger<CardResponse[]>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildTrigUpdateCard))]
        public IBodyWorkflowTrigger<CardResponse[]> TrigUpdateCard([WorkflowExpression] Func<string> board,[WorkflowExpression] Func<string> lane,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CardResponse[]> __BuildTrigUpdateCard(WorkflowExpression<string> board,WorkflowExpression<string> lane,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(board, nameof(board), required: true);
            WorkflowExpression.Validate(lane, nameof(lane), required: true);
            return new DeferredBodyTrigger<CardResponse[]>(() =>
            {
                var apiCallPath = "/update_card_trigger/io/card";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board"] = ExpressionConverter.Convert(board);
                callPayload.Queries["lane"] = ExpressionConverter.Convert(lane);
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