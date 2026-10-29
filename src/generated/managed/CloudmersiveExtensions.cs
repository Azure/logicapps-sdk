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
        public IBodyWorkflowAction<WebsiteScanResult, ApiConnectionActionConfiguration> ScanWebsite(Expression<Func<ScanWebsiteInput>> input)
        {
            var __workflow_input = WorkflowExpression.Compile(input, nameof(input), required: true);
            return new DeferredBodyAction<WebsiteScanResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/virus/scan/website";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_input);
                return new ApiConnectionAction<WebsiteScanResult>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebsiteScanResultWebsiteThreatTypeType
    {
        None,
        Malware,
        Phishing,
        ForcedDownload,
        UnableToConnect
    }

    public class ScanWebsiteInput
    {
        public string Url { get; set; }
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