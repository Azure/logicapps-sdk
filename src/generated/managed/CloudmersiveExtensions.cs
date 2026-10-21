//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersive
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersiveActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersive")]
        public IBodyWorkflowAction<VirusScanResult> ScanFile(Expression<Func<string>> inputFile)
        {
            var __workflow_inputFile = WorkflowExpression.Compile(inputFile, nameof(inputFile), required: true);
            return new DeferredBodyAction<VirusScanResult>(() =>
            {
                var apiCallPath = "/virus/scan/file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VirusScanResult>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersive")]
        public IBodyWorkflowAction<WebsiteScanResult> ScanWebsite(Expression<Func<string>> inputurl = null)
        {
            var __workflow_inputurl = WorkflowExpression.Compile(inputurl, nameof(inputurl), required: false);
            return new DeferredBodyAction<WebsiteScanResult>(() =>
            {
                var apiCallPath = "/virus/scan/website";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputurl != null)
                {
                    input["Url"] = ExpressionConverter.ConvertO(__workflow_inputurl);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<WebsiteScanResult>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
