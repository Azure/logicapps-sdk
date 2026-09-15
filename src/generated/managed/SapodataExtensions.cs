//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sapodata
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SapodataActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sapodata")]
        public IBodyWorkflowAction<Output> GetEntityData(Expression<Func<string>> entity, Expression<Func<string>> relativePath = null, Expression<Func<double>> top = null, Expression<Func<double>> skip = null, Expression<Func<string>> select = null, Expression<Func<string>> filter = null, Expression<Func<string>> expand = null, Expression<Func<string>> orderby = null, Expression<Func<string>> search = null, Expression<Func<inlinecountInput>> inlinecount = null)
        {
            var apiCallPath = "/getentitydata";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["entity"] = CSharpExpressionConverter.ConvertO(entity);
            callPayload.Queries["relativePath"] = Convert.ToString("/");
            if (relativePath != null)
                callPayload.Queries["relativePath"] = CSharpExpressionConverter.ConvertO(relativePath);
            if (top != null)
                callPayload.Queries["top"] = CSharpExpressionConverter.ConvertO(top);
            if (skip != null)
                callPayload.Queries["skip"] = CSharpExpressionConverter.ConvertO(skip);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            if (filter != null)
                callPayload.Queries["filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (expand != null)
                callPayload.Queries["expand"] = CSharpExpressionConverter.ConvertO(expand);
            if (orderby != null)
                callPayload.Queries["orderby"] = CSharpExpressionConverter.ConvertO(orderby);
            if (search != null)
                callPayload.Queries["search"] = CSharpExpressionConverter.ConvertO(search);
            if (inlinecount != null)
                callPayload.Queries["inlinecount"] = CSharpExpressionConverter.Convert(inlinecount);
            return new ApiConnectionAction<Output>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sapodata")]
        public IBodyWorkflowAction<JToken> GetEntry(Expression<Func<string>> entity, Expression<Func<object>> entryInput = null, Expression<Func<string>> relativePath = null, Expression<Func<double>> top = null, Expression<Func<double>> skip = null, Expression<Func<string>> select = null, Expression<Func<string>> filter = null, Expression<Func<string>> expand = null, Expression<Func<string>> orderby = null, Expression<Func<string>> search = null, Expression<Func<inlinecountInput>> inlinecount = null)
        {
            var apiCallPath = "/getentry";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["entity"] = CSharpExpressionConverter.ConvertO(entity);
            callPayload.Queries["relativePath"] = Convert.ToString("/");
            if (relativePath != null)
                callPayload.Queries["relativePath"] = CSharpExpressionConverter.ConvertO(relativePath);
            if (top != null)
                callPayload.Queries["top"] = CSharpExpressionConverter.ConvertO(top);
            if (skip != null)
                callPayload.Queries["skip"] = CSharpExpressionConverter.ConvertO(skip);
            if (select != null)
                callPayload.Queries["select"] = CSharpExpressionConverter.ConvertO(select);
            if (filter != null)
                callPayload.Queries["filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (expand != null)
                callPayload.Queries["expand"] = CSharpExpressionConverter.ConvertO(expand);
            if (orderby != null)
                callPayload.Queries["orderby"] = CSharpExpressionConverter.ConvertO(orderby);
            if (search != null)
                callPayload.Queries["search"] = CSharpExpressionConverter.ConvertO(search);
            if (inlinecount != null)
                callPayload.Queries["inlinecount"] = CSharpExpressionConverter.Convert(inlinecount);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(entryInput);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sapodata")]
        public IBodyWorkflowAction<JToken> CreateEntry(Expression<Func<string>> entity, Expression<Func<object>> entryInput = null, Expression<Func<string>> relativePath = null)
        {
            var apiCallPath = "/createentry";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["entity"] = CSharpExpressionConverter.ConvertO(entity);
            callPayload.Queries["relativePath"] = Convert.ToString("/");
            if (relativePath != null)
                callPayload.Queries["relativePath"] = CSharpExpressionConverter.ConvertO(relativePath);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(entryInput);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sapodata")]
        public IBodyWorkflowAction<JToken> UpdateEntry(Expression<Func<string>> entity, Expression<Func<object>> entryInput = null, Expression<Func<string>> relativePath = null)
        {
            var apiCallPath = "/updateentry";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["entity"] = CSharpExpressionConverter.ConvertO(entity);
            callPayload.Queries["relativePath"] = Convert.ToString("/");
            if (relativePath != null)
                callPayload.Queries["relativePath"] = CSharpExpressionConverter.ConvertO(relativePath);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(entryInput);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sapodata")]
        public IBodyWorkflowAction<AdHocRequestResponse> AdHocRequest(Expression<Func<string>> relativePath, Expression<Func<entryInputhttpMethodInput>> entryInputhttpMethod, Expression<Func<bool>> bypassMetadata = null)
        {
            var apiCallPath = "/adhoc";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["relativePath"] = CSharpExpressionConverter.ConvertO(relativePath);
            callPayload.Queries["bypassMetadata"] = Convert.ToString(false);
            if (bypassMetadata != null)
                callPayload.Queries["bypassMetadata"] = CSharpExpressionConverter.ConvertO(bypassMetadata);
            var entryInput = new JObject();
            var entryInputpropCount = 0;
            entryInputpropCount++;
            entryInput["httpMethod"] = CSharpExpressionConverter.Convert(entryInputhttpMethod);
            var queryStringObject = new JObject();
            var queryStringObjectpropCount = 0;
            if (queryStringObjectpropCount > 0)
            {
                entryInput["queryString"] = queryStringObject;
                entryInputpropCount++;
            }

            var payloadObject = new JObject();
            var payloadObjectpropCount = 0;
            if (payloadObjectpropCount > 0)
            {
                entryInput["payload"] = payloadObject;
                entryInputpropCount++;
            }

            if (entryInputpropCount > 0)
            {
                callPayload.Body = entryInput;
            }

            return new ApiConnectionAction<AdHocRequestResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sapodata")]
        public IBodyWorkflowAction<AdHocBulkRequestResponse> AdHocBulkRequest(Expression<Func<string>> relativePath, Expression<Func<entryInputhttpMethodInput>> entryInputhttpMethod, Expression<Func<JToken[]>> entryInputpayload = null, Expression<Func<bool>> bypassMetadata = null)
        {
            var apiCallPath = "/adhocBulk";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["relativePath"] = CSharpExpressionConverter.ConvertO(relativePath);
            callPayload.Queries["bypassMetadata"] = Convert.ToString(false);
            if (bypassMetadata != null)
                callPayload.Queries["bypassMetadata"] = CSharpExpressionConverter.ConvertO(bypassMetadata);
            var entryInput = new JObject();
            var entryInputpropCount = 0;
            entryInputpropCount++;
            entryInput["httpMethod"] = CSharpExpressionConverter.Convert(entryInputhttpMethod);
            var queryStringObject = new JObject();
            var queryStringObjectpropCount = 0;
            if (queryStringObjectpropCount > 0)
            {
                entryInput["queryString"] = queryStringObject;
                entryInputpropCount++;
            }

            if (entryInputpayload != null)
            {
                entryInput["payload"] = CSharpExpressionConverter.ConvertToken(entryInputpayload);
                entryInputpropCount++;
            }

            if (entryInputpropCount > 0)
            {
                callPayload.Body = entryInput;
            }

            return new ApiConnectionAction<AdHocBulkRequestResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sapodata")]
        public IBodyWorkflowAction<JToken> DeleteEntry(Expression<Func<string>> entity, Expression<Func<object>> entryInput = null, Expression<Func<string>> relativePath = null)
        {
            var apiCallPath = "/deleteentry";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["entity"] = CSharpExpressionConverter.ConvertO(entity);
            callPayload.Queries["relativePath"] = Convert.ToString("/");
            if (relativePath != null)
                callPayload.Queries["relativePath"] = CSharpExpressionConverter.ConvertO(relativePath);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(entryInput);
            return new ApiConnectionAction<JToken>(callPayload);
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

    public enum entryInputhttpMethodInput
    {
        GET,
        POST,
        DELETE,
        PUT
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