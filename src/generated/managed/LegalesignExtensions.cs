//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Legalesign
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LegalesignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<UserDetailResponse, ApiConnectionActionConfiguration> GetUser(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<UserDetailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/user/{0}/", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserDetailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<MemberListResponse, ApiConnectionActionConfiguration> GetMembers(Expression<Func<string>> group = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_group = WorkflowExpression.Compile(group, nameof(group), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<MemberListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/member/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(__workflow_group);
                callPayload.Queries["limit"] = Convert.ToString(20);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<MemberListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<MemberResponse, ApiConnectionActionConfiguration> GetMember(Expression<Func<string>> memberId)
        {
            var __workflow_memberId = WorkflowExpression.Compile(memberId, nameof(memberId), required: true);
            return new DeferredBodyAction<MemberResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/member/{0}/", __workflow_memberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MemberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<AttachmentResponse, ApiConnectionActionConfiguration> GetAttachment(Expression<Func<string>> attachId)
        {
            var __workflow_attachId = WorkflowExpression.Compile(attachId, nameof(attachId), required: true);
            return new DeferredBodyAction<AttachmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/attachment/{0}/", __workflow_attachId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AttachmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteAttachment(Expression<Func<string>> attachId)
        {
            var __workflow_attachId = WorkflowExpression.Compile(attachId, nameof(attachId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/attachment/{0}/", __workflow_attachId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<AttachmentListResponse, ApiConnectionActionConfiguration> GetAttachments(Expression<Func<string>> group = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_group = WorkflowExpression.Compile(group, nameof(group), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<AttachmentListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/attachment/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(__workflow_group);
                callPayload.Queries["limit"] = Convert.ToString(20);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<AttachmentListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PostAttachment(Expression<Func<string>> bodygroup, Expression<Func<string>> bodypdfFile, Expression<Func<string>> bodyfilename, Expression<Func<string>> bodyuser = null, Expression<Func<string>> bodydescription = null)
        {
            var __workflow_bodygroup = WorkflowExpression.Compile(bodygroup, nameof(bodygroup), required: true);
            var __workflow_bodypdfFile = WorkflowExpression.Compile(bodypdfFile, nameof(bodypdfFile), required: true);
            var __workflow_bodyfilename = WorkflowExpression.Compile(bodyfilename, nameof(bodyfilename), required: true);
            var __workflow_bodyuser = WorkflowExpression.Compile(bodyuser, nameof(bodyuser), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/attachment/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["group"] = ExpressionConverter.ConvertO(__workflow_bodygroup);
                bodypropCount++;
                body["pdf_file"] = ExpressionConverter.ConvertO(__workflow_bodypdfFile);
                bodypropCount++;
                body["filename"] = ExpressionConverter.ConvertO(__workflow_bodyfilename);
                if (__workflow_bodyuser != null)
                {
                    body["user"] = ExpressionConverter.ConvertO(__workflow_bodyuser);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<GetDocumentFieldsResponseItem[], ApiConnectionActionConfiguration> GetDocumentFields(Expression<Func<string>> docId)
        {
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            return new DeferredBodyAction<GetDocumentFieldsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}/fields/", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentFieldsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> GetDocumentAuditLog(Expression<Func<string>> docId)
        {
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}/auditlog/", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> GetDocumentPdf(Expression<Func<string>> docId)
        {
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pdf/{0}/", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteDocument(Expression<Func<string>> docId)
        {
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}/delete/", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<DocumentResponseDetail, ApiConnectionActionConfiguration> GetDocument(Expression<Func<string>> docId)
        {
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            return new DeferredBodyAction<DocumentResponseDetail, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}/", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DocumentResponseDetail>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateArchiveDocument(Expression<Func<string>> docId, Expression<Func<string>> email = null)
        {
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}/", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<SignerResponse, ApiConnectionActionConfiguration> GetRecipient(Expression<Func<string>> recipientId)
        {
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            return new DeferredBodyAction<SignerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/signer/{0}/", __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SignerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PostSignerReminder(Expression<Func<string>> recipientId, Expression<Func<string>> bodytext = null)
        {
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/signer/{0}/send-reminder/", __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetSignerLink(Expression<Func<string>> recipientId)
        {
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/signer/{0}/new-link/", __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<GetSignerFieldsResponseItem[], ApiConnectionActionConfiguration> GetSignerFields(Expression<Func<string>> recipientId)
        {
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            return new DeferredBodyAction<GetSignerFieldsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/signer/{0}/fields1/", __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSignerFieldsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<GetSignerRejectionResponse, ApiConnectionActionConfiguration> GetSignerRejection(Expression<Func<string>> recipientId)
        {
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            return new DeferredBodyAction<GetSignerRejectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/signer/{0}/rejection/", __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSignerRejectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<DocumentListResponse, ApiConnectionActionConfiguration> GetDocuments(Expression<Func<string>> group, Expression<Func<string>> archived = null, Expression<Func<string>> email = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<int>> status = null, Expression<Func<string>> nosigners = null, Expression<Func<string>> createdGt = null, Expression<Func<string>> modifiedGt = null)
        {
            var __workflow_group = WorkflowExpression.Compile(group, nameof(group), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_nosigners = WorkflowExpression.Compile(nosigners, nameof(nosigners), required: false);
            var __workflow_createdGt = WorkflowExpression.Compile(createdGt, nameof(createdGt), required: false);
            var __workflow_modifiedGt = WorkflowExpression.Compile(modifiedGt, nameof(modifiedGt), required: false);
            return new DeferredBodyAction<DocumentListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/document/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["group"] = ExpressionConverter.Convert(__workflow_group);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                callPayload.Queries["limit"] = Convert.ToString(20);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_nosigners != null)
                    callPayload.Queries["nosigners"] = ExpressionConverter.Convert(__workflow_nosigners);
                if (__workflow_createdGt != null)
                    callPayload.Queries["created_gt"] = ExpressionConverter.Convert(__workflow_createdGt);
                if (__workflow_modifiedGt != null)
                    callPayload.Queries["modified_gt"] = ExpressionConverter.Convert(__workflow_modifiedGt);
                return new ApiConnectionAction<DocumentListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PostDocument(Expression<Func<string>> bodygroup, Expression<Func<string>> bodyname, Expression<Func<string>> bodytemplatepdf, Expression<Func<DocumentSignerPost[]>> bodysigners, Expression<Func<int>> bodysignatureType = null, Expression<Func<bool>> bodyappendPdf = null, Expression<Func<bool>> bodyautoArchive = null, Expression<Func<bool>> bodydoEmail = null, Expression<Func<string>> bodyccEmails = null, Expression<Func<bool>> bodyconvertSenderToSigner = null, Expression<Func<string>> bodypdfPassword = null, Expression<Func<bodypdfPasswordTypeInput>> bodypdfPasswordType = null, Expression<Func<string>> bodyredirect = null, Expression<Func<string>> bodyreminders = null, Expression<Func<bool>> bodyreturnSignerLinks = null, Expression<Func<bool>> bodysignersInOrder = null, Expression<Func<bool>> bodystrictFields = null, Expression<Func<string>> bodytag = null, Expression<Func<string>> bodytag1 = null, Expression<Func<string>> bodytag2 = null, Expression<Func<string>> bodyuser = null)
        {
            var __workflow_bodygroup = WorkflowExpression.Compile(bodygroup, nameof(bodygroup), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodytemplatepdf = WorkflowExpression.Compile(bodytemplatepdf, nameof(bodytemplatepdf), required: true);
            var __workflow_bodysigners = WorkflowExpression.Compile(bodysigners, nameof(bodysigners), required: true);
            var __workflow_bodysignatureType = WorkflowExpression.Compile(bodysignatureType, nameof(bodysignatureType), required: false);
            var __workflow_bodyappendPdf = WorkflowExpression.Compile(bodyappendPdf, nameof(bodyappendPdf), required: false);
            var __workflow_bodyautoArchive = WorkflowExpression.Compile(bodyautoArchive, nameof(bodyautoArchive), required: false);
            var __workflow_bodydoEmail = WorkflowExpression.Compile(bodydoEmail, nameof(bodydoEmail), required: false);
            var __workflow_bodyccEmails = WorkflowExpression.Compile(bodyccEmails, nameof(bodyccEmails), required: false);
            var __workflow_bodyconvertSenderToSigner = WorkflowExpression.Compile(bodyconvertSenderToSigner, nameof(bodyconvertSenderToSigner), required: false);
            var __workflow_bodypdfPassword = WorkflowExpression.Compile(bodypdfPassword, nameof(bodypdfPassword), required: false);
            var __workflow_bodypdfPasswordType = WorkflowExpression.Compile(bodypdfPasswordType, nameof(bodypdfPasswordType), required: false);
            var __workflow_bodyredirect = WorkflowExpression.Compile(bodyredirect, nameof(bodyredirect), required: false);
            var __workflow_bodyreminders = WorkflowExpression.Compile(bodyreminders, nameof(bodyreminders), required: false);
            var __workflow_bodyreturnSignerLinks = WorkflowExpression.Compile(bodyreturnSignerLinks, nameof(bodyreturnSignerLinks), required: false);
            var __workflow_bodysignersInOrder = WorkflowExpression.Compile(bodysignersInOrder, nameof(bodysignersInOrder), required: false);
            var __workflow_bodystrictFields = WorkflowExpression.Compile(bodystrictFields, nameof(bodystrictFields), required: false);
            var __workflow_bodytag = WorkflowExpression.Compile(bodytag, nameof(bodytag), required: false);
            var __workflow_bodytag1 = WorkflowExpression.Compile(bodytag1, nameof(bodytag1), required: false);
            var __workflow_bodytag2 = WorkflowExpression.Compile(bodytag2, nameof(bodytag2), required: false);
            var __workflow_bodyuser = WorkflowExpression.Compile(bodyuser, nameof(bodyuser), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/document/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["group"] = ExpressionConverter.ConvertO(__workflow_bodygroup);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["templatepdf"] = ExpressionConverter.ConvertO(__workflow_bodytemplatepdf);
                bodypropCount++;
                body["signers"] = ExpressionConverter.ConvertO(__workflow_bodysigners);
                if (__workflow_bodysignatureType != null)
                {
                    if (__workflow_bodysignatureType != null)
                    {
                        body["signature_type"] = ExpressionConverter.ConvertO(__workflow_bodysignatureType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["signature_type"] = 4;
                    bodypropCount++;
                }

                if (__workflow_bodyappendPdf != null)
                {
                    body["append_pdf"] = ExpressionConverter.ConvertO(__workflow_bodyappendPdf);
                    bodypropCount++;
                }

                if (__workflow_bodyautoArchive != null)
                {
                    if (__workflow_bodyautoArchive != null)
                    {
                        body["auto_archive"] = ExpressionConverter.ConvertO(__workflow_bodyautoArchive);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["auto_archive"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodydoEmail != null)
                {
                    if (__workflow_bodydoEmail != null)
                    {
                        body["do_email"] = ExpressionConverter.ConvertO(__workflow_bodydoEmail);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["do_email"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodyccEmails != null)
                {
                    body["cc_emails"] = ExpressionConverter.ConvertO(__workflow_bodyccEmails);
                    bodypropCount++;
                }

                if (__workflow_bodyconvertSenderToSigner != null)
                {
                    if (__workflow_bodyconvertSenderToSigner != null)
                    {
                        body["convert_sender_to_signer"] = ExpressionConverter.ConvertO(__workflow_bodyconvertSenderToSigner);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["convert_sender_to_signer"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodypdfPassword != null)
                {
                    body["pdf_password"] = ExpressionConverter.ConvertO(__workflow_bodypdfPassword);
                    bodypropCount++;
                }

                if (__workflow_bodypdfPasswordType != null)
                {
                    body["pdf_password_type"] = ExpressionConverter.ConvertO(__workflow_bodypdfPasswordType);
                    bodypropCount++;
                }

                var pdftextObject = new JObject();
                var pdftextObjectpropCount = 0;
                if (pdftextObjectpropCount > 0)
                {
                    body["pdftext"] = pdftextObject;
                    bodypropCount++;
                }

                if (__workflow_bodyredirect != null)
                {
                    body["redirect"] = ExpressionConverter.ConvertO(__workflow_bodyredirect);
                    bodypropCount++;
                }

                if (__workflow_bodyreminders != null)
                {
                    body["reminders"] = ExpressionConverter.ConvertO(__workflow_bodyreminders);
                    bodypropCount++;
                }

                if (__workflow_bodyreturnSignerLinks != null)
                {
                    if (__workflow_bodyreturnSignerLinks != null)
                    {
                        body["return_signer_links"] = ExpressionConverter.ConvertO(__workflow_bodyreturnSignerLinks);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["return_signer_links"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodysignersInOrder != null)
                {
                    body["signers_in_order"] = ExpressionConverter.ConvertO(__workflow_bodysignersInOrder);
                    bodypropCount++;
                }

                var signertextObject = new JObject();
                var signertextObjectpropCount = 0;
                if (signertextObjectpropCount > 0)
                {
                    body["signertext"] = signertextObject;
                    bodypropCount++;
                }

                if (__workflow_bodystrictFields != null)
                {
                    if (__workflow_bodystrictFields != null)
                    {
                        body["strict_fields"] = ExpressionConverter.ConvertO(__workflow_bodystrictFields);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["strict_fields"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodytag != null)
                {
                    body["tag"] = ExpressionConverter.ConvertO(__workflow_bodytag);
                    bodypropCount++;
                }

                if (__workflow_bodytag1 != null)
                {
                    body["tag1"] = ExpressionConverter.ConvertO(__workflow_bodytag1);
                    bodypropCount++;
                }

                if (__workflow_bodytag2 != null)
                {
                    body["tag2"] = ExpressionConverter.ConvertO(__workflow_bodytag2);
                    bodypropCount++;
                }

                if (__workflow_bodyuser != null)
                {
                    body["user"] = ExpressionConverter.ConvertO(__workflow_bodyuser);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<TemplatePdfResponse, ApiConnectionActionConfiguration> GetPdfTemplate(Expression<Func<string>> pdfId)
        {
            var __workflow_pdfId = WorkflowExpression.Compile(pdfId, nameof(pdfId), required: true);
            return new DeferredBodyAction<TemplatePdfResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/templatepdf/{0}/", __workflow_pdfId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TemplatePdfResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetPdfTemplateEditLink(Expression<Func<string>> pdfId, Expression<Func<bool>> hideSenderFields = null, Expression<Func<string>> cssBodyBackgroundcolor = null)
        {
            var __workflow_pdfId = WorkflowExpression.Compile(pdfId, nameof(pdfId), required: true);
            var __workflow_hideSenderFields = WorkflowExpression.Compile(hideSenderFields, nameof(hideSenderFields), required: false);
            var __workflow_cssBodyBackgroundcolor = WorkflowExpression.Compile(cssBodyBackgroundcolor, nameof(cssBodyBackgroundcolor), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/templatepdf/{0}/edit-link/", __workflow_pdfId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_hideSenderFields != null)
                    callPayload.Queries["hide_sender_fields"] = ExpressionConverter.Convert(__workflow_hideSenderFields);
                if (__workflow_cssBodyBackgroundcolor != null)
                    callPayload.Queries["css_body_backgroundcolor"] = ExpressionConverter.Convert(__workflow_cssBodyBackgroundcolor);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<TemplatePdfListResponse, ApiConnectionActionConfiguration> GetPdfTemplates(Expression<Func<string>> group = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_group = WorkflowExpression.Compile(group, nameof(group), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<TemplatePdfListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/templatepdf/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(__workflow_group);
                callPayload.Queries["limit"] = Convert.ToString(20);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<TemplatePdfListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PostPdfTemplate(Expression<Func<string>> bodygroup, Expression<Func<string>> bodypdfFile, Expression<Func<bool>> bodyarchiveUponSend = null, Expression<Func<bool>> bodyprocessTags = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyuser = null)
        {
            var __workflow_bodygroup = WorkflowExpression.Compile(bodygroup, nameof(bodygroup), required: true);
            var __workflow_bodypdfFile = WorkflowExpression.Compile(bodypdfFile, nameof(bodypdfFile), required: true);
            var __workflow_bodyarchiveUponSend = WorkflowExpression.Compile(bodyarchiveUponSend, nameof(bodyarchiveUponSend), required: false);
            var __workflow_bodyprocessTags = WorkflowExpression.Compile(bodyprocessTags, nameof(bodyprocessTags), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyuser = WorkflowExpression.Compile(bodyuser, nameof(bodyuser), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/templatepdf/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyarchiveUponSend != null)
                {
                    if (__workflow_bodyarchiveUponSend != null)
                    {
                        body["archive_upon_send"] = ExpressionConverter.ConvertO(__workflow_bodyarchiveUponSend);
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
                body["group"] = ExpressionConverter.ConvertO(__workflow_bodygroup);
                bodypropCount++;
                body["pdf_file"] = ExpressionConverter.ConvertO(__workflow_bodypdfFile);
                if (__workflow_bodyprocessTags != null)
                {
                    body["process_tags"] = ExpressionConverter.ConvertO(__workflow_bodyprocessTags);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyuser != null)
                {
                    body["user"] = ExpressionConverter.ConvertO(__workflow_bodyuser);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<GroupListResponse, ApiConnectionActionConfiguration> GetGroups(Expression<Func<int>> offset = null, Expression<Func<int>> limit = null)
        {
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<GroupListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/group/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<GroupListResponse>(callPayload);
            });
        }
    }

    public class LegalesignTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> RecipientTrigger(Expression<Func<bodyeventFilterInput>> bodyeventFilter, Expression<Func<string>> bodygroup = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyeventFilter = WorkflowExpression.Compile(bodyeventFilter, nameof(bodyeventFilter), required: true);
            var __workflow_bodygroup = WorkflowExpression.Compile(bodygroup, nameof(bodygroup), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/subscribe/recipient/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["notify"] = "realtime";
                bodypropCount++;
                bodypropCount++;
                body["eventFilter"] = ExpressionConverter.ConvertO(__workflow_bodyeventFilter);
                if (__workflow_bodygroup != null)
                {
                    body["group"] = ExpressionConverter.ConvertO(__workflow_bodygroup);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> DocumentTrigger(Expression<Func<bodyeventFilterInput>> bodyeventFilter, Expression<Func<string>> bodygroup = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyeventFilter = WorkflowExpression.Compile(bodyeventFilter, nameof(bodyeventFilter), required: true);
            var __workflow_bodygroup = WorkflowExpression.Compile(bodygroup, nameof(bodygroup), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/subscribe/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["notify"] = "realtime";
                bodypropCount++;
                bodypropCount++;
                body["eventFilter"] = ExpressionConverter.ConvertO(__workflow_bodyeventFilter);
                if (__workflow_bodygroup != null)
                {
                    body["group"] = ExpressionConverter.ConvertO(__workflow_bodygroup);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentResponseDetailSignerObjectsTypeItemRoleType
    {
        [EnumMember(Value = "signer")]
        Signer,
        [EnumMember(Value = "approver")]
        Approver,
        [EnumMember(Value = "witness")]
        Witness
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
