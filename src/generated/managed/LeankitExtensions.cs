//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Leankit
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LeankitActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leankit")]
        public IBodyWorkflowAction<CreateBoardResponse> CreateBoard(Expression<Func<string>> bodytitle, Expression<Func<string>> bodydescription = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leankit")]
        public IBodyWorkflowAction<CreateCardResponse> CreateCard(Expression<Func<string>> bodyboardId, Expression<Func<string>> bodytype, Expression<Func<string>> bodytitle, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodylaneId = null, Expression<Func<string>> bodypriority = null, Expression<Func<int>> bodysize = null, Expression<Func<string>> bodytags = null, Expression<Func<string>> bodyplannedStartDate = null, Expression<Func<string>> bodyplannedFinishDate = null, Expression<Func<string>> bodycardId = null, Expression<Func<bool>> bodyisBlocked = null, Expression<Func<string>> bodyblockReason = null, Expression<Func<string>> bodyexternalLinkexternalLinkLabel = null, Expression<Func<string>> bodyexternalLinkexternalLinkURL = null, Expression<Func<string[]>> bodyassignees = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leankit")]
        public IBodyWorkflowAction<CardResponse> GetCard(Expression<Func<string>> cardId)
        {
            var apiCallPath = String.Format("/io/card/{0}", ExpressionConverter.ConvertWithUrlEncoding(cardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CardResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leankit")]
        public IBodyWorkflowAction<CardResponse> UpdateCard(Expression<Func<string>> cardId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodylaneId = null, Expression<Func<string>> bodypriority = null, Expression<Func<int>> bodysize = null, Expression<Func<string>> bodytags = null, Expression<Func<string>> bodyplannedStartDateTime = null, Expression<Func<string>> bodyplannedFinishDateTime = null, Expression<Func<string>> bodycardId = null, Expression<Func<bool>> bodyisBlocked = null, Expression<Func<string>> bodyblockReason = null, Expression<Func<string>> bodyexternalLinkexternalLinkLabel = null, Expression<Func<string>> bodyexternalLinkexternalLinkURL = null, Expression<Func<string[]>> bodyassignees = null)
        {
            var apiCallPath = String.Format("/io/card/{0}", ExpressionConverter.ConvertWithUrlEncoding(cardId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leankit")]
        public IBodyWorkflowAction<CardResponse> DeleteCard(Expression<Func<string>> cardId)
        {
            var apiCallPath = String.Format("/io/card/{0}", ExpressionConverter.ConvertWithUrlEncoding(cardId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CardResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leankit")]
        public IBodyWorkflowAction<AddCommentResponse> AddComment(Expression<Func<string>> cardId, Expression<Func<string>> bodycomment)
        {
            var apiCallPath = String.Format("/io/card/{0}/comment", ExpressionConverter.ConvertWithUrlEncoding(cardId, 1));
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
        }
    }

    public class LeankitTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<CardResponse[]> TrigNewCard(Expression<Func<string>> board, Expression<Func<string>> lane)
        {
            var apiCallPath = "/add_card_trigger/io/card";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["board"] = ExpressionConverter.Convert(board);
            callPayload.Queries["lane"] = ExpressionConverter.Convert(lane);
            return new ApiConnectionTrigger<CardResponse[]>(callPayload);
        }

        public IOutputWorkflowTrigger<CardResponse[]> TrigUpdateCard(Expression<Func<string>> board, Expression<Func<string>> lane)
        {
            var apiCallPath = "/update_card_trigger/io/card";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["board"] = ExpressionConverter.Convert(board);
            callPayload.Queries["lane"] = ExpressionConverter.Convert(lane);
            return new ApiConnectionTrigger<CardResponse[]>(callPayload);
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
    using Microsoft.Azure.Workflows.Sdk.Leankit;

    public partial class WorkflowManagedActions
    {
        public LeankitActions Leankit(string connectionId) => new LeankitActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LeankitTriggers Leankit(string connectionId) => new LeankitTriggers(connectionId);
    }
}