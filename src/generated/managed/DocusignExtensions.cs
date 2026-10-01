//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Docusign
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocusignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<DocGenFormFieldsResponse> GetDocgenFormFields([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> envelopeId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}/docGenFormFields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DocGenFormFieldsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IWorkflowAction UpdateDocgenFormFields([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> documentGuid, [WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}/docGenFormFields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentGuid"] = SourceExpressionConverter.ConvertO(documentGuid);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<JToken> GetDocGenTemplateTabs([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> templateId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/templates/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<JToken> VoidEnvelope([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> voidedReason)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}/voidEnvelope", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["voidedReason"] = SourceExpressionConverter.ConvertO(voidedReason);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<JToken> ResendEnvelope([WorkflowExpression] Func<string> envelopeId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/copilotAccount/envelopes/{0}/resendEnvelope", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<AddRemindersResponse> AddReminders([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<bool> reminderEnabled, [WorkflowExpression] Func<string> reminderDelay, [WorkflowExpression] Func<string> reminderFrequency, [WorkflowExpression] Func<string> expireAfter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}/notification", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["reminderEnabled"] = SourceExpressionConverter.ConvertO(reminderEnabled);
                callPayload.Queries["reminderDelay"] = SourceExpressionConverter.ConvertO(reminderDelay);
                callPayload.Queries["reminderFrequency"] = SourceExpressionConverter.ConvertO(reminderFrequency);
                if (expireAfter != null)
                    callPayload.Queries["expireAfter"] = SourceExpressionConverter.ConvertO(expireAfter);
                return callPayload;
            }

            return new ApiConnectionAction<AddRemindersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<ListTabsResponse> GetEnvelopeDocumentTabs([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> documentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}/documents/{2}/tabs", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListTabsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IWorkflowAction UpdateEnvelopePrefillTabs([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<bodyInputItem2[]> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}/documents/{2}/tabs", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<ListTabsResponse> GetTemplateDocumentTabs([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> documentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/templates/{1}/documents/{2}/tabs", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListTabsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<ListEnvelopeDocumentFieldsResponse> GetEnvelopeDocumentFields([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> documentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}/documents/{2}/fields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListEnvelopeDocumentFieldsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<CompositeTemplatesResponse> CompositeTemplates([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> emailSubject, [WorkflowExpression] Func<statusInput> status, [WorkflowExpression] Func<string> emailBody = null, [WorkflowExpression] Func<mergeRolesOnDraftInput> mergeRolesOnDraft = null, [WorkflowExpression] Func<object> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/compositeTemplates", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["emailSubject"] = SourceExpressionConverter.ConvertO(emailSubject);
                if (emailBody != null)
                    callPayload.Queries["emailBody"] = SourceExpressionConverter.ConvertO(emailBody);
                callPayload.Queries["status"] = SourceExpressionConverter.Convert(status);
                callPayload.Queries["merge_roles_on_draft"] = Convert.ToString("True");
                if (mergeRolesOnDraft != null)
                    callPayload.Queries["merge_roles_on_draft"] = SourceExpressionConverter.Convert(mergeRolesOnDraft);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<CompositeTemplatesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<FilteredEnvelopeListResponse> SearchListEnvelopes([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> recipientName = null, [WorkflowExpression] Func<string> recipientEmailId = null, [WorkflowExpression] Func<string> envelopeTitle = null, [WorkflowExpression] Func<string> customFieldName = null, [WorkflowExpression] Func<string> customFieldValue = null, [WorkflowExpression] Func<string> searchText = null, [WorkflowExpression] Func<envelopeStatusInput> envelopeStatus = null, [WorkflowExpression] Func<folderIdsInput> folderIds = null, [WorkflowExpression] Func<orderByInput> orderBy = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> fromDate = null, [WorkflowExpression] Func<string> toDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/SearchListEnvelopes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recipientName != null)
                    callPayload.Queries["recipientName"] = SourceExpressionConverter.ConvertO(recipientName);
                if (recipientEmailId != null)
                    callPayload.Queries["recipientEmailId"] = SourceExpressionConverter.ConvertO(recipientEmailId);
                if (envelopeTitle != null)
                    callPayload.Queries["envelopeTitle"] = SourceExpressionConverter.ConvertO(envelopeTitle);
                if (customFieldName != null)
                    callPayload.Queries["customFieldName"] = SourceExpressionConverter.ConvertO(customFieldName);
                if (customFieldValue != null)
                    callPayload.Queries["customFieldValue"] = SourceExpressionConverter.ConvertO(customFieldValue);
                if (searchText != null)
                    callPayload.Queries["search_text"] = SourceExpressionConverter.ConvertO(searchText);
                callPayload.Queries["envelopeStatus"] = Convert.ToString("Any");
                if (envelopeStatus != null)
                    callPayload.Queries["envelopeStatus"] = SourceExpressionConverter.Convert(envelopeStatus);
                if (folderIds != null)
                    callPayload.Queries["folder_ids"] = SourceExpressionConverter.Convert(folderIds);
                callPayload.Queries["order_by"] = Convert.ToString("Status changed");
                if (orderBy != null)
                    callPayload.Queries["order_by"] = SourceExpressionConverter.Convert(orderBy);
                if (top != null)
                    callPayload.Queries["top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["skip"] = SourceExpressionConverter.ConvertO(skip);
                callPayload.Queries["from_date"] = Convert.ToString("2024-01-02T12:45Z");
                if (fromDate != null)
                    callPayload.Queries["from_date"] = SourceExpressionConverter.ConvertO(fromDate);
                if (toDate != null)
                    callPayload.Queries["to_date"] = SourceExpressionConverter.ConvertO(toDate);
                return callPayload;
            }

            return new ApiConnectionAction<FilteredEnvelopeListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<CreateEnvelopeResponse> CreateEnvelopeFromTemplateNoRecipients([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<statusInput> status)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/createFromTemplateNoRecipients", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["templateId"] = SourceExpressionConverter.ConvertO(templateId);
                callPayload.Queries["status"] = SourceExpressionConverter.Convert(status);
                return callPayload;
            }

            return new ApiConnectionAction<CreateEnvelopeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<CreateEnvelopeResponse> SendEnvelope([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<statusInput> status, [WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<object> signers = null, [WorkflowExpression] Func<string> emailSubject = null, [WorkflowExpression] Func<string> emailBody = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["status"] = SourceExpressionConverter.Convert(status);
                callPayload.Queries["templateId"] = SourceExpressionConverter.ConvertO(templateId);
                if (emailSubject != null)
                    callPayload.Queries["emailSubject"] = SourceExpressionConverter.ConvertO(emailSubject);
                if (emailBody != null)
                    callPayload.Queries["emailBody"] = SourceExpressionConverter.ConvertO(emailBody);
                callPayload.Body = SourceExpressionConverter.ConvertToken(signers);
                return callPayload;
            }

            return new ApiConnectionAction<CreateEnvelopeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<CreateEnvelopeResponse> SendEnvelopeWithRecipientFields([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<object> recipients = null, [WorkflowExpression] Func<mergeRolesOnDraftInput> mergeRolesOnDraft = null, [WorkflowExpression] Func<string> emailSubject = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/createWithRecipientFields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["templateId"] = SourceExpressionConverter.ConvertO(templateId);
                callPayload.Queries["merge_roles_on_draft"] = Convert.ToString("False");
                if (mergeRolesOnDraft != null)
                    callPayload.Queries["merge_roles_on_draft"] = SourceExpressionConverter.Convert(mergeRolesOnDraft);
                if (emailSubject != null)
                    callPayload.Queries["emailSubject"] = SourceExpressionConverter.ConvertO(emailSubject);
                callPayload.Body = SourceExpressionConverter.ConvertToken(recipients);
                return callPayload;
            }

            return new ApiConnectionAction<CreateEnvelopeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<JToken> SendDraftEnvelope([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> envelopeId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<EnvelopeCustomFieldResponse> GetEnvelopeCustomField([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> fieldName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}/custom_fields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fieldName"] = SourceExpressionConverter.ConvertO(fieldName);
                return callPayload;
            }

            return new ApiConnectionAction<EnvelopeCustomFieldResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<UpdateEnvelopeCustomFieldResponse> UpdateEnvelopeCustomField([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> fieldId, [WorkflowExpression] Func<string> fieldType, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> value)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}/custom_fields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fieldId"] = SourceExpressionConverter.ConvertO(fieldId);
                callPayload.Queries["fieldType"] = SourceExpressionConverter.ConvertO(fieldType);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                callPayload.Queries["value"] = SourceExpressionConverter.ConvertO(value);
                return callPayload;
            }

            return new ApiConnectionAction<UpdateEnvelopeCustomFieldResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<EmbeddedSenderResponse> GenerateEmbeddedSenderURL([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<openInInput> openIn, [WorkflowExpression] Func<returnUrlInput> returnUrl, [WorkflowExpression] Func<object> additionalURL = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}/views/sender", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["openIn"] = SourceExpressionConverter.Convert(openIn);
                callPayload.Queries["returnUrl"] = SourceExpressionConverter.Convert(returnUrl);
                callPayload.Body = SourceExpressionConverter.ConvertToken(additionalURL);
                return callPayload;
            }

            return new ApiConnectionAction<EmbeddedSenderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<ListRecipientsResponse> GetRecipientStatus([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> envelopeId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}/recipients", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListRecipientsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<ListRecipientsResponse> RemoveRecipientFromEnvelope([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> removeRecipientFromEnvelopeRecipientId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}/recipients", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = SourceExpressionConverter.ConvertO(folderId);
                callPayload.Queries["RemoveRecipientFromEnvelopeRecipientId"] = SourceExpressionConverter.ConvertO(removeRecipientFromEnvelopeRecipientId);
                return callPayload;
            }

            return new ApiConnectionAction<ListRecipientsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<Signer> GetRecipientFields([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> recipientEmail = null, [WorkflowExpression] Func<string> areaCode = null, [WorkflowExpression] Func<string> phoneNumber = null, [WorkflowExpression] Func<string> recipientId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}/recipientFields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (recipientEmail != null)
                    callPayload.Queries["recipientEmail"] = SourceExpressionConverter.ConvertO(recipientEmail);
                if (areaCode != null)
                    callPayload.Queries["areaCode"] = SourceExpressionConverter.ConvertO(areaCode);
                if (phoneNumber != null)
                    callPayload.Queries["phoneNumber"] = SourceExpressionConverter.ConvertO(phoneNumber);
                if (recipientId != null)
                    callPayload.Queries["recipientId"] = SourceExpressionConverter.ConvertO(recipientId);
                return callPayload;
            }

            return new ApiConnectionAction<Signer>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<JToken> GetAuditEvents([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> envelopeId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}/audit_events", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IWorkflowAction AddVerificationToRecipient([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> recipientId, [WorkflowExpression] Func<string> recipientType, [WorkflowExpression] Func<verificationTypeInput> verificationType, [WorkflowExpression] Func<object> additionalRecipientData = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}/recipients/addRecipientV2", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["recipientId"] = SourceExpressionConverter.ConvertO(recipientId);
                callPayload.Queries["recipientType"] = SourceExpressionConverter.ConvertO(recipientType);
                callPayload.Queries["verificationType"] = SourceExpressionConverter.Convert(verificationType);
                callPayload.Body = SourceExpressionConverter.ConvertToken(additionalRecipientData);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<Signer> UpdateEnvelopeRecipient([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> recipientId, [WorkflowExpression] Func<string> recipientType, [WorkflowExpression] Func<string> signatureType = null, [WorkflowExpression] Func<string> clientUserId = null, [WorkflowExpression] Func<string> embeddedRecipientStartURL = null, [WorkflowExpression] Func<string> routingOrder = null, [WorkflowExpression] Func<emailNotificationLanguageInput> emailNotificationLanguage = null, [WorkflowExpression] Func<string> emailNotificationSubject = null, [WorkflowExpression] Func<string> emailNotificationBody = null, [WorkflowExpression] Func<string> note = null, [WorkflowExpression] Func<string> roleName = null, [WorkflowExpression] Func<string> countryCode = null, [WorkflowExpression] Func<string> phoneNumber = null, [WorkflowExpression] Func<string> signingGroupId = null, [WorkflowExpression] Func<object> additionalRecipientParams = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}/recipients/updateRecipient", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["recipientId"] = SourceExpressionConverter.ConvertO(recipientId);
                if (signatureType != null)
                    callPayload.Queries["signatureType"] = SourceExpressionConverter.ConvertO(signatureType);
                callPayload.Queries["recipientType"] = SourceExpressionConverter.ConvertO(recipientType);
                if (clientUserId != null)
                    callPayload.Queries["clientUserId"] = SourceExpressionConverter.ConvertO(clientUserId);
                if (embeddedRecipientStartURL != null)
                    callPayload.Queries["embeddedRecipientStartURL"] = SourceExpressionConverter.ConvertO(embeddedRecipientStartURL);
                if (routingOrder != null)
                    callPayload.Queries["routingOrder"] = SourceExpressionConverter.ConvertO(routingOrder);
                if (emailNotificationLanguage != null)
                    callPayload.Queries["emailNotificationLanguage"] = SourceExpressionConverter.Convert(emailNotificationLanguage);
                if (emailNotificationSubject != null)
                    callPayload.Queries["emailNotificationSubject"] = SourceExpressionConverter.ConvertO(emailNotificationSubject);
                if (emailNotificationBody != null)
                    callPayload.Queries["emailNotificationBody"] = SourceExpressionConverter.ConvertO(emailNotificationBody);
                if (note != null)
                    callPayload.Queries["note"] = SourceExpressionConverter.ConvertO(note);
                if (roleName != null)
                    callPayload.Queries["roleName"] = SourceExpressionConverter.ConvertO(roleName);
                if (countryCode != null)
                    callPayload.Queries["countryCode"] = SourceExpressionConverter.ConvertO(countryCode);
                if (phoneNumber != null)
                    callPayload.Queries["phoneNumber"] = SourceExpressionConverter.ConvertO(phoneNumber);
                if (signingGroupId != null)
                    callPayload.Queries["signingGroupId"] = SourceExpressionConverter.ConvertO(signingGroupId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(additionalRecipientParams);
                return callPayload;
            }

            return new ApiConnectionAction<Signer>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IWorkflowAction ApplyTemplatesToDocuments([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<preserveTemplateRecipientInput> preserveTemplateRecipient = null, [WorkflowExpression] Func<bodydocumentTemplatesInputItem[]> bodydocumentTemplates = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}/templates", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["templateId"] = SourceExpressionConverter.ConvertO(templateId);
                callPayload.Queries["preserve_template_recipient"] = Convert.ToString("False");
                if (preserveTemplateRecipient != null)
                    callPayload.Queries["preserve_template_recipient"] = SourceExpressionConverter.Convert(preserveTemplateRecipient);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydocumentTemplates != null)
                {
                    body["documentTemplates"] = SourceExpressionConverter.ConvertToken(bodydocumentTemplates);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<BulkSendListGuidInfo> CreateBulkSendList([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> csvcSVFile = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/bulk_send_lists", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                var csv = new JObject();
                var csvpropCount = 0;
                if (csvcSVFile != null)
                {
                    csv["csv"] = SourceExpressionConverter.ConvertToken(csvcSVFile);
                    csvpropCount++;
                }

                var rawOutputObject = new JObject();
                var rawOutputObjectpropCount = 0;
                if (rawOutputObjectpropCount > 0)
                {
                    csv["rawOutput"] = rawOutputObject;
                    csvpropCount++;
                }

                if (csvpropCount > 0)
                {
                    callPayload.Body = csv;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BulkSendListGuidInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<BulkSendListGuidInfo> BulkSend([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> bulkSendListId, [WorkflowExpression] Func<string> envelopeOrTemplateId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/bulk_send_lists/{1}/send", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bulkSendListId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["envelopeOrTemplateId"] = SourceExpressionConverter.ConvertO(envelopeOrTemplateId);
                return callPayload;
            }

            return new ApiConnectionAction<BulkSendListGuidInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<GetLoginAccountsResponse> GetLoginAccounts()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/oauth/userinfo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetLoginAccountsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<ListTemplatesResponse> GetEnvelopeTemplates([WorkflowExpression] Func<string> accountId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/templates", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListTemplatesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<AddDocumentsResponse> AddDocumentsToEnvelope([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<bodyunnamedInputItem[]> bodyunnamed = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}/documents", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyunnamed != null)
                {
                    body["documents"] = SourceExpressionConverter.ConvertToken(bodyunnamed);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddDocumentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<ListTemplateDocumentsResponse> ListTemplateDocuments([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> templateId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/templates/{1}/documents", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListTemplateDocumentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<ListDocumentsResponse> ListEnvelopeDocuments([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> envelopeId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}/envelopeDocuments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListDocumentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<EnvelopeDocument> GetEnvelopeDocumentInfo([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> documentName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}/get_document_info", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentName"] = SourceExpressionConverter.ConvertO(documentName);
                return callPayload;
            }

            return new ApiConnectionAction<EnvelopeDocument>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<Tab> GetTabInfo([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> recipientId, [WorkflowExpression] Func<string> tabLabel)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}/recipients/{2}/tabs", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tabLabel"] = SourceExpressionConverter.ConvertO(tabLabel);
                return callPayload;
            }

            return new ApiConnectionAction<Tab>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<AddRecipientTabsResponse> AddRecipientTabs([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> recipientId, [WorkflowExpression] Func<string> tabType, [WorkflowExpression] Func<object> tabDetails = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}/recipients/{2}/tabs", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tabType"] = SourceExpressionConverter.ConvertO(tabType);
                callPayload.Body = SourceExpressionConverter.ConvertToken(tabDetails);
                return callPayload;
            }

            return new ApiConnectionAction<AddRecipientTabsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IWorkflowAction UpdateRecipientTabsValues([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> recipientId, [WorkflowExpression] Func<bodyInputItem22[]> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}/recipients/{2}/tabs", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<RecipientTabsResponse> GetEnvelopeRecipientTabs([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> recipientId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}/recipients/{2}/recipientTabs", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<RecipientTabsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<JToken> TriggerMaestroFlow([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> workflowId, [WorkflowExpression] Func<string> instanceName, [WorkflowExpression] Func<object> variable = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/maestro-workflows/trigger/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workflowId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["instanceName"] = SourceExpressionConverter.ConvertO(instanceName);
                callPayload.Body = SourceExpressionConverter.ConvertToken(variable);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<JToken> BuildNumber([WorkflowExpression] Func<object> buildNumber = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/build_number";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(buildNumber);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<Signer> AddRecipientToEnvelope([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> recipientType, [WorkflowExpression] Func<string> clientUserId = null, [WorkflowExpression] Func<string> recipientId = null, [WorkflowExpression] Func<string> embeddedRecipientStartURL = null, [WorkflowExpression] Func<string> routingOrder = null, [WorkflowExpression] Func<emailNotificationLanguageInput> emailNotificationLanguage = null, [WorkflowExpression] Func<string> emailNotificationSubject = null, [WorkflowExpression] Func<string> emailNotificationBody = null, [WorkflowExpression] Func<string> note = null, [WorkflowExpression] Func<string> roleName = null, [WorkflowExpression] Func<string> countryCode = null, [WorkflowExpression] Func<string> phoneNumber = null, [WorkflowExpression] Func<string> signingGroupId = null, [WorkflowExpression] Func<string> signatureType = null, [WorkflowExpression] Func<string> workflowId = null, [WorkflowExpression] Func<object> additionalRecipientParams = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}/recipients/addRecipientV2", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["recipientType"] = SourceExpressionConverter.ConvertO(recipientType);
                if (clientUserId != null)
                    callPayload.Queries["clientUserId"] = SourceExpressionConverter.ConvertO(clientUserId);
                if (recipientId != null)
                    callPayload.Queries["recipientId"] = SourceExpressionConverter.ConvertO(recipientId);
                if (embeddedRecipientStartURL != null)
                    callPayload.Queries["embeddedRecipientStartURL"] = SourceExpressionConverter.ConvertO(embeddedRecipientStartURL);
                if (routingOrder != null)
                    callPayload.Queries["routingOrder"] = SourceExpressionConverter.ConvertO(routingOrder);
                if (emailNotificationLanguage != null)
                    callPayload.Queries["emailNotificationLanguage"] = SourceExpressionConverter.Convert(emailNotificationLanguage);
                if (emailNotificationSubject != null)
                    callPayload.Queries["emailNotificationSubject"] = SourceExpressionConverter.ConvertO(emailNotificationSubject);
                if (emailNotificationBody != null)
                    callPayload.Queries["emailNotificationBody"] = SourceExpressionConverter.ConvertO(emailNotificationBody);
                if (note != null)
                    callPayload.Queries["note"] = SourceExpressionConverter.ConvertO(note);
                if (roleName != null)
                    callPayload.Queries["roleName"] = SourceExpressionConverter.ConvertO(roleName);
                if (countryCode != null)
                    callPayload.Queries["countryCode"] = SourceExpressionConverter.ConvertO(countryCode);
                if (phoneNumber != null)
                    callPayload.Queries["phoneNumber"] = SourceExpressionConverter.ConvertO(phoneNumber);
                if (signingGroupId != null)
                    callPayload.Queries["signingGroupId"] = SourceExpressionConverter.ConvertO(signingGroupId);
                if (signatureType != null)
                    callPayload.Queries["signatureType"] = SourceExpressionConverter.ConvertO(signatureType);
                if (workflowId != null)
                    callPayload.Queries["workflowId"] = SourceExpressionConverter.ConvertO(workflowId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(additionalRecipientParams);
                return callPayload;
            }

            return new ApiConnectionAction<Signer>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<CreateEnvelopeResponse> CreateBlankEnvelope([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> emailSubject, [WorkflowExpression] Func<string> bodyemailBody = null, [WorkflowExpression] Func<object> bodyaccountCustomFields = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/createBlankEnvelopeV2", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["emailSubject"] = SourceExpressionConverter.ConvertO(emailSubject);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyemailBody != null)
                {
                    body["emailBlurb"] = SourceExpressionConverter.ConvertToken(bodyemailBody);
                    bodypropCount++;
                }

                if (bodyaccountCustomFields != null)
                {
                    body["AccountCustomFields"] = SourceExpressionConverter.ConvertToken(bodyaccountCustomFields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateEnvelopeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<EmbeddedSigningResponse> GenerateEmbeddedSigningURL([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<isInPersonSignerInput> isInPersonSigner, [WorkflowExpression] Func<authenticationMethodInput> authenticationMethod, [WorkflowExpression] Func<returnUrlInput> returnUrl, [WorkflowExpression] Func<object> additionalURL = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}/views/recipientV2", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["isInPersonSigner"] = SourceExpressionConverter.Convert(isInPersonSigner);
                callPayload.Queries["authenticationMethod"] = SourceExpressionConverter.Convert(authenticationMethod);
                callPayload.Queries["returnUrl"] = SourceExpressionConverter.Convert(returnUrl);
                callPayload.Body = SourceExpressionConverter.ConvertToken(additionalURL);
                return callPayload;
            }

            return new ApiConnectionAction<EmbeddedSigningResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<string> GetDocuments([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<documentIdInput> documentId, [WorkflowExpression] Func<languageInput> language = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/envelopes/{1}/documents/{2}/documentsDownload", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["language"] = Convert.ToString("English (default)");
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.Convert(language);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }
    }

    public class DocusignTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> CreateOrgHookEnvelope([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> bodyconnectConfigurationName, [WorkflowExpression] Func<bodytriggerEventsInputItem[]> bodytriggerEvents, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Management/v2/organizations/{0}/connect", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organizationId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["allUsers"] = "true";
                bodypropCount++;
                body["allowEnvelopePublish"] = "true";
                bodypropCount++;
                body["includeDocumentFields"] = "true";
                bodypropCount++;
                body["requiresAcknowledgement"] = "true";
                bodypropCount++;
                body["urlToPublishTo"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyconnectConfigurationName);
                bodypropCount++;
                body["events"] = SourceExpressionConverter.ConvertToken(bodytriggerEvents);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateHookEnvelope([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> bodyconnectConfigurationName, [WorkflowExpression] Func<bodytriggerEventsInputItem[]> bodytriggerEvents, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/accounts/{0}/connectV4", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["allUsers"] = "true";
                bodypropCount++;
                body["allowEnvelopePublish"] = "true";
                bodypropCount++;
                body["includeDocumentFields"] = "true";
                bodypropCount++;
                body["requiresAcknowledgement"] = "true";
                bodypropCount++;
                body["urlToPublishTo"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyconnectConfigurationName);
                bodypropCount++;
                body["events"] = SourceExpressionConverter.ConvertToken(bodytriggerEvents);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class DocGenFormFieldsResponse
    {
        [JsonProperty("docgenFields")]
        public DocGenFormField[] DocgenFields { get; set; }
    }

    public class DocGenFormField
    {
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class bodyInputItem
    {
        [JsonProperty("fieldType")]
        public bodyInputItemTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("tableName")]
        public string TableName { get; set; }

        [JsonProperty("rowNumber")]
        public string TableRow { get; set; }
    }

    public enum bodyInputItemTypeType
    {
        Text,
        Note,
        Number
    }

    public class AddRemindersResponse
    {
        [JsonProperty("reminderEnabled")]
        public string ReminderEnabled { get; set; }
    }

    public class ListTabsResponse
    {
        [JsonProperty("tabs")]
        public Tab[] Tabs { get; set; }
    }

    public class Tab
    {
        [JsonProperty("name")]
        public string TabName { get; set; }

        [JsonProperty("tabType")]
        public string TabType { get; set; }

        [JsonProperty("tabLabel")]
        public string TabLabel { get; set; }

        [JsonProperty("value")]
        public string TabValue { get; set; }

        [JsonProperty("tabId")]
        public string TabId { get; set; }

        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("recipientId")]
        public string RecipientID { get; set; }

        [JsonProperty("prefill")]
        public bool IsPrefill { get; set; }

        [JsonProperty("selected")]
        public string Selected { get; set; }
    }

    public class bodyInputItem2
    {
        [JsonProperty("tabType")]
        public string Type { get; set; }

        [JsonProperty("tabId")]
        public string ID { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ListEnvelopeDocumentFieldsResponse
    {
        [JsonProperty("envelopeDocumentFields")]
        public EnvelopeDocumentField[] CustomField { get; set; }
    }

    public class EnvelopeDocumentField
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CompositeTemplatesResponse
    {
        [JsonProperty("envelopeId")]
        public string EnvelopeId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusDateTime")]
        public string StatusDateTime { get; set; }

        [JsonProperty("uri")]
        public string URI { get; set; }
    }

    public enum statusInput
    {
        Sent,
        Created
    }

    public enum mergeRolesOnDraftInput
    {
        False,
        True
    }

    public class FilteredEnvelopeListResponse
    {
        [JsonProperty("value")]
        public FilteredEnvelopes[] FilteredEnvelopes { get; set; }

        [JsonProperty("hasMoreResults")]
        public bool MoreEnvelopeResults { get; set; }
    }

    public class FilteredEnvelopes
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("envelopeId")]
        public string EnvelopeID { get; set; }

        [JsonProperty("documents")]
        public string Documents { get; set; }

        [JsonProperty("recipients")]
        public string RecipientNames { get; set; }

        [JsonProperty("sender")]
        public string SenderName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusDate")]
        public string StatusDate { get; set; }

        [JsonProperty("dateSent")]
        public string DateSent { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }
    }

    public enum envelopeStatusInput
    {
        Any,
        Created,
        Sent,
        Delivered,
        Signed,
        Completed,
        Declined,
        Voided,
        Deleted
    }

    public enum folderIdsInput
    {
        [EnumMember(Value = "Awaiting my signature")]
        AwaitingMySignature,
        Completed,
        Draft,
        Drafts,
        [EnumMember(Value = "Expiring soon")]
        ExpiringSoon,
        Inbox,
        [EnumMember(Value = "Out for signature")]
        OutForSignature,
        [EnumMember(Value = "Recycle bin")]
        RecycleBin,
        [EnumMember(Value = "Sent items")]
        SentItems,
        [EnumMember(Value = "Waiting for others")]
        WaitingForOthers
    }

    public enum orderByInput
    {
        [EnumMember(Value = "Action required")]
        ActionRequired,
        Created,
        Completed,
        [EnumMember(Value = "Envelope name")]
        EnvelopeName,
        Expire,
        [EnumMember(Value = "Last modified")]
        LastModified,
        Sent,
        [EnumMember(Value = "Signer list")]
        SignerList,
        Status,
        Subject,
        [EnumMember(Value = "User name")]
        UserName,
        [EnumMember(Value = "Status changed")]
        StatusChanged
    }

    public class CreateEnvelopeResponse
    {
        [JsonProperty("envelopeId")]
        public string EnvelopeId { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusDateTime")]
        public string StatusDateTime { get; set; }

        [JsonProperty("uri")]
        public string URI { get; set; }
    }

    public class EnvelopeCustomFieldResponse
    {
        [JsonProperty("fieldId")]
        public string FieldID { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateEnvelopeCustomFieldResponse
    {
        [JsonProperty("fieldId")]
        public string FieldID { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EmbeddedSenderResponse
    {
        [JsonProperty("url")]
        public string EmbeddedSenderURL { get; set; }
    }

    public enum openInInput
    {
        Prepare,
        Tagging
    }

    public enum returnUrlInput
    {
        [EnumMember(Value = "Default URL (Not compatible with iframes)")]
        DefaultURLNotCompatibleWithIframes,
        [EnumMember(Value = "Add a different URL")]
        AddADifferentURL
    }

    public class ListRecipientsResponse
    {
        [JsonProperty("envelopeId")]
        public string EnvelopeID { get; set; }

        [JsonProperty("signers")]
        public Signer[] Signers { get; set; }
    }

    public class Signer
    {
        [JsonProperty("routingOrder")]
        public string SigningOrder { get; set; }

        [JsonProperty("roleName")]
        public string Role { get; set; }

        [JsonProperty("recipientId")]
        public string RecipientID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("recipientType")]
        public string RecipientType { get; set; }

        [JsonProperty("verificationType")]
        public string VerificationType { get; set; }

        [JsonProperty("recipientIdGuid")]
        public string RecipientGUID { get; set; }
    }

    public enum verificationTypeInput
    {
        None,
        [EnumMember(Value = "Access Code")]
        AccessCode,
        [EnumMember(Value = "ID Verification")]
        IdVerification,
        [EnumMember(Value = "Phone Authentication")]
        PhoneAuthentication,
        [EnumMember(Value = "Knowledge Based")]
        KnowledgeBased
    }

    public enum emailNotificationLanguageInput
    {
        [EnumMember(Value = "Arabic (ar)")]
        ArabicAr,
        [EnumMember(Value = "Bulgarian (bg)")]
        BulgarianBg,
        [EnumMember(Value = "Czech (cs)")]
        CzechCs,
        [EnumMember(Value = "Chinese Simplified (zh_CN)")]
        ChineseSimplifiedZhCN,
        [EnumMember(Value = "Chinese Traditional (zh_TW)")]
        ChineseTraditionalZhTW,
        [EnumMember(Value = "Croatian (hr)")]
        CroatianHr,
        [EnumMember(Value = "Danish (da)")]
        DanishDa,
        [EnumMember(Value = "Dutch (nl)")]
        DutchNl,
        [EnumMember(Value = "English US (en)")]
        EnglishUSEn,
        [EnumMember(Value = "English UK (en_GB)")]
        EnglishUKEnGB,
        [EnumMember(Value = "Estonian (et)")]
        EstonianEt,
        [EnumMember(Value = "Farsi (fa)")]
        FarsiFa,
        [EnumMember(Value = "Finnish (fi)")]
        FinnishFi,
        [EnumMember(Value = "French (fr)")]
        FrenchFr,
        [EnumMember(Value = "French Canada (fr_CA)")]
        FrenchCanadaFrCA,
        [EnumMember(Value = "German (de)")]
        GermanDe,
        [EnumMember(Value = "Greek (el)")]
        GreekEl,
        [EnumMember(Value = "Hebrew (he)")]
        HebrewHe,
        [EnumMember(Value = "Hindi (hi)")]
        HindiHi,
        [EnumMember(Value = "Hungarian (hu)")]
        HungarianHu,
        [EnumMember(Value = "Bahasa Indonesia (id)")]
        BahasaIndonesiaId,
        [EnumMember(Value = "Italian (it)")]
        ItalianIt,
        [EnumMember(Value = "Japanese (ja)")]
        JapaneseJa,
        [EnumMember(Value = "Korean (ko)")]
        KoreanKo,
        [EnumMember(Value = "Latvian (lv)")]
        LatvianLv,
        [EnumMember(Value = "Lithuanian (lt)")]
        LithuanianLt,
        [EnumMember(Value = "Bahasa Malay (ms)")]
        BahasaMalayMs,
        [EnumMember(Value = "Norwegian (no)")]
        NorwegianNo,
        [EnumMember(Value = "Polish (pl)")]
        PolishPl,
        [EnumMember(Value = "Portuguese (pt)")]
        PortuguesePt,
        [EnumMember(Value = "Portuguese Brasil (pt_BR)")]
        PortugueseBrasilPtBR,
        [EnumMember(Value = "Romanian (ro)")]
        RomanianRo,
        [EnumMember(Value = "Russian (ru)")]
        RussianRu,
        [EnumMember(Value = "Serbian (sr)")]
        SerbianSr,
        [EnumMember(Value = "Slovak (sk)")]
        SlovakSk,
        [EnumMember(Value = "Slovenian (sl)")]
        SlovenianSl,
        [EnumMember(Value = "Spanish (es)")]
        SpanishEs,
        [EnumMember(Value = "Spanish Latin America (es_MX)")]
        SpanishLatinAmericaEsMX,
        [EnumMember(Value = "Swedish (sv)")]
        SwedishSv,
        [EnumMember(Value = "Thai (th)")]
        ThaiTh,
        [EnumMember(Value = "Turkish (tr)")]
        TurkishTr,
        [EnumMember(Value = "Ukranian (uk)")]
        UkranianUk,
        [EnumMember(Value = "Vietnamese (vi)")]
        VietnameseVi,
        [EnumMember(Value = "Armenian (hy)")]
        ArmenianHy
    }

    public enum preserveTemplateRecipientInput
    {
        False,
        True
    }

    public class bodydocumentTemplatesInputItem
    {
        [JsonProperty("documentId")]
        public string DocumentID { get; set; }

        [JsonProperty("documentStartPage")]
        public string DocumentStartPage { get; set; }

        [JsonProperty("documentEndPage")]
        public string DocumentEndPage { get; set; }
    }

    public class BulkSendListGuidInfo
    {
        [JsonProperty("listId")]
        public string BulkSendListGuid { get; set; }
    }

    public class GetLoginAccountsResponse
    {
        [JsonProperty("loginAccounts")]
        public LoginAccount[] LoginAccounts { get; set; }
    }

    public class LoginAccount
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("accountIdGuid")]
        public string AccountIdGuid { get; set; }
    }

    public class ListTemplatesResponse
    {
        [JsonProperty("envelopeTemplates")]
        public EnvelopeTemplate[] EnvelopeTemplates { get; set; }
    }

    public class EnvelopeTemplate
    {
        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AddDocumentsResponse
    {
        [JsonProperty("envelopeId")]
        public string EnvelopeId { get; set; }

        [JsonProperty("envelopeDocuments")]
        public EnvelopeDocument[] EnvelopeDocuments { get; set; }
    }

    public class EnvelopeDocument
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("documentIdGuid")]
        public string DocumentGuid { get; set; }

        [JsonProperty("errorDetails")]
        public EnvelopeDocumentErrorDetailsType ErrorDetails { get; set; }
    }

    public class EnvelopeDocumentErrorDetailsType
    {
        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class bodyunnamedInputItem
    {
        [JsonProperty("documentBase64")]
        public string DocumentBase64 { get; set; }

        [JsonProperty("fileExtension")]
        public string DocumentType { get; set; }

        [JsonProperty("name")]
        public string DocumentName { get; set; }

        [JsonProperty("transformPdfFields")]
        public bodyunnamedInputItemTransformPdfFieldsType TransformPdfFields { get; set; }

        [JsonProperty("assignTabsToRecipientId")]
        public string AssignTabsToRecipient { get; set; }
    }

    public enum bodyunnamedInputItemTransformPdfFieldsType
    {
        False,
        True
    }

    public class ListTemplateDocumentsResponse
    {
        [JsonProperty("templateDocuments")]
        public EnvelopeDocument[] TemplateDocuments { get; set; }
    }

    public class ListDocumentsResponse
    {
        [JsonProperty("envelopeDocuments")]
        public EnvelopeDocument[] EnvelopeDocuments { get; set; }
    }

    public class AddRecipientTabsResponse
    {
        [JsonProperty("recipientTabs")]
        public RecipientTab[] RecipientTabs { get; set; }
    }

    public class RecipientTab
    {
        [JsonProperty("tabId")]
        public string TabId { get; set; }

        [JsonProperty("tabType")]
        public string TabType { get; set; }
    }

    public class bodyInputItem22
    {
        [JsonProperty("tabType")]
        public bodyInputItemTypeType Type { get; set; }

        [JsonProperty("tabId")]
        public string ID { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RecipientTabsResponse
    {
        [JsonProperty("recipientTabs")]
        public Tab[] RecipientTab { get; set; }
    }

    public class EmbeddedSigningResponse
    {
        [JsonProperty("url")]
        public string URL { get; set; }
    }

    public enum isInPersonSignerInput
    {
        Yes,
        No
    }

    public enum authenticationMethodInput
    {
        Biometric,
        Email,
        HTTPBasicAuth,
        Kerberos,
        KnowledgeBasedAuth,
        None,
        PaperDocuments,
        Password,
        [EnumMember(Value = "RSASecureID")]
        RSASecureId,
        [EnumMember(Value = "SingleSignOn_CASiteminder")]
        SingleSignOnCASiteminder,
        [EnumMember(Value = "SingleSignOn_InfoCard")]
        SingleSignOnInfoCard,
        [EnumMember(Value = "SingleSignOn_MicrosoftActiveDirectory")]
        SingleSignOnMicrosoftActiveDirectory,
        [EnumMember(Value = "SingleSignOn_Other")]
        SingleSignOnOther,
        [EnumMember(Value = "SingleSignOn_Passport")]
        SingleSignOnPassport,
        [EnumMember(Value = "SingleSignOn_SAML")]
        SingleSignOnSAML,
        Smartcard,
        SSLMutualAuth,
        X509Certificate
    }

    public enum documentIdInput
    {
        [EnumMember(Value = "Archive : Get ZIP archive with documents and COC")]
        ArchiveGetZIPArchiveWithDocumentsAndCOC,
        [EnumMember(Value = "Certificate : Get only certificate of completion as pdf")]
        CertificateGetOnlyCertificateOfCompletionAsPdf,
        [EnumMember(Value = "Combined with COC : Get all documents as single pdf")]
        CombinedWithCOCGetAllDocumentsAsSinglePdf,
        [EnumMember(Value = "Combined without COC : Get all documents as single pdf")]
        CombinedWithoutCOCGetAllDocumentsAsSinglePdf,
        [EnumMember(Value = "Portfolio : Get envelope documents as a PDF Portfolio")]
        PortfolioGetEnvelopeDocumentsAsAPDFPortfolio
    }

    public enum languageInput
    {
        [EnumMember(Value = "Chinese Simplified")]
        ChineseSimplified,
        [EnumMember(Value = "Chinese Traditional")]
        ChineseTraditional,
        Dutch,
        [EnumMember(Value = "English (default)")]
        EnglishDefault,
        French,
        German,
        Italian,
        Japanese,
        Korean,
        Portuguese,
        [EnumMember(Value = "Portuguese (Brazil)")]
        PortugueseBrazil,
        Russian,
        Spanish
    }

    public enum bodytriggerEventsInputItem
    {
        [EnumMember(Value = "envelope-completed")]
        EnvelopeCompleted,
        [EnumMember(Value = "envelope-corrected")]
        EnvelopeCorrected,
        [EnumMember(Value = "envelope-created")]
        EnvelopeCreated,
        [EnumMember(Value = "envelope-declined")]
        EnvelopeDeclined,
        [EnumMember(Value = "envelope-deleted")]
        EnvelopeDeleted,
        [EnumMember(Value = "envelope-delivered")]
        EnvelopeDelivered,
        [EnumMember(Value = "envelope-discard")]
        EnvelopeDiscard,
        [EnumMember(Value = "envelope-purge")]
        EnvelopePurge,
        [EnumMember(Value = "envelope-removed")]
        EnvelopeRemoved,
        [EnumMember(Value = "envelope-reminder-sent")]
        EnvelopeReminderSent,
        [EnumMember(Value = "envelope-resent")]
        EnvelopeResent,
        [EnumMember(Value = "envelope-voided")]
        EnvelopeVoided,
        [EnumMember(Value = "envelope-sent")]
        EnvelopeSent,
        [EnumMember(Value = "recipient-authenticationfailed")]
        RecipientAuthenticationfailed,
        [EnumMember(Value = "recipient-autoresponded")]
        RecipientAutoresponded,
        [EnumMember(Value = "recipient-completed")]
        RecipientCompleted,
        [EnumMember(Value = "recipient-declined")]
        RecipientDeclined,
        [EnumMember(Value = "recipient-delegate")]
        RecipientDelegate,
        [EnumMember(Value = "recipient-delivered")]
        RecipientDelivered,
        [EnumMember(Value = "recipient-finish-later")]
        RecipientFinishLater,
        [EnumMember(Value = "recipient-reassign")]
        RecipientReassign,
        [EnumMember(Value = "recipient-resent")]
        RecipientResent,
        [EnumMember(Value = "recipient-sent")]
        RecipientSent,
        [EnumMember(Value = "template-created")]
        TemplateCreated,
        [EnumMember(Value = "template-deleted")]
        TemplateDeleted,
        [EnumMember(Value = "template-modified")]
        TemplateModified,
        [EnumMember(Value = "click-agreed")]
        ClickAgreed,
        [EnumMember(Value = "click-declined")]
        ClickDeclined,
        [EnumMember(Value = "sms-opt-in")]
        SmsOptIn,
        [EnumMember(Value = "sms-opt-out")]
        SmsOptOut,
        [EnumMember(Value = "workflow-started")]
        WorkflowStarted,
        [EnumMember(Value = "workflow-failed")]
        WorkflowFailed,
        [EnumMember(Value = "workflow-completed")]
        WorkflowCompleted,
        [EnumMember(Value = "identity-verification-completed")]
        IdentityVerificationCompleted,
        [EnumMember(Value = "identity-verification-pending")]
        IdentityVerificationPending,
        [EnumMember(Value = "extension-executed")]
        ExtensionExecuted,
        [EnumMember(Value = "notary-session-signer-locked")]
        NotarySessionSignerLocked,
        [EnumMember(Value = "notary-session-signer-unlocked")]
        NotarySessionSignerUnlocked,
        [EnumMember(Value = "notary-session-terminated")]
        NotarySessionTerminated,
        [EnumMember(Value = "notary-session-paused")]
        NotarySessionPaused,
        [EnumMember(Value = "notary-session-status-updated")]
        NotarySessionStatusUpdated,
        [EnumMember(Value = "notary-session-notary-assigned")]
        NotarySessionNotaryAssigned,
        [EnumMember(Value = "notary-session-notary-removed")]
        NotarySessionNotaryRemoved,
        [EnumMember(Value = "agreement-created")]
        AgreementCreated,
        [EnumMember(Value = "agreement-updated")]
        AgreementUpdated,
        [EnumMember(Value = "agreement-deleted")]
        AgreementDeleted,
        [EnumMember(Value = "agreement-reviews-completed")]
        AgreementReviewsCompleted,
        [EnumMember(Value = "agreement-extractions-reviewed")]
        AgreementExtractionsReviewed
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Docusign;

    public partial class WorkflowManagedActions
    {
        public DocusignActions Docusign(string connectionId) => new DocusignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DocusignTriggers Docusign(string connectionId) => new DocusignTriggers(connectionId);
    }
}