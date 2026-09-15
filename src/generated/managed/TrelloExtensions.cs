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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/boards/{0}/cards", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (actions != null)
                callPayload.Queries["actions"] = CSharpExpressionConverter.ConvertO(actions);
            if (attachments != null)
                callPayload.Queries["attachments"] = CSharpExpressionConverter.ConvertO(attachments);
            if (attachmentFields != null)
                callPayload.Queries["attachment_fields"] = CSharpExpressionConverter.ConvertO(attachmentFields);
            if (stickers != null)
                callPayload.Queries["stickers"] = CSharpExpressionConverter.ConvertO(stickers);
            if (members != null)
                callPayload.Queries["members"] = CSharpExpressionConverter.ConvertO(members);
            if (memeberFields != null)
                callPayload.Queries["memeber_fields"] = CSharpExpressionConverter.ConvertO(memeberFields);
            if (checkItemStates != null)
                callPayload.Queries["checkItemStates"] = CSharpExpressionConverter.ConvertO(checkItemStates);
            if (checklists != null)
                callPayload.Queries["checklists"] = CSharpExpressionConverter.Convert(checklists);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (since != null)
                callPayload.Queries["since"] = CSharpExpressionConverter.ConvertO(since);
            if (before != null)
                callPayload.Queries["before"] = CSharpExpressionConverter.ConvertO(before);
            if (filter != null)
                callPayload.Queries["filter"] = CSharpExpressionConverter.Convert(filter);
            if (fields != null)
                callPayload.Queries["fields"] = CSharpExpressionConverter.ConvertO(fields);
            return new ApiConnectionAction<Card[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Card[]> ListCardsSimple(Expression<Func<string>> boardId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/simple/boards/{0}/cards", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Card[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<CardWithChecklists> GetCard(Expression<Func<string>> boardId, Expression<Func<string>> cardId, Expression<Func<string>> actions = null, Expression<Func<bool>> actionsEntities = null, Expression<Func<bool>> actionsDisplay = null, Expression<Func<int>> actionsLimit = null, Expression<Func<string>> actionFields = null, Expression<Func<string>> actionMemberCreatorFields = null, Expression<Func<bool>> attachments = null, Expression<Func<string>> attachmentFields = null, Expression<Func<bool>> members = null, Expression<Func<string>> memberFields = null, Expression<Func<bool>> membersVoted = null, Expression<Func<string>> memberVotedFields = null, Expression<Func<bool>> checkItemStates = null, Expression<Func<string>> checkItemStateFields = null, Expression<Func<checklistsInput>> checklists = null, Expression<Func<string>> checklistFields = null, Expression<Func<bool>> board = null, Expression<Func<string>> boardFields = null, Expression<Func<bool>> list = null, Expression<Func<string>> listFields = null, Expression<Func<bool>> stickers = null, Expression<Func<string>> stickerFields = null, Expression<Func<string>> fields = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/cards/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["board_id"] = CSharpExpressionConverter.ConvertO(boardId);
            if (actions != null)
                callPayload.Queries["actions"] = CSharpExpressionConverter.ConvertO(actions);
            if (actionsEntities != null)
                callPayload.Queries["actions_entities"] = CSharpExpressionConverter.ConvertO(actionsEntities);
            if (actionsDisplay != null)
                callPayload.Queries["actions_display"] = CSharpExpressionConverter.ConvertO(actionsDisplay);
            if (actionsLimit != null)
                callPayload.Queries["actions_limit"] = CSharpExpressionConverter.ConvertO(actionsLimit);
            if (actionFields != null)
                callPayload.Queries["action_fields"] = CSharpExpressionConverter.ConvertO(actionFields);
            if (actionMemberCreatorFields != null)
                callPayload.Queries["action_memberCreator_fields"] = CSharpExpressionConverter.ConvertO(actionMemberCreatorFields);
            if (attachments != null)
                callPayload.Queries["attachments"] = CSharpExpressionConverter.ConvertO(attachments);
            if (attachmentFields != null)
                callPayload.Queries["attachment_fields"] = CSharpExpressionConverter.ConvertO(attachmentFields);
            if (members != null)
                callPayload.Queries["members"] = CSharpExpressionConverter.ConvertO(members);
            if (memberFields != null)
                callPayload.Queries["member_fields"] = CSharpExpressionConverter.ConvertO(memberFields);
            if (membersVoted != null)
                callPayload.Queries["membersVoted"] = CSharpExpressionConverter.ConvertO(membersVoted);
            if (memberVotedFields != null)
                callPayload.Queries["memberVoted_fields"] = CSharpExpressionConverter.ConvertO(memberVotedFields);
            if (checkItemStates != null)
                callPayload.Queries["checkItemStates"] = CSharpExpressionConverter.ConvertO(checkItemStates);
            if (checkItemStateFields != null)
                callPayload.Queries["checkItemState_fields"] = CSharpExpressionConverter.ConvertO(checkItemStateFields);
            if (checklists != null)
                callPayload.Queries["checklists"] = CSharpExpressionConverter.Convert(checklists);
            if (checklistFields != null)
                callPayload.Queries["checklist_fields"] = CSharpExpressionConverter.ConvertO(checklistFields);
            if (board != null)
                callPayload.Queries["board"] = CSharpExpressionConverter.ConvertO(board);
            if (boardFields != null)
                callPayload.Queries["board_fields"] = CSharpExpressionConverter.ConvertO(boardFields);
            if (list != null)
                callPayload.Queries["list"] = CSharpExpressionConverter.ConvertO(list);
            if (listFields != null)
                callPayload.Queries["list_fields"] = CSharpExpressionConverter.ConvertO(listFields);
            if (stickers != null)
                callPayload.Queries["stickers"] = CSharpExpressionConverter.ConvertO(stickers);
            if (stickerFields != null)
                callPayload.Queries["sticker_fields"] = CSharpExpressionConverter.ConvertO(stickerFields);
            if (fields != null)
                callPayload.Queries["fields"] = CSharpExpressionConverter.ConvertO(fields);
            return new ApiConnectionAction<CardWithChecklists>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<JToken> DeleteCard(Expression<Func<string>> boardId, Expression<Func<string>> cardId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/cards/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["board_id"] = CSharpExpressionConverter.ConvertO(boardId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Board[]> ListBoards(Expression<Func<string>> filter = null, Expression<Func<string>> fields = null, Expression<Func<string>> actions = null, Expression<Func<bool>> actionsEntities = null, Expression<Func<int>> actionsLimit = null, Expression<Func<actionsFormatInput>> actionsFormat = null, Expression<Func<string>> actionsSince = null, Expression<Func<string>> actionFields = null, Expression<Func<string>> memberships = null, Expression<Func<bool>> organization = null, Expression<Func<string>> organizationFields = null, Expression<Func<string>> lists = null)
        {
            var apiCallPath = "/member/me/boards";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (fields != null)
                callPayload.Queries["fields"] = CSharpExpressionConverter.ConvertO(fields);
            if (actions != null)
                callPayload.Queries["actions"] = CSharpExpressionConverter.ConvertO(actions);
            if (actionsEntities != null)
                callPayload.Queries["actions_entities"] = CSharpExpressionConverter.ConvertO(actionsEntities);
            if (actionsLimit != null)
                callPayload.Queries["actions_limit"] = CSharpExpressionConverter.ConvertO(actionsLimit);
            if (actionsFormat != null)
                callPayload.Queries["actions_format"] = CSharpExpressionConverter.Convert(actionsFormat);
            if (actionsSince != null)
                callPayload.Queries["actions_since"] = CSharpExpressionConverter.ConvertO(actionsSince);
            if (actionFields != null)
                callPayload.Queries["action_fields"] = CSharpExpressionConverter.ConvertO(actionFields);
            if (memberships != null)
                callPayload.Queries["memberships"] = CSharpExpressionConverter.ConvertO(memberships);
            if (organization != null)
                callPayload.Queries["organization"] = CSharpExpressionConverter.ConvertO(organization);
            if (organizationFields != null)
                callPayload.Queries["organization_fields"] = CSharpExpressionConverter.ConvertO(organizationFields);
            if (lists != null)
                callPayload.Queries["lists"] = CSharpExpressionConverter.ConvertO(lists);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/boards/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (actions != null)
                callPayload.Queries["actions"] = CSharpExpressionConverter.ConvertO(actions);
            if (actionEntities != null)
                callPayload.Queries["action_entities"] = CSharpExpressionConverter.ConvertO(actionEntities);
            if (actionsDisplay != null)
                callPayload.Queries["actions_display"] = CSharpExpressionConverter.ConvertO(actionsDisplay);
            if (actionsFormat != null)
                callPayload.Queries["actions_format"] = CSharpExpressionConverter.Convert(actionsFormat);
            if (actionsSince != null)
                callPayload.Queries["actions_since"] = CSharpExpressionConverter.ConvertO(actionsSince);
            if (actionsLimit != null)
                callPayload.Queries["actions_limit"] = CSharpExpressionConverter.ConvertO(actionsLimit);
            if (actionFields != null)
                callPayload.Queries["action_fields"] = CSharpExpressionConverter.ConvertO(actionFields);
            if (actionMember != null)
                callPayload.Queries["action_member"] = CSharpExpressionConverter.ConvertO(actionMember);
            if (actionMemberFields != null)
                callPayload.Queries["action_member_fields"] = CSharpExpressionConverter.ConvertO(actionMemberFields);
            if (actionMemberCreator != null)
                callPayload.Queries["action_memberCreator"] = CSharpExpressionConverter.ConvertO(actionMemberCreator);
            if (actionMemberCreatorFields != null)
                callPayload.Queries["action_memberCreator_fields"] = CSharpExpressionConverter.ConvertO(actionMemberCreatorFields);
            if (cards != null)
                callPayload.Queries["cards"] = CSharpExpressionConverter.Convert(cards);
            if (cardFields != null)
                callPayload.Queries["card_fields"] = CSharpExpressionConverter.ConvertO(cardFields);
            if (cardAttachments != null)
                callPayload.Queries["card_attachments"] = CSharpExpressionConverter.ConvertO(cardAttachments);
            if (cardAttachmentFields != null)
                callPayload.Queries["card_attachment_fields"] = CSharpExpressionConverter.ConvertO(cardAttachmentFields);
            if (cardChecklists != null)
                callPayload.Queries["card_checklists"] = CSharpExpressionConverter.Convert(cardChecklists);
            if (cardStickers != null)
                callPayload.Queries["card_stickers"] = CSharpExpressionConverter.ConvertO(cardStickers);
            if (boardStars != null)
                callPayload.Queries["boardStars"] = CSharpExpressionConverter.Convert(boardStars);
            if (labels != null)
                callPayload.Queries["labels"] = CSharpExpressionConverter.Convert(labels);
            if (labelFields != null)
                callPayload.Queries["label_fields"] = CSharpExpressionConverter.ConvertO(labelFields);
            if (labelsLimit != null)
                callPayload.Queries["labels_limit"] = CSharpExpressionConverter.ConvertO(labelsLimit);
            if (lists != null)
                callPayload.Queries["lists"] = CSharpExpressionConverter.Convert(lists);
            if (listFields != null)
                callPayload.Queries["list_fields"] = CSharpExpressionConverter.ConvertO(listFields);
            if (memberships != null)
                callPayload.Queries["memberships"] = CSharpExpressionConverter.ConvertO(memberships);
            if (membershipsMember != null)
                callPayload.Queries["memberships_member"] = CSharpExpressionConverter.ConvertO(membershipsMember);
            if (membershipsMemberFields != null)
                callPayload.Queries["memberships_member_fields"] = CSharpExpressionConverter.ConvertO(membershipsMemberFields);
            if (members != null)
                callPayload.Queries["members"] = CSharpExpressionConverter.Convert(members);
            if (memberFields != null)
                callPayload.Queries["member_fields"] = CSharpExpressionConverter.ConvertO(memberFields);
            if (membersInvited != null)
                callPayload.Queries["membersInvited"] = CSharpExpressionConverter.Convert(membersInvited);
            if (membersInvitedFields != null)
                callPayload.Queries["membersInvited_fields"] = CSharpExpressionConverter.ConvertO(membersInvitedFields);
            if (checklists != null)
                callPayload.Queries["checklists"] = CSharpExpressionConverter.Convert(checklists);
            if (checklistFields != null)
                callPayload.Queries["checklist_fields"] = CSharpExpressionConverter.ConvertO(checklistFields);
            if (organization != null)
                callPayload.Queries["organization"] = CSharpExpressionConverter.ConvertO(organization);
            if (organizationFields != null)
                callPayload.Queries["organization_fields"] = CSharpExpressionConverter.ConvertO(organizationFields);
            if (organizationMemberships != null)
                callPayload.Queries["organization_memberships"] = CSharpExpressionConverter.ConvertO(organizationMemberships);
            if (myPerfs != null)
                callPayload.Queries["myPerfs"] = CSharpExpressionConverter.ConvertO(myPerfs);
            if (fields != null)
                callPayload.Queries["fields"] = CSharpExpressionConverter.ConvertO(fields);
            return new ApiConnectionAction<BoardWithChecklists>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Board> UpdateBoard(Expression<Func<string>> boardId, Expression<Func<string>> boardboardName = null, Expression<Func<boardcreateDefaultListsInput>> boardcreateDefaultLists = null, Expression<Func<string>> boardboardDescription = null, Expression<Func<string>> boardteamId = null, Expression<Func<boardpermissionLevelInput>> boardpermissionLevel = null, Expression<Func<boardcommentPreferencesInput>> boardcommentPreferences = null, Expression<Func<boardinvitationPreferencesInput>> boardinvitationPreferences = null, Expression<Func<boarduseCardCoversInput>> boarduseCardCovers = null, Expression<Func<boardbackgroundColorInput>> boardbackgroundColor = null, Expression<Func<boardvotingPowerUpPreferencesInput>> boardvotingPowerUpPreferences = null, Expression<Func<boardcardAgingPowerUpPreferencesInput>> boardcardAgingPowerUpPreferences = null, Expression<Func<boardenableCalendarPowerUpInput>> boardenableCalendarPowerUp = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/boards/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var board = new JObject();
            var boardpropCount = 0;
            if (boardboardName != null)
            {
                board["name"] = CSharpExpressionConverter.ConvertToken(boardboardName);
                boardpropCount++;
            }

            if (boardcreateDefaultLists != null)
            {
                board["defaultLists"] = CSharpExpressionConverter.Convert(boardcreateDefaultLists);
                boardpropCount++;
            }

            if (boardboardDescription != null)
            {
                board["desc"] = CSharpExpressionConverter.ConvertToken(boardboardDescription);
                boardpropCount++;
            }

            if (boardteamId != null)
            {
                board["idOrganization"] = CSharpExpressionConverter.ConvertToken(boardteamId);
                boardpropCount++;
            }

            if (boardpermissionLevel != null)
            {
                board["prefs_permissionLevel"] = CSharpExpressionConverter.Convert(boardpermissionLevel);
                boardpropCount++;
            }

            if (boardcommentPreferences != null)
            {
                board["prefs_comments"] = CSharpExpressionConverter.Convert(boardcommentPreferences);
                boardpropCount++;
            }

            if (boardinvitationPreferences != null)
            {
                board["prefs_invitations"] = CSharpExpressionConverter.Convert(boardinvitationPreferences);
                boardpropCount++;
            }

            if (boarduseCardCovers != null)
            {
                board["prefs_cardCovers"] = CSharpExpressionConverter.Convert(boarduseCardCovers);
                boardpropCount++;
            }

            if (boardbackgroundColor != null)
            {
                board["prefs_background"] = CSharpExpressionConverter.Convert(boardbackgroundColor);
                boardpropCount++;
            }

            if (boardvotingPowerUpPreferences != null)
            {
                board["prefs_voting"] = CSharpExpressionConverter.Convert(boardvotingPowerUpPreferences);
                boardpropCount++;
            }

            if (boardcardAgingPowerUpPreferences != null)
            {
                board["prefs_cardAging"] = CSharpExpressionConverter.Convert(boardcardAgingPowerUpPreferences);
                boardpropCount++;
            }

            if (boardenableCalendarPowerUp != null)
            {
                board["enable_calendar"] = CSharpExpressionConverter.Convert(boardenableCalendarPowerUp);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/boards/{0}/lists", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (cards != null)
                callPayload.Queries["cards"] = CSharpExpressionConverter.Convert(cards);
            if (cardFields != null)
                callPayload.Queries["card_fields"] = CSharpExpressionConverter.ConvertO(cardFields);
            if (filter != null)
                callPayload.Queries["filter"] = CSharpExpressionConverter.Convert(filter);
            if (fields != null)
                callPayload.Queries["fields"] = CSharpExpressionConverter.ConvertO(fields);
            return new ApiConnectionAction<List[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<List[]> ListListsSimple(Expression<Func<string>> boardId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/simple/boards/{0}/lists", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<List[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<List> GetList(Expression<Func<string>> boardId, Expression<Func<string>> listId, Expression<Func<cardsInput>> cards = null, Expression<Func<string>> cardFields = null, Expression<Func<bool>> board = null, Expression<Func<string>> boardFields = null, Expression<Func<string>> fields = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/lists/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["board_id"] = CSharpExpressionConverter.ConvertO(boardId);
            if (cards != null)
                callPayload.Queries["cards"] = CSharpExpressionConverter.Convert(cards);
            if (cardFields != null)
                callPayload.Queries["card_fields"] = CSharpExpressionConverter.ConvertO(cardFields);
            if (board != null)
                callPayload.Queries["board"] = CSharpExpressionConverter.ConvertO(board);
            if (boardFields != null)
                callPayload.Queries["board_fields"] = CSharpExpressionConverter.ConvertO(boardFields);
            if (fields != null)
                callPayload.Queries["fields"] = CSharpExpressionConverter.ConvertO(fields);
            return new ApiConnectionAction<List>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<CreateListResponse> UpdateList(Expression<Func<string>> boardId, Expression<Func<string>> listId, Expression<Func<string>> name = null, Expression<Func<closedInput>> closed = null, Expression<Func<string>> idBoard = null, Expression<Func<posInput>> pos = null, Expression<Func<subscribedInput>> subscribed = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/lists/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["board_id"] = CSharpExpressionConverter.ConvertO(boardId);
            if (name != null)
                callPayload.Queries["name"] = CSharpExpressionConverter.ConvertO(name);
            if (closed != null)
                callPayload.Queries["closed"] = CSharpExpressionConverter.Convert(closed);
            if (idBoard != null)
                callPayload.Queries["idBoard"] = CSharpExpressionConverter.ConvertO(idBoard);
            if (pos != null)
                callPayload.Queries["pos"] = CSharpExpressionConverter.Convert(pos);
            if (subscribed != null)
                callPayload.Queries["subscribed"] = CSharpExpressionConverter.Convert(subscribed);
            return new ApiConnectionAction<CreateListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<JToken> GetUserProfile(Expression<Func<string>> fields = null)
        {
            var apiCallPath = "/members/me";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fields != null)
                callPayload.Queries["fields"] = CSharpExpressionConverter.ConvertO(fields);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/organizations/{0}/members", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Member[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Member[]> ListBoardMembers(Expression<Func<string>> boardId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/boards/{0}/members", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Member[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<BoardLabel[]> ListBoardLabels(Expression<Func<string>> boardId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/boards/{0}/labels", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = Convert.ToString(1000);
            return new ApiConnectionAction<BoardLabel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Team> GetTeamForBoard(Expression<Func<string>> boardId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/boards/{0}/organization", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Team>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Member[]> ListCardMembers(Expression<Func<string>> boardId, Expression<Func<string>> cardId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/cards/{0}/members", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["board_id"] = CSharpExpressionConverter.ConvertO(boardId);
            return new ApiConnectionAction<Member[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Comment[]> ListCardComments(Expression<Func<string>> boardId, Expression<Func<string>> cardId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/cards/{0}/actions", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["board_id"] = CSharpExpressionConverter.ConvertO(boardId);
            return new ApiConnectionAction<Comment[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Comment> AddCommentToCard(Expression<Func<string>> boardId, Expression<Func<string>> cardId, Expression<Func<string>> commentcommentText = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/cards/{0}/actions/comments", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["board_id"] = CSharpExpressionConverter.ConvertO(boardId);
            var comment = new JObject();
            var commentpropCount = 0;
            if (commentcommentText != null)
            {
                comment["text"] = CSharpExpressionConverter.ConvertToken(commentcommentText);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/cards/{0}/idMembers", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["board_id"] = CSharpExpressionConverter.ConvertO(boardId);
            callPayload.Queries["memberId"] = CSharpExpressionConverter.ConvertO(memberId);
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
            board["name"] = CSharpExpressionConverter.ConvertToken(boardboardName);
            if (boardcreateDefaultLists != null)
            {
                board["defaultLists"] = CSharpExpressionConverter.Convert(boardcreateDefaultLists);
                boardpropCount++;
            }

            if (boardboardDescription != null)
            {
                board["desc"] = CSharpExpressionConverter.ConvertToken(boardboardDescription);
                boardpropCount++;
            }

            if (boardteamId != null)
            {
                board["idOrganization"] = CSharpExpressionConverter.ConvertToken(boardteamId);
                boardpropCount++;
            }

            if (boardpermissionLevel != null)
            {
                board["prefs_permissionLevel"] = CSharpExpressionConverter.Convert(boardpermissionLevel);
                boardpropCount++;
            }

            if (boardcommentPreferences != null)
            {
                board["prefs_comments"] = CSharpExpressionConverter.Convert(boardcommentPreferences);
                boardpropCount++;
            }

            if (boardinvitationPreferences != null)
            {
                board["prefs_invitations"] = CSharpExpressionConverter.Convert(boardinvitationPreferences);
                boardpropCount++;
            }

            if (boarduseCardCovers != null)
            {
                board["prefs_cardCovers"] = CSharpExpressionConverter.Convert(boarduseCardCovers);
                boardpropCount++;
            }

            if (boardbackgroundColor != null)
            {
                board["prefs_background"] = CSharpExpressionConverter.Convert(boardbackgroundColor);
                boardpropCount++;
            }

            if (boardvotingPowerUpPreferences != null)
            {
                board["prefs_voting"] = CSharpExpressionConverter.Convert(boardvotingPowerUpPreferences);
                boardpropCount++;
            }

            if (boardcardAgingPowerUpPreferences != null)
            {
                board["prefs_cardAging"] = CSharpExpressionConverter.Convert(boardcardAgingPowerUpPreferences);
                boardpropCount++;
            }

            if (boardenableCalendarPowerUp != null)
            {
                board["enable_calendar"] = CSharpExpressionConverter.Convert(boardenableCalendarPowerUp);
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
            list["name"] = CSharpExpressionConverter.ConvertToken(listlistName);
            listpropCount++;
            list["idBoard"] = CSharpExpressionConverter.ConvertToken(listboardId);
            if (listlistPosition != null)
            {
                list["pos"] = CSharpExpressionConverter.Convert(listlistPosition);
                listpropCount++;
            }

            if (listlistSource != null)
            {
                list["idListSource"] = CSharpExpressionConverter.ConvertToken(listlistSource);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/boards/{0}/closed", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Board>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Card> CreateCard(Expression<Func<string>> boardId, Expression<Func<string>> newCardparentListId, Expression<Func<string>> newCardcardName, Expression<Func<string>> newCardcardDescription = null, Expression<Func<newCardcardPositionInput>> newCardcardPosition = null, Expression<Func<string[]>> newCardmemberIds = null, Expression<Func<string[]>> newCardlabelIds = null, Expression<Func<string>> newCardsourceUrl = null, Expression<Func<string>> newCardsourceFile = null, Expression<Func<string>> newCardsourceCardId = null, Expression<Func<string>> newCardpropertiesFromSourceCard = null, Expression<Func<string>> newCarddueDate = null)
        {
            var apiCallPath = "/v2/cards";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["board_id"] = CSharpExpressionConverter.ConvertO(boardId);
            var newCard = new JObject();
            var newCardpropCount = 0;
            newCardpropCount++;
            newCard["idList"] = CSharpExpressionConverter.ConvertToken(newCardparentListId);
            newCardpropCount++;
            newCard["name"] = CSharpExpressionConverter.ConvertToken(newCardcardName);
            if (newCardcardDescription != null)
            {
                newCard["desc"] = CSharpExpressionConverter.ConvertToken(newCardcardDescription);
                newCardpropCount++;
            }

            if (newCardcardPosition != null)
            {
                newCard["pos"] = CSharpExpressionConverter.Convert(newCardcardPosition);
                newCardpropCount++;
            }

            if (newCardmemberIds != null)
            {
                newCard["idMembersArray"] = CSharpExpressionConverter.ConvertToken(newCardmemberIds);
                newCardpropCount++;
            }

            if (newCardlabelIds != null)
            {
                newCard["idLabelsArray"] = CSharpExpressionConverter.ConvertToken(newCardlabelIds);
                newCardpropCount++;
            }

            if (newCardsourceUrl != null)
            {
                if (newCardsourceUrl != null)
                {
                    newCard["urlSource"] = CSharpExpressionConverter.ConvertToken(newCardsourceUrl);
                    newCardpropCount++;
                }

                newCardpropCount++;
            }
            else
            {
                newCard["urlSource"] = "null";
                newCardpropCount++;
            }

            if (newCardsourceFile != null)
            {
                newCard["fileSource"] = CSharpExpressionConverter.ConvertToken(newCardsourceFile);
                newCardpropCount++;
            }

            if (newCardsourceCardId != null)
            {
                newCard["idCardSource"] = CSharpExpressionConverter.ConvertToken(newCardsourceCardId);
                newCardpropCount++;
            }

            if (newCardpropertiesFromSourceCard != null)
            {
                newCard["keepFromSource"] = CSharpExpressionConverter.ConvertToken(newCardpropertiesFromSourceCard);
                newCardpropCount++;
            }

            if (newCarddueDate != null)
            {
                newCard["due"] = CSharpExpressionConverter.ConvertToken(newCarddueDate);
                newCardpropCount++;
            }

            if (newCardpropCount > 0)
            {
                callPayload.Body = newCard;
            }

            return new ApiConnectionAction<Card>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Card> UpdateCard(Expression<Func<string>> boardId, Expression<Func<string>> cardId, Expression<Func<string>> updateCardname, Expression<Func<string>> updateCarddescription = null, Expression<Func<bool>> updateCardisClosed = null, Expression<Func<string[]>> updateCardmemberIds = null, Expression<Func<string>> updateCardcoverAttachmentIds = null, Expression<Func<string>> updateCardboardId = null, Expression<Func<string>> updateCardlistId = null, Expression<Func<string>> updateCardposition = null, Expression<Func<string>> updateCarddueDate = null, Expression<Func<bool>> updateCardsubscribedToCard = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/cards/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["board_id"] = CSharpExpressionConverter.ConvertO(boardId);
            var updateCard = new JObject();
            var updateCardpropCount = 0;
            updateCardpropCount++;
            updateCard["name"] = CSharpExpressionConverter.ConvertToken(updateCardname);
            if (updateCarddescription != null)
            {
                updateCard["desc"] = CSharpExpressionConverter.ConvertToken(updateCarddescription);
                updateCardpropCount++;
            }

            if (updateCardisClosed != null)
            {
                updateCard["closed"] = CSharpExpressionConverter.ConvertToken(updateCardisClosed);
                updateCardpropCount++;
            }

            if (updateCardmemberIds != null)
            {
                updateCard["idMembersArray"] = CSharpExpressionConverter.ConvertToken(updateCardmemberIds);
                updateCardpropCount++;
            }

            if (updateCardcoverAttachmentIds != null)
            {
                updateCard["idAttachmentCover"] = CSharpExpressionConverter.ConvertToken(updateCardcoverAttachmentIds);
                updateCardpropCount++;
            }

            if (updateCardboardId != null)
            {
                updateCard["idBoard"] = CSharpExpressionConverter.ConvertToken(updateCardboardId);
                updateCardpropCount++;
            }

            if (updateCardlistId != null)
            {
                updateCard["idList"] = CSharpExpressionConverter.ConvertToken(updateCardlistId);
                updateCardpropCount++;
            }

            if (updateCardposition != null)
            {
                updateCard["pos"] = CSharpExpressionConverter.ConvertToken(updateCardposition);
                updateCardpropCount++;
            }

            if (updateCarddueDate != null)
            {
                updateCard["due"] = CSharpExpressionConverter.ConvertToken(updateCarddueDate);
                updateCardpropCount++;
            }

            if (updateCardsubscribedToCard != null)
            {
                updateCard["subscribed"] = CSharpExpressionConverter.ConvertToken(updateCardsubscribedToCard);
                updateCardpropCount++;
            }

            if (updateCardpropCount > 0)
            {
                callPayload.Body = updateCard;
            }

            return new ApiConnectionAction<Card>(callPayload);
        }
    }

    public class TrelloTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CardInAction[]> OnNewCardInBoard(Expression<Func<string>> boardId, string triggerName = null)
        {
            var input = new ApiConnectionNotificationActionInput(connectionId);
            input.Fetch = new ApiConnectionNotificationRecurrenceActionInput()
            {
                Queries = new Dictionary<string, string>(),
                Headers = new Dictionary<string, string>(),
                PathTemplate = new PathTemplate
                {
                    Template = "/v3/trigger/boards/{0}/actions"
                },
                Method = "get",
            };
            input.Subscribe = new ApiConnectionNotificationWebhookActionInput()
            {
                Queries = new Dictionary<string, string>(),
                Headers = new Dictionary<string, string>(),
                PathTemplate = new PathTemplate
                {
                    Template = "/OnBoardChangesSubscription/{0}"
                },
                Method = "post",
            };
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            subscription["NotificationURL"] = "@listCallbackUrl()";
            subscriptionpropCount++;
            if (subscriptionpropCount > 0)
            {
                input.Subscribe.Body = subscription;
            }

            return new ApiConnectionTrigger<CardInAction[]>(input);
        }

        public IBodyWorkflowTrigger<CardInAction[]> OnNewCardInList(Expression<Func<string>> boardId, Expression<Func<string>> listId, string triggerName = null)
        {
            var input = new ApiConnectionNotificationActionInput(connectionId);
            input.Fetch = new ApiConnectionNotificationRecurrenceActionInput()
            {
                Queries = new Dictionary<string, string>(),
                Headers = new Dictionary<string, string>(),
                PathTemplate = new PathTemplate
                {
                    Template = "/v3/trigger/lists/{0}/actions"
                },
                Method = "get",
            };
            input.Fetch.Queries["board_id"] = CSharpExpressionConverter.ConvertO(boardId);
            input.Subscribe = new ApiConnectionNotificationWebhookActionInput()
            {
                Queries = new Dictionary<string, string>(),
                Headers = new Dictionary<string, string>(),
                PathTemplate = new PathTemplate
                {
                    Template = "/OnListChangesSubscription/{0}"
                },
                Method = "post",
            };
            input.Subscribe.Queries["board_id"] = CSharpExpressionConverter.ConvertO(boardId);
            var subscription = new JObject();
            var subscriptionpropCount = 0;
            subscription["NotificationURL"] = "@listCallbackUrl()";
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

    public enum newCardcardPositionInput
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