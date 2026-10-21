//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Trello
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TrelloActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Card[]> ListCards(Expression<Func<string>> boardId, Expression<Func<string>> actions = null, Expression<Func<bool>> attachments = null, Expression<Func<string>> attachmentFields = null, Expression<Func<bool>> stickers = null, Expression<Func<bool>> members = null, Expression<Func<string>> memeberFields = null, Expression<Func<bool>> checkItemStates = null, Expression<Func<checklistsInput>> checklists = null, Expression<Func<int>> limit = null, Expression<Func<string>> since = null, Expression<Func<string>> before = null, Expression<Func<filterInput>> filter = null, Expression<Func<string>> fields = null)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_actions = WorkflowExpression.Compile(actions, nameof(actions), required: false);
            var __workflow_attachments = WorkflowExpression.Compile(attachments, nameof(attachments), required: false);
            var __workflow_attachmentFields = WorkflowExpression.Compile(attachmentFields, nameof(attachmentFields), required: false);
            var __workflow_stickers = WorkflowExpression.Compile(stickers, nameof(stickers), required: false);
            var __workflow_members = WorkflowExpression.Compile(members, nameof(members), required: false);
            var __workflow_memeberFields = WorkflowExpression.Compile(memeberFields, nameof(memeberFields), required: false);
            var __workflow_checkItemStates = WorkflowExpression.Compile(checkItemStates, nameof(checkItemStates), required: false);
            var __workflow_checklists = WorkflowExpression.Compile(checklists, nameof(checklists), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_since = WorkflowExpression.Compile(since, nameof(since), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<Card[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/boards/{0}/cards", __workflow_boardId.WithUrlEncoding(1)));
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Card[]> ListCardsSimple(Expression<Func<string>> boardId)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            return new DeferredBodyAction<Card[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/simple/boards/{0}/cards", __workflow_boardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Card[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<CardWithChecklists> GetCard(Expression<Func<string>> boardId, Expression<Func<string>> cardId, Expression<Func<string>> actions = null, Expression<Func<bool>> actionsEntities = null, Expression<Func<bool>> actionsDisplay = null, Expression<Func<int>> actionsLimit = null, Expression<Func<string>> actionFields = null, Expression<Func<string>> actionMemberCreatorFields = null, Expression<Func<bool>> attachments = null, Expression<Func<string>> attachmentFields = null, Expression<Func<bool>> members = null, Expression<Func<string>> memberFields = null, Expression<Func<bool>> membersVoted = null, Expression<Func<string>> memberVotedFields = null, Expression<Func<bool>> checkItemStates = null, Expression<Func<string>> checkItemStateFields = null, Expression<Func<checklistsInput>> checklists = null, Expression<Func<string>> checklistFields = null, Expression<Func<bool>> board = null, Expression<Func<string>> boardFields = null, Expression<Func<bool>> list = null, Expression<Func<string>> listFields = null, Expression<Func<bool>> stickers = null, Expression<Func<string>> stickerFields = null, Expression<Func<string>> fields = null)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            var __workflow_actions = WorkflowExpression.Compile(actions, nameof(actions), required: false);
            var __workflow_actionsEntities = WorkflowExpression.Compile(actionsEntities, nameof(actionsEntities), required: false);
            var __workflow_actionsDisplay = WorkflowExpression.Compile(actionsDisplay, nameof(actionsDisplay), required: false);
            var __workflow_actionsLimit = WorkflowExpression.Compile(actionsLimit, nameof(actionsLimit), required: false);
            var __workflow_actionFields = WorkflowExpression.Compile(actionFields, nameof(actionFields), required: false);
            var __workflow_actionMemberCreatorFields = WorkflowExpression.Compile(actionMemberCreatorFields, nameof(actionMemberCreatorFields), required: false);
            var __workflow_attachments = WorkflowExpression.Compile(attachments, nameof(attachments), required: false);
            var __workflow_attachmentFields = WorkflowExpression.Compile(attachmentFields, nameof(attachmentFields), required: false);
            var __workflow_members = WorkflowExpression.Compile(members, nameof(members), required: false);
            var __workflow_memberFields = WorkflowExpression.Compile(memberFields, nameof(memberFields), required: false);
            var __workflow_membersVoted = WorkflowExpression.Compile(membersVoted, nameof(membersVoted), required: false);
            var __workflow_memberVotedFields = WorkflowExpression.Compile(memberVotedFields, nameof(memberVotedFields), required: false);
            var __workflow_checkItemStates = WorkflowExpression.Compile(checkItemStates, nameof(checkItemStates), required: false);
            var __workflow_checkItemStateFields = WorkflowExpression.Compile(checkItemStateFields, nameof(checkItemStateFields), required: false);
            var __workflow_checklists = WorkflowExpression.Compile(checklists, nameof(checklists), required: false);
            var __workflow_checklistFields = WorkflowExpression.Compile(checklistFields, nameof(checklistFields), required: false);
            var __workflow_board = WorkflowExpression.Compile(board, nameof(board), required: false);
            var __workflow_boardFields = WorkflowExpression.Compile(boardFields, nameof(boardFields), required: false);
            var __workflow_list = WorkflowExpression.Compile(list, nameof(list), required: false);
            var __workflow_listFields = WorkflowExpression.Compile(listFields, nameof(listFields), required: false);
            var __workflow_stickers = WorkflowExpression.Compile(stickers, nameof(stickers), required: false);
            var __workflow_stickerFields = WorkflowExpression.Compile(stickerFields, nameof(stickerFields), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<CardWithChecklists>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/cards/{0}", __workflow_cardId.WithUrlEncoding(1)));
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<JToken> DeleteCard(Expression<Func<string>> boardId, Expression<Func<string>> cardId)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/cards/{0}", __workflow_cardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = ExpressionConverter.Convert(__workflow_boardId);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Board[]> ListBoards(Expression<Func<string>> filter = null, Expression<Func<string>> fields = null, Expression<Func<string>> actions = null, Expression<Func<bool>> actionsEntities = null, Expression<Func<int>> actionsLimit = null, Expression<Func<actionsFormatInput>> actionsFormat = null, Expression<Func<string>> actionsSince = null, Expression<Func<string>> actionFields = null, Expression<Func<string>> memberships = null, Expression<Func<bool>> organization = null, Expression<Func<string>> organizationFields = null, Expression<Func<string>> lists = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_actions = WorkflowExpression.Compile(actions, nameof(actions), required: false);
            var __workflow_actionsEntities = WorkflowExpression.Compile(actionsEntities, nameof(actionsEntities), required: false);
            var __workflow_actionsLimit = WorkflowExpression.Compile(actionsLimit, nameof(actionsLimit), required: false);
            var __workflow_actionsFormat = WorkflowExpression.Compile(actionsFormat, nameof(actionsFormat), required: false);
            var __workflow_actionsSince = WorkflowExpression.Compile(actionsSince, nameof(actionsSince), required: false);
            var __workflow_actionFields = WorkflowExpression.Compile(actionFields, nameof(actionFields), required: false);
            var __workflow_memberships = WorkflowExpression.Compile(memberships, nameof(memberships), required: false);
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: false);
            var __workflow_organizationFields = WorkflowExpression.Compile(organizationFields, nameof(organizationFields), required: false);
            var __workflow_lists = WorkflowExpression.Compile(lists, nameof(lists), required: false);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_actions = WorkflowExpression.Compile(actions, nameof(actions), required: false);
            var __workflow_actionEntities = WorkflowExpression.Compile(actionEntities, nameof(actionEntities), required: false);
            var __workflow_actionsDisplay = WorkflowExpression.Compile(actionsDisplay, nameof(actionsDisplay), required: false);
            var __workflow_actionsFormat = WorkflowExpression.Compile(actionsFormat, nameof(actionsFormat), required: false);
            var __workflow_actionsSince = WorkflowExpression.Compile(actionsSince, nameof(actionsSince), required: false);
            var __workflow_actionsLimit = WorkflowExpression.Compile(actionsLimit, nameof(actionsLimit), required: false);
            var __workflow_actionFields = WorkflowExpression.Compile(actionFields, nameof(actionFields), required: false);
            var __workflow_actionMember = WorkflowExpression.Compile(actionMember, nameof(actionMember), required: false);
            var __workflow_actionMemberFields = WorkflowExpression.Compile(actionMemberFields, nameof(actionMemberFields), required: false);
            var __workflow_actionMemberCreator = WorkflowExpression.Compile(actionMemberCreator, nameof(actionMemberCreator), required: false);
            var __workflow_actionMemberCreatorFields = WorkflowExpression.Compile(actionMemberCreatorFields, nameof(actionMemberCreatorFields), required: false);
            var __workflow_cards = WorkflowExpression.Compile(cards, nameof(cards), required: false);
            var __workflow_cardFields = WorkflowExpression.Compile(cardFields, nameof(cardFields), required: false);
            var __workflow_cardAttachments = WorkflowExpression.Compile(cardAttachments, nameof(cardAttachments), required: false);
            var __workflow_cardAttachmentFields = WorkflowExpression.Compile(cardAttachmentFields, nameof(cardAttachmentFields), required: false);
            var __workflow_cardChecklists = WorkflowExpression.Compile(cardChecklists, nameof(cardChecklists), required: false);
            var __workflow_cardStickers = WorkflowExpression.Compile(cardStickers, nameof(cardStickers), required: false);
            var __workflow_boardStars = WorkflowExpression.Compile(boardStars, nameof(boardStars), required: false);
            var __workflow_labels = WorkflowExpression.Compile(labels, nameof(labels), required: false);
            var __workflow_labelFields = WorkflowExpression.Compile(labelFields, nameof(labelFields), required: false);
            var __workflow_labelsLimit = WorkflowExpression.Compile(labelsLimit, nameof(labelsLimit), required: false);
            var __workflow_lists = WorkflowExpression.Compile(lists, nameof(lists), required: false);
            var __workflow_listFields = WorkflowExpression.Compile(listFields, nameof(listFields), required: false);
            var __workflow_memberships = WorkflowExpression.Compile(memberships, nameof(memberships), required: false);
            var __workflow_membershipsMember = WorkflowExpression.Compile(membershipsMember, nameof(membershipsMember), required: false);
            var __workflow_membershipsMemberFields = WorkflowExpression.Compile(membershipsMemberFields, nameof(membershipsMemberFields), required: false);
            var __workflow_members = WorkflowExpression.Compile(members, nameof(members), required: false);
            var __workflow_memberFields = WorkflowExpression.Compile(memberFields, nameof(memberFields), required: false);
            var __workflow_membersInvited = WorkflowExpression.Compile(membersInvited, nameof(membersInvited), required: false);
            var __workflow_membersInvitedFields = WorkflowExpression.Compile(membersInvitedFields, nameof(membersInvitedFields), required: false);
            var __workflow_checklists = WorkflowExpression.Compile(checklists, nameof(checklists), required: false);
            var __workflow_checklistFields = WorkflowExpression.Compile(checklistFields, nameof(checklistFields), required: false);
            var __workflow_organization = WorkflowExpression.Compile(organization, nameof(organization), required: false);
            var __workflow_organizationFields = WorkflowExpression.Compile(organizationFields, nameof(organizationFields), required: false);
            var __workflow_organizationMemberships = WorkflowExpression.Compile(organizationMemberships, nameof(organizationMemberships), required: false);
            var __workflow_myPerfs = WorkflowExpression.Compile(myPerfs, nameof(myPerfs), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<BoardWithChecklists>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/boards/{0}", __workflow_boardId.WithUrlEncoding(1)));
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Board> UpdateBoard(Expression<Func<string>> boardId, Expression<Func<string>> boardboardName = null, Expression<Func<boardcreateDefaultListsInput>> boardcreateDefaultLists = null, Expression<Func<string>> boardboardDescription = null, Expression<Func<string>> boardteamId = null, Expression<Func<boardpermissionLevelInput>> boardpermissionLevel = null, Expression<Func<boardcommentPreferencesInput>> boardcommentPreferences = null, Expression<Func<boardinvitationPreferencesInput>> boardinvitationPreferences = null, Expression<Func<boarduseCardCoversInput>> boarduseCardCovers = null, Expression<Func<boardbackgroundColorInput>> boardbackgroundColor = null, Expression<Func<boardvotingPowerUpPreferencesInput>> boardvotingPowerUpPreferences = null, Expression<Func<boardcardAgingPowerUpPreferencesInput>> boardcardAgingPowerUpPreferences = null, Expression<Func<boardenableCalendarPowerUpInput>> boardenableCalendarPowerUp = null)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_boardboardName = WorkflowExpression.Compile(boardboardName, nameof(boardboardName), required: false);
            var __workflow_boardcreateDefaultLists = WorkflowExpression.Compile(boardcreateDefaultLists, nameof(boardcreateDefaultLists), required: false);
            var __workflow_boardboardDescription = WorkflowExpression.Compile(boardboardDescription, nameof(boardboardDescription), required: false);
            var __workflow_boardteamId = WorkflowExpression.Compile(boardteamId, nameof(boardteamId), required: false);
            var __workflow_boardpermissionLevel = WorkflowExpression.Compile(boardpermissionLevel, nameof(boardpermissionLevel), required: false);
            var __workflow_boardcommentPreferences = WorkflowExpression.Compile(boardcommentPreferences, nameof(boardcommentPreferences), required: false);
            var __workflow_boardinvitationPreferences = WorkflowExpression.Compile(boardinvitationPreferences, nameof(boardinvitationPreferences), required: false);
            var __workflow_boarduseCardCovers = WorkflowExpression.Compile(boarduseCardCovers, nameof(boarduseCardCovers), required: false);
            var __workflow_boardbackgroundColor = WorkflowExpression.Compile(boardbackgroundColor, nameof(boardbackgroundColor), required: false);
            var __workflow_boardvotingPowerUpPreferences = WorkflowExpression.Compile(boardvotingPowerUpPreferences, nameof(boardvotingPowerUpPreferences), required: false);
            var __workflow_boardcardAgingPowerUpPreferences = WorkflowExpression.Compile(boardcardAgingPowerUpPreferences, nameof(boardcardAgingPowerUpPreferences), required: false);
            var __workflow_boardenableCalendarPowerUp = WorkflowExpression.Compile(boardenableCalendarPowerUp, nameof(boardenableCalendarPowerUp), required: false);
            return new DeferredBodyAction<Board>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/boards/{0}", __workflow_boardId.WithUrlEncoding(1)));
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<List[]> ListLists(Expression<Func<string>> boardId, Expression<Func<cardsInput>> cards = null, Expression<Func<string>> cardFields = null, Expression<Func<filterInput>> filter = null, Expression<Func<string>> fields = null)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_cards = WorkflowExpression.Compile(cards, nameof(cards), required: false);
            var __workflow_cardFields = WorkflowExpression.Compile(cardFields, nameof(cardFields), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<List[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/boards/{0}/lists", __workflow_boardId.WithUrlEncoding(1)));
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<List[]> ListListsSimple(Expression<Func<string>> boardId)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            return new DeferredBodyAction<List[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/simple/boards/{0}/lists", __workflow_boardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<List[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<List> GetList(Expression<Func<string>> boardId, Expression<Func<string>> listId, Expression<Func<cardsInput>> cards = null, Expression<Func<string>> cardFields = null, Expression<Func<bool>> board = null, Expression<Func<string>> boardFields = null, Expression<Func<string>> fields = null)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_cards = WorkflowExpression.Compile(cards, nameof(cards), required: false);
            var __workflow_cardFields = WorkflowExpression.Compile(cardFields, nameof(cardFields), required: false);
            var __workflow_board = WorkflowExpression.Compile(board, nameof(board), required: false);
            var __workflow_boardFields = WorkflowExpression.Compile(boardFields, nameof(boardFields), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<List>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}", __workflow_listId.WithUrlEncoding(1)));
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<CreateListResponse> UpdateList(Expression<Func<string>> boardId, Expression<Func<string>> listId, Expression<Func<string>> name = null, Expression<Func<closedInput>> closed = null, Expression<Func<string>> idBoard = null, Expression<Func<posInput>> pos = null, Expression<Func<subscribedInput>> subscribed = null)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_closed = WorkflowExpression.Compile(closed, nameof(closed), required: false);
            var __workflow_idBoard = WorkflowExpression.Compile(idBoard, nameof(idBoard), required: false);
            var __workflow_pos = WorkflowExpression.Compile(pos, nameof(pos), required: false);
            var __workflow_subscribed = WorkflowExpression.Compile(subscribed, nameof(subscribed), required: false);
            return new DeferredBodyAction<CreateListResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}", __workflow_listId.WithUrlEncoding(1)));
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<JToken> GetUserProfile(Expression<Func<string>> fields = null)
        {
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/members/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            return new DeferredBodyAction<Member[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/organizations/{0}/members", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Member[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Member[]> ListBoardMembers(Expression<Func<string>> boardId)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            return new DeferredBodyAction<Member[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/boards/{0}/members", __workflow_boardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Member[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<BoardLabel[]> ListBoardLabels(Expression<Func<string>> boardId)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            return new DeferredBodyAction<BoardLabel[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/boards/{0}/labels", __workflow_boardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                return new ApiConnectionAction<BoardLabel[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Team> GetTeamForBoard(Expression<Func<string>> boardId)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            return new DeferredBodyAction<Team>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/boards/{0}/organization", __workflow_boardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Team>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Member[]> ListCardMembers(Expression<Func<string>> boardId, Expression<Func<string>> cardId)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            return new DeferredBodyAction<Member[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/cards/{0}/members", __workflow_cardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = ExpressionConverter.Convert(__workflow_boardId);
                return new ApiConnectionAction<Member[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Comment[]> ListCardComments(Expression<Func<string>> boardId, Expression<Func<string>> cardId)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            return new DeferredBodyAction<Comment[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/cards/{0}/actions", __workflow_cardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = ExpressionConverter.Convert(__workflow_boardId);
                return new ApiConnectionAction<Comment[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Comment> AddCommentToCard(Expression<Func<string>> boardId, Expression<Func<string>> cardId, Expression<Func<string>> commentcommentText = null)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            var __workflow_commentcommentText = WorkflowExpression.Compile(commentcommentText, nameof(commentcommentText), required: false);
            return new DeferredBodyAction<Comment>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/cards/{0}/actions/comments", __workflow_cardId.WithUrlEncoding(1)));
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Member[]> AddMemberToCard(Expression<Func<string>> boardId, Expression<Func<string>> cardId, Expression<Func<string>> memberId)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            var __workflow_memberId = WorkflowExpression.Compile(memberId, nameof(memberId), required: true);
            return new DeferredBodyAction<Member[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/cards/{0}/idMembers", __workflow_cardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_id"] = ExpressionConverter.Convert(__workflow_boardId);
                callPayload.Queries["memberId"] = ExpressionConverter.Convert(__workflow_memberId);
                return new ApiConnectionAction<Member[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Board> CreateBoard(Expression<Func<string>> boardboardName, Expression<Func<boardcreateDefaultListsInput>> boardcreateDefaultLists = null, Expression<Func<string>> boardboardDescription = null, Expression<Func<string>> boardteamId = null, Expression<Func<boardpermissionLevelInput>> boardpermissionLevel = null, Expression<Func<boardcommentPreferencesInput>> boardcommentPreferences = null, Expression<Func<boardinvitationPreferencesInput>> boardinvitationPreferences = null, Expression<Func<boarduseCardCoversInput>> boarduseCardCovers = null, Expression<Func<boardbackgroundColorInput>> boardbackgroundColor = null, Expression<Func<boardvotingPowerUpPreferencesInput>> boardvotingPowerUpPreferences = null, Expression<Func<boardcardAgingPowerUpPreferencesInput>> boardcardAgingPowerUpPreferences = null, Expression<Func<boardenableCalendarPowerUpInput>> boardenableCalendarPowerUp = null)
        {
            var __workflow_boardboardName = WorkflowExpression.Compile(boardboardName, nameof(boardboardName), required: true);
            var __workflow_boardcreateDefaultLists = WorkflowExpression.Compile(boardcreateDefaultLists, nameof(boardcreateDefaultLists), required: false);
            var __workflow_boardboardDescription = WorkflowExpression.Compile(boardboardDescription, nameof(boardboardDescription), required: false);
            var __workflow_boardteamId = WorkflowExpression.Compile(boardteamId, nameof(boardteamId), required: false);
            var __workflow_boardpermissionLevel = WorkflowExpression.Compile(boardpermissionLevel, nameof(boardpermissionLevel), required: false);
            var __workflow_boardcommentPreferences = WorkflowExpression.Compile(boardcommentPreferences, nameof(boardcommentPreferences), required: false);
            var __workflow_boardinvitationPreferences = WorkflowExpression.Compile(boardinvitationPreferences, nameof(boardinvitationPreferences), required: false);
            var __workflow_boarduseCardCovers = WorkflowExpression.Compile(boarduseCardCovers, nameof(boarduseCardCovers), required: false);
            var __workflow_boardbackgroundColor = WorkflowExpression.Compile(boardbackgroundColor, nameof(boardbackgroundColor), required: false);
            var __workflow_boardvotingPowerUpPreferences = WorkflowExpression.Compile(boardvotingPowerUpPreferences, nameof(boardvotingPowerUpPreferences), required: false);
            var __workflow_boardcardAgingPowerUpPreferences = WorkflowExpression.Compile(boardcardAgingPowerUpPreferences, nameof(boardcardAgingPowerUpPreferences), required: false);
            var __workflow_boardenableCalendarPowerUp = WorkflowExpression.Compile(boardenableCalendarPowerUp, nameof(boardenableCalendarPowerUp), required: false);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<CreateListResponse> CreateList(Expression<Func<string>> listlistName, Expression<Func<string>> listboardId, Expression<Func<listlistPositionInput>> listlistPosition = null, Expression<Func<string>> listlistSource = null)
        {
            var __workflow_listlistName = WorkflowExpression.Compile(listlistName, nameof(listlistName), required: true);
            var __workflow_listboardId = WorkflowExpression.Compile(listboardId, nameof(listboardId), required: true);
            var __workflow_listlistPosition = WorkflowExpression.Compile(listlistPosition, nameof(listlistPosition), required: false);
            var __workflow_listlistSource = WorkflowExpression.Compile(listlistSource, nameof(listlistSource), required: false);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Board> CloseBoard(Expression<Func<string>> boardId)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            return new DeferredBodyAction<Board>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/boards/{0}/closed", __workflow_boardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Board>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Card> CreateCard(Expression<Func<string>> boardId, Expression<Func<string>> newCardparentListId, Expression<Func<string>> newCardcardName, Expression<Func<string>> newCardcardDescription = null, Expression<Func<newCardcardPositionInput>> newCardcardPosition = null, Expression<Func<string[]>> newCardmemberIds = null, Expression<Func<string[]>> newCardlabelIds = null, Expression<Func<string>> newCardsourceUrl = null, Expression<Func<string>> newCardsourceFile = null, Expression<Func<string>> newCardsourceCardId = null, Expression<Func<string>> newCardpropertiesFromSourceCard = null, Expression<Func<string>> newCarddueDate = null)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_newCardparentListId = WorkflowExpression.Compile(newCardparentListId, nameof(newCardparentListId), required: true);
            var __workflow_newCardcardName = WorkflowExpression.Compile(newCardcardName, nameof(newCardcardName), required: true);
            var __workflow_newCardcardDescription = WorkflowExpression.Compile(newCardcardDescription, nameof(newCardcardDescription), required: false);
            var __workflow_newCardcardPosition = WorkflowExpression.Compile(newCardcardPosition, nameof(newCardcardPosition), required: false);
            var __workflow_newCardmemberIds = WorkflowExpression.Compile(newCardmemberIds, nameof(newCardmemberIds), required: false);
            var __workflow_newCardlabelIds = WorkflowExpression.Compile(newCardlabelIds, nameof(newCardlabelIds), required: false);
            var __workflow_newCardsourceUrl = WorkflowExpression.Compile(newCardsourceUrl, nameof(newCardsourceUrl), required: false);
            var __workflow_newCardsourceFile = WorkflowExpression.Compile(newCardsourceFile, nameof(newCardsourceFile), required: false);
            var __workflow_newCardsourceCardId = WorkflowExpression.Compile(newCardsourceCardId, nameof(newCardsourceCardId), required: false);
            var __workflow_newCardpropertiesFromSourceCard = WorkflowExpression.Compile(newCardpropertiesFromSourceCard, nameof(newCardpropertiesFromSourceCard), required: false);
            var __workflow_newCarddueDate = WorkflowExpression.Compile(newCarddueDate, nameof(newCarddueDate), required: false);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "trello")]
        public IBodyWorkflowAction<Card> UpdateCard(Expression<Func<string>> boardId, Expression<Func<string>> cardId, Expression<Func<string>> updateCardname, Expression<Func<string>> updateCarddescription = null, Expression<Func<bool>> updateCardisClosed = null, Expression<Func<string[]>> updateCardmemberIds = null, Expression<Func<string>> updateCardcoverAttachmentIds = null, Expression<Func<string>> updateCardboardId = null, Expression<Func<string>> updateCardlistId = null, Expression<Func<string>> updateCardposition = null, Expression<Func<string>> updateCarddueDate = null, Expression<Func<bool>> updateCardsubscribedToCard = null)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            var __workflow_updateCardname = WorkflowExpression.Compile(updateCardname, nameof(updateCardname), required: true);
            var __workflow_updateCarddescription = WorkflowExpression.Compile(updateCarddescription, nameof(updateCarddescription), required: false);
            var __workflow_updateCardisClosed = WorkflowExpression.Compile(updateCardisClosed, nameof(updateCardisClosed), required: false);
            var __workflow_updateCardmemberIds = WorkflowExpression.Compile(updateCardmemberIds, nameof(updateCardmemberIds), required: false);
            var __workflow_updateCardcoverAttachmentIds = WorkflowExpression.Compile(updateCardcoverAttachmentIds, nameof(updateCardcoverAttachmentIds), required: false);
            var __workflow_updateCardboardId = WorkflowExpression.Compile(updateCardboardId, nameof(updateCardboardId), required: false);
            var __workflow_updateCardlistId = WorkflowExpression.Compile(updateCardlistId, nameof(updateCardlistId), required: false);
            var __workflow_updateCardposition = WorkflowExpression.Compile(updateCardposition, nameof(updateCardposition), required: false);
            var __workflow_updateCarddueDate = WorkflowExpression.Compile(updateCarddueDate, nameof(updateCarddueDate), required: false);
            var __workflow_updateCardsubscribedToCard = WorkflowExpression.Compile(updateCardsubscribedToCard, nameof(updateCardsubscribedToCard), required: false);
            return new DeferredBodyAction<Card>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/cards/{0}", __workflow_cardId.WithUrlEncoding(1)));
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class TrelloTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CardInAction[]> OnNewCardInBoard(Expression<Func<string>> boardId)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<CardInAction[]> OnNewCardInList(Expression<Func<string>> boardId, Expression<Func<string>> listId)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
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
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
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
