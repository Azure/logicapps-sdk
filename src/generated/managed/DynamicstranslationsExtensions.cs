//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicstranslations
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DynamicstranslationsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicstranslations")]
        public IBodyWorkflowAction<AlignResponse> Align(Expression<Func<string>> productType, Expression<Func<string>> productVersion, Expression<Func<string>> sourceLanguage, Expression<Func<string>> targetLanguage, Expression<Func<object>> sourceFile, Expression<Func<object>> targetFile)
        {
            var __workflow_productType = WorkflowExpression.Compile(productType, nameof(productType), required: true);
            var __workflow_productVersion = WorkflowExpression.Compile(productVersion, nameof(productVersion), required: true);
            var __workflow_sourceLanguage = WorkflowExpression.Compile(sourceLanguage, nameof(sourceLanguage), required: true);
            var __workflow_targetLanguage = WorkflowExpression.Compile(targetLanguage, nameof(targetLanguage), required: true);
            var __workflow_sourceFile = WorkflowExpression.Compile(sourceFile, nameof(sourceFile), required: true);
            var __workflow_targetFile = WorkflowExpression.Compile(targetFile, nameof(targetFile), required: true);
            return new DeferredBodyAction<AlignResponse>(() =>
            {
                var apiCallPath = "/dts/align/submit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AlignResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicstranslations")]
        public IBodyWorkflowAction<object> Download(Expression<Func<downloadTypeInput>> downloadType, Expression<Func<int>> translationId)
        {
            var __workflow_downloadType = WorkflowExpression.Compile(downloadType, nameof(downloadType), required: true);
            var __workflow_translationId = WorkflowExpression.Compile(translationId, nameof(translationId), required: true);
            return new DeferredBodyAction<object>(() =>
            {
                var apiCallPath = "/dts/translate/download";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["downloadType"] = ExpressionConverter.Convert(__workflow_downloadType);
                callPayload.Queries["translationId"] = ExpressionConverter.Convert(__workflow_translationId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicstranslations")]
        public IBodyWorkflowAction<RegenerateResponse> Regenerate(Expression<Func<int>> translationId, Expression<Func<object>> regenerateFile)
        {
            var __workflow_translationId = WorkflowExpression.Compile(translationId, nameof(translationId), required: true);
            var __workflow_regenerateFile = WorkflowExpression.Compile(regenerateFile, nameof(regenerateFile), required: true);
            return new DeferredBodyAction<RegenerateResponse>(() =>
            {
                var apiCallPath = "/dts/translate/regenerate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["translationId"] = ExpressionConverter.Convert(__workflow_translationId);
                return new ApiConnectionAction<RegenerateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicstranslations")]
        public IBodyWorkflowAction<RetrieveResponse> Retrieve(Expression<Func<int>> translationId)
        {
            var __workflow_translationId = WorkflowExpression.Compile(translationId, nameof(translationId), required: true);
            return new DeferredBodyAction<RetrieveResponse>(() =>
            {
                var apiCallPath = "/dts/translate/retrieve";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["translationId"] = ExpressionConverter.Convert(__workflow_translationId);
                return new ApiConnectionAction<RetrieveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicstranslations")]
        public IBodyWorkflowAction<TranslateResponse> Translate(Expression<Func<string>> productType, Expression<Func<string>> productVersion, Expression<Func<string>> sourceLanguage, Expression<Func<string>> targetLanguage, Expression<Func<string>> requestName, Expression<Func<translationTypeInput>> translationType, Expression<Func<object>> sourceFile, Expression<Func<bool>> trainMTWithTM = null, Expression<Func<object>> tmFile = null)
        {
            var __workflow_productType = WorkflowExpression.Compile(productType, nameof(productType), required: true);
            var __workflow_productVersion = WorkflowExpression.Compile(productVersion, nameof(productVersion), required: true);
            var __workflow_sourceLanguage = WorkflowExpression.Compile(sourceLanguage, nameof(sourceLanguage), required: true);
            var __workflow_targetLanguage = WorkflowExpression.Compile(targetLanguage, nameof(targetLanguage), required: true);
            var __workflow_requestName = WorkflowExpression.Compile(requestName, nameof(requestName), required: true);
            var __workflow_translationType = WorkflowExpression.Compile(translationType, nameof(translationType), required: true);
            var __workflow_sourceFile = WorkflowExpression.Compile(sourceFile, nameof(sourceFile), required: true);
            var __workflow_trainMTWithTM = WorkflowExpression.Compile(trainMTWithTM, nameof(trainMTWithTM), required: false);
            var __workflow_tmFile = WorkflowExpression.Compile(tmFile, nameof(tmFile), required: false);
            return new DeferredBodyAction<TranslateResponse>(() =>
            {
                var apiCallPath = "/dts/translate/submit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TranslateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicstranslations")]
        public IBodyWorkflowAction<object> AlignDownload(Expression<Func<string>> filename)
        {
            var __workflow_filename = WorkflowExpression.Compile(filename, nameof(filename), required: true);
            return new DeferredBodyAction<object>(() =>
            {
                var apiCallPath = "/dts/align/download";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filename"] = ExpressionConverter.Convert(__workflow_filename);
                return new ApiConnectionAction<object>(callPayload);
            });
        }
    }

    public class DynamicstranslationsTriggers([ConnectionName] string connectionId)
    {
    }

    public class AlignResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("alignmentRate")]
        public double AlignmentRate { get; set; }

        [JsonProperty("alignedFile")]
        public string AlignedFile { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum downloadTypeInput
    {
        [EnumMember(Value = "translated")]
        Translated
    }

    public class RegenerateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class RetrieveResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("parentTranslationID")]
        public int ParentTranslationID { get; set; }

        [JsonProperty("requestName")]
        public string RequestName { get; set; }

        [JsonProperty("productType")]
        public int ProductType { get; set; }

        [JsonProperty("productVersion")]
        public int ProductVersion { get; set; }

        [JsonProperty("translationType")]
        public string TranslationType { get; set; }

        [JsonProperty("sourceLanguage")]
        public string SourceLanguage { get; set; }

        [JsonProperty("targetLanguage")]
        public string TargetLanguage { get; set; }

        [JsonProperty("sourceFile")]
        public string SourceFile { get; set; }

        [JsonProperty("translatedFile")]
        public string TranslatedFile { get; set; }

        [JsonProperty("isDeletedRequest")]
        public bool IsDeletedRequest { get; set; }
    }

    public class TranslateResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("translationId")]
        public int TranslationId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum translationTypeInput
    {
        [EnumMember(Value = "ui")]
        Ui
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicstranslations;

    public partial class WorkflowManagedActions
    {
        public DynamicstranslationsActions Dynamicstranslations(string connectionId) => new DynamicstranslationsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DynamicstranslationsTriggers Dynamicstranslations(string connectionId) => new DynamicstranslationsTriggers(connectionId);
    }
}
