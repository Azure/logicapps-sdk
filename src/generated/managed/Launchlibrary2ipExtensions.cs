//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Launchlibrary2ip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Launchlibrary2ipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<AgenciesListResponse> AgenciesList([WorkflowExpression] Func<bool> featured = null, [WorkflowExpression] Func<string> agencyType = null, [WorkflowExpression] Func<string> countryCode = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/agencies/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (featured != null)
                    callPayload.Queries["featured"] = SourceExpressionConverter.ConvertO(featured);
                if (agencyType != null)
                    callPayload.Queries["agency_type"] = SourceExpressionConverter.ConvertO(agencyType);
                if (countryCode != null)
                    callPayload.Queries["country_code"] = SourceExpressionConverter.ConvertO(countryCode);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<AgenciesListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<AgencySerializerDetailed> AgenciesRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/agencies/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AgencySerializerDetailed>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<AstronautListResponse> AstronautList([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> nationality = null, [WorkflowExpression] Func<string> dateOfDeath = null, [WorkflowExpression] Func<string> agencyAbbrev = null, [WorkflowExpression] Func<string> agencyName = null, [WorkflowExpression] Func<string> dateOfBirth = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> dateOfBirthGt = null, [WorkflowExpression] Func<string> dateOfBirthLt = null, [WorkflowExpression] Func<string> dateOfBirthGte = null, [WorkflowExpression] Func<string> dateOfBirthLte = null, [WorkflowExpression] Func<string> dateOfDeathGt = null, [WorkflowExpression] Func<string> dateOfDeathLt = null, [WorkflowExpression] Func<string> dateOfDeathGte = null, [WorkflowExpression] Func<string> dateOfDeathLte = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/astronaut/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (nationality != null)
                    callPayload.Queries["nationality"] = SourceExpressionConverter.ConvertO(nationality);
                if (dateOfDeath != null)
                    callPayload.Queries["date_of_death"] = SourceExpressionConverter.ConvertO(dateOfDeath);
                if (agencyAbbrev != null)
                    callPayload.Queries["agency__abbrev"] = SourceExpressionConverter.ConvertO(agencyAbbrev);
                if (agencyName != null)
                    callPayload.Queries["agency__name"] = SourceExpressionConverter.ConvertO(agencyName);
                if (dateOfBirth != null)
                    callPayload.Queries["date_of_birth"] = SourceExpressionConverter.ConvertO(dateOfBirth);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                if (dateOfBirthGt != null)
                    callPayload.Queries["date_of_birth__gt"] = SourceExpressionConverter.ConvertO(dateOfBirthGt);
                if (dateOfBirthLt != null)
                    callPayload.Queries["date_of_birth__lt"] = SourceExpressionConverter.ConvertO(dateOfBirthLt);
                if (dateOfBirthGte != null)
                    callPayload.Queries["date_of_birth__gte"] = SourceExpressionConverter.ConvertO(dateOfBirthGte);
                if (dateOfBirthLte != null)
                    callPayload.Queries["date_of_birth__lte"] = SourceExpressionConverter.ConvertO(dateOfBirthLte);
                if (dateOfDeathGt != null)
                    callPayload.Queries["date_of_death__gt"] = SourceExpressionConverter.ConvertO(dateOfDeathGt);
                if (dateOfDeathLt != null)
                    callPayload.Queries["date_of_death__lt"] = SourceExpressionConverter.ConvertO(dateOfDeathLt);
                if (dateOfDeathGte != null)
                    callPayload.Queries["date_of_death__gte"] = SourceExpressionConverter.ConvertO(dateOfDeathGte);
                if (dateOfDeathLte != null)
                    callPayload.Queries["date_of_death__lte"] = SourceExpressionConverter.ConvertO(dateOfDeathLte);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<AstronautListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<AstronautDetailed> AstronautRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/astronaut/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AstronautDetailed>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigAgencytypeListResponse> ConfigAgencytypeList([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/config/agencytype/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ConfigAgencytypeListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<AgencyType> ConfigAgencytypeRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/config/agencytype/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AgencyType>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigAstronautroleListResponse> ConfigAstronautroleList([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/config/astronautrole/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ConfigAstronautroleListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<AstronautRole> ConfigAstronautroleRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/config/astronautrole/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AstronautRole>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigAstronautstatusListResponse> ConfigAstronautstatusList([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/config/astronautstatus/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ConfigAstronautstatusListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<AstronautStatus> ConfigAstronautstatusRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/config/astronautstatus/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AstronautStatus>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigAstronauttypeListResponse> ConfigAstronauttypeList([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/config/astronauttype/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ConfigAstronauttypeListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<AstronautType> ConfigAstronauttypeRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/config/astronauttype/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AstronautType>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigDockinglocationListResponse> ConfigDockinglocationList([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/config/dockinglocation/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ConfigDockinglocationListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<DockingLocation> ConfigDockinglocationRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/config/dockinglocation/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DockingLocation>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigEventtypeListResponse> ConfigEventtypeList([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/config/eventtype/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ConfigEventtypeListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<EventType> ConfigEventtypeRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/config/eventtype/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<EventType>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigFirststagetypeListResponse> ConfigFirststagetypeList([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/config/firststagetype/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ConfigFirststagetypeListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<FirstStageType> ConfigFirststagetypeRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/config/firststagetype/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FirstStageType>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigLandinglocationListResponse> ConfigLandinglocationList([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/config/landinglocation/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ConfigLandinglocationListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LandingLocation> ConfigLandinglocationRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/config/landinglocation/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LandingLocation>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigLauncherListResponse> ConfigLauncherList([WorkflowExpression] Func<string> family = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> manufacturer = null, [WorkflowExpression] Func<string> fullName = null, [WorkflowExpression] Func<string> active = null, [WorkflowExpression] Func<string> reusable = null, [WorkflowExpression] Func<string> program = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/config/launcher/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (family != null)
                    callPayload.Queries["family"] = SourceExpressionConverter.ConvertO(family);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (manufacturer != null)
                    callPayload.Queries["manufacturer"] = SourceExpressionConverter.ConvertO(manufacturer);
                if (fullName != null)
                    callPayload.Queries["full_name"] = SourceExpressionConverter.ConvertO(fullName);
                if (active != null)
                    callPayload.Queries["active"] = SourceExpressionConverter.ConvertO(active);
                if (reusable != null)
                    callPayload.Queries["reusable"] = SourceExpressionConverter.ConvertO(reusable);
                if (program != null)
                    callPayload.Queries["program"] = SourceExpressionConverter.ConvertO(program);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ConfigLauncherListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LauncherConfigDetail> ConfigLauncherRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/config/launcher/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LauncherConfigDetail>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigLaunchstatusListResponse> ConfigLaunchstatusList([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/config/launchstatus/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ConfigLaunchstatusListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LaunchStatus> ConfigLaunchstatusRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/config/launchstatus/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LaunchStatus>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigMissiontypeListResponse> ConfigMissiontypeList([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/config/missiontype/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ConfigMissiontypeListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<MissionType> ConfigMissiontypeRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/config/missiontype/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MissionType>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigNoticetypeListResponse> ConfigNoticetypeList([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/config/noticetype/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ConfigNoticetypeListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<NoticeType> ConfigNoticetypeRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/config/noticetype/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<NoticeType>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigOrbitListResponse> ConfigOrbitList([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/config/orbit/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ConfigOrbitListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<Orbit> ConfigOrbitRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/config/orbit/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Orbit>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigRoadclosurestatusListResponse> ConfigRoadclosurestatusList([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/config/roadclosurestatus/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ConfigRoadclosurestatusListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<RoadClosureStatus> ConfigRoadclosurestatusRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/config/roadclosurestatus/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<RoadClosureStatus>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigSpacecraftListResponse> ConfigSpacecraftList([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> manufacturer = null, [WorkflowExpression] Func<string> inUse = null, [WorkflowExpression] Func<string> humanRated = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/config/spacecraft/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (manufacturer != null)
                    callPayload.Queries["manufacturer"] = SourceExpressionConverter.ConvertO(manufacturer);
                if (inUse != null)
                    callPayload.Queries["in_use"] = SourceExpressionConverter.ConvertO(inUse);
                if (humanRated != null)
                    callPayload.Queries["human_rated"] = SourceExpressionConverter.ConvertO(humanRated);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ConfigSpacecraftListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<SpacecraftConfigurationDetail> ConfigSpacecraftRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/config/spacecraft/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SpacecraftConfigurationDetail>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigSpacecraftstatusListResponse> ConfigSpacecraftstatusList([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/config/spacecraftstatus/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ConfigSpacecraftstatusListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<SpacecraftStatus> ConfigSpacecraftstatusRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/config/spacecraftstatus/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SpacecraftStatus>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigSpacestationstatusListResponse> ConfigSpacestationstatusList([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/config/spacestationstatus/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ConfigSpacestationstatusListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<SpaceStationStatus> ConfigSpacestationstatusRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/config/spacestationstatus/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SpaceStationStatus>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<DockingEventListResponse> DockingEventList([WorkflowExpression] Func<double> spaceStationId = null, [WorkflowExpression] Func<double> dockingLocationId = null, [WorkflowExpression] Func<double> flightVehicleId = null, [WorkflowExpression] Func<string> dockingGt = null, [WorkflowExpression] Func<string> dockingLt = null, [WorkflowExpression] Func<string> dockingGte = null, [WorkflowExpression] Func<string> dockingLte = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/docking_event/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (spaceStationId != null)
                    callPayload.Queries["space_station__id"] = SourceExpressionConverter.ConvertO(spaceStationId);
                if (dockingLocationId != null)
                    callPayload.Queries["docking_location__id"] = SourceExpressionConverter.ConvertO(dockingLocationId);
                if (flightVehicleId != null)
                    callPayload.Queries["flight_vehicle__id"] = SourceExpressionConverter.ConvertO(flightVehicleId);
                if (dockingGt != null)
                    callPayload.Queries["docking__gt"] = SourceExpressionConverter.ConvertO(dockingGt);
                if (dockingLt != null)
                    callPayload.Queries["docking__lt"] = SourceExpressionConverter.ConvertO(dockingLt);
                if (dockingGte != null)
                    callPayload.Queries["docking__gte"] = SourceExpressionConverter.ConvertO(dockingGte);
                if (dockingLte != null)
                    callPayload.Queries["docking__lte"] = SourceExpressionConverter.ConvertO(dockingLte);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<DockingEventListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<DockingEventDetailed> DockingEventRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/docking_event/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DockingEventDetailed>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<EventListResponse> EventList([WorkflowExpression] Func<string> slug = null, [WorkflowExpression] Func<double> id = null, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<string> program = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/event/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (slug != null)
                    callPayload.Queries["slug"] = SourceExpressionConverter.ConvertO(slug);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                if (program != null)
                    callPayload.Queries["program"] = SourceExpressionConverter.ConvertO(program);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<EventListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<EventPreviousListResponse> EventPreviousList([WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<string> program = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/event/previous/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                if (program != null)
                    callPayload.Queries["program"] = SourceExpressionConverter.ConvertO(program);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<EventPreviousListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<Events> EventPreviousRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/previous/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Events>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<EventUpcomingListResponse> EventUpcomingList([WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<string> program = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/event/upcoming/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                if (program != null)
                    callPayload.Queries["program"] = SourceExpressionConverter.ConvertO(program);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<EventUpcomingListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<Events> EventUpcomingRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/upcoming/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Events>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<Events> EventRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/event/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Events>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ExpeditionListResponse> ExpeditionList([WorkflowExpression] Func<string> crewAstronaut = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> spaceStation = null, [WorkflowExpression] Func<string> crewAstronautAgency = null, [WorkflowExpression] Func<string> startGt = null, [WorkflowExpression] Func<string> startLt = null, [WorkflowExpression] Func<string> startGte = null, [WorkflowExpression] Func<string> startLte = null, [WorkflowExpression] Func<string> endGt = null, [WorkflowExpression] Func<string> endLt = null, [WorkflowExpression] Func<string> endGte = null, [WorkflowExpression] Func<string> endLte = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/expedition/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (crewAstronaut != null)
                    callPayload.Queries["crew__astronaut"] = SourceExpressionConverter.ConvertO(crewAstronaut);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (spaceStation != null)
                    callPayload.Queries["space_station"] = SourceExpressionConverter.ConvertO(spaceStation);
                if (crewAstronautAgency != null)
                    callPayload.Queries["crew__astronaut__agency"] = SourceExpressionConverter.ConvertO(crewAstronautAgency);
                if (startGt != null)
                    callPayload.Queries["start__gt"] = SourceExpressionConverter.ConvertO(startGt);
                if (startLt != null)
                    callPayload.Queries["start__lt"] = SourceExpressionConverter.ConvertO(startLt);
                if (startGte != null)
                    callPayload.Queries["start__gte"] = SourceExpressionConverter.ConvertO(startGte);
                if (startLte != null)
                    callPayload.Queries["start__lte"] = SourceExpressionConverter.ConvertO(startLte);
                if (endGt != null)
                    callPayload.Queries["end__gt"] = SourceExpressionConverter.ConvertO(endGt);
                if (endLt != null)
                    callPayload.Queries["end__lt"] = SourceExpressionConverter.ConvertO(endLt);
                if (endGte != null)
                    callPayload.Queries["end__gte"] = SourceExpressionConverter.ConvertO(endGte);
                if (endLte != null)
                    callPayload.Queries["end__lte"] = SourceExpressionConverter.ConvertO(endLte);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ExpeditionListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ExpeditionDetail> ExpeditionRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/expedition/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ExpeditionDetail>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<UplistResponse> Uplist([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> slug = null, [WorkflowExpression] Func<string> rocketConfigurationName = null, [WorkflowExpression] Func<double> rocketConfigurationId = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> rocketSpacecraftflightSpacecraftName = null, [WorkflowExpression] Func<string> rocketSpacecraftflightSpacecraftNameIcontains = null, [WorkflowExpression] Func<double> rocketSpacecraftflightSpacecraftId = null, [WorkflowExpression] Func<string> rocketConfigurationManufacturerName = null, [WorkflowExpression] Func<string> rocketConfigurationManufacturerNameIcontains = null, [WorkflowExpression] Func<string> rocketConfigurationFullName = null, [WorkflowExpression] Func<string> rocketConfigurationFullNameIcontains = null, [WorkflowExpression] Func<string> missionOrbitName = null, [WorkflowExpression] Func<string> missionOrbitNameIcontains = null, [WorkflowExpression] Func<string> rSpacexApiId = null, [WorkflowExpression] Func<string> netGt = null, [WorkflowExpression] Func<string> netLt = null, [WorkflowExpression] Func<string> netGte = null, [WorkflowExpression] Func<string> netLte = null, [WorkflowExpression] Func<string> windowStartGt = null, [WorkflowExpression] Func<string> windowStartLt = null, [WorkflowExpression] Func<string> windowStartGte = null, [WorkflowExpression] Func<string> windowStartLte = null, [WorkflowExpression] Func<string> windowEndGt = null, [WorkflowExpression] Func<string> windowEndLt = null, [WorkflowExpression] Func<string> windowEndGte = null, [WorkflowExpression] Func<string> windowEndLte = null, [WorkflowExpression] Func<string> lastUpdatedGte = null, [WorkflowExpression] Func<string> lastUpdatedLte = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int[]> locationIds = null, [WorkflowExpression] Func<int[]> lspIds = null, [WorkflowExpression] Func<bool> isCrewed = null, [WorkflowExpression] Func<bool> includeSuborbital = null, [WorkflowExpression] Func<string> serialNumber = null, [WorkflowExpression] Func<string> lspName = null, [WorkflowExpression] Func<int> lspId = null, [WorkflowExpression] Func<int> lspConfigId = null, [WorkflowExpression] Func<int[]> spacecraftConfigIds = null, [WorkflowExpression] Func<bool> related = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/launch/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (slug != null)
                    callPayload.Queries["slug"] = SourceExpressionConverter.ConvertO(slug);
                if (rocketConfigurationName != null)
                    callPayload.Queries["rocket__configuration__name"] = SourceExpressionConverter.ConvertO(rocketConfigurationName);
                if (rocketConfigurationId != null)
                    callPayload.Queries["rocket__configuration__id"] = SourceExpressionConverter.ConvertO(rocketConfigurationId);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                if (rocketSpacecraftflightSpacecraftName != null)
                    callPayload.Queries["rocket__spacecraftflight__spacecraft__name"] = SourceExpressionConverter.ConvertO(rocketSpacecraftflightSpacecraftName);
                if (rocketSpacecraftflightSpacecraftNameIcontains != null)
                    callPayload.Queries["rocket__spacecraftflight__spacecraft__name__icontains"] = SourceExpressionConverter.ConvertO(rocketSpacecraftflightSpacecraftNameIcontains);
                if (rocketSpacecraftflightSpacecraftId != null)
                    callPayload.Queries["rocket__spacecraftflight__spacecraft__id"] = SourceExpressionConverter.ConvertO(rocketSpacecraftflightSpacecraftId);
                if (rocketConfigurationManufacturerName != null)
                    callPayload.Queries["rocket__configuration__manufacturer__name"] = SourceExpressionConverter.ConvertO(rocketConfigurationManufacturerName);
                if (rocketConfigurationManufacturerNameIcontains != null)
                    callPayload.Queries["rocket__configuration__manufacturer__name__icontains"] = SourceExpressionConverter.ConvertO(rocketConfigurationManufacturerNameIcontains);
                if (rocketConfigurationFullName != null)
                    callPayload.Queries["rocket__configuration__full_name"] = SourceExpressionConverter.ConvertO(rocketConfigurationFullName);
                if (rocketConfigurationFullNameIcontains != null)
                    callPayload.Queries["rocket__configuration__full_name__icontains"] = SourceExpressionConverter.ConvertO(rocketConfigurationFullNameIcontains);
                if (missionOrbitName != null)
                    callPayload.Queries["mission__orbit__name"] = SourceExpressionConverter.ConvertO(missionOrbitName);
                if (missionOrbitNameIcontains != null)
                    callPayload.Queries["mission__orbit__name__icontains"] = SourceExpressionConverter.ConvertO(missionOrbitNameIcontains);
                if (rSpacexApiId != null)
                    callPayload.Queries["r_spacex_api_id"] = SourceExpressionConverter.ConvertO(rSpacexApiId);
                if (netGt != null)
                    callPayload.Queries["net__gt"] = SourceExpressionConverter.ConvertO(netGt);
                if (netLt != null)
                    callPayload.Queries["net__lt"] = SourceExpressionConverter.ConvertO(netLt);
                if (netGte != null)
                    callPayload.Queries["net__gte"] = SourceExpressionConverter.ConvertO(netGte);
                if (netLte != null)
                    callPayload.Queries["net__lte"] = SourceExpressionConverter.ConvertO(netLte);
                if (windowStartGt != null)
                    callPayload.Queries["window_start__gt"] = SourceExpressionConverter.ConvertO(windowStartGt);
                if (windowStartLt != null)
                    callPayload.Queries["window_start__lt"] = SourceExpressionConverter.ConvertO(windowStartLt);
                if (windowStartGte != null)
                    callPayload.Queries["window_start__gte"] = SourceExpressionConverter.ConvertO(windowStartGte);
                if (windowStartLte != null)
                    callPayload.Queries["window_start__lte"] = SourceExpressionConverter.ConvertO(windowStartLte);
                if (windowEndGt != null)
                    callPayload.Queries["window_end__gt"] = SourceExpressionConverter.ConvertO(windowEndGt);
                if (windowEndLt != null)
                    callPayload.Queries["window_end__lt"] = SourceExpressionConverter.ConvertO(windowEndLt);
                if (windowEndGte != null)
                    callPayload.Queries["window_end__gte"] = SourceExpressionConverter.ConvertO(windowEndGte);
                if (windowEndLte != null)
                    callPayload.Queries["window_end__lte"] = SourceExpressionConverter.ConvertO(windowEndLte);
                if (lastUpdatedGte != null)
                    callPayload.Queries["last_updated__gte"] = SourceExpressionConverter.ConvertO(lastUpdatedGte);
                if (lastUpdatedLte != null)
                    callPayload.Queries["last_updated__lte"] = SourceExpressionConverter.ConvertO(lastUpdatedLte);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (locationIds != null)
                    callPayload.Queries["location__ids"] = SourceExpressionConverter.ConvertO(locationIds);
                if (lspIds != null)
                    callPayload.Queries["lsp__ids"] = SourceExpressionConverter.ConvertO(lspIds);
                callPayload.Queries["is_crewed"] = Convert.ToString(false);
                if (isCrewed != null)
                    callPayload.Queries["is_crewed"] = SourceExpressionConverter.ConvertO(isCrewed);
                callPayload.Queries["include_suborbital"] = Convert.ToString(true);
                if (includeSuborbital != null)
                    callPayload.Queries["include_suborbital"] = SourceExpressionConverter.ConvertO(includeSuborbital);
                if (serialNumber != null)
                    callPayload.Queries["serial_number"] = SourceExpressionConverter.ConvertO(serialNumber);
                if (lspName != null)
                    callPayload.Queries["lsp__name"] = SourceExpressionConverter.ConvertO(lspName);
                if (lspId != null)
                    callPayload.Queries["lsp__id"] = SourceExpressionConverter.ConvertO(lspId);
                if (lspConfigId != null)
                    callPayload.Queries["lsp__config_id"] = SourceExpressionConverter.ConvertO(lspConfigId);
                if (spacecraftConfigIds != null)
                    callPayload.Queries["spacecraft_config_ids"] = SourceExpressionConverter.ConvertO(spacecraftConfigIds);
                callPayload.Queries["related"] = Convert.ToString(false);
                if (related != null)
                    callPayload.Queries["related"] = SourceExpressionConverter.ConvertO(related);
                return callPayload;
            }

            return new ApiConnectionAction<UplistResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LaunchPreviousListResponse> LaunchPreviousList([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> slug = null, [WorkflowExpression] Func<string> rocketConfigurationName = null, [WorkflowExpression] Func<double> rocketConfigurationId = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> rocketSpacecraftflightSpacecraftName = null, [WorkflowExpression] Func<string> rocketSpacecraftflightSpacecraftIcontains = null, [WorkflowExpression] Func<double> rocketSpacecraftflightSpacecraftId = null, [WorkflowExpression] Func<string> rocketConfigurationManufacturerName = null, [WorkflowExpression] Func<string> rocketConfigurationManufacturerNameIcontains = null, [WorkflowExpression] Func<string> rocketConfigurationFullName = null, [WorkflowExpression] Func<string> rocketConfigurationFullNameIcontains = null, [WorkflowExpression] Func<string> missionOrbitName = null, [WorkflowExpression] Func<string> missionOrbitNameIcontains = null, [WorkflowExpression] Func<string> program = null, [WorkflowExpression] Func<string> rSpacexApiId = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int[]> locationIds = null, [WorkflowExpression] Func<int[]> lspIds = null, [WorkflowExpression] Func<bool> isCrewed = null, [WorkflowExpression] Func<bool> includeSuborbital = null, [WorkflowExpression] Func<string> serialNumber = null, [WorkflowExpression] Func<string> lspName = null, [WorkflowExpression] Func<int> lspId = null, [WorkflowExpression] Func<int> lspConfigId = null, [WorkflowExpression] Func<int[]> spacecraftConfigIds = null, [WorkflowExpression] Func<bool> related = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/launch/previous/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (slug != null)
                    callPayload.Queries["slug"] = SourceExpressionConverter.ConvertO(slug);
                if (rocketConfigurationName != null)
                    callPayload.Queries["rocket__configuration__name"] = SourceExpressionConverter.ConvertO(rocketConfigurationName);
                if (rocketConfigurationId != null)
                    callPayload.Queries["rocket__configuration__id"] = SourceExpressionConverter.ConvertO(rocketConfigurationId);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                if (rocketSpacecraftflightSpacecraftName != null)
                    callPayload.Queries["rocket__spacecraftflight__spacecraft__name"] = SourceExpressionConverter.ConvertO(rocketSpacecraftflightSpacecraftName);
                if (rocketSpacecraftflightSpacecraftIcontains != null)
                    callPayload.Queries["rocket__spacecraftflight__spacecraft__icontains"] = SourceExpressionConverter.ConvertO(rocketSpacecraftflightSpacecraftIcontains);
                if (rocketSpacecraftflightSpacecraftId != null)
                    callPayload.Queries["rocket__spacecraftflight__spacecraft__id"] = SourceExpressionConverter.ConvertO(rocketSpacecraftflightSpacecraftId);
                if (rocketConfigurationManufacturerName != null)
                    callPayload.Queries["rocket__configuration__manufacturer__name"] = SourceExpressionConverter.ConvertO(rocketConfigurationManufacturerName);
                if (rocketConfigurationManufacturerNameIcontains != null)
                    callPayload.Queries["rocket__configuration__manufacturer__name__icontains"] = SourceExpressionConverter.ConvertO(rocketConfigurationManufacturerNameIcontains);
                if (rocketConfigurationFullName != null)
                    callPayload.Queries["rocket__configuration__full_name"] = SourceExpressionConverter.ConvertO(rocketConfigurationFullName);
                if (rocketConfigurationFullNameIcontains != null)
                    callPayload.Queries["rocket__configuration__full_name__icontains"] = SourceExpressionConverter.ConvertO(rocketConfigurationFullNameIcontains);
                if (missionOrbitName != null)
                    callPayload.Queries["mission__orbit__name"] = SourceExpressionConverter.ConvertO(missionOrbitName);
                if (missionOrbitNameIcontains != null)
                    callPayload.Queries["mission__orbit__name__icontains"] = SourceExpressionConverter.ConvertO(missionOrbitNameIcontains);
                if (program != null)
                    callPayload.Queries["program"] = SourceExpressionConverter.ConvertO(program);
                if (rSpacexApiId != null)
                    callPayload.Queries["r_spacex_api_id"] = SourceExpressionConverter.ConvertO(rSpacexApiId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (locationIds != null)
                    callPayload.Queries["location__ids"] = SourceExpressionConverter.ConvertO(locationIds);
                if (lspIds != null)
                    callPayload.Queries["lsp__ids"] = SourceExpressionConverter.ConvertO(lspIds);
                callPayload.Queries["is_crewed"] = Convert.ToString(false);
                if (isCrewed != null)
                    callPayload.Queries["is_crewed"] = SourceExpressionConverter.ConvertO(isCrewed);
                callPayload.Queries["include_suborbital"] = Convert.ToString(true);
                if (includeSuborbital != null)
                    callPayload.Queries["include_suborbital"] = SourceExpressionConverter.ConvertO(includeSuborbital);
                if (serialNumber != null)
                    callPayload.Queries["serial_number"] = SourceExpressionConverter.ConvertO(serialNumber);
                if (lspName != null)
                    callPayload.Queries["lsp__name"] = SourceExpressionConverter.ConvertO(lspName);
                if (lspId != null)
                    callPayload.Queries["lsp__id"] = SourceExpressionConverter.ConvertO(lspId);
                if (lspConfigId != null)
                    callPayload.Queries["lsp__config__id"] = SourceExpressionConverter.ConvertO(lspConfigId);
                if (spacecraftConfigIds != null)
                    callPayload.Queries["spacecraft_config_ids"] = SourceExpressionConverter.ConvertO(spacecraftConfigIds);
                callPayload.Queries["related"] = Convert.ToString(false);
                if (related != null)
                    callPayload.Queries["related"] = SourceExpressionConverter.ConvertO(related);
                return callPayload;
            }

            return new ApiConnectionAction<LaunchPreviousListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LaunchDetailed> LaunchPreviousRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/launch/previous/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LaunchDetailed>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LaunchUpcomingListResponse> LaunchUpcomingList([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> slug = null, [WorkflowExpression] Func<string> rocketConfigurationName = null, [WorkflowExpression] Func<double> rocketConfigurationId = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> rocketSpacecraftflightSpacecraftName = null, [WorkflowExpression] Func<string> rocketSpacecraftflightSpacecraftNameIcontains = null, [WorkflowExpression] Func<double> rocketSpacecraftflightSpacecraftId = null, [WorkflowExpression] Func<string> rocketConfigurationManufacturerName = null, [WorkflowExpression] Func<string> rocketConfigurationManufacturerNameIcontains = null, [WorkflowExpression] Func<string> rocketConfigurationFullName = null, [WorkflowExpression] Func<string> rocketConfigurationFullNameIcontains = null, [WorkflowExpression] Func<string> missionOrbitName = null, [WorkflowExpression] Func<string> missionOrbitNameIcontains = null, [WorkflowExpression] Func<string> program = null, [WorkflowExpression] Func<string> rSpacexApiId = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int[]> locationIds = null, [WorkflowExpression] Func<int[]> lspIds = null, [WorkflowExpression] Func<bool> isCrewed = null, [WorkflowExpression] Func<bool> includeSuborbital = null, [WorkflowExpression] Func<string> serialNumber = null, [WorkflowExpression] Func<string> lspName = null, [WorkflowExpression] Func<int> lspId = null, [WorkflowExpression] Func<int> lspConfigId = null, [WorkflowExpression] Func<int[]> spacecraftConfigIds = null, [WorkflowExpression] Func<bool> related = null, [WorkflowExpression] Func<bool> hideRecentPrevious = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/launch/upcoming/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (slug != null)
                    callPayload.Queries["slug"] = SourceExpressionConverter.ConvertO(slug);
                if (rocketConfigurationName != null)
                    callPayload.Queries["rocket__configuration__name"] = SourceExpressionConverter.ConvertO(rocketConfigurationName);
                if (rocketConfigurationId != null)
                    callPayload.Queries["rocket__configuration__id"] = SourceExpressionConverter.ConvertO(rocketConfigurationId);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                if (rocketSpacecraftflightSpacecraftName != null)
                    callPayload.Queries["rocket__spacecraftflight__spacecraft__name"] = SourceExpressionConverter.ConvertO(rocketSpacecraftflightSpacecraftName);
                if (rocketSpacecraftflightSpacecraftNameIcontains != null)
                    callPayload.Queries["rocket__spacecraftflight__spacecraft__name__icontains"] = SourceExpressionConverter.ConvertO(rocketSpacecraftflightSpacecraftNameIcontains);
                if (rocketSpacecraftflightSpacecraftId != null)
                    callPayload.Queries["rocket__spacecraftflight__spacecraft__id"] = SourceExpressionConverter.ConvertO(rocketSpacecraftflightSpacecraftId);
                if (rocketConfigurationManufacturerName != null)
                    callPayload.Queries["rocket__configuration__manufacturer__name"] = SourceExpressionConverter.ConvertO(rocketConfigurationManufacturerName);
                if (rocketConfigurationManufacturerNameIcontains != null)
                    callPayload.Queries["rocket__configuration__manufacturer__name__icontains"] = SourceExpressionConverter.ConvertO(rocketConfigurationManufacturerNameIcontains);
                if (rocketConfigurationFullName != null)
                    callPayload.Queries["rocket__configuration__full_name"] = SourceExpressionConverter.ConvertO(rocketConfigurationFullName);
                if (rocketConfigurationFullNameIcontains != null)
                    callPayload.Queries["rocket__configuration__full_name__icontains"] = SourceExpressionConverter.ConvertO(rocketConfigurationFullNameIcontains);
                if (missionOrbitName != null)
                    callPayload.Queries["mission__orbit__name"] = SourceExpressionConverter.ConvertO(missionOrbitName);
                if (missionOrbitNameIcontains != null)
                    callPayload.Queries["mission__orbit__name__icontains"] = SourceExpressionConverter.ConvertO(missionOrbitNameIcontains);
                if (program != null)
                    callPayload.Queries["program"] = SourceExpressionConverter.ConvertO(program);
                if (rSpacexApiId != null)
                    callPayload.Queries["r_spacex_api_id"] = SourceExpressionConverter.ConvertO(rSpacexApiId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (locationIds != null)
                    callPayload.Queries["location__ids"] = SourceExpressionConverter.ConvertO(locationIds);
                if (lspIds != null)
                    callPayload.Queries["lsp__ids"] = SourceExpressionConverter.ConvertO(lspIds);
                callPayload.Queries["is_crewed"] = Convert.ToString(false);
                if (isCrewed != null)
                    callPayload.Queries["is_crewed"] = SourceExpressionConverter.ConvertO(isCrewed);
                callPayload.Queries["include_suborbital"] = Convert.ToString(true);
                if (includeSuborbital != null)
                    callPayload.Queries["include_suborbital"] = SourceExpressionConverter.ConvertO(includeSuborbital);
                if (serialNumber != null)
                    callPayload.Queries["serial_number"] = SourceExpressionConverter.ConvertO(serialNumber);
                if (lspName != null)
                    callPayload.Queries["lsp__name"] = SourceExpressionConverter.ConvertO(lspName);
                if (lspId != null)
                    callPayload.Queries["lsp__id"] = SourceExpressionConverter.ConvertO(lspId);
                if (lspConfigId != null)
                    callPayload.Queries["lsp__config__id"] = SourceExpressionConverter.ConvertO(lspConfigId);
                if (spacecraftConfigIds != null)
                    callPayload.Queries["spacecraft_config_ids"] = SourceExpressionConverter.ConvertO(spacecraftConfigIds);
                callPayload.Queries["related"] = Convert.ToString(false);
                if (related != null)
                    callPayload.Queries["related"] = SourceExpressionConverter.ConvertO(related);
                callPayload.Queries["hide_recent_previous"] = Convert.ToString(false);
                if (hideRecentPrevious != null)
                    callPayload.Queries["hide_recent_previous"] = SourceExpressionConverter.ConvertO(hideRecentPrevious);
                return callPayload;
            }

            return new ApiConnectionAction<LaunchUpcomingListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LaunchDetailed> LaunchUpcomingRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/launch/upcoming/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LaunchDetailed>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LaunchDetailed> LaunchRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/launch/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LaunchDetailed>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LauncherListResponse> LauncherList([WorkflowExpression] Func<double> id = null, [WorkflowExpression] Func<string> serialNumber = null, [WorkflowExpression] Func<string> flightProven = null, [WorkflowExpression] Func<string> launcherConfig = null, [WorkflowExpression] Func<string> launcherConfigManufacturer = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/launcher/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (serialNumber != null)
                    callPayload.Queries["serial_number"] = SourceExpressionConverter.ConvertO(serialNumber);
                if (flightProven != null)
                    callPayload.Queries["flight_proven"] = SourceExpressionConverter.ConvertO(flightProven);
                if (launcherConfig != null)
                    callPayload.Queries["launcher_config"] = SourceExpressionConverter.ConvertO(launcherConfig);
                if (launcherConfigManufacturer != null)
                    callPayload.Queries["launcher_config__manufacturer"] = SourceExpressionConverter.ConvertO(launcherConfigManufacturer);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<LauncherListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LauncherDetail> LauncherRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/launcher/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LauncherDetail>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LocationListResponse> LocationList([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> countryCode = null, [WorkflowExpression] Func<double> id = null, [WorkflowExpression] Func<string> padLocationId = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/location/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (countryCode != null)
                    callPayload.Queries["country_code"] = SourceExpressionConverter.ConvertO(countryCode);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (padLocationId != null)
                    callPayload.Queries["pad__location_id"] = SourceExpressionConverter.ConvertO(padLocationId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<LocationListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LocationDetail> LocationRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/location/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LocationDetail>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<PadListResponse> PadList([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<double> id = null, [WorkflowExpression] Func<string> location = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pad/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (id != null)
                    callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                if (location != null)
                    callPayload.Queries["location"] = SourceExpressionConverter.ConvertO(location);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<PadListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<Pad> PadRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pad/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Pad>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ProgramListResponse> ProgramList([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/program/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ProgramListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<Program> ProgramRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/program/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Program>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<SpacecraftListResponse> SpacecraftList([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> spacecraftConfig = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/spacecraft/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                if (spacecraftConfig != null)
                    callPayload.Queries["spacecraft_config"] = SourceExpressionConverter.ConvertO(spacecraftConfig);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<SpacecraftListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<SpacecraftFlightListResponse> SpacecraftFlightList([WorkflowExpression] Func<string> spacecraft = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/spacecraft/flight/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (spacecraft != null)
                    callPayload.Queries["spacecraft"] = SourceExpressionConverter.ConvertO(spacecraft);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<SpacecraftFlightListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<SpacecraftFlightDetailed> SpacecraftFlightRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/spacecraft/flight/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SpacecraftFlightDetailed>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<SpacecraftDetailed> SpacecraftRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/spacecraft/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SpacecraftDetailed>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<SpacestationListResponse> SpacestationList([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> owners = null, [WorkflowExpression] Func<string> orbit = null, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<string> ownersName = null, [WorkflowExpression] Func<string> ownersAbbrev = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/spacestation/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                if (owners != null)
                    callPayload.Queries["owners"] = SourceExpressionConverter.ConvertO(owners);
                if (orbit != null)
                    callPayload.Queries["orbit"] = SourceExpressionConverter.ConvertO(orbit);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                if (ownersName != null)
                    callPayload.Queries["owners__name"] = SourceExpressionConverter.ConvertO(ownersName);
                if (ownersAbbrev != null)
                    callPayload.Queries["owners__abbrev"] = SourceExpressionConverter.ConvertO(ownersAbbrev);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<SpacestationListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<SpaceStationDetailed> SpacestationRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/spacestation/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SpaceStationDetailed>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<UpdatesListResponse> UpdatesList([WorkflowExpression] Func<string> createdOn = null, [WorkflowExpression] Func<string> launch = null, [WorkflowExpression] Func<string> program = null, [WorkflowExpression] Func<string> launchLaunchServiceProvider = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/updates/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (createdOn != null)
                    callPayload.Queries["created_on"] = SourceExpressionConverter.ConvertO(createdOn);
                if (launch != null)
                    callPayload.Queries["launch"] = SourceExpressionConverter.ConvertO(launch);
                if (program != null)
                    callPayload.Queries["program"] = SourceExpressionConverter.ConvertO(program);
                if (launchLaunchServiceProvider != null)
                    callPayload.Queries["launch__launch_service_provider"] = SourceExpressionConverter.ConvertO(launchLaunchServiceProvider);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<UpdatesListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<Update> UpdatesRead([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/updates/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Update>(BuildSourceInput);
        }
    }

    public class Launchlibrary2ipTriggers([ConnectionName] string connectionId)
    {
    }

    public class AgenciesListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public Agency[] Results { get; set; }
    }

    public class Agency
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("featured")]
        public bool Featured { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("abbrev")]
        public string Abbrev { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("administrator")]
        public string Administrator { get; set; }

        [JsonProperty("founding_year")]
        public string FoundingYear { get; set; }

        [JsonProperty("launchers")]
        public string Launchers { get; set; }

        [JsonProperty("spacecraft")]
        public string Spacecraft { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
    }

    public class AgencySerializerDetailed
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("featured")]
        public bool Featured { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("abbrev")]
        public string Abbrev { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("administrator")]
        public string Administrator { get; set; }

        [JsonProperty("founding_year")]
        public string FoundingYear { get; set; }

        [JsonProperty("launchers")]
        public string Launchers { get; set; }

        [JsonProperty("spacecraft")]
        public string Spacecraft { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("launch_library_url")]
        public string LaunchLibraryUrl { get; set; }

        [JsonProperty("total_launch_count")]
        public int TotalLaunchCount { get; set; }

        [JsonProperty("successful_launches")]
        public int SuccessfulLaunches { get; set; }

        [JsonProperty("consecutive_successful_launches")]
        public int ConsecutiveSuccessfulLaunches { get; set; }

        [JsonProperty("failed_launches")]
        public int FailedLaunches { get; set; }

        [JsonProperty("pending_launches")]
        public int PendingLaunches { get; set; }

        [JsonProperty("successful_landings")]
        public int SuccessfulLandings { get; set; }

        [JsonProperty("failed_landings")]
        public int FailedLandings { get; set; }

        [JsonProperty("attempted_landings")]
        public int AttemptedLandings { get; set; }

        [JsonProperty("consecutive_successful_landings")]
        public int ConsecutiveSuccessfulLandings { get; set; }

        [JsonProperty("info_url")]
        public string InfoUrl { get; set; }

        [JsonProperty("wiki_url")]
        public string WikiUrl { get; set; }

        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("nation_url")]
        public string NationUrl { get; set; }

        [JsonProperty("launcher_list")]
        public LauncherConfigDetailSerializerForAgency[] LauncherList { get; set; }

        [JsonProperty("spacecraft_list")]
        public SpacecraftConfigurationDetail[] SpacecraftList { get; set; }
    }

    public class LauncherConfigDetailSerializerForAgency
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("variant")]
        public string Variant { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("min_stage")]
        public int MinStage { get; set; }

        [JsonProperty("max_stage")]
        public int MaxStage { get; set; }

        [JsonProperty("length")]
        public double Length { get; set; }

        [JsonProperty("diameter")]
        public double Diameter { get; set; }

        [JsonProperty("maiden_flight")]
        public string MaidenFlight { get; set; }

        [JsonProperty("launch_mass")]
        public int LaunchMass { get; set; }

        [JsonProperty("leo_capacity")]
        public int LeoCapacity { get; set; }

        [JsonProperty("gto_capacity")]
        public int GtoCapacity { get; set; }

        [JsonProperty("to_thrust")]
        public int ToThrust { get; set; }

        [JsonProperty("apogee")]
        public int Apogee { get; set; }

        [JsonProperty("vehicle_range")]
        public int VehicleRange { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("info_url")]
        public string InfoUrl { get; set; }

        [JsonProperty("wiki_url")]
        public string WikiUrl { get; set; }

        [JsonProperty("consecutive_successful_launches")]
        public int ConsecutiveSuccessfulLaunches { get; set; }

        [JsonProperty("successful_launches")]
        public int SuccessfulLaunches { get; set; }

        [JsonProperty("failed_launches")]
        public int FailedLaunches { get; set; }

        [JsonProperty("pending_launches")]
        public int PendingLaunches { get; set; }
    }

    public class SpacecraftConfigurationDetail
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public SpacecraftConfigType Type { get; set; }

        [JsonProperty("agency")]
        public Agency Agency { get; set; }

        [JsonProperty("in_use")]
        public bool InUse { get; set; }

        [JsonProperty("capability")]
        public string Capability { get; set; }

        [JsonProperty("history")]
        public string History { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("maiden_flight")]
        public string MaidenFlight { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("diameter")]
        public double Diameter { get; set; }

        [JsonProperty("human_rated")]
        public bool HumanRated { get; set; }

        [JsonProperty("crew_capacity")]
        public int CrewCapacity { get; set; }

        [JsonProperty("payload_capacity")]
        public int PayloadCapacity { get; set; }

        [JsonProperty("flight_life")]
        public string FlightLife { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("nation_url")]
        public string NationUrl { get; set; }

        [JsonProperty("wiki_link")]
        public string WikiLink { get; set; }

        [JsonProperty("info_link")]
        public string InfoLink { get; set; }
    }

    public class SpacecraftConfigType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AstronautListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public AstronautNormal[] Results { get; set; }
    }

    public class AstronautNormal
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public AstronautStatus Status { get; set; }

        [JsonProperty("type")]
        public AstronautType Type { get; set; }

        [JsonProperty("date_of_birth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("date_of_death")]
        public string DateOfDeath { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("instagram")]
        public string Instagram { get; set; }

        [JsonProperty("wiki")]
        public string Wiki { get; set; }

        [JsonProperty("agency")]
        public Agency Agency { get; set; }

        [JsonProperty("profile_image")]
        public string ProfileImage { get; set; }

        [JsonProperty("profile_image_thumbnail")]
        public string ProfileImageThumbnail { get; set; }

        [JsonProperty("last_flight")]
        public string LastFlight { get; set; }

        [JsonProperty("first_flight")]
        public string FirstFlight { get; set; }
    }

    public class AstronautStatus
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AstronautType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AstronautDetailed
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public AstronautStatus Status { get; set; }

        [JsonProperty("type")]
        public AstronautType Type { get; set; }

        [JsonProperty("agency")]
        public AgencySerializerMini Agency { get; set; }

        [JsonProperty("date_of_birth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("date_of_death")]
        public string DateOfDeath { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("instagram")]
        public string Instagram { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("profile_image")]
        public string ProfileImage { get; set; }

        [JsonProperty("profile_image_thumbnail")]
        public string ProfileImageThumbnail { get; set; }

        [JsonProperty("wiki")]
        public string Wiki { get; set; }

        [JsonProperty("flights")]
        public LaunchSerializerCommon[] Flights { get; set; }

        [JsonProperty("landings")]
        public SpacecraftFlight[] Landings { get; set; }

        [JsonProperty("last_flight")]
        public string LastFlight { get; set; }

        [JsonProperty("first_flight")]
        public string FirstFlight { get; set; }
    }

    public class AgencySerializerMini
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class LaunchSerializerCommon
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public LaunchStatus Status { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("net")]
        public string Net { get; set; }

        [JsonProperty("window_end")]
        public string WindowEnd { get; set; }

        [JsonProperty("window_start")]
        public string WindowStart { get; set; }

        [JsonProperty("probability")]
        public int Probability { get; set; }

        [JsonProperty("holdreason")]
        public string Holdreason { get; set; }

        [JsonProperty("failreason")]
        public string Failreason { get; set; }

        [JsonProperty("hashtag")]
        public string Hashtag { get; set; }

        [JsonProperty("launch_service_provider")]
        public AgencySerializerMini LaunchServiceProvider { get; set; }

        [JsonProperty("rocket")]
        public RocketSerializerCommon Rocket { get; set; }

        [JsonProperty("mission")]
        public Mission Mission { get; set; }

        [JsonProperty("pad")]
        public Pad Pad { get; set; }

        [JsonProperty("infoURLs")]
        public string InfoURLs { get; set; }

        [JsonProperty("vidURLs")]
        public string VidURLs { get; set; }

        [JsonProperty("webcast_live")]
        public bool WebcastLive { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("infographic")]
        public string Infographic { get; set; }

        [JsonProperty("program")]
        public Program[] Program { get; set; }
    }

    public class LaunchStatus
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("abbrev")]
        public string Abbrev { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class RocketSerializerCommon
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("configuration")]
        public LauncherConfigList Configuration { get; set; }
    }

    public class LauncherConfigList
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("variant")]
        public string Variant { get; set; }
    }

    public class Mission
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("launch_designator")]
        public string LaunchDesignator { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("orbit")]
        public Orbit Orbit { get; set; }
    }

    public class Orbit
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("abbrev")]
        public string Abbrev { get; set; }
    }

    public class Pad
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("agency_id")]
        public int AgencyId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("info_url")]
        public string InfoUrl { get; set; }

        [JsonProperty("wiki_url")]
        public string WikiUrl { get; set; }

        [JsonProperty("map_url")]
        public string MapUrl { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("map_image")]
        public string MapImage { get; set; }

        [JsonProperty("total_launch_count")]
        public int TotalLaunchCount { get; set; }
    }

    public class Location
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("map_image")]
        public string MapImage { get; set; }

        [JsonProperty("total_launch_count")]
        public int TotalLaunchCount { get; set; }

        [JsonProperty("total_landing_count")]
        public int TotalLandingCount { get; set; }
    }

    public class Program
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("agencies")]
        public AgencySerializerMini[] Agencies { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("info_url")]
        public string InfoUrl { get; set; }

        [JsonProperty("wiki_url")]
        public string WikiUrl { get; set; }

        [JsonProperty("mission_patches")]
        public MissionPatch[] MissionPatches { get; set; }
    }

    public class MissionPatch
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("agency")]
        public AgencySerializerMini Agency { get; set; }
    }

    public class SpacecraftFlight
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("mission_end")]
        public string MissionEnd { get; set; }

        [JsonProperty("spacecraft")]
        public Spacecraft Spacecraft { get; set; }

        [JsonProperty("launch")]
        public LaunchSerializerCommon Launch { get; set; }
    }

    public class Spacecraft
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("serial_number")]
        public string SerialNumber { get; set; }

        [JsonProperty("status")]
        public SpacecraftStatus Status { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("spacecraft_config")]
        public SpacecraftConfig SpacecraftConfig { get; set; }
    }

    public class SpacecraftStatus
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SpacecraftConfig
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public SpacecraftConfigType Type { get; set; }

        [JsonProperty("agency")]
        public AgencySerializerMini Agency { get; set; }

        [JsonProperty("in_use")]
        public bool InUse { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
    }

    public class ConfigAgencytypeListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public AgencyType[] Results { get; set; }
    }

    public class AgencyType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ConfigAstronautroleListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public AstronautRole[] Results { get; set; }
    }

    public class AstronautRole
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }
    }

    public class ConfigAstronautstatusListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public AstronautStatus[] Results { get; set; }
    }

    public class ConfigAstronauttypeListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public AstronautType[] Results { get; set; }
    }

    public class ConfigDockinglocationListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public DockingLocation[] Results { get; set; }
    }

    public class DockingLocation
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ConfigEventtypeListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public EventType[] Results { get; set; }
    }

    public class EventType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ConfigFirststagetypeListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public FirstStageType[] Results { get; set; }
    }

    public class FirstStageType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ConfigLandinglocationListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public LandingLocation[] Results { get; set; }
    }

    public class LandingLocation
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("abbrev")]
        public string Abbrev { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("successful_landings")]
        public string SuccessfulLandings { get; set; }
    }

    public class ConfigLauncherListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public LauncherConfig[] Results { get; set; }
    }

    public class LauncherConfig
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("manufacturer")]
        public Agency Manufacturer { get; set; }

        [JsonProperty("program")]
        public Program[] Program { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("variant")]
        public string Variant { get; set; }

        [JsonProperty("reusable")]
        public bool Reusable { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("info_url")]
        public string InfoUrl { get; set; }

        [JsonProperty("wiki_url")]
        public string WikiUrl { get; set; }
    }

    public class LauncherConfigDetail
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("manufacturer")]
        public AgencySerializerDetailedCommon Manufacturer { get; set; }

        [JsonProperty("program")]
        public Program[] Program { get; set; }

        [JsonProperty("variant")]
        public string Variant { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("min_stage")]
        public int MinStage { get; set; }

        [JsonProperty("max_stage")]
        public int MaxStage { get; set; }

        [JsonProperty("length")]
        public double Length { get; set; }

        [JsonProperty("diameter")]
        public double Diameter { get; set; }

        [JsonProperty("maiden_flight")]
        public string MaidenFlight { get; set; }

        [JsonProperty("launch_cost")]
        public string LaunchCost { get; set; }

        [JsonProperty("launch_mass")]
        public int LaunchMass { get; set; }

        [JsonProperty("leo_capacity")]
        public int LeoCapacity { get; set; }

        [JsonProperty("gto_capacity")]
        public int GtoCapacity { get; set; }

        [JsonProperty("to_thrust")]
        public int ToThrust { get; set; }

        [JsonProperty("apogee")]
        public int Apogee { get; set; }

        [JsonProperty("vehicle_range")]
        public int VehicleRange { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("info_url")]
        public string InfoUrl { get; set; }

        [JsonProperty("wiki_url")]
        public string WikiUrl { get; set; }

        [JsonProperty("total_launch_count")]
        public int TotalLaunchCount { get; set; }

        [JsonProperty("consecutive_successful_launches")]
        public int ConsecutiveSuccessfulLaunches { get; set; }

        [JsonProperty("successful_launches")]
        public int SuccessfulLaunches { get; set; }

        [JsonProperty("failed_launches")]
        public int FailedLaunches { get; set; }

        [JsonProperty("pending_launches")]
        public int PendingLaunches { get; set; }
    }

    public class AgencySerializerDetailedCommon
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("featured")]
        public bool Featured { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("abbrev")]
        public string Abbrev { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("administrator")]
        public string Administrator { get; set; }

        [JsonProperty("founding_year")]
        public string FoundingYear { get; set; }

        [JsonProperty("launchers")]
        public string Launchers { get; set; }

        [JsonProperty("spacecraft")]
        public string Spacecraft { get; set; }

        [JsonProperty("launch_library_url")]
        public string LaunchLibraryUrl { get; set; }

        [JsonProperty("total_launch_count")]
        public int TotalLaunchCount { get; set; }

        [JsonProperty("consecutive_successful_launches")]
        public int ConsecutiveSuccessfulLaunches { get; set; }

        [JsonProperty("successful_launches")]
        public int SuccessfulLaunches { get; set; }

        [JsonProperty("failed_launches")]
        public int FailedLaunches { get; set; }

        [JsonProperty("pending_launches")]
        public int PendingLaunches { get; set; }

        [JsonProperty("consecutive_successful_landings")]
        public int ConsecutiveSuccessfulLandings { get; set; }

        [JsonProperty("successful_landings")]
        public int SuccessfulLandings { get; set; }

        [JsonProperty("failed_landings")]
        public int FailedLandings { get; set; }

        [JsonProperty("attempted_landings")]
        public int AttemptedLandings { get; set; }

        [JsonProperty("info_url")]
        public string InfoUrl { get; set; }

        [JsonProperty("wiki_url")]
        public string WikiUrl { get; set; }

        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("nation_url")]
        public string NationUrl { get; set; }
    }

    public class ConfigLaunchstatusListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public LaunchStatus[] Results { get; set; }
    }

    public class ConfigMissiontypeListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public MissionType[] Results { get; set; }
    }

    public class MissionType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ConfigNoticetypeListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public NoticeType[] Results { get; set; }
    }

    public class NoticeType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ConfigOrbitListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public Orbit[] Results { get; set; }
    }

    public class ConfigRoadclosurestatusListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public RoadClosureStatus[] Results { get; set; }
    }

    public class RoadClosureStatus
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ConfigSpacecraftListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public SpacecraftConfiguration[] Results { get; set; }
    }

    public class SpacecraftConfiguration
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("agency")]
        public Agency Agency { get; set; }

        [JsonProperty("in_use")]
        public bool InUse { get; set; }

        [JsonProperty("capability")]
        public string Capability { get; set; }

        [JsonProperty("maiden_flight")]
        public string MaidenFlight { get; set; }

        [JsonProperty("human_rated")]
        public bool HumanRated { get; set; }

        [JsonProperty("crew_capacity")]
        public int CrewCapacity { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("nation_url")]
        public string NationUrl { get; set; }

        [JsonProperty("wiki_link")]
        public string WikiLink { get; set; }

        [JsonProperty("info_link")]
        public string InfoLink { get; set; }
    }

    public class ConfigSpacecraftstatusListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public SpacecraftStatus[] Results { get; set; }
    }

    public class ConfigSpacestationstatusListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public SpaceStationStatus[] Results { get; set; }
    }

    public class SpaceStationStatus
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class DockingEventListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public DockingEvent[] Results { get; set; }
    }

    public class DockingEvent
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("launch_id")]
        public string LaunchId { get; set; }

        [JsonProperty("docking")]
        public string Docking { get; set; }

        [JsonProperty("departure")]
        public string Departure { get; set; }

        [JsonProperty("flight_vehicle")]
        public SpacecraftFlightSerializerForDockingEvent FlightVehicle { get; set; }

        [JsonProperty("docking_location")]
        public DockingLocation DockingLocation { get; set; }
    }

    public class SpacecraftFlightSerializerForDockingEvent
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("mission_end")]
        public string MissionEnd { get; set; }

        [JsonProperty("spacecraft")]
        public Spacecraft Spacecraft { get; set; }
    }

    public class DockingEventDetailed
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("launch_id")]
        public string LaunchId { get; set; }

        [JsonProperty("docking")]
        public string Docking { get; set; }

        [JsonProperty("departure")]
        public string Departure { get; set; }

        [JsonProperty("flight_vehicle")]
        public SpacecraftFlightSerializerForDockingEventDetailed FlightVehicle { get; set; }

        [JsonProperty("docking_location")]
        public DockingLocation DockingLocation { get; set; }

        [JsonProperty("space_station")]
        public SpaceStationSerializerForDockingEvent SpaceStation { get; set; }
    }

    public class SpacecraftFlightSerializerForDockingEventDetailed
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("mission_end")]
        public string MissionEnd { get; set; }

        [JsonProperty("spacecraft")]
        public SpacecraftDetailedNoFlights Spacecraft { get; set; }
    }

    public class SpacecraftDetailedNoFlights
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("serial_number")]
        public string SerialNumber { get; set; }

        [JsonProperty("status")]
        public SpacecraftStatus Status { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("spacecraft_config")]
        public SpacecraftConfigurationDetail SpacecraftConfig { get; set; }
    }

    public class SpaceStationSerializerForDockingEvent
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
    }

    public class EventListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public Events[] Results { get; set; }
    }

    public class Events
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("updates")]
        public Update[] Updates { get; set; }

        [JsonProperty("type")]
        public EventType Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("news_url")]
        public string NewsUrl { get; set; }

        [JsonProperty("video_url")]
        public string VideoUrl { get; set; }

        [JsonProperty("feature_image")]
        public string FeatureImage { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("launches")]
        public LaunchSerializerCommon[] Launches { get; set; }

        [JsonProperty("expeditions")]
        public Expedition[] Expeditions { get; set; }

        [JsonProperty("spacestations")]
        public SpaceStationSerializerForCommon[] Spacestations { get; set; }

        [JsonProperty("program")]
        public Program[] Program { get; set; }
    }

    public class Update
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("profile_image")]
        public string ProfileImage { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("info_url")]
        public string InfoUrl { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }
    }

    public class Expedition
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("spacestation")]
        public SpaceStationSerializerForExpedition Spacestation { get; set; }

        [JsonProperty("mission_patches")]
        public MissionPatch[] MissionPatches { get; set; }
    }

    public class SpaceStationSerializerForExpedition
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public SpaceStationStatus Status { get; set; }

        [JsonProperty("orbit")]
        public string Orbit { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
    }

    public class SpaceStationSerializerForCommon
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public SpaceStationStatus Status { get; set; }

        [JsonProperty("founded")]
        public string Founded { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("orbit")]
        public string Orbit { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
    }

    public class EventPreviousListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public Events[] Results { get; set; }
    }

    public class EventUpcomingListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public Events[] Results { get; set; }
    }

    public class ExpeditionListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public Expedition[] Results { get; set; }
    }

    public class ExpeditionDetail
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("spacestation")]
        public SpaceStationDetailedSerializerForExpedition Spacestation { get; set; }

        [JsonProperty("crew")]
        public AstronautFlightForExpedition[] Crew { get; set; }

        [JsonProperty("mission_patches")]
        public MissionPatch[] MissionPatches { get; set; }
    }

    public class SpaceStationDetailedSerializerForExpedition
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public SpaceStationStatus Status { get; set; }

        [JsonProperty("founded")]
        public string Founded { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("orbit")]
        public string Orbit { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("owners")]
        public AgencyList[] Owners { get; set; }
    }

    public class AgencyList
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("abbrev")]
        public string Abbrev { get; set; }
    }

    public class AstronautFlightForExpedition
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("role")]
        public AstronautRole Role { get; set; }

        [JsonProperty("astronaut")]
        public Astronaut Astronaut { get; set; }
    }

    public class Astronaut
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public AstronautStatus Status { get; set; }

        [JsonProperty("agency")]
        public AgencySerializerMini Agency { get; set; }

        [JsonProperty("profile_image")]
        public string ProfileImage { get; set; }

        [JsonProperty("profile_image_thumbnail")]
        public string ProfileImageThumbnail { get; set; }
    }

    public class UplistResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public LaunchSerializerCommon[] Results { get; set; }
    }

    public class LaunchPreviousListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public LaunchSerializerCommon[] Results { get; set; }
    }

    public class LaunchDetailed
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("flightclub_url")]
        public string FlightclubUrl { get; set; }

        [JsonProperty("r_spacex_api_id")]
        public string RSpacexApiId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public LaunchStatus Status { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("updates")]
        public Update[] Updates { get; set; }

        [JsonProperty("net")]
        public string Net { get; set; }

        [JsonProperty("window_end")]
        public string WindowEnd { get; set; }

        [JsonProperty("window_start")]
        public string WindowStart { get; set; }

        [JsonProperty("probability")]
        public int Probability { get; set; }

        [JsonProperty("holdreason")]
        public string Holdreason { get; set; }

        [JsonProperty("failreason")]
        public string Failreason { get; set; }

        [JsonProperty("hashtag")]
        public string Hashtag { get; set; }

        [JsonProperty("launch_service_provider")]
        public AgencySerializerDetailedCommon LaunchServiceProvider { get; set; }

        [JsonProperty("rocket")]
        public RocketDetailed Rocket { get; set; }

        [JsonProperty("mission")]
        public Mission Mission { get; set; }

        [JsonProperty("pad")]
        public Pad Pad { get; set; }

        [JsonProperty("infoURLs")]
        public InfoURL[] InfoURLs { get; set; }

        [JsonProperty("vidURLs")]
        public VidURL[] VidURLs { get; set; }

        [JsonProperty("webcast_live")]
        public bool WebcastLive { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("infographic")]
        public string Infographic { get; set; }

        [JsonProperty("program")]
        public Program[] Program { get; set; }

        [JsonProperty("orbital_launch_attempt_count")]
        public int OrbitalLaunchAttemptCount { get; set; }

        [JsonProperty("location_launch_attempt_count")]
        public int LocationLaunchAttemptCount { get; set; }

        [JsonProperty("pad_launch_attempt_count")]
        public int PadLaunchAttemptCount { get; set; }

        [JsonProperty("agency_launch_attempt_count")]
        public int AgencyLaunchAttemptCount { get; set; }

        [JsonProperty("orbital_launch_attempt_count_year")]
        public int OrbitalLaunchAttemptCountYear { get; set; }

        [JsonProperty("location_launch_attempt_count_year")]
        public int LocationLaunchAttemptCountYear { get; set; }

        [JsonProperty("pad_launch_attempt_count_year")]
        public int PadLaunchAttemptCountYear { get; set; }

        [JsonProperty("agency_launch_attempt_count_year")]
        public int AgencyLaunchAttemptCountYear { get; set; }

        [JsonProperty("mission_patches")]
        public MissionPatch[] MissionPatches { get; set; }

        [JsonProperty("notifications_enabled")]
        public bool NotificationsEnabled { get; set; }
    }

    public class RocketDetailed
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("configuration")]
        public LauncherConfigDetail Configuration { get; set; }

        [JsonProperty("launcher_stage")]
        public FirstStage[] LauncherStage { get; set; }

        [JsonProperty("spacecraft_stage")]
        public SpacecraftFlightDetailedSerializerForLaunch SpacecraftStage { get; set; }
    }

    public class FirstStage
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("reused")]
        public bool Reused { get; set; }

        [JsonProperty("launcher_flight_number")]
        public string LauncherFlightNumber { get; set; }

        [JsonProperty("launcher")]
        public LauncherDetailed Launcher { get; set; }

        [JsonProperty("landing")]
        public Landing Landing { get; set; }

        [JsonProperty("previous_flight_date")]
        public string PreviousFlightDate { get; set; }

        [JsonProperty("turn_around_time_days")]
        public string TurnAroundTimeDays { get; set; }

        [JsonProperty("previous_flight")]
        public LaunchSerializerMini PreviousFlight { get; set; }
    }

    public class LauncherDetailed
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("flight_proven")]
        public bool FlightProven { get; set; }

        [JsonProperty("serial_number")]
        public string SerialNumber { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("successful_landings")]
        public string SuccessfulLandings { get; set; }

        [JsonProperty("attempted_landings")]
        public string AttemptedLandings { get; set; }

        [JsonProperty("flights")]
        public string Flights { get; set; }

        [JsonProperty("last_launch_date")]
        public string LastLaunchDate { get; set; }

        [JsonProperty("first_launch_date")]
        public string FirstLaunchDate { get; set; }
    }

    public class Landing
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("attempt")]
        public bool Attempt { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public LandingLocation Location { get; set; }

        [JsonProperty("type")]
        public LandingType Type { get; set; }
    }

    public class LandingType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("abbrev")]
        public string Abbrev { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class LaunchSerializerMini
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SpacecraftFlightDetailedSerializerForLaunch
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("mission_end")]
        public string MissionEnd { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("launch_crew")]
        public AstronautFlight[] LaunchCrew { get; set; }

        [JsonProperty("onboard_crew")]
        public AstronautFlight[] OnboardCrew { get; set; }

        [JsonProperty("landing_crew")]
        public AstronautFlight[] LandingCrew { get; set; }

        [JsonProperty("spacecraft")]
        public SpacecraftDetailedNoFlights Spacecraft { get; set; }

        [JsonProperty("docking_events")]
        public DockingEventSerializerForSpacecraftFlight[] DockingEvents { get; set; }
    }

    public class AstronautFlight
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("role")]
        public AstronautRole Role { get; set; }

        [JsonProperty("astronaut")]
        public AstronautDetailedSerializerNoFlights Astronaut { get; set; }
    }

    public class AstronautDetailedSerializerNoFlights
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public AstronautType Type { get; set; }

        [JsonProperty("status")]
        public AstronautStatus Status { get; set; }

        [JsonProperty("agency")]
        public AgencySerializerMini Agency { get; set; }

        [JsonProperty("date_of_birth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("date_of_death")]
        public string DateOfDeath { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("instagram")]
        public string Instagram { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("profile_image")]
        public string ProfileImage { get; set; }

        [JsonProperty("wiki")]
        public string Wiki { get; set; }

        [JsonProperty("last_flight")]
        public string LastFlight { get; set; }

        [JsonProperty("first_flight")]
        public string FirstFlight { get; set; }
    }

    public class DockingEventSerializerForSpacecraftFlight
    {
        [JsonProperty("spacestation")]
        public SpaceStationSerializerForCommon Spacestation { get; set; }

        [JsonProperty("docking")]
        public string Docking { get; set; }

        [JsonProperty("departure")]
        public string Departure { get; set; }

        [JsonProperty("docking_location")]
        public DockingLocation DockingLocation { get; set; }
    }

    public class InfoURL
    {
        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("feature_image")]
        public string FeatureImage { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class VidURL
    {
        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("feature_image")]
        public string FeatureImage { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class LaunchUpcomingListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public LaunchSerializerCommon[] Results { get; set; }
    }

    public class LauncherListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public Launcher[] Results { get; set; }
    }

    public class Launcher
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("flight_proven")]
        public bool FlightProven { get; set; }

        [JsonProperty("serial_number")]
        public string SerialNumber { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("launcher_config")]
        public LauncherConfigList LauncherConfig { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("flights")]
        public string Flights { get; set; }

        [JsonProperty("last_launch_date")]
        public string LastLaunchDate { get; set; }

        [JsonProperty("first_launch_date")]
        public string FirstLaunchDate { get; set; }
    }

    public class LauncherDetail
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("flight_proven")]
        public bool FlightProven { get; set; }

        [JsonProperty("serial_number")]
        public string SerialNumber { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("launcher_config")]
        public LauncherConfigDetail LauncherConfig { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("successful_landings")]
        public string SuccessfulLandings { get; set; }

        [JsonProperty("attempted_landings")]
        public string AttemptedLandings { get; set; }

        [JsonProperty("flights")]
        public string Flights { get; set; }

        [JsonProperty("last_launch_date")]
        public string LastLaunchDate { get; set; }

        [JsonProperty("first_launch_date")]
        public string FirstLaunchDate { get; set; }
    }

    public class LocationListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public Location[] Results { get; set; }
    }

    public class LocationDetail
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("map_image")]
        public string MapImage { get; set; }

        [JsonProperty("total_launch_count")]
        public string TotalLaunchCount { get; set; }

        [JsonProperty("total_landing_count")]
        public string TotalLandingCount { get; set; }

        [JsonProperty("pads")]
        public PadSerializerNoLocation[] Pads { get; set; }
    }

    public class PadSerializerNoLocation
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("agency_id")]
        public int AgencyId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("info_url")]
        public string InfoUrl { get; set; }

        [JsonProperty("wiki_url")]
        public string WikiUrl { get; set; }

        [JsonProperty("map_url")]
        public string MapUrl { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("map_image")]
        public string MapImage { get; set; }

        [JsonProperty("total_launch_count")]
        public string TotalLaunchCount { get; set; }
    }

    public class PadListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public Pad[] Results { get; set; }
    }

    public class ProgramListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public Program[] Results { get; set; }
    }

    public class SpacecraftListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public Spacecraft[] Results { get; set; }
    }

    public class SpacecraftFlightListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public SpacecraftFlight[] Results { get; set; }
    }

    public class SpacecraftFlightDetailed
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("mission_end")]
        public string MissionEnd { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("launch_crew")]
        public AstronautFlight[] LaunchCrew { get; set; }

        [JsonProperty("onboard_crew")]
        public AstronautFlight[] OnboardCrew { get; set; }

        [JsonProperty("landing_crew")]
        public AstronautFlight[] LandingCrew { get; set; }

        [JsonProperty("spacecraft")]
        public SpacecraftDetailedNoFlights Spacecraft { get; set; }

        [JsonProperty("launch")]
        public LaunchSerializerCommon Launch { get; set; }

        [JsonProperty("docking_events")]
        public DockingEventSerializerForSpacecraftFlight[] DockingEvents { get; set; }
    }

    public class SpacecraftDetailed
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("serial_number")]
        public string SerialNumber { get; set; }

        [JsonProperty("status")]
        public SpacecraftStatus Status { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("spacecraft_config")]
        public SpacecraftConfigurationDetail SpacecraftConfig { get; set; }

        [JsonProperty("flights")]
        public SpacecraftFlight[] Flights { get; set; }
    }

    public class SpacestationListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public SpaceStation[] Results { get; set; }
    }

    public class SpaceStation
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public SpaceStationStatus Status { get; set; }

        [JsonProperty("type")]
        public SpaceStationType Type { get; set; }

        [JsonProperty("founded")]
        public string Founded { get; set; }

        [JsonProperty("deorbited")]
        public string Deorbited { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("orbit")]
        public string Orbit { get; set; }

        [JsonProperty("owners")]
        public AgencyList[] Owners { get; set; }

        [JsonProperty("active_expedition")]
        public ExpeditionSerializerForSpacestation[] ActiveExpedition { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
    }

    public class SpaceStationType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ExpeditionSerializerForSpacestation
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class SpaceStationDetailed
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public SpaceStationStatus Status { get; set; }

        [JsonProperty("type")]
        public SpaceStationType Type { get; set; }

        [JsonProperty("founded")]
        public string Founded { get; set; }

        [JsonProperty("deorbited")]
        public string Deorbited { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("mass")]
        public double Mass { get; set; }

        [JsonProperty("volume")]
        public int Volume { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("orbit")]
        public string Orbit { get; set; }

        [JsonProperty("onboard_crew")]
        public string OnboardCrew { get; set; }

        [JsonProperty("owners")]
        public Agency[] Owners { get; set; }

        [JsonProperty("active_expeditions")]
        public ExpeditionDetailedSerializerForSpacestation[] ActiveExpeditions { get; set; }

        [JsonProperty("docking_location")]
        public DockingLocationSerializerForSpacestation[] DockingLocation { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
    }

    public class ExpeditionDetailedSerializerForSpacestation
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("crew")]
        public AstronautFlightForExpedition[] Crew { get; set; }
    }

    public class DockingLocationSerializerForSpacestation
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("docked")]
        public DockingEventDetailedSerializerForSpacestation Docked { get; set; }
    }

    public class DockingEventDetailedSerializerForSpacestation
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("docking")]
        public string Docking { get; set; }

        [JsonProperty("departure")]
        public string Departure { get; set; }

        [JsonProperty("flight_vehicle")]
        public SpacecraftFlightForDockingEvent FlightVehicle { get; set; }
    }

    public class SpacecraftFlightForDockingEvent
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("spacecraft")]
        public SpacecraftDetailedNoFlights Spacecraft { get; set; }

        [JsonProperty("launch")]
        public LaunchSerializerCommon Launch { get; set; }
    }

    public class UpdatesListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public Update[] Results { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Launchlibrary2ip;

    public partial class WorkflowManagedActions
    {
        public Launchlibrary2ipActions Launchlibrary2ip(string connectionId) => new Launchlibrary2ipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Launchlibrary2ipTriggers Launchlibrary2ip(string connectionId) => new Launchlibrary2ipTriggers(connectionId);
    }
}