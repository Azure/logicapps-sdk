//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Verified
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VerifiedActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<PostAuthenticateResponse> PostAuthenticate([WorkflowExpression] Func<int> withoutIpLock)
        {
            SourceExpression.Validate(withoutIpLock, nameof(withoutIpLock), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/auth";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["withoutIpLock"] = SourceExpressionConverter.ConvertO(withoutIpLock);
                return callPayload;
            }

            return new ApiConnectionAction<PostAuthenticateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Company> GetCompaniesCompanyId([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> companyId)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(companyId, nameof(companyId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/companies/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(companyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<Company>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Recipient[]> GetEnvelopesEnvelopeIdRecipients([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> xNamespace = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/recipients", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                return callPayload;
            }

            return new ApiConnectionAction<Recipient[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PostEnvelopesEnvelopeIdRecipients([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> bodygivenName, [WorkflowExpression] Func<string> bodyfamilyName, [WorkflowExpression] Func<bodylanguageInput> bodylanguage, [WorkflowExpression] Func<bodysigningMethodInput> bodysigningMethod, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyroleaction, [WorkflowExpression] Func<string> bodyrolelabel, [WorkflowExpression] Func<string> bodyrolename, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<bodynotificationMethodInput> bodynotificationMethod = null, [WorkflowExpression] Func<string> bodytelephone = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<bool> bodysecure = null, [WorkflowExpression] Func<bool> bodysms = null, [WorkflowExpression] Func<string> bodyssn = null, [WorkflowExpression] Func<string> bodybank = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            SourceExpression.Validate(bodygivenName, nameof(bodygivenName), required: true);
            SourceExpression.Validate(bodyfamilyName, nameof(bodyfamilyName), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            SourceExpression.Validate(bodysigningMethod, nameof(bodysigningMethod), required: true);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            SourceExpression.Validate(bodyroleaction, nameof(bodyroleaction), required: true);
            SourceExpression.Validate(bodyrolelabel, nameof(bodyrolelabel), required: true);
            SourceExpression.Validate(bodyrolename, nameof(bodyrolename), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            SourceExpression.Validate(bodynotificationMethod, nameof(bodynotificationMethod), required: false);
            SourceExpression.Validate(bodytelephone, nameof(bodytelephone), required: false);
            SourceExpression.Validate(bodyorder, nameof(bodyorder), required: false);
            SourceExpression.Validate(bodysecure, nameof(bodysecure), required: false);
            SourceExpression.Validate(bodysms, nameof(bodysms), required: false);
            SourceExpression.Validate(bodyssn, nameof(bodyssn), required: false);
            SourceExpression.Validate(bodybank, nameof(bodybank), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/recipients", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["givenName"] = SourceExpressionConverter.ConvertToken(bodygivenName);
                bodypropCount++;
                body["familyName"] = SourceExpressionConverter.ConvertToken(bodyfamilyName);
                bodypropCount++;
                body["language"] = SourceExpressionConverter.Convert(bodylanguage);
                bodypropCount++;
                body["signingMethod"] = SourceExpressionConverter.Convert(bodysigningMethod);
                if (bodynotificationMethod != null)
                {
                    body["notificationMethod"] = SourceExpressionConverter.Convert(bodynotificationMethod);
                    bodypropCount++;
                }

                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodytelephone != null)
                {
                    body["telephone"] = SourceExpressionConverter.ConvertToken(bodytelephone);
                    bodypropCount++;
                }

                if (bodyorder != null)
                {
                    body["order"] = SourceExpressionConverter.ConvertToken(bodyorder);
                    bodypropCount++;
                }

                var roleObject = new JObject();
                var roleObjectpropCount = 0;
                roleObjectpropCount++;
                roleObject["action"] = SourceExpressionConverter.ConvertToken(bodyroleaction);
                roleObjectpropCount++;
                roleObject["label"] = SourceExpressionConverter.ConvertToken(bodyrolelabel);
                roleObjectpropCount++;
                roleObject["name"] = SourceExpressionConverter.ConvertToken(bodyrolename);
                if (roleObjectpropCount > 0)
                {
                    body["role"] = roleObject;
                    bodypropCount++;
                }

                if (bodysecure != null)
                {
                    body["secure"] = SourceExpressionConverter.ConvertToken(bodysecure);
                    bodypropCount++;
                }

                if (bodysms != null)
                {
                    body["sms"] = SourceExpressionConverter.ConvertToken(bodysms);
                    bodypropCount++;
                }

                if (bodyssn != null)
                {
                    body["ssn"] = SourceExpressionConverter.ConvertToken(bodyssn);
                    bodypropCount++;
                }

                if (bodybank != null)
                {
                    body["bank"] = SourceExpressionConverter.ConvertToken(bodybank);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Recipient> GetEnvelopesEnvelopeIdRecipientsRecipientId([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> recipientId, [WorkflowExpression] Func<string> xNamespace = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            SourceExpression.Validate(recipientId, nameof(recipientId), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/recipients/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                return callPayload;
            }

            return new ApiConnectionAction<Recipient>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PutEnvelopesEnvelopeIdRecipientsRecipientId([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> recipientId, [WorkflowExpression] Func<string> bodygivenName, [WorkflowExpression] Func<string> bodyfamilyName, [WorkflowExpression] Func<bodylanguageInput> bodylanguage, [WorkflowExpression] Func<bodysigningMethodInput> bodysigningMethod, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyroleaction, [WorkflowExpression] Func<string> bodyrolelabel, [WorkflowExpression] Func<string> bodyrolename, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<bodynotificationMethodInput> bodynotificationMethod = null, [WorkflowExpression] Func<string> bodytelephone = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<bool> bodysecure = null, [WorkflowExpression] Func<bool> bodysms = null, [WorkflowExpression] Func<string> bodyssn = null, [WorkflowExpression] Func<string> bodybank = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            SourceExpression.Validate(recipientId, nameof(recipientId), required: true);
            SourceExpression.Validate(bodygivenName, nameof(bodygivenName), required: true);
            SourceExpression.Validate(bodyfamilyName, nameof(bodyfamilyName), required: true);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            SourceExpression.Validate(bodysigningMethod, nameof(bodysigningMethod), required: true);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            SourceExpression.Validate(bodyroleaction, nameof(bodyroleaction), required: true);
            SourceExpression.Validate(bodyrolelabel, nameof(bodyrolelabel), required: true);
            SourceExpression.Validate(bodyrolename, nameof(bodyrolename), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            SourceExpression.Validate(bodynotificationMethod, nameof(bodynotificationMethod), required: false);
            SourceExpression.Validate(bodytelephone, nameof(bodytelephone), required: false);
            SourceExpression.Validate(bodyorder, nameof(bodyorder), required: false);
            SourceExpression.Validate(bodysecure, nameof(bodysecure), required: false);
            SourceExpression.Validate(bodysms, nameof(bodysms), required: false);
            SourceExpression.Validate(bodyssn, nameof(bodyssn), required: false);
            SourceExpression.Validate(bodybank, nameof(bodybank), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/recipients/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["givenName"] = SourceExpressionConverter.ConvertToken(bodygivenName);
                bodypropCount++;
                body["familyName"] = SourceExpressionConverter.ConvertToken(bodyfamilyName);
                bodypropCount++;
                body["language"] = SourceExpressionConverter.Convert(bodylanguage);
                bodypropCount++;
                body["signingMethod"] = SourceExpressionConverter.Convert(bodysigningMethod);
                if (bodynotificationMethod != null)
                {
                    body["notificationMethod"] = SourceExpressionConverter.Convert(bodynotificationMethod);
                    bodypropCount++;
                }

                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodytelephone != null)
                {
                    body["telephone"] = SourceExpressionConverter.ConvertToken(bodytelephone);
                    bodypropCount++;
                }

                if (bodyorder != null)
                {
                    body["order"] = SourceExpressionConverter.ConvertToken(bodyorder);
                    bodypropCount++;
                }

                var roleObject = new JObject();
                var roleObjectpropCount = 0;
                roleObjectpropCount++;
                roleObject["action"] = SourceExpressionConverter.ConvertToken(bodyroleaction);
                roleObjectpropCount++;
                roleObject["label"] = SourceExpressionConverter.ConvertToken(bodyrolelabel);
                roleObjectpropCount++;
                roleObject["name"] = SourceExpressionConverter.ConvertToken(bodyrolename);
                if (roleObjectpropCount > 0)
                {
                    body["role"] = roleObject;
                    bodypropCount++;
                }

                if (bodysecure != null)
                {
                    body["secure"] = SourceExpressionConverter.ConvertToken(bodysecure);
                    bodypropCount++;
                }

                if (bodysms != null)
                {
                    body["sms"] = SourceExpressionConverter.ConvertToken(bodysms);
                    bodypropCount++;
                }

                if (bodyssn != null)
                {
                    body["ssn"] = SourceExpressionConverter.ConvertToken(bodyssn);
                    bodypropCount++;
                }

                if (bodybank != null)
                {
                    body["bank"] = SourceExpressionConverter.ConvertToken(bodybank);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<GetEnvelopesEnvelopeIdDocumentsDocumentIdFilesFileIdUrlResponse> GetEnvelopesEnvelopeIdDocumentsDocumentIdFilesFileIdUrl([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<bool> asObject = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            SourceExpression.Validate(asObject, nameof(asObject), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents/{1}/files/{2}/url", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (asObject != null)
                    callPayload.Queries["asObject"] = SourceExpressionConverter.ConvertO(asObject);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                return callPayload;
            }

            return new ApiConnectionAction<GetEnvelopesEnvelopeIdDocumentsDocumentIdFilesFileIdUrlResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Setting> GetCompaniesCompanyIdUsersUserIdSettings([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> companyId, [WorkflowExpression] Func<string> userId)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(companyId, nameof(companyId), required: true);
            SourceExpression.Validate(userId, nameof(userId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/companies/{0}/users/{1}/settings", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(companyId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<Setting>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Envelope> GetEnvelopesEnvelopeId([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> xNamespace = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                return callPayload;
            }

            return new ApiConnectionAction<Envelope>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction DeleteEnvelopesEnvelopeId([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> xNamespace = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PutEnvelopesEnvelopeId([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<bool> bodysequentialSigning = null, [WorkflowExpression] Func<string> bodygreeting = null, [WorkflowExpression] Func<string> bodyexpiration = null, [WorkflowExpression] Func<double> bodyautomaticReminders = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            SourceExpression.Validate(bodysequentialSigning, nameof(bodysequentialSigning), required: false);
            SourceExpression.Validate(bodygreeting, nameof(bodygreeting), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodyautomaticReminders, nameof(bodyautomaticReminders), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysequentialSigning != null)
                {
                    body["sequentialSigning"] = SourceExpressionConverter.ConvertToken(bodysequentialSigning);
                    bodypropCount++;
                }

                if (bodygreeting != null)
                {
                    body["greeting"] = SourceExpressionConverter.ConvertToken(bodygreeting);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                    bodypropCount++;
                }

                if (bodyautomaticReminders != null)
                {
                    body["automaticReminders"] = SourceExpressionConverter.ConvertToken(bodyautomaticReminders);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PutEnvelopesEnvelopeIdPublishStatus([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<bool> bodypublished, [WorkflowExpression] Func<string> xNamespace = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            SourceExpression.Validate(bodypublished, nameof(bodypublished), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/publish-status", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["published"] = SourceExpressionConverter.ConvertToken(bodypublished);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PostEnvelopesEnvelopeIdDocumentsDocumentIdTemplatesTemplateIdUserData([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> xNamespace = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(templateId, nameof(templateId), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents/{1}/templates/{2}/user-data", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PutEnvelopesEnvelopeIdAbortStatus([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/abort-status", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<File[]> GetEnvelopesEnvelopeIdDocumentsDocumentIdFiles([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> xNamespace = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents/{1}/files", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                return callPayload;
            }

            return new ApiConnectionAction<File[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<File> PostEnvelopesEnvelopeIdDocumentsDocumentIdFiles([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyfileType, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<string> bodyhash = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyfileType, nameof(bodyfileType), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            SourceExpression.Validate(bodyhash, nameof(bodyhash), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents/{1}/files", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["fileType"] = SourceExpressionConverter.ConvertToken(bodyfileType);
                if (bodyhash != null)
                {
                    body["hash"] = SourceExpressionConverter.ConvertToken(bodyhash);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<File>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<UserInfo> GetAuthUserinfo([WorkflowExpression] Func<string> token)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/auth/userinfo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<UserInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PostEnvelopesEnvelopeIdDocumentsDocumentIdStatusAborted([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> xNamespace = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents/{1}/status/aborted", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PutEnvelopesEnvelopeIdTrashStatus([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/trash-status", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<EnvelopeDescriptorString[]> GetQueryEnvelopes([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<string> filters = null, [WorkflowExpression] Func<int> from = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            SourceExpression.Validate(filters, nameof(filters), required: false);
            SourceExpression.Validate(from, nameof(from), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/query/envelopes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filters != null)
                    callPayload.Queries["filters"] = SourceExpressionConverter.ConvertO(filters);
                if (from != null)
                    callPayload.Queries["from"] = SourceExpressionConverter.ConvertO(from);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                return callPayload;
            }

            return new ApiConnectionAction<EnvelopeDescriptorString[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<EnvelopeDescriptorString[]> GetSearchEnvelopes([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<string> filters = null, [WorkflowExpression] Func<int> from = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            SourceExpression.Validate(filters, nameof(filters), required: false);
            SourceExpression.Validate(from, nameof(from), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/search/envelopes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filters != null)
                    callPayload.Queries["filters"] = SourceExpressionConverter.ConvertO(filters);
                if (from != null)
                    callPayload.Queries["from"] = SourceExpressionConverter.ConvertO(from);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                return callPayload;
            }

            return new ApiConnectionAction<EnvelopeDescriptorString[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Descriptor[]> GetEnvelopeDescriptors([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<string> filters = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            SourceExpression.Validate(filters, nameof(filters), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/envelope-descriptors";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filters != null)
                    callPayload.Queries["filters"] = SourceExpressionConverter.ConvertO(filters);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                return callPayload;
            }

            return new ApiConnectionAction<Descriptor[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<GetFlowsFlowIdJobsEnvelopeIdResponse> GetFlowsFlowIdJobsEnvelopeId([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> flowId, [WorkflowExpression] Func<string> xNamespace = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            SourceExpression.Validate(flowId, nameof(flowId), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/flows/{0}/jobs/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(flowId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                return callPayload;
            }

            return new ApiConnectionAction<GetFlowsFlowIdJobsEnvelopeIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Document> GetEnvelopesEnvelopeIdDocumentsDocumentId([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> xNamespace = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                return callPayload;
            }

            return new ApiConnectionAction<Document>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction DeleteEnvelopesEnvelopeIdDocumentsDocumentId([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> xNamespace = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopesResponse> PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopes([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeDescriptorId, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<string> bodysenderemail = null, [WorkflowExpression] Func<string> bodysendergivenName = null, [WorkflowExpression] Func<string> bodysenderfamilyName = null, [WorkflowExpression] Func<double> bodyautomaticReminders = null, [WorkflowExpression] Func<string> bodyexpiration = null, [WorkflowExpression] Func<bodydocumentsInputItem[]> bodydocuments = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(envelopeDescriptorId, nameof(envelopeDescriptorId), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            SourceExpression.Validate(bodysenderemail, nameof(bodysenderemail), required: false);
            SourceExpression.Validate(bodysendergivenName, nameof(bodysendergivenName), required: false);
            SourceExpression.Validate(bodysenderfamilyName, nameof(bodysenderfamilyName), required: false);
            SourceExpression.Validate(bodyautomaticReminders, nameof(bodyautomaticReminders), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodydocuments, nameof(bodydocuments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelope-descriptors/{0}/envelopes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeDescriptorId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                var senderObject = new JObject();
                var senderObjectpropCount = 0;
                if (bodysenderemail != null)
                {
                    senderObject["email"] = SourceExpressionConverter.ConvertToken(bodysenderemail);
                    senderObjectpropCount++;
                }

                if (bodysendergivenName != null)
                {
                    senderObject["givenName"] = SourceExpressionConverter.ConvertToken(bodysendergivenName);
                    senderObjectpropCount++;
                }

                if (bodysenderfamilyName != null)
                {
                    senderObject["familyName"] = SourceExpressionConverter.ConvertToken(bodysenderfamilyName);
                    senderObjectpropCount++;
                }

                if (senderObjectpropCount > 0)
                {
                    body["sender"] = senderObject;
                    bodypropCount++;
                }

                if (bodyautomaticReminders != null)
                {
                    body["automaticReminders"] = SourceExpressionConverter.ConvertToken(bodyautomaticReminders);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                    bodypropCount++;
                }

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

            return new ApiConnectionAction<PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Document[]> GetEnvelopesEnvelopeIdDocuments([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> xNamespace = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                return callPayload;
            }

            return new ApiConnectionAction<Document[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PostEnvelopesEnvelopeIdDocuments([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<int> bodydescriptorhash = null, [WorkflowExpression] Func<string> bodysource = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            SourceExpression.Validate(bodydescriptorhash, nameof(bodydescriptorhash), required: false);
            SourceExpression.Validate(bodysource, nameof(bodysource), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                var descriptorObject = new JObject();
                var descriptorObjectpropCount = 0;
                if (bodydescriptorhash != null)
                {
                    descriptorObject["hash"] = SourceExpressionConverter.ConvertToken(bodydescriptorhash);
                    descriptorObjectpropCount++;
                }

                if (descriptorObjectpropCount > 0)
                {
                    body["descriptor"] = descriptorObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodysource != null)
                {
                    body["source"] = SourceExpressionConverter.ConvertToken(bodysource);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<PostEnvelopesEnvelopeIdJobsGetSignLinkResponse> PostEnvelopesEnvelopeIdJobsGetSignLink([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<string> bodyrecipientid = null, [WorkflowExpression] Func<string> bodyredirectTo = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            SourceExpression.Validate(bodyrecipientid, nameof(bodyrecipientid), required: false);
            SourceExpression.Validate(bodyredirectTo, nameof(bodyredirectTo), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/jobs/get.sign.link", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                var recipientObject = new JObject();
                var recipientObjectpropCount = 0;
                if (bodyrecipientid != null)
                {
                    recipientObject["id"] = SourceExpressionConverter.ConvertToken(bodyrecipientid);
                    recipientObjectpropCount++;
                }

                if (recipientObjectpropCount > 0)
                {
                    body["recipient"] = recipientObject;
                    bodypropCount++;
                }

                if (bodyredirectTo != null)
                {
                    body["redirectTo"] = SourceExpressionConverter.ConvertToken(bodyredirectTo);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PostEnvelopesEnvelopeIdJobsGetSignLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<PostEnvelopeDescriptorsDefaultEnvelopesResponse> PostEnvelopeDescriptorsDefaultEnvelopes([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<string> bodysenderemail = null, [WorkflowExpression] Func<string> bodysendergivenName = null, [WorkflowExpression] Func<string> bodysenderfamilyName = null, [WorkflowExpression] Func<double> bodyautomaticReminders = null, [WorkflowExpression] Func<string> bodyexpiration = null, [WorkflowExpression] Func<bodydocumentsInputItem[]> bodydocuments = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            SourceExpression.Validate(bodysenderemail, nameof(bodysenderemail), required: false);
            SourceExpression.Validate(bodysendergivenName, nameof(bodysendergivenName), required: false);
            SourceExpression.Validate(bodysenderfamilyName, nameof(bodysenderfamilyName), required: false);
            SourceExpression.Validate(bodyautomaticReminders, nameof(bodyautomaticReminders), required: false);
            SourceExpression.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            SourceExpression.Validate(bodydocuments, nameof(bodydocuments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/envelope-descriptors/default/envelopes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                var senderObject = new JObject();
                var senderObjectpropCount = 0;
                if (bodysenderemail != null)
                {
                    senderObject["email"] = SourceExpressionConverter.ConvertToken(bodysenderemail);
                    senderObjectpropCount++;
                }

                if (bodysendergivenName != null)
                {
                    senderObject["givenName"] = SourceExpressionConverter.ConvertToken(bodysendergivenName);
                    senderObjectpropCount++;
                }

                if (bodysenderfamilyName != null)
                {
                    senderObject["familyName"] = SourceExpressionConverter.ConvertToken(bodysenderfamilyName);
                    senderObjectpropCount++;
                }

                if (senderObjectpropCount > 0)
                {
                    body["sender"] = senderObject;
                    bodypropCount++;
                }

                if (bodyautomaticReminders != null)
                {
                    body["automaticReminders"] = SourceExpressionConverter.ConvertToken(bodyautomaticReminders);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    body["expiration"] = SourceExpressionConverter.ConvertToken(bodyexpiration);
                    bodypropCount++;
                }

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

            return new ApiConnectionAction<PostEnvelopeDescriptorsDefaultEnvelopesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Descriptor> GetEnvelopeDescriptorsDefault([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<string> filters = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            SourceExpression.Validate(filters, nameof(filters), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/envelope-descriptors/default";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filters != null)
                    callPayload.Queries["filters"] = SourceExpressionConverter.ConvertO(filters);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                return callPayload;
            }

            return new ApiConnectionAction<Descriptor>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PostEnvelopesEnvelopIdJobsSendNotification([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<string> bodyenvelopegreeting = null, [WorkflowExpression] Func<string> bodyrecipientid = null)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(envelopeId, nameof(envelopeId), required: true);
            SourceExpression.Validate(xNamespace, nameof(xNamespace), required: false);
            SourceExpression.Validate(bodyenvelopegreeting, nameof(bodyenvelopegreeting), required: false);
            SourceExpression.Validate(bodyrecipientid, nameof(bodyrecipientid), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/jobs/send.notification", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = SourceExpressionConverter.ConvertO(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = SourceExpressionConverter.ConvertO(xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                var envelopeObject = new JObject();
                var envelopeObjectpropCount = 0;
                if (bodyenvelopegreeting != null)
                {
                    envelopeObject["greeting"] = SourceExpressionConverter.ConvertToken(bodyenvelopegreeting);
                    envelopeObjectpropCount++;
                }

                if (envelopeObjectpropCount > 0)
                {
                    body["envelope"] = envelopeObject;
                    bodypropCount++;
                }

                var recipientObject = new JObject();
                var recipientObjectpropCount = 0;
                if (bodyrecipientid != null)
                {
                    recipientObject["id"] = SourceExpressionConverter.ConvertToken(bodyrecipientid);
                    recipientObjectpropCount++;
                }

                if (recipientObjectpropCount > 0)
                {
                    body["recipient"] = recipientObject;
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

    public class VerifiedTriggers([ConnectionName] string connectionId)
    {
    }

    public class PostAuthenticateResponse
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }

    public class Company
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("regNumber")]
        public string RegNumber { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Recipient
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("role")]
        public RoleActionString Role { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("signingMethod")]
        public string SigningMethod { get; set; }

        [JsonProperty("notificationMethod")]
        public string NotificationMethod { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("notified")]
        public bool Notified { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("demandAttachment")]
        public bool DemandAttachment { get; set; }

        [JsonProperty("ssn")]
        public string Ssn { get; set; }

        [JsonProperty("bank")]
        public string Bank { get; set; }

        [JsonProperty("secure")]
        public bool Secure { get; set; }

        [JsonProperty("sms")]
        public bool Sms { get; set; }

        [JsonProperty("telephone")]
        public string Telephone { get; set; }

        [JsonProperty("signatures")]
        public JToken Signatures { get; set; }

        [JsonProperty("notifications")]
        public Notification[] Notifications { get; set; }
    }

    public class RoleActionString
    {
        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("numMax")]
        public int NumMax { get; set; }

        [JsonProperty("numMin")]
        public int NumMin { get; set; }

        [JsonProperty("roleName")]
        public string RoleName { get; set; }
    }

    public class Notification
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("details")]
        public JToken Details { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public enum bodylanguageInput
    {
        [EnumMember(Value = "nb-NO")]
        NbNO,
        [EnumMember(Value = "sv-SE")]
        SvSE,
        [EnumMember(Value = "da-DK")]
        DaDK,
        [EnumMember(Value = "fi-FI")]
        FiFI,
        [EnumMember(Value = "lt-LT")]
        LtLT,
        [EnumMember(Value = "lv-LV")]
        LvLV
    }

    public enum bodysigningMethodInput
    {
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "sms")]
        Sms,
        [EnumMember(Value = "bankid-no")]
        BankidNo,
        [EnumMember(Value = "bankid-se")]
        BankidSe,
        [EnumMember(Value = "bankid-dk")]
        BankidDk,
        [EnumMember(Value = "nets-esign-no")]
        NetsEsignNo,
        [EnumMember(Value = "nets-esign-se")]
        NetsEsignSe,
        [EnumMember(Value = "nets-esign-dk")]
        NetsEsignDk,
        [EnumMember(Value = "nets-esign-tupas")]
        NetsEsignTupas,
        [EnumMember(Value = "nets-eident-mobiilivarmenne")]
        NetsEidentMobiilivarmenne,
        [EnumMember(Value = "nets-eident-fi")]
        NetsEidentFi,
        [EnumMember(Value = "nets-eident-dk")]
        NetsEidentDk,
        [EnumMember(Value = "eideasy-ee-ideideasy-lv-id")]
        EideasyEeIdeideasyLvId,
        [EnumMember(Value = "eideasy-lt-id")]
        EideasyLtId,
        [EnumMember(Value = "touch-sign")]
        TouchSign
    }

    public enum bodynotificationMethodInput
    {
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "sms")]
        Sms
    }

    public class GetEnvelopesEnvelopeIdDocumentsDocumentIdFilesFileIdUrlResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Setting
    {
        [JsonProperty("global")]
        public string Global { get; set; }

        [JsonProperty("preferences")]
        public SettingPreferencesType Preferences { get; set; }
    }

    public class SettingPreferencesType
    {
        [JsonProperty("signatoryLanguage")]
        public string SignatoryLanguage { get; set; }

        [JsonProperty("greeting")]
        public string Greeting { get; set; }

        [JsonProperty("signingMethod")]
        public string SigningMethod { get; set; }

        [JsonProperty("reminderOffset")]
        public string ReminderOffset { get; set; }
    }

    public class Envelope
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("published")]
        public bool Published { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("aborted")]
        public bool Aborted { get; set; }

        [JsonProperty("trashed")]
        public bool Trashed { get; set; }

        [JsonProperty("sequentialSigning")]
        public bool SequentialSigning { get; set; }

        [JsonProperty("automaticReminders")]
        public int AutomaticReminders { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("expired")]
        public bool Expired { get; set; }

        [JsonProperty("flow")]
        public Flow Flow { get; set; }

        [JsonProperty("descriptor")]
        public Descriptor Descriptor { get; set; }

        [JsonProperty("sender")]
        public Person Sender { get; set; }

        [JsonProperty("documents")]
        public Document[] Documents { get; set; }

        [JsonProperty("recipients")]
        public Recipient[] Recipients { get; set; }

        [JsonProperty("tags")]
        public JToken[] Tags { get; set; }

        [JsonProperty("owners")]
        public Person[] Owners { get; set; }
    }

    public class Flow
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Descriptor
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }

        [JsonProperty("expired")]
        public bool Expired { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("mandatory")]
        public bool Mandatory { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("roles")]
        public Role[] Roles { get; set; }

        [JsonProperty("owners")]
        public Person[] Owners { get; set; }

        [JsonProperty("flow")]
        public Flow Flow { get; set; }

        [JsonProperty("defaultValues")]
        public DefaultValues DefaultValues { get; set; }

        [JsonProperty("instances")]
        public JToken[] Instances { get; set; }
    }

    public class Role
    {
        [JsonProperty("action")]
        public RoleActionType Action { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("numMax")]
        public int NumMax { get; set; }

        [JsonProperty("numMin")]
        public int NumMin { get; set; }

        [JsonProperty("roleName")]
        public string RoleName { get; set; }
    }

    public class RoleActionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("methods")]
        public string[] Methods { get; set; }
    }

    public class Person
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }
    }

    public class DefaultValues
    {
        [JsonProperty("signer")]
        public Person Signer { get; set; }

        [JsonProperty("reviewer")]
        public Person Reviewer { get; set; }
    }

    public class Document
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("hash")]
        public int Hash { get; set; }

        [JsonProperty("numMax")]
        public int NumMax { get; set; }

        [JsonProperty("numMin")]
        public int NumMin { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("rejected")]
        public bool Rejected { get; set; }

        [JsonProperty("signed")]
        public bool Signed { get; set; }

        [JsonProperty("trashed")]
        public bool Trashed { get; set; }

        [JsonProperty("aborted")]
        public bool Aborted { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("attachments")]
        public Attachment[] Attachments { get; set; }

        [JsonProperty("flow")]
        public Flow Flow { get; set; }

        [JsonProperty("roles")]
        public Role[] Roles { get; set; }

        [JsonProperty("template")]
        public Template Template { get; set; }

        [JsonProperty("descriptor")]
        public Descriptor Descriptor { get; set; }

        [JsonProperty("signatures")]
        public Signature[] Signatures { get; set; }
    }

    public class Attachment
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("numMax")]
        public int NumMax { get; set; }

        [JsonProperty("numMin")]
        public int NumMin { get; set; }

        [JsonProperty("hash")]
        public int Hash { get; set; }
    }

    public class Template
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("pdfHtml")]
        public string PdfHtml { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("published")]
        public bool Published { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("aborted")]
        public bool Aborted { get; set; }
    }

    public class Signature
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }

    public class File
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("fileType")]
        public string FileType { get; set; }

        [JsonProperty("storagePath")]
        public string StoragePath { get; set; }

        [JsonProperty("uploadedAt")]
        public string UploadedAt { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("owners")]
        public FileOwnersTypeItem[] Owners { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }
    }

    public class FileOwnersTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }
    }

    public class UserInfo
    {
        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("metadata")]
        public UserInfoMetadataType Metadata { get; set; }

        [JsonProperty("missingPassword")]
        public bool MissingPassword { get; set; }

        [JsonProperty("isEnabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("roles")]
        public Role[] Roles { get; set; }

        [JsonProperty("validated")]
        public bool Validated { get; set; }
    }

    public class UserInfoMetadataType
    {
        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class EnvelopeDescriptorString
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("published")]
        public bool Published { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("aborted")]
        public bool Aborted { get; set; }

        [JsonProperty("trashed")]
        public bool Trashed { get; set; }

        [JsonProperty("sequentialSigning")]
        public bool SequentialSigning { get; set; }

        [JsonProperty("automaticReminders")]
        public int AutomaticReminders { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("expired")]
        public bool Expired { get; set; }

        [JsonProperty("flow")]
        public Flow Flow { get; set; }

        [JsonProperty("descriptor")]
        public string Descriptor { get; set; }

        [JsonProperty("sender")]
        public Person Sender { get; set; }

        [JsonProperty("documents")]
        public Document[] Documents { get; set; }

        [JsonProperty("recipients")]
        public Recipient[] Recipients { get; set; }

        [JsonProperty("tags")]
        public JToken[] Tags { get; set; }

        [JsonProperty("owners")]
        public Person[] Owners { get; set; }
    }

    public class GetFlowsFlowIdJobsEnvelopeIdResponse
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }

    public class PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopesResponse
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }
    }

    public class bodydocumentsInputItem
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    public class PostEnvelopesEnvelopeIdJobsGetSignLinkResponse
    {
        [JsonProperty("getSignLink")]
        public PostEnvelopesEnvelopeIdJobsGetSignLinkResponseGetSignLinkType GetSignLink { get; set; }
    }

    public class PostEnvelopesEnvelopeIdJobsGetSignLinkResponseGetSignLinkType
    {
        [JsonProperty("recipient")]
        public PostEnvelopesEnvelopeIdJobsGetSignLinkResponseGetSignLinkTypeRecipientType Recipient { get; set; }
    }

    public class PostEnvelopesEnvelopeIdJobsGetSignLinkResponseGetSignLinkTypeRecipientType
    {
        [JsonProperty("{recipient-id}")]
        public PostEnvelopesEnvelopeIdJobsGetSignLinkResponseGetSignLinkTypeRecipientTypeRecipientIdType RecipientId { get; set; }
    }

    public class PostEnvelopesEnvelopeIdJobsGetSignLinkResponseGetSignLinkTypeRecipientTypeRecipientIdType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class PostEnvelopeDescriptorsDefaultEnvelopesResponse
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Verified;

    public partial class WorkflowManagedActions
    {
        public VerifiedActions Verified(string connectionId) => new VerifiedActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public VerifiedTriggers Verified(string connectionId) => new VerifiedTriggers(connectionId);
    }
}