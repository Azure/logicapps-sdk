//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Xbridgerdocumentmanager
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class XbridgerdocumentmanagerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xbridgerdocumentmanager")]
        public IBodyWorkflowAction<Convert2ModernPageResponse> Convert2ModernPage([WorkflowExpression] Func<string> requestfileContent, [WorkflowExpression] Func<string> requestsiteUrl, [WorkflowExpression] Func<string> requestpageTitle, [WorkflowExpression] Func<string> requestauthor, [WorkflowExpression] Func<string> requestfolderPath = null, [WorkflowExpression] Func<string> requestbannerImageUrl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ConvertWord2ModernPage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["FileContent"] = SourceExpressionConverter.ConvertToken(requestfileContent);
                if (requestfolderPath != null)
                {
                    request["FolderPath"] = SourceExpressionConverter.ConvertToken(requestfolderPath);
                    requestpropCount++;
                }

                requestpropCount++;
                request["SiteUrl"] = SourceExpressionConverter.ConvertToken(requestsiteUrl);
                requestpropCount++;
                request["PageTitle"] = SourceExpressionConverter.ConvertToken(requestpageTitle);
                requestpropCount++;
                request["Author"] = SourceExpressionConverter.ConvertToken(requestauthor);
                if (requestbannerImageUrl != null)
                {
                    request["BannerImageUrl"] = SourceExpressionConverter.ConvertToken(requestbannerImageUrl);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Convert2ModernPageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xbridgerdocumentmanager")]
        public IBodyWorkflowAction<Convert2NonModernPageResponse> Convert2NonModernPage([WorkflowExpression] Func<string> requestfileContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ConvertWord2StaticHMTLPage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["FileContent"] = SourceExpressionConverter.ConvertToken(requestfileContent);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Convert2NonModernPageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xbridgerdocumentmanager")]
        public IBodyWorkflowAction<ExportList2PDFResponse> ExportList2PDF([WorkflowExpression] Func<string> requestdocumentTitle, [WorkflowExpression] Func<string> requestdata, [WorkflowExpression] Func<string> requestfieldArray)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Export2PDFFromFlow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["DocumentTitle"] = SourceExpressionConverter.ConvertToken(requestdocumentTitle);
                requestpropCount++;
                request["Data"] = SourceExpressionConverter.ConvertToken(requestdata);
                requestpropCount++;
                request["FieldArray"] = SourceExpressionConverter.ConvertToken(requestfieldArray);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExportList2PDFResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xbridgerdocumentmanager")]
        public IBodyWorkflowAction<ExtractWordImagesResponse> ExtractWordImages([WorkflowExpression] Func<string> requestfileContent)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Extractworddocimages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["FileContent"] = SourceExpressionConverter.ConvertToken(requestfileContent);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExtractWordImagesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xbridgerdocumentmanager")]
        public IBodyWorkflowAction<PDFMergeResponse> PDFMerge([WorkflowExpression] Func<string> requestfileContentArray)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/PDFMerge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["FileContentArray"] = SourceExpressionConverter.ConvertToken(requestfileContentArray);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PDFMergeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xbridgerdocumentmanager")]
        public IBodyWorkflowAction<WordMergeResponse> WordMerge([WorkflowExpression] Func<string> requestfileContentArray)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/WordMerge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["FileContentArray"] = SourceExpressionConverter.ConvertToken(requestfileContentArray);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WordMergeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "xbridgerdocumentmanager")]
        public IBodyWorkflowAction<WordtopdfResponse> Wordtopdf([WorkflowExpression] Func<string> requestfileContent, [WorkflowExpression] Func<string> requestfileName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Wordtopdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["FileContent"] = SourceExpressionConverter.ConvertToken(requestfileContent);
                requestpropCount++;
                request["FileName"] = SourceExpressionConverter.ConvertToken(requestfileName);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WordtopdfResponse>(BuildSourceInput);
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