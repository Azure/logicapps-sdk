//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ahead
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AheadActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ahead")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AheadReceiveExternalActivity(Expression<Func<AheadReceiveExternalActivityInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ReceiveExternalActivity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class AheadTriggers([ConnectionName] string connectionId)
    {
    }

    public class AheadReceiveExternalActivityInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }
        public string MediaUrl { get; set; }
        public AheadReceiveExternalActivityInputSourceType? Source { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AheadReceiveExternalActivityInputSourceType
    {
        Ahead,
        DynamicsCrm,
        Twitter,
        Yammer,
        Facebook,
        Pipedrive,
        Instagram,
        Youtube,
        MicrosoftStream,
        Menuplan,
        Stocks,
        Weather,
        Sport,
        Travel,
        Event,
        HR,
        Birthday,
        Slack,
        Other
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ahead;

    public partial class WorkflowManagedActions
    {
        public AheadActions Ahead(string connectionId) => new AheadActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AheadTriggers Ahead(string connectionId) => new AheadTriggers(connectionId);
    }
}