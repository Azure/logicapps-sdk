//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Veteransaffairsprovi
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VeteransaffairsproviActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "veteransaffairsprovi")]
        public IBodyWorkflowAction<LocationBundle> GetLocation(Expression<Func<string>> Id = null, Expression<Func<string>> identifier = null, Expression<Func<string>> address = null, Expression<Func<string>> addressCity = null, Expression<Func<string>> addressState = null, Expression<Func<string>> addressPostalcode = null, Expression<Func<string>> name = null, Expression<Func<string>> LastUpdated = null, Expression<Func<int>> page = null, Expression<Func<int>> Count = null)
        {
            var apiCallPath = "/Location";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (Id != null)
                callPayload.Queries["_id"] = CSharpExpressionConverter.ConvertO(Id);
            if (identifier != null)
                callPayload.Queries["identifier"] = CSharpExpressionConverter.ConvertO(identifier);
            if (address != null)
                callPayload.Queries["address"] = CSharpExpressionConverter.ConvertO(address);
            if (addressCity != null)
                callPayload.Queries["address-city"] = CSharpExpressionConverter.ConvertO(addressCity);
            if (addressState != null)
                callPayload.Queries["address-state"] = CSharpExpressionConverter.ConvertO(addressState);
            if (addressPostalcode != null)
                callPayload.Queries["address-postalcode"] = CSharpExpressionConverter.ConvertO(addressPostalcode);
            if (name != null)
                callPayload.Queries["name"] = CSharpExpressionConverter.ConvertO(name);
            if (LastUpdated != null)
                callPayload.Queries["_lastUpdated"] = CSharpExpressionConverter.ConvertO(LastUpdated);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (Count != null)
                callPayload.Queries["_count"] = CSharpExpressionConverter.ConvertO(Count);
            return new ApiConnectionAction<LocationBundle>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "veteransaffairsprovi")]
        public IBodyWorkflowAction<Location> GetLocationById(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Location/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Location>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "veteransaffairsprovi")]
        public IBodyWorkflowAction<OrganizationBundle> ListOrganizations(Expression<Func<string>> Id = null, Expression<Func<string>> identifier = null, Expression<Func<string>> address = null, Expression<Func<string>> addressCity = null, Expression<Func<string>> addressState = null, Expression<Func<string>> addressPostalcode = null, Expression<Func<string>> name = null, Expression<Func<string>> LastUpdated = null, Expression<Func<int>> page = null, Expression<Func<int>> Count = null)
        {
            var apiCallPath = "/Organization";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (Id != null)
                callPayload.Queries["_id"] = CSharpExpressionConverter.ConvertO(Id);
            if (identifier != null)
                callPayload.Queries["identifier"] = CSharpExpressionConverter.ConvertO(identifier);
            if (address != null)
                callPayload.Queries["address"] = CSharpExpressionConverter.ConvertO(address);
            if (addressCity != null)
                callPayload.Queries["address-city"] = CSharpExpressionConverter.ConvertO(addressCity);
            if (addressState != null)
                callPayload.Queries["address-state"] = CSharpExpressionConverter.ConvertO(addressState);
            if (addressPostalcode != null)
                callPayload.Queries["address-postalcode"] = CSharpExpressionConverter.ConvertO(addressPostalcode);
            if (name != null)
                callPayload.Queries["name"] = CSharpExpressionConverter.ConvertO(name);
            if (LastUpdated != null)
                callPayload.Queries["_lastUpdated"] = CSharpExpressionConverter.ConvertO(LastUpdated);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (Count != null)
                callPayload.Queries["_count"] = CSharpExpressionConverter.ConvertO(Count);
            return new ApiConnectionAction<OrganizationBundle>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "veteransaffairsprovi")]
        public IBodyWorkflowAction<Organization> GetOrganizationById(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Organization/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Organization>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "veteransaffairsprovi")]
        public IBodyWorkflowAction<PractitionerBundle> ListPractitioners(Expression<Func<string>> Id = null, Expression<Func<string>> identifier = null, Expression<Func<string>> family = null, Expression<Func<string>> given = null, Expression<Func<string>> name = null, Expression<Func<string>> LastUpdated = null, Expression<Func<int>> page = null, Expression<Func<int>> Count = null)
        {
            var apiCallPath = "/Practitioner";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (Id != null)
                callPayload.Queries["_id"] = CSharpExpressionConverter.ConvertO(Id);
            if (identifier != null)
                callPayload.Queries["identifier"] = CSharpExpressionConverter.ConvertO(identifier);
            if (family != null)
                callPayload.Queries["family"] = CSharpExpressionConverter.ConvertO(family);
            if (given != null)
                callPayload.Queries["given"] = CSharpExpressionConverter.ConvertO(given);
            if (name != null)
                callPayload.Queries["name"] = CSharpExpressionConverter.ConvertO(name);
            if (LastUpdated != null)
                callPayload.Queries["_lastUpdated"] = CSharpExpressionConverter.ConvertO(LastUpdated);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (Count != null)
                callPayload.Queries["_count"] = CSharpExpressionConverter.ConvertO(Count);
            return new ApiConnectionAction<PractitionerBundle>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "veteransaffairsprovi")]
        public IBodyWorkflowAction<Practitioner> GetPractitionerById(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Practitioner/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Practitioner>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "veteransaffairsprovi")]
        public IBodyWorkflowAction<PractitionerRoleBundle> ListPractitionerRoles(Expression<Func<string>> Id = null, Expression<Func<string>> practitionerIdentifier = null, Expression<Func<string>> practitionerName = null, Expression<Func<string>> LastUpdated = null, Expression<Func<int>> page = null, Expression<Func<int>> Count = null)
        {
            var apiCallPath = "/PractitionerRole";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (Id != null)
                callPayload.Queries["_id"] = CSharpExpressionConverter.ConvertO(Id);
            if (practitionerIdentifier != null)
                callPayload.Queries["practitioner.identifier"] = CSharpExpressionConverter.ConvertO(practitionerIdentifier);
            if (practitionerName != null)
                callPayload.Queries["practitioner.name"] = CSharpExpressionConverter.ConvertO(practitionerName);
            if (LastUpdated != null)
                callPayload.Queries["_lastUpdated"] = CSharpExpressionConverter.ConvertO(LastUpdated);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (Count != null)
                callPayload.Queries["_count"] = CSharpExpressionConverter.ConvertO(Count);
            return new ApiConnectionAction<PractitionerRoleBundle>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "veteransaffairsprovi")]
        public IBodyWorkflowAction<PractitionerRole> GetPractitionerRoleById(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/PractitionerRole/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PractitionerRole>(callPayload);
        }
    }

    public class VeteransaffairsproviTriggers([ConnectionName] string connectionId)
    {
    }

    public class LocationBundle
    {
        [JsonProperty("entry")]
        public LocationEntry[] Entry { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("identifier")]
        public Identifier Identifier { get; set; }

        [JsonProperty("implicitRules")]
        public string ImplicitRules { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("link")]
        public BundleLink[] Link { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("signature")]
        public Signature Signature { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("type")]
        public LocationBundleTypeType Type { get; set; }
    }

    public class LocationEntry
    {
        [JsonProperty("extension")]
        public JToken[] Extension { get; set; }

        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public BundleLink[] Link { get; set; }

        [JsonProperty("modifierExtension")]
        public JToken[] ModifierExtension { get; set; }

        [JsonProperty("request")]
        public JToken Request { get; set; }

        [JsonProperty("resource")]
        public Location Resource { get; set; }

        [JsonProperty("response")]
        public JToken Response { get; set; }

        [JsonProperty("search")]
        public JToken Search { get; set; }
    }

    public class BundleLink
    {
        [JsonProperty("extension")]
        public JToken[] Extension { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("modifierExtension")]
        public JToken[] ModifierExtension { get; set; }

        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Location
    {
        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("alias")]
        public string[] Alias { get; set; }

        [JsonProperty("availabilityExceptions")]
        public string AvailabilityExceptions { get; set; }

        [JsonProperty("contained")]
        public JToken[] Contained { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("endpoint")]
        public JToken[] Endpoint { get; set; }

        [JsonProperty("extension")]
        public JToken[] Extension { get; set; }

        [JsonProperty("hoursOfOperation")]
        public HoursOfOperation HoursOfOperation { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("identifier")]
        public Identifier[] Identifier { get; set; }

        [JsonProperty("implicitRules")]
        public string ImplicitRules { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("managingOrganization")]
        public JToken ManagingOrganization { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("mode")]
        public LocationModeType Mode { get; set; }

        [JsonProperty("modifierExtension")]
        public JToken[] ModifierExtension { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("operationalStatus")]
        public Coding OperationalStatus { get; set; }

        [JsonProperty("partOf")]
        public JToken PartOf { get; set; }

        [JsonProperty("physicalType")]
        public CodeableConcept PhysicalType { get; set; }

        [JsonProperty("position")]
        public Position Position { get; set; }

        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("status")]
        public LocationStatusType Status { get; set; }

        [JsonProperty("telecom")]
        public ContactPoint[] Telecom { get; set; }

        [JsonProperty("text")]
        public Narrative Text { get; set; }

        [JsonProperty("type")]
        public CodeableConcept[] Type { get; set; }
    }

    public class Address
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("extension")]
        public JToken[] Extension { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("period")]
        public Period Period { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("type")]
        public AddressTypeType Type { get; set; }

        [JsonProperty("use")]
        public AddressUseType Use { get; set; }
    }

    public class Period
    {
        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("extension")]
        public JToken[] Extension { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public enum AddressTypeType
    {
        [EnumMember(Value = "postal")]
        Postal,
        [EnumMember(Value = "physical")]
        Physical,
        [EnumMember(Value = "both")]
        Both
    }

    public enum AddressUseType
    {
        [EnumMember(Value = "home")]
        Home,
        [EnumMember(Value = "work")]
        Work,
        [EnumMember(Value = "temp")]
        Temp,
        [EnumMember(Value = "old")]
        Old,
        [EnumMember(Value = "billing")]
        Billing
    }

    public class HoursOfOperation
    {
        [JsonProperty("allDay")]
        public bool AllDay { get; set; }

        [JsonProperty("closingTime")]
        public string ClosingTime { get; set; }

        [JsonProperty("daysOfWeek")]
        public HoursOfOperationDaysOfWeekTypeItem[] DaysOfWeek { get; set; }

        [JsonProperty("extension")]
        public JToken[] Extension { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("modifierExtension")]
        public JToken[] ModifierExtension { get; set; }

        [JsonProperty("openingTime")]
        public string OpeningTime { get; set; }
    }

    public enum HoursOfOperationDaysOfWeekTypeItem
    {
        [EnumMember(Value = "mon")]
        Mon,
        [EnumMember(Value = "tue")]
        Tue,
        [EnumMember(Value = "wed")]
        Wed,
        [EnumMember(Value = "thu")]
        Thu,
        [EnumMember(Value = "fri")]
        Fri,
        [EnumMember(Value = "sat")]
        Sat,
        [EnumMember(Value = "sun")]
        Sun
    }

    public class Identifier
    {
        [JsonProperty("assigner")]
        public JToken Assigner { get; set; }

        [JsonProperty("extension")]
        public JToken[] Extension { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("period")]
        public Period Period { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("type")]
        public CodeableConcept Type { get; set; }

        [JsonProperty("use")]
        public IdentifierUseType Use { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CodeableConcept
    {
        [JsonProperty("coding")]
        public Coding[] Coding { get; set; }

        [JsonProperty("extension")]
        public JToken[] Extension { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class Coding
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }

        [JsonProperty("extension")]
        public JToken[] Extension { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("userSelected")]
        public bool UserSelected { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public enum IdentifierUseType
    {
        [EnumMember(Value = "usual")]
        Usual,
        [EnumMember(Value = "official")]
        Official,
        [EnumMember(Value = "temp")]
        Temp,
        [EnumMember(Value = "secondary")]
        Secondary,
        [EnumMember(Value = "old")]
        Old
    }

    public class Meta
    {
        [JsonProperty("extension")]
        public JToken[] Extension { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }

        [JsonProperty("profile")]
        public string[] Profile { get; set; }

        [JsonProperty("security")]
        public Coding[] Security { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("tag")]
        public Coding[] Tag { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }
    }

    public enum LocationModeType
    {
        [EnumMember(Value = "instance")]
        Instance,
        [EnumMember(Value = "kind")]
        Kind
    }

    public class Position
    {
        [JsonProperty("altitude")]
        public double Altitude { get; set; }

        [JsonProperty("extension")]
        public JToken[] Extension { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("modifierExtension")]
        public JToken[] ModifierExtension { get; set; }
    }

    public enum LocationStatusType
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "suspended")]
        Suspended,
        [EnumMember(Value = "inactive")]
        Inactive
    }

    public class ContactPoint
    {
        [JsonProperty("extension")]
        public JToken[] Extension { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("period")]
        public Period Period { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("system")]
        public ContactPointSystemType System { get; set; }

        [JsonProperty("use")]
        public ContactPointUseType Use { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum ContactPointSystemType
    {
        [EnumMember(Value = "phone")]
        Phone,
        [EnumMember(Value = "fax")]
        Fax,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "pager")]
        Pager,
        [EnumMember(Value = "url")]
        Url,
        [EnumMember(Value = "sms")]
        Sms,
        [EnumMember(Value = "other")]
        Other
    }

    public enum ContactPointUseType
    {
        [EnumMember(Value = "home")]
        Home,
        [EnumMember(Value = "work")]
        Work,
        [EnumMember(Value = "temp")]
        Temp,
        [EnumMember(Value = "old")]
        Old,
        [EnumMember(Value = "mobile")]
        Mobile
    }

    public class Narrative
    {
        [JsonProperty("div")]
        public string Div { get; set; }

        [JsonProperty("extension")]
        public JToken[] Extension { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public NarrativeStatusType Status { get; set; }
    }

    public enum NarrativeStatusType
    {
        [EnumMember(Value = "generated")]
        Generated,
        [EnumMember(Value = "extensions")]
        Extensions,
        [EnumMember(Value = "additional")]
        Additional,
        [EnumMember(Value = "empty")]
        Empty
    }

    public class Signature
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("extension")]
        public JToken[] Extension { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("onBehalfOf")]
        public JToken OnBehalfOf { get; set; }

        [JsonProperty("sigFormat")]
        public string SigFormat { get; set; }

        [JsonProperty("targetFormat")]
        public string TargetFormat { get; set; }

        [JsonProperty("type")]
        public Coding[] Type { get; set; }

        [JsonProperty("when")]
        public string When { get; set; }

        [JsonProperty("who")]
        public JToken Who { get; set; }
    }

    public enum LocationBundleTypeType
    {
        [EnumMember(Value = "document")]
        Document,
        [EnumMember(Value = "message")]
        Message,
        [EnumMember(Value = "transaction")]
        Transaction,
        [EnumMember(Value = "transaction-response")]
        TransactionResponse,
        [EnumMember(Value = "batch")]
        Batch,
        [EnumMember(Value = "batch-response")]
        BatchResponse,
        [EnumMember(Value = "history")]
        History,
        [EnumMember(Value = "searchset")]
        Searchset,
        [EnumMember(Value = "collection")]
        Collection
    }

    public class OrganizationBundle
    {
        [JsonProperty("entry")]
        public OrganizationEntry[] Entry { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("identifier")]
        public Identifier Identifier { get; set; }

        [JsonProperty("implicitRules")]
        public string ImplicitRules { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("link")]
        public BundleLink[] Link { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("signature")]
        public Signature Signature { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("type")]
        public OrganizationBundleTypeType Type { get; set; }
    }

    public class OrganizationEntry
    {
        [JsonProperty("extension")]
        public JToken[] Extension { get; set; }

        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public BundleLink[] Link { get; set; }

        [JsonProperty("modifierExtension")]
        public JToken[] ModifierExtension { get; set; }

        [JsonProperty("request")]
        public JToken Request { get; set; }

        [JsonProperty("resource")]
        public Organization Resource { get; set; }

        [JsonProperty("response")]
        public JToken Response { get; set; }

        [JsonProperty("search")]
        public JToken Search { get; set; }
    }

    public class Organization
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("address")]
        public Address[] Address { get; set; }

        [JsonProperty("alias")]
        public string[] Alias { get; set; }

        [JsonProperty("contact")]
        public OrganizationContact[] Contact { get; set; }

        [JsonProperty("contained")]
        public JToken[] Contained { get; set; }

        [JsonProperty("endpoint")]
        public JToken[] Endpoint { get; set; }

        [JsonProperty("extension")]
        public JToken[] Extension { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("identifier")]
        public Identifier[] Identifier { get; set; }

        [JsonProperty("implicitRules")]
        public string ImplicitRules { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("modifierExtension")]
        public JToken[] ModifierExtension { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("partOf")]
        public JToken PartOf { get; set; }

        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("telecom")]
        public ContactPoint[] Telecom { get; set; }

        [JsonProperty("text")]
        public Narrative Text { get; set; }

        [JsonProperty("type")]
        public CodeableConcept[] Type { get; set; }
    }

    public class OrganizationContact
    {
        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("extension")]
        public JToken[] Extension { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("modifierExtension")]
        public JToken[] ModifierExtension { get; set; }

        [JsonProperty("name")]
        public HumanName Name { get; set; }

        [JsonProperty("purpose")]
        public CodeableConcept Purpose { get; set; }

        [JsonProperty("telecom")]
        public ContactPoint[] Telecom { get; set; }
    }

    public class HumanName
    {
        [JsonProperty("extension")]
        public JToken[] Extension { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("period")]
        public Period Period { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }

        [JsonProperty("suffix")]
        public string[] Suffix { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("use")]
        public HumanNameUseType Use { get; set; }
    }

    public enum HumanNameUseType
    {
        [EnumMember(Value = "usual")]
        Usual,
        [EnumMember(Value = "official")]
        Official,
        [EnumMember(Value = "temp")]
        Temp,
        [EnumMember(Value = "nickname")]
        Nickname,
        [EnumMember(Value = "anonymous")]
        Anonymous,
        [EnumMember(Value = "old")]
        Old,
        [EnumMember(Value = "maiden")]
        Maiden
    }

    public enum OrganizationBundleTypeType
    {
        [EnumMember(Value = "document")]
        Document,
        [EnumMember(Value = "message")]
        Message,
        [EnumMember(Value = "transaction")]
        Transaction,
        [EnumMember(Value = "transaction-response")]
        TransactionResponse,
        [EnumMember(Value = "batch")]
        Batch,
        [EnumMember(Value = "batch-response")]
        BatchResponse,
        [EnumMember(Value = "history")]
        History,
        [EnumMember(Value = "searchset")]
        Searchset,
        [EnumMember(Value = "collection")]
        Collection
    }

    public class PractitionerBundle
    {
        [JsonProperty("entry")]
        public PractitionerEntry[] Entry { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("identifier")]
        public Identifier Identifier { get; set; }

        [JsonProperty("implicitRules")]
        public string ImplicitRules { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("link")]
        public BundleLink[] Link { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("signature")]
        public Signature Signature { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("type")]
        public PractitionerBundleTypeType Type { get; set; }
    }

    public class PractitionerEntry
    {
        [JsonProperty("extension")]
        public JToken[] Extension { get; set; }

        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public BundleLink[] Link { get; set; }

        [JsonProperty("modifierExtension")]
        public JToken[] ModifierExtension { get; set; }

        [JsonProperty("request")]
        public JToken Request { get; set; }

        [JsonProperty("resource")]
        public Practitioner Resource { get; set; }

        [JsonProperty("response")]
        public JToken Response { get; set; }

        [JsonProperty("search")]
        public JToken Search { get; set; }
    }

    public class Practitioner
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("address")]
        public Address[] Address { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("communication")]
        public CodeableConcept[] Communication { get; set; }

        [JsonProperty("contained")]
        public JToken[] Contained { get; set; }

        [JsonProperty("extensions")]
        public JToken[] Extensions { get; set; }

        [JsonProperty("gender")]
        public PractitionerGenderType Gender { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("identifier")]
        public Identifier[] Identifier { get; set; }

        [JsonProperty("implicitRules")]
        public string ImplicitRules { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("modifierExtensions")]
        public JToken[] ModifierExtensions { get; set; }

        [JsonProperty("name")]
        public HumanName[] Name { get; set; }

        [JsonProperty("photo")]
        public Attachment[] Photo { get; set; }

        [JsonProperty("qualification")]
        public PractitionerQualification[] Qualification { get; set; }

        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("telecom")]
        public ContactPoint[] Telecom { get; set; }

        [JsonProperty("text")]
        public Narrative Text { get; set; }
    }

    public enum PractitionerGenderType
    {
        Male,
        Female,
        Other,
        Unknown
    }

    public class Attachment
    {
        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("creation")]
        public string Creation { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("extension")]
        public JToken[] Extension { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class PractitionerQualification
    {
        [JsonProperty("code")]
        public CodeableConcept Code { get; set; }

        [JsonProperty("extension")]
        public JToken[] Extension { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("identifier")]
        public Identifier[] Identifier { get; set; }

        [JsonProperty("issuer")]
        public JToken Issuer { get; set; }

        [JsonProperty("modifierExtension")]
        public JToken[] ModifierExtension { get; set; }

        [JsonProperty("period")]
        public Period Period { get; set; }
    }

    public enum PractitionerBundleTypeType
    {
        [EnumMember(Value = "document")]
        Document,
        [EnumMember(Value = "message")]
        Message,
        [EnumMember(Value = "transaction")]
        Transaction,
        [EnumMember(Value = "transaction-response")]
        TransactionResponse,
        [EnumMember(Value = "batch")]
        Batch,
        [EnumMember(Value = "batch-response")]
        BatchResponse,
        [EnumMember(Value = "history")]
        History,
        [EnumMember(Value = "searchset")]
        Searchset,
        [EnumMember(Value = "collection")]
        Collection
    }

    public class PractitionerRoleBundle
    {
        [JsonProperty("entry")]
        public PractitionerRoleEntry[] Entry { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("identifier")]
        public Identifier Identifier { get; set; }

        [JsonProperty("implicitRules")]
        public string ImplicitRules { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("link")]
        public BundleLink[] Link { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("signature")]
        public Signature Signature { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("type")]
        public PractitionerRoleBundleTypeType Type { get; set; }
    }

    public class PractitionerRoleEntry
    {
        [JsonProperty("extension")]
        public JToken[] Extension { get; set; }

        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link")]
        public BundleLink[] Link { get; set; }

        [JsonProperty("modifierExtension")]
        public JToken[] ModifierExtension { get; set; }

        [JsonProperty("request")]
        public JToken Request { get; set; }

        [JsonProperty("resource")]
        public PractitionerRole Resource { get; set; }

        [JsonProperty("response")]
        public JToken Response { get; set; }

        [JsonProperty("search")]
        public JToken Search { get; set; }
    }

    public class PractitionerRole
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("availabilityExceptions")]
        public string AvailabilityExceptions { get; set; }

        [JsonProperty("availableTime")]
        public PractitionerAvailableTime[] AvailableTime { get; set; }

        [JsonProperty("code")]
        public CodeableConcept[] Code { get; set; }

        [JsonProperty("contained")]
        public JToken[] Contained { get; set; }

        [JsonProperty("endpoint")]
        public JToken[] Endpoint { get; set; }

        [JsonProperty("extension")]
        public JToken[] Extension { get; set; }

        [JsonProperty("healthcareService")]
        public JToken[] HealthcareService { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("identifier")]
        public Identifier[] Identifier { get; set; }

        [JsonProperty("implicitRules")]
        public string ImplicitRules { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("location")]
        public JToken[] Location { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("modifierExtension")]
        public JToken[] ModifierExtension { get; set; }

        [JsonProperty("notAvailable")]
        public PractitionerNotAvailable[] NotAvailable { get; set; }

        [JsonProperty("organization")]
        public JToken Organization { get; set; }

        [JsonProperty("period")]
        public Period Period { get; set; }

        [JsonProperty("practitioner")]
        public JToken Practitioner { get; set; }

        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("specialty")]
        public CodeableConcept[] Specialty { get; set; }

        [JsonProperty("telecom")]
        public ContactPoint[] Telecom { get; set; }

        [JsonProperty("text")]
        public Narrative Text { get; set; }
    }

    public class PractitionerAvailableTime
    {
        [JsonProperty("allDay")]
        public bool AllDay { get; set; }

        [JsonProperty("availableEndTime")]
        public string AvailableEndTime { get; set; }

        [JsonProperty("availableStartTime")]
        public string AvailableStartTime { get; set; }

        [JsonProperty("daysOfWeek")]
        public PractitionerAvailableTimeDaysOfWeekTypeItem[] DaysOfWeek { get; set; }

        [JsonProperty("extension")]
        public JToken[] Extension { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("modifierExtension")]
        public JToken[] ModifierExtension { get; set; }
    }

    public enum PractitionerAvailableTimeDaysOfWeekTypeItem
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public class PractitionerNotAvailable
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("during")]
        public Period During { get; set; }

        [JsonProperty("extension")]
        public JToken[] Extension { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("modifierExtension")]
        public JToken[] ModifierExtension { get; set; }
    }

    public enum PractitionerRoleBundleTypeType
    {
        [EnumMember(Value = "document")]
        Document,
        [EnumMember(Value = "message")]
        Message,
        [EnumMember(Value = "transaction")]
        Transaction,
        [EnumMember(Value = "transaction-response")]
        TransactionResponse,
        [EnumMember(Value = "batch")]
        Batch,
        [EnumMember(Value = "batch-response")]
        BatchResponse,
        [EnumMember(Value = "history")]
        History,
        [EnumMember(Value = "searchset")]
        Searchset,
        [EnumMember(Value = "collection")]
        Collection
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Veteransaffairsprovi;

    public partial class WorkflowManagedActions
    {
        public VeteransaffairsproviActions Veteransaffairsprovi(string connectionId) => new VeteransaffairsproviActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public VeteransaffairsproviTriggers Veteransaffairsprovi(string connectionId) => new VeteransaffairsproviTriggers(connectionId);
    }
}