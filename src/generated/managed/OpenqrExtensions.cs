//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openqr
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpenqrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openqr")]
        public IBodyWorkflowAction<FolderUpdateResponse, ApiConnectionActionConfiguration> FolderUpdate(Expression<Func<string>> folderId, Expression<Func<FolderBodyInput>> body = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<FolderUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/folders/{0}", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FolderUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openqr")]
        public IBodyWorkflowAction<FoldersGetResponse, ApiConnectionActionConfiguration> FoldersGet()
        {
            return new DeferredBodyAction<FoldersGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/folders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FoldersGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openqr")]
        public IBodyWorkflowAction<FolderResponse, ApiConnectionActionConfiguration> Folder(Expression<Func<FolderBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<FolderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/folders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openqr")]
        public IBodyWorkflowAction<QRsGetResponse, ApiConnectionActionConfiguration> QRsGet()
        {
            return new DeferredBodyAction<QRsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/qr-codes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<QRsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openqr")]
        public IBodyWorkflowAction<QRResponse, ApiConnectionActionConfiguration> QR(Expression<Func<QRBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<QRResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/qr-codes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<QRResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openqr")]
        public IBodyWorkflowAction<QRGetResponse, ApiConnectionActionConfiguration> QRGet(Expression<Func<string>> qrCodeId)
        {
            var __workflow_qrCodeId = WorkflowExpression.Compile(qrCodeId, nameof(qrCodeId), required: true);
            return new DeferredBodyAction<QRGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/qr-codes/{0}", __workflow_qrCodeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<QRGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openqr")]
        public IBodyWorkflowAction<QRUpdateResponse, ApiConnectionActionConfiguration> QRUpdate(Expression<Func<string>> qrCodeId, Expression<Func<QRUpdateBodyInput>> body = null)
        {
            var __workflow_qrCodeId = WorkflowExpression.Compile(qrCodeId, nameof(qrCodeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<QRUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/qr-codes/{0}", __workflow_qrCodeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<QRUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openqr")]
        public IBodyWorkflowAction<FilesGetResponse, ApiConnectionActionConfiguration> FilesGet()
        {
            return new DeferredBodyAction<FilesGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/files";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FilesGetResponse>(callPayload);
            });
        }
    }

    public class OpenqrTriggers([ConnectionName] string connectionId)
    {
    }

    public class FolderUpdateResponse
    {
        [JsonProperty("data")]
        public FolderUpdateResponseDataType Data { get; set; }
    }

    public class FolderUpdateResponseDataType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class FolderBodyInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
    }

    public class FoldersGetResponse
    {
        [JsonProperty("data")]
        public FoldersGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("links")]
        public FoldersGetResponseLinksType Links { get; set; }

        [JsonProperty("meta")]
        public FoldersGetResponseMetaType Meta { get; set; }
    }

    public class FoldersGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class FoldersGetResponseLinksType
    {
        [JsonProperty("first")]
        public int First { get; set; }

        [JsonProperty("last")]
        public int Last { get; set; }

        [JsonProperty("prev")]
        public string Prev { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }

    public class FoldersGetResponseMetaType
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("next_cursor")]
        public string NextCursor { get; set; }

        [JsonProperty("prev_cursor")]
        public string PrevCursor { get; set; }
    }

    public class FolderResponse
    {
        [JsonProperty("data")]
        public FolderResponseDataType Data { get; set; }
    }

    public class FolderResponseDataType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class QRsGetResponse
    {
        [JsonProperty("data")]
        public QRsGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("links")]
        public QRsGetResponseLinksType Links { get; set; }

        [JsonProperty("meta")]
        public QRsGetResponseMetaType Meta { get; set; }
    }

    public class QRsGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("dynamic")]
        public bool Dynamic { get; set; }

        [JsonProperty("qr_code_folder_id")]
        public int QrCodeFolderId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class QRsGetResponseLinksType
    {
        [JsonProperty("first")]
        public int First { get; set; }

        [JsonProperty("last")]
        public int Last { get; set; }

        [JsonProperty("prev")]
        public string Prev { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }

    public class QRsGetResponseMetaType
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("next_cursor")]
        public string NextCursor { get; set; }

        [JsonProperty("prev_cursor")]
        public string PrevCursor { get; set; }
    }

    public class QRResponse
    {
        [JsonProperty("data")]
        public QRResponseDataType Data { get; set; }
    }

    public class QRResponseDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("dynamic")]
        public bool Dynamic { get; set; }

        [JsonProperty("qr_code_folder_id")]
        public int QrCodeFolderId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class QRBodyInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputTypeType Type { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Openqr.BodyInputTypeType.Url;

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public QRBodyInputDataType Data { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputTypeType
    {
        [EnumMember(Value = "url")]
        Url,
        [EnumMember(Value = "call")]
        Call,
        [EnumMember(Value = "call_static")]
        CallStatic,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "email_static")]
        EmailStatic,
        [EnumMember(Value = "event")]
        Event,
        [EnumMember(Value = "event_static")]
        EventStatic,
        [EnumMember(Value = "geo")]
        Geo,
        [EnumMember(Value = "geo_static")]
        GeoStatic,
        [EnumMember(Value = "sms")]
        Sms,
        [EnumMember(Value = "sms_static")]
        SmsStatic,
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "text_static")]
        TextStatic,
        [EnumMember(Value = "url_static")]
        UrlStatic,
        [EnumMember(Value = "vcard")]
        Vcard,
        [EnumMember(Value = "vcard_static")]
        VcardStatic,
        [EnumMember(Value = "wifi")]
        Wifi,
        [EnumMember(Value = "wifi_static")]
        WifiStatic
    }

    public class QRBodyInputDataType
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }
    }

    public class QRGetResponse
    {
        [JsonProperty("data")]
        public QRGetResponseDataType Data { get; set; }
    }

    public class QRGetResponseDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("dynamic")]
        public bool Dynamic { get; set; }

        [JsonProperty("qr_code_folder_id")]
        public int QrCodeFolderId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class QRUpdateResponse
    {
        [JsonProperty("data")]
        public QRUpdateResponseDataType Data { get; set; }
    }

    public class QRUpdateResponseDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("dynamic")]
        public bool Dynamic { get; set; }

        [JsonProperty("qr_code_folder_id")]
        public int QrCodeFolderId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class QRUpdateBodyInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputTypeType? Type { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Openqr.BodyInputTypeType.Url;

        [JsonProperty("data")]
        public QRUpdateBodyInputDataType Data { get; set; }
    }

    public class QRUpdateBodyInputDataType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class FilesGetResponse
    {
        [JsonProperty("data")]
        public FilesGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("links")]
        public FilesGetResponseLinksType Links { get; set; }

        [JsonProperty("meta")]
        public FilesGetResponseMetaType Meta { get; set; }
    }

    public class FilesGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mime_type")]
        public string MimeType { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }
    }

    public class FilesGetResponseLinksType
    {
        [JsonProperty("first")]
        public int First { get; set; }

        [JsonProperty("last")]
        public int Last { get; set; }

        [JsonProperty("prev")]
        public string Prev { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }

    public class FilesGetResponseMetaType
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("next_cursor")]
        public string NextCursor { get; set; }

        [JsonProperty("prev_cursor")]
        public string PrevCursor { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Openqr;

    public partial class WorkflowManagedActions
    {
        public OpenqrActions Openqr(string connectionId) => new OpenqrActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OpenqrTriggers Openqr(string connectionId) => new OpenqrTriggers(connectionId);
    }
}