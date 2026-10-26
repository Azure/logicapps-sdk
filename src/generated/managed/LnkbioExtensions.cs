//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lnkbio
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LnkbioActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lnkbio")]
        public IBodyWorkflowAction<InlineResponse200, ApiConnectionActionConfiguration> Lnkadd(Expression<Func<LnkaddInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<InlineResponse200, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/lnk/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<InlineResponse200>(callPayload);
            });
        }
    }

    public class LnkbioTriggers([ConnectionName] string connectionId)
    {
    }

    public class InlineResponse200
    {
        [JsonProperty("data")]
        public InlineResponse200Data Data { get; set; }

        [JsonProperty("errors")]
        public string[] Errors { get; set; }

        [JsonProperty("status")]
        public bool Status { get; set; }
    }

    public class InlineResponse200Data
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class LnkaddInput
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("link", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Link { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Lnkbio;

    public partial class WorkflowManagedActions
    {
        public LnkbioActions Lnkbio(string connectionId) => new LnkbioActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LnkbioTriggers Lnkbio(string connectionId) => new LnkbioTriggers(connectionId);
    }
}