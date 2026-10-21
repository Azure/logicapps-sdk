//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fileioip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FileioipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fileioip")]
        public IBodyWorkflowAction<FileListResponse> FileList(Expression<Func<string>> search = null, Expression<Func<string>> sort = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<FileListResponse>(() =>
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<FileListResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fileioip")]
        public IBodyWorkflowAction<FileUploadResponse> FileUpload(Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyexpires = null, Expression<Func<int>> bodymaxDownloads = null, Expression<Func<bool>> bodyautoDelete = null)
        {
            var __workflow_bodyfile = WorkflowExpression.Compile(bodyfile, nameof(bodyfile), required: false);
            var __workflow_bodyexpires = WorkflowExpression.Compile(bodyexpires, nameof(bodyexpires), required: false);
            var __workflow_bodymaxDownloads = WorkflowExpression.Compile(bodymaxDownloads, nameof(bodymaxDownloads), required: false);
            var __workflow_bodyautoDelete = WorkflowExpression.Compile(bodyautoDelete, nameof(bodyautoDelete), required: false);
            return new DeferredBodyAction<FileUploadResponse>(() =>
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyfile);
                    bodypropCount++;
                }

                if (__workflow_bodyexpires != null)
                {
                    body["expires"] = ExpressionConverter.ConvertO(__workflow_bodyexpires);
                    bodypropCount++;
                }

                if (__workflow_bodymaxDownloads != null)
                {
                    body["maxDownloads"] = ExpressionConverter.ConvertO(__workflow_bodymaxDownloads);
                    bodypropCount++;
                }

                if (__workflow_bodyautoDelete != null)
                {
                    body["autoDelete"] = ExpressionConverter.ConvertO(__workflow_bodyautoDelete);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FileUploadResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fileioip")]
        public IBodyWorkflowAction<FileUpdateResponse> FileUpdate(Expression<Func<string>> key, Expression<Func<string>> bodyfile = null, Expression<Func<string>> bodyexpires = null, Expression<Func<int>> bodymaxDownloads = null, Expression<Func<bool>> bodyautoDelete = null)
        {
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            var __workflow_bodyfile = WorkflowExpression.Compile(bodyfile, nameof(bodyfile), required: false);
            var __workflow_bodyexpires = WorkflowExpression.Compile(bodyexpires, nameof(bodyexpires), required: false);
            var __workflow_bodymaxDownloads = WorkflowExpression.Compile(bodymaxDownloads, nameof(bodymaxDownloads), required: false);
            var __workflow_bodyautoDelete = WorkflowExpression.Compile(bodyautoDelete, nameof(bodyautoDelete), required: false);
            return new DeferredBodyAction<FileUpdateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}", __workflow_key.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyfile);
                    bodypropCount++;
                }

                if (__workflow_bodyexpires != null)
                {
                    body["expires"] = ExpressionConverter.ConvertO(__workflow_bodyexpires);
                    bodypropCount++;
                }

                if (__workflow_bodymaxDownloads != null)
                {
                    body["maxDownloads"] = ExpressionConverter.ConvertO(__workflow_bodymaxDownloads);
                    bodypropCount++;
                }

                if (__workflow_bodyautoDelete != null)
                {
                    body["autoDelete"] = ExpressionConverter.ConvertO(__workflow_bodyautoDelete);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FileUpdateResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fileioip")]
        public IBodyWorkflowAction<FileDeleteResponse> FileDelete(Expression<Func<string>> key)
        {
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            return new DeferredBodyAction<FileDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}", __workflow_key.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FileDeleteResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
