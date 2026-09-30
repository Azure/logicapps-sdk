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
        public IWorkflowAction DeleteDocGroupEmbeddedInvites([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/documentgroup/{0}/embedded-invites", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateDocGroupEmbeddedInvitesResponse> CreateDocGroupEmbeddedInvites([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<inviteinvitesInputItem[]> inviteinvites = null, [WorkflowExpression] Func<inviteadvancedInputItem[]> inviteadvanced = null, [WorkflowExpression] Func<inviteqESSignatureInput> inviteqESSignature = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(inviteinvites, nameof(inviteinvites), required: false);
            SourceExpression.Validate(inviteadvanced, nameof(inviteadvanced), required: false);
            SourceExpression.Validate(inviteqESSignature, nameof(inviteqESSignature), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/documentgroup/{0}/embedded-invites", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var invite = new JObject();
                var invitepropCount = 0;
                if (inviteinvites != null)
                {
                    invite["invites"] = SourceExpressionConverter.ConvertToken(inviteinvites);
                    invitepropCount++;
                }

                if (inviteadvanced != null)
                {
                    invite["advanced"] = SourceExpressionConverter.ConvertToken(inviteadvanced);
                    invitepropCount++;
                }

                if (inviteqESSignature != null)
                {
                    invite["signature"] = SourceExpressionConverter.Convert(inviteqESSignature);
                    invitepropCount++;
                }

                if (invitepropCount > 0)
                {
                    callPayload.Body = invite;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateDocGroupEmbeddedInvitesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<GenerateDocGroupEmbeddedInviteLinkResponse> GenerateDocGroupEmbeddedInviteLink([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> inviteId, [WorkflowExpression] Func<string> inviteemail, [WorkflowExpression] Func<int> invitelinkExpiration = null, [WorkflowExpression] Func<int> invitesessionExpiration = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(inviteId, nameof(inviteId), required: true);
            SourceExpression.Validate(inviteemail, nameof(inviteemail), required: true);
            SourceExpression.Validate(invitelinkExpiration, nameof(invitelinkExpiration), required: false);
            SourceExpression.Validate(invitesessionExpiration, nameof(invitesessionExpiration), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/documentgroup/{0}/embedded-invites/{1}/link", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(inviteId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var invite = new JObject();
                var invitepropCount = 0;
                invitepropCount++;
                invite["email"] = SourceExpressionConverter.ConvertToken(inviteemail);
                if (invitelinkExpiration != null)
                {
                    invite["link_expiration"] = SourceExpressionConverter.ConvertToken(invitelinkExpiration);
                    invitepropCount++;
                }

                if (invitesessionExpiration != null)
                {
                    invite["session_expiration"] = SourceExpressionConverter.ConvertToken(invitesessionExpiration);
                    invitepropCount++;
                }

                if (invitepropCount > 0)
                {
                    callPayload.Body = invite;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GenerateDocGroupEmbeddedInviteLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IWorkflowAction DeleteEmbeddedInvites([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/documents/{0}/embedded-invites", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateEmbeddedInvitesResponse> CreateEmbeddedInvites([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<inviteinvitesInputItem22[]> inviteinvites = null, [WorkflowExpression] Func<string> invitenameFormula = null, [WorkflowExpression] Func<inviteinviteAdvancedParametersInputItem[]> inviteinviteAdvancedParameters = null, [WorkflowExpression] Func<inviteqESSignatureInput> inviteqESSignature = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(inviteinvites, nameof(inviteinvites), required: false);
            SourceExpression.Validate(invitenameFormula, nameof(invitenameFormula), required: false);
            SourceExpression.Validate(inviteinviteAdvancedParameters, nameof(inviteinviteAdvancedParameters), required: false);
            SourceExpression.Validate(inviteqESSignature, nameof(inviteqESSignature), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/documents/{0}/embedded-invites", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var invite = new JObject();
                var invitepropCount = 0;
                if (inviteinvites != null)
                {
                    invite["invites"] = SourceExpressionConverter.ConvertToken(inviteinvites);
                    invitepropCount++;
                }

                if (invitenameFormula != null)
                {
                    invite["name_formula"] = SourceExpressionConverter.ConvertToken(invitenameFormula);
                    invitepropCount++;
                }

                if (inviteinviteAdvancedParameters != null)
                {
                    invite["advanced_params"] = SourceExpressionConverter.ConvertToken(inviteinviteAdvancedParameters);
                    invitepropCount++;
                }

                if (inviteqESSignature != null)
                {
                    invite["signature"] = SourceExpressionConverter.Convert(inviteqESSignature);
                    invitepropCount++;
                }

                if (invitepropCount > 0)
                {
                    callPayload.Body = invite;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateEmbeddedInvitesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<GenerateEmbeddedInviteLinkResponse> GenerateEmbeddedInviteLink([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> fieldInviteId, [WorkflowExpression] Func<int> invitelinkExpiration = null, [WorkflowExpression] Func<int> invitesessionExpiration = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(fieldInviteId, nameof(fieldInviteId), required: true);
            SourceExpression.Validate(invitelinkExpiration, nameof(invitelinkExpiration), required: false);
            SourceExpression.Validate(invitesessionExpiration, nameof(invitesessionExpiration), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/documents/{0}/embedded-invites/{1}/link", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldInviteId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var invite = new JObject();
                var invitepropCount = 0;
                if (invitelinkExpiration != null)
                {
                    invite["link_expiration"] = SourceExpressionConverter.ConvertToken(invitelinkExpiration);
                    invitepropCount++;
                }

                if (invitesessionExpiration != null)
                {
                    invite["session_expiration"] = SourceExpressionConverter.ConvertToken(invitesessionExpiration);
                    invitepropCount++;
                }

                if (invitepropCount > 0)
                {
                    callPayload.Body = invite;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GenerateEmbeddedInviteLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<DocumentGroupsResponse> GetListDocGroups([WorkflowExpression] Func<bool> template, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(template, nameof(template), required: true);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/documentgroups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template"] = SourceExpressionConverter.ConvertO(template);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<DocumentGroupsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateDocumentGroupFromFilesResponse> CreateDocGroupFromFiles([WorkflowExpression] Func<string> bodydocumentGroupName, [WorkflowExpression] Func<bodydocumentsInputItem[]> bodydocuments = null)
        {
            SourceExpression.Validate(bodydocumentGroupName, nameof(bodydocumentGroupName), required: true);
            SourceExpression.Validate(bodydocuments, nameof(bodydocuments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/documentgroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["group_name"] = SourceExpressionConverter.ConvertToken(bodydocumentGroupName);
                if (bodydocuments != null)
                {
                    body["documents"] = SourceExpressionConverter.ConvertToken(bodydocuments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateDocumentGroupFromFilesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<DocumentGroupProperties> GetDocumentGroup([WorkflowExpression] Func<string> docGroupId, [WorkflowExpression] Func<bool> template)
        {
            SourceExpression.Validate(docGroupId, nameof(docGroupId), required: true);
            SourceExpression.Validate(template, nameof(template), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/documentgroups/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(docGroupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template"] = SourceExpressionConverter.ConvertO(template);
                return callPayload;
            }

            return new ApiConnectionAction<DocumentGroupProperties>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateFromTemplateGroupResponse> CreateFromTemplateGroup([WorkflowExpression] Func<string> docGroupId, [WorkflowExpression] Func<string> bodydocumentGroupName = null)
        {
            SourceExpression.Validate(docGroupId, nameof(docGroupId), required: true);
            SourceExpression.Validate(bodydocumentGroupName, nameof(bodydocumentGroupName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/documentgroups/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(docGroupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydocumentGroupName != null)
                {
                    body["group_name"] = SourceExpressionConverter.ConvertToken(bodydocumentGroupName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateFromTemplateGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<UpdateGroupFieldValuesResponse> UpdateGroupFieldValues([WorkflowExpression] Func<string> templateGroupId, [WorkflowExpression] Func<string> docGroupId, [WorkflowExpression] Func<object> fields = null)
        {
            SourceExpression.Validate(templateGroupId, nameof(templateGroupId), required: true);
            SourceExpression.Validate(docGroupId, nameof(docGroupId), required: true);
            SourceExpression.Validate(fields, nameof(fields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/documentgroup/{0}/fields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(docGroupId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_group_id"] = SourceExpressionConverter.ConvertO(templateGroupId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(fields);
                return callPayload;
            }

            return new ApiConnectionAction<UpdateGroupFieldValuesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<UpdateGroupSmartFieldValuesResponse> UpdateGroupSmartFieldValues([WorkflowExpression] Func<string> templateGroupId, [WorkflowExpression] Func<string> docGroupId, [WorkflowExpression] Func<object> fields = null)
        {
            SourceExpression.Validate(templateGroupId, nameof(templateGroupId), required: true);
            SourceExpression.Validate(docGroupId, nameof(docGroupId), required: true);
            SourceExpression.Validate(fields, nameof(fields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/documentgroup/{0}/smartfields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(docGroupId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_group_id"] = SourceExpressionConverter.ConvertO(templateGroupId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(fields);
                return callPayload;
            }

            return new ApiConnectionAction<UpdateGroupSmartFieldValuesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<DocumentProperties[]> GetListDoc([WorkflowExpression] Func<bool> template = null, [WorkflowExpression] Func<bool> includeDefaultTemplate = null)
        {
            SourceExpression.Validate(template, nameof(template), required: false);
            SourceExpression.Validate(includeDefaultTemplate, nameof(includeDefaultTemplate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/document";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (template != null)
                    callPayload.Queries["template"] = SourceExpressionConverter.ConvertO(template);
                if (includeDefaultTemplate != null)
                    callPayload.Queries["includeDefaultTemplate"] = SourceExpressionConverter.ConvertO(includeDefaultTemplate);
                callPayload.Queries["excludeDocumentRelations"] = Convert.ToString(false);
                return callPayload;
            }

            return new ApiConnectionAction<DocumentProperties[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<DocumentProperties> GetDoc([WorkflowExpression] Func<bool> template, [WorkflowExpression] Func<string> docId)
        {
            SourceExpression.Validate(template, nameof(template), required: true);
            SourceExpression.Validate(docId, nameof(docId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template"] = SourceExpressionConverter.ConvertO(template);
                return callPayload;
            }

            return new ApiConnectionAction<DocumentProperties>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<DeleteDocResponse> DeleteDoc([WorkflowExpression] Func<string> docId)
        {
            SourceExpression.Validate(docId, nameof(docId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DeleteDocResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateFromTemplateResponse> CreateFromTemplate([WorkflowExpression] Func<string> docId, [WorkflowExpression] Func<string> bodydocumentName = null)
        {
            SourceExpression.Validate(docId, nameof(docId), required: true);
            SourceExpression.Validate(bodydocumentName, nameof(bodydocumentName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydocumentName != null)
                {
                    body["document_name"] = SourceExpressionConverter.ConvertToken(bodydocumentName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateFromTemplateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateSigningLinkResponse> CreateSigningLink([WorkflowExpression] Func<string> docId, [WorkflowExpression] Func<object> fields = null)
        {
            SourceExpression.Validate(docId, nameof(docId), required: true);
            SourceExpression.Validate(fields, nameof(fields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document/{0}/link", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(fields);
                return callPayload;
            }

            return new ApiConnectionAction<CreateSigningLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<JToken> SendInvite([WorkflowExpression] Func<bool> template, [WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(template, nameof(template), required: true);
            SourceExpression.Validate(templateId, nameof(templateId), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document/{0}/invite", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template"] = SourceExpressionConverter.ConvertO(template);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<JToken> SendGroupInvite([WorkflowExpression] Func<bool> template, [WorkflowExpression] Func<string> templateGroupId, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(template, nameof(template), required: true);
            SourceExpression.Validate(templateGroupId, nameof(templateGroupId), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/documentgroup/{0}/invite", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateGroupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template"] = SourceExpressionConverter.ConvertO(template);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<JToken> SendUserDefinedInvite([WorkflowExpression] Func<string> docId, [WorkflowExpression] Func<bodyroleInputItem[]> bodyrole = null, [WorkflowExpression] Func<string> bodycC = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string> bodyemailAllPartiesOnCompletion = null)
        {
            SourceExpression.Validate(docId, nameof(docId), required: true);
            SourceExpression.Validate(bodyrole, nameof(bodyrole), required: false);
            SourceExpression.Validate(bodycC, nameof(bodycC), required: false);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            SourceExpression.Validate(bodyemailAllPartiesOnCompletion, nameof(bodyemailAllPartiesOnCompletion), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document/{0}/invite-user-defined-schema", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyrole != null)
                {
                    body["Role"] = SourceExpressionConverter.ConvertToken(bodyrole);
                    bodypropCount++;
                }

                if (bodycC != null)
                {
                    body["cc"] = SourceExpressionConverter.ConvertToken(bodycC);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                if (bodymessage != null)
                {
                    body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                    bodypropCount++;
                }

                if (bodyemailAllPartiesOnCompletion != null)
                {
                    body["on_complete"] = SourceExpressionConverter.ConvertToken(bodyemailAllPartiesOnCompletion);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<JToken> CancelInvite([WorkflowExpression] Func<string> docId)
        {
            SourceExpression.Validate(docId, nameof(docId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document/{0}/invite-cancel", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<string> DownloadDocument([WorkflowExpression] Func<string> docId, [WorkflowExpression] Func<string> mode = null)
        {
            SourceExpression.Validate(docId, nameof(docId), required: true);
            SourceExpression.Validate(mode, nameof(mode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document/{0}/download", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mode"] = Convert.ToString("Collapsed");
                if (mode != null)
                    callPayload.Queries["mode"] = SourceExpressionConverter.ConvertO(mode);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IWorkflowAction PrefillSmartFields([WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> docId, [WorkflowExpression] Func<object> fields = null)
        {
            SourceExpression.Validate(templateId, nameof(templateId), required: true);
            SourceExpression.Validate(docId, nameof(docId), required: true);
            SourceExpression.Validate(fields, nameof(fields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document/{0}/smartfields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_id"] = SourceExpressionConverter.ConvertO(templateId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(fields);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<GetInviteStatusResponse> GetInviteStatus([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document/{0}/invite-status", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetInviteStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<GetDocumentGroupInviteStatusResponse> GetDocumentGroupInviteStatus([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/documentgroups/{0}/invite-status", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentGroupInviteStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<ReplaceRecipientsInDocumentInviteResponse> ReplaceRecipientsInDocumentInvite([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<replaceToreplaceToInputItem[]> replaceToreplaceTo = null, [WorkflowExpression] Func<replaceToadvancedParametersInputItem[]> replaceToadvancedParameters = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(replaceToreplaceTo, nameof(replaceToreplaceTo), required: false);
            SourceExpression.Validate(replaceToadvancedParameters, nameof(replaceToadvancedParameters), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document/{0}/replace-recipients", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var replaceTo = new JObject();
                var replaceTopropCount = 0;
                if (replaceToreplaceTo != null)
                {
                    replaceTo["replace_to"] = SourceExpressionConverter.ConvertToken(replaceToreplaceTo);
                    replaceTopropCount++;
                }

                if (replaceToadvancedParameters != null)
                {
                    replaceTo["advanced"] = SourceExpressionConverter.ConvertToken(replaceToadvancedParameters);
                    replaceTopropCount++;
                }

                if (replaceTopropCount > 0)
                {
                    callPayload.Body = replaceTo;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReplaceRecipientsInDocumentInviteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<ReplaceRecipientsInDocumentGroupInviteResponse> ReplaceRecipientsInDocumentGroupInvite([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> inviteId, [WorkflowExpression] Func<string> replaceTostepId = null, [WorkflowExpression] Func<string> replaceTorecipientToReplace = null, [WorkflowExpression] Func<string> replaceTonewRecipient = null, [WorkflowExpression] Func<int> replaceToexpirationDays = null, [WorkflowExpression] Func<int> replaceToreminder = null, [WorkflowExpression] Func<replaceToinviteActionAttributesInputItem[]> replaceToinviteActionAttributes = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(inviteId, nameof(inviteId), required: true);
            SourceExpression.Validate(replaceTostepId, nameof(replaceTostepId), required: false);
            SourceExpression.Validate(replaceTorecipientToReplace, nameof(replaceTorecipientToReplace), required: false);
            SourceExpression.Validate(replaceTonewRecipient, nameof(replaceTonewRecipient), required: false);
            SourceExpression.Validate(replaceToexpirationDays, nameof(replaceToexpirationDays), required: false);
            SourceExpression.Validate(replaceToreminder, nameof(replaceToreminder), required: false);
            SourceExpression.Validate(replaceToinviteActionAttributes, nameof(replaceToinviteActionAttributes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/documentgroup/{0}/invite/{1}/replace-recipients", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(inviteId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var replaceTo = new JObject();
                var replaceTopropCount = 0;
                if (replaceTostepId != null)
                {
                    replaceTo["step_id"] = SourceExpressionConverter.ConvertToken(replaceTostepId);
                    replaceTopropCount++;
                }

                if (replaceTorecipientToReplace != null)
                {
                    replaceTo["recipient_to_update"] = SourceExpressionConverter.ConvertToken(replaceTorecipientToReplace);
                    replaceTopropCount++;
                }

                if (replaceTonewRecipient != null)
                {
                    replaceTo["new_recipient"] = SourceExpressionConverter.ConvertToken(replaceTonewRecipient);
                    replaceTopropCount++;
                }

                if (replaceToexpirationDays != null)
                {
                    if (replaceToexpirationDays != null)
                    {
                        replaceTo["expiration_days"] = SourceExpressionConverter.ConvertToken(replaceToexpirationDays);
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
                    replaceTo["reminder"] = SourceExpressionConverter.ConvertToken(replaceToreminder);
                    replaceTopropCount++;
                }

                if (replaceToinviteActionAttributes != null)
                {
                    replaceTo["invite_action_attributes"] = SourceExpressionConverter.ConvertToken(replaceToinviteActionAttributes);
                    replaceTopropCount++;
                }

                if (replaceTopropCount > 0)
                {
                    callPayload.Body = replaceTo;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReplaceRecipientsInDocumentGroupInviteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateEmbeddedInviteSettingsLinkResponse> CreateEmbeddedInviteSettingsLink([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<inviteSettingstypeInput> inviteSettingstype = null, [WorkflowExpression] Func<string> inviteSettingsredirectUri = null, [WorkflowExpression] Func<int> inviteSettingslinkExpiration = null, [WorkflowExpression] Func<inviteSettingsredirectTargetInput> inviteSettingsredirectTarget = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(inviteSettingstype, nameof(inviteSettingstype), required: false);
            SourceExpression.Validate(inviteSettingsredirectUri, nameof(inviteSettingsredirectUri), required: false);
            SourceExpression.Validate(inviteSettingslinkExpiration, nameof(inviteSettingslinkExpiration), required: false);
            SourceExpression.Validate(inviteSettingsredirectTarget, nameof(inviteSettingsredirectTarget), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/documents/{0}/embedded-sending", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inviteSettings = new JObject();
                var inviteSettingspropCount = 0;
                if (inviteSettingstype != null)
                {
                    inviteSettings["type"] = SourceExpressionConverter.Convert(inviteSettingstype);
                    inviteSettingspropCount++;
                }

                if (inviteSettingsredirectUri != null)
                {
                    inviteSettings["redirect_uri"] = SourceExpressionConverter.ConvertToken(inviteSettingsredirectUri);
                    inviteSettingspropCount++;
                }

                if (inviteSettingslinkExpiration != null)
                {
                    if (inviteSettingslinkExpiration != null)
                    {
                        inviteSettings["link_expiration"] = SourceExpressionConverter.ConvertToken(inviteSettingslinkExpiration);
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
                    inviteSettings["redirect_target"] = SourceExpressionConverter.Convert(inviteSettingsredirectTarget);
                    inviteSettingspropCount++;
                }

                if (inviteSettingspropCount > 0)
                {
                    callPayload.Body = inviteSettings;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateEmbeddedInviteSettingsLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<CreateDocGroupEmbeddedInviteSettingsLinkResponse> CreateDocGroupEmbeddedInviteSettingsLink([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<inviteSettingstypeInput> inviteSettingstype = null, [WorkflowExpression] Func<string> inviteSettingsredirectUri = null, [WorkflowExpression] Func<int> inviteSettingslinkExpiration = null, [WorkflowExpression] Func<inviteSettingsredirectTargetInput> inviteSettingsredirectTarget = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(inviteSettingstype, nameof(inviteSettingstype), required: false);
            SourceExpression.Validate(inviteSettingsredirectUri, nameof(inviteSettingsredirectUri), required: false);
            SourceExpression.Validate(inviteSettingslinkExpiration, nameof(inviteSettingslinkExpiration), required: false);
            SourceExpression.Validate(inviteSettingsredirectTarget, nameof(inviteSettingsredirectTarget), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/documentgroup/{0}/embedded-sending", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inviteSettings = new JObject();
                var inviteSettingspropCount = 0;
                if (inviteSettingstype != null)
                {
                    if (inviteSettingstype != null)
                    {
                        inviteSettings["type"] = SourceExpressionConverter.Convert(inviteSettingstype);
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
                    inviteSettings["redirect_uri"] = SourceExpressionConverter.ConvertToken(inviteSettingsredirectUri);
                    inviteSettingspropCount++;
                }

                if (inviteSettingslinkExpiration != null)
                {
                    if (inviteSettingslinkExpiration != null)
                    {
                        inviteSettings["link_expiration"] = SourceExpressionConverter.ConvertToken(inviteSettingslinkExpiration);
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
                    inviteSettings["redirect_target"] = SourceExpressionConverter.Convert(inviteSettingsredirectTarget);
                    inviteSettingspropCount++;
                }

                if (inviteSettingspropCount > 0)
                {
                    callPayload.Body = inviteSettings;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateDocGroupEmbeddedInviteSettingsLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<InviteToSignAllOptionsResponse> InviteToSignAllOptions([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<invitesignersInputItem[]> invitesigners = null, [WorkflowExpression] Func<invitesignerAdvancedPropertiesInputItem[]> invitesignerAdvancedProperties = null, [WorkflowExpression] Func<inviteviewersInputItem[]> inviteviewers = null, [WorkflowExpression] Func<inviteviewerAdvancedPropertiesInputItem[]> inviteviewerAdvancedProperties = null, [WorkflowExpression] Func<inviteapproversInputItem[]> inviteapprovers = null, [WorkflowExpression] Func<inviteapproverAdvancedPropertiesInputItem[]> inviteapproverAdvancedProperties = null, [WorkflowExpression] Func<string> invitefrom = null, [WorkflowExpression] Func<inviteemailGroupsInputItem[]> inviteemailGroups = null, [WorkflowExpression] Func<invitecCInputItem[]> invitecC = null, [WorkflowExpression] Func<invitecCStepsInputItem[]> invitecCSteps = null, [WorkflowExpression] Func<string> invitesubject = null, [WorkflowExpression] Func<string> invitemessage = null, [WorkflowExpression] Func<string> invitecCSubject = null, [WorkflowExpression] Func<string> invitecCMessage = null, [WorkflowExpression] Func<inviteqESSignatureInput> inviteqESSignature = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(invitesigners, nameof(invitesigners), required: false);
            SourceExpression.Validate(invitesignerAdvancedProperties, nameof(invitesignerAdvancedProperties), required: false);
            SourceExpression.Validate(inviteviewers, nameof(inviteviewers), required: false);
            SourceExpression.Validate(inviteviewerAdvancedProperties, nameof(inviteviewerAdvancedProperties), required: false);
            SourceExpression.Validate(inviteapprovers, nameof(inviteapprovers), required: false);
            SourceExpression.Validate(inviteapproverAdvancedProperties, nameof(inviteapproverAdvancedProperties), required: false);
            SourceExpression.Validate(invitefrom, nameof(invitefrom), required: false);
            SourceExpression.Validate(inviteemailGroups, nameof(inviteemailGroups), required: false);
            SourceExpression.Validate(invitecC, nameof(invitecC), required: false);
            SourceExpression.Validate(invitecCSteps, nameof(invitecCSteps), required: false);
            SourceExpression.Validate(invitesubject, nameof(invitesubject), required: false);
            SourceExpression.Validate(invitemessage, nameof(invitemessage), required: false);
            SourceExpression.Validate(invitecCSubject, nameof(invitecCSubject), required: false);
            SourceExpression.Validate(invitecCMessage, nameof(invitecCMessage), required: false);
            SourceExpression.Validate(inviteqESSignature, nameof(inviteqESSignature), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document/{0}/invite-all-options", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var invite = new JObject();
                var invitepropCount = 0;
                if (invitesigners != null)
                {
                    invite["signers"] = SourceExpressionConverter.ConvertToken(invitesigners);
                    invitepropCount++;
                }

                if (invitesignerAdvancedProperties != null)
                {
                    invite["signers_advanced"] = SourceExpressionConverter.ConvertToken(invitesignerAdvancedProperties);
                    invitepropCount++;
                }

                if (inviteviewers != null)
                {
                    invite["viewers"] = SourceExpressionConverter.ConvertToken(inviteviewers);
                    invitepropCount++;
                }

                if (inviteviewerAdvancedProperties != null)
                {
                    invite["viewers_advanced"] = SourceExpressionConverter.ConvertToken(inviteviewerAdvancedProperties);
                    invitepropCount++;
                }

                if (inviteapprovers != null)
                {
                    invite["approvers"] = SourceExpressionConverter.ConvertToken(inviteapprovers);
                    invitepropCount++;
                }

                if (inviteapproverAdvancedProperties != null)
                {
                    invite["approver_advanced"] = SourceExpressionConverter.ConvertToken(inviteapproverAdvancedProperties);
                    invitepropCount++;
                }

                if (invitefrom != null)
                {
                    invite["from"] = SourceExpressionConverter.ConvertToken(invitefrom);
                    invitepropCount++;
                }

                if (inviteemailGroups != null)
                {
                    invite["email_groups"] = SourceExpressionConverter.ConvertToken(inviteemailGroups);
                    invitepropCount++;
                }

                if (invitecC != null)
                {
                    invite["cc"] = SourceExpressionConverter.ConvertToken(invitecC);
                    invitepropCount++;
                }

                if (invitecCSteps != null)
                {
                    invite["cc_step"] = SourceExpressionConverter.ConvertToken(invitecCSteps);
                    invitepropCount++;
                }

                if (invitesubject != null)
                {
                    invite["subject"] = SourceExpressionConverter.ConvertToken(invitesubject);
                    invitepropCount++;
                }

                if (invitemessage != null)
                {
                    invite["message"] = SourceExpressionConverter.ConvertToken(invitemessage);
                    invitepropCount++;
                }

                if (invitecCSubject != null)
                {
                    invite["cc_subject"] = SourceExpressionConverter.ConvertToken(invitecCSubject);
                    invitepropCount++;
                }

                if (invitecCMessage != null)
                {
                    invite["cc_message"] = SourceExpressionConverter.ConvertToken(invitecCMessage);
                    invitepropCount++;
                }

                if (inviteqESSignature != null)
                {
                    invite["signature"] = SourceExpressionConverter.Convert(inviteqESSignature);
                    invitepropCount++;
                }

                if (invitepropCount > 0)
                {
                    callPayload.Body = invite;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InviteToSignAllOptionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<InviteToSignDocGroupAllOptionsResponse> InviteToSignDocGroupAllOptions([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<inviteinviteStepsInputItem[]> inviteinviteSteps = null, [WorkflowExpression] Func<inviteinviteEmailsInputItem[]> inviteinviteEmails = null, [WorkflowExpression] Func<inviteemailGroupsInputItem2[]> inviteemailGroups = null, [WorkflowExpression] Func<invitecompletionEmailsInputItem[]> invitecompletionEmails = null, [WorkflowExpression] Func<bool> invitesignAsMerged = null, [WorkflowExpression] Func<int> inviteclientTimestamp = null, [WorkflowExpression] Func<invitecCInputItem[]> invitecC = null, [WorkflowExpression] Func<inviteqESSignatureInput> inviteqESSignature = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(inviteinviteSteps, nameof(inviteinviteSteps), required: false);
            SourceExpression.Validate(inviteinviteEmails, nameof(inviteinviteEmails), required: false);
            SourceExpression.Validate(inviteemailGroups, nameof(inviteemailGroups), required: false);
            SourceExpression.Validate(invitecompletionEmails, nameof(invitecompletionEmails), required: false);
            SourceExpression.Validate(invitesignAsMerged, nameof(invitesignAsMerged), required: false);
            SourceExpression.Validate(inviteclientTimestamp, nameof(inviteclientTimestamp), required: false);
            SourceExpression.Validate(invitecC, nameof(invitecC), required: false);
            SourceExpression.Validate(inviteqESSignature, nameof(inviteqESSignature), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/documentgroup/{0}/invite-all-options", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var invite = new JObject();
                var invitepropCount = 0;
                if (inviteinviteSteps != null)
                {
                    invite["invite_steps"] = SourceExpressionConverter.ConvertToken(inviteinviteSteps);
                    invitepropCount++;
                }

                if (inviteinviteEmails != null)
                {
                    invite["Email"] = SourceExpressionConverter.ConvertToken(inviteinviteEmails);
                    invitepropCount++;
                }

                if (inviteemailGroups != null)
                {
                    invite["email_groups"] = SourceExpressionConverter.ConvertToken(inviteemailGroups);
                    invitepropCount++;
                }

                if (invitecompletionEmails != null)
                {
                    invite["completion_emails"] = SourceExpressionConverter.ConvertToken(invitecompletionEmails);
                    invitepropCount++;
                }

                if (invitesignAsMerged != null)
                {
                    invite["sign_as_merged"] = SourceExpressionConverter.ConvertToken(invitesignAsMerged);
                    invitepropCount++;
                }

                if (inviteclientTimestamp != null)
                {
                    invite["client_timestamp"] = SourceExpressionConverter.ConvertToken(inviteclientTimestamp);
                    invitepropCount++;
                }

                if (invitecC != null)
                {
                    invite["cc"] = SourceExpressionConverter.ConvertToken(invitecC);
                    invitepropCount++;
                }

                if (inviteqESSignature != null)
                {
                    invite["signature"] = SourceExpressionConverter.Convert(inviteqESSignature);
                    invitepropCount++;
                }

                if (invitepropCount > 0)
                {
                    callPayload.Body = invite;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InviteToSignDocGroupAllOptionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<JToken> GetDocFields([WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> docId)
        {
            SourceExpression.Validate(templateId, nameof(templateId), required: true);
            SourceExpression.Validate(docId, nameof(docId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/document/{0}/fields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_id"] = SourceExpressionConverter.ConvertO(templateId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signnow")]
        public IBodyWorkflowAction<UpdateFieldValuesV2Response> UpdateFieldValues([WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> docId, [WorkflowExpression] Func<object> fields = null)
        {
            SourceExpression.Validate(templateId, nameof(templateId), required: true);
            SourceExpression.Validate(docId, nameof(docId), required: true);
            SourceExpression.Validate(fields, nameof(fields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/document/{0}/fields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["template_id"] = SourceExpressionConverter.ConvertO(templateId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(fields);
                return callPayload;
            }

            return new ApiConnectionAction<UpdateFieldValuesV2Response>(BuildSourceInput);
        }
    }

    public class SignnowTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TriggersV2Response> Triggers([WorkflowExpression] Func<string> bodyEvent, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyEvent, nameof(bodyEvent), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/multievent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event"] = SourceExpressionConverter.ConvertToken(bodyEvent);
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
                return callPayload;
            }

            return new ApiConnectionTrigger<TriggersV2Response>(BuildSourceInput, triggerName, recurrence);
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

    public class inviteinvitesInputItem22
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