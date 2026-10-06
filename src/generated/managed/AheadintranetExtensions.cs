//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aheadintranet
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AheadintranetActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aheadintranet")]
        [WorkflowExpressionFactory(nameof(__BuildAheadReceiveExternalActivity))]
        public IWorkflowAction AheadReceiveExternalActivity([WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<string> bodyurl = null, [WorkflowExpression] Func<string> bodymediaUrl = null, [WorkflowExpression] Func<bodysourceInput> bodysource = null, [WorkflowExpression] Func<string> bodytargetAudience = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aheadintranet")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAheadReceiveExternalActivity(WorkflowExpression<string> bodytitle, WorkflowExpression<string> bodytext = null, WorkflowExpression<string> bodyurl = null, WorkflowExpression<string> bodymediaUrl = null, WorkflowExpression<bodysourceInput> bodysource = null, WorkflowExpression<string> bodytargetAudience = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: false);
            WorkflowExpression.Validate(bodyurl, nameof(bodyurl), required: false);
            WorkflowExpression.Validate(bodymediaUrl, nameof(bodymediaUrl), required: false);
            WorkflowExpression.Validate(bodysource, nameof(bodysource), required: false);
            WorkflowExpression.Validate(bodytargetAudience, nameof(bodytargetAudience), required: false);
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

                if (bodytargetAudience != null)
                {
                    body["TargetAudience"] = ExpressionConverter.ConvertO(bodytargetAudience);
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

    public class AheadintranetTriggers([ConnectionName] string connectionId)
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Aheadintranet;

    public partial class WorkflowManagedActions
    {
        public AheadintranetActions Aheadintranet(string connectionId) => new AheadintranetActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AheadintranetTriggers Aheadintranet(string connectionId) => new AheadintranetTriggers(connectionId);
    }
}