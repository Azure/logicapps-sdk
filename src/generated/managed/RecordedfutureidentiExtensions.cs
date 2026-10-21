//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Recordedfutureidenti
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RecordedfutureidentiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "recordedfutureidenti")]
        public IBodyWorkflowAction<LookupResponse> CredentialLookup(Expression<Func<string[]>> bodyfilterauthorizationProtocols = null, Expression<Func<string[]>> bodyfilterauthorizationTechnologies = null, Expression<Func<string>> bodyfilterbreachPropertiesdate = null, Expression<Func<string>> bodyfilterbreachPropertiesname = null, Expression<Func<string>> bodyfilterdumpPropertiesdate = null, Expression<Func<string>> bodyfilterdumpPropertiesname = null, Expression<Func<string>> bodyfilterexfiltrationDateGte = null, Expression<Func<string>> bodyfilterfirstDownloadedGte = null, Expression<Func<string>> bodyfilterlatestDownloadedGte = null, Expression<Func<string[]>> bodyfiltermalwareFamilies = null, Expression<Func<bodyfilterpropertiesInputItem[]>> bodyfilterproperties = null, Expression<Func<bodyfilterusernamePropertiesInputItem[]>> bodyfilterusernameProperties = null, Expression<Func<string>> bodyorganizationId = null, Expression<Func<string[]>> bodysubjects = null, Expression<Func<DomainLogin[]>> bodysubjectsLogin = null, Expression<Func<string[]>> bodysubjectsSha1 = null)
        {
            var __workflow_bodyfilterauthorizationProtocols = WorkflowExpression.Compile(bodyfilterauthorizationProtocols, nameof(bodyfilterauthorizationProtocols), required: false);
            var __workflow_bodyfilterauthorizationTechnologies = WorkflowExpression.Compile(bodyfilterauthorizationTechnologies, nameof(bodyfilterauthorizationTechnologies), required: false);
            var __workflow_bodyfilterbreachPropertiesdate = WorkflowExpression.Compile(bodyfilterbreachPropertiesdate, nameof(bodyfilterbreachPropertiesdate), required: false);
            var __workflow_bodyfilterbreachPropertiesname = WorkflowExpression.Compile(bodyfilterbreachPropertiesname, nameof(bodyfilterbreachPropertiesname), required: false);
            var __workflow_bodyfilterdumpPropertiesdate = WorkflowExpression.Compile(bodyfilterdumpPropertiesdate, nameof(bodyfilterdumpPropertiesdate), required: false);
            var __workflow_bodyfilterdumpPropertiesname = WorkflowExpression.Compile(bodyfilterdumpPropertiesname, nameof(bodyfilterdumpPropertiesname), required: false);
            var __workflow_bodyfilterexfiltrationDateGte = WorkflowExpression.Compile(bodyfilterexfiltrationDateGte, nameof(bodyfilterexfiltrationDateGte), required: false);
            var __workflow_bodyfilterfirstDownloadedGte = WorkflowExpression.Compile(bodyfilterfirstDownloadedGte, nameof(bodyfilterfirstDownloadedGte), required: false);
            var __workflow_bodyfilterlatestDownloadedGte = WorkflowExpression.Compile(bodyfilterlatestDownloadedGte, nameof(bodyfilterlatestDownloadedGte), required: false);
            var __workflow_bodyfiltermalwareFamilies = WorkflowExpression.Compile(bodyfiltermalwareFamilies, nameof(bodyfiltermalwareFamilies), required: false);
            var __workflow_bodyfilterproperties = WorkflowExpression.Compile(bodyfilterproperties, nameof(bodyfilterproperties), required: false);
            var __workflow_bodyfilterusernameProperties = WorkflowExpression.Compile(bodyfilterusernameProperties, nameof(bodyfilterusernameProperties), required: false);
            var __workflow_bodyorganizationId = WorkflowExpression.Compile(bodyorganizationId, nameof(bodyorganizationId), required: false);
            var __workflow_bodysubjects = WorkflowExpression.Compile(bodysubjects, nameof(bodysubjects), required: false);
            var __workflow_bodysubjectsLogin = WorkflowExpression.Compile(bodysubjectsLogin, nameof(bodysubjectsLogin), required: false);
            var __workflow_bodysubjectsSha1 = WorkflowExpression.Compile(bodysubjectsSha1, nameof(bodysubjectsSha1), required: false);
            return new DeferredBodyAction<LookupResponse>(() =>
            {
                var apiCallPath = "/v2/credentials/lookup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (__workflow_bodyfilterauthorizationProtocols != null)
                {
                    filterObject["authorization_protocols"] = ExpressionConverter.ConvertO(__workflow_bodyfilterauthorizationProtocols);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterauthorizationTechnologies != null)
                {
                    filterObject["authorization_technologies"] = ExpressionConverter.ConvertO(__workflow_bodyfilterauthorizationTechnologies);
                    filterObjectpropCount++;
                }

                var breachPropertiesObject = new JObject();
                var breachPropertiesObjectpropCount = 0;
                if (__workflow_bodyfilterbreachPropertiesdate != null)
                {
                    breachPropertiesObject["date"] = ExpressionConverter.ConvertO(__workflow_bodyfilterbreachPropertiesdate);
                    breachPropertiesObjectpropCount++;
                }

                if (__workflow_bodyfilterbreachPropertiesname != null)
                {
                    breachPropertiesObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyfilterbreachPropertiesname);
                    breachPropertiesObjectpropCount++;
                }

                if (breachPropertiesObjectpropCount > 0)
                {
                    filterObject["breach_properties"] = breachPropertiesObject;
                    filterObjectpropCount++;
                }

                var dumpPropertiesObject = new JObject();
                var dumpPropertiesObjectpropCount = 0;
                if (__workflow_bodyfilterdumpPropertiesdate != null)
                {
                    dumpPropertiesObject["date"] = ExpressionConverter.ConvertO(__workflow_bodyfilterdumpPropertiesdate);
                    dumpPropertiesObjectpropCount++;
                }

                if (__workflow_bodyfilterdumpPropertiesname != null)
                {
                    dumpPropertiesObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyfilterdumpPropertiesname);
                    dumpPropertiesObjectpropCount++;
                }

                if (dumpPropertiesObjectpropCount > 0)
                {
                    filterObject["dump_properties"] = dumpPropertiesObject;
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterexfiltrationDateGte != null)
                {
                    filterObject["exfiltration_date_gte"] = ExpressionConverter.ConvertO(__workflow_bodyfilterexfiltrationDateGte);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterfirstDownloadedGte != null)
                {
                    filterObject["first_downloaded_gte"] = ExpressionConverter.ConvertO(__workflow_bodyfilterfirstDownloadedGte);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterlatestDownloadedGte != null)
                {
                    filterObject["latest_downloaded_gte"] = ExpressionConverter.ConvertO(__workflow_bodyfilterlatestDownloadedGte);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfiltermalwareFamilies != null)
                {
                    filterObject["malware_families"] = ExpressionConverter.ConvertO(__workflow_bodyfiltermalwareFamilies);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterproperties != null)
                {
                    filterObject["properties"] = ExpressionConverter.ConvertO(__workflow_bodyfilterproperties);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterusernameProperties != null)
                {
                    filterObject["username_properties"] = ExpressionConverter.ConvertO(__workflow_bodyfilterusernameProperties);
                    filterObjectpropCount++;
                }

                if (filterObjectpropCount > 0)
                {
                    body["filter"] = filterObject;
                    bodypropCount++;
                }

                if (__workflow_bodyorganizationId != null)
                {
                    body["organization_id"] = ExpressionConverter.ConvertO(__workflow_bodyorganizationId);
                    bodypropCount++;
                }

                if (__workflow_bodysubjects != null)
                {
                    body["subjects"] = ExpressionConverter.ConvertO(__workflow_bodysubjects);
                    bodypropCount++;
                }

                if (__workflow_bodysubjectsLogin != null)
                {
                    body["subjects_login"] = ExpressionConverter.ConvertO(__workflow_bodysubjectsLogin);
                    bodypropCount++;
                }

                if (__workflow_bodysubjectsSha1 != null)
                {
                    body["subjects_sha1"] = ExpressionConverter.ConvertO(__workflow_bodysubjectsSha1);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LookupResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class RecordedfutureidentiTriggers([ConnectionName] string connectionId)
    {
    }

    public class LookupResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("identities")]
        public LeakedIdentity[] Identities { get; set; }

        [JsonProperty("next_offset")]
        public string NextOffset { get; set; }
    }

    public class LeakedIdentity
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("credentials")]
        public Credentials[] Credentials { get; set; }

        [JsonProperty("identity")]
        public IdentityDetails Identity { get; set; }
    }

    public class Credentials
    {
        [JsonProperty("authorization_service")]
        public CredentialsAuthorizationServiceType AuthorizationService { get; set; }

        [JsonProperty("compromise")]
        public CredentialsCompromiseType Compromise { get; set; }

        [JsonProperty("cookies")]
        public Cookie[] Cookies { get; set; }

        [JsonProperty("dumps")]
        public DumpMetadata[] Dumps { get; set; }

        [JsonProperty("exposed_secret")]
        public SecretDetails ExposedSecret { get; set; }

        [JsonProperty("first_downloaded")]
        public string FirstDownloaded { get; set; }

        [JsonProperty("latest_downloaded")]
        public string LatestDownloaded { get; set; }

        [JsonProperty("malware_family")]
        public CredentialsMalwareFamilyType MalwareFamily { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }
    }

    public class CredentialsAuthorizationServiceType
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("fqdn")]
        public string Fqdn { get; set; }

        [JsonProperty("protocols")]
        public string[] Protocols { get; set; }

        [JsonProperty("technology")]
        public Technology[] Technology { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Technology
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CredentialsCompromiseType
    {
        [JsonProperty("exfiltration_date")]
        public string ExfiltrationDate { get; set; }
    }

    public class Cookie
    {
        [JsonProperty("dns")]
        public string Dns { get; set; }

        [JsonProperty("expiration")]
        public string Expiration { get; set; }

        [JsonProperty("http")]
        public bool Http { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("secure")]
        public bool Secure { get; set; }
    }

    public class DumpMetadata
    {
        [JsonProperty("breaches")]
        public BreachMetadata[] Breaches { get; set; }

        [JsonProperty("compromise")]
        public DumpMetadataCompromiseType Compromise { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("downloaded")]
        public string Downloaded { get; set; }

        [JsonProperty("infrastructure")]
        public DumpMetadataInfrastructureType Infrastructure { get; set; }

        [JsonProperty("location")]
        public DumpMetadataLocationType Location { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class BreachMetadata
    {
        [JsonProperty("breached")]
        public string Breached { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("precision")]
        public BreachMetadataPrecisionType Precision { get; set; }

        [JsonProperty("site_description")]
        public string SiteDescription { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("stop")]
        public string Stop { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BreachMetadataPrecisionType
    {
        [EnumMember(Value = "year")]
        Year,
        [EnumMember(Value = "month")]
        Month,
        [EnumMember(Value = "day")]
        Day
    }

    public class DumpMetadataCompromiseType
    {
        [JsonProperty("antivirus")]
        public string[] Antivirus { get; set; }

        [JsonProperty("computer_name")]
        public string ComputerName { get; set; }

        [JsonProperty("exfiltration_date")]
        public string ExfiltrationDate { get; set; }

        [JsonProperty("malware_file")]
        public string MalwareFile { get; set; }

        [JsonProperty("os")]
        public string Os { get; set; }

        [JsonProperty("os_username")]
        public string OsUsername { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("uac")]
        public string Uac { get; set; }
    }

    public class DumpMetadataInfrastructureType
    {
        [JsonProperty("ip")]
        public string Ip { get; set; }
    }

    public class DumpMetadataLocationType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public DumpMetadataLocationTypeCountryType Country { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class DumpMetadataLocationTypeCountryType
    {
        [JsonProperty("alpha2Code")]
        public string Alpha2Code { get; set; }

        [JsonProperty("alpha3Code")]
        public string Alpha3Code { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SecretDetails
    {
        [JsonProperty("details")]
        public SecretDetailsDetailsType Details { get; set; }

        [JsonProperty("effectively_clear")]
        public bool EffectivelyClear { get; set; }

        [JsonProperty("hashes")]
        public JToken[] Hashes { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SecretDetailsDetailsType
    {
        [JsonProperty("clear_text_hint")]
        public string ClearTextHint { get; set; }

        [JsonProperty("clear_text_value")]
        public string ClearTextValue { get; set; }

        [JsonProperty("properties")]
        public SecretDetailsDetailsTypePropertiesTypeItem[] Properties { get; set; }

        [JsonProperty("rank")]
        public SecretDetailsDetailsTypeRankType Rank { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SecretDetailsDetailsTypePropertiesTypeItem
    {
        Letter,
        Number,
        Symbol,
        UpperCase,
        LowerCase,
        MixedCase,
        AtLeast8Characters,
        AtLeast10Characters,
        AtLeast12Characters,
        AtLeast16Characters,
        AtLeast24Characters,
        Cookies,
        UnexpiredCookies,
        AuthorizationTechnology,
        MalwareOnly
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SecretDetailsDetailsTypeRankType
    {
        Top100kCommonPasswords,
        TopMillionCommonPasswords
    }

    public class CredentialsMalwareFamilyType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class IdentityDetails
    {
        [JsonProperty("subjects")]
        public string[] Subjects { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyfilterpropertiesInputItem
    {
        Letter,
        Number,
        Symbol,
        UpperCase,
        LowerCase,
        MixedCase,
        AtLeast8Characters,
        AtLeast10Characters,
        AtLeast12Characters,
        AtLeast16Characters,
        AtLeast24Characters,
        Cookies,
        UnexpiredCookies,
        AuthorizationTechnology,
        MalwareOnly
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyfilterusernamePropertiesInputItem
    {
        Email
    }

    public class DomainLogin
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("login_sha1")]
        public string LoginSha1 { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Recordedfutureidenti;

    public partial class WorkflowManagedActions
    {
        public RecordedfutureidentiActions Recordedfutureidenti(string connectionId) => new RecordedfutureidentiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RecordedfutureidentiTriggers Recordedfutureidenti(string connectionId) => new RecordedfutureidentiTriggers(connectionId);
    }
}
