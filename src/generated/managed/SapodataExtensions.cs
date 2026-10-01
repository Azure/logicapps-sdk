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
        public IBodyWorkflowAction<Output> GetEntityData([WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<string> relativePath = null, [WorkflowExpression] Func<double> top = null, [WorkflowExpression] Func<double> skip = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<inlinecountInput> inlinecount = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getentitydata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["entity"] = SourceExpressionConverter.ConvertO(entity);
                callPayload.Queries["relativePath"] = Convert.ToString("/");
                if (relativePath != null)
                    callPayload.Queries["relativePath"] = SourceExpressionConverter.ConvertO(relativePath);
                if (top != null)
                    callPayload.Queries["top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["skip"] = SourceExpressionConverter.ConvertO(skip);
                if (select != null)
                    callPayload.Queries["select"] = SourceExpressionConverter.ConvertO(select);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (expand != null)
                    callPayload.Queries["expand"] = SourceExpressionConverter.ConvertO(expand);
                if (orderby != null)
                    callPayload.Queries["orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (inlinecount != null)
                    callPayload.Queries["inlinecount"] = SourceExpressionConverter.Convert(inlinecount);
                return callPayload;
            }

            return new ApiConnectionAction<Output>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sapodata")]
        public IBodyWorkflowAction<JToken> GetEntry([WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<object> entryInput = null, [WorkflowExpression] Func<string> relativePath = null, [WorkflowExpression] Func<double> top = null, [WorkflowExpression] Func<double> skip = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<inlinecountInput> inlinecount = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["entity"] = SourceExpressionConverter.ConvertO(entity);
                callPayload.Queries["relativePath"] = Convert.ToString("/");
                if (relativePath != null)
                    callPayload.Queries["relativePath"] = SourceExpressionConverter.ConvertO(relativePath);
                if (top != null)
                    callPayload.Queries["top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["skip"] = SourceExpressionConverter.ConvertO(skip);
                if (select != null)
                    callPayload.Queries["select"] = SourceExpressionConverter.ConvertO(select);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (expand != null)
                    callPayload.Queries["expand"] = SourceExpressionConverter.ConvertO(expand);
                if (orderby != null)
                    callPayload.Queries["orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (inlinecount != null)
                    callPayload.Queries["inlinecount"] = SourceExpressionConverter.Convert(inlinecount);
                callPayload.Body = SourceExpressionConverter.ConvertToken(entryInput);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sapodata")]
        public IBodyWorkflowAction<JToken> CreateEntry([WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<object> entryInput = null, [WorkflowExpression] Func<string> relativePath = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/createentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["entity"] = SourceExpressionConverter.ConvertO(entity);
                callPayload.Queries["relativePath"] = Convert.ToString("/");
                if (relativePath != null)
                    callPayload.Queries["relativePath"] = SourceExpressionConverter.ConvertO(relativePath);
                callPayload.Body = SourceExpressionConverter.ConvertToken(entryInput);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sapodata")]
        public IBodyWorkflowAction<JToken> UpdateEntry([WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<object> entryInput = null, [WorkflowExpression] Func<string> relativePath = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/updateentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["entity"] = SourceExpressionConverter.ConvertO(entity);
                callPayload.Queries["relativePath"] = Convert.ToString("/");
                if (relativePath != null)
                    callPayload.Queries["relativePath"] = SourceExpressionConverter.ConvertO(relativePath);
                callPayload.Body = SourceExpressionConverter.ConvertToken(entryInput);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sapodata")]
        public IBodyWorkflowAction<AdHocRequestResponse> AdHocRequest([WorkflowExpression] Func<string> relativePath, [WorkflowExpression] Func<entryInputhttpMethodInput> entryInputhttpMethod, [WorkflowExpression] Func<bool> bypassMetadata = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/adhoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["relativePath"] = SourceExpressionConverter.ConvertO(relativePath);
                callPayload.Queries["bypassMetadata"] = Convert.ToString(false);
                if (bypassMetadata != null)
                    callPayload.Queries["bypassMetadata"] = SourceExpressionConverter.ConvertO(bypassMetadata);
                var entryInput = new JObject();
                var entryInputpropCount = 0;
                entryInputpropCount++;
                entryInput["httpMethod"] = SourceExpressionConverter.Convert(entryInputhttpMethod);
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
                return callPayload;
            }

            return new ApiConnectionAction<AdHocRequestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sapodata")]
        public IBodyWorkflowAction<AdHocBulkRequestResponse> AdHocBulkRequest([WorkflowExpression] Func<string> relativePath, [WorkflowExpression] Func<entryInputhttpMethodInput> entryInputhttpMethod, [WorkflowExpression] Func<JToken[]> entryInputpayload = null, [WorkflowExpression] Func<bool> bypassMetadata = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/adhocBulk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["relativePath"] = SourceExpressionConverter.ConvertO(relativePath);
                callPayload.Queries["bypassMetadata"] = Convert.ToString(false);
                if (bypassMetadata != null)
                    callPayload.Queries["bypassMetadata"] = SourceExpressionConverter.ConvertO(bypassMetadata);
                var entryInput = new JObject();
                var entryInputpropCount = 0;
                entryInputpropCount++;
                entryInput["httpMethod"] = SourceExpressionConverter.Convert(entryInputhttpMethod);
                var queryStringObject = new JObject();
                var queryStringObjectpropCount = 0;
                if (queryStringObjectpropCount > 0)
                {
                    entryInput["queryString"] = queryStringObject;
                    entryInputpropCount++;
                }

                if (entryInputpayload != null)
                {
                    entryInput["payload"] = SourceExpressionConverter.ConvertToken(entryInputpayload);
                    entryInputpropCount++;
                }

                if (entryInputpropCount > 0)
                {
                    callPayload.Body = entryInput;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AdHocBulkRequestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sapodata")]
        public IBodyWorkflowAction<JToken> DeleteEntry([WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<object> entryInput = null, [WorkflowExpression] Func<string> relativePath = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/deleteentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["entity"] = SourceExpressionConverter.ConvertO(entity);
                callPayload.Queries["relativePath"] = Convert.ToString("/");
                if (relativePath != null)
                    callPayload.Queries["relativePath"] = SourceExpressionConverter.ConvertO(relativePath);
                callPayload.Body = SourceExpressionConverter.ConvertToken(entryInput);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
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