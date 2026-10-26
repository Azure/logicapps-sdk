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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateProduct(Expression<Func<CreateProductInput>> body)
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> UpdateProduct(Expression<Func<string>> productId, Expression<Func<UpdateProductInput>> body = null)
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

    public class CreateProductInput
    {
        [JsonProperty("ID")]
        public string Id { get; set; }

        [JsonProperty("TREE_ID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TREEId { get; set; }

        [JsonProperty("C_TYPE")]
        public double? CTYPE { get; set; }

        [JsonProperty("DESCR_1")]
        public string DESCR1 { get; set; }

        [JsonProperty("DESCR_2")]
        public string DESCR2 { get; set; }

        [JsonProperty("DESCR_3")]
        public string DESCR3 { get; set; }
        public string TYPE { get; set; }
        public string MEMO { get; set; }
        public string UPC { get; set; }
        public string MFG { get; set; }

        [JsonProperty("MFG_PART")]
        public string MFGPART { get; set; }

        [JsonProperty("PRI_VENDOR")]
        public string PRIVENDOR { get; set; }

        [JsonProperty("EACH_UNIT")]
        public string EACHUNIT { get; set; }
        public double? WEIGHT { get; set; }
        public double? COST { get; set; }
        public double? BASE { get; set; }

        [JsonProperty("EXTERNALID")]
        public string EXTERNALId { get; set; }
    }

    public class UpdateProductInput
    {
        [JsonProperty("DESCR_1")]
        public string DESCR1 { get; set; }

        [JsonProperty("DESCR_2")]
        public string DESCR2 { get; set; }

        [JsonProperty("DESCR_3")]
        public string DESCR3 { get; set; }
        public string TYPE { get; set; }
        public string MEMO { get; set; }
        public string UPC { get; set; }
        public string MFG { get; set; }

        [JsonProperty("MFG_PART")]
        public string MFGPART { get; set; }

        [JsonProperty("PRI_VENDOR")]
        public string PRIVENDOR { get; set; }

        [JsonProperty("EACH_UNIT")]
        public string EACHUNIT { get; set; }
        public double? WEIGHT { get; set; }
        public double? COST { get; set; }
        public double? BASE { get; set; }

        [JsonProperty("EXTERNALID")]
        public string EXTERNALId { get; set; }
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