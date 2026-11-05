//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Carbonedocumentgener
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CarbonedocumentgenerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "carbonedocumentgener")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditTemplate(Expression<Func<string>> templateId, Expression<Func<BodyInput>> body)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/template/{0}", __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class CarbonedocumentgenerTriggers([ConnectionName] string connectionId)
    {
    }

    public class BodyInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("tags")]
        public JToken[] Tags { get; set; }

        [JsonProperty("deployedAt")]
        public int? DeployedAt { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Carbonedocumentgener;

    public partial class WorkflowManagedActions
    {
        public CarbonedocumentgenerActions Carbonedocumentgener(string connectionId) => new CarbonedocumentgenerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CarbonedocumentgenerTriggers Carbonedocumentgener(string connectionId) => new CarbonedocumentgenerTriggers(connectionId);
    }
}