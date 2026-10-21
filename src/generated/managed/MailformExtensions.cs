//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mailform
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MailformActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailform")]
        public IBodyWorkflowAction<CreateOrderResponse> CreateOrder(Expression<Func<serviceInput>> service, Expression<Func<string>> toName, Expression<Func<string>> toAddress1, Expression<Func<string>> toCity, Expression<Func<string>> toState, Expression<Func<string>> toPostcode, Expression<Func<string>> fromName, Expression<Func<string>> fromAddress1, Expression<Func<string>> fromCity, Expression<Func<string>> fromState, Expression<Func<string>> fromPostcode, Expression<Func<object>> file = null, Expression<Func<string>> url = null, Expression<Func<string>> customerReference = null, Expression<Func<string>> webhook = null, Expression<Func<bool>> simplex = null, Expression<Func<bool>> color = null, Expression<Func<bool>> flat = null, Expression<Func<bool>> returnEnvelope = null, Expression<Func<bool>> stamp = null, Expression<Func<string>> message = null, Expression<Func<string>> toOrganization = null, Expression<Func<string>> toAddress2 = null, Expression<Func<string>> toCountry = null, Expression<Func<string>> fromOrganization = null, Expression<Func<string>> fromAddress2 = null, Expression<Func<string>> fromCountry = null)
        {
            var __workflow_service = WorkflowExpression.Compile(service, nameof(service), required: true);
            var __workflow_toName = WorkflowExpression.Compile(toName, nameof(toName), required: true);
            var __workflow_toAddress1 = WorkflowExpression.Compile(toAddress1, nameof(toAddress1), required: true);
            var __workflow_toCity = WorkflowExpression.Compile(toCity, nameof(toCity), required: true);
            var __workflow_toState = WorkflowExpression.Compile(toState, nameof(toState), required: true);
            var __workflow_toPostcode = WorkflowExpression.Compile(toPostcode, nameof(toPostcode), required: true);
            var __workflow_fromName = WorkflowExpression.Compile(fromName, nameof(fromName), required: true);
            var __workflow_fromAddress1 = WorkflowExpression.Compile(fromAddress1, nameof(fromAddress1), required: true);
            var __workflow_fromCity = WorkflowExpression.Compile(fromCity, nameof(fromCity), required: true);
            var __workflow_fromState = WorkflowExpression.Compile(fromState, nameof(fromState), required: true);
            var __workflow_fromPostcode = WorkflowExpression.Compile(fromPostcode, nameof(fromPostcode), required: true);
            var __workflow_file = WorkflowExpression.Compile(file, nameof(file), required: false);
            var __workflow_url = WorkflowExpression.Compile(url, nameof(url), required: false);
            var __workflow_customerReference = WorkflowExpression.Compile(customerReference, nameof(customerReference), required: false);
            var __workflow_webhook = WorkflowExpression.Compile(webhook, nameof(webhook), required: false);
            var __workflow_simplex = WorkflowExpression.Compile(simplex, nameof(simplex), required: false);
            var __workflow_color = WorkflowExpression.Compile(color, nameof(color), required: false);
            var __workflow_flat = WorkflowExpression.Compile(flat, nameof(flat), required: false);
            var __workflow_returnEnvelope = WorkflowExpression.Compile(returnEnvelope, nameof(returnEnvelope), required: false);
            var __workflow_stamp = WorkflowExpression.Compile(stamp, nameof(stamp), required: false);
            var __workflow_message = WorkflowExpression.Compile(message, nameof(message), required: false);
            var __workflow_toOrganization = WorkflowExpression.Compile(toOrganization, nameof(toOrganization), required: false);
            var __workflow_toAddress2 = WorkflowExpression.Compile(toAddress2, nameof(toAddress2), required: false);
            var __workflow_toCountry = WorkflowExpression.Compile(toCountry, nameof(toCountry), required: false);
            var __workflow_fromOrganization = WorkflowExpression.Compile(fromOrganization, nameof(fromOrganization), required: false);
            var __workflow_fromAddress2 = WorkflowExpression.Compile(fromAddress2, nameof(fromAddress2), required: false);
            var __workflow_fromCountry = WorkflowExpression.Compile(fromCountry, nameof(fromCountry), required: false);
            return new DeferredBodyAction<CreateOrderResponse>(() =>
            {
                var apiCallPath = "/v1/orders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CreateOrderResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailform")]
        public IBodyWorkflowAction<GetOrderResponse> GetOrder(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetOrderResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/orders/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetOrderResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailform")]
        public IBodyWorkflowAction<GetUserResponse> GetUser()
        {
            var apiCallPath = "/v1/users/me";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetUserResponse>(callPayload);
        }
    }

    public class MailformTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateOrderResponse
    {
        [JsonProperty("error")]
        public CreateOrderResponseErrorType Error { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public CreateOrderResponseDataType Data { get; set; }
    }

    public class CreateOrderResponseErrorType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class CreateOrderResponseDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lineitems")]
        public CreateOrderResponseDataTypeLineitemsTypeItem[] Lineitems { get; set; }
    }

    public class CreateOrderResponseDataTypeLineitemsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("service")]
        public string Service { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum serviceInput
    {
        [EnumMember(Value = "USPS_PRIORITY_EXPRESS")]
        USPSPRIORITYEXPRESS,
        [EnumMember(Value = "USPS_PRIORITY")]
        USPSPRIORITY,
        [EnumMember(Value = "USPS_CERTIFIED_PHYSICAL_RECEIPT")]
        USPSCERTIFIEDPHYSICALRECEIPT,
        [EnumMember(Value = "USPS_CERTIFIED_RECEIPT")]
        USPSCERTIFIEDRECEIPT,
        [EnumMember(Value = "USPS_CERTIFIED,")]
        USPSCERTIFIED,
        [EnumMember(Value = "USPS_FIRST_CLASS")]
        USPSFIRSTCLASS,
        [EnumMember(Value = "USPS_POSTCARD")]
        USPSPOSTCARD
    }

    public class GetOrderResponse
    {
        [JsonProperty("error")]
        public GetOrderResponseErrorType Error { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public GetOrderResponseDataType Data { get; set; }
    }

    public class GetOrderResponseErrorType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class GetOrderResponseDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lineitems")]
        public GetOrderResponseDataTypeLineitemsTypeItem[] Lineitems { get; set; }
    }

    public class GetOrderResponseDataTypeLineitemsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("service")]
        public string Service { get; set; }

        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }
    }

    public class GetUserResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("balance")]
        public GetUserResponseBalanceType Balance { get; set; }
    }

    public class GetUserResponseBalanceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mailform;

    public partial class WorkflowManagedActions
    {
        public MailformActions Mailform(string connectionId) => new MailformActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MailformTriggers Mailform(string connectionId) => new MailformTriggers(connectionId);
    }
}
