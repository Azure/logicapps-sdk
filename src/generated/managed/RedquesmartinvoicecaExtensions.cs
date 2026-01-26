//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Redquesmartinvoiceca
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RedquesmartinvoicecaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction ReturnDocumentConfiguration()
        {
            var apiCallPath = "/v1/configuration/return-to-issuer";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction StoreReturnDocumentConfiguration(Expression<Func<string>> bodytemplate = null, Expression<Func<string>> bodysubject = null)
        {
            var apiCallPath = "/v1/configuration/return-to-issuer";
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytemplate != null)
            {
                body["template"] = ExpressionConverter.ConvertO(bodytemplate);
                bodypropCount++;
            }

            if (bodysubject != null)
            {
                body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<string> GetImage(Expression<Func<string>> documentId, Expression<Func<int>> pageIndex, Expression<Func<bool>> isPreview = null)
        {
            var apiCallPath = String.Format("/v1/documents/{0}/page/{1}/image", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(pageIndex, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["isPreview"] = Convert.ToString(false);
            if (isPreview != null)
                callPayload.Queries["isPreview"] = ExpressionConverter.Convert(isPreview);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction ReturnDocument(Expression<Func<string>> documentId, Expression<Func<string[]>> bodyadditionalDocuments = null, Expression<Func<string>> bodyrecipientEmail = null, Expression<Func<string>> bodyreason = null, Expression<Func<string>> bodyrequestedByUserId = null)
        {
            var apiCallPath = String.Format("/v1/documents/{0}/return-to-issuer", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyadditionalDocuments != null)
            {
                body["additionalDocuments"] = ExpressionConverter.ConvertO(bodyadditionalDocuments);
                bodypropCount++;
            }

            if (bodyrecipientEmail != null)
            {
                body["recipientEmail"] = ExpressionConverter.ConvertO(bodyrecipientEmail);
                bodypropCount++;
            }

            if (bodyreason != null)
            {
                body["reason"] = ExpressionConverter.ConvertO(bodyreason);
                bodypropCount++;
            }

            if (bodyrequestedByUserId != null)
            {
                body["requestedByUserId"] = ExpressionConverter.ConvertO(bodyrequestedByUserId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiDocumentApiListResult> ListAllDocuments(Expression<Func<string>> bodytext = null, Expression<Func<string>> bodyfilterfileNamevalue = null, Expression<Func<DocumentState[]>> bodyfilterstatevalues = null, Expression<Func<ApprovalState[]>> bodyfilterapprovalStatevalues = null, Expression<Func<string>> bodyfiltertypevalue = null, Expression<Func<string>> bodyfiltersourceInfovalue = null, Expression<Func<bool>> bodyfilterisPostProcessCompletedvalue = null, Expression<Func<bool>> bodyfilterisReturnedToSendervalue = null, Expression<Func<DocumentSource[]>> bodyfiltersourcevalues = null, Expression<Func<string[]>> bodyfilterownerIdvalues = null, Expression<Func<string[]>> bodyfiltervalidatorIdvalues = null, Expression<Func<string>> bodyfiltercreatedDatefrom = null, Expression<Func<string>> bodyfiltercreatedDateto = null, Expression<Func<string>> bodyfiltervalidatedDatefrom = null, Expression<Func<string>> bodyfiltervalidatedDateto = null, Expression<Func<string>> bodyfilterapprovedDatefrom = null, Expression<Func<string>> bodyfilterapprovedDateto = null, Expression<Func<int>> bodycontrolskip = null, Expression<Func<int>> bodycontroltake = null, Expression<Func<bodysortfieldInput>> bodysortfield = null, Expression<Func<bodysortdirectionInput>> bodysortdirection = null, Expression<Func<ApiDocumentScope[]>> bodyscopes = null)
        {
            var apiCallPath = "/v1/documents/list";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytext != null)
            {
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
            }

            var filterObject = new JObject();
            var filterObjectpropCount = 0;
            var fileNameObject = new JObject();
            var fileNameObjectpropCount = 0;
            if (bodyfilterfileNamevalue != null)
            {
                fileNameObject["value"] = ExpressionConverter.ConvertO(bodyfilterfileNamevalue);
                fileNameObjectpropCount++;
            }

            if (fileNameObjectpropCount > 0)
            {
                filterObject["fileName"] = fileNameObject;
                filterObjectpropCount++;
            }

            var stateObject = new JObject();
            var stateObjectpropCount = 0;
            if (bodyfilterstatevalues != null)
            {
                stateObject["values"] = ExpressionConverter.ConvertO(bodyfilterstatevalues);
                stateObjectpropCount++;
            }

            if (stateObjectpropCount > 0)
            {
                filterObject["state"] = stateObject;
                filterObjectpropCount++;
            }

            var approvalStateObject = new JObject();
            var approvalStateObjectpropCount = 0;
            if (bodyfilterapprovalStatevalues != null)
            {
                approvalStateObject["values"] = ExpressionConverter.ConvertO(bodyfilterapprovalStatevalues);
                approvalStateObjectpropCount++;
            }

            if (approvalStateObjectpropCount > 0)
            {
                filterObject["approvalState"] = approvalStateObject;
                filterObjectpropCount++;
            }

            var typeObject = new JObject();
            var typeObjectpropCount = 0;
            if (bodyfilterfileNamevalue != null)
            {
                typeObject["value"] = ExpressionConverter.ConvertO(bodyfilterfileNamevalue);
                typeObjectpropCount++;
            }

            if (typeObjectpropCount > 0)
            {
                filterObject["type"] = typeObject;
                filterObjectpropCount++;
            }

            var sourceInfoObject = new JObject();
            var sourceInfoObjectpropCount = 0;
            if (bodyfiltersourceInfovalue != null)
            {
                sourceInfoObject["value"] = ExpressionConverter.ConvertO(bodyfiltersourceInfovalue);
                sourceInfoObjectpropCount++;
            }

            if (sourceInfoObjectpropCount > 0)
            {
                filterObject["sourceInfo"] = sourceInfoObject;
                filterObjectpropCount++;
            }

            var isPostProcessCompletedObject = new JObject();
            var isPostProcessCompletedObjectpropCount = 0;
            if (bodyfilterisPostProcessCompletedvalue != null)
            {
                isPostProcessCompletedObject["value"] = ExpressionConverter.ConvertO(bodyfilterisPostProcessCompletedvalue);
                isPostProcessCompletedObjectpropCount++;
            }

            if (isPostProcessCompletedObjectpropCount > 0)
            {
                filterObject["isPostProcessCompleted"] = isPostProcessCompletedObject;
                filterObjectpropCount++;
            }

            var isReturnedToSenderObject = new JObject();
            var isReturnedToSenderObjectpropCount = 0;
            if (bodyfilterisPostProcessCompletedvalue != null)
            {
                isReturnedToSenderObject["value"] = ExpressionConverter.ConvertO(bodyfilterisPostProcessCompletedvalue);
                isReturnedToSenderObjectpropCount++;
            }

            if (isReturnedToSenderObjectpropCount > 0)
            {
                filterObject["isReturnedToSender"] = isReturnedToSenderObject;
                filterObjectpropCount++;
            }

            var sourceObject = new JObject();
            var sourceObjectpropCount = 0;
            if (bodyfiltersourcevalues != null)
            {
                sourceObject["values"] = ExpressionConverter.ConvertO(bodyfiltersourcevalues);
                sourceObjectpropCount++;
            }

            if (sourceObjectpropCount > 0)
            {
                filterObject["source"] = sourceObject;
                filterObjectpropCount++;
            }

            var ownerIdObject = new JObject();
            var ownerIdObjectpropCount = 0;
            if (bodyfilterownerIdvalues != null)
            {
                ownerIdObject["values"] = ExpressionConverter.ConvertO(bodyfilterownerIdvalues);
                ownerIdObjectpropCount++;
            }

            if (ownerIdObjectpropCount > 0)
            {
                filterObject["ownerId"] = ownerIdObject;
                filterObjectpropCount++;
            }

            var validatorIdObject = new JObject();
            var validatorIdObjectpropCount = 0;
            if (bodyfilterownerIdvalues != null)
            {
                validatorIdObject["values"] = ExpressionConverter.ConvertO(bodyfilterownerIdvalues);
                validatorIdObjectpropCount++;
            }

            if (validatorIdObjectpropCount > 0)
            {
                filterObject["validatorId"] = validatorIdObject;
                filterObjectpropCount++;
            }

            var createdDateObject = new JObject();
            var createdDateObjectpropCount = 0;
            if (bodyfiltercreatedDatefrom != null)
            {
                createdDateObject["from"] = ExpressionConverter.ConvertO(bodyfiltercreatedDatefrom);
                createdDateObjectpropCount++;
            }

            if (bodyfiltercreatedDateto != null)
            {
                createdDateObject["to"] = ExpressionConverter.ConvertO(bodyfiltercreatedDateto);
                createdDateObjectpropCount++;
            }

            if (createdDateObjectpropCount > 0)
            {
                filterObject["createdDate"] = createdDateObject;
                filterObjectpropCount++;
            }

            var validatedDateObject = new JObject();
            var validatedDateObjectpropCount = 0;
            if (bodyfiltercreatedDatefrom != null)
            {
                validatedDateObject["from"] = ExpressionConverter.ConvertO(bodyfiltercreatedDatefrom);
                validatedDateObjectpropCount++;
            }

            if (bodyfiltercreatedDateto != null)
            {
                validatedDateObject["to"] = ExpressionConverter.ConvertO(bodyfiltercreatedDateto);
                validatedDateObjectpropCount++;
            }

            if (validatedDateObjectpropCount > 0)
            {
                filterObject["validatedDate"] = validatedDateObject;
                filterObjectpropCount++;
            }

            var approvedDateObject = new JObject();
            var approvedDateObjectpropCount = 0;
            if (bodyfiltercreatedDatefrom != null)
            {
                approvedDateObject["from"] = ExpressionConverter.ConvertO(bodyfiltercreatedDatefrom);
                approvedDateObjectpropCount++;
            }

            if (bodyfiltercreatedDateto != null)
            {
                approvedDateObject["to"] = ExpressionConverter.ConvertO(bodyfiltercreatedDateto);
                approvedDateObjectpropCount++;
            }

            if (approvedDateObjectpropCount > 0)
            {
                filterObject["approvedDate"] = approvedDateObject;
                filterObjectpropCount++;
            }

            var fieldsObject = new JObject();
            var fieldsObjectpropCount = 0;
            if (fieldsObjectpropCount > 0)
            {
                filterObject["fields"] = fieldsObject;
                filterObjectpropCount++;
            }

            if (filterObjectpropCount > 0)
            {
                body["filter"] = filterObject;
                bodypropCount++;
            }

            var controlObject = new JObject();
            var controlObjectpropCount = 0;
            if (bodycontrolskip != null)
            {
                controlObject["skip"] = ExpressionConverter.ConvertO(bodycontrolskip);
                controlObjectpropCount++;
            }

            if (bodycontroltake != null)
            {
                controlObject["take"] = ExpressionConverter.ConvertO(bodycontroltake);
                controlObjectpropCount++;
            }

            if (controlObjectpropCount > 0)
            {
                body["control"] = controlObject;
                bodypropCount++;
            }

            var sortObject = new JObject();
            var sortObjectpropCount = 0;
            if (bodysortfield != null)
            {
                sortObject["field"] = ExpressionConverter.ConvertO(bodysortfield);
                sortObjectpropCount++;
            }

            if (bodysortdirection != null)
            {
                sortObject["direction"] = ExpressionConverter.ConvertO(bodysortdirection);
                sortObjectpropCount++;
            }

            if (sortObjectpropCount > 0)
            {
                body["sort"] = sortObject;
                bodypropCount++;
            }

            if (bodyscopes != null)
            {
                body["scopes"] = ExpressionConverter.ConvertO(bodyscopes);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ApiDocumentApiListResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction DownloadFileAsync(Expression<Func<string>> documentId)
        {
            var apiCallPath = String.Format("/v1/documents/{0}/file", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction DeleteDocument(Expression<Func<string>> documentId)
        {
            var apiCallPath = String.Format("/v1/documents/{0}", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiDocument> GetDocument(Expression<Func<string>> documentId, Expression<Func<bool>> isExternalId = null)
        {
            var apiCallPath = String.Format("/v1/documents/{0}", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["isExternalId"] = Convert.ToString(false);
            if (isExternalId != null)
                callPayload.Queries["isExternalId"] = ExpressionConverter.Convert(isExternalId);
            return new ApiConnectionAction<ApiDocument>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<RedQueStatus> UpdateDocuments(Expression<Func<string>> documentId, Expression<Func<string>> bodydocumentId = null, Expression<Func<string>> bodyexternalDocumentIdvalue = null, Expression<Func<string>> bodycontainerIdvalue = null, Expression<Func<string>> bodyfileNamevalue = null, Expression<Func<string>> bodycontentTypevalue = null, Expression<Func<bodysourcevalueInput>> bodysourcevalue = null, Expression<Func<string>> bodysourceInfovalue = null, Expression<Func<string>> bodydocumentClassvalue = null, Expression<Func<bool>> bodyisAttachmentvalue = null, Expression<Func<bool>> bodyeditedvalue = null, Expression<Func<string>> bodynotevalue = null, Expression<Func<ApiFieldValueUpdate[]>> bodyfields = null, Expression<Func<ApiFieldValueUpdate[][]>> bodyitems = null, Expression<Func<string>> bodyvalidatevalueuserId = null, Expression<Func<string>> bodyapprovevalueuserId = null, Expression<Func<bodyapprovevaluestateInput>> bodyapprovevaluestate = null, Expression<Func<StringApiListValueUpdate[]>> bodyauthorizeUsers = null, Expression<Func<StringApiListValueUpdate[]>> bodyduplicateDocIds = null)
        {
            var apiCallPath = String.Format("/v1/documents/{0}", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydocumentId != null)
            {
                body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
                bodypropCount++;
            }

            var externalDocumentIdObject = new JObject();
            var externalDocumentIdObjectpropCount = 0;
            if (bodyexternalDocumentIdvalue != null)
            {
                externalDocumentIdObject["value"] = ExpressionConverter.ConvertO(bodyexternalDocumentIdvalue);
                externalDocumentIdObjectpropCount++;
            }

            if (externalDocumentIdObjectpropCount > 0)
            {
                body["externalDocumentId"] = externalDocumentIdObject;
                bodypropCount++;
            }

            var containerIdObject = new JObject();
            var containerIdObjectpropCount = 0;
            if (bodyexternalDocumentIdvalue != null)
            {
                containerIdObject["value"] = ExpressionConverter.ConvertO(bodyexternalDocumentIdvalue);
                containerIdObjectpropCount++;
            }

            if (containerIdObjectpropCount > 0)
            {
                body["containerId"] = containerIdObject;
                bodypropCount++;
            }

            var fileNameObject = new JObject();
            var fileNameObjectpropCount = 0;
            if (bodyexternalDocumentIdvalue != null)
            {
                fileNameObject["value"] = ExpressionConverter.ConvertO(bodyexternalDocumentIdvalue);
                fileNameObjectpropCount++;
            }

            if (fileNameObjectpropCount > 0)
            {
                body["fileName"] = fileNameObject;
                bodypropCount++;
            }

            var contentTypeObject = new JObject();
            var contentTypeObjectpropCount = 0;
            if (bodyexternalDocumentIdvalue != null)
            {
                contentTypeObject["value"] = ExpressionConverter.ConvertO(bodyexternalDocumentIdvalue);
                contentTypeObjectpropCount++;
            }

            if (contentTypeObjectpropCount > 0)
            {
                body["contentType"] = contentTypeObject;
                bodypropCount++;
            }

            var sourceObject = new JObject();
            var sourceObjectpropCount = 0;
            if (bodysourcevalue != null)
            {
                sourceObject["value"] = ExpressionConverter.ConvertO(bodysourcevalue);
                sourceObjectpropCount++;
            }

            if (sourceObjectpropCount > 0)
            {
                body["source"] = sourceObject;
                bodypropCount++;
            }

            var sourceInfoObject = new JObject();
            var sourceInfoObjectpropCount = 0;
            if (bodyexternalDocumentIdvalue != null)
            {
                sourceInfoObject["value"] = ExpressionConverter.ConvertO(bodyexternalDocumentIdvalue);
                sourceInfoObjectpropCount++;
            }

            if (sourceInfoObjectpropCount > 0)
            {
                body["sourceInfo"] = sourceInfoObject;
                bodypropCount++;
            }

            var documentClassObject = new JObject();
            var documentClassObjectpropCount = 0;
            if (bodyexternalDocumentIdvalue != null)
            {
                documentClassObject["value"] = ExpressionConverter.ConvertO(bodyexternalDocumentIdvalue);
                documentClassObjectpropCount++;
            }

            if (documentClassObjectpropCount > 0)
            {
                body["documentClass"] = documentClassObject;
                bodypropCount++;
            }

            var isAttachmentObject = new JObject();
            var isAttachmentObjectpropCount = 0;
            if (bodyisAttachmentvalue != null)
            {
                isAttachmentObject["value"] = ExpressionConverter.ConvertO(bodyisAttachmentvalue);
                isAttachmentObjectpropCount++;
            }

            if (isAttachmentObjectpropCount > 0)
            {
                body["isAttachment"] = isAttachmentObject;
                bodypropCount++;
            }

            var editedObject = new JObject();
            var editedObjectpropCount = 0;
            if (bodyisAttachmentvalue != null)
            {
                editedObject["value"] = ExpressionConverter.ConvertO(bodyisAttachmentvalue);
                editedObjectpropCount++;
            }

            if (editedObjectpropCount > 0)
            {
                body["edited"] = editedObject;
                bodypropCount++;
            }

            var noteObject = new JObject();
            var noteObjectpropCount = 0;
            if (bodyexternalDocumentIdvalue != null)
            {
                noteObject["value"] = ExpressionConverter.ConvertO(bodyexternalDocumentIdvalue);
                noteObjectpropCount++;
            }

            if (noteObjectpropCount > 0)
            {
                body["note"] = noteObject;
                bodypropCount++;
            }

            if (bodyfields != null)
            {
                body["fields"] = ExpressionConverter.ConvertO(bodyfields);
                bodypropCount++;
            }

            if (bodyitems != null)
            {
                body["items"] = ExpressionConverter.ConvertO(bodyitems);
                bodypropCount++;
            }

            var validateObject = new JObject();
            var validateObjectpropCount = 0;
            var valueObject = new JObject();
            var valueObjectpropCount = 0;
            if (bodyvalidatevalueuserId != null)
            {
                valueObject["userId"] = ExpressionConverter.ConvertO(bodyvalidatevalueuserId);
                valueObjectpropCount++;
            }

            if (valueObjectpropCount > 0)
            {
                validateObject["value"] = valueObject;
                validateObjectpropCount++;
            }

            if (validateObjectpropCount > 0)
            {
                body["validate"] = validateObject;
                bodypropCount++;
            }

            var approveObject = new JObject();
            var approveObjectpropCount = 0;
            var valueObject = new JObject();
            var valueObjectpropCount = 0;
            if (bodyapprovevalueuserId != null)
            {
                valueObject["userId"] = ExpressionConverter.ConvertO(bodyapprovevalueuserId);
                valueObjectpropCount++;
            }

            if (bodyapprovevaluestate != null)
            {
                valueObject["state"] = ExpressionConverter.ConvertO(bodyapprovevaluestate);
                valueObjectpropCount++;
            }

            if (valueObjectpropCount > 0)
            {
                approveObject["value"] = valueObject;
                approveObjectpropCount++;
            }

            if (approveObjectpropCount > 0)
            {
                body["approve"] = approveObject;
                bodypropCount++;
            }

            if (bodyauthorizeUsers != null)
            {
                body["authorizeUsers"] = ExpressionConverter.ConvertO(bodyauthorizeUsers);
                bodypropCount++;
            }

            if (bodyduplicateDocIds != null)
            {
                body["duplicateDocIds"] = ExpressionConverter.ConvertO(bodyduplicateDocIds);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<RedQueStatus>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction LockDocument(Expression<Func<string>> documentId)
        {
            var apiCallPath = String.Format("/v1/documents/{0}/lock", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction UnlockDocumentAsync(Expression<Func<string>> documentId)
        {
            var apiCallPath = String.Format("/v1/documents/{0}/lock", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction GrantDocumentAccess(Expression<Func<string>> documentId, Expression<Func<string>> userId, Expression<Func<string>> bodydocumentId = null, Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodydatamessage = null)
        {
            var apiCallPath = String.Format("/v1/documents/{0}/users/{1}", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydocumentId != null)
            {
                body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
                bodypropCount++;
            }

            if (bodyuserId != null)
            {
                body["userId"] = ExpressionConverter.ConvertO(bodyuserId);
                bodypropCount++;
            }

            var dataObject = new JObject();
            var dataObjectpropCount = 0;
            if (bodydatamessage != null)
            {
                dataObject["message"] = ExpressionConverter.ConvertO(bodydatamessage);
                dataObjectpropCount++;
            }

            if (dataObjectpropCount > 0)
            {
                body["data"] = dataObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction RemoveDocumentAccess(Expression<Func<string>> documentId, Expression<Func<string>> userId)
        {
            var apiCallPath = String.Format("/v1/documents/{0}/users/{1}", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiUploadResponse> UploadDocumentAsync(Expression<Func<object>> file = null, Expression<Func<string>> documentId = null, Expression<Func<string>> folderId = null, Expression<Func<string>> date = null, Expression<Func<int>> ordinal = null, Expression<Func<bool>> isAttachment = null, Expression<Func<string>> documentClass = null)
        {
            var apiCallPath = "/v1/documents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ApiUploadResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiEnum[]> GetAllEnums()
        {
            var apiCallPath = "/v1/enums";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ApiEnum[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<StringApiValue> CreateEnum(Expression<Func<string>> bodyid = null, Expression<Func<string>> bodyname = null, Expression<Func<bool>> bodyisEditable = null)
        {
            var apiCallPath = "/v1/enums";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            var valuesObject = new JObject();
            var valuesObjectpropCount = 0;
            if (valuesObjectpropCount > 0)
            {
                body["values"] = valuesObject;
                bodypropCount++;
            }

            if (bodyisEditable != null)
            {
                body["isEditable"] = ExpressionConverter.ConvertO(bodyisEditable);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<StringApiValue>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiEnum> GetEnum(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v1/enums/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ApiEnum>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction UpdateEnum(Expression<Func<string>> id, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodyname = null, Expression<Func<bool>> bodyisEditable = null)
        {
            var apiCallPath = String.Format("/v1/enums/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            var valuesObject = new JObject();
            var valuesObjectpropCount = 0;
            if (valuesObjectpropCount > 0)
            {
                body["values"] = valuesObject;
                bodypropCount++;
            }

            if (bodyisEditable != null)
            {
                body["isEditable"] = ExpressionConverter.ConvertO(bodyisEditable);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction DeleteEnum(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v1/enums/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction GetExtractDocument(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v1/extract/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction ExtractDocument(Expression<Func<string>> externalDocumentId = null, Expression<Func<object>> file = null)
        {
            var apiCallPath = "/v1/extract";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (externalDocumentId != null)
                callPayload.Queries["externalDocumentId"] = ExpressionConverter.Convert(externalDocumentId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiFolderCreationResult> CreateFolder()
        {
            var apiCallPath = "/v1/folder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ApiFolderCreationResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction DownloadFolderArchived(Expression<Func<string>> folderId)
        {
            var apiCallPath = String.Format("/v1/folder/{0}/archived", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction DeleteFolder(Expression<Func<string>> folderId)
        {
            var apiCallPath = String.Format("/v1/folder/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiFolderWithMembers> GetFolder(Expression<Func<string>> folderId, Expression<Func<bool>> withMembers = null)
        {
            var apiCallPath = String.Format("/v1/folder/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["withMembers"] = Convert.ToString(false);
            if (withMembers != null)
                callPayload.Queries["withMembers"] = ExpressionConverter.Convert(withMembers);
            return new ApiConnectionAction<ApiFolderWithMembers>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction UpdateContainerData(Expression<Func<string>> folderId, Expression<Func<string>> bodyfolderId = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string>> bodycreated = null)
        {
            var apiCallPath = String.Format("/v1/folder/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfolderId != null)
            {
                body["folderId"] = ExpressionConverter.ConvertO(bodyfolderId);
                bodypropCount++;
            }

            if (bodyownerId != null)
            {
                body["ownerId"] = ExpressionConverter.ConvertO(bodyownerId);
                bodypropCount++;
            }

            if (bodycreated != null)
            {
                body["created"] = ExpressionConverter.ConvertO(bodycreated);
                bodypropCount++;
            }

            var metadataObject = new JObject();
            var metadataObjectpropCount = 0;
            if (metadataObjectpropCount > 0)
            {
                body["metadata"] = metadataObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<MLicense> GetLicenseInfo()
        {
            var apiCallPath = "/v1/tenant/license";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MLicense>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<StringApiValue> GetRegisterToken()
        {
            var apiCallPath = "/v1/tenant/token";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<StringApiValue>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<StringApiValue> GenerateRegistrationToken()
        {
            var apiCallPath = "/v1/tenant/token";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<StringApiValue>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction DisableRegistrationToken()
        {
            var apiCallPath = "/v1/tenant/token";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiUserApiListResult> ListOfUsers(Expression<Func<string>> bodytext = null, Expression<Func<string>> bodyfilterfirstNamevalue = null, Expression<Func<string>> bodyfilterlastNamevalue = null, Expression<Func<string>> bodyfilteremailvalue = null, Expression<Func<int>> bodycontrolskip = null, Expression<Func<int>> bodycontroltake = null, Expression<Func<bodysortfieldInput>> bodysortfield = null, Expression<Func<bodysortdirectionInput>> bodysortdirection = null)
        {
            var apiCallPath = "/v1/users/list";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytext != null)
            {
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                bodypropCount++;
            }

            var filterObject = new JObject();
            var filterObjectpropCount = 0;
            var firstNameObject = new JObject();
            var firstNameObjectpropCount = 0;
            if (bodyfilterfirstNamevalue != null)
            {
                firstNameObject["value"] = ExpressionConverter.ConvertO(bodyfilterfirstNamevalue);
                firstNameObjectpropCount++;
            }

            if (firstNameObjectpropCount > 0)
            {
                filterObject["firstName"] = firstNameObject;
                filterObjectpropCount++;
            }

            var lastNameObject = new JObject();
            var lastNameObjectpropCount = 0;
            if (bodyfilterfirstNamevalue != null)
            {
                lastNameObject["value"] = ExpressionConverter.ConvertO(bodyfilterfirstNamevalue);
                lastNameObjectpropCount++;
            }

            if (lastNameObjectpropCount > 0)
            {
                filterObject["lastName"] = lastNameObject;
                filterObjectpropCount++;
            }

            var emailObject = new JObject();
            var emailObjectpropCount = 0;
            if (bodyfilterfirstNamevalue != null)
            {
                emailObject["value"] = ExpressionConverter.ConvertO(bodyfilterfirstNamevalue);
                emailObjectpropCount++;
            }

            if (emailObjectpropCount > 0)
            {
                filterObject["email"] = emailObject;
                filterObjectpropCount++;
            }

            if (filterObjectpropCount > 0)
            {
                body["filter"] = filterObject;
                bodypropCount++;
            }

            var controlObject = new JObject();
            var controlObjectpropCount = 0;
            if (bodycontrolskip != null)
            {
                controlObject["skip"] = ExpressionConverter.ConvertO(bodycontrolskip);
                controlObjectpropCount++;
            }

            if (bodycontroltake != null)
            {
                controlObject["take"] = ExpressionConverter.ConvertO(bodycontroltake);
                controlObjectpropCount++;
            }

            if (controlObjectpropCount > 0)
            {
                body["control"] = controlObject;
                bodypropCount++;
            }

            var sortObject = new JObject();
            var sortObjectpropCount = 0;
            if (bodysortfield != null)
            {
                sortObject["field"] = ExpressionConverter.ConvertO(bodysortfield);
                sortObjectpropCount++;
            }

            if (bodysortdirection != null)
            {
                sortObject["direction"] = ExpressionConverter.ConvertO(bodysortdirection);
                sortObjectpropCount++;
            }

            if (sortObjectpropCount > 0)
            {
                body["sort"] = sortObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ApiUserApiListResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction CreateUser(Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodyemail = null)
        {
            var apiCallPath = "/v1/users";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfirstName != null)
            {
                body["firstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                bodypropCount++;
            }

            if (bodylastName != null)
            {
                body["lastName"] = ExpressionConverter.ConvertO(bodylastName);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction ChangePassword(Expression<Func<string>> userId, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/v1/users/{0}/password", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction ForceUserPasswordChange(Expression<Func<string>> userId, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodyaccountId = null, Expression<Func<string>> bodyactivationkey = null)
        {
            var apiCallPath = String.Format("/v1/users/{0}/password", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodyaccountId != null)
            {
                body["accountId"] = ExpressionConverter.ConvertO(bodyaccountId);
                bodypropCount++;
            }

            if (bodyactivationkey != null)
            {
                body["activationkey"] = ExpressionConverter.ConvertO(bodyactivationkey);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction DeleteUser(Expression<Func<string>> userId)
        {
            var apiCallPath = String.Format("/v1/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiUser> GetUser(Expression<Func<string>> userId)
        {
            var apiCallPath = String.Format("/v1/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ApiUser>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction UpdateUser(Expression<Func<string>> userId, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null)
        {
            var apiCallPath = String.Format("/v1/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfirstName != null)
            {
                body["firstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                bodypropCount++;
            }

            if (bodylastName != null)
            {
                body["lastName"] = ExpressionConverter.ConvertO(bodylastName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction AddUserPermissions(Expression<Func<string>> userId, Expression<Func<string[]>> bodypermissions = null)
        {
            var apiCallPath = String.Format("/v1/users/{0}/permission", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypermissions != null)
            {
                body["permissions"] = ExpressionConverter.ConvertO(bodypermissions);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction RemoveUserPermissions(Expression<Func<string>> userId, Expression<Func<string[]>> bodypermissions = null)
        {
            var apiCallPath = String.Format("/v1/users/{0}/permission", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypermissions != null)
            {
                body["permissions"] = ExpressionConverter.ConvertO(bodypermissions);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class RedquesmartinvoicecaTriggers([ConnectionName] string connectionId)
    {
    }

    public class ApiDocumentApiListResult
    {
        [JsonProperty("list")]
        public ApiDocument[] List { get; set; }

        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }
    }

    public class ApiDocument
    {
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("externalDocumentId")]
        public string ExternalDocumentId { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("contentHash")]
        public string ContentHash { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("owner")]
        public ApiUser Owner { get; set; }

        [JsonProperty("state")]
        public DocumentState State { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("isImagesGenerated")]
        public bool IsImagesGenerated { get; set; }

        [JsonProperty("isReturned")]
        public bool IsReturned { get; set; }

        [JsonProperty("returnReason")]
        public string ReturnReason { get; set; }

        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("source")]
        public DocumentSource Source { get; set; }

        [JsonProperty("sourceInfo")]
        public string SourceInfo { get; set; }

        [JsonProperty("extractionTime")]
        public string ExtractionTime { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("isAttachment")]
        public bool IsAttachment { get; set; }

        [JsonProperty("isValidated")]
        public bool IsValidated { get; set; }

        [JsonProperty("isEdited")]
        public bool IsEdited { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }

        [JsonProperty("items")]
        public JToken[] Items { get; set; }

        [JsonProperty("pages")]
        public ApiPage[] Pages { get; set; }

        [JsonProperty("pluginResults")]
        public ApiPluginResult[] PluginResults { get; set; }

        [JsonProperty("isPostProcessCompleted")]
        public bool IsPostProcessCompleted { get; set; }

        [JsonProperty("isPrevalidated")]
        public bool IsPrevalidated { get; set; }

        [JsonProperty("lastOpenTime")]
        public string LastOpenTime { get; set; }

        [JsonProperty("lastOpenUserId")]
        public string LastOpenUserId { get; set; }

        [JsonProperty("isLocked")]
        public bool IsLocked { get; set; }

        [JsonProperty("validationTime")]
        public string ValidationTime { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("approvalState")]
        public ApprovalState ApprovalState { get; set; }

        [JsonProperty("currentApproverId")]
        public string CurrentApproverId { get; set; }

        [JsonProperty("lastApprovalStepTime")]
        public string LastApprovalStepTime { get; set; }

        [JsonProperty("isCurrentApproverNotificationSent")]
        public bool IsCurrentApproverNotificationSent { get; set; }

        [JsonProperty("approvalHistory")]
        public ApiApproval[] ApprovalHistory { get; set; }

        [JsonProperty("approvalReminderHistory")]
        public ApiApprovalReminder[] ApprovalReminderHistory { get; set; }

        [JsonProperty("authorizedUserIds")]
        public string[] AuthorizedUserIds { get; set; }

        [JsonProperty("duplicateDocIds")]
        public string[] DuplicateDocIds { get; set; }

        [JsonProperty("approvedBy")]
        public ApiUser ApprovedBy { get; set; }

        [JsonProperty("validatedBy")]
        public ApiUser ValidatedBy { get; set; }
    }

    public class ApiUser
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public enum DocumentState
    {
        Uploading,
        Uploaded,
        PreProcessed,
        Extracting,
        Extracted,
        Validated,
        Exported,
        Failed,
        UnsupportedType,
        NoLicense
    }

    public enum DocumentSource
    {
        WebApp,
        Mail,
        API,
        Plugin
    }

    public class ApiPage
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("rotation")]
        public double Rotation { get; set; }

        [JsonProperty("words")]
        public ApiWord[] Words { get; set; }

        [JsonProperty("itemTable")]
        public ApiItemTable ItemTable { get; set; }
    }

    public class ApiWord
    {
        [JsonProperty("wordId")]
        public int WordId { get; set; }

        [JsonProperty("pageIndex")]
        public int PageIndex { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("locX")]
        public int LocX { get; set; }

        [JsonProperty("locY")]
        public int LocY { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }

    public class ApiItemTable
    {
        [JsonProperty("pageIndex")]
        public int PageIndex { get; set; }

        [JsonProperty("offset")]
        public Offset Offset { get; set; }

        [JsonProperty("columns")]
        public ApiItemColumn[] Columns { get; set; }

        [JsonProperty("rows")]
        public ApiItemRow[] Rows { get; set; }
    }

    public class Offset
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class ApiItemColumn
    {
        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }
    }

    public class ApiItemRow
    {
        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("cells")]
        public ApiItemCell[] Cells { get; set; }
    }

    public class ApiItemCell
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("modifiedByPostProcessing")]
        public bool ModifiedByPostProcessing { get; set; }

        [JsonProperty("pluginResults")]
        public ApiPluginResult[] PluginResults { get; set; }
    }

    public class ApiPluginResult
    {
        [JsonProperty("pluginName")]
        public string PluginName { get; set; }

        [JsonProperty("resultCode")]
        public PostProcessResult ResultCode { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("extraInformationRequired")]
        public bool ExtraInformationRequired { get; set; }

        [JsonProperty("extraInformationMessage")]
        public string ExtraInformationMessage { get; set; }
    }

    public enum PostProcessResult
    {
        SUCCESS,
        FAILURE
    }

    public enum ApprovalState
    {
        UNAPPROVED,
        PREAPPROVED,
        PREREJECTED,
        DELEGATED,
        ABANDONED,
        APPROVED,
        REJECTED
    }

    public class ApiApproval
    {
        [JsonProperty("approver")]
        public ApiUser Approver { get; set; }

        [JsonProperty("approvalStepTime")]
        public string ApprovalStepTime { get; set; }

        [JsonProperty("approvalState")]
        public ApprovalState ApprovalState { get; set; }

        [JsonProperty("delegatedTo")]
        public ApiUser DelegatedTo { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    public class ApiApprovalReminder
    {
        [JsonProperty("fromUser")]
        public ApiUser FromUser { get; set; }

        [JsonProperty("toUser")]
        public ApiUser ToUser { get; set; }

        [JsonProperty("sentTime")]
        public string SentTime { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    public enum bodysortfieldInput
    {
        FirstName,
        LastName,
        Email
    }

    public enum bodysortdirectionInput
    {
        Ascending,
        Descending
    }

    public enum ApiDocumentScope
    {
        Metadata,
        Approval,
        PluginResults,
        Fields,
        Words,
        Users
    }

    public class RedQueStatus
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public enum bodysourcevalueInput
    {
        WebApp,
        Mail,
        API,
        Plugin
    }

    public class ApiFieldValueUpdate
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("operation")]
        public ApiListValueOperation Operation { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isWarning")]
        public bool IsWarning { get; set; }

        [JsonProperty("wordIds")]
        public int[] WordIds { get; set; }
    }

    public enum ApiListValueOperation
    {
        Undefined,
        Add,
        AddIfNotExists,
        Set,
        Remove
    }

    public enum bodyapprovevaluestateInput
    {
        UNAPPROVED,
        PREAPPROVED,
        PREREJECTED,
        DELEGATED,
        ABANDONED,
        APPROVED,
        REJECTED
    }

    public class StringApiListValueUpdate
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("operation")]
        public ApiListValueOperation Operation { get; set; }
    }

    public class ApiUploadResponse
    {
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }
    }

    public class ApiEnum
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("values")]
        public JToken Values { get; set; }

        [JsonProperty("isEditable")]
        public bool IsEditable { get; set; }
    }

    public class StringApiValue
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ApiFolderCreationResult
    {
        [JsonProperty("folderId")]
        public string FolderId { get; set; }
    }

    public class ApiFolderWithMembers
    {
        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("members")]
        public ApiDocument[] Members { get; set; }
    }

    public class MLicense
    {
        [JsonProperty("responseCode")]
        public ResponseCode ResponseCode { get; set; }

        [JsonProperty("responseMessage")]
        public string ResponseMessage { get; set; }

        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public string ValidTo { get; set; }

        [JsonProperty("nextPeriod")]
        public string NextPeriod { get; set; }

        [JsonProperty("usageLimit")]
        public int UsageLimit { get; set; }

        [JsonProperty("usageLimitPeriod")]
        public LicenseTimePeriod UsageLimitPeriod { get; set; }

        [JsonProperty("isTrial")]
        public bool IsTrial { get; set; }

        [JsonProperty("usageCount")]
        public int UsageCount { get; set; }
    }

    public enum ResponseCode
    {
        NONE,
        OK,
        [EnumMember(Value = "NO_CONFIG_FILE")]
        NOCONFIGFILE,
        [EnumMember(Value = "INCOMPLETE_CONFIG_FILE")]
        INCOMPLETECONFIGFILE,
        [EnumMember(Value = "INVALID_CONFIG_FILE")]
        INVALIDCONFIGFILE,
        [EnumMember(Value = "UNREADABLE_CONFIG_FILE")]
        UNREADABLECONFIGFILE,
        [EnumMember(Value = "DATABASE_NOT_AVAILABLE")]
        DATABASENOTAVAILABLE,
        [EnumMember(Value = "DOCUMENT_STORAGE_NOT_AVAILABLE")]
        DOCUMENTSTORAGENOTAVAILABLE,
        [EnumMember(Value = "UNKNOWN_USER")]
        UNKNOWNUSER,
        [EnumMember(Value = "INTERNAL_ERROR")]
        INTERNALERROR,
        [EnumMember(Value = "USER_ALREADY_EXISTS")]
        USERALREADYEXISTS,
        [EnumMember(Value = "LICENSE_SERVER_ERROR")]
        LICENSESERVERERROR,
        [EnumMember(Value = "MODEL_CANT_BE_READ")]
        MODELCANTBEREAD,
        [EnumMember(Value = "NOT_AUTHENTICATED")]
        NOTAUTHENTICATED,
        [EnumMember(Value = "GROUP_ALREADY_EXISTS")]
        GROUPALREADYEXISTS,
        [EnumMember(Value = "UNKNOWN_GROUP")]
        UNKNOWNGROUP,
        [EnumMember(Value = "MODEL_BUILDING")]
        MODELBUILDING,
        [EnumMember(Value = "MODEL_CANT_BE_BUILT")]
        MODELCANTBEBUILT,
        [EnumMember(Value = "MODEL_STORAGE_NOT_AVAILABLE")]
        MODELSTORAGENOTAVAILABLE,
        [EnumMember(Value = "UNDEFINED_LANGUAGE")]
        UNDEFINEDLANGUAGE,
        [EnumMember(Value = "FORMAT_NOT_SUPPORTED")]
        FORMATNOTSUPPORTED,
        [EnumMember(Value = "DOCUMENT_SIZE_EXCEEDED")]
        DOCUMENTSIZEEXCEEDED,
        [EnumMember(Value = "DOCUMENT_NOT_FOUND")]
        DOCUMENTNOTFOUND,
        [EnumMember(Value = "DPI_NOT_SUFFICIENT")]
        DPINOTSUFFICIENT,
        [EnumMember(Value = "DOCUMENT_ALREADY_EXISTS")]
        DOCUMENTALREADYEXISTS,
        [EnumMember(Value = "MODEL_NOT_SPECIFIED")]
        MODELNOTSPECIFIED,
        [EnumMember(Value = "CLASS_NOT_EXISTS")]
        CLASSNOTEXISTS,
        [EnumMember(Value = "MODEL_NOT_FOUND")]
        MODELNOTFOUND,
        [EnumMember(Value = "USER_NOT_REGISTERED")]
        USERNOTREGISTERED,
        [EnumMember(Value = "PAGE_NOT_EXIST")]
        PAGENOTEXIST,
        [EnumMember(Value = "ATTACHMENT_NOT_VALID")]
        ATTACHMENTNOTVALID,
        [EnumMember(Value = "PLUGINS_CANT_BE_LOADED")]
        PLUGINSCANTBELOADED,
        [EnumMember(Value = "PLUGIN_NOT_FOUND")]
        PLUGINNOTFOUND,
        [EnumMember(Value = "DISABLED_FEATURE")]
        DISABLEDFEATURE,
        [EnumMember(Value = "METADATA_NOT_VALID")]
        METADATANOTVALID,
        [EnumMember(Value = "TRANSACTION_ABORTED")]
        TRANSACTIONABORTED,
        [EnumMember(Value = "AUTHBACKEND_INITIALIZATION_FAILED")]
        AUTHBACKENDINITIALIZATIONFAILED,
        [EnumMember(Value = "OUT_OF_MEMORY")]
        OUTOFMEMORY,
        [EnumMember(Value = "ENTITY_COULD_NOT_BE_SAVED")]
        ENTITYCOULDNOTBESAVED,
        [EnumMember(Value = "ENTITY_COULD_NOT_BE_LOADED")]
        ENTITYCOULDNOTBELOADED,
        [EnumMember(Value = "EXTRACTION_ERROR")]
        EXTRACTIONERROR,
        [EnumMember(Value = "TRANSACTION_INVALIDATED")]
        TRANSACTIONINVALIDATED,
        [EnumMember(Value = "SERVICE_NOT_AVAILABLE")]
        SERVICENOTAVAILABLE,
        [EnumMember(Value = "BACKEND_NOT_FOUND")]
        BACKENDNOTFOUND,
        [EnumMember(Value = "INCORRECT_DATA")]
        INCORRECTDATA,
        [EnumMember(Value = "USER_NOT_FOUND")]
        USERNOTFOUND,
        [EnumMember(Value = "PERMISSION_ALREADY_ASSIGNED")]
        PERMISSIONALREADYASSIGNED,
        [EnumMember(Value = "PERMISSION_NOT_FOUND")]
        PERMISSIONNOTFOUND,
        [EnumMember(Value = "ENTITY_ALREADY_EXISTS")]
        ENTITYALREADYEXISTS,
        [EnumMember(Value = "ENTITY_NOT_FOUND")]
        ENTITYNOTFOUND,
        [EnumMember(Value = "POSTPROCESSING_INITIALIZATION_FAILED")]
        POSTPROCESSINGINITIALIZATIONFAILED,
        [EnumMember(Value = "DOCUMENT_ALREADY_OPENED")]
        DOCUMENTALREADYOPENED,
        [EnumMember(Value = "DOCUMENT_OPENED_BY_ANOTHER_USER")]
        DOCUMENTOPENEDBYANOTHERUSER,
        [EnumMember(Value = "DOCUMENT_OLD_VERSION")]
        DOCUMENTOLDVERSION,
        [EnumMember(Value = "DOCUMENT_FILE_CORRUPTED")]
        DOCUMENTFILECORRUPTED,
        [EnumMember(Value = "DOCUMENT_FILE_PROTECTED")]
        DOCUMENTFILEPROTECTED,
        [EnumMember(Value = "POSTPROCESSING_PREVALIDATION_FAILED")]
        POSTPROCESSINGPREVALIDATIONFAILED,
        [EnumMember(Value = "TENANT_ALREADY_EXISTS")]
        TENANTALREADYEXISTS,
        [EnumMember(Value = "NOT_AUTHORIZED")]
        NOTAUTHORIZED,
        [EnumMember(Value = "EXPORT_NO_TEMPLATE")]
        EXPORTNOTEMPLATE,
        [EnumMember(Value = "EXPORT_FILL_ERROR")]
        EXPORTFILLERROR,
        [EnumMember(Value = "EXPORT_SAVE_ERROR")]
        EXPORTSAVEERROR,
        [EnumMember(Value = "EXPORT_REQUIRED_FIELD_MISSING")]
        EXPORTREQUIREDFIELDMISSING,
        [EnumMember(Value = "EXPORT_TEMPLATE_INVALID")]
        EXPORTTEMPLATEINVALID,
        [EnumMember(Value = "BATCH_EXPORT_NO_ROOT")]
        BATCHEXPORTNOROOT,
        [EnumMember(Value = "BATCH_EXPORT_NO_DOCS")]
        BATCHEXPORTNODOCS,
        [EnumMember(Value = "BATCH_EXPORT_TOO_MANY_DOCS")]
        BATCHEXPORTTOOMANYDOCS,
        [EnumMember(Value = "TENANT_NOT_FOUND")]
        TENANTNOTFOUND,
        [EnumMember(Value = "AUTH_BACKEND_ERROR")]
        AUTHBACKENDERROR,
        [EnumMember(Value = "REQUEST_INVALID")]
        REQUESTINVALID,
        [EnumMember(Value = "FIELD_INVALID")]
        FIELDINVALID,
        [EnumMember(Value = "REQUIRED_FIELD_MISSING")]
        REQUIREDFIELDMISSING,
        [EnumMember(Value = "FIELD_VALUE_INVALID")]
        FIELDVALUEINVALID,
        [EnumMember(Value = "FIELD_UNKNOWN")]
        FIELDUNKNOWN,
        [EnumMember(Value = "REQUEST_TIMEOUT")]
        REQUESTTIMEOUT,
        [EnumMember(Value = "NO_CHANGES")]
        NOCHANGES,
        [EnumMember(Value = "ENUM_UNKNOWN_KEY")]
        ENUMUNKNOWNKEY,
        [EnumMember(Value = "ENUM_MISSING_KEY")]
        ENUMMISSINGKEY,
        [EnumMember(Value = "ENUM_DUPLICATE_KEY")]
        ENUMDUPLICATEKEY,
        [EnumMember(Value = "VALIDATION_THRESHOLD_MET")]
        VALIDATIONTHRESHOLDMET,
        [EnumMember(Value = "VALIDATION_THRESHOLD_EXCEEDED")]
        VALIDATIONTHRESHOLDEXCEEDED,
        [EnumMember(Value = "USER_NOT_APPROVED")]
        USERNOTAPPROVED,
        [EnumMember(Value = "WHITELIST_ADDRESS_INVALID")]
        WHITELISTADDRESSINVALID,
        [EnumMember(Value = "WHITELIST_USER_ANOTHER_TENANT")]
        WHITELISTUSERANOTHERTENANT,
        [EnumMember(Value = "LICENSE_MISSING")]
        LICENSEMISSING,
        [EnumMember(Value = "LICENSE_EXPIRED")]
        LICENSEEXPIRED,
        [EnumMember(Value = "LICENSE_NOT_VALID_YET")]
        LICENSENOTVALIDYET,
        [EnumMember(Value = "LICENSE_USAGE_EXCEEDED")]
        LICENSEUSAGEEXCEEDED,
        [EnumMember(Value = "CONTAINER_PARTIALLY_REMOVED")]
        CONTAINERPARTIALLYREMOVED,
        [EnumMember(Value = "CONTAINER_CREATION_FAILED")]
        CONTAINERCREATIONFAILED,
        [EnumMember(Value = "CONTAINER_NOT_FOUND")]
        CONTAINERNOTFOUND,
        [EnumMember(Value = "CONTAINER_NOT_REMOVED")]
        CONTAINERNOTREMOVED,
        [EnumMember(Value = "DOCUMENT_NOT_RETURNED")]
        DOCUMENTNOTRETURNED,
        [EnumMember(Value = "DOCUMENT_RETURNED_NOT_SAVED")]
        DOCUMENTRETURNEDNOTSAVED,
        [EnumMember(Value = "DOCUMENT_NOT_READY")]
        DOCUMENTNOTREADY,
        [EnumMember(Value = "DOCUMENT_UNSUPPORTED_TYPE")]
        DOCUMENTUNSUPPORTEDTYPE,
        [EnumMember(Value = "DOCUMENT_EXTRACT_RESULT_NOT_FOUND")]
        DOCUMENTEXTRACTRESULTNOTFOUND,
        [EnumMember(Value = "DOCUMENT_FILE_NOT_FOUND")]
        DOCUMENTFILENOTFOUND,
        [EnumMember(Value = "DOCUMENT_FILE_UPLOAD_FAILED")]
        DOCUMENTFILEUPLOADFAILED,
        [EnumMember(Value = "DOCUMENT_FORBIDDEN_TYPE")]
        DOCUMENTFORBIDDENTYPE,
        [EnumMember(Value = "ATTACHMENT_NOT_ATTACHED")]
        ATTACHMENTNOTATTACHED,
        [EnumMember(Value = "PASSWORD_NOT_ACCEPTED")]
        PASSWORDNOTACCEPTED,
        [EnumMember(Value = "EMAIL_NOT_FOUND")]
        EMAILNOTFOUND,
        [EnumMember(Value = "NO_TEXT_DETECTED")]
        NOTEXTDETECTED,
        [EnumMember(Value = "ENTITY_DELETE_FAILED")]
        ENTITYDELETEFAILED
    }

    public enum LicenseTimePeriod
    {
        Day,
        Week,
        Month,
        Quarter,
        Year,
        Eternity
    }

    public class ApiUserApiListResult
    {
        [JsonProperty("list")]
        public ApiUser[] List { get; set; }

        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Redquesmartinvoiceca;

    public partial class WorkflowManagedActions
    {
        public RedquesmartinvoicecaActions Redquesmartinvoiceca(string connectionId) => new RedquesmartinvoicecaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RedquesmartinvoicecaTriggers Redquesmartinvoiceca(string connectionId) => new RedquesmartinvoicecaTriggers(connectionId);
    }
}