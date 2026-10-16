//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shareeffect
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ShareeffectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shareeffect")]
        public IBodyWorkflowAction<AddUpdateTermResponse> AddUpdateTerm(Expression<Func<bool>> bodyisavailable, Expression<Func<string>> bodytermlabel, Expression<Func<string>> bodytermsgroup, Expression<Func<string>> bodytermsset, Expression<Func<string>> bodyotherlabels = null, Expression<Func<string>> bodyparentterm = null)
        {
            var __workflow_bodyisavailable = WorkflowExpression.Compile(bodyisavailable, nameof(bodyisavailable), required: true);
            var __workflow_bodytermlabel = WorkflowExpression.Compile(bodytermlabel, nameof(bodytermlabel), required: true);
            var __workflow_bodytermsgroup = WorkflowExpression.Compile(bodytermsgroup, nameof(bodytermsgroup), required: true);
            var __workflow_bodytermsset = WorkflowExpression.Compile(bodytermsset, nameof(bodytermsset), required: true);
            var __workflow_bodyotherlabels = WorkflowExpression.Compile(bodyotherlabels, nameof(bodyotherlabels), required: false);
            var __workflow_bodyparentterm = WorkflowExpression.Compile(bodyparentterm, nameof(bodyparentterm), required: false);
            return new DeferredBodyAction<AddUpdateTermResponse>(() =>
            {
                var apiCallPath = "/AddUpdateTerm";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["isavailable"] = ExpressionConverter.ConvertO(__workflow_bodyisavailable);
                if (__workflow_bodyotherlabels != null)
                {
                    body["otherlabels"] = ExpressionConverter.ConvertO(__workflow_bodyotherlabels);
                    bodypropCount++;
                }

                if (__workflow_bodyparentterm != null)
                {
                    body["parentterm"] = ExpressionConverter.ConvertO(__workflow_bodyparentterm);
                    bodypropCount++;
                }

                bodypropCount++;
                body["termlabel"] = ExpressionConverter.ConvertO(__workflow_bodytermlabel);
                bodypropCount++;
                body["termsgroup"] = ExpressionConverter.ConvertO(__workflow_bodytermsgroup);
                bodypropCount++;
                body["termsset"] = ExpressionConverter.ConvertO(__workflow_bodytermsset);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddUpdateTermResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shareeffect")]
        public IBodyWorkflowAction<AddUpdateTermByKeyValueResponse> AddUpdateTermByKeyValue(Expression<Func<bool>> bodyisavailable, Expression<Func<string>> bodykeyvalue, Expression<Func<string>> bodytermlabel, Expression<Func<string>> bodytermsgroup, Expression<Func<string>> bodytermsset, Expression<Func<string>> bodyotherlabels = null, Expression<Func<string>> bodyparentterm = null)
        {
            var __workflow_bodyisavailable = WorkflowExpression.Compile(bodyisavailable, nameof(bodyisavailable), required: true);
            var __workflow_bodykeyvalue = WorkflowExpression.Compile(bodykeyvalue, nameof(bodykeyvalue), required: true);
            var __workflow_bodytermlabel = WorkflowExpression.Compile(bodytermlabel, nameof(bodytermlabel), required: true);
            var __workflow_bodytermsgroup = WorkflowExpression.Compile(bodytermsgroup, nameof(bodytermsgroup), required: true);
            var __workflow_bodytermsset = WorkflowExpression.Compile(bodytermsset, nameof(bodytermsset), required: true);
            var __workflow_bodyotherlabels = WorkflowExpression.Compile(bodyotherlabels, nameof(bodyotherlabels), required: false);
            var __workflow_bodyparentterm = WorkflowExpression.Compile(bodyparentterm, nameof(bodyparentterm), required: false);
            return new DeferredBodyAction<AddUpdateTermByKeyValueResponse>(() =>
            {
                var apiCallPath = "/AddUpdateTermByKeyvalue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["isavailable"] = ExpressionConverter.ConvertO(__workflow_bodyisavailable);
                bodypropCount++;
                body["keyvalue"] = ExpressionConverter.ConvertO(__workflow_bodykeyvalue);
                if (__workflow_bodyotherlabels != null)
                {
                    body["otherlabels"] = ExpressionConverter.ConvertO(__workflow_bodyotherlabels);
                    bodypropCount++;
                }

                if (__workflow_bodyparentterm != null)
                {
                    body["parentterm"] = ExpressionConverter.ConvertO(__workflow_bodyparentterm);
                    bodypropCount++;
                }

                bodypropCount++;
                body["termlabel"] = ExpressionConverter.ConvertO(__workflow_bodytermlabel);
                bodypropCount++;
                body["termsgroup"] = ExpressionConverter.ConvertO(__workflow_bodytermsgroup);
                bodypropCount++;
                body["termsset"] = ExpressionConverter.ConvertO(__workflow_bodytermsset);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddUpdateTermByKeyValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shareeffect")]
        public IBodyWorkflowAction<GetTermByKeyValueResponseItem[]> GetTermByKeyValue(Expression<Func<string>> searchValue)
        {
            var __workflow_searchValue = WorkflowExpression.Compile(searchValue, nameof(searchValue), required: true);
            return new DeferredBodyAction<GetTermByKeyValueResponseItem[]>(() =>
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
        public IBodyWorkflowAction<GetTermByLabelResponseItem[]> GetTermByLabel(Expression<Func<string>> searchValue)
        {
            var __workflow_searchValue = WorkflowExpression.Compile(searchValue, nameof(searchValue), required: true);
            return new DeferredBodyAction<GetTermByLabelResponseItem[]>(() =>
            {
                var apiCallPath = "/GetTermsByTermLabel";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchValue"] = ExpressionConverter.Convert(__workflow_searchValue);
                return new ApiConnectionAction<GetTermByLabelResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shareeffect")]
        public IBodyWorkflowAction<UploadTemplateResponse> UploadTemplate(Expression<Func<string>> bodytemplateId, Expression<Func<string>> bodytemplate)
        {
            var __workflow_bodytemplateId = WorkflowExpression.Compile(bodytemplateId, nameof(bodytemplateId), required: true);
            var __workflow_bodytemplate = WorkflowExpression.Compile(bodytemplate, nameof(bodytemplate), required: true);
            return new DeferredBodyAction<UploadTemplateResponse>(() =>
            {
                var apiCallPath = "/uploadtemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["templateId"] = ExpressionConverter.ConvertO(__workflow_bodytemplateId);
                bodypropCount++;
                body["template"] = ExpressionConverter.ConvertO(__workflow_bodytemplate);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UploadTemplateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shareeffect")]
        public IBodyWorkflowAction<GenerateDocumentResponse> GenerateDocument(Expression<Func<string>> bodytemplateId, Expression<Func<bodyoutputformatInput>> bodyoutputformat)
        {
            var __workflow_bodytemplateId = WorkflowExpression.Compile(bodytemplateId, nameof(bodytemplateId), required: true);
            var __workflow_bodyoutputformat = WorkflowExpression.Compile(bodyoutputformat, nameof(bodyoutputformat), required: true);
            return new DeferredBodyAction<GenerateDocumentResponse>(() =>
            {
                var apiCallPath = "/GenerateDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["templateId"] = ExpressionConverter.ConvertO(__workflow_bodytemplateId);
                bodypropCount++;
                body["outputformat"] = ExpressionConverter.ConvertO(__workflow_bodyoutputformat);
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (propertiesObjectpropCount > 0)
                {
                    body["properties"] = propertiesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    public class AddUpdateTermByKeyValueResponse
    {
        public string Result { get; set; }
        public string Termid { get; set; }
        public string Term { get; set; }
        public string LicenseExpires { get; set; }
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

    public class GenerateDocumentResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyoutputformatInput
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
