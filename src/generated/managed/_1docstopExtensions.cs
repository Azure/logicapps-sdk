//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors._1docstop
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class _1docstopActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        [WorkflowExpressionFactory(nameof(__BuildPalibrariesAdd))]
        public IBodyWorkflowAction<Library> PalibrariesAdd([WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<string> solutionkey = null, [WorkflowExpression] Func<int> librarylibraryId = null, [WorkflowExpression] Func<int> libraryrepositoryId = null, [WorkflowExpression] Func<int> libraryrepositoryrepositoryId = null, [WorkflowExpression] Func<string> libraryrepositoryname = null, [WorkflowExpression] Func<string> libraryrepositorydescription = null, [WorkflowExpression] Func<int> libraryrepositoryrepositoryTypeId = null, [WorkflowExpression] Func<int> libraryrepositoryrepositoryTyperepositoryTypeId = null, [WorkflowExpression] Func<string> libraryrepositoryrepositoryTypename = null, [WorkflowExpression] Func<string> libraryrepositoryrepositoryURI = null, [WorkflowExpression] Func<int> librarydocumentTypeId = null, [WorkflowExpression] Func<int> librarydocumentTypedocumentTypeId = null, [WorkflowExpression] Func<string> librarydocumentTypename = null, [WorkflowExpression] Func<string> librarydocumentTypedescription = null, [WorkflowExpression] Func<string> libraryname = null, [WorkflowExpression] Func<string> librarydescription = null, [WorkflowExpression] Func<bool> libraryocr = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Library> __BuildPalibrariesAdd(WorkflowExpression<int> solutionid = null, WorkflowExpression<string> solutionkey = null, WorkflowExpression<int> librarylibraryId = null, WorkflowExpression<int> libraryrepositoryId = null, WorkflowExpression<int> libraryrepositoryrepositoryId = null, WorkflowExpression<string> libraryrepositoryname = null, WorkflowExpression<string> libraryrepositorydescription = null, WorkflowExpression<int> libraryrepositoryrepositoryTypeId = null, WorkflowExpression<int> libraryrepositoryrepositoryTyperepositoryTypeId = null, WorkflowExpression<string> libraryrepositoryrepositoryTypename = null, WorkflowExpression<string> libraryrepositoryrepositoryURI = null, WorkflowExpression<int> librarydocumentTypeId = null, WorkflowExpression<int> librarydocumentTypedocumentTypeId = null, WorkflowExpression<string> librarydocumentTypename = null, WorkflowExpression<string> librarydocumentTypedescription = null, WorkflowExpression<string> libraryname = null, WorkflowExpression<string> librarydescription = null, WorkflowExpression<bool> libraryocr = null)
        {
            WorkflowExpression.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowExpression.Validate(solutionkey, nameof(solutionkey), required: false);
            WorkflowExpression.Validate(librarylibraryId, nameof(librarylibraryId), required: false);
            WorkflowExpression.Validate(libraryrepositoryId, nameof(libraryrepositoryId), required: false);
            WorkflowExpression.Validate(libraryrepositoryrepositoryId, nameof(libraryrepositoryrepositoryId), required: false);
            WorkflowExpression.Validate(libraryrepositoryname, nameof(libraryrepositoryname), required: false);
            WorkflowExpression.Validate(libraryrepositorydescription, nameof(libraryrepositorydescription), required: false);
            WorkflowExpression.Validate(libraryrepositoryrepositoryTypeId, nameof(libraryrepositoryrepositoryTypeId), required: false);
            WorkflowExpression.Validate(libraryrepositoryrepositoryTyperepositoryTypeId, nameof(libraryrepositoryrepositoryTyperepositoryTypeId), required: false);
            WorkflowExpression.Validate(libraryrepositoryrepositoryTypename, nameof(libraryrepositoryrepositoryTypename), required: false);
            WorkflowExpression.Validate(libraryrepositoryrepositoryURI, nameof(libraryrepositoryrepositoryURI), required: false);
            WorkflowExpression.Validate(librarydocumentTypeId, nameof(librarydocumentTypeId), required: false);
            WorkflowExpression.Validate(librarydocumentTypedocumentTypeId, nameof(librarydocumentTypedocumentTypeId), required: false);
            WorkflowExpression.Validate(librarydocumentTypename, nameof(librarydocumentTypename), required: false);
            WorkflowExpression.Validate(librarydocumentTypedescription, nameof(librarydocumentTypedescription), required: false);
            WorkflowExpression.Validate(libraryname, nameof(libraryname), required: false);
            WorkflowExpression.Validate(librarydescription, nameof(librarydescription), required: false);
            WorkflowExpression.Validate(libraryocr, nameof(libraryocr), required: false);
            return new DeferredBodyAction<Library>(() =>
            {
                var apiCallPath = "/palibraries/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(solutionid);
                if (solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(solutionkey);
                var library = new JObject();
                var librarypropCount = 0;
                if (librarylibraryId != null)
                {
                    library["libraryId"] = ExpressionConverter.ConvertO(librarylibraryId);
                    librarypropCount++;
                }

                if (libraryrepositoryId != null)
                {
                    library["repositoryId"] = ExpressionConverter.ConvertO(libraryrepositoryId);
                    librarypropCount++;
                }

                if (librarydocumentTypeId != null)
                {
                    library["documentTypeId"] = ExpressionConverter.ConvertO(librarydocumentTypeId);
                    librarypropCount++;
                }

                var documentTypeObject = new JObject();
                var documentTypeObjectpropCount = 0;
                if (librarydocumentTypedocumentTypeId != null)
                {
                    documentTypeObject["documentTypeId"] = ExpressionConverter.ConvertO(librarydocumentTypedocumentTypeId);
                    documentTypeObjectpropCount++;
                }

                if (librarydocumentTypename != null)
                {
                    documentTypeObject["name"] = ExpressionConverter.ConvertO(librarydocumentTypename);
                    documentTypeObjectpropCount++;
                }

                if (librarydocumentTypedescription != null)
                {
                    documentTypeObject["description"] = ExpressionConverter.ConvertO(librarydocumentTypedescription);
                    documentTypeObjectpropCount++;
                }

                if (documentTypeObjectpropCount > 0)
                {
                    library["documentType"] = documentTypeObject;
                    librarypropCount++;
                }

                if (libraryname != null)
                {
                    library["name"] = ExpressionConverter.ConvertO(libraryname);
                    librarypropCount++;
                }

                if (librarydescription != null)
                {
                    library["description"] = ExpressionConverter.ConvertO(librarydescription);
                    librarypropCount++;
                }

                if (libraryocr != null)
                {
                    library["ocr"] = ExpressionConverter.ConvertO(libraryocr);
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
        [WorkflowExpressionFactory(nameof(__BuildPasolutionsGet))]
        public IBodyWorkflowAction<Solution> PasolutionsGet([WorkflowExpression] Func<string> solutionkey, [WorkflowExpression] Func<int> solutionid = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Solution> __BuildPasolutionsGet(WorkflowExpression<string> solutionkey, WorkflowExpression<int> solutionid = null)
        {
            WorkflowExpression.Validate(solutionkey, nameof(solutionkey), required: true);
            WorkflowExpression.Validate(solutionid, nameof(solutionid), required: false);
            return new DeferredBodyAction<Solution>(() =>
            {
                var apiCallPath = "/pasolutions/get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(solutionkey);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(solutionid);
                return new ApiConnectionAction<Solution>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        [WorkflowExpressionFactory(nameof(__BuildPasolutionsList))]
        public IBodyWorkflowAction<Solution[]> PasolutionsList([WorkflowExpression] Func<int> solutionid = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Solution[]> __BuildPasolutionsList(WorkflowExpression<int> solutionid = null)
        {
            WorkflowExpression.Validate(solutionid, nameof(solutionid), required: false);
            return new DeferredBodyAction<Solution[]>(() =>
            {
                var apiCallPath = "/pasolutions/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(solutionid);
                return new ApiConnectionAction<Solution[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        [WorkflowExpressionFactory(nameof(__BuildPasolutionsDepartmentList))]
        public IBodyWorkflowAction<Solution[]> PasolutionsDepartmentList([WorkflowExpression] Func<string> departmentkey, [WorkflowExpression] Func<int> solutionid = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Solution[]> __BuildPasolutionsDepartmentList(WorkflowExpression<string> departmentkey, WorkflowExpression<int> solutionid = null)
        {
            WorkflowExpression.Validate(departmentkey, nameof(departmentkey), required: true);
            WorkflowExpression.Validate(solutionid, nameof(solutionid), required: false);
            return new DeferredBodyAction<Solution[]>(() =>
            {
                var apiCallPath = "/pasolutions/department/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["departmentkey"] = ExpressionConverter.Convert(departmentkey);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(solutionid);
                return new ApiConnectionAction<Solution[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        [WorkflowExpressionFactory(nameof(__BuildPasolutionsAdd))]
        public IBodyWorkflowAction<Solution> PasolutionsAdd([WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<int> solutionsolutionId = null, [WorkflowExpression] Func<string> solutionsolutionKey = null, [WorkflowExpression] Func<int> solutiondepartmentdepartmentId = null, [WorkflowExpression] Func<string> solutiondepartmentdepartmentKey = null, [WorkflowExpression] Func<int> solutiondepartmentcustomerId = null, [WorkflowExpression] Func<int> solutiondepartmentcustomercustomerId = null, [WorkflowExpression] Func<string> solutiondepartmentcustomercustomerKey = null, [WorkflowExpression] Func<string> solutiondepartmentcustomername = null, [WorkflowExpression] Func<string> solutiondepartmentname = null, [WorkflowExpression] Func<string> solutionname = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Solution> __BuildPasolutionsAdd(WorkflowExpression<int> solutionid = null, WorkflowExpression<int> solutionsolutionId = null, WorkflowExpression<string> solutionsolutionKey = null, WorkflowExpression<int> solutiondepartmentdepartmentId = null, WorkflowExpression<string> solutiondepartmentdepartmentKey = null, WorkflowExpression<int> solutiondepartmentcustomerId = null, WorkflowExpression<int> solutiondepartmentcustomercustomerId = null, WorkflowExpression<string> solutiondepartmentcustomercustomerKey = null, WorkflowExpression<string> solutiondepartmentcustomername = null, WorkflowExpression<string> solutiondepartmentname = null, WorkflowExpression<string> solutionname = null)
        {
            WorkflowExpression.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowExpression.Validate(solutionsolutionId, nameof(solutionsolutionId), required: false);
            WorkflowExpression.Validate(solutionsolutionKey, nameof(solutionsolutionKey), required: false);
            WorkflowExpression.Validate(solutiondepartmentdepartmentId, nameof(solutiondepartmentdepartmentId), required: false);
            WorkflowExpression.Validate(solutiondepartmentdepartmentKey, nameof(solutiondepartmentdepartmentKey), required: false);
            WorkflowExpression.Validate(solutiondepartmentcustomerId, nameof(solutiondepartmentcustomerId), required: false);
            WorkflowExpression.Validate(solutiondepartmentcustomercustomerId, nameof(solutiondepartmentcustomercustomerId), required: false);
            WorkflowExpression.Validate(solutiondepartmentcustomercustomerKey, nameof(solutiondepartmentcustomercustomerKey), required: false);
            WorkflowExpression.Validate(solutiondepartmentcustomername, nameof(solutiondepartmentcustomername), required: false);
            WorkflowExpression.Validate(solutiondepartmentname, nameof(solutiondepartmentname), required: false);
            WorkflowExpression.Validate(solutionname, nameof(solutionname), required: false);
            return new DeferredBodyAction<Solution>(() =>
            {
                var apiCallPath = "/pasolutions/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(solutionid);
                var solution = new JObject();
                var solutionpropCount = 0;
                if (solutionsolutionId != null)
                {
                    solution["solutionId"] = ExpressionConverter.ConvertO(solutionsolutionId);
                    solutionpropCount++;
                }

                if (solutionsolutionKey != null)
                {
                    solution["solutionKey"] = ExpressionConverter.ConvertO(solutionsolutionKey);
                    solutionpropCount++;
                }

                if (solutionname != null)
                {
                    solution["name"] = ExpressionConverter.ConvertO(solutionname);
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
        [WorkflowExpressionFactory(nameof(__BuildPasolutionsUpdate))]
        public IBodyWorkflowAction<Solution> PasolutionsUpdate([WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<int> functionsolutionid = null, [WorkflowExpression] Func<int> solutionsolutionId = null, [WorkflowExpression] Func<string> solutionsolutionKey = null, [WorkflowExpression] Func<int> solutiondepartmentdepartmentId = null, [WorkflowExpression] Func<string> solutiondepartmentdepartmentKey = null, [WorkflowExpression] Func<int> solutiondepartmentcustomerId = null, [WorkflowExpression] Func<int> solutiondepartmentcustomercustomerId = null, [WorkflowExpression] Func<string> solutiondepartmentcustomercustomerKey = null, [WorkflowExpression] Func<string> solutiondepartmentcustomername = null, [WorkflowExpression] Func<string> solutiondepartmentname = null, [WorkflowExpression] Func<string> solutionname = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Solution> __BuildPasolutionsUpdate(WorkflowExpression<int> solutionid = null, WorkflowExpression<int> functionsolutionid = null, WorkflowExpression<int> solutionsolutionId = null, WorkflowExpression<string> solutionsolutionKey = null, WorkflowExpression<int> solutiondepartmentdepartmentId = null, WorkflowExpression<string> solutiondepartmentdepartmentKey = null, WorkflowExpression<int> solutiondepartmentcustomerId = null, WorkflowExpression<int> solutiondepartmentcustomercustomerId = null, WorkflowExpression<string> solutiondepartmentcustomercustomerKey = null, WorkflowExpression<string> solutiondepartmentcustomername = null, WorkflowExpression<string> solutiondepartmentname = null, WorkflowExpression<string> solutionname = null)
        {
            WorkflowExpression.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowExpression.Validate(functionsolutionid, nameof(functionsolutionid), required: false);
            WorkflowExpression.Validate(solutionsolutionId, nameof(solutionsolutionId), required: false);
            WorkflowExpression.Validate(solutionsolutionKey, nameof(solutionsolutionKey), required: false);
            WorkflowExpression.Validate(solutiondepartmentdepartmentId, nameof(solutiondepartmentdepartmentId), required: false);
            WorkflowExpression.Validate(solutiondepartmentdepartmentKey, nameof(solutiondepartmentdepartmentKey), required: false);
            WorkflowExpression.Validate(solutiondepartmentcustomerId, nameof(solutiondepartmentcustomerId), required: false);
            WorkflowExpression.Validate(solutiondepartmentcustomercustomerId, nameof(solutiondepartmentcustomercustomerId), required: false);
            WorkflowExpression.Validate(solutiondepartmentcustomercustomerKey, nameof(solutiondepartmentcustomercustomerKey), required: false);
            WorkflowExpression.Validate(solutiondepartmentcustomername, nameof(solutiondepartmentcustomername), required: false);
            WorkflowExpression.Validate(solutiondepartmentname, nameof(solutiondepartmentname), required: false);
            WorkflowExpression.Validate(solutionname, nameof(solutionname), required: false);
            return new DeferredBodyAction<Solution>(() =>
            {
                var apiCallPath = "/pasolutions/update";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(solutionid);
                if (functionsolutionid != null)
                    callPayload.Queries["functionsolutionid"] = ExpressionConverter.Convert(functionsolutionid);
                var solution = new JObject();
                var solutionpropCount = 0;
                if (solutionsolutionId != null)
                {
                    solution["solutionId"] = ExpressionConverter.ConvertO(solutionsolutionId);
                    solutionpropCount++;
                }

                if (solutionsolutionKey != null)
                {
                    solution["solutionKey"] = ExpressionConverter.ConvertO(solutionsolutionKey);
                    solutionpropCount++;
                }

                if (solutionname != null)
                {
                    solution["name"] = ExpressionConverter.ConvertO(solutionname);
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
        [WorkflowExpressionFactory(nameof(__BuildPadocumentsAdd))]
        public IBodyWorkflowAction<Document> PadocumentsAdd([WorkflowExpression] Func<int> libraryid, [WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<string> solutionkey = null, [WorkflowExpression] Func<string> documentdocumentKey = null, [WorkflowExpression] Func<string> documentname = null, [WorkflowExpression] Func<int> documentfileSizeBytes = null, [WorkflowExpression] Func<int> documentstatus = null, [WorkflowExpression] Func<PropertyValue[]> documentpropertyValues = null, [WorkflowExpression] Func<string> documenturl = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Document> __BuildPadocumentsAdd(WorkflowExpression<int> libraryid, WorkflowExpression<int> solutionid = null, WorkflowExpression<string> solutionkey = null, WorkflowExpression<string> documentdocumentKey = null, WorkflowExpression<string> documentname = null, WorkflowExpression<int> documentfileSizeBytes = null, WorkflowExpression<int> documentstatus = null, WorkflowExpression<PropertyValue[]> documentpropertyValues = null, WorkflowExpression<string> documenturl = null)
        {
            WorkflowExpression.Validate(libraryid, nameof(libraryid), required: true);
            WorkflowExpression.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowExpression.Validate(solutionkey, nameof(solutionkey), required: false);
            WorkflowExpression.Validate(documentdocumentKey, nameof(documentdocumentKey), required: false);
            WorkflowExpression.Validate(documentname, nameof(documentname), required: false);
            WorkflowExpression.Validate(documentfileSizeBytes, nameof(documentfileSizeBytes), required: false);
            WorkflowExpression.Validate(documentstatus, nameof(documentstatus), required: false);
            WorkflowExpression.Validate(documentpropertyValues, nameof(documentpropertyValues), required: false);
            WorkflowExpression.Validate(documenturl, nameof(documenturl), required: false);
            return new DeferredBodyAction<Document>(() =>
            {
                var apiCallPath = "/padocuments/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryid"] = ExpressionConverter.Convert(libraryid);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(solutionid);
                if (solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(solutionkey);
                var document = new JObject();
                var documentpropCount = 0;
                if (documentdocumentKey != null)
                {
                    document["documentKey"] = ExpressionConverter.ConvertO(documentdocumentKey);
                    documentpropCount++;
                }

                if (documentname != null)
                {
                    document["name"] = ExpressionConverter.ConvertO(documentname);
                    documentpropCount++;
                }

                if (documentfileSizeBytes != null)
                {
                    document["fileSizeBytes"] = ExpressionConverter.ConvertO(documentfileSizeBytes);
                    documentpropCount++;
                }

                if (documentstatus != null)
                {
                    document["status"] = ExpressionConverter.ConvertO(documentstatus);
                    documentpropCount++;
                }

                if (documentpropertyValues != null)
                {
                    document["propertyValues"] = ExpressionConverter.ConvertO(documentpropertyValues);
                    documentpropCount++;
                }

                if (documenturl != null)
                {
                    document["url"] = ExpressionConverter.ConvertO(documenturl);
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
        [WorkflowExpressionFactory(nameof(__BuildPadocumenttypesGet))]
        public IBodyWorkflowAction<DocumentType> PadocumenttypesGet([WorkflowExpression] Func<int> documenttypeid, [WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<string> solutionkey = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentType> __BuildPadocumenttypesGet(WorkflowExpression<int> documenttypeid, WorkflowExpression<int> solutionid = null, WorkflowExpression<string> solutionkey = null)
        {
            WorkflowExpression.Validate(documenttypeid, nameof(documenttypeid), required: true);
            WorkflowExpression.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowExpression.Validate(solutionkey, nameof(solutionkey), required: false);
            return new DeferredBodyAction<DocumentType>(() =>
            {
                var apiCallPath = "/padocumenttypes/get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documenttypeid"] = ExpressionConverter.Convert(documenttypeid);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(solutionid);
                if (solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(solutionkey);
                return new ApiConnectionAction<DocumentType>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        [WorkflowExpressionFactory(nameof(__BuildPadocumenttypesList))]
        public IBodyWorkflowAction<DocumentType[]> PadocumenttypesList([WorkflowExpression] Func<string> solutionkey, [WorkflowExpression] Func<int> solutionid = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentType[]> __BuildPadocumenttypesList(WorkflowExpression<string> solutionkey, WorkflowExpression<int> solutionid = null)
        {
            WorkflowExpression.Validate(solutionkey, nameof(solutionkey), required: true);
            WorkflowExpression.Validate(solutionid, nameof(solutionid), required: false);
            return new DeferredBodyAction<DocumentType[]>(() =>
            {
                var apiCallPath = "/padocumenttypes/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(solutionkey);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(solutionid);
                return new ApiConnectionAction<DocumentType[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        [WorkflowExpressionFactory(nameof(__BuildPadocumenttypesAdd))]
        public IBodyWorkflowAction<Library> PadocumenttypesAdd([WorkflowExpression] Func<string> solutionkey, [WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<int> librarylibraryId = null, [WorkflowExpression] Func<int> libraryrepositoryId = null, [WorkflowExpression] Func<int> libraryrepositoryrepositoryId = null, [WorkflowExpression] Func<string> libraryrepositoryname = null, [WorkflowExpression] Func<string> libraryrepositorydescription = null, [WorkflowExpression] Func<int> libraryrepositoryrepositoryTypeId = null, [WorkflowExpression] Func<int> libraryrepositoryrepositoryTyperepositoryTypeId = null, [WorkflowExpression] Func<string> libraryrepositoryrepositoryTypename = null, [WorkflowExpression] Func<string> libraryrepositoryrepositoryURI = null, [WorkflowExpression] Func<int> librarydocumentTypeId = null, [WorkflowExpression] Func<int> librarydocumentTypedocumentTypeId = null, [WorkflowExpression] Func<string> librarydocumentTypename = null, [WorkflowExpression] Func<string> librarydocumentTypedescription = null, [WorkflowExpression] Func<string> libraryname = null, [WorkflowExpression] Func<string> librarydescription = null, [WorkflowExpression] Func<bool> libraryocr = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Library> __BuildPadocumenttypesAdd(WorkflowExpression<string> solutionkey, WorkflowExpression<int> solutionid = null, WorkflowExpression<int> librarylibraryId = null, WorkflowExpression<int> libraryrepositoryId = null, WorkflowExpression<int> libraryrepositoryrepositoryId = null, WorkflowExpression<string> libraryrepositoryname = null, WorkflowExpression<string> libraryrepositorydescription = null, WorkflowExpression<int> libraryrepositoryrepositoryTypeId = null, WorkflowExpression<int> libraryrepositoryrepositoryTyperepositoryTypeId = null, WorkflowExpression<string> libraryrepositoryrepositoryTypename = null, WorkflowExpression<string> libraryrepositoryrepositoryURI = null, WorkflowExpression<int> librarydocumentTypeId = null, WorkflowExpression<int> librarydocumentTypedocumentTypeId = null, WorkflowExpression<string> librarydocumentTypename = null, WorkflowExpression<string> librarydocumentTypedescription = null, WorkflowExpression<string> libraryname = null, WorkflowExpression<string> librarydescription = null, WorkflowExpression<bool> libraryocr = null)
        {
            WorkflowExpression.Validate(solutionkey, nameof(solutionkey), required: true);
            WorkflowExpression.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowExpression.Validate(librarylibraryId, nameof(librarylibraryId), required: false);
            WorkflowExpression.Validate(libraryrepositoryId, nameof(libraryrepositoryId), required: false);
            WorkflowExpression.Validate(libraryrepositoryrepositoryId, nameof(libraryrepositoryrepositoryId), required: false);
            WorkflowExpression.Validate(libraryrepositoryname, nameof(libraryrepositoryname), required: false);
            WorkflowExpression.Validate(libraryrepositorydescription, nameof(libraryrepositorydescription), required: false);
            WorkflowExpression.Validate(libraryrepositoryrepositoryTypeId, nameof(libraryrepositoryrepositoryTypeId), required: false);
            WorkflowExpression.Validate(libraryrepositoryrepositoryTyperepositoryTypeId, nameof(libraryrepositoryrepositoryTyperepositoryTypeId), required: false);
            WorkflowExpression.Validate(libraryrepositoryrepositoryTypename, nameof(libraryrepositoryrepositoryTypename), required: false);
            WorkflowExpression.Validate(libraryrepositoryrepositoryURI, nameof(libraryrepositoryrepositoryURI), required: false);
            WorkflowExpression.Validate(librarydocumentTypeId, nameof(librarydocumentTypeId), required: false);
            WorkflowExpression.Validate(librarydocumentTypedocumentTypeId, nameof(librarydocumentTypedocumentTypeId), required: false);
            WorkflowExpression.Validate(librarydocumentTypename, nameof(librarydocumentTypename), required: false);
            WorkflowExpression.Validate(librarydocumentTypedescription, nameof(librarydocumentTypedescription), required: false);
            WorkflowExpression.Validate(libraryname, nameof(libraryname), required: false);
            WorkflowExpression.Validate(librarydescription, nameof(librarydescription), required: false);
            WorkflowExpression.Validate(libraryocr, nameof(libraryocr), required: false);
            return new DeferredBodyAction<Library>(() =>
            {
                var apiCallPath = "/padocumenttypes/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(solutionkey);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(solutionid);
                var library = new JObject();
                var librarypropCount = 0;
                if (librarylibraryId != null)
                {
                    library["libraryId"] = ExpressionConverter.ConvertO(librarylibraryId);
                    librarypropCount++;
                }

                if (libraryrepositoryId != null)
                {
                    library["repositoryId"] = ExpressionConverter.ConvertO(libraryrepositoryId);
                    librarypropCount++;
                }

                if (librarydocumentTypeId != null)
                {
                    library["documentTypeId"] = ExpressionConverter.ConvertO(librarydocumentTypeId);
                    librarypropCount++;
                }

                var documentTypeObject = new JObject();
                var documentTypeObjectpropCount = 0;
                if (librarydocumentTypedocumentTypeId != null)
                {
                    documentTypeObject["documentTypeId"] = ExpressionConverter.ConvertO(librarydocumentTypedocumentTypeId);
                    documentTypeObjectpropCount++;
                }

                if (librarydocumentTypename != null)
                {
                    documentTypeObject["name"] = ExpressionConverter.ConvertO(librarydocumentTypename);
                    documentTypeObjectpropCount++;
                }

                if (librarydocumentTypedescription != null)
                {
                    documentTypeObject["description"] = ExpressionConverter.ConvertO(librarydocumentTypedescription);
                    documentTypeObjectpropCount++;
                }

                if (documentTypeObjectpropCount > 0)
                {
                    library["documentType"] = documentTypeObject;
                    librarypropCount++;
                }

                if (libraryname != null)
                {
                    library["name"] = ExpressionConverter.ConvertO(libraryname);
                    librarypropCount++;
                }

                if (librarydescription != null)
                {
                    library["description"] = ExpressionConverter.ConvertO(librarydescription);
                    librarypropCount++;
                }

                if (libraryocr != null)
                {
                    library["ocr"] = ExpressionConverter.ConvertO(libraryocr);
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
        [WorkflowExpressionFactory(nameof(__BuildPadocumenttypesUpdate))]
        public IBodyWorkflowAction<DocumentType> PadocumenttypesUpdate([WorkflowExpression] Func<int> documenttypeid, [WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<string> solutionkey = null, [WorkflowExpression] Func<int> documentTypedocumentTypeId = null, [WorkflowExpression] Func<string> documentTypename = null, [WorkflowExpression] Func<string> documentTypedescription = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentType> __BuildPadocumenttypesUpdate(WorkflowExpression<int> documenttypeid, WorkflowExpression<int> solutionid = null, WorkflowExpression<string> solutionkey = null, WorkflowExpression<int> documentTypedocumentTypeId = null, WorkflowExpression<string> documentTypename = null, WorkflowExpression<string> documentTypedescription = null)
        {
            WorkflowExpression.Validate(documenttypeid, nameof(documenttypeid), required: true);
            WorkflowExpression.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowExpression.Validate(solutionkey, nameof(solutionkey), required: false);
            WorkflowExpression.Validate(documentTypedocumentTypeId, nameof(documentTypedocumentTypeId), required: false);
            WorkflowExpression.Validate(documentTypename, nameof(documentTypename), required: false);
            WorkflowExpression.Validate(documentTypedescription, nameof(documentTypedescription), required: false);
            return new DeferredBodyAction<DocumentType>(() =>
            {
                var apiCallPath = "/padocumenttypes/update";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documenttypeid"] = ExpressionConverter.Convert(documenttypeid);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(solutionid);
                if (solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(solutionkey);
                var documentType = new JObject();
                var documentTypepropCount = 0;
                if (documentTypedocumentTypeId != null)
                {
                    documentType["documentTypeId"] = ExpressionConverter.ConvertO(documentTypedocumentTypeId);
                    documentTypepropCount++;
                }

                if (documentTypename != null)
                {
                    documentType["name"] = ExpressionConverter.ConvertO(documentTypename);
                    documentTypepropCount++;
                }

                if (documentTypedescription != null)
                {
                    documentType["description"] = ExpressionConverter.ConvertO(documentTypedescription);
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
        [WorkflowExpressionFactory(nameof(__BuildPalibrariesGet))]
        public IBodyWorkflowAction<Library> PalibrariesGet([WorkflowExpression] Func<int> libraryid, [WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<string> solutionkey = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Library> __BuildPalibrariesGet(WorkflowExpression<int> libraryid, WorkflowExpression<int> solutionid = null, WorkflowExpression<string> solutionkey = null)
        {
            WorkflowExpression.Validate(libraryid, nameof(libraryid), required: true);
            WorkflowExpression.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowExpression.Validate(solutionkey, nameof(solutionkey), required: false);
            return new DeferredBodyAction<Library>(() =>
            {
                var apiCallPath = "/palibraries/get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryid"] = ExpressionConverter.Convert(libraryid);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(solutionid);
                if (solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(solutionkey);
                return new ApiConnectionAction<Library>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        [WorkflowExpressionFactory(nameof(__BuildPalibrariesList))]
        public IBodyWorkflowAction<Library[]> PalibrariesList([WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<string> solutionkey = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Library[]> __BuildPalibrariesList(WorkflowExpression<int> solutionid = null, WorkflowExpression<string> solutionkey = null)
        {
            WorkflowExpression.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowExpression.Validate(solutionkey, nameof(solutionkey), required: false);
            return new DeferredBodyAction<Library[]>(() =>
            {
                var apiCallPath = "/palibraries/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(solutionid);
                if (solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(solutionkey);
                return new ApiConnectionAction<Library[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        [WorkflowExpressionFactory(nameof(__BuildPalibrariesDocumenttypeList))]
        public IBodyWorkflowAction<Library[]> PalibrariesDocumenttypeList([WorkflowExpression] Func<int> documenttypeid, [WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<string> solutionkey = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Library[]> __BuildPalibrariesDocumenttypeList(WorkflowExpression<int> documenttypeid, WorkflowExpression<int> solutionid = null, WorkflowExpression<string> solutionkey = null)
        {
            WorkflowExpression.Validate(documenttypeid, nameof(documenttypeid), required: true);
            WorkflowExpression.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowExpression.Validate(solutionkey, nameof(solutionkey), required: false);
            return new DeferredBodyAction<Library[]>(() =>
            {
                var apiCallPath = "/palibraries/documenttype/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documenttypeid"] = ExpressionConverter.Convert(documenttypeid);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(solutionid);
                if (solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(solutionkey);
                return new ApiConnectionAction<Library[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        [WorkflowExpressionFactory(nameof(__BuildPalibrariesUpdate))]
        public IBodyWorkflowAction<Library> PalibrariesUpdate([WorkflowExpression] Func<int> libraryid, [WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<string> solutionkey = null, [WorkflowExpression] Func<int> librarylibraryId = null, [WorkflowExpression] Func<int> libraryrepositoryId = null, [WorkflowExpression] Func<int> libraryrepositoryrepositoryId = null, [WorkflowExpression] Func<string> libraryrepositoryname = null, [WorkflowExpression] Func<string> libraryrepositorydescription = null, [WorkflowExpression] Func<int> libraryrepositoryrepositoryTypeId = null, [WorkflowExpression] Func<int> libraryrepositoryrepositoryTyperepositoryTypeId = null, [WorkflowExpression] Func<string> libraryrepositoryrepositoryTypename = null, [WorkflowExpression] Func<string> libraryrepositoryrepositoryURI = null, [WorkflowExpression] Func<int> librarydocumentTypeId = null, [WorkflowExpression] Func<int> librarydocumentTypedocumentTypeId = null, [WorkflowExpression] Func<string> librarydocumentTypename = null, [WorkflowExpression] Func<string> librarydocumentTypedescription = null, [WorkflowExpression] Func<string> libraryname = null, [WorkflowExpression] Func<string> librarydescription = null, [WorkflowExpression] Func<bool> libraryocr = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Library> __BuildPalibrariesUpdate(WorkflowExpression<int> libraryid, WorkflowExpression<int> solutionid = null, WorkflowExpression<string> solutionkey = null, WorkflowExpression<int> librarylibraryId = null, WorkflowExpression<int> libraryrepositoryId = null, WorkflowExpression<int> libraryrepositoryrepositoryId = null, WorkflowExpression<string> libraryrepositoryname = null, WorkflowExpression<string> libraryrepositorydescription = null, WorkflowExpression<int> libraryrepositoryrepositoryTypeId = null, WorkflowExpression<int> libraryrepositoryrepositoryTyperepositoryTypeId = null, WorkflowExpression<string> libraryrepositoryrepositoryTypename = null, WorkflowExpression<string> libraryrepositoryrepositoryURI = null, WorkflowExpression<int> librarydocumentTypeId = null, WorkflowExpression<int> librarydocumentTypedocumentTypeId = null, WorkflowExpression<string> librarydocumentTypename = null, WorkflowExpression<string> librarydocumentTypedescription = null, WorkflowExpression<string> libraryname = null, WorkflowExpression<string> librarydescription = null, WorkflowExpression<bool> libraryocr = null)
        {
            WorkflowExpression.Validate(libraryid, nameof(libraryid), required: true);
            WorkflowExpression.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowExpression.Validate(solutionkey, nameof(solutionkey), required: false);
            WorkflowExpression.Validate(librarylibraryId, nameof(librarylibraryId), required: false);
            WorkflowExpression.Validate(libraryrepositoryId, nameof(libraryrepositoryId), required: false);
            WorkflowExpression.Validate(libraryrepositoryrepositoryId, nameof(libraryrepositoryrepositoryId), required: false);
            WorkflowExpression.Validate(libraryrepositoryname, nameof(libraryrepositoryname), required: false);
            WorkflowExpression.Validate(libraryrepositorydescription, nameof(libraryrepositorydescription), required: false);
            WorkflowExpression.Validate(libraryrepositoryrepositoryTypeId, nameof(libraryrepositoryrepositoryTypeId), required: false);
            WorkflowExpression.Validate(libraryrepositoryrepositoryTyperepositoryTypeId, nameof(libraryrepositoryrepositoryTyperepositoryTypeId), required: false);
            WorkflowExpression.Validate(libraryrepositoryrepositoryTypename, nameof(libraryrepositoryrepositoryTypename), required: false);
            WorkflowExpression.Validate(libraryrepositoryrepositoryURI, nameof(libraryrepositoryrepositoryURI), required: false);
            WorkflowExpression.Validate(librarydocumentTypeId, nameof(librarydocumentTypeId), required: false);
            WorkflowExpression.Validate(librarydocumentTypedocumentTypeId, nameof(librarydocumentTypedocumentTypeId), required: false);
            WorkflowExpression.Validate(librarydocumentTypename, nameof(librarydocumentTypename), required: false);
            WorkflowExpression.Validate(librarydocumentTypedescription, nameof(librarydocumentTypedescription), required: false);
            WorkflowExpression.Validate(libraryname, nameof(libraryname), required: false);
            WorkflowExpression.Validate(librarydescription, nameof(librarydescription), required: false);
            WorkflowExpression.Validate(libraryocr, nameof(libraryocr), required: false);
            return new DeferredBodyAction<Library>(() =>
            {
                var apiCallPath = "/palibraries/update";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryid"] = ExpressionConverter.Convert(libraryid);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(solutionid);
                if (solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(solutionkey);
                var library = new JObject();
                var librarypropCount = 0;
                if (librarylibraryId != null)
                {
                    library["libraryId"] = ExpressionConverter.ConvertO(librarylibraryId);
                    librarypropCount++;
                }

                if (libraryrepositoryId != null)
                {
                    library["repositoryId"] = ExpressionConverter.ConvertO(libraryrepositoryId);
                    librarypropCount++;
                }

                if (librarydocumentTypeId != null)
                {
                    library["documentTypeId"] = ExpressionConverter.ConvertO(librarydocumentTypeId);
                    librarypropCount++;
                }

                var documentTypeObject = new JObject();
                var documentTypeObjectpropCount = 0;
                if (librarydocumentTypedocumentTypeId != null)
                {
                    documentTypeObject["documentTypeId"] = ExpressionConverter.ConvertO(librarydocumentTypedocumentTypeId);
                    documentTypeObjectpropCount++;
                }

                if (librarydocumentTypename != null)
                {
                    documentTypeObject["name"] = ExpressionConverter.ConvertO(librarydocumentTypename);
                    documentTypeObjectpropCount++;
                }

                if (librarydocumentTypedescription != null)
                {
                    documentTypeObject["description"] = ExpressionConverter.ConvertO(librarydocumentTypedescription);
                    documentTypeObjectpropCount++;
                }

                if (documentTypeObjectpropCount > 0)
                {
                    library["documentType"] = documentTypeObject;
                    librarypropCount++;
                }

                if (libraryname != null)
                {
                    library["name"] = ExpressionConverter.ConvertO(libraryname);
                    librarypropCount++;
                }

                if (librarydescription != null)
                {
                    library["description"] = ExpressionConverter.ConvertO(librarydescription);
                    librarypropCount++;
                }

                if (libraryocr != null)
                {
                    library["ocr"] = ExpressionConverter.ConvertO(libraryocr);
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
        [WorkflowExpressionFactory(nameof(__BuildPadatatypesList))]
        public IBodyWorkflowAction<DataType[]> PadatatypesList([WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<string> solutionkey = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DataType[]> __BuildPadatatypesList(WorkflowExpression<int> solutionid = null, WorkflowExpression<string> solutionkey = null)
        {
            WorkflowExpression.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowExpression.Validate(solutionkey, nameof(solutionkey), required: false);
            return new DeferredBodyAction<DataType[]>(() =>
            {
                var apiCallPath = "/padatatypes/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(solutionid);
                if (solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(solutionkey);
                return new ApiConnectionAction<DataType[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        [WorkflowExpressionFactory(nameof(__BuildPadocumentsLoadfile))]
        public IBodyWorkflowAction<string> PadocumentsLoadfile([WorkflowExpression] Func<string> documentkey, [WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<string> solutionkey = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildPadocumentsLoadfile(WorkflowExpression<string> documentkey, WorkflowExpression<int> solutionid = null, WorkflowExpression<string> solutionkey = null)
        {
            WorkflowExpression.Validate(documentkey, nameof(documentkey), required: true);
            WorkflowExpression.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowExpression.Validate(solutionkey, nameof(solutionkey), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/padocuments/loadfile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentkey"] = ExpressionConverter.Convert(documentkey);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(solutionid);
                if (solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(solutionkey);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        [WorkflowExpressionFactory(nameof(__BuildPapropertyvaluesGet))]
        public IBodyWorkflowAction<PropertyValue[]> PapropertyvaluesGet([WorkflowExpression] Func<string> documentkey, [WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<string> solutionkey = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PropertyValue[]> __BuildPapropertyvaluesGet(WorkflowExpression<string> documentkey, WorkflowExpression<int> solutionid = null, WorkflowExpression<string> solutionkey = null)
        {
            WorkflowExpression.Validate(documentkey, nameof(documentkey), required: true);
            WorkflowExpression.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowExpression.Validate(solutionkey, nameof(solutionkey), required: false);
            return new DeferredBodyAction<PropertyValue[]>(() =>
            {
                var apiCallPath = "/papropertyvalues/get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentkey"] = ExpressionConverter.Convert(documentkey);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(solutionid);
                if (solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(solutionkey);
                return new ApiConnectionAction<PropertyValue[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        [WorkflowExpressionFactory(nameof(__BuildPapropertyvaluesUpdate))]
        public IBodyWorkflowAction<PropertyValue[]> PapropertyvaluesUpdate([WorkflowExpression] Func<string> documentkey, [WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<string> solutionkey = null, [WorkflowExpression] Func<PropertyValue[]> propertyValueArray = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PropertyValue[]> __BuildPapropertyvaluesUpdate(WorkflowExpression<string> documentkey, WorkflowExpression<int> solutionid = null, WorkflowExpression<string> solutionkey = null, WorkflowExpression<PropertyValue[]> propertyValueArray = null)
        {
            WorkflowExpression.Validate(documentkey, nameof(documentkey), required: true);
            WorkflowExpression.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowExpression.Validate(solutionkey, nameof(solutionkey), required: false);
            WorkflowExpression.Validate(propertyValueArray, nameof(propertyValueArray), required: false);
            return new DeferredBodyAction<PropertyValue[]>(() =>
            {
                var apiCallPath = "/papropertyvalues/update";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentkey"] = ExpressionConverter.Convert(documentkey);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(solutionid);
                if (solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(solutionkey);
                callPayload.Body = ExpressionConverter.ConvertO(propertyValueArray);
                return new ApiConnectionAction<PropertyValue[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        [WorkflowExpressionFactory(nameof(__BuildPadocumentpropertiesList))]
        public IBodyWorkflowAction<DocumentProperty[]> PadocumentpropertiesList([WorkflowExpression] Func<int> documenttypeid, [WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<string> solutionkey = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentProperty[]> __BuildPadocumentpropertiesList(WorkflowExpression<int> documenttypeid, WorkflowExpression<int> solutionid = null, WorkflowExpression<string> solutionkey = null)
        {
            WorkflowExpression.Validate(documenttypeid, nameof(documenttypeid), required: true);
            WorkflowExpression.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowExpression.Validate(solutionkey, nameof(solutionkey), required: false);
            return new DeferredBodyAction<DocumentProperty[]>(() =>
            {
                var apiCallPath = "/padocumentproperties-list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documenttypeid"] = ExpressionConverter.Convert(documenttypeid);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(solutionid);
                if (solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(solutionkey);
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