//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Docusign
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocusignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<DocGenFormFieldsResponse, ApiConnectionActionConfiguration> GetDocgenFormFields(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            return new DeferredBodyAction<DocGenFormFieldsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}/docGenFormFields", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DocGenFormFieldsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateDocgenFormFields(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> documentGuid, Expression<Func<bodyInputItem[]>> body = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_documentGuid = WorkflowExpression.Compile(documentGuid, nameof(documentGuid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}/docGenFormFields", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentGuid"] = ExpressionConverter.Convert(__workflow_documentGuid);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetDocGenTemplateTabs(Expression<Func<string>> accountId, Expression<Func<string>> templateId)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/templates/{1}", __workflow_accountId.WithUrlEncoding(1), __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> VoidEnvelope(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> voidedReason)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_voidedReason = WorkflowExpression.Compile(voidedReason, nameof(voidedReason), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}/voidEnvelope", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["voidedReason"] = ExpressionConverter.Convert(__workflow_voidedReason);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ResendEnvelope(Expression<Func<string>> envelopeId)
        {
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/copilotAccount/envelopes/{0}/resendEnvelope", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<AddRemindersResponse, ApiConnectionActionConfiguration> AddReminders(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<bool>> reminderEnabled, Expression<Func<string>> reminderDelay, Expression<Func<string>> reminderFrequency, Expression<Func<string>> expireAfter = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_reminderEnabled = WorkflowExpression.Compile(reminderEnabled, nameof(reminderEnabled), required: true);
            var __workflow_reminderDelay = WorkflowExpression.Compile(reminderDelay, nameof(reminderDelay), required: true);
            var __workflow_reminderFrequency = WorkflowExpression.Compile(reminderFrequency, nameof(reminderFrequency), required: true);
            var __workflow_expireAfter = WorkflowExpression.Compile(expireAfter, nameof(expireAfter), required: false);
            return new DeferredBodyAction<AddRemindersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}/notification", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["reminderEnabled"] = ExpressionConverter.Convert(__workflow_reminderEnabled);
                callPayload.Queries["reminderDelay"] = ExpressionConverter.Convert(__workflow_reminderDelay);
                callPayload.Queries["reminderFrequency"] = ExpressionConverter.Convert(__workflow_reminderFrequency);
                if (__workflow_expireAfter != null)
                    callPayload.Queries["expireAfter"] = ExpressionConverter.Convert(__workflow_expireAfter);
                return new ApiConnectionAction<AddRemindersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<ListTabsResponse, ApiConnectionActionConfiguration> GetEnvelopeDocumentTabs(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<ListTabsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}/documents/{2}/tabs", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListTabsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateEnvelopePrefillTabs(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<bodyInputItem2[]>> body = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}/documents/{2}/tabs", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<ListTabsResponse, ApiConnectionActionConfiguration> GetTemplateDocumentTabs(Expression<Func<string>> accountId, Expression<Func<string>> templateId, Expression<Func<string>> documentId)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<ListTabsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/templates/{1}/documents/{2}/tabs", __workflow_accountId.WithUrlEncoding(1), __workflow_templateId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListTabsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<ListEnvelopeDocumentFieldsResponse, ApiConnectionActionConfiguration> GetEnvelopeDocumentFields(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<ListEnvelopeDocumentFieldsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}/documents/{2}/fields", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListEnvelopeDocumentFieldsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<CompositeTemplatesResponse, ApiConnectionActionConfiguration> CompositeTemplates(Expression<Func<string>> accountId, Expression<Func<string>> emailSubject, Expression<Func<statusInput>> status, Expression<Func<string>> emailBody = null, Expression<Func<mergeRolesOnDraftInput>> mergeRolesOnDraft = null, Expression<Func<object>> body = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_emailSubject = WorkflowExpression.Compile(emailSubject, nameof(emailSubject), required: true);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: true);
            var __workflow_emailBody = WorkflowExpression.Compile(emailBody, nameof(emailBody), required: false);
            var __workflow_mergeRolesOnDraft = WorkflowExpression.Compile(mergeRolesOnDraft, nameof(mergeRolesOnDraft), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CompositeTemplatesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/compositeTemplates", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["emailSubject"] = ExpressionConverter.Convert(__workflow_emailSubject);
                if (__workflow_emailBody != null)
                    callPayload.Queries["emailBody"] = ExpressionConverter.Convert(__workflow_emailBody);
                callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                callPayload.Queries["merge_roles_on_draft"] = Convert.ToString("True");
                if (__workflow_mergeRolesOnDraft != null)
                    callPayload.Queries["merge_roles_on_draft"] = ExpressionConverter.Convert(__workflow_mergeRolesOnDraft);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CompositeTemplatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<FilteredEnvelopeListResponse, ApiConnectionActionConfiguration> SearchListEnvelopes(Expression<Func<string>> accountId, Expression<Func<string>> recipientName = null, Expression<Func<string>> recipientEmailId = null, Expression<Func<string>> envelopeTitle = null, Expression<Func<string>> customFieldName = null, Expression<Func<string>> customFieldValue = null, Expression<Func<string>> searchText = null, Expression<Func<envelopeStatusInput>> envelopeStatus = null, Expression<Func<folderIdsInput>> folderIds = null, Expression<Func<orderByInput>> orderBy = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> fromDate = null, Expression<Func<string>> toDate = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_recipientName = WorkflowExpression.Compile(recipientName, nameof(recipientName), required: false);
            var __workflow_recipientEmailId = WorkflowExpression.Compile(recipientEmailId, nameof(recipientEmailId), required: false);
            var __workflow_envelopeTitle = WorkflowExpression.Compile(envelopeTitle, nameof(envelopeTitle), required: false);
            var __workflow_customFieldName = WorkflowExpression.Compile(customFieldName, nameof(customFieldName), required: false);
            var __workflow_customFieldValue = WorkflowExpression.Compile(customFieldValue, nameof(customFieldValue), required: false);
            var __workflow_searchText = WorkflowExpression.Compile(searchText, nameof(searchText), required: false);
            var __workflow_envelopeStatus = WorkflowExpression.Compile(envelopeStatus, nameof(envelopeStatus), required: false);
            var __workflow_folderIds = WorkflowExpression.Compile(folderIds, nameof(folderIds), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_fromDate = WorkflowExpression.Compile(fromDate, nameof(fromDate), required: false);
            var __workflow_toDate = WorkflowExpression.Compile(toDate, nameof(toDate), required: false);
            return new DeferredBodyAction<FilteredEnvelopeListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/SearchListEnvelopes", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recipientName != null)
                    callPayload.Queries["recipientName"] = ExpressionConverter.Convert(__workflow_recipientName);
                if (__workflow_recipientEmailId != null)
                    callPayload.Queries["recipientEmailId"] = ExpressionConverter.Convert(__workflow_recipientEmailId);
                if (__workflow_envelopeTitle != null)
                    callPayload.Queries["envelopeTitle"] = ExpressionConverter.Convert(__workflow_envelopeTitle);
                if (__workflow_customFieldName != null)
                    callPayload.Queries["customFieldName"] = ExpressionConverter.Convert(__workflow_customFieldName);
                if (__workflow_customFieldValue != null)
                    callPayload.Queries["customFieldValue"] = ExpressionConverter.Convert(__workflow_customFieldValue);
                if (__workflow_searchText != null)
                    callPayload.Queries["search_text"] = ExpressionConverter.Convert(__workflow_searchText);
                callPayload.Queries["envelopeStatus"] = Convert.ToString("Any");
                if (__workflow_envelopeStatus != null)
                    callPayload.Queries["envelopeStatus"] = ExpressionConverter.Convert(__workflow_envelopeStatus);
                if (__workflow_folderIds != null)
                    callPayload.Queries["folder_ids"] = ExpressionConverter.Convert(__workflow_folderIds);
                callPayload.Queries["order_by"] = Convert.ToString("Status changed");
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["from_date"] = Convert.ToString("2024-01-02T12:45Z");
                if (__workflow_fromDate != null)
                    callPayload.Queries["from_date"] = ExpressionConverter.Convert(__workflow_fromDate);
                if (__workflow_toDate != null)
                    callPayload.Queries["to_date"] = ExpressionConverter.Convert(__workflow_toDate);
                return new ApiConnectionAction<FilteredEnvelopeListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<CreateEnvelopeResponse, ApiConnectionActionConfiguration> CreateEnvelopeFromTemplateNoRecipients(Expression<Func<string>> accountId, Expression<Func<string>> templateId, Expression<Func<statusInput>> status)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: true);
            return new DeferredBodyAction<CreateEnvelopeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/createFromTemplateNoRecipients", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["templateId"] = ExpressionConverter.Convert(__workflow_templateId);
                callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionAction<CreateEnvelopeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<CreateEnvelopeResponse, ApiConnectionActionConfiguration> SendEnvelope(Expression<Func<string>> accountId, Expression<Func<statusInput>> status, Expression<Func<string>> templateId, Expression<Func<object>> signers = null, Expression<Func<string>> emailSubject = null, Expression<Func<string>> emailBody = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_signers = WorkflowExpression.Compile(signers, nameof(signers), required: false);
            var __workflow_emailSubject = WorkflowExpression.Compile(emailSubject, nameof(emailSubject), required: false);
            var __workflow_emailBody = WorkflowExpression.Compile(emailBody, nameof(emailBody), required: false);
            return new DeferredBodyAction<CreateEnvelopeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                callPayload.Queries["templateId"] = ExpressionConverter.Convert(__workflow_templateId);
                if (__workflow_emailSubject != null)
                    callPayload.Queries["emailSubject"] = ExpressionConverter.Convert(__workflow_emailSubject);
                if (__workflow_emailBody != null)
                    callPayload.Queries["emailBody"] = ExpressionConverter.Convert(__workflow_emailBody);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_signers);
                return new ApiConnectionAction<CreateEnvelopeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<CreateEnvelopeResponse, ApiConnectionActionConfiguration> SendEnvelopeWithRecipientFields(Expression<Func<string>> accountId, Expression<Func<string>> templateId, Expression<Func<object>> recipients = null, Expression<Func<mergeRolesOnDraftInput>> mergeRolesOnDraft = null, Expression<Func<string>> emailSubject = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_recipients = WorkflowExpression.Compile(recipients, nameof(recipients), required: false);
            var __workflow_mergeRolesOnDraft = WorkflowExpression.Compile(mergeRolesOnDraft, nameof(mergeRolesOnDraft), required: false);
            var __workflow_emailSubject = WorkflowExpression.Compile(emailSubject, nameof(emailSubject), required: false);
            return new DeferredBodyAction<CreateEnvelopeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/createWithRecipientFields", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["templateId"] = ExpressionConverter.Convert(__workflow_templateId);
                callPayload.Queries["merge_roles_on_draft"] = Convert.ToString("False");
                if (__workflow_mergeRolesOnDraft != null)
                    callPayload.Queries["merge_roles_on_draft"] = ExpressionConverter.Convert(__workflow_mergeRolesOnDraft);
                if (__workflow_emailSubject != null)
                    callPayload.Queries["emailSubject"] = ExpressionConverter.Convert(__workflow_emailSubject);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_recipients);
                return new ApiConnectionAction<CreateEnvelopeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> SendDraftEnvelope(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<EnvelopeCustomFieldResponse, ApiConnectionActionConfiguration> GetEnvelopeCustomField(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> fieldName)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_fieldName = WorkflowExpression.Compile(fieldName, nameof(fieldName), required: true);
            return new DeferredBodyAction<EnvelopeCustomFieldResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}/custom_fields", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fieldName"] = ExpressionConverter.Convert(__workflow_fieldName);
                return new ApiConnectionAction<EnvelopeCustomFieldResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<UpdateEnvelopeCustomFieldResponse, ApiConnectionActionConfiguration> UpdateEnvelopeCustomField(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> fieldId, Expression<Func<string>> fieldType, Expression<Func<string>> name, Expression<Func<string>> value)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_fieldType = WorkflowExpression.Compile(fieldType, nameof(fieldType), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            return new DeferredBodyAction<UpdateEnvelopeCustomFieldResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}/custom_fields", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fieldId"] = ExpressionConverter.Convert(__workflow_fieldId);
                callPayload.Queries["fieldType"] = ExpressionConverter.Convert(__workflow_fieldType);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                callPayload.Queries["value"] = ExpressionConverter.Convert(__workflow_value);
                return new ApiConnectionAction<UpdateEnvelopeCustomFieldResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<EmbeddedSenderResponse, ApiConnectionActionConfiguration> GenerateEmbeddedSenderURL(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<openInInput>> openIn, Expression<Func<returnUrlInput>> returnUrl, Expression<Func<object>> additionalURL = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_openIn = WorkflowExpression.Compile(openIn, nameof(openIn), required: true);
            var __workflow_returnUrl = WorkflowExpression.Compile(returnUrl, nameof(returnUrl), required: true);
            var __workflow_additionalURL = WorkflowExpression.Compile(additionalURL, nameof(additionalURL), required: false);
            return new DeferredBodyAction<EmbeddedSenderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}/views/sender", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["openIn"] = ExpressionConverter.Convert(__workflow_openIn);
                callPayload.Queries["returnUrl"] = ExpressionConverter.Convert(__workflow_returnUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_additionalURL);
                return new ApiConnectionAction<EmbeddedSenderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<ListRecipientsResponse, ApiConnectionActionConfiguration> GetRecipientStatus(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            return new DeferredBodyAction<ListRecipientsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}/recipients", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListRecipientsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<ListRecipientsResponse, ApiConnectionActionConfiguration> RemoveRecipientFromEnvelope(Expression<Func<string>> accountId, Expression<Func<string>> folderId, Expression<Func<string>> envelopeId, Expression<Func<string>> removeRecipientFromEnvelopeRecipientId)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_removeRecipientFromEnvelopeRecipientId = WorkflowExpression.Compile(removeRecipientFromEnvelopeRecipientId, nameof(removeRecipientFromEnvelopeRecipientId), required: true);
            return new DeferredBodyAction<ListRecipientsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}/recipients", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                callPayload.Queries["RemoveRecipientFromEnvelopeRecipientId"] = ExpressionConverter.Convert(__workflow_removeRecipientFromEnvelopeRecipientId);
                return new ApiConnectionAction<ListRecipientsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<Signer, ApiConnectionActionConfiguration> GetRecipientFields(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> recipientEmail = null, Expression<Func<string>> areaCode = null, Expression<Func<string>> phoneNumber = null, Expression<Func<string>> recipientId = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_recipientEmail = WorkflowExpression.Compile(recipientEmail, nameof(recipientEmail), required: false);
            var __workflow_areaCode = WorkflowExpression.Compile(areaCode, nameof(areaCode), required: false);
            var __workflow_phoneNumber = WorkflowExpression.Compile(phoneNumber, nameof(phoneNumber), required: false);
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: false);
            return new DeferredBodyAction<Signer, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}/recipientFields", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recipientEmail != null)
                    callPayload.Queries["recipientEmail"] = ExpressionConverter.Convert(__workflow_recipientEmail);
                if (__workflow_areaCode != null)
                    callPayload.Queries["areaCode"] = ExpressionConverter.Convert(__workflow_areaCode);
                if (__workflow_phoneNumber != null)
                    callPayload.Queries["phoneNumber"] = ExpressionConverter.Convert(__workflow_phoneNumber);
                if (__workflow_recipientId != null)
                    callPayload.Queries["recipientId"] = ExpressionConverter.Convert(__workflow_recipientId);
                return new ApiConnectionAction<Signer>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetAuditEvents(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}/audit_events", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddVerificationToRecipient(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> recipientId, Expression<Func<string>> recipientType, Expression<Func<verificationTypeInput>> verificationType, Expression<Func<object>> additionalRecipientData = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            var __workflow_recipientType = WorkflowExpression.Compile(recipientType, nameof(recipientType), required: true);
            var __workflow_verificationType = WorkflowExpression.Compile(verificationType, nameof(verificationType), required: true);
            var __workflow_additionalRecipientData = WorkflowExpression.Compile(additionalRecipientData, nameof(additionalRecipientData), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}/recipients/addRecipientV2", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["recipientId"] = ExpressionConverter.Convert(__workflow_recipientId);
                callPayload.Queries["recipientType"] = ExpressionConverter.Convert(__workflow_recipientType);
                callPayload.Queries["verificationType"] = ExpressionConverter.Convert(__workflow_verificationType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_additionalRecipientData);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<Signer, ApiConnectionActionConfiguration> UpdateEnvelopeRecipient(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> recipientId, Expression<Func<string>> recipientType, Expression<Func<string>> signatureType = null, Expression<Func<string>> clientUserId = null, Expression<Func<string>> embeddedRecipientStartURL = null, Expression<Func<string>> routingOrder = null, Expression<Func<emailNotificationLanguageInput>> emailNotificationLanguage = null, Expression<Func<string>> emailNotificationSubject = null, Expression<Func<string>> emailNotificationBody = null, Expression<Func<string>> note = null, Expression<Func<string>> roleName = null, Expression<Func<string>> countryCode = null, Expression<Func<string>> phoneNumber = null, Expression<Func<string>> signingGroupId = null, Expression<Func<object>> additionalRecipientParams = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            var __workflow_recipientType = WorkflowExpression.Compile(recipientType, nameof(recipientType), required: true);
            var __workflow_signatureType = WorkflowExpression.Compile(signatureType, nameof(signatureType), required: false);
            var __workflow_clientUserId = WorkflowExpression.Compile(clientUserId, nameof(clientUserId), required: false);
            var __workflow_embeddedRecipientStartURL = WorkflowExpression.Compile(embeddedRecipientStartURL, nameof(embeddedRecipientStartURL), required: false);
            var __workflow_routingOrder = WorkflowExpression.Compile(routingOrder, nameof(routingOrder), required: false);
            var __workflow_emailNotificationLanguage = WorkflowExpression.Compile(emailNotificationLanguage, nameof(emailNotificationLanguage), required: false);
            var __workflow_emailNotificationSubject = WorkflowExpression.Compile(emailNotificationSubject, nameof(emailNotificationSubject), required: false);
            var __workflow_emailNotificationBody = WorkflowExpression.Compile(emailNotificationBody, nameof(emailNotificationBody), required: false);
            var __workflow_note = WorkflowExpression.Compile(note, nameof(note), required: false);
            var __workflow_roleName = WorkflowExpression.Compile(roleName, nameof(roleName), required: false);
            var __workflow_countryCode = WorkflowExpression.Compile(countryCode, nameof(countryCode), required: false);
            var __workflow_phoneNumber = WorkflowExpression.Compile(phoneNumber, nameof(phoneNumber), required: false);
            var __workflow_signingGroupId = WorkflowExpression.Compile(signingGroupId, nameof(signingGroupId), required: false);
            var __workflow_additionalRecipientParams = WorkflowExpression.Compile(additionalRecipientParams, nameof(additionalRecipientParams), required: false);
            return new DeferredBodyAction<Signer, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}/recipients/updateRecipient", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["recipientId"] = ExpressionConverter.Convert(__workflow_recipientId);
                if (__workflow_signatureType != null)
                    callPayload.Queries["signatureType"] = ExpressionConverter.Convert(__workflow_signatureType);
                callPayload.Queries["recipientType"] = ExpressionConverter.Convert(__workflow_recipientType);
                if (__workflow_clientUserId != null)
                    callPayload.Queries["clientUserId"] = ExpressionConverter.Convert(__workflow_clientUserId);
                if (__workflow_embeddedRecipientStartURL != null)
                    callPayload.Queries["embeddedRecipientStartURL"] = ExpressionConverter.Convert(__workflow_embeddedRecipientStartURL);
                if (__workflow_routingOrder != null)
                    callPayload.Queries["routingOrder"] = ExpressionConverter.Convert(__workflow_routingOrder);
                if (__workflow_emailNotificationLanguage != null)
                    callPayload.Queries["emailNotificationLanguage"] = ExpressionConverter.Convert(__workflow_emailNotificationLanguage);
                if (__workflow_emailNotificationSubject != null)
                    callPayload.Queries["emailNotificationSubject"] = ExpressionConverter.Convert(__workflow_emailNotificationSubject);
                if (__workflow_emailNotificationBody != null)
                    callPayload.Queries["emailNotificationBody"] = ExpressionConverter.Convert(__workflow_emailNotificationBody);
                if (__workflow_note != null)
                    callPayload.Queries["note"] = ExpressionConverter.Convert(__workflow_note);
                if (__workflow_roleName != null)
                    callPayload.Queries["roleName"] = ExpressionConverter.Convert(__workflow_roleName);
                if (__workflow_countryCode != null)
                    callPayload.Queries["countryCode"] = ExpressionConverter.Convert(__workflow_countryCode);
                if (__workflow_phoneNumber != null)
                    callPayload.Queries["phoneNumber"] = ExpressionConverter.Convert(__workflow_phoneNumber);
                if (__workflow_signingGroupId != null)
                    callPayload.Queries["signingGroupId"] = ExpressionConverter.Convert(__workflow_signingGroupId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_additionalRecipientParams);
                return new ApiConnectionAction<Signer>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ApplyTemplatesToDocuments(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> templateId, Expression<Func<preserveTemplateRecipientInput>> preserveTemplateRecipient = null, Expression<Func<bodydocumentTemplatesInputItem[]>> bodydocumentTemplates = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_preserveTemplateRecipient = WorkflowExpression.Compile(preserveTemplateRecipient, nameof(preserveTemplateRecipient), required: false);
            var __workflow_bodydocumentTemplates = WorkflowExpression.Compile(bodydocumentTemplates, nameof(bodydocumentTemplates), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}/templates", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["templateId"] = ExpressionConverter.Convert(__workflow_templateId);
                callPayload.Queries["preserve_template_recipient"] = Convert.ToString("False");
                if (__workflow_preserveTemplateRecipient != null)
                    callPayload.Queries["preserve_template_recipient"] = ExpressionConverter.Convert(__workflow_preserveTemplateRecipient);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydocumentTemplates != null)
                {
                    body["documentTemplates"] = ExpressionConverter.ConvertO(__workflow_bodydocumentTemplates);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<BulkSendListGuidInfo, ApiConnectionActionConfiguration> CreateBulkSendList(Expression<Func<string>> accountId, Expression<Func<string>> name, Expression<Func<string>> csvcSVFile = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_csvcSVFile = WorkflowExpression.Compile(csvcSVFile, nameof(csvcSVFile), required: false);
            return new DeferredBodyAction<BulkSendListGuidInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/bulk_send_lists", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                var csv = new JObject();
                var csvpropCount = 0;
                if (__workflow_csvcSVFile != null)
                {
                    csv["csv"] = ExpressionConverter.ConvertO(__workflow_csvcSVFile);
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

                return new ApiConnectionAction<BulkSendListGuidInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<BulkSendListGuidInfo, ApiConnectionActionConfiguration> BulkSend(Expression<Func<string>> accountId, Expression<Func<string>> bulkSendListId, Expression<Func<string>> envelopeOrTemplateId)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_bulkSendListId = WorkflowExpression.Compile(bulkSendListId, nameof(bulkSendListId), required: true);
            var __workflow_envelopeOrTemplateId = WorkflowExpression.Compile(envelopeOrTemplateId, nameof(envelopeOrTemplateId), required: true);
            return new DeferredBodyAction<BulkSendListGuidInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/bulk_send_lists/{1}/send", __workflow_accountId.WithUrlEncoding(1), __workflow_bulkSendListId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["envelopeOrTemplateId"] = ExpressionConverter.Convert(__workflow_envelopeOrTemplateId);
                return new ApiConnectionAction<BulkSendListGuidInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<GetLoginAccountsResponse, ApiConnectionActionConfiguration> GetLoginAccounts()
        {
            return new DeferredBodyAction<GetLoginAccountsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/oauth/userinfo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetLoginAccountsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<ListTemplatesResponse, ApiConnectionActionConfiguration> GetEnvelopeTemplates(Expression<Func<string>> accountId)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            return new DeferredBodyAction<ListTemplatesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/templates", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListTemplatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<AddDocumentsResponse, ApiConnectionActionConfiguration> AddDocumentsToEnvelope(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<bodyunnamedInputItem[]>> bodyunnamed = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_bodyunnamed = WorkflowExpression.Compile(bodyunnamed, nameof(bodyunnamed), required: false);
            return new DeferredBodyAction<AddDocumentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}/documents", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyunnamed != null)
                {
                    body["documents"] = ExpressionConverter.ConvertO(__workflow_bodyunnamed);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddDocumentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<ListTemplateDocumentsResponse, ApiConnectionActionConfiguration> ListTemplateDocuments(Expression<Func<string>> accountId, Expression<Func<string>> templateId)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            return new DeferredBodyAction<ListTemplateDocumentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/templates/{1}/documents", __workflow_accountId.WithUrlEncoding(1), __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListTemplateDocumentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<ListDocumentsResponse, ApiConnectionActionConfiguration> ListEnvelopeDocuments(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            return new DeferredBodyAction<ListDocumentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}/envelopeDocuments", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListDocumentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<EnvelopeDocument, ApiConnectionActionConfiguration> GetEnvelopeDocumentInfo(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> documentName)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_documentName = WorkflowExpression.Compile(documentName, nameof(documentName), required: true);
            return new DeferredBodyAction<EnvelopeDocument, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}/get_document_info", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentName"] = ExpressionConverter.Convert(__workflow_documentName);
                return new ApiConnectionAction<EnvelopeDocument>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<Tab, ApiConnectionActionConfiguration> GetTabInfo(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> recipientId, Expression<Func<string>> tabLabel)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            var __workflow_tabLabel = WorkflowExpression.Compile(tabLabel, nameof(tabLabel), required: true);
            return new DeferredBodyAction<Tab, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}/recipients/{2}/tabs", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1), __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tabLabel"] = ExpressionConverter.Convert(__workflow_tabLabel);
                return new ApiConnectionAction<Tab>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<AddRecipientTabsResponse, ApiConnectionActionConfiguration> AddRecipientTabs(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> recipientId, Expression<Func<string>> tabType, Expression<Func<object>> tabDetails = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            var __workflow_tabType = WorkflowExpression.Compile(tabType, nameof(tabType), required: true);
            var __workflow_tabDetails = WorkflowExpression.Compile(tabDetails, nameof(tabDetails), required: false);
            return new DeferredBodyAction<AddRecipientTabsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}/recipients/{2}/tabs", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1), __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tabType"] = ExpressionConverter.Convert(__workflow_tabType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_tabDetails);
                return new ApiConnectionAction<AddRecipientTabsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateRecipientTabsValues(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> recipientId, Expression<Func<bodyInputItem22[]>> body = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}/recipients/{2}/tabs", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1), __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<RecipientTabsResponse, ApiConnectionActionConfiguration> GetEnvelopeRecipientTabs(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> recipientId)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            return new DeferredBodyAction<RecipientTabsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}/recipients/{2}/recipientTabs", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1), __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RecipientTabsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> TriggerMaestroFlow(Expression<Func<string>> accountId, Expression<Func<string>> workflowId, Expression<Func<string>> instanceName, Expression<Func<object>> variable = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: true);
            var __workflow_instanceName = WorkflowExpression.Compile(instanceName, nameof(instanceName), required: true);
            var __workflow_variable = WorkflowExpression.Compile(variable, nameof(variable), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/maestro-workflows/trigger/{1}", __workflow_accountId.WithUrlEncoding(1), __workflow_workflowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["instanceName"] = ExpressionConverter.Convert(__workflow_instanceName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_variable);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> BuildNumber(Expression<Func<object>> buildNumber = null)
        {
            var __workflow_buildNumber = WorkflowExpression.Compile(buildNumber, nameof(buildNumber), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/build_number";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_buildNumber);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<Signer, ApiConnectionActionConfiguration> AddRecipientToEnvelope(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<string>> recipientType, Expression<Func<string>> clientUserId = null, Expression<Func<string>> recipientId = null, Expression<Func<string>> embeddedRecipientStartURL = null, Expression<Func<string>> routingOrder = null, Expression<Func<emailNotificationLanguageInput>> emailNotificationLanguage = null, Expression<Func<string>> emailNotificationSubject = null, Expression<Func<string>> emailNotificationBody = null, Expression<Func<string>> note = null, Expression<Func<string>> roleName = null, Expression<Func<string>> countryCode = null, Expression<Func<string>> phoneNumber = null, Expression<Func<string>> signingGroupId = null, Expression<Func<string>> signatureType = null, Expression<Func<string>> workflowId = null, Expression<Func<object>> additionalRecipientParams = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_recipientType = WorkflowExpression.Compile(recipientType, nameof(recipientType), required: true);
            var __workflow_clientUserId = WorkflowExpression.Compile(clientUserId, nameof(clientUserId), required: false);
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: false);
            var __workflow_embeddedRecipientStartURL = WorkflowExpression.Compile(embeddedRecipientStartURL, nameof(embeddedRecipientStartURL), required: false);
            var __workflow_routingOrder = WorkflowExpression.Compile(routingOrder, nameof(routingOrder), required: false);
            var __workflow_emailNotificationLanguage = WorkflowExpression.Compile(emailNotificationLanguage, nameof(emailNotificationLanguage), required: false);
            var __workflow_emailNotificationSubject = WorkflowExpression.Compile(emailNotificationSubject, nameof(emailNotificationSubject), required: false);
            var __workflow_emailNotificationBody = WorkflowExpression.Compile(emailNotificationBody, nameof(emailNotificationBody), required: false);
            var __workflow_note = WorkflowExpression.Compile(note, nameof(note), required: false);
            var __workflow_roleName = WorkflowExpression.Compile(roleName, nameof(roleName), required: false);
            var __workflow_countryCode = WorkflowExpression.Compile(countryCode, nameof(countryCode), required: false);
            var __workflow_phoneNumber = WorkflowExpression.Compile(phoneNumber, nameof(phoneNumber), required: false);
            var __workflow_signingGroupId = WorkflowExpression.Compile(signingGroupId, nameof(signingGroupId), required: false);
            var __workflow_signatureType = WorkflowExpression.Compile(signatureType, nameof(signatureType), required: false);
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: false);
            var __workflow_additionalRecipientParams = WorkflowExpression.Compile(additionalRecipientParams, nameof(additionalRecipientParams), required: false);
            return new DeferredBodyAction<Signer, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}/recipients/addRecipientV2", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["recipientType"] = ExpressionConverter.Convert(__workflow_recipientType);
                if (__workflow_clientUserId != null)
                    callPayload.Queries["clientUserId"] = ExpressionConverter.Convert(__workflow_clientUserId);
                if (__workflow_recipientId != null)
                    callPayload.Queries["recipientId"] = ExpressionConverter.Convert(__workflow_recipientId);
                if (__workflow_embeddedRecipientStartURL != null)
                    callPayload.Queries["embeddedRecipientStartURL"] = ExpressionConverter.Convert(__workflow_embeddedRecipientStartURL);
                if (__workflow_routingOrder != null)
                    callPayload.Queries["routingOrder"] = ExpressionConverter.Convert(__workflow_routingOrder);
                if (__workflow_emailNotificationLanguage != null)
                    callPayload.Queries["emailNotificationLanguage"] = ExpressionConverter.Convert(__workflow_emailNotificationLanguage);
                if (__workflow_emailNotificationSubject != null)
                    callPayload.Queries["emailNotificationSubject"] = ExpressionConverter.Convert(__workflow_emailNotificationSubject);
                if (__workflow_emailNotificationBody != null)
                    callPayload.Queries["emailNotificationBody"] = ExpressionConverter.Convert(__workflow_emailNotificationBody);
                if (__workflow_note != null)
                    callPayload.Queries["note"] = ExpressionConverter.Convert(__workflow_note);
                if (__workflow_roleName != null)
                    callPayload.Queries["roleName"] = ExpressionConverter.Convert(__workflow_roleName);
                if (__workflow_countryCode != null)
                    callPayload.Queries["countryCode"] = ExpressionConverter.Convert(__workflow_countryCode);
                if (__workflow_phoneNumber != null)
                    callPayload.Queries["phoneNumber"] = ExpressionConverter.Convert(__workflow_phoneNumber);
                if (__workflow_signingGroupId != null)
                    callPayload.Queries["signingGroupId"] = ExpressionConverter.Convert(__workflow_signingGroupId);
                if (__workflow_signatureType != null)
                    callPayload.Queries["signatureType"] = ExpressionConverter.Convert(__workflow_signatureType);
                if (__workflow_workflowId != null)
                    callPayload.Queries["workflowId"] = ExpressionConverter.Convert(__workflow_workflowId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_additionalRecipientParams);
                return new ApiConnectionAction<Signer>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<CreateEnvelopeResponse, ApiConnectionActionConfiguration> CreateBlankEnvelope(Expression<Func<string>> accountId, Expression<Func<string>> emailSubject, Expression<Func<string>> bodyemailBody = null, Expression<Func<object>> bodyaccountCustomFields = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_emailSubject = WorkflowExpression.Compile(emailSubject, nameof(emailSubject), required: true);
            var __workflow_bodyemailBody = WorkflowExpression.Compile(bodyemailBody, nameof(bodyemailBody), required: false);
            var __workflow_bodyaccountCustomFields = WorkflowExpression.Compile(bodyaccountCustomFields, nameof(bodyaccountCustomFields), required: false);
            return new DeferredBodyAction<CreateEnvelopeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/createBlankEnvelopeV2", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["emailSubject"] = ExpressionConverter.Convert(__workflow_emailSubject);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyemailBody != null)
                {
                    body["emailBlurb"] = ExpressionConverter.ConvertO(__workflow_bodyemailBody);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountCustomFields != null)
                {
                    body["AccountCustomFields"] = ExpressionConverter.ConvertO(__workflow_bodyaccountCustomFields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateEnvelopeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<EmbeddedSigningResponse, ApiConnectionActionConfiguration> GenerateEmbeddedSigningURL(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<isInPersonSignerInput>> isInPersonSigner, Expression<Func<authenticationMethodInput>> authenticationMethod, Expression<Func<returnUrlInput>> returnUrl, Expression<Func<object>> additionalURL = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_isInPersonSigner = WorkflowExpression.Compile(isInPersonSigner, nameof(isInPersonSigner), required: true);
            var __workflow_authenticationMethod = WorkflowExpression.Compile(authenticationMethod, nameof(authenticationMethod), required: true);
            var __workflow_returnUrl = WorkflowExpression.Compile(returnUrl, nameof(returnUrl), required: true);
            var __workflow_additionalURL = WorkflowExpression.Compile(additionalURL, nameof(additionalURL), required: false);
            return new DeferredBodyAction<EmbeddedSigningResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}/views/recipientV2", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["isInPersonSigner"] = ExpressionConverter.Convert(__workflow_isInPersonSigner);
                callPayload.Queries["authenticationMethod"] = ExpressionConverter.Convert(__workflow_authenticationMethod);
                callPayload.Queries["returnUrl"] = ExpressionConverter.Convert(__workflow_returnUrl);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_additionalURL);
                return new ApiConnectionAction<EmbeddedSigningResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docusign")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetDocuments(Expression<Func<string>> accountId, Expression<Func<string>> envelopeId, Expression<Func<documentIdInput>> documentId, Expression<Func<languageInput>> language = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/envelopes/{1}/documents/{2}/documentsDownload", __workflow_accountId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["language"] = Convert.ToString("English (default)");
                if (__workflow_language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(__workflow_language);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class DocusignTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> CreateOrgHookEnvelope(Expression<Func<string>> organizationId, Expression<Func<string>> bodyconnectConfigurationName, Expression<Func<bodytriggerEventsInputItem[]>> bodytriggerEvents, FlowRecurrence recurrence = null)
        {
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            var __workflow_bodyconnectConfigurationName = WorkflowExpression.Compile(bodyconnectConfigurationName, nameof(bodyconnectConfigurationName), required: true);
            var __workflow_bodytriggerEvents = WorkflowExpression.Compile(bodytriggerEvents, nameof(bodytriggerEvents), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Management/v2/organizations/{0}/connect", __workflow_organizationId.WithUrlEncoding(1)));
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
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyconnectConfigurationName);
                bodypropCount++;
                body["events"] = ExpressionConverter.ConvertO(__workflow_bodytriggerEvents);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> CreateHookEnvelope(Expression<Func<string>> accountId, Expression<Func<string>> bodyconnectConfigurationName, Expression<Func<bodytriggerEventsInputItem[]>> bodytriggerEvents, FlowRecurrence recurrence = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_bodyconnectConfigurationName = WorkflowExpression.Compile(bodyconnectConfigurationName, nameof(bodyconnectConfigurationName), required: true);
            var __workflow_bodytriggerEvents = WorkflowExpression.Compile(bodytriggerEvents, nameof(bodytriggerEvents), required: true);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounts/{0}/connectV4", __workflow_accountId.WithUrlEncoding(1)));
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
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyconnectConfigurationName);
                bodypropCount++;
                body["events"] = ExpressionConverter.ConvertO(__workflow_bodytriggerEvents);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum statusInput
    {
        Sent,
        Created
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public string EnvelopeId { get; set; }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public string FieldId { get; set; }

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
        public string FieldId { get; set; }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum openInInput
    {
        Prepare,
        Tagging
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public string EnvelopeId { get; set; }

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
        public string RecipientGUID { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum preserveTemplateRecipientInput
    {
        False,
        True
    }

    public class bodydocumentTemplatesInputItem
    {
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class EmbeddedSigningResponse
    {
        [JsonProperty("url")]
        public string URL { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum isInPersonSignerInput
    {
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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