//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fedexdataworks
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

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
        public IBodyWorkflowAction<DeleteCompanySubscriptionResponse> DeleteCompanySubscription(Expression<Func<string>> subscriptionId)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            return new DeferredBodyAction<DeleteCompanySubscriptionResponse>(() =>
            {
                var apiCallPath = "/webhook/v1/subscription";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["subscriptionId"] = ExpressionConverter.Convert(__workflow_subscriptionId);
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
        public IBodyWorkflowAction<PostCompanySubscriptionResponse> PostCompanySubscription(Expression<Func<string>> bodyEvent, Expression<Func<string>> bodyregistrationId, Expression<Func<string>> bodykey, Expression<Func<string[]>> bodyvalues, Expression<Func<string>> bodycallbackUrl = null)
        {
            var __workflow_bodyEvent = WorkflowExpression.Compile(bodyEvent, nameof(bodyEvent), required: true);
            var __workflow_bodyregistrationId = WorkflowExpression.Compile(bodyregistrationId, nameof(bodyregistrationId), required: true);
            var __workflow_bodykey = WorkflowExpression.Compile(bodykey, nameof(bodykey), required: true);
            var __workflow_bodyvalues = WorkflowExpression.Compile(bodyvalues, nameof(bodyvalues), required: true);
            var __workflow_bodycallbackUrl = WorkflowExpression.Compile(bodycallbackUrl, nameof(bodycallbackUrl), required: false);
            return new DeferredBodyAction<PostCompanySubscriptionResponse>(() =>
            {
                var apiCallPath = "/webhook/v1/subscription";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event"] = ExpressionConverter.ConvertO(__workflow_bodyEvent);
                bodypropCount++;
                body["registrationId"] = ExpressionConverter.ConvertO(__workflow_bodyregistrationId);
                if (__workflow_bodycallbackUrl != null)
                {
                    body["callbackUrl"] = ExpressionConverter.ConvertO(__workflow_bodycallbackUrl);
                    bodypropCount++;
                }

                bodypropCount++;
                body["key"] = ExpressionConverter.ConvertO(__workflow_bodykey);
                bodypropCount++;
                body["values"] = ExpressionConverter.ConvertO(__workflow_bodyvalues);
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
        public IBodyWorkflowAction<ValidateWebhookNotificationSignatureResponse> ValidateWebhookNotificationSignature(Expression<Func<string>> messageSignature, Expression<Func<string>> secretKey)
        {
            var __workflow_messageSignature = WorkflowExpression.Compile(messageSignature, nameof(messageSignature), required: true);
            var __workflow_secretKey = WorkflowExpression.Compile(secretKey, nameof(secretKey), required: true);
            return new DeferredBodyAction<ValidateWebhookNotificationSignatureResponse>(() =>
            {
                var apiCallPath = "/validatesignature";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["MessageSignature"] = ExpressionConverter.Convert(__workflow_messageSignature);
                callPayload.Headers["SecretKey"] = ExpressionConverter.Convert(__workflow_secretKey);
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
        public IBodyWorkflowAction<DeleteCompanyRegistrationResponse> DeleteCompanyRegistration(Expression<Func<string>> registrationId = null)
        {
            var __workflow_registrationId = WorkflowExpression.Compile(registrationId, nameof(registrationId), required: false);
            return new DeferredBodyAction<DeleteCompanyRegistrationResponse>(() =>
            {
                var apiCallPath = "/webhook/v1/deleteregistration";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_registrationId != null)
                    callPayload.Queries["registrationId"] = ExpressionConverter.Convert(__workflow_registrationId);
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
        public IBodyWorkflowTrigger<PostCompanyRegistrationResponse> PostCompanyRegistration(Expression<Func<string>> bodyEvent, Expression<Func<string>> bodycallbackSignatureSecretKey, Expression<Func<string>> bodycallbackSignatureAlgorithm, Expression<Func<string>> bodycallbackAuthUrl = null, Expression<Func<string>> bodycallbackClientId = null, Expression<Func<string>> bodycallbackClientSecret = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyEvent = WorkflowExpression.Compile(bodyEvent, nameof(bodyEvent), required: true);
            var __workflow_bodycallbackSignatureSecretKey = WorkflowExpression.Compile(bodycallbackSignatureSecretKey, nameof(bodycallbackSignatureSecretKey), required: true);
            var __workflow_bodycallbackSignatureAlgorithm = WorkflowExpression.Compile(bodycallbackSignatureAlgorithm, nameof(bodycallbackSignatureAlgorithm), required: true);
            var __workflow_bodycallbackAuthUrl = WorkflowExpression.Compile(bodycallbackAuthUrl, nameof(bodycallbackAuthUrl), required: false);
            var __workflow_bodycallbackClientId = WorkflowExpression.Compile(bodycallbackClientId, nameof(bodycallbackClientId), required: false);
            var __workflow_bodycallbackClientSecret = WorkflowExpression.Compile(bodycallbackClientSecret, nameof(bodycallbackClientSecret), required: false);
            return new DeferredBodyTrigger<PostCompanyRegistrationResponse>(() =>
            {
                var apiCallPath = "/webhook/v1/register";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event"] = ExpressionConverter.ConvertO(__workflow_bodyEvent);
                bodypropCount++;
                body["callbackSignatureSecretKey"] = ExpressionConverter.ConvertO(__workflow_bodycallbackSignatureSecretKey);
                if (__workflow_bodycallbackAuthUrl != null)
                {
                    body["callbackAuthUrl"] = ExpressionConverter.ConvertO(__workflow_bodycallbackAuthUrl);
                    bodypropCount++;
                }

                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (__workflow_bodycallbackClientId != null)
                {
                    body["callbackClientId"] = ExpressionConverter.ConvertO(__workflow_bodycallbackClientId);
                    bodypropCount++;
                }

                if (__workflow_bodycallbackClientSecret != null)
                {
                    body["callbackClientSecret"] = ExpressionConverter.ConvertO(__workflow_bodycallbackClientSecret);
                    bodypropCount++;
                }

                bodypropCount++;
                body["callbackSignatureAlgorithm"] = ExpressionConverter.ConvertO(__workflow_bodycallbackSignatureAlgorithm);
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
