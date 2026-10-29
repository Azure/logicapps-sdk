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
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> Download(Expression<Func<downloadTypeInput>> downloadType, Expression<Func<int>> translationId)
        {
            var __workflow_downloadType = WorkflowExpression.Compile(downloadType, nameof(downloadType), required: true);
            var __workflow_translationId = WorkflowExpression.Compile(translationId, nameof(translationId), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<RetrieveResponse, ApiConnectionActionConfiguration> Retrieve(Expression<Func<int>> translationId)
        {
            var __workflow_translationId = WorkflowExpression.Compile(translationId, nameof(translationId), required: true);
            return new DeferredBodyAction<RetrieveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/dts/translate/retrieve";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["translationId"] = ExpressionConverter.Convert(__workflow_translationId);
                return new ApiConnectionAction<RetrieveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "dynamicstranslations")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> AlignDownload(Expression<Func<string>> filename)
        {
            var __workflow_filename = WorkflowExpression.Compile(filename, nameof(filename), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum downloadTypeInput
    {
        [EnumMember(Value = "translated")]
        Translated
    }

    public class RetrieveResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("parentTranslationID")]
        public int ParentTranslationId { get; set; }

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