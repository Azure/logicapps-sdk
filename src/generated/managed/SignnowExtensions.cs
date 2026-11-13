//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Signnow
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SignnowActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteDocGroupEmbeddedInvites(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/documentgroup/{0}/embedded-invites", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateDocGroupEmbeddedInvitesResponse, ApiConnectionActionConfiguration> CreateDocGroupEmbeddedInvites(Expression<Func<string>> id, Expression<Func<CreateDocGroupEmbeddedInvitesInviteInput>> invite)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_invite = WorkflowExpression.Compile(invite, nameof(invite), required: true);
            return new DeferredBodyAction<CreateDocGroupEmbeddedInvitesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/documentgroup/{0}/embedded-invites", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_invite);
                return new ApiConnectionAction<CreateDocGroupEmbeddedInvitesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<GenerateDocGroupEmbeddedInviteLinkResponse, ApiConnectionActionConfiguration> GenerateDocGroupEmbeddedInviteLink(Expression<Func<string>> id, Expression<Func<string>> inviteId, Expression<Func<GenerateDocGroupEmbeddedInviteLinkInviteInput>> invite)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_inviteId = WorkflowExpression.Compile(inviteId, nameof(inviteId), required: true);
            var __workflow_invite = WorkflowExpression.Compile(invite, nameof(invite), required: true);
            return new DeferredBodyAction<GenerateDocGroupEmbeddedInviteLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/documentgroup/{0}/embedded-invites/{1}/link", __workflow_id.WithUrlEncoding(1), __workflow_inviteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_invite);
                return new ApiConnectionAction<GenerateDocGroupEmbeddedInviteLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteEmbeddedInvites(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/documents/{0}/embedded-invites", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateEmbeddedInvitesResponse, ApiConnectionActionConfiguration> CreateEmbeddedInvites(Expression<Func<string>> id, Expression<Func<CreateEmbeddedInvitesInviteInput>> invite)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_invite = WorkflowExpression.Compile(invite, nameof(invite), required: true);
            return new DeferredBodyAction<CreateEmbeddedInvitesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/documents/{0}/embedded-invites", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_invite);
                return new ApiConnectionAction<CreateEmbeddedInvitesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<GenerateEmbeddedInviteLinkResponse, ApiConnectionActionConfiguration> GenerateEmbeddedInviteLink(Expression<Func<string>> id, Expression<Func<string>> fieldInviteId, Expression<Func<GenerateEmbeddedInviteLinkInviteInput>> invite)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_fieldInviteId = WorkflowExpression.Compile(fieldInviteId, nameof(fieldInviteId), required: true);
            var __workflow_invite = WorkflowExpression.Compile(invite, nameof(invite), required: true);
            return new DeferredBodyAction<GenerateEmbeddedInviteLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/documents/{0}/embedded-invites/{1}/link", __workflow_id.WithUrlEncoding(1), __workflow_fieldInviteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_invite);
                return new ApiConnectionAction<GenerateEmbeddedInviteLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<DocumentGroupsResponse, ApiConnectionActionConfiguration> GetListDocGroups(Expression<Func<bool>> template, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<DocumentGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/documentgroups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<DocumentGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateDocumentGroupFromFilesResponse, ApiConnectionActionConfiguration> CreateDocGroupFromFiles(Expression<Func<CreateDocGroupFromFilesBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateDocumentGroupFromFilesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/documentgroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateDocumentGroupFromFilesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<DocumentGroupProperties, ApiConnectionActionConfiguration> GetDocumentGroup(Expression<Func<string>> docGroupId, Expression<Func<bool>> template)
        {
            var __workflow_docGroupId = WorkflowExpression.Compile(docGroupId, nameof(docGroupId), required: true);
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: true);
            return new DeferredBodyAction<DocumentGroupProperties, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/documentgroups/{0}", __workflow_docGroupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                return new ApiConnectionAction<DocumentGroupProperties>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateFromTemplateGroupResponse, ApiConnectionActionConfiguration> CreateFromTemplateGroup(Expression<Func<string>> docGroupId, Expression<Func<CreateFromTemplateGroupBodyInput>> body = null)
        {
            var __workflow_docGroupId = WorkflowExpression.Compile(docGroupId, nameof(docGroupId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateFromTemplateGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/documentgroups/{0}", __workflow_docGroupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateFromTemplateGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<UpdateGroupFieldValuesResponse, ApiConnectionActionConfiguration> UpdateGroupFieldValues(Expression<Func<string>> templateGroupId, Expression<Func<string>> docGroupId, Expression<Func<object>> fields = null)
        {
            var __workflow_templateGroupId = WorkflowExpression.Compile(templateGroupId, nameof(templateGroupId), required: true);
            var __workflow_docGroupId = WorkflowExpression.Compile(docGroupId, nameof(docGroupId), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<UpdateGroupFieldValuesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/documentgroup/{0}/fields", __workflow_docGroupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_group_id"] = ExpressionConverter.Convert(__workflow_templateGroupId);
                if (__workflow_fields != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_fields);
                return new ApiConnectionAction<UpdateGroupFieldValuesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<UpdateGroupSmartFieldValuesResponse, ApiConnectionActionConfiguration> UpdateGroupSmartFieldValues(Expression<Func<string>> templateGroupId, Expression<Func<string>> docGroupId, Expression<Func<object>> fields = null)
        {
            var __workflow_templateGroupId = WorkflowExpression.Compile(templateGroupId, nameof(templateGroupId), required: true);
            var __workflow_docGroupId = WorkflowExpression.Compile(docGroupId, nameof(docGroupId), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<UpdateGroupSmartFieldValuesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/documentgroup/{0}/smartfields", __workflow_docGroupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_group_id"] = ExpressionConverter.Convert(__workflow_templateGroupId);
                if (__workflow_fields != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_fields);
                return new ApiConnectionAction<UpdateGroupSmartFieldValuesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<DocumentProperties[], ApiConnectionActionConfiguration> GetListDoc(Expression<Func<bool>> template = null, Expression<Func<bool>> includeDefaultTemplate = null)
        {
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: false);
            var __workflow_includeDefaultTemplate = WorkflowExpression.Compile(includeDefaultTemplate, nameof(includeDefaultTemplate), required: false);
            return new DeferredBodyAction<DocumentProperties[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/document";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_template != null)
                    callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                if (__workflow_includeDefaultTemplate != null)
                    callPayload.Queries["includeDefaultTemplate"] = ExpressionConverter.Convert(__workflow_includeDefaultTemplate);
                callPayload.Queries["excludeDocumentRelations"] = Convert.ToString(false);
                return new ApiConnectionAction<DocumentProperties[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<DocumentProperties, ApiConnectionActionConfiguration> GetDoc(Expression<Func<bool>> template, Expression<Func<string>> docId)
        {
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: true);
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            return new DeferredBodyAction<DocumentProperties, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                return new ApiConnectionAction<DocumentProperties>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<DeleteDocResponse, ApiConnectionActionConfiguration> DeleteDoc(Expression<Func<string>> docId)
        {
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            return new DeferredBodyAction<DeleteDocResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteDocResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateFromTemplateResponse, ApiConnectionActionConfiguration> CreateFromTemplate(Expression<Func<string>> docId, Expression<Func<CreateFromTemplateBodyInput>> body = null)
        {
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateFromTemplateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateFromTemplateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateSigningLinkResponse, ApiConnectionActionConfiguration> CreateSigningLink(Expression<Func<string>> docId, Expression<Func<object>> fields = null)
        {
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<CreateSigningLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}/link", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fields != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_fields);
                return new ApiConnectionAction<CreateSigningLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> SendInvite(Expression<Func<bool>> template, Expression<Func<string>> templateId, Expression<Func<object>> body)
        {
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}/invite", __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> SendGroupInvite(Expression<Func<bool>> template, Expression<Func<string>> templateGroupId, Expression<Func<object>> body)
        {
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: true);
            var __workflow_templateGroupId = WorkflowExpression.Compile(templateGroupId, nameof(templateGroupId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/documentgroup/{0}/invite", __workflow_templateGroupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> SendUserDefinedInvite(Expression<Func<string>> docId, Expression<Func<SendUserDefinedInviteBodyInput>> body = null)
        {
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}/invite-user-defined-schema", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CancelInvite(Expression<Func<string>> docId)
        {
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}/invite-cancel", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DownloadDocument(Expression<Func<string>> docId, Expression<Func<string>> mode = null)
        {
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            var __workflow_mode = WorkflowExpression.Compile(mode, nameof(mode), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}/download", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mode"] = Convert.ToString("Collapsed");
                if (__workflow_mode != null)
                    callPayload.Queries["mode"] = ExpressionConverter.Convert(__workflow_mode);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PrefillSmartFields(Expression<Func<string>> templateId, Expression<Func<string>> docId, Expression<Func<object>> fields = null)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}/smartfields", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_id"] = ExpressionConverter.Convert(__workflow_templateId);
                if (__workflow_fields != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_fields);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<GetInviteStatusResponse, ApiConnectionActionConfiguration> GetInviteStatus(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetInviteStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}/invite-status", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetInviteStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<GetDocumentGroupInviteStatusResponse, ApiConnectionActionConfiguration> GetDocumentGroupInviteStatus(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetDocumentGroupInviteStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/documentgroups/{0}/invite-status", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentGroupInviteStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<ReplaceRecipientsInDocumentInviteResponse, ApiConnectionActionConfiguration> ReplaceRecipientsInDocumentInvite(Expression<Func<string>> id, Expression<Func<ReplaceRecipientsInDocumentInviteReplaceToInput>> replaceTo)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_replaceTo = WorkflowExpression.Compile(replaceTo, nameof(replaceTo), required: true);
            return new DeferredBodyAction<ReplaceRecipientsInDocumentInviteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}/replace-recipients", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_replaceTo);
                return new ApiConnectionAction<ReplaceRecipientsInDocumentInviteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<ReplaceRecipientsInDocumentGroupInviteResponse, ApiConnectionActionConfiguration> ReplaceRecipientsInDocumentGroupInvite(Expression<Func<string>> id, Expression<Func<string>> inviteId, Expression<Func<ReplaceRecipientsInDocumentGroupInviteReplaceToInput>> replaceTo)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_inviteId = WorkflowExpression.Compile(inviteId, nameof(inviteId), required: true);
            var __workflow_replaceTo = WorkflowExpression.Compile(replaceTo, nameof(replaceTo), required: true);
            return new DeferredBodyAction<ReplaceRecipientsInDocumentGroupInviteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/documentgroup/{0}/invite/{1}/replace-recipients", __workflow_id.WithUrlEncoding(1), __workflow_inviteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_replaceTo);
                return new ApiConnectionAction<ReplaceRecipientsInDocumentGroupInviteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateEmbeddedInviteSettingsLinkResponse, ApiConnectionActionConfiguration> CreateEmbeddedInviteSettingsLink(Expression<Func<string>> id, Expression<Func<CreateEmbeddedInviteSettingsLinkInviteSettingsInput>> inviteSettings)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_inviteSettings = WorkflowExpression.Compile(inviteSettings, nameof(inviteSettings), required: true);
            return new DeferredBodyAction<CreateEmbeddedInviteSettingsLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/documents/{0}/embedded-sending", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inviteSettings);
                return new ApiConnectionAction<CreateEmbeddedInviteSettingsLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateDocGroupEmbeddedInviteSettingsLinkResponse, ApiConnectionActionConfiguration> CreateDocGroupEmbeddedInviteSettingsLink(Expression<Func<string>> id, Expression<Func<CreateDocGroupEmbeddedInviteSettingsLinkInviteSettingsInput>> inviteSettings)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_inviteSettings = WorkflowExpression.Compile(inviteSettings, nameof(inviteSettings), required: true);
            return new DeferredBodyAction<CreateDocGroupEmbeddedInviteSettingsLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/documentgroup/{0}/embedded-sending", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_inviteSettings);
                return new ApiConnectionAction<CreateDocGroupEmbeddedInviteSettingsLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<InviteToSignAllOptionsResponse, ApiConnectionActionConfiguration> InviteToSignAllOptions(Expression<Func<string>> id, Expression<Func<InviteToSignAllOptionsInviteInput>> invite)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_invite = WorkflowExpression.Compile(invite, nameof(invite), required: true);
            return new DeferredBodyAction<InviteToSignAllOptionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}/invite-all-options", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_invite);
                return new ApiConnectionAction<InviteToSignAllOptionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<InviteToSignDocGroupAllOptionsResponse, ApiConnectionActionConfiguration> InviteToSignDocGroupAllOptions(Expression<Func<string>> id, Expression<Func<InviteToSignDocGroupAllOptionsInviteInput>> invite)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_invite = WorkflowExpression.Compile(invite, nameof(invite), required: true);
            return new DeferredBodyAction<InviteToSignDocGroupAllOptionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/documentgroup/{0}/invite-all-options", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_invite);
                return new ApiConnectionAction<InviteToSignDocGroupAllOptionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetDocFields(Expression<Func<string>> templateId, Expression<Func<string>> docId)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/document/{0}/fields", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_id"] = ExpressionConverter.Convert(__workflow_templateId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<UpdateFieldValuesResponse, ApiConnectionActionConfiguration> UpdateFieldValues(Expression<Func<string>> templateId, Expression<Func<string>> docId, Expression<Func<object>> fields = null)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<UpdateFieldValuesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/document/{0}/fields", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_id"] = ExpressionConverter.Convert(__workflow_templateId);
                if (__workflow_fields != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_fields);
                return new ApiConnectionAction<UpdateFieldValuesResponse>(callPayload);
            });
        }
    }

    public class SignnowTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TriggersResponse, ApiConnectionPollingTriggerConfiguration> Triggers(Expression<Func<TriggersBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<TriggersResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/multievent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<TriggersResponse>(callPayload);
            });
        }
    }

    public class CreateDocGroupEmbeddedInvitesResponse
    {
        [JsonProperty("id")]
        public string InviteId { get; set; }
    }

    public class CreateDocGroupEmbeddedInvitesInviteInput
    {
        [JsonProperty("invites")]
        public CreateDocGroupEmbeddedInvitesInviteInputInvitesTypeItem[] Invites { get; set; }

        [JsonProperty("advanced")]
        public InviteInputAdvancedTypeItem[] Advanced { get; set; }

        [JsonProperty("signature")]
        public InviteInputQESSignatureType? QESSignature { get; set; }
    }

    public class CreateDocGroupEmbeddedInvitesInviteInputInvitesTypeItem
    {
        public CreateDocGroupEmbeddedInvitesInviteInputInvitesTypeItem(int order, InviteInputInvitesTypeItemSignersTypeItem[] signers)
        {
            this.Order = order;
            this.Signers = signers;
        }

        [JsonProperty("order", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Order { get; set; }

        [JsonProperty("signers", DefaultValueHandling = DefaultValueHandling.Include)]
        public InviteInputInvitesTypeItemSignersTypeItem[] Signers { get; set; }
    }

    public class InviteInputInvitesTypeItemSignersTypeItem
    {
        public InviteInputInvitesTypeItemSignersTypeItem(string email, InviteInputInvitesTypeItemSignersTypeItemDocumentsTypeItem[] documents)
        {
            this.Email = email;
            this.Documents = documents;
        }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("documents", DefaultValueHandling = DefaultValueHandling.Include)]
        public InviteInputInvitesTypeItemSignersTypeItemDocumentsTypeItem[] Documents { get; set; }
    }

    public class InviteInputInvitesTypeItemSignersTypeItemDocumentsTypeItem
    {
        public InviteInputInvitesTypeItemSignersTypeItemDocumentsTypeItem(string documentId, InviteInputInvitesTypeItemSignersTypeItemDocumentsTypeItemActionType action)
        {
            this.DocumentId = documentId;
            this.Action = action;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        public InviteInputInvitesTypeItemSignersTypeItemDocumentsTypeItemActionType Action { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteInputInvitesTypeItemSignersTypeItemDocumentsTypeItemActionType
    {
        Sign,
        View
    }

    public class InviteInputAdvancedTypeItem
    {
        public InviteInputAdvancedTypeItem(string order, string email)
        {
            this.Order = order;
            this.Email = email;
        }

        [JsonProperty("order", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Order { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("language")]
        public InviteInputAdvancedTypeItemLanguageType? Language { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("required_preset_signature_name")]
        public string RequiredPresetSignatureName { get; set; }

        [JsonProperty("redirect_uri")]
        public string RedirectUri { get; set; }

        [JsonProperty("decline_redirect_uri")]
        public string DeclineRedirectUri { get; set; }

        [JsonProperty("close_redirect_uri")]
        public string CloseRedirectUri { get; set; }

        [JsonProperty("redirect_target")]
        public InviteInputAdvancedTypeItemRedirectTargetType? RedirectTarget { get; set; }

        [JsonProperty("delivery_type")]
        public InviteInputAdvancedTypeItemDeliveryTypeType? DeliveryType { get; set; }

        [JsonProperty("link_expiration")]
        public int? LinkExpiration { get; set; }

        [JsonProperty("session_expiration")]
        public int? SessionExpiration { get; set; }

        [JsonProperty("authentication_type")]
        public InviteInputAdvancedTypeItemAuthenticationTypeType? AuthenticationType { get; set; }

        [JsonProperty("authentication_password")]
        public string AuthenticationPassword { get; set; }

        [JsonProperty("authentication_phone")]
        public string AuthenticationPhone { get; set; }

        [JsonProperty("authentication_sms_message")]
        public string AuthenticationSmsMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteInputAdvancedTypeItemLanguageType
    {
        En,
        Es,
        Fr
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteInputAdvancedTypeItemRedirectTargetType
    {
        [EnumMember(Value = "In the new tab")]
        InTheNewTab,
        [EnumMember(Value = "In the same tab")]
        InTheSameTab
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteInputAdvancedTypeItemDeliveryTypeType
    {
        Email,
        Link
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteInputAdvancedTypeItemAuthenticationTypeType
    {
        Password,
        [EnumMember(Value = "Phone call")]
        PhoneCall,
        Sms
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteInputQESSignatureType
    {
        Eideasy,
        Nom151
    }

    public class GenerateDocGroupEmbeddedInviteLinkResponse
    {
        [JsonProperty("link")]
        public string EmbeddedInviteLink { get; set; }
    }

    public class GenerateDocGroupEmbeddedInviteLinkInviteInput
    {
        public GenerateDocGroupEmbeddedInviteLinkInviteInput(string email)
        {
            this.Email = email;
        }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("link_expiration")]
        public int? LinkExpiration { get; set; }

        [JsonProperty("session_expiration")]
        public int? SessionExpiration { get; set; }
    }

    public class CreateEmbeddedInvitesResponse
    {
        [JsonProperty("data")]
        public CreateEmbeddedInvitesResponseDataTypeItem[] Data { get; set; }
    }

    public class CreateEmbeddedInvitesResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("role_id")]
        public string RoleId { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class CreateEmbeddedInvitesInviteInput
    {
        [JsonProperty("invites")]
        public CreateEmbeddedInvitesInviteInputInvitesTypeItem[] Invites { get; set; }

        [JsonProperty("name_formula")]
        public string NameFormula { get; set; }

        [JsonProperty("advanced_params")]
        public InviteInputInviteAdvancedParametersTypeItem[] InviteAdvancedParameters { get; set; }

        [JsonProperty("signature")]
        public InviteInputQESSignatureType? QESSignature { get; set; }
    }

    public class CreateEmbeddedInvitesInviteInputInvitesTypeItem
    {
        public CreateEmbeddedInvitesInviteInputInvitesTypeItem(string signerEmail, string role)
        {
            this.SignerEmail = signerEmail;
            this.Role = role;
        }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SignerEmail { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Role { get; set; }

        [JsonProperty("order", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Order { get; set; } = 1;
    }

    public class InviteInputInviteAdvancedParametersTypeItem
    {
        public InviteInputInviteAdvancedParametersTypeItem(string role)
        {
            this.Role = role;
        }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Role { get; set; }

        [JsonProperty("language")]
        public InviteInputInviteAdvancedParametersTypeItemLanguageType? Language { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("required_preset_signature_name")]
        public string RequiredPresetSignatureName { get; set; }

        [JsonProperty("prefill_signature_name")]
        public string PrefillSignatureName { get; set; }

        [JsonProperty("force_new_signature")]
        public bool? RequireNewSignature { get; set; }

        [JsonProperty("redirect_uri")]
        public string RedirectUri { get; set; }

        [JsonProperty("decline_redirect_uri")]
        public string DeclineRedirectUri { get; set; }

        [JsonProperty("close_redirect_uri")]
        public string CloseRedirectUri { get; set; }

        [JsonProperty("redirect_target")]
        public InviteInputInviteAdvancedParametersTypeItemRedirectTargetType? RedirectTarget { get; set; }

        [JsonProperty("authentication_type")]
        public InviteInputInviteAdvancedParametersTypeItemAuthenticationTypeType? AuthenticationType { get; set; }

        [JsonProperty("authentication_password")]
        public string AuthenticationPassword { get; set; }

        [JsonProperty("authentication_phone")]
        public string AuthenticationPhone { get; set; }

        [JsonProperty("authentication_sms_message")]
        public string AuthenticationSmsMessage { get; set; }

        [JsonProperty("delivery_type")]
        public InviteInputInviteAdvancedParametersTypeItemDeliveryTypeType? DeliveryType { get; set; }

        [JsonProperty("link_expiration")]
        public int? LinkExpiration { get; set; }

        [JsonProperty("session_expiration")]
        public int? SessionExpiration { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteInputInviteAdvancedParametersTypeItemLanguageType
    {
        En,
        Es,
        Fr
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteInputInviteAdvancedParametersTypeItemRedirectTargetType
    {
        [EnumMember(Value = "In the new tab")]
        InTheNewTab,
        [EnumMember(Value = "In the same tab")]
        InTheSameTab
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteInputInviteAdvancedParametersTypeItemAuthenticationTypeType
    {
        Password,
        [EnumMember(Value = "Phone call")]
        PhoneCall,
        Sms
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteInputInviteAdvancedParametersTypeItemDeliveryTypeType
    {
        Email,
        Link
    }

    public class GenerateEmbeddedInviteLinkResponse
    {
        [JsonProperty("data")]
        public GenerateEmbeddedInviteLinkResponseDataType Data { get; set; }
    }

    public class GenerateEmbeddedInviteLinkResponseDataType
    {
        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class GenerateEmbeddedInviteLinkInviteInput
    {
        [JsonProperty("link_expiration")]
        public int? LinkExpiration { get; set; }

        [JsonProperty("session_expiration")]
        public int? SessionExpiration { get; set; }
    }

    public class DocumentGroupsResponse
    {
        [JsonProperty("document_groups")]
        public DocumentGroupProperties[] DocumentGroups { get; set; }

        [JsonProperty("document_group_total_count")]
        public int DocumentGroupsTotalCount { get; set; }
    }

    public class DocumentGroupProperties
    {
        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("group_name")]
        public string DocumentGroupName { get; set; }

        [JsonProperty("documents")]
        public DocumentGroupDocumentProperties[] Documents { get; set; }
    }

    public class DocumentGroupDocumentProperties
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("document_name")]
        public string DocumentName { get; set; }

        [JsonProperty("origin_document_id")]
        public string TemplateId { get; set; }
    }

    public class CreateDocumentGroupFromFilesResponse
    {
        [JsonProperty("group_name")]
        public string DocumentGroupName { get; set; }

        [JsonProperty("group_id")]
        public string DocumentGroupId { get; set; }

        [JsonProperty("documents")]
        public CreateDocumentGroupFromFilesResponseDocumentsTypeItem[] Documents { get; set; }
    }

    public class CreateDocumentGroupFromFilesResponseDocumentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string DocumentName { get; set; }
    }

    public class CreateDocGroupFromFilesBodyInput
    {
        public CreateDocGroupFromFilesBodyInput(string documentGroupName)
        {
            this.DocumentGroupName = documentGroupName;
        }

        [JsonProperty("group_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentGroupName { get; set; }

        [JsonProperty("documents")]
        public BodyInputDocumentsTypeItem[] Documents { get; set; }
    }

    public class BodyInputDocumentsTypeItem
    {
        public BodyInputDocumentsTypeItem(string documentName, string fileContent)
        {
            this.DocumentName = documentName;
            this.FileContent = fileContent;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentName { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileContent { get; set; }
    }

    public class CreateFromTemplateGroupResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateFromTemplateGroupBodyInput
    {
        [JsonProperty("group_name")]
        public string DocumentGroupName { get; set; }
    }

    public class UpdateGroupFieldValuesResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UpdateGroupSmartFieldValuesResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class DocumentProperties
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("document_name")]
        public string DocumentName { get; set; }

        [JsonProperty("page_count")]
        public int PageCount { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("original_filename")]
        public string TemplateName { get; set; }

        [JsonProperty("origin_document_id")]
        public string TemplateId { get; set; }

        [JsonProperty("template")]
        public bool IsTemplate { get; set; }

        [JsonProperty("status")]
        public string DocumentStatus { get; set; }

        [JsonProperty("roles")]
        public DocumentPropertiesRolesTypeItem[] Roles { get; set; }
    }

    public class DocumentPropertiesRolesTypeItem
    {
        [JsonProperty("unique_id")]
        public string UniqueId { get; set; }

        [JsonProperty("signing_order")]
        public string SigningOrder { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class DeleteDocResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class CreateFromTemplateResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateFromTemplateBodyInput
    {
        [JsonProperty("document_name")]
        public string DocumentName { get; set; }
    }

    public class CreateSigningLinkResponse
    {
        [JsonProperty("url_no_signup")]
        public string URL { get; set; }
    }

    public class SendUserDefinedInviteBodyInput
    {
        public BodyInputRoleTypeItem[] Role { get; set; }

        [JsonProperty("cc")]
        public string CC { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("on_complete")]
        public string EmailAllPartiesOnCompletion { get; set; }
    }

    public class BodyInputRoleTypeItem
    {
        [JsonProperty("role")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string EMail { get; set; }

        [JsonProperty("phone_invite")]
        public string PhoneNumberInviteViaSMS { get; set; }

        [JsonProperty("order", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Order { get; set; } = 1;

        [JsonProperty("subject")]
        public string PersonalizedSubject { get; set; }

        [JsonProperty("message")]
        public string PersonalizedMessage { get; set; }

        [JsonProperty("authentication_type")]
        public BodyInputRoleTypeItemAuthenticationTypeType? AuthenticationType { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("expiration_days")]
        public int? DaysUntilExpiration { get; set; }

        [JsonProperty("reminder")]
        public int? SendReminderIn { get; set; }

        [JsonProperty("remind_repeat")]
        public int? SendReminderEveryXDays { get; set; }

        [JsonProperty("reassign")]
        public bool? AllowForwarding { get; set; }

        [JsonProperty("decline_by_signature")]
        public bool? ShowDeclineOnSignature { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputRoleTypeItemAuthenticationTypeType
    {
        Password,
        [EnumMember(Value = "Phone Call")]
        PhoneCall,
        SMS
    }

    public class GetInviteStatusResponse
    {
        [JsonProperty("is_document_declined")]
        public bool DocumentDeclined { get; set; }

        [JsonProperty("steps")]
        public GetInviteStatusResponseStepsTypeItem[] Steps { get; set; }
    }

    public class GetInviteStatusResponseStepsTypeItem
    {
        [JsonProperty("signing_order")]
        public int SigningOrder { get; set; }

        [JsonProperty("signer_email")]
        public string RecipientEmail { get; set; }

        [JsonProperty("role_name")]
        public string RoleName { get; set; }

        [JsonProperty("action_type")]
        public string ActionType { get; set; }

        [JsonProperty("invite_id")]
        public string InviteId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("declined")]
        public bool Declined { get; set; }

        [JsonProperty("decline_reason")]
        public string DeclineReason { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }
    }

    public class GetDocumentGroupInviteStatusResponse
    {
        [JsonProperty("document_group_invite_id")]
        public string DocumentGroupInviteId { get; set; }

        [JsonProperty("status")]
        public string DocumentGroupStatus { get; set; }

        [JsonProperty("owner_email")]
        public string OwnerEmail { get; set; }

        [JsonProperty("is_document_declined")]
        public bool DocumentGroupDeclined { get; set; }

        [JsonProperty("steps")]
        public GetDocumentGroupInviteStatusResponseStepsTypeItem[] Steps { get; set; }
    }

    public class GetDocumentGroupInviteStatusResponseStepsTypeItem
    {
        [JsonProperty("step_id")]
        public string StepId { get; set; }

        [JsonProperty("signing_order")]
        public int SigningOrder { get; set; }

        [JsonProperty("document_id")]
        public string DocumentId { get; set; }

        [JsonProperty("document_name")]
        public string DocumentName { get; set; }

        [JsonProperty("signer_email")]
        public string SignerEmail { get; set; }

        [JsonProperty("role_name")]
        public string RoleName { get; set; }

        [JsonProperty("action_type")]
        public string ActionType { get; set; }

        [JsonProperty("invite_id")]
        public string StepInviteId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("declined")]
        public bool Declined { get; set; }

        [JsonProperty("decline_reason")]
        public string DeclineReason { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }
    }

    public class ReplaceRecipientsInDocumentInviteResponse
    {
        [JsonProperty("replacements")]
        public ReplaceRecipientsInDocumentInviteResponseReplacementsTypeItem[] Replacements { get; set; }
    }

    public class ReplaceRecipientsInDocumentInviteResponseReplacementsTypeItem
    {
        [JsonProperty("new_invite_id")]
        public string NewInviteId { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("new_email")]
        public string NewEmail { get; set; }
    }

    public class ReplaceRecipientsInDocumentInviteReplaceToInput
    {
        [JsonProperty("replace_to")]
        public ReplaceToInputReplaceToTypeItem[] ReplaceTo { get; set; }

        [JsonProperty("advanced")]
        public ReplaceToInputAdvancedParametersTypeItem[] AdvancedParameters { get; set; }
    }

    public class ReplaceToInputReplaceToTypeItem
    {
        public ReplaceToInputReplaceToTypeItem(string role, string newEmail)
        {
            this.Role = role;
            this.NewEmail = newEmail;
        }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Role { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NewEmail { get; set; }
    }

    public class ReplaceToInputAdvancedParametersTypeItem
    {
        public ReplaceToInputAdvancedParametersTypeItem(string role)
        {
            this.Role = role;
        }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Role { get; set; }

        [JsonProperty("expiration_days", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ExpirationDays { get; set; } = 30;

        [JsonProperty("decline_by_signature")]
        public bool? AllowDeclineBySignature { get; set; }

        [JsonProperty("reminder")]
        public int? Reminder { get; set; }

        [JsonProperty("authentication_type")]
        public ReplaceToInputAdvancedParametersTypeItemAuthenticationTypeType? AuthenticationType { get; set; }

        [JsonProperty("authentication_password")]
        public string AuthenticationPassword { get; set; }

        [JsonProperty("authentication_phone")]
        public string AuthenticationPhone { get; set; }

        [JsonProperty("authentication_sms_message")]
        public string AuthenticationSmsMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReplaceToInputAdvancedParametersTypeItemAuthenticationTypeType
    {
        Password,
        [EnumMember(Value = "Phone call")]
        PhoneCall,
        Sms
    }

    public class ReplaceRecipientsInDocumentGroupInviteResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ReplaceRecipientsInDocumentGroupInviteReplaceToInput
    {
        [JsonProperty("step_id")]
        public string StepId { get; set; }

        [JsonProperty("recipient_to_update")]
        public string RecipientToReplace { get; set; }

        [JsonProperty("new_recipient")]
        public string NewRecipient { get; set; }

        [JsonProperty("expiration_days", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ExpirationDays { get; set; } = 30;

        [JsonProperty("reminder")]
        public int? Reminder { get; set; }

        [JsonProperty("invite_action_attributes")]
        public ReplaceToInputInviteActionAttributesTypeItem[] InviteActionAttributes { get; set; }
    }

    public class ReplaceToInputInviteActionAttributesTypeItem
    {
        public ReplaceToInputInviteActionAttributesTypeItem(string documentId)
        {
            this.DocumentId = documentId;
        }

        [JsonProperty("document_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }

        [JsonProperty("allow_forwarding")]
        public bool? AllowForwarding { get; set; }

        [JsonProperty("decline_by_signature")]
        public bool? AllowDeclineBySignature { get; set; }
    }

    public class CreateEmbeddedInviteSettingsLinkResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class CreateEmbeddedInviteSettingsLinkInviteSettingsInput
    {
        [JsonProperty("type")]
        public CreateEmbeddedInviteSettingsLinkInviteSettingsInputTypeType? Type { get; set; }

        [JsonProperty("redirect_uri")]
        public string RedirectUri { get; set; }

        [JsonProperty("link_expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? LinkExpiration { get; set; } = 15;

        [JsonProperty("redirect_target")]
        public InviteSettingsInputRedirectTargetType? RedirectTarget { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEmbeddedInviteSettingsLinkInviteSettingsInputTypeType
    {
        Invite,
        Document
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteSettingsInputRedirectTargetType
    {
        [EnumMember(Value = "In the new tab")]
        InTheNewTab,
        [EnumMember(Value = "In the same tab")]
        InTheSameTab
    }

    public class CreateDocGroupEmbeddedInviteSettingsLinkResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class CreateDocGroupEmbeddedInviteSettingsLinkInviteSettingsInput
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateDocGroupEmbeddedInviteSettingsLinkInviteSettingsInputTypeType? Type { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Signnow.CreateDocGroupEmbeddedInviteSettingsLinkInviteSettingsInputTypeType.Manage;

        [JsonProperty("redirect_uri")]
        public string RedirectUri { get; set; }

        [JsonProperty("link_expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? LinkExpiration { get; set; } = 15;

        [JsonProperty("redirect_target")]
        public InviteSettingsInputRedirectTargetType? RedirectTarget { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateDocGroupEmbeddedInviteSettingsLinkInviteSettingsInputTypeType
    {
        Manage,
        Edit,
        [EnumMember(Value = "Send-invite")]
        SendInvite
    }

    public class InviteToSignAllOptionsResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class InviteToSignAllOptionsInviteInput
    {
        [JsonProperty("signers")]
        public InviteInputSignersTypeItem[] Signers { get; set; }

        [JsonProperty("signers_advanced")]
        public InviteInputSignerAdvancedPropertiesTypeItem[] SignerAdvancedProperties { get; set; }

        [JsonProperty("viewers")]
        public InviteInputViewersTypeItem[] Viewers { get; set; }

        [JsonProperty("viewers_advanced")]
        public InviteInputViewerAdvancedPropertiesTypeItem[] ViewerAdvancedProperties { get; set; }

        [JsonProperty("approvers")]
        public InviteInputApproversTypeItem[] Approvers { get; set; }

        [JsonProperty("approver_advanced")]
        public InviteInputApproverAdvancedPropertiesTypeItem[] ApproverAdvancedProperties { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("email_groups")]
        public InviteInputEmailGroupsTypeItem[] EmailGroups { get; set; }

        [JsonProperty("cc")]
        public InviteInputCCTypeItem[] CC { get; set; }

        [JsonProperty("cc_step")]
        public InviteInputCCStepsTypeItem[] CCSteps { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("cc_subject")]
        public string CCSubject { get; set; }

        [JsonProperty("cc_message")]
        public string CCMessage { get; set; }

        [JsonProperty("signature")]
        public InviteInputQESSignatureType? QESSignature { get; set; }
    }

    public class InviteInputSignersTypeItem
    {
        public InviteInputSignersTypeItem(string role, int order)
        {
            this.Role = role;
            this.Order = order;
        }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("email_group")]
        public string EmailGroup { get; set; }

        [JsonProperty("phone_invite")]
        public string PhoneInvite { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Role { get; set; }

        [JsonProperty("order", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Order { get; set; }
    }

    public class InviteInputSignerAdvancedPropertiesTypeItem
    {
        public InviteInputSignerAdvancedPropertiesTypeItem(string role)
        {
            this.Role = role;
        }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Role { get; set; }

        [JsonProperty("prefill_signature_name")]
        public string PrefillSignatureName { get; set; }

        [JsonProperty("required_preset_signature_name")]
        public string RequiredPresetSignatureName { get; set; }

        [JsonProperty("force_new_signature")]
        public bool? RequireNewSignature { get; set; }

        [JsonProperty("reassign")]
        public bool? AllowForwarding { get; set; }

        [JsonProperty("decline_by_signature")]
        public bool? AllowDeclineBySignature { get; set; }

        [JsonProperty("remind_after")]
        public int? SendReminderInXDays { get; set; }

        [JsonProperty("remind_before")]
        public int? SendReminderInXDaysBeforeExpiration { get; set; }

        [JsonProperty("remind_repeat")]
        public int? SendReminderEveryXDays { get; set; }

        [JsonProperty("expiration_days")]
        public int? DaysUntilExpiration { get; set; }

        [JsonProperty("authentication_type")]
        public InviteInputSignerAdvancedPropertiesTypeItemAuthenticationTypeType? AuthenticationType { get; set; }

        [JsonProperty("password")]
        public string AuthenticationPassword { get; set; }

        [JsonProperty("phone")]
        public string AuthenticationPhone { get; set; }

        [JsonProperty("authentication_sms_message")]
        public string AuthenticationSmsMessage { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("redirect_uri")]
        public string RedirectUri { get; set; }

        [JsonProperty("redirect_target")]
        public InviteInputSignerAdvancedPropertiesTypeItemRedirectTargetType? RedirectTarget { get; set; }

        [JsonProperty("decline_redirect_uri")]
        public string DeclineRedirectUri { get; set; }

        [JsonProperty("close_redirect_uri")]
        public string CloseRedirectUri { get; set; }

        [JsonProperty("is_finish_redirect_canceled")]
        public bool? IsFinishRedirectCanceled { get; set; }

        [JsonProperty("is_close_redirect_canceled")]
        public bool? IsCloseRedirectCanceled { get; set; }

        [JsonProperty("is_decline_redirect_canceled")]
        public bool? IsDeclineRedirectCanceled { get; set; }

        [JsonProperty("language")]
        public InviteInputSignerAdvancedPropertiesTypeItemLanguageType? Language { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteInputSignerAdvancedPropertiesTypeItemAuthenticationTypeType
    {
        Password,
        [EnumMember(Value = "Phone call")]
        PhoneCall,
        Sms
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteInputSignerAdvancedPropertiesTypeItemRedirectTargetType
    {
        [EnumMember(Value = "In the new tab")]
        InTheNewTab,
        [EnumMember(Value = "In the same tab")]
        InTheSameTab
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteInputSignerAdvancedPropertiesTypeItemLanguageType
    {
        En,
        Es,
        Fr
    }

    public class InviteInputViewersTypeItem
    {
        public InviteInputViewersTypeItem(string email, string role, int order)
        {
            this.Email = email;
            this.Role = role;
            this.Order = order;
        }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Role { get; set; }

        [JsonProperty("order", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Order { get; set; }
    }

    public class InviteInputViewerAdvancedPropertiesTypeItem
    {
        public InviteInputViewerAdvancedPropertiesTypeItem(string role)
        {
            this.Role = role;
        }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Role { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class InviteInputApproversTypeItem
    {
        public InviteInputApproversTypeItem(string email, string role, int order)
        {
            this.Email = email;
            this.Role = role;
            this.Order = order;
        }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Role { get; set; }

        [JsonProperty("order", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Order { get; set; }
    }

    public class InviteInputApproverAdvancedPropertiesTypeItem
    {
        public InviteInputApproverAdvancedPropertiesTypeItem(string role)
        {
            this.Role = role;
        }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Role { get; set; }

        [JsonProperty("expiration_days")]
        public int? ExpirationDays { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("authentication_type")]
        public InviteInputApproverAdvancedPropertiesTypeItemAuthenticationTypeType? AuthenticationType { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("authentication_sms_message")]
        public string AuthenticationSmsMessage { get; set; }

        [JsonProperty("redirect_uri")]
        public string RedirectUri { get; set; }

        [JsonProperty("redirect_target")]
        public InviteInputApproverAdvancedPropertiesTypeItemRedirectTargetType? RedirectTarget { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteInputApproverAdvancedPropertiesTypeItemAuthenticationTypeType
    {
        Password,
        [EnumMember(Value = "Phone call")]
        PhoneCall,
        Sms
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteInputApproverAdvancedPropertiesTypeItemRedirectTargetType
    {
        [EnumMember(Value = "In the new tab")]
        InTheNewTab,
        [EnumMember(Value = "In the same tab")]
        InTheSameTab
    }

    public class InviteInputEmailGroupsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("emails")]
        public InviteInputEmailGroupsTypeItemEmailsTypeItem[] Emails { get; set; }
    }

    public class InviteInputEmailGroupsTypeItemEmailsTypeItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class InviteInputCCTypeItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class InviteInputCCStepsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("step")]
        public int? Step { get; set; }
    }

    public class InviteToSignDocGroupAllOptionsResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("pending_invite_link")]
        public string PendingInviteLink { get; set; }
    }

    public class InviteToSignDocGroupAllOptionsInviteInput
    {
        [JsonProperty("invite_steps")]
        public InviteInputInviteStepsTypeItem[] InviteSteps { get; set; }

        [JsonProperty("Email")]
        public InviteInputInviteEmailsTypeItem[] InviteEmails { get; set; }

        [JsonProperty("email_groups")]
        public InviteInputEmailGroupsTypeItem[] EmailGroups { get; set; }

        [JsonProperty("completion_emails")]
        public InviteInputCompletionEmailsTypeItem[] CompletionEmails { get; set; }

        [JsonProperty("sign_as_merged")]
        public bool? SignAsMerged { get; set; }

        [JsonProperty("client_timestamp")]
        public int? ClientTimestamp { get; set; }

        [JsonProperty("cc")]
        public InviteInputCCTypeItem[] CC { get; set; }

        [JsonProperty("signature")]
        public InviteInputQESSignatureType? QESSignature { get; set; }
    }

    public class InviteInputInviteStepsTypeItem
    {
        public InviteInputInviteStepsTypeItem(int order, string roleName, InviteInputInviteStepsTypeItemActionType action, string documentId)
        {
            this.Order = order;
            this.RoleName = roleName;
            this.Action = action;
            this.DocumentId = documentId;
        }

        [JsonProperty("order", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Order { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("email_group")]
        public string EmailGroup { get; set; }

        [JsonProperty("role_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RoleName { get; set; }

        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        public InviteInputInviteStepsTypeItemActionType Action { get; set; }

        [JsonProperty("document_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }
        public InviteInputInviteStepsTypeItemAdvancedTypeItem[] Advanced { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteInputInviteStepsTypeItemActionType
    {
        View,
        Sign,
        Approve
    }

    public class InviteInputInviteStepsTypeItemAdvancedTypeItem
    {
        [JsonProperty("required_preset_signature_name")]
        public string RequiredPresetSignatureName { get; set; }

        [JsonProperty("allow_reassign")]
        public bool? AllowForwarding { get; set; }

        [JsonProperty("decline_by_signature")]
        public bool? AllowDeclineBySignature { get; set; }

        [JsonProperty("authentication")]
        public InviteInputInviteStepsTypeItemAdvancedTypeItemAuthenticationType Authentication { get; set; }

        [JsonProperty("payment_request")]
        public InviteInputInviteStepsTypeItemAdvancedTypeItemPaymentRequestType PaymentRequest { get; set; }

        [JsonProperty("redirect")]
        public InviteInputInviteStepsTypeItemAdvancedTypeItemRedirectType Redirect { get; set; }

        [JsonProperty("language")]
        public InviteInputInviteStepsTypeItemAdvancedTypeItemLanguageType? Language { get; set; }
    }

    public class InviteInputInviteStepsTypeItemAdvancedTypeItemAuthenticationType
    {
        [JsonProperty("type")]
        public InviteInputInviteStepsTypeItemAdvancedTypeItemAuthenticationTypeAuthenticationTypeType? AuthenticationType { get; set; }

        [JsonProperty("value")]
        public string Password { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteInputInviteStepsTypeItemAdvancedTypeItemAuthenticationTypeAuthenticationTypeType
    {
        Password,
        [EnumMember(Value = "Phone call")]
        PhoneCall,
        Sms
    }

    public class InviteInputInviteStepsTypeItemAdvancedTypeItemPaymentRequestType
    {
        [JsonProperty("merchant_id")]
        public string MerchantId { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }
    }

    public class InviteInputInviteStepsTypeItemAdvancedTypeItemRedirectType
    {
        [JsonProperty("redirect_uri")]
        public string Uri { get; set; }

        [JsonProperty("redirect_target")]
        public InviteInputInviteStepsTypeItemAdvancedTypeItemRedirectTypeRedirectTargetType? RedirectTarget { get; set; }

        [JsonProperty("decline_redirect_uri")]
        public string DeclineRedirectUri { get; set; }

        [JsonProperty("close_redirect_uri")]
        public string CloseRedirectUri { get; set; }

        [JsonProperty("is_finish_redirect_canceled")]
        public bool? IsFinishRedirectCanceled { get; set; }

        [JsonProperty("is_close_redirect_canceled")]
        public bool? IsCloseRedirectCanceled { get; set; }

        [JsonProperty("is_decline_redirect_canceled")]
        public bool? IsDeclineRedirectCanceled { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteInputInviteStepsTypeItemAdvancedTypeItemRedirectTypeRedirectTargetType
    {
        [EnumMember(Value = "In the new tab")]
        InTheNewTab,
        [EnumMember(Value = "In the same tab")]
        InTheSameTab
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteInputInviteStepsTypeItemAdvancedTypeItemLanguageType
    {
        En,
        Es,
        Fr
    }

    public class InviteInputInviteEmailsTypeItem
    {
        public InviteInputInviteEmailsTypeItem(int order, string email)
        {
            this.Order = order;
            this.Email = email;
        }

        [JsonProperty("order", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Order { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("email_group")]
        public string EmailGroup { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("expiration_days")]
        public int? DaysUntilExpiration { get; set; }

        [JsonProperty("remind_after")]
        public int? SendReminderInXDays { get; set; }

        [JsonProperty("remind_before")]
        public int? SendReminderInXDaysBeforeExpiration { get; set; }

        [JsonProperty("remind_repeat")]
        public int? SendReminderEveryXDays { get; set; }
    }

    public class InviteInputCompletionEmailsTypeItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("disable_document_attachment")]
        public bool? DisableDocumentAttachment { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class UpdateFieldValuesResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class TriggersResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class TriggersBodyInput
    {
        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Event { get; set; } = "user.document.complete";

        [JsonProperty("entity_id", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string EntityId { get; set; } = "00000000-0000-0000-0000-000000000000";

        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Action { get; set; } = "callback";

        [JsonProperty("attributes", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputAttributesType Attributes { get; set; } = new BodyInputAttributesType();
    }

    public class BodyInputAttributesType
    {
        [JsonProperty("callback", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callback { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Signnow;

    public partial class WorkflowManagedActions
    {
        public SignnowActions Signnow(string connectionId) => new SignnowActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SignnowTriggers Signnow(string connectionId) => new SignnowTriggers(connectionId);
    }
}