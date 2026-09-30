//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Myhospitalsbyaihwip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MyhospitalsbyaihwipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetCaveatsResponse> GetCaveats()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/caveats";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetCaveatsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetCaveatResponse> GetCaveat([WorkflowExpression] Func<string> caveatCode)
        {
            SourceExpression.Validate(caveatCode, nameof(caveatCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/caveats/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(caveatCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetCaveatResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetDataSetsResponse> GetDataSets([WorkflowExpression] Func<string> measureCode = null, [WorkflowExpression] Func<string> reportedMeasureCode = null)
        {
            SourceExpression.Validate(measureCode, nameof(measureCode), required: false);
            SourceExpression.Validate(reportedMeasureCode, nameof(reportedMeasureCode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datasets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (measureCode != null)
                    callPayload.Queries["measure_code"] = SourceExpressionConverter.ConvertO(measureCode);
                if (reportedMeasureCode != null)
                    callPayload.Queries["reported_measure_code"] = SourceExpressionConverter.ConvertO(reportedMeasureCode);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetDataSetsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetDataSetResponse> GetDataSet([WorkflowExpression] Func<int> datasetId)
        {
            SourceExpression.Validate(datasetId, nameof(datasetId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(datasetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetDataSetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetDatasetItemsResponse> GetDatasetItems([WorkflowExpression] Func<string> datasetId, [WorkflowExpression] Func<string> reportingUnitCode = null)
        {
            SourceExpression.Validate(datasetId, nameof(datasetId), required: true);
            SourceExpression.Validate(reportingUnitCode, nameof(reportingUnitCode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/data-items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(datasetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (reportingUnitCode != null)
                    callPayload.Queries["reporting_unit_code"] = SourceExpressionConverter.ConvertO(reportingUnitCode);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetDatasetItemsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetMeasureCategoriesResponse> GetMeasureCategories()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/measure-categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetMeasureCategoriesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetSingleMeasureCategoryResponse> GetSingleMeasureCategory([WorkflowExpression] Func<string> measureCategoryCode)
        {
            SourceExpression.Validate(measureCategoryCode, nameof(measureCategoryCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/measure-categories/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(measureCategoryCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetSingleMeasureCategoryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetSingleMeasureCategoryMeasuresResponse> GetSingleMeasureCategoryMeasures([WorkflowExpression] Func<string> measureCategoryCode)
        {
            SourceExpression.Validate(measureCategoryCode, nameof(measureCategoryCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/measure-categories/{0}/measures", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(measureCategoryCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetSingleMeasureCategoryMeasuresResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetReportedMeasureCategoriesResponse> GetReportedMeasureCategories()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/reported-measure-categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetReportedMeasureCategoriesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetReportedMeasureCategoryResponse> GetReportedMeasureCategory([WorkflowExpression] Func<string> reportedMeasureCategoryCode)
        {
            SourceExpression.Validate(reportedMeasureCategoryCode, nameof(reportedMeasureCategoryCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/reported-measure-categories/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportedMeasureCategoryCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetReportedMeasureCategoryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetReportedMeasureCategoryMeasuresResponse> GetReportedMeasureCategoryMeasures([WorkflowExpression] Func<string> reportedMeasureCategoryCode)
        {
            SourceExpression.Validate(reportedMeasureCategoryCode, nameof(reportedMeasureCategoryCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/reported-measure-categories/{0}/reported-measures", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportedMeasureCategoryCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetReportedMeasureCategoryMeasuresResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetReportedMeasuresResponse> GetReportedMeasures([WorkflowExpression] Func<string> measureCode = null)
        {
            SourceExpression.Validate(measureCode, nameof(measureCode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/reported-measures";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (measureCode != null)
                    callPayload.Queries["measure_code"] = SourceExpressionConverter.ConvertO(measureCode);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetReportedMeasuresResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<ReportedMeasureModel> GetSingleReportedMeasure([WorkflowExpression] Func<string> reportedMeasureCode)
        {
            SourceExpression.Validate(reportedMeasureCode, nameof(reportedMeasureCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/reported-measures/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportedMeasureCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<ReportedMeasureModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetSingleReportedMeasureDataItemsResponse> GetSingleReportedMeasureDataItems([WorkflowExpression] Func<string> reportedMeasureCode)
        {
            SourceExpression.Validate(reportedMeasureCode, nameof(reportedMeasureCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/reported-measures/{0}/data-items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportedMeasureCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetSingleReportedMeasureDataItemsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetReportingUnitsResponse> GetReportingUnits([WorkflowExpression] Func<string> reportingUnitTypeCode = null)
        {
            SourceExpression.Validate(reportingUnitTypeCode, nameof(reportingUnitTypeCode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/reporting-units";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (reportingUnitTypeCode != null)
                    callPayload.Queries["reporting_unit_type_code"] = SourceExpressionConverter.ConvertO(reportingUnitTypeCode);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetReportingUnitsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetSingleReportingUnitResponse> GetSingleReportingUnit([WorkflowExpression] Func<string> reportingUnitCode)
        {
            SourceExpression.Validate(reportingUnitCode, nameof(reportingUnitCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/reporting-units/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportingUnitCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetSingleReportingUnitResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetSingleReportingUnitDataitemsResponse> GetSingleReportingUnitDataitems([WorkflowExpression] Func<string> reportingUnitCode)
        {
            SourceExpression.Validate(reportingUnitCode, nameof(reportingUnitCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/reporting-units/{0}/data-items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportingUnitCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetSingleReportingUnitDataitemsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetSingleReportingUnitMeasuresResponse> GetSingleReportingUnitMeasures([WorkflowExpression] Func<string> reportingUnitCode)
        {
            SourceExpression.Validate(reportingUnitCode, nameof(reportingUnitCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/reporting-units/{0}/measures-available", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportingUnitCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetSingleReportingUnitMeasuresResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetSingleReportingUnitBricksResponse> GetSingleReportingUnitBricks([WorkflowExpression] Func<string> reportingUnitCode)
        {
            SourceExpression.Validate(reportingUnitCode, nameof(reportingUnitCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/reporting-units/{0}/bricks-available", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportingUnitCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetSingleReportingUnitBricksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetReportingUnitTypesResponse> GetReportingUnitTypes()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/reporting-unit-types";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetReportingUnitTypesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetSingleReportingUnitTypeResponse> GetSingleReportingUnitType([WorkflowExpression] Func<string> reportingUnitTypeCode)
        {
            SourceExpression.Validate(reportingUnitTypeCode, nameof(reportingUnitTypeCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/reporting-unit-types/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportingUnitTypeCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetSingleReportingUnitTypeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetSingleReportUnitTypeBricksResponse> GetSingleReportUnitTypeBricks([WorkflowExpression] Func<string> reportingUnitTypeCode)
        {
            SourceExpression.Validate(reportingUnitTypeCode, nameof(reportingUnitTypeCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/reporting-unit-types/{0}/bricks-available", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportingUnitTypeCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetSingleReportUnitTypeBricksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetMeasuresResponse> GetMeasures([WorkflowExpression] Func<string> measureCategoryCode = null)
        {
            SourceExpression.Validate(measureCategoryCode, nameof(measureCategoryCode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/measures";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (measureCategoryCode != null)
                    callPayload.Queries["measure_category_code"] = SourceExpressionConverter.ConvertO(measureCategoryCode);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetMeasuresResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetMeasureResponse> GetMeasure([WorkflowExpression] Func<string> measureCode)
        {
            SourceExpression.Validate(measureCode, nameof(measureCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/measures/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(measureCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetMeasureResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetReportingUnitsForMeasureResponse> GetReportingUnitsForMeasure([WorkflowExpression] Func<string> measureCode)
        {
            SourceExpression.Validate(measureCode, nameof(measureCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/measures/{0}/reporting-units-available", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(measureCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetReportingUnitsForMeasureResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetMeasureDataItemsResponse> GetMeasureDataItems([WorkflowExpression] Func<string> measureCode)
        {
            SourceExpression.Validate(measureCode, nameof(measureCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/measures/{0}/data-items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(measureCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetMeasureDataItemsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetMeasureDownloadsResponse> GetMeasureDownloads()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/measure-downloads/measure-download-codes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetMeasureDownloadsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IWorkflowAction GetMeasureDownload([WorkflowExpression] Func<string> measureDownloadCode)
        {
            SourceExpression.Validate(measureDownloadCode, nameof(measureDownloadCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/measure-downloads1/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(measureDownloadCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IWorkflowAction GetMeasureReportingunitDownload([WorkflowExpression] Func<string> measureDownloadCode)
        {
            SourceExpression.Validate(measureDownloadCode, nameof(measureDownloadCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/measure-downloads/across-reporting-units/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(measureDownloadCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetReportingUnitDatasheetCodesResponse> GetReportingUnitDatasheetCodes()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/reporting-units-downloads/datasheet-codes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetReportingUnitDatasheetCodesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IWorkflowAction GetReportingUnitMappingDownload()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/reporting-units-downloads/mappings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IWorkflowAction GetsReportingUnitDataDownload([WorkflowExpression] Func<string> datasheetCode, [WorkflowExpression] Func<string> reportingUnitCode)
        {
            SourceExpression.Validate(datasheetCode, nameof(datasheetCode), required: true);
            SourceExpression.Validate(reportingUnitCode, nameof(reportingUnitCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/reporting-units-downloads/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(datasheetCode, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportingUnitCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IWorkflowAction GetSimpleDownloads()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/simple-downloads/download-codes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IWorkflowAction GetSimpleDownload([WorkflowExpression] Func<string> downloadCode)
        {
            SourceExpression.Validate(downloadCode, nameof(downloadCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/simple-downloads1/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(downloadCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetFlatFormattedDataResponse> GetFlatFormattedData([WorkflowExpression] Func<string> measureCategoryCode, [WorkflowExpression] Func<int> skip, [WorkflowExpression] Func<int> top, [WorkflowExpression] Func<string> measureCode = null, [WorkflowExpression] Func<string> reportingUnitTypeCode = null, [WorkflowExpression] Func<string> reportingUnitCode = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null)
        {
            SourceExpression.Validate(measureCategoryCode, nameof(measureCategoryCode), required: true);
            SourceExpression.Validate(skip, nameof(skip), required: true);
            SourceExpression.Validate(top, nameof(top), required: true);
            SourceExpression.Validate(measureCode, nameof(measureCode), required: false);
            SourceExpression.Validate(reportingUnitTypeCode, nameof(reportingUnitTypeCode), required: false);
            SourceExpression.Validate(reportingUnitCode, nameof(reportingUnitCode), required: false);
            SourceExpression.Validate(startDate, nameof(startDate), required: false);
            SourceExpression.Validate(endDate, nameof(endDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/flat-formatted-data-extract/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(measureCategoryCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (measureCode != null)
                    callPayload.Queries["measure_code"] = SourceExpressionConverter.ConvertO(measureCode);
                if (reportingUnitTypeCode != null)
                    callPayload.Queries["reporting_unit_type_code"] = SourceExpressionConverter.ConvertO(reportingUnitTypeCode);
                if (reportingUnitCode != null)
                    callPayload.Queries["reporting_unit_code"] = SourceExpressionConverter.ConvertO(reportingUnitCode);
                callPayload.Queries["skip"] = SourceExpressionConverter.ConvertO(skip);
                callPayload.Queries["top"] = SourceExpressionConverter.ConvertO(top);
                if (startDate != null)
                    callPayload.Queries["start_date"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["end_date"] = SourceExpressionConverter.ConvertO(endDate);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetFlatFormattedDataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "myhospitalsbyaihwip")]
        public IBodyWorkflowAction<GetFlatDataResponse> GetFlatData([WorkflowExpression] Func<string> measureCategoryCode, [WorkflowExpression] Func<int> skip, [WorkflowExpression] Func<int> top, [WorkflowExpression] Func<string> measureCode = null, [WorkflowExpression] Func<string> reportingUnitTypeCode = null, [WorkflowExpression] Func<string> reportingUnitCode = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null)
        {
            SourceExpression.Validate(measureCategoryCode, nameof(measureCategoryCode), required: true);
            SourceExpression.Validate(skip, nameof(skip), required: true);
            SourceExpression.Validate(top, nameof(top), required: true);
            SourceExpression.Validate(measureCode, nameof(measureCode), required: false);
            SourceExpression.Validate(reportingUnitTypeCode, nameof(reportingUnitTypeCode), required: false);
            SourceExpression.Validate(reportingUnitCode, nameof(reportingUnitCode), required: false);
            SourceExpression.Validate(startDate, nameof(startDate), required: false);
            SourceExpression.Validate(endDate, nameof(endDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/flat-data-extract/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(measureCategoryCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (measureCode != null)
                    callPayload.Queries["measure_code"] = SourceExpressionConverter.ConvertO(measureCode);
                if (reportingUnitTypeCode != null)
                    callPayload.Queries["reporting_unit_type_code"] = SourceExpressionConverter.ConvertO(reportingUnitTypeCode);
                if (reportingUnitCode != null)
                    callPayload.Queries["reporting_unit_code"] = SourceExpressionConverter.ConvertO(reportingUnitCode);
                callPayload.Queries["skip"] = SourceExpressionConverter.ConvertO(skip);
                callPayload.Queries["top"] = SourceExpressionConverter.ConvertO(top);
                if (startDate != null)
                    callPayload.Queries["start_date"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["end_date"] = SourceExpressionConverter.ConvertO(endDate);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetFlatDataResponse>(BuildSourceInput);
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