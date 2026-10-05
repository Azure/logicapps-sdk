//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ahead
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AheadActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ahead")]
        [WorkflowExpressionFactory(nameof(__BuildAheadReceiveExternalActivity))]
        public IWorkflowAction AheadReceiveExternalActivity([WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<string> bodyurl = null, [WorkflowExpression] Func<string> bodymediaUrl = null, [WorkflowExpression] Func<bodysourceInput> bodysource = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAheadReceiveExternalActivity(WorkflowValue<string> bodytitle, WorkflowValue<string> bodytext = null, WorkflowValue<string> bodyurl = null, WorkflowValue<string> bodymediaUrl = null, WorkflowValue<bodysourceInput> bodysource = null)
        {
            WorkflowValue.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowValue.Validate(bodytext, nameof(bodytext), required: false);
            WorkflowValue.Validate(bodyurl, nameof(bodyurl), required: false);
            WorkflowValue.Validate(bodymediaUrl, nameof(bodymediaUrl), required: false);
            WorkflowValue.Validate(bodysource, nameof(bodysource), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/ReceiveExternalActivity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodytext != null)
                {
                    body["Text"] = ExpressionConverter.ConvertO(bodytext);
                    bodypropCount++;
                }

                if (bodyurl != null)
                {
                    body["Url"] = ExpressionConverter.ConvertO(bodyurl);
                    bodypropCount++;
                }

                if (bodymediaUrl != null)
                {
                    body["MediaUrl"] = ExpressionConverter.ConvertO(bodymediaUrl);
                    bodypropCount++;
                }

                if (bodysource != null)
                {
                    body["Source"] = ExpressionConverter.ConvertO(bodysource);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class AheadTriggers([ConnectionName] string connectionId)
    {
    }

    public enum bodysourceInput
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
