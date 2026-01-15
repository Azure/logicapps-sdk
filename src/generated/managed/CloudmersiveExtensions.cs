//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Cloudmersive
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersiveActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersive")]
        public IBodyWorkflowAction<VirusScanResult> ScanFile(Expression<Func<string>> inputFile)
        {
            var apiCallPath = "/virus/scan/file";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<VirusScanResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersive")]
        public IBodyWorkflowAction<WebsiteScanResult> ScanWebsite(Expression<Func<string>> inputUrl = null)
        {
            var apiCallPath = "/virus/scan/website";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputUrl != null)
            {
                input["Url"] = ExpressionConverter.ConvertO(inputUrl);
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<WebsiteScanResult>(callPayload);
        }
    }

    public class CloudmersiveTriggers([ConnectionName] string connectionId)
    {
    }

    public class VirusScanResult
    {
        public bool CleanResult { get; set; }
        public VirusFound[] FoundViruses { get; set; }
    }

    public class VirusFound
    {
        public string FileName { get; set; }
        public string VirusName { get; set; }
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
    using Microsoft.Azure.Workflows.Sdk.Cloudmersive;

    public partial class WorkflowManagedActions
    {
        public CloudmersiveActions Cloudmersive(string connectionId) => new CloudmersiveActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CloudmersiveTriggers Cloudmersive(string connectionId) => new CloudmersiveTriggers(connectionId);
    }
}