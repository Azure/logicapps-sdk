//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Truedialogsms
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TruedialogsmsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "truedialogsms")]
        [WorkflowExpressionFactory(nameof(__BuildAccountGetInfo))]
        public IBodyWorkflowAction<AccountResponse> AccountGetInfo([WorkflowExpression] Func<string> accountId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AccountResponse> __BuildAccountGetInfo(WorkflowExpression<string> accountId)
        {
            WorkflowExpression.Validate(accountId, nameof(accountId), required: true);
            return new DeferredBodyAction<AccountResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/account/{0}", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AccountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "truedialogsms")]
        [WorkflowExpressionFactory(nameof(__BuildContactSearch))]
        public IBodyWorkflowAction<ContactSearchRequestItem[]> ContactSearch([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> phone)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ContactSearchRequestItem[]> __BuildContactSearch(WorkflowExpression<string> accountId, WorkflowExpression<string> phone)
        {
            WorkflowExpression.Validate(accountId, nameof(accountId), required: true);
            WorkflowExpression.Validate(phone, nameof(phone), required: true);
            return new DeferredBodyAction<ContactSearchRequestItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/account/{0}/contact-search/{1}", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(phone, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ContactSearchRequestItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "truedialogsms")]
        [WorkflowExpressionFactory(nameof(__BuildContactCreate))]
        public IBodyWorkflowAction<ContactResponse> ContactCreate([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> bodyphoneNumber = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ContactResponse> __BuildContactCreate(WorkflowExpression<string> accountId, WorkflowExpression<string> bodyphoneNumber = null, WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<string> bodylastName = null)
        {
            WorkflowExpression.Validate(accountId, nameof(accountId), required: true);
            WorkflowExpression.Validate(bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            return new DeferredBodyAction<ContactResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/account/{0}/contact", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyphoneNumber != null)
                {
                    body["PhoneNumber"] = ExpressionConverter.ConvertO(bodyphoneNumber);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["Email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["FirstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["LastName"] = ExpressionConverter.ConvertO(bodylastName);
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
        [WorkflowExpressionFactory(nameof(__BuildContactUpdate))]
        public IBodyWorkflowAction<ContactResponse> ContactUpdate([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> contactid, [WorkflowExpression] Func<string> bodyphoneNumber = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ContactResponse> __BuildContactUpdate(WorkflowExpression<string> accountId, WorkflowExpression<string> contactid, WorkflowExpression<string> bodyphoneNumber = null, WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<string> bodylastName = null)
        {
            WorkflowExpression.Validate(accountId, nameof(accountId), required: true);
            WorkflowExpression.Validate(contactid, nameof(contactid), required: true);
            WorkflowExpression.Validate(bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            return new DeferredBodyAction<ContactResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/account/{0}/contact/{1}", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1), ExpressionConverter.ConvertWithUrlEncoding(contactid, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyphoneNumber != null)
                {
                    body["PhoneNumber"] = ExpressionConverter.ConvertO(bodyphoneNumber);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["Email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["FirstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["LastName"] = ExpressionConverter.ConvertO(bodylastName);
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
        [WorkflowExpressionFactory(nameof(__BuildCampaignPush))]
        public IBodyWorkflowAction<PushCampaignResponse> CampaignPush([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string[]> bodychannels, [WorkflowExpression] Func<string[]> bodytargets, [WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<bool> bodyexecute, [WorkflowExpression] Func<string[]> bodycontactListIds = null, [WorkflowExpression] Func<string[]> bodyexcludeListIds = null, [WorkflowExpression] Func<int> bodymediaId = null, [WorkflowExpression] Func<bool> bodyignoreSingleUse = null, [WorkflowExpression] Func<bool> bodyforceOptIn = null, [WorkflowExpression] Func<string[]> bodyschedules = null, [WorkflowExpression] Func<bool> bodyignoreInvalidTargets = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PushCampaignResponse> __BuildCampaignPush(WorkflowExpression<string> accountId, WorkflowExpression<string[]> bodychannels, WorkflowExpression<string[]> bodytargets, WorkflowExpression<string> bodymessage, WorkflowExpression<bool> bodyexecute, WorkflowExpression<string[]> bodycontactListIds = null, WorkflowExpression<string[]> bodyexcludeListIds = null, WorkflowExpression<int> bodymediaId = null, WorkflowExpression<bool> bodyignoreSingleUse = null, WorkflowExpression<bool> bodyforceOptIn = null, WorkflowExpression<string[]> bodyschedules = null, WorkflowExpression<bool> bodyignoreInvalidTargets = null)
        {
            WorkflowExpression.Validate(accountId, nameof(accountId), required: true);
            WorkflowExpression.Validate(bodychannels, nameof(bodychannels), required: true);
            WorkflowExpression.Validate(bodytargets, nameof(bodytargets), required: true);
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            WorkflowExpression.Validate(bodyexecute, nameof(bodyexecute), required: true);
            WorkflowExpression.Validate(bodycontactListIds, nameof(bodycontactListIds), required: false);
            WorkflowExpression.Validate(bodyexcludeListIds, nameof(bodyexcludeListIds), required: false);
            WorkflowExpression.Validate(bodymediaId, nameof(bodymediaId), required: false);
            WorkflowExpression.Validate(bodyignoreSingleUse, nameof(bodyignoreSingleUse), required: false);
            WorkflowExpression.Validate(bodyforceOptIn, nameof(bodyforceOptIn), required: false);
            WorkflowExpression.Validate(bodyschedules, nameof(bodyschedules), required: false);
            WorkflowExpression.Validate(bodyignoreInvalidTargets, nameof(bodyignoreInvalidTargets), required: false);
            return new DeferredBodyAction<PushCampaignResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/account/{0}/action-pushcampaign", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Channels"] = ExpressionConverter.ConvertO(bodychannels);
                bodypropCount++;
                body["Targets"] = ExpressionConverter.ConvertO(bodytargets);
                if (bodycontactListIds != null)
                {
                    body["ContactListIds"] = ExpressionConverter.ConvertO(bodycontactListIds);
                    bodypropCount++;
                }

                if (bodyexcludeListIds != null)
                {
                    body["ExcludeListIds"] = ExpressionConverter.ConvertO(bodyexcludeListIds);
                    bodypropCount++;
                }

                body["CampaignId"] = 0;
                bodypropCount++;
                if (bodymediaId != null)
                {
                    body["MediaId"] = ExpressionConverter.ConvertO(bodymediaId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Message"] = ExpressionConverter.ConvertO(bodymessage);
                if (bodyignoreSingleUse != null)
                {
                    body["IgnoreSingleUse"] = ExpressionConverter.ConvertO(bodyignoreSingleUse);
                    bodypropCount++;
                }

                if (bodyforceOptIn != null)
                {
                    if (bodyforceOptIn != null)
                    {
                        body["ForceOptIn"] = ExpressionConverter.ConvertO(bodyforceOptIn);
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
                    body["Schedules"] = ExpressionConverter.ConvertO(bodyschedules);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Execute"] = ExpressionConverter.ConvertO(bodyexecute);
                if (bodyignoreInvalidTargets != null)
                {
                    if (bodyignoreInvalidTargets != null)
                    {
                        body["IgnoreInvalidTargets"] = ExpressionConverter.ConvertO(bodyignoreInvalidTargets);
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

        [WorkflowExpressionFactory(nameof(__BuildIncomingSMSReceived))]
        public IBodyWorkflowTrigger<CallbackCreatedResponse> IncomingSMSReceived([WorkflowExpression] Func<string> accountId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CallbackCreatedResponse> __BuildIncomingSMSReceived(WorkflowExpression<string> accountId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(accountId, nameof(accountId), required: true);
            return new DeferredBodyTrigger<CallbackCreatedResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/account/{0}/callback", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
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

        [WorkflowExpressionFactory(nameof(__BuildKeywordReceived))]
        public IBodyWorkflowTrigger<CallbackCreatedResponse> KeywordReceived([WorkflowExpression] Func<string> accountId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CallbackCreatedResponse> __BuildKeywordReceived(WorkflowExpression<string> accountId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(accountId, nameof(accountId), required: true);
            return new DeferredBodyTrigger<CallbackCreatedResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/account/{0}/callback/-1", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
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

        [WorkflowExpressionFactory(nameof(__BuildStopReceived))]
        public IBodyWorkflowTrigger<CallbackCreatedResponse> StopReceived([WorkflowExpression] Func<string> accountId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CallbackCreatedResponse> __BuildStopReceived(WorkflowExpression<string> accountId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(accountId, nameof(accountId), required: true);
            return new DeferredBodyTrigger<CallbackCreatedResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/account/{0}/callback/-6", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
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

        [WorkflowExpressionFactory(nameof(__BuildDeliveryNoticeReceived))]
        public IBodyWorkflowTrigger<CallbackCreatedResponse> DeliveryNoticeReceived([WorkflowExpression] Func<string> accountId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CallbackCreatedResponse> __BuildDeliveryNoticeReceived(WorkflowExpression<string> accountId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(accountId, nameof(accountId), required: true);
            return new DeferredBodyTrigger<CallbackCreatedResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/account/{0}/callback/-12", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
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

        [WorkflowExpressionFactory(nameof(__BuildInvalidTargets))]
        public IBodyWorkflowTrigger<CallbackCreatedResponse> InvalidTargets([WorkflowExpression] Func<string> accountId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CallbackCreatedResponse> __BuildInvalidTargets(WorkflowExpression<string> accountId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(accountId, nameof(accountId), required: true);
            return new DeferredBodyTrigger<CallbackCreatedResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/account/{0}/callback/-13", ExpressionConverter.ConvertWithUrlEncoding(accountId, 1));
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