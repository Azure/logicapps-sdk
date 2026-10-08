//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mailform
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MailformActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailform")]
        [WorkflowExpressionFactory(nameof(__BuildCreateOrder))]
        public IBodyWorkflowAction<CreateOrderResponse> CreateOrder([WorkflowExpression] Func<serviceInput> service, [WorkflowExpression] Func<string> toName, [WorkflowExpression] Func<string> toAddress1, [WorkflowExpression] Func<string> toCity, [WorkflowExpression] Func<string> toState, [WorkflowExpression] Func<string> toPostcode, [WorkflowExpression] Func<string> fromName, [WorkflowExpression] Func<string> fromAddress1, [WorkflowExpression] Func<string> fromCity, [WorkflowExpression] Func<string> fromState, [WorkflowExpression] Func<string> fromPostcode, [WorkflowExpression] Func<object> file = null, [WorkflowExpression] Func<string> url = null, [WorkflowExpression] Func<string> customerReference = null, [WorkflowExpression] Func<string> webhook = null, [WorkflowExpression] Func<bool> simplex = null, [WorkflowExpression] Func<bool> color = null, [WorkflowExpression] Func<bool> flat = null, [WorkflowExpression] Func<bool> returnEnvelope = null, [WorkflowExpression] Func<bool> stamp = null, [WorkflowExpression] Func<string> message = null, [WorkflowExpression] Func<string> toOrganization = null, [WorkflowExpression] Func<string> toAddress2 = null, [WorkflowExpression] Func<string> toCountry = null, [WorkflowExpression] Func<string> fromOrganization = null, [WorkflowExpression] Func<string> fromAddress2 = null, [WorkflowExpression] Func<string> fromCountry = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateOrderResponse> __BuildCreateOrder(WorkflowExpression<serviceInput> service, WorkflowExpression<string> toName, WorkflowExpression<string> toAddress1, WorkflowExpression<string> toCity, WorkflowExpression<string> toState, WorkflowExpression<string> toPostcode, WorkflowExpression<string> fromName, WorkflowExpression<string> fromAddress1, WorkflowExpression<string> fromCity, WorkflowExpression<string> fromState, WorkflowExpression<string> fromPostcode, WorkflowExpression<object> file = null, WorkflowExpression<string> url = null, WorkflowExpression<string> customerReference = null, WorkflowExpression<string> webhook = null, WorkflowExpression<bool> simplex = null, WorkflowExpression<bool> color = null, WorkflowExpression<bool> flat = null, WorkflowExpression<bool> returnEnvelope = null, WorkflowExpression<bool> stamp = null, WorkflowExpression<string> message = null, WorkflowExpression<string> toOrganization = null, WorkflowExpression<string> toAddress2 = null, WorkflowExpression<string> toCountry = null, WorkflowExpression<string> fromOrganization = null, WorkflowExpression<string> fromAddress2 = null, WorkflowExpression<string> fromCountry = null)
        {
            WorkflowExpression.Validate(service, nameof(service), required: true);
            WorkflowExpression.Validate(toName, nameof(toName), required: true);
            WorkflowExpression.Validate(toAddress1, nameof(toAddress1), required: true);
            WorkflowExpression.Validate(toCity, nameof(toCity), required: true);
            WorkflowExpression.Validate(toState, nameof(toState), required: true);
            WorkflowExpression.Validate(toPostcode, nameof(toPostcode), required: true);
            WorkflowExpression.Validate(fromName, nameof(fromName), required: true);
            WorkflowExpression.Validate(fromAddress1, nameof(fromAddress1), required: true);
            WorkflowExpression.Validate(fromCity, nameof(fromCity), required: true);
            WorkflowExpression.Validate(fromState, nameof(fromState), required: true);
            WorkflowExpression.Validate(fromPostcode, nameof(fromPostcode), required: true);
            WorkflowExpression.Validate(file, nameof(file), required: false);
            WorkflowExpression.Validate(url, nameof(url), required: false);
            WorkflowExpression.Validate(customerReference, nameof(customerReference), required: false);
            WorkflowExpression.Validate(webhook, nameof(webhook), required: false);
            WorkflowExpression.Validate(simplex, nameof(simplex), required: false);
            WorkflowExpression.Validate(color, nameof(color), required: false);
            WorkflowExpression.Validate(flat, nameof(flat), required: false);
            WorkflowExpression.Validate(returnEnvelope, nameof(returnEnvelope), required: false);
            WorkflowExpression.Validate(stamp, nameof(stamp), required: false);
            WorkflowExpression.Validate(message, nameof(message), required: false);
            WorkflowExpression.Validate(toOrganization, nameof(toOrganization), required: false);
            WorkflowExpression.Validate(toAddress2, nameof(toAddress2), required: false);
            WorkflowExpression.Validate(toCountry, nameof(toCountry), required: false);
            WorkflowExpression.Validate(fromOrganization, nameof(fromOrganization), required: false);
            WorkflowExpression.Validate(fromAddress2, nameof(fromAddress2), required: false);
            WorkflowExpression.Validate(fromCountry, nameof(fromCountry), required: false);
            return new DeferredBodyAction<CreateOrderResponse>(() =>
            {
                var apiCallPath = "/v1/orders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CreateOrderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailform")]
        [WorkflowExpressionFactory(nameof(__BuildGetOrder))]
        public IBodyWorkflowAction<GetOrderResponse> GetOrder([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetOrderResponse> __BuildGetOrder(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GetOrderResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/orders/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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