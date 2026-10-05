//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Robohaship
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RobohashipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "robohaship")]
        [WorkflowExpressionFactory(nameof(__BuildImageGet))]
        public IBodyWorkflowAction<ImageGetResponse> ImageGet([WorkflowExpression] Func<string> text, [WorkflowExpression] Func<setInput> set, [WorkflowExpression] Func<string> size = null, [WorkflowExpression] Func<string> bgset = null, [WorkflowExpression] Func<gravatarInput> gravatar = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ImageGetResponse> __BuildImageGet(WorkflowValue<string> text, WorkflowValue<setInput> set, WorkflowValue<string> size = null, WorkflowValue<string> bgset = null, WorkflowValue<gravatarInput> gravatar = null)
        {
            WorkflowValue.Validate(text, nameof(text), required: true);
            WorkflowValue.Validate(set, nameof(set), required: true);
            WorkflowValue.Validate(size, nameof(size), required: false);
            WorkflowValue.Validate(bgset, nameof(bgset), required: false);
            WorkflowValue.Validate(gravatar, nameof(gravatar), required: false);
            return new DeferredBodyAction<ImageGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}", ExpressionConverter.ConvertWithUrlEncoding(text, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["set"] = ExpressionConverter.Convert(set);
                if (size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(size);
                if (bgset != null)
                    callPayload.Queries["bgset"] = ExpressionConverter.Convert(bgset);
                callPayload.Queries["gravatar"] = Convert.ToString("no");
                if (gravatar != null)
                    callPayload.Queries["gravatar"] = ExpressionConverter.Convert(gravatar);
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
