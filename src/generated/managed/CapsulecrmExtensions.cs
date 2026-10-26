//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Capsulecrm
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CapsulecrmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<ListOpportunitiesResponse, ApiConnectionActionConfiguration> ListOpportunities()
        {
            return new DeferredBodyAction<ListOpportunitiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/opportunities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListOpportunitiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<CreateOpportunityResponse, ApiConnectionActionConfiguration> CreateOpportunity(Expression<Func<CreateOpportunityInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateOpportunityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/opportunities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateOpportunityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<GetOpportunityResponse, ApiConnectionActionConfiguration> GetOpportunity(Expression<Func<string>> opportunityId)
        {
            var __workflow_opportunityId = WorkflowExpression.Compile(opportunityId, nameof(opportunityId), required: true);
            return new DeferredBodyAction<GetOpportunityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/opportunities/{0}", __workflow_opportunityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetOpportunityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<UpdateOpportunityResponse, ApiConnectionActionConfiguration> UpdateOpportunity(Expression<Func<string>> opportunityId, Expression<Func<UpdateOpportunityInput>> body)
        {
            var __workflow_opportunityId = WorkflowExpression.Compile(opportunityId, nameof(opportunityId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateOpportunityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/opportunities/{0}", __workflow_opportunityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateOpportunityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DeleteOpportunity(Expression<Func<string>> opportunityId)
        {
            var __workflow_opportunityId = WorkflowExpression.Compile(opportunityId, nameof(opportunityId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/opportunities/{0}", __workflow_opportunityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<CreateOrganisationResponse, ApiConnectionActionConfiguration> CreateOrganisation(Expression<Func<CreateOrganisationInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateOrganisationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/organisation/parties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateOrganisationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<UpdateOrganisationResponse, ApiConnectionActionConfiguration> UpdateOrganisation(Expression<Func<string>> id, Expression<Func<UpdateOrganisationInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateOrganisationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/organisation/parties/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateOrganisationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<ListpartiesResponse, ApiConnectionActionConfiguration> ListOrganizations()
        {
            return new DeferredBodyAction<ListpartiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/organisations/parties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListpartiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DeleteParty(Expression<Func<string>> personId)
        {
            var __workflow_personId = WorkflowExpression.Compile(personId, nameof(personId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/parties/{0}", __workflow_personId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<ListTasksResponse, ApiConnectionActionConfiguration> ListTasks()
        {
            return new DeferredBodyAction<ListTasksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListTasksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<CreateTaskResponse, ApiConnectionActionConfiguration> CreateTask(Expression<Func<CreateTaskInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<CompleteTaskResponse, ApiConnectionActionConfiguration> CompleteTask(Expression<Func<string>> taskId, Expression<Func<CompleteTaskInput>> body)
        {
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CompleteTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tasks/{0}", __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CompleteTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<CreatePersonV2Response, ApiConnectionActionConfiguration> CreatePerson(Expression<Func<CreatePersonV2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreatePersonV2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/person/parties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreatePersonV2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<GetPartyV2Response, ApiConnectionActionConfiguration> GetParty(Expression<Func<string>> personId)
        {
            var __workflow_personId = WorkflowExpression.Compile(personId, nameof(personId), required: true);
            return new DeferredBodyAction<GetPartyV2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/parties/{0}", __workflow_personId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPartyV2Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<ListpartiesResponseV2, ApiConnectionActionConfiguration> ListParties()
        {
            return new DeferredBodyAction<ListpartiesResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/parties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListpartiesResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<ListpartiesResponseV2, ApiConnectionActionConfiguration> ListPeople()
        {
            return new DeferredBodyAction<ListpartiesResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/people/parties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListpartiesResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "capsulecrm")]
        public IBodyWorkflowAction<UpdatePersonV2Response, ApiConnectionActionConfiguration> UpdatePerson(Expression<Func<string>> personId, Expression<Func<UpdatePersonV2Input>> body)
        {
            var __workflow_personId = WorkflowExpression.Compile(personId, nameof(personId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdatePersonV2Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/person/parties/{0}", __workflow_personId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdatePersonV2Response>(callPayload);
            });
        }
    }

    public class CapsulecrmTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<OpportunityResponse[], ApiConnectionTriggerConfiguration> OnNewOpportunity(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<OpportunityResponse[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/create_trigger/opportunities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<OpportunityResponse[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<OpportunityResponse[], ApiConnectionTriggerConfiguration> OnUpdateOpportunity(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<OpportunityResponse[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/update_trigger/opportunities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<OpportunityResponse[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<TaskResponse[], ApiConnectionTriggerConfiguration> OnNewTask(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<TaskResponse[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/create_trigger/tasks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<TaskResponse[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<PartyResponseV2[], ApiConnectionTriggerConfiguration> OnNewParty(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<PartyResponseV2[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/create_trigger/parties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<PartyResponseV2[]>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class ListOpportunitiesResponse
    {
        [JsonProperty("opportunities")]
        public OpportunityResponse[] Opportunities { get; set; }
    }

    public class OpportunityResponse
    {
        [JsonProperty("closedOn")]
        public string ClosedDate { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("durationBasis")]
        public string DurationBasis { get; set; }

        [JsonProperty("expectedCloseOn")]
        public string ExpectedCloseDate { get; set; }

        [JsonProperty("id")]
        public int OpportunityId { get; set; }

        [JsonProperty("milestone")]
        public OpportunityResponseMilestoneType Milestone { get; set; }

        [JsonProperty("name")]
        public string OpportunityName { get; set; }

        [JsonProperty("owner")]
        public OpportunityResponseOwnerType Owner { get; set; }

        [JsonProperty("party")]
        public OpportunityResponsePartyType Party { get; set; }

        [JsonProperty("probability")]
        public int Probability { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("value")]
        public OpportunityResponseValueType Value { get; set; }
    }

    public class OpportunityResponseMilestoneType
    {
        [JsonProperty("id")]
        public int MilestoneId { get; set; }

        [JsonProperty("name")]
        public string MilestoneName { get; set; }
    }

    public class OpportunityResponseOwnerType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public class OpportunityResponsePartyType
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("pictureURL")]
        public string PictureURL { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class OpportunityResponseValueType
    {
        [JsonProperty("amount")]
        public double AmountTheOpportunityIsWorth { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CreateOpportunityResponse
    {
        [JsonProperty("opportunity")]
        public OpportunityResponse Opportunity { get; set; }
    }

    public class CreateOpportunityInput
    {
        [JsonProperty("opportunity", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateOpportunityInputOpportunityType Opportunity { get; set; }
    }

    public class CreateOpportunityInputOpportunityType
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("party", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateOpportunityInputOpportunityTypePartyType Party { get; set; }

        [JsonProperty("milestone", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateOpportunityInputOpportunityTypeMilestoneType Milestone { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("durationBasis")]
        public CreateOpportunityInputOpportunityTypeDurationBasisType? DurationBasis { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("expectedCloseOn")]
        public string ExpectedCloseDate { get; set; }

        [JsonProperty("probability")]
        public int? WinningProbability { get; set; }

        [JsonProperty("value")]
        public CreateOpportunityInputOpportunityTypeExpectedType Expected { get; set; }
    }

    public class CreateOpportunityInputOpportunityTypePartyType
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PartyId { get; set; }
    }

    public class CreateOpportunityInputOpportunityTypeMilestoneType
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateOpportunityInputOpportunityTypeDurationBasisType
    {
        FIXED,
        HOUR,
        DAY,
        MONTH,
        YEAR,
        WEEK,
        QUARTER
    }

    public class CreateOpportunityInputOpportunityTypeExpectedType
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class GetOpportunityResponse
    {
        [JsonProperty("opportunity")]
        public OpportunityResponse Opportunity { get; set; }
    }

    public class UpdateOpportunityResponse
    {
        [JsonProperty("opportunity")]
        public OpportunityResponse Opportunity { get; set; }
    }

    public class UpdateOpportunityInput
    {
        [JsonProperty("opportunity")]
        public UpdateOpportunityInputOpportunityType Opportunity { get; set; }
    }

    public class UpdateOpportunityInputOpportunityType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("party")]
        public UpdateOpportunityInputOpportunityTypePartyType Party { get; set; }

        [JsonProperty("milestone")]
        public UpdateOpportunityInputOpportunityTypeMilestoneType Milestone { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("durationBasis")]
        public UpdateOpportunityInputOpportunityTypeDurationBasisType? DurationBasis { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("expectedCloseOn")]
        public string ExpectedCloseDate { get; set; }

        [JsonProperty("probability")]
        public int? WinningProbability { get; set; }

        [JsonProperty("value")]
        public UpdateOpportunityInputOpportunityTypeExpectedType Expected { get; set; }
    }

    public class UpdateOpportunityInputOpportunityTypePartyType
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PartyId { get; set; }
    }

    public class UpdateOpportunityInputOpportunityTypeMilestoneType
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int MilestoneId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateOpportunityInputOpportunityTypeDurationBasisType
    {
        FIXED,
        HOUR,
        DAY,
        MONTH,
        YEAR,
        WEEK,
        QUARTER
    }

    public class UpdateOpportunityInputOpportunityTypeExpectedType
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CreateOrganisationResponse
    {
        [JsonProperty("party")]
        public PartyResponse Party { get; set; }
    }

    public class PartyResponse
    {
        [JsonProperty("name")]
        public string OrganisationName { get; set; }

        [JsonProperty("about")]
        public string About { get; set; }

        [JsonProperty("addresses")]
        public PartyResponseAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("emailAddresses")]
        public PartyResponseEmailAddressesTypeItem[] EmailAddresses { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("id")]
        public int PartyId { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("lastContactedAt")]
        public string LastContactedAt { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("organisation")]
        public string Organisation { get; set; }

        [JsonProperty("phoneNumbers")]
        public PartyResponsePhoneNumbersTypeItem[] PhoneNumbers { get; set; }

        [JsonProperty("pictureURL")]
        public string PictureURL { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("websites")]
        public PartyResponseWebsitesTypeItem[] Websites { get; set; }
    }

    public class PartyResponseAddressesTypeItem
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class PartyResponseEmailAddressesTypeItem
    {
        [JsonProperty("address")]
        public string EmailAddress { get; set; }

        [JsonProperty("type")]
        public string EmailType { get; set; }
    }

    public class PartyResponsePhoneNumbersTypeItem
    {
        [JsonProperty("number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("type")]
        public string PhoneNumberType { get; set; }
    }

    public class PartyResponseWebsitesTypeItem
    {
        [JsonProperty("address")]
        public string WebsiteAddress { get; set; }

        [JsonProperty("service")]
        public string WebsiteService { get; set; }

        [JsonProperty("type")]
        public string WebsiteType { get; set; }
    }

    public class CreateOrganisationInput
    {
        [JsonProperty("party", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateOrganisationInputPartyType Party { get; set; }
    }

    public class CreateOrganisationInputPartyType
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("about")]
        public string About { get; set; }

        [JsonProperty("phoneNumbers")]
        public CreateOrganisationInputPartyTypePhoneNumbersType PhoneNumbers { get; set; }

        [JsonProperty("emailAddresses")]
        public CreateOrganisationInputPartyTypeEmailAddressesType EmailAddresses { get; set; }

        [JsonProperty("websites")]
        public CreateOrganisationInputPartyTypeWebsitesType Websites { get; set; }

        [JsonProperty("addresses")]
        public CreateOrganisationInputPartyTypeAddressesType Addresses { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "organisation";
    }

    public class CreateOrganisationInputPartyTypePhoneNumbersType
    {
        [JsonProperty("number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("type")]
        public CreateOrganisationInputPartyTypePhoneNumbersTypePhoneTypeType? PhoneType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateOrganisationInputPartyTypePhoneNumbersTypePhoneTypeType
    {
        Home,
        Work,
        Mobile,
        Fax,
        Direct
    }

    public class CreateOrganisationInputPartyTypeEmailAddressesType
    {
        [JsonProperty("address")]
        public string EmailAddress { get; set; }

        [JsonProperty("type")]
        public CreateOrganisationInputPartyTypeEmailAddressesTypeEmailTypeType? EmailType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateOrganisationInputPartyTypeEmailAddressesTypeEmailTypeType
    {
        Home,
        Work
    }

    public class CreateOrganisationInputPartyTypeWebsitesType
    {
        [JsonProperty("address")]
        public string WebsiteAddress { get; set; }

        [JsonProperty("service")]
        public CreateOrganisationInputPartyTypeWebsitesTypeWebsiteServiceType? WebsiteService { get; set; }

        [JsonProperty("type")]
        public CreateOrganisationInputPartyTypeWebsitesTypeWebsiteTypeType? WebsiteType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateOrganisationInputPartyTypeWebsitesTypeWebsiteServiceType
    {
        FEED,
        FACEBOOK,
        FLICKR,
        GITHUB,
        [EnumMember(Value = "GOOGLE_PLUS")]
        GOOGLEPLUS,
        INSTAGRAM,
        [EnumMember(Value = "LINKED_IN")]
        LINKEDIN,
        PINTEREST,
        SKYPE,
        TWITTER,
        URL,
        XING,
        YOUTUBE
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateOrganisationInputPartyTypeWebsitesTypeWebsiteTypeType
    {
        Home,
        Work
    }

    public class CreateOrganisationInputPartyTypeAddressesType
    {
        [JsonProperty("street")]
        public string AddressStreet { get; set; }

        [JsonProperty("city")]
        public string AddressCity { get; set; }

        [JsonProperty("state")]
        public string AddressState { get; set; }

        [JsonProperty("zip")]
        public string AddressZip { get; set; }

        [JsonProperty("country")]
        public string AddressCountry { get; set; }

        [JsonProperty("type")]
        public CreateOrganisationInputPartyTypeAddressesTypeAddressTypeType? AddressType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateOrganisationInputPartyTypeAddressesTypeAddressTypeType
    {
        Home,
        Postal,
        Office
    }

    public class UpdateOrganisationResponse
    {
        [JsonProperty("party")]
        public PartyResponse Party { get; set; }
    }

    public class UpdateOrganisationInput
    {
        [JsonProperty("party")]
        public UpdateOrganisationInputPartyType Party { get; set; }
    }

    public class UpdateOrganisationInputPartyType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("about")]
        public string About { get; set; }

        [JsonProperty("phoneNumbers")]
        public UpdateOrganisationInputPartyTypePhoneNumbersType PhoneNumbers { get; set; }

        [JsonProperty("emailAddresses")]
        public UpdateOrganisationInputPartyTypeEmailAddressesType EmailAddresses { get; set; }

        [JsonProperty("websites")]
        public UpdateOrganisationInputPartyTypeWebsitesType Websites { get; set; }

        [JsonProperty("addresses")]
        public UpdateOrganisationInputPartyTypeAddressesType Addresses { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "organisation";
    }

    public class UpdateOrganisationInputPartyTypePhoneNumbersType
    {
        [JsonProperty("number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("type")]
        public UpdateOrganisationInputPartyTypePhoneNumbersTypePhoneTypeType? PhoneType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateOrganisationInputPartyTypePhoneNumbersTypePhoneTypeType
    {
        Home,
        Work,
        Mobile,
        Fax,
        Direct
    }

    public class UpdateOrganisationInputPartyTypeEmailAddressesType
    {
        [JsonProperty("address")]
        public string EmailAddress { get; set; }

        [JsonProperty("type")]
        public UpdateOrganisationInputPartyTypeEmailAddressesTypeEmailTypeType? EmailType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateOrganisationInputPartyTypeEmailAddressesTypeEmailTypeType
    {
        Home,
        Work
    }

    public class UpdateOrganisationInputPartyTypeWebsitesType
    {
        [JsonProperty("address")]
        public string WebsiteAddress { get; set; }

        [JsonProperty("service")]
        public UpdateOrganisationInputPartyTypeWebsitesTypeWebsiteServiceType? WebsiteService { get; set; }

        [JsonProperty("type")]
        public UpdateOrganisationInputPartyTypeWebsitesTypeWebsiteTypeType? WebsiteType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateOrganisationInputPartyTypeWebsitesTypeWebsiteServiceType
    {
        FEED,
        FACEBOOK,
        FLICKR,
        GITHUB,
        [EnumMember(Value = "GOOGLE_PLUS")]
        GOOGLEPLUS,
        INSTAGRAM,
        [EnumMember(Value = "LINKED_IN")]
        LINKEDIN,
        PINTEREST,
        SKYPE,
        TWITTER,
        URL,
        XING,
        YOUTUBE
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateOrganisationInputPartyTypeWebsitesTypeWebsiteTypeType
    {
        Home,
        Work
    }

    public class UpdateOrganisationInputPartyTypeAddressesType
    {
        [JsonProperty("street")]
        public string AddressStreet { get; set; }

        [JsonProperty("city")]
        public string AddressCity { get; set; }

        [JsonProperty("state")]
        public string AddressState { get; set; }

        [JsonProperty("zip")]
        public string AddressZip { get; set; }

        [JsonProperty("country")]
        public string AddressCountry { get; set; }

        [JsonProperty("type")]
        public UpdateOrganisationInputPartyTypeAddressesTypeAddressTypeType? AddressType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateOrganisationInputPartyTypeAddressesTypeAddressTypeType
    {
        Home,
        Postal,
        Office
    }

    public class ListpartiesResponse
    {
        [JsonProperty("parties")]
        public ListpartiesResponsePartiesTypeItem[] Parties { get; set; }
    }

    public class ListpartiesResponsePartiesTypeItem
    {
        [JsonProperty("name")]
        public string OrganisationName { get; set; }

        [JsonProperty("about")]
        public string About { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("id")]
        public int PartyId { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("lastContactedAt")]
        public string LastContactedDateTime { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("organisation")]
        public string Organisation { get; set; }

        [JsonProperty("pictureURL")]
        public string PictureURL { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedDateTime { get; set; }
    }

    public class ListTasksResponse
    {
        [JsonProperty("tasks")]
        public TaskResponse[] Tasks { get; set; }
    }

    public class TaskResponse
    {
        [JsonProperty("category")]
        public TaskResponseCategoryType Category { get; set; }

        [JsonProperty("completedAt")]
        public string CompletedDateTime { get; set; }

        [JsonProperty("completedBy")]
        public string CompletedBy { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("detail")]
        public string Detail { get; set; }

        [JsonProperty("dueOn")]
        public string DueDate { get; set; }

        [JsonProperty("dueTime")]
        public string DueTime { get; set; }

        [JsonProperty("id")]
        public int TaskId { get; set; }

        [JsonProperty("owner")]
        public TaskResponseOwnerType Owner { get; set; }

        [JsonProperty("party")]
        public TaskResponsePartyType Party { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedDateTime { get; set; }
    }

    public class TaskResponseCategoryType
    {
        [JsonProperty("colour")]
        public string Colour { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class TaskResponseOwnerType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public class TaskResponsePartyType
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("pictureURL")]
        public string PictureURL { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class CreateTaskResponse
    {
        [JsonProperty("task")]
        public TaskResponse TaskObject { get; set; }
    }

    public class CreateTaskInput
    {
        [JsonProperty("task", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateTaskInputTaskObjectType TaskObject { get; set; }
    }

    public class CreateTaskInputTaskObjectType
    {
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }

        [JsonProperty("dueOn", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DueDate { get; set; }

        [JsonProperty("dueTime")]
        public string DueTime { get; set; }

        [JsonProperty("detail")]
        public string Details { get; set; }

        [JsonProperty("party")]
        public CreateTaskInputTaskObjectTypePartyType Party { get; set; }
    }

    public class CreateTaskInputTaskObjectTypePartyType
    {
        [JsonProperty("id")]
        public int? Id { get; set; }
    }

    public class CompleteTaskResponse
    {
        [JsonProperty("task")]
        public TaskResponse TaskObject { get; set; }
    }

    public class CompleteTaskInput
    {
        [JsonProperty("task", DefaultValueHandling = DefaultValueHandling.Include)]
        public CompleteTaskInputTaskObjectType TaskObject { get; set; }
    }

    public class CompleteTaskInputTaskObjectType
    {
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Status { get; set; } = "completed";
    }

    public class CreatePersonV2Response
    {
        [JsonProperty("party")]
        public PartyResponseV2 Party { get; set; }
    }

    public class PartyResponseV2
    {
        [JsonProperty("name")]
        public string OrganisationName { get; set; }

        [JsonProperty("about")]
        public string About { get; set; }

        [JsonProperty("addresses")]
        public PartyResponseV2AddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("emailAddresses")]
        public PartyResponseV2EmailAddressesTypeItem[] EmailAddresses { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("id")]
        public int PartyId { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("lastContactedAt")]
        public string LastContactedAt { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("organisation")]
        public PartyResponseV2NestedOrganisationType NestedOrganisation { get; set; }

        [JsonProperty("phoneNumbers")]
        public PartyResponseV2PhoneNumbersTypeItem[] PhoneNumbers { get; set; }

        [JsonProperty("pictureURL")]
        public string PictureURL { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("websites")]
        public PartyResponseV2WebsitesTypeItem[] Websites { get; set; }
    }

    public class PartyResponseV2AddressesTypeItem
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class PartyResponseV2EmailAddressesTypeItem
    {
        [JsonProperty("address")]
        public string EmailAddress { get; set; }

        [JsonProperty("type")]
        public string EmailType { get; set; }
    }

    public class PartyResponseV2NestedOrganisationType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pictureURL")]
        public string PictureURL { get; set; }
    }

    public class PartyResponseV2PhoneNumbersTypeItem
    {
        [JsonProperty("number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("type")]
        public string PhoneNumberType { get; set; }
    }

    public class PartyResponseV2WebsitesTypeItem
    {
        [JsonProperty("address")]
        public string WebsiteAddress { get; set; }

        [JsonProperty("service")]
        public string WebsiteService { get; set; }

        [JsonProperty("type")]
        public string WebsiteType { get; set; }
    }

    public class CreatePersonV2Input
    {
        [JsonProperty("party", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreatePersonV2InputPartyType Party { get; set; }
    }

    public class CreatePersonV2InputPartyType
    {
        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastName { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("title")]
        public CreatePersonV2InputPartyTypeTitleType? Title { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("about")]
        public string About { get; set; }

        [JsonProperty("organisation")]
        public CreatePersonV2InputPartyTypeOrganisationType Organisation { get; set; }

        [JsonProperty("phoneNumbers")]
        public CreatePersonV2InputPartyTypePhoneNumbersType PhoneNumbers { get; set; }

        [JsonProperty("emailAddresses")]
        public CreatePersonV2InputPartyTypeEmailAddressesType EmailAddresses { get; set; }

        [JsonProperty("websites")]
        public CreatePersonV2InputPartyTypeWebsitesType Websites { get; set; }

        [JsonProperty("addresses")]
        public CreatePersonV2InputPartyTypeAddressesType Addresses { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "person";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreatePersonV2InputPartyTypeTitleType
    {
        Mr,
        Master,
        Mrs,
        Miss,
        Ms,
        Dr,
        Prof
    }

    public class CreatePersonV2InputPartyTypeOrganisationType
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Id { get; set; }
    }

    public class CreatePersonV2InputPartyTypePhoneNumbersType
    {
        [JsonProperty("number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("type")]
        public CreatePersonV2InputPartyTypePhoneNumbersTypePhoneTypeType? PhoneType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreatePersonV2InputPartyTypePhoneNumbersTypePhoneTypeType
    {
        Home,
        Work,
        Mobile,
        Fax,
        Direct
    }

    public class CreatePersonV2InputPartyTypeEmailAddressesType
    {
        [JsonProperty("address")]
        public string EmailAddress { get; set; }

        [JsonProperty("type")]
        public CreatePersonV2InputPartyTypeEmailAddressesTypeEmailTypeType? EmailType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreatePersonV2InputPartyTypeEmailAddressesTypeEmailTypeType
    {
        Home,
        Work
    }

    public class CreatePersonV2InputPartyTypeWebsitesType
    {
        [JsonProperty("address")]
        public string WebsiteAddress { get; set; }

        [JsonProperty("service")]
        public CreatePersonV2InputPartyTypeWebsitesTypeWebsiteServiceType? WebsiteService { get; set; }

        [JsonProperty("type")]
        public CreatePersonV2InputPartyTypeWebsitesTypeWebsiteTypeType? WebsiteType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreatePersonV2InputPartyTypeWebsitesTypeWebsiteServiceType
    {
        FEED,
        FACEBOOK,
        FLICKR,
        GITHUB,
        [EnumMember(Value = "GOOGLE_PLUS")]
        GOOGLEPLUS,
        INSTAGRAM,
        [EnumMember(Value = "LINKED_IN")]
        LINKEDIN,
        PINTEREST,
        SKYPE,
        TWITTER,
        URL,
        XING,
        YOUTUBE
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreatePersonV2InputPartyTypeWebsitesTypeWebsiteTypeType
    {
        Home,
        Work
    }

    public class CreatePersonV2InputPartyTypeAddressesType
    {
        [JsonProperty("street")]
        public string AddressStreet { get; set; }

        [JsonProperty("city")]
        public string AddressCity { get; set; }

        [JsonProperty("state")]
        public string AddressState { get; set; }

        [JsonProperty("zip")]
        public string AddressZip { get; set; }

        [JsonProperty("country")]
        public string AddressCountry { get; set; }

        [JsonProperty("type")]
        public CreatePersonV2InputPartyTypeAddressesTypeAddressTypeType? AddressType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreatePersonV2InputPartyTypeAddressesTypeAddressTypeType
    {
        Home,
        Postal,
        Office
    }

    public class GetPartyV2Response
    {
        [JsonProperty("party")]
        public PartyResponseV2 Party { get; set; }
    }

    public class ListpartiesResponseV2
    {
        [JsonProperty("parties")]
        public ListpartiesResponseV2PartiesTypeItem[] Parties { get; set; }
    }

    public class ListpartiesResponseV2PartiesTypeItem
    {
        [JsonProperty("name")]
        public string OrganisationName { get; set; }

        [JsonProperty("about")]
        public string About { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("id")]
        public int PartyId { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("lastContactedAt")]
        public string LastContactedDateTime { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("organisation")]
        public ListpartiesResponseV2PartiesTypeItemNestedOrganisationType NestedOrganisation { get; set; }

        [JsonProperty("pictureURL")]
        public string PictureURL { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedDateTime { get; set; }
    }

    public class ListpartiesResponseV2PartiesTypeItemNestedOrganisationType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pictureURL")]
        public string PictureURL { get; set; }
    }

    public class UpdatePersonV2Response
    {
        [JsonProperty("party")]
        public PartyResponseV2 Party { get; set; }
    }

    public class UpdatePersonV2Input
    {
        [JsonProperty("party")]
        public UpdatePersonV2InputPartyType Party { get; set; }
    }

    public class UpdatePersonV2InputPartyType
    {
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("title")]
        public UpdatePersonV2InputPartyTypeTitleType? Title { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("about")]
        public string About { get; set; }

        [JsonProperty("organisation")]
        public UpdatePersonV2InputPartyTypeOrganisationType Organisation { get; set; }

        [JsonProperty("phoneNumbers")]
        public UpdatePersonV2InputPartyTypePhoneNumbersType PhoneNumbers { get; set; }

        [JsonProperty("emailAddresses")]
        public UpdatePersonV2InputPartyTypeEmailAddressesType EmailAddresses { get; set; }

        [JsonProperty("websites")]
        public UpdatePersonV2InputPartyTypeWebsitesType Websites { get; set; }

        [JsonProperty("addresses")]
        public UpdatePersonV2InputPartyTypeAddressesType Addresses { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "person";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdatePersonV2InputPartyTypeTitleType
    {
        Mr,
        Master,
        Mrs,
        Miss,
        Ms,
        Dr,
        Prof
    }

    public class UpdatePersonV2InputPartyTypeOrganisationType
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Id { get; set; }
    }

    public class UpdatePersonV2InputPartyTypePhoneNumbersType
    {
        [JsonProperty("number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("type")]
        public UpdatePersonV2InputPartyTypePhoneNumbersTypePhoneTypeType? PhoneType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdatePersonV2InputPartyTypePhoneNumbersTypePhoneTypeType
    {
        Home,
        Work,
        Mobile,
        Fax,
        Direct
    }

    public class UpdatePersonV2InputPartyTypeEmailAddressesType
    {
        [JsonProperty("address")]
        public string EmailAddress { get; set; }

        [JsonProperty("type")]
        public UpdatePersonV2InputPartyTypeEmailAddressesTypeEmailTypeType? EmailType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdatePersonV2InputPartyTypeEmailAddressesTypeEmailTypeType
    {
        Home,
        Work
    }

    public class UpdatePersonV2InputPartyTypeWebsitesType
    {
        [JsonProperty("address")]
        public string WebsiteAddress { get; set; }

        [JsonProperty("service")]
        public UpdatePersonV2InputPartyTypeWebsitesTypeWebsiteServiceType? WebsiteService { get; set; }

        [JsonProperty("type")]
        public UpdatePersonV2InputPartyTypeWebsitesTypeWebsiteTypeType? WebsiteType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdatePersonV2InputPartyTypeWebsitesTypeWebsiteServiceType
    {
        FEED,
        FACEBOOK,
        FLICKR,
        GITHUB,
        [EnumMember(Value = "GOOGLE_PLUS")]
        GOOGLEPLUS,
        INSTAGRAM,
        [EnumMember(Value = "LINKED_IN")]
        LINKEDIN,
        PINTEREST,
        SKYPE,
        TWITTER,
        URL,
        XING,
        YOUTUBE
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdatePersonV2InputPartyTypeWebsitesTypeWebsiteTypeType
    {
        Home,
        Work
    }

    public class UpdatePersonV2InputPartyTypeAddressesType
    {
        [JsonProperty("street")]
        public string AddressStreet { get; set; }

        [JsonProperty("city")]
        public string AddressCity { get; set; }

        [JsonProperty("state")]
        public string AddressState { get; set; }

        [JsonProperty("zip")]
        public string AddressZip { get; set; }

        [JsonProperty("country")]
        public string AddressCountry { get; set; }

        [JsonProperty("type")]
        public UpdatePersonV2InputPartyTypeAddressesTypeAddressTypeType? AddressType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdatePersonV2InputPartyTypeAddressesTypeAddressTypeType
    {
        Home,
        Postal,
        Office
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Capsulecrm;

    public partial class WorkflowManagedActions
    {
        public CapsulecrmActions Capsulecrm(string connectionId) => new CapsulecrmActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CapsulecrmTriggers Capsulecrm(string connectionId) => new CapsulecrmTriggers(connectionId);
    }
}