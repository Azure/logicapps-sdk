//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mailform
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MailformActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailform")]
        public IBodyWorkflowAction<CreateOrderResponse> CreateOrder([WorkflowExpression] Func<serviceInput> service, [WorkflowExpression] Func<string> toName, [WorkflowExpression] Func<string> toAddress1, [WorkflowExpression] Func<string> toCity, [WorkflowExpression] Func<string> toState, [WorkflowExpression] Func<string> toPostcode, [WorkflowExpression] Func<string> fromName, [WorkflowExpression] Func<string> fromAddress1, [WorkflowExpression] Func<string> fromCity, [WorkflowExpression] Func<string> fromState, [WorkflowExpression] Func<string> fromPostcode, [WorkflowExpression] Func<object> file = null, [WorkflowExpression] Func<string> url = null, [WorkflowExpression] Func<string> customerReference = null, [WorkflowExpression] Func<string> webhook = null, [WorkflowExpression] Func<bool> simplex = null, [WorkflowExpression] Func<bool> color = null, [WorkflowExpression] Func<bool> flat = null, [WorkflowExpression] Func<bool> returnEnvelope = null, [WorkflowExpression] Func<bool> stamp = null, [WorkflowExpression] Func<string> message = null, [WorkflowExpression] Func<string> toOrganization = null, [WorkflowExpression] Func<string> toAddress2 = null, [WorkflowExpression] Func<string> toCountry = null, [WorkflowExpression] Func<string> fromOrganization = null, [WorkflowExpression] Func<string> fromAddress2 = null, [WorkflowExpression] Func<string> fromCountry = null)
        {
            SourceExpression.Validate(service, nameof(service), required: true);
            SourceExpression.Validate(toName, nameof(toName), required: true);
            SourceExpression.Validate(toAddress1, nameof(toAddress1), required: true);
            SourceExpression.Validate(toCity, nameof(toCity), required: true);
            SourceExpression.Validate(toState, nameof(toState), required: true);
            SourceExpression.Validate(toPostcode, nameof(toPostcode), required: true);
            SourceExpression.Validate(fromName, nameof(fromName), required: true);
            SourceExpression.Validate(fromAddress1, nameof(fromAddress1), required: true);
            SourceExpression.Validate(fromCity, nameof(fromCity), required: true);
            SourceExpression.Validate(fromState, nameof(fromState), required: true);
            SourceExpression.Validate(fromPostcode, nameof(fromPostcode), required: true);
            SourceExpression.Validate(file, nameof(file), required: false);
            SourceExpression.Validate(url, nameof(url), required: false);
            SourceExpression.Validate(customerReference, nameof(customerReference), required: false);
            SourceExpression.Validate(webhook, nameof(webhook), required: false);
            SourceExpression.Validate(simplex, nameof(simplex), required: false);
            SourceExpression.Validate(color, nameof(color), required: false);
            SourceExpression.Validate(flat, nameof(flat), required: false);
            SourceExpression.Validate(returnEnvelope, nameof(returnEnvelope), required: false);
            SourceExpression.Validate(stamp, nameof(stamp), required: false);
            SourceExpression.Validate(message, nameof(message), required: false);
            SourceExpression.Validate(toOrganization, nameof(toOrganization), required: false);
            SourceExpression.Validate(toAddress2, nameof(toAddress2), required: false);
            SourceExpression.Validate(toCountry, nameof(toCountry), required: false);
            SourceExpression.Validate(fromOrganization, nameof(fromOrganization), required: false);
            SourceExpression.Validate(fromAddress2, nameof(fromAddress2), required: false);
            SourceExpression.Validate(fromCountry, nameof(fromCountry), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/orders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CreateOrderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailform")]
        public IBodyWorkflowAction<GetOrderResponse> GetOrder([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/orders/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetOrderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailform")]
        public IBodyWorkflowAction<GetUserResponse> GetUser()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/users/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetUserResponse>(BuildSourceInput);
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