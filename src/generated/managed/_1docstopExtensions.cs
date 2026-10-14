//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors._1docstop
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class _1docstopActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Library> PalibrariesAdd(Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null, Expression<Func<int>> librarylibraryId = null, Expression<Func<int>> libraryrepositoryId = null, Expression<Func<int>> libraryrepositoryrepositoryId = null, Expression<Func<string>> libraryrepositoryname = null, Expression<Func<string>> libraryrepositorydescription = null, Expression<Func<int>> libraryrepositoryrepositoryTypeId = null, Expression<Func<int>> libraryrepositoryrepositoryTyperepositoryTypeId = null, Expression<Func<string>> libraryrepositoryrepositoryTypename = null, Expression<Func<string>> libraryrepositoryrepositoryURI = null, Expression<Func<int>> librarydocumentTypeId = null, Expression<Func<int>> librarydocumentTypedocumentTypeId = null, Expression<Func<string>> librarydocumentTypename = null, Expression<Func<string>> librarydocumentTypedescription = null, Expression<Func<string>> libraryname = null, Expression<Func<string>> librarydescription = null, Expression<Func<bool>> libraryocr = null)
        {
            var __workflow_solutionid = solutionid == null ? null : WorkflowExpression.Compile(solutionid);
            WorkflowExpression.Validate(__workflow_solutionid, nameof(solutionid), required: false);
            var __workflow_solutionkey = solutionkey == null ? null : WorkflowExpression.Compile(solutionkey);
            WorkflowExpression.Validate(__workflow_solutionkey, nameof(solutionkey), required: false);
            var __workflow_librarylibraryId = librarylibraryId == null ? null : WorkflowExpression.Compile(librarylibraryId);
            WorkflowExpression.Validate(__workflow_librarylibraryId, nameof(librarylibraryId), required: false);
            var __workflow_libraryrepositoryId = libraryrepositoryId == null ? null : WorkflowExpression.Compile(libraryrepositoryId);
            WorkflowExpression.Validate(__workflow_libraryrepositoryId, nameof(libraryrepositoryId), required: false);
            var __workflow_libraryrepositoryrepositoryId = libraryrepositoryrepositoryId == null ? null : WorkflowExpression.Compile(libraryrepositoryrepositoryId);
            WorkflowExpression.Validate(__workflow_libraryrepositoryrepositoryId, nameof(libraryrepositoryrepositoryId), required: false);
            var __workflow_libraryrepositoryname = libraryrepositoryname == null ? null : WorkflowExpression.Compile(libraryrepositoryname);
            WorkflowExpression.Validate(__workflow_libraryrepositoryname, nameof(libraryrepositoryname), required: false);
            var __workflow_libraryrepositorydescription = libraryrepositorydescription == null ? null : WorkflowExpression.Compile(libraryrepositorydescription);
            WorkflowExpression.Validate(__workflow_libraryrepositorydescription, nameof(libraryrepositorydescription), required: false);
            var __workflow_libraryrepositoryrepositoryTypeId = libraryrepositoryrepositoryTypeId == null ? null : WorkflowExpression.Compile(libraryrepositoryrepositoryTypeId);
            WorkflowExpression.Validate(__workflow_libraryrepositoryrepositoryTypeId, nameof(libraryrepositoryrepositoryTypeId), required: false);
            var __workflow_libraryrepositoryrepositoryTyperepositoryTypeId = libraryrepositoryrepositoryTyperepositoryTypeId == null ? null : WorkflowExpression.Compile(libraryrepositoryrepositoryTyperepositoryTypeId);
            WorkflowExpression.Validate(__workflow_libraryrepositoryrepositoryTyperepositoryTypeId, nameof(libraryrepositoryrepositoryTyperepositoryTypeId), required: false);
            var __workflow_libraryrepositoryrepositoryTypename = libraryrepositoryrepositoryTypename == null ? null : WorkflowExpression.Compile(libraryrepositoryrepositoryTypename);
            WorkflowExpression.Validate(__workflow_libraryrepositoryrepositoryTypename, nameof(libraryrepositoryrepositoryTypename), required: false);
            var __workflow_libraryrepositoryrepositoryURI = libraryrepositoryrepositoryURI == null ? null : WorkflowExpression.Compile(libraryrepositoryrepositoryURI);
            WorkflowExpression.Validate(__workflow_libraryrepositoryrepositoryURI, nameof(libraryrepositoryrepositoryURI), required: false);
            var __workflow_librarydocumentTypeId = librarydocumentTypeId == null ? null : WorkflowExpression.Compile(librarydocumentTypeId);
            WorkflowExpression.Validate(__workflow_librarydocumentTypeId, nameof(librarydocumentTypeId), required: false);
            var __workflow_librarydocumentTypedocumentTypeId = librarydocumentTypedocumentTypeId == null ? null : WorkflowExpression.Compile(librarydocumentTypedocumentTypeId);
            WorkflowExpression.Validate(__workflow_librarydocumentTypedocumentTypeId, nameof(librarydocumentTypedocumentTypeId), required: false);
            var __workflow_librarydocumentTypename = librarydocumentTypename == null ? null : WorkflowExpression.Compile(librarydocumentTypename);
            WorkflowExpression.Validate(__workflow_librarydocumentTypename, nameof(librarydocumentTypename), required: false);
            var __workflow_librarydocumentTypedescription = librarydocumentTypedescription == null ? null : WorkflowExpression.Compile(librarydocumentTypedescription);
            WorkflowExpression.Validate(__workflow_librarydocumentTypedescription, nameof(librarydocumentTypedescription), required: false);
            var __workflow_libraryname = libraryname == null ? null : WorkflowExpression.Compile(libraryname);
            WorkflowExpression.Validate(__workflow_libraryname, nameof(libraryname), required: false);
            var __workflow_librarydescription = librarydescription == null ? null : WorkflowExpression.Compile(librarydescription);
            WorkflowExpression.Validate(__workflow_librarydescription, nameof(librarydescription), required: false);
            var __workflow_libraryocr = libraryocr == null ? null : WorkflowExpression.Compile(libraryocr);
            WorkflowExpression.Validate(__workflow_libraryocr, nameof(libraryocr), required: false);
            return new DeferredBodyAction<Library>(() =>
            {
                var apiCallPath = "/palibraries/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                if (__workflow_solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(__workflow_solutionkey);
                var library = new JObject();
                var librarypropCount = 0;
                if (__workflow_librarylibraryId != null)
                {
                    library["libraryId"] = ExpressionConverter.ConvertO(__workflow_librarylibraryId);
                    librarypropCount++;
                }

                if (__workflow_libraryrepositoryId != null)
                {
                    library["repositoryId"] = ExpressionConverter.ConvertO(__workflow_libraryrepositoryId);
                    librarypropCount++;
                }

                if (__workflow_librarydocumentTypeId != null)
                {
                    library["documentTypeId"] = ExpressionConverter.ConvertO(__workflow_librarydocumentTypeId);
                    librarypropCount++;
                }

                var documentTypeObject = new JObject();
                var documentTypeObjectpropCount = 0;
                if (__workflow_librarydocumentTypedocumentTypeId != null)
                {
                    documentTypeObject["documentTypeId"] = ExpressionConverter.ConvertO(__workflow_librarydocumentTypedocumentTypeId);
                    documentTypeObjectpropCount++;
                }

                if (__workflow_librarydocumentTypename != null)
                {
                    documentTypeObject["name"] = ExpressionConverter.ConvertO(__workflow_librarydocumentTypename);
                    documentTypeObjectpropCount++;
                }

                if (__workflow_librarydocumentTypedescription != null)
                {
                    documentTypeObject["description"] = ExpressionConverter.ConvertO(__workflow_librarydocumentTypedescription);
                    documentTypeObjectpropCount++;
                }

                if (documentTypeObjectpropCount > 0)
                {
                    library["documentType"] = documentTypeObject;
                    librarypropCount++;
                }

                if (__workflow_libraryname != null)
                {
                    library["name"] = ExpressionConverter.ConvertO(__workflow_libraryname);
                    librarypropCount++;
                }

                if (__workflow_librarydescription != null)
                {
                    library["description"] = ExpressionConverter.ConvertO(__workflow_librarydescription);
                    librarypropCount++;
                }

                if (__workflow_libraryocr != null)
                {
                    library["ocr"] = ExpressionConverter.ConvertO(__workflow_libraryocr);
                    librarypropCount++;
                }

                if (librarypropCount > 0)
                {
                    callPayload.Body = library;
                }

                return new ApiConnectionAction<Library>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Solution> PasolutionsGet(Expression<Func<string>> solutionkey, Expression<Func<int>> solutionid = null)
        {
            var __workflow_solutionkey = solutionkey == null ? null : WorkflowExpression.Compile(solutionkey);
            WorkflowExpression.Validate(__workflow_solutionkey, nameof(solutionkey), required: true);
            var __workflow_solutionid = solutionid == null ? null : WorkflowExpression.Compile(solutionid);
            WorkflowExpression.Validate(__workflow_solutionid, nameof(solutionid), required: false);
            return new DeferredBodyAction<Solution>(() =>
            {
                var apiCallPath = "/pasolutions/get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(__workflow_solutionkey);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                return new ApiConnectionAction<Solution>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Solution[]> PasolutionsList(Expression<Func<int>> solutionid = null)
        {
            var __workflow_solutionid = solutionid == null ? null : WorkflowExpression.Compile(solutionid);
            WorkflowExpression.Validate(__workflow_solutionid, nameof(solutionid), required: false);
            return new DeferredBodyAction<Solution[]>(() =>
            {
                var apiCallPath = "/pasolutions/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                return new ApiConnectionAction<Solution[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Solution[]> PasolutionsDepartmentList(Expression<Func<string>> departmentkey, Expression<Func<int>> solutionid = null)
        {
            var __workflow_departmentkey = departmentkey == null ? null : WorkflowExpression.Compile(departmentkey);
            WorkflowExpression.Validate(__workflow_departmentkey, nameof(departmentkey), required: true);
            var __workflow_solutionid = solutionid == null ? null : WorkflowExpression.Compile(solutionid);
            WorkflowExpression.Validate(__workflow_solutionid, nameof(solutionid), required: false);
            return new DeferredBodyAction<Solution[]>(() =>
            {
                var apiCallPath = "/pasolutions/department/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["departmentkey"] = ExpressionConverter.Convert(__workflow_departmentkey);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                return new ApiConnectionAction<Solution[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Solution> PasolutionsAdd(Expression<Func<int>> solutionid = null, Expression<Func<int>> solutionsolutionId = null, Expression<Func<string>> solutionsolutionKey = null, Expression<Func<int>> solutiondepartmentdepartmentId = null, Expression<Func<string>> solutiondepartmentdepartmentKey = null, Expression<Func<int>> solutiondepartmentcustomerId = null, Expression<Func<int>> solutiondepartmentcustomercustomerId = null, Expression<Func<string>> solutiondepartmentcustomercustomerKey = null, Expression<Func<string>> solutiondepartmentcustomername = null, Expression<Func<string>> solutiondepartmentname = null, Expression<Func<string>> solutionname = null)
        {
            var __workflow_solutionid = solutionid == null ? null : WorkflowExpression.Compile(solutionid);
            WorkflowExpression.Validate(__workflow_solutionid, nameof(solutionid), required: false);
            var __workflow_solutionsolutionId = solutionsolutionId == null ? null : WorkflowExpression.Compile(solutionsolutionId);
            WorkflowExpression.Validate(__workflow_solutionsolutionId, nameof(solutionsolutionId), required: false);
            var __workflow_solutionsolutionKey = solutionsolutionKey == null ? null : WorkflowExpression.Compile(solutionsolutionKey);
            WorkflowExpression.Validate(__workflow_solutionsolutionKey, nameof(solutionsolutionKey), required: false);
            var __workflow_solutiondepartmentdepartmentId = solutiondepartmentdepartmentId == null ? null : WorkflowExpression.Compile(solutiondepartmentdepartmentId);
            WorkflowExpression.Validate(__workflow_solutiondepartmentdepartmentId, nameof(solutiondepartmentdepartmentId), required: false);
            var __workflow_solutiondepartmentdepartmentKey = solutiondepartmentdepartmentKey == null ? null : WorkflowExpression.Compile(solutiondepartmentdepartmentKey);
            WorkflowExpression.Validate(__workflow_solutiondepartmentdepartmentKey, nameof(solutiondepartmentdepartmentKey), required: false);
            var __workflow_solutiondepartmentcustomerId = solutiondepartmentcustomerId == null ? null : WorkflowExpression.Compile(solutiondepartmentcustomerId);
            WorkflowExpression.Validate(__workflow_solutiondepartmentcustomerId, nameof(solutiondepartmentcustomerId), required: false);
            var __workflow_solutiondepartmentcustomercustomerId = solutiondepartmentcustomercustomerId == null ? null : WorkflowExpression.Compile(solutiondepartmentcustomercustomerId);
            WorkflowExpression.Validate(__workflow_solutiondepartmentcustomercustomerId, nameof(solutiondepartmentcustomercustomerId), required: false);
            var __workflow_solutiondepartmentcustomercustomerKey = solutiondepartmentcustomercustomerKey == null ? null : WorkflowExpression.Compile(solutiondepartmentcustomercustomerKey);
            WorkflowExpression.Validate(__workflow_solutiondepartmentcustomercustomerKey, nameof(solutiondepartmentcustomercustomerKey), required: false);
            var __workflow_solutiondepartmentcustomername = solutiondepartmentcustomername == null ? null : WorkflowExpression.Compile(solutiondepartmentcustomername);
            WorkflowExpression.Validate(__workflow_solutiondepartmentcustomername, nameof(solutiondepartmentcustomername), required: false);
            var __workflow_solutiondepartmentname = solutiondepartmentname == null ? null : WorkflowExpression.Compile(solutiondepartmentname);
            WorkflowExpression.Validate(__workflow_solutiondepartmentname, nameof(solutiondepartmentname), required: false);
            var __workflow_solutionname = solutionname == null ? null : WorkflowExpression.Compile(solutionname);
            WorkflowExpression.Validate(__workflow_solutionname, nameof(solutionname), required: false);
            return new DeferredBodyAction<Solution>(() =>
            {
                var apiCallPath = "/pasolutions/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                var solution = new JObject();
                var solutionpropCount = 0;
                if (__workflow_solutionsolutionId != null)
                {
                    solution["solutionId"] = ExpressionConverter.ConvertO(__workflow_solutionsolutionId);
                    solutionpropCount++;
                }

                if (__workflow_solutionsolutionKey != null)
                {
                    solution["solutionKey"] = ExpressionConverter.ConvertO(__workflow_solutionsolutionKey);
                    solutionpropCount++;
                }

                if (__workflow_solutionname != null)
                {
                    solution["name"] = ExpressionConverter.ConvertO(__workflow_solutionname);
                    solutionpropCount++;
                }

                if (solutionpropCount > 0)
                {
                    callPayload.Body = solution;
                }

                return new ApiConnectionAction<Solution>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Solution> PasolutionsUpdate(Expression<Func<int>> solutionid = null, Expression<Func<int>> functionsolutionid = null, Expression<Func<int>> solutionsolutionId = null, Expression<Func<string>> solutionsolutionKey = null, Expression<Func<int>> solutiondepartmentdepartmentId = null, Expression<Func<string>> solutiondepartmentdepartmentKey = null, Expression<Func<int>> solutiondepartmentcustomerId = null, Expression<Func<int>> solutiondepartmentcustomercustomerId = null, Expression<Func<string>> solutiondepartmentcustomercustomerKey = null, Expression<Func<string>> solutiondepartmentcustomername = null, Expression<Func<string>> solutiondepartmentname = null, Expression<Func<string>> solutionname = null)
        {
            var __workflow_solutionid = solutionid == null ? null : WorkflowExpression.Compile(solutionid);
            WorkflowExpression.Validate(__workflow_solutionid, nameof(solutionid), required: false);
            var __workflow_functionsolutionid = functionsolutionid == null ? null : WorkflowExpression.Compile(functionsolutionid);
            WorkflowExpression.Validate(__workflow_functionsolutionid, nameof(functionsolutionid), required: false);
            var __workflow_solutionsolutionId = solutionsolutionId == null ? null : WorkflowExpression.Compile(solutionsolutionId);
            WorkflowExpression.Validate(__workflow_solutionsolutionId, nameof(solutionsolutionId), required: false);
            var __workflow_solutionsolutionKey = solutionsolutionKey == null ? null : WorkflowExpression.Compile(solutionsolutionKey);
            WorkflowExpression.Validate(__workflow_solutionsolutionKey, nameof(solutionsolutionKey), required: false);
            var __workflow_solutiondepartmentdepartmentId = solutiondepartmentdepartmentId == null ? null : WorkflowExpression.Compile(solutiondepartmentdepartmentId);
            WorkflowExpression.Validate(__workflow_solutiondepartmentdepartmentId, nameof(solutiondepartmentdepartmentId), required: false);
            var __workflow_solutiondepartmentdepartmentKey = solutiondepartmentdepartmentKey == null ? null : WorkflowExpression.Compile(solutiondepartmentdepartmentKey);
            WorkflowExpression.Validate(__workflow_solutiondepartmentdepartmentKey, nameof(solutiondepartmentdepartmentKey), required: false);
            var __workflow_solutiondepartmentcustomerId = solutiondepartmentcustomerId == null ? null : WorkflowExpression.Compile(solutiondepartmentcustomerId);
            WorkflowExpression.Validate(__workflow_solutiondepartmentcustomerId, nameof(solutiondepartmentcustomerId), required: false);
            var __workflow_solutiondepartmentcustomercustomerId = solutiondepartmentcustomercustomerId == null ? null : WorkflowExpression.Compile(solutiondepartmentcustomercustomerId);
            WorkflowExpression.Validate(__workflow_solutiondepartmentcustomercustomerId, nameof(solutiondepartmentcustomercustomerId), required: false);
            var __workflow_solutiondepartmentcustomercustomerKey = solutiondepartmentcustomercustomerKey == null ? null : WorkflowExpression.Compile(solutiondepartmentcustomercustomerKey);
            WorkflowExpression.Validate(__workflow_solutiondepartmentcustomercustomerKey, nameof(solutiondepartmentcustomercustomerKey), required: false);
            var __workflow_solutiondepartmentcustomername = solutiondepartmentcustomername == null ? null : WorkflowExpression.Compile(solutiondepartmentcustomername);
            WorkflowExpression.Validate(__workflow_solutiondepartmentcustomername, nameof(solutiondepartmentcustomername), required: false);
            var __workflow_solutiondepartmentname = solutiondepartmentname == null ? null : WorkflowExpression.Compile(solutiondepartmentname);
            WorkflowExpression.Validate(__workflow_solutiondepartmentname, nameof(solutiondepartmentname), required: false);
            var __workflow_solutionname = solutionname == null ? null : WorkflowExpression.Compile(solutionname);
            WorkflowExpression.Validate(__workflow_solutionname, nameof(solutionname), required: false);
            return new DeferredBodyAction<Solution>(() =>
            {
                var apiCallPath = "/pasolutions/update";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                if (__workflow_functionsolutionid != null)
                    callPayload.Queries["functionsolutionid"] = ExpressionConverter.Convert(__workflow_functionsolutionid);
                var solution = new JObject();
                var solutionpropCount = 0;
                if (__workflow_solutionsolutionId != null)
                {
                    solution["solutionId"] = ExpressionConverter.ConvertO(__workflow_solutionsolutionId);
                    solutionpropCount++;
                }

                if (__workflow_solutionsolutionKey != null)
                {
                    solution["solutionKey"] = ExpressionConverter.ConvertO(__workflow_solutionsolutionKey);
                    solutionpropCount++;
                }

                if (__workflow_solutionname != null)
                {
                    solution["name"] = ExpressionConverter.ConvertO(__workflow_solutionname);
                    solutionpropCount++;
                }

                if (solutionpropCount > 0)
                {
                    callPayload.Body = solution;
                }

                return new ApiConnectionAction<Solution>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Document> PadocumentsAdd(Expression<Func<int>> libraryid, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null, Expression<Func<string>> documentdocumentKey = null, Expression<Func<string>> documentname = null, Expression<Func<int>> documentfileSizeBytes = null, Expression<Func<int>> documentstatus = null, Expression<Func<PropertyValue[]>> documentpropertyValues = null, Expression<Func<string>> documenturl = null)
        {
            var __workflow_libraryid = libraryid == null ? null : WorkflowExpression.Compile(libraryid);
            WorkflowExpression.Validate(__workflow_libraryid, nameof(libraryid), required: true);
            var __workflow_solutionid = solutionid == null ? null : WorkflowExpression.Compile(solutionid);
            WorkflowExpression.Validate(__workflow_solutionid, nameof(solutionid), required: false);
            var __workflow_solutionkey = solutionkey == null ? null : WorkflowExpression.Compile(solutionkey);
            WorkflowExpression.Validate(__workflow_solutionkey, nameof(solutionkey), required: false);
            var __workflow_documentdocumentKey = documentdocumentKey == null ? null : WorkflowExpression.Compile(documentdocumentKey);
            WorkflowExpression.Validate(__workflow_documentdocumentKey, nameof(documentdocumentKey), required: false);
            var __workflow_documentname = documentname == null ? null : WorkflowExpression.Compile(documentname);
            WorkflowExpression.Validate(__workflow_documentname, nameof(documentname), required: false);
            var __workflow_documentfileSizeBytes = documentfileSizeBytes == null ? null : WorkflowExpression.Compile(documentfileSizeBytes);
            WorkflowExpression.Validate(__workflow_documentfileSizeBytes, nameof(documentfileSizeBytes), required: false);
            var __workflow_documentstatus = documentstatus == null ? null : WorkflowExpression.Compile(documentstatus);
            WorkflowExpression.Validate(__workflow_documentstatus, nameof(documentstatus), required: false);
            var __workflow_documentpropertyValues = documentpropertyValues == null ? null : WorkflowExpression.Compile(documentpropertyValues);
            WorkflowExpression.Validate(__workflow_documentpropertyValues, nameof(documentpropertyValues), required: false);
            var __workflow_documenturl = documenturl == null ? null : WorkflowExpression.Compile(documenturl);
            WorkflowExpression.Validate(__workflow_documenturl, nameof(documenturl), required: false);
            return new DeferredBodyAction<Document>(() =>
            {
                var apiCallPath = "/padocuments/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryid"] = ExpressionConverter.Convert(__workflow_libraryid);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                if (__workflow_solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(__workflow_solutionkey);
                var document = new JObject();
                var documentpropCount = 0;
                if (__workflow_documentdocumentKey != null)
                {
                    document["documentKey"] = ExpressionConverter.ConvertO(__workflow_documentdocumentKey);
                    documentpropCount++;
                }

                if (__workflow_documentname != null)
                {
                    document["name"] = ExpressionConverter.ConvertO(__workflow_documentname);
                    documentpropCount++;
                }

                if (__workflow_documentfileSizeBytes != null)
                {
                    document["fileSizeBytes"] = ExpressionConverter.ConvertO(__workflow_documentfileSizeBytes);
                    documentpropCount++;
                }

                if (__workflow_documentstatus != null)
                {
                    document["status"] = ExpressionConverter.ConvertO(__workflow_documentstatus);
                    documentpropCount++;
                }

                if (__workflow_documentpropertyValues != null)
                {
                    document["propertyValues"] = ExpressionConverter.ConvertO(__workflow_documentpropertyValues);
                    documentpropCount++;
                }

                if (__workflow_documenturl != null)
                {
                    document["url"] = ExpressionConverter.ConvertO(__workflow_documenturl);
                    documentpropCount++;
                }

                if (documentpropCount > 0)
                {
                    callPayload.Body = document;
                }

                return new ApiConnectionAction<Document>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<DocumentType> PadocumenttypesGet(Expression<Func<int>> documenttypeid, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null)
        {
            var __workflow_documenttypeid = documenttypeid == null ? null : WorkflowExpression.Compile(documenttypeid);
            WorkflowExpression.Validate(__workflow_documenttypeid, nameof(documenttypeid), required: true);
            var __workflow_solutionid = solutionid == null ? null : WorkflowExpression.Compile(solutionid);
            WorkflowExpression.Validate(__workflow_solutionid, nameof(solutionid), required: false);
            var __workflow_solutionkey = solutionkey == null ? null : WorkflowExpression.Compile(solutionkey);
            WorkflowExpression.Validate(__workflow_solutionkey, nameof(solutionkey), required: false);
            return new DeferredBodyAction<DocumentType>(() =>
            {
                var apiCallPath = "/padocumenttypes/get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documenttypeid"] = ExpressionConverter.Convert(__workflow_documenttypeid);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                if (__workflow_solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(__workflow_solutionkey);
                return new ApiConnectionAction<DocumentType>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<DocumentType[]> PadocumenttypesList(Expression<Func<string>> solutionkey, Expression<Func<int>> solutionid = null)
        {
            var __workflow_solutionkey = solutionkey == null ? null : WorkflowExpression.Compile(solutionkey);
            WorkflowExpression.Validate(__workflow_solutionkey, nameof(solutionkey), required: true);
            var __workflow_solutionid = solutionid == null ? null : WorkflowExpression.Compile(solutionid);
            WorkflowExpression.Validate(__workflow_solutionid, nameof(solutionid), required: false);
            return new DeferredBodyAction<DocumentType[]>(() =>
            {
                var apiCallPath = "/padocumenttypes/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(__workflow_solutionkey);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                return new ApiConnectionAction<DocumentType[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Library> PadocumenttypesAdd(Expression<Func<string>> solutionkey, Expression<Func<int>> solutionid = null, Expression<Func<int>> librarylibraryId = null, Expression<Func<int>> libraryrepositoryId = null, Expression<Func<int>> libraryrepositoryrepositoryId = null, Expression<Func<string>> libraryrepositoryname = null, Expression<Func<string>> libraryrepositorydescription = null, Expression<Func<int>> libraryrepositoryrepositoryTypeId = null, Expression<Func<int>> libraryrepositoryrepositoryTyperepositoryTypeId = null, Expression<Func<string>> libraryrepositoryrepositoryTypename = null, Expression<Func<string>> libraryrepositoryrepositoryURI = null, Expression<Func<int>> librarydocumentTypeId = null, Expression<Func<int>> librarydocumentTypedocumentTypeId = null, Expression<Func<string>> librarydocumentTypename = null, Expression<Func<string>> librarydocumentTypedescription = null, Expression<Func<string>> libraryname = null, Expression<Func<string>> librarydescription = null, Expression<Func<bool>> libraryocr = null)
        {
            var __workflow_solutionkey = solutionkey == null ? null : WorkflowExpression.Compile(solutionkey);
            WorkflowExpression.Validate(__workflow_solutionkey, nameof(solutionkey), required: true);
            var __workflow_solutionid = solutionid == null ? null : WorkflowExpression.Compile(solutionid);
            WorkflowExpression.Validate(__workflow_solutionid, nameof(solutionid), required: false);
            var __workflow_librarylibraryId = librarylibraryId == null ? null : WorkflowExpression.Compile(librarylibraryId);
            WorkflowExpression.Validate(__workflow_librarylibraryId, nameof(librarylibraryId), required: false);
            var __workflow_libraryrepositoryId = libraryrepositoryId == null ? null : WorkflowExpression.Compile(libraryrepositoryId);
            WorkflowExpression.Validate(__workflow_libraryrepositoryId, nameof(libraryrepositoryId), required: false);
            var __workflow_libraryrepositoryrepositoryId = libraryrepositoryrepositoryId == null ? null : WorkflowExpression.Compile(libraryrepositoryrepositoryId);
            WorkflowExpression.Validate(__workflow_libraryrepositoryrepositoryId, nameof(libraryrepositoryrepositoryId), required: false);
            var __workflow_libraryrepositoryname = libraryrepositoryname == null ? null : WorkflowExpression.Compile(libraryrepositoryname);
            WorkflowExpression.Validate(__workflow_libraryrepositoryname, nameof(libraryrepositoryname), required: false);
            var __workflow_libraryrepositorydescription = libraryrepositorydescription == null ? null : WorkflowExpression.Compile(libraryrepositorydescription);
            WorkflowExpression.Validate(__workflow_libraryrepositorydescription, nameof(libraryrepositorydescription), required: false);
            var __workflow_libraryrepositoryrepositoryTypeId = libraryrepositoryrepositoryTypeId == null ? null : WorkflowExpression.Compile(libraryrepositoryrepositoryTypeId);
            WorkflowExpression.Validate(__workflow_libraryrepositoryrepositoryTypeId, nameof(libraryrepositoryrepositoryTypeId), required: false);
            var __workflow_libraryrepositoryrepositoryTyperepositoryTypeId = libraryrepositoryrepositoryTyperepositoryTypeId == null ? null : WorkflowExpression.Compile(libraryrepositoryrepositoryTyperepositoryTypeId);
            WorkflowExpression.Validate(__workflow_libraryrepositoryrepositoryTyperepositoryTypeId, nameof(libraryrepositoryrepositoryTyperepositoryTypeId), required: false);
            var __workflow_libraryrepositoryrepositoryTypename = libraryrepositoryrepositoryTypename == null ? null : WorkflowExpression.Compile(libraryrepositoryrepositoryTypename);
            WorkflowExpression.Validate(__workflow_libraryrepositoryrepositoryTypename, nameof(libraryrepositoryrepositoryTypename), required: false);
            var __workflow_libraryrepositoryrepositoryURI = libraryrepositoryrepositoryURI == null ? null : WorkflowExpression.Compile(libraryrepositoryrepositoryURI);
            WorkflowExpression.Validate(__workflow_libraryrepositoryrepositoryURI, nameof(libraryrepositoryrepositoryURI), required: false);
            var __workflow_librarydocumentTypeId = librarydocumentTypeId == null ? null : WorkflowExpression.Compile(librarydocumentTypeId);
            WorkflowExpression.Validate(__workflow_librarydocumentTypeId, nameof(librarydocumentTypeId), required: false);
            var __workflow_librarydocumentTypedocumentTypeId = librarydocumentTypedocumentTypeId == null ? null : WorkflowExpression.Compile(librarydocumentTypedocumentTypeId);
            WorkflowExpression.Validate(__workflow_librarydocumentTypedocumentTypeId, nameof(librarydocumentTypedocumentTypeId), required: false);
            var __workflow_librarydocumentTypename = librarydocumentTypename == null ? null : WorkflowExpression.Compile(librarydocumentTypename);
            WorkflowExpression.Validate(__workflow_librarydocumentTypename, nameof(librarydocumentTypename), required: false);
            var __workflow_librarydocumentTypedescription = librarydocumentTypedescription == null ? null : WorkflowExpression.Compile(librarydocumentTypedescription);
            WorkflowExpression.Validate(__workflow_librarydocumentTypedescription, nameof(librarydocumentTypedescription), required: false);
            var __workflow_libraryname = libraryname == null ? null : WorkflowExpression.Compile(libraryname);
            WorkflowExpression.Validate(__workflow_libraryname, nameof(libraryname), required: false);
            var __workflow_librarydescription = librarydescription == null ? null : WorkflowExpression.Compile(librarydescription);
            WorkflowExpression.Validate(__workflow_librarydescription, nameof(librarydescription), required: false);
            var __workflow_libraryocr = libraryocr == null ? null : WorkflowExpression.Compile(libraryocr);
            WorkflowExpression.Validate(__workflow_libraryocr, nameof(libraryocr), required: false);
            return new DeferredBodyAction<Library>(() =>
            {
                var apiCallPath = "/padocumenttypes/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(__workflow_solutionkey);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                var library = new JObject();
                var librarypropCount = 0;
                if (__workflow_librarylibraryId != null)
                {
                    library["libraryId"] = ExpressionConverter.ConvertO(__workflow_librarylibraryId);
                    librarypropCount++;
                }

                if (__workflow_libraryrepositoryId != null)
                {
                    library["repositoryId"] = ExpressionConverter.ConvertO(__workflow_libraryrepositoryId);
                    librarypropCount++;
                }

                if (__workflow_librarydocumentTypeId != null)
                {
                    library["documentTypeId"] = ExpressionConverter.ConvertO(__workflow_librarydocumentTypeId);
                    librarypropCount++;
                }

                var documentTypeObject = new JObject();
                var documentTypeObjectpropCount = 0;
                if (__workflow_librarydocumentTypedocumentTypeId != null)
                {
                    documentTypeObject["documentTypeId"] = ExpressionConverter.ConvertO(__workflow_librarydocumentTypedocumentTypeId);
                    documentTypeObjectpropCount++;
                }

                if (__workflow_librarydocumentTypename != null)
                {
                    documentTypeObject["name"] = ExpressionConverter.ConvertO(__workflow_librarydocumentTypename);
                    documentTypeObjectpropCount++;
                }

                if (__workflow_librarydocumentTypedescription != null)
                {
                    documentTypeObject["description"] = ExpressionConverter.ConvertO(__workflow_librarydocumentTypedescription);
                    documentTypeObjectpropCount++;
                }

                if (documentTypeObjectpropCount > 0)
                {
                    library["documentType"] = documentTypeObject;
                    librarypropCount++;
                }

                if (__workflow_libraryname != null)
                {
                    library["name"] = ExpressionConverter.ConvertO(__workflow_libraryname);
                    librarypropCount++;
                }

                if (__workflow_librarydescription != null)
                {
                    library["description"] = ExpressionConverter.ConvertO(__workflow_librarydescription);
                    librarypropCount++;
                }

                if (__workflow_libraryocr != null)
                {
                    library["ocr"] = ExpressionConverter.ConvertO(__workflow_libraryocr);
                    librarypropCount++;
                }

                if (librarypropCount > 0)
                {
                    callPayload.Body = library;
                }

                return new ApiConnectionAction<Library>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<DocumentType> PadocumenttypesUpdate(Expression<Func<int>> documenttypeid, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null, Expression<Func<int>> documentTypedocumentTypeId = null, Expression<Func<string>> documentTypename = null, Expression<Func<string>> documentTypedescription = null)
        {
            var __workflow_documenttypeid = documenttypeid == null ? null : WorkflowExpression.Compile(documenttypeid);
            WorkflowExpression.Validate(__workflow_documenttypeid, nameof(documenttypeid), required: true);
            var __workflow_solutionid = solutionid == null ? null : WorkflowExpression.Compile(solutionid);
            WorkflowExpression.Validate(__workflow_solutionid, nameof(solutionid), required: false);
            var __workflow_solutionkey = solutionkey == null ? null : WorkflowExpression.Compile(solutionkey);
            WorkflowExpression.Validate(__workflow_solutionkey, nameof(solutionkey), required: false);
            var __workflow_documentTypedocumentTypeId = documentTypedocumentTypeId == null ? null : WorkflowExpression.Compile(documentTypedocumentTypeId);
            WorkflowExpression.Validate(__workflow_documentTypedocumentTypeId, nameof(documentTypedocumentTypeId), required: false);
            var __workflow_documentTypename = documentTypename == null ? null : WorkflowExpression.Compile(documentTypename);
            WorkflowExpression.Validate(__workflow_documentTypename, nameof(documentTypename), required: false);
            var __workflow_documentTypedescription = documentTypedescription == null ? null : WorkflowExpression.Compile(documentTypedescription);
            WorkflowExpression.Validate(__workflow_documentTypedescription, nameof(documentTypedescription), required: false);
            return new DeferredBodyAction<DocumentType>(() =>
            {
                var apiCallPath = "/padocumenttypes/update";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documenttypeid"] = ExpressionConverter.Convert(__workflow_documenttypeid);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                if (__workflow_solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(__workflow_solutionkey);
                var documentType = new JObject();
                var documentTypepropCount = 0;
                if (__workflow_documentTypedocumentTypeId != null)
                {
                    documentType["documentTypeId"] = ExpressionConverter.ConvertO(__workflow_documentTypedocumentTypeId);
                    documentTypepropCount++;
                }

                if (__workflow_documentTypename != null)
                {
                    documentType["name"] = ExpressionConverter.ConvertO(__workflow_documentTypename);
                    documentTypepropCount++;
                }

                if (__workflow_documentTypedescription != null)
                {
                    documentType["description"] = ExpressionConverter.ConvertO(__workflow_documentTypedescription);
                    documentTypepropCount++;
                }

                if (documentTypepropCount > 0)
                {
                    callPayload.Body = documentType;
                }

                return new ApiConnectionAction<DocumentType>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Library> PalibrariesGet(Expression<Func<int>> libraryid, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null)
        {
            var __workflow_libraryid = libraryid == null ? null : WorkflowExpression.Compile(libraryid);
            WorkflowExpression.Validate(__workflow_libraryid, nameof(libraryid), required: true);
            var __workflow_solutionid = solutionid == null ? null : WorkflowExpression.Compile(solutionid);
            WorkflowExpression.Validate(__workflow_solutionid, nameof(solutionid), required: false);
            var __workflow_solutionkey = solutionkey == null ? null : WorkflowExpression.Compile(solutionkey);
            WorkflowExpression.Validate(__workflow_solutionkey, nameof(solutionkey), required: false);
            return new DeferredBodyAction<Library>(() =>
            {
                var apiCallPath = "/palibraries/get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryid"] = ExpressionConverter.Convert(__workflow_libraryid);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                if (__workflow_solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(__workflow_solutionkey);
                return new ApiConnectionAction<Library>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Library[]> PalibrariesList(Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null)
        {
            var __workflow_solutionid = solutionid == null ? null : WorkflowExpression.Compile(solutionid);
            WorkflowExpression.Validate(__workflow_solutionid, nameof(solutionid), required: false);
            var __workflow_solutionkey = solutionkey == null ? null : WorkflowExpression.Compile(solutionkey);
            WorkflowExpression.Validate(__workflow_solutionkey, nameof(solutionkey), required: false);
            return new DeferredBodyAction<Library[]>(() =>
            {
                var apiCallPath = "/palibraries/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                if (__workflow_solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(__workflow_solutionkey);
                return new ApiConnectionAction<Library[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Library[]> PalibrariesDocumenttypeList(Expression<Func<int>> documenttypeid, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null)
        {
            var __workflow_documenttypeid = documenttypeid == null ? null : WorkflowExpression.Compile(documenttypeid);
            WorkflowExpression.Validate(__workflow_documenttypeid, nameof(documenttypeid), required: true);
            var __workflow_solutionid = solutionid == null ? null : WorkflowExpression.Compile(solutionid);
            WorkflowExpression.Validate(__workflow_solutionid, nameof(solutionid), required: false);
            var __workflow_solutionkey = solutionkey == null ? null : WorkflowExpression.Compile(solutionkey);
            WorkflowExpression.Validate(__workflow_solutionkey, nameof(solutionkey), required: false);
            return new DeferredBodyAction<Library[]>(() =>
            {
                var apiCallPath = "/palibraries/documenttype/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documenttypeid"] = ExpressionConverter.Convert(__workflow_documenttypeid);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                if (__workflow_solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(__workflow_solutionkey);
                return new ApiConnectionAction<Library[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Library> PalibrariesUpdate(Expression<Func<int>> libraryid, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null, Expression<Func<int>> librarylibraryId = null, Expression<Func<int>> libraryrepositoryId = null, Expression<Func<int>> libraryrepositoryrepositoryId = null, Expression<Func<string>> libraryrepositoryname = null, Expression<Func<string>> libraryrepositorydescription = null, Expression<Func<int>> libraryrepositoryrepositoryTypeId = null, Expression<Func<int>> libraryrepositoryrepositoryTyperepositoryTypeId = null, Expression<Func<string>> libraryrepositoryrepositoryTypename = null, Expression<Func<string>> libraryrepositoryrepositoryURI = null, Expression<Func<int>> librarydocumentTypeId = null, Expression<Func<int>> librarydocumentTypedocumentTypeId = null, Expression<Func<string>> librarydocumentTypename = null, Expression<Func<string>> librarydocumentTypedescription = null, Expression<Func<string>> libraryname = null, Expression<Func<string>> librarydescription = null, Expression<Func<bool>> libraryocr = null)
        {
            var __workflow_libraryid = libraryid == null ? null : WorkflowExpression.Compile(libraryid);
            WorkflowExpression.Validate(__workflow_libraryid, nameof(libraryid), required: true);
            var __workflow_solutionid = solutionid == null ? null : WorkflowExpression.Compile(solutionid);
            WorkflowExpression.Validate(__workflow_solutionid, nameof(solutionid), required: false);
            var __workflow_solutionkey = solutionkey == null ? null : WorkflowExpression.Compile(solutionkey);
            WorkflowExpression.Validate(__workflow_solutionkey, nameof(solutionkey), required: false);
            var __workflow_librarylibraryId = librarylibraryId == null ? null : WorkflowExpression.Compile(librarylibraryId);
            WorkflowExpression.Validate(__workflow_librarylibraryId, nameof(librarylibraryId), required: false);
            var __workflow_libraryrepositoryId = libraryrepositoryId == null ? null : WorkflowExpression.Compile(libraryrepositoryId);
            WorkflowExpression.Validate(__workflow_libraryrepositoryId, nameof(libraryrepositoryId), required: false);
            var __workflow_libraryrepositoryrepositoryId = libraryrepositoryrepositoryId == null ? null : WorkflowExpression.Compile(libraryrepositoryrepositoryId);
            WorkflowExpression.Validate(__workflow_libraryrepositoryrepositoryId, nameof(libraryrepositoryrepositoryId), required: false);
            var __workflow_libraryrepositoryname = libraryrepositoryname == null ? null : WorkflowExpression.Compile(libraryrepositoryname);
            WorkflowExpression.Validate(__workflow_libraryrepositoryname, nameof(libraryrepositoryname), required: false);
            var __workflow_libraryrepositorydescription = libraryrepositorydescription == null ? null : WorkflowExpression.Compile(libraryrepositorydescription);
            WorkflowExpression.Validate(__workflow_libraryrepositorydescription, nameof(libraryrepositorydescription), required: false);
            var __workflow_libraryrepositoryrepositoryTypeId = libraryrepositoryrepositoryTypeId == null ? null : WorkflowExpression.Compile(libraryrepositoryrepositoryTypeId);
            WorkflowExpression.Validate(__workflow_libraryrepositoryrepositoryTypeId, nameof(libraryrepositoryrepositoryTypeId), required: false);
            var __workflow_libraryrepositoryrepositoryTyperepositoryTypeId = libraryrepositoryrepositoryTyperepositoryTypeId == null ? null : WorkflowExpression.Compile(libraryrepositoryrepositoryTyperepositoryTypeId);
            WorkflowExpression.Validate(__workflow_libraryrepositoryrepositoryTyperepositoryTypeId, nameof(libraryrepositoryrepositoryTyperepositoryTypeId), required: false);
            var __workflow_libraryrepositoryrepositoryTypename = libraryrepositoryrepositoryTypename == null ? null : WorkflowExpression.Compile(libraryrepositoryrepositoryTypename);
            WorkflowExpression.Validate(__workflow_libraryrepositoryrepositoryTypename, nameof(libraryrepositoryrepositoryTypename), required: false);
            var __workflow_libraryrepositoryrepositoryURI = libraryrepositoryrepositoryURI == null ? null : WorkflowExpression.Compile(libraryrepositoryrepositoryURI);
            WorkflowExpression.Validate(__workflow_libraryrepositoryrepositoryURI, nameof(libraryrepositoryrepositoryURI), required: false);
            var __workflow_librarydocumentTypeId = librarydocumentTypeId == null ? null : WorkflowExpression.Compile(librarydocumentTypeId);
            WorkflowExpression.Validate(__workflow_librarydocumentTypeId, nameof(librarydocumentTypeId), required: false);
            var __workflow_librarydocumentTypedocumentTypeId = librarydocumentTypedocumentTypeId == null ? null : WorkflowExpression.Compile(librarydocumentTypedocumentTypeId);
            WorkflowExpression.Validate(__workflow_librarydocumentTypedocumentTypeId, nameof(librarydocumentTypedocumentTypeId), required: false);
            var __workflow_librarydocumentTypename = librarydocumentTypename == null ? null : WorkflowExpression.Compile(librarydocumentTypename);
            WorkflowExpression.Validate(__workflow_librarydocumentTypename, nameof(librarydocumentTypename), required: false);
            var __workflow_librarydocumentTypedescription = librarydocumentTypedescription == null ? null : WorkflowExpression.Compile(librarydocumentTypedescription);
            WorkflowExpression.Validate(__workflow_librarydocumentTypedescription, nameof(librarydocumentTypedescription), required: false);
            var __workflow_libraryname = libraryname == null ? null : WorkflowExpression.Compile(libraryname);
            WorkflowExpression.Validate(__workflow_libraryname, nameof(libraryname), required: false);
            var __workflow_librarydescription = librarydescription == null ? null : WorkflowExpression.Compile(librarydescription);
            WorkflowExpression.Validate(__workflow_librarydescription, nameof(librarydescription), required: false);
            var __workflow_libraryocr = libraryocr == null ? null : WorkflowExpression.Compile(libraryocr);
            WorkflowExpression.Validate(__workflow_libraryocr, nameof(libraryocr), required: false);
            return new DeferredBodyAction<Library>(() =>
            {
                var apiCallPath = "/palibraries/update";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryid"] = ExpressionConverter.Convert(__workflow_libraryid);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                if (__workflow_solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(__workflow_solutionkey);
                var library = new JObject();
                var librarypropCount = 0;
                if (__workflow_librarylibraryId != null)
                {
                    library["libraryId"] = ExpressionConverter.ConvertO(__workflow_librarylibraryId);
                    librarypropCount++;
                }

                if (__workflow_libraryrepositoryId != null)
                {
                    library["repositoryId"] = ExpressionConverter.ConvertO(__workflow_libraryrepositoryId);
                    librarypropCount++;
                }

                if (__workflow_librarydocumentTypeId != null)
                {
                    library["documentTypeId"] = ExpressionConverter.ConvertO(__workflow_librarydocumentTypeId);
                    librarypropCount++;
                }

                var documentTypeObject = new JObject();
                var documentTypeObjectpropCount = 0;
                if (__workflow_librarydocumentTypedocumentTypeId != null)
                {
                    documentTypeObject["documentTypeId"] = ExpressionConverter.ConvertO(__workflow_librarydocumentTypedocumentTypeId);
                    documentTypeObjectpropCount++;
                }

                if (__workflow_librarydocumentTypename != null)
                {
                    documentTypeObject["name"] = ExpressionConverter.ConvertO(__workflow_librarydocumentTypename);
                    documentTypeObjectpropCount++;
                }

                if (__workflow_librarydocumentTypedescription != null)
                {
                    documentTypeObject["description"] = ExpressionConverter.ConvertO(__workflow_librarydocumentTypedescription);
                    documentTypeObjectpropCount++;
                }

                if (documentTypeObjectpropCount > 0)
                {
                    library["documentType"] = documentTypeObject;
                    librarypropCount++;
                }

                if (__workflow_libraryname != null)
                {
                    library["name"] = ExpressionConverter.ConvertO(__workflow_libraryname);
                    librarypropCount++;
                }

                if (__workflow_librarydescription != null)
                {
                    library["description"] = ExpressionConverter.ConvertO(__workflow_librarydescription);
                    librarypropCount++;
                }

                if (__workflow_libraryocr != null)
                {
                    library["ocr"] = ExpressionConverter.ConvertO(__workflow_libraryocr);
                    librarypropCount++;
                }

                if (librarypropCount > 0)
                {
                    callPayload.Body = library;
                }

                return new ApiConnectionAction<Library>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<DataType[]> PadatatypesList(Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null)
        {
            var __workflow_solutionid = solutionid == null ? null : WorkflowExpression.Compile(solutionid);
            WorkflowExpression.Validate(__workflow_solutionid, nameof(solutionid), required: false);
            var __workflow_solutionkey = solutionkey == null ? null : WorkflowExpression.Compile(solutionkey);
            WorkflowExpression.Validate(__workflow_solutionkey, nameof(solutionkey), required: false);
            return new DeferredBodyAction<DataType[]>(() =>
            {
                var apiCallPath = "/padatatypes/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                if (__workflow_solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(__workflow_solutionkey);
                return new ApiConnectionAction<DataType[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<string> PadocumentsLoadfile(Expression<Func<string>> documentkey, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null)
        {
            var __workflow_documentkey = documentkey == null ? null : WorkflowExpression.Compile(documentkey);
            WorkflowExpression.Validate(__workflow_documentkey, nameof(documentkey), required: true);
            var __workflow_solutionid = solutionid == null ? null : WorkflowExpression.Compile(solutionid);
            WorkflowExpression.Validate(__workflow_solutionid, nameof(solutionid), required: false);
            var __workflow_solutionkey = solutionkey == null ? null : WorkflowExpression.Compile(solutionkey);
            WorkflowExpression.Validate(__workflow_solutionkey, nameof(solutionkey), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/padocuments/loadfile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentkey"] = ExpressionConverter.Convert(__workflow_documentkey);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                if (__workflow_solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(__workflow_solutionkey);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<PropertyValue[]> PapropertyvaluesGet(Expression<Func<string>> documentkey, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null)
        {
            var __workflow_documentkey = documentkey == null ? null : WorkflowExpression.Compile(documentkey);
            WorkflowExpression.Validate(__workflow_documentkey, nameof(documentkey), required: true);
            var __workflow_solutionid = solutionid == null ? null : WorkflowExpression.Compile(solutionid);
            WorkflowExpression.Validate(__workflow_solutionid, nameof(solutionid), required: false);
            var __workflow_solutionkey = solutionkey == null ? null : WorkflowExpression.Compile(solutionkey);
            WorkflowExpression.Validate(__workflow_solutionkey, nameof(solutionkey), required: false);
            return new DeferredBodyAction<PropertyValue[]>(() =>
            {
                var apiCallPath = "/papropertyvalues/get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentkey"] = ExpressionConverter.Convert(__workflow_documentkey);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                if (__workflow_solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(__workflow_solutionkey);
                return new ApiConnectionAction<PropertyValue[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<PropertyValue[]> PapropertyvaluesUpdate(Expression<Func<string>> documentkey, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null, Expression<Func<PropertyValue[]>> propertyValueArray = null)
        {
            var __workflow_documentkey = documentkey == null ? null : WorkflowExpression.Compile(documentkey);
            WorkflowExpression.Validate(__workflow_documentkey, nameof(documentkey), required: true);
            var __workflow_solutionid = solutionid == null ? null : WorkflowExpression.Compile(solutionid);
            WorkflowExpression.Validate(__workflow_solutionid, nameof(solutionid), required: false);
            var __workflow_solutionkey = solutionkey == null ? null : WorkflowExpression.Compile(solutionkey);
            WorkflowExpression.Validate(__workflow_solutionkey, nameof(solutionkey), required: false);
            var __workflow_propertyValueArray = propertyValueArray == null ? null : WorkflowExpression.Compile(propertyValueArray);
            WorkflowExpression.Validate(__workflow_propertyValueArray, nameof(propertyValueArray), required: false);
            return new DeferredBodyAction<PropertyValue[]>(() =>
            {
                var apiCallPath = "/papropertyvalues/update";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentkey"] = ExpressionConverter.Convert(__workflow_documentkey);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                if (__workflow_solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(__workflow_solutionkey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_propertyValueArray);
                return new ApiConnectionAction<PropertyValue[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<DocumentProperty[]> PadocumentpropertiesList(Expression<Func<int>> documenttypeid, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null)
        {
            var __workflow_documenttypeid = documenttypeid == null ? null : WorkflowExpression.Compile(documenttypeid);
            WorkflowExpression.Validate(__workflow_documenttypeid, nameof(documenttypeid), required: true);
            var __workflow_solutionid = solutionid == null ? null : WorkflowExpression.Compile(solutionid);
            WorkflowExpression.Validate(__workflow_solutionid, nameof(solutionid), required: false);
            var __workflow_solutionkey = solutionkey == null ? null : WorkflowExpression.Compile(solutionkey);
            WorkflowExpression.Validate(__workflow_solutionkey, nameof(solutionkey), required: false);
            return new DeferredBodyAction<DocumentProperty[]>(() =>
            {
                var apiCallPath = "/padocumentproperties-list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documenttypeid"] = ExpressionConverter.Convert(__workflow_documenttypeid);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                if (__workflow_solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(__workflow_solutionkey);
                return new ApiConnectionAction<DocumentProperty[]>(callPayload);
            });
        }
    }

    public class _1docstopTriggers([ConnectionName] string connectionId)
    {
    }

    public class Library
    {
        [JsonProperty("libraryId")]
        public int LibraryId { get; set; }

        [JsonProperty("repositoryId")]
        public int RepositoryId { get; set; }

        [JsonProperty("repository")]
        public Repository Repository { get; set; }

        [JsonProperty("documentTypeId")]
        public int DocumentTypeId { get; set; }

        [JsonProperty("documentType")]
        public DocumentType DocumentType { get; set; }

        [JsonProperty("internalName")]
        public string InternalName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("storageContainer")]
        public string StorageContainer { get; set; }

        [JsonProperty("ocr")]
        public bool Ocr { get; set; }
    }

    public class Repository
    {
        [JsonProperty("repositoryId")]
        public int RepositoryId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("repositoryTypeId")]
        public int RepositoryTypeId { get; set; }

        [JsonProperty("repositoryType")]
        public RepositoryType RepositoryType { get; set; }

        [JsonProperty("repositoryURI")]
        public string RepositoryURI { get; set; }
    }

    public class RepositoryType
    {
        [JsonProperty("repositoryTypeId")]
        public int RepositoryTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class DocumentType
    {
        [JsonProperty("documentTypeId")]
        public int DocumentTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class Solution
    {
        [JsonProperty("solutionId")]
        public int SolutionId { get; set; }

        [JsonProperty("solutionKey")]
        public string SolutionKey { get; set; }

        [JsonProperty("departmentId")]
        public int DepartmentId { get; set; }

        [JsonProperty("department")]
        public Department Department { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("database")]
        public string Database { get; set; }

        [JsonProperty("storageAccount")]
        public string StorageAccount { get; set; }

        [JsonProperty("deleteStatus")]
        public int DeleteStatus { get; set; }

        [JsonProperty("searchService")]
        public string SearchService { get; set; }
    }

    public class Department
    {
        [JsonProperty("departmentId")]
        public int DepartmentId { get; set; }

        [JsonProperty("departmentKey")]
        public string DepartmentKey { get; set; }

        [JsonProperty("customerId")]
        public int CustomerId { get; set; }

        [JsonProperty("customer")]
        public Customer Customer { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Customer
    {
        [JsonProperty("customerId")]
        public int CustomerId { get; set; }

        [JsonProperty("customerKey")]
        public string CustomerKey { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Document
    {
        [JsonProperty("documentId")]
        public int DocumentId { get; set; }

        [JsonProperty("documentKey")]
        public string DocumentKey { get; set; }

        [JsonProperty("documentTypeId")]
        public int DocumentTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("author")]
        public int Author { get; set; }

        [JsonProperty("editor")]
        public int Editor { get; set; }

        [JsonProperty("storageKey")]
        public string StorageKey { get; set; }

        [JsonProperty("fileSizeBytes")]
        public int FileSizeBytes { get; set; }

        [JsonProperty("fileExtension")]
        public string FileExtension { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("propertyValues")]
        public PropertyValue[] PropertyValues { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class PropertyValue
    {
        [JsonProperty("documentId")]
        public int DocumentId { get; set; }

        [JsonProperty("documentPropertyId")]
        public int DocumentPropertyId { get; set; }

        [JsonProperty("documentProperty")]
        public DocumentProperty DocumentProperty { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("columnName")]
        public string ColumnName { get; set; }
    }

    public class DocumentProperty
    {
        [JsonProperty("documentPropertyId")]
        public int DocumentPropertyId { get; set; }

        [JsonProperty("documentTypeId")]
        public int DocumentTypeId { get; set; }

        [JsonProperty("documentType")]
        public DocumentType DocumentType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dataTypeId")]
        public int DataTypeId { get; set; }

        [JsonProperty("dataTypeName")]
        public string DataTypeName { get; set; }

        [JsonProperty("dataType")]
        public DataType DataType { get; set; }

        [JsonProperty("optionSetId")]
        public int OptionSetId { get; set; }

        [JsonProperty("optionSet")]
        public OptionSet OptionSet { get; set; }

        [JsonProperty("externalOptionSet")]
        public string ExternalOptionSet { get; set; }

        [JsonProperty("displayFormat")]
        public string DisplayFormat { get; set; }

        [JsonProperty("internalName")]
        public string InternalName { get; set; }
    }

    public class DataType
    {
        [JsonProperty("dataTypeId")]
        public int DataTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class OptionSet
    {
        [JsonProperty("optionSetId")]
        public int OptionSetId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("optionSetValues")]
        public OptionSetValue[] OptionSetValues { get; set; }
    }

    public class OptionSetValue
    {
        [JsonProperty("optionSetValueId")]
        public int OptionSetValueId { get; set; }

        [JsonProperty("optionSetId")]
        public int OptionSetId { get; set; }

        [JsonProperty("optionSet")]
        public OptionSet OptionSet { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors._1docstop;

    public partial class WorkflowManagedActions
    {
        public _1docstopActions _1docstop(string connectionId) => new _1docstopActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public _1docstopTriggers _1docstop(string connectionId) => new _1docstopTriggers(connectionId);
    }
}
