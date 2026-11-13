//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ebms
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EbmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebms")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateProduct(Expression<Func<CreateProductBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/INVENTRY";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebms")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> UpdateProduct(Expression<Func<string>> productId, Expression<Func<UpdateProductBodyInput>> body = null)
        {
            var __workflow_productId = WorkflowExpression.Compile(productId, nameof(productId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/INVENTRY(ID='{0}')", __workflow_productId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class EbmsTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateProductBodyInput
    {
        public CreateProductBodyInput(string treeId)
        {
            this.TreeId = treeId;
        }

        [JsonProperty("ID")]
        public string Id { get; set; }

        [JsonProperty("TREE_ID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TreeId { get; set; }

        [JsonProperty("C_TYPE")]
        public double? CType { get; set; }

        [JsonProperty("DESCR_1")]
        public string Descr1 { get; set; }

        [JsonProperty("DESCR_2")]
        public string Descr2 { get; set; }

        [JsonProperty("DESCR_3")]
        public string Descr3 { get; set; }

        [JsonProperty("TYPE")]
        public string Type { get; set; }

        [JsonProperty("MEMO")]
        public string Memo { get; set; }

        [JsonProperty("UPC")]
        public string Upc { get; set; }

        [JsonProperty("MFG")]
        public string Mfg { get; set; }

        [JsonProperty("MFG_PART")]
        public string MfgPart { get; set; }

        [JsonProperty("PRI_VENDOR")]
        public string PriVendor { get; set; }

        [JsonProperty("EACH_UNIT")]
        public string EachUnit { get; set; }

        [JsonProperty("WEIGHT")]
        public double? Weight { get; set; }

        [JsonProperty("COST")]
        public double? Cost { get; set; }

        [JsonProperty("BASE")]
        public double? Base { get; set; }

        [JsonProperty("EXTERNALID")]
        public string Externalid { get; set; }
    }

    public class UpdateProductBodyInput
    {
        [JsonProperty("DESCR_1")]
        public string Descr1 { get; set; }

        [JsonProperty("DESCR_2")]
        public string Descr2 { get; set; }

        [JsonProperty("DESCR_3")]
        public string Descr3 { get; set; }

        [JsonProperty("TYPE")]
        public string Type { get; set; }

        [JsonProperty("MEMO")]
        public string Memo { get; set; }

        [JsonProperty("UPC")]
        public string Upc { get; set; }

        [JsonProperty("MFG")]
        public string Mfg { get; set; }

        [JsonProperty("MFG_PART")]
        public string MfgPart { get; set; }

        [JsonProperty("PRI_VENDOR")]
        public string PriVendor { get; set; }

        [JsonProperty("EACH_UNIT")]
        public string EachUnit { get; set; }

        [JsonProperty("WEIGHT")]
        public double? Weight { get; set; }

        [JsonProperty("COST")]
        public double? Cost { get; set; }

        [JsonProperty("BASE")]
        public double? Base { get; set; }

        [JsonProperty("EXTERNALID")]
        public string Externalid { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ebms;

    public partial class WorkflowManagedActions
    {
        public EbmsActions Ebms(string connectionId) => new EbmsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EbmsTriggers Ebms(string connectionId) => new EbmsTriggers(connectionId);
    }
}