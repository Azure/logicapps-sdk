//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Xbridgerdocumentmanager
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class XbridgerdocumentmanagerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xbridgerdocumentmanager")]
        public IBodyWorkflowAction<Convert2ModernPageResponse> Convert2ModernPage(Expression<Func<string>> requestfileContent, Expression<Func<string>> requestsiteUrl, Expression<Func<string>> requestpageTitle, Expression<Func<string>> requestauthor, Expression<Func<string>> requestfolderPath = null, Expression<Func<string>> requestbannerImageUrl = null)
        {
            var __workflow_requestfileContent = requestfileContent == null ? null : WorkflowExpression.Compile(requestfileContent);
            WorkflowExpression.Validate(__workflow_requestfileContent, nameof(requestfileContent), required: true);
            var __workflow_requestsiteUrl = requestsiteUrl == null ? null : WorkflowExpression.Compile(requestsiteUrl);
            WorkflowExpression.Validate(__workflow_requestsiteUrl, nameof(requestsiteUrl), required: true);
            var __workflow_requestpageTitle = requestpageTitle == null ? null : WorkflowExpression.Compile(requestpageTitle);
            WorkflowExpression.Validate(__workflow_requestpageTitle, nameof(requestpageTitle), required: true);
            var __workflow_requestauthor = requestauthor == null ? null : WorkflowExpression.Compile(requestauthor);
            WorkflowExpression.Validate(__workflow_requestauthor, nameof(requestauthor), required: true);
            var __workflow_requestfolderPath = requestfolderPath == null ? null : WorkflowExpression.Compile(requestfolderPath);
            WorkflowExpression.Validate(__workflow_requestfolderPath, nameof(requestfolderPath), required: false);
            var __workflow_requestbannerImageUrl = requestbannerImageUrl == null ? null : WorkflowExpression.Compile(requestbannerImageUrl);
            WorkflowExpression.Validate(__workflow_requestbannerImageUrl, nameof(requestbannerImageUrl), required: false);
            return new DeferredBodyAction<Convert2ModernPageResponse>(() =>
            {
                var apiCallPath = "/api/ConvertWord2ModernPage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["FileContent"] = ExpressionConverter.ConvertO(__workflow_requestfileContent);
                if (__workflow_requestfolderPath != null)
                {
                    request["FolderPath"] = ExpressionConverter.ConvertO(__workflow_requestfolderPath);
                    requestpropCount++;
                }

                requestpropCount++;
                request["SiteUrl"] = ExpressionConverter.ConvertO(__workflow_requestsiteUrl);
                requestpropCount++;
                request["PageTitle"] = ExpressionConverter.ConvertO(__workflow_requestpageTitle);
                requestpropCount++;
                request["Author"] = ExpressionConverter.ConvertO(__workflow_requestauthor);
                if (__workflow_requestbannerImageUrl != null)
                {
                    request["BannerImageUrl"] = ExpressionConverter.ConvertO(__workflow_requestbannerImageUrl);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<Convert2ModernPageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xbridgerdocumentmanager")]
        public IBodyWorkflowAction<Convert2NonModernPageResponse> Convert2NonModernPage(Expression<Func<string>> requestfileContent)
        {
            var __workflow_requestfileContent = requestfileContent == null ? null : WorkflowExpression.Compile(requestfileContent);
            WorkflowExpression.Validate(__workflow_requestfileContent, nameof(requestfileContent), required: true);
            return new DeferredBodyAction<Convert2NonModernPageResponse>(() =>
            {
                var apiCallPath = "/api/ConvertWord2StaticHMTLPage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["FileContent"] = ExpressionConverter.ConvertO(__workflow_requestfileContent);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<Convert2NonModernPageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xbridgerdocumentmanager")]
        public IBodyWorkflowAction<ExportList2PDFResponse> ExportList2PDF(Expression<Func<string>> requestdocumentTitle, Expression<Func<string>> requestdata, Expression<Func<string>> requestfieldArray)
        {
            var __workflow_requestdocumentTitle = requestdocumentTitle == null ? null : WorkflowExpression.Compile(requestdocumentTitle);
            WorkflowExpression.Validate(__workflow_requestdocumentTitle, nameof(requestdocumentTitle), required: true);
            var __workflow_requestdata = requestdata == null ? null : WorkflowExpression.Compile(requestdata);
            WorkflowExpression.Validate(__workflow_requestdata, nameof(requestdata), required: true);
            var __workflow_requestfieldArray = requestfieldArray == null ? null : WorkflowExpression.Compile(requestfieldArray);
            WorkflowExpression.Validate(__workflow_requestfieldArray, nameof(requestfieldArray), required: true);
            return new DeferredBodyAction<ExportList2PDFResponse>(() =>
            {
                var apiCallPath = "/api/Export2PDFFromFlow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["DocumentTitle"] = ExpressionConverter.ConvertO(__workflow_requestdocumentTitle);
                requestpropCount++;
                request["Data"] = ExpressionConverter.ConvertO(__workflow_requestdata);
                requestpropCount++;
                request["FieldArray"] = ExpressionConverter.ConvertO(__workflow_requestfieldArray);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<ExportList2PDFResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xbridgerdocumentmanager")]
        public IBodyWorkflowAction<ExtractWordImagesResponse> ExtractWordImages(Expression<Func<string>> requestfileContent)
        {
            var __workflow_requestfileContent = requestfileContent == null ? null : WorkflowExpression.Compile(requestfileContent);
            WorkflowExpression.Validate(__workflow_requestfileContent, nameof(requestfileContent), required: true);
            return new DeferredBodyAction<ExtractWordImagesResponse>(() =>
            {
                var apiCallPath = "/api/Extractworddocimages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["FileContent"] = ExpressionConverter.ConvertO(__workflow_requestfileContent);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<ExtractWordImagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xbridgerdocumentmanager")]
        public IBodyWorkflowAction<PDFMergeResponse> PDFMerge(Expression<Func<string>> requestfileContentArray)
        {
            var __workflow_requestfileContentArray = requestfileContentArray == null ? null : WorkflowExpression.Compile(requestfileContentArray);
            WorkflowExpression.Validate(__workflow_requestfileContentArray, nameof(requestfileContentArray), required: true);
            return new DeferredBodyAction<PDFMergeResponse>(() =>
            {
                var apiCallPath = "/api/PDFMerge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["FileContentArray"] = ExpressionConverter.ConvertO(__workflow_requestfileContentArray);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<PDFMergeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xbridgerdocumentmanager")]
        public IBodyWorkflowAction<WordMergeResponse> WordMerge(Expression<Func<string>> requestfileContentArray)
        {
            var __workflow_requestfileContentArray = requestfileContentArray == null ? null : WorkflowExpression.Compile(requestfileContentArray);
            WorkflowExpression.Validate(__workflow_requestfileContentArray, nameof(requestfileContentArray), required: true);
            return new DeferredBodyAction<WordMergeResponse>(() =>
            {
                var apiCallPath = "/api/WordMerge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["FileContentArray"] = ExpressionConverter.ConvertO(__workflow_requestfileContentArray);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<WordMergeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xbridgerdocumentmanager")]
        public IBodyWorkflowAction<WordtopdfResponse> Wordtopdf(Expression<Func<string>> requestfileContent, Expression<Func<string>> requestfileName)
        {
            var __workflow_requestfileContent = requestfileContent == null ? null : WorkflowExpression.Compile(requestfileContent);
            WorkflowExpression.Validate(__workflow_requestfileContent, nameof(requestfileContent), required: true);
            var __workflow_requestfileName = requestfileName == null ? null : WorkflowExpression.Compile(requestfileName);
            WorkflowExpression.Validate(__workflow_requestfileName, nameof(requestfileName), required: true);
            return new DeferredBodyAction<WordtopdfResponse>(() =>
            {
                var apiCallPath = "/api/Wordtopdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["FileContent"] = ExpressionConverter.ConvertO(__workflow_requestfileContent);
                requestpropCount++;
                request["FileName"] = ExpressionConverter.ConvertO(__workflow_requestfileName);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<WordtopdfResponse>(callPayload);
            });
        }
    }

    public class XbridgerdocumentmanagerTriggers([ConnectionName] string connectionId)
    {
    }

    public class Convert2ModernPageResponse
    {
        public string HTMLString { get; set; }
        public string JSONObject { get; set; }
        public string InstanceId { get; set; }
        public string SiteUrl { get; set; }
    }

    public class Convert2NonModernPageResponse
    {
        public string FileContent { get; set; }
    }

    public class ExportList2PDFResponse
    {
        public string FileContent { get; set; }
    }

    public class ExtractWordImagesResponse
    {
        public ExtractWordImagesResponseValueTypeItem[] Value { get; set; }
    }

    public class ExtractWordImagesResponseValueTypeItem
    {
        public string ImageExtension { get; set; }
        public int ImageCounter { get; set; }
        public string ImageMimeType { get; set; }
        public string ImageContent { get; set; }
    }

    public class PDFMergeResponse
    {
        public string FileContent { get; set; }
    }

    public class WordMergeResponse
    {
        public string FileContent { get; set; }
    }

    public class WordtopdfResponse
    {
        public string FileContent { get; set; }
        public string FileName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Xbridgerdocumentmanager;

    public partial class WorkflowManagedActions
    {
        public XbridgerdocumentmanagerActions Xbridgerdocumentmanager(string connectionId) => new XbridgerdocumentmanagerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public XbridgerdocumentmanagerTriggers Xbridgerdocumentmanager(string connectionId) => new XbridgerdocumentmanagerTriggers(connectionId);
    }
}
