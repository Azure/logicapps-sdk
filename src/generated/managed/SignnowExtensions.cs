//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Signnow
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SignnowActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteDocGroupEmbeddedInvites))]
        public IWorkflowAction DeleteDocGroupEmbeddedInvites([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteDocGroupEmbeddedInvites(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/documentgroup/{0}/embedded-invites", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildCreateDocGroupEmbeddedInvites))]
        public IBodyWorkflowAction<CreateDocGroupEmbeddedInvitesResponse> CreateDocGroupEmbeddedInvites([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<inviteinvitesInputItem[]> inviteinvites = null, [WorkflowExpression] Func<inviteadvancedInputItem[]> inviteadvanced = null, [WorkflowExpression] Func<inviteqESSignatureInput> inviteqESSignature = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateDocGroupEmbeddedInvitesResponse> __BuildCreateDocGroupEmbeddedInvites(WorkflowExpression<string> id, WorkflowExpression<inviteinvitesInputItem[]> inviteinvites = null, WorkflowExpression<inviteadvancedInputItem[]> inviteadvanced = null, WorkflowExpression<inviteqESSignatureInput> inviteqESSignature = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(inviteinvites, nameof(inviteinvites), required: false);
            WorkflowExpression.Validate(inviteadvanced, nameof(inviteadvanced), required: false);
            WorkflowExpression.Validate(inviteqESSignature, nameof(inviteqESSignature), required: false);
            return new DeferredBodyAction<CreateDocGroupEmbeddedInvitesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/documentgroup/{0}/embedded-invites", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var invite = new JObject();
                var invitepropCount = 0;
                if (inviteinvites != null)
                {
                    invite["invites"] = ExpressionConverter.ConvertO(inviteinvites);
                    invitepropCount++;
                }

                if (inviteadvanced != null)
                {
                    invite["advanced"] = ExpressionConverter.ConvertO(inviteadvanced);
                    invitepropCount++;
                }

                if (inviteqESSignature != null)
                {
                    invite["signature"] = ExpressionConverter.ConvertO(inviteqESSignature);
                    invitepropCount++;
                }

                if (invitepropCount > 0)
                {
                    callPayload.Body = invite;
                }

                return new ApiConnectionAction<CreateDocGroupEmbeddedInvitesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildGenerateDocGroupEmbeddedInviteLink))]
        public IBodyWorkflowAction<GenerateDocGroupEmbeddedInviteLinkResponse> GenerateDocGroupEmbeddedInviteLink([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> inviteId, [WorkflowExpression] Func<string> inviteemail, [WorkflowExpression] Func<int> invitelinkExpiration = null, [WorkflowExpression] Func<int> invitesessionExpiration = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GenerateDocGroupEmbeddedInviteLinkResponse> __BuildGenerateDocGroupEmbeddedInviteLink(WorkflowExpression<string> id, WorkflowExpression<string> inviteId, WorkflowExpression<string> inviteemail, WorkflowExpression<int> invitelinkExpiration = null, WorkflowExpression<int> invitesessionExpiration = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(inviteId, nameof(inviteId), required: true);
            WorkflowExpression.Validate(inviteemail, nameof(inviteemail), required: true);
            WorkflowExpression.Validate(invitelinkExpiration, nameof(invitelinkExpiration), required: false);
            WorkflowExpression.Validate(invitesessionExpiration, nameof(invitesessionExpiration), required: false);
            return new DeferredBodyAction<GenerateDocGroupEmbeddedInviteLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/documentgroup/{0}/embedded-invites/{1}/link", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(inviteId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var invite = new JObject();
                var invitepropCount = 0;
                invitepropCount++;
                invite["email"] = ExpressionConverter.ConvertO(inviteemail);
                if (invitelinkExpiration != null)
                {
                    invite["link_expiration"] = ExpressionConverter.ConvertO(invitelinkExpiration);
                    invitepropCount++;
                }

                if (invitesessionExpiration != null)
                {
                    invite["session_expiration"] = ExpressionConverter.ConvertO(invitesessionExpiration);
                    invitepropCount++;
                }

                if (invitepropCount > 0)
                {
                    callPayload.Body = invite;
                }

                return new ApiConnectionAction<GenerateDocGroupEmbeddedInviteLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteEmbeddedInvites))]
        public IWorkflowAction DeleteEmbeddedInvites([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteEmbeddedInvites(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/documents/{0}/embedded-invites", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildCreateEmbeddedInvites))]
        public IBodyWorkflowAction<CreateEmbeddedInvitesResponse> CreateEmbeddedInvites([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<inviteinvitesInputItem2[]> inviteinvites = null, [WorkflowExpression] Func<string> invitenameFormula = null, [WorkflowExpression] Func<inviteinviteAdvancedParametersInputItem[]> inviteinviteAdvancedParameters = null, [WorkflowExpression] Func<inviteqESSignatureInput> inviteqESSignature = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateEmbeddedInvitesResponse> __BuildCreateEmbeddedInvites(WorkflowExpression<string> id, WorkflowExpression<inviteinvitesInputItem2[]> inviteinvites = null, WorkflowExpression<string> invitenameFormula = null, WorkflowExpression<inviteinviteAdvancedParametersInputItem[]> inviteinviteAdvancedParameters = null, WorkflowExpression<inviteqESSignatureInput> inviteqESSignature = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(inviteinvites, nameof(inviteinvites), required: false);
            WorkflowExpression.Validate(invitenameFormula, nameof(invitenameFormula), required: false);
            WorkflowExpression.Validate(inviteinviteAdvancedParameters, nameof(inviteinviteAdvancedParameters), required: false);
            WorkflowExpression.Validate(inviteqESSignature, nameof(inviteqESSignature), required: false);
            return new DeferredBodyAction<CreateEmbeddedInvitesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/documents/{0}/embedded-invites", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var invite = new JObject();
                var invitepropCount = 0;
                if (inviteinvites != null)
                {
                    invite["invites"] = ExpressionConverter.ConvertO(inviteinvites);
                    invitepropCount++;
                }

                if (invitenameFormula != null)
                {
                    invite["name_formula"] = ExpressionConverter.ConvertO(invitenameFormula);
                    invitepropCount++;
                }

                if (inviteinviteAdvancedParameters != null)
                {
                    invite["advanced_params"] = ExpressionConverter.ConvertO(inviteinviteAdvancedParameters);
                    invitepropCount++;
                }

                if (inviteqESSignature != null)
                {
                    invite["signature"] = ExpressionConverter.ConvertO(inviteqESSignature);
                    invitepropCount++;
                }

                if (invitepropCount > 0)
                {
                    callPayload.Body = invite;
                }

                return new ApiConnectionAction<CreateEmbeddedInvitesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildGenerateEmbeddedInviteLink))]
        public IBodyWorkflowAction<GenerateEmbeddedInviteLinkResponse> GenerateEmbeddedInviteLink([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> fieldInviteId, [WorkflowExpression] Func<int> invitelinkExpiration = null, [WorkflowExpression] Func<int> invitesessionExpiration = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GenerateEmbeddedInviteLinkResponse> __BuildGenerateEmbeddedInviteLink(WorkflowExpression<string> id, WorkflowExpression<string> fieldInviteId, WorkflowExpression<int> invitelinkExpiration = null, WorkflowExpression<int> invitesessionExpiration = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(fieldInviteId, nameof(fieldInviteId), required: true);
            WorkflowExpression.Validate(invitelinkExpiration, nameof(invitelinkExpiration), required: false);
            WorkflowExpression.Validate(invitesessionExpiration, nameof(invitesessionExpiration), required: false);
            return new DeferredBodyAction<GenerateEmbeddedInviteLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/documents/{0}/embedded-invites/{1}/link", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldInviteId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var invite = new JObject();
                var invitepropCount = 0;
                if (invitelinkExpiration != null)
                {
                    invite["link_expiration"] = ExpressionConverter.ConvertO(invitelinkExpiration);
                    invitepropCount++;
                }

                if (invitesessionExpiration != null)
                {
                    invite["session_expiration"] = ExpressionConverter.ConvertO(invitesessionExpiration);
                    invitepropCount++;
                }

                if (invitepropCount > 0)
                {
                    callPayload.Body = invite;
                }

                return new ApiConnectionAction<GenerateEmbeddedInviteLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildGetListDocGroups))]
        public IBodyWorkflowAction<DocumentGroupsResponse> GetListDocGroups([WorkflowExpression] Func<bool> template, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentGroupsResponse> __BuildGetListDocGroups(WorkflowExpression<bool> template, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null)
        {
            WorkflowExpression.Validate(template, nameof(template), required: true);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<DocumentGroupsResponse>(() =>
            {
                var apiCallPath = "/documentgroups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template"] = ExpressionConverter.Convert(template);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<DocumentGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildCreateDocGroupFromFiles))]
        public IBodyWorkflowAction<CreateDocumentGroupFromFilesResponse> CreateDocGroupFromFiles([WorkflowExpression] Func<string> bodydocumentGroupName, [WorkflowExpression] Func<bodydocumentsInputItem[]> bodydocuments = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateDocumentGroupFromFilesResponse> __BuildCreateDocGroupFromFiles(WorkflowExpression<string> bodydocumentGroupName, WorkflowExpression<bodydocumentsInputItem[]> bodydocuments = null)
        {
            WorkflowExpression.Validate(bodydocumentGroupName, nameof(bodydocumentGroupName), required: true);
            WorkflowExpression.Validate(bodydocuments, nameof(bodydocuments), required: false);
            return new DeferredBodyAction<CreateDocumentGroupFromFilesResponse>(() =>
            {
                var apiCallPath = "/documentgroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["group_name"] = ExpressionConverter.ConvertO(bodydocumentGroupName);
                if (bodydocuments != null)
                {
                    body["documents"] = ExpressionConverter.ConvertO(bodydocuments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateDocumentGroupFromFilesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocumentGroup))]
        public IBodyWorkflowAction<DocumentGroupProperties> GetDocumentGroup([WorkflowExpression] Func<string> docGroupId, [WorkflowExpression] Func<bool> template)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentGroupProperties> __BuildGetDocumentGroup(WorkflowExpression<string> docGroupId, WorkflowExpression<bool> template)
        {
            WorkflowExpression.Validate(docGroupId, nameof(docGroupId), required: true);
            WorkflowExpression.Validate(template, nameof(template), required: true);
            return new DeferredBodyAction<DocumentGroupProperties>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/documentgroups/{0}", ExpressionConverter.ConvertWithUrlEncoding(docGroupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template"] = ExpressionConverter.Convert(template);
                return new ApiConnectionAction<DocumentGroupProperties>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildCreateFromTemplateGroup))]
        public IBodyWorkflowAction<CreateFromTemplateGroupResponse> CreateFromTemplateGroup([WorkflowExpression] Func<string> docGroupId, [WorkflowExpression] Func<string> bodydocumentGroupName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateFromTemplateGroupResponse> __BuildCreateFromTemplateGroup(WorkflowExpression<string> docGroupId, WorkflowExpression<string> bodydocumentGroupName = null)
        {
            WorkflowExpression.Validate(docGroupId, nameof(docGroupId), required: true);
            WorkflowExpression.Validate(bodydocumentGroupName, nameof(bodydocumentGroupName), required: false);
            return new DeferredBodyAction<CreateFromTemplateGroupResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/documentgroups/{0}", ExpressionConverter.ConvertWithUrlEncoding(docGroupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydocumentGroupName != null)
                {
                    body["group_name"] = ExpressionConverter.ConvertO(bodydocumentGroupName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateFromTemplateGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateGroupFieldValues))]
        public IBodyWorkflowAction<UpdateGroupFieldValuesResponse> UpdateGroupFieldValues([WorkflowExpression] Func<string> templateGroupId, [WorkflowExpression] Func<string> docGroupId, [WorkflowExpression] Func<object> fields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateGroupFieldValuesResponse> __BuildUpdateGroupFieldValues(WorkflowExpression<string> templateGroupId, WorkflowExpression<string> docGroupId, WorkflowExpression<object> fields = null)
        {
            WorkflowExpression.Validate(templateGroupId, nameof(templateGroupId), required: true);
            WorkflowExpression.Validate(docGroupId, nameof(docGroupId), required: true);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            return new DeferredBodyAction<UpdateGroupFieldValuesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/documentgroup/{0}/fields", ExpressionConverter.ConvertWithUrlEncoding(docGroupId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_group_id"] = ExpressionConverter.Convert(templateGroupId);
                callPayload.Body = ExpressionConverter.ConvertO(fields);
                return new ApiConnectionAction<UpdateGroupFieldValuesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateGroupSmartFieldValues))]
        public IBodyWorkflowAction<UpdateGroupSmartFieldValuesResponse> UpdateGroupSmartFieldValues([WorkflowExpression] Func<string> templateGroupId, [WorkflowExpression] Func<string> docGroupId, [WorkflowExpression] Func<object> fields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateGroupSmartFieldValuesResponse> __BuildUpdateGroupSmartFieldValues(WorkflowExpression<string> templateGroupId, WorkflowExpression<string> docGroupId, WorkflowExpression<object> fields = null)
        {
            WorkflowExpression.Validate(templateGroupId, nameof(templateGroupId), required: true);
            WorkflowExpression.Validate(docGroupId, nameof(docGroupId), required: true);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            return new DeferredBodyAction<UpdateGroupSmartFieldValuesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/documentgroup/{0}/smartfields", ExpressionConverter.ConvertWithUrlEncoding(docGroupId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_group_id"] = ExpressionConverter.Convert(templateGroupId);
                callPayload.Body = ExpressionConverter.ConvertO(fields);
                return new ApiConnectionAction<UpdateGroupSmartFieldValuesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildGetListDoc))]
        public IBodyWorkflowAction<DocumentProperties[]> GetListDoc([WorkflowExpression] Func<bool> template = null, [WorkflowExpression] Func<bool> includeDefaultTemplate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentProperties[]> __BuildGetListDoc(WorkflowExpression<bool> template = null, WorkflowExpression<bool> includeDefaultTemplate = null)
        {
            WorkflowExpression.Validate(template, nameof(template), required: false);
            WorkflowExpression.Validate(includeDefaultTemplate, nameof(includeDefaultTemplate), required: false);
            return new DeferredBodyAction<DocumentProperties[]>(() =>
            {
                var apiCallPath = "/document";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (template != null)
                    callPayload.Queries["template"] = ExpressionConverter.Convert(template);
                if (includeDefaultTemplate != null)
                    callPayload.Queries["includeDefaultTemplate"] = ExpressionConverter.Convert(includeDefaultTemplate);
                callPayload.Queries["excludeDocumentRelations"] = Convert.ToString(false);
                return new ApiConnectionAction<DocumentProperties[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildUploadDocument))]
        public IBodyWorkflowAction<UploadDocumentResponse> UploadDocument([WorkflowExpression] Func<object> file)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadDocumentResponse> __BuildUploadDocument(WorkflowExpression<object> file)
        {
            WorkflowExpression.Validate(file, nameof(file), required: true);
            return new DeferredBodyAction<UploadDocumentResponse>(() =>
            {
                var apiCallPath = "/document";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UploadDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildGetDoc))]
        public IBodyWorkflowAction<DocumentProperties> GetDoc([WorkflowExpression] Func<bool> template, [WorkflowExpression] Func<string> docId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentProperties> __BuildGetDoc(WorkflowExpression<bool> template, WorkflowExpression<string> docId)
        {
            WorkflowExpression.Validate(template, nameof(template), required: true);
            WorkflowExpression.Validate(docId, nameof(docId), required: true);
            return new DeferredBodyAction<DocumentProperties>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/document/{0}", ExpressionConverter.ConvertWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template"] = ExpressionConverter.Convert(template);
                return new ApiConnectionAction<DocumentProperties>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteDoc))]
        public IBodyWorkflowAction<DeleteDocResponse> DeleteDoc([WorkflowExpression] Func<string> docId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteDocResponse> __BuildDeleteDoc(WorkflowExpression<string> docId)
        {
            WorkflowExpression.Validate(docId, nameof(docId), required: true);
            return new DeferredBodyAction<DeleteDocResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/document/{0}", ExpressionConverter.ConvertWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteDocResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildCreateFromTemplate))]
        public IBodyWorkflowAction<CreateFromTemplateResponse> CreateFromTemplate([WorkflowExpression] Func<string> docId, [WorkflowExpression] Func<string> bodydocumentName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateFromTemplateResponse> __BuildCreateFromTemplate(WorkflowExpression<string> docId, WorkflowExpression<string> bodydocumentName = null)
        {
            WorkflowExpression.Validate(docId, nameof(docId), required: true);
            WorkflowExpression.Validate(bodydocumentName, nameof(bodydocumentName), required: false);
            return new DeferredBodyAction<CreateFromTemplateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/document/{0}", ExpressionConverter.ConvertWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydocumentName != null)
                {
                    body["document_name"] = ExpressionConverter.ConvertO(bodydocumentName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateFromTemplateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildCreateSigningLink))]
        public IBodyWorkflowAction<CreateSigningLinkResponse> CreateSigningLink([WorkflowExpression] Func<string> docId, [WorkflowExpression] Func<object> fields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateSigningLinkResponse> __BuildCreateSigningLink(WorkflowExpression<string> docId, WorkflowExpression<object> fields = null)
        {
            WorkflowExpression.Validate(docId, nameof(docId), required: true);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            return new DeferredBodyAction<CreateSigningLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/document/{0}/link", ExpressionConverter.ConvertWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(fields);
                return new ApiConnectionAction<CreateSigningLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildSendInvite))]
        public IBodyWorkflowAction<JToken> SendInvite([WorkflowExpression] Func<bool> template, [WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildSendInvite(WorkflowExpression<bool> template, WorkflowExpression<string> templateId, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(template, nameof(template), required: true);
            WorkflowExpression.Validate(templateId, nameof(templateId), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/document/{0}/invite", ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template"] = ExpressionConverter.Convert(template);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildSendGroupInvite))]
        public IBodyWorkflowAction<JToken> SendGroupInvite([WorkflowExpression] Func<bool> template, [WorkflowExpression] Func<string> templateGroupId, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildSendGroupInvite(WorkflowExpression<bool> template, WorkflowExpression<string> templateGroupId, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(template, nameof(template), required: true);
            WorkflowExpression.Validate(templateGroupId, nameof(templateGroupId), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/documentgroup/{0}/invite", ExpressionConverter.ConvertWithUrlEncoding(templateGroupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template"] = ExpressionConverter.Convert(template);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildSendUserDefinedInvite))]
        public IBodyWorkflowAction<JToken> SendUserDefinedInvite([WorkflowExpression] Func<string> docId, [WorkflowExpression] Func<bodyroleInputItem[]> bodyrole = null, [WorkflowExpression] Func<string> bodycC = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string> bodyemailAllPartiesOnCompletion = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildSendUserDefinedInvite(WorkflowExpression<string> docId, WorkflowExpression<bodyroleInputItem[]> bodyrole = null, WorkflowExpression<string> bodycC = null, WorkflowExpression<string> bodysubject = null, WorkflowExpression<string> bodymessage = null, WorkflowExpression<string> bodyemailAllPartiesOnCompletion = null)
        {
            WorkflowExpression.Validate(docId, nameof(docId), required: true);
            WorkflowExpression.Validate(bodyrole, nameof(bodyrole), required: false);
            WorkflowExpression.Validate(bodycC, nameof(bodycC), required: false);
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            WorkflowExpression.Validate(bodyemailAllPartiesOnCompletion, nameof(bodyemailAllPartiesOnCompletion), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/document/{0}/invite-user-defined-schema", ExpressionConverter.ConvertWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyrole != null)
                {
                    body["Role"] = ExpressionConverter.ConvertO(bodyrole);
                    bodypropCount++;
                }

                if (bodycC != null)
                {
                    body["cc"] = ExpressionConverter.ConvertO(bodycC);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                    bodypropCount++;
                }

                if (bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(bodymessage);
                    bodypropCount++;
                }

                if (bodyemailAllPartiesOnCompletion != null)
                {
                    body["on_complete"] = ExpressionConverter.ConvertO(bodyemailAllPartiesOnCompletion);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildCancelInvite))]
        public IBodyWorkflowAction<JToken> CancelInvite([WorkflowExpression] Func<string> docId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCancelInvite(WorkflowExpression<string> docId)
        {
            WorkflowExpression.Validate(docId, nameof(docId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/document/{0}/invite-cancel", ExpressionConverter.ConvertWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildDownloadDocument))]
        public IBodyWorkflowAction<string> DownloadDocument([WorkflowExpression] Func<string> docId, [WorkflowExpression] Func<string> mode = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildDownloadDocument(WorkflowExpression<string> docId, WorkflowExpression<string> mode = null)
        {
            WorkflowExpression.Validate(docId, nameof(docId), required: true);
            WorkflowExpression.Validate(mode, nameof(mode), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/document/{0}/download", ExpressionConverter.ConvertWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mode"] = Convert.ToString("Collapsed");
                if (mode != null)
                    callPayload.Queries["mode"] = ExpressionConverter.Convert(mode);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildPrefillSmartFields))]
        public IWorkflowAction PrefillSmartFields([WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> docId, [WorkflowExpression] Func<object> fields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPrefillSmartFields(WorkflowExpression<string> templateId, WorkflowExpression<string> docId, WorkflowExpression<object> fields = null)
        {
            WorkflowExpression.Validate(templateId, nameof(templateId), required: true);
            WorkflowExpression.Validate(docId, nameof(docId), required: true);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/document/{0}/smartfields", ExpressionConverter.ConvertWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_id"] = ExpressionConverter.Convert(templateId);
                callPayload.Body = ExpressionConverter.ConvertO(fields);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildGetInviteStatus))]
        public IBodyWorkflowAction<GetInviteStatusResponse> GetInviteStatus([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetInviteStatusResponse> __BuildGetInviteStatus(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GetInviteStatusResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/document/{0}/invite-status", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetInviteStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocumentGroupInviteStatus))]
        public IBodyWorkflowAction<GetDocumentGroupInviteStatusResponse> GetDocumentGroupInviteStatus([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDocumentGroupInviteStatusResponse> __BuildGetDocumentGroupInviteStatus(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GetDocumentGroupInviteStatusResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/documentgroups/{0}/invite-status", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentGroupInviteStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildReplaceRecipientsInDocumentInvite))]
        public IBodyWorkflowAction<ReplaceRecipientsInDocumentInviteResponse> ReplaceRecipientsInDocumentInvite([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<replaceToreplaceToInputItem[]> replaceToreplaceTo = null, [WorkflowExpression] Func<replaceToadvancedParametersInputItem[]> replaceToadvancedParameters = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReplaceRecipientsInDocumentInviteResponse> __BuildReplaceRecipientsInDocumentInvite(WorkflowExpression<string> id, WorkflowExpression<replaceToreplaceToInputItem[]> replaceToreplaceTo = null, WorkflowExpression<replaceToadvancedParametersInputItem[]> replaceToadvancedParameters = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(replaceToreplaceTo, nameof(replaceToreplaceTo), required: false);
            WorkflowExpression.Validate(replaceToadvancedParameters, nameof(replaceToadvancedParameters), required: false);
            return new DeferredBodyAction<ReplaceRecipientsInDocumentInviteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/document/{0}/replace-recipients", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var replaceTo = new JObject();
                var replaceTopropCount = 0;
                if (replaceToreplaceTo != null)
                {
                    replaceTo["replace_to"] = ExpressionConverter.ConvertO(replaceToreplaceTo);
                    replaceTopropCount++;
                }

                if (replaceToadvancedParameters != null)
                {
                    replaceTo["advanced"] = ExpressionConverter.ConvertO(replaceToadvancedParameters);
                    replaceTopropCount++;
                }

                if (replaceTopropCount > 0)
                {
                    callPayload.Body = replaceTo;
                }

                return new ApiConnectionAction<ReplaceRecipientsInDocumentInviteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildReplaceRecipientsInDocumentGroupInvite))]
        public IBodyWorkflowAction<ReplaceRecipientsInDocumentGroupInviteResponse> ReplaceRecipientsInDocumentGroupInvite([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> inviteId, [WorkflowExpression] Func<string> replaceTostepID = null, [WorkflowExpression] Func<string> replaceTorecipientToReplace = null, [WorkflowExpression] Func<string> replaceTonewRecipient = null, [WorkflowExpression] Func<int> replaceToexpirationDays = null, [WorkflowExpression] Func<int> replaceToreminder = null, [WorkflowExpression] Func<replaceToinviteActionAttributesInputItem[]> replaceToinviteActionAttributes = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReplaceRecipientsInDocumentGroupInviteResponse> __BuildReplaceRecipientsInDocumentGroupInvite(WorkflowExpression<string> id, WorkflowExpression<string> inviteId, WorkflowExpression<string> replaceTostepID = null, WorkflowExpression<string> replaceTorecipientToReplace = null, WorkflowExpression<string> replaceTonewRecipient = null, WorkflowExpression<int> replaceToexpirationDays = null, WorkflowExpression<int> replaceToreminder = null, WorkflowExpression<replaceToinviteActionAttributesInputItem[]> replaceToinviteActionAttributes = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(inviteId, nameof(inviteId), required: true);
            WorkflowExpression.Validate(replaceTostepID, nameof(replaceTostepID), required: false);
            WorkflowExpression.Validate(replaceTorecipientToReplace, nameof(replaceTorecipientToReplace), required: false);
            WorkflowExpression.Validate(replaceTonewRecipient, nameof(replaceTonewRecipient), required: false);
            WorkflowExpression.Validate(replaceToexpirationDays, nameof(replaceToexpirationDays), required: false);
            WorkflowExpression.Validate(replaceToreminder, nameof(replaceToreminder), required: false);
            WorkflowExpression.Validate(replaceToinviteActionAttributes, nameof(replaceToinviteActionAttributes), required: false);
            return new DeferredBodyAction<ReplaceRecipientsInDocumentGroupInviteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/documentgroup/{0}/invite/{1}/replace-recipients", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(inviteId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var replaceTo = new JObject();
                var replaceTopropCount = 0;
                if (replaceTostepID != null)
                {
                    replaceTo["step_id"] = ExpressionConverter.ConvertO(replaceTostepID);
                    replaceTopropCount++;
                }

                if (replaceTorecipientToReplace != null)
                {
                    replaceTo["recipient_to_update"] = ExpressionConverter.ConvertO(replaceTorecipientToReplace);
                    replaceTopropCount++;
                }

                if (replaceTonewRecipient != null)
                {
                    replaceTo["new_recipient"] = ExpressionConverter.ConvertO(replaceTonewRecipient);
                    replaceTopropCount++;
                }

                if (replaceToexpirationDays != null)
                {
                    if (replaceToexpirationDays != null)
                    {
                        replaceTo["expiration_days"] = ExpressionConverter.ConvertO(replaceToexpirationDays);
                        replaceTopropCount++;
                    }

                    replaceTopropCount++;
                }
                else
                {
                    replaceTo["expiration_days"] = 30;
                    replaceTopropCount++;
                }

                if (replaceToreminder != null)
                {
                    replaceTo["reminder"] = ExpressionConverter.ConvertO(replaceToreminder);
                    replaceTopropCount++;
                }

                if (replaceToinviteActionAttributes != null)
                {
                    replaceTo["invite_action_attributes"] = ExpressionConverter.ConvertO(replaceToinviteActionAttributes);
                    replaceTopropCount++;
                }

                if (replaceTopropCount > 0)
                {
                    callPayload.Body = replaceTo;
                }

                return new ApiConnectionAction<ReplaceRecipientsInDocumentGroupInviteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildCreateEmbeddedInviteSettingsLink))]
        public IBodyWorkflowAction<CreateEmbeddedInviteSettingsLinkResponse> CreateEmbeddedInviteSettingsLink([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<inviteSettingstypeInput> inviteSettingstype = null, [WorkflowExpression] Func<string> inviteSettingsredirectUri = null, [WorkflowExpression] Func<int> inviteSettingslinkExpiration = null, [WorkflowExpression] Func<inviteSettingsredirectTargetInput> inviteSettingsredirectTarget = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateEmbeddedInviteSettingsLinkResponse> __BuildCreateEmbeddedInviteSettingsLink(WorkflowExpression<string> id, WorkflowExpression<inviteSettingstypeInput> inviteSettingstype = null, WorkflowExpression<string> inviteSettingsredirectUri = null, WorkflowExpression<int> inviteSettingslinkExpiration = null, WorkflowExpression<inviteSettingsredirectTargetInput> inviteSettingsredirectTarget = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(inviteSettingstype, nameof(inviteSettingstype), required: false);
            WorkflowExpression.Validate(inviteSettingsredirectUri, nameof(inviteSettingsredirectUri), required: false);
            WorkflowExpression.Validate(inviteSettingslinkExpiration, nameof(inviteSettingslinkExpiration), required: false);
            WorkflowExpression.Validate(inviteSettingsredirectTarget, nameof(inviteSettingsredirectTarget), required: false);
            return new DeferredBodyAction<CreateEmbeddedInviteSettingsLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/documents/{0}/embedded-sending", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inviteSettings = new JObject();
                var inviteSettingspropCount = 0;
                if (inviteSettingstype != null)
                {
                    inviteSettings["type"] = ExpressionConverter.ConvertO(inviteSettingstype);
                    inviteSettingspropCount++;
                }

                if (inviteSettingsredirectUri != null)
                {
                    inviteSettings["redirect_uri"] = ExpressionConverter.ConvertO(inviteSettingsredirectUri);
                    inviteSettingspropCount++;
                }

                if (inviteSettingslinkExpiration != null)
                {
                    if (inviteSettingslinkExpiration != null)
                    {
                        inviteSettings["link_expiration"] = ExpressionConverter.ConvertO(inviteSettingslinkExpiration);
                        inviteSettingspropCount++;
                    }

                    inviteSettingspropCount++;
                }
                else
                {
                    inviteSettings["link_expiration"] = 15;
                    inviteSettingspropCount++;
                }

                if (inviteSettingsredirectTarget != null)
                {
                    inviteSettings["redirect_target"] = ExpressionConverter.ConvertO(inviteSettingsredirectTarget);
                    inviteSettingspropCount++;
                }

                if (inviteSettingspropCount > 0)
                {
                    callPayload.Body = inviteSettings;
                }

                return new ApiConnectionAction<CreateEmbeddedInviteSettingsLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildCreateDocGroupEmbeddedInviteSettingsLink))]
        public IBodyWorkflowAction<CreateDocGroupEmbeddedInviteSettingsLinkResponse> CreateDocGroupEmbeddedInviteSettingsLink([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<inviteSettingstypeInput> inviteSettingstype = null, [WorkflowExpression] Func<string> inviteSettingsredirectUri = null, [WorkflowExpression] Func<int> inviteSettingslinkExpiration = null, [WorkflowExpression] Func<inviteSettingsredirectTargetInput> inviteSettingsredirectTarget = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateDocGroupEmbeddedInviteSettingsLinkResponse> __BuildCreateDocGroupEmbeddedInviteSettingsLink(WorkflowExpression<string> id, WorkflowExpression<inviteSettingstypeInput> inviteSettingstype = null, WorkflowExpression<string> inviteSettingsredirectUri = null, WorkflowExpression<int> inviteSettingslinkExpiration = null, WorkflowExpression<inviteSettingsredirectTargetInput> inviteSettingsredirectTarget = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(inviteSettingstype, nameof(inviteSettingstype), required: false);
            WorkflowExpression.Validate(inviteSettingsredirectUri, nameof(inviteSettingsredirectUri), required: false);
            WorkflowExpression.Validate(inviteSettingslinkExpiration, nameof(inviteSettingslinkExpiration), required: false);
            WorkflowExpression.Validate(inviteSettingsredirectTarget, nameof(inviteSettingsredirectTarget), required: false);
            return new DeferredBodyAction<CreateDocGroupEmbeddedInviteSettingsLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/documentgroup/{0}/embedded-sending", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inviteSettings = new JObject();
                var inviteSettingspropCount = 0;
                if (inviteSettingstype != null)
                {
                    if (inviteSettingstype != null)
                    {
                        inviteSettings["type"] = ExpressionConverter.ConvertO(inviteSettingstype);
                        inviteSettingspropCount++;
                    }

                    inviteSettingspropCount++;
                }
                else
                {
                    inviteSettings["type"] = "Manage";
                    inviteSettingspropCount++;
                }

                if (inviteSettingsredirectUri != null)
                {
                    inviteSettings["redirect_uri"] = ExpressionConverter.ConvertO(inviteSettingsredirectUri);
                    inviteSettingspropCount++;
                }

                if (inviteSettingslinkExpiration != null)
                {
                    if (inviteSettingslinkExpiration != null)
                    {
                        inviteSettings["link_expiration"] = ExpressionConverter.ConvertO(inviteSettingslinkExpiration);
                        inviteSettingspropCount++;
                    }

                    inviteSettingspropCount++;
                }
                else
                {
                    inviteSettings["link_expiration"] = 15;
                    inviteSettingspropCount++;
                }

                if (inviteSettingsredirectTarget != null)
                {
                    inviteSettings["redirect_target"] = ExpressionConverter.ConvertO(inviteSettingsredirectTarget);
                    inviteSettingspropCount++;
                }

                if (inviteSettingspropCount > 0)
                {
                    callPayload.Body = inviteSettings;
                }

                return new ApiConnectionAction<CreateDocGroupEmbeddedInviteSettingsLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildInviteToSignAllOptions))]
        public IBodyWorkflowAction<InviteToSignAllOptionsResponse> InviteToSignAllOptions([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<invitesignersInputItem[]> invitesigners = null, [WorkflowExpression] Func<invitesignerAdvancedPropertiesInputItem[]> invitesignerAdvancedProperties = null, [WorkflowExpression] Func<inviteviewersInputItem[]> inviteviewers = null, [WorkflowExpression] Func<inviteviewerAdvancedPropertiesInputItem[]> inviteviewerAdvancedProperties = null, [WorkflowExpression] Func<inviteapproversInputItem[]> inviteapprovers = null, [WorkflowExpression] Func<inviteapproverAdvancedPropertiesInputItem[]> inviteapproverAdvancedProperties = null, [WorkflowExpression] Func<string> invitefrom = null, [WorkflowExpression] Func<inviteemailGroupsInputItem[]> inviteemailGroups = null, [WorkflowExpression] Func<invitecCInputItem[]> invitecC = null, [WorkflowExpression] Func<invitecCStepsInputItem[]> invitecCSteps = null, [WorkflowExpression] Func<string> invitesubject = null, [WorkflowExpression] Func<string> invitemessage = null, [WorkflowExpression] Func<string> invitecCSubject = null, [WorkflowExpression] Func<string> invitecCMessage = null, [WorkflowExpression] Func<inviteqESSignatureInput> inviteqESSignature = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InviteToSignAllOptionsResponse> __BuildInviteToSignAllOptions(WorkflowExpression<string> id, WorkflowExpression<invitesignersInputItem[]> invitesigners = null, WorkflowExpression<invitesignerAdvancedPropertiesInputItem[]> invitesignerAdvancedProperties = null, WorkflowExpression<inviteviewersInputItem[]> inviteviewers = null, WorkflowExpression<inviteviewerAdvancedPropertiesInputItem[]> inviteviewerAdvancedProperties = null, WorkflowExpression<inviteapproversInputItem[]> inviteapprovers = null, WorkflowExpression<inviteapproverAdvancedPropertiesInputItem[]> inviteapproverAdvancedProperties = null, WorkflowExpression<string> invitefrom = null, WorkflowExpression<inviteemailGroupsInputItem[]> inviteemailGroups = null, WorkflowExpression<invitecCInputItem[]> invitecC = null, WorkflowExpression<invitecCStepsInputItem[]> invitecCSteps = null, WorkflowExpression<string> invitesubject = null, WorkflowExpression<string> invitemessage = null, WorkflowExpression<string> invitecCSubject = null, WorkflowExpression<string> invitecCMessage = null, WorkflowExpression<inviteqESSignatureInput> inviteqESSignature = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(invitesigners, nameof(invitesigners), required: false);
            WorkflowExpression.Validate(invitesignerAdvancedProperties, nameof(invitesignerAdvancedProperties), required: false);
            WorkflowExpression.Validate(inviteviewers, nameof(inviteviewers), required: false);
            WorkflowExpression.Validate(inviteviewerAdvancedProperties, nameof(inviteviewerAdvancedProperties), required: false);
            WorkflowExpression.Validate(inviteapprovers, nameof(inviteapprovers), required: false);
            WorkflowExpression.Validate(inviteapproverAdvancedProperties, nameof(inviteapproverAdvancedProperties), required: false);
            WorkflowExpression.Validate(invitefrom, nameof(invitefrom), required: false);
            WorkflowExpression.Validate(inviteemailGroups, nameof(inviteemailGroups), required: false);
            WorkflowExpression.Validate(invitecC, nameof(invitecC), required: false);
            WorkflowExpression.Validate(invitecCSteps, nameof(invitecCSteps), required: false);
            WorkflowExpression.Validate(invitesubject, nameof(invitesubject), required: false);
            WorkflowExpression.Validate(invitemessage, nameof(invitemessage), required: false);
            WorkflowExpression.Validate(invitecCSubject, nameof(invitecCSubject), required: false);
            WorkflowExpression.Validate(invitecCMessage, nameof(invitecCMessage), required: false);
            WorkflowExpression.Validate(inviteqESSignature, nameof(inviteqESSignature), required: false);
            return new DeferredBodyAction<InviteToSignAllOptionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/document/{0}/invite-all-options", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var invite = new JObject();
                var invitepropCount = 0;
                if (invitesigners != null)
                {
                    invite["signers"] = ExpressionConverter.ConvertO(invitesigners);
                    invitepropCount++;
                }

                if (invitesignerAdvancedProperties != null)
                {
                    invite["signers_advanced"] = ExpressionConverter.ConvertO(invitesignerAdvancedProperties);
                    invitepropCount++;
                }

                if (inviteviewers != null)
                {
                    invite["viewers"] = ExpressionConverter.ConvertO(inviteviewers);
                    invitepropCount++;
                }

                if (inviteviewerAdvancedProperties != null)
                {
                    invite["viewers_advanced"] = ExpressionConverter.ConvertO(inviteviewerAdvancedProperties);
                    invitepropCount++;
                }

                if (inviteapprovers != null)
                {
                    invite["approvers"] = ExpressionConverter.ConvertO(inviteapprovers);
                    invitepropCount++;
                }

                if (inviteapproverAdvancedProperties != null)
                {
                    invite["approver_advanced"] = ExpressionConverter.ConvertO(inviteapproverAdvancedProperties);
                    invitepropCount++;
                }

                if (invitefrom != null)
                {
                    invite["from"] = ExpressionConverter.ConvertO(invitefrom);
                    invitepropCount++;
                }

                if (inviteemailGroups != null)
                {
                    invite["email_groups"] = ExpressionConverter.ConvertO(inviteemailGroups);
                    invitepropCount++;
                }

                if (invitecC != null)
                {
                    invite["cc"] = ExpressionConverter.ConvertO(invitecC);
                    invitepropCount++;
                }

                if (invitecCSteps != null)
                {
                    invite["cc_step"] = ExpressionConverter.ConvertO(invitecCSteps);
                    invitepropCount++;
                }

                if (invitesubject != null)
                {
                    invite["subject"] = ExpressionConverter.ConvertO(invitesubject);
                    invitepropCount++;
                }

                if (invitemessage != null)
                {
                    invite["message"] = ExpressionConverter.ConvertO(invitemessage);
                    invitepropCount++;
                }

                if (invitecCSubject != null)
                {
                    invite["cc_subject"] = ExpressionConverter.ConvertO(invitecCSubject);
                    invitepropCount++;
                }

                if (invitecCMessage != null)
                {
                    invite["cc_message"] = ExpressionConverter.ConvertO(invitecCMessage);
                    invitepropCount++;
                }

                if (inviteqESSignature != null)
                {
                    invite["signature"] = ExpressionConverter.ConvertO(inviteqESSignature);
                    invitepropCount++;
                }

                if (invitepropCount > 0)
                {
                    callPayload.Body = invite;
                }

                return new ApiConnectionAction<InviteToSignAllOptionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildInviteToSignDocGroupAllOptions))]
        public IBodyWorkflowAction<InviteToSignDocGroupAllOptionsResponse> InviteToSignDocGroupAllOptions([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<inviteinviteStepsInputItem[]> inviteinviteSteps = null, [WorkflowExpression] Func<inviteinviteEmailsInputItem[]> inviteinviteEmails = null, [WorkflowExpression] Func<inviteemailGroupsInputItem2[]> inviteemailGroups = null, [WorkflowExpression] Func<invitecompletionEmailsInputItem[]> invitecompletionEmails = null, [WorkflowExpression] Func<bool> invitesignAsMerged = null, [WorkflowExpression] Func<int> inviteclientTimestamp = null, [WorkflowExpression] Func<invitecCInputItem[]> invitecC = null, [WorkflowExpression] Func<inviteqESSignatureInput> inviteqESSignature = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InviteToSignDocGroupAllOptionsResponse> __BuildInviteToSignDocGroupAllOptions(WorkflowExpression<string> id, WorkflowExpression<inviteinviteStepsInputItem[]> inviteinviteSteps = null, WorkflowExpression<inviteinviteEmailsInputItem[]> inviteinviteEmails = null, WorkflowExpression<inviteemailGroupsInputItem2[]> inviteemailGroups = null, WorkflowExpression<invitecompletionEmailsInputItem[]> invitecompletionEmails = null, WorkflowExpression<bool> invitesignAsMerged = null, WorkflowExpression<int> inviteclientTimestamp = null, WorkflowExpression<invitecCInputItem[]> invitecC = null, WorkflowExpression<inviteqESSignatureInput> inviteqESSignature = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(inviteinviteSteps, nameof(inviteinviteSteps), required: false);
            WorkflowExpression.Validate(inviteinviteEmails, nameof(inviteinviteEmails), required: false);
            WorkflowExpression.Validate(inviteemailGroups, nameof(inviteemailGroups), required: false);
            WorkflowExpression.Validate(invitecompletionEmails, nameof(invitecompletionEmails), required: false);
            WorkflowExpression.Validate(invitesignAsMerged, nameof(invitesignAsMerged), required: false);
            WorkflowExpression.Validate(inviteclientTimestamp, nameof(inviteclientTimestamp), required: false);
            WorkflowExpression.Validate(invitecC, nameof(invitecC), required: false);
            WorkflowExpression.Validate(inviteqESSignature, nameof(inviteqESSignature), required: false);
            return new DeferredBodyAction<InviteToSignDocGroupAllOptionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/documentgroup/{0}/invite-all-options", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var invite = new JObject();
                var invitepropCount = 0;
                if (inviteinviteSteps != null)
                {
                    invite["invite_steps"] = ExpressionConverter.ConvertO(inviteinviteSteps);
                    invitepropCount++;
                }

                if (inviteinviteEmails != null)
                {
                    invite["Email"] = ExpressionConverter.ConvertO(inviteinviteEmails);
                    invitepropCount++;
                }

                if (inviteemailGroups != null)
                {
                    invite["email_groups"] = ExpressionConverter.ConvertO(inviteemailGroups);
                    invitepropCount++;
                }

                if (invitecompletionEmails != null)
                {
                    invite["completion_emails"] = ExpressionConverter.ConvertO(invitecompletionEmails);
                    invitepropCount++;
                }

                if (invitesignAsMerged != null)
                {
                    invite["sign_as_merged"] = ExpressionConverter.ConvertO(invitesignAsMerged);
                    invitepropCount++;
                }

                if (inviteclientTimestamp != null)
                {
                    invite["client_timestamp"] = ExpressionConverter.ConvertO(inviteclientTimestamp);
                    invitepropCount++;
                }

                if (invitecC != null)
                {
                    invite["cc"] = ExpressionConverter.ConvertO(invitecC);
                    invitepropCount++;
                }

                if (inviteqESSignature != null)
                {
                    invite["signature"] = ExpressionConverter.ConvertO(inviteqESSignature);
                    invitepropCount++;
                }

                if (invitepropCount > 0)
                {
                    callPayload.Body = invite;
                }

                return new ApiConnectionAction<InviteToSignDocGroupAllOptionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocFields))]
        public IBodyWorkflowAction<JToken> GetDocFields([WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> docId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetDocFields(WorkflowExpression<string> templateId, WorkflowExpression<string> docId)
        {
            WorkflowExpression.Validate(templateId, nameof(templateId), required: true);
            WorkflowExpression.Validate(docId, nameof(docId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/document/{0}/fields", ExpressionConverter.ConvertWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_id"] = ExpressionConverter.Convert(templateId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateFieldValues))]
        public IBodyWorkflowAction<UpdateFieldValuesV2Response> UpdateFieldValues([WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> docId, [WorkflowExpression] Func<object> fields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateFieldValuesV2Response> __BuildUpdateFieldValues(WorkflowExpression<string> templateId, WorkflowExpression<string> docId, WorkflowExpression<object> fields = null)
        {
            WorkflowExpression.Validate(templateId, nameof(templateId), required: true);
            WorkflowExpression.Validate(docId, nameof(docId), required: true);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            return new DeferredBodyAction<UpdateFieldValuesV2Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/document/{0}/fields", ExpressionConverter.ConvertWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_id"] = ExpressionConverter.Convert(templateId);
                callPayload.Body = ExpressionConverter.ConvertO(fields);
                return new ApiConnectionAction<UpdateFieldValuesV2Response>(callPayload);
            });
        }
    }

    public class SignnowTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildTriggers))]
        public IBodyWorkflowTrigger<TriggersV2Response> Triggers([WorkflowExpression] Func<string> bodyevent,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<TriggersV2Response> __BuildTriggers(WorkflowExpression<string> bodyevent,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyevent, nameof(bodyevent), required: true);
            return new DeferredBodyTrigger<TriggersV2Response>(() =>
            {
                var apiCallPath = "/multievent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event"] = ExpressionConverter.ConvertO(bodyevent);
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
            });
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