//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openplz
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpenplzActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<FederalState[]> GetFederalStatesDE()
        {
            var apiCallPath = "/de/FederalStates";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FederalState[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildGetGovernmentRegionsByFederalStateDE))]
        public IBodyWorkflowAction<GovernmentRegion[]> GetGovernmentRegionsByFederalStateDE([WorkflowExpression] Func<string> federalStateKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GovernmentRegion[]> __BuildGetGovernmentRegionsByFederalStateDE(WorkflowExpression<string> federalStateKey, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(federalStateKey, nameof(federalStateKey), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<GovernmentRegion[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/de/FederalStates/{0}/GovernmentRegions", ExpressionConverter.ConvertWithUrlEncoding(federalStateKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<GovernmentRegion[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildGetDistrictsByFederalStateDE))]
        public IBodyWorkflowAction<District[]> GetDistrictsByFederalStateDE([WorkflowExpression] Func<string> federalStateKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<District[]> __BuildGetDistrictsByFederalStateDE(WorkflowExpression<string> federalStateKey, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(federalStateKey, nameof(federalStateKey), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<District[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/de/FederalStates/{0}/Districts", ExpressionConverter.ConvertWithUrlEncoding(federalStateKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<District[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildGetDistrictsByGovernmentRegionDE))]
        public IBodyWorkflowAction<District[]> GetDistrictsByGovernmentRegionDE([WorkflowExpression] Func<string> governmentRegionKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<District[]> __BuildGetDistrictsByGovernmentRegionDE(WorkflowExpression<string> governmentRegionKey, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(governmentRegionKey, nameof(governmentRegionKey), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<District[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/de/GovernmentRegions/{0}/Districts", ExpressionConverter.ConvertWithUrlEncoding(governmentRegionKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<District[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildGetMunicipalitiesByFederalStateDE))]
        public IBodyWorkflowAction<Municipality[]> GetMunicipalitiesByFederalStateDE([WorkflowExpression] Func<string> federalStateKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Municipality[]> __BuildGetMunicipalitiesByFederalStateDE(WorkflowExpression<string> federalStateKey, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(federalStateKey, nameof(federalStateKey), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<Municipality[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/de/FederalStates/{0}/Municipalities", ExpressionConverter.ConvertWithUrlEncoding(federalStateKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<Municipality[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildGetMunicipalitiesByGovernmentRegionDE))]
        public IBodyWorkflowAction<Municipality[]> GetMunicipalitiesByGovernmentRegionDE([WorkflowExpression] Func<string> governmentRegionKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Municipality[]> __BuildGetMunicipalitiesByGovernmentRegionDE(WorkflowExpression<string> governmentRegionKey, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(governmentRegionKey, nameof(governmentRegionKey), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<Municipality[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/de/GovernmentRegions/{0}/Municipalities", ExpressionConverter.ConvertWithUrlEncoding(governmentRegionKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<Municipality[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildGetMunicipalitiesByDistrictDE))]
        public IBodyWorkflowAction<Municipality[]> GetMunicipalitiesByDistrictDE([WorkflowExpression] Func<string> districtKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Municipality[]> __BuildGetMunicipalitiesByDistrictDE(WorkflowExpression<string> districtKey, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(districtKey, nameof(districtKey), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<Municipality[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/de/Districts/{0}/Municipalities", ExpressionConverter.ConvertWithUrlEncoding(districtKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<Municipality[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildGetMunicipalAssociationsByFederalStateDE))]
        public IBodyWorkflowAction<MunicipalAssociation[]> GetMunicipalAssociationsByFederalStateDE([WorkflowExpression] Func<string> federalStateKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MunicipalAssociation[]> __BuildGetMunicipalAssociationsByFederalStateDE(WorkflowExpression<string> federalStateKey, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(federalStateKey, nameof(federalStateKey), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<MunicipalAssociation[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/de/FederalStates/{0}/MunicipalAssociations", ExpressionConverter.ConvertWithUrlEncoding(federalStateKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<MunicipalAssociation[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildGetMunicipalAssociationsByGovernmentRegionDE))]
        public IBodyWorkflowAction<MunicipalAssociation[]> GetMunicipalAssociationsByGovernmentRegionDE([WorkflowExpression] Func<string> governmentRegionKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MunicipalAssociation[]> __BuildGetMunicipalAssociationsByGovernmentRegionDE(WorkflowExpression<string> governmentRegionKey, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(governmentRegionKey, nameof(governmentRegionKey), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<MunicipalAssociation[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/de/GovernmentRegions/{0}/MunicipalAssociations", ExpressionConverter.ConvertWithUrlEncoding(governmentRegionKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<MunicipalAssociation[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildGetMunicipalAssociationsByDistrictDE))]
        public IBodyWorkflowAction<MunicipalAssociation[]> GetMunicipalAssociationsByDistrictDE([WorkflowExpression] Func<string> districtKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MunicipalAssociation[]> __BuildGetMunicipalAssociationsByDistrictDE(WorkflowExpression<string> districtKey, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(districtKey, nameof(districtKey), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<MunicipalAssociation[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/de/Districts/{0}/MunicipalAssociations", ExpressionConverter.ConvertWithUrlEncoding(districtKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<MunicipalAssociation[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildGetLocalitiesByFederalStateDE))]
        public IBodyWorkflowAction<Locality[]> GetLocalitiesByFederalStateDE([WorkflowExpression] Func<string> federalStateKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Locality[]> __BuildGetLocalitiesByFederalStateDE(WorkflowExpression<string> federalStateKey, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(federalStateKey, nameof(federalStateKey), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<Locality[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/de/FederalStates/{0}/Localities", ExpressionConverter.ConvertWithUrlEncoding(federalStateKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<Locality[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildGetLocalitiesByGovernmentRegionDE))]
        public IBodyWorkflowAction<Locality[]> GetLocalitiesByGovernmentRegionDE([WorkflowExpression] Func<string> governmentRegionKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Locality[]> __BuildGetLocalitiesByGovernmentRegionDE(WorkflowExpression<string> governmentRegionKey, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(governmentRegionKey, nameof(governmentRegionKey), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<Locality[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/de/GovernmentRegions/{0}/Localities", ExpressionConverter.ConvertWithUrlEncoding(governmentRegionKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<Locality[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildGetLocalitiesByDistrictDE))]
        public IBodyWorkflowAction<Locality[]> GetLocalitiesByDistrictDE([WorkflowExpression] Func<string> districtKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Locality[]> __BuildGetLocalitiesByDistrictDE(WorkflowExpression<string> districtKey, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(districtKey, nameof(districtKey), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<Locality[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/de/Districts/{0}/Localities", ExpressionConverter.ConvertWithUrlEncoding(districtKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<Locality[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildSearchLocalitiesDE))]
        public IBodyWorkflowAction<Locality[]> SearchLocalitiesDE([WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Locality[]> __BuildSearchLocalitiesDE(WorkflowExpression<string> postalCode = null, WorkflowExpression<string> name = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(postalCode, nameof(postalCode), required: false);
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<Locality[]>(() =>
            {
                var apiCallPath = "/de/Localities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (postalCode != null)
                    callPayload.Queries["postalCode"] = ExpressionConverter.Convert(postalCode);
                if (name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<Locality[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildSearchStreetsDE))]
        public IBodyWorkflowAction<Street[]> SearchStreetsDE([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> locality = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Street[]> __BuildSearchStreetsDE(WorkflowExpression<string> name = null, WorkflowExpression<string> postalCode = null, WorkflowExpression<string> locality = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(postalCode, nameof(postalCode), required: false);
            WorkflowExpression.Validate(locality, nameof(locality), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<Street[]>(() =>
            {
                var apiCallPath = "/de/Streets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                if (postalCode != null)
                    callPayload.Queries["postalCode"] = ExpressionConverter.Convert(postalCode);
                if (locality != null)
                    callPayload.Queries["locality"] = ExpressionConverter.Convert(locality);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<Street[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildFullTextSearchDE))]
        public IBodyWorkflowAction<Street[]> FullTextSearchDE([WorkflowExpression] Func<string> searchTerm, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Street[]> __BuildFullTextSearchDE(WorkflowExpression<string> searchTerm, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(searchTerm, nameof(searchTerm), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<Street[]>(() =>
            {
                var apiCallPath = "/de/FullTextSearch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchTerm"] = ExpressionConverter.Convert(searchTerm);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<Street[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<CommuneLI[]> GetCommunesLI()
        {
            var apiCallPath = "/li/Communes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CommuneLI[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildSearchLocalitiesLI))]
        public IBodyWorkflowAction<LocalityLI[]> SearchLocalitiesLI([WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LocalityLI[]> __BuildSearchLocalitiesLI(WorkflowExpression<string> postalCode = null, WorkflowExpression<string> name = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(postalCode, nameof(postalCode), required: false);
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<LocalityLI[]>(() =>
            {
                var apiCallPath = "/li/Localities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (postalCode != null)
                    callPayload.Queries["postalCode"] = ExpressionConverter.Convert(postalCode);
                if (name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<LocalityLI[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildSearchStreetsLI))]
        public IBodyWorkflowAction<StreetLI[]> SearchStreetsLI([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> locality = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StreetLI[]> __BuildSearchStreetsLI(WorkflowExpression<string> name = null, WorkflowExpression<string> postalCode = null, WorkflowExpression<string> locality = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(postalCode, nameof(postalCode), required: false);
            WorkflowExpression.Validate(locality, nameof(locality), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<StreetLI[]>(() =>
            {
                var apiCallPath = "/li/Streets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                if (postalCode != null)
                    callPayload.Queries["postalCode"] = ExpressionConverter.Convert(postalCode);
                if (locality != null)
                    callPayload.Queries["locality"] = ExpressionConverter.Convert(locality);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<StreetLI[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildFullTextSearchLI))]
        public IBodyWorkflowAction<StreetLI[]> FullTextSearchLI([WorkflowExpression] Func<string> searchTerm, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StreetLI[]> __BuildFullTextSearchLI(WorkflowExpression<string> searchTerm, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(searchTerm, nameof(searchTerm), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<StreetLI[]>(() =>
            {
                var apiCallPath = "/li/FullTextSearch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchTerm"] = ExpressionConverter.Convert(searchTerm);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<StreetLI[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<CantonCH[]> GetCantonsCH()
        {
            var apiCallPath = "/ch/Cantons";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CantonCH[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildGetDistrictsByCantonCH))]
        public IBodyWorkflowAction<DistrictCH[]> GetDistrictsByCantonCH([WorkflowExpression] Func<string> cantonKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DistrictCH[]> __BuildGetDistrictsByCantonCH(WorkflowExpression<string> cantonKey, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(cantonKey, nameof(cantonKey), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<DistrictCH[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/ch/Cantons/{0}/Districts", ExpressionConverter.ConvertWithUrlEncoding(cantonKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<DistrictCH[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildGetCommunesByCantonCH))]
        public IBodyWorkflowAction<CommuneCH[]> GetCommunesByCantonCH([WorkflowExpression] Func<string> cantonKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CommuneCH[]> __BuildGetCommunesByCantonCH(WorkflowExpression<string> cantonKey, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(cantonKey, nameof(cantonKey), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<CommuneCH[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/ch/Cantons/{0}/Communes", ExpressionConverter.ConvertWithUrlEncoding(cantonKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<CommuneCH[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildGetCommunesByDistrictCH))]
        public IBodyWorkflowAction<CommuneCH[]> GetCommunesByDistrictCH([WorkflowExpression] Func<string> districtKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CommuneCH[]> __BuildGetCommunesByDistrictCH(WorkflowExpression<string> districtKey, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(districtKey, nameof(districtKey), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<CommuneCH[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/ch/Districts/{0}/Communes", ExpressionConverter.ConvertWithUrlEncoding(districtKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<CommuneCH[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildGetLocalitiesByCantonCH))]
        public IBodyWorkflowAction<LocalityCH[]> GetLocalitiesByCantonCH([WorkflowExpression] Func<string> cantonKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LocalityCH[]> __BuildGetLocalitiesByCantonCH(WorkflowExpression<string> cantonKey, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(cantonKey, nameof(cantonKey), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<LocalityCH[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/ch/Cantons/{0}/Localities", ExpressionConverter.ConvertWithUrlEncoding(cantonKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<LocalityCH[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildGetLocalitiesByDistrictCH))]
        public IBodyWorkflowAction<LocalityCH[]> GetLocalitiesByDistrictCH([WorkflowExpression] Func<string> districtKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LocalityCH[]> __BuildGetLocalitiesByDistrictCH(WorkflowExpression<string> districtKey, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(districtKey, nameof(districtKey), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<LocalityCH[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/ch/Districts/{0}/Localities", ExpressionConverter.ConvertWithUrlEncoding(districtKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<LocalityCH[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildSearchLocalitiesCH))]
        public IBodyWorkflowAction<LocalityCH[]> SearchLocalitiesCH([WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LocalityCH[]> __BuildSearchLocalitiesCH(WorkflowExpression<string> postalCode = null, WorkflowExpression<string> name = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(postalCode, nameof(postalCode), required: false);
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<LocalityCH[]>(() =>
            {
                var apiCallPath = "/ch/Localities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (postalCode != null)
                    callPayload.Queries["postalCode"] = ExpressionConverter.Convert(postalCode);
                if (name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<LocalityCH[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildSearchStreetsCH))]
        public IBodyWorkflowAction<StreetCH[]> SearchStreetsCH([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> locality = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StreetCH[]> __BuildSearchStreetsCH(WorkflowExpression<string> name = null, WorkflowExpression<string> postalCode = null, WorkflowExpression<string> locality = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(postalCode, nameof(postalCode), required: false);
            WorkflowExpression.Validate(locality, nameof(locality), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<StreetCH[]>(() =>
            {
                var apiCallPath = "/ch/Streets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                if (postalCode != null)
                    callPayload.Queries["postalCode"] = ExpressionConverter.Convert(postalCode);
                if (locality != null)
                    callPayload.Queries["locality"] = ExpressionConverter.Convert(locality);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<StreetCH[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildFullTextSearchCH))]
        public IBodyWorkflowAction<StreetCH[]> FullTextSearchCH([WorkflowExpression] Func<string> searchTerm, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StreetCH[]> __BuildFullTextSearchCH(WorkflowExpression<string> searchTerm, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(searchTerm, nameof(searchTerm), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<StreetCH[]>(() =>
            {
                var apiCallPath = "/ch/FullTextSearch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchTerm"] = ExpressionConverter.Convert(searchTerm);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<StreetCH[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<FederalProvinceAT[]> GetFederalProvincesAT()
        {
            var apiCallPath = "/at/FederalProvinces";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FederalProvinceAT[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildGetDistrictsByFederalProvinceAT))]
        public IBodyWorkflowAction<DistrictAT[]> GetDistrictsByFederalProvinceAT([WorkflowExpression] Func<string> federalProvinceKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DistrictAT[]> __BuildGetDistrictsByFederalProvinceAT(WorkflowExpression<string> federalProvinceKey, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(federalProvinceKey, nameof(federalProvinceKey), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<DistrictAT[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/at/FederalProvinces/{0}/Districts", ExpressionConverter.ConvertWithUrlEncoding(federalProvinceKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<DistrictAT[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildGetMunicipalitiesByFederalProvinceAT))]
        public IBodyWorkflowAction<MunicipalityAT[]> GetMunicipalitiesByFederalProvinceAT([WorkflowExpression] Func<string> federalProvinceKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MunicipalityAT[]> __BuildGetMunicipalitiesByFederalProvinceAT(WorkflowExpression<string> federalProvinceKey, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(federalProvinceKey, nameof(federalProvinceKey), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<MunicipalityAT[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/at/FederalProvinces/{0}/Municipalities", ExpressionConverter.ConvertWithUrlEncoding(federalProvinceKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<MunicipalityAT[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildGetMunicipalitiesByDistrictAT))]
        public IBodyWorkflowAction<MunicipalityAT[]> GetMunicipalitiesByDistrictAT([WorkflowExpression] Func<string> districtKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MunicipalityAT[]> __BuildGetMunicipalitiesByDistrictAT(WorkflowExpression<string> districtKey, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(districtKey, nameof(districtKey), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<MunicipalityAT[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/at/Districts/{0}/Municipalities", ExpressionConverter.ConvertWithUrlEncoding(districtKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<MunicipalityAT[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildGetLocalitiesByFederalProvinceAT))]
        public IBodyWorkflowAction<LocalityAT[]> GetLocalitiesByFederalProvinceAT([WorkflowExpression] Func<string> federalProvinceKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LocalityAT[]> __BuildGetLocalitiesByFederalProvinceAT(WorkflowExpression<string> federalProvinceKey, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(federalProvinceKey, nameof(federalProvinceKey), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<LocalityAT[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/at/FederalProvinces/{0}/Localities", ExpressionConverter.ConvertWithUrlEncoding(federalProvinceKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<LocalityAT[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildGetLocalitiesByDistrictAT))]
        public IBodyWorkflowAction<LocalityAT[]> GetLocalitiesByDistrictAT([WorkflowExpression] Func<string> districtKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LocalityAT[]> __BuildGetLocalitiesByDistrictAT(WorkflowExpression<string> districtKey, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(districtKey, nameof(districtKey), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<LocalityAT[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/at/Districts/{0}/Localities", ExpressionConverter.ConvertWithUrlEncoding(districtKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<LocalityAT[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildSearchLocalitiesAT))]
        public IBodyWorkflowAction<LocalityAT[]> SearchLocalitiesAT([WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LocalityAT[]> __BuildSearchLocalitiesAT(WorkflowExpression<string> postalCode = null, WorkflowExpression<string> name = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(postalCode, nameof(postalCode), required: false);
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<LocalityAT[]>(() =>
            {
                var apiCallPath = "/at/Localities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (postalCode != null)
                    callPayload.Queries["postalCode"] = ExpressionConverter.Convert(postalCode);
                if (name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<LocalityAT[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildSearchStreetsAT))]
        public IBodyWorkflowAction<StreetAT[]> SearchStreetsAT([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> locality = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StreetAT[]> __BuildSearchStreetsAT(WorkflowExpression<string> name = null, WorkflowExpression<string> postalCode = null, WorkflowExpression<string> locality = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(postalCode, nameof(postalCode), required: false);
            WorkflowExpression.Validate(locality, nameof(locality), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<StreetAT[]>(() =>
            {
                var apiCallPath = "/at/Streets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                if (postalCode != null)
                    callPayload.Queries["postalCode"] = ExpressionConverter.Convert(postalCode);
                if (locality != null)
                    callPayload.Queries["locality"] = ExpressionConverter.Convert(locality);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<StreetAT[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        [WorkflowExpressionFactory(nameof(__BuildFullTextSearchAT))]
        public IBodyWorkflowAction<StreetAT[]> FullTextSearchAT([WorkflowExpression] Func<string> searchTerm, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StreetAT[]> __BuildFullTextSearchAT(WorkflowExpression<string> searchTerm, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(searchTerm, nameof(searchTerm), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<StreetAT[]>(() =>
            {
                var apiCallPath = "/at/FullTextSearch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchTerm"] = ExpressionConverter.Convert(searchTerm);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<StreetAT[]>(callPayload);
            });
        }
    }

    public class OpenplzTriggers([ConnectionName] string connectionId)
    {
    }

    public class FederalState
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("seatOfGovernment")]
        public string SeatOfGovernment { get; set; }
    }

    public class GovernmentRegion
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("administrativeHeadquarters")]
        public string AdministrativeHeadquarters { get; set; }

        [JsonProperty("federalState")]
        public FederalStateSummary FederalState { get; set; }
    }

    public class FederalStateSummary
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class District
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("administrativeHeadquarters")]
        public string AdministrativeHeadquarters { get; set; }

        [JsonProperty("governmentRegion")]
        public GovernmentRegionSummary GovernmentRegion { get; set; }

        [JsonProperty("federalState")]
        public FederalStateSummary FederalState { get; set; }
    }

    public class GovernmentRegionSummary
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Municipality
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("multiplePostalCodes")]
        public bool MultiplePostalCodes { get; set; }

        [JsonProperty("association")]
        public MunicipalAssociationSummary Association { get; set; }

        [JsonProperty("district")]
        public DistrictSummary District { get; set; }

        [JsonProperty("governmentRegion")]
        public GovernmentRegionSummary GovernmentRegion { get; set; }

        [JsonProperty("federalState")]
        public FederalStateSummary FederalState { get; set; }
    }

    public class MunicipalAssociationSummary
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class DistrictSummary
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class MunicipalAssociation
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("administrativeHeadquarters")]
        public string AdministrativeHeadquarters { get; set; }

        [JsonProperty("district")]
        public DistrictSummary District { get; set; }

        [JsonProperty("governmentRegion")]
        public GovernmentRegionSummary GovernmentRegion { get; set; }

        [JsonProperty("federalState")]
        public FederalStateSummary FederalState { get; set; }
    }

    public class Locality
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("municipality")]
        public MunicipalitySummary Municipality { get; set; }

        [JsonProperty("district")]
        public DistrictSummary District { get; set; }

        [JsonProperty("governmentRegion")]
        public GovernmentRegionSummary GovernmentRegion { get; set; }

        [JsonProperty("federalState")]
        public FederalStateSummary FederalState { get; set; }
    }

    public class MunicipalitySummary
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class Street
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("borough")]
        public string Borough { get; set; }

        [JsonProperty("suburb")]
        public string Suburb { get; set; }

        [JsonProperty("municipality")]
        public MunicipalitySummary Municipality { get; set; }

        [JsonProperty("district")]
        public DistrictSummary District { get; set; }

        [JsonProperty("governmentRegion")]
        public GovernmentRegionSummary GovernmentRegion { get; set; }

        [JsonProperty("federalState")]
        public FederalStateSummary FederalState { get; set; }
    }

    public class CommuneLI
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("electoralDistrict")]
        public string ElectoralDistrict { get; set; }
    }

    public class LocalityLI
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("commune")]
        public LocalityLICommuneType Commune { get; set; }
    }

    public class LocalityLICommuneType
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class StreetLI
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("commune")]
        public StreetLICommuneType Commune { get; set; }
    }

    public class StreetLICommuneType
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CantonCH
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("historicalCode")]
        public string HistoricalCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }
    }

    public class DistrictCH
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("historicalCode")]
        public string HistoricalCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("canton")]
        public CantonCHSummary Canton { get; set; }
    }

    public class CantonCHSummary
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }
    }

    public class CommuneCH
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("historicalCode")]
        public string HistoricalCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("district")]
        public DistrictCHSummary District { get; set; }

        [JsonProperty("canton")]
        public CantonCHSummary Canton { get; set; }
    }

    public class DistrictCHSummary
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }
    }

    public class LocalityCH
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("postalcode")]
        public string Postalcode { get; set; }

        [JsonProperty("commune")]
        public CommuneCHSummary Commune { get; set; }

        [JsonProperty("district")]
        public DistrictCHSummary District { get; set; }

        [JsonProperty("canton")]
        public CantonCHSummary Canton { get; set; }
    }

    public class CommuneCHSummary
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }
    }

    public class StreetCH
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("postalcode")]
        public string Postalcode { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("commune")]
        public CommuneCHSummary Commune { get; set; }

        [JsonProperty("district")]
        public DistrictCHSummary District { get; set; }

        [JsonProperty("canton")]
        public CantonCHSummary Canton { get; set; }
    }

    public class FederalProvinceAT
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class DistrictAT
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("federalProvince")]
        public FederalProvinceATSummary FederalProvince { get; set; }
    }

    public class FederalProvinceATSummary
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class MunicipalityAT
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("multiplePostalCodes")]
        public bool MultiplePostalCodes { get; set; }

        [JsonProperty("district")]
        public DistrictATSummary District { get; set; }

        [JsonProperty("federalProvince")]
        public FederalProvinceATSummary FederalProvince { get; set; }
    }

    public class DistrictATSummary
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class LocalityAT
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("postalcode")]
        public string Postalcode { get; set; }

        [JsonProperty("municipality")]
        public MunicipalityATSummary Municipality { get; set; }

        [JsonProperty("district")]
        public DistrictATSummary District { get; set; }

        [JsonProperty("federalProvince")]
        public FederalProvinceATSummary FederalProvince { get; set; }
    }

    public class MunicipalityATSummary
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class StreetAT
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("postalcode")]
        public string Postalcode { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("municipality")]
        public MunicipalityATSummary Municipality { get; set; }

        [JsonProperty("district")]
        public DistrictATSummary District { get; set; }

        [JsonProperty("federalProvince")]
        public FederalProvinceATSummary FederalProvince { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Openplz;

    public partial class WorkflowManagedActions
    {
        public OpenplzActions Openplz(string connectionId) => new OpenplzActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OpenplzTriggers Openplz(string connectionId) => new OpenplzTriggers(connectionId);
    }
}