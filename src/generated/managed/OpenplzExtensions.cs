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
        public IBodyWorkflowAction<GovernmentRegion[]> GetGovernmentRegionsByFederalStateDE([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> federalStateKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            var apiCallPath = String.Format("/de/FederalStates/{0}/GovernmentRegions", ExpressionConverter.ConvertWithUrlEncoding(federalStateKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<GovernmentRegion[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<District[]> GetDistrictsByFederalStateDE([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> federalStateKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            var apiCallPath = String.Format("/de/FederalStates/{0}/Districts", ExpressionConverter.ConvertWithUrlEncoding(federalStateKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<District[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<District[]> GetDistrictsByGovernmentRegionDE([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> governmentRegionKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            var apiCallPath = String.Format("/de/GovernmentRegions/{0}/Districts", ExpressionConverter.ConvertWithUrlEncoding(governmentRegionKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<District[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<Municipality[]> GetMunicipalitiesByFederalStateDE([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> federalStateKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            var apiCallPath = String.Format("/de/FederalStates/{0}/Municipalities", ExpressionConverter.ConvertWithUrlEncoding(federalStateKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<Municipality[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<Municipality[]> GetMunicipalitiesByGovernmentRegionDE([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> governmentRegionKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            var apiCallPath = String.Format("/de/GovernmentRegions/{0}/Municipalities", ExpressionConverter.ConvertWithUrlEncoding(governmentRegionKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<Municipality[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<Municipality[]> GetMunicipalitiesByDistrictDE([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> districtKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            var apiCallPath = String.Format("/de/Districts/{0}/Municipalities", ExpressionConverter.ConvertWithUrlEncoding(districtKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<Municipality[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<MunicipalAssociation[]> GetMunicipalAssociationsByFederalStateDE([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> federalStateKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            var apiCallPath = String.Format("/de/FederalStates/{0}/MunicipalAssociations", ExpressionConverter.ConvertWithUrlEncoding(federalStateKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<MunicipalAssociation[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<MunicipalAssociation[]> GetMunicipalAssociationsByGovernmentRegionDE([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> governmentRegionKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            var apiCallPath = String.Format("/de/GovernmentRegions/{0}/MunicipalAssociations", ExpressionConverter.ConvertWithUrlEncoding(governmentRegionKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<MunicipalAssociation[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<MunicipalAssociation[]> GetMunicipalAssociationsByDistrictDE([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> districtKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            var apiCallPath = String.Format("/de/Districts/{0}/MunicipalAssociations", ExpressionConverter.ConvertWithUrlEncoding(districtKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<MunicipalAssociation[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<Locality[]> GetLocalitiesByFederalStateDE([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> federalStateKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            var apiCallPath = String.Format("/de/FederalStates/{0}/Localities", ExpressionConverter.ConvertWithUrlEncoding(federalStateKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<Locality[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<Locality[]> GetLocalitiesByGovernmentRegionDE([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> governmentRegionKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            var apiCallPath = String.Format("/de/GovernmentRegions/{0}/Localities", ExpressionConverter.ConvertWithUrlEncoding(governmentRegionKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<Locality[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<Locality[]> GetLocalitiesByDistrictDE([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> districtKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            var apiCallPath = String.Format("/de/Districts/{0}/Localities", ExpressionConverter.ConvertWithUrlEncoding(districtKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<Locality[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<Locality[]> SearchLocalitiesDE([WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<Street[]> SearchStreetsDE([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> locality = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<Street[]> FullTextSearchDE([WorkflowExpression] Func<string> searchTerm, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
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
        public IBodyWorkflowAction<LocalityLI[]> SearchLocalitiesLI([WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<StreetLI[]> SearchStreetsLI([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> locality = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<StreetLI[]> FullTextSearchLI([WorkflowExpression] Func<string> searchTerm, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
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
        public IBodyWorkflowAction<DistrictCH[]> GetDistrictsByCantonCH([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> cantonKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            var apiCallPath = String.Format("/ch/Cantons/{0}/Districts", ExpressionConverter.ConvertWithUrlEncoding(cantonKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<DistrictCH[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<CommuneCH[]> GetCommunesByCantonCH([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> cantonKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            var apiCallPath = String.Format("/ch/Cantons/{0}/Communes", ExpressionConverter.ConvertWithUrlEncoding(cantonKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<CommuneCH[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<CommuneCH[]> GetCommunesByDistrictCH([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> districtKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            var apiCallPath = String.Format("/ch/Districts/{0}/Communes", ExpressionConverter.ConvertWithUrlEncoding(districtKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<CommuneCH[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<LocalityCH[]> GetLocalitiesByCantonCH([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> cantonKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            var apiCallPath = String.Format("/ch/Cantons/{0}/Localities", ExpressionConverter.ConvertWithUrlEncoding(cantonKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<LocalityCH[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<LocalityCH[]> GetLocalitiesByDistrictCH([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> districtKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            var apiCallPath = String.Format("/ch/Districts/{0}/Localities", ExpressionConverter.ConvertWithUrlEncoding(districtKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<LocalityCH[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<LocalityCH[]> SearchLocalitiesCH([WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<StreetCH[]> SearchStreetsCH([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> locality = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<StreetCH[]> FullTextSearchCH([WorkflowExpression] Func<string> searchTerm, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
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
        public IBodyWorkflowAction<DistrictAT[]> GetDistrictsByFederalProvinceAT([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> federalProvinceKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            var apiCallPath = String.Format("/at/FederalProvinces/{0}/Districts", ExpressionConverter.ConvertWithUrlEncoding(federalProvinceKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<DistrictAT[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<MunicipalityAT[]> GetMunicipalitiesByFederalProvinceAT([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> federalProvinceKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            var apiCallPath = String.Format("/at/FederalProvinces/{0}/Municipalities", ExpressionConverter.ConvertWithUrlEncoding(federalProvinceKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<MunicipalityAT[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<MunicipalityAT[]> GetMunicipalitiesByDistrictAT([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> districtKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            var apiCallPath = String.Format("/at/Districts/{0}/Municipalities", ExpressionConverter.ConvertWithUrlEncoding(districtKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<MunicipalityAT[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<LocalityAT[]> GetLocalitiesByFederalProvinceAT([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> federalProvinceKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            var apiCallPath = String.Format("/at/FederalProvinces/{0}/Localities", ExpressionConverter.ConvertWithUrlEncoding(federalProvinceKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<LocalityAT[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<LocalityAT[]> GetLocalitiesByDistrictAT([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> districtKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            var apiCallPath = String.Format("/at/Districts/{0}/Localities", ExpressionConverter.ConvertWithUrlEncoding(districtKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(pageSize);
            return new ApiConnectionAction<LocalityAT[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<LocalityAT[]> SearchLocalitiesAT([WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<StreetAT[]> SearchStreetsAT([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> locality = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<StreetAT[]> FullTextSearchAT([WorkflowExpression] Func<string> searchTerm, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
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