//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Schooldiggerip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SchooldiggeripActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schooldiggerip")]
        [WorkflowExpressionFactory(nameof(__BuildAutocompleteGetSchools))]
        public IBodyWorkflowAction<APIAutocompleteSchoolResult> AutocompleteGetSchools([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<bool> qSearchCityStateName = null, [WorkflowExpression] Func<string> st = null, [WorkflowExpression] Func<levelInput> level = null, [WorkflowExpression] Func<double> boxLatitudeNW = null, [WorkflowExpression] Func<double> boxLongitudeNW = null, [WorkflowExpression] Func<double> boxLatitudeSE = null, [WorkflowExpression] Func<double> boxLongitudeSE = null, [WorkflowExpression] Func<int> returnCount = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schooldiggerip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<APIAutocompleteSchoolResult> __BuildAutocompleteGetSchools(WorkflowExpression<string> q, WorkflowExpression<bool> qSearchCityStateName = null, WorkflowExpression<string> st = null, WorkflowExpression<levelInput> level = null, WorkflowExpression<double> boxLatitudeNW = null, WorkflowExpression<double> boxLongitudeNW = null, WorkflowExpression<double> boxLatitudeSE = null, WorkflowExpression<double> boxLongitudeSE = null, WorkflowExpression<int> returnCount = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: true);
            WorkflowExpression.Validate(qSearchCityStateName, nameof(qSearchCityStateName), required: false);
            WorkflowExpression.Validate(st, nameof(st), required: false);
            WorkflowExpression.Validate(level, nameof(level), required: false);
            WorkflowExpression.Validate(boxLatitudeNW, nameof(boxLatitudeNW), required: false);
            WorkflowExpression.Validate(boxLongitudeNW, nameof(boxLongitudeNW), required: false);
            WorkflowExpression.Validate(boxLatitudeSE, nameof(boxLatitudeSE), required: false);
            WorkflowExpression.Validate(boxLongitudeSE, nameof(boxLongitudeSE), required: false);
            WorkflowExpression.Validate(returnCount, nameof(returnCount), required: false);
            return new DeferredBodyAction<APIAutocompleteSchoolResult>(() =>
            {
                var apiCallPath = "/v2.0/autocomplete/schools";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                if (qSearchCityStateName != null)
                    callPayload.Queries["qSearchCityStateName"] = ExpressionConverter.Convert(qSearchCityStateName);
                if (st != null)
                    callPayload.Queries["st"] = ExpressionConverter.Convert(st);
                if (level != null)
                    callPayload.Queries["level"] = ExpressionConverter.Convert(level);
                if (boxLatitudeNW != null)
                    callPayload.Queries["boxLatitudeNW"] = ExpressionConverter.Convert(boxLatitudeNW);
                if (boxLongitudeNW != null)
                    callPayload.Queries["boxLongitudeNW"] = ExpressionConverter.Convert(boxLongitudeNW);
                if (boxLatitudeSE != null)
                    callPayload.Queries["boxLatitudeSE"] = ExpressionConverter.Convert(boxLatitudeSE);
                if (boxLongitudeSE != null)
                    callPayload.Queries["boxLongitudeSE"] = ExpressionConverter.Convert(boxLongitudeSE);
                if (returnCount != null)
                    callPayload.Queries["returnCount"] = ExpressionConverter.Convert(returnCount);
                return new ApiConnectionAction<APIAutocompleteSchoolResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schooldiggerip")]
        [WorkflowExpressionFactory(nameof(__BuildDistrictsGetAllDistricts2))]
        public IBodyWorkflowAction<APIDistrictList2> DistrictsGetAllDistricts2([WorkflowExpression] Func<string> st, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<string> zip = null, [WorkflowExpression] Func<double> nearLatitude = null, [WorkflowExpression] Func<double> nearLongitude = null, [WorkflowExpression] Func<string> boundaryAddress = null, [WorkflowExpression] Func<int> distanceMiles = null, [WorkflowExpression] Func<bool> isInBoundaryOnly = null, [WorkflowExpression] Func<double> boxLatitudeNW = null, [WorkflowExpression] Func<double> boxLongitudeNW = null, [WorkflowExpression] Func<double> boxLatitudeSE = null, [WorkflowExpression] Func<double> boxLongitudeSE = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<sortByInput> sortBy = null, [WorkflowExpression] Func<bool> includeUnrankedDistrictsInRankSort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schooldiggerip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<APIDistrictList2> __BuildDistrictsGetAllDistricts2(WorkflowExpression<string> st, WorkflowExpression<string> q = null, WorkflowExpression<string> city = null, WorkflowExpression<string> zip = null, WorkflowExpression<double> nearLatitude = null, WorkflowExpression<double> nearLongitude = null, WorkflowExpression<string> boundaryAddress = null, WorkflowExpression<int> distanceMiles = null, WorkflowExpression<bool> isInBoundaryOnly = null, WorkflowExpression<double> boxLatitudeNW = null, WorkflowExpression<double> boxLongitudeNW = null, WorkflowExpression<double> boxLatitudeSE = null, WorkflowExpression<double> boxLongitudeSE = null, WorkflowExpression<int> page = null, WorkflowExpression<int> perPage = null, WorkflowExpression<sortByInput> sortBy = null, WorkflowExpression<bool> includeUnrankedDistrictsInRankSort = null)
        {
            WorkflowExpression.Validate(st, nameof(st), required: true);
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(city, nameof(city), required: false);
            WorkflowExpression.Validate(zip, nameof(zip), required: false);
            WorkflowExpression.Validate(nearLatitude, nameof(nearLatitude), required: false);
            WorkflowExpression.Validate(nearLongitude, nameof(nearLongitude), required: false);
            WorkflowExpression.Validate(boundaryAddress, nameof(boundaryAddress), required: false);
            WorkflowExpression.Validate(distanceMiles, nameof(distanceMiles), required: false);
            WorkflowExpression.Validate(isInBoundaryOnly, nameof(isInBoundaryOnly), required: false);
            WorkflowExpression.Validate(boxLatitudeNW, nameof(boxLatitudeNW), required: false);
            WorkflowExpression.Validate(boxLongitudeNW, nameof(boxLongitudeNW), required: false);
            WorkflowExpression.Validate(boxLatitudeSE, nameof(boxLatitudeSE), required: false);
            WorkflowExpression.Validate(boxLongitudeSE, nameof(boxLongitudeSE), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(perPage, nameof(perPage), required: false);
            WorkflowExpression.Validate(sortBy, nameof(sortBy), required: false);
            WorkflowExpression.Validate(includeUnrankedDistrictsInRankSort, nameof(includeUnrankedDistrictsInRankSort), required: false);
            return new DeferredBodyAction<APIDistrictList2>(() =>
            {
                var apiCallPath = "/v2.0/districts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["st"] = ExpressionConverter.Convert(st);
                if (q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                if (city != null)
                    callPayload.Queries["city"] = ExpressionConverter.Convert(city);
                if (zip != null)
                    callPayload.Queries["zip"] = ExpressionConverter.Convert(zip);
                if (nearLatitude != null)
                    callPayload.Queries["nearLatitude"] = ExpressionConverter.Convert(nearLatitude);
                if (nearLongitude != null)
                    callPayload.Queries["nearLongitude"] = ExpressionConverter.Convert(nearLongitude);
                if (boundaryAddress != null)
                    callPayload.Queries["boundaryAddress"] = ExpressionConverter.Convert(boundaryAddress);
                if (distanceMiles != null)
                    callPayload.Queries["distanceMiles"] = ExpressionConverter.Convert(distanceMiles);
                if (isInBoundaryOnly != null)
                    callPayload.Queries["isInBoundaryOnly"] = ExpressionConverter.Convert(isInBoundaryOnly);
                if (boxLatitudeNW != null)
                    callPayload.Queries["boxLatitudeNW"] = ExpressionConverter.Convert(boxLatitudeNW);
                if (boxLongitudeNW != null)
                    callPayload.Queries["boxLongitudeNW"] = ExpressionConverter.Convert(boxLongitudeNW);
                if (boxLatitudeSE != null)
                    callPayload.Queries["boxLatitudeSE"] = ExpressionConverter.Convert(boxLatitudeSE);
                if (boxLongitudeSE != null)
                    callPayload.Queries["boxLongitudeSE"] = ExpressionConverter.Convert(boxLongitudeSE);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (perPage != null)
                    callPayload.Queries["perPage"] = ExpressionConverter.Convert(perPage);
                if (sortBy != null)
                    callPayload.Queries["sortBy"] = ExpressionConverter.Convert(sortBy);
                if (includeUnrankedDistrictsInRankSort != null)
                    callPayload.Queries["includeUnrankedDistrictsInRankSort"] = ExpressionConverter.Convert(includeUnrankedDistrictsInRankSort);
                return new ApiConnectionAction<APIDistrictList2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schooldiggerip")]
        [WorkflowExpressionFactory(nameof(__BuildDistrictsGetDistrict2))]
        public IBodyWorkflowAction<APIDistrict12> DistrictsGetDistrict2([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schooldiggerip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<APIDistrict12> __BuildDistrictsGetDistrict2(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<APIDistrict12>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2.0/districts/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<APIDistrict12>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schooldiggerip")]
        [WorkflowExpressionFactory(nameof(__BuildRankingGet))]
        public IBodyWorkflowAction<APISchoolListRank2> RankingGet([WorkflowExpression] Func<string> st, [WorkflowExpression] Func<int> year = null, [WorkflowExpression] Func<levelInput> level = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schooldiggerip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<APISchoolListRank2> __BuildRankingGet(WorkflowExpression<string> st, WorkflowExpression<int> year = null, WorkflowExpression<levelInput> level = null, WorkflowExpression<int> page = null, WorkflowExpression<int> perPage = null)
        {
            WorkflowExpression.Validate(st, nameof(st), required: true);
            WorkflowExpression.Validate(year, nameof(year), required: false);
            WorkflowExpression.Validate(level, nameof(level), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<APISchoolListRank2>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2.0/rankings/schools/{0}", ExpressionConverter.ConvertWithUrlEncoding(st, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(year);
                if (level != null)
                    callPayload.Queries["level"] = ExpressionConverter.Convert(level);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (perPage != null)
                    callPayload.Queries["perPage"] = ExpressionConverter.Convert(perPage);
                return new ApiConnectionAction<APISchoolListRank2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schooldiggerip")]
        [WorkflowExpressionFactory(nameof(__BuildDistrictRanking))]
        public IBodyWorkflowAction<APIDistrictListRank2> DistrictRanking([WorkflowExpression] Func<string> st, [WorkflowExpression] Func<int> year = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schooldiggerip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<APIDistrictListRank2> __BuildDistrictRanking(WorkflowExpression<string> st, WorkflowExpression<int> year = null, WorkflowExpression<int> page = null, WorkflowExpression<int> perPage = null)
        {
            WorkflowExpression.Validate(st, nameof(st), required: true);
            WorkflowExpression.Validate(year, nameof(year), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<APIDistrictListRank2>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2.0/rankings/districts/{0}", ExpressionConverter.ConvertWithUrlEncoding(st, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(year);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (perPage != null)
                    callPayload.Queries["perPage"] = ExpressionConverter.Convert(perPage);
                return new ApiConnectionAction<APIDistrictListRank2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schooldiggerip")]
        [WorkflowExpressionFactory(nameof(__BuildSchoolsGetAllSchools20))]
        public IBodyWorkflowAction<APISchoolList2> SchoolsGetAllSchools20([WorkflowExpression] Func<string> st, [WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<bool> qSearchSchoolNameOnly = null, [WorkflowExpression] Func<string> districtID = null, [WorkflowExpression] Func<levelInput> level = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<string> zip = null, [WorkflowExpression] Func<bool> isMagnet = null, [WorkflowExpression] Func<bool> isCharter = null, [WorkflowExpression] Func<bool> isVirtual = null, [WorkflowExpression] Func<bool> isTitleI = null, [WorkflowExpression] Func<bool> isTitleISchoolwide = null, [WorkflowExpression] Func<double> nearLatitude = null, [WorkflowExpression] Func<double> nearLongitude = null, [WorkflowExpression] Func<string> nearAddress = null, [WorkflowExpression] Func<int> distanceMiles = null, [WorkflowExpression] Func<double> boundaryLatitude = null, [WorkflowExpression] Func<double> boundaryLongitude = null, [WorkflowExpression] Func<string> boundaryAddress = null, [WorkflowExpression] Func<bool> isInBoundaryOnly = null, [WorkflowExpression] Func<double> boxLatitudeNW = null, [WorkflowExpression] Func<double> boxLongitudeNW = null, [WorkflowExpression] Func<double> boxLatitudeSE = null, [WorkflowExpression] Func<double> boxLongitudeSE = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<sortByInput> sortBy = null, [WorkflowExpression] Func<bool> includeUnrankedSchoolsInRankSort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schooldiggerip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<APISchoolList2> __BuildSchoolsGetAllSchools20(WorkflowExpression<string> st, WorkflowExpression<string> q = null, WorkflowExpression<bool> qSearchSchoolNameOnly = null, WorkflowExpression<string> districtID = null, WorkflowExpression<levelInput> level = null, WorkflowExpression<string> city = null, WorkflowExpression<string> zip = null, WorkflowExpression<bool> isMagnet = null, WorkflowExpression<bool> isCharter = null, WorkflowExpression<bool> isVirtual = null, WorkflowExpression<bool> isTitleI = null, WorkflowExpression<bool> isTitleISchoolwide = null, WorkflowExpression<double> nearLatitude = null, WorkflowExpression<double> nearLongitude = null, WorkflowExpression<string> nearAddress = null, WorkflowExpression<int> distanceMiles = null, WorkflowExpression<double> boundaryLatitude = null, WorkflowExpression<double> boundaryLongitude = null, WorkflowExpression<string> boundaryAddress = null, WorkflowExpression<bool> isInBoundaryOnly = null, WorkflowExpression<double> boxLatitudeNW = null, WorkflowExpression<double> boxLongitudeNW = null, WorkflowExpression<double> boxLatitudeSE = null, WorkflowExpression<double> boxLongitudeSE = null, WorkflowExpression<int> page = null, WorkflowExpression<int> perPage = null, WorkflowExpression<sortByInput> sortBy = null, WorkflowExpression<bool> includeUnrankedSchoolsInRankSort = null)
        {
            WorkflowExpression.Validate(st, nameof(st), required: true);
            WorkflowExpression.Validate(q, nameof(q), required: false);
            WorkflowExpression.Validate(qSearchSchoolNameOnly, nameof(qSearchSchoolNameOnly), required: false);
            WorkflowExpression.Validate(districtID, nameof(districtID), required: false);
            WorkflowExpression.Validate(level, nameof(level), required: false);
            WorkflowExpression.Validate(city, nameof(city), required: false);
            WorkflowExpression.Validate(zip, nameof(zip), required: false);
            WorkflowExpression.Validate(isMagnet, nameof(isMagnet), required: false);
            WorkflowExpression.Validate(isCharter, nameof(isCharter), required: false);
            WorkflowExpression.Validate(isVirtual, nameof(isVirtual), required: false);
            WorkflowExpression.Validate(isTitleI, nameof(isTitleI), required: false);
            WorkflowExpression.Validate(isTitleISchoolwide, nameof(isTitleISchoolwide), required: false);
            WorkflowExpression.Validate(nearLatitude, nameof(nearLatitude), required: false);
            WorkflowExpression.Validate(nearLongitude, nameof(nearLongitude), required: false);
            WorkflowExpression.Validate(nearAddress, nameof(nearAddress), required: false);
            WorkflowExpression.Validate(distanceMiles, nameof(distanceMiles), required: false);
            WorkflowExpression.Validate(boundaryLatitude, nameof(boundaryLatitude), required: false);
            WorkflowExpression.Validate(boundaryLongitude, nameof(boundaryLongitude), required: false);
            WorkflowExpression.Validate(boundaryAddress, nameof(boundaryAddress), required: false);
            WorkflowExpression.Validate(isInBoundaryOnly, nameof(isInBoundaryOnly), required: false);
            WorkflowExpression.Validate(boxLatitudeNW, nameof(boxLatitudeNW), required: false);
            WorkflowExpression.Validate(boxLongitudeNW, nameof(boxLongitudeNW), required: false);
            WorkflowExpression.Validate(boxLatitudeSE, nameof(boxLatitudeSE), required: false);
            WorkflowExpression.Validate(boxLongitudeSE, nameof(boxLongitudeSE), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(perPage, nameof(perPage), required: false);
            WorkflowExpression.Validate(sortBy, nameof(sortBy), required: false);
            WorkflowExpression.Validate(includeUnrankedSchoolsInRankSort, nameof(includeUnrankedSchoolsInRankSort), required: false);
            return new DeferredBodyAction<APISchoolList2>(() =>
            {
                var apiCallPath = "/v2.0/schools";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["st"] = ExpressionConverter.Convert(st);
                if (q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                if (qSearchSchoolNameOnly != null)
                    callPayload.Queries["qSearchSchoolNameOnly"] = ExpressionConverter.Convert(qSearchSchoolNameOnly);
                if (districtID != null)
                    callPayload.Queries["districtID"] = ExpressionConverter.Convert(districtID);
                if (level != null)
                    callPayload.Queries["level"] = ExpressionConverter.Convert(level);
                if (city != null)
                    callPayload.Queries["city"] = ExpressionConverter.Convert(city);
                if (zip != null)
                    callPayload.Queries["zip"] = ExpressionConverter.Convert(zip);
                if (isMagnet != null)
                    callPayload.Queries["isMagnet"] = ExpressionConverter.Convert(isMagnet);
                if (isCharter != null)
                    callPayload.Queries["isCharter"] = ExpressionConverter.Convert(isCharter);
                if (isVirtual != null)
                    callPayload.Queries["isVirtual"] = ExpressionConverter.Convert(isVirtual);
                if (isTitleI != null)
                    callPayload.Queries["isTitleI"] = ExpressionConverter.Convert(isTitleI);
                if (isTitleISchoolwide != null)
                    callPayload.Queries["isTitleISchoolwide"] = ExpressionConverter.Convert(isTitleISchoolwide);
                if (nearLatitude != null)
                    callPayload.Queries["nearLatitude"] = ExpressionConverter.Convert(nearLatitude);
                if (nearLongitude != null)
                    callPayload.Queries["nearLongitude"] = ExpressionConverter.Convert(nearLongitude);
                if (nearAddress != null)
                    callPayload.Queries["nearAddress"] = ExpressionConverter.Convert(nearAddress);
                if (distanceMiles != null)
                    callPayload.Queries["distanceMiles"] = ExpressionConverter.Convert(distanceMiles);
                if (boundaryLatitude != null)
                    callPayload.Queries["boundaryLatitude"] = ExpressionConverter.Convert(boundaryLatitude);
                if (boundaryLongitude != null)
                    callPayload.Queries["boundaryLongitude"] = ExpressionConverter.Convert(boundaryLongitude);
                if (boundaryAddress != null)
                    callPayload.Queries["boundaryAddress"] = ExpressionConverter.Convert(boundaryAddress);
                if (isInBoundaryOnly != null)
                    callPayload.Queries["isInBoundaryOnly"] = ExpressionConverter.Convert(isInBoundaryOnly);
                if (boxLatitudeNW != null)
                    callPayload.Queries["boxLatitudeNW"] = ExpressionConverter.Convert(boxLatitudeNW);
                if (boxLongitudeNW != null)
                    callPayload.Queries["boxLongitudeNW"] = ExpressionConverter.Convert(boxLongitudeNW);
                if (boxLatitudeSE != null)
                    callPayload.Queries["boxLatitudeSE"] = ExpressionConverter.Convert(boxLatitudeSE);
                if (boxLongitudeSE != null)
                    callPayload.Queries["boxLongitudeSE"] = ExpressionConverter.Convert(boxLongitudeSE);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (perPage != null)
                    callPayload.Queries["perPage"] = ExpressionConverter.Convert(perPage);
                if (sortBy != null)
                    callPayload.Queries["sortBy"] = ExpressionConverter.Convert(sortBy);
                if (includeUnrankedSchoolsInRankSort != null)
                    callPayload.Queries["includeUnrankedSchoolsInRankSort"] = ExpressionConverter.Convert(includeUnrankedSchoolsInRankSort);
                return new ApiConnectionAction<APISchoolList2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schooldiggerip")]
        [WorkflowExpressionFactory(nameof(__BuildSchoolsGetSchool20))]
        public IBodyWorkflowAction<APISchool20Full> SchoolsGetSchool20([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schooldiggerip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<APISchool20Full> __BuildSchoolsGetSchool20(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<APISchool20Full>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2.0/schools/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<APISchool20Full>(callPayload);
            });
        }
    }

    public class SchooldiggeripTriggers([ConnectionName] string connectionId)
    {
    }

    public class APIAutocompleteSchoolResult
    {
        [JsonProperty("schoolMatches")]
        public APISchoolAC[] SchoolMatches { get; set; }
    }

    public class APISchoolAC
    {
        [JsonProperty("schoolid")]
        public string Schoolid { get; set; }

        [JsonProperty("schoolName")]
        public string SchoolName { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("schoolLevel")]
        public string SchoolLevel { get; set; }

        [JsonProperty("lowGrade")]
        public string LowGrade { get; set; }

        [JsonProperty("highGrade")]
        public string HighGrade { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("hasBoundary")]
        public bool HasBoundary { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("rankOf")]
        public int RankOf { get; set; }

        [JsonProperty("rankStars")]
        public int RankStars { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum levelInput
    {
        Elementary,
        Middle,
        High,
        Alt,
        Public,
        Private
    }

    public class APIDistrictList2
    {
        [JsonProperty("numberOfDistricts")]
        public int NumberOfDistricts { get; set; }

        [JsonProperty("numberOfPages")]
        public int NumberOfPages { get; set; }

        [JsonProperty("districtList")]
        public APIDistrict2Summary[] DistrictList { get; set; }
    }

    public class APIDistrict2Summary
    {
        [JsonProperty("districtID")]
        public string DistrictID { get; set; }

        [JsonProperty("districtName")]
        public string DistrictName { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("address")]
        public APILocation Address { get; set; }

        [JsonProperty("locationIsWithinBoundary")]
        public bool LocationIsWithinBoundary { get; set; }

        [JsonProperty("hasBoundary")]
        public bool HasBoundary { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("isWithinBoundary")]
        public bool IsWithinBoundary { get; set; }

        [JsonProperty("county")]
        public APICounty County { get; set; }

        [JsonProperty("lowGrade")]
        public string LowGrade { get; set; }

        [JsonProperty("highGrade")]
        public string HighGrade { get; set; }

        [JsonProperty("numberTotalSchools")]
        public int NumberTotalSchools { get; set; }

        [JsonProperty("numberPrimarySchools")]
        public int NumberPrimarySchools { get; set; }

        [JsonProperty("numberMiddleSchools")]
        public int NumberMiddleSchools { get; set; }

        [JsonProperty("numberHighSchools")]
        public int NumberHighSchools { get; set; }

        [JsonProperty("numberAlternativeSchools")]
        public int NumberAlternativeSchools { get; set; }

        [JsonProperty("rankHistory")]
        public APILEARankHistory[] RankHistory { get; set; }

        [JsonProperty("districtYearlyDetails")]
        public APILEAYearlyDetail[] DistrictYearlyDetails { get; set; }
    }

    public class APILocation
    {
        [JsonProperty("latLong")]
        public APILatLong LatLong { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("stateFull")]
        public string StateFull { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("zip4")]
        public string Zip4 { get; set; }

        [JsonProperty("cityURL")]
        public string CityURL { get; set; }

        [JsonProperty("zipURL")]
        public string ZipURL { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }
    }

    public class APILatLong
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }

    public class APICounty
    {
        [JsonProperty("countyName")]
        public string CountyName { get; set; }

        [JsonProperty("countyURL")]
        public string CountyURL { get; set; }
    }

    public class APILEARankHistory
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("rankOf")]
        public int RankOf { get; set; }

        [JsonProperty("rankStars")]
        public int RankStars { get; set; }

        [JsonProperty("rankStatewidePercentage")]
        public double RankStatewidePercentage { get; set; }

        [JsonProperty("rankScore")]
        public double RankScore { get; set; }
    }

    public class APILEAYearlyDetail
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("numberOfStudents")]
        public int NumberOfStudents { get; set; }

        [JsonProperty("numberOfSpecialEdStudents")]
        public int NumberOfSpecialEdStudents { get; set; }

        [JsonProperty("numberOfEnglishLanguageLearnerStudents")]
        public int NumberOfEnglishLanguageLearnerStudents { get; set; }

        [JsonProperty("numberOfTeachers")]
        public double NumberOfTeachers { get; set; }

        [JsonProperty("numberOfTeachersPK")]
        public double NumberOfTeachersPK { get; set; }

        [JsonProperty("numberOfTeachersK")]
        public double NumberOfTeachersK { get; set; }

        [JsonProperty("numberOfTeachersElementary")]
        public double NumberOfTeachersElementary { get; set; }

        [JsonProperty("numberOfTeachersSecondary")]
        public double NumberOfTeachersSecondary { get; set; }

        [JsonProperty("numberOfAids")]
        public double NumberOfAids { get; set; }

        [JsonProperty("numberOfCoordsSupervisors")]
        public double NumberOfCoordsSupervisors { get; set; }

        [JsonProperty("numberOfGuidanceElem")]
        public double NumberOfGuidanceElem { get; set; }

        [JsonProperty("numberOfGuidanceSecondary")]
        public double NumberOfGuidanceSecondary { get; set; }

        [JsonProperty("numberOfGuidanceTotal")]
        public double NumberOfGuidanceTotal { get; set; }

        [JsonProperty("numberOfLibrarians")]
        public double NumberOfLibrarians { get; set; }

        [JsonProperty("numberOfLibraryStaff")]
        public double NumberOfLibraryStaff { get; set; }

        [JsonProperty("numberOfLEAAdministrators")]
        public double NumberOfLEAAdministrators { get; set; }

        [JsonProperty("numberOfLEASupportStaff")]
        public double NumberOfLEASupportStaff { get; set; }

        [JsonProperty("numberOfSchoolAdministrators")]
        public double NumberOfSchoolAdministrators { get; set; }

        [JsonProperty("numberOfSchoolAdminSupportStaff")]
        public double NumberOfSchoolAdminSupportStaff { get; set; }

        [JsonProperty("numberOfStudentSupportStaff")]
        public double NumberOfStudentSupportStaff { get; set; }

        [JsonProperty("numberOfOtherSupportStaff")]
        public double NumberOfOtherSupportStaff { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortByInput
    {
        [EnumMember(Value = "schoolname")]
        Schoolname,
        [EnumMember(Value = "distance")]
        Distance,
        [EnumMember(Value = "rank")]
        Rank
    }

    public class APIDistrict12
    {
        [JsonProperty("districtID")]
        public string DistrictID { get; set; }

        [JsonProperty("districtName")]
        public string DistrictName { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("address")]
        public APILocation Address { get; set; }

        [JsonProperty("boundary")]
        public APIBoundary12 Boundary { get; set; }

        [JsonProperty("isWithinBoundary")]
        public bool IsWithinBoundary { get; set; }

        [JsonProperty("county")]
        public APICounty County { get; set; }

        [JsonProperty("lowGrade")]
        public string LowGrade { get; set; }

        [JsonProperty("highGrade")]
        public string HighGrade { get; set; }

        [JsonProperty("numberTotalSchools")]
        public int NumberTotalSchools { get; set; }

        [JsonProperty("numberPrimarySchools")]
        public int NumberPrimarySchools { get; set; }

        [JsonProperty("numberMiddleSchools")]
        public int NumberMiddleSchools { get; set; }

        [JsonProperty("numberHighSchools")]
        public int NumberHighSchools { get; set; }

        [JsonProperty("numberAlternativeSchools")]
        public int NumberAlternativeSchools { get; set; }

        [JsonProperty("rankHistory")]
        public APILEARankHistory[] RankHistory { get; set; }

        [JsonProperty("districtYearlyDetails")]
        public APILEAYearlyDetail[] DistrictYearlyDetails { get; set; }

        [JsonProperty("testScores")]
        public APITestScoreWrapper[] TestScores { get; set; }
    }

    public class APIBoundary12
    {
        [JsonProperty("polylineCollection")]
        public APIPolyline[] PolylineCollection { get; set; }

        [JsonProperty("polylines")]
        public string Polylines { get; set; }

        [JsonProperty("hasBoundary")]
        public bool HasBoundary { get; set; }
    }

    public class APIPolyline
    {
        [JsonProperty("polylineOverlayEncodedPoints")]
        public string PolylineOverlayEncodedPoints { get; set; }

        [JsonProperty("numberEncodedPoints")]
        public int NumberEncodedPoints { get; set; }
    }

    public class APITestScoreWrapper
    {
        [JsonProperty("test")]
        public string Test { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("grade")]
        public string Grade { get; set; }

        [JsonProperty("schoolTestScore")]
        public APITestScore SchoolTestScore { get; set; }

        [JsonProperty("districtTestScore")]
        public APITestScore DistrictTestScore { get; set; }

        [JsonProperty("stateTestScore")]
        public APITestScore StateTestScore { get; set; }

        [JsonProperty("tier1")]
        public string Tier1 { get; set; }

        [JsonProperty("tier2")]
        public string Tier2 { get; set; }

        [JsonProperty("tier3")]
        public string Tier3 { get; set; }

        [JsonProperty("tier4")]
        public string Tier4 { get; set; }

        [JsonProperty("tier5")]
        public string Tier5 { get; set; }
    }

    public class APITestScore
    {
        [JsonProperty("studentsEligible")]
        public int StudentsEligible { get; set; }

        [JsonProperty("studentsTested")]
        public int StudentsTested { get; set; }

        [JsonProperty("meanScaledScore")]
        public double MeanScaledScore { get; set; }

        [JsonProperty("percentMetStandard")]
        public double PercentMetStandard { get; set; }

        [JsonProperty("numberMetStandard")]
        public double NumberMetStandard { get; set; }

        [JsonProperty("numTier1")]
        public int NumTier1 { get; set; }

        [JsonProperty("numTier2")]
        public int NumTier2 { get; set; }

        [JsonProperty("numTier3")]
        public int NumTier3 { get; set; }

        [JsonProperty("numTier4")]
        public int NumTier4 { get; set; }

        [JsonProperty("numTier5")]
        public int NumTier5 { get; set; }

        [JsonProperty("percentTier1")]
        public double PercentTier1 { get; set; }

        [JsonProperty("percentTier2")]
        public double PercentTier2 { get; set; }

        [JsonProperty("percentTier3")]
        public double PercentTier3 { get; set; }

        [JsonProperty("percentTier4")]
        public double PercentTier4 { get; set; }

        [JsonProperty("percentTier5")]
        public double PercentTier5 { get; set; }
    }

    public class APISchoolListRank2
    {
        [JsonProperty("rankYear")]
        public int RankYear { get; set; }

        [JsonProperty("rankYearCompare")]
        public int RankYearCompare { get; set; }

        [JsonProperty("rankYearsAvailable")]
        public int[] RankYearsAvailable { get; set; }

        [JsonProperty("numberOfSchools")]
        public int NumberOfSchools { get; set; }

        [JsonProperty("numberOfPages")]
        public int NumberOfPages { get; set; }

        [JsonProperty("schoolList")]
        public APISchool2Summary[] SchoolList { get; set; }
    }

    public class APISchool2Summary
    {
        [JsonProperty("schoolid")]
        public string Schoolid { get; set; }

        [JsonProperty("schoolName")]
        public string SchoolName { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("urlCompare")]
        public string UrlCompare { get; set; }

        [JsonProperty("address")]
        public APILocation Address { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("lowGrade")]
        public string LowGrade { get; set; }

        [JsonProperty("highGrade")]
        public string HighGrade { get; set; }

        [JsonProperty("schoolLevel")]
        public string SchoolLevel { get; set; }

        [JsonProperty("isCharterSchool")]
        public string IsCharterSchool { get; set; }

        [JsonProperty("isMagnetSchool")]
        public string IsMagnetSchool { get; set; }

        [JsonProperty("isVirtualSchool")]
        public string IsVirtualSchool { get; set; }

        [JsonProperty("isTitleISchool")]
        public string IsTitleISchool { get; set; }

        [JsonProperty("isTitleISchoolwideSchool")]
        public string IsTitleISchoolwideSchool { get; set; }

        [JsonProperty("hasBoundary")]
        public bool HasBoundary { get; set; }

        [JsonProperty("locationIsWithinBoundary")]
        public bool LocationIsWithinBoundary { get; set; }

        [JsonProperty("district")]
        public APIDistrictSum District { get; set; }

        [JsonProperty("county")]
        public APICounty County { get; set; }

        [JsonProperty("rankHistory")]
        public APIRankHistory[] RankHistory { get; set; }

        [JsonProperty("rankMovement")]
        public int RankMovement { get; set; }

        [JsonProperty("schoolYearlyDetails")]
        public APIYearlyDemographics[] SchoolYearlyDetails { get; set; }

        [JsonProperty("isPrivate")]
        public bool IsPrivate { get; set; }

        [JsonProperty("privateDays")]
        public int PrivateDays { get; set; }

        [JsonProperty("privateHours")]
        public double PrivateHours { get; set; }

        [JsonProperty("privateHasLibrary")]
        public bool PrivateHasLibrary { get; set; }

        [JsonProperty("privateCoed")]
        public string PrivateCoed { get; set; }

        [JsonProperty("privateOrientation")]
        public string PrivateOrientation { get; set; }
    }

    public class APIDistrictSum
    {
        [JsonProperty("districtID")]
        public string DistrictID { get; set; }

        [JsonProperty("districtName")]
        public string DistrictName { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("rankURL")]
        public string RankURL { get; set; }
    }

    public class APIRankHistory
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("rankOf")]
        public int RankOf { get; set; }

        [JsonProperty("rankStars")]
        public int RankStars { get; set; }

        [JsonProperty("rankLevel")]
        public string RankLevel { get; set; }

        [JsonProperty("rankStatewidePercentage")]
        public double RankStatewidePercentage { get; set; }

        [JsonProperty("averageStandardScore")]
        public double AverageStandardScore { get; set; }
    }

    public class APIYearlyDemographics
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("numberOfStudents")]
        public int NumberOfStudents { get; set; }

        [JsonProperty("percentFreeDiscLunch")]
        public double PercentFreeDiscLunch { get; set; }

        [JsonProperty("percentofAfricanAmericanStudents")]
        public double PercentofAfricanAmericanStudents { get; set; }

        [JsonProperty("percentofAsianStudents")]
        public double PercentofAsianStudents { get; set; }

        [JsonProperty("percentofHispanicStudents")]
        public double PercentofHispanicStudents { get; set; }

        [JsonProperty("percentofIndianStudents")]
        public double PercentofIndianStudents { get; set; }

        [JsonProperty("percentofPacificIslanderStudents")]
        public double PercentofPacificIslanderStudents { get; set; }

        [JsonProperty("percentofWhiteStudents")]
        public double PercentofWhiteStudents { get; set; }

        [JsonProperty("percentofTwoOrMoreRaceStudents")]
        public double PercentofTwoOrMoreRaceStudents { get; set; }

        [JsonProperty("percentofUnspecifiedRaceStudents")]
        public double PercentofUnspecifiedRaceStudents { get; set; }

        [JsonProperty("teachersFulltime")]
        public double TeachersFulltime { get; set; }

        [JsonProperty("pupilTeacherRatio")]
        public double PupilTeacherRatio { get; set; }

        [JsonProperty("numberofAfricanAmericanStudents")]
        public int NumberofAfricanAmericanStudents { get; set; }

        [JsonProperty("numberofAsianStudents")]
        public int NumberofAsianStudents { get; set; }

        [JsonProperty("numberofHispanicStudents")]
        public int NumberofHispanicStudents { get; set; }

        [JsonProperty("numberofIndianStudents")]
        public int NumberofIndianStudents { get; set; }

        [JsonProperty("numberofPacificIslanderStudents")]
        public int NumberofPacificIslanderStudents { get; set; }

        [JsonProperty("numberofWhiteStudents")]
        public int NumberofWhiteStudents { get; set; }

        [JsonProperty("numberofTwoOrMoreRaceStudents")]
        public int NumberofTwoOrMoreRaceStudents { get; set; }

        [JsonProperty("numberofUnspecifiedRaceStudents")]
        public int NumberofUnspecifiedRaceStudents { get; set; }
    }

    public class APIDistrictListRank2
    {
        [JsonProperty("rankYear")]
        public int RankYear { get; set; }

        [JsonProperty("rankYearCompare")]
        public int RankYearCompare { get; set; }

        [JsonProperty("rankYearsAvailable")]
        public int[] RankYearsAvailable { get; set; }

        [JsonProperty("numberOfDistricts")]
        public int NumberOfDistricts { get; set; }

        [JsonProperty("numberOfPages")]
        public int NumberOfPages { get; set; }

        [JsonProperty("districtList")]
        public APIDistrict2Summary[] DistrictList { get; set; }

        [JsonProperty("rankCompareYear")]
        public int RankCompareYear { get; set; }
    }

    public class APISchoolList2
    {
        [JsonProperty("numberOfSchools")]
        public int NumberOfSchools { get; set; }

        [JsonProperty("numberOfPages")]
        public int NumberOfPages { get; set; }

        [JsonProperty("schoolList")]
        public APISchool2Summary[] SchoolList { get; set; }
    }

    public class APISchool20Full
    {
        [JsonProperty("schoolid")]
        public string Schoolid { get; set; }

        [JsonProperty("schoolName")]
        public string SchoolName { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("urlSchoolDigger")]
        public string UrlSchoolDigger { get; set; }

        [JsonProperty("urlCompareSchoolDigger")]
        public string UrlCompareSchoolDigger { get; set; }

        [JsonProperty("address")]
        public APILocation Address { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("lowGrade")]
        public string LowGrade { get; set; }

        [JsonProperty("highGrade")]
        public string HighGrade { get; set; }

        [JsonProperty("schoolLevel")]
        public string SchoolLevel { get; set; }

        [JsonProperty("isCharterSchool")]
        public string IsCharterSchool { get; set; }

        [JsonProperty("isMagnetSchool")]
        public string IsMagnetSchool { get; set; }

        [JsonProperty("isVirtualSchool")]
        public string IsVirtualSchool { get; set; }

        [JsonProperty("isTitleISchool")]
        public string IsTitleISchool { get; set; }

        [JsonProperty("isTitleISchoolwideSchool")]
        public string IsTitleISchoolwideSchool { get; set; }

        [JsonProperty("isPrivate")]
        public bool IsPrivate { get; set; }

        [JsonProperty("privateDays")]
        public int PrivateDays { get; set; }

        [JsonProperty("privateHours")]
        public double PrivateHours { get; set; }

        [JsonProperty("privateHasLibrary")]
        public bool PrivateHasLibrary { get; set; }

        [JsonProperty("privateCoed")]
        public string PrivateCoed { get; set; }

        [JsonProperty("privateOrientation")]
        public string PrivateOrientation { get; set; }

        [JsonProperty("district")]
        public APIDistrictSum District { get; set; }

        [JsonProperty("county")]
        public APICounty County { get; set; }

        [JsonProperty("reviews")]
        public APISchoolReview[] Reviews { get; set; }

        [JsonProperty("finance")]
        public APISchoolFinance[] Finance { get; set; }

        [JsonProperty("rankHistory")]
        public APIRankHistory[] RankHistory { get; set; }

        [JsonProperty("rankMovement")]
        public int RankMovement { get; set; }

        [JsonProperty("testScores")]
        public APITestScoreWrapper[] TestScores { get; set; }

        [JsonProperty("schoolYearlyDetails")]
        public APIYearlyDemographics[] SchoolYearlyDetails { get; set; }
    }

    public class APISchoolReview
    {
        [JsonProperty("submitDate")]
        public string SubmitDate { get; set; }

        [JsonProperty("numberOfStars")]
        public int NumberOfStars { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("submittedBy")]
        public string SubmittedBy { get; set; }
    }

    public class APISchoolFinance
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("spendingPerStudent")]
        public double SpendingPerStudent { get; set; }

        [JsonProperty("spendingFederalPersonnel")]
        public double SpendingFederalPersonnel { get; set; }

        [JsonProperty("spendingFederalNonPersonnel")]
        public double SpendingFederalNonPersonnel { get; set; }

        [JsonProperty("spendingStateLocalPersonnel")]
        public double SpendingStateLocalPersonnel { get; set; }

        [JsonProperty("spendingStateLocalNonPersonnel")]
        public double SpendingStateLocalNonPersonnel { get; set; }

        [JsonProperty("spendingPerStudentFederal")]
        public double SpendingPerStudentFederal { get; set; }

        [JsonProperty("spendingPerStudentStateLocal")]
        public double SpendingPerStudentStateLocal { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Schooldiggerip;

    public partial class WorkflowManagedActions
    {
        public SchooldiggeripActions Schooldiggerip(string connectionId) => new SchooldiggeripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SchooldiggeripTriggers Schooldiggerip(string connectionId) => new SchooldiggeripTriggers(connectionId);
    }
}