//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aheadintranet
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AheadintranetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aheadintranet")]
        public IWorkflowAction AheadReceiveExternalActivity(Expression<Func<string>> bodytitle, Expression<Func<string>> bodytext = null, Expression<Func<string>> bodyurl = null, Expression<Func<string>> bodymediaUrl = null, Expression<Func<bodysourceInput>> bodysource = null, Expression<Func<string>> bodytargetAudience = null)
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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