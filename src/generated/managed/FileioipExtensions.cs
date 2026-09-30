//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fileioip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FileioipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fileioip")]
        public IBodyWorkflowAction<FileListResponse> FileList([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null)
        {
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<FileListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fileioip")]
        public IBodyWorkflowAction<FileUploadResponse> FileUpload([WorkflowExpression] Func<string> bodyFile = null, [WorkflowExpression] Func<string> bodyexpires = null, [WorkflowExpression] Func<int> bodymaxDownloads = null, [WorkflowExpression] Func<bool> bodyautoDelete = null)
        {
            SourceExpression.Validate(bodyFile, nameof(bodyFile), required: false);
            SourceExpression.Validate(bodyexpires, nameof(bodyexpires), required: false);
            SourceExpression.Validate(bodymaxDownloads, nameof(bodymaxDownloads), required: false);
            SourceExpression.Validate(bodyautoDelete, nameof(bodyautoDelete), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyFile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyFile);
                    bodypropCount++;
                }

                if (bodyexpires != null)
                {
                    body["expires"] = SourceExpressionConverter.ConvertToken(bodyexpires);
                    bodypropCount++;
                }

                if (bodymaxDownloads != null)
                {
                    body["maxDownloads"] = SourceExpressionConverter.ConvertToken(bodymaxDownloads);
                    bodypropCount++;
                }

                if (bodyautoDelete != null)
                {
                    body["autoDelete"] = SourceExpressionConverter.ConvertToken(bodyautoDelete);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FileUploadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fileioip")]
        public IBodyWorkflowAction<FileUpdateResponse> FileUpdate([WorkflowExpression] Func<string> key, [WorkflowExpression] Func<string> bodyFile = null, [WorkflowExpression] Func<string> bodyexpires = null, [WorkflowExpression] Func<int> bodymaxDownloads = null, [WorkflowExpression] Func<bool> bodyautoDelete = null)
        {
            SourceExpression.Validate(key, nameof(key), required: true);
            SourceExpression.Validate(bodyFile, nameof(bodyFile), required: false);
            SourceExpression.Validate(bodyexpires, nameof(bodyexpires), required: false);
            SourceExpression.Validate(bodymaxDownloads, nameof(bodymaxDownloads), required: false);
            SourceExpression.Validate(bodyautoDelete, nameof(bodyautoDelete), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(key, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyFile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyFile);
                    bodypropCount++;
                }

                if (bodyexpires != null)
                {
                    body["expires"] = SourceExpressionConverter.ConvertToken(bodyexpires);
                    bodypropCount++;
                }

                if (bodymaxDownloads != null)
                {
                    body["maxDownloads"] = SourceExpressionConverter.ConvertToken(bodymaxDownloads);
                    bodypropCount++;
                }

                if (bodyautoDelete != null)
                {
                    body["autoDelete"] = SourceExpressionConverter.ConvertToken(bodyautoDelete);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FileUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fileioip")]
        public IBodyWorkflowAction<FileDeleteResponse> FileDelete([WorkflowExpression] Func<string> key)
        {
            SourceExpression.Validate(key, nameof(key), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(key, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FileDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fileioip")]
        public IBodyWorkflowAction<MeResponse> Me()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MeResponse>(BuildSourceInput);
        }
    }

    public class FileioipTriggers([ConnectionName] string connectionId)
    {
    }

    public class FileListResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("nodes")]
        public FileListResponseNodesTypeItem[] Nodes { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("screeningStatus")]
        public string ScreeningStatus { get; set; }
    }

    public class FileListResponseNodesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("nodeType")]
        public string NodeType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("downloads")]
        public int Downloads { get; set; }

        [JsonProperty("maxDownloads")]
        public int MaxDownloads { get; set; }

        [JsonProperty("autoDelete")]
        public bool AutoDelete { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("screeningStatus")]
        public string ScreeningStatus { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }
    }

    public class FileUploadResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("nodeType")]
        public string NodeType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("downloads")]
        public int Downloads { get; set; }

        [JsonProperty("maxDownloads")]
        public int MaxDownloads { get; set; }

        [JsonProperty("autoDelete")]
        public bool AutoDelete { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("screeningStatus")]
        public string ScreeningStatus { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }
    }

    public class FileUpdateResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("expiry")]
        public string Expiry { get; set; }

        [JsonProperty("downloads")]
        public int Downloads { get; set; }

        [JsonProperty("maxDownloads")]
        public int MaxDownloads { get; set; }

        [JsonProperty("autoDelete")]
        public bool AutoDelete { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }
    }

    public class FileDeleteResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }
    }

    public class MeResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("planId")]
        public int PlanId { get; set; }

        [JsonProperty("maxUploadBytes")]
        public int MaxUploadBytes { get; set; }

        [JsonProperty("maxStorageBytes")]
        public int MaxStorageBytes { get; set; }

        [JsonProperty("usedStorageBytes")]
        public int UsedStorageBytes { get; set; }

        [JsonProperty("rateLimit")]
        public int RateLimit { get; set; }

        [JsonProperty("customDomain")]
        public string CustomDomain { get; set; }

        [JsonProperty("directDownload")]
        public string DirectDownload { get; set; }

        [JsonProperty("paymentCustomerId")]
        public string PaymentCustomerId { get; set; }

        [JsonProperty("paymentSubscriptionId")]
        public string PaymentSubscriptionId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Fileioip;

    public partial class WorkflowManagedActions
    {
        public FileioipActions Fileioip(string connectionId) => new FileioipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FileioipTriggers Fileioip(string connectionId) => new FileioipTriggers(connectionId);
    }
}