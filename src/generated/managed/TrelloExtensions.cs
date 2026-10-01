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
        public IBodyWorkflowAction<Card[]> ListCards([WorkflowExpression] Func<string> boardId, [WorkflowExpression] Func<string> actions = null, [WorkflowExpression] Func<bool> attachments = null, [WorkflowExpression] Func<string> attachmentFields = null, [WorkflowExpression] Func<bool> stickers = null, [WorkflowExpression] Func<bool> members = null, [WorkflowExpression] Func<string> memeberFields = null, [WorkflowExpression] Func<bool> checkItemStates = null, [WorkflowExpression] Func<checklistsInput> checklists = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> since = null, [WorkflowExpression] Func<string> before = null, [WorkflowExpression] Func<filterInput> filter = null, [WorkflowExpression] Func<string> fields = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/boards/{0}/cards", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (actions != null)
                    callPayload.Queries["actions"] = SourceExpressionConverter.ConvertO(actions);
                if (attachments != null)
                    callPayload.Queries["attachments"] = SourceExpressionConverter.ConvertO(attachments);
                if (attachmentFields != null)
                    callPayload.Queries["attachment_fields"] = SourceExpressionConverter.ConvertO(attachmentFields);
                if (stickers != null)
                    callPayload.Queries["stickers"] = SourceExpressionConverter.ConvertO(stickers);
                if (members != null)
                    callPayload.Queries["members"] = SourceExpressionConverter.ConvertO(members);
                if (memeberFields != null)
                    callPayload.Queries["memeber_fields"] = SourceExpressionConverter.ConvertO(memeberFields);
                if (checkItemStates != null)
                    callPayload.Queries["checkItemStates"] = SourceExpressionConverter.ConvertO(checkItemStates);
                if (checklists != null)
                    callPayload.Queries["checklists"] = SourceExpressionConverter.Convert(checklists);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (since != null)
                    callPayload.Queries["since"] = SourceExpressionConverter.ConvertO(since);
                if (before != null)
                    callPayload.Queries["before"] = SourceExpressionConverter.ConvertO(before);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.Convert(filter);
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                return callPayload;
            }

            return new ApiConnectionAction<Card[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Card[]> ListCardsSimple([WorkflowExpression] Func<string> boardId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/simple/boards/{0}/cards", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Card[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<CardWithChecklists> GetCard([WorkflowExpression] Func<string> boardId, [WorkflowExpression] Func<string> cardId, [WorkflowExpression] Func<string> actions = null, [WorkflowExpression] Func<bool> actionsEntities = null, [WorkflowExpression] Func<bool> actionsDisplay = null, [WorkflowExpression] Func<int> actionsLimit = null, [WorkflowExpression] Func<string> actionFields = null, [WorkflowExpression] Func<string> actionMemberCreatorFields = null, [WorkflowExpression] Func<bool> attachments = null, [WorkflowExpression] Func<string> attachmentFields = null, [WorkflowExpression] Func<bool> members = null, [WorkflowExpression] Func<string> memberFields = null, [WorkflowExpression] Func<bool> membersVoted = null, [WorkflowExpression] Func<string> memberVotedFields = null, [WorkflowExpression] Func<bool> checkItemStates = null, [WorkflowExpression] Func<string> checkItemStateFields = null, [WorkflowExpression] Func<checklistsInput> checklists = null, [WorkflowExpression] Func<string> checklistFields = null, [WorkflowExpression] Func<bool> board = null, [WorkflowExpression] Func<string> boardFields = null, [WorkflowExpression] Func<bool> list = null, [WorkflowExpression] Func<string> listFields = null, [WorkflowExpression] Func<bool> stickers = null, [WorkflowExpression] Func<string> stickerFields = null, [WorkflowExpression] Func<string> fields = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/cards/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = SourceExpressionConverter.ConvertO(boardId);
                if (actions != null)
                    callPayload.Queries["actions"] = SourceExpressionConverter.ConvertO(actions);
                if (actionsEntities != null)
                    callPayload.Queries["actions_entities"] = SourceExpressionConverter.ConvertO(actionsEntities);
                if (actionsDisplay != null)
                    callPayload.Queries["actions_display"] = SourceExpressionConverter.ConvertO(actionsDisplay);
                if (actionsLimit != null)
                    callPayload.Queries["actions_limit"] = SourceExpressionConverter.ConvertO(actionsLimit);
                if (actionFields != null)
                    callPayload.Queries["action_fields"] = SourceExpressionConverter.ConvertO(actionFields);
                if (actionMemberCreatorFields != null)
                    callPayload.Queries["action_memberCreator_fields"] = SourceExpressionConverter.ConvertO(actionMemberCreatorFields);
                if (attachments != null)
                    callPayload.Queries["attachments"] = SourceExpressionConverter.ConvertO(attachments);
                if (attachmentFields != null)
                    callPayload.Queries["attachment_fields"] = SourceExpressionConverter.ConvertO(attachmentFields);
                if (members != null)
                    callPayload.Queries["members"] = SourceExpressionConverter.ConvertO(members);
                if (memberFields != null)
                    callPayload.Queries["member_fields"] = SourceExpressionConverter.ConvertO(memberFields);
                if (membersVoted != null)
                    callPayload.Queries["membersVoted"] = SourceExpressionConverter.ConvertO(membersVoted);
                if (memberVotedFields != null)
                    callPayload.Queries["memberVoted_fields"] = SourceExpressionConverter.ConvertO(memberVotedFields);
                if (checkItemStates != null)
                    callPayload.Queries["checkItemStates"] = SourceExpressionConverter.ConvertO(checkItemStates);
                if (checkItemStateFields != null)
                    callPayload.Queries["checkItemState_fields"] = SourceExpressionConverter.ConvertO(checkItemStateFields);
                if (checklists != null)
                    callPayload.Queries["checklists"] = SourceExpressionConverter.Convert(checklists);
                if (checklistFields != null)
                    callPayload.Queries["checklist_fields"] = SourceExpressionConverter.ConvertO(checklistFields);
                if (board != null)
                    callPayload.Queries["board"] = SourceExpressionConverter.ConvertO(board);
                if (boardFields != null)
                    callPayload.Queries["board_fields"] = SourceExpressionConverter.ConvertO(boardFields);
                if (list != null)
                    callPayload.Queries["list"] = SourceExpressionConverter.ConvertO(list);
                if (listFields != null)
                    callPayload.Queries["list_fields"] = SourceExpressionConverter.ConvertO(listFields);
                if (stickers != null)
                    callPayload.Queries["stickers"] = SourceExpressionConverter.ConvertO(stickers);
                if (stickerFields != null)
                    callPayload.Queries["sticker_fields"] = SourceExpressionConverter.ConvertO(stickerFields);
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                return callPayload;
            }

            return new ApiConnectionAction<CardWithChecklists>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<JToken> DeleteCard([WorkflowExpression] Func<string> boardId, [WorkflowExpression] Func<string> cardId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/cards/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = SourceExpressionConverter.ConvertO(boardId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Board[]> ListBoards([WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> actions = null, [WorkflowExpression] Func<bool> actionsEntities = null, [WorkflowExpression] Func<int> actionsLimit = null, [WorkflowExpression] Func<actionsFormatInput> actionsFormat = null, [WorkflowExpression] Func<string> actionsSince = null, [WorkflowExpression] Func<string> actionFields = null, [WorkflowExpression] Func<string> memberships = null, [WorkflowExpression] Func<bool> organization = null, [WorkflowExpression] Func<string> organizationFields = null, [WorkflowExpression] Func<string> lists = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/member/me/boards";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                if (actions != null)
                    callPayload.Queries["actions"] = SourceExpressionConverter.ConvertO(actions);
                if (actionsEntities != null)
                    callPayload.Queries["actions_entities"] = SourceExpressionConverter.ConvertO(actionsEntities);
                if (actionsLimit != null)
                    callPayload.Queries["actions_limit"] = SourceExpressionConverter.ConvertO(actionsLimit);
                if (actionsFormat != null)
                    callPayload.Queries["actions_format"] = SourceExpressionConverter.Convert(actionsFormat);
                if (actionsSince != null)
                    callPayload.Queries["actions_since"] = SourceExpressionConverter.ConvertO(actionsSince);
                if (actionFields != null)
                    callPayload.Queries["action_fields"] = SourceExpressionConverter.ConvertO(actionFields);
                if (memberships != null)
                    callPayload.Queries["memberships"] = SourceExpressionConverter.ConvertO(memberships);
                if (organization != null)
                    callPayload.Queries["organization"] = SourceExpressionConverter.ConvertO(organization);
                if (organizationFields != null)
                    callPayload.Queries["organization_fields"] = SourceExpressionConverter.ConvertO(organizationFields);
                if (lists != null)
                    callPayload.Queries["lists"] = SourceExpressionConverter.ConvertO(lists);
                return callPayload;
            }

            return new ApiConnectionAction<Board[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Board[]> ListBoardsSimple()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/simple/member/me/boards";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Board[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<BoardWithChecklists> GetBoard([WorkflowExpression] Func<string> boardId, [WorkflowExpression] Func<string> actions = null, [WorkflowExpression] Func<bool> actionEntities = null, [WorkflowExpression] Func<bool> actionsDisplay = null, [WorkflowExpression] Func<actionsFormatInput> actionsFormat = null, [WorkflowExpression] Func<string> actionsSince = null, [WorkflowExpression] Func<int> actionsLimit = null, [WorkflowExpression] Func<string> actionFields = null, [WorkflowExpression] Func<bool> actionMember = null, [WorkflowExpression] Func<string> actionMemberFields = null, [WorkflowExpression] Func<bool> actionMemberCreator = null, [WorkflowExpression] Func<string> actionMemberCreatorFields = null, [WorkflowExpression] Func<cardsInput> cards = null, [WorkflowExpression] Func<string> cardFields = null, [WorkflowExpression] Func<bool> cardAttachments = null, [WorkflowExpression] Func<string> cardAttachmentFields = null, [WorkflowExpression] Func<cardChecklistsInput> cardChecklists = null, [WorkflowExpression] Func<bool> cardStickers = null, [WorkflowExpression] Func<boardStarsInput> boardStars = null, [WorkflowExpression] Func<labelsInput> labels = null, [WorkflowExpression] Func<string> labelFields = null, [WorkflowExpression] Func<int> labelsLimit = null, [WorkflowExpression] Func<listsInput> lists = null, [WorkflowExpression] Func<string> listFields = null, [WorkflowExpression] Func<string> memberships = null, [WorkflowExpression] Func<bool> membershipsMember = null, [WorkflowExpression] Func<string> membershipsMemberFields = null, [WorkflowExpression] Func<membersInput> members = null, [WorkflowExpression] Func<string> memberFields = null, [WorkflowExpression] Func<membersInvitedInput> membersInvited = null, [WorkflowExpression] Func<string> membersInvitedFields = null, [WorkflowExpression] Func<checklistsInput> checklists = null, [WorkflowExpression] Func<string> checklistFields = null, [WorkflowExpression] Func<bool> organization = null, [WorkflowExpression] Func<string> organizationFields = null, [WorkflowExpression] Func<string> organizationMemberships = null, [WorkflowExpression] Func<bool> myPerfs = null, [WorkflowExpression] Func<string> fields = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/boards/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (actions != null)
                    callPayload.Queries["actions"] = SourceExpressionConverter.ConvertO(actions);
                if (actionEntities != null)
                    callPayload.Queries["action_entities"] = SourceExpressionConverter.ConvertO(actionEntities);
                if (actionsDisplay != null)
                    callPayload.Queries["actions_display"] = SourceExpressionConverter.ConvertO(actionsDisplay);
                if (actionsFormat != null)
                    callPayload.Queries["actions_format"] = SourceExpressionConverter.Convert(actionsFormat);
                if (actionsSince != null)
                    callPayload.Queries["actions_since"] = SourceExpressionConverter.ConvertO(actionsSince);
                if (actionsLimit != null)
                    callPayload.Queries["actions_limit"] = SourceExpressionConverter.ConvertO(actionsLimit);
                if (actionFields != null)
                    callPayload.Queries["action_fields"] = SourceExpressionConverter.ConvertO(actionFields);
                if (actionMember != null)
                    callPayload.Queries["action_member"] = SourceExpressionConverter.ConvertO(actionMember);
                if (actionMemberFields != null)
                    callPayload.Queries["action_member_fields"] = SourceExpressionConverter.ConvertO(actionMemberFields);
                if (actionMemberCreator != null)
                    callPayload.Queries["action_memberCreator"] = SourceExpressionConverter.ConvertO(actionMemberCreator);
                if (actionMemberCreatorFields != null)
                    callPayload.Queries["action_memberCreator_fields"] = SourceExpressionConverter.ConvertO(actionMemberCreatorFields);
                if (cards != null)
                    callPayload.Queries["cards"] = SourceExpressionConverter.Convert(cards);
                if (cardFields != null)
                    callPayload.Queries["card_fields"] = SourceExpressionConverter.ConvertO(cardFields);
                if (cardAttachments != null)
                    callPayload.Queries["card_attachments"] = SourceExpressionConverter.ConvertO(cardAttachments);
                if (cardAttachmentFields != null)
                    callPayload.Queries["card_attachment_fields"] = SourceExpressionConverter.ConvertO(cardAttachmentFields);
                if (cardChecklists != null)
                    callPayload.Queries["card_checklists"] = SourceExpressionConverter.Convert(cardChecklists);
                if (cardStickers != null)
                    callPayload.Queries["card_stickers"] = SourceExpressionConverter.ConvertO(cardStickers);
                if (boardStars != null)
                    callPayload.Queries["boardStars"] = SourceExpressionConverter.Convert(boardStars);
                if (labels != null)
                    callPayload.Queries["labels"] = SourceExpressionConverter.Convert(labels);
                if (labelFields != null)
                    callPayload.Queries["label_fields"] = SourceExpressionConverter.ConvertO(labelFields);
                if (labelsLimit != null)
                    callPayload.Queries["labels_limit"] = SourceExpressionConverter.ConvertO(labelsLimit);
                if (lists != null)
                    callPayload.Queries["lists"] = SourceExpressionConverter.Convert(lists);
                if (listFields != null)
                    callPayload.Queries["list_fields"] = SourceExpressionConverter.ConvertO(listFields);
                if (memberships != null)
                    callPayload.Queries["memberships"] = SourceExpressionConverter.ConvertO(memberships);
                if (membershipsMember != null)
                    callPayload.Queries["memberships_member"] = SourceExpressionConverter.ConvertO(membershipsMember);
                if (membershipsMemberFields != null)
                    callPayload.Queries["memberships_member_fields"] = SourceExpressionConverter.ConvertO(membershipsMemberFields);
                if (members != null)
                    callPayload.Queries["members"] = SourceExpressionConverter.Convert(members);
                if (memberFields != null)
                    callPayload.Queries["member_fields"] = SourceExpressionConverter.ConvertO(memberFields);
                if (membersInvited != null)
                    callPayload.Queries["membersInvited"] = SourceExpressionConverter.Convert(membersInvited);
                if (membersInvitedFields != null)
                    callPayload.Queries["membersInvited_fields"] = SourceExpressionConverter.ConvertO(membersInvitedFields);
                if (checklists != null)
                    callPayload.Queries["checklists"] = SourceExpressionConverter.Convert(checklists);
                if (checklistFields != null)
                    callPayload.Queries["checklist_fields"] = SourceExpressionConverter.ConvertO(checklistFields);
                if (organization != null)
                    callPayload.Queries["organization"] = SourceExpressionConverter.ConvertO(organization);
                if (organizationFields != null)
                    callPayload.Queries["organization_fields"] = SourceExpressionConverter.ConvertO(organizationFields);
                if (organizationMemberships != null)
                    callPayload.Queries["organization_memberships"] = SourceExpressionConverter.ConvertO(organizationMemberships);
                if (myPerfs != null)
                    callPayload.Queries["myPerfs"] = SourceExpressionConverter.ConvertO(myPerfs);
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                return callPayload;
            }

            return new ApiConnectionAction<BoardWithChecklists>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Board> UpdateBoard([WorkflowExpression] Func<string> boardId, [WorkflowExpression] Func<string> boardboardName = null, [WorkflowExpression] Func<boardcreateDefaultListsInput> boardcreateDefaultLists = null, [WorkflowExpression] Func<string> boardboardDescription = null, [WorkflowExpression] Func<string> boardteamId = null, [WorkflowExpression] Func<boardpermissionLevelInput> boardpermissionLevel = null, [WorkflowExpression] Func<boardcommentPreferencesInput> boardcommentPreferences = null, [WorkflowExpression] Func<boardinvitationPreferencesInput> boardinvitationPreferences = null, [WorkflowExpression] Func<boarduseCardCoversInput> boarduseCardCovers = null, [WorkflowExpression] Func<boardbackgroundColorInput> boardbackgroundColor = null, [WorkflowExpression] Func<boardvotingPowerUpPreferencesInput> boardvotingPowerUpPreferences = null, [WorkflowExpression] Func<boardcardAgingPowerUpPreferencesInput> boardcardAgingPowerUpPreferences = null, [WorkflowExpression] Func<boardenableCalendarPowerUpInput> boardenableCalendarPowerUp = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/boards/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var board = new JObject();
                var boardpropCount = 0;
                if (boardboardName != null)
                {
                    board["name"] = SourceExpressionConverter.ConvertToken(boardboardName);
                    boardpropCount++;
                }

                if (boardcreateDefaultLists != null)
                {
                    board["defaultLists"] = SourceExpressionConverter.Convert(boardcreateDefaultLists);
                    boardpropCount++;
                }

                if (boardboardDescription != null)
                {
                    board["desc"] = SourceExpressionConverter.ConvertToken(boardboardDescription);
                    boardpropCount++;
                }

                if (boardteamId != null)
                {
                    board["idOrganization"] = SourceExpressionConverter.ConvertToken(boardteamId);
                    boardpropCount++;
                }

                if (boardpermissionLevel != null)
                {
                    board["prefs_permissionLevel"] = SourceExpressionConverter.Convert(boardpermissionLevel);
                    boardpropCount++;
                }

                if (boardcommentPreferences != null)
                {
                    board["prefs_comments"] = SourceExpressionConverter.Convert(boardcommentPreferences);
                    boardpropCount++;
                }

                if (boardinvitationPreferences != null)
                {
                    board["prefs_invitations"] = SourceExpressionConverter.Convert(boardinvitationPreferences);
                    boardpropCount++;
                }

                if (boarduseCardCovers != null)
                {
                    board["prefs_cardCovers"] = SourceExpressionConverter.Convert(boarduseCardCovers);
                    boardpropCount++;
                }

                if (boardbackgroundColor != null)
                {
                    board["prefs_background"] = SourceExpressionConverter.Convert(boardbackgroundColor);
                    boardpropCount++;
                }

                if (boardvotingPowerUpPreferences != null)
                {
                    board["prefs_voting"] = SourceExpressionConverter.Convert(boardvotingPowerUpPreferences);
                    boardpropCount++;
                }

                if (boardcardAgingPowerUpPreferences != null)
                {
                    board["prefs_cardAging"] = SourceExpressionConverter.Convert(boardcardAgingPowerUpPreferences);
                    boardpropCount++;
                }

                if (boardenableCalendarPowerUp != null)
                {
                    board["enable_calendar"] = SourceExpressionConverter.Convert(boardenableCalendarPowerUp);
                    boardpropCount++;
                }

                if (boardpropCount > 0)
                {
                    callPayload.Body = board;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Board>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<List[]> ListLists([WorkflowExpression] Func<string> boardId, [WorkflowExpression] Func<cardsInput> cards = null, [WorkflowExpression] Func<string> cardFields = null, [WorkflowExpression] Func<filterInput> filter = null, [WorkflowExpression] Func<string> fields = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/boards/{0}/lists", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (cards != null)
                    callPayload.Queries["cards"] = SourceExpressionConverter.Convert(cards);
                if (cardFields != null)
                    callPayload.Queries["card_fields"] = SourceExpressionConverter.ConvertO(cardFields);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.Convert(filter);
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                return callPayload;
            }

            return new ApiConnectionAction<List[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<List[]> ListListsSimple([WorkflowExpression] Func<string> boardId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/simple/boards/{0}/lists", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<List[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<List> GetList([WorkflowExpression] Func<string> boardId, [WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<cardsInput> cards = null, [WorkflowExpression] Func<string> cardFields = null, [WorkflowExpression] Func<bool> board = null, [WorkflowExpression] Func<string> boardFields = null, [WorkflowExpression] Func<string> fields = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = SourceExpressionConverter.ConvertO(boardId);
                if (cards != null)
                    callPayload.Queries["cards"] = SourceExpressionConverter.Convert(cards);
                if (cardFields != null)
                    callPayload.Queries["card_fields"] = SourceExpressionConverter.ConvertO(cardFields);
                if (board != null)
                    callPayload.Queries["board"] = SourceExpressionConverter.ConvertO(board);
                if (boardFields != null)
                    callPayload.Queries["board_fields"] = SourceExpressionConverter.ConvertO(boardFields);
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                return callPayload;
            }

            return new ApiConnectionAction<List>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<CreateListResponse> UpdateList([WorkflowExpression] Func<string> boardId, [WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<closedInput> closed = null, [WorkflowExpression] Func<string> idBoard = null, [WorkflowExpression] Func<posInput> pos = null, [WorkflowExpression] Func<subscribedInput> subscribed = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = SourceExpressionConverter.ConvertO(boardId);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (closed != null)
                    callPayload.Queries["closed"] = SourceExpressionConverter.Convert(closed);
                if (idBoard != null)
                    callPayload.Queries["idBoard"] = SourceExpressionConverter.ConvertO(idBoard);
                if (pos != null)
                    callPayload.Queries["pos"] = SourceExpressionConverter.Convert(pos);
                if (subscribed != null)
                    callPayload.Queries["subscribed"] = SourceExpressionConverter.Convert(subscribed);
                return callPayload;
            }

            return new ApiConnectionAction<CreateListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<JToken> GetUserProfile([WorkflowExpression] Func<string> fields = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/members/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Team[]> ListTeams()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/members/me/organizations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Team[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Member[]> ListTeamMembers([WorkflowExpression] Func<string> teamId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/organizations/{0}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Member[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Member[]> ListBoardMembers([WorkflowExpression] Func<string> boardId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/boards/{0}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Member[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<BoardLabel[]> ListBoardLabels([WorkflowExpression] Func<string> boardId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/boards/{0}/labels", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                return callPayload;
            }

            return new ApiConnectionAction<BoardLabel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Team> GetTeamForBoard([WorkflowExpression] Func<string> boardId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/boards/{0}/organization", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Team>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Member[]> ListCardMembers([WorkflowExpression] Func<string> boardId, [WorkflowExpression] Func<string> cardId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/cards/{0}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = SourceExpressionConverter.ConvertO(boardId);
                return callPayload;
            }

            return new ApiConnectionAction<Member[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Comment[]> ListCardComments([WorkflowExpression] Func<string> boardId, [WorkflowExpression] Func<string> cardId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/cards/{0}/actions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = SourceExpressionConverter.ConvertO(boardId);
                return callPayload;
            }

            return new ApiConnectionAction<Comment[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Comment> AddCommentToCard([WorkflowExpression] Func<string> boardId, [WorkflowExpression] Func<string> cardId, [WorkflowExpression] Func<string> commentcommentText = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/cards/{0}/actions/comments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = SourceExpressionConverter.ConvertO(boardId);
                var comment = new JObject();
                var commentpropCount = 0;
                if (commentcommentText != null)
                {
                    comment["text"] = SourceExpressionConverter.ConvertToken(commentcommentText);
                    commentpropCount++;
                }

                if (commentpropCount > 0)
                {
                    callPayload.Body = comment;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Comment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Member[]> AddMemberToCard([WorkflowExpression] Func<string> boardId, [WorkflowExpression] Func<string> cardId, [WorkflowExpression] Func<string> memberId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/cards/{0}/idMembers", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = SourceExpressionConverter.ConvertO(boardId);
                callPayload.Queries["memberId"] = SourceExpressionConverter.ConvertO(memberId);
                return callPayload;
            }

            return new ApiConnectionAction<Member[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Board> CreateBoard([WorkflowExpression] Func<string> boardboardName, [WorkflowExpression] Func<boardcreateDefaultListsInput> boardcreateDefaultLists = null, [WorkflowExpression] Func<string> boardboardDescription = null, [WorkflowExpression] Func<string> boardteamId = null, [WorkflowExpression] Func<boardpermissionLevelInput> boardpermissionLevel = null, [WorkflowExpression] Func<boardcommentPreferencesInput> boardcommentPreferences = null, [WorkflowExpression] Func<boardinvitationPreferencesInput> boardinvitationPreferences = null, [WorkflowExpression] Func<boarduseCardCoversInput> boarduseCardCovers = null, [WorkflowExpression] Func<boardbackgroundColorInput> boardbackgroundColor = null, [WorkflowExpression] Func<boardvotingPowerUpPreferencesInput> boardvotingPowerUpPreferences = null, [WorkflowExpression] Func<boardcardAgingPowerUpPreferencesInput> boardcardAgingPowerUpPreferences = null, [WorkflowExpression] Func<boardenableCalendarPowerUpInput> boardenableCalendarPowerUp = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/boards";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var board = new JObject();
                var boardpropCount = 0;
                boardpropCount++;
                board["name"] = SourceExpressionConverter.ConvertToken(boardboardName);
                if (boardcreateDefaultLists != null)
                {
                    board["defaultLists"] = SourceExpressionConverter.Convert(boardcreateDefaultLists);
                    boardpropCount++;
                }

                if (boardboardDescription != null)
                {
                    board["desc"] = SourceExpressionConverter.ConvertToken(boardboardDescription);
                    boardpropCount++;
                }

                if (boardteamId != null)
                {
                    board["idOrganization"] = SourceExpressionConverter.ConvertToken(boardteamId);
                    boardpropCount++;
                }

                if (boardpermissionLevel != null)
                {
                    board["prefs_permissionLevel"] = SourceExpressionConverter.Convert(boardpermissionLevel);
                    boardpropCount++;
                }

                if (boardcommentPreferences != null)
                {
                    board["prefs_comments"] = SourceExpressionConverter.Convert(boardcommentPreferences);
                    boardpropCount++;
                }

                if (boardinvitationPreferences != null)
                {
                    board["prefs_invitations"] = SourceExpressionConverter.Convert(boardinvitationPreferences);
                    boardpropCount++;
                }

                if (boarduseCardCovers != null)
                {
                    board["prefs_cardCovers"] = SourceExpressionConverter.Convert(boarduseCardCovers);
                    boardpropCount++;
                }

                if (boardbackgroundColor != null)
                {
                    board["prefs_background"] = SourceExpressionConverter.Convert(boardbackgroundColor);
                    boardpropCount++;
                }

                if (boardvotingPowerUpPreferences != null)
                {
                    board["prefs_voting"] = SourceExpressionConverter.Convert(boardvotingPowerUpPreferences);
                    boardpropCount++;
                }

                if (boardcardAgingPowerUpPreferences != null)
                {
                    board["prefs_cardAging"] = SourceExpressionConverter.Convert(boardcardAgingPowerUpPreferences);
                    boardpropCount++;
                }

                if (boardenableCalendarPowerUp != null)
                {
                    board["enable_calendar"] = SourceExpressionConverter.Convert(boardenableCalendarPowerUp);
                    boardpropCount++;
                }

                if (boardpropCount > 0)
                {
                    callPayload.Body = board;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Board>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<CreateListResponse> CreateList([WorkflowExpression] Func<string> listlistName, [WorkflowExpression] Func<string> listboardId, [WorkflowExpression] Func<listlistPositionInput> listlistPosition = null, [WorkflowExpression] Func<string> listlistSource = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var list = new JObject();
                var listpropCount = 0;
                listpropCount++;
                list["name"] = SourceExpressionConverter.ConvertToken(listlistName);
                listpropCount++;
                list["idBoard"] = SourceExpressionConverter.ConvertToken(listboardId);
                if (listlistPosition != null)
                {
                    list["pos"] = SourceExpressionConverter.Convert(listlistPosition);
                    listpropCount++;
                }

                if (listlistSource != null)
                {
                    list["idListSource"] = SourceExpressionConverter.ConvertToken(listlistSource);
                    listpropCount++;
                }

                if (listpropCount > 0)
                {
                    callPayload.Body = list;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Board> CloseBoard([WorkflowExpression] Func<string> boardId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/boards/{0}/closed", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(boardId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Board>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Card> CreateCard([WorkflowExpression] Func<string> boardId, [WorkflowExpression] Func<string> newCardparentListId, [WorkflowExpression] Func<string> newCardcardName, [WorkflowExpression] Func<string> newCardcardDescription = null, [WorkflowExpression] Func<newCardcardPositionInput> newCardcardPosition = null, [WorkflowExpression] Func<string[]> newCardmemberIds = null, [WorkflowExpression] Func<string[]> newCardlabelIds = null, [WorkflowExpression] Func<string> newCardsourceUrl = null, [WorkflowExpression] Func<string> newCardsourceFile = null, [WorkflowExpression] Func<string> newCardsourceCardId = null, [WorkflowExpression] Func<string> newCardpropertiesFromSourceCard = null, [WorkflowExpression] Func<string> newCarddueDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/cards";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = SourceExpressionConverter.ConvertO(boardId);
                var newCard = new JObject();
                var newCardpropCount = 0;
                newCardpropCount++;
                newCard["idList"] = SourceExpressionConverter.ConvertToken(newCardparentListId);
                newCardpropCount++;
                newCard["name"] = SourceExpressionConverter.ConvertToken(newCardcardName);
                if (newCardcardDescription != null)
                {
                    newCard["desc"] = SourceExpressionConverter.ConvertToken(newCardcardDescription);
                    newCardpropCount++;
                }

                if (newCardcardPosition != null)
                {
                    newCard["pos"] = SourceExpressionConverter.Convert(newCardcardPosition);
                    newCardpropCount++;
                }

                if (newCardmemberIds != null)
                {
                    newCard["idMembersArray"] = SourceExpressionConverter.ConvertToken(newCardmemberIds);
                    newCardpropCount++;
                }

                if (newCardlabelIds != null)
                {
                    newCard["idLabelsArray"] = SourceExpressionConverter.ConvertToken(newCardlabelIds);
                    newCardpropCount++;
                }

                if (newCardsourceUrl != null)
                {
                    if (newCardsourceUrl != null)
                    {
                        newCard["urlSource"] = SourceExpressionConverter.ConvertToken(newCardsourceUrl);
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
                    newCard["fileSource"] = SourceExpressionConverter.ConvertToken(newCardsourceFile);
                    newCardpropCount++;
                }

                if (newCardsourceCardId != null)
                {
                    newCard["idCardSource"] = SourceExpressionConverter.ConvertToken(newCardsourceCardId);
                    newCardpropCount++;
                }

                if (newCardpropertiesFromSourceCard != null)
                {
                    newCard["keepFromSource"] = SourceExpressionConverter.ConvertToken(newCardpropertiesFromSourceCard);
                    newCardpropCount++;
                }

                if (newCarddueDate != null)
                {
                    newCard["due"] = SourceExpressionConverter.ConvertToken(newCarddueDate);
                    newCardpropCount++;
                }

                if (newCardpropCount > 0)
                {
                    callPayload.Body = newCard;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Card>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Card> UpdateCard([WorkflowExpression] Func<string> boardId, [WorkflowExpression] Func<string> cardId, [WorkflowExpression] Func<string> updateCardname, [WorkflowExpression] Func<string> updateCarddescription = null, [WorkflowExpression] Func<bool> updateCardisClosed = null, [WorkflowExpression] Func<string[]> updateCardmemberIds = null, [WorkflowExpression] Func<string> updateCardcoverAttachmentIds = null, [WorkflowExpression] Func<string> updateCardboardId = null, [WorkflowExpression] Func<string> updateCardlistId = null, [WorkflowExpression] Func<string> updateCardposition = null, [WorkflowExpression] Func<string> updateCarddueDate = null, [WorkflowExpression] Func<bool> updateCardsubscribedToCard = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/cards/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = SourceExpressionConverter.ConvertO(boardId);
                var updateCard = new JObject();
                var updateCardpropCount = 0;
                updateCardpropCount++;
                updateCard["name"] = SourceExpressionConverter.ConvertToken(updateCardname);
                if (updateCarddescription != null)
                {
                    updateCard["desc"] = SourceExpressionConverter.ConvertToken(updateCarddescription);
                    updateCardpropCount++;
                }

                if (updateCardisClosed != null)
                {
                    updateCard["closed"] = SourceExpressionConverter.ConvertToken(updateCardisClosed);
                    updateCardpropCount++;
                }

                if (updateCardmemberIds != null)
                {
                    updateCard["idMembersArray"] = SourceExpressionConverter.ConvertToken(updateCardmemberIds);
                    updateCardpropCount++;
                }

                if (updateCardcoverAttachmentIds != null)
                {
                    updateCard["idAttachmentCover"] = SourceExpressionConverter.ConvertToken(updateCardcoverAttachmentIds);
                    updateCardpropCount++;
                }

                if (updateCardboardId != null)
                {
                    updateCard["idBoard"] = SourceExpressionConverter.ConvertToken(updateCardboardId);
                    updateCardpropCount++;
                }

                if (updateCardlistId != null)
                {
                    updateCard["idList"] = SourceExpressionConverter.ConvertToken(updateCardlistId);
                    updateCardpropCount++;
                }

                if (updateCardposition != null)
                {
                    updateCard["pos"] = SourceExpressionConverter.ConvertToken(updateCardposition);
                    updateCardpropCount++;
                }

                if (updateCarddueDate != null)
                {
                    updateCard["due"] = SourceExpressionConverter.ConvertToken(updateCarddueDate);
                    updateCardpropCount++;
                }

                if (updateCardsubscribedToCard != null)
                {
                    updateCard["subscribed"] = SourceExpressionConverter.ConvertToken(updateCardsubscribedToCard);
                    updateCardpropCount++;
                }

                if (updateCardpropCount > 0)
                {
                    callPayload.Body = updateCard;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Card>(BuildSourceInput);
        }
    }

    public class TrelloTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CardInAction[]> OnNewCardInBoard([WorkflowExpression] Func<string> boardId, string triggerName = null)
        {
            ApiConnectionNotificationActionInput BuildSourceInput()
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
                subscription["NotificationURL"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    input.Subscribe.Body = subscription;
                }
                return input;
            }

            return new ApiConnectionTrigger<CardInAction[]>(BuildSourceInput);
        }

        public IBodyWorkflowTrigger<CardInAction[]> OnNewCardInList([WorkflowExpression] Func<string> boardId, [WorkflowExpression] Func<string> listId, string triggerName = null)
        {
            ApiConnectionNotificationActionInput BuildSourceInput()
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
                input.Fetch.Queries["board_id"] = SourceExpressionConverter.ConvertO(boardId);
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
                input.Subscribe.Queries["board_id"] = SourceExpressionConverter.ConvertO(boardId);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscription["NotificationURL"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    input.Subscribe.Body = subscription;
                }
                return input;
            }

            return new ApiConnectionTrigger<CardInAction[]>(BuildSourceInput);
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