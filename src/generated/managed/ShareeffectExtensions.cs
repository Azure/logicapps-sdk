//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shareeffect
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ShareeffectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shareeffect")]
        public IBodyWorkflowAction<AddUpdateTermResponse, ApiConnectionActionConfiguration> AddUpdateTerm(Expression<Func<AddUpdateTermInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddUpdateTermResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AddUpdateTerm";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddUpdateTermResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shareeffect")]
        public IBodyWorkflowAction<AddUpdateTermByKeyValueResponse, ApiConnectionActionConfiguration> AddUpdateTermByKeyValue(Expression<Func<AddUpdateTermByKeyValueInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddUpdateTermByKeyValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AddUpdateTermByKeyvalue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddUpdateTermByKeyValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shareeffect")]
        public IBodyWorkflowAction<GetTermByKeyValueResponseItem[], ApiConnectionActionConfiguration> GetTermByKeyValue(Expression<Func<string>> searchValue)
        {
            var __workflow_searchValue = WorkflowExpression.Compile(searchValue, nameof(searchValue), required: true);
            return new DeferredBodyAction<GetTermByKeyValueResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetTermsByProperty";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchProperty"] = Convert.ToString("KeyValue");
                callPayload.Queries["searchValue"] = ExpressionConverter.Convert(__workflow_searchValue);
                return new ApiConnectionAction<GetTermByKeyValueResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shareeffect")]
        public IBodyWorkflowAction<GetTermByLabelResponseItem[], ApiConnectionActionConfiguration> GetTermByLabel(Expression<Func<string>> searchValue)
        {
            var __workflow_searchValue = WorkflowExpression.Compile(searchValue, nameof(searchValue), required: true);
            return new DeferredBodyAction<GetTermByLabelResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetTermsByTermLabel";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchValue"] = ExpressionConverter.Convert(__workflow_searchValue);
                return new ApiConnectionAction<GetTermByLabelResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shareeffect")]
        public IBodyWorkflowAction<UploadTemplateResponse, ApiConnectionActionConfiguration> UploadTemplate(Expression<Func<UploadTemplateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UploadTemplateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/uploadtemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UploadTemplateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shareeffect")]
        public IBodyWorkflowAction<GenerateDocumentResponse, ApiConnectionActionConfiguration> GenerateDocument(Expression<Func<GenerateDocumentInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GenerateDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GenerateDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GenerateDocumentResponse>(callPayload);
            });
        }
    }

    public class ShareeffectTriggers([ConnectionName] string connectionId)
    {
    }

    public class AddUpdateTermResponse
    {
        public string Result { get; set; }
        public string Termid { get; set; }
        public string Term { get; set; }
        public string LicenseExpires { get; set; }
    }

    public class AddUpdateTermInput
    {
        [JsonProperty("isavailable", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Isavailable { get; set; } = true;

        [JsonProperty("otherlabels")]
        public string Otherlabels { get; set; }

        [JsonProperty("parentterm")]
        public string Parentterm { get; set; }

        [JsonProperty("termlabel", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Termlabel { get; set; }

        [JsonProperty("termsgroup", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Termsgroup { get; set; }

        [JsonProperty("termsset", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Termsset { get; set; }
    }

    public class AddUpdateTermByKeyValueResponse
    {
        public string Result { get; set; }
        public string Termid { get; set; }
        public string Term { get; set; }
        public string LicenseExpires { get; set; }
    }

    public class AddUpdateTermByKeyValueInput
    {
        [JsonProperty("isavailable", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Isavailable { get; set; } = true;

        [JsonProperty("keyvalue", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Keyvalue { get; set; }

        [JsonProperty("otherlabels")]
        public string Otherlabels { get; set; }

        [JsonProperty("parentterm")]
        public string Parentterm { get; set; }

        [JsonProperty("termlabel", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Termlabel { get; set; }

        [JsonProperty("termsgroup", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Termsgroup { get; set; }

        [JsonProperty("termsset", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Termsset { get; set; }
    }

    public class GetTermByKeyValueResponseItem
    {
        public string KeyValue { get; set; }
        public string Term { get; set; }
        public string TermSet { get; set; }
    }

    public class GetTermByLabelResponseItem
    {
        public string KeyValue { get; set; }
        public string Term { get; set; }
        public string TermSet { get; set; }
    }

    public class UploadTemplateResponse
    {
        [JsonProperty("templateId")]
        public string TemplateId { get; set; }
    }

    public class UploadTemplateInput
    {
        [JsonProperty("templateId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateId { get; set; }

        [JsonProperty("template", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Template { get; set; }
    }

    public class GenerateDocumentResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    public class GenerateDocumentInput
    {
        [JsonProperty("templateId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateId { get; set; }

        [JsonProperty("outputformat", DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateDocumentInputOutputformatType Outputformat { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Data { get; set; }

        [JsonProperty("properties")]
        public JToken Properties { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GenerateDocumentInputOutputformatType
    {
        [EnumMember(Value = "docx")]
        Docx,
        [EnumMember(Value = "pdf")]
        Pdf
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Shareeffect;

    public partial class WorkflowManagedActions
    {
        public ShareeffectActions Shareeffect(string connectionId) => new ShareeffectActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ShareeffectTriggers Shareeffect(string connectionId) => new ShareeffectTriggers(connectionId);
    }
}