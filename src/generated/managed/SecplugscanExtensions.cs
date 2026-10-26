//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Secplugscan
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SecplugscanActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "secplugscan")]
        public IBodyWorkflowAction<FilescanResponse, ApiConnectionActionConfiguration> Filescan(Expression<Func<string>> xApiKey = null, Expression<Func<string>> xClientId = null, Expression<Func<FilescanInput>> body = null)
        {
            var __workflow_xApiKey = WorkflowExpression.Compile(xApiKey, nameof(xApiKey), required: false);
            var __workflow_xClientId = WorkflowExpression.Compile(xClientId, nameof(xClientId), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<FilescanResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/file/jsonupload";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("");
                if (__workflow_xApiKey != null)
                    callPayload.Headers["x-api-key"] = ExpressionConverter.Convert(__workflow_xApiKey);
                callPayload.Headers["x-client-id"] = Convert.ToString("");
                if (__workflow_xClientId != null)
                    callPayload.Headers["x-client-id"] = ExpressionConverter.Convert(__workflow_xClientId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FilescanResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "secplugscan")]
        public IBodyWorkflowAction<EmailScanResponse, ApiConnectionActionConfiguration> EmailScan(Expression<Func<string>> xApiKey = null, Expression<Func<string>> xClientId = null, Expression<Func<EmailScanInput>> body = null)
        {
            var __workflow_xApiKey = WorkflowExpression.Compile(xApiKey, nameof(xApiKey), required: false);
            var __workflow_xClientId = WorkflowExpression.Compile(xClientId, nameof(xClientId), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<EmailScanResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/email/jsonupload";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xApiKey != null)
                    callPayload.Headers["x-api-key"] = ExpressionConverter.Convert(__workflow_xApiKey);
                if (__workflow_xClientId != null)
                    callPayload.Headers["x-client-id"] = ExpressionConverter.Convert(__workflow_xClientId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<EmailScanResponse>(callPayload);
            });
        }
    }

    public class SecplugscanTriggers([ConnectionName] string connectionId)
    {
    }

    public class FilescanResponse
    {
        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("threat_object")]
        public FilescanResponseThreatObjectType ThreatObject { get; set; }

        [JsonProperty("scan_context")]
        public FilescanResponseScanContextType ScanContext { get; set; }

        [JsonProperty("datetime")]
        public double Datetime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("api_key")]
        public string ApiKey { get; set; }

        [JsonProperty("meta_data")]
        public FilescanResponseMetaDataType MetaData { get; set; }

        [JsonProperty("report_id")]
        public string ReportId { get; set; }

        [JsonProperty("verdict")]
        public string Verdict { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("user_report_url")]
        public string UserReportUrl { get; set; }
    }

    public class FilescanResponseThreatObjectType
    {
        [JsonProperty("sha256")]
        public string Sha256 { get; set; }
    }

    public class FilescanResponseScanContextType
    {
        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("client_id")]
        public string ClientId { get; set; }
    }

    public class FilescanResponseMetaDataType
    {
        [JsonProperty("plugin_info")]
        public FilescanResponseMetaDataTypePluginInfoType PluginInfo { get; set; }

        [JsonProperty("capability")]
        public string Capability { get; set; }

        [JsonProperty("vendor_info")]
        public FilescanResponseMetaDataTypeVendorInfoType VendorInfo { get; set; }
    }

    public class FilescanResponseMetaDataTypePluginInfoType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class FilescanResponseMetaDataTypeVendorInfoType
    {
        [JsonProperty("vendor_config_name")]
        public string VendorConfigName { get; set; }

        [JsonProperty("entitlement_level")]
        public string EntitlementLevel { get; set; }

        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("params")]
        public JToken Params { get; set; }
    }

    public class FilescanInput
    {
        [JsonProperty("filename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Filename { get; set; }

        [JsonProperty("filetype", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Filetype { get; set; } = "text/plain";

        [JsonProperty("cte", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Cte { get; set; } = "base64";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Data { get; set; }
    }

    public class EmailScanResponse
    {
        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("threat_object")]
        public EmailScanResponseThreatObjectType ThreatObject { get; set; }

        [JsonProperty("scan_context")]
        public EmailScanResponseScanContextType ScanContext { get; set; }

        [JsonProperty("datetime")]
        public double Datetime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("api_key")]
        public string ApiKey { get; set; }

        [JsonProperty("meta_data")]
        public EmailScanResponseMetaDataType MetaData { get; set; }

        [JsonProperty("report_id")]
        public string ReportId { get; set; }

        [JsonProperty("verdict")]
        public string Verdict { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("user_report_url")]
        public string UserReportUrl { get; set; }
    }

    public class EmailScanResponseThreatObjectType
    {
        [JsonProperty("email_id")]
        public string EmailId { get; set; }
    }

    public class EmailScanResponseScanContextType
    {
        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("client_id")]
        public string ClientId { get; set; }
    }

    public class EmailScanResponseMetaDataType
    {
        [JsonProperty("plugin_info")]
        public EmailScanResponseMetaDataTypePluginInfoType PluginInfo { get; set; }

        [JsonProperty("capability")]
        public string Capability { get; set; }

        [JsonProperty("vendor_info")]
        public EmailScanResponseMetaDataTypeVendorInfoType VendorInfo { get; set; }
    }

    public class EmailScanResponseMetaDataTypePluginInfoType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class EmailScanResponseMetaDataTypeVendorInfoType
    {
        [JsonProperty("vendor_config_name")]
        public string VendorConfigName { get; set; }

        [JsonProperty("entitlement_level")]
        public string EntitlementLevel { get; set; }

        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        [JsonProperty("credits")]
        public int Credits { get; set; }

        [JsonProperty("params")]
        public JToken Params { get; set; }
    }

    public class EmailScanInput
    {
        [JsonProperty("filename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Filename { get; set; }

        [JsonProperty("cte", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Cte { get; set; } = "base64";

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Data { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Secplugscan;

    public partial class WorkflowManagedActions
    {
        public SecplugscanActions Secplugscan(string connectionId) => new SecplugscanActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SecplugscanTriggers Secplugscan(string connectionId) => new SecplugscanTriggers(connectionId);
    }
}