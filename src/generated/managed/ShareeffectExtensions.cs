//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shareeffect
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ShareeffectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shareeffect")]
        public IBodyWorkflowAction<AddUpdateTermResponse> AddUpdateTerm([WorkflowExpression] Func<bool> bodyisavailable, [WorkflowExpression] Func<string> bodytermlabel, [WorkflowExpression] Func<string> bodytermsgroup, [WorkflowExpression] Func<string> bodytermsset, [WorkflowExpression] Func<string> bodyotherlabels = null, [WorkflowExpression] Func<string> bodyparentterm = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/AddUpdateTerm";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["isavailable"] = SourceExpressionConverter.ConvertToken(bodyisavailable);
                if (bodyotherlabels != null)
                {
                    body["otherlabels"] = SourceExpressionConverter.ConvertToken(bodyotherlabels);
                    bodypropCount++;
                }

                if (bodyparentterm != null)
                {
                    body["parentterm"] = SourceExpressionConverter.ConvertToken(bodyparentterm);
                    bodypropCount++;
                }

                bodypropCount++;
                body["termlabel"] = SourceExpressionConverter.ConvertToken(bodytermlabel);
                bodypropCount++;
                body["termsgroup"] = SourceExpressionConverter.ConvertToken(bodytermsgroup);
                bodypropCount++;
                body["termsset"] = SourceExpressionConverter.ConvertToken(bodytermsset);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddUpdateTermResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shareeffect")]
        public IBodyWorkflowAction<AddUpdateTermByKeyValueResponse> AddUpdateTermByKeyValue([WorkflowExpression] Func<bool> bodyisavailable, [WorkflowExpression] Func<string> bodykeyvalue, [WorkflowExpression] Func<string> bodytermlabel, [WorkflowExpression] Func<string> bodytermsgroup, [WorkflowExpression] Func<string> bodytermsset, [WorkflowExpression] Func<string> bodyotherlabels = null, [WorkflowExpression] Func<string> bodyparentterm = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/AddUpdateTermByKeyvalue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["isavailable"] = SourceExpressionConverter.ConvertToken(bodyisavailable);
                bodypropCount++;
                body["keyvalue"] = SourceExpressionConverter.ConvertToken(bodykeyvalue);
                if (bodyotherlabels != null)
                {
                    body["otherlabels"] = SourceExpressionConverter.ConvertToken(bodyotherlabels);
                    bodypropCount++;
                }

                if (bodyparentterm != null)
                {
                    body["parentterm"] = SourceExpressionConverter.ConvertToken(bodyparentterm);
                    bodypropCount++;
                }

                bodypropCount++;
                body["termlabel"] = SourceExpressionConverter.ConvertToken(bodytermlabel);
                bodypropCount++;
                body["termsgroup"] = SourceExpressionConverter.ConvertToken(bodytermsgroup);
                bodypropCount++;
                body["termsset"] = SourceExpressionConverter.ConvertToken(bodytermsset);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddUpdateTermByKeyValueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shareeffect")]
        public IBodyWorkflowAction<GetTermByKeyValueResponseItem[]> GetTermByKeyValue([WorkflowExpression] Func<string> searchValue)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetTermsByProperty";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchProperty"] = Convert.ToString("KeyValue");
                callPayload.Queries["searchValue"] = SourceExpressionConverter.ConvertO(searchValue);
                return callPayload;
            }

            return new ApiConnectionAction<GetTermByKeyValueResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shareeffect")]
        public IBodyWorkflowAction<GetTermByLabelResponseItem[]> GetTermByLabel([WorkflowExpression] Func<string> searchValue)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GetTermsByTermLabel";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchValue"] = SourceExpressionConverter.ConvertO(searchValue);
                return callPayload;
            }

            return new ApiConnectionAction<GetTermByLabelResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shareeffect")]
        public IBodyWorkflowAction<UploadTemplateResponse> UploadTemplate([WorkflowExpression] Func<string> bodytemplateId, [WorkflowExpression] Func<string> bodytemplate)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/uploadtemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["templateId"] = SourceExpressionConverter.ConvertToken(bodytemplateId);
                bodypropCount++;
                body["template"] = SourceExpressionConverter.ConvertToken(bodytemplate);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UploadTemplateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shareeffect")]
        public IBodyWorkflowAction<GenerateDocumentResponse> GenerateDocument([WorkflowExpression] Func<string> bodytemplateId, [WorkflowExpression] Func<bodyoutputformatInput> bodyoutputformat)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/GenerateDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["templateId"] = SourceExpressionConverter.ConvertToken(bodytemplateId);
                bodypropCount++;
                body["outputformat"] = SourceExpressionConverter.Convert(bodyoutputformat);
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
                return callPayload;
            }

            return new ApiConnectionAction<GenerateDocumentResponse>(BuildSourceInput);
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