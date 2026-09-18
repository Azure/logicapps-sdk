//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Leankit
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LeankitActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leankit")]
        public IBodyWorkflowAction<CreateBoardResponse> CreateBoard([WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodydescription = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/io/board";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateBoardResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leankit")]
        public IBodyWorkflowAction<CreateCardResponse> CreateCard([WorkflowExpression] Func<string> bodyboardId, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodylaneId = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<int> bodysize = null, [WorkflowExpression] Func<string> bodytags = null, [WorkflowExpression] Func<string> bodyplannedStartDate = null, [WorkflowExpression] Func<string> bodyplannedFinishDate = null, [WorkflowExpression] Func<string> bodycardId = null, [WorkflowExpression] Func<bool> bodyisBlocked = null, [WorkflowExpression] Func<string> bodyblockReason = null, [WorkflowExpression] Func<string> bodyexternalLinkexternalLinkLabel = null, [WorkflowExpression] Func<string> bodyexternalLinkexternalLinkURL = null, [WorkflowExpression] Func<string[]> bodyassignees = null)
        {
            SourceExpression.Validate(bodyboardId, nameof(bodyboardId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodylaneId, nameof(bodylaneId), required: false);
            SourceExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            SourceExpression.Validate(bodysize, nameof(bodysize), required: false);
            SourceExpression.Validate(bodytags, nameof(bodytags), required: false);
            SourceExpression.Validate(bodyplannedStartDate, nameof(bodyplannedStartDate), required: false);
            SourceExpression.Validate(bodyplannedFinishDate, nameof(bodyplannedFinishDate), required: false);
            SourceExpression.Validate(bodycardId, nameof(bodycardId), required: false);
            SourceExpression.Validate(bodyisBlocked, nameof(bodyisBlocked), required: false);
            SourceExpression.Validate(bodyblockReason, nameof(bodyblockReason), required: false);
            SourceExpression.Validate(bodyexternalLinkexternalLinkLabel, nameof(bodyexternalLinkexternalLinkLabel), required: false);
            SourceExpression.Validate(bodyexternalLinkexternalLinkURL, nameof(bodyexternalLinkexternalLinkURL), required: false);
            SourceExpression.Validate(bodyassignees, nameof(bodyassignees), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/io/card";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["boardId"] = SourceExpressionConverter.ConvertToken(bodyboardId);
                bodypropCount++;
                body["typeId"] = SourceExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodylaneId != null)
                {
                    body["laneId"] = SourceExpressionConverter.ConvertToken(bodylaneId);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                if (bodysize != null)
                {
                    body["size"] = SourceExpressionConverter.ConvertToken(bodysize);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                if (bodyplannedStartDate != null)
                {
                    body["plannedStart"] = SourceExpressionConverter.ConvertToken(bodyplannedStartDate);
                    bodypropCount++;
                }

                if (bodyplannedFinishDate != null)
                {
                    body["plannedFinish"] = SourceExpressionConverter.ConvertToken(bodyplannedFinishDate);
                    bodypropCount++;
                }

                if (bodycardId != null)
                {
                    body["customId"] = SourceExpressionConverter.ConvertToken(bodycardId);
                    bodypropCount++;
                }

                if (bodyisBlocked != null)
                {
                    body["isBlocked"] = SourceExpressionConverter.ConvertToken(bodyisBlocked);
                    bodypropCount++;
                }

                if (bodyblockReason != null)
                {
                    body["blockReason"] = SourceExpressionConverter.ConvertToken(bodyblockReason);
                    bodypropCount++;
                }

                var externalLinkObject = new JObject();
                var externalLinkObjectpropCount = 0;
                if (bodyexternalLinkexternalLinkLabel != null)
                {
                    externalLinkObject["label"] = SourceExpressionConverter.ConvertToken(bodyexternalLinkexternalLinkLabel);
                    externalLinkObjectpropCount++;
                }

                if (bodyexternalLinkexternalLinkURL != null)
                {
                    externalLinkObject["url"] = SourceExpressionConverter.ConvertToken(bodyexternalLinkexternalLinkURL);
                    externalLinkObjectpropCount++;
                }

                if (externalLinkObjectpropCount > 0)
                {
                    body["externalLink"] = externalLinkObject;
                    bodypropCount++;
                }

                if (bodyassignees != null)
                {
                    body["assignedUserIds"] = SourceExpressionConverter.ConvertToken(bodyassignees);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateCardResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leankit")]
        public IBodyWorkflowAction<CardResponse> GetCard([WorkflowExpression] Func<string> cardId)
        {
            SourceExpression.Validate(cardId, nameof(cardId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/io/card/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CardResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leankit")]
        public IBodyWorkflowAction<CardResponse> UpdateCard([WorkflowExpression] Func<string> cardId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodylaneId = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<int> bodysize = null, [WorkflowExpression] Func<string> bodytags = null, [WorkflowExpression] Func<string> bodyplannedStartDateTime = null, [WorkflowExpression] Func<string> bodyplannedFinishDateTime = null, [WorkflowExpression] Func<string> bodycardId = null, [WorkflowExpression] Func<bool> bodyisBlocked = null, [WorkflowExpression] Func<string> bodyblockReason = null, [WorkflowExpression] Func<string> bodyexternalLinkexternalLinkLabel = null, [WorkflowExpression] Func<string> bodyexternalLinkexternalLinkURL = null, [WorkflowExpression] Func<string[]> bodyassignees = null)
        {
            SourceExpression.Validate(cardId, nameof(cardId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodylaneId, nameof(bodylaneId), required: false);
            SourceExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            SourceExpression.Validate(bodysize, nameof(bodysize), required: false);
            SourceExpression.Validate(bodytags, nameof(bodytags), required: false);
            SourceExpression.Validate(bodyplannedStartDateTime, nameof(bodyplannedStartDateTime), required: false);
            SourceExpression.Validate(bodyplannedFinishDateTime, nameof(bodyplannedFinishDateTime), required: false);
            SourceExpression.Validate(bodycardId, nameof(bodycardId), required: false);
            SourceExpression.Validate(bodyisBlocked, nameof(bodyisBlocked), required: false);
            SourceExpression.Validate(bodyblockReason, nameof(bodyblockReason), required: false);
            SourceExpression.Validate(bodyexternalLinkexternalLinkLabel, nameof(bodyexternalLinkexternalLinkLabel), required: false);
            SourceExpression.Validate(bodyexternalLinkexternalLinkURL, nameof(bodyexternalLinkexternalLinkURL), required: false);
            SourceExpression.Validate(bodyassignees, nameof(bodyassignees), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/io/card/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["typeId"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodylaneId != null)
                {
                    body["laneId"] = SourceExpressionConverter.ConvertToken(bodylaneId);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                if (bodysize != null)
                {
                    body["size"] = SourceExpressionConverter.ConvertToken(bodysize);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                if (bodyplannedStartDateTime != null)
                {
                    body["plannedStart"] = SourceExpressionConverter.ConvertToken(bodyplannedStartDateTime);
                    bodypropCount++;
                }

                if (bodyplannedFinishDateTime != null)
                {
                    body["plannedFinish"] = SourceExpressionConverter.ConvertToken(bodyplannedFinishDateTime);
                    bodypropCount++;
                }

                if (bodycardId != null)
                {
                    body["customId"] = SourceExpressionConverter.ConvertToken(bodycardId);
                    bodypropCount++;
                }

                if (bodyisBlocked != null)
                {
                    body["isBlocked"] = SourceExpressionConverter.ConvertToken(bodyisBlocked);
                    bodypropCount++;
                }

                if (bodyblockReason != null)
                {
                    body["blockReason"] = SourceExpressionConverter.ConvertToken(bodyblockReason);
                    bodypropCount++;
                }

                var externalLinkObject = new JObject();
                var externalLinkObjectpropCount = 0;
                if (bodyexternalLinkexternalLinkLabel != null)
                {
                    externalLinkObject["label"] = SourceExpressionConverter.ConvertToken(bodyexternalLinkexternalLinkLabel);
                    externalLinkObjectpropCount++;
                }

                if (bodyexternalLinkexternalLinkURL != null)
                {
                    externalLinkObject["url"] = SourceExpressionConverter.ConvertToken(bodyexternalLinkexternalLinkURL);
                    externalLinkObjectpropCount++;
                }

                if (externalLinkObjectpropCount > 0)
                {
                    body["externalLink"] = externalLinkObject;
                    bodypropCount++;
                }

                if (bodyassignees != null)
                {
                    body["assignedUserIds"] = SourceExpressionConverter.ConvertToken(bodyassignees);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CardResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leankit")]
        public IBodyWorkflowAction<CardResponse> DeleteCard([WorkflowExpression] Func<string> cardId)
        {
            SourceExpression.Validate(cardId, nameof(cardId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/io/card/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CardResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leankit")]
        public IBodyWorkflowAction<AddCommentResponse> AddComment([WorkflowExpression] Func<string> cardId, [WorkflowExpression] Func<string> bodycomment)
        {
            SourceExpression.Validate(cardId, nameof(cardId), required: true);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/io/card/{0}/comment", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = SourceExpressionConverter.ConvertToken(bodycomment);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddCommentResponse>(BuildSourceInput);
        }
    }

    public class LeankitTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CardResponse[]> TrigNewCard([WorkflowExpression] Func<string> board, [WorkflowExpression] Func<string> lane, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(board, nameof(board), required: true);
            SourceExpression.Validate(lane, nameof(lane), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/add_card_trigger/io/card";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board"] = SourceExpressionConverter.ConvertO(board);
                callPayload.Queries["lane"] = SourceExpressionConverter.ConvertO(lane);
                return callPayload;
            }

            return new ApiConnectionTrigger<CardResponse[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<CardResponse[]> TrigUpdateCard([WorkflowExpression] Func<string> board, [WorkflowExpression] Func<string> lane, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(board, nameof(board), required: true);
            SourceExpression.Validate(lane, nameof(lane), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/update_card_trigger/io/card";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board"] = SourceExpressionConverter.ConvertO(board);
                callPayload.Queries["lane"] = SourceExpressionConverter.ConvertO(lane);
                return callPayload;
            }

            return new ApiConnectionTrigger<CardResponse[]>(BuildSourceInput, triggerName, recurrence);
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