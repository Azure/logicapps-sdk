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
        public IBodyWorkflowAction<UserDetailResponse> GetUser(Expression<Func<string>> userId)
        {
            var apiCallPath = String.Format("/user/{0}/", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserDetailResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<MemberListResponse> GetMembers(Expression<Func<string>> group = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<MemberResponse> GetMember(Expression<Func<string>> memberId)
        {
            var apiCallPath = String.Format("/member/{0}/", ExpressionConverter.ConvertWithUrlEncoding(memberId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MemberResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<AttachmentResponse> GetAttachment(Expression<Func<string>> attachId)
        {
            var apiCallPath = String.Format("/attachment/{0}/", ExpressionConverter.ConvertWithUrlEncoding(attachId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AttachmentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IWorkflowAction DeleteAttachment(Expression<Func<string>> attachId)
        {
            var apiCallPath = String.Format("/attachment/{0}/", ExpressionConverter.ConvertWithUrlEncoding(attachId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<AttachmentListResponse> GetAttachments(Expression<Func<string>> group = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IWorkflowAction PostAttachment(Expression<Func<string>> bodygroup, Expression<Func<string>> bodypdfFile, Expression<Func<string>> bodyfilename, Expression<Func<string>> bodyuser = null, Expression<Func<string>> bodydescription = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<GetDocumentFieldsResponseItem[]> GetDocumentFields(Expression<Func<string>> docId)
        {
            var apiCallPath = String.Format("/document/{0}/fields/", ExpressionConverter.ConvertWithUrlEncoding(docId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetDocumentFieldsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<object> GetDocumentAuditLog(Expression<Func<string>> docId)
        {
            var apiCallPath = String.Format("/document/{0}/auditlog/", ExpressionConverter.ConvertWithUrlEncoding(docId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<object>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<object> GetDocumentPdf(Expression<Func<string>> docId)
        {
            var apiCallPath = String.Format("/pdf/{0}/", ExpressionConverter.ConvertWithUrlEncoding(docId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<object>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IWorkflowAction DeleteDocument(Expression<Func<string>> docId)
        {
            var apiCallPath = String.Format("/document/{0}/delete/", ExpressionConverter.ConvertWithUrlEncoding(docId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<DocumentResponseDetail> GetDocument(Expression<Func<string>> docId)
        {
            var apiCallPath = String.Format("/document/{0}/", ExpressionConverter.ConvertWithUrlEncoding(docId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DocumentResponseDetail>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IWorkflowAction UpdateArchiveDocument(Expression<Func<string>> docId, Expression<Func<string>> email = null)
        {
            var apiCallPath = String.Format("/document/{0}/", ExpressionConverter.ConvertWithUrlEncoding(docId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (email != null)
                callPayload.Queries["email"] = ExpressionConverter.Convert(email);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<SignerResponse> GetRecipient(Expression<Func<string>> recipientId)
        {
            var apiCallPath = String.Format("/signer/{0}/", ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SignerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IWorkflowAction PostSignerReminder(Expression<Func<string>> recipientId, Expression<Func<string>> bodytext = null)
        {
            var apiCallPath = String.Format("/signer/{0}/send-reminder/", ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IWorkflowAction GetSignerLink(Expression<Func<string>> recipientId)
        {
            var apiCallPath = String.Format("/signer/{0}/new-link/", ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<GetSignerFieldsResponseItem[]> GetSignerFields(Expression<Func<string>> recipientId)
        {
            var apiCallPath = String.Format("/signer/{0}/fields1/", ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetSignerFieldsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<GetSignerRejectionResponse> GetSignerRejection(Expression<Func<string>> recipientId)
        {
            var apiCallPath = String.Format("/signer/{0}/rejection/", ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetSignerRejectionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<DocumentListResponse> GetDocuments(Expression<Func<string>> group, Expression<Func<string>> archived = null, Expression<Func<string>> email = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<int>> status = null, Expression<Func<string>> nosigners = null, Expression<Func<string>> createdGt = null, Expression<Func<string>> modifiedGt = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IWorkflowAction PostDocument(Expression<Func<string>> bodygroup, Expression<Func<string>> bodyname, Expression<Func<string>> bodytemplatepdf, Expression<Func<DocumentSignerPost[]>> bodysigners, Expression<Func<int>> bodysignatureType = null, Expression<Func<bool>> bodyappendPdf = null, Expression<Func<bool>> bodyautoArchive = null, Expression<Func<bool>> bodydoEmail = null, Expression<Func<string>> bodyccEmails = null, Expression<Func<bool>> bodyconvertSenderToSigner = null, Expression<Func<string>> bodypdfPassword = null, Expression<Func<bodypdfPasswordTypeInput>> bodypdfPasswordType = null, Expression<Func<string>> bodyredirect = null, Expression<Func<string>> bodyreminders = null, Expression<Func<bool>> bodyreturnSignerLinks = null, Expression<Func<bool>> bodysignersInOrder = null, Expression<Func<bool>> bodystrictFields = null, Expression<Func<string>> bodytag = null, Expression<Func<string>> bodytag1 = null, Expression<Func<string>> bodytag2 = null, Expression<Func<string>> bodyuser = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<TemplatePdfResponse> GetPdfTemplate(Expression<Func<string>> pdfId)
        {
            var apiCallPath = String.Format("/templatepdf/{0}/", ExpressionConverter.ConvertWithUrlEncoding(pdfId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TemplatePdfResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IWorkflowAction GetPdfTemplateEditLink(Expression<Func<string>> pdfId, Expression<Func<bool>> hideSenderFields = null, Expression<Func<string>> cssBodyBackgroundcolor = null)
        {
            var apiCallPath = String.Format("/templatepdf/{0}/edit-link/", ExpressionConverter.ConvertWithUrlEncoding(pdfId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (hideSenderFields != null)
                callPayload.Queries["hide_sender_fields"] = ExpressionConverter.Convert(hideSenderFields);
            if (cssBodyBackgroundcolor != null)
                callPayload.Queries["css_body_backgroundcolor"] = ExpressionConverter.Convert(cssBodyBackgroundcolor);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<TemplatePdfListResponse> GetPdfTemplates(Expression<Func<string>> group = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IWorkflowAction PostPdfTemplate(Expression<Func<string>> bodygroup, Expression<Func<string>> bodypdfFile, Expression<Func<bool>> bodyarchiveUponSend = null, Expression<Func<bool>> bodyprocessTags = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyuser = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "legalesign")]
        public IBodyWorkflowAction<GroupListResponse> GetGroups(Expression<Func<int>> offset = null, Expression<Func<int>> limit = null)
        {
            var apiCallPath = "/group/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            return new ApiConnectionAction<GroupListResponse>(callPayload);
        }
    }

    public class LegalesignTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger RecipientTrigger(Expression<Func<bodyeventFilterInput>> bodyeventFilter, Expression<Func<string>> bodygroup = null, string triggerName = null, FlowRecurrence recurrence = null)
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
        }

        public IWorkflowTrigger DocumentTrigger(Expression<Func<bodyeventFilterInput>> bodyeventFilter, Expression<Func<string>> bodygroup = null, string triggerName = null, FlowRecurrence recurrence = null)
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