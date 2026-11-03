//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Serviceobjects
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ServiceobjectsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serviceobjects")]
        public IBodyWorkflowAction<AVIGetAddressInfoResponse, ApiConnectionActionConfiguration> AVIGetAddressInfo(Expression<Func<string>> address1 = null, Expression<Func<string>> address2 = null, Expression<Func<string>> address3 = null, Expression<Func<string>> address4 = null, Expression<Func<string>> address5 = null, Expression<Func<string>> locality = null, Expression<Func<string>> administrativeArea = null, Expression<Func<string>> postalCode = null, Expression<Func<string>> country = null, Expression<Func<string>> outputLanguage = null)
        {
            var __workflow_address1 = WorkflowExpression.Compile(address1, nameof(address1), required: false);
            var __workflow_address2 = WorkflowExpression.Compile(address2, nameof(address2), required: false);
            var __workflow_address3 = WorkflowExpression.Compile(address3, nameof(address3), required: false);
            var __workflow_address4 = WorkflowExpression.Compile(address4, nameof(address4), required: false);
            var __workflow_address5 = WorkflowExpression.Compile(address5, nameof(address5), required: false);
            var __workflow_locality = WorkflowExpression.Compile(locality, nameof(locality), required: false);
            var __workflow_administrativeArea = WorkflowExpression.Compile(administrativeArea, nameof(administrativeArea), required: false);
            var __workflow_postalCode = WorkflowExpression.Compile(postalCode, nameof(postalCode), required: false);
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: false);
            var __workflow_outputLanguage = WorkflowExpression.Compile(outputLanguage, nameof(outputLanguage), required: false);
            return new DeferredBodyAction<AVIGetAddressInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AVI/api.svc/json/GetAddressInfo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_address1 != null)
                    callPayload.Queries["Address1"] = ExpressionConverter.Convert(__workflow_address1);
                if (__workflow_address2 != null)
                    callPayload.Queries["Address2"] = ExpressionConverter.Convert(__workflow_address2);
                if (__workflow_address3 != null)
                    callPayload.Queries["Address3"] = ExpressionConverter.Convert(__workflow_address3);
                if (__workflow_address4 != null)
                    callPayload.Queries["Address4"] = ExpressionConverter.Convert(__workflow_address4);
                if (__workflow_address5 != null)
                    callPayload.Queries["Address5"] = ExpressionConverter.Convert(__workflow_address5);
                if (__workflow_locality != null)
                    callPayload.Queries["Locality"] = ExpressionConverter.Convert(__workflow_locality);
                if (__workflow_administrativeArea != null)
                    callPayload.Queries["AdministrativeArea"] = ExpressionConverter.Convert(__workflow_administrativeArea);
                if (__workflow_postalCode != null)
                    callPayload.Queries["PostalCode"] = ExpressionConverter.Convert(__workflow_postalCode);
                if (__workflow_country != null)
                    callPayload.Queries["Country"] = ExpressionConverter.Convert(__workflow_country);
                if (__workflow_outputLanguage != null)
                    callPayload.Queries["OutputLanguage"] = ExpressionConverter.Convert(__workflow_outputLanguage);
                return new ApiConnectionAction<AVIGetAddressInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serviceobjects")]
        public IBodyWorkflowAction<AGIPlaceSearchResponse, ApiConnectionActionConfiguration> AGIPlaceSearch(Expression<Func<string>> singleLine = null, Expression<Func<string>> address1 = null, Expression<Func<string>> address2 = null, Expression<Func<string>> address3 = null, Expression<Func<string>> address4 = null, Expression<Func<string>> address5 = null, Expression<Func<string>> locality = null, Expression<Func<string>> administrativeArea = null, Expression<Func<string>> postalCode = null, Expression<Func<string>> country = null, Expression<Func<string>> boundaries = null, Expression<Func<string>> maxResults = null, Expression<Func<string>> searchType = null, Expression<Func<string>> extras = null)
        {
            var __workflow_singleLine = WorkflowExpression.Compile(singleLine, nameof(singleLine), required: false);
            var __workflow_address1 = WorkflowExpression.Compile(address1, nameof(address1), required: false);
            var __workflow_address2 = WorkflowExpression.Compile(address2, nameof(address2), required: false);
            var __workflow_address3 = WorkflowExpression.Compile(address3, nameof(address3), required: false);
            var __workflow_address4 = WorkflowExpression.Compile(address4, nameof(address4), required: false);
            var __workflow_address5 = WorkflowExpression.Compile(address5, nameof(address5), required: false);
            var __workflow_locality = WorkflowExpression.Compile(locality, nameof(locality), required: false);
            var __workflow_administrativeArea = WorkflowExpression.Compile(administrativeArea, nameof(administrativeArea), required: false);
            var __workflow_postalCode = WorkflowExpression.Compile(postalCode, nameof(postalCode), required: false);
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: false);
            var __workflow_boundaries = WorkflowExpression.Compile(boundaries, nameof(boundaries), required: false);
            var __workflow_maxResults = WorkflowExpression.Compile(maxResults, nameof(maxResults), required: false);
            var __workflow_searchType = WorkflowExpression.Compile(searchType, nameof(searchType), required: false);
            var __workflow_extras = WorkflowExpression.Compile(extras, nameof(extras), required: false);
            return new DeferredBodyAction<AGIPlaceSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AGI/api.svc/json/PlaceSearch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_singleLine != null)
                    callPayload.Queries["SingleLine"] = ExpressionConverter.Convert(__workflow_singleLine);
                if (__workflow_address1 != null)
                    callPayload.Queries["Address1"] = ExpressionConverter.Convert(__workflow_address1);
                if (__workflow_address2 != null)
                    callPayload.Queries["Address2"] = ExpressionConverter.Convert(__workflow_address2);
                if (__workflow_address3 != null)
                    callPayload.Queries["Address3"] = ExpressionConverter.Convert(__workflow_address3);
                if (__workflow_address4 != null)
                    callPayload.Queries["Address4"] = ExpressionConverter.Convert(__workflow_address4);
                if (__workflow_address5 != null)
                    callPayload.Queries["Address5"] = ExpressionConverter.Convert(__workflow_address5);
                if (__workflow_locality != null)
                    callPayload.Queries["Locality"] = ExpressionConverter.Convert(__workflow_locality);
                if (__workflow_administrativeArea != null)
                    callPayload.Queries["AdministrativeArea"] = ExpressionConverter.Convert(__workflow_administrativeArea);
                if (__workflow_postalCode != null)
                    callPayload.Queries["PostalCode"] = ExpressionConverter.Convert(__workflow_postalCode);
                if (__workflow_country != null)
                    callPayload.Queries["Country"] = ExpressionConverter.Convert(__workflow_country);
                if (__workflow_boundaries != null)
                    callPayload.Queries["Boundaries"] = ExpressionConverter.Convert(__workflow_boundaries);
                if (__workflow_maxResults != null)
                    callPayload.Queries["MaxResults"] = ExpressionConverter.Convert(__workflow_maxResults);
                if (__workflow_searchType != null)
                    callPayload.Queries["SearchType"] = ExpressionConverter.Convert(__workflow_searchType);
                if (__workflow_extras != null)
                    callPayload.Queries["Extras"] = ExpressionConverter.Convert(__workflow_extras);
                return new ApiConnectionAction<AGIPlaceSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serviceobjects")]
        public IBodyWorkflowAction<AGIReverseSearchResponse, ApiConnectionActionConfiguration> AGIReverseSearch(Expression<Func<string>> latitude = null, Expression<Func<string>> longitude = null, Expression<Func<string>> searchRadius = null, Expression<Func<string>> country = null, Expression<Func<string>> maxResults = null, Expression<Func<string>> searchType = null)
        {
            var __workflow_latitude = WorkflowExpression.Compile(latitude, nameof(latitude), required: false);
            var __workflow_longitude = WorkflowExpression.Compile(longitude, nameof(longitude), required: false);
            var __workflow_searchRadius = WorkflowExpression.Compile(searchRadius, nameof(searchRadius), required: false);
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: false);
            var __workflow_maxResults = WorkflowExpression.Compile(maxResults, nameof(maxResults), required: false);
            var __workflow_searchType = WorkflowExpression.Compile(searchType, nameof(searchType), required: false);
            return new DeferredBodyAction<AGIReverseSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AGI/api.svc/json/ReverseSearch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_latitude != null)
                    callPayload.Queries["Latitude"] = ExpressionConverter.Convert(__workflow_latitude);
                if (__workflow_longitude != null)
                    callPayload.Queries["Longitude"] = ExpressionConverter.Convert(__workflow_longitude);
                if (__workflow_searchRadius != null)
                    callPayload.Queries["SearchRadius"] = ExpressionConverter.Convert(__workflow_searchRadius);
                if (__workflow_country != null)
                    callPayload.Queries["Country"] = ExpressionConverter.Convert(__workflow_country);
                if (__workflow_maxResults != null)
                    callPayload.Queries["MaxResults"] = ExpressionConverter.Convert(__workflow_maxResults);
                if (__workflow_searchType != null)
                    callPayload.Queries["SearchType"] = ExpressionConverter.Convert(__workflow_searchType);
                return new ApiConnectionAction<AGIReverseSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serviceobjects")]
        public IBodyWorkflowAction<PE2IGetInternationalExchangeInfoResponse, ApiConnectionActionConfiguration> PE2IGetInternationalExchangeInfo(Expression<Func<string>> phoneNumber = null, Expression<Func<string>> country = null)
        {
            var __workflow_phoneNumber = WorkflowExpression.Compile(phoneNumber, nameof(phoneNumber), required: false);
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: false);
            return new DeferredBodyAction<PE2IGetInternationalExchangeInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PE2/web.svc/json/GetInternationalExchangeInfo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_phoneNumber != null)
                    callPayload.Queries["PhoneNumber"] = ExpressionConverter.Convert(__workflow_phoneNumber);
                if (__workflow_country != null)
                    callPayload.Queries["Country"] = ExpressionConverter.Convert(__workflow_country);
                return new ApiConnectionAction<PE2IGetInternationalExchangeInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serviceobjects")]
        public IBodyWorkflowAction<LVIValidateLeadInternationalResponse, ApiConnectionActionConfiguration> LVIValidateLeadInternational(Expression<Func<string>> fullName = null, Expression<Func<string>> salutation = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lastName = null, Expression<Func<string>> businessName = null, Expression<Func<string>> businessDomain = null, Expression<Func<string>> businessEIN = null, Expression<Func<string>> address1 = null, Expression<Func<string>> address2 = null, Expression<Func<string>> address3 = null, Expression<Func<string>> address4 = null, Expression<Func<string>> address5 = null, Expression<Func<string>> locality = null, Expression<Func<string>> adminArea = null, Expression<Func<string>> postalCode = null, Expression<Func<string>> country = null, Expression<Func<string>> phone1 = null, Expression<Func<string>> phone2 = null, Expression<Func<string>> email = null, Expression<Func<string>> iPAddress = null, Expression<Func<string>> gender = null, Expression<Func<string>> dateOfBirth = null, Expression<Func<string>> uTCCaptureTime = null, Expression<Func<string>> outputLanguage = null, Expression<Func<string>> testType = null)
        {
            var __workflow_fullName = WorkflowExpression.Compile(fullName, nameof(fullName), required: false);
            var __workflow_salutation = WorkflowExpression.Compile(salutation, nameof(salutation), required: false);
            var __workflow_firstName = WorkflowExpression.Compile(firstName, nameof(firstName), required: false);
            var __workflow_lastName = WorkflowExpression.Compile(lastName, nameof(lastName), required: false);
            var __workflow_businessName = WorkflowExpression.Compile(businessName, nameof(businessName), required: false);
            var __workflow_businessDomain = WorkflowExpression.Compile(businessDomain, nameof(businessDomain), required: false);
            var __workflow_businessEIN = WorkflowExpression.Compile(businessEIN, nameof(businessEIN), required: false);
            var __workflow_address1 = WorkflowExpression.Compile(address1, nameof(address1), required: false);
            var __workflow_address2 = WorkflowExpression.Compile(address2, nameof(address2), required: false);
            var __workflow_address3 = WorkflowExpression.Compile(address3, nameof(address3), required: false);
            var __workflow_address4 = WorkflowExpression.Compile(address4, nameof(address4), required: false);
            var __workflow_address5 = WorkflowExpression.Compile(address5, nameof(address5), required: false);
            var __workflow_locality = WorkflowExpression.Compile(locality, nameof(locality), required: false);
            var __workflow_adminArea = WorkflowExpression.Compile(adminArea, nameof(adminArea), required: false);
            var __workflow_postalCode = WorkflowExpression.Compile(postalCode, nameof(postalCode), required: false);
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: false);
            var __workflow_phone1 = WorkflowExpression.Compile(phone1, nameof(phone1), required: false);
            var __workflow_phone2 = WorkflowExpression.Compile(phone2, nameof(phone2), required: false);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: false);
            var __workflow_iPAddress = WorkflowExpression.Compile(iPAddress, nameof(iPAddress), required: false);
            var __workflow_gender = WorkflowExpression.Compile(gender, nameof(gender), required: false);
            var __workflow_dateOfBirth = WorkflowExpression.Compile(dateOfBirth, nameof(dateOfBirth), required: false);
            var __workflow_uTCCaptureTime = WorkflowExpression.Compile(uTCCaptureTime, nameof(uTCCaptureTime), required: false);
            var __workflow_outputLanguage = WorkflowExpression.Compile(outputLanguage, nameof(outputLanguage), required: false);
            var __workflow_testType = WorkflowExpression.Compile(testType, nameof(testType), required: false);
            return new DeferredBodyAction<LVIValidateLeadInternationalResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/LVI/api.svc/json/ValidateLeadInternational";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fullName != null)
                    callPayload.Queries["FullName"] = ExpressionConverter.Convert(__workflow_fullName);
                if (__workflow_salutation != null)
                    callPayload.Queries["Salutation"] = ExpressionConverter.Convert(__workflow_salutation);
                if (__workflow_firstName != null)
                    callPayload.Queries["FirstName"] = ExpressionConverter.Convert(__workflow_firstName);
                if (__workflow_lastName != null)
                    callPayload.Queries["LastName"] = ExpressionConverter.Convert(__workflow_lastName);
                if (__workflow_businessName != null)
                    callPayload.Queries["BusinessName"] = ExpressionConverter.Convert(__workflow_businessName);
                if (__workflow_businessDomain != null)
                    callPayload.Queries["BusinessDomain"] = ExpressionConverter.Convert(__workflow_businessDomain);
                if (__workflow_businessEIN != null)
                    callPayload.Queries["BusinessEIN"] = ExpressionConverter.Convert(__workflow_businessEIN);
                if (__workflow_address1 != null)
                    callPayload.Queries["Address1"] = ExpressionConverter.Convert(__workflow_address1);
                if (__workflow_address2 != null)
                    callPayload.Queries["Address2"] = ExpressionConverter.Convert(__workflow_address2);
                if (__workflow_address3 != null)
                    callPayload.Queries["Address3"] = ExpressionConverter.Convert(__workflow_address3);
                if (__workflow_address4 != null)
                    callPayload.Queries["Address4"] = ExpressionConverter.Convert(__workflow_address4);
                if (__workflow_address5 != null)
                    callPayload.Queries["Address5"] = ExpressionConverter.Convert(__workflow_address5);
                if (__workflow_locality != null)
                    callPayload.Queries["Locality"] = ExpressionConverter.Convert(__workflow_locality);
                if (__workflow_adminArea != null)
                    callPayload.Queries["AdminArea"] = ExpressionConverter.Convert(__workflow_adminArea);
                if (__workflow_postalCode != null)
                    callPayload.Queries["PostalCode"] = ExpressionConverter.Convert(__workflow_postalCode);
                if (__workflow_country != null)
                    callPayload.Queries["Country"] = ExpressionConverter.Convert(__workflow_country);
                if (__workflow_phone1 != null)
                    callPayload.Queries["Phone1"] = ExpressionConverter.Convert(__workflow_phone1);
                if (__workflow_phone2 != null)
                    callPayload.Queries["Phone2"] = ExpressionConverter.Convert(__workflow_phone2);
                if (__workflow_email != null)
                    callPayload.Queries["Email"] = ExpressionConverter.Convert(__workflow_email);
                if (__workflow_iPAddress != null)
                    callPayload.Queries["IPAddress"] = ExpressionConverter.Convert(__workflow_iPAddress);
                if (__workflow_gender != null)
                    callPayload.Queries["Gender"] = ExpressionConverter.Convert(__workflow_gender);
                if (__workflow_dateOfBirth != null)
                    callPayload.Queries["DateOfBirth"] = ExpressionConverter.Convert(__workflow_dateOfBirth);
                if (__workflow_uTCCaptureTime != null)
                    callPayload.Queries["UTCCaptureTime"] = ExpressionConverter.Convert(__workflow_uTCCaptureTime);
                if (__workflow_outputLanguage != null)
                    callPayload.Queries["OutputLanguage"] = ExpressionConverter.Convert(__workflow_outputLanguage);
                if (__workflow_testType != null)
                    callPayload.Queries["TestType"] = ExpressionConverter.Convert(__workflow_testType);
                return new ApiConnectionAction<LVIValidateLeadInternationalResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serviceobjects")]
        public IBodyWorkflowAction<AV3GetBestMatchesResponse, ApiConnectionActionConfiguration> AV3GetBestMatches(Expression<Func<string>> businessName = null, Expression<Func<string>> address = null, Expression<Func<string>> address2 = null, Expression<Func<string>> city = null, Expression<Func<string>> state = null, Expression<Func<string>> postalCode = null)
        {
            var __workflow_businessName = WorkflowExpression.Compile(businessName, nameof(businessName), required: false);
            var __workflow_address = WorkflowExpression.Compile(address, nameof(address), required: false);
            var __workflow_address2 = WorkflowExpression.Compile(address2, nameof(address2), required: false);
            var __workflow_city = WorkflowExpression.Compile(city, nameof(city), required: false);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
            var __workflow_postalCode = WorkflowExpression.Compile(postalCode, nameof(postalCode), required: false);
            return new DeferredBodyAction<AV3GetBestMatchesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AV3/api.svc/GetBestMatchesJson";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_businessName != null)
                    callPayload.Queries["BusinessName"] = ExpressionConverter.Convert(__workflow_businessName);
                if (__workflow_address != null)
                    callPayload.Queries["Address"] = ExpressionConverter.Convert(__workflow_address);
                if (__workflow_address2 != null)
                    callPayload.Queries["Address2"] = ExpressionConverter.Convert(__workflow_address2);
                if (__workflow_city != null)
                    callPayload.Queries["City"] = ExpressionConverter.Convert(__workflow_city);
                if (__workflow_state != null)
                    callPayload.Queries["State"] = ExpressionConverter.Convert(__workflow_state);
                if (__workflow_postalCode != null)
                    callPayload.Queries["PostalCode"] = ExpressionConverter.Convert(__workflow_postalCode);
                return new ApiConnectionAction<AV3GetBestMatchesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serviceobjects")]
        public IBodyWorkflowAction<IPAVGetLocationByIPV4Response, ApiConnectionActionConfiguration> IPAVGetLocationByIP(Expression<Func<string>> iPAddress = null)
        {
            var __workflow_iPAddress = WorkflowExpression.Compile(iPAddress, nameof(iPAddress), required: false);
            return new DeferredBodyAction<IPAVGetLocationByIPV4Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GPP/web.svc/json/GetLocationByIP_V4";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_iPAddress != null)
                    callPayload.Queries["IPAddress"] = ExpressionConverter.Convert(__workflow_iPAddress);
                return new ApiConnectionAction<IPAVGetLocationByIPV4Response>(callPayload);
            });
        }
    }

    public class ServiceobjectsTriggers([ConnectionName] string connectionId)
    {
    }

    public class AVIGetAddressInfoResponse
    {
        public AVIGetAddressInfoResponseAddressInfoType AddressInfo { get; set; }
        public AVIGetAddressInfoResponseErrorType Error { get; set; }
        public string Debug { get; set; }
    }

    public class AVIGetAddressInfoResponseAddressInfoType
    {
        public string Status { get; set; }
        public string ResolutionLevel { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Address5 { get; set; }
        public string Address6 { get; set; }
        public string Address7 { get; set; }
        public string Address8 { get; set; }
        public string Locality { get; set; }
        public string AdministrativeArea { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string CountryISO2 { get; set; }
        public string CountryISO3 { get; set; }
        public AVIGetAddressInfoResponseAddressInfoTypeInformationComponentsTypeItem[] InformationComponents { get; set; }
    }

    public class AVIGetAddressInfoResponseAddressInfoTypeInformationComponentsTypeItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class AVIGetAddressInfoResponseErrorType
    {
        public string Type { get; set; }
        public string TypeCode { get; set; }
        public string Desc { get; set; }
        public string DescCode { get; set; }
    }

    public class AGIPlaceSearchResponse
    {
        public AGIPlaceSearchResponseSearchInfoType SearchInfo { get; set; }
        public AGIPlaceSearchResponseLocationsTypeItem[] Locations { get; set; }
        public AGIPlaceSearchResponseErrorType Error { get; set; }
        public string Debug { get; set; }
    }

    public class AGIPlaceSearchResponseSearchInfoType
    {
        public string Status { get; set; }
        public int NumberOfLocations { get; set; }
        public string Notes { get; set; }
        public string NotesDesc { get; set; }
        public string Warnings { get; set; }
        public string WarningsDesc { get; set; }
    }

    public class AGIPlaceSearchResponseLocationsTypeItem
    {
        public int PrecisionLevel { get; set; }
        public string Type { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public AGIPlaceSearchResponseLocationsTypeItemAddressComponentsType AddressComponents { get; set; }
    }

    public class AGIPlaceSearchResponseLocationsTypeItemAddressComponentsType
    {
        public string PremiseNumber { get; set; }
        public string Thoroughfare { get; set; }
        public string DoubleDependentLocality { get; set; }
        public string DependentLocality { get; set; }
        public string Locality { get; set; }
        public string AdministrativeArea4 { get; set; }
        public string AdministrativeArea4Abbreviation { get; set; }
        public string AdministrativeArea3 { get; set; }
        public string AdministrativeArea3Abbreviation { get; set; }
        public string AdministrativeArea2 { get; set; }
        public string AdministrativeArea2Abbreviation { get; set; }
        public string AdministrativeArea1 { get; set; }
        public string AdministrativeArea1Abbreviation { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string CountryISO2 { get; set; }
        public string CountryISO3 { get; set; }
        public string BingMapsURL { get; set; }
        public string GoogleMapsURL { get; set; }
        public string MapQuestURL { get; set; }
        public string PlaceName { get; set; }
        public string IsUnincorporated { get; set; }
        public string StateFIPS { get; set; }
        public string CountyFIPS { get; set; }
        public string CensusTract { get; set; }
        public string CensusBlock { get; set; }

        [JsonProperty("CensusGeoID")]
        public string CensusGeoId { get; set; }
        public string ClassFP { get; set; }
        public string CongressCode { get; set; }
        public string SLDUST { get; set; }
        public string SLDLST { get; set; }

        [JsonProperty("TimeZone_UTC")]
        public string TimeZoneUTC { get; set; }
    }

    public class AGIPlaceSearchResponseErrorType
    {
        public string Type { get; set; }
        public string TypeCode { get; set; }
        public string Desc { get; set; }
        public string DescCode { get; set; }
    }

    public class AGIReverseSearchResponse
    {
        public AGIReverseSearchResponseSearchInfoType SearchInfo { get; set; }
        public AGIReverseSearchResponseLocationsTypeItem[] Locations { get; set; }
        public AGIReverseSearchResponseErrorType Error { get; set; }
        public string Debug { get; set; }
    }

    public class AGIReverseSearchResponseSearchInfoType
    {
        public string Status { get; set; }
        public int NumberOfLocations { get; set; }
        public string Notes { get; set; }
        public string NotesDesc { get; set; }
        public string Warnings { get; set; }
        public string WarningsDesc { get; set; }
    }

    public class AGIReverseSearchResponseLocationsTypeItem
    {
        public int PrecisionLevel { get; set; }
        public string Type { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public AGIReverseSearchResponseLocationsTypeItemAddressComponentsType AddressComponents { get; set; }
    }

    public class AGIReverseSearchResponseLocationsTypeItemAddressComponentsType
    {
        public string PremiseNumber { get; set; }
        public string Thoroughfare { get; set; }
        public string DoubleDependentLocality { get; set; }
        public string DependentLocality { get; set; }
        public string Locality { get; set; }
        public string AdministrativeArea4 { get; set; }
        public string AdministrativeArea4Abbreviation { get; set; }
        public string AdministrativeArea3 { get; set; }
        public string AdministrativeArea3Abbreviation { get; set; }
        public string AdministrativeArea2 { get; set; }
        public string AdministrativeArea2Abbreviation { get; set; }
        public string AdministrativeArea1 { get; set; }
        public string AdministrativeArea1Abbreviation { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string CountryISO2 { get; set; }
        public string CountryISO3 { get; set; }
        public string BingMapsURL { get; set; }
        public string GoogleMapsURL { get; set; }
        public string MapQuestURL { get; set; }
        public string PlaceName { get; set; }
        public string IsUnincorporated { get; set; }
        public string StateFIPS { get; set; }
        public string CountyFIPS { get; set; }
        public string CensusTract { get; set; }
        public string CensusBlock { get; set; }

        [JsonProperty("CensusGeoID")]
        public string CensusGeoId { get; set; }
        public string ClassFP { get; set; }
        public string CongressCode { get; set; }
        public string SLDUST { get; set; }
        public string SLDLST { get; set; }

        [JsonProperty("TimeZone_UTC")]
        public string TimeZoneUTC { get; set; }
    }

    public class AGIReverseSearchResponseErrorType
    {
        public string Type { get; set; }
        public string TypeCode { get; set; }
        public string Desc { get; set; }
        public string DescCode { get; set; }
    }

    public class PE2IGetInternationalExchangeInfoResponse
    {
        public PE2IGetInternationalExchangeInfoResponseInternationalExchangeInfoType InternationalExchangeInfo { get; set; }
        public PE2IGetInternationalExchangeInfoResponseErrorType Error { get; set; }
        public string[] Debug { get; set; }
    }

    public class PE2IGetInternationalExchangeInfoResponseInternationalExchangeInfoType
    {
        public string NumberIn { get; set; }
        public string CountryCode { get; set; }
        public string FormatNational { get; set; }
        public string Extension { get; set; }
        public string Locality { get; set; }
        public string LocalityMatchLevel { get; set; }
        public string TimeZone { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Country { get; set; }
        public string CountryISO2 { get; set; }
        public string CountryISO3 { get; set; }
        public string FormatInternational { get; set; }
        public string FormatE164 { get; set; }
        public string Carrier { get; set; }
        public string LineType { get; set; }
        public string SMSAddress { get; set; }
        public string MMSAddress { get; set; }
        public bool IsValid { get; set; }
        public bool IsValidForRegion { get; set; }
        public string NoteCodes { get; set; }
        public string NoteDescriptions { get; set; }
    }

    public class PE2IGetInternationalExchangeInfoResponseErrorType
    {
        public string Type { get; set; }
        public string TypeCode { get; set; }
        public string Desc { get; set; }
        public string DescCode { get; set; }
    }

    public class LVIValidateLeadInternationalResponse
    {
        public string OverallCertainty { get; set; }
        public string OverallQuality { get; set; }
        public string LeadType { get; set; }
        public string LeadCountry { get; set; }
        public string NoteCodes { get; set; }
        public string NoteDesc { get; set; }
        public string NameCertainty { get; set; }
        public string NameQuality { get; set; }
        public string FirstNameLatin { get; set; }
        public string LastNameLatin { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NameNoteCodes { get; set; }
        public string NameNoteDesc { get; set; }
        public string AddressCertainty { get; set; }
        public string AddressQuality { get; set; }
        public string AddressResolutionLevel { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string AddressLine5 { get; set; }
        public string AddressLocality { get; set; }
        public string AddressAdminArea { get; set; }
        public string AddressPostalCode { get; set; }
        public string AddressCountry { get; set; }
        public string AddressNoteCodes { get; set; }
        public string AddressNoteDesc { get; set; }
        public string EmailCertainty { get; set; }
        public string EmailQuality { get; set; }
        public string EmailCorrected { get; set; }
        public string EmailNoteCodes { get; set; }
        public string EmailNoteDesc { get; set; }
        public string IPCertainty { get; set; }
        public string IPQuality { get; set; }
        public string IPLocality { get; set; }
        public string IPAdminArea { get; set; }
        public string IPCountry { get; set; }
        public string IPNoteCodes { get; set; }
        public string IPNoteDesc { get; set; }
        public string Phone1Certainty { get; set; }
        public string Phone1Quality { get; set; }
        public string Phone1Locality { get; set; }
        public string Phone1AdminArea { get; set; }
        public string Phone1Country { get; set; }
        public string Phone1NoteCodes { get; set; }
        public string Phone1NoteDesc { get; set; }
        public string Phone2Certainty { get; set; }
        public string Phone2Quality { get; set; }
        public string Phone2Locality { get; set; }
        public string Phone2AdminArea { get; set; }
        public string Phone2Country { get; set; }
        public string Phone2NoteCodes { get; set; }
        public string Phone2NoteDesc { get; set; }
        public LVIValidateLeadInternationalResponsePhoneContactType PhoneContact { get; set; }
        public string BusinessCertainty { get; set; }
        public string BusinessQuality { get; set; }
        public string BusinessName { get; set; }
        public string BusinessDomain { get; set; }
        public string BusinessEmail { get; set; }
        public string BusinessNoteCodes { get; set; }
        public string BusinessNoteDesc { get; set; }
        public LVIValidateLeadInternationalResponseInformationComponentsTypeItem[] InformationComponents { get; set; }
        public LVIValidateLeadInternationalResponseErrorType Error { get; set; }
        public string DEBUG { get; set; }
    }

    public class LVIValidateLeadInternationalResponsePhoneContactType
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Type { get; set; }
    }

    public class LVIValidateLeadInternationalResponseInformationComponentsTypeItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class LVIValidateLeadInternationalResponseErrorType
    {
        public string Type { get; set; }
        public string TypeCode { get; set; }
        public string Desc { get; set; }
        public string DescCode { get; set; }
    }

    public class AV3GetBestMatchesResponse
    {
        public AV3GetBestMatchesResponseAddressesTypeItem[] Addresses { get; set; }
        public AV3GetBestMatchesResponseErrorType Error { get; set; }
        public bool IsCASS { get; set; }
    }

    public class AV3GetBestMatchesResponseAddressesTypeItem
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string IsResidential { get; set; }
        public string DPV { get; set; }
        public string DPVDesc { get; set; }
        public string DPVNotes { get; set; }
        public string DPVNotesDesc { get; set; }
        public string Corrections { get; set; }
        public string CorrectionsDesc { get; set; }
        public string BarcodeDigits { get; set; }
        public string CarrierRoute { get; set; }
        public string CongressCode { get; set; }
        public string CountyCode { get; set; }
        public string CountyName { get; set; }
        public string FragmentHouse { get; set; }
        public string FragmentPreDir { get; set; }
        public string FragmentStreet { get; set; }
        public string FragmentSuffix { get; set; }
        public string FragmentPostDir { get; set; }
        public string FragmentUnit { get; set; }
        public string Fragment { get; set; }
        public string FragmentPMBPrefix { get; set; }
        public string FragmentPMBNumber { get; set; }
    }

    public class AV3GetBestMatchesResponseErrorType
    {
        public string Type { get; set; }
        public string TypeCode { get; set; }
        public string Desc { get; set; }
        public string DescCode { get; set; }
    }

    public class IPAVGetLocationByIPV4Response
    {
        public IPAVGetLocationByIPV4ResponseErrorType Error { get; set; }
        public int Certainty { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string CountryISO3 { get; set; }
        public string CountryISO2 { get; set; }
        public string PostalCode { get; set; }
        public string MetroCode { get; set; }
        public string DMA { get; set; }
        public string StateFIPS { get; set; }
        public string CountyFIPS { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string IsProxy { get; set; }
        public string ProxyType { get; set; }
        public string PossibleMobileDevice { get; set; }
        public string ISP { get; set; }
        public string NetblockOwner { get; set; }
        public string HostNames { get; set; }
        public string IPNoteCodes { get; set; }
        public string IPNotes { get; set; }
        public string Debug { get; set; }
    }

    public class IPAVGetLocationByIPV4ResponseErrorType
    {
        public string Desc { get; set; }
        public string Location { get; set; }
        public string Number { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Serviceobjects;

    public partial class WorkflowManagedActions
    {
        public ServiceobjectsActions Serviceobjects(string connectionId) => new ServiceobjectsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ServiceobjectsTriggers Serviceobjects(string connectionId) => new ServiceobjectsTriggers(connectionId);
    }
}