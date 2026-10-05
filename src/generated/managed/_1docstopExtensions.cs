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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Library> __BuildPalibrariesAdd(WorkflowValue<int> solutionid = null, WorkflowValue<string> solutionkey = null, WorkflowValue<int> librarylibraryId = null, WorkflowValue<int> libraryrepositoryId = null, WorkflowValue<int> libraryrepositoryrepositoryId = null, WorkflowValue<string> libraryrepositoryname = null, WorkflowValue<string> libraryrepositorydescription = null, WorkflowValue<int> libraryrepositoryrepositoryTypeId = null, WorkflowValue<int> libraryrepositoryrepositoryTyperepositoryTypeId = null, WorkflowValue<string> libraryrepositoryrepositoryTypename = null, WorkflowValue<string> libraryrepositoryrepositoryURI = null, WorkflowValue<int> librarydocumentTypeId = null, WorkflowValue<int> librarydocumentTypedocumentTypeId = null, WorkflowValue<string> librarydocumentTypename = null, WorkflowValue<string> librarydocumentTypedescription = null, WorkflowValue<string> libraryname = null, WorkflowValue<string> librarydescription = null, WorkflowValue<bool> libraryocr = null)
        {
            WorkflowValue.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowValue.Validate(solutionkey, nameof(solutionkey), required: false);
            WorkflowValue.Validate(librarylibraryId, nameof(librarylibraryId), required: false);
            WorkflowValue.Validate(libraryrepositoryId, nameof(libraryrepositoryId), required: false);
            WorkflowValue.Validate(libraryrepositoryrepositoryId, nameof(libraryrepositoryrepositoryId), required: false);
            WorkflowValue.Validate(libraryrepositoryname, nameof(libraryrepositoryname), required: false);
            WorkflowValue.Validate(libraryrepositorydescription, nameof(libraryrepositorydescription), required: false);
            WorkflowValue.Validate(libraryrepositoryrepositoryTypeId, nameof(libraryrepositoryrepositoryTypeId), required: false);
            WorkflowValue.Validate(libraryrepositoryrepositoryTyperepositoryTypeId, nameof(libraryrepositoryrepositoryTyperepositoryTypeId), required: false);
            WorkflowValue.Validate(libraryrepositoryrepositoryTypename, nameof(libraryrepositoryrepositoryTypename), required: false);
            WorkflowValue.Validate(libraryrepositoryrepositoryURI, nameof(libraryrepositoryrepositoryURI), required: false);
            WorkflowValue.Validate(librarydocumentTypeId, nameof(librarydocumentTypeId), required: false);
            WorkflowValue.Validate(librarydocumentTypedocumentTypeId, nameof(librarydocumentTypedocumentTypeId), required: false);
            WorkflowValue.Validate(librarydocumentTypename, nameof(librarydocumentTypename), required: false);
            WorkflowValue.Validate(librarydocumentTypedescription, nameof(librarydocumentTypedescription), required: false);
            WorkflowValue.Validate(libraryname, nameof(libraryname), required: false);
            WorkflowValue.Validate(librarydescription, nameof(librarydescription), required: false);
            WorkflowValue.Validate(libraryocr, nameof(libraryocr), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Solution> __BuildPasolutionsGet(WorkflowValue<string> solutionkey, WorkflowValue<int> solutionid = null)
        {
            WorkflowValue.Validate(solutionkey, nameof(solutionkey), required: true);
            WorkflowValue.Validate(solutionid, nameof(solutionid), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Solution[]> __BuildPasolutionsList(WorkflowValue<int> solutionid = null)
        {
            WorkflowValue.Validate(solutionid, nameof(solutionid), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Solution[]> __BuildPasolutionsDepartmentList(WorkflowValue<string> departmentkey, WorkflowValue<int> solutionid = null)
        {
            WorkflowValue.Validate(departmentkey, nameof(departmentkey), required: true);
            WorkflowValue.Validate(solutionid, nameof(solutionid), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Solution> __BuildPasolutionsAdd(WorkflowValue<int> solutionid = null, WorkflowValue<int> solutionsolutionId = null, WorkflowValue<string> solutionsolutionKey = null, WorkflowValue<int> solutiondepartmentdepartmentId = null, WorkflowValue<string> solutiondepartmentdepartmentKey = null, WorkflowValue<int> solutiondepartmentcustomerId = null, WorkflowValue<int> solutiondepartmentcustomercustomerId = null, WorkflowValue<string> solutiondepartmentcustomercustomerKey = null, WorkflowValue<string> solutiondepartmentcustomername = null, WorkflowValue<string> solutiondepartmentname = null, WorkflowValue<string> solutionname = null)
        {
            WorkflowValue.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowValue.Validate(solutionsolutionId, nameof(solutionsolutionId), required: false);
            WorkflowValue.Validate(solutionsolutionKey, nameof(solutionsolutionKey), required: false);
            WorkflowValue.Validate(solutiondepartmentdepartmentId, nameof(solutiondepartmentdepartmentId), required: false);
            WorkflowValue.Validate(solutiondepartmentdepartmentKey, nameof(solutiondepartmentdepartmentKey), required: false);
            WorkflowValue.Validate(solutiondepartmentcustomerId, nameof(solutiondepartmentcustomerId), required: false);
            WorkflowValue.Validate(solutiondepartmentcustomercustomerId, nameof(solutiondepartmentcustomercustomerId), required: false);
            WorkflowValue.Validate(solutiondepartmentcustomercustomerKey, nameof(solutiondepartmentcustomercustomerKey), required: false);
            WorkflowValue.Validate(solutiondepartmentcustomername, nameof(solutiondepartmentcustomername), required: false);
            WorkflowValue.Validate(solutiondepartmentname, nameof(solutiondepartmentname), required: false);
            WorkflowValue.Validate(solutionname, nameof(solutionname), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Solution> __BuildPasolutionsUpdate(WorkflowValue<int> solutionid = null, WorkflowValue<int> functionsolutionid = null, WorkflowValue<int> solutionsolutionId = null, WorkflowValue<string> solutionsolutionKey = null, WorkflowValue<int> solutiondepartmentdepartmentId = null, WorkflowValue<string> solutiondepartmentdepartmentKey = null, WorkflowValue<int> solutiondepartmentcustomerId = null, WorkflowValue<int> solutiondepartmentcustomercustomerId = null, WorkflowValue<string> solutiondepartmentcustomercustomerKey = null, WorkflowValue<string> solutiondepartmentcustomername = null, WorkflowValue<string> solutiondepartmentname = null, WorkflowValue<string> solutionname = null)
        {
            WorkflowValue.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowValue.Validate(functionsolutionid, nameof(functionsolutionid), required: false);
            WorkflowValue.Validate(solutionsolutionId, nameof(solutionsolutionId), required: false);
            WorkflowValue.Validate(solutionsolutionKey, nameof(solutionsolutionKey), required: false);
            WorkflowValue.Validate(solutiondepartmentdepartmentId, nameof(solutiondepartmentdepartmentId), required: false);
            WorkflowValue.Validate(solutiondepartmentdepartmentKey, nameof(solutiondepartmentdepartmentKey), required: false);
            WorkflowValue.Validate(solutiondepartmentcustomerId, nameof(solutiondepartmentcustomerId), required: false);
            WorkflowValue.Validate(solutiondepartmentcustomercustomerId, nameof(solutiondepartmentcustomercustomerId), required: false);
            WorkflowValue.Validate(solutiondepartmentcustomercustomerKey, nameof(solutiondepartmentcustomercustomerKey), required: false);
            WorkflowValue.Validate(solutiondepartmentcustomername, nameof(solutiondepartmentcustomername), required: false);
            WorkflowValue.Validate(solutiondepartmentname, nameof(solutiondepartmentname), required: false);
            WorkflowValue.Validate(solutionname, nameof(solutionname), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Document> __BuildPadocumentsAdd(WorkflowValue<int> libraryid, WorkflowValue<int> solutionid = null, WorkflowValue<string> solutionkey = null, WorkflowValue<string> documentdocumentKey = null, WorkflowValue<string> documentname = null, WorkflowValue<int> documentfileSizeBytes = null, WorkflowValue<int> documentstatus = null, WorkflowValue<PropertyValue[]> documentpropertyValues = null, WorkflowValue<string> documenturl = null)
        {
            WorkflowValue.Validate(libraryid, nameof(libraryid), required: true);
            WorkflowValue.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowValue.Validate(solutionkey, nameof(solutionkey), required: false);
            WorkflowValue.Validate(documentdocumentKey, nameof(documentdocumentKey), required: false);
            WorkflowValue.Validate(documentname, nameof(documentname), required: false);
            WorkflowValue.Validate(documentfileSizeBytes, nameof(documentfileSizeBytes), required: false);
            WorkflowValue.Validate(documentstatus, nameof(documentstatus), required: false);
            WorkflowValue.Validate(documentpropertyValues, nameof(documentpropertyValues), required: false);
            WorkflowValue.Validate(documenturl, nameof(documenturl), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentType> __BuildPadocumenttypesGet(WorkflowValue<int> documenttypeid, WorkflowValue<int> solutionid = null, WorkflowValue<string> solutionkey = null)
        {
            WorkflowValue.Validate(documenttypeid, nameof(documenttypeid), required: true);
            WorkflowValue.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowValue.Validate(solutionkey, nameof(solutionkey), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentType[]> __BuildPadocumenttypesList(WorkflowValue<string> solutionkey, WorkflowValue<int> solutionid = null)
        {
            WorkflowValue.Validate(solutionkey, nameof(solutionkey), required: true);
            WorkflowValue.Validate(solutionid, nameof(solutionid), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Library> __BuildPadocumenttypesAdd(WorkflowValue<string> solutionkey, WorkflowValue<int> solutionid = null, WorkflowValue<int> librarylibraryId = null, WorkflowValue<int> libraryrepositoryId = null, WorkflowValue<int> libraryrepositoryrepositoryId = null, WorkflowValue<string> libraryrepositoryname = null, WorkflowValue<string> libraryrepositorydescription = null, WorkflowValue<int> libraryrepositoryrepositoryTypeId = null, WorkflowValue<int> libraryrepositoryrepositoryTyperepositoryTypeId = null, WorkflowValue<string> libraryrepositoryrepositoryTypename = null, WorkflowValue<string> libraryrepositoryrepositoryURI = null, WorkflowValue<int> librarydocumentTypeId = null, WorkflowValue<int> librarydocumentTypedocumentTypeId = null, WorkflowValue<string> librarydocumentTypename = null, WorkflowValue<string> librarydocumentTypedescription = null, WorkflowValue<string> libraryname = null, WorkflowValue<string> librarydescription = null, WorkflowValue<bool> libraryocr = null)
        {
            WorkflowValue.Validate(solutionkey, nameof(solutionkey), required: true);
            WorkflowValue.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowValue.Validate(librarylibraryId, nameof(librarylibraryId), required: false);
            WorkflowValue.Validate(libraryrepositoryId, nameof(libraryrepositoryId), required: false);
            WorkflowValue.Validate(libraryrepositoryrepositoryId, nameof(libraryrepositoryrepositoryId), required: false);
            WorkflowValue.Validate(libraryrepositoryname, nameof(libraryrepositoryname), required: false);
            WorkflowValue.Validate(libraryrepositorydescription, nameof(libraryrepositorydescription), required: false);
            WorkflowValue.Validate(libraryrepositoryrepositoryTypeId, nameof(libraryrepositoryrepositoryTypeId), required: false);
            WorkflowValue.Validate(libraryrepositoryrepositoryTyperepositoryTypeId, nameof(libraryrepositoryrepositoryTyperepositoryTypeId), required: false);
            WorkflowValue.Validate(libraryrepositoryrepositoryTypename, nameof(libraryrepositoryrepositoryTypename), required: false);
            WorkflowValue.Validate(libraryrepositoryrepositoryURI, nameof(libraryrepositoryrepositoryURI), required: false);
            WorkflowValue.Validate(librarydocumentTypeId, nameof(librarydocumentTypeId), required: false);
            WorkflowValue.Validate(librarydocumentTypedocumentTypeId, nameof(librarydocumentTypedocumentTypeId), required: false);
            WorkflowValue.Validate(librarydocumentTypename, nameof(librarydocumentTypename), required: false);
            WorkflowValue.Validate(librarydocumentTypedescription, nameof(librarydocumentTypedescription), required: false);
            WorkflowValue.Validate(libraryname, nameof(libraryname), required: false);
            WorkflowValue.Validate(librarydescription, nameof(librarydescription), required: false);
            WorkflowValue.Validate(libraryocr, nameof(libraryocr), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentType> __BuildPadocumenttypesUpdate(WorkflowValue<int> documenttypeid, WorkflowValue<int> solutionid = null, WorkflowValue<string> solutionkey = null, WorkflowValue<int> documentTypedocumentTypeId = null, WorkflowValue<string> documentTypename = null, WorkflowValue<string> documentTypedescription = null)
        {
            WorkflowValue.Validate(documenttypeid, nameof(documenttypeid), required: true);
            WorkflowValue.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowValue.Validate(solutionkey, nameof(solutionkey), required: false);
            WorkflowValue.Validate(documentTypedocumentTypeId, nameof(documentTypedocumentTypeId), required: false);
            WorkflowValue.Validate(documentTypename, nameof(documentTypename), required: false);
            WorkflowValue.Validate(documentTypedescription, nameof(documentTypedescription), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Library> __BuildPalibrariesGet(WorkflowValue<int> libraryid, WorkflowValue<int> solutionid = null, WorkflowValue<string> solutionkey = null)
        {
            WorkflowValue.Validate(libraryid, nameof(libraryid), required: true);
            WorkflowValue.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowValue.Validate(solutionkey, nameof(solutionkey), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Library[]> __BuildPalibrariesList(WorkflowValue<int> solutionid = null, WorkflowValue<string> solutionkey = null)
        {
            WorkflowValue.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowValue.Validate(solutionkey, nameof(solutionkey), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Library[]> __BuildPalibrariesDocumenttypeList(WorkflowValue<int> documenttypeid, WorkflowValue<int> solutionid = null, WorkflowValue<string> solutionkey = null)
        {
            WorkflowValue.Validate(documenttypeid, nameof(documenttypeid), required: true);
            WorkflowValue.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowValue.Validate(solutionkey, nameof(solutionkey), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Library> __BuildPalibrariesUpdate(WorkflowValue<int> libraryid, WorkflowValue<int> solutionid = null, WorkflowValue<string> solutionkey = null, WorkflowValue<int> librarylibraryId = null, WorkflowValue<int> libraryrepositoryId = null, WorkflowValue<int> libraryrepositoryrepositoryId = null, WorkflowValue<string> libraryrepositoryname = null, WorkflowValue<string> libraryrepositorydescription = null, WorkflowValue<int> libraryrepositoryrepositoryTypeId = null, WorkflowValue<int> libraryrepositoryrepositoryTyperepositoryTypeId = null, WorkflowValue<string> libraryrepositoryrepositoryTypename = null, WorkflowValue<string> libraryrepositoryrepositoryURI = null, WorkflowValue<int> librarydocumentTypeId = null, WorkflowValue<int> librarydocumentTypedocumentTypeId = null, WorkflowValue<string> librarydocumentTypename = null, WorkflowValue<string> librarydocumentTypedescription = null, WorkflowValue<string> libraryname = null, WorkflowValue<string> librarydescription = null, WorkflowValue<bool> libraryocr = null)
        {
            WorkflowValue.Validate(libraryid, nameof(libraryid), required: true);
            WorkflowValue.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowValue.Validate(solutionkey, nameof(solutionkey), required: false);
            WorkflowValue.Validate(librarylibraryId, nameof(librarylibraryId), required: false);
            WorkflowValue.Validate(libraryrepositoryId, nameof(libraryrepositoryId), required: false);
            WorkflowValue.Validate(libraryrepositoryrepositoryId, nameof(libraryrepositoryrepositoryId), required: false);
            WorkflowValue.Validate(libraryrepositoryname, nameof(libraryrepositoryname), required: false);
            WorkflowValue.Validate(libraryrepositorydescription, nameof(libraryrepositorydescription), required: false);
            WorkflowValue.Validate(libraryrepositoryrepositoryTypeId, nameof(libraryrepositoryrepositoryTypeId), required: false);
            WorkflowValue.Validate(libraryrepositoryrepositoryTyperepositoryTypeId, nameof(libraryrepositoryrepositoryTyperepositoryTypeId), required: false);
            WorkflowValue.Validate(libraryrepositoryrepositoryTypename, nameof(libraryrepositoryrepositoryTypename), required: false);
            WorkflowValue.Validate(libraryrepositoryrepositoryURI, nameof(libraryrepositoryrepositoryURI), required: false);
            WorkflowValue.Validate(librarydocumentTypeId, nameof(librarydocumentTypeId), required: false);
            WorkflowValue.Validate(librarydocumentTypedocumentTypeId, nameof(librarydocumentTypedocumentTypeId), required: false);
            WorkflowValue.Validate(librarydocumentTypename, nameof(librarydocumentTypename), required: false);
            WorkflowValue.Validate(librarydocumentTypedescription, nameof(librarydocumentTypedescription), required: false);
            WorkflowValue.Validate(libraryname, nameof(libraryname), required: false);
            WorkflowValue.Validate(librarydescription, nameof(librarydescription), required: false);
            WorkflowValue.Validate(libraryocr, nameof(libraryocr), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DataType[]> __BuildPadatatypesList(WorkflowValue<int> solutionid = null, WorkflowValue<string> solutionkey = null)
        {
            WorkflowValue.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowValue.Validate(solutionkey, nameof(solutionkey), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildPadocumentsLoadfile(WorkflowValue<string> documentkey, WorkflowValue<int> solutionid = null, WorkflowValue<string> solutionkey = null)
        {
            WorkflowValue.Validate(documentkey, nameof(documentkey), required: true);
            WorkflowValue.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowValue.Validate(solutionkey, nameof(solutionkey), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PropertyValue[]> __BuildPapropertyvaluesGet(WorkflowValue<string> documentkey, WorkflowValue<int> solutionid = null, WorkflowValue<string> solutionkey = null)
        {
            WorkflowValue.Validate(documentkey, nameof(documentkey), required: true);
            WorkflowValue.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowValue.Validate(solutionkey, nameof(solutionkey), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PropertyValue[]> __BuildPapropertyvaluesUpdate(WorkflowValue<string> documentkey, WorkflowValue<int> solutionid = null, WorkflowValue<string> solutionkey = null, WorkflowValue<PropertyValue[]> propertyValueArray = null)
        {
            WorkflowValue.Validate(documentkey, nameof(documentkey), required: true);
            WorkflowValue.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowValue.Validate(solutionkey, nameof(solutionkey), required: false);
            WorkflowValue.Validate(propertyValueArray, nameof(propertyValueArray), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentProperty[]> __BuildPadocumentpropertiesList(WorkflowValue<int> documenttypeid, WorkflowValue<int> solutionid = null, WorkflowValue<string> solutionkey = null)
        {
            WorkflowValue.Validate(documenttypeid, nameof(documenttypeid), required: true);
            WorkflowValue.Validate(solutionid, nameof(solutionid), required: false);
            WorkflowValue.Validate(solutionkey, nameof(solutionkey), required: false);
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
