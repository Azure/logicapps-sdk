//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googlecontacts
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GooglecontactsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googlecontacts")]
        public IBodyWorkflowAction<PeopleApiListContactsV4Response> PeopleApiListContacts()
        {
            var apiCallPath = "/v4/people/v1/me/connections";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PeopleApiListContactsV4Response>(callPayload);
        }
    }

    public class GooglecontactsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<PeopleApiOnContactUpdatedV3Response> PeopleApiOnContactUpdated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v3/people/trigger/onContactUpdated";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<PeopleApiOnContactUpdatedV3Response>(callPayload, recurrence: recurrence);
        }
    }

    public class PeopleApiListContactsV4Response
    {
        [JsonProperty("connections")]
        public PeopleApiConnectionV2[] Connections { get; set; }
    }

    public class PeopleApiConnectionV2
    {
        [JsonProperty("metadata")]
        public PeopleApiConnectionV2MetadataType Metadata { get; set; }

        [JsonProperty("name")]
        public PeopleApiConnectionV2NameType Name { get; set; }

        [JsonProperty("nickname")]
        public PeopleApiConnectionV2NicknameType Nickname { get; set; }

        [JsonProperty("organizations")]
        public PeopleApiConnectionV2OrganizationsTypeItem[] Organizations { get; set; }

        [JsonProperty("addresses")]
        public PeopleApiConnectionV2AddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("emailAddresses")]
        public PeopleApiConnectionV2EmailAddressesTypeItem[] EmailAddresses { get; set; }

        [JsonProperty("phoneNumbers")]
        public PeopleApiConnectionV2PhoneNumbersTypeItem[] PhoneNumbers { get; set; }
    }

    public class PeopleApiConnectionV2MetadataType
    {
        [JsonProperty("source")]
        public PeopleApiConnectionV2MetadataTypeSourceType Source { get; set; }
    }

    public class PeopleApiConnectionV2MetadataTypeSourceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updateTime")]
        public string UpdatedDateTime { get; set; }
    }

    public class PeopleApiConnectionV2NameType
    {
        [JsonProperty("displayName")]
        public string FullName { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }
    }

    public class PeopleApiConnectionV2NicknameType
    {
        [JsonProperty("value")]
        public string Nickname { get; set; }
    }

    public class PeopleApiConnectionV2OrganizationsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class PeopleApiConnectionV2AddressesTypeItem
    {
        [JsonProperty("formattedValue")]
        public string Address { get; set; }
    }

    public class PeopleApiConnectionV2EmailAddressesTypeItem
    {
        [JsonProperty("value")]
        public string Email { get; set; }

        [JsonProperty("formattedType")]
        public string Type { get; set; }
    }

    public class PeopleApiConnectionV2PhoneNumbersTypeItem
    {
        [JsonProperty("value")]
        public string PhoneNumber { get; set; }

        [JsonProperty("formattedType")]
        public string Type { get; set; }
    }

    public class PeopleApiOnContactUpdatedV3Response
    {
        [JsonProperty("connections")]
        public PeopleApiConnectionV2[] Connections { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Googlecontacts;

    public partial class WorkflowManagedActions
    {
        public GooglecontactsActions Googlecontacts(string connectionId) => new GooglecontactsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GooglecontactsTriggers Googlecontacts(string connectionId) => new GooglecontactsTriggers(connectionId);
    }
}