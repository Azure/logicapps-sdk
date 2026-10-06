//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Legalesign
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LegalesignActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [WorkflowExpressionFactory(nameof(__BuildGetUser))]
        public IBodyWorkflowAction<UserDetailResponse> GetUser([WorkflowExpression] Func<string> userId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserDetailResponse> __BuildGetUser(WorkflowExpression<string> userId)
        {
            WorkflowExpression.Validate(userId, nameof(userId), required: true);
            return new DeferredBodyAction<UserDetailResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/user/{0}/", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserDetailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [WorkflowExpressionFactory(nameof(__BuildGetMembers))]
        public IBodyWorkflowAction<MemberListResponse> GetMembers([WorkflowExpression] Func<string> group = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MemberListResponse> __BuildGetMembers(WorkflowExpression<string> group = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null)
        {
            WorkflowExpression.Validate(group, nameof(group), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<MemberListResponse>(() =>
            {
                var apiCallPath = "/member/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(group);
                callPayload.Queries["limit"] = Convert.ToString(20);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<MemberListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [WorkflowExpressionFactory(nameof(__BuildGetMember))]
        public IBodyWorkflowAction<MemberResponse> GetMember([WorkflowExpression] Func<string> memberId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MemberResponse> __BuildGetMember(WorkflowExpression<string> memberId)
        {
            WorkflowExpression.Validate(memberId, nameof(memberId), required: true);
            return new DeferredBodyAction<MemberResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/member/{0}/", ExpressionConverter.ConvertWithUrlEncoding(memberId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MemberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [WorkflowExpressionFactory(nameof(__BuildGetAttachment))]
        public IBodyWorkflowAction<AttachmentResponse> GetAttachment([WorkflowExpression] Func<string> attachId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AttachmentResponse> __BuildGetAttachment(WorkflowExpression<string> attachId)
        {
            WorkflowExpression.Validate(attachId, nameof(attachId), required: true);
            return new DeferredBodyAction<AttachmentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/attachment/{0}/", ExpressionConverter.ConvertWithUrlEncoding(attachId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AttachmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteAttachment))]
        public IWorkflowAction DeleteAttachment([WorkflowExpression] Func<string> attachId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteAttachment(WorkflowExpression<string> attachId)
        {
            WorkflowExpression.Validate(attachId, nameof(attachId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/attachment/{0}/", ExpressionConverter.ConvertWithUrlEncoding(attachId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [WorkflowExpressionFactory(nameof(__BuildGetAttachments))]
        public IBodyWorkflowAction<AttachmentListResponse> GetAttachments([WorkflowExpression] Func<string> group = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AttachmentListResponse> __BuildGetAttachments(WorkflowExpression<string> group = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null)
        {
            WorkflowExpression.Validate(group, nameof(group), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<AttachmentListResponse>(() =>
            {
                var apiCallPath = "/attachment/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(group);
                callPayload.Queries["limit"] = Convert.ToString(20);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<AttachmentListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [WorkflowExpressionFactory(nameof(__BuildPostAttachment))]
        public IWorkflowAction PostAttachment([WorkflowExpression] Func<string> bodygroup, [WorkflowExpression] Func<string> bodypdfFile, [WorkflowExpression] Func<string> bodyfilename, [WorkflowExpression] Func<string> bodyuser = null, [WorkflowExpression] Func<string> bodydescription = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPostAttachment(WorkflowExpression<string> bodygroup, WorkflowExpression<string> bodypdfFile, WorkflowExpression<string> bodyfilename, WorkflowExpression<string> bodyuser = null, WorkflowExpression<string> bodydescription = null)
        {
            WorkflowExpression.Validate(bodygroup, nameof(bodygroup), required: true);
            WorkflowExpression.Validate(bodypdfFile, nameof(bodypdfFile), required: true);
            WorkflowExpression.Validate(bodyfilename, nameof(bodyfilename), required: true);
            WorkflowExpression.Validate(bodyuser, nameof(bodyuser), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/attachment/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["group"] = ExpressionConverter.ConvertO(bodygroup);
                bodypropCount++;
                body["pdf_file"] = ExpressionConverter.ConvertO(bodypdfFile);
                bodypropCount++;
                body["filename"] = ExpressionConverter.ConvertO(bodyfilename);
                if (bodyuser != null)
                {
                    body["user"] = ExpressionConverter.ConvertO(bodyuser);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
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
        [WorkflowExpressionFactory(nameof(__BuildGetDocumentFields))]
        public IBodyWorkflowAction<GetDocumentFieldsResponseItem[]> GetDocumentFields([WorkflowExpression] Func<string> docId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDocumentFieldsResponseItem[]> __BuildGetDocumentFields(WorkflowExpression<string> docId)
        {
            WorkflowExpression.Validate(docId, nameof(docId), required: true);
            return new DeferredBodyAction<GetDocumentFieldsResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/document/{0}/fields/", ExpressionConverter.ConvertWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentFieldsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocumentAuditLog))]
        public IBodyWorkflowAction<object> GetDocumentAuditLog([WorkflowExpression] Func<string> docId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<object> __BuildGetDocumentAuditLog(WorkflowExpression<string> docId)
        {
            WorkflowExpression.Validate(docId, nameof(docId), required: true);
            return new DeferredBodyAction<object>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/document/{0}/auditlog/", ExpressionConverter.ConvertWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocumentPdf))]
        public IBodyWorkflowAction<object> GetDocumentPdf([WorkflowExpression] Func<string> docId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<object> __BuildGetDocumentPdf(WorkflowExpression<string> docId)
        {
            WorkflowExpression.Validate(docId, nameof(docId), required: true);
            return new DeferredBodyAction<object>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/pdf/{0}/", ExpressionConverter.ConvertWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteDocument))]
        public IWorkflowAction DeleteDocument([WorkflowExpression] Func<string> docId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteDocument(WorkflowExpression<string> docId)
        {
            WorkflowExpression.Validate(docId, nameof(docId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/document/{0}/delete/", ExpressionConverter.ConvertWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocument))]
        public IBodyWorkflowAction<DocumentResponseDetail> GetDocument([WorkflowExpression] Func<string> docId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentResponseDetail> __BuildGetDocument(WorkflowExpression<string> docId)
        {
            WorkflowExpression.Validate(docId, nameof(docId), required: true);
            return new DeferredBodyAction<DocumentResponseDetail>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/document/{0}/", ExpressionConverter.ConvertWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DocumentResponseDetail>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateArchiveDocument))]
        public IWorkflowAction UpdateArchiveDocument([WorkflowExpression] Func<string> docId, [WorkflowExpression] Func<string> email = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateArchiveDocument(WorkflowExpression<string> docId, WorkflowExpression<string> email = null)
        {
            WorkflowExpression.Validate(docId, nameof(docId), required: true);
            WorkflowExpression.Validate(email, nameof(email), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/document/{0}/", ExpressionConverter.ConvertWithUrlEncoding(docId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(email);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [WorkflowExpressionFactory(nameof(__BuildGetRecipient))]
        public IBodyWorkflowAction<SignerResponse> GetRecipient([WorkflowExpression] Func<string> recipientId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SignerResponse> __BuildGetRecipient(WorkflowExpression<string> recipientId)
        {
            WorkflowExpression.Validate(recipientId, nameof(recipientId), required: true);
            return new DeferredBodyAction<SignerResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/signer/{0}/", ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SignerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [WorkflowExpressionFactory(nameof(__BuildPostSignerReminder))]
        public IWorkflowAction PostSignerReminder([WorkflowExpression] Func<string> recipientId, [WorkflowExpression] Func<string> bodytext = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPostSignerReminder(WorkflowExpression<string> recipientId, WorkflowExpression<string> bodytext = null)
        {
            WorkflowExpression.Validate(recipientId, nameof(recipientId), required: true);
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/signer/{0}/send-reminder/", ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(bodytext);
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
        [WorkflowExpressionFactory(nameof(__BuildGetSignerLink))]
        public IWorkflowAction GetSignerLink([WorkflowExpression] Func<string> recipientId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetSignerLink(WorkflowExpression<string> recipientId)
        {
            WorkflowExpression.Validate(recipientId, nameof(recipientId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/signer/{0}/new-link/", ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [WorkflowExpressionFactory(nameof(__BuildGetSignerFields))]
        public IBodyWorkflowAction<GetSignerFieldsResponseItem[]> GetSignerFields([WorkflowExpression] Func<string> recipientId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSignerFieldsResponseItem[]> __BuildGetSignerFields(WorkflowExpression<string> recipientId)
        {
            WorkflowExpression.Validate(recipientId, nameof(recipientId), required: true);
            return new DeferredBodyAction<GetSignerFieldsResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/signer/{0}/fields1/", ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSignerFieldsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [WorkflowExpressionFactory(nameof(__BuildGetSignerRejection))]
        public IBodyWorkflowAction<GetSignerRejectionResponse> GetSignerRejection([WorkflowExpression] Func<string> recipientId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSignerRejectionResponse> __BuildGetSignerRejection(WorkflowExpression<string> recipientId)
        {
            WorkflowExpression.Validate(recipientId, nameof(recipientId), required: true);
            return new DeferredBodyAction<GetSignerRejectionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/signer/{0}/rejection/", ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSignerRejectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocuments))]
        public IBodyWorkflowAction<DocumentListResponse> GetDocuments([WorkflowExpression] Func<string> group, [WorkflowExpression] Func<string> archived = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> status = null, [WorkflowExpression] Func<string> nosigners = null, [WorkflowExpression] Func<string> createdGt = null, [WorkflowExpression] Func<string> modifiedGt = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentListResponse> __BuildGetDocuments(WorkflowExpression<string> group, WorkflowExpression<string> archived = null, WorkflowExpression<string> email = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null, WorkflowExpression<int> status = null, WorkflowExpression<string> nosigners = null, WorkflowExpression<string> createdGt = null, WorkflowExpression<string> modifiedGt = null)
        {
            WorkflowExpression.Validate(group, nameof(group), required: true);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            WorkflowExpression.Validate(email, nameof(email), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            WorkflowExpression.Validate(nosigners, nameof(nosigners), required: false);
            WorkflowExpression.Validate(createdGt, nameof(createdGt), required: false);
            WorkflowExpression.Validate(modifiedGt, nameof(modifiedGt), required: false);
            return new DeferredBodyAction<DocumentListResponse>(() =>
            {
                var apiCallPath = "/document/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["group"] = ExpressionConverter.Convert(group);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                if (email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(email);
                callPayload.Queries["limit"] = Convert.ToString(20);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(status);
                if (nosigners != null)
                    callPayload.Queries["nosigners"] = ExpressionConverter.Convert(nosigners);
                if (createdGt != null)
                    callPayload.Queries["created_gt"] = ExpressionConverter.Convert(createdGt);
                if (modifiedGt != null)
                    callPayload.Queries["modified_gt"] = ExpressionConverter.Convert(modifiedGt);
                return new ApiConnectionAction<DocumentListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [WorkflowExpressionFactory(nameof(__BuildPostDocument))]
        public IWorkflowAction PostDocument([WorkflowExpression] Func<string> bodygroup, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodytemplatepdf, [WorkflowExpression] Func<DocumentSignerPost[]> bodysigners, [WorkflowExpression] Func<int> bodysignatureType = null, [WorkflowExpression] Func<bool> bodyappendPdf = null, [WorkflowExpression] Func<bool> bodyautoArchive = null, [WorkflowExpression] Func<bool> bodydoEmail = null, [WorkflowExpression] Func<string> bodyccEmails = null, [WorkflowExpression] Func<bool> bodyconvertSenderToSigner = null, [WorkflowExpression] Func<string> bodypdfPassword = null, [WorkflowExpression] Func<bodypdfPasswordTypeInput> bodypdfPasswordType = null, [WorkflowExpression] Func<string> bodyredirect = null, [WorkflowExpression] Func<string> bodyreminders = null, [WorkflowExpression] Func<bool> bodyreturnSignerLinks = null, [WorkflowExpression] Func<bool> bodysignersInOrder = null, [WorkflowExpression] Func<bool> bodystrictFields = null, [WorkflowExpression] Func<string> bodytag = null, [WorkflowExpression] Func<string> bodytag1 = null, [WorkflowExpression] Func<string> bodytag2 = null, [WorkflowExpression] Func<string> bodyuser = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPostDocument(WorkflowExpression<string> bodygroup, WorkflowExpression<string> bodyname, WorkflowExpression<string> bodytemplatepdf, WorkflowExpression<DocumentSignerPost[]> bodysigners, WorkflowExpression<int> bodysignatureType = null, WorkflowExpression<bool> bodyappendPdf = null, WorkflowExpression<bool> bodyautoArchive = null, WorkflowExpression<bool> bodydoEmail = null, WorkflowExpression<string> bodyccEmails = null, WorkflowExpression<bool> bodyconvertSenderToSigner = null, WorkflowExpression<string> bodypdfPassword = null, WorkflowExpression<bodypdfPasswordTypeInput> bodypdfPasswordType = null, WorkflowExpression<string> bodyredirect = null, WorkflowExpression<string> bodyreminders = null, WorkflowExpression<bool> bodyreturnSignerLinks = null, WorkflowExpression<bool> bodysignersInOrder = null, WorkflowExpression<bool> bodystrictFields = null, WorkflowExpression<string> bodytag = null, WorkflowExpression<string> bodytag1 = null, WorkflowExpression<string> bodytag2 = null, WorkflowExpression<string> bodyuser = null)
        {
            WorkflowExpression.Validate(bodygroup, nameof(bodygroup), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodytemplatepdf, nameof(bodytemplatepdf), required: true);
            WorkflowExpression.Validate(bodysigners, nameof(bodysigners), required: true);
            WorkflowExpression.Validate(bodysignatureType, nameof(bodysignatureType), required: false);
            WorkflowExpression.Validate(bodyappendPdf, nameof(bodyappendPdf), required: false);
            WorkflowExpression.Validate(bodyautoArchive, nameof(bodyautoArchive), required: false);
            WorkflowExpression.Validate(bodydoEmail, nameof(bodydoEmail), required: false);
            WorkflowExpression.Validate(bodyccEmails, nameof(bodyccEmails), required: false);
            WorkflowExpression.Validate(bodyconvertSenderToSigner, nameof(bodyconvertSenderToSigner), required: false);
            WorkflowExpression.Validate(bodypdfPassword, nameof(bodypdfPassword), required: false);
            WorkflowExpression.Validate(bodypdfPasswordType, nameof(bodypdfPasswordType), required: false);
            WorkflowExpression.Validate(bodyredirect, nameof(bodyredirect), required: false);
            WorkflowExpression.Validate(bodyreminders, nameof(bodyreminders), required: false);
            WorkflowExpression.Validate(bodyreturnSignerLinks, nameof(bodyreturnSignerLinks), required: false);
            WorkflowExpression.Validate(bodysignersInOrder, nameof(bodysignersInOrder), required: false);
            WorkflowExpression.Validate(bodystrictFields, nameof(bodystrictFields), required: false);
            WorkflowExpression.Validate(bodytag, nameof(bodytag), required: false);
            WorkflowExpression.Validate(bodytag1, nameof(bodytag1), required: false);
            WorkflowExpression.Validate(bodytag2, nameof(bodytag2), required: false);
            WorkflowExpression.Validate(bodyuser, nameof(bodyuser), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/document/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["group"] = ExpressionConverter.ConvertO(bodygroup);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
                body["templatepdf"] = ExpressionConverter.ConvertO(bodytemplatepdf);
                bodypropCount++;
                body["signers"] = ExpressionConverter.ConvertO(bodysigners);
                if (bodysignatureType != null)
                {
                    if (bodysignatureType != null)
                    {
                        body["signature_type"] = ExpressionConverter.ConvertO(bodysignatureType);
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
                    body["append_pdf"] = ExpressionConverter.ConvertO(bodyappendPdf);
                    bodypropCount++;
                }

                if (bodyautoArchive != null)
                {
                    if (bodyautoArchive != null)
                    {
                        body["auto_archive"] = ExpressionConverter.ConvertO(bodyautoArchive);
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
                        body["do_email"] = ExpressionConverter.ConvertO(bodydoEmail);
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
                    body["cc_emails"] = ExpressionConverter.ConvertO(bodyccEmails);
                    bodypropCount++;
                }

                if (bodyconvertSenderToSigner != null)
                {
                    if (bodyconvertSenderToSigner != null)
                    {
                        body["convert_sender_to_signer"] = ExpressionConverter.ConvertO(bodyconvertSenderToSigner);
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
                    body["pdf_password"] = ExpressionConverter.ConvertO(bodypdfPassword);
                    bodypropCount++;
                }

                if (bodypdfPasswordType != null)
                {
                    body["pdf_password_type"] = ExpressionConverter.ConvertO(bodypdfPasswordType);
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
                    body["redirect"] = ExpressionConverter.ConvertO(bodyredirect);
                    bodypropCount++;
                }

                if (bodyreminders != null)
                {
                    body["reminders"] = ExpressionConverter.ConvertO(bodyreminders);
                    bodypropCount++;
                }

                if (bodyreturnSignerLinks != null)
                {
                    if (bodyreturnSignerLinks != null)
                    {
                        body["return_signer_links"] = ExpressionConverter.ConvertO(bodyreturnSignerLinks);
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
                    body["signers_in_order"] = ExpressionConverter.ConvertO(bodysignersInOrder);
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
                        body["strict_fields"] = ExpressionConverter.ConvertO(bodystrictFields);
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
                    body["tag"] = ExpressionConverter.ConvertO(bodytag);
                    bodypropCount++;
                }

                if (bodytag1 != null)
                {
                    body["tag1"] = ExpressionConverter.ConvertO(bodytag1);
                    bodypropCount++;
                }

                if (bodytag2 != null)
                {
                    body["tag2"] = ExpressionConverter.ConvertO(bodytag2);
                    bodypropCount++;
                }

                if (bodyuser != null)
                {
                    body["user"] = ExpressionConverter.ConvertO(bodyuser);
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
        [WorkflowExpressionFactory(nameof(__BuildGetPdfTemplate))]
        public IBodyWorkflowAction<TemplatePdfResponse> GetPdfTemplate([WorkflowExpression] Func<string> pdfId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TemplatePdfResponse> __BuildGetPdfTemplate(WorkflowExpression<string> pdfId)
        {
            WorkflowExpression.Validate(pdfId, nameof(pdfId), required: true);
            return new DeferredBodyAction<TemplatePdfResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/templatepdf/{0}/", ExpressionConverter.ConvertWithUrlEncoding(pdfId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TemplatePdfResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [WorkflowExpressionFactory(nameof(__BuildGetPdfTemplateEditLink))]
        public IWorkflowAction GetPdfTemplateEditLink([WorkflowExpression] Func<string> pdfId, [WorkflowExpression] Func<bool> hideSenderFields = null, [WorkflowExpression] Func<string> cssBodyBackgroundcolor = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetPdfTemplateEditLink(WorkflowExpression<string> pdfId, WorkflowExpression<bool> hideSenderFields = null, WorkflowExpression<string> cssBodyBackgroundcolor = null)
        {
            WorkflowExpression.Validate(pdfId, nameof(pdfId), required: true);
            WorkflowExpression.Validate(hideSenderFields, nameof(hideSenderFields), required: false);
            WorkflowExpression.Validate(cssBodyBackgroundcolor, nameof(cssBodyBackgroundcolor), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/templatepdf/{0}/edit-link/", ExpressionConverter.ConvertWithUrlEncoding(pdfId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (hideSenderFields != null)
                    callPayload.Queries["hide_sender_fields"] = ExpressionConverter.Convert(hideSenderFields);
                if (cssBodyBackgroundcolor != null)
                    callPayload.Queries["css_body_backgroundcolor"] = ExpressionConverter.Convert(cssBodyBackgroundcolor);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [WorkflowExpressionFactory(nameof(__BuildGetPdfTemplates))]
        public IBodyWorkflowAction<TemplatePdfListResponse> GetPdfTemplates([WorkflowExpression] Func<string> group = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TemplatePdfListResponse> __BuildGetPdfTemplates(WorkflowExpression<string> group = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null)
        {
            WorkflowExpression.Validate(group, nameof(group), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<TemplatePdfListResponse>(() =>
            {
                var apiCallPath = "/templatepdf/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(group);
                callPayload.Queries["limit"] = Convert.ToString(20);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<TemplatePdfListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [WorkflowExpressionFactory(nameof(__BuildPostPdfTemplate))]
        public IWorkflowAction PostPdfTemplate([WorkflowExpression] Func<string> bodygroup, [WorkflowExpression] Func<string> bodypdfFile, [WorkflowExpression] Func<bool> bodyarchiveUponSend = null, [WorkflowExpression] Func<bool> bodyprocessTags = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyuser = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPostPdfTemplate(WorkflowExpression<string> bodygroup, WorkflowExpression<string> bodypdfFile, WorkflowExpression<bool> bodyarchiveUponSend = null, WorkflowExpression<bool> bodyprocessTags = null, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodyuser = null)
        {
            WorkflowExpression.Validate(bodygroup, nameof(bodygroup), required: true);
            WorkflowExpression.Validate(bodypdfFile, nameof(bodypdfFile), required: true);
            WorkflowExpression.Validate(bodyarchiveUponSend, nameof(bodyarchiveUponSend), required: false);
            WorkflowExpression.Validate(bodyprocessTags, nameof(bodyprocessTags), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodyuser, nameof(bodyuser), required: false);
            return new DeferredWorkflowAction(() =>
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
                        body["archive_upon_send"] = ExpressionConverter.ConvertO(bodyarchiveUponSend);
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
                body["group"] = ExpressionConverter.ConvertO(bodygroup);
                bodypropCount++;
                body["pdf_file"] = ExpressionConverter.ConvertO(bodypdfFile);
                if (bodyprocessTags != null)
                {
                    body["process_tags"] = ExpressionConverter.ConvertO(bodyprocessTags);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodyuser != null)
                {
                    body["user"] = ExpressionConverter.ConvertO(bodyuser);
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
        [WorkflowExpressionFactory(nameof(__BuildGetGroups))]
        public IBodyWorkflowAction<GroupListResponse> GetGroups([WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GroupListResponse> __BuildGetGroups(WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<GroupListResponse>(() =>
            {
                var apiCallPath = "/group/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction<GroupListResponse>(callPayload);
            });
        }
    }

    public class LegalesignTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildRecipientTrigger))]
        public IWorkflowTrigger RecipientTrigger([WorkflowExpression] Func<bodyeventFilterInput> bodyeventFilter, [WorkflowExpression] Func<string> bodygroup = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildRecipientTrigger(WorkflowExpression<bodyeventFilterInput> bodyeventFilter, WorkflowExpression<string> bodygroup = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyeventFilter, nameof(bodyeventFilter), required: true);
            WorkflowExpression.Validate(bodygroup, nameof(bodygroup), required: false);
            return new DeferredWorkflowTrigger(() =>
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
                body["eventFilter"] = ExpressionConverter.ConvertO(bodyeventFilter);
                if (bodygroup != null)
                {
                    body["group"] = ExpressionConverter.ConvertO(bodygroup);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildDocumentTrigger))]
        public IWorkflowTrigger DocumentTrigger([WorkflowExpression] Func<bodyeventFilterInput> bodyeventFilter, [WorkflowExpression] Func<string> bodygroup = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildDocumentTrigger(WorkflowExpression<bodyeventFilterInput> bodyeventFilter, WorkflowExpression<string> bodygroup = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyeventFilter, nameof(bodyeventFilter), required: true);
            WorkflowExpression.Validate(bodygroup, nameof(bodygroup), required: false);
            return new DeferredWorkflowTrigger(() =>
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
                body["eventFilter"] = ExpressionConverter.ConvertO(bodyeventFilter);
                if (bodygroup != null)
                {
                    body["group"] = ExpressionConverter.ConvertO(bodygroup);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
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