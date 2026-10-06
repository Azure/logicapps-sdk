//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersive
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersiveActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersive")]
        [WorkflowExpressionFactory(nameof(__BuildScanFile))]
        public IBodyWorkflowAction<VirusScanResult> ScanFile([WorkflowExpression] Func<string> inputFile)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersive")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VirusScanResult> __BuildScanFile(WorkflowExpression<string> inputFile)
        {
            WorkflowExpression.Validate(inputFile, nameof(inputFile), required: true);
            return new DeferredBodyAction<VirusScanResult>(() =>
            {
                var apiCallPath = "/virus/scan/file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VirusScanResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersive")]
        [WorkflowExpressionFactory(nameof(__BuildScanWebsite))]
        public IBodyWorkflowAction<WebsiteScanResult> ScanWebsite([WorkflowExpression] Func<string> inputurl = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersive")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WebsiteScanResult> __BuildScanWebsite(WorkflowExpression<string> inputurl = null)
        {
            WorkflowExpression.Validate(inputurl, nameof(inputurl), required: false);
            return new DeferredBodyAction<WebsiteScanResult>(() =>
            {
                var apiCallPath = "/virus/scan/website";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputurl != null)
                {
                    input["Url"] = ExpressionConverter.ConvertO(inputurl);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<WebsiteScanResult>(callPayload);
            });
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