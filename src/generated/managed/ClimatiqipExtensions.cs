//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Climatiqip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ClimatiqipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<EmissionEstimateResponse, ApiConnectionActionConfiguration> EmissionEstimate(Expression<Func<EmissionEstimateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<EmissionEstimateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/estimate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<EmissionEstimateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<EmissionEstimateBulkResponse, ApiConnectionActionConfiguration> EmissionEstimateBulk(Expression<Func<bodyInputItem[]>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<EmissionEstimateBulkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/batch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<EmissionEstimateBulkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<TravelFlightResponse, ApiConnectionActionConfiguration> TravelFlight(Expression<Func<TravelFlightInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TravelFlightResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/travel/flights";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TravelFlightResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<FreightFlightResponse, ApiConnectionActionConfiguration> FreightFlight(Expression<Func<FreightFlightInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FreightFlightResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/freight/flights";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FreightFlightResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<ComputeMetadataResponse, ApiConnectionActionConfiguration> ComputeMetadata()
        {
            return new DeferredBodyAction<ComputeMetadataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/compute";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ComputeMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<ComputeCPUResponse, ApiConnectionActionConfiguration> ComputeCPU(Expression<Func<string>> provider, Expression<Func<ComputeCPUInput>> body)
        {
            var __workflow_provider = WorkflowExpression.Compile(provider, nameof(provider), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ComputeCPUResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/compute/{0}/cpu", __workflow_provider.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ComputeCPUResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<ComputeStorageResponse, ApiConnectionActionConfiguration> ComputeStorage(Expression<Func<string>> provider, Expression<Func<ComputeStorageInput>> body)
        {
            var __workflow_provider = WorkflowExpression.Compile(provider, nameof(provider), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ComputeStorageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/compute/{0}/storage", __workflow_provider.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ComputeStorageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<ComputeMemoryResponse, ApiConnectionActionConfiguration> ComputeMemory(Expression<Func<string>> provider, Expression<Func<ComputeMemoryInput>> body)
        {
            var __workflow_provider = WorkflowExpression.Compile(provider, nameof(provider), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ComputeMemoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/compute/{0}/memory", __workflow_provider.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ComputeMemoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<ClassificationResponse, ApiConnectionActionConfiguration> Classification(Expression<Func<ClassificationInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ClassificationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/classifications/estimate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ClassificationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<CustomResponse, ApiConnectionActionConfiguration> Custom(Expression<Func<CustomInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CustomResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/custom-activities/estimate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CustomResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<CustomBatchResponse, ApiConnectionActionConfiguration> CustomBatch(Expression<Func<bodyInputItem2[]>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CustomBatchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/custom-activities/batch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CustomBatchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<FactorsSearchResponse, ApiConnectionActionConfiguration> FactorsSearch(Expression<Func<string>> query = null, Expression<Func<string>> uuid = null, Expression<Func<string>> activityId = null, Expression<Func<string>> id = null, Expression<Func<string>> sector = null, Expression<Func<string>> category = null, Expression<Func<string>> source = null, Expression<Func<string>> region = null, Expression<Func<string>> year = null, Expression<Func<string>> lcaActivity = null, Expression<Func<string>> calculationMethod = null, Expression<Func<string>> unitType = null, Expression<Func<int>> page = null, Expression<Func<int>> resultsPerPage = null)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            var __workflow_uuid = WorkflowExpression.Compile(uuid, nameof(uuid), required: false);
            var __workflow_activityId = WorkflowExpression.Compile(activityId, nameof(activityId), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_sector = WorkflowExpression.Compile(sector, nameof(sector), required: false);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: false);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: false);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: false);
            var __workflow_lcaActivity = WorkflowExpression.Compile(lcaActivity, nameof(lcaActivity), required: false);
            var __workflow_calculationMethod = WorkflowExpression.Compile(calculationMethod, nameof(calculationMethod), required: false);
            var __workflow_unitType = WorkflowExpression.Compile(unitType, nameof(unitType), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_resultsPerPage = WorkflowExpression.Compile(resultsPerPage, nameof(resultsPerPage), required: false);
            return new DeferredBodyAction<FactorsSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                if (__workflow_uuid != null)
                    callPayload.Queries["uuid"] = ExpressionConverter.Convert(__workflow_uuid);
                if (__workflow_activityId != null)
                    callPayload.Queries["activity_id"] = ExpressionConverter.Convert(__workflow_activityId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_sector != null)
                    callPayload.Queries["sector"] = ExpressionConverter.Convert(__workflow_sector);
                if (__workflow_category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                if (__workflow_source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                if (__workflow_region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(__workflow_region);
                if (__workflow_year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(__workflow_year);
                if (__workflow_lcaActivity != null)
                    callPayload.Queries["lca_activity"] = ExpressionConverter.Convert(__workflow_lcaActivity);
                if (__workflow_calculationMethod != null)
                    callPayload.Queries["calculation_method"] = ExpressionConverter.Convert(__workflow_calculationMethod);
                if (__workflow_unitType != null)
                    callPayload.Queries["unit_type"] = ExpressionConverter.Convert(__workflow_unitType);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_resultsPerPage != null)
                    callPayload.Queries["results_per_page"] = ExpressionConverter.Convert(__workflow_resultsPerPage);
                return new ApiConnectionAction<FactorsSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<SourcesResponse, ApiConnectionActionConfiguration> Sources(Expression<Func<string>> sector = null, Expression<Func<string>> category = null, Expression<Func<string>> source = null, Expression<Func<string>> region = null, Expression<Func<string>> year = null, Expression<Func<string>> id = null, Expression<Func<string>> lcaActivity = null, Expression<Func<string>> calculationMethod = null)
        {
            var __workflow_sector = WorkflowExpression.Compile(sector, nameof(sector), required: false);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: false);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: false);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_lcaActivity = WorkflowExpression.Compile(lcaActivity, nameof(lcaActivity), required: false);
            var __workflow_calculationMethod = WorkflowExpression.Compile(calculationMethod, nameof(calculationMethod), required: false);
            return new DeferredBodyAction<SourcesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/emission-factors/sources";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sector != null)
                    callPayload.Queries["sector"] = ExpressionConverter.Convert(__workflow_sector);
                if (__workflow_category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                if (__workflow_source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                if (__workflow_region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(__workflow_region);
                if (__workflow_year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(__workflow_year);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_lcaActivity != null)
                    callPayload.Queries["lca_activity"] = ExpressionConverter.Convert(__workflow_lcaActivity);
                if (__workflow_calculationMethod != null)
                    callPayload.Queries["calculation_method"] = ExpressionConverter.Convert(__workflow_calculationMethod);
                return new ApiConnectionAction<SourcesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<YearsResponse, ApiConnectionActionConfiguration> Years(Expression<Func<string>> sector = null, Expression<Func<string>> category = null, Expression<Func<string>> source = null, Expression<Func<string>> region = null, Expression<Func<string>> year = null, Expression<Func<string>> id = null, Expression<Func<string>> lcaActivity = null, Expression<Func<string>> calculationMethod = null)
        {
            var __workflow_sector = WorkflowExpression.Compile(sector, nameof(sector), required: false);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: false);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: false);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_lcaActivity = WorkflowExpression.Compile(lcaActivity, nameof(lcaActivity), required: false);
            var __workflow_calculationMethod = WorkflowExpression.Compile(calculationMethod, nameof(calculationMethod), required: false);
            return new DeferredBodyAction<YearsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/emission-factors/years";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sector != null)
                    callPayload.Queries["sector"] = ExpressionConverter.Convert(__workflow_sector);
                if (__workflow_category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                if (__workflow_source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                if (__workflow_region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(__workflow_region);
                if (__workflow_year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(__workflow_year);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_lcaActivity != null)
                    callPayload.Queries["lca_activity"] = ExpressionConverter.Convert(__workflow_lcaActivity);
                if (__workflow_calculationMethod != null)
                    callPayload.Queries["calculation_method"] = ExpressionConverter.Convert(__workflow_calculationMethod);
                return new ApiConnectionAction<YearsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<RegionsResponse, ApiConnectionActionConfiguration> Regions(Expression<Func<string>> sector = null, Expression<Func<string>> category = null, Expression<Func<string>> source = null, Expression<Func<string>> region = null, Expression<Func<string>> year = null, Expression<Func<string>> id = null, Expression<Func<string>> lcaActivity = null, Expression<Func<string>> calculationMethod = null)
        {
            var __workflow_sector = WorkflowExpression.Compile(sector, nameof(sector), required: false);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: false);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: false);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_lcaActivity = WorkflowExpression.Compile(lcaActivity, nameof(lcaActivity), required: false);
            var __workflow_calculationMethod = WorkflowExpression.Compile(calculationMethod, nameof(calculationMethod), required: false);
            return new DeferredBodyAction<RegionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/emission-factors/regions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sector != null)
                    callPayload.Queries["sector"] = ExpressionConverter.Convert(__workflow_sector);
                if (__workflow_category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                if (__workflow_source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                if (__workflow_region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(__workflow_region);
                if (__workflow_year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(__workflow_year);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_lcaActivity != null)
                    callPayload.Queries["lca_activity"] = ExpressionConverter.Convert(__workflow_lcaActivity);
                if (__workflow_calculationMethod != null)
                    callPayload.Queries["calculation_method"] = ExpressionConverter.Convert(__workflow_calculationMethod);
                return new ApiConnectionAction<RegionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<CategoriesResponse, ApiConnectionActionConfiguration> Categories(Expression<Func<string>> sector = null, Expression<Func<string>> category = null, Expression<Func<string>> source = null, Expression<Func<string>> region = null, Expression<Func<string>> year = null, Expression<Func<string>> id = null, Expression<Func<string>> lcaActivity = null, Expression<Func<string>> calculationMethod = null)
        {
            var __workflow_sector = WorkflowExpression.Compile(sector, nameof(sector), required: false);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: false);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: false);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_lcaActivity = WorkflowExpression.Compile(lcaActivity, nameof(lcaActivity), required: false);
            var __workflow_calculationMethod = WorkflowExpression.Compile(calculationMethod, nameof(calculationMethod), required: false);
            return new DeferredBodyAction<CategoriesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/emission-factors/categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sector != null)
                    callPayload.Queries["sector"] = ExpressionConverter.Convert(__workflow_sector);
                if (__workflow_category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                if (__workflow_source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                if (__workflow_region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(__workflow_region);
                if (__workflow_year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(__workflow_year);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_lcaActivity != null)
                    callPayload.Queries["lca_activity"] = ExpressionConverter.Convert(__workflow_lcaActivity);
                if (__workflow_calculationMethod != null)
                    callPayload.Queries["calculation_method"] = ExpressionConverter.Convert(__workflow_calculationMethod);
                return new ApiConnectionAction<CategoriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<SectorsResponse, ApiConnectionActionConfiguration> Sectors(Expression<Func<string>> sector = null, Expression<Func<string>> category = null, Expression<Func<string>> source = null, Expression<Func<string>> region = null, Expression<Func<string>> year = null, Expression<Func<string>> id = null, Expression<Func<string>> lcaActivity = null, Expression<Func<string>> calculationMethod = null)
        {
            var __workflow_sector = WorkflowExpression.Compile(sector, nameof(sector), required: false);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: false);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: false);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_lcaActivity = WorkflowExpression.Compile(lcaActivity, nameof(lcaActivity), required: false);
            var __workflow_calculationMethod = WorkflowExpression.Compile(calculationMethod, nameof(calculationMethod), required: false);
            return new DeferredBodyAction<SectorsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/emission-factors/sectors";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sector != null)
                    callPayload.Queries["sector"] = ExpressionConverter.Convert(__workflow_sector);
                if (__workflow_category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                if (__workflow_source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                if (__workflow_region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(__workflow_region);
                if (__workflow_year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(__workflow_year);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_lcaActivity != null)
                    callPayload.Queries["lca_activity"] = ExpressionConverter.Convert(__workflow_lcaActivity);
                if (__workflow_calculationMethod != null)
                    callPayload.Queries["calculation_method"] = ExpressionConverter.Convert(__workflow_calculationMethod);
                return new ApiConnectionAction<SectorsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<LifeCycleActivitiesResponse, ApiConnectionActionConfiguration> LifeCycleActivities(Expression<Func<string>> sector = null, Expression<Func<string>> category = null, Expression<Func<string>> source = null, Expression<Func<string>> region = null, Expression<Func<string>> year = null, Expression<Func<string>> id = null, Expression<Func<string>> lcaActivity = null, Expression<Func<string>> calculationMethod = null)
        {
            var __workflow_sector = WorkflowExpression.Compile(sector, nameof(sector), required: false);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: false);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: false);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_lcaActivity = WorkflowExpression.Compile(lcaActivity, nameof(lcaActivity), required: false);
            var __workflow_calculationMethod = WorkflowExpression.Compile(calculationMethod, nameof(calculationMethod), required: false);
            return new DeferredBodyAction<LifeCycleActivitiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/emission-factors/lca-activities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sector != null)
                    callPayload.Queries["sector"] = ExpressionConverter.Convert(__workflow_sector);
                if (__workflow_category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                if (__workflow_source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                if (__workflow_region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(__workflow_region);
                if (__workflow_year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(__workflow_year);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_lcaActivity != null)
                    callPayload.Queries["lca_activity"] = ExpressionConverter.Convert(__workflow_lcaActivity);
                if (__workflow_calculationMethod != null)
                    callPayload.Queries["calculation_method"] = ExpressionConverter.Convert(__workflow_calculationMethod);
                return new ApiConnectionAction<LifeCycleActivitiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "climatiqip")]
        public IBodyWorkflowAction<UnitTypesResponse, ApiConnectionActionConfiguration> UnitTypes(Expression<Func<string>> sector = null, Expression<Func<string>> category = null, Expression<Func<string>> source = null, Expression<Func<string>> region = null, Expression<Func<string>> year = null, Expression<Func<string>> id = null, Expression<Func<string>> lcaActivity = null, Expression<Func<string>> calculationMethod = null)
        {
            var __workflow_sector = WorkflowExpression.Compile(sector, nameof(sector), required: false);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: false);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: false);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_lcaActivity = WorkflowExpression.Compile(lcaActivity, nameof(lcaActivity), required: false);
            var __workflow_calculationMethod = WorkflowExpression.Compile(calculationMethod, nameof(calculationMethod), required: false);
            return new DeferredBodyAction<UnitTypesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/emission-factors/unit-types";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sector != null)
                    callPayload.Queries["sector"] = ExpressionConverter.Convert(__workflow_sector);
                if (__workflow_category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                if (__workflow_source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                if (__workflow_region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(__workflow_region);
                if (__workflow_year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(__workflow_year);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_lcaActivity != null)
                    callPayload.Queries["lca_activity"] = ExpressionConverter.Convert(__workflow_lcaActivity);
                if (__workflow_calculationMethod != null)
                    callPayload.Queries["calculation_method"] = ExpressionConverter.Convert(__workflow_calculationMethod);
                return new ApiConnectionAction<UnitTypesResponse>(callPayload);
            });
        }
    }

    public class ClimatiqipTriggers([ConnectionName] string connectionId)
    {
    }

    public class EmissionEstimateResponse
    {
        [JsonProperty("co2e")]
        public double Co2e { get; set; }

        [JsonProperty("co2e_unit")]
        public string Co2eUnit { get; set; }

        [JsonProperty("co2e_calculation_method")]
        public string Co2eCalculationMethod { get; set; }

        [JsonProperty("co2e_calculation_origin")]
        public string Co2eCalculationOrigin { get; set; }

        [JsonProperty("emission_factor")]
        public EmissionEstimateResponseEmissionFactorType EmissionFactor { get; set; }

        [JsonProperty("constituent_gases")]
        public EmissionEstimateResponseConstituentGasesType ConstituentGases { get; set; }
    }

    public class EmissionEstimateResponseEmissionFactorType
    {
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("access_type")]
        public string AccessType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("data_quality_flags")]
        public string[] DataQualityFlags { get; set; }
    }

    public class EmissionEstimateResponseConstituentGasesType
    {
        [JsonProperty("co2e_total")]
        public double Co2eTotal { get; set; }

        [JsonProperty("co2e_other")]
        public double Co2eOther { get; set; }

        [JsonProperty("co2")]
        public double Co2 { get; set; }

        [JsonProperty("ch4")]
        public double Ch4 { get; set; }

        [JsonProperty("n2o")]
        public double N2o { get; set; }
    }

    public class EmissionEstimateInput
    {
        [JsonProperty("emission_factor")]
        public EmissionEstimateInputEmissionFactorType EmissionFactor { get; set; }

        [JsonProperty("parameters")]
        public EmissionEstimateInputParametersType Parameters { get; set; }
    }

    public class EmissionEstimateInputEmissionFactorType
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("region_fallback")]
        public bool? RegionFallback { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("calculation_method")]
        public string CalculationMethod { get; set; }
    }

    public class EmissionEstimateInputParametersType
    {
        [JsonProperty("energy")]
        public int? Energy { get; set; }

        [JsonProperty("energy_unit")]
        public string EnergyUnit { get; set; }

        [JsonProperty("data")]
        public int? Data { get; set; }

        [JsonProperty("data_unit")]
        public string DataUnit { get; set; }

        [JsonProperty("distance")]
        public int? Distance { get; set; }

        [JsonProperty("distance_unit")]
        public string DistanceUnit { get; set; }

        [JsonProperty("money")]
        public int? Money { get; set; }

        [JsonProperty("money_unit")]
        public string MoneyUnit { get; set; }

        [JsonProperty("number")]
        public int? Number { get; set; }

        [JsonProperty("time")]
        public int? Time { get; set; }

        [JsonProperty("time_unit")]
        public string TimeUnit { get; set; }

        [JsonProperty("passengers")]
        public int? Passengers { get; set; }

        [JsonProperty("volume")]
        public int? Volume { get; set; }

        [JsonProperty("volume_unit")]
        public string VolumeUnit { get; set; }

        [JsonProperty("weight")]
        public int? Weight { get; set; }

        [JsonProperty("weight_unit")]
        public string WeightUnit { get; set; }
    }

    public class EmissionEstimateBulkResponse
    {
        [JsonProperty("results")]
        public EmissionEstimateBulkResponseResultsTypeItem[] Results { get; set; }
    }

    public class EmissionEstimateBulkResponseResultsTypeItem
    {
        [JsonProperty("co2e")]
        public double Co2e { get; set; }

        [JsonProperty("co2e_unit")]
        public string Co2eUnit { get; set; }

        [JsonProperty("co2e_calculation_method")]
        public string Co2eCalculationMethod { get; set; }

        [JsonProperty("co2e_calculation_origin")]
        public string Co2eCalculationOrigin { get; set; }

        [JsonProperty("emission_factor")]
        public EmissionEstimateBulkResponseResultsTypeItemEmissionFactorType EmissionFactor { get; set; }

        [JsonProperty("constituent_gases")]
        public EmissionEstimateBulkResponseResultsTypeItemConstituentGasesType ConstituentGases { get; set; }
    }

    public class EmissionEstimateBulkResponseResultsTypeItemEmissionFactorType
    {
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("access_type")]
        public string AccessType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("data_quality_flags")]
        public string[] DataQualityFlags { get; set; }
    }

    public class EmissionEstimateBulkResponseResultsTypeItemConstituentGasesType
    {
        [JsonProperty("co2e_total")]
        public double Co2eTotal { get; set; }

        [JsonProperty("co2e_other")]
        public double Co2eOther { get; set; }

        [JsonProperty("co2")]
        public double Co2 { get; set; }

        [JsonProperty("ch4")]
        public double Ch4 { get; set; }

        [JsonProperty("n2o")]
        public double N2o { get; set; }
    }

    public class bodyInputItem
    {
        [JsonProperty("co2e")]
        public double Co2e { get; set; }

        [JsonProperty("co2e_unit")]
        public string Co2eUnit { get; set; }

        [JsonProperty("co2e_calculation_method")]
        public string Co2eCalculationMethod { get; set; }

        [JsonProperty("co2e_calculation_origin")]
        public string Co2eCalculationOrigin { get; set; }

        [JsonProperty("emission_factor")]
        public bodyInputItemEmissionFactorType EmissionFactor { get; set; }

        [JsonProperty("constituent_gases")]
        public bodyInputItemConstituentGasesType ConstituentGases { get; set; }
    }

    public class bodyInputItemEmissionFactorType
    {
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("access_type")]
        public string AccessType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("data_quality_flags")]
        public string[] DataQualityFlags { get; set; }
    }

    public class bodyInputItemConstituentGasesType
    {
        [JsonProperty("co2e_total")]
        public double Co2eTotal { get; set; }

        [JsonProperty("co2e_other")]
        public double Co2eOther { get; set; }

        [JsonProperty("co2")]
        public double Co2 { get; set; }

        [JsonProperty("ch4")]
        public double Ch4 { get; set; }

        [JsonProperty("n2o")]
        public double N2o { get; set; }
    }

    public class TravelFlightResponse
    {
        [JsonProperty("co2e")]
        public double Co2e { get; set; }

        [JsonProperty("co2e_unit")]
        public string Co2eUnit { get; set; }

        [JsonProperty("legs")]
        public TravelFlightResponseLegsTypeItem[] Legs { get; set; }
    }

    public class TravelFlightResponseLegsTypeItem
    {
        [JsonProperty("co2e")]
        public double Co2e { get; set; }

        [JsonProperty("co2e_unit")]
        public string Co2eUnit { get; set; }

        [JsonProperty("co2e_calculation_method")]
        public string Co2eCalculationMethod { get; set; }

        [JsonProperty("co2e_calculation_origin")]
        public string Co2eCalculationOrigin { get; set; }

        [JsonProperty("emission_factor")]
        public TravelFlightResponseLegsTypeItemEmissionFactorType EmissionFactor { get; set; }

        [JsonProperty("constituent_gases")]
        public TravelFlightResponseLegsTypeItemConstituentGasesType ConstituentGases { get; set; }
    }

    public class TravelFlightResponseLegsTypeItemEmissionFactorType
    {
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("access_type")]
        public string AccessType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("data_quality_flags")]
        public string[] DataQualityFlags { get; set; }
    }

    public class TravelFlightResponseLegsTypeItemConstituentGasesType
    {
        [JsonProperty("co2e_total")]
        public double Co2eTotal { get; set; }

        [JsonProperty("co2e_other")]
        public double Co2eOther { get; set; }

        [JsonProperty("co2")]
        public double Co2 { get; set; }

        [JsonProperty("ch4")]
        public double Ch4 { get; set; }

        [JsonProperty("n2o")]
        public double N2o { get; set; }
    }

    public class TravelFlightInput
    {
        [JsonProperty("legs", DefaultValueHandling = DefaultValueHandling.Include)]
        public TravelFlightInputLegsTypeItem[] Legs { get; set; }
    }

    public class TravelFlightInputLegsTypeItem
    {
        [JsonProperty("from", DefaultValueHandling = DefaultValueHandling.Include)]
        public string From { get; set; }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty("passengers")]
        public int? Passengers { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }
    }

    public class FreightFlightResponse
    {
        [JsonProperty("co2e")]
        public double Co2e { get; set; }

        [JsonProperty("co2e_unit")]
        public string Co2eUnit { get; set; }

        [JsonProperty("legs")]
        public FreightFlightResponseLegsTypeItem[] Legs { get; set; }
    }

    public class FreightFlightResponseLegsTypeItem
    {
        [JsonProperty("co2e")]
        public double Co2e { get; set; }

        [JsonProperty("co2e_unit")]
        public string Co2eUnit { get; set; }

        [JsonProperty("co2e_calculation_method")]
        public string Co2eCalculationMethod { get; set; }

        [JsonProperty("co2e_calculation_origin")]
        public string Co2eCalculationOrigin { get; set; }

        [JsonProperty("emission_factor")]
        public FreightFlightResponseLegsTypeItemEmissionFactorType EmissionFactor { get; set; }

        [JsonProperty("constituent_gases")]
        public FreightFlightResponseLegsTypeItemConstituentGasesType ConstituentGases { get; set; }
    }

    public class FreightFlightResponseLegsTypeItemEmissionFactorType
    {
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("access_type")]
        public string AccessType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("data_quality_flags")]
        public string[] DataQualityFlags { get; set; }
    }

    public class FreightFlightResponseLegsTypeItemConstituentGasesType
    {
        [JsonProperty("co2e_total")]
        public double Co2eTotal { get; set; }

        [JsonProperty("co2e_other")]
        public double Co2eOther { get; set; }

        [JsonProperty("co2")]
        public double Co2 { get; set; }

        [JsonProperty("ch4")]
        public double Ch4 { get; set; }

        [JsonProperty("n2o")]
        public double N2o { get; set; }
    }

    public class FreightFlightInput
    {
        [JsonProperty("legs", DefaultValueHandling = DefaultValueHandling.Include)]
        public FreightFlightInputLegsTypeItem[] Legs { get; set; }
    }

    public class FreightFlightInputLegsTypeItem
    {
        [JsonProperty("from", DefaultValueHandling = DefaultValueHandling.Include)]
        public string From { get; set; }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty("passengers")]
        public int? Passengers { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }
    }

    public class ComputeMetadataResponse
    {
        [JsonProperty("cloud_providers")]
        public ComputeMetadataResponseCloudProvidersType CloudProviders { get; set; }
    }

    public class ComputeMetadataResponseCloudProvidersType
    {
        [JsonProperty("gcp")]
        public ComputeMetadataResponseCloudProvidersTypeGcpType Gcp { get; set; }

        [JsonProperty("aws")]
        public ComputeMetadataResponseCloudProvidersTypeAwsType Aws { get; set; }

        [JsonProperty("azure")]
        public ComputeMetadataResponseCloudProvidersTypeAzureType Azure { get; set; }
    }

    public class ComputeMetadataResponseCloudProvidersTypeGcpType
    {
        [JsonProperty("provider_id")]
        public string ProviderId { get; set; }

        [JsonProperty("provider_full_name")]
        public string ProviderFullName { get; set; }

        [JsonProperty("cpu_regions")]
        public string[] CpuRegions { get; set; }

        [JsonProperty("storage_regions")]
        public string[] StorageRegions { get; set; }

        [JsonProperty("memory_regions")]
        public string[] MemoryRegions { get; set; }
    }

    public class ComputeMetadataResponseCloudProvidersTypeAwsType
    {
        [JsonProperty("provider_id")]
        public string ProviderId { get; set; }

        [JsonProperty("provider_full_name")]
        public string ProviderFullName { get; set; }

        [JsonProperty("cpu_regions")]
        public string[] CpuRegions { get; set; }

        [JsonProperty("storage_regions")]
        public string[] StorageRegions { get; set; }

        [JsonProperty("memory_regions")]
        public string[] MemoryRegions { get; set; }
    }

    public class ComputeMetadataResponseCloudProvidersTypeAzureType
    {
        [JsonProperty("provider_id")]
        public string ProviderId { get; set; }

        [JsonProperty("provider_full_name")]
        public string ProviderFullName { get; set; }

        [JsonProperty("cpu_regions")]
        public string[] CpuRegions { get; set; }

        [JsonProperty("storage_regions")]
        public string[] StorageRegions { get; set; }

        [JsonProperty("memory_regions")]
        public string[] MemoryRegions { get; set; }
    }

    public class ComputeCPUResponse
    {
        [JsonProperty("co2e")]
        public double Co2e { get; set; }

        [JsonProperty("co2e_unit")]
        public string Co2eUnit { get; set; }

        [JsonProperty("co2e_calculation_method")]
        public string Co2eCalculationMethod { get; set; }

        [JsonProperty("co2e_calculation_origin")]
        public string Co2eCalculationOrigin { get; set; }

        [JsonProperty("emission_factor")]
        public ComputeCPUResponseEmissionFactorType EmissionFactor { get; set; }

        [JsonProperty("constituent_gases")]
        public ComputeCPUResponseConstituentGasesType ConstituentGases { get; set; }
    }

    public class ComputeCPUResponseEmissionFactorType
    {
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("access_type")]
        public string AccessType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("data_quality_flags")]
        public string[] DataQualityFlags { get; set; }
    }

    public class ComputeCPUResponseConstituentGasesType
    {
        [JsonProperty("co2e_total")]
        public double Co2eTotal { get; set; }

        [JsonProperty("co2e_other")]
        public double Co2eOther { get; set; }

        [JsonProperty("co2")]
        public double Co2 { get; set; }

        [JsonProperty("ch4")]
        public double Ch4 { get; set; }

        [JsonProperty("n2o")]
        public double N2o { get; set; }
    }

    public class ComputeCPUInput
    {
        [JsonProperty("cpu_count", DefaultValueHandling = DefaultValueHandling.Include)]
        public int CpuCount { get; set; }

        [JsonProperty("region", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Region { get; set; }

        [JsonProperty("cpu_load", DefaultValueHandling = DefaultValueHandling.Include)]
        public int CpuLoad { get; set; }

        [JsonProperty("duration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Duration { get; set; }

        [JsonProperty("duration_unit")]
        public string DurationUnit { get; set; }
    }

    public class ComputeStorageResponse
    {
        [JsonProperty("co2e")]
        public double Co2e { get; set; }

        [JsonProperty("co2e_unit")]
        public string Co2eUnit { get; set; }

        [JsonProperty("co2e_calculation_method")]
        public string Co2eCalculationMethod { get; set; }

        [JsonProperty("co2e_calculation_origin")]
        public string Co2eCalculationOrigin { get; set; }

        [JsonProperty("emission_factor")]
        public ComputeStorageResponseEmissionFactorType EmissionFactor { get; set; }

        [JsonProperty("constituent_gases")]
        public ComputeStorageResponseConstituentGasesType ConstituentGases { get; set; }
    }

    public class ComputeStorageResponseEmissionFactorType
    {
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("access_type")]
        public string AccessType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("data_quality_flags")]
        public string[] DataQualityFlags { get; set; }
    }

    public class ComputeStorageResponseConstituentGasesType
    {
        [JsonProperty("co2e_total")]
        public double Co2eTotal { get; set; }

        [JsonProperty("co2e_other")]
        public double Co2eOther { get; set; }

        [JsonProperty("co2")]
        public double Co2 { get; set; }

        [JsonProperty("ch4")]
        public double Ch4 { get; set; }

        [JsonProperty("n2o")]
        public double N2o { get; set; }
    }

    public class ComputeStorageInput
    {
        [JsonProperty("region", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Region { get; set; }

        [JsonProperty("storage_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public ComputeStorageInputStorageTypeType StorageType { get; set; } = ComputeStorageInputStorageTypeType.Ssd;

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Data { get; set; }

        [JsonProperty("data_unit")]
        public string DataUnit { get; set; }

        [JsonProperty("duration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Duration { get; set; }

        [JsonProperty("duration_unit")]
        public string DurationUnit { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ComputeStorageInputStorageTypeType
    {
        [EnumMember(Value = "ssd")]
        Ssd,
        [EnumMember(Value = "hdd")]
        Hdd
    }

    public class ComputeMemoryResponse
    {
        [JsonProperty("co2e")]
        public double Co2e { get; set; }

        [JsonProperty("co2e_unit")]
        public string Co2eUnit { get; set; }

        [JsonProperty("co2e_calculation_method")]
        public string Co2eCalculationMethod { get; set; }

        [JsonProperty("co2e_calculation_origin")]
        public string Co2eCalculationOrigin { get; set; }

        [JsonProperty("emission_factor")]
        public ComputeMemoryResponseEmissionFactorType EmissionFactor { get; set; }

        [JsonProperty("constituent_gases")]
        public ComputeMemoryResponseConstituentGasesType ConstituentGases { get; set; }
    }

    public class ComputeMemoryResponseEmissionFactorType
    {
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("access_type")]
        public string AccessType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("data_quality_flags")]
        public JToken[] DataQualityFlags { get; set; }
    }

    public class ComputeMemoryResponseConstituentGasesType
    {
        [JsonProperty("co2e_total")]
        public double Co2eTotal { get; set; }

        [JsonProperty("co2e_other")]
        public double Co2eOther { get; set; }

        [JsonProperty("co2")]
        public double Co2 { get; set; }

        [JsonProperty("ch4")]
        public double Ch4 { get; set; }

        [JsonProperty("n2o")]
        public double N2o { get; set; }
    }

    public class ComputeMemoryInput
    {
        [JsonProperty("region", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Region { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Data { get; set; }

        [JsonProperty("data_unit")]
        public string DataUnit { get; set; }

        [JsonProperty("duration", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Duration { get; set; }

        [JsonProperty("duration_unit")]
        public string DurationUnit { get; set; }
    }

    public class ClassificationResponse
    {
        [JsonProperty("co2e")]
        public double Co2e { get; set; }

        [JsonProperty("co2e_unit")]
        public string Co2eUnit { get; set; }

        [JsonProperty("co2e_calculation_method")]
        public string Co2eCalculationMethod { get; set; }

        [JsonProperty("co2e_calculation_origin")]
        public string Co2eCalculationOrigin { get; set; }

        [JsonProperty("emission_factor")]
        public ClassificationResponseEmissionFactorType EmissionFactor { get; set; }

        [JsonProperty("constituent_gases")]
        public ClassificationResponseConstituentGasesType ConstituentGases { get; set; }
    }

    public class ClassificationResponseEmissionFactorType
    {
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("access_type")]
        public string AccessType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("data_quality_flags")]
        public string[] DataQualityFlags { get; set; }
    }

    public class ClassificationResponseConstituentGasesType
    {
        [JsonProperty("co2e_total")]
        public double Co2eTotal { get; set; }

        [JsonProperty("co2e_other")]
        public double Co2eOther { get; set; }

        [JsonProperty("co2")]
        public double Co2 { get; set; }

        [JsonProperty("ch4")]
        public double Ch4 { get; set; }

        [JsonProperty("n2o")]
        public double N2o { get; set; }
    }

    public class ClassificationInput
    {
        [JsonProperty("classification")]
        public ClassificationInputClassificationType Classification { get; set; }

        [JsonProperty("parameters")]
        public ClassificationInputParametersType Parameters { get; set; }
    }

    public class ClassificationInputClassificationType
    {
        [JsonProperty("classification_type")]
        public string ClassificationType { get; set; }

        [JsonProperty("classification_code")]
        public string ClassificationCode { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("region_fallback")]
        public bool? RegionFallback { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("calculation_method")]
        public string CalculationMethod { get; set; }
    }

    public class ClassificationInputParametersType
    {
        [JsonProperty("energy")]
        public int? Energy { get; set; }

        [JsonProperty("energy_unit")]
        public string EnergyUnit { get; set; }

        [JsonProperty("data")]
        public int? Data { get; set; }

        [JsonProperty("data_unit")]
        public string DataUnit { get; set; }

        [JsonProperty("distance")]
        public int? Distance { get; set; }

        [JsonProperty("distance_unit")]
        public string DistanceUnit { get; set; }

        [JsonProperty("money")]
        public int? Money { get; set; }

        [JsonProperty("money_unit")]
        public string MoneyUnit { get; set; }

        [JsonProperty("number")]
        public int? Number { get; set; }

        [JsonProperty("time")]
        public int? Time { get; set; }

        [JsonProperty("time_unit")]
        public string TimeUnit { get; set; }

        [JsonProperty("passengers")]
        public int? Passengers { get; set; }

        [JsonProperty("volume")]
        public int? Volume { get; set; }

        [JsonProperty("volume_unit")]
        public string VolumeUnit { get; set; }

        [JsonProperty("weight")]
        public int? Weight { get; set; }

        [JsonProperty("weight_unit")]
        public string WeightUnit { get; set; }
    }

    public class CustomResponse
    {
        [JsonProperty("co2e")]
        public double Co2e { get; set; }

        [JsonProperty("co2e_unit")]
        public string Co2eUnit { get; set; }

        [JsonProperty("co2e_calculation_method")]
        public string Co2eCalculationMethod { get; set; }

        [JsonProperty("co2e_calculation_origin")]
        public string Co2eCalculationOrigin { get; set; }

        [JsonProperty("emission_factor")]
        public CustomResponseEmissionFactorType EmissionFactor { get; set; }

        [JsonProperty("constituent_gases")]
        public CustomResponseConstituentGasesType ConstituentGases { get; set; }
    }

    public class CustomResponseEmissionFactorType
    {
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("access_type")]
        public string AccessType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("data_quality_flags")]
        public string[] DataQualityFlags { get; set; }
    }

    public class CustomResponseConstituentGasesType
    {
        [JsonProperty("co2e_total")]
        public double Co2eTotal { get; set; }

        [JsonProperty("co2e_other")]
        public double Co2eOther { get; set; }

        [JsonProperty("co2")]
        public double Co2 { get; set; }

        [JsonProperty("ch4")]
        public double Ch4 { get; set; }

        [JsonProperty("n2o")]
        public double N2o { get; set; }
    }

    public class CustomInput
    {
        [JsonProperty("custom_activity", DefaultValueHandling = DefaultValueHandling.Include)]
        public CustomInputCustomActivityType CustomActivity { get; set; }

        [JsonProperty("parameters")]
        public CustomInputParametersType Parameters { get; set; }
    }

    public class CustomInputCustomActivityType
    {
        [JsonProperty("label", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Label { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("region_fallback")]
        public bool? RegionFallback { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("calculation_method")]
        public string CalculationMethod { get; set; }
    }

    public class CustomInputParametersType
    {
        [JsonProperty("energy")]
        public int? Energy { get; set; }

        [JsonProperty("energy_unit")]
        public string EnergyUnit { get; set; }

        [JsonProperty("data")]
        public int? Data { get; set; }

        [JsonProperty("data_unit")]
        public string DataUnit { get; set; }

        [JsonProperty("distance")]
        public int? Distance { get; set; }

        [JsonProperty("distance_unit")]
        public string DistanceUnit { get; set; }

        [JsonProperty("money")]
        public int? Money { get; set; }

        [JsonProperty("money_unit")]
        public string MoneyUnit { get; set; }

        [JsonProperty("number")]
        public int? Number { get; set; }

        [JsonProperty("time")]
        public int? Time { get; set; }

        [JsonProperty("time_unit")]
        public string TimeUnit { get; set; }

        [JsonProperty("passengers")]
        public int? Passengers { get; set; }

        [JsonProperty("volume")]
        public int? Volume { get; set; }

        [JsonProperty("volume_unit")]
        public string VolumeUnit { get; set; }

        [JsonProperty("weight")]
        public int? Weight { get; set; }

        [JsonProperty("weight_unit")]
        public string WeightUnit { get; set; }
    }

    public class CustomBatchResponse
    {
        [JsonProperty("results")]
        public CustomBatchResponseResultsTypeItem[] Results { get; set; }
    }

    public class CustomBatchResponseResultsTypeItem
    {
        [JsonProperty("co2e")]
        public double Co2e { get; set; }

        [JsonProperty("co2e_unit")]
        public string Co2eUnit { get; set; }

        [JsonProperty("co2e_calculation_method")]
        public string Co2eCalculationMethod { get; set; }

        [JsonProperty("co2e_calculation_origin")]
        public string Co2eCalculationOrigin { get; set; }

        [JsonProperty("emission_factor")]
        public CustomBatchResponseResultsTypeItemEmissionFactorType EmissionFactor { get; set; }

        [JsonProperty("constituent_gases")]
        public CustomBatchResponseResultsTypeItemConstituentGasesType ConstituentGases { get; set; }
    }

    public class CustomBatchResponseResultsTypeItemEmissionFactorType
    {
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("access_type")]
        public string AccessType { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("data_quality_flags")]
        public JToken[] DataQualityFlags { get; set; }
    }

    public class CustomBatchResponseResultsTypeItemConstituentGasesType
    {
        [JsonProperty("co2e_total")]
        public double Co2eTotal { get; set; }

        [JsonProperty("co2e_other")]
        public double Co2eOther { get; set; }

        [JsonProperty("co2")]
        public double Co2 { get; set; }

        [JsonProperty("ch4")]
        public double Ch4 { get; set; }

        [JsonProperty("n2o")]
        public double N2o { get; set; }
    }

    public class bodyInputItem2
    {
        [JsonProperty("custom_activity")]
        public bodyInputItemCustomActivityType CustomActivity { get; set; }

        [JsonProperty("parameters")]
        public bodyInputItemParametersType Parameters { get; set; }
    }

    public class bodyInputItemCustomActivityType
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("region_fallback")]
        public bool RegionFallback { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("calculation_method")]
        public string CalculationMethod { get; set; }
    }

    public class bodyInputItemParametersType
    {
        [JsonProperty("energy")]
        public int Energy { get; set; }

        [JsonProperty("energy_unit")]
        public string EnergyUnit { get; set; }

        [JsonProperty("data")]
        public int Data { get; set; }

        [JsonProperty("data_unit")]
        public string DataUnit { get; set; }

        [JsonProperty("distance")]
        public int Distance { get; set; }

        [JsonProperty("distance_unit")]
        public string DistanceUnit { get; set; }

        [JsonProperty("money")]
        public int Money { get; set; }

        [JsonProperty("money_unit")]
        public string MoneyUnit { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("time_unit")]
        public string TimeUnit { get; set; }

        [JsonProperty("passengers")]
        public int Passengers { get; set; }

        [JsonProperty("volume")]
        public int Volume { get; set; }

        [JsonProperty("volume_unit")]
        public string VolumeUnit { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }

        [JsonProperty("weight_unit")]
        public string WeightUnit { get; set; }
    }

    public class FactorsSearchResponse
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("last_page")]
        public int LastPage { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("results")]
        public FactorsSearchResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("possible_filters")]
        public FactorsSearchResponsePossibleFiltersType PossibleFilters { get; set; }
    }

    public class FactorsSearchResponseResultsTypeItem
    {
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("sector")]
        public string Sector { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("source_link")]
        public string SourceLink { get; set; }

        [JsonProperty("uncertainty")]
        public string Uncertainty { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("region_name")]
        public string RegionName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("unit_type")]
        public string[] UnitType { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("lca_activity")]
        public string LcaActivity { get; set; }

        [JsonProperty("data_quality_flags")]
        public string[] DataQualityFlags { get; set; }

        [JsonProperty("access_type")]
        public string AccessType { get; set; }

        [JsonProperty("supported_calculation_methods")]
        public string[] SupportedCalculationMethods { get; set; }

        [JsonProperty("factor")]
        public double Factor { get; set; }

        [JsonProperty("factor_calculation_method")]
        public string FactorCalculationMethod { get; set; }

        [JsonProperty("factor_calculation_origin")]
        public string FactorCalculationOrigin { get; set; }

        [JsonProperty("constituent_gases")]
        public FactorsSearchResponseResultsTypeItemConstituentGasesType ConstituentGases { get; set; }
    }

    public class FactorsSearchResponseResultsTypeItemConstituentGasesType
    {
        [JsonProperty("co2e_total")]
        public double Co2eTotal { get; set; }

        [JsonProperty("co2e_other")]
        public string Co2eOther { get; set; }

        [JsonProperty("co2")]
        public string Co2 { get; set; }

        [JsonProperty("ch4")]
        public string Ch4 { get; set; }

        [JsonProperty("n2o")]
        public string N2o { get; set; }
    }

    public class FactorsSearchResponsePossibleFiltersType
    {
        [JsonProperty("year")]
        public string[] Year { get; set; }

        [JsonProperty("source")]
        public string[] Source { get; set; }

        [JsonProperty("region")]
        public FactorsSearchResponsePossibleFiltersTypeRegionTypeItem[] Region { get; set; }

        [JsonProperty("category")]
        public string[] Category { get; set; }

        [JsonProperty("sector")]
        public string[] Sector { get; set; }

        [JsonProperty("unit_type")]
        public string[] UnitType { get; set; }
    }

    public class FactorsSearchResponsePossibleFiltersTypeRegionTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SourcesResponse
    {
        [JsonProperty("results")]
        public string[] Results { get; set; }
    }

    public class YearsResponse
    {
        [JsonProperty("results")]
        public string[] Results { get; set; }
    }

    public class RegionsResponse
    {
        [JsonProperty("results")]
        public RegionsResponseResultsTypeItem[] Results { get; set; }
    }

    public class RegionsResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CategoriesResponse
    {
        [JsonProperty("results")]
        public string[] Results { get; set; }
    }

    public class SectorsResponse
    {
        [JsonProperty("results")]
        public string[] Results { get; set; }
    }

    public class LifeCycleActivitiesResponse
    {
        [JsonProperty("results")]
        public string[] Results { get; set; }
    }

    public class UnitTypesResponse
    {
        [JsonProperty("results")]
        public string[] Results { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Climatiqip;

    public partial class WorkflowManagedActions
    {
        public ClimatiqipActions Climatiqip(string connectionId) => new ClimatiqipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ClimatiqipTriggers Climatiqip(string connectionId) => new ClimatiqipTriggers(connectionId);
    }
}