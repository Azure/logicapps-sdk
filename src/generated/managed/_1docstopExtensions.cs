//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors._1docstop
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class _1docstopActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Library, ApiConnectionActionConfiguration> PalibrariesAdd(Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null, Expression<Func<LibraryInput>> library = null)
        {
            var __workflow_solutionid = WorkflowExpression.Compile(solutionid, nameof(solutionid), required: false);
            var __workflow_solutionkey = WorkflowExpression.Compile(solutionkey, nameof(solutionkey), required: false);
            var __workflow_library = WorkflowExpression.Compile(library, nameof(library), required: false);
            return new DeferredBodyAction<Library, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/palibraries/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                if (__workflow_solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(__workflow_solutionkey);
                if (__workflow_library != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_library);
                return new ApiConnectionAction<Library>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Solution, ApiConnectionActionConfiguration> PasolutionsGet(Expression<Func<string>> solutionkey, Expression<Func<int>> solutionid = null)
        {
            var __workflow_solutionkey = WorkflowExpression.Compile(solutionkey, nameof(solutionkey), required: true);
            var __workflow_solutionid = WorkflowExpression.Compile(solutionid, nameof(solutionid), required: false);
            return new DeferredBodyAction<Solution, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<Solution[], ApiConnectionActionConfiguration> PasolutionsList(Expression<Func<int>> solutionid = null)
        {
            var __workflow_solutionid = WorkflowExpression.Compile(solutionid, nameof(solutionid), required: false);
            return new DeferredBodyAction<Solution[], ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<Solution[], ApiConnectionActionConfiguration> PasolutionsDepartmentList(Expression<Func<string>> departmentkey, Expression<Func<int>> solutionid = null)
        {
            var __workflow_departmentkey = WorkflowExpression.Compile(departmentkey, nameof(departmentkey), required: true);
            var __workflow_solutionid = WorkflowExpression.Compile(solutionid, nameof(solutionid), required: false);
            return new DeferredBodyAction<Solution[], ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<Solution, ApiConnectionActionConfiguration> PasolutionsAdd(Expression<Func<int>> solutionid = null, Expression<Func<SolutionInput>> solution = null)
        {
            var __workflow_solutionid = WorkflowExpression.Compile(solutionid, nameof(solutionid), required: false);
            var __workflow_solution = WorkflowExpression.Compile(solution, nameof(solution), required: false);
            return new DeferredBodyAction<Solution, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pasolutions/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                if (__workflow_solution != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_solution);
                return new ApiConnectionAction<Solution>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Solution, ApiConnectionActionConfiguration> PasolutionsUpdate(Expression<Func<int>> solutionid = null, Expression<Func<int>> functionsolutionid = null, Expression<Func<SolutionInput>> solution = null)
        {
            var __workflow_solutionid = WorkflowExpression.Compile(solutionid, nameof(solutionid), required: false);
            var __workflow_functionsolutionid = WorkflowExpression.Compile(functionsolutionid, nameof(functionsolutionid), required: false);
            var __workflow_solution = WorkflowExpression.Compile(solution, nameof(solution), required: false);
            return new DeferredBodyAction<Solution, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pasolutions/update";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                if (__workflow_functionsolutionid != null)
                    callPayload.Queries["functionsolutionid"] = ExpressionConverter.Convert(__workflow_functionsolutionid);
                if (__workflow_solution != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_solution);
                return new ApiConnectionAction<Solution>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Document, ApiConnectionActionConfiguration> PadocumentsAdd(Expression<Func<int>> libraryid, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null, Expression<Func<DocumentInput>> document = null)
        {
            var __workflow_libraryid = WorkflowExpression.Compile(libraryid, nameof(libraryid), required: true);
            var __workflow_solutionid = WorkflowExpression.Compile(solutionid, nameof(solutionid), required: false);
            var __workflow_solutionkey = WorkflowExpression.Compile(solutionkey, nameof(solutionkey), required: false);
            var __workflow_document = WorkflowExpression.Compile(document, nameof(document), required: false);
            return new DeferredBodyAction<Document, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/padocuments/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryid"] = ExpressionConverter.Convert(__workflow_libraryid);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                if (__workflow_solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(__workflow_solutionkey);
                if (__workflow_document != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_document);
                return new ApiConnectionAction<Document>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<PadocumentpropertiesListDocumentTypeResponse, ApiConnectionActionConfiguration> PadocumenttypesGet(Expression<Func<int>> documenttypeid, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null)
        {
            var __workflow_documenttypeid = WorkflowExpression.Compile(documenttypeid, nameof(documenttypeid), required: true);
            var __workflow_solutionid = WorkflowExpression.Compile(solutionid, nameof(solutionid), required: false);
            var __workflow_solutionkey = WorkflowExpression.Compile(solutionkey, nameof(solutionkey), required: false);
            return new DeferredBodyAction<PadocumentpropertiesListDocumentTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/padocumenttypes/get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documenttypeid"] = ExpressionConverter.Convert(__workflow_documenttypeid);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                if (__workflow_solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(__workflow_solutionkey);
                return new ApiConnectionAction<PadocumentpropertiesListDocumentTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<PadocumentpropertiesListDocumentTypeResponse[], ApiConnectionActionConfiguration> PadocumenttypesList(Expression<Func<string>> solutionkey, Expression<Func<int>> solutionid = null)
        {
            var __workflow_solutionkey = WorkflowExpression.Compile(solutionkey, nameof(solutionkey), required: true);
            var __workflow_solutionid = WorkflowExpression.Compile(solutionid, nameof(solutionid), required: false);
            return new DeferredBodyAction<PadocumentpropertiesListDocumentTypeResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/padocumenttypes/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(__workflow_solutionkey);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                return new ApiConnectionAction<PadocumentpropertiesListDocumentTypeResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Library, ApiConnectionActionConfiguration> PadocumenttypesAdd(Expression<Func<string>> solutionkey, Expression<Func<int>> solutionid = null, Expression<Func<LibraryInput>> library = null)
        {
            var __workflow_solutionkey = WorkflowExpression.Compile(solutionkey, nameof(solutionkey), required: true);
            var __workflow_solutionid = WorkflowExpression.Compile(solutionid, nameof(solutionid), required: false);
            var __workflow_library = WorkflowExpression.Compile(library, nameof(library), required: false);
            return new DeferredBodyAction<Library, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/padocumenttypes/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(__workflow_solutionkey);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                if (__workflow_library != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_library);
                return new ApiConnectionAction<Library>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<PadocumentpropertiesListDocumentTypeResponse, ApiConnectionActionConfiguration> PadocumenttypesUpdate(Expression<Func<int>> documenttypeid, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null, Expression<Func<DocumentTypeInput>> documentType = null)
        {
            var __workflow_documenttypeid = WorkflowExpression.Compile(documenttypeid, nameof(documenttypeid), required: true);
            var __workflow_solutionid = WorkflowExpression.Compile(solutionid, nameof(solutionid), required: false);
            var __workflow_solutionkey = WorkflowExpression.Compile(solutionkey, nameof(solutionkey), required: false);
            var __workflow_documentType = WorkflowExpression.Compile(documentType, nameof(documentType), required: false);
            return new DeferredBodyAction<PadocumentpropertiesListDocumentTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/padocumenttypes/update";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documenttypeid"] = ExpressionConverter.Convert(__workflow_documenttypeid);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                if (__workflow_solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(__workflow_solutionkey);
                if (__workflow_documentType != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_documentType);
                return new ApiConnectionAction<PadocumentpropertiesListDocumentTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<Library, ApiConnectionActionConfiguration> PalibrariesGet(Expression<Func<int>> libraryid, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null)
        {
            var __workflow_libraryid = WorkflowExpression.Compile(libraryid, nameof(libraryid), required: true);
            var __workflow_solutionid = WorkflowExpression.Compile(solutionid, nameof(solutionid), required: false);
            var __workflow_solutionkey = WorkflowExpression.Compile(solutionkey, nameof(solutionkey), required: false);
            return new DeferredBodyAction<Library, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<Library[], ApiConnectionActionConfiguration> PalibrariesList(Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null)
        {
            var __workflow_solutionid = WorkflowExpression.Compile(solutionid, nameof(solutionid), required: false);
            var __workflow_solutionkey = WorkflowExpression.Compile(solutionkey, nameof(solutionkey), required: false);
            return new DeferredBodyAction<Library[], ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<Library[], ApiConnectionActionConfiguration> PalibrariesDocumenttypeList(Expression<Func<int>> documenttypeid, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null)
        {
            var __workflow_documenttypeid = WorkflowExpression.Compile(documenttypeid, nameof(documenttypeid), required: true);
            var __workflow_solutionid = WorkflowExpression.Compile(solutionid, nameof(solutionid), required: false);
            var __workflow_solutionkey = WorkflowExpression.Compile(solutionkey, nameof(solutionkey), required: false);
            return new DeferredBodyAction<Library[], ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<Library, ApiConnectionActionConfiguration> PalibrariesUpdate(Expression<Func<int>> libraryid, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null, Expression<Func<LibraryInput>> library = null)
        {
            var __workflow_libraryid = WorkflowExpression.Compile(libraryid, nameof(libraryid), required: true);
            var __workflow_solutionid = WorkflowExpression.Compile(solutionid, nameof(solutionid), required: false);
            var __workflow_solutionkey = WorkflowExpression.Compile(solutionkey, nameof(solutionkey), required: false);
            var __workflow_library = WorkflowExpression.Compile(library, nameof(library), required: false);
            return new DeferredBodyAction<Library, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/palibraries/update";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryid"] = ExpressionConverter.Convert(__workflow_libraryid);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                if (__workflow_solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(__workflow_solutionkey);
                if (__workflow_library != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_library);
                return new ApiConnectionAction<Library>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<PadatatypesListDataTypeResponse[], ApiConnectionActionConfiguration> PadatatypesList(Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null)
        {
            var __workflow_solutionid = WorkflowExpression.Compile(solutionid, nameof(solutionid), required: false);
            var __workflow_solutionkey = WorkflowExpression.Compile(solutionkey, nameof(solutionkey), required: false);
            return new DeferredBodyAction<PadatatypesListDataTypeResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/padatatypes/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                if (__workflow_solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(__workflow_solutionkey);
                return new ApiConnectionAction<PadatatypesListDataTypeResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PadocumentsLoadfile(Expression<Func<string>> documentkey, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null)
        {
            var __workflow_documentkey = WorkflowExpression.Compile(documentkey, nameof(documentkey), required: true);
            var __workflow_solutionid = WorkflowExpression.Compile(solutionid, nameof(solutionid), required: false);
            var __workflow_solutionkey = WorkflowExpression.Compile(solutionkey, nameof(solutionkey), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<PadocumentsAddPropertyValueResponse[], ApiConnectionActionConfiguration> PapropertyvaluesGet(Expression<Func<string>> documentkey, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null)
        {
            var __workflow_documentkey = WorkflowExpression.Compile(documentkey, nameof(documentkey), required: true);
            var __workflow_solutionid = WorkflowExpression.Compile(solutionid, nameof(solutionid), required: false);
            var __workflow_solutionkey = WorkflowExpression.Compile(solutionkey, nameof(solutionkey), required: false);
            return new DeferredBodyAction<PadocumentsAddPropertyValueResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/papropertyvalues/get";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentkey"] = ExpressionConverter.Convert(__workflow_documentkey);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                if (__workflow_solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(__workflow_solutionkey);
                return new ApiConnectionAction<PadocumentsAddPropertyValueResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<PadocumentsAddPropertyValueResponse[], ApiConnectionActionConfiguration> PapropertyvaluesUpdate(Expression<Func<string>> documentkey, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null, Expression<Func<PadocumentsAddPropertyValue[]>> propertyValueArray = null)
        {
            var __workflow_documentkey = WorkflowExpression.Compile(documentkey, nameof(documentkey), required: true);
            var __workflow_solutionid = WorkflowExpression.Compile(solutionid, nameof(solutionid), required: false);
            var __workflow_solutionkey = WorkflowExpression.Compile(solutionkey, nameof(solutionkey), required: false);
            var __workflow_propertyValueArray = WorkflowExpression.Compile(propertyValueArray, nameof(propertyValueArray), required: false);
            return new DeferredBodyAction<PadocumentsAddPropertyValueResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/papropertyvalues/update";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentkey"] = ExpressionConverter.Convert(__workflow_documentkey);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                if (__workflow_solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(__workflow_solutionkey);
                if (__workflow_propertyValueArray != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_propertyValueArray);
                return new ApiConnectionAction<PadocumentsAddPropertyValueResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1docstop")]
        public IBodyWorkflowAction<PadocumentpropertiesListDocumentPropertyResponse[], ApiConnectionActionConfiguration> PadocumentpropertiesList(Expression<Func<int>> documenttypeid, Expression<Func<int>> solutionid = null, Expression<Func<string>> solutionkey = null)
        {
            var __workflow_documenttypeid = WorkflowExpression.Compile(documenttypeid, nameof(documenttypeid), required: true);
            var __workflow_solutionid = WorkflowExpression.Compile(solutionid, nameof(solutionid), required: false);
            var __workflow_solutionkey = WorkflowExpression.Compile(solutionkey, nameof(solutionkey), required: false);
            return new DeferredBodyAction<PadocumentpropertiesListDocumentPropertyResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/padocumentproperties-list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documenttypeid"] = ExpressionConverter.Convert(__workflow_documenttypeid);
                if (__workflow_solutionid != null)
                    callPayload.Queries["solutionid"] = ExpressionConverter.Convert(__workflow_solutionid);
                if (__workflow_solutionkey != null)
                    callPayload.Queries["solutionkey"] = ExpressionConverter.Convert(__workflow_solutionkey);
                return new ApiConnectionAction<PadocumentpropertiesListDocumentPropertyResponse[]>(callPayload);
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
        public PadocumenttypesAddRepositoryResponse Repository { get; set; }

        [JsonProperty("documentTypeId")]
        public int DocumentTypeId { get; set; }

        [JsonProperty("documentType")]
        public PadocumentpropertiesListDocumentTypeResponse DocumentType { get; set; }

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

    public class PadocumenttypesAddRepositoryResponse
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
        public PadocumenttypesAddRepositoryTypeResponse RepositoryType { get; set; }

        [JsonProperty("repositoryURI")]
        public string RepositoryURI { get; set; }
    }

    public class PadocumenttypesAddRepositoryTypeResponse
    {
        [JsonProperty("repositoryTypeId")]
        public int RepositoryTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PadocumentpropertiesListDocumentTypeResponse
    {
        [JsonProperty("documentTypeId")]
        public int DocumentTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class LibraryInput
    {
        [JsonProperty("libraryId")]
        public int? LibraryId { get; set; }

        [JsonProperty("repositoryId")]
        public int? RepositoryId { get; set; }

        [JsonProperty("documentTypeId")]
        public int? DocumentTypeId { get; set; }

        [JsonProperty("documentType")]
        public PadocumentsAddDocumentType DocumentType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ocr")]
        public bool? Ocr { get; set; }
    }

    public class PadocumentsAddDocumentType
    {
        [JsonProperty("documentTypeId")]
        public int? DocumentTypeId { get; set; }

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
        public PasolutionsAddDepartmentResponse Department { get; set; }

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

    public class PasolutionsAddDepartmentResponse
    {
        [JsonProperty("departmentId")]
        public int DepartmentId { get; set; }

        [JsonProperty("departmentKey")]
        public string DepartmentKey { get; set; }

        [JsonProperty("customerId")]
        public int CustomerId { get; set; }

        [JsonProperty("customer")]
        public PasolutionsAddCustomerResponse Customer { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PasolutionsAddCustomerResponse
    {
        [JsonProperty("customerId")]
        public int CustomerId { get; set; }

        [JsonProperty("customerKey")]
        public string CustomerKey { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SolutionInput
    {
        [JsonProperty("solutionId")]
        public int? SolutionId { get; set; }

        [JsonProperty("solutionKey")]
        public string SolutionKey { get; set; }

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
        public PadocumentsAddPropertyValueResponse[] PropertyValues { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class PadocumentsAddPropertyValueResponse
    {
        [JsonProperty("documentId")]
        public int DocumentId { get; set; }

        [JsonProperty("documentPropertyId")]
        public int DocumentPropertyId { get; set; }

        [JsonProperty("documentProperty")]
        public PadocumentpropertiesListDocumentPropertyResponse DocumentProperty { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("columnName")]
        public string ColumnName { get; set; }
    }

    public class PadocumentpropertiesListDocumentPropertyResponse
    {
        [JsonProperty("documentPropertyId")]
        public int DocumentPropertyId { get; set; }

        [JsonProperty("documentTypeId")]
        public int DocumentTypeId { get; set; }

        [JsonProperty("documentType")]
        public PadocumentpropertiesListDocumentTypeResponse DocumentType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dataTypeId")]
        public int DataTypeId { get; set; }

        [JsonProperty("dataTypeName")]
        public string DataTypeName { get; set; }

        [JsonProperty("dataType")]
        public PadatatypesListDataTypeResponse DataType { get; set; }

        [JsonProperty("optionSetId")]
        public int OptionSetId { get; set; }

        [JsonProperty("optionSet")]
        public PadocumentpropertiesListOptionSetResponse OptionSet { get; set; }

        [JsonProperty("externalOptionSet")]
        public string ExternalOptionSet { get; set; }

        [JsonProperty("displayFormat")]
        public string DisplayFormat { get; set; }

        [JsonProperty("internalName")]
        public string InternalName { get; set; }
    }

    public class PadatatypesListDataTypeResponse
    {
        [JsonProperty("dataTypeId")]
        public int DataTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PadocumentpropertiesListOptionSetResponse
    {
        [JsonProperty("optionSetId")]
        public int OptionSetId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("optionSetValues")]
        public PadocumentpropertiesListOptionSetValueResponse[] OptionSetValues { get; set; }
    }

    public class PadocumentpropertiesListOptionSetValueResponse
    {
        [JsonProperty("optionSetValueId")]
        public int OptionSetValueId { get; set; }

        [JsonProperty("optionSetId")]
        public int OptionSetId { get; set; }

        [JsonProperty("optionSet")]
        public PadocumentpropertiesListOptionSetResponse OptionSet { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }
    }

    public class DocumentInput
    {
        [JsonProperty("documentKey")]
        public string DocumentKey { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fileSizeBytes")]
        public int? FileSizeBytes { get; set; }

        [JsonProperty("status")]
        public int? Status { get; set; }

        [JsonProperty("propertyValues")]
        public PadocumentsAddPropertyValue[] PropertyValues { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class PadocumentsAddPropertyValue
    {
        [JsonProperty("documentId")]
        public int? DocumentId { get; set; }

        [JsonProperty("documentPropertyId")]
        public int? DocumentPropertyId { get; set; }

        [JsonProperty("documentProperty")]
        public PadocumentsAddDocumentProperty DocumentProperty { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("columnName")]
        public string ColumnName { get; set; }
    }

    public class PadocumentsAddDocumentProperty
    {
        [JsonProperty("documentPropertyId")]
        public int? DocumentPropertyId { get; set; }

        [JsonProperty("documentTypeId")]
        public int? DocumentTypeId { get; set; }

        [JsonProperty("documentType")]
        public PadocumentsAddDocumentType DocumentType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dataTypeId")]
        public int? DataTypeId { get; set; }

        [JsonProperty("dataType")]
        public PadocumentsAddDataType DataType { get; set; }

        [JsonProperty("optionSetId")]
        public int? OptionSetId { get; set; }

        [JsonProperty("externalOptionSet")]
        public string ExternalOptionSet { get; set; }

        [JsonProperty("displayFormat")]
        public string DisplayFormat { get; set; }

        [JsonProperty("internalName")]
        public string InternalName { get; set; }
    }

    public class PadocumentsAddDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class DocumentTypeInput
    {
        [JsonProperty("documentTypeId")]
        public int? DocumentTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
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