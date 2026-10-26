//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sapodata
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SapodataActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sapodata")]
        public IBodyWorkflowAction<Output, ApiConnectionActionConfiguration> GetEntityData(Expression<Func<string>> entity, Expression<Func<string>> relativePath = null, Expression<Func<double>> top = null, Expression<Func<double>> skip = null, Expression<Func<string>> select = null, Expression<Func<string>> filter = null, Expression<Func<string>> expand = null, Expression<Func<string>> orderby = null, Expression<Func<string>> search = null, Expression<Func<inlinecountInput>> inlinecount = null)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_relativePath = WorkflowExpression.Compile(relativePath, nameof(relativePath), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_inlinecount = WorkflowExpression.Compile(inlinecount, nameof(inlinecount), required: false);
            return new DeferredBodyAction<Output, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getentitydata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["entity"] = ExpressionConverter.Convert(__workflow_entity);
                callPayload.Queries["relativePath"] = Convert.ToString("/");
                if (__workflow_relativePath != null)
                    callPayload.Queries["relativePath"] = ExpressionConverter.Convert(__workflow_relativePath);
                if (__workflow_top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_expand != null)
                    callPayload.Queries["expand"] = ExpressionConverter.Convert(__workflow_expand);
                if (__workflow_orderby != null)
                    callPayload.Queries["orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_inlinecount != null)
                    callPayload.Queries["inlinecount"] = ExpressionConverter.Convert(__workflow_inlinecount);
                return new ApiConnectionAction<Output>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sapodata")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetEntry(Expression<Func<string>> entity, Expression<Func<object>> entryInput, Expression<Func<string>> relativePath = null, Expression<Func<double>> top = null, Expression<Func<double>> skip = null, Expression<Func<string>> select = null, Expression<Func<string>> filter = null, Expression<Func<string>> expand = null, Expression<Func<string>> orderby = null, Expression<Func<string>> search = null, Expression<Func<inlinecountInput>> inlinecount = null)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_entryInput = WorkflowExpression.Compile(entryInput, nameof(entryInput), required: true);
            var __workflow_relativePath = WorkflowExpression.Compile(relativePath, nameof(relativePath), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_inlinecount = WorkflowExpression.Compile(inlinecount, nameof(inlinecount), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["entity"] = ExpressionConverter.Convert(__workflow_entity);
                callPayload.Queries["relativePath"] = Convert.ToString("/");
                if (__workflow_relativePath != null)
                    callPayload.Queries["relativePath"] = ExpressionConverter.Convert(__workflow_relativePath);
                if (__workflow_top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_expand != null)
                    callPayload.Queries["expand"] = ExpressionConverter.Convert(__workflow_expand);
                if (__workflow_orderby != null)
                    callPayload.Queries["orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_inlinecount != null)
                    callPayload.Queries["inlinecount"] = ExpressionConverter.Convert(__workflow_inlinecount);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_entryInput);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sapodata")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateEntry(Expression<Func<string>> entity, Expression<Func<object>> entryInput, Expression<Func<string>> relativePath = null)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_entryInput = WorkflowExpression.Compile(entryInput, nameof(entryInput), required: true);
            var __workflow_relativePath = WorkflowExpression.Compile(relativePath, nameof(relativePath), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/createentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["entity"] = ExpressionConverter.Convert(__workflow_entity);
                callPayload.Queries["relativePath"] = Convert.ToString("/");
                if (__workflow_relativePath != null)
                    callPayload.Queries["relativePath"] = ExpressionConverter.Convert(__workflow_relativePath);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_entryInput);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sapodata")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> UpdateEntry(Expression<Func<string>> entity, Expression<Func<object>> entryInput, Expression<Func<string>> relativePath = null)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_entryInput = WorkflowExpression.Compile(entryInput, nameof(entryInput), required: true);
            var __workflow_relativePath = WorkflowExpression.Compile(relativePath, nameof(relativePath), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/updateentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["entity"] = ExpressionConverter.Convert(__workflow_entity);
                callPayload.Queries["relativePath"] = Convert.ToString("/");
                if (__workflow_relativePath != null)
                    callPayload.Queries["relativePath"] = ExpressionConverter.Convert(__workflow_relativePath);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_entryInput);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sapodata")]
        public IBodyWorkflowAction<AdHocRequestResponse, ApiConnectionActionConfiguration> AdHocRequest(Expression<Func<string>> relativePath, Expression<Func<AdHocRequestInput>> entryInput, Expression<Func<bool>> bypassMetadata = null)
        {
            var __workflow_relativePath = WorkflowExpression.Compile(relativePath, nameof(relativePath), required: true);
            var __workflow_entryInput = WorkflowExpression.Compile(entryInput, nameof(entryInput), required: true);
            var __workflow_bypassMetadata = WorkflowExpression.Compile(bypassMetadata, nameof(bypassMetadata), required: false);
            return new DeferredBodyAction<AdHocRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/adhoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["relativePath"] = ExpressionConverter.Convert(__workflow_relativePath);
                callPayload.Queries["bypassMetadata"] = Convert.ToString(false);
                if (__workflow_bypassMetadata != null)
                    callPayload.Queries["bypassMetadata"] = ExpressionConverter.Convert(__workflow_bypassMetadata);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_entryInput);
                return new ApiConnectionAction<AdHocRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sapodata")]
        public IBodyWorkflowAction<AdHocBulkRequestResponse, ApiConnectionActionConfiguration> AdHocBulkRequest(Expression<Func<string>> relativePath, Expression<Func<AdHocBulkRequestInput>> entryInput, Expression<Func<bool>> bypassMetadata = null)
        {
            var __workflow_relativePath = WorkflowExpression.Compile(relativePath, nameof(relativePath), required: true);
            var __workflow_entryInput = WorkflowExpression.Compile(entryInput, nameof(entryInput), required: true);
            var __workflow_bypassMetadata = WorkflowExpression.Compile(bypassMetadata, nameof(bypassMetadata), required: false);
            return new DeferredBodyAction<AdHocBulkRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/adhocBulk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["relativePath"] = ExpressionConverter.Convert(__workflow_relativePath);
                callPayload.Queries["bypassMetadata"] = Convert.ToString(false);
                if (__workflow_bypassMetadata != null)
                    callPayload.Queries["bypassMetadata"] = ExpressionConverter.Convert(__workflow_bypassMetadata);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_entryInput);
                return new ApiConnectionAction<AdHocBulkRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sapodata")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DeleteEntry(Expression<Func<string>> entity, Expression<Func<object>> entryInput, Expression<Func<string>> relativePath = null)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_entryInput = WorkflowExpression.Compile(entryInput, nameof(entryInput), required: true);
            var __workflow_relativePath = WorkflowExpression.Compile(relativePath, nameof(relativePath), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/deleteentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["entity"] = ExpressionConverter.Convert(__workflow_entity);
                callPayload.Queries["relativePath"] = Convert.ToString("/");
                if (__workflow_relativePath != null)
                    callPayload.Queries["relativePath"] = ExpressionConverter.Convert(__workflow_relativePath);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_entryInput);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class SapodataTriggers([ConnectionName] string connectionId)
    {
    }

    public class Output
    {
        [JsonProperty("data")]
        public JToken[] Data { get; set; }

        [JsonProperty("count")]
        public double Count { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum inlinecountInput
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "allpages")]
        Allpages
    }

    public class AdHocRequestResponse
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("response")]
        public AdHocRequestResponseResponseType Response { get; set; }
    }

    public class AdHocRequestResponseResponseType
    {
        [JsonProperty("structured")]
        public JToken Structured { get; set; }

        [JsonProperty("unstructured")]
        public string Unstructured { get; set; }
    }

    public class AdHocRequestInput
    {
        [JsonProperty("httpMethod", DefaultValueHandling = DefaultValueHandling.Include)]
        public AdHocRequestInputHttpMethodType HttpMethod { get; set; }

        [JsonProperty("queryString")]
        public JToken QueryString { get; set; }

        [JsonProperty("payload")]
        public JToken Payload { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AdHocRequestInputHttpMethodType
    {
        GET,
        POST,
        DELETE,
        PUT,
        PATCH
    }

    public class AdHocBulkRequestResponse
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("response")]
        public AdHocBulkRequestResponseResponseType Response { get; set; }
    }

    public class AdHocBulkRequestResponseResponseType
    {
        [JsonProperty("structured")]
        public JToken Structured { get; set; }

        [JsonProperty("unstructured")]
        public string Unstructured { get; set; }
    }

    public class AdHocBulkRequestInput
    {
        [JsonProperty("httpMethod", DefaultValueHandling = DefaultValueHandling.Include)]
        public AdHocBulkRequestInputHttpMethodType HttpMethod { get; set; }

        [JsonProperty("queryString")]
        public JToken QueryString { get; set; }

        [JsonProperty("payload")]
        public JToken[] Payload { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AdHocBulkRequestInputHttpMethodType
    {
        GET,
        POST,
        DELETE,
        PUT
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sapodata;

    public partial class WorkflowManagedActions
    {
        public SapodataActions Sapodata(string connectionId) => new SapodataActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SapodataTriggers Sapodata(string connectionId) => new SapodataTriggers(connectionId);
    }
}