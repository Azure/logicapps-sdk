//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Elfsquad
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ElfsquadActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<CategoriesCategoryResponse[], ApiConnectionActionConfiguration> CategoriesGet()
        {
            return new DeferredBodyAction<CategoriesCategoryResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CategoriesCategoryResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<CategoriesCategoryResponse, ApiConnectionActionConfiguration> Categories(Expression<Func<CategoriesEntityInput>> entity = null)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: false);
            return new DeferredBodyAction<CategoriesCategoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/categories";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_entity != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_entity);
                return new ApiConnectionAction<CategoriesCategoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<CategoriesCategoryResponse, ApiConnectionActionConfiguration> CategoriesUpdate(Expression<Func<CategoriesEntityInput>> entity = null)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: false);
            return new DeferredBodyAction<CategoriesCategoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/categories";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_entity != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_entity);
                return new ApiConnectionAction<CategoriesCategoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<CategoriesCategoryResponse[], ApiConnectionActionConfiguration> CategoriesSubcategoriesGetById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<CategoriesCategoryResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/categories/subcategories/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CategoriesCategoryResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CategoriesDeleteById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/categories/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<CategoriesCategoryResponse, ApiConnectionActionConfiguration> CategoriesGetById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<CategoriesCategoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/categories/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CategoriesCategoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<CategoriesCategoryResponse, ApiConnectionActionConfiguration> CategoriesPatch(Expression<Func<string>> id, Expression<Func<Operation[]>> patchDocument = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_patchDocument = WorkflowExpression.Compile(patchDocument, nameof(patchDocument), required: false);
            return new DeferredBodyAction<CategoriesCategoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/categories/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_patchDocument != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_patchDocument);
                return new ApiConnectionAction<CategoriesCategoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<CrmAccount[], ApiConnectionActionConfiguration> CrmAccountsGet()
        {
            return new DeferredBodyAction<CrmAccount[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/crmaccounts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CrmAccount[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<CrmAccount, ApiConnectionActionConfiguration> CrmAccounts(Expression<Func<CrmAccountsEntityInput>> entity = null)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: false);
            return new DeferredBodyAction<CrmAccount, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/crmaccounts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_entity != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_entity);
                return new ApiConnectionAction<CrmAccount>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<CrmAccount, ApiConnectionActionConfiguration> CrmAccountsUpdate(Expression<Func<CrmAccountsEntityInput>> entity = null)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: false);
            return new DeferredBodyAction<CrmAccount, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/crmaccounts";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_entity != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_entity);
                return new ApiConnectionAction<CrmAccount>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CrmAccountsDeleteById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/crmaccounts/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<CrmAccount, ApiConnectionActionConfiguration> CrmAccountsGetById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<CrmAccount, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/crmaccounts/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CrmAccount>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<CrmAccount, ApiConnectionActionConfiguration> CrmAccountsPatch(Expression<Func<string>> id, Expression<Func<Operation[]>> patchDocument = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_patchDocument = WorkflowExpression.Compile(patchDocument, nameof(patchDocument), required: false);
            return new DeferredBodyAction<CrmAccount, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/crmaccounts/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_patchDocument != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_patchDocument);
                return new ApiConnectionAction<CrmAccount>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<CrmAccountsCrmContactResponse[], ApiConnectionActionConfiguration> CrmContactsGet()
        {
            return new DeferredBodyAction<CrmAccountsCrmContactResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/crmcontacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CrmAccountsCrmContactResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<CrmAccountsCrmContactResponse, ApiConnectionActionConfiguration> CrmContacts(Expression<Func<CrmContactsEntityInput>> entity = null)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: false);
            return new DeferredBodyAction<CrmAccountsCrmContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/crmcontacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_entity != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_entity);
                return new ApiConnectionAction<CrmAccountsCrmContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<CrmAccountsCrmContactResponse, ApiConnectionActionConfiguration> CrmContactsUpdate(Expression<Func<CrmContactsEntityInput>> entity = null)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: false);
            return new DeferredBodyAction<CrmAccountsCrmContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/crmcontacts";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_entity != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_entity);
                return new ApiConnectionAction<CrmAccountsCrmContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CrmContactsDeleteById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/crmcontacts/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<CrmAccountsCrmContactResponse, ApiConnectionActionConfiguration> CrmContactsGetById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<CrmAccountsCrmContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/crmcontacts/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CrmAccountsCrmContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<CrmAccountsCrmContactResponse, ApiConnectionActionConfiguration> CrmContactsPatch(Expression<Func<string>> id, Expression<Func<Operation[]>> patchDocument = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_patchDocument = WorkflowExpression.Compile(patchDocument, nameof(patchDocument), required: false);
            return new DeferredBodyAction<CrmAccountsCrmContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/crmcontacts/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_patchDocument != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_patchDocument);
                return new ApiConnectionAction<CrmAccountsCrmContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<FeatureHasFeatureProperty[], ApiConnectionActionConfiguration> FeatureHasPropertiesGet()
        {
            return new DeferredBodyAction<FeatureHasFeatureProperty[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/featurehasfeatureproperties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FeatureHasFeatureProperty[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<FeatureHasFeatureProperty, ApiConnectionActionConfiguration> FeatureHasProperties(Expression<Func<FeatureHasPropertiesEntityInput>> entity = null)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: false);
            return new DeferredBodyAction<FeatureHasFeatureProperty, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/featurehasfeatureproperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_entity != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_entity);
                return new ApiConnectionAction<FeatureHasFeatureProperty>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<FeatureHasFeatureProperty, ApiConnectionActionConfiguration> FeatureHasPropertiesUpdate(Expression<Func<FeatureHasPropertiesEntityInput>> entity = null)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: false);
            return new DeferredBodyAction<FeatureHasFeatureProperty, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/featurehasfeatureproperties";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_entity != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_entity);
                return new ApiConnectionAction<FeatureHasFeatureProperty>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FeatureHasPropertiesDelete(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/featurehasfeatureproperties/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<FeatureHasFeatureProperty, ApiConnectionActionConfiguration> FeatureHasPropertiesPatch(Expression<Func<string>> id, Expression<Func<Operation[]>> patchDocument = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_patchDocument = WorkflowExpression.Compile(patchDocument, nameof(patchDocument), required: false);
            return new DeferredBodyAction<FeatureHasFeatureProperty, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/featurehasfeatureproperties/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_patchDocument != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_patchDocument);
                return new ApiConnectionAction<FeatureHasFeatureProperty>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<FeatureModel[], ApiConnectionActionConfiguration> FeatureModelsGet()
        {
            return new DeferredBodyAction<FeatureModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/featuremodels";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FeatureModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<FeatureModel, ApiConnectionActionConfiguration> FeatureModels(Expression<Func<FeatureModelsEntityInput>> entity = null)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: false);
            return new DeferredBodyAction<FeatureModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/featuremodels";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_entity != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_entity);
                return new ApiConnectionAction<FeatureModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<FeatureModel, ApiConnectionActionConfiguration> FeatureModelsUpdate(Expression<Func<FeatureModelsEntityInput>> entity = null)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: false);
            return new DeferredBodyAction<FeatureModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/featuremodels";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_entity != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_entity);
                return new ApiConnectionAction<FeatureModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FeatureModelsDeleteById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/featuremodels/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<FeatureModel, ApiConnectionActionConfiguration> FeatureModelsGetById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<FeatureModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/featuremodels/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FeatureModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<FeatureModel, ApiConnectionActionConfiguration> FeatureModelsPatch(Expression<Func<string>> id, Expression<Func<Operation[]>> patchDocument = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_patchDocument = WorkflowExpression.Compile(patchDocument, nameof(patchDocument), required: false);
            return new DeferredBodyAction<FeatureModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/featuremodels/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_patchDocument != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_patchDocument);
                return new ApiConnectionAction<FeatureModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<FeatureProperty[], ApiConnectionActionConfiguration> FeaturesPropertiesGet()
        {
            return new DeferredBodyAction<FeatureProperty[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/featureproperties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FeatureProperty[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<FeatureProperty, ApiConnectionActionConfiguration> FeaturesProperties(Expression<Func<FeaturesPropertiesEntityInput>> entity = null)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: false);
            return new DeferredBodyAction<FeatureProperty, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/featureproperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_entity != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_entity);
                return new ApiConnectionAction<FeatureProperty>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<FeatureProperty, ApiConnectionActionConfiguration> FeaturesPropertiesUpdate(Expression<Func<FeaturesPropertiesEntityInput>> entity = null)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: false);
            return new DeferredBodyAction<FeatureProperty, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/featureproperties";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_entity != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_entity);
                return new ApiConnectionAction<FeatureProperty>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FeaturesPropertiesDelete(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/featureproperties/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<FeatureProperty, ApiConnectionActionConfiguration> FeaturesPropertiesGetById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<FeatureProperty, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/featureproperties/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FeatureProperty>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<FeatureProperty, ApiConnectionActionConfiguration> FeaturesPropertiesPatch(Expression<Func<string>> id, Expression<Func<Operation[]>> patchDocument = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_patchDocument = WorkflowExpression.Compile(patchDocument, nameof(patchDocument), required: false);
            return new DeferredBodyAction<FeatureProperty, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/featureproperties/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_patchDocument != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_patchDocument);
                return new ApiConnectionAction<FeatureProperty>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<FeaturesFeatureResponse[], ApiConnectionActionConfiguration> FeaturesGet()
        {
            return new DeferredBodyAction<FeaturesFeatureResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/features";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FeaturesFeatureResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<FeaturesFeatureResponse, ApiConnectionActionConfiguration> Features(Expression<Func<FeatureInput>> feature = null)
        {
            var __workflow_feature = WorkflowExpression.Compile(feature, nameof(feature), required: false);
            return new DeferredBodyAction<FeaturesFeatureResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/features";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_feature != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_feature);
                return new ApiConnectionAction<FeaturesFeatureResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<FeaturesFeatureResponse, ApiConnectionActionConfiguration> FeaturesUpdate(Expression<Func<FeatureInput>> feature = null)
        {
            var __workflow_feature = WorkflowExpression.Compile(feature, nameof(feature), required: false);
            return new DeferredBodyAction<FeaturesFeatureResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/features";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_feature != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_feature);
                return new ApiConnectionAction<FeaturesFeatureResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<FeaturesFeatureResponse[], ApiConnectionActionConfiguration> FeaturesCopy(Expression<Func<FeaturesCopyFeature[]>> features = null)
        {
            var __workflow_features = WorkflowExpression.Compile(features, nameof(features), required: false);
            return new DeferredBodyAction<FeaturesFeatureResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/features/copy/bulk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_features != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_features);
                return new ApiConnectionAction<FeaturesFeatureResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FeaturesDeleteById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/features/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<FeaturesFeatureResponse, ApiConnectionActionConfiguration> FeaturesGetById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<FeaturesFeatureResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/features/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FeaturesFeatureResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<FeaturesFeatureResponse, ApiConnectionActionConfiguration> FeaturesPatch(Expression<Func<string>> id, Expression<Func<Operation[]>> patchDocument = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_patchDocument = WorkflowExpression.Compile(patchDocument, nameof(patchDocument), required: false);
            return new DeferredBodyAction<FeaturesFeatureResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/features/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_patchDocument != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_patchDocument);
                return new ApiConnectionAction<FeaturesFeatureResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<bool, ApiConnectionActionConfiguration> NotificationsSend(Expression<Func<NotificationInput>> notification = null)
        {
            var __workflow_notification = WorkflowExpression.Compile(notification, nameof(notification), required: false);
            return new DeferredBodyAction<bool, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/notifications";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_notification != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_notification);
                return new ApiConnectionAction<bool>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<OrganizationSellsFeature[], ApiConnectionActionConfiguration> OrgSellsFeatureGet()
        {
            return new DeferredBodyAction<OrganizationSellsFeature[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/organizationsellsfeatures";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OrganizationSellsFeature[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<OrganizationSellsFeature, ApiConnectionActionConfiguration> OrgSellsFeature(Expression<Func<OrgSellsFeatureEntityInput>> entity = null)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: false);
            return new DeferredBodyAction<OrganizationSellsFeature, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/organizationsellsfeatures";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_entity != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_entity);
                return new ApiConnectionAction<OrganizationSellsFeature>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<OrganizationSellsFeature, ApiConnectionActionConfiguration> OrgSellsFeatureUpdate(Expression<Func<OrgSellsFeatureEntityInput>> entity = null)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: false);
            return new DeferredBodyAction<OrganizationSellsFeature, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/organizationsellsfeatures";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_entity != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_entity);
                return new ApiConnectionAction<OrganizationSellsFeature>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IWorkflowAction<ApiConnectionActionConfiguration> OrgSellsFeatureGetByFeatureId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/organizationsellsfeatures/byfeatureid/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IWorkflowAction<ApiConnectionActionConfiguration> OrgSellsFeatureDelete(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/organizationsellsfeatures/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<OrganizationSellsFeature, ApiConnectionActionConfiguration> OrgSellsFeatureGetById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<OrganizationSellsFeature, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/organizationsellsfeatures/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OrganizationSellsFeature>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<OrganizationSellsFeature, ApiConnectionActionConfiguration> OrgSellsFeaturePatch(Expression<Func<string>> id, Expression<Func<Operation[]>> patchDocument = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_patchDocument = WorkflowExpression.Compile(patchDocument, nameof(patchDocument), required: false);
            return new DeferredBodyAction<OrganizationSellsFeature, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/organizationsellsfeatures/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_patchDocument != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_patchDocument);
                return new ApiConnectionAction<OrganizationSellsFeature>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<QuotationProperty[], ApiConnectionActionConfiguration> QuotationPropertiesGet55()
        {
            return new DeferredBodyAction<QuotationProperty[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/quotationproperties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<QuotationProperty[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<QuotationProperty, ApiConnectionActionConfiguration> QuotationProperties(Expression<Func<QuotationPropertiesEntityInput>> entity = null)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: false);
            return new DeferredBodyAction<QuotationProperty, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/quotationproperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_entity != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_entity);
                return new ApiConnectionAction<QuotationProperty>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<QuotationProperty, ApiConnectionActionConfiguration> QuotationPropertiesUpdate(Expression<Func<QuotationPropertiesEntityInput>> entity = null)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: false);
            return new DeferredBodyAction<QuotationProperty, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/quotationproperties";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_entity != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_entity);
                return new ApiConnectionAction<QuotationProperty>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IWorkflowAction<ApiConnectionActionConfiguration> QuotationPropertiesGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/quotationproperties/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<QuotationProperty, ApiConnectionActionConfiguration> QuotationPropertiesGetById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<QuotationProperty, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/quotationproperties/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<QuotationProperty>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<QuotationProperty, ApiConnectionActionConfiguration> QuotationPropertiesPatch(Expression<Func<string>> id, Expression<Func<Operation[]>> patchDocument = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_patchDocument = WorkflowExpression.Compile(patchDocument, nameof(patchDocument), required: false);
            return new DeferredBodyAction<QuotationProperty, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/quotationproperties/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_patchDocument != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_patchDocument);
                return new ApiConnectionAction<QuotationProperty>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<QuotationPropertiesQuotationPropertyFieldResponse[], ApiConnectionActionConfiguration> QuotationPropertyFieldsGet()
        {
            return new DeferredBodyAction<QuotationPropertiesQuotationPropertyFieldResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/quotationpropertyfields";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<QuotationPropertiesQuotationPropertyFieldResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IWorkflowAction<ApiConnectionActionConfiguration> QuotationPropertyFieldsDelete(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/quotationpropertyfields/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<Quotation[], ApiConnectionActionConfiguration> QuotationsGet()
        {
            return new DeferredBodyAction<Quotation[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/quotations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Quotation[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<Quotation, ApiConnectionActionConfiguration> Quotations(Expression<Func<QuotationsEntityInput>> entity)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            return new DeferredBodyAction<Quotation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/quotations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_entity);
                return new ApiConnectionAction<Quotation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<Quotation, ApiConnectionActionConfiguration> QuotationsUpdate(Expression<Func<QuotationInput>> quotation)
        {
            var __workflow_quotation = WorkflowExpression.Compile(quotation, nameof(quotation), required: true);
            return new DeferredBodyAction<Quotation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/quotations";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_quotation);
                return new ApiConnectionAction<Quotation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<Quotation, ApiConnectionActionConfiguration> QuotationsPatchBulk(Expression<Func<PatchDocumentInput>> patchDocument = null)
        {
            var __workflow_patchDocument = WorkflowExpression.Compile(patchDocument, nameof(patchDocument), required: false);
            return new DeferredBodyAction<Quotation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/quotations/bulk";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_patchDocument != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_patchDocument);
                return new ApiConnectionAction<Quotation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IWorkflowAction<ApiConnectionActionConfiguration> QuotationsDeleteById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/quotations/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<Quotation, ApiConnectionActionConfiguration> QuotationsGetById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Quotation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/quotations/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["include"] = Convert.ToString("Lines");
                return new ApiConnectionAction<Quotation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<Quotation, ApiConnectionActionConfiguration> QuotationsPatch(Expression<Func<string>> id, Expression<Func<Operation[]>> patchDocument = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_patchDocument = WorkflowExpression.Compile(patchDocument, nameof(patchDocument), required: false);
            return new DeferredBodyAction<Quotation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/quotations/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_patchDocument != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_patchDocument);
                return new ApiConnectionAction<Quotation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IWorkflowAction<ApiConnectionActionConfiguration> QuotationsAddConfigurations(Expression<Func<string>> id, Expression<Func<string[]>> configurationIds = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_configurationIds = WorkflowExpression.Compile(configurationIds, nameof(configurationIds), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/quotations/{0}/addconfigurations", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_configurationIds != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_configurationIds);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<Quotation, ApiConnectionActionConfiguration> QuotationsCopy(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Quotation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/quotations/{0}/copy", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Quotation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IWorkflowAction<ApiConnectionActionConfiguration> QuotationsGetPdf(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/quotations/{0}/pdf", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<Quotation, ApiConnectionActionConfiguration> QuotationsRevise(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Quotation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/quotations/{0}/revise", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Quotation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<Step[], ApiConnectionActionConfiguration> StepsGet()
        {
            return new DeferredBodyAction<Step[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/steps";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Step[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<Step, ApiConnectionActionConfiguration> Steps(Expression<Func<StepsEntityInput>> entity = null)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: false);
            return new DeferredBodyAction<Step, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/steps";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_entity != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_entity);
                return new ApiConnectionAction<Step>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<Step, ApiConnectionActionConfiguration> StepsUpdate(Expression<Func<StepsEntityInput>> entity = null)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: false);
            return new DeferredBodyAction<Step, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/steps";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_entity != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_entity);
                return new ApiConnectionAction<Step>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IWorkflowAction<ApiConnectionActionConfiguration> StepsDeleteById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/steps/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<Step, ApiConnectionActionConfiguration> StepsGetById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Step, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/steps/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Step>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elfsquad")]
        public IBodyWorkflowAction<Step, ApiConnectionActionConfiguration> StepsPatch(Expression<Func<string>> id, Expression<Func<Operation[]>> patchDocument = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_patchDocument = WorkflowExpression.Compile(patchDocument, nameof(patchDocument), required: false);
            return new DeferredBodyAction<Step, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/steps/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_patchDocument != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_patchDocument);
                return new ApiConnectionAction<Step>(callPayload);
            });
        }
    }

    public class ElfsquadTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> WebhooksCustom(Expression<Func<string>> identifier)
        {
            var __workflow_identifier = WorkflowExpression.Compile(identifier, nameof(identifier), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/2/webhooks/custom.{0}", __workflow_identifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new WebHooksSubscriptionInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> WebhooksQuotationAccepted()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/2/webhooks/quotation.accepted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new WebHooksSubscriptionInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> WebhooksQuotationConfigurationAdded()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/2/webhooks/quotation.configurationadded";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new WebHooksSubscriptionInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> WebhooksQuotationDenied()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/2/webhooks/quotation.declined";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new WebHooksSubscriptionInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> WebhooksQuotationRequested()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/2/webhooks/quotation.requested";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new WebHooksSubscriptionInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> WebhooksQuotationRevised()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/2/webhooks/quotation.revised";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new WebHooksSubscriptionInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> WebhooksQuotationSubmitted()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/2/webhooks/quotation.submitted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new WebHooksSubscriptionInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> WebhooksQuotationVerified()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/2/webhooks/quotation.verified";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new WebHooksSubscriptionInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class CategoriesCategoryResponse
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("linkedFeatures")]
        public int LinkedFeatures { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }

        [JsonProperty("texts")]
        public CategoriesCategoryTextResponse[] Texts { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public class CategoriesCategoryTextResponse
    {
        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("languageIso")]
        public string LanguageIso { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CategoriesEntityInput
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("linkedFeatures")]
        public int? LinkedFeatures { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("texts")]
        public CategoriesCategoryText[] Texts { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public class CategoriesCategoryText
    {
        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("languageIso")]
        public string LanguageIso { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Operation
    {
        [JsonProperty("op", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Op { get; set; } = "replace";

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }

    public class CrmAccount
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("cocNumber")]
        public string CocNumber { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("contacts")]
        public CrmAccountsCrmContactResponse[] Contacts { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countryIso")]
        public string CountryIso { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("customerReference")]
        public string CustomerReference { get; set; }

        [JsonProperty("defaultContact")]
        public CrmAccountsCrmContactResponse DefaultContact { get; set; }

        [JsonProperty("defaultContactId")]
        public string DefaultContactId { get; set; }

        [JsonProperty("defaultVatId")]
        public string DefaultVatId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("fullLastName")]
        public string FullLastName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("houseNumber")]
        public string HouseNumber { get; set; }

        [JsonProperty("iban")]
        public string Iban { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("lastNamePrefix")]
        public string LastNamePrefix { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("phone2")]
        public string Phone2 { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("shoeSize")]
        public int ShoeSize { get; set; }

        [JsonProperty("streetName")]
        public string StreetName { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }

        [JsonProperty("type")]
        public CrmAccountTypeType Type { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("vatNumber")]
        public string VatNumber { get; set; }
    }

    public class CrmAccountsCrmContactResponse
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("contactReference")]
        public string ContactReference { get; set; }

        [JsonProperty("countryIso")]
        public string CountryIso { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("crmAccountId")]
        public string CrmAccountId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("fullLastName")]
        public string FullLastName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("houseNumber")]
        public string HouseNumber { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("lastNamePrefix")]
        public string LastNamePrefix { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("phone2")]
        public string Phone2 { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("streetName")]
        public string StreetName { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("useParentAddress")]
        public bool UseParentAddress { get; set; }
    }

    public enum CrmAccountTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2
    }

    public class CrmAccountsEntityInput
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("cocNumber")]
        public string CocNumber { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("contacts")]
        public CrmAccountsCrmContact[] Contacts { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countryIso")]
        public string CountryIso { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("customerReference")]
        public string CustomerReference { get; set; }

        [JsonProperty("defaultContact")]
        public CrmAccountsCrmContact DefaultContact { get; set; }

        [JsonProperty("defaultContactId")]
        public string DefaultContactId { get; set; }

        [JsonProperty("defaultVatId")]
        public string DefaultVatId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("fullLastName")]
        public string FullLastName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("houseNumber")]
        public string HouseNumber { get; set; }

        [JsonProperty("iban")]
        public string Iban { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("lastNamePrefix")]
        public string LastNamePrefix { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("phone2")]
        public string Phone2 { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("shoeSize")]
        public int? ShoeSize { get; set; }

        [JsonProperty("streetName")]
        public string StreetName { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("type")]
        public CrmAccountsEntityInputTypeType? Type { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("vatNumber")]
        public string VatNumber { get; set; }
    }

    public class CrmAccountsCrmContact
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("contactReference")]
        public string ContactReference { get; set; }

        [JsonProperty("countryIso")]
        public string CountryIso { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("crmAccountId")]
        public string CrmAccountId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("fullLastName")]
        public string FullLastName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("houseNumber")]
        public string HouseNumber { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("lastNamePrefix")]
        public string LastNamePrefix { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("phone2")]
        public string Phone2 { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("streetName")]
        public string StreetName { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("useParentAddress")]
        public bool? UseParentAddress { get; set; }
    }

    public enum CrmAccountsEntityInputTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2
    }

    public class CrmContactsEntityInput
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("contactReference")]
        public string ContactReference { get; set; }

        [JsonProperty("countryIso")]
        public string CountryIso { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("crmAccountId")]
        public string CrmAccountId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("fullLastName")]
        public string FullLastName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("houseNumber")]
        public string HouseNumber { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("lastNamePrefix")]
        public string LastNamePrefix { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("phone2")]
        public string Phone2 { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("streetName")]
        public string StreetName { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("useParentAddress")]
        public bool? UseParentAddress { get; set; }
    }

    public class FeatureHasFeatureProperty
    {
        [JsonProperty("associatedFeatureId")]
        public string AssociatedFeatureId { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("featureId")]
        public string FeatureId { get; set; }

        [JsonProperty("featurePropertyId")]
        public string FeaturePropertyId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }

        [JsonProperty("textValue")]
        public string TextValue { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class FeatureHasPropertiesEntityInput
    {
        [JsonProperty("associatedFeatureId")]
        public string AssociatedFeatureId { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("featureId")]
        public string FeatureId { get; set; }

        [JsonProperty("featurePropertyId")]
        public string FeaturePropertyId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("textValue")]
        public string TextValue { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("value")]
        public double? Value { get; set; }
    }

    public class FeatureModel
    {
        [JsonProperty("attachmentNodes")]
        public FeatureModelsFeatureModelAttachmentNodeResponse[] AttachmentNodes { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("displayPrices")]
        public bool DisplayPrices { get; set; }

        [JsonProperty("dynamicGroups")]
        public FeatureModelsFeatureModelDynamicGroupResponse[] DynamicGroups { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("nodes")]
        public FeatureModelsFeatureModelNodeResponse[] Nodes { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("relationships")]
        public FeatureModelsFeatureModelRelationshipResponse[] Relationships { get; set; }

        [JsonProperty("revisionOf")]
        public string RevisionOf { get; set; }

        [JsonProperty("rootFeatureId")]
        public string RootFeatureId { get; set; }

        [JsonProperty("status")]
        public FeatureModelStatusType Status { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public class FeatureModelsFeatureModelAttachmentNodeResponse
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("featureModelId")]
        public string FeatureModelId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("rotation")]
        public double Rotation { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }

        [JsonProperty("z")]
        public double Z { get; set; }
    }

    public class FeatureModelsFeatureModelDynamicGroupResponse
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("featureModelId")]
        public string FeatureModelId { get; set; }

        [JsonProperty("featureModelNodeId")]
        public string FeatureModelNodeId { get; set; }

        [JsonProperty("filters")]
        public FeatureModelsFeatureModelDynamicGroupFilterResponse[] Filters { get; set; }

        [JsonProperty("hideInConfigurator")]
        public bool HideInConfigurator { get; set; }

        [JsonProperty("hideInOrderEntry")]
        public bool HideInOrderEntry { get; set; }

        [JsonProperty("hideInQuotation")]
        public bool HideInQuotation { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("orderByFeatureProperty")]
        public string OrderByFeatureProperty { get; set; }

        [JsonProperty("orderByPrice")]
        public bool OrderByPrice { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("relationshipType")]
        public FeatureModelsFeatureModelDynamicGroupRelationshipTypeTypeResponse RelationshipType { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public class FeatureModelsFeatureModelDynamicGroupFilterResponse
    {
        [JsonProperty("associatedFeature")]
        public string AssociatedFeature { get; set; }

        [JsonProperty("associatedFeatureParentId")]
        public string AssociatedFeatureParentId { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("featureModelDynamicGroupFilterValueType")]
        public FeatureModelsFeatureModelDynamicGroupFilterFeatureModelDynamicGroupFilterValueTypeTypeResponse FeatureModelDynamicGroupFilterValueType { get; set; }

        [JsonProperty("featureModelDynamicGroupId")]
        public string FeatureModelDynamicGroupId { get; set; }

        [JsonProperty("featurePropertyId")]
        public string FeaturePropertyId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("valueFeatureModelNodeId")]
        public string ValueFeatureModelNodeId { get; set; }
    }

    public enum FeatureModelsFeatureModelDynamicGroupFilterFeatureModelDynamicGroupFilterValueTypeTypeResponse
    {
        _0 = 0,
        _1 = 1,
        _2 = 2
    }

    public enum FeatureModelsFeatureModelDynamicGroupRelationshipTypeTypeResponse
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6
    }

    public class FeatureModelsFeatureModelNodeResponse
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("defaultValue")]
        public double DefaultValue { get; set; }

        [JsonProperty("divergentPrice")]
        public double DivergentPrice { get; set; }

        [JsonProperty("divergentPriceExpressionId")]
        public string DivergentPriceExpressionId { get; set; }

        [JsonProperty("featureId")]
        public string FeatureId { get; set; }

        [JsonProperty("featureModelId")]
        public string FeatureModelId { get; set; }

        [JsonProperty("hiddenThreeDModelItems")]
        public string[] HiddenThreeDModelItems { get; set; }

        [JsonProperty("hideInConfigurator")]
        public bool HideInConfigurator { get; set; }

        [JsonProperty("hideInOrderEntry")]
        public bool HideInOrderEntry { get; set; }

        [JsonProperty("hideInQuotation")]
        public bool HideInQuotation { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("infoField")]
        public string InfoField { get; set; }

        [JsonProperty("isMandatory")]
        public bool IsMandatory { get; set; }

        [JsonProperty("isPhantom")]
        public bool IsPhantom { get; set; }

        [JsonProperty("isPreconfiguration")]
        public bool IsPreconfiguration { get; set; }

        [JsonProperty("isQuotationGroup")]
        public bool IsQuotationGroup { get; set; }

        [JsonProperty("maxValueExpressionId")]
        public string MaxValueExpressionId { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }

        [JsonProperty("threeDModelItems")]
        public string[] ThreeDModelItems { get; set; }

        [JsonProperty("totalPriceExVAT")]
        public double TotalPriceExVat { get; set; }

        [JsonProperty("totalPriceExVATLabel")]
        public string TotalPriceExVatLabel { get; set; }

        [JsonProperty("totalPriceIncVAT")]
        public double TotalPriceIncVat { get; set; }

        [JsonProperty("totalPriceIncVATLabel")]
        public string TotalPriceIncVatLabel { get; set; }

        [JsonProperty("unitPriceExVAT")]
        public double UnitPriceExVat { get; set; }

        [JsonProperty("unitPriceExVATExExchangeRate")]
        public double UnitPriceExVatExExchangeRate { get; set; }

        [JsonProperty("unitPriceExVATLabel")]
        public string UnitPriceExVatLabel { get; set; }

        [JsonProperty("unitPriceIncVAT")]
        public double UnitPriceIncVat { get; set; }

        [JsonProperty("unitPriceIncVATLabel")]
        public string UnitPriceIncVatLabel { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public class FeatureModelsFeatureModelRelationshipResponse
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("default")]
        public bool Default { get; set; }

        [JsonProperty("displaySeperateBlade")]
        public bool DisplaySeperateBlade { get; set; }

        [JsonProperty("displayType")]
        public FeatureModelsFeatureModelRelationshipDisplayTypeTypeResponse DisplayType { get; set; }

        [JsonProperty("expressionId")]
        public string ExpressionId { get; set; }

        [JsonProperty("featureModelDynamicGroupFromId")]
        public string FeatureModelDynamicGroupFromId { get; set; }

        [JsonProperty("featureModelDynamicGroupToId")]
        public string FeatureModelDynamicGroupToId { get; set; }

        [JsonProperty("featureModelId")]
        public string FeatureModelId { get; set; }

        [JsonProperty("fromNodeId")]
        public string FromNodeId { get; set; }

        [JsonProperty("hideExcludeInView")]
        public bool HideExcludeInView { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("impliesExpression")]
        public string ImpliesExpression { get; set; }

        [JsonProperty("impliesFromValue")]
        public double ImpliesFromValue { get; set; }

        [JsonProperty("impliesRoundingType")]
        public FeatureModelsFeatureModelRelationshipImpliesRoundingTypeTypeResponse ImpliesRoundingType { get; set; }

        [JsonProperty("impliesToValue")]
        public double ImpliesToValue { get; set; }

        [JsonProperty("impliesType")]
        public FeatureModelsFeatureModelRelationshipImpliesTypeTypeResponse ImpliesType { get; set; }

        [JsonProperty("isDefaultSelector")]
        public bool IsDefaultSelector { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }

        [JsonProperty("toNodeId")]
        public string ToNodeId { get; set; }

        [JsonProperty("type")]
        public FeatureModelsFeatureModelRelationshipTypeTypeResponse Type { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public enum FeatureModelsFeatureModelRelationshipDisplayTypeTypeResponse
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _4 = 4,
        _5 = 5
    }

    public enum FeatureModelsFeatureModelRelationshipImpliesRoundingTypeTypeResponse
    {
        _0 = 0,
        _1 = 1,
        _2 = 2
    }

    public enum FeatureModelsFeatureModelRelationshipImpliesTypeTypeResponse
    {
        _0 = 0,
        _1 = 1,
        _3 = 3
    }

    public enum FeatureModelsFeatureModelRelationshipTypeTypeResponse
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6
    }

    public enum FeatureModelStatusType
    {
        _0 = 0,
        _1 = 1
    }

    public class FeatureModelsEntityInput
    {
        [JsonProperty("attachmentNodes")]
        public FeatureModelsFeatureModelAttachmentNode[] AttachmentNodes { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("displayPrices")]
        public bool? DisplayPrices { get; set; }

        [JsonProperty("dynamicGroups")]
        public FeatureModelsFeatureModelDynamicGroup[] DynamicGroups { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("nodes")]
        public FeatureModelsFeatureModelNode[] Nodes { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("relationships")]
        public FeatureModelsFeatureModelRelationship[] Relationships { get; set; }

        [JsonProperty("revisionOf")]
        public string RevisionOf { get; set; }

        [JsonProperty("rootFeatureId")]
        public string RootFeatureId { get; set; }

        [JsonProperty("status")]
        public FeatureModelsEntityInputStatusType? Status { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public class FeatureModelsFeatureModelAttachmentNode
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("featureModelId")]
        public string FeatureModelId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("rotation")]
        public double? Rotation { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("x")]
        public double? X { get; set; }

        [JsonProperty("y")]
        public double? Y { get; set; }

        [JsonProperty("z")]
        public double? Z { get; set; }
    }

    public class FeatureModelsFeatureModelDynamicGroup
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("featureModelId")]
        public string FeatureModelId { get; set; }

        [JsonProperty("featureModelNodeId")]
        public string FeatureModelNodeId { get; set; }

        [JsonProperty("filters")]
        public FeatureModelsFeatureModelDynamicGroupFilter[] Filters { get; set; }

        [JsonProperty("hideInConfigurator")]
        public bool? HideInConfigurator { get; set; }

        [JsonProperty("hideInOrderEntry")]
        public bool? HideInOrderEntry { get; set; }

        [JsonProperty("hideInQuotation")]
        public bool? HideInQuotation { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("orderByFeatureProperty")]
        public string OrderByFeatureProperty { get; set; }

        [JsonProperty("orderByPrice")]
        public bool? OrderByPrice { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("relationshipType")]
        public FeatureModelsFeatureModelDynamicGroupRelationshipTypeType? RelationshipType { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public class FeatureModelsFeatureModelDynamicGroupFilter
    {
        [JsonProperty("associatedFeature")]
        public string AssociatedFeature { get; set; }

        [JsonProperty("associatedFeatureParentId")]
        public string AssociatedFeatureParentId { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("featureModelDynamicGroupFilterValueType")]
        public FeatureModelsFeatureModelDynamicGroupFilterFeatureModelDynamicGroupFilterValueTypeType? FeatureModelDynamicGroupFilterValueType { get; set; }

        [JsonProperty("featureModelDynamicGroupId")]
        public string FeatureModelDynamicGroupId { get; set; }

        [JsonProperty("featurePropertyId")]
        public string FeaturePropertyId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("value")]
        public double? Value { get; set; }

        [JsonProperty("valueFeatureModelNodeId")]
        public string ValueFeatureModelNodeId { get; set; }
    }

    public enum FeatureModelsFeatureModelDynamicGroupFilterFeatureModelDynamicGroupFilterValueTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2
    }

    public enum FeatureModelsFeatureModelDynamicGroupRelationshipTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6
    }

    public class FeatureModelsFeatureModelNode
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("defaultValue")]
        public double? DefaultValue { get; set; }

        [JsonProperty("divergentPrice")]
        public double? DivergentPrice { get; set; }

        [JsonProperty("divergentPriceExpressionId")]
        public string DivergentPriceExpressionId { get; set; }

        [JsonProperty("featureId")]
        public string FeatureId { get; set; }

        [JsonProperty("featureModelId")]
        public string FeatureModelId { get; set; }

        [JsonProperty("hiddenThreeDModelItems")]
        public string[] HiddenThreeDModelItems { get; set; }

        [JsonProperty("hideInConfigurator")]
        public bool? HideInConfigurator { get; set; }

        [JsonProperty("hideInOrderEntry")]
        public bool? HideInOrderEntry { get; set; }

        [JsonProperty("hideInQuotation")]
        public bool? HideInQuotation { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("infoField")]
        public string InfoField { get; set; }

        [JsonProperty("isMandatory")]
        public bool? IsMandatory { get; set; }

        [JsonProperty("isPhantom")]
        public bool? IsPhantom { get; set; }

        [JsonProperty("isPreconfiguration")]
        public bool? IsPreconfiguration { get; set; }

        [JsonProperty("isQuotationGroup")]
        public bool? IsQuotationGroup { get; set; }

        [JsonProperty("maxValueExpressionId")]
        public string MaxValueExpressionId { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("threeDModelItems")]
        public string[] ThreeDModelItems { get; set; }

        [JsonProperty("totalPriceExVAT")]
        public double? TotalPriceExVat { get; set; }

        [JsonProperty("totalPriceExVATLabel")]
        public string TotalPriceExVatLabel { get; set; }

        [JsonProperty("totalPriceIncVAT")]
        public double? TotalPriceIncVat { get; set; }

        [JsonProperty("totalPriceIncVATLabel")]
        public string TotalPriceIncVatLabel { get; set; }

        [JsonProperty("unitPriceExVAT")]
        public double? UnitPriceExVat { get; set; }

        [JsonProperty("unitPriceExVATExExchangeRate")]
        public double? UnitPriceExVatExExchangeRate { get; set; }

        [JsonProperty("unitPriceExVATLabel")]
        public string UnitPriceExVatLabel { get; set; }

        [JsonProperty("unitPriceIncVAT")]
        public double? UnitPriceIncVat { get; set; }

        [JsonProperty("unitPriceIncVATLabel")]
        public string UnitPriceIncVatLabel { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public class FeatureModelsFeatureModelRelationship
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("default")]
        public bool? Default { get; set; }

        [JsonProperty("displaySeperateBlade")]
        public bool? DisplaySeperateBlade { get; set; }

        [JsonProperty("displayType")]
        public FeatureModelsFeatureModelRelationshipDisplayTypeType? DisplayType { get; set; }

        [JsonProperty("expressionId")]
        public string ExpressionId { get; set; }

        [JsonProperty("featureModelDynamicGroupFromId")]
        public string FeatureModelDynamicGroupFromId { get; set; }

        [JsonProperty("featureModelDynamicGroupToId")]
        public string FeatureModelDynamicGroupToId { get; set; }

        [JsonProperty("featureModelId")]
        public string FeatureModelId { get; set; }

        [JsonProperty("fromNodeId")]
        public string FromNodeId { get; set; }

        [JsonProperty("hideExcludeInView")]
        public bool? HideExcludeInView { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("impliesExpression")]
        public string ImpliesExpression { get; set; }

        [JsonProperty("impliesFromValue")]
        public double? ImpliesFromValue { get; set; }

        [JsonProperty("impliesRoundingType")]
        public FeatureModelsFeatureModelRelationshipImpliesRoundingTypeType? ImpliesRoundingType { get; set; }

        [JsonProperty("impliesToValue")]
        public double? ImpliesToValue { get; set; }

        [JsonProperty("impliesType")]
        public FeatureModelsFeatureModelRelationshipImpliesTypeType? ImpliesType { get; set; }

        [JsonProperty("isDefaultSelector")]
        public bool? IsDefaultSelector { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("toNodeId")]
        public string ToNodeId { get; set; }

        [JsonProperty("type")]
        public FeatureModelsFeatureModelRelationshipTypeType? Type { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public enum FeatureModelsFeatureModelRelationshipDisplayTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _4 = 4,
        _5 = 5
    }

    public enum FeatureModelsFeatureModelRelationshipImpliesRoundingTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2
    }

    public enum FeatureModelsFeatureModelRelationshipImpliesTypeType
    {
        _0 = 0,
        _1 = 1,
        _3 = 3
    }

    public enum FeatureModelsFeatureModelRelationshipTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6
    }

    public enum FeatureModelsEntityInputStatusType
    {
        _0 = 0,
        _1 = 1
    }

    public class FeatureProperty
    {
        [JsonProperty("associatedFeatures")]
        public FeaturesPropertiesAssociatedFeaturePropertyResponse[] AssociatedFeatures { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("single")]
        public bool Single { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }

        [JsonProperty("type")]
        public FeaturePropertyTypeType Type { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public class FeaturesPropertiesAssociatedFeaturePropertyResponse
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("feature")]
        public FeaturesFeatureResponse Feature { get; set; }

        [JsonProperty("featureId")]
        public string FeatureId { get; set; }

        [JsonProperty("featurePropertyId")]
        public string FeaturePropertyId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public class FeaturesFeatureResponse
    {
        [JsonProperty("articleCode")]
        public string ArticleCode { get; set; }

        [JsonProperty("cardImageUrl")]
        public string CardImageUrl { get; set; }

        [JsonProperty("category")]
        public CategoriesCategoryResponse Category { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("disallowDiscount")]
        public bool DisallowDiscount { get; set; }

        [JsonProperty("hiddenThreeDModelItems")]
        public string[] HiddenThreeDModelItems { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("marginPct")]
        public double MarginPct { get; set; }

        [JsonProperty("maxValue")]
        public double MaxValue { get; set; }

        [JsonProperty("minValue")]
        public double MinValue { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("packingUnit")]
        public double PackingUnit { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("salesPrice")]
        public double SalesPrice { get; set; }

        [JsonProperty("salesPriceLabel")]
        public string SalesPriceLabel { get; set; }

        [JsonProperty("stepValue")]
        public double StepValue { get; set; }

        [JsonProperty("subcategoryIds")]
        public string[] SubcategoryIds { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("texts")]
        public FeaturesFeatureTextResponse[] Texts { get; set; }

        [JsonProperty("threeDModelItems")]
        public string[] ThreeDModelItems { get; set; }

        [JsonProperty("type")]
        public FeaturesFeatureTypeTypeResponse Type { get; set; }

        [JsonProperty("unitOfMeasurement")]
        public FeaturesUnitOfMeasurementResponse UnitOfMeasurement { get; set; }

        [JsonProperty("unitOfMeasurementId")]
        public string UnitOfMeasurementId { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("vatId")]
        public string VatId { get; set; }
    }

    public class FeaturesFeatureTextResponse
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("featureId")]
        public string FeatureId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("languageIso")]
        public string LanguageIso { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }

        [JsonProperty("type")]
        public FeaturesFeatureTextTypeTypeResponse Type { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum FeaturesFeatureTextTypeTypeResponse
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5
    }

    public enum FeaturesFeatureTypeTypeResponse
    {
        _0 = 0,
        _2 = 2,
        _3 = 3
    }

    public class FeaturesUnitOfMeasurementResponse
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public enum FeaturePropertyTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2
    }

    public class FeaturesPropertiesEntityInput
    {
        [JsonProperty("associatedFeatures")]
        public FeaturesPropertiesAssociatedFeatureProperty[] AssociatedFeatures { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("single")]
        public bool? Single { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("type")]
        public CrmAccountsEntityInputTypeType? Type { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public class FeaturesPropertiesAssociatedFeatureProperty
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("feature")]
        public FeaturesCopyFeature Feature { get; set; }

        [JsonProperty("featureId")]
        public string FeatureId { get; set; }

        [JsonProperty("featurePropertyId")]
        public string FeaturePropertyId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public class FeaturesCopyFeature
    {
        [JsonProperty("articleCode")]
        public string ArticleCode { get; set; }

        [JsonProperty("cardImageUrl")]
        public string CardImageUrl { get; set; }

        [JsonProperty("category")]
        public FeaturesCategory Category { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("disallowDiscount")]
        public bool? DisallowDiscount { get; set; }

        [JsonProperty("hiddenThreeDModelItems")]
        public string[] HiddenThreeDModelItems { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("marginPct")]
        public double? MarginPct { get; set; }

        [JsonProperty("maxValue")]
        public double? MaxValue { get; set; }

        [JsonProperty("minValue")]
        public double? MinValue { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("packingUnit")]
        public double? PackingUnit { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("salesPrice")]
        public double? SalesPrice { get; set; }

        [JsonProperty("salesPriceLabel")]
        public string SalesPriceLabel { get; set; }

        [JsonProperty("stepValue")]
        public double? StepValue { get; set; }

        [JsonProperty("subcategoryIds")]
        public string[] SubcategoryIds { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("texts")]
        public FeaturesFeatureText[] Texts { get; set; }

        [JsonProperty("threeDModelItems")]
        public string[] ThreeDModelItems { get; set; }

        [JsonProperty("type")]
        public FeaturesCopyFeatureTypeType? Type { get; set; }

        [JsonProperty("unitOfMeasurement")]
        public FeaturesUnitOfMeasurement UnitOfMeasurement { get; set; }

        [JsonProperty("unitOfMeasurementId")]
        public string UnitOfMeasurementId { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("vatId")]
        public string VatId { get; set; }
    }

    public class FeaturesCategory
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("linkedFeatures")]
        public int? LinkedFeatures { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("texts")]
        public CategoriesCategoryText[] Texts { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public class FeaturesFeatureText
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("featureId")]
        public string FeatureId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("languageIso")]
        public string LanguageIso { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("type")]
        public FeaturesFeatureTextTypeType? Type { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum FeaturesFeatureTextTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5
    }

    public enum FeaturesCopyFeatureTypeType
    {
        _0 = 0,
        _2 = 2,
        _3 = 3
    }

    public class FeaturesUnitOfMeasurement
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public class FeatureInput
    {
        [JsonProperty("articleCode")]
        public string ArticleCode { get; set; }

        [JsonProperty("cardImageUrl")]
        public string CardImageUrl { get; set; }

        [JsonProperty("category")]
        public FeaturesCategory Category { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("disallowDiscount")]
        public bool? DisallowDiscount { get; set; }

        [JsonProperty("hiddenThreeDModelItems")]
        public string[] HiddenThreeDModelItems { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("marginPct")]
        public double? MarginPct { get; set; }

        [JsonProperty("maxValue")]
        public double? MaxValue { get; set; }

        [JsonProperty("minValue")]
        public double? MinValue { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("packingUnit")]
        public double? PackingUnit { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("salesPrice")]
        public double? SalesPrice { get; set; }

        [JsonProperty("salesPriceLabel")]
        public string SalesPriceLabel { get; set; }

        [JsonProperty("stepValue")]
        public double? StepValue { get; set; }

        [JsonProperty("subcategoryIds")]
        public string[] SubcategoryIds { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("texts")]
        public FeaturesFeatureText[] Texts { get; set; }

        [JsonProperty("threeDModelItems")]
        public string[] ThreeDModelItems { get; set; }

        [JsonProperty("type")]
        public FeatureInputTypeType? Type { get; set; }

        [JsonProperty("unitOfMeasurement")]
        public FeaturesUnitOfMeasurement UnitOfMeasurement { get; set; }

        [JsonProperty("unitOfMeasurementId")]
        public string UnitOfMeasurementId { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("vatId")]
        public string VatId { get; set; }
    }

    public enum FeatureInputTypeType
    {
        _0 = 0,
        _2 = 2,
        _3 = 3
    }

    public class NotificationInput
    {
        [JsonProperty("cancelText")]
        public string CancelText { get; set; }

        [JsonProperty("confirmText")]
        public string ConfirmText { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public class OrganizationSellsFeature
    {
        [JsonProperty("allowedToSell")]
        public bool AllowedToSell { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("featureId")]
        public string FeatureId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("purchaseDiscountPct")]
        public double PurchaseDiscountPct { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }

        [JsonProperty("upValuePct")]
        public double UpValuePct { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public class OrgSellsFeatureEntityInput
    {
        [JsonProperty("allowedToSell")]
        public bool? AllowedToSell { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("featureId")]
        public string FeatureId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("purchaseDiscountPct")]
        public double? PurchaseDiscountPct { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("upValuePct")]
        public double? UpValuePct { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public class QuotationProperty
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fields")]
        public QuotationPropertiesQuotationPropertyFieldResponse[] Fields { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public class QuotationPropertiesQuotationPropertyFieldResponse
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("quotationPropertyId")]
        public string QuotationPropertyId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }

        [JsonProperty("texts")]
        public QuotationPropertiesQuotationPropertyFieldTextResponse[] Texts { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public class QuotationPropertiesQuotationPropertyFieldTextResponse
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("languageIso")]
        public string LanguageIso { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("quotationPropertyFieldId")]
        public string QuotationPropertyFieldId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class QuotationPropertiesEntityInput
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fields")]
        public QuotationPropertiesQuotationPropertyField[] Fields { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isRequired")]
        public bool? IsRequired { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public class QuotationPropertiesQuotationPropertyField
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("quotationPropertyId")]
        public string QuotationPropertyId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("texts")]
        public QuotationPropertiesQuotationPropertyFieldText[] Texts { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public class QuotationPropertiesQuotationPropertyFieldText
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("languageIso")]
        public string LanguageIso { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("quotationPropertyFieldId")]
        public string QuotationPropertyFieldId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Quotation
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("currencyIso")]
        public string CurrencyIso { get; set; }

        [JsonProperty("customerReference")]
        public string CustomerReference { get; set; }

        [JsonProperty("debtorContactId")]
        public string DebtorContactId { get; set; }

        [JsonProperty("debtorId")]
        public string DebtorId { get; set; }

        [JsonProperty("deliverydate")]
        public string Deliverydate { get; set; }

        [JsonProperty("expiresDate")]
        public string ExpiresDate { get; set; }

        [JsonProperty("files")]
        public QuotationsQuotationFileResponse[] Files { get; set; }

        [JsonProperty("formattedVerifiedDate")]
        public string FormattedVerifiedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isExpired")]
        public bool IsExpired { get; set; }

        [JsonProperty("isVerified")]
        public bool IsVerified { get; set; }

        [JsonProperty("languageIso")]
        public string LanguageIso { get; set; }

        [JsonProperty("leaseTermAmount")]
        public int LeaseTermAmount { get; set; }

        [JsonProperty("leaseTermType")]
        public QuotationLeaseTermTypeType LeaseTermType { get; set; }

        [JsonProperty("lines")]
        public QuotationsQuotationLineResponse[] Lines { get; set; }

        [JsonProperty("margin")]
        public double Margin { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("quotationNumber")]
        public int QuotationNumber { get; set; }

        [JsonProperty("quotationReference")]
        public string QuotationReference { get; set; }

        [JsonProperty("quotationTemplateId")]
        public string QuotationTemplateId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("remarks")]
        public string Remarks { get; set; }

        [JsonProperty("revisionOfId")]
        public string RevisionOfId { get; set; }

        [JsonProperty("sellerContactId")]
        public string SellerContactId { get; set; }

        [JsonProperty("sellerId")]
        public string SellerId { get; set; }

        [JsonProperty("shipToContactId")]
        public string ShipToContactId { get; set; }

        [JsonProperty("shipToId")]
        public string ShipToId { get; set; }

        [JsonProperty("status")]
        public QuotationStatusType Status { get; set; }

        [JsonProperty("statusDescription")]
        public string StatusDescription { get; set; }

        [JsonProperty("subTotalExclPrice")]
        public double SubTotalExclPrice { get; set; }

        [JsonProperty("subTotalExclPriceLabel")]
        public string SubTotalExclPriceLabel { get; set; }

        [JsonProperty("subTotalInclPrice")]
        public double SubTotalInclPrice { get; set; }

        [JsonProperty("subTotalInclPriceLabel")]
        public string SubTotalInclPriceLabel { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }

        [JsonProperty("totalDiscountAmntLabel")]
        public string TotalDiscountAmntLabel { get; set; }

        [JsonProperty("totalDiscountAmt")]
        public double TotalDiscountAmt { get; set; }

        [JsonProperty("totalDiscountPct")]
        public double TotalDiscountPct { get; set; }

        [JsonProperty("totalExclPrice")]
        public double TotalExclPrice { get; set; }

        [JsonProperty("totalInclPrice")]
        public double TotalInclPrice { get; set; }

        [JsonProperty("totalPriceExclVATLabel")]
        public string TotalPriceExclVatLabel { get; set; }

        [JsonProperty("totalPriceInclVAT")]
        public double TotalPriceInclVat { get; set; }

        [JsonProperty("totalPriceInclVATLabel")]
        public string TotalPriceInclVatLabel { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("verifiedBy")]
        public string VerifiedBy { get; set; }

        [JsonProperty("verifiedDate")]
        public string VerifiedDate { get; set; }

        [JsonProperty("versionNumber")]
        public int VersionNumber { get; set; }
    }

    public class QuotationsQuotationFileResponse
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("file")]
        public QuotationsFileEntityResponse File { get; set; }

        [JsonProperty("fileId")]
        public string FileId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("quotationId")]
        public string QuotationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public class QuotationsFileEntityResponse
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public enum QuotationLeaseTermTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3
    }

    public class QuotationsQuotationLineResponse
    {
        [JsonProperty("addedFromConfiguration")]
        public bool AddedFromConfiguration { get; set; }

        [JsonProperty("articleCode")]
        public string ArticleCode { get; set; }

        [JsonProperty("basePrice")]
        public double BasePrice { get; set; }

        [JsonProperty("cardImageUrl")]
        public string CardImageUrl { get; set; }

        [JsonProperty("configurationId")]
        public string ConfigurationId { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("defaultPurchasePriceDiscountPct")]
        public double DefaultPurchasePriceDiscountPct { get; set; }

        [JsonProperty("deliverydate")]
        public string Deliverydate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("discountPct")]
        public double DiscountPct { get; set; }

        [JsonProperty("extendedDescription")]
        public string ExtendedDescription { get; set; }

        [JsonProperty("featureId")]
        public string FeatureId { get; set; }

        [JsonProperty("featureModelNodeId")]
        public string FeatureModelNodeId { get; set; }

        [JsonProperty("groupAdditionalExclPrice")]
        public double GroupAdditionalExclPrice { get; set; }

        [JsonProperty("groupAdditionalExclPriceLabel")]
        public string GroupAdditionalExclPriceLabel { get; set; }

        [JsonProperty("groupAdditionalInclPrice")]
        public double GroupAdditionalInclPrice { get; set; }

        [JsonProperty("groupAdditionalInclPriceLabel")]
        public string GroupAdditionalInclPriceLabel { get; set; }

        [JsonProperty("groupBaseExclPrice")]
        public double GroupBaseExclPrice { get; set; }

        [JsonProperty("groupBaseExclPriceDiscountExclVat")]
        public double GroupBaseExclPriceDiscountExclVat { get; set; }

        [JsonProperty("groupBaseInclPrice")]
        public double GroupBaseInclPrice { get; set; }

        [JsonProperty("groupDefaultExclPriceExclDiscountLabel")]
        public string GroupDefaultExclPriceExclDiscountLabel { get; set; }

        [JsonProperty("groupDefaultExclPriceLabel")]
        public string GroupDefaultExclPriceLabel { get; set; }

        [JsonProperty("groupDefaultInclPriceLabel")]
        public string GroupDefaultInclPriceLabel { get; set; }

        [JsonProperty("groupDiscountPct")]
        public double GroupDiscountPct { get; set; }

        [JsonProperty("groupExclMarginLabel")]
        public string GroupExclMarginLabel { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("groupMargin")]
        public double GroupMargin { get; set; }

        [JsonProperty("groupOrder")]
        public int GroupOrder { get; set; }

        [JsonProperty("groupPriceExclLabel")]
        public string GroupPriceExclLabel { get; set; }

        [JsonProperty("groupPriceInclLabel")]
        public string GroupPriceInclLabel { get; set; }

        [JsonProperty("groupPurchasePrice")]
        public double GroupPurchasePrice { get; set; }

        [JsonProperty("groupPurchasePriceLabel")]
        public string GroupPurchasePriceLabel { get; set; }

        [JsonProperty("groupTitle")]
        public string GroupTitle { get; set; }

        [JsonProperty("groupTotalExclPrice")]
        public double GroupTotalExclPrice { get; set; }

        [JsonProperty("groupTotalExclPriceLabel")]
        public string GroupTotalExclPriceLabel { get; set; }

        [JsonProperty("groupTotalInclPrice")]
        public double GroupTotalInclPrice { get; set; }

        [JsonProperty("groupTotalInclPriceLabel")]
        public string GroupTotalInclPriceLabel { get; set; }

        [JsonProperty("groupedRootLine")]
        public bool GroupedRootLine { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lineNumber")]
        public int LineNumber { get; set; }

        [JsonProperty("marginPct")]
        public double MarginPct { get; set; }

        [JsonProperty("moreInfo")]
        public string MoreInfo { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("originalUnitPrice")]
        public double OriginalUnitPrice { get; set; }

        [JsonProperty("parentLineId")]
        public string ParentLineId { get; set; }

        [JsonProperty("purchasePrice")]
        public double PurchasePrice { get; set; }

        [JsonProperty("purchasePriceDiscountPct")]
        public double PurchasePriceDiscountPct { get; set; }

        [JsonProperty("purchasePriceLabel")]
        public string PurchasePriceLabel { get; set; }

        [JsonProperty("quantityAmount")]
        public double QuantityAmount { get; set; }

        [JsonProperty("quantityFormatted")]
        public string QuantityFormatted { get; set; }

        [JsonProperty("quotationId")]
        public string QuotationId { get; set; }

        [JsonProperty("quotationText")]
        public string QuotationText { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }

        [JsonProperty("tenantPurchasePrice")]
        public double TenantPurchasePrice { get; set; }

        [JsonProperty("textValue")]
        public string TextValue { get; set; }

        [JsonProperty("totalExclMargin")]
        public double TotalExclMargin { get; set; }

        [JsonProperty("totalExclMarginLabel")]
        public string TotalExclMarginLabel { get; set; }

        [JsonProperty("totalExclPrice")]
        public double TotalExclPrice { get; set; }

        [JsonProperty("totalExclPriceExclDiscount")]
        public double TotalExclPriceExclDiscount { get; set; }

        [JsonProperty("totalExclPriceExclDiscountLabel")]
        public string TotalExclPriceExclDiscountLabel { get; set; }

        [JsonProperty("totalInclMargin")]
        public double TotalInclMargin { get; set; }

        [JsonProperty("totalInclMarginLabel")]
        public string TotalInclMarginLabel { get; set; }

        [JsonProperty("totalInclPrice")]
        public double TotalInclPrice { get; set; }

        [JsonProperty("totalPriceExclLabel")]
        public string TotalPriceExclLabel { get; set; }

        [JsonProperty("totalPriceInclLabel")]
        public string TotalPriceInclLabel { get; set; }

        [JsonProperty("unitPrice")]
        public double UnitPrice { get; set; }

        [JsonProperty("unitPriceLabel")]
        public string UnitPriceLabel { get; set; }

        [JsonProperty("uom")]
        public string Uom { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("vatId")]
        public string VatId { get; set; }
    }

    public enum QuotationStatusType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7
    }

    public class QuotationsEntityInput
    {
        public QuotationsEntityInput(QuotationsQuotationLine[] lines)
        {
            this.Lines = lines;
        }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("currencyIso")]
        public string CurrencyIso { get; set; }

        [JsonProperty("customerReference")]
        public string CustomerReference { get; set; }

        [JsonProperty("debtorContactId")]
        public string DebtorContactId { get; set; }

        [JsonProperty("debtorId")]
        public string DebtorId { get; set; }

        [JsonProperty("deliverydate")]
        public string Deliverydate { get; set; }

        [JsonProperty("expiresDate")]
        public string ExpiresDate { get; set; }

        [JsonProperty("files")]
        public QuotationsQuotationFile[] Files { get; set; }

        [JsonProperty("formattedVerifiedDate")]
        public string FormattedVerifiedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isExpired")]
        public bool? IsExpired { get; set; }

        [JsonProperty("isVerified")]
        public bool? IsVerified { get; set; }

        [JsonProperty("languageIso")]
        public string LanguageIso { get; set; }

        [JsonProperty("leaseTermAmount")]
        public int? LeaseTermAmount { get; set; }

        [JsonProperty("leaseTermType")]
        public EntityInputLeaseTermTypeType? LeaseTermType { get; set; }

        [JsonProperty("lines", DefaultValueHandling = DefaultValueHandling.Include)]
        public QuotationsQuotationLine[] Lines { get; set; }

        [JsonProperty("margin")]
        public double? Margin { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("quotationNumber")]
        public int? QuotationNumber { get; set; }

        [JsonProperty("quotationReference")]
        public string QuotationReference { get; set; }

        [JsonProperty("quotationTemplateId")]
        public string QuotationTemplateId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("remarks")]
        public string Remarks { get; set; }

        [JsonProperty("revisionOfId")]
        public string RevisionOfId { get; set; }

        [JsonProperty("sellerContactId")]
        public string SellerContactId { get; set; }

        [JsonProperty("sellerId")]
        public string SellerId { get; set; }

        [JsonProperty("shipToContactId")]
        public string ShipToContactId { get; set; }

        [JsonProperty("shipToId")]
        public string ShipToId { get; set; }

        [JsonProperty("status")]
        public QuotationsEntityInputStatusType? Status { get; set; }

        [JsonProperty("statusDescription")]
        public string StatusDescription { get; set; }

        [JsonProperty("subTotalExclPrice")]
        public double? SubTotalExclPrice { get; set; }

        [JsonProperty("subTotalExclPriceLabel")]
        public string SubTotalExclPriceLabel { get; set; }

        [JsonProperty("subTotalInclPrice")]
        public double? SubTotalInclPrice { get; set; }

        [JsonProperty("subTotalInclPriceLabel")]
        public string SubTotalInclPriceLabel { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("totalDiscountAmntLabel")]
        public string TotalDiscountAmntLabel { get; set; }

        [JsonProperty("totalDiscountAmt")]
        public double? TotalDiscountAmt { get; set; }

        [JsonProperty("totalDiscountPct")]
        public double? TotalDiscountPct { get; set; }

        [JsonProperty("totalExclPrice")]
        public double? TotalExclPrice { get; set; }

        [JsonProperty("totalInclPrice")]
        public double? TotalInclPrice { get; set; }

        [JsonProperty("totalPriceExclVATLabel")]
        public string TotalPriceExclVatLabel { get; set; }

        [JsonProperty("totalPriceInclVAT")]
        public double? TotalPriceInclVat { get; set; }

        [JsonProperty("totalPriceInclVATLabel")]
        public string TotalPriceInclVatLabel { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("verifiedBy")]
        public string VerifiedBy { get; set; }

        [JsonProperty("verifiedDate")]
        public string VerifiedDate { get; set; }

        [JsonProperty("versionNumber")]
        public int? VersionNumber { get; set; }
    }

    public class QuotationsQuotationFile
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("file")]
        public QuotationsFileEntity File { get; set; }

        [JsonProperty("fileId")]
        public string FileId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("quotationId")]
        public string QuotationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public class QuotationsFileEntity
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public enum EntityInputLeaseTermTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3
    }

    public class QuotationsQuotationLine
    {
        [JsonProperty("addedFromConfiguration")]
        public bool? AddedFromConfiguration { get; set; }

        [JsonProperty("articleCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ArticleCode { get; set; } = "-";

        [JsonProperty("basePrice")]
        public double? BasePrice { get; set; }

        [JsonProperty("cardImageUrl")]
        public string CardImageUrl { get; set; }

        [JsonProperty("configurationId")]
        public string ConfigurationId { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("defaultPurchasePriceDiscountPct")]
        public double? DefaultPurchasePriceDiscountPct { get; set; }

        [JsonProperty("deliverydate")]
        public string Deliverydate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("discountPct")]
        public double? DiscountPct { get; set; }

        [JsonProperty("extendedDescription")]
        public string ExtendedDescription { get; set; }

        [JsonProperty("featureId")]
        public string FeatureId { get; set; }

        [JsonProperty("featureModelNodeId")]
        public string FeatureModelNodeId { get; set; }

        [JsonProperty("groupAdditionalExclPrice")]
        public double? GroupAdditionalExclPrice { get; set; }

        [JsonProperty("groupAdditionalExclPriceLabel")]
        public string GroupAdditionalExclPriceLabel { get; set; }

        [JsonProperty("groupAdditionalInclPrice")]
        public double? GroupAdditionalInclPrice { get; set; }

        [JsonProperty("groupAdditionalInclPriceLabel")]
        public string GroupAdditionalInclPriceLabel { get; set; }

        [JsonProperty("groupBaseExclPrice")]
        public double? GroupBaseExclPrice { get; set; }

        [JsonProperty("groupBaseExclPriceDiscountExclVat")]
        public double? GroupBaseExclPriceDiscountExclVat { get; set; }

        [JsonProperty("groupBaseInclPrice")]
        public double? GroupBaseInclPrice { get; set; }

        [JsonProperty("groupDefaultExclPriceExclDiscountLabel")]
        public string GroupDefaultExclPriceExclDiscountLabel { get; set; }

        [JsonProperty("groupDefaultExclPriceLabel")]
        public string GroupDefaultExclPriceLabel { get; set; }

        [JsonProperty("groupDefaultInclPriceLabel")]
        public string GroupDefaultInclPriceLabel { get; set; }

        [JsonProperty("groupDiscountPct")]
        public double? GroupDiscountPct { get; set; }

        [JsonProperty("groupExclMarginLabel")]
        public string GroupExclMarginLabel { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("groupMargin")]
        public double? GroupMargin { get; set; }

        [JsonProperty("groupOrder")]
        public int? GroupOrder { get; set; }

        [JsonProperty("groupPriceExclLabel")]
        public string GroupPriceExclLabel { get; set; }

        [JsonProperty("groupPriceInclLabel")]
        public string GroupPriceInclLabel { get; set; }

        [JsonProperty("groupPurchasePrice")]
        public double? GroupPurchasePrice { get; set; }

        [JsonProperty("groupPurchasePriceLabel")]
        public string GroupPurchasePriceLabel { get; set; }

        [JsonProperty("groupTitle")]
        public string GroupTitle { get; set; }

        [JsonProperty("groupTotalExclPrice")]
        public double? GroupTotalExclPrice { get; set; }

        [JsonProperty("groupTotalExclPriceLabel")]
        public string GroupTotalExclPriceLabel { get; set; }

        [JsonProperty("groupTotalInclPrice")]
        public double? GroupTotalInclPrice { get; set; }

        [JsonProperty("groupTotalInclPriceLabel")]
        public string GroupTotalInclPriceLabel { get; set; }

        [JsonProperty("groupedRootLine")]
        public bool? GroupedRootLine { get; set; }

        [JsonProperty("hidden")]
        public bool? Hidden { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lineNumber")]
        public int? LineNumber { get; set; }

        [JsonProperty("marginPct")]
        public double? MarginPct { get; set; }

        [JsonProperty("moreInfo")]
        public string MoreInfo { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("originalUnitPrice")]
        public double? OriginalUnitPrice { get; set; }

        [JsonProperty("parentLineId")]
        public string ParentLineId { get; set; }

        [JsonProperty("purchasePrice")]
        public double? PurchasePrice { get; set; }

        [JsonProperty("purchasePriceDiscountPct")]
        public double? PurchasePriceDiscountPct { get; set; }

        [JsonProperty("purchasePriceLabel")]
        public string PurchasePriceLabel { get; set; }

        [JsonProperty("quantityAmount")]
        public double? QuantityAmount { get; set; }

        [JsonProperty("quantityFormatted")]
        public string QuantityFormatted { get; set; }

        [JsonProperty("quotationId")]
        public string QuotationId { get; set; }

        [JsonProperty("quotationText")]
        public string QuotationText { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("tenantPurchasePrice")]
        public double? TenantPurchasePrice { get; set; }

        [JsonProperty("textValue")]
        public string TextValue { get; set; }

        [JsonProperty("totalExclMargin")]
        public double? TotalExclMargin { get; set; }

        [JsonProperty("totalExclMarginLabel")]
        public string TotalExclMarginLabel { get; set; }

        [JsonProperty("totalExclPrice")]
        public double? TotalExclPrice { get; set; }

        [JsonProperty("totalExclPriceExclDiscount")]
        public double? TotalExclPriceExclDiscount { get; set; }

        [JsonProperty("totalExclPriceExclDiscountLabel")]
        public string TotalExclPriceExclDiscountLabel { get; set; }

        [JsonProperty("totalInclMargin")]
        public double? TotalInclMargin { get; set; }

        [JsonProperty("totalInclMarginLabel")]
        public string TotalInclMarginLabel { get; set; }

        [JsonProperty("totalInclPrice")]
        public double? TotalInclPrice { get; set; }

        [JsonProperty("totalPriceExclLabel")]
        public string TotalPriceExclLabel { get; set; }

        [JsonProperty("totalPriceInclLabel")]
        public string TotalPriceInclLabel { get; set; }

        [JsonProperty("unitPrice")]
        public double? UnitPrice { get; set; }

        [JsonProperty("unitPriceLabel")]
        public string UnitPriceLabel { get; set; }

        [JsonProperty("uom")]
        public string Uom { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("vatId")]
        public string VatId { get; set; }
    }

    public enum QuotationsEntityInputStatusType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7
    }

    public class QuotationInput
    {
        public QuotationInput(QuotationsQuotationLine[] lines)
        {
            this.Lines = lines;
        }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("currencyIso")]
        public string CurrencyIso { get; set; }

        [JsonProperty("customerReference")]
        public string CustomerReference { get; set; }

        [JsonProperty("debtorContactId")]
        public string DebtorContactId { get; set; }

        [JsonProperty("debtorId")]
        public string DebtorId { get; set; }

        [JsonProperty("deliverydate")]
        public string Deliverydate { get; set; }

        [JsonProperty("expiresDate")]
        public string ExpiresDate { get; set; }

        [JsonProperty("files")]
        public QuotationsQuotationFile[] Files { get; set; }

        [JsonProperty("formattedVerifiedDate")]
        public string FormattedVerifiedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isExpired")]
        public bool? IsExpired { get; set; }

        [JsonProperty("isVerified")]
        public bool? IsVerified { get; set; }

        [JsonProperty("languageIso")]
        public string LanguageIso { get; set; }

        [JsonProperty("leaseTermAmount")]
        public int? LeaseTermAmount { get; set; }

        [JsonProperty("leaseTermType")]
        public QuotationInputLeaseTermTypeType? LeaseTermType { get; set; }

        [JsonProperty("lines", DefaultValueHandling = DefaultValueHandling.Include)]
        public QuotationsQuotationLine[] Lines { get; set; }

        [JsonProperty("margin")]
        public double? Margin { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("quotationNumber")]
        public int? QuotationNumber { get; set; }

        [JsonProperty("quotationReference")]
        public string QuotationReference { get; set; }

        [JsonProperty("quotationTemplateId")]
        public string QuotationTemplateId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("remarks")]
        public string Remarks { get; set; }

        [JsonProperty("revisionOfId")]
        public string RevisionOfId { get; set; }

        [JsonProperty("sellerContactId")]
        public string SellerContactId { get; set; }

        [JsonProperty("sellerId")]
        public string SellerId { get; set; }

        [JsonProperty("shipToContactId")]
        public string ShipToContactId { get; set; }

        [JsonProperty("shipToId")]
        public string ShipToId { get; set; }

        [JsonProperty("status")]
        public QuotationInputStatusType? Status { get; set; }

        [JsonProperty("statusDescription")]
        public string StatusDescription { get; set; }

        [JsonProperty("subTotalExclPrice")]
        public double? SubTotalExclPrice { get; set; }

        [JsonProperty("subTotalExclPriceLabel")]
        public string SubTotalExclPriceLabel { get; set; }

        [JsonProperty("subTotalInclPrice")]
        public double? SubTotalInclPrice { get; set; }

        [JsonProperty("subTotalInclPriceLabel")]
        public string SubTotalInclPriceLabel { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("totalDiscountAmntLabel")]
        public string TotalDiscountAmntLabel { get; set; }

        [JsonProperty("totalDiscountAmt")]
        public double? TotalDiscountAmt { get; set; }

        [JsonProperty("totalDiscountPct")]
        public double? TotalDiscountPct { get; set; }

        [JsonProperty("totalExclPrice")]
        public double? TotalExclPrice { get; set; }

        [JsonProperty("totalInclPrice")]
        public double? TotalInclPrice { get; set; }

        [JsonProperty("totalPriceExclVATLabel")]
        public string TotalPriceExclVatLabel { get; set; }

        [JsonProperty("totalPriceInclVAT")]
        public double? TotalPriceInclVat { get; set; }

        [JsonProperty("totalPriceInclVATLabel")]
        public string TotalPriceInclVatLabel { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("verifiedBy")]
        public string VerifiedBy { get; set; }

        [JsonProperty("verifiedDate")]
        public string VerifiedDate { get; set; }

        [JsonProperty("versionNumber")]
        public int? VersionNumber { get; set; }
    }

    public enum QuotationInputLeaseTermTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3
    }

    public enum QuotationInputStatusType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5,
        _6 = 6,
        _7 = 7
    }

    public class PatchDocumentInput
    {
        [JsonProperty("ids")]
        public string[] Ids { get; set; }

        [JsonProperty("operations")]
        public OperationQuotation[] Operations { get; set; }

        [JsonProperty("patchDocuments")]
        public JsonPatchDocumentQuotation[] PatchDocuments { get; set; }
    }

    public class OperationQuotation
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("op")]
        public string Op { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }

    public class JsonPatchDocumentQuotation
    {
        [JsonProperty("operations")]
        public OperationQuotation[] Operations { get; set; }
    }

    public class Step
    {
        [JsonProperty("backgroundUrl")]
        public string BackgroundUrl { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("featureModelId")]
        public string FeatureModelId { get; set; }

        [JsonProperty("iconUrl")]
        public string IconUrl { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("listviewEnabled")]
        public bool ListviewEnabled { get; set; }

        [JsonProperty("mainCameraPositionId")]
        public string MainCameraPositionId { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("requiredHotspots")]
        public bool RequiredHotspots { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }

        [JsonProperty("texts")]
        public StepsStepTextResponse[] Texts { get; set; }

        [JsonProperty("type")]
        public StepTypeType Type { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("visibleNodes")]
        public string[] VisibleNodes { get; set; }
    }

    public class StepsStepTextResponse
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("languageIso")]
        public string LanguageIso { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("stepId")]
        public string StepId { get; set; }

        [JsonProperty("synced")]
        public bool Synced { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum StepTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5
    }

    public class StepsEntityInput
    {
        [JsonProperty("backgroundUrl")]
        public string BackgroundUrl { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("featureModelId")]
        public string FeatureModelId { get; set; }

        [JsonProperty("iconUrl")]
        public string IconUrl { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("listviewEnabled")]
        public bool? ListviewEnabled { get; set; }

        [JsonProperty("mainCameraPositionId")]
        public string MainCameraPositionId { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("requiredHotspots")]
        public bool? RequiredHotspots { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("texts")]
        public StepsStepText[] Texts { get; set; }

        [JsonProperty("type")]
        public StepsEntityInputTypeType? Type { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("visibleNodes")]
        public string[] VisibleNodes { get; set; }
    }

    public class StepsStepText
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("languageIso")]
        public string LanguageIso { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("stepId")]
        public string StepId { get; set; }

        [JsonProperty("synced")]
        public bool? Synced { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum StepsEntityInputTypeType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5
    }

    public class WebHooksSubscriptionInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Elfsquad;

    public partial class WorkflowManagedActions
    {
        public ElfsquadActions Elfsquad(string connectionId) => new ElfsquadActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ElfsquadTriggers Elfsquad(string connectionId) => new ElfsquadTriggers(connectionId);
    }
}