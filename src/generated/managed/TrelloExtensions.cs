//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Trello
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class TrelloActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Card[]> ListCards(Expression<Func<string>> boardId, Expression<Func<string>> actions = null, Expression<Func<bool>> attachments = null, Expression<Func<string>> attachmentFields = null, Expression<Func<bool>> stickers = null, Expression<Func<bool>> members = null, Expression<Func<string>> memeberFields = null, Expression<Func<bool>> checkItemStates = null, Expression<Func<checklistsInput>> checklists = null, Expression<Func<int>> limit = null, Expression<Func<string>> since = null, Expression<Func<string>> before = null, Expression<Func<filterInput>> filter = null, Expression<Func<string>> fields = null)
        {
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            var __workflow_actions = actions == null ? null : WorkflowExpression.Compile(actions);
            WorkflowExpression.Validate(__workflow_actions, nameof(actions), required: false);
            var __workflow_attachments = attachments == null ? null : WorkflowExpression.Compile(attachments);
            WorkflowExpression.Validate(__workflow_attachments, nameof(attachments), required: false);
            var __workflow_attachmentFields = attachmentFields == null ? null : WorkflowExpression.Compile(attachmentFields);
            WorkflowExpression.Validate(__workflow_attachmentFields, nameof(attachmentFields), required: false);
            var __workflow_stickers = stickers == null ? null : WorkflowExpression.Compile(stickers);
            WorkflowExpression.Validate(__workflow_stickers, nameof(stickers), required: false);
            var __workflow_members = members == null ? null : WorkflowExpression.Compile(members);
            WorkflowExpression.Validate(__workflow_members, nameof(members), required: false);
            var __workflow_memeberFields = memeberFields == null ? null : WorkflowExpression.Compile(memeberFields);
            WorkflowExpression.Validate(__workflow_memeberFields, nameof(memeberFields), required: false);
            var __workflow_checkItemStates = checkItemStates == null ? null : WorkflowExpression.Compile(checkItemStates);
            WorkflowExpression.Validate(__workflow_checkItemStates, nameof(checkItemStates), required: false);
            var __workflow_checklists = checklists == null ? null : WorkflowExpression.Compile(checklists);
            WorkflowExpression.Validate(__workflow_checklists, nameof(checklists), required: false);
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            var __workflow_since = since == null ? null : WorkflowExpression.Compile(since);
            WorkflowExpression.Validate(__workflow_since, nameof(since), required: false);
            var __workflow_before = before == null ? null : WorkflowExpression.Compile(before);
            WorkflowExpression.Validate(__workflow_before, nameof(before), required: false);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_fields = fields == null ? null : WorkflowExpression.Compile(fields);
            WorkflowExpression.Validate(__workflow_fields, nameof(fields), required: false);
            return new DeferredBodyAction<Card[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/boards/{0}/cards", ExpressionConverter.ConvertWithUrlEncoding(__workflow_boardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_actions != null)
                    callPayload.Queries["actions"] = ExpressionConverter.Convert(__workflow_actions);
                if (__workflow_attachments != null)
                    callPayload.Queries["attachments"] = ExpressionConverter.Convert(__workflow_attachments);
                if (__workflow_attachmentFields != null)
                    callPayload.Queries["attachment_fields"] = ExpressionConverter.Convert(__workflow_attachmentFields);
                if (__workflow_stickers != null)
                    callPayload.Queries["stickers"] = ExpressionConverter.Convert(__workflow_stickers);
                if (__workflow_members != null)
                    callPayload.Queries["members"] = ExpressionConverter.Convert(__workflow_members);
                if (__workflow_memeberFields != null)
                    callPayload.Queries["memeber_fields"] = ExpressionConverter.Convert(__workflow_memeberFields);
                if (__workflow_checkItemStates != null)
                    callPayload.Queries["checkItemStates"] = ExpressionConverter.Convert(__workflow_checkItemStates);
                if (__workflow_checklists != null)
                    callPayload.Queries["checklists"] = ExpressionConverter.Convert(__workflow_checklists);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_since != null)
                    callPayload.Queries["since"] = ExpressionConverter.Convert(__workflow_since);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction<Card[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Card[]> ListCardsSimple(Expression<Func<string>> boardId)
        {
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            return new DeferredBodyAction<Card[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/simple/boards/{0}/cards", ExpressionConverter.ConvertWithUrlEncoding(__workflow_boardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Card[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<CardWithChecklists> GetCard(Expression<Func<string>> boardId, Expression<Func<string>> cardId, Expression<Func<string>> actions = null, Expression<Func<bool>> actionsEntities = null, Expression<Func<bool>> actionsDisplay = null, Expression<Func<int>> actionsLimit = null, Expression<Func<string>> actionFields = null, Expression<Func<string>> actionMemberCreatorFields = null, Expression<Func<bool>> attachments = null, Expression<Func<string>> attachmentFields = null, Expression<Func<bool>> members = null, Expression<Func<string>> memberFields = null, Expression<Func<bool>> membersVoted = null, Expression<Func<string>> memberVotedFields = null, Expression<Func<bool>> checkItemStates = null, Expression<Func<string>> checkItemStateFields = null, Expression<Func<checklistsInput>> checklists = null, Expression<Func<string>> checklistFields = null, Expression<Func<bool>> board = null, Expression<Func<string>> boardFields = null, Expression<Func<bool>> list = null, Expression<Func<string>> listFields = null, Expression<Func<bool>> stickers = null, Expression<Func<string>> stickerFields = null, Expression<Func<string>> fields = null)
        {
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            var __workflow_cardId = cardId == null ? null : WorkflowExpression.Compile(cardId);
            WorkflowExpression.Validate(__workflow_cardId, nameof(cardId), required: true);
            var __workflow_actions = actions == null ? null : WorkflowExpression.Compile(actions);
            WorkflowExpression.Validate(__workflow_actions, nameof(actions), required: false);
            var __workflow_actionsEntities = actionsEntities == null ? null : WorkflowExpression.Compile(actionsEntities);
            WorkflowExpression.Validate(__workflow_actionsEntities, nameof(actionsEntities), required: false);
            var __workflow_actionsDisplay = actionsDisplay == null ? null : WorkflowExpression.Compile(actionsDisplay);
            WorkflowExpression.Validate(__workflow_actionsDisplay, nameof(actionsDisplay), required: false);
            var __workflow_actionsLimit = actionsLimit == null ? null : WorkflowExpression.Compile(actionsLimit);
            WorkflowExpression.Validate(__workflow_actionsLimit, nameof(actionsLimit), required: false);
            var __workflow_actionFields = actionFields == null ? null : WorkflowExpression.Compile(actionFields);
            WorkflowExpression.Validate(__workflow_actionFields, nameof(actionFields), required: false);
            var __workflow_actionMemberCreatorFields = actionMemberCreatorFields == null ? null : WorkflowExpression.Compile(actionMemberCreatorFields);
            WorkflowExpression.Validate(__workflow_actionMemberCreatorFields, nameof(actionMemberCreatorFields), required: false);
            var __workflow_attachments = attachments == null ? null : WorkflowExpression.Compile(attachments);
            WorkflowExpression.Validate(__workflow_attachments, nameof(attachments), required: false);
            var __workflow_attachmentFields = attachmentFields == null ? null : WorkflowExpression.Compile(attachmentFields);
            WorkflowExpression.Validate(__workflow_attachmentFields, nameof(attachmentFields), required: false);
            var __workflow_members = members == null ? null : WorkflowExpression.Compile(members);
            WorkflowExpression.Validate(__workflow_members, nameof(members), required: false);
            var __workflow_memberFields = memberFields == null ? null : WorkflowExpression.Compile(memberFields);
            WorkflowExpression.Validate(__workflow_memberFields, nameof(memberFields), required: false);
            var __workflow_membersVoted = membersVoted == null ? null : WorkflowExpression.Compile(membersVoted);
            WorkflowExpression.Validate(__workflow_membersVoted, nameof(membersVoted), required: false);
            var __workflow_memberVotedFields = memberVotedFields == null ? null : WorkflowExpression.Compile(memberVotedFields);
            WorkflowExpression.Validate(__workflow_memberVotedFields, nameof(memberVotedFields), required: false);
            var __workflow_checkItemStates = checkItemStates == null ? null : WorkflowExpression.Compile(checkItemStates);
            WorkflowExpression.Validate(__workflow_checkItemStates, nameof(checkItemStates), required: false);
            var __workflow_checkItemStateFields = checkItemStateFields == null ? null : WorkflowExpression.Compile(checkItemStateFields);
            WorkflowExpression.Validate(__workflow_checkItemStateFields, nameof(checkItemStateFields), required: false);
            var __workflow_checklists = checklists == null ? null : WorkflowExpression.Compile(checklists);
            WorkflowExpression.Validate(__workflow_checklists, nameof(checklists), required: false);
            var __workflow_checklistFields = checklistFields == null ? null : WorkflowExpression.Compile(checklistFields);
            WorkflowExpression.Validate(__workflow_checklistFields, nameof(checklistFields), required: false);
            var __workflow_board = board == null ? null : WorkflowExpression.Compile(board);
            WorkflowExpression.Validate(__workflow_board, nameof(board), required: false);
            var __workflow_boardFields = boardFields == null ? null : WorkflowExpression.Compile(boardFields);
            WorkflowExpression.Validate(__workflow_boardFields, nameof(boardFields), required: false);
            var __workflow_list = list == null ? null : WorkflowExpression.Compile(list);
            WorkflowExpression.Validate(__workflow_list, nameof(list), required: false);
            var __workflow_listFields = listFields == null ? null : WorkflowExpression.Compile(listFields);
            WorkflowExpression.Validate(__workflow_listFields, nameof(listFields), required: false);
            var __workflow_stickers = stickers == null ? null : WorkflowExpression.Compile(stickers);
            WorkflowExpression.Validate(__workflow_stickers, nameof(stickers), required: false);
            var __workflow_stickerFields = stickerFields == null ? null : WorkflowExpression.Compile(stickerFields);
            WorkflowExpression.Validate(__workflow_stickerFields, nameof(stickerFields), required: false);
            var __workflow_fields = fields == null ? null : WorkflowExpression.Compile(fields);
            WorkflowExpression.Validate(__workflow_fields, nameof(fields), required: false);
            return new DeferredBodyAction<CardWithChecklists>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/cards/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_cardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = ExpressionConverter.Convert(__workflow_boardId);
                if (__workflow_actions != null)
                    callPayload.Queries["actions"] = ExpressionConverter.Convert(__workflow_actions);
                if (__workflow_actionsEntities != null)
                    callPayload.Queries["actions_entities"] = ExpressionConverter.Convert(__workflow_actionsEntities);
                if (__workflow_actionsDisplay != null)
                    callPayload.Queries["actions_display"] = ExpressionConverter.Convert(__workflow_actionsDisplay);
                if (__workflow_actionsLimit != null)
                    callPayload.Queries["actions_limit"] = ExpressionConverter.Convert(__workflow_actionsLimit);
                if (__workflow_actionFields != null)
                    callPayload.Queries["action_fields"] = ExpressionConverter.Convert(__workflow_actionFields);
                if (__workflow_actionMemberCreatorFields != null)
                    callPayload.Queries["action_memberCreator_fields"] = ExpressionConverter.Convert(__workflow_actionMemberCreatorFields);
                if (__workflow_attachments != null)
                    callPayload.Queries["attachments"] = ExpressionConverter.Convert(__workflow_attachments);
                if (__workflow_attachmentFields != null)
                    callPayload.Queries["attachment_fields"] = ExpressionConverter.Convert(__workflow_attachmentFields);
                if (__workflow_members != null)
                    callPayload.Queries["members"] = ExpressionConverter.Convert(__workflow_members);
                if (__workflow_memberFields != null)
                    callPayload.Queries["member_fields"] = ExpressionConverter.Convert(__workflow_memberFields);
                if (__workflow_membersVoted != null)
                    callPayload.Queries["membersVoted"] = ExpressionConverter.Convert(__workflow_membersVoted);
                if (__workflow_memberVotedFields != null)
                    callPayload.Queries["memberVoted_fields"] = ExpressionConverter.Convert(__workflow_memberVotedFields);
                if (__workflow_checkItemStates != null)
                    callPayload.Queries["checkItemStates"] = ExpressionConverter.Convert(__workflow_checkItemStates);
                if (__workflow_checkItemStateFields != null)
                    callPayload.Queries["checkItemState_fields"] = ExpressionConverter.Convert(__workflow_checkItemStateFields);
                if (__workflow_checklists != null)
                    callPayload.Queries["checklists"] = ExpressionConverter.Convert(__workflow_checklists);
                if (__workflow_checklistFields != null)
                    callPayload.Queries["checklist_fields"] = ExpressionConverter.Convert(__workflow_checklistFields);
                if (__workflow_board != null)
                    callPayload.Queries["board"] = ExpressionConverter.Convert(__workflow_board);
                if (__workflow_boardFields != null)
                    callPayload.Queries["board_fields"] = ExpressionConverter.Convert(__workflow_boardFields);
                if (__workflow_list != null)
                    callPayload.Queries["list"] = ExpressionConverter.Convert(__workflow_list);
                if (__workflow_listFields != null)
                    callPayload.Queries["list_fields"] = ExpressionConverter.Convert(__workflow_listFields);
                if (__workflow_stickers != null)
                    callPayload.Queries["stickers"] = ExpressionConverter.Convert(__workflow_stickers);
                if (__workflow_stickerFields != null)
                    callPayload.Queries["sticker_fields"] = ExpressionConverter.Convert(__workflow_stickerFields);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction<CardWithChecklists>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<JToken> DeleteCard(Expression<Func<string>> boardId, Expression<Func<string>> cardId)
        {
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            var __workflow_cardId = cardId == null ? null : WorkflowExpression.Compile(cardId);
            WorkflowExpression.Validate(__workflow_cardId, nameof(cardId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/cards/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_cardId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = ExpressionConverter.Convert(__workflow_boardId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Board[]> ListBoards(Expression<Func<string>> filter = null, Expression<Func<string>> fields = null, Expression<Func<string>> actions = null, Expression<Func<bool>> actionsEntities = null, Expression<Func<int>> actionsLimit = null, Expression<Func<actionsFormatInput>> actionsFormat = null, Expression<Func<string>> actionsSince = null, Expression<Func<string>> actionFields = null, Expression<Func<string>> memberships = null, Expression<Func<bool>> organization = null, Expression<Func<string>> organizationFields = null, Expression<Func<string>> lists = null)
        {
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_fields = fields == null ? null : WorkflowExpression.Compile(fields);
            WorkflowExpression.Validate(__workflow_fields, nameof(fields), required: false);
            var __workflow_actions = actions == null ? null : WorkflowExpression.Compile(actions);
            WorkflowExpression.Validate(__workflow_actions, nameof(actions), required: false);
            var __workflow_actionsEntities = actionsEntities == null ? null : WorkflowExpression.Compile(actionsEntities);
            WorkflowExpression.Validate(__workflow_actionsEntities, nameof(actionsEntities), required: false);
            var __workflow_actionsLimit = actionsLimit == null ? null : WorkflowExpression.Compile(actionsLimit);
            WorkflowExpression.Validate(__workflow_actionsLimit, nameof(actionsLimit), required: false);
            var __workflow_actionsFormat = actionsFormat == null ? null : WorkflowExpression.Compile(actionsFormat);
            WorkflowExpression.Validate(__workflow_actionsFormat, nameof(actionsFormat), required: false);
            var __workflow_actionsSince = actionsSince == null ? null : WorkflowExpression.Compile(actionsSince);
            WorkflowExpression.Validate(__workflow_actionsSince, nameof(actionsSince), required: false);
            var __workflow_actionFields = actionFields == null ? null : WorkflowExpression.Compile(actionFields);
            WorkflowExpression.Validate(__workflow_actionFields, nameof(actionFields), required: false);
            var __workflow_memberships = memberships == null ? null : WorkflowExpression.Compile(memberships);
            WorkflowExpression.Validate(__workflow_memberships, nameof(memberships), required: false);
            var __workflow_organization = organization == null ? null : WorkflowExpression.Compile(organization);
            WorkflowExpression.Validate(__workflow_organization, nameof(organization), required: false);
            var __workflow_organizationFields = organizationFields == null ? null : WorkflowExpression.Compile(organizationFields);
            WorkflowExpression.Validate(__workflow_organizationFields, nameof(organizationFields), required: false);
            var __workflow_lists = lists == null ? null : WorkflowExpression.Compile(lists);
            WorkflowExpression.Validate(__workflow_lists, nameof(lists), required: false);
            return new DeferredBodyAction<Board[]>(() =>
            {
                var apiCallPath = "/member/me/boards";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_actions != null)
                    callPayload.Queries["actions"] = ExpressionConverter.Convert(__workflow_actions);
                if (__workflow_actionsEntities != null)
                    callPayload.Queries["actions_entities"] = ExpressionConverter.Convert(__workflow_actionsEntities);
                if (__workflow_actionsLimit != null)
                    callPayload.Queries["actions_limit"] = ExpressionConverter.Convert(__workflow_actionsLimit);
                if (__workflow_actionsFormat != null)
                    callPayload.Queries["actions_format"] = ExpressionConverter.Convert(__workflow_actionsFormat);
                if (__workflow_actionsSince != null)
                    callPayload.Queries["actions_since"] = ExpressionConverter.Convert(__workflow_actionsSince);
                if (__workflow_actionFields != null)
                    callPayload.Queries["action_fields"] = ExpressionConverter.Convert(__workflow_actionFields);
                if (__workflow_memberships != null)
                    callPayload.Queries["memberships"] = ExpressionConverter.Convert(__workflow_memberships);
                if (__workflow_organization != null)
                    callPayload.Queries["organization"] = ExpressionConverter.Convert(__workflow_organization);
                if (__workflow_organizationFields != null)
                    callPayload.Queries["organization_fields"] = ExpressionConverter.Convert(__workflow_organizationFields);
                if (__workflow_lists != null)
                    callPayload.Queries["lists"] = ExpressionConverter.Convert(__workflow_lists);
                return new ApiConnectionAction<Board[]>(callPayload);
            });
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
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            var __workflow_actions = actions == null ? null : WorkflowExpression.Compile(actions);
            WorkflowExpression.Validate(__workflow_actions, nameof(actions), required: false);
            var __workflow_actionEntities = actionEntities == null ? null : WorkflowExpression.Compile(actionEntities);
            WorkflowExpression.Validate(__workflow_actionEntities, nameof(actionEntities), required: false);
            var __workflow_actionsDisplay = actionsDisplay == null ? null : WorkflowExpression.Compile(actionsDisplay);
            WorkflowExpression.Validate(__workflow_actionsDisplay, nameof(actionsDisplay), required: false);
            var __workflow_actionsFormat = actionsFormat == null ? null : WorkflowExpression.Compile(actionsFormat);
            WorkflowExpression.Validate(__workflow_actionsFormat, nameof(actionsFormat), required: false);
            var __workflow_actionsSince = actionsSince == null ? null : WorkflowExpression.Compile(actionsSince);
            WorkflowExpression.Validate(__workflow_actionsSince, nameof(actionsSince), required: false);
            var __workflow_actionsLimit = actionsLimit == null ? null : WorkflowExpression.Compile(actionsLimit);
            WorkflowExpression.Validate(__workflow_actionsLimit, nameof(actionsLimit), required: false);
            var __workflow_actionFields = actionFields == null ? null : WorkflowExpression.Compile(actionFields);
            WorkflowExpression.Validate(__workflow_actionFields, nameof(actionFields), required: false);
            var __workflow_actionMember = actionMember == null ? null : WorkflowExpression.Compile(actionMember);
            WorkflowExpression.Validate(__workflow_actionMember, nameof(actionMember), required: false);
            var __workflow_actionMemberFields = actionMemberFields == null ? null : WorkflowExpression.Compile(actionMemberFields);
            WorkflowExpression.Validate(__workflow_actionMemberFields, nameof(actionMemberFields), required: false);
            var __workflow_actionMemberCreator = actionMemberCreator == null ? null : WorkflowExpression.Compile(actionMemberCreator);
            WorkflowExpression.Validate(__workflow_actionMemberCreator, nameof(actionMemberCreator), required: false);
            var __workflow_actionMemberCreatorFields = actionMemberCreatorFields == null ? null : WorkflowExpression.Compile(actionMemberCreatorFields);
            WorkflowExpression.Validate(__workflow_actionMemberCreatorFields, nameof(actionMemberCreatorFields), required: false);
            var __workflow_cards = cards == null ? null : WorkflowExpression.Compile(cards);
            WorkflowExpression.Validate(__workflow_cards, nameof(cards), required: false);
            var __workflow_cardFields = cardFields == null ? null : WorkflowExpression.Compile(cardFields);
            WorkflowExpression.Validate(__workflow_cardFields, nameof(cardFields), required: false);
            var __workflow_cardAttachments = cardAttachments == null ? null : WorkflowExpression.Compile(cardAttachments);
            WorkflowExpression.Validate(__workflow_cardAttachments, nameof(cardAttachments), required: false);
            var __workflow_cardAttachmentFields = cardAttachmentFields == null ? null : WorkflowExpression.Compile(cardAttachmentFields);
            WorkflowExpression.Validate(__workflow_cardAttachmentFields, nameof(cardAttachmentFields), required: false);
            var __workflow_cardChecklists = cardChecklists == null ? null : WorkflowExpression.Compile(cardChecklists);
            WorkflowExpression.Validate(__workflow_cardChecklists, nameof(cardChecklists), required: false);
            var __workflow_cardStickers = cardStickers == null ? null : WorkflowExpression.Compile(cardStickers);
            WorkflowExpression.Validate(__workflow_cardStickers, nameof(cardStickers), required: false);
            var __workflow_boardStars = boardStars == null ? null : WorkflowExpression.Compile(boardStars);
            WorkflowExpression.Validate(__workflow_boardStars, nameof(boardStars), required: false);
            var __workflow_labels = labels == null ? null : WorkflowExpression.Compile(labels);
            WorkflowExpression.Validate(__workflow_labels, nameof(labels), required: false);
            var __workflow_labelFields = labelFields == null ? null : WorkflowExpression.Compile(labelFields);
            WorkflowExpression.Validate(__workflow_labelFields, nameof(labelFields), required: false);
            var __workflow_labelsLimit = labelsLimit == null ? null : WorkflowExpression.Compile(labelsLimit);
            WorkflowExpression.Validate(__workflow_labelsLimit, nameof(labelsLimit), required: false);
            var __workflow_lists = lists == null ? null : WorkflowExpression.Compile(lists);
            WorkflowExpression.Validate(__workflow_lists, nameof(lists), required: false);
            var __workflow_listFields = listFields == null ? null : WorkflowExpression.Compile(listFields);
            WorkflowExpression.Validate(__workflow_listFields, nameof(listFields), required: false);
            var __workflow_memberships = memberships == null ? null : WorkflowExpression.Compile(memberships);
            WorkflowExpression.Validate(__workflow_memberships, nameof(memberships), required: false);
            var __workflow_membershipsMember = membershipsMember == null ? null : WorkflowExpression.Compile(membershipsMember);
            WorkflowExpression.Validate(__workflow_membershipsMember, nameof(membershipsMember), required: false);
            var __workflow_membershipsMemberFields = membershipsMemberFields == null ? null : WorkflowExpression.Compile(membershipsMemberFields);
            WorkflowExpression.Validate(__workflow_membershipsMemberFields, nameof(membershipsMemberFields), required: false);
            var __workflow_members = members == null ? null : WorkflowExpression.Compile(members);
            WorkflowExpression.Validate(__workflow_members, nameof(members), required: false);
            var __workflow_memberFields = memberFields == null ? null : WorkflowExpression.Compile(memberFields);
            WorkflowExpression.Validate(__workflow_memberFields, nameof(memberFields), required: false);
            var __workflow_membersInvited = membersInvited == null ? null : WorkflowExpression.Compile(membersInvited);
            WorkflowExpression.Validate(__workflow_membersInvited, nameof(membersInvited), required: false);
            var __workflow_membersInvitedFields = membersInvitedFields == null ? null : WorkflowExpression.Compile(membersInvitedFields);
            WorkflowExpression.Validate(__workflow_membersInvitedFields, nameof(membersInvitedFields), required: false);
            var __workflow_checklists = checklists == null ? null : WorkflowExpression.Compile(checklists);
            WorkflowExpression.Validate(__workflow_checklists, nameof(checklists), required: false);
            var __workflow_checklistFields = checklistFields == null ? null : WorkflowExpression.Compile(checklistFields);
            WorkflowExpression.Validate(__workflow_checklistFields, nameof(checklistFields), required: false);
            var __workflow_organization = organization == null ? null : WorkflowExpression.Compile(organization);
            WorkflowExpression.Validate(__workflow_organization, nameof(organization), required: false);
            var __workflow_organizationFields = organizationFields == null ? null : WorkflowExpression.Compile(organizationFields);
            WorkflowExpression.Validate(__workflow_organizationFields, nameof(organizationFields), required: false);
            var __workflow_organizationMemberships = organizationMemberships == null ? null : WorkflowExpression.Compile(organizationMemberships);
            WorkflowExpression.Validate(__workflow_organizationMemberships, nameof(organizationMemberships), required: false);
            var __workflow_myPerfs = myPerfs == null ? null : WorkflowExpression.Compile(myPerfs);
            WorkflowExpression.Validate(__workflow_myPerfs, nameof(myPerfs), required: false);
            var __workflow_fields = fields == null ? null : WorkflowExpression.Compile(fields);
            WorkflowExpression.Validate(__workflow_fields, nameof(fields), required: false);
            return new DeferredBodyAction<BoardWithChecklists>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/boards/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_boardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_actions != null)
                    callPayload.Queries["actions"] = ExpressionConverter.Convert(__workflow_actions);
                if (__workflow_actionEntities != null)
                    callPayload.Queries["action_entities"] = ExpressionConverter.Convert(__workflow_actionEntities);
                if (__workflow_actionsDisplay != null)
                    callPayload.Queries["actions_display"] = ExpressionConverter.Convert(__workflow_actionsDisplay);
                if (__workflow_actionsFormat != null)
                    callPayload.Queries["actions_format"] = ExpressionConverter.Convert(__workflow_actionsFormat);
                if (__workflow_actionsSince != null)
                    callPayload.Queries["actions_since"] = ExpressionConverter.Convert(__workflow_actionsSince);
                if (__workflow_actionsLimit != null)
                    callPayload.Queries["actions_limit"] = ExpressionConverter.Convert(__workflow_actionsLimit);
                if (__workflow_actionFields != null)
                    callPayload.Queries["action_fields"] = ExpressionConverter.Convert(__workflow_actionFields);
                if (__workflow_actionMember != null)
                    callPayload.Queries["action_member"] = ExpressionConverter.Convert(__workflow_actionMember);
                if (__workflow_actionMemberFields != null)
                    callPayload.Queries["action_member_fields"] = ExpressionConverter.Convert(__workflow_actionMemberFields);
                if (__workflow_actionMemberCreator != null)
                    callPayload.Queries["action_memberCreator"] = ExpressionConverter.Convert(__workflow_actionMemberCreator);
                if (__workflow_actionMemberCreatorFields != null)
                    callPayload.Queries["action_memberCreator_fields"] = ExpressionConverter.Convert(__workflow_actionMemberCreatorFields);
                if (__workflow_cards != null)
                    callPayload.Queries["cards"] = ExpressionConverter.Convert(__workflow_cards);
                if (__workflow_cardFields != null)
                    callPayload.Queries["card_fields"] = ExpressionConverter.Convert(__workflow_cardFields);
                if (__workflow_cardAttachments != null)
                    callPayload.Queries["card_attachments"] = ExpressionConverter.Convert(__workflow_cardAttachments);
                if (__workflow_cardAttachmentFields != null)
                    callPayload.Queries["card_attachment_fields"] = ExpressionConverter.Convert(__workflow_cardAttachmentFields);
                if (__workflow_cardChecklists != null)
                    callPayload.Queries["card_checklists"] = ExpressionConverter.Convert(__workflow_cardChecklists);
                if (__workflow_cardStickers != null)
                    callPayload.Queries["card_stickers"] = ExpressionConverter.Convert(__workflow_cardStickers);
                if (__workflow_boardStars != null)
                    callPayload.Queries["boardStars"] = ExpressionConverter.Convert(__workflow_boardStars);
                if (__workflow_labels != null)
                    callPayload.Queries["labels"] = ExpressionConverter.Convert(__workflow_labels);
                if (__workflow_labelFields != null)
                    callPayload.Queries["label_fields"] = ExpressionConverter.Convert(__workflow_labelFields);
                if (__workflow_labelsLimit != null)
                    callPayload.Queries["labels_limit"] = ExpressionConverter.Convert(__workflow_labelsLimit);
                if (__workflow_lists != null)
                    callPayload.Queries["lists"] = ExpressionConverter.Convert(__workflow_lists);
                if (__workflow_listFields != null)
                    callPayload.Queries["list_fields"] = ExpressionConverter.Convert(__workflow_listFields);
                if (__workflow_memberships != null)
                    callPayload.Queries["memberships"] = ExpressionConverter.Convert(__workflow_memberships);
                if (__workflow_membershipsMember != null)
                    callPayload.Queries["memberships_member"] = ExpressionConverter.Convert(__workflow_membershipsMember);
                if (__workflow_membershipsMemberFields != null)
                    callPayload.Queries["memberships_member_fields"] = ExpressionConverter.Convert(__workflow_membershipsMemberFields);
                if (__workflow_members != null)
                    callPayload.Queries["members"] = ExpressionConverter.Convert(__workflow_members);
                if (__workflow_memberFields != null)
                    callPayload.Queries["member_fields"] = ExpressionConverter.Convert(__workflow_memberFields);
                if (__workflow_membersInvited != null)
                    callPayload.Queries["membersInvited"] = ExpressionConverter.Convert(__workflow_membersInvited);
                if (__workflow_membersInvitedFields != null)
                    callPayload.Queries["membersInvited_fields"] = ExpressionConverter.Convert(__workflow_membersInvitedFields);
                if (__workflow_checklists != null)
                    callPayload.Queries["checklists"] = ExpressionConverter.Convert(__workflow_checklists);
                if (__workflow_checklistFields != null)
                    callPayload.Queries["checklist_fields"] = ExpressionConverter.Convert(__workflow_checklistFields);
                if (__workflow_organization != null)
                    callPayload.Queries["organization"] = ExpressionConverter.Convert(__workflow_organization);
                if (__workflow_organizationFields != null)
                    callPayload.Queries["organization_fields"] = ExpressionConverter.Convert(__workflow_organizationFields);
                if (__workflow_organizationMemberships != null)
                    callPayload.Queries["organization_memberships"] = ExpressionConverter.Convert(__workflow_organizationMemberships);
                if (__workflow_myPerfs != null)
                    callPayload.Queries["myPerfs"] = ExpressionConverter.Convert(__workflow_myPerfs);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction<BoardWithChecklists>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Board> UpdateBoard(Expression<Func<string>> boardId, Expression<Func<string>> boardboardName = null, Expression<Func<boardcreateDefaultListsInput>> boardcreateDefaultLists = null, Expression<Func<string>> boardboardDescription = null, Expression<Func<string>> boardteamId = null, Expression<Func<boardpermissionLevelInput>> boardpermissionLevel = null, Expression<Func<boardcommentPreferencesInput>> boardcommentPreferences = null, Expression<Func<boardinvitationPreferencesInput>> boardinvitationPreferences = null, Expression<Func<boarduseCardCoversInput>> boarduseCardCovers = null, Expression<Func<boardbackgroundColorInput>> boardbackgroundColor = null, Expression<Func<boardvotingPowerUpPreferencesInput>> boardvotingPowerUpPreferences = null, Expression<Func<boardcardAgingPowerUpPreferencesInput>> boardcardAgingPowerUpPreferences = null, Expression<Func<boardenableCalendarPowerUpInput>> boardenableCalendarPowerUp = null)
        {
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            var __workflow_boardboardName = boardboardName == null ? null : WorkflowExpression.Compile(boardboardName);
            WorkflowExpression.Validate(__workflow_boardboardName, nameof(boardboardName), required: false);
            var __workflow_boardcreateDefaultLists = boardcreateDefaultLists == null ? null : WorkflowExpression.Compile(boardcreateDefaultLists);
            WorkflowExpression.Validate(__workflow_boardcreateDefaultLists, nameof(boardcreateDefaultLists), required: false);
            var __workflow_boardboardDescription = boardboardDescription == null ? null : WorkflowExpression.Compile(boardboardDescription);
            WorkflowExpression.Validate(__workflow_boardboardDescription, nameof(boardboardDescription), required: false);
            var __workflow_boardteamId = boardteamId == null ? null : WorkflowExpression.Compile(boardteamId);
            WorkflowExpression.Validate(__workflow_boardteamId, nameof(boardteamId), required: false);
            var __workflow_boardpermissionLevel = boardpermissionLevel == null ? null : WorkflowExpression.Compile(boardpermissionLevel);
            WorkflowExpression.Validate(__workflow_boardpermissionLevel, nameof(boardpermissionLevel), required: false);
            var __workflow_boardcommentPreferences = boardcommentPreferences == null ? null : WorkflowExpression.Compile(boardcommentPreferences);
            WorkflowExpression.Validate(__workflow_boardcommentPreferences, nameof(boardcommentPreferences), required: false);
            var __workflow_boardinvitationPreferences = boardinvitationPreferences == null ? null : WorkflowExpression.Compile(boardinvitationPreferences);
            WorkflowExpression.Validate(__workflow_boardinvitationPreferences, nameof(boardinvitationPreferences), required: false);
            var __workflow_boarduseCardCovers = boarduseCardCovers == null ? null : WorkflowExpression.Compile(boarduseCardCovers);
            WorkflowExpression.Validate(__workflow_boarduseCardCovers, nameof(boarduseCardCovers), required: false);
            var __workflow_boardbackgroundColor = boardbackgroundColor == null ? null : WorkflowExpression.Compile(boardbackgroundColor);
            WorkflowExpression.Validate(__workflow_boardbackgroundColor, nameof(boardbackgroundColor), required: false);
            var __workflow_boardvotingPowerUpPreferences = boardvotingPowerUpPreferences == null ? null : WorkflowExpression.Compile(boardvotingPowerUpPreferences);
            WorkflowExpression.Validate(__workflow_boardvotingPowerUpPreferences, nameof(boardvotingPowerUpPreferences), required: false);
            var __workflow_boardcardAgingPowerUpPreferences = boardcardAgingPowerUpPreferences == null ? null : WorkflowExpression.Compile(boardcardAgingPowerUpPreferences);
            WorkflowExpression.Validate(__workflow_boardcardAgingPowerUpPreferences, nameof(boardcardAgingPowerUpPreferences), required: false);
            var __workflow_boardenableCalendarPowerUp = boardenableCalendarPowerUp == null ? null : WorkflowExpression.Compile(boardenableCalendarPowerUp);
            WorkflowExpression.Validate(__workflow_boardenableCalendarPowerUp, nameof(boardenableCalendarPowerUp), required: false);
            return new DeferredBodyAction<Board>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/boards/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_boardId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var board = new JObject();
                var boardpropCount = 0;
                if (__workflow_boardboardName != null)
                {
                    board["name"] = ExpressionConverter.ConvertO(__workflow_boardboardName);
                    boardpropCount++;
                }

                if (__workflow_boardcreateDefaultLists != null)
                {
                    board["defaultLists"] = ExpressionConverter.ConvertO(__workflow_boardcreateDefaultLists);
                    boardpropCount++;
                }

                if (__workflow_boardboardDescription != null)
                {
                    board["desc"] = ExpressionConverter.ConvertO(__workflow_boardboardDescription);
                    boardpropCount++;
                }

                if (__workflow_boardteamId != null)
                {
                    board["idOrganization"] = ExpressionConverter.ConvertO(__workflow_boardteamId);
                    boardpropCount++;
                }

                if (__workflow_boardpermissionLevel != null)
                {
                    board["prefs_permissionLevel"] = ExpressionConverter.ConvertO(__workflow_boardpermissionLevel);
                    boardpropCount++;
                }

                if (__workflow_boardcommentPreferences != null)
                {
                    board["prefs_comments"] = ExpressionConverter.ConvertO(__workflow_boardcommentPreferences);
                    boardpropCount++;
                }

                if (__workflow_boardinvitationPreferences != null)
                {
                    board["prefs_invitations"] = ExpressionConverter.ConvertO(__workflow_boardinvitationPreferences);
                    boardpropCount++;
                }

                if (__workflow_boarduseCardCovers != null)
                {
                    board["prefs_cardCovers"] = ExpressionConverter.ConvertO(__workflow_boarduseCardCovers);
                    boardpropCount++;
                }

                if (__workflow_boardbackgroundColor != null)
                {
                    board["prefs_background"] = ExpressionConverter.ConvertO(__workflow_boardbackgroundColor);
                    boardpropCount++;
                }

                if (__workflow_boardvotingPowerUpPreferences != null)
                {
                    board["prefs_voting"] = ExpressionConverter.ConvertO(__workflow_boardvotingPowerUpPreferences);
                    boardpropCount++;
                }

                if (__workflow_boardcardAgingPowerUpPreferences != null)
                {
                    board["prefs_cardAging"] = ExpressionConverter.ConvertO(__workflow_boardcardAgingPowerUpPreferences);
                    boardpropCount++;
                }

                if (__workflow_boardenableCalendarPowerUp != null)
                {
                    board["enable_calendar"] = ExpressionConverter.ConvertO(__workflow_boardenableCalendarPowerUp);
                    boardpropCount++;
                }

                if (boardpropCount > 0)
                {
                    callPayload.Body = board;
                }

                return new ApiConnectionAction<Board>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<List[]> ListLists(Expression<Func<string>> boardId, Expression<Func<cardsInput>> cards = null, Expression<Func<string>> cardFields = null, Expression<Func<filterInput>> filter = null, Expression<Func<string>> fields = null)
        {
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            var __workflow_cards = cards == null ? null : WorkflowExpression.Compile(cards);
            WorkflowExpression.Validate(__workflow_cards, nameof(cards), required: false);
            var __workflow_cardFields = cardFields == null ? null : WorkflowExpression.Compile(cardFields);
            WorkflowExpression.Validate(__workflow_cardFields, nameof(cardFields), required: false);
            var __workflow_filter = filter == null ? null : WorkflowExpression.Compile(filter);
            WorkflowExpression.Validate(__workflow_filter, nameof(filter), required: false);
            var __workflow_fields = fields == null ? null : WorkflowExpression.Compile(fields);
            WorkflowExpression.Validate(__workflow_fields, nameof(fields), required: false);
            return new DeferredBodyAction<List[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/boards/{0}/lists", ExpressionConverter.ConvertWithUrlEncoding(__workflow_boardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cards != null)
                    callPayload.Queries["cards"] = ExpressionConverter.Convert(__workflow_cards);
                if (__workflow_cardFields != null)
                    callPayload.Queries["card_fields"] = ExpressionConverter.Convert(__workflow_cardFields);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction<List[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<List[]> ListListsSimple(Expression<Func<string>> boardId)
        {
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            return new DeferredBodyAction<List[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/simple/boards/{0}/lists", ExpressionConverter.ConvertWithUrlEncoding(__workflow_boardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<List[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<List> GetList(Expression<Func<string>> boardId, Expression<Func<string>> listId, Expression<Func<cardsInput>> cards = null, Expression<Func<string>> cardFields = null, Expression<Func<bool>> board = null, Expression<Func<string>> boardFields = null, Expression<Func<string>> fields = null)
        {
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            var __workflow_listId = listId == null ? null : WorkflowExpression.Compile(listId);
            WorkflowExpression.Validate(__workflow_listId, nameof(listId), required: true);
            var __workflow_cards = cards == null ? null : WorkflowExpression.Compile(cards);
            WorkflowExpression.Validate(__workflow_cards, nameof(cards), required: false);
            var __workflow_cardFields = cardFields == null ? null : WorkflowExpression.Compile(cardFields);
            WorkflowExpression.Validate(__workflow_cardFields, nameof(cardFields), required: false);
            var __workflow_board = board == null ? null : WorkflowExpression.Compile(board);
            WorkflowExpression.Validate(__workflow_board, nameof(board), required: false);
            var __workflow_boardFields = boardFields == null ? null : WorkflowExpression.Compile(boardFields);
            WorkflowExpression.Validate(__workflow_boardFields, nameof(boardFields), required: false);
            var __workflow_fields = fields == null ? null : WorkflowExpression.Compile(fields);
            WorkflowExpression.Validate(__workflow_fields, nameof(fields), required: false);
            return new DeferredBodyAction<List>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_listId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = ExpressionConverter.Convert(__workflow_boardId);
                if (__workflow_cards != null)
                    callPayload.Queries["cards"] = ExpressionConverter.Convert(__workflow_cards);
                if (__workflow_cardFields != null)
                    callPayload.Queries["card_fields"] = ExpressionConverter.Convert(__workflow_cardFields);
                if (__workflow_board != null)
                    callPayload.Queries["board"] = ExpressionConverter.Convert(__workflow_board);
                if (__workflow_boardFields != null)
                    callPayload.Queries["board_fields"] = ExpressionConverter.Convert(__workflow_boardFields);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction<List>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<CreateListResponse> UpdateList(Expression<Func<string>> boardId, Expression<Func<string>> listId, Expression<Func<string>> name = null, Expression<Func<closedInput>> closed = null, Expression<Func<string>> idBoard = null, Expression<Func<posInput>> pos = null, Expression<Func<subscribedInput>> subscribed = null)
        {
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            var __workflow_listId = listId == null ? null : WorkflowExpression.Compile(listId);
            WorkflowExpression.Validate(__workflow_listId, nameof(listId), required: true);
            var __workflow_name = name == null ? null : WorkflowExpression.Compile(name);
            WorkflowExpression.Validate(__workflow_name, nameof(name), required: false);
            var __workflow_closed = closed == null ? null : WorkflowExpression.Compile(closed);
            WorkflowExpression.Validate(__workflow_closed, nameof(closed), required: false);
            var __workflow_idBoard = idBoard == null ? null : WorkflowExpression.Compile(idBoard);
            WorkflowExpression.Validate(__workflow_idBoard, nameof(idBoard), required: false);
            var __workflow_pos = pos == null ? null : WorkflowExpression.Compile(pos);
            WorkflowExpression.Validate(__workflow_pos, nameof(pos), required: false);
            var __workflow_subscribed = subscribed == null ? null : WorkflowExpression.Compile(subscribed);
            WorkflowExpression.Validate(__workflow_subscribed, nameof(subscribed), required: false);
            return new DeferredBodyAction<CreateListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_listId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = ExpressionConverter.Convert(__workflow_boardId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_closed != null)
                    callPayload.Queries["closed"] = ExpressionConverter.Convert(__workflow_closed);
                if (__workflow_idBoard != null)
                    callPayload.Queries["idBoard"] = ExpressionConverter.Convert(__workflow_idBoard);
                if (__workflow_pos != null)
                    callPayload.Queries["pos"] = ExpressionConverter.Convert(__workflow_pos);
                if (__workflow_subscribed != null)
                    callPayload.Queries["subscribed"] = ExpressionConverter.Convert(__workflow_subscribed);
                return new ApiConnectionAction<CreateListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<JToken> GetUserProfile(Expression<Func<string>> fields = null)
        {
            var __workflow_fields = fields == null ? null : WorkflowExpression.Compile(fields);
            WorkflowExpression.Validate(__workflow_fields, nameof(fields), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/members/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction<JToken>(callPayload);
            });
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
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            return new DeferredBodyAction<Member[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/organizations/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Member[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Member[]> ListBoardMembers(Expression<Func<string>> boardId)
        {
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            return new DeferredBodyAction<Member[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/boards/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(__workflow_boardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Member[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<BoardLabel[]> ListBoardLabels(Expression<Func<string>> boardId)
        {
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            return new DeferredBodyAction<BoardLabel[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/boards/{0}/labels", ExpressionConverter.ConvertWithUrlEncoding(__workflow_boardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                return new ApiConnectionAction<BoardLabel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Team> GetTeamForBoard(Expression<Func<string>> boardId)
        {
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            return new DeferredBodyAction<Team>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/boards/{0}/organization", ExpressionConverter.ConvertWithUrlEncoding(__workflow_boardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Team>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Member[]> ListCardMembers(Expression<Func<string>> boardId, Expression<Func<string>> cardId)
        {
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            var __workflow_cardId = cardId == null ? null : WorkflowExpression.Compile(cardId);
            WorkflowExpression.Validate(__workflow_cardId, nameof(cardId), required: true);
            return new DeferredBodyAction<Member[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/cards/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(__workflow_cardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = ExpressionConverter.Convert(__workflow_boardId);
                return new ApiConnectionAction<Member[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Comment[]> ListCardComments(Expression<Func<string>> boardId, Expression<Func<string>> cardId)
        {
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            var __workflow_cardId = cardId == null ? null : WorkflowExpression.Compile(cardId);
            WorkflowExpression.Validate(__workflow_cardId, nameof(cardId), required: true);
            return new DeferredBodyAction<Comment[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/cards/{0}/actions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_cardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = ExpressionConverter.Convert(__workflow_boardId);
                return new ApiConnectionAction<Comment[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Comment> AddCommentToCard(Expression<Func<string>> boardId, Expression<Func<string>> cardId, Expression<Func<string>> commentcommentText = null)
        {
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            var __workflow_cardId = cardId == null ? null : WorkflowExpression.Compile(cardId);
            WorkflowExpression.Validate(__workflow_cardId, nameof(cardId), required: true);
            var __workflow_commentcommentText = commentcommentText == null ? null : WorkflowExpression.Compile(commentcommentText);
            WorkflowExpression.Validate(__workflow_commentcommentText, nameof(commentcommentText), required: false);
            return new DeferredBodyAction<Comment>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/cards/{0}/actions/comments", ExpressionConverter.ConvertWithUrlEncoding(__workflow_cardId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = ExpressionConverter.Convert(__workflow_boardId);
                var comment = new JObject();
                var commentpropCount = 0;
                if (__workflow_commentcommentText != null)
                {
                    comment["text"] = ExpressionConverter.ConvertO(__workflow_commentcommentText);
                    commentpropCount++;
                }

                if (commentpropCount > 0)
                {
                    callPayload.Body = comment;
                }

                return new ApiConnectionAction<Comment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Member[]> AddMemberToCard(Expression<Func<string>> boardId, Expression<Func<string>> cardId, Expression<Func<string>> memberId)
        {
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            var __workflow_cardId = cardId == null ? null : WorkflowExpression.Compile(cardId);
            WorkflowExpression.Validate(__workflow_cardId, nameof(cardId), required: true);
            var __workflow_memberId = memberId == null ? null : WorkflowExpression.Compile(memberId);
            WorkflowExpression.Validate(__workflow_memberId, nameof(memberId), required: true);
            return new DeferredBodyAction<Member[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/cards/{0}/idMembers", ExpressionConverter.ConvertWithUrlEncoding(__workflow_cardId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = ExpressionConverter.Convert(__workflow_boardId);
                callPayload.Queries["memberId"] = ExpressionConverter.Convert(__workflow_memberId);
                return new ApiConnectionAction<Member[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Board> CreateBoard(Expression<Func<string>> boardboardName, Expression<Func<boardcreateDefaultListsInput>> boardcreateDefaultLists = null, Expression<Func<string>> boardboardDescription = null, Expression<Func<string>> boardteamId = null, Expression<Func<boardpermissionLevelInput>> boardpermissionLevel = null, Expression<Func<boardcommentPreferencesInput>> boardcommentPreferences = null, Expression<Func<boardinvitationPreferencesInput>> boardinvitationPreferences = null, Expression<Func<boarduseCardCoversInput>> boarduseCardCovers = null, Expression<Func<boardbackgroundColorInput>> boardbackgroundColor = null, Expression<Func<boardvotingPowerUpPreferencesInput>> boardvotingPowerUpPreferences = null, Expression<Func<boardcardAgingPowerUpPreferencesInput>> boardcardAgingPowerUpPreferences = null, Expression<Func<boardenableCalendarPowerUpInput>> boardenableCalendarPowerUp = null)
        {
            var __workflow_boardboardName = boardboardName == null ? null : WorkflowExpression.Compile(boardboardName);
            WorkflowExpression.Validate(__workflow_boardboardName, nameof(boardboardName), required: true);
            var __workflow_boardcreateDefaultLists = boardcreateDefaultLists == null ? null : WorkflowExpression.Compile(boardcreateDefaultLists);
            WorkflowExpression.Validate(__workflow_boardcreateDefaultLists, nameof(boardcreateDefaultLists), required: false);
            var __workflow_boardboardDescription = boardboardDescription == null ? null : WorkflowExpression.Compile(boardboardDescription);
            WorkflowExpression.Validate(__workflow_boardboardDescription, nameof(boardboardDescription), required: false);
            var __workflow_boardteamId = boardteamId == null ? null : WorkflowExpression.Compile(boardteamId);
            WorkflowExpression.Validate(__workflow_boardteamId, nameof(boardteamId), required: false);
            var __workflow_boardpermissionLevel = boardpermissionLevel == null ? null : WorkflowExpression.Compile(boardpermissionLevel);
            WorkflowExpression.Validate(__workflow_boardpermissionLevel, nameof(boardpermissionLevel), required: false);
            var __workflow_boardcommentPreferences = boardcommentPreferences == null ? null : WorkflowExpression.Compile(boardcommentPreferences);
            WorkflowExpression.Validate(__workflow_boardcommentPreferences, nameof(boardcommentPreferences), required: false);
            var __workflow_boardinvitationPreferences = boardinvitationPreferences == null ? null : WorkflowExpression.Compile(boardinvitationPreferences);
            WorkflowExpression.Validate(__workflow_boardinvitationPreferences, nameof(boardinvitationPreferences), required: false);
            var __workflow_boarduseCardCovers = boarduseCardCovers == null ? null : WorkflowExpression.Compile(boarduseCardCovers);
            WorkflowExpression.Validate(__workflow_boarduseCardCovers, nameof(boarduseCardCovers), required: false);
            var __workflow_boardbackgroundColor = boardbackgroundColor == null ? null : WorkflowExpression.Compile(boardbackgroundColor);
            WorkflowExpression.Validate(__workflow_boardbackgroundColor, nameof(boardbackgroundColor), required: false);
            var __workflow_boardvotingPowerUpPreferences = boardvotingPowerUpPreferences == null ? null : WorkflowExpression.Compile(boardvotingPowerUpPreferences);
            WorkflowExpression.Validate(__workflow_boardvotingPowerUpPreferences, nameof(boardvotingPowerUpPreferences), required: false);
            var __workflow_boardcardAgingPowerUpPreferences = boardcardAgingPowerUpPreferences == null ? null : WorkflowExpression.Compile(boardcardAgingPowerUpPreferences);
            WorkflowExpression.Validate(__workflow_boardcardAgingPowerUpPreferences, nameof(boardcardAgingPowerUpPreferences), required: false);
            var __workflow_boardenableCalendarPowerUp = boardenableCalendarPowerUp == null ? null : WorkflowExpression.Compile(boardenableCalendarPowerUp);
            WorkflowExpression.Validate(__workflow_boardenableCalendarPowerUp, nameof(boardenableCalendarPowerUp), required: false);
            return new DeferredBodyAction<Board>(() =>
            {
                var apiCallPath = "/boards";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var board = new JObject();
                var boardpropCount = 0;
                boardpropCount++;
                board["name"] = ExpressionConverter.ConvertO(__workflow_boardboardName);
                if (__workflow_boardcreateDefaultLists != null)
                {
                    board["defaultLists"] = ExpressionConverter.ConvertO(__workflow_boardcreateDefaultLists);
                    boardpropCount++;
                }

                if (__workflow_boardboardDescription != null)
                {
                    board["desc"] = ExpressionConverter.ConvertO(__workflow_boardboardDescription);
                    boardpropCount++;
                }

                if (__workflow_boardteamId != null)
                {
                    board["idOrganization"] = ExpressionConverter.ConvertO(__workflow_boardteamId);
                    boardpropCount++;
                }

                if (__workflow_boardpermissionLevel != null)
                {
                    board["prefs_permissionLevel"] = ExpressionConverter.ConvertO(__workflow_boardpermissionLevel);
                    boardpropCount++;
                }

                if (__workflow_boardcommentPreferences != null)
                {
                    board["prefs_comments"] = ExpressionConverter.ConvertO(__workflow_boardcommentPreferences);
                    boardpropCount++;
                }

                if (__workflow_boardinvitationPreferences != null)
                {
                    board["prefs_invitations"] = ExpressionConverter.ConvertO(__workflow_boardinvitationPreferences);
                    boardpropCount++;
                }

                if (__workflow_boarduseCardCovers != null)
                {
                    board["prefs_cardCovers"] = ExpressionConverter.ConvertO(__workflow_boarduseCardCovers);
                    boardpropCount++;
                }

                if (__workflow_boardbackgroundColor != null)
                {
                    board["prefs_background"] = ExpressionConverter.ConvertO(__workflow_boardbackgroundColor);
                    boardpropCount++;
                }

                if (__workflow_boardvotingPowerUpPreferences != null)
                {
                    board["prefs_voting"] = ExpressionConverter.ConvertO(__workflow_boardvotingPowerUpPreferences);
                    boardpropCount++;
                }

                if (__workflow_boardcardAgingPowerUpPreferences != null)
                {
                    board["prefs_cardAging"] = ExpressionConverter.ConvertO(__workflow_boardcardAgingPowerUpPreferences);
                    boardpropCount++;
                }

                if (__workflow_boardenableCalendarPowerUp != null)
                {
                    board["enable_calendar"] = ExpressionConverter.ConvertO(__workflow_boardenableCalendarPowerUp);
                    boardpropCount++;
                }

                if (boardpropCount > 0)
                {
                    callPayload.Body = board;
                }

                return new ApiConnectionAction<Board>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<CreateListResponse> CreateList(Expression<Func<string>> listlistName, Expression<Func<string>> listboardId, Expression<Func<listlistPositionInput>> listlistPosition = null, Expression<Func<string>> listlistSource = null)
        {
            var __workflow_listlistName = listlistName == null ? null : WorkflowExpression.Compile(listlistName);
            WorkflowExpression.Validate(__workflow_listlistName, nameof(listlistName), required: true);
            var __workflow_listboardId = listboardId == null ? null : WorkflowExpression.Compile(listboardId);
            WorkflowExpression.Validate(__workflow_listboardId, nameof(listboardId), required: true);
            var __workflow_listlistPosition = listlistPosition == null ? null : WorkflowExpression.Compile(listlistPosition);
            WorkflowExpression.Validate(__workflow_listlistPosition, nameof(listlistPosition), required: false);
            var __workflow_listlistSource = listlistSource == null ? null : WorkflowExpression.Compile(listlistSource);
            WorkflowExpression.Validate(__workflow_listlistSource, nameof(listlistSource), required: false);
            return new DeferredBodyAction<CreateListResponse>(() =>
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var list = new JObject();
                var listpropCount = 0;
                listpropCount++;
                list["name"] = ExpressionConverter.ConvertO(__workflow_listlistName);
                listpropCount++;
                list["idBoard"] = ExpressionConverter.ConvertO(__workflow_listboardId);
                if (__workflow_listlistPosition != null)
                {
                    list["pos"] = ExpressionConverter.ConvertO(__workflow_listlistPosition);
                    listpropCount++;
                }

                if (__workflow_listlistSource != null)
                {
                    list["idListSource"] = ExpressionConverter.ConvertO(__workflow_listlistSource);
                    listpropCount++;
                }

                if (listpropCount > 0)
                {
                    callPayload.Body = list;
                }

                return new ApiConnectionAction<CreateListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Board> CloseBoard(Expression<Func<string>> boardId)
        {
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            return new DeferredBodyAction<Board>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/boards/{0}/closed", ExpressionConverter.ConvertWithUrlEncoding(__workflow_boardId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Board>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Card> CreateCard(Expression<Func<string>> boardId, Expression<Func<string>> newCardparentListId, Expression<Func<string>> newCardcardName, Expression<Func<string>> newCardcardDescription = null, Expression<Func<newCardcardPositionInput>> newCardcardPosition = null, Expression<Func<string[]>> newCardmemberIds = null, Expression<Func<string[]>> newCardlabelIds = null, Expression<Func<string>> newCardsourceUrl = null, Expression<Func<string>> newCardsourceFile = null, Expression<Func<string>> newCardsourceCardId = null, Expression<Func<string>> newCardpropertiesFromSourceCard = null, Expression<Func<string>> newCarddueDate = null)
        {
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            var __workflow_newCardparentListId = newCardparentListId == null ? null : WorkflowExpression.Compile(newCardparentListId);
            WorkflowExpression.Validate(__workflow_newCardparentListId, nameof(newCardparentListId), required: true);
            var __workflow_newCardcardName = newCardcardName == null ? null : WorkflowExpression.Compile(newCardcardName);
            WorkflowExpression.Validate(__workflow_newCardcardName, nameof(newCardcardName), required: true);
            var __workflow_newCardcardDescription = newCardcardDescription == null ? null : WorkflowExpression.Compile(newCardcardDescription);
            WorkflowExpression.Validate(__workflow_newCardcardDescription, nameof(newCardcardDescription), required: false);
            var __workflow_newCardcardPosition = newCardcardPosition == null ? null : WorkflowExpression.Compile(newCardcardPosition);
            WorkflowExpression.Validate(__workflow_newCardcardPosition, nameof(newCardcardPosition), required: false);
            var __workflow_newCardmemberIds = newCardmemberIds == null ? null : WorkflowExpression.Compile(newCardmemberIds);
            WorkflowExpression.Validate(__workflow_newCardmemberIds, nameof(newCardmemberIds), required: false);
            var __workflow_newCardlabelIds = newCardlabelIds == null ? null : WorkflowExpression.Compile(newCardlabelIds);
            WorkflowExpression.Validate(__workflow_newCardlabelIds, nameof(newCardlabelIds), required: false);
            var __workflow_newCardsourceUrl = newCardsourceUrl == null ? null : WorkflowExpression.Compile(newCardsourceUrl);
            WorkflowExpression.Validate(__workflow_newCardsourceUrl, nameof(newCardsourceUrl), required: false);
            var __workflow_newCardsourceFile = newCardsourceFile == null ? null : WorkflowExpression.Compile(newCardsourceFile);
            WorkflowExpression.Validate(__workflow_newCardsourceFile, nameof(newCardsourceFile), required: false);
            var __workflow_newCardsourceCardId = newCardsourceCardId == null ? null : WorkflowExpression.Compile(newCardsourceCardId);
            WorkflowExpression.Validate(__workflow_newCardsourceCardId, nameof(newCardsourceCardId), required: false);
            var __workflow_newCardpropertiesFromSourceCard = newCardpropertiesFromSourceCard == null ? null : WorkflowExpression.Compile(newCardpropertiesFromSourceCard);
            WorkflowExpression.Validate(__workflow_newCardpropertiesFromSourceCard, nameof(newCardpropertiesFromSourceCard), required: false);
            var __workflow_newCarddueDate = newCarddueDate == null ? null : WorkflowExpression.Compile(newCarddueDate);
            WorkflowExpression.Validate(__workflow_newCarddueDate, nameof(newCarddueDate), required: false);
            return new DeferredBodyAction<Card>(() =>
            {
                var apiCallPath = "/v2/cards";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = ExpressionConverter.Convert(__workflow_boardId);
                var newCard = new JObject();
                var newCardpropCount = 0;
                newCardpropCount++;
                newCard["idList"] = ExpressionConverter.ConvertO(__workflow_newCardparentListId);
                newCardpropCount++;
                newCard["name"] = ExpressionConverter.ConvertO(__workflow_newCardcardName);
                if (__workflow_newCardcardDescription != null)
                {
                    newCard["desc"] = ExpressionConverter.ConvertO(__workflow_newCardcardDescription);
                    newCardpropCount++;
                }

                if (__workflow_newCardcardPosition != null)
                {
                    newCard["pos"] = ExpressionConverter.ConvertO(__workflow_newCardcardPosition);
                    newCardpropCount++;
                }

                if (__workflow_newCardmemberIds != null)
                {
                    newCard["idMembersArray"] = ExpressionConverter.ConvertO(__workflow_newCardmemberIds);
                    newCardpropCount++;
                }

                if (__workflow_newCardlabelIds != null)
                {
                    newCard["idLabelsArray"] = ExpressionConverter.ConvertO(__workflow_newCardlabelIds);
                    newCardpropCount++;
                }

                if (__workflow_newCardsourceUrl != null)
                {
                    if (__workflow_newCardsourceUrl != null)
                    {
                        newCard["urlSource"] = ExpressionConverter.ConvertO(__workflow_newCardsourceUrl);
                        newCardpropCount++;
                    }

                    newCardpropCount++;
                }
                else
                {
                    newCard["urlSource"] = "null";
                    newCardpropCount++;
                }

                if (__workflow_newCardsourceFile != null)
                {
                    newCard["fileSource"] = ExpressionConverter.ConvertO(__workflow_newCardsourceFile);
                    newCardpropCount++;
                }

                if (__workflow_newCardsourceCardId != null)
                {
                    newCard["idCardSource"] = ExpressionConverter.ConvertO(__workflow_newCardsourceCardId);
                    newCardpropCount++;
                }

                if (__workflow_newCardpropertiesFromSourceCard != null)
                {
                    newCard["keepFromSource"] = ExpressionConverter.ConvertO(__workflow_newCardpropertiesFromSourceCard);
                    newCardpropCount++;
                }

                if (__workflow_newCarddueDate != null)
                {
                    newCard["due"] = ExpressionConverter.ConvertO(__workflow_newCarddueDate);
                    newCardpropCount++;
                }

                if (newCardpropCount > 0)
                {
                    callPayload.Body = newCard;
                }

                return new ApiConnectionAction<Card>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Card> UpdateCard(Expression<Func<string>> boardId, Expression<Func<string>> cardId, Expression<Func<string>> updateCardname, Expression<Func<string>> updateCarddescription = null, Expression<Func<bool>> updateCardisClosed = null, Expression<Func<string[]>> updateCardmemberIds = null, Expression<Func<string>> updateCardcoverAttachmentIds = null, Expression<Func<string>> updateCardboardId = null, Expression<Func<string>> updateCardlistId = null, Expression<Func<string>> updateCardposition = null, Expression<Func<string>> updateCarddueDate = null, Expression<Func<bool>> updateCardsubscribedToCard = null)
        {
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            var __workflow_cardId = cardId == null ? null : WorkflowExpression.Compile(cardId);
            WorkflowExpression.Validate(__workflow_cardId, nameof(cardId), required: true);
            var __workflow_updateCardname = updateCardname == null ? null : WorkflowExpression.Compile(updateCardname);
            WorkflowExpression.Validate(__workflow_updateCardname, nameof(updateCardname), required: true);
            var __workflow_updateCarddescription = updateCarddescription == null ? null : WorkflowExpression.Compile(updateCarddescription);
            WorkflowExpression.Validate(__workflow_updateCarddescription, nameof(updateCarddescription), required: false);
            var __workflow_updateCardisClosed = updateCardisClosed == null ? null : WorkflowExpression.Compile(updateCardisClosed);
            WorkflowExpression.Validate(__workflow_updateCardisClosed, nameof(updateCardisClosed), required: false);
            var __workflow_updateCardmemberIds = updateCardmemberIds == null ? null : WorkflowExpression.Compile(updateCardmemberIds);
            WorkflowExpression.Validate(__workflow_updateCardmemberIds, nameof(updateCardmemberIds), required: false);
            var __workflow_updateCardcoverAttachmentIds = updateCardcoverAttachmentIds == null ? null : WorkflowExpression.Compile(updateCardcoverAttachmentIds);
            WorkflowExpression.Validate(__workflow_updateCardcoverAttachmentIds, nameof(updateCardcoverAttachmentIds), required: false);
            var __workflow_updateCardboardId = updateCardboardId == null ? null : WorkflowExpression.Compile(updateCardboardId);
            WorkflowExpression.Validate(__workflow_updateCardboardId, nameof(updateCardboardId), required: false);
            var __workflow_updateCardlistId = updateCardlistId == null ? null : WorkflowExpression.Compile(updateCardlistId);
            WorkflowExpression.Validate(__workflow_updateCardlistId, nameof(updateCardlistId), required: false);
            var __workflow_updateCardposition = updateCardposition == null ? null : WorkflowExpression.Compile(updateCardposition);
            WorkflowExpression.Validate(__workflow_updateCardposition, nameof(updateCardposition), required: false);
            var __workflow_updateCarddueDate = updateCarddueDate == null ? null : WorkflowExpression.Compile(updateCarddueDate);
            WorkflowExpression.Validate(__workflow_updateCarddueDate, nameof(updateCarddueDate), required: false);
            var __workflow_updateCardsubscribedToCard = updateCardsubscribedToCard == null ? null : WorkflowExpression.Compile(updateCardsubscribedToCard);
            WorkflowExpression.Validate(__workflow_updateCardsubscribedToCard, nameof(updateCardsubscribedToCard), required: false);
            return new DeferredBodyAction<Card>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/cards/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_cardId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = ExpressionConverter.Convert(__workflow_boardId);
                var updateCard = new JObject();
                var updateCardpropCount = 0;
                updateCardpropCount++;
                updateCard["name"] = ExpressionConverter.ConvertO(__workflow_updateCardname);
                if (__workflow_updateCarddescription != null)
                {
                    updateCard["desc"] = ExpressionConverter.ConvertO(__workflow_updateCarddescription);
                    updateCardpropCount++;
                }

                if (__workflow_updateCardisClosed != null)
                {
                    updateCard["closed"] = ExpressionConverter.ConvertO(__workflow_updateCardisClosed);
                    updateCardpropCount++;
                }

                if (__workflow_updateCardmemberIds != null)
                {
                    updateCard["idMembersArray"] = ExpressionConverter.ConvertO(__workflow_updateCardmemberIds);
                    updateCardpropCount++;
                }

                if (__workflow_updateCardcoverAttachmentIds != null)
                {
                    updateCard["idAttachmentCover"] = ExpressionConverter.ConvertO(__workflow_updateCardcoverAttachmentIds);
                    updateCardpropCount++;
                }

                if (__workflow_updateCardboardId != null)
                {
                    updateCard["idBoard"] = ExpressionConverter.ConvertO(__workflow_updateCardboardId);
                    updateCardpropCount++;
                }

                if (__workflow_updateCardlistId != null)
                {
                    updateCard["idList"] = ExpressionConverter.ConvertO(__workflow_updateCardlistId);
                    updateCardpropCount++;
                }

                if (__workflow_updateCardposition != null)
                {
                    updateCard["pos"] = ExpressionConverter.ConvertO(__workflow_updateCardposition);
                    updateCardpropCount++;
                }

                if (__workflow_updateCarddueDate != null)
                {
                    updateCard["due"] = ExpressionConverter.ConvertO(__workflow_updateCarddueDate);
                    updateCardpropCount++;
                }

                if (__workflow_updateCardsubscribedToCard != null)
                {
                    updateCard["subscribed"] = ExpressionConverter.ConvertO(__workflow_updateCardsubscribedToCard);
                    updateCardpropCount++;
                }

                if (updateCardpropCount > 0)
                {
                    callPayload.Body = updateCard;
                }

                return new ApiConnectionAction<Card>(callPayload);
            });
        }
    }

    public class TrelloTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CardInAction[]> OnNewCardInBoard(Expression<Func<string>> boardId)
        {
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            return new DeferredBodyTrigger<CardInAction[]>(() =>
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

                return new ApiConnectionTrigger<CardInAction[]>(input);
            });
        }

        public IBodyWorkflowTrigger<CardInAction[]> OnNewCardInList(Expression<Func<string>> boardId, Expression<Func<string>> listId)
        {
            var __workflow_boardId = boardId == null ? null : WorkflowExpression.Compile(boardId);
            WorkflowExpression.Validate(__workflow_boardId, nameof(boardId), required: true);
            var __workflow_listId = listId == null ? null : WorkflowExpression.Compile(listId);
            WorkflowExpression.Validate(__workflow_listId, nameof(listId), required: true);
            return new DeferredBodyTrigger<CardInAction[]>(() =>
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
                input.Fetch.Queries["board_id"] = ExpressionConverter.Convert(__workflow_boardId);
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
                input.Subscribe.Queries["board_id"] = ExpressionConverter.Convert(__workflow_boardId);
                var subscription = new JObject();
                var subscriptionpropCount = 0;
                subscription["NotificationURL"] = "#{listCallbackUrl()}";
                subscriptionpropCount++;
                if (subscriptionpropCount > 0)
                {
                    input.Subscribe.Body = subscription;
                }

                return new ApiConnectionTrigger<CardInAction[]>(input);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum checklistsInput
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "none")]
        None
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum cardChecklistsInput
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "none")]
        None
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum boardStarsInput
    {
        [EnumMember(Value = "mine")]
        Mine,
        [EnumMember(Value = "none")]
        None
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum labelsInput
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "none")]
        None
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum boardcreateDefaultListsInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum boardpermissionLevelInput
    {
        [EnumMember(Value = "org")]
        Org,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "public")]
        Public
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum boardinvitationPreferencesInput
    {
        [EnumMember(Value = "admins")]
        Admins,
        [EnumMember(Value = "members")]
        Members
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum boarduseCardCoversInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum boardcardAgingPowerUpPreferencesInput
    {
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "pirate")]
        Pirate,
        [EnumMember(Value = "regular")]
        Regular
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum closedInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum posInput
    {
        [EnumMember(Value = "top")]
        Top,
        [EnumMember(Value = "bottom")]
        Bottom
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum listlistPositionInput
    {
        [EnumMember(Value = "top")]
        Top,
        [EnumMember(Value = "bottom")]
        Bottom
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
