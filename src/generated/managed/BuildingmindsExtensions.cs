//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Buildingminds
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BuildingmindsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<PortfolioTypeWithPagination> GetPortfolios(Expression<Func<string>> top = null, Expression<Func<string>> skip = null)
        {
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<PortfolioTypeWithPagination>(() =>
            {
                var apiCallPath = "/premises/portfolios";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                return new ApiConnectionAction<PortfolioTypeWithPagination>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<SiteTypeWithPagination> GetSites(Expression<Func<string>> top = null, Expression<Func<string>> skip = null)
        {
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<SiteTypeWithPagination>(() =>
            {
                var apiCallPath = "/premises/sites";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                return new ApiConnectionAction<SiteTypeWithPagination>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<BuildingTypeWithPagination> GetBuildings(Expression<Func<string>> top = null, Expression<Func<string>> skip = null)
        {
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<BuildingTypeWithPagination>(() =>
            {
                var apiCallPath = "/premises/buildings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                return new ApiConnectionAction<BuildingTypeWithPagination>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<FloorTypeWithPagination> GetFloors(Expression<Func<string>> top = null, Expression<Func<string>> skip = null)
        {
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<FloorTypeWithPagination>(() =>
            {
                var apiCallPath = "/premises/floors";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                return new ApiConnectionAction<FloorTypeWithPagination>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<RoofsTypeWithPagination> GetRoofs(Expression<Func<string>> top = null, Expression<Func<string>> skip = null)
        {
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<RoofsTypeWithPagination>(() =>
            {
                var apiCallPath = "/premises/roofs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                return new ApiConnectionAction<RoofsTypeWithPagination>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<FacadesTypeWithPagination> GetFacades(Expression<Func<string>> top = null, Expression<Func<string>> skip = null)
        {
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<FacadesTypeWithPagination>(() =>
            {
                var apiCallPath = "/premises/facades";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                return new ApiConnectionAction<FacadesTypeWithPagination>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<OutsideareasTypeWithPagination> GetOutsideareas(Expression<Func<string>> top = null, Expression<Func<string>> skip = null)
        {
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<OutsideareasTypeWithPagination>(() =>
            {
                var apiCallPath = "/premises/outsideareas";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                return new ApiConnectionAction<OutsideareasTypeWithPagination>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<SubareasTypeWithPagination> GetSubareas(Expression<Func<string>> top = null, Expression<Func<string>> skip = null)
        {
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<SubareasTypeWithPagination>(() =>
            {
                var apiCallPath = "/premises/subareas";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                return new ApiConnectionAction<SubareasTypeWithPagination>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<LandsTypeWithPagination> GetLands(Expression<Func<string>> top = null, Expression<Func<string>> skip = null)
        {
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<LandsTypeWithPagination>(() =>
            {
                var apiCallPath = "/premises/lands";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                return new ApiConnectionAction<LandsTypeWithPagination>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<SpacesTypeWithPagination> GetSpaces(Expression<Func<string>> top = null, Expression<Func<string>> skip = null)
        {
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            return new DeferredBodyAction<SpacesTypeWithPagination>(() =>
            {
                var apiCallPath = "/premises/spaces";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                return new ApiConnectionAction<SpacesTypeWithPagination>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<Portfolio> GetPortfolioById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Portfolio>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/premises/portfolios/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Portfolio>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<Site> GetSiteById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Site>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/premises/sites/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Site>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<Building> GetBuildingById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Building>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/premises/buildings/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Building>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<Floor> GetFloorById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Floor>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/premises/floors/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Floor>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<Roof> GetRoofById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Roof>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/premises/roofs/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Roof>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<Facade> GetFacadeById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Facade>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/premises/facades/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Facade>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<Outsidearea> GetOutsideareaById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Outsidearea>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/premises/outsideareas/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Outsidearea>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<Subarea> GetSubareaById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Subarea>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/premises/subareas/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Subarea>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<Land> GetLandById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Land>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/premises/lands/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Land>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<Space> GetSpaceById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Space>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/premises/spaces/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Space>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<ChildrenCheckType> CheckForChildrenOnPortfolio(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ChildrenCheckType>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/premises/portfolios/{0}/children/exist", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ChildrenCheckType>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<ChildrenCheckType> CheckForChildrenOnSite(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ChildrenCheckType>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/premises/sites/{0}/children/exist", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ChildrenCheckType>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<ChildrenCheckType> CheckForChildrenOnBuilding(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ChildrenCheckType>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/premises/buildings/{0}/children/exist", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ChildrenCheckType>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<ChildrenCheckType> CheckForChildrenOnFloor(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ChildrenCheckType>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/premises/floors/{0}/children/exist", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ChildrenCheckType>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<ChildrenCheckType> CheckForChildrenOnRoof(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ChildrenCheckType>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/premises/roofs/{0}/children/exist", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ChildrenCheckType>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<ChildrenCheckType> CheckForChildrenOnFacade(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ChildrenCheckType>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/premises/facades/{0}/children/exist", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ChildrenCheckType>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<ChildrenCheckType> CheckForChildrenOnOutsidearea(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ChildrenCheckType>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/premises/outsideareas/{0}/children/exist", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ChildrenCheckType>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<ChildrenCheckType> CheckForChildrenOnSubarea(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ChildrenCheckType>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/premises/subareas/{0}/children/exist", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ChildrenCheckType>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<ChildrenCheckType> CheckForChildrenOnLand(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ChildrenCheckType>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/premises/lands/{0}/children/exist", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ChildrenCheckType>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<ChildrenCheckType> CheckForChildrenOnSpace(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ChildrenCheckType>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/premises/spaces/{0}/children/exist", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ChildrenCheckType>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IBodyWorkflowAction<AssociatedSpacesTypeWithPagination> GetAssociatedSpacesForSpace(Expression<Func<spaceTypeInput>> spaceType, Expression<Func<string>> id, Expression<Func<associatedTypeInput>> associatedType, Expression<Func<string>> skip = null, Expression<Func<string>> top = null)
        {
            var __workflow_spaceType = WorkflowExpression.Compile(spaceType, nameof(spaceType), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_associatedType = WorkflowExpression.Compile(associatedType, nameof(associatedType), required: true);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<AssociatedSpacesTypeWithPagination>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/premises/{0}/{1}/associated/{2}", __workflow_spaceType.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1), __workflow_associatedType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<AssociatedSpacesTypeWithPagination>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "buildingminds")]
        public IWorkflowAction GetUnassociatedSpaces(Expression<Func<spaceTypeInput>> spaceType, Expression<Func<associatedTypeInput>> associatedType, Expression<Func<string>> spaceid = null)
        {
            var __workflow_spaceType = WorkflowExpression.Compile(spaceType, nameof(spaceType), required: true);
            var __workflow_associatedType = WorkflowExpression.Compile(associatedType, nameof(associatedType), required: true);
            var __workflow_spaceid = WorkflowExpression.Compile(spaceid, nameof(spaceid), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/premises/{0}/notassociated/{1}", __workflow_spaceType.WithUrlEncoding(1), __workflow_associatedType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_spaceid != null)
                    callPayload.Queries["spaceid"] = ExpressionConverter.Convert(__workflow_spaceid);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class BuildingmindsTriggers([ConnectionName] string connectionId)
    {
    }

    public class PortfolioTypeWithPagination
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("items")]
        public Portfolio[] Items { get; set; }
    }

    public class Portfolio
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public EntityType Type { get; set; }

        [JsonProperty("changedOn")]
        public string ChangedOn { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }

        [JsonProperty("locationPath")]
        public LocationPathType[] LocationPath { get; set; }

        [JsonProperty("tid")]
        public string Tid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public string ValidTo { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("buildingGrossArea")]
        public AreaValueType BuildingGrossArea { get; set; }

        [JsonProperty("landGrossArea")]
        public AreaValueType LandGrossArea { get; set; }

        [JsonProperty("associatedLandIds")]
        public string[] AssociatedLandIds { get; set; }

        [JsonProperty("associatedBuildingIds")]
        public string[] AssociatedBuildingIds { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntityType
    {
        [EnumMember(Value = "portfolio")]
        Portfolio,
        [EnumMember(Value = "land")]
        Land,
        [EnumMember(Value = "site")]
        Site,
        [EnumMember(Value = "outsidearea")]
        Outsidearea,
        [EnumMember(Value = "subarea")]
        Subarea,
        [EnumMember(Value = "building")]
        Building,
        [EnumMember(Value = "floor")]
        Floor,
        [EnumMember(Value = "roof")]
        Roof,
        [EnumMember(Value = "facade")]
        Facade,
        [EnumMember(Value = "space")]
        Space,
        [EnumMember(Value = "address")]
        Address
    }

    public class LocationPathType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AreaValueType
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("unit")]
        public AreaValueTypeUnitType Unit { get; set; }

        [JsonProperty("metricValue")]
        public double MetricValue { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AreaValueTypeUnitType
    {
        [EnumMember(Value = "m2")]
        M2,
        [EnumMember(Value = "ft2")]
        Ft2
    }

    public class SiteTypeWithPagination
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("items")]
        public Site[] Items { get; set; }
    }

    public class Site
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public EntityType Type { get; set; }

        [JsonProperty("changedOn")]
        public string ChangedOn { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }

        [JsonProperty("locationPath")]
        public LocationPathType[] LocationPath { get; set; }

        [JsonProperty("tid")]
        public string Tid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public string ValidTo { get; set; }

        [JsonProperty("buildingGrossArea")]
        public AreaValueType BuildingGrossArea { get; set; }

        [JsonProperty("outsideareaGrossArea")]
        public AreaValueType OutsideareaGrossArea { get; set; }

        [JsonProperty("mainAddressExternalId")]
        public string MainAddressExternalId { get; set; }

        [JsonProperty("addresses")]
        public AddressType[] Addresses { get; set; }

        [JsonProperty("typeOfSite")]
        public SpaceTypeOfUseEnum TypeOfSite { get; set; }

        [JsonProperty("imageIds")]
        public string[] ImageIds { get; set; }

        [JsonProperty("internalId")]
        public string InternalId { get; set; }

        [JsonProperty("furtherInformation")]
        public string FurtherInformation { get; set; }
    }

    public class AddressType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public EntityType Type { get; set; }

        [JsonProperty("changedOn")]
        public string ChangedOn { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("houseNumber")]
        public string HouseNumber { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("postBox")]
        public string PostBox { get; set; }

        [JsonProperty("postBoxPostCode")]
        public string PostBoxPostCode { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SpaceTypeOfUseEnum
    {
        [EnumMember(Value = "office")]
        Office,
        [EnumMember(Value = "apartment")]
        Apartment,
        [EnumMember(Value = "meeting")]
        Meeting,
        [EnumMember(Value = "technical")]
        Technical,
        [EnumMember(Value = "parking")]
        Parking,
        [EnumMember(Value = "production")]
        Production,
        [EnumMember(Value = "logistics")]
        Logistics,
        [EnumMember(Value = "traffic")]
        Traffic,
        [EnumMember(Value = "passageway")]
        Passageway,
        [EnumMember(Value = "storage")]
        Storage,
        [EnumMember(Value = "bathroom")]
        Bathroom,
        [EnumMember(Value = "canteen")]
        Canteen,
        [EnumMember(Value = "kitchen")]
        Kitchen,
        [EnumMember(Value = "sales")]
        Sales,
        [EnumMember(Value = "technicalShaft")]
        TechnicalShaft,
        [EnumMember(Value = "otherShaft")]
        OtherShaft
    }

    public class BuildingTypeWithPagination
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("items")]
        public Building[] Items { get; set; }
    }

    public class Building
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public EntityType Type { get; set; }

        [JsonProperty("changedOn")]
        public string ChangedOn { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }

        [JsonProperty("locationPath")]
        public LocationPathType[] LocationPath { get; set; }

        [JsonProperty("tid")]
        public string Tid { get; set; }

        [JsonProperty("associatedPortfolioId")]
        public string AssociatedPortfolioId { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("associatedLandIds")]
        public string[] AssociatedLandIds { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("internalId")]
        public string InternalId { get; set; }

        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public string ValidTo { get; set; }

        [JsonProperty("addresses")]
        public AddressType[] Addresses { get; set; }

        [JsonProperty("responsiblePeopleFullName")]
        public string ResponsiblePeopleFullName { get; set; }

        [JsonProperty("typeOfOwnership")]
        public SpaceTypeOfOwnership TypeOfOwnership { get; set; }

        [JsonProperty("typeOfBuilding")]
        public string TypeOfBuilding { get; set; }

        [JsonProperty("imageIds")]
        public string[] ImageIds { get; set; }

        [JsonProperty("furtherInformation")]
        public string FurtherInformation { get; set; }

        [JsonProperty("constructionYear")]
        public string ConstructionYear { get; set; }

        [JsonProperty("yearOfLastRefurbishment")]
        public string YearOfLastRefurbishment { get; set; }

        [JsonProperty("grossArea")]
        public AreaValueType GrossArea { get; set; }

        [JsonProperty("buildingPurchaseCost")]
        public CurrencyValueType BuildingPurchaseCost { get; set; }

        [JsonProperty("hasMonumentProtection")]
        public bool HasMonumentProtection { get; set; }

        [JsonProperty("numberOfFloors")]
        public int NumberOfFloors { get; set; }

        [JsonProperty("numberOf BasementFloors")]
        public int NumberOfBasementFloors { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SpaceTypeOfOwnership
    {
        Leased,
        Freehold,
        [EnumMember(Value = "Part-Ownership")]
        PartOwnership,
        Owned
    }

    public class CurrencyValueType
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class FloorTypeWithPagination
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("items")]
        public Floor[] Items { get; set; }
    }

    public class Floor
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public EntityType Type { get; set; }

        [JsonProperty("changedOn")]
        public string ChangedOn { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }

        [JsonProperty("locationPath")]
        public LocationPathType[] LocationPath { get; set; }

        [JsonProperty("tid")]
        public string Tid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("internalId")]
        public string InternalId { get; set; }

        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public string ValidTo { get; set; }

        [JsonProperty("furtherInformation")]
        public string FurtherInformation { get; set; }

        [JsonProperty("grossArea")]
        public AreaValueType GrossArea { get; set; }

        [JsonProperty("typeOfFloor")]
        public FloorTypeOfFloorType TypeOfFloor { get; set; }

        [JsonProperty("imageIds")]
        public string[] ImageIds { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FloorTypeOfFloorType
    {
        [EnumMember(Value = "basement")]
        Basement,
        [EnumMember(Value = "above")]
        Above,
        [EnumMember(Value = "ground")]
        Ground
    }

    public class RoofsTypeWithPagination
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("items")]
        public Roof[] Items { get; set; }
    }

    public class Roof
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public EntityType Type { get; set; }

        [JsonProperty("changedOn")]
        public string ChangedOn { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }

        [JsonProperty("locationPath")]
        public LocationPathType[] LocationPath { get; set; }

        [JsonProperty("tid")]
        public string Tid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("internalId")]
        public string InternalId { get; set; }

        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public string ValidTo { get; set; }

        [JsonProperty("furtherInformation")]
        public string FurtherInformation { get; set; }

        [JsonProperty("material")]
        public string Material { get; set; }

        [JsonProperty("grossArea")]
        public AreaValueType GrossArea { get; set; }

        [JsonProperty("imageIds")]
        public string[] ImageIds { get; set; }
    }

    public class FacadesTypeWithPagination
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("items")]
        public Facade[] Items { get; set; }
    }

    public class Facade
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public EntityType Type { get; set; }

        [JsonProperty("changedOn")]
        public string ChangedOn { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }

        [JsonProperty("locationPath")]
        public LocationPathType[] LocationPath { get; set; }

        [JsonProperty("tid")]
        public string Tid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("internalId")]
        public string InternalId { get; set; }

        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public string ValidTo { get; set; }

        [JsonProperty("furtherInformation")]
        public string FurtherInformation { get; set; }

        [JsonProperty("material")]
        public string Material { get; set; }

        [JsonProperty("grossArea")]
        public AreaValueType GrossArea { get; set; }

        [JsonProperty("imageIds")]
        public string[] ImageIds { get; set; }
    }

    public class OutsideareasTypeWithPagination
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("items")]
        public Outsidearea[] Items { get; set; }
    }

    public class Outsidearea
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public EntityType Type { get; set; }

        [JsonProperty("changedOn")]
        public string ChangedOn { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }

        [JsonProperty("locationPath")]
        public LocationPathType[] LocationPath { get; set; }

        [JsonProperty("tid")]
        public string Tid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("internalId")]
        public string InternalId { get; set; }

        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public string ValidTo { get; set; }

        [JsonProperty("furtherInformation")]
        public string FurtherInformation { get; set; }

        [JsonProperty("typeOfOutsideArea")]
        public OutsideAreaType TypeOfOutsideArea { get; set; }

        [JsonProperty("grossArea")]
        public AreaValueType GrossArea { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OutsideAreaType
    {
        [EnumMember(Value = "pavedArea")]
        PavedArea,
        [EnumMember(Value = "greenArea")]
        GreenArea
    }

    public class SubareasTypeWithPagination
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("items")]
        public Subarea[] Items { get; set; }
    }

    public class Subarea
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public EntityType Type { get; set; }

        [JsonProperty("changedOn")]
        public string ChangedOn { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }

        [JsonProperty("locationPath")]
        public LocationPathType[] LocationPath { get; set; }

        [JsonProperty("tid")]
        public string Tid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("internalId")]
        public string InternalId { get; set; }

        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public string ValidTo { get; set; }

        [JsonProperty("furtherInformation")]
        public string FurtherInformation { get; set; }
    }

    public class LandsTypeWithPagination
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("items")]
        public Land[] Items { get; set; }
    }

    public class Land
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public EntityType Type { get; set; }

        [JsonProperty("changedOn")]
        public string ChangedOn { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }

        [JsonProperty("locationPath")]
        public LocationPathType[] LocationPath { get; set; }

        [JsonProperty("tid")]
        public string Tid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("internalId")]
        public string InternalId { get; set; }

        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public string ValidTo { get; set; }

        [JsonProperty("furtherInformation")]
        public string FurtherInformation { get; set; }

        [JsonProperty("grossArea")]
        public AreaValueType GrossArea { get; set; }

        [JsonProperty("registrationNumberOfDeed")]
        public string[] RegistrationNumberOfDeed { get; set; }

        [JsonProperty("plotNumber")]
        public string[] PlotNumber { get; set; }

        [JsonProperty("subPlotNumber")]
        public string[] SubPlotNumber { get; set; }

        [JsonProperty("easementBelongingToDeed")]
        public string[] EasementBelongingToDeed { get; set; }

        [JsonProperty("admissableSiteOccupancyIndex")]
        public double AdmissableSiteOccupancyIndex { get; set; }

        [JsonProperty("admissableCubicIndex")]
        public double AdmissableCubicIndex { get; set; }

        [JsonProperty("actualFloorSpaceIndex")]
        public double ActualFloorSpaceIndex { get; set; }

        [JsonProperty("actualSiteOccupancyIndex")]
        public double ActualSiteOccupancyIndex { get; set; }

        [JsonProperty("actualCubicIndex")]
        public double ActualCubicIndex { get; set; }

        [JsonProperty("associatedPortfolioId")]
        public string AssociatedPortfolioId { get; set; }

        [JsonProperty("associatedBuildingIds")]
        public string[] AssociatedBuildingIds { get; set; }
    }

    public class SpacesTypeWithPagination
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("items")]
        public Space[] Items { get; set; }
    }

    public class Space
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public EntityType Type { get; set; }

        [JsonProperty("changedOn")]
        public string ChangedOn { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }

        [JsonProperty("locationPath")]
        public LocationPathType[] LocationPath { get; set; }

        [JsonProperty("tid")]
        public string Tid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("internalId")]
        public string InternalId { get; set; }

        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public string ValidTo { get; set; }

        [JsonProperty("furtherInformation")]
        public string FurtherInformation { get; set; }

        [JsonProperty("imageIds")]
        public string[] ImageIds { get; set; }

        [JsonProperty("grossArea")]
        public AreaValueType GrossArea { get; set; }

        [JsonProperty("typeOfSpace")]
        public SpaceTypeOfSpaceType TypeOfSpace { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SpaceTypeOfSpaceType
    {
        [EnumMember(Value = "residential")]
        Residential,
        [EnumMember(Value = "office")]
        Office,
        [EnumMember(Value = "industrial")]
        Industrial,
        [EnumMember(Value = "retail")]
        Retail,
        [EnumMember(Value = "storage")]
        Storage,
        [EnumMember(Value = "parking space")]
        ParkingSpace,
        [EnumMember(Value = "shaft")]
        Shaft,
        [EnumMember(Value = "staircase")]
        Staircase,
        [EnumMember(Value = "other")]
        Other
    }

    public class ChildrenCheckType
    {
        [JsonProperty("hasChildren")]
        public bool HasChildren { get; set; }
    }

    public class AssociatedSpacesTypeWithPagination
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("items")]
        public Space[] Items { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum spaceTypeInput
    {
        [EnumMember(Value = "portfolios")]
        Portfolios,
        [EnumMember(Value = "sites")]
        Sites,
        [EnumMember(Value = "buildings")]
        Buildings,
        [EnumMember(Value = "floors")]
        Floors,
        [EnumMember(Value = "roofs")]
        Roofs,
        [EnumMember(Value = "facades")]
        Facades,
        [EnumMember(Value = "outsideareas")]
        Outsideareas,
        [EnumMember(Value = "subareas")]
        Subareas,
        [EnumMember(Value = "lands")]
        Lands,
        [EnumMember(Value = "spaces")]
        Spaces
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum associatedTypeInput
    {
        [EnumMember(Value = "portfolios")]
        Portfolios,
        [EnumMember(Value = "sites")]
        Sites,
        [EnumMember(Value = "buildings")]
        Buildings,
        [EnumMember(Value = "floors")]
        Floors,
        [EnumMember(Value = "roofs")]
        Roofs,
        [EnumMember(Value = "facades")]
        Facades,
        [EnumMember(Value = "outsideareas")]
        Outsideareas,
        [EnumMember(Value = "subareas")]
        Subareas,
        [EnumMember(Value = "lands")]
        Lands,
        [EnumMember(Value = "spaces")]
        Spaces
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Buildingminds;

    public partial class WorkflowManagedActions
    {
        public BuildingmindsActions Buildingminds(string connectionId) => new BuildingmindsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BuildingmindsTriggers Buildingminds(string connectionId) => new BuildingmindsTriggers(connectionId);
    }
}
