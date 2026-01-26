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
        public IBodyWorkflowAction<AddUpdateTermResponse> AddUpdateTerm(Expression<Func<bool>> bodyisavailable, Expression<Func<string>> bodytermlabel, Expression<Func<string>> bodytermsgroup, Expression<Func<string>> bodytermsset, Expression<Func<string>> bodyotherlabels = null, Expression<Func<string>> bodyparentterm = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shareeffect")]
        public IBodyWorkflowAction<AddUpdateTermByKeyValueResponse> AddUpdateTermByKeyValue(Expression<Func<bool>> bodyisavailable, Expression<Func<string>> bodykeyvalue, Expression<Func<string>> bodytermlabel, Expression<Func<string>> bodytermsgroup, Expression<Func<string>> bodytermsset, Expression<Func<string>> bodyotherlabels = null, Expression<Func<string>> bodyparentterm = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shareeffect")]
        public IBodyWorkflowAction<GetTermByKeyValueResponseItem[]> GetTermByKeyValue(Expression<Func<string>> searchValue)
        {
            var apiCallPath = "/GetTermsByProperty";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["searchProperty"] = Convert.ToString("KeyValue");
            callPayload.Queries["searchValue"] = ExpressionConverter.Convert(searchValue);
            return new ApiConnectionAction<GetTermByKeyValueResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shareeffect")]
        public IBodyWorkflowAction<GetTermByLabelResponseItem[]> GetTermByLabel(Expression<Func<string>> searchValue)
        {
            var apiCallPath = "/GetTermsByTermLabel";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["searchValue"] = ExpressionConverter.Convert(searchValue);
            return new ApiConnectionAction<GetTermByLabelResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shareeffect")]
        public IBodyWorkflowAction<UploadTemplateResponse> UploadTemplate(Expression<Func<string>> bodytemplateId, Expression<Func<string>> bodytemplate)
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