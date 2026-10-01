//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Secplugscan
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SecplugscanActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "secplugscan")]
        public IBodyWorkflowAction<FilescanResponse> Filescan([WorkflowExpression] Func<string> bodyfilename, [WorkflowExpression] Func<string> bodydata, [WorkflowExpression] Func<string> xApiKey = null, [WorkflowExpression] Func<string> xClientId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/file/jsonupload";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-api-key"] = Convert.ToString("");
                if (xApiKey != null)
                    callPayload.Headers["x-api-key"] = SourceExpressionConverter.ConvertO(xApiKey);
                callPayload.Headers["x-client-id"] = Convert.ToString("");
                if (xClientId != null)
                    callPayload.Headers["x-client-id"] = SourceExpressionConverter.ConvertO(xClientId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["filename"] = SourceExpressionConverter.ConvertToken(bodyfilename);
                body["filetype"] = "text/plain";
                bodypropCount++;
                body["cte"] = "base64";
                bodypropCount++;
                bodypropCount++;
                body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FilescanResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "secplugscan")]
        public IBodyWorkflowAction<EmailScanResponse> EmailScan([WorkflowExpression] Func<string> bodyfilename, [WorkflowExpression] Func<string> bodydata, [WorkflowExpression] Func<string> xApiKey = null, [WorkflowExpression] Func<string> xClientId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/email/jsonupload";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xApiKey != null)
                    callPayload.Headers["x-api-key"] = SourceExpressionConverter.ConvertO(xApiKey);
                if (xClientId != null)
                    callPayload.Headers["x-client-id"] = SourceExpressionConverter.ConvertO(xClientId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["filename"] = SourceExpressionConverter.ConvertToken(bodyfilename);
                body["cte"] = "base64";
                bodypropCount++;
                bodypropCount++;
                body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<EmailScanResponse>(BuildSourceInput);
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