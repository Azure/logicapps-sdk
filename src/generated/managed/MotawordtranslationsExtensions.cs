//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Motawordtranslations
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MotawordtranslationsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "motawordtranslations")]
        public IBodyWorkflowAction<InitializeTranslationProjectResponse, ApiConnectionActionConfiguration> InitializeTranslationProject(Expression<Func<InitializeTranslationProjectBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<InitializeTranslationProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/projects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<InitializeTranslationProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "motawordtranslations")]
        public IBodyWorkflowAction<GetProjectDetailsResponse, ApiConnectionActionConfiguration> GetProjectDetails(Expression<Func<int>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<GetProjectDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetProjectDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "motawordtranslations")]
        public IBodyWorkflowAction<LaunchTranslationProjectResponse, ApiConnectionActionConfiguration> LaunchTranslationProject(Expression<Func<string>> projectId)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredBodyAction<LaunchTranslationProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/launch", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LaunchTranslationProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "motawordtranslations")]
        public IBodyWorkflowAction<AddDocumentsForTranslationResponse, ApiConnectionActionConfiguration> AddDocumentsForTranslation(Expression<Func<string>> projectId, Expression<Func<AddDocumentsForTranslationBodyInput>> body = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AddDocumentsForTranslationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/documents", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddDocumentsForTranslationResponse>(callPayload);
            });
        }
    }

    public class MotawordtranslationsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenTranslationProjectCompleted(Expression<Func<int>> projectId, FlowRecurrence recurrence = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/webhooks", __workflow_projectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new WhenTranslationProjectCompletedBodyInput().ToJToken();
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class InitializeTranslationProjectResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("source_language")]
        public string SourceLanguage { get; set; }

        [JsonProperty("target_languages")]
        public string[] TargetLanguages { get; set; }

        [JsonProperty("word_count")]
        public int WordCount { get; set; }

        [JsonProperty("price")]
        public InitializeTranslationProjectResponsePriceType Price { get; set; }

        [JsonProperty("price_without_discount")]
        public InitializeTranslationProjectResponsePriceWithoutDiscountType PriceWithoutDiscount { get; set; }

        [JsonProperty("status")]
        public InitializeTranslationProjectResponseStatusType Status { get; set; }

        [JsonProperty("delivery_at")]
        public int DeliveryAt { get; set; }

        [JsonProperty("completed_on")]
        public string CompletedOn { get; set; }

        [JsonProperty("valid_until")]
        public int ValidUntil { get; set; }

        [JsonProperty("custom")]
        public string Custom { get; set; }

        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }
    }

    public class InitializeTranslationProjectResponsePriceType
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("usd_amount")]
        public double UsdAmount { get; set; }
    }

    public class InitializeTranslationProjectResponsePriceWithoutDiscountType
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("usd_amount")]
        public double UsdAmount { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InitializeTranslationProjectResponseStatusType
    {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "started")]
        Started,
        [EnumMember(Value = "translated")]
        Translated,
        [EnumMember(Value = "completed")]
        Completed
    }

    public class InitializeTranslationProjectBodyInput
    {
        [JsonProperty("documents")]
        public InitializeTranslationProjectBodyInputDocumentsTypeItem[] Documents { get; set; }

        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        [JsonProperty("source_language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceLanguage { get; set; }

        [JsonProperty("target_languages", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] TargetLanguages { get; set; }
    }

    public class InitializeTranslationProjectBodyInputDocumentsTypeItem
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent Data { get; set; }
    }

    public class GetProjectDetailsResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("source_language")]
        public string SourceLanguage { get; set; }

        [JsonProperty("target_languages")]
        public string[] TargetLanguages { get; set; }

        [JsonProperty("word_count")]
        public int WordCount { get; set; }

        [JsonProperty("price")]
        public GetProjectDetailsResponsePriceType Price { get; set; }

        [JsonProperty("price_without_discount")]
        public GetProjectDetailsResponsePriceWithoutDiscountType PriceWithoutDiscount { get; set; }

        [JsonProperty("status")]
        public GetProjectDetailsResponseStatusType Status { get; set; }

        [JsonProperty("delivery_at")]
        public int DeliveryAt { get; set; }

        [JsonProperty("completed_on")]
        public string CompletedOn { get; set; }

        [JsonProperty("valid_until")]
        public int ValidUntil { get; set; }

        [JsonProperty("custom")]
        public string Custom { get; set; }

        [JsonProperty("callback_url")]
        public string CallbackUrl { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }
    }

    public class GetProjectDetailsResponsePriceType
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("usd_amount")]
        public double UsdAmount { get; set; }
    }

    public class GetProjectDetailsResponsePriceWithoutDiscountType
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("usd_amount")]
        public double UsdAmount { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetProjectDetailsResponseStatusType
    {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "started")]
        Started,
        [EnumMember(Value = "translated")]
        Translated,
        [EnumMember(Value = "completed")]
        Completed
    }

    public class LaunchTranslationProjectResponse
    {
        [JsonProperty("status")]
        public LaunchTranslationProjectResponseStatusType Status { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LaunchTranslationProjectResponseStatusType
    {
        [EnumMember(Value = "started")]
        Started,
        [EnumMember(Value = "failed")]
        Failed
    }

    public class AddDocumentsForTranslationResponse
    {
        [JsonProperty("documents")]
        public AddDocumentsForTranslationResponseDocumentsTypeItem[] Documents { get; set; }
    }

    public class AddDocumentsForTranslationResponseDocumentsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uploaded_at")]
        public int UploadedAt { get; set; }

        [JsonProperty("word_count")]
        public int WordCount { get; set; }

        [JsonProperty("scheme")]
        public JToken Scheme { get; set; }
    }

    public class AddDocumentsForTranslationBodyInput
    {
        [JsonProperty("documents")]
        public AddDocumentsForTranslationBodyInputDocumentsTypeItem[] Documents { get; set; }
    }

    public class AddDocumentsForTranslationBodyInputDocumentsTypeItem
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WhatDoYouWantToNameThisFileOnMotaWordSide { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent Base64EncodedContentOfTheFileYouWantTranslated { get; set; }
    }

    public class WhenTranslationProjectCompletedBodyInput
    {
        [JsonProperty("callback_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Motawordtranslations;

    public partial class WorkflowManagedActions
    {
        public MotawordtranslationsActions Motawordtranslations(string connectionId) => new MotawordtranslationsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MotawordtranslationsTriggers Motawordtranslations(string connectionId) => new MotawordtranslationsTriggers(connectionId);
    }
}