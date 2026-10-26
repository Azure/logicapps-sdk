//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Schooldiggerip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SchooldiggeripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schooldiggerip")]
        public IBodyWorkflowAction<APIAutocompleteSchoolResult, ApiConnectionActionConfiguration> AutocompleteGetSchools(Expression<Func<string>> q, Expression<Func<bool>> qSearchCityStateName = null, Expression<Func<string>> st = null, Expression<Func<levelInput>> level = null, Expression<Func<double>> boxLatitudeNW = null, Expression<Func<double>> boxLongitudeNW = null, Expression<Func<double>> boxLatitudeSE = null, Expression<Func<double>> boxLongitudeSE = null, Expression<Func<int>> returnCount = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: true);
            var __workflow_qSearchCityStateName = WorkflowExpression.Compile(qSearchCityStateName, nameof(qSearchCityStateName), required: false);
            var __workflow_st = WorkflowExpression.Compile(st, nameof(st), required: false);
            var __workflow_level = WorkflowExpression.Compile(level, nameof(level), required: false);
            var __workflow_boxLatitudeNW = WorkflowExpression.Compile(boxLatitudeNW, nameof(boxLatitudeNW), required: false);
            var __workflow_boxLongitudeNW = WorkflowExpression.Compile(boxLongitudeNW, nameof(boxLongitudeNW), required: false);
            var __workflow_boxLatitudeSE = WorkflowExpression.Compile(boxLatitudeSE, nameof(boxLatitudeSE), required: false);
            var __workflow_boxLongitudeSE = WorkflowExpression.Compile(boxLongitudeSE, nameof(boxLongitudeSE), required: false);
            var __workflow_returnCount = WorkflowExpression.Compile(returnCount, nameof(returnCount), required: false);
            return new DeferredBodyAction<APIAutocompleteSchoolResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2.0/autocomplete/schools";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_qSearchCityStateName != null)
                    callPayload.Queries["qSearchCityStateName"] = ExpressionConverter.Convert(__workflow_qSearchCityStateName);
                if (__workflow_st != null)
                    callPayload.Queries["st"] = ExpressionConverter.Convert(__workflow_st);
                if (__workflow_level != null)
                    callPayload.Queries["level"] = ExpressionConverter.Convert(__workflow_level);
                if (__workflow_boxLatitudeNW != null)
                    callPayload.Queries["boxLatitudeNW"] = ExpressionConverter.Convert(__workflow_boxLatitudeNW);
                if (__workflow_boxLongitudeNW != null)
                    callPayload.Queries["boxLongitudeNW"] = ExpressionConverter.Convert(__workflow_boxLongitudeNW);
                if (__workflow_boxLatitudeSE != null)
                    callPayload.Queries["boxLatitudeSE"] = ExpressionConverter.Convert(__workflow_boxLatitudeSE);
                if (__workflow_boxLongitudeSE != null)
                    callPayload.Queries["boxLongitudeSE"] = ExpressionConverter.Convert(__workflow_boxLongitudeSE);
                if (__workflow_returnCount != null)
                    callPayload.Queries["returnCount"] = ExpressionConverter.Convert(__workflow_returnCount);
                return new ApiConnectionAction<APIAutocompleteSchoolResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schooldiggerip")]
        public IBodyWorkflowAction<APIDistrictList2, ApiConnectionActionConfiguration> DistrictsGetAllDistricts2(Expression<Func<string>> st, Expression<Func<string>> q = null, Expression<Func<string>> city = null, Expression<Func<string>> zip = null, Expression<Func<double>> nearLatitude = null, Expression<Func<double>> nearLongitude = null, Expression<Func<string>> boundaryAddress = null, Expression<Func<int>> distanceMiles = null, Expression<Func<bool>> isInBoundaryOnly = null, Expression<Func<double>> boxLatitudeNW = null, Expression<Func<double>> boxLongitudeNW = null, Expression<Func<double>> boxLatitudeSE = null, Expression<Func<double>> boxLongitudeSE = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<sortByInput>> sortBy = null, Expression<Func<bool>> includeUnrankedDistrictsInRankSort = null)
        {
            var __workflow_st = WorkflowExpression.Compile(st, nameof(st), required: true);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_city = WorkflowExpression.Compile(city, nameof(city), required: false);
            var __workflow_zip = WorkflowExpression.Compile(zip, nameof(zip), required: false);
            var __workflow_nearLatitude = WorkflowExpression.Compile(nearLatitude, nameof(nearLatitude), required: false);
            var __workflow_nearLongitude = WorkflowExpression.Compile(nearLongitude, nameof(nearLongitude), required: false);
            var __workflow_boundaryAddress = WorkflowExpression.Compile(boundaryAddress, nameof(boundaryAddress), required: false);
            var __workflow_distanceMiles = WorkflowExpression.Compile(distanceMiles, nameof(distanceMiles), required: false);
            var __workflow_isInBoundaryOnly = WorkflowExpression.Compile(isInBoundaryOnly, nameof(isInBoundaryOnly), required: false);
            var __workflow_boxLatitudeNW = WorkflowExpression.Compile(boxLatitudeNW, nameof(boxLatitudeNW), required: false);
            var __workflow_boxLongitudeNW = WorkflowExpression.Compile(boxLongitudeNW, nameof(boxLongitudeNW), required: false);
            var __workflow_boxLatitudeSE = WorkflowExpression.Compile(boxLatitudeSE, nameof(boxLatitudeSE), required: false);
            var __workflow_boxLongitudeSE = WorkflowExpression.Compile(boxLongitudeSE, nameof(boxLongitudeSE), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            var __workflow_includeUnrankedDistrictsInRankSort = WorkflowExpression.Compile(includeUnrankedDistrictsInRankSort, nameof(includeUnrankedDistrictsInRankSort), required: false);
            return new DeferredBodyAction<APIDistrictList2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2.0/districts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["st"] = ExpressionConverter.Convert(__workflow_st);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_city != null)
                    callPayload.Queries["city"] = ExpressionConverter.Convert(__workflow_city);
                if (__workflow_zip != null)
                    callPayload.Queries["zip"] = ExpressionConverter.Convert(__workflow_zip);
                if (__workflow_nearLatitude != null)
                    callPayload.Queries["nearLatitude"] = ExpressionConverter.Convert(__workflow_nearLatitude);
                if (__workflow_nearLongitude != null)
                    callPayload.Queries["nearLongitude"] = ExpressionConverter.Convert(__workflow_nearLongitude);
                if (__workflow_boundaryAddress != null)
                    callPayload.Queries["boundaryAddress"] = ExpressionConverter.Convert(__workflow_boundaryAddress);
                if (__workflow_distanceMiles != null)
                    callPayload.Queries["distanceMiles"] = ExpressionConverter.Convert(__workflow_distanceMiles);
                if (__workflow_isInBoundaryOnly != null)
                    callPayload.Queries["isInBoundaryOnly"] = ExpressionConverter.Convert(__workflow_isInBoundaryOnly);
                if (__workflow_boxLatitudeNW != null)
                    callPayload.Queries["boxLatitudeNW"] = ExpressionConverter.Convert(__workflow_boxLatitudeNW);
                if (__workflow_boxLongitudeNW != null)
                    callPayload.Queries["boxLongitudeNW"] = ExpressionConverter.Convert(__workflow_boxLongitudeNW);
                if (__workflow_boxLatitudeSE != null)
                    callPayload.Queries["boxLatitudeSE"] = ExpressionConverter.Convert(__workflow_boxLatitudeSE);
                if (__workflow_boxLongitudeSE != null)
                    callPayload.Queries["boxLongitudeSE"] = ExpressionConverter.Convert(__workflow_boxLongitudeSE);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["perPage"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_sortBy != null)
                    callPayload.Queries["sortBy"] = ExpressionConverter.Convert(__workflow_sortBy);
                if (__workflow_includeUnrankedDistrictsInRankSort != null)
                    callPayload.Queries["includeUnrankedDistrictsInRankSort"] = ExpressionConverter.Convert(__workflow_includeUnrankedDistrictsInRankSort);
                return new ApiConnectionAction<APIDistrictList2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schooldiggerip")]
        public IBodyWorkflowAction<APIDistrict12, ApiConnectionActionConfiguration> DistrictsGetDistrict2(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<APIDistrict12, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2.0/districts/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<APIDistrict12>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schooldiggerip")]
        public IBodyWorkflowAction<APISchoolListRank2, ApiConnectionActionConfiguration> RankingGet(Expression<Func<string>> st, Expression<Func<int>> year = null, Expression<Func<levelInput>> level = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_st = WorkflowExpression.Compile(st, nameof(st), required: true);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: false);
            var __workflow_level = WorkflowExpression.Compile(level, nameof(level), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<APISchoolListRank2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2.0/rankings/schools/{0}", __workflow_st.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(__workflow_year);
                if (__workflow_level != null)
                    callPayload.Queries["level"] = ExpressionConverter.Convert(__workflow_level);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["perPage"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<APISchoolListRank2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schooldiggerip")]
        public IBodyWorkflowAction<APIDistrictListRank2, ApiConnectionActionConfiguration> DistrictRanking(Expression<Func<string>> st, Expression<Func<int>> year = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_st = WorkflowExpression.Compile(st, nameof(st), required: true);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<APIDistrictListRank2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2.0/rankings/districts/{0}", __workflow_st.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(__workflow_year);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["perPage"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<APIDistrictListRank2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schooldiggerip")]
        public IBodyWorkflowAction<APISchoolList2, ApiConnectionActionConfiguration> SchoolsGetAllSchools20(Expression<Func<string>> st, Expression<Func<string>> q = null, Expression<Func<bool>> qSearchSchoolNameOnly = null, Expression<Func<string>> districtId = null, Expression<Func<levelInput>> level = null, Expression<Func<string>> city = null, Expression<Func<string>> zip = null, Expression<Func<bool>> isMagnet = null, Expression<Func<bool>> isCharter = null, Expression<Func<bool>> isVirtual = null, Expression<Func<bool>> isTitleI = null, Expression<Func<bool>> isTitleISchoolwide = null, Expression<Func<double>> nearLatitude = null, Expression<Func<double>> nearLongitude = null, Expression<Func<string>> nearAddress = null, Expression<Func<int>> distanceMiles = null, Expression<Func<double>> boundaryLatitude = null, Expression<Func<double>> boundaryLongitude = null, Expression<Func<string>> boundaryAddress = null, Expression<Func<bool>> isInBoundaryOnly = null, Expression<Func<double>> boxLatitudeNW = null, Expression<Func<double>> boxLongitudeNW = null, Expression<Func<double>> boxLatitudeSE = null, Expression<Func<double>> boxLongitudeSE = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<sortByInput>> sortBy = null, Expression<Func<bool>> includeUnrankedSchoolsInRankSort = null)
        {
            var __workflow_st = WorkflowExpression.Compile(st, nameof(st), required: true);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_qSearchSchoolNameOnly = WorkflowExpression.Compile(qSearchSchoolNameOnly, nameof(qSearchSchoolNameOnly), required: false);
            var __workflow_districtId = WorkflowExpression.Compile(districtId, nameof(districtId), required: false);
            var __workflow_level = WorkflowExpression.Compile(level, nameof(level), required: false);
            var __workflow_city = WorkflowExpression.Compile(city, nameof(city), required: false);
            var __workflow_zip = WorkflowExpression.Compile(zip, nameof(zip), required: false);
            var __workflow_isMagnet = WorkflowExpression.Compile(isMagnet, nameof(isMagnet), required: false);
            var __workflow_isCharter = WorkflowExpression.Compile(isCharter, nameof(isCharter), required: false);
            var __workflow_isVirtual = WorkflowExpression.Compile(isVirtual, nameof(isVirtual), required: false);
            var __workflow_isTitleI = WorkflowExpression.Compile(isTitleI, nameof(isTitleI), required: false);
            var __workflow_isTitleISchoolwide = WorkflowExpression.Compile(isTitleISchoolwide, nameof(isTitleISchoolwide), required: false);
            var __workflow_nearLatitude = WorkflowExpression.Compile(nearLatitude, nameof(nearLatitude), required: false);
            var __workflow_nearLongitude = WorkflowExpression.Compile(nearLongitude, nameof(nearLongitude), required: false);
            var __workflow_nearAddress = WorkflowExpression.Compile(nearAddress, nameof(nearAddress), required: false);
            var __workflow_distanceMiles = WorkflowExpression.Compile(distanceMiles, nameof(distanceMiles), required: false);
            var __workflow_boundaryLatitude = WorkflowExpression.Compile(boundaryLatitude, nameof(boundaryLatitude), required: false);
            var __workflow_boundaryLongitude = WorkflowExpression.Compile(boundaryLongitude, nameof(boundaryLongitude), required: false);
            var __workflow_boundaryAddress = WorkflowExpression.Compile(boundaryAddress, nameof(boundaryAddress), required: false);
            var __workflow_isInBoundaryOnly = WorkflowExpression.Compile(isInBoundaryOnly, nameof(isInBoundaryOnly), required: false);
            var __workflow_boxLatitudeNW = WorkflowExpression.Compile(boxLatitudeNW, nameof(boxLatitudeNW), required: false);
            var __workflow_boxLongitudeNW = WorkflowExpression.Compile(boxLongitudeNW, nameof(boxLongitudeNW), required: false);
            var __workflow_boxLatitudeSE = WorkflowExpression.Compile(boxLatitudeSE, nameof(boxLatitudeSE), required: false);
            var __workflow_boxLongitudeSE = WorkflowExpression.Compile(boxLongitudeSE, nameof(boxLongitudeSE), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            var __workflow_includeUnrankedSchoolsInRankSort = WorkflowExpression.Compile(includeUnrankedSchoolsInRankSort, nameof(includeUnrankedSchoolsInRankSort), required: false);
            return new DeferredBodyAction<APISchoolList2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2.0/schools";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["st"] = ExpressionConverter.Convert(__workflow_st);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_qSearchSchoolNameOnly != null)
                    callPayload.Queries["qSearchSchoolNameOnly"] = ExpressionConverter.Convert(__workflow_qSearchSchoolNameOnly);
                if (__workflow_districtId != null)
                    callPayload.Queries["districtID"] = ExpressionConverter.Convert(__workflow_districtId);
                if (__workflow_level != null)
                    callPayload.Queries["level"] = ExpressionConverter.Convert(__workflow_level);
                if (__workflow_city != null)
                    callPayload.Queries["city"] = ExpressionConverter.Convert(__workflow_city);
                if (__workflow_zip != null)
                    callPayload.Queries["zip"] = ExpressionConverter.Convert(__workflow_zip);
                if (__workflow_isMagnet != null)
                    callPayload.Queries["isMagnet"] = ExpressionConverter.Convert(__workflow_isMagnet);
                if (__workflow_isCharter != null)
                    callPayload.Queries["isCharter"] = ExpressionConverter.Convert(__workflow_isCharter);
                if (__workflow_isVirtual != null)
                    callPayload.Queries["isVirtual"] = ExpressionConverter.Convert(__workflow_isVirtual);
                if (__workflow_isTitleI != null)
                    callPayload.Queries["isTitleI"] = ExpressionConverter.Convert(__workflow_isTitleI);
                if (__workflow_isTitleISchoolwide != null)
                    callPayload.Queries["isTitleISchoolwide"] = ExpressionConverter.Convert(__workflow_isTitleISchoolwide);
                if (__workflow_nearLatitude != null)
                    callPayload.Queries["nearLatitude"] = ExpressionConverter.Convert(__workflow_nearLatitude);
                if (__workflow_nearLongitude != null)
                    callPayload.Queries["nearLongitude"] = ExpressionConverter.Convert(__workflow_nearLongitude);
                if (__workflow_nearAddress != null)
                    callPayload.Queries["nearAddress"] = ExpressionConverter.Convert(__workflow_nearAddress);
                if (__workflow_distanceMiles != null)
                    callPayload.Queries["distanceMiles"] = ExpressionConverter.Convert(__workflow_distanceMiles);
                if (__workflow_boundaryLatitude != null)
                    callPayload.Queries["boundaryLatitude"] = ExpressionConverter.Convert(__workflow_boundaryLatitude);
                if (__workflow_boundaryLongitude != null)
                    callPayload.Queries["boundaryLongitude"] = ExpressionConverter.Convert(__workflow_boundaryLongitude);
                if (__workflow_boundaryAddress != null)
                    callPayload.Queries["boundaryAddress"] = ExpressionConverter.Convert(__workflow_boundaryAddress);
                if (__workflow_isInBoundaryOnly != null)
                    callPayload.Queries["isInBoundaryOnly"] = ExpressionConverter.Convert(__workflow_isInBoundaryOnly);
                if (__workflow_boxLatitudeNW != null)
                    callPayload.Queries["boxLatitudeNW"] = ExpressionConverter.Convert(__workflow_boxLatitudeNW);
                if (__workflow_boxLongitudeNW != null)
                    callPayload.Queries["boxLongitudeNW"] = ExpressionConverter.Convert(__workflow_boxLongitudeNW);
                if (__workflow_boxLatitudeSE != null)
                    callPayload.Queries["boxLatitudeSE"] = ExpressionConverter.Convert(__workflow_boxLatitudeSE);
                if (__workflow_boxLongitudeSE != null)
                    callPayload.Queries["boxLongitudeSE"] = ExpressionConverter.Convert(__workflow_boxLongitudeSE);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["perPage"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_sortBy != null)
                    callPayload.Queries["sortBy"] = ExpressionConverter.Convert(__workflow_sortBy);
                if (__workflow_includeUnrankedSchoolsInRankSort != null)
                    callPayload.Queries["includeUnrankedSchoolsInRankSort"] = ExpressionConverter.Convert(__workflow_includeUnrankedSchoolsInRankSort);
                return new ApiConnectionAction<APISchoolList2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schooldiggerip")]
        public IBodyWorkflowAction<APISchool20Full, ApiConnectionActionConfiguration> SchoolsGetSchool20(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<APISchool20Full, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2.0/schools/{0}", __workflow_id.WithUrlEncoding(1)));
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
        public string DistrictId { get; set; }

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
        public string DistrictId { get; set; }

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
        public string DistrictId { get; set; }

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