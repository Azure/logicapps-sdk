//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Veteransaffairsfacil
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VeteransaffairsfacilActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "veteransaffairsfacil")]
        [WorkflowExpressionFactory(nameof(__BuildGetFacilities))]
        public IBodyWorkflowAction<FacilitiesResponse> GetFacilities([WorkflowExpression] Func<string> facilityIds = null, [WorkflowExpression] Func<string> zip = null, [WorkflowExpression] Func<string> state = null, [WorkflowExpression] Func<double> lat = null, [WorkflowExpression] Func<double> @long = null, [WorkflowExpression] Func<double> radius = null, [WorkflowExpression] Func<string> bbox = null, [WorkflowExpression] Func<double> visn = null, [WorkflowExpression] Func<typeInput> type = null, [WorkflowExpression] Func<string> services = null, [WorkflowExpression] Func<bool> mobile = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FacilitiesResponse> __BuildGetFacilities(WorkflowExpression<string> facilityIds = null, WorkflowExpression<string> zip = null, WorkflowExpression<string> state = null, WorkflowExpression<double> lat = null, WorkflowExpression<double> @long = null, WorkflowExpression<double> radius = null, WorkflowExpression<string> bbox = null, WorkflowExpression<double> visn = null, WorkflowExpression<typeInput> type = null, WorkflowExpression<string> services = null, WorkflowExpression<bool> mobile = null, WorkflowExpression<int> page = null, WorkflowExpression<int> perPage = null)
        {
            WorkflowExpression.Validate(facilityIds, nameof(facilityIds), required: false);
            WorkflowExpression.Validate(zip, nameof(zip), required: false);
            WorkflowExpression.Validate(state, nameof(state), required: false);
            WorkflowExpression.Validate(lat, nameof(lat), required: false);
            WorkflowExpression.Validate(@long, nameof(@long), required: false);
            WorkflowExpression.Validate(radius, nameof(radius), required: false);
            WorkflowExpression.Validate(bbox, nameof(bbox), required: false);
            WorkflowExpression.Validate(visn, nameof(visn), required: false);
            WorkflowExpression.Validate(type, nameof(type), required: false);
            WorkflowExpression.Validate(services, nameof(services), required: false);
            WorkflowExpression.Validate(mobile, nameof(mobile), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<FacilitiesResponse>(() =>
            {
                var apiCallPath = "/facilities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (facilityIds != null)
                    callPayload.Queries["facilityIds"] = ExpressionConverter.Convert(facilityIds);
                if (zip != null)
                    callPayload.Queries["zip"] = ExpressionConverter.Convert(zip);
                if (state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(state);
                if (lat != null)
                    callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
                if (@long != null)
                    callPayload.Queries["long"] = ExpressionConverter.Convert(@long);
                if (radius != null)
                    callPayload.Queries["radius"] = ExpressionConverter.Convert(radius);
                if (bbox != null)
                    callPayload.Queries["bbox[]"] = ExpressionConverter.Convert(bbox);
                if (visn != null)
                    callPayload.Queries["visn"] = ExpressionConverter.Convert(visn);
                if (type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                if (services != null)
                    callPayload.Queries["services[]"] = ExpressionConverter.Convert(services);
                if (mobile != null)
                    callPayload.Queries["mobile"] = ExpressionConverter.Convert(mobile);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                return new ApiConnectionAction<FacilitiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "veteransaffairsfacil")]
        [WorkflowExpressionFactory(nameof(__BuildGetFacilityById))]
        public IBodyWorkflowAction<FacilityReadResponse> GetFacilityById([WorkflowExpression] Func<string> facilityId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FacilityReadResponse> __BuildGetFacilityById(WorkflowExpression<string> facilityId)
        {
            WorkflowExpression.Validate(facilityId, nameof(facilityId), required: true);
            return new DeferredBodyAction<FacilityReadResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/facilities/{0}", ExpressionConverter.ConvertWithUrlEncoding(facilityId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FacilityReadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "veteransaffairsfacil")]
        [WorkflowExpressionFactory(nameof(__BuildGetFacilityServicesById))]
        public IBodyWorkflowAction<DetailedServicesResponse> GetFacilityServicesById([WorkflowExpression] Func<string> facilityId, [WorkflowExpression] Func<string> serviceIds = null, [WorkflowExpression] Func<string> serviceType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DetailedServicesResponse> __BuildGetFacilityServicesById(WorkflowExpression<string> facilityId, WorkflowExpression<string> serviceIds = null, WorkflowExpression<string> serviceType = null)
        {
            WorkflowExpression.Validate(facilityId, nameof(facilityId), required: true);
            WorkflowExpression.Validate(serviceIds, nameof(serviceIds), required: false);
            WorkflowExpression.Validate(serviceType, nameof(serviceType), required: false);
            return new DeferredBodyAction<DetailedServicesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/facilities/{0}/services", ExpressionConverter.ConvertWithUrlEncoding(facilityId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (serviceIds != null)
                    callPayload.Queries["serviceIds"] = ExpressionConverter.Convert(serviceIds);
                if (serviceType != null)
                    callPayload.Queries["serviceType"] = ExpressionConverter.Convert(serviceType);
                return new ApiConnectionAction<DetailedServicesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "veteransaffairsfacil")]
        [WorkflowExpressionFactory(nameof(__BuildGetFacilityServiceById))]
        public IBodyWorkflowAction<DetailedServiceResponse> GetFacilityServiceById([WorkflowExpression] Func<string> facilityId, [WorkflowExpression] Func<string> serviceId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DetailedServiceResponse> __BuildGetFacilityServiceById(WorkflowExpression<string> facilityId, WorkflowExpression<string> serviceId)
        {
            WorkflowExpression.Validate(facilityId, nameof(facilityId), required: true);
            WorkflowExpression.Validate(serviceId, nameof(serviceId), required: true);
            return new DeferredBodyAction<DetailedServiceResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/facilities/{0}/services/{1}", ExpressionConverter.ConvertWithUrlEncoding(facilityId, 1), ExpressionConverter.ConvertWithUrlEncoding(serviceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DetailedServiceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "veteransaffairsfacil")]
        [WorkflowExpressionFactory(nameof(__BuildGetFacilityIds))]
        public IBodyWorkflowAction<FacilitiesIdsResponse> GetFacilityIds([WorkflowExpression] Func<typeInput> type = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FacilitiesIdsResponse> __BuildGetFacilityIds(WorkflowExpression<typeInput> type = null)
        {
            WorkflowExpression.Validate(type, nameof(type), required: false);
            return new DeferredBodyAction<FacilitiesIdsResponse>(() =>
            {
                var apiCallPath = "/ids";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                return new ApiConnectionAction<FacilitiesIdsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "veteransaffairsfacil")]
        [WorkflowExpressionFactory(nameof(__BuildGetNearbyFacilities))]
        public IBodyWorkflowAction<NearbyResponse> GetNearbyFacilities([WorkflowExpression] Func<double> lat, [WorkflowExpression] Func<double> @long, [WorkflowExpression] Func<int> driveTime = null, [WorkflowExpression] Func<string> services = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NearbyResponse> __BuildGetNearbyFacilities(WorkflowExpression<double> lat, WorkflowExpression<double> @long, WorkflowExpression<int> driveTime = null, WorkflowExpression<string> services = null, WorkflowExpression<int> page = null, WorkflowExpression<int> perPage = null)
        {
            WorkflowExpression.Validate(lat, nameof(lat), required: true);
            WorkflowExpression.Validate(@long, nameof(@long), required: true);
            WorkflowExpression.Validate(driveTime, nameof(driveTime), required: false);
            WorkflowExpression.Validate(services, nameof(services), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<NearbyResponse>(() =>
            {
                var apiCallPath = "/nearby";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["lat"] = ExpressionConverter.Convert(lat);
                callPayload.Queries["long"] = ExpressionConverter.Convert(@long);
                if (driveTime != null)
                    callPayload.Queries["drive_time"] = ExpressionConverter.Convert(driveTime);
                if (services != null)
                    callPayload.Queries["services[]"] = ExpressionConverter.Convert(services);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                return new ApiConnectionAction<NearbyResponse>(callPayload);
            });
        }
    }

    public class VeteransaffairsfacilTriggers([ConnectionName] string connectionId)
    {
    }

    public class FacilitiesResponse
    {
        [JsonProperty("data")]
        public Facility[] FacilitiesData { get; set; }

        [JsonProperty("links")]
        public PageLinks Links { get; set; }

        [JsonProperty("meta")]
        public FacilitiesMetadata Meta { get; set; }
    }

    public class Facility
    {
        [JsonProperty("attributes")]
        public FacilityAttributes Attributes { get; set; }

        [JsonProperty("id")]
        public string FacilityID { get; set; }

        [JsonProperty("type")]
        public FacilityFacilityTypeType FacilityType { get; set; }
    }

    public class FacilityAttributes
    {
        [JsonProperty("address")]
        public Addresses Address { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("facilityType")]
        public FacilityAttributesFacilityTypeType FacilityType { get; set; }

        [JsonProperty("hours")]
        public Hours Hours { get; set; }

        [JsonProperty("lat")]
        public double Latitude { get; set; }

        [JsonProperty("long")]
        public double Longitude { get; set; }

        [JsonProperty("mobile")]
        public bool MobileFacility { get; set; }

        [JsonProperty("name")]
        public string FacilityName { get; set; }

        [JsonProperty("operatingStatus")]
        public OperatingStatus OperatingStatus { get; set; }

        [JsonProperty("operationalHoursSpecialInstructions")]
        public string[] SpecialOperatingHours { get; set; }

        [JsonProperty("parent")]
        public Parent Parent { get; set; }

        [JsonProperty("phone")]
        public Phone Phone { get; set; }

        [JsonProperty("satisfaction")]
        public Satisfaction Satisfaction { get; set; }

        [JsonProperty("services")]
        public Services Services { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("visn")]
        public string VISN { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }
    }

    public class Addresses
    {
        [JsonProperty("mailing")]
        public Address Mailing { get; set; }

        [JsonProperty("physical")]
        public Address Physical { get; set; }
    }

    public class Address
    {
        [JsonProperty("address1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("address3")]
        public string AddressLine3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string ZIPCode { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FacilityAttributesFacilityTypeType
    {
        [EnumMember(Value = "va_benefits_facility")]
        VaBenefitsFacility,
        [EnumMember(Value = "va_cemetery")]
        VaCemetery,
        [EnumMember(Value = "va_health_facility")]
        VaHealthFacility,
        [EnumMember(Value = "vet_center")]
        VetCenter
    }

    public class Hours
    {
        [JsonProperty("friday")]
        public string FridayHours { get; set; }

        [JsonProperty("monday")]
        public string MondayHours { get; set; }

        [JsonProperty("saturday")]
        public string SaturdayHours { get; set; }

        [JsonProperty("sunday")]
        public string SundayHours { get; set; }

        [JsonProperty("thursday")]
        public string ThursdayHours { get; set; }

        [JsonProperty("tuesday")]
        public string TuesdayHours { get; set; }

        [JsonProperty("wednesday")]
        public string WednesdayHours { get; set; }
    }

    public class OperatingStatus
    {
        [JsonProperty("additionalInfo")]
        public string AdditionalInformation { get; set; }

        [JsonProperty("code")]
        public OperatingStatusStatusCodeType StatusCode { get; set; }

        [JsonProperty("supplementalStatus")]
        public SupplementalStatus[] SupplementalStatus { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OperatingStatusStatusCodeType
    {
        NORMAL,
        NOTICE,
        LIMITED,
        CLOSED
    }

    public class SupplementalStatus
    {
        [JsonProperty("id")]
        public string StatusID { get; set; }

        [JsonProperty("label")]
        public string StatusLabel { get; set; }
    }

    public class Parent
    {
        [JsonProperty("id")]
        public string ParentFacilityID { get; set; }

        [JsonProperty("link")]
        public string ParentFacilityAPILink { get; set; }
    }

    public class Phone
    {
        [JsonProperty("afterHours")]
        public string AfterHours { get; set; }

        [JsonProperty("enrollmentCoordinator")]
        public string EnrollmentCoordinator { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("healthConnect")]
        public string VAHealthConnect { get; set; }

        [JsonProperty("main")]
        public string MainContact { get; set; }

        [JsonProperty("mentalHealthClinic")]
        public string MentalHealthClinic { get; set; }

        [JsonProperty("patientAdvocate")]
        public string PatientAdvocate { get; set; }

        [JsonProperty("pharmacy")]
        public string Pharmacy { get; set; }
    }

    public class Satisfaction
    {
        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }

        [JsonProperty("health")]
        public PatientSatisfaction Health { get; set; }
    }

    public class PatientSatisfaction
    {
        [JsonProperty("primaryCareRoutine")]
        public double PrimaryCareRoutine { get; set; }

        [JsonProperty("primaryCareUrgent")]
        public double PrimaryCareUrgent { get; set; }

        [JsonProperty("specialtyCareRoutine")]
        public double SpecialtyCareRoutine { get; set; }

        [JsonProperty("specialtyCareUrgent")]
        public double SpecialtyCareUrgent { get; set; }
    }

    public class Services
    {
        [JsonProperty("benefits")]
        public ServiceBenefitsService[] BenefitsServices { get; set; }

        [JsonProperty("health")]
        public ServiceHealthService[] HealthServices { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }

        [JsonProperty("link")]
        public string ServicesLink { get; set; }

        [JsonProperty("other")]
        public ServiceOtherService[] OtherServices { get; set; }
    }

    public class ServiceBenefitsService
    {
        [JsonProperty("link")]
        public string ServiceLink { get; set; }

        [JsonProperty("name")]
        public string ServiceName { get; set; }

        [JsonProperty("serviceId")]
        public string ServiceID { get; set; }
    }

    public class ServiceHealthService
    {
        [JsonProperty("link")]
        public string ServiceLink { get; set; }

        [JsonProperty("name")]
        public string ServiceName { get; set; }

        [JsonProperty("serviceId")]
        public string ServiceID { get; set; }
    }

    public class ServiceOtherService
    {
        [JsonProperty("link")]
        public string ServiceLink { get; set; }

        [JsonProperty("name")]
        public string ServiceName { get; set; }

        [JsonProperty("serviceId")]
        public string ServiceID { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FacilityFacilityTypeType
    {
        [EnumMember(Value = "va_facilities")]
        VaFacilities
    }

    public class PageLinks
    {
        [JsonProperty("first")]
        public string FirstPageLink { get; set; }

        [JsonProperty("last")]
        public string LastPageLink { get; set; }

        [JsonProperty("next")]
        public string NextPageLink { get; set; }

        [JsonProperty("prev")]
        public string PreviousPageLink { get; set; }

        [JsonProperty("related")]
        public string RelatedLink { get; set; }

        [JsonProperty("self")]
        public string CurrentPageLink { get; set; }
    }

    public class FacilitiesMetadata
    {
        [JsonProperty("distances")]
        public Distance[] DistancesToFacilities { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class Distance
    {
        [JsonProperty("distance")]
        public double DistanceInMiles { get; set; }

        [JsonProperty("id")]
        public string FacilityID { get; set; }
    }

    public class Pagination
    {
        [JsonProperty("currentPage")]
        public int CurrentPage { get; set; }

        [JsonProperty("perPage")]
        public int ResultsPerPage { get; set; }

        [JsonProperty("totalEntries")]
        public int TotalEntries { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum typeInput
    {
        [EnumMember(Value = "health")]
        Health,
        [EnumMember(Value = "cemetery")]
        Cemetery,
        [EnumMember(Value = "benefits")]
        Benefits,
        [EnumMember(Value = "vet_center")]
        VetCenter
    }

    public class FacilityReadResponse
    {
        [JsonProperty("data")]
        public Facility Data { get; set; }
    }

    public class DetailedServicesResponse
    {
        [JsonProperty("data")]
        public DetailedService[] ServicesList { get; set; }

        [JsonProperty("links")]
        public PageLinks Links { get; set; }

        [JsonProperty("meta")]
        public DetailedServicesMetadata Meta { get; set; }
    }

    public class DetailedService
    {
        [JsonProperty("appointmentLeadIn")]
        public string AppointmentLeadIn { get; set; }

        [JsonProperty("appointmentPhones")]
        public AppointmentPhoneNumber[] AppointmentPhones { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }

        [JsonProperty("name")]
        public string ServiceName { get; set; }

        [JsonProperty("serviceId")]
        public string ServiceID { get; set; }

        [JsonProperty("path")]
        public string ServiceDetailsPath { get; set; }

        [JsonProperty("serviceInfo")]
        public ServiceInfo ServiceInfo { get; set; }

        [JsonProperty("serviceLocations")]
        public DetailedServiceLocation[] ServiceLocations { get; set; }

        [JsonProperty("waitTime")]
        public PatientWaitTime WaitTime { get; set; }
    }

    public class AppointmentPhoneNumber
    {
        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ServiceInfo
    {
        [JsonProperty("name")]
        public string ServiceName { get; set; }

        [JsonProperty("serviceId")]
        public string ServiceID { get; set; }

        [JsonProperty("serviceType")]
        public ServiceInfoServiceTypeType ServiceType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ServiceInfoServiceTypeType
    {
        [EnumMember(Value = "benefits")]
        Benefits,
        [EnumMember(Value = "health")]
        Health,
        [EnumMember(Value = "other")]
        Other
    }

    public class DetailedServiceLocation
    {
        [JsonProperty("additionalHoursInfo")]
        public string AdditionalHoursInformation { get; set; }

        [JsonProperty("emailContacts")]
        public DetailedServiceEmailContact[] EmailContacts { get; set; }

        [JsonProperty("officeName")]
        public string OfficeName { get; set; }

        [JsonProperty("onlineSchedulingAvailable")]
        public string OnlineSchedulingAvailability { get; set; }

        [JsonProperty("phones")]
        public AppointmentPhoneNumber[] PhoneContacts { get; set; }

        [JsonProperty("referralRequired")]
        public string ReferralRequirement { get; set; }

        [JsonProperty("serviceAddress")]
        public DetailedServiceAddress ServiceAddress { get; set; }

        [JsonProperty("serviceHours")]
        public DetailedServiceHours ServiceHours { get; set; }

        [JsonProperty("walkInsAccepted")]
        public string WalkInsAccepted { get; set; }
    }

    public class DetailedServiceEmailContact
    {
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("emailLabel")]
        public string EmailLabel { get; set; }
    }

    public class DetailedServiceAddress
    {
        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("buildingNameNumber")]
        public string BuildingNameNumber { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("wingFloorOrRoomNumber")]
        public string WingFloorRoomNumber { get; set; }

        [JsonProperty("zipCode")]
        public string ZIPCode { get; set; }
    }

    public class DetailedServiceHours
    {
        [JsonProperty("friday")]
        public string Friday { get; set; }

        [JsonProperty("monday")]
        public string Monday { get; set; }

        [JsonProperty("saturday")]
        public string Saturday { get; set; }

        [JsonProperty("sunday")]
        public string Sunday { get; set; }

        [JsonProperty("thursday")]
        public string Thursday { get; set; }

        [JsonProperty("tuesday")]
        public string Tuesday { get; set; }

        [JsonProperty("wednesday")]
        public string Wednesday { get; set; }
    }

    public class PatientWaitTime
    {
        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }

        [JsonProperty("established")]
        public double EstablishedPatientWaitTime { get; set; }

        [JsonProperty("new")]
        public double NewPatientWaitTime { get; set; }
    }

    public class DetailedServicesMetadata
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class DetailedServiceResponse
    {
        [JsonProperty("data")]
        public DetailedService Data { get; set; }
    }

    public class FacilitiesIdsResponse
    {
        [JsonProperty("data")]
        public string[] FacilityIDs { get; set; }
    }

    public class NearbyResponse
    {
        [JsonProperty("data")]
        public Nearby[] NearbyFacilitiesData { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }

    public class Nearby
    {
        [JsonProperty("attributes")]
        public NearbyAttributes Attributes { get; set; }

        [JsonProperty("id")]
        public string FacilityID { get; set; }

        [JsonProperty("type")]
        public NearbyFacilityTypeType FacilityType { get; set; }
    }

    public class NearbyAttributes
    {
        [JsonProperty("maxTime")]
        public int MaximumTime { get; set; }

        [JsonProperty("minTime")]
        public int MinimumTime { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NearbyFacilityTypeType
    {
        [EnumMember(Value = "nearby_facility")]
        NearbyFacility
    }

    public class Meta
    {
        [JsonProperty("bandVersion")]
        public string BandVersion { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Veteransaffairsfacil;

    public partial class WorkflowManagedActions
    {
        public VeteransaffairsfacilActions Veteransaffairsfacil(string connectionId) => new VeteransaffairsfacilActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public VeteransaffairsfacilTriggers Veteransaffairsfacil(string connectionId) => new VeteransaffairsfacilTriggers(connectionId);
    }
}