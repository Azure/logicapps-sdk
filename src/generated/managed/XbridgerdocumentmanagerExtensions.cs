//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Xbridgerdocumentmanager
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class XbridgerdocumentmanagerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xbridgerdocumentmanager")]
        public IBodyWorkflowAction<Convert2ModernPageResponse> Convert2ModernPage([WorkflowExpression] Func<string> requestfileContent, [WorkflowExpression] Func<string> requestsiteUrl, [WorkflowExpression] Func<string> requestpageTitle, [WorkflowExpression] Func<string> requestauthor, [WorkflowExpression] Func<string> requestfolderPath = null, [WorkflowExpression] Func<string> requestbannerImageUrl = null)
        {
            var apiCallPath = "/api/ConvertWord2ModernPage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["FileContent"] = ExpressionConverter.ConvertO(requestfileContent);
            if (requestfolderPath != null)
            {
                request["FolderPath"] = ExpressionConverter.ConvertO(requestfolderPath);
                requestpropCount++;
            }

            requestpropCount++;
            request["SiteUrl"] = ExpressionConverter.ConvertO(requestsiteUrl);
            requestpropCount++;
            request["PageTitle"] = ExpressionConverter.ConvertO(requestpageTitle);
            requestpropCount++;
            request["Author"] = ExpressionConverter.ConvertO(requestauthor);
            if (requestbannerImageUrl != null)
            {
                request["BannerImageUrl"] = ExpressionConverter.ConvertO(requestbannerImageUrl);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<Convert2ModernPageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xbridgerdocumentmanager")]
        public IBodyWorkflowAction<Convert2NonModernPageResponse> Convert2NonModernPage([WorkflowExpression] Func<string> requestfileContent)
        {
            var apiCallPath = "/api/ConvertWord2StaticHMTLPage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["FileContent"] = ExpressionConverter.ConvertO(requestfileContent);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<Convert2NonModernPageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xbridgerdocumentmanager")]
        public IBodyWorkflowAction<ExportList2PDFResponse> ExportList2PDF([WorkflowExpression] Func<string> requestdocumentTitle, [WorkflowExpression] Func<string> requestdata, [WorkflowExpression] Func<string> requestfieldArray)
        {
            var apiCallPath = "/api/Export2PDFFromFlow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["DocumentTitle"] = ExpressionConverter.ConvertO(requestdocumentTitle);
            requestpropCount++;
            request["Data"] = ExpressionConverter.ConvertO(requestdata);
            requestpropCount++;
            request["FieldArray"] = ExpressionConverter.ConvertO(requestfieldArray);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<ExportList2PDFResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xbridgerdocumentmanager")]
        public IBodyWorkflowAction<ExtractWordImagesResponse> ExtractWordImages([WorkflowExpression] Func<string> requestfileContent)
        {
            var apiCallPath = "/api/Extractworddocimages";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["FileContent"] = ExpressionConverter.ConvertO(requestfileContent);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<ExtractWordImagesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xbridgerdocumentmanager")]
        public IBodyWorkflowAction<PDFMergeResponse> PDFMerge([WorkflowExpression] Func<string> requestfileContentArray)
        {
            var apiCallPath = "/api/PDFMerge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["FileContentArray"] = ExpressionConverter.ConvertO(requestfileContentArray);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<PDFMergeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xbridgerdocumentmanager")]
        public IBodyWorkflowAction<WordMergeResponse> WordMerge([WorkflowExpression] Func<string> requestfileContentArray)
        {
            var apiCallPath = "/api/WordMerge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["FileContentArray"] = ExpressionConverter.ConvertO(requestfileContentArray);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<WordMergeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xbridgerdocumentmanager")]
        public IBodyWorkflowAction<WordtopdfResponse> Wordtopdf([WorkflowExpression] Func<string> requestfileContent, [WorkflowExpression] Func<string> requestfileName)
        {
            var apiCallPath = "/api/Wordtopdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["FileContent"] = ExpressionConverter.ConvertO(requestfileContent);
            requestpropCount++;
            request["FileName"] = ExpressionConverter.ConvertO(requestfileName);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<WordtopdfResponse>(callPayload);
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