//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Legalesign
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LegalesignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<UserDetailResponse> GetUser([WorkflowExpression] Func<string> userId)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/user/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UserDetailResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<MemberListResponse> GetMembers([WorkflowExpression] Func<string> group = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(group, nameof(group), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/member/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (group != null)
                    callPayload.Queries["group"] = SourceExpressionConverter.ConvertO(group);
                callPayload.Queries["limit"] = Convert.ToString(20);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<MemberListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<MemberResponse> GetMember([WorkflowExpression] Func<string> memberId)
        {
            SourceExpression.Validate(memberId, nameof(memberId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/member/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(memberId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MemberResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<AttachmentResponse> GetAttachment([WorkflowExpression] Func<string> attachId)
        {
            SourceExpression.Validate(attachId, nameof(attachId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/attachment/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AttachmentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IWorkflowAction DeleteAttachment([WorkflowExpression] Func<string> attachId)
        {
            SourceExpression.Validate(attachId, nameof(attachId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/attachment/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<AttachmentListResponse> GetAttachments([WorkflowExpression] Func<string> group = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(group, nameof(group), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/attachment/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (group != null)
                    callPayload.Queries["group"] = SourceExpressionConverter.ConvertO(group);
                callPayload.Queries["limit"] = Convert.ToString(20);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<AttachmentListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IWorkflowAction PostAttachment([WorkflowExpression] Func<string> bodygroup, [WorkflowExpression] Func<string> bodypdfFile, [WorkflowExpression] Func<string> bodyfilename, [WorkflowExpression] Func<string> bodyuser = null, [WorkflowExpression] Func<string> bodydescription = null)
        {
            SourceExpression.Validate(bodygroup, nameof(bodygroup), required: true);
            SourceExpression.Validate(bodypdfFile, nameof(bodypdfFile), required: true);
            SourceExpression.Validate(bodyfilename, nameof(bodyfilename), required: true);
            SourceExpression.Validate(bodyuser, nameof(bodyuser), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/attachment/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["group"] = SourceExpressionConverter.ConvertToken(bodygroup);
                bodypropCount++;
                body["pdf_file"] = SourceExpressionConverter.ConvertToken(bodypdfFile);
                bodypropCount++;
                body["filename"] = SourceExpressionConverter.ConvertToken(bodyfilename);
                if (bodyuser != null)
                {
                    body["user"] = SourceExpressionConverter.ConvertToken(bodyuser);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<GetDocumentFieldsResponseItem[]> GetDocumentFields([WorkflowExpression] Func<string> docId)
        {
            SourceExpression.Validate(docId, nameof(docId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document/{0}/fields/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentFieldsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<object> GetDocumentAuditLog([WorkflowExpression] Func<string> docId)
        {
            SourceExpression.Validate(docId, nameof(docId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document/{0}/auditlog/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<object> GetDocumentPdf([WorkflowExpression] Func<string> docId)
        {
            SourceExpression.Validate(docId, nameof(docId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pdf/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IWorkflowAction DeleteDocument([WorkflowExpression] Func<string> docId)
        {
            SourceExpression.Validate(docId, nameof(docId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document/{0}/delete/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<DocumentResponseDetail> GetDocument([WorkflowExpression] Func<string> docId)
        {
            SourceExpression.Validate(docId, nameof(docId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DocumentResponseDetail>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IWorkflowAction UpdateArchiveDocument([WorkflowExpression] Func<string> docId, [WorkflowExpression] Func<string> email = null)
        {
            SourceExpression.Validate(docId, nameof(docId), required: true);
            SourceExpression.Validate(email, nameof(email), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/document/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (email != null)
                    callPayload.Queries["email"] = SourceExpressionConverter.ConvertO(email);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<SignerResponse> GetRecipient([WorkflowExpression] Func<string> recipientId)
        {
            SourceExpression.Validate(recipientId, nameof(recipientId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/signer/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SignerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IWorkflowAction PostSignerReminder([WorkflowExpression] Func<string> recipientId, [WorkflowExpression] Func<string> bodytext = null)
        {
            SourceExpression.Validate(recipientId, nameof(recipientId), required: true);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/signer/{0}/send-reminder/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IWorkflowAction GetSignerLink([WorkflowExpression] Func<string> recipientId)
        {
            SourceExpression.Validate(recipientId, nameof(recipientId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/signer/{0}/new-link/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<GetSignerFieldsResponseItem[]> GetSignerFields([WorkflowExpression] Func<string> recipientId)
        {
            SourceExpression.Validate(recipientId, nameof(recipientId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/signer/{0}/fields1/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetSignerFieldsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<GetSignerRejectionResponse> GetSignerRejection([WorkflowExpression] Func<string> recipientId)
        {
            SourceExpression.Validate(recipientId, nameof(recipientId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/signer/{0}/rejection/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetSignerRejectionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<DocumentListResponse> GetDocuments([WorkflowExpression] Func<string> group, [WorkflowExpression] Func<string> archived = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> status = null, [WorkflowExpression] Func<string> nosigners = null, [WorkflowExpression] Func<string> createdGt = null, [WorkflowExpression] Func<string> modifiedGt = null)
        {
            SourceExpression.Validate(group, nameof(group), required: true);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            SourceExpression.Validate(email, nameof(email), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(nosigners, nameof(nosigners), required: false);
            SourceExpression.Validate(createdGt, nameof(createdGt), required: false);
            SourceExpression.Validate(modifiedGt, nameof(modifiedGt), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/document/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["group"] = SourceExpressionConverter.ConvertO(group);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                if (email != null)
                    callPayload.Queries["email"] = SourceExpressionConverter.ConvertO(email);
                callPayload.Queries["limit"] = Convert.ToString(20);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                if (nosigners != null)
                    callPayload.Queries["nosigners"] = SourceExpressionConverter.ConvertO(nosigners);
                if (createdGt != null)
                    callPayload.Queries["created_gt"] = SourceExpressionConverter.ConvertO(createdGt);
                if (modifiedGt != null)
                    callPayload.Queries["modified_gt"] = SourceExpressionConverter.ConvertO(modifiedGt);
                return callPayload;
            }

            return new ApiConnectionAction<DocumentListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IWorkflowAction PostDocument([WorkflowExpression] Func<string> bodygroup, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodytemplatepdf, [WorkflowExpression] Func<DocumentSignerPost[]> bodysigners, [WorkflowExpression] Func<int> bodysignatureType = null, [WorkflowExpression] Func<bool> bodyappendPdf = null, [WorkflowExpression] Func<bool> bodyautoArchive = null, [WorkflowExpression] Func<bool> bodydoEmail = null, [WorkflowExpression] Func<string> bodyccEmails = null, [WorkflowExpression] Func<bool> bodyconvertSenderToSigner = null, [WorkflowExpression] Func<string> bodypdfPassword = null, [WorkflowExpression] Func<bodypdfPasswordTypeInput> bodypdfPasswordType = null, [WorkflowExpression] Func<string> bodyredirect = null, [WorkflowExpression] Func<string> bodyreminders = null, [WorkflowExpression] Func<bool> bodyreturnSignerLinks = null, [WorkflowExpression] Func<bool> bodysignersInOrder = null, [WorkflowExpression] Func<bool> bodystrictFields = null, [WorkflowExpression] Func<string> bodytag = null, [WorkflowExpression] Func<string> bodytag1 = null, [WorkflowExpression] Func<string> bodytag2 = null, [WorkflowExpression] Func<string> bodyuser = null)
        {
            SourceExpression.Validate(bodygroup, nameof(bodygroup), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodytemplatepdf, nameof(bodytemplatepdf), required: true);
            SourceExpression.Validate(bodysigners, nameof(bodysigners), required: true);
            SourceExpression.Validate(bodysignatureType, nameof(bodysignatureType), required: false);
            SourceExpression.Validate(bodyappendPdf, nameof(bodyappendPdf), required: false);
            SourceExpression.Validate(bodyautoArchive, nameof(bodyautoArchive), required: false);
            SourceExpression.Validate(bodydoEmail, nameof(bodydoEmail), required: false);
            SourceExpression.Validate(bodyccEmails, nameof(bodyccEmails), required: false);
            SourceExpression.Validate(bodyconvertSenderToSigner, nameof(bodyconvertSenderToSigner), required: false);
            SourceExpression.Validate(bodypdfPassword, nameof(bodypdfPassword), required: false);
            SourceExpression.Validate(bodypdfPasswordType, nameof(bodypdfPasswordType), required: false);
            SourceExpression.Validate(bodyredirect, nameof(bodyredirect), required: false);
            SourceExpression.Validate(bodyreminders, nameof(bodyreminders), required: false);
            SourceExpression.Validate(bodyreturnSignerLinks, nameof(bodyreturnSignerLinks), required: false);
            SourceExpression.Validate(bodysignersInOrder, nameof(bodysignersInOrder), required: false);
            SourceExpression.Validate(bodystrictFields, nameof(bodystrictFields), required: false);
            SourceExpression.Validate(bodytag, nameof(bodytag), required: false);
            SourceExpression.Validate(bodytag1, nameof(bodytag1), required: false);
            SourceExpression.Validate(bodytag2, nameof(bodytag2), required: false);
            SourceExpression.Validate(bodyuser, nameof(bodyuser), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/document/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["group"] = SourceExpressionConverter.ConvertToken(bodygroup);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["templatepdf"] = SourceExpressionConverter.ConvertToken(bodytemplatepdf);
                bodypropCount++;
                body["signers"] = SourceExpressionConverter.ConvertToken(bodysigners);
                if (bodysignatureType != null)
                {
                    if (bodysignatureType != null)
                    {
                        body["signature_type"] = SourceExpressionConverter.ConvertToken(bodysignatureType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["signature_type"] = 4;
                    bodypropCount++;
                }

                if (bodyappendPdf != null)
                {
                    body["append_pdf"] = SourceExpressionConverter.ConvertToken(bodyappendPdf);
                    bodypropCount++;
                }

                if (bodyautoArchive != null)
                {
                    if (bodyautoArchive != null)
                    {
                        body["auto_archive"] = SourceExpressionConverter.ConvertToken(bodyautoArchive);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["auto_archive"] = true;
                    bodypropCount++;
                }

                if (bodydoEmail != null)
                {
                    if (bodydoEmail != null)
                    {
                        body["do_email"] = SourceExpressionConverter.ConvertToken(bodydoEmail);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["do_email"] = true;
                    bodypropCount++;
                }

                if (bodyccEmails != null)
                {
                    body["cc_emails"] = SourceExpressionConverter.ConvertToken(bodyccEmails);
                    bodypropCount++;
                }

                if (bodyconvertSenderToSigner != null)
                {
                    if (bodyconvertSenderToSigner != null)
                    {
                        body["convert_sender_to_signer"] = SourceExpressionConverter.ConvertToken(bodyconvertSenderToSigner);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["convert_sender_to_signer"] = false;
                    bodypropCount++;
                }

                if (bodypdfPassword != null)
                {
                    body["pdf_password"] = SourceExpressionConverter.ConvertToken(bodypdfPassword);
                    bodypropCount++;
                }

                if (bodypdfPasswordType != null)
                {
                    body["pdf_password_type"] = SourceExpressionConverter.Convert(bodypdfPasswordType);
                    bodypropCount++;
                }

                var pdftextObject = new JObject();
                var pdftextObjectpropCount = 0;
                if (pdftextObjectpropCount > 0)
                {
                    body["pdftext"] = pdftextObject;
                    bodypropCount++;
                }

                if (bodyredirect != null)
                {
                    body["redirect"] = SourceExpressionConverter.ConvertToken(bodyredirect);
                    bodypropCount++;
                }

                if (bodyreminders != null)
                {
                    body["reminders"] = SourceExpressionConverter.ConvertToken(bodyreminders);
                    bodypropCount++;
                }

                if (bodyreturnSignerLinks != null)
                {
                    if (bodyreturnSignerLinks != null)
                    {
                        body["return_signer_links"] = SourceExpressionConverter.ConvertToken(bodyreturnSignerLinks);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["return_signer_links"] = false;
                    bodypropCount++;
                }

                if (bodysignersInOrder != null)
                {
                    body["signers_in_order"] = SourceExpressionConverter.ConvertToken(bodysignersInOrder);
                    bodypropCount++;
                }

                var signertextObject = new JObject();
                var signertextObjectpropCount = 0;
                if (signertextObjectpropCount > 0)
                {
                    body["signertext"] = signertextObject;
                    bodypropCount++;
                }

                if (bodystrictFields != null)
                {
                    if (bodystrictFields != null)
                    {
                        body["strict_fields"] = SourceExpressionConverter.ConvertToken(bodystrictFields);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["strict_fields"] = false;
                    bodypropCount++;
                }

                if (bodytag != null)
                {
                    body["tag"] = SourceExpressionConverter.ConvertToken(bodytag);
                    bodypropCount++;
                }

                if (bodytag1 != null)
                {
                    body["tag1"] = SourceExpressionConverter.ConvertToken(bodytag1);
                    bodypropCount++;
                }

                if (bodytag2 != null)
                {
                    body["tag2"] = SourceExpressionConverter.ConvertToken(bodytag2);
                    bodypropCount++;
                }

                if (bodyuser != null)
                {
                    body["user"] = SourceExpressionConverter.ConvertToken(bodyuser);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<TemplatePdfResponse> GetPdfTemplate([WorkflowExpression] Func<string> pdfId)
        {
            SourceExpression.Validate(pdfId, nameof(pdfId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/templatepdf/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pdfId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TemplatePdfResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IWorkflowAction GetPdfTemplateEditLink([WorkflowExpression] Func<string> pdfId, [WorkflowExpression] Func<bool> hideSenderFields = null, [WorkflowExpression] Func<string> cssBodyBackgroundcolor = null)
        {
            SourceExpression.Validate(pdfId, nameof(pdfId), required: true);
            SourceExpression.Validate(hideSenderFields, nameof(hideSenderFields), required: false);
            SourceExpression.Validate(cssBodyBackgroundcolor, nameof(cssBodyBackgroundcolor), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/templatepdf/{0}/edit-link/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pdfId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (hideSenderFields != null)
                    callPayload.Queries["hide_sender_fields"] = SourceExpressionConverter.ConvertO(hideSenderFields);
                if (cssBodyBackgroundcolor != null)
                    callPayload.Queries["css_body_backgroundcolor"] = SourceExpressionConverter.ConvertO(cssBodyBackgroundcolor);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<TemplatePdfListResponse> GetPdfTemplates([WorkflowExpression] Func<string> group = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(group, nameof(group), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/templatepdf/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (group != null)
                    callPayload.Queries["group"] = SourceExpressionConverter.ConvertO(group);
                callPayload.Queries["limit"] = Convert.ToString(20);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<TemplatePdfListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IWorkflowAction PostPdfTemplate([WorkflowExpression] Func<string> bodygroup, [WorkflowExpression] Func<string> bodypdfFile, [WorkflowExpression] Func<bool> bodyarchiveUponSend = null, [WorkflowExpression] Func<bool> bodyprocessTags = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyuser = null)
        {
            SourceExpression.Validate(bodygroup, nameof(bodygroup), required: true);
            SourceExpression.Validate(bodypdfFile, nameof(bodypdfFile), required: true);
            SourceExpression.Validate(bodyarchiveUponSend, nameof(bodyarchiveUponSend), required: false);
            SourceExpression.Validate(bodyprocessTags, nameof(bodyprocessTags), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodyuser, nameof(bodyuser), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/templatepdf/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyarchiveUponSend != null)
                {
                    if (bodyarchiveUponSend != null)
                    {
                        body["archive_upon_send"] = SourceExpressionConverter.ConvertToken(bodyarchiveUponSend);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["archive_upon_send"] = false;
                    bodypropCount++;
                }

                bodypropCount++;
                body["group"] = SourceExpressionConverter.ConvertToken(bodygroup);
                bodypropCount++;
                body["pdf_file"] = SourceExpressionConverter.ConvertToken(bodypdfFile);
                if (bodyprocessTags != null)
                {
                    body["process_tags"] = SourceExpressionConverter.ConvertToken(bodyprocessTags);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyuser != null)
                {
                    body["user"] = SourceExpressionConverter.ConvertToken(bodyuser);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<GroupListResponse> GetGroups([WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null)
        {
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/group/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<GroupListResponse>(BuildSourceInput);
        }
    }

    public class LegalesignTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger RecipientTrigger([WorkflowExpression] Func<bodyeventFilterInput> bodyeventFilter, [WorkflowExpression] Func<string> bodygroup = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyeventFilter, nameof(bodyeventFilter), required: true);
            SourceExpression.Validate(bodygroup, nameof(bodygroup), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/subscribe/recipient/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "@listCallbackUrl()";
                bodypropCount++;
                body["notify"] = "realtime";
                bodypropCount++;
                bodypropCount++;
                body["eventFilter"] = SourceExpressionConverter.Convert(bodyeventFilter);
                if (bodygroup != null)
                {
                    body["group"] = SourceExpressionConverter.ConvertToken(bodygroup);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger DocumentTrigger([WorkflowExpression] Func<bodyeventFilterInput> bodyeventFilter, [WorkflowExpression] Func<string> bodygroup = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyeventFilter, nameof(bodyeventFilter), required: true);
            SourceExpression.Validate(bodygroup, nameof(bodygroup), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/subscribe/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "@listCallbackUrl()";
                bodypropCount++;
                body["notify"] = "realtime";
                bodypropCount++;
                bodypropCount++;
                body["eventFilter"] = SourceExpressionConverter.Convert(bodyeventFilter);
                if (bodygroup != null)
                {
                    body["group"] = SourceExpressionConverter.ConvertToken(bodygroup);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class UserDetailResponse
    {
        [JsonProperty("date_joined")]
        public string DateJoined { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("groups")]
        public string[] Groups { get; set; }

        [JsonProperty("last_login")]
        public string LastLogin { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceUri { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public class MemberListResponse
    {
        [JsonProperty("meta")]
        public ListMeta Meta { get; set; }

        [JsonProperty("objects")]
        public MemberResponse[] Objects { get; set; }
    }

    public class ListMeta
    {
        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    public class MemberResponse
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("permission")]
        public PermissionsEnum Permission { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceUri { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }

    public enum PermissionsEnum
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "6")]
        _6
    }

    public class AttachmentResponse
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceUri { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public class AttachmentListResponse
    {
        [JsonProperty("meta")]
        public ListMeta Meta { get; set; }

        [JsonProperty("objects")]
        public AttachmentListResponseObjectsTypeItem[] Objects { get; set; }
    }

    public class AttachmentListResponseObjectsTypeItem
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceUri { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public class GetDocumentFieldsResponseItem
    {
        [JsonProperty("element_type")]
        public string ElementType { get; set; }

        [JsonProperty("fieldorder")]
        public int Fieldorder { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("label_extra")]
        public string LabelExtra { get; set; }

        [JsonProperty("signer")]
        public int Signer { get; set; }

        [JsonProperty("state")]
        public bool State { get; set; }

        [JsonProperty("validation")]
        public int Validation { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DocumentResponseDetail
    {
        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("auto_archive")]
        public bool AutoArchive { get; set; }

        [JsonProperty("cc_emails")]
        public string CcEmails { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("do_email")]
        public bool DoEmail { get; set; }

        [JsonProperty("download_final")]
        public bool DownloadFinal { get; set; }

        [JsonProperty("footer")]
        public string Footer { get; set; }

        [JsonProperty("footer_height")]
        public int FooterHeight { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("has_fields")]
        public bool HasFields { get; set; }

        [JsonProperty("hash_value")]
        public string HashValue { get; set; }

        [JsonProperty("header")]
        public string Header { get; set; }

        [JsonProperty("header_height")]
        public int HeaderHeight { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pdf_password")]
        public string PdfPassword { get; set; }

        [JsonProperty("pdf_password_type")]
        public string PdfPasswordType { get; set; }

        [JsonProperty("pdftext")]
        public string Pdftext { get; set; }

        [JsonProperty("redirect")]
        public string Redirect { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceUri { get; set; }

        [JsonProperty("return_signer_links")]
        public bool ReturnSignerLinks { get; set; }

        [JsonProperty("sign_mouse")]
        public bool SignMouse { get; set; }

        [JsonProperty("sign_time")]
        public string SignTime { get; set; }

        [JsonProperty("sign_type")]
        public bool SignType { get; set; }

        [JsonProperty("sign_upload")]
        public bool SignUpload { get; set; }

        [JsonProperty("signature_placement")]
        public int SignaturePlacement { get; set; }

        [JsonProperty("signature_type")]
        public int SignatureType { get; set; }

        [JsonProperty("signers")]
        public JToken[][] Signers { get; set; }

        [JsonProperty("signer_objects")]
        public DocumentResponseDetailSignerObjectsTypeItem[] SignerObjects { get; set; }

        [JsonProperty("signers_in_order")]
        public bool SignersInOrder { get; set; }

        [JsonProperty("status")]
        public DocumentStatusEnum Status { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("tag1")]
        public string Tag1 { get; set; }

        [JsonProperty("tag2")]
        public string Tag2 { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("templatepdf")]
        public string Templatepdf { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public class DocumentResponseDetailSignerObjectsTypeItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("tel")]
        public string Tel { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceUri { get; set; }

        [JsonProperty("role")]
        public DocumentResponseDetailSignerObjectsTypeItemRoleType Role { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public enum DocumentResponseDetailSignerObjectsTypeItemRoleType
    {
        [EnumMember(Value = "signer")]
        Signer,
        [EnumMember(Value = "approver")]
        Approver,
        [EnumMember(Value = "witness")]
        Witness
    }

    public enum DocumentStatusEnum
    {
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "20")]
        _20,
        [EnumMember(Value = "30")]
        _30,
        [EnumMember(Value = "40")]
        _40,
        [EnumMember(Value = "50")]
        _50
    }

    public class SignerResponse
    {
        [JsonProperty("document")]
        public string Document { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("has_fields")]
        public bool HasFields { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceUri { get; set; }

        [JsonProperty("status")]
        public SignerStatusEnum Status { get; set; }
    }

    public enum SignerStatusEnum
    {
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5,
        [EnumMember(Value = "10")]
        _10,
        [EnumMember(Value = "15")]
        _15,
        [EnumMember(Value = "20")]
        _20,
        [EnumMember(Value = "30")]
        _30,
        [EnumMember(Value = "35")]
        _35,
        [EnumMember(Value = "39")]
        _39,
        [EnumMember(Value = "40")]
        _40,
        [EnumMember(Value = "50")]
        _50,
        [EnumMember(Value = "60")]
        _60
    }

    public class GetSignerFieldsResponseItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("label_extra")]
        public string LabelExtra { get; set; }

        [JsonProperty("state")]
        public bool State { get; set; }

        [JsonProperty("fieldorder")]
        public int Fieldorder { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetSignerRejectionResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }

    public class DocumentListResponse
    {
        [JsonProperty("meta")]
        public ListMeta Meta { get; set; }

        [JsonProperty("objects")]
        public DocumentListResponseObjectsTypeItem[] Objects { get; set; }
    }

    public class DocumentListResponseObjectsTypeItem
    {
        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("auto_archive")]
        public bool AutoArchive { get; set; }

        [JsonProperty("cc_emails")]
        public string CcEmails { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("do_email")]
        public bool DoEmail { get; set; }

        [JsonProperty("download_final")]
        public bool DownloadFinal { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pdftext")]
        public string Pdftext { get; set; }

        [JsonProperty("redirect")]
        public string Redirect { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceUri { get; set; }

        [JsonProperty("return_signer_links")]
        public bool ReturnSignerLinks { get; set; }

        [JsonProperty("signers")]
        public JToken[][] Signers { get; set; }

        [JsonProperty("signers_in_order")]
        public DocumentListResponseObjectsTypeItemSignersInOrderType SignersInOrder { get; set; }

        [JsonProperty("status")]
        public DocumentStatusEnum Status { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("tag1")]
        public string Tag1 { get; set; }

        [JsonProperty("tag2")]
        public string Tag2 { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("templatepdf")]
        public string Templatepdf { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public enum DocumentListResponseObjectsTypeItemSignersInOrderType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    public class DocumentSignerPost
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("attachments")]
        public string[] Attachments { get; set; }

        [JsonProperty("decide_later")]
        public bool DecideLater { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("reviewers")]
        public ReviewersPost[] Reviewers { get; set; }

        [JsonProperty("sms")]
        public string Sms { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }

    public class ReviewersPost
    {
        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("include_link")]
        public bool IncludeLink { get; set; }
    }

    public enum bodypdfPasswordTypeInput
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }

    public class TemplatePdfResponse
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("parties")]
        public string Parties { get; set; }

        [JsonProperty("page_count")]
        public int PageCount { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceUri { get; set; }

        [JsonProperty("signer_count")]
        public int SignerCount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }
    }

    public class TemplatePdfListResponse
    {
        [JsonProperty("meta")]
        public ListMeta Meta { get; set; }

        [JsonProperty("objects")]
        public TemplatePdfResponse[] Objects { get; set; }
    }

    public class GroupListResponse
    {
        [JsonProperty("meta")]
        public ListMeta Meta { get; set; }

        [JsonProperty("objects")]
        public GroupListResponseObjectsTypeItem[] Objects { get; set; }
    }

    public class GroupListResponseObjectsTypeItem
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("is_active")]
        public bool IsActive { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("public_name")]
        public string PublicName { get; set; }

        [JsonProperty("resource_uri")]
        public string ResourceUri { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("xframe_allow")]
        public bool XframeAllow { get; set; }

        [JsonProperty("xframe_allow_pdf_edit")]
        public bool XframeAllowPdfEdit { get; set; }
    }

    public enum bodyeventFilterInput
    {
        [EnumMember(Value = "document.*")]
        Document,
        [EnumMember(Value = "document.created")]
        DocumentCreated,
        [EnumMember(Value = "document.rejected")]
        DocumentRejected,
        [EnumMember(Value = "document.finalPdfCreated")]
        DocumentFinalPdfCreated
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Legalesign;

    public partial class WorkflowManagedActions
    {
        public LegalesignActions Legalesign(string connectionId) => new LegalesignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LegalesignTriggers Legalesign(string connectionId) => new LegalesignTriggers(connectionId);
    }
}