//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicstranslations
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DynamicstranslationsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicstranslations")]
        [WorkflowExpressionFactory(nameof(__BuildAlign))]
        public IBodyWorkflowAction<AlignResponse> Align([WorkflowExpression] Func<string> productType, [WorkflowExpression] Func<string> productVersion, [WorkflowExpression] Func<string> sourceLanguage, [WorkflowExpression] Func<string> targetLanguage, [WorkflowExpression] Func<object> sourceFile, [WorkflowExpression] Func<object> targetFile)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AlignResponse> __BuildAlign(WorkflowValue<string> productType, WorkflowValue<string> productVersion, WorkflowValue<string> sourceLanguage, WorkflowValue<string> targetLanguage, WorkflowValue<object> sourceFile, WorkflowValue<object> targetFile)
        {
            WorkflowValue.Validate(productType, nameof(productType), required: true);
            WorkflowValue.Validate(productVersion, nameof(productVersion), required: true);
            WorkflowValue.Validate(sourceLanguage, nameof(sourceLanguage), required: true);
            WorkflowValue.Validate(targetLanguage, nameof(targetLanguage), required: true);
            WorkflowValue.Validate(sourceFile, nameof(sourceFile), required: true);
            WorkflowValue.Validate(targetFile, nameof(targetFile), required: true);
            return new DeferredBodyAction<AlignResponse>(() =>
            {
                var apiCallPath = "/dts/align/submit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AlignResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicstranslations")]
        [WorkflowExpressionFactory(nameof(__BuildDownload))]
        public IBodyWorkflowAction<object> Download([WorkflowExpression] Func<downloadTypeInput> downloadType, [WorkflowExpression] Func<int> translationId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<object> __BuildDownload(WorkflowValue<downloadTypeInput> downloadType, WorkflowValue<int> translationId)
        {
            WorkflowValue.Validate(downloadType, nameof(downloadType), required: true);
            WorkflowValue.Validate(translationId, nameof(translationId), required: true);
            return new DeferredBodyAction<object>(() =>
            {
                var apiCallPath = "/dts/translate/download";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["downloadType"] = ExpressionConverter.Convert(downloadType);
                callPayload.Queries["translationId"] = ExpressionConverter.Convert(translationId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicstranslations")]
        [WorkflowExpressionFactory(nameof(__BuildRegenerate))]
        public IBodyWorkflowAction<RegenerateResponse> Regenerate([WorkflowExpression] Func<int> translationId, [WorkflowExpression] Func<object> regenerateFile)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RegenerateResponse> __BuildRegenerate(WorkflowValue<int> translationId, WorkflowValue<object> regenerateFile)
        {
            WorkflowValue.Validate(translationId, nameof(translationId), required: true);
            WorkflowValue.Validate(regenerateFile, nameof(regenerateFile), required: true);
            return new DeferredBodyAction<RegenerateResponse>(() =>
            {
                var apiCallPath = "/dts/translate/regenerate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["translationId"] = ExpressionConverter.Convert(translationId);
                return new ApiConnectionAction<RegenerateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicstranslations")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieve))]
        public IBodyWorkflowAction<RetrieveResponse> Retrieve([WorkflowExpression] Func<int> translationId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RetrieveResponse> __BuildRetrieve(WorkflowValue<int> translationId)
        {
            WorkflowValue.Validate(translationId, nameof(translationId), required: true);
            return new DeferredBodyAction<RetrieveResponse>(() =>
            {
                var apiCallPath = "/dts/translate/retrieve";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["translationId"] = ExpressionConverter.Convert(translationId);
                return new ApiConnectionAction<RetrieveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicstranslations")]
        [WorkflowExpressionFactory(nameof(__BuildTranslate))]
        public IBodyWorkflowAction<TranslateResponse> Translate([WorkflowExpression] Func<string> productType, [WorkflowExpression] Func<string> productVersion, [WorkflowExpression] Func<string> sourceLanguage, [WorkflowExpression] Func<string> targetLanguage, [WorkflowExpression] Func<string> requestName, [WorkflowExpression] Func<translationTypeInput> translationType, [WorkflowExpression] Func<object> sourceFile, [WorkflowExpression] Func<bool> trainMTWithTM = null, [WorkflowExpression] Func<object> tmFile = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TranslateResponse> __BuildTranslate(WorkflowValue<string> productType, WorkflowValue<string> productVersion, WorkflowValue<string> sourceLanguage, WorkflowValue<string> targetLanguage, WorkflowValue<string> requestName, WorkflowValue<translationTypeInput> translationType, WorkflowValue<object> sourceFile, WorkflowValue<bool> trainMTWithTM = null, WorkflowValue<object> tmFile = null)
        {
            WorkflowValue.Validate(productType, nameof(productType), required: true);
            WorkflowValue.Validate(productVersion, nameof(productVersion), required: true);
            WorkflowValue.Validate(sourceLanguage, nameof(sourceLanguage), required: true);
            WorkflowValue.Validate(targetLanguage, nameof(targetLanguage), required: true);
            WorkflowValue.Validate(requestName, nameof(requestName), required: true);
            WorkflowValue.Validate(translationType, nameof(translationType), required: true);
            WorkflowValue.Validate(sourceFile, nameof(sourceFile), required: true);
            WorkflowValue.Validate(trainMTWithTM, nameof(trainMTWithTM), required: false);
            WorkflowValue.Validate(tmFile, nameof(tmFile), required: false);
            return new DeferredBodyAction<TranslateResponse>(() =>
            {
                var apiCallPath = "/dts/translate/submit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TranslateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicstranslations")]
        [WorkflowExpressionFactory(nameof(__BuildAlignDownload))]
        public IBodyWorkflowAction<object> AlignDownload([WorkflowExpression] Func<string> filename)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<object> __BuildAlignDownload(WorkflowValue<string> filename)
        {
            WorkflowValue.Validate(filename, nameof(filename), required: true);
            return new DeferredBodyAction<object>(() =>
            {
                var apiCallPath = "/dts/align/download";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filename"] = ExpressionConverter.Convert(filename);
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
