//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openplz
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
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
        public IBodyWorkflowAction<GovernmentRegion[]> GetGovernmentRegionsByFederalStateDE(Expression<Func<string>> federalStateKey, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_federalStateKey = WorkflowExpression.Compile(federalStateKey, nameof(federalStateKey), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<GovernmentRegion[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/de/FederalStates/{0}/GovernmentRegions", __workflow_federalStateKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<GovernmentRegion[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<District[]> GetDistrictsByFederalStateDE(Expression<Func<string>> federalStateKey, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_federalStateKey = WorkflowExpression.Compile(federalStateKey, nameof(federalStateKey), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<District[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/de/FederalStates/{0}/Districts", __workflow_federalStateKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<District[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<District[]> GetDistrictsByGovernmentRegionDE(Expression<Func<string>> governmentRegionKey, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_governmentRegionKey = WorkflowExpression.Compile(governmentRegionKey, nameof(governmentRegionKey), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<District[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/de/GovernmentRegions/{0}/Districts", __workflow_governmentRegionKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<District[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<Municipality[]> GetMunicipalitiesByFederalStateDE(Expression<Func<string>> federalStateKey, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_federalStateKey = WorkflowExpression.Compile(federalStateKey, nameof(federalStateKey), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<Municipality[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/de/FederalStates/{0}/Municipalities", __workflow_federalStateKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<Municipality[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<Municipality[]> GetMunicipalitiesByGovernmentRegionDE(Expression<Func<string>> governmentRegionKey, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_governmentRegionKey = WorkflowExpression.Compile(governmentRegionKey, nameof(governmentRegionKey), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<Municipality[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/de/GovernmentRegions/{0}/Municipalities", __workflow_governmentRegionKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<Municipality[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<Municipality[]> GetMunicipalitiesByDistrictDE(Expression<Func<string>> districtKey, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_districtKey = WorkflowExpression.Compile(districtKey, nameof(districtKey), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<Municipality[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/de/Districts/{0}/Municipalities", __workflow_districtKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<Municipality[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<MunicipalAssociation[]> GetMunicipalAssociationsByFederalStateDE(Expression<Func<string>> federalStateKey, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_federalStateKey = WorkflowExpression.Compile(federalStateKey, nameof(federalStateKey), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<MunicipalAssociation[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/de/FederalStates/{0}/MunicipalAssociations", __workflow_federalStateKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<MunicipalAssociation[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<MunicipalAssociation[]> GetMunicipalAssociationsByGovernmentRegionDE(Expression<Func<string>> governmentRegionKey, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_governmentRegionKey = WorkflowExpression.Compile(governmentRegionKey, nameof(governmentRegionKey), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<MunicipalAssociation[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/de/GovernmentRegions/{0}/MunicipalAssociations", __workflow_governmentRegionKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<MunicipalAssociation[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<MunicipalAssociation[]> GetMunicipalAssociationsByDistrictDE(Expression<Func<string>> districtKey, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_districtKey = WorkflowExpression.Compile(districtKey, nameof(districtKey), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<MunicipalAssociation[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/de/Districts/{0}/MunicipalAssociations", __workflow_districtKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<MunicipalAssociation[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<Locality[]> GetLocalitiesByFederalStateDE(Expression<Func<string>> federalStateKey, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_federalStateKey = WorkflowExpression.Compile(federalStateKey, nameof(federalStateKey), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<Locality[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/de/FederalStates/{0}/Localities", __workflow_federalStateKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<Locality[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<Locality[]> GetLocalitiesByGovernmentRegionDE(Expression<Func<string>> governmentRegionKey, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_governmentRegionKey = WorkflowExpression.Compile(governmentRegionKey, nameof(governmentRegionKey), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<Locality[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/de/GovernmentRegions/{0}/Localities", __workflow_governmentRegionKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<Locality[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<Locality[]> GetLocalitiesByDistrictDE(Expression<Func<string>> districtKey, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_districtKey = WorkflowExpression.Compile(districtKey, nameof(districtKey), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<Locality[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/de/Districts/{0}/Localities", __workflow_districtKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<Locality[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<Locality[]> SearchLocalitiesDE(Expression<Func<string>> postalCode = null, Expression<Func<string>> name = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_postalCode = WorkflowExpression.Compile(postalCode, nameof(postalCode), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<Locality[]>(() =>
            {
                var apiCallPath = "/de/Localities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_postalCode != null)
                    callPayload.Queries["postalCode"] = ExpressionConverter.Convert(__workflow_postalCode);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<Locality[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<Street[]> SearchStreetsDE(Expression<Func<string>> name = null, Expression<Func<string>> postalCode = null, Expression<Func<string>> locality = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_postalCode = WorkflowExpression.Compile(postalCode, nameof(postalCode), required: false);
            var __workflow_locality = WorkflowExpression.Compile(locality, nameof(locality), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<Street[]>(() =>
            {
                var apiCallPath = "/de/Streets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_postalCode != null)
                    callPayload.Queries["postalCode"] = ExpressionConverter.Convert(__workflow_postalCode);
                if (__workflow_locality != null)
                    callPayload.Queries["locality"] = ExpressionConverter.Convert(__workflow_locality);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<Street[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<Street[]> FullTextSearchDE(Expression<Func<string>> searchTerm, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_searchTerm = WorkflowExpression.Compile(searchTerm, nameof(searchTerm), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<Street[]>(() =>
            {
                var apiCallPath = "/de/FullTextSearch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchTerm"] = ExpressionConverter.Convert(__workflow_searchTerm);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
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
        public IBodyWorkflowAction<LocalityLI[]> SearchLocalitiesLI(Expression<Func<string>> postalCode = null, Expression<Func<string>> name = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_postalCode = WorkflowExpression.Compile(postalCode, nameof(postalCode), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<LocalityLI[]>(() =>
            {
                var apiCallPath = "/li/Localities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_postalCode != null)
                    callPayload.Queries["postalCode"] = ExpressionConverter.Convert(__workflow_postalCode);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<LocalityLI[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<StreetLI[]> SearchStreetsLI(Expression<Func<string>> name = null, Expression<Func<string>> postalCode = null, Expression<Func<string>> locality = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_postalCode = WorkflowExpression.Compile(postalCode, nameof(postalCode), required: false);
            var __workflow_locality = WorkflowExpression.Compile(locality, nameof(locality), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<StreetLI[]>(() =>
            {
                var apiCallPath = "/li/Streets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_postalCode != null)
                    callPayload.Queries["postalCode"] = ExpressionConverter.Convert(__workflow_postalCode);
                if (__workflow_locality != null)
                    callPayload.Queries["locality"] = ExpressionConverter.Convert(__workflow_locality);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<StreetLI[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<StreetLI[]> FullTextSearchLI(Expression<Func<string>> searchTerm, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_searchTerm = WorkflowExpression.Compile(searchTerm, nameof(searchTerm), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<StreetLI[]>(() =>
            {
                var apiCallPath = "/li/FullTextSearch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchTerm"] = ExpressionConverter.Convert(__workflow_searchTerm);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
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
        public IBodyWorkflowAction<DistrictCH[]> GetDistrictsByCantonCH(Expression<Func<string>> cantonKey, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_cantonKey = WorkflowExpression.Compile(cantonKey, nameof(cantonKey), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<DistrictCH[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/ch/Cantons/{0}/Districts", __workflow_cantonKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<DistrictCH[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<CommuneCH[]> GetCommunesByCantonCH(Expression<Func<string>> cantonKey, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_cantonKey = WorkflowExpression.Compile(cantonKey, nameof(cantonKey), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<CommuneCH[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/ch/Cantons/{0}/Communes", __workflow_cantonKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<CommuneCH[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<CommuneCH[]> GetCommunesByDistrictCH(Expression<Func<string>> districtKey, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_districtKey = WorkflowExpression.Compile(districtKey, nameof(districtKey), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<CommuneCH[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/ch/Districts/{0}/Communes", __workflow_districtKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<CommuneCH[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<LocalityCH[]> GetLocalitiesByCantonCH(Expression<Func<string>> cantonKey, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_cantonKey = WorkflowExpression.Compile(cantonKey, nameof(cantonKey), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<LocalityCH[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/ch/Cantons/{0}/Localities", __workflow_cantonKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<LocalityCH[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<LocalityCH[]> GetLocalitiesByDistrictCH(Expression<Func<string>> districtKey, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_districtKey = WorkflowExpression.Compile(districtKey, nameof(districtKey), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<LocalityCH[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/ch/Districts/{0}/Localities", __workflow_districtKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<LocalityCH[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<LocalityCH[]> SearchLocalitiesCH(Expression<Func<string>> postalCode = null, Expression<Func<string>> name = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_postalCode = WorkflowExpression.Compile(postalCode, nameof(postalCode), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<LocalityCH[]>(() =>
            {
                var apiCallPath = "/ch/Localities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_postalCode != null)
                    callPayload.Queries["postalCode"] = ExpressionConverter.Convert(__workflow_postalCode);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<LocalityCH[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<StreetCH[]> SearchStreetsCH(Expression<Func<string>> name = null, Expression<Func<string>> postalCode = null, Expression<Func<string>> locality = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_postalCode = WorkflowExpression.Compile(postalCode, nameof(postalCode), required: false);
            var __workflow_locality = WorkflowExpression.Compile(locality, nameof(locality), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<StreetCH[]>(() =>
            {
                var apiCallPath = "/ch/Streets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_postalCode != null)
                    callPayload.Queries["postalCode"] = ExpressionConverter.Convert(__workflow_postalCode);
                if (__workflow_locality != null)
                    callPayload.Queries["locality"] = ExpressionConverter.Convert(__workflow_locality);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<StreetCH[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<StreetCH[]> FullTextSearchCH(Expression<Func<string>> searchTerm, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_searchTerm = WorkflowExpression.Compile(searchTerm, nameof(searchTerm), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<StreetCH[]>(() =>
            {
                var apiCallPath = "/ch/FullTextSearch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchTerm"] = ExpressionConverter.Convert(__workflow_searchTerm);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
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
        public IBodyWorkflowAction<DistrictAT[]> GetDistrictsByFederalProvinceAT(Expression<Func<string>> federalProvinceKey, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_federalProvinceKey = WorkflowExpression.Compile(federalProvinceKey, nameof(federalProvinceKey), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<DistrictAT[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/at/FederalProvinces/{0}/Districts", __workflow_federalProvinceKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<DistrictAT[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<MunicipalityAT[]> GetMunicipalitiesByFederalProvinceAT(Expression<Func<string>> federalProvinceKey, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_federalProvinceKey = WorkflowExpression.Compile(federalProvinceKey, nameof(federalProvinceKey), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<MunicipalityAT[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/at/FederalProvinces/{0}/Municipalities", __workflow_federalProvinceKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<MunicipalityAT[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<MunicipalityAT[]> GetMunicipalitiesByDistrictAT(Expression<Func<string>> districtKey, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_districtKey = WorkflowExpression.Compile(districtKey, nameof(districtKey), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<MunicipalityAT[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/at/Districts/{0}/Municipalities", __workflow_districtKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<MunicipalityAT[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<LocalityAT[]> GetLocalitiesByFederalProvinceAT(Expression<Func<string>> federalProvinceKey, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_federalProvinceKey = WorkflowExpression.Compile(federalProvinceKey, nameof(federalProvinceKey), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<LocalityAT[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/at/FederalProvinces/{0}/Localities", __workflow_federalProvinceKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<LocalityAT[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<LocalityAT[]> GetLocalitiesByDistrictAT(Expression<Func<string>> districtKey, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_districtKey = WorkflowExpression.Compile(districtKey, nameof(districtKey), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<LocalityAT[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/at/Districts/{0}/Localities", __workflow_districtKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<LocalityAT[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<LocalityAT[]> SearchLocalitiesAT(Expression<Func<string>> postalCode = null, Expression<Func<string>> name = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_postalCode = WorkflowExpression.Compile(postalCode, nameof(postalCode), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<LocalityAT[]>(() =>
            {
                var apiCallPath = "/at/Localities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_postalCode != null)
                    callPayload.Queries["postalCode"] = ExpressionConverter.Convert(__workflow_postalCode);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<LocalityAT[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<StreetAT[]> SearchStreetsAT(Expression<Func<string>> name = null, Expression<Func<string>> postalCode = null, Expression<Func<string>> locality = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_postalCode = WorkflowExpression.Compile(postalCode, nameof(postalCode), required: false);
            var __workflow_locality = WorkflowExpression.Compile(locality, nameof(locality), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<StreetAT[]>(() =>
            {
                var apiCallPath = "/at/Streets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_postalCode != null)
                    callPayload.Queries["postalCode"] = ExpressionConverter.Convert(__workflow_postalCode);
                if (__workflow_locality != null)
                    callPayload.Queries["locality"] = ExpressionConverter.Convert(__workflow_locality);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<StreetAT[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<StreetAT[]> FullTextSearchAT(Expression<Func<string>> searchTerm, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_searchTerm = WorkflowExpression.Compile(searchTerm, nameof(searchTerm), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<StreetAT[]>(() =>
            {
                var apiCallPath = "/at/FullTextSearch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchTerm"] = ExpressionConverter.Convert(__workflow_searchTerm);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
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
