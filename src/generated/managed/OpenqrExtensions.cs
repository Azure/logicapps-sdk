//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openqr
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpenqrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openqr")]
        public IBodyWorkflowAction<FolderUpdatePostResponse> FolderUpdatePost(Expression<Func<string>> folderId, Expression<Func<string>> bodyname)
        {
            var apiCallPath = String.Format("/folders/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FolderUpdatePostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openqr")]
        public IBodyWorkflowAction<FoldersGetResponse> FoldersGet()
        {
            var apiCallPath = "/folders";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FoldersGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openqr")]
        public IBodyWorkflowAction<FolderPostResponse> FolderPost(Expression<Func<string>> bodyname)
        {
            var apiCallPath = "/folders";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FolderPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openqr")]
        public IBodyWorkflowAction<QRsGetResponse> QRsGet()
        {
            var apiCallPath = "/qr-codes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<QRsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openqr")]
        public IBodyWorkflowAction<QRPostResponse> QRPost(Expression<Func<string>> bodyname, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodydataurl = null)
        {
            var apiCallPath = "/qr-codes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            var dataObject = new JObject();
            var dataObjectpropCount = 0;
            if (bodydataurl != null)
            {
                dataObject["url"] = ExpressionConverter.ConvertO(bodydataurl);
                dataObjectpropCount++;
            }

            if (dataObjectpropCount > 0)
            {
                body["data"] = dataObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<QRPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openqr")]
        public IBodyWorkflowAction<QRGetResponse> QRGet(Expression<Func<string>> qrCodeId)
        {
            var apiCallPath = String.Format("/qr-codes/{0}", ExpressionConverter.ConvertWithUrlEncoding(qrCodeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<QRGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openqr")]
        public IBodyWorkflowAction<QRUpdatePostResponse> QRUpdatePost(Expression<Func<string>> qrCodeId, Expression<Func<string>> bodyname = null, Expression<Func<bodytypeInput>> bodytype = null, Expression<Func<string>> bodydataurl = null)
        {
            var apiCallPath = String.Format("/qr-codes/{0}", ExpressionConverter.ConvertWithUrlEncoding(qrCodeId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            var dataObject = new JObject();
            var dataObjectpropCount = 0;
            if (bodydataurl != null)
            {
                dataObject["url"] = ExpressionConverter.ConvertO(bodydataurl);
                dataObjectpropCount++;
            }

            if (dataObjectpropCount > 0)
            {
                body["data"] = dataObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<QRUpdatePostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openqr")]
        public IBodyWorkflowAction<FilesGetResponse> FilesGet()
        {
            var apiCallPath = "/files";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FilesGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openqr")]
        public IBodyWorkflowAction<FilePostResponse> FilePost(Expression<Func<object>> file)
        {
            var apiCallPath = "/files";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FilePostResponse>(callPayload);
        }
    }

    public class OpenqrTriggers([ConnectionName] string connectionId)
    {
    }

    public class FolderUpdatePostResponse
    {
        [JsonProperty("data")]
        public FolderUpdatePostResponseDataType Data { get; set; }
    }

    public class FolderUpdatePostResponseDataType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
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

    public class FolderPostResponse
    {
        [JsonProperty("data")]
        public FolderPostResponseDataType Data { get; set; }
    }

    public class FolderPostResponseDataType
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

    public class QRPostResponse
    {
        [JsonProperty("data")]
        public QRPostResponseDataType Data { get; set; }
    }

    public class QRPostResponseDataType
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

    public enum bodytypeInput
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

    public class QRUpdatePostResponse
    {
        [JsonProperty("data")]
        public QRUpdatePostResponseDataType Data { get; set; }
    }

    public class QRUpdatePostResponseDataType
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

    public class FilePostResponse
    {
        [JsonProperty("data")]
        public FilePostResponseDataType Data { get; set; }
    }

    public class FilePostResponseDataType
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