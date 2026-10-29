//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Launchlibrary2ip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Launchlibrary2ipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<AgenciesListResponse, ApiConnectionActionConfiguration> AgenciesList(Expression<Func<bool>> featured = null, Expression<Func<string>> agencyType = null, Expression<Func<string>> countryCode = null, Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_featured = WorkflowExpression.Compile(featured, nameof(featured), required: false);
            var __workflow_agencyType = WorkflowExpression.Compile(agencyType, nameof(agencyType), required: false);
            var __workflow_countryCode = WorkflowExpression.Compile(countryCode, nameof(countryCode), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<AgenciesListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/agencies/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_featured != null)
                    callPayload.Queries["featured"] = ExpressionConverter.Convert(__workflow_featured);
                if (__workflow_agencyType != null)
                    callPayload.Queries["agency_type"] = ExpressionConverter.Convert(__workflow_agencyType);
                if (__workflow_countryCode != null)
                    callPayload.Queries["country_code"] = ExpressionConverter.Convert(__workflow_countryCode);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<AgenciesListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<AgencySerializerDetailed, ApiConnectionActionConfiguration> AgenciesRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<AgencySerializerDetailed, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agencies/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AgencySerializerDetailed>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<AstronautListResponse, ApiConnectionActionConfiguration> AstronautList(Expression<Func<string>> name = null, Expression<Func<string>> nationality = null, Expression<Func<string>> dateOfDeath = null, Expression<Func<string>> agencyAbbrev = null, Expression<Func<string>> agencyName = null, Expression<Func<string>> dateOfBirth = null, Expression<Func<string>> status = null, Expression<Func<string>> dateOfBirthGt = null, Expression<Func<string>> dateOfBirthLt = null, Expression<Func<string>> dateOfBirthGte = null, Expression<Func<string>> dateOfBirthLte = null, Expression<Func<string>> dateOfDeathGt = null, Expression<Func<string>> dateOfDeathLt = null, Expression<Func<string>> dateOfDeathGte = null, Expression<Func<string>> dateOfDeathLte = null, Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_nationality = WorkflowExpression.Compile(nationality, nameof(nationality), required: false);
            var __workflow_dateOfDeath = WorkflowExpression.Compile(dateOfDeath, nameof(dateOfDeath), required: false);
            var __workflow_agencyAbbrev = WorkflowExpression.Compile(agencyAbbrev, nameof(agencyAbbrev), required: false);
            var __workflow_agencyName = WorkflowExpression.Compile(agencyName, nameof(agencyName), required: false);
            var __workflow_dateOfBirth = WorkflowExpression.Compile(dateOfBirth, nameof(dateOfBirth), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_dateOfBirthGt = WorkflowExpression.Compile(dateOfBirthGt, nameof(dateOfBirthGt), required: false);
            var __workflow_dateOfBirthLt = WorkflowExpression.Compile(dateOfBirthLt, nameof(dateOfBirthLt), required: false);
            var __workflow_dateOfBirthGte = WorkflowExpression.Compile(dateOfBirthGte, nameof(dateOfBirthGte), required: false);
            var __workflow_dateOfBirthLte = WorkflowExpression.Compile(dateOfBirthLte, nameof(dateOfBirthLte), required: false);
            var __workflow_dateOfDeathGt = WorkflowExpression.Compile(dateOfDeathGt, nameof(dateOfDeathGt), required: false);
            var __workflow_dateOfDeathLt = WorkflowExpression.Compile(dateOfDeathLt, nameof(dateOfDeathLt), required: false);
            var __workflow_dateOfDeathGte = WorkflowExpression.Compile(dateOfDeathGte, nameof(dateOfDeathGte), required: false);
            var __workflow_dateOfDeathLte = WorkflowExpression.Compile(dateOfDeathLte, nameof(dateOfDeathLte), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<AstronautListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/astronaut/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_nationality != null)
                    callPayload.Queries["nationality"] = ExpressionConverter.Convert(__workflow_nationality);
                if (__workflow_dateOfDeath != null)
                    callPayload.Queries["date_of_death"] = ExpressionConverter.Convert(__workflow_dateOfDeath);
                if (__workflow_agencyAbbrev != null)
                    callPayload.Queries["agency__abbrev"] = ExpressionConverter.Convert(__workflow_agencyAbbrev);
                if (__workflow_agencyName != null)
                    callPayload.Queries["agency__name"] = ExpressionConverter.Convert(__workflow_agencyName);
                if (__workflow_dateOfBirth != null)
                    callPayload.Queries["date_of_birth"] = ExpressionConverter.Convert(__workflow_dateOfBirth);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_dateOfBirthGt != null)
                    callPayload.Queries["date_of_birth__gt"] = ExpressionConverter.Convert(__workflow_dateOfBirthGt);
                if (__workflow_dateOfBirthLt != null)
                    callPayload.Queries["date_of_birth__lt"] = ExpressionConverter.Convert(__workflow_dateOfBirthLt);
                if (__workflow_dateOfBirthGte != null)
                    callPayload.Queries["date_of_birth__gte"] = ExpressionConverter.Convert(__workflow_dateOfBirthGte);
                if (__workflow_dateOfBirthLte != null)
                    callPayload.Queries["date_of_birth__lte"] = ExpressionConverter.Convert(__workflow_dateOfBirthLte);
                if (__workflow_dateOfDeathGt != null)
                    callPayload.Queries["date_of_death__gt"] = ExpressionConverter.Convert(__workflow_dateOfDeathGt);
                if (__workflow_dateOfDeathLt != null)
                    callPayload.Queries["date_of_death__lt"] = ExpressionConverter.Convert(__workflow_dateOfDeathLt);
                if (__workflow_dateOfDeathGte != null)
                    callPayload.Queries["date_of_death__gte"] = ExpressionConverter.Convert(__workflow_dateOfDeathGte);
                if (__workflow_dateOfDeathLte != null)
                    callPayload.Queries["date_of_death__lte"] = ExpressionConverter.Convert(__workflow_dateOfDeathLte);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<AstronautListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<AstronautDetailed, ApiConnectionActionConfiguration> AstronautRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<AstronautDetailed, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/astronaut/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AstronautDetailed>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigAgencytypeListResponse, ApiConnectionActionConfiguration> ConfigAgencytypeList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ConfigAgencytypeListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/config/agencytype/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ConfigAgencytypeListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<AgencyType, ApiConnectionActionConfiguration> ConfigAgencytypeRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<AgencyType, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/config/agencytype/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AgencyType>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigAstronautroleListResponse, ApiConnectionActionConfiguration> ConfigAstronautroleList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ConfigAstronautroleListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/config/astronautrole/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ConfigAstronautroleListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<AstronautRole, ApiConnectionActionConfiguration> ConfigAstronautroleRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<AstronautRole, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/config/astronautrole/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AstronautRole>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigAstronautstatusListResponse, ApiConnectionActionConfiguration> ConfigAstronautstatusList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ConfigAstronautstatusListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/config/astronautstatus/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ConfigAstronautstatusListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<AstronautStatus, ApiConnectionActionConfiguration> ConfigAstronautstatusRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<AstronautStatus, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/config/astronautstatus/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AstronautStatus>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigAstronauttypeListResponse, ApiConnectionActionConfiguration> ConfigAstronauttypeList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ConfigAstronauttypeListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/config/astronauttype/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ConfigAstronauttypeListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<AstronautType, ApiConnectionActionConfiguration> ConfigAstronauttypeRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<AstronautType, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/config/astronauttype/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AstronautType>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigDockinglocationListResponse, ApiConnectionActionConfiguration> ConfigDockinglocationList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ConfigDockinglocationListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/config/dockinglocation/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ConfigDockinglocationListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<DockingLocation, ApiConnectionActionConfiguration> ConfigDockinglocationRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<DockingLocation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/config/dockinglocation/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DockingLocation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigEventtypeListResponse, ApiConnectionActionConfiguration> ConfigEventtypeList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ConfigEventtypeListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/config/eventtype/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ConfigEventtypeListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<EventType, ApiConnectionActionConfiguration> ConfigEventtypeRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<EventType, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/config/eventtype/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EventType>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigFirststagetypeListResponse, ApiConnectionActionConfiguration> ConfigFirststagetypeList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ConfigFirststagetypeListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/config/firststagetype/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ConfigFirststagetypeListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<FirstStageType, ApiConnectionActionConfiguration> ConfigFirststagetypeRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<FirstStageType, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/config/firststagetype/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FirstStageType>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigLandinglocationListResponse, ApiConnectionActionConfiguration> ConfigLandinglocationList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ConfigLandinglocationListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/config/landinglocation/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ConfigLandinglocationListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LandingLocation, ApiConnectionActionConfiguration> ConfigLandinglocationRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<LandingLocation, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/config/landinglocation/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LandingLocation>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigLauncherListResponse, ApiConnectionActionConfiguration> ConfigLauncherList(Expression<Func<string>> family = null, Expression<Func<string>> name = null, Expression<Func<string>> manufacturer = null, Expression<Func<string>> fullName = null, Expression<Func<string>> active = null, Expression<Func<string>> reusable = null, Expression<Func<string>> program = null, Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_family = WorkflowExpression.Compile(family, nameof(family), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_manufacturer = WorkflowExpression.Compile(manufacturer, nameof(manufacturer), required: false);
            var __workflow_fullName = WorkflowExpression.Compile(fullName, nameof(fullName), required: false);
            var __workflow_active = WorkflowExpression.Compile(active, nameof(active), required: false);
            var __workflow_reusable = WorkflowExpression.Compile(reusable, nameof(reusable), required: false);
            var __workflow_program = WorkflowExpression.Compile(program, nameof(program), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ConfigLauncherListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/config/launcher/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_family != null)
                    callPayload.Queries["family"] = ExpressionConverter.Convert(__workflow_family);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_manufacturer != null)
                    callPayload.Queries["manufacturer"] = ExpressionConverter.Convert(__workflow_manufacturer);
                if (__workflow_fullName != null)
                    callPayload.Queries["full_name"] = ExpressionConverter.Convert(__workflow_fullName);
                if (__workflow_active != null)
                    callPayload.Queries["active"] = ExpressionConverter.Convert(__workflow_active);
                if (__workflow_reusable != null)
                    callPayload.Queries["reusable"] = ExpressionConverter.Convert(__workflow_reusable);
                if (__workflow_program != null)
                    callPayload.Queries["program"] = ExpressionConverter.Convert(__workflow_program);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ConfigLauncherListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LauncherConfigDetail, ApiConnectionActionConfiguration> ConfigLauncherRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<LauncherConfigDetail, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/config/launcher/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LauncherConfigDetail>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigLaunchstatusListResponse, ApiConnectionActionConfiguration> ConfigLaunchstatusList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ConfigLaunchstatusListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/config/launchstatus/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ConfigLaunchstatusListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LaunchStatus, ApiConnectionActionConfiguration> ConfigLaunchstatusRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<LaunchStatus, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/config/launchstatus/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LaunchStatus>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigMissiontypeListResponse, ApiConnectionActionConfiguration> ConfigMissiontypeList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ConfigMissiontypeListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/config/missiontype/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ConfigMissiontypeListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<MissionType, ApiConnectionActionConfiguration> ConfigMissiontypeRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<MissionType, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/config/missiontype/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MissionType>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigNoticetypeListResponse, ApiConnectionActionConfiguration> ConfigNoticetypeList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ConfigNoticetypeListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/config/noticetype/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ConfigNoticetypeListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<NoticeType, ApiConnectionActionConfiguration> ConfigNoticetypeRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<NoticeType, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/config/noticetype/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<NoticeType>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigOrbitListResponse, ApiConnectionActionConfiguration> ConfigOrbitList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ConfigOrbitListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/config/orbit/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ConfigOrbitListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<Orbit, ApiConnectionActionConfiguration> ConfigOrbitRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Orbit, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/config/orbit/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Orbit>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigRoadclosurestatusListResponse, ApiConnectionActionConfiguration> ConfigRoadclosurestatusList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ConfigRoadclosurestatusListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/config/roadclosurestatus/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ConfigRoadclosurestatusListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<RoadClosureStatus, ApiConnectionActionConfiguration> ConfigRoadclosurestatusRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<RoadClosureStatus, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/config/roadclosurestatus/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RoadClosureStatus>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigSpacecraftListResponse, ApiConnectionActionConfiguration> ConfigSpacecraftList(Expression<Func<string>> name = null, Expression<Func<string>> manufacturer = null, Expression<Func<string>> inUse = null, Expression<Func<string>> humanRated = null, Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_manufacturer = WorkflowExpression.Compile(manufacturer, nameof(manufacturer), required: false);
            var __workflow_inUse = WorkflowExpression.Compile(inUse, nameof(inUse), required: false);
            var __workflow_humanRated = WorkflowExpression.Compile(humanRated, nameof(humanRated), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ConfigSpacecraftListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/config/spacecraft/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_manufacturer != null)
                    callPayload.Queries["manufacturer"] = ExpressionConverter.Convert(__workflow_manufacturer);
                if (__workflow_inUse != null)
                    callPayload.Queries["in_use"] = ExpressionConverter.Convert(__workflow_inUse);
                if (__workflow_humanRated != null)
                    callPayload.Queries["human_rated"] = ExpressionConverter.Convert(__workflow_humanRated);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ConfigSpacecraftListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<SpacecraftConfigurationDetail, ApiConnectionActionConfiguration> ConfigSpacecraftRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<SpacecraftConfigurationDetail, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/config/spacecraft/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SpacecraftConfigurationDetail>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigSpacecraftstatusListResponse, ApiConnectionActionConfiguration> ConfigSpacecraftstatusList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ConfigSpacecraftstatusListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/config/spacecraftstatus/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ConfigSpacecraftstatusListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<SpacecraftStatus, ApiConnectionActionConfiguration> ConfigSpacecraftstatusRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<SpacecraftStatus, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/config/spacecraftstatus/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SpacecraftStatus>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ConfigSpacestationstatusListResponse, ApiConnectionActionConfiguration> ConfigSpacestationstatusList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ConfigSpacestationstatusListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/config/spacestationstatus/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ConfigSpacestationstatusListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<SpaceStationStatus, ApiConnectionActionConfiguration> ConfigSpacestationstatusRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<SpaceStationStatus, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/config/spacestationstatus/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SpaceStationStatus>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<DockingEventListResponse, ApiConnectionActionConfiguration> DockingEventList(Expression<Func<double>> spaceStationId = null, Expression<Func<double>> dockingLocationId = null, Expression<Func<double>> flightVehicleId = null, Expression<Func<string>> dockingGt = null, Expression<Func<string>> dockingLt = null, Expression<Func<string>> dockingGte = null, Expression<Func<string>> dockingLte = null, Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_spaceStationId = WorkflowExpression.Compile(spaceStationId, nameof(spaceStationId), required: false);
            var __workflow_dockingLocationId = WorkflowExpression.Compile(dockingLocationId, nameof(dockingLocationId), required: false);
            var __workflow_flightVehicleId = WorkflowExpression.Compile(flightVehicleId, nameof(flightVehicleId), required: false);
            var __workflow_dockingGt = WorkflowExpression.Compile(dockingGt, nameof(dockingGt), required: false);
            var __workflow_dockingLt = WorkflowExpression.Compile(dockingLt, nameof(dockingLt), required: false);
            var __workflow_dockingGte = WorkflowExpression.Compile(dockingGte, nameof(dockingGte), required: false);
            var __workflow_dockingLte = WorkflowExpression.Compile(dockingLte, nameof(dockingLte), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<DockingEventListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/docking_event/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_spaceStationId != null)
                    callPayload.Queries["space_station__id"] = ExpressionConverter.Convert(__workflow_spaceStationId);
                if (__workflow_dockingLocationId != null)
                    callPayload.Queries["docking_location__id"] = ExpressionConverter.Convert(__workflow_dockingLocationId);
                if (__workflow_flightVehicleId != null)
                    callPayload.Queries["flight_vehicle__id"] = ExpressionConverter.Convert(__workflow_flightVehicleId);
                if (__workflow_dockingGt != null)
                    callPayload.Queries["docking__gt"] = ExpressionConverter.Convert(__workflow_dockingGt);
                if (__workflow_dockingLt != null)
                    callPayload.Queries["docking__lt"] = ExpressionConverter.Convert(__workflow_dockingLt);
                if (__workflow_dockingGte != null)
                    callPayload.Queries["docking__gte"] = ExpressionConverter.Convert(__workflow_dockingGte);
                if (__workflow_dockingLte != null)
                    callPayload.Queries["docking__lte"] = ExpressionConverter.Convert(__workflow_dockingLte);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<DockingEventListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<DockingEventDetailed, ApiConnectionActionConfiguration> DockingEventRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<DockingEventDetailed, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/docking_event/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DockingEventDetailed>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<EventListResponse, ApiConnectionActionConfiguration> EventList(Expression<Func<string>> slug = null, Expression<Func<double>> id = null, Expression<Func<string>> type = null, Expression<Func<string>> program = null, Expression<Func<string>> search = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_slug = WorkflowExpression.Compile(slug, nameof(slug), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_program = WorkflowExpression.Compile(program, nameof(program), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<EventListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/event/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_slug != null)
                    callPayload.Queries["slug"] = ExpressionConverter.Convert(__workflow_slug);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_program != null)
                    callPayload.Queries["program"] = ExpressionConverter.Convert(__workflow_program);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<EventListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<EventPreviousListResponse, ApiConnectionActionConfiguration> EventPreviousList(Expression<Func<string>> type = null, Expression<Func<string>> program = null, Expression<Func<string>> search = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_program = WorkflowExpression.Compile(program, nameof(program), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<EventPreviousListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/event/previous/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_program != null)
                    callPayload.Queries["program"] = ExpressionConverter.Convert(__workflow_program);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<EventPreviousListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<Events, ApiConnectionActionConfiguration> EventPreviousRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Events, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/event/previous/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Events>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<EventUpcomingListResponse, ApiConnectionActionConfiguration> EventUpcomingList(Expression<Func<string>> type = null, Expression<Func<string>> program = null, Expression<Func<string>> search = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_program = WorkflowExpression.Compile(program, nameof(program), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<EventUpcomingListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/event/upcoming/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_program != null)
                    callPayload.Queries["program"] = ExpressionConverter.Convert(__workflow_program);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<EventUpcomingListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<Events, ApiConnectionActionConfiguration> EventUpcomingRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Events, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/event/upcoming/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Events>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<Events, ApiConnectionActionConfiguration> EventRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Events, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/event/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Events>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ExpeditionListResponse, ApiConnectionActionConfiguration> ExpeditionList(Expression<Func<string>> crewAstronaut = null, Expression<Func<string>> name = null, Expression<Func<string>> spaceStation = null, Expression<Func<string>> crewAstronautAgency = null, Expression<Func<string>> startGt = null, Expression<Func<string>> startLt = null, Expression<Func<string>> startGte = null, Expression<Func<string>> startLte = null, Expression<Func<string>> endGt = null, Expression<Func<string>> endLt = null, Expression<Func<string>> endGte = null, Expression<Func<string>> endLte = null, Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_crewAstronaut = WorkflowExpression.Compile(crewAstronaut, nameof(crewAstronaut), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_spaceStation = WorkflowExpression.Compile(spaceStation, nameof(spaceStation), required: false);
            var __workflow_crewAstronautAgency = WorkflowExpression.Compile(crewAstronautAgency, nameof(crewAstronautAgency), required: false);
            var __workflow_startGt = WorkflowExpression.Compile(startGt, nameof(startGt), required: false);
            var __workflow_startLt = WorkflowExpression.Compile(startLt, nameof(startLt), required: false);
            var __workflow_startGte = WorkflowExpression.Compile(startGte, nameof(startGte), required: false);
            var __workflow_startLte = WorkflowExpression.Compile(startLte, nameof(startLte), required: false);
            var __workflow_endGt = WorkflowExpression.Compile(endGt, nameof(endGt), required: false);
            var __workflow_endLt = WorkflowExpression.Compile(endLt, nameof(endLt), required: false);
            var __workflow_endGte = WorkflowExpression.Compile(endGte, nameof(endGte), required: false);
            var __workflow_endLte = WorkflowExpression.Compile(endLte, nameof(endLte), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ExpeditionListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/expedition/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_crewAstronaut != null)
                    callPayload.Queries["crew__astronaut"] = ExpressionConverter.Convert(__workflow_crewAstronaut);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_spaceStation != null)
                    callPayload.Queries["space_station"] = ExpressionConverter.Convert(__workflow_spaceStation);
                if (__workflow_crewAstronautAgency != null)
                    callPayload.Queries["crew__astronaut__agency"] = ExpressionConverter.Convert(__workflow_crewAstronautAgency);
                if (__workflow_startGt != null)
                    callPayload.Queries["start__gt"] = ExpressionConverter.Convert(__workflow_startGt);
                if (__workflow_startLt != null)
                    callPayload.Queries["start__lt"] = ExpressionConverter.Convert(__workflow_startLt);
                if (__workflow_startGte != null)
                    callPayload.Queries["start__gte"] = ExpressionConverter.Convert(__workflow_startGte);
                if (__workflow_startLte != null)
                    callPayload.Queries["start__lte"] = ExpressionConverter.Convert(__workflow_startLte);
                if (__workflow_endGt != null)
                    callPayload.Queries["end__gt"] = ExpressionConverter.Convert(__workflow_endGt);
                if (__workflow_endLt != null)
                    callPayload.Queries["end__lt"] = ExpressionConverter.Convert(__workflow_endLt);
                if (__workflow_endGte != null)
                    callPayload.Queries["end__gte"] = ExpressionConverter.Convert(__workflow_endGte);
                if (__workflow_endLte != null)
                    callPayload.Queries["end__lte"] = ExpressionConverter.Convert(__workflow_endLte);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ExpeditionListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ExpeditionDetail, ApiConnectionActionConfiguration> ExpeditionRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ExpeditionDetail, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/expedition/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ExpeditionDetail>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<UplistResponse, ApiConnectionActionConfiguration> Uplist(Expression<Func<string>> name = null, Expression<Func<string>> slug = null, Expression<Func<string>> rocketConfigurationName = null, Expression<Func<double>> rocketConfigurationId = null, Expression<Func<string>> status = null, Expression<Func<string>> rocketSpacecraftflightSpacecraftName = null, Expression<Func<string>> rocketSpacecraftflightSpacecraftNameIcontains = null, Expression<Func<double>> rocketSpacecraftflightSpacecraftId = null, Expression<Func<string>> rocketConfigurationManufacturerName = null, Expression<Func<string>> rocketConfigurationManufacturerNameIcontains = null, Expression<Func<string>> rocketConfigurationFullName = null, Expression<Func<string>> rocketConfigurationFullNameIcontains = null, Expression<Func<string>> missionOrbitName = null, Expression<Func<string>> missionOrbitNameIcontains = null, Expression<Func<string>> rSpacexApiId = null, Expression<Func<string>> netGt = null, Expression<Func<string>> netLt = null, Expression<Func<string>> netGte = null, Expression<Func<string>> netLte = null, Expression<Func<string>> windowStartGt = null, Expression<Func<string>> windowStartLt = null, Expression<Func<string>> windowStartGte = null, Expression<Func<string>> windowStartLte = null, Expression<Func<string>> windowEndGt = null, Expression<Func<string>> windowEndLt = null, Expression<Func<string>> windowEndGte = null, Expression<Func<string>> windowEndLte = null, Expression<Func<string>> lastUpdatedGte = null, Expression<Func<string>> lastUpdatedLte = null, Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<int[]>> locationIds = null, Expression<Func<int[]>> lspIds = null, Expression<Func<bool>> isCrewed = null, Expression<Func<bool>> includeSuborbital = null, Expression<Func<string>> serialNumber = null, Expression<Func<string>> lspName = null, Expression<Func<int>> lspId = null, Expression<Func<int>> lspConfigId = null, Expression<Func<int[]>> spacecraftConfigIds = null, Expression<Func<bool>> related = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_slug = WorkflowExpression.Compile(slug, nameof(slug), required: false);
            var __workflow_rocketConfigurationName = WorkflowExpression.Compile(rocketConfigurationName, nameof(rocketConfigurationName), required: false);
            var __workflow_rocketConfigurationId = WorkflowExpression.Compile(rocketConfigurationId, nameof(rocketConfigurationId), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_rocketSpacecraftflightSpacecraftName = WorkflowExpression.Compile(rocketSpacecraftflightSpacecraftName, nameof(rocketSpacecraftflightSpacecraftName), required: false);
            var __workflow_rocketSpacecraftflightSpacecraftNameIcontains = WorkflowExpression.Compile(rocketSpacecraftflightSpacecraftNameIcontains, nameof(rocketSpacecraftflightSpacecraftNameIcontains), required: false);
            var __workflow_rocketSpacecraftflightSpacecraftId = WorkflowExpression.Compile(rocketSpacecraftflightSpacecraftId, nameof(rocketSpacecraftflightSpacecraftId), required: false);
            var __workflow_rocketConfigurationManufacturerName = WorkflowExpression.Compile(rocketConfigurationManufacturerName, nameof(rocketConfigurationManufacturerName), required: false);
            var __workflow_rocketConfigurationManufacturerNameIcontains = WorkflowExpression.Compile(rocketConfigurationManufacturerNameIcontains, nameof(rocketConfigurationManufacturerNameIcontains), required: false);
            var __workflow_rocketConfigurationFullName = WorkflowExpression.Compile(rocketConfigurationFullName, nameof(rocketConfigurationFullName), required: false);
            var __workflow_rocketConfigurationFullNameIcontains = WorkflowExpression.Compile(rocketConfigurationFullNameIcontains, nameof(rocketConfigurationFullNameIcontains), required: false);
            var __workflow_missionOrbitName = WorkflowExpression.Compile(missionOrbitName, nameof(missionOrbitName), required: false);
            var __workflow_missionOrbitNameIcontains = WorkflowExpression.Compile(missionOrbitNameIcontains, nameof(missionOrbitNameIcontains), required: false);
            var __workflow_rSpacexApiId = WorkflowExpression.Compile(rSpacexApiId, nameof(rSpacexApiId), required: false);
            var __workflow_netGt = WorkflowExpression.Compile(netGt, nameof(netGt), required: false);
            var __workflow_netLt = WorkflowExpression.Compile(netLt, nameof(netLt), required: false);
            var __workflow_netGte = WorkflowExpression.Compile(netGte, nameof(netGte), required: false);
            var __workflow_netLte = WorkflowExpression.Compile(netLte, nameof(netLte), required: false);
            var __workflow_windowStartGt = WorkflowExpression.Compile(windowStartGt, nameof(windowStartGt), required: false);
            var __workflow_windowStartLt = WorkflowExpression.Compile(windowStartLt, nameof(windowStartLt), required: false);
            var __workflow_windowStartGte = WorkflowExpression.Compile(windowStartGte, nameof(windowStartGte), required: false);
            var __workflow_windowStartLte = WorkflowExpression.Compile(windowStartLte, nameof(windowStartLte), required: false);
            var __workflow_windowEndGt = WorkflowExpression.Compile(windowEndGt, nameof(windowEndGt), required: false);
            var __workflow_windowEndLt = WorkflowExpression.Compile(windowEndLt, nameof(windowEndLt), required: false);
            var __workflow_windowEndGte = WorkflowExpression.Compile(windowEndGte, nameof(windowEndGte), required: false);
            var __workflow_windowEndLte = WorkflowExpression.Compile(windowEndLte, nameof(windowEndLte), required: false);
            var __workflow_lastUpdatedGte = WorkflowExpression.Compile(lastUpdatedGte, nameof(lastUpdatedGte), required: false);
            var __workflow_lastUpdatedLte = WorkflowExpression.Compile(lastUpdatedLte, nameof(lastUpdatedLte), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_locationIds = WorkflowExpression.Compile(locationIds, nameof(locationIds), required: false);
            var __workflow_lspIds = WorkflowExpression.Compile(lspIds, nameof(lspIds), required: false);
            var __workflow_isCrewed = WorkflowExpression.Compile(isCrewed, nameof(isCrewed), required: false);
            var __workflow_includeSuborbital = WorkflowExpression.Compile(includeSuborbital, nameof(includeSuborbital), required: false);
            var __workflow_serialNumber = WorkflowExpression.Compile(serialNumber, nameof(serialNumber), required: false);
            var __workflow_lspName = WorkflowExpression.Compile(lspName, nameof(lspName), required: false);
            var __workflow_lspId = WorkflowExpression.Compile(lspId, nameof(lspId), required: false);
            var __workflow_lspConfigId = WorkflowExpression.Compile(lspConfigId, nameof(lspConfigId), required: false);
            var __workflow_spacecraftConfigIds = WorkflowExpression.Compile(spacecraftConfigIds, nameof(spacecraftConfigIds), required: false);
            var __workflow_related = WorkflowExpression.Compile(related, nameof(related), required: false);
            return new DeferredBodyAction<UplistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/launch/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_slug != null)
                    callPayload.Queries["slug"] = ExpressionConverter.Convert(__workflow_slug);
                if (__workflow_rocketConfigurationName != null)
                    callPayload.Queries["rocket__configuration__name"] = ExpressionConverter.Convert(__workflow_rocketConfigurationName);
                if (__workflow_rocketConfigurationId != null)
                    callPayload.Queries["rocket__configuration__id"] = ExpressionConverter.Convert(__workflow_rocketConfigurationId);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_rocketSpacecraftflightSpacecraftName != null)
                    callPayload.Queries["rocket__spacecraftflight__spacecraft__name"] = ExpressionConverter.Convert(__workflow_rocketSpacecraftflightSpacecraftName);
                if (__workflow_rocketSpacecraftflightSpacecraftNameIcontains != null)
                    callPayload.Queries["rocket__spacecraftflight__spacecraft__name__icontains"] = ExpressionConverter.Convert(__workflow_rocketSpacecraftflightSpacecraftNameIcontains);
                if (__workflow_rocketSpacecraftflightSpacecraftId != null)
                    callPayload.Queries["rocket__spacecraftflight__spacecraft__id"] = ExpressionConverter.Convert(__workflow_rocketSpacecraftflightSpacecraftId);
                if (__workflow_rocketConfigurationManufacturerName != null)
                    callPayload.Queries["rocket__configuration__manufacturer__name"] = ExpressionConverter.Convert(__workflow_rocketConfigurationManufacturerName);
                if (__workflow_rocketConfigurationManufacturerNameIcontains != null)
                    callPayload.Queries["rocket__configuration__manufacturer__name__icontains"] = ExpressionConverter.Convert(__workflow_rocketConfigurationManufacturerNameIcontains);
                if (__workflow_rocketConfigurationFullName != null)
                    callPayload.Queries["rocket__configuration__full_name"] = ExpressionConverter.Convert(__workflow_rocketConfigurationFullName);
                if (__workflow_rocketConfigurationFullNameIcontains != null)
                    callPayload.Queries["rocket__configuration__full_name__icontains"] = ExpressionConverter.Convert(__workflow_rocketConfigurationFullNameIcontains);
                if (__workflow_missionOrbitName != null)
                    callPayload.Queries["mission__orbit__name"] = ExpressionConverter.Convert(__workflow_missionOrbitName);
                if (__workflow_missionOrbitNameIcontains != null)
                    callPayload.Queries["mission__orbit__name__icontains"] = ExpressionConverter.Convert(__workflow_missionOrbitNameIcontains);
                if (__workflow_rSpacexApiId != null)
                    callPayload.Queries["r_spacex_api_id"] = ExpressionConverter.Convert(__workflow_rSpacexApiId);
                if (__workflow_netGt != null)
                    callPayload.Queries["net__gt"] = ExpressionConverter.Convert(__workflow_netGt);
                if (__workflow_netLt != null)
                    callPayload.Queries["net__lt"] = ExpressionConverter.Convert(__workflow_netLt);
                if (__workflow_netGte != null)
                    callPayload.Queries["net__gte"] = ExpressionConverter.Convert(__workflow_netGte);
                if (__workflow_netLte != null)
                    callPayload.Queries["net__lte"] = ExpressionConverter.Convert(__workflow_netLte);
                if (__workflow_windowStartGt != null)
                    callPayload.Queries["window_start__gt"] = ExpressionConverter.Convert(__workflow_windowStartGt);
                if (__workflow_windowStartLt != null)
                    callPayload.Queries["window_start__lt"] = ExpressionConverter.Convert(__workflow_windowStartLt);
                if (__workflow_windowStartGte != null)
                    callPayload.Queries["window_start__gte"] = ExpressionConverter.Convert(__workflow_windowStartGte);
                if (__workflow_windowStartLte != null)
                    callPayload.Queries["window_start__lte"] = ExpressionConverter.Convert(__workflow_windowStartLte);
                if (__workflow_windowEndGt != null)
                    callPayload.Queries["window_end__gt"] = ExpressionConverter.Convert(__workflow_windowEndGt);
                if (__workflow_windowEndLt != null)
                    callPayload.Queries["window_end__lt"] = ExpressionConverter.Convert(__workflow_windowEndLt);
                if (__workflow_windowEndGte != null)
                    callPayload.Queries["window_end__gte"] = ExpressionConverter.Convert(__workflow_windowEndGte);
                if (__workflow_windowEndLte != null)
                    callPayload.Queries["window_end__lte"] = ExpressionConverter.Convert(__workflow_windowEndLte);
                if (__workflow_lastUpdatedGte != null)
                    callPayload.Queries["last_updated__gte"] = ExpressionConverter.Convert(__workflow_lastUpdatedGte);
                if (__workflow_lastUpdatedLte != null)
                    callPayload.Queries["last_updated__lte"] = ExpressionConverter.Convert(__workflow_lastUpdatedLte);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_locationIds != null)
                    callPayload.Queries["location__ids"] = ExpressionConverter.Convert(__workflow_locationIds);
                if (__workflow_lspIds != null)
                    callPayload.Queries["lsp__ids"] = ExpressionConverter.Convert(__workflow_lspIds);
                callPayload.Queries["is_crewed"] = Convert.ToString(false);
                if (__workflow_isCrewed != null)
                    callPayload.Queries["is_crewed"] = ExpressionConverter.Convert(__workflow_isCrewed);
                callPayload.Queries["include_suborbital"] = Convert.ToString(true);
                if (__workflow_includeSuborbital != null)
                    callPayload.Queries["include_suborbital"] = ExpressionConverter.Convert(__workflow_includeSuborbital);
                if (__workflow_serialNumber != null)
                    callPayload.Queries["serial_number"] = ExpressionConverter.Convert(__workflow_serialNumber);
                if (__workflow_lspName != null)
                    callPayload.Queries["lsp__name"] = ExpressionConverter.Convert(__workflow_lspName);
                if (__workflow_lspId != null)
                    callPayload.Queries["lsp__id"] = ExpressionConverter.Convert(__workflow_lspId);
                if (__workflow_lspConfigId != null)
                    callPayload.Queries["lsp__config_id"] = ExpressionConverter.Convert(__workflow_lspConfigId);
                if (__workflow_spacecraftConfigIds != null)
                    callPayload.Queries["spacecraft_config_ids"] = ExpressionConverter.Convert(__workflow_spacecraftConfigIds);
                callPayload.Queries["related"] = Convert.ToString(false);
                if (__workflow_related != null)
                    callPayload.Queries["related"] = ExpressionConverter.Convert(__workflow_related);
                return new ApiConnectionAction<UplistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LaunchPreviousListResponse, ApiConnectionActionConfiguration> LaunchPreviousList(Expression<Func<string>> name = null, Expression<Func<string>> slug = null, Expression<Func<string>> rocketConfigurationName = null, Expression<Func<double>> rocketConfigurationId = null, Expression<Func<string>> status = null, Expression<Func<string>> rocketSpacecraftflightSpacecraftName = null, Expression<Func<string>> rocketSpacecraftflightSpacecraftIcontains = null, Expression<Func<double>> rocketSpacecraftflightSpacecraftId = null, Expression<Func<string>> rocketConfigurationManufacturerName = null, Expression<Func<string>> rocketConfigurationManufacturerNameIcontains = null, Expression<Func<string>> rocketConfigurationFullName = null, Expression<Func<string>> rocketConfigurationFullNameIcontains = null, Expression<Func<string>> missionOrbitName = null, Expression<Func<string>> missionOrbitNameIcontains = null, Expression<Func<string>> program = null, Expression<Func<string>> rSpacexApiId = null, Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<int[]>> locationIds = null, Expression<Func<int[]>> lspIds = null, Expression<Func<bool>> isCrewed = null, Expression<Func<bool>> includeSuborbital = null, Expression<Func<string>> serialNumber = null, Expression<Func<string>> lspName = null, Expression<Func<int>> lspId = null, Expression<Func<int>> lspConfigId = null, Expression<Func<int[]>> spacecraftConfigIds = null, Expression<Func<bool>> related = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_slug = WorkflowExpression.Compile(slug, nameof(slug), required: false);
            var __workflow_rocketConfigurationName = WorkflowExpression.Compile(rocketConfigurationName, nameof(rocketConfigurationName), required: false);
            var __workflow_rocketConfigurationId = WorkflowExpression.Compile(rocketConfigurationId, nameof(rocketConfigurationId), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_rocketSpacecraftflightSpacecraftName = WorkflowExpression.Compile(rocketSpacecraftflightSpacecraftName, nameof(rocketSpacecraftflightSpacecraftName), required: false);
            var __workflow_rocketSpacecraftflightSpacecraftIcontains = WorkflowExpression.Compile(rocketSpacecraftflightSpacecraftIcontains, nameof(rocketSpacecraftflightSpacecraftIcontains), required: false);
            var __workflow_rocketSpacecraftflightSpacecraftId = WorkflowExpression.Compile(rocketSpacecraftflightSpacecraftId, nameof(rocketSpacecraftflightSpacecraftId), required: false);
            var __workflow_rocketConfigurationManufacturerName = WorkflowExpression.Compile(rocketConfigurationManufacturerName, nameof(rocketConfigurationManufacturerName), required: false);
            var __workflow_rocketConfigurationManufacturerNameIcontains = WorkflowExpression.Compile(rocketConfigurationManufacturerNameIcontains, nameof(rocketConfigurationManufacturerNameIcontains), required: false);
            var __workflow_rocketConfigurationFullName = WorkflowExpression.Compile(rocketConfigurationFullName, nameof(rocketConfigurationFullName), required: false);
            var __workflow_rocketConfigurationFullNameIcontains = WorkflowExpression.Compile(rocketConfigurationFullNameIcontains, nameof(rocketConfigurationFullNameIcontains), required: false);
            var __workflow_missionOrbitName = WorkflowExpression.Compile(missionOrbitName, nameof(missionOrbitName), required: false);
            var __workflow_missionOrbitNameIcontains = WorkflowExpression.Compile(missionOrbitNameIcontains, nameof(missionOrbitNameIcontains), required: false);
            var __workflow_program = WorkflowExpression.Compile(program, nameof(program), required: false);
            var __workflow_rSpacexApiId = WorkflowExpression.Compile(rSpacexApiId, nameof(rSpacexApiId), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_locationIds = WorkflowExpression.Compile(locationIds, nameof(locationIds), required: false);
            var __workflow_lspIds = WorkflowExpression.Compile(lspIds, nameof(lspIds), required: false);
            var __workflow_isCrewed = WorkflowExpression.Compile(isCrewed, nameof(isCrewed), required: false);
            var __workflow_includeSuborbital = WorkflowExpression.Compile(includeSuborbital, nameof(includeSuborbital), required: false);
            var __workflow_serialNumber = WorkflowExpression.Compile(serialNumber, nameof(serialNumber), required: false);
            var __workflow_lspName = WorkflowExpression.Compile(lspName, nameof(lspName), required: false);
            var __workflow_lspId = WorkflowExpression.Compile(lspId, nameof(lspId), required: false);
            var __workflow_lspConfigId = WorkflowExpression.Compile(lspConfigId, nameof(lspConfigId), required: false);
            var __workflow_spacecraftConfigIds = WorkflowExpression.Compile(spacecraftConfigIds, nameof(spacecraftConfigIds), required: false);
            var __workflow_related = WorkflowExpression.Compile(related, nameof(related), required: false);
            return new DeferredBodyAction<LaunchPreviousListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/launch/previous/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_slug != null)
                    callPayload.Queries["slug"] = ExpressionConverter.Convert(__workflow_slug);
                if (__workflow_rocketConfigurationName != null)
                    callPayload.Queries["rocket__configuration__name"] = ExpressionConverter.Convert(__workflow_rocketConfigurationName);
                if (__workflow_rocketConfigurationId != null)
                    callPayload.Queries["rocket__configuration__id"] = ExpressionConverter.Convert(__workflow_rocketConfigurationId);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_rocketSpacecraftflightSpacecraftName != null)
                    callPayload.Queries["rocket__spacecraftflight__spacecraft__name"] = ExpressionConverter.Convert(__workflow_rocketSpacecraftflightSpacecraftName);
                if (__workflow_rocketSpacecraftflightSpacecraftIcontains != null)
                    callPayload.Queries["rocket__spacecraftflight__spacecraft__icontains"] = ExpressionConverter.Convert(__workflow_rocketSpacecraftflightSpacecraftIcontains);
                if (__workflow_rocketSpacecraftflightSpacecraftId != null)
                    callPayload.Queries["rocket__spacecraftflight__spacecraft__id"] = ExpressionConverter.Convert(__workflow_rocketSpacecraftflightSpacecraftId);
                if (__workflow_rocketConfigurationManufacturerName != null)
                    callPayload.Queries["rocket__configuration__manufacturer__name"] = ExpressionConverter.Convert(__workflow_rocketConfigurationManufacturerName);
                if (__workflow_rocketConfigurationManufacturerNameIcontains != null)
                    callPayload.Queries["rocket__configuration__manufacturer__name__icontains"] = ExpressionConverter.Convert(__workflow_rocketConfigurationManufacturerNameIcontains);
                if (__workflow_rocketConfigurationFullName != null)
                    callPayload.Queries["rocket__configuration__full_name"] = ExpressionConverter.Convert(__workflow_rocketConfigurationFullName);
                if (__workflow_rocketConfigurationFullNameIcontains != null)
                    callPayload.Queries["rocket__configuration__full_name__icontains"] = ExpressionConverter.Convert(__workflow_rocketConfigurationFullNameIcontains);
                if (__workflow_missionOrbitName != null)
                    callPayload.Queries["mission__orbit__name"] = ExpressionConverter.Convert(__workflow_missionOrbitName);
                if (__workflow_missionOrbitNameIcontains != null)
                    callPayload.Queries["mission__orbit__name__icontains"] = ExpressionConverter.Convert(__workflow_missionOrbitNameIcontains);
                if (__workflow_program != null)
                    callPayload.Queries["program"] = ExpressionConverter.Convert(__workflow_program);
                if (__workflow_rSpacexApiId != null)
                    callPayload.Queries["r_spacex_api_id"] = ExpressionConverter.Convert(__workflow_rSpacexApiId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_locationIds != null)
                    callPayload.Queries["location__ids"] = ExpressionConverter.Convert(__workflow_locationIds);
                if (__workflow_lspIds != null)
                    callPayload.Queries["lsp__ids"] = ExpressionConverter.Convert(__workflow_lspIds);
                callPayload.Queries["is_crewed"] = Convert.ToString(false);
                if (__workflow_isCrewed != null)
                    callPayload.Queries["is_crewed"] = ExpressionConverter.Convert(__workflow_isCrewed);
                callPayload.Queries["include_suborbital"] = Convert.ToString(true);
                if (__workflow_includeSuborbital != null)
                    callPayload.Queries["include_suborbital"] = ExpressionConverter.Convert(__workflow_includeSuborbital);
                if (__workflow_serialNumber != null)
                    callPayload.Queries["serial_number"] = ExpressionConverter.Convert(__workflow_serialNumber);
                if (__workflow_lspName != null)
                    callPayload.Queries["lsp__name"] = ExpressionConverter.Convert(__workflow_lspName);
                if (__workflow_lspId != null)
                    callPayload.Queries["lsp__id"] = ExpressionConverter.Convert(__workflow_lspId);
                if (__workflow_lspConfigId != null)
                    callPayload.Queries["lsp__config__id"] = ExpressionConverter.Convert(__workflow_lspConfigId);
                if (__workflow_spacecraftConfigIds != null)
                    callPayload.Queries["spacecraft_config_ids"] = ExpressionConverter.Convert(__workflow_spacecraftConfigIds);
                callPayload.Queries["related"] = Convert.ToString(false);
                if (__workflow_related != null)
                    callPayload.Queries["related"] = ExpressionConverter.Convert(__workflow_related);
                return new ApiConnectionAction<LaunchPreviousListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LaunchDetailed, ApiConnectionActionConfiguration> LaunchPreviousRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<LaunchDetailed, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/launch/previous/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LaunchDetailed>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LaunchUpcomingListResponse, ApiConnectionActionConfiguration> LaunchUpcomingList(Expression<Func<string>> name = null, Expression<Func<string>> slug = null, Expression<Func<string>> rocketConfigurationName = null, Expression<Func<double>> rocketConfigurationId = null, Expression<Func<string>> status = null, Expression<Func<string>> rocketSpacecraftflightSpacecraftName = null, Expression<Func<string>> rocketSpacecraftflightSpacecraftNameIcontains = null, Expression<Func<double>> rocketSpacecraftflightSpacecraftId = null, Expression<Func<string>> rocketConfigurationManufacturerName = null, Expression<Func<string>> rocketConfigurationManufacturerNameIcontains = null, Expression<Func<string>> rocketConfigurationFullName = null, Expression<Func<string>> rocketConfigurationFullNameIcontains = null, Expression<Func<string>> missionOrbitName = null, Expression<Func<string>> missionOrbitNameIcontains = null, Expression<Func<string>> program = null, Expression<Func<string>> rSpacexApiId = null, Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<int[]>> locationIds = null, Expression<Func<int[]>> lspIds = null, Expression<Func<bool>> isCrewed = null, Expression<Func<bool>> includeSuborbital = null, Expression<Func<string>> serialNumber = null, Expression<Func<string>> lspName = null, Expression<Func<int>> lspId = null, Expression<Func<int>> lspConfigId = null, Expression<Func<int[]>> spacecraftConfigIds = null, Expression<Func<bool>> related = null, Expression<Func<bool>> hideRecentPrevious = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_slug = WorkflowExpression.Compile(slug, nameof(slug), required: false);
            var __workflow_rocketConfigurationName = WorkflowExpression.Compile(rocketConfigurationName, nameof(rocketConfigurationName), required: false);
            var __workflow_rocketConfigurationId = WorkflowExpression.Compile(rocketConfigurationId, nameof(rocketConfigurationId), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_rocketSpacecraftflightSpacecraftName = WorkflowExpression.Compile(rocketSpacecraftflightSpacecraftName, nameof(rocketSpacecraftflightSpacecraftName), required: false);
            var __workflow_rocketSpacecraftflightSpacecraftNameIcontains = WorkflowExpression.Compile(rocketSpacecraftflightSpacecraftNameIcontains, nameof(rocketSpacecraftflightSpacecraftNameIcontains), required: false);
            var __workflow_rocketSpacecraftflightSpacecraftId = WorkflowExpression.Compile(rocketSpacecraftflightSpacecraftId, nameof(rocketSpacecraftflightSpacecraftId), required: false);
            var __workflow_rocketConfigurationManufacturerName = WorkflowExpression.Compile(rocketConfigurationManufacturerName, nameof(rocketConfigurationManufacturerName), required: false);
            var __workflow_rocketConfigurationManufacturerNameIcontains = WorkflowExpression.Compile(rocketConfigurationManufacturerNameIcontains, nameof(rocketConfigurationManufacturerNameIcontains), required: false);
            var __workflow_rocketConfigurationFullName = WorkflowExpression.Compile(rocketConfigurationFullName, nameof(rocketConfigurationFullName), required: false);
            var __workflow_rocketConfigurationFullNameIcontains = WorkflowExpression.Compile(rocketConfigurationFullNameIcontains, nameof(rocketConfigurationFullNameIcontains), required: false);
            var __workflow_missionOrbitName = WorkflowExpression.Compile(missionOrbitName, nameof(missionOrbitName), required: false);
            var __workflow_missionOrbitNameIcontains = WorkflowExpression.Compile(missionOrbitNameIcontains, nameof(missionOrbitNameIcontains), required: false);
            var __workflow_program = WorkflowExpression.Compile(program, nameof(program), required: false);
            var __workflow_rSpacexApiId = WorkflowExpression.Compile(rSpacexApiId, nameof(rSpacexApiId), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_locationIds = WorkflowExpression.Compile(locationIds, nameof(locationIds), required: false);
            var __workflow_lspIds = WorkflowExpression.Compile(lspIds, nameof(lspIds), required: false);
            var __workflow_isCrewed = WorkflowExpression.Compile(isCrewed, nameof(isCrewed), required: false);
            var __workflow_includeSuborbital = WorkflowExpression.Compile(includeSuborbital, nameof(includeSuborbital), required: false);
            var __workflow_serialNumber = WorkflowExpression.Compile(serialNumber, nameof(serialNumber), required: false);
            var __workflow_lspName = WorkflowExpression.Compile(lspName, nameof(lspName), required: false);
            var __workflow_lspId = WorkflowExpression.Compile(lspId, nameof(lspId), required: false);
            var __workflow_lspConfigId = WorkflowExpression.Compile(lspConfigId, nameof(lspConfigId), required: false);
            var __workflow_spacecraftConfigIds = WorkflowExpression.Compile(spacecraftConfigIds, nameof(spacecraftConfigIds), required: false);
            var __workflow_related = WorkflowExpression.Compile(related, nameof(related), required: false);
            var __workflow_hideRecentPrevious = WorkflowExpression.Compile(hideRecentPrevious, nameof(hideRecentPrevious), required: false);
            return new DeferredBodyAction<LaunchUpcomingListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/launch/upcoming/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_slug != null)
                    callPayload.Queries["slug"] = ExpressionConverter.Convert(__workflow_slug);
                if (__workflow_rocketConfigurationName != null)
                    callPayload.Queries["rocket__configuration__name"] = ExpressionConverter.Convert(__workflow_rocketConfigurationName);
                if (__workflow_rocketConfigurationId != null)
                    callPayload.Queries["rocket__configuration__id"] = ExpressionConverter.Convert(__workflow_rocketConfigurationId);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_rocketSpacecraftflightSpacecraftName != null)
                    callPayload.Queries["rocket__spacecraftflight__spacecraft__name"] = ExpressionConverter.Convert(__workflow_rocketSpacecraftflightSpacecraftName);
                if (__workflow_rocketSpacecraftflightSpacecraftNameIcontains != null)
                    callPayload.Queries["rocket__spacecraftflight__spacecraft__name__icontains"] = ExpressionConverter.Convert(__workflow_rocketSpacecraftflightSpacecraftNameIcontains);
                if (__workflow_rocketSpacecraftflightSpacecraftId != null)
                    callPayload.Queries["rocket__spacecraftflight__spacecraft__id"] = ExpressionConverter.Convert(__workflow_rocketSpacecraftflightSpacecraftId);
                if (__workflow_rocketConfigurationManufacturerName != null)
                    callPayload.Queries["rocket__configuration__manufacturer__name"] = ExpressionConverter.Convert(__workflow_rocketConfigurationManufacturerName);
                if (__workflow_rocketConfigurationManufacturerNameIcontains != null)
                    callPayload.Queries["rocket__configuration__manufacturer__name__icontains"] = ExpressionConverter.Convert(__workflow_rocketConfigurationManufacturerNameIcontains);
                if (__workflow_rocketConfigurationFullName != null)
                    callPayload.Queries["rocket__configuration__full_name"] = ExpressionConverter.Convert(__workflow_rocketConfigurationFullName);
                if (__workflow_rocketConfigurationFullNameIcontains != null)
                    callPayload.Queries["rocket__configuration__full_name__icontains"] = ExpressionConverter.Convert(__workflow_rocketConfigurationFullNameIcontains);
                if (__workflow_missionOrbitName != null)
                    callPayload.Queries["mission__orbit__name"] = ExpressionConverter.Convert(__workflow_missionOrbitName);
                if (__workflow_missionOrbitNameIcontains != null)
                    callPayload.Queries["mission__orbit__name__icontains"] = ExpressionConverter.Convert(__workflow_missionOrbitNameIcontains);
                if (__workflow_program != null)
                    callPayload.Queries["program"] = ExpressionConverter.Convert(__workflow_program);
                if (__workflow_rSpacexApiId != null)
                    callPayload.Queries["r_spacex_api_id"] = ExpressionConverter.Convert(__workflow_rSpacexApiId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_locationIds != null)
                    callPayload.Queries["location__ids"] = ExpressionConverter.Convert(__workflow_locationIds);
                if (__workflow_lspIds != null)
                    callPayload.Queries["lsp__ids"] = ExpressionConverter.Convert(__workflow_lspIds);
                callPayload.Queries["is_crewed"] = Convert.ToString(false);
                if (__workflow_isCrewed != null)
                    callPayload.Queries["is_crewed"] = ExpressionConverter.Convert(__workflow_isCrewed);
                callPayload.Queries["include_suborbital"] = Convert.ToString(true);
                if (__workflow_includeSuborbital != null)
                    callPayload.Queries["include_suborbital"] = ExpressionConverter.Convert(__workflow_includeSuborbital);
                if (__workflow_serialNumber != null)
                    callPayload.Queries["serial_number"] = ExpressionConverter.Convert(__workflow_serialNumber);
                if (__workflow_lspName != null)
                    callPayload.Queries["lsp__name"] = ExpressionConverter.Convert(__workflow_lspName);
                if (__workflow_lspId != null)
                    callPayload.Queries["lsp__id"] = ExpressionConverter.Convert(__workflow_lspId);
                if (__workflow_lspConfigId != null)
                    callPayload.Queries["lsp__config__id"] = ExpressionConverter.Convert(__workflow_lspConfigId);
                if (__workflow_spacecraftConfigIds != null)
                    callPayload.Queries["spacecraft_config_ids"] = ExpressionConverter.Convert(__workflow_spacecraftConfigIds);
                callPayload.Queries["related"] = Convert.ToString(false);
                if (__workflow_related != null)
                    callPayload.Queries["related"] = ExpressionConverter.Convert(__workflow_related);
                callPayload.Queries["hide_recent_previous"] = Convert.ToString(false);
                if (__workflow_hideRecentPrevious != null)
                    callPayload.Queries["hide_recent_previous"] = ExpressionConverter.Convert(__workflow_hideRecentPrevious);
                return new ApiConnectionAction<LaunchUpcomingListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LaunchDetailed, ApiConnectionActionConfiguration> LaunchUpcomingRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<LaunchDetailed, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/launch/upcoming/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LaunchDetailed>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LaunchDetailed, ApiConnectionActionConfiguration> LaunchRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<LaunchDetailed, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/launch/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LaunchDetailed>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LauncherListResponse, ApiConnectionActionConfiguration> LauncherList(Expression<Func<double>> id = null, Expression<Func<string>> serialNumber = null, Expression<Func<string>> flightProven = null, Expression<Func<string>> launcherConfig = null, Expression<Func<string>> launcherConfigManufacturer = null, Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_serialNumber = WorkflowExpression.Compile(serialNumber, nameof(serialNumber), required: false);
            var __workflow_flightProven = WorkflowExpression.Compile(flightProven, nameof(flightProven), required: false);
            var __workflow_launcherConfig = WorkflowExpression.Compile(launcherConfig, nameof(launcherConfig), required: false);
            var __workflow_launcherConfigManufacturer = WorkflowExpression.Compile(launcherConfigManufacturer, nameof(launcherConfigManufacturer), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<LauncherListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/launcher/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_serialNumber != null)
                    callPayload.Queries["serial_number"] = ExpressionConverter.Convert(__workflow_serialNumber);
                if (__workflow_flightProven != null)
                    callPayload.Queries["flight_proven"] = ExpressionConverter.Convert(__workflow_flightProven);
                if (__workflow_launcherConfig != null)
                    callPayload.Queries["launcher_config"] = ExpressionConverter.Convert(__workflow_launcherConfig);
                if (__workflow_launcherConfigManufacturer != null)
                    callPayload.Queries["launcher_config__manufacturer"] = ExpressionConverter.Convert(__workflow_launcherConfigManufacturer);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<LauncherListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LauncherDetail, ApiConnectionActionConfiguration> LauncherRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<LauncherDetail, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/launcher/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LauncherDetail>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LocationListResponse, ApiConnectionActionConfiguration> LocationList(Expression<Func<string>> name = null, Expression<Func<string>> countryCode = null, Expression<Func<double>> id = null, Expression<Func<string>> padLocationId = null, Expression<Func<string>> search = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_countryCode = WorkflowExpression.Compile(countryCode, nameof(countryCode), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_padLocationId = WorkflowExpression.Compile(padLocationId, nameof(padLocationId), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<LocationListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/location/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_countryCode != null)
                    callPayload.Queries["country_code"] = ExpressionConverter.Convert(__workflow_countryCode);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_padLocationId != null)
                    callPayload.Queries["pad__location_id"] = ExpressionConverter.Convert(__workflow_padLocationId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<LocationListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<LocationDetail, ApiConnectionActionConfiguration> LocationRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<LocationDetail, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/location/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LocationDetail>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<PadListResponse, ApiConnectionActionConfiguration> PadList(Expression<Func<string>> name = null, Expression<Func<double>> id = null, Expression<Func<string>> location = null, Expression<Func<string>> search = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_location = WorkflowExpression.Compile(location, nameof(location), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<PadListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pad/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_location != null)
                    callPayload.Queries["location"] = ExpressionConverter.Convert(__workflow_location);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<PadListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<Pad, ApiConnectionActionConfiguration> PadRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Pad, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pad/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Pad>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<ProgramListResponse, ApiConnectionActionConfiguration> ProgramList(Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ProgramListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/program/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ProgramListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<Program, ApiConnectionActionConfiguration> ProgramRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Program, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/program/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Program>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<SpacecraftListResponse, ApiConnectionActionConfiguration> SpacecraftList(Expression<Func<string>> name = null, Expression<Func<string>> status = null, Expression<Func<string>> spacecraftConfig = null, Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_spacecraftConfig = WorkflowExpression.Compile(spacecraftConfig, nameof(spacecraftConfig), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<SpacecraftListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/spacecraft/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_spacecraftConfig != null)
                    callPayload.Queries["spacecraft_config"] = ExpressionConverter.Convert(__workflow_spacecraftConfig);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<SpacecraftListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<SpacecraftFlightListResponse, ApiConnectionActionConfiguration> SpacecraftFlightList(Expression<Func<string>> spacecraft = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_spacecraft = WorkflowExpression.Compile(spacecraft, nameof(spacecraft), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<SpacecraftFlightListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/spacecraft/flight/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_spacecraft != null)
                    callPayload.Queries["spacecraft"] = ExpressionConverter.Convert(__workflow_spacecraft);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<SpacecraftFlightListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<SpacecraftFlightDetailed, ApiConnectionActionConfiguration> SpacecraftFlightRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<SpacecraftFlightDetailed, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/spacecraft/flight/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SpacecraftFlightDetailed>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<SpacecraftDetailed, ApiConnectionActionConfiguration> SpacecraftRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<SpacecraftDetailed, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/spacecraft/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SpacecraftDetailed>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<SpacestationListResponse, ApiConnectionActionConfiguration> SpacestationList(Expression<Func<string>> name = null, Expression<Func<string>> status = null, Expression<Func<string>> owners = null, Expression<Func<string>> orbit = null, Expression<Func<string>> type = null, Expression<Func<string>> ownersName = null, Expression<Func<string>> ownersAbbrev = null, Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_owners = WorkflowExpression.Compile(owners, nameof(owners), required: false);
            var __workflow_orbit = WorkflowExpression.Compile(orbit, nameof(orbit), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_ownersName = WorkflowExpression.Compile(ownersName, nameof(ownersName), required: false);
            var __workflow_ownersAbbrev = WorkflowExpression.Compile(ownersAbbrev, nameof(ownersAbbrev), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<SpacestationListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/spacestation/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_owners != null)
                    callPayload.Queries["owners"] = ExpressionConverter.Convert(__workflow_owners);
                if (__workflow_orbit != null)
                    callPayload.Queries["orbit"] = ExpressionConverter.Convert(__workflow_orbit);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_ownersName != null)
                    callPayload.Queries["owners__name"] = ExpressionConverter.Convert(__workflow_ownersName);
                if (__workflow_ownersAbbrev != null)
                    callPayload.Queries["owners__abbrev"] = ExpressionConverter.Convert(__workflow_ownersAbbrev);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<SpacestationListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<SpaceStationDetailed, ApiConnectionActionConfiguration> SpacestationRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<SpaceStationDetailed, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/spacestation/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SpaceStationDetailed>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<UpdatesListResponse, ApiConnectionActionConfiguration> UpdatesList(Expression<Func<string>> createdOn = null, Expression<Func<string>> launch = null, Expression<Func<string>> program = null, Expression<Func<string>> launchLaunchServiceProvider = null, Expression<Func<string>> search = null, Expression<Func<string>> ordering = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_createdOn = WorkflowExpression.Compile(createdOn, nameof(createdOn), required: false);
            var __workflow_launch = WorkflowExpression.Compile(launch, nameof(launch), required: false);
            var __workflow_program = WorkflowExpression.Compile(program, nameof(program), required: false);
            var __workflow_launchLaunchServiceProvider = WorkflowExpression.Compile(launchLaunchServiceProvider, nameof(launchLaunchServiceProvider), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<UpdatesListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/updates/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_createdOn != null)
                    callPayload.Queries["created_on"] = ExpressionConverter.Convert(__workflow_createdOn);
                if (__workflow_launch != null)
                    callPayload.Queries["launch"] = ExpressionConverter.Convert(__workflow_launch);
                if (__workflow_program != null)
                    callPayload.Queries["program"] = ExpressionConverter.Convert(__workflow_program);
                if (__workflow_launchLaunchServiceProvider != null)
                    callPayload.Queries["launch__launch_service_provider"] = ExpressionConverter.Convert(__workflow_launchLaunchServiceProvider);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<UpdatesListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "launchlibrary2ip")]
        public IBodyWorkflowAction<Update, ApiConnectionActionConfiguration> UpdatesRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Update, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/updates/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Update>(callPayload);
            });
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