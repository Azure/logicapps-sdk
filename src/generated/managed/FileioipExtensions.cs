//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fileioip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FileioipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fileioip")]
        public IBodyWorkflowAction<FileListResponse> FileList([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null)
        {
            var apiCallPath = "/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            return new ApiConnectionAction<FileListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fileioip")]
        public IBodyWorkflowAction<FileUploadResponse> FileUpload([WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyexpires = null, [WorkflowExpression] Func<int> bodymaxDownloads = null, [WorkflowExpression] Func<bool> bodyautoDelete = null)
        {
            var apiCallPath = "/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfile != null)
            {
                body["file"] = ExpressionConverter.ConvertO(bodyfile);
                bodypropCount++;
            }

            if (bodyexpires != null)
            {
                body["expires"] = ExpressionConverter.ConvertO(bodyexpires);
                bodypropCount++;
            }

            if (bodymaxDownloads != null)
            {
                body["maxDownloads"] = ExpressionConverter.ConvertO(bodymaxDownloads);
                bodypropCount++;
            }

            if (bodyautoDelete != null)
            {
                body["autoDelete"] = ExpressionConverter.ConvertO(bodyautoDelete);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FileUploadResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fileioip")]
        public IBodyWorkflowAction<FileUpdateResponse> FileUpdate([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> key, [WorkflowExpression] Func<string> bodyfile = null, [WorkflowExpression] Func<string> bodyexpires = null, [WorkflowExpression] Func<int> bodymaxDownloads = null, [WorkflowExpression] Func<bool> bodyautoDelete = null)
        {
            var apiCallPath = String.Format("/{0}", ExpressionConverter.ConvertWithUrlEncoding(key, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfile != null)
            {
                body["file"] = ExpressionConverter.ConvertO(bodyfile);
                bodypropCount++;
            }

            if (bodyexpires != null)
            {
                body["expires"] = ExpressionConverter.ConvertO(bodyexpires);
                bodypropCount++;
            }

            if (bodymaxDownloads != null)
            {
                body["maxDownloads"] = ExpressionConverter.ConvertO(bodymaxDownloads);
                bodypropCount++;
            }

            if (bodyautoDelete != null)
            {
                body["autoDelete"] = ExpressionConverter.ConvertO(bodyautoDelete);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FileUpdateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fileioip")]
        public IBodyWorkflowAction<FileDeleteResponse> FileDelete([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> key)
        {
            var apiCallPath = String.Format("/{0}", ExpressionConverter.ConvertWithUrlEncoding(key, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FileDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fileioip")]
        public IBodyWorkflowAction<MeResponse> Me()
        {
            var apiCallPath = "/me";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MeResponse>(callPayload);
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