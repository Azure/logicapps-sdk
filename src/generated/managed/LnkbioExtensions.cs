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
        public IBodyWorkflowAction<InlineResponse200, ApiConnectionActionConfiguration> Lnkadd(Expression<Func<string>> bodytitle, Expression<Func<string>> bodylink, Expression<Func<string>> bodyimage = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodylink = WorkflowExpression.Compile(bodylink, nameof(bodylink), required: true);
            var __workflow_bodyimage = WorkflowExpression.Compile(bodyimage, nameof(bodyimage), required: false);
            return new DeferredBodyAction<InlineResponse200, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/lnk/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                bodypropCount++;
                body["link"] = ExpressionConverter.ConvertO(__workflow_bodylink);
                if (__workflow_bodyimage != null)
                {
                    body["image"] = ExpressionConverter.ConvertO(__workflow_bodyimage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
