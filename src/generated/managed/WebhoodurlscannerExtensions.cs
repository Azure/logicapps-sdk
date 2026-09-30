//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Webhoodurlscanner
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WebhoodurlscannerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webhoodurlscanner")]
        public IBodyWorkflowAction<Scan[]> GetScans([WorkflowExpression] Func<statusInput> status = null)
        {
            var apiCallPath = "/beta/scans";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["status"] = Convert.ToString("done");
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            return new ApiConnectionAction<Scan[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webhoodurlscanner")]
        public IBodyWorkflowAction<Scan> GetScanById([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> scanId)
        {
            var apiCallPath = String.Format("/beta/scans/{0}", ExpressionConverter.ConvertWithUrlEncoding(scanId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Scan>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webhoodurlscanner")]
        public IWorkflowAction GetScreenshotByScanId([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> scanId)
        {
            var apiCallPath = String.Format("/beta/scans/{0}/screenshot", ExpressionConverter.ConvertWithUrlEncoding(scanId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class WebhoodurlscannerTriggers([ConnectionName] string connectionId)
    {
    }

    public class Scan
    {
        [JsonProperty("id")]
        public string ScanID { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("done_at")]
        public string DoneAt { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("url")]
        public string ScanURL { get; set; }

        [JsonProperty("final_url")]
        public string FinalURL { get; set; }

        [JsonProperty("status")]
        public ScanStatusType Status { get; set; }

        [JsonProperty("screenshots")]
        public string[] ScreenshotList { get; set; }

        [JsonProperty("html")]
        public string[] HTMLList { get; set; }

        [JsonProperty("error")]
        public string ErrorDescription { get; set; }
    }

    public enum ScanStatusType
    {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "done")]
        Done,
        [EnumMember(Value = "error")]
        Error,
        [EnumMember(Value = "running")]
        Running
    }

    public enum statusInput
    {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "done")]
        Done,
        [EnumMember(Value = "running")]
        Running,
        [EnumMember(Value = "error")]
        Error
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Webhoodurlscanner;

    public partial class WorkflowManagedActions
    {
        public WebhoodurlscannerActions Webhoodurlscanner(string connectionId) => new WebhoodurlscannerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WebhoodurlscannerTriggers Webhoodurlscanner(string connectionId) => new WebhoodurlscannerTriggers(connectionId);
    }
}