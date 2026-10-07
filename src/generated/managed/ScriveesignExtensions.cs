//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Scriveesign
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ScriveesignActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocJson))]
        public IBodyWorkflowAction<JToken> GetDocJson([WorkflowExpression] Func<string> bodydocumentId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetDocJson(WorkflowExpression<string> bodydocumentId)
        {
            WorkflowExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/getdocumentjson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocStatus))]
        public IBodyWorkflowAction<string> GetDocStatus([WorkflowExpression] Func<string> bodydocumentId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetDocStatus(WorkflowExpression<string> bodydocumentId)
        {
            WorkflowExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/getdocumentstatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [WorkflowExpressionFactory(nameof(__BuildGetPartyStatus))]
        public IBodyWorkflowAction<string> GetPartyStatus([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodypartyId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetPartyStatus(WorkflowExpression<string> bodydocumentId, WorkflowExpression<string> bodypartyId)
        {
            WorkflowExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            WorkflowExpression.Validate(bodypartyId, nameof(bodypartyId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/getpartystatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
                bodypropCount++;
                body["partyId"] = ExpressionConverter.ConvertO(bodypartyId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [WorkflowExpressionFactory(nameof(__BuildUpdatePartyEmail))]
        public IBodyWorkflowAction<JToken> UpdatePartyEmail([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodypartyId, [WorkflowExpression] Func<string> bodypartyEmail)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildUpdatePartyEmail(WorkflowExpression<string> bodydocumentId, WorkflowExpression<string> bodypartyId, WorkflowExpression<string> bodypartyEmail)
        {
            WorkflowExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            WorkflowExpression.Validate(bodypartyId, nameof(bodypartyId), required: true);
            WorkflowExpression.Validate(bodypartyEmail, nameof(bodypartyEmail), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/updatepartyemail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
                bodypropCount++;
                body["partyId"] = ExpressionConverter.ConvertO(bodypartyId);
                bodypropCount++;
                body["partyEmail"] = ExpressionConverter.ConvertO(bodypartyEmail);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [WorkflowExpressionFactory(nameof(__BuildSendReminder))]
        public IBodyWorkflowAction<JToken> SendReminder([WorkflowExpression] Func<string> bodydocumentId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildSendReminder(WorkflowExpression<string> bodydocumentId)
        {
            WorkflowExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/sendreminder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocumentPdfContent))]
        public IBodyWorkflowAction<string> GetDocumentPdfContent([WorkflowExpression] Func<string> bodydocumentId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetDocumentPdfContent(WorkflowExpression<string> bodydocumentId)
        {
            WorkflowExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/getdocumentpdfcontent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [WorkflowExpressionFactory(nameof(__BuildNewDocumentFromTemplate))]
        public IBodyWorkflowAction<string> NewDocumentFromTemplate([WorkflowExpression] Func<string> templateIdDynamic)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildNewDocumentFromTemplate(WorkflowExpression<string> templateIdDynamic)
        {
            WorkflowExpression.Validate(templateIdDynamic, nameof(templateIdDynamic), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/newfromtemplate/{0}", ExpressionConverter.ConvertWithUrlEncoding(templateIdDynamic, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [WorkflowExpressionFactory(nameof(__BuildStartSigning))]
        public IBodyWorkflowAction<string> StartSigning([WorkflowExpression] Func<string> bodydocumentId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildStartSigning(WorkflowExpression<string> bodydocumentId)
        {
            WorkflowExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/startsigning";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateDocJson))]
        public IWorkflowAction UpdateDocJson([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodydocumentJson)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateDocJson(WorkflowExpression<string> bodydocumentId, WorkflowExpression<string> bodydocumentJson)
        {
            WorkflowExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            WorkflowExpression.Validate(bodydocumentJson, nameof(bodydocumentJson), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/updatedocumentjson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
                bodypropCount++;
                body["documentJson"] = ExpressionConverter.ConvertO(bodydocumentJson);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [WorkflowExpressionFactory(nameof(__BuildUpdatePartiesFields))]
        public IWorkflowAction UpdatePartiesFields([WorkflowExpression] Func<string> templateIDDynamic, [WorkflowExpression] Func<object> dynamicTemplateSchema = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdatePartiesFields(WorkflowExpression<string> templateIDDynamic, WorkflowExpression<object> dynamicTemplateSchema = null)
        {
            WorkflowExpression.Validate(templateIDDynamic, nameof(templateIDDynamic), required: true);
            WorkflowExpression.Validate(dynamicTemplateSchema, nameof(dynamicTemplateSchema), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/updatepartiesfields/{0}", ExpressionConverter.ConvertWithUrlEncoding(templateIDDynamic, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(dynamicTemplateSchema);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [WorkflowExpressionFactory(nameof(__BuildUpdatePartiesProperties))]
        public IWorkflowAction UpdatePartiesProperties([WorkflowExpression] Func<string> templateIDDynamic, [WorkflowExpression] Func<object> dynamicTemplateMetaSchema = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdatePartiesProperties(WorkflowExpression<string> templateIDDynamic, WorkflowExpression<object> dynamicTemplateMetaSchema = null)
        {
            WorkflowExpression.Validate(templateIDDynamic, nameof(templateIDDynamic), required: true);
            WorkflowExpression.Validate(dynamicTemplateMetaSchema, nameof(dynamicTemplateMetaSchema), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/updatepartiesproperties/{0}", ExpressionConverter.ConvertWithUrlEncoding(templateIDDynamic, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(dynamicTemplateMetaSchema);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [WorkflowExpressionFactory(nameof(__BuildSetFile))]
        public IBodyWorkflowAction<JToken> SetFile([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodypdfContent)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildSetFile(WorkflowExpression<string> bodydocumentId, WorkflowExpression<string> bodypdfContent)
        {
            WorkflowExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            WorkflowExpression.Validate(bodypdfContent, nameof(bodypdfContent), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/setfile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
                bodypropCount++;
                body["pdfContent"] = ExpressionConverter.ConvertO(bodypdfContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [WorkflowExpressionFactory(nameof(__BuildNewFromPdf))]
        public IBodyWorkflowAction<string> NewFromPdf([WorkflowExpression] Func<string> bodypdfContent, [WorkflowExpression] Func<bodyauthorRoleInput> bodyauthorRole)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildNewFromPdf(WorkflowExpression<string> bodypdfContent, WorkflowExpression<bodyauthorRoleInput> bodyauthorRole)
        {
            WorkflowExpression.Validate(bodypdfContent, nameof(bodypdfContent), required: true);
            WorkflowExpression.Validate(bodyauthorRole, nameof(bodyauthorRole), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/newfrompdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["pdfContent"] = ExpressionConverter.ConvertO(bodypdfContent);
                bodypropCount++;
                body["authorRole"] = ExpressionConverter.ConvertO(bodyauthorRole);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [WorkflowExpressionFactory(nameof(__BuildAppendFile))]
        public IWorkflowAction AppendFile([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodypdfContent)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAppendFile(WorkflowExpression<string> bodydocumentId, WorkflowExpression<string> bodypdfContent)
        {
            WorkflowExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            WorkflowExpression.Validate(bodypdfContent, nameof(bodypdfContent), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/appendfile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
                bodypropCount++;
                body["pdfContent"] = ExpressionConverter.ConvertO(bodypdfContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [WorkflowExpressionFactory(nameof(__BuildCancel))]
        public IWorkflowAction Cancel([WorkflowExpression] Func<string> bodydocumentId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCancel(WorkflowExpression<string> bodydocumentId)
        {
            WorkflowExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/cancel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [WorkflowExpressionFactory(nameof(__BuildAddParty))]
        public IWorkflowAction AddParty([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodypartyEmail, [WorkflowExpression] Func<bodypartyRoleInput> bodypartyRole, [WorkflowExpression] Func<string> bodyfirstname = null, [WorkflowExpression] Func<string> bodylastname = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodymobile = null, [WorkflowExpression] Func<string> bodypersonalNumber = null, [WorkflowExpression] Func<double> bodysignOrder = null, [WorkflowExpression] Func<bodydeliveryMethodInput> bodydeliveryMethod = null, [WorkflowExpression] Func<bodyauthenticationToViewInput> bodyauthenticationToView = null, [WorkflowExpression] Func<bodyauthenticationToViewArchivedInput> bodyauthenticationToViewArchived = null, [WorkflowExpression] Func<bodyauthenticationToSignInput> bodyauthenticationToSign = null, [WorkflowExpression] Func<bodyconfirmationInput> bodyconfirmation = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddParty(WorkflowExpression<string> bodydocumentId, WorkflowExpression<string> bodypartyEmail, WorkflowExpression<bodypartyRoleInput> bodypartyRole, WorkflowExpression<string> bodyfirstname = null, WorkflowExpression<string> bodylastname = null, WorkflowExpression<string> bodycompany = null, WorkflowExpression<string> bodymobile = null, WorkflowExpression<string> bodypersonalNumber = null, WorkflowExpression<double> bodysignOrder = null, WorkflowExpression<bodydeliveryMethodInput> bodydeliveryMethod = null, WorkflowExpression<bodyauthenticationToViewInput> bodyauthenticationToView = null, WorkflowExpression<bodyauthenticationToViewArchivedInput> bodyauthenticationToViewArchived = null, WorkflowExpression<bodyauthenticationToSignInput> bodyauthenticationToSign = null, WorkflowExpression<bodyconfirmationInput> bodyconfirmation = null)
        {
            WorkflowExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            WorkflowExpression.Validate(bodypartyEmail, nameof(bodypartyEmail), required: true);
            WorkflowExpression.Validate(bodypartyRole, nameof(bodypartyRole), required: true);
            WorkflowExpression.Validate(bodyfirstname, nameof(bodyfirstname), required: false);
            WorkflowExpression.Validate(bodylastname, nameof(bodylastname), required: false);
            WorkflowExpression.Validate(bodycompany, nameof(bodycompany), required: false);
            WorkflowExpression.Validate(bodymobile, nameof(bodymobile), required: false);
            WorkflowExpression.Validate(bodypersonalNumber, nameof(bodypersonalNumber), required: false);
            WorkflowExpression.Validate(bodysignOrder, nameof(bodysignOrder), required: false);
            WorkflowExpression.Validate(bodydeliveryMethod, nameof(bodydeliveryMethod), required: false);
            WorkflowExpression.Validate(bodyauthenticationToView, nameof(bodyauthenticationToView), required: false);
            WorkflowExpression.Validate(bodyauthenticationToViewArchived, nameof(bodyauthenticationToViewArchived), required: false);
            WorkflowExpression.Validate(bodyauthenticationToSign, nameof(bodyauthenticationToSign), required: false);
            WorkflowExpression.Validate(bodyconfirmation, nameof(bodyconfirmation), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/addparty";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
                bodypropCount++;
                body["partyEmail"] = ExpressionConverter.ConvertO(bodypartyEmail);
                bodypropCount++;
                body["partyRole"] = ExpressionConverter.ConvertO(bodypartyRole);
                if (bodyfirstname != null)
                {
                    body["firstname"] = ExpressionConverter.ConvertO(bodyfirstname);
                    bodypropCount++;
                }

                if (bodylastname != null)
                {
                    body["lastname"] = ExpressionConverter.ConvertO(bodylastname);
                    bodypropCount++;
                }

                if (bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(bodycompany);
                    bodypropCount++;
                }

                if (bodymobile != null)
                {
                    body["mobile"] = ExpressionConverter.ConvertO(bodymobile);
                    bodypropCount++;
                }

                if (bodypersonalNumber != null)
                {
                    body["personalNumber"] = ExpressionConverter.ConvertO(bodypersonalNumber);
                    bodypropCount++;
                }

                if (bodysignOrder != null)
                {
                    body["signOrder"] = ExpressionConverter.ConvertO(bodysignOrder);
                    bodypropCount++;
                }

                if (bodydeliveryMethod != null)
                {
                    if (bodydeliveryMethod != null)
                    {
                        body["deliveryMethod"] = ExpressionConverter.ConvertO(bodydeliveryMethod);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["deliveryMethod"] = "email";
                    bodypropCount++;
                }

                if (bodyauthenticationToView != null)
                {
                    if (bodyauthenticationToView != null)
                    {
                        body["authenticationToView"] = ExpressionConverter.ConvertO(bodyauthenticationToView);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["authenticationToView"] = "standard";
                    bodypropCount++;
                }

                if (bodyauthenticationToViewArchived != null)
                {
                    if (bodyauthenticationToViewArchived != null)
                    {
                        body["authenticationToViewArchived"] = ExpressionConverter.ConvertO(bodyauthenticationToViewArchived);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["authenticationToViewArchived"] = "standard";
                    bodypropCount++;
                }

                if (bodyauthenticationToSign != null)
                {
                    if (bodyauthenticationToSign != null)
                    {
                        body["authenticationToSign"] = ExpressionConverter.ConvertO(bodyauthenticationToSign);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["authenticationToSign"] = "standard";
                    bodypropCount++;
                }

                if (bodyconfirmation != null)
                {
                    if (bodyconfirmation != null)
                    {
                        body["confirmation"] = ExpressionConverter.ConvertO(bodyconfirmation);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["confirmation"] = "email";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [WorkflowExpressionFactory(nameof(__BuildSetAuthorAttachment))]
        public IWorkflowAction SetAuthorAttachment([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodyattachmentName, [WorkflowExpression] Func<bodyrequiredInput> bodyrequired, [WorkflowExpression] Func<bodyaddToSealedFileInput> bodyaddToSealedFile, [WorkflowExpression] Func<string> bodyfileId = null, [WorkflowExpression] Func<string> bodypdfContent = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSetAuthorAttachment(WorkflowExpression<string> bodydocumentId, WorkflowExpression<string> bodyattachmentName, WorkflowExpression<bodyrequiredInput> bodyrequired, WorkflowExpression<bodyaddToSealedFileInput> bodyaddToSealedFile, WorkflowExpression<string> bodyfileId = null, WorkflowExpression<string> bodypdfContent = null)
        {
            WorkflowExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            WorkflowExpression.Validate(bodyattachmentName, nameof(bodyattachmentName), required: true);
            WorkflowExpression.Validate(bodyrequired, nameof(bodyrequired), required: true);
            WorkflowExpression.Validate(bodyaddToSealedFile, nameof(bodyaddToSealedFile), required: true);
            WorkflowExpression.Validate(bodyfileId, nameof(bodyfileId), required: false);
            WorkflowExpression.Validate(bodypdfContent, nameof(bodypdfContent), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/setattachment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfileId != null)
                {
                    body["fileId"] = ExpressionConverter.ConvertO(bodyfileId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
                bodypropCount++;
                body["attachmentName"] = ExpressionConverter.ConvertO(bodyattachmentName);
                bodypropCount++;
                body["required"] = ExpressionConverter.ConvertO(bodyrequired);
                bodypropCount++;
                body["addToSealedFile"] = ExpressionConverter.ConvertO(bodyaddToSealedFile);
                if (bodypdfContent != null)
                {
                    body["pdfContent"] = ExpressionConverter.ConvertO(bodypdfContent);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class ScriveesignTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildStartAndOnDocumentSign))]
        public IBodyWorkflowTrigger<string> StartAndOnDocumentSign([WorkflowExpression] Func<string> bodydocumentId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<string> __BuildStartAndOnDocumentSign(WorkflowExpression<string> bodydocumentId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            return new DeferredBodyTrigger<string>(() =>
            {
                var apiCallPath = "/webhooks/signed/createandstart";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
                body["webhookUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildWebhookFromTemplateSign))]
        public IBodyWorkflowTrigger<string> WebhookFromTemplateSign([WorkflowExpression] Func<string> templateIdDynamic,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<string> __BuildWebhookFromTemplateSign(WorkflowExpression<string> templateIdDynamic,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(templateIdDynamic, nameof(templateIdDynamic), required: true);
            return new DeferredBodyTrigger<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/webhooks/signedfromtemplate/create/{0}", ExpressionConverter.ConvertWithUrlEncoding(templateIdDynamic, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["webhookUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<PollSignedDocumentsResponse> PollSignedDocuments(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/polling/signed";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pollTime"] = Convert.ToString("init");
            return new ApiConnectionTrigger<PollSignedDocumentsResponse>(callPayload, recurrence: recurrence);
        }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyauthorRoleInput
    {
        [EnumMember(Value = "signing_party")]
        SigningParty,
        [EnumMember(Value = "viewer")]
        Viewer
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypartyRoleInput
    {
        [EnumMember(Value = "signing_party")]
        SigningParty,
        [EnumMember(Value = "viewer")]
        Viewer,
        [EnumMember(Value = "approver")]
        Approver
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydeliveryMethodInput
    {
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "mobile")]
        Mobile,
        [EnumMember(Value = "email_mobile")]
        EmailMobile,
        [EnumMember(Value = "pad")]
        Pad,
        [EnumMember(Value = "api")]
        Api
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyauthenticationToViewInput
    {
        [EnumMember(Value = "standard")]
        Standard,
        [EnumMember(Value = "sms_pin")]
        SmsPin,
        [EnumMember(Value = "se_bankid")]
        SeBankid,
        [EnumMember(Value = "no_bankid")]
        NoBankid,
        [EnumMember(Value = "dk_nemid")]
        DkNemid,
        [EnumMember(Value = "fi_tupas")]
        FiTupas,
        [EnumMember(Value = "verimi")]
        Verimi,
        [EnumMember(Value = "nl_idin")]
        NlIdin
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyauthenticationToViewArchivedInput
    {
        [EnumMember(Value = "standard")]
        Standard,
        [EnumMember(Value = "sms_pin")]
        SmsPin,
        [EnumMember(Value = "se_bankid")]
        SeBankid,
        [EnumMember(Value = "no_bankid")]
        NoBankid,
        [EnumMember(Value = "dk_nemid")]
        DkNemid,
        [EnumMember(Value = "fi_tupas")]
        FiTupas,
        [EnumMember(Value = "verimi")]
        Verimi,
        [EnumMember(Value = "nl_idin")]
        NlIdin
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyauthenticationToSignInput
    {
        [EnumMember(Value = "standard")]
        Standard,
        [EnumMember(Value = "sms_pin")]
        SmsPin,
        [EnumMember(Value = "se_bankid")]
        SeBankid,
        [EnumMember(Value = "no_bankid")]
        NoBankid,
        [EnumMember(Value = "dk_nemid")]
        DkNemid,
        [EnumMember(Value = "fi_tupas")]
        FiTupas,
        [EnumMember(Value = "onfido_document_check")]
        OnfidoDocumentCheck,
        [EnumMember(Value = "onfido_document_and_photo_check")]
        OnfidoDocumentAndPhotoCheck
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyconfirmationInput
    {
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "mobile")]
        Mobile,
        [EnumMember(Value = "email_mobile")]
        EmailMobile,
        [EnumMember(Value = "email_link")]
        EmailLink,
        [EnumMember(Value = "email_link_mobile")]
        EmailLinkMobile,
        [EnumMember(Value = "none")]
        None
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyrequiredInput
    {
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyaddToSealedFileInput
    {
        Yes,
        No
    }

    public class PollSignedDocumentsResponse
    {
        [JsonProperty("pollTime")]
        public string PollTime { get; set; }

        [JsonProperty("documents")]
        public PollSignedDocumentsResponseDocumentsTypeItem[] Documents { get; set; }
    }

    public class PollSignedDocumentsResponseDocumentsTypeItem
    {
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Scriveesign;

    public partial class WorkflowManagedActions
    {
        public ScriveesignActions Scriveesign(string connectionId) => new ScriveesignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ScriveesignTriggers Scriveesign(string connectionId) => new ScriveesignTriggers(connectionId);
    }
}