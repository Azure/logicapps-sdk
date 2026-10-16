//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aheadintranet
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AheadintranetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aheadintranet")]
        public IWorkflowAction AheadReceiveExternalActivity(Expression<Func<string>> bodytitle, Expression<Func<string>> bodytext = null, Expression<Func<string>> bodyurl = null, Expression<Func<string>> bodymediaUrl = null, Expression<Func<bodysourceInput>> bodysource = null, Expression<Func<string>> bodytargetAudience = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: false);
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: false);
            var __workflow_bodymediaUrl = WorkflowExpression.Compile(bodymediaUrl, nameof(bodymediaUrl), required: false);
            var __workflow_bodysource = WorkflowExpression.Compile(bodysource, nameof(bodysource), required: false);
            var __workflow_bodytargetAudience = WorkflowExpression.Compile(bodytargetAudience, nameof(bodytargetAudience), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/ReceiveExternalActivity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (__workflow_bodytext != null)
                {
                    body["Text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                    bodypropCount++;
                }

                if (__workflow_bodyurl != null)
                {
                    body["Url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                    bodypropCount++;
                }

                if (__workflow_bodymediaUrl != null)
                {
                    body["MediaUrl"] = ExpressionConverter.ConvertO(__workflow_bodymediaUrl);
                    bodypropCount++;
                }

                if (__workflow_bodysource != null)
                {
                    body["Source"] = ExpressionConverter.ConvertO(__workflow_bodysource);
                    bodypropCount++;
                }

                if (__workflow_bodytargetAudience != null)
                {
                    body["TargetAudience"] = ExpressionConverter.ConvertO(__workflow_bodytargetAudience);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
