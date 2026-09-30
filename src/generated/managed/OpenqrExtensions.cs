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
        public IBodyWorkflowAction<FolderUpdatePostResponse> FolderUpdate([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> bodyname)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/folders/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FolderUpdatePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openqr")]
        public IBodyWorkflowAction<FoldersGetResponse> FoldersGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/folders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FoldersGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openqr")]
        public IBodyWorkflowAction<FolderPostResponse> Folder([WorkflowExpression] Func<string> bodyname)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/folders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FolderPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openqr")]
        public IBodyWorkflowAction<QRsGetResponse> QRsGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/qr-codes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<QRsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openqr")]
        public IBodyWorkflowAction<QRPostResponse> QR([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodydataurl = null)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodydataurl, nameof(bodydataurl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/qr-codes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (bodydataurl != null)
                {
                    dataObject["url"] = SourceExpressionConverter.ConvertToken(bodydataurl);
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
                return callPayload;
            }

            return new ApiConnectionAction<QRPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openqr")]
        public IBodyWorkflowAction<QRGetResponse> QRGet([WorkflowExpression] Func<string> qrCodeId)
        {
            SourceExpression.Validate(qrCodeId, nameof(qrCodeId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/qr-codes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(qrCodeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<QRGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openqr")]
        public IBodyWorkflowAction<QRUpdatePostResponse> QRUpdate([WorkflowExpression] Func<string> qrCodeId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<bodytypeInput> bodytype = null, [WorkflowExpression] Func<string> bodydataurl = null)
        {
            SourceExpression.Validate(qrCodeId, nameof(qrCodeId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodydataurl, nameof(bodydataurl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/qr-codes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(qrCodeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    if (bodytype != null)
                    {
                        body["type"] = SourceExpressionConverter.Convert(bodytype);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["type"] = "url";
                    bodypropCount++;
                }

                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (bodydataurl != null)
                {
                    dataObject["url"] = SourceExpressionConverter.ConvertToken(bodydataurl);
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
                return callPayload;
            }

            return new ApiConnectionAction<QRUpdatePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openqr")]
        public IBodyWorkflowAction<FilesGetResponse> FilesGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/files";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FilesGetResponse>(BuildSourceInput);
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