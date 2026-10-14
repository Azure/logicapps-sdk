//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Robohaship
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class RobohashipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "robohaship")]
        public IBodyWorkflowAction<ImageGetResponse> ImageGet(Expression<Func<string>> text, Expression<Func<setInput>> set, Expression<Func<string>> size = null, Expression<Func<string>> bgset = null, Expression<Func<gravatarInput>> gravatar = null)
        {
            var __workflow_text = text == null ? null : WorkflowExpression.Compile(text);
            WorkflowExpression.Validate(__workflow_text, nameof(text), required: true);
            var __workflow_set = set == null ? null : WorkflowExpression.Compile(set);
            WorkflowExpression.Validate(__workflow_set, nameof(set), required: true);
            var __workflow_size = size == null ? null : WorkflowExpression.Compile(size);
            WorkflowExpression.Validate(__workflow_size, nameof(size), required: false);
            var __workflow_bgset = bgset == null ? null : WorkflowExpression.Compile(bgset);
            WorkflowExpression.Validate(__workflow_bgset, nameof(bgset), required: false);
            var __workflow_gravatar = gravatar == null ? null : WorkflowExpression.Compile(gravatar);
            WorkflowExpression.Validate(__workflow_gravatar, nameof(gravatar), required: false);
            return new DeferredBodyAction<ImageGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_text, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["set"] = ExpressionConverter.Convert(__workflow_set);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_bgset != null)
                    callPayload.Queries["bgset"] = ExpressionConverter.Convert(__workflow_bgset);
                callPayload.Queries["gravatar"] = Convert.ToString("no");
                if (__workflow_gravatar != null)
                    callPayload.Queries["gravatar"] = ExpressionConverter.Convert(__workflow_gravatar);
                return new ApiConnectionAction<ImageGetResponse>(callPayload);
            });
        }
    }

    public class RobohashipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ImageGetResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum setInput
    {
        [EnumMember(Value = "any")]
        Any,
        [EnumMember(Value = "set1")]
        Set1,
        [EnumMember(Value = "set2")]
        Set2,
        [EnumMember(Value = "set3")]
        Set3,
        [EnumMember(Value = "set4")]
        Set4,
        [EnumMember(Value = "set5")]
        Set5
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum gravatarInput
    {
        [EnumMember(Value = "no")]
        No,
        [EnumMember(Value = "yes")]
        Yes
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Robohaship;

    public partial class WorkflowManagedActions
    {
        public RobohashipActions Robohaship(string connectionId) => new RobohashipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RobohashipTriggers Robohaship(string connectionId) => new RobohashipTriggers(connectionId);
    }
}
