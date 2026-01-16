//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Trello
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TrelloActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Card[]> ListCards(Expression<Func<string>> boardId, Expression<Func<string>> actions = null, Expression<Func<bool>> attachments = null, Expression<Func<string>> attachmentFields = null, Expression<Func<bool>> stickers = null, Expression<Func<bool>> members = null, Expression<Func<string>> memeberFields = null, Expression<Func<bool>> checkItemStates = null, Expression<Func<checklistsInput>> checklists = null, Expression<Func<int>> limit = null, Expression<Func<string>> since = null, Expression<Func<string>> before = null, Expression<Func<filterInput>> filter = null, Expression<Func<string>> fields = null)
        {
            var apiCallPath = String.Format("/boards/{0}/cards", ExpressionConverter.ConvertWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (actions != null)
                callPayload.Queries["actions"] = ExpressionConverter.Convert(actions);
            if (attachments != null)
                callPayload.Queries["attachments"] = ExpressionConverter.Convert(attachments);
            if (attachmentFields != null)
                callPayload.Queries["attachment_fields"] = ExpressionConverter.Convert(attachmentFields);
            if (stickers != null)
                callPayload.Queries["stickers"] = ExpressionConverter.Convert(stickers);
            if (members != null)
                callPayload.Queries["members"] = ExpressionConverter.Convert(members);
            if (memeberFields != null)
                callPayload.Queries["memeber_fields"] = ExpressionConverter.Convert(memeberFields);
            if (checkItemStates != null)
                callPayload.Queries["checkItemStates"] = ExpressionConverter.Convert(checkItemStates);
            if (checklists != null)
                callPayload.Queries["checklists"] = ExpressionConverter.Convert(checklists);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (since != null)
                callPayload.Queries["since"] = ExpressionConverter.Convert(since);
            if (before != null)
                callPayload.Queries["before"] = ExpressionConverter.Convert(before);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            return new ApiConnectionAction<Card[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Card[]> ListCardsSimple(Expression<Func<string>> boardId)
        {
            var apiCallPath = String.Format("/simple/boards/{0}/cards", ExpressionConverter.ConvertWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Card[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<CardWithChecklists> GetCard(Expression<Func<string>> boardId, Expression<Func<string>> cardId, Expression<Func<string>> actions = null, Expression<Func<bool>> actionsEntities = null, Expression<Func<bool>> actionsDisplay = null, Expression<Func<int>> actionsLimit = null, Expression<Func<string>> actionFields = null, Expression<Func<string>> actionMemberCreatorFields = null, Expression<Func<bool>> attachments = null, Expression<Func<string>> attachmentFields = null, Expression<Func<bool>> members = null, Expression<Func<string>> memberFields = null, Expression<Func<bool>> membersVoted = null, Expression<Func<string>> memberVotedFields = null, Expression<Func<bool>> checkItemStates = null, Expression<Func<string>> checkItemStateFields = null, Expression<Func<checklistsInput>> checklists = null, Expression<Func<string>> checklistFields = null, Expression<Func<bool>> board = null, Expression<Func<string>> boardFields = null, Expression<Func<bool>> list = null, Expression<Func<string>> listFields = null, Expression<Func<bool>> stickers = null, Expression<Func<string>> stickerFields = null, Expression<Func<string>> fields = null)
        {
            var apiCallPath = String.Format("/cards/{0}", ExpressionConverter.ConvertWithUrlEncoding(cardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["board_id"] = ExpressionConverter.Convert(boardId);
            if (actions != null)
                callPayload.Queries["actions"] = ExpressionConverter.Convert(actions);
            if (actionsEntities != null)
                callPayload.Queries["actions_entities"] = ExpressionConverter.Convert(actionsEntities);
            if (actionsDisplay != null)
                callPayload.Queries["actions_display"] = ExpressionConverter.Convert(actionsDisplay);
            if (actionsLimit != null)
                callPayload.Queries["actions_limit"] = ExpressionConverter.Convert(actionsLimit);
            if (actionFields != null)
                callPayload.Queries["action_fields"] = ExpressionConverter.Convert(actionFields);
            if (actionMemberCreatorFields != null)
                callPayload.Queries["action_memberCreator_fields"] = ExpressionConverter.Convert(actionMemberCreatorFields);
            if (attachments != null)
                callPayload.Queries["attachments"] = ExpressionConverter.Convert(attachments);
            if (attachmentFields != null)
                callPayload.Queries["attachment_fields"] = ExpressionConverter.Convert(attachmentFields);
            if (members != null)
                callPayload.Queries["members"] = ExpressionConverter.Convert(members);
            if (memberFields != null)
                callPayload.Queries["member_fields"] = ExpressionConverter.Convert(memberFields);
            if (membersVoted != null)
                callPayload.Queries["membersVoted"] = ExpressionConverter.Convert(membersVoted);
            if (memberVotedFields != null)
                callPayload.Queries["memberVoted_fields"] = ExpressionConverter.Convert(memberVotedFields);
            if (checkItemStates != null)
                callPayload.Queries["checkItemStates"] = ExpressionConverter.Convert(checkItemStates);
            if (checkItemStateFields != null)
                callPayload.Queries["checkItemState_fields"] = ExpressionConverter.Convert(checkItemStateFields);
            if (checklists != null)
                callPayload.Queries["checklists"] = ExpressionConverter.Convert(checklists);
            if (checklistFields != null)
                callPayload.Queries["checklist_fields"] = ExpressionConverter.Convert(checklistFields);
            if (board != null)
                callPayload.Queries["board"] = ExpressionConverter.Convert(board);
            if (boardFields != null)
                callPayload.Queries["board_fields"] = ExpressionConverter.Convert(boardFields);
            if (list != null)
                callPayload.Queries["list"] = ExpressionConverter.Convert(list);
            if (listFields != null)
                callPayload.Queries["list_fields"] = ExpressionConverter.Convert(listFields);
            if (stickers != null)
                callPayload.Queries["stickers"] = ExpressionConverter.Convert(stickers);
            if (stickerFields != null)
                callPayload.Queries["sticker_fields"] = ExpressionConverter.Convert(stickerFields);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            return new ApiConnectionAction<CardWithChecklists>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<JToken> DeleteCard(Expression<Func<string>> boardId, Expression<Func<string>> cardId)
        {
            var apiCallPath = String.Format("/cards/{0}", ExpressionConverter.ConvertWithUrlEncoding(cardId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["board_id"] = ExpressionConverter.Convert(boardId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Card> UpdateCardV2(Expression<Func<string>> boardId, Expression<Func<string>> cardId, Expression<Func<string>> updateCardname, Expression<Func<string>> updateCarddescription = null, Expression<Func<bool>> updateCardisClosed = null, Expression<Func<string[]>> updateCardmemberIds = null, Expression<Func<string>> updateCardcoverAttachmentIds = null, Expression<Func<string>> updateCardboardId = null, Expression<Func<string>> updateCardlistId = null, Expression<Func<string>> updateCardposition = null, Expression<Func<string>> updateCarddueDate = null, Expression<Func<bool>> updateCardsubscribedToCard = null)
        {
            var apiCallPath = String.Format("/v2/cards/{0}", ExpressionConverter.ConvertWithUrlEncoding(cardId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["board_id"] = ExpressionConverter.Convert(boardId);
            var updateCard = new JObject();
            var updateCardpropCount = 0;
            updateCardpropCount++;
            updateCard["name"] = ExpressionConverter.ConvertO(updateCardname);
            if (updateCarddescription != null)
            {
                updateCard["desc"] = ExpressionConverter.ConvertO(updateCarddescription);
                updateCardpropCount++;
            }

            if (updateCardisClosed != null)
            {
                updateCard["closed"] = ExpressionConverter.ConvertO(updateCardisClosed);
                updateCardpropCount++;
            }

            if (updateCardmemberIds != null)
            {
                updateCard["idMembersArray"] = ExpressionConverter.ConvertO(updateCardmemberIds);
                updateCardpropCount++;
            }

            if (updateCardcoverAttachmentIds != null)
            {
                updateCard["idAttachmentCover"] = ExpressionConverter.ConvertO(updateCardcoverAttachmentIds);
                updateCardpropCount++;
            }

            if (updateCardboardId != null)
            {
                updateCard["idBoard"] = ExpressionConverter.ConvertO(updateCardboardId);
                updateCardpropCount++;
            }

            if (updateCardlistId != null)
            {
                updateCard["idList"] = ExpressionConverter.ConvertO(updateCardlistId);
                updateCardpropCount++;
            }

            if (updateCardposition != null)
            {
                updateCard["pos"] = ExpressionConverter.ConvertO(updateCardposition);
                updateCardpropCount++;
            }

            if (updateCarddueDate != null)
            {
                updateCard["due"] = ExpressionConverter.ConvertO(updateCarddueDate);
                updateCardpropCount++;
            }

            if (updateCardsubscribedToCard != null)
            {
                updateCard["subscribed"] = ExpressionConverter.ConvertO(updateCardsubscribedToCard);
                updateCardpropCount++;
            }

            if (updateCardpropCount > 0)
            {
                callPayload.Body = updateCard;
            }

            return new ApiConnectionAction<Card>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Card> CreateCardV2(Expression<Func<string>> boardId, Expression<Func<string>> newCardparentListId, Expression<Func<string>> newCardcardName, Expression<Func<string>> newCardcardDescription = null, Expression<Func<newCardcardPositionInput>> newCardcardPosition = null, Expression<Func<string[]>> newCardmemberIds = null, Expression<Func<string[]>> newCardlabelIds = null, Expression<Func<string>> newCardsourceUrl = null, Expression<Func<string>> newCardsourceFile = null, Expression<Func<string>> newCardsourceCardId = null, Expression<Func<string>> newCardpropertiesFromSourceCard = null, Expression<Func<string>> newCarddueDate = null)
        {
            var apiCallPath = "/v2/cards";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["board_id"] = ExpressionConverter.Convert(boardId);
            var newCard = new JObject();
            var newCardpropCount = 0;
            newCardpropCount++;
            newCard["idList"] = ExpressionConverter.ConvertO(newCardparentListId);
            newCardpropCount++;
            newCard["name"] = ExpressionConverter.ConvertO(newCardcardName);
            if (newCardcardDescription != null)
            {
                newCard["desc"] = ExpressionConverter.ConvertO(newCardcardDescription);
                newCardpropCount++;
            }

            if (newCardcardPosition != null)
            {
                newCard["pos"] = ExpressionConverter.ConvertO(newCardcardPosition);
                newCardpropCount++;
            }

            if (newCardmemberIds != null)
            {
                newCard["idMembersArray"] = ExpressionConverter.ConvertO(newCardmemberIds);
                newCardpropCount++;
            }

            if (newCardlabelIds != null)
            {
                newCard["idLabelsArray"] = ExpressionConverter.ConvertO(newCardlabelIds);
                newCardpropCount++;
            }

            if (newCardsourceUrl != null)
            {
                newCard["urlSource"] = ExpressionConverter.ConvertO(newCardsourceUrl);
                newCardpropCount++;
            }

            if (newCardsourceFile != null)
            {
                newCard["fileSource"] = ExpressionConverter.ConvertO(newCardsourceFile);
                newCardpropCount++;
            }

            if (newCardsourceCardId != null)
            {
                newCard["idCardSource"] = ExpressionConverter.ConvertO(newCardsourceCardId);
                newCardpropCount++;
            }

            if (newCardpropertiesFromSourceCard != null)
            {
                newCard["keepFromSource"] = ExpressionConverter.ConvertO(newCardpropertiesFromSourceCard);
                newCardpropCount++;
            }

            if (newCarddueDate != null)
            {
                newCard["due"] = ExpressionConverter.ConvertO(newCarddueDate);
                newCardpropCount++;
            }

            if (newCardpropCount > 0)
            {
                callPayload.Body = newCard;
            }

            return new ApiConnectionAction<Card>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Board[]> ListBoards(Expression<Func<string>> filter = null, Expression<Func<string>> fields = null, Expression<Func<string>> actions = null, Expression<Func<bool>> actionsEntities = null, Expression<Func<int>> actionsLimit = null, Expression<Func<actionsFormatInput>> actionsFormat = null, Expression<Func<string>> actionsSince = null, Expression<Func<string>> actionFields = null, Expression<Func<string>> memberships = null, Expression<Func<bool>> organization = null, Expression<Func<string>> organizationFields = null, Expression<Func<string>> lists = null)
        {
            var apiCallPath = "/member/me/boards";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            if (actions != null)
                callPayload.Queries["actions"] = ExpressionConverter.Convert(actions);
            if (actionsEntities != null)
                callPayload.Queries["actions_entities"] = ExpressionConverter.Convert(actionsEntities);
            if (actionsLimit != null)
                callPayload.Queries["actions_limit"] = ExpressionConverter.Convert(actionsLimit);
            if (actionsFormat != null)
                callPayload.Queries["actions_format"] = ExpressionConverter.Convert(actionsFormat);
            if (actionsSince != null)
                callPayload.Queries["actions_since"] = ExpressionConverter.Convert(actionsSince);
            if (actionFields != null)
                callPayload.Queries["action_fields"] = ExpressionConverter.Convert(actionFields);
            if (memberships != null)
                callPayload.Queries["memberships"] = ExpressionConverter.Convert(memberships);
            if (organization != null)
                callPayload.Queries["organization"] = ExpressionConverter.Convert(organization);
            if (organizationFields != null)
                callPayload.Queries["organization_fields"] = ExpressionConverter.Convert(organizationFields);
            if (lists != null)
                callPayload.Queries["lists"] = ExpressionConverter.Convert(lists);
            return new ApiConnectionAction<Board[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Board[]> ListBoardsSimple()
        {
            var apiCallPath = "/simple/member/me/boards";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Board[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<BoardWithChecklists> GetBoard(Expression<Func<string>> boardId, Expression<Func<string>> actions = null, Expression<Func<bool>> actionEntities = null, Expression<Func<bool>> actionsDisplay = null, Expression<Func<actionsFormatInput>> actionsFormat = null, Expression<Func<string>> actionsSince = null, Expression<Func<int>> actionsLimit = null, Expression<Func<string>> actionFields = null, Expression<Func<bool>> actionMember = null, Expression<Func<string>> actionMemberFields = null, Expression<Func<bool>> actionMemberCreator = null, Expression<Func<string>> actionMemberCreatorFields = null, Expression<Func<cardsInput>> cards = null, Expression<Func<string>> cardFields = null, Expression<Func<bool>> cardAttachments = null, Expression<Func<string>> cardAttachmentFields = null, Expression<Func<cardChecklistsInput>> cardChecklists = null, Expression<Func<bool>> cardStickers = null, Expression<Func<boardStarsInput>> boardStars = null, Expression<Func<labelsInput>> labels = null, Expression<Func<string>> labelFields = null, Expression<Func<int>> labelsLimit = null, Expression<Func<listsInput>> lists = null, Expression<Func<string>> listFields = null, Expression<Func<string>> memberships = null, Expression<Func<bool>> membershipsMember = null, Expression<Func<string>> membershipsMemberFields = null, Expression<Func<membersInput>> members = null, Expression<Func<string>> memberFields = null, Expression<Func<membersInvitedInput>> membersInvited = null, Expression<Func<string>> membersInvitedFields = null, Expression<Func<checklistsInput>> checklists = null, Expression<Func<string>> checklistFields = null, Expression<Func<bool>> organization = null, Expression<Func<string>> organizationFields = null, Expression<Func<string>> organizationMemberships = null, Expression<Func<bool>> myPerfs = null, Expression<Func<string>> fields = null)
        {
            var apiCallPath = String.Format("/boards/{0}", ExpressionConverter.ConvertWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (actions != null)
                callPayload.Queries["actions"] = ExpressionConverter.Convert(actions);
            if (actionEntities != null)
                callPayload.Queries["action_entities"] = ExpressionConverter.Convert(actionEntities);
            if (actionsDisplay != null)
                callPayload.Queries["actions_display"] = ExpressionConverter.Convert(actionsDisplay);
            if (actionsFormat != null)
                callPayload.Queries["actions_format"] = ExpressionConverter.Convert(actionsFormat);
            if (actionsSince != null)
                callPayload.Queries["actions_since"] = ExpressionConverter.Convert(actionsSince);
            if (actionsLimit != null)
                callPayload.Queries["actions_limit"] = ExpressionConverter.Convert(actionsLimit);
            if (actionFields != null)
                callPayload.Queries["action_fields"] = ExpressionConverter.Convert(actionFields);
            if (actionMember != null)
                callPayload.Queries["action_member"] = ExpressionConverter.Convert(actionMember);
            if (actionMemberFields != null)
                callPayload.Queries["action_member_fields"] = ExpressionConverter.Convert(actionMemberFields);
            if (actionMemberCreator != null)
                callPayload.Queries["action_memberCreator"] = ExpressionConverter.Convert(actionMemberCreator);
            if (actionMemberCreatorFields != null)
                callPayload.Queries["action_memberCreator_fields"] = ExpressionConverter.Convert(actionMemberCreatorFields);
            if (cards != null)
                callPayload.Queries["cards"] = ExpressionConverter.Convert(cards);
            if (cardFields != null)
                callPayload.Queries["card_fields"] = ExpressionConverter.Convert(cardFields);
            if (cardAttachments != null)
                callPayload.Queries["card_attachments"] = ExpressionConverter.Convert(cardAttachments);
            if (cardAttachmentFields != null)
                callPayload.Queries["card_attachment_fields"] = ExpressionConverter.Convert(cardAttachmentFields);
            if (cardChecklists != null)
                callPayload.Queries["card_checklists"] = ExpressionConverter.Convert(cardChecklists);
            if (cardStickers != null)
                callPayload.Queries["card_stickers"] = ExpressionConverter.Convert(cardStickers);
            if (boardStars != null)
                callPayload.Queries["boardStars"] = ExpressionConverter.Convert(boardStars);
            if (labels != null)
                callPayload.Queries["labels"] = ExpressionConverter.Convert(labels);
            if (labelFields != null)
                callPayload.Queries["label_fields"] = ExpressionConverter.Convert(labelFields);
            if (labelsLimit != null)
                callPayload.Queries["labels_limit"] = ExpressionConverter.Convert(labelsLimit);
            if (lists != null)
                callPayload.Queries["lists"] = ExpressionConverter.Convert(lists);
            if (listFields != null)
                callPayload.Queries["list_fields"] = ExpressionConverter.Convert(listFields);
            if (memberships != null)
                callPayload.Queries["memberships"] = ExpressionConverter.Convert(memberships);
            if (membershipsMember != null)
                callPayload.Queries["memberships_member"] = ExpressionConverter.Convert(membershipsMember);
            if (membershipsMemberFields != null)
                callPayload.Queries["memberships_member_fields"] = ExpressionConverter.Convert(membershipsMemberFields);
            if (members != null)
                callPayload.Queries["members"] = ExpressionConverter.Convert(members);
            if (memberFields != null)
                callPayload.Queries["member_fields"] = ExpressionConverter.Convert(memberFields);
            if (membersInvited != null)
                callPayload.Queries["membersInvited"] = ExpressionConverter.Convert(membersInvited);
            if (membersInvitedFields != null)
                callPayload.Queries["membersInvited_fields"] = ExpressionConverter.Convert(membersInvitedFields);
            if (checklists != null)
                callPayload.Queries["checklists"] = ExpressionConverter.Convert(checklists);
            if (checklistFields != null)
                callPayload.Queries["checklist_fields"] = ExpressionConverter.Convert(checklistFields);
            if (organization != null)
                callPayload.Queries["organization"] = ExpressionConverter.Convert(organization);
            if (organizationFields != null)
                callPayload.Queries["organization_fields"] = ExpressionConverter.Convert(organizationFields);
            if (organizationMemberships != null)
                callPayload.Queries["organization_memberships"] = ExpressionConverter.Convert(organizationMemberships);
            if (myPerfs != null)
                callPayload.Queries["myPerfs"] = ExpressionConverter.Convert(myPerfs);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            return new ApiConnectionAction<BoardWithChecklists>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Board> UpdateBoard(Expression<Func<string>> boardId, Expression<Func<string>> boardboardName = null, Expression<Func<boardcreateDefaultListsInput>> boardcreateDefaultLists = null, Expression<Func<string>> boardboardDescription = null, Expression<Func<string>> boardteamId = null, Expression<Func<boardpermissionLevelInput>> boardpermissionLevel = null, Expression<Func<boardcommentPreferencesInput>> boardcommentPreferences = null, Expression<Func<boardinvitationPreferencesInput>> boardinvitationPreferences = null, Expression<Func<boarduseCardCoversInput>> boarduseCardCovers = null, Expression<Func<boardbackgroundColorInput>> boardbackgroundColor = null, Expression<Func<boardvotingPowerUpPreferencesInput>> boardvotingPowerUpPreferences = null, Expression<Func<boardcardAgingPowerUpPreferencesInput>> boardcardAgingPowerUpPreferences = null, Expression<Func<boardenableCalendarPowerUpInput>> boardenableCalendarPowerUp = null)
        {
            var apiCallPath = String.Format("/boards/{0}", ExpressionConverter.ConvertWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var board = new JObject();
            var boardpropCount = 0;
            if (boardboardName != null)
            {
                board["name"] = ExpressionConverter.ConvertO(boardboardName);
                boardpropCount++;
            }

            if (boardcreateDefaultLists != null)
            {
                board["defaultLists"] = ExpressionConverter.ConvertO(boardcreateDefaultLists);
                boardpropCount++;
            }

            if (boardboardDescription != null)
            {
                board["desc"] = ExpressionConverter.ConvertO(boardboardDescription);
                boardpropCount++;
            }

            if (boardteamId != null)
            {
                board["idOrganization"] = ExpressionConverter.ConvertO(boardteamId);
                boardpropCount++;
            }

            if (boardpermissionLevel != null)
            {
                board["prefs_permissionLevel"] = ExpressionConverter.ConvertO(boardpermissionLevel);
                boardpropCount++;
            }

            if (boardcommentPreferences != null)
            {
                board["prefs_comments"] = ExpressionConverter.ConvertO(boardcommentPreferences);
                boardpropCount++;
            }

            if (boardinvitationPreferences != null)
            {
                board["prefs_invitations"] = ExpressionConverter.ConvertO(boardinvitationPreferences);
                boardpropCount++;
            }

            if (boarduseCardCovers != null)
            {
                board["prefs_cardCovers"] = ExpressionConverter.ConvertO(boarduseCardCovers);
                boardpropCount++;
            }

            if (boardbackgroundColor != null)
            {
                board["prefs_background"] = ExpressionConverter.ConvertO(boardbackgroundColor);
                boardpropCount++;
            }

            if (boardvotingPowerUpPreferences != null)
            {
                board["prefs_voting"] = ExpressionConverter.ConvertO(boardvotingPowerUpPreferences);
                boardpropCount++;
            }

            if (boardcardAgingPowerUpPreferences != null)
            {
                board["prefs_cardAging"] = ExpressionConverter.ConvertO(boardcardAgingPowerUpPreferences);
                boardpropCount++;
            }

            if (boardenableCalendarPowerUp != null)
            {
                board["enable_calendar"] = ExpressionConverter.ConvertO(boardenableCalendarPowerUp);
                boardpropCount++;
            }

            if (boardpropCount > 0)
            {
                callPayload.Body = board;
            }

            return new ApiConnectionAction<Board>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<List[]> ListLists(Expression<Func<string>> boardId, Expression<Func<cardsInput>> cards = null, Expression<Func<string>> cardFields = null, Expression<Func<filterInput>> filter = null, Expression<Func<string>> fields = null)
        {
            var apiCallPath = String.Format("/boards/{0}/lists", ExpressionConverter.ConvertWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (cards != null)
                callPayload.Queries["cards"] = ExpressionConverter.Convert(cards);
            if (cardFields != null)
                callPayload.Queries["card_fields"] = ExpressionConverter.Convert(cardFields);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            return new ApiConnectionAction<List[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<List[]> ListListsSimple(Expression<Func<string>> boardId)
        {
            var apiCallPath = String.Format("/simple/boards/{0}/lists", ExpressionConverter.ConvertWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<List[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<List> GetList(Expression<Func<string>> boardId, Expression<Func<string>> listId, Expression<Func<cardsInput>> cards = null, Expression<Func<string>> cardFields = null, Expression<Func<bool>> board = null, Expression<Func<string>> boardFields = null, Expression<Func<string>> fields = null)
        {
            var apiCallPath = String.Format("/lists/{0}", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["board_id"] = ExpressionConverter.Convert(boardId);
            if (cards != null)
                callPayload.Queries["cards"] = ExpressionConverter.Convert(cards);
            if (cardFields != null)
                callPayload.Queries["card_fields"] = ExpressionConverter.Convert(cardFields);
            if (board != null)
                callPayload.Queries["board"] = ExpressionConverter.Convert(board);
            if (boardFields != null)
                callPayload.Queries["board_fields"] = ExpressionConverter.Convert(boardFields);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            return new ApiConnectionAction<List>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<CreateListResponse> UpdateList(Expression<Func<string>> boardId, Expression<Func<string>> listId, Expression<Func<string>> name = null, Expression<Func<closedInput>> closed = null, Expression<Func<string>> idBoard = null, Expression<Func<posInput>> pos = null, Expression<Func<subscribedInput>> subscribed = null)
        {
            var apiCallPath = String.Format("/lists/{0}", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["board_id"] = ExpressionConverter.Convert(boardId);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (closed != null)
                callPayload.Queries["closed"] = ExpressionConverter.Convert(closed);
            if (idBoard != null)
                callPayload.Queries["idBoard"] = ExpressionConverter.Convert(idBoard);
            if (pos != null)
                callPayload.Queries["pos"] = ExpressionConverter.Convert(pos);
            if (subscribed != null)
                callPayload.Queries["subscribed"] = ExpressionConverter.Convert(subscribed);
            return new ApiConnectionAction<CreateListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<JToken> GetUserProfile(Expression<Func<string>> fields = null)
        {
            var apiCallPath = "/members/me";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Team[]> ListTeams()
        {
            var apiCallPath = "/members/me/organizations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Team[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Member[]> ListTeamMembers(Expression<Func<string>> teamId)
        {
            var apiCallPath = String.Format("/organizations/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Member[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Member[]> ListBoardMembers(Expression<Func<string>> boardId)
        {
            var apiCallPath = String.Format("/boards/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Member[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<BoardLabel[]> ListBoardLabels(Expression<Func<string>> boardId)
        {
            var apiCallPath = String.Format("/boards/{0}/labels", ExpressionConverter.ConvertWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = Convert.ToString(1000);
            return new ApiConnectionAction<BoardLabel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Team> GetTeamForBoard(Expression<Func<string>> boardId)
        {
            var apiCallPath = String.Format("/boards/{0}/organization", ExpressionConverter.ConvertWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Team>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Member[]> ListCardMembers(Expression<Func<string>> boardId, Expression<Func<string>> cardId)
        {
            var apiCallPath = String.Format("/cards/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(cardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["board_id"] = ExpressionConverter.Convert(boardId);
            return new ApiConnectionAction<Member[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Comment[]> ListCardComments(Expression<Func<string>> boardId, Expression<Func<string>> cardId)
        {
            var apiCallPath = String.Format("/cards/{0}/actions", ExpressionConverter.ConvertWithUrlEncoding(cardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["board_id"] = ExpressionConverter.Convert(boardId);
            return new ApiConnectionAction<Comment[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Comment> AddCommentToCard(Expression<Func<string>> boardId, Expression<Func<string>> cardId, Expression<Func<string>> commentcommentText = null)
        {
            var apiCallPath = String.Format("/cards/{0}/actions/comments", ExpressionConverter.ConvertWithUrlEncoding(cardId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["board_id"] = ExpressionConverter.Convert(boardId);
            var comment = new JObject();
            var commentpropCount = 0;
            if (commentcommentText != null)
            {
                comment["text"] = ExpressionConverter.ConvertO(commentcommentText);
                commentpropCount++;
            }

            if (commentpropCount > 0)
            {
                callPayload.Body = comment;
            }

            return new ApiConnectionAction<Comment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Member[]> AddMemberToCard(Expression<Func<string>> boardId, Expression<Func<string>> cardId, Expression<Func<string>> memberId)
        {
            var apiCallPath = String.Format("/cards/{0}/idMembers", ExpressionConverter.ConvertWithUrlEncoding(cardId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["board_id"] = ExpressionConverter.Convert(boardId);
            callPayload.Queries["memberId"] = ExpressionConverter.Convert(memberId);
            return new ApiConnectionAction<Member[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Board> CreateBoard(Expression<Func<string>> boardboardName, Expression<Func<boardcreateDefaultListsInput>> boardcreateDefaultLists = null, Expression<Func<string>> boardboardDescription = null, Expression<Func<string>> boardteamId = null, Expression<Func<boardpermissionLevelInput>> boardpermissionLevel = null, Expression<Func<boardcommentPreferencesInput>> boardcommentPreferences = null, Expression<Func<boardinvitationPreferencesInput>> boardinvitationPreferences = null, Expression<Func<boarduseCardCoversInput>> boarduseCardCovers = null, Expression<Func<boardbackgroundColorInput>> boardbackgroundColor = null, Expression<Func<boardvotingPowerUpPreferencesInput>> boardvotingPowerUpPreferences = null, Expression<Func<boardcardAgingPowerUpPreferencesInput>> boardcardAgingPowerUpPreferences = null, Expression<Func<boardenableCalendarPowerUpInput>> boardenableCalendarPowerUp = null)
        {
            var apiCallPath = "/boards";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var board = new JObject();
            var boardpropCount = 0;
            boardpropCount++;
            board["name"] = ExpressionConverter.ConvertO(boardboardName);
            if (boardcreateDefaultLists != null)
            {
                board["defaultLists"] = ExpressionConverter.ConvertO(boardcreateDefaultLists);
                boardpropCount++;
            }

            if (boardboardDescription != null)
            {
                board["desc"] = ExpressionConverter.ConvertO(boardboardDescription);
                boardpropCount++;
            }

            if (boardteamId != null)
            {
                board["idOrganization"] = ExpressionConverter.ConvertO(boardteamId);
                boardpropCount++;
            }

            if (boardpermissionLevel != null)
            {
                board["prefs_permissionLevel"] = ExpressionConverter.ConvertO(boardpermissionLevel);
                boardpropCount++;
            }

            if (boardcommentPreferences != null)
            {
                board["prefs_comments"] = ExpressionConverter.ConvertO(boardcommentPreferences);
                boardpropCount++;
            }

            if (boardinvitationPreferences != null)
            {
                board["prefs_invitations"] = ExpressionConverter.ConvertO(boardinvitationPreferences);
                boardpropCount++;
            }

            if (boarduseCardCovers != null)
            {
                board["prefs_cardCovers"] = ExpressionConverter.ConvertO(boarduseCardCovers);
                boardpropCount++;
            }

            if (boardbackgroundColor != null)
            {
                board["prefs_background"] = ExpressionConverter.ConvertO(boardbackgroundColor);
                boardpropCount++;
            }

            if (boardvotingPowerUpPreferences != null)
            {
                board["prefs_voting"] = ExpressionConverter.ConvertO(boardvotingPowerUpPreferences);
                boardpropCount++;
            }

            if (boardcardAgingPowerUpPreferences != null)
            {
                board["prefs_cardAging"] = ExpressionConverter.ConvertO(boardcardAgingPowerUpPreferences);
                boardpropCount++;
            }

            if (boardenableCalendarPowerUp != null)
            {
                board["enable_calendar"] = ExpressionConverter.ConvertO(boardenableCalendarPowerUp);
                boardpropCount++;
            }

            if (boardpropCount > 0)
            {
                callPayload.Body = board;
            }

            return new ApiConnectionAction<Board>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<CreateListResponse> CreateList(Expression<Func<string>> listlistName, Expression<Func<string>> listboardId, Expression<Func<listlistPositionInput>> listlistPosition = null, Expression<Func<string>> listlistSource = null)
        {
            var apiCallPath = "/lists";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var list = new JObject();
            var listpropCount = 0;
            listpropCount++;
            list["name"] = ExpressionConverter.ConvertO(listlistName);
            listpropCount++;
            list["idBoard"] = ExpressionConverter.ConvertO(listboardId);
            if (listlistPosition != null)
            {
                list["pos"] = ExpressionConverter.ConvertO(listlistPosition);
                listpropCount++;
            }

            if (listlistSource != null)
            {
                list["idListSource"] = ExpressionConverter.ConvertO(listlistSource);
                listpropCount++;
            }

            if (listpropCount > 0)
            {
                callPayload.Body = list;
            }

            return new ApiConnectionAction<CreateListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Board> CloseBoard(Expression<Func<string>> boardId)
        {
            var apiCallPath = String.Format("/boards/{0}/closed", ExpressionConverter.ConvertWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Board>(callPayload);
        }
    }

    public class TrelloTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<CardInAction[]> OnNewCardInBoardV2(Expression<Func<string>> boardId, string triggerName = null)
        {
            var apiCallPath = String.Format("/v2/trigger/boards/{0}/actions", ExpressionConverter.ConvertWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<CardInAction[]>(callPayload);
        }

        public IOutputWorkflowTrigger<CardInAction[]> OnNewCardInListV2(Expression<Func<string>> boardId, Expression<Func<string>> listId, string triggerName = null)
        {
            var apiCallPath = String.Format("/v2/trigger/lists/{0}/actions", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["board_id"] = ExpressionConverter.Convert(boardId);
            return new ApiConnectionTrigger<CardInAction[]>(callPayload);
        }

        public IOutputWorkflowTrigger<CardInAction[]> OnNewCardInBoardV3(Expression<Func<string>> boardId, string triggerName = null)
        {
            var input = new ApiConnectionNotificationActionInput(connectionId);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            subscription["NotificationURL"] = "@listcallbackurl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                input.Subscribe.Body = subscription;
            }

            return new ApiConnectionTrigger<CardInAction[]>(input);
        }

        public IOutputWorkflowTrigger<CardInAction[]> OnNewCardInListV3(Expression<Func<string>> boardId, Expression<Func<string>> listId, string triggerName = null)
        {
            var input = new ApiConnectionNotificationActionInput(connectionId);
            input.Fetch.Queries["board_id"] = ExpressionConverter.Convert(boardId);
            input.Subscribe.Queries["board_id"] = ExpressionConverter.Convert(boardId);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            subscription["NotificationURL"] = "@listcallbackurl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                input.Subscribe.Body = subscription;
            }

            return new ApiConnectionTrigger<CardInAction[]>(input);
        }
    }

    public class Card
    {
        [JsonProperty("id")]
        public string CardId { get; set; }

        [JsonProperty("checkItemStates")]
        public CheckItemStateInfo[] CheckItemStates { get; set; }

        [JsonProperty("closed")]
        public bool CardClosed { get; set; }

        [JsonProperty("dateLastActivity")]
        public string LastActivityDate { get; set; }

        [JsonProperty("desc")]
        public string CardDescription { get; set; }

        [JsonProperty("idBoard")]
        public string BoardId { get; set; }

        [JsonProperty("idList")]
        public string ListId { get; set; }

        [JsonProperty("idMembersVoted")]
        public string[] VotedMemberIds { get; set; }

        [JsonProperty("idShort")]
        public int CardShortId { get; set; }

        [JsonProperty("idAttachmentCover")]
        public string AttachmentCoverId { get; set; }

        [JsonProperty("manualCoverAttachment")]
        public bool IsManualCoverAttachment { get; set; }

        [JsonProperty("idLabels")]
        public string[] LabelIds { get; set; }

        [JsonProperty("name")]
        public string CardName { get; set; }

        [JsonProperty("pos")]
        public double CardPosition { get; set; }

        [JsonProperty("shortLink")]
        public string CardShortLink { get; set; }

        [JsonProperty("badges")]
        public Badges Badges { get; set; }

        [JsonProperty("due")]
        public string CardDueDate { get; set; }

        [JsonProperty("shortUrl")]
        public string CardShortUrl { get; set; }

        [JsonProperty("subscribed")]
        public bool IsSubscribed { get; set; }

        [JsonProperty("url")]
        public string CardFullUrl { get; set; }

        [JsonProperty("checklists")]
        public Checklist[] Checklists { get; set; }
    }

    public class CheckItemStateInfo
    {
        [JsonProperty("idCheckItem")]
        public string CheckItemId { get; set; }

        [JsonProperty("state")]
        public string CheckItemState { get; set; }
    }

    public class Badges
    {
        public int Votes { get; set; }
        public bool ViewingMemberVoted { get; set; }

        [JsonProperty("Subscribed")]
        public bool SubscribedToBadge { get; set; }
        public string Fogbugz { get; set; }
        public int CheckItems { get; set; }

        [JsonProperty("CheckItemsChecked")]
        public int CheckedCheckItems { get; set; }
        public int Comments { get; set; }
        public int Attachments { get; set; }
        public bool Description { get; set; }

        [JsonProperty("Due")]
        public string DueDate { get; set; }
    }

    public class Checklist
    {
        [JsonProperty("id")]
        public string ChecklistId { get; set; }

        [JsonProperty("name")]
        public string ChecklistName { get; set; }

        [JsonProperty("pos")]
        public int ChecklistPosition { get; set; }

        [JsonProperty("idBoard")]
        public string BoardId { get; set; }

        [JsonProperty("idCard")]
        public string CardId { get; set; }

        [JsonProperty("checkItems")]
        public Checkitem[] Checkitems { get; set; }
    }

    public class Checkitem
    {
        [JsonProperty("id")]
        public string CheckitemId { get; set; }

        [JsonProperty("name")]
        public string CheckitemName { get; set; }

        [JsonProperty("nameData")]
        public JToken CheckitemNameData { get; set; }

        [JsonProperty("pos")]
        public double CheckitemPosition { get; set; }

        [JsonProperty("state")]
        public string CheckitemState { get; set; }

        [JsonProperty("due")]
        public string CheckitemDueDate { get; set; }

        [JsonProperty("idMember")]
        public string MemberId { get; set; }

        [JsonProperty("idChecklist")]
        public string ChecklistId { get; set; }
    }

    public enum checklistsInput
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "none")]
        None
    }

    public enum filterInput
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "closed")]
        Closed,
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "open")]
        Open
    }

    public class CardWithChecklists
    {
        [JsonProperty("id")]
        public string CardId { get; set; }

        [JsonProperty("checkItemStates")]
        public CheckItemStateInfo[] CheckItemStates { get; set; }

        [JsonProperty("closed")]
        public bool CardClosed { get; set; }

        [JsonProperty("dateLastActivity")]
        public string LastActivityDate { get; set; }

        [JsonProperty("desc")]
        public string CardDescription { get; set; }

        [JsonProperty("idBoard")]
        public string BoardId { get; set; }

        [JsonProperty("idList")]
        public string ListId { get; set; }

        [JsonProperty("idMembersVoted")]
        public string[] VotedMemberIds { get; set; }

        [JsonProperty("idShort")]
        public int CardShortId { get; set; }

        [JsonProperty("idAttachmentCover")]
        public string AttachmentCoverId { get; set; }

        [JsonProperty("manualCoverAttachment")]
        public bool IsManualCoverAttachment { get; set; }

        [JsonProperty("idLabels")]
        public string[] LabelIds { get; set; }

        [JsonProperty("name")]
        public string CardName { get; set; }

        [JsonProperty("pos")]
        public double CardPosition { get; set; }

        [JsonProperty("shortLink")]
        public string CardShortLink { get; set; }

        [JsonProperty("badges")]
        public Badges Badges { get; set; }

        [JsonProperty("due")]
        public string CardDueDate { get; set; }

        [JsonProperty("shortUrl")]
        public string CardShortUrl { get; set; }

        [JsonProperty("subscribed")]
        public bool IsSubscribed { get; set; }

        [JsonProperty("url")]
        public string CardFullUrl { get; set; }

        [JsonProperty("checklists")]
        public Checklist[] Checklists { get; set; }
    }

    public enum newCardcardPositionInput
    {
        [EnumMember(Value = "top")]
        Top,
        [EnumMember(Value = "bottom")]
        Bottom
    }

    public class Board
    {
        [JsonProperty("id")]
        public string BoardId { get; set; }

        [JsonProperty("closed")]
        public bool IsClosed { get; set; }

        [JsonProperty("dateLastActivity")]
        public string LastActivityDate { get; set; }

        [JsonProperty("dateLastView")]
        public string LastViewedDate { get; set; }

        [JsonProperty("desc")]
        public string BoardDescription { get; set; }

        [JsonProperty("idOrganization")]
        public string OrganizationId { get; set; }

        [JsonProperty("invitations")]
        public string[] Invitations { get; set; }

        [JsonProperty("invited")]
        public bool Invited { get; set; }

        [JsonProperty("labelNames")]
        public Label LabelNames { get; set; }

        [JsonProperty("memberships")]
        public Membership[] BoardMemberships { get; set; }

        [JsonProperty("name")]
        public string BoardName { get; set; }

        [JsonProperty("pinned")]
        public bool IsBoardPinned { get; set; }

        [JsonProperty("powerUps")]
        public string[] Powerups { get; set; }

        [JsonProperty("perfs")]
        public Perfs Perfs { get; set; }

        [JsonProperty("shortLink")]
        public string BoardShortLink { get; set; }

        [JsonProperty("shortUrl")]
        public string BoardShortUrl { get; set; }

        [JsonProperty("starred")]
        public bool IsStarred { get; set; }

        [JsonProperty("subscribed")]
        public bool SubscribedToBoard { get; set; }

        [JsonProperty("url")]
        public string BoardUrl { get; set; }
    }

    public class Label
    {
        [JsonProperty("green")]
        public string GreenLabel { get; set; }

        [JsonProperty("yellow")]
        public string YellowLabel { get; set; }

        [JsonProperty("orange")]
        public string OrangeLabel { get; set; }

        [JsonProperty("red")]
        public string RedLabel { get; set; }

        [JsonProperty("purple")]
        public string PurpleLabel { get; set; }

        [JsonProperty("blue")]
        public string BlueLabel { get; set; }

        [JsonProperty("sky")]
        public string SkyBlueLabel { get; set; }

        [JsonProperty("lime")]
        public string LimeGreenLabel { get; set; }

        [JsonProperty("pink")]
        public string PinkLabel { get; set; }

        [JsonProperty("black")]
        public string BlackLabel { get; set; }
    }

    public class Membership
    {
        [JsonProperty("id")]
        public string MembershipId { get; set; }

        [JsonProperty("idMember")]
        public string MemberId { get; set; }

        [JsonProperty("memberType")]
        public string MemberType { get; set; }

        [JsonProperty("unconfirmed")]
        public bool UnconfirmedMembership { get; set; }
    }

    public class Perfs
    {
        [JsonProperty("permissionLevel")]
        public string PermissionLevel { get; set; }

        [JsonProperty("voting")]
        public string VotingPermission { get; set; }

        [JsonProperty("comments")]
        public string CommentingPermission { get; set; }

        [JsonProperty("invitations")]
        public string InvitationPermission { get; set; }

        [JsonProperty("selfJoin")]
        public bool SelfJoinPermission { get; set; }

        [JsonProperty("cardCovers")]
        public bool CanAccessCardCovers { get; set; }

        [JsonProperty("calendarFeedEnabled")]
        public bool IsCalendarFeedEnabled { get; set; }

        [JsonProperty("background")]
        public string ObjectBackground { get; set; }

        [JsonProperty("backgroundColor")]
        public string ObjectBackgroundColor { get; set; }

        [JsonProperty("backgroundImage")]
        public string ObjectBackgroundImage { get; set; }

        [JsonProperty("backgroundImageScaled")]
        public string ScaledBackgroundImage { get; set; }

        [JsonProperty("backgroundTile")]
        public bool ObjectBackgroundTile { get; set; }

        [JsonProperty("backgroundBrightness")]
        public string BackgroundBrightness { get; set; }

        [JsonProperty("canBePublic")]
        public bool CanObjectBePublic { get; set; }

        [JsonProperty("canBeOrg")]
        public bool CanBePartOfOrganization { get; set; }

        [JsonProperty("canBePrivate")]
        public bool CanObjectBePrivate { get; set; }

        [JsonProperty("canInvite")]
        public bool CanInvite { get; set; }
    }

    public enum actionsFormatInput
    {
        [EnumMember(Value = "count")]
        Count,
        [EnumMember(Value = "list")]
        List,
        [EnumMember(Value = "minimal")]
        Minimal
    }

    public class BoardWithChecklists
    {
        [JsonProperty("id")]
        public string BoardId { get; set; }

        [JsonProperty("closed")]
        public bool IsClosed { get; set; }

        [JsonProperty("dateLastActivity")]
        public string LastActivityDate { get; set; }

        [JsonProperty("dateLastView")]
        public string LastViewedDate { get; set; }

        [JsonProperty("desc")]
        public string BoardDescription { get; set; }

        [JsonProperty("idOrganization")]
        public string OrganizationId { get; set; }

        [JsonProperty("invitations")]
        public string[] Invitations { get; set; }

        [JsonProperty("invited")]
        public bool Invited { get; set; }

        [JsonProperty("labelNames")]
        public Label LabelNames { get; set; }

        [JsonProperty("memberships")]
        public Membership[] BoardMemberships { get; set; }

        [JsonProperty("name")]
        public string BoardName { get; set; }

        [JsonProperty("pinned")]
        public bool IsBoardPinned { get; set; }

        [JsonProperty("powerUps")]
        public string[] Powerups { get; set; }

        [JsonProperty("perfs")]
        public Perfs Perfs { get; set; }

        [JsonProperty("shortLink")]
        public string BoardShortLink { get; set; }

        [JsonProperty("shortUrl")]
        public string BoardShortUrl { get; set; }

        [JsonProperty("starred")]
        public bool IsStarred { get; set; }

        [JsonProperty("subscribed")]
        public bool SubscribedToBoard { get; set; }

        [JsonProperty("url")]
        public string BoardUrl { get; set; }

        [JsonProperty("checklists")]
        public Checklist[] Checklists { get; set; }
    }

    public enum cardsInput
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "closed")]
        Closed,
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "open")]
        Open
    }

    public enum cardChecklistsInput
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "none")]
        None
    }

    public enum boardStarsInput
    {
        [EnumMember(Value = "mine")]
        Mine,
        [EnumMember(Value = "none")]
        None
    }

    public enum labelsInput
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "none")]
        None
    }

    public enum listsInput
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "closed")]
        Closed,
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "open")]
        Open
    }

    public enum membersInput
    {
        [EnumMember(Value = "admins")]
        Admins,
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "owners")]
        Owners
    }

    public enum membersInvitedInput
    {
        [EnumMember(Value = "admin")]
        Admin,
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "owners")]
        Owners
    }

    public enum boardcreateDefaultListsInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public enum boardpermissionLevelInput
    {
        [EnumMember(Value = "org")]
        Org,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "public")]
        Public
    }

    public enum boardcommentPreferencesInput
    {
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "members")]
        Members,
        [EnumMember(Value = "observers")]
        Observers,
        [EnumMember(Value = "org")]
        Org,
        [EnumMember(Value = "public")]
        Public
    }

    public enum boardinvitationPreferencesInput
    {
        [EnumMember(Value = "admins")]
        Admins,
        [EnumMember(Value = "members")]
        Members
    }

    public enum boarduseCardCoversInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public enum boardbackgroundColorInput
    {
        [EnumMember(Value = "blue")]
        Blue,
        [EnumMember(Value = "orange")]
        Orange,
        [EnumMember(Value = "green")]
        Green,
        [EnumMember(Value = "red")]
        Red,
        [EnumMember(Value = "purple")]
        Purple,
        [EnumMember(Value = "pink")]
        Pink,
        [EnumMember(Value = "lime")]
        Lime,
        [EnumMember(Value = "sky")]
        Sky,
        [EnumMember(Value = "grey")]
        Grey
    }

    public enum boardvotingPowerUpPreferencesInput
    {
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "members")]
        Members,
        [EnumMember(Value = "observers")]
        Observers,
        [EnumMember(Value = "org")]
        Org,
        [EnumMember(Value = "public")]
        Public
    }

    public enum boardcardAgingPowerUpPreferencesInput
    {
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "pirate")]
        Pirate,
        [EnumMember(Value = "regular")]
        Regular
    }

    public enum boardenableCalendarPowerUpInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public class List
    {
        [JsonProperty("id")]
        public string ListId { get; set; }

        [JsonProperty("name")]
        public string ListName { get; set; }

        [JsonProperty("closed")]
        public bool IsClosed { get; set; }

        [JsonProperty("idBoard")]
        public string BoardId { get; set; }

        [JsonProperty("pos")]
        public double ListPosition { get; set; }

        [JsonProperty("subscribed")]
        public bool IsListSubscribedTo { get; set; }

        [JsonProperty("cards")]
        public Card[] CardsInList { get; set; }

        [JsonProperty("board")]
        public Board Board { get; set; }
    }

    public class CreateListResponse
    {
        [JsonProperty("id")]
        public string ListId { get; set; }

        [JsonProperty("name")]
        public string ListName { get; set; }

        [JsonProperty("idBoard")]
        public string BoardId { get; set; }

        [JsonProperty("pos")]
        public double ListPosition { get; set; }
    }

    public enum closedInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public enum posInput
    {
        [EnumMember(Value = "top")]
        Top,
        [EnumMember(Value = "bottom")]
        Bottom
    }

    public enum subscribedInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public class Team
    {
        [JsonProperty("id")]
        public string TeamId { get; set; }

        [JsonProperty("desc")]
        public string TeamDescription { get; set; }

        [JsonProperty("displayName")]
        public string TeamDisplayName { get; set; }

        [JsonProperty("idBoards")]
        public string[] BoardIds { get; set; }

        [JsonProperty("billableMemberCount")]
        public int MemberCount { get; set; }

        [JsonProperty("memberships")]
        public Membership[] Memberships { get; set; }

        [JsonProperty("WebSite")]
        public string Website { get; set; }

        [JsonProperty("prefs")]
        public TeamPreferences Prefs { get; set; }
    }

    public class TeamPreferences
    {
        [JsonProperty("permissionLevel")]
        public string PermissionLevel { get; set; }
    }

    public class Member
    {
        [JsonProperty("id")]
        public string MemberId { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("initials")]
        public string Initials { get; set; }
    }

    public class BoardLabel
    {
        [JsonProperty("id")]
        public string LabelId { get; set; }

        [JsonProperty("name")]
        public string LabelName { get; set; }

        [JsonProperty("color")]
        public string LabelColor { get; set; }
    }

    public class Comment
    {
        [JsonProperty("memberCreator")]
        public Member MemberCreator { get; set; }

        [JsonProperty("text")]
        public string CommentText { get; set; }

        [JsonProperty("date")]
        public string DatetimeCreated { get; set; }
    }

    public enum listlistPositionInput
    {
        [EnumMember(Value = "top")]
        Top,
        [EnumMember(Value = "bottom")]
        Bottom
    }

    public class CardInAction
    {
        [JsonProperty("id")]
        public string CardId { get; set; }

        [JsonProperty("idShort")]
        public int CardShortId { get; set; }

        [JsonProperty("name")]
        public string CardName { get; set; }

        [JsonProperty("shortLink")]
        public string CardShortLink { get; set; }

        [JsonProperty("due")]
        public string CardDueDate { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Trello;

    public partial class WorkflowManagedActions
    {
        public TrelloActions Trello(string connectionId) => new TrelloActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TrelloTriggers Trello(string connectionId) => new TrelloTriggers(connectionId);
    }
}