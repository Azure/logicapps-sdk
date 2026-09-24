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
        public IBodyWorkflowAction<AccountResponse> AccountGetInfo([WorkflowExpression] Func<string> accountId)
        {
            SourceExpression.Validate(accountId, nameof(accountId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/account/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AccountResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "truedialogsms")]
        public IBodyWorkflowAction<ContactSearchRequestItem[]> ContactSearch([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> phone)
        {
            SourceExpression.Validate(accountId, nameof(accountId), required: true);
            SourceExpression.Validate(phone, nameof(phone), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/account/{0}/contact-search/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(phone, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ContactSearchRequestItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "truedialogsms")]
        public IBodyWorkflowAction<ContactResponse> ContactCreate([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> bodyphoneNumber = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null)
        {
            SourceExpression.Validate(accountId, nameof(accountId), required: true);
            SourceExpression.Validate(bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/account/{0}/contact", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyphoneNumber != null)
                {
                    body["PhoneNumber"] = SourceExpressionConverter.ConvertToken(bodyphoneNumber);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["Email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["FirstName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["LastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "truedialogsms")]
        public IBodyWorkflowAction<ContactResponse> ContactUpdate([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> contactid, [WorkflowExpression] Func<string> bodyphoneNumber = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null)
        {
            SourceExpression.Validate(accountId, nameof(accountId), required: true);
            SourceExpression.Validate(contactid, nameof(contactid), required: true);
            SourceExpression.Validate(bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/account/{0}/contact/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactid, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyphoneNumber != null)
                {
                    body["PhoneNumber"] = SourceExpressionConverter.ConvertToken(bodyphoneNumber);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["Email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["FirstName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["LastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "truedialogsms")]
        public IBodyWorkflowAction<PushCampaignResponse> CampaignPush([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string[]> bodychannels, [WorkflowExpression] Func<string[]> bodytargets, [WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<bool> bodyexecute, [WorkflowExpression] Func<string[]> bodycontactListIds = null, [WorkflowExpression] Func<string[]> bodyexcludeListIds = null, [WorkflowExpression] Func<int> bodymediaId = null, [WorkflowExpression] Func<bool> bodyignoreSingleUse = null, [WorkflowExpression] Func<bool> bodyforceOptIn = null, [WorkflowExpression] Func<string[]> bodyschedules = null, [WorkflowExpression] Func<bool> bodyignoreInvalidTargets = null)
        {
            SourceExpression.Validate(accountId, nameof(accountId), required: true);
            SourceExpression.Validate(bodychannels, nameof(bodychannels), required: true);
            SourceExpression.Validate(bodytargets, nameof(bodytargets), required: true);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            SourceExpression.Validate(bodyexecute, nameof(bodyexecute), required: true);
            SourceExpression.Validate(bodycontactListIds, nameof(bodycontactListIds), required: false);
            SourceExpression.Validate(bodyexcludeListIds, nameof(bodyexcludeListIds), required: false);
            SourceExpression.Validate(bodymediaId, nameof(bodymediaId), required: false);
            SourceExpression.Validate(bodyignoreSingleUse, nameof(bodyignoreSingleUse), required: false);
            SourceExpression.Validate(bodyforceOptIn, nameof(bodyforceOptIn), required: false);
            SourceExpression.Validate(bodyschedules, nameof(bodyschedules), required: false);
            SourceExpression.Validate(bodyignoreInvalidTargets, nameof(bodyignoreInvalidTargets), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/account/{0}/action-pushcampaign", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Channels"] = SourceExpressionConverter.ConvertToken(bodychannels);
                bodypropCount++;
                body["Targets"] = SourceExpressionConverter.ConvertToken(bodytargets);
                if (bodycontactListIds != null)
                {
                    body["ContactListIds"] = SourceExpressionConverter.ConvertToken(bodycontactListIds);
                    bodypropCount++;
                }

                if (bodyexcludeListIds != null)
                {
                    body["ExcludeListIds"] = SourceExpressionConverter.ConvertToken(bodyexcludeListIds);
                    bodypropCount++;
                }

                body["CampaignId"] = 0;
                bodypropCount++;
                if (bodymediaId != null)
                {
                    body["MediaId"] = SourceExpressionConverter.ConvertToken(bodymediaId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                if (bodyignoreSingleUse != null)
                {
                    body["IgnoreSingleUse"] = SourceExpressionConverter.ConvertToken(bodyignoreSingleUse);
                    bodypropCount++;
                }

                if (bodyforceOptIn != null)
                {
                    if (bodyforceOptIn != null)
                    {
                        body["ForceOptIn"] = SourceExpressionConverter.ConvertToken(bodyforceOptIn);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["ForceOptIn"] = false;
                    bodypropCount++;
                }

                if (bodyschedules != null)
                {
                    body["Schedules"] = SourceExpressionConverter.ConvertToken(bodyschedules);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Execute"] = SourceExpressionConverter.ConvertToken(bodyexecute);
                if (bodyignoreInvalidTargets != null)
                {
                    if (bodyignoreInvalidTargets != null)
                    {
                        body["IgnoreInvalidTargets"] = SourceExpressionConverter.ConvertToken(bodyignoreInvalidTargets);
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
                return callPayload;
            }

            return new ApiConnectionAction<PushCampaignResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "truedialogsms")]
        public IBodyWorkflowAction<UserResponse> UserGetSelfInfo()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/userinfo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UserResponse>(BuildSourceInput);
        }
    }

    public class TruedialogsmsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CallbackCreatedResponse> IncomingSMSReceived([WorkflowExpression] Func<string> accountId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(accountId, nameof(accountId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/account/{0}/callback", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<CallbackCreatedResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<CallbackCreatedResponse> KeywordReceived([WorkflowExpression] Func<string> accountId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(accountId, nameof(accountId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/account/{0}/callback/-1", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<CallbackCreatedResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<CallbackCreatedResponse> StopReceived([WorkflowExpression] Func<string> accountId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(accountId, nameof(accountId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/account/{0}/callback/-6", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<CallbackCreatedResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<CallbackCreatedResponse> DeliveryNoticeReceived([WorkflowExpression] Func<string> accountId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(accountId, nameof(accountId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/account/{0}/callback/-12", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<CallbackCreatedResponse>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<CallbackCreatedResponse> InvalidTargets([WorkflowExpression] Func<string> accountId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(accountId, nameof(accountId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/account/{0}/callback/-13", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<CallbackCreatedResponse>(BuildSourceInput, triggerName, recurrence);
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