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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/configuration/return-to-issuer";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction StoreReturnDocumentConfiguration([WorkflowExpression] Func<string> bodytemplate = null, [WorkflowExpression] Func<string> bodysubject = null)
        {
            SourceExpression.Validate(bodytemplate, nameof(bodytemplate), required: false);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/configuration/return-to-issuer";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytemplate != null)
                {
                    body["template"] = SourceExpressionConverter.ConvertToken(bodytemplate);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<string> GetImage([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<int> pageIndex, [WorkflowExpression] Func<bool> isPreview = null)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(pageIndex, nameof(pageIndex), required: true);
            SourceExpression.Validate(isPreview, nameof(isPreview), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/documents/{0}/page/{1}/image", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(pageIndex, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["isPreview"] = Convert.ToString(false);
                if (isPreview != null)
                    callPayload.Queries["isPreview"] = SourceExpressionConverter.ConvertO(isPreview);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction ReturnDocument([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string[]> bodyadditionalDocuments = null, [WorkflowExpression] Func<string> bodyrecipientEmail = null, [WorkflowExpression] Func<string> bodyreason = null, [WorkflowExpression] Func<string> bodyrequestedByUserId = null)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(bodyadditionalDocuments, nameof(bodyadditionalDocuments), required: false);
            SourceExpression.Validate(bodyrecipientEmail, nameof(bodyrecipientEmail), required: false);
            SourceExpression.Validate(bodyreason, nameof(bodyreason), required: false);
            SourceExpression.Validate(bodyrequestedByUserId, nameof(bodyrequestedByUserId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/documents/{0}/return-to-issuer", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyadditionalDocuments != null)
                {
                    body["additionalDocuments"] = SourceExpressionConverter.ConvertToken(bodyadditionalDocuments);
                    bodypropCount++;
                }

                if (bodyrecipientEmail != null)
                {
                    body["recipientEmail"] = SourceExpressionConverter.ConvertToken(bodyrecipientEmail);
                    bodypropCount++;
                }

                if (bodyreason != null)
                {
                    body["reason"] = SourceExpressionConverter.ConvertToken(bodyreason);
                    bodypropCount++;
                }

                if (bodyrequestedByUserId != null)
                {
                    body["requestedByUserId"] = SourceExpressionConverter.ConvertToken(bodyrequestedByUserId);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiDocumentApiListResult> ListAllDocuments([WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<string> bodyfilterfileNamevalue = null, [WorkflowExpression] Func<DocumentState[]> bodyfilterstatevalues = null, [WorkflowExpression] Func<ApprovalState[]> bodyfilterapprovalStatevalues = null, [WorkflowExpression] Func<string> bodyfiltertypevalue = null, [WorkflowExpression] Func<string> bodyfiltersourceInfovalue = null, [WorkflowExpression] Func<bool> bodyfilterisPostProcessCompletedvalue = null, [WorkflowExpression] Func<bool> bodyfilterisReturnedToSendervalue = null, [WorkflowExpression] Func<DocumentSource[]> bodyfiltersourcevalues = null, [WorkflowExpression] Func<string[]> bodyfilterownerIdvalues = null, [WorkflowExpression] Func<string[]> bodyfiltervalidatorIdvalues = null, [WorkflowExpression] Func<string> bodyfiltercreatedDatefrom = null, [WorkflowExpression] Func<string> bodyfiltercreatedDateto = null, [WorkflowExpression] Func<string> bodyfiltervalidatedDatefrom = null, [WorkflowExpression] Func<string> bodyfiltervalidatedDateto = null, [WorkflowExpression] Func<string> bodyfilterapprovedDatefrom = null, [WorkflowExpression] Func<string> bodyfilterapprovedDateto = null, [WorkflowExpression] Func<int> bodycontrolskip = null, [WorkflowExpression] Func<int> bodycontroltake = null, [WorkflowExpression] Func<bodysortfieldInput> bodysortfield = null, [WorkflowExpression] Func<bodysortdirectionInput> bodysortdirection = null, [WorkflowExpression] Func<ApiDocumentScope[]> bodyscopes = null)
        {
            SourceExpression.Validate(bodytext, nameof(bodytext), required: false);
            SourceExpression.Validate(bodyfilterfileNamevalue, nameof(bodyfilterfileNamevalue), required: false);
            SourceExpression.Validate(bodyfilterstatevalues, nameof(bodyfilterstatevalues), required: false);
            SourceExpression.Validate(bodyfilterapprovalStatevalues, nameof(bodyfilterapprovalStatevalues), required: false);
            SourceExpression.Validate(bodyfiltertypevalue, nameof(bodyfiltertypevalue), required: false);
            SourceExpression.Validate(bodyfiltersourceInfovalue, nameof(bodyfiltersourceInfovalue), required: false);
            SourceExpression.Validate(bodyfilterisPostProcessCompletedvalue, nameof(bodyfilterisPostProcessCompletedvalue), required: false);
            SourceExpression.Validate(bodyfilterisReturnedToSendervalue, nameof(bodyfilterisReturnedToSendervalue), required: false);
            SourceExpression.Validate(bodyfiltersourcevalues, nameof(bodyfiltersourcevalues), required: false);
            SourceExpression.Validate(bodyfilterownerIdvalues, nameof(bodyfilterownerIdvalues), required: false);
            SourceExpression.Validate(bodyfiltervalidatorIdvalues, nameof(bodyfiltervalidatorIdvalues), required: false);
            SourceExpression.Validate(bodyfiltercreatedDatefrom, nameof(bodyfiltercreatedDatefrom), required: false);
            SourceExpression.Validate(bodyfiltercreatedDateto, nameof(bodyfiltercreatedDateto), required: false);
            SourceExpression.Validate(bodyfiltervalidatedDatefrom, nameof(bodyfiltervalidatedDatefrom), required: false);
            SourceExpression.Validate(bodyfiltervalidatedDateto, nameof(bodyfiltervalidatedDateto), required: false);
            SourceExpression.Validate(bodyfilterapprovedDatefrom, nameof(bodyfilterapprovedDatefrom), required: false);
            SourceExpression.Validate(bodyfilterapprovedDateto, nameof(bodyfilterapprovedDateto), required: false);
            SourceExpression.Validate(bodycontrolskip, nameof(bodycontrolskip), required: false);
            SourceExpression.Validate(bodycontroltake, nameof(bodycontroltake), required: false);
            SourceExpression.Validate(bodysortfield, nameof(bodysortfield), required: false);
            SourceExpression.Validate(bodysortdirection, nameof(bodysortdirection), required: false);
            SourceExpression.Validate(bodyscopes, nameof(bodyscopes), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/documents/list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                var fileNameObject = new JObject();
                var fileNameObjectpropCount = 0;
                if (bodyfilterfileNamevalue != null)
                {
                    fileNameObject["value"] = SourceExpressionConverter.ConvertToken(bodyfilterfileNamevalue);
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
                    stateObject["values"] = SourceExpressionConverter.ConvertToken(bodyfilterstatevalues);
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
                    approvalStateObject["values"] = SourceExpressionConverter.ConvertToken(bodyfilterapprovalStatevalues);
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
                    typeObject["value"] = SourceExpressionConverter.ConvertToken(bodyfilterfileNamevalue);
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
                    sourceInfoObject["value"] = SourceExpressionConverter.ConvertToken(bodyfiltersourceInfovalue);
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
                    isPostProcessCompletedObject["value"] = SourceExpressionConverter.ConvertToken(bodyfilterisPostProcessCompletedvalue);
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
                    isReturnedToSenderObject["value"] = SourceExpressionConverter.ConvertToken(bodyfilterisPostProcessCompletedvalue);
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
                    sourceObject["values"] = SourceExpressionConverter.ConvertToken(bodyfiltersourcevalues);
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
                    ownerIdObject["values"] = SourceExpressionConverter.ConvertToken(bodyfilterownerIdvalues);
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
                    validatorIdObject["values"] = SourceExpressionConverter.ConvertToken(bodyfilterownerIdvalues);
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
                    createdDateObject["from"] = SourceExpressionConverter.ConvertToken(bodyfiltercreatedDatefrom);
                    createdDateObjectpropCount++;
                }

                if (bodyfiltercreatedDateto != null)
                {
                    createdDateObject["to"] = SourceExpressionConverter.ConvertToken(bodyfiltercreatedDateto);
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
                    validatedDateObject["from"] = SourceExpressionConverter.ConvertToken(bodyfiltercreatedDatefrom);
                    validatedDateObjectpropCount++;
                }

                if (bodyfiltercreatedDateto != null)
                {
                    validatedDateObject["to"] = SourceExpressionConverter.ConvertToken(bodyfiltercreatedDateto);
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
                    approvedDateObject["from"] = SourceExpressionConverter.ConvertToken(bodyfiltercreatedDatefrom);
                    approvedDateObjectpropCount++;
                }

                if (bodyfiltercreatedDateto != null)
                {
                    approvedDateObject["to"] = SourceExpressionConverter.ConvertToken(bodyfiltercreatedDateto);
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
                    controlObject["skip"] = SourceExpressionConverter.ConvertToken(bodycontrolskip);
                    controlObjectpropCount++;
                }

                if (bodycontroltake != null)
                {
                    controlObject["take"] = SourceExpressionConverter.ConvertToken(bodycontroltake);
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
                    sortObject["field"] = SourceExpressionConverter.Convert(bodysortfield);
                    sortObjectpropCount++;
                }

                if (bodysortdirection != null)
                {
                    sortObject["direction"] = SourceExpressionConverter.Convert(bodysortdirection);
                    sortObjectpropCount++;
                }

                if (sortObjectpropCount > 0)
                {
                    body["sort"] = sortObject;
                    bodypropCount++;
                }

                if (bodyscopes != null)
                {
                    body["scopes"] = SourceExpressionConverter.ConvertToken(bodyscopes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ApiDocumentApiListResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction DownloadFileAsync([WorkflowExpression] Func<string> documentId)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/documents/{0}/file", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction DeleteDocument([WorkflowExpression] Func<string> documentId)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/documents/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiDocument> GetDocument([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<bool> isExternalId = null)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(isExternalId, nameof(isExternalId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/documents/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["isExternalId"] = Convert.ToString(false);
                if (isExternalId != null)
                    callPayload.Queries["isExternalId"] = SourceExpressionConverter.ConvertO(isExternalId);
                return callPayload;
            }

            return new ApiConnectionAction<ApiDocument>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<RedQueStatus> UpdateDocuments([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> bodydocumentId = null, [WorkflowExpression] Func<string> bodyexternalDocumentIdvalue = null, [WorkflowExpression] Func<string> bodycontainerIdvalue = null, [WorkflowExpression] Func<string> bodyfileNamevalue = null, [WorkflowExpression] Func<string> bodycontentTypevalue = null, [WorkflowExpression] Func<bodysourcevalueInput> bodysourcevalue = null, [WorkflowExpression] Func<string> bodysourceInfovalue = null, [WorkflowExpression] Func<string> bodydocumentClassvalue = null, [WorkflowExpression] Func<bool> bodyisAttachmentvalue = null, [WorkflowExpression] Func<bool> bodyeditedvalue = null, [WorkflowExpression] Func<string> bodynotevalue = null, [WorkflowExpression] Func<ApiFieldValueUpdate[]> bodyfields = null, [WorkflowExpression] Func<ApiFieldValueUpdate[][]> bodyitems = null, [WorkflowExpression] Func<string> bodyvalidatevalueuserId = null, [WorkflowExpression] Func<string> bodyapprovevalueuserId = null, [WorkflowExpression] Func<bodyapprovevaluestateInput> bodyapprovevaluestate = null, [WorkflowExpression] Func<StringApiListValueUpdate[]> bodyauthorizeUsers = null, [WorkflowExpression] Func<StringApiListValueUpdate[]> bodyduplicateDocIds = null)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: false);
            SourceExpression.Validate(bodyexternalDocumentIdvalue, nameof(bodyexternalDocumentIdvalue), required: false);
            SourceExpression.Validate(bodycontainerIdvalue, nameof(bodycontainerIdvalue), required: false);
            SourceExpression.Validate(bodyfileNamevalue, nameof(bodyfileNamevalue), required: false);
            SourceExpression.Validate(bodycontentTypevalue, nameof(bodycontentTypevalue), required: false);
            SourceExpression.Validate(bodysourcevalue, nameof(bodysourcevalue), required: false);
            SourceExpression.Validate(bodysourceInfovalue, nameof(bodysourceInfovalue), required: false);
            SourceExpression.Validate(bodydocumentClassvalue, nameof(bodydocumentClassvalue), required: false);
            SourceExpression.Validate(bodyisAttachmentvalue, nameof(bodyisAttachmentvalue), required: false);
            SourceExpression.Validate(bodyeditedvalue, nameof(bodyeditedvalue), required: false);
            SourceExpression.Validate(bodynotevalue, nameof(bodynotevalue), required: false);
            SourceExpression.Validate(bodyfields, nameof(bodyfields), required: false);
            SourceExpression.Validate(bodyitems, nameof(bodyitems), required: false);
            SourceExpression.Validate(bodyvalidatevalueuserId, nameof(bodyvalidatevalueuserId), required: false);
            SourceExpression.Validate(bodyapprovevalueuserId, nameof(bodyapprovevalueuserId), required: false);
            SourceExpression.Validate(bodyapprovevaluestate, nameof(bodyapprovevaluestate), required: false);
            SourceExpression.Validate(bodyauthorizeUsers, nameof(bodyauthorizeUsers), required: false);
            SourceExpression.Validate(bodyduplicateDocIds, nameof(bodyduplicateDocIds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/documents/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydocumentId != null)
                {
                    body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                    bodypropCount++;
                }

                var externalDocumentIdObject = new JObject();
                var externalDocumentIdObjectpropCount = 0;
                if (bodyexternalDocumentIdvalue != null)
                {
                    externalDocumentIdObject["value"] = SourceExpressionConverter.ConvertToken(bodyexternalDocumentIdvalue);
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
                    containerIdObject["value"] = SourceExpressionConverter.ConvertToken(bodyexternalDocumentIdvalue);
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
                    fileNameObject["value"] = SourceExpressionConverter.ConvertToken(bodyexternalDocumentIdvalue);
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
                    contentTypeObject["value"] = SourceExpressionConverter.ConvertToken(bodyexternalDocumentIdvalue);
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
                    sourceObject["value"] = SourceExpressionConverter.Convert(bodysourcevalue);
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
                    sourceInfoObject["value"] = SourceExpressionConverter.ConvertToken(bodyexternalDocumentIdvalue);
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
                    documentClassObject["value"] = SourceExpressionConverter.ConvertToken(bodyexternalDocumentIdvalue);
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
                    isAttachmentObject["value"] = SourceExpressionConverter.ConvertToken(bodyisAttachmentvalue);
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
                    editedObject["value"] = SourceExpressionConverter.ConvertToken(bodyisAttachmentvalue);
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
                    noteObject["value"] = SourceExpressionConverter.ConvertToken(bodyexternalDocumentIdvalue);
                    noteObjectpropCount++;
                }

                if (noteObjectpropCount > 0)
                {
                    body["note"] = noteObject;
                    bodypropCount++;
                }

                if (bodyfields != null)
                {
                    body["fields"] = SourceExpressionConverter.ConvertToken(bodyfields);
                    bodypropCount++;
                }

                if (bodyitems != null)
                {
                    body["items"] = SourceExpressionConverter.ConvertToken(bodyitems);
                    bodypropCount++;
                }

                var validateObject = new JObject();
                var validateObjectpropCount = 0;
                var valueObject = new JObject();
                var valueObjectpropCount = 0;
                if (bodyvalidatevalueuserId != null)
                {
                    valueObject["userId"] = SourceExpressionConverter.ConvertToken(bodyvalidatevalueuserId);
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
                var valueObject2 = new JObject();
                var valueObject2propCount = 0;
                if (bodyapprovevalueuserId != null)
                {
                    valueObject2["userId"] = SourceExpressionConverter.ConvertToken(bodyapprovevalueuserId);
                    valueObject2propCount++;
                }

                if (bodyapprovevaluestate != null)
                {
                    valueObject2["state"] = SourceExpressionConverter.Convert(bodyapprovevaluestate);
                    valueObject2propCount++;
                }

                if (valueObject2propCount > 0)
                {
                    approveObject["value"] = valueObject2;
                    approveObjectpropCount++;
                }

                if (approveObjectpropCount > 0)
                {
                    body["approve"] = approveObject;
                    bodypropCount++;
                }

                if (bodyauthorizeUsers != null)
                {
                    body["authorizeUsers"] = SourceExpressionConverter.ConvertToken(bodyauthorizeUsers);
                    bodypropCount++;
                }

                if (bodyduplicateDocIds != null)
                {
                    body["duplicateDocIds"] = SourceExpressionConverter.ConvertToken(bodyduplicateDocIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RedQueStatus>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction LockDocument([WorkflowExpression] Func<string> documentId)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/documents/{0}/lock", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction UnlockDocumentAsync([WorkflowExpression] Func<string> documentId)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/documents/{0}/lock", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction GrantDocumentAccess([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> bodydocumentId = null, [WorkflowExpression] Func<string> bodyuserId = null, [WorkflowExpression] Func<string> bodydatamessage = null)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: false);
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            SourceExpression.Validate(bodydatamessage, nameof(bodydatamessage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/documents/{0}/users/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydocumentId != null)
                {
                    body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                    bodypropCount++;
                }

                if (bodyuserId != null)
                {
                    body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (bodydatamessage != null)
                {
                    dataObject["message"] = SourceExpressionConverter.ConvertToken(bodydatamessage);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction RemoveDocumentAccess([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> userId)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(userId, nameof(userId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/documents/{0}/users/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiEnum[]> GetAllEnums()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/enums";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ApiEnum[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<StringApiValue> CreateEnum([WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<bool> bodyisEditable = null)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyisEditable, nameof(bodyisEditable), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/enums";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
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
                    body["isEditable"] = SourceExpressionConverter.ConvertToken(bodyisEditable);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<StringApiValue>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiEnum> GetEnum([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/enums/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ApiEnum>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction UpdateEnum([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<bool> bodyisEditable = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyisEditable, nameof(bodyisEditable), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/enums/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
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
                    body["isEditable"] = SourceExpressionConverter.ConvertToken(bodyisEditable);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction DeleteEnum([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/enums/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction GetExtractDocument([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/extract/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiFolderCreationResult> CreateFolder()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/folder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ApiFolderCreationResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction DownloadFolderArchived([WorkflowExpression] Func<string> folderId)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/folder/{0}/archived", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction DeleteFolder([WorkflowExpression] Func<string> folderId)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/folder/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiFolderWithMembers> GetFolder([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<bool> withMembers = null)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            SourceExpression.Validate(withMembers, nameof(withMembers), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/folder/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["withMembers"] = Convert.ToString(false);
                if (withMembers != null)
                    callPayload.Queries["withMembers"] = SourceExpressionConverter.ConvertO(withMembers);
                return callPayload;
            }

            return new ApiConnectionAction<ApiFolderWithMembers>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction UpdateContainerData([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> bodyfolderId = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodycreated = null)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            SourceExpression.Validate(bodyfolderId, nameof(bodyfolderId), required: false);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            SourceExpression.Validate(bodycreated, nameof(bodycreated), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/folder/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfolderId != null)
                {
                    body["folderId"] = SourceExpressionConverter.ConvertToken(bodyfolderId);
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["ownerId"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                    bodypropCount++;
                }

                if (bodycreated != null)
                {
                    body["created"] = SourceExpressionConverter.ConvertToken(bodycreated);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<MLicense> GetLicenseInfo()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/tenant/license";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MLicense>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<StringApiValue> GetRegisterToken()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/tenant/token";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<StringApiValue>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<StringApiValue> GenerateRegistrationToken()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/tenant/token";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<StringApiValue>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction DisableRegistrationToken()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/tenant/token";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiUserApiListResult> ListOfUsers([WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<string> bodyfilterfirstNamevalue = null, [WorkflowExpression] Func<string> bodyfilterlastNamevalue = null, [WorkflowExpression] Func<string> bodyfilteremailvalue = null, [WorkflowExpression] Func<int> bodycontrolskip = null, [WorkflowExpression] Func<int> bodycontroltake = null, [WorkflowExpression] Func<bodysortfieldInput> bodysortfield = null, [WorkflowExpression] Func<bodysortdirectionInput> bodysortdirection = null)
        {
            SourceExpression.Validate(bodytext, nameof(bodytext), required: false);
            SourceExpression.Validate(bodyfilterfirstNamevalue, nameof(bodyfilterfirstNamevalue), required: false);
            SourceExpression.Validate(bodyfilterlastNamevalue, nameof(bodyfilterlastNamevalue), required: false);
            SourceExpression.Validate(bodyfilteremailvalue, nameof(bodyfilteremailvalue), required: false);
            SourceExpression.Validate(bodycontrolskip, nameof(bodycontrolskip), required: false);
            SourceExpression.Validate(bodycontroltake, nameof(bodycontroltake), required: false);
            SourceExpression.Validate(bodysortfield, nameof(bodysortfield), required: false);
            SourceExpression.Validate(bodysortdirection, nameof(bodysortdirection), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/users/list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                var firstNameObject = new JObject();
                var firstNameObjectpropCount = 0;
                if (bodyfilterfirstNamevalue != null)
                {
                    firstNameObject["value"] = SourceExpressionConverter.ConvertToken(bodyfilterfirstNamevalue);
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
                    lastNameObject["value"] = SourceExpressionConverter.ConvertToken(bodyfilterfirstNamevalue);
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
                    emailObject["value"] = SourceExpressionConverter.ConvertToken(bodyfilterfirstNamevalue);
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
                    controlObject["skip"] = SourceExpressionConverter.ConvertToken(bodycontrolskip);
                    controlObjectpropCount++;
                }

                if (bodycontroltake != null)
                {
                    controlObject["take"] = SourceExpressionConverter.ConvertToken(bodycontroltake);
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
                    sortObject["field"] = SourceExpressionConverter.Convert(bodysortfield);
                    sortObjectpropCount++;
                }

                if (bodysortdirection != null)
                {
                    sortObject["direction"] = SourceExpressionConverter.Convert(bodysortdirection);
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
                return callPayload;
            }

            return new ApiConnectionAction<ApiUserApiListResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction CreateUser([WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodyemail = null)
        {
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfirstName != null)
                {
                    body["firstName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["lastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction ChangePassword([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/users/{0}/password", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction ForceUserPasswordChange([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodyaccountId = null, [WorkflowExpression] Func<string> bodyactivationkey = null)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            SourceExpression.Validate(bodyaccountId, nameof(bodyaccountId), required: false);
            SourceExpression.Validate(bodyactivationkey, nameof(bodyactivationkey), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/users/{0}/password", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodyaccountId != null)
                {
                    body["accountId"] = SourceExpressionConverter.ConvertToken(bodyaccountId);
                    bodypropCount++;
                }

                if (bodyactivationkey != null)
                {
                    body["activationkey"] = SourceExpressionConverter.ConvertToken(bodyactivationkey);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction DeleteUser([WorkflowExpression] Func<string> userId)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiUser> GetUser([WorkflowExpression] Func<string> userId)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ApiUser>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction UpdateUser([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfirstName != null)
                {
                    body["firstName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["lastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction AddUserPermissions([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string[]> bodypermissions = null)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(bodypermissions, nameof(bodypermissions), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/users/{0}/permission", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypermissions != null)
                {
                    body["permissions"] = SourceExpressionConverter.ConvertToken(bodypermissions);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction RemoveUserPermissions([WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string[]> bodypermissions = null)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            SourceExpression.Validate(bodypermissions, nameof(bodypermissions), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/users/{0}/permission", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypermissions != null)
                {
                    body["permissions"] = SourceExpressionConverter.ConvertToken(bodypermissions);
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
        INVALIdCONFIGFILE,
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
        ATTACHMENTNOTVALId,
        [EnumMember(Value = "PLUGINS_CANT_BE_LOADED")]
        PLUGINSCANTBELOADED,
        [EnumMember(Value = "PLUGIN_NOT_FOUND")]
        PLUGINNOTFOUND,
        [EnumMember(Value = "DISABLED_FEATURE")]
        DISABLEDFEATURE,
        [EnumMember(Value = "METADATA_NOT_VALID")]
        METADATANOTVALId,
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
        TRANSACTIONINVALIdATED,
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
        POSTPROCESSINGPREVALIdATIONFAILED,
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
        EXPORTTEMPLATEINVALId,
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
        REQUESTINVALId,
        [EnumMember(Value = "FIELD_INVALID")]
        FIELDINVALId,
        [EnumMember(Value = "REQUIRED_FIELD_MISSING")]
        REQUIREDFIELDMISSING,
        [EnumMember(Value = "FIELD_VALUE_INVALID")]
        FIELDVALUEINVALId,
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
        VALIdATIONTHRESHOLDMET,
        [EnumMember(Value = "VALIDATION_THRESHOLD_EXCEEDED")]
        VALIdATIONTHRESHOLDEXCEEDED,
        [EnumMember(Value = "USER_NOT_APPROVED")]
        USERNOTAPPROVED,
        [EnumMember(Value = "WHITELIST_ADDRESS_INVALID")]
        WHITELISTADDRESSINVALId,
        [EnumMember(Value = "WHITELIST_USER_ANOTHER_TENANT")]
        WHITELISTUSERANOTHERTENANT,
        [EnumMember(Value = "LICENSE_MISSING")]
        LICENSEMISSING,
        [EnumMember(Value = "LICENSE_EXPIRED")]
        LICENSEEXPIRED,
        [EnumMember(Value = "LICENSE_NOT_VALID_YET")]
        LICENSENOTVALIdYET,
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
        DOCUMENTFORBIdDENTYPE,
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