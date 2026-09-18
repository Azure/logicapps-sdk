//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openplz
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpenplzActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<FederalState[]> GetFederalStatesDE()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/de/FederalStates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FederalState[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<GovernmentRegion[]> GetGovernmentRegionsByFederalStateDE([WorkflowExpression] Func<string> federalStateKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(federalStateKey, nameof(federalStateKey), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/de/FederalStates/{0}/GovernmentRegions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(federalStateKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<GovernmentRegion[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<District[]> GetDistrictsByFederalStateDE([WorkflowExpression] Func<string> federalStateKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(federalStateKey, nameof(federalStateKey), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/de/FederalStates/{0}/Districts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(federalStateKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<District[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<District[]> GetDistrictsByGovernmentRegionDE([WorkflowExpression] Func<string> governmentRegionKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(governmentRegionKey, nameof(governmentRegionKey), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/de/GovernmentRegions/{0}/Districts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(governmentRegionKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<District[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<Municipality[]> GetMunicipalitiesByFederalStateDE([WorkflowExpression] Func<string> federalStateKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(federalStateKey, nameof(federalStateKey), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/de/FederalStates/{0}/Municipalities", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(federalStateKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<Municipality[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<Municipality[]> GetMunicipalitiesByGovernmentRegionDE([WorkflowExpression] Func<string> governmentRegionKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(governmentRegionKey, nameof(governmentRegionKey), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/de/GovernmentRegions/{0}/Municipalities", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(governmentRegionKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<Municipality[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<Municipality[]> GetMunicipalitiesByDistrictDE([WorkflowExpression] Func<string> districtKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(districtKey, nameof(districtKey), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/de/Districts/{0}/Municipalities", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(districtKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<Municipality[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<MunicipalAssociation[]> GetMunicipalAssociationsByFederalStateDE([WorkflowExpression] Func<string> federalStateKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(federalStateKey, nameof(federalStateKey), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/de/FederalStates/{0}/MunicipalAssociations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(federalStateKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<MunicipalAssociation[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<MunicipalAssociation[]> GetMunicipalAssociationsByGovernmentRegionDE([WorkflowExpression] Func<string> governmentRegionKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(governmentRegionKey, nameof(governmentRegionKey), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/de/GovernmentRegions/{0}/MunicipalAssociations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(governmentRegionKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<MunicipalAssociation[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<MunicipalAssociation[]> GetMunicipalAssociationsByDistrictDE([WorkflowExpression] Func<string> districtKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(districtKey, nameof(districtKey), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/de/Districts/{0}/MunicipalAssociations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(districtKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<MunicipalAssociation[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<Locality[]> GetLocalitiesByFederalStateDE([WorkflowExpression] Func<string> federalStateKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(federalStateKey, nameof(federalStateKey), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/de/FederalStates/{0}/Localities", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(federalStateKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<Locality[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<Locality[]> GetLocalitiesByGovernmentRegionDE([WorkflowExpression] Func<string> governmentRegionKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(governmentRegionKey, nameof(governmentRegionKey), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/de/GovernmentRegions/{0}/Localities", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(governmentRegionKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<Locality[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<Locality[]> GetLocalitiesByDistrictDE([WorkflowExpression] Func<string> districtKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(districtKey, nameof(districtKey), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/de/Districts/{0}/Localities", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(districtKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<Locality[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<Locality[]> SearchLocalitiesDE([WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(postalCode, nameof(postalCode), required: false);
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/de/Localities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (postalCode != null)
                    callPayload.Queries["postalCode"] = SourceExpressionConverter.ConvertO(postalCode);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<Locality[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<Street[]> SearchStreetsDE([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> locality = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(postalCode, nameof(postalCode), required: false);
            SourceExpression.Validate(locality, nameof(locality), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/de/Streets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (postalCode != null)
                    callPayload.Queries["postalCode"] = SourceExpressionConverter.ConvertO(postalCode);
                if (locality != null)
                    callPayload.Queries["locality"] = SourceExpressionConverter.ConvertO(locality);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<Street[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<Street[]> FullTextSearchDE([WorkflowExpression] Func<string> searchTerm, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(searchTerm, nameof(searchTerm), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/de/FullTextSearch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchTerm"] = SourceExpressionConverter.ConvertO(searchTerm);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<Street[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<CommuneLI[]> GetCommunesLI()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/li/Communes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CommuneLI[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<LocalityLI[]> SearchLocalitiesLI([WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(postalCode, nameof(postalCode), required: false);
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/li/Localities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (postalCode != null)
                    callPayload.Queries["postalCode"] = SourceExpressionConverter.ConvertO(postalCode);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<LocalityLI[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<StreetLI[]> SearchStreetsLI([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> locality = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(postalCode, nameof(postalCode), required: false);
            SourceExpression.Validate(locality, nameof(locality), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/li/Streets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (postalCode != null)
                    callPayload.Queries["postalCode"] = SourceExpressionConverter.ConvertO(postalCode);
                if (locality != null)
                    callPayload.Queries["locality"] = SourceExpressionConverter.ConvertO(locality);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<StreetLI[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<StreetLI[]> FullTextSearchLI([WorkflowExpression] Func<string> searchTerm, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(searchTerm, nameof(searchTerm), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/li/FullTextSearch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchTerm"] = SourceExpressionConverter.ConvertO(searchTerm);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<StreetLI[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<CantonCH[]> GetCantonsCH()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ch/Cantons";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CantonCH[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<DistrictCH[]> GetDistrictsByCantonCH([WorkflowExpression] Func<string> cantonKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(cantonKey, nameof(cantonKey), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/ch/Cantons/{0}/Districts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cantonKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<DistrictCH[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<CommuneCH[]> GetCommunesByCantonCH([WorkflowExpression] Func<string> cantonKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(cantonKey, nameof(cantonKey), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/ch/Cantons/{0}/Communes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cantonKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<CommuneCH[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<CommuneCH[]> GetCommunesByDistrictCH([WorkflowExpression] Func<string> districtKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(districtKey, nameof(districtKey), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/ch/Districts/{0}/Communes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(districtKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<CommuneCH[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<LocalityCH[]> GetLocalitiesByCantonCH([WorkflowExpression] Func<string> cantonKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(cantonKey, nameof(cantonKey), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/ch/Cantons/{0}/Localities", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cantonKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<LocalityCH[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<LocalityCH[]> GetLocalitiesByDistrictCH([WorkflowExpression] Func<string> districtKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(districtKey, nameof(districtKey), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/ch/Districts/{0}/Localities", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(districtKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<LocalityCH[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<LocalityCH[]> SearchLocalitiesCH([WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(postalCode, nameof(postalCode), required: false);
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ch/Localities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (postalCode != null)
                    callPayload.Queries["postalCode"] = SourceExpressionConverter.ConvertO(postalCode);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<LocalityCH[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<StreetCH[]> SearchStreetsCH([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> locality = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(postalCode, nameof(postalCode), required: false);
            SourceExpression.Validate(locality, nameof(locality), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ch/Streets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (postalCode != null)
                    callPayload.Queries["postalCode"] = SourceExpressionConverter.ConvertO(postalCode);
                if (locality != null)
                    callPayload.Queries["locality"] = SourceExpressionConverter.ConvertO(locality);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<StreetCH[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<StreetCH[]> FullTextSearchCH([WorkflowExpression] Func<string> searchTerm, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(searchTerm, nameof(searchTerm), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ch/FullTextSearch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchTerm"] = SourceExpressionConverter.ConvertO(searchTerm);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<StreetCH[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<FederalProvinceAT[]> GetFederalProvincesAT()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/at/FederalProvinces";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FederalProvinceAT[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<DistrictAT[]> GetDistrictsByFederalProvinceAT([WorkflowExpression] Func<string> federalProvinceKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(federalProvinceKey, nameof(federalProvinceKey), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/at/FederalProvinces/{0}/Districts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(federalProvinceKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<DistrictAT[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<MunicipalityAT[]> GetMunicipalitiesByFederalProvinceAT([WorkflowExpression] Func<string> federalProvinceKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(federalProvinceKey, nameof(federalProvinceKey), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/at/FederalProvinces/{0}/Municipalities", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(federalProvinceKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<MunicipalityAT[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<MunicipalityAT[]> GetMunicipalitiesByDistrictAT([WorkflowExpression] Func<string> districtKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(districtKey, nameof(districtKey), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/at/Districts/{0}/Municipalities", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(districtKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<MunicipalityAT[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<LocalityAT[]> GetLocalitiesByFederalProvinceAT([WorkflowExpression] Func<string> federalProvinceKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(federalProvinceKey, nameof(federalProvinceKey), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/at/FederalProvinces/{0}/Localities", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(federalProvinceKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<LocalityAT[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<LocalityAT[]> GetLocalitiesByDistrictAT([WorkflowExpression] Func<string> districtKey, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(districtKey, nameof(districtKey), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/at/Districts/{0}/Localities", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(districtKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<LocalityAT[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<LocalityAT[]> SearchLocalitiesAT([WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(postalCode, nameof(postalCode), required: false);
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/at/Localities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (postalCode != null)
                    callPayload.Queries["postalCode"] = SourceExpressionConverter.ConvertO(postalCode);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<LocalityAT[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<StreetAT[]> SearchStreetsAT([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> locality = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(postalCode, nameof(postalCode), required: false);
            SourceExpression.Validate(locality, nameof(locality), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/at/Streets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (postalCode != null)
                    callPayload.Queries["postalCode"] = SourceExpressionConverter.ConvertO(postalCode);
                if (locality != null)
                    callPayload.Queries["locality"] = SourceExpressionConverter.ConvertO(locality);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<StreetAT[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openplz")]
        public IBodyWorkflowAction<StreetAT[]> FullTextSearchAT([WorkflowExpression] Func<string> searchTerm, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(searchTerm, nameof(searchTerm), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/at/FullTextSearch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchTerm"] = SourceExpressionConverter.ConvertO(searchTerm);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<StreetAT[]>(BuildSourceInput);
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