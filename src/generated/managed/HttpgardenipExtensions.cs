//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Httpgardenip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HttpgardenipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "httpgardenip")]
        public IBodyWorkflowAction<StatusGetResponse, ApiConnectionActionConfiguration> StatusGet(Expression<Func<int>> code, Expression<Func<@fileInput>> @file)
        {
            var __workflow_code = WorkflowExpression.Compile(code, nameof(code), required: true);
            var __workflow_file = WorkflowExpression.Compile(@file, nameof(@file), required: true);
            return new DeferredBodyAction<StatusGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}.{1}", __workflow_code.WithUrlEncoding(1), __workflow_file.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<StatusGetResponse>(callPayload);
            });
        }
    }

    public class HttpgardenipTriggers([ConnectionName] string connectionId)
    {
    }

    public class StatusGetResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum @fileInput
    {
        [EnumMember(Value = "jpg")]
        Jpg,
        [EnumMember(Value = "webp")]
        Webp,
        [EnumMember(Value = "jxl")]
        Jxl,
        [EnumMember(Value = "avif")]
        Avif
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Httpgardenip;

    public partial class WorkflowManagedActions
    {
        public HttpgardenipActions Httpgardenip(string connectionId) => new HttpgardenipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HttpgardenipTriggers Httpgardenip(string connectionId) => new HttpgardenipTriggers(connectionId);
    }
}