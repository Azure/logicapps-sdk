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
        public IBodyWorkflowAction<AgenciesListResponse> AgenciesList(Expression<Func<bool>> featured = null, Expression<Func<string>> agencyType = null, Expression<Func<string>> countryCode = null, Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/agencies/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (featured != null)
                callPayload.Queries["featured"] = ExpressionConverter.Convert(featured);
            if (agencyType != null)
                callPayload.Queries["agency_type"] = ExpressionConverter.Convert(agencyType);
            if (countryCode != null)
                callPayload.Queries["country_code"] = ExpressionConverter.Convert(countryCode);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<AgenciesListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<AgencySerializerDetailed> AgenciesRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/agencies/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AgencySerializerDetailed>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<AstronautListResponse> AstronautList(Expression<Func<string>> name = null, Expression<Func<string>> nationality = null, Expression<Func<string>> dateOfDeath = null, Expression<Func<string>> agencyAbbrev = null, Expression<Func<string>> agencyName = null, Expression<Func<string>> dateOfBirth = null, Expression<Func<string>> status = null, Expression<Func<string>> dateOfBirthGt = null, Expression<Func<string>> dateOfBirthLt = null, Expression<Func<string>> dateOfBirthGte = null, Expression<Func<string>> dateOfBirthLte = null, Expression<Func<string>> dateOfDeathGt = null, Expression<Func<string>> dateOfDeathLt = null, Expression<Func<string>> dateOfDeathGte = null, Expression<Func<string>> dateOfDeathLte = null, Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/astronaut/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (nationality != null)
                callPayload.Queries["nationality"] = ExpressionConverter.Convert(nationality);
            if (dateOfDeath != null)
                callPayload.Queries["date_of_death"] = ExpressionConverter.Convert(dateOfDeath);
            if (agencyAbbrev != null)
                callPayload.Queries["agency__abbrev"] = ExpressionConverter.Convert(agencyAbbrev);
            if (agencyName != null)
                callPayload.Queries["agency__name"] = ExpressionConverter.Convert(agencyName);
            if (dateOfBirth != null)
                callPayload.Queries["date_of_birth"] = ExpressionConverter.Convert(dateOfBirth);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (dateOfBirthGt != null)
                callPayload.Queries["date_of_birth__gt"] = ExpressionConverter.Convert(dateOfBirthGt);
            if (dateOfBirthLt != null)
                callPayload.Queries["date_of_birth__lt"] = ExpressionConverter.Convert(dateOfBirthLt);
            if (dateOfBirthGte != null)
                callPayload.Queries["date_of_birth__gte"] = ExpressionConverter.Convert(dateOfBirthGte);
            if (dateOfBirthLte != null)
                callPayload.Queries["date_of_birth__lte"] = ExpressionConverter.Convert(dateOfBirthLte);
            if (dateOfDeathGt != null)
                callPayload.Queries["date_of_death__gt"] = ExpressionConverter.Convert(dateOfDeathGt);
            if (dateOfDeathLt != null)
                callPayload.Queries["date_of_death__lt"] = ExpressionConverter.Convert(dateOfDeathLt);
            if (dateOfDeathGte != null)
                callPayload.Queries["date_of_death__gte"] = ExpressionConverter.Convert(dateOfDeathGte);
            if (dateOfDeathLte != null)
                callPayload.Queries["date_of_death__lte"] = ExpressionConverter.Convert(dateOfDeathLte);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<AstronautListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<AstronautDetailed> AstronautRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/astronaut/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AstronautDetailed>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigAgencytypeListResponse> ConfigAgencytypeList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/config/agencytype/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ConfigAgencytypeListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<AgencyType> ConfigAgencytypeRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/config/agencytype/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AgencyType>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigAstronautroleListResponse> ConfigAstronautroleList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/config/astronautrole/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ConfigAstronautroleListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<AstronautRole> ConfigAstronautroleRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/config/astronautrole/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AstronautRole>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigAstronautstatusListResponse> ConfigAstronautstatusList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/config/astronautstatus/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ConfigAstronautstatusListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<AstronautStatus> ConfigAstronautstatusRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/config/astronautstatus/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AstronautStatus>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigAstronauttypeListResponse> ConfigAstronauttypeList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/config/astronauttype/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ConfigAstronauttypeListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<AstronautType> ConfigAstronauttypeRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/config/astronauttype/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AstronautType>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigDockinglocationListResponse> ConfigDockinglocationList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/config/dockinglocation/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ConfigDockinglocationListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<DockingLocation> ConfigDockinglocationRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/config/dockinglocation/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DockingLocation>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigEventtypeListResponse> ConfigEventtypeList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/config/eventtype/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ConfigEventtypeListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<EventType> ConfigEventtypeRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/config/eventtype/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EventType>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigFirststagetypeListResponse> ConfigFirststagetypeList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/config/firststagetype/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ConfigFirststagetypeListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<FirstStageType> ConfigFirststagetypeRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/config/firststagetype/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FirstStageType>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigLandinglocationListResponse> ConfigLandinglocationList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/config/landinglocation/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ConfigLandinglocationListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LandingLocation> ConfigLandinglocationRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/config/landinglocation/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LandingLocation>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigLauncherListResponse> ConfigLauncherList(Expression<Func<string>> family = null, Expression<Func<string>> name = null, Expression<Func<string>> manufacturer = null, Expression<Func<string>> fullName = null, Expression<Func<string>> active = null, Expression<Func<string>> reusable = null, Expression<Func<string>> program = null, Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/config/launcher/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (family != null)
                callPayload.Queries["family"] = ExpressionConverter.Convert(family);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (manufacturer != null)
                callPayload.Queries["manufacturer"] = ExpressionConverter.Convert(manufacturer);
            if (fullName != null)
                callPayload.Queries["full_name"] = ExpressionConverter.Convert(fullName);
            if (active != null)
                callPayload.Queries["active"] = ExpressionConverter.Convert(active);
            if (reusable != null)
                callPayload.Queries["reusable"] = ExpressionConverter.Convert(reusable);
            if (program != null)
                callPayload.Queries["program"] = ExpressionConverter.Convert(program);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ConfigLauncherListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LauncherConfigDetail> ConfigLauncherRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/config/launcher/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LauncherConfigDetail>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigLaunchstatusListResponse> ConfigLaunchstatusList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/config/launchstatus/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ConfigLaunchstatusListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LaunchStatus> ConfigLaunchstatusRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/config/launchstatus/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LaunchStatus>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigMissiontypeListResponse> ConfigMissiontypeList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/config/missiontype/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ConfigMissiontypeListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<MissionType> ConfigMissiontypeRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/config/missiontype/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MissionType>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigNoticetypeListResponse> ConfigNoticetypeList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/config/noticetype/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ConfigNoticetypeListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<NoticeType> ConfigNoticetypeRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/config/noticetype/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<NoticeType>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigOrbitListResponse> ConfigOrbitList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/config/orbit/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ConfigOrbitListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<Orbit> ConfigOrbitRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/config/orbit/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Orbit>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigRoadclosurestatusListResponse> ConfigRoadclosurestatusList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/config/roadclosurestatus/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ConfigRoadclosurestatusListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<RoadClosureStatus> ConfigRoadclosurestatusRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/config/roadclosurestatus/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<RoadClosureStatus>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigSpacecraftListResponse> ConfigSpacecraftList(Expression<Func<string>> name = null, Expression<Func<string>> manufacturer = null, Expression<Func<string>> inUse = null, Expression<Func<string>> humanRated = null, Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/config/spacecraft/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (manufacturer != null)
                callPayload.Queries["manufacturer"] = ExpressionConverter.Convert(manufacturer);
            if (inUse != null)
                callPayload.Queries["in_use"] = ExpressionConverter.Convert(inUse);
            if (humanRated != null)
                callPayload.Queries["human_rated"] = ExpressionConverter.Convert(humanRated);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ConfigSpacecraftListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<SpacecraftConfigurationDetail> ConfigSpacecraftRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/config/spacecraft/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SpacecraftConfigurationDetail>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigSpacecraftstatusListResponse> ConfigSpacecraftstatusList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/config/spacecraftstatus/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ConfigSpacecraftstatusListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<SpacecraftStatus> ConfigSpacecraftstatusRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/config/spacecraftstatus/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SpacecraftStatus>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigSpacestationstatusListResponse> ConfigSpacestationstatusList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/config/spacestationstatus/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ConfigSpacestationstatusListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<SpaceStationStatus> ConfigSpacestationstatusRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/config/spacestationstatus/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SpaceStationStatus>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<DockingEventListResponse> DockingEventList(Expression<Func<double>> spaceStationId = null, Expression<Func<double>> dockingLocationId = null, Expression<Func<double>> flightVehicleId = null, Expression<Func<string>> dockingGt = null, Expression<Func<string>> dockingLt = null, Expression<Func<string>> dockingGte = null, Expression<Func<string>> dockingLte = null, Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/docking_event/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (spaceStationId != null)
                callPayload.Queries["space_station__id"] = ExpressionConverter.Convert(spaceStationId);
            if (dockingLocationId != null)
                callPayload.Queries["docking_location__id"] = ExpressionConverter.Convert(dockingLocationId);
            if (flightVehicleId != null)
                callPayload.Queries["flight_vehicle__id"] = ExpressionConverter.Convert(flightVehicleId);
            if (dockingGt != null)
                callPayload.Queries["docking__gt"] = ExpressionConverter.Convert(dockingGt);
            if (dockingLt != null)
                callPayload.Queries["docking__lt"] = ExpressionConverter.Convert(dockingLt);
            if (dockingGte != null)
                callPayload.Queries["docking__gte"] = ExpressionConverter.Convert(dockingGte);
            if (dockingLte != null)
                callPayload.Queries["docking__lte"] = ExpressionConverter.Convert(dockingLte);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<DockingEventListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<DockingEventDetailed> DockingEventRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/docking_event/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DockingEventDetailed>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<EventListResponse> EventList(Expression<Func<string>> slug = null, Expression<Func<double>> id = null, Expression<Func<string>> type = null, Expression<Func<string>> program = null, Expression<Func<string>> search = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/event/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (slug != null)
                callPayload.Queries["slug"] = ExpressionConverter.Convert(slug);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            if (program != null)
                callPayload.Queries["program"] = ExpressionConverter.Convert(program);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<EventListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<EventPreviousListResponse> EventPreviousList(Expression<Func<string>> type = null, Expression<Func<string>> program = null, Expression<Func<string>> search = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/event/previous/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            if (program != null)
                callPayload.Queries["program"] = ExpressionConverter.Convert(program);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<EventPreviousListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<Events> EventPreviousRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/event/previous/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Events>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<EventUpcomingListResponse> EventUpcomingList(Expression<Func<string>> type = null, Expression<Func<string>> program = null, Expression<Func<string>> search = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/event/upcoming/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            if (program != null)
                callPayload.Queries["program"] = ExpressionConverter.Convert(program);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<EventUpcomingListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<Events> EventUpcomingRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/event/upcoming/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Events>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<Events> EventRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/event/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Events>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ExpeditionListResponse> ExpeditionList(Expression<Func<string>> crewAstronaut = null, Expression<Func<string>> name = null, Expression<Func<string>> spaceStation = null, Expression<Func<string>> crewAstronautAgency = null, Expression<Func<string>> startGt = null, Expression<Func<string>> startLt = null, Expression<Func<string>> startGte = null, Expression<Func<string>> startLte = null, Expression<Func<string>> endGt = null, Expression<Func<string>> endLt = null, Expression<Func<string>> endGte = null, Expression<Func<string>> endLte = null, Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/expedition/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (crewAstronaut != null)
                callPayload.Queries["crew__astronaut"] = ExpressionConverter.Convert(crewAstronaut);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (spaceStation != null)
                callPayload.Queries["space_station"] = ExpressionConverter.Convert(spaceStation);
            if (crewAstronautAgency != null)
                callPayload.Queries["crew__astronaut__agency"] = ExpressionConverter.Convert(crewAstronautAgency);
            if (startGt != null)
                callPayload.Queries["start__gt"] = ExpressionConverter.Convert(startGt);
            if (startLt != null)
                callPayload.Queries["start__lt"] = ExpressionConverter.Convert(startLt);
            if (startGte != null)
                callPayload.Queries["start__gte"] = ExpressionConverter.Convert(startGte);
            if (startLte != null)
                callPayload.Queries["start__lte"] = ExpressionConverter.Convert(startLte);
            if (endGt != null)
                callPayload.Queries["end__gt"] = ExpressionConverter.Convert(endGt);
            if (endLt != null)
                callPayload.Queries["end__lt"] = ExpressionConverter.Convert(endLt);
            if (endGte != null)
                callPayload.Queries["end__gte"] = ExpressionConverter.Convert(endGte);
            if (endLte != null)
                callPayload.Queries["end__lte"] = ExpressionConverter.Convert(endLte);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ExpeditionListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ExpeditionDetail> ExpeditionRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/expedition/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ExpeditionDetail>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<UplistResponse> Uplist(Expression<Func<string>> name = null, Expression<Func<string>> slug = null, Expression<Func<string>> rocketConfigurationName = null, Expression<Func<double>> rocketConfigurationId = null, Expression<Func<string>> status = null, Expression<Func<string>> rocketSpacecraftflightSpacecraftName = null, Expression<Func<string>> rocketSpacecraftflightSpacecraftNameIcontains = null, Expression<Func<double>> rocketSpacecraftflightSpacecraftId = null, Expression<Func<string>> rocketConfigurationManufacturerName = null, Expression<Func<string>> rocketConfigurationManufacturerNameIcontains = null, Expression<Func<string>> rocketConfigurationFullName = null, Expression<Func<string>> rocketConfigurationFullNameIcontains = null, Expression<Func<string>> missionOrbitName = null, Expression<Func<string>> missionOrbitNameIcontains = null, Expression<Func<string>> rSpacexApiId = null, Expression<Func<string>> netGt = null, Expression<Func<string>> netLt = null, Expression<Func<string>> netGte = null, Expression<Func<string>> netLte = null, Expression<Func<string>> windowStartGt = null, Expression<Func<string>> windowStartLt = null, Expression<Func<string>> windowStartGte = null, Expression<Func<string>> windowStartLte = null, Expression<Func<string>> windowEndGt = null, Expression<Func<string>> windowEndLt = null, Expression<Func<string>> windowEndGte = null, Expression<Func<string>> windowEndLte = null, Expression<Func<string>> lastUpdatedGte = null, Expression<Func<string>> lastUpdatedLte = null, Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<int[]>> locationIds = null, Expression<Func<int[]>> lspIds = null, Expression<Func<bool>> isCrewed = null, Expression<Func<bool>> includeSuborbital = null, Expression<Func<string>> serialNumber = null, Expression<Func<string>> lspName = null, Expression<Func<int>> lspId = null, Expression<Func<int>> lspConfigId = null, Expression<Func<int[]>> spacecraftConfigIds = null, Expression<Func<bool>> related = null)
        {
            var apiCallPath = "/launch/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (slug != null)
                callPayload.Queries["slug"] = ExpressionConverter.Convert(slug);
            if (rocketConfigurationName != null)
                callPayload.Queries["rocket__configuration__name"] = ExpressionConverter.Convert(rocketConfigurationName);
            if (rocketConfigurationId != null)
                callPayload.Queries["rocket__configuration__id"] = ExpressionConverter.Convert(rocketConfigurationId);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (rocketSpacecraftflightSpacecraftName != null)
                callPayload.Queries["rocket__spacecraftflight__spacecraft__name"] = ExpressionConverter.Convert(rocketSpacecraftflightSpacecraftName);
            if (rocketSpacecraftflightSpacecraftNameIcontains != null)
                callPayload.Queries["rocket__spacecraftflight__spacecraft__name__icontains"] = ExpressionConverter.Convert(rocketSpacecraftflightSpacecraftNameIcontains);
            if (rocketSpacecraftflightSpacecraftId != null)
                callPayload.Queries["rocket__spacecraftflight__spacecraft__id"] = ExpressionConverter.Convert(rocketSpacecraftflightSpacecraftId);
            if (rocketConfigurationManufacturerName != null)
                callPayload.Queries["rocket__configuration__manufacturer__name"] = ExpressionConverter.Convert(rocketConfigurationManufacturerName);
            if (rocketConfigurationManufacturerNameIcontains != null)
                callPayload.Queries["rocket__configuration__manufacturer__name__icontains"] = ExpressionConverter.Convert(rocketConfigurationManufacturerNameIcontains);
            if (rocketConfigurationFullName != null)
                callPayload.Queries["rocket__configuration__full_name"] = ExpressionConverter.Convert(rocketConfigurationFullName);
            if (rocketConfigurationFullNameIcontains != null)
                callPayload.Queries["rocket__configuration__full_name__icontains"] = ExpressionConverter.Convert(rocketConfigurationFullNameIcontains);
            if (missionOrbitName != null)
                callPayload.Queries["mission__orbit__name"] = ExpressionConverter.Convert(missionOrbitName);
            if (missionOrbitNameIcontains != null)
                callPayload.Queries["mission__orbit__name__icontains"] = ExpressionConverter.Convert(missionOrbitNameIcontains);
            if (rSpacexApiId != null)
                callPayload.Queries["r_spacex_api_id"] = ExpressionConverter.Convert(rSpacexApiId);
            if (netGt != null)
                callPayload.Queries["net__gt"] = ExpressionConverter.Convert(netGt);
            if (netLt != null)
                callPayload.Queries["net__lt"] = ExpressionConverter.Convert(netLt);
            if (netGte != null)
                callPayload.Queries["net__gte"] = ExpressionConverter.Convert(netGte);
            if (netLte != null)
                callPayload.Queries["net__lte"] = ExpressionConverter.Convert(netLte);
            if (windowStartGt != null)
                callPayload.Queries["window_start__gt"] = ExpressionConverter.Convert(windowStartGt);
            if (windowStartLt != null)
                callPayload.Queries["window_start__lt"] = ExpressionConverter.Convert(windowStartLt);
            if (windowStartGte != null)
                callPayload.Queries["window_start__gte"] = ExpressionConverter.Convert(windowStartGte);
            if (windowStartLte != null)
                callPayload.Queries["window_start__lte"] = ExpressionConverter.Convert(windowStartLte);
            if (windowEndGt != null)
                callPayload.Queries["window_end__gt"] = ExpressionConverter.Convert(windowEndGt);
            if (windowEndLt != null)
                callPayload.Queries["window_end__lt"] = ExpressionConverter.Convert(windowEndLt);
            if (windowEndGte != null)
                callPayload.Queries["window_end__gte"] = ExpressionConverter.Convert(windowEndGte);
            if (windowEndLte != null)
                callPayload.Queries["window_end__lte"] = ExpressionConverter.Convert(windowEndLte);
            if (lastUpdatedGte != null)
                callPayload.Queries["last_updated__gte"] = ExpressionConverter.Convert(lastUpdatedGte);
            if (lastUpdatedLte != null)
                callPayload.Queries["last_updated__lte"] = ExpressionConverter.Convert(lastUpdatedLte);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (locationIds != null)
                callPayload.Queries["location__ids"] = ExpressionConverter.Convert(locationIds);
            if (lspIds != null)
                callPayload.Queries["lsp__ids"] = ExpressionConverter.Convert(lspIds);
            callPayload.Queries["is_crewed"] = Convert.ToString(false);
            if (isCrewed != null)
                callPayload.Queries["is_crewed"] = ExpressionConverter.Convert(isCrewed);
            callPayload.Queries["include_suborbital"] = Convert.ToString(true);
            if (includeSuborbital != null)
                callPayload.Queries["include_suborbital"] = ExpressionConverter.Convert(includeSuborbital);
            if (serialNumber != null)
                callPayload.Queries["serial_number"] = ExpressionConverter.Convert(serialNumber);
            if (lspName != null)
                callPayload.Queries["lsp__name"] = ExpressionConverter.Convert(lspName);
            if (lspId != null)
                callPayload.Queries["lsp__id"] = ExpressionConverter.Convert(lspId);
            if (lspConfigId != null)
                callPayload.Queries["lsp__config_id"] = ExpressionConverter.Convert(lspConfigId);
            if (spacecraftConfigIds != null)
                callPayload.Queries["spacecraft_config_ids"] = ExpressionConverter.Convert(spacecraftConfigIds);
            callPayload.Queries["related"] = Convert.ToString(false);
            if (related != null)
                callPayload.Queries["related"] = ExpressionConverter.Convert(related);
            return new ApiConnectionAction<UplistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LaunchPreviousListResponse> LaunchPreviousList(Expression<Func<string>> name = null, Expression<Func<string>> slug = null, Expression<Func<string>> rocketConfigurationName = null, Expression<Func<double>> rocketConfigurationId = null, Expression<Func<string>> status = null, Expression<Func<string>> rocketSpacecraftflightSpacecraftName = null, Expression<Func<string>> rocketSpacecraftflightSpacecraftIcontains = null, Expression<Func<double>> rocketSpacecraftflightSpacecraftId = null, Expression<Func<string>> rocketConfigurationManufacturerName = null, Expression<Func<string>> rocketConfigurationManufacturerNameIcontains = null, Expression<Func<string>> rocketConfigurationFullName = null, Expression<Func<string>> rocketConfigurationFullNameIcontains = null, Expression<Func<string>> missionOrbitName = null, Expression<Func<string>> missionOrbitNameIcontains = null, Expression<Func<string>> program = null, Expression<Func<string>> rSpacexApiId = null, Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<int[]>> locationIds = null, Expression<Func<int[]>> lspIds = null, Expression<Func<bool>> isCrewed = null, Expression<Func<bool>> includeSuborbital = null, Expression<Func<string>> serialNumber = null, Expression<Func<string>> lspName = null, Expression<Func<int>> lspId = null, Expression<Func<int>> lspConfigId = null, Expression<Func<int[]>> spacecraftConfigIds = null, Expression<Func<bool>> related = null)
        {
            var apiCallPath = "/launch/previous/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (slug != null)
                callPayload.Queries["slug"] = ExpressionConverter.Convert(slug);
            if (rocketConfigurationName != null)
                callPayload.Queries["rocket__configuration__name"] = ExpressionConverter.Convert(rocketConfigurationName);
            if (rocketConfigurationId != null)
                callPayload.Queries["rocket__configuration__id"] = ExpressionConverter.Convert(rocketConfigurationId);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (rocketSpacecraftflightSpacecraftName != null)
                callPayload.Queries["rocket__spacecraftflight__spacecraft__name"] = ExpressionConverter.Convert(rocketSpacecraftflightSpacecraftName);
            if (rocketSpacecraftflightSpacecraftIcontains != null)
                callPayload.Queries["rocket__spacecraftflight__spacecraft__icontains"] = ExpressionConverter.Convert(rocketSpacecraftflightSpacecraftIcontains);
            if (rocketSpacecraftflightSpacecraftId != null)
                callPayload.Queries["rocket__spacecraftflight__spacecraft__id"] = ExpressionConverter.Convert(rocketSpacecraftflightSpacecraftId);
            if (rocketConfigurationManufacturerName != null)
                callPayload.Queries["rocket__configuration__manufacturer__name"] = ExpressionConverter.Convert(rocketConfigurationManufacturerName);
            if (rocketConfigurationManufacturerNameIcontains != null)
                callPayload.Queries["rocket__configuration__manufacturer__name__icontains"] = ExpressionConverter.Convert(rocketConfigurationManufacturerNameIcontains);
            if (rocketConfigurationFullName != null)
                callPayload.Queries["rocket__configuration__full_name"] = ExpressionConverter.Convert(rocketConfigurationFullName);
            if (rocketConfigurationFullNameIcontains != null)
                callPayload.Queries["rocket__configuration__full_name__icontains"] = ExpressionConverter.Convert(rocketConfigurationFullNameIcontains);
            if (missionOrbitName != null)
                callPayload.Queries["mission__orbit__name"] = ExpressionConverter.Convert(missionOrbitName);
            if (missionOrbitNameIcontains != null)
                callPayload.Queries["mission__orbit__name__icontains"] = ExpressionConverter.Convert(missionOrbitNameIcontains);
            if (program != null)
                callPayload.Queries["program"] = ExpressionConverter.Convert(program);
            if (rSpacexApiId != null)
                callPayload.Queries["r_spacex_api_id"] = ExpressionConverter.Convert(rSpacexApiId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (locationIds != null)
                callPayload.Queries["location__ids"] = ExpressionConverter.Convert(locationIds);
            if (lspIds != null)
                callPayload.Queries["lsp__ids"] = ExpressionConverter.Convert(lspIds);
            callPayload.Queries["is_crewed"] = Convert.ToString(false);
            if (isCrewed != null)
                callPayload.Queries["is_crewed"] = ExpressionConverter.Convert(isCrewed);
            callPayload.Queries["include_suborbital"] = Convert.ToString(true);
            if (includeSuborbital != null)
                callPayload.Queries["include_suborbital"] = ExpressionConverter.Convert(includeSuborbital);
            if (serialNumber != null)
                callPayload.Queries["serial_number"] = ExpressionConverter.Convert(serialNumber);
            if (lspName != null)
                callPayload.Queries["lsp__name"] = ExpressionConverter.Convert(lspName);
            if (lspId != null)
                callPayload.Queries["lsp__id"] = ExpressionConverter.Convert(lspId);
            if (lspConfigId != null)
                callPayload.Queries["lsp__config__id"] = ExpressionConverter.Convert(lspConfigId);
            if (spacecraftConfigIds != null)
                callPayload.Queries["spacecraft_config_ids"] = ExpressionConverter.Convert(spacecraftConfigIds);
            callPayload.Queries["related"] = Convert.ToString(false);
            if (related != null)
                callPayload.Queries["related"] = ExpressionConverter.Convert(related);
            return new ApiConnectionAction<LaunchPreviousListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LaunchDetailed> LaunchPreviousRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/launch/previous/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LaunchDetailed>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LaunchUpcomingListResponse> LaunchUpcomingList(Expression<Func<string>> name = null, Expression<Func<string>> slug = null, Expression<Func<string>> rocketConfigurationName = null, Expression<Func<double>> rocketConfigurationId = null, Expression<Func<string>> status = null, Expression<Func<string>> rocketSpacecraftflightSpacecraftName = null, Expression<Func<string>> rocketSpacecraftflightSpacecraftNameIcontains = null, Expression<Func<double>> rocketSpacecraftflightSpacecraftId = null, Expression<Func<string>> rocketConfigurationManufacturerName = null, Expression<Func<string>> rocketConfigurationManufacturerNameIcontains = null, Expression<Func<string>> rocketConfigurationFullName = null, Expression<Func<string>> rocketConfigurationFullNameIcontains = null, Expression<Func<string>> missionOrbitName = null, Expression<Func<string>> missionOrbitNameIcontains = null, Expression<Func<string>> program = null, Expression<Func<string>> rSpacexApiId = null, Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<int[]>> locationIds = null, Expression<Func<int[]>> lspIds = null, Expression<Func<bool>> isCrewed = null, Expression<Func<bool>> includeSuborbital = null, Expression<Func<string>> serialNumber = null, Expression<Func<string>> lspName = null, Expression<Func<int>> lspId = null, Expression<Func<int>> lspConfigId = null, Expression<Func<int[]>> spacecraftConfigIds = null, Expression<Func<bool>> related = null, Expression<Func<bool>> hideRecentPrevious = null)
        {
            var apiCallPath = "/launch/upcoming/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (slug != null)
                callPayload.Queries["slug"] = ExpressionConverter.Convert(slug);
            if (rocketConfigurationName != null)
                callPayload.Queries["rocket__configuration__name"] = ExpressionConverter.Convert(rocketConfigurationName);
            if (rocketConfigurationId != null)
                callPayload.Queries["rocket__configuration__id"] = ExpressionConverter.Convert(rocketConfigurationId);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (rocketSpacecraftflightSpacecraftName != null)
                callPayload.Queries["rocket__spacecraftflight__spacecraft__name"] = ExpressionConverter.Convert(rocketSpacecraftflightSpacecraftName);
            if (rocketSpacecraftflightSpacecraftNameIcontains != null)
                callPayload.Queries["rocket__spacecraftflight__spacecraft__name__icontains"] = ExpressionConverter.Convert(rocketSpacecraftflightSpacecraftNameIcontains);
            if (rocketSpacecraftflightSpacecraftId != null)
                callPayload.Queries["rocket__spacecraftflight__spacecraft__id"] = ExpressionConverter.Convert(rocketSpacecraftflightSpacecraftId);
            if (rocketConfigurationManufacturerName != null)
                callPayload.Queries["rocket__configuration__manufacturer__name"] = ExpressionConverter.Convert(rocketConfigurationManufacturerName);
            if (rocketConfigurationManufacturerNameIcontains != null)
                callPayload.Queries["rocket__configuration__manufacturer__name__icontains"] = ExpressionConverter.Convert(rocketConfigurationManufacturerNameIcontains);
            if (rocketConfigurationFullName != null)
                callPayload.Queries["rocket__configuration__full_name"] = ExpressionConverter.Convert(rocketConfigurationFullName);
            if (rocketConfigurationFullNameIcontains != null)
                callPayload.Queries["rocket__configuration__full_name__icontains"] = ExpressionConverter.Convert(rocketConfigurationFullNameIcontains);
            if (missionOrbitName != null)
                callPayload.Queries["mission__orbit__name"] = ExpressionConverter.Convert(missionOrbitName);
            if (missionOrbitNameIcontains != null)
                callPayload.Queries["mission__orbit__name__icontains"] = ExpressionConverter.Convert(missionOrbitNameIcontains);
            if (program != null)
                callPayload.Queries["program"] = ExpressionConverter.Convert(program);
            if (rSpacexApiId != null)
                callPayload.Queries["r_spacex_api_id"] = ExpressionConverter.Convert(rSpacexApiId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (locationIds != null)
                callPayload.Queries["location__ids"] = ExpressionConverter.Convert(locationIds);
            if (lspIds != null)
                callPayload.Queries["lsp__ids"] = ExpressionConverter.Convert(lspIds);
            callPayload.Queries["is_crewed"] = Convert.ToString(false);
            if (isCrewed != null)
                callPayload.Queries["is_crewed"] = ExpressionConverter.Convert(isCrewed);
            callPayload.Queries["include_suborbital"] = Convert.ToString(true);
            if (includeSuborbital != null)
                callPayload.Queries["include_suborbital"] = ExpressionConverter.Convert(includeSuborbital);
            if (serialNumber != null)
                callPayload.Queries["serial_number"] = ExpressionConverter.Convert(serialNumber);
            if (lspName != null)
                callPayload.Queries["lsp__name"] = ExpressionConverter.Convert(lspName);
            if (lspId != null)
                callPayload.Queries["lsp__id"] = ExpressionConverter.Convert(lspId);
            if (lspConfigId != null)
                callPayload.Queries["lsp__config__id"] = ExpressionConverter.Convert(lspConfigId);
            if (spacecraftConfigIds != null)
                callPayload.Queries["spacecraft_config_ids"] = ExpressionConverter.Convert(spacecraftConfigIds);
            callPayload.Queries["related"] = Convert.ToString(false);
            if (related != null)
                callPayload.Queries["related"] = ExpressionConverter.Convert(related);
            callPayload.Queries["hide_recent_previous"] = Convert.ToString(false);
            if (hideRecentPrevious != null)
                callPayload.Queries["hide_recent_previous"] = ExpressionConverter.Convert(hideRecentPrevious);
            return new ApiConnectionAction<LaunchUpcomingListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LaunchDetailed> LaunchUpcomingRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/launch/upcoming/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LaunchDetailed>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LaunchDetailed> LaunchRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/launch/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LaunchDetailed>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LauncherListResponse> LauncherList(Expression<Func<double>> id = null, Expression<Func<string>> serialNumber = null, Expression<Func<string>> flightProven = null, Expression<Func<string>> launcherConfig = null, Expression<Func<string>> launcherConfigManufacturer = null, Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/launcher/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (serialNumber != null)
                callPayload.Queries["serial_number"] = ExpressionConverter.Convert(serialNumber);
            if (flightProven != null)
                callPayload.Queries["flight_proven"] = ExpressionConverter.Convert(flightProven);
            if (launcherConfig != null)
                callPayload.Queries["launcher_config"] = ExpressionConverter.Convert(launcherConfig);
            if (launcherConfigManufacturer != null)
                callPayload.Queries["launcher_config__manufacturer"] = ExpressionConverter.Convert(launcherConfigManufacturer);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<LauncherListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LauncherDetail> LauncherRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/launcher/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LauncherDetail>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LocationListResponse> LocationList(Expression<Func<string>> name = null, Expression<Func<string>> countryCode = null, Expression<Func<double>> id = null, Expression<Func<string>> padLocationId = null, Expression<Func<string>> search = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/location/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (countryCode != null)
                callPayload.Queries["country_code"] = ExpressionConverter.Convert(countryCode);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (padLocationId != null)
                callPayload.Queries["pad__location_id"] = ExpressionConverter.Convert(padLocationId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<LocationListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LocationDetail> LocationRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/location/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LocationDetail>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<PadListResponse> PadList(Expression<Func<string>> name = null, Expression<Func<double>> id = null, Expression<Func<string>> location = null, Expression<Func<string>> search = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/pad/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (location != null)
                callPayload.Queries["location"] = ExpressionConverter.Convert(location);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<PadListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<Pad> PadRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/pad/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Pad>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ProgramListResponse> ProgramList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/program/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ProgramListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<Program> ProgramRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/program/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Program>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<SpacecraftListResponse> SpacecraftList(Expression<Func<string>> name = null, Expression<Func<string>> status = null, Expression<Func<string>> spacecraftConfig = null, Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/spacecraft/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (spacecraftConfig != null)
                callPayload.Queries["spacecraft_config"] = ExpressionConverter.Convert(spacecraftConfig);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<SpacecraftListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<SpacecraftFlightListResponse> SpacecraftFlightList(Expression<Func<string>> spacecraft = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/spacecraft/flight/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (spacecraft != null)
                callPayload.Queries["spacecraft"] = ExpressionConverter.Convert(spacecraft);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<SpacecraftFlightListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<SpacecraftFlightDetailed> SpacecraftFlightRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/spacecraft/flight/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SpacecraftFlightDetailed>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<SpacecraftDetailed> SpacecraftRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/spacecraft/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SpacecraftDetailed>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<SpacestationListResponse> SpacestationList(Expression<Func<string>> name = null, Expression<Func<string>> status = null, Expression<Func<string>> owners = null, Expression<Func<string>> orbit = null, Expression<Func<string>> type = null, Expression<Func<string>> ownersName = null, Expression<Func<string>> ownersAbbrev = null, Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/spacestation/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (owners != null)
                callPayload.Queries["owners"] = ExpressionConverter.Convert(owners);
            if (orbit != null)
                callPayload.Queries["orbit"] = ExpressionConverter.Convert(orbit);
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            if (ownersName != null)
                callPayload.Queries["owners__name"] = ExpressionConverter.Convert(ownersName);
            if (ownersAbbrev != null)
                callPayload.Queries["owners__abbrev"] = ExpressionConverter.Convert(ownersAbbrev);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<SpacestationListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<SpaceStationDetailed> SpacestationRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/spacestation/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SpaceStationDetailed>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<UpdatesListResponse> UpdatesList(Expression<Func<string>> createdOn = null, Expression<Func<string>> launch = null, Expression<Func<string>> program = null, Expression<Func<string>> launchLaunchServiceProvider = null, Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/updates/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (createdOn != null)
                callPayload.Queries["created_on"] = ExpressionConverter.Convert(createdOn);
            if (launch != null)
                callPayload.Queries["launch"] = ExpressionConverter.Convert(launch);
            if (program != null)
                callPayload.Queries["program"] = ExpressionConverter.Convert(program);
            if (launchLaunchServiceProvider != null)
                callPayload.Queries["launch__launch_service_provider"] = ExpressionConverter.Convert(launchLaunchServiceProvider);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<UpdatesListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<Update> UpdatesRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/updates/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Update>(callPayload);
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