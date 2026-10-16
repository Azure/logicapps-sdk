//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Truedialogsms
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class TruedialogsmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "truedialogsms")]
        public IBodyWorkflowAction<AccountResponse> AccountGetInfo(Expression<Func<string>> accountId)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            return new DeferredBodyAction<AccountResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/account/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_accountId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AccountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "truedialogsms")]
        public IBodyWorkflowAction<ContactSearchRequestItem[]> ContactSearch(Expression<Func<string>> accountId, Expression<Func<string>> phone)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_phone = WorkflowExpression.Compile(phone, nameof(phone), required: true);
            return new DeferredBodyAction<ContactSearchRequestItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/account/{0}/contact-search/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_phone, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ContactSearchRequestItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "truedialogsms")]
        public IBodyWorkflowAction<ContactResponse> ContactCreate(Expression<Func<string>> accountId, Expression<Func<string>> bodyphoneNumber = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_bodyphoneNumber = WorkflowExpression.Compile(bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            return new DeferredBodyAction<ContactResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/account/{0}/contact", ExpressionConverter.ConvertWithUrlEncoding(__workflow_accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyphoneNumber != null)
                {
                    body["PhoneNumber"] = ExpressionConverter.ConvertO(__workflow_bodyphoneNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["Email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstName != null)
                {
                    body["FirstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["LastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "truedialogsms")]
        public IBodyWorkflowAction<ContactResponse> ContactUpdate(Expression<Func<string>> accountId, Expression<Func<string>> contactid, Expression<Func<string>> bodyphoneNumber = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_contactid = WorkflowExpression.Compile(contactid, nameof(contactid), required: true);
            var __workflow_bodyphoneNumber = WorkflowExpression.Compile(bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            return new DeferredBodyAction<ContactResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/account/{0}/contact/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_contactid, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyphoneNumber != null)
                {
                    body["PhoneNumber"] = ExpressionConverter.ConvertO(__workflow_bodyphoneNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["Email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstName != null)
                {
                    body["FirstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["LastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "truedialogsms")]
        public IBodyWorkflowAction<PushCampaignResponse> CampaignPush(Expression<Func<string>> accountId, Expression<Func<string[]>> bodychannels, Expression<Func<string[]>> bodytargets, Expression<Func<string>> bodymessage, Expression<Func<bool>> bodyexecute, Expression<Func<string[]>> bodycontactListIds = null, Expression<Func<string[]>> bodyexcludeListIds = null, Expression<Func<int>> bodymediaId = null, Expression<Func<bool>> bodyignoreSingleUse = null, Expression<Func<bool>> bodyforceOptIn = null, Expression<Func<string[]>> bodyschedules = null, Expression<Func<bool>> bodyignoreInvalidTargets = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_bodychannels = WorkflowExpression.Compile(bodychannels, nameof(bodychannels), required: true);
            var __workflow_bodytargets = WorkflowExpression.Compile(bodytargets, nameof(bodytargets), required: true);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: true);
            var __workflow_bodyexecute = WorkflowExpression.Compile(bodyexecute, nameof(bodyexecute), required: true);
            var __workflow_bodycontactListIds = WorkflowExpression.Compile(bodycontactListIds, nameof(bodycontactListIds), required: false);
            var __workflow_bodyexcludeListIds = WorkflowExpression.Compile(bodyexcludeListIds, nameof(bodyexcludeListIds), required: false);
            var __workflow_bodymediaId = WorkflowExpression.Compile(bodymediaId, nameof(bodymediaId), required: false);
            var __workflow_bodyignoreSingleUse = WorkflowExpression.Compile(bodyignoreSingleUse, nameof(bodyignoreSingleUse), required: false);
            var __workflow_bodyforceOptIn = WorkflowExpression.Compile(bodyforceOptIn, nameof(bodyforceOptIn), required: false);
            var __workflow_bodyschedules = WorkflowExpression.Compile(bodyschedules, nameof(bodyschedules), required: false);
            var __workflow_bodyignoreInvalidTargets = WorkflowExpression.Compile(bodyignoreInvalidTargets, nameof(bodyignoreInvalidTargets), required: false);
            return new DeferredBodyAction<PushCampaignResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/account/{0}/action-pushcampaign", ExpressionConverter.ConvertWithUrlEncoding(__workflow_accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Channels"] = ExpressionConverter.ConvertO(__workflow_bodychannels);
                bodypropCount++;
                body["Targets"] = ExpressionConverter.ConvertO(__workflow_bodytargets);
                if (__workflow_bodycontactListIds != null)
                {
                    body["ContactListIds"] = ExpressionConverter.ConvertO(__workflow_bodycontactListIds);
                    bodypropCount++;
                }

                if (__workflow_bodyexcludeListIds != null)
                {
                    body["ExcludeListIds"] = ExpressionConverter.ConvertO(__workflow_bodyexcludeListIds);
                    bodypropCount++;
                }

                body["CampaignId"] = 0;
                bodypropCount++;
                if (__workflow_bodymediaId != null)
                {
                    body["MediaId"] = ExpressionConverter.ConvertO(__workflow_bodymediaId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                if (__workflow_bodyignoreSingleUse != null)
                {
                    body["IgnoreSingleUse"] = ExpressionConverter.ConvertO(__workflow_bodyignoreSingleUse);
                    bodypropCount++;
                }

                if (__workflow_bodyforceOptIn != null)
                {
                    if (__workflow_bodyforceOptIn != null)
                    {
                        body["ForceOptIn"] = ExpressionConverter.ConvertO(__workflow_bodyforceOptIn);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["ForceOptIn"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyschedules != null)
                {
                    body["Schedules"] = ExpressionConverter.ConvertO(__workflow_bodyschedules);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Execute"] = ExpressionConverter.ConvertO(__workflow_bodyexecute);
                if (__workflow_bodyignoreInvalidTargets != null)
                {
                    if (__workflow_bodyignoreInvalidTargets != null)
                    {
                        body["IgnoreInvalidTargets"] = ExpressionConverter.ConvertO(__workflow_bodyignoreInvalidTargets);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["IgnoreInvalidTargets"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PushCampaignResponse>(callPayload);
            });
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
        public IBodyWorkflowTrigger<CallbackCreatedResponse> IncomingSMSReceived(Expression<Func<string>> accountId, FlowRecurrence recurrence = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            return new DeferredBodyTrigger<CallbackCreatedResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/account/{0}/callback", ExpressionConverter.ConvertWithUrlEncoding(__workflow_accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["CallbackType"] = 11;
                bodypropCount++;
                body["URL"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["Active"] = true;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<CallbackCreatedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CallbackCreatedResponse> KeywordReceived(Expression<Func<string>> accountId, FlowRecurrence recurrence = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            return new DeferredBodyTrigger<CallbackCreatedResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/account/{0}/callback/-1", ExpressionConverter.ConvertWithUrlEncoding(__workflow_accountId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["CallbackType"] = 1;
                bodypropCount++;
                body["URL"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["Active"] = true;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<CallbackCreatedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CallbackCreatedResponse> StopReceived(Expression<Func<string>> accountId, FlowRecurrence recurrence = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            return new DeferredBodyTrigger<CallbackCreatedResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/account/{0}/callback/-6", ExpressionConverter.ConvertWithUrlEncoding(__workflow_accountId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["CallbackType"] = 6;
                bodypropCount++;
                body["URL"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["Active"] = true;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<CallbackCreatedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CallbackCreatedResponse> DeliveryNoticeReceived(Expression<Func<string>> accountId, FlowRecurrence recurrence = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            return new DeferredBodyTrigger<CallbackCreatedResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/account/{0}/callback/-12", ExpressionConverter.ConvertWithUrlEncoding(__workflow_accountId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["CallbackType"] = 12;
                bodypropCount++;
                body["URL"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["Active"] = true;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<CallbackCreatedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CallbackCreatedResponse> InvalidTargets(Expression<Func<string>> accountId, FlowRecurrence recurrence = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            return new DeferredBodyTrigger<CallbackCreatedResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/account/{0}/callback/-13", ExpressionConverter.ConvertWithUrlEncoding(__workflow_accountId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["CallbackType"] = 13;
                bodypropCount++;
                body["URL"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["Active"] = true;
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
