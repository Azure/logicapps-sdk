//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Dynamicstranslations
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DynamicstranslationsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicstranslations")]
        public IBodyWorkflowAction<AlignResponse> Align([WorkflowExpression] Func<string> productType, [WorkflowExpression] Func<string> productVersion, [WorkflowExpression] Func<string> sourceLanguage, [WorkflowExpression] Func<string> targetLanguage, [WorkflowExpression] Func<object> sourceFile, [WorkflowExpression] Func<object> targetFile)
        {
            SourceExpression.Validate(productType, nameof(productType), required: true);
            SourceExpression.Validate(productVersion, nameof(productVersion), required: true);
            SourceExpression.Validate(sourceLanguage, nameof(sourceLanguage), required: true);
            SourceExpression.Validate(targetLanguage, nameof(targetLanguage), required: true);
            SourceExpression.Validate(sourceFile, nameof(sourceFile), required: true);
            SourceExpression.Validate(targetFile, nameof(targetFile), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/dts/align/submit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AlignResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicstranslations")]
        public IBodyWorkflowAction<object> Download([WorkflowExpression] Func<downloadTypeInput> downloadType, [WorkflowExpression] Func<int> translationId)
        {
            SourceExpression.Validate(downloadType, nameof(downloadType), required: true);
            SourceExpression.Validate(translationId, nameof(translationId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/dts/translate/download";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["downloadType"] = SourceExpressionConverter.Convert(downloadType);
                callPayload.Queries["translationId"] = SourceExpressionConverter.ConvertO(translationId);
                return callPayload;
            }

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicstranslations")]
        public IBodyWorkflowAction<RegenerateResponse> Regenerate([WorkflowExpression] Func<int> translationId, [WorkflowExpression] Func<object> regenerateFile)
        {
            SourceExpression.Validate(translationId, nameof(translationId), required: true);
            SourceExpression.Validate(regenerateFile, nameof(regenerateFile), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/dts/translate/regenerate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["translationId"] = SourceExpressionConverter.ConvertO(translationId);
                return callPayload;
            }

            return new ApiConnectionAction<RegenerateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicstranslations")]
        public IBodyWorkflowAction<RetrieveResponse> Retrieve([WorkflowExpression] Func<int> translationId)
        {
            SourceExpression.Validate(translationId, nameof(translationId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/dts/translate/retrieve";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["translationId"] = SourceExpressionConverter.ConvertO(translationId);
                return callPayload;
            }

            return new ApiConnectionAction<RetrieveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicstranslations")]
        public IBodyWorkflowAction<TranslateResponse> Translate([WorkflowExpression] Func<string> productType, [WorkflowExpression] Func<string> productVersion, [WorkflowExpression] Func<string> sourceLanguage, [WorkflowExpression] Func<string> targetLanguage, [WorkflowExpression] Func<string> requestName, [WorkflowExpression] Func<translationTypeInput> translationType, [WorkflowExpression] Func<object> sourceFile, [WorkflowExpression] Func<bool> trainMTWithTM = null, [WorkflowExpression] Func<object> tmFile = null)
        {
            SourceExpression.Validate(productType, nameof(productType), required: true);
            SourceExpression.Validate(productVersion, nameof(productVersion), required: true);
            SourceExpression.Validate(sourceLanguage, nameof(sourceLanguage), required: true);
            SourceExpression.Validate(targetLanguage, nameof(targetLanguage), required: true);
            SourceExpression.Validate(requestName, nameof(requestName), required: true);
            SourceExpression.Validate(translationType, nameof(translationType), required: true);
            SourceExpression.Validate(sourceFile, nameof(sourceFile), required: true);
            SourceExpression.Validate(trainMTWithTM, nameof(trainMTWithTM), required: false);
            SourceExpression.Validate(tmFile, nameof(tmFile), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/dts/translate/submit";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TranslateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicstranslations")]
        public IBodyWorkflowAction<object> AlignDownload([WorkflowExpression] Func<string> filename)
        {
            SourceExpression.Validate(filename, nameof(filename), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/dts/align/download";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filename"] = SourceExpressionConverter.ConvertO(filename);
                return callPayload;
            }

            return new ApiConnectionAction<object>(BuildSourceInput);
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