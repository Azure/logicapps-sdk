//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Signnow
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SignnowActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IWorkflowAction DeleteDocGroupEmbeddedInvites(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/documentgroup/{0}/embedded-invites", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateDocGroupEmbeddedInvitesResponse> CreateDocGroupEmbeddedInvites(Expression<Func<string>> id, Expression<Func<inviteinvitesInputItem[]>> inviteinvites = null, Expression<Func<inviteadvancedInputItem[]>> inviteadvanced = null, Expression<Func<inviteqESSignatureInput>> inviteqESSignature = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/documentgroup/{0}/embedded-invites", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var invite = new JObject();
            var invitepropCount = 0;
            if (inviteinvites != null)
            {
                invite["invites"] = CSharpExpressionConverter.ConvertToken(inviteinvites);
                invitepropCount++;
            }

            if (inviteadvanced != null)
            {
                invite["advanced"] = CSharpExpressionConverter.ConvertToken(inviteadvanced);
                invitepropCount++;
            }

            if (inviteqESSignature != null)
            {
                invite["signature"] = CSharpExpressionConverter.Convert(inviteqESSignature);
                invitepropCount++;
            }

            if (invitepropCount > 0)
            {
                callPayload.Body = invite;
            }

            return new ApiConnectionAction<CreateDocGroupEmbeddedInvitesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<GenerateDocGroupEmbeddedInviteLinkResponse> GenerateDocGroupEmbeddedInviteLink(Expression<Func<string>> id, Expression<Func<string>> inviteId, Expression<Func<string>> inviteemail, Expression<Func<int>> invitelinkExpiration = null, Expression<Func<int>> invitesessionExpiration = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/documentgroup/{0}/embedded-invites/{1}/link", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(inviteId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var invite = new JObject();
            var invitepropCount = 0;
            invitepropCount++;
            invite["email"] = CSharpExpressionConverter.ConvertToken(inviteemail);
            if (invitelinkExpiration != null)
            {
                invite["link_expiration"] = CSharpExpressionConverter.ConvertToken(invitelinkExpiration);
                invitepropCount++;
            }

            if (invitesessionExpiration != null)
            {
                invite["session_expiration"] = CSharpExpressionConverter.ConvertToken(invitesessionExpiration);
                invitepropCount++;
            }

            if (invitepropCount > 0)
            {
                callPayload.Body = invite;
            }

            return new ApiConnectionAction<GenerateDocGroupEmbeddedInviteLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IWorkflowAction DeleteEmbeddedInvites(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/documents/{0}/embedded-invites", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateEmbeddedInvitesResponse> CreateEmbeddedInvites(Expression<Func<string>> id, Expression<Func<inviteinvitesInputItem2[]>> inviteinvites = null, Expression<Func<string>> invitenameFormula = null, Expression<Func<inviteinviteAdvancedParametersInputItem[]>> inviteinviteAdvancedParameters = null, Expression<Func<inviteqESSignatureInput>> inviteqESSignature = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/documents/{0}/embedded-invites", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var invite = new JObject();
            var invitepropCount = 0;
            if (inviteinvites != null)
            {
                invite["invites"] = CSharpExpressionConverter.ConvertToken(inviteinvites);
                invitepropCount++;
            }

            if (invitenameFormula != null)
            {
                invite["name_formula"] = CSharpExpressionConverter.ConvertToken(invitenameFormula);
                invitepropCount++;
            }

            if (inviteinviteAdvancedParameters != null)
            {
                invite["advanced_params"] = CSharpExpressionConverter.ConvertToken(inviteinviteAdvancedParameters);
                invitepropCount++;
            }

            if (inviteqESSignature != null)
            {
                invite["signature"] = CSharpExpressionConverter.Convert(inviteqESSignature);
                invitepropCount++;
            }

            if (invitepropCount > 0)
            {
                callPayload.Body = invite;
            }

            return new ApiConnectionAction<CreateEmbeddedInvitesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<GenerateEmbeddedInviteLinkResponse> GenerateEmbeddedInviteLink(Expression<Func<string>> id, Expression<Func<string>> fieldInviteId, Expression<Func<int>> invitelinkExpiration = null, Expression<Func<int>> invitesessionExpiration = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/documents/{0}/embedded-invites/{1}/link", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldInviteId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var invite = new JObject();
            var invitepropCount = 0;
            if (invitelinkExpiration != null)
            {
                invite["link_expiration"] = CSharpExpressionConverter.ConvertToken(invitelinkExpiration);
                invitepropCount++;
            }

            if (invitesessionExpiration != null)
            {
                invite["session_expiration"] = CSharpExpressionConverter.ConvertToken(invitesessionExpiration);
                invitepropCount++;
            }

            if (invitepropCount > 0)
            {
                callPayload.Body = invite;
            }

            return new ApiConnectionAction<GenerateEmbeddedInviteLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<DocumentGroupsResponse> GetListDocGroups(Expression<Func<bool>> template, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/documentgroups";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["template"] = CSharpExpressionConverter.ConvertO(template);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            return new ApiConnectionAction<DocumentGroupsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateDocumentGroupFromFilesResponse> CreateDocGroupFromFiles(Expression<Func<string>> bodydocumentGroupName, Expression<Func<bodydocumentsInputItem[]>> bodydocuments = null)
        {
            var apiCallPath = "/documentgroups";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["group_name"] = CSharpExpressionConverter.ConvertToken(bodydocumentGroupName);
            if (bodydocuments != null)
            {
                body["documents"] = CSharpExpressionConverter.ConvertToken(bodydocuments);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateDocumentGroupFromFilesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<DocumentGroupProperties> GetDocumentGroup(Expression<Func<string>> docGroupId, Expression<Func<bool>> template)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/documentgroups/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(docGroupId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["template"] = CSharpExpressionConverter.ConvertO(template);
            return new ApiConnectionAction<DocumentGroupProperties>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateFromTemplateGroupResponse> CreateFromTemplateGroup(Expression<Func<string>> docGroupId, Expression<Func<string>> bodydocumentGroupName = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/documentgroups/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(docGroupId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydocumentGroupName != null)
            {
                body["group_name"] = CSharpExpressionConverter.ConvertToken(bodydocumentGroupName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateFromTemplateGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<UpdateGroupFieldValuesResponse> UpdateGroupFieldValues(Expression<Func<string>> templateGroupId, Expression<Func<string>> docGroupId, Expression<Func<object>> fields = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/documentgroup/{0}/fields", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(docGroupId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["template_group_id"] = CSharpExpressionConverter.ConvertO(templateGroupId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(fields);
            return new ApiConnectionAction<UpdateGroupFieldValuesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<UpdateGroupSmartFieldValuesResponse> UpdateGroupSmartFieldValues(Expression<Func<string>> templateGroupId, Expression<Func<string>> docGroupId, Expression<Func<object>> fields = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/documentgroup/{0}/smartfields", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(docGroupId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["template_group_id"] = CSharpExpressionConverter.ConvertO(templateGroupId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(fields);
            return new ApiConnectionAction<UpdateGroupSmartFieldValuesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<DocumentProperties[]> GetListDoc(Expression<Func<bool>> template = null, Expression<Func<bool>> includeDefaultTemplate = null)
        {
            var apiCallPath = "/document";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (template != null)
                callPayload.Queries["template"] = CSharpExpressionConverter.ConvertO(template);
            if (includeDefaultTemplate != null)
                callPayload.Queries["includeDefaultTemplate"] = CSharpExpressionConverter.ConvertO(includeDefaultTemplate);
            callPayload.Queries["excludeDocumentRelations"] = Convert.ToString(false);
            return new ApiConnectionAction<DocumentProperties[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<UploadDocumentResponse> UploadDocument(Expression<Func<object>> file)
        {
            var apiCallPath = "/document";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UploadDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<DocumentProperties> GetDoc(Expression<Func<bool>> template, Expression<Func<string>> docId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/document/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(docId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["template"] = CSharpExpressionConverter.ConvertO(template);
            return new ApiConnectionAction<DocumentProperties>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<DeleteDocResponse> DeleteDoc(Expression<Func<string>> docId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/document/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(docId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DeleteDocResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateFromTemplateResponse> CreateFromTemplate(Expression<Func<string>> docId, Expression<Func<string>> bodydocumentName = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/document/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(docId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydocumentName != null)
            {
                body["document_name"] = CSharpExpressionConverter.ConvertToken(bodydocumentName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateFromTemplateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateSigningLinkResponse> CreateSigningLink(Expression<Func<string>> docId, Expression<Func<object>> fields = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/document/{0}/link", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(docId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(fields);
            return new ApiConnectionAction<CreateSigningLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<JToken> SendInvite(Expression<Func<bool>> template, Expression<Func<string>> templateId, Expression<Func<object>> body = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/document/{0}/invite", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["template"] = CSharpExpressionConverter.ConvertO(template);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<JToken> SendGroupInvite(Expression<Func<bool>> template, Expression<Func<string>> templateGroupId, Expression<Func<object>> body = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/documentgroup/{0}/invite", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateGroupId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["template"] = CSharpExpressionConverter.ConvertO(template);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<JToken> SendUserDefinedInvite(Expression<Func<string>> docId, Expression<Func<bodyroleInputItem[]>> bodyrole = null, Expression<Func<string>> bodycC = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodymessage = null, Expression<Func<string>> bodyemailAllPartiesOnCompletion = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/document/{0}/invite-user-defined-schema", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(docId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyrole != null)
            {
                body["Role"] = CSharpExpressionConverter.ConvertToken(bodyrole);
                bodypropCount++;
            }

            if (bodycC != null)
            {
                body["cc"] = CSharpExpressionConverter.ConvertToken(bodycC);
                bodypropCount++;
            }

            if (bodysubject != null)
            {
                body["subject"] = CSharpExpressionConverter.ConvertToken(bodysubject);
                bodypropCount++;
            }

            if (bodymessage != null)
            {
                body["message"] = CSharpExpressionConverter.ConvertToken(bodymessage);
                bodypropCount++;
            }

            if (bodyemailAllPartiesOnCompletion != null)
            {
                body["on_complete"] = CSharpExpressionConverter.ConvertToken(bodyemailAllPartiesOnCompletion);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<JToken> CancelInvite(Expression<Func<string>> docId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/document/{0}/invite-cancel", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(docId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<string> DownloadDocument(Expression<Func<string>> docId, Expression<Func<string>> mode = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/document/{0}/download", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(docId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["mode"] = Convert.ToString("Collapsed");
            if (mode != null)
                callPayload.Queries["mode"] = CSharpExpressionConverter.ConvertO(mode);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IWorkflowAction PrefillSmartFields(Expression<Func<string>> templateId, Expression<Func<string>> docId, Expression<Func<object>> fields = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/document/{0}/smartfields", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(docId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["template_id"] = CSharpExpressionConverter.ConvertO(templateId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(fields);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<GetInviteStatusResponse> GetInviteStatus(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/document/{0}/invite-status", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetInviteStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<GetDocumentGroupInviteStatusResponse> GetDocumentGroupInviteStatus(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/documentgroups/{0}/invite-status", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetDocumentGroupInviteStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<ReplaceRecipientsInDocumentInviteResponse> ReplaceRecipientsInDocumentInvite(Expression<Func<string>> id, Expression<Func<replaceToreplaceToInputItem[]>> replaceToreplaceTo = null, Expression<Func<replaceToadvancedParametersInputItem[]>> replaceToadvancedParameters = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/document/{0}/replace-recipients", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var replaceTo = new JObject();
            var replaceTopropCount = 0;
            if (replaceToreplaceTo != null)
            {
                replaceTo["replace_to"] = CSharpExpressionConverter.ConvertToken(replaceToreplaceTo);
                replaceTopropCount++;
            }

            if (replaceToadvancedParameters != null)
            {
                replaceTo["advanced"] = CSharpExpressionConverter.ConvertToken(replaceToadvancedParameters);
                replaceTopropCount++;
            }

            if (replaceTopropCount > 0)
            {
                callPayload.Body = replaceTo;
            }

            return new ApiConnectionAction<ReplaceRecipientsInDocumentInviteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<ReplaceRecipientsInDocumentGroupInviteResponse> ReplaceRecipientsInDocumentGroupInvite(Expression<Func<string>> id, Expression<Func<string>> inviteId, Expression<Func<string>> replaceTostepID = null, Expression<Func<string>> replaceTorecipientToReplace = null, Expression<Func<string>> replaceTonewRecipient = null, Expression<Func<int>> replaceToexpirationDays = null, Expression<Func<int>> replaceToreminder = null, Expression<Func<replaceToinviteActionAttributesInputItem[]>> replaceToinviteActionAttributes = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/documentgroup/{0}/invite/{1}/replace-recipients", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(inviteId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var replaceTo = new JObject();
            var replaceTopropCount = 0;
            if (replaceTostepID != null)
            {
                replaceTo["step_id"] = CSharpExpressionConverter.ConvertToken(replaceTostepID);
                replaceTopropCount++;
            }

            if (replaceTorecipientToReplace != null)
            {
                replaceTo["recipient_to_update"] = CSharpExpressionConverter.ConvertToken(replaceTorecipientToReplace);
                replaceTopropCount++;
            }

            if (replaceTonewRecipient != null)
            {
                replaceTo["new_recipient"] = CSharpExpressionConverter.ConvertToken(replaceTonewRecipient);
                replaceTopropCount++;
            }

            if (replaceToexpirationDays != null)
            {
                if (replaceToexpirationDays != null)
                {
                    replaceTo["expiration_days"] = CSharpExpressionConverter.ConvertToken(replaceToexpirationDays);
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
                replaceTo["reminder"] = CSharpExpressionConverter.ConvertToken(replaceToreminder);
                replaceTopropCount++;
            }

            if (replaceToinviteActionAttributes != null)
            {
                replaceTo["invite_action_attributes"] = CSharpExpressionConverter.ConvertToken(replaceToinviteActionAttributes);
                replaceTopropCount++;
            }

            if (replaceTopropCount > 0)
            {
                callPayload.Body = replaceTo;
            }

            return new ApiConnectionAction<ReplaceRecipientsInDocumentGroupInviteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateEmbeddedInviteSettingsLinkResponse> CreateEmbeddedInviteSettingsLink(Expression<Func<string>> id, Expression<Func<inviteSettingstypeInput>> inviteSettingstype = null, Expression<Func<string>> inviteSettingsredirectUri = null, Expression<Func<int>> inviteSettingslinkExpiration = null, Expression<Func<inviteSettingsredirectTargetInput>> inviteSettingsredirectTarget = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/documents/{0}/embedded-sending", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inviteSettings = new JObject();
            var inviteSettingspropCount = 0;
            if (inviteSettingstype != null)
            {
                inviteSettings["type"] = CSharpExpressionConverter.Convert(inviteSettingstype);
                inviteSettingspropCount++;
            }

            if (inviteSettingsredirectUri != null)
            {
                inviteSettings["redirect_uri"] = CSharpExpressionConverter.ConvertToken(inviteSettingsredirectUri);
                inviteSettingspropCount++;
            }

            if (inviteSettingslinkExpiration != null)
            {
                if (inviteSettingslinkExpiration != null)
                {
                    inviteSettings["link_expiration"] = CSharpExpressionConverter.ConvertToken(inviteSettingslinkExpiration);
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
                inviteSettings["redirect_target"] = CSharpExpressionConverter.Convert(inviteSettingsredirectTarget);
                inviteSettingspropCount++;
            }

            if (inviteSettingspropCount > 0)
            {
                callPayload.Body = inviteSettings;
            }

            return new ApiConnectionAction<CreateEmbeddedInviteSettingsLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateDocGroupEmbeddedInviteSettingsLinkResponse> CreateDocGroupEmbeddedInviteSettingsLink(Expression<Func<string>> id, Expression<Func<inviteSettingstypeInput>> inviteSettingstype = null, Expression<Func<string>> inviteSettingsredirectUri = null, Expression<Func<int>> inviteSettingslinkExpiration = null, Expression<Func<inviteSettingsredirectTargetInput>> inviteSettingsredirectTarget = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/documentgroup/{0}/embedded-sending", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inviteSettings = new JObject();
            var inviteSettingspropCount = 0;
            if (inviteSettingstype != null)
            {
                if (inviteSettingstype != null)
                {
                    inviteSettings["type"] = CSharpExpressionConverter.Convert(inviteSettingstype);
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
                inviteSettings["redirect_uri"] = CSharpExpressionConverter.ConvertToken(inviteSettingsredirectUri);
                inviteSettingspropCount++;
            }

            if (inviteSettingslinkExpiration != null)
            {
                if (inviteSettingslinkExpiration != null)
                {
                    inviteSettings["link_expiration"] = CSharpExpressionConverter.ConvertToken(inviteSettingslinkExpiration);
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
                inviteSettings["redirect_target"] = CSharpExpressionConverter.Convert(inviteSettingsredirectTarget);
                inviteSettingspropCount++;
            }

            if (inviteSettingspropCount > 0)
            {
                callPayload.Body = inviteSettings;
            }

            return new ApiConnectionAction<CreateDocGroupEmbeddedInviteSettingsLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<InviteToSignAllOptionsResponse> InviteToSignAllOptions(Expression<Func<string>> id, Expression<Func<invitesignersInputItem[]>> invitesigners = null, Expression<Func<invitesignerAdvancedPropertiesInputItem[]>> invitesignerAdvancedProperties = null, Expression<Func<inviteviewersInputItem[]>> inviteviewers = null, Expression<Func<inviteviewerAdvancedPropertiesInputItem[]>> inviteviewerAdvancedProperties = null, Expression<Func<inviteapproversInputItem[]>> inviteapprovers = null, Expression<Func<inviteapproverAdvancedPropertiesInputItem[]>> inviteapproverAdvancedProperties = null, Expression<Func<string>> invitefrom = null, Expression<Func<inviteemailGroupsInputItem[]>> inviteemailGroups = null, Expression<Func<invitecCInputItem[]>> invitecC = null, Expression<Func<invitecCStepsInputItem[]>> invitecCSteps = null, Expression<Func<string>> invitesubject = null, Expression<Func<string>> invitemessage = null, Expression<Func<string>> invitecCSubject = null, Expression<Func<string>> invitecCMessage = null, Expression<Func<inviteqESSignatureInput>> inviteqESSignature = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/document/{0}/invite-all-options", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var invite = new JObject();
            var invitepropCount = 0;
            if (invitesigners != null)
            {
                invite["signers"] = CSharpExpressionConverter.ConvertToken(invitesigners);
                invitepropCount++;
            }

            if (invitesignerAdvancedProperties != null)
            {
                invite["signers_advanced"] = CSharpExpressionConverter.ConvertToken(invitesignerAdvancedProperties);
                invitepropCount++;
            }

            if (inviteviewers != null)
            {
                invite["viewers"] = CSharpExpressionConverter.ConvertToken(inviteviewers);
                invitepropCount++;
            }

            if (inviteviewerAdvancedProperties != null)
            {
                invite["viewers_advanced"] = CSharpExpressionConverter.ConvertToken(inviteviewerAdvancedProperties);
                invitepropCount++;
            }

            if (inviteapprovers != null)
            {
                invite["approvers"] = CSharpExpressionConverter.ConvertToken(inviteapprovers);
                invitepropCount++;
            }

            if (inviteapproverAdvancedProperties != null)
            {
                invite["approver_advanced"] = CSharpExpressionConverter.ConvertToken(inviteapproverAdvancedProperties);
                invitepropCount++;
            }

            if (invitefrom != null)
            {
                invite["from"] = CSharpExpressionConverter.ConvertToken(invitefrom);
                invitepropCount++;
            }

            if (inviteemailGroups != null)
            {
                invite["email_groups"] = CSharpExpressionConverter.ConvertToken(inviteemailGroups);
                invitepropCount++;
            }

            if (invitecC != null)
            {
                invite["cc"] = CSharpExpressionConverter.ConvertToken(invitecC);
                invitepropCount++;
            }

            if (invitecCSteps != null)
            {
                invite["cc_step"] = CSharpExpressionConverter.ConvertToken(invitecCSteps);
                invitepropCount++;
            }

            if (invitesubject != null)
            {
                invite["subject"] = CSharpExpressionConverter.ConvertToken(invitesubject);
                invitepropCount++;
            }

            if (invitemessage != null)
            {
                invite["message"] = CSharpExpressionConverter.ConvertToken(invitemessage);
                invitepropCount++;
            }

            if (invitecCSubject != null)
            {
                invite["cc_subject"] = CSharpExpressionConverter.ConvertToken(invitecCSubject);
                invitepropCount++;
            }

            if (invitecCMessage != null)
            {
                invite["cc_message"] = CSharpExpressionConverter.ConvertToken(invitecCMessage);
                invitepropCount++;
            }

            if (inviteqESSignature != null)
            {
                invite["signature"] = CSharpExpressionConverter.Convert(inviteqESSignature);
                invitepropCount++;
            }

            if (invitepropCount > 0)
            {
                callPayload.Body = invite;
            }

            return new ApiConnectionAction<InviteToSignAllOptionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<InviteToSignDocGroupAllOptionsResponse> InviteToSignDocGroupAllOptions(Expression<Func<string>> id, Expression<Func<inviteinviteStepsInputItem[]>> inviteinviteSteps = null, Expression<Func<inviteinviteEmailsInputItem[]>> inviteinviteEmails = null, Expression<Func<inviteemailGroupsInputItem2[]>> inviteemailGroups = null, Expression<Func<invitecompletionEmailsInputItem[]>> invitecompletionEmails = null, Expression<Func<bool>> invitesignAsMerged = null, Expression<Func<int>> inviteclientTimestamp = null, Expression<Func<invitecCInputItem[]>> invitecC = null, Expression<Func<inviteqESSignatureInput>> inviteqESSignature = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/documentgroup/{0}/invite-all-options", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var invite = new JObject();
            var invitepropCount = 0;
            if (inviteinviteSteps != null)
            {
                invite["invite_steps"] = CSharpExpressionConverter.ConvertToken(inviteinviteSteps);
                invitepropCount++;
            }

            if (inviteinviteEmails != null)
            {
                invite["Email"] = CSharpExpressionConverter.ConvertToken(inviteinviteEmails);
                invitepropCount++;
            }

            if (inviteemailGroups != null)
            {
                invite["email_groups"] = CSharpExpressionConverter.ConvertToken(inviteemailGroups);
                invitepropCount++;
            }

            if (invitecompletionEmails != null)
            {
                invite["completion_emails"] = CSharpExpressionConverter.ConvertToken(invitecompletionEmails);
                invitepropCount++;
            }

            if (invitesignAsMerged != null)
            {
                invite["sign_as_merged"] = CSharpExpressionConverter.ConvertToken(invitesignAsMerged);
                invitepropCount++;
            }

            if (inviteclientTimestamp != null)
            {
                invite["client_timestamp"] = CSharpExpressionConverter.ConvertToken(inviteclientTimestamp);
                invitepropCount++;
            }

            if (invitecC != null)
            {
                invite["cc"] = CSharpExpressionConverter.ConvertToken(invitecC);
                invitepropCount++;
            }

            if (inviteqESSignature != null)
            {
                invite["signature"] = CSharpExpressionConverter.Convert(inviteqESSignature);
                invitepropCount++;
            }

            if (invitepropCount > 0)
            {
                callPayload.Body = invite;
            }

            return new ApiConnectionAction<InviteToSignDocGroupAllOptionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<JToken> GetDocFields(Expression<Func<string>> templateId, Expression<Func<string>> docId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/document/{0}/fields", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(docId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["template_id"] = CSharpExpressionConverter.ConvertO(templateId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<UpdateFieldValuesV2Response> UpdateFieldValues(Expression<Func<string>> templateId, Expression<Func<string>> docId, Expression<Func<object>> fields = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/document/{0}/fields", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(docId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["template_id"] = CSharpExpressionConverter.ConvertO(templateId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(fields);
            return new ApiConnectionAction<UpdateFieldValuesV2Response>(callPayload);
        }
    }

    public class SignnowTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TriggersV2Response> Triggers(Expression<Func<string>> bodyevent, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/multievent";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["event"] = CSharpExpressionConverter.ConvertToken(bodyevent);
            body["entity_id"] = "00000000-0000-0000-0000-000000000000";
            bodypropCount++;
            body["action"] = "callback";
            bodypropCount++;
            var attributesObject = new JObject();
            var attributesObjectpropCount = 0;
            attributesObject["callback"] = "@listCallbackUrl()";
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

            return new ApiConnectionTrigger<TriggersV2Response>(callPayload, triggerName, recurrence);
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

    public enum inviteadvancedInputItemLanguageType
    {
        En,
        Es,
        Fr
    }

    public enum inviteadvancedInputItemRedirectTargetType
    {
        [EnumMember(Value = "In the new tab")]
        InTheNewTab,
        [EnumMember(Value = "In the same tab")]
        InTheSameTab
    }

    public enum inviteadvancedInputItemDeliveryTypeType
    {
        Email,
        Link
    }

    public enum inviteadvancedInputItemAuthenticationTypeType
    {
        Password,
        [EnumMember(Value = "Phone call")]
        PhoneCall,
        Sms
    }

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

    public enum inviteinviteAdvancedParametersInputItemLanguageType
    {
        En,
        Es,
        Fr
    }

    public enum inviteinviteAdvancedParametersInputItemRedirectTargetType
    {
        [EnumMember(Value = "In the new tab")]
        InTheNewTab,
        [EnumMember(Value = "In the same tab")]
        InTheSameTab
    }

    public enum inviteinviteAdvancedParametersInputItemAuthenticationTypeType
    {
        Password,
        [EnumMember(Value = "Phone call")]
        PhoneCall,
        Sms
    }

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

    public enum inviteSettingstypeInput
    {
        Manage,
        Edit,
        [EnumMember(Value = "Send-invite")]
        SendInvite
    }

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

    public enum invitesignerAdvancedPropertiesInputItemAuthenticationTypeType
    {
        Password,
        [EnumMember(Value = "Phone call")]
        PhoneCall,
        Sms
    }

    public enum invitesignerAdvancedPropertiesInputItemRedirectTargetType
    {
        [EnumMember(Value = "In the new tab")]
        InTheNewTab,
        [EnumMember(Value = "In the same tab")]
        InTheSameTab
    }

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

    public enum inviteapproverAdvancedPropertiesInputItemAuthenticationTypeType
    {
        Password,
        [EnumMember(Value = "Phone call")]
        PhoneCall,
        Sms
    }

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

    public enum inviteinviteStepsInputItemAdvancedTypeItemRedirectTypeRedirectTargetType
    {
        [EnumMember(Value = "In the new tab")]
        InTheNewTab,
        [EnumMember(Value = "In the same tab")]
        InTheSameTab
    }

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