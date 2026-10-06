//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lnkbio
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LnkbioActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lnkbio")]
        [WorkflowExpressionFactory(nameof(__BuildLnkadd))]
        public IBodyWorkflowAction<InlineResponse200> Lnkadd([WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodylink, [WorkflowExpression] Func<string> bodyimage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lnkbio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InlineResponse200> __BuildLnkadd(WorkflowExpression<string> bodytitle, WorkflowExpression<string> bodylink, WorkflowExpression<string> bodyimage = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowExpression.Validate(bodylink, nameof(bodylink), required: true);
            WorkflowExpression.Validate(bodyimage, nameof(bodyimage), required: false);
            return new DeferredBodyAction<InlineResponse200>(() =>
            {
                var apiCallPath = "/lnk/add";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
                body["link"] = ExpressionConverter.ConvertO(bodylink);
                if (bodyimage != null)
                {
                    body["image"] = ExpressionConverter.ConvertO(bodyimage);
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