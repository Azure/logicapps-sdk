//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Truedialogsms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TruedialogsmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "truedialogsms")]
        public IBodyWorkflowAction<AccountResponse> AccountGetInfo(Expression<Func<string>> accountId)
        {
            var apiCallPath = String.Format("/account/{0}", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AccountResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "truedialogsms")]
        public IBodyWorkflowAction<ContactSearchRequestItem[]> ContactSearch(Expression<Func<string>> accountId, Expression<Func<string>> phone)
        {
            var apiCallPath = String.Format("/account/{0}/contact-search/{1}", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(phone, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ContactSearchRequestItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "truedialogsms")]
        public IBodyWorkflowAction<ContactResponse> ContactCreate(Expression<Func<string>> accountId, Expression<Func<string>> bodyPhoneNumber = null, Expression<Func<string>> bodyEmail = null, Expression<Func<string>> bodyFirstName = null, Expression<Func<string>> bodyLastName = null)
        {
            var apiCallPath = String.Format("/account/{0}/contact", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyPhoneNumber != null)
            {
                body["PhoneNumber"] = ExpressionConverter.ConvertO(bodyPhoneNumber);
                bodypropCount++;
            }

            if (bodyEmail != null)
            {
                body["Email"] = ExpressionConverter.ConvertO(bodyEmail);
                bodypropCount++;
            }

            if (bodyFirstName != null)
            {
                body["FirstName"] = ExpressionConverter.ConvertO(bodyFirstName);
                bodypropCount++;
            }

            if (bodyLastName != null)
            {
                body["LastName"] = ExpressionConverter.ConvertO(bodyLastName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "truedialogsms")]
        public IBodyWorkflowAction<ContactResponse> ContactUpdate(Expression<Func<string>> accountId, Expression<Func<string>> contactid, Expression<Func<string>> bodyPhoneNumber = null, Expression<Func<string>> bodyEmail = null, Expression<Func<string>> bodyFirstName = null, Expression<Func<string>> bodyLastName = null)
        {
            var apiCallPath = String.Format("/account/{0}/contact/{1}", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(contactid, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyPhoneNumber != null)
            {
                body["PhoneNumber"] = ExpressionConverter.ConvertO(bodyPhoneNumber);
                bodypropCount++;
            }

            if (bodyEmail != null)
            {
                body["Email"] = ExpressionConverter.ConvertO(bodyEmail);
                bodypropCount++;
            }

            if (bodyFirstName != null)
            {
                body["FirstName"] = ExpressionConverter.ConvertO(bodyFirstName);
                bodypropCount++;
            }

            if (bodyLastName != null)
            {
                body["LastName"] = ExpressionConverter.ConvertO(bodyLastName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "truedialogsms")]
        public IBodyWorkflowAction<PushCampaignResponse> CampaignPush(Expression<Func<string>> accountId, Expression<Func<string[]>> bodyChannels, Expression<Func<string[]>> bodyTargets, Expression<Func<string>> bodyMessage, Expression<Func<bool>> bodyExecute, Expression<Func<string[]>> bodyContactListIds = null, Expression<Func<string[]>> bodyExcludeListIds = null, Expression<Func<int>> bodyMediaId = null, Expression<Func<bool>> bodyIgnoreSingleUse = null, Expression<Func<bool>> bodyForceOptIn = null, Expression<Func<string[]>> bodySchedules = null, Expression<Func<bool>> bodyIgnoreInvalidTargets = null)
        {
            var apiCallPath = String.Format("/account/{0}/action-pushcampaign", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Channels"] = ExpressionConverter.ConvertO(bodyChannels);
            bodypropCount++;
            body["Targets"] = ExpressionConverter.ConvertO(bodyTargets);
            if (bodyContactListIds != null)
            {
                body["ContactListIds"] = ExpressionConverter.ConvertO(bodyContactListIds);
                bodypropCount++;
            }

            if (bodyExcludeListIds != null)
            {
                body["ExcludeListIds"] = ExpressionConverter.ConvertO(bodyExcludeListIds);
                bodypropCount++;
            }

            body["CampaignId"] = 0;
            bodypropCount++;
            if (bodyMediaId != null)
            {
                body["MediaId"] = ExpressionConverter.ConvertO(bodyMediaId);
                bodypropCount++;
            }

            bodypropCount++;
            body["Message"] = ExpressionConverter.ConvertO(bodyMessage);
            if (bodyIgnoreSingleUse != null)
            {
                body["IgnoreSingleUse"] = ExpressionConverter.ConvertO(bodyIgnoreSingleUse);
                bodypropCount++;
            }

            if (bodyForceOptIn != null)
            {
                body["ForceOptIn"] = ExpressionConverter.ConvertO(bodyForceOptIn);
                bodypropCount++;
            }

            if (bodySchedules != null)
            {
                body["Schedules"] = ExpressionConverter.ConvertO(bodySchedules);
                bodypropCount++;
            }

            bodypropCount++;
            body["Execute"] = ExpressionConverter.ConvertO(bodyExecute);
            if (bodyIgnoreInvalidTargets != null)
            {
                body["IgnoreInvalidTargets"] = ExpressionConverter.ConvertO(bodyIgnoreInvalidTargets);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PushCampaignResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "truedialogsms")]
        public IBodyWorkflowAction<UserResponse> UserGetSelfInfo()
        {
            var apiCallPath = "/userinfo";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserResponse>(callPayload);
        }
    }

    public class TruedialogsmsTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<CallbackCreatedResponse> IncomingSMSReceived(Expression<Func<string>> accountId, string triggerName = null)
        {
            var apiCallPath = String.Format("/account/{0}/callback", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackType"] = 11;
            bodypropCount++;
            body["URL"] = "@listcallbackurl()";
            bodypropCount++;
            body["Active"] = true;
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<CallbackCreatedResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<CallbackCreatedResponse> KeywordReceived(Expression<Func<string>> accountId, string triggerName = null)
        {
            var apiCallPath = String.Format("/account/{0}/callback/-1", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackType"] = 1;
            bodypropCount++;
            body["URL"] = "@listcallbackurl()";
            bodypropCount++;
            body["Active"] = true;
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<CallbackCreatedResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<CallbackCreatedResponse> StopReceived(Expression<Func<string>> accountId, string triggerName = null)
        {
            var apiCallPath = String.Format("/account/{0}/callback/-6", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackType"] = 6;
            bodypropCount++;
            body["URL"] = "@listcallbackurl()";
            bodypropCount++;
            body["Active"] = true;
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<CallbackCreatedResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<CallbackCreatedResponse> DeliveryNoticeReceived(Expression<Func<string>> accountId, string triggerName = null)
        {
            var apiCallPath = String.Format("/account/{0}/callback/-12", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackType"] = 12;
            bodypropCount++;
            body["URL"] = "@listcallbackurl()";
            bodypropCount++;
            body["Active"] = true;
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<CallbackCreatedResponse>(callPayload);
        }

        public IOutputWorkflowTrigger<CallbackCreatedResponse> InvalidTargets(Expression<Func<string>> accountId, string triggerName = null)
        {
            var apiCallPath = String.Format("/account/{0}/callback/-13", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            body["CallbackType"] = 13;
            bodypropCount++;
            body["URL"] = "@listcallbackurl()";
            bodypropCount++;
            body["Active"] = true;
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<CallbackCreatedResponse>(callPayload);
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