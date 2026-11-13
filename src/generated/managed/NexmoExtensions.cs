//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nexmo
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NexmoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nexmo")]
        public IBodyWorkflowAction<ListNumbersResponse, ApiConnectionActionConfiguration> ListOwnedNumbers(Expression<Func<SearchPatternInput>> searchPattern = null, Expression<Func<double>> index = null, Expression<Func<double>> size = null, Expression<Func<double>> pattern = null)
        {
            var __workflow_searchPattern = WorkflowExpression.Compile(searchPattern, nameof(searchPattern), required: false);
            var __workflow_index = WorkflowExpression.Compile(index, nameof(index), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_pattern = WorkflowExpression.Compile(pattern, nameof(pattern), required: false);
            return new DeferredBodyAction<ListNumbersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/account/numbers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_searchPattern != null)
                    callPayload.Queries["Search Pattern"] = ExpressionConverter.Convert(__workflow_searchPattern);
                if (__workflow_index != null)
                    callPayload.Queries["index"] = ExpressionConverter.Convert(__workflow_index);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_pattern != null)
                    callPayload.Queries["pattern"] = ExpressionConverter.Convert(__workflow_pattern);
                return new ApiConnectionAction<ListNumbersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nexmo")]
        public IBodyWorkflowAction<ListNumbersResponse, ApiConnectionActionConfiguration> ListInboundNumbers(Expression<Func<string>> country, Expression<Func<SearchPatternInput>> searchPattern = null, Expression<Func<double>> pattern = null, Expression<Func<string>> features = null, Expression<Func<double>> size = null, Expression<Func<double>> index = null)
        {
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: true);
            var __workflow_searchPattern = WorkflowExpression.Compile(searchPattern, nameof(searchPattern), required: false);
            var __workflow_pattern = WorkflowExpression.Compile(pattern, nameof(pattern), required: false);
            var __workflow_features = WorkflowExpression.Compile(features, nameof(features), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_index = WorkflowExpression.Compile(index, nameof(index), required: false);
            return new DeferredBodyAction<ListNumbersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/number/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["country"] = ExpressionConverter.Convert(__workflow_country);
                if (__workflow_searchPattern != null)
                    callPayload.Queries["Search Pattern"] = ExpressionConverter.Convert(__workflow_searchPattern);
                if (__workflow_pattern != null)
                    callPayload.Queries["pattern"] = ExpressionConverter.Convert(__workflow_pattern);
                if (__workflow_features != null)
                    callPayload.Queries["features"] = ExpressionConverter.Convert(__workflow_features);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_index != null)
                    callPayload.Queries["index"] = ExpressionConverter.Convert(__workflow_index);
                return new ApiConnectionAction<ListNumbersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nexmo")]
        public IBodyWorkflowAction<ListApplicationsResponse, ApiConnectionActionConfiguration> ListApplications(Expression<Func<double>> pageSize = null, Expression<Func<double>> pageIndex = null)
        {
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_pageIndex = WorkflowExpression.Compile(pageIndex, nameof(pageIndex), required: false);
            return new DeferredBodyAction<ListApplicationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/applications";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_pageIndex != null)
                    callPayload.Queries["page_index"] = ExpressionConverter.Convert(__workflow_pageIndex);
                return new ApiConnectionAction<ListApplicationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nexmo")]
        public IBodyWorkflowAction<ApplicationResponse, ApiConnectionActionConfiguration> CreateApplication(Expression<Func<string>> name, Expression<Func<string>> type, Expression<Func<string>> answerUrl, Expression<Func<string>> eventUrl, Expression<Func<string>> answerMethod = null, Expression<Func<string>> eventMethod = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_answerUrl = WorkflowExpression.Compile(answerUrl, nameof(answerUrl), required: true);
            var __workflow_eventUrl = WorkflowExpression.Compile(eventUrl, nameof(eventUrl), required: true);
            var __workflow_answerMethod = WorkflowExpression.Compile(answerMethod, nameof(answerMethod), required: false);
            var __workflow_eventMethod = WorkflowExpression.Compile(eventMethod, nameof(eventMethod), required: false);
            return new DeferredBodyAction<ApplicationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/applications";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                callPayload.Queries["answer_url"] = ExpressionConverter.Convert(__workflow_answerUrl);
                callPayload.Queries["event_url"] = ExpressionConverter.Convert(__workflow_eventUrl);
                if (__workflow_answerMethod != null)
                    callPayload.Queries["answer_method"] = ExpressionConverter.Convert(__workflow_answerMethod);
                if (__workflow_eventMethod != null)
                    callPayload.Queries["event_method"] = ExpressionConverter.Convert(__workflow_eventMethod);
                return new ApiConnectionAction<ApplicationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nexmo")]
        public IBodyWorkflowAction<ApplicationResponse, ApiConnectionActionConfiguration> GetApplication(Expression<Func<string>> applicationId)
        {
            var __workflow_applicationId = WorkflowExpression.Compile(applicationId, nameof(applicationId), required: true);
            return new DeferredBodyAction<ApplicationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/applications/{0}", __workflow_applicationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ApplicationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nexmo")]
        public IBodyWorkflowAction<ApplicationResponse, ApiConnectionActionConfiguration> UpdateApplication(Expression<Func<string>> applicationId, Expression<Func<string>> name, Expression<Func<string>> type, Expression<Func<string>> answerUrl, Expression<Func<string>> eventUrl, Expression<Func<string>> answerMethod = null, Expression<Func<string>> eventMethod = null)
        {
            var __workflow_applicationId = WorkflowExpression.Compile(applicationId, nameof(applicationId), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_answerUrl = WorkflowExpression.Compile(answerUrl, nameof(answerUrl), required: true);
            var __workflow_eventUrl = WorkflowExpression.Compile(eventUrl, nameof(eventUrl), required: true);
            var __workflow_answerMethod = WorkflowExpression.Compile(answerMethod, nameof(answerMethod), required: false);
            var __workflow_eventMethod = WorkflowExpression.Compile(eventMethod, nameof(eventMethod), required: false);
            return new DeferredBodyAction<ApplicationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/applications/{0}", __workflow_applicationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                callPayload.Queries["answer_url"] = ExpressionConverter.Convert(__workflow_answerUrl);
                callPayload.Queries["event_url"] = ExpressionConverter.Convert(__workflow_eventUrl);
                if (__workflow_answerMethod != null)
                    callPayload.Queries["answer_method"] = ExpressionConverter.Convert(__workflow_answerMethod);
                if (__workflow_eventMethod != null)
                    callPayload.Queries["event_method"] = ExpressionConverter.Convert(__workflow_eventMethod);
                return new ApiConnectionAction<ApplicationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nexmo")]
        public IBodyWorkflowAction<Common, ApiConnectionActionConfiguration> DeleteApplication(Expression<Func<string>> applicationId)
        {
            var __workflow_applicationId = WorkflowExpression.Compile(applicationId, nameof(applicationId), required: true);
            return new DeferredBodyAction<Common, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/applications/{0}", __workflow_applicationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Common>(callPayload);
            });
        }
    }

    public class NexmoTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListNumbersResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("numbers")]
        public ListNumbersResponseNumbersArrayTypeItem[] NumbersArray { get; set; }
    }

    public class ListNumbersResponseNumbersArrayTypeItem
    {
        [JsonProperty("cost")]
        public string Cost { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("msisdn")]
        public string InboundNumber { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SearchPatternInput
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3
    }

    public class ListApplicationsResponse
    {
        [JsonProperty("_embedded")]
        public ListApplicationsResponseEmbeddedType Embedded { get; set; }
    }

    public class ListApplicationsResponseEmbeddedType
    {
        [JsonProperty("applications")]
        public ApplicationResponse[] Applications { get; set; }
    }

    public class ApplicationResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("keys")]
        public ApplicationResponseKeysType Keys { get; set; }
    }

    public class ApplicationResponseKeysType
    {
        [JsonProperty("public_key")]
        public string Keys { get; set; }
    }

    public class Common
    {
        [JsonProperty("type")]
        public string Response { get; set; }

        [JsonProperty("error_title")]
        public string ErrorText { get; set; }

        [JsonProperty("invalid_parameters")]
        public CommonInvalidParametersType InvalidParameters { get; set; }
    }

    public class CommonInvalidParametersType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nexmo;

    public partial class WorkflowManagedActions
    {
        public NexmoActions Nexmo(string connectionId) => new NexmoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NexmoTriggers Nexmo(string connectionId) => new NexmoTriggers(connectionId);
    }
}