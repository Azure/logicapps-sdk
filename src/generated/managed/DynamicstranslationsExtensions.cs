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