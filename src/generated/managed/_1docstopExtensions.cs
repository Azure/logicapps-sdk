//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors._1docstop
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class _1docstopActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Library> PalibrariesAdd(Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null, Expression<Func<int>> librarylibraryId = null, Expression<Func<int>> libraryrepositoryId = null, Expression<Func<int>> libraryrepositoryrepositoryId = null, Expression<Func<string>> libraryrepositoryname = null, Expression<Func<string>> libraryrepositorydescription = null, Expression<Func<int>> libraryrepositoryrepositoryTypeId = null, Expression<Func<int>> libraryrepositoryrepositoryTyperepositoryTypeId = null, Expression<Func<string>> libraryrepositoryrepositoryTypename = null, Expression<Func<string>> libraryrepositoryrepositoryURI = null, Expression<Func<int>> librarydocumentTypeId = null, Expression<Func<int>> librarydocumentTypedocumentTypeId = null, Expression<Func<string>> librarydocumentTypename = null, Expression<Func<string>> librarydocumentTypedescription = null, Expression<Func<string>> libraryname = null, Expression<Func<string>> librarydescription = null, Expression<Func<bool>> libraryocr = null)
        {
            var apiCallPath = "/palibraries/add";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (solutionid != null)
                callPayload.Queries["solutionid"] = CSharpExpressionConverter.ConvertO(solutionid);
            if (solutionkey != null)
                callPayload.Queries["solutionkey"] = CSharpExpressionConverter.ConvertO(solutionkey);
            var library = new JObject();
            var librarypropCount = 0;
            if (librarylibraryId != null)
            {
                library["libraryId"] = CSharpExpressionConverter.ConvertToken(librarylibraryId);
                librarypropCount++;
            }

            if (libraryrepositoryId != null)
            {
                library["repositoryId"] = CSharpExpressionConverter.ConvertToken(libraryrepositoryId);
                librarypropCount++;
            }

            if (librarydocumentTypeId != null)
            {
                library["documentTypeId"] = CSharpExpressionConverter.ConvertToken(librarydocumentTypeId);
                librarypropCount++;
            }

            var documentTypeObject = new JObject();
            var documentTypeObjectpropCount = 0;
            if (librarydocumentTypedocumentTypeId != null)
            {
                documentTypeObject["documentTypeId"] = CSharpExpressionConverter.ConvertToken(librarydocumentTypedocumentTypeId);
                documentTypeObjectpropCount++;
            }

            if (librarydocumentTypename != null)
            {
                documentTypeObject["name"] = CSharpExpressionConverter.ConvertToken(librarydocumentTypename);
                documentTypeObjectpropCount++;
            }

            if (librarydocumentTypedescription != null)
            {
                documentTypeObject["description"] = CSharpExpressionConverter.ConvertToken(librarydocumentTypedescription);
                documentTypeObjectpropCount++;
            }

            if (documentTypeObjectpropCount > 0)
            {
                library["documentType"] = documentTypeObject;
                librarypropCount++;
            }

            if (libraryname != null)
            {
                library["name"] = CSharpExpressionConverter.ConvertToken(libraryname);
                librarypropCount++;
            }

            if (librarydescription != null)
            {
                library["description"] = CSharpExpressionConverter.ConvertToken(librarydescription);
                librarypropCount++;
            }

            if (libraryocr != null)
            {
                library["ocr"] = CSharpExpressionConverter.ConvertToken(libraryocr);
                librarypropCount++;
            }

            if (librarypropCount > 0)
            {
                callPayload.Body = library;
            }

            return new ApiConnectionAction<Library>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Solution> PasolutionsGet(Expression<Func<string>> solutionkey, Expression<Func<int>> solutionid = null)
        {
            var apiCallPath = "/pasolutions/get";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["solutionkey"] = CSharpExpressionConverter.ConvertO(solutionkey);
            if (solutionid != null)
                callPayload.Queries["solutionid"] = CSharpExpressionConverter.ConvertO(solutionid);
            return new ApiConnectionAction<Solution>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Solution[]> PasolutionsList(Expression<Func<int>> solutionid = null)
        {
            var apiCallPath = "/pasolutions/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (solutionid != null)
                callPayload.Queries["solutionid"] = CSharpExpressionConverter.ConvertO(solutionid);
            return new ApiConnectionAction<Solution[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Solution[]> PasolutionsDepartmentList(Expression<Func<string>> departmentkey, Expression<Func<int>> solutionid = null)
        {
            var apiCallPath = "/pasolutions/department/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["departmentkey"] = CSharpExpressionConverter.ConvertO(departmentkey);
            if (solutionid != null)
                callPayload.Queries["solutionid"] = CSharpExpressionConverter.ConvertO(solutionid);
            return new ApiConnectionAction<Solution[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Solution> PasolutionsAdd(Expression<Func<int>> solutionid = null, Expression<Func<int>> solutionsolutionId = null, Expression<Func<string>> solutionsolutionKey = null, Expression<Func<int>> solutiondepartmentdepartmentId = null, Expression<Func<string>> solutiondepartmentdepartmentKey = null, Expression<Func<int>> solutiondepartmentcustomerId = null, Expression<Func<int>> solutiondepartmentcustomercustomerId = null, Expression<Func<string>> solutiondepartmentcustomercustomerKey = null, Expression<Func<string>> solutiondepartmentcustomername = null, Expression<Func<string>> solutiondepartmentname = null, Expression<Func<string>> solutionname = null)
        {
            var apiCallPath = "/pasolutions/add";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (solutionid != null)
                callPayload.Queries["solutionid"] = CSharpExpressionConverter.ConvertO(solutionid);
            var solution = new JObject();
            var solutionpropCount = 0;
            if (solutionsolutionId != null)
            {
                solution["solutionId"] = CSharpExpressionConverter.ConvertToken(solutionsolutionId);
                solutionpropCount++;
            }

            if (solutionsolutionKey != null)
            {
                solution["solutionKey"] = CSharpExpressionConverter.ConvertToken(solutionsolutionKey);
                solutionpropCount++;
            }

            if (solutionname != null)
            {
                solution["name"] = CSharpExpressionConverter.ConvertToken(solutionname);
                solutionpropCount++;
            }

            if (solutionpropCount > 0)
            {
                callPayload.Body = solution;
            }

            return new ApiConnectionAction<Solution>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Solution> PasolutionsUpdate(Expression<Func<int>> solutionid = null, Expression<Func<int>> functionsolutionid = null, Expression<Func<int>> solutionsolutionId = null, Expression<Func<string>> solutionsolutionKey = null, Expression<Func<int>> solutiondepartmentdepartmentId = null, Expression<Func<string>> solutiondepartmentdepartmentKey = null, Expression<Func<int>> solutiondepartmentcustomerId = null, Expression<Func<int>> solutiondepartmentcustomercustomerId = null, Expression<Func<string>> solutiondepartmentcustomercustomerKey = null, Expression<Func<string>> solutiondepartmentcustomername = null, Expression<Func<string>> solutiondepartmentname = null, Expression<Func<string>> solutionname = null)
        {
            var apiCallPath = "/pasolutions/update";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (solutionid != null)
                callPayload.Queries["solutionid"] = CSharpExpressionConverter.ConvertO(solutionid);
            if (functionsolutionid != null)
                callPayload.Queries["functionsolutionid"] = CSharpExpressionConverter.ConvertO(functionsolutionid);
            var solution = new JObject();
            var solutionpropCount = 0;
            if (solutionsolutionId != null)
            {
                solution["solutionId"] = CSharpExpressionConverter.ConvertToken(solutionsolutionId);
                solutionpropCount++;
            }

            if (solutionsolutionKey != null)
            {
                solution["solutionKey"] = CSharpExpressionConverter.ConvertToken(solutionsolutionKey);
                solutionpropCount++;
            }

            if (solutionname != null)
            {
                solution["name"] = CSharpExpressionConverter.ConvertToken(solutionname);
                solutionpropCount++;
            }

            if (solutionpropCount > 0)
            {
                callPayload.Body = solution;
            }

            return new ApiConnectionAction<Solution>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Document> PadocumentsAdd(Expression<Func<int>> libraryid, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null, Expression<Func<string>> documentdocumentKey = null, Expression<Func<string>> documentname = null, Expression<Func<int>> documentfileSizeBytes = null, Expression<Func<int>> documentstatus = null, Expression<Func<PropertyValue[]>> documentpropertyValues = null, Expression<Func<string>> documenturl = null)
        {
            var apiCallPath = "/padocuments/add";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["libraryid"] = CSharpExpressionConverter.ConvertO(libraryid);
            if (solutionid != null)
                callPayload.Queries["solutionid"] = CSharpExpressionConverter.ConvertO(solutionid);
            if (solutionkey != null)
                callPayload.Queries["solutionkey"] = CSharpExpressionConverter.ConvertO(solutionkey);
            var document = new JObject();
            var documentpropCount = 0;
            if (documentdocumentKey != null)
            {
                document["documentKey"] = CSharpExpressionConverter.ConvertToken(documentdocumentKey);
                documentpropCount++;
            }

            if (documentname != null)
            {
                document["name"] = CSharpExpressionConverter.ConvertToken(documentname);
                documentpropCount++;
            }

            if (documentfileSizeBytes != null)
            {
                document["fileSizeBytes"] = CSharpExpressionConverter.ConvertToken(documentfileSizeBytes);
                documentpropCount++;
            }

            if (documentstatus != null)
            {
                document["status"] = CSharpExpressionConverter.ConvertToken(documentstatus);
                documentpropCount++;
            }

            if (documentpropertyValues != null)
            {
                document["propertyValues"] = CSharpExpressionConverter.ConvertToken(documentpropertyValues);
                documentpropCount++;
            }

            if (documenturl != null)
            {
                document["url"] = CSharpExpressionConverter.ConvertToken(documenturl);
                documentpropCount++;
            }

            if (documentpropCount > 0)
            {
                callPayload.Body = document;
            }

            return new ApiConnectionAction<Document>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<DocumentType> PadocumenttypesGet(Expression<Func<int>> documenttypeid, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null)
        {
            var apiCallPath = "/padocumenttypes/get";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["documenttypeid"] = CSharpExpressionConverter.ConvertO(documenttypeid);
            if (solutionid != null)
                callPayload.Queries["solutionid"] = CSharpExpressionConverter.ConvertO(solutionid);
            if (solutionkey != null)
                callPayload.Queries["solutionkey"] = CSharpExpressionConverter.ConvertO(solutionkey);
            return new ApiConnectionAction<DocumentType>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<DocumentType[]> PadocumenttypesList(Expression<Func<string>> solutionkey, Expression<Func<int>> solutionid = null)
        {
            var apiCallPath = "/padocumenttypes/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["solutionkey"] = CSharpExpressionConverter.ConvertO(solutionkey);
            if (solutionid != null)
                callPayload.Queries["solutionid"] = CSharpExpressionConverter.ConvertO(solutionid);
            return new ApiConnectionAction<DocumentType[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Library> PadocumenttypesAdd(Expression<Func<string>> solutionkey, Expression<Func<int>> solutionid = null, Expression<Func<int>> librarylibraryId = null, Expression<Func<int>> libraryrepositoryId = null, Expression<Func<int>> libraryrepositoryrepositoryId = null, Expression<Func<string>> libraryrepositoryname = null, Expression<Func<string>> libraryrepositorydescription = null, Expression<Func<int>> libraryrepositoryrepositoryTypeId = null, Expression<Func<int>> libraryrepositoryrepositoryTyperepositoryTypeId = null, Expression<Func<string>> libraryrepositoryrepositoryTypename = null, Expression<Func<string>> libraryrepositoryrepositoryURI = null, Expression<Func<int>> librarydocumentTypeId = null, Expression<Func<int>> librarydocumentTypedocumentTypeId = null, Expression<Func<string>> librarydocumentTypename = null, Expression<Func<string>> librarydocumentTypedescription = null, Expression<Func<string>> libraryname = null, Expression<Func<string>> librarydescription = null, Expression<Func<bool>> libraryocr = null)
        {
            var apiCallPath = "/padocumenttypes/add";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["solutionkey"] = CSharpExpressionConverter.ConvertO(solutionkey);
            if (solutionid != null)
                callPayload.Queries["solutionid"] = CSharpExpressionConverter.ConvertO(solutionid);
            var library = new JObject();
            var librarypropCount = 0;
            if (librarylibraryId != null)
            {
                library["libraryId"] = CSharpExpressionConverter.ConvertToken(librarylibraryId);
                librarypropCount++;
            }

            if (libraryrepositoryId != null)
            {
                library["repositoryId"] = CSharpExpressionConverter.ConvertToken(libraryrepositoryId);
                librarypropCount++;
            }

            if (librarydocumentTypeId != null)
            {
                library["documentTypeId"] = CSharpExpressionConverter.ConvertToken(librarydocumentTypeId);
                librarypropCount++;
            }

            var documentTypeObject = new JObject();
            var documentTypeObjectpropCount = 0;
            if (librarydocumentTypedocumentTypeId != null)
            {
                documentTypeObject["documentTypeId"] = CSharpExpressionConverter.ConvertToken(librarydocumentTypedocumentTypeId);
                documentTypeObjectpropCount++;
            }

            if (librarydocumentTypename != null)
            {
                documentTypeObject["name"] = CSharpExpressionConverter.ConvertToken(librarydocumentTypename);
                documentTypeObjectpropCount++;
            }

            if (librarydocumentTypedescription != null)
            {
                documentTypeObject["description"] = CSharpExpressionConverter.ConvertToken(librarydocumentTypedescription);
                documentTypeObjectpropCount++;
            }

            if (documentTypeObjectpropCount > 0)
            {
                library["documentType"] = documentTypeObject;
                librarypropCount++;
            }

            if (libraryname != null)
            {
                library["name"] = CSharpExpressionConverter.ConvertToken(libraryname);
                librarypropCount++;
            }

            if (librarydescription != null)
            {
                library["description"] = CSharpExpressionConverter.ConvertToken(librarydescription);
                librarypropCount++;
            }

            if (libraryocr != null)
            {
                library["ocr"] = CSharpExpressionConverter.ConvertToken(libraryocr);
                librarypropCount++;
            }

            if (librarypropCount > 0)
            {
                callPayload.Body = library;
            }

            return new ApiConnectionAction<Library>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<DocumentType> PadocumenttypesUpdate(Expression<Func<int>> documenttypeid, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null, Expression<Func<int>> documentTypedocumentTypeId = null, Expression<Func<string>> documentTypename = null, Expression<Func<string>> documentTypedescription = null)
        {
            var apiCallPath = "/padocumenttypes/update";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["documenttypeid"] = CSharpExpressionConverter.ConvertO(documenttypeid);
            if (solutionid != null)
                callPayload.Queries["solutionid"] = CSharpExpressionConverter.ConvertO(solutionid);
            if (solutionkey != null)
                callPayload.Queries["solutionkey"] = CSharpExpressionConverter.ConvertO(solutionkey);
            var documentType = new JObject();
            var documentTypepropCount = 0;
            if (documentTypedocumentTypeId != null)
            {
                documentType["documentTypeId"] = CSharpExpressionConverter.ConvertToken(documentTypedocumentTypeId);
                documentTypepropCount++;
            }

            if (documentTypename != null)
            {
                documentType["name"] = CSharpExpressionConverter.ConvertToken(documentTypename);
                documentTypepropCount++;
            }

            if (documentTypedescription != null)
            {
                documentType["description"] = CSharpExpressionConverter.ConvertToken(documentTypedescription);
                documentTypepropCount++;
            }

            if (documentTypepropCount > 0)
            {
                callPayload.Body = documentType;
            }

            return new ApiConnectionAction<DocumentType>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Library> PalibrariesGet(Expression<Func<int>> libraryid, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null)
        {
            var apiCallPath = "/palibraries/get";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["libraryid"] = CSharpExpressionConverter.ConvertO(libraryid);
            if (solutionid != null)
                callPayload.Queries["solutionid"] = CSharpExpressionConverter.ConvertO(solutionid);
            if (solutionkey != null)
                callPayload.Queries["solutionkey"] = CSharpExpressionConverter.ConvertO(solutionkey);
            return new ApiConnectionAction<Library>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Library[]> PalibrariesList(Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null)
        {
            var apiCallPath = "/palibraries/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (solutionid != null)
                callPayload.Queries["solutionid"] = CSharpExpressionConverter.ConvertO(solutionid);
            if (solutionkey != null)
                callPayload.Queries["solutionkey"] = CSharpExpressionConverter.ConvertO(solutionkey);
            return new ApiConnectionAction<Library[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Library[]> PalibrariesDocumenttypeList(Expression<Func<int>> documenttypeid, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null)
        {
            var apiCallPath = "/palibraries/documenttype/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["documenttypeid"] = CSharpExpressionConverter.ConvertO(documenttypeid);
            if (solutionid != null)
                callPayload.Queries["solutionid"] = CSharpExpressionConverter.ConvertO(solutionid);
            if (solutionkey != null)
                callPayload.Queries["solutionkey"] = CSharpExpressionConverter.ConvertO(solutionkey);
            return new ApiConnectionAction<Library[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Library> PalibrariesUpdate(Expression<Func<int>> libraryid, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null, Expression<Func<int>> librarylibraryId = null, Expression<Func<int>> libraryrepositoryId = null, Expression<Func<int>> libraryrepositoryrepositoryId = null, Expression<Func<string>> libraryrepositoryname = null, Expression<Func<string>> libraryrepositorydescription = null, Expression<Func<int>> libraryrepositoryrepositoryTypeId = null, Expression<Func<int>> libraryrepositoryrepositoryTyperepositoryTypeId = null, Expression<Func<string>> libraryrepositoryrepositoryTypename = null, Expression<Func<string>> libraryrepositoryrepositoryURI = null, Expression<Func<int>> librarydocumentTypeId = null, Expression<Func<int>> librarydocumentTypedocumentTypeId = null, Expression<Func<string>> librarydocumentTypename = null, Expression<Func<string>> librarydocumentTypedescription = null, Expression<Func<string>> libraryname = null, Expression<Func<string>> librarydescription = null, Expression<Func<bool>> libraryocr = null)
        {
            var apiCallPath = "/palibraries/update";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["libraryid"] = CSharpExpressionConverter.ConvertO(libraryid);
            if (solutionid != null)
                callPayload.Queries["solutionid"] = CSharpExpressionConverter.ConvertO(solutionid);
            if (solutionkey != null)
                callPayload.Queries["solutionkey"] = CSharpExpressionConverter.ConvertO(solutionkey);
            var library = new JObject();
            var librarypropCount = 0;
            if (librarylibraryId != null)
            {
                library["libraryId"] = CSharpExpressionConverter.ConvertToken(librarylibraryId);
                librarypropCount++;
            }

            if (libraryrepositoryId != null)
            {
                library["repositoryId"] = CSharpExpressionConverter.ConvertToken(libraryrepositoryId);
                librarypropCount++;
            }

            if (librarydocumentTypeId != null)
            {
                library["documentTypeId"] = CSharpExpressionConverter.ConvertToken(librarydocumentTypeId);
                librarypropCount++;
            }

            var documentTypeObject = new JObject();
            var documentTypeObjectpropCount = 0;
            if (librarydocumentTypedocumentTypeId != null)
            {
                documentTypeObject["documentTypeId"] = CSharpExpressionConverter.ConvertToken(librarydocumentTypedocumentTypeId);
                documentTypeObjectpropCount++;
            }

            if (librarydocumentTypename != null)
            {
                documentTypeObject["name"] = CSharpExpressionConverter.ConvertToken(librarydocumentTypename);
                documentTypeObjectpropCount++;
            }

            if (librarydocumentTypedescription != null)
            {
                documentTypeObject["description"] = CSharpExpressionConverter.ConvertToken(librarydocumentTypedescription);
                documentTypeObjectpropCount++;
            }

            if (documentTypeObjectpropCount > 0)
            {
                library["documentType"] = documentTypeObject;
                librarypropCount++;
            }

            if (libraryname != null)
            {
                library["name"] = CSharpExpressionConverter.ConvertToken(libraryname);
                librarypropCount++;
            }

            if (librarydescription != null)
            {
                library["description"] = CSharpExpressionConverter.ConvertToken(librarydescription);
                librarypropCount++;
            }

            if (libraryocr != null)
            {
                library["ocr"] = CSharpExpressionConverter.ConvertToken(libraryocr);
                librarypropCount++;
            }

            if (librarypropCount > 0)
            {
                callPayload.Body = library;
            }

            return new ApiConnectionAction<Library>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<DataType[]> PadatatypesList(Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null)
        {
            var apiCallPath = "/padatatypes/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (solutionid != null)
                callPayload.Queries["solutionid"] = CSharpExpressionConverter.ConvertO(solutionid);
            if (solutionkey != null)
                callPayload.Queries["solutionkey"] = CSharpExpressionConverter.ConvertO(solutionkey);
            return new ApiConnectionAction<DataType[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<string> PadocumentsLoadfile(Expression<Func<string>> documentkey, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null)
        {
            var apiCallPath = "/padocuments/loadfile";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["documentkey"] = CSharpExpressionConverter.ConvertO(documentkey);
            if (solutionid != null)
                callPayload.Queries["solutionid"] = CSharpExpressionConverter.ConvertO(solutionid);
            if (solutionkey != null)
                callPayload.Queries["solutionkey"] = CSharpExpressionConverter.ConvertO(solutionkey);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<PropertyValue[]> PapropertyvaluesGet(Expression<Func<string>> documentkey, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null)
        {
            var apiCallPath = "/papropertyvalues/get";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["documentkey"] = CSharpExpressionConverter.ConvertO(documentkey);
            if (solutionid != null)
                callPayload.Queries["solutionid"] = CSharpExpressionConverter.ConvertO(solutionid);
            if (solutionkey != null)
                callPayload.Queries["solutionkey"] = CSharpExpressionConverter.ConvertO(solutionkey);
            return new ApiConnectionAction<PropertyValue[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<PropertyValue[]> PapropertyvaluesUpdate(Expression<Func<string>> documentkey, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null, Expression<Func<PropertyValue[]>> propertyValueArray = null)
        {
            var apiCallPath = "/papropertyvalues/update";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["documentkey"] = CSharpExpressionConverter.ConvertO(documentkey);
            if (solutionid != null)
                callPayload.Queries["solutionid"] = CSharpExpressionConverter.ConvertO(solutionid);
            if (solutionkey != null)
                callPayload.Queries["solutionkey"] = CSharpExpressionConverter.ConvertO(solutionkey);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(propertyValueArray);
            return new ApiConnectionAction<PropertyValue[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<DocumentProperty[]> PadocumentpropertiesList(Expression<Func<int>> documenttypeid, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null)
        {
            var apiCallPath = "/padocumentproperties-list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["documenttypeid"] = CSharpExpressionConverter.ConvertO(documenttypeid);
            if (solutionid != null)
                callPayload.Queries["solutionid"] = CSharpExpressionConverter.ConvertO(solutionid);
            if (solutionkey != null)
                callPayload.Queries["solutionkey"] = CSharpExpressionConverter.ConvertO(solutionkey);
            return new ApiConnectionAction<DocumentProperty[]>(callPayload);
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