//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fedexdataworks
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FedexdataworksActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fedexdataworks")]
        public IBodyWorkflowAction<GetTransportationPlanScoresResponse> GetTransportationPlanScores()
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

            return new ApiConnectionAction<GetTransportationPlanScoresResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fedexdataworks")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteCompanySubscription))]
        public IBodyWorkflowAction<DeleteCompanySubscriptionResponse> DeleteCompanySubscription([WorkflowExpression] Func<string> subscriptionId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fedexdataworks")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteCompanySubscriptionResponse> __BuildDeleteCompanySubscription(WorkflowExpression<string> subscriptionId)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            return new DeferredBodyAction<DeleteCompanySubscriptionResponse>(() =>
            {
                var apiCallPath = "/webhook/v1/subscription";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["subscriptionId"] = ExpressionConverter.Convert(subscriptionId);
                return new ApiConnectionAction<DeleteCompanySubscriptionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fedexdataworks")]
        public IBodyWorkflowAction<GetCompanySubscriptionsResponse> GetCompanySubscriptions()
        {
            var apiCallPath = "/webhook/v1/subscription";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetCompanySubscriptionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fedexdataworks")]
        [WorkflowExpressionFactory(nameof(__BuildPostCompanySubscription))]
        public IBodyWorkflowAction<PostCompanySubscriptionResponse> PostCompanySubscription([WorkflowExpression] Func<string> bodyEvent, [WorkflowExpression] Func<string> bodyregistrationId, [WorkflowExpression] Func<string> bodykey, [WorkflowExpression] Func<string[]> bodyvalues, [WorkflowExpression] Func<string> bodycallbackUrl = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fedexdataworks")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostCompanySubscriptionResponse> __BuildPostCompanySubscription(WorkflowExpression<string> bodyEvent, WorkflowExpression<string> bodyregistrationId, WorkflowExpression<string> bodykey, WorkflowExpression<string[]> bodyvalues, WorkflowExpression<string> bodycallbackUrl = null)
        {
            WorkflowExpression.Validate(bodyEvent, nameof(bodyEvent), required: true);
            WorkflowExpression.Validate(bodyregistrationId, nameof(bodyregistrationId), required: true);
            WorkflowExpression.Validate(bodykey, nameof(bodykey), required: true);
            WorkflowExpression.Validate(bodyvalues, nameof(bodyvalues), required: true);
            WorkflowExpression.Validate(bodycallbackUrl, nameof(bodycallbackUrl), required: false);
            return new DeferredBodyAction<PostCompanySubscriptionResponse>(() =>
            {
                var apiCallPath = "/webhook/v1/subscription";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event"] = ExpressionConverter.ConvertO(bodyEvent);
                bodypropCount++;
                body["registrationId"] = ExpressionConverter.ConvertO(bodyregistrationId);
                if (bodycallbackUrl != null)
                {
                    body["callbackUrl"] = ExpressionConverter.ConvertO(bodycallbackUrl);
                    bodypropCount++;
                }

                bodypropCount++;
                body["key"] = ExpressionConverter.ConvertO(bodykey);
                bodypropCount++;
                body["values"] = ExpressionConverter.ConvertO(bodyvalues);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostCompanySubscriptionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fedexdataworks")]
        public IBodyWorkflowAction<GetCompanyRegistrationsResponse> GetCompanyRegistrations()
        {
            var apiCallPath = "/webhook/v1/registrations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetCompanyRegistrationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fedexdataworks")]
        [WorkflowExpressionFactory(nameof(__BuildValidateWebhookNotificationSignature))]
        public IBodyWorkflowAction<ValidateWebhookNotificationSignatureResponse> ValidateWebhookNotificationSignature([WorkflowExpression] Func<string> messageSignature, [WorkflowExpression] Func<string> secretKey)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fedexdataworks")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ValidateWebhookNotificationSignatureResponse> __BuildValidateWebhookNotificationSignature(WorkflowExpression<string> messageSignature, WorkflowExpression<string> secretKey)
        {
            WorkflowExpression.Validate(messageSignature, nameof(messageSignature), required: true);
            WorkflowExpression.Validate(secretKey, nameof(secretKey), required: true);
            return new DeferredBodyAction<ValidateWebhookNotificationSignatureResponse>(() =>
            {
                var apiCallPath = "/validatesignature";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["MessageSignature"] = ExpressionConverter.Convert(messageSignature);
                callPayload.Headers["SecretKey"] = ExpressionConverter.Convert(secretKey);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ValidateWebhookNotificationSignatureResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fedexdataworks")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteCompanyRegistration))]
        public IBodyWorkflowAction<DeleteCompanyRegistrationResponse> DeleteCompanyRegistration([WorkflowExpression] Func<string> registrationId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fedexdataworks")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteCompanyRegistrationResponse> __BuildDeleteCompanyRegistration(WorkflowExpression<string> registrationId = null)
        {
            WorkflowExpression.Validate(registrationId, nameof(registrationId), required: false);
            return new DeferredBodyAction<DeleteCompanyRegistrationResponse>(() =>
            {
                var apiCallPath = "/webhook/v1/deleteregistration";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (registrationId != null)
                    callPayload.Queries["registrationId"] = ExpressionConverter.Convert(registrationId);
                return new ApiConnectionAction<DeleteCompanyRegistrationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fedexdataworks")]
        public IBodyWorkflowAction<GetPredictiveDeliveryEstimatesResponse> GetPredictiveDeliveryEstimates()
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

            return new ApiConnectionAction<GetPredictiveDeliveryEstimatesResponse>(callPayload);
        }
    }

    public class FedexdataworksTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildPostCompanyRegistration))]
        public IBodyWorkflowTrigger<PostCompanyRegistrationResponse> PostCompanyRegistration([WorkflowExpression] Func<string> bodyEvent,[WorkflowExpression] Func<string> bodycallbackSignatureSecretKey,[WorkflowExpression] Func<string> bodycallbackSignatureAlgorithm,[WorkflowExpression] Func<string> bodycallbackAuthUrl = null,[WorkflowExpression] Func<string> bodycallbackClientId = null,[WorkflowExpression] Func<string> bodycallbackClientSecret = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<PostCompanyRegistrationResponse> __BuildPostCompanyRegistration(WorkflowExpression<string> bodyEvent,WorkflowExpression<string> bodycallbackSignatureSecretKey,WorkflowExpression<string> bodycallbackSignatureAlgorithm,WorkflowExpression<string> bodycallbackAuthUrl = null,WorkflowExpression<string> bodycallbackClientId = null,WorkflowExpression<string> bodycallbackClientSecret = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyEvent, nameof(bodyEvent), required: true);
            WorkflowExpression.Validate(bodycallbackSignatureSecretKey, nameof(bodycallbackSignatureSecretKey), required: true);
            WorkflowExpression.Validate(bodycallbackSignatureAlgorithm, nameof(bodycallbackSignatureAlgorithm), required: true);
            WorkflowExpression.Validate(bodycallbackAuthUrl, nameof(bodycallbackAuthUrl), required: false);
            WorkflowExpression.Validate(bodycallbackClientId, nameof(bodycallbackClientId), required: false);
            WorkflowExpression.Validate(bodycallbackClientSecret, nameof(bodycallbackClientSecret), required: false);
            return new DeferredBodyTrigger<PostCompanyRegistrationResponse>(() =>
            {
                var apiCallPath = "/webhook/v1/register";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event"] = ExpressionConverter.ConvertO(bodyEvent);
                bodypropCount++;
                body["callbackSignatureSecretKey"] = ExpressionConverter.ConvertO(bodycallbackSignatureSecretKey);
                if (bodycallbackAuthUrl != null)
                {
                    body["callbackAuthUrl"] = ExpressionConverter.ConvertO(bodycallbackAuthUrl);
                    bodypropCount++;
                }

                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodycallbackClientId != null)
                {
                    body["callbackClientId"] = ExpressionConverter.ConvertO(bodycallbackClientId);
                    bodypropCount++;
                }

                if (bodycallbackClientSecret != null)
                {
                    body["callbackClientSecret"] = ExpressionConverter.ConvertO(bodycallbackClientSecret);
                    bodypropCount++;
                }

                bodypropCount++;
                body["callbackSignatureAlgorithm"] = ExpressionConverter.ConvertO(bodycallbackSignatureAlgorithm);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<PostCompanyRegistrationResponse>(callPayload, recurrence: recurrence);
            });
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