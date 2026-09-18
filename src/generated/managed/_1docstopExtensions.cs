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
        public IBodyWorkflowAction<Library> PalibrariesAdd([WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<string> solutionkey = null, [WorkflowExpression] Func<int> librarylibraryId = null, [WorkflowExpression] Func<int> libraryrepositoryId = null, [WorkflowExpression] Func<int> libraryrepositoryrepositoryId = null, [WorkflowExpression] Func<string> libraryrepositoryname = null, [WorkflowExpression] Func<string> libraryrepositorydescription = null, [WorkflowExpression] Func<int> libraryrepositoryrepositoryTypeId = null, [WorkflowExpression] Func<int> libraryrepositoryrepositoryTyperepositoryTypeId = null, [WorkflowExpression] Func<string> libraryrepositoryrepositoryTypename = null, [WorkflowExpression] Func<string> libraryrepositoryrepositoryURI = null, [WorkflowExpression] Func<int> librarydocumentTypeId = null, [WorkflowExpression] Func<int> librarydocumentTypedocumentTypeId = null, [WorkflowExpression] Func<string> librarydocumentTypename = null, [WorkflowExpression] Func<string> librarydocumentTypedescription = null, [WorkflowExpression] Func<string> libraryname = null, [WorkflowExpression] Func<string> librarydescription = null, [WorkflowExpression] Func<bool> libraryocr = null)
        {
            SourceExpression.Validate(solutionid, nameof(solutionid), required: false);
            SourceExpression.Validate(solutionkey, nameof(solutionkey), required: false);
            SourceExpression.Validate(librarylibraryId, nameof(librarylibraryId), required: false);
            SourceExpression.Validate(libraryrepositoryId, nameof(libraryrepositoryId), required: false);
            SourceExpression.Validate(libraryrepositoryrepositoryId, nameof(libraryrepositoryrepositoryId), required: false);
            SourceExpression.Validate(libraryrepositoryname, nameof(libraryrepositoryname), required: false);
            SourceExpression.Validate(libraryrepositorydescription, nameof(libraryrepositorydescription), required: false);
            SourceExpression.Validate(libraryrepositoryrepositoryTypeId, nameof(libraryrepositoryrepositoryTypeId), required: false);
            SourceExpression.Validate(libraryrepositoryrepositoryTyperepositoryTypeId, nameof(libraryrepositoryrepositoryTyperepositoryTypeId), required: false);
            SourceExpression.Validate(libraryrepositoryrepositoryTypename, nameof(libraryrepositoryrepositoryTypename), required: false);
            SourceExpression.Validate(libraryrepositoryrepositoryURI, nameof(libraryrepositoryrepositoryURI), required: false);
            SourceExpression.Validate(librarydocumentTypeId, nameof(librarydocumentTypeId), required: false);
            SourceExpression.Validate(librarydocumentTypedocumentTypeId, nameof(librarydocumentTypedocumentTypeId), required: false);
            SourceExpression.Validate(librarydocumentTypename, nameof(librarydocumentTypename), required: false);
            SourceExpression.Validate(librarydocumentTypedescription, nameof(librarydocumentTypedescription), required: false);
            SourceExpression.Validate(libraryname, nameof(libraryname), required: false);
            SourceExpression.Validate(librarydescription, nameof(librarydescription), required: false);
            SourceExpression.Validate(libraryocr, nameof(libraryocr), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/palibraries/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = SourceExpressionConverter.ConvertO(solutionid);
                if (solutionkey != null)
                    callPayload.Queries["solutionkey"] = SourceExpressionConverter.ConvertO(solutionkey);
                var library = new JObject();
                var librarypropCount = 0;
                if (librarylibraryId != null)
                {
                    library["libraryId"] = SourceExpressionConverter.ConvertToken(librarylibraryId);
                    librarypropCount++;
                }

                if (libraryrepositoryId != null)
                {
                    library["repositoryId"] = SourceExpressionConverter.ConvertToken(libraryrepositoryId);
                    librarypropCount++;
                }

                if (librarydocumentTypeId != null)
                {
                    library["documentTypeId"] = SourceExpressionConverter.ConvertToken(librarydocumentTypeId);
                    librarypropCount++;
                }

                var documentTypeObject = new JObject();
                var documentTypeObjectpropCount = 0;
                if (librarydocumentTypedocumentTypeId != null)
                {
                    documentTypeObject["documentTypeId"] = SourceExpressionConverter.ConvertToken(librarydocumentTypedocumentTypeId);
                    documentTypeObjectpropCount++;
                }

                if (librarydocumentTypename != null)
                {
                    documentTypeObject["name"] = SourceExpressionConverter.ConvertToken(librarydocumentTypename);
                    documentTypeObjectpropCount++;
                }

                if (librarydocumentTypedescription != null)
                {
                    documentTypeObject["description"] = SourceExpressionConverter.ConvertToken(librarydocumentTypedescription);
                    documentTypeObjectpropCount++;
                }

                if (documentTypeObjectpropCount > 0)
                {
                    library["documentType"] = documentTypeObject;
                    librarypropCount++;
                }

                if (libraryname != null)
                {
                    library["name"] = SourceExpressionConverter.ConvertToken(libraryname);
                    librarypropCount++;
                }

                if (librarydescription != null)
                {
                    library["description"] = SourceExpressionConverter.ConvertToken(librarydescription);
                    librarypropCount++;
                }

                if (libraryocr != null)
                {
                    library["ocr"] = SourceExpressionConverter.ConvertToken(libraryocr);
                    librarypropCount++;
                }

                if (librarypropCount > 0)
                {
                    callPayload.Body = library;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Library>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Solution> PasolutionsGet([WorkflowExpression] Func<string> solutionkey, [WorkflowExpression] Func<int> solutionid = null)
        {
            SourceExpression.Validate(solutionkey, nameof(solutionkey), required: true);
            SourceExpression.Validate(solutionid, nameof(solutionid), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pasolutions/get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["solutionkey"] = SourceExpressionConverter.ConvertO(solutionkey);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = SourceExpressionConverter.ConvertO(solutionid);
                return callPayload;
            }

            return new ApiConnectionAction<Solution>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Solution[]> PasolutionsList([WorkflowExpression] Func<int> solutionid = null)
        {
            SourceExpression.Validate(solutionid, nameof(solutionid), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pasolutions/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = SourceExpressionConverter.ConvertO(solutionid);
                return callPayload;
            }

            return new ApiConnectionAction<Solution[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Solution[]> PasolutionsDepartmentList([WorkflowExpression] Func<string> departmentkey, [WorkflowExpression] Func<int> solutionid = null)
        {
            SourceExpression.Validate(departmentkey, nameof(departmentkey), required: true);
            SourceExpression.Validate(solutionid, nameof(solutionid), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pasolutions/department/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["departmentkey"] = SourceExpressionConverter.ConvertO(departmentkey);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = SourceExpressionConverter.ConvertO(solutionid);
                return callPayload;
            }

            return new ApiConnectionAction<Solution[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Solution> PasolutionsAdd([WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<int> solutionsolutionId = null, [WorkflowExpression] Func<string> solutionsolutionKey = null, [WorkflowExpression] Func<int> solutiondepartmentdepartmentId = null, [WorkflowExpression] Func<string> solutiondepartmentdepartmentKey = null, [WorkflowExpression] Func<int> solutiondepartmentcustomerId = null, [WorkflowExpression] Func<int> solutiondepartmentcustomercustomerId = null, [WorkflowExpression] Func<string> solutiondepartmentcustomercustomerKey = null, [WorkflowExpression] Func<string> solutiondepartmentcustomername = null, [WorkflowExpression] Func<string> solutiondepartmentname = null, [WorkflowExpression] Func<string> solutionname = null)
        {
            SourceExpression.Validate(solutionid, nameof(solutionid), required: false);
            SourceExpression.Validate(solutionsolutionId, nameof(solutionsolutionId), required: false);
            SourceExpression.Validate(solutionsolutionKey, nameof(solutionsolutionKey), required: false);
            SourceExpression.Validate(solutiondepartmentdepartmentId, nameof(solutiondepartmentdepartmentId), required: false);
            SourceExpression.Validate(solutiondepartmentdepartmentKey, nameof(solutiondepartmentdepartmentKey), required: false);
            SourceExpression.Validate(solutiondepartmentcustomerId, nameof(solutiondepartmentcustomerId), required: false);
            SourceExpression.Validate(solutiondepartmentcustomercustomerId, nameof(solutiondepartmentcustomercustomerId), required: false);
            SourceExpression.Validate(solutiondepartmentcustomercustomerKey, nameof(solutiondepartmentcustomercustomerKey), required: false);
            SourceExpression.Validate(solutiondepartmentcustomername, nameof(solutiondepartmentcustomername), required: false);
            SourceExpression.Validate(solutiondepartmentname, nameof(solutiondepartmentname), required: false);
            SourceExpression.Validate(solutionname, nameof(solutionname), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pasolutions/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = SourceExpressionConverter.ConvertO(solutionid);
                var solution = new JObject();
                var solutionpropCount = 0;
                if (solutionsolutionId != null)
                {
                    solution["solutionId"] = SourceExpressionConverter.ConvertToken(solutionsolutionId);
                    solutionpropCount++;
                }

                if (solutionsolutionKey != null)
                {
                    solution["solutionKey"] = SourceExpressionConverter.ConvertToken(solutionsolutionKey);
                    solutionpropCount++;
                }

                if (solutionname != null)
                {
                    solution["name"] = SourceExpressionConverter.ConvertToken(solutionname);
                    solutionpropCount++;
                }

                if (solutionpropCount > 0)
                {
                    callPayload.Body = solution;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Solution>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Solution> PasolutionsUpdate([WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<int> functionsolutionid = null, [WorkflowExpression] Func<int> solutionsolutionId = null, [WorkflowExpression] Func<string> solutionsolutionKey = null, [WorkflowExpression] Func<int> solutiondepartmentdepartmentId = null, [WorkflowExpression] Func<string> solutiondepartmentdepartmentKey = null, [WorkflowExpression] Func<int> solutiondepartmentcustomerId = null, [WorkflowExpression] Func<int> solutiondepartmentcustomercustomerId = null, [WorkflowExpression] Func<string> solutiondepartmentcustomercustomerKey = null, [WorkflowExpression] Func<string> solutiondepartmentcustomername = null, [WorkflowExpression] Func<string> solutiondepartmentname = null, [WorkflowExpression] Func<string> solutionname = null)
        {
            SourceExpression.Validate(solutionid, nameof(solutionid), required: false);
            SourceExpression.Validate(functionsolutionid, nameof(functionsolutionid), required: false);
            SourceExpression.Validate(solutionsolutionId, nameof(solutionsolutionId), required: false);
            SourceExpression.Validate(solutionsolutionKey, nameof(solutionsolutionKey), required: false);
            SourceExpression.Validate(solutiondepartmentdepartmentId, nameof(solutiondepartmentdepartmentId), required: false);
            SourceExpression.Validate(solutiondepartmentdepartmentKey, nameof(solutiondepartmentdepartmentKey), required: false);
            SourceExpression.Validate(solutiondepartmentcustomerId, nameof(solutiondepartmentcustomerId), required: false);
            SourceExpression.Validate(solutiondepartmentcustomercustomerId, nameof(solutiondepartmentcustomercustomerId), required: false);
            SourceExpression.Validate(solutiondepartmentcustomercustomerKey, nameof(solutiondepartmentcustomercustomerKey), required: false);
            SourceExpression.Validate(solutiondepartmentcustomername, nameof(solutiondepartmentcustomername), required: false);
            SourceExpression.Validate(solutiondepartmentname, nameof(solutiondepartmentname), required: false);
            SourceExpression.Validate(solutionname, nameof(solutionname), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pasolutions/update";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = SourceExpressionConverter.ConvertO(solutionid);
                if (functionsolutionid != null)
                    callPayload.Queries["functionsolutionid"] = SourceExpressionConverter.ConvertO(functionsolutionid);
                var solution = new JObject();
                var solutionpropCount = 0;
                if (solutionsolutionId != null)
                {
                    solution["solutionId"] = SourceExpressionConverter.ConvertToken(solutionsolutionId);
                    solutionpropCount++;
                }

                if (solutionsolutionKey != null)
                {
                    solution["solutionKey"] = SourceExpressionConverter.ConvertToken(solutionsolutionKey);
                    solutionpropCount++;
                }

                if (solutionname != null)
                {
                    solution["name"] = SourceExpressionConverter.ConvertToken(solutionname);
                    solutionpropCount++;
                }

                if (solutionpropCount > 0)
                {
                    callPayload.Body = solution;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Solution>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Document> PadocumentsAdd([WorkflowExpression] Func<int> libraryid, [WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<string> solutionkey = null, [WorkflowExpression] Func<string> documentdocumentKey = null, [WorkflowExpression] Func<string> documentname = null, [WorkflowExpression] Func<int> documentfileSizeBytes = null, [WorkflowExpression] Func<int> documentstatus = null, [WorkflowExpression] Func<PropertyValue[]> documentpropertyValues = null, [WorkflowExpression] Func<string> documenturl = null)
        {
            SourceExpression.Validate(libraryid, nameof(libraryid), required: true);
            SourceExpression.Validate(solutionid, nameof(solutionid), required: false);
            SourceExpression.Validate(solutionkey, nameof(solutionkey), required: false);
            SourceExpression.Validate(documentdocumentKey, nameof(documentdocumentKey), required: false);
            SourceExpression.Validate(documentname, nameof(documentname), required: false);
            SourceExpression.Validate(documentfileSizeBytes, nameof(documentfileSizeBytes), required: false);
            SourceExpression.Validate(documentstatus, nameof(documentstatus), required: false);
            SourceExpression.Validate(documentpropertyValues, nameof(documentpropertyValues), required: false);
            SourceExpression.Validate(documenturl, nameof(documenturl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/padocuments/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryid"] = SourceExpressionConverter.ConvertO(libraryid);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = SourceExpressionConverter.ConvertO(solutionid);
                if (solutionkey != null)
                    callPayload.Queries["solutionkey"] = SourceExpressionConverter.ConvertO(solutionkey);
                var document = new JObject();
                var documentpropCount = 0;
                if (documentdocumentKey != null)
                {
                    document["documentKey"] = SourceExpressionConverter.ConvertToken(documentdocumentKey);
                    documentpropCount++;
                }

                if (documentname != null)
                {
                    document["name"] = SourceExpressionConverter.ConvertToken(documentname);
                    documentpropCount++;
                }

                if (documentfileSizeBytes != null)
                {
                    document["fileSizeBytes"] = SourceExpressionConverter.ConvertToken(documentfileSizeBytes);
                    documentpropCount++;
                }

                if (documentstatus != null)
                {
                    document["status"] = SourceExpressionConverter.ConvertToken(documentstatus);
                    documentpropCount++;
                }

                if (documentpropertyValues != null)
                {
                    document["propertyValues"] = SourceExpressionConverter.ConvertToken(documentpropertyValues);
                    documentpropCount++;
                }

                if (documenturl != null)
                {
                    document["url"] = SourceExpressionConverter.ConvertToken(documenturl);
                    documentpropCount++;
                }

                if (documentpropCount > 0)
                {
                    callPayload.Body = document;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Document>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<DocumentType> PadocumenttypesGet([WorkflowExpression] Func<int> documenttypeid, [WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<string> solutionkey = null)
        {
            SourceExpression.Validate(documenttypeid, nameof(documenttypeid), required: true);
            SourceExpression.Validate(solutionid, nameof(solutionid), required: false);
            SourceExpression.Validate(solutionkey, nameof(solutionkey), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/padocumenttypes/get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documenttypeid"] = SourceExpressionConverter.ConvertO(documenttypeid);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = SourceExpressionConverter.ConvertO(solutionid);
                if (solutionkey != null)
                    callPayload.Queries["solutionkey"] = SourceExpressionConverter.ConvertO(solutionkey);
                return callPayload;
            }

            return new ApiConnectionAction<DocumentType>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<DocumentType[]> PadocumenttypesList([WorkflowExpression] Func<string> solutionkey, [WorkflowExpression] Func<int> solutionid = null)
        {
            SourceExpression.Validate(solutionkey, nameof(solutionkey), required: true);
            SourceExpression.Validate(solutionid, nameof(solutionid), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/padocumenttypes/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["solutionkey"] = SourceExpressionConverter.ConvertO(solutionkey);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = SourceExpressionConverter.ConvertO(solutionid);
                return callPayload;
            }

            return new ApiConnectionAction<DocumentType[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Library> PadocumenttypesAdd([WorkflowExpression] Func<string> solutionkey, [WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<int> librarylibraryId = null, [WorkflowExpression] Func<int> libraryrepositoryId = null, [WorkflowExpression] Func<int> libraryrepositoryrepositoryId = null, [WorkflowExpression] Func<string> libraryrepositoryname = null, [WorkflowExpression] Func<string> libraryrepositorydescription = null, [WorkflowExpression] Func<int> libraryrepositoryrepositoryTypeId = null, [WorkflowExpression] Func<int> libraryrepositoryrepositoryTyperepositoryTypeId = null, [WorkflowExpression] Func<string> libraryrepositoryrepositoryTypename = null, [WorkflowExpression] Func<string> libraryrepositoryrepositoryURI = null, [WorkflowExpression] Func<int> librarydocumentTypeId = null, [WorkflowExpression] Func<int> librarydocumentTypedocumentTypeId = null, [WorkflowExpression] Func<string> librarydocumentTypename = null, [WorkflowExpression] Func<string> librarydocumentTypedescription = null, [WorkflowExpression] Func<string> libraryname = null, [WorkflowExpression] Func<string> librarydescription = null, [WorkflowExpression] Func<bool> libraryocr = null)
        {
            SourceExpression.Validate(solutionkey, nameof(solutionkey), required: true);
            SourceExpression.Validate(solutionid, nameof(solutionid), required: false);
            SourceExpression.Validate(librarylibraryId, nameof(librarylibraryId), required: false);
            SourceExpression.Validate(libraryrepositoryId, nameof(libraryrepositoryId), required: false);
            SourceExpression.Validate(libraryrepositoryrepositoryId, nameof(libraryrepositoryrepositoryId), required: false);
            SourceExpression.Validate(libraryrepositoryname, nameof(libraryrepositoryname), required: false);
            SourceExpression.Validate(libraryrepositorydescription, nameof(libraryrepositorydescription), required: false);
            SourceExpression.Validate(libraryrepositoryrepositoryTypeId, nameof(libraryrepositoryrepositoryTypeId), required: false);
            SourceExpression.Validate(libraryrepositoryrepositoryTyperepositoryTypeId, nameof(libraryrepositoryrepositoryTyperepositoryTypeId), required: false);
            SourceExpression.Validate(libraryrepositoryrepositoryTypename, nameof(libraryrepositoryrepositoryTypename), required: false);
            SourceExpression.Validate(libraryrepositoryrepositoryURI, nameof(libraryrepositoryrepositoryURI), required: false);
            SourceExpression.Validate(librarydocumentTypeId, nameof(librarydocumentTypeId), required: false);
            SourceExpression.Validate(librarydocumentTypedocumentTypeId, nameof(librarydocumentTypedocumentTypeId), required: false);
            SourceExpression.Validate(librarydocumentTypename, nameof(librarydocumentTypename), required: false);
            SourceExpression.Validate(librarydocumentTypedescription, nameof(librarydocumentTypedescription), required: false);
            SourceExpression.Validate(libraryname, nameof(libraryname), required: false);
            SourceExpression.Validate(librarydescription, nameof(librarydescription), required: false);
            SourceExpression.Validate(libraryocr, nameof(libraryocr), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/padocumenttypes/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["solutionkey"] = SourceExpressionConverter.ConvertO(solutionkey);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = SourceExpressionConverter.ConvertO(solutionid);
                var library = new JObject();
                var librarypropCount = 0;
                if (librarylibraryId != null)
                {
                    library["libraryId"] = SourceExpressionConverter.ConvertToken(librarylibraryId);
                    librarypropCount++;
                }

                if (libraryrepositoryId != null)
                {
                    library["repositoryId"] = SourceExpressionConverter.ConvertToken(libraryrepositoryId);
                    librarypropCount++;
                }

                if (librarydocumentTypeId != null)
                {
                    library["documentTypeId"] = SourceExpressionConverter.ConvertToken(librarydocumentTypeId);
                    librarypropCount++;
                }

                var documentTypeObject = new JObject();
                var documentTypeObjectpropCount = 0;
                if (librarydocumentTypedocumentTypeId != null)
                {
                    documentTypeObject["documentTypeId"] = SourceExpressionConverter.ConvertToken(librarydocumentTypedocumentTypeId);
                    documentTypeObjectpropCount++;
                }

                if (librarydocumentTypename != null)
                {
                    documentTypeObject["name"] = SourceExpressionConverter.ConvertToken(librarydocumentTypename);
                    documentTypeObjectpropCount++;
                }

                if (librarydocumentTypedescription != null)
                {
                    documentTypeObject["description"] = SourceExpressionConverter.ConvertToken(librarydocumentTypedescription);
                    documentTypeObjectpropCount++;
                }

                if (documentTypeObjectpropCount > 0)
                {
                    library["documentType"] = documentTypeObject;
                    librarypropCount++;
                }

                if (libraryname != null)
                {
                    library["name"] = SourceExpressionConverter.ConvertToken(libraryname);
                    librarypropCount++;
                }

                if (librarydescription != null)
                {
                    library["description"] = SourceExpressionConverter.ConvertToken(librarydescription);
                    librarypropCount++;
                }

                if (libraryocr != null)
                {
                    library["ocr"] = SourceExpressionConverter.ConvertToken(libraryocr);
                    librarypropCount++;
                }

                if (librarypropCount > 0)
                {
                    callPayload.Body = library;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Library>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<DocumentType> PadocumenttypesUpdate([WorkflowExpression] Func<int> documenttypeid, [WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<string> solutionkey = null, [WorkflowExpression] Func<int> documentTypedocumentTypeId = null, [WorkflowExpression] Func<string> documentTypename = null, [WorkflowExpression] Func<string> documentTypedescription = null)
        {
            SourceExpression.Validate(documenttypeid, nameof(documenttypeid), required: true);
            SourceExpression.Validate(solutionid, nameof(solutionid), required: false);
            SourceExpression.Validate(solutionkey, nameof(solutionkey), required: false);
            SourceExpression.Validate(documentTypedocumentTypeId, nameof(documentTypedocumentTypeId), required: false);
            SourceExpression.Validate(documentTypename, nameof(documentTypename), required: false);
            SourceExpression.Validate(documentTypedescription, nameof(documentTypedescription), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/padocumenttypes/update";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documenttypeid"] = SourceExpressionConverter.ConvertO(documenttypeid);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = SourceExpressionConverter.ConvertO(solutionid);
                if (solutionkey != null)
                    callPayload.Queries["solutionkey"] = SourceExpressionConverter.ConvertO(solutionkey);
                var documentType = new JObject();
                var documentTypepropCount = 0;
                if (documentTypedocumentTypeId != null)
                {
                    documentType["documentTypeId"] = SourceExpressionConverter.ConvertToken(documentTypedocumentTypeId);
                    documentTypepropCount++;
                }

                if (documentTypename != null)
                {
                    documentType["name"] = SourceExpressionConverter.ConvertToken(documentTypename);
                    documentTypepropCount++;
                }

                if (documentTypedescription != null)
                {
                    documentType["description"] = SourceExpressionConverter.ConvertToken(documentTypedescription);
                    documentTypepropCount++;
                }

                if (documentTypepropCount > 0)
                {
                    callPayload.Body = documentType;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DocumentType>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Library> PalibrariesGet([WorkflowExpression] Func<int> libraryid, [WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<string> solutionkey = null)
        {
            SourceExpression.Validate(libraryid, nameof(libraryid), required: true);
            SourceExpression.Validate(solutionid, nameof(solutionid), required: false);
            SourceExpression.Validate(solutionkey, nameof(solutionkey), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/palibraries/get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryid"] = SourceExpressionConverter.ConvertO(libraryid);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = SourceExpressionConverter.ConvertO(solutionid);
                if (solutionkey != null)
                    callPayload.Queries["solutionkey"] = SourceExpressionConverter.ConvertO(solutionkey);
                return callPayload;
            }

            return new ApiConnectionAction<Library>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Library[]> PalibrariesList([WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<string> solutionkey = null)
        {
            SourceExpression.Validate(solutionid, nameof(solutionid), required: false);
            SourceExpression.Validate(solutionkey, nameof(solutionkey), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/palibraries/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = SourceExpressionConverter.ConvertO(solutionid);
                if (solutionkey != null)
                    callPayload.Queries["solutionkey"] = SourceExpressionConverter.ConvertO(solutionkey);
                return callPayload;
            }

            return new ApiConnectionAction<Library[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Library[]> PalibrariesDocumenttypeList([WorkflowExpression] Func<int> documenttypeid, [WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<string> solutionkey = null)
        {
            SourceExpression.Validate(documenttypeid, nameof(documenttypeid), required: true);
            SourceExpression.Validate(solutionid, nameof(solutionid), required: false);
            SourceExpression.Validate(solutionkey, nameof(solutionkey), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/palibraries/documenttype/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documenttypeid"] = SourceExpressionConverter.ConvertO(documenttypeid);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = SourceExpressionConverter.ConvertO(solutionid);
                if (solutionkey != null)
                    callPayload.Queries["solutionkey"] = SourceExpressionConverter.ConvertO(solutionkey);
                return callPayload;
            }

            return new ApiConnectionAction<Library[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Library> PalibrariesUpdate([WorkflowExpression] Func<int> libraryid, [WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<string> solutionkey = null, [WorkflowExpression] Func<int> librarylibraryId = null, [WorkflowExpression] Func<int> libraryrepositoryId = null, [WorkflowExpression] Func<int> libraryrepositoryrepositoryId = null, [WorkflowExpression] Func<string> libraryrepositoryname = null, [WorkflowExpression] Func<string> libraryrepositorydescription = null, [WorkflowExpression] Func<int> libraryrepositoryrepositoryTypeId = null, [WorkflowExpression] Func<int> libraryrepositoryrepositoryTyperepositoryTypeId = null, [WorkflowExpression] Func<string> libraryrepositoryrepositoryTypename = null, [WorkflowExpression] Func<string> libraryrepositoryrepositoryURI = null, [WorkflowExpression] Func<int> librarydocumentTypeId = null, [WorkflowExpression] Func<int> librarydocumentTypedocumentTypeId = null, [WorkflowExpression] Func<string> librarydocumentTypename = null, [WorkflowExpression] Func<string> librarydocumentTypedescription = null, [WorkflowExpression] Func<string> libraryname = null, [WorkflowExpression] Func<string> librarydescription = null, [WorkflowExpression] Func<bool> libraryocr = null)
        {
            SourceExpression.Validate(libraryid, nameof(libraryid), required: true);
            SourceExpression.Validate(solutionid, nameof(solutionid), required: false);
            SourceExpression.Validate(solutionkey, nameof(solutionkey), required: false);
            SourceExpression.Validate(librarylibraryId, nameof(librarylibraryId), required: false);
            SourceExpression.Validate(libraryrepositoryId, nameof(libraryrepositoryId), required: false);
            SourceExpression.Validate(libraryrepositoryrepositoryId, nameof(libraryrepositoryrepositoryId), required: false);
            SourceExpression.Validate(libraryrepositoryname, nameof(libraryrepositoryname), required: false);
            SourceExpression.Validate(libraryrepositorydescription, nameof(libraryrepositorydescription), required: false);
            SourceExpression.Validate(libraryrepositoryrepositoryTypeId, nameof(libraryrepositoryrepositoryTypeId), required: false);
            SourceExpression.Validate(libraryrepositoryrepositoryTyperepositoryTypeId, nameof(libraryrepositoryrepositoryTyperepositoryTypeId), required: false);
            SourceExpression.Validate(libraryrepositoryrepositoryTypename, nameof(libraryrepositoryrepositoryTypename), required: false);
            SourceExpression.Validate(libraryrepositoryrepositoryURI, nameof(libraryrepositoryrepositoryURI), required: false);
            SourceExpression.Validate(librarydocumentTypeId, nameof(librarydocumentTypeId), required: false);
            SourceExpression.Validate(librarydocumentTypedocumentTypeId, nameof(librarydocumentTypedocumentTypeId), required: false);
            SourceExpression.Validate(librarydocumentTypename, nameof(librarydocumentTypename), required: false);
            SourceExpression.Validate(librarydocumentTypedescription, nameof(librarydocumentTypedescription), required: false);
            SourceExpression.Validate(libraryname, nameof(libraryname), required: false);
            SourceExpression.Validate(librarydescription, nameof(librarydescription), required: false);
            SourceExpression.Validate(libraryocr, nameof(libraryocr), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/palibraries/update";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryid"] = SourceExpressionConverter.ConvertO(libraryid);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = SourceExpressionConverter.ConvertO(solutionid);
                if (solutionkey != null)
                    callPayload.Queries["solutionkey"] = SourceExpressionConverter.ConvertO(solutionkey);
                var library = new JObject();
                var librarypropCount = 0;
                if (librarylibraryId != null)
                {
                    library["libraryId"] = SourceExpressionConverter.ConvertToken(librarylibraryId);
                    librarypropCount++;
                }

                if (libraryrepositoryId != null)
                {
                    library["repositoryId"] = SourceExpressionConverter.ConvertToken(libraryrepositoryId);
                    librarypropCount++;
                }

                if (librarydocumentTypeId != null)
                {
                    library["documentTypeId"] = SourceExpressionConverter.ConvertToken(librarydocumentTypeId);
                    librarypropCount++;
                }

                var documentTypeObject = new JObject();
                var documentTypeObjectpropCount = 0;
                if (librarydocumentTypedocumentTypeId != null)
                {
                    documentTypeObject["documentTypeId"] = SourceExpressionConverter.ConvertToken(librarydocumentTypedocumentTypeId);
                    documentTypeObjectpropCount++;
                }

                if (librarydocumentTypename != null)
                {
                    documentTypeObject["name"] = SourceExpressionConverter.ConvertToken(librarydocumentTypename);
                    documentTypeObjectpropCount++;
                }

                if (librarydocumentTypedescription != null)
                {
                    documentTypeObject["description"] = SourceExpressionConverter.ConvertToken(librarydocumentTypedescription);
                    documentTypeObjectpropCount++;
                }

                if (documentTypeObjectpropCount > 0)
                {
                    library["documentType"] = documentTypeObject;
                    librarypropCount++;
                }

                if (libraryname != null)
                {
                    library["name"] = SourceExpressionConverter.ConvertToken(libraryname);
                    librarypropCount++;
                }

                if (librarydescription != null)
                {
                    library["description"] = SourceExpressionConverter.ConvertToken(librarydescription);
                    librarypropCount++;
                }

                if (libraryocr != null)
                {
                    library["ocr"] = SourceExpressionConverter.ConvertToken(libraryocr);
                    librarypropCount++;
                }

                if (librarypropCount > 0)
                {
                    callPayload.Body = library;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Library>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<DataType[]> PadatatypesList([WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<string> solutionkey = null)
        {
            SourceExpression.Validate(solutionid, nameof(solutionid), required: false);
            SourceExpression.Validate(solutionkey, nameof(solutionkey), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/padatatypes/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = SourceExpressionConverter.ConvertO(solutionid);
                if (solutionkey != null)
                    callPayload.Queries["solutionkey"] = SourceExpressionConverter.ConvertO(solutionkey);
                return callPayload;
            }

            return new ApiConnectionAction<DataType[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<string> PadocumentsLoadfile([WorkflowExpression] Func<string> documentkey, [WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<string> solutionkey = null)
        {
            SourceExpression.Validate(documentkey, nameof(documentkey), required: true);
            SourceExpression.Validate(solutionid, nameof(solutionid), required: false);
            SourceExpression.Validate(solutionkey, nameof(solutionkey), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/padocuments/loadfile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentkey"] = SourceExpressionConverter.ConvertO(documentkey);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = SourceExpressionConverter.ConvertO(solutionid);
                if (solutionkey != null)
                    callPayload.Queries["solutionkey"] = SourceExpressionConverter.ConvertO(solutionkey);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<PropertyValue[]> PapropertyvaluesGet([WorkflowExpression] Func<string> documentkey, [WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<string> solutionkey = null)
        {
            SourceExpression.Validate(documentkey, nameof(documentkey), required: true);
            SourceExpression.Validate(solutionid, nameof(solutionid), required: false);
            SourceExpression.Validate(solutionkey, nameof(solutionkey), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/papropertyvalues/get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentkey"] = SourceExpressionConverter.ConvertO(documentkey);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = SourceExpressionConverter.ConvertO(solutionid);
                if (solutionkey != null)
                    callPayload.Queries["solutionkey"] = SourceExpressionConverter.ConvertO(solutionkey);
                return callPayload;
            }

            return new ApiConnectionAction<PropertyValue[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<PropertyValue[]> PapropertyvaluesUpdate([WorkflowExpression] Func<string> documentkey, [WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<string> solutionkey = null, [WorkflowExpression] Func<PropertyValue[]> propertyValueArray = null)
        {
            SourceExpression.Validate(documentkey, nameof(documentkey), required: true);
            SourceExpression.Validate(solutionid, nameof(solutionid), required: false);
            SourceExpression.Validate(solutionkey, nameof(solutionkey), required: false);
            SourceExpression.Validate(propertyValueArray, nameof(propertyValueArray), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/papropertyvalues/update";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentkey"] = SourceExpressionConverter.ConvertO(documentkey);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = SourceExpressionConverter.ConvertO(solutionid);
                if (solutionkey != null)
                    callPayload.Queries["solutionkey"] = SourceExpressionConverter.ConvertO(solutionkey);
                callPayload.Body = SourceExpressionConverter.ConvertToken(propertyValueArray);
                return callPayload;
            }

            return new ApiConnectionAction<PropertyValue[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<DocumentProperty[]> PadocumentpropertiesList([WorkflowExpression] Func<int> documenttypeid, [WorkflowExpression] Func<int> solutionid = null, [WorkflowExpression] Func<string> solutionkey = null)
        {
            SourceExpression.Validate(documenttypeid, nameof(documenttypeid), required: true);
            SourceExpression.Validate(solutionid, nameof(solutionid), required: false);
            SourceExpression.Validate(solutionkey, nameof(solutionkey), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/padocumentproperties-list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documenttypeid"] = SourceExpressionConverter.ConvertO(documenttypeid);
                if (solutionid != null)
                    callPayload.Queries["solutionid"] = SourceExpressionConverter.ConvertO(solutionid);
                if (solutionkey != null)
                    callPayload.Queries["solutionkey"] = SourceExpressionConverter.ConvertO(solutionkey);
                return callPayload;
            }

            return new ApiConnectionAction<DocumentProperty[]>(BuildSourceInput);
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