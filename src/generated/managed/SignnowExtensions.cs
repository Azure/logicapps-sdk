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
        public IWorkflowAction DeleteDocGroupEmbeddedInvites(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/documentgroup/{0}/embedded-invites", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateDocGroupEmbeddedInvitesResponse> CreateDocGroupEmbeddedInvites(Expression<Func<string>> id, Expression<Func<inviteinvitesInputItem[]>> inviteinvites = null, Expression<Func<inviteadvancedInputItem[]>> inviteadvanced = null, Expression<Func<inviteqESSignatureInput>> inviteqESSignature = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_inviteinvites = WorkflowExpression.Compile(inviteinvites, nameof(inviteinvites), required: false);
            var __workflow_inviteadvanced = WorkflowExpression.Compile(inviteadvanced, nameof(inviteadvanced), required: false);
            var __workflow_inviteqESSignature = WorkflowExpression.Compile(inviteqESSignature, nameof(inviteqESSignature), required: false);
            return new DeferredBodyAction<CreateDocGroupEmbeddedInvitesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/documentgroup/{0}/embedded-invites", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var invite = new JObject();
                var invitepropCount = 0;
                if (__workflow_inviteinvites != null)
                {
                    invite["invites"] = ExpressionConverter.ConvertO(__workflow_inviteinvites);
                    invitepropCount++;
                }

                if (__workflow_inviteadvanced != null)
                {
                    invite["advanced"] = ExpressionConverter.ConvertO(__workflow_inviteadvanced);
                    invitepropCount++;
                }

                if (__workflow_inviteqESSignature != null)
                {
                    invite["signature"] = ExpressionConverter.ConvertO(__workflow_inviteqESSignature);
                    invitepropCount++;
                }

                if (invitepropCount > 0)
                {
                    callPayload.Body = invite;
                }

                return new ApiConnectionAction<CreateDocGroupEmbeddedInvitesResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<GenerateDocGroupEmbeddedInviteLinkResponse> GenerateDocGroupEmbeddedInviteLink(Expression<Func<string>> id, Expression<Func<string>> inviteId, Expression<Func<string>> inviteemail, Expression<Func<int>> invitelinkExpiration = null, Expression<Func<int>> invitesessionExpiration = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_inviteId = WorkflowExpression.Compile(inviteId, nameof(inviteId), required: true);
            var __workflow_inviteemail = WorkflowExpression.Compile(inviteemail, nameof(inviteemail), required: true);
            var __workflow_invitelinkExpiration = WorkflowExpression.Compile(invitelinkExpiration, nameof(invitelinkExpiration), required: false);
            var __workflow_invitesessionExpiration = WorkflowExpression.Compile(invitesessionExpiration, nameof(invitesessionExpiration), required: false);
            return new DeferredBodyAction<GenerateDocGroupEmbeddedInviteLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/documentgroup/{0}/embedded-invites/{1}/link", __workflow_id.WithUrlEncoding(1), __workflow_inviteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var invite = new JObject();
                var invitepropCount = 0;
                invitepropCount++;
                invite["email"] = ExpressionConverter.ConvertO(__workflow_inviteemail);
                if (__workflow_invitelinkExpiration != null)
                {
                    invite["link_expiration"] = ExpressionConverter.ConvertO(__workflow_invitelinkExpiration);
                    invitepropCount++;
                }

                if (__workflow_invitesessionExpiration != null)
                {
                    invite["session_expiration"] = ExpressionConverter.ConvertO(__workflow_invitesessionExpiration);
                    invitepropCount++;
                }

                if (invitepropCount > 0)
                {
                    callPayload.Body = invite;
                }

                return new ApiConnectionAction<GenerateDocGroupEmbeddedInviteLinkResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IWorkflowAction DeleteEmbeddedInvites(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/documents/{0}/embedded-invites", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateEmbeddedInvitesResponse> CreateEmbeddedInvites(Expression<Func<string>> id, Expression<Func<inviteinvitesInputItem2[]>> inviteinvites = null, Expression<Func<string>> invitenameFormula = null, Expression<Func<inviteinviteAdvancedParametersInputItem[]>> inviteinviteAdvancedParameters = null, Expression<Func<inviteqESSignatureInput>> inviteqESSignature = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_inviteinvites = WorkflowExpression.Compile(inviteinvites, nameof(inviteinvites), required: false);
            var __workflow_invitenameFormula = WorkflowExpression.Compile(invitenameFormula, nameof(invitenameFormula), required: false);
            var __workflow_inviteinviteAdvancedParameters = WorkflowExpression.Compile(inviteinviteAdvancedParameters, nameof(inviteinviteAdvancedParameters), required: false);
            var __workflow_inviteqESSignature = WorkflowExpression.Compile(inviteqESSignature, nameof(inviteqESSignature), required: false);
            return new DeferredBodyAction<CreateEmbeddedInvitesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/documents/{0}/embedded-invites", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var invite = new JObject();
                var invitepropCount = 0;
                if (__workflow_inviteinvites != null)
                {
                    invite["invites"] = ExpressionConverter.ConvertO(__workflow_inviteinvites);
                    invitepropCount++;
                }

                if (__workflow_invitenameFormula != null)
                {
                    invite["name_formula"] = ExpressionConverter.ConvertO(__workflow_invitenameFormula);
                    invitepropCount++;
                }

                if (__workflow_inviteinviteAdvancedParameters != null)
                {
                    invite["advanced_params"] = ExpressionConverter.ConvertO(__workflow_inviteinviteAdvancedParameters);
                    invitepropCount++;
                }

                if (__workflow_inviteqESSignature != null)
                {
                    invite["signature"] = ExpressionConverter.ConvertO(__workflow_inviteqESSignature);
                    invitepropCount++;
                }

                if (invitepropCount > 0)
                {
                    callPayload.Body = invite;
                }

                return new ApiConnectionAction<CreateEmbeddedInvitesResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<GenerateEmbeddedInviteLinkResponse> GenerateEmbeddedInviteLink(Expression<Func<string>> id, Expression<Func<string>> fieldInviteId, Expression<Func<int>> invitelinkExpiration = null, Expression<Func<int>> invitesessionExpiration = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_fieldInviteId = WorkflowExpression.Compile(fieldInviteId, nameof(fieldInviteId), required: true);
            var __workflow_invitelinkExpiration = WorkflowExpression.Compile(invitelinkExpiration, nameof(invitelinkExpiration), required: false);
            var __workflow_invitesessionExpiration = WorkflowExpression.Compile(invitesessionExpiration, nameof(invitesessionExpiration), required: false);
            return new DeferredBodyAction<GenerateEmbeddedInviteLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/documents/{0}/embedded-invites/{1}/link", __workflow_id.WithUrlEncoding(1), __workflow_fieldInviteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var invite = new JObject();
                var invitepropCount = 0;
                if (__workflow_invitelinkExpiration != null)
                {
                    invite["link_expiration"] = ExpressionConverter.ConvertO(__workflow_invitelinkExpiration);
                    invitepropCount++;
                }

                if (__workflow_invitesessionExpiration != null)
                {
                    invite["session_expiration"] = ExpressionConverter.ConvertO(__workflow_invitesessionExpiration);
                    invitepropCount++;
                }

                if (invitepropCount > 0)
                {
                    callPayload.Body = invite;
                }

                return new ApiConnectionAction<GenerateEmbeddedInviteLinkResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<DocumentGroupsResponse> GetListDocGroups(Expression<Func<bool>> template, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<DocumentGroupsResponse>(() =>
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateDocumentGroupFromFilesResponse> CreateDocGroupFromFiles(Expression<Func<string>> bodydocumentGroupName, Expression<Func<bodydocumentsInputItem[]>> bodydocuments = null)
        {
            var __workflow_bodydocumentGroupName = WorkflowExpression.Compile(bodydocumentGroupName, nameof(bodydocumentGroupName), required: true);
            var __workflow_bodydocuments = WorkflowExpression.Compile(bodydocuments, nameof(bodydocuments), required: false);
            return new DeferredBodyAction<CreateDocumentGroupFromFilesResponse>(() =>
            {
                var apiCallPath = "/documentgroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["group_name"] = ExpressionConverter.ConvertO(__workflow_bodydocumentGroupName);
                if (__workflow_bodydocuments != null)
                {
                    body["documents"] = ExpressionConverter.ConvertO(__workflow_bodydocuments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateDocumentGroupFromFilesResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<DocumentGroupProperties> GetDocumentGroup(Expression<Func<string>> docGroupId, Expression<Func<bool>> template)
        {
            var __workflow_docGroupId = WorkflowExpression.Compile(docGroupId, nameof(docGroupId), required: true);
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: true);
            return new DeferredBodyAction<DocumentGroupProperties>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/documentgroups/{0}", __workflow_docGroupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                return new ApiConnectionAction<DocumentGroupProperties>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateFromTemplateGroupResponse> CreateFromTemplateGroup(Expression<Func<string>> docGroupId, Expression<Func<string>> bodydocumentGroupName = null)
        {
            var __workflow_docGroupId = WorkflowExpression.Compile(docGroupId, nameof(docGroupId), required: true);
            var __workflow_bodydocumentGroupName = WorkflowExpression.Compile(bodydocumentGroupName, nameof(bodydocumentGroupName), required: false);
            return new DeferredBodyAction<CreateFromTemplateGroupResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/documentgroups/{0}", __workflow_docGroupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydocumentGroupName != null)
                {
                    body["group_name"] = ExpressionConverter.ConvertO(__workflow_bodydocumentGroupName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateFromTemplateGroupResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<UpdateGroupFieldValuesResponse> UpdateGroupFieldValues(Expression<Func<string>> templateGroupId, Expression<Func<string>> docGroupId, Expression<Func<object>> fields = null)
        {
            var __workflow_templateGroupId = WorkflowExpression.Compile(templateGroupId, nameof(templateGroupId), required: true);
            var __workflow_docGroupId = WorkflowExpression.Compile(docGroupId, nameof(docGroupId), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<UpdateGroupFieldValuesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/documentgroup/{0}/fields", __workflow_docGroupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_group_id"] = ExpressionConverter.Convert(__workflow_templateGroupId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_fields);
                return new ApiConnectionAction<UpdateGroupFieldValuesResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<UpdateGroupSmartFieldValuesResponse> UpdateGroupSmartFieldValues(Expression<Func<string>> templateGroupId, Expression<Func<string>> docGroupId, Expression<Func<object>> fields = null)
        {
            var __workflow_templateGroupId = WorkflowExpression.Compile(templateGroupId, nameof(templateGroupId), required: true);
            var __workflow_docGroupId = WorkflowExpression.Compile(docGroupId, nameof(docGroupId), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<UpdateGroupSmartFieldValuesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/documentgroup/{0}/smartfields", __workflow_docGroupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_group_id"] = ExpressionConverter.Convert(__workflow_templateGroupId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_fields);
                return new ApiConnectionAction<UpdateGroupSmartFieldValuesResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<DocumentProperties[]> GetListDoc(Expression<Func<bool>> template = null, Expression<Func<bool>> includeDefaultTemplate = null)
        {
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: false);
            var __workflow_includeDefaultTemplate = WorkflowExpression.Compile(includeDefaultTemplate, nameof(includeDefaultTemplate), required: false);
            return new DeferredBodyAction<DocumentProperties[]>(() =>
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<UploadDocumentResponse> UploadDocument(Expression<Func<object>> file)
        {
            var __workflow_file = WorkflowExpression.Compile(file, nameof(file), required: true);
            return new DeferredBodyAction<UploadDocumentResponse>(() =>
            {
                var apiCallPath = "/document";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UploadDocumentResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<DocumentProperties> GetDoc(Expression<Func<bool>> template, Expression<Func<string>> docId)
        {
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: true);
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            return new DeferredBodyAction<DocumentProperties>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                return new ApiConnectionAction<DocumentProperties>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<DeleteDocResponse> DeleteDoc(Expression<Func<string>> docId)
        {
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            return new DeferredBodyAction<DeleteDocResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteDocResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateFromTemplateResponse> CreateFromTemplate(Expression<Func<string>> docId, Expression<Func<string>> bodydocumentName = null)
        {
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            var __workflow_bodydocumentName = WorkflowExpression.Compile(bodydocumentName, nameof(bodydocumentName), required: false);
            return new DeferredBodyAction<CreateFromTemplateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydocumentName != null)
                {
                    body["document_name"] = ExpressionConverter.ConvertO(__workflow_bodydocumentName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateFromTemplateResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateSigningLinkResponse> CreateSigningLink(Expression<Func<string>> docId, Expression<Func<object>> fields = null)
        {
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<CreateSigningLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}/link", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_fields);
                return new ApiConnectionAction<CreateSigningLinkResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<JToken> SendInvite(Expression<Func<bool>> template, Expression<Func<string>> templateId, Expression<Func<object>> body = null)
        {
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}/invite", __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<JToken> SendGroupInvite(Expression<Func<bool>> template, Expression<Func<string>> templateGroupId, Expression<Func<object>> body = null)
        {
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: true);
            var __workflow_templateGroupId = WorkflowExpression.Compile(templateGroupId, nameof(templateGroupId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/documentgroup/{0}/invite", __workflow_templateGroupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template"] = ExpressionConverter.Convert(__workflow_template);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<JToken> SendUserDefinedInvite(Expression<Func<string>> docId, Expression<Func<bodyroleInputItem[]>> bodyrole = null, Expression<Func<string>> bodycC = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodymessage = null, Expression<Func<string>> bodyemailAllPartiesOnCompletion = null)
        {
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            var __workflow_bodyrole = WorkflowExpression.Compile(bodyrole, nameof(bodyrole), required: false);
            var __workflow_bodycC = WorkflowExpression.Compile(bodycC, nameof(bodycC), required: false);
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: false);
            var __workflow_bodyemailAllPartiesOnCompletion = WorkflowExpression.Compile(bodyemailAllPartiesOnCompletion, nameof(bodyemailAllPartiesOnCompletion), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}/invite-user-defined-schema", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyrole != null)
                {
                    body["Role"] = ExpressionConverter.ConvertO(__workflow_bodyrole);
                    bodypropCount++;
                }

                if (__workflow_bodycC != null)
                {
                    body["cc"] = ExpressionConverter.ConvertO(__workflow_bodycC);
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                if (__workflow_bodyemailAllPartiesOnCompletion != null)
                {
                    body["on_complete"] = ExpressionConverter.ConvertO(__workflow_bodyemailAllPartiesOnCompletion);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<JToken> CancelInvite(Expression<Func<string>> docId)
        {
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}/invite-cancel", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<string> DownloadDocument(Expression<Func<string>> docId, Expression<Func<string>> mode = null)
        {
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            var __workflow_mode = WorkflowExpression.Compile(mode, nameof(mode), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}/download", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mode"] = Convert.ToString("Collapsed");
                if (__workflow_mode != null)
                    callPayload.Queries["mode"] = ExpressionConverter.Convert(__workflow_mode);
                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IWorkflowAction PrefillSmartFields(Expression<Func<string>> templateId, Expression<Func<string>> docId, Expression<Func<object>> fields = null)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}/smartfields", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_id"] = ExpressionConverter.Convert(__workflow_templateId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_fields);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<GetInviteStatusResponse> GetInviteStatus(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetInviteStatusResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}/invite-status", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetInviteStatusResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<GetDocumentGroupInviteStatusResponse> GetDocumentGroupInviteStatus(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetDocumentGroupInviteStatusResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/documentgroups/{0}/invite-status", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentGroupInviteStatusResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<ReplaceRecipientsInDocumentInviteResponse> ReplaceRecipientsInDocumentInvite(Expression<Func<string>> id, Expression<Func<replaceToreplaceToInputItem[]>> replaceToreplaceTo = null, Expression<Func<replaceToadvancedParametersInputItem[]>> replaceToadvancedParameters = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_replaceToreplaceTo = WorkflowExpression.Compile(replaceToreplaceTo, nameof(replaceToreplaceTo), required: false);
            var __workflow_replaceToadvancedParameters = WorkflowExpression.Compile(replaceToadvancedParameters, nameof(replaceToadvancedParameters), required: false);
            return new DeferredBodyAction<ReplaceRecipientsInDocumentInviteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}/replace-recipients", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var replaceTo = new JObject();
                var replaceTopropCount = 0;
                if (__workflow_replaceToreplaceTo != null)
                {
                    replaceTo["replace_to"] = ExpressionConverter.ConvertO(__workflow_replaceToreplaceTo);
                    replaceTopropCount++;
                }

                if (__workflow_replaceToadvancedParameters != null)
                {
                    replaceTo["advanced"] = ExpressionConverter.ConvertO(__workflow_replaceToadvancedParameters);
                    replaceTopropCount++;
                }

                if (replaceTopropCount > 0)
                {
                    callPayload.Body = replaceTo;
                }

                return new ApiConnectionAction<ReplaceRecipientsInDocumentInviteResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<ReplaceRecipientsInDocumentGroupInviteResponse> ReplaceRecipientsInDocumentGroupInvite(Expression<Func<string>> id, Expression<Func<string>> inviteId, Expression<Func<string>> replaceTostepID = null, Expression<Func<string>> replaceTorecipientToReplace = null, Expression<Func<string>> replaceTonewRecipient = null, Expression<Func<int>> replaceToexpirationDays = null, Expression<Func<int>> replaceToreminder = null, Expression<Func<replaceToinviteActionAttributesInputItem[]>> replaceToinviteActionAttributes = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_inviteId = WorkflowExpression.Compile(inviteId, nameof(inviteId), required: true);
            var __workflow_replaceTostepID = WorkflowExpression.Compile(replaceTostepID, nameof(replaceTostepID), required: false);
            var __workflow_replaceTorecipientToReplace = WorkflowExpression.Compile(replaceTorecipientToReplace, nameof(replaceTorecipientToReplace), required: false);
            var __workflow_replaceTonewRecipient = WorkflowExpression.Compile(replaceTonewRecipient, nameof(replaceTonewRecipient), required: false);
            var __workflow_replaceToexpirationDays = WorkflowExpression.Compile(replaceToexpirationDays, nameof(replaceToexpirationDays), required: false);
            var __workflow_replaceToreminder = WorkflowExpression.Compile(replaceToreminder, nameof(replaceToreminder), required: false);
            var __workflow_replaceToinviteActionAttributes = WorkflowExpression.Compile(replaceToinviteActionAttributes, nameof(replaceToinviteActionAttributes), required: false);
            return new DeferredBodyAction<ReplaceRecipientsInDocumentGroupInviteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/documentgroup/{0}/invite/{1}/replace-recipients", __workflow_id.WithUrlEncoding(1), __workflow_inviteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var replaceTo = new JObject();
                var replaceTopropCount = 0;
                if (__workflow_replaceTostepID != null)
                {
                    replaceTo["step_id"] = ExpressionConverter.ConvertO(__workflow_replaceTostepID);
                    replaceTopropCount++;
                }

                if (__workflow_replaceTorecipientToReplace != null)
                {
                    replaceTo["recipient_to_update"] = ExpressionConverter.ConvertO(__workflow_replaceTorecipientToReplace);
                    replaceTopropCount++;
                }

                if (__workflow_replaceTonewRecipient != null)
                {
                    replaceTo["new_recipient"] = ExpressionConverter.ConvertO(__workflow_replaceTonewRecipient);
                    replaceTopropCount++;
                }

                if (__workflow_replaceToexpirationDays != null)
                {
                    if (__workflow_replaceToexpirationDays != null)
                    {
                        replaceTo["expiration_days"] = ExpressionConverter.ConvertO(__workflow_replaceToexpirationDays);
                        replaceTopropCount++;
                    }

                    replaceTopropCount++;
                }
                else
                {
                    replaceTo["expiration_days"] = 30;
                    replaceTopropCount++;
                }

                if (__workflow_replaceToreminder != null)
                {
                    replaceTo["reminder"] = ExpressionConverter.ConvertO(__workflow_replaceToreminder);
                    replaceTopropCount++;
                }

                if (__workflow_replaceToinviteActionAttributes != null)
                {
                    replaceTo["invite_action_attributes"] = ExpressionConverter.ConvertO(__workflow_replaceToinviteActionAttributes);
                    replaceTopropCount++;
                }

                if (replaceTopropCount > 0)
                {
                    callPayload.Body = replaceTo;
                }

                return new ApiConnectionAction<ReplaceRecipientsInDocumentGroupInviteResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateEmbeddedInviteSettingsLinkResponse> CreateEmbeddedInviteSettingsLink(Expression<Func<string>> id, Expression<Func<inviteSettingstypeInput>> inviteSettingstype = null, Expression<Func<string>> inviteSettingsredirectUri = null, Expression<Func<int>> inviteSettingslinkExpiration = null, Expression<Func<inviteSettingsredirectTargetInput>> inviteSettingsredirectTarget = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_inviteSettingstype = WorkflowExpression.Compile(inviteSettingstype, nameof(inviteSettingstype), required: false);
            var __workflow_inviteSettingsredirectUri = WorkflowExpression.Compile(inviteSettingsredirectUri, nameof(inviteSettingsredirectUri), required: false);
            var __workflow_inviteSettingslinkExpiration = WorkflowExpression.Compile(inviteSettingslinkExpiration, nameof(inviteSettingslinkExpiration), required: false);
            var __workflow_inviteSettingsredirectTarget = WorkflowExpression.Compile(inviteSettingsredirectTarget, nameof(inviteSettingsredirectTarget), required: false);
            return new DeferredBodyAction<CreateEmbeddedInviteSettingsLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/documents/{0}/embedded-sending", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inviteSettings = new JObject();
                var inviteSettingspropCount = 0;
                if (__workflow_inviteSettingstype != null)
                {
                    inviteSettings["type"] = ExpressionConverter.ConvertO(__workflow_inviteSettingstype);
                    inviteSettingspropCount++;
                }

                if (__workflow_inviteSettingsredirectUri != null)
                {
                    inviteSettings["redirect_uri"] = ExpressionConverter.ConvertO(__workflow_inviteSettingsredirectUri);
                    inviteSettingspropCount++;
                }

                if (__workflow_inviteSettingslinkExpiration != null)
                {
                    if (__workflow_inviteSettingslinkExpiration != null)
                    {
                        inviteSettings["link_expiration"] = ExpressionConverter.ConvertO(__workflow_inviteSettingslinkExpiration);
                        inviteSettingspropCount++;
                    }

                    inviteSettingspropCount++;
                }
                else
                {
                    inviteSettings["link_expiration"] = 15;
                    inviteSettingspropCount++;
                }

                if (__workflow_inviteSettingsredirectTarget != null)
                {
                    inviteSettings["redirect_target"] = ExpressionConverter.ConvertO(__workflow_inviteSettingsredirectTarget);
                    inviteSettingspropCount++;
                }

                if (inviteSettingspropCount > 0)
                {
                    callPayload.Body = inviteSettings;
                }

                return new ApiConnectionAction<CreateEmbeddedInviteSettingsLinkResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateDocGroupEmbeddedInviteSettingsLinkResponse> CreateDocGroupEmbeddedInviteSettingsLink(Expression<Func<string>> id, Expression<Func<inviteSettingstypeInput>> inviteSettingstype = null, Expression<Func<string>> inviteSettingsredirectUri = null, Expression<Func<int>> inviteSettingslinkExpiration = null, Expression<Func<inviteSettingsredirectTargetInput>> inviteSettingsredirectTarget = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_inviteSettingstype = WorkflowExpression.Compile(inviteSettingstype, nameof(inviteSettingstype), required: false);
            var __workflow_inviteSettingsredirectUri = WorkflowExpression.Compile(inviteSettingsredirectUri, nameof(inviteSettingsredirectUri), required: false);
            var __workflow_inviteSettingslinkExpiration = WorkflowExpression.Compile(inviteSettingslinkExpiration, nameof(inviteSettingslinkExpiration), required: false);
            var __workflow_inviteSettingsredirectTarget = WorkflowExpression.Compile(inviteSettingsredirectTarget, nameof(inviteSettingsredirectTarget), required: false);
            return new DeferredBodyAction<CreateDocGroupEmbeddedInviteSettingsLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/documentgroup/{0}/embedded-sending", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inviteSettings = new JObject();
                var inviteSettingspropCount = 0;
                if (__workflow_inviteSettingstype != null)
                {
                    if (__workflow_inviteSettingstype != null)
                    {
                        inviteSettings["type"] = ExpressionConverter.ConvertO(__workflow_inviteSettingstype);
                        inviteSettingspropCount++;
                    }

                    inviteSettingspropCount++;
                }
                else
                {
                    inviteSettings["type"] = "Manage";
                    inviteSettingspropCount++;
                }

                if (__workflow_inviteSettingsredirectUri != null)
                {
                    inviteSettings["redirect_uri"] = ExpressionConverter.ConvertO(__workflow_inviteSettingsredirectUri);
                    inviteSettingspropCount++;
                }

                if (__workflow_inviteSettingslinkExpiration != null)
                {
                    if (__workflow_inviteSettingslinkExpiration != null)
                    {
                        inviteSettings["link_expiration"] = ExpressionConverter.ConvertO(__workflow_inviteSettingslinkExpiration);
                        inviteSettingspropCount++;
                    }

                    inviteSettingspropCount++;
                }
                else
                {
                    inviteSettings["link_expiration"] = 15;
                    inviteSettingspropCount++;
                }

                if (__workflow_inviteSettingsredirectTarget != null)
                {
                    inviteSettings["redirect_target"] = ExpressionConverter.ConvertO(__workflow_inviteSettingsredirectTarget);
                    inviteSettingspropCount++;
                }

                if (inviteSettingspropCount > 0)
                {
                    callPayload.Body = inviteSettings;
                }

                return new ApiConnectionAction<CreateDocGroupEmbeddedInviteSettingsLinkResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<InviteToSignAllOptionsResponse> InviteToSignAllOptions(Expression<Func<string>> id, Expression<Func<invitesignersInputItem[]>> invitesigners = null, Expression<Func<invitesignerAdvancedPropertiesInputItem[]>> invitesignerAdvancedProperties = null, Expression<Func<inviteviewersInputItem[]>> inviteviewers = null, Expression<Func<inviteviewerAdvancedPropertiesInputItem[]>> inviteviewerAdvancedProperties = null, Expression<Func<inviteapproversInputItem[]>> inviteapprovers = null, Expression<Func<inviteapproverAdvancedPropertiesInputItem[]>> inviteapproverAdvancedProperties = null, Expression<Func<string>> invitefrom = null, Expression<Func<inviteemailGroupsInputItem[]>> inviteemailGroups = null, Expression<Func<invitecCInputItem[]>> invitecC = null, Expression<Func<invitecCStepsInputItem[]>> invitecCSteps = null, Expression<Func<string>> invitesubject = null, Expression<Func<string>> invitemessage = null, Expression<Func<string>> invitecCSubject = null, Expression<Func<string>> invitecCMessage = null, Expression<Func<inviteqESSignatureInput>> inviteqESSignature = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_invitesigners = WorkflowExpression.Compile(invitesigners, nameof(invitesigners), required: false);
            var __workflow_invitesignerAdvancedProperties = WorkflowExpression.Compile(invitesignerAdvancedProperties, nameof(invitesignerAdvancedProperties), required: false);
            var __workflow_inviteviewers = WorkflowExpression.Compile(inviteviewers, nameof(inviteviewers), required: false);
            var __workflow_inviteviewerAdvancedProperties = WorkflowExpression.Compile(inviteviewerAdvancedProperties, nameof(inviteviewerAdvancedProperties), required: false);
            var __workflow_inviteapprovers = WorkflowExpression.Compile(inviteapprovers, nameof(inviteapprovers), required: false);
            var __workflow_inviteapproverAdvancedProperties = WorkflowExpression.Compile(inviteapproverAdvancedProperties, nameof(inviteapproverAdvancedProperties), required: false);
            var __workflow_invitefrom = WorkflowExpression.Compile(invitefrom, nameof(invitefrom), required: false);
            var __workflow_inviteemailGroups = WorkflowExpression.Compile(inviteemailGroups, nameof(inviteemailGroups), required: false);
            var __workflow_invitecC = WorkflowExpression.Compile(invitecC, nameof(invitecC), required: false);
            var __workflow_invitecCSteps = WorkflowExpression.Compile(invitecCSteps, nameof(invitecCSteps), required: false);
            var __workflow_invitesubject = WorkflowExpression.Compile(invitesubject, nameof(invitesubject), required: false);
            var __workflow_invitemessage = WorkflowExpression.Compile(invitemessage, nameof(invitemessage), required: false);
            var __workflow_invitecCSubject = WorkflowExpression.Compile(invitecCSubject, nameof(invitecCSubject), required: false);
            var __workflow_invitecCMessage = WorkflowExpression.Compile(invitecCMessage, nameof(invitecCMessage), required: false);
            var __workflow_inviteqESSignature = WorkflowExpression.Compile(inviteqESSignature, nameof(inviteqESSignature), required: false);
            return new DeferredBodyAction<InviteToSignAllOptionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}/invite-all-options", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var invite = new JObject();
                var invitepropCount = 0;
                if (__workflow_invitesigners != null)
                {
                    invite["signers"] = ExpressionConverter.ConvertO(__workflow_invitesigners);
                    invitepropCount++;
                }

                if (__workflow_invitesignerAdvancedProperties != null)
                {
                    invite["signers_advanced"] = ExpressionConverter.ConvertO(__workflow_invitesignerAdvancedProperties);
                    invitepropCount++;
                }

                if (__workflow_inviteviewers != null)
                {
                    invite["viewers"] = ExpressionConverter.ConvertO(__workflow_inviteviewers);
                    invitepropCount++;
                }

                if (__workflow_inviteviewerAdvancedProperties != null)
                {
                    invite["viewers_advanced"] = ExpressionConverter.ConvertO(__workflow_inviteviewerAdvancedProperties);
                    invitepropCount++;
                }

                if (__workflow_inviteapprovers != null)
                {
                    invite["approvers"] = ExpressionConverter.ConvertO(__workflow_inviteapprovers);
                    invitepropCount++;
                }

                if (__workflow_inviteapproverAdvancedProperties != null)
                {
                    invite["approver_advanced"] = ExpressionConverter.ConvertO(__workflow_inviteapproverAdvancedProperties);
                    invitepropCount++;
                }

                if (__workflow_invitefrom != null)
                {
                    invite["from"] = ExpressionConverter.ConvertO(__workflow_invitefrom);
                    invitepropCount++;
                }

                if (__workflow_inviteemailGroups != null)
                {
                    invite["email_groups"] = ExpressionConverter.ConvertO(__workflow_inviteemailGroups);
                    invitepropCount++;
                }

                if (__workflow_invitecC != null)
                {
                    invite["cc"] = ExpressionConverter.ConvertO(__workflow_invitecC);
                    invitepropCount++;
                }

                if (__workflow_invitecCSteps != null)
                {
                    invite["cc_step"] = ExpressionConverter.ConvertO(__workflow_invitecCSteps);
                    invitepropCount++;
                }

                if (__workflow_invitesubject != null)
                {
                    invite["subject"] = ExpressionConverter.ConvertO(__workflow_invitesubject);
                    invitepropCount++;
                }

                if (__workflow_invitemessage != null)
                {
                    invite["message"] = ExpressionConverter.ConvertO(__workflow_invitemessage);
                    invitepropCount++;
                }

                if (__workflow_invitecCSubject != null)
                {
                    invite["cc_subject"] = ExpressionConverter.ConvertO(__workflow_invitecCSubject);
                    invitepropCount++;
                }

                if (__workflow_invitecCMessage != null)
                {
                    invite["cc_message"] = ExpressionConverter.ConvertO(__workflow_invitecCMessage);
                    invitepropCount++;
                }

                if (__workflow_inviteqESSignature != null)
                {
                    invite["signature"] = ExpressionConverter.ConvertO(__workflow_inviteqESSignature);
                    invitepropCount++;
                }

                if (invitepropCount > 0)
                {
                    callPayload.Body = invite;
                }

                return new ApiConnectionAction<InviteToSignAllOptionsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<InviteToSignDocGroupAllOptionsResponse> InviteToSignDocGroupAllOptions(Expression<Func<string>> id, Expression<Func<inviteinviteStepsInputItem[]>> inviteinviteSteps = null, Expression<Func<inviteinviteEmailsInputItem[]>> inviteinviteEmails = null, Expression<Func<inviteemailGroupsInputItem2[]>> inviteemailGroups = null, Expression<Func<invitecompletionEmailsInputItem[]>> invitecompletionEmails = null, Expression<Func<bool>> invitesignAsMerged = null, Expression<Func<int>> inviteclientTimestamp = null, Expression<Func<invitecCInputItem[]>> invitecC = null, Expression<Func<inviteqESSignatureInput>> inviteqESSignature = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_inviteinviteSteps = WorkflowExpression.Compile(inviteinviteSteps, nameof(inviteinviteSteps), required: false);
            var __workflow_inviteinviteEmails = WorkflowExpression.Compile(inviteinviteEmails, nameof(inviteinviteEmails), required: false);
            var __workflow_inviteemailGroups = WorkflowExpression.Compile(inviteemailGroups, nameof(inviteemailGroups), required: false);
            var __workflow_invitecompletionEmails = WorkflowExpression.Compile(invitecompletionEmails, nameof(invitecompletionEmails), required: false);
            var __workflow_invitesignAsMerged = WorkflowExpression.Compile(invitesignAsMerged, nameof(invitesignAsMerged), required: false);
            var __workflow_inviteclientTimestamp = WorkflowExpression.Compile(inviteclientTimestamp, nameof(inviteclientTimestamp), required: false);
            var __workflow_invitecC = WorkflowExpression.Compile(invitecC, nameof(invitecC), required: false);
            var __workflow_inviteqESSignature = WorkflowExpression.Compile(inviteqESSignature, nameof(inviteqESSignature), required: false);
            return new DeferredBodyAction<InviteToSignDocGroupAllOptionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/documentgroup/{0}/invite-all-options", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var invite = new JObject();
                var invitepropCount = 0;
                if (__workflow_inviteinviteSteps != null)
                {
                    invite["invite_steps"] = ExpressionConverter.ConvertO(__workflow_inviteinviteSteps);
                    invitepropCount++;
                }

                if (__workflow_inviteinviteEmails != null)
                {
                    invite["Email"] = ExpressionConverter.ConvertO(__workflow_inviteinviteEmails);
                    invitepropCount++;
                }

                if (__workflow_inviteemailGroups != null)
                {
                    invite["email_groups"] = ExpressionConverter.ConvertO(__workflow_inviteemailGroups);
                    invitepropCount++;
                }

                if (__workflow_invitecompletionEmails != null)
                {
                    invite["completion_emails"] = ExpressionConverter.ConvertO(__workflow_invitecompletionEmails);
                    invitepropCount++;
                }

                if (__workflow_invitesignAsMerged != null)
                {
                    invite["sign_as_merged"] = ExpressionConverter.ConvertO(__workflow_invitesignAsMerged);
                    invitepropCount++;
                }

                if (__workflow_inviteclientTimestamp != null)
                {
                    invite["client_timestamp"] = ExpressionConverter.ConvertO(__workflow_inviteclientTimestamp);
                    invitepropCount++;
                }

                if (__workflow_invitecC != null)
                {
                    invite["cc"] = ExpressionConverter.ConvertO(__workflow_invitecC);
                    invitepropCount++;
                }

                if (__workflow_inviteqESSignature != null)
                {
                    invite["signature"] = ExpressionConverter.ConvertO(__workflow_inviteqESSignature);
                    invitepropCount++;
                }

                if (invitepropCount > 0)
                {
                    callPayload.Body = invite;
                }

                return new ApiConnectionAction<InviteToSignDocGroupAllOptionsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<JToken> GetDocFields(Expression<Func<string>> templateId, Expression<Func<string>> docId)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/document/{0}/fields", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_id"] = ExpressionConverter.Convert(__workflow_templateId);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<UpdateFieldValuesV2Response> UpdateFieldValues(Expression<Func<string>> templateId, Expression<Func<string>> docId, Expression<Func<object>> fields = null)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<UpdateFieldValuesV2Response>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/document/{0}/fields", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_id"] = ExpressionConverter.Convert(__workflow_templateId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_fields);
                return new ApiConnectionAction<UpdateFieldValuesV2Response>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class SignnowTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TriggersV2Response> Triggers(Expression<Func<string>> bodyevent, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyevent = WorkflowExpression.Compile(bodyevent, nameof(bodyevent), required: true);
            return new DeferredBodyTrigger<TriggersV2Response>(() =>
            {
                var apiCallPath = "/multievent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event"] = ExpressionConverter.ConvertO(__workflow_bodyevent);
                body["entity_id"] = "00000000-0000-0000-0000-000000000000";
                bodypropCount++;
                body["action"] = "callback";
                bodypropCount++;
                var attributesObject = new JObject();
                var attributesObjectpropCount = 0;
                attributesObject["callback"] = "#{listCallbackUrl()}";
                attributesObjectpropCount++;
                if (attributesObjectpropCount > 0)
                {
                    body["attributes"] = attributesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<TriggersV2Response>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }
    }

    public class CreateDocGroupEmbeddedInvitesResponse
    {
        [JsonProperty("id")]
        public string InviteID { get; set; }
    }

    public class inviteinvitesInputItem
    {
        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("signers")]
        public inviteinvitesInputItemSignersTypeItem[] Signers { get; set; }
    }

    public class inviteinvitesInputItemSignersTypeItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("documents")]
        public inviteinvitesInputItemSignersTypeItemDocumentsTypeItem[] Documents { get; set; }
    }

    public class inviteinvitesInputItemSignersTypeItemDocumentsTypeItem
    {
        [JsonProperty("id")]
        public string DocumentId { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("action")]
        public inviteinvitesInputItemSignersTypeItemDocumentsTypeItemActionType Action { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inviteinvitesInputItemSignersTypeItemDocumentsTypeItemActionType
    {
        Sign,
        View
    }

    public class inviteadvancedInputItem
    {
        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("language")]
        public inviteadvancedInputItemLanguageType Language { get; set; }

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
        public inviteadvancedInputItemRedirectTargetType RedirectTarget { get; set; }

        [JsonProperty("delivery_type")]
        public inviteadvancedInputItemDeliveryTypeType DeliveryType { get; set; }

        [JsonProperty("link_expiration")]
        public int LinkExpiration { get; set; }

        [JsonProperty("session_expiration")]
        public int SessionExpiration { get; set; }

        [JsonProperty("authentication_type")]
        public inviteadvancedInputItemAuthenticationTypeType AuthenticationType { get; set; }

        [JsonProperty("authentication_password")]
        public string AuthenticationPassword { get; set; }

        [JsonProperty("authentication_phone")]
        public string AuthenticationPhone { get; set; }

        [JsonProperty("authentication_sms_message")]
        public string AuthenticationSmsMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inviteadvancedInputItemLanguageType
    {
        En,
        Es,
        Fr
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inviteadvancedInputItemRedirectTargetType
    {
        [EnumMember(Value = "In the new tab")]
        InTheNewTab,
        [EnumMember(Value = "In the same tab")]
        InTheSameTab
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inviteadvancedInputItemDeliveryTypeType
    {
        Email,
        Link
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inviteadvancedInputItemAuthenticationTypeType
    {
        Password,
        [EnumMember(Value = "Phone call")]
        PhoneCall,
        Sms
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inviteqESSignatureInput
    {
        Eideasy,
        Nom151
    }

    public class GenerateDocGroupEmbeddedInviteLinkResponse
    {
        [JsonProperty("link")]
        public string EmbeddedInviteLink { get; set; }
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
        public string RoleID { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class inviteinvitesInputItem2
    {
        [JsonProperty("email")]
        public string SignerEmail { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }
    }

    public class inviteinviteAdvancedParametersInputItem
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("language")]
        public inviteinviteAdvancedParametersInputItemLanguageType Language { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("required_preset_signature_name")]
        public string RequiredPresetSignatureName { get; set; }

        [JsonProperty("prefill_signature_name")]
        public string PrefillSignatureName { get; set; }

        [JsonProperty("force_new_signature")]
        public bool RequireNewSignature { get; set; }

        [JsonProperty("redirect_uri")]
        public string RedirectUri { get; set; }

        [JsonProperty("decline_redirect_uri")]
        public string DeclineRedirectUri { get; set; }

        [JsonProperty("close_redirect_uri")]
        public string CloseRedirectUri { get; set; }

        [JsonProperty("redirect_target")]
        public inviteinviteAdvancedParametersInputItemRedirectTargetType RedirectTarget { get; set; }

        [JsonProperty("authentication_type")]
        public inviteinviteAdvancedParametersInputItemAuthenticationTypeType AuthenticationType { get; set; }

        [JsonProperty("authentication_password")]
        public string AuthenticationPassword { get; set; }

        [JsonProperty("authentication_phone")]
        public string AuthenticationPhone { get; set; }

        [JsonProperty("authentication_sms_message")]
        public string AuthenticationSmsMessage { get; set; }

        [JsonProperty("delivery_type")]
        public inviteinviteAdvancedParametersInputItemDeliveryTypeType DeliveryType { get; set; }

        [JsonProperty("link_expiration")]
        public int LinkExpiration { get; set; }

        [JsonProperty("session_expiration")]
        public int SessionExpiration { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inviteinviteAdvancedParametersInputItemLanguageType
    {
        En,
        Es,
        Fr
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inviteinviteAdvancedParametersInputItemRedirectTargetType
    {
        [EnumMember(Value = "In the new tab")]
        InTheNewTab,
        [EnumMember(Value = "In the same tab")]
        InTheSameTab
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inviteinviteAdvancedParametersInputItemAuthenticationTypeType
    {
        Password,
        [EnumMember(Value = "Phone call")]
        PhoneCall,
        Sms
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inviteinviteAdvancedParametersInputItemDeliveryTypeType
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
        public string TemplateID { get; set; }
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

    public class bodydocumentsInputItem
    {
        [JsonProperty("name")]
        public string DocumentName { get; set; }

        [JsonProperty("content")]
        public string FileContent { get; set; }
    }

    public class CreateFromTemplateGroupResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
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
        public string TemplateID { get; set; }

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

    public class UploadDocumentResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
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

    public class CreateSigningLinkResponse
    {
        [JsonProperty("url_no_signup")]
        public string URL { get; set; }
    }

    public class bodyroleInputItem
    {
        [JsonProperty("role")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string EMail { get; set; }

        [JsonProperty("phone_invite")]
        public string PhoneNumberInviteViaSMS { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("subject")]
        public string PersonalizedSubject { get; set; }

        [JsonProperty("message")]
        public string PersonalizedMessage { get; set; }

        [JsonProperty("authentication_type")]
        public bodyroleInputItemAuthenticationTypeType AuthenticationType { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("expiration_days")]
        public int DaysUntilExpiration { get; set; }

        [JsonProperty("reminder")]
        public int SendReminderIn { get; set; }

        [JsonProperty("remind_repeat")]
        public int SendReminderEveryXDays { get; set; }

        [JsonProperty("reassign")]
        public bool AllowForwarding { get; set; }

        [JsonProperty("decline_by_signature")]
        public bool ShowDeclineOnSignature { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyroleInputItemAuthenticationTypeType
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
        public string InviteID { get; set; }

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
        public string StepID { get; set; }

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
        public string StepInviteID { get; set; }

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
        public string NewInviteID { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("new_email")]
        public string NewEmail { get; set; }
    }

    public class replaceToreplaceToInputItem
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("email")]
        public string NewEmail { get; set; }
    }

    public class replaceToadvancedParametersInputItem
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("expiration_days")]
        public int ExpirationDays { get; set; }

        [JsonProperty("decline_by_signature")]
        public bool AllowDeclineBySignature { get; set; }

        [JsonProperty("reminder")]
        public int Reminder { get; set; }

        [JsonProperty("authentication_type")]
        public replaceToadvancedParametersInputItemAuthenticationTypeType AuthenticationType { get; set; }

        [JsonProperty("authentication_password")]
        public string AuthenticationPassword { get; set; }

        [JsonProperty("authentication_phone")]
        public string AuthenticationPhone { get; set; }

        [JsonProperty("authentication_sms_message")]
        public string AuthenticationSmsMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum replaceToadvancedParametersInputItemAuthenticationTypeType
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

    public class replaceToinviteActionAttributesInputItem
    {
        [JsonProperty("document_id")]
        public string DocumentID { get; set; }

        [JsonProperty("allow_forwarding")]
        public bool AllowForwarding { get; set; }

        [JsonProperty("decline_by_signature")]
        public bool AllowDeclineBySignature { get; set; }
    }

    public class CreateEmbeddedInviteSettingsLinkResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inviteSettingstypeInput
    {
        Manage,
        Edit,
        [EnumMember(Value = "Send-invite")]
        SendInvite
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inviteSettingsredirectTargetInput
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

    public class InviteToSignAllOptionsResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class invitesignersInputItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("email_group")]
        public string EmailGroup { get; set; }

        [JsonProperty("phone_invite")]
        public string PhoneInvite { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }
    }

    public class invitesignerAdvancedPropertiesInputItem
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("prefill_signature_name")]
        public string PrefillSignatureName { get; set; }

        [JsonProperty("required_preset_signature_name")]
        public string RequiredPresetSignatureName { get; set; }

        [JsonProperty("force_new_signature")]
        public bool RequireNewSignature { get; set; }

        [JsonProperty("reassign")]
        public bool AllowForwarding { get; set; }

        [JsonProperty("decline_by_signature")]
        public bool AllowDeclineBySignature { get; set; }

        [JsonProperty("remind_after")]
        public int SendReminderInXDays { get; set; }

        [JsonProperty("remind_before")]
        public int SendReminderInXDaysBeforeExpiration { get; set; }

        [JsonProperty("remind_repeat")]
        public int SendReminderEveryXDays { get; set; }

        [JsonProperty("expiration_days")]
        public int DaysUntilExpiration { get; set; }

        [JsonProperty("authentication_type")]
        public invitesignerAdvancedPropertiesInputItemAuthenticationTypeType AuthenticationType { get; set; }

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
        public invitesignerAdvancedPropertiesInputItemRedirectTargetType RedirectTarget { get; set; }

        [JsonProperty("decline_redirect_uri")]
        public string DeclineRedirectUri { get; set; }

        [JsonProperty("close_redirect_uri")]
        public string CloseRedirectUri { get; set; }

        [JsonProperty("is_finish_redirect_canceled")]
        public bool IsFinishRedirectCanceled { get; set; }

        [JsonProperty("is_close_redirect_canceled")]
        public bool IsCloseRedirectCanceled { get; set; }

        [JsonProperty("is_decline_redirect_canceled")]
        public bool IsDeclineRedirectCanceled { get; set; }

        [JsonProperty("language")]
        public invitesignerAdvancedPropertiesInputItemLanguageType Language { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum invitesignerAdvancedPropertiesInputItemAuthenticationTypeType
    {
        Password,
        [EnumMember(Value = "Phone call")]
        PhoneCall,
        Sms
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum invitesignerAdvancedPropertiesInputItemRedirectTargetType
    {
        [EnumMember(Value = "In the new tab")]
        InTheNewTab,
        [EnumMember(Value = "In the same tab")]
        InTheSameTab
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum invitesignerAdvancedPropertiesInputItemLanguageType
    {
        En,
        Es,
        Fr
    }

    public class inviteviewersInputItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }
    }

    public class inviteviewerAdvancedPropertiesInputItem
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class inviteapproversInputItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }
    }

    public class inviteapproverAdvancedPropertiesInputItem
    {
        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("expiration_days")]
        public int ExpirationDays { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("authentication_type")]
        public inviteapproverAdvancedPropertiesInputItemAuthenticationTypeType AuthenticationType { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("authentication_sms_message")]
        public string AuthenticationSmsMessage { get; set; }

        [JsonProperty("redirect_uri")]
        public string RedirectUri { get; set; }

        [JsonProperty("redirect_target")]
        public inviteapproverAdvancedPropertiesInputItemRedirectTargetType RedirectTarget { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inviteapproverAdvancedPropertiesInputItemAuthenticationTypeType
    {
        Password,
        [EnumMember(Value = "Phone call")]
        PhoneCall,
        Sms
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inviteapproverAdvancedPropertiesInputItemRedirectTargetType
    {
        [EnumMember(Value = "In the new tab")]
        InTheNewTab,
        [EnumMember(Value = "In the same tab")]
        InTheSameTab
    }

    public class inviteemailGroupsInputItem
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("emails")]
        public inviteemailGroupsInputItemEmailsTypeItem[] Emails { get; set; }
    }

    public class inviteemailGroupsInputItemEmailsTypeItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class invitecCInputItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class invitecCStepsInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("step")]
        public int Step { get; set; }
    }

    public class InviteToSignDocGroupAllOptionsResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("pending_invite_link")]
        public string PendingInviteLink { get; set; }
    }

    public class inviteinviteStepsInputItem
    {
        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("email_group")]
        public string EmailGroup { get; set; }

        [JsonProperty("role_name")]
        public string RoleName { get; set; }

        [JsonProperty("action")]
        public inviteinviteStepsInputItemActionType Action { get; set; }

        [JsonProperty("document_id")]
        public string DocumentID { get; set; }
        public inviteinviteStepsInputItemAdvancedTypeItem[] Advanced { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inviteinviteStepsInputItemActionType
    {
        View,
        Sign,
        Approve
    }

    public class inviteinviteStepsInputItemAdvancedTypeItem
    {
        [JsonProperty("required_preset_signature_name")]
        public string RequiredPresetSignatureName { get; set; }

        [JsonProperty("allow_reassign")]
        public bool AllowForwarding { get; set; }

        [JsonProperty("decline_by_signature")]
        public bool AllowDeclineBySignature { get; set; }

        [JsonProperty("authentication")]
        public inviteinviteStepsInputItemAdvancedTypeItemAuthenticationType Authentication { get; set; }

        [JsonProperty("payment_request")]
        public inviteinviteStepsInputItemAdvancedTypeItemPaymentRequestType PaymentRequest { get; set; }

        [JsonProperty("redirect")]
        public inviteinviteStepsInputItemAdvancedTypeItemRedirectType Redirect { get; set; }

        [JsonProperty("language")]
        public inviteinviteStepsInputItemAdvancedTypeItemLanguageType Language { get; set; }
    }

    public class inviteinviteStepsInputItemAdvancedTypeItemAuthenticationType
    {
        [JsonProperty("type")]
        public inviteinviteStepsInputItemAdvancedTypeItemAuthenticationTypeAuthenticationTypeType AuthenticationType { get; set; }

        [JsonProperty("value")]
        public string Password { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inviteinviteStepsInputItemAdvancedTypeItemAuthenticationTypeAuthenticationTypeType
    {
        Password,
        [EnumMember(Value = "Phone call")]
        PhoneCall,
        Sms
    }

    public class inviteinviteStepsInputItemAdvancedTypeItemPaymentRequestType
    {
        [JsonProperty("merchant_id")]
        public string MerchantId { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }
    }

    public class inviteinviteStepsInputItemAdvancedTypeItemRedirectType
    {
        [JsonProperty("redirect_uri")]
        public string Uri { get; set; }

        [JsonProperty("redirect_target")]
        public inviteinviteStepsInputItemAdvancedTypeItemRedirectTypeRedirectTargetType RedirectTarget { get; set; }

        [JsonProperty("decline_redirect_uri")]
        public string DeclineRedirectUri { get; set; }

        [JsonProperty("close_redirect_uri")]
        public string CloseRedirectUri { get; set; }

        [JsonProperty("is_finish_redirect_canceled")]
        public bool IsFinishRedirectCanceled { get; set; }

        [JsonProperty("is_close_redirect_canceled")]
        public bool IsCloseRedirectCanceled { get; set; }

        [JsonProperty("is_decline_redirect_canceled")]
        public bool IsDeclineRedirectCanceled { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inviteinviteStepsInputItemAdvancedTypeItemRedirectTypeRedirectTargetType
    {
        [EnumMember(Value = "In the new tab")]
        InTheNewTab,
        [EnumMember(Value = "In the same tab")]
        InTheSameTab
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inviteinviteStepsInputItemAdvancedTypeItemLanguageType
    {
        En,
        Es,
        Fr
    }

    public class inviteinviteEmailsInputItem
    {
        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("email_group")]
        public string EmailGroup { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("expiration_days")]
        public int DaysUntilExpiration { get; set; }

        [JsonProperty("remind_after")]
        public int SendReminderInXDays { get; set; }

        [JsonProperty("remind_before")]
        public int SendReminderInXDaysBeforeExpiration { get; set; }

        [JsonProperty("remind_repeat")]
        public int SendReminderEveryXDays { get; set; }
    }

    public class inviteemailGroupsInputItem2
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("emails")]
        public inviteemailGroupsInputItemEmailsTypeItem[] Emails { get; set; }
    }

    public class invitecompletionEmailsInputItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("disable_document_attachment")]
        public bool DisableDocumentAttachment { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
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
