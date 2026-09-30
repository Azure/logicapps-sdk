//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersive
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersiveActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersive")]
        public IBodyWorkflowAction<WebsiteScanResult> ScanWebsite([WorkflowExpression] Func<string> inputurl = null)
        {
            SourceExpression.Validate(inputurl, nameof(inputurl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/virus/scan/website";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputurl != null)
                {
                    input["Url"] = SourceExpressionConverter.ConvertToken(inputurl);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WebsiteScanResult>(BuildSourceInput);
        }
    }

    public class CloudmersiveTriggers([ConnectionName] string connectionId)
    {
    }

    public class WebsiteScanResult
    {
        public bool CleanResult { get; set; }
        public WebsiteScanResultWebsiteThreatTypeType WebsiteThreatType { get; set; }
    }

    public enum WebsiteScanResultWebsiteThreatTypeType
    {
        None,
        Malware,
        Phishing,
        ForcedDownload,
        UnableToConnect
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersive;

    public partial class WorkflowManagedActions
    {
        public CloudmersiveActions Cloudmersive(string connectionId) => new CloudmersiveActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CloudmersiveTriggers Cloudmersive(string connectionId) => new CloudmersiveTriggers(connectionId);
    }
}