//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Anttextautomation
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AnttextautomationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "anttextautomation")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PostAntTextEmail(Expression<Func<PostAntTextEmailInput>> postBodyParameter)
        {
            var __workflow_postBodyParameter = WorkflowExpression.Compile(postBodyParameter, nameof(postBodyParameter), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/templates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_postBodyParameter);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class AnttextautomationTriggers([ConnectionName] string connectionId)
    {
    }

    public class PostAntTextEmailInput
    {
        [JsonProperty("AntTextOwner", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmailForAntTextBusiness { get; set; }

        [JsonProperty("AntTextLicenseKey", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AntTextBusinessLicenseKey { get; set; }

        [JsonProperty("CalledFrom", DefaultValueHandling = DefaultValueHandling.Include)]
        public string KeyPhraseConfirmation { get; set; }

        [JsonProperty("TemplateID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public PostAntTextEmailInputSaveCopyToSentItemsType? SaveCopyToSentItems { get; set; } = PostAntTextEmailInputSaveCopyToSentItemsType.Yes;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public PostAntTextEmailInputImportanceType? Importance { get; set; } = PostAntTextEmailInputImportanceType.Normal;
        public string FlowField1 { get; set; }
        public string FlowField2 { get; set; }
        public string FlowField3 { get; set; }
        public string FlowField4 { get; set; }
        public string FlowField5 { get; set; }
        public string FlowField6 { get; set; }
        public string FlowField7 { get; set; }
        public string FlowField8 { get; set; }
        public string FlowField9 { get; set; }
        public string FlowField10 { get; set; }
        public string FlowField11 { get; set; }
        public string FlowField12 { get; set; }
        public string FlowField13 { get; set; }
        public string FlowField14 { get; set; }
        public string FlowField15 { get; set; }
        public string FlowField16 { get; set; }
        public string FlowField17 { get; set; }
        public string FlowField18 { get; set; }
        public string FlowField19 { get; set; }
        public string FlowField20 { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public PostAntTextEmailInputIncludeAntTextSignatureType? IncludeAntTextSignature { get; set; } = PostAntTextEmailInputIncludeAntTextSignatureType.Yes;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PostAntTextEmailInputSaveCopyToSentItemsType
    {
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PostAntTextEmailInputImportanceType
    {
        High,
        Normal,
        Low
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PostAntTextEmailInputIncludeAntTextSignatureType
    {
        Yes,
        No
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Anttextautomation;

    public partial class WorkflowManagedActions
    {
        public AnttextautomationActions Anttextautomation(string connectionId) => new AnttextautomationActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AnttextautomationTriggers Anttextautomation(string connectionId) => new AnttextautomationTriggers(connectionId);
    }
}