//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Ahead
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AheadActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ahead")]
        public IWorkflowAction AheadReceiveExternalActivity(Expression<Func<string>> bodytitle, Expression<Func<string>> bodytext = null, Expression<Func<string>> bodyurl = null, Expression<Func<string>> bodymediaUrl = null, Expression<Func<bodysourceInput>> bodysource = null)
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
    using Microsoft.Azure.Workflows.Sdk.Ahead;

    public partial class WorkflowManagedActions
    {
        public AheadActions Ahead(string connectionId) => new AheadActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AheadTriggers Ahead(string connectionId) => new AheadTriggers(connectionId);
    }
}