//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fedexdataworks
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FedexdataworksActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fedexdataworks")]
        public IBodyWorkflowAction<GetTransportationPlanScoresResponse> GetTransportationPlanScores()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/transportation/v1/scores";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetTransportationPlanScoresResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fedexdataworks")]
        public IBodyWorkflowAction<DeleteCompanySubscriptionResponse> DeleteCompanySubscription([WorkflowExpression] Func<string> subscriptionId)
        {
            SourceExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook/v1/subscription";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["subscriptionId"] = SourceExpressionConverter.ConvertO(subscriptionId);
                return callPayload;
            }

            return new ApiConnectionAction<DeleteCompanySubscriptionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fedexdataworks")]
        public IBodyWorkflowAction<GetCompanySubscriptionsResponse> GetCompanySubscriptions()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook/v1/subscription";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetCompanySubscriptionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fedexdataworks")]
        public IBodyWorkflowAction<PostCompanySubscriptionResponse> PostCompanySubscription([WorkflowExpression] Func<string> bodyEvent, [WorkflowExpression] Func<string> bodyregistrationId, [WorkflowExpression] Func<string> bodykey, [WorkflowExpression] Func<string[]> bodyvalues, [WorkflowExpression] Func<string> bodycallbackUrl = null)
        {
            SourceExpression.Validate(bodyEvent, nameof(bodyEvent), required: true);
            SourceExpression.Validate(bodyregistrationId, nameof(bodyregistrationId), required: true);
            SourceExpression.Validate(bodykey, nameof(bodykey), required: true);
            SourceExpression.Validate(bodyvalues, nameof(bodyvalues), required: true);
            SourceExpression.Validate(bodycallbackUrl, nameof(bodycallbackUrl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook/v1/subscription";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event"] = SourceExpressionConverter.ConvertToken(bodyEvent);
                bodypropCount++;
                body["registrationId"] = SourceExpressionConverter.ConvertToken(bodyregistrationId);
                if (bodycallbackUrl != null)
                {
                    body["callbackUrl"] = SourceExpressionConverter.ConvertToken(bodycallbackUrl);
                    bodypropCount++;
                }

                bodypropCount++;
                body["key"] = SourceExpressionConverter.ConvertToken(bodykey);
                bodypropCount++;
                body["values"] = SourceExpressionConverter.ConvertToken(bodyvalues);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PostCompanySubscriptionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fedexdataworks")]
        public IBodyWorkflowAction<GetCompanyRegistrationsResponse> GetCompanyRegistrations()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook/v1/registrations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetCompanyRegistrationsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fedexdataworks")]
        public IBodyWorkflowAction<ValidateWebhookNotificationSignatureResponse> ValidateWebhookNotificationSignature([WorkflowExpression] Func<string> messageSignature, [WorkflowExpression] Func<string> secretKey)
        {
            SourceExpression.Validate(messageSignature, nameof(messageSignature), required: true);
            SourceExpression.Validate(secretKey, nameof(secretKey), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/validatesignature";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["MessageSignature"] = SourceExpressionConverter.ConvertO(messageSignature);
                callPayload.Headers["SecretKey"] = SourceExpressionConverter.ConvertO(secretKey);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ValidateWebhookNotificationSignatureResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fedexdataworks")]
        public IBodyWorkflowAction<DeleteCompanyRegistrationResponse> DeleteCompanyRegistration([WorkflowExpression] Func<string> registrationId = null)
        {
            SourceExpression.Validate(registrationId, nameof(registrationId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook/v1/deleteregistration";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (registrationId != null)
                    callPayload.Queries["registrationId"] = SourceExpressionConverter.ConvertO(registrationId);
                return callPayload;
            }

            return new ApiConnectionAction<DeleteCompanyRegistrationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fedexdataworks")]
        public IBodyWorkflowAction<GetPredictiveDeliveryEstimatesResponse> GetPredictiveDeliveryEstimates()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gdpp/deliveryestimates/v1/edd";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetPredictiveDeliveryEstimatesResponse>(BuildSourceInput);
        }
    }

    public class FedexdataworksTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<PostCompanyRegistrationResponse> PostCompanyRegistration([WorkflowExpression] Func<string> bodyEvent, [WorkflowExpression] Func<string> bodycallbackSignatureSecretKey, [WorkflowExpression] Func<string> bodycallbackSignatureAlgorithm, [WorkflowExpression] Func<string> bodycallbackAuthUrl = null, [WorkflowExpression] Func<string> bodycallbackClientId = null, [WorkflowExpression] Func<string> bodycallbackClientSecret = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyEvent, nameof(bodyEvent), required: true);
            SourceExpression.Validate(bodycallbackSignatureSecretKey, nameof(bodycallbackSignatureSecretKey), required: true);
            SourceExpression.Validate(bodycallbackSignatureAlgorithm, nameof(bodycallbackSignatureAlgorithm), required: true);
            SourceExpression.Validate(bodycallbackAuthUrl, nameof(bodycallbackAuthUrl), required: false);
            SourceExpression.Validate(bodycallbackClientId, nameof(bodycallbackClientId), required: false);
            SourceExpression.Validate(bodycallbackClientSecret, nameof(bodycallbackClientSecret), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook/v1/register";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event"] = SourceExpressionConverter.ConvertToken(bodyEvent);
                bodypropCount++;
                body["callbackSignatureSecretKey"] = SourceExpressionConverter.ConvertToken(bodycallbackSignatureSecretKey);
                if (bodycallbackAuthUrl != null)
                {
                    body["callbackAuthUrl"] = SourceExpressionConverter.ConvertToken(bodycallbackAuthUrl);
                    bodypropCount++;
                }

                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodycallbackClientId != null)
                {
                    body["callbackClientId"] = SourceExpressionConverter.ConvertToken(bodycallbackClientId);
                    bodypropCount++;
                }

                if (bodycallbackClientSecret != null)
                {
                    body["callbackClientSecret"] = SourceExpressionConverter.ConvertToken(bodycallbackClientSecret);
                    bodypropCount++;
                }

                bodypropCount++;
                body["callbackSignatureAlgorithm"] = SourceExpressionConverter.ConvertToken(bodycallbackSignatureAlgorithm);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<PostCompanyRegistrationResponse>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class GetTransportationPlanScoresResponse
    {
        [JsonProperty("httpStatusCode")]
        public int HttpStatusCode { get; set; }

        [JsonProperty("data")]
        public GetTransportationPlanScoresResponseDataType Data { get; set; }

        [JsonProperty("results")]
        public GetTransportationPlanScoresResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("requestTimeStamp")]
        public string RequestTimeStamp { get; set; }
    }

    public class GetTransportationPlanScoresResponseDataType
    {
        [JsonProperty("responseDateTime")]
        public string ResponseDateTime { get; set; }

        [JsonProperty("transportationPlanScores")]
        public GetTransportationPlanScoresResponseDataTypeTransportationPlanScoresTypeItem[] TransportationPlanScores { get; set; }
    }

    public class GetTransportationPlanScoresResponseDataTypeTransportationPlanScoresTypeItem
    {
        [JsonProperty("planId")]
        public string PlanId { get; set; }

        [JsonProperty("score")]
        public GetTransportationPlanScoresResponseDataTypeTransportationPlanScoresTypeItemScoreType Score { get; set; }

        [JsonProperty("shipmentServiceConditions")]
        public GetTransportationPlanScoresResponseDataTypeTransportationPlanScoresTypeItemShipmentServiceConditionsTypeItem[] ShipmentServiceConditions { get; set; }
    }

    public class GetTransportationPlanScoresResponseDataTypeTransportationPlanScoresTypeItemScoreType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("confidence")]
        public string Confidence { get; set; }
    }

    public class GetTransportationPlanScoresResponseDataTypeTransportationPlanScoresTypeItemShipmentServiceConditionsTypeItem
    {
        [JsonProperty("shipmentId")]
        public string ShipmentId { get; set; }

        [JsonProperty("recommendedTransportationService")]
        public GetTransportationPlanScoresResponseDataTypeTransportationPlanScoresTypeItemShipmentServiceConditionsTypeItemRecommendedTransportationServiceType RecommendedTransportationService { get; set; }
    }

    public class GetTransportationPlanScoresResponseDataTypeTransportationPlanScoresTypeItemShipmentServiceConditionsTypeItemRecommendedTransportationServiceType
    {
        [JsonProperty("serviceCode")]
        public string ServiceCode { get; set; }

        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        [JsonProperty("estimatedDeliveryDate")]
        public string EstimatedDeliveryDate { get; set; }
    }

    public class GetTransportationPlanScoresResponseResultsTypeItem
    {
        [JsonProperty("status")]
        public GetTransportationPlanScoresResponseResultsTypeItemStatusTypeItem[] Status { get; set; }
    }

    public class GetTransportationPlanScoresResponseResultsTypeItemStatusTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("severity")]
        public string Severity { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("helpUrl")]
        public string HelpUrl { get; set; }

        [JsonProperty("recommendedRetryMinutes")]
        public int RecommendedRetryMinutes { get; set; }
    }

    public class DeleteCompanySubscriptionResponse
    {
        [JsonProperty("successful")]
        public bool Successful { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("subscriptionId")]
        public string SubscriptionId { get; set; }
    }

    public class GetCompanySubscriptionsResponse
    {
        [JsonProperty("successful")]
        public bool Successful { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("subscriptionId")]
        public string[] SubscriptionId { get; set; }
    }

    public class PostCompanySubscriptionResponse
    {
        [JsonProperty("successful")]
        public bool Successful { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("subscriptionId")]
        public string[] SubscriptionId { get; set; }
    }

    public class GetCompanyRegistrationsResponse
    {
        [JsonProperty("successful")]
        public bool Successful { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("events")]
        public GetCompanyRegistrationsResponseEventsTypeItem[] Events { get; set; }
    }

    public class GetCompanyRegistrationsResponseEventsTypeItem
    {
        [JsonProperty("authUrl")]
        public string AuthUrl { get; set; }

        [JsonProperty("callbackUrl")]
        public string CallbackUrl { get; set; }

        [JsonProperty("callbackClientId")]
        public string CallbackClientId { get; set; }

        [JsonProperty("callbackSignatureAlgorithm")]
        public string CallbackSignatureAlgorithm { get; set; }

        [JsonProperty("registrationId")]
        public string RegistrationId { get; set; }
    }

    public class ValidateWebhookNotificationSignatureResponse
    {
        [JsonProperty("isValid")]
        public bool IsValid { get; set; }
    }

    public class DeleteCompanyRegistrationResponse
    {
        [JsonProperty("successful")]
        public bool Successful { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }
    }

    public class GetPredictiveDeliveryEstimatesResponse
    {
        [JsonProperty("responsebody")]
        public GetPredictiveDeliveryEstimatesResponseResponsebodyType Responsebody { get; set; }
    }

    public class GetPredictiveDeliveryEstimatesResponseResponsebodyType
    {
        [JsonProperty("originofpackage")]
        public string Originofpackage { get; set; }

        [JsonProperty("destinationofpackage")]
        public string Destinationofpackage { get; set; }

        [JsonProperty("datetimeofpossession")]
        public string Datetimeofpossession { get; set; }

        [JsonProperty("edds")]
        public JToken[] Edds { get; set; }

        [JsonProperty("metadata")]
        public GetPredictiveDeliveryEstimatesResponseResponsebodyTypeMetadataType Metadata { get; set; }
    }

    public class GetPredictiveDeliveryEstimatesResponseResponsebodyTypeMetadataType
    {
        [JsonProperty("requestid")]
        public string Requestid { get; set; }

        [JsonProperty("shipperId")]
        public string ShipperId { get; set; }
    }

    public class PostCompanyRegistrationResponse
    {
        [JsonProperty("successful")]
        public bool Successful { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("registrationId")]
        public string RegistrationId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Fedexdataworks;

    public partial class WorkflowManagedActions
    {
        public FedexdataworksActions Fedexdataworks(string connectionId) => new FedexdataworksActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FedexdataworksTriggers Fedexdataworks(string connectionId) => new FedexdataworksTriggers(connectionId);
    }
}