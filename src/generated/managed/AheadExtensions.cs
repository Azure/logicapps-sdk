//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ahead
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AheadActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ahead")]
        public IWorkflowAction AheadReceiveExternalActivity([WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodytext = null, [WorkflowExpression] Func<string> bodyurl = null, [WorkflowExpression] Func<string> bodymediaUrl = null, [WorkflowExpression] Func<bodysourceInput> bodysource = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ReceiveExternalActivity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodytext != null)
                {
                    body["Text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodyurl != null)
                {
                    body["Url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                    bodypropCount++;
                }

                if (bodymediaUrl != null)
                {
                    body["MediaUrl"] = SourceExpressionConverter.ConvertToken(bodymediaUrl);
                    bodypropCount++;
                }

                if (bodysource != null)
                {
                    body["Source"] = SourceExpressionConverter.Convert(bodysource);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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