//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Staychartedaimodeltr
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class StaychartedaimodeltrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "staychartedaimodeltr")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> Classify(Expression<Func<string>> id, Expression<Func<BodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/models/{0}/classify", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class StaychartedaimodeltrTriggers([ConnectionName] string connectionId)
    {
    }

    public class BodyInput
    {
        public BodyInput(JToken @record)
        {
            this.Record = @record;
        }

        [JsonProperty("input", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Record { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Staychartedaimodeltr;

    public partial class WorkflowManagedActions
    {
        public StaychartedaimodeltrActions Staychartedaimodeltr(string connectionId) => new StaychartedaimodeltrActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public StaychartedaimodeltrTriggers Staychartedaimodeltr(string connectionId) => new StaychartedaimodeltrTriggers(connectionId);
    }
}