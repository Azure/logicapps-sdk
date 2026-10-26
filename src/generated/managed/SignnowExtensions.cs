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
        public IBodyWorkflowAction<CreateDocGroupEmbeddedInvitesResponse, ApiConnectionActionConfiguration> CreateDocGroupEmbeddedInvites(Expression<Func<string>> id, Expression<Func<CreateDocGroupEmbeddedInvitesInput>> invite)
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
        public IBodyWorkflowAction<GenerateDocGroupEmbeddedInviteLinkResponse, ApiConnectionActionConfiguration> GenerateDocGroupEmbeddedInviteLink(Expression<Func<string>> id, Expression<Func<string>> inviteId, Expression<Func<GenerateDocGroupEmbeddedInviteLinkInput>> invite)
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
        public IBodyWorkflowAction<CreateEmbeddedInvitesResponse, ApiConnectionActionConfiguration> CreateEmbeddedInvites(Expression<Func<string>> id, Expression<Func<CreateEmbeddedInvitesInput>> invite)
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
        public IBodyWorkflowAction<GenerateEmbeddedInviteLinkResponse, ApiConnectionActionConfiguration> GenerateEmbeddedInviteLink(Expression<Func<string>> id, Expression<Func<string>> fieldInviteId, Expression<Func<GenerateEmbeddedInviteLinkInput>> invite)
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
        public IBodyWorkflowAction<CreateDocumentGroupFromFilesResponse, ApiConnectionActionConfiguration> CreateDocGroupFromFiles(Expression<Func<CreateDocGroupFromFilesInput>> body)
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
        public IBodyWorkflowAction<CreateFromTemplateGroupResponse, ApiConnectionActionConfiguration> CreateFromTemplateGroup(Expression<Func<string>> docGroupId, Expression<Func<CreateFromTemplateGroupInput>> body = null)
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
        public IBodyWorkflowAction<CreateFromTemplateResponse, ApiConnectionActionConfiguration> CreateFromTemplate(Expression<Func<string>> docId, Expression<Func<CreateFromTemplateInput>> body = null)
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> SendUserDefinedInvite(Expression<Func<string>> docId, Expression<Func<SendUserDefinedInviteInput>> body = null)
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
        public IBodyWorkflowAction<ReplaceRecipientsInDocumentInviteResponse, ApiConnectionActionConfiguration> ReplaceRecipientsInDocumentInvite(Expression<Func<string>> id, Expression<Func<ReplaceRecipientsInDocumentInviteInput>> replaceTo)
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
        public IBodyWorkflowAction<ReplaceRecipientsInDocumentGroupInviteResponse, ApiConnectionActionConfiguration> ReplaceRecipientsInDocumentGroupInvite(Expression<Func<string>> id, Expression<Func<string>> inviteId, Expression<Func<ReplaceRecipientsInDocumentGroupInviteInput>> replaceTo)
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
        public IBodyWorkflowAction<CreateEmbeddedInviteSettingsLinkResponse, ApiConnectionActionConfiguration> CreateEmbeddedInviteSettingsLink(Expression<Func<string>> id, Expression<Func<CreateEmbeddedInviteSettingsLinkInput>> inviteSettings)
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
        public IBodyWorkflowAction<CreateDocGroupEmbeddedInviteSettingsLinkResponse, ApiConnectionActionConfiguration> CreateDocGroupEmbeddedInviteSettingsLink(Expression<Func<string>> id, Expression<Func<CreateDocGroupEmbeddedInviteSettingsLinkInput>> inviteSettings)
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
        public IBodyWorkflowAction<InviteToSignAllOptionsResponse, ApiConnectionActionConfiguration> InviteToSignAllOptions(Expression<Func<string>> id, Expression<Func<InviteToSignAllOptionsInput>> invite)
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
        public IBodyWorkflowAction<InviteToSignDocGroupAllOptionsResponse, ApiConnectionActionConfiguration> InviteToSignDocGroupAllOptions(Expression<Func<string>> id, Expression<Func<InviteToSignDocGroupAllOptionsInput>> invite)
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
        public IBodyWorkflowAction<UpdateFieldValuesV2Response, ApiConnectionActionConfiguration> UpdateFieldValues(Expression<Func<string>> templateId, Expression<Func<string>> docId, Expression<Func<object>> fields = null)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<UpdateFieldValuesV2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/document/{0}/fields", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_id"] = ExpressionConverter.Convert(__workflow_templateId);
                if (__workflow_fields != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_fields);
                return new ApiConnectionAction<UpdateFieldValuesV2Response>(callPayload);
            });
        }
    }

    public class SignnowTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TriggersV2Response, ApiConnectionTriggerConfiguration> Triggers(Expression<Func<TriggersV2Input>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<TriggersV2Response, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/multievent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<TriggersV2Response>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CreateDocGroupEmbeddedInvitesResponse
    {
        [JsonProperty("id")]
        public string InviteId { get; set; }
    }

    public class CreateDocGroupEmbeddedInvitesInput
    {
        [JsonProperty("invites")]
        public CreateDocGroupEmbeddedInvitesInputInvitesTypeItem[] Invites { get; set; }

        [JsonProperty("advanced")]
        public CreateDocGroupEmbeddedInvitesInputAdvancedTypeItem[] Advanced { get; set; }

        [JsonProperty("signature")]
        public CreateDocGroupEmbeddedInvitesInputQESSignatureType? QESSignature { get; set; }
    }

    public class CreateDocGroupEmbeddedInvitesInputInvitesTypeItem
    {
        [JsonProperty("order", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Order { get; set; }

        [JsonProperty("signers", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateDocGroupEmbeddedInvitesInputInvitesTypeItemSignersTypeItem[] Signers { get; set; }
    }

    public class CreateDocGroupEmbeddedInvitesInputInvitesTypeItemSignersTypeItem
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("documents", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateDocGroupEmbeddedInvitesInputInvitesTypeItemSignersTypeItemDocumentsTypeItem[] Documents { get; set; }
    }

    public class CreateDocGroupEmbeddedInvitesInputInvitesTypeItemSignersTypeItemDocumentsTypeItem
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateDocGroupEmbeddedInvitesInputInvitesTypeItemSignersTypeItemDocumentsTypeItemActionType Action { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateDocGroupEmbeddedInvitesInputInvitesTypeItemSignersTypeItemDocumentsTypeItemActionType
    {
        Sign,
        View
    }

    public class CreateDocGroupEmbeddedInvitesInputAdvancedTypeItem
    {
        [JsonProperty("order", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Order { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("language")]
        public CreateDocGroupEmbeddedInvitesInputAdvancedTypeItemLanguageType? Language { get; set; }

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
        public CreateDocGroupEmbeddedInvitesInputAdvancedTypeItemRedirectTargetType? RedirectTarget { get; set; }

        [JsonProperty("delivery_type")]
        public CreateDocGroupEmbeddedInvitesInputAdvancedTypeItemDeliveryTypeType? DeliveryType { get; set; }

        [JsonProperty("link_expiration")]
        public int? LinkExpiration { get; set; }

        [JsonProperty("session_expiration")]
        public int? SessionExpiration { get; set; }

        [JsonProperty("authentication_type")]
        public CreateDocGroupEmbeddedInvitesInputAdvancedTypeItemAuthenticationTypeType? AuthenticationType { get; set; }

        [JsonProperty("authentication_password")]
        public string AuthenticationPassword { get; set; }

        [JsonProperty("authentication_phone")]
        public string AuthenticationPhone { get; set; }

        [JsonProperty("authentication_sms_message")]
        public string AuthenticationSmsMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateDocGroupEmbeddedInvitesInputAdvancedTypeItemLanguageType
    {
        En,
        Es,
        Fr
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateDocGroupEmbeddedInvitesInputAdvancedTypeItemRedirectTargetType
    {
        [EnumMember(Value = "In the new tab")]
        InTheNewTab,
        [EnumMember(Value = "In the same tab")]
        InTheSameTab
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateDocGroupEmbeddedInvitesInputAdvancedTypeItemDeliveryTypeType
    {
        Email,
        Link
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateDocGroupEmbeddedInvitesInputAdvancedTypeItemAuthenticationTypeType
    {
        Password,
        [EnumMember(Value = "Phone call")]
        PhoneCall,
        Sms
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateDocGroupEmbeddedInvitesInputQESSignatureType
    {
        Eideasy,
        Nom151
    }

    public class GenerateDocGroupEmbeddedInviteLinkResponse
    {
        [JsonProperty("link")]
        public string EmbeddedInviteLink { get; set; }
    }

    public class GenerateDocGroupEmbeddedInviteLinkInput
    {
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

    public class CreateEmbeddedInvitesInput
    {
        [JsonProperty("invites")]
        public CreateEmbeddedInvitesInputInvitesTypeItem[] Invites { get; set; }

        [JsonProperty("name_formula")]
        public string NameFormula { get; set; }

        [JsonProperty("advanced_params")]
        public CreateEmbeddedInvitesInputInviteAdvancedParametersTypeItem[] InviteAdvancedParameters { get; set; }

        [JsonProperty("signature")]
        public CreateEmbeddedInvitesInputQESSignatureType? QESSignature { get; set; }
    }

    public class CreateEmbeddedInvitesInputInvitesTypeItem
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SignerEmail { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Role { get; set; }

        [JsonProperty("order", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Order { get; set; } = 1;
    }

    public class CreateEmbeddedInvitesInputInviteAdvancedParametersTypeItem
    {
        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Role { get; set; }

        [JsonProperty("language")]
        public CreateEmbeddedInvitesInputInviteAdvancedParametersTypeItemLanguageType? Language { get; set; }

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
        public CreateEmbeddedInvitesInputInviteAdvancedParametersTypeItemRedirectTargetType? RedirectTarget { get; set; }

        [JsonProperty("authentication_type")]
        public CreateEmbeddedInvitesInputInviteAdvancedParametersTypeItemAuthenticationTypeType? AuthenticationType { get; set; }

        [JsonProperty("authentication_password")]
        public string AuthenticationPassword { get; set; }

        [JsonProperty("authentication_phone")]
        public string AuthenticationPhone { get; set; }

        [JsonProperty("authentication_sms_message")]
        public string AuthenticationSmsMessage { get; set; }

        [JsonProperty("delivery_type")]
        public CreateEmbeddedInvitesInputInviteAdvancedParametersTypeItemDeliveryTypeType? DeliveryType { get; set; }

        [JsonProperty("link_expiration")]
        public int? LinkExpiration { get; set; }

        [JsonProperty("session_expiration")]
        public int? SessionExpiration { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEmbeddedInvitesInputInviteAdvancedParametersTypeItemLanguageType
    {
        En,
        Es,
        Fr
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEmbeddedInvitesInputInviteAdvancedParametersTypeItemRedirectTargetType
    {
        [EnumMember(Value = "In the new tab")]
        InTheNewTab,
        [EnumMember(Value = "In the same tab")]
        InTheSameTab
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEmbeddedInvitesInputInviteAdvancedParametersTypeItemAuthenticationTypeType
    {
        Password,
        [EnumMember(Value = "Phone call")]
        PhoneCall,
        Sms
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEmbeddedInvitesInputInviteAdvancedParametersTypeItemDeliveryTypeType
    {
        Email,
        Link
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEmbeddedInvitesInputQESSignatureType
    {
        Eideasy,
        Nom151
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

    public class GenerateEmbeddedInviteLinkInput
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

    public class CreateDocGroupFromFilesInput
    {
        [JsonProperty("group_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentGroupName { get; set; }

        [JsonProperty("documents")]
        public CreateDocGroupFromFilesInputDocumentsTypeItem[] Documents { get; set; }
    }

    public class CreateDocGroupFromFilesInputDocumentsTypeItem
    {
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

    public class CreateFromTemplateGroupInput
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

    public class CreateFromTemplateInput
    {
        [JsonProperty("document_name")]
        public string DocumentName { get; set; }
    }

    public class CreateSigningLinkResponse
    {
        [JsonProperty("url_no_signup")]
        public string URL { get; set; }
    }

    public class SendUserDefinedInviteInput
    {
        public SendUserDefinedInviteInputRoleTypeItem[] Role { get; set; }

        [JsonProperty("cc")]
        public string CC { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("on_complete")]
        public string EmailAllPartiesOnCompletion { get; set; }
    }

    public class SendUserDefinedInviteInputRoleTypeItem
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
        public SendUserDefinedInviteInputRoleTypeItemAuthenticationTypeType? AuthenticationType { get; set; }

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
    public enum SendUserDefinedInviteInputRoleTypeItemAuthenticationTypeType
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

    public class ReplaceRecipientsInDocumentInviteInput
    {
        [JsonProperty("replace_to")]
        public ReplaceRecipientsInDocumentInviteInputReplaceToTypeItem[] ReplaceTo { get; set; }

        [JsonProperty("advanced")]
        public ReplaceRecipientsInDocumentInviteInputAdvancedParametersTypeItem[] AdvancedParameters { get; set; }
    }

    public class ReplaceRecipientsInDocumentInviteInputReplaceToTypeItem
    {
        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Role { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NewEmail { get; set; }
    }

    public class ReplaceRecipientsInDocumentInviteInputAdvancedParametersTypeItem
    {
        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Role { get; set; }

        [JsonProperty("expiration_days", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ExpirationDays { get; set; } = 30;

        [JsonProperty("decline_by_signature")]
        public bool? AllowDeclineBySignature { get; set; }

        [JsonProperty("reminder")]
        public int? Reminder { get; set; }

        [JsonProperty("authentication_type")]
        public ReplaceRecipientsInDocumentInviteInputAdvancedParametersTypeItemAuthenticationTypeType? AuthenticationType { get; set; }

        [JsonProperty("authentication_password")]
        public string AuthenticationPassword { get; set; }

        [JsonProperty("authentication_phone")]
        public string AuthenticationPhone { get; set; }

        [JsonProperty("authentication_sms_message")]
        public string AuthenticationSmsMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReplaceRecipientsInDocumentInviteInputAdvancedParametersTypeItemAuthenticationTypeType
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

    public class ReplaceRecipientsInDocumentGroupInviteInput
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
        public ReplaceRecipientsInDocumentGroupInviteInputInviteActionAttributesTypeItem[] InviteActionAttributes { get; set; }
    }

    public class ReplaceRecipientsInDocumentGroupInviteInputInviteActionAttributesTypeItem
    {
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

    public class CreateEmbeddedInviteSettingsLinkInput
    {
        [JsonProperty("type")]
        public CreateEmbeddedInviteSettingsLinkInputTypeType? Type { get; set; }

        [JsonProperty("redirect_uri")]
        public string RedirectUri { get; set; }

        [JsonProperty("link_expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? LinkExpiration { get; set; } = 15;

        [JsonProperty("redirect_target")]
        public CreateEmbeddedInviteSettingsLinkInputRedirectTargetType? RedirectTarget { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEmbeddedInviteSettingsLinkInputTypeType
    {
        Invite,
        Document
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEmbeddedInviteSettingsLinkInputRedirectTargetType
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

    public class CreateDocGroupEmbeddedInviteSettingsLinkInput
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateDocGroupEmbeddedInviteSettingsLinkInputTypeType? Type { get; set; } = CreateDocGroupEmbeddedInviteSettingsLinkInputTypeType.Manage;

        [JsonProperty("redirect_uri")]
        public string RedirectUri { get; set; }

        [JsonProperty("link_expiration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? LinkExpiration { get; set; } = 15;

        [JsonProperty("redirect_target")]
        public CreateDocGroupEmbeddedInviteSettingsLinkInputRedirectTargetType? RedirectTarget { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateDocGroupEmbeddedInviteSettingsLinkInputTypeType
    {
        Manage,
        Edit,
        [EnumMember(Value = "Send-invite")]
        SendInvite
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateDocGroupEmbeddedInviteSettingsLinkInputRedirectTargetType
    {
        [EnumMember(Value = "In the new tab")]
        InTheNewTab,
        [EnumMember(Value = "In the same tab")]
        InTheSameTab
    }

    public class InviteToSignAllOptionsResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class InviteToSignAllOptionsInput
    {
        [JsonProperty("signers")]
        public InviteToSignAllOptionsInputSignersTypeItem[] Signers { get; set; }

        [JsonProperty("signers_advanced")]
        public InviteToSignAllOptionsInputSignerAdvancedPropertiesTypeItem[] SignerAdvancedProperties { get; set; }

        [JsonProperty("viewers")]
        public InviteToSignAllOptionsInputViewersTypeItem[] Viewers { get; set; }

        [JsonProperty("viewers_advanced")]
        public InviteToSignAllOptionsInputViewerAdvancedPropertiesTypeItem[] ViewerAdvancedProperties { get; set; }

        [JsonProperty("approvers")]
        public InviteToSignAllOptionsInputApproversTypeItem[] Approvers { get; set; }

        [JsonProperty("approver_advanced")]
        public InviteToSignAllOptionsInputApproverAdvancedPropertiesTypeItem[] ApproverAdvancedProperties { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("email_groups")]
        public InviteToSignAllOptionsInputEmailGroupsTypeItem[] EmailGroups { get; set; }

        [JsonProperty("cc")]
        public InviteToSignAllOptionsInputCCTypeItem[] CC { get; set; }

        [JsonProperty("cc_step")]
        public InviteToSignAllOptionsInputCCStepsTypeItem[] CCSteps { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("cc_subject")]
        public string CCSubject { get; set; }

        [JsonProperty("cc_message")]
        public string CCMessage { get; set; }

        [JsonProperty("signature")]
        public InviteToSignAllOptionsInputQESSignatureType? QESSignature { get; set; }
    }

    public class InviteToSignAllOptionsInputSignersTypeItem
    {
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

    public class InviteToSignAllOptionsInputSignerAdvancedPropertiesTypeItem
    {
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
        public InviteToSignAllOptionsInputSignerAdvancedPropertiesTypeItemAuthenticationTypeType? AuthenticationType { get; set; }

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
        public InviteToSignAllOptionsInputSignerAdvancedPropertiesTypeItemRedirectTargetType? RedirectTarget { get; set; }

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
        public InviteToSignAllOptionsInputSignerAdvancedPropertiesTypeItemLanguageType? Language { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteToSignAllOptionsInputSignerAdvancedPropertiesTypeItemAuthenticationTypeType
    {
        Password,
        [EnumMember(Value = "Phone call")]
        PhoneCall,
        Sms
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteToSignAllOptionsInputSignerAdvancedPropertiesTypeItemRedirectTargetType
    {
        [EnumMember(Value = "In the new tab")]
        InTheNewTab,
        [EnumMember(Value = "In the same tab")]
        InTheSameTab
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteToSignAllOptionsInputSignerAdvancedPropertiesTypeItemLanguageType
    {
        En,
        Es,
        Fr
    }

    public class InviteToSignAllOptionsInputViewersTypeItem
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Role { get; set; }

        [JsonProperty("order", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Order { get; set; }
    }

    public class InviteToSignAllOptionsInputViewerAdvancedPropertiesTypeItem
    {
        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Role { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class InviteToSignAllOptionsInputApproversTypeItem
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Role { get; set; }

        [JsonProperty("order", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Order { get; set; }
    }

    public class InviteToSignAllOptionsInputApproverAdvancedPropertiesTypeItem
    {
        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Role { get; set; }

        [JsonProperty("expiration_days")]
        public int? ExpirationDays { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("authentication_type")]
        public InviteToSignAllOptionsInputApproverAdvancedPropertiesTypeItemAuthenticationTypeType? AuthenticationType { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("authentication_sms_message")]
        public string AuthenticationSmsMessage { get; set; }

        [JsonProperty("redirect_uri")]
        public string RedirectUri { get; set; }

        [JsonProperty("redirect_target")]
        public InviteToSignAllOptionsInputApproverAdvancedPropertiesTypeItemRedirectTargetType? RedirectTarget { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteToSignAllOptionsInputApproverAdvancedPropertiesTypeItemAuthenticationTypeType
    {
        Password,
        [EnumMember(Value = "Phone call")]
        PhoneCall,
        Sms
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteToSignAllOptionsInputApproverAdvancedPropertiesTypeItemRedirectTargetType
    {
        [EnumMember(Value = "In the new tab")]
        InTheNewTab,
        [EnumMember(Value = "In the same tab")]
        InTheSameTab
    }

    public class InviteToSignAllOptionsInputEmailGroupsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("emails")]
        public InviteToSignAllOptionsInputEmailGroupsTypeItemEmailsTypeItem[] Emails { get; set; }
    }

    public class InviteToSignAllOptionsInputEmailGroupsTypeItemEmailsTypeItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class InviteToSignAllOptionsInputCCTypeItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class InviteToSignAllOptionsInputCCStepsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("step")]
        public int? Step { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteToSignAllOptionsInputQESSignatureType
    {
        Eideasy,
        Nom151
    }

    public class InviteToSignDocGroupAllOptionsResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("pending_invite_link")]
        public string PendingInviteLink { get; set; }
    }

    public class InviteToSignDocGroupAllOptionsInput
    {
        [JsonProperty("invite_steps")]
        public InviteToSignDocGroupAllOptionsInputInviteStepsTypeItem[] InviteSteps { get; set; }

        [JsonProperty("Email")]
        public InviteToSignDocGroupAllOptionsInputInviteEmailsTypeItem[] InviteEmails { get; set; }

        [JsonProperty("email_groups")]
        public InviteToSignDocGroupAllOptionsInputEmailGroupsTypeItem[] EmailGroups { get; set; }

        [JsonProperty("completion_emails")]
        public InviteToSignDocGroupAllOptionsInputCompletionEmailsTypeItem[] CompletionEmails { get; set; }

        [JsonProperty("sign_as_merged")]
        public bool? SignAsMerged { get; set; }

        [JsonProperty("client_timestamp")]
        public int? ClientTimestamp { get; set; }

        [JsonProperty("cc")]
        public InviteToSignDocGroupAllOptionsInputCCTypeItem[] CC { get; set; }

        [JsonProperty("signature")]
        public InviteToSignDocGroupAllOptionsInputQESSignatureType? QESSignature { get; set; }
    }

    public class InviteToSignDocGroupAllOptionsInputInviteStepsTypeItem
    {
        [JsonProperty("order", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Order { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("email_group")]
        public string EmailGroup { get; set; }

        [JsonProperty("role_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RoleName { get; set; }

        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        public InviteToSignDocGroupAllOptionsInputInviteStepsTypeItemActionType Action { get; set; }

        [JsonProperty("document_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }
        public InviteToSignDocGroupAllOptionsInputInviteStepsTypeItemAdvancedTypeItem[] Advanced { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteToSignDocGroupAllOptionsInputInviteStepsTypeItemActionType
    {
        View,
        Sign,
        Approve
    }

    public class InviteToSignDocGroupAllOptionsInputInviteStepsTypeItemAdvancedTypeItem
    {
        [JsonProperty("required_preset_signature_name")]
        public string RequiredPresetSignatureName { get; set; }

        [JsonProperty("allow_reassign")]
        public bool? AllowForwarding { get; set; }

        [JsonProperty("decline_by_signature")]
        public bool? AllowDeclineBySignature { get; set; }

        [JsonProperty("authentication")]
        public InviteToSignDocGroupAllOptionsInputInviteStepsTypeItemAdvancedTypeItemAuthenticationType Authentication { get; set; }

        [JsonProperty("payment_request")]
        public InviteToSignDocGroupAllOptionsInputInviteStepsTypeItemAdvancedTypeItemPaymentRequestType PaymentRequest { get; set; }

        [JsonProperty("redirect")]
        public InviteToSignDocGroupAllOptionsInputInviteStepsTypeItemAdvancedTypeItemRedirectType Redirect { get; set; }

        [JsonProperty("language")]
        public InviteToSignDocGroupAllOptionsInputInviteStepsTypeItemAdvancedTypeItemLanguageType? Language { get; set; }
    }

    public class InviteToSignDocGroupAllOptionsInputInviteStepsTypeItemAdvancedTypeItemAuthenticationType
    {
        [JsonProperty("type")]
        public InviteToSignDocGroupAllOptionsInputInviteStepsTypeItemAdvancedTypeItemAuthenticationTypeAuthenticationTypeType? AuthenticationType { get; set; }

        [JsonProperty("value")]
        public string Password { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteToSignDocGroupAllOptionsInputInviteStepsTypeItemAdvancedTypeItemAuthenticationTypeAuthenticationTypeType
    {
        Password,
        [EnumMember(Value = "Phone call")]
        PhoneCall,
        Sms
    }

    public class InviteToSignDocGroupAllOptionsInputInviteStepsTypeItemAdvancedTypeItemPaymentRequestType
    {
        [JsonProperty("merchant_id")]
        public string MerchantId { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }
    }

    public class InviteToSignDocGroupAllOptionsInputInviteStepsTypeItemAdvancedTypeItemRedirectType
    {
        [JsonProperty("redirect_uri")]
        public string Uri { get; set; }

        [JsonProperty("redirect_target")]
        public InviteToSignDocGroupAllOptionsInputInviteStepsTypeItemAdvancedTypeItemRedirectTypeRedirectTargetType? RedirectTarget { get; set; }

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
    public enum InviteToSignDocGroupAllOptionsInputInviteStepsTypeItemAdvancedTypeItemRedirectTypeRedirectTargetType
    {
        [EnumMember(Value = "In the new tab")]
        InTheNewTab,
        [EnumMember(Value = "In the same tab")]
        InTheSameTab
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteToSignDocGroupAllOptionsInputInviteStepsTypeItemAdvancedTypeItemLanguageType
    {
        En,
        Es,
        Fr
    }

    public class InviteToSignDocGroupAllOptionsInputInviteEmailsTypeItem
    {
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

    public class InviteToSignDocGroupAllOptionsInputEmailGroupsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("emails")]
        public InviteToSignDocGroupAllOptionsInputEmailGroupsTypeItemEmailsTypeItem[] Emails { get; set; }
    }

    public class InviteToSignDocGroupAllOptionsInputEmailGroupsTypeItemEmailsTypeItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class InviteToSignDocGroupAllOptionsInputCompletionEmailsTypeItem
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

    public class InviteToSignDocGroupAllOptionsInputCCTypeItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InviteToSignDocGroupAllOptionsInputQESSignatureType
    {
        Eideasy,
        Nom151
    }

    public class UpdateFieldValuesV2Response
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class TriggersV2Response
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class TriggersV2Input
    {
        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Event { get; set; } = "user.document.complete";

        [JsonProperty("entity_id", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string EntityId { get; set; } = "00000000-0000-0000-0000-000000000000";

        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Action { get; set; } = "callback";

        [JsonProperty("attributes", DefaultValueHandling = DefaultValueHandling.Include)]
        public TriggersV2InputAttributesType Attributes { get; set; }
    }

    public class TriggersV2InputAttributesType
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