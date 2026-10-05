//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sapodata
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SapodataActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sapodata")]
        [WorkflowExpressionFactory(nameof(__BuildGetEntityData))]
        public IBodyWorkflowAction<Output> GetEntityData([WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<string> relativePath = null, [WorkflowExpression] Func<double> top = null, [WorkflowExpression] Func<double> skip = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<inlinecountInput> inlinecount = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Output> __BuildGetEntityData(WorkflowValue<string> entity, WorkflowValue<string> relativePath = null, WorkflowValue<double> top = null, WorkflowValue<double> skip = null, WorkflowValue<string> select = null, WorkflowValue<string> filter = null, WorkflowValue<string> expand = null, WorkflowValue<string> orderby = null, WorkflowValue<string> search = null, WorkflowValue<inlinecountInput> inlinecount = null)
        {
            WorkflowValue.Validate(entity, nameof(entity), required: true);
            WorkflowValue.Validate(relativePath, nameof(relativePath), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(skip, nameof(skip), required: false);
            WorkflowValue.Validate(select, nameof(select), required: false);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(expand, nameof(expand), required: false);
            WorkflowValue.Validate(orderby, nameof(orderby), required: false);
            WorkflowValue.Validate(search, nameof(search), required: false);
            WorkflowValue.Validate(inlinecount, nameof(inlinecount), required: false);
            return new DeferredBodyAction<Output>(() =>
            {
                var apiCallPath = "/getentitydata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["entity"] = ExpressionConverter.Convert(entity);
                callPayload.Queries["relativePath"] = Convert.ToString("/");
                if (relativePath != null)
                    callPayload.Queries["relativePath"] = ExpressionConverter.Convert(relativePath);
                if (top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(top);
                if (skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(skip);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (expand != null)
                    callPayload.Queries["expand"] = ExpressionConverter.Convert(expand);
                if (orderby != null)
                    callPayload.Queries["orderby"] = ExpressionConverter.Convert(orderby);
                if (search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(search);
                if (inlinecount != null)
                    callPayload.Queries["inlinecount"] = ExpressionConverter.Convert(inlinecount);
                return new ApiConnectionAction<Output>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sapodata")]
        [WorkflowExpressionFactory(nameof(__BuildGetEntry))]
        public IBodyWorkflowAction<JToken> GetEntry([WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<object> entryInput = null, [WorkflowExpression] Func<string> relativePath = null, [WorkflowExpression] Func<double> top = null, [WorkflowExpression] Func<double> skip = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<inlinecountInput> inlinecount = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetEntry(WorkflowValue<string> entity, WorkflowValue<object> entryInput = null, WorkflowValue<string> relativePath = null, WorkflowValue<double> top = null, WorkflowValue<double> skip = null, WorkflowValue<string> select = null, WorkflowValue<string> filter = null, WorkflowValue<string> expand = null, WorkflowValue<string> orderby = null, WorkflowValue<string> search = null, WorkflowValue<inlinecountInput> inlinecount = null)
        {
            WorkflowValue.Validate(entity, nameof(entity), required: true);
            WorkflowValue.Validate(entryInput, nameof(entryInput), required: false);
            WorkflowValue.Validate(relativePath, nameof(relativePath), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(skip, nameof(skip), required: false);
            WorkflowValue.Validate(select, nameof(select), required: false);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(expand, nameof(expand), required: false);
            WorkflowValue.Validate(orderby, nameof(orderby), required: false);
            WorkflowValue.Validate(search, nameof(search), required: false);
            WorkflowValue.Validate(inlinecount, nameof(inlinecount), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/getentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["entity"] = ExpressionConverter.Convert(entity);
                callPayload.Queries["relativePath"] = Convert.ToString("/");
                if (relativePath != null)
                    callPayload.Queries["relativePath"] = ExpressionConverter.Convert(relativePath);
                if (top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(top);
                if (skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(skip);
                if (select != null)
                    callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                if (expand != null)
                    callPayload.Queries["expand"] = ExpressionConverter.Convert(expand);
                if (orderby != null)
                    callPayload.Queries["orderby"] = ExpressionConverter.Convert(orderby);
                if (search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(search);
                if (inlinecount != null)
                    callPayload.Queries["inlinecount"] = ExpressionConverter.Convert(inlinecount);
                callPayload.Body = ExpressionConverter.ConvertO(entryInput);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sapodata")]
        [WorkflowExpressionFactory(nameof(__BuildCreateEntry))]
        public IBodyWorkflowAction<JToken> CreateEntry([WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<object> entryInput = null, [WorkflowExpression] Func<string> relativePath = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCreateEntry(WorkflowValue<string> entity, WorkflowValue<object> entryInput = null, WorkflowValue<string> relativePath = null)
        {
            WorkflowValue.Validate(entity, nameof(entity), required: true);
            WorkflowValue.Validate(entryInput, nameof(entryInput), required: false);
            WorkflowValue.Validate(relativePath, nameof(relativePath), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/createentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["entity"] = ExpressionConverter.Convert(entity);
                callPayload.Queries["relativePath"] = Convert.ToString("/");
                if (relativePath != null)
                    callPayload.Queries["relativePath"] = ExpressionConverter.Convert(relativePath);
                callPayload.Body = ExpressionConverter.ConvertO(entryInput);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sapodata")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateEntry))]
        public IBodyWorkflowAction<JToken> UpdateEntry([WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<object> entryInput = null, [WorkflowExpression] Func<string> relativePath = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildUpdateEntry(WorkflowValue<string> entity, WorkflowValue<object> entryInput = null, WorkflowValue<string> relativePath = null)
        {
            WorkflowValue.Validate(entity, nameof(entity), required: true);
            WorkflowValue.Validate(entryInput, nameof(entryInput), required: false);
            WorkflowValue.Validate(relativePath, nameof(relativePath), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/updateentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["entity"] = ExpressionConverter.Convert(entity);
                callPayload.Queries["relativePath"] = Convert.ToString("/");
                if (relativePath != null)
                    callPayload.Queries["relativePath"] = ExpressionConverter.Convert(relativePath);
                callPayload.Body = ExpressionConverter.ConvertO(entryInput);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sapodata")]
        [WorkflowExpressionFactory(nameof(__BuildAdHocRequest))]
        public IBodyWorkflowAction<AdHocRequestResponse> AdHocRequest([WorkflowExpression] Func<string> relativePath, [WorkflowExpression] Func<entryInputhttpMethodInput> entryInputhttpMethod, [WorkflowExpression] Func<bool> bypassMetadata = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AdHocRequestResponse> __BuildAdHocRequest(WorkflowValue<string> relativePath, WorkflowValue<entryInputhttpMethodInput> entryInputhttpMethod, WorkflowValue<bool> bypassMetadata = null)
        {
            WorkflowValue.Validate(relativePath, nameof(relativePath), required: true);
            WorkflowValue.Validate(entryInputhttpMethod, nameof(entryInputhttpMethod), required: true);
            WorkflowValue.Validate(bypassMetadata, nameof(bypassMetadata), required: false);
            return new DeferredBodyAction<AdHocRequestResponse>(() =>
            {
                var apiCallPath = "/adhoc";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["relativePath"] = ExpressionConverter.Convert(relativePath);
                callPayload.Queries["bypassMetadata"] = Convert.ToString(false);
                if (bypassMetadata != null)
                    callPayload.Queries["bypassMetadata"] = ExpressionConverter.Convert(bypassMetadata);
                var entryInput = new JObject();
                var entryInputpropCount = 0;
                entryInputpropCount++;
                entryInput["httpMethod"] = ExpressionConverter.ConvertO(entryInputhttpMethod);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sapodata")]
        [WorkflowExpressionFactory(nameof(__BuildAdHocBulkRequest))]
        public IBodyWorkflowAction<AdHocBulkRequestResponse> AdHocBulkRequest([WorkflowExpression] Func<string> relativePath, [WorkflowExpression] Func<entryInputhttpMethodInput> entryInputhttpMethod, [WorkflowExpression] Func<JToken[]> entryInputpayload = null, [WorkflowExpression] Func<bool> bypassMetadata = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AdHocBulkRequestResponse> __BuildAdHocBulkRequest(WorkflowValue<string> relativePath, WorkflowValue<entryInputhttpMethodInput> entryInputhttpMethod, WorkflowValue<JToken[]> entryInputpayload = null, WorkflowValue<bool> bypassMetadata = null)
        {
            WorkflowValue.Validate(relativePath, nameof(relativePath), required: true);
            WorkflowValue.Validate(entryInputhttpMethod, nameof(entryInputhttpMethod), required: true);
            WorkflowValue.Validate(entryInputpayload, nameof(entryInputpayload), required: false);
            WorkflowValue.Validate(bypassMetadata, nameof(bypassMetadata), required: false);
            return new DeferredBodyAction<AdHocBulkRequestResponse>(() =>
            {
                var apiCallPath = "/adhocBulk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["relativePath"] = ExpressionConverter.Convert(relativePath);
                callPayload.Queries["bypassMetadata"] = Convert.ToString(false);
                if (bypassMetadata != null)
                    callPayload.Queries["bypassMetadata"] = ExpressionConverter.Convert(bypassMetadata);
                var entryInput = new JObject();
                var entryInputpropCount = 0;
                entryInputpropCount++;
                entryInput["httpMethod"] = ExpressionConverter.ConvertO(entryInputhttpMethod);
                var queryStringObject = new JObject();
                var queryStringObjectpropCount = 0;
                if (queryStringObjectpropCount > 0)
                {
                    entryInput["queryString"] = queryStringObject;
                    entryInputpropCount++;
                }

                if (entryInputpayload != null)
                {
                    entryInput["payload"] = ExpressionConverter.ConvertO(entryInputpayload);
                    entryInputpropCount++;
                }

                if (entryInputpropCount > 0)
                {
                    callPayload.Body = entryInput;
                }

                return new ApiConnectionAction<AdHocBulkRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sapodata")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteEntry))]
        public IBodyWorkflowAction<JToken> DeleteEntry([WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<object> entryInput = null, [WorkflowExpression] Func<string> relativePath = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildDeleteEntry(WorkflowValue<string> entity, WorkflowValue<object> entryInput = null, WorkflowValue<string> relativePath = null)
        {
            WorkflowValue.Validate(entity, nameof(entity), required: true);
            WorkflowValue.Validate(entryInput, nameof(entryInput), required: false);
            WorkflowValue.Validate(relativePath, nameof(relativePath), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/deleteentry";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["entity"] = ExpressionConverter.Convert(entity);
                callPayload.Queries["relativePath"] = Convert.ToString("/");
                if (relativePath != null)
                    callPayload.Queries["relativePath"] = ExpressionConverter.Convert(relativePath);
                callPayload.Body = ExpressionConverter.ConvertO(entryInput);
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
