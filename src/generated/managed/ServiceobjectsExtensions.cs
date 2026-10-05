//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Serviceobjects
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ServiceobjectsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serviceobjects")]
        [WorkflowExpressionFactory(nameof(__BuildAVIGetAddressInfo))]
        public IBodyWorkflowAction<AVIGetAddressInfoResponse> AVIGetAddressInfo([WorkflowExpression] Func<string> address1 = null, [WorkflowExpression] Func<string> address2 = null, [WorkflowExpression] Func<string> address3 = null, [WorkflowExpression] Func<string> address4 = null, [WorkflowExpression] Func<string> address5 = null, [WorkflowExpression] Func<string> locality = null, [WorkflowExpression] Func<string> administrativeArea = null, [WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<string> outputLanguage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AVIGetAddressInfoResponse> __BuildAVIGetAddressInfo(WorkflowValue<string> address1 = null, WorkflowValue<string> address2 = null, WorkflowValue<string> address3 = null, WorkflowValue<string> address4 = null, WorkflowValue<string> address5 = null, WorkflowValue<string> locality = null, WorkflowValue<string> administrativeArea = null, WorkflowValue<string> postalCode = null, WorkflowValue<string> country = null, WorkflowValue<string> outputLanguage = null)
        {
            WorkflowValue.Validate(address1, nameof(address1), required: false);
            WorkflowValue.Validate(address2, nameof(address2), required: false);
            WorkflowValue.Validate(address3, nameof(address3), required: false);
            WorkflowValue.Validate(address4, nameof(address4), required: false);
            WorkflowValue.Validate(address5, nameof(address5), required: false);
            WorkflowValue.Validate(locality, nameof(locality), required: false);
            WorkflowValue.Validate(administrativeArea, nameof(administrativeArea), required: false);
            WorkflowValue.Validate(postalCode, nameof(postalCode), required: false);
            WorkflowValue.Validate(country, nameof(country), required: false);
            WorkflowValue.Validate(outputLanguage, nameof(outputLanguage), required: false);
            return new DeferredBodyAction<AVIGetAddressInfoResponse>(() =>
            {
                var apiCallPath = "/AVI/api.svc/json/GetAddressInfo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (address1 != null)
                    callPayload.Queries["Address1"] = ExpressionConverter.Convert(address1);
                if (address2 != null)
                    callPayload.Queries["Address2"] = ExpressionConverter.Convert(address2);
                if (address3 != null)
                    callPayload.Queries["Address3"] = ExpressionConverter.Convert(address3);
                if (address4 != null)
                    callPayload.Queries["Address4"] = ExpressionConverter.Convert(address4);
                if (address5 != null)
                    callPayload.Queries["Address5"] = ExpressionConverter.Convert(address5);
                if (locality != null)
                    callPayload.Queries["Locality"] = ExpressionConverter.Convert(locality);
                if (administrativeArea != null)
                    callPayload.Queries["AdministrativeArea"] = ExpressionConverter.Convert(administrativeArea);
                if (postalCode != null)
                    callPayload.Queries["PostalCode"] = ExpressionConverter.Convert(postalCode);
                if (country != null)
                    callPayload.Queries["Country"] = ExpressionConverter.Convert(country);
                if (outputLanguage != null)
                    callPayload.Queries["OutputLanguage"] = ExpressionConverter.Convert(outputLanguage);
                return new ApiConnectionAction<AVIGetAddressInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serviceobjects")]
        [WorkflowExpressionFactory(nameof(__BuildAGIPlaceSearch))]
        public IBodyWorkflowAction<AGIPlaceSearchResponse> AGIPlaceSearch([WorkflowExpression] Func<string> singleLine = null, [WorkflowExpression] Func<string> address1 = null, [WorkflowExpression] Func<string> address2 = null, [WorkflowExpression] Func<string> address3 = null, [WorkflowExpression] Func<string> address4 = null, [WorkflowExpression] Func<string> address5 = null, [WorkflowExpression] Func<string> locality = null, [WorkflowExpression] Func<string> administrativeArea = null, [WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<string> boundaries = null, [WorkflowExpression] Func<string> maxResults = null, [WorkflowExpression] Func<string> searchType = null, [WorkflowExpression] Func<string> extras = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AGIPlaceSearchResponse> __BuildAGIPlaceSearch(WorkflowValue<string> singleLine = null, WorkflowValue<string> address1 = null, WorkflowValue<string> address2 = null, WorkflowValue<string> address3 = null, WorkflowValue<string> address4 = null, WorkflowValue<string> address5 = null, WorkflowValue<string> locality = null, WorkflowValue<string> administrativeArea = null, WorkflowValue<string> postalCode = null, WorkflowValue<string> country = null, WorkflowValue<string> boundaries = null, WorkflowValue<string> maxResults = null, WorkflowValue<string> searchType = null, WorkflowValue<string> extras = null)
        {
            WorkflowValue.Validate(singleLine, nameof(singleLine), required: false);
            WorkflowValue.Validate(address1, nameof(address1), required: false);
            WorkflowValue.Validate(address2, nameof(address2), required: false);
            WorkflowValue.Validate(address3, nameof(address3), required: false);
            WorkflowValue.Validate(address4, nameof(address4), required: false);
            WorkflowValue.Validate(address5, nameof(address5), required: false);
            WorkflowValue.Validate(locality, nameof(locality), required: false);
            WorkflowValue.Validate(administrativeArea, nameof(administrativeArea), required: false);
            WorkflowValue.Validate(postalCode, nameof(postalCode), required: false);
            WorkflowValue.Validate(country, nameof(country), required: false);
            WorkflowValue.Validate(boundaries, nameof(boundaries), required: false);
            WorkflowValue.Validate(maxResults, nameof(maxResults), required: false);
            WorkflowValue.Validate(searchType, nameof(searchType), required: false);
            WorkflowValue.Validate(extras, nameof(extras), required: false);
            return new DeferredBodyAction<AGIPlaceSearchResponse>(() =>
            {
                var apiCallPath = "/AGI/api.svc/json/PlaceSearch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (singleLine != null)
                    callPayload.Queries["SingleLine"] = ExpressionConverter.Convert(singleLine);
                if (address1 != null)
                    callPayload.Queries["Address1"] = ExpressionConverter.Convert(address1);
                if (address2 != null)
                    callPayload.Queries["Address2"] = ExpressionConverter.Convert(address2);
                if (address3 != null)
                    callPayload.Queries["Address3"] = ExpressionConverter.Convert(address3);
                if (address4 != null)
                    callPayload.Queries["Address4"] = ExpressionConverter.Convert(address4);
                if (address5 != null)
                    callPayload.Queries["Address5"] = ExpressionConverter.Convert(address5);
                if (locality != null)
                    callPayload.Queries["Locality"] = ExpressionConverter.Convert(locality);
                if (administrativeArea != null)
                    callPayload.Queries["AdministrativeArea"] = ExpressionConverter.Convert(administrativeArea);
                if (postalCode != null)
                    callPayload.Queries["PostalCode"] = ExpressionConverter.Convert(postalCode);
                if (country != null)
                    callPayload.Queries["Country"] = ExpressionConverter.Convert(country);
                if (boundaries != null)
                    callPayload.Queries["Boundaries"] = ExpressionConverter.Convert(boundaries);
                if (maxResults != null)
                    callPayload.Queries["MaxResults"] = ExpressionConverter.Convert(maxResults);
                if (searchType != null)
                    callPayload.Queries["SearchType"] = ExpressionConverter.Convert(searchType);
                if (extras != null)
                    callPayload.Queries["Extras"] = ExpressionConverter.Convert(extras);
                return new ApiConnectionAction<AGIPlaceSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serviceobjects")]
        [WorkflowExpressionFactory(nameof(__BuildAGIReverseSearch))]
        public IBodyWorkflowAction<AGIReverseSearchResponse> AGIReverseSearch([WorkflowExpression] Func<string> latitude = null, [WorkflowExpression] Func<string> longitude = null, [WorkflowExpression] Func<string> searchRadius = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<string> maxResults = null, [WorkflowExpression] Func<string> searchType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AGIReverseSearchResponse> __BuildAGIReverseSearch(WorkflowValue<string> latitude = null, WorkflowValue<string> longitude = null, WorkflowValue<string> searchRadius = null, WorkflowValue<string> country = null, WorkflowValue<string> maxResults = null, WorkflowValue<string> searchType = null)
        {
            WorkflowValue.Validate(latitude, nameof(latitude), required: false);
            WorkflowValue.Validate(longitude, nameof(longitude), required: false);
            WorkflowValue.Validate(searchRadius, nameof(searchRadius), required: false);
            WorkflowValue.Validate(country, nameof(country), required: false);
            WorkflowValue.Validate(maxResults, nameof(maxResults), required: false);
            WorkflowValue.Validate(searchType, nameof(searchType), required: false);
            return new DeferredBodyAction<AGIReverseSearchResponse>(() =>
            {
                var apiCallPath = "/AGI/api.svc/json/ReverseSearch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (latitude != null)
                    callPayload.Queries["Latitude"] = ExpressionConverter.Convert(latitude);
                if (longitude != null)
                    callPayload.Queries["Longitude"] = ExpressionConverter.Convert(longitude);
                if (searchRadius != null)
                    callPayload.Queries["SearchRadius"] = ExpressionConverter.Convert(searchRadius);
                if (country != null)
                    callPayload.Queries["Country"] = ExpressionConverter.Convert(country);
                if (maxResults != null)
                    callPayload.Queries["MaxResults"] = ExpressionConverter.Convert(maxResults);
                if (searchType != null)
                    callPayload.Queries["SearchType"] = ExpressionConverter.Convert(searchType);
                return new ApiConnectionAction<AGIReverseSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serviceobjects")]
        [WorkflowExpressionFactory(nameof(__BuildPE2IGetInternationalExchangeInfo))]
        public IBodyWorkflowAction<PE2IGetInternationalExchangeInfoResponse> PE2IGetInternationalExchangeInfo([WorkflowExpression] Func<string> phoneNumber = null, [WorkflowExpression] Func<string> country = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PE2IGetInternationalExchangeInfoResponse> __BuildPE2IGetInternationalExchangeInfo(WorkflowValue<string> phoneNumber = null, WorkflowValue<string> country = null)
        {
            WorkflowValue.Validate(phoneNumber, nameof(phoneNumber), required: false);
            WorkflowValue.Validate(country, nameof(country), required: false);
            return new DeferredBodyAction<PE2IGetInternationalExchangeInfoResponse>(() =>
            {
                var apiCallPath = "/PE2/web.svc/json/GetInternationalExchangeInfo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (phoneNumber != null)
                    callPayload.Queries["PhoneNumber"] = ExpressionConverter.Convert(phoneNumber);
                if (country != null)
                    callPayload.Queries["Country"] = ExpressionConverter.Convert(country);
                return new ApiConnectionAction<PE2IGetInternationalExchangeInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serviceobjects")]
        [WorkflowExpressionFactory(nameof(__BuildLVIValidateLeadInternational))]
        public IBodyWorkflowAction<LVIValidateLeadInternationalResponse> LVIValidateLeadInternational([WorkflowExpression] Func<string> fullName = null, [WorkflowExpression] Func<string> salutation = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> lastName = null, [WorkflowExpression] Func<string> businessName = null, [WorkflowExpression] Func<string> businessDomain = null, [WorkflowExpression] Func<string> businessEIN = null, [WorkflowExpression] Func<string> address1 = null, [WorkflowExpression] Func<string> address2 = null, [WorkflowExpression] Func<string> address3 = null, [WorkflowExpression] Func<string> address4 = null, [WorkflowExpression] Func<string> address5 = null, [WorkflowExpression] Func<string> locality = null, [WorkflowExpression] Func<string> adminArea = null, [WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<string> phone1 = null, [WorkflowExpression] Func<string> phone2 = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> iPAddress = null, [WorkflowExpression] Func<string> gender = null, [WorkflowExpression] Func<string> dateOfBirth = null, [WorkflowExpression] Func<string> uTCCaptureTime = null, [WorkflowExpression] Func<string> outputLanguage = null, [WorkflowExpression] Func<string> testType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LVIValidateLeadInternationalResponse> __BuildLVIValidateLeadInternational(WorkflowValue<string> fullName = null, WorkflowValue<string> salutation = null, WorkflowValue<string> firstName = null, WorkflowValue<string> lastName = null, WorkflowValue<string> businessName = null, WorkflowValue<string> businessDomain = null, WorkflowValue<string> businessEIN = null, WorkflowValue<string> address1 = null, WorkflowValue<string> address2 = null, WorkflowValue<string> address3 = null, WorkflowValue<string> address4 = null, WorkflowValue<string> address5 = null, WorkflowValue<string> locality = null, WorkflowValue<string> adminArea = null, WorkflowValue<string> postalCode = null, WorkflowValue<string> country = null, WorkflowValue<string> phone1 = null, WorkflowValue<string> phone2 = null, WorkflowValue<string> email = null, WorkflowValue<string> iPAddress = null, WorkflowValue<string> gender = null, WorkflowValue<string> dateOfBirth = null, WorkflowValue<string> uTCCaptureTime = null, WorkflowValue<string> outputLanguage = null, WorkflowValue<string> testType = null)
        {
            WorkflowValue.Validate(fullName, nameof(fullName), required: false);
            WorkflowValue.Validate(salutation, nameof(salutation), required: false);
            WorkflowValue.Validate(firstName, nameof(firstName), required: false);
            WorkflowValue.Validate(lastName, nameof(lastName), required: false);
            WorkflowValue.Validate(businessName, nameof(businessName), required: false);
            WorkflowValue.Validate(businessDomain, nameof(businessDomain), required: false);
            WorkflowValue.Validate(businessEIN, nameof(businessEIN), required: false);
            WorkflowValue.Validate(address1, nameof(address1), required: false);
            WorkflowValue.Validate(address2, nameof(address2), required: false);
            WorkflowValue.Validate(address3, nameof(address3), required: false);
            WorkflowValue.Validate(address4, nameof(address4), required: false);
            WorkflowValue.Validate(address5, nameof(address5), required: false);
            WorkflowValue.Validate(locality, nameof(locality), required: false);
            WorkflowValue.Validate(adminArea, nameof(adminArea), required: false);
            WorkflowValue.Validate(postalCode, nameof(postalCode), required: false);
            WorkflowValue.Validate(country, nameof(country), required: false);
            WorkflowValue.Validate(phone1, nameof(phone1), required: false);
            WorkflowValue.Validate(phone2, nameof(phone2), required: false);
            WorkflowValue.Validate(email, nameof(email), required: false);
            WorkflowValue.Validate(iPAddress, nameof(iPAddress), required: false);
            WorkflowValue.Validate(gender, nameof(gender), required: false);
            WorkflowValue.Validate(dateOfBirth, nameof(dateOfBirth), required: false);
            WorkflowValue.Validate(uTCCaptureTime, nameof(uTCCaptureTime), required: false);
            WorkflowValue.Validate(outputLanguage, nameof(outputLanguage), required: false);
            WorkflowValue.Validate(testType, nameof(testType), required: false);
            return new DeferredBodyAction<LVIValidateLeadInternationalResponse>(() =>
            {
                var apiCallPath = "/LVI/api.svc/json/ValidateLeadInternational";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fullName != null)
                    callPayload.Queries["FullName"] = ExpressionConverter.Convert(fullName);
                if (salutation != null)
                    callPayload.Queries["Salutation"] = ExpressionConverter.Convert(salutation);
                if (firstName != null)
                    callPayload.Queries["FirstName"] = ExpressionConverter.Convert(firstName);
                if (lastName != null)
                    callPayload.Queries["LastName"] = ExpressionConverter.Convert(lastName);
                if (businessName != null)
                    callPayload.Queries["BusinessName"] = ExpressionConverter.Convert(businessName);
                if (businessDomain != null)
                    callPayload.Queries["BusinessDomain"] = ExpressionConverter.Convert(businessDomain);
                if (businessEIN != null)
                    callPayload.Queries["BusinessEIN"] = ExpressionConverter.Convert(businessEIN);
                if (address1 != null)
                    callPayload.Queries["Address1"] = ExpressionConverter.Convert(address1);
                if (address2 != null)
                    callPayload.Queries["Address2"] = ExpressionConverter.Convert(address2);
                if (address3 != null)
                    callPayload.Queries["Address3"] = ExpressionConverter.Convert(address3);
                if (address4 != null)
                    callPayload.Queries["Address4"] = ExpressionConverter.Convert(address4);
                if (address5 != null)
                    callPayload.Queries["Address5"] = ExpressionConverter.Convert(address5);
                if (locality != null)
                    callPayload.Queries["Locality"] = ExpressionConverter.Convert(locality);
                if (adminArea != null)
                    callPayload.Queries["AdminArea"] = ExpressionConverter.Convert(adminArea);
                if (postalCode != null)
                    callPayload.Queries["PostalCode"] = ExpressionConverter.Convert(postalCode);
                if (country != null)
                    callPayload.Queries["Country"] = ExpressionConverter.Convert(country);
                if (phone1 != null)
                    callPayload.Queries["Phone1"] = ExpressionConverter.Convert(phone1);
                if (phone2 != null)
                    callPayload.Queries["Phone2"] = ExpressionConverter.Convert(phone2);
                if (email != null)
                    callPayload.Queries["Email"] = ExpressionConverter.Convert(email);
                if (iPAddress != null)
                    callPayload.Queries["IPAddress"] = ExpressionConverter.Convert(iPAddress);
                if (gender != null)
                    callPayload.Queries["Gender"] = ExpressionConverter.Convert(gender);
                if (dateOfBirth != null)
                    callPayload.Queries["DateOfBirth"] = ExpressionConverter.Convert(dateOfBirth);
                if (uTCCaptureTime != null)
                    callPayload.Queries["UTCCaptureTime"] = ExpressionConverter.Convert(uTCCaptureTime);
                if (outputLanguage != null)
                    callPayload.Queries["OutputLanguage"] = ExpressionConverter.Convert(outputLanguage);
                if (testType != null)
                    callPayload.Queries["TestType"] = ExpressionConverter.Convert(testType);
                return new ApiConnectionAction<LVIValidateLeadInternationalResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serviceobjects")]
        [WorkflowExpressionFactory(nameof(__BuildAV3GetBestMatches))]
        public IBodyWorkflowAction<AV3GetBestMatchesResponse> AV3GetBestMatches([WorkflowExpression] Func<string> businessName = null, [WorkflowExpression] Func<string> address = null, [WorkflowExpression] Func<string> address2 = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<string> state = null, [WorkflowExpression] Func<string> postalCode = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AV3GetBestMatchesResponse> __BuildAV3GetBestMatches(WorkflowValue<string> businessName = null, WorkflowValue<string> address = null, WorkflowValue<string> address2 = null, WorkflowValue<string> city = null, WorkflowValue<string> state = null, WorkflowValue<string> postalCode = null)
        {
            WorkflowValue.Validate(businessName, nameof(businessName), required: false);
            WorkflowValue.Validate(address, nameof(address), required: false);
            WorkflowValue.Validate(address2, nameof(address2), required: false);
            WorkflowValue.Validate(city, nameof(city), required: false);
            WorkflowValue.Validate(state, nameof(state), required: false);
            WorkflowValue.Validate(postalCode, nameof(postalCode), required: false);
            return new DeferredBodyAction<AV3GetBestMatchesResponse>(() =>
            {
                var apiCallPath = "/AV3/api.svc/GetBestMatchesJson";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (businessName != null)
                    callPayload.Queries["BusinessName"] = ExpressionConverter.Convert(businessName);
                if (address != null)
                    callPayload.Queries["Address"] = ExpressionConverter.Convert(address);
                if (address2 != null)
                    callPayload.Queries["Address2"] = ExpressionConverter.Convert(address2);
                if (city != null)
                    callPayload.Queries["City"] = ExpressionConverter.Convert(city);
                if (state != null)
                    callPayload.Queries["State"] = ExpressionConverter.Convert(state);
                if (postalCode != null)
                    callPayload.Queries["PostalCode"] = ExpressionConverter.Convert(postalCode);
                return new ApiConnectionAction<AV3GetBestMatchesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serviceobjects")]
        [WorkflowExpressionFactory(nameof(__BuildIPAVGetLocationByIP))]
        public IBodyWorkflowAction<IPAVGetLocationByIPV4Response> IPAVGetLocationByIP([WorkflowExpression] Func<string> iPAddress = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IPAVGetLocationByIPV4Response> __BuildIPAVGetLocationByIP(WorkflowValue<string> iPAddress = null)
        {
            WorkflowValue.Validate(iPAddress, nameof(iPAddress), required: false);
            return new DeferredBodyAction<IPAVGetLocationByIPV4Response>(() =>
            {
                var apiCallPath = "/GPP/web.svc/json/GetLocationByIP_V4";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (iPAddress != null)
                    callPayload.Queries["IPAddress"] = ExpressionConverter.Convert(iPAddress);
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
        public string CensusGeoID { get; set; }
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
        public string CensusGeoID { get; set; }
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
