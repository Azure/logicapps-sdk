//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Transform2all
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Transform2allActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "transform2all")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Transform(Expression<Func<TransformInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/1.0/translate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class Transform2allTriggers([ConnectionName] string connectionId)
    {
    }

    public class TransformInput
    {
        [JsonProperty("configId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConfigId { get; set; }

        [JsonProperty("base64Content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Base64Content { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Transform2all;

    public partial class WorkflowManagedActions
    {
        public Transform2allActions Transform2all(string connectionId) => new Transform2allActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Transform2allTriggers Transform2all(string connectionId) => new Transform2allTriggers(connectionId);
    }
}