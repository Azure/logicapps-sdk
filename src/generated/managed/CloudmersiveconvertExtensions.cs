//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersiveconvert
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersiveconvertActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<CreateBlankDocxResponse> EditDocumentDocxCreateBlankDocument([WorkflowExpression] Func<string> inputinitialText = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/create/blank";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputinitialText != null)
                {
                    input["InitialText"] = SourceExpressionConverter.ConvertToken(inputinitialText);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateBlankDocxResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> EditDocumentDocxDeletePages([WorkflowExpression] Func<int> reqConfigendDeletePageNumber = null, [WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null, [WorkflowExpression] Func<int> reqConfigstartDeletePageNumber = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/delete-pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfigendDeletePageNumber != null)
                {
                    reqConfig["EndDeletePageNumber"] = SourceExpressionConverter.ConvertToken(reqConfigendDeletePageNumber);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigstartDeletePageNumber != null)
                {
                    reqConfig["StartDeletePageNumber"] = SourceExpressionConverter.ConvertToken(reqConfigstartDeletePageNumber);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DeleteDocxTableRowResponse> EditDocumentDocxDeleteTableRow([WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null, [WorkflowExpression] Func<string> reqConfigtablePath = null, [WorkflowExpression] Func<int> reqConfigtableRowRowIndex = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/delete-table-row";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigtablePath != null)
                {
                    reqConfig["TablePath"] = SourceExpressionConverter.ConvertToken(reqConfigtablePath);
                    reqConfigpropCount++;
                }

                if (reqConfigtableRowRowIndex != null)
                {
                    reqConfig["TableRowRowIndex"] = SourceExpressionConverter.ConvertToken(reqConfigtableRowRowIndex);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DeleteDocxTableRowResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DeleteDocxTableRowRangeResponse> EditDocumentDocxDeleteTableRowRange([WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null, [WorkflowExpression] Func<string> reqConfigtablePath = null, [WorkflowExpression] Func<int> reqConfigtableRowRowIndexEnd = null, [WorkflowExpression] Func<int> reqConfigtableRowRowIndexStart = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/delete-table-row/range";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigtablePath != null)
                {
                    reqConfig["TablePath"] = SourceExpressionConverter.ConvertToken(reqConfigtablePath);
                    reqConfigpropCount++;
                }

                if (reqConfigtableRowRowIndexEnd != null)
                {
                    reqConfig["TableRowRowIndexEnd"] = SourceExpressionConverter.ConvertToken(reqConfigtableRowRowIndexEnd);
                    reqConfigpropCount++;
                }

                if (reqConfigtableRowRowIndexStart != null)
                {
                    reqConfig["TableRowRowIndexStart"] = SourceExpressionConverter.ConvertToken(reqConfigtableRowRowIndexStart);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DeleteDocxTableRowRangeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxBodyResponse> EditDocumentDocxBody([WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/get-body";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetDocxBodyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxCommentsHierarchicalResponse> EditDocumentDocxGetCommentsHierarchical([WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/get-comments/hierarchical";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetDocxCommentsHierarchicalResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxHeadersAndFootersResponse> EditDocumentDocxGetHeadersAndFooters([WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/get-headers-and-footers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetDocxHeadersAndFootersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxImagesResponse> EditDocumentDocxGetImages([WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/get-images";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetDocxImagesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxPagesResponse> EditDocumentDocxPages([WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/get-pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetDocxPagesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxSectionsResponse> EditDocumentDocxGetSections([WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/get-sections";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetDocxSectionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxStylesResponse> EditDocumentDocxGetStyles([WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/get-styles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetDocxStylesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxTableRowResponse> EditDocumentDocxGetTableRow([WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null, [WorkflowExpression] Func<string> reqConfigtablePath = null, [WorkflowExpression] Func<int> reqConfigtableRowRowIndex = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/get-table-row";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigtablePath != null)
                {
                    reqConfig["TablePath"] = SourceExpressionConverter.ConvertToken(reqConfigtablePath);
                    reqConfigpropCount++;
                }

                if (reqConfigtableRowRowIndex != null)
                {
                    reqConfig["TableRowRowIndex"] = SourceExpressionConverter.ConvertToken(reqConfigtableRowRowIndex);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetDocxTableRowResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxTableByIndexResponse> EditDocumentDocxGetTableByIndex([WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null, [WorkflowExpression] Func<int> reqConfigtableIndex = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/get-table/by-index";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigtableIndex != null)
                {
                    reqConfig["TableIndex"] = SourceExpressionConverter.ConvertToken(reqConfigtableIndex);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetDocxTableByIndexResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxTablesResponse> EditDocumentDocxGetTables([WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/get-tables";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetDocxTablesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<InsertDocxCommentOnParagraphResponse> EditDocumentDocxInsertCommentOnParagraph([WorkflowExpression] Func<string> reqConfigcommentToInsertauthor = null, [WorkflowExpression] Func<string> reqConfigcommentToInsertauthorInitials = null, [WorkflowExpression] Func<string> reqConfigcommentToInsertcommentDate = null, [WorkflowExpression] Func<string> reqConfigcommentToInsertcommentText = null, [WorkflowExpression] Func<bool> reqConfigcommentToInsertdone = null, [WorkflowExpression] Func<bool> reqConfigcommentToInsertisReply = null, [WorkflowExpression] Func<bool> reqConfigcommentToInsertisTopLevel = null, [WorkflowExpression] Func<string> reqConfigcommentToInsertparentCommentPath = null, [WorkflowExpression] Func<string> reqConfigcommentToInsertpath = null, [WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null, [WorkflowExpression] Func<string> reqConfigparagraphPath = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/insert-comment/on/paragraph";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                var commentToInsertObject = new JObject();
                var commentToInsertObjectpropCount = 0;
                if (reqConfigcommentToInsertauthor != null)
                {
                    commentToInsertObject["Author"] = SourceExpressionConverter.ConvertToken(reqConfigcommentToInsertauthor);
                    commentToInsertObjectpropCount++;
                }

                if (reqConfigcommentToInsertauthorInitials != null)
                {
                    commentToInsertObject["AuthorInitials"] = SourceExpressionConverter.ConvertToken(reqConfigcommentToInsertauthorInitials);
                    commentToInsertObjectpropCount++;
                }

                if (reqConfigcommentToInsertcommentDate != null)
                {
                    commentToInsertObject["CommentDate"] = SourceExpressionConverter.ConvertToken(reqConfigcommentToInsertcommentDate);
                    commentToInsertObjectpropCount++;
                }

                if (reqConfigcommentToInsertcommentText != null)
                {
                    commentToInsertObject["CommentText"] = SourceExpressionConverter.ConvertToken(reqConfigcommentToInsertcommentText);
                    commentToInsertObjectpropCount++;
                }

                if (reqConfigcommentToInsertdone != null)
                {
                    commentToInsertObject["Done"] = SourceExpressionConverter.ConvertToken(reqConfigcommentToInsertdone);
                    commentToInsertObjectpropCount++;
                }

                if (reqConfigcommentToInsertisReply != null)
                {
                    commentToInsertObject["IsReply"] = SourceExpressionConverter.ConvertToken(reqConfigcommentToInsertisReply);
                    commentToInsertObjectpropCount++;
                }

                if (reqConfigcommentToInsertisTopLevel != null)
                {
                    commentToInsertObject["IsTopLevel"] = SourceExpressionConverter.ConvertToken(reqConfigcommentToInsertisTopLevel);
                    commentToInsertObjectpropCount++;
                }

                if (reqConfigcommentToInsertparentCommentPath != null)
                {
                    commentToInsertObject["ParentCommentPath"] = SourceExpressionConverter.ConvertToken(reqConfigcommentToInsertparentCommentPath);
                    commentToInsertObjectpropCount++;
                }

                if (reqConfigcommentToInsertpath != null)
                {
                    commentToInsertObject["Path"] = SourceExpressionConverter.ConvertToken(reqConfigcommentToInsertpath);
                    commentToInsertObjectpropCount++;
                }

                if (commentToInsertObjectpropCount > 0)
                {
                    reqConfig["CommentToInsert"] = commentToInsertObject;
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigparagraphPath != null)
                {
                    reqConfig["ParagraphPath"] = SourceExpressionConverter.ConvertToken(reqConfigparagraphPath);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InsertDocxCommentOnParagraphResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DocxInsertImageResponse> EditDocumentDocxInsertImage([WorkflowExpression] Func<int> reqConfigheightInEMUs = null, [WorkflowExpression] Func<string> reqConfigimageToAddimageContentsURL = null, [WorkflowExpression] Func<string> reqConfigimageToAddimageDataContentType = null, [WorkflowExpression] Func<string> reqConfigimageToAddimageDataEmbedId = null, [WorkflowExpression] Func<string> reqConfigimageToAddimageDescription = null, [WorkflowExpression] Func<int> reqConfigimageToAddimageHeight = null, [WorkflowExpression] Func<int> reqConfigimageToAddimageId = null, [WorkflowExpression] Func<string> reqConfigimageToAddimageInternalFileName = null, [WorkflowExpression] Func<string> reqConfigimageToAddimageName = null, [WorkflowExpression] Func<int> reqConfigimageToAddimageWidth = null, [WorkflowExpression] Func<bool> reqConfigimageToAddinlineWithText = null, [WorkflowExpression] Func<string> reqConfigimageToAddpath = null, [WorkflowExpression] Func<int> reqConfigimageToAddxOffset = null, [WorkflowExpression] Func<int> reqConfigimageToAddyOffset = null, [WorkflowExpression] Func<string> reqConfiginputDocumentFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputDocumentFileUrl = null, [WorkflowExpression] Func<string> reqConfiginputImageFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputImageFileUrl = null, [WorkflowExpression] Func<string> reqConfiginsertPath = null, [WorkflowExpression] Func<string> reqConfiginsertPlacement = null, [WorkflowExpression] Func<int> reqConfigwidthInEMUs = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/insert-image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfigheightInEMUs != null)
                {
                    reqConfig["HeightInEMUs"] = SourceExpressionConverter.ConvertToken(reqConfigheightInEMUs);
                    reqConfigpropCount++;
                }

                var imageToAddObject = new JObject();
                var imageToAddObjectpropCount = 0;
                if (reqConfigimageToAddimageContentsURL != null)
                {
                    imageToAddObject["ImageContentsURL"] = SourceExpressionConverter.ConvertToken(reqConfigimageToAddimageContentsURL);
                    imageToAddObjectpropCount++;
                }

                if (reqConfigimageToAddimageDataContentType != null)
                {
                    imageToAddObject["ImageDataContentType"] = SourceExpressionConverter.ConvertToken(reqConfigimageToAddimageDataContentType);
                    imageToAddObjectpropCount++;
                }

                if (reqConfigimageToAddimageDataEmbedId != null)
                {
                    imageToAddObject["ImageDataEmbedId"] = SourceExpressionConverter.ConvertToken(reqConfigimageToAddimageDataEmbedId);
                    imageToAddObjectpropCount++;
                }

                if (reqConfigimageToAddimageDescription != null)
                {
                    imageToAddObject["ImageDescription"] = SourceExpressionConverter.ConvertToken(reqConfigimageToAddimageDescription);
                    imageToAddObjectpropCount++;
                }

                if (reqConfigimageToAddimageHeight != null)
                {
                    imageToAddObject["ImageHeight"] = SourceExpressionConverter.ConvertToken(reqConfigimageToAddimageHeight);
                    imageToAddObjectpropCount++;
                }

                if (reqConfigimageToAddimageId != null)
                {
                    imageToAddObject["ImageId"] = SourceExpressionConverter.ConvertToken(reqConfigimageToAddimageId);
                    imageToAddObjectpropCount++;
                }

                if (reqConfigimageToAddimageInternalFileName != null)
                {
                    imageToAddObject["ImageInternalFileName"] = SourceExpressionConverter.ConvertToken(reqConfigimageToAddimageInternalFileName);
                    imageToAddObjectpropCount++;
                }

                if (reqConfigimageToAddimageName != null)
                {
                    imageToAddObject["ImageName"] = SourceExpressionConverter.ConvertToken(reqConfigimageToAddimageName);
                    imageToAddObjectpropCount++;
                }

                if (reqConfigimageToAddimageWidth != null)
                {
                    imageToAddObject["ImageWidth"] = SourceExpressionConverter.ConvertToken(reqConfigimageToAddimageWidth);
                    imageToAddObjectpropCount++;
                }

                if (reqConfigimageToAddinlineWithText != null)
                {
                    imageToAddObject["InlineWithText"] = SourceExpressionConverter.ConvertToken(reqConfigimageToAddinlineWithText);
                    imageToAddObjectpropCount++;
                }

                if (reqConfigimageToAddpath != null)
                {
                    imageToAddObject["Path"] = SourceExpressionConverter.ConvertToken(reqConfigimageToAddpath);
                    imageToAddObjectpropCount++;
                }

                if (reqConfigimageToAddxOffset != null)
                {
                    imageToAddObject["XOffset"] = SourceExpressionConverter.ConvertToken(reqConfigimageToAddxOffset);
                    imageToAddObjectpropCount++;
                }

                if (reqConfigimageToAddyOffset != null)
                {
                    imageToAddObject["YOffset"] = SourceExpressionConverter.ConvertToken(reqConfigimageToAddyOffset);
                    imageToAddObjectpropCount++;
                }

                if (imageToAddObjectpropCount > 0)
                {
                    reqConfig["ImageToAdd"] = imageToAddObject;
                    reqConfigpropCount++;
                }

                if (reqConfiginputDocumentFileBytes != null)
                {
                    reqConfig["InputDocumentFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputDocumentFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputDocumentFileUrl != null)
                {
                    reqConfig["InputDocumentFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputDocumentFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfiginputImageFileBytes != null)
                {
                    reqConfig["InputImageFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputImageFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputImageFileUrl != null)
                {
                    reqConfig["InputImageFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputImageFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfiginsertPath != null)
                {
                    reqConfig["InsertPath"] = SourceExpressionConverter.ConvertToken(reqConfiginsertPath);
                    reqConfigpropCount++;
                }

                if (reqConfiginsertPlacement != null)
                {
                    reqConfig["InsertPlacement"] = SourceExpressionConverter.ConvertToken(reqConfiginsertPlacement);
                    reqConfigpropCount++;
                }

                if (reqConfigwidthInEMUs != null)
                {
                    reqConfig["WidthInEMUs"] = SourceExpressionConverter.ConvertToken(reqConfigwidthInEMUs);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DocxInsertImageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<InsertDocxInsertParagraphResponse> EditDocumentDocxInsertParagraph([WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null, [WorkflowExpression] Func<string> reqConfiginsertPath = null, [WorkflowExpression] Func<string> reqConfiginsertPlacement = null, [WorkflowExpression] Func<DocxRun[]> reqConfigparagraphToInsertcontentRuns = null, [WorkflowExpression] Func<int> reqConfigparagraphToInsertparagraphIndex = null, [WorkflowExpression] Func<string> reqConfigparagraphToInsertpath = null, [WorkflowExpression] Func<string> reqConfigparagraphToInsertstyleId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/insert-paragraph";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfiginsertPath != null)
                {
                    reqConfig["InsertPath"] = SourceExpressionConverter.ConvertToken(reqConfiginsertPath);
                    reqConfigpropCount++;
                }

                if (reqConfiginsertPlacement != null)
                {
                    reqConfig["InsertPlacement"] = SourceExpressionConverter.ConvertToken(reqConfiginsertPlacement);
                    reqConfigpropCount++;
                }

                var paragraphToInsertObject = new JObject();
                var paragraphToInsertObjectpropCount = 0;
                if (reqConfigparagraphToInsertcontentRuns != null)
                {
                    paragraphToInsertObject["ContentRuns"] = SourceExpressionConverter.ConvertToken(reqConfigparagraphToInsertcontentRuns);
                    paragraphToInsertObjectpropCount++;
                }

                if (reqConfigparagraphToInsertparagraphIndex != null)
                {
                    paragraphToInsertObject["ParagraphIndex"] = SourceExpressionConverter.ConvertToken(reqConfigparagraphToInsertparagraphIndex);
                    paragraphToInsertObjectpropCount++;
                }

                if (reqConfigparagraphToInsertpath != null)
                {
                    paragraphToInsertObject["Path"] = SourceExpressionConverter.ConvertToken(reqConfigparagraphToInsertpath);
                    paragraphToInsertObjectpropCount++;
                }

                if (reqConfigparagraphToInsertstyleId != null)
                {
                    paragraphToInsertObject["StyleID"] = SourceExpressionConverter.ConvertToken(reqConfigparagraphToInsertstyleId);
                    paragraphToInsertObjectpropCount++;
                }

                if (paragraphToInsertObjectpropCount > 0)
                {
                    reqConfig["ParagraphToInsert"] = paragraphToInsertObject;
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InsertDocxInsertParagraphResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<InsertDocxTablesResponse> EditDocumentDocxInsertTable([WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null, [WorkflowExpression] Func<string> reqConfiginsertPath = null, [WorkflowExpression] Func<string> reqConfiginsertPlacement = null, [WorkflowExpression] Func<string> reqConfigtableToInsertbottomBorderColor = null, [WorkflowExpression] Func<int> reqConfigtableToInsertbottomBorderSize = null, [WorkflowExpression] Func<int> reqConfigtableToInsertbottomBorderSpace = null, [WorkflowExpression] Func<string> reqConfigtableToInsertbottomBorderType = null, [WorkflowExpression] Func<string> reqConfigtableToInsertcellHorizontalBorderColor = null, [WorkflowExpression] Func<int> reqConfigtableToInsertcellHorizontalBorderSize = null, [WorkflowExpression] Func<int> reqConfigtableToInsertcellHorizontalBorderSpace = null, [WorkflowExpression] Func<string> reqConfigtableToInsertcellHorizontalBorderType = null, [WorkflowExpression] Func<string> reqConfigtableToInsertcellVerticalBorderColor = null, [WorkflowExpression] Func<int> reqConfigtableToInsertcellVerticalBorderSize = null, [WorkflowExpression] Func<int> reqConfigtableToInsertcellVerticalBorderSpace = null, [WorkflowExpression] Func<string> reqConfigtableToInsertcellVerticalBorderType = null, [WorkflowExpression] Func<string> reqConfigtableToInsertendBorderColor = null, [WorkflowExpression] Func<int> reqConfigtableToInsertendBorderSize = null, [WorkflowExpression] Func<int> reqConfigtableToInsertendBorderSpace = null, [WorkflowExpression] Func<string> reqConfigtableToInsertendBorderType = null, [WorkflowExpression] Func<string> reqConfigtableToInsertleftBorderColor = null, [WorkflowExpression] Func<int> reqConfigtableToInsertleftBorderSize = null, [WorkflowExpression] Func<int> reqConfigtableToInsertleftBorderSpace = null, [WorkflowExpression] Func<string> reqConfigtableToInsertleftBorderType = null, [WorkflowExpression] Func<string> reqConfigtableToInsertpath = null, [WorkflowExpression] Func<string> reqConfigtableToInsertrightBorderColor = null, [WorkflowExpression] Func<int> reqConfigtableToInsertrightBorderSize = null, [WorkflowExpression] Func<int> reqConfigtableToInsertrightBorderSpace = null, [WorkflowExpression] Func<string> reqConfigtableToInsertrightBorderType = null, [WorkflowExpression] Func<string> reqConfigtableToInsertstartBorderColor = null, [WorkflowExpression] Func<int> reqConfigtableToInsertstartBorderSize = null, [WorkflowExpression] Func<int> reqConfigtableToInsertstartBorderSpace = null, [WorkflowExpression] Func<string> reqConfigtableToInsertstartBorderType = null, [WorkflowExpression] Func<string> reqConfigtableToInserttableId = null, [WorkflowExpression] Func<string> reqConfigtableToInserttableIndentationMode = null, [WorkflowExpression] Func<int> reqConfigtableToInserttableIndentationWidth = null, [WorkflowExpression] Func<DocxTableRow[]> reqConfigtableToInserttableRows = null, [WorkflowExpression] Func<string> reqConfigtableToInserttopBorderColor = null, [WorkflowExpression] Func<int> reqConfigtableToInserttopBorderSize = null, [WorkflowExpression] Func<int> reqConfigtableToInserttopBorderSpace = null, [WorkflowExpression] Func<string> reqConfigtableToInserttopBorderType = null, [WorkflowExpression] Func<string> reqConfigtableToInsertwidth = null, [WorkflowExpression] Func<string> reqConfigtableToInsertwidthType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/insert-table";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfiginsertPath != null)
                {
                    reqConfig["InsertPath"] = SourceExpressionConverter.ConvertToken(reqConfiginsertPath);
                    reqConfigpropCount++;
                }

                if (reqConfiginsertPlacement != null)
                {
                    reqConfig["InsertPlacement"] = SourceExpressionConverter.ConvertToken(reqConfiginsertPlacement);
                    reqConfigpropCount++;
                }

                var tableToInsertObject = new JObject();
                var tableToInsertObjectpropCount = 0;
                if (reqConfigtableToInsertbottomBorderColor != null)
                {
                    tableToInsertObject["BottomBorderColor"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertbottomBorderColor);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertbottomBorderSize != null)
                {
                    tableToInsertObject["BottomBorderSize"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertbottomBorderSize);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertbottomBorderSpace != null)
                {
                    tableToInsertObject["BottomBorderSpace"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertbottomBorderSpace);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertbottomBorderType != null)
                {
                    tableToInsertObject["BottomBorderType"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertbottomBorderType);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertcellHorizontalBorderColor != null)
                {
                    tableToInsertObject["CellHorizontalBorderColor"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertcellHorizontalBorderColor);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertcellHorizontalBorderSize != null)
                {
                    tableToInsertObject["CellHorizontalBorderSize"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertcellHorizontalBorderSize);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertcellHorizontalBorderSpace != null)
                {
                    tableToInsertObject["CellHorizontalBorderSpace"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertcellHorizontalBorderSpace);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertcellHorizontalBorderType != null)
                {
                    tableToInsertObject["CellHorizontalBorderType"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertcellHorizontalBorderType);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertcellVerticalBorderColor != null)
                {
                    tableToInsertObject["CellVerticalBorderColor"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertcellVerticalBorderColor);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertcellVerticalBorderSize != null)
                {
                    tableToInsertObject["CellVerticalBorderSize"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertcellVerticalBorderSize);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertcellVerticalBorderSpace != null)
                {
                    tableToInsertObject["CellVerticalBorderSpace"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertcellVerticalBorderSpace);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertcellVerticalBorderType != null)
                {
                    tableToInsertObject["CellVerticalBorderType"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertcellVerticalBorderType);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertendBorderColor != null)
                {
                    tableToInsertObject["EndBorderColor"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertendBorderColor);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertendBorderSize != null)
                {
                    tableToInsertObject["EndBorderSize"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertendBorderSize);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertendBorderSpace != null)
                {
                    tableToInsertObject["EndBorderSpace"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertendBorderSpace);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertendBorderType != null)
                {
                    tableToInsertObject["EndBorderType"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertendBorderType);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertleftBorderColor != null)
                {
                    tableToInsertObject["LeftBorderColor"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertleftBorderColor);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertleftBorderSize != null)
                {
                    tableToInsertObject["LeftBorderSize"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertleftBorderSize);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertleftBorderSpace != null)
                {
                    tableToInsertObject["LeftBorderSpace"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertleftBorderSpace);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertleftBorderType != null)
                {
                    tableToInsertObject["LeftBorderType"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertleftBorderType);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertpath != null)
                {
                    tableToInsertObject["Path"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertpath);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertrightBorderColor != null)
                {
                    tableToInsertObject["RightBorderColor"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertrightBorderColor);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertrightBorderSize != null)
                {
                    tableToInsertObject["RightBorderSize"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertrightBorderSize);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertrightBorderSpace != null)
                {
                    tableToInsertObject["RightBorderSpace"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertrightBorderSpace);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertrightBorderType != null)
                {
                    tableToInsertObject["RightBorderType"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertrightBorderType);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertstartBorderColor != null)
                {
                    tableToInsertObject["StartBorderColor"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertstartBorderColor);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertstartBorderSize != null)
                {
                    tableToInsertObject["StartBorderSize"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertstartBorderSize);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertstartBorderSpace != null)
                {
                    tableToInsertObject["StartBorderSpace"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertstartBorderSpace);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertstartBorderType != null)
                {
                    tableToInsertObject["StartBorderType"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertstartBorderType);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInserttableId != null)
                {
                    tableToInsertObject["TableID"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInserttableId);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInserttableIndentationMode != null)
                {
                    tableToInsertObject["TableIndentationMode"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInserttableIndentationMode);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInserttableIndentationWidth != null)
                {
                    tableToInsertObject["TableIndentationWidth"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInserttableIndentationWidth);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInserttableRows != null)
                {
                    tableToInsertObject["TableRows"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInserttableRows);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInserttopBorderColor != null)
                {
                    tableToInsertObject["TopBorderColor"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInserttopBorderColor);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInserttopBorderSize != null)
                {
                    tableToInsertObject["TopBorderSize"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInserttopBorderSize);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInserttopBorderSpace != null)
                {
                    tableToInsertObject["TopBorderSpace"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInserttopBorderSpace);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInserttopBorderType != null)
                {
                    tableToInsertObject["TopBorderType"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInserttopBorderType);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertwidth != null)
                {
                    tableToInsertObject["Width"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertwidth);
                    tableToInsertObjectpropCount++;
                }

                if (reqConfigtableToInsertwidthType != null)
                {
                    tableToInsertObject["WidthType"] = SourceExpressionConverter.ConvertToken(reqConfigtableToInsertwidthType);
                    tableToInsertObjectpropCount++;
                }

                if (tableToInsertObjectpropCount > 0)
                {
                    reqConfig["TableToInsert"] = tableToInsertObject;
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InsertDocxTablesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<InsertDocxTableRowResponse> EditDocumentDocxInsertTableRow([WorkflowExpression] Func<string> reqConfigexistingTablePath = null, [WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null, [WorkflowExpression] Func<string> reqConfiginsertPlacement = null, [WorkflowExpression] Func<string> reqConfigrowToInsertpath = null, [WorkflowExpression] Func<DocxTableCell[]> reqConfigrowToInsertrowCells = null, [WorkflowExpression] Func<int> reqConfigrowToInsertrowIndex = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/insert-table-row";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfigexistingTablePath != null)
                {
                    reqConfig["ExistingTablePath"] = SourceExpressionConverter.ConvertToken(reqConfigexistingTablePath);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfiginsertPlacement != null)
                {
                    reqConfig["InsertPlacement"] = SourceExpressionConverter.ConvertToken(reqConfiginsertPlacement);
                    reqConfigpropCount++;
                }

                var rowToInsertObject = new JObject();
                var rowToInsertObjectpropCount = 0;
                if (reqConfigrowToInsertpath != null)
                {
                    rowToInsertObject["Path"] = SourceExpressionConverter.ConvertToken(reqConfigrowToInsertpath);
                    rowToInsertObjectpropCount++;
                }

                if (reqConfigrowToInsertrowCells != null)
                {
                    rowToInsertObject["RowCells"] = SourceExpressionConverter.ConvertToken(reqConfigrowToInsertrowCells);
                    rowToInsertObjectpropCount++;
                }

                if (reqConfigrowToInsertrowIndex != null)
                {
                    rowToInsertObject["RowIndex"] = SourceExpressionConverter.ConvertToken(reqConfigrowToInsertrowIndex);
                    rowToInsertObjectpropCount++;
                }

                if (rowToInsertObjectpropCount > 0)
                {
                    reqConfig["RowToInsert"] = rowToInsertObject;
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InsertDocxTableRowResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<RemoveDocxHeadersAndFootersResponse> EditDocumentDocxRemoveHeadersAndFooters([WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null, [WorkflowExpression] Func<bool> reqConfigremoveFooters = null, [WorkflowExpression] Func<bool> reqConfigremoveHeaders = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/remove-headers-and-footers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigremoveFooters != null)
                {
                    reqConfig["RemoveFooters"] = SourceExpressionConverter.ConvertToken(reqConfigremoveFooters);
                    reqConfigpropCount++;
                }

                if (reqConfigremoveHeaders != null)
                {
                    reqConfig["RemoveHeaders"] = SourceExpressionConverter.ConvertToken(reqConfigremoveHeaders);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RemoveDocxHeadersAndFootersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DocxRemoveObjectResponse> EditDocumentDocxRemoveObject([WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null, [WorkflowExpression] Func<string> reqConfigpathToObjectToRemove = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/remove-object";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigpathToObjectToRemove != null)
                {
                    reqConfig["PathToObjectToRemove"] = SourceExpressionConverter.ConvertToken(reqConfigpathToObjectToRemove);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DocxRemoveObjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> EditDocumentDocxReplace([WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null, [WorkflowExpression] Func<bool> reqConfigmatchCase = null, [WorkflowExpression] Func<string> reqConfigmatchString = null, [WorkflowExpression] Func<string> reqConfigreplaceString = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/replace-all";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigmatchCase != null)
                {
                    reqConfig["MatchCase"] = SourceExpressionConverter.ConvertToken(reqConfigmatchCase);
                    reqConfigpropCount++;
                }

                if (reqConfigmatchString != null)
                {
                    reqConfig["MatchString"] = SourceExpressionConverter.ConvertToken(reqConfigmatchString);
                    reqConfigpropCount++;
                }

                if (reqConfigreplaceString != null)
                {
                    reqConfig["ReplaceString"] = SourceExpressionConverter.ConvertToken(reqConfigreplaceString);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DocxSetFooterResponse> EditDocumentDocxSetFooter([WorkflowExpression] Func<DocxParagraph[]> reqConfigfooterToApplyparagraphs = null, [WorkflowExpression] Func<string> reqConfigfooterToApplypath = null, [WorkflowExpression] Func<DocxSection[]> reqConfigfooterToApplysectionsWithFooter = null, [WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/set-footer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                var footerToApplyObject = new JObject();
                var footerToApplyObjectpropCount = 0;
                if (reqConfigfooterToApplyparagraphs != null)
                {
                    footerToApplyObject["Paragraphs"] = SourceExpressionConverter.ConvertToken(reqConfigfooterToApplyparagraphs);
                    footerToApplyObjectpropCount++;
                }

                if (reqConfigfooterToApplypath != null)
                {
                    footerToApplyObject["Path"] = SourceExpressionConverter.ConvertToken(reqConfigfooterToApplypath);
                    footerToApplyObjectpropCount++;
                }

                if (reqConfigfooterToApplysectionsWithFooter != null)
                {
                    footerToApplyObject["SectionsWithFooter"] = SourceExpressionConverter.ConvertToken(reqConfigfooterToApplysectionsWithFooter);
                    footerToApplyObjectpropCount++;
                }

                if (footerToApplyObjectpropCount > 0)
                {
                    reqConfig["FooterToApply"] = footerToApplyObject;
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DocxSetFooterResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DocxSetFooterResponse> EditDocumentDocxSetFooterAddPageNumber([WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null, [WorkflowExpression] Func<string> reqConfigprependText = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/set-footer/add-page-number";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigprependText != null)
                {
                    reqConfig["PrependText"] = SourceExpressionConverter.ConvertToken(reqConfigprependText);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DocxSetFooterResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DocxSetHeaderResponse> EditDocumentDocxSetHeader([WorkflowExpression] Func<DocxParagraph[]> reqConfigheaderToApplyparagraphs = null, [WorkflowExpression] Func<string> reqConfigheaderToApplypath = null, [WorkflowExpression] Func<DocxSection[]> reqConfigheaderToApplysectionsWithHeader = null, [WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/set-header";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                var headerToApplyObject = new JObject();
                var headerToApplyObjectpropCount = 0;
                if (reqConfigheaderToApplyparagraphs != null)
                {
                    headerToApplyObject["Paragraphs"] = SourceExpressionConverter.ConvertToken(reqConfigheaderToApplyparagraphs);
                    headerToApplyObjectpropCount++;
                }

                if (reqConfigheaderToApplypath != null)
                {
                    headerToApplyObject["Path"] = SourceExpressionConverter.ConvertToken(reqConfigheaderToApplypath);
                    headerToApplyObjectpropCount++;
                }

                if (reqConfigheaderToApplysectionsWithHeader != null)
                {
                    headerToApplyObject["SectionsWithHeader"] = SourceExpressionConverter.ConvertToken(reqConfigheaderToApplysectionsWithHeader);
                    headerToApplyObjectpropCount++;
                }

                if (headerToApplyObjectpropCount > 0)
                {
                    reqConfig["HeaderToApply"] = headerToApplyObject;
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DocxSetHeaderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<UpdateDocxTableCellResponse> EditDocumentDocxUpdateTableCell([WorkflowExpression] Func<int> reqConfigcellToUpdatecellIndex = null, [WorkflowExpression] Func<string> reqConfigcellToUpdatecellShadingColor = null, [WorkflowExpression] Func<string> reqConfigcellToUpdatecellShadingFill = null, [WorkflowExpression] Func<string> reqConfigcellToUpdatecellShadingPattern = null, [WorkflowExpression] Func<string> reqConfigcellToUpdatecellWidth = null, [WorkflowExpression] Func<string> reqConfigcellToUpdatecellWidthMode = null, [WorkflowExpression] Func<DocxParagraph[]> reqConfigcellToUpdateparagraphs = null, [WorkflowExpression] Func<string> reqConfigcellToUpdatepath = null, [WorkflowExpression] Func<string> reqConfigexistingTablePath = null, [WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null, [WorkflowExpression] Func<int> reqConfigtableCellIndex = null, [WorkflowExpression] Func<int> reqConfigtableRowIndex = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/update-table-cell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                var cellToUpdateObject = new JObject();
                var cellToUpdateObjectpropCount = 0;
                if (reqConfigcellToUpdatecellIndex != null)
                {
                    cellToUpdateObject["CellIndex"] = SourceExpressionConverter.ConvertToken(reqConfigcellToUpdatecellIndex);
                    cellToUpdateObjectpropCount++;
                }

                if (reqConfigcellToUpdatecellShadingColor != null)
                {
                    cellToUpdateObject["CellShadingColor"] = SourceExpressionConverter.ConvertToken(reqConfigcellToUpdatecellShadingColor);
                    cellToUpdateObjectpropCount++;
                }

                if (reqConfigcellToUpdatecellShadingFill != null)
                {
                    cellToUpdateObject["CellShadingFill"] = SourceExpressionConverter.ConvertToken(reqConfigcellToUpdatecellShadingFill);
                    cellToUpdateObjectpropCount++;
                }

                if (reqConfigcellToUpdatecellShadingPattern != null)
                {
                    cellToUpdateObject["CellShadingPattern"] = SourceExpressionConverter.ConvertToken(reqConfigcellToUpdatecellShadingPattern);
                    cellToUpdateObjectpropCount++;
                }

                if (reqConfigcellToUpdatecellWidth != null)
                {
                    cellToUpdateObject["CellWidth"] = SourceExpressionConverter.ConvertToken(reqConfigcellToUpdatecellWidth);
                    cellToUpdateObjectpropCount++;
                }

                if (reqConfigcellToUpdatecellWidthMode != null)
                {
                    cellToUpdateObject["CellWidthMode"] = SourceExpressionConverter.ConvertToken(reqConfigcellToUpdatecellWidthMode);
                    cellToUpdateObjectpropCount++;
                }

                if (reqConfigcellToUpdateparagraphs != null)
                {
                    cellToUpdateObject["Paragraphs"] = SourceExpressionConverter.ConvertToken(reqConfigcellToUpdateparagraphs);
                    cellToUpdateObjectpropCount++;
                }

                if (reqConfigcellToUpdatepath != null)
                {
                    cellToUpdateObject["Path"] = SourceExpressionConverter.ConvertToken(reqConfigcellToUpdatepath);
                    cellToUpdateObjectpropCount++;
                }

                if (cellToUpdateObjectpropCount > 0)
                {
                    reqConfig["CellToUpdate"] = cellToUpdateObject;
                    reqConfigpropCount++;
                }

                if (reqConfigexistingTablePath != null)
                {
                    reqConfig["ExistingTablePath"] = SourceExpressionConverter.ConvertToken(reqConfigexistingTablePath);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigtableCellIndex != null)
                {
                    reqConfig["TableCellIndex"] = SourceExpressionConverter.ConvertToken(reqConfigtableCellIndex);
                    reqConfigpropCount++;
                }

                if (reqConfigtableRowIndex != null)
                {
                    reqConfig["TableRowIndex"] = SourceExpressionConverter.ConvertToken(reqConfigtableRowIndex);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateDocxTableCellResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<UpdateDocxTableRowResponse> EditDocumentDocxUpdateTableRow([WorkflowExpression] Func<string> reqConfigexistingTablePath = null, [WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null, [WorkflowExpression] Func<string> reqConfigrowToUpdatepath = null, [WorkflowExpression] Func<DocxTableCell[]> reqConfigrowToUpdaterowCells = null, [WorkflowExpression] Func<int> reqConfigrowToUpdaterowIndex = null, [WorkflowExpression] Func<int> reqConfigtableRowIndex = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/docx/update-table-row";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfigexistingTablePath != null)
                {
                    reqConfig["ExistingTablePath"] = SourceExpressionConverter.ConvertToken(reqConfigexistingTablePath);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                var rowToUpdateObject = new JObject();
                var rowToUpdateObjectpropCount = 0;
                if (reqConfigrowToUpdatepath != null)
                {
                    rowToUpdateObject["Path"] = SourceExpressionConverter.ConvertToken(reqConfigrowToUpdatepath);
                    rowToUpdateObjectpropCount++;
                }

                if (reqConfigrowToUpdaterowCells != null)
                {
                    rowToUpdateObject["RowCells"] = SourceExpressionConverter.ConvertToken(reqConfigrowToUpdaterowCells);
                    rowToUpdateObjectpropCount++;
                }

                if (reqConfigrowToUpdaterowIndex != null)
                {
                    rowToUpdateObject["RowIndex"] = SourceExpressionConverter.ConvertToken(reqConfigrowToUpdaterowIndex);
                    rowToUpdateObjectpropCount++;
                }

                if (rowToUpdateObjectpropCount > 0)
                {
                    reqConfig["RowToUpdate"] = rowToUpdateObject;
                    reqConfigpropCount++;
                }

                if (reqConfigtableRowIndex != null)
                {
                    reqConfig["TableRowIndex"] = SourceExpressionConverter.ConvertToken(reqConfigtableRowIndex);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateDocxTableRowResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> EditDocumentFinishEditing([WorkflowExpression] Func<string> reqConfiginputFileUrl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/finish-editing";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> EditDocumentPptxDeleteSlides([WorkflowExpression] Func<int> reqConfigendDeleteSlideNumber = null, [WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null, [WorkflowExpression] Func<int> reqConfigstartDeleteSlideNumber = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/pptx/delete-slides";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfigendDeleteSlideNumber != null)
                {
                    reqConfig["EndDeleteSlideNumber"] = SourceExpressionConverter.ConvertToken(reqConfigendDeleteSlideNumber);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigstartDeleteSlideNumber != null)
                {
                    reqConfig["StartDeleteSlideNumber"] = SourceExpressionConverter.ConvertToken(reqConfigstartDeleteSlideNumber);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> EditDocumentPptxReplace([WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null, [WorkflowExpression] Func<bool> reqConfigmatchCase = null, [WorkflowExpression] Func<string> reqConfigmatchString = null, [WorkflowExpression] Func<string> reqConfigreplaceString = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/pptx/replace-all";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigmatchCase != null)
                {
                    reqConfig["MatchCase"] = SourceExpressionConverter.ConvertToken(reqConfigmatchCase);
                    reqConfigpropCount++;
                }

                if (reqConfigmatchString != null)
                {
                    reqConfig["MatchString"] = SourceExpressionConverter.ConvertToken(reqConfigmatchString);
                    reqConfigpropCount++;
                }

                if (reqConfigreplaceString != null)
                {
                    reqConfig["ReplaceString"] = SourceExpressionConverter.ConvertToken(reqConfigreplaceString);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<ClearXlsxCellResponse> EditDocumentXlsxClearCellByIndex([WorkflowExpression] Func<int> inputcellIndex = null, [WorkflowExpression] Func<string> inputinputFileBytes = null, [WorkflowExpression] Func<string> inputinputFileUrl = null, [WorkflowExpression] Func<int> inputrowIndex = null, [WorkflowExpression] Func<string> inputworksheetToUpdatepath = null, [WorkflowExpression] Func<string> inputworksheetToUpdateworksheetName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/xlsx/clear-cell/by-index";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputcellIndex != null)
                {
                    input["CellIndex"] = SourceExpressionConverter.ConvertToken(inputcellIndex);
                    inputpropCount++;
                }

                if (inputinputFileBytes != null)
                {
                    input["InputFileBytes"] = SourceExpressionConverter.ConvertToken(inputinputFileBytes);
                    inputpropCount++;
                }

                if (inputinputFileUrl != null)
                {
                    input["InputFileUrl"] = SourceExpressionConverter.ConvertToken(inputinputFileUrl);
                    inputpropCount++;
                }

                if (inputrowIndex != null)
                {
                    input["RowIndex"] = SourceExpressionConverter.ConvertToken(inputrowIndex);
                    inputpropCount++;
                }

                var worksheetToUpdateObject = new JObject();
                var worksheetToUpdateObjectpropCount = 0;
                if (inputworksheetToUpdatepath != null)
                {
                    worksheetToUpdateObject["Path"] = SourceExpressionConverter.ConvertToken(inputworksheetToUpdatepath);
                    worksheetToUpdateObjectpropCount++;
                }

                if (inputworksheetToUpdateworksheetName != null)
                {
                    worksheetToUpdateObject["WorksheetName"] = SourceExpressionConverter.ConvertToken(inputworksheetToUpdateworksheetName);
                    worksheetToUpdateObjectpropCount++;
                }

                if (worksheetToUpdateObjectpropCount > 0)
                {
                    input["WorksheetToUpdate"] = worksheetToUpdateObject;
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ClearXlsxCellResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<CreateBlankSpreadsheetResponse> EditDocumentXlsxCreateBlankSpreadsheet([WorkflowExpression] Func<string> inputworksheetName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/xlsx/create/blank";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputworksheetName != null)
                {
                    input["WorksheetName"] = SourceExpressionConverter.ConvertToken(inputworksheetName);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateBlankSpreadsheetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<CreateSpreadsheetFromDataResponse> EditDocumentXlsxCreateSpreadsheetFromData([WorkflowExpression] Func<XlsxSpreadsheetRow[]> inputrows = null, [WorkflowExpression] Func<string> inputworksheetName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/xlsx/create/from/data";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputrows != null)
                {
                    input["Rows"] = SourceExpressionConverter.ConvertToken(inputrows);
                    inputpropCount++;
                }

                if (inputworksheetName != null)
                {
                    input["WorksheetName"] = SourceExpressionConverter.ConvertToken(inputworksheetName);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateSpreadsheetFromDataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<JToken> EditDocumentXlsxDeleteWorksheet([WorkflowExpression] Func<string> reqConfiginputFileBytes = null, [WorkflowExpression] Func<string> reqConfiginputFileUrl = null, [WorkflowExpression] Func<string> reqConfigworksheetToRemovepath = null, [WorkflowExpression] Func<string> reqConfigworksheetToRemoveworksheetName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/xlsx/delete-worksheet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = SourceExpressionConverter.ConvertToken(reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                var worksheetToRemoveObject = new JObject();
                var worksheetToRemoveObjectpropCount = 0;
                if (reqConfigworksheetToRemovepath != null)
                {
                    worksheetToRemoveObject["Path"] = SourceExpressionConverter.ConvertToken(reqConfigworksheetToRemovepath);
                    worksheetToRemoveObjectpropCount++;
                }

                if (reqConfigworksheetToRemoveworksheetName != null)
                {
                    worksheetToRemoveObject["WorksheetName"] = SourceExpressionConverter.ConvertToken(reqConfigworksheetToRemoveworksheetName);
                    worksheetToRemoveObjectpropCount++;
                }

                if (worksheetToRemoveObjectpropCount > 0)
                {
                    reqConfig["WorksheetToRemove"] = worksheetToRemoveObject;
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxCellByIdentifierResponse> EditDocumentXlsxGetCellByIdentifier([WorkflowExpression] Func<string> inputcellIdentifier = null, [WorkflowExpression] Func<string> inputinputFileBytes = null, [WorkflowExpression] Func<string> inputinputFileUrl = null, [WorkflowExpression] Func<string> inputworksheetToQuerypath = null, [WorkflowExpression] Func<string> inputworksheetToQueryworksheetName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/xlsx/get-cell/by-identifier";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputcellIdentifier != null)
                {
                    input["CellIdentifier"] = SourceExpressionConverter.ConvertToken(inputcellIdentifier);
                    inputpropCount++;
                }

                if (inputinputFileBytes != null)
                {
                    input["InputFileBytes"] = SourceExpressionConverter.ConvertToken(inputinputFileBytes);
                    inputpropCount++;
                }

                if (inputinputFileUrl != null)
                {
                    input["InputFileUrl"] = SourceExpressionConverter.ConvertToken(inputinputFileUrl);
                    inputpropCount++;
                }

                var worksheetToQueryObject = new JObject();
                var worksheetToQueryObjectpropCount = 0;
                if (inputworksheetToQuerypath != null)
                {
                    worksheetToQueryObject["Path"] = SourceExpressionConverter.ConvertToken(inputworksheetToQuerypath);
                    worksheetToQueryObjectpropCount++;
                }

                if (inputworksheetToQueryworksheetName != null)
                {
                    worksheetToQueryObject["WorksheetName"] = SourceExpressionConverter.ConvertToken(inputworksheetToQueryworksheetName);
                    worksheetToQueryObjectpropCount++;
                }

                if (worksheetToQueryObjectpropCount > 0)
                {
                    input["WorksheetToQuery"] = worksheetToQueryObject;
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetXlsxCellByIdentifierResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxCellResponse> EditDocumentXlsxGetCellByIndex([WorkflowExpression] Func<int> inputcellIndex = null, [WorkflowExpression] Func<string> inputinputFileBytes = null, [WorkflowExpression] Func<string> inputinputFileUrl = null, [WorkflowExpression] Func<int> inputrowIndex = null, [WorkflowExpression] Func<string> inputworksheetToQuerypath = null, [WorkflowExpression] Func<string> inputworksheetToQueryworksheetName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/xlsx/get-cell/by-index";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputcellIndex != null)
                {
                    input["CellIndex"] = SourceExpressionConverter.ConvertToken(inputcellIndex);
                    inputpropCount++;
                }

                if (inputinputFileBytes != null)
                {
                    input["InputFileBytes"] = SourceExpressionConverter.ConvertToken(inputinputFileBytes);
                    inputpropCount++;
                }

                if (inputinputFileUrl != null)
                {
                    input["InputFileUrl"] = SourceExpressionConverter.ConvertToken(inputinputFileUrl);
                    inputpropCount++;
                }

                if (inputrowIndex != null)
                {
                    input["RowIndex"] = SourceExpressionConverter.ConvertToken(inputrowIndex);
                    inputpropCount++;
                }

                var worksheetToQueryObject = new JObject();
                var worksheetToQueryObjectpropCount = 0;
                if (inputworksheetToQuerypath != null)
                {
                    worksheetToQueryObject["Path"] = SourceExpressionConverter.ConvertToken(inputworksheetToQuerypath);
                    worksheetToQueryObjectpropCount++;
                }

                if (inputworksheetToQueryworksheetName != null)
                {
                    worksheetToQueryObject["WorksheetName"] = SourceExpressionConverter.ConvertToken(inputworksheetToQueryworksheetName);
                    worksheetToQueryObjectpropCount++;
                }

                if (worksheetToQueryObjectpropCount > 0)
                {
                    input["WorksheetToQuery"] = worksheetToQueryObject;
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetXlsxCellResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxColumnsResponse> EditDocumentXlsxGetColumns([WorkflowExpression] Func<string> inputinputFileBytes = null, [WorkflowExpression] Func<string> inputinputFileUrl = null, [WorkflowExpression] Func<string> inputworksheetToQuerypath = null, [WorkflowExpression] Func<string> inputworksheetToQueryworksheetName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/xlsx/get-columns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputinputFileBytes != null)
                {
                    input["InputFileBytes"] = SourceExpressionConverter.ConvertToken(inputinputFileBytes);
                    inputpropCount++;
                }

                if (inputinputFileUrl != null)
                {
                    input["InputFileUrl"] = SourceExpressionConverter.ConvertToken(inputinputFileUrl);
                    inputpropCount++;
                }

                var worksheetToQueryObject = new JObject();
                var worksheetToQueryObjectpropCount = 0;
                if (inputworksheetToQuerypath != null)
                {
                    worksheetToQueryObject["Path"] = SourceExpressionConverter.ConvertToken(inputworksheetToQuerypath);
                    worksheetToQueryObjectpropCount++;
                }

                if (inputworksheetToQueryworksheetName != null)
                {
                    worksheetToQueryObject["WorksheetName"] = SourceExpressionConverter.ConvertToken(inputworksheetToQueryworksheetName);
                    worksheetToQueryObjectpropCount++;
                }

                if (worksheetToQueryObjectpropCount > 0)
                {
                    input["WorksheetToQuery"] = worksheetToQueryObject;
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetXlsxColumnsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxImagesResponse> EditDocumentXlsxGetImages([WorkflowExpression] Func<string> inputinputFileBytes = null, [WorkflowExpression] Func<string> inputinputFileUrl = null, [WorkflowExpression] Func<string> inputworksheetToQuerypath = null, [WorkflowExpression] Func<string> inputworksheetToQueryworksheetName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/xlsx/get-images";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputinputFileBytes != null)
                {
                    input["InputFileBytes"] = SourceExpressionConverter.ConvertToken(inputinputFileBytes);
                    inputpropCount++;
                }

                if (inputinputFileUrl != null)
                {
                    input["InputFileUrl"] = SourceExpressionConverter.ConvertToken(inputinputFileUrl);
                    inputpropCount++;
                }

                var worksheetToQueryObject = new JObject();
                var worksheetToQueryObjectpropCount = 0;
                if (inputworksheetToQuerypath != null)
                {
                    worksheetToQueryObject["Path"] = SourceExpressionConverter.ConvertToken(inputworksheetToQuerypath);
                    worksheetToQueryObjectpropCount++;
                }

                if (inputworksheetToQueryworksheetName != null)
                {
                    worksheetToQueryObject["WorksheetName"] = SourceExpressionConverter.ConvertToken(inputworksheetToQueryworksheetName);
                    worksheetToQueryObjectpropCount++;
                }

                if (worksheetToQueryObjectpropCount > 0)
                {
                    input["WorksheetToQuery"] = worksheetToQueryObject;
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetXlsxImagesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxRowsAndCellsResponse> EditDocumentXlsxGetRowsAndCells([WorkflowExpression] Func<string> inputinputFileBytes = null, [WorkflowExpression] Func<string> inputinputFileUrl = null, [WorkflowExpression] Func<string> inputworksheetToQuerypath = null, [WorkflowExpression] Func<string> inputworksheetToQueryworksheetName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/xlsx/get-rows-and-cells";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputinputFileBytes != null)
                {
                    input["InputFileBytes"] = SourceExpressionConverter.ConvertToken(inputinputFileBytes);
                    inputpropCount++;
                }

                if (inputinputFileUrl != null)
                {
                    input["InputFileUrl"] = SourceExpressionConverter.ConvertToken(inputinputFileUrl);
                    inputpropCount++;
                }

                var worksheetToQueryObject = new JObject();
                var worksheetToQueryObjectpropCount = 0;
                if (inputworksheetToQuerypath != null)
                {
                    worksheetToQueryObject["Path"] = SourceExpressionConverter.ConvertToken(inputworksheetToQuerypath);
                    worksheetToQueryObjectpropCount++;
                }

                if (inputworksheetToQueryworksheetName != null)
                {
                    worksheetToQueryObject["WorksheetName"] = SourceExpressionConverter.ConvertToken(inputworksheetToQueryworksheetName);
                    worksheetToQueryObjectpropCount++;
                }

                if (worksheetToQueryObjectpropCount > 0)
                {
                    input["WorksheetToQuery"] = worksheetToQueryObject;
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetXlsxRowsAndCellsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxStylesResponse> EditDocumentXlsxGetStyles([WorkflowExpression] Func<string> inputinputFileBytes = null, [WorkflowExpression] Func<string> inputinputFileUrl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/xlsx/get-styles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputinputFileBytes != null)
                {
                    input["InputFileBytes"] = SourceExpressionConverter.ConvertToken(inputinputFileBytes);
                    inputpropCount++;
                }

                if (inputinputFileUrl != null)
                {
                    input["InputFileUrl"] = SourceExpressionConverter.ConvertToken(inputinputFileUrl);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetXlsxStylesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxWorksheetsResponse> EditDocumentXlsxGetWorksheets([WorkflowExpression] Func<string> inputinputFileBytes = null, [WorkflowExpression] Func<string> inputinputFileUrl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/xlsx/get-worksheets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputinputFileBytes != null)
                {
                    input["InputFileBytes"] = SourceExpressionConverter.ConvertToken(inputinputFileBytes);
                    inputpropCount++;
                }

                if (inputinputFileUrl != null)
                {
                    input["InputFileUrl"] = SourceExpressionConverter.ConvertToken(inputinputFileUrl);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetXlsxWorksheetsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<InsertXlsxWorksheetResponse> EditDocumentXlsxInsertWorksheet([WorkflowExpression] Func<string> inputinputFileBytes = null, [WorkflowExpression] Func<string> inputinputFileUrl = null, [WorkflowExpression] Func<string> inputworksheetToInsertpath = null, [WorkflowExpression] Func<string> inputworksheetToInsertworksheetName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/xlsx/insert-worksheet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputinputFileBytes != null)
                {
                    input["InputFileBytes"] = SourceExpressionConverter.ConvertToken(inputinputFileBytes);
                    inputpropCount++;
                }

                if (inputinputFileUrl != null)
                {
                    input["InputFileUrl"] = SourceExpressionConverter.ConvertToken(inputinputFileUrl);
                    inputpropCount++;
                }

                var worksheetToInsertObject = new JObject();
                var worksheetToInsertObjectpropCount = 0;
                if (inputworksheetToInsertpath != null)
                {
                    worksheetToInsertObject["Path"] = SourceExpressionConverter.ConvertToken(inputworksheetToInsertpath);
                    worksheetToInsertObjectpropCount++;
                }

                if (inputworksheetToInsertworksheetName != null)
                {
                    worksheetToInsertObject["WorksheetName"] = SourceExpressionConverter.ConvertToken(inputworksheetToInsertworksheetName);
                    worksheetToInsertObjectpropCount++;
                }

                if (worksheetToInsertObjectpropCount > 0)
                {
                    input["WorksheetToInsert"] = worksheetToInsertObject;
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InsertXlsxWorksheetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<SetXlsxCellByIdentifierResponse> EditDocumentXlsxSetCellByIdentifier([WorkflowExpression] Func<string> inputcellIdentifier = null, [WorkflowExpression] Func<string> inputcellValuecellIdentifier = null, [WorkflowExpression] Func<string> inputcellValueformula = null, [WorkflowExpression] Func<string> inputcellValuepath = null, [WorkflowExpression] Func<int> inputcellValuestyleIndex = null, [WorkflowExpression] Func<string> inputcellValuetextValue = null, [WorkflowExpression] Func<string> inputinputFileBytes = null, [WorkflowExpression] Func<string> inputinputFileUrl = null, [WorkflowExpression] Func<string> inputworksheetToUpdatepath = null, [WorkflowExpression] Func<string> inputworksheetToUpdateworksheetName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/xlsx/set-cell/by-identifier";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputcellIdentifier != null)
                {
                    input["CellIdentifier"] = SourceExpressionConverter.ConvertToken(inputcellIdentifier);
                    inputpropCount++;
                }

                var cellValueObject = new JObject();
                var cellValueObjectpropCount = 0;
                if (inputcellValuecellIdentifier != null)
                {
                    cellValueObject["CellIdentifier"] = SourceExpressionConverter.ConvertToken(inputcellValuecellIdentifier);
                    cellValueObjectpropCount++;
                }

                if (inputcellValueformula != null)
                {
                    cellValueObject["Formula"] = SourceExpressionConverter.ConvertToken(inputcellValueformula);
                    cellValueObjectpropCount++;
                }

                if (inputcellValuepath != null)
                {
                    cellValueObject["Path"] = SourceExpressionConverter.ConvertToken(inputcellValuepath);
                    cellValueObjectpropCount++;
                }

                if (inputcellValuestyleIndex != null)
                {
                    cellValueObject["StyleIndex"] = SourceExpressionConverter.ConvertToken(inputcellValuestyleIndex);
                    cellValueObjectpropCount++;
                }

                if (inputcellValuetextValue != null)
                {
                    cellValueObject["TextValue"] = SourceExpressionConverter.ConvertToken(inputcellValuetextValue);
                    cellValueObjectpropCount++;
                }

                if (cellValueObjectpropCount > 0)
                {
                    input["CellValue"] = cellValueObject;
                    inputpropCount++;
                }

                if (inputinputFileBytes != null)
                {
                    input["InputFileBytes"] = SourceExpressionConverter.ConvertToken(inputinputFileBytes);
                    inputpropCount++;
                }

                if (inputinputFileUrl != null)
                {
                    input["InputFileUrl"] = SourceExpressionConverter.ConvertToken(inputinputFileUrl);
                    inputpropCount++;
                }

                var worksheetToUpdateObject = new JObject();
                var worksheetToUpdateObjectpropCount = 0;
                if (inputworksheetToUpdatepath != null)
                {
                    worksheetToUpdateObject["Path"] = SourceExpressionConverter.ConvertToken(inputworksheetToUpdatepath);
                    worksheetToUpdateObjectpropCount++;
                }

                if (inputworksheetToUpdateworksheetName != null)
                {
                    worksheetToUpdateObject["WorksheetName"] = SourceExpressionConverter.ConvertToken(inputworksheetToUpdateworksheetName);
                    worksheetToUpdateObjectpropCount++;
                }

                if (worksheetToUpdateObjectpropCount > 0)
                {
                    input["WorksheetToUpdate"] = worksheetToUpdateObject;
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SetXlsxCellByIdentifierResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<SetXlsxCellResponse> EditDocumentXlsxSetCellByIndex([WorkflowExpression] Func<int> inputcellIndex = null, [WorkflowExpression] Func<string> inputcellValuecellIdentifier = null, [WorkflowExpression] Func<string> inputcellValueformula = null, [WorkflowExpression] Func<string> inputcellValuepath = null, [WorkflowExpression] Func<int> inputcellValuestyleIndex = null, [WorkflowExpression] Func<string> inputcellValuetextValue = null, [WorkflowExpression] Func<string> inputinputFileBytes = null, [WorkflowExpression] Func<string> inputinputFileUrl = null, [WorkflowExpression] Func<int> inputrowIndex = null, [WorkflowExpression] Func<string> inputworksheetToUpdatepath = null, [WorkflowExpression] Func<string> inputworksheetToUpdateworksheetName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/edit/xlsx/set-cell/by-index";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputcellIndex != null)
                {
                    input["CellIndex"] = SourceExpressionConverter.ConvertToken(inputcellIndex);
                    inputpropCount++;
                }

                var cellValueObject = new JObject();
                var cellValueObjectpropCount = 0;
                if (inputcellValuecellIdentifier != null)
                {
                    cellValueObject["CellIdentifier"] = SourceExpressionConverter.ConvertToken(inputcellValuecellIdentifier);
                    cellValueObjectpropCount++;
                }

                if (inputcellValueformula != null)
                {
                    cellValueObject["Formula"] = SourceExpressionConverter.ConvertToken(inputcellValueformula);
                    cellValueObjectpropCount++;
                }

                if (inputcellValuepath != null)
                {
                    cellValueObject["Path"] = SourceExpressionConverter.ConvertToken(inputcellValuepath);
                    cellValueObjectpropCount++;
                }

                if (inputcellValuestyleIndex != null)
                {
                    cellValueObject["StyleIndex"] = SourceExpressionConverter.ConvertToken(inputcellValuestyleIndex);
                    cellValueObjectpropCount++;
                }

                if (inputcellValuetextValue != null)
                {
                    cellValueObject["TextValue"] = SourceExpressionConverter.ConvertToken(inputcellValuetextValue);
                    cellValueObjectpropCount++;
                }

                if (cellValueObjectpropCount > 0)
                {
                    input["CellValue"] = cellValueObject;
                    inputpropCount++;
                }

                if (inputinputFileBytes != null)
                {
                    input["InputFileBytes"] = SourceExpressionConverter.ConvertToken(inputinputFileBytes);
                    inputpropCount++;
                }

                if (inputinputFileUrl != null)
                {
                    input["InputFileUrl"] = SourceExpressionConverter.ConvertToken(inputinputFileUrl);
                    inputpropCount++;
                }

                if (inputrowIndex != null)
                {
                    input["RowIndex"] = SourceExpressionConverter.ConvertToken(inputrowIndex);
                    inputpropCount++;
                }

                var worksheetToUpdateObject = new JObject();
                var worksheetToUpdateObjectpropCount = 0;
                if (inputworksheetToUpdatepath != null)
                {
                    worksheetToUpdateObject["Path"] = SourceExpressionConverter.ConvertToken(inputworksheetToUpdatepath);
                    worksheetToUpdateObjectpropCount++;
                }

                if (inputworksheetToUpdateworksheetName != null)
                {
                    worksheetToUpdateObject["WorksheetName"] = SourceExpressionConverter.ConvertToken(inputworksheetToUpdateworksheetName);
                    worksheetToUpdateObjectpropCount++;
                }

                if (worksheetToUpdateObjectpropCount > 0)
                {
                    input["WorksheetToUpdate"] = worksheetToUpdateObject;
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SetXlsxCellResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertWebHtmlToDocx([WorkflowExpression] Func<string> inputRequesthtml = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/html/to/docx";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputRequest = new JObject();
                var inputRequestpropCount = 0;
                if (inputRequesthtml != null)
                {
                    inputRequest["Html"] = SourceExpressionConverter.ConvertToken(inputRequesthtml);
                    inputRequestpropCount++;
                }

                if (inputRequestpropCount > 0)
                {
                    callPayload.Body = inputRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertDataJsonToXml()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/json/to/xml";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jsonObject = new JObject();
                var jsonObjectpropCount = 0;
                if (jsonObjectpropCount > 0)
                {
                    callPayload.Body = jsonObject;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<HtmlTemplateApplicationResponse> ConvertTemplateApplyHtmlTemplate([WorkflowExpression] Func<string> valuehtmlTemplate = null, [WorkflowExpression] Func<string> valuehtmlTemplateUrl = null, [WorkflowExpression] Func<HtmlTemplateOperation[]> valueoperations = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/template/html/apply";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var value = new JObject();
                var valuepropCount = 0;
                if (valuehtmlTemplate != null)
                {
                    value["HtmlTemplate"] = SourceExpressionConverter.ConvertToken(valuehtmlTemplate);
                    valuepropCount++;
                }

                if (valuehtmlTemplateUrl != null)
                {
                    value["HtmlTemplateUrl"] = SourceExpressionConverter.ConvertToken(valuehtmlTemplateUrl);
                    valuepropCount++;
                }

                if (valueoperations != null)
                {
                    value["Operations"] = SourceExpressionConverter.ConvertToken(valueoperations);
                    valuepropCount++;
                }

                if (valuepropCount > 0)
                {
                    callPayload.Body = value;
                }
                return callPayload;
            }

            return new ApiConnectionAction<HtmlTemplateApplicationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertWebHtmlToPdf([WorkflowExpression] Func<int> inputextraLoadingWait = null, [WorkflowExpression] Func<string> inputhtml = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/web/html/to/pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputextraLoadingWait != null)
                {
                    input["ExtraLoadingWait"] = SourceExpressionConverter.ConvertToken(inputextraLoadingWait);
                    inputpropCount++;
                }

                if (inputhtml != null)
                {
                    input["Html"] = SourceExpressionConverter.ConvertToken(inputhtml);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<JToken> ConvertWebHtmlToPng([WorkflowExpression] Func<int> inputextraLoadingWait = null, [WorkflowExpression] Func<string> inputhtml = null, [WorkflowExpression] Func<int> inputscreenshotHeight = null, [WorkflowExpression] Func<int> inputscreenshotWidth = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/web/html/to/png";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputextraLoadingWait != null)
                {
                    input["ExtraLoadingWait"] = SourceExpressionConverter.ConvertToken(inputextraLoadingWait);
                    inputpropCount++;
                }

                if (inputhtml != null)
                {
                    input["Html"] = SourceExpressionConverter.ConvertToken(inputhtml);
                    inputpropCount++;
                }

                if (inputscreenshotHeight != null)
                {
                    input["ScreenshotHeight"] = SourceExpressionConverter.ConvertToken(inputscreenshotHeight);
                    inputpropCount++;
                }

                if (inputscreenshotWidth != null)
                {
                    input["ScreenshotWidth"] = SourceExpressionConverter.ConvertToken(inputscreenshotWidth);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<HtmlToTextResponse> ConvertWebHtmlToTxt([WorkflowExpression] Func<string> inputhtml = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/web/html/to/txt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputhtml != null)
                {
                    input["Html"] = SourceExpressionConverter.ConvertToken(inputhtml);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<HtmlToTextResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertWebUrlToPdf([WorkflowExpression] Func<int> inputextraLoadingWait = null, [WorkflowExpression] Func<int> inputscreenshotHeight = null, [WorkflowExpression] Func<int> inputscreenshotWidth = null, [WorkflowExpression] Func<string> inputurl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/web/url/to/pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputextraLoadingWait != null)
                {
                    input["ExtraLoadingWait"] = SourceExpressionConverter.ConvertToken(inputextraLoadingWait);
                    inputpropCount++;
                }

                if (inputscreenshotHeight != null)
                {
                    input["ScreenshotHeight"] = SourceExpressionConverter.ConvertToken(inputscreenshotHeight);
                    inputpropCount++;
                }

                if (inputscreenshotWidth != null)
                {
                    input["ScreenshotWidth"] = SourceExpressionConverter.ConvertToken(inputscreenshotWidth);
                    inputpropCount++;
                }

                if (inputurl != null)
                {
                    input["Url"] = SourceExpressionConverter.ConvertToken(inputurl);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertWebUrlToScreenshot([WorkflowExpression] Func<int> inputextraLoadingWait = null, [WorkflowExpression] Func<int> inputscreenshotHeight = null, [WorkflowExpression] Func<int> inputscreenshotWidth = null, [WorkflowExpression] Func<string> inputurl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/web/url/to/screenshot";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputextraLoadingWait != null)
                {
                    input["ExtraLoadingWait"] = SourceExpressionConverter.ConvertToken(inputextraLoadingWait);
                    inputpropCount++;
                }

                if (inputscreenshotHeight != null)
                {
                    input["ScreenshotHeight"] = SourceExpressionConverter.ConvertToken(inputscreenshotHeight);
                    inputpropCount++;
                }

                if (inputscreenshotWidth != null)
                {
                    input["ScreenshotWidth"] = SourceExpressionConverter.ConvertToken(inputscreenshotWidth);
                    inputpropCount++;
                }

                if (inputurl != null)
                {
                    input["Url"] = SourceExpressionConverter.ConvertToken(inputurl);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<UrlToTextResponse> ConvertWebUrlToTxt([WorkflowExpression] Func<string> inputurl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/convert/web/url/to/txt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (inputurl != null)
                {
                    input["Url"] = SourceExpressionConverter.ConvertToken(inputurl);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UrlToTextResponse>(BuildSourceInput);
        }
    }

    public class CloudmersiveconvertTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateBlankDocxResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class DeleteDocxTableRowResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class DeleteDocxTableRowRangeResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class GetDocxBodyResponse
    {
        public DocxBody Body { get; set; }
        public bool Successful { get; set; }
    }

    public class DocxBody
    {
        public DocxParagraph[] AllParagraphs { get; set; }
        public DocxTable[] AllTables { get; set; }
        public string Path { get; set; }
    }

    public class DocxParagraph
    {
        public DocxRun[] ContentRuns { get; set; }
        public int ParagraphIndex { get; set; }
        public string Path { get; set; }
        public string StyleID { get; set; }
    }

    public class DocxRun
    {
        public bool Bold { get; set; }
        public string FontFamily { get; set; }
        public string FontSize { get; set; }
        public bool Italic { get; set; }
        public string Path { get; set; }
        public int RunIndex { get; set; }
        public DocxText[] TextItems { get; set; }
        public string Underline { get; set; }
    }

    public class DocxText
    {
        public string Path { get; set; }
        public string TextContent { get; set; }
        public int TextIndex { get; set; }
    }

    public class DocxTable
    {
        public string BottomBorderColor { get; set; }
        public int BottomBorderSize { get; set; }
        public int BottomBorderSpace { get; set; }
        public string BottomBorderType { get; set; }
        public string CellHorizontalBorderColor { get; set; }
        public int CellHorizontalBorderSize { get; set; }
        public int CellHorizontalBorderSpace { get; set; }
        public string CellHorizontalBorderType { get; set; }
        public string CellVerticalBorderColor { get; set; }
        public int CellVerticalBorderSize { get; set; }
        public int CellVerticalBorderSpace { get; set; }
        public string CellVerticalBorderType { get; set; }
        public string EndBorderColor { get; set; }
        public int EndBorderSize { get; set; }
        public int EndBorderSpace { get; set; }
        public string EndBorderType { get; set; }
        public string LeftBorderColor { get; set; }
        public int LeftBorderSize { get; set; }
        public int LeftBorderSpace { get; set; }
        public string LeftBorderType { get; set; }
        public string Path { get; set; }
        public string RightBorderColor { get; set; }
        public int RightBorderSize { get; set; }
        public int RightBorderSpace { get; set; }
        public string RightBorderType { get; set; }
        public string StartBorderColor { get; set; }
        public int StartBorderSize { get; set; }
        public int StartBorderSpace { get; set; }
        public string StartBorderType { get; set; }
        public string TableID { get; set; }
        public string TableIndentationMode { get; set; }
        public int TableIndentationWidth { get; set; }
        public DocxTableRow[] TableRows { get; set; }
        public string TopBorderColor { get; set; }
        public int TopBorderSize { get; set; }
        public int TopBorderSpace { get; set; }
        public string TopBorderType { get; set; }
        public string Width { get; set; }
        public string WidthType { get; set; }
    }

    public class DocxTableRow
    {
        public string Path { get; set; }
        public DocxTableCell[] RowCells { get; set; }
        public int RowIndex { get; set; }
    }

    public class DocxTableCell
    {
        public int CellIndex { get; set; }
        public string CellShadingColor { get; set; }
        public string CellShadingFill { get; set; }
        public string CellShadingPattern { get; set; }
        public string CellWidth { get; set; }
        public string CellWidthMode { get; set; }
        public DocxParagraph[] Paragraphs { get; set; }
        public string Path { get; set; }
    }

    public class GetDocxCommentsHierarchicalResponse
    {
        public DocxTopLevelComment[] Comments { get; set; }
        public bool Successful { get; set; }
        public int TopLevelCommentCount { get; set; }
    }

    public class DocxTopLevelComment
    {
        public string Author { get; set; }
        public string AuthorInitials { get; set; }
        public string CommentDate { get; set; }
        public string CommentText { get; set; }
        public bool Done { get; set; }
        public string Path { get; set; }
        public DocxComment[] ReplyChildComments { get; set; }
    }

    public class DocxComment
    {
        public string Author { get; set; }
        public string AuthorInitials { get; set; }
        public string CommentDate { get; set; }
        public string CommentText { get; set; }
        public bool Done { get; set; }
        public bool IsReply { get; set; }
        public bool IsTopLevel { get; set; }
        public string ParentCommentPath { get; set; }
        public string Path { get; set; }
    }

    public class GetDocxHeadersAndFootersResponse
    {
        public DocxFooter[] Footers { get; set; }
        public DocxHeader[] Headers { get; set; }
        public bool Successful { get; set; }
    }

    public class DocxFooter
    {
        public DocxParagraph[] Paragraphs { get; set; }
        public string Path { get; set; }
        public DocxSection[] SectionsWithFooter { get; set; }
    }

    public class DocxSection
    {
        public string Path { get; set; }
        public int[] StartingPageNumbers { get; set; }
    }

    public class DocxHeader
    {
        public DocxParagraph[] Paragraphs { get; set; }
        public string Path { get; set; }
        public DocxSection[] SectionsWithHeader { get; set; }
    }

    public class GetDocxImagesResponse
    {
        public DocxImage[] Images { get; set; }
        public bool Successful { get; set; }
    }

    public class DocxImage
    {
        public string ImageContentsURL { get; set; }
        public string ImageDataContentType { get; set; }
        public string ImageDataEmbedId { get; set; }
        public string ImageDescription { get; set; }
        public int ImageHeight { get; set; }
        public int ImageId { get; set; }
        public string ImageInternalFileName { get; set; }
        public string ImageName { get; set; }
        public int ImageWidth { get; set; }
        public bool InlineWithText { get; set; }
        public string Path { get; set; }
        public int XOffset { get; set; }
        public int YOffset { get; set; }
    }

    public class GetDocxPagesResponse
    {
        public int PageCount { get; set; }
        public DocxPage[] Pages { get; set; }
        public bool Successful { get; set; }
    }

    public class DocxPage
    {
        public int PageNumber { get; set; }
        public DocxParagraph[] Paragraphs { get; set; }
    }

    public class GetDocxSectionsResponse
    {
        public DocxSection[] Sections { get; set; }
        public bool Successful { get; set; }
    }

    public class GetDocxStylesResponse
    {
        public DocxStyle[] Styles { get; set; }
        public bool Successful { get; set; }
    }

    public class DocxStyle
    {
        public bool Bold { get; set; }
        public string FontFamily { get; set; }
        public string FontSize { get; set; }
        public bool Italic { get; set; }
        public string Path { get; set; }
        public string StyleID { get; set; }
        public bool Underline { get; set; }
    }

    public class GetDocxTableRowResponse
    {
        public DocxTableRow RowResult { get; set; }
        public bool Successful { get; set; }
    }

    public class GetDocxTableByIndexResponse
    {
        public bool Successful { get; set; }
        public DocxTable Table { get; set; }
    }

    public class GetDocxTablesResponse
    {
        public bool Successful { get; set; }
        public DocxTable[] Tables { get; set; }
    }

    public class InsertDocxCommentOnParagraphResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class DocxInsertImageResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class InsertDocxInsertParagraphResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class InsertDocxTablesResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class InsertDocxTableRowResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class RemoveDocxHeadersAndFootersResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class DocxRemoveObjectResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class DocxSetFooterResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class DocxSetHeaderResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class UpdateDocxTableCellResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class UpdateDocxTableRowResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class ClearXlsxCellResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class CreateBlankSpreadsheetResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class CreateSpreadsheetFromDataResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class XlsxSpreadsheetRow
    {
        public XlsxSpreadsheetCell[] Cells { get; set; }
        public string Path { get; set; }
    }

    public class XlsxSpreadsheetCell
    {
        public string CellIdentifier { get; set; }
        public string Formula { get; set; }
        public string Path { get; set; }
        public int StyleIndex { get; set; }
        public string TextValue { get; set; }
    }

    public class GetXlsxCellByIdentifierResponse
    {
        public XlsxSpreadsheetCell Cell { get; set; }
        public bool Successful { get; set; }
    }

    public class GetXlsxCellResponse
    {
        public XlsxSpreadsheetCell Cell { get; set; }
        public bool Successful { get; set; }
    }

    public class GetXlsxColumnsResponse
    {
        public XlsxSpreadsheetColumn[] Columns { get; set; }
        public bool Successful { get; set; }
    }

    public class XlsxSpreadsheetColumn
    {
        public XlsxSpreadsheetCell HeadingCell { get; set; }
        public string Path { get; set; }
    }

    public class GetXlsxImagesResponse
    {
        public XlsxImage[] Images { get; set; }
        public bool Successful { get; set; }
    }

    public class XlsxImage
    {
        public string ImageContentsURL { get; set; }
        public string ImageDataContentType { get; set; }
        public string ImageDataEmbedId { get; set; }
        public string ImageInternalFileName { get; set; }
        public string Path { get; set; }
    }

    public class GetXlsxRowsAndCellsResponse
    {
        public XlsxSpreadsheetRow[] Rows { get; set; }
        public bool Successful { get; set; }
    }

    public class GetXlsxStylesResponse
    {
        public DocxCellStyle[] CellStyles { get; set; }
        public bool Successful { get; set; }
    }

    public class DocxCellStyle
    {
        public int BuiltInID { get; set; }
        public int FormatID { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
    }

    public class GetXlsxWorksheetsResponse
    {
        public bool Successful { get; set; }
        public XlsxWorksheet[] Worksheets { get; set; }
    }

    public class XlsxWorksheet
    {
        public string Path { get; set; }
        public string WorksheetName { get; set; }
    }

    public class InsertXlsxWorksheetResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class SetXlsxCellByIdentifierResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class SetXlsxCellResponse
    {
        public string EditedDocumentURL { get; set; }
        public bool Successful { get; set; }
    }

    public class HtmlTemplateApplicationResponse
    {
        public string FinalHtml { get; set; }
        public bool Successful { get; set; }
    }

    public class HtmlTemplateOperation
    {
        public HtmlTemplateOperationActionType Action { get; set; }
        public string MatchAgsint { get; set; }
        public string ReplaceWith { get; set; }
    }

    public enum HtmlTemplateOperationActionType
    {
        _1 = 1
    }

    public class HtmlToTextResponse
    {
        public bool Successful { get; set; }
        public string TextContentResult { get; set; }
    }

    public class UrlToTextResponse
    {
        public bool Successful { get; set; }
        public string TextContentResult { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersiveconvert;

    public partial class WorkflowManagedActions
    {
        public CloudmersiveconvertActions Cloudmersiveconvert(string connectionId) => new CloudmersiveconvertActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CloudmersiveconvertTriggers Cloudmersiveconvert(string connectionId) => new CloudmersiveconvertTriggers(connectionId);
    }
}