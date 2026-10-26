//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Redquesmartinvoiceca
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RedquesmartinvoicecaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReturnDocumentConfiguration()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/configuration/return-to-issuer";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> StoreReturnDocumentConfiguration(Expression<Func<string>> bodytemplate = null, Expression<Func<string>> bodysubject = null)
        {
            var __workflow_bodytemplate = WorkflowExpression.Compile(bodytemplate, nameof(bodytemplate), required: false);
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/configuration/return-to-issuer";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytemplate != null)
                {
                    body["template"] = ExpressionConverter.ConvertO(__workflow_bodytemplate);
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetImage(Expression<Func<string>> documentId, Expression<Func<int>> pageIndex, Expression<Func<bool>> isPreview = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_pageIndex = WorkflowExpression.Compile(pageIndex, nameof(pageIndex), required: true);
            var __workflow_isPreview = WorkflowExpression.Compile(isPreview, nameof(isPreview), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/documents/{0}/page/{1}/image", __workflow_documentId.WithUrlEncoding(1), __workflow_pageIndex.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["isPreview"] = Convert.ToString(false);
                if (__workflow_isPreview != null)
                    callPayload.Queries["isPreview"] = ExpressionConverter.Convert(__workflow_isPreview);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReturnDocument(Expression<Func<string>> documentId, Expression<Func<string[]>> bodyadditionalDocuments = null, Expression<Func<string>> bodyrecipientEmail = null, Expression<Func<string>> bodyreason = null, Expression<Func<string>> bodyrequestedByUserId = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_bodyadditionalDocuments = WorkflowExpression.Compile(bodyadditionalDocuments, nameof(bodyadditionalDocuments), required: false);
            var __workflow_bodyrecipientEmail = WorkflowExpression.Compile(bodyrecipientEmail, nameof(bodyrecipientEmail), required: false);
            var __workflow_bodyreason = WorkflowExpression.Compile(bodyreason, nameof(bodyreason), required: false);
            var __workflow_bodyrequestedByUserId = WorkflowExpression.Compile(bodyrequestedByUserId, nameof(bodyrequestedByUserId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/documents/{0}/return-to-issuer", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyadditionalDocuments != null)
                {
                    body["additionalDocuments"] = ExpressionConverter.ConvertO(__workflow_bodyadditionalDocuments);
                    bodypropCount++;
                }

                if (__workflow_bodyrecipientEmail != null)
                {
                    body["recipientEmail"] = ExpressionConverter.ConvertO(__workflow_bodyrecipientEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyreason != null)
                {
                    body["reason"] = ExpressionConverter.ConvertO(__workflow_bodyreason);
                    bodypropCount++;
                }

                if (__workflow_bodyrequestedByUserId != null)
                {
                    body["requestedByUserId"] = ExpressionConverter.ConvertO(__workflow_bodyrequestedByUserId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiDocumentApiListResult, ApiConnectionActionConfiguration> ListAllDocuments(Expression<Func<string>> bodytext = null, Expression<Func<string>> bodyfilterfileNamevalue = null, Expression<Func<DocumentState[]>> bodyfilterstatevalues = null, Expression<Func<ApprovalState[]>> bodyfilterapprovalStatevalues = null, Expression<Func<string>> bodyfiltertypevalue = null, Expression<Func<string>> bodyfiltersourceInfovalue = null, Expression<Func<bool>> bodyfilterisPostProcessCompletedvalue = null, Expression<Func<bool>> bodyfilterisReturnedToSendervalue = null, Expression<Func<DocumentSource[]>> bodyfiltersourcevalues = null, Expression<Func<string[]>> bodyfilterownerIdvalues = null, Expression<Func<string[]>> bodyfiltervalidatorIdvalues = null, Expression<Func<string>> bodyfiltercreatedDatefrom = null, Expression<Func<string>> bodyfiltercreatedDateto = null, Expression<Func<string>> bodyfiltervalidatedDatefrom = null, Expression<Func<string>> bodyfiltervalidatedDateto = null, Expression<Func<string>> bodyfilterapprovedDatefrom = null, Expression<Func<string>> bodyfilterapprovedDateto = null, Expression<Func<int>> bodycontrolskip = null, Expression<Func<int>> bodycontroltake = null, Expression<Func<bodysortfieldInput>> bodysortfield = null, Expression<Func<bodysortdirectionInput>> bodysortdirection = null, Expression<Func<ApiDocumentScope[]>> bodyscopes = null)
        {
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: false);
            var __workflow_bodyfilterfileNamevalue = WorkflowExpression.Compile(bodyfilterfileNamevalue, nameof(bodyfilterfileNamevalue), required: false);
            var __workflow_bodyfilterstatevalues = WorkflowExpression.Compile(bodyfilterstatevalues, nameof(bodyfilterstatevalues), required: false);
            var __workflow_bodyfilterapprovalStatevalues = WorkflowExpression.Compile(bodyfilterapprovalStatevalues, nameof(bodyfilterapprovalStatevalues), required: false);
            var __workflow_bodyfiltertypevalue = WorkflowExpression.Compile(bodyfiltertypevalue, nameof(bodyfiltertypevalue), required: false);
            var __workflow_bodyfiltersourceInfovalue = WorkflowExpression.Compile(bodyfiltersourceInfovalue, nameof(bodyfiltersourceInfovalue), required: false);
            var __workflow_bodyfilterisPostProcessCompletedvalue = WorkflowExpression.Compile(bodyfilterisPostProcessCompletedvalue, nameof(bodyfilterisPostProcessCompletedvalue), required: false);
            var __workflow_bodyfilterisReturnedToSendervalue = WorkflowExpression.Compile(bodyfilterisReturnedToSendervalue, nameof(bodyfilterisReturnedToSendervalue), required: false);
            var __workflow_bodyfiltersourcevalues = WorkflowExpression.Compile(bodyfiltersourcevalues, nameof(bodyfiltersourcevalues), required: false);
            var __workflow_bodyfilterownerIdvalues = WorkflowExpression.Compile(bodyfilterownerIdvalues, nameof(bodyfilterownerIdvalues), required: false);
            var __workflow_bodyfiltervalidatorIdvalues = WorkflowExpression.Compile(bodyfiltervalidatorIdvalues, nameof(bodyfiltervalidatorIdvalues), required: false);
            var __workflow_bodyfiltercreatedDatefrom = WorkflowExpression.Compile(bodyfiltercreatedDatefrom, nameof(bodyfiltercreatedDatefrom), required: false);
            var __workflow_bodyfiltercreatedDateto = WorkflowExpression.Compile(bodyfiltercreatedDateto, nameof(bodyfiltercreatedDateto), required: false);
            var __workflow_bodyfiltervalidatedDatefrom = WorkflowExpression.Compile(bodyfiltervalidatedDatefrom, nameof(bodyfiltervalidatedDatefrom), required: false);
            var __workflow_bodyfiltervalidatedDateto = WorkflowExpression.Compile(bodyfiltervalidatedDateto, nameof(bodyfiltervalidatedDateto), required: false);
            var __workflow_bodyfilterapprovedDatefrom = WorkflowExpression.Compile(bodyfilterapprovedDatefrom, nameof(bodyfilterapprovedDatefrom), required: false);
            var __workflow_bodyfilterapprovedDateto = WorkflowExpression.Compile(bodyfilterapprovedDateto, nameof(bodyfilterapprovedDateto), required: false);
            var __workflow_bodycontrolskip = WorkflowExpression.Compile(bodycontrolskip, nameof(bodycontrolskip), required: false);
            var __workflow_bodycontroltake = WorkflowExpression.Compile(bodycontroltake, nameof(bodycontroltake), required: false);
            var __workflow_bodysortfield = WorkflowExpression.Compile(bodysortfield, nameof(bodysortfield), required: false);
            var __workflow_bodysortdirection = WorkflowExpression.Compile(bodysortdirection, nameof(bodysortdirection), required: false);
            var __workflow_bodyscopes = WorkflowExpression.Compile(bodyscopes, nameof(bodyscopes), required: false);
            return new DeferredBodyAction<ApiDocumentApiListResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/documents/list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                    bodypropCount++;
                }

                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                var fileNameObject = new JObject();
                var fileNameObjectpropCount = 0;
                if (__workflow_bodyfilterfileNamevalue != null)
                {
                    fileNameObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyfilterfileNamevalue);
                    fileNameObjectpropCount++;
                }

                if (fileNameObjectpropCount > 0)
                {
                    filterObject["fileName"] = fileNameObject;
                    filterObjectpropCount++;
                }

                var stateObject = new JObject();
                var stateObjectpropCount = 0;
                if (__workflow_bodyfilterstatevalues != null)
                {
                    stateObject["values"] = ExpressionConverter.ConvertO(__workflow_bodyfilterstatevalues);
                    stateObjectpropCount++;
                }

                if (stateObjectpropCount > 0)
                {
                    filterObject["state"] = stateObject;
                    filterObjectpropCount++;
                }

                var approvalStateObject = new JObject();
                var approvalStateObjectpropCount = 0;
                if (__workflow_bodyfilterapprovalStatevalues != null)
                {
                    approvalStateObject["values"] = ExpressionConverter.ConvertO(__workflow_bodyfilterapprovalStatevalues);
                    approvalStateObjectpropCount++;
                }

                if (approvalStateObjectpropCount > 0)
                {
                    filterObject["approvalState"] = approvalStateObject;
                    filterObjectpropCount++;
                }

                var typeObject = new JObject();
                var typeObjectpropCount = 0;
                if (__workflow_bodyfilterfileNamevalue != null)
                {
                    typeObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyfilterfileNamevalue);
                    typeObjectpropCount++;
                }

                if (typeObjectpropCount > 0)
                {
                    filterObject["type"] = typeObject;
                    filterObjectpropCount++;
                }

                var sourceInfoObject = new JObject();
                var sourceInfoObjectpropCount = 0;
                if (__workflow_bodyfiltersourceInfovalue != null)
                {
                    sourceInfoObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyfiltersourceInfovalue);
                    sourceInfoObjectpropCount++;
                }

                if (sourceInfoObjectpropCount > 0)
                {
                    filterObject["sourceInfo"] = sourceInfoObject;
                    filterObjectpropCount++;
                }

                var isPostProcessCompletedObject = new JObject();
                var isPostProcessCompletedObjectpropCount = 0;
                if (__workflow_bodyfilterisPostProcessCompletedvalue != null)
                {
                    isPostProcessCompletedObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyfilterisPostProcessCompletedvalue);
                    isPostProcessCompletedObjectpropCount++;
                }

                if (isPostProcessCompletedObjectpropCount > 0)
                {
                    filterObject["isPostProcessCompleted"] = isPostProcessCompletedObject;
                    filterObjectpropCount++;
                }

                var isReturnedToSenderObject = new JObject();
                var isReturnedToSenderObjectpropCount = 0;
                if (__workflow_bodyfilterisPostProcessCompletedvalue != null)
                {
                    isReturnedToSenderObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyfilterisPostProcessCompletedvalue);
                    isReturnedToSenderObjectpropCount++;
                }

                if (isReturnedToSenderObjectpropCount > 0)
                {
                    filterObject["isReturnedToSender"] = isReturnedToSenderObject;
                    filterObjectpropCount++;
                }

                var sourceObject = new JObject();
                var sourceObjectpropCount = 0;
                if (__workflow_bodyfiltersourcevalues != null)
                {
                    sourceObject["values"] = ExpressionConverter.ConvertO(__workflow_bodyfiltersourcevalues);
                    sourceObjectpropCount++;
                }

                if (sourceObjectpropCount > 0)
                {
                    filterObject["source"] = sourceObject;
                    filterObjectpropCount++;
                }

                var ownerIdObject = new JObject();
                var ownerIdObjectpropCount = 0;
                if (__workflow_bodyfilterownerIdvalues != null)
                {
                    ownerIdObject["values"] = ExpressionConverter.ConvertO(__workflow_bodyfilterownerIdvalues);
                    ownerIdObjectpropCount++;
                }

                if (ownerIdObjectpropCount > 0)
                {
                    filterObject["ownerId"] = ownerIdObject;
                    filterObjectpropCount++;
                }

                var validatorIdObject = new JObject();
                var validatorIdObjectpropCount = 0;
                if (__workflow_bodyfilterownerIdvalues != null)
                {
                    validatorIdObject["values"] = ExpressionConverter.ConvertO(__workflow_bodyfilterownerIdvalues);
                    validatorIdObjectpropCount++;
                }

                if (validatorIdObjectpropCount > 0)
                {
                    filterObject["validatorId"] = validatorIdObject;
                    filterObjectpropCount++;
                }

                var createdDateObject = new JObject();
                var createdDateObjectpropCount = 0;
                if (__workflow_bodyfiltercreatedDatefrom != null)
                {
                    createdDateObject["from"] = ExpressionConverter.ConvertO(__workflow_bodyfiltercreatedDatefrom);
                    createdDateObjectpropCount++;
                }

                if (__workflow_bodyfiltercreatedDateto != null)
                {
                    createdDateObject["to"] = ExpressionConverter.ConvertO(__workflow_bodyfiltercreatedDateto);
                    createdDateObjectpropCount++;
                }

                if (createdDateObjectpropCount > 0)
                {
                    filterObject["createdDate"] = createdDateObject;
                    filterObjectpropCount++;
                }

                var validatedDateObject = new JObject();
                var validatedDateObjectpropCount = 0;
                if (__workflow_bodyfiltercreatedDatefrom != null)
                {
                    validatedDateObject["from"] = ExpressionConverter.ConvertO(__workflow_bodyfiltercreatedDatefrom);
                    validatedDateObjectpropCount++;
                }

                if (__workflow_bodyfiltercreatedDateto != null)
                {
                    validatedDateObject["to"] = ExpressionConverter.ConvertO(__workflow_bodyfiltercreatedDateto);
                    validatedDateObjectpropCount++;
                }

                if (validatedDateObjectpropCount > 0)
                {
                    filterObject["validatedDate"] = validatedDateObject;
                    filterObjectpropCount++;
                }

                var approvedDateObject = new JObject();
                var approvedDateObjectpropCount = 0;
                if (__workflow_bodyfiltercreatedDatefrom != null)
                {
                    approvedDateObject["from"] = ExpressionConverter.ConvertO(__workflow_bodyfiltercreatedDatefrom);
                    approvedDateObjectpropCount++;
                }

                if (__workflow_bodyfiltercreatedDateto != null)
                {
                    approvedDateObject["to"] = ExpressionConverter.ConvertO(__workflow_bodyfiltercreatedDateto);
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
                if (__workflow_bodycontrolskip != null)
                {
                    controlObject["skip"] = ExpressionConverter.ConvertO(__workflow_bodycontrolskip);
                    controlObjectpropCount++;
                }

                if (__workflow_bodycontroltake != null)
                {
                    controlObject["take"] = ExpressionConverter.ConvertO(__workflow_bodycontroltake);
                    controlObjectpropCount++;
                }

                if (controlObjectpropCount > 0)
                {
                    body["control"] = controlObject;
                    bodypropCount++;
                }

                var sortObject = new JObject();
                var sortObjectpropCount = 0;
                if (__workflow_bodysortfield != null)
                {
                    sortObject["field"] = ExpressionConverter.ConvertO(__workflow_bodysortfield);
                    sortObjectpropCount++;
                }

                if (__workflow_bodysortdirection != null)
                {
                    sortObject["direction"] = ExpressionConverter.ConvertO(__workflow_bodysortdirection);
                    sortObjectpropCount++;
                }

                if (sortObjectpropCount > 0)
                {
                    body["sort"] = sortObject;
                    bodypropCount++;
                }

                if (__workflow_bodyscopes != null)
                {
                    body["scopes"] = ExpressionConverter.ConvertO(__workflow_bodyscopes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ApiDocumentApiListResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DownloadFileAsync(Expression<Func<string>> documentId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/documents/{0}/file", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteDocument(Expression<Func<string>> documentId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/documents/{0}", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiDocument, ApiConnectionActionConfiguration> GetDocument(Expression<Func<string>> documentId, Expression<Func<bool>> isExternalId = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_isExternalId = WorkflowExpression.Compile(isExternalId, nameof(isExternalId), required: false);
            return new DeferredBodyAction<ApiDocument, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/documents/{0}", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["isExternalId"] = Convert.ToString(false);
                if (__workflow_isExternalId != null)
                    callPayload.Queries["isExternalId"] = ExpressionConverter.Convert(__workflow_isExternalId);
                return new ApiConnectionAction<ApiDocument>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<RedQueStatus, ApiConnectionActionConfiguration> UpdateDocuments(Expression<Func<string>> documentId, Expression<Func<string>> bodydocumentId = null, Expression<Func<string>> bodyexternalDocumentIdvalue = null, Expression<Func<string>> bodycontainerIdvalue = null, Expression<Func<string>> bodyfileNamevalue = null, Expression<Func<string>> bodycontentTypevalue = null, Expression<Func<bodysourcevalueInput>> bodysourcevalue = null, Expression<Func<string>> bodysourceInfovalue = null, Expression<Func<string>> bodydocumentClassvalue = null, Expression<Func<bool>> bodyisAttachmentvalue = null, Expression<Func<bool>> bodyeditedvalue = null, Expression<Func<string>> bodynotevalue = null, Expression<Func<ApiFieldValueUpdate[]>> bodyfields = null, Expression<Func<ApiFieldValueUpdate[][]>> bodyitems = null, Expression<Func<string>> bodyvalidatevalueuserId = null, Expression<Func<string>> bodyapprovevalueuserId = null, Expression<Func<bodyapprovevaluestateInput>> bodyapprovevaluestate = null, Expression<Func<StringApiListValueUpdate[]>> bodyauthorizeUsers = null, Expression<Func<StringApiListValueUpdate[]>> bodyduplicateDocIds = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: false);
            var __workflow_bodyexternalDocumentIdvalue = WorkflowExpression.Compile(bodyexternalDocumentIdvalue, nameof(bodyexternalDocumentIdvalue), required: false);
            var __workflow_bodycontainerIdvalue = WorkflowExpression.Compile(bodycontainerIdvalue, nameof(bodycontainerIdvalue), required: false);
            var __workflow_bodyfileNamevalue = WorkflowExpression.Compile(bodyfileNamevalue, nameof(bodyfileNamevalue), required: false);
            var __workflow_bodycontentTypevalue = WorkflowExpression.Compile(bodycontentTypevalue, nameof(bodycontentTypevalue), required: false);
            var __workflow_bodysourcevalue = WorkflowExpression.Compile(bodysourcevalue, nameof(bodysourcevalue), required: false);
            var __workflow_bodysourceInfovalue = WorkflowExpression.Compile(bodysourceInfovalue, nameof(bodysourceInfovalue), required: false);
            var __workflow_bodydocumentClassvalue = WorkflowExpression.Compile(bodydocumentClassvalue, nameof(bodydocumentClassvalue), required: false);
            var __workflow_bodyisAttachmentvalue = WorkflowExpression.Compile(bodyisAttachmentvalue, nameof(bodyisAttachmentvalue), required: false);
            var __workflow_bodyeditedvalue = WorkflowExpression.Compile(bodyeditedvalue, nameof(bodyeditedvalue), required: false);
            var __workflow_bodynotevalue = WorkflowExpression.Compile(bodynotevalue, nameof(bodynotevalue), required: false);
            var __workflow_bodyfields = WorkflowExpression.Compile(bodyfields, nameof(bodyfields), required: false);
            var __workflow_bodyitems = WorkflowExpression.Compile(bodyitems, nameof(bodyitems), required: false);
            var __workflow_bodyvalidatevalueuserId = WorkflowExpression.Compile(bodyvalidatevalueuserId, nameof(bodyvalidatevalueuserId), required: false);
            var __workflow_bodyapprovevalueuserId = WorkflowExpression.Compile(bodyapprovevalueuserId, nameof(bodyapprovevalueuserId), required: false);
            var __workflow_bodyapprovevaluestate = WorkflowExpression.Compile(bodyapprovevaluestate, nameof(bodyapprovevaluestate), required: false);
            var __workflow_bodyauthorizeUsers = WorkflowExpression.Compile(bodyauthorizeUsers, nameof(bodyauthorizeUsers), required: false);
            var __workflow_bodyduplicateDocIds = WorkflowExpression.Compile(bodyduplicateDocIds, nameof(bodyduplicateDocIds), required: false);
            return new DeferredBodyAction<RedQueStatus, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/documents/{0}", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydocumentId != null)
                {
                    body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                    bodypropCount++;
                }

                var externalDocumentIdObject = new JObject();
                var externalDocumentIdObjectpropCount = 0;
                if (__workflow_bodyexternalDocumentIdvalue != null)
                {
                    externalDocumentIdObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyexternalDocumentIdvalue);
                    externalDocumentIdObjectpropCount++;
                }

                if (externalDocumentIdObjectpropCount > 0)
                {
                    body["externalDocumentId"] = externalDocumentIdObject;
                    bodypropCount++;
                }

                var containerIdObject = new JObject();
                var containerIdObjectpropCount = 0;
                if (__workflow_bodyexternalDocumentIdvalue != null)
                {
                    containerIdObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyexternalDocumentIdvalue);
                    containerIdObjectpropCount++;
                }

                if (containerIdObjectpropCount > 0)
                {
                    body["containerId"] = containerIdObject;
                    bodypropCount++;
                }

                var fileNameObject = new JObject();
                var fileNameObjectpropCount = 0;
                if (__workflow_bodyexternalDocumentIdvalue != null)
                {
                    fileNameObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyexternalDocumentIdvalue);
                    fileNameObjectpropCount++;
                }

                if (fileNameObjectpropCount > 0)
                {
                    body["fileName"] = fileNameObject;
                    bodypropCount++;
                }

                var contentTypeObject = new JObject();
                var contentTypeObjectpropCount = 0;
                if (__workflow_bodyexternalDocumentIdvalue != null)
                {
                    contentTypeObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyexternalDocumentIdvalue);
                    contentTypeObjectpropCount++;
                }

                if (contentTypeObjectpropCount > 0)
                {
                    body["contentType"] = contentTypeObject;
                    bodypropCount++;
                }

                var sourceObject = new JObject();
                var sourceObjectpropCount = 0;
                if (__workflow_bodysourcevalue != null)
                {
                    sourceObject["value"] = ExpressionConverter.ConvertO(__workflow_bodysourcevalue);
                    sourceObjectpropCount++;
                }

                if (sourceObjectpropCount > 0)
                {
                    body["source"] = sourceObject;
                    bodypropCount++;
                }

                var sourceInfoObject = new JObject();
                var sourceInfoObjectpropCount = 0;
                if (__workflow_bodyexternalDocumentIdvalue != null)
                {
                    sourceInfoObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyexternalDocumentIdvalue);
                    sourceInfoObjectpropCount++;
                }

                if (sourceInfoObjectpropCount > 0)
                {
                    body["sourceInfo"] = sourceInfoObject;
                    bodypropCount++;
                }

                var documentClassObject = new JObject();
                var documentClassObjectpropCount = 0;
                if (__workflow_bodyexternalDocumentIdvalue != null)
                {
                    documentClassObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyexternalDocumentIdvalue);
                    documentClassObjectpropCount++;
                }

                if (documentClassObjectpropCount > 0)
                {
                    body["documentClass"] = documentClassObject;
                    bodypropCount++;
                }

                var isAttachmentObject = new JObject();
                var isAttachmentObjectpropCount = 0;
                if (__workflow_bodyisAttachmentvalue != null)
                {
                    isAttachmentObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyisAttachmentvalue);
                    isAttachmentObjectpropCount++;
                }

                if (isAttachmentObjectpropCount > 0)
                {
                    body["isAttachment"] = isAttachmentObject;
                    bodypropCount++;
                }

                var editedObject = new JObject();
                var editedObjectpropCount = 0;
                if (__workflow_bodyisAttachmentvalue != null)
                {
                    editedObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyisAttachmentvalue);
                    editedObjectpropCount++;
                }

                if (editedObjectpropCount > 0)
                {
                    body["edited"] = editedObject;
                    bodypropCount++;
                }

                var noteObject = new JObject();
                var noteObjectpropCount = 0;
                if (__workflow_bodyexternalDocumentIdvalue != null)
                {
                    noteObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyexternalDocumentIdvalue);
                    noteObjectpropCount++;
                }

                if (noteObjectpropCount > 0)
                {
                    body["note"] = noteObject;
                    bodypropCount++;
                }

                if (__workflow_bodyfields != null)
                {
                    body["fields"] = ExpressionConverter.ConvertO(__workflow_bodyfields);
                    bodypropCount++;
                }

                if (__workflow_bodyitems != null)
                {
                    body["items"] = ExpressionConverter.ConvertO(__workflow_bodyitems);
                    bodypropCount++;
                }

                var validateObject = new JObject();
                var validateObjectpropCount = 0;
                var valueObject = new JObject();
                var valueObjectpropCount = 0;
                if (__workflow_bodyvalidatevalueuserId != null)
                {
                    valueObject["userId"] = ExpressionConverter.ConvertO(__workflow_bodyvalidatevalueuserId);
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
                if (__workflow_bodyapprovevalueuserId != null)
                {
                    valueObject2["userId"] = ExpressionConverter.ConvertO(__workflow_bodyapprovevalueuserId);
                    valueObject2propCount++;
                }

                if (__workflow_bodyapprovevaluestate != null)
                {
                    valueObject2["state"] = ExpressionConverter.ConvertO(__workflow_bodyapprovevaluestate);
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

                if (__workflow_bodyauthorizeUsers != null)
                {
                    body["authorizeUsers"] = ExpressionConverter.ConvertO(__workflow_bodyauthorizeUsers);
                    bodypropCount++;
                }

                if (__workflow_bodyduplicateDocIds != null)
                {
                    body["duplicateDocIds"] = ExpressionConverter.ConvertO(__workflow_bodyduplicateDocIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RedQueStatus>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LockDocument(Expression<Func<string>> documentId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/documents/{0}/lock", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UnlockDocumentAsync(Expression<Func<string>> documentId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/documents/{0}/lock", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GrantDocumentAccess(Expression<Func<string>> documentId, Expression<Func<string>> userId, Expression<Func<string>> bodydocumentId = null, Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodydatamessage = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: false);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
            var __workflow_bodydatamessage = WorkflowExpression.Compile(bodydatamessage, nameof(bodydatamessage), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/documents/{0}/users/{1}", __workflow_documentId.WithUrlEncoding(1), __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydocumentId != null)
                {
                    body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                    bodypropCount++;
                }

                if (__workflow_bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (__workflow_bodydatamessage != null)
                {
                    dataObject["message"] = ExpressionConverter.ConvertO(__workflow_bodydatamessage);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveDocumentAccess(Expression<Func<string>> documentId, Expression<Func<string>> userId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/documents/{0}/users/{1}", __workflow_documentId.WithUrlEncoding(1), __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiEnum[], ApiConnectionActionConfiguration> GetAllEnums()
        {
            return new DeferredBodyAction<ApiEnum[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/enums";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ApiEnum[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<StringApiValue, ApiConnectionActionConfiguration> CreateEnum(Expression<Func<string>> bodyid = null, Expression<Func<string>> bodyname = null, Expression<Func<bool>> bodyisEditable = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyisEditable = WorkflowExpression.Compile(bodyisEditable, nameof(bodyisEditable), required: false);
            return new DeferredBodyAction<StringApiValue, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/enums";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                var valuesObject = new JObject();
                var valuesObjectpropCount = 0;
                if (valuesObjectpropCount > 0)
                {
                    body["values"] = valuesObject;
                    bodypropCount++;
                }

                if (__workflow_bodyisEditable != null)
                {
                    body["isEditable"] = ExpressionConverter.ConvertO(__workflow_bodyisEditable);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<StringApiValue>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiEnum, ApiConnectionActionConfiguration> GetEnum(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ApiEnum, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/enums/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ApiEnum>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateEnum(Expression<Func<string>> id, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodyname = null, Expression<Func<bool>> bodyisEditable = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyisEditable = WorkflowExpression.Compile(bodyisEditable, nameof(bodyisEditable), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/enums/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                var valuesObject = new JObject();
                var valuesObjectpropCount = 0;
                if (valuesObjectpropCount > 0)
                {
                    body["values"] = valuesObject;
                    bodypropCount++;
                }

                if (__workflow_bodyisEditable != null)
                {
                    body["isEditable"] = ExpressionConverter.ConvertO(__workflow_bodyisEditable);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteEnum(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/enums/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetExtractDocument(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/extract/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiFolderCreationResult, ApiConnectionActionConfiguration> CreateFolder()
        {
            return new DeferredBodyAction<ApiFolderCreationResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/folder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ApiFolderCreationResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DownloadFolderArchived(Expression<Func<string>> folderId)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/folder/{0}/archived", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteFolder(Expression<Func<string>> folderId)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/folder/{0}", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiFolderWithMembers, ApiConnectionActionConfiguration> GetFolder(Expression<Func<string>> folderId, Expression<Func<bool>> withMembers = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_withMembers = WorkflowExpression.Compile(withMembers, nameof(withMembers), required: false);
            return new DeferredBodyAction<ApiFolderWithMembers, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/folder/{0}", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["withMembers"] = Convert.ToString(false);
                if (__workflow_withMembers != null)
                    callPayload.Queries["withMembers"] = ExpressionConverter.Convert(__workflow_withMembers);
                return new ApiConnectionAction<ApiFolderWithMembers>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateContainerData(Expression<Func<string>> folderId, Expression<Func<string>> bodyfolderId = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string>> bodycreated = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_bodyfolderId = WorkflowExpression.Compile(bodyfolderId, nameof(bodyfolderId), required: false);
            var __workflow_bodyownerId = WorkflowExpression.Compile(bodyownerId, nameof(bodyownerId), required: false);
            var __workflow_bodycreated = WorkflowExpression.Compile(bodycreated, nameof(bodycreated), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/folder/{0}", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfolderId != null)
                {
                    body["folderId"] = ExpressionConverter.ConvertO(__workflow_bodyfolderId);
                    bodypropCount++;
                }

                if (__workflow_bodyownerId != null)
                {
                    body["ownerId"] = ExpressionConverter.ConvertO(__workflow_bodyownerId);
                    bodypropCount++;
                }

                if (__workflow_bodycreated != null)
                {
                    body["created"] = ExpressionConverter.ConvertO(__workflow_bodycreated);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<MLicense, ApiConnectionActionConfiguration> GetLicenseInfo()
        {
            return new DeferredBodyAction<MLicense, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/tenant/license";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MLicense>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<StringApiValue, ApiConnectionActionConfiguration> GetRegisterToken()
        {
            return new DeferredBodyAction<StringApiValue, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/tenant/token";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<StringApiValue>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<StringApiValue, ApiConnectionActionConfiguration> GenerateRegistrationToken()
        {
            return new DeferredBodyAction<StringApiValue, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/tenant/token";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<StringApiValue>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DisableRegistrationToken()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/tenant/token";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiUserApiListResult, ApiConnectionActionConfiguration> ListOfUsers(Expression<Func<string>> bodytext = null, Expression<Func<string>> bodyfilterfirstNamevalue = null, Expression<Func<string>> bodyfilterlastNamevalue = null, Expression<Func<string>> bodyfilteremailvalue = null, Expression<Func<int>> bodycontrolskip = null, Expression<Func<int>> bodycontroltake = null, Expression<Func<bodysortfieldInput>> bodysortfield = null, Expression<Func<bodysortdirectionInput>> bodysortdirection = null)
        {
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: false);
            var __workflow_bodyfilterfirstNamevalue = WorkflowExpression.Compile(bodyfilterfirstNamevalue, nameof(bodyfilterfirstNamevalue), required: false);
            var __workflow_bodyfilterlastNamevalue = WorkflowExpression.Compile(bodyfilterlastNamevalue, nameof(bodyfilterlastNamevalue), required: false);
            var __workflow_bodyfilteremailvalue = WorkflowExpression.Compile(bodyfilteremailvalue, nameof(bodyfilteremailvalue), required: false);
            var __workflow_bodycontrolskip = WorkflowExpression.Compile(bodycontrolskip, nameof(bodycontrolskip), required: false);
            var __workflow_bodycontroltake = WorkflowExpression.Compile(bodycontroltake, nameof(bodycontroltake), required: false);
            var __workflow_bodysortfield = WorkflowExpression.Compile(bodysortfield, nameof(bodysortfield), required: false);
            var __workflow_bodysortdirection = WorkflowExpression.Compile(bodysortdirection, nameof(bodysortdirection), required: false);
            return new DeferredBodyAction<ApiUserApiListResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                    bodypropCount++;
                }

                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                var firstNameObject = new JObject();
                var firstNameObjectpropCount = 0;
                if (__workflow_bodyfilterfirstNamevalue != null)
                {
                    firstNameObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyfilterfirstNamevalue);
                    firstNameObjectpropCount++;
                }

                if (firstNameObjectpropCount > 0)
                {
                    filterObject["firstName"] = firstNameObject;
                    filterObjectpropCount++;
                }

                var lastNameObject = new JObject();
                var lastNameObjectpropCount = 0;
                if (__workflow_bodyfilterfirstNamevalue != null)
                {
                    lastNameObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyfilterfirstNamevalue);
                    lastNameObjectpropCount++;
                }

                if (lastNameObjectpropCount > 0)
                {
                    filterObject["lastName"] = lastNameObject;
                    filterObjectpropCount++;
                }

                var emailObject = new JObject();
                var emailObjectpropCount = 0;
                if (__workflow_bodyfilterfirstNamevalue != null)
                {
                    emailObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyfilterfirstNamevalue);
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
                if (__workflow_bodycontrolskip != null)
                {
                    controlObject["skip"] = ExpressionConverter.ConvertO(__workflow_bodycontrolskip);
                    controlObjectpropCount++;
                }

                if (__workflow_bodycontroltake != null)
                {
                    controlObject["take"] = ExpressionConverter.ConvertO(__workflow_bodycontroltake);
                    controlObjectpropCount++;
                }

                if (controlObjectpropCount > 0)
                {
                    body["control"] = controlObject;
                    bodypropCount++;
                }

                var sortObject = new JObject();
                var sortObjectpropCount = 0;
                if (__workflow_bodysortfield != null)
                {
                    sortObject["field"] = ExpressionConverter.ConvertO(__workflow_bodysortfield);
                    sortObjectpropCount++;
                }

                if (__workflow_bodysortdirection != null)
                {
                    sortObject["direction"] = ExpressionConverter.ConvertO(__workflow_bodysortdirection);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateUser(Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodyemail = null)
        {
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfirstName != null)
                {
                    body["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ChangePassword(Expression<Func<string>> userId, Expression<Func<string>> body = null)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/users/{0}/password", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ForceUserPasswordChange(Expression<Func<string>> userId, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodyaccountId = null, Expression<Func<string>> bodyactivationkey = null)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodyaccountId = WorkflowExpression.Compile(bodyaccountId, nameof(bodyaccountId), required: false);
            var __workflow_bodyactivationkey = WorkflowExpression.Compile(bodyactivationkey, nameof(bodyactivationkey), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/users/{0}/password", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountId != null)
                {
                    body["accountId"] = ExpressionConverter.ConvertO(__workflow_bodyaccountId);
                    bodypropCount++;
                }

                if (__workflow_bodyactivationkey != null)
                {
                    body["activationkey"] = ExpressionConverter.ConvertO(__workflow_bodyactivationkey);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteUser(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiUser, ApiConnectionActionConfiguration> GetUser(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<ApiUser, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ApiUser>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateUser(Expression<Func<string>> userId, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfirstName != null)
                {
                    body["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddUserPermissions(Expression<Func<string>> userId, Expression<Func<string[]>> bodypermissions = null)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_bodypermissions = WorkflowExpression.Compile(bodypermissions, nameof(bodypermissions), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/users/{0}/permission", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodypermissions != null)
                {
                    body["permissions"] = ExpressionConverter.ConvertO(__workflow_bodypermissions);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveUserPermissions(Expression<Func<string>> userId, Expression<Func<string[]>> bodypermissions = null)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_bodypermissions = WorkflowExpression.Compile(bodypermissions, nameof(bodypermissions), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/users/{0}/permission", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodypermissions != null)
                {
                    body["permissions"] = ExpressionConverter.ConvertO(__workflow_bodypermissions);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PostProcessResult
    {
        SUCCESS,
        FAILURE
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysortfieldInput
    {
        FirstName,
        LastName,
        Email
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysortdirectionInput
    {
        Ascending,
        Descending
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ApiListValueOperation
    {
        Undefined,
        Add,
        AddIfNotExists,
        Set,
        Remove
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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