//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Truedialogsms
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TruedialogsmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "truedialogsms")]
        public IBodyWorkflowAction<AccountResponse, ApiConnectionActionConfiguration> AccountGetInfo(Expression<Func<string>> accountId)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            return new DeferredBodyAction<AccountResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/account/{0}", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AccountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "truedialogsms")]
        public IBodyWorkflowAction<ContactSearchRequestItem[], ApiConnectionActionConfiguration> ContactSearch(Expression<Func<string>> accountId, Expression<Func<string>> phone)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_phone = WorkflowExpression.Compile(phone, nameof(phone), required: true);
            return new DeferredBodyAction<ContactSearchRequestItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/account/{0}/contact-search/{1}", __workflow_accountId.WithUrlEncoding(1), __workflow_phone.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ContactSearchRequestItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "truedialogsms")]
        public IBodyWorkflowAction<ContactResponse, ApiConnectionActionConfiguration> ContactCreate(Expression<Func<string>> accountId, Expression<Func<ContactCreateInput>> body = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/account/{0}/contact", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "truedialogsms")]
        public IBodyWorkflowAction<ContactResponse, ApiConnectionActionConfiguration> ContactUpdate(Expression<Func<string>> accountId, Expression<Func<string>> contactid, Expression<Func<ContactUpdateInput>> body = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_contactid = WorkflowExpression.Compile(contactid, nameof(contactid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/account/{0}/contact/{1}", __workflow_accountId.WithUrlEncoding(1), __workflow_contactid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "truedialogsms")]
        public IBodyWorkflowAction<PushCampaignResponse, ApiConnectionActionConfiguration> CampaignPush(Expression<Func<string>> accountId, Expression<Func<CampaignPushInput>> body)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PushCampaignResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/account/{0}/action-pushcampaign", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PushCampaignResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "truedialogsms")]
        public IBodyWorkflowAction<UserResponse, ApiConnectionActionConfiguration> UserGetSelfInfo()
        {
            return new DeferredBodyAction<UserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/userinfo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserResponse>(callPayload);
            });
        }
    }

    public class TruedialogsmsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CallbackCreatedResponse, ApiConnectionTriggerConfiguration> IncomingSMSReceived(Expression<Func<string>> accountId, Expression<Func<IncomingSMSReceivedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<CallbackCreatedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/account/{0}/callback", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<CallbackCreatedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CallbackCreatedResponse, ApiConnectionTriggerConfiguration> KeywordReceived(Expression<Func<string>> accountId, Expression<Func<KeywordReceivedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<CallbackCreatedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/account/{0}/callback/-1", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<CallbackCreatedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CallbackCreatedResponse, ApiConnectionTriggerConfiguration> StopReceived(Expression<Func<string>> accountId, Expression<Func<StopReceivedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<CallbackCreatedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/account/{0}/callback/-6", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<CallbackCreatedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CallbackCreatedResponse, ApiConnectionTriggerConfiguration> DeliveryNoticeReceived(Expression<Func<string>> accountId, Expression<Func<DeliveryNoticeReceivedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<CallbackCreatedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/account/{0}/callback/-12", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<CallbackCreatedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CallbackCreatedResponse, ApiConnectionTriggerConfiguration> InvalidTargets(Expression<Func<string>> accountId, Expression<Func<InvalidTargetsInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<CallbackCreatedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/account/{0}/callback/-13", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<CallbackCreatedResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class AccountResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("parentId")]
        public int ParentId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("allowCallback")]
        public bool AllowCallback { get; set; }

        [JsonProperty("callbackToken")]
        public string CallbackToken { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("accountType")]
        public int AccountType { get; set; }

        [JsonProperty("isApproved")]
        public bool IsApproved { get; set; }
    }

    public class ContactSearchRequestItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("accountId")]
        public int AccountId { get; set; }

        [JsonProperty("statusId")]
        public int StatusId { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("assignedId")]
        public string AssignedId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("subscriptions")]
        public JToken[] Subscriptions { get; set; }

        [JsonProperty("attributes")]
        public JToken[] Attributes { get; set; }

        [JsonProperty("phoneStatusId")]
        public int PhoneStatusId { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("modifiedBy")]
        public string ModifiedBy { get; set; }
    }

    public class ContactResponse
    {
        [JsonProperty("accountId")]
        public int AccountId { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("preferredLanguageId")]
        public string PreferredLanguageId { get; set; }

        [JsonProperty("preferredLanguage")]
        public string PreferredLanguage { get; set; }

        [JsonProperty("assignedId")]
        public string AssignedId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneStatusId")]
        public int PhoneStatusId { get; set; }

        [JsonProperty("phoneStatus")]
        public int PhoneStatus { get; set; }

        [JsonProperty("phoneHardErrorCount")]
        public int PhoneHardErrorCount { get; set; }

        [JsonProperty("phoneSoftErrorCount")]
        public int PhoneSoftErrorCount { get; set; }

        [JsonProperty("phoneTotalHardErrorCount")]
        public int PhoneTotalHardErrorCount { get; set; }

        [JsonProperty("phoneTotalSoftErrorCount")]
        public int PhoneTotalSoftErrorCount { get; set; }

        [JsonProperty("phoneLastHardError")]
        public string PhoneLastHardError { get; set; }

        [JsonProperty("phoneLastSoftError")]
        public string PhoneLastSoftError { get; set; }

        [JsonProperty("phoneHardErrorSince")]
        public string PhoneHardErrorSince { get; set; }

        [JsonProperty("phoneSoftErrorSince")]
        public string PhoneSoftErrorSince { get; set; }

        [JsonProperty("statusId")]
        public int StatusId { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("modifiedBy")]
        public string ModifiedBy { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class ContactCreateInput
    {
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class ContactUpdateInput
    {
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class PushCampaignResponse
    {
        [JsonProperty("channels")]
        public JToken[] Channels { get; set; }

        [JsonProperty("targets")]
        public string[] Targets { get; set; }

        [JsonProperty("targetsUrl")]
        public string TargetsUrl { get; set; }

        [JsonProperty("targetsColumn")]
        public string TargetsColumn { get; set; }

        [JsonProperty("contactListIds")]
        public JToken[] ContactListIds { get; set; }

        [JsonProperty("excludeListIds")]
        public JToken[] ExcludeListIds { get; set; }

        [JsonProperty("campaignId")]
        public int CampaignId { get; set; }

        [JsonProperty("mediaId")]
        public string MediaId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("ignoreSingleUse")]
        public bool IgnoreSingleUse { get; set; }

        [JsonProperty("forceOptIn")]
        public bool ForceOptIn { get; set; }

        [JsonProperty("statusId")]
        public int StatusId { get; set; }

        [JsonProperty("roundRobinById")]
        public bool RoundRobinById { get; set; }

        [JsonProperty("globalRoundRobin")]
        public bool GlobalRoundRobin { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("accountId")]
        public int AccountId { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("modifiedBy")]
        public string ModifiedBy { get; set; }

        [JsonProperty("schedules")]
        public JToken[] Schedules { get; set; }
    }

    public class CampaignPushInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Channels { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Targets { get; set; }
        public string[] ContactListIds { get; set; }
        public string[] ExcludeListIds { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal int CampaignId { get; set; } = 0;
        public int? MediaId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }
        public bool? IgnoreSingleUse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ForceOptIn { get; set; } = false;
        public string[] Schedules { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Execute { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IgnoreInvalidTargets { get; set; } = false;
    }

    public class UserResponse
    {
        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("accountId")]
        public int AccountId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("isAdmin")]
        public bool IsAdmin { get; set; }

        [JsonProperty("apiKey")]
        public UserResponseApiKeyType ApiKey { get; set; }

        [JsonProperty("isChatUser")]
        public bool IsChatUser { get; set; }

        [JsonProperty("reportOnly")]
        public bool ReportOnly { get; set; }

        [JsonProperty("requestNumber")]
        public bool RequestNumber { get; set; }

        [JsonProperty("canCreateContact")]
        public bool CanCreateContact { get; set; }

        [JsonProperty("isAlertAgent")]
        public bool IsAlertAgent { get; set; }

        [JsonProperty("agreed")]
        public bool Agreed { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("isApproved")]
        public bool IsApproved { get; set; }

        [JsonProperty("isLockedOut")]
        public bool IsLockedOut { get; set; }

        [JsonProperty("lastLockoutDate")]
        public string LastLockoutDate { get; set; }

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("lastLoginDate")]
        public string LastLoginDate { get; set; }

        [JsonProperty("lastActivityDate")]
        public string LastActivityDate { get; set; }

        [JsonProperty("lastPasswordChangedDate")]
        public string LastPasswordChangedDate { get; set; }
    }

    public class UserResponseApiKeyType
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("lastActivity")]
        public string LastActivity { get; set; }

        [JsonProperty("typeId")]
        public int TypeId { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("validTo")]
        public string ValidTo { get; set; }

        [JsonProperty("accountId")]
        public int AccountId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class CallbackCreatedResponse
    {
        [JsonProperty("accountId")]
        public int AccountId { get; set; }

        [JsonProperty("callbackTypeId")]
        public int CallbackTypeId { get; set; }
        public string Url { get; set; }
        public bool Active { get; set; }

        [JsonProperty("callbackType")]
        public int CallbackType { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class IncomingSMSReceivedInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal int CallbackType { get; set; } = 11;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string URL { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Active { get; set; } = true;
    }

    public class KeywordReceivedInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal int CallbackType { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string URL { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Active { get; set; } = true;
    }

    public class StopReceivedInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal int CallbackType { get; set; } = 6;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string URL { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Active { get; set; } = true;
    }

    public class DeliveryNoticeReceivedInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal int CallbackType { get; set; } = 12;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string URL { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Active { get; set; } = true;
    }

    public class InvalidTargetsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal int CallbackType { get; set; } = 13;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string URL { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Active { get; set; } = true;
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Truedialogsms;

    public partial class WorkflowManagedActions
    {
        public TruedialogsmsActions Truedialogsms(string connectionId) => new TruedialogsmsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TruedialogsmsTriggers Truedialogsms(string connectionId) => new TruedialogsmsTriggers(connectionId);
    }
}