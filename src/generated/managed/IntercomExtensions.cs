//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Intercom
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IntercomActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intercom")]
        [WorkflowExpressionFactory(nameof(__BuildCreateUser))]
        public IBodyWorkflowAction<UserResponse> CreateUser([WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodycompanyId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intercom")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserResponse> __BuildCreateUser(WorkflowExpression<string> bodyemail, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodyphone = null, WorkflowExpression<string> bodycompanyId = null)
        {
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            WorkflowExpression.Validate(bodycompanyId, nameof(bodycompanyId), required: false);
            return new DeferredBodyAction<UserResponse>(() =>
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(bodyphone);
                    bodypropCount++;
                }

                if (bodycompanyId != null)
                {
                    body["companies"] = ExpressionConverter.ConvertO(bodycompanyId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intercom")]
        public IBodyWorkflowAction<LeadResponse[]> ListLeads()
        {
            var apiCallPath = "/contacts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LeadResponse[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intercom")]
        [WorkflowExpressionFactory(nameof(__BuildCreateLead))]
        public IBodyWorkflowAction<LeadResponse> CreateLead([WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodyavatarimageURL = null, [WorkflowExpression] Func<string> bodycompanyId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intercom")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LeadResponse> __BuildCreateLead(WorkflowExpression<string> bodyemail, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodyphone = null, WorkflowExpression<string> bodyavatarimageURL = null, WorkflowExpression<string> bodycompanyId = null)
        {
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            WorkflowExpression.Validate(bodyavatarimageURL, nameof(bodyavatarimageURL), required: false);
            WorkflowExpression.Validate(bodycompanyId, nameof(bodycompanyId), required: false);
            return new DeferredBodyAction<LeadResponse>(() =>
            {
                var apiCallPath = "/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(bodyphone);
                    bodypropCount++;
                }

                var avatarObject = new JObject();
                var avatarObjectpropCount = 0;
                if (bodyavatarimageURL != null)
                {
                    avatarObject["image_url"] = ExpressionConverter.ConvertO(bodyavatarimageURL);
                    avatarObjectpropCount++;
                }

                if (avatarObjectpropCount > 0)
                {
                    body["avatar"] = avatarObject;
                    bodypropCount++;
                }

                if (bodycompanyId != null)
                {
                    body["companies"] = ExpressionConverter.ConvertO(bodycompanyId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LeadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intercom")]
        [WorkflowExpressionFactory(nameof(__BuildGetUser))]
        public IBodyWorkflowAction<UserResponse> GetUser([WorkflowExpression] Func<string> userId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intercom")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserResponse> __BuildGetUser(WorkflowExpression<string> userId)
        {
            WorkflowExpression.Validate(userId, nameof(userId), required: true);
            return new DeferredBodyAction<UserResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intercom")]
        [WorkflowExpressionFactory(nameof(__BuildGetLead))]
        public IBodyWorkflowAction<LeadResponse> GetLead([WorkflowExpression] Func<string> contactId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intercom")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LeadResponse> __BuildGetLead(WorkflowExpression<string> contactId)
        {
            WorkflowExpression.Validate(contactId, nameof(contactId), required: true);
            return new DeferredBodyAction<LeadResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LeadResponse>(callPayload);
            });
        }
    }

    public class IntercomTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TrigLeadResponse[]> TrigNewLead(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/create_lead_trigger/contacts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<TrigLeadResponse[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<TrigUserResponse[]> TrigNewUser(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/create_user_trigger/users";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<TrigUserResponse[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<TrigUserResponse[]> TrigUpdateUser(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/update_user_trigger/users";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<TrigUserResponse[]>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<TrigConversationResponse[]> TrigNewConversation(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/create_conversation_trigger/conversations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<TrigConversationResponse[]>(callPayload, recurrence: recurrence);
        }
    }

    public class UserResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("session_count")]
        public int SessionCount { get; set; }

        [JsonProperty("avatar")]
        public UserResponseAvatarType Avatar { get; set; }

        [JsonProperty("unsubscribed_from_emails")]
        public bool IsUnsubscribed { get; set; }

        [JsonProperty("location_data")]
        public UserResponseLocationDataType LocationData { get; set; }

        [JsonProperty("pseudonym")]
        public string Pseudonym { get; set; }
    }

    public class UserResponseAvatarType
    {
        [JsonProperty("image_url")]
        public string ImageURL { get; set; }
    }

    public class UserResponseLocationDataType
    {
        [JsonProperty("city_name")]
        public string CityName { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("region_name")]
        public string RegionName { get; set; }

        [JsonProperty("timezone")]
        public string TimeZone { get; set; }
    }

    public class LeadResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("user_id")]
        public string LeadId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("avatar")]
        public LeadResponseAvatarType Avatar { get; set; }

        [JsonProperty("unsubscribed_from_emails")]
        public bool IsUnsubscribed { get; set; }

        [JsonProperty("location_data")]
        public LeadResponseLocationDataType LocationData { get; set; }
    }

    public class LeadResponseAvatarType
    {
        [JsonProperty("image_url")]
        public string ImageURL { get; set; }
    }

    public class LeadResponseLocationDataType
    {
        [JsonProperty("city_name")]
        public string CityName { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("region_name")]
        public string RegionName { get; set; }

        [JsonProperty("timezone")]
        public string TimeZone { get; set; }
    }

    public class TrigLeadResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("avatar")]
        public TrigLeadResponseAvatarType Avatar { get; set; }

        [JsonProperty("unsubscribed_from_emails")]
        public bool IsUnsubscribed { get; set; }

        [JsonProperty("location_data")]
        public TrigLeadResponseLocationDataType LocationData { get; set; }

        [JsonProperty("companies")]
        public TrigLeadResponseCompaniesType Companies { get; set; }

        [JsonProperty("tags")]
        public TrigLeadResponseTagsType Tags { get; set; }
    }

    public class TrigLeadResponseAvatarType
    {
        [JsonProperty("image_url")]
        public string ImageURL { get; set; }
    }

    public class TrigLeadResponseLocationDataType
    {
        [JsonProperty("city_name")]
        public string CityName { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("region_name")]
        public string RegionName { get; set; }

        [JsonProperty("timezone")]
        public string TimeZone { get; set; }
    }

    public class TrigLeadResponseCompaniesType
    {
        [JsonProperty("companies")]
        public TrigLeadResponseCompaniesTypeCompaniesTypeItem[] Companies { get; set; }
    }

    public class TrigLeadResponseCompaniesTypeCompaniesTypeItem
    {
        [JsonProperty("name")]
        public string CompanyName { get; set; }
    }

    public class TrigLeadResponseTagsType
    {
        [JsonProperty("companies")]
        public TrigLeadResponseTagsTypeCompaniesTypeItem[] Companies { get; set; }
    }

    public class TrigLeadResponseTagsTypeCompaniesTypeItem
    {
        [JsonProperty("name")]
        public string TagName { get; set; }
    }

    public class TrigUserResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("session_count")]
        public int SessionCount { get; set; }

        [JsonProperty("avatar")]
        public TrigUserResponseAvatarType Avatar { get; set; }

        [JsonProperty("unsubscribed_from_emails")]
        public bool IsUnsubscribed { get; set; }

        [JsonProperty("location_data")]
        public TrigUserResponseLocationDataType LocationData { get; set; }

        [JsonProperty("pseudonym")]
        public string Pseudonym { get; set; }

        [JsonProperty("companies")]
        public TrigUserResponseCompaniesType Companies { get; set; }

        [JsonProperty("tags")]
        public TrigUserResponseTagsType Tags { get; set; }
    }

    public class TrigUserResponseAvatarType
    {
        [JsonProperty("image_url")]
        public string ImageURL { get; set; }
    }

    public class TrigUserResponseLocationDataType
    {
        [JsonProperty("city_name")]
        public string CityName { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("region_name")]
        public string RegionName { get; set; }

        [JsonProperty("timezone")]
        public string TimeZone { get; set; }
    }

    public class TrigUserResponseCompaniesType
    {
        [JsonProperty("companies")]
        public TrigUserResponseCompaniesTypeCompaniesTypeItem[] Companies { get; set; }
    }

    public class TrigUserResponseCompaniesTypeCompaniesTypeItem
    {
        [JsonProperty("name")]
        public string CompanyName { get; set; }
    }

    public class TrigUserResponseTagsType
    {
        [JsonProperty("companies")]
        public TrigUserResponseTagsTypeCompaniesTypeItem[] Companies { get; set; }
    }

    public class TrigUserResponseTagsTypeCompaniesTypeItem
    {
        [JsonProperty("name")]
        public string TagName { get; set; }
    }

    public class TrigConversationResponse
    {
        [JsonProperty("assignee")]
        public TrigConversationResponseAssigneeType Assignee { get; set; }

        [JsonProperty("conversation_message")]
        public TrigConversationResponseConversationMessageType ConversationMessage { get; set; }

        [JsonProperty("created_at")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("user")]
        public TrigConversationResponseUserType User { get; set; }
    }

    public class TrigConversationResponseAssigneeType
    {
        [JsonProperty("id")]
        public string AdminId { get; set; }
    }

    public class TrigConversationResponseConversationMessageType
    {
        [JsonProperty("author")]
        public TrigConversationResponseConversationMessageTypeAuthorType Author { get; set; }

        [JsonProperty("body")]
        public string Text { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("url")]
        public string MessageURL { get; set; }
    }

    public class TrigConversationResponseConversationMessageTypeAuthorType
    {
        [JsonProperty("id")]
        public string AuthorId { get; set; }

        [JsonProperty("type")]
        public string AuthorType { get; set; }
    }

    public class TrigConversationResponseUserType
    {
        [JsonProperty("id")]
        public string UserId { get; set; }

        [JsonProperty("type")]
        public string UserType { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Intercom;

    public partial class WorkflowManagedActions
    {
        public IntercomActions Intercom(string connectionId) => new IntercomActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IntercomTriggers Intercom(string connectionId) => new IntercomTriggers(connectionId);
    }
}