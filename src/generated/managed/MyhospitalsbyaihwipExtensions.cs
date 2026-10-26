//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Myhospitalsbyaihwip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MyhospitalsbyaihwipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetCaveatsResponse, ApiConnectionActionConfiguration> GetCaveats()
        {
            return new DeferredBodyAction<GetCaveatsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/caveats";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetCaveatsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetCaveatResponse, ApiConnectionActionConfiguration> GetCaveat(Expression<Func<string>> caveatCode)
        {
            var __workflow_caveatCode = WorkflowExpression.Compile(caveatCode, nameof(caveatCode), required: true);
            return new DeferredBodyAction<GetCaveatResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/caveats/{0}", __workflow_caveatCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetCaveatResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetDataSetsResponse, ApiConnectionActionConfiguration> GetDataSets(Expression<Func<string>> measureCode = null, Expression<Func<string>> reportedMeasureCode = null)
        {
            var __workflow_measureCode = WorkflowExpression.Compile(measureCode, nameof(measureCode), required: false);
            var __workflow_reportedMeasureCode = WorkflowExpression.Compile(reportedMeasureCode, nameof(reportedMeasureCode), required: false);
            return new DeferredBodyAction<GetDataSetsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/datasets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_measureCode != null)
                    callPayload.Queries["measure_code"] = ExpressionConverter.Convert(__workflow_measureCode);
                if (__workflow_reportedMeasureCode != null)
                    callPayload.Queries["reported_measure_code"] = ExpressionConverter.Convert(__workflow_reportedMeasureCode);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetDataSetsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetDataSetResponse, ApiConnectionActionConfiguration> GetDataSet(Expression<Func<int>> datasetId)
        {
            var __workflow_datasetId = WorkflowExpression.Compile(datasetId, nameof(datasetId), required: true);
            return new DeferredBodyAction<GetDataSetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/{0}", __workflow_datasetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetDataSetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetDatasetItemsResponse, ApiConnectionActionConfiguration> GetDatasetItems(Expression<Func<string>> datasetId, Expression<Func<string>> reportingUnitCode = null)
        {
            var __workflow_datasetId = WorkflowExpression.Compile(datasetId, nameof(datasetId), required: true);
            var __workflow_reportingUnitCode = WorkflowExpression.Compile(reportingUnitCode, nameof(reportingUnitCode), required: false);
            return new DeferredBodyAction<GetDatasetItemsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/datasets/{0}/data-items", __workflow_datasetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reportingUnitCode != null)
                    callPayload.Queries["reporting_unit_code"] = ExpressionConverter.Convert(__workflow_reportingUnitCode);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetDatasetItemsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetMeasureCategoriesResponse, ApiConnectionActionConfiguration> GetMeasureCategories()
        {
            return new DeferredBodyAction<GetMeasureCategoriesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/measure-categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetMeasureCategoriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetSingleMeasureCategoryResponse, ApiConnectionActionConfiguration> GetSingleMeasureCategory(Expression<Func<string>> measureCategoryCode)
        {
            var __workflow_measureCategoryCode = WorkflowExpression.Compile(measureCategoryCode, nameof(measureCategoryCode), required: true);
            return new DeferredBodyAction<GetSingleMeasureCategoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/measure-categories/{0}", __workflow_measureCategoryCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetSingleMeasureCategoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetSingleMeasureCategoryMeasuresResponse, ApiConnectionActionConfiguration> GetSingleMeasureCategoryMeasures(Expression<Func<string>> measureCategoryCode)
        {
            var __workflow_measureCategoryCode = WorkflowExpression.Compile(measureCategoryCode, nameof(measureCategoryCode), required: true);
            return new DeferredBodyAction<GetSingleMeasureCategoryMeasuresResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/measure-categories/{0}/measures", __workflow_measureCategoryCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetSingleMeasureCategoryMeasuresResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetReportedMeasureCategoriesResponse, ApiConnectionActionConfiguration> GetReportedMeasureCategories()
        {
            return new DeferredBodyAction<GetReportedMeasureCategoriesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/reported-measure-categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetReportedMeasureCategoriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetReportedMeasureCategoryResponse, ApiConnectionActionConfiguration> GetReportedMeasureCategory(Expression<Func<string>> reportedMeasureCategoryCode)
        {
            var __workflow_reportedMeasureCategoryCode = WorkflowExpression.Compile(reportedMeasureCategoryCode, nameof(reportedMeasureCategoryCode), required: true);
            return new DeferredBodyAction<GetReportedMeasureCategoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/reported-measure-categories/{0}", __workflow_reportedMeasureCategoryCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetReportedMeasureCategoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetReportedMeasureCategoryMeasuresResponse, ApiConnectionActionConfiguration> GetReportedMeasureCategoryMeasures(Expression<Func<string>> reportedMeasureCategoryCode)
        {
            var __workflow_reportedMeasureCategoryCode = WorkflowExpression.Compile(reportedMeasureCategoryCode, nameof(reportedMeasureCategoryCode), required: true);
            return new DeferredBodyAction<GetReportedMeasureCategoryMeasuresResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/reported-measure-categories/{0}/reported-measures", __workflow_reportedMeasureCategoryCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetReportedMeasureCategoryMeasuresResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetReportedMeasuresResponse, ApiConnectionActionConfiguration> GetReportedMeasures(Expression<Func<string>> measureCode = null)
        {
            var __workflow_measureCode = WorkflowExpression.Compile(measureCode, nameof(measureCode), required: false);
            return new DeferredBodyAction<GetReportedMeasuresResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/reported-measures";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_measureCode != null)
                    callPayload.Queries["measure_code"] = ExpressionConverter.Convert(__workflow_measureCode);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetReportedMeasuresResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<ReportedMeasureModel, ApiConnectionActionConfiguration> GetSingleReportedMeasure(Expression<Func<string>> reportedMeasureCode)
        {
            var __workflow_reportedMeasureCode = WorkflowExpression.Compile(reportedMeasureCode, nameof(reportedMeasureCode), required: true);
            return new DeferredBodyAction<ReportedMeasureModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/reported-measures/{0}", __workflow_reportedMeasureCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ReportedMeasureModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetSingleReportedMeasureDataItemsResponse, ApiConnectionActionConfiguration> GetSingleReportedMeasureDataItems(Expression<Func<string>> reportedMeasureCode)
        {
            var __workflow_reportedMeasureCode = WorkflowExpression.Compile(reportedMeasureCode, nameof(reportedMeasureCode), required: true);
            return new DeferredBodyAction<GetSingleReportedMeasureDataItemsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/reported-measures/{0}/data-items", __workflow_reportedMeasureCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetSingleReportedMeasureDataItemsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetReportingUnitsResponse, ApiConnectionActionConfiguration> GetReportingUnits(Expression<Func<string>> reportingUnitTypeCode = null)
        {
            var __workflow_reportingUnitTypeCode = WorkflowExpression.Compile(reportingUnitTypeCode, nameof(reportingUnitTypeCode), required: false);
            return new DeferredBodyAction<GetReportingUnitsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/reporting-units";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reportingUnitTypeCode != null)
                    callPayload.Queries["reporting_unit_type_code"] = ExpressionConverter.Convert(__workflow_reportingUnitTypeCode);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetReportingUnitsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetSingleReportingUnitResponse, ApiConnectionActionConfiguration> GetSingleReportingUnit(Expression<Func<string>> reportingUnitCode)
        {
            var __workflow_reportingUnitCode = WorkflowExpression.Compile(reportingUnitCode, nameof(reportingUnitCode), required: true);
            return new DeferredBodyAction<GetSingleReportingUnitResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/reporting-units/{0}", __workflow_reportingUnitCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetSingleReportingUnitResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetSingleReportingUnitDataitemsResponse, ApiConnectionActionConfiguration> GetSingleReportingUnitDataitems(Expression<Func<string>> reportingUnitCode)
        {
            var __workflow_reportingUnitCode = WorkflowExpression.Compile(reportingUnitCode, nameof(reportingUnitCode), required: true);
            return new DeferredBodyAction<GetSingleReportingUnitDataitemsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/reporting-units/{0}/data-items", __workflow_reportingUnitCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetSingleReportingUnitDataitemsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetSingleReportingUnitMeasuresResponse, ApiConnectionActionConfiguration> GetSingleReportingUnitMeasures(Expression<Func<string>> reportingUnitCode)
        {
            var __workflow_reportingUnitCode = WorkflowExpression.Compile(reportingUnitCode, nameof(reportingUnitCode), required: true);
            return new DeferredBodyAction<GetSingleReportingUnitMeasuresResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/reporting-units/{0}/measures-available", __workflow_reportingUnitCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetSingleReportingUnitMeasuresResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetSingleReportingUnitBricksResponse, ApiConnectionActionConfiguration> GetSingleReportingUnitBricks(Expression<Func<string>> reportingUnitCode)
        {
            var __workflow_reportingUnitCode = WorkflowExpression.Compile(reportingUnitCode, nameof(reportingUnitCode), required: true);
            return new DeferredBodyAction<GetSingleReportingUnitBricksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/reporting-units/{0}/bricks-available", __workflow_reportingUnitCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetSingleReportingUnitBricksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetReportingUnitTypesResponse, ApiConnectionActionConfiguration> GetReportingUnitTypes()
        {
            return new DeferredBodyAction<GetReportingUnitTypesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/reporting-unit-types";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetReportingUnitTypesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetSingleReportingUnitTypeResponse, ApiConnectionActionConfiguration> GetSingleReportingUnitType(Expression<Func<string>> reportingUnitTypeCode)
        {
            var __workflow_reportingUnitTypeCode = WorkflowExpression.Compile(reportingUnitTypeCode, nameof(reportingUnitTypeCode), required: true);
            return new DeferredBodyAction<GetSingleReportingUnitTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/reporting-unit-types/{0}", __workflow_reportingUnitTypeCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetSingleReportingUnitTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetSingleReportUnitTypeBricksResponse, ApiConnectionActionConfiguration> GetSingleReportUnitTypeBricks(Expression<Func<string>> reportingUnitTypeCode)
        {
            var __workflow_reportingUnitTypeCode = WorkflowExpression.Compile(reportingUnitTypeCode, nameof(reportingUnitTypeCode), required: true);
            return new DeferredBodyAction<GetSingleReportUnitTypeBricksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/reporting-unit-types/{0}/bricks-available", __workflow_reportingUnitTypeCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSingleReportUnitTypeBricksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetMeasuresResponse, ApiConnectionActionConfiguration> GetMeasures(Expression<Func<string>> measureCategoryCode = null)
        {
            var __workflow_measureCategoryCode = WorkflowExpression.Compile(measureCategoryCode, nameof(measureCategoryCode), required: false);
            return new DeferredBodyAction<GetMeasuresResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/measures";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_measureCategoryCode != null)
                    callPayload.Queries["measure_category_code"] = ExpressionConverter.Convert(__workflow_measureCategoryCode);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetMeasuresResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetMeasureResponse, ApiConnectionActionConfiguration> GetMeasure(Expression<Func<string>> measureCode)
        {
            var __workflow_measureCode = WorkflowExpression.Compile(measureCode, nameof(measureCode), required: true);
            return new DeferredBodyAction<GetMeasureResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/measures/{0}", __workflow_measureCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetMeasureResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetReportingUnitsForMeasureResponse, ApiConnectionActionConfiguration> GetReportingUnitsForMeasure(Expression<Func<string>> measureCode)
        {
            var __workflow_measureCode = WorkflowExpression.Compile(measureCode, nameof(measureCode), required: true);
            return new DeferredBodyAction<GetReportingUnitsForMeasureResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/measures/{0}/reporting-units-available", __workflow_measureCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetReportingUnitsForMeasureResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetMeasureDataItemsResponse, ApiConnectionActionConfiguration> GetMeasureDataItems(Expression<Func<string>> measureCode)
        {
            var __workflow_measureCode = WorkflowExpression.Compile(measureCode, nameof(measureCode), required: true);
            return new DeferredBodyAction<GetMeasureDataItemsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/measures/{0}/data-items", __workflow_measureCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetMeasureDataItemsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetMeasureDownloadsResponse, ApiConnectionActionConfiguration> GetMeasureDownloads()
        {
            return new DeferredBodyAction<GetMeasureDownloadsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/measure-downloads/measure-download-codes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetMeasureDownloadsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetMeasureDownload(Expression<Func<string>> measureDownloadCode)
        {
            var __workflow_measureDownloadCode = WorkflowExpression.Compile(measureDownloadCode, nameof(measureDownloadCode), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/measure-downloads1/{0}", __workflow_measureDownloadCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetMeasureReportingunitDownload(Expression<Func<string>> measureDownloadCode)
        {
            var __workflow_measureDownloadCode = WorkflowExpression.Compile(measureDownloadCode, nameof(measureDownloadCode), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/measure-downloads/across-reporting-units/{0}", __workflow_measureDownloadCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetReportingUnitDatasheetCodesResponse, ApiConnectionActionConfiguration> GetReportingUnitDatasheetCodes()
        {
            return new DeferredBodyAction<GetReportingUnitDatasheetCodesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/reporting-units-downloads/datasheet-codes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetReportingUnitDatasheetCodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetReportingUnitMappingDownload()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/reporting-units-downloads/mappings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetsReportingUnitDataDownload(Expression<Func<string>> datasheetCode, Expression<Func<string>> reportingUnitCode)
        {
            var __workflow_datasheetCode = WorkflowExpression.Compile(datasheetCode, nameof(datasheetCode), required: true);
            var __workflow_reportingUnitCode = WorkflowExpression.Compile(reportingUnitCode, nameof(reportingUnitCode), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/reporting-units-downloads/{0}/{1}", __workflow_datasheetCode.WithUrlEncoding(1), __workflow_reportingUnitCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetSimpleDownloads()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/simple-downloads/download-codes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetSimpleDownload(Expression<Func<string>> downloadCode)
        {
            var __workflow_downloadCode = WorkflowExpression.Compile(downloadCode, nameof(downloadCode), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/simple-downloads1/{0}", __workflow_downloadCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetFlatFormattedDataResponse, ApiConnectionActionConfiguration> GetFlatFormattedData(Expression<Func<string>> measureCategoryCode, Expression<Func<int>> skip, Expression<Func<int>> top, Expression<Func<string>> measureCode = null, Expression<Func<string>> reportingUnitTypeCode = null, Expression<Func<string>> reportingUnitCode = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null)
        {
            var __workflow_measureCategoryCode = WorkflowExpression.Compile(measureCategoryCode, nameof(measureCategoryCode), required: true);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: true);
            var __workflow_measureCode = WorkflowExpression.Compile(measureCode, nameof(measureCode), required: false);
            var __workflow_reportingUnitTypeCode = WorkflowExpression.Compile(reportingUnitTypeCode, nameof(reportingUnitTypeCode), required: false);
            var __workflow_reportingUnitCode = WorkflowExpression.Compile(reportingUnitCode, nameof(reportingUnitCode), required: false);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            return new DeferredBodyAction<GetFlatFormattedDataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/flat-formatted-data-extract/{0}", __workflow_measureCategoryCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_measureCode != null)
                    callPayload.Queries["measure_code"] = ExpressionConverter.Convert(__workflow_measureCode);
                if (__workflow_reportingUnitTypeCode != null)
                    callPayload.Queries["reporting_unit_type_code"] = ExpressionConverter.Convert(__workflow_reportingUnitTypeCode);
                if (__workflow_reportingUnitCode != null)
                    callPayload.Queries["reporting_unit_code"] = ExpressionConverter.Convert(__workflow_reportingUnitCode);
                callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_startDate != null)
                    callPayload.Queries["start_date"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(__workflow_endDate);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetFlatFormattedDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetFlatDataResponse, ApiConnectionActionConfiguration> GetFlatData(Expression<Func<string>> measureCategoryCode, Expression<Func<int>> skip, Expression<Func<int>> top, Expression<Func<string>> measureCode = null, Expression<Func<string>> reportingUnitTypeCode = null, Expression<Func<string>> reportingUnitCode = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null)
        {
            var __workflow_measureCategoryCode = WorkflowExpression.Compile(measureCategoryCode, nameof(measureCategoryCode), required: true);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: true);
            var __workflow_measureCode = WorkflowExpression.Compile(measureCode, nameof(measureCode), required: false);
            var __workflow_reportingUnitTypeCode = WorkflowExpression.Compile(reportingUnitTypeCode, nameof(reportingUnitTypeCode), required: false);
            var __workflow_reportingUnitCode = WorkflowExpression.Compile(reportingUnitCode, nameof(reportingUnitCode), required: false);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            return new DeferredBodyAction<GetFlatDataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/flat-data-extract/{0}", __workflow_measureCategoryCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_measureCode != null)
                    callPayload.Queries["measure_code"] = ExpressionConverter.Convert(__workflow_measureCode);
                if (__workflow_reportingUnitTypeCode != null)
                    callPayload.Queries["reporting_unit_type_code"] = ExpressionConverter.Convert(__workflow_reportingUnitTypeCode);
                if (__workflow_reportingUnitCode != null)
                    callPayload.Queries["reporting_unit_code"] = ExpressionConverter.Convert(__workflow_reportingUnitCode);
                callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_startDate != null)
                    callPayload.Queries["start_date"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(__workflow_endDate);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetFlatDataResponse>(callPayload);
            });
        }
    }

    public class MyhospitalsbyaihwipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetCaveatsResponse
    {
        [JsonProperty("result")]
        public CaveatModel[] Result { get; set; }

        [JsonProperty("version_information")]
        public VersionInformation VersionInformation { get; set; }
    }

    public class CaveatModel
    {
        [JsonProperty("caveat_code")]
        public string CaveatCode { get; set; }

        [JsonProperty("caveat_display_value")]
        public string CaveatDisplayValue { get; set; }

        [JsonProperty("caveat_footnote")]
        public string CaveatFootnote { get; set; }

        [JsonProperty("caveat_name")]
        public string CaveatName { get; set; }
    }

    public class VersionInformation
    {
        [JsonProperty("api_version")]
        public string ApiVersion { get; set; }

        [JsonProperty("data_version")]
        public int DataVersion { get; set; }

        [JsonProperty("date_uploaded")]
        public string DateUploaded { get; set; }

        [JsonProperty("requested_time_stamp")]
        public string RequestedTimeStamp { get; set; }
    }

    public class GetCaveatResponse
    {
        [JsonProperty("result")]
        public CaveatModel Result { get; set; }

        [JsonProperty("version_information")]
        public VersionInformation VersionInformation { get; set; }
    }

    public class GetDataSetsResponse
    {
        [JsonProperty("result")]
        public DatasetModel[] Result { get; set; }
    }

    public class DatasetModel
    {
        [JsonProperty("caveats")]
        public CaveatModel[] Caveats { get; set; }

        [JsonProperty("data_set_id")]
        public int DataSetId { get; set; }

        [JsonProperty("data_set_name")]
        public string DataSetName { get; set; }

        [JsonProperty("meta_tags")]
        public MetaTagModel[] MetaTags { get; set; }

        [JsonProperty("reported_measure_summary")]
        public ReportedMeasureSummaryModel ReportedMeasureSummary { get; set; }

        [JsonProperty("reporting_end_date")]
        public string ReportingEndDate { get; set; }

        [JsonProperty("reporting_start_date")]
        public string ReportingStartDate { get; set; }
    }

    public class MetaTagModel
    {
        [JsonProperty("meta_tag_code")]
        public string MetaTagCode { get; set; }

        [JsonProperty("meta_tag_name")]
        public string MetaTagName { get; set; }

        [JsonProperty("meta_tag_type")]
        public MetaTagTypeModel MetaTagType { get; set; }
    }

    public class MetaTagTypeModel
    {
        [JsonProperty("meta_tag_type_code")]
        public string MetaTagTypeCode { get; set; }

        [JsonProperty("meta_tag_type_name")]
        public string MetaTagTypeName { get; set; }
    }

    public class ReportedMeasureSummaryModel
    {
        [JsonProperty("measure_summary")]
        public MeasureSummaryModel MeasureSummary { get; set; }

        [JsonProperty("reported_measure_code")]
        public string ReportedMeasureCode { get; set; }

        [JsonProperty("reported_measure_name")]
        public string ReportedMeasureName { get; set; }
    }

    public class MeasureSummaryModel
    {
        [JsonProperty("measure_code")]
        public string MeasureCode { get; set; }

        [JsonProperty("measure_name")]
        public string MeasureName { get; set; }
    }

    public class GetDataSetResponse
    {
        [JsonProperty("result")]
        public DatasetModel Result { get; set; }

        [JsonProperty("version_information")]
        public VersionInformation VersionInformation { get; set; }
    }

    public class GetDatasetItemsResponse
    {
        [JsonProperty("result")]
        public DataItemModel[] Result { get; set; }

        [JsonProperty("version_information")]
        public VersionInformation VersionInformation { get; set; }
    }

    public class DataItemModel
    {
        [JsonProperty("caveats")]
        public CaveatModel[] Caveats { get; set; }

        [JsonProperty("data_set_id")]
        public int DataSetId { get; set; }

        [JsonProperty("group_number")]
        public int GroupNumber { get; set; }

        [JsonProperty("lower_value")]
        public JToken LowerValue { get; set; }

        [JsonProperty("measure_code")]
        public string MeasureCode { get; set; }

        [JsonProperty("peer_group_summary")]
        public ReportingUnitSummaryModel PeerGroupSummary { get; set; }

        [JsonProperty("proxy_reporting_unit_summary")]
        public ReportingUnitSummaryModel ProxyReportingUnitSummary { get; set; }

        [JsonProperty("reported_measure_code")]
        public string ReportedMeasureCode { get; set; }

        [JsonProperty("reporting_unit_summary")]
        public ReportingUnitSummaryModel ReportingUnitSummary { get; set; }

        [JsonProperty("suppressions")]
        public SuppressionModel[] Suppressions { get; set; }

        [JsonProperty("upper_value")]
        public double UpperValue { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ReportingUnitSummaryModel
    {
        [JsonProperty("reporting_unit_code")]
        public string ReportingUnitCode { get; set; }

        [JsonProperty("reporting_unit_name")]
        public string ReportingUnitName { get; set; }

        [JsonProperty("reporting_unit_type")]
        public ReportingUnitType ReportingUnitType { get; set; }
    }

    public class ReportingUnitType
    {
        [JsonProperty("reporting_unit_type_code")]
        public string ReportingUnitTypeCode { get; set; }

        [JsonProperty("reporting_unit_type_name")]
        public string ReportingUnitTypeName { get; set; }
    }

    public class SuppressionModel
    {
        [JsonProperty("suppression_code")]
        public string SuppressionCode { get; set; }

        [JsonProperty("suppression_display_value")]
        public string SuppressionDisplayValue { get; set; }

        [JsonProperty("suppression_footnote")]
        public string SuppressionFootnote { get; set; }

        [JsonProperty("suppression_name")]
        public string SuppressionName { get; set; }
    }

    public class GetMeasureCategoriesResponse
    {
        [JsonProperty("result")]
        public MeasureCategoryModel[] Result { get; set; }

        [JsonProperty("version_information")]
        public VersionInformation VersionInformation { get; set; }
    }

    public class MeasureCategoryModel
    {
        [JsonProperty("measure_category_code")]
        public string MeasureCategoryCode { get; set; }

        [JsonProperty("measure_category_name")]
        public string MeasureCategoryName { get; set; }
    }

    public class GetSingleMeasureCategoryResponse
    {
        [JsonProperty("result")]
        public MeasureCategoryModel Result { get; set; }

        [JsonProperty("version_information")]
        public VersionInformation VersionInformation { get; set; }
    }

    public class GetSingleMeasureCategoryMeasuresResponse
    {
        [JsonProperty("result")]
        public MeasureModel[] Result { get; set; }

        [JsonProperty("version_information")]
        public VersionInformation VersionInformation { get; set; }
    }

    public class MeasureModel
    {
        [JsonProperty("measure_categories")]
        public MeasureCategoryModel[] MeasureCategories { get; set; }

        [JsonProperty("measure_code")]
        public string MeasureCode { get; set; }

        [JsonProperty("measure_name")]
        public string MeasureName { get; set; }

        [JsonProperty("meta_tags")]
        public MetaTagModel[] MetaTags { get; set; }

        [JsonProperty("units")]
        public UnitsModel Units { get; set; }
    }

    public class UnitsModel
    {
        [JsonProperty("decimal_places")]
        public int DecimalPlaces { get; set; }

        [JsonProperty("units_are_prefix")]
        public bool UnitsArePrefix { get; set; }

        [JsonProperty("units_display")]
        public string UnitsDisplay { get; set; }

        [JsonProperty("units_name")]
        public string UnitsName { get; set; }
    }

    public class GetReportedMeasureCategoriesResponse
    {
        [JsonProperty("result")]
        public ReportedMeasureCategoryModel[] Result { get; set; }

        [JsonProperty("version_information")]
        public VersionInformation VersionInformation { get; set; }
    }

    public class ReportedMeasureCategoryModel
    {
        [JsonProperty("reported_measure_category_code")]
        public string ReportedMeasureCategoryCode { get; set; }

        [JsonProperty("reported_measure_category_name")]
        public string ReportedMeasureCategoryName { get; set; }

        [JsonProperty("reported_measure_category_type")]
        public ReportedMeasureCategoryTypeModel ReportedMeasureCategoryType { get; set; }
    }

    public class ReportedMeasureCategoryTypeModel
    {
        [JsonProperty("reported_measure_category_type_code")]
        public string ReportedMeasureCategoryTypeCode { get; set; }

        [JsonProperty("reported_measure_category_type_name")]
        public string ReportedMeasureCategoryTypeName { get; set; }
    }

    public class GetReportedMeasureCategoryResponse
    {
        [JsonProperty("result")]
        public ReportedMeasureCategoryModel Result { get; set; }

        [JsonProperty("version_information")]
        public VersionInformation VersionInformation { get; set; }
    }

    public class GetReportedMeasureCategoryMeasuresResponse
    {
        [JsonProperty("result")]
        public ReportedMeasureModel[] Result { get; set; }

        [JsonProperty("version_information")]
        public VersionInformation VersionInformation { get; set; }
    }

    public class ReportedMeasureModel
    {
        [JsonProperty("measure")]
        public MeasureModel Measure { get; set; }

        [JsonProperty("meta_tags")]
        public MetaTagModel[] MetaTags { get; set; }

        [JsonProperty("reported_measure_categories")]
        public ReportedMeasureCategoryModel[] ReportedMeasureCategories { get; set; }

        [JsonProperty("reported_measure_code")]
        public string ReportedMeasureCode { get; set; }

        [JsonProperty("reported_measure_name")]
        public string ReportedMeasureName { get; set; }
    }

    public class GetReportedMeasuresResponse
    {
        [JsonProperty("result")]
        public ReportedMeasureModel[] Result { get; set; }

        [JsonProperty("version_information")]
        public VersionInformation VersionInformation { get; set; }
    }

    public class GetSingleReportedMeasureDataItemsResponse
    {
        [JsonProperty("result")]
        public DataItemModel[] Result { get; set; }

        [JsonProperty("version_information")]
        public VersionInformation VersionInformation { get; set; }
    }

    public class GetReportingUnitsResponse
    {
        [JsonProperty("result")]
        public ReportingUnitModel[] Result { get; set; }

        [JsonProperty("version_information")]
        public VersionInformation VersionInformation { get; set; }
    }

    public class ReportingUnitModel
    {
        [JsonProperty("alternative_names")]
        public JToken[] AlternativeNames { get; set; }

        [JsonProperty("closed")]
        public bool Closed { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("mapped_reporting_units")]
        public MappedReportingUnitModelItem[] MappedReportingUnits { get; set; }

        [JsonProperty("meta_tags")]
        public MetaTagModel[] MetaTags { get; set; }

        [JsonProperty("reporting_unit_code")]
        public string ReportingUnitCode { get; set; }

        [JsonProperty("reporting_unit_name")]
        public string ReportingUnitName { get; set; }

        [JsonProperty("reporting_unit_type")]
        public ReportingUnitType ReportingUnitType { get; set; }
    }

    public class MappedReportingUnitModelItem
    {
        [JsonProperty("mapped_reporting_unit")]
        public ReportingUnitSummaryModel MappedReportingUnit { get; set; }

        [JsonProperty("map_type")]
        public MappedReportingUnitModelItemMapTypeType MapType { get; set; }
    }

    public class MappedReportingUnitModelItemMapTypeType
    {
        [JsonProperty("mapped_reporting_unit_code")]
        public string MappedReportingUnitCode { get; set; }

        [JsonProperty("mapped_reporting_unit_name")]
        public string MappedReportingUnitName { get; set; }
    }

    public class GetSingleReportingUnitResponse
    {
        [JsonProperty("result")]
        public ReportingUnitModel Result { get; set; }

        [JsonProperty("version_information")]
        public VersionInformation VersionInformation { get; set; }
    }

    public class GetSingleReportingUnitDataitemsResponse
    {
        [JsonProperty("result")]
        public DataItemModel[] Result { get; set; }

        [JsonProperty("version_information")]
        public VersionInformation VersionInformation { get; set; }
    }

    public class GetSingleReportingUnitMeasuresResponse
    {
        [JsonProperty("result")]
        public MeasureSummaryModel[] Result { get; set; }

        [JsonProperty("version_information")]
        public VersionInformation VersionInformation { get; set; }
    }

    public class GetSingleReportingUnitBricksResponse
    {
        [JsonProperty("result")]
        public string[] Result { get; set; }

        [JsonProperty("version_information")]
        public VersionInformation VersionInformation { get; set; }
    }

    public class GetReportingUnitTypesResponse
    {
        [JsonProperty("result")]
        public ReportingUnitType[] Result { get; set; }

        [JsonProperty("version_information")]
        public VersionInformation VersionInformation { get; set; }
    }

    public class GetSingleReportingUnitTypeResponse
    {
        [JsonProperty("result")]
        public ReportingUnitType Result { get; set; }

        [JsonProperty("version_information")]
        public VersionInformation VersionInformation { get; set; }
    }

    public class GetSingleReportUnitTypeBricksResponse
    {
        [JsonProperty("result")]
        public JToken Result { get; set; }

        [JsonProperty("version_information")]
        public VersionInformation VersionInformation { get; set; }
    }

    public class GetMeasuresResponse
    {
        [JsonProperty("result")]
        public GetMeasuresResponseResultTypeItem[] Result { get; set; }

        [JsonProperty("version_information")]
        public VersionInformation VersionInformation { get; set; }
    }

    public class GetMeasuresResponseResultTypeItem
    {
        [JsonProperty("measure_categories")]
        public MeasureCategoryModel[] MeasureCategories { get; set; }

        [JsonProperty("measure_code")]
        public string MeasureCode { get; set; }

        [JsonProperty("measure_name")]
        public string MeasureName { get; set; }

        [JsonProperty("meta_tags")]
        public MetaTagModel[] MetaTags { get; set; }

        [JsonProperty("units")]
        public UnitsModel Units { get; set; }
    }

    public class GetMeasureResponse
    {
        [JsonProperty("result")]
        public GetMeasureResponseResultType Result { get; set; }

        [JsonProperty("version_information")]
        public VersionInformation VersionInformation { get; set; }
    }

    public class GetMeasureResponseResultType
    {
        [JsonProperty("measure_categories")]
        public MeasureCategoryModel[] MeasureCategories { get; set; }

        [JsonProperty("measure_code")]
        public string MeasureCode { get; set; }

        [JsonProperty("measure_name")]
        public string MeasureName { get; set; }

        [JsonProperty("meta_tags")]
        public MetaTagModel[] MetaTags { get; set; }

        [JsonProperty("units")]
        public UnitsModel Units { get; set; }
    }

    public class GetReportingUnitsForMeasureResponse
    {
        [JsonProperty("result")]
        public ReportingUnitSummaryModel[] Result { get; set; }

        [JsonProperty("version_information")]
        public VersionInformation VersionInformation { get; set; }
    }

    public class GetMeasureDataItemsResponse
    {
        [JsonProperty("result")]
        public DataItemModel[] Result { get; set; }

        [JsonProperty("version_information")]
        public VersionInformation VersionInformation { get; set; }
    }

    public class GetMeasureDownloadsResponse
    {
        [JsonProperty("result")]
        public JToken Result { get; set; }

        [JsonProperty("results")]
        public GetMeasureDownloadsResponseResultsTypeItem[] Results { get; set; }
    }

    public class GetMeasureDownloadsResponseResultsTypeItem
    {
        public string Name { get; set; }
        public DatasheetConfigurationSummaryModel[] Details { get; set; }
    }

    public class DatasheetConfigurationSummaryModel
    {
        [JsonProperty("datasheet_code")]
        public string DatasheetCode { get; set; }

        [JsonProperty("datasheet_description")]
        public string DatasheetDescription { get; set; }

        [JsonProperty("datasheet_type")]
        public string DatasheetType { get; set; }
    }

    public class GetReportingUnitDatasheetCodesResponse
    {
        [JsonProperty("result")]
        public JToken Result { get; set; }

        [JsonProperty("version_information")]
        public VersionInformation VersionInformation { get; set; }
    }

    public class GetFlatFormattedDataResponse
    {
        [JsonProperty("result")]
        public PaginatedFormattedDataExtractModel Result { get; set; }

        [JsonProperty("version_information")]
        public VersionInformation VersionInformation { get; set; }
    }

    public class PaginatedFormattedDataExtractModel
    {
        [JsonProperty("data")]
        public FormattedDataExtractModel[] Data { get; set; }

        [JsonProperty("pagination")]
        public DataExtractPagination Pagination { get; set; }
    }

    public class FormattedDataExtractModel
    {
        [JsonProperty("caveat")]
        public string Caveat { get; set; }

        [JsonProperty("caveat_codes")]
        public string CaveatCodes { get; set; }

        [JsonProperty("caveat_footnotes")]
        public string CaveatFootnotes { get; set; }

        [JsonProperty("data_set_caveat")]
        public string DataSetCaveat { get; set; }

        [JsonProperty("data_set_caveat_codes")]
        public string DataSetCaveatCodes { get; set; }

        [JsonProperty("data_set_caveat_footnotes")]
        public string DataSetCaveatFootnotes { get; set; }

        [JsonProperty("data_period")]
        public string DataPeriod { get; set; }

        [JsonProperty("data_period_type")]
        public string DataPeriodType { get; set; }

        [JsonProperty("data_set_id")]
        public int DataSetId { get; set; }

        [JsonProperty("data_set_meta_tag_codes")]
        public string DataSetMetaTagCodes { get; set; }

        [JsonProperty("data_set_meta_tags")]
        public string DataSetMetaTags { get; set; }

        [JsonProperty("data_set_meta_tags_with_type")]
        public string DataSetMetaTagsWithType { get; set; }

        [JsonProperty("formatted_peer_value")]
        public string FormattedPeerValue { get; set; }

        [JsonProperty("formatted_value")]
        public string FormattedValue { get; set; }

        [JsonProperty("group_number")]
        public string GroupNumber { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("mapped_local_hospital_network")]
        public string MappedLocalHospitalNetwork { get; set; }

        [JsonProperty("mapped_primary_health_network")]
        public string MappedPrimaryHealthNetwork { get; set; }

        [JsonProperty("mapped_state")]
        public string MappedState { get; set; }

        [JsonProperty("measure_category_code")]
        public string MeasureCategoryCode { get; set; }

        [JsonProperty("measure_category_name")]
        public string MeasureCategoryName { get; set; }

        [JsonProperty("measure_code")]
        public string MeasureCode { get; set; }

        [JsonProperty("measure_meta_tag_codes")]
        public string MeasureMetaTagCodes { get; set; }

        [JsonProperty("measure_meta_tags")]
        public string MeasureMetaTags { get; set; }

        [JsonProperty("measure_meta_tags_with_type")]
        public string MeasureMetaTagsWithType { get; set; }

        [JsonProperty("measure_name")]
        public string MeasureName { get; set; }

        [JsonProperty("peer_group_code")]
        public string PeerGroupCode { get; set; }

        [JsonProperty("peer_group_name")]
        public string PeerGroupName { get; set; }

        [JsonProperty("proxy_reporting_unit_name")]
        public string ProxyReportingUnitName { get; set; }

        [JsonProperty("raw_lower_value")]
        public JToken RawLowerValue { get; set; }

        [JsonProperty("raw_peer_value")]
        public JToken RawPeerValue { get; set; }

        [JsonProperty("raw_upper_value")]
        public JToken RawUpperValue { get; set; }

        [JsonProperty("raw_value")]
        public double RawValue { get; set; }

        [JsonProperty("reported_measure_category_code")]
        public string ReportedMeasureCategoryCode { get; set; }

        [JsonProperty("reported_measure_category_name")]
        public string ReportedMeasureCategoryName { get; set; }

        [JsonProperty("reported_measure_category_three_code")]
        public string ReportedMeasureCategoryThreeCode { get; set; }

        [JsonProperty("reported_measure_category_three_name")]
        public string ReportedMeasureCategoryThreeName { get; set; }

        [JsonProperty("reported_measure_category_two_code")]
        public string ReportedMeasureCategoryTwoCode { get; set; }

        [JsonProperty("reported_measure_category_two_name")]
        public string ReportedMeasureCategoryTwoName { get; set; }

        [JsonProperty("reported_measure_category_type_code")]
        public string ReportedMeasureCategoryTypeCode { get; set; }

        [JsonProperty("reported_measure_category_type_name")]
        public string ReportedMeasureCategoryTypeName { get; set; }

        [JsonProperty("reported_measure_category_three_type_code")]
        public string ReportedMeasureCategoryThreeTypeCode { get; set; }

        [JsonProperty("reported_measure_category_three_type_name")]
        public string ReportedMeasureCategoryThreeTypeName { get; set; }

        [JsonProperty("reported_measure_category_two_type_code")]
        public string ReportedMeasureCategoryTwoTypeCode { get; set; }

        [JsonProperty("reported_measure_category_two_type_name")]
        public string ReportedMeasureCategoryTwoTypeName { get; set; }

        [JsonProperty("reported_measure_code")]
        public string ReportedMeasureCode { get; set; }

        [JsonProperty("reported_measure_meta_tag_codes")]
        public string ReportedMeasureMetaTagCodes { get; set; }

        [JsonProperty("reported_measure_meta_tags")]
        public string ReportedMeasureMetaTags { get; set; }

        [JsonProperty("reported_measure_meta_tags_with_type")]
        public string ReportedMeasureMetaTagsWithType { get; set; }

        [JsonProperty("reported_measure_name")]
        public string ReportedMeasureName { get; set; }

        [JsonProperty("reporting_end_date")]
        public string ReportingEndDate { get; set; }

        [JsonProperty("reporting_start_date")]
        public string ReportingStartDate { get; set; }

        [JsonProperty("reporting_unit_code")]
        public string ReportingUnitCode { get; set; }

        [JsonProperty("reporting_unit_meta_tag_codes")]
        public string ReportingUnitMetaTagCodes { get; set; }

        [JsonProperty("reporting_unit_meta_tags")]
        public string ReportingUnitMetaTags { get; set; }

        [JsonProperty("reporting_unit_meta_tags_with_type")]
        public string ReportingUnitMetaTagsWithType { get; set; }

        [JsonProperty("reporting_unit_name")]
        public string ReportingUnitName { get; set; }

        [JsonProperty("reporting_unit_type_code")]
        public string ReportingUnitTypeCode { get; set; }

        [JsonProperty("reporting_unit_type_name")]
        public string ReportingUnitTypeName { get; set; }

        [JsonProperty("suppression")]
        public string Suppression { get; set; }

        [JsonProperty("suppression_codes")]
        public string SuppressionCodes { get; set; }
    }

    public class DataExtractPagination
    {
        [JsonProperty("results_returned")]
        public int ResultsReturned { get; set; }

        [JsonProperty("starting_result_index")]
        public int StartingResultIndex { get; set; }

        [JsonProperty("total_results_available")]
        public int TotalResultsAvailable { get; set; }
    }

    public class GetFlatDataResponse
    {
        [JsonProperty("result")]
        public PaginatedFormattedDataExtractModel Result { get; set; }

        [JsonProperty("version_information")]
        public VersionInformation VersionInformation { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Myhospitalsbyaihwip;

    public partial class WorkflowManagedActions
    {
        public MyhospitalsbyaihwipActions Myhospitalsbyaihwip(string connectionId) => new MyhospitalsbyaihwipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MyhospitalsbyaihwipTriggers Myhospitalsbyaihwip(string connectionId) => new MyhospitalsbyaihwipTriggers(connectionId);
    }
}