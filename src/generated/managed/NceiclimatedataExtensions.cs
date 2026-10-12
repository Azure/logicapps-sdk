//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nceiclimatedata
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NceiclimatedataActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nceiclimatedata")]
        [WorkflowExpressionFactory(nameof(__BuildDatasetsGet))]
        public IBodyWorkflowAction<DatasetsGetResponse> DatasetsGet([WorkflowExpression] Func<string> datatypeid = null, [WorkflowExpression] Func<string> locationid = null, [WorkflowExpression] Func<string> stationid = null, [WorkflowExpression] Func<string> startdate = null, [WorkflowExpression] Func<string> enddate = null, [WorkflowExpression] Func<sortfieldInput> sortfield = null, [WorkflowExpression] Func<sortorderInput> sortorder = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DatasetsGetResponse> __BuildDatasetsGet(WorkflowExpression<string> datatypeid = null, WorkflowExpression<string> locationid = null, WorkflowExpression<string> stationid = null, WorkflowExpression<string> startdate = null, WorkflowExpression<string> enddate = null, WorkflowExpression<sortfieldInput> sortfield = null, WorkflowExpression<sortorderInput> sortorder = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null)
        {
            WorkflowExpression.Validate(datatypeid, nameof(datatypeid), required: false);
            WorkflowExpression.Validate(locationid, nameof(locationid), required: false);
            WorkflowExpression.Validate(stationid, nameof(stationid), required: false);
            WorkflowExpression.Validate(startdate, nameof(startdate), required: false);
            WorkflowExpression.Validate(enddate, nameof(enddate), required: false);
            WorkflowExpression.Validate(sortfield, nameof(sortfield), required: false);
            WorkflowExpression.Validate(sortorder, nameof(sortorder), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<DatasetsGetResponse>(() =>
            {
                var apiCallPath = "/cdo-web/api/v2/datasets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (datatypeid != null)
                    callPayload.Queries["datatypeid"] = ExpressionConverter.Convert(datatypeid);
                if (locationid != null)
                    callPayload.Queries["locationid"] = ExpressionConverter.Convert(locationid);
                if (stationid != null)
                    callPayload.Queries["stationid"] = ExpressionConverter.Convert(stationid);
                if (startdate != null)
                    callPayload.Queries["startdate"] = ExpressionConverter.Convert(startdate);
                if (enddate != null)
                    callPayload.Queries["enddate"] = ExpressionConverter.Convert(enddate);
                if (sortfield != null)
                    callPayload.Queries["sortfield"] = ExpressionConverter.Convert(sortfield);
                if (sortorder != null)
                    callPayload.Queries["sortorder"] = ExpressionConverter.Convert(sortorder);
                callPayload.Queries["limit"] = Convert.ToString(25);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<DatasetsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nceiclimatedata")]
        [WorkflowExpressionFactory(nameof(__BuildDatasetGet))]
        public IBodyWorkflowAction<DatasetGetResponse> DatasetGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DatasetGetResponse> __BuildDatasetGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<DatasetGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/cdo-web/api/v2/datasets/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DatasetGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nceiclimatedata")]
        [WorkflowExpressionFactory(nameof(__BuildCatagoriesGet))]
        public IBodyWorkflowAction<CatagoriesGetResponse> CatagoriesGet([WorkflowExpression] Func<string> datatsetid = null, [WorkflowExpression] Func<string> locationid = null, [WorkflowExpression] Func<string> stationid = null, [WorkflowExpression] Func<string> startdate = null, [WorkflowExpression] Func<string> enddate = null, [WorkflowExpression] Func<sortfieldInput> sortfield = null, [WorkflowExpression] Func<sortorderInput> sortorder = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CatagoriesGetResponse> __BuildCatagoriesGet(WorkflowExpression<string> datatsetid = null, WorkflowExpression<string> locationid = null, WorkflowExpression<string> stationid = null, WorkflowExpression<string> startdate = null, WorkflowExpression<string> enddate = null, WorkflowExpression<sortfieldInput> sortfield = null, WorkflowExpression<sortorderInput> sortorder = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null)
        {
            WorkflowExpression.Validate(datatsetid, nameof(datatsetid), required: false);
            WorkflowExpression.Validate(locationid, nameof(locationid), required: false);
            WorkflowExpression.Validate(stationid, nameof(stationid), required: false);
            WorkflowExpression.Validate(startdate, nameof(startdate), required: false);
            WorkflowExpression.Validate(enddate, nameof(enddate), required: false);
            WorkflowExpression.Validate(sortfield, nameof(sortfield), required: false);
            WorkflowExpression.Validate(sortorder, nameof(sortorder), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<CatagoriesGetResponse>(() =>
            {
                var apiCallPath = "/cdo-web/api/v2/datacategories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (datatsetid != null)
                    callPayload.Queries["datatsetid"] = ExpressionConverter.Convert(datatsetid);
                if (locationid != null)
                    callPayload.Queries["locationid"] = ExpressionConverter.Convert(locationid);
                if (stationid != null)
                    callPayload.Queries["stationid"] = ExpressionConverter.Convert(stationid);
                if (startdate != null)
                    callPayload.Queries["startdate"] = ExpressionConverter.Convert(startdate);
                if (enddate != null)
                    callPayload.Queries["enddate"] = ExpressionConverter.Convert(enddate);
                if (sortfield != null)
                    callPayload.Queries["sortfield"] = ExpressionConverter.Convert(sortfield);
                if (sortorder != null)
                    callPayload.Queries["sortorder"] = ExpressionConverter.Convert(sortorder);
                callPayload.Queries["limit"] = Convert.ToString(25);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<CatagoriesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nceiclimatedata")]
        [WorkflowExpressionFactory(nameof(__BuildCategoryGet))]
        public IBodyWorkflowAction<CategoryGetResponse> CategoryGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CategoryGetResponse> __BuildCategoryGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<CategoryGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/cdo-web/api/v2/datacategories/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CategoryGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nceiclimatedata")]
        [WorkflowExpressionFactory(nameof(__BuildTypesGet))]
        public IBodyWorkflowAction<TypesGetResponse> TypesGet([WorkflowExpression] Func<string> datatsetid = null, [WorkflowExpression] Func<string> locationid = null, [WorkflowExpression] Func<string> stationid = null, [WorkflowExpression] Func<string> datacategoryid = null, [WorkflowExpression] Func<string> startdate = null, [WorkflowExpression] Func<string> enddate = null, [WorkflowExpression] Func<sortfieldInput> sortfield = null, [WorkflowExpression] Func<sortorderInput> sortorder = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TypesGetResponse> __BuildTypesGet(WorkflowExpression<string> datatsetid = null, WorkflowExpression<string> locationid = null, WorkflowExpression<string> stationid = null, WorkflowExpression<string> datacategoryid = null, WorkflowExpression<string> startdate = null, WorkflowExpression<string> enddate = null, WorkflowExpression<sortfieldInput> sortfield = null, WorkflowExpression<sortorderInput> sortorder = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null)
        {
            WorkflowExpression.Validate(datatsetid, nameof(datatsetid), required: false);
            WorkflowExpression.Validate(locationid, nameof(locationid), required: false);
            WorkflowExpression.Validate(stationid, nameof(stationid), required: false);
            WorkflowExpression.Validate(datacategoryid, nameof(datacategoryid), required: false);
            WorkflowExpression.Validate(startdate, nameof(startdate), required: false);
            WorkflowExpression.Validate(enddate, nameof(enddate), required: false);
            WorkflowExpression.Validate(sortfield, nameof(sortfield), required: false);
            WorkflowExpression.Validate(sortorder, nameof(sortorder), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<TypesGetResponse>(() =>
            {
                var apiCallPath = "/cdo-web/api/v2/datatypes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (datatsetid != null)
                    callPayload.Queries["datatsetid"] = ExpressionConverter.Convert(datatsetid);
                if (locationid != null)
                    callPayload.Queries["locationid"] = ExpressionConverter.Convert(locationid);
                if (stationid != null)
                    callPayload.Queries["stationid"] = ExpressionConverter.Convert(stationid);
                if (datacategoryid != null)
                    callPayload.Queries["datacategoryid"] = ExpressionConverter.Convert(datacategoryid);
                if (startdate != null)
                    callPayload.Queries["startdate"] = ExpressionConverter.Convert(startdate);
                if (enddate != null)
                    callPayload.Queries["enddate"] = ExpressionConverter.Convert(enddate);
                if (sortfield != null)
                    callPayload.Queries["sortfield"] = ExpressionConverter.Convert(sortfield);
                if (sortorder != null)
                    callPayload.Queries["sortorder"] = ExpressionConverter.Convert(sortorder);
                callPayload.Queries["limit"] = Convert.ToString(25);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<TypesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nceiclimatedata")]
        [WorkflowExpressionFactory(nameof(__BuildTypeGet))]
        public IBodyWorkflowAction<TypeGetResponse> TypeGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TypeGetResponse> __BuildTypeGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<TypeGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/cdo-web/api/v2/datatypes/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TypeGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nceiclimatedata")]
        [WorkflowExpressionFactory(nameof(__BuildLocationCategoriesGet))]
        public IBodyWorkflowAction<LocationCategoriesGetResponse> LocationCategoriesGet([WorkflowExpression] Func<string> datasetid = null, [WorkflowExpression] Func<string> startdate = null, [WorkflowExpression] Func<string> enddate = null, [WorkflowExpression] Func<sortfieldInput> sortfield = null, [WorkflowExpression] Func<sortorderInput> sortorder = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LocationCategoriesGetResponse> __BuildLocationCategoriesGet(WorkflowExpression<string> datasetid = null, WorkflowExpression<string> startdate = null, WorkflowExpression<string> enddate = null, WorkflowExpression<sortfieldInput> sortfield = null, WorkflowExpression<sortorderInput> sortorder = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null)
        {
            WorkflowExpression.Validate(datasetid, nameof(datasetid), required: false);
            WorkflowExpression.Validate(startdate, nameof(startdate), required: false);
            WorkflowExpression.Validate(enddate, nameof(enddate), required: false);
            WorkflowExpression.Validate(sortfield, nameof(sortfield), required: false);
            WorkflowExpression.Validate(sortorder, nameof(sortorder), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<LocationCategoriesGetResponse>(() =>
            {
                var apiCallPath = "/cdo-web/api/v2/locationcategories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (datasetid != null)
                    callPayload.Queries["datasetid"] = ExpressionConverter.Convert(datasetid);
                if (startdate != null)
                    callPayload.Queries["startdate"] = ExpressionConverter.Convert(startdate);
                if (enddate != null)
                    callPayload.Queries["enddate"] = ExpressionConverter.Convert(enddate);
                if (sortfield != null)
                    callPayload.Queries["sortfield"] = ExpressionConverter.Convert(sortfield);
                if (sortorder != null)
                    callPayload.Queries["sortorder"] = ExpressionConverter.Convert(sortorder);
                callPayload.Queries["limit"] = Convert.ToString(25);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<LocationCategoriesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nceiclimatedata")]
        [WorkflowExpressionFactory(nameof(__BuildLocationCategoryGet))]
        public IBodyWorkflowAction<LocationCategoryGetResponse> LocationCategoryGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LocationCategoryGetResponse> __BuildLocationCategoryGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<LocationCategoryGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/cdo-web/api/v2/locationcategories/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LocationCategoryGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nceiclimatedata")]
        [WorkflowExpressionFactory(nameof(__BuildLocationsGet))]
        public IBodyWorkflowAction<LocationsGetResponse> LocationsGet([WorkflowExpression] Func<string> datatypeid = null, [WorkflowExpression] Func<string> locationcategoryid = null, [WorkflowExpression] Func<string> datacategoryid = null, [WorkflowExpression] Func<string> startdate = null, [WorkflowExpression] Func<string> enddate = null, [WorkflowExpression] Func<sortfieldInput> sortfield = null, [WorkflowExpression] Func<sortorderInput> sortorder = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LocationsGetResponse> __BuildLocationsGet(WorkflowExpression<string> datatypeid = null, WorkflowExpression<string> locationcategoryid = null, WorkflowExpression<string> datacategoryid = null, WorkflowExpression<string> startdate = null, WorkflowExpression<string> enddate = null, WorkflowExpression<sortfieldInput> sortfield = null, WorkflowExpression<sortorderInput> sortorder = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null)
        {
            WorkflowExpression.Validate(datatypeid, nameof(datatypeid), required: false);
            WorkflowExpression.Validate(locationcategoryid, nameof(locationcategoryid), required: false);
            WorkflowExpression.Validate(datacategoryid, nameof(datacategoryid), required: false);
            WorkflowExpression.Validate(startdate, nameof(startdate), required: false);
            WorkflowExpression.Validate(enddate, nameof(enddate), required: false);
            WorkflowExpression.Validate(sortfield, nameof(sortfield), required: false);
            WorkflowExpression.Validate(sortorder, nameof(sortorder), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<LocationsGetResponse>(() =>
            {
                var apiCallPath = "/cdo-web/api/v2/locations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (datatypeid != null)
                    callPayload.Queries["datatypeid"] = ExpressionConverter.Convert(datatypeid);
                if (locationcategoryid != null)
                    callPayload.Queries["locationcategoryid"] = ExpressionConverter.Convert(locationcategoryid);
                if (datacategoryid != null)
                    callPayload.Queries["datacategoryid"] = ExpressionConverter.Convert(datacategoryid);
                if (startdate != null)
                    callPayload.Queries["startdate"] = ExpressionConverter.Convert(startdate);
                if (enddate != null)
                    callPayload.Queries["enddate"] = ExpressionConverter.Convert(enddate);
                if (sortfield != null)
                    callPayload.Queries["sortfield"] = ExpressionConverter.Convert(sortfield);
                if (sortorder != null)
                    callPayload.Queries["sortorder"] = ExpressionConverter.Convert(sortorder);
                callPayload.Queries["limit"] = Convert.ToString(25);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<LocationsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nceiclimatedata")]
        [WorkflowExpressionFactory(nameof(__BuildLocationGet))]
        public IBodyWorkflowAction<LocationGetResponse> LocationGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LocationGetResponse> __BuildLocationGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<LocationGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/cdo-web/api/v2/locations/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LocationGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nceiclimatedata")]
        [WorkflowExpressionFactory(nameof(__BuildStationsGet))]
        public IBodyWorkflowAction<StationsGetResponse> StationsGet([WorkflowExpression] Func<string> datasetid = null, [WorkflowExpression] Func<string> locationid = null, [WorkflowExpression] Func<string> datacategoryid = null, [WorkflowExpression] Func<string> datatypeid = null, [WorkflowExpression] Func<string> extent = null, [WorkflowExpression] Func<string> startdate = null, [WorkflowExpression] Func<string> enddate = null, [WorkflowExpression] Func<sortfieldInput> sortfield = null, [WorkflowExpression] Func<sortorderInput> sortorder = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StationsGetResponse> __BuildStationsGet(WorkflowExpression<string> datasetid = null, WorkflowExpression<string> locationid = null, WorkflowExpression<string> datacategoryid = null, WorkflowExpression<string> datatypeid = null, WorkflowExpression<string> extent = null, WorkflowExpression<string> startdate = null, WorkflowExpression<string> enddate = null, WorkflowExpression<sortfieldInput> sortfield = null, WorkflowExpression<sortorderInput> sortorder = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null)
        {
            WorkflowExpression.Validate(datasetid, nameof(datasetid), required: false);
            WorkflowExpression.Validate(locationid, nameof(locationid), required: false);
            WorkflowExpression.Validate(datacategoryid, nameof(datacategoryid), required: false);
            WorkflowExpression.Validate(datatypeid, nameof(datatypeid), required: false);
            WorkflowExpression.Validate(extent, nameof(extent), required: false);
            WorkflowExpression.Validate(startdate, nameof(startdate), required: false);
            WorkflowExpression.Validate(enddate, nameof(enddate), required: false);
            WorkflowExpression.Validate(sortfield, nameof(sortfield), required: false);
            WorkflowExpression.Validate(sortorder, nameof(sortorder), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<StationsGetResponse>(() =>
            {
                var apiCallPath = "/cdo-web/api/v2/stations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (datasetid != null)
                    callPayload.Queries["datasetid"] = ExpressionConverter.Convert(datasetid);
                if (locationid != null)
                    callPayload.Queries["locationid"] = ExpressionConverter.Convert(locationid);
                if (datacategoryid != null)
                    callPayload.Queries["datacategoryid"] = ExpressionConverter.Convert(datacategoryid);
                if (datatypeid != null)
                    callPayload.Queries["datatypeid"] = ExpressionConverter.Convert(datatypeid);
                if (extent != null)
                    callPayload.Queries["extent"] = ExpressionConverter.Convert(extent);
                if (startdate != null)
                    callPayload.Queries["startdate"] = ExpressionConverter.Convert(startdate);
                if (enddate != null)
                    callPayload.Queries["enddate"] = ExpressionConverter.Convert(enddate);
                if (sortfield != null)
                    callPayload.Queries["sortfield"] = ExpressionConverter.Convert(sortfield);
                if (sortorder != null)
                    callPayload.Queries["sortorder"] = ExpressionConverter.Convert(sortorder);
                callPayload.Queries["limit"] = Convert.ToString(25);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<StationsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nceiclimatedata")]
        [WorkflowExpressionFactory(nameof(__BuildStationGet))]
        public IBodyWorkflowAction<StationGetResponse> StationGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StationGetResponse> __BuildStationGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<StationGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/cdo-web/api/v2/stations/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<StationGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nceiclimatedata")]
        [WorkflowExpressionFactory(nameof(__BuildDataGet))]
        public IBodyWorkflowAction<DataGetResponse> DataGet([WorkflowExpression] Func<string> datasetid, [WorkflowExpression] Func<string> startdate, [WorkflowExpression] Func<string> enddate, [WorkflowExpression] Func<string> datatypeid = null, [WorkflowExpression] Func<string> locationid = null, [WorkflowExpression] Func<string> stationid = null, [WorkflowExpression] Func<unitsInput> units = null, [WorkflowExpression] Func<sortfieldInput> sortfield = null, [WorkflowExpression] Func<sortorderInput> sortorder = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<bool> includemetadata = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DataGetResponse> __BuildDataGet(WorkflowExpression<string> datasetid, WorkflowExpression<string> startdate, WorkflowExpression<string> enddate, WorkflowExpression<string> datatypeid = null, WorkflowExpression<string> locationid = null, WorkflowExpression<string> stationid = null, WorkflowExpression<unitsInput> units = null, WorkflowExpression<sortfieldInput> sortfield = null, WorkflowExpression<sortorderInput> sortorder = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null, WorkflowExpression<bool> includemetadata = null)
        {
            WorkflowExpression.Validate(datasetid, nameof(datasetid), required: true);
            WorkflowExpression.Validate(startdate, nameof(startdate), required: true);
            WorkflowExpression.Validate(enddate, nameof(enddate), required: true);
            WorkflowExpression.Validate(datatypeid, nameof(datatypeid), required: false);
            WorkflowExpression.Validate(locationid, nameof(locationid), required: false);
            WorkflowExpression.Validate(stationid, nameof(stationid), required: false);
            WorkflowExpression.Validate(units, nameof(units), required: false);
            WorkflowExpression.Validate(sortfield, nameof(sortfield), required: false);
            WorkflowExpression.Validate(sortorder, nameof(sortorder), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(includemetadata, nameof(includemetadata), required: false);
            return new DeferredBodyAction<DataGetResponse>(() =>
            {
                var apiCallPath = "/cdo-web/api/v2/data";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["datasetid"] = ExpressionConverter.Convert(datasetid);
                if (datatypeid != null)
                    callPayload.Queries["datatypeid"] = ExpressionConverter.Convert(datatypeid);
                if (locationid != null)
                    callPayload.Queries["locationid"] = ExpressionConverter.Convert(locationid);
                if (stationid != null)
                    callPayload.Queries["stationid"] = ExpressionConverter.Convert(stationid);
                callPayload.Queries["startdate"] = ExpressionConverter.Convert(startdate);
                callPayload.Queries["enddate"] = ExpressionConverter.Convert(enddate);
                if (units != null)
                    callPayload.Queries["units"] = ExpressionConverter.Convert(units);
                if (sortfield != null)
                    callPayload.Queries["sortfield"] = ExpressionConverter.Convert(sortfield);
                if (sortorder != null)
                    callPayload.Queries["sortorder"] = ExpressionConverter.Convert(sortorder);
                callPayload.Queries["limit"] = Convert.ToString(25);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                callPayload.Queries["includemetadata"] = Convert.ToString(true);
                if (includemetadata != null)
                    callPayload.Queries["includemetadata"] = ExpressionConverter.Convert(includemetadata);
                return new ApiConnectionAction<DataGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nceiclimatedata")]
        [WorkflowExpressionFactory(nameof(__BuildDatasetsSearchGet))]
        public IBodyWorkflowAction<DatasetsSearchGetResponse> DatasetsSearchGet([WorkflowExpression] Func<string> dataset = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> boundingBox = null, [WorkflowExpression] Func<string> keywords = null, [WorkflowExpression] Func<string> text = null, [WorkflowExpression] Func<string> dataTypes = null, [WorkflowExpression] Func<string> stations = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<bool> available = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DatasetsSearchGetResponse> __BuildDatasetsSearchGet(WorkflowExpression<string> dataset = null, WorkflowExpression<string> startDate = null, WorkflowExpression<string> endDate = null, WorkflowExpression<string> boundingBox = null, WorkflowExpression<string> keywords = null, WorkflowExpression<string> text = null, WorkflowExpression<string> dataTypes = null, WorkflowExpression<string> stations = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null, WorkflowExpression<bool> available = null)
        {
            WorkflowExpression.Validate(dataset, nameof(dataset), required: false);
            WorkflowExpression.Validate(startDate, nameof(startDate), required: false);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: false);
            WorkflowExpression.Validate(boundingBox, nameof(boundingBox), required: false);
            WorkflowExpression.Validate(keywords, nameof(keywords), required: false);
            WorkflowExpression.Validate(text, nameof(text), required: false);
            WorkflowExpression.Validate(dataTypes, nameof(dataTypes), required: false);
            WorkflowExpression.Validate(stations, nameof(stations), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(available, nameof(available), required: false);
            return new DeferredBodyAction<DatasetsSearchGetResponse>(() =>
            {
                var apiCallPath = "/access/services/search/v1/data";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (dataset != null)
                    callPayload.Queries["dataset"] = ExpressionConverter.Convert(dataset);
                if (startDate != null)
                    callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
                if (boundingBox != null)
                    callPayload.Queries["boundingBox"] = ExpressionConverter.Convert(boundingBox);
                if (keywords != null)
                    callPayload.Queries["keywords"] = ExpressionConverter.Convert(keywords);
                if (text != null)
                    callPayload.Queries["text"] = ExpressionConverter.Convert(text);
                if (dataTypes != null)
                    callPayload.Queries["dataTypes"] = ExpressionConverter.Convert(dataTypes);
                if (stations != null)
                    callPayload.Queries["stations"] = ExpressionConverter.Convert(stations);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (available != null)
                    callPayload.Queries["available"] = ExpressionConverter.Convert(available);
                return new ApiConnectionAction<DatasetsSearchGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nceiclimatedata")]
        [WorkflowExpressionFactory(nameof(__BuildStationHistoricalGet))]
        public IBodyWorkflowAction<StationHistoricalGetResponse> StationHistoricalGet([WorkflowExpression] Func<string> stationid, [WorkflowExpression] Func<string> date = null, [WorkflowExpression] Func<string> begindate = null, [WorkflowExpression] Func<string> enddate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StationHistoricalGetResponse> __BuildStationHistoricalGet(WorkflowExpression<string> stationid, WorkflowExpression<string> date = null, WorkflowExpression<string> begindate = null, WorkflowExpression<string> enddate = null)
        {
            WorkflowExpression.Validate(stationid, nameof(stationid), required: true);
            WorkflowExpression.Validate(date, nameof(date), required: false);
            WorkflowExpression.Validate(begindate, nameof(begindate), required: false);
            WorkflowExpression.Validate(enddate, nameof(enddate), required: false);
            return new DeferredBodyAction<StationHistoricalGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/access/homr/services/station/{0}", ExpressionConverter.ConvertWithUrlEncoding(stationid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["date"] = Convert.ToString("all");
                if (date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(date);
                if (begindate != null)
                    callPayload.Queries["begindate"] = ExpressionConverter.Convert(begindate);
                if (enddate != null)
                    callPayload.Queries["enddate"] = ExpressionConverter.Convert(enddate);
                return new ApiConnectionAction<StationHistoricalGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nceiclimatedata")]
        [WorkflowExpressionFactory(nameof(__BuildStationHistoricSearchGet))]
        public IBodyWorkflowAction<StationHistoricSearchGetResponse> StationHistoricSearchGet([WorkflowExpression] Func<string> qid = null, [WorkflowExpression] Func<string> qidMod = null, [WorkflowExpression] Func<string> state = null, [WorkflowExpression] Func<string> county = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> nameMod = null, [WorkflowExpression] Func<string> platform = null, [WorkflowExpression] Func<string> date = null, [WorkflowExpression] Func<string> begindate = null, [WorkflowExpression] Func<string> enddate = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<bool> current = null, [WorkflowExpression] Func<string> headersOnly = null, [WorkflowExpression] Func<bool> phrData = null, [WorkflowExpression] Func<bool> definitions = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StationHistoricSearchGetResponse> __BuildStationHistoricSearchGet(WorkflowExpression<string> qid = null, WorkflowExpression<string> qidMod = null, WorkflowExpression<string> state = null, WorkflowExpression<string> county = null, WorkflowExpression<string> country = null, WorkflowExpression<string> name = null, WorkflowExpression<string> nameMod = null, WorkflowExpression<string> platform = null, WorkflowExpression<string> date = null, WorkflowExpression<string> begindate = null, WorkflowExpression<string> enddate = null, WorkflowExpression<statusInput> status = null, WorkflowExpression<bool> current = null, WorkflowExpression<string> headersOnly = null, WorkflowExpression<bool> phrData = null, WorkflowExpression<bool> definitions = null)
        {
            WorkflowExpression.Validate(qid, nameof(qid), required: false);
            WorkflowExpression.Validate(qidMod, nameof(qidMod), required: false);
            WorkflowExpression.Validate(state, nameof(state), required: false);
            WorkflowExpression.Validate(county, nameof(county), required: false);
            WorkflowExpression.Validate(country, nameof(country), required: false);
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(nameMod, nameof(nameMod), required: false);
            WorkflowExpression.Validate(platform, nameof(platform), required: false);
            WorkflowExpression.Validate(date, nameof(date), required: false);
            WorkflowExpression.Validate(begindate, nameof(begindate), required: false);
            WorkflowExpression.Validate(enddate, nameof(enddate), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            WorkflowExpression.Validate(current, nameof(current), required: false);
            WorkflowExpression.Validate(headersOnly, nameof(headersOnly), required: false);
            WorkflowExpression.Validate(phrData, nameof(phrData), required: false);
            WorkflowExpression.Validate(definitions, nameof(definitions), required: false);
            return new DeferredBodyAction<StationHistoricSearchGetResponse>(() =>
            {
                var apiCallPath = "/access/homr/services/station/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (qid != null)
                    callPayload.Queries["qid"] = ExpressionConverter.Convert(qid);
                if (qidMod != null)
                    callPayload.Queries["qidMod"] = ExpressionConverter.Convert(qidMod);
                if (state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(state);
                if (county != null)
                    callPayload.Queries["county"] = ExpressionConverter.Convert(county);
                if (country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(country);
                if (name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                if (nameMod != null)
                    callPayload.Queries["nameMod"] = ExpressionConverter.Convert(nameMod);
                if (platform != null)
                    callPayload.Queries["platform"] = ExpressionConverter.Convert(platform);
                if (date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(date);
                if (begindate != null)
                    callPayload.Queries["begindate"] = ExpressionConverter.Convert(begindate);
                if (enddate != null)
                    callPayload.Queries["enddate"] = ExpressionConverter.Convert(enddate);
                if (status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(status);
                if (current != null)
                    callPayload.Queries["current"] = ExpressionConverter.Convert(current);
                if (headersOnly != null)
                    callPayload.Queries["headersOnly"] = ExpressionConverter.Convert(headersOnly);
                if (phrData != null)
                    callPayload.Queries["phrData"] = ExpressionConverter.Convert(phrData);
                if (definitions != null)
                    callPayload.Queries["definitions"] = ExpressionConverter.Convert(definitions);
                return new ApiConnectionAction<StationHistoricSearchGetResponse>(callPayload);
            });
        }
    }

    public class NceiclimatedataTriggers([ConnectionName] string connectionId)
    {
    }

    public class DatasetsGetResponse
    {
        [JsonProperty("metadata")]
        public DatasetsGetResponseMetadataType Metadata { get; set; }

        [JsonProperty("results")]
        public DatasetsGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class DatasetsGetResponseMetadataType
    {
        [JsonProperty("resultset")]
        public DatasetsGetResponseMetadataTypeResultsetType Resultset { get; set; }
    }

    public class DatasetsGetResponseMetadataTypeResultsetType
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }
    }

    public class DatasetsGetResponseResultsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("mindate")]
        public string Mindate { get; set; }

        [JsonProperty("maxdate")]
        public string Maxdate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("datacoverage")]
        public int Datacoverage { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortfieldInput
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "mindate")]
        Mindate,
        [EnumMember(Value = "maxdate")]
        Maxdate,
        [EnumMember(Value = "datacoverage")]
        Datacoverage
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortorderInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class DatasetGetResponse
    {
        [JsonProperty("mindate")]
        public string Mindate { get; set; }

        [JsonProperty("maxdate")]
        public string Maxdate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("datacoverage")]
        public int Datacoverage { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CatagoriesGetResponse
    {
        [JsonProperty("metadata")]
        public CatagoriesGetResponseMetadataType Metadata { get; set; }

        [JsonProperty("results")]
        public CatagoriesGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class CatagoriesGetResponseMetadataType
    {
        [JsonProperty("resultset")]
        public CatagoriesGetResponseMetadataTypeResultsetType Resultset { get; set; }
    }

    public class CatagoriesGetResponseMetadataTypeResultsetType
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }
    }

    public class CatagoriesGetResponseResultsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CategoryGetResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class TypesGetResponse
    {
        [JsonProperty("metadata")]
        public TypesGetResponseMetadataType Metadata { get; set; }

        [JsonProperty("results")]
        public TypesGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class TypesGetResponseMetadataType
    {
        [JsonProperty("resultset")]
        public TypesGetResponseMetadataTypeResultsetType Resultset { get; set; }
    }

    public class TypesGetResponseMetadataTypeResultsetType
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }
    }

    public class TypesGetResponseResultsTypeItem
    {
        [JsonProperty("mindate")]
        public string Mindate { get; set; }

        [JsonProperty("maxdate")]
        public string Maxdate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("datacoverage")]
        public int Datacoverage { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class TypeGetResponse
    {
        [JsonProperty("mindate")]
        public string Mindate { get; set; }

        [JsonProperty("maxdate")]
        public string Maxdate { get; set; }

        [JsonProperty("datacoverage")]
        public int Datacoverage { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class LocationCategoriesGetResponse
    {
        [JsonProperty("metadata")]
        public LocationCategoriesGetResponseMetadataType Metadata { get; set; }

        [JsonProperty("results")]
        public LocationCategoriesGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class LocationCategoriesGetResponseMetadataType
    {
        [JsonProperty("resultset")]
        public LocationCategoriesGetResponseMetadataTypeResultsetType Resultset { get; set; }
    }

    public class LocationCategoriesGetResponseMetadataTypeResultsetType
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }
    }

    public class LocationCategoriesGetResponseResultsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class LocationCategoryGetResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class LocationsGetResponse
    {
        [JsonProperty("metadata")]
        public LocationsGetResponseMetadataType Metadata { get; set; }

        [JsonProperty("results")]
        public LocationsGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class LocationsGetResponseMetadataType
    {
        [JsonProperty("resultset")]
        public LocationsGetResponseMetadataTypeResultsetType Resultset { get; set; }
    }

    public class LocationsGetResponseMetadataTypeResultsetType
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }
    }

    public class LocationsGetResponseResultsTypeItem
    {
        [JsonProperty("mindate")]
        public string Mindate { get; set; }

        [JsonProperty("maxdate")]
        public string Maxdate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("datacoverage")]
        public int Datacoverage { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class LocationGetResponse
    {
        [JsonProperty("mindate")]
        public string Mindate { get; set; }

        [JsonProperty("maxdate")]
        public string Maxdate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("datacoverage")]
        public int Datacoverage { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class StationsGetResponse
    {
        [JsonProperty("metadata")]
        public StationsGetResponseMetadataType Metadata { get; set; }

        [JsonProperty("results")]
        public StationsGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class StationsGetResponseMetadataType
    {
        [JsonProperty("resultset")]
        public StationsGetResponseMetadataTypeResultsetType Resultset { get; set; }
    }

    public class StationsGetResponseMetadataTypeResultsetType
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }
    }

    public class StationsGetResponseResultsTypeItem
    {
        [JsonProperty("elevation")]
        public double Elevation { get; set; }

        [JsonProperty("mindate")]
        public string Mindate { get; set; }

        [JsonProperty("maxdate")]
        public string Maxdate { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("datacoverage")]
        public int Datacoverage { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("elevationUnit")]
        public string ElevationUnit { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }

    public class StationGetResponse
    {
        [JsonProperty("elevation")]
        public double Elevation { get; set; }

        [JsonProperty("mindate")]
        public string Mindate { get; set; }

        [JsonProperty("maxdate")]
        public string Maxdate { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("datacoverage")]
        public int Datacoverage { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("elevationUnit")]
        public string ElevationUnit { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }

    public class DataGetResponse
    {
        [JsonProperty("metadata")]
        public DataGetResponseMetadataType Metadata { get; set; }

        [JsonProperty("results")]
        public DataGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class DataGetResponseMetadataType
    {
        [JsonProperty("resultset")]
        public DataGetResponseMetadataTypeResultsetType Resultset { get; set; }
    }

    public class DataGetResponseMetadataTypeResultsetType
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }
    }

    public class DataGetResponseResultsTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("datatype")]
        public string Datatype { get; set; }

        [JsonProperty("station")]
        public string Station { get; set; }

        [JsonProperty("attributes")]
        public string Attributes { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum unitsInput
    {
        [EnumMember(Value = "standard")]
        Standard,
        [EnumMember(Value = "metric")]
        Metric
    }

    public class DatasetsSearchGetResponse
    {
        [JsonProperty("dataTypes")]
        public DatasetsSearchGetResponseDataTypesType DataTypes { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("bounds")]
        public DatasetsSearchGetResponseBoundsType Bounds { get; set; }

        [JsonProperty("totalFileSize")]
        public int TotalFileSize { get; set; }

        [JsonProperty("stations")]
        public DatasetsSearchGetResponseStationsType Stations { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("results")]
        public DatasetsSearchGetResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }
    }

    public class DatasetsSearchGetResponseDataTypesType
    {
        [JsonProperty("docCountError")]
        public int DocCountError { get; set; }

        [JsonProperty("buckets")]
        public DatasetsSearchGetResponseDataTypesTypeBucketsTypeItem[] Buckets { get; set; }

        [JsonProperty("sumOfOtherDocCounts")]
        public int SumOfOtherDocCounts { get; set; }
    }

    public class DatasetsSearchGetResponseDataTypesTypeBucketsTypeItem
    {
        [JsonProperty("docCount")]
        public int DocCount { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }

    public class DatasetsSearchGetResponseBoundsType
    {
        [JsonProperty("bottomRight")]
        public DatasetsSearchGetResponseBoundsTypeBottomRightType BottomRight { get; set; }

        [JsonProperty("topLeft")]
        public DatasetsSearchGetResponseBoundsTypeTopLeftType TopLeft { get; set; }
    }

    public class DatasetsSearchGetResponseBoundsTypeBottomRightType
    {
        [JsonProperty("lat")]
        public int Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("geohash")]
        public string Geohash { get; set; }

        [JsonProperty("fragment")]
        public bool Fragment { get; set; }
    }

    public class DatasetsSearchGetResponseBoundsTypeTopLeftType
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("geohash")]
        public string Geohash { get; set; }

        [JsonProperty("fragment")]
        public bool Fragment { get; set; }
    }

    public class DatasetsSearchGetResponseStationsType
    {
        [JsonProperty("docCountError")]
        public int DocCountError { get; set; }

        [JsonProperty("buckets")]
        public DatasetsSearchGetResponseStationsTypeBucketsTypeItem[] Buckets { get; set; }

        [JsonProperty("sumOfOtherDocCounts")]
        public int SumOfOtherDocCounts { get; set; }
    }

    public class DatasetsSearchGetResponseStationsTypeBucketsTypeItem
    {
        [JsonProperty("docCount")]
        public int DocCount { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }

    public class DatasetsSearchGetResponseResultsTypeItem
    {
        [JsonProperty("tar")]
        public string Tar { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("boundingPoints")]
        public DatasetsSearchGetResponseResultsTypeItemBoundingPointsTypeItem[] BoundingPoints { get; set; }

        [JsonProperty("filePath")]
        public string FilePath { get; set; }

        [JsonProperty("stations")]
        public DatasetsSearchGetResponseResultsTypeItemStationsTypeItem[] Stations { get; set; }

        [JsonProperty("dataTypes")]
        public DatasetsSearchGetResponseResultsTypeItemDataTypesTypeItem[] DataTypes { get; set; }

        [JsonProperty("fileSize")]
        public int FileSize { get; set; }

        [JsonProperty("centroid")]
        public DatasetsSearchGetResponseResultsTypeItemCentroidType Centroid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location")]
        public DatasetsSearchGetResponseResultsTypeItemLocationType Location { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("dataTypesCount")]
        public int DataTypesCount { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }
    }

    public class DatasetsSearchGetResponseResultsTypeItemBoundingPointsTypeItem
    {
        [JsonProperty("point")]
        public double[] Point { get; set; }
    }

    public class DatasetsSearchGetResponseResultsTypeItemStationsTypeItem
    {
        [JsonProperty("dataTypes")]
        public DatasetsSearchGetResponseResultsTypeItemStationsTypeItemDataTypesTypeItem[] DataTypes { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class DatasetsSearchGetResponseResultsTypeItemStationsTypeItemDataTypesTypeItem
    {
        [JsonProperty("coverage")]
        public double Coverage { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("dateRange")]
        public DatasetsSearchGetResponseResultsTypeItemStationsTypeItemDataTypesTypeItemDateRangeType DateRange { get; set; }

        [JsonProperty("searchWeight")]
        public int SearchWeight { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }
    }

    public class DatasetsSearchGetResponseResultsTypeItemStationsTypeItemDataTypesTypeItemDateRangeType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class DatasetsSearchGetResponseResultsTypeItemDataTypesTypeItem
    {
        [JsonProperty("dateRange")]
        public DatasetsSearchGetResponseResultsTypeItemDataTypesTypeItemDateRangeType DateRange { get; set; }

        [JsonProperty("searchWeight")]
        public int SearchWeight { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class DatasetsSearchGetResponseResultsTypeItemDataTypesTypeItemDateRangeType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class DatasetsSearchGetResponseResultsTypeItemCentroidType
    {
        [JsonProperty("point")]
        public double[] Point { get; set; }
    }

    public class DatasetsSearchGetResponseResultsTypeItemLocationType
    {
        [JsonProperty("coordinates")]
        public double[] Coordinates { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class StationHistoricalGetResponse
    {
        [JsonProperty("stationCollection")]
        public StationHistoricalGetResponseStationCollectionType StationCollection { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionType
    {
        [JsonProperty("definitions")]
        public StationHistoricalGetResponseStationCollectionTypeDefinitionsTypeItem[] Definitions { get; set; }

        [JsonProperty("stations")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItem[] Stations { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeDefinitionsTypeItem
    {
        [JsonProperty("defType")]
        public string DefType { get; set; }

        [JsonProperty("abbr")]
        public string Abbr { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("cssaName")]
        public string CssaName { get; set; }

        [JsonProperty("ghcndName")]
        public string GhcndName { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItem
    {
        [JsonProperty("ncdcStnId")]
        public string NcdcStnId { get; set; }

        [JsonProperty("header")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemHeaderType Header { get; set; }

        [JsonProperty("names")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemNamesTypeItem[] Names { get; set; }

        [JsonProperty("identifiers")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemIdentifiersTypeItem[] Identifiers { get; set; }

        [JsonProperty("location")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationType Location { get; set; }

        [JsonProperty("platforms")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemPlatformsTypeItem[] Platforms { get; set; }

        [JsonProperty("relocations")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemRelocationsTypeItem[] Relocations { get; set; }

        [JsonProperty("remarks")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemRemarksTypeItem[] Remarks { get; set; }

        [JsonProperty("updates")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemUpdatesTypeItem[] Updates { get; set; }

        [JsonProperty("elements")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemElementsTypeItem[] Elements { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemHeaderType
    {
        [JsonProperty("preferredName")]
        public string PreferredName { get; set; }

        [JsonProperty("latitude_dec")]
        public string LatitudeDec { get; set; }

        [JsonProperty("longitude_dec")]
        public string LongitudeDec { get; set; }

        [JsonProperty("precision")]
        public string Precision { get; set; }

        [JsonProperty("por")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemHeaderTypePorType Por { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemHeaderTypePorType
    {
        [JsonProperty("beginDate")]
        public string BeginDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemNamesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nameType")]
        public string NameType { get; set; }

        [JsonProperty("date")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemNamesTypeItemDateType Date { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemNamesTypeItemDateType
    {
        [JsonProperty("beginDate")]
        public string BeginDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemIdentifiersTypeItem
    {
        [JsonProperty("idType")]
        public string IdType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemIdentifiersTypeItemDateType Date { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemIdentifiersTypeItemDateType
    {
        [JsonProperty("beginDate")]
        public string BeginDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationType
    {
        [JsonProperty("ncdcstnId")]
        public string NcdcstnId { get; set; }

        [JsonProperty("descriptions")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeDescriptionsTypeItem[] Descriptions { get; set; }

        [JsonProperty("latitudes")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeLatitudesTypeItem[] Latitudes { get; set; }

        [JsonProperty("longitudes")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeLongitudesTypeItem[] Longitudes { get; set; }

        [JsonProperty("latLonPairs")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeLatLonPairsTypeItem[] LatLonPairs { get; set; }

        [JsonProperty("elevations")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeElevationsTypeItem[] Elevations { get; set; }

        [JsonProperty("topography")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeTopographyTypeItem[] Topography { get; set; }

        [JsonProperty("obstructions")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeObstructionsTypeItem[] Obstructions { get; set; }

        [JsonProperty("geoInfo")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoType GeoInfo { get; set; }

        [JsonProperty("nwsInfo")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeNwsInfoType NwsInfo { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeDescriptionsTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("date")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeDescriptionsTypeItemDateType Date { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeDescriptionsTypeItemDateType
    {
        [JsonProperty("beginDate")]
        public string BeginDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeLatitudesTypeItem
    {
        [JsonProperty("latitude_dec")]
        public string LatitudeDec { get; set; }

        [JsonProperty("precision")]
        public string Precision { get; set; }

        [JsonProperty("date")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeLatitudesTypeItemDateType Date { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeLatitudesTypeItemDateType
    {
        [JsonProperty("beginDate")]
        public string BeginDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeLongitudesTypeItem
    {
        [JsonProperty("longitude_dec")]
        public string LongitudeDec { get; set; }

        [JsonProperty("precision")]
        public string Precision { get; set; }

        [JsonProperty("date")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeLongitudesTypeItemDateType Date { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeLongitudesTypeItemDateType
    {
        [JsonProperty("beginDate")]
        public string BeginDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeLatLonPairsTypeItem
    {
        [JsonProperty("latitude_rptd")]
        public string LatitudeRptd { get; set; }

        [JsonProperty("longitude_rptd")]
        public string LongitudeRptd { get; set; }

        [JsonProperty("latitude_dec")]
        public string LatitudeDec { get; set; }

        [JsonProperty("longitude_dec")]
        public string LongitudeDec { get; set; }

        [JsonProperty("latitude_dms")]
        public string LatitudeDms { get; set; }

        [JsonProperty("longitude_dms")]
        public string LongitudeDms { get; set; }

        [JsonProperty("precision")]
        public string Precision { get; set; }

        [JsonProperty("datum_horiz")]
        public string DatumHoriz { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("date")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeLatLonPairsTypeItemDateType Date { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeLatLonPairsTypeItemDateType
    {
        [JsonProperty("beginDate")]
        public string BeginDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeElevationsTypeItem
    {
        [JsonProperty("elevationType")]
        public string ElevationType { get; set; }

        [JsonProperty("elevationFeet")]
        public string ElevationFeet { get; set; }

        [JsonProperty("elevationMeters")]
        public string ElevationMeters { get; set; }

        [JsonProperty("date")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeElevationsTypeItemDateType Date { get; set; }

        [JsonProperty("groundElevDatum")]
        public string GroundElevDatum { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeElevationsTypeItemDateType
    {
        [JsonProperty("beginDate")]
        public string BeginDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeTopographyTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("date")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeTopographyTypeItemDateType Date { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeTopographyTypeItemDateType
    {
        [JsonProperty("beginDate")]
        public string BeginDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeObstructionsTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("date")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeObstructionsTypeItemDateType Date { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeObstructionsTypeItemDateType
    {
        [JsonProperty("beginDate")]
        public string BeginDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoType
    {
        [JsonProperty("ncdcstnId")]
        public string NcdcstnId { get; set; }

        [JsonProperty("countries")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoTypeCountriesTypeItem[] Countries { get; set; }

        [JsonProperty("stateProvinces")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoTypeStateProvincesTypeItem[] StateProvinces { get; set; }

        [JsonProperty("counties")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoTypeCountiesTypeItem[] Counties { get; set; }

        [JsonProperty("utcOffsets")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoTypeUtcOffsetsTypeItem[] UtcOffsets { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoTypeCountriesTypeItem
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("date")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoTypeCountriesTypeItemDateType Date { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoTypeCountriesTypeItemDateType
    {
        [JsonProperty("beginDate")]
        public string BeginDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoTypeStateProvincesTypeItem
    {
        [JsonProperty("stateProvince")]
        public string StateProvince { get; set; }

        [JsonProperty("date")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoTypeStateProvincesTypeItemDateType Date { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoTypeStateProvincesTypeItemDateType
    {
        [JsonProperty("beginDate")]
        public string BeginDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoTypeCountiesTypeItem
    {
        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("date")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoTypeCountiesTypeItemDateType Date { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoTypeCountiesTypeItemDateType
    {
        [JsonProperty("beginDate")]
        public string BeginDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoTypeUtcOffsetsTypeItem
    {
        [JsonProperty("utcOffset")]
        public string UtcOffset { get; set; }

        [JsonProperty("date")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoTypeUtcOffsetsTypeItemDateType Date { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoTypeUtcOffsetsTypeItemDateType
    {
        [JsonProperty("beginDate")]
        public string BeginDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeNwsInfoType
    {
        [JsonProperty("ncdcstnId")]
        public string NcdcstnId { get; set; }

        [JsonProperty("climateDivisions")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeNwsInfoTypeClimateDivisionsTypeItem[] ClimateDivisions { get; set; }

        [JsonProperty("nwsRegions")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeNwsInfoTypeNwsRegionsTypeItem[] NwsRegions { get; set; }

        [JsonProperty("nwsWfos")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeNwsInfoTypeNwsWfosTypeItem[] NwsWfos { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeNwsInfoTypeClimateDivisionsTypeItem
    {
        [JsonProperty("stateProvince")]
        public string StateProvince { get; set; }

        [JsonProperty("climateDivision")]
        public string ClimateDivision { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("date")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeNwsInfoTypeClimateDivisionsTypeItemDateType Date { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeNwsInfoTypeClimateDivisionsTypeItemDateType
    {
        [JsonProperty("beginDate")]
        public string BeginDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeNwsInfoTypeNwsRegionsTypeItem
    {
        [JsonProperty("nwsRegion")]
        public string NwsRegion { get; set; }

        [JsonProperty("date")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeNwsInfoTypeNwsRegionsTypeItemDateType Date { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeNwsInfoTypeNwsRegionsTypeItemDateType
    {
        [JsonProperty("beginDate")]
        public string BeginDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeNwsInfoTypeNwsWfosTypeItem
    {
        [JsonProperty("nwsWfo")]
        public string NwsWfo { get; set; }

        [JsonProperty("date")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeNwsInfoTypeNwsWfosTypeItemDateType Date { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemLocationTypeNwsInfoTypeNwsWfosTypeItemDateType
    {
        [JsonProperty("beginDate")]
        public string BeginDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemPlatformsTypeItem
    {
        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("date")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemPlatformsTypeItemDateType Date { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemPlatformsTypeItemDateType
    {
        [JsonProperty("beginDate")]
        public string BeginDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemRelocationsTypeItem
    {
        [JsonProperty("relocation")]
        public string Relocation { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemRemarksTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("date")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemRemarksTypeItemDateType Date { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemRemarksTypeItemDateType
    {
        [JsonProperty("beginDate")]
        public string BeginDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemUpdatesTypeItem
    {
        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }

        [JsonProperty("providedBy")]
        public string ProvidedBy { get; set; }

        [JsonProperty("updateSource")]
        public string UpdateSource { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enteredBy")]
        public string EnteredBy { get; set; }

        [JsonProperty("enteredDate")]
        public string EnteredDate { get; set; }

        [JsonProperty("modifiedBy")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("nativeId")]
        public string NativeId { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemElementsTypeItem
    {
        [JsonProperty("dataProgram")]
        public string DataProgram { get; set; }

        [JsonProperty("element")]
        public string Element { get; set; }

        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        [JsonProperty("observationTime")]
        public string ObservationTime { get; set; }

        [JsonProperty("publishedFlag")]
        public string PublishedFlag { get; set; }

        [JsonProperty("receiver")]
        public string Receiver { get; set; }

        [JsonProperty("reportingMethod")]
        public string ReportingMethod { get; set; }

        [JsonProperty("equipment")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemElementsTypeItemEquipmentType Equipment { get; set; }

        [JsonProperty("date")]
        public StationHistoricalGetResponseStationCollectionTypeStationsTypeItemElementsTypeItemDateType Date { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemElementsTypeItemEquipmentType
    {
        [JsonProperty("equipment")]
        public string Equipment { get; set; }

        [JsonProperty("equipmentMods")]
        public string EquipmentMods { get; set; }

        [JsonProperty("equipmentAzimuth")]
        public string EquipmentAzimuth { get; set; }

        [JsonProperty("equipmentDistance")]
        public string EquipmentDistance { get; set; }

        [JsonProperty("equipmentDistanceUnits")]
        public string EquipmentDistanceUnits { get; set; }
    }

    public class StationHistoricalGetResponseStationCollectionTypeStationsTypeItemElementsTypeItemDateType
    {
        [JsonProperty("beginDate")]
        public string BeginDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class StationHistoricSearchGetResponse
    {
        [JsonProperty("stationCollection")]
        public StationHistoricSearchGetResponseStationCollectionType StationCollection { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionType
    {
        [JsonProperty("definitions")]
        public StationHistoricSearchGetResponseStationCollectionTypeDefinitionsTypeItem[] Definitions { get; set; }

        [JsonProperty("stations")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItem[] Stations { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeDefinitionsTypeItem
    {
        [JsonProperty("defType")]
        public string DefType { get; set; }

        [JsonProperty("abbr")]
        public string Abbr { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("cssaName")]
        public string CssaName { get; set; }

        [JsonProperty("ghcndName")]
        public string GhcndName { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItem
    {
        [JsonProperty("ncdcStnId")]
        public string NcdcStnId { get; set; }

        [JsonProperty("header")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemHeaderType Header { get; set; }

        [JsonProperty("names")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemNamesTypeItem[] Names { get; set; }

        [JsonProperty("identifiers")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemIdentifiersTypeItem[] Identifiers { get; set; }

        [JsonProperty("location")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationType Location { get; set; }

        [JsonProperty("platforms")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemPlatformsTypeItem[] Platforms { get; set; }

        [JsonProperty("relocations")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemRelocationsTypeItem[] Relocations { get; set; }

        [JsonProperty("remarks")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemRemarksTypeItem[] Remarks { get; set; }

        [JsonProperty("updates")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemUpdatesTypeItem[] Updates { get; set; }

        [JsonProperty("elements")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemElementsTypeItem[] Elements { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemHeaderType
    {
        [JsonProperty("preferredName")]
        public string PreferredName { get; set; }

        [JsonProperty("latitude_dec")]
        public string LatitudeDec { get; set; }

        [JsonProperty("longitude_dec")]
        public string LongitudeDec { get; set; }

        [JsonProperty("precision")]
        public string Precision { get; set; }

        [JsonProperty("por")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemHeaderTypePorType Por { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemHeaderTypePorType
    {
        [JsonProperty("beginDate")]
        public string BeginDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemNamesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nameType")]
        public string NameType { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemIdentifiersTypeItem
    {
        [JsonProperty("idType")]
        public string IdType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationType
    {
        [JsonProperty("ncdcstnId")]
        public string NcdcstnId { get; set; }

        [JsonProperty("descriptions")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeDescriptionsTypeItem[] Descriptions { get; set; }

        [JsonProperty("latitudes")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeLatitudesTypeItem[] Latitudes { get; set; }

        [JsonProperty("longitudes")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeLongitudesTypeItem[] Longitudes { get; set; }

        [JsonProperty("latLonPairs")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeLatLonPairsTypeItem[] LatLonPairs { get; set; }

        [JsonProperty("elevations")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeElevationsTypeItem[] Elevations { get; set; }

        [JsonProperty("topography")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeTopographyTypeItem[] Topography { get; set; }

        [JsonProperty("obstructions")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeObstructionsTypeItem[] Obstructions { get; set; }

        [JsonProperty("geoInfo")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoType GeoInfo { get; set; }

        [JsonProperty("nwsInfo")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeNwsInfoType NwsInfo { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeDescriptionsTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeLatitudesTypeItem
    {
        [JsonProperty("latitude_dec")]
        public string LatitudeDec { get; set; }

        [JsonProperty("precision")]
        public string Precision { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeLongitudesTypeItem
    {
        [JsonProperty("longitude_dec")]
        public string LongitudeDec { get; set; }

        [JsonProperty("precision")]
        public string Precision { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeLatLonPairsTypeItem
    {
        [JsonProperty("latitude_rptd")]
        public string LatitudeRptd { get; set; }

        [JsonProperty("longitude_rptd")]
        public string LongitudeRptd { get; set; }

        [JsonProperty("latitude_dec")]
        public string LatitudeDec { get; set; }

        [JsonProperty("longitude_dec")]
        public string LongitudeDec { get; set; }

        [JsonProperty("latitude_dms")]
        public string LatitudeDms { get; set; }

        [JsonProperty("longitude_dms")]
        public string LongitudeDms { get; set; }

        [JsonProperty("precision")]
        public string Precision { get; set; }

        [JsonProperty("datum_horiz")]
        public string DatumHoriz { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeElevationsTypeItem
    {
        [JsonProperty("elevationType")]
        public string ElevationType { get; set; }

        [JsonProperty("elevationFeet")]
        public string ElevationFeet { get; set; }

        [JsonProperty("elevationMeters")]
        public string ElevationMeters { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeTopographyTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeObstructionsTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoType
    {
        [JsonProperty("ncdcstnId")]
        public string NcdcstnId { get; set; }

        [JsonProperty("countries")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoTypeCountriesTypeItem[] Countries { get; set; }

        [JsonProperty("stateProvinces")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoTypeStateProvincesTypeItem[] StateProvinces { get; set; }

        [JsonProperty("counties")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoTypeCountiesTypeItem[] Counties { get; set; }

        [JsonProperty("utcOffsets")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoTypeUtcOffsetsTypeItem[] UtcOffsets { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoTypeCountriesTypeItem
    {
        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoTypeStateProvincesTypeItem
    {
        [JsonProperty("stateProvince")]
        public string StateProvince { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoTypeCountiesTypeItem
    {
        [JsonProperty("county")]
        public string County { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeGeoInfoTypeUtcOffsetsTypeItem
    {
        [JsonProperty("utcOffset")]
        public string UtcOffset { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeNwsInfoType
    {
        [JsonProperty("ncdcstnId")]
        public string NcdcstnId { get; set; }

        [JsonProperty("climateDivisions")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeNwsInfoTypeClimateDivisionsTypeItem[] ClimateDivisions { get; set; }

        [JsonProperty("nwsRegions")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeNwsInfoTypeNwsRegionsTypeItem[] NwsRegions { get; set; }

        [JsonProperty("nwsWfos")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeNwsInfoTypeNwsWfosTypeItem[] NwsWfos { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeNwsInfoTypeClimateDivisionsTypeItem
    {
        [JsonProperty("stateProvince")]
        public string StateProvince { get; set; }

        [JsonProperty("climateDivision")]
        public string ClimateDivision { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeNwsInfoTypeNwsRegionsTypeItem
    {
        [JsonProperty("nwsRegion")]
        public string NwsRegion { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemLocationTypeNwsInfoTypeNwsWfosTypeItem
    {
        [JsonProperty("nwsWfo")]
        public string NwsWfo { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemPlatformsTypeItem
    {
        [JsonProperty("platform")]
        public string Platform { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemRelocationsTypeItem
    {
        [JsonProperty("relocation")]
        public string Relocation { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemRemarksTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemUpdatesTypeItem
    {
        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }

        [JsonProperty("providedBy")]
        public string ProvidedBy { get; set; }

        [JsonProperty("updateSource")]
        public string UpdateSource { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enteredBy")]
        public string EnteredBy { get; set; }

        [JsonProperty("enteredDate")]
        public string EnteredDate { get; set; }

        [JsonProperty("modifiedBy")]
        public string ModifiedBy { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemElementsTypeItem
    {
        [JsonProperty("dataProgram")]
        public string DataProgram { get; set; }

        [JsonProperty("element")]
        public string Element { get; set; }

        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        [JsonProperty("observationTime")]
        public string ObservationTime { get; set; }

        [JsonProperty("publishedFlag")]
        public string PublishedFlag { get; set; }

        [JsonProperty("receiver")]
        public string Receiver { get; set; }

        [JsonProperty("reportingMethod")]
        public string ReportingMethod { get; set; }

        [JsonProperty("equipment")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemElementsTypeItemEquipmentType Equipment { get; set; }

        [JsonProperty("date")]
        public StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemElementsTypeItemDateType Date { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemElementsTypeItemEquipmentType
    {
        [JsonProperty("equipment")]
        public string Equipment { get; set; }

        [JsonProperty("equipmentMods")]
        public string EquipmentMods { get; set; }

        [JsonProperty("equipmentAzimuth")]
        public string EquipmentAzimuth { get; set; }

        [JsonProperty("equipmentDistance")]
        public string EquipmentDistance { get; set; }

        [JsonProperty("equipmentDistanceUnits")]
        public string EquipmentDistanceUnits { get; set; }
    }

    public class StationHistoricSearchGetResponseStationCollectionTypeStationsTypeItemElementsTypeItemDateType
    {
        [JsonProperty("beginDate")]
        public string BeginDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum statusInput
    {
        CLOSED,
        INACTIVE
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nceiclimatedata;

    public partial class WorkflowManagedActions
    {
        public NceiclimatedataActions Nceiclimatedata(string connectionId) => new NceiclimatedataActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NceiclimatedataTriggers Nceiclimatedata(string connectionId) => new NceiclimatedataTriggers(connectionId);
    }
}