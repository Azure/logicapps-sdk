//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Scriveesign
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ScriveesignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<JToken> GetDocJson([WorkflowExpression] Func<string> bodydocumentId)
        {
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getdocumentjson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<string> GetDocStatus([WorkflowExpression] Func<string> bodydocumentId)
        {
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getdocumentstatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<string> GetPartyStatus([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodypartyId)
        {
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            SourceExpression.Validate(bodypartyId, nameof(bodypartyId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getpartystatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                bodypropCount++;
                body["partyId"] = SourceExpressionConverter.ConvertToken(bodypartyId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<JToken> UpdatePartyEmail([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodypartyId, [WorkflowExpression] Func<string> bodypartyEmail)
        {
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            SourceExpression.Validate(bodypartyId, nameof(bodypartyId), required: true);
            SourceExpression.Validate(bodypartyEmail, nameof(bodypartyEmail), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/updatepartyemail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                bodypropCount++;
                body["partyId"] = SourceExpressionConverter.ConvertToken(bodypartyId);
                bodypropCount++;
                body["partyEmail"] = SourceExpressionConverter.ConvertToken(bodypartyEmail);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<JToken> SendReminder([WorkflowExpression] Func<string> bodydocumentId)
        {
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/sendreminder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<string> GetDocumentPdfContent([WorkflowExpression] Func<string> bodydocumentId)
        {
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getdocumentpdfcontent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<string> NewDocumentFromTemplate([WorkflowExpression] Func<string> templateIdDynamic)
        {
            SourceExpression.Validate(templateIdDynamic, nameof(templateIdDynamic), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/newfromtemplate/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateIdDynamic, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<string> StartSigning([WorkflowExpression] Func<string> bodydocumentId)
        {
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/startsigning";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction UpdateDocJson([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodydocumentJson)
        {
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            SourceExpression.Validate(bodydocumentJson, nameof(bodydocumentJson), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/updatedocumentjson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                bodypropCount++;
                body["documentJson"] = SourceExpressionConverter.ConvertToken(bodydocumentJson);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction UpdatePartiesFields([WorkflowExpression] Func<string> templateIDDynamic, [WorkflowExpression] Func<object> dynamicTemplateSchema = null)
        {
            SourceExpression.Validate(templateIDDynamic, nameof(templateIDDynamic), required: true);
            SourceExpression.Validate(dynamicTemplateSchema, nameof(dynamicTemplateSchema), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/updatepartiesfields/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateIDDynamic, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(dynamicTemplateSchema);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction UpdatePartiesProperties([WorkflowExpression] Func<string> templateIDDynamic, [WorkflowExpression] Func<object> dynamicTemplateMetaSchema = null)
        {
            SourceExpression.Validate(templateIDDynamic, nameof(templateIDDynamic), required: true);
            SourceExpression.Validate(dynamicTemplateMetaSchema, nameof(dynamicTemplateMetaSchema), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/updatepartiesproperties/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateIDDynamic, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(dynamicTemplateMetaSchema);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<JToken> SetFile([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodypdfContent)
        {
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            SourceExpression.Validate(bodypdfContent, nameof(bodypdfContent), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/setfile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                bodypropCount++;
                body["pdfContent"] = SourceExpressionConverter.ConvertToken(bodypdfContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<string> NewFromPdf([WorkflowExpression] Func<string> bodypdfContent, [WorkflowExpression] Func<bodyauthorRoleInput> bodyauthorRole)
        {
            SourceExpression.Validate(bodypdfContent, nameof(bodypdfContent), required: true);
            SourceExpression.Validate(bodyauthorRole, nameof(bodyauthorRole), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/newfrompdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["pdfContent"] = SourceExpressionConverter.ConvertToken(bodypdfContent);
                bodypropCount++;
                body["authorRole"] = SourceExpressionConverter.Convert(bodyauthorRole);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction AppendFile([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodypdfContent)
        {
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            SourceExpression.Validate(bodypdfContent, nameof(bodypdfContent), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/appendfile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                bodypropCount++;
                body["pdfContent"] = SourceExpressionConverter.ConvertToken(bodypdfContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction Cancel([WorkflowExpression] Func<string> bodydocumentId)
        {
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/cancel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction AddParty([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodypartyEmail, [WorkflowExpression] Func<bodypartyRoleInput> bodypartyRole, [WorkflowExpression] Func<string> bodyfirstname = null, [WorkflowExpression] Func<string> bodylastname = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodymobile = null, [WorkflowExpression] Func<string> bodypersonalNumber = null, [WorkflowExpression] Func<double> bodysignOrder = null, [WorkflowExpression] Func<bodydeliveryMethodInput> bodydeliveryMethod = null, [WorkflowExpression] Func<bodyauthenticationToViewInput> bodyauthenticationToView = null, [WorkflowExpression] Func<bodyauthenticationToViewArchivedInput> bodyauthenticationToViewArchived = null, [WorkflowExpression] Func<bodyauthenticationToSignInput> bodyauthenticationToSign = null, [WorkflowExpression] Func<bodyconfirmationInput> bodyconfirmation = null)
        {
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            SourceExpression.Validate(bodypartyEmail, nameof(bodypartyEmail), required: true);
            SourceExpression.Validate(bodypartyRole, nameof(bodypartyRole), required: true);
            SourceExpression.Validate(bodyfirstname, nameof(bodyfirstname), required: false);
            SourceExpression.Validate(bodylastname, nameof(bodylastname), required: false);
            SourceExpression.Validate(bodycompany, nameof(bodycompany), required: false);
            SourceExpression.Validate(bodymobile, nameof(bodymobile), required: false);
            SourceExpression.Validate(bodypersonalNumber, nameof(bodypersonalNumber), required: false);
            SourceExpression.Validate(bodysignOrder, nameof(bodysignOrder), required: false);
            SourceExpression.Validate(bodydeliveryMethod, nameof(bodydeliveryMethod), required: false);
            SourceExpression.Validate(bodyauthenticationToView, nameof(bodyauthenticationToView), required: false);
            SourceExpression.Validate(bodyauthenticationToViewArchived, nameof(bodyauthenticationToViewArchived), required: false);
            SourceExpression.Validate(bodyauthenticationToSign, nameof(bodyauthenticationToSign), required: false);
            SourceExpression.Validate(bodyconfirmation, nameof(bodyconfirmation), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/addparty";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                bodypropCount++;
                body["partyEmail"] = SourceExpressionConverter.ConvertToken(bodypartyEmail);
                bodypropCount++;
                body["partyRole"] = SourceExpressionConverter.Convert(bodypartyRole);
                if (bodyfirstname != null)
                {
                    body["firstname"] = SourceExpressionConverter.ConvertToken(bodyfirstname);
                    bodypropCount++;
                }

                if (bodylastname != null)
                {
                    body["lastname"] = SourceExpressionConverter.ConvertToken(bodylastname);
                    bodypropCount++;
                }

                if (bodycompany != null)
                {
                    body["company"] = SourceExpressionConverter.ConvertToken(bodycompany);
                    bodypropCount++;
                }

                if (bodymobile != null)
                {
                    body["mobile"] = SourceExpressionConverter.ConvertToken(bodymobile);
                    bodypropCount++;
                }

                if (bodypersonalNumber != null)
                {
                    body["personalNumber"] = SourceExpressionConverter.ConvertToken(bodypersonalNumber);
                    bodypropCount++;
                }

                if (bodysignOrder != null)
                {
                    body["signOrder"] = SourceExpressionConverter.ConvertToken(bodysignOrder);
                    bodypropCount++;
                }

                if (bodydeliveryMethod != null)
                {
                    if (bodydeliveryMethod != null)
                    {
                        body["deliveryMethod"] = SourceExpressionConverter.Convert(bodydeliveryMethod);
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
                        body["authenticationToView"] = SourceExpressionConverter.Convert(bodyauthenticationToView);
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
                        body["authenticationToViewArchived"] = SourceExpressionConverter.Convert(bodyauthenticationToViewArchived);
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
                        body["authenticationToSign"] = SourceExpressionConverter.Convert(bodyauthenticationToSign);
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
                        body["confirmation"] = SourceExpressionConverter.Convert(bodyconfirmation);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction SetAuthorAttachment([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodyattachmentName, [WorkflowExpression] Func<bodyrequiredInput> bodyrequired, [WorkflowExpression] Func<bodyaddToSealedFileInput> bodyaddToSealedFile, [WorkflowExpression] Func<string> bodyfileId = null, [WorkflowExpression] Func<string> bodypdfContent = null)
        {
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            SourceExpression.Validate(bodyattachmentName, nameof(bodyattachmentName), required: true);
            SourceExpression.Validate(bodyrequired, nameof(bodyrequired), required: true);
            SourceExpression.Validate(bodyaddToSealedFile, nameof(bodyaddToSealedFile), required: true);
            SourceExpression.Validate(bodyfileId, nameof(bodyfileId), required: false);
            SourceExpression.Validate(bodypdfContent, nameof(bodypdfContent), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/setattachment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfileId != null)
                {
                    body["fileId"] = SourceExpressionConverter.ConvertToken(bodyfileId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                bodypropCount++;
                body["attachmentName"] = SourceExpressionConverter.ConvertToken(bodyattachmentName);
                bodypropCount++;
                body["required"] = SourceExpressionConverter.Convert(bodyrequired);
                bodypropCount++;
                body["addToSealedFile"] = SourceExpressionConverter.Convert(bodyaddToSealedFile);
                if (bodypdfContent != null)
                {
                    body["pdfContent"] = SourceExpressionConverter.ConvertToken(bodypdfContent);
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
    }

    public class ScriveesignTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<string> StartAndOnDocumentSign([WorkflowExpression] Func<string> bodydocumentId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhooks/signed/createandstart";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                body["webhookUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<string>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> WebhookFromTemplateSign([WorkflowExpression] Func<string> templateIdDynamic, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(templateIdDynamic, nameof(templateIdDynamic), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/webhooks/signedfromtemplate/create/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateIdDynamic, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["webhookUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<string>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PollSignedDocumentsResponse> PollSignedDocuments(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/polling/signed";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pollTime"] = Convert.ToString("init");
                return callPayload;
            }

            return new ApiConnectionTrigger<PollSignedDocumentsResponse>(BuildSourceInput, triggerName, recurrence);
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