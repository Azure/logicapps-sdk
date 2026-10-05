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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetDocJson(WorkflowValue<string> bodydocumentId)
        {
            WorkflowValue.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetDocStatus(WorkflowValue<string> bodydocumentId)
        {
            WorkflowValue.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetPartyStatus(WorkflowValue<string> bodydocumentId, WorkflowValue<string> bodypartyId)
        {
            WorkflowValue.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            WorkflowValue.Validate(bodypartyId, nameof(bodypartyId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildUpdatePartyEmail(WorkflowValue<string> bodydocumentId, WorkflowValue<string> bodypartyId, WorkflowValue<string> bodypartyEmail)
        {
            WorkflowValue.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            WorkflowValue.Validate(bodypartyId, nameof(bodypartyId), required: true);
            WorkflowValue.Validate(bodypartyEmail, nameof(bodypartyEmail), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildSendReminder(WorkflowValue<string> bodydocumentId)
        {
            WorkflowValue.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetDocumentPdfContent(WorkflowValue<string> bodydocumentId)
        {
            WorkflowValue.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildNewDocumentFromTemplate(WorkflowValue<string> templateIdDynamic)
        {
            WorkflowValue.Validate(templateIdDynamic, nameof(templateIdDynamic), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildStartSigning(WorkflowValue<string> bodydocumentId)
        {
            WorkflowValue.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateDocJson(WorkflowValue<string> bodydocumentId, WorkflowValue<string> bodydocumentJson)
        {
            WorkflowValue.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            WorkflowValue.Validate(bodydocumentJson, nameof(bodydocumentJson), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdatePartiesFields(WorkflowValue<string> templateIDDynamic, WorkflowValue<object> dynamicTemplateSchema = null)
        {
            WorkflowValue.Validate(templateIDDynamic, nameof(templateIDDynamic), required: true);
            WorkflowValue.Validate(dynamicTemplateSchema, nameof(dynamicTemplateSchema), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdatePartiesProperties(WorkflowValue<string> templateIDDynamic, WorkflowValue<object> dynamicTemplateMetaSchema = null)
        {
            WorkflowValue.Validate(templateIDDynamic, nameof(templateIDDynamic), required: true);
            WorkflowValue.Validate(dynamicTemplateMetaSchema, nameof(dynamicTemplateMetaSchema), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildSetFile(WorkflowValue<string> bodydocumentId, WorkflowValue<string> bodypdfContent)
        {
            WorkflowValue.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            WorkflowValue.Validate(bodypdfContent, nameof(bodypdfContent), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildNewFromPdf(WorkflowValue<string> bodypdfContent, WorkflowValue<bodyauthorRoleInput> bodyauthorRole)
        {
            WorkflowValue.Validate(bodypdfContent, nameof(bodypdfContent), required: true);
            WorkflowValue.Validate(bodyauthorRole, nameof(bodyauthorRole), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAppendFile(WorkflowValue<string> bodydocumentId, WorkflowValue<string> bodypdfContent)
        {
            WorkflowValue.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            WorkflowValue.Validate(bodypdfContent, nameof(bodypdfContent), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCancel(WorkflowValue<string> bodydocumentId)
        {
            WorkflowValue.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddParty(WorkflowValue<string> bodydocumentId, WorkflowValue<string> bodypartyEmail, WorkflowValue<bodypartyRoleInput> bodypartyRole, WorkflowValue<string> bodyfirstname = null, WorkflowValue<string> bodylastname = null, WorkflowValue<string> bodycompany = null, WorkflowValue<string> bodymobile = null, WorkflowValue<string> bodypersonalNumber = null, WorkflowValue<double> bodysignOrder = null, WorkflowValue<bodydeliveryMethodInput> bodydeliveryMethod = null, WorkflowValue<bodyauthenticationToViewInput> bodyauthenticationToView = null, WorkflowValue<bodyauthenticationToViewArchivedInput> bodyauthenticationToViewArchived = null, WorkflowValue<bodyauthenticationToSignInput> bodyauthenticationToSign = null, WorkflowValue<bodyconfirmationInput> bodyconfirmation = null)
        {
            WorkflowValue.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            WorkflowValue.Validate(bodypartyEmail, nameof(bodypartyEmail), required: true);
            WorkflowValue.Validate(bodypartyRole, nameof(bodypartyRole), required: true);
            WorkflowValue.Validate(bodyfirstname, nameof(bodyfirstname), required: false);
            WorkflowValue.Validate(bodylastname, nameof(bodylastname), required: false);
            WorkflowValue.Validate(bodycompany, nameof(bodycompany), required: false);
            WorkflowValue.Validate(bodymobile, nameof(bodymobile), required: false);
            WorkflowValue.Validate(bodypersonalNumber, nameof(bodypersonalNumber), required: false);
            WorkflowValue.Validate(bodysignOrder, nameof(bodysignOrder), required: false);
            WorkflowValue.Validate(bodydeliveryMethod, nameof(bodydeliveryMethod), required: false);
            WorkflowValue.Validate(bodyauthenticationToView, nameof(bodyauthenticationToView), required: false);
            WorkflowValue.Validate(bodyauthenticationToViewArchived, nameof(bodyauthenticationToViewArchived), required: false);
            WorkflowValue.Validate(bodyauthenticationToSign, nameof(bodyauthenticationToSign), required: false);
            WorkflowValue.Validate(bodyconfirmation, nameof(bodyconfirmation), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSetAuthorAttachment(WorkflowValue<string> bodydocumentId, WorkflowValue<string> bodyattachmentName, WorkflowValue<bodyrequiredInput> bodyrequired, WorkflowValue<bodyaddToSealedFileInput> bodyaddToSealedFile, WorkflowValue<string> bodyfileId = null, WorkflowValue<string> bodypdfContent = null)
        {
            WorkflowValue.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            WorkflowValue.Validate(bodyattachmentName, nameof(bodyattachmentName), required: true);
            WorkflowValue.Validate(bodyrequired, nameof(bodyrequired), required: true);
            WorkflowValue.Validate(bodyaddToSealedFile, nameof(bodyaddToSealedFile), required: true);
            WorkflowValue.Validate(bodyfileId, nameof(bodyfileId), required: false);
            WorkflowValue.Validate(bodypdfContent, nameof(bodypdfContent), required: false);
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
        public IBodyWorkflowTrigger<string> StartAndOnDocumentSign([WorkflowExpression] Func<string> bodydocumentId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<string> __BuildStartAndOnDocumentSign(WorkflowValue<string> bodydocumentId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
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

                return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildWebhookFromTemplateSign))]
        public IBodyWorkflowTrigger<string> WebhookFromTemplateSign([WorkflowExpression] Func<string> templateIdDynamic, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<string> __BuildWebhookFromTemplateSign(WorkflowValue<string> templateIdDynamic, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(templateIdDynamic, nameof(templateIdDynamic), required: true);
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

                return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        public IBodyWorkflowTrigger<PollSignedDocumentsResponse> PollSignedDocuments(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/polling/signed";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pollTime"] = Convert.ToString("init");
            return new ApiConnectionTrigger<PollSignedDocumentsResponse>(callPayload, triggerName, recurrence);
        }
    }

    public enum bodyauthorRoleInput
    {
        [EnumMember(Value = "signing_party")]
        SigningParty,
        [EnumMember(Value = "viewer")]
        Viewer
    }

    public enum bodypartyRoleInput
    {
        [EnumMember(Value = "signing_party")]
        SigningParty,
        [EnumMember(Value = "viewer")]
        Viewer,
        [EnumMember(Value = "approver")]
        Approver
    }

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

    public enum bodyrequiredInput
    {
        Yes,
        No
    }

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
