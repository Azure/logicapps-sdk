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
        [WorkflowExpressionFactory(nameof(__BuildGetScans))]
        public IBodyWorkflowAction<Scan[]> GetScans([WorkflowExpression] Func<statusInput> status = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webhoodurlscanner")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Scan[]> __BuildGetScans(WorkflowExpression<statusInput> status = null)
        {
            WorkflowExpression.Validate(status, nameof(status), required: false);
            return new DeferredBodyAction<Scan[]>(() =>
            {
                var apiCallPath = "/beta/scans";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["status"] = Convert.ToString("done");
                if (status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(status);
                return new ApiConnectionAction<Scan[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webhoodurlscanner")]
        [WorkflowExpressionFactory(nameof(__BuildGetScanById))]
        public IBodyWorkflowAction<Scan> GetScanById([WorkflowExpression] Func<string> scanId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webhoodurlscanner")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Scan> __BuildGetScanById(WorkflowExpression<string> scanId)
        {
            WorkflowExpression.Validate(scanId, nameof(scanId), required: true);
            return new DeferredBodyAction<Scan>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/scans/{0}", ExpressionConverter.ConvertWithUrlEncoding(scanId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Scan>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webhoodurlscanner")]
        [WorkflowExpressionFactory(nameof(__BuildGetScreenshotByScanId))]
        public IWorkflowAction GetScreenshotByScanId([WorkflowExpression] Func<string> scanId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webhoodurlscanner")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetScreenshotByScanId(WorkflowExpression<string> scanId)
        {
            WorkflowExpression.Validate(scanId, nameof(scanId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/beta/scans/{0}/screenshot", ExpressionConverter.ConvertWithUrlEncoding(scanId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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