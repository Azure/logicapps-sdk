//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shareeffect
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ShareeffectActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shareeffect")]
        [WorkflowExpressionFactory(nameof(__BuildAddUpdateTerm))]
        public IBodyWorkflowAction<AddUpdateTermResponse> AddUpdateTerm([WorkflowExpression] Func<bool> bodyisavailable, [WorkflowExpression] Func<string> bodytermlabel, [WorkflowExpression] Func<string> bodytermsgroup, [WorkflowExpression] Func<string> bodytermsset, [WorkflowExpression] Func<string> bodyotherlabels = null, [WorkflowExpression] Func<string> bodyparentterm = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddUpdateTermResponse> __BuildAddUpdateTerm(WorkflowExpression<bool> bodyisavailable, WorkflowExpression<string> bodytermlabel, WorkflowExpression<string> bodytermsgroup, WorkflowExpression<string> bodytermsset, WorkflowExpression<string> bodyotherlabels = null, WorkflowExpression<string> bodyparentterm = null)
        {
            WorkflowExpression.Validate(bodyisavailable, nameof(bodyisavailable), required: true);
            WorkflowExpression.Validate(bodytermlabel, nameof(bodytermlabel), required: true);
            WorkflowExpression.Validate(bodytermsgroup, nameof(bodytermsgroup), required: true);
            WorkflowExpression.Validate(bodytermsset, nameof(bodytermsset), required: true);
            WorkflowExpression.Validate(bodyotherlabels, nameof(bodyotherlabels), required: false);
            WorkflowExpression.Validate(bodyparentterm, nameof(bodyparentterm), required: false);
            return new DeferredBodyAction<AddUpdateTermResponse>(() =>
            {
                var apiCallPath = "/AddUpdateTerm";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["isavailable"] = ExpressionConverter.ConvertO(bodyisavailable);
                if (bodyotherlabels != null)
                {
                    body["otherlabels"] = ExpressionConverter.ConvertO(bodyotherlabels);
                    bodypropCount++;
                }

                if (bodyparentterm != null)
                {
                    body["parentterm"] = ExpressionConverter.ConvertO(bodyparentterm);
                    bodypropCount++;
                }

                bodypropCount++;
                body["termlabel"] = ExpressionConverter.ConvertO(bodytermlabel);
                bodypropCount++;
                body["termsgroup"] = ExpressionConverter.ConvertO(bodytermsgroup);
                bodypropCount++;
                body["termsset"] = ExpressionConverter.ConvertO(bodytermsset);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddUpdateTermResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shareeffect")]
        [WorkflowExpressionFactory(nameof(__BuildAddUpdateTermByKeyValue))]
        public IBodyWorkflowAction<AddUpdateTermByKeyValueResponse> AddUpdateTermByKeyValue([WorkflowExpression] Func<bool> bodyisavailable, [WorkflowExpression] Func<string> bodykeyvalue, [WorkflowExpression] Func<string> bodytermlabel, [WorkflowExpression] Func<string> bodytermsgroup, [WorkflowExpression] Func<string> bodytermsset, [WorkflowExpression] Func<string> bodyotherlabels = null, [WorkflowExpression] Func<string> bodyparentterm = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddUpdateTermByKeyValueResponse> __BuildAddUpdateTermByKeyValue(WorkflowExpression<bool> bodyisavailable, WorkflowExpression<string> bodykeyvalue, WorkflowExpression<string> bodytermlabel, WorkflowExpression<string> bodytermsgroup, WorkflowExpression<string> bodytermsset, WorkflowExpression<string> bodyotherlabels = null, WorkflowExpression<string> bodyparentterm = null)
        {
            WorkflowExpression.Validate(bodyisavailable, nameof(bodyisavailable), required: true);
            WorkflowExpression.Validate(bodykeyvalue, nameof(bodykeyvalue), required: true);
            WorkflowExpression.Validate(bodytermlabel, nameof(bodytermlabel), required: true);
            WorkflowExpression.Validate(bodytermsgroup, nameof(bodytermsgroup), required: true);
            WorkflowExpression.Validate(bodytermsset, nameof(bodytermsset), required: true);
            WorkflowExpression.Validate(bodyotherlabels, nameof(bodyotherlabels), required: false);
            WorkflowExpression.Validate(bodyparentterm, nameof(bodyparentterm), required: false);
            return new DeferredBodyAction<AddUpdateTermByKeyValueResponse>(() =>
            {
                var apiCallPath = "/AddUpdateTermByKeyvalue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["isavailable"] = ExpressionConverter.ConvertO(bodyisavailable);
                bodypropCount++;
                body["keyvalue"] = ExpressionConverter.ConvertO(bodykeyvalue);
                if (bodyotherlabels != null)
                {
                    body["otherlabels"] = ExpressionConverter.ConvertO(bodyotherlabels);
                    bodypropCount++;
                }

                if (bodyparentterm != null)
                {
                    body["parentterm"] = ExpressionConverter.ConvertO(bodyparentterm);
                    bodypropCount++;
                }

                bodypropCount++;
                body["termlabel"] = ExpressionConverter.ConvertO(bodytermlabel);
                bodypropCount++;
                body["termsgroup"] = ExpressionConverter.ConvertO(bodytermsgroup);
                bodypropCount++;
                body["termsset"] = ExpressionConverter.ConvertO(bodytermsset);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddUpdateTermByKeyValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shareeffect")]
        [WorkflowExpressionFactory(nameof(__BuildGetTermByKeyValue))]
        public IBodyWorkflowAction<GetTermByKeyValueResponseItem[]> GetTermByKeyValue([WorkflowExpression] Func<string> searchValue)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTermByKeyValueResponseItem[]> __BuildGetTermByKeyValue(WorkflowExpression<string> searchValue)
        {
            WorkflowExpression.Validate(searchValue, nameof(searchValue), required: true);
            return new DeferredBodyAction<GetTermByKeyValueResponseItem[]>(() =>
            {
                var apiCallPath = "/GetTermsByProperty";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchProperty"] = Convert.ToString("KeyValue");
                callPayload.Queries["searchValue"] = ExpressionConverter.Convert(searchValue);
                return new ApiConnectionAction<GetTermByKeyValueResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shareeffect")]
        [WorkflowExpressionFactory(nameof(__BuildGetTermByLabel))]
        public IBodyWorkflowAction<GetTermByLabelResponseItem[]> GetTermByLabel([WorkflowExpression] Func<string> searchValue)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTermByLabelResponseItem[]> __BuildGetTermByLabel(WorkflowExpression<string> searchValue)
        {
            WorkflowExpression.Validate(searchValue, nameof(searchValue), required: true);
            return new DeferredBodyAction<GetTermByLabelResponseItem[]>(() =>
            {
                var apiCallPath = "/GetTermsByTermLabel";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchValue"] = ExpressionConverter.Convert(searchValue);
                return new ApiConnectionAction<GetTermByLabelResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shareeffect")]
        [WorkflowExpressionFactory(nameof(__BuildUploadTemplate))]
        public IBodyWorkflowAction<UploadTemplateResponse> UploadTemplate([WorkflowExpression] Func<string> bodytemplateId, [WorkflowExpression] Func<string> bodytemplate)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadTemplateResponse> __BuildUploadTemplate(WorkflowExpression<string> bodytemplateId, WorkflowExpression<string> bodytemplate)
        {
            WorkflowExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: true);
            WorkflowExpression.Validate(bodytemplate, nameof(bodytemplate), required: true);
            return new DeferredBodyAction<UploadTemplateResponse>(() =>
            {
                var apiCallPath = "/uploadtemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["templateId"] = ExpressionConverter.ConvertO(bodytemplateId);
                bodypropCount++;
                body["template"] = ExpressionConverter.ConvertO(bodytemplate);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UploadTemplateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shareeffect")]
        [WorkflowExpressionFactory(nameof(__BuildGenerateDocument))]
        public IBodyWorkflowAction<GenerateDocumentResponse> GenerateDocument([WorkflowExpression] Func<string> bodytemplateId, [WorkflowExpression] Func<bodyoutputformatInput> bodyoutputformat)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GenerateDocumentResponse> __BuildGenerateDocument(WorkflowExpression<string> bodytemplateId, WorkflowExpression<bodyoutputformatInput> bodyoutputformat)
        {
            WorkflowExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: true);
            WorkflowExpression.Validate(bodyoutputformat, nameof(bodyoutputformat), required: true);
            return new DeferredBodyAction<GenerateDocumentResponse>(() =>
            {
                var apiCallPath = "/GenerateDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["templateId"] = ExpressionConverter.ConvertO(bodytemplateId);
                bodypropCount++;
                body["outputformat"] = ExpressionConverter.ConvertO(bodyoutputformat);
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