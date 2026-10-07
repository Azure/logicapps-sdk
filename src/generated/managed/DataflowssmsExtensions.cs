//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dataflowssms
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DataflowssmsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dataflowssms")]
        [WorkflowExpressionFactory(nameof(__BuildSendSMSGet))]
        public IBodyWorkflowAction<SMSResponse> SendSMSGet([WorkflowExpression] Func<string> recipient, [WorkflowExpression] Func<string> senderId, [WorkflowExpression] Func<string> message, [WorkflowExpression] Func<string> type = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dataflowssms")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SMSResponse> __BuildSendSMSGet(WorkflowExpression<string> recipient, WorkflowExpression<string> senderId, WorkflowExpression<string> message, WorkflowExpression<string> type = null)
        {
            WorkflowExpression.Validate(recipient, nameof(recipient), required: true);
            WorkflowExpression.Validate(senderId, nameof(senderId), required: true);
            WorkflowExpression.Validate(message, nameof(message), required: true);
            WorkflowExpression.Validate(type, nameof(type), required: false);
            return new DeferredBodyAction<SMSResponse>(() =>
            {
                var apiCallPath = "/sms/send";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["recipient"] = ExpressionConverter.Convert(recipient);
                callPayload.Queries["sender_id"] = ExpressionConverter.Convert(senderId);
                callPayload.Queries["message"] = ExpressionConverter.Convert(message);
                callPayload.Queries["type"] = Convert.ToString("plain");
                if (type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                return new ApiConnectionAction<SMSResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dataflowssms")]
        [WorkflowExpressionFactory(nameof(__BuildListSMS))]
        public IBodyWorkflowAction<SMSList> ListSMS([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dataflowssms")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SMSList> __BuildListSMS(WorkflowExpression<int> page = null, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<SMSList>(() =>
            {
                var apiCallPath = "/sms";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                callPayload.Queries["limit"] = Convert.ToString(20);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction<SMSList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dataflowssms")]
        public IBodyWorkflowAction<Profile> GetProfile()
        {
            var apiCallPath = "/me";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Profile>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dataflowssms")]
        public IBodyWorkflowAction<Balance> GetBalance()
        {
            var apiCallPath = "/balance";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Balance>(callPayload);
        }
    }

    public class DataflowssmsTriggers([ConnectionName] string connectionId)
    {
    }

    public class SMSResponse
    {
        [JsonProperty("status")]
        public SMSResponseStatusType Status { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SMSResponseStatusType
    {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "error")]
        Error
    }

    public class SMSList
    {
        [JsonProperty("status")]
        public SMSListStatusType Status { get; set; }

        [JsonProperty("data")]
        public SMSListDataType Data { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SMSListStatusType
    {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "error")]
        Error
    }

    public class SMSListDataType
    {
        [JsonProperty("messages")]
        public SMSDetails[] Messages { get; set; }

        [JsonProperty("pagination")]
        public SMSListDataTypePaginationType Pagination { get; set; }
    }

    public class SMSDetails
    {
        [JsonProperty("status")]
        public SMSDetailsStatusType Status { get; set; }

        [JsonProperty("data")]
        public SMSDetailsDataType Data { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SMSDetailsStatusType
    {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "error")]
        Error
    }

    public class SMSDetailsDataType
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("sender_id")]
        public string SenderId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("cost")]
        public double Cost { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class SMSListDataTypePaginationType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }
    }

    public class Profile
    {
        [JsonProperty("status")]
        public ProfileStatusType Status { get; set; }

        [JsonProperty("data")]
        public ProfileDataType Data { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ProfileStatusType
    {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "error")]
        Error
    }

    public class ProfileDataType
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }

    public class Balance
    {
        [JsonProperty("status")]
        public BalanceStatusType Status { get; set; }

        [JsonProperty("data")]
        public BalanceDataType Data { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BalanceStatusType
    {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "error")]
        Error
    }

    public class BalanceDataType
    {
        [JsonProperty("sms_unit")]
        public double SmsUnit { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dataflowssms;

    public partial class WorkflowManagedActions
    {
        public DataflowssmsActions Dataflowssms(string connectionId) => new DataflowssmsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DataflowssmsTriggers Dataflowssms(string connectionId) => new DataflowssmsTriggers(connectionId);
    }
}