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
        public IBodyWorkflowAction<DocGenFormFieldsResponse> GetDocgenFormFields(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/docGenFormFields", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DocGenFormFieldsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IWorkflowAction UpdateDocgenFormFields(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> documentGuid, Expression<Func<bodyInputItem[]>> body = null)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/docGenFormFields", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["documentGuid"] = ExpressionConverter.Convert(documentGuid);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<string> GetDocuments(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<bool>> certificate)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/documents/{2}", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["certificate"] = ExpressionConverter.Convert(certificate);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<string> GetDocumentsV2(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<documentIdInput>> documentId)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/documents/{2}/documentsDownload", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<JToken> VoidEnvelope(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> voidedReason)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/voidEnvelope", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["voidedReason"] = ExpressionConverter.Convert(voidedReason);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<JToken> ResendEnvelope(Expression<Func<string>> envelopeId)
        {
            var apiCallPath = String.Format("/accounts/copilotAccount/envelopes/{0}/resendEnvelope", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<AddRemindersResponse> AddReminders(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<bool>> reminderEnabled, Expression<Func<string>> reminderDelay, Expression<Func<string>> reminderFrequency, Expression<Func<string>> expireAfter = null)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/notification", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["reminderEnabled"] = ExpressionConverter.Convert(reminderEnabled);
            callPayload.Queries["reminderDelay"] = ExpressionConverter.Convert(reminderDelay);
            callPayload.Queries["reminderFrequency"] = ExpressionConverter.Convert(reminderFrequency);
            if (expireAfter != null)
                callPayload.Queries["expireAfter"] = ExpressionConverter.Convert(expireAfter);
            return new ApiConnectionAction<AddRemindersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<ListTabsResponse> GetEnvelopeDocumentTabs(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/documents/{2}/tabs", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListTabsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IWorkflowAction UpdateEnvelopePrefillTabs(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<bodyInputItem2[]>> body = null)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/documents/{2}/tabs", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<ListTabsResponse> GetTemplateDocumentTabs(Expression<Func<string>> accountId, Expression<Func<string>> templateId, Expression<Func<string>> documentId)
        {
            var apiCallPath = String.Format("/accounts/{0}/templates/{1}/documents/{2}/tabs", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(templateId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListTabsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<ListEnvelopeDocumentFieldsResponse> GetEnvelopeDocumentFields(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/documents/{2}/fields", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListEnvelopeDocumentFieldsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<CreateEnvelopeResponse> CreateBlankEnvelope(Expression<Func<string>> accountId, Expression<Func<string>> emailSubject, Expression<Func<string>> emailBody = null, Expression<Func<object>> accountCustomFields = null)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/createBlankEnvelope", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["emailSubject"] = ExpressionConverter.Convert(emailSubject);
            if (emailBody != null)
                callPayload.Queries["emailBody"] = ExpressionConverter.Convert(emailBody);
            callPayload.Body = ExpressionConverter.ConvertO(accountCustomFields);
            return new ApiConnectionAction<CreateEnvelopeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<CompositeTemplatesResponse> CompositeTemplates(Expression<Func<string>> accountId, Expression<Func<string>> emailSubject, Expression<Func<statusInput>> status, Expression<Func<string>> emailBody = null, Expression<Func<object>> body = null)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/compositeTemplates", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["emailSubject"] = ExpressionConverter.Convert(emailSubject);
            if (emailBody != null)
                callPayload.Queries["emailBody"] = ExpressionConverter.Convert(emailBody);
            callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<CompositeTemplatesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<FilteredEnvelopeListResponse> ListEnvelopes(Expression<Func<string>> recipientName = null, Expression<Func<string>> recipientEmailId = null, Expression<Func<string>> envelopeTitle = null, Expression<Func<string>> customFieldName = null, Expression<Func<string>> customFieldValue = null, Expression<Func<envelopeStatusInput>> envelopeStatus = null, Expression<Func<folderIdsInput>> folderIds = null, Expression<Func<orderByInput>> orderBy = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> fromDate = null, Expression<Func<string>> toDate = null)
        {
            var apiCallPath = "/accounts/copilotAccount/envelopes/listEnvelopes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (recipientName != null)
                callPayload.Queries["recipientName"] = ExpressionConverter.Convert(recipientName);
            if (recipientEmailId != null)
                callPayload.Queries["recipientEmailId"] = ExpressionConverter.Convert(recipientEmailId);
            if (envelopeTitle != null)
                callPayload.Queries["envelopeTitle"] = ExpressionConverter.Convert(envelopeTitle);
            if (customFieldName != null)
                callPayload.Queries["customFieldName"] = ExpressionConverter.Convert(customFieldName);
            if (customFieldValue != null)
                callPayload.Queries["customFieldValue"] = ExpressionConverter.Convert(customFieldValue);
            callPayload.Queries["envelopeStatus"] = Convert.ToString("any");
            if (envelopeStatus != null)
                callPayload.Queries["envelopeStatus"] = ExpressionConverter.Convert(envelopeStatus);
            if (folderIds != null)
                callPayload.Queries["folder_ids"] = ExpressionConverter.Convert(folderIds);
            callPayload.Queries["order_by"] = Convert.ToString("status_changed");
            if (orderBy != null)
                callPayload.Queries["order_by"] = ExpressionConverter.Convert(orderBy);
            if (top != null)
                callPayload.Queries["top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["from_date"] = Convert.ToString("2000-01-02T12:45Z");
            if (fromDate != null)
                callPayload.Queries["from_date"] = ExpressionConverter.Convert(fromDate);
            if (toDate != null)
                callPayload.Queries["to_date"] = ExpressionConverter.Convert(toDate);
            return new ApiConnectionAction<FilteredEnvelopeListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<FilteredEnvelopeListResponse> SearchListEnvelopes(Expression<Func<string>> accountId, Expression<Func<string>> recipientName = null, Expression<Func<string>> recipientEmailId = null, Expression<Func<string>> envelopeTitle = null, Expression<Func<string>> customFieldName = null, Expression<Func<string>> customFieldValue = null, Expression<Func<envelopeStatusInput>> envelopeStatus = null, Expression<Func<folderIdsInput>> folderIds = null, Expression<Func<orderByInput>> orderBy = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> fromDate = null, Expression<Func<string>> toDate = null)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/SearchListEnvelopes", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (recipientName != null)
                callPayload.Queries["recipientName"] = ExpressionConverter.Convert(recipientName);
            if (recipientEmailId != null)
                callPayload.Queries["recipientEmailId"] = ExpressionConverter.Convert(recipientEmailId);
            if (envelopeTitle != null)
                callPayload.Queries["envelopeTitle"] = ExpressionConverter.Convert(envelopeTitle);
            if (customFieldName != null)
                callPayload.Queries["customFieldName"] = ExpressionConverter.Convert(customFieldName);
            if (customFieldValue != null)
                callPayload.Queries["customFieldValue"] = ExpressionConverter.Convert(customFieldValue);
            callPayload.Queries["envelopeStatus"] = Convert.ToString("Any");
            if (envelopeStatus != null)
                callPayload.Queries["envelopeStatus"] = ExpressionConverter.Convert(envelopeStatus);
            if (folderIds != null)
                callPayload.Queries["folder_ids"] = ExpressionConverter.Convert(folderIds);
            callPayload.Queries["order_by"] = Convert.ToString("Status changed");
            if (orderBy != null)
                callPayload.Queries["order_by"] = ExpressionConverter.Convert(orderBy);
            if (top != null)
                callPayload.Queries["top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["skip"] = ExpressionConverter.Convert(skip);
            callPayload.Queries["from_date"] = Convert.ToString("2024-01-02T12:45Z");
            if (fromDate != null)
                callPayload.Queries["from_date"] = ExpressionConverter.Convert(fromDate);
            if (toDate != null)
                callPayload.Queries["to_date"] = ExpressionConverter.Convert(toDate);
            return new ApiConnectionAction<FilteredEnvelopeListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<FilteredSalesCopilotEnvelopeListResponse> SalesCopilotListEnvelopes(Expression<Func<string>> recipientName = null, Expression<Func<string>> recipientEmailId = null, Expression<Func<string>> envelopeTitle = null, Expression<Func<string>> customFieldName = null, Expression<Func<string>> customFieldValue = null, Expression<Func<envelopeStatusInput>> envelopeStatus = null, Expression<Func<folderIdsInput>> folderIds = null, Expression<Func<orderByInput>> orderBy = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> startDateTime = null, Expression<Func<string>> endDateTime = null)
        {
            var apiCallPath = "/accounts/copilotAccount/envelopes/listEnvelopesForSalesCopilot";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (recipientName != null)
                callPayload.Queries["recipientName"] = ExpressionConverter.Convert(recipientName);
            if (recipientEmailId != null)
                callPayload.Queries["recipientEmailId"] = ExpressionConverter.Convert(recipientEmailId);
            if (envelopeTitle != null)
                callPayload.Queries["envelopeTitle"] = ExpressionConverter.Convert(envelopeTitle);
            if (customFieldName != null)
                callPayload.Queries["customFieldName"] = ExpressionConverter.Convert(customFieldName);
            if (customFieldValue != null)
                callPayload.Queries["customFieldValue"] = ExpressionConverter.Convert(customFieldValue);
            callPayload.Queries["envelopeStatus"] = Convert.ToString("any");
            if (envelopeStatus != null)
                callPayload.Queries["envelopeStatus"] = ExpressionConverter.Convert(envelopeStatus);
            if (folderIds != null)
                callPayload.Queries["folder_ids"] = ExpressionConverter.Convert(folderIds);
            callPayload.Queries["order_by"] = Convert.ToString("status_changed");
            if (orderBy != null)
                callPayload.Queries["order_by"] = ExpressionConverter.Convert(orderBy);
            if (top != null)
                callPayload.Queries["top"] = ExpressionConverter.Convert(top);
            if (skip != null)
                callPayload.Queries["skip"] = ExpressionConverter.Convert(skip);
            if (startDateTime != null)
                callPayload.Queries["startDateTime"] = ExpressionConverter.Convert(startDateTime);
            if (endDateTime != null)
                callPayload.Queries["endDateTime"] = ExpressionConverter.Convert(endDateTime);
            return new ApiConnectionAction<FilteredSalesCopilotEnvelopeListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<CreateEnvelopeResponse> CreateEnvelopeFromTemplate(Expression<Func<string>> accountId, Expression<Func<string>> templateId, Expression<Func<statusInput>> status, Expression<Func<object>> accountCustomFields = null)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/createFromTemplate", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["templateId"] = ExpressionConverter.Convert(templateId);
            callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            callPayload.Body = ExpressionConverter.ConvertO(accountCustomFields);
            return new ApiConnectionAction<CreateEnvelopeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<CreateEnvelopeResponse> CreateEnvelopeFromTemplateNoRecipients(Expression<Func<string>> accountId, Expression<Func<string>> templateId, Expression<Func<statusInput>> status)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/createFromTemplateNoRecipients", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["templateId"] = ExpressionConverter.Convert(templateId);
            callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            return new ApiConnectionAction<CreateEnvelopeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<CreateEnvelopeResponse> SendEnvelope(Expression<Func<string>> accountId, Expression<Func<statusInput>> status, Expression<Func<string>> templateId, Expression<Func<object>> signers = null, Expression<Func<string>> emailSubject = null, Expression<Func<string>> emailBody = null)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            callPayload.Queries["templateId"] = ExpressionConverter.Convert(templateId);
            if (emailSubject != null)
                callPayload.Queries["emailSubject"] = ExpressionConverter.Convert(emailSubject);
            if (emailBody != null)
                callPayload.Queries["emailBody"] = ExpressionConverter.Convert(emailBody);
            callPayload.Body = ExpressionConverter.ConvertO(signers);
            return new ApiConnectionAction<CreateEnvelopeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<CreateEnvelopeResponse> SendEnvelopeWithRecipientFields(Expression<Func<string>> accountId, Expression<Func<string>> templateId, Expression<Func<object>> recipients = null, Expression<Func<string>> emailSubject = null)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/createWithRecipientFields", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["templateId"] = ExpressionConverter.Convert(templateId);
            if (emailSubject != null)
                callPayload.Queries["emailSubject"] = ExpressionConverter.Convert(emailSubject);
            callPayload.Body = ExpressionConverter.ConvertO(recipients);
            return new ApiConnectionAction<CreateEnvelopeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<JToken> SendDraftEnvelope(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<EnvelopeCustomFieldResponse> GetEnvelopeCustomField(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> fieldName)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/custom_fields", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["fieldName"] = ExpressionConverter.Convert(fieldName);
            return new ApiConnectionAction<EnvelopeCustomFieldResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<UpdateEnvelopeCustomFieldResponse> UpdateEnvelopeCustomField(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> fieldId, Expression<Func<string>> fieldType, Expression<Func<string>> name, Expression<Func<string>> value)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/custom_fields", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["fieldId"] = ExpressionConverter.Convert(fieldId);
            callPayload.Queries["fieldType"] = ExpressionConverter.Convert(fieldType);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            callPayload.Queries["value"] = ExpressionConverter.Convert(value);
            return new ApiConnectionAction<UpdateEnvelopeCustomFieldResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<EmbeddedSenderResponse> GenerateEmbeddedSenderURL(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<openInInput>> openIn, Expression<Func<returnUrlInput>> returnUrl, Expression<Func<object>> additionalURL = null)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/views/sender", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["openIn"] = ExpressionConverter.Convert(openIn);
            callPayload.Queries["returnUrl"] = ExpressionConverter.Convert(returnUrl);
            callPayload.Body = ExpressionConverter.ConvertO(additionalURL);
            return new ApiConnectionAction<EmbeddedSenderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<EmbeddedSigningResponse> GenerateEmbeddedSigningURLV2(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<isInPersonSignerInput>> isInPersonSigner, Expression<Func<authenticationMethodInput>> authenticationMethod, Expression<Func<returnUrlInput>> returnUrl, Expression<Func<object>> additionalURL = null)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/views/recipientV2", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["isInPersonSigner"] = ExpressionConverter.Convert(isInPersonSigner);
            callPayload.Queries["authenticationMethod"] = ExpressionConverter.Convert(authenticationMethod);
            callPayload.Queries["returnUrl"] = ExpressionConverter.Convert(returnUrl);
            callPayload.Body = ExpressionConverter.ConvertO(additionalURL);
            return new ApiConnectionAction<EmbeddedSigningResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<ListRecipientsResponse> AddRecipientToEnvelope(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> addRecipientToEnvelopeName, Expression<Func<string>> addRecipientToEnvelopeEmail, Expression<Func<SignerRequest[]>> newRecipientsigner = null)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/recipients", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["AddRecipientToEnvelopeName"] = ExpressionConverter.Convert(addRecipientToEnvelopeName);
            callPayload.Queries["AddRecipientToEnvelopeEmail"] = ExpressionConverter.Convert(addRecipientToEnvelopeEmail);
            var newRecipient = new JObject();
            var newRecipientpropCount = 0;
            if (newRecipientsigner != null)
            {
                newRecipient["signers"] = ExpressionConverter.ConvertO(newRecipientsigner);
                newRecipientpropCount++;
            }

            if (newRecipientpropCount > 0)
            {
                callPayload.Body = newRecipient;
            }

            return new ApiConnectionAction<ListRecipientsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<ListRecipientsResponse> GetRecipientStatus(Expression<Func<string>> accountId, Expression<Func<string>> folderId, Expression<Func<string>> envelopeId)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/recipients", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
            return new ApiConnectionAction<ListRecipientsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<ListRecipientsResponse> RemoveRecipientFromEnvelope(Expression<Func<string>> accountId, Expression<Func<string>> folderId, Expression<Func<string>> envelopeId, Expression<Func<string>> removeRecipientFromEnvelopeRecipientId)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/recipients", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
            callPayload.Queries["RemoveRecipientFromEnvelopeRecipientId"] = ExpressionConverter.Convert(removeRecipientFromEnvelopeRecipientId);
            return new ApiConnectionAction<ListRecipientsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<Signer> GetRecipientFields(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> recipientEmail = null, Expression<Func<string>> areaCode = null, Expression<Func<string>> phoneNumber = null, Expression<Func<string>> recipientId = null)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/recipientFields", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (recipientEmail != null)
                callPayload.Queries["recipientEmail"] = ExpressionConverter.Convert(recipientEmail);
            if (areaCode != null)
                callPayload.Queries["areaCode"] = ExpressionConverter.Convert(areaCode);
            if (phoneNumber != null)
                callPayload.Queries["phoneNumber"] = ExpressionConverter.Convert(phoneNumber);
            if (recipientId != null)
                callPayload.Queries["recipientId"] = ExpressionConverter.Convert(recipientId);
            return new ApiConnectionAction<Signer>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<JToken> GetAuditEvents(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/audit_events", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<Signer> AddRecipientToEnvelopeV2(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> recipientType, Expression<Func<string>> clientUserId = null, Expression<Func<string>> embeddedRecipientStartURL = null, Expression<Func<string>> routingOrder = null, Expression<Func<emailNotificationLanguageInput>> emailNotificationLanguage = null, Expression<Func<string>> emailNotificationSubject = null, Expression<Func<string>> emailNotificationBody = null, Expression<Func<string>> note = null, Expression<Func<string>> roleName = null, Expression<Func<int>> countryCode = null, Expression<Func<int>> phoneNumber = null, Expression<Func<string>> signingGroupId = null, Expression<Func<string>> signatureType = null, Expression<Func<string>> workflowId = null, Expression<Func<object>> additionalRecipientParams = null)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/recipients/addRecipientV2", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["recipientType"] = ExpressionConverter.Convert(recipientType);
            if (clientUserId != null)
                callPayload.Queries["clientUserId"] = ExpressionConverter.Convert(clientUserId);
            if (embeddedRecipientStartURL != null)
                callPayload.Queries["embeddedRecipientStartURL"] = ExpressionConverter.Convert(embeddedRecipientStartURL);
            if (routingOrder != null)
                callPayload.Queries["routingOrder"] = ExpressionConverter.Convert(routingOrder);
            if (emailNotificationLanguage != null)
                callPayload.Queries["emailNotificationLanguage"] = ExpressionConverter.Convert(emailNotificationLanguage);
            if (emailNotificationSubject != null)
                callPayload.Queries["emailNotificationSubject"] = ExpressionConverter.Convert(emailNotificationSubject);
            if (emailNotificationBody != null)
                callPayload.Queries["emailNotificationBody"] = ExpressionConverter.Convert(emailNotificationBody);
            if (note != null)
                callPayload.Queries["note"] = ExpressionConverter.Convert(note);
            if (roleName != null)
                callPayload.Queries["roleName"] = ExpressionConverter.Convert(roleName);
            if (countryCode != null)
                callPayload.Queries["countryCode"] = ExpressionConverter.Convert(countryCode);
            if (phoneNumber != null)
                callPayload.Queries["phoneNumber"] = ExpressionConverter.Convert(phoneNumber);
            if (signingGroupId != null)
                callPayload.Queries["signingGroupId"] = ExpressionConverter.Convert(signingGroupId);
            if (signatureType != null)
                callPayload.Queries["signatureType"] = ExpressionConverter.Convert(signatureType);
            if (workflowId != null)
                callPayload.Queries["workflowId"] = ExpressionConverter.Convert(workflowId);
            callPayload.Body = ExpressionConverter.ConvertO(additionalRecipientParams);
            return new ApiConnectionAction<Signer>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IWorkflowAction AddVerificationToRecipient(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> recipientId, Expression<Func<string>> recipientType, Expression<Func<verificationTypeInput>> verificationType, Expression<Func<object>> additionalRecipientData = null)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/recipients/addRecipientV2", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["recipientId"] = ExpressionConverter.Convert(recipientId);
            callPayload.Queries["recipientType"] = ExpressionConverter.Convert(recipientType);
            callPayload.Queries["verificationType"] = ExpressionConverter.Convert(verificationType);
            callPayload.Body = ExpressionConverter.ConvertO(additionalRecipientData);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<Signer> UpdateEnvelopeRecipient(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> recipientId, Expression<Func<string>> recipientType, Expression<Func<string>> signatureType = null, Expression<Func<string>> clientUserId = null, Expression<Func<string>> embeddedRecipientStartURL = null, Expression<Func<string>> routingOrder = null, Expression<Func<emailNotificationLanguageInput>> emailNotificationLanguage = null, Expression<Func<string>> emailNotificationSubject = null, Expression<Func<string>> emailNotificationBody = null, Expression<Func<string>> note = null, Expression<Func<string>> roleName = null, Expression<Func<int>> countryCode = null, Expression<Func<int>> phoneNumber = null, Expression<Func<string>> signingGroupId = null, Expression<Func<object>> additionalRecipientParams = null)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/recipients/updateRecipient", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["recipientId"] = ExpressionConverter.Convert(recipientId);
            if (signatureType != null)
                callPayload.Queries["signatureType"] = ExpressionConverter.Convert(signatureType);
            callPayload.Queries["recipientType"] = ExpressionConverter.Convert(recipientType);
            if (clientUserId != null)
                callPayload.Queries["clientUserId"] = ExpressionConverter.Convert(clientUserId);
            if (embeddedRecipientStartURL != null)
                callPayload.Queries["embeddedRecipientStartURL"] = ExpressionConverter.Convert(embeddedRecipientStartURL);
            if (routingOrder != null)
                callPayload.Queries["routingOrder"] = ExpressionConverter.Convert(routingOrder);
            if (emailNotificationLanguage != null)
                callPayload.Queries["emailNotificationLanguage"] = ExpressionConverter.Convert(emailNotificationLanguage);
            if (emailNotificationSubject != null)
                callPayload.Queries["emailNotificationSubject"] = ExpressionConverter.Convert(emailNotificationSubject);
            if (emailNotificationBody != null)
                callPayload.Queries["emailNotificationBody"] = ExpressionConverter.Convert(emailNotificationBody);
            if (note != null)
                callPayload.Queries["note"] = ExpressionConverter.Convert(note);
            if (roleName != null)
                callPayload.Queries["roleName"] = ExpressionConverter.Convert(roleName);
            if (countryCode != null)
                callPayload.Queries["countryCode"] = ExpressionConverter.Convert(countryCode);
            if (phoneNumber != null)
                callPayload.Queries["phoneNumber"] = ExpressionConverter.Convert(phoneNumber);
            if (signingGroupId != null)
                callPayload.Queries["signingGroupId"] = ExpressionConverter.Convert(signingGroupId);
            callPayload.Body = ExpressionConverter.ConvertO(additionalRecipientParams);
            return new ApiConnectionAction<Signer>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IWorkflowAction ApplyTemplatesToDocuments(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> templateId, Expression<Func<preserveTemplateRecipientInput>> preserveTemplateRecipient = null, Expression<Func<bodydocumentTemplatesInputItem[]>> bodydocumentTemplates = null)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/templates", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["templateId"] = ExpressionConverter.Convert(templateId);
            callPayload.Queries["preserve_template_recipient"] = Convert.ToString("False");
            if (preserveTemplateRecipient != null)
                callPayload.Queries["preserve_template_recipient"] = ExpressionConverter.Convert(preserveTemplateRecipient);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydocumentTemplates != null)
            {
                body["documentTemplates"] = ExpressionConverter.ConvertO(bodydocumentTemplates);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<BulkSendListGuidInfo> CreateBulkSendList(Expression<Func<string>> accountId, Expression<Func<string>> name, Expression<Func<string>> csvcSVFile = null)
        {
            var apiCallPath = String.Format("/accounts/{0}/bulk_send_lists", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            var csv = new JObject();
            var csvpropCount = 0;
            if (csvcSVFile != null)
            {
                csv["csv"] = ExpressionConverter.ConvertO(csvcSVFile);
                csvpropCount++;
            }

            if (csvpropCount > 0)
            {
                callPayload.Body = csv;
            }

            return new ApiConnectionAction<BulkSendListGuidInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<BulkSendListGuidInfo> BulkSend(Expression<Func<string>> accountId, Expression<Func<string>> bulkSendListId, Expression<Func<string>> envelopeOrTemplateId)
        {
            var apiCallPath = String.Format("/accounts/{0}/bulk_send_lists/{1}/send", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(bulkSendListId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["envelopeOrTemplateId"] = ExpressionConverter.Convert(envelopeOrTemplateId);
            return new ApiConnectionAction<BulkSendListGuidInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<GetLoginAccountsResponse> GetLoginAccounts()
        {
            var apiCallPath = "/login_information";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetLoginAccountsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<ListTemplatesResponse> GetEnvelopeTemplates(Expression<Func<string>> accountId)
        {
            var apiCallPath = String.Format("/accounts/{0}/templates", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListTemplatesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<AddDocumentsResponse> AddDocumentsToEnvelope(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<bodyunnamedInputItem[]>> bodyunnamed = null)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/documents", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyunnamed != null)
            {
                body["documents"] = ExpressionConverter.ConvertO(bodyunnamed);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddDocumentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<ListTemplateDocumentsResponse> ListTemplateDocuments(Expression<Func<string>> accountId, Expression<Func<string>> templateId)
        {
            var apiCallPath = String.Format("/accounts/{0}/templates/{1}/documents", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListTemplateDocumentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<ListDocumentsResponse> ListEnvelopeDocuments(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/envelopeDocuments", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListDocumentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<EnvelopeDocument> GetEnvelopeDocumentInfo(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> documentName)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/get_document_info", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["documentName"] = ExpressionConverter.Convert(documentName);
            return new ApiConnectionAction<EnvelopeDocument>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<AddRecipientTabsResponse> AddRecipientTabs(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> recipientId, Expression<Func<string>> tabType, Expression<Func<object>> tabDetails = null)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/recipients/{2}/tabs", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["tabType"] = ExpressionConverter.Convert(tabType);
            callPayload.Body = ExpressionConverter.ConvertO(tabDetails);
            return new ApiConnectionAction<AddRecipientTabsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<Tab> GetTabInfo(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> recipientId, Expression<Func<string>> tabLabel)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/recipients/{2}/tabs", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["tabLabel"] = ExpressionConverter.Convert(tabLabel);
            return new ApiConnectionAction<Tab>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IWorkflowAction UpdateRecipientTabsValues(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> recipientId, Expression<Func<bodyInputItem22[]>> body = null)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/recipients/{2}/tabs", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<RecipientTabsResponse> GetEnvelopeRecipientTabs(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> recipientId)
        {
            var apiCallPath = String.Format("/accounts/{0}/envelopes/{1}/recipients/{2}/recipientTabs", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<RecipientTabsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<JToken> TriggerMaestroFlow(Expression<Func<string>> accountId, Expression<Func<string>> workflowId, Expression<Func<string>> instanceName, Expression<Func<object>> variable = null)
        {
            var apiCallPath = String.Format("/accounts/{0}/maestro-workflows/trigger/{1}", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(workflowId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["instanceName"] = ExpressionConverter.Convert(instanceName);
            callPayload.Body = ExpressionConverter.ConvertO(variable);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<JToken> BuildNumber(Expression<Func<object>> buildNumber = null)
        {
            var apiCallPath = "/build_number";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(buildNumber);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class DocusignTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> CreateHookEnvelope(Expression<Func<string>> accountId, Expression<Func<string>> bodyconnectName, Expression<Func<bodyenvelopeEventInput>> bodyenvelopeEvent, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/accounts/{0}/connect", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
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
            body["includeEnvelopeVoidReason"] = "true";
            bodypropCount++;
            body["includeTimeZoneInformation"] = "true";
            bodypropCount++;
            body["requiresAcknowledgement"] = "true";
            bodypropCount++;
            body["urlToPublishTo"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyconnectName);
            bodypropCount++;
            body["envelopeEvents"] = ExpressionConverter.ConvertO(bodyenvelopeEvent);
            body["includeSenderAccountasCustomField"] = "true";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateHookEnvelopeV2(Expression<Func<string>> accountId, Expression<Func<string>> bodyconnectName, Expression<Func<bodyenvelopeEventInput>> bodyenvelopeEvent, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/accounts/{0}/connectV2", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
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
            body["urlToPublishTo"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyconnectName);
            bodypropCount++;
            body["envelopeEvents"] = ExpressionConverter.ConvertO(bodyenvelopeEvent);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> CreateHookEnvelopeV3(Expression<Func<string>> accountId, Expression<Func<string>> bodyconnectName, Expression<Func<bodyenvelopeEventInput>> bodyenvelopeEvent, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/accounts/{0}/connectV3", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
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
            body["urlToPublishTo"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyconnectName);
            bodypropCount++;
            body["envelopeEvents"] = ExpressionConverter.ConvertO(bodyenvelopeEvent);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
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

        [JsonProperty("tableName")]
        public string TableName { get; set; }

        [JsonProperty("rowNumber")]
        public string TableRow { get; set; }
    }

    public enum bodyInputItemTypeType
    {
        Text,
        Note
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
        public string RecipientId { get; set; }

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
        public string Id { get; set; }

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
        [EnumMember(Value = "any")]
        Any,
        [EnumMember(Value = "created")]
        Created,
        [EnumMember(Value = "sent")]
        Sent,
        [EnumMember(Value = "delivered")]
        Delivered,
        [EnumMember(Value = "signed")]
        Signed,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "declined")]
        Declined,
        [EnumMember(Value = "voided")]
        Voided,
        [EnumMember(Value = "deleted")]
        Deleted
    }

    public enum folderIdsInput
    {
        [EnumMember(Value = "awaiting_my_signature")]
        AwaitingMySignature,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "draft")]
        Draft,
        [EnumMember(Value = "drafts")]
        Drafts,
        [EnumMember(Value = "expiring_soon")]
        ExpiringSoon,
        [EnumMember(Value = "inbox")]
        Inbox,
        [EnumMember(Value = "out_for_signature")]
        OutForSignature,
        [EnumMember(Value = "recyclebin")]
        Recyclebin,
        [EnumMember(Value = "sentitems")]
        Sentitems,
        [EnumMember(Value = "waiting_for_others")]
        WaitingForOthers
    }

    public enum orderByInput
    {
        [EnumMember(Value = "last_modified")]
        LastModified,
        [EnumMember(Value = "action_required")]
        ActionRequired,
        [EnumMember(Value = "created")]
        Created,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "envelope_name")]
        EnvelopeName,
        [EnumMember(Value = "expire")]
        Expire,
        [EnumMember(Value = "sent")]
        Sent,
        [EnumMember(Value = "signer_list")]
        SignerList,
        [EnumMember(Value = "status")]
        Status,
        [EnumMember(Value = "subject")]
        Subject,
        [EnumMember(Value = "user_name")]
        UserName,
        [EnumMember(Value = "status_changed")]
        StatusChanged
    }

    public class FilteredSalesCopilotEnvelopeListResponse
    {
        [JsonProperty("value")]
        public SalesCopilotFilteredEnvelopes[] FilteredEnvelopes { get; set; }

        [JsonProperty("hasMoreResults")]
        public bool HasMoreResults { get; set; }
    }

    public class SalesCopilotFilteredEnvelopes
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subTitle")]
        public string SubTitle { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("additionalPropertiesForSalesEnvelope")]
        public SalesCopilotFilteredEnvelopesAdditionalPropertiesType AdditionalProperties { get; set; }
    }

    public class SalesCopilotFilteredEnvelopesAdditionalPropertiesType
    {
        [JsonProperty("additionalPropertiesForSalesEnvelope")]
        public string AdditionalProperties { get; set; }
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
        [EnumMember(Value = "Default URL")]
        DefaultURL,
        [EnumMember(Value = "Add a different URL")]
        AddADifferentURL
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
        RSASecureID,
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

    public class ListRecipientsResponse
    {
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
        public string RecipientId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("recipientType")]
        public string RecipientType { get; set; }

        [JsonProperty("verificationType")]
        public string VerificationType { get; set; }

        [JsonProperty("recipientIdGuid")]
        public string RecipientGuid { get; set; }
    }

    public class SignerRequest
    {
        [JsonProperty("routingOrder")]
        public string SigningOrder { get; set; }

        [JsonProperty("roleName")]
        public string Role { get; set; }
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

    public enum verificationTypeInput
    {
        None,
        [EnumMember(Value = "Access Code")]
        AccessCode,
        [EnumMember(Value = "ID Verification")]
        IDVerification,
        [EnumMember(Value = "Phone Authentication")]
        PhoneAuthentication,
        [EnumMember(Value = "Knowledge Based")]
        KnowledgeBased
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
    }

    public class bodyunnamedInputItem
    {
        [JsonProperty("documentBase64")]
        public string DocumentBase64* { get; set; }

        [JsonProperty("fileExtension")]
        public string DocumentType* { get; set; }

        [JsonProperty("name")]
        public string DocumentName* { get; set; }

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
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class RecipientTabsResponse
    {
        [JsonProperty("recipientTabs")]
        public Tab[] RecipientTab { get; set; }
    }

    public enum bodyenvelopeEventInput
    {
        [EnumMember(Value = "envelope-sent")]
        EnvelopeSent,
        [EnumMember(Value = "envelope-delivered")]
        EnvelopeDelivered,
        [EnumMember(Value = "envelope-completed")]
        EnvelopeCompleted,
        [EnumMember(Value = "envelope-declined")]
        EnvelopeDeclined,
        [EnumMember(Value = "envelope-voided")]
        EnvelopeVoided,
        [EnumMember(Value = "envelope-resent")]
        EnvelopeResent,
        [EnumMember(Value = "envelope-corrected")]
        EnvelopeCorrected,
        [EnumMember(Value = "envelope-purge")]
        EnvelopePurge,
        [EnumMember(Value = "envelope-deleted")]
        EnvelopeDeleted,
        [EnumMember(Value = "envelope-discard")]
        EnvelopeDiscard,
        [EnumMember(Value = "click-agreed")]
        ClickAgreed,
        [EnumMember(Value = "click-declined")]
        ClickDeclined,
        [EnumMember(Value = "recipient-autoresponded")]
        RecipientAutoresponded,
        [EnumMember(Value = "recipient-authenticationfailed")]
        RecipientAuthenticationfailed,
        [EnumMember(Value = "recipient-finish-later")]
        RecipientFinishLater
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