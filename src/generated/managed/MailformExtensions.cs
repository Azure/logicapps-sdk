//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mailform
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class MailformActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailform")]
        public IBodyWorkflowAction<CreateOrderResponse> CreateOrder(Expression<Func<serviceInput>> service, Expression<Func<string>> toName, Expression<Func<string>> toAddress1, Expression<Func<string>> toCity, Expression<Func<string>> toState, Expression<Func<string>> toPostcode, Expression<Func<string>> fromName, Expression<Func<string>> fromAddress1, Expression<Func<string>> fromCity, Expression<Func<string>> fromState, Expression<Func<string>> fromPostcode, Expression<Func<object>> file = null, Expression<Func<string>> url = null, Expression<Func<string>> customerReference = null, Expression<Func<string>> webhook = null, Expression<Func<bool>> simplex = null, Expression<Func<bool>> color = null, Expression<Func<bool>> flat = null, Expression<Func<bool>> returnEnvelope = null, Expression<Func<bool>> stamp = null, Expression<Func<string>> message = null, Expression<Func<string>> toOrganization = null, Expression<Func<string>> toAddress2 = null, Expression<Func<string>> toCountry = null, Expression<Func<string>> fromOrganization = null, Expression<Func<string>> fromAddress2 = null, Expression<Func<string>> fromCountry = null)
        {
            var __workflow_service = service == null ? null : WorkflowExpression.Compile(service);
            WorkflowExpression.Validate(__workflow_service, nameof(service), required: true);
            var __workflow_toName = toName == null ? null : WorkflowExpression.Compile(toName);
            WorkflowExpression.Validate(__workflow_toName, nameof(toName), required: true);
            var __workflow_toAddress1 = toAddress1 == null ? null : WorkflowExpression.Compile(toAddress1);
            WorkflowExpression.Validate(__workflow_toAddress1, nameof(toAddress1), required: true);
            var __workflow_toCity = toCity == null ? null : WorkflowExpression.Compile(toCity);
            WorkflowExpression.Validate(__workflow_toCity, nameof(toCity), required: true);
            var __workflow_toState = toState == null ? null : WorkflowExpression.Compile(toState);
            WorkflowExpression.Validate(__workflow_toState, nameof(toState), required: true);
            var __workflow_toPostcode = toPostcode == null ? null : WorkflowExpression.Compile(toPostcode);
            WorkflowExpression.Validate(__workflow_toPostcode, nameof(toPostcode), required: true);
            var __workflow_fromName = fromName == null ? null : WorkflowExpression.Compile(fromName);
            WorkflowExpression.Validate(__workflow_fromName, nameof(fromName), required: true);
            var __workflow_fromAddress1 = fromAddress1 == null ? null : WorkflowExpression.Compile(fromAddress1);
            WorkflowExpression.Validate(__workflow_fromAddress1, nameof(fromAddress1), required: true);
            var __workflow_fromCity = fromCity == null ? null : WorkflowExpression.Compile(fromCity);
            WorkflowExpression.Validate(__workflow_fromCity, nameof(fromCity), required: true);
            var __workflow_fromState = fromState == null ? null : WorkflowExpression.Compile(fromState);
            WorkflowExpression.Validate(__workflow_fromState, nameof(fromState), required: true);
            var __workflow_fromPostcode = fromPostcode == null ? null : WorkflowExpression.Compile(fromPostcode);
            WorkflowExpression.Validate(__workflow_fromPostcode, nameof(fromPostcode), required: true);
            var __workflow_file = file == null ? null : WorkflowExpression.Compile(file);
            WorkflowExpression.Validate(__workflow_file, nameof(file), required: false);
            var __workflow_url = url == null ? null : WorkflowExpression.Compile(url);
            WorkflowExpression.Validate(__workflow_url, nameof(url), required: false);
            var __workflow_customerReference = customerReference == null ? null : WorkflowExpression.Compile(customerReference);
            WorkflowExpression.Validate(__workflow_customerReference, nameof(customerReference), required: false);
            var __workflow_webhook = webhook == null ? null : WorkflowExpression.Compile(webhook);
            WorkflowExpression.Validate(__workflow_webhook, nameof(webhook), required: false);
            var __workflow_simplex = simplex == null ? null : WorkflowExpression.Compile(simplex);
            WorkflowExpression.Validate(__workflow_simplex, nameof(simplex), required: false);
            var __workflow_color = color == null ? null : WorkflowExpression.Compile(color);
            WorkflowExpression.Validate(__workflow_color, nameof(color), required: false);
            var __workflow_flat = flat == null ? null : WorkflowExpression.Compile(flat);
            WorkflowExpression.Validate(__workflow_flat, nameof(flat), required: false);
            var __workflow_returnEnvelope = returnEnvelope == null ? null : WorkflowExpression.Compile(returnEnvelope);
            WorkflowExpression.Validate(__workflow_returnEnvelope, nameof(returnEnvelope), required: false);
            var __workflow_stamp = stamp == null ? null : WorkflowExpression.Compile(stamp);
            WorkflowExpression.Validate(__workflow_stamp, nameof(stamp), required: false);
            var __workflow_message = message == null ? null : WorkflowExpression.Compile(message);
            WorkflowExpression.Validate(__workflow_message, nameof(message), required: false);
            var __workflow_toOrganization = toOrganization == null ? null : WorkflowExpression.Compile(toOrganization);
            WorkflowExpression.Validate(__workflow_toOrganization, nameof(toOrganization), required: false);
            var __workflow_toAddress2 = toAddress2 == null ? null : WorkflowExpression.Compile(toAddress2);
            WorkflowExpression.Validate(__workflow_toAddress2, nameof(toAddress2), required: false);
            var __workflow_toCountry = toCountry == null ? null : WorkflowExpression.Compile(toCountry);
            WorkflowExpression.Validate(__workflow_toCountry, nameof(toCountry), required: false);
            var __workflow_fromOrganization = fromOrganization == null ? null : WorkflowExpression.Compile(fromOrganization);
            WorkflowExpression.Validate(__workflow_fromOrganization, nameof(fromOrganization), required: false);
            var __workflow_fromAddress2 = fromAddress2 == null ? null : WorkflowExpression.Compile(fromAddress2);
            WorkflowExpression.Validate(__workflow_fromAddress2, nameof(fromAddress2), required: false);
            var __workflow_fromCountry = fromCountry == null ? null : WorkflowExpression.Compile(fromCountry);
            WorkflowExpression.Validate(__workflow_fromCountry, nameof(fromCountry), required: false);
            return new DeferredBodyAction<CreateOrderResponse>(() =>
            {
                var apiCallPath = "/v1/orders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CreateOrderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailform")]
        public IBodyWorkflowAction<GetOrderResponse> GetOrder(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<GetOrderResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/orders/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetOrderResponse>(callPayload);
            });
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
